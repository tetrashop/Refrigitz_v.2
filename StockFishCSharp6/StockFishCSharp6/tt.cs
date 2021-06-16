using System.Diagnostics;

public static class GlobalMembersTt
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



	public static TranspositionTable TT = new TranspositionTable(); // Our global transposition table
}

/// TranspositionTable::resize() sets the size of the transposition table,
/// measured in megabytes. Transposition table consists of a power of 2 number
/// of clusters and each cluster consists of ClusterSize number of TTEntry.



/// TranspositionTable::clear() overwrites the entire transposition table
/// with zeros. It is called whenever the table is resized, or when the
/// user asks the program to clear the table (from the UCI interface).



/// TranspositionTable::probe() looks up the current position in the transposition
/// table. It returns true and a pointer to the TTEntry if the position is found.
/// Otherwise, it returns false and a pointer to an empty or least valuable TTEntry
/// to be replaced later. A TTEntry t1 is considered to be more valuable than a
/// TTEntry t2 if t1 is from the current search and t2 is from a previous search,
/// or if the depth of t1 is bigger than the depth of t2.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: TTEntry* TranspositionTable::probe(const uint long key, bool& found) const
