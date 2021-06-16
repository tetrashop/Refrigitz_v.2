using System.Collections.Generic;

public static class GlobalMembersThread
{


//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Entry probe(Position pos);


//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void init<Color Us>();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Entry probe<Color Us>(Position pos);

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ThreadPool Threads;
}

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

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/



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

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


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

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/





/// EndgameType lists all supported endgames

public enum EndgameType
{

  // Evaluation functions

  KNNK, // KNN vs K
  KXK, // Generic "mate lone king" eval
  KBNK, // KBN vs K
  KPK, // KP vs K
  KRKP, // KR vs KP
  KRKB, // KR vs KB
  KRKN, // KR vs KN
  KQKP, // KQ vs KP
  KQKR, // KQ vs KR


  // Scaling functions
  SCALING_FUNCTIONS,

  KBPsK, // KB and pawns vs K
  KQKRPs, // KQ vs KR and pawns
  KRPKR, // KRP vs KR
  KRPKB, // KRP vs KB
  KRPPKRP, // KRPP vs KRP
  KPsK, // K and pawns vs K
  KBPKB, // KBP vs KB
  KBPPKB, // KBPP vs KB
  KBPKN, // KBP vs KN
  KNPK, // KNP vs K
  KNPKB, // KNP vs KB
  KPKP // KP vs KP
}


/// Endgame functions can be of two types depending on whether they return a
/// Value or a ScaleFactor.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<EndgameType E>
//C++ TO C# CONVERTER TODO TASK: There is no equivalent in C# to C++11 template aliases:
using eg_type = typename std.conditional < (E < SCALING_FUNCTIONS), Value, ScaleFactor>.type;


/// Base and derived templates for endgame evaluation and scaling functions

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
public abstract class EndgameBase <T>
{

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  public void Dispose();
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: virtual Color strong_side() const = 0;
  public abstract Color strong_side();
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: virtual T operator ()(const Position&) const = 0;
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
  public static abstract T operator ()(Position NamelessParameter);
}


//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<EndgameType E, typename T = eg_type<E>>
public class Endgame <EndgameType E, T = eg_type<E>>: EndgameBase<T>
{

  public Endgame(Color c)
  {
	  this.strongSide = new Color(c);
	  this.weakSide = new Color(~c);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Color strong_side() const
  public Color strong_side()
  {
	  return strongSide;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: T operator ()(const Position&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  T operator ()(Position NamelessParameter);

  private Color strongSide;
  private Color weakSide;
}


/// The Endgames class stores the pointers to endgame evaluation and scaling
/// base objects in two std::map. We use polymorphism to invoke the actual
/// endgame function by calling its virtual operator().

public class Endgames
{

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
//C++ TO C# CONVERTER TODO TASK: There is no equivalent in C# to C++11 template aliases:
  using Map = SortedDictionary<ulong, std.unique_ptr<EndgameBase<T>>>;

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<EndgameType E, typename T = eg_type<E>>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void add<EndgameType E, T = eg_type<E>>(string code);

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
  private Map<T> map<T>()
  {
	return std.get<std.is_same<T, ScaleFactor>.value>(maps);
  }

  private std.pair<Map<Value>, Map<ScaleFactor>> maps = new std.pair<Map<Value>, Map<ScaleFactor>>();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Endgames();

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
  public EndgameBase<T> probe<T>(ulong key)
  {
	return new SortedDictionary<T>().count(key) ? new SortedDictionary<T>()[key].get() : null;
  }
}



namespace Material
{

/// Material::Entry contains various information about a material configuration.
/// It contains a material imbalance evaluation, a function pointer to a special
/// endgame evaluation function (which in most cases is NULL, meaning that the
/// standard evaluation function will be used), and scale factors.
///
/// The scale factors are used to scale the evaluation score up or down. For
/// instance, in KRB vs KR endgames, the score is scaled down by a factor of 4,
/// which will result in scores of absolute value less than one pawn.

public class Entry
{

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Score imbalance() const
  public Score imbalance()
  {
	  return GlobalMembersBenchmark.make_score(value, value);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Phase game_phase() const
  public Phase game_phase()
  {
	  return gamePhase;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool specialized_eval_exists() const
  public bool specialized_eval_exists()
  {
	  return evaluationFunction != null;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value evaluate(const Position& pos) const
  public Value evaluate(Position pos)
  {
	  return evaluationFunction(pos);
  }

  // scale_factor takes a position and a color as input and returns a scale factor
  // for the given color. We have to provide the position in addition to the color
  // because the scale factor may also be a function which should be applied to
  // the position. For instance, in KBP vs K endgames, the scaling function looks
  // for rook pawns and wrong-colored bishops.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor scale_factor(const Position& pos, Color c) const
  public ScaleFactor scale_factor(Position pos, Color c)
  {
	ScaleFactor sf = scalingFunction[(int)c] != null ? scalingFunction[(int)c](pos) : ScaleFactor.SCALE_FACTOR_NONE;
	return sf != ((int)ScaleFactor.SCALE_FACTOR_NONE) != 0 ? sf : ScaleFactor(factor[(int)c]);
  }

  public ulong key;
  public short value;
  public byte[] factor = new byte[(int)Color.COLOR_NB];
  public EndgameBase<Value> evaluationFunction;
  public EndgameBase<ScaleFactor>[] scalingFunction = Arrays.InitializeWithDefaultInstances<EndgameBase>((int)Color.COLOR_NB); // Could be one for each
													   // side (e.g. KPKP, KBPsKs)
  public Phase gamePhase;
}

} // namespace Material


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

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/



namespace Pawns
{

/// Pawns::Entry contains various information about a pawn structure. A lookup
/// to the pawn hash table (performed by calling the probe function) returns a
/// pointer to an Entry object.

public class Entry
{

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Score pawns_score() const
  public Score pawns_score()
  {
	  return score;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong pawn_attacks(Color c) const
  public ulong pawn_attacks(Color c)
  {
	  return pawnAttacks[(int)c];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong passed_pawns(Color c) const
  public ulong passed_pawns(Color c)
  {
	  return passedPawns[(int)c];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong pawn_attacks_span(Color c) const
  public ulong pawn_attacks_span(Color c)
  {
	  return pawnAttacksSpan[(int)c];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int pawn_asymmetry() const
  public int pawn_asymmetry()
  {
	  return asymmetry;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int open_files() const
  public int open_files()
  {
	  return openFiles;
  }

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int semiopen_file(Color c, File f) const
  public int semiopen_file(Color c, File f)
  {
	return semiopenFiles[(int)c] & (1 << f);
  }

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int semiopen_side(Color c, File f, bool leftSide) const
  public int semiopen_side(Color c, File f, bool leftSide)
  {
	return semiopenFiles[(int)c] & (leftSide ? (1 << f) - 1 :~((1 << (f + 1)) - 1));
  }

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int pawns_on_same_color_squares(Color c, Square s) const
  public int pawns_on_same_color_squares(Color c, Square s)
  {
	return pawnsOnSquares[(int)c, !!(GlobalMembersBenchmark.DarkSquares & (int)s)];
  }

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
  public Score king_safety<Color Us>(Position pos, Square ksq)
  {
	return kingSquares[Us] == ksq && castlingRights[Us] == pos.can_castle(Us) != 0 ? kingSafety[Us] : (kingSafety[Us] = do_king_safety<Us>(pos, ksq));
  }

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	public Score do_king_safety<Color Us>(Position pos, Square ksq)
	{
    
	  kingSquares[Us] = ksq;
	  castlingRights[Us] = pos.can_castle(Us);
	  int minKingPawnDistance = 0;
    
	  ulong pawns = pos.pieces(Us, PieceType.PAWN);
	  if (pawns != 0)
	  {
		  while (((GlobalMembersBitboard.DistanceRingBB[(int)ksq, minKingPawnDistance++] & pawns) == 0)
		  {
		  }
	  }
    
	  Value bonus = shelter_storm<Us>(pos, ksq);
    
	  // If we can castle use the bonus after the castling if it is bigger
	  if (pos.can_castle(MakeCastling<Us, CastlingSide.KING_SIDE>.right) != 0)
	  {
		  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersBenchmark.relative_square(Us, Square.SQ_G1)));
	  }
    
	  if (pos.can_castle(MakeCastling<Us, CastlingSide.QUEEN_SIDE>.right) != 0)
	  {
		  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersBenchmark.relative_square(Us, Square.SQ_C1)));
	  }
    
	  return GlobalMembersBenchmark.make_score(bonus, -16 * minKingPawnDistance);
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	public Value shelter_storm<Color Us>(Position pos, Square ksq)
	{
    
	  Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
    
    
	  ulong b = pos.pieces(PieceType.PAWN) & (GlobalMembersBenchmark.in_front_bb(Us, GlobalMembersBenchmark.rank_of(ksq)) | GlobalMembersBenchmark.rank_bb(ksq));
	  ulong ourPawns = b & pos.pieces(Us);
	  ulong theirPawns = b & pos.pieces(Them);
	  Value safety = MaxSafetyBonus;
	  File center = Math.Max(File.FILE_B, Math.Min(File.FILE_G, GlobalMembersBenchmark.file_of(ksq)));
    
	  for (File f = center - File(1); f <= center + File(1); ++f)
	  {
		  b = ourPawns & GlobalMembersBenchmark.file_bb(f);
		  Rank rkUs = b != 0 ? GlobalMembersBenchmark.relative_rank(Us, GlobalMembersBenchmark.backmost_sq(Us, b)) : Rank.RANK_1;
    
		  b = theirPawns & GlobalMembersBenchmark.file_bb(f);
		  Rank rkThem = b != 0 ? GlobalMembersBenchmark.relative_rank(Us, GlobalMembersBenchmark.frontmost_sq(Them, b)) : Rank.RANK_1;
    
		  safety -= ShelterWeakness[Math.Min(f, File.FILE_H - f), (int)rkUs] + StormDanger [(int)f == GlobalMembersBenchmark.file_of(ksq) && rkThem == GlobalMembersBenchmark.relative_rank(Us, ksq) + 1 ? BlockedByKing : rkUs == ((int)Rank.RANK_1) != 0 ? NoFriendlyPawn : rkThem == rkUs + 1 ? BlockedByPawn : Unblocked, Math.Min(f, File.FILE_H - f), (int)rkThem];
	  }
    
	  return safety;
	}

  public ulong key;
  public Score score;
  public ulong[] passedPawns = new ulong[(int)Color.COLOR_NB];
  public ulong[] pawnAttacks = new ulong[(int)Color.COLOR_NB];
  public ulong[] pawnAttacksSpan = new ulong[(int)Color.COLOR_NB];
  public Square[] kingSquares = new Square[(int)Color.COLOR_NB];
  public Score[] kingSafety = new Score[(int)Color.COLOR_NB];
  public int[] castlingRights = new int[(int)Color.COLOR_NB];
  public int[] semiopenFiles = new int[(int)Color.COLOR_NB];
  public int[,] pawnsOnSquares = new int[(int)Color.COLOR_NB, (int)Color.COLOR_NB]; // [color][light/dark squares]
  public int asymmetry;
  public int openFiles;
}

} // namespace Pawns


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

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


/// STL thread library used by mingw and gcc when cross compiling for Windows
/// relies on libwinpthread. Currently libwinpthread implements mutexes directly
/// on top of Windows semaphores. Semaphores, being kernel objects, require kernel
/// mode transition in order to lock or unlock, which is very slow compared to
/// interlocked operations (about 30% slower on bench test). To work around this
/// issue, we define our wrappers to the low level Win32 calls. We use critical
/// sections to support Windows XP and older versions. Unfortunately, cond_wait()
/// is racy between unlock() and WaitForSingleObject() but they have the same
/// speed performance as the SRW locks.


#if _WIN32 && !_MSC_VER

#define NOMINMAX

#define WIN32_LEAN_AND_MEAN_ConditionalDefinition1
#define WIN32_LEAN_AND_MEAN
#undef WIN32_LEAN_AND_MEAN
#undef NOMINMAX

/// Mutex and ConditionVariable struct are wrappers of the low level locking
/// machinery and are modeled after the corresponding C++11 classes.

//C++ TO C# CONVERTER WARNING: The original type declaration contained unconverted modifiers:
//ORIGINAL LINE: struct std::mutex
public class mutex <Color Us>
{
  public std.mutex()
  {
	  InitializeCriticalSection(cs);
  }
 public void Dispose()
 {
	 DeleteCriticalSection(cs);
 }
  public void @lock()
  {
	  EnterCriticalSection(cs);
  }
  public void unlock()
  {
	  LeaveCriticalSection(cs);
  }

  private CRITICAL_SECTION cs = new CRITICAL_SECTION();
}

#define ConditionVariable_ConditionalDefinition1

#else

#define Mutex_ConditionalDefinition1
#define ConditionVariable_ConditionalDefinition2

#endif




/// Thread struct keeps together all the thread-related stuff. We also use
/// per-thread pawn and material hash tables so that once we get a pointer to an
/// entry its life time is unlimited and we don't have to care about someone
/// changing the entry under our feet.

public class Thread <Color Us>
{

  private std.thread nativeThread = new std.thread();
  private std.mutex mutex = new std.mutex();
#if ConditionVariable_ConditionalDefinition1
  private std.condition_variable_any sleepCondition = new std.condition_variable_any();
#elif ConditionVariable_ConditionalDefinition2
  private std.condition_variable sleepCondition = new std.condition_variable();
#else
  private ConditionVariable sleepCondition = new ConditionVariable();
#endif
  private bool exit;
  private bool searching;

	public Thread()
	{
    
	  resetCalls = exit = false;
	  maxPly = callsCnt = 0;
	  tbHits = 0;
	  history.clear();
	  counterMoves.clear();
	  idx = Threads.Count; // Start from 0
    
	  std.unique_lock<std.mutex> lk = new std.unique_lock<std.mutex>(mutex);
	  searching = true;
	  nativeThread = std.thread(Thread.idle_loop, this);
	  sleepCondition.wait(lk, () =>
	  {
		  return !searching;
	  });
	}
	public void Dispose()
	{
    
	  mutex.@lock();
	  exit = true;
	  sleepCondition.notify_one();
	  mutex.unlock();
	  nativeThread.join();
	}
	public void search()
	{
    
	  Stack[] stack = Arrays.InitializeWithDefaultInstances<Search.Stack>(MAX_PLY + 7); // To allow referencing (ss-5) and (ss+2)
	  Stack ss = stack + 5;
	  Value bestValue;
	  Value alpha;
	  Value beta;
	  Value delta;
	  Move easyMove = Move.MOVE_NONE;
	  MainThread mainThread = (this == GlobalMembersThread.Threads.main() ? GlobalMembersThread.Threads.main() : null);
    
	  std.memset(ss - 5, 0, 8 * sizeof(Stack));
    
	  bestValue = delta = alpha = -Value.VALUE_INFINITE;
	  beta = Value.VALUE_INFINITE;
	  completedDepth = Depth.DEPTH_ZERO;
    
	  if (mainThread)
	  {
		  easyMove = EasyMove.get(rootPos.key());
		  EasyMove.clear();
		  mainThread.easyMovePlayed = mainThread.failedLow = false;
		  mainThread.bestMoveChanges = 0;
		  GlobalMembersTt.TT.new_search();
	  }
    
	  uint multiPV = GlobalMembersUcioption.Options["MultiPV"];
	  Skill skill = new Skill(GlobalMembersUcioption.Options["Skill Level"]);
    
	  // When playing with strength handicap enable MultiPV search that we will
	  // use behind the scenes to retrieve a set of possible moves.
	  if (skill.enabled())
	  {
		  multiPV = Math.Max(multiPV, (uint)4);
	  }
    
	  multiPV = Math.Min(multiPV, rootMoves.size());
    
	  // Iterative deepening loop until requested to stop or the target depth is reached
	  while ((rootDepth += Depth.ONE_PLY) < Depth.DEPTH_MAX && Signals.stop == null && (Limits.depth == 0 || GlobalMembersThread.Threads.main().rootDepth / Depth.ONE_PLY <= Limits.depth))
	  {
		  // Set up the new depths for the helper threads skipping on average every
		  // 2nd ply (using a half-density matrix).
		  if (mainThread == null)
		  {
			  List<int> row = HalfDensity[(idx - 1) % HalfDensitySize];
			  if (row[(rootDepth / Depth.ONE_PLY + rootPos.game_ply()) % row.Count] != 0)
				 continue;
		  }
    
		  // Age out PV variability metric
		  if (mainThread)
		  {
			  mainThread.bestMoveChanges *= 0.505, mainThread.failedLow = false;
		  }
    
		  // Save the last iteration's scores before first PV line is searched and
		  // all the move scores except the (new) PV are set to -VALUE_INFINITE.
		  foreach (RootMove rm in rootMoves)
		  {
			  rm.previousScore = rm.score;
		  }
    
		  // MultiPV loop. We perform a full root search for each PV line
		  for (PVIdx = 0; PVIdx < multiPV && Signals.stop == null; ++PVIdx)
		  {
			  // Reset aspiration window starting size
			  if (rootDepth >= 5 * Depth.ONE_PLY)
			  {
				  delta = Value(18);
				  alpha = Math.Max(rootMoves[PVIdx].previousScore - delta,-Value.VALUE_INFINITE);
				  beta = Math.Min(rootMoves[PVIdx].previousScore + delta, Value.VALUE_INFINITE);
			  }
    
			  // Start with a small aspiration window and, in the case of a fail
			  // high/low, re-search with a bigger window until we're not failing
			  // high/low anymore.
			  while (true)
			  {
				  bestValue = global::search<NodeType.PV>(rootPos, ss, alpha, beta, rootDepth, false);
    
				  // Bring the best move to the front. It is critical that sorting
				  // is done with a stable algorithm because all the values but the
				  // first and eventually the new best one are set to -VALUE_INFINITE
				  // and we want to keep the same order for all the moves except the
				  // new PV that goes to the front. Note that in case of MultiPV
				  // search the already searched PV lines are preserved.
				  std.stable_sort(rootMoves.begin() + PVIdx, rootMoves.end());
    
				  // If search has been stopped, break immediately. Sorting and
				  // writing PV back to TT is safe because RootMoves is still
				  // valid, although it refers to the previous iteration.
				  if (Signals.stop)
					  break;
    
				  // When failing high/low give some update (without cluttering
				  // the UI) before a re-search.
				  if (mainThread != null && multiPV == 1 && (bestValue <= alpha || bestValue >= beta) && GlobalMembersTimeman.Time.elapsed() > 3000)
				  {
					  Console.Write(SyncCout.IO_LOCK);
					  Console.Write(GlobalMembersSearch.pv(rootPos, rootDepth, alpha, beta));
					  Console.Write("\n");
					  Console.Write(SyncCout.IO_UNLOCK);
				  }
    
				  // In case of failing low/high increase aspiration window and
				  // re-search, otherwise exit the loop.
				  if (bestValue <= alpha)
				  {
					  beta = (alpha + beta) / 2;
					  alpha = Math.Max(bestValue - delta, -Value.VALUE_INFINITE);
    
					  if (mainThread)
					  {
						  mainThread.failedLow = true;
						  Signals.stopOnPonderhit = false;
					  }
				  }
				  else if (bestValue >= beta)
				  {
					  alpha = (alpha + beta) / 2;
					  beta = Math.Min(bestValue + delta, Value.VALUE_INFINITE);
				  }
				  else
					  break;
    
				  delta += delta / 4 + 5;
    
				  Debug.Assert(alpha >= -Value.VALUE_INFINITE && beta <= Value.VALUE_INFINITE);
			  }
    
			  // Sort the PV lines searched so far and update the GUI
			  std.stable_sort(rootMoves.begin(), rootMoves.begin() + PVIdx + 1);
    
			  if (mainThread == null)
				  continue;
    
			  if (Signals.stop != null || PVIdx + 1 == multiPV || GlobalMembersTimeman.Time.elapsed() > 3000)
			  {
				  Console.Write(SyncCout.IO_LOCK);
				  Console.Write(GlobalMembersSearch.pv(rootPos, rootDepth, alpha, beta));
				  Console.Write("\n");
				  Console.Write(SyncCout.IO_UNLOCK);
			  }
		  }
    
		  if (Signals.stop == null)
		  {
			  completedDepth = rootDepth;
		  }
    
		  if (mainThread == null)
			  continue;
    
		  // If skill level is enabled and time is up, pick a sub-optimal best move
		  if (skill.enabled() && skill.time_to_pick(rootDepth))
		  {
			  skill.pick_best(multiPV);
		  }
    
		  // Have we found a "mate in x"?
		  if (Limits.mate != 0 && bestValue >= Value.VALUE_MATE_IN_MAX_PLY && Value.VALUE_MATE - bestValue <= 2 * Limits.mate)
		  {
			  Signals.stop = true;
		  }
    
		  // Do we have time for the next iteration? Can we stop searching now?
		  if (Limits.use_time_management())
		  {
			  if (Signals.stop == null && Signals.stopOnPonderhit == null)
			  {
				  // Stop the search if only one legal move is available, or if all
				  // of the available time has been used, or if we matched an easyMove
				  // from the previous search and just did a fast verification.
				  int[] F = {mainThread.failedLow, bestValue - mainThread.previousScore};
    
				  int improvingFactor = Math.Max(229, Math.Min(715, 357 + 119 * F[0] - 6 * F[1]));
				  double unstablePvFactor = 1 + mainThread.bestMoveChanges;
    
				  bool doEasyMove = rootMoves[0].pv[0] == easyMove && mainThread.bestMoveChanges < 0.03 && GlobalMembersTimeman.Time.elapsed() > GlobalMembersTimeman.Time.optimum() * 5 / 42;
    
				  if (rootMoves.size() == 1 || GlobalMembersTimeman.Time.elapsed() > GlobalMembersTimeman.Time.optimum() * unstablePvFactor * improvingFactor / 628 || (mainThread.easyMovePlayed = doEasyMove, doEasyMove))
				  {
					  // If we are allowed to ponder do not stop the search now but
					  // keep pondering until the GUI sends "ponderhit" or "stop".
					  if (Limits.ponder != 0)
					  {
						  Signals.stopOnPonderhit = true;
					  }
					  else
					  {
						  Signals.stop = true;
					  }
				  }
			  }
    
			  if (rootMoves[0].pv.size() >= 3)
			  {
				  EasyMove.update(rootPos, rootMoves[0].pv);
			  }
			  else
			  {
				  EasyMove.clear();
			  }
		  }
	  }
    
	  if (mainThread == null)
		  return;
    
	  // Clear any candidate easy move that wasn't stable for the last search
	  // iterations; the second condition prevents consecutive fast moves.
	  if (EasyMove.stableCnt < 6 || mainThread.easyMovePlayed)
	  {
		  EasyMove.clear();
	  }
    
	  // If skill level is enabled, swap best PV line with the sub-optimal one
	  if (skill.enabled())
	  {
		  std.swap(rootMoves[0], *std.find(rootMoves.begin(), rootMoves.end(), skill.best_move(multiPV)));
	  }
	}
	public void idle_loop()
	{
    
	  while (!exit)
	  {
		  std.unique_lock<std.mutex> lk = new std.unique_lock<std.mutex>(mutex);
    
		  searching = false;
    
		  while (!searching && !exit)
		  {
			  sleepCondition.notify_one(); // Wake up any waiting thread
			  sleepCondition.wait(lk);
		  }
    
		  lk.unlock();
    
		  if (!exit)
		  {
			  search();
		  }
	  }
	}
	public void start_searching(bool resume)
	{
    
	  std.unique_lock<std.mutex> lk = new std.unique_lock<std.mutex>(mutex);
    
	  if (!resume)
	  {
		  searching = true;
	  }
    
	  sleepCondition.notify_one();
	}
	public void wait_for_search_finished()
	{
    
	  std.unique_lock<std.mutex> lk = new std.unique_lock<std.mutex>(mutex);
	  sleepCondition.wait(lk, () =>
	  {
		  return !searching;
	  });
	}
	public void wait(std.atomic_bool condition)
	{
    
	  std.unique_lock<std.mutex> lk = new std.unique_lock<std.mutex>(mutex);
	  sleepCondition.wait(lk, () =>
	  {
		  return (bool)condition;
	  });
	}

  public HashTable<Entry, 16384> pawnsTable = new HashTable<Entry, 16384>();
#if Material::Table_ConditionalDefinition1
  public HashTable<Entry, 8192> materialTable = new HashTable<Entry, 8192>();
#elif Material::Table_ConditionalDefinition2
  public HashTable<Entry, 8192> materialTable = new HashTable<Entry, 8192>();
#elif Material::Table_ConditionalDefinition3
  public HashTable<Entry, 8192> materialTable = new HashTable<Entry, 8192>();
#else
  public Material.Table materialTable = new Material.Table();
#endif
  public Endgames endgames = new Endgames();
  public uint idx;
  public uint PVIdx;
  public int maxPly;
  public int callsCnt;
  public ulong tbHits;

  public Position rootPos = new Position();
  public List<RootMove> rootMoves = new List<RootMove>();
  public Depth rootDepth;
  public Depth completedDepth;
  public std.atomic_bool resetCalls = new std.atomic_bool();
  public Stats<Value, false> history = new Stats<Value, false>();
  public Stats<Move> counterMoves = new Stats<Move>();
  public FromToStats fromTo = new FromToStats();
  public Stats<Stats<Value, true>> counterMoveHistory = new Stats<Stats<Value, true>>();
}


/// MainThread is a derived class with a specific overload for the main thread

public class MainThread : Thread
{
	public void search()
	{
    
	  Color us = rootPos.side_to_move();
	  GlobalMembersTimeman.Time.init(Limits, us, rootPos.game_ply());
    
	  int contempt = GlobalMembersUcioption.Options["Contempt"] * Value.PawnValueEg / 100; // From centipawns
	  DrawValue[(int)us] = Value.VALUE_DRAW - Value(contempt);
	  DrawValue[~us] = Value.VALUE_DRAW + Value(contempt);
    
	  if (rootMoves.empty())
	  {
		  rootMoves.push_back(new RootMove(Move.MOVE_NONE));
		  Console.Write(SyncCout.IO_LOCK);
		  Console.Write("info depth 0 score ");
		  Console.Write(GlobalMembersUci.value(rootPos.checkers() ? - Value.VALUE_MATE : Value.VALUE_DRAW));
		  Console.Write("\n");
		  Console.Write(SyncCout.IO_UNLOCK);
	  }
	  else
	  {
		  foreach (Thread th in GlobalMembersThread.Threads)
		  {
			  if (th != this)
			  {
				  th.start_searching();
			  }
		  }
    
		  Thread.search(); // Let's start searching!
	  }
    
	  // When playing in 'nodes as time' mode, subtract the searched nodes from
	  // the available ones before exiting.
	  if (Limits.npmsec != 0)
	  {
		  GlobalMembersTimeman.Time.availableNodes += Limits.inc[(int)us] - GlobalMembersThread.Threads.nodes_searched();
	  }
    
	  // When we reach the maximum depth, we can arrive here without a raise of
	  // Signals.stop. However, if we are pondering or in an infinite search,
	  // the UCI protocol states that we shouldn't print the best move before the
	  // GUI sends a "stop" or "ponderhit" command. We therefore simply wait here
	  // until the GUI sends one of those commands (which also raises Signals.stop).
	  if (Signals.stop == null && (Limits.ponder != 0 || Limits.infinite != 0))
	  {
		  Signals.stopOnPonderhit = true;
		  wait(Signals.stop);
	  }
    
	  // Stop the threads if not already stopped
	  Signals.stop = true;
    
	  // Wait until all threads have finished
	  foreach (Thread th in GlobalMembersThread.Threads)
	  {
		  if (th != this)
		  {
			  th.wait_for_search_finished();
		  }
	  }
    
	  // Check if there are threads with a better score than main thread
	  Thread bestThread = this;
	  if (!this.easyMovePlayed && GlobalMembersUcioption.Options["MultiPV"] == 1 && Limits.depth == 0 && !new Skill(GlobalMembersUcioption.Options["Skill Level"]).enabled() && rootMoves[0].pv[0] != Move.MOVE_NONE)
	  {
		  foreach (Thread th in GlobalMembersThread.Threads)
		  {
			  if (th.completedDepth > bestThread.completedDepth && th.rootMoves[0].score > bestThread.rootMoves[0].score)
			  {
				  bestThread = th;
			  }
		  }
	  }
    
	  previousScore = bestThread.rootMoves[0].score;
    
	  // Send new PV when needed
	  if (bestThread != this)
	  {
		  Console.Write(SyncCout.IO_LOCK);
		  Console.Write(GlobalMembersSearch.pv(bestThread.rootPos, bestThread.completedDepth, -Value.VALUE_INFINITE, Value.VALUE_INFINITE));
		  Console.Write("\n");
		  Console.Write(SyncCout.IO_UNLOCK);
	  }
	  GlobalMembersUci.BestMove = true;
	  Console.Write(SyncCout.IO_LOCK);
	  Console.Write("bestmove ");
	//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
	//ORIGINAL LINE: Console.Write(GlobalMembersUci::move(bestThread->rootMoves[0].pv[0], rootPos.is_chess960()));
	  Console.Write(GlobalMembersUci.move(new List(bestThread.rootMoves[0].pv[0]), rootPos.is_chess960()));
	  GlobalMembersUci.BestMove = false;
	  if (bestThread.rootMoves[0].pv.Count > 1 || bestThread.rootMoves[0].extract_ponder_from_tt(rootPos))
	  {
		  Console.Write(" ponder ");
	//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
	//ORIGINAL LINE: Console.Write(GlobalMembersUci::move(bestThread->rootMoves[0].pv[1], rootPos.is_chess960()));
		  Console.Write(GlobalMembersUci.move(new List(bestThread.rootMoves[0].pv[1]), rootPos.is_chess960()));
	  }
    
	  Console.Write("\n");
	  Console.Write(SyncCout.IO_UNLOCK);
	}

  public bool easyMovePlayed;
  public bool failedLow;
  public double bestMoveChanges;
  public Value previousScore;
}


/// ThreadPool struct handles all the threads-related stuff like init, starting,
/// parking and, most importantly, launching a thread. All the access to threads
/// data is done through this class.

public class ThreadPool : List<Thread*>
{

	public void init()
	{
    
	  push_back(new MainThread());
	  read_uci_options();
	}
	public void exit()
	{
    
	  while (size())
	  {
		  back(), pop_back() = null;
	  }
	}

  static MainThread Main()
  {
	  return (MainThread)(at(0));
  }
	public void start_thinking(Position pos, std.unique_ptr<std.deque<StateInfo>> states, Search.LimitsType limits)
	{
    
	  main().wait_for_search_finished();
    
	  GlobalMembersSearch.Signals.stopOnPonderhit = GlobalMembersSearch.Signals.stop = false;
	//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
	//ORIGINAL LINE: Search::Limits = limits;
	  GlobalMembersSearch.Limits.CopyFrom(limits);
	  List<RootMove> rootMoves = new List<RootMove>();
    
	  foreach (var m in new MoveList<GenType.LEGAL>(pos))
	  {
		  if (limits.searchmoves.Count == 0 || std.count(limits.searchmoves.GetEnumerator(), limits.searchmoves.end(), m))
		  {
			  rootMoves.Add(new Search.RootMove(m));
		  }
	  }
    
	  if (rootMoves.Count > 0)
	  {
		  GlobalMembersSearch.filter_root_moves(pos, rootMoves);
	  }
    
	  // After ownership transfer 'states' becomes empty, so if we stop the search
	  // and call 'go' again without setting a new position states.get() == NULL.
	  Debug.Assert(states.get() || setupStates.get());
    
	  if (states.get())
	  {
		  setupStates = std.move(states); // Ownership transfer, states is now empty
	  }
    
	  StateInfo tmp = setupStates.back();
    
	  foreach (Thread th in Threads)
	  {
		  th.maxPly = 0;
		  th.tbHits = 0;
		  th.rootDepth = Depth.DEPTH_ZERO;
		  th.rootMoves = new List<RootMove>(rootMoves);
		  th.rootPos.set(pos.fen(), pos.is_chess960(), setupStates.back(), th);
	  }
    
	  setupStates.back() = tmp; // Restore st->previous, cleared by Position::set()
    
	  main().start_searching();
	}
	public void read_uci_options()
	{
    
	  uint requested = GlobalMembersUcioption.Options["Threads"];
    
	  Debug.Assert(requested > 0);
    
	  while (size() < requested)
	  {
		  push_back(new Thread());
	  }
    
	  while (size() > requested)
	  {
		  back(), pop_back() = null;
	  }
	}
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong nodes_searched() const;
	public ulong nodes_searched()
	{
    
	  ulong nodes = 0;
	  foreach (Thread th in * this)
	  {
		  nodes += th.rootPos.nodes_searched();
	  }
	  return nodes;
	}
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong tb_hits() const;
	public ulong tb_hits()
	{
    
	  ulong hits = 0;
	  foreach (Thread th in * this)
	  {
		  hits += th.tbHits;
	  }
	  return hits;
	}

  private std.unique_ptr<std.deque<StateInfo>> setupStates = new std.unique_ptr<std.deque<StateInfo>>();
}

