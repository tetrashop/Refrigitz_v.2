#pragma once
#include "stdafx.h"
#include "AllDraw.h"
#include "ThinkingChess.h"
#include <string>
#include <vector>
#include <stdexcept>

//#include "stdafx.h"

//namespace RefrigtzDLL
////{
	
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class DrawElefant
	class DrawElefant

	{


		


	public:
		const DrawElefant& operator[] (const int index) const;

		//void* operator*(std::size_t idx);
		int WinOcuuredatChiled;
		int LoseOcuuredatChiled;
		//private readonly object balance//lock = new object();
		//private readonly object balance//lockS = new object();
		//atic Image E[2];
		//Initiate Global Variables.
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
		static double MaxHuristicxE;
		float Row, Column;
		
		std::vector<ThinkingChess> ElefantThinking;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public int[,] Table = nullptr;
		int **Table;
		int color;
		int Current;
		int Order;
	private:
		int CurrentAStarGredyMax;
		//static void Log(std::exception ex);
	public:
		~DrawElefant();
		bool MaxFound(bool MaxNotFound);
		double ReturnHuristic();

		//Constructor 1.
		DrawElefant(int CurrentAStarGredy, bool MoveentsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);
		//Constructor 2.
		DrawElefant(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur); //,ref AllDraw:: THIS


		void Clone(DrawElefant AA);

		//Clone a Copy.
		//void Clone(DrawElefant *AA); //, ref AllDraw:: THIS
		//Draw an Instatnt Elephant On the Table.
		void DrawElefantOnTable( int CellW, int CellH);

	private:
		void InitializeInstanceFields();
	};
//}
//End of Documentation.
