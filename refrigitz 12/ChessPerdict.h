#pragma once

#include "AllDraw.h"
#include "DrawSoldire.h"
#include "DrawElefant.h"
#include "DrawHourse.h"
#include "DrawCastle.h"
#include "DrawMinister.h"
#include "DrawKing.h"
#include <string>
#include <vector>
#include <cmath>
#include <float.h>
#include <stdexcept>
#include <functional>

/*********************************************************************************************
 * tring to predictative orderly movments.****************************************************
 * Ramin Edjlal*******************************************************************************
 * This Class should Predict the Validity Movements Of Current Order an Enemy of Current Order*(_)
 * Predict Not Working************************************************************************(+)
 * Chess Predict Taking A Lot Of Time********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Chess Prediction Caused to Initial AllDraw Method in ObjectDanger state not Working.************RS*****0.12**4**Managements and Cuation Programing**(+)
 * 'Check' ObjectDanger Attacker by Gray Minister to Brown 'King' Not Removed by Brown Soldier******RS*****0.12**4**Managements and Cuation Programing**(+)
 * The State of Soldier Supporter By Soldier Brown Doesn’t Detected.*************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Chess Predict Doesn’t Act The Supporter of Soldier****************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Chess Predict Supporter Successful For Checking 'Alice' by Person**************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Chess 'Alice' By 'Bob' Supporter Misleading***********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Chess Predict at Tow Level Taking a lot of time.******************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Chess Predict Not Working*****************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * **********************************************************************************************************************************************(+:Sum(10)) (_:Sum(1))*/
namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class ChessPerdict
	class ChessPerdict
	{
		//Initiate Global Variables. 
	public:
		double MaxHuristicxT;
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;

	private:
		bool ArrangmentsChanged;
		/*public int SodierMidle = 8;
		public int SodierHigh = 16;
		public int ElefantMidle = 2;
		public int ElefantHigh = 4;
		public int HourseMidle = 2;
		public int HourseHight = 4;
		public int CastleMidle = 2;
		public int CastleHigh = 4;
		public int MinisterMidle = 1;
		public int MinisterHigh = 2;
		public int KingMidle = 1;
		public int KingHigh = 2;
		*/
	public:
		int SodierMidle;
		int SodierHigh;
		int ElefantMidle;
		int ElefantHigh;
		int HourseMidle;
		int HourseHight;
		int CastleMidle;
		int CastleHigh;
		int MinisterMidle;
		int MinisterHigh;
		int KingMidle;
		int KingHigh;

	private:
		ChessPerdict *APredict;
		int OrderDummy;
	public:
		static int SodierValue;
		static int ElefantValue;
		static int HourseValue;
		static int CastleValue;
		static int MinisterValue;
		static int KingValue;
	private:
		int RW;
		int CL;
		int Ki;
	public:
		static int LoopHuristicIndex;
	private:
		static std::vector<int> RWList;
		static std::vector<int> ClList;
		static std::vector<int> KiList;
	public:
		static std::vector<int[][]> TableListAction;
		int Move;
		static int MouseClick;
	private:
		int AStarGreedyIndex[20];
	public:
		std::vector<AllDraw*> A;
		std::vector<int[][]> TableList;
		int AStarGreedyGreedy;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public DrawSoldier[] SolderesOnTable = nullptr;
		DrawSoldier *SolderesOnTable;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public DrawElefant[] ElephantOnTable = nullptr;
		DrawElefant *ElephantOnTable;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public DrawHourse[] HoursesOnTable = nullptr;
		DrawHourse *HoursesOnTable;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public DrawCastle[] CastlesOnTable = nullptr;
		DrawCastle *CastlesOnTable;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public DrawMinister[] MinisterOnTable = nullptr;
		DrawMinister *MinisterOnTable;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public DrawKing[] KingOnTable = nullptr;
		DrawKing *KingOnTable;
	private:
		int CurrentAStarGredyMax;

		//AllDraw. THIS;
		static void Log(std::exception &ex);
	public:
		void SetObjectNumbers(int TabS[8][8]);
	private:
		float *FoundLocationOfObject(int Tabl[8][8], int Kind, bool IsGray);
		//Constructor.
	public:
		ChessPerdict(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments); //, ref AllDraw. Th
		//Determination of Current Thinking Operations Task Finished His Worke.
		bool AllCurrentAStarGreedyThinkingFinished(AllDraw *Dum, int i, int j, int Kind);
		//Wait Method For Thinking Operation.
	private:
		void Wait(AllDraw *Dum, int i, int j, int Kind);
		//Initiate For Every Initiation Objects.
	public:
		void InitiateForEveryKindThingHome(AllDraw *DummyHA, int ii, int jj, int a, int Table[8][8], int Order, bool TB, int IN);

		//Rearrange AllDraw ObjectContent.
		void SetRowColumn(int index);

		//Huristic of Check Method.    
		int **HuristicCheck(std::vector<AllDraw*> &A, int a, int ij, double &Less, int Order);

	   //Iniatite Prediction Method.
		int **InitiatePerdictCheck(int ii, int jj, int a, int Table[8][8], int Order, bool TB);

		//Enemy Non Used Check Predict Found.
		bool InitiatePerdictCheckEnemy(int ii, int jj, int a, int Table[8][8], int Order, bool TB);

	};
}

//End of Documentation.




