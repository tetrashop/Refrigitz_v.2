using Search;
using System.Diagnostics;
using System.Collections.Generic;

public static class GlobalMembersThread
{

	public static ThreadPool Threads = new ThreadPool(); // Global object

	//void check_time();

	 // start_routine() is the C function which is called when a new thread
	 // is launched. It is a wrapper to the virtual function idle_loop().

		 public static int start_routine(ThreadBase th)
		 {
			 th.idle_loop();
			 return 0;
		 }


	 // Helpers to launch a thread after creation and joining before delete. Must be
	 // outside Thread c'tor and d'tor because the object must be fully initialized
	 // when start_routine (and hence virtual idle_loop) is called and when joining.

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
	 public static T new_thread<T>()
	 {
	   T th = new default(T);
	   thread_create(th.handle, GlobalMembersThread.start_routine, th); // Will go to sleep
	   return th;
	 }

	 public static void delete_thread(ThreadBase th)
	 {

	   th.mutex.@lock();
	   th.exit = true; // Search must be already finished
	   th.mutex.unlock();

	   th.notify_one();
	   thread_join(th.handle); // Wait for thread termination
	   if (th != null)
	   th.Dispose();
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



// ThreadBase::notify_one() wakes up the thread when there is some work to do



// ThreadBase::wait_for() set the thread to sleep until 'condition' turns true



// Thread c'tor makes some init but does not launch any execution thread that
// will be started only when c'tor returns.

 // : splitPoints()

// Thread::cutoff_occurred() checks whether a beta cutoff has occurred in the
// current active split point, or in some ancestor of the split point.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Thread::cutoff_occurred() const


// Thread::available_to() checks whether the thread is available to help the
// thread 'master' at a split point. An obvious requirement is that thread must
// be idle. With more than two threads, this is not sufficient: If the thread is
// the master of some split point, it is only available as a slave to the slaves
// which are busy searching the split point at the top of slave's split point
// stack (the "helpful master concept" in YBWC terminology).

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool Thread::available_to(const Thread* master) const


// Thread::split() does the actual work of distributing the work at a node between
// several available threads. If it does not succeed in splitting the node
// (because no idle threads are available), the function immediately returns.
// If splitting is possible, a SplitPoint object is initialized with all the
// data that must be copied to the helper threads and then helper threads are
// informed that they have been assigned work. This will cause them to instantly
// leave their idle loops and call search(). When all threads have returned from
// search() then split() returns.



// TimerThread::idle_loop() is where the timer thread waits Resolution milliseconds
// and then calls check_time(). When not searching, thread sleeps until it's woken up.



// MainThread::idle_loop() is where the main thread is parked waiting to be started
// when there is a new search. The main thread will launch all the slave threads.



// ThreadPool::init() is called at startup to create and launch requested threads,
// that will go immediately to sleep. We cannot use a c'tor because Threads is a
// static object and we need a fully initialized engine at this point due to
// allocation of Endgames in Thread c'tor.



// ThreadPool::exit() terminates the threads before the program exits. Cannot be
// done in d'tor because threads must be terminated before freeing us.



// ThreadPool::read_uci_options() updates internal threads parameters from the
// corresponding UCI options and creates/destroys threads to match the requested
// number. Thread objects are dynamically allocated to avoid creating all possible
// threads in advance (which include pawns and material tables), even if only a
// few are to be used.



// ThreadPool::available_slave() tries to find an idle thread which is available
// as a slave for the thread 'master'.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Thread* ThreadPool::available_slave(const Thread* master) const


// ThreadPool::wait_for_think_finished() waits for main thread to finish the search



// ThreadPool::start_thinking() wakes up the main thread sleeping in
// MainThread::idle_loop() and starts a new search, then returns immediately.

#if StateStackPtr_ConditionalDefinition1
{
  wait_for_think_finished();

  SearchTime = GlobalMembersMisc.now(); // As early as possible

  GlobalMembersSearch.Signals.stopOnPonderhit = GlobalMembersSearch.Signals.firstRootMove = false;
  GlobalMembersSearch.Signals.stop = GlobalMembersSearch.Signals.failedLowAtRoot = false;

  GlobalMembersSearch.RootMoves.Clear();
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: RootPos = pos;
  GlobalMembersSearch.RootPos.CopyFrom(pos);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: Limits = limits;
  GlobalMembersSearch.Limits.CopyFrom(limits);
  if (states.get()) // If we don't set a new position, preserve current state
  {
	  GlobalMembersSearch.SetupStates = states; // Ownership transfer here
	  Debug.Assert(!states.get());
  }

  for (MoveList it = pos; it.Indirection(); ++it)
  {
	  if (limits.searchmoves.Count == 0 || std.count(limits.searchmoves.GetEnumerator(), limits.searchmoves.end(), it.Indirection()))
	  {
		  GlobalMembersSearch.RootMoves.Add(new RootMove(it.Indirection()));
	  }
  }

  main().thinking = true;
  main().notify_one(); // Starts main thread
}
