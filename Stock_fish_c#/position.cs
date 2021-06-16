using System.Diagnostics;
using System.Collections.Generic;
using System;




public static class GlobalMembersPosition
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

/// operator<<(Position) returns an ASCII representation of the position


	public static std.ostream operator << (std.ostream os, Position pos)
	{

	  os << "\n +---+---+---+---+---+---+---+---+\n";

	  for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r)
	  {
		  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
		  {
			  os << " | " << PieceToChar[(int)pos.piece_on(GlobalMembersBenchmark.make_square(f, r))];
		  }

		  os << " |\n +---+---+---+---+---+---+---+---+\n";
	  }

	  os << "\nFen: " << pos.fen() << "\nKey: " << std.hex << std.uppercase << std.setfill('0') << std.setw(16) << (int)pos.key() << std.dec << "\nCheckers: ";

	  for (ulong b = pos.checkers(); b != 0;)
	  {
		  os << GlobalMembersUci.square(GlobalMembersBenchmark.pop_lsb(ref b)) << " ";
	  }

	  return os;
	}

//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern TranspositionTable TT;


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
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern Score psq[PIECE_NB][SQUARE_NB];

	  public static ulong[,] psq = new ulong[(int)Piece.PIECE_NB, (int)Square.SQUARE_NB];
	  public static ulong[] enpassant = new ulong[(int)File.FILE_NB];
	  public static ulong[] castling = new ulong[(int)CastlingRight.CASTLING_RIGHT_NB];
	  public static ulong side;
	public static PieceType min_attacker<int Pt>(ulong[] bb, Square to, ulong stmAttackers, ref ulong occupied, ref ulong attackers)
	{

	  ulong b = stmAttackers & bb[Pt];
	  if (b == 0)
	  {
		  return min_attacker < Pt + 1>(bb, to, stmAttackers, occupied, attackers);
	  }

	  occupied ^= b & ~(b - 1);

	  if (Pt == PieceType.PAWN || Pt == PieceType.BISHOP || Pt == PieceType.QUEEN)
	  {
		  attackers |= attacks_bb<PieceType.BISHOP>(to, occupied) & (bb[(int)PieceType.BISHOP] | bb[(int)PieceType.QUEEN]);
	  }

	  if (Pt == PieceType.ROOK || Pt == PieceType.QUEEN)
	  {
		  attackers |= attacks_bb<PieceType.ROOK>(to, occupied) & (bb[(int)PieceType.ROOK] | bb[(int)PieceType.QUEEN]);
	  }

	  attackers &= occupied; // After X-ray that may add already processed pieces
	  return (PieceType)Pt;
	}

	public static PieceType min_attacker(ulong UnnamedParameter1, Square UnnamedParameter2, ulong UnnamedParameter3, ref ulong UnnamedParameter4, ref ulong UnnamedParameter5)
	{
	  return PieceType.KING; // No need to update bitboards: it is the last cycle
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

  /// Position::init() initializes at startup the various arrays used to compute
  /// hash keys.

  public static void init()
  {

	PRNG rng = new PRNG(1070372);

	foreach (Piece pc in GlobalMembersBenchmark.Pieces)
	{
		for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
		{
			GlobalMembersPosition.psq[(int)pc, (int)s] = rng.rand<ulong>();
		}
	}

	for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	{
		GlobalMembersPosition.enpassant[(int)f] = rng.rand<ulong>();
	}

	for (int cr = (int)CastlingRight.NO_CASTLING; cr <= CastlingRight.ANY_CASTLING; ++cr)
	{
		GlobalMembersPosition.castling[cr] = 0;
		ulong b = cr;
		while (b != 0)
		{
			ulong k = GlobalMembersPosition.castling[1UL << GlobalMembersBenchmark.pop_lsb(ref b)];
			GlobalMembersPosition.castling[cr] ^= k != 0 ? k : rng.rand<ulong>();
		}
	}

	GlobalMembersPosition.side = rng.rand<ulong>();
  }

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

  /// Position::set() initializes the position object with the given FEN string.
  /// This function is not very robust - make sure that input FENs are correct,
  /// this is assumed to be the responsibility of the GUI.

  public Position set(string fenStr, bool isChess960, StateInfo si, Thread th)
  {
  /*
     A FEN string defines a particular position using only the ASCII character set.
  
     A FEN string contains six fields separated by a space. The fields are:
  
     1) Piece placement (from white's perspective). Each rank is described, starting
        with rank 8 and ending with rank 1. Within each rank, the contents of each
        square are described from file A through file H. Following the Standard
        Algebraic Notation (SAN), each piece is identified by a single letter taken
        from the standard English names. White pieces are designated using upper-case
        letters ("PNBRQK") whilst Black uses lowercase ("pnbrqk"). Blank squares are
        noted using digits 1 through 8 (the number of blank squares), and "/"
        separates ranks.
  
     2) Active color. "w" means white moves next, "b" means black.
  
     3) Castling availability. If neither side can castle, this is "-". Otherwise,
        this has one or more letters: "K" (White can castle kingside), "Q" (White
        can castle queenside), "k" (Black can castle kingside), and/or "q" (Black
        can castle queenside).
  
     4) En passant target square (in algebraic notation). If there's no en passant
        target square, this is "-". If a pawn has just made a 2-square move, this
        is the position "behind" the pawn. This is recorded regardless of whether
        there is a pawn in position to make an en passant capture.
  
     5) Halfmove clock. This is the number of halfmoves since the last pawn advance
        or capture. This is used to determine if a draw can be claimed under the
        fifty-move rule.
  
     6) Fullmove number. The number of the full move. It starts at 1, and is
        incremented after Black's move.
  */

	byte col;
	byte row;
	byte token;
	uint idx;
	Square sq = Square.SQ_A8;
	std.istringstream ss = new std.istringstream(fenStr);

	std.memset(this, 0, sizeof(Position));
	std.memset(si, 0, sizeof(StateInfo));
//C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
//ORIGINAL LINE: std::fill_n(&pieceList[0][0], sizeof(pieceList) / sizeof(Square), SQ_NONE);
	std.fill_n(pieceList[0, 0], pieceList.Length, Square.SQ_NONE);
	st = si;

	ss >> std.noskipws;

	// 1. Piece placement
	while ((ss >> token) && !char.IsWhiteSpace(token))
	{
		if (char.IsDigit(token))
		{
			sq += Square(token - '0'); // Advance the given number of files
		}

		else if (token == '/')
		{
			sq -= Square(16);
		}

		else if ((idx = PieceToChar.find(token)) != string.npos)
		{
			put_piece(Piece(idx), sq);
			++sq;
		}
	}

	// 2. Active color
	ss >> token;
	sideToMove = (token == 'w' ? Color.WHITE : Color.BLACK);
	ss >> token;

	// 3. Castling availability. Compatible with 3 standards: Normal FEN standard,
	// Shredder-FEN that uses the letters of the columns on which the rooks began
	// the game instead of KQkq and also X-FEN standard that, in case of Chess960,
	// if an inner rook is associated with the castling right, the castling tag is
	// replaced by the file letter of the involved rook, as for the Shredder-FEN.
	while ((ss >> token) && !char.IsWhiteSpace(token))
	{
		Square rsq;
		Color c = char.IsLower(token) ? Color.BLACK : Color.WHITE;
		Piece rook = GlobalMembersBenchmark.make_piece(c, PieceType.ROOK);

		token = (sbyte)char.ToUpper(token);

		if (token == 'K')
		{
			for (rsq = GlobalMembersBenchmark.relative_square(c, Square.SQ_H1); piece_on(rsq) != rook; --rsq)
			{
			}
		}

		else if (token == 'Q')
		{
			for (rsq = GlobalMembersBenchmark.relative_square(c, Square.SQ_A1); piece_on(rsq) != rook; ++rsq)
			{
			}
		}

		else if (token >= 'A' && token <= 'H')
		{
			rsq = GlobalMembersBenchmark.make_square(File(token - 'A'), GlobalMembersBenchmark.relative_rank(c, Rank.RANK_1));
		}

		else
			continue;

		set_castling_right(c, rsq);
	}

	// 4. En passant square. Ignore if no pawn capture is possible
	if (((ss >> col) && (col >= 'a' && col <= 'h')) && ((ss >> row) && (row == '3' || row == '6')))
	{
		st.epSquare = GlobalMembersBenchmark.make_square(File(col - 'a'), Rank(row - '1'));

		if (((attackers_to(st.epSquare) & pieces(sideToMove, PieceType.PAWN)) == 0)
		{
			st.epSquare = Square.SQ_NONE;
		}
	}
	else
	{
		st.epSquare = Square.SQ_NONE;
	}

	// 5-6. Halfmove clock and fullmove number
	ss >> std.skipws >> st.rule50 >> gamePly;

	// Convert from fullmove starting from 1 to ply starting from 0,
	// handle also common incorrect FEN with fullmove = 0.
	gamePly = Math.Max(2 * (gamePly - 1), 0) + (sideToMove == Color.BLACK);

	chess960 = isChess960;
	thisThread = th;
	set_state(st);

	Debug.Assert(pos_is_ok());

	return this;
  }

  /// Position::fen() returns a FEN representation of the position. In case of
  /// Chess960 the Shredder-FEN notation is used. This is mainly a debugging function.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: const string fen() const
  public string fen()
  {

	int emptyCnt;
	std.ostringstream ss = new std.ostringstream();

	for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r)
	{
		for (File f = File.FILE_A; f <= File.FILE_H; ++f)
		{
			for (emptyCnt = 0; f <= File.FILE_H && empty(GlobalMembersBenchmark.make_square(f, r)); ++f)
			{
				++emptyCnt;
			}

			if (emptyCnt != 0)
			{
				ss << emptyCnt;
			}

			if (f <= File.FILE_H)
			{
				ss << PieceToChar[(int)piece_on(GlobalMembersBenchmark.make_square(f, r))];
			}
		}

		if (r > Rank.RANK_1)
		{
			ss << '/';
		}
	}

	ss << (sideToMove == ((int)Color.WHITE) != 0 ? " w " : " b ");

	if (can_castle(CastlingRight.WHITE_OO) != 0)
	{
		ss << (chess960 ? (sbyte)('A' + GlobalMembersBenchmark.file_of(castling_rook_square((int)Color.WHITE | (int)CastlingSide.KING_SIDE))) : 'K');
	}

	if (can_castle(CastlingRight.WHITE_OOO) != 0)
	{
		ss << (chess960 ? (sbyte)('A' + GlobalMembersBenchmark.file_of(castling_rook_square((int)Color.WHITE | (int)CastlingSide.QUEEN_SIDE))) : 'Q');
	}

	if (can_castle(CastlingRight.BLACK_OO) != 0)
	{
		ss << (chess960 ? (sbyte)('a' + GlobalMembersBenchmark.file_of(castling_rook_square((int)Color.BLACK | (int)CastlingSide.KING_SIDE))) : 'k');
	}

	if (can_castle(CastlingRight.BLACK_OOO) != 0)
	{
		ss << (chess960 ? (sbyte)('a' + GlobalMembersBenchmark.file_of(castling_rook_square((int)Color.BLACK | (int)CastlingSide.QUEEN_SIDE))) : 'q');
	}

	if (can_castle(Color.WHITE) == 0 && can_castle(Color.BLACK) == 0)
	{
		ss << '-';
	}

	ss << (ep_square() == ((int)Square.SQ_NONE) != 0 ? " - " : " " + GlobalMembersUci.square(ep_square()) + " ") << st.rule50 << " " << 1 + (gamePly - (sideToMove == Color.BLACK)) / 2;

	return ss.str();
  }

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

  /// Position::attackers_to() computes a bitboard of all pieces which attack a
  /// given square. Slider attacks use the occupied bitboard to indicate occupancy.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong attackers_to(Square s, ulong occupied) const
  public ulong attackers_to(Square s, ulong occupied)
  {

	return (attacks_from<PieceType.PAWN>(s, Color.BLACK) & pieces(Color.WHITE, PieceType.PAWN)) | (attacks_from<PieceType.PAWN>(s, Color.WHITE) & pieces(Color.BLACK, PieceType.PAWN)) | (attacks_from<PieceType.KNIGHT>(s) & pieces(PieceType.KNIGHT)) | (attacks_bb<PieceType.ROOK >(s, occupied) & pieces(PieceType.ROOK, PieceType.QUEEN)) | (attacks_bb<PieceType.BISHOP>(s, occupied) & pieces(PieceType.BISHOP, PieceType.QUEEN)) | (attacks_from<PieceType.KING>(s) & pieces(PieceType.KING));
  }
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

  /// Position::slider_blockers() returns a bitboard of all the pieces (both colors)
  /// that are blocking attacks on the square 's' from 'sliders'. A piece blocks a
  /// slider if removing that piece from the board would result in a position where
  /// square 's' is attacked. For example, a king-attack blocking piece can be either
  /// a pinned or a discovered check piece, according if its color is the opposite
  /// or the same of the color of the slider.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong slider_blockers(ulong sliders, Square s, ulong& pinners) const
  public ulong slider_blockers(ulong sliders, Square s, ref ulong pinners)
  {

	ulong result = 0;
	pinners = 0;

	// Snipers are sliders that attack 's' when a piece is removed
	ulong snipers = ((GlobalMembersBitboard.PseudoAttacks[(int)PieceType.ROOK, (int)s] & pieces(PieceType.QUEEN, PieceType.ROOK)) | (GlobalMembersBitboard.PseudoAttacks[(int)PieceType.BISHOP, (int)s] & pieces(PieceType.QUEEN, PieceType.BISHOP))) & sliders;

	while (snipers != 0)
	{
	  Square sniperSq = GlobalMembersBenchmark.pop_lsb(ref snipers);
	  ulong b = GlobalMembersBenchmark.between_bb(s, sniperSq) & pieces();

	  if (!GlobalMembersBenchmark.more_than_one(b))
	  {
		  result |= b;
		  if ((b & pieces(GlobalMembersBenchmark.color_of(piece_on(s)))) != 0)
		  {
			  pinners |= sniperSq;
		  }
	  }
	}
	return result;
  }

  // Properties of moves

  /// Position::legal() tests whether a pseudo-legal move is legal

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool legal(Move m) const
  public bool legal(Move m)
  {

	Debug.Assert(GlobalMembersBenchmark.is_ok(m));

	Color us = sideToMove;
	Square from = GlobalMembersBenchmark.from_sq(m);

	Debug.Assert(GlobalMembersBenchmark.color_of(moved_piece(m)) == us);
	Debug.Assert(piece_on(square<PieceType.KING>(us)) == GlobalMembersBenchmark.make_piece(us, PieceType.KING));

	// En passant captures are a tricky special case. Because they are rather
	// uncommon, we do it simply by testing whether the king is attacked after
	// the move is made.
	if (GlobalMembersBenchmark.type_of(m) == MoveType.ENPASSANT)
	{
		Square ksq = square<PieceType.KING>(us);
		Square to = GlobalMembersBenchmark.to_sq(m);
		Square capsq = to - GlobalMembersBenchmark.pawn_push(us);
		ulong occupied = (pieces() ^ from ^ capsq) | (int)to;

		Debug.Assert(to == ep_square());
		Debug.Assert(moved_piece(m) == GlobalMembersBenchmark.make_piece(us, PieceType.PAWN));
		Debug.Assert(piece_on(capsq) == GlobalMembersBenchmark.make_piece(~us, PieceType.PAWN));
		Debug.Assert(piece_on(to) == Piece.NO_PIECE);

		return !(attacks_bb< PieceType.ROOK>(ksq, occupied) & pieces(~us, PieceType.QUEEN, PieceType.ROOK)) && !(attacks_bb<PieceType.BISHOP>(ksq, occupied) & pieces(~us, PieceType.QUEEN, PieceType.BISHOP));
	}

	// If the moving piece is a king, check whether the destination
	// square is attacked by the opponent. Castling moves are checked
	// for legality during move generation.
	if (GlobalMembersBenchmark.type_of(piece_on(from)) == PieceType.KING)
	{
		return GlobalMembersBenchmark.type_of(m) == MoveType.CASTLING || !(attackers_to(GlobalMembersBenchmark.to_sq(m)) & pieces(~us));
	}

	// A non-king move is legal if and only if it is not pinned or it
	// is moving along the ray towards or away from the king.
	return !(pinned_pieces(us) & (int)from) || GlobalMembersBenchmark.aligned(from, GlobalMembersBenchmark.to_sq(m), square<PieceType.KING>(us));
  }

  /// Position::pseudo_legal() takes a random move and tests whether the move is
  /// pseudo legal. It is used to validate moves from TT that can be corrupted
  /// due to SMP concurrent access or hash position key aliasing.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool pseudo_legal(const Move m) const
  public bool pseudo_legal(Move m)
  {

	Color us = sideToMove;
	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);
	Piece pc = moved_piece(m);

	// Use a slower but simpler function for uncommon cases
	if (GlobalMembersBenchmark.type_of(m) != MoveType.NORMAL)
	{
		return new MoveList<GenType.LEGAL>(this).contains(m);
	}

	// Is not a promotion, so promotion piece must be empty
	if (GlobalMembersBenchmark.promotion_type(m) - PieceType.KNIGHT != PieceType.NO_PIECE_TYPE)
	{
		return false;
	}

	// If the 'from' square is not occupied by a piece belonging to the side to
	// move, the move is obviously not legal.
	if (pc == Piece.NO_PIECE || GlobalMembersBenchmark.color_of(pc) != us)
	{
		return false;
	}

	// The destination square cannot be occupied by a friendly piece
	if ((pieces(us) & (int)to) != 0)
	{
		return false;
	}

	// Handle the special case of a pawn move
	if (GlobalMembersBenchmark.type_of(pc) == PieceType.PAWN)
	{
		// We have already handled promotion moves, so destination
		// cannot be on the 8th/1st rank.
		if (GlobalMembersBenchmark.rank_of(to) == GlobalMembersBenchmark.relative_rank(us, Rank.RANK_8))
		{
			return false;
		}

		if (!(attacks_from<PieceType.PAWN>(from, us) & pieces(~us) & (int)to) && !((from + GlobalMembersBenchmark.pawn_push(us) == to) && empty(to)) && !((from + 2 * GlobalMembersBenchmark.pawn_push(us) == to) && (GlobalMembersBenchmark.rank_of(from) == GlobalMembersBenchmark.relative_rank(us, Rank.RANK_2)) && empty(to) && empty(to - GlobalMembersBenchmark.pawn_push(us)))) // Not a double push -  Not a single push -  Not a capture
		{
			return false;
		}
	}
	else if (((attacks_from(pc, from) & (int)to) == 0)
	{
		return false;
	}

	// Evasions generator already takes care to avoid some kind of illegal moves
	// and legal() relies on this. We therefore have to take care that the same
	// kind of moves are filtered out here.
	if (checkers() != 0)
	{
		if (GlobalMembersBenchmark.type_of(pc) != PieceType.KING)
		{
			// Double check? In this case a king move is required
			if (GlobalMembersBenchmark.more_than_one(checkers()))
			{
				return false;
			}

			// Our move must be a blocking evasion or a capture of the checking piece
			if ((((GlobalMembersBenchmark.between_bb(GlobalMembersBenchmark.lsb(checkers()), square<PieceType.KING>(us)) | checkers()) & (int)to) == 0)
			{
				return false;
			}
		}
		// In case of king moves under check we have to remove king so as to catch
		// invalid moves like b1a1 when opposite queen is on c1.
		else if ((attackers_to(to, pieces() ^ from) & pieces(~us)) != 0)
		{
			return false;
		}
	}

	return true;
  }
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

  /// Position::gives_check() tests whether a pseudo-legal move gives a check

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool gives_check(Move m) const
  public bool gives_check(Move m)
  {

	Debug.Assert(GlobalMembersBenchmark.is_ok(m));
	Debug.Assert(GlobalMembersBenchmark.color_of(moved_piece(m)) == sideToMove);

	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);

	// Is there a direct check?
	if ((st.checkSquares[(int)GlobalMembersBenchmark.type_of(piece_on(from))] & (int)to) != 0)
	{
		return true;
	}

	// Is there a discovered check?
	if ((discovered_check_candidates() & (int)from) && !GlobalMembersBenchmark.aligned(from, to, square<PieceType.KING>(~sideToMove)))
	{
		return true;
	}

	switch (GlobalMembersBenchmark.type_of(m))
	{
	case MoveType.NORMAL:
		return false;

	case MoveType.PROMOTION:
		return GlobalMembersBenchmark.attacks_bb(Piece(GlobalMembersBenchmark.promotion_type(m)), to, pieces() ^ from) & (int)square<PieceType.KING>(~sideToMove);

	// En passant capture with check? We have already handled the case
	// of direct checks and ordinary discovered check, so the only case we
	// need to handle is the unusual case of a discovered check through
	// the captured pawn.
	case MoveType.ENPASSANT:
	{
		Square capsq = GlobalMembersBenchmark.make_square(GlobalMembersBenchmark.file_of(to), GlobalMembersBenchmark.rank_of(from));
		ulong b = (pieces() ^ from ^ capsq) | (int)to;

		return (attacks_bb< PieceType.ROOK>(square<PieceType.KING>(~sideToMove), b) & pieces(sideToMove, PieceType.QUEEN, PieceType.ROOK)) | (attacks_bb<PieceType.BISHOP>(square<PieceType.KING>(~sideToMove), b) & pieces(sideToMove, PieceType.QUEEN, PieceType.BISHOP));
	}
	case MoveType.CASTLING:
	{
		Square kfrom = from;
		Square rfrom = to; // Castling is encoded as 'King captures the rook'
		Square kto = GlobalMembersBenchmark.relative_square(sideToMove, rfrom > ((int)kfrom) != 0 ? Square.SQ_G1 : Square.SQ_C1);
		Square rto = GlobalMembersBenchmark.relative_square(sideToMove, rfrom > ((int)kfrom) != 0 ? Square.SQ_F1 : Square.SQ_D1);

		return (GlobalMembersBitboard.PseudoAttacks[(int)PieceType.ROOK, (int)rto] & (int)square<PieceType.KING>(~sideToMove)) && (attacks_bb<PieceType.ROOK>(rto, (pieces() ^ kfrom ^ rfrom) | (int)rto | (int)kto) & (int)square<PieceType.KING>(~sideToMove));
	}
	default:
		Debug.Assert(false);
		return false;
	}
  }
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

  /// Position::do_move() makes a move, and saves all information necessary
  /// to a StateInfo object. The move is assumed to be legal. Pseudo-legal
  /// moves should be filtered out before this function is called.

  public void do_move(Move m, StateInfo newSt, bool givesCheck)
  {

	Debug.Assert(GlobalMembersBenchmark.is_ok(m));
	Debug.Assert(newSt != st);

	++nodes;
	ulong k = st.key ^ GlobalMembersPosition.side;

	// Copy some fields of the old state to our new StateInfo object except the
	// ones which are going to be recalculated from scratch anyway and then switch
	// our state pointer to point to the new (ready to be updated) state.
	std.memcpy(newSt, st, offsetof(StateInfo, key));
	newSt.previous = st;
	st = newSt;

	// Increment ply counters. In particular, rule50 will be reset to zero later on
	// in case of a capture or a pawn move.
	++gamePly;
	++st.rule50;
	++st.pliesFromNull;

	Color us = sideToMove;
	Color them = ~us;
	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);
	Piece pc = piece_on(from);
	Piece captured = GlobalMembersBenchmark.type_of(m) == ((int)MoveType.ENPASSANT) != 0 ? GlobalMembersBenchmark.make_piece(them, PieceType.PAWN) : piece_on(to);

	Debug.Assert(GlobalMembersBenchmark.color_of(pc) == us);
	Debug.Assert(captured == Piece.NO_PIECE || GlobalMembersBenchmark.color_of(captured) == (GlobalMembersBenchmark.type_of(m) != ((int)MoveType.CASTLING) != 0 ? them : us));
	Debug.Assert(GlobalMembersBenchmark.type_of(captured) != PieceType.KING);

	if (GlobalMembersBenchmark.type_of(m) == MoveType.CASTLING)
	{
		Debug.Assert(pc == GlobalMembersBenchmark.make_piece(us, PieceType.KING));
		Debug.Assert(captured == GlobalMembersBenchmark.make_piece(us, PieceType.ROOK));

		Square rfrom;
		Square rto;
		do_castling<true>(us, from, to, rfrom, rto);

		st.psq += GlobalMembersPsqt.psq[(int)captured, (int)rto] - GlobalMembersPsqt.psq[(int)captured, (int)rfrom];
		k ^= GlobalMembersPosition.psq[(int)captured, (int)rfrom] ^ GlobalMembersPosition.psq[(int)captured, (int)rto];
		captured = Piece.NO_PIECE;
	}

	if ((int)captured != 0)
	{
		Square capsq = to;

		// If the captured piece is a pawn, update pawn hash key, otherwise
		// update non-pawn material.
		if (GlobalMembersBenchmark.type_of(captured) == PieceType.PAWN)
		{
			if (GlobalMembersBenchmark.type_of(m) == MoveType.ENPASSANT)
			{
				capsq -= GlobalMembersBenchmark.pawn_push(us);

				Debug.Assert(pc == GlobalMembersBenchmark.make_piece(us, PieceType.PAWN));
				Debug.Assert(to == st.epSquare);
				Debug.Assert(GlobalMembersBenchmark.relative_rank(us, to) == Rank.RANK_6);
				Debug.Assert(piece_on(to) == Piece.NO_PIECE);
				Debug.Assert(piece_on(capsq) == GlobalMembersBenchmark.make_piece(them, PieceType.PAWN));

				board[(int)capsq] = Piece.NO_PIECE; // Not done by remove_piece()
			}

			st.pawnKey ^= GlobalMembersPosition.psq[(int)captured, (int)capsq];
		}
		else
		{
			st.nonPawnMaterial[(int)them] -= GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)captured];
		}

		// Update board and piece lists
		remove_piece(captured, capsq);

		// Update material hash key and prefetch access to materialTable
		k ^= GlobalMembersPosition.psq[(int)captured, (int)capsq];
		st.materialKey ^= GlobalMembersPosition.psq[(int)captured, pieceCount[(int)captured]];
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: prefetch(thisThread->materialTable[st->materialKey]);
		GlobalMembersMisc.prefetch(new HashTable(thisThread.materialTable[st.materialKey]));

		// Update incremental scores
		st.psq -= GlobalMembersPsqt.psq[(int)captured, (int)capsq];

		// Reset rule 50 counter
		st.rule50 = 0;
	}

	// Update hash key
	k ^= GlobalMembersPosition.psq[(int)pc, (int)from] ^ GlobalMembersPosition.psq[(int)pc, (int)to];

	// Reset en passant square
	if (st.epSquare != Square.SQ_NONE)
	{
		k ^= GlobalMembersPosition.enpassant[(int)GlobalMembersBenchmark.file_of(st.epSquare)];
		st.epSquare = Square.SQ_NONE;
	}

	// Update castling rights if needed
	if (st.castlingRights != 0 && (castlingRightsMask[(int)from] | castlingRightsMask[(int)to]))
	{
		int cr = castlingRightsMask[(int)from] | castlingRightsMask[(int)to];
		k ^= GlobalMembersPosition.castling[st.castlingRights & cr];
		st.castlingRights &= ~cr;
	}

	// Move the piece. The tricky Chess960 castling is handled earlier
	if (GlobalMembersBenchmark.type_of(m) != MoveType.CASTLING)
	{
		move_piece(pc, from, to);
	}

	// If the moving piece is a pawn do some special extra work
	if (GlobalMembersBenchmark.type_of(pc) == PieceType.PAWN)
	{
		// Set en-passant square if the moved pawn can be captured
		if (((int)to ^ (int)from) == 16 && (attacks_from<PieceType.PAWN>(to - GlobalMembersBenchmark.pawn_push(us), us) & pieces(them, PieceType.PAWN)))
		{
			st.epSquare = (from + to) / 2;
			k ^= GlobalMembersPosition.enpassant[(int)GlobalMembersBenchmark.file_of(st.epSquare)];
		}

		else if (GlobalMembersBenchmark.type_of(m) == MoveType.PROMOTION)
		{
			Piece promotion = GlobalMembersBenchmark.make_piece(us, GlobalMembersBenchmark.promotion_type(m));

			Debug.Assert(GlobalMembersBenchmark.relative_rank(us, to) == Rank.RANK_8);
			Debug.Assert(GlobalMembersBenchmark.type_of(promotion) >= PieceType.KNIGHT && GlobalMembersBenchmark.type_of(promotion) <= PieceType.QUEEN);

			remove_piece(pc, to);
			put_piece(promotion, to);

			// Update hash keys
			k ^= GlobalMembersPosition.psq[(int)pc, (int)to] ^ GlobalMembersPosition.psq[(int)promotion, (int)to];
			st.pawnKey ^= GlobalMembersPosition.psq[(int)pc, (int)to];
			st.materialKey ^= GlobalMembersPosition.psq[(int)promotion, pieceCount[(int)promotion] - 1] ^ GlobalMembersPosition.psq[(int)pc, pieceCount[(int)pc]];

			// Update incremental score
			st.psq += GlobalMembersPsqt.psq[(int)promotion, (int)to] - GlobalMembersPsqt.psq[(int)pc, (int)to];

			// Update material
			st.nonPawnMaterial[(int)us] += GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)promotion];
		}

		// Update pawn hash key and prefetch access to pawnsTable
		st.pawnKey ^= GlobalMembersPosition.psq[(int)pc, (int)from] ^ GlobalMembersPosition.psq[(int)pc, (int)to];
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: prefetch(thisThread->pawnsTable[st->pawnKey]);
		GlobalMembersMisc.prefetch(new HashTable(thisThread.pawnsTable[st.pawnKey]));

		// Reset rule 50 draw counter
		st.rule50 = 0;
	}

	// Update incremental scores
	st.psq += GlobalMembersPsqt.psq[(int)pc, (int)to] - GlobalMembersPsqt.psq[(int)pc, (int)from];

	// Set capture piece
	st.capturedPiece = captured;

	// Update the key with the final value
	st.key = k;

	// Calculate checkers bitboard (if move gives check)
	st.checkersBB = givesCheck ? attackers_to(square<PieceType.KING>(them)) & pieces(us) : 0;

	sideToMove = ~sideToMove;

	// Update king attacks used for fast check detection
	set_check_info(st);

	Debug.Assert(pos_is_ok());
  }

  /// Position::undo_move() unmakes a move. When it returns, the position should
  /// be restored to exactly the same state as before the move was made.

  public void undo_move(Move m)
  {

	Debug.Assert(GlobalMembersBenchmark.is_ok(m));

	sideToMove = ~sideToMove;

	Color us = sideToMove;
	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);
	Piece pc = piece_on(to);

	Debug.Assert(empty(from) || GlobalMembersBenchmark.type_of(m) == MoveType.CASTLING);
	Debug.Assert(GlobalMembersBenchmark.type_of(st.capturedPiece) != PieceType.KING);

	if (GlobalMembersBenchmark.type_of(m) == MoveType.PROMOTION)
	{
		Debug.Assert(GlobalMembersBenchmark.relative_rank(us, to) == Rank.RANK_8);
		Debug.Assert(GlobalMembersBenchmark.type_of(pc) == GlobalMembersBenchmark.promotion_type(m));
		Debug.Assert(GlobalMembersBenchmark.type_of(pc) >= PieceType.KNIGHT && GlobalMembersBenchmark.type_of(pc) <= PieceType.QUEEN);

		remove_piece(pc, to);
		pc = GlobalMembersBenchmark.make_piece(us, PieceType.PAWN);
		put_piece(pc, to);
	}

	if (GlobalMembersBenchmark.type_of(m) == MoveType.CASTLING)
	{
		Square rfrom;
		Square rto;
		do_castling<false>(us, from, to, rfrom, rto);
	}
	else
	{
		move_piece(pc, to, from); // Put the piece back at the source square

		if ((int)st.capturedPiece != 0)
		{
			Square capsq = to;

			if (GlobalMembersBenchmark.type_of(m) == MoveType.ENPASSANT)
			{
				capsq -= GlobalMembersBenchmark.pawn_push(us);

				Debug.Assert(GlobalMembersBenchmark.type_of(pc) == PieceType.PAWN);
				Debug.Assert(to == st.previous.epSquare);
				Debug.Assert(GlobalMembersBenchmark.relative_rank(us, to) == Rank.RANK_6);
				Debug.Assert(piece_on(capsq) == Piece.NO_PIECE);
				Debug.Assert(st.capturedPiece == GlobalMembersBenchmark.make_piece(~us, PieceType.PAWN));
			}

			put_piece(st.capturedPiece, capsq); // Restore the captured piece
		}
	}

	// Finally point our state pointer back to the previous state
	st = st.previous;
	--gamePly;

	Debug.Assert(pos_is_ok());
  }

  /// Position::do(undo)_null_move() is used to do(undo) a "null move": It flips
  /// the side to move without executing any move on the board.

  public void do_null_move(StateInfo newSt)
  {

	Debug.Assert(checkers() == 0);
	Debug.Assert(newSt != st);

	std.memcpy(newSt, st, sizeof(StateInfo));
	newSt.previous = st;
	st = newSt;

	if (st.epSquare != Square.SQ_NONE)
	{
		st.key ^= GlobalMembersPosition.enpassant[(int)GlobalMembersBenchmark.file_of(st.epSquare)];
		st.epSquare = Square.SQ_NONE;
	}

	st.key ^= GlobalMembersPosition.side;
	GlobalMembersMisc.prefetch(GlobalMembersTt.TT.first_entry(st.key));

	++st.rule50;
	st.pliesFromNull = 0;

	sideToMove = ~sideToMove;

	set_check_info(st);

	Debug.Assert(pos_is_ok());
  }
  public void undo_null_move()
  {

	Debug.Assert(checkers() == 0);

	st = st.previous;
	sideToMove = ~sideToMove;
  }

  // Static Exchange Evaluation

  /// Position::see_ge (Static Exchange Evaluation Greater or Equal) tests if the
  /// SEE value of move is greater or equal to the given value. We'll use an
  /// algorithm similar to alpha-beta pruning with a null window.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool see_ge(Move m, Value v) const
  public bool see_ge(Move m, Value v)
  {

	Debug.Assert(GlobalMembersBenchmark.is_ok(m));

	// Castling moves are implemented as king capturing the rook so cannot be
	// handled correctly. Simply assume the SEE value is VALUE_ZERO that is always
	// correct unless in the rare case the rook ends up under attack.
	if (GlobalMembersBenchmark.type_of(m) == MoveType.CASTLING)
	{
		return Value.VALUE_ZERO >= v;
	}

	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);
	PieceType nextVictim = GlobalMembersBenchmark.type_of(piece_on(from));
	Color stm = ~GlobalMembersBenchmark.color_of(piece_on(from)); // First consider opponent's move
	Value balance; // Values of the pieces taken by us minus opponent's ones
	ulong occupied;
	ulong stmAttackers;

	if (GlobalMembersBenchmark.type_of(m) == MoveType.ENPASSANT)
	{
		occupied = GlobalMembersBitboard.SquareBB[(int)to - GlobalMembersBenchmark.pawn_push(~stm)]; // Remove the captured pawn
		balance = GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)PieceType.PAWN];
	}
	else
	{
		balance = GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)piece_on(to)];
		occupied = 0;
	}

	if (balance < v)
	{
		return false;
	}

	if (nextVictim == PieceType.KING)
	{
		return true;
	}

	balance -= GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)nextVictim];

	if (balance >= v)
	{
		return true;
	}

	bool relativeStm = true; // True if the opponent is to move
	occupied ^= pieces() ^ from ^ to;

	// Find all attackers to the destination square, with the moving piece removed,
	// but possibly an X-ray attacker added behind it.
	ulong attackers = attackers_to(to, occupied) & occupied;

	while (true)
	{
		stmAttackers = attackers & pieces(stm);

		// Don't allow pinned pieces to attack pieces except the king as long all
		// pinners are on their original square.
		if (((st.pinnersForKing[(int)stm] & ~occupied) == 0)
		{
			stmAttackers &= ~st.blockersForKing[(int)stm];
		}

		if (stmAttackers == 0)
		{
			return relativeStm;
		}

		// Locate and remove the next least valuable attacker
		nextVictim = min_attacker<PieceType.PAWN>(byTypeBB, to, stmAttackers, occupied, attackers);

		if (nextVictim == PieceType.KING)
		{
			return relativeStm == (bool)(attackers & pieces(~stm));
		}

		balance += relativeStm ? GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)nextVictim] : -GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)nextVictim];

		relativeStm = !relativeStm;

		if (relativeStm == (balance >= v))
		{
			return relativeStm;
		}

		stm = ~stm;
	}
  }

  // Accessing hash keys
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: inline ulong key() const
  public ulong key()
  {
	return st.key;
  }

  /// Position::key_after() computes the new hash key after the given move. Needed
  /// for speculative prefetch. It doesn't recognize special moves like castling,
  /// en-passant and promotions.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: ulong key_after(Move m) const
  public ulong key_after(Move m)
  {

	Square from = GlobalMembersBenchmark.from_sq(m);
	Square to = GlobalMembersBenchmark.to_sq(m);
	Piece pc = piece_on(from);
	Piece captured = piece_on(to);
	ulong k = st.key ^ GlobalMembersPosition.side;

	if ((int)captured != 0)
	{
		k ^= GlobalMembersPosition.psq[(int)captured, (int)to];
	}

	return k ^ GlobalMembersPosition.psq[(int)pc, (int)to] ^ GlobalMembersPosition.psq[(int)pc, (int)from];
  }
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

  /// Position::game_phase() calculates the game phase interpolating total non-pawn
  /// material between endgame and midgame limits.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Phase game_phase() const
  public Phase game_phase()
  {

	Value npm = st.nonPawnMaterial[(int)Color.WHITE] + st.nonPawnMaterial[(int)Color.BLACK];

	npm = Math.Max(Value.EndgameLimit, Math.Min(npm, Value.MidgameLimit));

	return Phase(((npm - Value.EndgameLimit) * Phase.PHASE_MIDGAME) / (Value.MidgameLimit - Value.EndgameLimit));
  }
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

  /// Position::is_draw() tests whether the position is drawn by 50-move rule
  /// or by repetition. It does not detect stalemates.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool is_draw() const
  public bool is_draw()
  {

	if (st.rule50 > 99 && (checkers() == 0 || new MoveList<GenType.LEGAL>(this).size()))
	{
		return true;
	}

	StateInfo stp = st;
	for (int i = 2, e = Math.Min(st.rule50, st.pliesFromNull); i <= e; i += 2)
	{
		stp = stp.previous.previous;

		if (stp.key == st.key)
		{
			return true; // Draw at first repetition
		}
	}

	return false;
  }
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

  /// Position::pos_is_ok() performs some consistency checks for the position object.
  /// This is meant to be helpful when debugging.

  public bool pos_is_ok()
  {
	  return pos_is_ok(null);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool pos_is_ok(int* failedStep = null) const
//C++ TO C# CONVERTER NOTE: Overloaded method(s) are created above to convert the following method having default parameters:
  public bool pos_is_ok(ref int failedStep)
  {

	const bool Fast = true; // Quick (default) or full check?


	for (int step = Default; step <= (Fast ? Default : Castling); step++)
	{
		if (failedStep != 0)
		{
			failedStep = step;
		}

		if (step == Default)
		{
			if ((sideToMove != Color.WHITE && sideToMove != Color.BLACK) || piece_on(square<PieceType.KING>(Color.WHITE)) != Piece.W_KING || piece_on(square<PieceType.KING>(Color.BLACK)) != Piece.B_KING || (ep_square() != Square.SQ_NONE && GlobalMembersBenchmark.relative_rank(sideToMove, ep_square()) != Rank.RANK_6))
			{
				return false;
			}
		}

		if (step == King)
		{
			if (std.count(board, board + Square.SQUARE_NB, Piece.W_KING) != 1 || std.count(board, board + Square.SQUARE_NB, Piece.B_KING) != 1 || attackers_to(square<PieceType.KING>(~sideToMove)) != 0 & pieces(sideToMove))
			{
				return false;
			}
		}

		if (step == Bitboards)
		{
			if ((pieces(Color.WHITE) & pieces(Color.BLACK)) || (pieces(Color.WHITE) | pieces(Color.BLACK)) != pieces())
			{
				return false;
			}

			for (PieceType p1 = PieceType.PAWN; p1 <= PieceType.KING; ++p1)
			{
				for (PieceType p2 = PieceType.PAWN; p2 <= PieceType.KING; ++p2)
				{
					if (p1 != p2 && (pieces(p1) & pieces(p2)))
					{
						return false;
					}
				}
			}
		}

		if (step == State)
		{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: StateInfo si = *st;
			StateInfo si = new StateInfo(st);
			set_state(si);
			if (std.memcmp(si, st, sizeof(StateInfo)))
			{
				return false;
			}
		}

		if (step == Lists)
		{
			foreach (Piece pc in GlobalMembersBenchmark.Pieces)
			{
				if (pieceCount[(int)pc] != GlobalMembersBenchmark.popcount(pieces(GlobalMembersBenchmark.color_of(pc), GlobalMembersBenchmark.type_of(pc))))
				{
					return false;
				}

				for (int i = 0; i < pieceCount[(int)pc]; ++i)
				{
					if (board[(int)pieceList[(int)pc, i]] != pc || index[(int)pieceList[(int)pc, i]] != i)
					{
						return false;
					}
				}
			}
		}

		if (step == Castling)
		{
			for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
			{
				for (CastlingSide s = CastlingSide.KING_SIDE; s <= CastlingSide.QUEEN_SIDE; s = CastlingSide(s + 1))
				{
					if (can_castle((int)c | (int)s) == 0)
						continue;

					if (piece_on(castlingRookSquare[(int)c | (int)s]) != GlobalMembersBenchmark.make_piece(c, PieceType.ROOK) || castlingRightsMask[(int)castlingRookSquare[(int)c | (int)s]] != ((int)c | (int)s) || (castlingRightsMask[(int)square<PieceType.KING>(c)] & ((int)c | (int)s)) != ((int)c | (int)s))
					{
						return false;
					}
				}
			}
		}
	}

	return true;
  }
//C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named AnonymousEnum3:
  public enum AnonymousEnum3
  {
	  Default,
	  King,
	  Bitboards,
	  State,
	  Lists,
	  Castling
  }

  /// Position::flip() flips position with the white and black sides reversed. This
  /// is only useful for debugging e.g. for finding evaluation symmetry bugs.

  public void flip()
  {

	string f;
	string token;
	std.stringstream ss = new std.stringstream(fen());

	for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r) // Piece placement
	{
		getline(ss, token, r > ((int)Rank.RANK_1) != 0 ? '/' : ' ');
		f = f.Insert(0, token + (string.IsNullOrEmpty(f) ? " " : "/"));
	}

	ss >> token; // Active color
	f += (token == "w" ? "B " : "W "); // Will be lowercased later

	ss >> token; // Castling availability
	f += token + " ";

	std.transform(f.GetEnumerator(), f.end(), f.GetEnumerator(), (sbyte c) =>
	{
		return (sbyte)(char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c));
	});

	ss >> token; // En passant square
	f += (token == "-" ? token : token.replace(1, 1, token[1] == '3' ? "6" : "3"));

	getline(ss, token); // Half and full moves
	f += token;

	set(f, is_chess960(), st, this_thread());

	Debug.Assert(pos_is_ok());
  }

  // Initialization helpers (used while setting up a position)

  /// Position::set_castling_right() is a helper function used to set castling
  /// rights given the corresponding color and the rook starting square.

  private void set_castling_right(Color c, Square rfrom)
  {

	Square kfrom = square<PieceType.KING>(c);
	CastlingSide cs = kfrom < ((int)rfrom) != 0 ? CastlingSide.KING_SIDE : CastlingSide.QUEEN_SIDE;
	CastlingRight cr = ((int)c | (int)cs);

	st.castlingRights |= cr;
	castlingRightsMask[(int)kfrom] |= cr;
	castlingRightsMask[(int)rfrom] |= cr;
	castlingRookSquare[(int)cr] = rfrom;

	Square kto = GlobalMembersBenchmark.relative_square(c, cs == ((int)CastlingSide.KING_SIDE) != 0 ? Square.SQ_G1 : Square.SQ_C1);
	Square rto = GlobalMembersBenchmark.relative_square(c, cs == ((int)CastlingSide.KING_SIDE) != 0 ? Square.SQ_F1 : Square.SQ_D1);

	for (Square s = Math.Min(rfrom, rto); s <= Math.Max(rfrom, rto); ++s)
	{
		if (s != kfrom && s != rfrom)
		{
			castlingPath[(int)cr] |= s;
		}
	}

	for (Square s = Math.Min(kfrom, kto); s <= Math.Max(kfrom, kto); ++s)
	{
		if (s != kfrom && s != rfrom)
		{
			castlingPath[(int)cr] |= s;
		}
	}
  }

  /// Position::set_state() computes the hash keys of the position, and other
  /// data that once computed is updated incrementally as moves are made.
  /// The function is only used when a new position is set up, and to verify
  /// the correctness of the StateInfo data when running in debug mode.

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: void set_state(StateInfo* si) const
  private void set_state(StateInfo si)
  {

	si.key = si.pawnKey = si.materialKey = 0;
	si.nonPawnMaterial[(int)Color.WHITE] = si.nonPawnMaterial[(int)Color.BLACK] = Value.VALUE_ZERO;
	si.psq = Score.SCORE_ZERO;
	si.checkersBB = attackers_to(square<PieceType.KING>(sideToMove)) & pieces(~sideToMove);

	set_check_info(si);

	for (ulong b = pieces(); b != 0;)
	{
		Square s = GlobalMembersBenchmark.pop_lsb(ref b);
		Piece pc = piece_on(s);
		si.key ^= GlobalMembersPosition.psq[(int)pc, (int)s];
		si.psq += GlobalMembersPsqt.psq[(int)pc, (int)s];
	}

	if (si.epSquare != Square.SQ_NONE)
	{
		si.key ^= GlobalMembersPosition.enpassant[(int)GlobalMembersBenchmark.file_of(si.epSquare)];
	}

	if (sideToMove == Color.BLACK)
	{
		si.key ^= GlobalMembersPosition.side;
	}

	si.key ^= GlobalMembersPosition.castling[si.castlingRights];

	for (ulong b = pieces(PieceType.PAWN); b != 0;)
	{
		Square s = GlobalMembersBenchmark.pop_lsb(ref b);
		si.pawnKey ^= GlobalMembersPosition.psq[(int)piece_on(s), (int)s];
	}

	foreach (Piece pc in GlobalMembersBenchmark.Pieces)
	{
		if (GlobalMembersBenchmark.type_of(pc) != PieceType.PAWN && GlobalMembersBenchmark.type_of(pc) != PieceType.KING)
		{
			si.nonPawnMaterial[(int)GlobalMembersBenchmark.color_of(pc)] += pieceCount[(int)pc] * GlobalMembersPsqt.PieceValue[(int)Phase.MG, (int)pc];
		}

		for (int cnt = 0; cnt < pieceCount[(int)pc]; ++cnt)
		{
			si.materialKey ^= GlobalMembersPosition.psq[(int)pc, cnt];
		}
	}
  }

  /// Position::set_check_info() sets king attacks to detect if a move gives check

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: void set_check_info(StateInfo* si) const
  private void set_check_info(StateInfo si)
  {

	si.blockersForKing[(int)Color.WHITE] = slider_blockers(pieces(Color.BLACK), square<PieceType.KING>(Color.WHITE), ref si.pinnersForKing[(int)Color.WHITE]);
	si.blockersForKing[(int)Color.BLACK] = slider_blockers(pieces(Color.WHITE), square<PieceType.KING>(Color.BLACK), ref si.pinnersForKing[(int)Color.BLACK]);

	Square ksq = square<PieceType.KING>(~sideToMove);

	si.checkSquares[(int)PieceType.PAWN] = attacks_from<PieceType.PAWN>(ksq, ~sideToMove);
	si.checkSquares[(int)PieceType.KNIGHT] = attacks_from<PieceType.KNIGHT>(ksq);
	si.checkSquares[(int)PieceType.BISHOP] = attacks_from<PieceType.BISHOP>(ksq);
	si.checkSquares[(int)PieceType.ROOK] = attacks_from<PieceType.ROOK>(ksq);
	si.checkSquares[(int)PieceType.QUEEN] = si.checkSquares[(int)PieceType.BISHOP] | si.checkSquares[(int)PieceType.ROOK];
	si.checkSquares[(int)PieceType.KING] = 0;
  }

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

  /// Position::do_castling() is a helper used to do/undo a castling move. This
  /// is a bit tricky in Chess960 where from/to squares can overlap.
  private void do_castling<bool Do>(Color us, Square from, ref Square to, ref Square rfrom, ref Square rto)
  {

	bool kingSide = to > from;
	rfrom = to; // Castling is encoded as "king captures friendly rook"
	rto = GlobalMembersBenchmark.relative_square(us, kingSide ? Square.SQ_F1 : Square.SQ_D1);
	to = GlobalMembersBenchmark.relative_square(us, kingSide ? Square.SQ_G1 : Square.SQ_C1);

	// Remove both pieces first since squares could overlap in Chess960
	remove_piece(GlobalMembersBenchmark.make_piece(us, PieceType.KING), Do ? from : to);
	remove_piece(GlobalMembersBenchmark.make_piece(us, PieceType.ROOK), Do ? rfrom : rto);
	board[Do ? from : to] = board[Do ? rfrom : rto] = Piece.NO_PIECE; // Since remove_piece doesn't do it for us
	put_piece(GlobalMembersBenchmark.make_piece(us, PieceType.KING), Do ? to : from);
	put_piece(GlobalMembersBenchmark.make_piece(us, PieceType.ROOK), Do ? rto : rfrom);
  }

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



/// TTEntry struct is the 10 bytes transposition table entry, defined as below:
///
/// key        16 bit
/// move       16 bit
/// value      16 bit
/// eval value 16 bit
/// generation  6 bit
/// bound type  2 bit
/// depth       8 bit

public class TTEntry
{

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Move move() const
  public Move move()
  {
	  return (Move)move16;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value value() const
  public Value value()
  {
	  return (Value)value16;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Value eval() const
  public Value eval()
  {
	  return (Value)eval16;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Depth depth() const
  public Depth depth()
  {
	  return (Depth)(depth8 * (int)Depth.ONE_PLY);
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Bound bound() const
  public Bound bound()
  {
	  return (Bound)(genBound8 & 0x3);
  }

  public void save(ulong k, Value v, Bound b, Depth d, Move m, Value ev, byte g)
  {

	Debug.Assert(d / Depth.ONE_PLY * Depth.ONE_PLY == d);

	// Preserve any existing move for the same position
	if (((int)m) != 0 || (k >> 48) != key16)
	{
		move16 = (ushort)m;
	}

	// Don't overwrite more valuable entries
	if ((k >> 48) != key16 || d / Depth.ONE_PLY > depth8 - 4 || b == Bound.BOUND_EXACT)
	 /* || g != (genBound8 & 0xFC) // Matching non-zero keys are already refreshed by probe() */
	{
		key16 = (ushort)(k >> 48);
		value16 = (short)v;
		eval16 = (short)ev;
		genBound8 = (byte)(g | (int)b);
		depth8 = (sbyte)(d / Depth.ONE_PLY);
	}
  }

//C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//  friend class TranspositionTable;

  private ushort key16;
  private ushort move16;
  private short value16;
  private short eval16;
  private byte genBound8;
  private sbyte depth8;
}


/// A TranspositionTable consists of a power of 2 number of clusters and each
/// cluster consists of ClusterSize number of TTEntry. Each non-empty entry
/// contains information of exactly one position. The size of a cluster should
/// divide the size of a cache line size, to ensure that clusters never cross
/// cache lines. This ensures best cache performance, as the cacheline is
/// prefetched, as soon as possible.

public class TranspositionTable
{

  private const int CacheLineSize = 64;
  private const int ClusterSize = 3;

  private class Cluster
  {
	public TTEntry[] entry = Arrays.InitializeWithDefaultInstances<TTEntry>(ClusterSize);
	public string padding = new string(new char[2]); // Align to a divisor of the cache line size
  }

//C++ TO C# CONVERTER TODO TASK: There is no equivalent in C# to 'static_assert':
//  static_assert(CacheLineSize % sizeof(Cluster) == 0, "Cluster size incorrect");

 public void Dispose()
 {
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
	 free(mem);
 }
  public void new_search() // Lower 2 bits are used by Bound
  {
	  generation8 += 4;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: byte generation() const
  public byte generation()
  {
	  return generation8;
  }
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: TTEntry* probe(const ulong key, bool& found) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  TTEntry probe(ulong key, ref bool found);
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int hashfull() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  int hashfull();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void resize(uint mbSize);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//  void clear();

  // The lowest order bits of the key are used to get the index of the cluster
//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: TTEntry* first_entry(const ulong key) const
  public TTEntry first_entry(ulong key)
  {
	return table[(uint)key & (clusterCount - 1)].entry[0];
  }

  private uint clusterCount;
  private Cluster table;
  private object mem;
  private byte generation8; // Size must be not bigger than TTEntry::genBound8
}

namespace UCI
{

//C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//class Option;

/// Custom comparator because UCI options should be case insensitive
public class CaseInsensitiveLess
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



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

//C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
const string PieceToChar(" PNBRQK  pnbrqk");

// min_attacker() is a helper function used by see() to locate the least
// valuable attacker for the side to move, remove the attacker we just found
// from the bitboards and scan for new X-ray attacks behind it.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<int Pt>

