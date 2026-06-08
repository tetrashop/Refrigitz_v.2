using System.Diagnostics;
using System;

public static class GlobalMembersPawns
{

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define V Value
	  #define V
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define S(mg, eg) make_score(mg, eg)
	  #define S

	  // Doubled pawn penalty by file
	  public static readonly Score[] Doubled = {make_score(13, 43), make_score(20, 48), make_score(23, 48), make_score(23, 48), make_score(23, 48), make_score(23, 48), make_score(20, 48), make_score(13, 43)};

	  // Isolated pawn penalty by opposed flag and file
	  public static readonly Score[,] Isolated = {{make_score(37, 45), make_score(54, 52), make_score(60, 52), make_score(60, 52), make_score(60, 52), make_score(60, 52), make_score(54, 52), make_score(37, 45)}, {make_score(25, 30), make_score(36, 35), make_score(40, 35), make_score(40, 35), make_score(40, 35), make_score(40, 35), make_score(36, 35), make_score(25, 30)}};

	  // Backward pawn penalty by opposed flag and file
	  public static readonly Score[,] Backward = {{make_score(30, 42), make_score(43, 46), make_score(49, 46), make_score(49, 46), make_score(49, 46), make_score(49, 46), make_score(43, 46), make_score(30, 42)}, {make_score(20, 28), make_score(29, 31), make_score(33, 31), make_score(33, 31), make_score(33, 31), make_score(33, 31), make_score(29, 31), make_score(20, 28)}};

	  // Connected pawn bonus by opposed, phalanx flags and rank
	  public static Score[,,] Connected = new Score[2, 2, (int)Rank.RANK_NB];

	  // Levers bonus by rank
	  public static readonly Score[] Lever = {make_score(0, 0), make_score(0, 0), make_score(0, 0), make_score(0, 0), make_score(20, 20), make_score(40, 40), make_score(0, 0), make_score(0, 0)};

	  // Unsupported pawn penalty
	  public static Score UnsupportedPawnPenalty = make_score(20, 10);

	  // Weakness of our pawn shelter in front of the king by [distance from edge][rank]
	  public static readonly Value[,] ShelterWeakness = {{Value(100), Value(13), Value(24), Value(64), Value(89), Value(93), Value(104)}, {Value(110), Value(1), Value(29), Value(75), Value(96), Value(102), Value(107)}, {Value(102), Value(0), Value(39), Value(74), Value(88), Value(101), Value(98)}, {Value(88), Value(4), Value(33), Value(67), Value(92), Value(94), Value(107)}};

	  // Danger of enemy pawns moving toward our king by [type][distance from edge][rank]
	  public static readonly Value[,,] StormDanger = {{{Value(0), Value(63), Value(128), Value(43), Value(27)}, {Value(0), Value(62), Value(131), Value(44), Value(26)}, {Value(0), Value(59), Value(121), Value(50), Value(28)}, {Value(0), Value(62), Value(127), Value(54), Value(28)}}, {{Value(24), Value(40), Value(93), Value(42), Value(22)}, {Value(24), Value(28), Value(101), Value(38), Value(20)}, {Value(24), Value(32), Value(95), Value(36), Value(23)}, {Value(27), Value(24), Value(99), Value(36), Value(24)}}, {{Value(0), Value(0), Value(81), Value(16), Value(6)}, {Value(0), Value(0), Value(165), Value(29), Value(9)}, {Value(0), Value(0), Value(163), Value(23), Value(12)}, {Value(0), Value(0), Value(161), Value(28), Value(13)}}, {{Value(0), Value(-296), Value(-299), Value(55), Value(25)}, {Value(0), Value(67), Value(131), Value(46), Value(21)}, {Value(0), Value(65), Value(135), Value(50), Value(31)}, {Value(0), Value(62), Value(128), Value(51), Value(24)}}};

	  // Max bonus for king safety. Corresponds to start position with all the pawns
	  // in front of the king and no enemy pawn on the horizon.
	  public static Value MaxSafetyBonus = new Value(257);

	  #undef S
	  #undef V

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'e', so pointers on this parameter are left unchanged:
	  public static Score evaluate<Color Us>(Position pos, Pawns.Entry * e)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		Square Up = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_N : Square.DELTA_S);
		Square Right = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_NE : Square.DELTA_SW);
		Square Left = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_NW : Square.DELTA_SE);

		uint GlobalMembersBitboard.long b, p, doubled, connected;
		Square s;
		bool passed;
		bool isolated;
		bool opposed;
		bool phalanx;
		bool backward;
		bool unsupported;
		bool lever;
		Score score = Score.SCORE_ZERO;
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
		Square * pl = pos.list<PieceType.PAWN>(Us);
		const uint GlobalMembersBitboard.long * pawnAttacksBB = StepAttacksBB[(int)GlobalMembersTypes.make_piece(Us, PieceType.PAWN)];

		uint GlobalMembersBitboard.long ourPawns = pos.pieces(Us, PieceType.PAWN);
		uint GlobalMembersBitboard.long theirPawns = pos.pieces(Them, PieceType.PAWN);

		e.passedPawns[Us] = 0;
		e.kingSquares[Us] = Square.SQ_NONE;
		e.semiopenFiles[Us] = 0xFF;
		e.pawnAttacks[Us] = GlobalMembersBitboard.shift_bb<Right>(ourPawns) | GlobalMembersBitboard.shift_bb<Left>(ourPawns);
		e.pawnsOnSquares[Us, (int)Color.BLACK] = GlobalMembersTbprobe.popcount<Max15>(ourPawns & DarkSquares);
		e.pawnsOnSquares[Us, (int)Color.WHITE] = pos.count<PieceType.PAWN>(Us) - e.pawnsOnSquares[Us, (int)Color.BLACK];

		// Loop through all pawns of the current color and score each pawn
		while ((s = pl++) != Square.SQ_NONE)
		{
			Debug.Assert(pos.piece_on(s) == GlobalMembersTypes.make_piece(Us, PieceType.PAWN));

			File f = GlobalMembersTypes.file_of(s);

			// This file cannot be semi-open
			e.semiopenFiles[Us] &= ~(1 << f);

			// Previous rank
			p = GlobalMembersBitboard.rank_bb(s - GlobalMembersTypes.pawn_push(Us));

			// Flag the pawn as passed, isolated, doubled,
			// unsupported or connected (but not the backward one).
			connected = ourPawns & GlobalMembersBitboard.adjacent_files_bb(f) & (GlobalMembersBitboard.rank_bb(s) | p);
			phalanx = connected & GlobalMembersBitboard.rank_bb(s);
			unsupported = !(ourPawns & GlobalMembersBitboard.adjacent_files_bb(f) & p);
			isolated = !(ourPawns & GlobalMembersBitboard.adjacent_files_bb(f));
			doubled = ourPawns & GlobalMembersBitboard.forward_bb(Us, s);
			opposed = theirPawns & GlobalMembersBitboard.forward_bb(Us, s);
			passed = !(theirPawns & GlobalMembersBitboard.passed_pawn_mask(Us, s));
			lever = theirPawns & pawnAttacksBB[(int)s];

			// Test for backward pawn.
			// If the pawn is passed, isolated, or connected it cannot be
			// backward. If there are friendly pawns behind on adjacent files
			// or if it can capture an enemy pawn it cannot be backward either.
			if ((passed | isolated | connected) || (ourPawns & GlobalMembersBitboard.pawn_attack_span(Them, s)) || (pos.attacks_from<PieceType.PAWN>(s, Us) & theirPawns))
			{
				backward = false;
			}
			else
			{
				// We now know that there are no friendly pawns beside or behind this
				// pawn on adjacent files. We now check whether the pawn is
				// backward by looking in the forward direction on the adjacent
				// files, and picking the closest pawn there.
				b = GlobalMembersBitboard.pawn_attack_span(Us, s) & (ourPawns | theirPawns);
				b = GlobalMembersBitboard.pawn_attack_span(Us, s) & GlobalMembersBitboard.rank_bb(GlobalMembersBitboard.backmost_sq(Us, b));

				// If we have an enemy pawn in the same or next rank, the pawn is
				// backward because it cannot advance without being captured.
				backward = (b | GlobalMembersBitboard.shift_bb<Up>(b)) & theirPawns;
			}

			Debug.Assert(opposed | passed | (GlobalMembersBitboard.pawn_attack_span(Us, s) & theirPawns));

			// Passed pawns will be properly scored in evaluation because we need
			// full attack info to evaluate passed pawns. Only the frontmost passed
			// pawn on each file is considered a true passed pawn.
			if (passed && !doubled)
			{
				e.passedPawns[Us] |= s;
			}

			// Score this pawn
			if (isolated)
			{
				score -= Isolated[opposed, (int)f];
			}

			if (unsupported && !isolated)
			{
				score -= UnsupportedPawnPenalty;
			}

			if (doubled)
			{
				score -= Doubled[(int)f] / GlobalMembersBitboard.distance<Rank>(s, GlobalMembersBitboard.frontmost_sq(Us, doubled));
			}

			if (backward)
			{
				score -= Backward[opposed, (int)f];
			}

			if (connected)
			{
				score += Connected[opposed, phalanx, (int)GlobalMembersTypes.relative_rank(Us, s)];
			}

			if (lever)
			{
				score += Lever[(int)GlobalMembersTypes.relative_rank(Us, s)];
			}
		}

		b = e.semiopenFiles[Us] ^ 0xFF;
		e.pawnSpan[Us] = b ? (int)(GlobalMembersBitboard.msb(b) - GlobalMembersBitboard.lsb(b)) : 0;

		return score;
	  }

	/// Pawns::init() initializes some tables needed by evaluation. Instead of using
	/// hard-coded tables, when makes sense, we prefer to calculate them with a formula
	/// to reduce independent parameters and to allow easier tuning and better insight.

	public static void init()
	{
	  int[] Seed = {0, 6, 15, 10, 57, 75, 135, 258};

	  for (int opposed = 0; opposed <= 1; ++opposed)
	  {
		  for (int phalanx = 0; phalanx <= 1; ++phalanx)
		  {
			  for (Rank r = Rank.RANK_2; r < Rank.RANK_8; ++r)
			  {
				  int bonus = Seed[(int)r] + (phalanx != 0 ? (Seed[(int)r + 1] - Seed[(int)r]) / 2 : 0);
				  Connected[opposed, phalanx, (int)r] = GlobalMembersTypes.make_score(bonus / 2, bonus >> opposed);
			  }
		  }
	  }
	}


	/// Pawns::probe() looks up the current position's pawns configuration in
	/// the pawns hash table. It returns a pointer to the Entry if the position
	/// is found. Otherwise a new Entry is computed and stored there, so we don't
	/// have to recompute all when the same pawns configuration occurs again.

	public static Entry probe(Position pos)
	{

	  uint GlobalMembersBitboard.long GlobalMembersEndgame.key = pos.pawn_key();
	  Entry e = pos.this_thread().pawnsTable[GlobalMembersEndgame.key];

	  if (e.key == GlobalMembersEndgame.key)
	  {
		  return e;
	  }

	  e.key = GlobalMembersEndgame.key;
	  e.score = GlobalMembersEvaluate.evaluate<Color.WHITE>(pos, e) - GlobalMembersEvaluate.evaluate<Color.BLACK>(pos, e);
	  return e;
	}


	/// Entry::shelter_storm() calculates shelter and storm penalties for the file
	/// the king is on, as well as the two adjacent files.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>

	// Explicit template instantiation
	//template Score Entry::do_king_safety(Position pos, Square ksq);
	//template Score Entry::do_king_safety(Position pos, Square ksq);
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


namespace Pawns
{
//C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named AnonymousEnum16:
public enum AnonymousEnum16
{
	NoFriendlyPawn,
	Unblocked,
	BlockedByPawn,
	BlockedByKing
}


/// Entry::do_king_safety() calculates a bonus for king safety. It is called only
/// when king square changes, which is about 20% of total king_safety() calls.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>

} // namespace Pawns
