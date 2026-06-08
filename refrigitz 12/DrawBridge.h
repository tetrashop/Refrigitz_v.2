#pragma once


#include "ThinkingChess.h"
#include <string>
#include <vector>
#include <stdexcept>

namespace RefrigtzDLL
{
	class DrawBridge
	{
		//Iniatite Global Variable.
	private:
		std::vector<int[]> ValuableSelfSupported;

	public:
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
		bool ArrangmentsChanged;
		static double MaxHuristicxB;
		float Row, Column;
		int color;
		ThinkingChess BridgeThinking[AllDraw::BridgeMovments];
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public int[,] Table = nullptr;
		int **Table;
		int Current;
		int Order;
	private:
		int CurrentAStarGredyMax;

		static void Log(std::exception &ex);
	public:
		bool MaxFound(bool &MaxNotFound);
		double ReturnHuristic();


		//Constructor 1.
		DrawBridge(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);
		//constructor 2.
		DrawBridge(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int Tab[][], int Ord, bool TB, int Cur); //, ref AllDraw. THIS
		//Clone a Copy.
		void Clone(DrawBridge *&AA); //, ref AllDraw. THIS
		//Draw An Instatnt Brideges Images On the Table Method.
		void DrawBridgeOnTable( int CellW, int CellH);
	};
}
//End of Documents.
