using System.Collections.Generic;
using System.Diagnostics;
using System;

public static class GlobalMembersUcioption
{

	public static SortedDictionary<string, Option, CaseInsensitiveLess> Options = new SortedDictionary<string, Option, CaseInsensitiveLess>(); // Global object

	/// 'On change' actions, triggered by an option's value change
	public static void on_clear_hash(Option UnnamedParameter1)
	{
		GlobalMembersTt.TT.clear();
	}
	public static void on_hash_size(Option o)
	{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: TT.resize(o);
		GlobalMembersTt.TT.resize(new UCI.Option(o));
	}
	public static void on_logger(Option o)
	{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: start_logger(o);
		GlobalMembersMisc.start_logger(new UCI.Option(o));
	}
	public static void on_threads(Option UnnamedParameter1)
	{
		GlobalMembersThread.Threads.read_uci_options();
	}
	public static void on_tb_path(Option o)
	{
		Tablebases.init(o);
	}


	/// Our case insensitive less() function as required by UCI protocol
	public static bool ci_less(sbyte c1, sbyte c2)
	{
		return char.ToLower(c1) < char.ToLower(c2);
	}

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool CaseInsensitiveLess::operator ()(const string& s1, const string& s2) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static bool CaseInsensitiveLess.operator ()(string s1, string s2)
	{
	  return std.lexicographical_compare(s1.GetEnumerator(), s1.end(), s2.GetEnumerator(), s2.end(), GlobalMembersUcioption.ci_less);
	}


	/// init() initializes the UCI options to their hard-coded default values

	public static void init(SortedDictionary<string, Option, CaseInsensitiveLess> o)
	{

	  int MaxHashMB = GlobalMembersTypes.Is64Bit ? 1024 * 1024 : 2048;

	  o["Write Debug Log"] << new Option(false, GlobalMembersUcioption.on_logger);
	  o["Contempt"] << new Option(0, -100, 100);
	  o["Min Split Depth"] << new Option(0, 0, 12, GlobalMembersUcioption.on_threads);
	  o["Threads"] << new Option(1, 1, GlobalMembersThread.MAX_THREADS, GlobalMembersUcioption.on_threads);
	  o["Hash"] << new Option(16, 1, MaxHashMB, GlobalMembersUcioption.on_hash_size);
	  o["Clear Hash"] << new Option(GlobalMembersUcioption.on_clear_hash);
	  o["Ponder"] << new Option(true);
	  o["MultiPV"] << new Option(1, 1, 500);
	  o["Skill Level"] << new Option(20, 0, 20);
	  o["Move Overhead"] << new Option(30, 0, 5000);
	  o["Minimum Thinking Time"] << new Option(20, 0, 5000);
	  o["Slow Mover"] << new Option(80, 10, 1000);
	  o["UCI_Chess960"] << new Option(false);
	  o["SyzygyPath"] << new Option("<empty>", GlobalMembersUcioption.on_tb_path);
	  o["SyzygyProbeDepth"] << new Option(1, 1, 100);
	  o["Syzygy50MoveRule"] << new Option(true);
	  o["SyzygyProbeLimit"] << new Option(6, 0, 6);
	}


	/// operator<<() is used to print all the options default values in chronological
	/// insertion order (the idx field) and in the format defined by the UCI protocol.

	public static std.ostream operator << (std.ostream os, SortedDictionary<string, Option, CaseInsensitiveLess> om)
	{

	  for (uint idx = 0; idx < om.Count; ++idx)
	  {
		  for (SortedDictionary<string, Option, CaseInsensitiveLess>.Enumerator it = om.GetEnumerator(); it.MoveNext();)
		  {
//C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
			  if (it.second.idx == idx)
			  {
//C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
				  Option o = it.second;
//C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
				  os << "\noption name " << it.first << " type " << o.type;

				  if (o.type != "button")
				  {
					  os << " default " << o.defaultValue;
				  }

				  if (o.type == "spin")
				  {
					  os << " min " << o.min << " max " << o.max;
				  }

				  break;
			  }
		  }
	  }
	  return os;
	}
//C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
private static uint operator << _insert_order = 0;


	/// operator<<() inits options and assigns idx in the correct printing order

	public static void Option.operator << (Option o)
	{

	//C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
	//  static uint insert_order = 0;

	  this = o;
	  idx = operator << _insert_order++;
	}


	/// operator=() updates currentValue and triggers on_change() action. It's up to
	/// the GUI to check for option's limits, but we could receive the new value from
	/// the user by console window, so let's check the bounds anyway.

//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: Option& Option::operator =(const string& v)
	public static Option Option.CopyFrom(string v)
	{

	  Debug.Assert(!ScaleFactor.empty());

	  if ((ScaleFactor != "button" && string.IsNullOrEmpty(v)) || (ScaleFactor == "check" && v != "true" && v != "false") || (ScaleFactor == "spin" && (Convert.ToInt32(v) < min || Convert.ToInt32(v) > max)))
	  {
		  return this;
	  }

	  if (ScaleFactor != "button")
	  {
		  currentValue = v;
	  }

	  if (on_change)
	  {
		  on_change(this);
	  }

	  return this;
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

namespace UCI
{


/// Option class constructors and conversion operators






//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Option::operator int() const

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Option::operator string() const

} // namespace UCI
