using System.Diagnostics;
using System;

public static class GlobalMembersPosition
{

	public static Value[,] PieceValue = {{Value.VALUE_ZERO, Value.PawnValueMg, Value.KnightValueMg, Value.BishopValueMg, Value.RookValueMg, Value.QueenValueMg}, {Value.VALUE_ZERO, Value.PawnValueEg, Value.KnightValueEg, Value.BishopValueEg, Value.RookValueEg, Value.QueenValueEg}};

	  public static uint[,,] long psq = new uint[(int)Color.COLOR_NB, PieceType.PIECE_TYPE_NB, (int)Square.SQUARE_NB];
	  public static uint[] long enpassant = new uint[(int)File.FILE_NB];
	  public static uint[] long castling = new uint[(int)CastlingRight.CASTLING_RIGHT_NB];
	  public static uint long side;
	  public static uint long exclusion;
	public static Score[,,] psq = new Score[(int)Color.COLOR_NB, PieceType.PIECE_TYPE_NB, (int)Square.SQUARE_NB];

	// min_attacker() is a helper function used by see() to locate the least
	// valuable attacker for the side to move, remove the attacker we just found
	// from the bitboards and scan for new X-ray attacks behind it.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<int Pt>
	public static FORCE_INLINE PieceType min_attacker<int Pt>(uint long[] bb, Square to, uint long stmAttackers, ref uint long occupied, ref uint long attackers)
	{

	  uint long b = stmAttackers & bb[Pt];
	  if (!b)
	  {
		  return GlobalMembersPosition.min_attacker < Pt + 1>(bb, to, stmAttackers, occupied, attackers);
	  }

	  occupied ^= b & ~(b - 1);

	  if (Pt == PieceType.PAWN || Pt == PieceType.BISHOP || Pt == PieceType.QUEEN)
	  {
		  attackers |= GlobalMembersBitboard.attacks_bb<PieceType.BISHOP>(to, occupied) & (bb[(int)PieceType.BISHOP] | bb[(int)PieceType.QUEEN]);
	  }

	  if (Pt == PieceType.ROOK || Pt == PieceType.QUEEN)
	  {
		  attackers |= GlobalMembersBitboard.attacks_bb<PieceType.ROOK>(to, occupied) & (bb[(int)PieceType.ROOK] | bb[(int)PieceType.QUEEN]);
	  }

	  attackers &= occupied; // After X-ray that may add already processed pieces
	  return (PieceType)Pt;
	}

	public static FORCE_INLINE PieceType min_attacker(uint long UnnamedParameter1, Square UnnamedParameter2, uint long, ref uint long, ref uint long)
	{
	  return PieceType.KING; // No need to update bitboards: it is the last cycle
	}


	/// operator<<(Position) returns an ASCII representation of the position

	public static std.ostream operator << (std.ostream os, Position pos)
	{

	  os << "\n +---+---+---+---+---+---+---+---+\n";

	  for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r)
	  {
		  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
		  {
			  os << " | " << PieceToChar[(int)pos.piece_on(GlobalMembersTypes.make_square(f, r))];
		  }

		  os << " |\n +---+---+---+---+---+---+---+---+\n";
	  }

	  os << "\nFen: " << pos.fen() << "\nKey: " << std.hex << std.uppercase << std.setfill('0') << std.setw(16) << pos.st.key << std.dec << "\nCheckers: ";

	  for (uint long b = pos.checkers(); b != null;)
	  {
		  os << GlobalMembersUci.square(GlobalMembersBitboard.pop_lsb(ref b)) << " ";
	  }

	  return os;
	}


	/// Position::operator=() creates a copy of 'pos' but detaching the state pointer
	/// from the source to be self-consistent and not depending on any external data.

//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: Position& Position::operator =(const Position& pos)
	public static Position Position.CopyFrom(Position pos)
	{

	  std.memcpy(this, pos, sizeof(Position));
	  startState = *st;
	  st = &startState;
	  nodes = 0;

	  Debug.Assert(pos_is_ok());

	  return this;
	}


	/// Position::flip() flips position with the white and black sides reversed. This
	/// is only useful for debugging e.g. for finding evaluation symmetry bugs.

	internal static sbyte toggle_case(sbyte c)
	{
	  return (sbyte)(char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c));
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


//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: uint long Position::exclusion_key() const

//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

//C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
const string PieceToChar(" PNBRQK  pnbrqk");



/// CheckInfo c'tor



/// Position::init() initializes at startup the various arrays used to compute
/// hash keys and the piece square tables. The latter is a two-step operation:
/// Firstly, the white halves of the tables are copied from PSQT[] tables.
/// Secondly, the black halves of the tables are initialized by flipping and
/// changing the sign of the white scores.



/// Position::clear() erases the position object to a pristine state, with an
/// empty board, white to move, and no castling rights.



/// Position::set() initializes the position object with the given FEN string.
/// This function is not very robust - make sure that input FENs are correct,
/// this is assumed to be the responsibility of the GUI.



/// Position::set_castling_right() is a helper function used to set castling
/// rights given the corresponding color and the rook starting square.



/// Position::set_state() computes the hash keys of the position, and other
/// data that once computed is updated incrementally as moves are made.
/// The function is only used when a new position is set up, and to verify
/// the correctness of the StateInfo data when running in debug mode.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: void Position::set_state(StateInfo* si) const


/// Position::fen() returns a FEN representation of the position. In case of
/// Chess960 the Shredder-FEN notation is used. This is mainly a debugging function.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: const string Position::fen() const


/// Position::game_phase() calculates the game phase interpolating total non-pawn
/// material between endgame and midgame limits.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Phase Position::game_phase() const


/// Position::check_blockers() returns a bitboard of all the pieces with color
/// 'c' that are blocking check on the king with color 'kingColor'. A piece
/// blocks a check if removing that piece from the board would result in a
/// position where the king is in check. A check blocking piece can be either a
/// pinned or a discovered check piece, according if its color 'c' is the same
/// or the opposite of 'kingColor'.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: uint long Position::check_blockers(Color c, Color kingColor) const


/// Position::attackers_to() computes a bitboard of all pieces which attack a
/// given square. Slider attacks use the occupied bitboard to indicate occupancy.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: uint long Position::attackers_to(Square s, uint long occupied) const


/// Position::legal() tests whether a pseudo-legal move is legal

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Position::legal(Move m, uint long pinned) const


/// Position::pseudo_legal() takes a random move and tests whether the move is
/// pseudo legal. It is used to validate moves from TT that can be corrupted
/// due to SMP concurrent access or hash position key aliasing.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Position::pseudo_legal(const Move m) const


/// Position::gives_check() tests whether a pseudo-legal move gives a check

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Position::gives_check(Move m, const CheckInfo& ci) const


/// Position::do_move() makes a move, and saves all information necessary
/// to a StateInfo object. The move is assumed to be legal. Pseudo-legal
/// moves should be filtered out before this function is called.




/// Position::undo_move() unmakes a move. When it returns, the position should
/// be restored to exactly the same state as before the move was made.



/// Position::do_castling() is a helper used to do/undo a castling move. This
/// is a bit tricky, especially in Chess960.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool Do>


/// Position::do(undo)_null_move() is used to do(undo) a "null move": It flips
/// the side to move without executing any move on the board.




/// Position::key_after() computes the new hash key after the given move. Needed
/// for speculative prefetch. It doesn't recognize special moves like castling,
/// en-passant and promotions.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: uint long Position::key_after(Move m) const


/// Position::see() is a static exchange evaluator: It tries to estimate the
/// material gain or loss resulting from a move.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Position::see_sign(Move m) const

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Position::see(Move m) const


/// Position::is_draw() tests whether the position is drawn by material, 50 moves
/// rule or repetition. It does not detect stalemates.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Position::is_draw() const



/// Position::pos_is_ok() performs some consistency checks for the position object.
/// This is meant to be helpful when debugging.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Position::pos_is_ok(int* step) const
