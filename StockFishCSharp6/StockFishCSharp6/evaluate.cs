using System.Diagnostics;
using System;

public static class GlobalMembersEvaluate
{

		public static Score[,] scores = new Score[(int)Color.COLOR_NB, (int)Terms.TERMS_NB];
		public static EvalInfo ei = new EvalInfo();
		public static ScaleFactor sf;

	// Tracing function definitions


		public static double to_cp(Value v)
		{
			return (double)v / Value.PawnValueEg;
		}
		public static void write(int idx, Color c, Score s)
		{
			scores[(int)c, idx] = s;
		}
	public static void write(int idx, Score w)
	{
		write(idx, w, Score.SCORE_ZERO);
	}
//C++ TO C# CONVERTER NOTE: Overloaded method(s) are created above to convert the following method having default parameters:
//ORIGINAL LINE: void write(int idx, Score w, Score b = SCORE_ZERO)
		public static void write(int idx, Score w, Score b)
		{

		  GlobalMembersEvaluate.write(idx, Color.WHITE, w);
		  GlobalMembersEvaluate.write(idx, Color.BLACK, b);
		}
		public static void print(std.stringstream ss, string name, int idx)
		{

		  Score wScore = scores[(int)Color.WHITE, idx];
		  Score bScore = scores[(int)Color.BLACK, idx];

		  switch (idx)
		  {
		  case Terms.MATERIAL:
	  case Terms.IMBALANCE:
	  case PieceType.PAWN:
	  case Terms.TOTAL:
			  ss << std.setw(15) << name << " |   ---   --- |   ---   --- | " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.mg_value(wScore - bScore)) << " " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.eg_value(wScore - bScore)) << " \n";
			  break;
		  default:
			  ss << std.setw(15) << name << " | " << std.noshowpos << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.mg_value(wScore)) << " " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.eg_value(wScore)) << " | " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.mg_value(bScore)) << " " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.eg_value(bScore)) << " | " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.mg_value(wScore - bScore)) << " " << std.setw(5) << GlobalMembersEvaluate.to_cp(GlobalMembersTypes.eg_value(wScore - bScore)) << " \n";
		  break;
		  }
		}
		public static string do_trace(Position pos)
		{

		  std.memset(scores, 0, sizeof(scores));

		  Value v = GlobalMembersEvaluate.do_evaluate<true>(pos);
		  v = pos.side_to_move() == ((int)Color.WHITE) != 0 ? v : -v; // White's point of view

		  std.stringstream ss = new std.stringstream();
		  ss << std.showpoint << std.noshowpos << std.@fixed << std.setprecision(2) << "      Eval term |    White    |    Black    |    Total    \n" << "                |   MG    EG  |   MG    EG  |   MG    EG  \n" << "----------------+-------------+-------------+-------------\n";

		  GlobalMembersEvaluate.print(ss, "Material", Terms.MATERIAL);
		  GlobalMembersEvaluate.print(ss, "Imbalance", Terms.IMBALANCE);
		  GlobalMembersEvaluate.print(ss, "Pawns", PieceType.PAWN);
		  GlobalMembersEvaluate.print(ss, "Knights", PieceType.KNIGHT);
		  GlobalMembersEvaluate.print(ss, "Bishops", PieceType.BISHOP);
		  GlobalMembersEvaluate.print(ss, "Rooks", PieceType.ROOK);
		  GlobalMembersEvaluate.print(ss, "Queens", PieceType.QUEEN);
		  GlobalMembersEvaluate.print(ss, "Mobility", Terms.MOBILITY);
		  GlobalMembersEvaluate.print(ss, "King safety", PieceType.KING);
		  GlobalMembersEvaluate.print(ss, "Threats", Terms.THREAT);
		  GlobalMembersEvaluate.print(ss, "Passed pawns", Terms.PASSED);
		  GlobalMembersEvaluate.print(ss, "Space", Terms.SPACE);

		  ss << "----------------+-------------+-------------+-------------\n";
		  GlobalMembersEvaluate.print(ss, "Total", Terms.TOTAL);

		  ss << "\nTotal Evaluation: " << GlobalMembersEvaluate.to_cp(v) << " (white side)\n";

		  return ss.str();
		}
	  public static Weight[] Weights = {new Weight(289, 344), new Weight(233, 201), new Weight(221, 273), new Weight(46, 0), new Weight(321, 0)};

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define V(v) Value(v)
	  #define V
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define S(mg, eg) make_score(mg, eg)
	  #define S

	  // MobilityBonus[PieceType][attacked] contains bonuses for middle and end
	  // game, indexed by piece type and number of attacked squares not occupied by
	  // friendly pieces.
	  public static readonly Score[,] MobilityBonus = {{, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null}, {, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null}, {make_score(-65, -50), make_score(-42, -30), make_score(-9, -10), make_score(3, 0), make_score(15, 10), make_score(27, 20), make_score(37, 28), make_score(42, 31), make_score(44, 33), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null}, {make_score(-52, -47), make_score(-28, -23), make_score(6, 1), make_score(20, 15), make_score(34, 29), make_score(48, 43), make_score(60, 55), make_score(68, 63), make_score(74, 68), make_score(77, 72), make_score(80, 75), make_score(82, 77), make_score(84, 79), make_score(86, 81), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null}, {make_score(-47, -53), make_score(-31, -26), make_score(-5, 0), make_score(1, 16), make_score(7, 32), make_score(13, 48), make_score(18, 64), make_score(22, 80), make_score(26, 96), make_score(29, 109), make_score(31, 115), make_score(33, 119), make_score(35, 122), make_score(36, 123), make_score(37, 124), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null}, {make_score(-42, -40), make_score(-28, -23), make_score(-5, -7), make_score(0, 0), make_score(6, 10), make_score(11, 19), make_score(13, 29), make_score(18, 38), make_score(20, 40), make_score(21, 41), make_score(22, 41), make_score(22, 41), make_score(22, 41), make_score(23, 41), make_score(24, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), make_score(25, 41), null, null, null, null}};

	  // Outpost[PieceType][Square] contains bonuses for knights and bishops outposts,
	  // indexed by piece type and square (from white's point of view).
	  public static readonly Value[,] Outpost = {{Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(4), Value(8), Value(8), Value(4), Value(0), Value(0), Value(0), Value(4),Value(17),Value(26),Value(26),Value(17), Value(4), Value(0), Value(0), Value(8),Value(26),Value(35),Value(35),Value(26), Value(8), Value(0), Value(0), Value(4),Value(17),Value(17),Value(17),Value(17), Value(4), Value(0)}, {Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(0), Value(5), Value(5), Value(5), Value(5), Value(0), Value(0), Value(0), Value(5),Value(10),Value(10),Value(10),Value(10), Value(5), Value(0), Value(0),Value(10),Value(21),Value(21),Value(21),Value(21),Value(10), Value(0), Value(0), Value(5), Value(8), Value(8), Value(8), Value(8), Value(5), Value(0)}};

	  // Threat[defended/weak][minor/major attacking][attacked PieceType] contains
	  // bonuses according to which piece type attacks which one.
	  public static readonly Score[,,] Threat = {{{make_score(0, 0), make_score(0, 0), make_score(19, 37), make_score(24, 37), make_score(44, 97), make_score(35, 106)}, {make_score(0, 0), make_score(0, 0), make_score(9, 14), make_score(9, 14), make_score(7, 14), make_score(24, 48)}}, {{make_score(0, 0), make_score(0, 32), make_score(33, 41), make_score(31, 50), make_score(41, 100), make_score(35, 104)}, {make_score(0, 0), make_score(0, 27), make_score(26, 57), make_score(26, 57), make_score(0, 43), make_score(23, 51)}}};

	  // ThreatenedByPawn[PieceType] contains a penalty according to which piece
	  // type is attacked by an enemy pawn.
	  public static readonly Score[] ThreatenedByPawn = {make_score(0, 0), make_score(0, 0), make_score(87, 118), make_score(84, 122), make_score(114, 203), make_score(121, 217)};

	  // Assorted bonuses and penalties used by evaluation
	  public static Score KingOnOne = make_score(2, 58);
	  public static Score KingOnMany = make_score(6, 125);
	  public static Score RookOnPawn = make_score(7, 27);
	  public static Score RookOnOpenFile = make_score(43, 21);
	  public static Score RookOnSemiOpenFile = make_score(19, 10);
	  public static Score BishopPawns = make_score(8, 12);
	  public static Score MinorBehindPawn = make_score(16, 0);
	  public static Score TrappedRook = make_score(92, 0);
	  public static Score Unstoppable = make_score(0, 20);
	  public static Score Hanging = make_score(31, 26);

	  // Penalty for a bishop on a1/h1 (a8/h8 for black) which is trapped by
	  // a friendly pawn on b2/g2 (b7/g7 for black). This can obviously only
	  // happen in Chess960 games.
	  public static Score TrappedBishopA1H1 = make_score(50, 50);

	  #undef S
	  #undef V

	  // SpaceMask[Color] contains the area of the board which is considered
	  // by the space evaluation. In the middlegame, each side is given a bonus
	  // based on how many squares inside this area are safe and available for
	  // friendly minor pieces.
	  public static readonly uint[] long SpaceMask = {(FileCBB | FileDBB | FileEBB | FileFBB) & (Rank2BB | Rank3BB | Rank4BB), (FileCBB | FileDBB | FileEBB | FileFBB) & (Rank7BB | Rank6BB | Rank5BB)};

	  // King danger constants and variables. The king danger scores are looked-up
	  // in KingDanger[]. Various little "meta-bonuses" measuring the strength
	  // of the enemy attack are added up into an integer, which is used as an
	  // index to KingDanger[].
	  //
	  // KingAttackWeights[PieceType] contains king attack weights by piece type
	  public static readonly int[] KingAttackWeights = {0, 0, 6, 2, 5, 5};

	  // Bonuses for enemy's safe checks
	  public const int QueenContactCheck = 92;
	  public const int RookContactCheck = 68;
	  public const int QueenCheck = 50;
	  public const int RookCheck = 36;
	  public const int BishopCheck = 7;
	  public const int KnightCheck = 14;

	  // KingDanger[attackUnits] contains the actual king danger weighted
	  // scores, indexed by a calculated integer number.
	  public static Score[] KingDanger = new Score[512];

	  // apply_weight() weighs score 's' by weight 'w' trying to prevent overflow
	  public static Score apply_weight(Score s, Weight w)
	  {
		return GlobalMembersTypes.make_score(GlobalMembersTypes.mg_value(s) * w.mg / 256, GlobalMembersTypes.eg_value(s) * w.eg / 256);
	  }


	  // init_eval_info() initializes king bitboards for given color adding
	  // pawn attacks. To be done at the beginning of the evaluation.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static void init_eval_info<Color Us>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		Square Down = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_S : Square.DELTA_N);

		ei.pinnedPieces[Us] = pos.pinned_pieces(Us);

		uint long b = ei.attackedBy[(int)Them][(int)PieceType.KING] = pos.attacks_from<PieceType.KING>(pos.king_square(Them));
		ei.attackedBy[Us][(int)PieceType.ALL_PIECES] = ei.attackedBy[Us][(int)PieceType.PAWN] = ei.pi.pawn_attacks(Us);

		// Init king safety tables only if we are going to use them
		if (pos.non_pawn_material(Us) >= Value.QueenValueMg)
		{
			ei.kingRing[(int)Them] = b | GlobalMembersBitboard.shift_bb<Down>(b);
			b &= ei.attackedBy[Us][(int)PieceType.PAWN];
			ei.kingAttackersCount[Us] = b ? GlobalMembersTbprobe.popcount<Max15>(b) : 0;
			ei.kingAdjacentZoneAttacksCount[Us] = ei.kingAttackersWeight[Us] = 0;
		}
		else
		{
			ei.kingRing[(int)Them] = ei.kingAttackersCount[Us] = 0;
		}
	  }


	  // evaluate_outpost() evaluates bishop and knight outpost squares

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt, Color Us>
	  public static Score evaluate_outpost<PieceType Pt, Color Us>(Position pos, EvalInfo ei, Square s)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

		Debug.Assert(Pt == PieceType.BISHOP || Pt == PieceType.KNIGHT);

		// Initial bonus based on square
		Value bonus = Outpost[Pt == PieceType.BISHOP, (int)GlobalMembersTypes.relative_square(Us, s)];

		// Increase bonus if supported by pawn, especially if the opponent has
		// no minor piece which can trade with the outpost piece.
		if (((int)bonus) != 0 && (ei.attackedBy[Us][(int)PieceType.PAWN] & (int)s))
		{
			if (pos.pieces(Them, PieceType.KNIGHT) == 0 && !(GlobalMembersBitboard.squares_of_color(s) & pos.pieces(Them, PieceType.BISHOP)))
			{
				bonus += bonus + bonus / 2;
			}
			else
			{
				bonus += bonus / 2;
			}
		}

		return GlobalMembersTypes.make_score(bonus * 2, bonus / 2);
	  }


	  // evaluate_pieces() assigns bonuses and penalties to the pieces of a given color

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt, Color Us, bool Trace>
	  public static Score evaluate_pieces<PieceType Pt, Color Us, bool Trace>(Position pos, EvalInfo ei, Score[] mobility, uint long[] mobilityArea)
	  {

		uint long b;
		Square s;
		Score score = Score.SCORE_ZERO;

		PieceType NextPt = (Us == ((int)Color.WHITE) != 0 ? Pt : PieceType(Pt + 1));
		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
		Square * pl = pos.list<Pt>(Us);

		ei.attackedBy[Us][Pt] = 0;

		while ((s = pl++) != Square.SQ_NONE)
		{
			// Find attacked squares, including x-ray attacks for bishops and rooks
			b = Pt == ((int)PieceType.BISHOP) != 0 ? GlobalMembersBitboard.attacks_bb<PieceType.BISHOP>(s, pos.pieces() ^ pos.pieces(Us, PieceType.QUEEN)) : Pt == ((int)PieceType.ROOK) != 0 ? GlobalMembersBitboard.attacks_bb< PieceType.ROOK>(s, pos.pieces() ^ pos.pieces(Us, PieceType.ROOK, PieceType.QUEEN)) : pos.attacks_from<Pt>(s);

			if (ei.pinnedPieces[Us] & (int)s)
			{
				b &= LineBB[(int)pos.king_square(Us)][(int)s];
			}

			ei.attackedBy[Us][(int)PieceType.ALL_PIECES] |= ei.attackedBy[Us][Pt] |= b;

			if (b & ei.kingRing[(int)Them])
			{
				ei.kingAttackersCount[Us]++;
				ei.kingAttackersWeight[Us] += KingAttackWeights[Pt];
				uint long bb = b & ei.attackedBy[(int)Them][(int)PieceType.KING];
				if (bb)
				{
					ei.kingAdjacentZoneAttacksCount[Us] += GlobalMembersTbprobe.popcount<Max15>(bb);
				}
			}

			if (Pt == PieceType.QUEEN)
			{
				b &= ~(ei.attackedBy[(int)Them][(int)PieceType.KNIGHT] | ei.attackedBy[(int)Them][(int)PieceType.BISHOP] | ei.attackedBy[(int)Them][(int)PieceType.ROOK]);
			}

			int mob = Pt != ((int)PieceType.QUEEN) != 0 ? GlobalMembersTbprobe.popcount<Max15>(b & mobilityArea[Us]) : GlobalMembersTbprobe.popcount<Full >(b & mobilityArea[Us]);

			mobility[Us] += MobilityBonus[Pt, mob];

			// Decrease score if we are attacked by an enemy pawn. The remaining part
			// of threat evaluation must be done later when we have full attack info.
			if (ei.attackedBy[(int)Them][(int)PieceType.PAWN] & (int)s)
			{
				score -= ThreatenedByPawn[Pt];
			}

			if (Pt == PieceType.BISHOP || Pt == PieceType.KNIGHT)
			{
				// Bonus for outpost square
				if (!(pos.pieces(Them, PieceType.PAWN) & GlobalMembersBitboard.pawn_attack_span(Us, s)))
				{
					score += GlobalMembersEvaluate.evaluate_outpost<Pt, Us>(pos, ei, s);
				}

				// Bonus when behind a pawn
				if (GlobalMembersTypes.relative_rank(Us, s) < Rank.RANK_5 && (pos.pieces(PieceType.PAWN) & (s + GlobalMembersTypes.pawn_push(Us))))
				{
					score += MinorBehindPawn;
				}

				// Penalty for pawns on same color square of bishop
				if (Pt == PieceType.BISHOP)
				{
					score -= BishopPawns * ei.pi.pawns_on_same_color_squares(Us, s);
				}

				// An important Chess960 pattern: A cornered bishop blocked by a friendly
				// pawn diagonally in front of it is a very serious problem, especially
				// when that pawn is also blocked.
				if (Pt == PieceType.BISHOP && pos.is_chess960() && (s == GlobalMembersTypes.relative_square(Us, Square.SQ_A1) || s == GlobalMembersTypes.relative_square(Us, Square.SQ_H1)))
				{
					Square d = GlobalMembersTypes.pawn_push(Us) + (GlobalMembersTypes.file_of(s) == ((int)File.FILE_A) != 0 ? Square.DELTA_E : Square.DELTA_W);
					if (pos.piece_on(s + d) == GlobalMembersTypes.make_piece(Us, PieceType.PAWN))
					{
						score -= !pos.empty(s + d + GlobalMembersTypes.pawn_push(Us)) ? TrappedBishopA1H1 * 4 : pos.piece_on(s + d + d) == ((int)GlobalMembersTypes.make_piece(Us, PieceType.PAWN)) != 0 ? TrappedBishopA1H1 * 2 : TrappedBishopA1H1;
					}
				}
			}

			if (Pt == PieceType.ROOK)
			{
				// Bonus for aligning with enemy pawns on the same rank/file
				if (GlobalMembersTypes.relative_rank(Us, s) >= Rank.RANK_5)
				{
					uint long alignedPawns = pos.pieces(Them, PieceType.PAWN) & PseudoAttacks[(int)PieceType.ROOK][(int)s];
					if (alignedPawns)
					{
						score += GlobalMembersTbprobe.popcount<Max15>(alignedPawns) * RookOnPawn;
					}
				}

				// Bonus when on an open or semi-open file
				if (ei.pi.semiopen_file(Us, GlobalMembersTypes.file_of(s)) != 0)
				{
					score += ei.pi.semiopen_file(Them, GlobalMembersTypes.file_of(s)) != 0 ? RookOnOpenFile : RookOnSemiOpenFile;
				}

				// Penalize when trapped by the king, even more if king cannot castle
				if (mob <= 3 && ei.pi.semiopen_file(Us, GlobalMembersTypes.file_of(s)) == 0)
				{
					Square ksq = pos.king_square(Us);

					if (((GlobalMembersTypes.file_of(ksq) < File.FILE_E) == (GlobalMembersTypes.file_of(s) < GlobalMembersTypes.file_of(ksq))) && (GlobalMembersTypes.rank_of(ksq) == GlobalMembersTypes.rank_of(s) || GlobalMembersTypes.relative_rank(Us, ksq) == Rank.RANK_1) && ei.pi.semiopen_side(Us, GlobalMembersTypes.file_of(ksq), GlobalMembersTypes.file_of(s) < GlobalMembersTypes.file_of(ksq)) == 0)
					{
						score -= (TrappedRook - GlobalMembersTypes.make_score(mob * 22, 0)) * (1 + pos.can_castle(Us) == 0);
					}
				}
			}
		}

		if (Trace)
		{
			GlobalMembersEvaluate.write(Pt, Us, score);
		}

		// Recursively call evaluate_pieces() of next piece type until KING excluded
		return score - GlobalMembersEvaluate.evaluate_pieces<NextPt, Them, Trace>(pos, ei, mobility, mobilityArea);
	  }

	  public static Score evaluate_pieces(Position UnnamedParameter1, EvalInfo UnnamedParameter2, Score UnnamedParameter3, uint long UnnamedParameter4)
	  {
		  return Score.SCORE_ZERO;
	  }
	  public static Score evaluate_pieces(Position UnnamedParameter1, EvalInfo UnnamedParameter2, Score UnnamedParameter3, uint long UnnamedParameter4)
	  {
		  return Score.SCORE_ZERO;
	  }


	  // evaluate_king() assigns bonuses and penalties to a king of a given color

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, bool Trace>
	  public static Score evaluate_king<Color Us, bool Trace>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

		uint long undefended, b, b1, b2, safe;
		int attackUnits;
		Square ksq = pos.king_square(Us);

		// King shelter and enemy pawns storm
		Score score = ei.pi.king_safety<Us>(pos, ksq);

		// Main king safety evaluation
		if (ei.kingAttackersCount[(int)Them] != 0)
		{
			// Find the attacked squares around the king which have no defenders
			// apart from the king itself
			undefended = ei.attackedBy[(int)Them][(int)PieceType.ALL_PIECES] & ei.attackedBy[Us][(int)PieceType.KING] & ~(ei.attackedBy[Us][(int)PieceType.PAWN] | ei.attackedBy[Us][(int)PieceType.KNIGHT] | ei.attackedBy[Us][(int)PieceType.BISHOP] | ei.attackedBy[Us][(int)PieceType.ROOK] | ei.attackedBy[Us][(int)PieceType.QUEEN]);

			// Initialize the 'attackUnits' variable, which is used later on as an
			// index into the KingDanger[] array. The initial value is based on the
			// number and types of the enemy's attacking pieces, the number of
			// attacked and undefended squares around our king and the quality of
			// the pawn shelter (current 'score' value).
			attackUnits = Math.Min(77, ei.kingAttackersCount[(int)Them] * ei.kingAttackersWeight[(int)Them]) + 10 * ei.kingAdjacentZoneAttacksCount[(int)Them] + 19 * GlobalMembersTbprobe.popcount<Max15>(undefended) + 9 * (ei.pinnedPieces[Us] != 0) - GlobalMembersTypes.mg_value(score) * 63 / 512 - !pos.count<PieceType.QUEEN>(Them) * 60;

			// Analyse the enemy's safe queen contact checks. Firstly, find the
			// undefended squares around the king reachable by the enemy queen...
			b = undefended & ei.attackedBy[(int)Them][(int)PieceType.QUEEN] & ~pos.pieces(Them);
			if (b)
			{
				// ...and then remove squares not supported by another enemy piece
				b &= ei.attackedBy[(int)Them][(int)PieceType.PAWN] | ei.attackedBy[(int)Them][(int)PieceType.KNIGHT] | ei.attackedBy[(int)Them][(int)PieceType.BISHOP] | ei.attackedBy[(int)Them][(int)PieceType.ROOK];

				if (b)
				{
					attackUnits += QueenContactCheck * GlobalMembersTbprobe.popcount<Max15>(b);
				}
			}

			// Analyse the enemy's safe rook contact checks. Firstly, find the
			// undefended squares around the king reachable by the enemy rooks...
			b = undefended & ei.attackedBy[(int)Them][(int)PieceType.ROOK] & ~pos.pieces(Them);

			// Consider only squares where the enemy's rook gives check
			b &= PseudoAttacks[(int)PieceType.ROOK][(int)ksq];

			if (b)
			{
				// ...and then remove squares not supported by another enemy piece
				b &= (ei.attackedBy[(int)Them][(int)PieceType.PAWN] | ei.attackedBy[(int)Them][(int)PieceType.KNIGHT] | ei.attackedBy[(int)Them][(int)PieceType.BISHOP] | ei.attackedBy[(int)Them][(int)PieceType.QUEEN]);

				if (b)
				{
					attackUnits += RookContactCheck * GlobalMembersTbprobe.popcount<Max15>(b);
				}
			}

			// Analyse the enemy's safe distance checks for sliders and knights
			safe = ~(ei.attackedBy[Us][(int)PieceType.ALL_PIECES] | pos.pieces(Them));

			b1 = pos.attacks_from<PieceType.ROOK >(ksq) & safe;
			b2 = pos.attacks_from<PieceType.BISHOP>(ksq) & safe;

			// Enemy queen safe checks
			b = (b1 | b2) & ei.attackedBy[(int)Them][(int)PieceType.QUEEN];
			if (b)
			{
				attackUnits += QueenCheck * GlobalMembersTbprobe.popcount<Max15>(b);
			}

			// Enemy rooks safe checks
			b = b1 & ei.attackedBy[(int)Them][(int)PieceType.ROOK];
			if (b)
			{
				attackUnits += RookCheck * GlobalMembersTbprobe.popcount<Max15>(b);
			}

			// Enemy bishops safe checks
			b = b2 & ei.attackedBy[(int)Them][(int)PieceType.BISHOP];
			if (b)
			{
				attackUnits += BishopCheck * GlobalMembersTbprobe.popcount<Max15>(b);
			}

			// Enemy knights safe checks
			b = pos.attacks_from<PieceType.KNIGHT>(ksq) & ei.attackedBy[(int)Them][(int)PieceType.KNIGHT] & safe;
			if (b)
			{
				attackUnits += KnightCheck * GlobalMembersTbprobe.popcount<Max15>(b);
			}

			// Finally, extract the king danger score from the KingDanger[]
			// array and subtract the score from evaluation.
			score -= KingDanger[Math.Max(Math.Min(attackUnits, 399), 0)];
		}

		if (Trace)
		{
			GlobalMembersEvaluate.write(PieceType.KING, Us, score);
		}

		return score;
	  }


	  // evaluate_threats() assigns bonuses according to the type of attacking piece
	  // and the type of attacked one.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, bool Trace>
	  public static Score evaluate_threats<Color Us, bool Trace>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);


		uint long b, weak, defended;
		Score score = Score.SCORE_ZERO;

		// Non-pawn enemies defended by a pawn
		defended = (pos.pieces(Them) ^ pos.pieces(Them, PieceType.PAWN)) & ei.attackedBy[(int)Them][(int)PieceType.PAWN];

		// Add a bonus according to the kind of attacking pieces
		if (defended)
		{
			b = defended & (ei.attackedBy[Us][(int)PieceType.KNIGHT] | ei.attackedBy[Us][(int)PieceType.BISHOP]);
			while (b)
			{
				score += Threat[Defended, Minor, (int)GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersBitboard.pop_lsb(ref b)))];
			}

			b = defended & (ei.attackedBy[Us][(int)PieceType.ROOK]);
			while (b)
			{
				score += Threat[Defended, Major, (int)GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersBitboard.pop_lsb(ref b)))];
			}
		}

		// Enemies not defended by a pawn and under our attack
		weak = pos.pieces(Them) & ~ei.attackedBy[(int)Them][(int)PieceType.PAWN] & ei.attackedBy[Us][(int)PieceType.ALL_PIECES];

		// Add a bonus according to the kind of attacking pieces
		if (weak)
		{
			b = weak & (ei.attackedBy[Us][(int)PieceType.KNIGHT] | ei.attackedBy[Us][(int)PieceType.BISHOP]);
			while (b)
			{
				score += Threat[Weak, Minor, (int)GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersBitboard.pop_lsb(ref b)))];
			}

			b = weak & (ei.attackedBy[Us][(int)PieceType.ROOK] | ei.attackedBy[Us][(int)PieceType.QUEEN]);
			while (b)
			{
				score += Threat[Weak, Major, (int)GlobalMembersTypes.type_of(pos.piece_on(GlobalMembersBitboard.pop_lsb(ref b)))];
			}

			b = weak & ~ei.attackedBy[(int)Them][(int)PieceType.ALL_PIECES];
			if (b)
			{
				score += Hanging * GlobalMembersTbprobe.popcount<Max15>(b);
			}

			b = weak & ei.attackedBy[Us][(int)PieceType.KING];
			if (b)
			{
				score += GlobalMembersBitboard.more_than_one(b) ? KingOnMany : KingOnOne;
			}
		}

		if (Trace)
		{
			GlobalMembersEvaluate.write(Tracing.Terms.THREAT, Us, score);
		}

		return score;
	  }
	  public static Score evaluate_passed_pawns<Color Us, bool Trace>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

		uint long b, squaresToQueen, defendedSquares, unsafeSquares;
		Score score = Score.SCORE_ZERO;

		b = ei.pi.passed_pawns(Us);

		while (b)
		{
			Square s = GlobalMembersBitboard.pop_lsb(ref b);

			Debug.Assert(pos.pawn_passed(Us, s));

			int r = (int)GlobalMembersTypes.relative_rank(Us, s) - Rank.RANK_2;
			int rr = r * (r - 1);

			// Base bonus based on rank
			Value mbonus = new Value(17 * rr);
			Value ebonus = new Value(7 * (rr + r + 1));

			if (rr != 0)
			{
				Square blockSq = s + GlobalMembersTypes.pawn_push(Us);

				// Adjust bonus based on the king's proximity
				ebonus += GlobalMembersBitboard.distance(pos.king_square(Them), blockSq) * 5 * rr - GlobalMembersBitboard.distance(pos.king_square(Us), blockSq) * 2 * rr;

				// If blockSq is not the queening square then consider also a second push
				if (GlobalMembersTypes.relative_rank(Us, blockSq) != Rank.RANK_8)
				{
					ebonus -= GlobalMembersBitboard.distance(pos.king_square(Us), blockSq + GlobalMembersTypes.pawn_push(Us)) * rr;
				}

				// If the pawn is free to advance, then increase the bonus
				if (pos.empty(blockSq))
				{
					// If there is a rook or queen attacking/defending the pawn from behind,
					// consider all the squaresToQueen. Otherwise consider only the squares
					// in the pawn's path attacked or occupied by the enemy.
					defendedSquares = unsafeSquares = squaresToQueen = GlobalMembersBitboard.forward_bb(Us, s);

					uint long bb = GlobalMembersBitboard.forward_bb(Them, s) & pos.pieces(PieceType.ROOK, PieceType.QUEEN) & pos.attacks_from<PieceType.ROOK>(s);

					if (!(pos.pieces(Us) & bb))
					{
						defendedSquares &= ei.attackedBy[Us][(int)PieceType.ALL_PIECES];
					}

					if (!(pos.pieces(Them) & bb))
					{
						unsafeSquares &= ei.attackedBy[(int)Them][(int)PieceType.ALL_PIECES] | pos.pieces(Them);
					}

					// If there aren't any enemy attacks, assign a big bonus. Otherwise
					// assign a smaller bonus if the block square isn't attacked.
					int k = !unsafeSquares ? 15 :!(unsafeSquares & (int)blockSq) ? 9 : 0;

					// If the path to queen is fully defended, assign a big bonus.
					// Otherwise assign a smaller bonus if the block square is defended.
					if (defendedSquares == squaresToQueen)
					{
						k += 6;
					}

					else if (defendedSquares & (int)blockSq)
					{
						k += 4;
					}

					mbonus += k * rr, ebonus += k * rr;
				}
				else if ((pos.pieces(Us) & (int)blockSq) != 0)
				{
					mbonus += rr * 3 + r * 2 + 3, ebonus += rr + r * 2;
				}
			} // rr != 0

			if (pos.count<PieceType.PAWN>(Us) < pos.count<PieceType.PAWN>(Them))
			{
				ebonus += ebonus / 4;
			}

			score += GlobalMembersTypes.make_score(mbonus, ebonus);
		}

		if (Trace)
		{
			GlobalMembersEvaluate.write(Tracing.Terms.PASSED, Us, GlobalMembersEvaluate.apply_weight(score, Weights[(int)AnonymousEnum.PassedPawns]));
		}

		// Add the scores to the middlegame and endgame eval
		return GlobalMembersEvaluate.apply_weight(score, Weights[(int)AnonymousEnum.PassedPawns]);
	  }


	  // evaluate_space() computes the space evaluation for a given side. The
	  // space evaluation is a simple bonus based on the number of safe squares
	  // available for minor pieces on the central four files on ranks 2--4. Safe
	  // squares one, two or three squares behind a friendly pawn are counted
	  // twice. Finally, the space bonus is multiplied by a weight. The aim is to
	  // improve play on game opening.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static Score evaluate_space<Color Us>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

		// Find the safe squares for our pieces inside the area defined by
		// SpaceMask[]. A square is unsafe if it is attacked by an enemy
		// pawn, or if it is undefended and attacked by an enemy piece.
		uint long safe = SpaceMask[Us] & ~pos.pieces(Us, PieceType.PAWN) & ~ei.attackedBy[(int)Them][(int)PieceType.PAWN] & (ei.attackedBy[Us][(int)PieceType.ALL_PIECES] | ~ei.attackedBy[(int)Them][(int)PieceType.ALL_PIECES]);

		// Find all squares which are at most three squares behind some friendly pawn
		uint long behind = pos.pieces(Us, PieceType.PAWN);
		behind |= (Us == ((int)Color.WHITE) != 0 ? behind >> 8 : behind << 8);
		behind |= (Us == ((int)Color.WHITE) != 0 ? behind >> 16 : behind << 16);

		// Since SpaceMask[Us] is fully on our half of the board
		Debug.Assert((uint)(safe >> (Us == ((int)Color.WHITE) != 0 ? 32 : 0)) == 0);

		// Count safe + (behind & safe) with a single popcount
		int bonus = GlobalMembersTbprobe.popcount<Full>((Us == ((int)Color.WHITE) != 0 ? safe << 32 : safe >> 32) | (behind & safe));
		int weight = pos.count<PieceType.KNIGHT>(Us) + pos.count<PieceType.BISHOP>(Us) + pos.count<PieceType.KNIGHT>(Them) + pos.count<PieceType.BISHOP>(Them);

		return GlobalMembersTypes.make_score(bonus * weight * weight, 0);
	  }


	  // do_evaluate() is the evaluation entry point, called directly from evaluate()

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool Trace>
	  public static Value do_evaluate<bool Trace>(Position pos)
	  {

		Debug.Assert(pos.checkers() == 0);

		EvalInfo ei = new EvalInfo();
		Score score;
		Score[] mobility = {Score.SCORE_ZERO, Score.SCORE_ZERO};

		// Initialize score by reading the incrementally updated scores included
		// in the position object (material + piece square tables).
		// Score is computed from the point of view of white.
		score = pos.psq_score();

		// Probe the material hash table
		ei.mi = GlobalMembersMaterial.probe(pos);
		score += ei.mi.imbalance();

		// If we have a specialized evaluation function for the current material
		// configuration, call it and return.
		if (ei.mi.specialized_eval_exists())
		{
			return ei.mi.evaluate(pos);
		}

		// Probe the pawn hash table
		ei.pi = GlobalMembersMaterial.probe(pos);
		score += GlobalMembersEvaluate.apply_weight(ei.pi.pawns_score(), Weights[(int)AnonymousEnum.PawnStructure]);

		// Initialize attack and king safety bitboards
		GlobalMembersEvaluate.init_eval_info<Color.WHITE>(pos, ei);
		GlobalMembersEvaluate.init_eval_info<Color.BLACK>(pos, ei);

		ei.attackedBy[(int)Color.WHITE][(int)PieceType.ALL_PIECES] |= ei.attackedBy[(int)Color.WHITE][(int)PieceType.KING];
		ei.attackedBy[(int)Color.BLACK][(int)PieceType.ALL_PIECES] |= ei.attackedBy[(int)Color.BLACK][(int)PieceType.KING];

		// Do not include in mobility squares protected by enemy pawns or occupied by our pawns or king
		uint long mobilityArea[] = {~(ei.attackedBy[(int)Color.BLACK][(int)PieceType.PAWN] | pos.pieces(Color.WHITE, PieceType.PAWN, PieceType.KING)), ~(ei.attackedBy[(int)Color.WHITE][(int)PieceType.PAWN] | pos.pieces(Color.BLACK, PieceType.PAWN, PieceType.KING))};

		// Evaluate pieces and mobility
		score += GlobalMembersEvaluate.evaluate_pieces<PieceType.KNIGHT, Color.WHITE, Trace>(pos, ei, mobility, mobilityArea);
		score += GlobalMembersEvaluate.apply_weight(mobility[(int)Color.WHITE] - mobility[(int)Color.BLACK], Weights[(int)AnonymousEnum.Mobility]);

		// Evaluate kings after all other pieces because we need complete attack
		// information when computing the king safety evaluation.
		score += GlobalMembersEvaluate.evaluate_king<Color.WHITE, Trace>(pos, ei) - GlobalMembersEvaluate.evaluate_king<Color.BLACK, Trace>(pos, ei);

		// Evaluate tactical threats, we need full attack information including king
		score += GlobalMembersEvaluate.evaluate_threats<Color.WHITE, Trace>(pos, ei) - GlobalMembersEvaluate.evaluate_threats<Color.BLACK, Trace>(pos, ei);

		// Evaluate passed pawns, we need full attack information including king
		score += GlobalMembersEvaluate.evaluate_passed_pawns<Color.WHITE, Trace>(pos, ei) - GlobalMembersEvaluate.evaluate_passed_pawns<Color.BLACK, Trace>(pos, ei);

		// If both sides have only pawns, score for potential unstoppable pawns
		if (((int)pos.non_pawn_material(Color.WHITE)) == 0 && ((int)pos.non_pawn_material(Color.BLACK)) == 0)
		{
			uint long b;
			if ((b = ei.pi.passed_pawns(Color.WHITE)) != 0)
			{
				score += (int)GlobalMembersTypes.relative_rank(Color.WHITE, GlobalMembersBitboard.frontmost_sq(Color.WHITE, b)) * Unstoppable;
			}

			if ((b = ei.pi.passed_pawns(Color.BLACK)) != 0)
			{
				score -= (int)GlobalMembersTypes.relative_rank(Color.BLACK, GlobalMembersBitboard.frontmost_sq(Color.BLACK, b)) * Unstoppable;
			}
		}

		// Evaluate space for both sides, only during opening
		if (pos.non_pawn_material(Color.WHITE) + pos.non_pawn_material(Color.BLACK) >= 2 * Value.QueenValueMg + 4 * Value.RookValueMg + 2 * Value.KnightValueMg)
		{
			Score s = GlobalMembersEvaluate.evaluate_space<Color.WHITE>(pos, ei) - GlobalMembersEvaluate.evaluate_space<Color.BLACK>(pos, ei);
			score += GlobalMembersEvaluate.apply_weight(s, Weights[(int)AnonymousEnum.Space]);
		}

		// Scale winning side if position is more drawish than it appears
		Color strongSide = GlobalMembersTypes.eg_value(score) > ((int)Value.VALUE_DRAW) != 0 ? Color.WHITE : Color.BLACK;
		ScaleFactor sf = ei.mi.scale_factor(pos, strongSide);

		// If we don't already have an unusual scale factor, check for certain
		// types of endgames, and use a lower scale for those.
		if (ei.mi.game_phase() < Phase.PHASE_MIDGAME && (sf == ScaleFactor.SCALE_FACTOR_NORMAL || sf == ScaleFactor.SCALE_FACTOR_ONEPAWN))
		{
			if (pos.opposite_bishops())
			{
				// Endgame with opposite-colored bishops and no other pieces (ignoring pawns)
				// is almost a draw, in case of KBP vs KB is even more a draw.
				if (pos.non_pawn_material(Color.WHITE) == Value.BishopValueMg && pos.non_pawn_material(Color.BLACK) == Value.BishopValueMg)
				{
					sf = GlobalMembersBitboard.more_than_one(pos.pieces(PieceType.PAWN)) ? ScaleFactor(32) : ScaleFactor(8);
				}

				// Endgame with opposite-colored bishops, but also other pieces. Still
				// a bit drawish, but not as drawish as with only the two bishops.
				else
				{
					 sf = ScaleFactor(50 * sf / ScaleFactor.SCALE_FACTOR_NORMAL);
				}
			}
			// Endings where weaker side can place his king in front of the opponent's
			// pawns are drawish.
			else if (Math.Abs(GlobalMembersTypes.eg_value(score)) <= Value.BishopValueEg && ei.pi.pawn_span(strongSide) <= 1 && !pos.pawn_passed(~strongSide, pos.king_square(~strongSide)))
			{
					 sf = ei.pi.pawn_span(strongSide) != 0 ? ScaleFactor(56) : ScaleFactor(38);
			}
		}

		// Interpolate between a middlegame and a (scaled by 'sf') endgame score
		Value v = GlobalMembersTypes.mg_value(score) * (int)ei.mi.game_phase() + GlobalMembersTypes.eg_value(score) * (int)(Phase.PHASE_MIDGAME - ei.mi.game_phase()) * sf / ScaleFactor.SCALE_FACTOR_NORMAL;

		v /= (int)Phase.PHASE_MIDGAME;

		// In case of tracing add all single evaluation contributions for both white and black
		if (Trace)
		{
			GlobalMembersEvaluate.write(Tracing.Terms.MATERIAL, pos.psq_score());
			GlobalMembersEvaluate.write(Tracing.Terms.IMBALANCE, ei.mi.imbalance());
			GlobalMembersEvaluate.write(PieceType.PAWN, ei.pi.pawns_score());
			GlobalMembersEvaluate.write(Tracing.Terms.MOBILITY, GlobalMembersEvaluate.apply_weight(mobility[(int)Color.WHITE], Weights[(int)AnonymousEnum.Mobility]), GlobalMembersEvaluate.apply_weight(mobility[(int)Color.BLACK], Weights[(int)AnonymousEnum.Mobility]));
			GlobalMembersEvaluate.write(Tracing.Terms.SPACE, GlobalMembersEvaluate.apply_weight(GlobalMembersEvaluate.evaluate_space<Color.WHITE>(pos, ei), Weights[(int)AnonymousEnum.Space]), GlobalMembersEvaluate.apply_weight(GlobalMembersEvaluate.evaluate_space<Color.BLACK>(pos, ei), Weights[(int)AnonymousEnum.Space]));
			GlobalMembersEvaluate.write(Tracing.Terms.TOTAL, score);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: Tracing::ei = ei;
			ei.CopyFrom(ei);
			sf = sf;
		}

		return (pos.side_to_move() == ((int)Color.WHITE) != 0 ? v : -v) + Tempo;
	  }

	  /// evaluate() is the main evaluation function. It returns a static evaluation
	  /// of the position always from the point of view of the side to move.

	  public static Value evaluate(Position pos)
	  {
		return GlobalMembersEvaluate.do_evaluate<false>(pos);
	  }


	  /// trace() is like evaluate(), but instead of returning a value, it returns
	  /// a string (suitable for outputting to stdout) that contains the detailed
	  /// descriptions and values of each evaluation term. It's mainly used for
	  /// debugging.
	  public static string trace(Position pos)
	  {
		return GlobalMembersEvaluate.do_trace(pos);
	  }


	  /// init() computes evaluation weights, usually at startup

	  public static void init()
	  {

		const double MaxSlope = 7.5;
		const double Peak = 1280;
		double t = 0.0;

		for (int i = 1; i < 400; ++i)
		{
			t = Math.Min(Peak, Math.Min(0.025 * i * i, t + MaxSlope));
			KingDanger[i] = GlobalMembersEvaluate.apply_weight(GlobalMembersTypes.make_score((int)t, 0), Weights[(int)AnonymousEnum.KingSafety]);
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



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

  // Struct EvalInfo contains various information computed and collected
  // by the evaluation functions.
  public class EvalInfo
  {

	// Pointers to material and pawn hash table entries
	public Material.Entry mi;
	public Pawns.Entry pi;

	// attackedBy[color][piece type] is a bitboard representing all squares
	// attacked by a given color and piece type, attackedBy[color][ALL_PIECES]
	// contains all squares attacked by the given color.
	public uint[,] long attackedBy = new uint[(int)Color.COLOR_NB, (int)PieceType.PIECE_TYPE_NB];

	// kingRing[color] is the zone around the king which is considered
	// by the king safety evaluation. This consists of the squares directly
	// adjacent to the king, and the three (or two, for a king on an edge file)
	// squares two ranks in front of the king. For instance, if black's king
	// is on g8, kingRing[BLACK] is a bitboard containing the squares f8, h8,
	// f7, g7, h7, f6, g6 and h6.
	public uint[] long kingRing = new uint[(int)Color.COLOR_NB];

	// kingAttackersCount[color] is the number of pieces of the given color
	// which attack a square in the kingRing of the enemy king.
	public int[] kingAttackersCount = new int[(int)Color.COLOR_NB];

	// kingAttackersWeight[color] is the sum of the "weight" of the pieces of the
	// given color which attack a square in the kingRing of the enemy king. The
	// weights of the individual piece types are given by the elements in the
	// KingAttackWeights array.
	public int[] kingAttackersWeight = new int[(int)Color.COLOR_NB];

	// kingAdjacentZoneAttacksCount[color] is the number of attacks to squares
	// directly adjacent to the king of the given color. Pieces which attack
	// more than one square are counted multiple times. For instance, if black's
	// king is on g8 and there's a white knight on g5, this knight adds
	// 2 to kingAdjacentZoneAttacksCount[BLACK].
	public int[] kingAdjacentZoneAttacksCount = new int[(int)Color.COLOR_NB];

	public uint[] long pinnedPieces = new uint[(int)Color.COLOR_NB];
  }

  namespace Tracing
  {

	public enum Terms // First 8 entries are for PieceType
	{
	  MATERIAL = 8,
	  IMBALANCE,
	  MOBILITY,
	  THREAT,
	  PASSED,
	  SPACE,
	  TOTAL,
	  TERMS_NB
	}
  }

  // Evaluation weights, indexed by evaluation term
//C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named AnonymousEnum13:
  public enum AnonymousEnum13
  {
	  Mobility,
	  PawnStructure,
	  PassedPawns,
	  Space,
	  KingSafety
  }
  public const class Weight
  {
	  public int mg;
	  public int eg;
  }
//C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named AnonymousEnum14:
  public enum AnonymousEnum14
  {
	  Defended,
	  Weak
  }
//C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named AnonymousEnum15:
  public enum AnonymousEnum15
  {
	  Minor,
	  Major
  }


  // evaluate_passed_pawns() evaluates the passed pawns of the given color

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, bool Trace>



