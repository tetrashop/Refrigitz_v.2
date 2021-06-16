#pragma once
#include <string>
#include <vector>
#include <stdexcept>
#include "ThinkingChess.h"
#include "ThingsConverter.h"

namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class DrawSoldier : ThingsConverter
	 class DrawSoldier : public ThingsConverter
	{




	public:
		const DrawSoldier& operator[] (const int index) const;


		int WinOcuuredatChiled;
		int LoseOcuuredatChiled;
		//Iniatate Global Variables.
		//private readonly object balance//lock = new object();
		//private readonly object balance//lockS = new object();
	private:
		std::vector<int*> ValuableSelfSupported;

	public:
		//atic Image S[2];
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
		bool ArrangmentsChanged;
		static double MaxHuristicxS;
		float RowS, ColumnS;
		int color;

		std::vector<ThinkingChess> SoldierThinking;//= std::vector<ThinkingChess>();
		//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
		//ORIGINAL LINE: public int[,] Table = nullptr;
		int **Table;
		int Order;
		int Current;
	private:
		int CurrentAStarGredyMax;
		//static void Log(std::exception &ex);

	public:
		~DrawSoldier();
		bool MaxFound(bool & MaxNotFound);
			double ReturnHuristic();

		////void* operator*(std::size_t idx);
		static bool KingGrayNotCheckedByQuantumMove;

		//Constructor 1.
		DrawSoldier(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);

		//Constructor 2.		
		DrawSoldier(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int ** Tab, int Ord, bool TB, int Cur);
		void Clone(DrawSoldier AA);
		void DrawSoldierOnTable(int CellW, int CellH);
		// :ThingsConverter(Arrangments, i, j, a, Tab, Ord, TB, Cur);

		//Clone a Copy Method.
		//void Clone(DrawSoldier AA); //,  AllDraw:: THIS
		//Drawing Soldiers On the Table Method..
		//void DrawSoldierOnTable( int CellW, int CellH);

	private:
		void DrawSoldierOnTable(float CellW, float CellH);
		//void DrawSoldierOnTable(T CellW, T CellH);
		void InitializeInstanceFields();
	};
}
//End of Documentation.
