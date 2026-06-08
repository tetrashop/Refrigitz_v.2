using System.Diagnostics;
using System;

public static class GlobalMembersBitboard
{
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



	public static int[,] SquareDistance = new int[(int)Square.SQUARE_NB, (int)Square.SQUARE_NB];

	public static uint[] long RookMasks = new uint[(int)Square.SQUARE_NB];
	public static uint[] long RookMagics = new uint[(int)Square.SQUARE_NB];
	public static uint[] long * RookAttacks = new uint[(int)Square.SQUARE_NB];
	public static uint[] RookShifts = new uint[(int)Square.SQUARE_NB];

	public static uint[] long BishopMasks = new uint[(int)Square.SQUARE_NB];
	public static uint[] long BishopMagics = new uint[(int)Square.SQUARE_NB];
	public static uint[] long * BishopAttacks = new uint[(int)Square.SQUARE_NB];
	public static uint[] BishopShifts = new uint[(int)Square.SQUARE_NB];

	public static uint[] long SquareBB = new uint[(int)Square.SQUARE_NB];
	public static uint[] long FileBB = new uint[(int)File.FILE_NB];
	public static uint[] long RankBB = new uint[(int)Rank.RANK_NB];
	public static uint[] long AdjacentFilesBB = new uint[(int)File.FILE_NB];
	public static uint[,] long InFrontBB = new uint[(int)Color.COLOR_NB, (int)Rank.RANK_NB];
	public static uint[,] long StepAttacksBB = new uint[(int)Piece.PIECE_NB, (int)Square.SQUARE_NB];
	public static uint[,] long BetweenBB = new uint[(int)Square.SQUARE_NB, (int)Square.SQUARE_NB];
	public static uint[,] long LineBB = new uint[(int)Square.SQUARE_NB, (int)Square.SQUARE_NB];
	public static uint[,] long DistanceRingBB = new uint[(int)Square.SQUARE_NB, 8];
	public static uint[,] long ForwardBB = new uint[(int)Color.COLOR_NB, (int)Square.SQUARE_NB];
	public static uint[,] long PassedPawnMask = new uint[(int)Color.COLOR_NB, (int)Square.SQUARE_NB];
	public static uint[,] long PawnAttackSpan = new uint[(int)Color.COLOR_NB, (int)Square.SQUARE_NB];
	public static uint[,] long PseudoAttacks = new uint[(int)PieceType.PIECE_TYPE_NB, (int)Square.SQUARE_NB];

	  // De Bruijn sequences. See chessprogramming.wikispaces.com/BitScan
	  public const uint long DeBruijn64 = 0x3F79D71B4CB0A89UL;
	  public const uint DeBruijn32 = 0x783A9B23;

	  public static int[] MS1BTable = new int[256]; // To implement software msb()
	  public static Square[] BSFTable = new Square[(int)Square.SQUARE_NB]; // To implement software bitscan
	  public static uint[] long RookTable = new uint[0x19000]; // To store rook attacks
	  public static uint[] long BishopTable = new uint[0x1480]; // To store bishop attacks

	  typedef uint(Fn)(Square, uint long);

  // init_magics() computes all rook and bishop attacks at startup. Magic
  // bitboards are used to look up attacks of sliding pieces. As a reference see
  // chessprogramming.wikispaces.com/Magic+Bitboards. In particular, here we
  // use the so called "fancy" approach.


	  public static void init_magics(uint long[] table, uint long[] attacks, uint long[] magics, uint long[] masks, uint[] shifts, Square[] deltas, Fn index)
	  {

		int[,] seeds = {{8977, 44560, 54343, 38998, 5731, 95205, 104912, 17020}, {728, 10316, 55013, 32803, 12281, 15100, 16645, 255}};

		uint long occupancy[4096], reference[4096], edges, b;
		int i;
		int size;

		// attacks[s] is a pointer to the beginning of the attacks table for square 's'
		attacks[(int)Square.SQ_A1] = table;

		for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
		{
			// Board edges are not considered in the relevant occupancies
			edges = ((Rank1BB | Rank8BB) & ~GlobalMembersBitboard.rank_bb(s)) | ((FileABB | FileHBB) & ~GlobalMembersBitboard.file_bb(s));

			// Given a square 's', the mask is the bitboard of sliding attacks from
			// 's' computed on an empty board. The index must be big enough to contain
			// all the attacks for each possible subset of the mask and so is 2 power
			// the number of 1s of the mask. Hence we deduce the size of the shift to
			// apply to the 64 or 32 bits word to get the index.
			masks[(int)s] = GlobalMembersBitboard.sliding_attack(deltas, s, 0) & ~edges;
			shifts[(int)s] = (GlobalMembersTypes.Is64Bit ? 64 : 32) - GlobalMembersTbprobe.popcount<Max15>(masks[(int)s]);

			// Use Carry-Rippler trick to enumerate all subsets of masks[s] and
			// store the corresponding sliding attack bitboard in reference[].
			b = size = 0;
			do
			{
				occupancy[size] = b;
				reference[size] = GlobalMembersBitboard.sliding_attack(deltas, s, b);

				if (GlobalMembersTypes.HasPext)
				{
					attacks[(int)s][pext(b, masks[(int)s])] = reference[size];
				}

				size++;
				b = (b - masks[(int)s]) & masks[(int)s];
			} while (b);

			// Set the offset for the table of the next square. We have individual
			// table sizes for each square with "Fancy Magic Bitboards".
			if (s < Square.SQ_H8)
			{
				attacks[(int)s + 1] = attacks[(int)s] + size;
			}

			if (GlobalMembersTypes.HasPext)
				continue;

			PRNG rng = new PRNG(seeds[GlobalMembersTypes.Is64Bit, (int)GlobalMembersTypes.rank_of(s)]);

			// Find a magic for square 's' picking up an (almost) random number
			// until we find the one that passes the verification test.
			do
			{
				do
				{
					magics[(int)s] = rng.sparse_rand<uint long>();
				} while (GlobalMembersTbprobe.popcount<Max15>((magics[(int)s] * masks[(int)s]) >> 56) < 6);

				std.memset(attacks[(int)s], 0, size * sizeof(uint long));

				// A good magic must map every possible occupancy to an index that
				// looks up the correct sliding attack in the attacks[s] database.
				// Note that we build up the database for square 's' as a side
				// effect of verifying the magic.
				for (i = 0; i < size; ++i)
				{
					uint long & attack = attacks[(int)s][index(s, occupancy[i])];

					if (attack && attack != reference[i])
						break;

					Debug.Assert(reference[i]);

					attack = reference[i];
				}
			} while (i < size);
		}
	  }

	  // bsf_index() returns the index into BSFTable[] to look up the bitscan. Uses
	  // Matt Taylor's folding for 32 bit case, extended to 64 bit by Kim Walisch.

	  public static FORCE_INLINE uint bsf_index(uint long b)
	  {
		b ^= b - 1;
		return GlobalMembersTypes.Is64Bit ? (b * DeBruijn64) >> 58 : (((uint)b ^ (uint)(b >> 32)) * DeBruijn32) >> 26;
	  }

	#if ! USE_BSFQ

	/// Software fall-back of lsb() and msb() for CPU lacking hardware support

	public static Square lsb(uint long b)
	{
	  return BSFTable[GlobalMembersBitboard.bsf_index(b)];
	}

	public static Square msb(uint long b)
	{

	  uint b32;
	  int result = 0;

	  if (b > 0xFFFFFFFF)
	  {
		  b >>= 32;
		  result = 32;
	  }

	  b32 = (uint)b;

	  if (b32 > 0xFFFF)
	  {
		  b32 >>= 16;
		  result += 16;
	  }

	  if (b32 > 0xFF)
	  {
		  b32 >>= 8;
		  result += 8;
	  }

	  return Square(result + MS1BTable[b32]);
	}
	#endif

	  public static uint long sliding_attack(Square[] deltas, Square sq, uint long occupied)
	  {

		uint long attack = 0;

		for (int i = 0; i < 4; ++i)
		{
			for (Square s = sq + deltas[i]; GlobalMembersTypes.is_ok(s) && GlobalMembersBitboard.distance(s, s - deltas[i]) == 1; s += deltas[i])
			{
				attack |= s;

				if ((occupied & (int)s) != 0)
					break;
			}
		}

		return attack;
	  }
}

//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace



/// Bitboards::pretty() returns an ASCII representation of a bitboard suitable
/// to be printed to standard output. Useful for debugging.



/// Bitboards::init() initializes various bitboard tables. It is called at
/// startup and relies on global objects to be already zero-initialized.



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace
