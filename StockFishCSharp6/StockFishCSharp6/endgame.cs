using System.Diagnostics;
using System;

public static class GlobalMembersEndgame
{

	  // Table used to drive the king towards the edge of the board
	  // in KX vs K and KQ vs KR endgames.
	  public static readonly int[] PushToEdges = {100, 90, 80, 70, 70, 80, 90, 100, 90, 70, 60, 50, 50, 60, 70, 90, 80, 60, 40, 30, 30, 40, 60, 80, 70, 50, 30, 20, 20, 30, 50, 70, 70, 50, 30, 20, 20, 30, 50, 70, 80, 60, 40, 30, 30, 40, 60, 80, 90, 70, 60, 50, 50, 60, 70, 90, 100, 90, 80, 70, 70, 80, 90, 100};

	  // Table used to drive the king towards a corner square of the
	  // right color in KBN vs K endgames.
	  public static readonly int[] PushToCorners = {200, 190, 180, 170, 160, 150, 140, 130, 190, 180, 170, 160, 150, 140, 130, 140, 180, 170, 155, 140, 140, 125, 140, 150, 170, 160, 140, 120, 110, 140, 150, 160, 160, 150, 140, 110, 120, 140, 160, 170, 150, 140, 125, 140, 140, 155, 170, 180, 140, 130, 140, 150, 160, 170, 180, 190, 130, 140, 150, 160, 170, 180, 190, 200};

	  // Tables used to drive a piece towards or away from another piece
	  public static readonly int[] PushClose = {0, 0, 100, 80, 60, 40, 20, 10};
	  public static readonly int[] PushAway = {0, 5, 20, 40, 60, 80, 90, 100};

	#if ! NDEBUG
	  public static bool verify_material(Position pos, Color c, Value npm, int pawnsCnt)
	  {
		return pos.non_pawn_material(c) == npm && pos.count<PieceType.PAWN>(c) == pawnsCnt;
	  }
	#endif

	  // Map the square as if strongSide is white and strongSide's only pawn
	  // is on the left half of the board.
	  public static Square normalize(Position pos, Color strongSide, Square sq)
	  {

		Debug.Assert(pos.count<PieceType.PAWN>(strongSide) == 1);

		if (GlobalMembersTypes.file_of(pos.list<PieceType.PAWN>(strongSide)[0]) >= File.FILE_E)
		{
			sq = Square(sq ^ 7); // Mirror SQ_H1 -> SQ_A1
		}

		if (strongSide == Color.BLACK)
		{
			sq = ~sq;
		}

		return sq;
	  }

	  // Get the material key of Position out of the given endgame key code
	  // like "KBPKN". The trick here is to first forge an ad-hoc FEN string
	  // and then let a Position object do the work for us.
	  public static uint long key(string code, Color c)
	  {

		Debug.Assert(code.Length > 0 && code.Length < 8);
		Debug.Assert(code[0] == 'K');

		string[] sides = {code.Substring(code.IndexOf('K', 1)), code.Substring(0, code.IndexOf('K', 1))}; // Weak

		sides[(int)c] = sides[(int)c].ToLower();

		string fen = sides[0] + (char)(sbyte)(8 - sides[0].Length + '0') + "/8/8/8/8/8/8/" + sides[1] + (char)(sbyte)(8 - sides[1].Length + '0') + " w - - 0 10";

		return new Position(fen, false, null).material_key();
	  }

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename M>
	  public static void delete_endgame<M>(typename M.value_type p)
	  {
		  p.second = null;
	  }


	/// Mate with KX vs K. This function is used to evaluate positions with
	/// king and plenty of material vs a lone king. It simply gives the
	/// attacking side a bonus for driving the defending king towards the edge
	/// of the board, and for keeping the distance between the two kings small.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KXK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KXK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));
	  Debug.Assert(pos.checkers() == 0); // Eval is never called when in check

	  // Stalemate detection with lone king
	  if (pos.side_to_move() == weakSide && !new MoveList<GenType.LEGAL>(pos).size())
	  {
		  return Value.VALUE_DRAW;
	  }

	  Square winnerKSq = pos.king_square(strongSide);
	  Square loserKSq = pos.king_square(weakSide);

	  Value result = pos.non_pawn_material(strongSide) + pos.count<PieceType.PAWN>(strongSide) * Value.PawnValueEg + PushToEdges[(int)loserKSq] + PushClose[GlobalMembersBitboard.distance(winnerKSq, loserKSq)];

	  if (pos.count<PieceType.QUEEN>(strongSide) != 0 || pos.count<PieceType.ROOK>(strongSide) != 0 || (pos.count<PieceType.BISHOP>(strongSide) != 0 && pos.count<PieceType.KNIGHT>(strongSide) != 0) || (pos.count<PieceType.BISHOP>(strongSide) > 1 && GlobalMembersTypes.opposite_colors(pos.list<PieceType.BISHOP>(strongSide)[0], pos.list<PieceType.BISHOP>(strongSide)[1])))
	  {
		  result += Value.VALUE_KNOWN_WIN;
	  }

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// Mate with KBN vs K. This is similar to KX vs K, but we have to drive the
	/// defending king towards a corner square of the right color.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KBNK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KBNK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.KnightValueMg + Value.BishopValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  Square winnerKSq = pos.king_square(strongSide);
	  Square loserKSq = pos.king_square(weakSide);
	  Square bishopSq = pos.list<PieceType.BISHOP>(strongSide)[0];

	  // kbnk_mate_table() tries to drive toward corners A1 or H8. If we have a
	  // bishop that cannot reach the above squares, we flip the kings in order
	  // to drive the enemy toward corners A8 or H1.
	  if (GlobalMembersTypes.opposite_colors(bishopSq, Square.SQ_A1))
	  {
		  winnerKSq = ~winnerKSq;
		  loserKSq = ~loserKSq;
	  }

	  Value result = Value.VALUE_KNOWN_WIN + PushClose[GlobalMembersBitboard.distance(winnerKSq, loserKSq)] + PushToCorners[(int)loserKSq];

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KP vs K. This endgame is evaluated with the help of a bitbase.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KPK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KPK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.VALUE_ZERO, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square wksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(strongSide));
	  Square bksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(weakSide));
	  Square psq = GlobalMembersEndgame.normalize(pos, strongSide, pos.list<PieceType.PAWN>(strongSide)[0]);

	  Color us = strongSide == ((int)pos.side_to_move()) != 0 ? Color.WHITE : Color.BLACK;

	  if (!Bitbases.probe(wksq, psq, bksq, us))
	  {
		  return Value.VALUE_DRAW;
	  }

	  Value result = Value.VALUE_KNOWN_WIN + Value.PawnValueEg + Value(GlobalMembersTypes.rank_of(psq));

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KR vs KP. This is a somewhat tricky endgame to evaluate precisely without
	/// a bitbase. The function below returns drawish scores when the pawn is
	/// far advanced with support of the king, while the attacking king is far
	/// away.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KRKP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KRKP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 1));

	  Square wksq = GlobalMembersTypes.relative_square(strongSide, pos.king_square(strongSide));
	  Square bksq = GlobalMembersTypes.relative_square(strongSide, pos.king_square(weakSide));
	  Square rsq = GlobalMembersTypes.relative_square(strongSide, pos.list<PieceType.ROOK>(strongSide)[0]);
	  Square psq = GlobalMembersTypes.relative_square(strongSide, pos.list<PieceType.PAWN>(weakSide)[0]);

	  Square queeningSq = GlobalMembersTypes.make_square(GlobalMembersTypes.file_of(psq), Rank.RANK_1);
	  Value result;

	  // If the stronger side's king is in front of the pawn, it's a win
	  if (wksq < psq && GlobalMembersTypes.file_of(wksq) == GlobalMembersTypes.file_of(psq))
	  {
		  result = Value.RookValueEg - GlobalMembersBitboard.distance(wksq, psq);
	  }

	  // If the weaker side's king is too far from the pawn and the rook,
	  // it's a win.
	  else if (GlobalMembersBitboard.distance(bksq, psq) >= 3 + (pos.side_to_move() == weakSide) && GlobalMembersBitboard.distance(bksq, rsq) >= 3)
	  {
		  result = Value.RookValueEg - GlobalMembersBitboard.distance(wksq, psq);
	  }

	  // If the pawn is far advanced and supported by the defending king,
	  // the position is drawish
	  else if (GlobalMembersTypes.rank_of(bksq) <= Rank.RANK_3 && GlobalMembersBitboard.distance(bksq, psq) == 1 && GlobalMembersTypes.rank_of(wksq) >= Rank.RANK_4 && GlobalMembersBitboard.distance(wksq, psq) > 2 + (pos.side_to_move() == strongSide))
	  {
		  result = Value(80) - 8 * GlobalMembersBitboard.distance(wksq, psq);
	  }

	  else
	  {
		  result = Value(200) - 8 * (GlobalMembersBitboard.distance(wksq, psq + Square.DELTA_S) - GlobalMembersBitboard.distance(bksq, psq + Square.DELTA_S) - GlobalMembersBitboard.distance(psq, queeningSq));
	  }

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KR vs KB. This is very simple, and always returns drawish scores.  The
	/// score is slightly bigger when the defending king is close to the edge.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KRKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KRKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  Value result = new Value(PushToEdges[(int)pos.king_square(weakSide)]);
	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KR vs KN. The attacking side has slightly better winning chances than
	/// in KR vs KB, particularly if the king and the knight are far apart.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KRKN>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KRKN>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.KnightValueMg, 0));

	  Square bksq = pos.king_square(weakSide);
	  Square bnsq = pos.list<PieceType.KNIGHT>(weakSide)[0];
	  Value result = new Value(PushToEdges[(int)bksq] + PushAway[GlobalMembersBitboard.distance(bksq, bnsq)]);
	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KQ vs KP. In general, this is a win for the stronger side, but there are a
	/// few important exceptions. A pawn on 7th rank and on the A,C,F or H files
	/// with a king positioned next to it can be a draw, so in that case, we only
	/// use the distance between the kings.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KQKP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KQKP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.QueenValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 1));

	  Square winnerKSq = pos.king_square(strongSide);
	  Square loserKSq = pos.king_square(weakSide);
	  Square pawnSq = pos.list<PieceType.PAWN>(weakSide)[0];

	  Value result = new Value(PushClose[GlobalMembersBitboard.distance(winnerKSq, loserKSq)]);

	  if (GlobalMembersTypes.relative_rank(weakSide, pawnSq) != Rank.RANK_7 || GlobalMembersBitboard.distance(loserKSq, pawnSq) != 1 || !((FileABB | FileCBB | FileFBB | FileHBB) & (int)pawnSq))
	  {
		  result += Value.QueenValueEg - Value.PawnValueEg;
	  }

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KQ vs KR.  This is almost identical to KX vs K:  We give the attacking
	/// king a bonus for having the kings close together, and for forcing the
	/// defending king towards the edge. If we also take care to avoid null move for
	/// the defending side in the search, this is usually sufficient to win KQ vs KR.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KQKR>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KQKR>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.QueenValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.RookValueMg, 0));

	  Square winnerKSq = pos.king_square(strongSide);
	  Square loserKSq = pos.king_square(weakSide);

	  Value result = Value.QueenValueEg - Value.RookValueEg + PushToEdges[(int)loserKSq] + PushClose[GlobalMembersBitboard.distance(winnerKSq, loserKSq)];

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// Some cases of trivial draws
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KNNK>::operator ()(const Position&) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KNNK>.operator ()(Position UnnamedParameter1)
	{
		return Value.VALUE_DRAW;
	}


	/// KB and one or more pawns vs K. It checks for draws with rook pawns and
	/// a bishop of the wrong color. If such a draw is detected, SCALE_FACTOR_DRAW
	/// is returned. If not, the return value is SCALE_FACTOR_NONE, i.e. no scaling
	/// will be used.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPsK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPsK>.operator ()(Position pos)
	{

	  Debug.Assert(pos.non_pawn_material(strongSide) == Value.BishopValueMg);
	  Debug.Assert(pos.count<PieceType.PAWN>(strongSide) >= 1);

	  // No assertions about the material of weakSide, because we want draws to
	  // be detected even when the weaker side has some pawns.

	  uint GlobalMembersBitboard.long pawns = pos.pieces(strongSide, PieceType.PAWN);
	  File pawnFile = GlobalMembersTypes.file_of(pos.list<PieceType.PAWN>(strongSide)[0]);

	  // All pawns are on a single rook file ?
	  if ((pawnFile == File.FILE_A || pawnFile == File.FILE_H) && !(pawns & ~GlobalMembersBitboard.file_bb(pawnFile)))
	  {
		  Square bishopSq = pos.list<PieceType.BISHOP>(strongSide)[0];
		  Square queeningSq = GlobalMembersTypes.relative_square(strongSide, GlobalMembersTypes.make_square(pawnFile, Rank.RANK_8));
		  Square kingSq = pos.king_square(weakSide);

		  if (GlobalMembersTypes.opposite_colors(queeningSq, bishopSq) && GlobalMembersBitboard.distance(queeningSq, kingSq) <= 1)
		  {
			  return ScaleFactor.SCALE_FACTOR_DRAW;
		  }
	  }

	  // If all the pawns are on the same B or G file, then it's potentially a draw
	  if ((pawnFile == File.FILE_B || pawnFile == File.FILE_G) && !(pos.pieces(PieceType.PAWN) & ~GlobalMembersBitboard.file_bb(pawnFile)) && pos.non_pawn_material(weakSide) == 0 && pos.count<PieceType.PAWN>(weakSide) >= 1)
	  {
		  // Get weakSide pawn that is closest to the home rank
		  Square weakPawnSq = GlobalMembersBitboard.backmost_sq(weakSide, pos.pieces(weakSide, PieceType.PAWN));

		  Square strongKingSq = pos.king_square(strongSide);
		  Square weakKingSq = pos.king_square(weakSide);
		  Square bishopSq = pos.list<PieceType.BISHOP>(strongSide)[0];

		  // There's potential for a draw if our pawn is blocked on the 7th rank,
		  // the bishop cannot attack it or they only have one pawn left
		  if (GlobalMembersTypes.relative_rank(strongSide, weakPawnSq) == Rank.RANK_7 && (pos.pieces(strongSide, PieceType.PAWN) & (weakPawnSq + GlobalMembersTypes.pawn_push(weakSide))) && (GlobalMembersTypes.opposite_colors(bishopSq, weakPawnSq) || pos.count<PieceType.PAWN>(strongSide) == 1))
		  {
			  int strongKingDist = GlobalMembersBitboard.distance(weakPawnSq, strongKingSq);
			  int weakKingDist = GlobalMembersBitboard.distance(weakPawnSq, weakKingSq);

			  // It's a draw if the weak king is on its back two ranks, within 2
			  // squares of the blocking pawn and the strong king is not
			  // closer. (I think this rule only fails in practically
			  // unreachable positions such as 5k1K/6p1/6P1/8/8/3B4/8/8 w
			  // and positions where qsearch will immediately correct the
			  // problem such as 8/4k1p1/6P1/1K6/3B4/8/8/8 w)
			  if (GlobalMembersTypes.relative_rank(strongSide, weakKingSq) >= Rank.RANK_7 && weakKingDist <= 2 && weakKingDist <= strongKingDist)
			  {
				  return ScaleFactor.SCALE_FACTOR_DRAW;
			  }
		  }
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KQ vs KR and one or more pawns. It tests for fortress draws with a rook on
	/// the third rank defended by a pawn.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KQKRPs>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KQKRPs>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.QueenValueMg, 0));
	  Debug.Assert(pos.count<PieceType.ROOK>(weakSide) == 1);
	  Debug.Assert(pos.count<PieceType.PAWN>(weakSide) >= 1);

	  Square kingSq = pos.king_square(weakSide);
	  Square rsq = pos.list<PieceType.ROOK>(weakSide)[0];

	  if (GlobalMembersTypes.relative_rank(weakSide, kingSq) <= Rank.RANK_2 && GlobalMembersTypes.relative_rank(weakSide, pos.king_square(strongSide)) >= Rank.RANK_4 && GlobalMembersTypes.relative_rank(weakSide, rsq) == Rank.RANK_3 && (pos.pieces(weakSide, PieceType.PAWN) & pos.attacks_from<PieceType.KING>(kingSq) & pos.attacks_from<PieceType.PAWN>(rsq, strongSide)))
	  {
			  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KRP vs KR. This function knows a handful of the most important classes of
	/// drawn positions, but is far from perfect. It would probably be a good idea
	/// to add more knowledge in the future.
	///
	/// It would also be nice to rewrite the actual code for this function,
	/// which is mostly copied from Glaurung 1.x, and isn't very pretty.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KRPKR>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KRPKR>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.RookValueMg, 0));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square wksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(strongSide));
	  Square bksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(weakSide));
	  Square wrsq = GlobalMembersEndgame.normalize(pos, strongSide, pos.list<PieceType.ROOK>(strongSide)[0]);
	  Square wpsq = GlobalMembersEndgame.normalize(pos, strongSide, pos.list<PieceType.PAWN>(strongSide)[0]);
	  Square brsq = GlobalMembersEndgame.normalize(pos, strongSide, pos.list<PieceType.ROOK>(weakSide)[0]);

	  File f = GlobalMembersTypes.file_of(wpsq);
	  Rank r = GlobalMembersTypes.rank_of(wpsq);
	  Square queeningSq = GlobalMembersTypes.make_square(f, Rank.RANK_8);
	  int tempo = (pos.side_to_move() == strongSide);

	  // If the pawn is not too far advanced and the defending king defends the
	  // queening square, use the third-rank defence.
	  if (r <= Rank.RANK_5 && GlobalMembersBitboard.distance(bksq, queeningSq) <= 1 && wksq <= Square.SQ_H5 && (GlobalMembersTypes.rank_of(brsq) == Rank.RANK_6 || (r <= Rank.RANK_3 && GlobalMembersTypes.rank_of(wrsq) != Rank.RANK_6)))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // The defending side saves a draw by checking from behind in case the pawn
	  // has advanced to the 6th rank with the king behind.
	  if (r == Rank.RANK_6 && GlobalMembersBitboard.distance(bksq, queeningSq) <= 1 && GlobalMembersTypes.rank_of(wksq) + tempo <= Rank.RANK_6 && (GlobalMembersTypes.rank_of(brsq) == Rank.RANK_1 || (tempo == 0 && GlobalMembersBitboard.distance(GlobalMembersTypes.file_of(brsq), f) >= 3)))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  if (r >= Rank.RANK_6 && bksq == queeningSq && GlobalMembersTypes.rank_of(brsq) == Rank.RANK_1 && (tempo == 0 || GlobalMembersBitboard.distance(wksq, wpsq) >= 2))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // White pawn on a7 and rook on a8 is a draw if black's king is on g7 or h7
	  // and the black rook is behind the pawn.
	  if (wpsq == Square.SQ_A7 && wrsq == Square.SQ_A8 && (bksq == Square.SQ_H7 || bksq == Square.SQ_G7) && GlobalMembersTypes.file_of(brsq) == File.FILE_A && (GlobalMembersTypes.rank_of(brsq) <= Rank.RANK_3 || GlobalMembersTypes.file_of(wksq) >= File.FILE_D || GlobalMembersTypes.rank_of(wksq) <= Rank.RANK_5))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // If the defending king blocks the pawn and the attacking king is too far
	  // away, it's a draw.
	  if (r <= Rank.RANK_5 && bksq == wpsq + Square.DELTA_N && GlobalMembersBitboard.distance(wksq, wpsq) - tempo >= 2 && GlobalMembersBitboard.distance(wksq, brsq) - tempo >= 2)
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // Pawn on the 7th rank supported by the rook from behind usually wins if the
	  // attacking king is closer to the queening square than the defending king,
	  // and the defending king cannot gain tempi by threatening the attacking rook.
	  if (r == Rank.RANK_7 && f != File.FILE_A && GlobalMembersTypes.file_of(wrsq) == f && wrsq != queeningSq && (GlobalMembersBitboard.distance(wksq, queeningSq) < GlobalMembersBitboard.distance(bksq, queeningSq) - 2 + tempo) && (GlobalMembersBitboard.distance(wksq, queeningSq) < GlobalMembersBitboard.distance(bksq, wrsq) + tempo))
	  {
		  return ScaleFactor(ScaleFactor.SCALE_FACTOR_MAX - 2 * GlobalMembersBitboard.distance(wksq, queeningSq));
	  }

	  // Similar to the above, but with the pawn further back
	  if (f != File.FILE_A && GlobalMembersTypes.file_of(wrsq) == f && wrsq < wpsq && (GlobalMembersBitboard.distance(wksq, queeningSq) < GlobalMembersBitboard.distance(bksq, queeningSq) - 2 + tempo) && (GlobalMembersBitboard.distance(wksq, wpsq + Square.DELTA_N) < GlobalMembersBitboard.distance(bksq, wpsq + Square.DELTA_N) - 2 + tempo) && (GlobalMembersBitboard.distance(bksq, wrsq) + tempo >= 3 || (GlobalMembersBitboard.distance(wksq, queeningSq) < GlobalMembersBitboard.distance(bksq, wrsq) + tempo && (GlobalMembersBitboard.distance(wksq, wpsq + Square.DELTA_N) < GlobalMembersBitboard.distance(bksq, wrsq) + tempo))))
	  {
		  return ScaleFactor(ScaleFactor.SCALE_FACTOR_MAX - 8 * GlobalMembersBitboard.distance(wpsq, queeningSq) - 2 * GlobalMembersBitboard.distance(wksq, queeningSq));
	  }

	  // If the pawn is not far advanced and the defending king is somewhere in
	  // the pawn's path, it's probably a draw.
	  if (r <= Rank.RANK_4 && bksq > wpsq)
	  {
		  if (GlobalMembersTypes.file_of(bksq) == GlobalMembersTypes.file_of(wpsq))
		  {
			  return ScaleFactor(10);
		  }
		  if (GlobalMembersBitboard.distance<File>(bksq, wpsq) == 1 && GlobalMembersBitboard.distance(wksq, bksq) > 2)
		  {
			  return ScaleFactor(24 - 2 * GlobalMembersBitboard.distance(wksq, bksq));
		  }
	  }
	  return ScaleFactor.SCALE_FACTOR_NONE;
	}

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KRPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KRPKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  // Test for a rook pawn
	  if ((pos.pieces(PieceType.PAWN) & (FileABB | FileHBB)) != 0)
	  {
		  Square ksq = pos.king_square(weakSide);
		  Square bsq = pos.list<PieceType.BISHOP>(weakSide)[0];
		  Square psq = pos.list<PieceType.PAWN>(strongSide)[0];
		  Rank rk = GlobalMembersTypes.relative_rank(strongSide, psq);
		  Square push = GlobalMembersTypes.pawn_push(strongSide);

		  // If the pawn is on the 5th rank and the pawn (currently) is on
		  // the same color square as the bishop then there is a chance of
		  // a fortress. Depending on the king position give a moderate
		  // reduction or a stronger one if the defending king is near the
		  // corner but not trapped there.
		  if (rk == Rank.RANK_5 && !GlobalMembersTypes.opposite_colors(bsq, psq))
		  {
			  int d = GlobalMembersBitboard.distance(psq + 3 * push, ksq);

			  if (d <= 2 && !(d == 0 && ksq == pos.king_square(strongSide) + 2 * push))
			  {
				  return ScaleFactor(24);
			  }
			  else
			  {
				  return ScaleFactor(48);
			  }
		  }

		  // When the pawn has moved to the 6th rank we can be fairly sure
		  // it's drawn if the bishop attacks the square in front of the
		  // pawn from a reasonable distance and the defending king is near
		  // the corner
		  if (rk == Rank.RANK_6 && GlobalMembersBitboard.distance(psq + 2 * push, ksq) <= 1 && (PseudoAttacks[(int)PieceType.BISHOP][(int)bsq] & (psq + push)) && GlobalMembersBitboard.distance<File>(bsq, psq) >= 2)
		  {
			  return ScaleFactor(8);
		  }
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}

	/// KRPP vs KRP. There is just a single rule: if the stronger side has no passed
	/// pawns and the defending king is actively placed, the position is drawish.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KRPPKRP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KRPPKRP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 2));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.RookValueMg, 1));

	  Square wpsq1 = pos.list<PieceType.PAWN>(strongSide)[0];
	  Square wpsq2 = pos.list<PieceType.PAWN>(strongSide)[1];
	  Square bksq = pos.king_square(weakSide);

	  // Does the stronger side have a passed pawn?
	  if (pos.pawn_passed(strongSide, wpsq1) || pos.pawn_passed(strongSide, wpsq2))
	  {
		  return ScaleFactor.SCALE_FACTOR_NONE;
	  }

	  Rank r = Math.Max(GlobalMembersTypes.relative_rank(strongSide, wpsq1), GlobalMembersTypes.relative_rank(strongSide, wpsq2));

	  if (GlobalMembersBitboard.distance<File>(bksq, wpsq1) <= 1 && GlobalMembersBitboard.distance<File>(bksq, wpsq2) <= 1 && GlobalMembersTypes.relative_rank(strongSide, bksq) > r)
	  {
		  switch (r)
		  {
		  case Rank.RANK_2:
			  return ScaleFactor(10);
		  case Rank.RANK_3:
			  return ScaleFactor(10);
		  case Rank.RANK_4:
			  return ScaleFactor(15);
		  case Rank.RANK_5:
			  return ScaleFactor(20);
		  case Rank.RANK_6:
			  return ScaleFactor(40);
		  default:
			  Debug.Assert(false);
		  break;
		  }
	  }
	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// K and two or more pawns vs K. There is just a single rule here: If all pawns
	/// are on the same rook file and are blocked by the defending king, it's a draw.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KPsK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KPsK>.operator ()(Position pos)
	{

	  Debug.Assert(pos.non_pawn_material(strongSide) == Value.VALUE_ZERO);
	  Debug.Assert(pos.count<PieceType.PAWN>(strongSide) >= 2);
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  Square ksq = pos.king_square(weakSide);
	  uint GlobalMembersBitboard.long pawns = pos.pieces(strongSide, PieceType.PAWN);
	  Square psq = pos.list<PieceType.PAWN>(strongSide)[0];

	  // If all pawns are ahead of the king, on a single rook file and
	  // the king is within one file of the pawns, it's a draw.
	  if (!(pawns & ~GlobalMembersBitboard.in_front_bb(weakSide, GlobalMembersTypes.rank_of(ksq))) && !((pawns & ~FileABB) && (pawns & ~FileHBB)) && GlobalMembersBitboard.distance<File>(ksq, psq) <= 1)
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KBP vs KB. There are two rules: if the defending king is somewhere along the
	/// path of the pawn, and the square of the king is not of the same color as the
	/// stronger side's bishop, it's a draw. If the two bishops have opposite color,
	/// it's almost always a draw.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.BishopValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  Square pawnSq = pos.list<PieceType.PAWN>(strongSide)[0];
	  Square strongBishopSq = pos.list<PieceType.BISHOP>(strongSide)[0];
	  Square weakBishopSq = pos.list<PieceType.BISHOP>(weakSide)[0];
	  Square weakKingSq = pos.king_square(weakSide);

	  // Case 1: Defending king blocks the pawn, and cannot be driven away
	  if (GlobalMembersTypes.file_of(weakKingSq) == GlobalMembersTypes.file_of(pawnSq) && GlobalMembersTypes.relative_rank(strongSide, pawnSq) < GlobalMembersTypes.relative_rank(strongSide, weakKingSq) && (GlobalMembersTypes.opposite_colors(weakKingSq, strongBishopSq) || GlobalMembersTypes.relative_rank(strongSide, weakKingSq) <= Rank.RANK_6))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // Case 2: Opposite colored bishops
	  if (GlobalMembersTypes.opposite_colors(strongBishopSq, weakBishopSq))
	  {
		  // We assume that the position is drawn in the following three situations:
		  //
		  //   a. The pawn is on rank 5 or further back.
		  //   b. The defending king is somewhere in the pawn's path.
		  //   c. The defending bishop attacks some square along the pawn's path,
		  //      and is at least three squares away from the pawn.
		  //
		  // These rules are probably not perfect, but in practice they work
		  // reasonably well.

		  if (GlobalMembersTypes.relative_rank(strongSide, pawnSq) <= Rank.RANK_5)
		  {
			  return ScaleFactor.SCALE_FACTOR_DRAW;
		  }
		  else
		  {
			  uint GlobalMembersBitboard.long path = GlobalMembersBitboard.forward_bb(strongSide, pawnSq);

			  if ((path & pos.pieces(weakSide, PieceType.KING)) != 0)
			  {
				  return ScaleFactor.SCALE_FACTOR_DRAW;
			  }

			  if ((pos.attacks_from<PieceType.BISHOP>(weakBishopSq) & path) && GlobalMembersBitboard.distance(weakBishopSq, pawnSq) >= 3)
			  {
				  return ScaleFactor.SCALE_FACTOR_DRAW;
			  }
		  }
	  }
	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KBPP vs KB. It detects a few basic draws with opposite-colored bishops
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPPKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.BishopValueMg, 2));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  Square wbsq = pos.list<PieceType.BISHOP>(strongSide)[0];
	  Square bbsq = pos.list<PieceType.BISHOP>(weakSide)[0];

	  if (!GlobalMembersTypes.opposite_colors(wbsq, bbsq))
	  {
		  return ScaleFactor.SCALE_FACTOR_NONE;
	  }

	  Square ksq = pos.king_square(weakSide);
	  Square psq1 = pos.list<PieceType.PAWN>(strongSide)[0];
	  Square psq2 = pos.list<PieceType.PAWN>(strongSide)[1];
	  Rank r1 = GlobalMembersTypes.rank_of(psq1);
	  Rank r2 = GlobalMembersTypes.rank_of(psq2);
	  Square blockSq1;
	  Square blockSq2;

	  if (GlobalMembersTypes.relative_rank(strongSide, psq1) > GlobalMembersTypes.relative_rank(strongSide, psq2))
	  {
		  blockSq1 = psq1 + GlobalMembersTypes.pawn_push(strongSide);
		  blockSq2 = GlobalMembersTypes.make_square(GlobalMembersTypes.file_of(psq2), GlobalMembersTypes.rank_of(psq1));
	  }
	  else
	  {
		  blockSq1 = psq2 + GlobalMembersTypes.pawn_push(strongSide);
		  blockSq2 = GlobalMembersTypes.make_square(GlobalMembersTypes.file_of(psq1), GlobalMembersTypes.rank_of(psq2));
	  }

	  switch (GlobalMembersBitboard.distance<File>(psq1, psq2))
	  {
	  case 0:
		// Both pawns are on the same file. It's an easy draw if the defender firmly
		// controls some square in the frontmost pawn's path.
		if (GlobalMembersTypes.file_of(ksq) == GlobalMembersTypes.file_of(blockSq1) && GlobalMembersTypes.relative_rank(strongSide, ksq) >= GlobalMembersTypes.relative_rank(strongSide, blockSq1) && GlobalMembersTypes.opposite_colors(ksq, wbsq))
		{
			return ScaleFactor.SCALE_FACTOR_DRAW;
		}
		else
		{
			return ScaleFactor.SCALE_FACTOR_NONE;
		}

	  case 1:
		// Pawns on adjacent files. It's a draw if the defender firmly controls the
		// square in front of the frontmost pawn's path, and the square diagonally
		// behind this square on the file of the other pawn.
		if (ksq == blockSq1 && GlobalMembersTypes.opposite_colors(ksq, wbsq) && (bbsq == blockSq2 || (pos.attacks_from<PieceType.BISHOP>(blockSq2) & pos.pieces(weakSide, PieceType.BISHOP)) || GlobalMembersBitboard.distance(r1, r2) >= 2))
		{
			return ScaleFactor.SCALE_FACTOR_DRAW;
		}

		else if (ksq == blockSq2 && GlobalMembersTypes.opposite_colors(ksq, wbsq) && (bbsq == blockSq1 || (pos.attacks_from<PieceType.BISHOP>(blockSq1) & pos.pieces(weakSide, PieceType.BISHOP))))
		{
			return ScaleFactor.SCALE_FACTOR_DRAW;
		}
		else
		{
			return ScaleFactor.SCALE_FACTOR_NONE;
		}

	  default:
		// The pawns are not on the same file or adjacent files. No scaling.
		return ScaleFactor.SCALE_FACTOR_NONE;
	  }
	}


	/// KBP vs KN. There is a single rule: If the defending king is somewhere along
	/// the path of the pawn, and the square of the king is not of the same color as
	/// the stronger side's bishop, it's a draw.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPKN>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPKN>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.BishopValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.KnightValueMg, 0));

	  Square pawnSq = pos.list<PieceType.PAWN>(strongSide)[0];
	  Square strongBishopSq = pos.list<PieceType.BISHOP>(strongSide)[0];
	  Square weakKingSq = pos.king_square(weakSide);

	  if (GlobalMembersTypes.file_of(weakKingSq) == GlobalMembersTypes.file_of(pawnSq) && GlobalMembersTypes.relative_rank(strongSide, pawnSq) < GlobalMembersTypes.relative_rank(strongSide, weakKingSq) && (GlobalMembersTypes.opposite_colors(weakKingSq, strongBishopSq) || GlobalMembersTypes.relative_rank(strongSide, weakKingSq) <= Rank.RANK_6))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KNP vs K. There is a single rule: if the pawn is a rook pawn on the 7th rank
	/// and the defending king prevents the pawn from advancing, the position is drawn.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KNPK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KNPK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.KnightValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square pawnSq = GlobalMembersEndgame.normalize(pos, strongSide, pos.list<PieceType.PAWN>(strongSide)[0]);
	  Square weakKingSq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(weakSide));

	  if (pawnSq == Square.SQ_A7 && GlobalMembersBitboard.distance(Square.SQ_A8, weakKingSq) <= 1)
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KNP vs KB. If knight can block bishop from taking pawn, it's a win.
	/// Otherwise the position is drawn.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KNPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KNPKB>.operator ()(Position pos)
	{

	  Square pawnSq = pos.list<PieceType.PAWN>(strongSide)[0];
	  Square bishopSq = pos.list<PieceType.BISHOP>(weakSide)[0];
	  Square weakKingSq = pos.king_square(weakSide);

	  // King needs to get close to promoting pawn to prevent knight from blocking.
	  // Rules for this are very tricky, so just approximate.
	  if ((GlobalMembersBitboard.forward_bb(strongSide, pawnSq) & pos.attacks_from<PieceType.BISHOP>(bishopSq)) != 0)
	  {
		  return ScaleFactor(GlobalMembersBitboard.distance(weakKingSq, pawnSq));
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KP vs KP. This is done by removing the weakest side's pawn and probing the
	/// KP vs K bitbase: If the weakest side has a draw without the pawn, it probably
	/// has at least a draw with the pawn as well. The exception is when the stronger
	/// side's pawn is far advanced and not on a rook file; in this case it is often
	/// possible to win (e.g. 8/4k3/3p4/3P4/6K1/8/8/8 w - - 0 1).
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KPKP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KPKP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.VALUE_ZERO, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 1));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square wksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(strongSide));
	  Square bksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.king_square(weakSide));
	  Square psq = GlobalMembersEndgame.normalize(pos, strongSide, pos.list<PieceType.PAWN>(strongSide)[0]);

	  Color us = strongSide == ((int)pos.side_to_move()) != 0 ? Color.WHITE : Color.BLACK;

	  // If the pawn has advanced to the fifth rank or further, and is not a
	  // rook pawn, it's too dangerous to assume that it's at least a draw.
	  if (GlobalMembersTypes.rank_of(psq) >= Rank.RANK_5 && GlobalMembersTypes.file_of(psq) != File.FILE_A)
	  {
		  return ScaleFactor.SCALE_FACTOR_NONE;
	  }

	  // Probe the KPK bitbase with the weakest side's pawn removed. If it's a draw,
	  // it's probably at least a draw even with the pawn.
	  return Bitbases.probe(wksq, psq, bksq, us) ? ScaleFactor.SCALE_FACTOR_NONE : ScaleFactor.SCALE_FACTOR_DRAW;
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



/// Endgames members definitions



//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<EndgameType E>
