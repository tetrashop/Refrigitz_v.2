using System.Diagnostics;
using System.Collections.Generic;

using Trace;
using System;

public static class GlobalMembersEvaluate
{
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


	/// When compiling with provided Makefile (e.g. for Linux and OSX), configuration
	/// is done automatically. To get started type 'make help'.
	///
	/// When Makefile is not used (e.g. with Microsoft Visual Studio) some switches
	/// need to be set manually:
	///
	/// -DNDEBUG      | Disable debugging mode. Always use this for release.
	///
	/// -DNO_PREFETCH | Disable use of prefetch asm-instruction. You may need this to
	///               | run on some very old machines.
	///
	/// -DUSE_POPCNT  | Add runtime support for use of popcnt asm-instruction. Works
	///               | only in 64-bit mode and requires hardware with popcnt support.
	///
	/// -DUSE_PEXT    | Add runtime support for use of pext asm-instruction. Works
	///               | only in 64-bit mode and requires hardware with pext support.


	#if _MSC_VER
	// Disable some silly and noisy warning from MSVC compiler
	//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
	//#pragma warning(disable: 4127) // Conditional expression is constant
	//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
	//#pragma warning(disable: 4146) // Unary minus operator applied to unsigned type
	//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
	//#pragma warning(disable: 4800) // Forcing value to bool 'true' or 'false'
	#endif

	/// Predefined macros hell:
	///
	/// __GNUC__           Compiler is gcc, Clang or Intel on Linux
	/// __INTEL_COMPILER   Compiler is Intel
	/// _MSC_VER           Compiler is MSVC or Intel on Windows
	/// _WIN32             Building on Windows (any)
	/// _WIN64             Building on Windows 64 bit

	#if _WIN64 && _MSC_VER
	#define IS_64BIT
	#endif

	#if USE_POPCNT && (__INTEL_COMPILER || _MSC_VER)
	#endif

	#if !NO_PREFETCH && (__INTEL_COMPILER || _MSC_VER)
	#endif

	#if USE_PEXT
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define pext(b, m) _pext_u64(b, m)
	#define pext
	#else
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define pext(b, m) (0)
	#define pext
	#endif

	#if USE_POPCNT
	public const bool HasPopCnt = true;
	#else
	public const bool HasPopCnt = false;
	#endif

	#if USE_PEXT
	public const bool HasPext = true;
	#else
	public const bool HasPext = false;
	#endif

	#if IS_64BIT
	public const bool Is64Bit = true;
	#else
	public const bool Is64Bit = false;
	#endif


	public const int MAX_MOVES = 256;
	public const int MAX_PLY = 128;

	public static readonly Piece[] Pieces = {Piece.W_PAWN, Piece.W_KNIGHT, Piece.W_BISHOP, Piece.W_ROOK, Piece.W_QUEEN, Piece.W_KING, Piece.B_PAWN, Piece.B_KNIGHT, Piece.B_BISHOP, Piece.B_ROOK, Piece.B_QUEEN, Piece.B_KING};
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern Value PieceValue[PHASE_NB][PIECE_NB];

	public static Score make_score(int mg, int eg)
	{
	  return GlobalMembersSearch.Score((int)((uint)eg << 16) + mg);
	}

	/// Extracting the signed lower and upper 16 bits is not so trivial because
	/// according to the standard a simple cast to short is implementation defined
	/// and so is a right shift of a signed integer.
	public static Value eg_value(Score s)
	{

//C++ TO C# CONVERTER TODO TASK: Unions within methods are not supported in C#:
	//  union
	//  {
	//	  ushort u;
	//	  short s;
	//  }
	  eg = {(ushort)((uint)(s + 0x8000) >> 16)};
	  return Value(eg.s);
	}

	public static Value mg_value(Score s)
	{

//C++ TO C# CONVERTER TODO TASK: Unions within methods are not supported in C#:
	//  union
	//  {
	//	  ushort u;
	//	  short s;
	//  }
	  mg = {(ushort)((uint)s)};
	  return Value(mg.s);
	}

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define ENABLE_BASE_OPERATORS_ON(T) inline T operator+(T d1, T d2) { return T(int(d1) + int(d2)); } inline T operator-(T d1, T d2) { return T(int(d1) - int(d2)); } inline T operator*(int i, T d) { return T(i * int(d)); } inline T operator*(T d, int i) { return T(int(d) * i); } inline T operator-(T d) { return T(-int(d)); } inline T& operator+=(T& d1, T d2) { return d1 = d1 + d2; } inline T& operator-=(T& d1, T d2) { return d1 = d1 - d2; } inline T& operator*=(T& d, int i) { return d = T(int(d) * i); }
	#define ENABLE_BASE_OPERATORS_ON

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define ENABLE_FULL_OPERATORS_ON(T) ENABLE_BASE_OPERATORS_ON(T) inline T& operator++(T& d) { return d = T(int(d) + 1); } inline T& operator--(T& d) { return d = T(int(d) - 1); } inline T operator/(T d, int i) { return T(int(d) / i); } inline int operator/(T d1, T d2) { return int(d1) / int(d2); } inline T& operator/=(T& d, int i) { return d = T(int(d) / i); }
	#define ENABLE_FULL_OPERATORS_ON

	public static Value operator + (Value d1, Value d2)
	{
		return Value((int)d1 + (int)d2);
	}
	public static Value operator - (Value d1, Value d2)
	{
		return Value((int)d1 - (int)d2);
	}
	public static Value operator * (int i, Value d)
	{
		return Value(i * (int)d);
	}
	public static Value operator * (Value d, int i)
	{
		return Value((int)d * i);
	}
	public static Value operator - (Value d)
	{
		return Value(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Value operator += (Value d1, Value d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Value operator -= (Value d1, Value d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Value operator *= (Value d, int i)
	{
		return d = Value((int)d * i);
	}
	public static Value operator ++(Value d)
	{
		return d = Value((int)d + 1);
	}
	public static Value operator --(Value d)
	{
		return d = Value((int)d - 1);
	}
	public static Value operator / (Value d, int i)
	{
		return Value((int)d / i);
	}
	public static int operator / (Value d1, Value d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static Value operator /= (Value d, int i)
	{
		return d = Value((int)d / i);
	}
	public static PieceType operator + (PieceType d1, PieceType d2)
	{
		return PieceType((int)d1 + (int)d2);
	}
	public static PieceType operator - (PieceType d1, PieceType d2)
	{
		return PieceType((int)d1 - (int)d2);
	}
	public static PieceType operator * (int i, PieceType d)
	{
		return PieceType(i * (int)d);
	}
	public static PieceType operator * (PieceType d, int i)
	{
		return PieceType((int)d * i);
	}
	public static PieceType operator - (PieceType d)
	{
		return PieceType(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static PieceType operator += (PieceType d1, PieceType d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static PieceType operator -= (PieceType d1, PieceType d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static PieceType operator *= (PieceType d, int i)
	{
		return d = PieceType((int)d * i);
	}
	public static PieceType operator ++(PieceType d)
	{
		return d = PieceType((int)d + 1);
	}
	public static PieceType operator --(PieceType d)
	{
		return d = PieceType((int)d - 1);
	}
	public static PieceType operator / (PieceType d, int i)
	{
		return PieceType((int)d / i);
	}
	public static int operator / (PieceType d1, PieceType d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static PieceType operator /= (PieceType d, int i)
	{
		return d = PieceType((int)d / i);
	}
	public static Piece operator + (Piece d1, Piece d2)
	{
		return Piece((int)d1 + (int)d2);
	}
	public static Piece operator - (Piece d1, Piece d2)
	{
		return Piece((int)d1 - (int)d2);
	}
	public static Piece operator * (int i, Piece d)
	{
		return Piece(i * (int)d);
	}
	public static Piece operator * (Piece d, int i)
	{
		return Piece((int)d * i);
	}
	public static Piece operator - (Piece d)
	{
		return Piece(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Piece operator += (Piece d1, Piece d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Piece operator -= (Piece d1, Piece d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Piece operator *= (Piece d, int i)
	{
		return d = Piece((int)d * i);
	}
	public static Piece operator ++(Piece d)
	{
		return d = Piece((int)d + 1);
	}
	public static Piece operator --(Piece d)
	{
		return d = Piece((int)d - 1);
	}
	public static Piece operator / (Piece d, int i)
	{
		return Piece((int)d / i);
	}
	public static int operator / (Piece d1, Piece d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static Piece operator /= (Piece d, int i)
	{
		return d = Piece((int)d / i);
	}
	public static Color operator + (Color d1, Color d2)
	{
		return Color((int)d1 + (int)d2);
	}
	public static Color operator - (Color d1, Color d2)
	{
		return Color((int)d1 - (int)d2);
	}
	public static Color operator * (int i, Color d)
	{
		return Color(i * (int)d);
	}
	public static Color operator * (Color d, int i)
	{
		return Color((int)d * i);
	}
	public static Color operator - (Color d)
	{
		return Color(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Color operator += (Color d1, Color d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Color operator -= (Color d1, Color d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Color operator *= (Color d, int i)
	{
		return d = Color((int)d * i);
	}
	public static Color operator ++(Color d)
	{
		return d = Color((int)d + 1);
	}
	public static Color operator --(Color d)
	{
		return d = Color((int)d - 1);
	}
	public static Color operator / (Color d, int i)
	{
		return Color((int)d / i);
	}
	public static int operator / (Color d1, Color d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static Color operator /= (Color d, int i)
	{
		return d = Color((int)d / i);
	}
	public static Depth operator + (Depth d1, Depth d2)
	{
		return Depth((int)d1 + (int)d2);
	}
	public static Depth operator - (Depth d1, Depth d2)
	{
		return Depth((int)d1 - (int)d2);
	}
	public static Depth operator * (int i, Depth d)
	{
		return Depth(i * (int)d);
	}
	public static Depth operator * (Depth d, int i)
	{
		return Depth((int)d * i);
	}
	public static Depth operator - (Depth d)
	{
		return Depth(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Depth operator += (Depth d1, Depth d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Depth operator -= (Depth d1, Depth d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Depth operator *= (Depth d, int i)
	{
		return d = Depth((int)d * i);
	}
	public static Depth operator ++(Depth d)
	{
		return d = Depth((int)d + 1);
	}
	public static Depth operator --(Depth d)
	{
		return d = Depth((int)d - 1);
	}
	public static Depth operator / (Depth d, int i)
	{
		return Depth((int)d / i);
	}
	public static int operator / (Depth d1, Depth d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static Depth operator /= (Depth d, int i)
	{
		return d = Depth((int)d / i);
	}
	public static Square operator + (Square d1, Square d2)
	{
		return Square((int)d1 + (int)d2);
	}
	public static Square operator - (Square d1, Square d2)
	{
		return Square((int)d1 - (int)d2);
	}
	public static Square operator * (int i, Square d)
	{
		return Square(i * (int)d);
	}
	public static Square operator * (Square d, int i)
	{
		return Square((int)d * i);
	}
	public static Square operator - (Square d)
	{
		return Square(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Square operator += (Square d1, Square d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Square operator -= (Square d1, Square d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Square operator *= (Square d, int i)
	{
		return d = Square((int)d * i);
	}
	public static Square operator ++(Square d)
	{
		return d = Square((int)d + 1);
	}
	public static Square operator --(Square d)
	{
		return d = Square((int)d - 1);
	}
	public static Square operator / (Square d, int i)
	{
		return Square((int)d / i);
	}
	public static int operator / (Square d1, Square d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static Square operator /= (Square d, int i)
	{
		return d = Square((int)d / i);
	}
	public static File operator + (File d1, File d2)
	{
		return File((int)d1 + (int)d2);
	}
	public static File operator - (File d1, File d2)
	{
		return File((int)d1 - (int)d2);
	}
	public static File operator * (int i, File d)
	{
		return File(i * (int)d);
	}
	public static File operator * (File d, int i)
	{
		return File((int)d * i);
	}
	public static File operator - (File d)
	{
		return File(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static File operator += (File d1, File d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static File operator -= (File d1, File d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static File operator *= (File d, int i)
	{
		return d = File((int)d * i);
	}
	public static File operator ++(File d)
	{
		return d = File((int)d + 1);
	}
	public static File operator --(File d)
	{
		return d = File((int)d - 1);
	}
	public static File operator / (File d, int i)
	{
		return File((int)d / i);
	}
	public static int operator / (File d1, File d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static File operator /= (File d, int i)
	{
		return d = File((int)d / i);
	}
	public static Rank operator + (Rank d1, Rank d2)
	{
		return Rank((int)d1 + (int)d2);
	}
	public static Rank operator - (Rank d1, Rank d2)
	{
		return Rank((int)d1 - (int)d2);
	}
	public static Rank operator * (int i, Rank d)
	{
		return Rank(i * (int)d);
	}
	public static Rank operator * (Rank d, int i)
	{
		return Rank((int)d * i);
	}
	public static Rank operator - (Rank d)
	{
		return Rank(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Rank operator += (Rank d1, Rank d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Rank operator -= (Rank d1, Rank d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Rank operator *= (Rank d, int i)
	{
		return d = Rank((int)d * i);
	}
	public static Rank operator ++(Rank d)
	{
		return d = Rank((int)d + 1);
	}
	public static Rank operator --(Rank d)
	{
		return d = Rank((int)d - 1);
	}
	public static Rank operator / (Rank d, int i)
	{
		return Rank((int)d / i);
	}
	public static int operator / (Rank d1, Rank d2)
	{
		return (int)d1 / (int)d2;
	}
//C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
	public static Rank operator /= (Rank d, int i)
	{
		return d = Rank((int)d / i);
	}

	public static Score operator + (Score d1, Score d2)
	{
		return GlobalMembersSearch.Score((int)d1 + (int)d2);
	}
	public static Score operator - (Score d1, Score d2)
	{
		return GlobalMembersSearch.Score((int)d1 - (int)d2);
	}
	public static Score operator * (int i, Score d)
	{
		return GlobalMembersSearch.Score(i * (int)d);
	}
	public static Score operator * (Score d, int i)
	{
		return GlobalMembersSearch.Score((int)d * i);
	}
	public static Score operator - (Score d)
	{
		return GlobalMembersSearch.Score(-(int)d);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Score operator += (Score d1, Score d2)
	{
		return d1 = d1 + d2;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Score operator -= (Score d1, Score d2)
	{
		return d1 = d1 - d2;
	}
//C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
	public static Score operator *= (Score d, int i)
	{
		return d = GlobalMembersSearch.Score((int)d * i);
	}

	#undef ENABLE_FULL_OPERATORS_ON
	#undef ENABLE_BASE_OPERATORS_ON

	/// Additional operators to add integers to a Value
	public static Value operator + (Value v, int i)
	{
		return Value((int)v + i);
	}
	public static Value operator - (Value v, int i)
	{
		return Value((int)v - i);
	}
//C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
	public static Value operator += (Value v, int i)
	{
		return v = v + i;
	}
//C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
	public static Value operator -= (Value v, int i)
	{
		return v = v - i;
	}

	/// Only declared but not defined. We don't want to multiply two scores due to
	/// a very high risk of overflow. So user should explicitly convert to integer.
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Score operator *(Score s1, Score s2);

	/// Division of a Score must be handled separately for each term
	public static Score operator / (Score s, int i)
	{
	  return GlobalMembersBenchmark.make_score(GlobalMembersBenchmark.mg_value(s) / i, GlobalMembersBenchmark.eg_value(s) / i);
	}

	public static Color operator ~(Color c)
	{
	  return Color(c ^ Color.BLACK); // Toggle color
	}

	public static Square operator ~(Square s)
	{
	  return Square(s ^ Square.SQ_A8); // Vertical flip SQ_A1 -> SQ_A8
	}

	public static Piece operator ~(Piece pc)
	{
	  return Piece(pc ^ 8); // Swap color of piece B_KNIGHT -> W_KNIGHT
	}

	public static CastlingRight operator | (Color c, CastlingSide s)
	{
	  return CastlingRight(CastlingRight.WHITE_OO << ((s == CastlingSide.QUEEN_SIDE) + 2 * c));
	}

	public static Value mate_in(int ply)
	{
	  return Value.VALUE_MATE - ply;
	}

	public static Value mated_in(int ply)
	{
	  return -Value.VALUE_MATE + ply;
	}

	public static Square make_square(File f, Rank r)
	{
	  return Square((r << 3) + f);
	}

	public static Piece make_piece(Color c, PieceType pt)
	{
	  return Piece((c << 3) + pt);
	}

	public static PieceType type_of(Piece pc)
	{
	  return PieceType((int)pc & 7);
	}

	public static Color color_of(Piece pc)
	{
	  Debug.Assert(pc != Piece.NO_PIECE);
	  return Color(pc >> 3);
	}

	public static bool is_ok(Square s)
	{
	  return s >= Square.SQ_A1 && s <= Square.SQ_H8;
	}

	public static File file_of(Square s)
	{
	  return File((int)s & 7);
	}

	public static Rank rank_of(Square s)
	{
	  return Rank(s >> 3);
	}

	public static Square relative_square(Color c, Square s)
	{
	  return Square(s ^ (c * 56));
	}

	public static Rank relative_rank(Color c, Rank r)
	{
	  return Rank(r ^ (c * 7));
	}

	public static Rank relative_rank(Color c, Square s)
	{
	  return GlobalMembersBenchmark.relative_rank(c, GlobalMembersBenchmark.rank_of(s));
	}

	public static bool opposite_colors(Square s1, Square s2)
	{
	  int s = (int)s1 ^ (int)s2;
	  return ((s >> 3) ^ s) & 1;
	}

	public static Square pawn_push(Color c)
	{
	  return c == ((int)Color.WHITE) != 0 ? Square.NORTH : Square.SOUTH;
	}

	public static Square from_sq(Move m)
	{
	  return Square((m >> 6) & 0x3F);
	}

	public static Square to_sq(Move m)
	{
	  return Square((int)m & 0x3F);
	}

	public static MoveType type_of(Move m)
	{
	  return MoveType((int)m & (3 << 14));
	}

	public static PieceType promotion_type(Move m)
	{
	  return PieceType(((m >> 12) & 3) + PieceType.KNIGHT);
	}

	public static Move make_move(Square from, Square to)
	{
	  return Move((from << 6) + to);
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<MoveType T>
public static Move make<MoveType T>(Square from, Square to)
{
	return make(from, to, PieceType.KNIGHT);
}
//C++ TO C# CONVERTER NOTE: Overloaded method(s) are created above to convert the following method having default parameters:
//ORIGINAL LINE: inline Move make(Square from, Square to, PieceType pt = KNIGHT)
	public static Move make<MoveType T>(Square from, Square to, PieceType pt)
	{
	  return Move(T + ((pt - PieceType.KNIGHT) << 12) + (from << 6) + to);
	}

	public static bool is_ok(Move m)
	{
	  return GlobalMembersBenchmark.from_sq(m) != GlobalMembersBenchmark.to_sq(m); // Catch MOVE_NULL and MOVE_NONE
	}

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void init();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//bool probe(Square wksq, Square wpsq, Square bksq, Color us);

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void init();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//string pretty(ulong b);

	public const ulong DarkSquares = 0xAA55AA55AA55AA55UL;

	public const ulong FileABB = 0x0101010101010101UL;
	public static ulong FileBBB = FileABB << 1;
	public static ulong FileCBB = FileABB << 2;
	public static ulong FileDBB = FileABB << 3;
	public static ulong FileEBB = FileABB << 4;
	public static ulong FileFBB = FileABB << 5;
	public static ulong FileGBB = FileABB << 6;
	public static ulong FileHBB = FileABB << 7;

	public const ulong Rank1BB = 0xFF;
	public static ulong Rank2BB = Rank1BB << (8 * 1);
	public static ulong Rank3BB = Rank1BB << (8 * 2);
	public static ulong Rank4BB = Rank1BB << (8 * 3);
	public static ulong Rank5BB = Rank1BB << (8 * 4);
	public static ulong Rank6BB = Rank1BB << (8 * 5);
	public static ulong Rank7BB = Rank1BB << (8 * 6);
	public static ulong Rank8BB = Rank1BB << (8 * 7);

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern int SquareDistance[SQUARE_NB][SQUARE_NB];

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong SquareBB[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong FileBB[FILE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong RankBB[RANK_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong AdjacentFilesBB[FILE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong InFrontBB[COLOR_NB][RANK_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong StepAttacksBB[PIECE_NB][SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong BetweenBB[SQUARE_NB][SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong LineBB[SQUARE_NB][SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong DistanceRingBB[SQUARE_NB][8];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong ForwardBB[COLOR_NB][SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong PassedPawnMask[COLOR_NB][SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong PawnAttackSpan[COLOR_NB][SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ulong PseudoAttacks[PIECE_TYPE_NB][SQUARE_NB];


	/// Overloads of bitwise operators between a Bitboard and a Square for testing
	/// whether a given bit is set in a bitboard, and for setting and clearing bits.

	public static ulong operator & (ulong b, Square s)
	{
	  return b & GlobalMembersBitboard.SquareBB[(int)s];
	}

	public static ulong operator | (ulong b, Square s)
	{
	  return b | GlobalMembersBitboard.SquareBB[(int)s];
	}

	public static ulong operator ^ (ulong b, Square s)
	{
	  return b ^ GlobalMembersBitboard.SquareBB[(int)s];
	}

//C++ TO C# CONVERTER TODO TASK: The |= operator cannot be overloaded in C#:
	public static ulong operator |= (ref ulong b, Square s)
	{
	  return b |= GlobalMembersBitboard.SquareBB[(int)s];
	}

//C++ TO C# CONVERTER TODO TASK: The ^= operator cannot be overloaded in C#:
	public static ulong operator ^= (ref ulong b, Square s)
	{
	  return b ^= GlobalMembersBitboard.SquareBB[(int)s];
	}

	public static bool more_than_one(ulong b)
	{
	  return b & (b - 1);
	}


	/// rank_bb() and file_bb() return a bitboard representing all the squares on
	/// the given file or rank.

	public static ulong rank_bb(Rank r)
	{
	  return GlobalMembersBitboard.RankBB[(int)r];
	}

	public static ulong rank_bb(Square s)
	{
	  return GlobalMembersBitboard.RankBB[(int)GlobalMembersBenchmark.rank_of(s)];
	}

	public static ulong file_bb(File f)
	{
	  return GlobalMembersBitboard.FileBB[(int)f];
	}

	public static ulong file_bb(Square s)
	{
	  return GlobalMembersBitboard.FileBB[(int)GlobalMembersBenchmark.file_of(s)];
	}


	/// shift() moves a bitboard one step along direction D. Mainly for pawns

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Square D>
	public static ulong shift<Square D>(ulong b)
	{
	  return D == ((int)Square.NORTH) != 0 ? b << 8 : D == ((int)Square.SOUTH) != 0 ? b >> 8 : D == ((int)Square.NORTH_EAST) != 0 ? (b & ~FileHBB) << 9 : D == ((int)Square.SOUTH_EAST) != 0 ? (b & ~FileHBB) >> 7 : D == ((int)Square.NORTH_WEST) != 0 ? (b & ~FileABB) << 7 : D == ((int)Square.SOUTH_WEST) != 0 ? (b & ~FileABB) >> 9 : 0;
	}


	/// adjacent_files_bb() returns a bitboard representing all the squares on the
	/// adjacent files of the given one.

	public static ulong adjacent_files_bb(File f)
	{
	  return GlobalMembersBitboard.AdjacentFilesBB[(int)f];
	}


	/// between_bb() returns a bitboard representing all the squares between the two
	/// given ones. For instance, between_bb(SQ_C4, SQ_F7) returns a bitboard with
	/// the bits for square d5 and e6 set. If s1 and s2 are not on the same rank, file
	/// or diagonal, 0 is returned.

	public static ulong between_bb(Square s1, Square s2)
	{
	  return GlobalMembersBitboard.BetweenBB[(int)s1, (int)s2];
	}


	/// in_front_bb() returns a bitboard representing all the squares on all the ranks
	/// in front of the given one, from the point of view of the given color. For
	/// instance, in_front_bb(BLACK, RANK_3) will return the squares on ranks 1 and 2.

	public static ulong in_front_bb(Color c, Rank r)
	{
	  return GlobalMembersBitboard.InFrontBB[(int)c, (int)r];
	}


	/// forward_bb() returns a bitboard representing all the squares along the line
	/// in front of the given one, from the point of view of the given color:
	///        ForwardBB[c][s] = in_front_bb(c, s) & file_bb(s)

	public static ulong forward_bb(Color c, Square s)
	{
	  return GlobalMembersBitboard.ForwardBB[(int)c, (int)s];
	}


	/// pawn_attack_span() returns a bitboard representing all the squares that can be
	/// attacked by a pawn of the given color when it moves along its file, starting
	/// from the given square:
	///       PawnAttackSpan[c][s] = in_front_bb(c, s) & adjacent_files_bb(s);

	public static ulong pawn_attack_span(Color c, Square s)
	{
	  return GlobalMembersBitboard.PawnAttackSpan[(int)c, (int)s];
	}


	/// passed_pawn_mask() returns a bitboard mask which can be used to test if a
	/// pawn of the given color and on the given square is a passed pawn:
	///       PassedPawnMask[c][s] = pawn_attack_span(c, s) | forward_bb(c, s)

	public static ulong passed_pawn_mask(Color c, Square s)
	{
	  return GlobalMembersBitboard.PassedPawnMask[(int)c, (int)s];
	}


	/// aligned() returns true if the squares s1, s2 and s3 are aligned either on a
	/// straight or on a diagonal line.

	public static bool aligned(Square s1, Square s2, Square s3)
	{
	  return GlobalMembersBitboard.LineBB[(int)s1, (int)s2] & (int)s3;
	}


	/// distance() functions return the distance between x and y, defined as the
	/// number of steps for a king in x to reach y. Works with squares, ranks, files.

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
	public static int distance<T>(T x, T y)
	{
		return x < y != null ? y - x : x - y;
	}
	public static int distance(Square x, Square y)
	{
		return GlobalMembersBitboard.SquareDistance[(int)x, (int)y];
	}

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T1, typename T2>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//int distance<T1, T2>(T2 x, T2 y);
	public static int distance<T1, T2>(Square x, Square y)
	{
		return GlobalMembersBenchmark.distance(GlobalMembersBenchmark.file_of(x), GlobalMembersBenchmark.file_of(y));
	}
	public static int distance(Square x, Square y)
	{
		return GlobalMembersBenchmark.distance(GlobalMembersBenchmark.rank_of(x), GlobalMembersBenchmark.rank_of(y));
	}


	/// attacks_bb() returns a bitboard representing all the squares attacked by a
	/// piece of type Pt (bishop or rook) placed on 's'. The helper magic_index()
	/// looks up the index using the 'magic bitboards' approach.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt>
	public static uint magic_index<PieceType Pt>(Square s, ulong occupied)
	{

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern ulong RookMasks[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern ulong RookMagics[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern uint RookShifts[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern ulong BishopMasks[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern ulong BishopMagics[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern uint BishopShifts[SQUARE_NB];

	  ulong[] Masks = Pt == ((int)PieceType.ROOK) != 0 ? GlobalMembersBitboard.RookMasks : GlobalMembersBitboard.BishopMasks;
	  ulong[] Magics = Pt == ((int)PieceType.ROOK) != 0 ? GlobalMembersBitboard.RookMagics : GlobalMembersBitboard.BishopMagics;
	  uint[] Shifts = Pt == ((int)PieceType.ROOK) != 0 ? GlobalMembersBitboard.RookShifts : GlobalMembersBitboard.BishopShifts;

	  if (HasPext)
	  {
		  return (uint)((b, m)(0)(occupied, Masks[(int)s]));
	  }

	  if (Is64Bit)
	  {
		  return (uint)(((occupied & Masks[(int)s]) * Magics[(int)s]) >> (int)Shifts[(int)s]);
	  }

	  uint lo = (uint)occupied & (uint)Masks[(int)s];
	  uint hi = (uint)(occupied >> 32) & (uint)(Masks[(int)s] >> 32);
	  return (lo * (uint)Magics[(int)s] ^ hi * (uint)(Magics[(int)s] >> 32)) >> (int)Shifts[(int)s];
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt>
	public static ulong attacks_bb<PieceType Pt>(Square s, ulong occupied)
	{

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern ulong* RookAttacks[SQUARE_NB];
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern ulong* BishopAttacks[SQUARE_NB];

	  return (Pt == ((int)PieceType.ROOK) != 0 ? GlobalMembersBitboard.RookAttacks : GlobalMembersBitboard.BishopAttacks)[(int)s][magic_index<Pt>(s, occupied)];
	}

	public static ulong attacks_bb(Piece pc, Square s, ulong occupied)
	{

	  switch (GlobalMembersBenchmark.type_of(pc))
	  {
	  case PieceType.BISHOP:
		  return attacks_bb<PieceType.BISHOP>(s, occupied);
	  case PieceType.ROOK :
		  return attacks_bb<PieceType.ROOK>(s, occupied);
	  case PieceType.QUEEN :
		  return attacks_bb<PieceType.BISHOP>(s, occupied) | attacks_bb<PieceType.ROOK>(s, occupied);
	  default :
		  return GlobalMembersBitboard.StepAttacksBB[(int)pc, (int)s];
	  }
	}


	/// popcount() counts the number of non-zero bits in a bitboard

	public static int popcount(ulong b)
	{

	#if ! USE_POPCNT

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern byte PopCnt16[1 << 16];
//C++ TO C# CONVERTER TODO TASK: Unions within methods are not supported in C#:
	//  union
	//  {
	//	  ulong bb;
	//	  ushort u[4];
	//  }
	  v = {b};
	  return GlobalMembersBitboard.PopCnt16[v.u[0]] + GlobalMembersBitboard.PopCnt16[v.u[1]] + GlobalMembersBitboard.PopCnt16[v.u[2]] + GlobalMembersBitboard.PopCnt16[v.u[3]];

	#elif _MSC_VER || __INTEL_COMPILER

	  return (int)_mm_popcnt_u64(b);

	#else

	  return __builtin_popcountll(b);

	#endif
	}


	/// lsb() and msb() return the least/most significant bit in a non-zero bitboard

	#if __GNUC__

	public static Square lsb(ulong b)
	{
	  Debug.Assert(b);
	  return Square(__builtin_ctzll(b));
	}

	public static Square msb(ulong b)
	{
	  Debug.Assert(b);
	  return Square(63 - __builtin_clzll(b));
	}

	#elif _WIN64 && _MSC_VER

	public static Square lsb(ulong b)
	{
	  Debug.Assert(b);
	  uint idx;
	  _BitScanForward64(idx, b);
	  return (Square) idx;
	}

	public static Square msb(ulong b)
	{
	  Debug.Assert(b);
	  uint idx;
	  _BitScanReverse64(idx, b);
	  return (Square) idx;
	}

	#else

	#define NO_BSF

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Square lsb(ulong b);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Square msb(ulong b);

	#endif


	/// pop_lsb() finds and clears the least significant bit in a non-zero bitboard

	public static Square pop_lsb(ref ulong b)
	{
	  Square s = GlobalMembersBenchmark.lsb(b);
	  b &= b - 1;
	  return s;
	}


	/// frontmost_sq() and backmost_sq() return the square corresponding to the
	/// most/least advanced bit relative to the given color.

	public static Square frontmost_sq(Color c, ulong b)
	{
		return c == ((int)Color.WHITE) != 0 ? GlobalMembersBenchmark.msb(b) : GlobalMembersBenchmark.lsb(b);
	}
	public static Square backmost_sq(Color c, ulong b)
	{
		return c == ((int)Color.WHITE) != 0 ? GlobalMembersBenchmark.lsb(b) : GlobalMembersBenchmark.msb(b);
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




//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
	//class Position;

	public static Value Tempo = new Value(20); // Must be visible to search

/// trace() is like evaluate(), but instead of returning a value, it returns
/// a string (suitable for outputting to stdout) that contains the detailed
/// descriptions and values of each evaluation term. Useful for debugging.


	public static string trace(Position pos)
	{

	  std.memset(scores, 0, sizeof(scores));

	  Value v = evaluate<true>(pos);
	  v = pos.side_to_move() == ((int)Color.WHITE) != 0 ? v : -v; // White's point of view

	  std.stringstream ss = new std.stringstream();
	  ss << std.showpoint << std.noshowpos << std.@fixed << std.setprecision(2) << "      Eval term |    White    |    Black    |    Total    \n" << "                |   MG    EG  |   MG    EG  |   MG    EG  \n" << "----------------+-------------+-------------+-------------\n" << "       Material | " << Term(MATERIAL) << "      Imbalance | " << Term(IMBALANCE) << "          Pawns | " << Term(PieceType.PAWN) << "        Knights | " << Term(PieceType.KNIGHT) << "         Bishop | " << Term(PieceType.BISHOP) << "          Rooks | " << Term(PieceType.ROOK) << "         Queens | " << Term(PieceType.QUEEN) << "       Mobility | " << Term(MOBILITY) << "    King safety | " << Term(PieceType.KING) << "        Threats | " << Term(THREAT) << "   Passed pawns | " << Term(PASSED) << "          Space | " << Term(SPACE) << "----------------+-------------+-------------+-------------\n" << "          Total | " << Term(TOTAL);

	  ss << "\nTotal Evaluation: " << GlobalMembersEvaluate.to_cp(v) << " (white side)\n";

	  return ss.str();
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool DoTrace = false>

/// evaluate() is the main evaluation function. It returns a static evaluation
/// of the position from the point of view of the side to move.

	public static Value evaluate<bool DoTrace = false>(Position pos)
	{

	  Debug.Assert(pos.checkers() == 0);

	  Score[] mobility = {Score.SCORE_ZERO, Score.SCORE_ZERO};
	  EvalInfo ei = new EvalInfo();

	  // Probe the material hash table
	  ei.me = GlobalMembersMaterial.probe(pos);

	  // If we have a specialized evaluation function for the current material
	  // configuration, call it and return.
	  if (ei.me.specialized_eval_exists())
	  {
		  return ei.me.evaluate(pos);
	  }

	  // Initialize score by reading the incrementally updated scores included in
	  // the position object (material + piece square tables) and the material
	  // imbalance. Score is computed internally from the white point of view.
	  Score score = pos.psq_score() + ei.me.imbalance();

	  // Probe the pawn hash table
	  ei.pi = GlobalMembersMaterial.probe(pos);
	  score += ei.pi.pawns_score();

	  // Initialize attack and king safety bitboards
	  ei.attackedBy[(int)Color.WHITE, (int)PieceType.ALL_PIECES] = ei.attackedBy[(int)Color.BLACK, (int)PieceType.ALL_PIECES] = 0;
	  ei.attackedBy[(int)Color.WHITE, (int)PieceType.KING] = pos.attacks_from<PieceType.KING>(pos.square<PieceType.KING>(Color.WHITE));
	  ei.attackedBy[(int)Color.BLACK, (int)PieceType.KING] = pos.attacks_from<PieceType.KING>(pos.square<PieceType.KING>(Color.BLACK));
	  eval_init<Color.WHITE>(pos, ei);
	  eval_init<Color.BLACK>(pos, ei);

	  // Pawns blocked or on ranks 2 and 3 will be excluded from the mobility area
	  ulong[] blockedPawns = {pos.pieces(Color.WHITE, PieceType.PAWN) & (shift<Square.SOUTH>(pos.pieces()) | Rank2BB | Rank3BB), pos.pieces(Color.BLACK, PieceType.PAWN) & (shift<Square.NORTH>(pos.pieces()) | Rank7BB | Rank6BB)};

	  // Do not include in mobility area squares protected by enemy pawns, or occupied
	  // by our blocked pawns or king.
	  ulong[] mobilityArea = {~(ei.attackedBy[(int)Color.BLACK, (int)PieceType.PAWN] | blockedPawns[(int)Color.WHITE] | (int)pos.square<PieceType.KING>(Color.WHITE)), ~(ei.attackedBy[(int)Color.WHITE, (int)PieceType.PAWN] | blockedPawns[(int)Color.BLACK] | (int)pos.square<PieceType.KING>(Color.BLACK))};

	  // Evaluate all pieces but king and pawns
	  score += evaluate_pieces<DoTrace>(pos, ei, mobility, mobilityArea);
	  score += mobility[(int)Color.WHITE] - mobility[(int)Color.BLACK];

	  // Evaluate kings after all other pieces because we need full attack
	  // information when computing the king safety evaluation.
	  score += evaluate_king<Color.WHITE, DoTrace>(pos, ei) - evaluate_king<Color.BLACK, DoTrace>(pos, ei);

	  // Evaluate tactical threats, we need full attack information including king
	  score += evaluate_threats<Color.WHITE, DoTrace>(pos, ei) - evaluate_threats<Color.BLACK, DoTrace>(pos, ei);

	  // Evaluate passed pawns, we need full attack information including king
	  score += evaluate_passed_pawns<Color.WHITE, DoTrace>(pos, ei) - evaluate_passed_pawns<Color.BLACK, DoTrace>(pos, ei);

	  // If both sides have only pawns, score for potential unstoppable pawns
	  if (((int)pos.non_pawn_material(Color.WHITE)) == 0 && ((int)pos.non_pawn_material(Color.BLACK)) == 0)
	  {
		  ulong b;
		  if ((b = ei.pi.passed_pawns(Color.WHITE)) != 0)
		  {
			  score += Unstoppable * (int)GlobalMembersBenchmark.relative_rank(Color.WHITE, GlobalMembersBenchmark.frontmost_sq(Color.WHITE, b));
		  }

		  if ((b = ei.pi.passed_pawns(Color.BLACK)) != 0)
		  {
			  score -= Unstoppable * (int)GlobalMembersBenchmark.relative_rank(Color.BLACK, GlobalMembersBenchmark.frontmost_sq(Color.BLACK, b));
		  }
	  }

	  // Evaluate space for both sides, only during opening
	  if (pos.non_pawn_material(Color.WHITE) + pos.non_pawn_material(Color.BLACK) >= 12222)
	  {
		  score += evaluate_space<Color.WHITE>(pos, ei) - evaluate_space<Color.BLACK>(pos, ei);
	  }

	  // Evaluate position potential for the winning side
	  score += GlobalMembersEvaluate.evaluate_initiative(pos, ei.pi.pawn_asymmetry(), GlobalMembersBenchmark.eg_value(score));

	  // Evaluate scale factor for the winning side
	  ScaleFactor sf = GlobalMembersEvaluate.evaluate_scale_factor(pos, ei, GlobalMembersBenchmark.eg_value(score));

	  // Interpolate between a middlegame and a (scaled by 'sf') endgame score
	  Value v = GlobalMembersBenchmark.mg_value(score) * (int)ei.me.game_phase() + GlobalMembersBenchmark.eg_value(score) * (int)(Phase.PHASE_MIDGAME - ei.me.game_phase()) * sf / ScaleFactor.SCALE_FACTOR_NORMAL;

	  v /= (int)Phase.PHASE_MIDGAME;

	  // In case of tracing add all remaining individual evaluation terms
	  if (DoTrace)
	  {
		  GlobalMembersEvaluate.add(MATERIAL, pos.psq_score());
		  GlobalMembersEvaluate.add(IMBALANCE, ei.me.imbalance());
		  GlobalMembersEvaluate.add(PieceType.PAWN, ei.pi.pawns_score());
		  GlobalMembersEvaluate.add(MOBILITY, mobility[(int)Color.WHITE], mobility[(int)Color.BLACK]);
		  GlobalMembersEvaluate.add(SPACE, evaluate_space<Color.WHITE>(pos, ei), evaluate_space<Color.BLACK>(pos, ei));
		  GlobalMembersEvaluate.add(TOTAL, score);
	  }

	  return (pos.side_to_move() == ((int)Color.WHITE) != 0 ? v : -v) + Tempo; // Side to move point of view
	}

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//std::ostream operator <<<bool Do>(std::ostream os, Position pos);


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




//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//string engine_info(bool to_uci);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void prefetch(object addr);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void start_logger(string fname);

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void dbg_hit_on(bool b);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void dbg_hit_on(bool c, bool b);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void dbg_mean_of(int v);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void dbg_print();


	public static std.chrono.milliseconds.rep now()
	{
	  return std.chrono.duration_cast<std.chrono.milliseconds> (std.chrono.steady_clock.now().time_since_epoch()).count();
	}

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<class Entry, int Size>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//std::ostream operator <<(std::ostream NamelessParameter1, SyncCout NamelessParameter2);


//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Entry probe(Position pos);


//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void init<Color Us>();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Entry probe<Color Us>(Position pos);

		public static double[,,] scores = new double[(int)Term.TERM_NB, Color.COLOR_NB, (int)Phase.PHASE_NB];

		public static double to_cp<Color Us>(Value v)
		{
			return (double)v / Value.PawnValueEg;
		}

		public static void add(int idx, Color c, Score s)
		{
		  scores[idx, c, (int)Phase.MG] = GlobalMembersEvaluate.to_cp(GlobalMembersBenchmark.mg_value(s));
		  scores[idx, c, (int)Phase.EG] = GlobalMembersEvaluate.to_cp(GlobalMembersBenchmark.eg_value(s));
		}
	public static void add(int idx, Score w)
	{
		add(idx, w, Score.SCORE_ZERO);
	}

//C++ TO C# CONVERTER NOTE: Overloaded method(s) are created above to convert the following method having default parameters:
//ORIGINAL LINE: void add(int idx, Score w, Score b = SCORE_ZERO)
		public static void add(int idx, Score w, Score b)
		{
		  GlobalMembersEvaluate.add(idx, Color.WHITE, w);
		  GlobalMembersEvaluate.add(idx, Color.BLACK, b);
		}

		public static std.ostream operator << (std.ostream os, Term t)
		{

		  if (t == Term.MATERIAL || t == Term.IMBALANCE || t == Term(PieceType.PAWN) || t == Term.TOTAL)
		  {
			  os << "  ---   --- |   ---   --- | ";
		  }
		  else
		  {
			  os << std.setw(5) << scores[(int)t, (int)Color.WHITE, (int)Phase.MG] << " " << std.setw(5) << scores[(int)t, (int)Color.WHITE, (int)Phase.EG] << " | " << std.setw(5) << scores[(int)t, (int)Color.BLACK, (int)Phase.MG] << " " << std.setw(5) << scores[(int)t, (int)Color.BLACK, (int)Phase.EG] << " | ";
		  }

		  os << std.setw(5) << scores[(int)t, (int)Color.WHITE, (int)Phase.MG] - scores[(int)t, (int)Color.BLACK, (int)Phase.MG] << " " << std.setw(5) << scores[(int)t, (int)Color.WHITE, (int)Phase.EG] - scores[(int)t, (int)Color.BLACK, (int)Phase.EG] << " \n";

		  return os;
		}

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define V(v) Value(v)
	  #define V
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define S(mg, eg) make_score(mg, eg)
	  #define S

	  // MobilityBonus[PieceType][attacked] contains bonuses for middle and end
	  // game, indexed by piece type and number of attacked squares in the MobilityArea.
	  public static readonly Score[,] MobilityBonus =
	  {
		  {, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null},
		  {, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null},
		  {make_score(-75, -76), make_score(-56, -54), make_score(-9, -26), make_score(-2, -10), make_score(6, 5), make_score(15, 11), make_score(22, 26), make_score(30, 28), make_score(36, 29), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null},
		  {make_score(-48, -58), make_score(-21, -19), make_score(16, -2), make_score(26, 12), make_score(37, 22), make_score(51, 42), make_score(54, 54), make_score(63, 58), make_score(65, 63), make_score(71, 70), make_score(79, 74), make_score(81, 86), make_score(92, 90), make_score(97, 94), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null},
		  {make_score(-56, -78), make_score(-25, -18), make_score(-11, 26), make_score(-5, 55), make_score(-4, 70), make_score(-1, 81), make_score(8, 109), make_score(14, 120), make_score(21, 128), make_score(23, 143), make_score(31, 154), make_score(32, 160), make_score(43, 165), make_score(49, 168), make_score(59, 169), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null},
		  {make_score(-40, -35), make_score(-25, -12), make_score(2, 7), make_score(4, 19), make_score(14, 37), make_score(24, 55), make_score(25, 62), make_score(40, 76), make_score(43, 79), make_score(47, 87), make_score(54, 94), make_score(56, 102), make_score(60, 111), make_score(70, 116), make_score(72, 118), make_score(73, 122), make_score(75, 128), make_score(77, 130), make_score(85, 133), make_score(94, 136), make_score(99, 140), make_score(108, 157), make_score(112, 158), make_score(113, 161), make_score(118, 174), make_score(119, 177), make_score(123, 191), make_score(128, 199), null, null, null, null}
	  };

	  // Outpost[knight/bishop][supported by pawn] contains bonuses for knights and
	  // bishops outposts, bigger if outpost piece is supported by a pawn.
	  public static readonly Score[,] Outpost =
	  {
		  {make_score(43, 11), make_score(65, 20)},
		  {make_score(20, 3), make_score(29, 8)}
	  };

	  // ReachableOutpost[knight/bishop][supported by pawn] contains bonuses for
	  // knights and bishops which can reach an outpost square in one move, bigger
	  // if outpost square is supported by a pawn.
	  public static readonly Score[,] ReachableOutpost =
	  {
		  {make_score(21, 5), make_score(35, 8)},
		  {make_score(8, 0), make_score(14, 4)}
	  };

	  // RookOnFile[semiopen/open] contains bonuses for each rook when there is no
	  // friendly pawn on the rook file.
	  public static readonly Score[] RookOnFile = {make_score(20, 7), make_score(45, 20)};

	  // ThreatBySafePawn[PieceType] contains bonuses according to which piece
	  // type is attacked by a pawn which is protected or is not attacked.
	  public static readonly Score[] ThreatBySafePawn = {make_score(0, 0), make_score(0, 0), make_score(176, 139), make_score(131, 127), make_score(217, 218), make_score(203, 215)};

	  // Threat[by minor/by rook][attacked PieceType] contains
	  // bonuses according to which piece type attacks which one.
	  // Attacks on lesser pieces which are pawn-defended are not considered.
	  public static readonly Score[,] Threat =
	  {
		  {make_score(0, 0), make_score(0, 33), make_score(45, 43), make_score(46, 47), make_score(72, 107), make_score(48, 118)},
		  {make_score(0, 0), make_score(0, 25), make_score(40, 62), make_score(40, 59), make_score(0, 34), make_score(35, 48)}
	  };

	  // ThreatByKing[on one/on many] contains bonuses for King attacks on
	  // pawns or pieces which are not pawn-defended.
	  public static readonly Score[] ThreatByKing = {make_score(3, 62), make_score(9, 138)};

	  // Passed[mg/eg][Rank] contains midgame and endgame bonuses for passed pawns.
	  // We don't use a Score because we process the two components independently.
	  public static readonly Value[,] Passed =
	  {
		  {Value(5), Value(5), Value(31), Value(73), Value(166), Value(252)},
		  {Value(7), Value(14), Value(38), Value(73), Value(166), Value(252)}
	  };

	  // PassedFile[File] contains a bonus according to the file of a passed pawn
	  public static readonly Score[] PassedFile = {make_score(9, 10), make_score(2, 10), make_score(1, -8), make_score(-20, -12), make_score(-20, -12), make_score(1, -8), make_score(2, 10), make_score(9, 10)};

	  // Assorted bonuses and penalties used by evaluation
	  public static Score MinorBehindPawn = make_score(16, 0);
	  public static Score BishopPawns = make_score(8, 12);
	  public static Score RookOnPawn = make_score(8, 24);
	  public static Score TrappedRook = make_score(92, 0);
	  public static Score CloseEnemies = make_score(7, 0);
	  public static Score SafeCheck = make_score(20, 20);
	  public static Score OtherCheck = make_score(10, 10);
	  public static Score ThreatByHangingPawn = make_score(71, 61);
	  public static Score LooseEnemies = make_score(0, 25);
	  public static Score WeakQueen = make_score(35, 0);
	  public static Score Hanging = make_score(48, 27);
	  public static Score ThreatByPawnPush = make_score(38, 22);
	  public static Score Unstoppable = make_score(0, 20);
	  public static Score PawnlessFlank = make_score(20, 80);
	  public static Score HinderPassedPawn = make_score(7, 0);

	  // Penalty for a bishop on a1/h1 (a8/h8 for black) which is trapped by
	  // a friendly pawn on b2/g2 (b7/g7 for black). This can obviously only
	  // happen in Chess960 games.
	  public static Score TrappedBishopA1H1 = make_score(50, 50);

	  #undef S
	  #undef V

	  // KingAttackWeights[PieceType] contains king attack weights by piece type
	  public static readonly int[] KingAttackWeights = {0, 0, 78, 56, 45, 11};

	  // Penalties for enemy's safe checks
	  public const int QueenContactCheck = 997;
	  public const int QueenCheck = 695;
	  public const int RookCheck = 638;
	  public const int BishopCheck = 538;
	  public const int KnightCheck = 874;


	  // eval_init() initializes king and attack bitboards for a given color
	  // adding pawn attacks. To be done at the beginning of the evaluation.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static void eval_init<Color Us>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		Square Down = (Us == ((int)Color.WHITE) != 0 ? Square.SOUTH : Square.NORTH);

		ei.pinnedPieces[Us] = pos.pinned_pieces(Us);
		ulong b = ei.attackedBy[(int)Them, (int)PieceType.KING];
		ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] |= b;
		ei.attackedBy[Us, (int)PieceType.ALL_PIECES] |= ei.attackedBy[Us, (int)PieceType.PAWN] = ei.pi.pawn_attacks(Us);
		ei.attackedBy2[Us] = ei.attackedBy[Us, (int)PieceType.PAWN] & ei.attackedBy[Us, (int)PieceType.KING];

		// Init king safety tables only if we are going to use them
		if (pos.non_pawn_material(Us) >= Value.QueenValueMg)
		{
			ei.kingRing[(int)Them] = b | shift<Down>(b);
			b &= ei.attackedBy[Us, (int)PieceType.PAWN];
			ei.kingAttackersCount[Us] = GlobalMembersBenchmark.popcount(b);
			ei.kingAdjacentZoneAttacksCount[Us] = ei.kingAttackersWeight[Us] = 0;
		}
		else
		{
			ei.kingRing[(int)Them] = ei.kingAttackersCount[Us] = 0;
		}
	  }


	  // evaluate_pieces() assigns bonuses and penalties to the pieces of a given
	  // color and type.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool DoTrace, Color Us = WHITE, PieceType Pt = KNIGHT>
	  public static Score evaluate_pieces<bool DoTrace, Color Us = WHITE, PieceType Pt = KNIGHT>(Position pos, EvalInfo ei, Score[] mobility, ulong[] mobilityArea)
	  {
		ulong b;
		ulong bb;
		Square s;
		Score score = Score.SCORE_ZERO;

		PieceType NextPt = (Us == ((int)Color.WHITE) != 0 ? Pt : PieceType(Pt + 1));
		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		ulong OutpostRanks = (Us == ((int)Color.WHITE) != 0 ? Rank4BB | Rank5BB | Rank6BB : Rank5BB | Rank4BB | Rank3BB);
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
		Square * pl = pos.squares<Pt>(Us);

		ei.attackedBy[Us, Pt] = 0;

		while ((s = pl++) != Square.SQ_NONE)
		{
			// Find attacked squares, including x-ray attacks for bishops and rooks
			b = Pt == ((int)PieceType.BISHOP) != 0 ? attacks_bb<PieceType.BISHOP>(s, pos.pieces() ^ pos.pieces(Us, PieceType.QUEEN)) : Pt == ((int)PieceType.ROOK) != 0 ? attacks_bb< PieceType.ROOK>(s, pos.pieces() ^ pos.pieces(Us, PieceType.ROOK, PieceType.QUEEN)) : pos.attacks_from<Pt>(s);

			if ((ei.pinnedPieces[Us] & (int)s) != 0)
			{
				b &= GlobalMembersBitboard.LineBB[(int)pos.square<PieceType.KING>(Us), (int)s];
			}

			ei.attackedBy2[Us] |= ei.attackedBy[Us, (int)PieceType.ALL_PIECES] & b;
			ei.attackedBy[Us, (int)PieceType.ALL_PIECES] |= ei.attackedBy[Us, Pt] |= b;

			if ((b & ei.kingRing[(int)Them]) != 0)
			{
				ei.kingAttackersCount[Us]++;
				ei.kingAttackersWeight[Us] += KingAttackWeights[Pt];
				ei.kingAdjacentZoneAttacksCount[Us] += GlobalMembersBenchmark.popcount(b & ei.attackedBy[(int)Them, (int)PieceType.KING]);
			}

			if (Pt == PieceType.QUEEN)
			{
				b &= ~(ei.attackedBy[(int)Them, (int)PieceType.KNIGHT] | ei.attackedBy[(int)Them, (int)PieceType.BISHOP] | ei.attackedBy[(int)Them, (int)PieceType.ROOK]);
			}

			int mob = GlobalMembersBenchmark.popcount(b & mobilityArea[Us]);

			mobility[Us] += MobilityBonus[Pt, mob];

			if (Pt == PieceType.BISHOP || Pt == PieceType.KNIGHT)
			{
				// Bonus for outpost squares
				bb = OutpostRanks & ~ei.pi.pawn_attacks_span(Them);
				if ((bb & (int)s) != 0)
				{
					score += Outpost[Pt == PieceType.BISHOP, !!(ei.attackedBy[Us, (int)PieceType.PAWN] & (int)s)];
				}
				else
				{
					bb &= b & ~pos.pieces(Us);
					if (bb != 0)
					{
					   score += ReachableOutpost[Pt == PieceType.BISHOP, !!(ei.attackedBy[Us, (int)PieceType.PAWN] & bb)];
					}
				}

				// Bonus when behind a pawn
				if (GlobalMembersBenchmark.relative_rank(Us, s) < Rank.RANK_5 && (pos.pieces(PieceType.PAWN) & (s + GlobalMembersBenchmark.pawn_push(Us))))
				{
					score += MinorBehindPawn;
				}

				// Penalty for pawns on the same color square as the bishop
				if (Pt == PieceType.BISHOP)
				{
					score -= BishopPawns * ei.pi.pawns_on_same_color_squares(Us, s);
				}

				// An important Chess960 pattern: A cornered bishop blocked by a friendly
				// pawn diagonally in front of it is a very serious problem, especially
				// when that pawn is also blocked.
				if (Pt == PieceType.BISHOP && pos.is_chess960() && (s == GlobalMembersBenchmark.relative_square(Us, Square.SQ_A1) || s == GlobalMembersBenchmark.relative_square(Us, Square.SQ_H1)))
				{
					Square d = GlobalMembersBenchmark.pawn_push(Us) + (GlobalMembersBenchmark.file_of(s) == ((int)File.FILE_A) != 0 ? Square.EAST : Square.WEST);
					if (pos.piece_on(s + d) == GlobalMembersBenchmark.make_piece(Us, PieceType.PAWN))
					{
						score -= !pos.empty(s + d + GlobalMembersBenchmark.pawn_push(Us)) ? TrappedBishopA1H1 * 4 : pos.piece_on(s + d + d) == ((int)GlobalMembersBenchmark.make_piece(Us, PieceType.PAWN)) != 0 ? TrappedBishopA1H1 * 2 : TrappedBishopA1H1;
					}
				}
			}

			if (Pt == PieceType.ROOK)
			{
				// Bonus for aligning with enemy pawns on the same rank/file
				if (GlobalMembersBenchmark.relative_rank(Us, s) >= Rank.RANK_5)
				{
					score += RookOnPawn * GlobalMembersBenchmark.popcount(pos.pieces(Them, PieceType.PAWN) & GlobalMembersBitboard.PseudoAttacks[(int)PieceType.ROOK, (int)s]);
				}

				// Bonus when on an open or semi-open file
				if (ei.pi.semiopen_file(Us, GlobalMembersBenchmark.file_of(s)) != 0)
				{
					score += RookOnFile[!ei.pi.semiopen_file(Them, GlobalMembersBenchmark.file_of(s)) == 0];
				}

				// Penalize when trapped by the king, even more if the king cannot castle
				else if (mob <= 3)
				{
					Square ksq = pos.square<PieceType.KING>(Us);

					if (((GlobalMembersBenchmark.file_of(ksq) < File.FILE_E) == (GlobalMembersBenchmark.file_of(s) < GlobalMembersBenchmark.file_of(ksq))) && (GlobalMembersBenchmark.rank_of(ksq) == GlobalMembersBenchmark.rank_of(s) || GlobalMembersBenchmark.relative_rank(Us, ksq) == Rank.RANK_1) && ei.pi.semiopen_side(Us, GlobalMembersBenchmark.file_of(ksq), GlobalMembersBenchmark.file_of(s) < GlobalMembersBenchmark.file_of(ksq)) == 0)
					{
						score -= (TrappedRook - GlobalMembersBenchmark.make_score(mob * 22, 0)) * (1 + pos.can_castle(Us) == 0);
					}
				}
			}

			if (Pt == PieceType.QUEEN)
			{
				// Penalty if any relative pin or discovered attack against the queen
				ulong pinners;
				if (pos.slider_blockers(pos.pieces(Them, PieceType.ROOK, PieceType.BISHOP), s, ref pinners) != 0)
				{
					score -= WeakQueen;
				}
			}
		}

		if (DoTrace)
		{
			GlobalMembersEvaluate.add(Pt, Us, score);
		}

		// Recursively call evaluate_pieces() of next piece type until KING is excluded
		return score - evaluate_pieces<DoTrace, Them, NextPt>(pos, ei, mobility, mobilityArea);
	  }

	  public static Score evaluate_pieces(Position UnnamedParameter1, EvalInfo UnnamedParameter2, Score UnnamedParameter3, ulong UnnamedParameter4)
	  {
		  return Score.SCORE_ZERO;
	  }
	  public static Score evaluate_pieces(Position UnnamedParameter1, EvalInfo UnnamedParameter2, Score UnnamedParameter3, ulong UnnamedParameter4)
	  {
		  return Score.SCORE_ZERO;
	  }


	  // evaluate_king() assigns bonuses and penalties to a king of a given color

	  public static ulong WhiteCamp = Rank1BB | Rank2BB | Rank3BB | Rank4BB | Rank5BB;
	  public static ulong BlackCamp = Rank8BB | Rank7BB | Rank6BB | Rank5BB | Rank4BB;
	  public static ulong QueenSide = FileABB | FileBBB | FileCBB | FileDBB;
	  public static ulong CenterFiles = FileCBB | FileDBB | FileEBB | FileFBB;
	  public static ulong KingSide = FileEBB | FileFBB | FileGBB | FileHBB;

	  public static readonly ulong[,] KingFlank =
	  {
		  {QueenSide & WhiteCamp, QueenSide & WhiteCamp, QueenSide & WhiteCamp, CenterFiles & WhiteCamp, CenterFiles & WhiteCamp, KingSide & WhiteCamp, KingSide & WhiteCamp, KingSide & WhiteCamp},
		  {QueenSide & BlackCamp, QueenSide & BlackCamp, QueenSide & BlackCamp, CenterFiles & BlackCamp, CenterFiles & BlackCamp, KingSide & BlackCamp, KingSide & BlackCamp, KingSide & BlackCamp}
	  };

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, bool DoTrace>
	  public static Score evaluate_king<Color Us, bool DoTrace>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		Square Up = (Us == ((int)Color.WHITE) != 0 ? Square.NORTH : Square.SOUTH);

		ulong undefended;
		ulong b;
		ulong b1;
		ulong b2;
		ulong safe;
		ulong other;
		int kingDanger;
		Square ksq = pos.square<PieceType.KING>(Us);

		// King shelter and enemy pawns storm
		Score score = ei.pi.king_safety<Us>(pos, ksq);

		// Main king safety evaluation
		if (ei.kingAttackersCount[(int)Them] != 0)
		{
			// Find the attacked squares which are defended only by the king...
			undefended = ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] & ei.attackedBy[Us, (int)PieceType.KING] & ~ei.attackedBy2[Us];

			// ... and those which are not defended at all in the larger king ring
			b = ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] & ~ei.attackedBy[Us, (int)PieceType.ALL_PIECES] & ei.kingRing[Us] & ~pos.pieces(Them);

			// Initialize the 'kingDanger' variable, which will be transformed
			// later into a king danger score. The initial value is based on the
			// number and types of the enemy's attacking pieces, the number of
			// attacked and undefended squares around our king and the quality of
			// the pawn shelter (current 'score' value).
			kingDanger = Math.Min(807, ei.kingAttackersCount[(int)Them] * ei.kingAttackersWeight[(int)Them]) + 101 * ei.kingAdjacentZoneAttacksCount[(int)Them] + 235 * GlobalMembersBenchmark.popcount(undefended) + 134 * (GlobalMembersBenchmark.popcount(b) + !ei.pinnedPieces[Us] == 0) - 717 * !pos.count<PieceType.QUEEN>(Them) - 7 * GlobalMembersBenchmark.mg_value(score) / 5 - 5;

			// Analyse the enemy's safe queen contact checks. Firstly, find the
			// undefended squares around the king reachable by the enemy queen...
			b = undefended & ei.attackedBy[(int)Them, (int)PieceType.QUEEN] & ~pos.pieces(Them);

			// ...and keep squares supported by another enemy piece
			kingDanger += QueenContactCheck * GlobalMembersBenchmark.popcount(b & ei.attackedBy2[(int)Them]);

			// Analyse the safe enemy's checks which are possible on next move...
			safe = ~(ei.attackedBy[Us, (int)PieceType.ALL_PIECES] | pos.pieces(Them));

			// ... and some other potential checks, only requiring the square to be
			// safe from pawn-attacks, and not being occupied by a blocked pawn.
			other = ~(ei.attackedBy[Us, (int)PieceType.PAWN] | (pos.pieces(Them, PieceType.PAWN) & shift<Up>(pos.pieces(PieceType.PAWN))));

			b1 = pos.attacks_from<PieceType.ROOK >(ksq);
			b2 = pos.attacks_from<PieceType.BISHOP>(ksq);

			// Enemy queen safe checks
			if (((b1 | b2) & ei.attackedBy[(int)Them, (int)PieceType.QUEEN] & safe) != 0)
			{
				kingDanger += QueenCheck, score -= SafeCheck;
			}

			// For other pieces, also consider the square safe if attacked twice,
			// and only defended by a queen.
			safe |= ei.attackedBy2[(int)Them] & ~(ei.attackedBy2[Us] | pos.pieces(Them)) & ei.attackedBy[Us, (int)PieceType.QUEEN];

			// Enemy rooks safe and other checks
			if ((b1 & ei.attackedBy[(int)Them, (int)PieceType.ROOK] & safe) != 0)
			{
				kingDanger += RookCheck, score -= SafeCheck;
			}

			else if ((b1 & ei.attackedBy[(int)Them, (int)PieceType.ROOK] & other) != 0)
			{
				score -= OtherCheck;
			}

			// Enemy bishops safe and other checks
			if ((b2 & ei.attackedBy[(int)Them, (int)PieceType.BISHOP] & safe) != 0)
			{
				kingDanger += BishopCheck, score -= SafeCheck;
			}

			else if ((b2 & ei.attackedBy[(int)Them, (int)PieceType.BISHOP] & other) != 0)
			{
				score -= OtherCheck;
			}

			// Enemy knights safe and other checks
			b = pos.attacks_from<PieceType.KNIGHT>(ksq) & ei.attackedBy[(int)Them, (int)PieceType.KNIGHT];
			if ((b & safe) != 0)
			{
				kingDanger += KnightCheck, score -= SafeCheck;
			}

			else if ((b & other) != 0)
			{
				score -= OtherCheck;
			}

			// Compute the king danger score and subtract it from the evaluation
			if (kingDanger > 0)
			{
				score -= GlobalMembersBenchmark.make_score(Math.Min(kingDanger * kingDanger / 4096, 2 * (int)Value.BishopValueMg), 0);
			}
		}

		// King tropism: firstly, find squares that opponent attacks in our king flank
		File kf = GlobalMembersBenchmark.file_of(ksq);
		b = ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] & KingFlank[Us, (int)kf];

		Debug.Assert(((Us == ((int)Color.WHITE) != 0 ? b << 4 : b >> 4) & b) == 0);
		Debug.Assert(GlobalMembersBenchmark.popcount(Us == ((int)Color.WHITE) != 0 ? b << 4 : b >> 4) == GlobalMembersBenchmark.popcount(b));

		// Secondly, add the squares which are attacked twice in that flank and
		// which are not defended by our pawns.
		b = (Us == ((int)Color.WHITE) != 0 ? b << 4 : b >> 4) | (b & ei.attackedBy2[(int)Them] & ~ei.attackedBy[Us, (int)PieceType.PAWN]);

		score -= CloseEnemies * GlobalMembersBenchmark.popcount(b);

		// Penalty when our king is on a pawnless flank
		if (((pos.pieces(PieceType.PAWN) & (KingFlank[(int)Color.WHITE, (int)kf] | KingFlank[(int)Color.BLACK, (int)kf])) == 0)
		{
			score -= PawnlessFlank;
		}

		if (DoTrace)
		{
			GlobalMembersEvaluate.add(PieceType.KING, Us, score);
		}

		return score;
	  }


	  // evaluate_threats() assigns bonuses according to the types of the attacking
	  // and the attacked pieces.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, bool DoTrace>
	  public static Score evaluate_threats<Color Us, bool DoTrace>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		Square Up = (Us == ((int)Color.WHITE) != 0 ? Square.NORTH : Square.SOUTH);
		Square Left = (Us == ((int)Color.WHITE) != 0 ? Square.NORTH_WEST : Square.SOUTH_EAST);
		Square Right = (Us == ((int)Color.WHITE) != 0 ? Square.NORTH_EAST : Square.SOUTH_WEST);
		ulong TRank2BB = (Us == ((int)Color.WHITE) != 0 ? Rank2BB : Rank7BB);
		ulong TRank7BB = (Us == ((int)Color.WHITE) != 0 ? Rank7BB : Rank2BB);


		ulong b;
		ulong weak;
		ulong defended;
		ulong safeThreats;
		Score score = Score.SCORE_ZERO;

		// Small bonus if the opponent has loose pawns or pieces
		if (((pos.pieces(Them) ^ pos.pieces(Them, PieceType.QUEEN, PieceType.KING)) & ~(ei.attackedBy[Us, (int)PieceType.ALL_PIECES] | ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES])) != 0)
		{
			score += LooseEnemies;
		}

		// Non-pawn enemies attacked by a pawn
		weak = (pos.pieces(Them) ^ pos.pieces(Them, PieceType.PAWN)) & ei.attackedBy[Us, (int)PieceType.PAWN];

		if (weak != 0)
		{
			b = pos.pieces(Us, PieceType.PAWN) & (~ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] | ei.attackedBy[Us, (int)PieceType.ALL_PIECES]);

			safeThreats = (shift<Right>(b) | shift<Left>(b)) & weak;

			if ((weak ^ safeThreats) != 0)
			{
				score += ThreatByHangingPawn;
			}

			while (safeThreats != 0)
			{
				score += ThreatBySafePawn[(int)GlobalMembersBenchmark.type_of(pos.piece_on(GlobalMembersBenchmark.pop_lsb(ref safeThreats)))];
			}
		}

		// Non-pawn enemies defended by a pawn
		defended = (pos.pieces(Them) ^ pos.pieces(Them, PieceType.PAWN)) & ei.attackedBy[(int)Them, (int)PieceType.PAWN];

		// Enemies not defended by a pawn and under our attack
		weak = pos.pieces(Them) & ~ei.attackedBy[(int)Them, (int)PieceType.PAWN] & ei.attackedBy[Us, (int)PieceType.ALL_PIECES];

		// Add a bonus according to the kind of attacking pieces
		if ((defended | weak) != 0)
		{
			b = (defended | weak) & (ei.attackedBy[Us, (int)PieceType.KNIGHT] | ei.attackedBy[Us, (int)PieceType.BISHOP]);
			while (b != 0)
			{
				score += Threat[Minor, (int)GlobalMembersBenchmark.type_of(pos.piece_on(GlobalMembersBenchmark.pop_lsb(ref b)))];
			}

			b = (pos.pieces(Them, PieceType.QUEEN) | weak) & ei.attackedBy[Us, (int)PieceType.ROOK];
			while (b != 0)
			{
				score += Threat[Rook, (int)GlobalMembersBenchmark.type_of(pos.piece_on(GlobalMembersBenchmark.pop_lsb(ref b)))];
			}

			score += Hanging * GlobalMembersBenchmark.popcount(weak & ~ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES]);

			b = weak & ei.attackedBy[Us, (int)PieceType.KING];
			if (b != 0)
			{
				score += ThreatByKing[GlobalMembersBenchmark.more_than_one(b)];
			}
		}

		// Bonus if some pawns can safely push and attack an enemy piece
		b = pos.pieces(Us, PieceType.PAWN) & ~TRank7BB;
		b = shift<Up>(b | (shift<Up>(b & TRank2BB) & ~pos.pieces()));

		b &= ~pos.pieces() & ~ei.attackedBy[(int)Them, (int)PieceType.PAWN] & (ei.attackedBy[Us, (int)PieceType.ALL_PIECES] | ~ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES]);

		b = (shift<Left>(b) | shift<Right>(b)) & pos.pieces(Them) & ~ei.attackedBy[Us, (int)PieceType.PAWN];

		score += ThreatByPawnPush * GlobalMembersBenchmark.popcount(b);

		if (DoTrace)
		{
			GlobalMembersEvaluate.add(THREAT, Us, score);
		}

		return score;
	  }
	  public static Score evaluate_passed_pawns<Color Us, bool DoTrace>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);

		ulong b;
		ulong bb;
		ulong squaresToQueen;
		ulong defendedSquares;
		ulong unsafeSquares;
		Score score = Score.SCORE_ZERO;

		b = ei.pi.passed_pawns(Us);

		while (b != 0)
		{
			Square s = GlobalMembersBenchmark.pop_lsb(ref b);

			Debug.Assert(pos.pawn_passed(Us, s));
			Debug.Assert(!(pos.pieces(PieceType.PAWN) & GlobalMembersBenchmark.forward_bb(Us, s)));

			bb = GlobalMembersBenchmark.forward_bb(Us, s) & (ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] | pos.pieces(Them));
			score -= HinderPassedPawn * GlobalMembersBenchmark.popcount(bb);

			int r = (int)GlobalMembersBenchmark.relative_rank(Us, s) - Rank.RANK_2;
			int rr = r * (r - 1);

			Value mbonus = Passed[(int)Phase.MG, r];
			Value ebonus = Passed[(int)Phase.EG, r];

			if (rr != 0)
			{
				Square blockSq = s + GlobalMembersBenchmark.pawn_push(Us);

				// Adjust bonus based on the king's proximity
				ebonus += GlobalMembersBenchmark.distance(pos.square<PieceType.KING>(Them), blockSq) * 5 * rr - GlobalMembersBenchmark.distance(pos.square<PieceType.KING>(Us), blockSq) * 2 * rr;

				// If blockSq is not the queening square then consider also a second push
				if (GlobalMembersBenchmark.relative_rank(Us, blockSq) != Rank.RANK_8)
				{
					ebonus -= GlobalMembersBenchmark.distance(pos.square<PieceType.KING>(Us), blockSq + GlobalMembersBenchmark.pawn_push(Us)) * rr;
				}

				// If the pawn is free to advance, then increase the bonus
				if (pos.empty(blockSq))
				{
					// If there is a rook or queen attacking/defending the pawn from behind,
					// consider all the squaresToQueen. Otherwise consider only the squares
					// in the pawn's path attacked or occupied by the enemy.
					defendedSquares = unsafeSquares = squaresToQueen = GlobalMembersBenchmark.forward_bb(Us, s);

					bb = GlobalMembersBenchmark.forward_bb(Them, s) & pos.pieces(PieceType.ROOK, PieceType.QUEEN) & pos.attacks_from<PieceType.ROOK>(s);

					if (((pos.pieces(Us) & bb) == 0)
					{
						defendedSquares &= ei.attackedBy[Us, (int)PieceType.ALL_PIECES];
					}

					if (((pos.pieces(Them) & bb) == 0)
					{
						unsafeSquares &= ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES] | pos.pieces(Them);
					}

					// If there aren't any enemy attacks, assign a big bonus. Otherwise
					// assign a smaller bonus if the block square isn't attacked.
					int k = unsafeSquares == 0 ? 18 :!((unsafeSquares & (int)blockSq) != 0) ? 8 : 0;

					// If the path to the queen is fully defended, assign a big bonus.
					// Otherwise assign a smaller bonus if the block square is defended.
					if (defendedSquares == squaresToQueen)
					{
						k += 6;
					}

					else if ((defendedSquares & (int)blockSq) != 0)
					{
						k += 4;
					}

					mbonus += k * rr, ebonus += k * rr;
				}
				else if ((pos.pieces(Us) & (int)blockSq) != 0)
				{
					mbonus += rr + r * 2, ebonus += rr + r * 2;
				}
			} // rr != 0

			score += GlobalMembersBenchmark.make_score(mbonus, ebonus) + PassedFile[(int)GlobalMembersBenchmark.file_of(s)];
		}

		if (DoTrace)
		{
			GlobalMembersEvaluate.add(PASSED, Us, score);
		}

		// Add the scores to the middlegame and endgame eval
		return score;
	  }


	  // evaluate_space() computes the space evaluation for a given side. The
	  // space evaluation is a simple bonus based on the number of safe squares
	  // available for minor pieces on the central four files on ranks 2--4. Safe
	  // squares one, two or three squares behind a friendly pawn are counted
	  // twice. Finally, the space bonus is multiplied by a weight. The aim is to
	  // improve play on game opening.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
	  public static Score evaluate_space<Color Us>(Position pos, EvalInfo ei)
	  {

		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		ulong SpaceMask = Us == ((int)Color.WHITE) != 0 ? (FileCBB | FileDBB | FileEBB | FileFBB) & (Rank2BB | Rank3BB | Rank4BB) : (FileCBB | FileDBB | FileEBB | FileFBB) & (Rank7BB | Rank6BB | Rank5BB);

		// Find the safe squares for our pieces inside the area defined by
		// SpaceMask. A square is unsafe if it is attacked by an enemy
		// pawn, or if it is undefended and attacked by an enemy piece.
		ulong safe = SpaceMask & ~pos.pieces(Us, PieceType.PAWN) & ~ei.attackedBy[(int)Them, (int)PieceType.PAWN] & (ei.attackedBy[Us, (int)PieceType.ALL_PIECES] | ~ei.attackedBy[(int)Them, (int)PieceType.ALL_PIECES]);

		// Find all squares which are at most three squares behind some friendly pawn
		ulong behind = pos.pieces(Us, PieceType.PAWN);
		behind |= (Us == ((int)Color.WHITE) != 0 ? behind >> 8 : behind << 8);
		behind |= (Us == ((int)Color.WHITE) != 0 ? behind >> 16 : behind << 16);

		// Since SpaceMask[Us] is fully on our half of the board...
		Debug.Assert((uint)(safe >> (Us == ((int)Color.WHITE) != 0 ? 32 : 0)) == 0);

		// ...count safe + (behind & safe) with a single popcount
		int bonus = GlobalMembersBenchmark.popcount((Us == ((int)Color.WHITE) != 0 ? safe << 32 : safe >> 32) | (behind & safe));
		bonus = Math.Min(16, bonus);
		int weight = pos.count<PieceType.ALL_PIECES>(Us) - 2 * ei.pi.open_files();

		return GlobalMembersBenchmark.make_score(bonus * weight * weight / 18, 0);
	  }


	  // evaluate_initiative() computes the initiative correction value for the
	  // position, i.e., second order bonus/malus based on the known attacking/defending
	  // status of the players.
	  public static Score evaluate_initiative(Position pos, int asymmetry, Value eg)
	  {

		int kingDistance = distance<File>(pos.square<PieceType.KING>(Color.WHITE), pos.square<PieceType.KING>(Color.BLACK)) - distance<Rank>(pos.square<PieceType.KING>(Color.WHITE), pos.square<PieceType.KING>(Color.BLACK));
		int pawns = pos.count<PieceType.PAWN>(Color.WHITE) + pos.count<PieceType.PAWN>(Color.BLACK);

		// Compute the initiative bonus for the attacking side
		int initiative = 8 * (asymmetry + kingDistance - 15) + 12 * pawns;

		// Now apply the bonus: note that we find the attacking side by extracting
		// the sign of the endgame value, and that we carefully cap the bonus so
		// that the endgame score will never be divided by more than two.
		int value = ((eg > 0) - (eg < 0)) * Math.Max(initiative, -Math.Abs(eg / 2));

		return GlobalMembersBenchmark.make_score(0, value);
	  }


	  // evaluate_scale_factor() computes the scale factor for the winning side
	  public static ScaleFactor evaluate_scale_factor(Position pos, EvalInfo ei, Value eg)
	  {

		Color strongSide = eg > ((int)Value.VALUE_DRAW) != 0 ? Color.WHITE : Color.BLACK;
		ScaleFactor sf = ei.me.scale_factor(pos, strongSide);

		// If we don't already have an unusual scale factor, check for certain
		// types of endgames, and use a lower scale for those.
		if (ei.me.game_phase() < Phase.PHASE_MIDGAME && (sf == ScaleFactor.SCALE_FACTOR_NORMAL || sf == ScaleFactor.SCALE_FACTOR_ONEPAWN))
		{
			if (pos.opposite_bishops())
			{
				// Endgame with opposite-colored bishops and no other pieces (ignoring pawns)
				// is almost a draw, in case of KBP vs KB, it is even more a draw.
				if (pos.non_pawn_material(Color.WHITE) == Value.BishopValueMg && pos.non_pawn_material(Color.BLACK) == Value.BishopValueMg)
				{
					sf = GlobalMembersBenchmark.more_than_one(pos.pieces(PieceType.PAWN)) ? ScaleFactor(31) : ScaleFactor(9);
				}

				// Endgame with opposite-colored bishops, but also other pieces. Still
				// a bit drawish, but not as drawish as with only the two bishops.
				else
				{
					sf = ScaleFactor(46);
				}
			}
			// Endings where weaker side can place his king in front of the opponent's
			// pawns are drawish.
			else if (Math.Abs(eg) <= Value.BishopValueEg && pos.count<PieceType.PAWN>(strongSide) <= 2 && !pos.pawn_passed(~strongSide, pos.square<PieceType.KING>(~strongSide)))
			{
				sf = ScaleFactor(37 + 7 * pos.count<PieceType.PAWN>(strongSide));
			}
		}

		return sf;
	  }


	// Explicit template instantiations
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//template Value Eval::evaluate(Position NamelessParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//template Value Eval::evaluate(Position NamelessParameter);
}

/// A move needs 16 bits to be stored
///
/// bit  0- 5: destination square (from 0 to 63)
/// bit  6-11: origin square (from 0 to 63)
/// bit 12-13: promotion piece type - 2 (from KNIGHT-2 to QUEEN-2)
/// bit 14-15: special move flag: promotion (1), en passant (2), castling (3)
/// NOTE: EN-PASSANT bit is set only when a pawn can be captured
///
/// Special cases are MOVE_NONE and MOVE_NULL. We can sneak these in because in
/// any normal move destination square is always different from origin square
/// while MOVE_NONE and MOVE_NULL have the same origin and destination square.

public enum Move : int
{
  MOVE_NONE,
  MOVE_NULL = 65
}

public enum MoveType
{
  NORMAL,
  PROMOTION = 1 << 14,
  ENPASSANT = 2 << 14,
  CASTLING = 3 << 14
}

public enum Color
{
  WHITE,
  BLACK,
  NO_COLOR,
  COLOR_NB = 2
}

public enum CastlingSide
{
  KING_SIDE,
  QUEEN_SIDE,
  CASTLING_SIDE_NB = 2
}

public enum CastlingRight
{
  NO_CASTLING,
  WHITE_OO,
  WHITE_OOO = WHITE_OO << 1,
  BLACK_OO = WHITE_OO << 2,
  BLACK_OOO = WHITE_OO << 3,
  ANY_CASTLING = WHITE_OO | WHITE_OOO | BLACK_OO | BLACK_OOO,
  CASTLING_RIGHT_NB = 16
}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color C, CastlingSide S>
public class MakeCastling <Color C, CastlingSide S>
{
//C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
  public static const CastlingRight right = C == ((int)Color.WHITE) != 0 ? S == ((int)CastlingSide.QUEEN_SIDE) != 0 ? CastlingRight.WHITE_OOO : CastlingRight.WHITE_OO : S == ((int)CastlingSide.QUEEN_SIDE) != 0 ? CastlingRight.BLACK_OOO : CastlingRight.BLACK_OO;
}

public enum Phase
{
  PHASE_ENDGAME,
  PHASE_MIDGAME = 128,
  MG = 0,
  EG = 1,
  PHASE_NB = 2
}

public enum ScaleFactor
{
  SCALE_FACTOR_DRAW = 0,
  SCALE_FACTOR_ONEPAWN = 48,
  SCALE_FACTOR_NORMAL = 64,
  SCALE_FACTOR_MAX = 128,
  SCALE_FACTOR_NONE = 255
}

public enum Bound
{
  BOUND_NONE,
  BOUND_UPPER,
  BOUND_LOWER,
  BOUND_EXACT = BOUND_UPPER | BOUND_LOWER
}

public enum Value : int
{
  VALUE_ZERO = 0,
  VALUE_DRAW = 0,
  VALUE_KNOWN_WIN = 10000,
  VALUE_MATE = 32000,
  VALUE_INFINITE = 32001,
  VALUE_NONE = 32002,

  VALUE_MATE_IN_MAX_PLY = VALUE_MATE - 2 * MAX_PLY,
  VALUE_MATED_IN_MAX_PLY = -VALUE_MATE + 2 * MAX_PLY,

  PawnValueMg = 188,
  PawnValueEg = 248,
  KnightValueMg = 753,
  KnightValueEg = 832,
  BishopValueMg = 826,
  BishopValueEg = 897,
  RookValueMg = 1285,
  RookValueEg = 1371,
  QueenValueMg = 2513,
  QueenValueEg = 2650,

  MidgameLimit = 15258,
  EndgameLimit = 3915
}

public enum PieceType
{
  NO_PIECE_TYPE,
  PAWN,
  KNIGHT,
  BISHOP,
  ROOK,
  QUEEN,
  KING,
  ALL_PIECES = 0,
  PIECE_TYPE_NB = 8
}

public enum Piece
{
  NO_PIECE,
  W_PAWN = 1,
  W_KNIGHT,
  W_BISHOP,
  W_ROOK,
  W_QUEEN,
  W_KING,
  B_PAWN = 9,
  B_KNIGHT,
  B_BISHOP,
  B_ROOK,
  B_QUEEN,
  B_KING,
  PIECE_NB = 16
}

public enum Depth
{

  ONE_PLY = 1,

  DEPTH_ZERO = 0 * ONE_PLY,
  DEPTH_QS_CHECKS = 0 * ONE_PLY,
  DEPTH_QS_NO_CHECKS = -1 * ONE_PLY,
  DEPTH_QS_RECAPTURES = -5 * ONE_PLY,

  DEPTH_NONE = -6 * ONE_PLY,
  DEPTH_MAX = MAX_PLY * ONE_PLY
}

//C++ TO C# CONVERTER TODO TASK: There is no equivalent in C# to 'static_assert':
//static_assert(!(ONE_PLY & (ONE_PLY - 1)), "ONE_PLY is not a power of 2");

public enum Square
{
  SQ_A1,
  SQ_B1,
  SQ_C1,
  SQ_D1,
  SQ_E1,
  SQ_F1,
  SQ_G1,
  SQ_H1,
  SQ_A2,
  SQ_B2,
  SQ_C2,
  SQ_D2,
  SQ_E2,
  SQ_F2,
  SQ_G2,
  SQ_H2,
  SQ_A3,
  SQ_B3,
  SQ_C3,
  SQ_D3,
  SQ_E3,
  SQ_F3,
  SQ_G3,
  SQ_H3,
  SQ_A4,
  SQ_B4,
  SQ_C4,
  SQ_D4,
  SQ_E4,
  SQ_F4,
  SQ_G4,
  SQ_H4,
  SQ_A5,
  SQ_B5,
  SQ_C5,
  SQ_D5,
  SQ_E5,
  SQ_F5,
  SQ_G5,
  SQ_H5,
  SQ_A6,
  SQ_B6,
  SQ_C6,
  SQ_D6,
  SQ_E6,
  SQ_F6,
  SQ_G6,
  SQ_H6,
  SQ_A7,
  SQ_B7,
  SQ_C7,
  SQ_D7,
  SQ_E7,
  SQ_F7,
  SQ_G7,
  SQ_H7,
  SQ_A8,
  SQ_B8,
  SQ_C8,
  SQ_D8,
  SQ_E8,
  SQ_F8,
  SQ_G8,
  SQ_H8,
  SQ_NONE,

  SQUARE_NB = 64,

  NORTH = 8,
  EAST = 1,
  SOUTH = -8,
  WEST = -1,

  NORTH_EAST = NORTH + EAST,
  SOUTH_EAST = SOUTH + EAST,
  SOUTH_WEST = SOUTH + WEST,
  NORTH_WEST = NORTH + WEST
}

public enum File : int
{
  FILE_A,
  FILE_B,
  FILE_C,
  FILE_D,
  FILE_E,
  FILE_F,
  FILE_G,
  FILE_H,
  FILE_NB
}

public enum Rank : int
{
  RANK_1,
  RANK_2,
  RANK_3,
  RANK_4,
  RANK_5,
  RANK_6,
  RANK_7,
  RANK_8,
  RANK_NB
}


/// Score enum stores a middlegame and an endgame value in a single integer
/// (enum). The least significant 16 bits are used to store the endgame value
/// and the upper 16 bits are used to store the middlegame value. Take some
/// care to avoid left-shifting a signed int to avoid undefined behavior.
public enum Score : int
{
	SCORE_ZERO
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





/// StateInfo struct stores information needed to restore a Position object to
/// its previous state when we retract a move. Whenever a move is made on the
/// board (by calling Position::do_move), a StateInfo object must be passed.

public class StateInfo
{

  // Copied when making a move
  public ulong pawnKey;
  public ulong materialKey;
  public Value[] nonPawnMaterial = new Value[(int)Color.COLOR_NB];
  public int castlingRights;
  public int rule50;
  public int pliesFromNull;
  public Score psq;
  public Square epSquare;

  // Not copied when making a move (will be recomputed anyhow)
  public ulong key;
  public ulong checkersBB;
  public Piece capturedPiece;
  public StateInfo previous;
  public ulong[] blockersForKing = new ulong[(int)Color.COLOR_NB];
  public ulong[] pinnersForKing = new ulong[(int)Color.COLOR_NB];
  public ulong[] checkSquares = new ulong[(int)PieceType.PIECE_TYPE_NB];
}

// In a std::deque references to elements are unaffected upon resizing


/// Position class stores information regarding the board representation as
/// pieces, side to move, hash keys, castling info, etc. Important methods are
/// do_move() and undo_move(), used by the search to update node info when
/// traversing the search tree.
//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//class Thread;

public class Position
{
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  static void init();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Position();
//C++ TO C# CONVERTER TODO TASK: C# has no equivalent to ' = delete':
//ORIGINAL LINE: Position(const Position&) = delete;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Position(Position NamelessParameter);
//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: Position& operator =(const Position&) = delete;
//C++ TO C# CONVERTER TODO TASK: C# has no equivalent to ' = delete':
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Position CopyFrom(Position NamelessParameter);

  // FEN string input/output
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Position set(string fenStr, bool isChess960, StateInfo si, Thread th);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: const string fen() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  string fen();

  // Position representation
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pieces() const
  public ulong pieces()
  {
	return byTypeBB[(int)PieceType.ALL_PIECES];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pieces(PieceType pt) const
  public ulong pieces(PieceType pt)
  {
	return byTypeBB[(int)pt];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pieces(PieceType pt1, PieceType pt2) const
  public ulong pieces(PieceType pt1, PieceType pt2)
  {
	return byTypeBB[(int)pt1] | byTypeBB[(int)pt2];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pieces(Color c) const
  public ulong pieces(Color c)
  {
	return byColorBB[(int)c];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pieces(Color c, PieceType pt) const
  public ulong pieces(Color c, PieceType pt)
  {
	return byColorBB[(int)c] & byTypeBB[(int)pt];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pieces(Color c, PieceType pt1, PieceType pt2) const
  public ulong pieces(Color c, PieceType pt1, PieceType pt2)
  {
	return byColorBB[(int)c] & (byTypeBB[(int)pt1] | byTypeBB[(int)pt2]);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Piece piece_on(Square s) const
  public Piece piece_on(Square s)
  {
	return board[(int)s];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Square ep_square() const
  public Square ep_square()
  {
	return st.epSquare;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool empty(Square s) const
  public bool empty(Square s)
  {
	return board[(int)s] == Piece.NO_PIECE;
  }
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt>
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline int count(Color c) const
  public int count<PieceType Pt>(Color c)
  {
	return pieceCount[(int)GlobalMembersBenchmark.make_piece(c, Pt)];
  }
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt>
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline const Square* squares(Color c) const
//C++ TO C# CONVERTER WARNING: C# has no equivalent to methods returning pointers to value types:
  public Square squares(<PieceType Pt>Color c)
  {
	return pieceList[(int)GlobalMembersBenchmark.make_piece(c, Pt)];
  }
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt>
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Square square(Color c) const
  public Square square<PieceType Pt>(Color c)
  {
	Debug.Assert(pieceCount[(int)GlobalMembersBenchmark.make_piece(c, Pt)] == 1);
	return pieceList[(int)GlobalMembersBenchmark.make_piece(c, Pt), 0];
  }

  // Castling
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline int can_castle(Color c) const
  public int can_castle(Color c)
  {
	return st.castlingRights & (((int)CastlingRight.WHITE_OO | (int)CastlingRight.WHITE_OOO) << (2 * c));
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline int can_castle(CastlingRight cr) const
  public int can_castle(CastlingRight cr)
  {
	return st.castlingRights & (int)cr;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool castling_impeded(CastlingRight cr) const
  public bool castling_impeded(CastlingRight cr)
  {
	return byTypeBB[(int)PieceType.ALL_PIECES] & castlingPath[(int)cr];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Square castling_rook_square(CastlingRight cr) const
  public Square castling_rook_square(CastlingRight cr)
  {
	return castlingRookSquare[(int)cr];
  }

  // Checking
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong checkers() const
  public ulong checkers()
  {
	return st.checkersBB;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong discovered_check_candidates() const
  public ulong discovered_check_candidates()
  {
	return st.blockersForKing[~sideToMove] & pieces(sideToMove);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pinned_pieces(Color c) const
  public ulong pinned_pieces(Color c)
  {
	return st.blockersForKing[(int)c] & pieces(c);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong check_squares(PieceType pt) const
  public ulong check_squares(PieceType pt)
  {
	return st.checkSquares[(int)pt];
  }

  // Attacks to/from a given square
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong attackers_to(Square s) const
  public ulong attackers_to(Square s)
  {
	return attackers_to(s, byTypeBB[(int)PieceType.ALL_PIECES]);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong attackers_to(Square s, ulong occupied) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  ulong attackers_to(Square s, ulong occupied);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong attacks_from(Piece pc, Square s) const
  public ulong attacks_from(Piece pc, Square s)
  {
	return GlobalMembersBenchmark.attacks_bb(pc, s, byTypeBB[(int)PieceType.ALL_PIECES]);
  }
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType>
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong attacks_from(Square s) const
  public ulong attacks_from<PieceType>(Square s)
  {
	return Pt == PieceType.BISHOP || Pt == ((int)PieceType.ROOK) != 0 ? attacks_bb<Pt>(s, byTypeBB[(int)PieceType.ALL_PIECES]) : Pt == ((int)PieceType.QUEEN) != 0 ? attacks_from<PieceType.ROOK>(s) | attacks_from<PieceType.BISHOP>(s) : GlobalMembersBitboard.StepAttacksBB[Pt, (int)s];
  }
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType>
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong attacks_from<PAWN>(Square s, Color c) const
  public ulong attacks_from<PieceType>(Square s, Color c)
  {
	return GlobalMembersBitboard.StepAttacksBB[(int)GlobalMembersBenchmark.make_piece(c, PieceType.PAWN), (int)s];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong slider_blockers(ulong sliders, Square s, ulong& pinners) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  ulong slider_blockers(ulong sliders, Square s, ref ulong pinners);

  // Properties of moves
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool legal(Move m) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool legal(Move m);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool pseudo_legal(const Move m) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool pseudo_legal(Move m);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool capture(Move m) const
  public bool capture(Move m)
  {
	Debug.Assert(GlobalMembersBenchmark.is_ok(m));
	// Castling is encoded as "king captures rook"
	return (!empty(GlobalMembersBenchmark.to_sq(m)) && GlobalMembersBenchmark.type_of(m) != MoveType.CASTLING) || GlobalMembersBenchmark.type_of(m) == MoveType.ENPASSANT;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool capture_or_promotion(Move m) const
  public bool capture_or_promotion(Move m)
  {
	Debug.Assert(GlobalMembersBenchmark.is_ok(m));
	return GlobalMembersBenchmark.type_of(m) != ((int)MoveType.NORMAL) != 0 ? GlobalMembersBenchmark.type_of(m) != MoveType.CASTLING :!empty(GlobalMembersBenchmark.to_sq(m));
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool gives_check(Move m) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool gives_check(Move m);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool advanced_pawn_push(Move m) const
  public bool advanced_pawn_push(Move m)
  {
	return GlobalMembersBenchmark.type_of(moved_piece(m)) == PieceType.PAWN && GlobalMembersBenchmark.relative_rank(sideToMove, GlobalMembersBenchmark.from_sq(m)) > Rank.RANK_4;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Piece moved_piece(Move m) const
  public Piece moved_piece(Move m)
  {
	return board[(int)GlobalMembersBenchmark.from_sq(m)];
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Piece captured_piece() const
  public Piece captured_piece()
  {
	return st.capturedPiece;
  }

  // Piece specific
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool pawn_passed(Color c, Square s) const
  public bool pawn_passed(Color c, Square s)
  {
	return !(pieces(~c, PieceType.PAWN) & GlobalMembersBenchmark.passed_pawn_mask(c, s));
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool opposite_bishops() const
  public bool opposite_bishops()
  {
	return pieceCount[(int)Piece.W_BISHOP] == 1 && pieceCount[(int)Piece.B_BISHOP] == 1 && GlobalMembersBenchmark.opposite_colors(square<PieceType.BISHOP>(Color.WHITE), square<PieceType.BISHOP>(Color.BLACK));
  }

  // Doing and undoing moves
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void do_move(Move m, StateInfo st, bool givesCheck);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void undo_move(Move m);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void do_null_move(StateInfo st);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void undo_null_move();

  // Static Exchange Evaluation
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool see_ge(Move m, Value value) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool see_ge(Move m, Value value);

  // Accessing hash keys
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong key() const
  public ulong key()
  {
	return st.key;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong key_after(Move m) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  ulong key_after(Move m);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong material_key() const
  public ulong material_key()
  {
	return st.materialKey;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong pawn_key() const
  public ulong pawn_key()
  {
	return st.pawnKey;
  }

  // Other properties of the position
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Color side_to_move() const
  public Color side_to_move()
  {
	return sideToMove;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Phase game_phase() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Phase game_phase();
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline int game_ply() const
  public int game_ply()
  {
	return gamePly;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline bool is_chess960() const
  public bool is_chess960()
  {
	return chess960;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Thread* this_thread() const
  public Thread this_thread()
  {
	return thisThread;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong nodes_searched() const
  public ulong nodes_searched()
  {
	return nodes;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool is_draw() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool is_draw();
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline int rule50_count() const
  public int rule50_count()
  {
	return st.rule50;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Score psq_score() const
  public Score psq_score()
  {
	return st.psq;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline Value non_pawn_material(Color c) const
  public Value non_pawn_material(Color c)
  {
	return st.nonPawnMaterial[(int)c];
  }

  // Position consistency check, for debugging
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool pos_is_ok(int* failedStep = null) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool pos_is_ok(ref int failedStep);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void flip();

  // Initialization helpers (used while setting up a position)
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void set_castling_right(Color c, Square rfrom);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: void set_state(StateInfo* si) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void set_state(StateInfo si);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: void set_check_info(StateInfo* si) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void set_check_info(StateInfo si);

  // Other helpers
  private void put_piece(Piece pc, Square s)
  {

	board[(int)s] = pc;
	byTypeBB[(int)PieceType.ALL_PIECES] |= s;
	byTypeBB[(int)GlobalMembersBenchmark.type_of(pc)] |= s;
	byColorBB[(int)GlobalMembersBenchmark.color_of(pc)] |= s;
	index[(int)s] = pieceCount[(int)pc]++;
	pieceList[(int)pc, index[(int)s]] = s;
	pieceCount[(int)GlobalMembersBenchmark.make_piece(GlobalMembersBenchmark.color_of(pc), PieceType.ALL_PIECES)]++;
  }
  private void remove_piece(Piece pc, Square s)
  {

	// WARNING: This is not a reversible operation. If we remove a piece in
	// do_move() and then replace it in undo_move() we will put it at the end of
	// the list and not in its original place, it means index[] and pieceList[]
	// are not invariant to a do_move() + undo_move() sequence.
	byTypeBB[(int)PieceType.ALL_PIECES] ^= s;
	byTypeBB[(int)GlobalMembersBenchmark.type_of(pc)] ^= s;
	byColorBB[(int)GlobalMembersBenchmark.color_of(pc)] ^= s;
	/* board[s] = NO_PIECE;  Not needed, overwritten by the capturing one */
	Square lastSquare = pieceList[(int)pc, --pieceCount[(int)pc]];
	index[(int)lastSquare] = index[(int)s];
	pieceList[(int)pc, index[(int)lastSquare]] = lastSquare;
	pieceList[(int)pc, pieceCount[(int)pc]] = Square.SQ_NONE;
	pieceCount[(int)GlobalMembersBenchmark.make_piece(GlobalMembersBenchmark.color_of(pc), PieceType.ALL_PIECES)]--;
  }
  private void move_piece(Piece pc, Square from, Square to)
  {

	// index[from] is not updated and becomes stale. This works as long as index[]
	// is accessed just by known occupied squares.
	ulong from_to_bb = GlobalMembersBitboard.SquareBB[(int)from] ^ GlobalMembersBitboard.SquareBB[(int)to];
	byTypeBB[(int)PieceType.ALL_PIECES] ^= from_to_bb;
	byTypeBB[(int)GlobalMembersBenchmark.type_of(pc)] ^= from_to_bb;
	byColorBB[(int)GlobalMembersBenchmark.color_of(pc)] ^= from_to_bb;
	board[(int)from] = Piece.NO_PIECE;
	board[(int)to] = pc;
	index[(int)to] = index[(int)from];
	pieceList[(int)pc, index[(int)to]] = to;
  }
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool Do>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void do_castling<bool Do>(Color us, Square from, Square to, Square rfrom, Square rto);

  // Data members
  private Piece[] board = new Piece[(int)Square.SQUARE_NB];
  private ulong[] byTypeBB = new ulong[(int)PieceType.PIECE_TYPE_NB];
  private ulong[] byColorBB = new ulong[(int)Color.COLOR_NB];
  private int[] pieceCount = new int[(int)Piece.PIECE_NB];
  private Square[,] pieceList = new Square[(int)Piece.PIECE_NB, 16];
  private int[] index = new int[(int)Square.SQUARE_NB];
  private int[] castlingRightsMask = new int[(int)Square.SQUARE_NB];
  private Square[] castlingRookSquare = new Square[(int)CastlingRight.CASTLING_RIGHT_NB];
  private ulong[] castlingPath = new ulong[(int)CastlingRight.CASTLING_RIGHT_NB];
  private ulong nodes;
  private int gamePly;
  private Color sideToMove;
  private Thread thisThread;
  private StateInfo st;
  private bool chess960;
}




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
public class HashTable <Entry, int Size>
{
  public Entry this[ulong key]
  {
	  get
	  {
		  return table[(uint)key & (Size - 1)];
	  }
  }

  private List<Entry> table = new List<Entry>(Size);
}


public enum SyncCout
{
	IO_LOCK,
	IO_UNLOCK
}

//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define sync_cout std::cout << IO_LOCK
#define sync_cout
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define sync_endl std::endl << IO_UNLOCK
#define sync_endl


/// xorshift64star Pseudo-Random Number Generator
/// This class is based on original code written and dedicated
/// to the public domain by Sebastiano Vigna (2014).
/// It has the following characteristics:
///
///  -  Outputs 64-bit numbers
///  -  Passes Dieharder and SmallCrush test batteries
///  -  Does not require warm-up, no zeroland to escape
///  -  Internal state is a single 64-bit integer
///  -  Period is 2^64 - 1
///  -  Speed: 1.60 ns/call (Core i7 @3.40GHz)
///
/// For further analysis see
///   <http://vigna.di.unimi.it/ftp/papers/xorshift.pdf>

public class PRNG
{

  private ulong s;

  private ulong rand64()
  {

	s ^= s >> 12, s ^= s << 25, s = s >> 27;
	return s * 2685821657736338717L;
  }

  public PRNG(ulong seed)
  {
	  this.s = seed;
	  Debug.Assert(seed);
  }

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
  public T rand<T>()
  {
	  return T(rand64());
  }

  /// Special generator used to fast init magic numbers.
  /// Output values only have 1/8th of their bits set on average.
//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
  public T sparse_rand<T>()
  {
	  return T(rand64() & rand64() & rand64());
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
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Score do_king_safety<Color Us>(Position pos, Square ksq);

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Value shelter_storm<Color Us>(Position pos, Square ksq);

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



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

  namespace Trace
  {

	public enum Term // The first 8 entries are for PieceType
	{
	  MATERIAL = 8,
	  IMBALANCE,
	  MOBILITY,
	  THREAT,
	  PASSED,
	  SPACE,
	  TOTAL,
	  TERM_NB
	}
  }

  // Struct EvalInfo contains various information computed and collected
  // by the evaluation functions.
  public class EvalInfo
  {

	// attackedBy[color][piece type] is a bitboard representing all squares
	// attacked by a given color and piece type (can be also ALL_PIECES).
	public ulong[,] attackedBy = new ulong[(int)Color.COLOR_NB, (int)PieceType.PIECE_TYPE_NB];

	// attackedBy2[color] are the squares attacked by 2 pieces of a given color,
	// possibly via x-ray or by one pawn and one piece. Diagonal x-ray through
	// pawn or squares attacked by 2 pawns are not explicitly added.
	public ulong[] attackedBy2 = new ulong[(int)Color.COLOR_NB];

	// kingRing[color] is the zone around the king which is considered
	// by the king safety evaluation. This consists of the squares directly
	// adjacent to the king, and the three (or two, for a king on an edge file)
	// squares two ranks in front of the king. For instance, if black's king
	// is on g8, kingRing[BLACK] is a bitboard containing the squares f8, h8,
	// f7, g7, h7, f6, g6 and h6.
	public ulong[] kingRing = new ulong[(int)Color.COLOR_NB];

	// kingAttackersCount[color] is the number of pieces of the given color
	// which attack a square in the kingRing of the enemy king.
	public int[] kingAttackersCount = new int[(int)Color.COLOR_NB];

	// kingAttackersWeight[color] is the sum of the "weights" of the pieces of the
	// given color which attack a square in the kingRing of the enemy king. The
	// weights of the individual piece types are given by the elements in the
	// KingAttackWeights array.
	public int[] kingAttackersWeight = new int[(int)Color.COLOR_NB];

	// kingAdjacentZoneAttacksCount[color] is the number of attacks by the given
	// color to squares directly adjacent to the enemy king. Pieces which attack
	// more than one square are counted multiple times. For instance, if there is
	// a white knight on g5 and black's king is on g8, this white knight adds 2
	// to kingAdjacentZoneAttacksCount[WHITE].
	public int[] kingAdjacentZoneAttacksCount = new int[(int)Color.COLOR_NB];

	public ulong[] pinnedPieces = new ulong[(int)Color.COLOR_NB];
	public Material.Entry me;
	public Pawns.Entry pi;
  }
//C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named AnonymousEnum:
  public enum AnonymousEnum
  {
	  Minor,
	  Rook
  }


  // evaluate_passed_pawns() evaluates the passed pawns of the given color

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, bool DoTrace>
