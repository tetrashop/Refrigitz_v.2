using System.Diagnostics;

public static class GlobalMembersMovepick
{

	  // Our insertion sort, which is guaranteed (and also needed) to be stable
	  public static void insertion_sort(ExtMove begin, ExtMove end)
	  {
		ExtMove tmp = new ExtMove();
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
		ExtMove * p = new ExtMove();
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
		ExtMove * q = new ExtMove();

		for (p = begin + 1; p < end; ++p)
		{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: tmp = *p;
			tmp.CopyFrom(p);
			for (q = p; q != begin && *(q - 1) < tmp; --q)
			{
				*q = (q - 1);
			}
			*q = tmp;
		}
	  }

	  // Unary predicate used by std::partition to split positive values from remaining
	  // ones so as to sort the two sets separately, with the second sort delayed.
	  public static bool has_positive_value(ExtMove move)
	  {
		  return move.value > Value.VALUE_ZERO;
	  }

	  // Picks the best move in the range (begin, end) and moves it to the front.
	  // It's faster than sorting all the moves in advance when there are few
	  // moves e.g. possible captures.
	  public static ExtMove pick_best(ExtMove begin, ExtMove end)
	  {
		  std.swap(begin, *std.max_element(begin, end));
		  return begin;
	  }


	/// score() assign a numerical value to each move in a move list. The moves with
	/// highest values will be picked first.
	public static void MovePicker.score()
	{
	  // Winning and equal captures in the main search are ordered by MVV/LVA.
	  // Suprisingly, this appears to perform slightly better than SEE based
	  // move ordering. The reason is probably that in a position with a winning
	  // capture, capturing a more valuable (but sufficiently defended) piece
	  // first usually doesn't hurt. The opponent will have to recapture, and
	  // the hanging piece will still be hanging (except in the unusual cases
	  // where it is possible to recapture with the hanging piece). Exchanging
	  // big pieces before capturing a hanging piece probably helps to reduce
	  // the subtree size.
	  // In main search we want to push captures with negative SEE values to the
	  // badCaptures[] array, but instead of doing it now we delay until the move
	  // has been picked up in pick_move_from_list(). This way we save some SEE
	  // calls in case we get a cutoff.
	  Move m;

	  for (ExtMove * it = moves; it != end; ++it)
	  {
		  m = it.move;
		  it.value = GlobalMembersPosition.PieceValue[(int)Phase.MG, pos.piece_on(GlobalMembersTypes.to_sq(m))] - Value(GlobalMembersTypes.type_of(pos.moved_piece(m)));

		  if (GlobalMembersTypes.type_of(m) == MoveType.ENPASSANT)
		  {
			  it.value += GlobalMembersPosition.PieceValue[(int)Phase.MG, (int)PieceType.PAWN];
		  }

		  else if (GlobalMembersTypes.type_of(m) == MoveType.PROMOTION)
		  {
			  it.value += GlobalMembersPosition.PieceValue[(int)Phase.MG, (int)GlobalMembersTypes.promotion_type(m)] - GlobalMembersPosition.PieceValue[(int)Phase.MG, (int)PieceType.PAWN];
		  }
	  }
	}

	public static void MovePicker.score()
	{

	  Move m;

	  for (ExtMove * it = moves; it != end; ++it)
	  {
		  m = it.move;
		  it.value = history[pos.moved_piece(m)][(int)GlobalMembersTypes.to_sq(m)];
	  }
	}

	public static void MovePicker.score()
	{
	  // Try good captures ordered by MVV/LVA, then non-captures if destination square
	  // is not under attack, ordered by history value, then bad-captures and quiet
	  // moves with a negative SEE. This last group is ordered by the SEE value.
	  Move m;
	  Value see;

	  for (ExtMove * it = moves; it != end; ++it)
	  {
		  m = it.move;
		  if ((see = pos.see_sign(m)) < Value.VALUE_ZERO)
		  {
			  it.value = see - Stats<false, Value>.Max; // At the bottom
		  }

		  else if (pos.capture(m))
		  {
			  it.value = GlobalMembersPosition.PieceValue[(int)Phase.MG, pos.piece_on(GlobalMembersTypes.to_sq(m))] - Value(GlobalMembersTypes.type_of(pos.moved_piece(m))) + Stats<false, Value>.Max;
		  }
		  else
		  {
			  it.value = history[pos.moved_piece(m)][(int)GlobalMembersTypes.to_sq(m)];
		  }
	  }
	}


	/// next_move() is the most important method of the MovePicker class. It returns
	/// a new pseudo legal move every time it is called, until there are no more moves
	/// left. It picks the move with the biggest value from a list of generated moves
	/// taking care not to return the ttMove if it has already been searched.
	public static Move MovePicker.next_move()
	{

	  Move move;

	  while (true)
	  {
		  while (cur == end)
		  {
			  generate_next_stage();
		  }

		  switch (stage)
		  {

		  case Stages.MAIN_SEARCH:
	  case Stages.EVASION:
	case Stages.QSEARCH_0:
	case Stages.QSEARCH_1:
	case Stages.PROBCUT:
			  ++cur;
			  return ttMove;

		  case Stages.CAPTURES_S1:
			  move = GlobalMembersMovepick.pick_best(cur++, end).move;
			  if (move != ttMove)
			  {
				  if (pos.see_sign(move) >= Value.VALUE_ZERO)
				  {
					  return move;
				  }

				  // Losing capture, move it to the tail of the array
				  (endBadCaptures--).move = move;
			  }
			  break;

		  case Stages.KILLERS_S1:
			  move = (cur++).move;
			  if (move != Move.MOVE_NONE && move != ttMove && pos.pseudo_legal(move) && !pos.capture(move))
			  {
				  return move;
			  }
			  break;

		  case Stages.QUIETS_1_S1:
	  case Stages.QUIETS_2_S1:
			  move = (cur++).move;
			  if (move != ttMove && move != killers[0].move && move != killers[1].move && move != killers[2].move && move != killers[3].move && move != killers[4].move && move != killers[5].move)
			  {
				  return move;
			  }
			  break;

		  case Stages.BAD_CAPTURES_S1:
			  return (cur--).move;

		  case Stages.EVASIONS_S2:
	  case Stages.CAPTURES_S3:
	case Stages.CAPTURES_S4:
			  move = GlobalMembersMovepick.pick_best(cur++, end).move;
			  if (move != ttMove)
			  {
				  return move;
			  }
			  break;

		  case Stages.CAPTURES_S5:
			   move = GlobalMembersMovepick.pick_best(cur++, end).move;
			   if (move != ttMove && pos.see(move) > captureThreshold)
			   {
				   return move;
			   }
			   break;

		  case Stages.CAPTURES_S6:
			  move = GlobalMembersMovepick.pick_best(cur++, end).move;
			  if (GlobalMembersTypes.to_sq(move) == recaptureSquare)
			  {
				  return move;
			  }
			  break;

		  case Stages.QUIET_CHECKS_S3:
			  move = (cur++).move;
			  if (move != ttMove)
			  {
				  return move;
			  }
			  break;

		  case Stages.STOP:
			  return Move.MOVE_NONE;

		  default:
			  Debug.Assert(false);
		  break;
		  }
	  }
	}


	/// Version of next_move() to use at split point nodes where the move is grabbed
	/// from the split point's shared MovePicker object. This function is not thread
	/// safe so must be lock protected by the caller.
	public static Move MovePicker.next_move()
	{
		return ss.splitPoint.movePicker.next_move<false>();
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

  public enum Stages
  {
	MAIN_SEARCH,
	CAPTURES_S1,
	KILLERS_S1,
	QUIETS_1_S1,
	QUIETS_2_S1,
	BAD_CAPTURES_S1,
	EVASION,
	EVASIONS_S2,
	QSEARCH_0,
	CAPTURES_S3,
	QUIET_CHECKS_S3,
	QSEARCH_1,
	CAPTURES_S4,
	PROBCUT,
	CAPTURES_S5,
	RECAPTURE,
	CAPTURES_S6,
	STOP
  }


/// Constructors of the MovePicker class. As arguments we pass information
/// to help it to return the (presumably) good moves first, to decide which
/// moves to return (in the quiescence search, for instance, we only want to
/// search captures, promotions and some checks) and how important good move
/// ordering is at the current node.





/// generate_next_stage() generates, scores and sorts the next bunch of moves,
/// when there are no more moves to try for the current stage.

