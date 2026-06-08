#pragma once

#include "../../Refregitz/QuantumRefrigiz/ChessRules.h"
#include <cmath>

/***************************************************************************************************************************************************
 * Ramin Edjlal 12/12/2018**************************************************************************************************************************
 ***************************************************************************************************************************************************/

namespace QuantumRefrigiz
{
	class RulesQuantum : public ChessRules
	{
	public:
		RulesQuantum(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int Ki, int A[][], int Ord, int i, int j);
		RulesQuantum(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int oRDER);
		RulesQuantum(int CurrentAStarGredy, int oRDER, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged);
		bool Rules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, Color color, int Ki, bool SelfHomeStatCP = true); //Current Kind. - int. - The Destination Click Column - The Destination Click Row - The First Click Column. - The First Click Row

	};
}
