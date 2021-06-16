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
#include <iomanip>
#include <sstream>

#include "bitcount.h"
#include "evaluate.h"
#include "material.h"
#include "pawns.h"
#include "thread.h"
#include "ucioption.h"

namespace {

  // Struct EvalInfo contains various information computed and collected
  // by the evaluation functions.
  struct EvalInfo {

    // Pointers to material and pawn hash table entries
    Material::Entry* mi;
    Pawns::Entry* pi;

    // attackedBy[color][piece type] is a bitboard representing all squares
    // attacked by a given color and piece type, attackedBy[color][ALL_PIECES]
    // contains all squares attacked by the given color.
    Bitboard attackedBy[COLOR_NB][PIECE_TYPE_NB];

    // kingRing[color] is the zone around the king which is considered
    // by the king safety evaluation. This consists of the squares directly
    // adjacent to the king, and the three (or two, for a king on an edge file)
    // squares two ranks in front of the king. For instance, if black's king
    // is on g8, kingRing[BLACK] is a bitboard containing the squares f8, h8,
    // f7, g7, h7, f6, g6 and h6.
    Bitboard kingRing[COLOR_NB];

    // kingAttackersCount[color] is the number of pieces of the given color
    // which attack a square in the kingRing of the enemy king.
    int kingAttackersCount[COLOR_NB];

    // kingAttackersWeight[color] is the sum of the "weight" of the pieces of the
    // given color which attack a square in the kingRing of the enemy king. The
    // weights of the individual piece types are given by the variables
    // QueenAttackWeight, RookAttackWeight, BishopAttackWeight and
    // KnightAttackWeight in evaluate.cpp
    int kingAttackersWeight[COLOR_NB];

    // kingAdjacentZoneAttacksCount[color] is the number of attacks to squares
    // directly adjacent to the king of the given color. Pieces which attack
    // more than one square are counted multiple times. For instance, if black's
    // king is on g8 and there's a white knight on g5, this knight adds
    // 2 to kingAdjacentZoneAttacksCount[BLACK].
    int kingAdjacentZoneAttacksCount[COLOR_NB];

    Bitboard pinnedPieces[COLOR_NB];
  };

  namespace Tracing {

    enum Terms { // First 8 entries are for PieceType
      MATERIAL = 8, IMBALANCE, MOBILITY, THREAT, PASSED, SPACE, TOTAL, TERMS_NB
    };

    Score terms[COLOR_NB][TERMS_NB];
    EvalInfo ei;
    ScaleFactor sf;

    double to_cp(Value v);
    void add_term(int idx, Score term_w, Score term_b = SCORE_ZERO);
    void format_row(std::stringstream& ss, const char* name, int idx);
    std::string do_trace(const Position& pos);
  }

  // Evaluation weights, indexed by evaluation term
  enum { Mobility, PawnStructure, PassedPawns, Space, KingSafety };
  const struct Weight { int mg, eg; } Weights[] = {
    {289, 344}, {233, 201}, {221, 273}, {46, 0}, {318, 0}
  };

  typedef Value V;
  #define S(mg, eg) make_score(mg, eg)

  // MobilityBonus[PieceType][attacked] contains bonuses for middle and end
  // game, indexed by piece type and number of attacked squares not occupied by
  // friendly pieces.
  const Score MobilityBonus[][32] = {
    {}, {},
    { S(-65,-50), S(-42,-30), S(-9,-10), S( 3,  0), S(15, 10), S(27, 20), // Knights
      S( 37, 28), S( 42, 31), S(44, 33) },
    { S(-52,-47), S(-28,-23), S( 6,  1), S(20, 15), S(34, 29), S(48, 43), // Bishops
      S( 60, 55), S( 68, 63), S(74, 68), S(77, 72), S(80, 75), S(82, 77),
      S( 84, 79), S( 86, 81) },
    { S(-47,-53), S(-31,-26), S(-5,  0), S( 1, 16), S( 7, 32), S(13, 48), // Rooks
      S( 18, 64), S( 22, 80), S(26, 96), S(29,109), S(31,115), S(33,119),
      S( 35,122), S( 36,123), S(37,124) },
    { S(-42,-40), S(-28,-23), S(-5, -7), S( 0,  0), S( 6, 10), S(11, 19), // Queens
      S( 13, 29), S( 18, 38), S(20, 40), S(21, 41), S(22, 41), S(22, 41),
      S( 22, 41), S( 23, 41), S(24, 41), S(25, 41), S(25, 41), S(25, 41),
      S( 25, 41), S( 25, 41), S(25, 41), S(25, 41), S(25, 41), S(25, 41),
      S( 25, 41), S( 25, 41), S(25, 41), S(25, 41) }
  };

  // Outpost[Square] contains bonuses for piece outposts indexed by square
  // (from white's point of view), supposing a opponent king in the center.
  const Value Outpost[SQUARE_NB] = {

   // A     B     C     D     E     F     G     H
    V(0), V(0), V(0), V(0), V(0), V(0), V(0), V(0),   // rank 1
    V(0), V(0), V(0), V(0), V(0), V(0), V(0), V(0),   // rank 2






    V(0), V(0), V(3), V(4), V(4), V(3), V(0), V(0),   // rank 3
    V(0), V(3),V(10),V(13),V(13),V(10), V(3), V(0),   // rank 4
    V(0), V(7),V(18),V(21),V(21),V(18), V(7), V(0),   // rank 5


    V(0), V(3), V(8), V(8), V(8), V(8), V(3), V(0),   // rank 6
  };

  
  // Outpost_[King File][Square] stores shifted versions of the Outpost array
  Value Outpost_[FILE_NB][SQUARE_NB];
  
  // Threat[attacking][attacked] contains bonuses according to which piece
  // type attacks which one.
  const Score Threat[][PIECE_TYPE_NB] = {
    { S(0, 0), S( 7, 39), S(24, 49), S(24, 49), S(41,100), S(41,100) }, // Minor
    { S(0, 0), S(15, 39), S(15, 45), S(15, 45), S(15, 45), S(24, 49) }  // Major
  };

  // ThreatenedByPawn[PieceType] contains a penalty according to which piece
  // type is attacked by an enemy pawn.
  const Score ThreatenedByPawn[] = {
    S(0, 0), S(0, 0), S(80, 119), S(80, 119), S(117, 199), S(127, 218)
  };


  // Hanging[side to move] contains a bonus for each enemy hanging piece
  const Score Hanging[2] = { S(23, 20) , S(35, 45) };
#undef S

 const int bishop_pawn_mg = Options["bishop_pawn_mg"] * 8/100;
 const int bishop_pawn_eg = Options["bishop_pawn_eg"] * 12/100;
 const int good_bishop_mg = Options["good_bishop_mg"] * 4/100;
 const int good_bishop_eg = Options["good_bishop_eg"] * 6/100;
 const int unstoppable_mg = Options["unstoppable_mg"] * 0/100;
 const int unstoppable_eg = Options["unstoppable_eg"] * 20/100;
 const int knightspan_mg = Options["knightspan_mg"] * 0/100;
 const int knightspan_eg = Options["knightspan_eg"] * 5/100;

 const Score BishopPawns = make_score( bishop_pawn_mg, bishop_pawn_eg);
 const Score GoodBishop = make_score( good_bishop_mg, good_bishop_eg);
 const Score Unstoppable = make_score( unstoppable_mg, unstoppable_eg);
 const Score KnightSpan = make_score( knightspan_mg, knightspan_eg);

 const Score RookOnPawn       = make_score(10, 28);
 const Score RookOpenFile     = make_score(43, 21);
 const Score RookSemiopenFile = make_score(19, 10);
 const Score MinorBehindPawn  = make_score(16, 0);
 const Score TrappedRook      = make_score(92, 0);













  // Penalty for a bishop on a1/h1 (a8/h8 for black) which is trapped by
  // a friendly pawn on b2/g2 (b7/g7 for black). This can obviously only
  // happen in Chess960 games.
  const Score TrappedBishopA1H1 = make_score(50, 50);



  // SpaceMask[Color] contains the area of the board which is considered
  // by the space evaluation. In the middlegame, each side is given a bonus
  // based on how many squares inside this area are safe and available for
  // friendly minor pieces.
  const Bitboard SpaceMask[] = {
    (FileCBB | FileDBB | FileEBB | FileFBB) & (Rank2BB | Rank3BB | Rank4BB),
    (FileCBB | FileDBB | FileEBB | FileFBB) & (Rank7BB | Rank6BB | Rank5BB)
  };

  // King danger constants and variables. The king danger scores are taken
  // from KingDanger[]. Various little "meta-bonuses" measuring the strength
  // of the enemy attack are added up into an integer, which is used as an
  // index to KingDanger[].
  //
  // KingAttackWeights[PieceType] contains king attack weights by piece type
  const int KingAttackWeights[] = { 0, 0, 2, 2, 3, 5 };

  // Bonuses for enemy's safe checks
  const int QueenContactCheck = 24;
  const int RookContactCheck  = 16;
  const int QueenCheck        = 12;
  const int RookCheck         = 8;
  const int BishopCheck       = 2;
  const int KnightCheck       = 3;

  // KingDanger[attackUnits] contains the actual king danger weighted
  // scores, indexed by a calculated integer number.
  Score KingDanger[128];


  // apply_weight() weighs score 'v' by weight 'w' trying to prevent overflow
  Score apply_weight(Score v, const Weight& w) {
    return make_score(mg_value(v) * w.mg / 256, eg_value(v) * w.eg / 256);
  }


  // init_eval_info() initializes king bitboards for given color adding
  // pawn attacks. To be done at the beginning of the evaluation.

  template<Color Us>
  void init_eval_info(const Position& pos, EvalInfo& ei) {

    const Color  Them = (Us == WHITE ? BLACK : WHITE);
    const Square Down = (Us == WHITE ? DELTA_S : DELTA_N);

    ei.pinnedPieces[Us] = pos.pinned_pieces(Us);

    Bitboard b = ei.attackedBy[Them][KING] = pos.attacks_from<KING>(pos.king_square(Them));
    ei.attackedBy[Us][ALL_PIECES] = ei.attackedBy[Us][PAWN] = ei.pi->pawn_attacks(Us);

    // Init king safety tables only if we are going to use them
    if (pos.count<QUEEN>(Us) && pos.non_pawn_material(Us) > QueenValueMg + PawnValueMg)
    {
        ei.kingRing[Them] = b | shift_bb<Down>(b);
        b &= ei.attackedBy[Us][PAWN];
        ei.kingAttackersCount[Us] = b ? popcount<Max15>(b) : 0;
        ei.kingAdjacentZoneAttacksCount[Us] = ei.kingAttackersWeight[Us] = 0;
    }
    else
        ei.kingRing[Them] = ei.kingAttackersCount[Us] = 0;
  }


  // evaluate_outposts() evaluates outpost squares

  template<PieceType Pt, Color Us>
  Score evaluate_outposts(const Position& pos, EvalInfo& ei, Square s) {

    const Color Them = (Us == WHITE ? BLACK : WHITE);



    // Initial bonus based on square
    Value bonus = Outpost_[file_of(pos.king_square(Them))][relative_square(Us, s)];

    // Increase bonus if supported by pawn, especially if the opponent has
    // no minor piece which can trade with the outpost piece.
    if (bonus && (ei.attackedBy[Us][PAWN] & s))
    {
        if (   !pos.pieces(Them, KNIGHT)
            && !(squares_of_color(s) & pos.pieces(Them, BISHOP)))
            bonus += bonus + bonus / 2;
        else
            bonus += bonus / 2;
    }

    return make_score(bonus * 2, bonus / 2);
  }


  // evaluate_pieces() assigns bonuses and penalties to the pieces of a given color

  template<PieceType Pt, Color Us, bool Trace>
  Score evaluate_pieces(const Position& pos, EvalInfo& ei, Score* mobility, Bitboard* mobilityArea) {

    Bitboard b;
    Square s;
    Score score = SCORE_ZERO;

    const PieceType NextPt = (Us == WHITE ? Pt : PieceType(Pt + 1));
    const Color Them = (Us == WHITE ? BLACK : WHITE);
    const Square* pl = pos.list<Pt>(Us);

    ei.attackedBy[Us][Pt] = 0;

    while ((s = *pl++) != SQ_NONE)
    {
        // Find attacked squares, including x-ray attacks for bishops and rooks
        b = Pt == BISHOP ? attacks_bb<BISHOP>(s, pos.pieces() ^ pos.pieces(Us, QUEEN))
          : Pt ==   ROOK ? attacks_bb<  ROOK>(s, pos.pieces() ^ pos.pieces(Us, ROOK, QUEEN))
                         : pos.attacks_from<Pt>(s);

        if (ei.pinnedPieces[Us] & s)
            b &= LineBB[pos.king_square(Us)][s];

        ei.attackedBy[Us][ALL_PIECES] |= ei.attackedBy[Us][Pt] |= b;

        if (b & ei.kingRing[Them])
        {
            ei.kingAttackersCount[Us]++;
            ei.kingAttackersWeight[Us] += KingAttackWeights[Pt];
            Bitboard bb = b & ei.attackedBy[Them][KING];
            if (bb)
                ei.kingAdjacentZoneAttacksCount[Us] += popcount<Max15>(bb);
        }

        if (Pt == QUEEN)
            b &= ~(  ei.attackedBy[Them][KNIGHT]
                   | ei.attackedBy[Them][BISHOP]
                   | ei.attackedBy[Them][ROOK]);

        int mob = Pt != QUEEN ? popcount<Max15>(b & mobilityArea[Us])
                              : popcount<Full >(b & mobilityArea[Us]);

        mobility[Us] += MobilityBonus[Pt][mob];

        // Decrease score if we are attacked by an enemy pawn. The remaining part
        // of threat evaluation must be done later when we have full attack info.
        if (ei.attackedBy[Them][PAWN] & s)
            score -= ThreatenedByPawn[Pt];
			
        // Evaluate the quality of the piece as an outpost
        if (!(pos.pieces(Them, PAWN) & pawn_attack_span(Us, s)))
            score += evaluate_outposts<Pt, Us>(pos, ei, s);			

        if (Pt == BISHOP || Pt == KNIGHT)
        {
             // Penalty for bishop with same colored pawns
             if (Pt == BISHOP)
            {
                 score -= BishopPawns * ei.pi->pawns_on_same_color_squares(Us, s);




                 
                 if (Pt == KNIGHT)
                	 score -= KnightSpan * std::max(std::max(ei.pi->pawnSpan[Them] - 4, ei.pi->pawnSpan[Us] - 5),  0);
                	 
            // psq tables already make sure bishops lying beyond RANK_5 have a better score
            // A good bishop lies behind the third rank but has access to squares on the enemy side
            bool good_bishop = ((Us == WHITE) ? ((b & 0xffffff7e00000000) != 0) : ((b & 0x7effffff) != 0)) && (relative_rank(Us, s) <= RANK_3);
            if(good_bishop)
               score += GoodBishop * ei.pi->pawns_on_same_color_squares(Us, s);
            }

            // Bishop or knight behind a pawn
            if (    relative_rank(Us, s) < RANK_5
                && (pos.pieces(PAWN) & (s + pawn_push(Us))))
                score += MinorBehindPawn;
        }

        if (Pt == ROOK)
        {
            // Rook piece attacking enemy pawns on the same rank/file
            if (relative_rank(Us, s) >= RANK_5)
            {
                Bitboard pawns = pos.pieces(Them, PAWN) & PseudoAttacks[ROOK][s];
                if (pawns)
                    score += popcount<Max15>(pawns) * RookOnPawn;
            }

            // Give a bonus for a rook on a open or semi-open file
            if (ei.pi->semiopen_file(Us, file_of(s)))
                score += ei.pi->semiopen_file(Them, file_of(s)) ? RookOpenFile : RookSemiopenFile;

            if (mob > 3 || ei.pi->semiopen_file(Us, file_of(s)))
                continue;

            Square ksq = pos.king_square(Us);

            // Penalize rooks which are trapped by a king. Penalize more if the
            // king has lost its castling capability.
            if (   ((file_of(ksq) < FILE_E) == (file_of(s) < file_of(ksq)))
                && (rank_of(ksq) == rank_of(s) || relative_rank(Us, ksq) == RANK_1)
                && !ei.pi->semiopen_side(Us, file_of(ksq), file_of(s) < file_of(ksq)))
                score -= (TrappedRook - make_score(mob * 22, 0)) * (1 + !pos.can_castle(Us));
        }

        // An important Chess960 pattern: A cornered bishop blocked by a friendly
        // pawn diagonally in front of it is a very serious problem, especially
        // when that pawn is also blocked.
        if (   Pt == BISHOP
            && pos.is_chess960()
            && (s == relative_square(Us, SQ_A1) || s == relative_square(Us, SQ_H1)))
        {
            Square d = pawn_push(Us) + (file_of(s) == FILE_A ? DELTA_E : DELTA_W);
            if (pos.piece_on(s + d) == make_piece(Us, PAWN))
                score -= !pos.empty(s + d + pawn_push(Us))                ? TrappedBishopA1H1 * 4
                        : pos.piece_on(s + d + d) == make_piece(Us, PAWN) ? TrappedBishopA1H1 * 2
                                                                          : TrappedBishopA1H1;
        }
    }

    if (Trace)
        Tracing::terms[Us][Pt] = score;

    return score - evaluate_pieces<NextPt, Them, Trace>(pos, ei, mobility, mobilityArea);
  }

  template<>
  Score evaluate_pieces<KING, WHITE, false>(const Position&, EvalInfo&, Score*, Bitboard*) { return SCORE_ZERO; }
  template<>
  Score evaluate_pieces<KING, WHITE,  true>(const Position&, EvalInfo&, Score*, Bitboard*) { return SCORE_ZERO; }


  // evaluate_king() assigns bonuses and penalties to a king of a given color

  template<Color Us, bool Trace>
  Score evaluate_king(const Position& pos, const EvalInfo& ei) {

    const Color Them = (Us == WHITE ? BLACK : WHITE);

    Bitboard undefended, b, b1, b2, safe;
    int attackUnits;
    const Square ksq = pos.king_square(Us);

    // King shelter and enemy pawns storm
    Score score = ei.pi->king_safety<Us>(pos, ksq);

    // Main king safety evaluation
    if (ei.kingAttackersCount[Them])
    {
        // Find the attacked squares around the king which have no defenders
        // apart from the king itself
        undefended =  ei.attackedBy[Them][ALL_PIECES]
                    & ei.attackedBy[Us][KING]
                    & ~(  ei.attackedBy[Us][PAWN]   | ei.attackedBy[Us][KNIGHT]
                        | ei.attackedBy[Us][BISHOP] | ei.attackedBy[Us][ROOK]
                        | ei.attackedBy[Us][QUEEN]);

        // Initialize the 'attackUnits' variable, which is used later on as an
        // index to the KingDanger[] array. The initial value is based on the
        // number and types of the enemy's attacking pieces, the number of
        // attacked and undefended squares around our king and the quality of
        // the pawn shelter (current 'score' value).
        attackUnits =  std::min(20, (ei.kingAttackersCount[Them] * ei.kingAttackersWeight[Them]) / 2)
                     + 3 * (ei.kingAdjacentZoneAttacksCount[Them] + popcount<Max15>(undefended))
                     + 2 * (ei.pinnedPieces[Us] != 0)


                     - mg_value(score) / 32;

        // Analyse the enemy's safe queen contact checks. Firstly, find the
        // undefended squares around the king that are attacked by the enemy's
        // queen...
        b = undefended & ei.attackedBy[Them][QUEEN] & ~pos.pieces(Them);
        if (b)
        {
            // ...and then remove squares not supported by another enemy piece
            b &= (  ei.attackedBy[Them][PAWN]   | ei.attackedBy[Them][KNIGHT]
                  | ei.attackedBy[Them][BISHOP] | ei.attackedBy[Them][ROOK]);

            if (b)
                attackUnits +=  QueenContactCheck * popcount<Max15>(b);


        }

        // Analyse the enemy's safe rook contact checks. Firstly, find the
        // undefended squares around the king that are attacked by the enemy's
        // rooks...
        b = undefended & ei.attackedBy[Them][ROOK] & ~pos.pieces(Them);

        // Consider only squares where the enemy's rook gives check
        b &= PseudoAttacks[ROOK][ksq];

        if (b)
        {
            // ...and then remove squares not supported by another enemy piece
            b &= (  ei.attackedBy[Them][PAWN]   | ei.attackedBy[Them][KNIGHT]
                  | ei.attackedBy[Them][BISHOP] | ei.attackedBy[Them][QUEEN]);

            if (b)
                attackUnits +=  RookContactCheck * popcount<Max15>(b);


        }

        // Analyse the enemy's safe distance checks for sliders and knights
        safe = ~(pos.pieces(Them) | ei.attackedBy[Us][ALL_PIECES]);

        b1 = pos.attacks_from<ROOK>(ksq) & safe;
        b2 = pos.attacks_from<BISHOP>(ksq) & safe;

        // Enemy queen safe checks
        b = (b1 | b2) & ei.attackedBy[Them][QUEEN];
        if (b)
            attackUnits += QueenCheck * popcount<Max15>(b);

        // Enemy rooks safe checks
        b = b1 & ei.attackedBy[Them][ROOK];
        if (b)
            attackUnits += RookCheck * popcount<Max15>(b);

        // Enemy bishops safe checks
        b = b2 & ei.attackedBy[Them][BISHOP];
        if (b)
            attackUnits += BishopCheck * popcount<Max15>(b);

        // Enemy knights safe checks
        b = pos.attacks_from<KNIGHT>(ksq) & ei.attackedBy[Them][KNIGHT] & safe;
        if (b)
            attackUnits += KnightCheck * popcount<Max15>(b);

        // To index KingDanger[] attackUnits must be in [0, 99] range
        attackUnits = std::min(99, std::max(0, attackUnits));

        // Finally, extract the king danger score from the KingDanger[]
        // array and subtract the score from evaluation.
        score -= KingDanger[attackUnits];
    }

    if (Trace)
        Tracing::terms[Us][KING] = score;

    return score;
  }


  // evaluate_threats() assigns bonuses according to the type of attacking piece

  // and the type of attacked one.

  template<Color Us, bool Trace>
  Score evaluate_threats(const Position& pos, const EvalInfo& ei) {

    const Color Them = (Us == WHITE ? BLACK : WHITE);







    Bitboard b, weakEnemies;






    Score score = SCORE_ZERO;


























    // Enemies not defended by a pawn and under our attack
    weakEnemies =  pos.pieces(Them)
                 & ~ei.attackedBy[Them][PAWN]
                 & ei.attackedBy[Us][ALL_PIECES];

    // Add a bonus according if the attacking pieces are minor or major
    if (weakEnemies)
    {
        b = weakEnemies & (ei.attackedBy[Us][PAWN] | ei.attackedBy[Us][KNIGHT] | ei.attackedBy[Us][BISHOP]);
        if (b)
            score += Threat[0][type_of(pos.piece_on(lsb(b)))];

        b = weakEnemies & (ei.attackedBy[Us][ROOK] | ei.attackedBy[Us][QUEEN]);
        if (b)
            score += Threat[1][type_of(pos.piece_on(lsb(b)))];

        b = weakEnemies & ~ei.attackedBy[Them][ALL_PIECES];
        if (b)
            score += more_than_one(b) ? Hanging[Us != pos.side_to_move()] * popcount<Max15>(b)
                                      : Hanging[Us == pos.side_to_move()];
    }


    if (Trace)
        Tracing::terms[Us][Tracing::THREAT] = score;

    return score;
  }


  // evaluate_passed_pawns() evaluates the passed pawns of the given color

  template<Color Us, bool Trace>
  Score evaluate_passed_pawns(const Position& pos, const EvalInfo& ei) {

    const Color Them = (Us == WHITE ? BLACK : WHITE);

    Bitboard b, squaresToQueen, defendedSquares, unsafeSquares;
    Score score = SCORE_ZERO;

    b = ei.pi->passed_pawns(Us);

    while (b)
    {
        Square s = pop_lsb(&b);

        assert(pos.pawn_passed(Us, s));

        int r = relative_rank(Us, s) - RANK_2;
        int rr = r * (r - 1);

        // Base bonus based on rank
        Value mbonus = Value(17 * rr), ebonus = Value(7 * (rr + r + 1));

        if (rr)
        {
            Square blockSq = s + pawn_push(Us);

            // Adjust bonus based on the king's proximity
            ebonus +=  square_distance(pos.king_square(Them), blockSq) * 5 * rr
                     - square_distance(pos.king_square(Us  ), blockSq) * 2 * rr;

            // If blockSq is not the queening square then consider also a second push
            if (relative_rank(Us, blockSq) != RANK_8)
                ebonus -= square_distance(pos.king_square(Us), blockSq + pawn_push(Us)) * rr;

            // If the pawn is free to advance, then increase the bonus
            if (pos.empty(blockSq))
            {
                // If there is a rook or queen attacking/defending the pawn from behind,
                // consider all the squaresToQueen. Otherwise consider only the squares
                // in the pawn's path attacked or occupied by the enemy.
                defendedSquares = unsafeSquares = squaresToQueen = forward_bb(Us, s);
                // If there is an enemy rook or queen attacking the pawn from behind,
                // add all X-ray attacks by the rook or queen. Otherwise consider only
                // the squares in the pawn's path attacked or occupied by the enemy.
                if (    unlikely(forward_bb(Them, s) & pos.pieces(Them, ROOK, QUEEN))
                    && (forward_bb(Them, s) & pos.pieces(Them, ROOK, QUEEN) & pos.attacks_from<ROOK>(s)))
                    unsafeSquares = squaresToQueen;
                else
                    unsafeSquares = squaresToQueen & (ei.attackedBy[Them][ALL_PIECES] | pos.pieces(Them));

                if (    unlikely(forward_bb(Them, s) & pos.pieces(Us, ROOK, QUEEN))
                    && (forward_bb(Them, s) & pos.pieces(Us, ROOK, QUEEN) & pos.attacks_from<ROOK>(s)))
                    defendedSquares = squaresToQueen;
                else
                    defendedSquares = squaresToQueen & ei.attackedBy[Us][ALL_PIECES];











                // If there aren't any enemy attacks, assign a big bonus. Otherwise
                // assign a smaller bonus if the block square isn't attacked.
                int k = !unsafeSquares ? 15 : !(unsafeSquares & blockSq) ? 9 : 0;

                // If the path to queen is fully defended, assign a big bonus.
                // Otherwise assign a smaller bonus if the block square is defended.
                if (defendedSquares == squaresToQueen)
                    k += 6;

                else if (defendedSquares & blockSq)
                    k += 4;

                mbonus += k * rr, ebonus += k * rr;
            }
            else if (pos.pieces(Us) & blockSq)
                mbonus += rr * 3 + r * 2 + 3, ebonus += rr + r * 2;


        } // rr != 0
        if (pos.count<PAWN>(Us) < pos.count<PAWN>(Them))
            ebonus += ebonus / 4;

        score += make_score(mbonus, ebonus);
    }

    if (Trace)
        Tracing::terms[Us][Tracing::PASSED] = apply_weight(score, Weights[PassedPawns]);

    // Add the scores to the middlegame and endgame eval
    return apply_weight(score, Weights[PassedPawns]);
  }


  // evaluate_unstoppable_pawns() scores the most advanced among the passed and
  // candidate pawns. In case both players have no pieces but pawns, this is
  // somewhat related to the possibility that pawns are unstoppable.

  Score evaluate_unstoppable_pawns(Color us, const EvalInfo& ei) {

    Bitboard b = ei.pi->passed_pawns(us) | ei.pi->candidate_pawns(us);

    return !b ? Unstoppable * int(relative_rank(us, frontmost_sq(us, b))) : SCORE_ZERO;
  }


  // evaluate_space() computes the space evaluation for a given side. The
  // space evaluation is a simple bonus based on the number of safe squares
  // available for minor pieces on the central four files on ranks 2--4. Safe
  // squares one, two or three squares behind a friendly pawn are counted
  // twice. Finally, the space bonus is scaled by a weight taken from the
  // material hash table. The aim is to improve play on game opening.
  template<Color Us>
  int evaluate_space(const Position& pos, const EvalInfo& ei) {

    const Color Them = (Us == WHITE ? BLACK : WHITE);

    // Find the safe squares for our pieces inside the area defined by
    // SpaceMask[]. A square is unsafe if it is attacked by an enemy
    // pawn, or if it is undefended and attacked by an enemy piece.
    Bitboard safe =   SpaceMask[Us]
                   & ~pos.pieces(Us, PAWN)
                   & ~ei.attackedBy[Them][PAWN]
                   & (ei.attackedBy[Us][ALL_PIECES] | ~ei.attackedBy[Them][ALL_PIECES]);

    // Find all squares which are at most three squares behind some friendly pawn
    Bitboard behind = pos.pieces(Us, PAWN);
    behind |= (Us == WHITE ? behind >>  8 : behind <<  8);
    behind |= (Us == WHITE ? behind >> 16 : behind << 16);

    // Since SpaceMask[Us] is fully on our half of the board
    assert(unsigned(safe >> (Us == WHITE ? 32 : 0)) == 0);

    // Count safe + (behind & safe) with a single popcount
    return popcount<Full>((Us == WHITE ? safe << 32 : safe >> 32) | (behind & safe));
  }


  // do_evaluate() is the evaluation entry point, called directly from evaluate()

  template<bool Trace>
  Value do_evaluate(const Position& pos) {

    assert(!pos.checkers());

    EvalInfo ei;
    Score score, mobility[2] = { SCORE_ZERO, SCORE_ZERO };
    Thread* thisThread = pos.this_thread();

    // Initialize score by reading the incrementally updated scores included
    // in the position object (material + piece square tables).
    // Score is computed from the point of view of white.


    score = pos.psq_score();
    // Probe the material hash table
    ei.mi = Material::probe(pos, thisThread->materialTable, thisThread->endgames);
    score += ei.mi->material_value();

    // If we have a specialized evaluation function for the current material
    // configuration, call it and return.
    if (ei.mi->specialized_eval_exists())
        return ei.mi->evaluate(pos);

    // Probe the pawn hash table
    ei.pi = Pawns::probe(pos, thisThread->pawnsTable);
    score += apply_weight(ei.pi->pawns_value(), Weights[PawnStructure]);

    // Initialize attack and king safety bitboards
    init_eval_info<WHITE>(pos, ei);
    init_eval_info<BLACK>(pos, ei);

    ei.attackedBy[WHITE][ALL_PIECES] |= ei.attackedBy[WHITE][KING];
    ei.attackedBy[BLACK][ALL_PIECES] |= ei.attackedBy[BLACK][KING];

    // Do not include in mobility squares protected by enemy pawns or occupied by our pawns or king
    Bitboard mobilityArea[] = { ~(ei.attackedBy[BLACK][PAWN] | pos.pieces(WHITE, PAWN, KING)),
                                ~(ei.attackedBy[WHITE][PAWN] | pos.pieces(BLACK, PAWN, KING)) };

    // Evaluate pieces and mobility
    score += evaluate_pieces<KNIGHT, WHITE, Trace>(pos, ei, mobility, mobilityArea);
    score += apply_weight(mobility[WHITE] - mobility[BLACK], Weights[Mobility]);

    // Evaluate kings after all other pieces because we need complete attack
    // information when computing the king safety evaluation.
    score +=  evaluate_king<WHITE, Trace>(pos, ei)
            - evaluate_king<BLACK, Trace>(pos, ei);

    // Evaluate tactical threats, we need full attack information including king
    score +=  evaluate_threats<WHITE, Trace>(pos, ei)
            - evaluate_threats<BLACK, Trace>(pos, ei);

    // Evaluate passed pawns, we need full attack information including king
    score +=  evaluate_passed_pawns<WHITE, Trace>(pos, ei)
            - evaluate_passed_pawns<BLACK, Trace>(pos, ei);

    // If both sides have only pawns, score for potential unstoppable pawns
    if (!pos.non_pawn_material(WHITE) && !pos.non_pawn_material(BLACK))
        score +=  evaluate_unstoppable_pawns(WHITE, ei)
                - evaluate_unstoppable_pawns(BLACK, ei);

				
    // Evaluate space for both sides, only in middlegame
    if (ei.mi->space_weight())
    {
        int s = evaluate_space<WHITE>(pos, ei) - evaluate_space<BLACK>(pos, ei);
        score += apply_weight(s * ei.mi->space_weight(), Weights[Space]);
    }

    // Scale winning side if position is more drawish than it appears
    ScaleFactor sf = eg_value(score) > VALUE_DRAW ? ei.mi->scale_factor(pos, WHITE)
                                                  : ei.mi->scale_factor(pos, BLACK);


    // If we don't already have an unusual scale factor, check for opposite
    // colored bishop endgames, and use a lower scale for those.
    if (    ei.mi->game_phase() < PHASE_MIDGAME
        &&  pos.opposite_bishops()
        && (sf == SCALE_FACTOR_NORMAL || sf == SCALE_FACTOR_ONEPAWN))
    {

        // Ignoring any pawns, do both sides only have a single bishop and no
        // other pieces?
        if (   pos.non_pawn_material(WHITE) == BishopValueMg
            && pos.non_pawn_material(BLACK) == BishopValueMg)
        {

            // Check for KBP vs KB with only a single pawn that is almost
            // certainly a draw or at least two pawns.
            bool one_pawn = (pos.count<PAWN>(WHITE) + pos.count<PAWN>(BLACK) == 1);
            sf = one_pawn ? ScaleFactor(8) : ScaleFactor(32);










        }
        else
            // Endgame with opposite-colored bishops, but also other pieces. Still
            // a bit drawish, but not as drawish as with only the two bishops.
             sf = ScaleFactor(50 * sf / SCALE_FACTOR_NORMAL);




    }

    // Interpolate between a middlegame and a (scaled by 'sf') endgame score
    Value v =  mg_value(score) * int(ei.mi->game_phase())
             + eg_value(score) * int(PHASE_MIDGAME - ei.mi->game_phase()) * sf / SCALE_FACTOR_NORMAL;

    v /= int(PHASE_MIDGAME);

    // In case of tracing add all single evaluation contributions for both white and black
    if (Trace)
    {
        Tracing::add_term(Tracing::MATERIAL, pos.psq_score());
        Tracing::add_term(Tracing::IMBALANCE, ei.mi->material_value());
        Tracing::add_term(PAWN, ei.pi->pawns_value());
        Tracing::add_term(Tracing::MOBILITY, apply_weight(mobility[WHITE], Weights[Mobility])
                                           , apply_weight(mobility[BLACK], Weights[Mobility]));
        Score w = ei.mi->space_weight() * evaluate_space<WHITE>(pos, ei);
        Score b = ei.mi->space_weight() * evaluate_space<BLACK>(pos, ei);
        Tracing::add_term(Tracing::SPACE, apply_weight(w, Weights[Space]), apply_weight(b, Weights[Space]));
        Tracing::add_term(Tracing::TOTAL, score);
        Tracing::ei = ei;
        Tracing::sf = sf;
    }

    return pos.side_to_move() == WHITE ? v : -v;
  }


  // Tracing function definitions

  double Tracing::to_cp(Value v) { return double(v) / PawnValueEg; }

  void Tracing::add_term(int idx, Score wScore, Score bScore) {

    terms[WHITE][idx] = wScore;
    terms[BLACK][idx] = bScore;
  }

  void Tracing::format_row(std::stringstream& ss, const char* name, int idx) {

    Score wScore = terms[WHITE][idx];
    Score bScore = terms[BLACK][idx];

    switch (idx) {
    case MATERIAL: case IMBALANCE: case PAWN: case TOTAL:
        ss << std::setw(15) << name << " |   ---   --- |   ---   --- | "
           << std::setw(5)  << to_cp(mg_value(wScore - bScore)) << " "
           << std::setw(5)  << to_cp(eg_value(wScore - bScore)) << " \n";
        break;
    default:
        ss << std::setw(15) << name << " | " << std::noshowpos
           << std::setw(5)  << to_cp(mg_value(wScore)) << " "
           << std::setw(5)  << to_cp(eg_value(wScore)) << " | "
           << std::setw(5)  << to_cp(mg_value(bScore)) << " "
           << std::setw(5)  << to_cp(eg_value(bScore)) << " | "
           << std::setw(5)  << to_cp(mg_value(wScore - bScore)) << " "
           << std::setw(5)  << to_cp(eg_value(wScore - bScore)) << " \n";
    }
  }

  std::string Tracing::do_trace(const Position& pos) {

    std::memset(terms, 0, sizeof(terms));

    Value v = do_evaluate<true>(pos);
    v = pos.side_to_move() == WHITE ? v : -v; // White's point of view

    std::stringstream ss;
    ss << std::showpoint << std::noshowpos << std::fixed << std::setprecision(2)
       << "           Eval term |    White    |    Black    |    Total    \n"


       << "                     |   MG    EG  |   MG    EG  |   MG    EG  \n"
       << "---------------------+-------------+-------------+-------------\n";

    format_row(ss, "Material", MATERIAL);
    format_row(ss, "Imbalance", IMBALANCE);
    format_row(ss, "Pawns", PAWN);
    format_row(ss, "Knights", KNIGHT);
    format_row(ss, "Bishops", BISHOP);
    format_row(ss, "Rooks", ROOK);
    format_row(ss, "Queens", QUEEN);
    format_row(ss, "Mobility", MOBILITY);
    format_row(ss, "King safety", KING);
    format_row(ss, "Threats", THREAT);
    format_row(ss, "Passed pawns", PASSED);
    format_row(ss, "Space", SPACE);


    ss << "---------------------+-------------+-------------+-------------\n";
    format_row(ss, "Total", TOTAL);

    ss << "\nTotal Evaluation: " << to_cp(v) << " (white side)\n";

    return ss.str();
  }

} // namespace


namespace Eval {

  /// evaluate() is the main evaluation function. It returns a static evaluation
  /// of the position always from the point of view of the side to move.

  Value evaluate(const Position& pos) {
    return do_evaluate<false>(pos) + Tempo;
  }


  /// trace() is like evaluate(), but instead of returning a value, it returns
  /// a string (suitable for outputting to stdout) that contains the detailed
  /// descriptions and values of each evaluation term. It's mainly used for
  /// debugging.
  std::string trace(const Position& pos) {
    return Tracing::do_trace(pos);
  }


  /// init() computes evaluation weights from the corresponding UCI parameters
  /// and setup king tables.

  void init() {

    const double MaxSlope = 30;
    const double Peak = 1280;

    for (int t = 0, i = 1; i < 100; ++i)
    {
        t = int(std::min(Peak, std::min(0.4 * i * i, t + MaxSlope)));


        KingDanger[i] = apply_weight(make_score(t, 0), Weights[KingSafety]);
    }









  }

} // namespace Eval
