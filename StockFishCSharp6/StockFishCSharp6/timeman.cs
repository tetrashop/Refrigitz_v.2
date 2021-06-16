﻿using System;

public static class GlobalMembersTimeman
{

	  public const int MoveHorizon = 50; // Plan time management at most this many moves ahead
	  public const double MaxRatio = 7.0; // When in trouble, we can step over reserved time with this ratio
	  public const double StealRatio = 0.33; // However we must not steal time from remaining moves over this ratio


	  // move_importance() is a skew-logistic function based on naive statistical
	  // analysis of "how many games are still undecided after n half-moves". Game
	  // is considered "undecided" as long as neither side has >275cp advantage.
	  // Data was extracted from CCRL game database with some simple filtering criteria.

	  public static double move_importance(int ply)
	  {

		const double XScale = 9.3;
		const double XShift = 59.8;
		const double Skew = 0.172;

		return Math.Pow((1 + Math.Exp((ply - XShift) / XScale)), -Skew) + DBL_MIN; // Ensure non-zero
	  }

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<TimeType T>
	  public static int remaining<TimeType T>(int myTime, int movesToGo, int ply, int slowMover)
	  {
		double TMaxRatio = (T == ((int)TimeType.OptimumTime) != 0 ? 1 : MaxRatio);
		double TStealRatio = (T == ((int)TimeType.OptimumTime) != 0 ? 0 : StealRatio);

		double moveImportance = (GlobalMembersTimeman.move_importance(ply) * slowMover) / 100;
		double otherMovesImportance = 0;

		for (int i = 1; i < movesToGo; ++i)
		{
			otherMovesImportance += GlobalMembersTimeman.move_importance(ply + 2 * i);
		}

		double ratio1 = (TMaxRatio * moveImportance) / (TMaxRatio * moveImportance + otherMovesImportance);
		double ratio2 = (moveImportance + TStealRatio * otherMovesImportance) / (moveImportance + otherMovesImportance);

		return (int)(myTime * Math.Min(ratio1, ratio2)); // Intel C++ asks an explicit cast
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

  public enum TimeType
  {
	  OptimumTime,
	  MaxTime
  }



/// init() is called at the beginning of the search and calculates the allowed
/// thinking time out of the time control and current game ply. We support four
/// different kinds of time controls, passed in 'limits':
///
///  inc == 0 && movestogo == 0 means: x basetime  [sudden death!]
///  inc == 0 && movestogo != 0 means: x moves in y minutes
///  inc >  0 && movestogo == 0 means: x basetime + z increment
///  inc >  0 && movestogo != 0 means: x moves in y minutes + z increment

