
#pragma once
#include "stdafx.h"
#include "AllDraw.h"
#include "ThinkingChess.h"
#include <string>
#include <vector>
#include <stdexcept>
//#include "stdafx.h"


using namespace std;

//namespace RefrigtzDLL
//{
	
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class DrawMinister
	class DrawMinister //:DrawKing
	{





	public:
		const DrawMinister& operator[] (const int index) const;
		
		
		int WinOcuuredatChiled;
		int LoseOcuuredatChiled;
		//private readonly object balance//lock = new object();
		//private readonly object balance//lockS = new object();
		//atic Image M[2];
		//Initiate Global Variable.
	private:
		std::vector<int> ValuableSelfSupported;

	public:
		bool MaxFound(bool MaxNotFound);
		//void* operator*(std::size_t idx);
		static bool KingGrayNotCheckedByQuantumMove;
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;

		bool ArrangmentsChanged;
		static double MaxHuristicxM;
		float Row, Column;
		int color;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public int[,] Table = nullptr;
		int **Table;
		int Current;
		int Order;
		
		std::vector<ThinkingChess> MinisterThinking;
	private:
		int CurrentAStarGredyMax;
		//static void Log(std::exception &ex);
	public:
		~DrawMinister();

		bool MaxFound(bool &MaxNotFound);
		double ReturnHuristic();
		//constructor 1.
		DrawMinister(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);

				//Constructor 2.

		DrawMinister(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur); //, ref AllDraw:: THIS
	

		void Clone(DrawMinister AA);

		//Clone a Copy.
		//void Clone(DrawMinister *&AA); //, ref AllDraw:: THIS
		//Draw an Mnister on the Table.
		void DrawMinisterOnTable( int CellW, int CellH);
		
	private:
		void InitializeInstanceFields();
	};
//}

//End of Documentation.
