using System.Diagnostics;

public static class GlobalMembersMaterial
{

	  // Polynomial material imbalance parameters

	  //                      pair  pawn knight bishop rook queen
	  public static readonly int[] Linear = {1852, -162, -1122, -183, 249, -154};

	  public static readonly int[,] QuadraticOurs = {{0}, {39, 2}, {35, 271, -4}, {0, 105, 4, 0}, {-27, -2, 46, 100, -141}, {-177, 25, 129, 142, -137, 0}};

	  public static readonly int[,] QuadraticTheirs = {{0}, {37, 0}, {10, 62, 0}, {57, 64, 39, 0}, {50, 40, 23, -22, 0}, {98, 105, -39, 141, 274, 0}};

	  // Endgame evaluation and scaling functions are accessed directly and not through
	  // the function maps because they correspond to more than one material hash key.
	  public static Endgame<EndgameType.KXK>[] EvaluateKXK = {Endgame<EndgameType.KXK>(Color.WHITE), Endgame<EndgameType.KXK>(Color.BLACK)};

	  public static Endgame<EndgameType.KBPsK>[] ScaleKBPsK = {Endgame<EndgameType.KBPsK>(Color.WHITE), Endgame<EndgameType.KBPsK>(Color.BLACK)};
	  public static Endgame<EndgameType.KQKRPs>[] ScaleKQKRPs = {Endgame<EndgameType.KQKRPs>(Color.WHITE), Endgame<EndgameType.KQKRPs>(Color.BLACK)};
	  public static Endgame<EndgameType.KPsK>[] ScaleKPsK = {Endgame<EndgameType.KPsK>(Color.WHITE), Endgame<EndgameType.KPsK>(Color.BLACK)};
	  public static Endgame<EndgameType.KPKP>[] ScaleKPKP = {Endgame<EndgameType.KPKP>(Color.WHITE), Endgame<EndgameType.KPKP>(Color.BLACK)};

	  // Helper templates used to detect a given material distribution
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static bool is_KXK<Color Us>(Position pos)
	  {
		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		return !GlobalMembersBitboard.more_than_one(pos.pieces(Them)) && pos.non_pawn_material(Us) >= Value.RookValueMg;
	  }

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static bool is_KBPsKs<Color Us>(Position pos)
	  {
		return pos.non_pawn_material(Us) == Value.BishopValueMg && pos.count<PieceType.BISHOP>(Us) == 1 && pos.count<PieceType.PAWN >(Us) >= 1;
	  }

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static bool is_KQKRPs<Color Us>(Position pos)
	  {
		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		return pos.count<PieceType.PAWN>(Us) == 0 && pos.non_pawn_material(Us) == Value.QueenValueMg && pos.count<PieceType.QUEEN>(Us) == 1 && pos.count<PieceType.ROOK>(Them) == 1 && pos.count<PieceType.PAWN>(Them) >= 1;
	  }

	  /// imbalance() calculates the imbalance by comparing the piece count of each
	  /// piece type for both colors.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static int imbalance<Color Us>(int[,] pieceCount)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

		int bonus = 0;

		// Second-degree polynomial material imbalance by Tord Romstad
		for (int pt1 = (int)PieceType.NO_PIECE_TYPE; pt1 <= PieceType.QUEEN; ++pt1)
		{
			if (pieceCount[Us, pt1] == 0)
				continue;

			int v = Linear[pt1];

			for (int pt2 = (int)PieceType.NO_PIECE_TYPE; pt2 <= pt1; ++pt2)
			{
				v += QuadraticOurs[pt1, pt2] * pieceCount[Us, pt2] + QuadraticTheirs[pt1, pt2] * pieceCount[(int)Them, pt2];
			}

			bonus += pieceCount[Us, pt1] * v;
		}

		return bonus;
	  }

	/// Material::probe() looks up the current position's material configuration in
	/// the material hash table. It returns a pointer to the Entry if the position
	/// is found. Otherwise a new Entry is computed and stored there, so we don't
	/// have to recompute all when the same material configuration occurs again.

	public static Entry probe(Position pos)
	{

	  uint GlobalMembersBitboard.long GlobalMembersEndgame.key = pos.material_key();
	  Entry e = pos.this_thread().materialTable[GlobalMembersEndgame.key];

	  if (e.key == GlobalMembersEndgame.key)
	  {
		  return e;
	  }

	  std.memset(e, 0, sizeof(Entry));
	  e.key = GlobalMembersEndgame.key;
	  e.factor[(int)Color.WHITE] = e.factor[(int)Color.BLACK] = (byte)ScaleFactor.SCALE_FACTOR_NORMAL;
	  e.gamePhase = pos.game_phase();

	  // Let's look if we have a specialized evaluation function for this particular
	  // material configuration. Firstly we look for a fixed configuration one, then
	  // for a generic one if the previous search failed.
	  if (pos.this_thread().endgames.probe(GlobalMembersEndgame.key, e.evaluationFunction))
	  {
		  return e;
	  }

	  if (GlobalMembersMaterial.is_KXK<Color.WHITE>(pos))
	  {
		  e.evaluationFunction = EvaluateKXK[(int)Color.WHITE];
		  return e;
	  }

	  if (GlobalMembersMaterial.is_KXK<Color.BLACK>(pos))
	  {
		  e.evaluationFunction = EvaluateKXK[(int)Color.BLACK];
		  return e;
	  }

	  // OK, we didn't find any special evaluation function for the current material
	  // configuration. Is there a suitable specialized scaling function?
	  EndgameBase<ScaleFactor> sf;

	  if (pos.this_thread().endgames.probe(GlobalMembersEndgame.key, sf))
	  {
		  e.scalingFunction[(int)sf.strong_side()] = sf; // Only strong color assigned
		  return e;
	  }

	  // We didn't find any specialized scaling function, so fall back on generic
	  // ones that refer to more than one material distribution. Note that in this
	  // case we don't return after setting the function.
	  if (GlobalMembersMaterial.is_KBPsKs<Color.WHITE>(pos))
	  {
		  e.scalingFunction[(int)Color.WHITE] = ScaleKBPsK[(int)Color.WHITE];
	  }

	  if (GlobalMembersMaterial.is_KBPsKs<Color.BLACK>(pos))
	  {
		  e.scalingFunction[(int)Color.BLACK] = ScaleKBPsK[(int)Color.BLACK];
	  }

	  if (GlobalMembersMaterial.is_KQKRPs<Color.WHITE>(pos))
	  {
		  e.scalingFunction[(int)Color.WHITE] = ScaleKQKRPs[(int)Color.WHITE];
	  }

	  else if (GlobalMembersMaterial.is_KQKRPs<Color.BLACK>(pos))
	  {
		  e.scalingFunction[(int)Color.BLACK] = ScaleKQKRPs[(int)Color.BLACK];
	  }

	  Value npm_w = pos.non_pawn_material(Color.WHITE);
	  Value npm_b = pos.non_pawn_material(Color.BLACK);

	  if (npm_w + npm_b == Value.VALUE_ZERO && pos.pieces(PieceType.PAWN) != 0) // Only pawns on the board
	  {
		  if (pos.count<PieceType.PAWN>(Color.BLACK) == 0)
		  {
			  Debug.Assert(pos.count<PieceType.PAWN>(Color.WHITE) >= 2);

			  e.scalingFunction[(int)Color.WHITE] = ScaleKPsK[(int)Color.WHITE];
		  }
		  else if (pos.count<PieceType.PAWN>(Color.WHITE) == 0)
		  {
			  Debug.Assert(pos.count<PieceType.PAWN>(Color.BLACK) >= 2);

			  e.scalingFunction[(int)Color.BLACK] = ScaleKPsK[(int)Color.BLACK];
		  }
		  else if (pos.count<PieceType.PAWN>(Color.WHITE) == 1 && pos.count<PieceType.PAWN>(Color.BLACK) == 1)
		  {
			  // This is a special case because we set scaling functions
			  // for both colors instead of only one.
			  e.scalingFunction[(int)Color.WHITE] = ScaleKPKP[(int)Color.WHITE];
			  e.scalingFunction[(int)Color.BLACK] = ScaleKPKP[(int)Color.BLACK];
		  }
	  }

	  // Zero or just one pawn makes it difficult to win, even with a small material
	  // advantage. This catches some trivial draws like KK, KBK and KNK and gives a
	  // drawish scale factor for cases such as KRKBP and KmmKm (except for KBBKN).
	  if (pos.count<PieceType.PAWN>(Color.WHITE) == 0 && npm_w - npm_b <= Value.BishopValueMg)
	  {
		  e.factor[(int)Color.WHITE] = (byte)(npm_w < ((int)Value.RookValueMg) != 0 ? ScaleFactor.SCALE_FACTOR_DRAW : npm_b <= ((int)Value.BishopValueMg) != 0 ? 4 : 12);
	  }

	  if (pos.count<PieceType.PAWN>(Color.BLACK) == 0 && npm_b - npm_w <= Value.BishopValueMg)
	  {
		  e.factor[(int)Color.BLACK] = (byte)(npm_b < ((int)Value.RookValueMg) != 0 ? ScaleFactor.SCALE_FACTOR_DRAW : npm_w <= ((int)Value.BishopValueMg) != 0 ? 4 : 12);
	  }

	  if (pos.count<PieceType.PAWN>(Color.WHITE) == 1 && npm_w - npm_b <= Value.BishopValueMg)
	  {
		  e.factor[(int)Color.WHITE] = (byte) ScaleFactor.SCALE_FACTOR_ONEPAWN;
	  }

	  if (pos.count<PieceType.PAWN>(Color.BLACK) == 1 && npm_b - npm_w <= Value.BishopValueMg)
	  {
		  e.factor[(int)Color.BLACK] = (byte) ScaleFactor.SCALE_FACTOR_ONEPAWN;
	  }

	  // Evaluate the material imbalance. We use PIECE_TYPE_NONE as a place holder
	  // for the bishop pair "extended piece", which allows us to be more flexible
	  // in defining bishop pair bonuses.
	  int[,] PieceCount = {{pos.count<PieceType.BISHOP>(Color.WHITE) > 1, pos.count<PieceType.PAWN>(Color.WHITE), pos.count<PieceType.KNIGHT>(Color.WHITE), pos.count<PieceType.BISHOP>(Color.WHITE), pos.count<PieceType.ROOK>(Color.WHITE), pos.count<PieceType.QUEEN >(Color.WHITE)}, {pos.count<PieceType.BISHOP>(Color.BLACK) > 1, pos.count<PieceType.PAWN>(Color.BLACK), pos.count<PieceType.KNIGHT>(Color.BLACK), pos.count<PieceType.BISHOP>(Color.BLACK), pos.count<PieceType.ROOK>(Color.BLACK), pos.count<PieceType.QUEEN >(Color.BLACK)}};

	  e.value = (short)((GlobalMembersMaterial.imbalance<Color.WHITE>(PieceCount) - GlobalMembersMaterial.imbalance<Color.BLACK>(PieceCount)) / 16);
	  return e;
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


