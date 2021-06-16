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

#include <algorithm>
#include <cassert>
#include <cstdlib>
#include <sstream>

#include "evaluate.h"
#include "misc.h"
#include "thread.h"
#include "tt.h"
#include "ucioption.h"
#include "tb_syzygy.h"

using std::string;
static bool BestMove;
static string MoveToFrom;
UCI::OptionsMap Options; // Global object

namespace UCI {

/// 'On change' actions, triggered by an option's value change
void on_logger(const Option& o) { start_logger(o); }
void on_eval(const Option&) { Eval::init(); }
void on_threads(const Option&) { Threads.read_uci_options(); }
void on_hash_size(const Option& o) { TT.set_size2(o); }
void on_clear_hash(const Option&) { TT.clear(); }
void on_tb_path(const Option& o) { Tablebases::init(o); }


/// Our case insensitive less() function as required by UCI protocol
bool ci_less(char c1, char c2) { return tolower(c1) < tolower(c2); }

bool CaseInsensitiveLess::operator() (const string& s1, const string& s2) const {
  return std::lexicographical_compare(s1.begin(), s1.end(), s2.begin(), s2.end(), ci_less);
}


/// init() initializes the UCI options to their hard-coded default values

void init(OptionsMap& o) {

  o["Write Debug Log"]       << Option(false, on_logger);
  o["Write Search Log"]         << Option(false);
  o["Search Log Filename"]      << Option("SearchLog.txt");
  o["Set_Path Book File"]    << Option("book.bin");
  o["Book Best Lines Move"]  << Option(false);
  o["MasterBook"]              << Option(false);
  o["Threads"]                 << Option(1, 1, MAX_THREADS, on_threads);
  o["Min Split Depth"]         << Option(0, 0, 12, on_threads);
  o["Contempt value"]          << Option(10, -100,  100);
  o["Ponder"]                  << Option(true);
  o["MultiPV"]                 << Option(1, 1, 500);
  o["Skill Level"]             << Option(20, 0, 20);
  o["Shift Overhead"]          << Option(35, 0, 5000);
  o["Minimum Reflection Time"] << Option(25, 0, 5000);
  o["Value Move Slow"]         << Option(85, 10, 1000);
  o["UCI_Chess960"]            << Option(false);
  o["Hash"]                    << Option(16, 1, 1024 * 1024, on_hash_size);
  o["Clear Hash"]              << Option(on_clear_hash);
  o["LP Enabled"]              << Option(true);  
  o["SyzygyPath"]              << Option("<empty>", on_tb_path);
  o["SyzygyProbeDepth"]        << Option(1, 1, 100);
  o["Syzygy50MoveRule"]        << Option(true);
  o["SyzygyProbeLimit"]        << Option(6, 0, 6);
  o["good_bishop_mg"]           << Option(100, 0, 200, on_eval);
  o["good_bishop_eg"]           << Option(110, 0, 200, on_eval);
  o["bishop_pawn_mg"]           << Option(100, 0, 200, on_eval);
  o["bishop_pawn_eg"]           << Option(110, 0, 200, on_eval);
  o["unstoppable_mg"]           << Option(100,-15, 200, on_eval);
  o["unstoppable_eg"]           << Option(100, 0, 200, on_eval);
  o["knightspan_mg"]            << Option(110,-15, 200, on_eval);
  o["knightspan_eg"]            << Option(100, 0, 200, on_eval);
  o["r2_mg"]                    << Option(0 , -25, 25);
  o["r2_eg"]                    << Option(0 , -25, 25);
  o["r3_mg"]                    << Option(0 , -25, 25);
  o["r3_eg"]                    << Option(0 , -25, 25);
  o["r4_mg"]                    << Option(0 , -25, 25);
  o["r4_eg"]                    << Option(0 , -25, 25);
  o["r5_mg"]                    << Option(21, 0  , 50);
  o["r5_eg"]                    << Option(20, 0  , 50);
  o["r6_mg"]                    << Option(42, 0  , 100);
  o["r6_eg"]                    << Option(40, 0  , 100);
  o["r7_mg"]                    << Option(0 , 0 , 100);
  o["r7_eg"]                    << Option(0 , 0 , 100);
}


/// operator<<() is used to print all the options default values in chronological
/// insertion order (the idx field) and in the format defined by the UCI protocol.

std::ostream& operator<<(std::ostream& os, const OptionsMap& om) {

  for (size_t idx = 0; idx < om.size(); ++idx)
      for (OptionsMap::const_iterator it = om.begin(); it != om.end(); ++it)
          if (it->second.idx == idx)
          {
              const Option& o = it->second;
              os << "\noption name " << it->first << " type " << o.type;

              if (o.type != "button")
                  os << " default " << o.defaultValue;

              if (o.type == "spin")
                  os << " min " << o.min << " max " << o.max;

              break;
          }
  return os;
}


/// Option class constructors and conversion operators

Option::Option(const char* v, OnChange f) : type("string"), min(0), max(0), on_change(f)
{ defaultValue = currentValue = v; }

Option::Option(bool v, OnChange f) : type("check"), min(0), max(0), on_change(f)
{ defaultValue = currentValue = (v ? "true" : "false"); }

Option::Option(OnChange f) : type("button"), min(0), max(0), on_change(f)
{}

Option::Option(int v, int minv, int maxv, OnChange f) : type("spin"), min(minv), max(maxv), on_change(f)
{ std::ostringstream ss; ss << v; defaultValue = currentValue = ss.str(); }


Option::operator int() const {
  assert(type == "check" || type == "spin");
  return (type == "spin" ? atoi(currentValue.c_str()) : currentValue == "true");
}

Option::operator std::string() const {
  assert(type == "string");
  return currentValue;
}


/// operator<<() inits options and assigns idx in the correct printing order

void Option::operator<<(const Option& o) {

  static size_t insert_order = 0;

  *this = o;
  idx = insert_order++;
}

/// operator=() updates currentValue and triggers on_change() action. It's up to
/// the GUI to check for option's limits, but we could receive the new value from
/// the user by console window, so let's check the bounds anyway.

Option& Option::operator=(const string& v) {

  assert(!type.empty());

  if (   (type != "button" && v.empty())
      || (type == "check" && v != "true" && v != "false")
      || (type == "spin" && (atoi(v.c_str()) < min || atoi(v.c_str()) > max)))
      return *this;

  if (type != "button")
      currentValue = v;

  if (on_change)
      on_change(*this);

  return *this;
}

} // namespace UCI
