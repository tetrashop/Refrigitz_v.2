/*
  Stockfish, a UCI chess playing engine derived from Glaurung 2.1
  Copyright (C) 2004-2008 Tord Romstad (Glaurung author)
  Copyright (C) 2008-2015 Marco Costalba, Joona Kiiski, Tord Romstad
  Copyright (C) 2015-2016 Marco Costalba, Joona Kiiski, Gary Linscott, Tord Romstad

  Stockfish is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  Stockfish is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#include <iostream>
#include <sstream>
#include <string>
#include <fstream>
/*#include "evaluate.h"
#include "movegen.h"

#include "thread.h"
#include "timeman.h"*/
//#include "search.h"
#include "position.h"

#include "uci.h"

#include "stdafx.h"
//using namespace refri
using namespace std;


extern void benchmark(const Position& pos, istream& is);
//bool UCI::Option::BestMove;
namespace {
	
	//string MoveToFrom = "";
  // FEN string of the initial position, normal chess
  const char* StartFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

  // A list to keep track of the position states along the setup moves (from the
  // start position to the position just before the search starts). Needed by
  // 'draw by repetition' detection.
  //StateListPtr States(new std::deque<StateInfo>(1));


 /*
  void Write(string input)
  {
	  try{
		  std::ofstream out("output.txt");
		  try{

			  try{
				  out << input;

			  }
			  catch (exception t){}
			  try{
				  out.close();
			  }
			  catch (exception t){}
		  }
		  catch (exception t)
		  {
			  try{
				  out.close();
			  }
			  catch (exception t){}
			  return;
		  }
	  }
	  catch (exception t)
	  {
		  return;
	  }
	  //MoveToFrom = "";
  }*/
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

    States = StateListPtr(new std::deque<StateInfo>(1));
    pos.set(fen, Options["UCI_Chess960"], &States->back(), Threads.main());

    // Parse move list (if any)
    while (is >> token && (m = UCI::to_move(pos, token)) != MOVE_NONE)
    {
        States->push_back(StateInfo());
        pos.do_move(m, States->back(), pos.gives_check(m));
    }
  }


  // setoption() is called when engine receives the "setoption" UCI command. The
  // function updates the UCI option ("name") to the given value ("value").

  void setoption(istringstream& is) {

    string token, name, value;

    is >> token; // Consume "name" token

    // Read option name (can contain spaces)
    while (is >> token && token != "value")
        name += string(" ", name.empty() ? 0 : 1) + token;

    // Read option value (can contain spaces)
    while (is >> token)
        value += string(" ", value.empty() ? 0 : 1) + token;

    if (Options.count(name))
        Options[name] = value;
   // else
    //    sync_cout << "No such option: " << name << sync_endl;
  }


  // go() is called when engine receives the "go" UCI command. The function sets
  // the thinking time and other parameters from the input string, then starts
  // the search.

  void go(Position& pos, istringstream& is) {

	  //foreign code
    Search::LimitsType limits;
    string token;

   limits.startTime = now(); // As early as possible!

    while (is >> token)
        if (token == "searchmoves")
            while (is >> token)
                limits.searchmoves.push_back(UCI::to_move(pos, token));

        else if (token == "wtime")     is >> limits.time[WHITE];
        else if (token == "btime")     is >> limits.time[BLACK];
        else if (token == "winc")      is >> limits.inc[WHITE];
        else if (token == "binc")      is >> limits.inc[BLACK];
        else if (token == "movestogo") is >> limits.movestogo;
        else if (token == "depth")     is >> limits.depth;
        else if (token == "nodes")     is >> limits.nodes;
        else if (token == "movetime")  is >> limits.movetime;
        else if (token == "mate")      is >> limits.mate;
        else if (token == "infinite")  limits.infinite = 1;
        else if (token == "ponder")    limits.ponder = 1;

   // Threads.start_thinking(pos, States, limits);
  }

} // namespace


/// UCI::loop() waits for a command from stdin, parses it and calls the appropriate
/// function. Also intercepts EOF from stdin to ensure gracefully exiting if the
/// GUI dies unexpectedly. When called with some command line arguments, e.g. to
/// run 'bench', once the command is executed the function returns immediately.
/// In addition to the UCI ones, also some additional debug commands are supported.


void UCI::loop(int argc, char* argv*) {

  //Position pos;
  string token, cmd;

 // pos.set(StartFEN, false, &States->back(), Threads.main());

  for (int i = 1; i < argc; ++i)
      cmd += std::string(argv[i]) + " ";

  do {
	  if (argc == 1 && !getline(cin, cmd)) // Block here waiting for input or EOF
		  cmd = "quit";

	  istringstream is(cmd);

	  token.clear(); // getline() could return empty or blank line
	  is >> skipws >> token;

	  // The GUI sends 'ponderhit' to tell us to ponder on the same move the
	  // opponent has played. In case Signals.stopOnPonderhit is set we are
	  // waiting for 'ponderhit' to stop the search (for instance because we
	  // already ran out of time), otherwise we should continue searching but
	  // switching from pondering to normal search.
	  if (token == "quit"
		  || token == "stop"
		  || (token == "ponderhit" && AllDraw::stopOnPonderhit)
		  )
	  {
		  AllDraw::EndOfGame = true;
		  //Search::Signals.stop = true;
		 //Threads.main()->start_searching(true); // Could be sleeping
	  }
	  else if (token == "ponderhit")
	  {
		  AllDraw::EndOfGame = false; // Switch to normal search
		  int a = 1;
		  if (Draw.OrderP == -1)
		  {
			  a = -1;
			  Order = -1;
		  }
		  Draw.TableList.clear();
		  Table = {
			  { -4, -1, 0, 0, 0, 0, 1, 4 },
			  { -3, -1, 0, 0, 0, 0, 1, 3 },
			  { -2, -1, 0, 0, 0, 0, 1, 2 },
			  { -5, -1, 0, 0, 0, 0, 1, 5 },
			  { -6, -1, 0, 0, 0, 0, 1, 6 },
			  { -2, -1, 0, 0, 0, 0, 1, 2 },
			  { -3, -1, 0, 0, 0, 0, 1, 3 },
			  { -4, -1, 0, 0, 0, 0, 1, 4 }
		  };
		  Draw.TableList.clear();
		  Draw.TableList.push_back(Table);
		  Draw.SetRowColumn(0);
		  Table = Draw.Initiate(0, 0, a, Table, Order, false, false, 0, false);

	  }

      else if (token == "uci")
          cout << "id name " << engine_info(true)
                    << "\n"       << Options
                    << "\nuciok"  << endl;

      else if (token == "ucinewgame")
      {
		  Table = {
			  { -4, -1, 0, 0, 0, 0, 1, 4 },
			  { -3, -1, 0, 0, 0, 0, 1, 3 },
			  { -2, -1, 0, 0, 0, 0, 1, 2 },
			  { -5, -1, 0, 0, 0, 0, 1, 5 },
			  { -6, -1, 0, 0, 0, 0, 1, 6 },
			  { -2, -1, 0, 0, 0, 0, 1, 2 },
			  { -3, -1, 0, 0, 0, 0, 1, 3 },
			  { -4, -1, 0, 0, 0, 0, 1, 4 }
		  };
		  Order = 1;
		  AllDraw::EndOfGame = false; // Switch to normal search
		  int a = 1;
		  if (Draw.OrderP == -1)
		  {
			  Order = -1;
			  a = -1;
		  }
		  Draw.TableList.clear();
		  Draw.TableList.push_back(Table);
		  Draw.SetRowColumn(0);
		 

		  //Search::clear();
          //Time.availableNodes = 0;
      }
      else if (token == "isready")    cout << "readyok" << endl;
	  else if (token == "go")         //go(pos, is);
	  {
		  Table = Draw.Initiate(0, 0, a, Table, Order, false, false, 0, false);
	  }
      else if (token == "position")   position(pos, is);
      else if (token == "setoption")  setoption(is);

      // Additional custom non-UCI commands, useful for debugging
      else if (token == "flip")       pos.flip();
	  //else if (token == "wr")         Write(MoveToFrom);
      else if (token == "bench")      benchmark(pos, is);
      else if (token == "d")          sync_cout << pos << sync_endl;
      else if (token == "eval")       sync_cout << Eval::trace(pos) << sync_endl;
      else if (token == "perft")
      {
          int depth;
          stringstream ss;

          is >> depth;
          ss << Options["Hash"]    << " "
             << Options["Threads"] << " " << depth << " current perft";

          benchmark(pos, ss);
      }
      else
          sync_cout << "Unknown command: " << cmd << sync_endl;

  } while (token != "quit" && argc == 1); // Passed args have one-shot behaviour

  //Threads.main()->wait_for_search_finished();
}


/// UCI::value() converts a Value to a string suitable for use with the UCI
/// protocol specification:
///
/// cp <x>    The score from the engine's point of view in centipawns.
/// mate <y>  Mate in y moves, not plies. If the engine is getting mated
///           use negative values for y.

string UCI::value(Value v) {

  stringstream ss;

  if (abs(v) < VALUE_MATE - MAX_PLY)
      ss << "cp " << v * 100 / PawnValueEg;
  else
      ss << "mate " << (v > 0 ? VALUE_MATE - v + 1 : -VALUE_MATE - v) / 2;

  return ss.str();
}


/// UCI::square() converts a Square to a string in algebraic notation (g1, a7, etc.)

std::string UCI::square(Square s) {
  return std::string{ char('a' + file_of(s)), char('1' + rank_of(s)) };
}


/// UCI::move() converts a Move to a string in coordinate notation (g1f3, a7a8q).
/// The only special case is castling, where we print in the e1g1 notation in
/// normal chess mode, and in e1h1 notation in chess960 mode. Internally all
/// castling moves are always encoded as 'king captures rook'.

string UCI::move(Move m, bool chess960) {

  Square from = from_sq(m);
  Square to = to_sq(m);

  if (m == MOVE_NONE)
      return "(none)";

  if (m == MOVE_NULL)
      return "0000";

  if (type_of(m) == CASTLING && !chess960)
      to = make_square(to > from ? FILE_G : FILE_C, rank_of(from));

  string move = UCI::square(from) + UCI::square(to);
  if (type_of(m) == PROMOTION)
      move += " pnbrqk"[promotion_type(m)];

  //if (UCI::Option::BestMove)
	  //MoveToFrom = move;
  return move;
}


/// UCI::to_move() converts a string representing a move in coordinate notation
/// (g1f3, a7a8q) to the corresponding legal Move, if any.

Move UCI::to_move(const Position& pos, string& str) {

  if (str.length() == 5) // Junior could send promotion piece in uppercase
      str[4] = char(tolower(str[4]));

  for (const //auto& m : MoveList<LEGAL>(pos))
      if (str == UCI::move(m, pos.is_chess960()))
          return m;

  return MOVE_NONE;
}
