/*
# Sugar, a UCI chess playing engine derived from Stockfish
# Copyright (C) 2008-2014 Marco Costalba, Joona Kiiski, Tord Romstad
# Sugar is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# Sugar is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
#include <algorithm>
#include <cassert>
#include <cmath>
#include <cstring>
#include <iostream>
#include <sstream>

#include "book.h"
#include "evaluate.h"
#include "movegen.h"
#include "movepick.h"
#include "notation.h"
#include "rkiss.h"
#include "searching.h"
#include "tb_syzygy.h"
#include "timeman.h"
#include "thread.h"
#include "tt.h"
#include "ucioption.h"

bool UCI::Option::BestMoveB;
std::string UCI::Option::MoveToFromB;


namespace Search {

  volatile SignalsType Signals;
  LimitsType Limits;
  std::vector<RootMove> RootMoves;
  Position RootPos;
  Time::point SearchTime;
  StateStackPtr SetupStates;
  int TBCardinality;
  uint64_t TBHits;
  bool RootInTB;
  bool TB50MoveRule;
  Depth TBProbeDepth;
  Value TBScore;
}

using std::string;
using Eval::evaluate;
using namespace Search;

namespace {

  // Different node types, used as template parameter
  enum NodeType { Root, PV, NonPV };

  // Dynamic razoring margin based on depth
  inline Value razor_margin(Depth d) { return Value(512 + 32 * d); }

  // Futility lookup tables (initialized at startup) and their access functions
  int FutilityMoveCounts[2][32]; // [improving][depth]

  inline Value futility_margin(Depth d) {
    return Value(200 * d);
  }

  // Reduction lookup tables (initialized at startup) and their access function
  int8_t Reductions[2][2][64][64]; // [pv][improving][depth][moveNumber]

  template <bool PvNode> inline Depth reduction(bool i, Depth d, int mn) {

    return (Depth) Reductions[PvNode][i][std::min(int(d), 63)][std::min(mn, 63)];
  }

  size_t PVIdx;
  TimeManager TimeMgr;
  double BestMoveChanges;
  Value DrawValue[COLOR_NB];
  HistoryStats History;
  GainsStats Gains;
  MovesStats Countermoves, Followupmoves;

  template <NodeType NT, bool SpNode>
  Value search(Position& pos, Stack* ss, Value alpha, Value beta, Depth depth, bool cutNode);

  template <NodeType NT, bool InCheck>
  Value qsearch(Position& pos, Stack* ss, Value alpha, Value beta, Depth depth);

  void id_loop(Position& pos);
  Value value_to_tt(Value v, int ply);
  Value value_from_tt(Value v, int ply);
  void update_stats(const Position& pos, Stack* ss, Move move, Depth depth, Move* quiets, int quietsCnt);
  string uci_pv(const Position& pos, int depth, Value alpha, Value beta);

  struct Skill {
    Skill(int l, size_t rootSize) : level(l),
                                    candidates(l < 20 ? std::min(4, (int)rootSize) : 0),
                                    best(MOVE_NONE) {}
   ~Skill() {
      if (candidates) // Swap best PV line with the sub-optimal one
          std::swap(RootMoves[0], *std::find(RootMoves.begin(),
                    RootMoves.end(), best ? best : pick_move()));
    }

    size_t candidates_size() const { return candidates; }
    bool time_to_pick(int depth) const { return depth == 1 + level; }
    Move pick_move();

    int level;
    size_t candidates;
    Move best;
  };

} // namespace


/// Search::init() is called during startup to initialize various lookup tables

void Search::init() {

  int d;  // depth (ONE_PLY == 2)
  int hd; // half depth (ONE_PLY == 1)
  int mc; // moveCount

  // Init reductions array
  for (hd = 1; hd < 64; ++hd) for (mc = 1; mc < 64; ++mc)
  {
      double    pvRed = 0.00 + log(double(hd)) * log(double(mc)) / 3.00;
      double nonPVRed = 0.33 + log(double(hd)) * log(double(mc)) / 2.25;
      Reductions[1][1][hd][mc] = int8_t(   pvRed >= 1.0 ?    pvRed * int(ONE_PLY) : 0);
      Reductions[0][1][hd][mc] = int8_t(nonPVRed >= 1.0 ? nonPVRed * int(ONE_PLY) : 0);




      Reductions[1][0][hd][mc] = Reductions[1][1][hd][mc];
      Reductions[0][0][hd][mc] = Reductions[0][1][hd][mc];

      if (Reductions[0][0][hd][mc] > 2 * ONE_PLY)
          Reductions[0][0][hd][mc] += ONE_PLY;

      else if (Reductions[0][0][hd][mc] > 1 * ONE_PLY)
          Reductions[0][0][hd][mc] += ONE_PLY / 2;


  }
  // Init futility move count array
  for (d = 0; d < 32; ++d)
  {
      FutilityMoveCounts[0][d] = int(2.4 + 0.222 * pow(d * 2 + 0.00, 1.8));
      FutilityMoveCounts[1][d] = int(3.0 + 0.300 * pow(d * 2 + 0.98, 1.8));
  }
}


/// Search::perft() is our utility to verify move generation. All the leaf nodes
/// up to the given depth are generated and counted and the sum returned.
template<bool Root>
uint64_t Search::perft(Position& pos, Depth depth) {

  StateInfo st;
  uint64_t cnt, nodes = 0;
  CheckInfo ci(pos);
  const bool leaf = (depth == 2 * ONE_PLY);

  for (MoveList<LEGAL> it(pos); *it; ++it)
  {
      if (Root && depth <= ONE_PLY)
          cnt = 1, nodes++;
      else
      {
          pos.do_move(*it, st, ci, pos.gives_check(*it, ci));
          cnt = leaf ? MoveList<LEGAL>(pos).size() : perft<false>(pos, depth - ONE_PLY);
          nodes += cnt;
          pos.undo_move(*it);
      }
      if (Root)
          sync_cout << move_to_uci(*it, pos.is_chess960()) << ": " << cnt << sync_endl;
  }
  return nodes;
}

template uint64_t Search::perft<true>(Position& pos, Depth depth);


/// Search::think() is the external interface to Stockfish's search, and is
/// called by the main thread when the program receives the UCI 'go' command. It
/// searches from RootPos and at the end prints the "bestmove" to output.

void Search::think() {

  static PolyglotBook book; // Defined static to initialize the PRNG only once
  TimeMgr.init(Limits, RootPos.game_ply(), RootPos.side_to_move());
  int piecesCnt;
  TBHits = TBCardinality = 0;
  RootInTB = false;

  int cf = Options["Contempt value"] * PawnValueEg / 100; // From centipawns
  DrawValue[ RootPos.side_to_move()] = VALUE_DRAW - Value(cf);
  DrawValue[~RootPos.side_to_move()] = VALUE_DRAW + Value(cf);

  if (RootMoves.empty())
  {
      RootMoves.push_back(MOVE_NONE);
      sync_cout << "info depth 0 score "
                << score_to_uci(RootPos.checkers() ? -VALUE_MATE : VALUE_DRAW)
                << sync_endl;

      goto finalize;
  }
  
  if (Options["MasterBook"] && !Limits.infinite && !Limits.mate)

  {
      Move bookMove = book.probe(RootPos, Options["Set_Path Book File"], Options["Book Best Lines Move"]);
	

      if (bookMove && std::count(RootMoves.begin(), RootMoves.end(), bookMove))
      {
          
          std::swap(RootMoves[0], *std::find(RootMoves.begin(), RootMoves.end(), bookMove));
          goto finalize;


      }
  }
  
  if (Options["Write Search Log"])
  {
      Log log(Options["Search Log Filename"]);
      log << "\nSearching: "  << RootPos.fen()
          << "\ninfinite: "   << Limits.infinite
          << " ponder: "      << Limits.ponder
          << " time: "        << Limits.time[RootPos.side_to_move()]
          << " increment: "   << Limits.inc[RootPos.side_to_move()]
          << " moves to go: " << Limits.movestogo
          << "\n" << std::endl;
  }

  piecesCnt = RootPos.total_piece_count();
  TBCardinality = Options["SyzygyProbeLimit"];
  TBProbeDepth = Options["SyzygyProbeDepth"] * ONE_PLY;
  if (TBCardinality > Tablebases::TBLargest)
  {
      TBCardinality = Tablebases::TBLargest;
      TBProbeDepth = 0 * ONE_PLY;
  }
  TB50MoveRule = Options["Syzygy50MoveRule"];

  if (piecesCnt <= TBCardinality)
  {
      TBHits = RootMoves.size();

      // If the current root position is in the tablebases then RootMoves
      // contains only moves that preserve the draw or win.
      RootInTB = Tablebases::root_probe(RootPos, TBScore);

      if (RootInTB)
      {
          TBCardinality = 0; // Do not probe tablebases during the search

          // It might be a good idea to mangle the hash key (xor it
          // with a fixed value) in order to "clear" the hash table of
          // the results of previous probes. However, that would have to
          // be done from within the Position class, so we skip it for now.

          // Optional: decrease target time.
      }
      else // If DTZ tables are missing, use WDL tables as a fallback
      {
          // Filter out moves that do not preserve a draw or win
          RootInTB = Tablebases::root_probe_wdl(RootPos, TBScore);

          // Only probe during search if winning
          if (TBScore <= VALUE_DRAW)
              TBCardinality = 0;
      }

      if (!RootInTB)
      {
          TBHits = 0;
      }
      else if (!TB50MoveRule)
      {
          TBScore = TBScore > VALUE_DRAW ? VALUE_MATE - MAX_PLY - 1
                  : TBScore < VALUE_DRAW ? -VALUE_MATE + MAX_PLY + 1
                  : TBScore;
      }
  }

  // Reset the threads, still sleeping: will wake up at split time
  for (size_t i = 0; i < Threads.size(); ++i)
      Threads[i]->maxPly = 0;

  Threads.timer->run = true;
  Threads.timer->notify_one(); // Wake up the recurring timer

  id_loop(RootPos); // Let's start searching !

  Threads.timer->run = false; // Stop the timer

  if (RootInTB)
  {
      // If we mangled the hash key, unmangle it here
  }

  if (Options["Write Search Log"])
  {
      Time::point elapsed = Time::now() - SearchTime + 1;

      Log log(Options["Search Log Filename"]);
      log << "Nodes: "          << RootPos.nodes_searched()
          << "\nNodes/second: " << RootPos.nodes_searched() * 1000 / elapsed
          << "\nBest move: "    << move_to_san(RootPos, RootMoves[0].pv[0]);

      StateInfo st;
      RootPos.do_move(RootMoves[0].pv[0], st);
      log << "\nPonder move: " << move_to_san(RootPos, RootMoves[0].pv[1]) << std::endl;
      RootPos.undo_move(RootMoves[0].pv[0]);
  }

finalize:
  // When search is stopped this info is not printed
  sync_cout << "info nodes " << RootPos.nodes_searched()
            << " tbhits " << TBHits
            << " time " << Time::now() - SearchTime + 1 << sync_endl;

  // When we reach the maximum depth, we can arrive here without a raise of
  // Signals.stop. However, if we are pondering or in an infinite search,
  // the UCI protocol states that we shouldn't print the best move before the
  // GUI sends a "stop" or "ponderhit" command. We therefore simply wait here
  // until the GUI sends one of those commands (which also raises Signals.stop).
  if (!Signals.stop && (Limits.ponder || Limits.infinite))
  {
      Signals.stopOnPonderhit = true;
      RootPos.this_thread()->wait_for(Signals.stop);
  }

  // Best move could be MOVE_NONE when searching on a stalemate position
  sync_cout << "bestmove " << move_to_uci(RootMoves[0].pv[0], RootPos.is_chess960())
            << " ponder "  << move_to_uci(RootMoves[0].pv[1], RootPos.is_chess960())
            << sync_endl;
}


namespace {

  // id_loop() is the main iterative deepening loop. It calls search() repeatedly
  // with increasing depth until the allocated thinking time has been consumed,
  // user stops the search, or the maximum search depth is reached.

  void id_loop(Position& pos) {
	  
    Stack stack[MAX_PLY_PLUS_6], *ss = stack+2; // To allow referencing (ss-2)
    int depth;
    Value bestValue, alpha, beta, delta;
    std::memset(ss-2, 0, 5 * sizeof(Stack));

    depth = 0;
    BestMoveChanges = 0;
    bestValue = delta = alpha = -VALUE_INFINITE;
    beta = VALUE_INFINITE;

    TT.new_search();
    History.clear();
    Gains.clear();
    Countermoves.clear();
    Followupmoves.clear();

    size_t multiPV = Options["MultiPV"];
    Skill skill(Options["Skill Level"], RootMoves.size());

    // Do we have to play with skill handicap? In this case enable MultiPV search
    // that we will use behind the scenes to retrieve a set of possible moves.
    multiPV = std::max(multiPV, skill.candidates_size());

    // Iterative deepening loop until requested to stop or target depth reached
    while (++depth <= MAX_PLY && !Signals.stop && (!Limits.depth || depth <= Limits.depth))
    {
        // Age out PV variability metric
        BestMoveChanges *= 0.5;

        // Save the last iteration's scores before first PV line is searched and
        // all the move scores except the (new) PV are set to -VALUE_INFINITE.
        for (size_t i = 0; i < RootMoves.size(); ++i)
            RootMoves[i].prevScore = RootMoves[i].score;

        // MultiPV loop. We perform a full root search for each PV line
        for (PVIdx = 0; PVIdx < std::min(multiPV, RootMoves.size()) && !Signals.stop; ++PVIdx)
        {
            // Reset aspiration window starting size
            if (depth >= 5)
            {
                delta = Value(16);
                alpha = std::max(RootMoves[PVIdx].prevScore - delta,-VALUE_INFINITE);
                beta  = std::min(RootMoves[PVIdx].prevScore + delta, VALUE_INFINITE);
            }

            // Start with a small aspiration window and, in the case of a fail
            // high/low, re-search with a bigger window until we're not failing
            // high/low anymore.
            while (true)
            {
                bestValue = search<Root, false>(pos, ss, alpha, beta, depth * ONE_PLY, false);

                // Bring the best move to the front. It is critical that sorting
                // is done with a stable algorithm because all the values but the
                // first and eventually the new best one are set to -VALUE_INFINITE
                // and we want to keep the same order for all the moves except the
                // new PV that goes to the front. Note that in case of MultiPV
                // search the already searched PV lines are preserved.
                std::stable_sort(RootMoves.begin() + PVIdx, RootMoves.end());

                // Write PV back to transposition table in case the relevant
                // entries have been overwritten during the search.
                for (size_t i = 0; i <= PVIdx; ++i)
                    RootMoves[i].insert_pv_in_tt(pos);

                // If search has been stopped break immediately. Sorting and
                // writing PV back to TT is safe because RootMoves is still
                // valid, although it refers to previous iteration.
                if (Signals.stop)
                    break;

                // When failing high/low give some update (without cluttering
                // the UI) before a re-search.
                if (  (bestValue <= alpha || bestValue >= beta)
                    && Time::now() - SearchTime > 3000)
                    sync_cout << uci_pv(pos, depth, alpha, beta) << sync_endl;

                // In case of failing low/high increase aspiration window and
                // re-search, otherwise exit the loop.
                if (bestValue <= alpha)
                {
                    alpha = std::max(bestValue - delta, -VALUE_INFINITE);

                    Signals.failedLowAtRoot = true;
                    Signals.stopOnPonderhit = false;
                }
                else if (bestValue >= beta)
                    beta = std::min(bestValue + delta, VALUE_INFINITE);

                else
                    break;

                delta += 3 * delta / 8;

                assert(alpha >= -VALUE_INFINITE && beta <= VALUE_INFINITE);
            }

            // Sort the PV lines searched so far and update the GUI
            std::stable_sort(RootMoves.begin(), RootMoves.begin() + PVIdx + 1);

            if (PVIdx + 1 == std::min(multiPV, RootMoves.size()) || Time::now() - SearchTime > 3000)
                sync_cout << uci_pv(pos, depth, alpha, beta) << sync_endl;
        }

        // If skill levels are enabled and time is up, pick a sub-optimal best move
        if (skill.candidates_size() && skill.time_to_pick(depth))
            skill.pick_move();

        if (Options["Write Search Log"])
        {
            RootMove& rm = RootMoves[0];
            if (skill.best != MOVE_NONE)
                rm = *std::find(RootMoves.begin(), RootMoves.end(), skill.best);

            Log log(Options["Search Log Filename"]);
            log << pretty_pv(pos, depth, rm.score, Time::now() - SearchTime, &rm.pv[0])
                << std::endl;
        }

        // Have we found a "mate in x"?
        if (   Limits.mate
            && bestValue >= VALUE_MATE_IN_MAX_PLY
            && VALUE_MATE - bestValue <= 2 * Limits.mate)
            Signals.stop = true;

        // Do we have time for the next iteration? Can we stop searching now?
        if (Limits.use_time_management() && !Signals.stop && !Signals.stopOnPonderhit)
        {
            // Take some extra time if the best move has changed
            if (depth > 4 && multiPV == 1)
                TimeMgr.pv_instability(BestMoveChanges);

            // Stop the search if only one legal move is available or all
            // of the available time has been used.
            if (   RootMoves.size() == 1
                || Time::now() - SearchTime > TimeMgr.available_time())
            {
                // If we are allowed to ponder do not stop the search now but
                // keep pondering until the GUI sends "ponderhit" or "stop".
                if (Limits.ponder)
                    Signals.stopOnPonderhit = true;
                else
                    Signals.stop = true;
            }
        }
    }





  }
  std::string square(Square s) {
	  return std::string{ char('a' + file_of(s)), char('1' + rank_of(s)) };
  }// namespace
  std::string moveB(Move m, bool chess960) {

	  Square from = from_sq(m);
	  Square to = to_sq(m);

	  if (m == MOVE_NONE)
		  return "(none)";

	  if (m == MOVE_NULL)
		  return "0000";

	  if (type_of(m) == CASTLING && !chess960)
		  to = make_square(to > from ? FILE_G : FILE_C, rank_of(from));

	  string move = square(from) + square(to);
	  if (type_of(m) == PROMOTION)
		  move += " pnbrqk"[promotion_type(m)];

	  if (UCI::Option::BestMoveB)
		  UCI::Option::MoveToFromB = move;
	  return move;
  }
 
  // search<>() is the main search function for both PV and non-PV nodes and for
  // normal and SplitPoint nodes. When called just after a split point the search
  // is simpler because we have already probed the hash table, done a null move
  // search, and searched the first move before splitting, so we don't have to
  // repeat all this work again. We also don't need to store anything to the hash
  // table here: This is taken care of after we return from the split point.

  template <NodeType NT, bool SpNode>
  Value search(Position& pos, Stack* ss, Value alpha, Value beta, Depth depth, bool cutNode) {

    const bool RootNode = NT == Root;
    const bool PvNode   = NT == PV || NT == Root;

    assert(-VALUE_INFINITE <= alpha && alpha < beta && beta <= VALUE_INFINITE);
    assert(PvNode || (alpha == beta - 1));
    assert(depth > DEPTH_ZERO);

    Move quietsSearched[64];
    StateInfo st;
    const TTEntry *tte;
    SplitPoint* splitPoint;
    Key posKey;
    Move ttMove, move, excludedMove, bestMove;
    Depth ext, newDepth, predictedDepth;
    Value bestValue, value, ttValue, eval, nullValue, futilityValue;
    bool inCheck, givesCheck, pvMove, singularExtensionNode, improving;
    bool captureOrPromotion, dangerous, doFullDepthSearch;
    int moveCount, quietCount;

    // Step 1. Initialize node
    Thread* thisThread = pos.this_thread();
    inCheck = pos.checkers();

    if (SpNode)
    {
        splitPoint = ss->splitPoint;
        bestMove   = splitPoint->bestMove;
        bestValue  = splitPoint->bestValue;
        tte = NULL;
        ttMove = excludedMove = MOVE_NONE;
        ttValue = VALUE_NONE;

        assert(splitPoint->bestValue > -VALUE_INFINITE && splitPoint->moveCount > 0);

        goto moves_loop;
    }

    moveCount = quietCount = 0;
    bestValue = -VALUE_INFINITE;
    ss->currentMove = ss->ttMove = (ss+1)->excludedMove = bestMove = MOVE_NONE;
    ss->ply = (ss-1)->ply + 1;
    (ss+1)->skipNullMove = (ss+1)->nullChild = false; (ss+1)->reduction = DEPTH_ZERO;
    (ss+2)->killers[0] = (ss+2)->killers[1] = MOVE_NONE;

    // Used to send selDepth info to GUI
    if (PvNode && thisThread->maxPly < ss->ply)
        thisThread->maxPly = ss->ply;

    if (!RootNode)
    {
        // Step 2. Check for aborted search and immediate draw
        if (Signals.stop || pos.is_draw() || ss->ply > MAX_PLY)
            return ss->ply > MAX_PLY && !inCheck ? evaluate(pos) : DrawValue[pos.side_to_move()];

        // Step 3. Mate distance pruning. Even if we mate at the next move our score
        // would be at best mate_in(ss->ply+1), but if alpha is already bigger because
        // a shorter mate was found upward in the tree then there is no need to search
        // because we will never beat the current alpha. Same logic but with reversed
        // signs applies also in the opposite condition of being mated instead of giving
        // mate. In this case return a fail-high score.
        alpha = std::max(mated_in(ss->ply), alpha);
        beta = std::min(mate_in(ss->ply+1), beta);
        if (alpha >= beta)
            return alpha;
    }

    // Step 4. Transposition table lookup
    // We don't want the score of a partial search to overwrite a previous full search
    // TT value, so we use a different position key in case of an excluded move.
    excludedMove = ss->excludedMove;
    posKey = excludedMove ? pos.exclusion_key() : pos.key();
    tte = TT.probe(posKey);
    ss->ttMove = ttMove = RootNode ? RootMoves[PVIdx].pv[0] : tte ? tte->move() : MOVE_NONE;
    ttValue = tte ? value_from_tt(tte->value(), ss->ply) : VALUE_NONE;

    // At PV nodes we check for exact scores, whilst at non-PV nodes we check for
    // a fail high/low. The biggest advantage to probing at PV nodes is to have a
    // smooth experience in analysis mode. We don't probe at Root nodes otherwise
    // we should also update RootMoveList to avoid bogus output.
    if (   !RootNode
        && tte
        && tte->depth() >= depth
        && ttValue != VALUE_NONE // Only in case of TT access race
        && (           PvNode ?  tte->bound() == BOUND_EXACT
            : ttValue >= beta ? (tte->bound() &  BOUND_LOWER)
                              : (tte->bound() &  BOUND_UPPER)))
    {
        ss->currentMove = ttMove; // Can be MOVE_NONE

        // If ttMove is quiet, update killers, history, counter move and followup move on TT hit
        if (ttValue >= beta && ttMove && !pos.capture_or_promotion(ttMove) && !inCheck)
            update_stats(pos, ss, ttMove, depth, NULL, 0);

        return ttValue;
    }

    // Step 4a. Tablebase probe
    if (   !RootNode
        && pos.total_piece_count() <= TBCardinality
        && ( pos.total_piece_count() < TBCardinality || depth >= TBProbeDepth )
        && pos.rule50_count() == 0)
    {
        int found, v = Tablebases::probe_wdl(pos, &found);

        if (found)
        {
            TBHits++;

            if (TB50MoveRule) {
                value = v < -1 ? -VALUE_MATE + MAX_PLY + ss->ply
                      : v >  1 ?  VALUE_MATE - MAX_PLY - ss->ply
                      : VALUE_DRAW + 2 * v;
            }
            else
            {
                value = v < 0 ? -VALUE_MATE + MAX_PLY + ss->ply
                      : v > 0 ?  VALUE_MATE - MAX_PLY - ss->ply
                      : VALUE_DRAW;
            }

            TT.store(posKey, value_to_tt(value, ss->ply), BOUND_EXACT,
                     depth + 6 * ONE_PLY, MOVE_NONE, VALUE_NONE);

            return value;
        }
    }

    // Step 5. Evaluate the position statically and update parent's gain statistics
    if (inCheck)
    {
        ss->staticEval = eval = VALUE_NONE;
        goto moves_loop;
    }

    else if (tte)
    {
        // Never assume anything on values stored in TT
        if ((ss->staticEval = eval = tte->eval_value()) == VALUE_NONE)
            eval = ss->staticEval = evaluate(pos);

        // Can ttValue be used as a better position evaluation?
        if (ttValue != VALUE_NONE)
            if (tte->bound() & (ttValue > eval ? BOUND_LOWER : BOUND_UPPER))
                eval = ttValue;
    }
    else
    {


        eval = ss->staticEval =
        (ss-1)->currentMove != MOVE_NULL ? evaluate(pos) : -(ss-1)->staticEval + 2 * Eval::Tempo;

        TT.store(posKey, VALUE_NONE, BOUND_NONE, DEPTH_NONE, MOVE_NONE, ss->staticEval);
    }

    if (   !pos.captured_piece_type()
        &&  ss->staticEval != VALUE_NONE
        && (ss-1)->staticEval != VALUE_NONE
        && (move = (ss-1)->currentMove) != MOVE_NULL
        &&  move != MOVE_NONE
        &&  type_of(move) == NORMAL)
    {
        Square to = to_sq(move);
        Gains.update(pos.piece_on(to), to, -(ss-1)->staticEval - ss->staticEval);
    }

    // Step 6. Razoring (skipped when in check)
    if (   !PvNode
        &&  depth < 4 * ONE_PLY
        &&  eval + razor_margin(depth) <= alpha
        &&  ttMove == MOVE_NONE
        && !pos.pawn_on_7th(pos.side_to_move()))
    {
        if (   depth <= ONE_PLY
            && eval + razor_margin(3 * ONE_PLY) <= alpha)
            return qsearch<NonPV, false>(pos, ss, alpha, beta, DEPTH_ZERO);

        Value ralpha = alpha - razor_margin(depth);
        Value v = qsearch<NonPV, false>(pos, ss, ralpha, ralpha+1, DEPTH_ZERO);
        if (v <= ralpha)
            return v;
    }

    // Step 7. Futility pruning: child node (skipped when in check)
    if (   !PvNode
        && !ss->skipNullMove
        &&  depth < 7 * ONE_PLY
        &&  eval - futility_margin(depth) >= beta

        &&  eval < VALUE_KNOWN_WIN  // Do not return unproven wins
        &&  pos.non_pawn_material(pos.side_to_move()))
        return eval - futility_margin(depth);

    // Step 8. Null move search with verification search (is omitted in PV nodes)
    if (   !PvNode
        && !ss->skipNullMove
        &&  depth >= 2 * ONE_PLY
        &&  eval >= beta
        &&  pos.non_pawn_material(pos.side_to_move()))
    {
        ss->currentMove = MOVE_NULL;

        assert(eval - beta >= 0);

        // Null move dynamic reduction based on depth and value
        Depth R = (3 + depth / 4 + std::min(int(eval - beta) / PawnValueMg, 3)) * ONE_PLY;






        pos.do_null_move(st);
        (ss+1)->skipNullMove = (ss+1)->nullChild = true;
        nullValue = depth-R < ONE_PLY ? -qsearch<NonPV, false>(pos, ss+1, -beta, -beta+1, DEPTH_ZERO)
                                      : - search<NonPV, false>(pos, ss+1, -beta, -beta+1, depth-R, !cutNode);
        (ss+1)->skipNullMove = (ss+1)->nullChild = false;
        pos.undo_null_move();

        if (nullValue >= beta)
        {
            // Do not return unproven mate scores
            if (nullValue >= VALUE_MATE_IN_MAX_PLY)
                nullValue = beta;

            if (depth < 12 * ONE_PLY && abs(beta) < VALUE_KNOWN_WIN)
                return nullValue;

            // Do verification search at high depths
            ss->skipNullMove = true;
            Value v = depth-R < ONE_PLY ? qsearch<NonPV, false>(pos, ss, beta-1, beta, DEPTH_ZERO)
                                        :  search<NonPV, false>(pos, ss, beta-1, beta, depth-R, false);
            ss->skipNullMove = false;

            if (v >= beta)
                return nullValue;
        }
    }

    // Step 9. ProbCut (skipped when in check)
    // If we have a very good capture (i.e. SEE > seeValues[captured_piece_type])
    // and a reduced search returns a value much above beta, we can (almost) safely
    // prune the previous move.
    if (   !PvNode
        &&  depth >= 5 * ONE_PLY
        && !ss->skipNullMove
        &&  abs(beta) < VALUE_MATE_IN_MAX_PLY)
    {
        Value rbeta = std::min(beta + 200, VALUE_INFINITE);
        Depth rdepth = depth - 4 * ONE_PLY;

        assert(rdepth >= ONE_PLY);
        assert((ss-1)->currentMove != MOVE_NONE);
        assert((ss-1)->currentMove != MOVE_NULL);

        MovePicker mp(pos, ttMove, History, pos.captured_piece_type());
        CheckInfo ci(pos);

        while ((move = mp.next_move<false>()) != MOVE_NONE)
            if (pos.legal(move, ci.pinned))
            {
                ss->currentMove = move;
                pos.do_move(move, st, ci, pos.gives_check(move, ci));
                value = -search<NonPV, false>(pos, ss+1, -rbeta, -rbeta+1, rdepth, !cutNode);
                pos.undo_move(move);
                if (value >= rbeta)
                    return value;
            }
    }

    // Step 10. Internal iterative deepening (skipped when in check)
    if (    depth >= (PvNode ? 5 * ONE_PLY : 8 * ONE_PLY)
        && !ttMove
        && (PvNode || ss->staticEval + 256 >= beta))
    {
        Depth d = depth - 2 * ONE_PLY - (PvNode ? DEPTH_ZERO : depth / 4);


        ss->skipNullMove = true;
        search<PvNode ? PV : NonPV, false>(pos, ss, alpha, beta, d, true);
        ss->skipNullMove = false;

        tte = TT.probe(posKey);
        ttMove = tte ? tte->move() : MOVE_NONE;
    }

moves_loop: // When in check and at SpNode search starts from here

    Square prevMoveSq = to_sq((ss-1)->currentMove);
    Move countermoves[] = { Countermoves[pos.piece_on(prevMoveSq)][prevMoveSq].first,
                            Countermoves[pos.piece_on(prevMoveSq)][prevMoveSq].second };

    Square prevOwnMoveSq = to_sq((ss-2)->currentMove);
    Move followupmoves[] = { Followupmoves[pos.piece_on(prevOwnMoveSq)][prevOwnMoveSq].first,
                             Followupmoves[pos.piece_on(prevOwnMoveSq)][prevOwnMoveSq].second };

    MovePicker mp(pos, ttMove, depth, History, countermoves, followupmoves, ss);
    CheckInfo ci(pos);
    value = bestValue; // Workaround a bogus 'uninitialized' warning under gcc
    improving =   ss->staticEval >= (ss-2)->staticEval
               || ss->staticEval == VALUE_NONE
               ||(ss-2)->staticEval == VALUE_NONE;

    singularExtensionNode =   !RootNode
                           && !SpNode
                           &&  depth >= 8 * ONE_PLY
                           &&  abs(beta) < VALUE_KNOWN_WIN
                           &&  ttMove != MOVE_NONE
                       /*  &&  ttValue != VALUE_NONE Already implicit in the next condition */
                           &&  abs(ttValue) < VALUE_KNOWN_WIN
                           && !excludedMove // Recursive singular search is not allowed
                           && (tte->bound() & BOUND_LOWER)
                           &&  tte->depth() >= depth - 3 * ONE_PLY;

    // Step 11. Loop through moves
    // Loop through all pseudo-legal moves until no moves remain or a beta cutoff occurs
    while ((move = mp.next_move<SpNode>()) != MOVE_NONE)
    {
      assert(is_ok(move));

      if (move == excludedMove)
          continue;

      // At root obey the "searchmoves" option and skip moves not listed in Root
      // Move List. As a consequence any illegal move is also skipped. In MultiPV
      // mode we also skip PV moves which have been already searched.
      if (RootNode && !std::count(RootMoves.begin() + PVIdx, RootMoves.end(), move))
          continue;

      if (SpNode)
      {
          // Shared counter cannot be decremented later if the move turns out to be illegal
          if (!pos.legal(move, ci.pinned))
              continue;

          moveCount = ++splitPoint->moveCount;
          splitPoint->mutex.unlock();
      }
      else
          ++moveCount;

      if (RootNode)
      {
          Signals.firstRootMove = (moveCount == 1);

          if (thisThread == Threads.main() && Time::now() - SearchTime > 3000)
              sync_cout << "info depth " << depth / ONE_PLY
                        << " currmove " << move_to_uci(move, pos.is_chess960())
                        << " currmovenumber " << moveCount + PVIdx << sync_endl;
      }

      ext = DEPTH_ZERO;
      captureOrPromotion = pos.capture_or_promotion(move);

      givesCheck =  type_of(move) == NORMAL && !ci.dcCandidates
                  ? ci.checkSq[type_of(pos.piece_on(from_sq(move)))] & to_sq(move)
                  : pos.gives_check(move, ci);

      dangerous =   givesCheck
                 || type_of(move) != NORMAL
                 || pos.advanced_pawn_push(move);

      // Step 12. Extend checks
      if (givesCheck && pos.see_sign(move) >= VALUE_ZERO)
          ext = ONE_PLY;

      // Singular extension search. If all moves but one fail low on a search of
      // (alpha-s, beta-s), and just one fails high on (alpha, beta), then that move
      // is singular and should be extended. To verify this we do a reduced search
      // on all the other moves but the ttMove and if the result is lower than
      // ttValue minus a margin then we extend the ttMove.
      if (    singularExtensionNode
          &&  move == ttMove
          && !ext
          &&  pos.legal(move, ci.pinned))
      {
          Value rBeta = ttValue - int(2 * depth);
          ss->excludedMove = move;
          ss->skipNullMove = true;
          value = search<NonPV, false>(pos, ss, rBeta - 1, rBeta, depth / 2, cutNode);
          ss->skipNullMove = false;
          ss->excludedMove = MOVE_NONE;

          if (value < rBeta)
              ext = ONE_PLY;
      }

      // Update the current move (this must be done after singular extension search)
      newDepth = depth - ONE_PLY + ext;

      // Step 13. Pruning at shallow depth (exclude PV nodes)
      if (   !PvNode
          && !captureOrPromotion
          && !inCheck
          && !dangerous
       /* &&  move != ttMove Already implicit in the next condition */
          &&  bestValue > VALUE_MATED_IN_MAX_PLY)
      {
          // Move count based pruning
          if (   depth < 16 * ONE_PLY
              && moveCount >= FutilityMoveCounts[improving][depth])
          {
              if (SpNode)
                  splitPoint->mutex.lock();

              continue;
          }

          predictedDepth = newDepth - reduction<PvNode>(improving, depth, moveCount);

          // Futility pruning: parent node
          if (predictedDepth < 7 * ONE_PLY)
          {
              futilityValue =  ss->staticEval + futility_margin(predictedDepth)
                             + 128 + Gains[pos.moved_piece(move)][to_sq(move)];

              if (futilityValue <= alpha)
              {
                  bestValue = std::max(bestValue, futilityValue);

                  if (SpNode)
                  {
                      splitPoint->mutex.lock();
                      if (bestValue > splitPoint->bestValue)
                          splitPoint->bestValue = bestValue;
                  }
                  continue;
              }
          }

          // Prune moves with negative SEE at low depths
          if (predictedDepth < 4 * ONE_PLY && pos.see_sign(move) < VALUE_ZERO)
          {
              if (SpNode)
                  splitPoint->mutex.lock();

              continue;
          }
      }

      // Check for legality just before making the move
      if (!RootNode && !SpNode && !pos.legal(move, ci.pinned))
      {
          moveCount--;
          continue;
      }

      pvMove = PvNode && moveCount == 1;
      ss->currentMove = move;
      if (!SpNode && !captureOrPromotion && quietCount < 64)
          quietsSearched[quietCount++] = move;

      // Step 14. Make the move
      pos.do_move(move, st, ci, givesCheck);

      // Step 15. Reduced depth search (LMR). If the move fails high it will be
      // re-searched at full depth.
      if (    depth >= 3 * ONE_PLY
          && !pvMove
          && !captureOrPromotion
          &&  move != ttMove
          &&  move != ss->killers[0]
          &&  move != ss->killers[1])
      {
          ss->reduction = reduction<PvNode>(improving, depth, moveCount);



          if (   (!PvNode && cutNode)
              ||  History[pos.piece_on(to_sq(move))][to_sq(move)] < 0)
              ss->reduction += ONE_PLY;

          if (move == countermoves[0] || move == countermoves[1])
              ss->reduction = std::max(DEPTH_ZERO, ss->reduction - ONE_PLY);

          // Decrease reduction for moves that escape a capture
          if (   ss->reduction
              && type_of(move) == NORMAL
              && type_of(pos.piece_on(to_sq(move))) != PAWN
              && pos.see(make_move(to_sq(move), from_sq(move))) < 0)
              ss->reduction = std::max(DEPTH_ZERO, ss->reduction - ONE_PLY);

          Depth d = std::max(newDepth - ss->reduction, ONE_PLY);
          if (SpNode)
              alpha = splitPoint->alpha;

          value = -search<NonPV, false>(pos, ss+1, -(alpha+1), -alpha, d, true);

          // Re-search at intermediate depth if reduction is very high
          if (value > alpha && ss->reduction >= 4 * ONE_PLY)
          {
              Depth d2 = std::max(newDepth - 2 * ONE_PLY, ONE_PLY);
              value = -search<NonPV, false>(pos, ss+1, -(alpha+1), -alpha, d2, true);
          }

          doFullDepthSearch = (value > alpha && ss->reduction != DEPTH_ZERO);
          ss->reduction = DEPTH_ZERO;
      }
      else
          doFullDepthSearch = !pvMove;

      // Step 16. Full depth search, when LMR is skipped or fails high
      if (doFullDepthSearch)
      {
          if (SpNode)
              alpha = splitPoint->alpha;

          value = newDepth <   ONE_PLY ?
                            givesCheck ? -qsearch<NonPV,  true>(pos, ss+1, -(alpha+1), -alpha, DEPTH_ZERO)
                                       : -qsearch<NonPV, false>(pos, ss+1, -(alpha+1), -alpha, DEPTH_ZERO)
                                       : - search<NonPV, false>(pos, ss+1, -(alpha+1), -alpha, newDepth, !cutNode);
      }

      // For PV nodes only, do a full PV search on the first move or after a fail
      // high (in the latter case search only if value < beta), otherwise let the
      // parent node fail low with value <= alpha and to try another move.
      if (PvNode && (pvMove || (value > alpha && (RootNode || value < beta))))
          value = newDepth <   ONE_PLY ?
                            givesCheck ? -qsearch<PV,  true>(pos, ss+1, -beta, -alpha, DEPTH_ZERO)
                                       : -qsearch<PV, false>(pos, ss+1, -beta, -alpha, DEPTH_ZERO)
                                       : - search<PV, false>(pos, ss+1, -beta, -alpha, newDepth, false);
      // Step 17. Undo move
      pos.undo_move(move);

      assert(value > -VALUE_INFINITE && value < VALUE_INFINITE);

      // Step 18. Check for new best move
      if (SpNode)
      {
          splitPoint->mutex.lock();
          bestValue = splitPoint->bestValue;
          alpha = splitPoint->alpha;
      }

      // Finished searching the move. If a stop or a cutoff occurred, the return
      // value of the search cannot be trusted, and we return immediately without
      // updating best move, PV and TT.
      if (Signals.stop || thisThread->cutoff_occurred())
          return VALUE_ZERO;

      if (RootNode)
      {
          RootMove& rm = *std::find(RootMoves.begin(), RootMoves.end(), move);

          // PV move or new best move ?
          if (pvMove || value > alpha)
          {
              rm.score = value;
              rm.extract_pv_from_tt(pos);

              // We record how often the best move has been changed in each
              // iteration. This information is used for time management: When
              // the best move changes frequently, we allocate some more time.
              if (!pvMove)
                  ++BestMoveChanges;
          }
          else
              // All other moves but the PV are set to the lowest value: this is
              // not a problem when sorting because the sort is stable and the
              // move position in the list is preserved - just the PV is pushed up.
              rm.score = -VALUE_INFINITE;
      }

      if (value > bestValue)
      {
          bestValue = SpNode ? splitPoint->bestValue = value : value;

          if (value > alpha)
          {
              bestMove = SpNode ? splitPoint->bestMove = move : move;

              if (PvNode && value < beta) // Update alpha! Always alpha < beta
                  alpha = SpNode ? splitPoint->alpha = value : value;
              else
              {
                  assert(value >= beta); // Fail high

                  if (SpNode)
                      splitPoint->cutoff = true;

                  break;
              }
          }
      }

      // Step 19. Check for splitting the search
      if (   !SpNode
          &&  Threads.size() >= 2
          &&  depth >= Threads.minimumSplitDepth
          &&  (   !thisThread->activeSplitPoint
               || !thisThread->activeSplitPoint->allSlavesSearching)
          &&  thisThread->splitPointsSize < MAX_SPLITPOINTS_PER_THREAD)
      {
          assert(bestValue > -VALUE_INFINITE && bestValue < beta);

          thisThread->split(pos, ss, alpha, beta, &bestValue, &bestMove,
                            depth, moveCount, &mp, NT, cutNode);

          if (Signals.stop || thisThread->cutoff_occurred())
              return VALUE_ZERO;

          if (bestValue >= beta)
              break;
      }
    }

	if (SpNode) {
		UCI::Option::BestMoveB = true;
		moveB(bestMove, pos.is_chess960()); 
		UCI::Option::BestMoveB = false;

		return bestValue;
	}

    // Following condition would detect a stop or a cutoff set only after move
    // loop has been completed. But in this case bestValue is valid because we
    // have fully searched our subtree, and we can anyhow save the result in TT.
    /*
       if (Signals.stop || thisThread->cutoff_occurred())
        return VALUE_DRAW;
    */

    // Step 20. Check for mate and stalemate
    // All legal moves have been searched and if there are no legal moves, itUCI::Option::BestMove
    // must be mate or stalemate. If we are in a singular extension search then
    // return a fail low score.
    if (!moveCount)
        bestValue = excludedMove ? alpha
                   :     inCheck ? mated_in(ss->ply) : DrawValue[pos.side_to_move()];

    // Quiet best move: update killers, history, countermoves and followupmoves
    else if (bestValue >= beta && !pos.capture_or_promotion(bestMove) && !inCheck)
        update_stats(pos, ss, bestMove, depth, quietsSearched, quietCount - 1);

    TT.store(posKey, value_to_tt(bestValue, ss->ply),
             bestValue >= beta  ? BOUND_LOWER :
             PvNode && bestMove ? BOUND_EXACT : BOUND_UPPER,
             depth, bestMove, ss->staticEval);

    assert(bestValue > -VALUE_INFINITE && bestValue < VALUE_INFINITE);
	UCI::Option::BestMoveB = true;
	moveB(bestMove, pos.is_chess960());
	UCI::Option::BestMoveB = false;

    return bestValue;
  }


  // qsearch() is the quiescence search function, which is called by the main
  // search function when the remaining depth is zero (or, to be more precise,
  // less than ONE_PLY).

  template <NodeType NT, bool InCheck>
  Value qsearch(Position& pos, Stack* ss, Value alpha, Value beta, Depth depth) {

    const bool PvNode = NT == PV;

    assert(NT == PV || NT == NonPV);
    assert(InCheck == !!pos.checkers());
    assert(alpha >= -VALUE_INFINITE && alpha < beta && beta <= VALUE_INFINITE);
    assert(PvNode || (alpha == beta - 1));
    assert(depth <= DEPTH_ZERO);

    StateInfo st;
    const TTEntry* tte;
    Key posKey;
    Move ttMove, move, bestMove;
    Value bestValue, value, ttValue, futilityValue, futilityBase, oldAlpha;
    bool givesCheck, evasionPrunable;
    Depth ttDepth;

    // To flag BOUND_EXACT a node with eval above alpha and no available moves
    if (PvNode)
        oldAlpha = alpha;

    ss->currentMove = bestMove = MOVE_NONE;
    ss->ply = (ss-1)->ply + 1;

    // Check for an instant draw or if the maximum ply has been reached
    if (pos.is_draw() || ss->ply > MAX_PLY)
        return ss->ply > MAX_PLY && !InCheck ? evaluate(pos) : DrawValue[pos.side_to_move()];

    // Decide whether or not to include checks: this fixes also the type of
    // TT entry depth that we are going to use. Note that in qsearch we use
    // only two types of depth in TT: DEPTH_QS_CHECKS or DEPTH_QS_NO_CHECKS.
    ttDepth = InCheck || depth >= DEPTH_QS_CHECKS ? DEPTH_QS_CHECKS
                                                  : DEPTH_QS_NO_CHECKS;

    // Transposition table lookup
    posKey = pos.key();
    tte = TT.probe(posKey);
    ttMove = tte ? tte->move() : MOVE_NONE;
    ttValue = tte ? value_from_tt(tte->value(),ss->ply) : VALUE_NONE;

    if (   tte
        && tte->depth() >= ttDepth
        && ttValue != VALUE_NONE // Only in case of TT access race
        && (           PvNode ?  tte->bound() == BOUND_EXACT
            : ttValue >= beta ? (tte->bound() &  BOUND_LOWER)
                              : (tte->bound() &  BOUND_UPPER)))
    {
        ss->currentMove = ttMove; // Can be MOVE_NONE
        return ttValue;
    }

    // Evaluate the position statically
    if (InCheck)
    {
        ss->staticEval = VALUE_NONE;
        bestValue = futilityBase = -VALUE_INFINITE;
    }
    else
    {
        if (tte)
        {
            // Never assume anything on values stored in TT
            if ((ss->staticEval = bestValue = tte->eval_value()) == VALUE_NONE)
                ss->staticEval = bestValue = evaluate(pos);

            // Can ttValue be used as a better position evaluation?
            if (ttValue != VALUE_NONE)
                if (tte->bound() & (ttValue > bestValue ? BOUND_LOWER : BOUND_UPPER))
                    bestValue = ttValue;
        }
        else
            ss->staticEval = bestValue = evaluate(pos);
            (ss-1)->currentMove != MOVE_NULL ? evaluate(pos) : -(ss-1)->staticEval + 2 * Eval::Tempo;

        // Stand pat. Return immediately if static value is at least beta
        if (bestValue >= beta)
        {
            if (!tte)
                TT.store(pos.key(), value_to_tt(bestValue, ss->ply), BOUND_LOWER,
                         DEPTH_NONE, MOVE_NONE, ss->staticEval);

            return bestValue;
        }

        if (PvNode && bestValue > alpha)
            alpha = bestValue;

        futilityBase = bestValue + 128;
    }

    // Initialize a MovePicker object for the current position, and prepare
    // to search the moves. Because the depth is <= 0 here, only captures,
    // queen promotions and checks (only if depth >= DEPTH_QS_CHECKS) will
    // be generated.
    MovePicker mp(pos, ttMove, depth, History, to_sq((ss-1)->currentMove));
    CheckInfo ci(pos);
    int cnt = 0;

    // Loop through the moves until no moves remain or a beta cutoff occurs
    while ((move = mp.next_move<false>()) != MOVE_NONE)
    {
      assert(is_ok(move));
      cnt++;

      givesCheck =  type_of(move) == NORMAL && !ci.dcCandidates
                  ? ci.checkSq[type_of(pos.piece_on(from_sq(move)))] & to_sq(move)
                  : pos.gives_check(move, ci);

      // Futility pruning
      if (   !PvNode
          && !InCheck
          && !givesCheck
          &&  move != ttMove
          &&  futilityBase > -VALUE_KNOWN_WIN
          && !pos.advanced_pawn_push(move))
      {
          assert(type_of(move) != ENPASSANT); // Due to !pos.advanced_pawn_push

          futilityValue = futilityBase + PieceValue[EG][pos.piece_on(to_sq(move))];

          if (futilityValue < beta)
          {
              bestValue = std::max(bestValue, futilityValue);
              continue;
          }

          if (futilityBase < beta && pos.see(move) <= VALUE_ZERO)
          {
              bestValue = std::max(bestValue, futilityBase);
              continue;
          }
      }

      // Detect non-capture evasions that are candidates to be pruned
      evasionPrunable =    InCheck
                       &&  bestValue > VALUE_MATED_IN_MAX_PLY
                       && !pos.capture(move)
                       && !pos.can_castle(pos.side_to_move());

      // Don't search moves with negative SEE values
      if (   !PvNode
          && (!InCheck || evasionPrunable)
          &&  move != ttMove
          &&  type_of(move) != PROMOTION
          &&  pos.see_sign(move) < VALUE_ZERO)
          continue;

      // Check for legality just before making the move
      if (!pos.legal(move, ci.pinned))
          continue;

      ss->currentMove = move;

      // Make and search the move
      pos.do_move(move, st, ci, givesCheck);

      if (PvNode && cnt == 1)
          value = givesCheck ? -qsearch<PV,  true>(pos, ss+1, -beta, -alpha, depth - ONE_PLY)
                             : -qsearch<PV, false>(pos, ss+1, -beta, -alpha, depth - ONE_PLY);
      else {
          value = givesCheck ? -qsearch<NonPV,  true>(pos, ss+1, -alpha-1, -alpha, depth - ONE_PLY)
                             : -qsearch<NonPV, false>(pos, ss+1, -alpha-1, -alpha, depth - ONE_PLY);
          if (alpha < value && value < beta)
              value = givesCheck ? -qsearch<PV,  true>(pos, ss+1, -beta, -alpha, depth - ONE_PLY)
                                 : -qsearch<PV, false>(pos, ss+1, -beta, -alpha, depth - ONE_PLY);
      }











      pos.undo_move(move);
      assert(value > -VALUE_INFINITE && value < VALUE_INFINITE);

      // Check for new best move
      if (value > bestValue)
      {
          bestValue = value;

          if (value > alpha)
          {
              if (PvNode && value < beta) // Update alpha here! Always alpha < beta
              {
                  alpha = value;
                  bestMove = move;
              }
              else // Fail high
              {
                  TT.store(posKey, value_to_tt(value, ss->ply), BOUND_LOWER,
                           ttDepth, move, ss->staticEval);

                  return value;
              }
          }
       }
    }

    // All legal moves have been searched. A special case: If we're in check
    // and no legal moves were found, it is checkmate.
    if (InCheck && bestValue == -VALUE_INFINITE)
        return mated_in(ss->ply); // Plies to mate from the root

    TT.store(posKey, value_to_tt(bestValue, ss->ply),
             PvNode && bestValue > oldAlpha ? BOUND_EXACT : BOUND_UPPER,
             ttDepth, bestMove, ss->staticEval);

    assert(bestValue > -VALUE_INFINITE && bestValue < VALUE_INFINITE);

    return bestValue;
  }


  // value_to_tt() adjusts a mate score from "plies to mate from the root" to
  // "plies to mate from the current position". Non-mate scores are unchanged.
  // The function is called before storing a value in the transposition table.

  Value value_to_tt(Value v, int ply) {

    assert(v != VALUE_NONE);

    return  v >= VALUE_MATE_IN_MAX_PLY  ? v + ply
          : v <= VALUE_MATED_IN_MAX_PLY ? v - ply : v;
  }


  // value_from_tt() is the inverse of value_to_tt(): It adjusts a mate score
  // from the transposition table (which refers to the plies to mate/be mated
  // from current position) to "plies to mate/be mated from the root".

  Value value_from_tt(Value v, int ply) {

    return  v == VALUE_NONE             ? VALUE_NONE
          : v >= VALUE_MATE_IN_MAX_PLY  ? v - ply
          : v <= VALUE_MATED_IN_MAX_PLY ? v + ply : v;
  }


  // update_stats() updates killers, history, countermoves and followupmoves stats after a fail-high
  // of a quiet move.

  void update_stats(const Position& pos, Stack* ss, Move move, Depth depth, Move* quiets, int quietsCnt) {

    if (ss->killers[0] != move)
    {
        ss->killers[1] = ss->killers[0];
        ss->killers[0] = move;
    }

    // Increase history value of the cut-off move and decrease all the other
    // played quiet moves.
    Value bonus = Value(4 * int(depth) * int(depth));
    History.update(pos.moved_piece(move), to_sq(move), bonus);
    for (int i = 0; i < quietsCnt; ++i)
    {
        Move m = quiets[i];
        History.update(pos.moved_piece(m), to_sq(m), -bonus);
    }

    if (is_ok((ss-1)->currentMove))
    {
        Square prevMoveSq = to_sq((ss-1)->currentMove);
        Countermoves.update(pos.piece_on(prevMoveSq), prevMoveSq, move);
    }

    if (is_ok((ss-2)->currentMove) && (ss-1)->currentMove == (ss-1)->ttMove)
    {
        Square prevOwnMoveSq = to_sq((ss-2)->currentMove);
        Followupmoves.update(pos.piece_on(prevOwnMoveSq), prevOwnMoveSq, move);
    }
  }


  // When playing with a strength handicap, choose best move among the first 'candidates'
  // RootMoves using a statistical rule dependent on 'level'. Idea by Heinz van Saanen.

  Move Skill::pick_move() {

    static RKISS rk;

    // PRNG sequence should be not deterministic
    for (int i = Time::now() % 50; i > 0; --i)
        rk.rand<unsigned>();

    // RootMoves are already sorted by score in descending order
    int variance = std::min(RootMoves[0].score - RootMoves[candidates - 1].score, PawnValueMg);
    int weakness = 120 - 2 * level;
    int max_s = -VALUE_INFINITE;
    best = MOVE_NONE;

    // Choose best move. For each move score we add two terms both dependent on
    // weakness. One deterministic and bigger for weaker moves, and one random,
    // then we choose the move with the resulting highest score.
    for (size_t i = 0; i < candidates; ++i)
    {
        int s = RootMoves[i].score;

        // Don't allow crazy blunders even at very low skills
        if (i > 0 && RootMoves[i - 1].score > s + 2 * PawnValueMg)
            break;

        // This is our magic formula
        s += (  weakness * int(RootMoves[0].score - s)
              + variance * (rk.rand<unsigned>() % weakness)) / 128;

        if (s > max_s)
        {
            max_s = s;
            best = RootMoves[i].pv[0];
        }
    }
    return best;
  }


  // uci_pv() formats PV information according to the UCI protocol. UCI
  // requires that all (if any) unsearched PV lines are sent using a previous
  // search score.

  string uci_pv(const Position& pos, int depth, Value alpha, Value beta) {

    std::stringstream ss;
    Time::point elapsed = Time::now() - SearchTime + 1;
    size_t uciPVSize = std::min((size_t)Options["MultiPV"], RootMoves.size());
    int selDepth = 0;

    for (size_t i = 0; i < Threads.size(); ++i)
        if (Threads[i]->maxPly > selDepth)
            selDepth = Threads[i]->maxPly;

    for (size_t i = 0; i < uciPVSize; ++i)
    {
        bool updated = (i <= PVIdx);

        if (depth == 1 && !updated)
            continue;

        int d   = updated ? depth : depth - 1;
        Value v = updated ? RootMoves[i].score : RootMoves[i].prevScore;

	bool tb = RootInTB;
        if (tb)
        {
	    if (abs(v) >= VALUE_MATE - MAX_PLY)
                tb = false;
            else
                v = TBScore;
        }

        if (ss.rdbuf()->in_avail()) // Not at first line
            ss << "\n";

        ss << "info depth " << d
           << " seldepth "  << selDepth
           << " score "     << ((!tb && i == PVIdx) ? score_to_uci(v, alpha, beta) : score_to_uci(v))
           << " nodes "     << pos.nodes_searched()
           << " nps "       << pos.nodes_searched() * 1000 / elapsed
           << " tbhits "    << TBHits
           << " time "      << elapsed
           << " multipv "   << i + 1
           << " pv";

        for (size_t j = 0; RootMoves[i].pv[j] != MOVE_NONE; ++j)
            ss << " " << move_to_uci(RootMoves[i].pv[j], pos.is_chess960());
    }

    return ss.str();
  }

} // namespace


/// RootMove::extract_pv_from_tt() builds a PV by adding moves from the TT table.
/// We also consider both failing high nodes and BOUND_EXACT nodes here to
/// ensure that we have a ponder move even when we fail high at root. This
/// results in a long PV to print that is important for position analysis.

void RootMove::extract_pv_from_tt(Position& pos) {

  StateInfo state[MAX_PLY_PLUS_6], *st = state;
  const TTEntry* tte;
  int ply = 1;    // At root ply is 1...
  Move m = pv[0]; // ...instead pv[] array starts from 0
  Value expectedScore = score;

  pv.clear();

  do {
      pv.push_back(m);

      assert(MoveList<LEGAL>(pos).contains(pv[ply - 1]));

      pos.do_move(pv[ply++ - 1], *st++);
      tte = TT.probe(pos.key());
      expectedScore = -expectedScore;

  } while (   tte
           && expectedScore == value_from_tt(tte->value(), ply)
           && pos.pseudo_legal(m = tte->move()) // Local copy, TT could change
           && pos.legal(m, pos.pinned_pieces(pos.side_to_move()))
           && ply < MAX_PLY
           && (!pos.is_draw() || ply <= 2));

  pv.push_back(MOVE_NONE); // Must be zero-terminating

  while (--ply) pos.undo_move(pv[ply - 1]);
}


/// RootMove::insert_pv_in_tt() is called at the end of a search iteration, and
/// inserts the PV back into the TT. This makes sure the old PV moves are searched
/// first, even if the old TT entries have been overwritten.

void RootMove::insert_pv_in_tt(Position& pos) {

  StateInfo state[MAX_PLY_PLUS_6], *st = state;
  const TTEntry* tte;
  int idx = 0; // Ply starts from 1, we need to start from 0

  do {
      tte = TT.probe(pos.key());

      if (!tte || tte->move() != pv[idx]) // Don't overwrite correct entries
          TT.store(pos.key(), VALUE_NONE, BOUND_NONE, DEPTH_NONE, pv[idx], VALUE_NONE);

      assert(MoveList<LEGAL>(pos).contains(pv[idx]));

      pos.do_move(pv[idx++], *st++);

  } while (pv[idx] != MOVE_NONE);

  while (idx) pos.undo_move(pv[--idx]);
}


/// Thread::idle_loop() is where the thread is parked when it has no work to do

void Thread::idle_loop() {

  // Pointer 'this_sp' is not null only if we are called from split(), and not
  // at the thread creation. This means we are the split point's master.
  SplitPoint* this_sp = splitPointsSize ? activeSplitPoint : NULL;

  assert(!this_sp || (this_sp->masterThread == this && searching));

  while (!exit)
  {
      // If this thread has been assigned work, launch a search
      while (searching)
      {
          Threads.mutex.lock();

          assert(activeSplitPoint);
          SplitPoint* sp = activeSplitPoint;

          Threads.mutex.unlock();

          Stack stack[MAX_PLY_PLUS_6], *ss = stack+2; // To allow referencing (ss-2)
          Position pos(*sp->pos, this);

          std::memcpy(ss-2, sp->ss-2, 5 * sizeof(Stack));
          ss->splitPoint = sp;

          sp->mutex.lock();

          assert(activePosition == NULL);

          activePosition = &pos;

          if (sp->nodeType == NonPV)
              search<NonPV, true>(pos, ss, sp->alpha, sp->beta, sp->depth, sp->cutNode);

          else if (sp->nodeType == PV)
              search<PV, true>(pos, ss, sp->alpha, sp->beta, sp->depth, sp->cutNode);

          else if (sp->nodeType == Root)
              search<Root, true>(pos, ss, sp->alpha, sp->beta, sp->depth, sp->cutNode);

          else
              assert(false);

          assert(searching);

          searching = false;
          activePosition = NULL;
          sp->slavesMask.reset(idx);
          sp->allSlavesSearching = false;
          sp->nodes += pos.nodes_searched();

          // Wake up the master thread so to allow it to return from the idle
          // loop in case we are the last slave of the split point.
          if (    this != sp->masterThread
              &&  sp->slavesMask.none())
          {
              assert(!sp->masterThread->searching);
              sp->masterThread->notify_one();
          }

          // After releasing the lock we can't access any SplitPoint related data
          // in a safe way because it could have been released under our feet by
          // the sp master.
          sp->mutex.unlock();

          // Try to late join to another split point if none of its slaves has
          // already finished.
          if (Threads.size() > 2)
              for (size_t i = 0; i < Threads.size(); ++i)
              {
                  const int size = Threads[i]->splitPointsSize; // Local copy
                  sp = size ? &Threads[i]->splitPoints[size - 1] : NULL;

                  if (   sp
                      && sp->allSlavesSearching
                      && available_to(Threads[i]))
                  {
                      // Recheck the conditions under lock protection
                      Threads.mutex.lock();
                      sp->mutex.lock();

                      if (   sp->allSlavesSearching
                          && available_to(Threads[i]))
                      {
                           sp->slavesMask.set(idx);
                           activeSplitPoint = sp;
                           searching = true;
                      }

                      sp->mutex.unlock();
                      Threads.mutex.unlock();

                      break; // Just a single attempt
                  }
              }
      }

      // Grab the lock to avoid races with Thread::notify_one()
      mutex.lock();

      // If we are master and all slaves have finished then exit idle_loop
      if (this_sp && this_sp->slavesMask.none())
      {
          assert(!searching);
          mutex.unlock();
          break;
      }

      // If we are not searching, wait for a condition to be signaled instead of
      // wasting CPU time polling for work.
      if (!searching && !exit)
          sleepCondition.wait(mutex);

      mutex.unlock();
  }
}


/// check_time() is called by the timer thread when the timer triggers. It is
/// used to print debug info and, more importantly, to detect when we are out of
/// available time and thus stop the search.

void check_time() {

  static Time::point lastInfoTime = Time::now();
  int64_t nodes = 0; // Workaround silly 'uninitialized' gcc warning

  if (Time::now() - lastInfoTime >= 1000)
  {
      lastInfoTime = Time::now();
      dbg_print();
  }

  if (Limits.ponder)
      return;

  if (Limits.nodes)
  {
      Threads.mutex.lock();

      nodes = RootPos.nodes_searched();

      // Loop across all split points and sum accumulated SplitPoint nodes plus
      // all the currently active positions nodes.
      for (size_t i = 0; i < Threads.size(); ++i)
          for (int j = 0; j < Threads[i]->splitPointsSize; ++j)
          {
              SplitPoint& sp = Threads[i]->splitPoints[j];

              sp.mutex.lock();

              nodes += sp.nodes;

              for (size_t idx = 0; idx < Threads.size(); ++idx)
                  if (sp.slavesMask.test(idx) && Threads[idx]->activePosition)
                      nodes += Threads[idx]->activePosition->nodes_searched();

              sp.mutex.unlock();
          }

      Threads.mutex.unlock();
  }

  Time::point elapsed = Time::now() - SearchTime;
  bool stillAtFirstMove =    Signals.firstRootMove
                         && !Signals.failedLowAtRoot
                         &&  elapsed > TimeMgr.available_time() * 75 / 100;

  bool noMoreTime =   elapsed > TimeMgr.maximum_time() - 2 * TimerThread::Resolution
                   || stillAtFirstMove;

  if (   (Limits.use_time_management() && noMoreTime)
      || (Limits.movetime && elapsed >= Limits.movetime)
      || (Limits.nodes && nodes >= Limits.nodes))
      Signals.stop = true;
}
