using System.Collections.Generic;
using System.Diagnostics;

public static class GlobalMembersBitbase
{

	  // There are 24 possible pawn squares: the first 4 files and ranks from 2 to 7
	  public const uint MAX_INDEX = 2 * 24 * 64 * 64; // stm * psq * wksq * bksq = 196608

	  // Each uint32_t stores results of 32 positions, one per bit
	  public static uint[] KPKBitbase = new uint[MAX_INDEX / 32];

	  // A KPK bitbase index is an integer in [0, IndexMax] range
	  //
	  // Information is mapped in a way that minimizes the number of iterations:
	  //
	  // bit  0- 5: white king square (from SQ_A1 to SQ_H8)
	  // bit  6-11: black king square (from SQ_A1 to SQ_H8)
	  // bit    12: side to move (WHITE or BLACK)
	  // bit 13-14: white pawn file (from FILE_A to FILE_D)
	  // bit 15-17: white pawn RANK_7 - rank (from RANK_7 - RANK_7 to RANK_7 - RANK_2)
	  public static uint index(Color us, Square bksq, Square wksq, Square psq)
	  {
		return (int)wksq | (bksq << 6) | (us << 12) | (GlobalMembersTypes.file_of(psq) << 13) | ((Rank.RANK_7 - GlobalMembersTypes.rank_of(psq)) << 15);
	  }

//C++ TO C# CONVERTER TODO TASK: The |= operator cannot be overloaded in C#:
	  public static Result operator |= (Result r, Result v)
	  {
		  return r = Result((int)r | (int)v);
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

  public enum Result
  {
	INVALID = 0,
	UNKNOWN = 1,
	DRAW = 2,
	WIN = 4
  }

  public class KPKPosition
  {

	public KPKPosition(uint idx)
	{

	  wksq = Square((idx >> 0) & 0x3F);
	  bksq = Square((idx >> 6) & 0x3F);
	  us = Color((idx >> 12) & 0x01);
	  psq = GlobalMembersTypes.make_square(File((idx >> 13) & 0x3), Rank.RANK_7 - Rank((idx >> 15) & 0x7));
	  result = Result.UNKNOWN;

	  // Check if two pieces are on the same square or if a king can be captured
	  if (GlobalMembersBitboard.distance(wksq, bksq) <= 1 || wksq == psq || bksq == psq || (us == Color.WHITE && (StepAttacksBB[(int)PieceType.PAWN][(int)psq] & (int)bksq)))
	  {
		  result = Result.INVALID;
	  }

	  else if (us == Color.WHITE)
	  {
		  // Immediate win if a pawn can be promoted without getting captured
		  if (GlobalMembersTypes.rank_of(psq) == Rank.RANK_7 && wksq != psq + Square.DELTA_N && (GlobalMembersBitboard.distance(bksq, psq + Square.DELTA_N) > 1 || (StepAttacksBB[(int)PieceType.KING][(int)wksq] & (psq + Square.DELTA_N))))
		  {
			  result = Result.WIN;
		  }
	  }
	  // Immediate draw if it is a stalemate or a king captures undefended pawn
	  else if (!(StepAttacksBB[(int)PieceType.KING][(int)bksq] & ~(StepAttacksBB[(int)PieceType.KING][(int)wksq] | StepAttacksBB[(int)PieceType.PAWN][(int)psq])) || (StepAttacksBB[(int)PieceType.KING][(int)bksq] & (int)psq & ~StepAttacksBB[(int)PieceType.KING][(int)wksq]))
	  {
		  result = Result.DRAW;
	  }
	}
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: operator Result() const
	public static implicit operator Result(KPKPosition ImpliedObject)
	{
		return result;
	}
	public Result classify(List<KPKPosition> db)
	{
		return us == ((int)Color.WHITE) != 0 ? classify<Color.WHITE>(db) : classify<Color.BLACK>(db);
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	private Result classify<Color Us>(List<KPKPosition> db)
	{

	  // White to Move: If one move leads to a position classified as WIN, the result
	  // of the current position is WIN. If all moves lead to positions classified
	  // as DRAW, the current position is classified as DRAW, otherwise the current
	  // position is classified as UNKNOWN.
	  //
	  // Black to Move: If one move leads to a position classified as DRAW, the result
	  // of the current position is DRAW. If all moves lead to positions classified
	  // as WIN, the position is classified as WIN, otherwise the current position is
	  // classified as UNKNOWN.

	  Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

	  Result r = Result.INVALID;
	  uint GlobalMembersBitboard.long b = StepAttacksBB[(int)PieceType.KING][Us == ((int)Color.WHITE) != 0 ? wksq : bksq];

	  while (b)
	  {
		  (int)r |= Us == ((int)Color.WHITE) != 0 ? db[GlobalMembersBitbase.index(Them, bksq, GlobalMembersBitboard.pop_lsb(ref b), psq)] : db[GlobalMembersBitbase.index(Them, GlobalMembersBitboard.pop_lsb(ref b), wksq, psq)];
	  }

	  if (Us == Color.WHITE && GlobalMembersTypes.rank_of(psq) < Rank.RANK_7)
	  {
		  Square s = psq + Square.DELTA_N;
		  (int)r |= db[GlobalMembersBitbase.index(Color.BLACK, bksq, wksq, s)]; // Single push

		  if (GlobalMembersTypes.rank_of(psq) == Rank.RANK_2 && s != wksq && s != bksq)
		  {
			  (int)r |= db[GlobalMembersBitbase.index(Color.BLACK, bksq, wksq, s + Square.DELTA_N)]; // Double push
		  }
	  }

	  if (Us == Color.WHITE)
	  {
		  return result = (int)r & (int)((int)Result.WIN) != 0 ? Result.WIN : (int)r & (int)((int)Result.UNKNOWN) != 0 ? Result.UNKNOWN : Result.DRAW;
	  }
	  else
	  {
		  return result = (int)r & (int)((int)Result.DRAW) != 0 ? Result.DRAW : (int)r & (int)((int)Result.UNKNOWN) != 0 ? Result.UNKNOWN : Result.WIN;
	  }
	}

	private Color us;
	private Square bksq;
	private Square wksq;
	private Square psq;
	private Result result;
  }







//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

