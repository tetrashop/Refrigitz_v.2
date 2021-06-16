/*
# Sugar, a UCI chess playing engine derived from Stockfish
# Copyright (C) 2008-2014 Marco Costalba, Joona Kiiski, Tord Romstad
# Sugar is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# Sugar is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#include <iomanip>
#include <iostream>
#include <sstream>
#include <string>

#include "evaluate.h"
#include "notation.h"
#include "position.h"
#include "search.h"
#include "thread.h"
#include "tt.h"
#include "ucioption.h"

bool UCI::Option::BestMoveB;
std::string UCI::Option::MoveToFromB;

using namespace std;

extern void bench(const Position& pos, istream& is);

namespace {

	
  // FEN string of the initial position, normal chess
  const char* StartFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

  // Keep a track of the position keys along the setup moves (from the start position
  // to the position just before the search starts). This is needed by the repetition
  // draw detection code.
  Search::StateStackPtr SetupStates;


  // position() is called when engine receives the "position" UCI command.
  // The function sets up the position described in the given FEN string ("fen")
  // or the starting position ("startpos") and then makes the moves given in the
  // following move list ("moves").

  void position(Position& pos, istringstream& is) {

    Move m;
    string token, fen;

    is >> token;

    if (token == "startpos")
    {
        fen = StartFEN;
        is >> token; // Consume "moves" token if any
    }
    else if (token == "fen")
        while (is >> token && token != "moves")
            fen += token + " ";
    else
        return;

    pos.set(fen, Options["UCI_Chess960"], Threads.main());
    SetupStates = Search::StateStackPtr(new std::stack<StateInfo>());

    // Parse move list (if any)
    while (is >> token && (m = move_from_uci(pos, token)) != MOVE_NONE)
    {
        SetupStates->push(StateInfo());
        pos.do_move(m, SetupStates->top());
    }
  }


  // setoption() is called when engine receives the "setoption" UCI command. The
  // function updates the UCI option ("name") to the given value ("value").

  void setoption(istringstream& is) {

    string token, name, value;

    is >> token; // Consume "name" token

    // Read option name (can contain spaces)
    while (is >> token && token != "value")
        name += string(" ", !name.empty()) + token;

    // Read option value (can contain spaces)
    while (is >> token)
        value += string(" ", !value.empty()) + token;

    if (Options.count(name))
        Options[name] = value;
    else
        sync_cout << "No such option: " << name << sync_endl;
  }


  // go() is called when engine receives the "go" UCI command. The function sets
  // the thinking time and other parameters from the input string, and starts
  // the search.

  void go(const Position& pos, istringstream& is) {

    Search::LimitsType limits;
    string token;

    while (is >> token)
    {
        if (token == "searchmoves")
            while (is >> token)
                limits.searchmoves.push_back(move_from_uci(pos, token));

        else if (token == "wtime")     is >> limits.time[WHITE];
        else if (token == "btime")     is >> limits.time[BLACK];
        else if (token == "winc")      is >> limits.inc[WHITE];
        else if (token == "binc")      is >> limits.inc[BLACK];
        else if (token == "movestogo") is >> limits.movestogo;
        else if (token == "depth")     is >> limits.depth;
        else if (token == "nodes")     is >> limits.nodes;
        else if (token == "movetime")  is >> limits.movetime;
        else if (token == "mate")      is >> limits.mate;
        else if (token == "infinite")  limits.infinite = true;
        else if (token == "ponder")    limits.ponder = true;
    }

    Threads.start_thinking(pos, limits, SetupStates);
  }

} 
std::string square(Square s) {
	return std::string{ char('a' + file_of(s)), char('1' + rank_of(s)) };
}// namespace
string move(Move m, bool chess960) {

	Square from = from_sq(m);
	Square to = to_sq(m);

	if (m == MOVE_NONE)
		return "(none)";

	if (m == MOVE_NULL)
		return "0000";

	if (type_of(m) == CASTLING && !chess960)
		to = make_square(to > from ? FILE_G : FILE_C, rank_of(from));

	string move = square(from) + square(to);
	if (type_of(m) == PROMOTION)
		move += " pnbrqk"[promotion_type(m)];

	if (UCI::Option::BestMoveB)
		UCI::Option::MoveToFromB = move;
	return move;
}

void Write(string input)
{
	try {
		std::ofstream out("output.txt");
		try {

			try {
				out << input;

			}
			catch (exception t) {}
			try {
				out.close();
			}
			catch (exception t) {}
		}
		catch (exception t)
		{
			try {
				out.close();
			}
			catch (exception t) {}
			return;
		}
	}
	catch (exception t)
	{
		return;
	}
	//MoveToFrom = "";
}
/// Wait for a command from the user, parse this text string as an UCI command,
/// and call the appropriate functions. Also intercepts EOF from stdin to ensure
/// that we exit gracefully if the GUI dies unexpectedly. In addition to the UCI
/// commands, the function also supports a few debug commands.

void UCI::loop(int argc, char* argv[]) {

  Position pos(StartFEN, false, Threads.main()); // The root position
  string token, cmd;

  for (int i = 1; i < argc; ++i)
      cmd += std::string(argv[i]) + " ";

  do {
      if (argc == 1 && !getline(cin, cmd)) // Block here waiting for input
          cmd = "quit";

      istringstream is(cmd);

      is >> skipws >> token;

      if (token == "quit" || token == "stop" || token == "ponderhit")
      {
          // The GUI sends 'ponderhit' to tell us to ponder on the same move the
          // opponent has played. In case Signals.stopOnPonderhit is set we are
          // waiting for 'ponderhit' to stop the search (for instance because we
          // already ran out of time), otherwise we should continue searching but
          // switch from pondering to normal search.
          if (token != "ponderhit" || Search::Signals.stopOnPonderhit)
          {
              Search::Signals.stop = true;
              Threads.main()->notify_one(); // Could be sleeping
          }
          else
              Search::Limits.ponder = false;
      }
      else if (token == "perft")
      {
          int depth;
          stringstream ss;

          is >> depth;
          ss << Options["Hash"]    << " "
             << Options["Threads"] << " " << depth << " current " << token;

          bench(pos, ss);
      }
      else if (token == "key")
          sync_cout << hex << uppercase << setfill('0')
                    << "position key: "   << setw(16) << pos.key()
                    << "\nmaterial key: " << setw(16) << pos.material_key()
                    << "\npawn key:     " << setw(16) << pos.pawn_key()
                    << dec << nouppercase << setfill(' ') << sync_endl;

      else if (token == "uci")
          sync_cout << "id name " << engine_info(true)
                    << "\n"       << Options
                    << "\nuciok"  << sync_endl;

      else if (token == "eval")
      {
          sync_cout << Eval::trace(pos) << sync_endl;
      }
      else if (token == "ucinewgame") TT.clear();
      else if (token == "go")         go(pos, is);
      else if (token == "position")   position(pos, is);
      else if (token == "setoption")  setoption(is);
      else if (token == "flip")       pos.flip();
	  else if (token == "wr")         Write(UCI::Option::MoveToFromB);
      else if (token == "bench")      bench(pos, is);
      else if (token == "d")          sync_cout << pos.pretty() << sync_endl;
      else if (token == "isready")    sync_cout << "readyok" << sync_endl;
      else if (token == "eval")       sync_cout << Eval::trace(pos) << sync_endl;
      else
          sync_cout << "Unknown command: " << cmd << sync_endl;

  } while (token != "quit" && argc == 1); // Passed args have one-shot behaviour

  Threads.wait_for_think_finished(); // Cannot quit whilst the search is running
}
