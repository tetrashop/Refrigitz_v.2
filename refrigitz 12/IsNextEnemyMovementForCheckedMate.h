#pragma once

#include "AllDraw.h"
#include <string>
#include <vector>


namespace RefrigtzDLL
{
	class IsNextEnemyMovementForCheckedMate : public AllDraw
	{
	private:
		int TableIsNextEnemyMovementForCheckedMate[8][8];
	public:
		IsNextEnemyMovementForCheckedMate(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int Tab[][]);
		IsNextEnemyMovementForCheckedMate(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, AllDraw *THi, int Tab[][]);
		bool Is();
	};
}
