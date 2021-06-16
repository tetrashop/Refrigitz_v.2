using System.Diagnostics;
using System.Collections.Generic;



using System;

public static class GlobalMembersEndgame
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

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//std::ostream operator <<<bool Do>(std::ostream os, Position pos);

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

	  // Table used to drive the king towards the edge of the board
	  // in KX vs K and KQ vs KR endgames.
	  public static readonly int[] PushToEdges = {100, 90, 80, 70, 70, 80, 90, 100, 90, 70, 60, 50, 50, 60, 70, 90, 80, 60, 40, 30, 30, 40, 60, 80, 70, 50, 30, 20, 20, 30, 50, 70, 70, 50, 30, 20, 20, 30, 50, 70, 80, 60, 40, 30, 30, 40, 60, 80, 90, 70, 60, 50, 50, 60, 70, 90, 100, 90, 80, 70, 70, 80, 90, 100};

	  // Table used to drive the king towards a corner square of the
	  // right color in KBN vs K endgames.
	  public static readonly int[] PushToCorners = {200, 190, 180, 170, 160, 150, 140, 130, 190, 180, 170, 160, 150, 140, 130, 140, 180, 170, 155, 140, 140, 125, 140, 150, 170, 160, 140, 120, 110, 140, 150, 160, 160, 150, 140, 110, 120, 140, 160, 170, 150, 140, 125, 140, 140, 155, 170, 180, 140, 130, 140, 150, 160, 170, 180, 190, 130, 140, 150, 160, 170, 180, 190, 200};

	  // Tables used to drive a piece towards or away from another piece
	  public static readonly int[] PushClose = {0, 0, 100, 80, 60, 40, 20, 10};
	  public static readonly int[] PushAway = {0, 5, 20, 40, 60, 80, 90, 100};

	  // Pawn Rank based scaling factors used in KRPPKRP endgame
	  public static readonly int[] KRPPKRPScaleFactors = {0, 9, 10, 14, 21, 44, 0, 0};

	#if ! NDEBUG
	  public static bool verify_material(Position pos, Color c, Value npm, int pawnsCnt)
	  {
		return pos.non_pawn_material(c) == npm && pos.count<PieceType.PAWN>(c) == pawnsCnt;
	  }
	#endif

	  // Map the square as if strongSide is white and strongSide's only pawn
	  // is on the left half of the board.
	  public static Square normalize(Position pos, Color strongSide, Square sq)
	  {

		Debug.Assert(pos.count<PieceType.PAWN>(strongSide) == 1);

		if (GlobalMembersBenchmark.file_of(pos.square<PieceType.PAWN>(strongSide)) >= File.FILE_E)
		{
			sq = Square(sq ^ 7); // Mirror SQ_H1 -> SQ_A1
		}

		if (strongSide == Color.BLACK)
		{
			sq = ~sq;
		}

		return sq;
	  }

	  // Get the material key of Position out of the given endgame key code
	  // like "KBPKN". The trick here is to first forge an ad-hoc FEN string
	  // and then let a Position object do the work for us.
	  public static ulong key(string code, Color c)
	  {

		Debug.Assert(code.Length > 0 && code.Length < 8);
		Debug.Assert(code[0] == 'K');

		string[] sides = {code.Substring(code.IndexOf('K', 1)), code.Substring(0, code.IndexOf('K', 1))}; // Weak

		sides[(int)c] = sides[(int)c].ToLower();

		string fen = sides[0] + (char)(sbyte)(8 - sides[0].Length + '0') + "/8/8/8/8/8/8/" + sides[1] + (char)(sbyte)(8 - sides[1].Length + '0') + " w - - 0 10";

		StateInfo st = new StateInfo();
		return new Position().set(fen, false, st, null).material_key();
	  }



	/// Mate with KX vs K. This function is used to evaluate positions with
	/// king and plenty of material vs a lone king. It simply gives the
	/// attacking side a bonus for driving the defending king towards the edge
	/// of the board, and for keeping the distance between the two kings small.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KXK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KXK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));
	  Debug.Assert(pos.checkers() == 0); // Eval is never called when in check

	  // Stalemate detection with lone king
	  if (pos.side_to_move() == weakSide && !new MoveList<GenType.LEGAL>(pos).size())
	  {
		  return Value.VALUE_DRAW;
	  }

	  Square winnerKSq = pos.square<PieceType.KING>(strongSide);
	  Square loserKSq = pos.square<PieceType.KING>(weakSide);

	  Value result = pos.non_pawn_material(strongSide) + pos.count<PieceType.PAWN>(strongSide) * Value.PawnValueEg + PushToEdges[(int)loserKSq] + PushClose[GlobalMembersBenchmark.distance(winnerKSq, loserKSq)];

	  if (pos.count<PieceType.QUEEN>(strongSide) != 0 || pos.count<PieceType.ROOK>(strongSide) != 0 || (pos.count<PieceType.BISHOP>(strongSide) != 0 && pos.count<PieceType.KNIGHT>(strongSide) != 0) || (pos.count<PieceType.BISHOP>(strongSide) > 1 && GlobalMembersBenchmark.opposite_colors(pos.squares<PieceType.BISHOP>(strongSide)[0], pos.squares<PieceType.BISHOP>(strongSide)[1])))
	  {
		  result = Math.Min(result + Value.VALUE_KNOWN_WIN, Value.VALUE_MATE_IN_MAX_PLY - 1);
	  }

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// Mate with KBN vs K. This is similar to KX vs K, but we have to drive the
	/// defending king towards a corner square of the right color.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KBNK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KBNK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.KnightValueMg + Value.BishopValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  Square winnerKSq = pos.square<PieceType.KING>(strongSide);
	  Square loserKSq = pos.square<PieceType.KING>(weakSide);
	  Square bishopSq = pos.square<PieceType.BISHOP>(strongSide);

	  // kbnk_mate_table() tries to drive toward corners A1 or H8. If we have a
	  // bishop that cannot reach the above squares, we flip the kings in order
	  // to drive the enemy toward corners A8 or H1.
	  if (GlobalMembersBenchmark.opposite_colors(bishopSq, Square.SQ_A1))
	  {
		  winnerKSq = ~winnerKSq;
		  loserKSq = ~loserKSq;
	  }

	  Value result = Value.VALUE_KNOWN_WIN + PushClose[GlobalMembersBenchmark.distance(winnerKSq, loserKSq)] + PushToCorners[(int)loserKSq];

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KP vs K. This endgame is evaluated with the help of a bitbase.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KPK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KPK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.VALUE_ZERO, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square wksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(strongSide));
	  Square bksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(weakSide));
	  Square psq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.PAWN>(strongSide));

	  Color us = strongSide == ((int)pos.side_to_move()) != 0 ? Color.WHITE : Color.BLACK;

	  if (!GlobalMembersBitbase.probe(wksq, psq, bksq, us))
	  {
		  return Value.VALUE_DRAW;
	  }

	  Value result = Value.VALUE_KNOWN_WIN + Value.PawnValueEg + Value(GlobalMembersBenchmark.rank_of(psq));

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KR vs KP. This is a somewhat tricky endgame to evaluate precisely without
	/// a bitbase. The function below returns drawish scores when the pawn is
	/// far advanced with support of the king, while the attacking king is far
	/// away.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KRKP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KRKP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 1));

	  Square wksq = GlobalMembersBenchmark.relative_square(strongSide, pos.square<PieceType.KING>(strongSide));
	  Square bksq = GlobalMembersBenchmark.relative_square(strongSide, pos.square<PieceType.KING>(weakSide));
	  Square rsq = GlobalMembersBenchmark.relative_square(strongSide, pos.square<PieceType.ROOK>(strongSide));
	  Square psq = GlobalMembersBenchmark.relative_square(strongSide, pos.square<PieceType.PAWN>(weakSide));

	  Square queeningSq = GlobalMembersBenchmark.make_square(GlobalMembersBenchmark.file_of(psq), Rank.RANK_1);
	  Value result;

	  // If the stronger side's king is in front of the pawn, it's a win
	  if (wksq < psq && GlobalMembersBenchmark.file_of(wksq) == GlobalMembersBenchmark.file_of(psq))
	  {
		  result = Value.RookValueEg - GlobalMembersBenchmark.distance(wksq, psq);
	  }

	  // If the weaker side's king is too far from the pawn and the rook,
	  // it's a win.
	  else if (GlobalMembersBenchmark.distance(bksq, psq) >= 3 + (pos.side_to_move() == weakSide) && GlobalMembersBenchmark.distance(bksq, rsq) >= 3)
	  {
		  result = Value.RookValueEg - GlobalMembersBenchmark.distance(wksq, psq);
	  }

	  // If the pawn is far advanced and supported by the defending king,
	  // the position is drawish
	  else if (GlobalMembersBenchmark.rank_of(bksq) <= Rank.RANK_3 && GlobalMembersBenchmark.distance(bksq, psq) == 1 && GlobalMembersBenchmark.rank_of(wksq) >= Rank.RANK_4 && GlobalMembersBenchmark.distance(wksq, psq) > 2 + (pos.side_to_move() == strongSide))
	  {
		  result = Value(80) - 8 * GlobalMembersBenchmark.distance(wksq, psq);
	  }

	  else
	  {
		  result = Value(200) - 8 * (GlobalMembersBenchmark.distance(wksq, psq + Square.SOUTH) - GlobalMembersBenchmark.distance(bksq, psq + Square.SOUTH) - GlobalMembersBenchmark.distance(psq, queeningSq));
	  }

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KR vs KB. This is very simple, and always returns drawish scores.  The
	/// score is slightly bigger when the defending king is close to the edge.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KRKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KRKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  Value result = new Value(PushToEdges[(int)pos.square<PieceType.KING>(weakSide)]);
	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KR vs KN. The attacking side has slightly better winning chances than
	/// in KR vs KB, particularly if the king and the knight are far apart.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KRKN>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KRKN>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.KnightValueMg, 0));

	  Square bksq = pos.square<PieceType.KING>(weakSide);
	  Square bnsq = pos.square<PieceType.KNIGHT>(weakSide);
	  Value result = new Value(PushToEdges[(int)bksq] + PushAway[GlobalMembersBenchmark.distance(bksq, bnsq)]);
	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KQ vs KP. In general, this is a win for the stronger side, but there are a
	/// few important exceptions. A pawn on 7th rank and on the A,C,F or H files
	/// with a king positioned next to it can be a draw, so in that case, we only
	/// use the distance between the kings.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KQKP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KQKP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.QueenValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 1));

	  Square winnerKSq = pos.square<PieceType.KING>(strongSide);
	  Square loserKSq = pos.square<PieceType.KING>(weakSide);
	  Square pawnSq = pos.square<PieceType.PAWN>(weakSide);

	  Value result = new Value(PushClose[GlobalMembersBenchmark.distance(winnerKSq, loserKSq)]);

	  if (GlobalMembersBenchmark.relative_rank(weakSide, pawnSq) != Rank.RANK_7 || GlobalMembersBenchmark.distance(loserKSq, pawnSq) != 1 || !((FileABB | FileCBB | FileFBB | FileHBB) & (int)pawnSq))
	  {
		  result += Value.QueenValueEg - Value.PawnValueEg;
	  }

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// KQ vs KR.  This is almost identical to KX vs K:  We give the attacking
	/// king a bonus for having the kings close together, and for forcing the
	/// defending king towards the edge. If we also take care to avoid null move for
	/// the defending side in the search, this is usually sufficient to win KQ vs KR.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KQKR>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KQKR>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.QueenValueMg, 0));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.RookValueMg, 0));

	  Square winnerKSq = pos.square<PieceType.KING>(strongSide);
	  Square loserKSq = pos.square<PieceType.KING>(weakSide);

	  Value result = Value.QueenValueEg - Value.RookValueEg + PushToEdges[(int)loserKSq] + PushClose[GlobalMembersBenchmark.distance(winnerKSq, loserKSq)];

	  return strongSide == ((int)pos.side_to_move()) != 0 ? result : -result;
	}


	/// Some cases of trivial draws
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value Endgame<KNNK>::operator ()(const Position&) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static Value Endgame<KNNK>.operator ()(Position UnnamedParameter1)
	{
		return Value.VALUE_DRAW;
	}


	/// KB and one or more pawns vs K. It checks for draws with rook pawns and
	/// a bishop of the wrong color. If such a draw is detected, SCALE_FACTOR_DRAW
	/// is returned. If not, the return value is SCALE_FACTOR_NONE, i.e. no scaling
	/// will be used.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPsK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPsK>.operator ()(Position pos)
	{

	  Debug.Assert(pos.non_pawn_material(strongSide) == Value.BishopValueMg);
	  Debug.Assert(pos.count<PieceType.PAWN>(strongSide) >= 1);

	  // No assertions about the material of weakSide, because we want draws to
	  // be detected even when the weaker side has some pawns.

	  ulong pawns = pos.pieces(strongSide, PieceType.PAWN);
	  File pawnsFile = GlobalMembersBenchmark.file_of(GlobalMembersBenchmark.lsb(pawns));

	  // All pawns are on a single rook file?
	  if ((pawnsFile == File.FILE_A || pawnsFile == File.FILE_H) && !(pawns & ~GlobalMembersBenchmark.file_bb(pawnsFile)))
	  {
		  Square bishopSq = pos.square<PieceType.BISHOP>(strongSide);
		  Square queeningSq = GlobalMembersBenchmark.relative_square(strongSide, GlobalMembersBenchmark.make_square(pawnsFile, Rank.RANK_8));
		  Square kingSq = pos.square<PieceType.KING>(weakSide);

		  if (GlobalMembersBenchmark.opposite_colors(queeningSq, bishopSq) && GlobalMembersBenchmark.distance(queeningSq, kingSq) <= 1)
		  {
			  return ScaleFactor.SCALE_FACTOR_DRAW;
		  }
	  }

	  // If all the pawns are on the same B or G file, then it's potentially a draw
	  if ((pawnsFile == File.FILE_B || pawnsFile == File.FILE_G) && !(pos.pieces(PieceType.PAWN) & ~GlobalMembersBenchmark.file_bb(pawnsFile)) && pos.non_pawn_material(weakSide) == 0 && pos.count<PieceType.PAWN>(weakSide) >= 1)
	  {
		  // Get weakSide pawn that is closest to the home rank
		  Square weakPawnSq = GlobalMembersBenchmark.backmost_sq(weakSide, pos.pieces(weakSide, PieceType.PAWN));

		  Square strongKingSq = pos.square<PieceType.KING>(strongSide);
		  Square weakKingSq = pos.square<PieceType.KING>(weakSide);
		  Square bishopSq = pos.square<PieceType.BISHOP>(strongSide);

		  // There's potential for a draw if our pawn is blocked on the 7th rank,
		  // the bishop cannot attack it or they only have one pawn left
		  if (GlobalMembersBenchmark.relative_rank(strongSide, weakPawnSq) == Rank.RANK_7 && (pos.pieces(strongSide, PieceType.PAWN) & (weakPawnSq + GlobalMembersBenchmark.pawn_push(weakSide))) && (GlobalMembersBenchmark.opposite_colors(bishopSq, weakPawnSq) || pos.count<PieceType.PAWN>(strongSide) == 1))
		  {
			  int strongKingDist = GlobalMembersBenchmark.distance(weakPawnSq, strongKingSq);
			  int weakKingDist = GlobalMembersBenchmark.distance(weakPawnSq, weakKingSq);

			  // It's a draw if the weak king is on its back two ranks, within 2
			  // squares of the blocking pawn and the strong king is not
			  // closer. (I think this rule only fails in practically
			  // unreachable positions such as 5k1K/6p1/6P1/8/8/3B4/8/8 w
			  // and positions where qsearch will immediately correct the
			  // problem such as 8/4k1p1/6P1/1K6/3B4/8/8/8 w)
			  if (GlobalMembersBenchmark.relative_rank(strongSide, weakKingSq) >= Rank.RANK_7 && weakKingDist <= 2 && weakKingDist <= strongKingDist)
			  {
				  return ScaleFactor.SCALE_FACTOR_DRAW;
			  }
		  }
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KQ vs KR and one or more pawns. It tests for fortress draws with a rook on
	/// the third rank defended by a pawn.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KQKRPs>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KQKRPs>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.QueenValueMg, 0));
	  Debug.Assert(pos.count<PieceType.ROOK>(weakSide) == 1);
	  Debug.Assert(pos.count<PieceType.PAWN>(weakSide) >= 1);

	  Square kingSq = pos.square<PieceType.KING>(weakSide);
	  Square rsq = pos.square<PieceType.ROOK>(weakSide);

	  if (GlobalMembersBenchmark.relative_rank(weakSide, kingSq) <= Rank.RANK_2 && GlobalMembersBenchmark.relative_rank(weakSide, pos.square<PieceType.KING>(strongSide)) >= Rank.RANK_4 && GlobalMembersBenchmark.relative_rank(weakSide, rsq) == Rank.RANK_3 && (pos.pieces(weakSide, PieceType.PAWN) & pos.attacks_from<PieceType.KING>(kingSq) & pos.attacks_from<PieceType.PAWN>(rsq, strongSide)))
	  {
			  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KRP vs KR. This function knows a handful of the most important classes of
	/// drawn positions, but is far from perfect. It would probably be a good idea
	/// to add more knowledge in the future.
	///
	/// It would also be nice to rewrite the actual code for this function,
	/// which is mostly copied from Glaurung 1.x, and isn't very pretty.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KRPKR>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KRPKR>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.RookValueMg, 0));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square wksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(strongSide));
	  Square bksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(weakSide));
	  Square wrsq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.ROOK>(strongSide));
	  Square wpsq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.PAWN>(strongSide));
	  Square brsq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.ROOK>(weakSide));

	  File f = GlobalMembersBenchmark.file_of(wpsq);
	  Rank r = GlobalMembersBenchmark.rank_of(wpsq);
	  Square queeningSq = GlobalMembersBenchmark.make_square(f, Rank.RANK_8);
	  int tempo = (pos.side_to_move() == strongSide);

	  // If the pawn is not too far advanced and the defending king defends the
	  // queening square, use the third-rank defence.
	  if (r <= Rank.RANK_5 && GlobalMembersBenchmark.distance(bksq, queeningSq) <= 1 && wksq <= Square.SQ_H5 && (GlobalMembersBenchmark.rank_of(brsq) == Rank.RANK_6 || (r <= Rank.RANK_3 && GlobalMembersBenchmark.rank_of(wrsq) != Rank.RANK_6)))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // The defending side saves a draw by checking from behind in case the pawn
	  // has advanced to the 6th rank with the king behind.
	  if (r == Rank.RANK_6 && GlobalMembersBenchmark.distance(bksq, queeningSq) <= 1 && GlobalMembersBenchmark.rank_of(wksq) + tempo <= Rank.RANK_6 && (GlobalMembersBenchmark.rank_of(brsq) == Rank.RANK_1 || (tempo == 0 && distance<File>(brsq, wpsq) >= 3)))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  if (r >= Rank.RANK_6 && bksq == queeningSq && GlobalMembersBenchmark.rank_of(brsq) == Rank.RANK_1 && (tempo == 0 || GlobalMembersBenchmark.distance(wksq, wpsq) >= 2))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // White pawn on a7 and rook on a8 is a draw if black's king is on g7 or h7
	  // and the black rook is behind the pawn.
	  if (wpsq == Square.SQ_A7 && wrsq == Square.SQ_A8 && (bksq == Square.SQ_H7 || bksq == Square.SQ_G7) && GlobalMembersBenchmark.file_of(brsq) == File.FILE_A && (GlobalMembersBenchmark.rank_of(brsq) <= Rank.RANK_3 || GlobalMembersBenchmark.file_of(wksq) >= File.FILE_D || GlobalMembersBenchmark.rank_of(wksq) <= Rank.RANK_5))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // If the defending king blocks the pawn and the attacking king is too far
	  // away, it's a draw.
	  if (r <= Rank.RANK_5 && bksq == wpsq + Square.NORTH && GlobalMembersBenchmark.distance(wksq, wpsq) - tempo >= 2 && GlobalMembersBenchmark.distance(wksq, brsq) - tempo >= 2)
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // Pawn on the 7th rank supported by the rook from behind usually wins if the
	  // attacking king is closer to the queening square than the defending king,
	  // and the defending king cannot gain tempi by threatening the attacking rook.
	  if (r == Rank.RANK_7 && f != File.FILE_A && GlobalMembersBenchmark.file_of(wrsq) == f && wrsq != queeningSq && (GlobalMembersBenchmark.distance(wksq, queeningSq) < GlobalMembersBenchmark.distance(bksq, queeningSq) - 2 + tempo) && (GlobalMembersBenchmark.distance(wksq, queeningSq) < GlobalMembersBenchmark.distance(bksq, wrsq) + tempo))
	  {
		  return ScaleFactor(ScaleFactor.SCALE_FACTOR_MAX - 2 * GlobalMembersBenchmark.distance(wksq, queeningSq));
	  }

	  // Similar to the above, but with the pawn further back
	  if (f != File.FILE_A && GlobalMembersBenchmark.file_of(wrsq) == f && wrsq < wpsq && (GlobalMembersBenchmark.distance(wksq, queeningSq) < GlobalMembersBenchmark.distance(bksq, queeningSq) - 2 + tempo) && (GlobalMembersBenchmark.distance(wksq, wpsq + Square.NORTH) < GlobalMembersBenchmark.distance(bksq, wpsq + Square.NORTH) - 2 + tempo) && (GlobalMembersBenchmark.distance(bksq, wrsq) + tempo >= 3 || (GlobalMembersBenchmark.distance(wksq, queeningSq) < GlobalMembersBenchmark.distance(bksq, wrsq) + tempo && (GlobalMembersBenchmark.distance(wksq, wpsq + Square.NORTH) < GlobalMembersBenchmark.distance(bksq, wrsq) + tempo))))
	  {
		  return ScaleFactor(ScaleFactor.SCALE_FACTOR_MAX - 8 * GlobalMembersBenchmark.distance(wpsq, queeningSq) - 2 * GlobalMembersBenchmark.distance(wksq, queeningSq));
	  }

	  // If the pawn is not far advanced and the defending king is somewhere in
	  // the pawn's path, it's probably a draw.
	  if (r <= Rank.RANK_4 && bksq > wpsq)
	  {
		  if (GlobalMembersBenchmark.file_of(bksq) == GlobalMembersBenchmark.file_of(wpsq))
		  {
			  return ScaleFactor(10);
		  }
		  if (distance<File>(bksq, wpsq) == 1 && GlobalMembersBenchmark.distance(wksq, bksq) > 2)
		  {
			  return ScaleFactor(24 - 2 * GlobalMembersBenchmark.distance(wksq, bksq));
		  }
	  }
	  return ScaleFactor.SCALE_FACTOR_NONE;
	}

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KRPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KRPKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  // Test for a rook pawn
	  if ((pos.pieces(PieceType.PAWN) & (FileABB | FileHBB)) != 0)
	  {
		  Square ksq = pos.square<PieceType.KING>(weakSide);
		  Square bsq = pos.square<PieceType.BISHOP>(weakSide);
		  Square psq = pos.square<PieceType.PAWN>(strongSide);
		  Rank rk = GlobalMembersBenchmark.relative_rank(strongSide, psq);
		  Square push = GlobalMembersBenchmark.pawn_push(strongSide);

		  // If the pawn is on the 5th rank and the pawn (currently) is on
		  // the same color square as the bishop then there is a chance of
		  // a fortress. Depending on the king position give a moderate
		  // reduction or a stronger one if the defending king is near the
		  // corner but not trapped there.
		  if (rk == Rank.RANK_5 && !GlobalMembersBenchmark.opposite_colors(bsq, psq))
		  {
			  int d = GlobalMembersBenchmark.distance(psq + 3 * push, ksq);

			  if (d <= 2 && !(d == 0 && ksq == pos.square<PieceType.KING>(strongSide) + 2 * push))
			  {
				  return ScaleFactor(24);
			  }
			  else
			  {
				  return ScaleFactor(48);
			  }
		  }

		  // When the pawn has moved to the 6th rank we can be fairly sure
		  // it's drawn if the bishop attacks the square in front of the
		  // pawn from a reasonable distance and the defending king is near
		  // the corner
		  if (rk == Rank.RANK_6 && GlobalMembersBenchmark.distance(psq + 2 * push, ksq) <= 1 && (GlobalMembersBitboard.PseudoAttacks[(int)PieceType.BISHOP, (int)bsq] & (psq + push)) && distance<File>(bsq, psq) >= 2)
		  {
			  return ScaleFactor(8);
		  }
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}

	/// KRPP vs KRP. There is just a single rule: if the stronger side has no passed
	/// pawns and the defending king is actively placed, the position is drawish.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KRPPKRP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KRPPKRP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.RookValueMg, 2));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.RookValueMg, 1));

	  Square wpsq1 = pos.squares<PieceType.PAWN>(strongSide)[0];
	  Square wpsq2 = pos.squares<PieceType.PAWN>(strongSide)[1];
	  Square bksq = pos.square<PieceType.KING>(weakSide);

	  // Does the stronger side have a passed pawn?
	  if (pos.pawn_passed(strongSide, wpsq1) || pos.pawn_passed(strongSide, wpsq2))
	  {
		  return ScaleFactor.SCALE_FACTOR_NONE;
	  }

	  Rank r = Math.Max(GlobalMembersBenchmark.relative_rank(strongSide, wpsq1), GlobalMembersBenchmark.relative_rank(strongSide, wpsq2));

	  if (distance<File>(bksq, wpsq1) <= 1 && distance<File>(bksq, wpsq2) <= 1 && GlobalMembersBenchmark.relative_rank(strongSide, bksq) > r)
	  {
		  Debug.Assert(r > Rank.RANK_1 && r < Rank.RANK_7);
		  return ScaleFactor(KRPPKRPScaleFactors[(int)r]);
	  }
	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// K and two or more pawns vs K. There is just a single rule here: If all pawns
	/// are on the same rook file and are blocked by the defending king, it's a draw.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KPsK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KPsK>.operator ()(Position pos)
	{

	  Debug.Assert(pos.non_pawn_material(strongSide) == Value.VALUE_ZERO);
	  Debug.Assert(pos.count<PieceType.PAWN>(strongSide) >= 2);
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  Square ksq = pos.square<PieceType.KING>(weakSide);
	  ulong pawns = pos.pieces(strongSide, PieceType.PAWN);

	  // If all pawns are ahead of the king, on a single rook file and
	  // the king is within one file of the pawns, it's a draw.
	  if (!(pawns & ~GlobalMembersBenchmark.in_front_bb(weakSide, GlobalMembersBenchmark.rank_of(ksq))) && !((pawns & ~FileABB) && (pawns & ~FileHBB)) && distance<File>(ksq, GlobalMembersBenchmark.lsb(pawns)) <= 1)
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KBP vs KB. There are two rules: if the defending king is somewhere along the
	/// path of the pawn, and the square of the king is not of the same color as the
	/// stronger side's bishop, it's a draw. If the two bishops have opposite color,
	/// it's almost always a draw.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.BishopValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  Square pawnSq = pos.square<PieceType.PAWN>(strongSide);
	  Square strongBishopSq = pos.square<PieceType.BISHOP>(strongSide);
	  Square weakBishopSq = pos.square<PieceType.BISHOP>(weakSide);
	  Square weakKingSq = pos.square<PieceType.KING>(weakSide);

	  // Case 1: Defending king blocks the pawn, and cannot be driven away
	  if (GlobalMembersBenchmark.file_of(weakKingSq) == GlobalMembersBenchmark.file_of(pawnSq) && GlobalMembersBenchmark.relative_rank(strongSide, pawnSq) < GlobalMembersBenchmark.relative_rank(strongSide, weakKingSq) && (GlobalMembersBenchmark.opposite_colors(weakKingSq, strongBishopSq) || GlobalMembersBenchmark.relative_rank(strongSide, weakKingSq) <= Rank.RANK_6))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  // Case 2: Opposite colored bishops
	  if (GlobalMembersBenchmark.opposite_colors(strongBishopSq, weakBishopSq))
	  {
		  // We assume that the position is drawn in the following three situations:
		  //
		  //   a. The pawn is on rank 5 or further back.
		  //   b. The defending king is somewhere in the pawn's path.
		  //   c. The defending bishop attacks some square along the pawn's path,
		  //      and is at least three squares away from the pawn.
		  //
		  // These rules are probably not perfect, but in practice they work
		  // reasonably well.

		  if (GlobalMembersBenchmark.relative_rank(strongSide, pawnSq) <= Rank.RANK_5)
		  {
			  return ScaleFactor.SCALE_FACTOR_DRAW;
		  }
		  else
		  {
			  ulong path = GlobalMembersBenchmark.forward_bb(strongSide, pawnSq);

			  if ((path & pos.pieces(weakSide, PieceType.KING)) != 0)
			  {
				  return ScaleFactor.SCALE_FACTOR_DRAW;
			  }

			  if ((pos.attacks_from<PieceType.BISHOP>(weakBishopSq) & path) && GlobalMembersBenchmark.distance(weakBishopSq, pawnSq) >= 3)
			  {
				  return ScaleFactor.SCALE_FACTOR_DRAW;
			  }
		  }
	  }
	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KBPP vs KB. It detects a few basic draws with opposite-colored bishops
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPPKB>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.BishopValueMg, 2));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.BishopValueMg, 0));

	  Square wbsq = pos.square<PieceType.BISHOP>(strongSide);
	  Square bbsq = pos.square<PieceType.BISHOP>(weakSide);

	  if (!GlobalMembersBenchmark.opposite_colors(wbsq, bbsq))
	  {
		  return ScaleFactor.SCALE_FACTOR_NONE;
	  }

	  Square ksq = pos.square<PieceType.KING>(weakSide);
	  Square psq1 = pos.squares<PieceType.PAWN>(strongSide)[0];
	  Square psq2 = pos.squares<PieceType.PAWN>(strongSide)[1];
	  Rank r1 = GlobalMembersBenchmark.rank_of(psq1);
	  Rank r2 = GlobalMembersBenchmark.rank_of(psq2);
	  Square blockSq1;
	  Square blockSq2;

	  if (GlobalMembersBenchmark.relative_rank(strongSide, psq1) > GlobalMembersBenchmark.relative_rank(strongSide, psq2))
	  {
		  blockSq1 = psq1 + GlobalMembersBenchmark.pawn_push(strongSide);
		  blockSq2 = GlobalMembersBenchmark.make_square(GlobalMembersBenchmark.file_of(psq2), GlobalMembersBenchmark.rank_of(psq1));
	  }
	  else
	  {
		  blockSq1 = psq2 + GlobalMembersBenchmark.pawn_push(strongSide);
		  blockSq2 = GlobalMembersBenchmark.make_square(GlobalMembersBenchmark.file_of(psq1), GlobalMembersBenchmark.rank_of(psq2));
	  }

	  switch (distance<File>(psq1, psq2))
	  {
	  case 0:
		// Both pawns are on the same file. It's an easy draw if the defender firmly
		// controls some square in the frontmost pawn's path.
		if (GlobalMembersBenchmark.file_of(ksq) == GlobalMembersBenchmark.file_of(blockSq1) && GlobalMembersBenchmark.relative_rank(strongSide, ksq) >= GlobalMembersBenchmark.relative_rank(strongSide, blockSq1) && GlobalMembersBenchmark.opposite_colors(ksq, wbsq))
		{
			return ScaleFactor.SCALE_FACTOR_DRAW;
		}
		else
		{
			return ScaleFactor.SCALE_FACTOR_NONE;
		}

	  case 1:
		// Pawns on adjacent files. It's a draw if the defender firmly controls the
		// square in front of the frontmost pawn's path, and the square diagonally
		// behind this square on the file of the other pawn.
		if (ksq == blockSq1 && GlobalMembersBenchmark.opposite_colors(ksq, wbsq) && (bbsq == blockSq2 || (pos.attacks_from<PieceType.BISHOP>(blockSq2) & pos.pieces(weakSide, PieceType.BISHOP)) || GlobalMembersBenchmark.distance(r1, r2) >= 2))
		{
			return ScaleFactor.SCALE_FACTOR_DRAW;
		}

		else if (ksq == blockSq2 && GlobalMembersBenchmark.opposite_colors(ksq, wbsq) && (bbsq == blockSq1 || (pos.attacks_from<PieceType.BISHOP>(blockSq1) & pos.pieces(weakSide, PieceType.BISHOP))))
		{
			return ScaleFactor.SCALE_FACTOR_DRAW;
		}
		else
		{
			return ScaleFactor.SCALE_FACTOR_NONE;
		}

	  default:
		// The pawns are not on the same file or adjacent files. No scaling.
		return ScaleFactor.SCALE_FACTOR_NONE;
	  }
	}


	/// KBP vs KN. There is a single rule: If the defending king is somewhere along
	/// the path of the pawn, and the square of the king is not of the same color as
	/// the stronger side's bishop, it's a draw.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KBPKN>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KBPKN>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.BishopValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.KnightValueMg, 0));

	  Square pawnSq = pos.square<PieceType.PAWN>(strongSide);
	  Square strongBishopSq = pos.square<PieceType.BISHOP>(strongSide);
	  Square weakKingSq = pos.square<PieceType.KING>(weakSide);

	  if (GlobalMembersBenchmark.file_of(weakKingSq) == GlobalMembersBenchmark.file_of(pawnSq) && GlobalMembersBenchmark.relative_rank(strongSide, pawnSq) < GlobalMembersBenchmark.relative_rank(strongSide, weakKingSq) && (GlobalMembersBenchmark.opposite_colors(weakKingSq, strongBishopSq) || GlobalMembersBenchmark.relative_rank(strongSide, weakKingSq) <= Rank.RANK_6))
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KNP vs K. There is a single rule: if the pawn is a rook pawn on the 7th rank
	/// and the defending king prevents the pawn from advancing, the position is drawn.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KNPK>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KNPK>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.KnightValueMg, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 0));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square pawnSq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.PAWN>(strongSide));
	  Square weakKingSq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(weakSide));

	  if (pawnSq == Square.SQ_A7 && GlobalMembersBenchmark.distance(Square.SQ_A8, weakKingSq) <= 1)
	  {
		  return ScaleFactor.SCALE_FACTOR_DRAW;
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KNP vs KB. If knight can block bishop from taking pawn, it's a win.
	/// Otherwise the position is drawn.
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KNPKB>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KNPKB>.operator ()(Position pos)
	{

	  Square pawnSq = pos.square<PieceType.PAWN>(strongSide);
	  Square bishopSq = pos.square<PieceType.BISHOP>(weakSide);
	  Square weakKingSq = pos.square<PieceType.KING>(weakSide);

	  // King needs to get close to promoting pawn to prevent knight from blocking.
	  // Rules for this are very tricky, so just approximate.
	  if ((GlobalMembersBenchmark.forward_bb(strongSide, pawnSq) & pos.attacks_from<PieceType.BISHOP>(bishopSq)) != 0)
	  {
		  return ScaleFactor(GlobalMembersBenchmark.distance(weakKingSq, pawnSq));
	  }

	  return ScaleFactor.SCALE_FACTOR_NONE;
	}


	/// KP vs KP. This is done by removing the weakest side's pawn and probing the
	/// KP vs K bitbase: If the weakest side has a draw without the pawn, it probably
	/// has at least a draw with the pawn as well. The exception is when the stronger
	/// side's pawn is far advanced and not on a rook file; in this case it is often
	/// possible to win (e.g. 8/4k3/3p4/3P4/6K1/8/8/8 w - - 0 1).
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ScaleFactor Endgame<KPKP>::operator ()(const Position& pos) const
//C++ TO C# CONVERTER TODO TASK: The () operator cannot be overloaded in C#:
	public static ScaleFactor Endgame<KPKP>.operator ()(Position pos)
	{

	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, strongSide, Value.VALUE_ZERO, 1));
	  Debug.Assert(GlobalMembersEndgame.verify_material(pos, weakSide, Value.VALUE_ZERO, 1));

	  // Assume strongSide is white and the pawn is on files A-D
	  Square wksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(strongSide));
	  Square bksq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.KING>(weakSide));
	  Square psq = GlobalMembersEndgame.normalize(pos, strongSide, pos.square<PieceType.PAWN>(strongSide));

	  Color us = strongSide == ((int)pos.side_to_move()) != 0 ? Color.WHITE : Color.BLACK;

	  // If the pawn has advanced to the fifth rank or further, and is not a
	  // rook pawn, it's too dangerous to assume that it's at least a draw.
	  if (GlobalMembersBenchmark.rank_of(psq) >= Rank.RANK_5 && GlobalMembersBenchmark.file_of(psq) != File.FILE_A)
	  {
		  return ScaleFactor.SCALE_FACTOR_NONE;
	  }

	  // Probe the KPK bitbase with the weakest side's pawn removed. If it's a draw,
	  // it's probably at least a draw even with the pawn.
	  return GlobalMembersBitbase.probe(wksq, psq, bksq, us) ? ScaleFactor.SCALE_FACTOR_NONE : ScaleFactor.SCALE_FACTOR_DRAW;
	}
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
  private void add<EndgameType E, T = eg_type<E>>(string code)
  {
	SortedDictionary<T>()[GlobalMembersEndgame.key(code, Color.WHITE)] = std.unique_ptr<EndgameBase<T>>(new Endgame<E>(Color.WHITE));
	SortedDictionary<T>()[GlobalMembersEndgame.key(code, Color.BLACK)] = std.unique_ptr<EndgameBase<T>>(new Endgame<E>(Color.BLACK));
  }

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
  private Map<T> map<T>()
  {
	return std.get<std.is_same<T, ScaleFactor>.value>(maps);
  }

  private std.pair<Map<Value>, Map<ScaleFactor>> maps = new std.pair<Map<Value>, Map<ScaleFactor>>();


  /// Endgames members definitions

  public Endgames()
  {

	add<EndgameType.KPK>("KPK");
	add<EndgameType.KNNK>("KNNK");
	add<EndgameType.KBNK>("KBNK");
	add<EndgameType.KRKP>("KRKP");
	add<EndgameType.KRKB>("KRKB");
	add<EndgameType.KRKN>("KRKN");
	add<EndgameType.KQKP>("KQKP");
	add<EndgameType.KQKR>("KQKR");

	add<EndgameType.KNPK>("KNPK");
	add<EndgameType.KNPKB>("KNPKB");
	add<EndgameType.KRPKR>("KRPKR");
	add<EndgameType.KRPKB>("KRPKB");
	add<EndgameType.KBPKB>("KBPKB");
	add<EndgameType.KBPKN>("KBPKN");
	add<EndgameType.KBPPKB>("KBPPKB");
	add<EndgameType.KRPPKRP>("KRPPKRP");
  }

//C++ TO C# CONVERTER TODO TASK: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
//ORIGINAL LINE: template<typename T>
  public EndgameBase<T> probe<T>(ulong key)
  {
	return new SortedDictionary<T>().count(key) ? new SortedDictionary<T>()[key].get() : null;
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



//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//class Position;

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

//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace
