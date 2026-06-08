#pragma once

#include <string>
#include <iostream>
#include <stdexcept>

/**************************************************************************************************************
 * Ramin Edjlal Copyright 1397/04/20 **************************************************************************
 * 1397/04/26:Problem in Seirlization Recurisvely of linked list for refrigitz.********************************
 * ************************************************************************************************************
 */
namespace GalleryStudio
{
	class RefregitzOperator //:RefregizMemmory
	{


	public:
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
		bool ArrangmentsT;
		static std::wstring Root;

	private:
		static const std::wstring SAllDraw;
		//static GalleryStudio.RefregizMemmory Node;
		//RefrigtzDLL.AllDraw Current = null;
		//GalleryStudio.RefregizMemmory Next = null;
		//int Kind = -1;
		static void Log(std::exception &ex);
	public:
		RefregitzOperator(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments); //) : base(MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments


		RefrigtzDLL::AllDraw *GetRefregiz(int No);


	private:
		void InitializeInstanceFields();
	};
}
