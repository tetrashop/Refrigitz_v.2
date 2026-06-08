#pragma once
#include "stdafx.h"

//namespace RefrigtzDLL
////{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class ThingsConverter

	class ThingsConverter
	{
		//Initiate Global Variables.
	public:
		static bool LoadConvertTable;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public static int[,] TableConverted = nullptr;
		static int **TableConverted;
	public:
		bool ArrangmentsChanged;
	public:
		static bool ClickOcurred;
		static bool ActOfClickEqualTow;
		bool Convert;
		bool ConvertedToMinister;
		bool ConvertedToCastle;
		bool ConvertedToElefant;
		bool ConvertedToHourse;
		int Max;
		int Row, Column;
	public:
		int color;
		int Order;
		int Current;
		//AllDraw:: THIS;
	public:
		ThingsConverter();
		//Constructor
		ThingsConverter(int Arrangments, int i, int j, int a, int **Tab, int Ord, bool TB, int Cur);
		//Convert Operation of Randomly All State Method.
		bool ConvertOperation(int i, int j, int a, int **Tab, int Ord, bool TB, int Cur);

	public:
		void InitializeInstanceFields();
	};
//}
//End of Documeatation.
