using System.Diagnostics;
using System.Collections.Generic;
using System;

public static class GlobalMembersThread
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



//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
	//class Position;

	public static bool operator < (ExtMove f, ExtMove s)
	{
	  return f.value < s.value;
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<GenType>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//ExtMove[] generate<GenType>(Position pos, ExtMove[] moveList);

	/// The MoveList struct is a simple wrapper around generate(). It sometimes comes
	/// in handy to use this class instead of the low level generate() function.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<GenType T>


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

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//std::ostream operator <<<bool Do>(std::ostream os, Position pos);




	/// The Stats struct stores moves statistics. According to the template parameter
	/// the class can store History and Countermoves. History records how often
	/// different moves have been successful or unsuccessful during the current search
	/// and is used for reduction and move ordering decisions.
	/// Countermoves store the move that refute a previous one. Entries are stored
	/// using only the moving piece and destination square, hence two moves with
	/// different origin but same destination and piece will be considered identical.
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers containing defaults cannot be converted to C#:
//ORIGINAL LINE: template<typename T, bool CM = false>

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern SignalsType Signals;
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern LimitsType Limits;

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void init();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void clear();
//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool Root = true>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//ulong perft<bool Root = true>(Position pos, Depth depth);

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void init(ClassicMap<string, Option, CaseInsensitiveLess>);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void loop(int argc, string[] argv);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//string value(Value v);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//string square(Square s);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//string move(Move m, bool chess960);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//string pv(Position pos, Depth depth, Value alpha, Value beta);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//Move to_move(Position pos, string str);

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern ClassicMap<string, Option, CaseInsensitiveLess> Options;



	public static ThreadPool Threads = new ThreadPool(); // Global object
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

public enum GenType
{
  CAPTURES,
  QUIETS,
  QUIET_CHECKS,
  EVASIONS,
  NON_EVASIONS,
  LEGAL
}

public class ExtMove
{
  public Move move;
  public Value value;

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: operator Move() const
  public static implicit operator Move(ExtMove ImpliedObject)
  {
	  return ImpliedObject.move;
  }
//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: void operator =(Move m)
  public void CopyFrom(Move m)
  {
	  move = m;
  }
}
public class MoveList <GenType T>
{

  public MoveList(Position pos)
  {
	  this.last = generate<T>(pos, moveList);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: const ExtMove* begin() const
  public ExtMove begin()
  {
	  return moveList;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: const ExtMove* end() const
  public ExtMove end()
  {
	  return last;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: uint size() const
  public uint size()
  {
	  return last - moveList;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool contains(Move move) const
  public bool contains(Move move)
  {
	foreach (var m in * this)
	{
		if (m == move)
		{
			return true;
		}
	}
	return false;
  }

  private ExtMove[] moveList = Arrays.InitializeWithDefaultInstances<ExtMove>(MAX_MOVES);
  private ExtMove last;
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
public class Stats <T, bool CM = false>
{

  public Value Max = new Value(1 << 28);

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: const T* operator [](Piece pc) const
  public T this[Piece pc]
  {
	  get
	  {
		  return table[(int)pc];
	  }
  }
  public T this[Piece pc]
  {
	  get
	  {
		  return table[(int)pc];
	  }
  }
  public void clear()
  {
	  std.memset(table, 0, sizeof(T));
  }
  public void update(Piece pc, Square to, Move m)
  {
	  table[(int)pc, (int)to] = m;
  }
  public void update(Piece pc, Square to, Value v)
  {

	if (Math.Abs((int)v) >= 324)
		return;

	table[(int)pc, (int)to] -= table[(int)pc, (int)to] * Math.Abs((int)v) / (CM ? 936 : 324);
	table[(int)pc, (int)to] += (int)v * 32;
  }

  private T[,] table = new T[(int)Piece.PIECE_NB, (int)Square.SQUARE_NB];
}


public class FromToStats
{

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value get(Color c, Move m) const
  public Value get(Color c, Move m)
  {
	  return table[(int)c, GlobalMembersBenchmark.from_sq(m), (int)GlobalMembersBenchmark.to_sq(m)];
  }
  public void clear()
  {
	  std.memset(table, 0, sizeof(Value));
  }
  public void update(Color c, Move m, Value v)
  {

	if (Math.Abs((int)v) >= 324)
		return;

	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);

	table[(int)c, from, (int)to] -= table[(int)c, from, (int)to] * Math.Abs((int)v) / 324;
	table[(int)c, from, (int)to] += (int)v * 32;
  }

  private Value[,,] table = new Value[(int)Color.COLOR_NB, Square.SQUARE_NB, (int)Square.SQUARE_NB];
}


/// MovePicker class is used to pick one pseudo legal move at a time from the
/// current position. The most important method is next_move(), which returns a
/// new pseudo legal move each time it is called, until there are no moves left,
/// when MOVE_NONE is returned. In order to improve the efficiency of the alpha
/// beta algorithm, MovePicker attempts to return the moves which are most likely
/// to get a cut-off first.
namespace Search
{
//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//	struct Stack;
}

public class MovePicker
{
//C++ TO C# CONVERTER TODO TASK: C# has no equivalent to ' = delete':
//ORIGINAL LINE: MovePicker(const MovePicker&) = delete;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  MovePicker(MovePicker NamelessParameter);
//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: MovePicker& operator =(const MovePicker&) = delete;
//C++ TO C# CONVERTER TODO TASK: C# has no equivalent to ' = delete':
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  MovePicker CopyFrom(MovePicker NamelessParameter);

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  MovePicker(Position NamelessParameter1, Move NamelessParameter2, Value NamelessParameter3);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  MovePicker(Position NamelessParameter1, Move NamelessParameter2, Depth NamelessParameter3, Square NamelessParameter4);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  MovePicker(Position NamelessParameter1, Move NamelessParameter2, Depth NamelessParameter3, Search::Stack NamelessParameter4);

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Move next_move();

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<GenType>
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void score<GenType>();
  private ExtMove begin<GenType>()
  {
	  return cur;
  }
  private ExtMove end()
  {
	  return endMoves;
  }

  private readonly Position pos;
  private Search.Stack ss;
  private Move countermove;
  private Depth depth;
  private Move ttMove;
  private Square recaptureSquare;
  private Value threshold;
  private int stage;
  private ExtMove cur;
  private ExtMove endMoves;
  private ExtMove endBadCaptures;
  private ExtMove[] moves = Arrays.InitializeWithDefaultInstances<ExtMove>(MAX_MOVES);
}



//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//class Position;

namespace Search
{

/// Stack struct keeps track of the information we need to remember from nodes
/// shallower and deeper in the tree during the search. Each search thread has
/// its own array of Stack objects, indexed by the current ply.

public class Stack
{
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: Move* pv;
  public Move pv;
  public int ply;
  public Move currentMove;
  public Move excludedMove;
  public Move[] killers = new Move[2];
  public Value staticEval;
  public Value history;
  public bool skipEarlyPruning;
  public int moveCount;
  public Stats<Value, true> counterMoves;
}


/// RootMove struct is used for moves at the root of the tree. For each root move
/// we store a score and a PV (really a refutation in the case of moves which
/// fail low). Score is normally set at -VALUE_INFINITE for all non-pv moves.

public class RootMove
{

  public RootMove(Move m)
  {
	  this.pv = new List<Move>(1, m);
  }

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool operator <(const RootMove& m) const
  public static bool operator < (RootMove ImpliedObject, RootMove m) // Descending sort
  {
	  return m.score < ImpliedObject.score;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool operator ==(const Move& m) const
  public static bool operator == (RootMove ImpliedObject, Move m)
  {
	  return ImpliedObject.pv[0] == m;
  }
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool extract_ponder_from_tt(Position pos);

  public Value score = -Value.VALUE_INFINITE;
  public Value previousScore = -Value.VALUE_INFINITE;
  public List<Move> pv = new List<Move>();
}



/// LimitsType struct stores information sent by GUI about available time to
/// search the current move, maximum depth/time, if we are in analysis mode or
/// if we have to ponder while it's our opponent's turn to move.

public class LimitsType
{

  public LimitsType() // Init explicitly due to broken value-initialization of non POD in MSVC
  {
	nodes = time[(int)Color.WHITE] = time[(int)Color.BLACK] = inc[(int)Color.WHITE] = inc[(int)Color.BLACK] = npmsec = movestogo = depth = movetime = mate = infinite = ponder = 0;
  }

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool use_time_management() const
  public bool use_time_management()
  {
	return !(mate | movetime | depth | nodes | infinite);
  }

  public List<Move> searchmoves = new List<Move>();
  public int[] time = new int[(int)Color.COLOR_NB];
  public int[] inc = new int[(int)Color.COLOR_NB];
  public int npmsec;
  public int movestogo;
  public int depth;
  public int movetime;
  public int mate;
  public int infinite;
  public int ponder;
  public long nodes;
  public std.chrono.milliseconds.rep startTime = new std.chrono.milliseconds.rep();
}


/// SignalsType struct stores atomic flags updated during the search, typically
/// in an async fashion e.g. to stop the search by the GUI.

public class SignalsType
{
  public std.atomic_bool stop = new std.atomic_bool();
  public std.atomic_bool stopOnPonderhit = new std.atomic_bool();
}

} // namespace Search


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

namespace UCI
{

//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//class Option;

/// Custom comparator because UCI options should be case insensitive
public class CaseInsensitiveLess <bool Root = true>
{
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool operator ()(const string&, const string&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  bool operator ()(string NamelessParameter1, string NamelessParameter2);
}

/// Our options container is actually a std::map

/// Option class implements an option as defined by UCI protocol
public class Option
{

  private delegate void OnChange(Option NamelessParameter);


//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Option(OnChange);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Option(bool v, OnChange);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Option(string v, OnChange);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Option(int v, int min, int max, OnChange);

//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: Option& operator =(const string&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  Option CopyFrom(string NamelessParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void operator <<(Option NamelessParameter);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: operator int() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  operator int();
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: operator string() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  operator string();
  public static bool BestMove;
//C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' function:
//ORIGINAL LINE: friend std::ostream& operator <<(std::ostream&, const ClassicMap<string, Option, CaseInsensitiveLess>&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  std::ostream operator <<(std::ostream NamelessParameter1, ClassicMap<string, Option, CaseInsensitiveLess>);

  private string defaultValue;
  private string currentValue;
  private string type;
  private int min;
  private int max;
  private uint idx;
  private OnChange on_change;
}

} // namespace UCI

/// Thread constructor launches the thread and then waits until it goes to sleep
/// in idle_loop().



/// Thread destructor waits for thread termination before returning



/// Thread::wait_for_search_finished() waits on sleep condition
/// until not searching



/// Thread::wait() waits on sleep condition until condition is true



/// Thread::start_searching() wakes up the thread that will start the search



/// Thread::idle_loop() is where the thread is parked when it has no work to do



/// ThreadPool::init() creates and launches requested threads that will go
/// immediately to sleep. We cannot use a constructor because Threads is a
/// static object and we need a fully initialized engine at this point due to
/// allocation of Endgames in the Thread constructor.



/// ThreadPool::exit() terminates threads before the program exits. Cannot be
/// done in destructor because threads must be terminated before deleting any
/// static objects while still in main().



/// ThreadPool::read_uci_options() updates internal threads parameters from the
/// corresponding UCI options and creates/destroys threads to match requested
/// number. Thread objects are dynamically allocated.



/// ThreadPool::nodes_searched() returns the number of nodes searched

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong ThreadPool::nodes_searched() const


/// ThreadPool::tb_hits() returns the number of TB hits

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong ThreadPool::tb_hits() const


/// ThreadPool::start_thinking() wakes up the main thread sleeping in idle_loop()
/// and starts a new search, then returns immediately.

