using System.Collections.Generic;
using System;

public static class GlobalMembersUci
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




	//void benchmark(Position pos, istream @is);

	  // FEN string of the initial position, normal chess
	  public static string StartFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

	  // Stack to keep track of the position states along the setup moves (from the
	  // start position to the position just before the search starts). Needed by
	  // 'draw by repetition' detection.
	#if StateStackPtr_ConditionalDefinition1
	  public static std.auto_ptr<Stack<StateInfo>> SetupStates = new std.auto_ptr<Stack<StateInfo>>();
	#elif StateStackPtr_ConditionalDefinition2
	  public static std.auto_ptr<Stack<StateInfo>> SetupStates = new std.auto_ptr<Stack<StateInfo>>();
	#else
	  public static Search.StateStackPtr SetupStates = new Search.StateStackPtr();
	#endif


	  // position() is called when engine receives the "position" UCI command.
	  // The function sets up the position described in the given FEN string ("fen")
	  // or the starting position ("startpos") and then makes the moves given in the
	  // following move list ("moves").

	  public static void position(Position pos, istringstream @is)
	  {

		Move m;
		string token;
		string fen;

		@is >> token;

		if (token == "startpos")
		{
			fen = ((char)StartFEN).ToString();
			@is >> token; // Consume "moves" token if any
		}
		else if (token == "fen")
		{
			while (@is >> token && token != "moves")
			{
				fen += token + " ";
			}
		}
		else
			return;

		pos.set(fen, GlobalMembersUcioption.Options["UCI_Chess960"], GlobalMembersThread.Threads.main());
	#if StateStackPtr_ConditionalDefinition1
		SetupStates = std.auto_ptr<Stack<StateInfo>>(new Stack<StateInfo>());
	#elif StateStackPtr_ConditionalDefinition2
		SetupStates = std.auto_ptr<Stack<StateInfo>>(new Stack<StateInfo>());
	#else
		SetupStates = Search.StateStackPtr(new Stack<StateInfo>());
	#endif

		// Parse move list (if any)
		while (@is >> token && (m = GlobalMembersUci.to_move(pos, token)) != Move.MOVE_NONE)
		{
			SetupStates.push(new StateInfo());
			pos.do_move(m, SetupStates.top());
		}
	  }


	  // setoption() is called when engine receives the "setoption" UCI command. The
	  // function updates the UCI option ("name") to the given value ("value").

	  public static void setoption(istringstream @is)
	  {

		string token;
		string name;
		string value;

		@is >> token; // Consume "name" token

		// Read option name (can contain spaces)
		while (@is >> token && token != "value")
		{
			name += (string)(" ", !string.IsNullOrEmpty(name)) + token;
		}

		// Read option value (can contain spaces)
		while (@is >> token)
		{
			value += (string)(" ", !string.IsNullOrEmpty(value)) + token;
		}

		if (GlobalMembersUcioption.Options.count(name))
		{
			GlobalMembersUcioption.Options[name] = value;
		}
		else
		{
			sync_cout << "No such option: " << name << sync_endl;
		}
	  }


	  // go() is called when engine receives the "go" UCI command. The function sets
	  // the thinking time and other parameters from the input string, then starts
	  // the search.

	  public static void go(Position pos, istringstream @is)
	  {

		Search.LimitsType limits = new Search.LimitsType();
		string token;

		while (@is >> token)
		{
			if (token == "searchmoves")
			{
				while (@is >> token)
				{
					limits.searchmoves.Add(GlobalMembersUci.to_move(pos, token));
				}
			}

			else if (token == "wtime")
			{
				@is >> limits.time[(int)Color.WHITE];
			}
			else if (token == "btime")
			{
				@is >> limits.time[(int)Color.BLACK];
			}
			else if (token == "winc")
			{
				@is >> limits.inc[(int)Color.WHITE];
			}
			else if (token == "binc")
			{
				@is >> limits.inc[(int)Color.BLACK];
			}
			else if (token == "movestogo")
			{
				@is >> limits.movestogo;
			}
			else if (token == "depth")
			{
				@is >> limits.depth;
			}
			else if (token == "nodes")
			{
				@is >> limits.nodes;
			}
			else if (token == "movetime")
			{
				@is >> limits.movetime;
			}
			else if (token == "mate")
			{
				@is >> limits.mate;
			}
			else if (token == "infinite")
			{
				limits.infinite = true;
			}
			else if (token == "ponder")
			{
				limits.ponder = true;
			}
		}

		GlobalMembersThread.Threads.start_thinking(pos, limits, SetupStates);
	  }
}

//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace



/// UCI::loop() waits for a command from stdin, parses it and calls the appropriate
/// function. Also intercepts EOF from stdin to ensure gracefully exiting if the
/// GUI dies unexpectedly. When called with some command line arguments, e.g. to
/// run 'bench', once the command is executed the function returns immediately.
/// In addition to the UCI ones, also some additional debug commands are supported.



/// UCI::value() converts a Value to a string suitable for use with the UCI
/// protocol specification:
///
/// cp <x>    The score from the engine's point of view in centipawns.
/// mate <y>  Mate in y moves, not plies. If the engine is getting mated
///           use negative values for y.



/// UCI::square() converts a Square to a string in algebraic notation (g1, a7, etc.)



/// UCI::move() converts a Move to a string in coordinate notation (g1f3, a7a8q).
/// The only special case is castling, where we print in the e1g1 notation in
/// normal chess mode, and in e1h1 notation in chess960 mode. Internally all
/// castling moves are always encoded as 'king captures rook'.



/// UCI::to_move() converts a string representing a move in coordinate notation
/// (g1f3, a7a8q) to the corresponding legal Move, if any.

