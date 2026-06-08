#pragma once
#include "stdafx.h"
#include <string>
#include <vector>
#include <stdexcept>
#include "ThinkingChess.h"

namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class DrawCastle
	 class DrawCastle
	{



	public:
		const DrawCastle& operator[] (const int index) const;
		//void* operator*(std::size_t idx);
		int WinOcuuredatChiled;
		int LoseOcuuredatChiled;
		//private readonly object balance//lock = new object();
		//private readonly object balance//lockS = new object();
		//atic Image C[2];
		//Iniatite Global Variable.
	private:
		std::vector<int*> ValuableSelfSupported;

	public:
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
		bool ArrangmentsChanged;
		static double MaxHuristicxC;
		float Row, Column;
		int color;
		std::vector<ThinkingChess> CastleThinking;
		//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
		//ORIGINAL LINE: public int[,] Table = nullptr;
		int **Table;
		int Current;
		int Order;
	private:
		int CurrentAStarGredyMax;

		static void Log(std::exception ex);
	public:
		~DrawCastle();
		bool MaxFound(bool &MaxNotFound);
		double ReturnHuristic();


		//Constructor 1.
		DrawCastle(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);

		//constructor 2.
		DrawCastle(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur); //,  AllDraw:: THIS

		void Clone(DrawCastle AA);

		//Clone a Copy.
		//void Clone(DrawCastle AA); //,  AllDraw:: THIS
		//Draw An Instatnt Brideges Images On the Table Method.
		void DrawCastleOnTable(int CellW, int CellH);

	private:
		void InitializeInstanceFields();
	};
}
//End of Documents.
