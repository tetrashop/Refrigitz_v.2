using System.Collections.Generic;

using evaluate = Eval.evaluate;
using Search;
using System;
using System.Diagnostics;

public static class GlobalMembersSearch
{

	  public static volatile SignalsType Signals = new SignalsType();
	  public static LimitsType Limits = new LimitsType();
	#if RootMoveVector_ConditionalDefinition1
	  public static List<RootMove> RootMoves = new List<RootMove>();
	#elif RootMoveVector_ConditionalDefinition2
	  public static List<RootMove> RootMoves = new List<RootMove>();
	#else
	  public static RootMoveVector RootMoves = new RootMoveVector();
	#endif
	  public static Position RootPos = new Position();
	  public static int long SearchTime;
	#if StateStackPtr_ConditionalDefinition1
	  public static std.auto_ptr<Stack<StateInfo>> SetupStates = new std.auto_ptr<Stack<StateInfo>>();
	#elif StateStackPtr_ConditionalDefinition2
	  public static std.auto_ptr<Stack<StateInfo>> SetupStates = new std.auto_ptr<Stack<StateInfo>>();
	#else
	  public static StateStackPtr SetupStates = new StateStackPtr();
	#endif

	  public static int Cardinality;
	  public static uint long Hits;
	  public static bool RootInTB;
	  public static bool UseRule50;
	  public static Depth ProbeDepth;
	  public static Value Score;

	  // Dynamic razoring margin based on depth
	  public static Value razor_margin(Depth d)
	  {
		  return Value(512 + 32 * d);
	  }

	  // Futility lookup tables (initialized at startup) and their access functions
	  public static int[,] FutilityMoveCounts = new int[2, 16]; // [improving][depth]

	  public static Value futility_margin(Depth d)
	  {
		return Value(200 * d);
	  }

	  // Reduction lookup tables (initialized at startup) and their access function
	  public static sbyte[,,,] Reductions = new sbyte[2, 2, 64, 64]; // [pv][improving][depth][moveNumber]

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template <bool PvNode>
	  public static Depth reduction<bool PvNode>(bool i, Depth d, int mn)
	  {
		return (Depth) Reductions[PvNode, i, Math.Min((int)d, 63), Math.Min(mn, 63)];
	  }

	  public static uint PVIdx;
	  public static TimeManager TimeMgr = new TimeManager();
	  public static double BestMoveChanges;
	  public static Value[] DrawValue = new Value[(int)Color.COLOR_NB];
	  public static Stats<false, Value> History = new Stats<false, Value>();
	  public static Stats< true, Value> Gains = new Stats< true, Value>();
	  public static Stats<false, std.pair<Move, Move>> Countermoves = new Stats<false, std.pair<Move, Move>>();
	  public static Stats<false, std.pair<Move, Move>> Followupmoves = new Stats<false, std.pair<Move, Move>>();

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template <NodeType NT, bool SpNode>

  // search<>() is the main search function for both PV and non-PV nodes and for
  // normal and SplitPoint nodes. When called just after a split point the search
  // is simpler because we have already probed the hash table, done a null move
  // search, and searched the first move before splitting, so we don't have to
  // repeat all this work again. We also don't need to store anything to the hash
  // table here: This is taken care of after we return from the split point.

	  public static Value search<NodeType NT, bool SpNode>(Position pos, Stack ss, Value alpha, Value beta, Depth depth, bool cutNode)
	  {

		bool RootNode = NT == NodeType.Root;
		bool PvNode = NT == NodeType.PV || NT == NodeType.Root;

		Debug.Assert(-Value.VALUE_INFINITE <= alpha && alpha < beta && beta <= Value.VALUE_INFINITE);
		Debug.Assert(PvNode || (alpha == beta - 1));
		Debug.Assert(depth > Depth.DEPTH_ZERO);

		Move[] pv = new Move[GlobalMembersTypes.MAX_PLY + 1];
		Move[] quietsSearched = new Move[64];
		StateInfo st = new StateInfo();
		TTEntry tte;
		SplitPoint splitPoint;
		uint long posKey;
		Move ttMove;
		Move move;
		Move excludedMove;
		Move bestMove;
		Depth extension;
		Depth newDepth;
		Depth predictedDepth;
		Value bestValue;
		Value value;
		Value ttValue;
		Value eval;
		Value nullValue;
		Value futilityValue;
		bool ttHit;
		bool inCheck;
		bool givesCheck;
		bool singularExtensionNode;
		bool improving;
		bool captureOrPromotion;
		bool dangerous;
		bool doFullDepthSearch;
		int moveCount;
		int quietCount;

		// Step 1. Initialize node
		Thread thisThread = pos.this_thread();
		inCheck = pos.checkers();

		if (SpNode)
		{
			splitPoint = ss.splitPoint;
			bestMove = splitPoint.bestMove;
			bestValue = splitPoint.bestValue;
			tte = null;
			ttHit = false;
			ttMove = excludedMove = Move.MOVE_NONE;
			ttValue = Value.VALUE_NONE;

			Debug.Assert(splitPoint.bestValue > -Value.VALUE_INFINITE && splitPoint.moveCount > 0);

			goto moves_loop;
		}

		moveCount = quietCount = 0;
		bestValue = -Value.VALUE_INFINITE;
		ss.ply = (ss - 1).ply + 1;

		// Used to send selDepth info to GUI
		if (PvNode && thisThread.maxPly < ss.ply)
		{
			thisThread.maxPly = ss.ply;
		}

		if (!RootNode)
		{
			// Step 2. Check for aborted search and immediate draw
			if (Signals.stop || pos.is_draw() || ss.ply >= GlobalMembersTypes.MAX_PLY)
			{
				return ss.ply >= GlobalMembersTypes.MAX_PLY && !inCheck ? GlobalMembersEvaluate.evaluate(pos) : DrawValue[(int)pos.side_to_move()];
			}

			// Step 3. Mate distance pruning. Even if we mate at the next move our score
			// would be at best mate_in(ss->ply+1), but if alpha is already bigger because
			// a shorter mate was found upward in the tree then there is no need to search
			// because we will never beat the current alpha. Same logic but with reversed
			// signs applies also in the opposite condition of being mated instead of giving
			// mate. In this case return a fail-high score.
			alpha = Math.Max(GlobalMembersTypes.mated_in(ss.ply), alpha);
			beta = Math.Min(GlobalMembersTypes.mate_in(ss.ply + 1), beta);
			if (alpha >= beta)
			{
				return alpha;
			}
		}

		Debug.Assert(0 <= ss.ply && ss.ply < GlobalMembersTypes.MAX_PLY);

		ss.currentMove = ss.ttMove = (ss + 1).excludedMove = bestMove = Move.MOVE_NONE;
		(ss + 1).skipEarlyPruning = false;
		(ss + 1).reduction = Depth.DEPTH_ZERO;
		(ss + 2).killers[0] = (ss + 2).killers[1] = Move.MOVE_NONE;

		// Step 4. Transposition table lookup
		// We don't want the score of a partial search to overwrite a previous full search
		// TT value, so we use a different position key in case of an excluded move.
		excludedMove = ss.excludedMove;
		posKey = ((int)excludedMove) != 0 ? pos.exclusion_key() : pos.key();
		tte = GlobalMembersTt.TT.probe(posKey, ref ttHit);
		ss.ttMove = ttMove = RootNode ? RootMoves[PVIdx].pv[0] : ttHit ? tte.move() : Move.MOVE_NONE;
		ttValue = ttHit ? GlobalMembersSearch.value_from_tt(tte.value(), ss.ply) : Value.VALUE_NONE;

		// At non-PV nodes we check for a fail high/low. We don't probe at PV nodes
		if (!PvNode && ttHit && tte.depth() >= depth && ttValue != Value.VALUE_NONE && (ttValue >= ((int)beta) != 0 ? ((int)tte.bound() & (int)Bound.BOUND_LOWER) : ((int)tte.bound() & (int)Bound.BOUND_UPPER))) // Only in case of TT access race
		{
			ss.currentMove = ttMove; // Can be MOVE_NONE

			// If ttMove is quiet, update killers, history, counter move and followup move on TT hit
			if (ttValue >= beta && ((int)ttMove) != 0 && !pos.capture_or_promotion(ttMove) && !inCheck)
			{
				GlobalMembersSearch.update_stats(pos, ss, ttMove, depth, null, 0);
			}

			return ttValue;
		}

		// Step 4a. Tablebase probe
		if (!RootNode && TB.Cardinality)
		{
			int piecesCnt = pos.count<PieceType.ALL_PIECES>(Color.WHITE) + pos.count<PieceType.ALL_PIECES>(Color.BLACK);

			if (piecesCnt <= TB.Cardinality && (piecesCnt < TB.Cardinality || depth >= TB.ProbeDepth) && pos.rule50_count() == 0)
			{
				int found;
				int v = GlobalMembersTbprobe.probe_wdl(pos, ref found);

				if (found != 0)
				{
					TB.Hits++;

					int drawScore = TB.UseRule50 ? 1 : 0;

					value = v < -drawScore != 0 ? - Value.VALUE_MATE + GlobalMembersTypes.MAX_PLY + ss.ply : v > drawScore != 0 ? Value.VALUE_MATE - GlobalMembersTypes.MAX_PLY - ss.ply : Value.VALUE_DRAW + 2 * v * drawScore;

					tte.save(posKey, GlobalMembersSearch.value_to_tt(value, ss.ply), Bound.BOUND_EXACT, Math.Min(Depth.DEPTH_MAX - Depth.ONE_PLY, depth + 6 * Depth.ONE_PLY), Move.MOVE_NONE, Value.VALUE_NONE, GlobalMembersTt.TT.generation());

					return value;
				}
			}
		}

		// Step 5. Evaluate the position statically and update parent's gain statistics
		if (inCheck)
		{
			ss.staticEval = eval = Value.VALUE_NONE;
			goto moves_loop;
		}

		else if (ttHit)
		{
			// Never assume anything on values stored in TT
			if ((ss.staticEval = eval = tte.eval()) == Value.VALUE_NONE)
			{
				eval = ss.staticEval = GlobalMembersEvaluate.evaluate(pos);
			}

			// Can ttValue be used as a better position evaluation?
			if (ttValue != Value.VALUE_NONE)
			{
				if ((int)tte.bound() & (ttValue > ((int)eval) != 0 ? Bound.BOUND_LOWER : Bound.BOUND_UPPER))
				{
					eval = ttValue;
				}
			}
		}
		else
		{
			eval = ss.staticEval = (ss - 1).currentMove != ((int)Move.MOVE_NULL) != 0 ? GlobalMembersEvaluate.evaluate(pos) : -(ss - 1).staticEval + 2 * GlobalMembersEvaluate.Tempo;

			tte.save(posKey, Value.VALUE_NONE, Bound.BOUND_NONE, Depth.DEPTH_NONE, Move.MOVE_NONE, ss.staticEval, GlobalMembersTt.TT.generation());
		}

		if (ss.skipEarlyPruning)
		{
			goto moves_loop;
		}

		if (((int)pos.captured_piece_type()) == 0 && ss.staticEval != Value.VALUE_NONE && (ss - 1).staticEval != Value.VALUE_NONE && (move = (ss - 1).currentMove) != Move.MOVE_NULL && move != Move.MOVE_NONE && GlobalMembersTypes.type_of(move) == MoveType.NORMAL)
		{
			Square to = GlobalMembersTypes.to_sq(move);
			Gains.update(pos.piece_on(to), to, -(ss - 1).staticEval - ss.staticEval);
		}

		// Step 6. Razoring (skipped when in check)
		if (!PvNode && depth < 4 * Depth.ONE_PLY && eval + GlobalMembersSearch.razor_margin(depth) <= alpha && ttMove == Move.MOVE_NONE && !pos.pawn_on_7th(pos.side_to_move()))
		{
			if (depth <= Depth.ONE_PLY && eval + GlobalMembersSearch.razor_margin(3 * Depth.ONE_PLY) <= alpha)
			{
				return GlobalMembersSearch.qsearch<NodeType.NonPV, false>(pos, ss, alpha, beta, Depth.DEPTH_ZERO);
			}

			Value ralpha = alpha - GlobalMembersSearch.razor_margin(depth);
			Value v = GlobalMembersSearch.qsearch<NodeType.NonPV, false>(pos, ss, ralpha, ralpha + 1, Depth.DEPTH_ZERO);
			if (v <= ralpha)
			{
				return v;
			}
		}

		// Step 7. Futility pruning: child node (skipped when in check)
		if (!RootNode && depth < 7 * Depth.ONE_PLY && eval - GlobalMembersSearch.futility_margin(depth) >= beta && eval < Value.VALUE_KNOWN_WIN && ((int)pos.non_pawn_material(pos.side_to_move())) != 0) // Do not return unproven wins
		{
			return eval - GlobalMembersSearch.futility_margin(depth);
		}

		// Step 8. Null move search with verification search (is omitted in PV nodes)
		if (!PvNode && depth >= 2 * Depth.ONE_PLY && eval >= beta && ((int)pos.non_pawn_material(pos.side_to_move())) != 0)
		{
			ss.currentMove = Move.MOVE_NULL;

			Debug.Assert(eval - beta >= 0);

			// Null move dynamic reduction based on depth and value
			Depth R = ((823 + 67 * depth) / 256 + Math.Min((eval - beta) / Value.PawnValueMg, 3)) * Depth.ONE_PLY;

			pos.do_null_move(st);
			(ss + 1).skipEarlyPruning = true;
			nullValue = depth - R < ((int)Depth.ONE_PLY) != 0 ? - GlobalMembersSearch.qsearch<NodeType.NonPV, false>(pos, ss + 1, -beta, -beta + 1, Depth.DEPTH_ZERO) : - GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss + 1, -beta, -beta + 1, depth - R, !cutNode);
			(ss + 1).skipEarlyPruning = false;
			pos.undo_null_move();

			if (nullValue >= beta)
			{
				// Do not return unproven mate scores
				if (nullValue >= Value.VALUE_MATE_IN_MAX_PLY)
				{
					nullValue = beta;
				}

				if (depth < 12 * Depth.ONE_PLY && Math.Abs(beta) < Value.VALUE_KNOWN_WIN)
				{
					return nullValue;
				}

				// Do verification search at high depths
				ss.skipEarlyPruning = true;
				Value v = depth - R < ((int)Depth.ONE_PLY) != 0 ? GlobalMembersSearch.qsearch<NodeType.NonPV, false>(pos, ss, beta - 1, beta, Depth.DEPTH_ZERO) : GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss, beta - 1, beta, depth - R, false);
				ss.skipEarlyPruning = false;

				if (v >= beta)
				{
					return nullValue;
				}
			}
		}

		// Step 9. ProbCut (skipped when in check)
		// If we have a very good capture (i.e. SEE > seeValues[captured_piece_type])
		// and a reduced search returns a value much above beta, we can (almost) safely
		// prune the previous move.
		if (!PvNode && depth >= 5 * Depth.ONE_PLY && Math.Abs(beta) < Value.VALUE_MATE_IN_MAX_PLY)
		{
			Value rbeta = Math.Min(beta + 200, Value.VALUE_INFINITE);
			Depth rdepth = depth - 4 * Depth.ONE_PLY;

			Debug.Assert(rdepth >= Depth.ONE_PLY);
			Debug.Assert((ss - 1).currentMove != Move.MOVE_NONE);
			Debug.Assert((ss - 1).currentMove != Move.MOVE_NULL);

			MovePicker mp = new MovePicker(pos, ttMove, History, pos.captured_piece_type());
			CheckInfo ci = new CheckInfo(pos);

			while ((move = mp.next_move<false>()) != Move.MOVE_NONE)
			{
				if (pos.legal(move, ci.pinned))
				{
					ss.currentMove = move;
					pos.do_move(move, st, ci, pos.gives_check(move, ci));
					value = -GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss + 1, -rbeta, -rbeta + 1, rdepth, !cutNode);
					pos.undo_move(move);
					if (value >= rbeta)
					{
						return value;
					}
				}
			}
		}

		// Step 10. Internal iterative deepening (skipped when in check)
		if (depth >= (PvNode ? 5 * Depth.ONE_PLY : 8 * Depth.ONE_PLY) && ((int)ttMove) == 0 && (PvNode || ss.staticEval + 256 >= beta))
		{
			Depth d = 2 * (depth - 2 * Depth.ONE_PLY) - (PvNode ? Depth.DEPTH_ZERO : depth / 2);
			ss.skipEarlyPruning = true;
			GlobalMembersSearch.search < PvNode ? NodeType.PV : NodeType.NonPV, false>(pos, ss, alpha, beta, d / 2, true);
			ss.skipEarlyPruning = false;

			tte = GlobalMembersTt.TT.probe(posKey, ref ttHit);
			ttMove = ttHit ? tte.move() : Move.MOVE_NONE;
		}

	moves_loop: // When in check and at SpNode search starts from here

		Square prevMoveSq = GlobalMembersTypes.to_sq((ss - 1).currentMove);
		Move[] countermoves = {Countermoves[(int)pos.piece_on(prevMoveSq)][(int)prevMoveSq].first, Countermoves[(int)pos.piece_on(prevMoveSq)][(int)prevMoveSq].second};

		Square prevOwnMoveSq = GlobalMembersTypes.to_sq((ss - 2).currentMove);
		Move[] followupmoves = {Followupmoves[(int)pos.piece_on(prevOwnMoveSq)][(int)prevOwnMoveSq].first, Followupmoves[(int)pos.piece_on(prevOwnMoveSq)][(int)prevOwnMoveSq].second};

		MovePicker mp = new MovePicker(pos, ttMove, depth, History, countermoves, followupmoves, ss);
		CheckInfo ci = new CheckInfo(pos);
		value = bestValue; // Workaround a bogus 'uninitialized' warning under gcc
		improving = ss.staticEval >= (ss - 2).staticEval || ss.staticEval == Value.VALUE_NONE || (ss - 2).staticEval == Value.VALUE_NONE;

		singularExtensionNode = !RootNode && !SpNode && depth >= 8 * Depth.ONE_PLY && ttMove != Move.MOVE_NONE && Math.Abs(ttValue) < Value.VALUE_KNOWN_WIN && ((int)excludedMove) == 0 && ((int)tte.bound() & (int)Bound.BOUND_LOWER) && tte.depth() >= depth - 3 * Depth.ONE_PLY; // Recursive singular search is not allowed
						   /*  &&  ttValue != VALUE_NONE Already implicit in the next condition */

		// Step 11. Loop through moves
		// Loop through all pseudo-legal moves until no moves remain or a beta cutoff occurs
		while ((move = mp.next_move<SpNode>()) != Move.MOVE_NONE)
		{
		  Debug.Assert(GlobalMembersTypes.is_ok(move));

		  if (move == excludedMove)
			  continue;

		  // At root obey the "searchmoves" option and skip moves not listed in Root
		  // Move List. As a consequence any illegal move is also skipped. In MultiPV
		  // mode we also skip PV moves which have been already searched.
		  if (RootNode && !std.count(RootMoves.GetEnumerator() + PVIdx, RootMoves.end(), move))
			  continue;

		  if (SpNode)
		  {
			  // Shared counter cannot be decremented later if the move turns out to be illegal
			  if (!pos.legal(move, ci.pinned))
				  continue;

			  moveCount = ++splitPoint.moveCount;
			  splitPoint.mutex.unlock();
		  }
		  else
		  {
			  ++moveCount;
		  }

		  if (RootNode)
		  {
			  Signals.firstRootMove = (moveCount == 1);

			  if (thisThread == GlobalMembersThread.Threads.main() && GlobalMembersMisc.now() - SearchTime > 3000)
			  {
				  sync_cout << "info depth " << depth / Depth.ONE_PLY << " currmove " << move(move, pos.is_chess960()) << " currmovenumber " << moveCount + PVIdx << sync_endl;
			  }
		  }

		  if (PvNode)
		  {
			  (ss + 1).pv = null;
		  }

		  extension = Depth.DEPTH_ZERO;
		  captureOrPromotion = pos.capture_or_promotion(move);

		  givesCheck = GlobalMembersTypes.type_of(move) == MoveType.NORMAL && !ci.dcCandidates ? ci.checkSq[(int)GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersTypes.from_sq(move)))] & (int)GlobalMembersTypes.to_sq(move) : pos.gives_check(move, ci);

		  dangerous = givesCheck || GlobalMembersTypes.type_of(move) != MoveType.NORMAL || pos.advanced_pawn_push(move);

		  // Step 12. Extend checks
		  if (givesCheck && pos.see_sign(move) >= Value.VALUE_ZERO)
		  {
			  extension = Depth.ONE_PLY;
		  }

		  // Singular extension search. If all moves but one fail low on a search of
		  // (alpha-s, beta-s), and just one fails high on (alpha, beta), then that move
		  // is singular and should be extended. To verify this we do a reduced search
		  // on all the other moves but the ttMove and if the result is lower than
		  // ttValue minus a margin then we extend the ttMove.
		  if (singularExtensionNode && move == ttMove && ((int)extension) == 0 && pos.legal(move, ci.pinned))
		  {
			  Value rBeta = ttValue - 2 * depth / Depth.ONE_PLY;
			  ss.excludedMove = move;
			  ss.skipEarlyPruning = true;
			  value = GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss, rBeta - 1, rBeta, depth / 2, cutNode);
			  ss.skipEarlyPruning = false;
			  ss.excludedMove = Move.MOVE_NONE;

			  if (value < rBeta)
			  {
				  extension = Depth.ONE_PLY;
			  }
		  }

		  // Update the current move (this must be done after singular extension search)
		  newDepth = depth - Depth.ONE_PLY + extension;

		  // Step 13. Pruning at shallow depth
		  if (!RootNode && !captureOrPromotion && !inCheck && !dangerous && bestValue > Value.VALUE_MATED_IN_MAX_PLY)
		  {
			  // Move count based pruning
			  if (depth < 16 * Depth.ONE_PLY && moveCount >= FutilityMoveCounts[improving, (int)depth])
			  {
				  if (SpNode)
				  {
					  splitPoint.mutex.@lock();
				  }

				  continue;
			  }

			  predictedDepth = newDepth - GlobalMembersSearch.reduction<PvNode>(improving, depth, moveCount);

			  // Futility pruning: parent node
			  if (predictedDepth < 7 * Depth.ONE_PLY)
			  {
				  futilityValue = ss.staticEval + GlobalMembersSearch.futility_margin(predictedDepth) + 128 + Gains[(int)pos.moved_piece(move)][(int)GlobalMembersTypes.to_sq(move)];

				  if (futilityValue <= alpha)
				  {
					  bestValue = Math.Max(bestValue, futilityValue);

					  if (SpNode)
					  {
						  splitPoint.mutex.@lock();
						  if (bestValue > splitPoint.bestValue)
						  {
							  splitPoint.bestValue = bestValue;
						  }
					  }
					  continue;
				  }
			  }

			  // Prune moves with negative SEE at low depths
			  if (predictedDepth < 4 * Depth.ONE_PLY && pos.see_sign(move) < Value.VALUE_ZERO)
			  {
				  if (SpNode)
				  {
					  splitPoint.mutex.@lock();
				  }

				  continue;
			  }
		  }

		  // Speculative prefetch as early as possible
		  GlobalMembersMisc.prefetch(ref (string)GlobalMembersTt.TT.first_entry(pos.key_after(move)));

		  // Check for legality just before making the move
		  if (!RootNode && !SpNode && !pos.legal(move, ci.pinned))
		  {
			  moveCount--;
			  continue;
		  }

		  ss.currentMove = move;
		  if (!SpNode && !captureOrPromotion && quietCount < 64)
		  {
			  quietsSearched[quietCount++] = move;
		  }

		  // Step 14. Make the move
		  pos.do_move(move, st, ci, givesCheck);

		  // Step 15. Reduced depth search (LMR). If the move fails high it will be
		  // re-searched at full depth.
		  if (depth >= 3 * Depth.ONE_PLY && moveCount > 1 && !captureOrPromotion && move != ss.killers[0] && move != ss.killers[1])
		  {
			  ss.reduction = GlobalMembersSearch.reduction<PvNode>(improving, depth, moveCount);

			  if ((!PvNode && cutNode) || History[(int)pos.piece_on(GlobalMembersTypes.to_sq(move))][(int)GlobalMembersTypes.to_sq(move)] < Value.VALUE_ZERO)
			  {
				  ss.reduction += Depth.ONE_PLY;
			  }

			  if (move == countermoves[0] || move == countermoves[1])
			  {
				  ss.reduction = Math.Max(Depth.DEPTH_ZERO, ss.reduction - Depth.ONE_PLY);
			  }

			  // Decrease reduction for moves that escape a capture
			  if (((int)ss.reduction) != 0 && GlobalMembersTypes.type_of(move) == MoveType.NORMAL && GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersTypes.to_sq(move))) != PieceType.PAWN && pos.see(GlobalMembersTypes.make_move(GlobalMembersTypes.to_sq(move), GlobalMembersTypes.from_sq(move))) < Value.VALUE_ZERO)
			  {
				  ss.reduction = Math.Max(Depth.DEPTH_ZERO, ss.reduction - Depth.ONE_PLY);
			  }

			  Depth d = Math.Max(newDepth - ss.reduction, Depth.ONE_PLY);
			  if (SpNode)
			  {
				  alpha = splitPoint.alpha;
			  }

			  value = -GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss + 1, -(alpha + 1), -alpha, d, true);

			  // Re-search at intermediate depth if reduction is very high
			  if (value > alpha && ss.reduction >= 4 * Depth.ONE_PLY)
			  {
				  Depth d2 = Math.Max(newDepth - 2 * Depth.ONE_PLY, Depth.ONE_PLY);
				  value = -GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss + 1, -(alpha + 1), -alpha, d2, true);
			  }

			  doFullDepthSearch = (value > alpha && ss.reduction != Depth.DEPTH_ZERO);
			  ss.reduction = Depth.DEPTH_ZERO;
		  }
		  else
		  {
			  doFullDepthSearch = !PvNode || moveCount > 1;
		  }

		  // Step 16. Full depth search, when LMR is skipped or fails high
		  if (doFullDepthSearch)
		  {
			  if (SpNode)
			  {
				  alpha = splitPoint.alpha;
			  }

			  value = newDepth < ((int)Depth.ONE_PLY) != 0 ? givesCheck ? - GlobalMembersSearch.qsearch<NodeType.NonPV, true>(pos, ss + 1, -(alpha + 1), -alpha, Depth.DEPTH_ZERO) : -GlobalMembersSearch.qsearch<NodeType.NonPV, false>(pos, ss + 1, -(alpha + 1), -alpha, Depth.DEPTH_ZERO) : - GlobalMembersSearch.search<NodeType.NonPV, false>(pos, ss + 1, -(alpha + 1), -alpha, newDepth, !cutNode);
		  }

		  // For PV nodes only, do a full PV search on the first move or after a fail
		  // high (in the latter case search only if value < beta), otherwise let the
		  // parent node fail low with value <= alpha and to try another move.
		  if (PvNode && (moveCount == 1 || (value > alpha && (RootNode || value < beta))))
		  {
			  (ss + 1).pv = pv;
			  (ss + 1).pv[0] = Move.MOVE_NONE;

			  value = newDepth < ((int)Depth.ONE_PLY) != 0 ? givesCheck ? - GlobalMembersSearch.qsearch<NodeType.PV, true>(pos, ss + 1, -beta, -alpha, Depth.DEPTH_ZERO) : -GlobalMembersSearch.qsearch<NodeType.PV, false>(pos, ss + 1, -beta, -alpha, Depth.DEPTH_ZERO) : - GlobalMembersSearch.search<NodeType.PV, false>(pos, ss + 1, -beta, -alpha, newDepth, false);
		  }

		  // Step 17. Undo move
		  pos.undo_move(move);

		  Debug.Assert(value > -Value.VALUE_INFINITE && value < Value.VALUE_INFINITE);

		  // Step 18. Check for new best move
		  if (SpNode)
		  {
			  splitPoint.mutex.@lock();
			  bestValue = splitPoint.bestValue;
			  alpha = splitPoint.alpha;
		  }

		  // Finished searching the move. If a stop or a cutoff occurred, the return
		  // value of the search cannot be trusted, and we return immediately without
		  // updating best move, PV and TT.
		  if (Signals.stop || thisThread.cutoff_occurred())
		  {
			  return Value.VALUE_ZERO;
		  }

		  if (RootNode)
		  {
			  RootMove rm = std.find(RootMoves.GetEnumerator(), RootMoves.end(), move);

			  // PV move or new best move ?
			  if (moveCount == 1 || value > alpha)
			  {
				  rm.score = value;
				  rm.pv.resize(1);

				  Debug.Assert((ss + 1).pv);

				  for (Move * m = (ss + 1).pv; m != Move.MOVE_NONE; ++m)
				  {
					  rm.pv.Add(m);
				  }

				  // We record how often the best move has been changed in each
				  // iteration. This information is used for time management: When
				  // the best move changes frequently, we allocate some more time.
				  if (moveCount > 1)
				  {
					  ++BestMoveChanges;
				  }
			  }
			  else
				  // All other moves but the PV are set to the lowest value: this is
				  // not a problem when sorting because the sort is stable and the
				  // move position in the list is preserved - just the PV is pushed up.
			  {
				  rm.score = -Value.VALUE_INFINITE;
			  }
		  }

		  if (value > bestValue)
		  {
			  bestValue = SpNode ? splitPoint.bestValue = value : value;

			  if (value > alpha)
			  {
				  bestMove = SpNode ? splitPoint.bestMove = move : move;

				  if (PvNode && !RootNode) // Update pv even in fail-high case
				  {
					  GlobalMembersSearch.update_pv(SpNode ? splitPoint.ss.pv : ss.pv, move, (ss + 1).pv);
				  }

				  if (PvNode && value < beta) // Update alpha! Always alpha < beta
				  {
					  alpha = SpNode ? splitPoint.alpha = value : value;
				  }
				  else
				  {
					  Debug.Assert(value >= beta); // Fail high

					  if (SpNode)
					  {
						  splitPoint.cutoff = true;
					  }

					  break;
				  }
			  }
		  }

		  // Step 19. Check for splitting the search
		  if (!SpNode && GlobalMembersThread.Threads.Count >= 2 && depth >= GlobalMembersThread.Threads.minimumSplitDepth && (!thisThread.activeSplitPoint || !thisThread.activeSplitPoint.allSlavesSearching) && thisThread.splitPointsSize < GlobalMembersThread.MAX_SPLITPOINTS_PER_THREAD)
		  {
			  Debug.Assert(bestValue > -Value.VALUE_INFINITE && bestValue < beta);

			  thisThread.split(pos, ss, alpha, beta, bestValue, bestMove, depth, moveCount, mp, NT, cutNode);

			  if (Signals.stop || thisThread.cutoff_occurred())
			  {
				  return Value.VALUE_ZERO;
			  }

			  if (bestValue >= beta)
				  break;
		  }
		}

		if (SpNode)
		{
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
		// All legal moves have been searched and if there are no legal moves, it
		// must be mate or stalemate. If we are in a singular extension search then
		// return a fail low score.
		if (moveCount == 0)
		{
			bestValue = ((int)excludedMove) != 0 ? alpha : inCheck ? GlobalMembersTypes.mated_in(ss.ply) : DrawValue[(int)pos.side_to_move()];
		}

		// Quiet best move: update killers, history, countermoves and followupmoves
		else if (bestValue >= beta && !pos.capture_or_promotion(bestMove) && !inCheck)
		{
			GlobalMembersSearch.update_stats(pos, ss, bestMove, depth, quietsSearched, quietCount - 1);
		}

		tte.save(posKey, GlobalMembersSearch.value_to_tt(bestValue, ss.ply), bestValue >= ((int)beta) != 0 ? Bound.BOUND_LOWER : PvNode && ((int)bestMove) != 0 ? Bound.BOUND_EXACT : Bound.BOUND_UPPER, depth, bestMove, ss.staticEval, GlobalMembersTt.TT.generation());

		Debug.Assert(bestValue > -Value.VALUE_INFINITE && bestValue < Value.VALUE_INFINITE);

		return bestValue;
	  }

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template <NodeType NT, bool InCheck>

  // qsearch() is the quiescence search function, which is called by the main
  // search function when the remaining depth is zero (or, to be more precise,
  // less than ONE_PLY).

	  public static Value qsearch<NodeType NT, bool InCheck>(Position pos, Stack ss, Value alpha, Value beta, Depth depth)
	  {

		bool PvNode = NT == NodeType.PV;

		Debug.Assert(NT == NodeType.PV || NT == NodeType.NonPV);
		Debug.Assert(InCheck == !pos.checkers() == 0);
		Debug.Assert(alpha >= -Value.VALUE_INFINITE && alpha < beta && beta <= Value.VALUE_INFINITE);
		Debug.Assert(PvNode || (alpha == beta - 1));
		Debug.Assert(depth <= Depth.DEPTH_ZERO);

		Move[] pv = new Move[GlobalMembersTypes.MAX_PLY + 1];
		StateInfo st = new StateInfo();
		TTEntry tte;
		uint long posKey;
		Move ttMove;
		Move move;
		Move bestMove;
		Value bestValue;
		Value value;
		Value ttValue;
		Value futilityValue;
		Value futilityBase;
		Value oldAlpha;
		bool ttHit;
		bool givesCheck;
		bool evasionPrunable;
		Depth ttDepth;

		if (PvNode)
		{
			oldAlpha = alpha; // To flag BOUND_EXACT when eval above alpha and no available moves
			(ss + 1).pv = pv;
			ss.pv[0] = Move.MOVE_NONE;
		}

		ss.currentMove = bestMove = Move.MOVE_NONE;
		ss.ply = (ss - 1).ply + 1;

		// Check for an instant draw or if the maximum ply has been reached
		if (pos.is_draw() || ss.ply >= GlobalMembersTypes.MAX_PLY)
		{
			return ss.ply >= GlobalMembersTypes.MAX_PLY && !InCheck ? GlobalMembersEvaluate.evaluate(pos) : DrawValue[(int)pos.side_to_move()];
		}

		Debug.Assert(0 <= ss.ply && ss.ply < GlobalMembersTypes.MAX_PLY);

		// Decide whether or not to include checks: this fixes also the type of
		// TT entry depth that we are going to use. Note that in qsearch we use
		// only two types of depth in TT: DEPTH_QS_CHECKS or DEPTH_QS_NO_CHECKS.
		ttDepth = InCheck || depth >= ((int)Depth.DEPTH_QS_CHECKS) != 0 ? Depth.DEPTH_QS_CHECKS : Depth.DEPTH_QS_NO_CHECKS;

		// Transposition table lookup
		posKey = pos.key();
		tte = GlobalMembersTt.TT.probe(posKey, ref ttHit);
		ttMove = ttHit ? tte.move() : Move.MOVE_NONE;
		ttValue = ttHit ? GlobalMembersSearch.value_from_tt(tte.value(), ss.ply) : Value.VALUE_NONE;

		if (!PvNode && ttHit && tte.depth() >= ttDepth && ttValue != Value.VALUE_NONE && (ttValue >= ((int)beta) != 0 ? ((int)tte.bound() & (int)Bound.BOUND_LOWER) : ((int)tte.bound() & (int)Bound.BOUND_UPPER))) // Only in case of TT access race
		{
			ss.currentMove = ttMove; // Can be MOVE_NONE
			return ttValue;
		}

		// Evaluate the position statically
		if (InCheck)
		{
			ss.staticEval = Value.VALUE_NONE;
			bestValue = futilityBase = -Value.VALUE_INFINITE;
		}
		else
		{
			if (ttHit)
			{
				// Never assume anything on values stored in TT
				if ((ss.staticEval = bestValue = tte.eval()) == Value.VALUE_NONE)
				{
					ss.staticEval = bestValue = GlobalMembersEvaluate.evaluate(pos);
				}

				// Can ttValue be used as a better position evaluation?
				if (ttValue != Value.VALUE_NONE)
				{
					if ((int)tte.bound() & (ttValue > ((int)bestValue) != 0 ? Bound.BOUND_LOWER : Bound.BOUND_UPPER))
					{
						bestValue = ttValue;
					}
				}
			}
			else
			{
				ss.staticEval = bestValue = (ss - 1).currentMove != ((int)Move.MOVE_NULL) != 0 ? GlobalMembersEvaluate.evaluate(pos) : -(ss - 1).staticEval + 2 * GlobalMembersEvaluate.Tempo;
			}

			// Stand pat. Return immediately if static value is at least beta
			if (bestValue >= beta)
			{
				if (!ttHit)
				{
					tte.save(pos.key(), GlobalMembersSearch.value_to_tt(bestValue, ss.ply), Bound.BOUND_LOWER, Depth.DEPTH_NONE, Move.MOVE_NONE, ss.staticEval, GlobalMembersTt.TT.generation());
				}

				return bestValue;
			}

			if (PvNode && bestValue > alpha)
			{
				alpha = bestValue;
			}

			futilityBase = bestValue + 128;
		}

		// Initialize a MovePicker object for the current position, and prepare
		// to search the moves. Because the depth is <= 0 here, only captures,
		// queen promotions and checks (only if depth >= DEPTH_QS_CHECKS) will
		// be generated.
		MovePicker mp = new MovePicker(pos, ttMove, depth, History, GlobalMembersTypes.to_sq((ss - 1).currentMove));
		CheckInfo ci = new CheckInfo(pos);

		// Loop through the moves until no moves remain or a beta cutoff occurs
		while ((move = mp.next_move<false>()) != Move.MOVE_NONE)
		{
		  Debug.Assert(GlobalMembersTypes.is_ok(move));

		  givesCheck = GlobalMembersTypes.type_of(move) == MoveType.NORMAL && !ci.dcCandidates ? ci.checkSq[(int)GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersTypes.from_sq(move)))] & (int)GlobalMembersTypes.to_sq(move) : pos.gives_check(move, ci);

		  // Futility pruning
		  if (!InCheck && !givesCheck && futilityBase > -Value.VALUE_KNOWN_WIN && !pos.advanced_pawn_push(move))
		  {
			  Debug.Assert(GlobalMembersTypes.type_of(move) != MoveType.ENPASSANT); // Due to !pos.advanced_pawn_push

			  futilityValue = futilityBase + GlobalMembersPosition.PieceValue[(int)Phase.EG, (int)pos.piece_on(GlobalMembersTypes.to_sq(move))];

			  if (futilityValue <= alpha)
			  {
				  bestValue = Math.Max(bestValue, futilityValue);
				  continue;
			  }

			  if (futilityBase <= alpha && pos.see(move) <= Value.VALUE_ZERO)
			  {
				  bestValue = Math.Max(bestValue, futilityBase);
				  continue;
			  }
		  }

		  // Detect non-capture evasions that are candidates to be pruned
		  evasionPrunable = InCheck && bestValue > Value.VALUE_MATED_IN_MAX_PLY && !pos.capture(move) && pos.can_castle(pos.side_to_move()) == 0;

		  // Don't search moves with negative SEE values
		  if ((!InCheck || evasionPrunable) && GlobalMembersTypes.type_of(move) != MoveType.PROMOTION && pos.see_sign(move) < Value.VALUE_ZERO)
			  continue;

		  // Speculative prefetch as early as possible
		  GlobalMembersMisc.prefetch(ref (string)GlobalMembersTt.TT.first_entry(pos.key_after(move)));

		  // Check for legality just before making the move
		  if (!pos.legal(move, ci.pinned))
			  continue;

		  ss.currentMove = move;

		  // Make and search the move
		  pos.do_move(move, st, ci, givesCheck);
		  value = givesCheck ? - GlobalMembersSearch.qsearch<NT, true>(pos, ss + 1, -beta, -alpha, depth - Depth.ONE_PLY) : -GlobalMembersSearch.qsearch<NT, false>(pos, ss + 1, -beta, -alpha, depth - Depth.ONE_PLY);
		  pos.undo_move(move);

		  Debug.Assert(value > -Value.VALUE_INFINITE && value < Value.VALUE_INFINITE);

		  // Check for new best move
		  if (value > bestValue)
		  {
			  bestValue = value;

			  if (value > alpha)
			  {
				  if (PvNode) // Update pv even in fail-high case
				  {
					  GlobalMembersSearch.update_pv(ss.pv, move, (ss + 1).pv);
				  }

				  if (PvNode && value < beta) // Update alpha here! Always alpha < beta
				  {
					  alpha = value;
					  bestMove = move;
				  }
				  else // Fail high
				  {
					  tte.save(posKey, GlobalMembersSearch.value_to_tt(value, ss.ply), Bound.BOUND_LOWER, ttDepth, move, ss.staticEval, GlobalMembersTt.TT.generation());

					  return value;
				  }
			  }
		  }
		}

		// All legal moves have been searched. A special case: If we're in check
		// and no legal moves were found, it is checkmate.
		if (InCheck && bestValue == -Value.VALUE_INFINITE)
		{
			return GlobalMembersTypes.mated_in(ss.ply); // Plies to mate from the root
		}

		tte.save(posKey, GlobalMembersSearch.value_to_tt(bestValue, ss.ply), PvNode && bestValue > ((int)oldAlpha) != 0 ? Bound.BOUND_EXACT : Bound.BOUND_UPPER, ttDepth, bestMove, ss.staticEval, GlobalMembersTt.TT.generation());

		Debug.Assert(bestValue > -Value.VALUE_INFINITE && bestValue < Value.VALUE_INFINITE);

		return bestValue;
	  }

  // id_loop() is the main iterative deepening loop. It calls search() repeatedly
  // with increasing depth until the allocated thinking time has been consumed,
  // user stops the search, or the maximum search depth is reached.


	  public static void id_loop(Position pos)
	  {

		Stack[] stack = new Stack[GlobalMembersTypes.MAX_PLY + 4]; // To allow referencing (ss-2) and (ss+2)
		Stack ss = stack + 2;
		Depth depth;
		Value bestValue;
		Value alpha;
		Value beta;
		Value delta;

		std.memset(ss - 2, 0, 5 * sizeof(Stack));

		depth = Depth.DEPTH_ZERO;
		BestMoveChanges = 0;
		bestValue = delta = alpha = -Value.VALUE_INFINITE;
		beta = Value.VALUE_INFINITE;

		GlobalMembersTt.TT.new_search();
		History.clear();
		Gains.clear();
		Countermoves.clear();
		Followupmoves.clear();

		uint multiPV = GlobalMembersUcioption.Options["MultiPV"];
		Skill skill = new Skill(GlobalMembersUcioption.Options["Skill Level"], RootMoves.Count);

		// Do we have to play with skill handicap? In this case enable MultiPV search
		// that we will use behind the scenes to retrieve a set of possible moves.
		multiPV = Math.Max(multiPV, skill.candidates_size());

		// Iterative deepening loop until requested to stop or target depth reached
		while (++depth < Depth.DEPTH_MAX && !Signals.stop && (Limits.depth == 0 || depth <= Limits.depth))
		{
			// Age out PV variability metric
			BestMoveChanges *= 0.5;

			// Save the last iteration's scores before first PV line is searched and
			// all the move scores except the (new) PV are set to -VALUE_INFINITE.
			for (uint i = 0; i < RootMoves.Count; ++i)
			{
				RootMoves[i].previousScore = RootMoves[i].score;
			}

			// MultiPV loop. We perform a full root search for each PV line
			for (PVIdx = 0; PVIdx < Math.Min(multiPV, RootMoves.Count) && !Signals.stop; ++PVIdx)
			{
				// Reset aspiration window starting size
				if (depth >= 5 * Depth.ONE_PLY)
				{
					delta = Value(16);
					alpha = Math.Max(RootMoves[PVIdx].previousScore - delta,-Value.VALUE_INFINITE);
					beta = Math.Min(RootMoves[PVIdx].previousScore + delta, Value.VALUE_INFINITE);
				}

				// Start with a small aspiration window and, in the case of a fail
				// high/low, re-search with a bigger window until we're not failing
				// high/low anymore.
				while (true)
				{
					bestValue = GlobalMembersSearch.search<NodeType.Root, false>(pos, ss, alpha, beta, depth, false);

					// Bring the best move to the front. It is critical that sorting
					// is done with a stable algorithm because all the values but the
					// first and eventually the new best one are set to -VALUE_INFINITE
					// and we want to keep the same order for all the moves except the
					// new PV that goes to the front. Note that in case of MultiPV
					// search the already searched PV lines are preserved.
					std.stable_sort(RootMoves.GetEnumerator() + PVIdx, RootMoves.end());

					// Write PV back to transposition table in case the relevant
					// entries have been overwritten during the search.
					for (uint i = 0; i <= PVIdx; ++i)
					{
						RootMoves[i].insert_pv_in_tt(pos);
					}

					// If search has been stopped break immediately. Sorting and
					// writing PV back to TT is safe because RootMoves is still
					// valid, although it refers to previous iteration.
					if (Signals.stop)
						break;

					// When failing high/low give some update (without cluttering
					// the UI) before a re-search.
					if (multiPV == 1 && (bestValue <= alpha || bestValue >= beta) && GlobalMembersMisc.now() - SearchTime > 3000)
					{
						sync_cout << GlobalMembersSearch.uci_pv(pos, depth, alpha, beta) << sync_endl;
					}

					// In case of failing low/high increase aspiration window and
					// re-search, otherwise exit the loop.
					if (bestValue <= alpha)
					{
						beta = (alpha + beta) / 2;
						alpha = Math.Max(bestValue - delta, -Value.VALUE_INFINITE);

						Signals.failedLowAtRoot = true;
						Signals.stopOnPonderhit = false;
					}
					else if (bestValue >= beta)
					{
						alpha = (alpha + beta) / 2;
						beta = Math.Min(bestValue + delta, Value.VALUE_INFINITE);
					}
					else
						break;

					delta += delta / 2;

					Debug.Assert(alpha >= -Value.VALUE_INFINITE && beta <= Value.VALUE_INFINITE);
				}

				// Sort the PV lines searched so far and update the GUI
				std.stable_sort(RootMoves.GetEnumerator(), RootMoves.GetEnumerator() + PVIdx + 1);

				if (Signals.stop)
				{
					sync_cout << "info nodes " << (int)RootPos.nodes_searched() << " time " << (int)GlobalMembersMisc.now() - SearchTime << sync_endl;
				}

				else if (PVIdx + 1 == Math.Min(multiPV, RootMoves.Count) || GlobalMembersMisc.now() - SearchTime > 3000)
				{
					sync_cout << GlobalMembersSearch.uci_pv(pos, depth, alpha, beta) << sync_endl;
				}
			}

			// If skill levels are enabled and time is up, pick a sub-optimal best move
			if (skill.candidates_size() != 0 && skill.time_to_pick(depth))
			{
				skill.pick_move();
			}

			// Have we found a "mate in x"?
			if (Limits.mate != 0 && bestValue >= Value.VALUE_MATE_IN_MAX_PLY && Value.VALUE_MATE - bestValue <= 2 * Limits.mate)
			{
				Signals.stop = true;
			}

			// Do we have time for the next iteration? Can we stop searching now?
			if (Limits.use_time_management() && !Signals.stop && !Signals.stopOnPonderhit)
			{
				// Take some extra time if the best move has changed
				if (depth > 4 * Depth.ONE_PLY && multiPV == 1)
				{
					TimeMgr.pv_instability(BestMoveChanges);
				}

				// Stop the search if only one legal move is available or all
				// of the available time has been used.
				if (RootMoves.Count == 1 || GlobalMembersMisc.now() - SearchTime > TimeMgr.available_time())
				{
					// If we are allowed to ponder do not stop the search now but
					// keep pondering until the GUI sends "ponderhit" or "stop".
					if (Limits.ponder != 0)
					{
						Signals.stopOnPonderhit = true;
					}
					else
					{
						Signals.stop = true;
					}
				}
			}
		}
	  }

  // value_to_tt() adjusts a mate score from "plies to mate from the root" to
  // "plies to mate from the current position". Non-mate scores are unchanged.
  // The function is called before storing a value in the transposition table.

	  public static Value value_to_tt(Value v, int ply)
	  {

		Debug.Assert(v != Value.VALUE_NONE);

		return v >= ((int)Value.VALUE_MATE_IN_MAX_PLY) != 0 ? v + ply : v <= ((int)Value.VALUE_MATED_IN_MAX_PLY) != 0 ? v - ply : v;
	  }

  // value_from_tt() is the inverse of value_to_tt(): It adjusts a mate score
  // from the transposition table (which refers to the plies to mate/be mated
  // from current position) to "plies to mate/be mated from the root".

	  public static Value value_from_tt(Value v, int ply)
	  {

		return v == ((int)Value.VALUE_NONE) != 0 ? Value.VALUE_NONE : v >= ((int)Value.VALUE_MATE_IN_MAX_PLY) != 0 ? v - ply : v <= ((int)Value.VALUE_MATED_IN_MAX_PLY) != 0 ? v + ply : v;
	  }

  // update_pv() adds current move and appends child pv[]

//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'pv', so pointers on this parameter are left unchanged:
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'childPv', so pointers on this parameter are left unchanged:
	  public static void update_pv(Move * pv, Move move, Move * childPv)
	  {

		for (*pv++ = move; childPv && *childPv != Move.MOVE_NONE;)
		{
			*pv++ = childPv++;
		}
		*pv = Move.MOVE_NONE;
	  }

  // update_stats() updates killers, history, countermoves and followupmoves stats after a fail-high
  // of a quiet move.

	  public static void update_stats(Position pos, Stack ss, Move move, Depth depth, Move[] quiets, int quietsCnt)
	  {

		if (ss.killers[0] != move)
		{
			ss.killers[1] = ss.killers[0];
			ss.killers[0] = move;
		}

		// Increase history value of the cut-off move and decrease all the other
		// played quiet moves.
		Value bonus = new Value((depth / Depth.ONE_PLY) * (depth / Depth.ONE_PLY));
		History.update(pos.moved_piece(move), GlobalMembersTypes.to_sq(move), bonus);
		for (int i = 0; i < quietsCnt; ++i)
		{
			Move m = quiets[i];
			History.update(pos.moved_piece(m), GlobalMembersTypes.to_sq(m), -bonus);
		}

		if (GlobalMembersTypes.is_ok((ss - 1).currentMove))
		{
			Square prevMoveSq = GlobalMembersTypes.to_sq((ss - 1).currentMove);
			Countermoves.update(pos.piece_on(prevMoveSq), prevMoveSq, move);
		}

		if (GlobalMembersTypes.is_ok((ss - 2).currentMove) && (ss - 1).currentMove == (ss - 1).ttMove)
		{
			Square prevOwnMoveSq = GlobalMembersTypes.to_sq((ss - 2).currentMove);
			Followupmoves.update(pos.piece_on(prevOwnMoveSq), prevOwnMoveSq, move);
		}
	  }

  // uci_pv() formats PV information according to the UCI protocol. UCI
  // requires that all (if any) unsearched PV lines are sent using a previous
  // search score.

	  public static string uci_pv(Position pos, Depth depth, Value alpha, Value beta)
	  {

		std.stringstream ss = new std.stringstream();
		int long elapsed = GlobalMembersMisc.now() - SearchTime + 1;
		uint uciPVSize = Math.Min((uint)GlobalMembersUcioption.Options["MultiPV"], RootMoves.Count);
		int selDepth = 0;

		for (uint i = 0; i < GlobalMembersThread.Threads.Count; ++i)
		{
			if (GlobalMembersThread.Threads[i].maxPly > selDepth)
			{
				selDepth = GlobalMembersThread.Threads[i].maxPly;
			}
		}

		for (uint i = 0; i < uciPVSize; ++i)
		{
			bool updated = (i <= PVIdx);

			if (depth == Depth.ONE_PLY && !updated)
				continue;

			Depth d = updated ? depth : depth - Depth.ONE_PLY;
			Value v = updated ? RootMoves[i].score : RootMoves[i].previousScore;

			bool tb = TB.RootInTB && Math.Abs(v) < Value.VALUE_MATE - GlobalMembersTypes.MAX_PLY;
			v = tb ? TB.Score : v;

			if (ss.rdbuf().in_avail()) // Not at first line
			{
				ss << "\n";
			}

			ss << "info depth " << d / Depth.ONE_PLY << " seldepth " << selDepth << " multipv " << (int)i + 1 << " score " << GlobalMembersUci.value(v);

			if (!tb && i == PVIdx)
			{
				  ss << (v >= ((int)beta) != 0 ? " lowerbound" : v <= ((int)alpha) != 0 ? " upperbound" : "");
			}

			ss << " nodes " << (int)pos.nodes_searched() << " nps " << (int)pos.nodes_searched() * 1000 / elapsed << " tbhits " << TB.Hits << " time " << elapsed << " pv";

			for (uint j = 0; j < RootMoves[i].pv.Count; ++j)
			{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: ss << " " << UCI::move(RootMoves[i].pv[j], pos.is_chess960());
				ss << " " << GlobalMembersUci.move(new List(RootMoves[i].pv[j]), pos.is_chess960());
			}
		}

		return ss.str();
	  }

	//template uint long Search::perft(Position pos, Depth depth);


	/// check_time() is called by the timer thread when the timer triggers. It is
	/// used to print debug info and, more importantly, to detect when we are out of
	/// available time and thus stop the search.

	public static void check_time()
	{

	  static int long lastInfoTime = GlobalMembersMisc.now();
	  int long elapsed = GlobalMembersMisc.now() - SearchTime;

	  if (GlobalMembersMisc.now() - lastInfoTime >= 1000)
	  {
		  lastInfoTime = GlobalMembersMisc.now();
		  GlobalMembersMisc.dbg_print();
	  }

	  // An engine may not stop pondering until told so by the GUI
	  if (Limits.ponder != 0)
		  return;

	  if (Limits.use_time_management())
	  {
		  bool stillAtFirstMove = Signals.firstRootMove && !Signals.failedLowAtRoot && elapsed > TimeMgr.available_time() * 75 / 100;

		  if (stillAtFirstMove || elapsed > TimeMgr.maximum_time() - 2 * TimerThread.Resolution)
		  {
			  Signals.stop = true;
		  }
	  }
	  else if (Limits.movetime != 0 && elapsed >= Limits.movetime)
	  {
		  Signals.stop = true;
	  }

	  else if (Limits.nodes)
	  {
		  GlobalMembersThread.Threads.mutex.@lock();

		  int long nodes = RootPos.nodes_searched();

		  // Loop across all split points and sum accumulated SplitPoint nodes plus
		  // all the currently active positions nodes.
		  for (uint i = 0; i < GlobalMembersThread.Threads.Count; ++i)
		  {
			  for (int j = 0; j < GlobalMembersThread.Threads[i].splitPointsSize; ++j)
			  {
				  SplitPoint sp = GlobalMembersThread.Threads[i].splitPoints[j];

				  sp.mutex.@lock();

				  nodes += sp.nodes;

				  for (uint idx = 0; idx < GlobalMembersThread.Threads.Count; ++idx)
				  {
					  if (sp.slavesMask.test(idx) && GlobalMembersThread.Threads[idx].activePosition)
					  {
						  nodes += GlobalMembersThread.Threads[idx].activePosition.nodes_searched();
					  }
				  }

				  sp.mutex.unlock();
			  }
		  }

		  GlobalMembersThread.Threads.mutex.unlock();

		  if (nodes >= Limits.nodes)
		  {
			  Signals.stop = true;
		  }
	  }
	}
}

/*
  Stockfish, a UCI chess playing engine derived from Glaurung 2.1
  Copyright (C) 2004-2008 Tord Romstad (Glaurung author)
  Copyright (C) 2008-2015 Marco Costalba, Joona Kiiski, Tord Romstad

  Stockfish is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  Stockfish is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/





using TB = Tablebases;

//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

  // Different node types, used as template parameter
  public enum NodeType
  {
	  Root,
	  PV,
	  NonPV
  }

  public class Skill
  {
	public Skill(int l, uint rootSize)
	{
		this.level = l;
		this.candidates = l < 20 ? Math.Min(4, (int)rootSize) : 0;
		this.best = new Move(Move.MOVE_NONE);
	}
   public void Dispose()
   {
	  if (candidates != 0) // Swap best PV line with the sub-optimal one
	  {
		  std.swap(GlobalMembersSearch.RootMoves[0], *std.find(GlobalMembersSearch.RootMoves.GetEnumerator(), GlobalMembersSearch.RootMoves.end(), ((int)best) != 0 ? best : pick_move()));
	  }
   }

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: uint candidates_size() const
	public uint candidates_size()
	{
		return candidates;
	}
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool time_to_pick(Depth depth) const
	public bool time_to_pick(Depth depth)
	{
		return depth / Depth.ONE_PLY == 1 + level;
	}

	// When playing with a strength handicap, choose best move among the first 'candidates'
	// RootMoves using a statistical rule dependent on 'level'. Idea by Heinz van Saanen.

//C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
	private PRNG pick_move_rng = new PRNG(GlobalMembersMisc.now());
	public Move pick_move()
	{

	  // PRNG sequence should be non-deterministic, so we seed it with the time at init
//C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
//	  static PRNG rng(Time::now());

	  // RootMoves are already sorted by score in descending order
	  int variance = Math.Min(GlobalMembersSearch.RootMoves[0].score - GlobalMembersSearch.RootMoves[candidates - 1].score, Value.PawnValueMg);
	  int weakness = 120 - 2 * level;
	  int maxScore = -Value.VALUE_INFINITE;
	  best = Move.MOVE_NONE;

	  // Choose best move. For each move score we add two terms both dependent on
	  // weakness. One deterministic and bigger for weaker moves, and one random,
	  // then we choose the move with the resulting highest score.
	  for (uint i = 0; i < candidates; ++i)
	  {
		  int score = (int)GlobalMembersSearch.RootMoves[i].score;

		  // Don't allow crazy blunders even at very low skills
		  if (i > 0 && GlobalMembersSearch.RootMoves[i - 1].score > score + 2 * Value.PawnValueMg)
			  break;

		  // This is our magic formula
		  score += (weakness * (int)(GlobalMembersSearch.RootMoves[0].score - score) + variance * (pick_move_rng.rand<uint>() % weakness)) / 128;

		  if (score > maxScore)
		  {
			  maxScore = score;
			  best = GlobalMembersSearch.RootMoves[i].pv[0];
		  }
	  }
	  return best;
	}

	public int level;
	public uint candidates;
	public Move best;
  }



/// Search::init() is called during startup to initialize various lookup tables



/// Search::perft() is our utility to verify move generation. All the leaf nodes
/// up to the given depth are generated and counted and the sum returned.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool Root>


/// Search::think() is the external interface to Stockfish's search, and is
/// called by the main thread when the program receives the UCI 'go' command. It
/// searches from RootPos and at the end prints the "bestmove" to output.



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace



/// RootMove::insert_pv_in_tt() is called at the end of a search iteration, and
/// inserts the PV back into the TT. This makes sure the old PV moves are searched
/// first, even if the old TT entries have been overwritten.



/// RootMove::extract_ponder_from_tt() is called in case we have no ponder move before
/// exiting the search, for instance in case we stop the search during a fail high at
/// root. We try hard to have a ponder move to return to the GUI, otherwise in case of
/// 'ponder on' we have nothing to think on.



/// Thread::idle_loop() is where the thread is parked when it has no work to do

