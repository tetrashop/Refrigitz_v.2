public static class GlobalMembersMisc
{

	/// Version number. If Version is left empty, then compile date in the format
	/// DD-MM-YY and show in engine_info.
	public const string Version = "6";

	/// Debug counters
	public static int[] long hits = new int[2];
	public static int[] means = new int[2];


	/// engine_info() returns the full name of the current Stockfish version. This
	/// will be either "Stockfish <Tag> DD-MM-YY" (where DD-MM-YY is the date when
	/// the program was compiled) or "Stockfish <Version>", depending on whether
	/// Version is empty.

	public static string engine_info(bool to_uci)
	{

	  string months = "Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec";
	  string month;
	  string day;
	  string year;
	//C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
	  stringstream ss = new stringstream(); // From compiler, format is "Sep 21 2008"
	  stringstream date = new stringstream(__DATE__);

	  ss << "Stockfish " << Version << setfill('0');

	  if (string.IsNullOrEmpty(Version))
	  {
		  date >> month >> day >> year;
		  ss << setw(2) << day << setw(2) << (1 + months.IndexOf(month) / 4) << year.Substring(2);
	  }

	  ss << (GlobalMembersTypes.Is64Bit ? " 64" : "") << (GlobalMembersTypes.HasPext ? " BMI2" : (GlobalMembersTypes.HasPopCnt ? " POPCNT" : "")) << (to_uci ? "\nid author ": " by ") << "Tord Romstad, Marco Costalba and Joona Kiiski";

	  return ss.str();
	}


	/// Debug functions used mainly to collect run-time statistics

	public static void dbg_hit_on(bool b)
	{
		++hits[0];
		if (b)
		{
			++hits[1];
		}
	}
	public static void dbg_hit_on_c(bool c, bool b)
	{
		if (c)
		{
			GlobalMembersMisc.dbg_hit_on(b);
		}
	}
	public static void dbg_mean_of(int v)
	{
		++means[0];
		means[1] += v;
	}

	public static void dbg_print()
	{

	  if (hits[0])
	  {
		  cerr << "Total " << hits[0] << " Hits " << hits[1] << " hit rate (%) " << 100 * hits[1] / hits[0] << "\n";
	  }

	  if (means[0] != 0)
	  {
		  cerr << "Total " << means[0] << " Mean " << (double)means[1] / means[0] << "\n";
	  }
	}
//C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
private static Mutex operator << _m = new Mutex();


	/// Used to serialize access to std::cout to avoid multiple threads writing at
	/// the same time.

	public static std.ostream operator << (std.ostream os, SyncCout sc)
	{

	//C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
	//  static Mutex m;

	  if (sc == SyncCout.IO_LOCK)
	  {
		  operator << _m.@lock();
	  }

	  if (sc == SyncCout.IO_UNLOCK)
	  {
		  operator << _m.unlock();
	  }

	  return os;
	}


	/// Trampoline helper to avoid moving Logger to misc.h
	public static void start_logger(bool b)
	{
		Logger.start(b);
	}


	/// timed_wait() waits for msec milliseconds. It is mainly a helper to wrap
	/// the conversion from milliseconds to struct timespec, as used by pthreads.

	public static void timed_wait(WaitCondition sleepCond, Lock sleepLock, int msec)
	{

	#if _WIN32
	  int tm = msec;
	#else
	  timespec ts = new timespec();
	  timespec tm = ts;
	  uint long ms = GlobalMembersMisc.now() + msec;

	  ts.tv_sec = ms / 1000;
	  ts.tv_nsec = (ms % 1000) * 1000000L;
	#endif

	  cond_timedwait(sleepCond, sleepLock, tm);
	}


	/// prefetch() preloads the given address in L1/L2 cache. This is a non-blocking
	/// function that doesn't stall the CPU waiting for data to be loaded from memory,
	/// which can be quite slow.
	#if NO_PREFETCH

	public static void prefetch(ref string UnnamedParameter1)
	{
	}

	#else

	public static void prefetch(ref string addr)
	{

	#if __INTEL_COMPILER
	   // This hack prevents prefetches from being optimized away by
	   // Intel compiler. Both MSVC and gcc seem not be affected by this.
	   __asm__("");
	#endif

	#if __INTEL_COMPILER || _MSC_VER
	  _mm_prefetch(addr, _MM_HINT_T0);
	#else
	  __builtin_prefetch(addr);
	#endif
	}
	#endif
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

/// Our fancy logging facility. The trick here is to replace cin.rdbuf() and
/// cout.rdbuf() with two Tie objects that tie cin and cout to a file stream. We
/// can toggle the logging of std::cout and std:cin at runtime whilst preserving
/// usual i/o functionality, all without changing a single line of code!
/// Idea from http://groups.google.com/group/comp.lang.c++/msg/1d941c0f26ea0d81

public class Tie: streambuf // MSVC requires splitted streambuf for cin and cout
{

  public Tie(streambuf b, ofstream f)
  {
	  this.buf = b;
	  this.file = f;
  }

  public int sync()
  {
	  return file.rdbuf().pubsync(), buf.pubsync();
  }
  public int overflow(int c)
  {
	  return log(buf.sputc((sbyte)c), "<< ");
  }
  public int underflow()
  {
	  return buf.sgetc();
  }
  public int uflow()
  {
	  return log(buf.sbumpc(), ">> ");
  }

  public streambuf buf;
  public ofstream file;

//C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
  private int log_last = '\n';
  public int log(int c, string prefix)
  {

//C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
//	static int last = '\n';

	if (log_last == '\n')
	{
		file.rdbuf().sputn(prefix, 3);
	}

	return log_last = file.rdbuf().sputc((sbyte)c);
  }
}

public class Logger
{

  private Logger()
  {
	  this.in = new Tie(cin.rdbuf(), file);
	  this.@out = new Tie(cout.rdbuf(), file);
  }
 public void Dispose()
 {
	 start(false);
 }

  private ofstream file = new ofstream();
  private Tie in = new Tie();
  private Tie @out = new Tie();

//C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
  private static Logger start_l = new Logger();
  public static void start(bool b)
  {

//C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
//	static Logger l;

	if (b && !start_l.file.is_open())
	{
		start_l.file.open("io_log.txt", ifstream.@out | ifstream.app);
		cin.rdbuf(start_l.in);
		cout.rdbuf(start_l.@out);
	}
	else if (!b && start_l.file.is_open())
	{
		cout.rdbuf(start_l.@out.buf);
		cin.rdbuf(start_l.in.buf);
		start_l.file.close();
	}
  }
}

