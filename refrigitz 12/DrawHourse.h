#pragma once
#include "stdafx.h"
#include "AllDraw.h"
#include "ThinkingChess.h"
#include <string>
#include <vector>
#include <stdexcept>

//#include "stdafx.h"
//namespace RefrigtzDLL
//{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class DrawHourse
	class DrawHourse
	{
		const DrawHourse& operator[] (const int index) const;




	public:
		//void* operator*(std::size_t idx);

		int WinOcuuredatChiled;
		int LoseOcuuredatChiled;
		//private readonly object balance//lock = new object();
		//private readonly object balance//lockS = new object();
		//atic Image H[2];
		//Iniatite Global Variables.
	private:
		std::vector<int> ValuableSelfSupported;

	public:
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
		bool ArrangmentsChanged;
		static double MaxHuristicxH;
		float Row, Column;
		int color;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public int[,] Table = nullptr;
		int **Table;
		
		std::vector<ThinkingChess> HourseThinking;
		int Current;
		int Order;
	private:
		int CurrentAStarGredyMax;

		//static void Log(std::exception ex);
	public:
		~DrawHourse();
		bool MaxFound(bool MaxNotFound);
		double ReturnHuristic();
		//Constructor 1.
		DrawHourse(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);
	    //Constructpor 2.
		DrawHourse(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur); //,ref AllDraw:: THIS

		void Clone(DrawHourse AA);

		//Cloen a Copy.
		//void Clone(DrawHourse *AA); //, ref AllDraw:: THIS
		//Draw a Instatnt Hourse on the Table Method.
		void DrawHourseOnTable( int CellW, int CellH);

	private:
		void InitializeInstanceFields();
	};
//}
//End of Documentation.
