using System.Collections.Generic;
using System.Diagnostics;

public static class GlobalMembersBitbase
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

    public static readonly Piece[] Pieces = { Piece.W_PAWN, Piece.W_KNIGHT, Piece.W_BISHOP, Piece.W_ROOK, Piece.W_QUEEN, Piece.W_KING, Piece.B_PAWN, Piece.B_KNIGHT, Piece.B_BISHOP, Piece.B_ROOK, Piece.B_QUEEN, Piece.B_KING };
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
        eg = { (ushort)((uint)(s + 0x8000) >> 16)};
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
        mg = { (ushort)((uint)s)};
        return Value(mg.s);
    }

    //C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
    //ORIGINAL LINE: #define ENABLE_BASE_OPERATORS_ON(T) inline T operator+(T d1, T d2) { return T(int(d1) + int(d2)); } inline T operator-(T d1, T d2) { return T(int(d1) - int(d2)); } inline T operator*(int i, T d) { return T(i * int(d)); } inline T operator*(T d, int i) { return T(int(d) * i); } inline T operator-(T d) { return T(-int(d)); } inline T& operator+=(T& d1, T d2) { return d1 = d1 + d2; } inline T& operator-=(T& d1, T d2) { return d1 = d1 - d2; } inline T& operator*=(T& d, int i) { return d = T(int(d) * i); }
#define ENABLE_BASE_OPERATORS_ON

    //C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
    //ORIGINAL LINE: #define ENABLE_FULL_OPERATORS_ON(T) ENABLE_BASE_OPERATORS_ON(T) inline T& operator++(T& d) { return d = T(int(d) + 1); } inline T& operator--(T& d) { return d = T(int(d) - 1); } inline T operator/(T d, int i) { return T(int(d) / i); } inline int operator/(T d1, T d2) { return int(d1) / int(d2); } inline T& operator/=(T& d, int i) { return d = T(int(d) / i); }
#define ENABLE_FULL_OPERATORS_ON

    public static Value operator +(Value d1, Value d2)
    {
        return Value((int)d1 + (int)d2);
    }
    public static Value operator -(Value d1, Value d2)
    {
        return Value((int)d1 - (int)d2);
    }
    public static Value operator *(int i, Value d)
    {
        return Value(i * (int)d);
    }
    public static Value operator *(Value d, int i)
    {
        return Value((int)d * i);
    }
    public static Value operator -(Value d)
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
    public static Value operator /(Value d, int i)
    {
        return Value((int)d / i);
    }
    public static int operator /(Value d1, Value d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static Value operator /= (Value d, int i)
    {
        return d = Value((int)d / i);
    }
    public static PieceType operator +(PieceType d1, PieceType d2)
    {
        return PieceType((int)d1 + (int)d2);
    }
    public static PieceType operator -(PieceType d1, PieceType d2)
    {
        return PieceType((int)d1 - (int)d2);
    }
    public static PieceType operator *(int i, PieceType d)
    {
        return PieceType(i * (int)d);
    }
    public static PieceType operator *(PieceType d, int i)
    {
        return PieceType((int)d * i);
    }
    public static PieceType operator -(PieceType d)
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
    public static PieceType operator /(PieceType d, int i)
    {
        return PieceType((int)d / i);
    }
    public static int operator /(PieceType d1, PieceType d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static PieceType operator /= (PieceType d, int i)
    {
        return d = PieceType((int)d / i);
    }
    public static Piece operator +(Piece d1, Piece d2)
    {
        return Piece((int)d1 + (int)d2);
    }
    public static Piece operator -(Piece d1, Piece d2)
    {
        return Piece((int)d1 - (int)d2);
    }
    public static Piece operator *(int i, Piece d)
    {
        return Piece(i * (int)d);
    }
    public static Piece operator *(Piece d, int i)
    {
        return Piece((int)d * i);
    }
    public static Piece operator -(Piece d)
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
    public static Piece operator /(Piece d, int i)
    {
        return Piece((int)d / i);
    }
    public static int operator /(Piece d1, Piece d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static Piece operator /= (Piece d, int i)
    {
        return d = Piece((int)d / i);
    }
    public static Color operator +(Color d1, Color d2)
    {
        return Color((int)d1 + (int)d2);
    }
    public static Color operator -(Color d1, Color d2)
    {
        return Color((int)d1 - (int)d2);
    }
    public static Color operator *(int i, Color d)
    {
        return Color(i * (int)d);
    }
    public static Color operator *(Color d, int i)
    {
        return Color((int)d * i);
    }
    public static Color operator -(Color d)
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
    public static Color operator /(Color d, int i)
    {
        return Color((int)d / i);
    }
    public static int operator /(Color d1, Color d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static Color operator /= (Color d, int i)
    {
        return d = Color((int)d / i);
    }
    public static Depth operator +(Depth d1, Depth d2)
    {
        return Depth((int)d1 + (int)d2);
    }
    public static Depth operator -(Depth d1, Depth d2)
    {
        return Depth((int)d1 - (int)d2);
    }
    public static Depth operator *(int i, Depth d)
    {
        return Depth(i * (int)d);
    }
    public static Depth operator *(Depth d, int i)
    {
        return Depth((int)d * i);
    }
    public static Depth operator -(Depth d)
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
    public static Depth operator /(Depth d, int i)
    {
        return Depth((int)d / i);
    }
    public static int operator /(Depth d1, Depth d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static Depth operator /= (Depth d, int i)
    {
        return d = Depth((int)d / i);
    }
    public static Square operator +(Square d1, Square d2)
    {
        return Square((int)d1 + (int)d2);
    }
    public static Square operator -(Square d1, Square d2)
    {
        return Square((int)d1 - (int)d2);
    }
    public static Square operator *(int i, Square d)
    {
        return Square(i * (int)d);
    }
    public static Square operator *(Square d, int i)
    {
        return Square((int)d * i);
    }
    public static Square operator -(Square d)
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
    public static Square operator /(Square d, int i)
    {
        return Square((int)d / i);
    }
    public static int operator /(Square d1, Square d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static Square operator /= (Square d, int i)
    {
        return d = Square((int)d / i);
    }
    public static File operator +(File d1, File d2)
    {
        return File((int)d1 + (int)d2);
    }
    public static File operator -(File d1, File d2)
    {
        return File((int)d1 - (int)d2);
    }
    public static File operator *(int i, File d)
    {
        return File(i * (int)d);
    }
    public static File operator *(File d, int i)
    {
        return File((int)d * i);
    }
    public static File operator -(File d)
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
    public static File operator /(File d, int i)
    {
        return File((int)d / i);
    }
    public static int operator /(File d1, File d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static File operator /= (File d, int i)
    {
        return d = File((int)d / i);
    }
    public static Rank operator +(Rank d1, Rank d2)
    {
        return Rank((int)d1 + (int)d2);
    }
    public static Rank operator -(Rank d1, Rank d2)
    {
        return Rank((int)d1 - (int)d2);
    }
    public static Rank operator *(int i, Rank d)
    {
        return Rank(i * (int)d);
    }
    public static Rank operator *(Rank d, int i)
    {
        return Rank((int)d * i);
    }
    public static Rank operator -(Rank d)
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
    public static Rank operator /(Rank d, int i)
    {
        return Rank((int)d / i);
    }
    public static int operator /(Rank d1, Rank d2)
    {
        return (int)d1 / (int)d2;
    }
    //C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static Rank operator /= (Rank d, int i)
    {
        return d = Rank((int)d / i);
    }

    public static Score operator +(Score d1, Score d2)
    {
        return GlobalMembersSearch.Score((int)d1 + (int)d2);
    }
    public static Score operator -(Score d1, Score d2)
    {
        return GlobalMembersSearch.Score((int)d1 - (int)d2);
    }
    public static Score operator *(int i, Score d)
    {
        return GlobalMembersSearch.Score(i * (int)d);
    }
    public static Score operator *(Score d, int i)
    {
        return GlobalMembersSearch.Score((int)d * i);
    }
    public static Score operator -(Score d)
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
    public static Value operator +(Value v, int i)
    {
        return Value((int)v + i);
    }
    public static Value operator -(Value v, int i)
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
    public static Score operator /(Score s, int i)
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

    public static CastlingRight operator |(Color c, CastlingSide s)
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

    public static void init()
    {

        List<KPKPosition> db = new List<KPKPosition>(MAX_INDEX);
        uint idx;
        uint repeat = 1;

        // Initialize db with known win / draw positions
        for (idx = 0; idx < MAX_INDEX; ++idx)
        {
            db[idx] = new KPKPosition(idx);
        }

        // Iterate through the positions until none of the unknown positions can be
        // changed to either wins or draws (15 cycles needed).
        while (repeat != 0)
        {
            for (repeat = idx = 0; idx < MAX_INDEX; ++idx)
            {
                repeat |= (db[idx] == Result.UNKNOWN && db[idx].classify(db) != Result.UNKNOWN);
            }
        }

        // Map 32 results into one KPKBitbase[] entry
        for (idx = 0; idx < MAX_INDEX; ++idx)
        {
            if (db[idx] == Result.WIN)
            {
                KPKBitbase[idx / 32] |= 1 << (idx & 0x1F);
            }
        }
    }
    public static bool probe(Square wksq, Square wpsq, Square bksq, Color us)
    {

        Debug.Assert(GlobalMembersBenchmark.file_of(wpsq) <= File.FILE_D);

        uint idx = GlobalMembersBitbase.index(us, bksq, wksq, wpsq);
        return KPKBitbase[idx / 32] & (1 << (idx & 0x1F));
    }

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

    public static ulong operator &(ulong b, Square s)
    {
        return b & GlobalMembersBitboard.SquareBB[(int)s];
    }

    public static ulong operator |(ulong b, Square s)
    {
        return b | GlobalMembersBitboard.SquareBB[(int)s];
    }

    public static ulong operator ^(ulong b, Square s)
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
            case PieceType.ROOK:
                return attacks_bb<PieceType.ROOK>(s, occupied);
            case PieceType.QUEEN:
                return attacks_bb<PieceType.BISHOP>(s, occupied) | attacks_bb<PieceType.ROOK>(s, occupied);
            default:
                return GlobalMembersBitboard.StepAttacksBB[(int)pc, (int)s];
        }
    }


    /// popcount() counts the number of non-zero bits in a bitboard

    public static int popcount(ulong b)
    {

#if !USE_POPCNT

        //C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
        //  extern byte PopCnt16[1 << 16];
        //C++ TO C# CONVERTER TODO TASK: Unions within methods are not supported in C#:
        //  union
        //  {
        //	  ulong bb;
        //	  ushort u[4];
        //  }
        v = { b};
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

    // There are 24 possible pawn squares: the first 4 files and ranks from 2 to 7
    public const uint MAX_INDEX = 2 * 24 * 64 * 64; // stm * psq * wksq * bksq = 196608

    // Each uint32_t stores results of 32 positions, one per bit
    public static uint[] KPKBitbase = new uint[MAX_INDEX / 32];

    // A KPK bitbase index is an integer in [0, IndexMax] range
    //
    // Information is mapped in a way that minimizes the number of iterations:
    //
    // bit  0- 5: white king square (from SQ_A1 to SQ_H8)
    // bit  6-11: black king square (from SQ_A1 to SQ_H8)
    // bit    12: side to move (WHITE or BLACK)
    // bit 13-14: white pawn file (from FILE_A to FILE_D)
    // bit 15-17: white pawn RANK_7 - rank (from RANK_7 - RANK_7 to RANK_7 - RANK_2)
    public static uint index(Color us, Square bksq, Square wksq, Square psq)
    {
        return (int)wksq | (bksq << 6) | (us << 12) | (GlobalMembersBenchmark.file_of(psq) << 13) | ((Rank.RANK_7 - GlobalMembersBenchmark.rank_of(psq)) << 15);
    }

    //C++ TO C# CONVERTER TODO TASK: The |= operator cannot be overloaded in C#:
    public static Result operator |= (Result r, Result v)
    {
        return r = Result((int)r | (int)v);
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
public class MakeCastling<Color C, CastlingSide S>
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







//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

public enum Result
{
    INVALID = 0,
    UNKNOWN = 1,
    DRAW = 2,
    WIN = 4
}

public class KPKPosition
{
    //C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
    //	KPKPosition();
    public KPKPosition(uint idx)
    {

        ksq[(int)Color.WHITE] = Square((idx >> 0) & 0x3F);
        ksq[(int)Color.BLACK] = Square((idx >> 6) & 0x3F);
        us = Color((idx >> 12) & 0x01);
        psq = GlobalMembersBenchmark.make_square(File((idx >> 13) & 0x3), Rank.RANK_7 - Rank((idx >> 15) & 0x7));

        // Check if two pieces are on the same square or if a king can be captured
        if (GlobalMembersBenchmark.distance(ksq[(int)Color.WHITE], ksq[(int)Color.BLACK]) <= 1 || ksq[(int)Color.WHITE] == psq || ksq[(int)Color.BLACK] == psq || (us == Color.WHITE && (GlobalMembersBitboard.StepAttacksBB[(int)PieceType.PAWN, (int)psq] & (int)ksq[(int)Color.BLACK])))
        {
            result = Result.INVALID;
        }

        // Immediate win if a pawn can be promoted without getting captured
        else if (us == Color.WHITE && GlobalMembersBenchmark.rank_of(psq) == Rank.RANK_7 && ksq[(int)us] != psq + Square.NORTH && (GlobalMembersBenchmark.distance(ksq[~us], psq + Square.NORTH) > 1 || (GlobalMembersBitboard.StepAttacksBB[(int)PieceType.KING, (int)ksq[(int)us]] & (psq + Square.NORTH))))
        {
            result = Result.WIN;
        }

        // Immediate draw if it is a stalemate or a king captures undefended pawn
        else if (us == Color.BLACK && (!(GlobalMembersBitboard.StepAttacksBB[(int)PieceType.KING, (int)ksq[(int)us]] & ~(GlobalMembersBitboard.StepAttacksBB[(int)PieceType.KING, (int)ksq[~us]] | GlobalMembersBitboard.StepAttacksBB[(int)PieceType.PAWN, (int)psq])) || (GlobalMembersBitboard.StepAttacksBB[(int)PieceType.KING, (int)ksq[(int)us]] & (int)psq & ~GlobalMembersBitboard.StepAttacksBB[(int)PieceType.KING, (int)ksq[~us]])))
        {
            result = Result.DRAW;
        }

        // Position will be classified later
        else
        {
            result = Result.UNKNOWN;
        }
    }
    //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
    //ORIGINAL LINE: operator Result() const
    public static implicit operator Result(KPKPosition ImpliedObject)
    {
        return ImpliedObject.result;
    }
    public Result classify(List<KPKPosition> db)
    {
        return us == ((int)Color.WHITE) != 0 ? classify<Color.WHITE>(db) : classify<Color.BLACK>(db);
    }

    //C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
    //ORIGINAL LINE: template<Color Us>
    public Result classify<Color Us>(List<KPKPosition> db)

    {

        // White to move: If one move leads to a position classified as WIN, the result
        // of the current position is WIN. If all moves lead to positions classified
        // as DRAW, the current position is classified as DRAW, otherwise the current
        // position is classified as UNKNOWN.
        //
        // Black to move: If one move leads to a position classified as DRAW, the result
        // of the current position is DRAW. If all moves lead to positions classified
        // as WIN, the position is classified as WIN, otherwise the current position is
        // classified as UNKNOWN.

        Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
        Result Good = (Us == ((int)Color.WHITE) != 0 ? Result.WIN : Result.DRAW);
        Result Bad = (Us == ((int)Color.WHITE) != 0 ? Result.DRAW : Result.WIN);

        Result r = Result.INVALID;
        ulong b = GlobalMembersBitboard.StepAttacksBB[(int)PieceType.KING, (int)ksq[Us]];

        while (b != 0)
        {
            (int)r |= Us == ((int)Color.WHITE) != 0 ? db[GlobalMembersBitbase.index(Them, ksq[(int)Them], GlobalMembersBenchmark.pop_lsb(ref b), psq)] : db[GlobalMembersBitbase.index(Them, GlobalMembersBenchmark.pop_lsb(ref b), ksq[(int)Them], psq)];
        }

        if (Us == Color.WHITE)
        {
            if (GlobalMembersBenchmark.rank_of(psq) < Rank.RANK_7) // Single push
            {
                (int)r |= db[GlobalMembersBitbase.index(Them, ksq[(int)Them], ksq[Us], psq + Square.NORTH)];
            }

            if (GlobalMembersBenchmark.rank_of(psq) == Rank.RANK_2 && psq + Square.NORTH != ksq[Us] && psq + Square.NORTH != ksq[(int)Them]) // Double push
            {
                (int)r |= db[GlobalMembersBitbase.index(Them, ksq[(int)Them], ksq[Us], psq + Square.NORTH + Square.NORTH)];
            }
        }

        return result = (int)r & (int)((int)Good) != 0 ? Good : (int)r & (int)((int)Result.UNKNOWN) != 0 ? Result.UNKNOWN : Bad;
    }

    public Color us;
    public Square[] ksq = new Square[(int)Color.COLOR_NB];
    public Square psq;
    public Result result;
}



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

