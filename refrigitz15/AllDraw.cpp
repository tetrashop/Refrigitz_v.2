#pragma once
class DrawSoldier;
class DrawElefant;
class DrawHourse;
class DrawCastle;
class DrawMinister;
class DrawKing;
//class ThinkingChess;
//class AllDraw;
#include "AllDraw.h"
#include "ChessRules.h"
#include "ThinkingChess.h"
#include "ThingsConverter.h"
using namespace std;
namespace RefrigtzDLL
{/*
	inline bool operator==(const AllDraw& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const AllDraw& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const DrawSoldier& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const DrawSoldier& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const DrawCastle& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const DrawCastle& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const DrawElefant& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const DrawElefant& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const DrawHourse& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const DrawHourse& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const DrawMinister& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const DrawMinister& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const DrawKing& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const DrawKing& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }
	inline bool operator==(const ThinkingChess& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const ThinkingChess& lhs, const std::nullptr_t rhs) { return !(lhs == rhs); }

	
	inline bool operator==(const AllDraw lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const AllDraw lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const DrawSoldier lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const DrawSoldier lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const DrawCastle lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const DrawCastle lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const DrawElefant lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const DrawElefant lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const DrawHourse lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const DrawHourse lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const DrawMinister lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const DrawMinister lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const DrawKing lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const DrawKing lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const ThinkingChess lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const ThinkingChess lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }

	
	inline bool operator==(const std::vector<AllDraw> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<AllDraw> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<DrawSoldier> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<DrawSoldier> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<DrawCastle> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<DrawCastle> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<DrawElefant> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<DrawElefant> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<DrawHourse> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<DrawHourse> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<DrawMinister> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<DrawMinister> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<DrawKing> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<DrawKing> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline bool operator==(const std::vector<ThinkingChess> lhs, const std::nullptr_t rhs) { return ((&lhs) == rhs); }
	inline bool operator!=(const std::vector<ThinkingChess> lhs, const std::nullptr_t rhs) { return !((&lhs) == rhs); }
	inline std::wstring operator+=(const std::wstring &out, const std::wstring &course)
	{
		std::wstring& lef = std::wstring();
		lef = out + course; // for example
		return lef;

	}
	*/
int AllDraw::DepthIterative = 0;
std::wstring AllDraw::OutPut = L"";
std::wstring AllDraw::ActionString = L"";
bool AllDraw::ActionStringReady = false;
bool AllDraw::RegardOccurred = false;
int AllDraw::SuppportCountStaticGray = 0;
int AllDraw::SuppportCountStaticBrown = 0;
int AllDraw::TaskBegin = 0;
int AllDraw::TaskEnd = 0;
//std::wstring AllDraw::Root = System::IO::Path::GetDirectoryName(Environment::GetCommandLineArgs()[0]);
int AllDraw::OrderPlate = 1;
bool AllDraw::Blitz = false;
int AllDraw::ConvertedKind = -2;
bool AllDraw::ConvertWait = true;
bool AllDraw::Stockfish = false;
bool AllDraw::Person = true;
bool AllDraw::THISSecradioButtonGrayOrderChecked = false;
bool AllDraw::THISSecradioButtonBrownOrderChecked = false;
std::wstring AllDraw::THIScomboBoxMaxLevelText = L"";
//AllDraw *AllDraw::THISDummy = nullptr;
bool AllDraw::StateCP = false;
int AllDraw::LastRow = -1;
int AllDraw::LastColumn = -1;
int AllDraw::NextRow = -1;
int AllDraw::NextColumn = -1;
int AllDraw::MovmentsNumber = 0;
int AllDraw::MaxAStarGreedyHuristicProgress = 0;
bool AllDraw::EndOfGame = false;
int AllDraw::MaxDuringLevelThinkingCreation = 0;
double AllDraw::AStarGreedytMaxCount = 0;
bool AllDraw::FoundATable = false;
double AllDraw::Less = -DBL_MAX;
int AllDraw::increasedProgress = 0;
double AllDraw::CurrentHuristic = -DBL_MAX;
double AllDraw::SignAttack = 1;
double AllDraw::SignObjectDangour = 1;
double AllDraw::SignReducedAttacked = -1;
double AllDraw::SignSupport = 1;
double AllDraw::SignKiller = 1;
double AllDraw::SignMovments = 1;
double AllDraw::SignDistance = -1;
double AllDraw::SignKingSafe = -1;
double AllDraw::SignKingDangour = -1;
bool AllDraw::DrawTable = true;
int AllDraw::MaxAStarGreedy = 1;
std::vector<int**> AllDraw::TableCurrent = std::vector<int**>();
bool AllDraw::NoTableFound = false;
bool AllDraw::DynamicAStarGreedytPrograming = false;
std::vector<AllDraw> AllDraw::StoreADraw = std::vector<AllDraw>();
std::vector<int> AllDraw::StoreADrawAStarGreedy = std::vector<int>();
bool AllDraw::UseDoubleTime = false;
int AllDraw::AStarGreedyiLevelMax = 0;
bool AllDraw::AStarGreadyFirstSearch = true;
std::wstring AllDraw::ImageRoot = AllDraw::Root + std::wstring(L"\\Images");
std::wstring AllDraw::ImagesSubRoot = AllDraw::ImageRoot + std::wstring(L"\\Fit\\Small\\");
bool AllDraw::RedrawTable = true;
std::wstring AllDraw::SyntaxToWrite = L"";
bool AllDraw::SodierConversionOcuured = false;
int AllDraw::SodierMovments = 1;
int AllDraw::ElefantMovments = 1;
int AllDraw::HourseMovments = 1;
int AllDraw::CastleMovments = 1;
int AllDraw::MinisterMovments = 1;
int AllDraw::KingMovments = 1;
int AllDraw::LoopHuristicIndex = 0;
std::vector<int> AllDraw::RWList = std::vector<int>();
std::vector<int> AllDraw::ClList = std::vector<int>();
std::vector<int> AllDraw::KiList = std::vector<int>();
std::vector<int**> AllDraw::TableListAction = std::vector<int**>();
int AllDraw::MouseClick = 0;

	

bool AllDraw::IsAQuantumeMoveOccured(bool IsQuantumMove)
{
	bool Is = false;
	if (!IsQuantumMove)
	{
		int IsInt = (rand() % 33);
		Is = static_cast<bool>(IsInt % 2);
	}
	return Is;
}

	

	void AllDraw::SetObjectNumbers(int **TabS)
	{
		////auto a = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a)
		{

			SodierMidle = 0;
			SodierHigh = 0;
			ElefantMidle = 0;
			ElefantHigh = 0;
			HourseMidle = 0;
			HourseHight = 0;
			CastleMidle = 0;
			CastleHigh = 0;
			MinisterMidle = 0;
			MinisterHigh = 0;
			KingMidle = 0;
			KingHigh = 0;
			for (int h = 0; h < 8; h++)
			{
				for (int s = 0; s < 8; s++)
				{
					if (TabS[h][s] == 1)
					{
						SodierMidle++;
						SodierHigh++;
					}
					else if (TabS[h][s] == 2)
					{
						ElefantMidle++;
						ElefantHigh++;
					}
					else if (TabS[h][s] == 3)
					{
						HourseMidle++;
						HourseHight++;
					}
					else if (TabS[h][s] == 4)
					{
						CastleMidle++;
						CastleHigh++;
					}
					else if (TabS[h][s] == 5)
					{
						MinisterMidle++;
						MinisterHigh++;
					}
					else if (TabS[h][s] == 6)
					{
						KingMidle++;
						KingHigh++;
					}
					else
					{
						if (TabS[h][s] == -1)
						{
						SodierHigh++;
						}
					else if (TabS[h][s] == -2)
					{
						ElefantHigh++;
					}
					else if (TabS[h][s] == -3)
					{
						HourseHight++;
					}
					else if (TabS[h][s] == -4)
					{
						CastleHigh++;
					}
					else if (TabS[h][s] == -5)
					{

						MinisterHigh++;
					}
					else if (TabS[h][s] == -6)
					{
						KingHigh++;
					}
					}
				}
			}
		}
	}

	float *AllDraw::FoundLocationOfObject(int **Tabl, int Kind, bool IsGray)
	{
		////auto a = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a)
		{
			float Location[2] = {-1, -1};
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (IsGray)
					{
						if (Tabl[i][j] == Kind)
						{
							Location[0] = i;
							Location[1] = j;
							Tabl[i][j] = 0;

						}
					}
					else
					{
						if (Tabl[i][j] * -1 == Kind)
						{
							Location[0] = i;
							Location[1] = j;
							Tabl[i][j] = 0;

						}
					}

				}
			}
			return Location;

		}
	}



	AllDraw::AllDraw(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int** Tab, int Ord, bool TB, int Cur)
	{
		InitializeInstanceFields();

		OrderP = Ord;
		MaxHuristicxT = -DBL_MAX;
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		if (!Arrangments)
		{
			ArrangmentsChanged = Arrangments;
		}
		else
		{
			ArrangmentsChanged = Arrangments;
		}
		AStarGreedytMaxCount = 0;
		FoundATable = false;

		CastlesKing = false;
		increasedProgress = 0;
		CurrentHuristic = -DBL_MAX;

		DrawTable = false;

		//TableVeryfy = new int**;

		//TableVeryfy = new int**;

		TableCurrent.clear();

		NoTableFound = false;

		DynamicAStarGreedytPrograming = false;
		UseDoubleTime = false;
		AStarGreadyFirstSearch = true;
		//ImageRoot = AllDraw::Root + std::wstring(L"\\Images");
		//ImagesSubRoot = AllDraw::ImageRoot + std::wstring(L"\\Fit\\Small\\");
		RedrawTable = true;
		SodierConversionOcuured = false;
		SodierMovments = 1;
		ElefantMovments = 1;
		HourseMovments = 1;
		CastleMovments = 1;
		MinisterMovments = 1;
		KingMovments = 1;
		SodierMidle = 8;
		SodierHigh = 16;
		ElefantMidle = 2;
		ElefantHigh = 4;
		HourseMidle = 2;
		HourseHight = 4;
		CastleMidle = 2;
		CastleHigh = 4;
		MinisterMidle = 1;
		MinisterHigh = 2;
		KingMidle = 1;
		KingHigh = 2;

		//APredict = null;
		RW = 0;
		CL = 0;
		Ki = 0;
		RW1 = 0;
		CL1 = 0;
		Ki1 = 0;
		MaxLess1 = 0;
		RW2 = 0;
		CL2 = 0;
		Ki2 = 0;
		MaxLess2 = 0;
		RW3 = 0;
		CL3 = 0;
		Ki3 = 0;
		MaxLess3 = 0;
		RW4 = 0;
		CL4 = 0;
		Ki4 = 0;
		MaxLess4 = 0;
		RW5 = 0;
		CL5 = 0;
		Ki5 = 0;
		MaxLess5 = 0;
		RW6 = 0;
		CL6 = 0;
		Ki6 = 0;
		MaxLess6 = 0;
		LoopHuristicIndex = 0;
		Move = 0;
		MouseClick = 0;
		//AStarGreedyIndex = new int[20];
		AStarGreedyInt = 0;
		MaxDuringLevelThinkingCreation = StringConverterHelper::fromString<int>(AllDraw::THIScomboBoxMaxLevelText);
		/*SolderesOnTable = new DrawSoldier[SodierHigh];
		ElephantOnTable = new DrawElefant[ElefantHigh];
		HoursesOnTable = new DrawHourse[HourseHight];
		CastlesOnTable = new DrawCastle[CastleHigh];
		MinisterOnTable = new DrawMinister[MinisterHigh];
		KingOnTable = new DrawKing[KingHigh];*/

		/*SolderesOnTable = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		SolderesOnTable= new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		HoursesOnTable= new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		CastlesOnTable= new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		MinisterOnTable= new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		KingOnTable = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		*/

		for (int i = 0; i < SodierHigh; i++)
			SolderesOnTable.push_back(DrawSoldier(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, i, j, a, Tab, Ord, TB, Cur));
		for (int i = 0; i < ElefantHigh; i++)
			ElephantOnTable.push_back(DrawElefant(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, i, j, a, Tab, Ord, TB, Cur));
		for (int i = 0; i < HourseHight; i++)
			HoursesOnTable.push_back(DrawHourse(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, i, j, a, Tab, Ord, TB, Cur));
		for (int i = 0; i < CastleMidle; i++)
			CastlesOnTable.push_back(DrawCastle(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, i, j, a, Tab, Ord, TB, Cur));
		for (int i = 0; i <MinisterHigh; i++)
			MinisterOnTable.push_back(DrawMinister(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, i, j, a, Tab, Ord, TB, Cur));
		for (int i = 0; i < KingHigh; i++)
			KingOnTable.push_back(DrawKing(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, i, j, a, Tab, Ord, TB, Cur));

	}
	AllDraw::AllDraw(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		InitializeInstanceFields();

		//OrderP = Ord;
		MaxHuristicxT = -DBL_MAX;
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		if (!Arrangments)
		{
			ArrangmentsChanged = Arrangments;
		}
		else
		{
			ArrangmentsChanged = Arrangments;
		}
		AStarGreedytMaxCount = 0;
		FoundATable = false;

		CastlesKing = false;
		increasedProgress = 0;
		CurrentHuristic = -DBL_MAX;

		DrawTable = false;

		//TableVeryfy = new int**;

		//TableVeryfy = new int**;

		TableCurrent.clear();

		NoTableFound = false;

		DynamicAStarGreedytPrograming = false;
		UseDoubleTime = false;
		AStarGreadyFirstSearch = true;
		//ImageRoot = AllDraw::Root + std::wstring(L"\\Images");
		//ImagesSubRoot = AllDraw::ImageRoot + std::wstring(L"\\Fit\\Small\\");
		RedrawTable = true;
		SodierConversionOcuured = false;
		SodierMovments = 1;
		ElefantMovments = 1;
		HourseMovments = 1;
		CastleMovments = 1;
		MinisterMovments = 1;
		KingMovments = 1;
		SodierMidle = 8;
		SodierHigh = 16;
		ElefantMidle = 2;
		ElefantHigh = 4;
		HourseMidle = 2;
		HourseHight = 4;
		CastleMidle = 2;
		CastleHigh = 4;
		MinisterMidle = 1;
		MinisterHigh = 2;
		KingMidle = 1;
		KingHigh = 2;

		//APredict = null;
		RW = 0;
		CL = 0;
		Ki = 0;
		RW1 = 0;
		CL1 = 0;
		Ki1 = 0;
		MaxLess1 = 0;
		RW2 = 0;
		CL2 = 0;
		Ki2 = 0;
		MaxLess2 = 0;
		RW3 = 0;
		CL3 = 0;
		Ki3 = 0;
		MaxLess3 = 0;
		RW4 = 0;
		CL4 = 0;
		Ki4 = 0;
		MaxLess4 = 0;
		RW5 = 0;
		CL5 = 0;
		Ki5 = 0;
		MaxLess5 = 0;
		RW6 = 0;
		CL6 = 0;
		Ki6 = 0;
		MaxLess6 = 0;
		LoopHuristicIndex = 0;
		Move = 0;
		MouseClick = 0;
		//AStarGreedyIndex = new int[20];
		AStarGreedyInt = 0;
		MaxDuringLevelThinkingCreation = StringConverterHelper::fromString<int>(AllDraw::THIScomboBoxMaxLevelText);
		/*SolderesOnTable = new DrawSoldier[SodierHigh];
		ElephantOnTable = new DrawElefant[ElefantHigh];
		HoursesOnTable = new DrawHourse[HourseHight];
		CastlesOnTable = new DrawCastle[CastleHigh];
		MinisterOnTable = new DrawMinister[MinisterHigh];
		KingOnTable = new DrawKing[KingHigh];
		*/
		/*SolderesOnTable = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		SolderesOnTable= new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		HoursesOnTable= new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		CastlesOnTable= new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		MinisterOnTable= new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		KingOnTable = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		*/


		for (int i = 0; i < SodierHigh; i++)
			SolderesOnTable.push_back(DrawSoldier(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments));
		for (int i = 0; i < ElefantHigh; i++)
			ElephantOnTable.push_back(DrawElefant(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments));
		for (int i = 0; i < HourseHight; i++)
			HoursesOnTable.push_back(DrawHourse(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments));
		for (int i = 0; i < CastleMidle; i++)
			CastlesOnTable.push_back(DrawCastle(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments));
		for (int i = 0; i <MinisterHigh; i++)
			MinisterOnTable.push_back(DrawMinister(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments));
		for (int i = 0; i < KingHigh; i++)
			KingOnTable.push_back(DrawKing(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments));

	}

	/*
	void AllDraw::Clone(AllDraw AA)
	{




		if ((&AA) == nullptr)
		{
			int color = 1;
			if (OrderP == -1)
				color = -1;
			AA = AllDraw(OrderP, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, RowS, ColumS, color, TableList[0], OrderP, false, CurS);

			AA.TableList.push_back(TableList[0]);
		}
		//AA.Tabl = new int**;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				AA.Tabl[i] = Tabl[i];
			}
		}
		AA.OrderP = OrderP;

		AA.PerceptionCount = PerceptionCount;
		AA.OutPutAction = OutPutAction;
		//static variable to be Initiate
		AA.ValuableSelfSupported = std::vector<int*>();
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				AA.ValuableSelfSupported.push_back(ValuableSelfSupported[i]);
			}
		}
		AA.CurrentAStarGredyMax = CurrentAStarGredyMax;
		for (int i = 0; i < 6; i++)
		{
			AA.Index[i] = Index[i];
		}
		for (int i = 0; i < 6; i++)
		{
			AA.jindex[i] = jindex[i];
		}
		for (int i = 0; i < 6; i++)
		{
			AA.Kind[i] = Kind[i];
		}
		if ((&AStarGreedyString) != nullptr)
		{
			AStarGreedyString->Clone(*(AA.AStarGreedyString));
		}
		if (TableList.size() == 1)
		{
			SetObjectNumbers(TableList[0]);
		}
		MaxHuristicxT = -DBL_MAX;
		AA.MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicFoundT;
		AA.IgnoreSelfObjectsT = IgnoreSelfObjectsT;
		AA.UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisamT;
		AA.BestMovmentsT = BestMovmentsT;
		AA.PredictHuristicT = PredictHuristicT;
		AA.OnlySelfT = OnlySelfT;
		AA.AStarGreedyHuristicT = AStarGreedyHuristicT;
		AA.ArrangmentsChanged = ArrangmentsChanged;
		AA.CastlesKing = CastlesKing;


		AA.SodierMidle = SodierMidle;
		AA.SodierHigh = SodierHigh;
		AA.ElefantMidle = ElefantMidle;
		AA.ElefantHigh = ElefantHigh;
		AA.HourseMidle = HourseMidle;
		AA.HourseHight = HourseHight;
		AA.CastleMidle = CastleMidle;
		AA.CastleHigh = CastleHigh;
		AA.MinisterMidle = MinisterMidle;
		AA.MinisterHigh = MinisterHigh;
		AA.KingMidle = KingMidle;
		AA.KingHigh = KingHigh;
		//Initiate a new class object and clone a copy.

		//AA.SolderesOnTable = DrawSoldier[SodierHigh];
		AA.ArrangmentsChanged = ArrangmentsChanged;
		for (int i = 0; i < SodierHigh; i++)
		{
			//try
			{
				SolderesOnTable[i].Clone(AA.SolderesOnTable[i]);
			}
			//catch(std::exception &t)
			{

			}
		}
		//AA.SolderesOnTable = new  DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < ElefantHigh; i++)
		{
			//try
			{
				SolderesOnTable[i].Clone((AA.SolderesOnTable[i]));

			}
			//catch(std::exception &t)
			{

			}
		}
		//AA.HoursesOnTable = new  DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < HourseHight; i++)
		{
			//try
			{
				HoursesOnTable[i].Clone((AA.HoursesOnTable[i]));

			}
			//catch(std::exception &t)
			{

			}
		}
		//AA.CastlesOnTable = new  DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < CastleHigh; i++)
		{
			//try
			{
				CastlesOnTable[i].Clone((AA.CastlesOnTable[i]));

			}
			//catch(std::exception &t)
			{

			}
		}
		//AA.MinisterOnTable = new  DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < MinisterHigh; i++)
		{
			//try
			{
				MinisterOnTable[i].Clone((AA.MinisterOnTable[i]));

			}
			//catch(std::exception &t)
			{

			}
		}
		//AA.KingOnTable = new  DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < KingHigh; i++)
		{
			//try
			{
				KingOnTable[i].Clone((AA.KingOnTable[i]));

			}
			//catch(std::exception &t)
			{

			}
		}
		//AA.AStarGreedy = AStarGreedy;

		if (AA.TableList.size() > 0)
		{
			AA.TableList.clear();
		}
		for (int i = 0; i < TableList.size(); i++)
		{
			AA.TableList.push_back(TableList[i]);
		}
		if (AA.TableList.size() > 0)
		{
			AA.SetObjectNumbers(AA.TableList[0]);
		}
		//AA.AStarGreedy = AStarGreedy;

	}

	*/
	void AllDraw::SetRowColumn(int index)
	{


		SetObjectNumbers(TableList[0]);

		int So1 = 0;
		int So2 = SodierMidle;
		int El1 = 0;
		int El2 = ElefantMidle;
		int Ho1 = 0;
		int Ho2 = HourseMidle;
		int Br1 = 0;
		int Br2 = CastleMidle;
		int Mi1 = 0;
		int Mi2 = MinisterMidle;
		int Ki1 = 0;
		int Ki2 = KingMidle;


		SetRowColumnFinished = false;

		Move = 0;
		//Intiate Dummy Variables.
		//When Conversion Occured.
		//SolderesOnTable =   DrawSoldier[16];
		//SolderesOnTable = DrawElefant[4];
		//HoursesOnTable =    DrawHourse[4];
		//CastlesOnTable =    DrawCastle[4];
		//MinisterOnTable =   DrawMinister[2];
		//KingOnTable =    DrawKing[2];
		/*
		for (int i = 0; i < SodierHigh; i++)
		SolderesOnTable[i] =  DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < ElefantHigh; i++)
		SolderesOnTable[i] =  DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < HourseHight; i++)
		HoursesOnTable[i] =  DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < CastleMidle; i++)
		CastlesOnTable[i] =  DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i <MinisterHigh; i++)
		MinisterOnTable[i] =  DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		for (int i = 0; i < KingHigh; i++)
		KingOnTable[i] =  DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		*/
		AllDraw::SodierConversionOcuured = false;

		//When Table Exist.
		if (TableList.size() > 0)
		{
			//For Every Table Things.
			for (int Column = 0; Column < 8; Column++)
			{
				for (int Row = 0; Row < 8; Row++)
				{
					if (TableList[index][Row][Column] == 0)
					{
						continue;
					}
					//When Things are Soldiers.
					if (abs(TableList[index][Row][Column]) == 1)
					{
						//Determine int
						int a;

						if (TableList[index][Row][Column] > 0)
						{
							a = 1;
						}
						else
						{
							a = -1;
						}
						//When int is Gray. 
						if (a == 1)
						{
							//try
							{
								//if (SolderesOnTable[So1] != null)
								//SolderesOnTable[So1].Dispose();
								//Construct Soder Gray.
								SolderesOnTable[So1] = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], 1, false, So1);
								//Increase So1.
								So1++;
								if (So1 > SodierMidle)
								{
									SodierMidle++;
									SodierHigh++;
								}


							}
							//catch(std::exception &t)
							{


							}
						}
						//When int is Brown
						else
						{
							//try
							{
								//if (SolderesOnTable[So2] != null)
								// SolderesOnTable[So2].Dispose();
								//Construct Soldeir Brown.
								SolderesOnTable[So2] = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], -1, false, So2);
								//Increase So2.
								So2++;
								if (So2 > SodierHigh)
								{
									SodierHigh++;
								}

							}
							//catch(std::exception &t)
							{


							}
						}
					}
					else //For Elephant Objects.
					{
						if (abs(TableList[index][Row][Column]) == 2)
						{
							//Initiate Local Variables.
							int a;
							if (TableList[index][Row][Column] > 0)
							{
								a = 1;
							}
							else
							{
								a = -1;
							}
							//If Gray Elepahnt
							if (a == 1)
							{
								//try
								{
									//if (SolderesOnTable[El1] != null)
									// SolderesOnTable[El1].Dispose();

									//Construction of Draw Object.
									ElephantOnTable[El1] = DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], 1, false, El1);
									//Increament of Gray Index.
									El1++;
									//If  Object Increament Gray Objects.
									if (El1 > ElefantMidle)
									{
										ElefantMidle++;
										ElefantHigh++;
									}
								}
								//catch(std::exception &t)
								{

								}
							}
							else //For Brown Elephant .Objects
							{
								//try
								{
									//if (SolderesOnTable[El2] != null)
									// SolderesOnTable[El2].Dispose();

									//Construction of Draw Brown Elephant Object. 
									ElephantOnTable[El2] = DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], -1, false, El2);
									//Increament of Index.
									El2++;
									//When  Brown Elephant Object Increament of Index.
									if (El2 > ElefantHigh)
									{
										ElefantHigh++;
									}
								}
								//catch(std::exception &t)
								{

								}

							}
						}
						else //For Hourse Objects.
						{
							if (abs(TableList[index][Row][Column]) == 3)
							{
								//Initiate Local Varibale and int.
								int a;
								if (TableList[index][Row][Column] > 0)
								{
									a = 1;
								}
								else
								{
									a = -1;
								}
								//If Gray Hourse.
								if (a == 1)
								{

									//try
									{
										// if (HoursesOnTable[Ho1] != null)
										// HoursesOnTable[Ho1].Dispose();

										//Construction of Draw Brown Hourse.
										HoursesOnTable[Ho1] = DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], 1, false, Ho1);
										//Increament of Index.
										Ho1++;
										//when There is  Gray Hourse Increase.
										if (Ho1 > HourseMidle)
										{
											HourseMidle++;
											HourseHight++;
										}
									}
									//catch(std::exception &t)
									{

									}
								} //For Brown Hourses.
								else
								{
									//try
									{
										//if (HoursesOnTable[Ho2] != null)
										//  HoursesOnTable[Ho2].Dispose();

										//Construction of Draw Brown Hourse.
										HoursesOnTable[Ho2] = DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], -1, false, Ho2);
										//Increament of Index.
										Ho2++;
										//When  Brown Hourse Exist Exist Index.
										if (Ho2 > HourseHight)
										{
											HourseHight++;
										}
									}
									//catch(std::exception &t)
									{

									}
								}
							}
							else //For Castles Objects.
							{
								if (abs(TableList[index][Row][Column]) == 4)
								{
									//Initiate of Local Variables.
									int a;
									if (TableList[index][Row][Column] > 0)
									{
										a = 1;
									}
									else
									{
										a = -1;
									}
									//For Gray int.
									if (a == 1)
									{

										//try
										{
											//if (CastlesOnTable[Br1] != null)
											//CastlesOnTable[Br1].Dispose();

											//Construction of  Draw Gray Castles.
											CastlesOnTable[Br1] = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], 1, false, Br1);
											//Increamnt of Index.
											Br1++;
											//When  Gray Briges Increamnt Max Index.
											if (Br1 > CastleMidle)
											{
												CastleMidle++;
												CastleHigh++;
											}
										}
										//catch(std::exception &t)
										{

										}
									} //For Brown Castles.
									else
									{
										//try
										{
											//if (CastlesOnTable[Br2] != null)
											//CastlesOnTable[Br2].Dispose();

											//Construction Draw of  Brown Castles.
											CastlesOnTable[Br2] = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], -1, false, Br2);
											//Increament of Index.
											Br2++;
											//wehn Brown  Castles Detected Increament Max Index.
											if (Br2 > CastleHigh)
											{
												CastleHigh++;
											}
										}
										//catch(std::exception &t)
										{

										}
									}
								}
								else //For Minister Objects.
								{
									if (abs(TableList[index][Row][Column]) == 5)
									{
										//Initiate Local int Varibales.
										int a;
										if (TableList[index][Row][Column] > 0)
										{
											a = 1;
										}
										else
										{
											a = -1;
										}
										//For Gray ints.
										if (a == 1)
										{


											//try
											{
												//if (MinisterOnTable[Mi1] != null)
												// MinisterOnTable[Mi1].Dispose();

												//construction of  draw Gray Minster.
												MinisterOnTable[Mi1] = DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], 1, false, Mi1);
												//Increament of Index.
												Mi1++;
												//Wehn  Gray Minster Detected Increament Max Indexes.
												if (Mi1 > MinisterMidle)
												{
													MinisterMidle++;
													MinisterHigh++;
												}
											}
											//catch(std::exception &t)
											{

											}

										} //For Brown  ints.
										else
										{
											//try
											{
												//if (MinisterOnTable[Mi2] != null)
												// MinisterOnTable[Mi2].Dispose();

												//Construction of  Draw Brown Minster.
												MinisterOnTable[Mi2] = DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], -1, false, Mi2);
												//Increament Index.
												Mi2++;
												//When  Brown Minister Detected Increament Max Index.
												if (Mi2 > MinisterHigh)
												{
													MinisterHigh++;
												}
											}
											//catch(std::exception &t)
											{

											}
										}
									}
									else //for King Objects.
									{
										if (abs(TableList[index][Row][Column]) == 6)
										{
											//Initiate Of int.
											int a;
											if (TableList[index][Row][Column] > 0)
											{
												a = 1;
											}
											else
											{
												a = -1;
											}
											//int consideration.
											if (a == 1)
											{

												//try
												{
													//if (KingOnTable[Ki1] != null)
													//KingOnTable[Ki1].Dispose();

													//Construction of  Draw Gray King.
													KingOnTable[Ki1] = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], 1, false, Ki1);
													//Increament of Index.
													Ki1++;
													//when  Draw  Object Detected Increament Max Index.
													if (Ki1 > KingMidle)
													{
														KingMidle++;
														KingHigh++;

													}
												}
												//catch(std::exception &t)
												{

												}
											} //For Brown King int
											else
											{
												//try
												{
													//if (KingOnTable[Ki2] != null)
													// KingOnTable[Ki2].Dispose();

													//Construction of  Draw King Brown Object.
													KingOnTable[Ki2] = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, TableList[index], -1, false, Ki2);
													//Increament of Index.
													Ki2++;
													//When  Object Detected Increament Of Brown King Max Index.
													if (Ki2 > KingHigh)
													{
														KingHigh++;
													}
												}
												//catch(std::exception &t)
												{


												}
											}

										}
									}
								}
							}
						}
					}
				}
			}
		}

		SetObjectNumbers(TableList[0]);
		for (int i = So1; i < SodierMidle; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &SolderesOnTable[i];
		}

		for (int i = So2; i < SodierHigh; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &SolderesOnTable[i];
		}

		for (int i = El1; i < ElefantMidle; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &SolderesOnTable[i];
		}

		for (int i = El2; i < ElefantHigh; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &SolderesOnTable[i];
		}

		for (int i = Ho1; i < HourseMidle; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &HoursesOnTable[i];
		}

		for (int i = Ho2; i < HourseHight; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &HoursesOnTable[i];
		}

		for (int i = Br1; i < CastleMidle; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &CastlesOnTable[i];
		}

		for (int i = Br2; i < CastleHigh; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &CastlesOnTable[i];
		}

		for (int i = Mi1; i < MinisterMidle; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &MinisterOnTable[i];
		}

		for (int i = Mi2; i < MinisterHigh; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &MinisterOnTable[i];
		}

		for (int i = Ki1; i < KingMidle; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &KingOnTable[i];
		}

		for (int i = Ki2; i < KingHigh; i++)
		{
			//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to '//delete', but you should review memory allocation of all pointer variables in the converted code:
			//delete &KingOnTable[i];
		}
		SetRowColumnFinished = true;

	}
	void AllDraw::SetRowColumnFinishedWait()
	{
		////auto a = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a)
		{
			do
			{

				//delay(2);
			} while (!SetRowColumnFinished);
		}

	}

	void AllDraw::BeginIndexFoundingMaxLessofMaxList(int ListIndex, std::vector<double> &Founded, double &LessB)
	{
		////auto a = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a)
		{
			//When There is Maximum Huristsic AStar Gredy Back Ward in Blitz Games.
			if (MaxHuristicAStarGreedytBackWard.size() > 0)
			{
				//When List Index is LessB than Founded.
				if (ListIndex < MaxHuristicAStarGreedytBackWard.size())
				{
					return;
				}
				//Initiate Variable.
				bool Added = false;
				//Recursive Method.
				BeginIndexFoundingMaxLessofMaxList(ListIndex++, Founded, LessB);
				//When Greater LessB of First index Object Found.
				if (LessB < MaxHuristicAStarGreedytBackWard[ListIndex][1])
				{
					LessB = MaxHuristicAStarGreedytBackWard[ListIndex][1];
					Added = true;

					Founded.push_back(2);
				}
				//When Greater LessB of Second index Object Found.
				if (LessB < MaxHuristicAStarGreedytBackWard[ListIndex][5])
				{
					LessB = MaxHuristicAStarGreedytBackWard[ListIndex][5];
					if (Added)
					{
						Founded.pop_back();
					}
					Added = true;
					Founded.push_back(6);
				}
				//When Greater LessB of Third index Object Found.
				if (LessB < MaxHuristicAStarGreedytBackWard[ListIndex][9])
				{
					LessB = MaxHuristicAStarGreedytBackWard[ListIndex][9];
					if (Added)
					{
						Founded.pop_back();
					}
					Added = true;
					Founded.push_back(10);
				}
				//When Greater LessB of Foutrh index Object Found.
				if (LessB < MaxHuristicAStarGreedytBackWard[ListIndex][13])
				{
					LessB = MaxHuristicAStarGreedytBackWard[ListIndex][13];
					if (Added)
					{
						Founded.pop_back();
					}
					Added = true;
					Founded.push_back(14);
				}
				//When Greater LessB of Fifth index Object Found.
				if (LessB < MaxHuristicAStarGreedytBackWard[ListIndex][18])
				{
					LessB = MaxHuristicAStarGreedytBackWard[ListIndex][18];
					if (Added)
					{
						Founded.pop_back();
					}
					Added = true;
					Founded.push_back(19);
				}
				//When Greater LessB of Sith index Object Found.
				if (LessB < MaxHuristicAStarGreedytBackWard[ListIndex][22])
				{
					LessB = MaxHuristicAStarGreedytBackWard[ListIndex][22];
					if (Added)
					{
						Founded.pop_back();
					}
					Added = true;
					Founded.push_back(23);
				}
			}
		}
	}

	bool AllDraw::IsToCheckMateHasLessDeeperThanForCheckMate(int Order, int ToCheckMate, int ForCheckMate, int AStarGreedyInt)
	{


		//Initiate variables.
		bool AA = false;
		int CDummy = Order;
		//For Gray One.
		if (Order == 1)
		{

			//For Solderis.
			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					//When there is Brown checked mate.
					if (SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy == -1)
					{
						//Set.
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&SolderesOnTable) != nullptr) && (&(SolderesOnTable[i]) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{

					//When there is Brown checked mate.
					if (ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}



					}
					else
					{
						//When there is Gray Checked mate.
						if (ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{

					//When there is Brown checked mate.
					if (HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && 
					(&(CastlesOnTable[i]) != nullptr) &&					
					(&(CastlesOnTable[i].CastleThinking) != nullptr) &&
					(j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{

					{
						//When there is Brown checked mate.
						if (CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy == -1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ToCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
						else
						{
							//When there is Gray Checked mate.
							if (CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy == 1)
							{
								ForCheckMate = AStarGreedyInt;
								if (ForCheckMate >= 0)
								{
									if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
									{
										AA = true;
									}
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&CastlesOnTable) != nullptr) && 
						(&(CastlesOnTable[i]) != nullptr) && 
						(&(CastlesOnTable[i].CastleThinking) != nullptr) &&
						(ii <CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j <MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{

					//When there is Brown checked mate.
					if (MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}


						}
					}
					Order *= -1;
					for (int ii = 0; ((&MinisterOnTable) != nullptr)
						&& (&(MinisterOnTable[i]) != nullptr) &&
						(&(MinisterOnTable[i].MinisterThinking) != nullptr) &&
						(ii <MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{

					//When there is Brown checked mate.
					if (KingOnTable[i].KingThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (KingOnTable[i].KingThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || KingOnTable[i].KingThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
		}
		else
		{
			//ChessRules::CurrentOrder = -1;
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j< SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					{
						//When there is Brown checked mate.
						if (SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy == -1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ToCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
						else
						{
							//When there is Gray Checked mate.
							if (SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy == 1)
							{
								ForCheckMate = AStarGreedyInt;
								if (ForCheckMate >= 0)
								{
									if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
									{
										AA = true;
									}
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && ((&(SolderesOnTable[i].SoldierThinking)) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{

					//When there is Brown checked mate.
					if (ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{

					if (HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j<CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{

					//When there is Brown checked mate.
					if (CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}
					Order *= -1;
					for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{

					//When there is Brown checked mate.
					if (MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy == -1)
					{
						ForCheckMate = AStarGreedyInt;
						if (ToCheckMate >= 0)
						{
							if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
							{
								AA = true;
							}
						}
					}
					else
					{
						//When there is Gray Checked mate.
						if (MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy == 1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ForCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
					}

					Order *= -1;
					for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}
			for (int i = KingMidle; i < KingHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{

					{
						//When there is Brown checked mate.
						if (KingOnTable[i].KingThinking[0].CheckMateAStarGreedy == -1)
						{
							ForCheckMate = AStarGreedyInt;
							if (ToCheckMate >= 0)
							{
								if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
								{
									AA = true;
								}
							}
						}
						else
						{
							//When there is Gray Checked mate.
							if (KingOnTable[i].KingThinking[0].CheckMateAStarGreedy == 1)
							{
								ForCheckMate = AStarGreedyInt;
								if (ForCheckMate >= 0)
								{
									if (ToCheckMate < ForCheckMate && ToCheckMate >= 0)
									{
										AA = true;
									}
								}
							}
						}

					}
					Order *= -1;
					for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
					{
						AA = AA || KingOnTable[i].KingThinking[0].AStarGreedy[ii].IsToCheckMateHasLessDeeperThanForCheckMate(Order, ToCheckMate, ForCheckMate, AStarGreedyInt++);
					}
					Order = CDummy;
				}
			}

		}
		ChessRules::CurrentOrder = CDummy;
		return AA;

	}


	void AllDraw::IsPenaltyRegardCheckMateAtBranch(int Order, int Do, AllDraw Base)
	{

		int CDummy = ChessRules::CurrentOrder;
		int COrder = Order;
		//For Gray Order.
		if (Order == 1)
		{
			

			//ChessRules::CurrentOrder = 1;
			//For  Soldeirs.
			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					//Create Rules Objects For Soldiers.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, SolderesOnTable[i].SoldierThinking[0].TableListSolder[j][SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][1]], SolderesOnTable[i].SoldierThinking[0].TableListSolder[j], Order, SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][0], SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][1]);
					//When CheckMate Occured for Current Sodiers
					if (AA.CheckMate(SolderesOnTable[i].SoldierThinking[0].TableListSolder[j], Order))
					{
						//When Self CheckMate
						if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
						{
							//Return Ignore
							(Do) = -1;
							//Set Superposition.
							SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//When Enemy CheckMate
							if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
							{
								//Set Regard and Set Movements.
								(Do) = 1;
								//Regard Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
								//Set Superpostion.
								SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy = 1;
							}
						}
					}
					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//For Subbranchs.
						for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
						{
							SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}

				}
			}
			//For Elephant.
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j <ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{

					//Create Elephant Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ElephantOnTable[i].ElefantThinking[0].TableListElefant[j][ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][0]][ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][1]], ElephantOnTable[i].ElefantThinking[0].TableListElefant[j], Order, ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][0], ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][1]);
					//When CheckMate Occured for Current Elephant.
					if (AA.CheckMate(ElephantOnTable[i].ElefantThinking[0].TableListElefant[j], Order))
					{
						//For Self Order CheckMate.
						if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
						{
							//Set Penalty Ignore.
							(Do) = -1;
							//Set Superposition.
							ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//For Enemy Order CheckMate.
							if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
							{
								//Set Regard Continue.
								(Do) = 1;
								//Regard Subolders.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
								//Set Superposition.
								ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy = 1;
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//For Subbranchs.
						for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
						{
							ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//For Hourse.
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{


					//Set Hourse Rules Objects.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, HoursesOnTable[i].HourseThinking[0].TableListHourse[j][HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][0]][HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][1]], HoursesOnTable[i].HourseThinking[0].TableListHourse[j], Order, HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][0], HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][1]);
					//When CheckMate Occured.
					if (AA.CheckMate(HoursesOnTable[i].HourseThinking[0].TableListSolder[j], Order))
					{
						//For Self CheckMate.
						if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
						{
							//Set Ignore.
							(Do) = -1;
							//Set Superposition.
							HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//For Enemy CheckMate.
							if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
							{
								//Set Regard.
								(Do) = 1;
								//Superposition.
								HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy = 1;
								//Set Regard For Sub Branches.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//Sub branchs For Hourse.
						for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
						{
							HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//For Gray Briges.
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{


					//Castles Gray Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, CastlesOnTable[i].CastleThinking[0].TableListCastle[j][CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][0]][CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][1]], CastlesOnTable[i].CastleThinking[0].TableListCastle[j], Order, CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][0], CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][1]);
					//When Current Gray Castles CheckMate.
					if (AA.CheckMate(CastlesOnTable[i].CastleThinking[0].TableListCastle[j], Order))
					{
						//For Self CheckMate
						if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
						{
							//Set Penalty Ignore.
							(Do) = -1;
							//Set Superposition.
							CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Sub branchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//For Enemy CheckMate.
							if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
							{
								//Set Regard.
								(Do) = 1;
								//Superpoistion.
								CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy = 1;
								//Set Regard Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//For Castles Gray Subbranchs.
						//try
						{
							for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
							{
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//For Ministers Gray.
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; (((&MinisterOnTable) != nullptr)) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{


					//Minister Gray Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, MinisterOnTable[i].MinisterThinking[0].TableListMinister[j][MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][0]][MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][1]], MinisterOnTable[i].MinisterThinking[0].TableListMinister[j], Order, MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][0], MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][1]);
					//When M ate Occured in Minister Gray.
					if (AA.CheckMate(MinisterOnTable[i].MinisterThinking[0].TableListMinister[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
						{
							//Penalty Ignore.
							(Do) = -1;
							//Superpostion.
							MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//For Enemy CheckMate.
							if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
							{
								//Regard Setting.
								(Do) = 1;
								//Superpoistion.
								MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy = 1;
								//Set Subbranchs Regard.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//For Gray Ministers Subbranchs.
						//try
						{
							for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
							{
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//For Gray King.
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{


					//Gray King Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, KingOnTable[i].KingThinking[0].TableListKing[j][KingOnTable[i].KingThinking[0].RowColumnKing[j][0]][KingOnTable[i].KingThinking[0].RowColumnKing[j][1]], KingOnTable[i].KingThinking[0].TableListKing[j], Order, KingOnTable[i].KingThinking[0].RowColumnKing[j][0], KingOnTable[i].KingThinking[0].RowColumnKing[j][1]);
					//When CheckMate Occured in King Gray.
					if (AA.CheckMate(KingOnTable[i].KingThinking[0].TableListKing[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
						{
							//Penalty Ignore.
							(Do) = -1;
							//Superposition.
							KingOnTable[i].KingThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//Self CheckMate.
							if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
							{
								//Regard Setting.
								(Do) = 1;
								//Superpoistion.
								KingOnTable[i].KingThinking[0].CheckMateAStarGreedy = 1;
								//Regard Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//For King Gray Subbranchs.
						//try
						{
							for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
							{
								KingOnTable[i].KingThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
		}
		//For Brown Order.
		else
		{
			
			//ChessRules::CurrentOrder = -1;
			//For Solders Brown.
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{


					//Solders Brown Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, SolderesOnTable[i].SoldierThinking[0].TableListSolder[j][SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][1]], SolderesOnTable[i].SoldierThinking[0].TableListSolder[j], Order, SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][0], SolderesOnTable[i].SoldierThinking[0].RowColumnSoldier[j][1]);
					//When Solders Brown CheckMate Occured.
					if (AA.CheckMate(SolderesOnTable[i].SoldierThinking[0].TableListSolder[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
						{
							//Ignore Penalty.
							(Do) = -1;
							//Supperpoistion.
							SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs Soders Brown.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//Self CheckMate.
							if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
							{
								//Set Regard.
								(Do) = 1;
								//Superpoition.
								SolderesOnTable[i].SoldierThinking[0].CheckMateAStarGreedy = 1;
								//Penalty Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//Solders Brown Subbranchs Calling.
						//try
						{
							for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
							{
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//Elephant Brown 
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{


					//Elephant Brown Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ElephantOnTable[i].ElefantThinking[0].TableListElefant[j][ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][0]][ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][1]], ElephantOnTable[i].ElefantThinking[0].TableListElefant[j], Order, ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][0], ElephantOnTable[i].ElefantThinking[0].RowColumnElefant[j][1]);
					//CheckMate Occured in Elephenat Brown.
					if (AA.CheckMate(ElephantOnTable[i].ElefantThinking[0].TableListElefant[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
						{
							//Ignore Penalty.
							(Do) = -1;
							//Superpoistion.
							ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//CheckMate Enemy.
							if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
							{
								//Set Regrading.
								(Do) = 1;
								//Superposition.
								ElephantOnTable[i].ElefantThinking[0].CheckMateAStarGreedy = 1;
								//Regrad Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//Subbranchs Elephenat Brown Calling.
						//try
						{
							for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
							{
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//Hourse Brown 
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{

					//Hourse Brown Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, HoursesOnTable[i].HourseThinking[0].TableListHourse[j][HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][0]][HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][1]], HoursesOnTable[i].HourseThinking[0].TableListHourse[j], Order, HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][0], HoursesOnTable[i].HourseThinking[0].RowColumnHourse[j][1]);
					//When Hourse Broin CheckMate Ocuucred.
					if (AA.CheckMate(HoursesOnTable[i].HourseThinking[0].TableListSolder[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
						{
							//Ignore Penalty.
							(Do) = -1;
							//Superposition.
							HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranchs.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//CheckMate Enemy.
							if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
							{
								//Set Regrad.
								(Do) = 1;
								//Superposition.
								HoursesOnTable[i].HourseThinking[0].CheckMateAStarGreedy = 1;
								//Regrad Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//Hourse Brown Calling Subbranchs.
						//try
						{
							for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
							{
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//Castles Brown 
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{


					//Castles Brown Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, CastlesOnTable[i].CastleThinking[0].TableListCastle[j][CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][0]][CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][1]], CastlesOnTable[i].CastleThinking[0].TableListCastle[j], Order, CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][0], CastlesOnTable[i].CastleThinking[0].RowColumnCastle[j][1]);
					//When Brown Castles CheckMate Occured.
					if (AA.CheckMate(CastlesOnTable[i].CastleThinking[0].TableListCastle[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
						{
							//Ignore CheckMate.
							(Do) = -1;
							//Superpoistion.
							CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy = -1;
							//Subbranchs Penalty.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//CheckMate Enemy.
							if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
							{
								//Set Regard.
								(Do) = 1;
								//Superpoistion.
								CastlesOnTable[i].CastleThinking[0].CheckMateAStarGreedy = 1;
								//Regard Subbranchs.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//Brown Castles Calling Subbranches.
						//try
						{
							for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
							{
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//Minister Brown 
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{


					//Minister Brown Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, MinisterOnTable[i].MinisterThinking[0].TableListMinister[j][MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][0]][MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][1]], MinisterOnTable[i].MinisterThinking[0].TableListMinister[j], Order, MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][0], MinisterOnTable[i].MinisterThinking[0].RowColumnMinister[j][1]);
					//When Minister Borwn CheckMate Occcured.
					if (AA.CheckMate(MinisterOnTable[i].MinisterThinking[0].TableListMinister[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
						{
							//Set Ignore.
							(Do) = -1;
							//Superpoistion.
							MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy = -1;
							//Penalty Subbranches.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//CheckMate Enemy.
							if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
							{
								//Set Regard.
								(Do) = 1;
								//Superposition.
								MinisterOnTable[i].MinisterThinking[0].CheckMateAStarGreedy = 1;
								//Regard SubBranches.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}

					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//Minister Brown SubBranches Calling.
						//try
						{
							for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
							{
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}
			//King Brown
			for (int i = KingMidle; i < KingHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{


					//King Brown Rules.
					ChessRules AA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, KingOnTable[i].KingThinking[0].TableListKing[j][KingOnTable[i].KingThinking[0].RowColumnKing[j][0]][KingOnTable[i].KingThinking[0].RowColumnKing[j][1]], KingOnTable[i].KingThinking[0].TableListKing[j], Order, KingOnTable[i].KingThinking[0].RowColumnKing[j][0], KingOnTable[i].KingThinking[0].RowColumnKing[j][1]);
					//When King Brown Rules CheckMate Occcured.
					if (AA.CheckMate(KingOnTable[i].KingThinking[0].TableListKing[j], Order))
					{
						//Self CheckMate.
						if (AllDraw::OrderPlate == -1 && AA.CheckMateBrown)
						{
							//Set Ignore.
							(Do) = -1;
							//Superposition.
							KingOnTable[i].KingThinking[0].CheckMateAStarGreedy = -1;
							//Penalty SubBranches.
							MakePenaltyAllCheckMateBranches(Base, AllDraw::OrderPlate);
						}
						else
						{
							//CheckMate Enemy.
							if (AllDraw::OrderPlate == 1 && AA.CheckMateGray)
							{
								//Set Regard.
								(Do) = 1;
								//Superposition.
								KingOnTable[i].KingThinking[0].CheckMateAStarGreedy = 1;
								//Regard Subbranches.
								MakeRegardAllCheckMateBranches(Base, AllDraw::OrderPlate);
							}
						}
					}


					if ((Do) != -1)
					{
						Order *= -1;
						ChessRules::CurrentOrder *= -1;
						//King Brown Subbranches Calling.
						//try
						{
							for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
							{
								KingOnTable[i].KingThinking[0].AStarGreedy[ii].IsPenaltyRegardCheckMateAtBranch(Order, Do, Base);
							}
						}
						//catch(std::exception &t)
						{

						}
						Order = COrder;
						ChessRules::CurrentOrder = CDummy;
					}
				}
			}

			ChessRules::CurrentOrder = CDummy;

		}
	}
	void AllDraw::MakePenaltyAllCheckMateBranches(AllDraw A, int Order)
	{
		int COrder = Order;
		int CDummy = ChessRules::CurrentOrder;
		if (Order == 1)
		{

			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					//try
					//{
					SolderesOnTable[i].SoldierThinking[0].PenaltyRegardListSolder[i].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					///{

					//}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii], Order);
					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{

					//try
					//{
					ElephantOnTable[i].ElefantThinking[0].PenaltyRegardListElefant[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					//{
					HoursesOnTable[i].HourseThinking[0].PenaltyRegardListHourse[j].LearningAlgorithmPenalty();

					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					//{
					CastlesOnTable[i].CastleThinking[0].PenaltyRegardListCastle[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					//{
					MinisterOnTable[i].MinisterThinking[0].PenaltyRegardListMinister[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					//{
					KingOnTable[i].KingThinking[0].PenaltyRegardListKing[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii <KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(KingOnTable[i].KingThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					//try
					{
						SolderesOnTable[i].SoldierThinking[0].PenaltyRegardListSolder[i].LearningAlgorithmPenalty();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					//{
					ElephantOnTable[i].ElefantThinking[0].PenaltyRegardListElefant[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{
						HoursesOnTable[i].HourseThinking[0].PenaltyRegardListHourse[j].LearningAlgorithmPenalty();

					}
					//catch(std::exception &t)
					{

					}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii], Order);
					}
					//}
					////catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					//{
					CastlesOnTable[i].CastleThinking[0].PenaltyRegardListCastle[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					//{
					MinisterOnTable[i].MinisterThinking[0].PenaltyRegardListMinister[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = KingMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					//{
					KingOnTable[i].KingThinking[0].PenaltyRegardListKing[j].LearningAlgorithmPenalty();
					//}
					//catch(std::exception &t)
					//{

					//}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					//{
					for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
					{
						MakePenaltyAllCheckMateBranches(KingOnTable[i].KingThinking[0].AStarGreedy[ii], Order);
					}
					//}
					//catch(std::exception &t)
					//{

					//}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
		}

	}

	void AllDraw::RemovePenalltyFromFirstBranches(int Order)
	{


		if (Order == 1)
		{

			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{
						SolderesOnTable[i].SoldierThinking[0].PenaltyRegardListSolder[j].Initiate();
						for (int k = 0; k < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); k++)
						{
							SolderesOnTable[i].SoldierThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						ElephantOnTable[i].ElefantThinking[0].PenaltyRegardListElefant[j].Initiate();
						for (int k = 0; k < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); k++)
						{
							ElephantOnTable[i].ElefantThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{
						HoursesOnTable[i].HourseThinking[0].PenaltyRegardListHourse[j].Initiate();
						for (int k = 0; k < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); k++)
						{
							HoursesOnTable[i].HourseThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}
					}
					//catch(std::exception &t)
					{

					}


				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						CastlesOnTable[i].CastleThinking[0].PenaltyRegardListCastle[j].Initiate();
						for (int k = 0; k < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); k++)
						{
							CastlesOnTable[i].CastleThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}
					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						MinisterOnTable[i].MinisterThinking[0].PenaltyRegardListMinister[j].Initiate();
						for (int k = 0; k < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); k++)
						{
							MinisterOnTable[i].MinisterThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}
					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						KingOnTable[i].KingThinking[0].PenaltyRegardListKing[j].Initiate();
						for (int k = 0; k < KingOnTable[i].KingThinking[0].AStarGreedy.size(); k++)
						{
							KingOnTable[i].KingThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}
					}
					//catch(std::exception &t)
					{

					}

				}
			}
		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						SolderesOnTable[i].SoldierThinking[0].PenaltyRegardListSolder[j].Initiate();
						for (int k = 0; k < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); k++)
						{
							SolderesOnTable[i].SoldierThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						ElephantOnTable[i].ElefantThinking[0].PenaltyRegardListElefant[j];
						for (int k = 0; k < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); k++)
						{
							ElephantOnTable[i].ElefantThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						HoursesOnTable[i].HourseThinking[0].PenaltyRegardListHourse[j].Initiate();
						for (int k = 0; k < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); k++)
						{
							HoursesOnTable[i].HourseThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						CastlesOnTable[i].CastleThinking[0].PenaltyRegardListCastle[j].Initiate();
						for (int k = 0; k < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); k++)
						{
							CastlesOnTable[i].CastleThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{

						MinisterOnTable[i].MinisterThinking[0].PenaltyRegardListMinister[j].Initiate();
						for (int k = 0; k < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); k++)
						{
							MinisterOnTable[i].MinisterThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = KingMidle; i < KingHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					UsePenaltyRegardMechnisamT = false;
					//try
					{
						KingOnTable[i].KingThinking[0].PenaltyRegardListKing[j].Initiate();
						for (int k = 0; k < KingOnTable[i].KingThinking[0].AStarGreedy.size(); k++)
						{
							KingOnTable[i].KingThinking[0].AStarGreedy[k].RemovePenalltyFromFirstBranches(Order * -1);
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
		}
		return;

	}

	AllDraw AllDraw::FoundOfCurrentTableNode(int **Tab, int Order, AllDraw THIS ,bool &Found)
	{


		ThinkingChess::NumbersOfAllNode++;
		if (TableList.size() > 0 && ThinkingChess::TableEqual(TableList[0], Tab))
		{
			Clone(THIS);
			Found = true;
			return THIS;
		}
		else

			if (Order == 1)
			{

				for (int i = 0; i < SodierMidle; i++)
				{
					for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
					{

						//try
						{
							if (ThinkingChess::TableEqual(SolderesOnTable[i].SoldierThinking[0].TableListSolder[j], Tab))
							{
								if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() > j && SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() > 0)
								{
									THIS = SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); ii++)
								{
									SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);
								}
							}

						}

						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = 0; i < ElefantMidle; i++)
				{
					for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
					{
						//try
						{

							if (ThinkingChess::TableEqual(ElephantOnTable[i].ElefantThinking[0].TableListElefant[j], Tab))
							{
								if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() > j && ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() > 0)
								{
									THIS = ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); ii++)
								{
									ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}


						}
						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = 0; i < HourseMidle; i++)
				{
					for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
					{
						//try
						{
							if (ThinkingChess::TableEqual(HoursesOnTable[i].HourseThinking[0].TableListHourse[j], Tab))
							{
								if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() > j && HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() > 0)
								{
									THIS = HoursesOnTable[i].HourseThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); ii++)
								{
									HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}


					}
				}
				for (int i = 0; i < CastleMidle; i++)
				{
					for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
					{
						//try
						{
							if (ThinkingChess::TableEqual(CastlesOnTable[i].CastleThinking[0].TableListCastle[j], Tab))
							{
								if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() > j && CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() > 0)
								{
									THIS = CastlesOnTable[i].CastleThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < CastlesOnTable[ii].CastleThinking[0].AStarGreedy.size(); ii++)
								{
									CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}
						}
						//catch(std::exception &t)
						{

						}

					}
				}
				for (int i = 0; i < MinisterMidle; i++)
				{
					for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
					{
						//try
						{
							if (ThinkingChess::TableEqual(MinisterOnTable[i].MinisterThinking[0].TableListMinister[j], Tab))
							{
								if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() > j && MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() > 0)
								{
									THIS = MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); ii++)
								{
									MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}

					}
				}
				for (int i = 0; i < KingMidle; i++)
				{
					for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
					{
						//try
						{
							if (ThinkingChess::TableEqual(KingOnTable[i].KingThinking[0].TableListKing[j], Tab))
							{
								if (KingOnTable[i].KingThinking[0].AStarGreedy.size() > j && KingOnTable[i].KingThinking[0].AStarGreedy.size() > 0)
								{
									THIS = KingOnTable[i].KingThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); ii++)
								{
									KingOnTable[i].KingThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}

					}
				}
			}
			else
			{
				for (int i = SodierMidle; i < SodierHigh; i++)
				{
					for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
					{
						//try
						{

							if (ThinkingChess::TableEqual(SolderesOnTable[i].SoldierThinking[0].TableListSolder[j], Tab))
							{
								if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() > j && SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() > 0)
								{
									THIS = SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); ii++)
								{
									SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = ElefantMidle; i < ElefantHigh; i++)
				{
					for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
					{
						//try
						{

							if (ThinkingChess::TableEqual(ElephantOnTable[i].ElefantThinking[0].TableListElefant[j], Tab))
							{
								if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() > j && ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() > 0)
								{
									THIS = ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); ii++)
								{
									ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = HourseMidle; i < HourseHight; i++)
				{
					for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
					{
						//try
						{

							if (ThinkingChess::TableEqual(HoursesOnTable[i].HourseThinking[0].TableListHourse[j], Tab))
							{
								if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() > j && HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() > 0)
								{
									THIS = HoursesOnTable[i].HourseThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); ii++)
								{
									HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}


						}
						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = CastleMidle; i < CastleHigh; i++)
				{
					for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
					{
						//try
						{

							if (ThinkingChess::TableEqual(CastlesOnTable[i].CastleThinking[0].TableListCastle[j], Tab))
							{
								if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() > j && CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() > 0)
								{
									THIS = CastlesOnTable[i].CastleThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < CastlesOnTable[ii].CastleThinking[0].AStarGreedy.size(); ii++)
								{
									CastlesOnTable[ii].CastleThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = MinisterMidle; i < MinisterHigh; i++)
				{
					for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
					{
						//try
						{
							if (ThinkingChess::TableEqual(MinisterOnTable[i].MinisterThinking[0].TableListMinister[j], Tab))
							{
								if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() > j && MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() > 0)
								{
									THIS = MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); ii++)
								{
									MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}
					}
				}
				for (int i = KingMidle; i < KingHigh; i++)
				{
					for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
					{
						//try
						{
							if (ThinkingChess::TableEqual(KingOnTable[i].KingThinking[0].TableListKing[j], Tab))
							{
								if (KingOnTable[i].KingThinking[0].AStarGreedy.size() > j && KingOnTable[i].KingThinking[0].AStarGreedy.size() > 0)
								{
									THIS = KingOnTable[i].KingThinking[0].AStarGreedy[j];
									Found = true;
									return THIS;
								}
							}
							else
							{
								for (int ii = 0; ii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); ii++)
								{
									KingOnTable[i].KingThinking[0].AStarGreedy[ii].FoundOfCurrentTableNode(Tab, Order * -1,*this,  Found);;
								}
							}

						}
						//catch(std::exception &t)
						{

						}
					}
				}
			}
		return THIS;

	}

	AllDraw AllDraw::FoundOfLeafDepenOfKind(int Kind, AllDraw Leaf, bool &Found, int Order, int OrderLeaf)
	{


		if (Found)
		{
			return Leaf;
		}
		if (Order == 1)
		{

			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					//try
					{
						if (SolderesOnTable[i].SoldierThinking[0].IsThereMateOfEnemy || SolderesOnTable[i].SoldierThinking[0].AStarGreedy.empty() && Kind == 1)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;

						}
						else
						{
							for (int ii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() - 1; ii++)
							{
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}

					}

					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{
						if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.empty() && Kind == 2)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() - 1; ii++)
							{
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{
						if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.empty() && Kind == 3)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() - 1; ii++)
							{
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}

					}
					//catch(std::exception &t)
					{

					}


				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{
						if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.empty() && Kind == 4)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() - 1; ii++)
							{
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}
					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.empty() && Kind == 5)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() - 1; ii++)
							{
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}

					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						if (KingOnTable[i].KingThinking[0].AStarGreedy.empty() && Kind == 6)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < KingOnTable[i].KingThinking[0].AStarGreedy.size() - 1; ii++)
							{
								KingOnTable[i].KingThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}

					}
					//catch(std::exception &t)
					{

					}

				}
			}
		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					//try
					{

						if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.empty() && Kind == 1)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() - 1; ii++)
							{
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{

						if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.empty() && Kind == 2)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() - 1; ii++)
							{
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{

						if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.empty() && Kind == 3)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() - 1; ii++)
							{
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{

						if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.empty() && Kind == 4)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() - 1; ii++)
							{
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.empty() && Kind == 5)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;
						}
						else
						{
							for (int ii = 0; ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() - 1; ii++)
							{
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = KingMidle; i < KingHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						if (KingOnTable[i].KingThinking[0].AStarGreedy.empty() && Kind == 6)
						{
							Found = true;
							Clone(Leaf);
							return Leaf;

						}
						else
						{
							for (int ii = 0; ii < KingOnTable[i].KingThinking[0].AStarGreedy.size() - 1; ii++)
							{
								KingOnTable[i].KingThinking[0].AStarGreedy[ii].FoundOfLeafDepenOfKind(Kind, Leaf, Found, Order * -1, OrderLeaf);
							}
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
		}
		return Leaf;

	}

	bool AllDraw::IsFoundOfLeafDepenOfKindhaveVictory(int Kind, bool &Found, int Order)
	{


		if (Found)
		{
			return true;
		}
		if (Order == 1)
		{

			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					//try
					{
						if (SolderesOnTable[i].SoldierThinking[0].IsThereMateOfEnemy && Kind == 1) // && SolderesOnTable[i] .SoldierThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); ii++)
							{
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}

					}

					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{
						if (ElephantOnTable[i].ElefantThinking[0].IsThereMateOfEnemy && Kind == 2) //&& SolderesOnTable[i].ElefantThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); ii++)
							{
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{
						if (HoursesOnTable[i].HourseThinking[0].IsThereMateOfEnemy && Kind == 3) //&& HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); ii++)
							{
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}

					}
					//catch(std::exception &t)
					{

					}


				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{
						if (CastlesOnTable[i].CastleThinking[0].IsThereMateOfEnemy && Kind == 4) //&& CastlesOnTable[ii].CastleThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); ii++)
							{
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}
					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						if (MinisterOnTable[i].MinisterThinking[0].IsThereMateOfEnemy && Kind == 5) //&& MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); ii++)
							{
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}

					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						if (KingOnTable[i].KingThinking[0].IsThereMateOfEnemy && Kind == 6) //&& KingOnTable[i].KingThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); ii++)
							{
								KingOnTable[i].KingThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}

					}
					//catch(std::exception &t)
					{

					}

				}
			}
		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					//try
					{

						if (SolderesOnTable[i].SoldierThinking[0].IsThereMateOfEnemy && Kind == 1) //&& SolderesOnTable[i] .SoldierThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); ii++)
							{
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{

						if (ElephantOnTable[i].ElefantThinking[0].IsThereMateOfEnemy && Kind == 2) //&& SolderesOnTable[i].ElefantThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); ii++)
							{
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{

						if (HoursesOnTable[i].HourseThinking[0].IsThereMateOfEnemy && Kind == 3) //&& HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); ii++)
							{
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{

						if (CastlesOnTable[i].CastleThinking[0].IsThereMateOfEnemy && Kind == 4) //&& CastlesOnTable[ii].CastleThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); ii++)
							{
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						if (MinisterOnTable[i].MinisterThinking[0].IsThereMateOfEnemy && Kind == 5) //&& MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;
						}
						else
						{
							for (int ii = 0; ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); ii++)
							{
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = KingMidle; i < KingHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						if (KingOnTable[i].KingThinking[0].IsThereMateOfEnemy && Kind == 6) //&& KingOnTable[i].KingThinking[0].AStarGreedy.size() == 0
						{
							Found = true;
							return true;

						}
						else
						{
							for (int ii = 0; ii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); ii++)
							{
								KingOnTable[i].KingThinking[0].AStarGreedy[ii].IsFoundOfLeafDepenOfKindhaveVictory(Kind, Found, Order * -1);
							}
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
		}
		return Found;

	}

	void AllDraw::FoundOfLeafDepenOfKind(int **Table, int Order, int iAStarGreedy, int ii, int jj, int ik, int jjj, bool FOUND, int LeafAStarGreedy)
	{

		//if()
		bool FullGameFound = false;

		int **table = CloneATable(table);
		OutPut = std::wstring(L"\r\nLeaf Tree Creation is ") + StringConverterHelper::toString(LeafAStarGreedy) + std::wstring(L"at AStarGreedy ") + StringConverterHelper::toString(iAStarGreedy);
		if (Order == 1)
		{

			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					//try
					{
						if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);

						}
						else
						{
							for (int iii = 0; iii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(SolderesOnTable[i].SoldierThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}

					}

					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{
						if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(ElephantOnTable[i].ElefantThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{
						if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(HoursesOnTable[i].HourseThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}

					}
					//catch(std::exception &t)
					{

					}


				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{
						if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(CastlesOnTable[i].CastleThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}
					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(MinisterOnTable[i].MinisterThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}


					}
					//catch(std::exception &t)
					{

					}

				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						if (KingOnTable[i].KingThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								KingOnTable[i].KingThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(KingOnTable[i].KingThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}

					}
					//catch(std::exception &t)
					{

					}

				}
			}
		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					//try
					{

						if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								SolderesOnTable[i].SoldierThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(SolderesOnTable[i].SoldierThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{

						if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								ElephantOnTable[i].ElefantThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(ElephantOnTable[i].ElefantThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{

						if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								HoursesOnTable[i].HourseThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(HoursesOnTable[i].HourseThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}
					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{

						if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								CastlesOnTable[i].CastleThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(CastlesOnTable[i].CastleThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.empty())
						{

							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								MinisterOnTable[i].MinisterThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(MinisterOnTable[i].MinisterThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}

					}
					//catch(std::exception &t)
					{

					}
				}
			}
			for (int i = KingMidle; i < KingHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						if (KingOnTable[i].KingThinking[0].AStarGreedy.empty())
						{
							FullGameFound = true;
							FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
						}
						else
						{
							for (int iii = 0; iii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); iii++)
							{
								ThinkingChess::NumbersOfAllNode++;
								KingOnTable[i].KingThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKind(KingOnTable[i].KingThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
							}
						}


					}
					//catch(std::exception &t)
					{

					}
				}
			}
		}

		if (!FullGameFound)
		{
			//autoO1 = new Object();
			//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				iAStarGreedy++;
				int a = 1;
				if (Order == -1)
				{
					a = -1;
				}
				InitiateAStarGreedyt(MaxAStarGreedy, ii, jj, a, table, Order, false, false, LeafAStarGreedy);
				//Initiate(ii, jj, a, table, Order, false, false,LeafAStarGreedy);
			}
		}
		return;
	}




	void AllDraw::MakeRegardAllCheckMateBranches(AllDraw A, int Order)
	{

		int COrder = Order;
		int CDummy = ChessRules::CurrentOrder;

		if (Order == 1)
		{

			for (int i = 0; i < SodierMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{

					//try
					{
						SolderesOnTable[i].SoldierThinking[0].PenaltyRegardListSolder[i].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii], Order);
						}

					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{

					//try
					{
						ElephantOnTable[i].ElefantThinking[0].PenaltyRegardListElefant[j].LearningAlgorithmRegard();

					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{
						HoursesOnTable[i].HourseThinking[0].PenaltyRegardListHourse[j].LearningAlgorithmRegard();

					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{
						CastlesOnTable[i].CastleThinking[0].PenaltyRegardListCastle[j].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						MinisterOnTable[i].MinisterThinking[0].PenaltyRegardListMinister[j].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}

					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = 0; i < KingMidle; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						KingOnTable[i].KingThinking[0].PenaltyRegardListKing[j].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(KingOnTable[i].KingThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
				{
					//try
					{
						SolderesOnTable[i].SoldierThinking[0].PenaltyRegardListSolder[i].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(SolderesOnTable[i].SoldierThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
				{
					//try
					{
						ElephantOnTable[i].ElefantThinking[0].PenaltyRegardListElefant[j].LearningAlgorithmRegard();

					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (ii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(ElephantOnTable[i].ElefantThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				for (int j = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
				{
					//try
					{
						HoursesOnTable[i].HourseThinking[0].PenaltyRegardListHourse[j].LearningAlgorithmRegard();

					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking) != nullptr) && (ii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(HoursesOnTable[i].HourseThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
				{
					//try
					{
						CastlesOnTable[i].CastleThinking[0].PenaltyRegardListCastle[j].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (ii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(CastlesOnTable[i].CastleThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size()); j++)
				{
					//try
					{
						MinisterOnTable[i].MinisterThinking[0].PenaltyRegardListMinister[j].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking) != nullptr) && (ii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(MinisterOnTable[i].MinisterThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
			for (int i = KingMidle; i < MinisterHigh; i++)
			{
				for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[0].TableListKing.size()); j++)
				{
					//try
					{
						KingOnTable[i].KingThinking[0].PenaltyRegardListKing[j].LearningAlgorithmRegard();
					}
					//catch(std::exception &t)
					{

					}
					Order *= -1;
					ChessRules::CurrentOrder *= -1;
					//try
					{
						for (int ii = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (ii < KingOnTable[i].KingThinking[0].AStarGreedy.size()); ii++)
						{
							MakeRegardAllCheckMateBranches(KingOnTable[i].KingThinking[0].AStarGreedy[ii], Order);
						}
					}
					//catch(std::exception &t)
					{

					}
					Order = COrder;
					ChessRules::CurrentOrder = CDummy;
				}
			}
		}

	}


	void AllDraw::StringHuristics(int Obj, int Sec, bool AA, int Do, int WinOcuuredatChiled, int LoseOcuuredatChiled)
	{
		std::wstring SOut = L"";
		if (Obj == 1)
		{
			SOut = L"Soldier ";
		}
		else
		{
			if (Obj == 2)
			{
			SOut = L"Elephant ";
			}
		else
		{
			if (Obj == 3)
			{
			SOut = L"Hourse ";
			}
		else
		{
			if (Obj == 4)
			{
			SOut = L"Castle ";
			}
		else
		{
			if (Obj == 5)
			{
			SOut = L"Minister ";
			}
		else
		{
				if (Obj == 6)
				{
			SOut = L"King ";
				}
		}
		}
		}
		}
		}
		SOut += std::wstring(L"AStar Huristics ");
		if (Sec == 1)
		{
			SOut += std::wstring(L" -Initiatetion- ");
		}
		if (Sec == 2)
		{
			SOut += std::wstring(L" -Regard- ");
		}
		if (Sec == 3)
		{
			SOut += std::wstring(L" -Foundation Greatest- ");
		}
		if (WinOcuuredatChiled >= 1)
		{
			SOut += std::wstring(L" At -WinKing Checked Mate- is active For Eneter Regard- ");
		}
		if (LoseOcuuredatChiled <= -1)
		{
			SOut += std::wstring(L" At -LoseKing Checked Mate- is active For Eneter Penelty- ");
		}
		if (AA)
		{
			SOut += std::wstring(L" '-AA-' is Active due to Regard Enter- ");
		}
		if (Do == 1)
		{
			SOut += std::wstring(L" '-Do-' is Active due to Regard Enter- ");
		}
		SOut += std::wstring(L" With Huristic Count ") +StringConverterHelper::toString(AllDraw::Less);
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			OutPut += std::wstring(L"\r\n") + SOut;
		}
		//delay(10);
	}

	void AllDraw::SaveLess(int i, int j, int k, int Kind, double &Less, bool AA, int Order)
	{

		if (Kind == 1)
		{
			Less = SolderesOnTable[i].SoldierThinking[k].ReturnHuristic(i, j, Order, AA);
		}
		else
		{
	if (Kind == 2)
	{
			Less = ElephantOnTable[i].ElefantThinking[k].ReturnHuristic(i, j, Order, AA);
	}
		else
		{
	if (Kind == 3)
	{
			Less = HoursesOnTable[i].HourseThinking[k].ReturnHuristic(i, j, Order, AA);
	}
		else
		{
	if (Kind == 4)
	{
			Less = CastlesOnTable[i].CastleThinking[k].ReturnHuristic(i, j, Order, AA);
	}
		else
		{
	if (Kind == 5)
	{
			Less = MinisterOnTable[i].MinisterThinking[k].ReturnHuristic(i, j, Order, AA);
	}
		else
		{
	if (Kind == 6)
	{
			Less = KingOnTable[i].KingThinking[k].ReturnHuristic(i, j, Order, AA);
	}
		}
		}
		}
		}
		}
	}

	void AllDraw::SaveTableHuristic(int i, int j, int k, int Kind, int **TableHuristic)
	{

		if (Kind == 1)
		{
			TableHuristic = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];
		}
		else
		{
			if (Kind == 2)
			{
			TableHuristic = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
			}
		else
		{
			if (Kind == 3)
			{
			TableHuristic = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];
			}
		else
		{
			if (Kind == 4)
			{
			TableHuristic = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
			}
		else
		{
			if (Kind == 5)
			{
			TableHuristic = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
			}
		else
		{
			if (Kind == 6)
			{
			TableHuristic = KingOnTable[i].KingThinking[k].TableListKing[j];
			}
		}
		}
		}
		}
		}

	}

	void AllDraw::SaveBeginEndLocation(int i, int j, int k, int Kind)
	{
		if (Kind == 1)
		{
			AllDraw::LastRow = SolderesOnTable[i].SoldierThinking[k].Row;
			AllDraw::LastColumn = SolderesOnTable[i].SoldierThinking[k].Column;
			AllDraw::NextRow = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0];
			AllDraw::NextColumn = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1];
		}
		else
		{
			 if (Kind == 2)
			 {
			AllDraw::LastRow = ElephantOnTable[i].ElefantThinking[k].Row;
			AllDraw::LastColumn = ElephantOnTable[i].ElefantThinking[k].Column;
			AllDraw::NextRow = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][0];
			AllDraw::NextColumn = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][1];
			 }
		else
		{
			 if (Kind == 3)
			 {
			AllDraw::LastRow = HoursesOnTable[i].HourseThinking[k].Row;
			AllDraw::LastColumn = HoursesOnTable[i].HourseThinking[k].Column;
			AllDraw::NextRow = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][0];
			AllDraw::NextColumn = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][1];
			 }
		else
		{
			 if (Kind == 4)
			 {
			AllDraw::LastRow = CastlesOnTable[i].CastleThinking[k].Row;
			AllDraw::LastColumn = CastlesOnTable[i].CastleThinking[k].Column;
			AllDraw::NextRow = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][0];
			AllDraw::NextColumn = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][1];
			 }
		else
		{
			 if (Kind == 5)
			 {
			AllDraw::LastRow = MinisterOnTable[i].MinisterThinking[k].Row;
			AllDraw::LastColumn = MinisterOnTable[i].MinisterThinking[k].Column;
			AllDraw::NextRow = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][0];
			AllDraw::NextColumn = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][1];
			 }
		else
		{
			 if (Kind == 6)
			 {
			AllDraw::LastRow = KingOnTable[i].KingThinking[k].Row;
			AllDraw::LastColumn = KingOnTable[i].KingThinking[k].Column;
			AllDraw::NextRow = KingOnTable[i].KingThinking[k].RowColumnKing[j][0];
			AllDraw::NextColumn = KingOnTable[i].KingThinking[k].RowColumnKing[j][1];
			 }
		}
		}
		}
		}
		}
	}

	bool AllDraw::HuristicRegardSection(int i, int j, int k, bool &Act, int **TableHuristic, bool &AA, int a, int Kind, int &Do, int AStarGreedyi, int Order)
	{
		bool continued = false;
		if (Kind == 1)
		{
			if ((SolderesOnTable[i].SoldierThinking[k].PenaltyRegardListSolder[j].IsPenaltyAction() != 0 && SolderesOnTable[i].SoldierThinking[k].PenaltyRegardListSolder[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((((Do == 1 || AA) && UsePenaltyRegardMechnisamT)) && UsePenaltyRegardMechnisamT) || SolderesOnTable[i].WinOcuuredatChiled >= 1 || SolderesOnTable[i].WinOcuuredatChiled >= 2 || SolderesOnTable[i].WinOcuuredatChiled >= 3)
			{
				//Set Table and Huristic Value and Syntax.
				Act = true;
				////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					SaveBeginEndLocation(i, j, k, 1);

					SaveTableHuristic(i, j, k, 1, TableHuristic);

					SaveLess(i, j, k, 1, Less, AA, Order);
				}

				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					ThingsConverter::ActOfClickEqualTow = true;
				}

				SolderesOnTable[i].ConvertOperation(SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0], SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1], a, SolderesOnTable[i].SoldierThinking[k].TableListSolder[j], Order, false, i);

				int Sign = 1;
				if (a == -1)
				{
					Sign = -1;
				}


				//If there is Soldier Convert.
				if (SolderesOnTable[i].Convert)
				{

					if (SolderesOnTable[i].ConvertedToMinister)
					{
						TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 5 * Sign;
					}
					else if (SolderesOnTable[i].ConvertedToCastle)
					{
						TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 4 * Sign;
					}
					else if (SolderesOnTable[i].ConvertedToHourse)
					{
						TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 3 * Sign;
					}
					else if (SolderesOnTable[i].ConvertedToElefant)
					{
						TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 2 * Sign;
					}

				}

				RegardOccurred = true;

				StringHuristics(1, 2, AA, Do, SolderesOnTable[i].WinOcuuredatChiled, SolderesOnTable[i].LoseOcuuredatChiled);

				continued = true;
			}

		}
		else
		{
		if (Kind == 2)
		{
			if ((ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsPenaltyAction() != 0 && ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT) || ElephantOnTable[i].WinOcuuredatChiled >= 1 || ElephantOnTable[i].WinOcuuredatChiled >= 2 || ElephantOnTable[i].WinOcuuredatChiled >= 3)
			{

				////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					SaveBeginEndLocation(i, j, k, 2);

					SaveTableHuristic(i, j, k, 2, TableHuristic);

					SaveLess(i, j, k, 2, Less, AA, Order);
				}

				StringHuristics(2, 2, AA, Do, ElephantOnTable[i].WinOcuuredatChiled, ElephantOnTable[i].LoseOcuuredatChiled);

				RegardOccurred = true;

				continued = true;

			}
		}
		else
		{
		if (Kind == 3)
		{
			if ((HoursesOnTable[i].HourseThinking[k].PenaltyRegardListHourse[j].IsPenaltyAction() != 0 && HoursesOnTable[i].HourseThinking[k].PenaltyRegardListHourse[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT) || HoursesOnTable[i].WinOcuuredatChiled >= 1 || HoursesOnTable[i].WinOcuuredatChiled >= 2 || HoursesOnTable[i].WinOcuuredatChiled >= 3)
			{
				////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					SaveBeginEndLocation(i, j, k, 3);

					SaveTableHuristic(i, j, k, 3, TableHuristic);

					SaveLess(i, j, k, 3, Less, AA, Order);
				}

				RegardOccurred = true;

				StringHuristics(3, 2, AA, Do, HoursesOnTable[i].WinOcuuredatChiled, HoursesOnTable[i].LoseOcuuredatChiled);

				continued = true;

			}

		}
		else
		{
		if (Kind == 4)
		{
			if ((CastlesOnTable[i].CastleThinking[k].PenaltyRegardListCastle[j].IsPenaltyAction() != 0 && CastlesOnTable[i].CastleThinking[k].PenaltyRegardListCastle[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT) || CastlesOnTable[i].WinOcuuredatChiled >= 1 || CastlesOnTable[i].WinOcuuredatChiled >= 2 || CastlesOnTable[i].WinOcuuredatChiled >= 3)
			{

				////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					SaveBeginEndLocation(i, j, k, 4);

					SaveTableHuristic(i, j, k, 4, TableHuristic);

					SaveLess(i, j, k, 4, Less, AA, Order);
				}

				RegardOccurred = true;
				StringHuristics(4, 2, AA, Do, CastlesOnTable[i].WinOcuuredatChiled, CastlesOnTable[i].LoseOcuuredatChiled);
				//if (CastlesOnTable[i].WinOcuuredatChiled >= 1 || CastlesOnTable[i].WinOcuuredatChiled >= 2 || CastlesOnTable[i].WinOcuuredatChiled >= 3)
				//Less = double.MaxValue;



				//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
				//return TableHuristic;
				continued = true;
			}
		}
		else
		{
			if (Kind == 5)
			{
			if ((MinisterOnTable[i].MinisterThinking[k].PenaltyRegardListMinister[j].IsPenaltyAction() != 0 && MinisterOnTable[i].MinisterThinking[k].PenaltyRegardListMinister[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT) || MinisterOnTable[i].WinOcuuredatChiled >= 1 || MinisterOnTable[i].WinOcuuredatChiled >= 2 || MinisterOnTable[i].WinOcuuredatChiled >= 3)
			{

				////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					SaveBeginEndLocation(i, j, k, 5);

					SaveTableHuristic(i, j, k, 5, TableHuristic);

					SaveLess(i, j, k, 5, Less, AA, Order);
				}

				TableHuristic = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
				RegardOccurred = true;
				StringHuristics(5, 2, AA, Do, MinisterOnTable[i].WinOcuuredatChiled, MinisterOnTable[i].LoseOcuuredatChiled);

				continued = true;
			}
			}
		else
		{
		if (Kind == 6)
		{
			if ((KingOnTable[i].KingThinking[k].PenaltyRegardListKing[j].IsPenaltyAction() != 0 && KingOnTable[i].KingThinking[k].PenaltyRegardListKing[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT) || KingOnTable[i].WinOcuuredatChiled >= 1 || KingOnTable[i].WinOcuuredatChiled >= 2 || KingOnTable[i].WinOcuuredatChiled >= 3)
			{
				////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					SaveBeginEndLocation(i, j, k, 6);

					SaveTableHuristic(i, j, k, 6, TableHuristic);

					SaveLess(i, j, k, 6, Less, AA, Order);
				}

				RegardOccurred = true;
				StringHuristics(6, 2, AA, Do, KingOnTable[i].WinOcuuredatChiled, KingOnTable[i].LoseOcuuredatChiled);

				//if (KingOnTable[i].WinOcuuredatChiled >= 1 || KingOnTable[i].WinOcuuredatChiled >= 2 || KingOnTable[i].WinOcuuredatChiled >= 3)
				// Less = double.MaxValue;



				//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
				//return TableHuristic;
				continued = true;
			}
		}
		}
		}
		}
		}
		}
		return continued;
	}

	void AllDraw::InitiateVars(int i, int j, int k, int Kind)
	{
		RW1 = -1;
		CL1 = -1;
		Ki1 = -1;
		RW2 = -1;
		CL2 = -1;
		Ki2 = -1;
		RW3 = -1;
		CL3 = -1;
		Ki3 = -1;
		RW4 = -1;
		CL4 = -1;
		Ki4 = -1;
		RW5 = -1;
		CL5 = -1;
		Ki5 = -1;
		RW6 = -1;
		CL6 = -1;
		Ki6 = -1;
		//Sodleirs Initiate.
		if (Kind == 1)
		{
			RW1 = i;
			CL1 = k;
			Ki1 = j;
		}
		else
		{
			if (Kind == 2)
			{
			RW2 = i;
			CL2 = k;
			Ki2 = j;
			}
		else
		{
			if (Kind == 3)
			{
			RW3 = i;
			CL3 = k;
			Ki3 = j;
			}
		else
		{
			if (Kind == 4)
			{
			RW4 = i;
			CL4 = k;
			Ki4 = j;
			}
		else
		{
			if (Kind == 5)
			{
			RW5 = i;
			CL5 = k;
			Ki5 = j;
			}
		else
		{
			if (Kind == 6)
			{
			RW6 = i;
			CL6 = k;
			Ki6 = j;
			}
		}
		}
		}
		}
		}
	}

	bool AllDraw::CheckeHuristci(int **TableS, int Order, int i, int j, int k)
	{
		bool continued = false;
		ChessRules *AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, TableS, Order, SolderesOnTable[i].SoldierThinking[k].Row, SolderesOnTable[i].SoldierThinking[k].Column);
		//If there is kish or kshachamaz Order.
		if (AB->Check(TableS, Order))
		{
			//When Order is Gray.
			if (Order == 1)
			{
				//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
				if (AB->CheckGray)
				{
					continued = true;
				}
			}
			else
			{
				//Continue when CheckBrown and AStarGreadyFirstSearch. 
				if (AB->CheckBrown)
				{
					continued = true;
				}
			}
		}
		return continued;
	}

	void AllDraw::OutputHuristic(int Order)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nChess Huristic Elephant By Bob!");
				//RefreshBoxText();
			}
			else //If Order is Brown.
			{
				OutPut += std::wstring(L"\r\nChess Huristic Elephant By Alice!");
				//RefreshBoxText();
			}
		}
	}

	bool AllDraw::HuristicMainBody(int i, int j, int k, bool &Act, int **TableHuristic, bool &CurrentTableHuristic, bool &AA, int a, int Kind, int &Do, int AStarGreedyi, int Order)
	{
		bool continued = false;

		if (Kind == 1)
		{
			if (SolderesOnTable[i].SoldierThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
			{

				////auto O11 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O11)
				{
					//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
					//ORIGINAL LINE: int[,] TableS = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];
					int **TableS = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];

					//checked for Legal Movments ArgumentOutOfRangeException curnt game.
					if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
					{

						if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
						{
							if (Order == 1)
							{
								AllDraw::OutPut += std::wstring(L"\r\nHuristic Soldier By Bob was not Valid Movment!");
							}
							else
							{
								AllDraw::OutPut += std::wstring(L"\r\nHuristic Soldier By Alice was not Valid Movment!");
							}

							return true;
						}


					}
					//When there is not Penalty regard mechanism.
					if (CheckeHuristci(TableS, Order, i, j, k))
					{
						return true;
					}


					InitiateVars(i, j, k, 1);

					//Set Max of Soldier.
					MaxLess1 = SolderesOnTable[RW1].SoldierThinking[CL1].ReturnHuristic(i, j, Order, AA);

					//When Soldeirs is Greater than Others these Set Max.
					if (MaxLess1 > MaxLess2)
					{
						MaxLess2 = -1;
					}
					if (MaxLess1 > MaxLess3)
					{
						MaxLess3 = -1;
					}
					if (MaxLess1 > MaxLess4)
					{
						MaxLess4 = -1;
					}
					if (MaxLess1 > MaxLess5)
					{
						MaxLess5 = -1;
					}
					if (MaxLess1 > MaxLess6)
					{
						MaxLess6 = -1;
					}

					if (AStarGreedyi == 1)
					{
						OutputHuristic(Order);

						//Set Table and Huristic Value and Syntax.
						Act = true;
						////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (On)
						{
							SaveBeginEndLocation(i, j, k, 1);

							SaveTableHuristic(i, j, k, 1, TableHuristic);

							SaveLess(i, j, k, 1, Less, AA, Order);
						}

						StringHuristics(1, 3, AA, Do, SolderesOnTable[i].WinOcuuredatChiled, SolderesOnTable[i].LoseOcuuredatChiled);



						////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{
							ThingsConverter::ActOfClickEqualTow = true;
						}
						SolderesOnTable[i].ConvertOperation(SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0], SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1], a, SolderesOnTable[i].SoldierThinking[k].TableListSolder[j], Order, false, i);
						int Sign = 1;
						if (a == -1)
						{
							Sign = -1;
						}
						//If there is Soldier Convert.
						if (SolderesOnTable[i].Convert)
						{

							if (SolderesOnTable[i].ConvertedToMinister)
							{
								TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 5 * Sign;
							}
							else if (SolderesOnTable[i].ConvertedToCastle)
							{
								TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 4 * Sign;
							}
							else if (SolderesOnTable[i].ConvertedToHourse)
							{
								TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 3 * Sign;
							}
							else if (SolderesOnTable[i].ConvertedToElefant)
							{
								TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 2 * Sign;
							}

						}
					}
				}
			}
		}
		else if (Kind == 2)
		{
			if (ElephantOnTable[i].ElefantThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
			{

				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					//ActionString = ThinkingChess::ActionsString; AllDraw.ActionStringReady = true;
				}
				//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
				int **TableS = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
				//checked for Legal Movments ArgumentOutOfRangeException curnt game.
				if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
				{

					if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
					{
						if (Order == 1)
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Elephant By Bob was not Valid Movment!");
						}
						else
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Elephant By Alice was not Valid Movment!");
						}

						return true;
					}



				}
				//When there is not Penalty regard mechanism.
				if (CheckeHuristci(TableS, Order, i, j, k))
				{
					return true;
				}


				InitiateVars(i, j, k, 2);

				MaxLess2 = (ElephantOnTable[RW2].ElefantThinking[CL2].ReturnHuristic(RW2, Ki2, Order, false));

				if (MaxLess2 > MaxLess1)
				{
					MaxLess1 = -1;
				}
				if (MaxLess2 > MaxLess3)
				{
					MaxLess3 = -1;
				}
				if (MaxLess2 > MaxLess4)
				{
					MaxLess4 = -1;
				}
				if (MaxLess2 > MaxLess5)
				{
					MaxLess5 = -1;
				}
				if (MaxLess2 > MaxLess6)
				{
					MaxLess6 = -1;
				}

				if (AStarGreedyi == 1)
				{
					OutputHuristic(Order);

					//Set Table and Huristic Value and Syntax.

					////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (On)
					{
						SaveBeginEndLocation(i, j, k, 2);

						SaveTableHuristic(i, j, k, 2, TableHuristic);

						SaveLess(i, j, k, 2, Less, AA, Order);
					}
					Act = true;

					StringHuristics(2, 3, AA, Do, ElephantOnTable[i].WinOcuuredatChiled, ElephantOnTable[i].LoseOcuuredatChiled);


				}
			}
		}
		else if (Kind == 3)
		{
			if (HoursesOnTable[i].HourseThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					//ActionString = ThinkingChess::ActionsString; AllDraw.ActionStringReady = true;
				}
				//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];
				int **TableS = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];

				//checked for Legal Movments ArgumentOutOfRangeException curnt game.
				if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
				{

					if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
					{
						if (Order == 1)
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Hourse By Bob was not Valid Movment!");
						}
						else
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Hourse By Alice was not Valid Movment!");
						}

						return true;
					}


				}
				//When there is not Penalty regard mechanism.
				if (CheckeHuristci(TableS, Order, i, j, k))
				{
					return true;
				}

				InitiateVars(i, j, k, 3);


				MaxLess3 = (HoursesOnTable[RW3].HourseThinking[CL3].ReturnHuristic(RW3, Ki3, Order, false));
				if (MaxLess3 > MaxLess1)
				{
					MaxLess1 = -1;
				}
				if (MaxLess3 > MaxLess2)
				{
					MaxLess2 = -1;
				}
				if (MaxLess3 > MaxLess4)
				{
					MaxLess4 = -1;
				}
				if (MaxLess3 > MaxLess5)
				{
					MaxLess5 = -1;
				}
				if (MaxLess3 > MaxLess6)
				{
					MaxLess6 = -1;
				}

				if (AStarGreedyi == 1)
				{
					OutputHuristic(Order);

					//Set Table and Huristic Value and Syntax.
					////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (On)
					{
						SaveBeginEndLocation(i, j, k, 3);

						SaveTableHuristic(i, j, k, 3, TableHuristic);

						SaveLess(i, j, k, 3, Less, AA, Order);
					}

					Act = true;

					StringHuristics(3, 3, AA, Do, HoursesOnTable[i].WinOcuuredatChiled, HoursesOnTable[i].LoseOcuuredatChiled);
				}

			}

		}
		else if (Kind == 4)
		{
			if (CastlesOnTable[i].CastleThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					//ActionString = ThinkingChess::ActionsString; AllDraw.ActionStringReady = true;
				}
				//retrive Table of current huristic.

				//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
				int **TableS = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
				//checked for Legal Movments ArgumentOutOfRangeException curnt game.
				if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
				{

					if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
					{
						if (Order == 1)
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Castle By Bob was not Valid Movment!");
						}
						else
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Castle By Alice was not Valid Movment!");
						}

						return true;
					}



				}
				//When there is not Penalty regard mechanism.
				if (CheckeHuristci(TableS, Order, i, j, k))
				{
					return true;
				}


				InitiateVars(i, j, k, 4);

				MaxLess4 = (CastlesOnTable[RW4].CastleThinking[CL4].ReturnHuristic(RW4, Ki4, Order, false));
				if (MaxLess4 > MaxLess1)
				{
					MaxLess1 = -1;
				}
				if (MaxLess4 > MaxLess2)
				{
					MaxLess2 = -1;
				}
				if (MaxLess4 > MaxLess3)
				{
					MaxLess3 = -1;
				}
				if (MaxLess4 > MaxLess5)
				{
					MaxLess5 = -1;
				}
				if (MaxLess4 > MaxLess6)
				{
					MaxLess6 = -1;
				}


				if (AStarGreedyi == 1)
				{
					OutputHuristic(Order);

					//Set Table and Huristic Value and Syntax.

					////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (On)
					{
						SaveBeginEndLocation(i, j, k, 4);

						SaveTableHuristic(i, j, k, 4, TableHuristic);

						SaveLess(i, j, k, 4, Less, AA, Order);
					}

					Act = true;
					StringHuristics(4, 3, AA, Do, CastlesOnTable[i].WinOcuuredatChiled, CastlesOnTable[i].LoseOcuuredatChiled);
				}
			}
			else //Set Table and Huristic Value and Syntax.
			{
			}
		}
		else if (Kind == 5)
		{
			if (MinisterOnTable[i].MinisterThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					//ActionString = ThinkingChess::ActionsString; AllDraw.ActionStringReady = true;
				}
				//retrive Table of current huristic.

				//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
				int **TableS = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
				//checked for Legal Movments ArgumentOutOfRangeException curnt game.
				if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
				{

					if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
					{
						if (Order == 1)
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Minister By Bob was not Valid Movment!");
						}
						else
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic Minister By Alice was not Valid Movment!");
						}

						return true;
					}

				}

				//When there is not Penalty regard mechanism.
				if (CheckeHuristci(TableS, Order, i, j, k))
				{
					return true;
				}



				InitiateVars(i, j, k, 5);


				MaxLess5 = (MinisterOnTable[RW5].MinisterThinking[CL5].ReturnHuristic(RW5, Ki5, Order, false));
				if (MaxLess5 > MaxLess1)
				{
					MaxLess1 = -1;
				}
				if (MaxLess5 > MaxLess2)
				{
					MaxLess2 = -1;
				}
				if (MaxLess5 > MaxLess3)
				{
					MaxLess3 = -1;
				}
				if (MaxLess5 > MaxLess4)
				{
					MaxLess4 = -1;
				}
				if (MaxLess5 > MaxLess6)
				{
					MaxLess6 = -1;
				}


				if (AStarGreedyi == 1)
				{
					OutputHuristic(Order);

					//Set Table and Huristic Value and Syntax.

					////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (On)
					{
						SaveBeginEndLocation(i, j, k, 5);

						SaveTableHuristic(i, j, k, 5, TableHuristic);

						SaveLess(i, j, k, 5, Less, AA, Order);
					}

					Act = true;

					StringHuristics(5, 3, AA, Do, MinisterOnTable[i].WinOcuuredatChiled, MinisterOnTable[i].LoseOcuuredatChiled);
				}
			}

		}
		else if (Kind == 6)
		{
			if (KingOnTable[i].KingThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
			{
				////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (OO)
				{
					//ActionString = ThinkingChess::ActionsString; AllDraw.ActionStringReady = true;
				}
				//retrive Table of current huristic.

				//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = KingOnTable[i].KingThinking[k].TableListKing[j];
				int **TableS = KingOnTable[i].KingThinking[k].TableListKing[j];

				//checked for Legal Movments ArgumentOutOfRangeException curnt game.
				if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
				{

					if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
					{
						if (Order == 1)
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic King By Bob was not Valid Movment!");
						}
						else
						{
							AllDraw::OutPut += std::wstring(L"\r\nHuristic King By Alice was not Valid Movment!");
						}

						return true;
					}

				}
				//When there is not Penalty regard mechanism.

				if (CheckeHuristci(TableS, Order, i, j, k))
				{
					return true;
				}

				InitiateVars(i, j, k, 6);


				MaxLess6 = (KingOnTable[RW6].KingThinking[CL6].ReturnHuristic(RW6, Ki6, Order, false));
				if (MaxLess6 > MaxLess1)
				{
					MaxLess1 = -1;
				}
				if (MaxLess6 > MaxLess2)
				{
					MaxLess2 = -1;
				}
				if (MaxLess6 > MaxLess3)
				{
					MaxLess3 = -1;
				}
				if (MaxLess6 > MaxLess4)
				{
					MaxLess4 = -1;
				}
				if (MaxLess6 > MaxLess5)
				{
					MaxLess5 = -1;
				}


				if (AStarGreedyi == 1)
				{
					OutputHuristic(Order);

					//Set Table and Huristic Value and Syntax.

					////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (On)
					{
						SaveBeginEndLocation(i, j, k, 6);

						SaveTableHuristic(i, j, k, 6, TableHuristic);

						SaveLess(i, j, k, 6, Less, AA, Order);
					}

					Act = true;

					StringHuristics(6, 3, AA, Do, KingOnTable[i].WinOcuuredatChiled, KingOnTable[i].LoseOcuuredatChiled);
				}


			}
			else //Set Table and Huristic Value and Syntax.
			{
			}
		}
		return continued;
	}

	int **AllDraw::HuristicAStarGreadySearchSoldier(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{


		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{
			//ChessRules AB = null;

			int j;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;



			//For Every Soldier Movments AStarGreedy.
			for (int k = 0; k < AllDraw::SodierMovments; k++)
			{
				//When There is an Movment in such situation.
				
					for (j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
					{
						{
						//System.Threading.Thread.Sleep(2);
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if (SolderesOnTable[i].SoldierThinking[k].PenaltyRegardListSolder[j].IsPenaltyAction() == 0)
								{
									continue;
								}
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									if (SolderesOnTable[i].SoldierThinking[k].AStarGreedy.size() > j)
									{
										SolderesOnTable[i].SoldierThinking[k].AStarGreedy[j].IsFoundOfLeafDepenOfKindhaveVictory(1, AA, Order * -1);
									}
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;

							
								StringHuristics(1, 1, AA, Do, SolderesOnTable[i].WinOcuuredatChiled, SolderesOnTable[i].LoseOcuuredatChiled);

								if (SolderesOnTable[i].LoseOcuuredatChiled <= -1 || SolderesOnTable[i].LoseOcuuredatChiled <= -2 || SolderesOnTable[i].LoseOcuuredatChiled <= -3)
								{
									continue;
								}

								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)


								if (HuristicRegardSection(i, j, k, Act, TableHuristic, AA, a, 1, Do, AStarGreedyi, Order))
								{
									continue;
								}
								//When There is No Movments in Such Order Enemy continue.
								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									if (Order != AllDraw::OrderPlate)
									{
										if (SolderesOnTable[i].SoldierThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.

									if (HuristicMainBody(i, j, k, Act, TableHuristic, CurrentTableHuristic, AA, a, 1, Do, AStarGreedyi, Order))
									{
										continue;
									}

								}
						
						}
					}

			
			}
			
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
		

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchSoldierGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{

		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{

			if (SodierMidle != 0)
			{
				for (int i = 0; i < SodierMidle; i++)
				{
					TableHuristic = HuristicAStarGreadySearchSoldier(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchSoldierBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{
			if (SodierMidle != SodierHigh)
			{

				for (int i = SodierMidle; i < SodierHigh; i++)
				{
					TableHuristic = HuristicAStarGreadySearchSoldier(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}

			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchElephantGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{

		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{
			if (0 != ElefantMidle)
			{
				//Do For Remaining Objects same as Soldeir Documentation.
				for (int i = 0; i < ElefantMidle; i++)
				{
					TableHuristic = HuristicAStarGreadySearchElephant(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchElephantBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{

			if (ElefantHigh != ElefantMidle)
			{
				//Do For Remaining Objects same as Soldeir Documentation.
				for (int i = ElefantMidle; i < ElefantHigh; i++)
				{
					TableHuristic = HuristicAStarGreadySearchElephant(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchElephant(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{

			//ChessRules AB = null;

			int j;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;

			for (int k = 0; k < AllDraw::ElefantMovments; k++)
			{
				
					for (j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
					{
						{
						//System.Threading.Thread.Sleep(2);
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if (ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsPenaltyAction() == 0)
								{
									continue;
								}
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() > j)
									{
										ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j].IsFoundOfLeafDepenOfKindhaveVictory(2, AA, Order * -1);
									}
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;

							
								StringHuristics(2, 1, AA, Do, ElephantOnTable[i].WinOcuuredatChiled, ElephantOnTable[i].LoseOcuuredatChiled);
								if (ElephantOnTable[i].LoseOcuuredatChiled <= -1 || ElephantOnTable[i].LoseOcuuredatChiled <= -2 || ElephantOnTable[i].LoseOcuuredatChiled <= -3)
								{
									continue;
								}
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)


								if (HuristicRegardSection(i, j, k, Act, TableHuristic, AA, a, 2, Do, AStarGreedyi, Order))
								{
									continue;
								}


								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{

									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (ElephantOnTable[i].ElefantThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (HuristicMainBody(i, j, k, Act, TableHuristic, CurrentTableHuristic, AA, a, 2, Do, AStarGreedyi, Order))
									{
										continue;
									}



								}
						

						}

					}
			
			}
			
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
		

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return TableHuristic;
		}


	}

	int **AllDraw::HuristicAStarGreadySearchHourseGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{

		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{
			if (0 != HourseMidle)
			{
				//For Every Soldeir
				for (int i = 0; i < HourseMidle; i++)
				{
					TableHuristic = HuristicAStarGreadySearchHourse(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}

			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchHourseBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{

			if (HourseHight != HourseMidle)
			{
				//For Every Soldeir
				for (int i = HourseMidle; i < HourseHight; i++)
				{
					TableHuristic = HuristicAStarGreadySearchHourse(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchHourse(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto a1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (a1)
		{

			//ChessRules AB = null;

			int j;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;


			for (int k = 0; k < AllDraw::HourseMovments; k++)
			{
				
					for (j = 0; ((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && ((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && ((&HoursesOnTable[i].HourseThinking[k]) != nullptr) && ((&HoursesOnTable[i].HourseThinking[k]) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
					{
						{
						//System.Threading.Thread.Sleep(2);
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if (HoursesOnTable[i].HourseThinking[k].PenaltyRegardListHourse[j].IsPenaltyAction() == 0)
								{
									continue;
								}
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() > j)
									{
										HoursesOnTable[i].HourseThinking[0].AStarGreedy[j].IsFoundOfLeafDepenOfKindhaveVictory(3, AA, Order * -1);
									}
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
							
								StringHuristics(3, 1, AA, Do, HoursesOnTable[i].WinOcuuredatChiled, HoursesOnTable[i].LoseOcuuredatChiled);

								if (HoursesOnTable[i].LoseOcuuredatChiled <= -1 || HoursesOnTable[i].LoseOcuuredatChiled <= -2 || HoursesOnTable[i].LoseOcuuredatChiled <= -3)
								{
									continue;
								}


								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)

								if (HuristicRegardSection(i, j, k, Act, TableHuristic, AA, a, 3, Do, AStarGreedyi, Order))
								{
									continue;
								}

								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{

									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (HoursesOnTable[i].HourseThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (HuristicMainBody(i, j, k, Act, TableHuristic, CurrentTableHuristic, AA, a, 3, Do, AStarGreedyi, Order))
									{
										continue;
									}


								}
						
						}
						{
						// else
						}


					}
			
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchCastleGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			if (0 != HourseMidle)
			{
				for (int i = 0; i < CastleMidle; i++)
				{
					TableHuristic = HuristicAStarGreadySearchCastle(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchCastleBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{

		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{


			if (CastleMidle != CastleHigh)
			{
				for (int i = CastleMidle; i < CastleHigh; i++)
				{
					TableHuristic = HuristicAStarGreadySearchCastle(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}

			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchCastle(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{


			//ChessRules AB = null;

			int j;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;

			for (int k = 0; k < AllDraw::CastleMovments; k++)
			{
				
					for (j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
					{
						{
						//System.Threading.Thread.Sleep(2);
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if (CastlesOnTable[i].CastleThinking[k].PenaltyRegardListCastle[j].IsPenaltyAction() == 0)
								{
									continue;
								}
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() > j)
									{
										CastlesOnTable[i].CastleThinking[0].AStarGreedy[j].IsFoundOfLeafDepenOfKindhaveVictory(4, AA, Order * -1);
									}
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
							
								Order = COrder;
								StringHuristics(4, 1, AA, Do, CastlesOnTable[i].WinOcuuredatChiled, CastlesOnTable[i].LoseOcuuredatChiled);

								if (CastlesOnTable[i].LoseOcuuredatChiled <= -1 || CastlesOnTable[i].LoseOcuuredatChiled <= -2 || CastlesOnTable[i].LoseOcuuredatChiled <= -3)
								{
									continue;
								}
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)


								if (HuristicRegardSection(i, j, k, Act, TableHuristic, AA, a, 4, Do, AStarGreedyi, Order))
								{
									continue;
								}


								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (CastlesOnTable[i].CastleThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (HuristicMainBody(i, j, k, Act, TableHuristic, CurrentTableHuristic, AA, a, 4, Do, AStarGreedyi, Order))
									{
										continue;
									}

								}
						
						}
					}
			
			}
			
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
		

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchMinsisterGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			if (0 != MinisterMidle)
			{
				for (int i = 0; i < MinisterMidle; i++)
				{
					TableHuristic = HuristicAStarGreadySearchMinsister(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}

			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}

	}

	int **AllDraw::HuristicAStarGreadySearchMinsisterBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			if (MinisterHigh != MinisterMidle)
			{
				for (int i = MinisterMidle; i < MinisterHigh; i++)
				{
					TableHuristic = HuristicAStarGreadySearchMinsister(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}

			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchMinsister(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O3)
		{

			//ChessRules AB = null;

			int j;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;

			for (int k = 0; k < AllDraw::MinisterMovments; k++)
			{
				
					for (j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && ((&MinisterOnTable[i].MinisterThinking[k]) != nullptr)&& ((&MinisterOnTable[i].MinisterThinking[k]) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[k].TableListMinister.size()); j++)
					{
						{
						//System.Threading.Thread.Sleep(2);
							//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
							//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
							//)
							if (MinisterOnTable[i].MinisterThinking[k].PenaltyRegardListMinister[j].IsPenaltyAction() == 0)
							{
								continue;
							}
							int CDummy = ChessRules::CurrentOrder;
							int COrder = Order;
							
								if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() > j)
								{
									MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j].IsFoundOfLeafDepenOfKindhaveVictory(5, AA, Order * -1);
								}
								ChessRules::CurrentOrder *= -1;
								Order *= -1;
								Do = 0;
						
							StringHuristics(5, 1, AA, Do, MinisterOnTable[i].WinOcuuredatChiled, MinisterOnTable[i].LoseOcuuredatChiled);

							if (MinisterOnTable[i].LoseOcuuredatChiled <= -1 || MinisterOnTable[i].LoseOcuuredatChiled <= -2 || MinisterOnTable[i].LoseOcuuredatChiled <= -3)
							{
								continue;
							}
							Order = COrder;
							ChessRules::CurrentOrder = CDummy;
							//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
							//)


							if (HuristicRegardSection(i, j, k, Act, TableHuristic, AA, a, 5, Do, AStarGreedyi, Order))
							{
								continue;
							}

							////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (ol)
							{
								if (Order != AllDraw::OrderPlate)
								{
									if (MinisterOnTable[i].MinisterThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
									{
										continue;
									}
								}
								if (HuristicMainBody(i, j, k, Act, TableHuristic, CurrentTableHuristic, AA, a, 5, Do, AStarGreedyi, Order))
								{
									continue;
								}

							}
						}
					}
			
			}
			
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
		

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchKingGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			if (0 != KingMidle)
			{
				for (int i = 0; i < KingMidle; i++)
				{
					TableHuristic = HuristicAStarGreadySearchKing(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchKingBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			if (KingHigh != KingMidle)
			{
				for (int i = KingMidle; i < KingHigh; i++)
				{
					TableHuristic = HuristicAStarGreadySearchKing(TableHuristic, i, AStarGreedyi, a, Order, CurrentTableHuristic, Act);
				}
			}
			else
			{
				//CodeClass::SaveByCode(1, callStack->GetFileLineNumber(), callStack->GetFileName());
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchKing(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			//ChessRules AB = null;

			int j;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;

			for (int k = 0; k < AllDraw::KingMovments; k++)
			{
				
					for (j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[k].TableListKing.size()); j++)
					{
						{
						//System.Threading.Thread.Sleep(2);
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if (KingOnTable[i].KingThinking[k].PenaltyRegardListKing[j].IsPenaltyAction() == 0)
								{
									continue;
								}
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									if (KingOnTable[i].KingThinking[0].AStarGreedy.size() > j)
									{
										KingOnTable[i].KingThinking[0].AStarGreedy[j].IsFoundOfLeafDepenOfKindhaveVictory(6, AA, Order * -1);
									}
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
							
								StringHuristics(6, 1, AA, Do, KingOnTable[i].WinOcuuredatChiled, KingOnTable[i].LoseOcuuredatChiled);

								if (KingOnTable[i].LoseOcuuredatChiled <= -1 || KingOnTable[i].LoseOcuuredatChiled <= -2 || KingOnTable[i].LoseOcuuredatChiled <= -3)
								{
									continue;
								}
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)


								if (HuristicRegardSection(i, j, k, Act, TableHuristic, AA, a, 6, Do, AStarGreedyi, Order))
								{
									continue;
								}

								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (KingOnTable[i].KingThinking[0].ReturnHuristic(i, j, Order, AA) > Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (HuristicMainBody(i, j, k, Act, TableHuristic, CurrentTableHuristic, AA, a, 6, Do, AStarGreedyi, Order))
									{
										continue;
									}

								}
						
						}
						{
						// else
						}

					}
			
			}
			
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
		

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchGray(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			int **TableHuristic = new int*[8]; for (int g = 0; g < 8; g++)TableHuristic[g] = new int[8];

			TableHuristic = HuristicAStarGreadySearchSoldierGray(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			TableHuristic = HuristicAStarGreadySearchElephantGray(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);


			TableHuristic = HuristicAStarGreadySearchHourseGray(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);


			TableHuristic = HuristicAStarGreadySearchCastleGray(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			TableHuristic = HuristicAStarGreadySearchMinsisterGray(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			TableHuristic = HuristicAStarGreadySearchKingGray(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreadySearchBrown(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{

		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			int **TableHuristic = new int*[8]; for (int g = 0; g < 8; g++)TableHuristic[g] = new int[8];
			
			TableHuristic = HuristicAStarGreadySearchSoldierBrown(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			TableHuristic = HuristicAStarGreadySearchElephantBrown(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);


			TableHuristic = HuristicAStarGreadySearchHourseBrown(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);


			TableHuristic = HuristicAStarGreadySearchCastleBrown(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			TableHuristic = HuristicAStarGreadySearchMinsisterBrown(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			TableHuristic = HuristicAStarGreadySearchKingBrown(TableHuristic, AStarGreedyi, a, Order, CurrentTableHuristic, Act);

			return TableHuristic;
		}
	}

	int **AllDraw::BrownHuristicAStarGreaedySearchPenalites(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool &Act)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			ChessRules *AB = nullptr;

			int ToCheckMate = -1, ForCheckMate = -1, j, i;
			std::vector<double> Founded = std::vector<double>();
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			bool AA = false;
			int Do = 0;
			int **TableHuristic = new int*[8]; for (int g = 0; g < 8; g++)TableHuristic[g] = new int[8];
			//For Every Soldeir
			for (i = SodierMidle; i < SodierHigh; i++)
			{

				//For Every Soldier Movments AStarGreedy.
				for (int k = 0; k < AllDraw::SodierMovments; k++)
				{
					//When There is an Movment in such situation.
					
						for (j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (&(SolderesOnTable[i].SoldierThinking) != nullptr) && (j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size()); j++)
						{
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								////if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT)
								//  if (SolderesOnTable[i].SoldierThinking[k].PenaltyRegardListSolder[j].IsPenaltyAction() == 0)
								//      continue;
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
									if (UsePenaltyRegardMechnisamT)
									{
										for (int ij = 0; ij < SolderesOnTable[i].SoldierThinking[k].AStarGreedy.size() - 1; ij++)
										{
											SolderesOnTable[i].SoldierThinking[k].AStarGreedy[ij].IsPenaltyRegardCheckMateAtBranch(Order, Do, SolderesOnTable[i].SoldierThinking[k].AStarGreedy[ij]);
										}
										Order = COrder;
										ChessRules::CurrentOrder = CDummy;
										ToCheckMate = -1;
										ForCheckMate = -1;
										AA = IsToCheckMateHasLessDeeperThanForCheckMate( Order, ToCheckMate, ForCheckMate, 0);
										if (Do == -1)
										{
											continue;
										}
									}

							
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;

								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if ((SolderesOnTable[i].SoldierThinking[k].PenaltyRegardListSolder[j].IsPenaltyAction() != 0 && SolderesOnTable[i].SoldierThinking[k].PenaltyRegardListSolder[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT))
								{
									//Set Table and Huristic Value and Syntax.
									Act = true;
									////auto o1l = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (o1l)
									{

										AllDraw::LastRow = SolderesOnTable[i].SoldierThinking[k].Row;
										AllDraw::LastColumn = SolderesOnTable[i].SoldierThinking[k].Column;
										AllDraw::NextRow = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0];
										AllDraw::NextColumn = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1];

										Less = SolderesOnTable[i].SoldierThinking[k].NumberOfPenalties;
									}


									TableHuristic = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];


									////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OO)
									{
										ThingsConverter::ActOfClickEqualTow = true;
									}
									SolderesOnTable[i].ConvertOperation(SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0], SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1], a, SolderesOnTable[i].SoldierThinking[k].TableListSolder[j], Order, false, i);
									int Sign = 1;
									if (a == -1)
									{
										Sign = -1;
									}
									//If there is Soldier Convert.
									if (SolderesOnTable[i].Convert)
									{

										if (SolderesOnTable[i].ConvertedToMinister)
										{
											TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 5 * Sign;
										}
										else if (SolderesOnTable[i].ConvertedToCastle)
										{
											TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 4 * Sign;
										}
										else if (SolderesOnTable[i].ConvertedToHourse)
										{
											TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 3 * Sign;
										}
										else if (SolderesOnTable[i].ConvertedToElefant)
										{
											TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 2 * Sign;
										}




										RegardOccurred = true;
										//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
										//return TableHuristic;
										continue;
									}

								}
								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (SolderesOnTable[i].SoldierThinking[0].NumberOfPenalties < Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (SolderesOnTable[i].SoldierThinking[0].NumberOfPenalties < Less)
									{

										//retrive Table of current huristic.

										//if (CheckG || CheckB)
										//{
										//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];
										int **TableS = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];

										//checked for Legal Movments ArgumentOutOfRangeException curnt game.
										if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
										{
											
												if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
												{
													continue;
												}
										
										}
										//When there is not Penalty regard mechanism.
										//if (!UsePenaltyRegardMechnisamT)
										{
											AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, TableS, Order, SolderesOnTable[i].SoldierThinking[k].Row, SolderesOnTable[i].SoldierThinking[k].Column);
											//If there is kish or kshachamaz Order.
											if (AB->Check(TableS, Order))
											{
												//When Order is Gray.
												if (Order == 1)
												{
													//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
													if (AB->CheckGray)
													{
														continue;
													}
												}
												else
												{
													//Continue when CheckBrown and AStarGreadyFirstSearch. 
													if (AB->CheckBrown)
													{
														continue;
													}
												}
											}
											// }
											else
											{

											}
										}
										RW1 = i;
										CL1 = k;
										Ki1 = j;
										RW2 = -1;
										CL2 = -1;
										Ki2 = -1;
										RW3 = -1;
										CL3 = -1;
										Ki3 = -1;
										RW4 = -1;
										CL4 = -1;
										Ki4 = -1;
										RW5 = -1;
										CL5 = -1;
										Ki5 = -1;
										RW6 = -1;
										CL6 = -1;
										Ki6 = -1;
										MaxLess1 = SolderesOnTable[RW1].SoldierThinking[CL1].NumberOfPenalties;
										if (MaxLess1 > MaxLess2)
										{
											MaxLess2 = -1;
										}
										if (MaxLess1 > MaxLess3)
										{
											MaxLess3 = -1;
										}
										if (MaxLess1 > MaxLess4)
										{
											MaxLess4 = -1;
										}
										if (MaxLess1 > MaxLess5)
										{
											MaxLess5 = -1;
										}
										if (MaxLess1 > MaxLess6)
										{
											MaxLess6 = -1;
										}

										//Set Table and Huristic Value and Syntax.
										if (AStarGreedyi == 1)
										{
											////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (OO)
											{
												if (Order == 1)
												{
													OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
													//RefreshBoxText();
												}
												else //If Order is Brown.
												{
													OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
													//RefreshBoxText();
												}
											}
											//Set Table and Huristic Value and Syntax.
											Act = true;
											////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (On)
											{
												AllDraw::LastRow = SolderesOnTable[i].SoldierThinking[k].Row;
												AllDraw::LastColumn = SolderesOnTable[i].SoldierThinking[k].Column;
												AllDraw::NextRow = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0];
												AllDraw::NextColumn = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1];
											}

											Less = SolderesOnTable[i].SoldierThinking[k].NumberOfPenalties;


											TableHuristic = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];


											////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (O1)
											{
												ThingsConverter::ActOfClickEqualTow = true;
											}
											SolderesOnTable[i].ConvertOperation(SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0], SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1], a, SolderesOnTable[i].SoldierThinking[k].TableListSolder[j], Order, false, i);
											int Sign = 1;
											if (a == -1)
											{
												Sign = -1;
											}
											//If there is Soldier Convert.
											if (SolderesOnTable[i].Convert)
											{

												if (SolderesOnTable[i].ConvertedToMinister)
												{
													TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 5 * Sign;
												}
												else if (SolderesOnTable[i].ConvertedToCastle)
												{
													TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 4 * Sign;
												}
												else if (SolderesOnTable[i].ConvertedToHourse)
												{
													TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 3 * Sign;
												}
												else if (SolderesOnTable[i].ConvertedToElefant)
												{
													TableHuristic[SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0]][SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1]] = 2 * Sign;
												}





											}

										}
										else
										{ //Set Table and Huristic Value and Syntax.
											
												if (AStarGreedyi == 1)
												{
													//TakeRoot.Pointer = this;
													//Found of Max Non Probable Movments.
													Founded.clear();
													double LessB = -DBL_MAX;
													BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB);
													RW1 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0])];
													CL1 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 1];
													Ki1 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 2];
													if (Founded[0] != MaxSoldeirFounded)
													{
														continue;
													}
													Act = true;
													////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
													//lock (On)
													{
														AllDraw::LastRow = SolderesOnTable[RW1].SoldierThinking[CL1].Row;
														AllDraw::LastColumn = SolderesOnTable[RW1].SoldierThinking[CL1].Column;
														AllDraw::NextRow = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][0];
														AllDraw::NextColumn = SolderesOnTable[i].SoldierThinking[k].RowColumnSoldier[j][1];
													}
													Less = SolderesOnTable[RW1].SoldierThinking[CL1].ReturnHuristic(RW1, Ki1, Order, false);


													TableHuristic = SolderesOnTable[RW1].SoldierThinking[CL1].TableListSolder[Ki1];


													////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
													//lock (O1)
													{
														ThingsConverter::ActOfClickEqualTow = true;
													}
													SolderesOnTable[RW1].ConvertOperation(SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][0], SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][1], a, SolderesOnTable[RW1].SoldierThinking[CL1].TableListSolder[Ki1], Order, false, i);
													int Sign = 1;
													if (a == -1)
													{
														Sign = -1;
													}
													//If there is Soldier Convert.
													if (SolderesOnTable[RW1].Convert)
													{

														if (SolderesOnTable[RW1].ConvertedToMinister)
														{
															TableHuristic[SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][0]][SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][1]] = 5 * Sign;
														}
														else if (SolderesOnTable[RW1].ConvertedToCastle)
														{
															TableHuristic[SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][0]][SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][1]] = 4 * Sign;
														}
														else if (SolderesOnTable[RW1].ConvertedToHourse)
														{
															TableHuristic[SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][0]][SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][1]] = 3 * Sign;
														}
														else if (SolderesOnTable[RW1].ConvertedToElefant)
														{
															TableHuristic[SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][0]][SolderesOnTable[RW1].SoldierThinking[CL1].RowColumnSoldier[Ki1][1]] = 2 * Sign;
														}




													}
													////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
													//lock (OO)
													{
														if (Order == 1)
														{
															OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
															//RefreshBoxText();
														}
														else //If Order is Brown.
														{
															OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
															//RefreshBoxText();
														}
													}
												}
										

										}
									}
								}
						
						}
				
				}
				
				/*
				            Order *= -1;
				            ChessRules::CurrentOrder *= -1;
				            for (int p = 0; p < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); p++)
				                SolderesOnTable[i].SoldierThinking[0].AStarGreedy[p].HuristicAStarGreedySearch(AStarGreedyi, A, a,  Less, Order, false);
				          */
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
			

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}
			//Do For Remaining Objects same as Soldeir Documentation.
			for (i = ElefantMidle; i < ElefantHigh; i++)
			{
				for (int k = 0; k < AllDraw::ElefantMovments; k++)
				{
					
						for (j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (&(ElephantOnTable[i].ElefantThinking) != nullptr) && (j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size()); j++)
						{
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								////if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT)
								//   if (ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsPenaltyAction() == 0)
								//       continue;
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
									if (UsePenaltyRegardMechnisamT)
									{
										for (int ij = 0; ij < ElephantOnTable[i].ElefantThinking[k].AStarGreedy.size() - 1; ij++)
										{
											ElephantOnTable[i].ElefantThinking[k].AStarGreedy[ij].IsPenaltyRegardCheckMateAtBranch(Order, Do, ElephantOnTable[i].ElefantThinking[k].AStarGreedy[ij]);
										}
										Order = COrder;
										ChessRules::CurrentOrder = CDummy;
										ToCheckMate = -1;
										ForCheckMate = -1;
										AA = IsToCheckMateHasLessDeeperThanForCheckMate( Order, ToCheckMate, ForCheckMate, 0);
										if (Do == -1)
										{
											continue;
										}
									}

							
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if ((ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsPenaltyAction() != 0 && ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT))
								{
									////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (On)
									{
										AllDraw::LastRow = ElephantOnTable[i].ElefantThinking[k].Row;
										AllDraw::LastColumn = ElephantOnTable[i].ElefantThinking[k].Column;
										AllDraw::NextRow = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][0];
										AllDraw::NextColumn = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][1];


										Act = true;
										Less = ElephantOnTable[i].ElefantThinking[k].NumberOfPenalties;
									}
									TableHuristic = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
									RegardOccurred = true;
									//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
									//return TableHuristic;
									continue;
								}
								//When There is No Movments in Such Order Enemy continue.
								if (ElephantOnTable[i].ElefantThinking[k].PenaltyRegardListElefant[j].IsPenaltyAction() == 0)
								{
									continue;
								}
								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (ElephantOnTable[i].ElefantThinking[0].NumberOfPenalties < Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (ElephantOnTable[i].ElefantThinking[0].NumberOfPenalties < Less)
									{

										//retrive Table of current huristic.

										//if (CheckG || CheckB)
										//{
										//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
										int **TableS = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
										//checked for Legal Movments ArgumentOutOfRangeException curnt game.
										if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
										{
											
												if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
												{
													continue;
												}
										
										}
										//When there is not Penalty regard mechanism.
										//if (!UsePenaltyRegardMechnisamT)
										{
											AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 2, TableS, Order, ElephantOnTable[i].ElefantThinking[k].Row, ElephantOnTable[i].ElefantThinking[k].Column);
											//If there is kish or kshachamaz Order.
											if (AB->Check(TableS, Order))
											{
												//When Order is Gray.
												if (Order == 1)
												{
													//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
													if (AB->CheckGray)
													{
														continue;
													}
												}
												else
												{
													//Continue when CheckBrown and AStarGreadyFirstSearch. 
													if (AB->CheckBrown)
													{
														continue;
													}
												}
											}
											else
											{

											}


										}
										RW2 = i;
										CL2 = k;
										Ki2 = j;
										RW1 = -1;
										CL1 = -1;
										Ki1 = -1;
										RW3 = -1;
										CL3 = -1;
										Ki3 = -1;
										RW4 = -1;
										CL4 = -1;
										Ki4 = -1;
										RW5 = -1;
										CL5 = -1;
										Ki5 = -1;
										RW6 = -1;
										CL6 = -1;
										Ki6 = -1;
										MaxLess2 = (ElephantOnTable[RW2].ElefantThinking[CL2].NumberOfPenalties);
										MaxLess1 = -1;
										if (MaxLess2 > MaxLess3)
										{
											MaxLess3 = -1;
										}
										if (MaxLess2 > MaxLess4)
										{
											MaxLess4 = -1;
										}
										if (MaxLess2 > MaxLess5)
										{
											MaxLess5 = -1;
										}
										if (MaxLess2 > MaxLess6)
										{
											MaxLess6 = -1;
										}
										if (AStarGreedyi == 1)
										{
											////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (OO)
											{
												if (Order == 1)
												{
													OutPut += std::wstring(L"\r\nChess Huristic Elephant By Bob!");
													//RefreshBoxText();
												}
												else //If Order is Brown.
												{
													OutPut += std::wstring(L"\r\nChess Huristic Elephant By Alice!");
													//RefreshBoxText();
												}
											}
											////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (On)
											{
												AllDraw::LastRow = ElephantOnTable[i].ElefantThinking[k].Row;
												AllDraw::LastColumn = ElephantOnTable[i].ElefantThinking[k].Column;
												AllDraw::NextRow = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][0];
												AllDraw::NextColumn = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][1];
											}

											Act = true;
											Less = ElephantOnTable[i].ElefantThinking[k].NumberOfPenalties;
											TableHuristic = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];

										}
									}
									else //Set Table and Huristic Value and Syntax.
									{
										
											if (AStarGreedyi == 1)
											{
												//TakeRoot.Pointer = this;
												//Found of Max Non Probable Movments.
												Founded.clear();
												double LessB = -DBL_MAX;
												BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB);
												RW2 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0])];
												CL2 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 1];
												Ki2 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 2];
												if (Founded[0] != MaxElephntFounded)
												{
													continue;
												}

												////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (On)
												{
													AllDraw::LastRow = ElephantOnTable[RW2].ElefantThinking[CL2].Row;
													AllDraw::LastColumn = ElephantOnTable[RW2].ElefantThinking[CL2].Column;
													AllDraw::NextRow = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][0];
													AllDraw::NextColumn = ElephantOnTable[i].ElefantThinking[k].RowColumnElefant[j][1];
												}

												Act = true;
												Less = ElephantOnTable[RW2].ElefantThinking[CL2].ReturnHuristic(RW2, Ki2, Order, false);
												TableHuristic = ElephantOnTable[RW2].ElefantThinking[CL2].TableListElefant[Ki2];
												////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (OO)
												{
													if (Order == 1)
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
														//RefreshBoxText();
													}
													else //If Order is Brown.
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
														//RefreshBoxText();
													}
												}
											}
									

									}
								}
						
						}
				
				}
				
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
			

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}

			for (i = HourseMidle; i < HourseHight; i++)
			{
				for (int k = 0; k < AllDraw::HourseMovments; k++)
				{
					
						for (j = 0; ((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && ((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && ((&HoursesOnTable[i].HourseThinking[k]) != nullptr) && ((&HoursesOnTable[i].HourseThinking[k]) != nullptr) && (j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size()); j++)
						{
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								////if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT)
								//    if (HoursesOnTable[i].HourseThinking[k].PenaltyRegardListHourse[j].IsPenaltyAction() == 0)
								//        continue;
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
									if (UsePenaltyRegardMechnisamT)
									{
										for (int ij = 0; ij < HoursesOnTable[i].HourseThinking[k].AStarGreedy.size() - 1; ij++)
										{
											HoursesOnTable[i].HourseThinking[k].AStarGreedy[ij].IsPenaltyRegardCheckMateAtBranch(Order, Do, HoursesOnTable[i].HourseThinking[k].AStarGreedy[ij]);
										}
										Order = COrder;
										ChessRules::CurrentOrder = CDummy;
										ToCheckMate = -1;
										ForCheckMate = -1;
										AA = IsToCheckMateHasLessDeeperThanForCheckMate( Order, ToCheckMate, ForCheckMate, 0);
										if (Do == -1)
										{
											continue;
										}
									}

							
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if ((HoursesOnTable[i].HourseThinking[k].PenaltyRegardListHourse[j].IsPenaltyAction() != 0 && HoursesOnTable[i].HourseThinking[k].PenaltyRegardListHourse[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT))
								{
									////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (On)
									{
										AllDraw::LastRow = HoursesOnTable[i].HourseThinking[k].Row;
										AllDraw::LastColumn = HoursesOnTable[i].HourseThinking[k].Column;
										AllDraw::NextRow = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][0];
										AllDraw::NextColumn = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][1];


										Act = true;
										Less = HoursesOnTable[i].HourseThinking[k].NumberOfPenalties;
									}
									TableHuristic = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];
									RegardOccurred = true;
									//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
									//return TableHuristic;
									continue;
								}

								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (HoursesOnTable[i].HourseThinking[0].NumberOfPenalties < Less)

										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (HoursesOnTable[i].HourseThinking[0].NumberOfPenalties < Less)
									{

										//retrive Table of current huristic.

										//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];
										int **TableS = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];
										{
											//checked for Legal Movments ArgumentOutOfRangeException curnt game.
											if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
											{
												
													if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
													{
														continue;
													}
											

											}
											//When there is not Penalty regard mechanism.
											//if (!UsePenaltyRegardMechnisamT)
											{
												AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 3, TableS, Order, HoursesOnTable[i].HourseThinking[k].Row, HoursesOnTable[i].HourseThinking[k].Column);
												//If there is kish or kshachamaz Order.
												if (AB->Check(TableS, Order))
												{
													//When Order is Gray.
													if (Order == 1)
													{
														//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
														if (AB->CheckGray)
														{
															continue;
														}
													}
													else
													{
														//Continue when CheckBrown and AStarGreadyFirstSearch. 
														if (AB->CheckBrown)
														{
															continue;
														}
													}
												}
												else
												{

												}
											}


										}
										RW1 = -1;
										CL1 = -1;
										Ki1 = -1;
										RW2 = -1;
										CL2 = -1;
										Ki2 = -1;
										RW3 = i;
										CL3 = k;
										Ki3 = j;
										RW4 = -1;
										CL4 = -1;
										Ki4 = -1;
										RW5 = -1;
										CL5 = -1;
										Ki5 = -1;
										RW6 = -1;
										CL6 = -1;
										Ki6 = -1;
										MaxLess3 = HoursesOnTable[RW3].HourseThinking[CL3].NumberOfPenalties;
										if (MaxLess3 > MaxLess1)
										{
											MaxLess1 = -1;
										}
										if (MaxLess3 > MaxLess2)
										{
											MaxLess2 = -1;
										}
										if (MaxLess3 > MaxLess4)
										{
											MaxLess4 = -1;
										}
										if (MaxLess3 > MaxLess5)
										{
											MaxLess5 = -1;
										}
										if (MaxLess3 > MaxLess6)
										{
											MaxLess6 = -1;
										}

										if (AStarGreedyi == 1)
										{
											////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (OO)
											{
												if (Order == 1)
												{
													OutPut += std::wstring(L"\r\nChess Huristic Hourse By Bob!");
													//RefreshBoxText();
												}
												else //If Order is Brown.
												{
													OutPut += std::wstring(L"\r\nChess Huristic Hourse By Alice!");
													//RefreshBoxText();
												}
											}
											//Set Table and Huristic Value and Syntax.

											////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (On)
											{
												AllDraw::LastRow = HoursesOnTable[i].HourseThinking[k].Row;
												AllDraw::LastColumn = HoursesOnTable[i].HourseThinking[k].Column;
												AllDraw::NextRow = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][0];
												AllDraw::NextColumn = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][1];
											}

											Act = true;
											Less = HoursesOnTable[i].HourseThinking[k].NumberOfPenalties;
											TableHuristic = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];

										}
									}
									else //Set Table and Huristic Value and Syntax.
									{
										
											if (AStarGreedyi == 1)
											{
												//TakeRoot.Pointer = this;
												//Found of Max Non Probable Movments.
												Founded.clear();
												double LessB = -DBL_MAX;
												BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB);
												RW3 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0])];
												CL3 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 1];
												Ki3 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 2];
												if (Founded[0] != MaxHourseFounded)
												{
													continue;
												}

												////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (On)
												{
													AllDraw::LastRow = HoursesOnTable[RW3].HourseThinking[CL3].Row;
													AllDraw::LastColumn = HoursesOnTable[RW3].HourseThinking[CL3].Column;
													AllDraw::NextRow = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][0];
													AllDraw::NextColumn = HoursesOnTable[i].HourseThinking[k].RowColumnHourse[j][1];
												}

												Act = true;
												Less = HoursesOnTable[RW3].HourseThinking[CL3].ReturnHuristic(RW3, Ki3, Order, false);
												TableHuristic = HoursesOnTable[RW3].HourseThinking[CL3].TableListHourse[Ki3];
												////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (OO)
												{
													if (Order == 1)
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
														//RefreshBoxText();
													}
													else //If Order is Brown.
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
														//RefreshBoxText();
													}
												}
											}
									


									}
								}
						
						}
				
				}
				
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
			

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}

			for (i = CastleMidle; i < CastleHigh; i++)
			{
				for (int k = 0; k < AllDraw::CastleMovments; k++)
				{
					
						for (j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (&(CastlesOnTable[i].CastleThinking) != nullptr) && (j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size()); j++)
						{
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								////if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT)
								///   if (CastlesOnTable[i].CastleThinking[k].PenaltyRegardListCastle[j].IsPenaltyAction() == 0)
								//       continue;

								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
									if (UsePenaltyRegardMechnisamT)
									{
										for (int ij = 0; ij < CastlesOnTable[i].CastleThinking[k].AStarGreedy.size() - 1; ij++)
										{
											CastlesOnTable[i].CastleThinking[k].AStarGreedy[ij].IsPenaltyRegardCheckMateAtBranch(Order, Do, CastlesOnTable[i].CastleThinking[k].AStarGreedy[ij]);
										}
										Order = COrder;
										ChessRules::CurrentOrder = CDummy;
										ToCheckMate = -1;
										ForCheckMate = -1;
										AA = IsToCheckMateHasLessDeeperThanForCheckMate( Order, ToCheckMate, ForCheckMate, 0);
										if (Do == -1)
										{
											continue;
										}
									}

							
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if ((CastlesOnTable[i].CastleThinking[k].PenaltyRegardListCastle[j].IsPenaltyAction() != 0 && CastlesOnTable[i].CastleThinking[k].PenaltyRegardListCastle[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT))
								{

									////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (On)
									{
										AllDraw::LastRow = CastlesOnTable[i].CastleThinking[k].Row;
										AllDraw::LastColumn = CastlesOnTable[i].CastleThinking[k].Column;
										AllDraw::NextRow = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][0];
										AllDraw::NextColumn = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][1];
										Act = true;
										Less = CastlesOnTable[i].CastleThinking[k].NumberOfPenalties;
									}
									TableHuristic = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
									RegardOccurred = true;
									//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
									//return TableHuristic;
									continue;
								}
								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									if (Order != AllDraw::OrderPlate)
									{
										if (CastlesOnTable[i].CastleThinking[0].NumberOfPenalties < Less)
										{
											continue;
										}
									}
									//When There is greater Huristic Movments.
									if (CastlesOnTable[i].CastleThinking[0].NumberOfPenalties < Less)
									{

										//retrive Table of current huristic.
										//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
										int **TableS = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
										//checked for Legal Movments ArgumentOutOfRangeException curnt game.
										if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
										{
											
												if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
												{
													continue;
												}
										

										}
										//When there is not Penalty regard mechanism.
										//if (!UsePenaltyRegardMechnisamT)
										{
											AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 4, TableS, Order, CastlesOnTable[i].CastleThinking[k].Row, CastlesOnTable[i].CastleThinking[k].Column);
											//If there is kish or kshachamaz Order.
											if (AB->Check(TableS, Order))
											{
												//When Order is Gray.
												if (Order == 1)
												{
													//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
													if (AB->CheckGray)
													{
														continue;
													}
												}
												else
												{
													//Continue when CheckBrown and AStarGreadyFirstSearch. 
													if (AB->CheckBrown)
													{
														continue;
													}
												}
											}
											else
											{

											}

										}
										RW4 = i;
										CL4 = k;
										Ki4 = j;
										RW1 = -1;
										CL1 = -1;
										Ki1 = -1;
										RW2 = -1;
										CL2 = -1;
										Ki2 = -1;
										RW3 = -1;
										CL3 = -1;
										Ki3 = -1;
										RW5 = -1;
										CL5 = -1;
										Ki5 = -1;
										RW6 = -1;
										CL6 = -1;
										Ki6 = -1;
										MaxLess4 = (CastlesOnTable[RW4].CastleThinking[CL4].NumberOfPenalties);
										if (MaxLess4 > MaxLess1)
										{
											MaxLess1 = -1;
										}
										if (MaxLess4 > MaxLess2)
										{
											MaxLess2 = -1;
										}
										if (MaxLess4 > MaxLess3)
										{
											MaxLess3 = -1;
										}
										if (MaxLess4 > MaxLess5)
										{
											MaxLess5 = -1;
										}
										if (MaxLess4 > MaxLess6)
										{
											MaxLess6 = -1;
										}

										if (AStarGreedyi == 1)
										{
											////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (OO)
											{
												if (Order == 1)
												{
													OutPut += std::wstring(L"\r\nChess Huristic Castles By Bob!");
													//RefreshBoxText();
												}
												else //If Order is Brown.
												{
													OutPut += std::wstring(L"\r\nChess Huristic Castles By Alice!");
													//RefreshBoxText();
												}
											}
											//Set Table and Huristic Value and Syntax.

											////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (On)
											{
												AllDraw::LastRow = CastlesOnTable[i].CastleThinking[k].Row;
												AllDraw::LastColumn = CastlesOnTable[i].CastleThinking[k].Column;
												AllDraw::NextRow = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][0];
												AllDraw::NextColumn = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][1];
											}

											Act = true;
											Less = CastlesOnTable[i].CastleThinking[k].NumberOfPenalties;
											TableHuristic = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];

										}
									}
									else //Set Table and Huristic Value and Syntax.
									{
										
											if (AStarGreedyi == 1)
											{
												//TakeRoot.Pointer = this;
												//Found of Max Non Probable Movments.
												Founded.clear();
												double LessB = -DBL_MAX;
												BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB);
												RW4 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0])];
												CL4 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 1];
												Ki4 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 2];
												if (Founded[0] != MaxCastlesFounded)
												{
													continue;
												}

												////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (On)
												{
													AllDraw::LastRow = CastlesOnTable[RW4].CastleThinking[CL4].Row;
													AllDraw::LastColumn = CastlesOnTable[RW4].CastleThinking[CL4].Column;
													AllDraw::NextRow = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][0];
													AllDraw::NextColumn = CastlesOnTable[i].CastleThinking[k].RowColumnCastle[j][1];
												}

												Act = true;
												Less = CastlesOnTable[RW4].CastleThinking[CL4].ReturnHuristic(RW4, Ki4, Order, false);
												TableHuristic = CastlesOnTable[RW4].CastleThinking[CL4].TableListCastle[Ki4];
												////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (OO)
												{
													if (Order == 1)
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
														//RefreshBoxText();
													}
													else //If Order is Brown.
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
														//RefreshBoxText();
													}
												}
											}
									

									}
								}
						
						}
				
				}
				
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
			
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}


			for (i = MinisterMidle; i < MinisterHigh; i++)
			{
				for (int k = 0; k < AllDraw::MinisterMovments; k++)
				{
					
						for (j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && ((&MinisterOnTable[i].MinisterThinking[k]) != nullptr) && ((&MinisterOnTable[i].MinisterThinking[k]) != nullptr) && (j < MinisterOnTable[i].MinisterThinking[k].TableListMinister.size()); j++)
						{
							
								//For Penalty Reagrad Mechanisam of Current Check CheckMate Current Movments.
								////if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT)
								////    if (MinisterOnTable[i].MinisterThinking[k].PenaltyRegardListMinister[j].IsPenaltyAction() == 0)
								//     continue;
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
									if (UsePenaltyRegardMechnisamT)
									{
										for (int ij = 0; ij < MinisterOnTable[i].MinisterThinking[k].AStarGreedy.size() - 1; ij++)
										{
											MinisterOnTable[i].MinisterThinking[k].AStarGreedy[ij].IsPenaltyRegardCheckMateAtBranch(Order, Do, MinisterOnTable[i].MinisterThinking[k].AStarGreedy[ij]);
										}
										Order = COrder;
										ChessRules::CurrentOrder = CDummy;
										ToCheckMate = -1;
										ForCheckMate = -1;
										AA = IsToCheckMateHasLessDeeperThanForCheckMate( Order, ToCheckMate, ForCheckMate, 0);
										if (Do == -1)
										{
											continue;
										}
									}

							
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if ((MinisterOnTable[i].MinisterThinking[k].PenaltyRegardListMinister[j].IsPenaltyAction() != 0 && MinisterOnTable[i].MinisterThinking[k].PenaltyRegardListMinister[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT))
								{

									////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (On)
									{
										AllDraw::LastRow = MinisterOnTable[i].MinisterThinking[k].Row;
										AllDraw::LastColumn = MinisterOnTable[i].MinisterThinking[k].Column;
										AllDraw::NextRow = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][0];
										AllDraw::NextColumn = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][1];


										Act = true;
										Less = MinisterOnTable[i].MinisterThinking[k].NumberOfPenalties;
									}
									TableHuristic = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
									RegardOccurred = true;
									//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
									//return TableHuristic;
									continue;
								}
								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{
									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (MinisterOnTable[i].MinisterThinking[0].NumberOfPenalties < Less)
										{
											continue;
										}
									}


									//When There is greater Huristic Movments.
									if (MinisterOnTable[i].MinisterThinking[0].NumberOfPenalties < Less)

									{
									//retrive Table of current huristic.

										//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
										int **TableS = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
										//checked for Legal Movments ArgumentOutOfRangeException curnt game.
										if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
										{
											
												if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
												{
													continue;
												}
										
										}
										{
											//When there is not Penalty regard mechanism.
											//if (!UsePenaltyRegardMechnisamT)
											{
												AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 5, TableS, Order, MinisterOnTable[i].MinisterThinking[k].Row, MinisterOnTable[i].MinisterThinking[k].Column);
												//If there is kish or kshachamaz Order.
												if (AB->Check(TableS, Order))
												{
													//When Order is Gray.
													if (Order == 1)
													{
														//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
														if (AB->CheckGray)
														{
															continue;
														}
													}
													else
													{
														//Continue when CheckBrown and AStarGreadyFirstSearch. 
														if (AB->CheckBrown)
														{
															continue;
														}
													}
												}
												else
												{

												}
											}

										}
										RW5 = i;
										CL5 = k;
										Ki5 = j;
										RW1 = -1;
										CL1 = -1;
										Ki1 = -1;
										RW2 = -1;
										CL2 = -1;
										Ki2 = -1;
										RW3 = -1;
										CL3 = -1;
										Ki3 = -1;
										RW4 = -1;
										CL4 = -1;
										Ki4 = -1;
										RW6 = -1;
										CL6 = -1;
										Ki6 = -1;
										MaxLess5 = (MinisterOnTable[RW5].MinisterThinking[CL5].NumberOfPenalties);
										if (MaxLess5 > MaxLess1)
										{
											MaxLess1 = -1;
										}
										if (MaxLess5 > MaxLess2)
										{
											MaxLess2 = -1;
										}
										if (MaxLess5 > MaxLess3)
										{
											MaxLess3 = -1;
										}
										if (MaxLess5 > MaxLess4)
										{
											MaxLess4 = -1;
										}
										if (MaxLess5 > MaxLess6)
										{
											MaxLess6 = -1;
										}
										if (AStarGreedyi == 1)
										{
											////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (OO)
											{
												if (Order == 1)
												{
													OutPut += std::wstring(L"\r\nChess Huristic Minister By Bob!");
													//RefreshBoxText();
												}
												else //If Order is Brown.
												{
													OutPut += std::wstring(L"\r\nChess Huristic Minister By Alice!");
													//RefreshBoxText();
												}
											}
											////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (On)
											{
												AllDraw::LastRow = MinisterOnTable[i].MinisterThinking[k].Row;
												AllDraw::LastColumn = MinisterOnTable[i].MinisterThinking[k].Column;
												AllDraw::NextRow = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][0];
												AllDraw::NextColumn = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][1];
											}

											Act = true;
											Less = MinisterOnTable[i].MinisterThinking[k].NumberOfPenalties;
											TableHuristic = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];

										}
									}
									else //Set Table and Huristic Value and Syntax.
									{
										
											if (AStarGreedyi == 1)
											{
												//TakeRoot.Pointer = this;
												//Found of Max Non Probable Movments.
												Founded.clear();
												double LessB = -DBL_MAX;
												BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB);
												RW5 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0])];
												CL5 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 1];
												Ki5 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 2];
												if (Founded[0] != MaxMinisterFounded)
												{
													continue;
												}

												////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (On)
												{
													AllDraw::LastRow = MinisterOnTable[RW5].MinisterThinking[CL5].Row;
													AllDraw::LastColumn = MinisterOnTable[RW5].MinisterThinking[CL5].Column;
													AllDraw::NextRow = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][0];
													AllDraw::NextColumn = MinisterOnTable[i].MinisterThinking[k].RowColumnMinister[j][1];
												}
												Act = true;
												Less = MinisterOnTable[RW5].MinisterThinking[CL5].ReturnHuristic(RW5, Ki5, Order, false);
												TableHuristic = MinisterOnTable[RW5].MinisterThinking[CL5].TableListMinister[Ki5];
												////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (OO)
												{
													if (Order == 1)
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
														//RefreshBoxText();
													}
													else //If Order is Brown.
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
														//RefreshBoxText();
													}
												}
											}
									
									}
								}
						
						}
				
				}
				
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
			

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;

			for (i = KingMidle; i < KingHigh; i++)
			{
				for (int k = 0; k < AllDraw::KingMovments; k++)
				{
					
						for (j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (&(KingOnTable[i].KingThinking) != nullptr) && (j < KingOnTable[i].KingThinking[k].TableListKing.size()); j++)
						{
							
								//////if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT)
								//    if (KingOnTable[i].KingThinking[k].PenaltyRegardListKing[j].IsPenaltyAction() == 0)
								//        continue;
								int CDummy = ChessRules::CurrentOrder;
								int COrder = Order;
								
									ChessRules::CurrentOrder *= -1;
									Order *= -1;
									Do = 0;
									if (UsePenaltyRegardMechnisamT)
									{
										for (int ij = 0; ij < KingOnTable[i].KingThinking[k].AStarGreedy.size() - 1; ij++)
										{
											KingOnTable[i].KingThinking[k].AStarGreedy[ij].IsPenaltyRegardCheckMateAtBranch(Order, Do, KingOnTable[i].KingThinking[k].AStarGreedy[ij]);
										}
										Order = COrder;
										ChessRules::CurrentOrder = CDummy;
										ToCheckMate = -1;
										ForCheckMate = -1;
										AA = IsToCheckMateHasLessDeeperThanForCheckMate( Order, ToCheckMate, ForCheckMate, 0);
										if (Do == -1)
										{
											continue;
										}
									}

							
								Order = COrder;
								ChessRules::CurrentOrder = CDummy;
								//if (AllDraw.OrderPlate == Order && AStarGreedyi == 1 //&& UsePenaltyRegardMechnisamT
								//)
								if ((KingOnTable[i].KingThinking[k].PenaltyRegardListKing[j].IsPenaltyAction() != 0 && KingOnTable[i].KingThinking[k].PenaltyRegardListKing[j].IsRewardAction() == 1 && AStarGreedyi == 1) || ((Do == 1 || AA) && UsePenaltyRegardMechnisamT))
								{

									////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (On)
									{
										AllDraw::LastRow = KingOnTable[i].KingThinking[k].Row;
										AllDraw::LastColumn = KingOnTable[i].KingThinking[k].Column;
										AllDraw::NextRow = KingOnTable[i].KingThinking[k].RowColumnKing[j][0];
										AllDraw::NextColumn = KingOnTable[i].KingThinking[k].RowColumnKing[j][1];


										Act = true;
										Less = KingOnTable[i].KingThinking[k].NumberOfPenalties;
									}
									TableHuristic = KingOnTable[i].KingThinking[k].TableListKing[j];
									RegardOccurred = true;
									//if (((Do == 1 || AA)&&UsePenaltyRegardMechnisamT))
									//return TableHuristic;
									continue;
								}
								////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (ol)
								{

									//When There is No Movments in Such Order Enemy continue.
									if (Order != AllDraw::OrderPlate)
									{
										if (KingOnTable[i].KingThinking[0].NumberOfPenalties < Less)
										{
											continue;
										}
									}


									//When There is greater Huristic Movments.
									if (KingOnTable[i].KingThinking[0].NumberOfPenalties < Less)
									{
									//retrive Table of current huristic.


										//retrive Table of current huristic.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = KingOnTable[i].KingThinking[k].TableListKing[j];
										int **TableS = KingOnTable[i].KingThinking[k].TableListKing[j];
										//checked for Legal Movments ArgumentOutOfRangeException curnt game.
										if (DynamicAStarGreedytPrograming && !CurrentTableHuristic && AStarGreedyi == 1)
										{
											
												if (!IsEnemyThingsinStable(TableS, AllDraw::TableListAction[AllDraw::TableListAction.size() - 1], AllDraw::OrderPlate))
												{
													continue;
												}
										

										}
										//When there is not Penalty regard mechanism.
										//if (!UsePenaltyRegardMechnisamT)
										{
											AB = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 6, TableS, Order, KingOnTable[i].KingThinking[k].Row, KingOnTable[i].KingThinking[k].Column);
											//If there is kish or kshachamaz Order.
											if (AB->Check(TableS, Order))
											{
												//When Order is Gray.
												if (Order == 1)
												{
													//Continue When is kish CheckObjectDangour and AStarGreadyFirstSearch .
													if (AB->CheckGray)
													{
														continue;
													}
												}
												else
												{
													//Continue when CheckBrown and AStarGreadyFirstSearch. 
													if (AB->CheckBrown)
													{
														continue;
													}
												}
											}
											else
											{

											}


										}
										RW6 = i;
										CL6 = k;
										Ki6 = j;
										RW1 = -1;
										CL1 = -1;
										Ki1 = -1;
										RW2 = -1;
										CL2 = -1;
										Ki2 = -1;
										RW3 = -1;
										CL3 = -1;
										Ki3 = -1;
										RW4 = -1;
										CL4 = -1;
										Ki4 = -1;
										RW5 = -1;
										CL5 = -1;
										Ki5 = -1;
										MaxLess6 = (KingOnTable[RW6].KingThinking[CL6].NumberOfPenalties);
										if (MaxLess6 > MaxLess1)
										{
											MaxLess1 = -1;
										}
										if (MaxLess6 > MaxLess2)
										{
											MaxLess2 = -1;
										}
										if (MaxLess6 > MaxLess3)
										{
											MaxLess3 = -1;
										}
										if (MaxLess6 > MaxLess4)
										{
											MaxLess4 = -1;
										}
										if (MaxLess6 > MaxLess5)
										{
											MaxLess5 = -1;
										}
										if (AStarGreedyi == 1)
										{
											////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (OO)
											{
												if (Order == 1)
												{
													OutPut += std::wstring(L"\r\nChess Huristic King By Bob!");
													//RefreshBoxText();
												}
												else //If Order is Brown.
												{
													OutPut += std::wstring(L"\r\nChess Huristic King By Alice!");
													//RefreshBoxText();
												}
											}
											////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (On)
											{
												AllDraw::LastRow = KingOnTable[i].KingThinking[k].Row;
												AllDraw::LastColumn = KingOnTable[i].KingThinking[k].Column;
												AllDraw::NextRow = KingOnTable[i].KingThinking[k].RowColumnKing[j][0];
												AllDraw::NextColumn = KingOnTable[i].KingThinking[k].RowColumnKing[j][1];
											}

											Act = true;
											Less = KingOnTable[i].KingThinking[k].NumberOfPenalties;
											TableHuristic = KingOnTable[i].KingThinking[k].TableListKing[j];

										}
									}
									else //Set Table and Huristic Value and Syntax.
									{
										
											if (AStarGreedyi == 1)
											{
												//TakeRoot.Pointer = this;
												//Found of Max Non Probable Movments.
												Founded.clear();
												double LessB = -DBL_MAX;
												BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB);
												if (Founded[0] != 1)
												{
													continue;
												}
												RW6 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0])];
												CL6 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 1];
												Ki6 = MaxHuristicAStarGreedytBackWard[0][static_cast<int>(Founded[0]) + 2];
												if (Founded[0] != MaxKingFounded)
												{
													continue;
												}

												////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (On)
												{
													AllDraw::LastRow = KingOnTable[RW6].KingThinking[CL6].Row;
													AllDraw::LastColumn = KingOnTable[RW6].KingThinking[CL6].Column;
													AllDraw::NextRow = KingOnTable[i].KingThinking[k].RowColumnKing[j][0];
													AllDraw::NextColumn = KingOnTable[i].KingThinking[k].RowColumnKing[j][1];
												}

												Act = true;
												Less = KingOnTable[RW6].KingThinking[CL6].ReturnHuristic(RW6, Ki6, Order, false);
												TableHuristic = KingOnTable[RW6].KingThinking[CL6].TableListKing[Ki6];
												////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
												//lock (OO)
												{
													if (Order == 1)
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Bob!");
														//RefreshBoxText();
													}
													else //If Order is Brown.
													{
														OutPut += std::wstring(L"\r\nChess Huristic Sodier By Alice!");
														//RefreshBoxText();
													}
												}
											}
									

									}

									{
									//else
									}
								}
						
						}
				
				}
				
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
			

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}
			return TableHuristic;
		}
	}

	int **AllDraw::HuristicAStarGreedySearch(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			int **TableHuristic = new int*[8]; for (int g = 0; g < 8; g++)TableHuristic[g] = new int[8];
			
			AStarGreedyi++;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			//Initiate For Dynamic Backward Current AStarGreedyi Non Minus Founded Max Movments Detection Global Variables.
			std::vector<double> Founded = std::vector<double>();
			//Initiateing Indicating Huristic Multiple Same Value Best Found of Movments.
			MaxLess1 = -1;
			MaxLess2 = -1;
			MaxLess3 = -1;
			MaxLess4 = -1;
			MaxLess5 = -1;
			MaxLess6 = -1;
			RW1 = -1;
			CL1 = -1;
			Ki1 = -1;
			RW2 = -1;
			CL2 = -1;
			Ki2 = -1;
			RW3 = -1;
			CL3 = -1;
			Ki3 = -1;
			RW4 = -1;
			CL4 = -1;
			Ki4 = -1;
			RW5 = -1;
			CL5 = -1;
			Ki5 = -1;
			RW6 = -1;
			CL6 = -1;
			Ki6 = -1;

			double BacWard[25];
			////auto Omm = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (Omm)
			{

				if (AStarGreedyi > MaxAStarGreedy)
				{
					return TableHuristic;
				}
			}
			bool Act = new bool();
			Act = false;
			if (Order == 1)
			{
				TableHuristic = HuristicAStarGreadySearchGray(AStarGreedyi, a, Order, CurrentTableHuristic, Act);
			}
			else
			{
				TableHuristic = HuristicAStarGreadySearchBrown(AStarGreedyi, a, Order, CurrentTableHuristic, Act);
			}

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			//Store In Local Variable and Dynamic Purpose Proccessing.
			//Every Non Minuse Non Idept in List Has Gretest Max Order.
			//Is Desired of Idept Oner Best Movments.
			BacWard[0] = AStarGreedyi;

			BacWard[1] = MaxLess1;
			BacWard[2] = RW1;
			BacWard[3] = RW1;
			BacWard[4] = Ki1;


			BacWard[5] = MaxLess2;
			BacWard[6] = RW2;
			BacWard[7] = RW2;
			BacWard[8] = Ki2;

			BacWard[9] = MaxLess3;
			BacWard[10] = RW3;
			BacWard[11] = RW3;
			BacWard[12] = Ki3;

			BacWard[13] = MaxLess4;
			BacWard[14] = RW4;
			BacWard[15] = RW4;
			BacWard[16] = Ki4;

			BacWard[17] = MaxLess5;
			BacWard[18] = RW5;
			BacWard[19] = RW5;
			BacWard[20] = Ki5;

			BacWard[21] = MaxLess6;
			BacWard[22] = RW6;
			BacWard[23] = RW6;
			BacWard[24] = Ki6;

			//We Have Information of Maximum of Huristic in Each Level and Table.
			MaxHuristicAStarGreedytBackWard.push_back(BacWard);
			MaxHuristicAStarGreedytBackWardTable.push_back(TableHuristic);

			Founded.clear();
			//If Found retrun Table.
			if (Act)
			{
				return TableHuristic;
			}
			//Return what found Table.
			return TableHuristic;
		}
	}

	
	
	
	int AllDraw::MaxGrayMidle()
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			int Tab[6];
			Tab[0] = SodierMidle;
			Tab[1] = ElefantMidle;
			Tab[2] = HourseMidle;
			Tab[3] = CastleMidle;
			Tab[4] = MinisterMidle;
			Tab[5] = KingMidle;
			int Max = 0;
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] > Max)
				{
					Max = Tab[i];
				}
			}
			return Max;
		}
	}

	int AllDraw::MaxBrownHigh()
	{

		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			int Tab[6];
			Tab[0] = SodierHigh;
			Tab[1] = ElefantHigh;
			Tab[2] = HourseHight;
			Tab[3] = CastleHigh;
			Tab[4] = MinisterHigh;
			Tab[5] = KingHigh;
			int Max = 0;
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] > Max)
				{
					Max = Tab[i];
				}
			}
			return Max;
		}
	}

	int AllDraw::MinBrownMidle()
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			int *Tab = new int[6];
			Tab[0] = SodierHigh;
			Tab[1] = ElefantHigh;
			Tab[2] = HourseHight;
			Tab[3] = CastleHigh;
			Tab[4] = MinisterHigh;
			Tab[5] = KingHigh;
			int Min = MaxBrownHigh();
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] < Min)
				{
					Min = Tab[i];
				}
			}
			return Min;
		}
	}

	
	
	
	bool AllDraw::TableEqual(int **t1, int **t2)
	{
		bool Is = true;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (t1[i][j] != t2[i][j])
				{
					Is = false;
				}
			}
		}
		return Is;
	}

	void AllDraw::Serve(int Order)
	{
		if (Order == 1)
		{
			for (int i = 0; i < SodierMidle; i++)
			{
				ServeISSup(Order, 1, i);
			}
			for (int i = 0; i < ElefantMidle; i++)
			{
				ServeISSup(Order, 2, i);
			}
			for (int i = 0; i < HourseMidle; i++)
			{
				ServeISSup(Order, 3, i);
			}
			for (int i = 0; i < CastleMidle; i++)
			{
				ServeISSup(Order, 4, i);
			}
			for (int i = 0; i < MinisterMidle; i++)
			{
				ServeISSup(Order, 5, i);
			}
			for (int i = 0; i < KingMidle; i++)
			{
				ServeISSup(Order, 6, i);
			}

		}
		else
		{
			for (int i = SodierMidle; i < SodierHigh; i++)
			{
				ServeISSup(Order, 1, i);
			}
			for (int i = ElefantMidle; i < ElefantHigh; i++)
			{
				ServeISSup(Order, 2, i);
			}
			for (int i = HourseMidle; i < HourseHight; i++)
			{
				ServeISSup(Order, 3, i);
			}
			for (int i = CastleMidle; i < CastleHigh; i++)
			{
				ServeISSup(Order, 4, i);
			}
			for (int i = MinisterMidle; i < MinisterHigh; i++)
			{
				ServeISSup(Order, 5, i);
			}
			for (int i = KingMidle; i < KingHigh; i++)
			{
				ServeISSup(Order, 6, i);
			}
		}
	}

	void AllDraw::ServeISSup(int Order, int Kind, int ii)
	{
		if (Kind == 1)
		{
			if (Order == 1)
			{
				{
				//if (SolderesOnTable[ii].SoldierThinking[0].IsSup[j])

					for (int i = 0; i < SodierMidle; i++)
					{
						if ((&(SolderesOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(SolderesOnTable[i].SoldierThinking[0].TableListSolder, SolderesOnTable[ii].SoldierThinking[0].TableConst);
						for (int j = 0; j < SolderesOnTable[i].SoldierThinking[0].HuristicListSolder.size(); j++)
						{
							if (!(SolderesOnTable[i].SoldierThinking[0].IsSup[j]))
							{
								continue;
							}


							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][0] += SolderesOnTable[ii].SoldierThinking[0].HuristicAttackValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][1] += SolderesOnTable[ii].SoldierThinking[0].HuristicMovementValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][2] += SolderesOnTable[ii].SoldierThinking[0].HuristicSelfSupportedValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][3] += SolderesOnTable[ii].SoldierThinking[0].HuristicObjectDangourCheckMateValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][4] += SolderesOnTable[ii].SoldierThinking[0].HuristicKillerValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][5] += SolderesOnTable[ii].SoldierThinking[0].HuristicReducedAttackValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][6] += SolderesOnTable[ii].SoldierThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][7] += SolderesOnTable[ii].SoldierThinking[0].HeuristicKingSafeSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][8] += SolderesOnTable[ii].SoldierThinking[0].HeuristicFromCenterSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][9] += SolderesOnTable[ii].SoldierThinking[0].HeuristicKingDangourSup;
							SolderesOnTable[i].SoldierThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Soldeir!");
						}
					}
					SolderesOnTable[ii].SoldierThinking[0].HuristicAttackValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicMovementValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicSelfSupportedValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicKillerValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicReducedAttackValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicKingSafeSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicFromCenterSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicKingDangourSup = 0;
				}
			}
			else
			{
				{
				//if (SolderesOnTable[ii].SoldierThinking[0].IsSup[j])

					for (int i = SodierMidle; i < SodierHigh; i++)
					{
						if ((&(SolderesOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(SolderesOnTable[i].SoldierThinking[0].TableListSolder, SolderesOnTable[ii].SoldierThinking[0].TableConst);
						for (int j = 0; j < SolderesOnTable[i].SoldierThinking[0].HuristicListSolder.size(); j++)
						{
							if (!(SolderesOnTable[i].SoldierThinking[0].IsSup[j]))
							{
								continue;
							}


							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][0] += SolderesOnTable[ii].SoldierThinking[0].HuristicAttackValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][1] += SolderesOnTable[ii].SoldierThinking[0].HuristicMovementValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][2] += SolderesOnTable[ii].SoldierThinking[0].HuristicSelfSupportedValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][3] += SolderesOnTable[ii].SoldierThinking[0].HuristicObjectDangourCheckMateValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][4] += SolderesOnTable[ii].SoldierThinking[0].HuristicKillerValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][5] += SolderesOnTable[ii].SoldierThinking[0].HuristicReducedAttackValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][6] += SolderesOnTable[ii].SoldierThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][7] += SolderesOnTable[ii].SoldierThinking[0].HeuristicKingSafeSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][8] += SolderesOnTable[ii].SoldierThinking[0].HeuristicFromCenterSup;
							SolderesOnTable[i].SoldierThinking[0].HuristicListSolder[j][9] += SolderesOnTable[ii].SoldierThinking[0].HeuristicKingDangourSup;
							SolderesOnTable[i].SoldierThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Soldeir!");
						}
					}
					SolderesOnTable[ii].SoldierThinking[0].HuristicAttackValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicMovementValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicSelfSupportedValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicKillerValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HuristicReducedAttackValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicKingSafeSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicFromCenterSup = 0;
					SolderesOnTable[ii].SoldierThinking[0].HeuristicKingDangourSup = 0;
				}
			}
		}
		else if (Kind == 2)
		{
			if (Order == 1)
			{
				{
				//if (ElephantOnTable[ii].ElefantThinking[0].IsSup[j])
					for (int i = 0; i < ElefantMidle; i++)
					{
						if ((&(ElephantOnTable[i]) == nullptr))
						{
							continue;
						}
						{
						//if (this != null && this != null)
							//int j = FoundTableIndex(ElephantOnTable[i].ElefantThinking[0].TableListElefant, ElephantOnTable[ii].ElefantThinking[0].TableConst);
							for (int j = 0; j < ElephantOnTable[i].ElefantThinking[0].HuristicListElefant.size(); j++)
							{
								if (!(ElephantOnTable[i].ElefantThinking[0].IsSup[j]))
								{
									continue;
								}

								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][0] += ElephantOnTable[ii].ElefantThinking[0].HuristicAttackValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][1] += ElephantOnTable[ii].ElefantThinking[0].HuristicMovementValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][2] += ElephantOnTable[ii].ElefantThinking[0].HuristicSelfSupportedValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][3] += ElephantOnTable[ii].ElefantThinking[0].HuristicObjectDangourCheckMateValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][4] += ElephantOnTable[ii].ElefantThinking[0].HuristicKillerValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][5] += ElephantOnTable[ii].ElefantThinking[0].HuristicReducedAttackValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][6] += ElephantOnTable[ii].ElefantThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][7] += ElephantOnTable[ii].ElefantThinking[0].HeuristicKingSafeSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][8] += ElephantOnTable[ii].ElefantThinking[0].HeuristicFromCenterSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][9] += ElephantOnTable[ii].ElefantThinking[0].HeuristicKingDangourSup;
								ElephantOnTable[i].ElefantThinking[0].IsSup[j] = false;

								AllDraw::OutPut += std::wstring(L"\r\nServed Elephant!");
							}
						}
					}
					ElephantOnTable[ii].ElefantThinking[0].HuristicAttackValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicMovementValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicSelfSupportedValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicKillerValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicReducedAttackValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicKingSafeSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicFromCenterSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicKingDangourSup = 0;
				}
			}
			else
			{

				{
				//if (ElephantOnTable[ii].ElefantThinking[0].IsSup[j])
					for (int i = ElefantMidle; i < ElefantHigh; i++)
					{
						if ((&(ElephantOnTable[i]) == nullptr))
						{
							continue;
						}
						{
						//if (this != null && this != null)
							//int j = FoundTableIndex(ElephantOnTable[i].ElefantThinking[0].TableListElefant, ElephantOnTable[ii].ElefantThinking[0].TableConst);
							for (int j = 0; j < ElephantOnTable[i].ElefantThinking[0].HuristicListElefant.size(); j++)
							{
								if (!(ElephantOnTable[i].ElefantThinking[0].IsSup[j]))
								{
									continue;
								}


								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][0] += ElephantOnTable[ii].ElefantThinking[0].HuristicAttackValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][1] += ElephantOnTable[ii].ElefantThinking[0].HuristicMovementValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][2] += ElephantOnTable[ii].ElefantThinking[0].HuristicSelfSupportedValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][3] += ElephantOnTable[ii].ElefantThinking[0].HuristicObjectDangourCheckMateValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][4] += ElephantOnTable[ii].ElefantThinking[0].HuristicKillerValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][5] += ElephantOnTable[ii].ElefantThinking[0].HuristicReducedAttackValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][6] += ElephantOnTable[ii].ElefantThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][7] += ElephantOnTable[ii].ElefantThinking[0].HeuristicKingSafeSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][8] += ElephantOnTable[ii].ElefantThinking[0].HeuristicFromCenterSup;
								ElephantOnTable[i].ElefantThinking[0].HuristicListElefant[j][9] += ElephantOnTable[ii].ElefantThinking[0].HeuristicKingDangourSup;
								ElephantOnTable[i].ElefantThinking[0].IsSup[j] = false;

								AllDraw::OutPut += std::wstring(L"\r\nServed Elephant!");
							}
						}
					}
					ElephantOnTable[ii].ElefantThinking[0].HuristicAttackValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicMovementValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicSelfSupportedValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicKillerValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HuristicReducedAttackValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicKingSafeSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicFromCenterSup = 0;
					ElephantOnTable[ii].ElefantThinking[0].HeuristicKingDangourSup = 0;
				}
			}
		}
		else if (Kind == 3)
		{
			if (Order == 1)
			{
				{
				//if (HoursesOnTable[ii].HourseThinking[0].IsSup[j])
					for (int i = 0; i < HourseMidle; i++)
					{
						if (((&HoursesOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(HoursesOnTable[i].HourseThinking[0].TableListHourse, HoursesOnTable[ii].HourseThinking[0].TableConst);
						for (int j = 0; j < HoursesOnTable[i].HourseThinking[0].HuristicListHourse.size(); j++)
						{
							if (!(HoursesOnTable[i].HourseThinking[0].IsSup[j]))
							{
								continue;
							}

							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][0] += HoursesOnTable[ii].HourseThinking[0].HuristicAttackValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][1] += HoursesOnTable[ii].HourseThinking[0].HuristicMovementValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][2] += HoursesOnTable[ii].HourseThinking[0].HuristicSelfSupportedValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][3] += HoursesOnTable[ii].HourseThinking[0].HuristicObjectDangourCheckMateValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][4] += HoursesOnTable[ii].HourseThinking[0].HuristicKillerValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][5] += HoursesOnTable[ii].HourseThinking[0].HuristicReducedAttackValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][6] += HoursesOnTable[ii].HourseThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][7] += HoursesOnTable[ii].HourseThinking[0].HeuristicKingSafeSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][8] += HoursesOnTable[ii].HourseThinking[0].HeuristicFromCenterSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][9] += HoursesOnTable[ii].HourseThinking[0].HeuristicKingDangourSup;
							HoursesOnTable[i].HourseThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Hourse!");
						}
					}
					HoursesOnTable[ii].HourseThinking[0].HuristicAttackValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicMovementValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicSelfSupportedValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicKillerValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicReducedAttackValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicKingSafeSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicFromCenterSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicKingDangourSup = 0;
				}

			}
			else
			{
				{
				//if (HoursesOnTable[ii].HourseThinking[0].IsSup[j])
					for (int i = HourseMidle; i < HourseHight; i++)
					{
						if (((&HoursesOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(HoursesOnTable[i].HourseThinking[0].TableListHourse, HoursesOnTable[ii].HourseThinking[0].TableConst);
						for (int j = 0; j < HoursesOnTable[i].HourseThinking[0].HuristicListHourse.size(); j++)
						{
							if (!(HoursesOnTable[i].HourseThinking[0].IsSup[j]))
							{
								continue;
							}

							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][0] += HoursesOnTable[ii].HourseThinking[0].HuristicAttackValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][1] += HoursesOnTable[ii].HourseThinking[0].HuristicMovementValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][2] += HoursesOnTable[ii].HourseThinking[0].HuristicSelfSupportedValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][3] += HoursesOnTable[ii].HourseThinking[0].HuristicObjectDangourCheckMateValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][4] += HoursesOnTable[ii].HourseThinking[0].HuristicKillerValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][5] += HoursesOnTable[ii].HourseThinking[0].HuristicReducedAttackValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][6] += HoursesOnTable[ii].HourseThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][7] += HoursesOnTable[ii].HourseThinking[0].HeuristicKingSafeSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][8] += HoursesOnTable[ii].HourseThinking[0].HeuristicFromCenterSup;
							HoursesOnTable[i].HourseThinking[0].HuristicListHourse[j][9] += HoursesOnTable[ii].HourseThinking[0].HeuristicKingDangourSup;
							HoursesOnTable[i].HourseThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Hourse!");
						}
					}
					HoursesOnTable[ii].HourseThinking[0].HuristicAttackValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicMovementValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicSelfSupportedValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicKillerValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HuristicReducedAttackValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicKingSafeSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicFromCenterSup = 0;
					HoursesOnTable[ii].HourseThinking[0].HeuristicKingDangourSup = 0;
				}
			}
		}
		else if (Kind == 4)
		{
			if (Order == 1)
			{
				{
				//if (CastlesOnTable[ii].CastleThinking[0].IsSup[j])
					for (int i = 0; i < CastleMidle; i++)
					{
						if ((&(CastlesOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(CastlesOnTable[i].CastleThinking[0].TableListCastle, CastlesOnTable[ii].CastleThinking[0].TableConst);
						for (int j = 0; j < CastlesOnTable[i].CastleThinking[0].HuristicListCastle.size(); j++)
						{
							if (!(CastlesOnTable[i].CastleThinking[0].IsSup[j]))
							{
								continue;
							}

							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][0] += CastlesOnTable[ii].CastleThinking[0].HuristicAttackValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][1] += CastlesOnTable[ii].CastleThinking[0].HuristicMovementValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][2] += CastlesOnTable[ii].CastleThinking[0].HuristicSelfSupportedValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][3] += CastlesOnTable[ii].CastleThinking[0].HuristicObjectDangourCheckMateValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][4] += CastlesOnTable[ii].CastleThinking[0].HuristicKillerValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][5] += CastlesOnTable[ii].CastleThinking[0].HuristicReducedAttackValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][6] += CastlesOnTable[ii].CastleThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][7] += CastlesOnTable[ii].CastleThinking[0].HeuristicKingSafeSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][8] += CastlesOnTable[ii].CastleThinking[0].HeuristicFromCenterSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][9] += CastlesOnTable[ii].CastleThinking[0].HeuristicKingDangourSup;
							CastlesOnTable[i].CastleThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Castle!");
						}
					}
					CastlesOnTable[ii].CastleThinking[0].HuristicAttackValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicMovementValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicSelfSupportedValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicKillerValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicReducedAttackValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicKingSafeSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicFromCenterSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicKingDangourSup = 0;
				}
			}
			else
			{
				{
				//if (CastlesOnTable[ii].CastleThinking[0].IsSup[j])
					for (int i = CastleMidle; i < CastleHigh; i++)
					{
						if ((&(CastlesOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(CastlesOnTable[i].CastleThinking[0].TableListCastle, CastlesOnTable[ii].CastleThinking[0].TableConst);
						for (int j = 0; j < CastlesOnTable[i].CastleThinking[0].HuristicListCastle.size(); j++)
						{
							if (!(CastlesOnTable[i].CastleThinking[0].IsSup[j]))
							{
								continue;
							}


							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][0] += CastlesOnTable[ii].CastleThinking[0].HuristicAttackValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][1] += CastlesOnTable[ii].CastleThinking[0].HuristicMovementValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][2] += CastlesOnTable[ii].CastleThinking[0].HuristicSelfSupportedValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][3] += CastlesOnTable[ii].CastleThinking[0].HuristicObjectDangourCheckMateValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][4] += CastlesOnTable[ii].CastleThinking[0].HuristicKillerValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][5] += CastlesOnTable[ii].CastleThinking[0].HuristicReducedAttackValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][6] += CastlesOnTable[ii].CastleThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][7] += CastlesOnTable[ii].CastleThinking[0].HeuristicKingSafeSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][8] += CastlesOnTable[ii].CastleThinking[0].HeuristicFromCenterSup;
							CastlesOnTable[i].CastleThinking[0].HuristicListCastle[j][9] += CastlesOnTable[ii].CastleThinking[0].HeuristicKingDangourSup;
							CastlesOnTable[i].CastleThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Castle!");
						}
					}
					CastlesOnTable[ii].CastleThinking[0].HuristicAttackValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicMovementValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicSelfSupportedValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicKillerValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HuristicReducedAttackValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicKingSafeSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicFromCenterSup = 0;
					CastlesOnTable[ii].CastleThinking[0].HeuristicKingDangourSup = 0;
				}
			}
		}
		else
		{
		if (Kind == 5)
		{
			if (Order == 1)
			{
				{
				//if (MinisterOnTable[ii].MinisterThinking[0].IsSup[j])
					for (int i = 0; i < MinisterMidle; i++)
					{
						if (((&MinisterOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(MinisterOnTable[i].MinisterThinking[0].TableListMinister, MinisterOnTable[ii].MinisterThinking[0].TableConst);
						for (int j = 0; j < MinisterOnTable[i].MinisterThinking[0].HuristicListMinister.size(); j++)
						{
							if (!(MinisterOnTable[i].MinisterThinking[0].IsSup[j]))
							{
								continue;
							}

							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][0] += MinisterOnTable[ii].MinisterThinking[0].HuristicAttackValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][1] += MinisterOnTable[ii].MinisterThinking[0].HuristicMovementValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][2] += MinisterOnTable[ii].MinisterThinking[0].HuristicSelfSupportedValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][3] += MinisterOnTable[ii].MinisterThinking[0].HuristicObjectDangourCheckMateValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][4] += MinisterOnTable[ii].MinisterThinking[0].HuristicKillerValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][5] += MinisterOnTable[ii].MinisterThinking[0].HuristicReducedAttackValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][6] += MinisterOnTable[ii].MinisterThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][7] += MinisterOnTable[ii].MinisterThinking[0].HeuristicKingSafeSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][8] += MinisterOnTable[ii].MinisterThinking[0].HeuristicFromCenterSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][9] += MinisterOnTable[ii].MinisterThinking[0].HeuristicKingDangourSup;
							MinisterOnTable[i].MinisterThinking[0].IsSup[j] = false;


							AllDraw::OutPut += std::wstring(L"\r\nServed Minister!");
						}
					}
					MinisterOnTable[ii].MinisterThinking[0].HuristicAttackValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicMovementValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicSelfSupportedValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicKillerValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicReducedAttackValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicKingSafeSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicFromCenterSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicKingDangourSup = 0;
				}
			}
			else
			{
				{
				//if (MinisterOnTable[ii].MinisterThinking[0].IsSup[j])
					for (int i = MinisterMidle; i < MinisterHigh; i++)
					{
						if (((&MinisterOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(MinisterOnTable[i].MinisterThinking[0].TableListMinister, MinisterOnTable[ii].MinisterThinking[0].TableConst);
						for (int j = 0; j < MinisterOnTable[i].MinisterThinking[0].HuristicListMinister.size(); j++)
						{
							if (!(MinisterOnTable[i].MinisterThinking[0].IsSup[j]))
							{
								continue;
							}


							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][0] += MinisterOnTable[ii].MinisterThinking[0].HuristicAttackValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][1] += MinisterOnTable[ii].MinisterThinking[0].HuristicMovementValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][2] += MinisterOnTable[ii].MinisterThinking[0].HuristicSelfSupportedValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][3] += MinisterOnTable[ii].MinisterThinking[0].HuristicObjectDangourCheckMateValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][4] += MinisterOnTable[ii].MinisterThinking[0].HuristicKillerValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][5] += MinisterOnTable[ii].MinisterThinking[0].HuristicReducedAttackValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][6] += MinisterOnTable[ii].MinisterThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][7] += MinisterOnTable[ii].MinisterThinking[0].HeuristicKingSafeSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][8] += MinisterOnTable[ii].MinisterThinking[0].HeuristicFromCenterSup;
							MinisterOnTable[i].MinisterThinking[0].HuristicListMinister[j][9] += MinisterOnTable[ii].MinisterThinking[0].HeuristicKingDangourSup;
							MinisterOnTable[i].MinisterThinking[0].IsSup[j] = false;

							AllDraw::OutPut += std::wstring(L"\r\nServed Minister!");
						}
					}
					MinisterOnTable[ii].MinisterThinking[0].HuristicAttackValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicMovementValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicSelfSupportedValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicKillerValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HuristicReducedAttackValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicKingSafeSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicFromCenterSup = 0;
					MinisterOnTable[ii].MinisterThinking[0].HeuristicKingDangourSup = 0;
				}
			}
		}
		else
		{
		if (Kind == 6)
		{
			if (Order == 1)
			{
				{
				//if (KingOnTable[ii].KingThinking[0].IsSup[j])
					for (int i = 0; i < KingMidle; i++)
					{
						if ((&(KingOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(KingOnTable[i].KingThinking[0].TableListKing, KingOnTable[ii].KingThinking[0].TableConst);
						for (int j = 0; j < KingOnTable[i].KingThinking[0].HuristicListKing.size(); j++)
						{
							if (!(KingOnTable[i].KingThinking[0].IsSup[j]))
							{
								continue;
							}

							KingOnTable[i].KingThinking[0].HuristicListKing[j][0] += KingOnTable[ii].KingThinking[0].HuristicAttackValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][1] += KingOnTable[ii].KingThinking[0].HuristicMovementValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][2] += KingOnTable[ii].KingThinking[0].HuristicSelfSupportedValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][3] += KingOnTable[ii].KingThinking[0].HuristicObjectDangourCheckMateValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][4] += KingOnTable[ii].KingThinking[0].HuristicKillerValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][5] += KingOnTable[ii].KingThinking[0].HuristicReducedAttackValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][6] += KingOnTable[ii].KingThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][7] += KingOnTable[ii].KingThinking[0].HeuristicKingSafeSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][8] += KingOnTable[ii].KingThinking[0].HeuristicFromCenterSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][9] += KingOnTable[ii].KingThinking[0].HeuristicKingDangourSup;
							KingOnTable[i].KingThinking[0].IsSup[j] = false;


							AllDraw::OutPut += std::wstring(L"\r\nServed King!");
						}
					}
					KingOnTable[ii].KingThinking[0].HuristicAttackValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicMovementValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicSelfSupportedValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicKillerValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicReducedAttackValueSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicKingSafeSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicFromCenterSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicKingDangourSup = 0;

				}
			}
			else
			{
				{
				//if (KingOnTable[ii].KingThinking[0].IsSup[j])
					for (int i = KingMidle; i < KingHigh; i++)
					{
						if ((&(KingOnTable[i]) == nullptr))
						{
							continue;
						}
						//int j = FoundTableIndex(KingOnTable[i].KingThinking[0].TableListKing, KingOnTable[ii].KingThinking[0].TableConst);
						for (int j = 0; j < KingOnTable[i].KingThinking[0].HuristicListKing.size(); j++)
						{
							if (!(KingOnTable[i].KingThinking[0].IsSup[j]))
							{
								continue;
							}


							KingOnTable[i].KingThinking[0].HuristicListKing[j][0] += KingOnTable[ii].KingThinking[0].HuristicAttackValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][1] += KingOnTable[ii].KingThinking[0].HuristicMovementValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][2] += KingOnTable[ii].KingThinking[0].HuristicSelfSupportedValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][3] += KingOnTable[ii].KingThinking[0].HuristicObjectDangourCheckMateValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][4] += KingOnTable[ii].KingThinking[0].HuristicKillerValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][5] += KingOnTable[ii].KingThinking[0].HuristicReducedAttackValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][6] += KingOnTable[ii].KingThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][7] += KingOnTable[ii].KingThinking[0].HeuristicKingSafeSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][8] += KingOnTable[ii].KingThinking[0].HeuristicFromCenterSup;
							KingOnTable[i].KingThinking[0].HuristicListKing[j][9] += KingOnTable[ii].KingThinking[0].HeuristicKingDangourSup;
							KingOnTable[i].KingThinking[0].IsSup[j] = false;


							AllDraw::OutPut += std::wstring(L"\r\nServed King!");
						}
					}
					KingOnTable[ii].KingThinking[0].HuristicAttackValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicMovementValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicSelfSupportedValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicObjectDangourCheckMateValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicKillerValueSup = 0;
					KingOnTable[ii].KingThinking[0].HuristicReducedAttackValueSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicKingSafeSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicFromCenterSup = 0;
					KingOnTable[ii].KingThinking[0].HeuristicKingDangourSup = 0;

				}
			}
		}
		}
		}
	}

	void AllDraw::InitiateAStarGreedytSodlerGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		//List<Task> tH = new List<Task>();
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{

			//For Gray Soldeirs Objects. 
			//Parallel::For(0, SodierMidle, [&] (void *i) //);
			for (int i = 0; i < SodierMidle; i++)
						//If Solders Not Exist Continue and Traversal Back.
							//Initiate of Local Variables By Global Objective Gray Current Solder.
							//Construction of Thinking Gray Soldier By Local Variables.
							//If There is no Thinking Movments on Current Object  
								//For All Movable Gray Solders.
								////Parallel.For(0, AllDraw.SodierMovments, j =>
									//Thinking of Gray Solder Operation.
										//ServeISSup(Order,1, i);
						// SolderesOnTable[i] = null;
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr))
						{
							ii = SolderesOnTable[i].Row;
							jj = SolderesOnTable[i].Column;
							if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.empty())
							{
								SolderesOnTable[i] = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										SolderesOnTable[i].SoldierThinking[0].ThinkingBegin = true;
										SolderesOnTable[i].SoldierThinking[0].ThinkingFinished = false;
										SolderesOnTable[i].SoldierThinking[0].Thinking(SolderesOnTable[i].LoseOcuuredatChiled, SolderesOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));

		return ;
	}

	void AllDraw::InitiateAStarGreedytElephantGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//Parallel::For(0, ElefantMidle, [&] (void *i) //);
			for (int i = 0; i < ElefantMidle; i++)
						//Ignore of Non Exist Current Elephant Gray Objects.
							//Inititae Local Varibale By Global Gray Elephant Objects Varibales.
							//Construction of Thinking Objects By Local Varibales.
							//If There is Not Thinking Objetive List Elephant Gray. 
								//For All Possible Movments.
								////Parallel.For(0, AllDraw.ElefantMovments, j =>
									//Operational Thinking Gray Elephant. 
										//ServeISSup(Order,2, i);
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr))
						{
							ii = ElephantOnTable[i].Row;
							jj = ElephantOnTable[i].Column;
							if (ElephantOnTable[i].ElefantThinking[0].TableListElefant.empty())
							{
								ElephantOnTable[i] = DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (ElephantOnTable[i].ElefantThinking[0].TableListElefant.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										ElephantOnTable[i].ElefantThinking[0].ThinkingBegin = true;
										ElephantOnTable[i].ElefantThinking[0].ThinkingFinished = false;
										ElephantOnTable[i].ElefantThinking[0].Thinking(ElephantOnTable[i].LoseOcuuredatChiled, ElephantOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythHourseGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//For All Gray Hourse Objects.
			//Parallel::For(0, HourseMidle, [&] (void *i) //);
			for (int i = 0; i < HourseMidle; i++)
						//Ignore of Non Exist Current Gray Hourse Objects.
							//Initiate of Local Variables By Global Gray Hourse Objectives.
							//Construction of Gray Hourse Thinking Objects..
							//When There is Not HourseList Count. 
								//For All Possible Movments.
								////Parallel.For(0, AllDraw.HourseMovments, j =>
									//Thinking of Gray Hourse Oprational.
										//ServeISSup(Order,3, i);
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr))
						{
							ii = HoursesOnTable[i].Row;
							jj = HoursesOnTable[i].Column;
							if (HoursesOnTable[i].HourseThinking[0].TableListHourse.empty())
							{
								HoursesOnTable[i] = DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (HoursesOnTable[i].HourseThinking[0].TableListHourse.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										HoursesOnTable[i].HourseThinking[0].ThinkingBegin = true;
										HoursesOnTable[i].HourseThinking[0].ThinkingFinished = false;
										HoursesOnTable[i].HourseThinking[0].Thinking(HoursesOnTable[i].LoseOcuuredatChiled, HoursesOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythCastleGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//For All Possible Gray Castles Objects.
			//Parallel::For(0, CastleMidle, [&] (void *i)
			for (int i = 0; i < CastleMidle; i++)
						//When Current Castles Gray Not Exist Continue Traversal Back.
							//Initaiate of Local Varibales By Global Varoiables.
							//Construction of Thinking Variables By Local Variables.
							//When Count of Table Castles of Thinking Not Exist Do Operational.
								//For All Possible Movments.
								////Parallel.For(0, AllDraw.CastleMovments, j =>
										//Thinking of Gray Castles Operational.
										//ServeISSup(Order,4, i);
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr))
						{
							ii = CastlesOnTable[i].Row;
							jj = CastlesOnTable[i].Column;
							if (CastlesOnTable[i].CastleThinking[0].TableListCastle.empty())
							{
								CastlesOnTable[i] = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (CastlesOnTable[i].CastleThinking[0].TableListCastle.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										CastlesOnTable[i].CastleThinking[0].ThinkingBegin = true;
										CastlesOnTable[i].CastleThinking[0].ThinkingFinished = false;
										CastlesOnTable[i].CastleThinking[0].Thinking(CastlesOnTable[i].LoseOcuuredatChiled, CastlesOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythMinisterGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//For All Possible Gray Minister Movments.
			//Parallel::For(0, MinisterMidle, [&] (void *i)
			for (int i = 0; i < MinisterMidle; i++)
						//For Each Non Exist Gray Minister Objectives.
							//Inititate Local Variables By Global Varibales.
							//Construction of Thinking Objects Gray Minister.
							//If There is Not Minister Of Gray In The Thinking Table List.   
								//For All Possible Movments.
								// //Parallel.For(0, AllDraw.MinisterMovments, j =>
									//Thinking of Gray Minister Operational.
										//ServeISSup(Order,5, i);
			{
				
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr))
						{
							ii = MinisterOnTable[i].Row;
							jj = MinisterOnTable[i].Column;
							if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.empty())
							{
								MinisterOnTable[i] = DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										MinisterOnTable[i].MinisterThinking[0].ThinkingBegin = true;
										MinisterOnTable[i].MinisterThinking[0].ThinkingFinished = false;
										MinisterOnTable[i].MinisterThinking[0].Thinking(MinisterOnTable[i].LoseOcuuredatChiled, MinisterOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
					}
			
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythKingGray(int iii, int jjjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//For All Possible Gray King Objects.
			//Parallel::For(0, KingMidle, [&] (void *i) //);
			for (int i = 0; i < KingMidle; i++)
						//If There is Not Current Object Continue Traversal Back.
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Gray King Thinking Objects.
							//When There is Not Thinking Table Gray King Movments.
								//For All Possible Gray King Movments.
								////Parallel.For(0, AllDraw.KingMovments, j =>
									//Thinking Of Gray King Operatins.
										//ServeISSup(Order,6, i);
						// KingOnTable[i] = null;
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr))
						{
							ii = static_cast<int>(KingOnTable[i].Row);
							jj = KingOnTable[i].Column;
							if (KingOnTable[i].KingThinking[0].TableListKing.empty())
							{
								KingOnTable[i] = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (KingOnTable[i].KingThinking[0].TableListKing.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										KingOnTable[i].KingThinking[0].ThinkingBegin = true;
										KingOnTable[i].KingThinking[0].ThinkingFinished = false;
										KingOnTable[i].KingThinking[0].Thinking(KingOnTable[i].LoseOcuuredatChiled, KingOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythSoldierBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//For Each Objects of Brown Sodiers.
			//Parallel::For(SodierMidle, SodierHigh, [&] (void *i)
			for (int i = SodierMidle; i < SodierHigh; i++)
						//Wheen Brown King Object There is Not Continue Traversal Back.
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Thinking Brown Current Objects.
								//When There is Current Brown Object Table List Thinking Objective Movments.
									//For Each Brown Possible Movments. 
									////Parallel.For(0, AllDraw.SodierMovments, j =>
										//Thinking Operations of Brown Current Objects.
											//ServeISSup(Order,1, i);
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr))
						{
							ii = SolderesOnTable[i].Row;
							jj = SolderesOnTable[i].Column;
							if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.empty())
							{
								SolderesOnTable[i] = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							{
								if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.empty())
								{
									{
										////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (OOO)
										{
											SolderesOnTable[i].SoldierThinking[0].ThinkingBegin = true;
											SolderesOnTable[i].SoldierThinking[0].ThinkingFinished = false;
											SolderesOnTable[i].SoldierThinking[0].Thinking(SolderesOnTable[i].LoseOcuuredatChiled, SolderesOnTable[i].WinOcuuredatChiled);
										}
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythElephantBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
		   //Parallel::For(ElefantMidle, ElefantHigh, [&] (void *i)
		   for (int i = ElefantMidle; i < ElefantHigh; i++)
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Thinking Brown Current Objects.
								//When There is Current Brown Object Table List Thinking Objective Movments.
									//For Each Brown Possible Movments. 
									////Parallel.For(0, AllDraw.ElefantMovments, j =>
											//Thinking Operations of Brown Current Objects.
											//ServeISSup(Order,2, i);
		   {
			   ////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			   //lock (O)
			   {
				   
					   Order = DummyOrder;
					   ChessRules::CurrentOrder = DummyCurrentOrder;
					   if (((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr))
					   {
						   ii = ElephantOnTable[i].Row;
						   jj = ElephantOnTable[i].Column;
						   if (ElephantOnTable[i].ElefantThinking[0].TableListElefant.empty())
						   {
							   ElephantOnTable[i] = DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
						   }
						   {
							   if (ElephantOnTable[i].ElefantThinking[0].TableListElefant.empty())
							   {
								   {
									   ////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									   //lock (OOO)
									   {
										   ElephantOnTable[i].ElefantThinking[0].ThinkingBegin = true;
										   ElephantOnTable[i].ElefantThinking[0].ThinkingFinished = false;
										   ElephantOnTable[i].ElefantThinking[0].Thinking(ElephantOnTable[i].LoseOcuuredatChiled, ElephantOnTable[i].WinOcuuredatChiled);
									   }
								   }
							   }
						   }
					   }
				  
			   }
		   }//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythHourseBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
		   //Parallel::For(HourseMidle, HourseHight, [&] (void *i)
		   for (int i = HourseMidle; i < HourseHight; i++)
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Thinking Brown Current Objects.
								//When There is Current Brown Object Table List Thinking Objective Movments.
									//For Each Brown Possible Movments. 
									////Parallel.For(0, AllDraw.HourseMovments, j =>
											//Thinking Operations of Brown Current Objects.
											//HoursesOnTable[i].HourseThinking[0].TableT = HoursesOnTable[i].HourseThinking[0].TableT;
											//ServeISSup(Order,3, i);
		   {
			   ////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			   //lock (O)
			   {
				   
					   Order = DummyOrder;
					   ChessRules::CurrentOrder = DummyCurrentOrder;
					   if (((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr))
					   {
						   ii = HoursesOnTable[i].Row;
						   jj = HoursesOnTable[i].Column;
						   if (HoursesOnTable[i].HourseThinking[0].TableListHourse.empty())
						   {
							   HoursesOnTable[i] = DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
						   }
						   {
							   if (HoursesOnTable[i].HourseThinking[0].TableListHourse.empty())
							   {
								   {
									   ////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									   //lock (OOO)
									   {
										   HoursesOnTable[i].HourseThinking[0].ThinkingBegin = true;
										   HoursesOnTable[i].HourseThinking[0].ThinkingFinished = false;
										   HoursesOnTable[i].HourseThinking[0].Thinking(HoursesOnTable[i].LoseOcuuredatChiled, HoursesOnTable[i].WinOcuuredatChiled);
									   }
								   }
							   }
						   }
					   }
				  
			   }
		   }//);
		}

		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythCastleBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//Parallel::For(CastleMidle, CastleHigh, [&] (void *i)
			for (int i = CastleMidle; i < CastleHigh; i++)
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Thinking Brown Current Objects.
								//When There is Current Brown Object Table List Thinking Objective Movments.
									//For Each Brown Possible Movments. 
									////Parallel.For(0, AllDraw.CastleMovments, j =>
											//Thinking Operations of Brown Current Objects.
											//ServeISSup(Order,4, i);
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr))
						{
							ii = CastlesOnTable[i].Row;
							jj = CastlesOnTable[i].Column;
							if (CastlesOnTable[i].CastleThinking[0].TableListCastle.empty())
							{
								CastlesOnTable[i] = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							{
								if (CastlesOnTable[i].CastleThinking[0].TableListCastle.empty())
								{
									{
										////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (OOO)
										{
											CastlesOnTable[i].CastleThinking[0].ThinkingBegin = true;
											CastlesOnTable[i].CastleThinking[0].ThinkingFinished = false;
											CastlesOnTable[i].CastleThinking[0].Thinking(CastlesOnTable[i].LoseOcuuredatChiled, CastlesOnTable[i].WinOcuuredatChiled);
										}
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythMinisterBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//Parallel::For(MinisterMidle, MinisterHigh, [&] (void *i) //);
			for (int i = MinisterMidle; i < MinisterHigh; i++)
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Thinking Brown Current Objects.
							//When There is Current Brown Object Table List Thinking Objective Movments.
								//For Each Brown Possible Movments. 
								////Parallel.For(0, AllDraw.MinisterMovments, j =>
										//Thinking Operations of Brown Current Objects.
										//ServeISSup(Order,5, i);
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr))
						{
							ii = MinisterOnTable[i].Row;
							jj = MinisterOnTable[i].Column;
							if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.empty())
							{
								MinisterOnTable[i] = DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										MinisterOnTable[i].MinisterThinking[0].ThinkingBegin = true;
										MinisterOnTable[i].MinisterThinking[0].ThinkingFinished = false;
										MinisterOnTable[i].MinisterThinking[0].Thinking(MinisterOnTable[i].LoseOcuuredatChiled, MinisterOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	void AllDraw::InitiateAStarGreedythKingBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy)
	{
		////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{
			//List<Task> tH = new List<Task>();
			//Parallel::For(KingMidle, KingHigh, [&] (void *i)
			for (int i = KingMidle; i < KingHigh; i++)
							//Initiate Local varibale By Global Objective Varibales.
							//Construction of Thinking Brown Current Objects.
							//When There is Current Brown Object Table List Thinking Objective Movments.
								//For Each Brown Possible Movments. 
								////Parallel.For(0, AllDraw.KingMovments, j =>
										//Thinking Operations of Brown Current Objects.
										//ServeISSup(Order,6, i);
						//KingOnTable[i] = null;
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					
						Order = DummyOrder;
						ChessRules::CurrentOrder = DummyCurrentOrder;
						if (((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr))
						{
							ii = KingOnTable[i].Row;
							jj = KingOnTable[i].Column;
							if (KingOnTable[i].KingThinking[0].TableListKing.empty())
							{
								KingOnTable[i] = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
							}
							if (KingOnTable[i].KingThinking[0].TableListKing.empty())
							{
								{
									////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (OOO)
									{
										KingOnTable[i].KingThinking[0].ThinkingBegin = true;
										KingOnTable[i].KingThinking[0].ThinkingFinished = false;
										KingOnTable[i].KingThinking[0].Thinking(KingOnTable[i].LoseOcuuredatChiled, KingOnTable[i].WinOcuuredatChiled);
									}
								}
							}
						}
				
				}
			}//);
		}
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		return ;
	}

	bool AllDraw::FullBoundryConditions(int Current, int Order, int iAStarGreedy)
	{
		//if (TimerEnded)
		//return true;

		bool IS = false;
		////if (iAStarGreedy < 0)
		//    IS = true;
		if (Order == 1)
		{
			for (int ikk = 0; ikk < SodierMidle; ikk++)
			{
				if ((&(SolderesOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (SolderesOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = 0; ikk < ElefantMidle; ikk++)
			{
				if ((&(ElephantOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (ElephantOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = 0; ikk < HourseMidle; ikk++)
			{
				if ((&(HoursesOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (HoursesOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = 0; ikk < CastleMidle; ikk++)
			{
				if ((&(CastlesOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (CastlesOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = 0; ikk < MinisterMidle; ikk++)
			{
				if ((&(MinisterOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (MinisterOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = 0; ikk < KingMidle; ikk++)
			{
				if ((&(KingOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (KingOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			if ((ThinkingChess::FoundFirstMating >= MaxAStarGreedy)) //|| (SetDeptIgnore))
			{
				OutPut += std::wstring(L"\r\nCheckedMate Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstMating);
				IS = true;
			}
			//else
			//if (iAStarGreedy < 0)
			/*{
			    iAStarGreedy = MaxAStarGreedy;
			    OutPut += "\r\nLevel Boundry Conditon for iAStarGreedy is Set To " + iAStarGreedy.ToString() + "MaxAStarGreedy";
			}*/
		}
		else
		{
			for (int ikk = SodierMidle; ikk < SodierHigh; ikk++)
			{
				if ((&(SolderesOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (SolderesOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = ElefantMidle; ikk < ElefantHigh; ikk++)
			{
				if ((&(ElephantOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (ElephantOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = HourseMidle; ikk < HourseHight; ikk++)
			{
				if ((&(HoursesOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (HoursesOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = CastleMidle; ikk < CastleHigh; ikk++)
			{
				if ((&(CastlesOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (CastlesOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = MinisterMidle; ikk < MinisterHigh; ikk++)
			{
				if ((&(MinisterOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (MinisterOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			for (int ikk = KingMidle; ikk < KingHigh; ikk++)
			{
				if ((&(KingOnTable[ikk]) == nullptr))
				{
					continue;
				}
				if (KingOnTable[ikk].LoseOcuuredatChiled < -1)
				{
					OutPut += std::wstring(L"\r\nCheckedMate SELF Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating);
					IS = true;
				}
			}
			if ((ThinkingChess::FoundFirstMating >= MaxAStarGreedy)) //|| (SetDeptIgnore))
			{
				OutPut += std::wstring(L"\r\nCheckedMate Boundry Conditon in Leafs found at  ") + StringConverterHelper::toString(ThinkingChess::FoundFirstMating);
				IS = true;
			}
		   /* else
		    //if (iAStarGreedy < 0)
		    {
		        iAStarGreedy = MaxAStarGreedy;
		        OutPut += "\r\nLevel Boundry Conditon for iAStarGreedy is Set To " + iAStarGreedy.ToString() + "MaxAStarGreedy";
		    }*/
		}
		return IS;
	} //AStarGreedy First Initiat Thinking Main Method.

	void AllDraw::AStarGreedyThinking(int Order, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int i, int j, int ii, int jj, int **Table, int a, bool TB, bool FOUND, int LeafAStarGreedy)
	{


		//If Order is Gray.
		if (Order == 1)
		{
			int i1 = i, j1 = j;
			//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
			//ORIGINAL LINE: int[,] Tab = CloneATable(Table);
			int **Tab = CloneATable(Table);
			int DummyOrder1 = DummyOrder, DummyCurrentOrder1 = DummyCurrentOrder, iAStarGreedy1 = iAStarGreedy, ii1 = ii, jj1 = jj, Ord1 = Order;
			bool TB1 = TB;
			int aa = a;

			InitiateAStarGreedytSodlerGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedytElephantGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythHourseGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythCastleGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythMinisterGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythKingGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

		}
		else //Brown Order Considarations.
		{
			int i1 = i, j1 = j;
			//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
			//ORIGINAL LINE: int[,] Tab = CloneATable(Table);
			int **Tab = CloneATable(Table);
			int DummyOrder1 = DummyOrder, DummyCurrentOrder1 = DummyCurrentOrder, iAStarGreedy1 = iAStarGreedy, ii1 = ii, jj1 = jj, Ord1 = Order;
			bool TB1 = TB;
			int aa = a;
			//If Order is Gray.

			InitiateAStarGreedythSoldierBrown(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythElephantBrown(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythHourseBrown(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythCastleBrown(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedythMinisterBrown(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);

			InitiateAStarGreedytElephantGray(i1, j1, Tabl, DummyOrder1, DummyCurrentOrder1, iAStarGreedy1, ii1, jj1, aa, Tab, Ord1, TB1, FOUND, LeafAStarGreedy);
		}


	}
	void AllDraw::InitiateAStarGreedytObjectGray(int iii, int jjj, int** Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int** Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy //,  Refrigtz.Timer timer,  Refrigtz.Timer Timerint,  double Less
	)
	{
		
		for (int i = 0; i < MaxGrayMidle(); i++)
		{

			if (SodierMidle > i)
			{

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
				//If Solders Not Exist Continue and Traversal Back.
				if (((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr))
				{
					//Initiate of Local Variables By Global Objective Gray Current Solder.
					ii = (int)SolderesOnTable[i].Row;
					jj = (int)SolderesOnTable[i].Column;
					//If There is no Thinking Movments on Current Object  
					if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.size() == 0)
					{
						//For All Movable Gray Solders.
						for (int j = 0; j < AllDraw::SodierMovments; j++)
						{
							SolderesOnTable[i].SoldierThinking[0].ThinkingBegin = true;
							SolderesOnTable[i].SoldierThinking[0].ThinkingFinished = false;
							SolderesOnTable[i].SoldierThinking[0].Kind = 1;
							SolderesOnTable[i].SoldierThinking[j].Thinking(SolderesOnTable[i].LoseOcuuredatChiled, SolderesOnTable[i].WinOcuuredatChiled);

						}

					}
				}

			}
			if (MinisterMidle > i)
			{


				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
				//For Each Non Exist Gray Minister Objectives.
				if (((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr))
				{
					//Inititate Local Variables By Global Varibales.
					ii = (int)MinisterOnTable[i].Row;
					jj = (int)MinisterOnTable[i].Column;
					//Construction of Thinking Objects Gray Minister.
					//if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.size() == 0)
					//MinisterOnTable[i] = DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//If There is Not Minister Of Gray In The Thinking Table List.   
					if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.size() == 0)
					{
						//For All Possible Movments.
						for (int j = 0; j < AllDraw::MinisterMovments; j++)
						{

							MinisterOnTable[i].MinisterThinking[0].ThinkingBegin = true;
							MinisterOnTable[i].MinisterThinking[0].ThinkingFinished = false;
							MinisterOnTable[i].MinisterThinking[0].Kind = 5;
							MinisterOnTable[i].MinisterThinking[0].Thinking(MinisterOnTable[i].LoseOcuuredatChiled, MinisterOnTable[i].WinOcuuredatChiled);

						}


					}
				}
			}


			if (KingMidle > i)
			{

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
				//If There is Not Current Object Continue Traversal Back.
				if (((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr))
				{
					//Initiate Local varibale By Global Objective Varibales.
					ii = (int)(int)KingOnTable[i].Row;
					jj = (int)KingOnTable[i].Column;
					//Construction of Gray King Thinking Objects.
					//if (KingOnTable[i].KingThinking[0].TableListKing.size() == 0)
					//KingOnTable[i] = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//When There is Not Thinking Table Gray King Movments.
					if (KingOnTable[i].KingThinking[0].TableListKing.size() == 0)
					{
						//For All Possible Gray King Movments.
						////Parallel.For(0, AllDraw::KingMovments, j =>
						for (int j = 0; j < AllDraw::KingMovments; j++)
						{

							KingOnTable[i].KingThinking[0].ThinkingBegin = true;
							KingOnTable[i].KingThinking[0].ThinkingFinished = false;
							KingOnTable[i].KingThinking[0].Kind = 6;
							KingOnTable[i].KingThinking[0].Thinking(MinisterOnTable[i].LoseOcuuredatChiled, MinisterOnTable[i].WinOcuuredatChiled);
						}
					}
				}
			}

		}
		return ;
	}
	int AllDraw::MaxBrownHigh()
	{

			int* Tab = new int[6];
			Tab[0] = SodierHigh;
			Tab[1] = ElefantHigh;
			Tab[2] = HourseHight;
			Tab[3] = CastleHigh;
			Tab[4] = MinisterHigh;
			Tab[5] = KingHigh;
			int Max = 0;
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] > Max)
					Max = Tab[i];
			}
			return Max;
		
	}
	int AllDraw::MinBrownMidle()
	{
		

			int* Tab = new int[6];
			Tab[0] = SodierHigh;
			Tab[1] = ElefantHigh;
			Tab[2] = HourseHight;
			Tab[3] = CastleHigh;
			Tab[4] = MinisterHigh;
			Tab[5] = KingHigh;
			int Min = MaxBrownHigh();
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] < Min)
					Min = Tab[i];
			}
			return Min;
		
	}
	int AllDraw::MaxBrownHigh()
	{

			int* Tab = new int[6];
			Tab[0] = SodierHigh;
			Tab[1] = ElefantHigh;
			Tab[2] = HourseHight;
			Tab[3] = CastleHigh;
			Tab[4] = MinisterHigh;
			Tab[5] = KingHigh;
			int Max = 0;
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] > Max)
					Max = Tab[i];
			}
			return Max;
		
	}
	int AllDraw::MinBrownMidle()
	{
		

			int* Tab = new int[6];
			Tab[0] = SodierHigh;
			Tab[1] = ElefantHigh;
			Tab[2] = HourseHight;
			Tab[3] = CastleHigh;
			Tab[4] = MinisterHigh;
			Tab[5] = KingHigh;
			int Min = MaxBrownHigh();
			for (int i = 0; i < 6; i++)
			{
				if (Tab[i] < Min)
					Min = Tab[i];
			}
			return Min;
		
	}

	void AllDraw::InitiateAStarGreedytObjectBrown(int iii, int jjj, int** Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int** Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy//,  Refrigtz.Timer timer,  Refrigtz.Timer Timerint,  double Less
	)
	{
		////Object oo = new Object();
		////lock(oo)
		{
			////Parallel.For(MinBrownMidle(), MaxBrownHigh(), i =>
			for (int i = MinBrownMidle(); i < MaxBrownHigh(); i++)
			{

				//Parallel.Invoke(() =>
				{
					//Object ooo = new Object();
					//lock(ooo)
					{
						if (SodierMidle <= i && SodierHigh > i)
						{
							//Object O = new Object();
							//lock(O)
							{
								
									Order = DummyOrder;
									ChessRules::CurrentOrder = DummyCurrentOrder;
									//If Solders Not Exist Continue and Traversal Back.
									if (((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr))
									{
										//Initiate of Local Variables By Global Objective Gray Current Solder.
										ii = (int)SolderesOnTable[i].Row;
										jj = (int)SolderesOnTable[i].Column;
										//Construction of Thinking Gray Soldier By Local Variables.
										//if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.size() == 0)
										//SolderesOnTable[i] = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
										//If There is no Thinking Movments on Current //Object  

										if (SolderesOnTable[i].SoldierThinking[0].TableListSolder.size() == 0)
										{
											//For All Movable Gray Solders.
											for (int j = 0; j < AllDraw::SodierMovments; j++)
												////Parallel.For(0, AllDraw::SodierMovments, j =>
											{
												//Thinking of Gray Solder Operation.
												//Object OOO = new Object();
												//lock(OOO)
												{
													SolderesOnTable[i].SoldierThinking[0].ThinkingBegin = true;
													SolderesOnTable[i].SoldierThinking[0].ThinkingFinished = false;
													SolderesOnTable[i].SoldierThinking[0].Kind = 1;
													SolderesOnTable[i].SoldierThinking[0].Thinking( SolderesOnTable[i].LoseOcuuredatChiled,  SolderesOnTable[i].WinOcuuredatChiled);/*.t = new Task(new Action(SolderesOnTable[i].SoldierThinking[0].Thinking));
																																														  SolderesOnTable[i].SoldierThinking[0].t.Start();*/
												}
											}//);
										}
									}
								
							}
						}
					}
				}//,() =>
				{
					//Object oooo = new Object();
					//lock(oooo)
					{

						if (ElefantMidle <= i && ElefantHigh > i)
						{

							//Object O = new Object();
							//lock(O)
							{
								
									Order = DummyOrder;
									ChessRules::CurrentOrder = DummyCurrentOrder;
									//Ignore of Non Exist Current Elephant Gray Objects.
									if (((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr))
									{
										//Inititae Local Varibale By Global Gray Elephant Objects Varibales.
										ii = (int)ElephantOnTable[i].Row;
										jj = (int)ElephantOnTable[i].Column;
										//Construction of Thinking Objects By Local Varibales.
										//if (ElephantOnTable[i].ElefantThinking[0].TableListElefant.size() == 0)
										//ElephantOnTable[i] = DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
										//If There is Not Thinking Objetive List Elephant Gray. 
										if (ElephantOnTable[i].ElefantThinking[0].TableListElefant.size() == 0)
										{
											//For All Possible Movments.
											////Parallel.For(0, AllDraw::ElefantMovments, j =>
											for (int j = 0; j < AllDraw::ElefantMovments; j++)
											{
												//Operational Thinking Gray Elephant. 
												//Object OOO = new Object();
												//lock(OOO)
												{
													ElephantOnTable[i].ElefantThinking[0].ThinkingBegin = true;
													ElephantOnTable[i].ElefantThinking[0].ThinkingFinished = false;
													ElephantOnTable[i].ElefantThinking[0].Kind = 2;
													ElephantOnTable[i].ElefantThinking[0].Thinking( ElephantOnTable[i].LoseOcuuredatChiled,  ElephantOnTable[i].WinOcuuredatChiled);/*.t = new Task(new Action(ElephantOnTable[i].ElefantThinking[0].Thinking));
																																														  ElephantOnTable[i].ElefantThinking[0].t.Start();*/
												}
											}//);
										}
									}
								
							}
						}
					}
				}//,() =>
				{
					//Object oooo = new Object();
					//lock(oooo)
					{

						if (HourseMidle <= i && HourseHight > i)
						{

							//Object O = new Object();
							//lock(O)
							{
									Order = DummyOrder;
									ChessRules::CurrentOrder = DummyCurrentOrder;
									//Ignore of Non Exist Current Gray Hourse Objects.
									if (((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr))
									{
										//Initiate of Local Variables By Global Gray Hourse Objectives.
										ii = (int)HoursesOnTable[i].Row;
										jj = (int)HoursesOnTable[i].Column;
										//Construction of Gray Hourse Thinking Objects..
										//if (HoursesOnTable[i].HourseThinking[0].TableListHourse.size() == 0)
										//HoursesOnTable[i] = DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
										//When There is Not HourseList Count. 
										if (HoursesOnTable[i].HourseThinking[0].TableListHourse.size() == 0)
										{
											//For All Possible Movments.
											for (int j = 0; j < AllDraw::HourseMovments; j++)
												////Parallel.For(0, AllDraw::HourseMovments, j =>
											{
												//Thinking of Gray Hourse Oprational.
												//Object OOO = new Object();
												//lock(OOO)
												{
													HoursesOnTable[i].HourseThinking[0].ThinkingBegin = true;
													HoursesOnTable[i].HourseThinking[0].ThinkingFinished = false;
													HoursesOnTable[i].HourseThinking[0].Kind = 3;
													HoursesOnTable[i].HourseThinking[0].Thinking( HoursesOnTable[i].LoseOcuuredatChiled,  HoursesOnTable[i].WinOcuuredatChiled);/*.t = new Task(new Action(HoursesOnTable[i].HourseThinking[0].Thinking));
																																													  HoursesOnTable[i].HourseThinking[0].t.Start();*/
												}
											}//);
										}
									}
								
							}
						}
					}

				}//,() =>
				{
					//Object oooo = new Object();
					//lock(oooo)
					{

						if (CastleMidle <= i && CastleHigh < i)
						{
							//Object O = new Object();
							//lock(O)
							{

								Order = DummyOrder;
								ChessRules::CurrentOrder = DummyCurrentOrder;
								//When Current Castles Gray Not Exist Continue Traversal Back.
								if (((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr))
								{
									//Initaiate of Local Varibales By Global Varoiables.
									ii = (int)CastlesOnTable[i].Row;
									jj = (int)CastlesOnTable[i].Column;
									//Construction of Thinking Variables By Local Variables.
									//if (CastlesOnTable[i].CastleThinking[0].TableListCastle.size() == 0)
									//CastlesOnTable[i] = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
									//When Count of Table Castles of Thinking Not Exist Do Operational.
									if (CastlesOnTable[i].CastleThinking[0].TableListCastle.size() == 0)
									{
										//For All Possible Movments.
										////Parallel.For(0, AllDraw::CastleMovments, j =>
										for (int j = 0; j < AllDraw::CastleMovments; j++)
										{
											//Object OOO = new Object();
											//lock(OOO)
											{
												//Thinking of Gray Castles Operational.
												CastlesOnTable[i].CastleThinking[0].ThinkingBegin = true;
												CastlesOnTable[i].CastleThinking[0].ThinkingFinished = false;
												CastlesOnTable[i].CastleThinking[0].Kind = 4;
												CastlesOnTable[i].CastleThinking[0].Thinking( CastlesOnTable[i].LoseOcuuredatChiled,  CastlesOnTable[i].WinOcuuredatChiled);/*.t = new Task(new Action(HoursesOnTable[i].HourseThinking[0].Thinking));
																																												  CastlesOnTable[i].CastleThinking[0].t.Start();*/
											}
										}//);
									}
								}
							}
						}
					}
				}//,() =>
				{
					//Object oooo = new Object();
					//lock(oooo)
					{

						

							if (MinisterMidle <= i && MinisterHigh > i)
							{
								//Object O = new Object();
								//lock(O)
								{
									Order = DummyOrder;
									ChessRules::CurrentOrder = DummyCurrentOrder;
									//For Each Non Exist Gray Minister Objectives.
									if (((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr))
									{
										//Inititate Local Variables By Global Varibales.
										ii = (int)MinisterOnTable[i].Row;
										jj = (int)MinisterOnTable[i].Column;
										//Construction of Thinking Objects Gray Minister.
										//if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.size() == 0)
										//MinisterOnTable[i] = DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
										//If There is Not Minister Of Gray In The Thinking Table List.   
										if (MinisterOnTable[i].MinisterThinking[0].TableListMinister.size() == 0)
										{
											//For All Possible Movments.
											////Parallel.For(0, AllDraw::MinisterMovments, j =>
											for (int j = 0; j < AllDraw::MinisterMovments; j++)
											{
												//Thinking of Gray Minister Operational.
												//Object OOO = new Object();
												//lock(OOO)
												{
													MinisterOnTable[i].MinisterThinking[0].ThinkingBegin = true;
													MinisterOnTable[i].MinisterThinking[0].ThinkingFinished = false;
													MinisterOnTable[i].MinisterThinking[0].Kind = 5;
													MinisterOnTable[i].MinisterThinking[0].Thinking( CastlesOnTable[i].LoseOcuuredatChiled,  CastlesOnTable[i].WinOcuuredatChiled);/*.t = new Task(new Action(MinisterOnTable[i].MinisterThinking[0].Thinking));
																																														 MinisterOnTable[i].MinisterThinking[0].t.Start();*/
												}
											}//);
										}
									}
								}
							}
						
					}

				}//,
				 // () =>
				{
					//Object oooo = new Object();
					//lock(oooo)
					{
						if (KingMidle <= i && KingHigh > i)
						{
							//Object O = new Object();
							//lock(O)
							{
								
									Order = DummyOrder;
									ChessRules::CurrentOrder = DummyCurrentOrder;
									//If There is Not Current //Object Continue Traversal Back.
									if (((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr))
									{
										//Initiate Local varibale By Global Objective Varibales.
										ii = (int)(int)KingOnTable[i].Row;
										jj = (int)KingOnTable[i].Column;
										//Construction of Gray King Thinking Objects.
										//if (KingOnTable[i].KingThinking[0].TableListKing.size() == 0)
										//KingOnTable[i] = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
										//When There is Not Thinking Table Gray King Movments.
										if (KingOnTable[i].KingThinking[0].TableListKing.size() == 0)
										{
											//For All Possible Gray King Movments.
											for (int j = 0; j < AllDraw::KingMovments; j++)
											{
												//Thinking Of Gray King Operatins.
												//Object OOO = new Object();
												//lock(OOO)
												{
													KingOnTable[i].KingThinking[0].ThinkingBegin = true;
													KingOnTable[i].KingThinking[0].ThinkingFinished = false;
													KingOnTable[i].KingThinking[0].Kind = 6;
													KingOnTable[i].KingThinking[0].Thinking( CastlesOnTable[i].LoseOcuuredatChiled,  CastlesOnTable[i].WinOcuuredatChiled);/*.t = new Task(new Action(KingOnTable[i].KingThinking[0].Thinking));
																																												 KingOnTable[i].KingThinking[0].t.Start();*/
												}
											}//);
										}
									}
								
							}
						}
					}
				}//);

			}//);
		}
		return ;
	}

	void AllDraw::InitiateAStarGreedytObject(int iAStarGreedy, int ii, int jj, int a, int** Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy) //,  Refrigtz.Timer timer,  Refrigtz.Timer Timerint,  double Less
	{
		bool Do = false;
		{

			OrderP = Order;
			SetObjectNumbers(Tab);

			int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
			for (int iii = 0; iii < 8; iii++)
			{
				for (int jjj = 0; jjj < 8; jjj++)
				{
					Table[iii][jjj] = Tab[iii][jjj];
				}
			}
			////auto oo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (oo)
			{
				ThinkingChess::BeginThread = 0;
				ThinkingChess::EndThread = 0;
			}
			//Initiate of global Variables Byte Local Variables.
			int DummyOrder = int();
			DummyOrder = Order;
			int DummyCurrentOrder = int();
			DummyCurrentOrder = ChessRules::CurrentOrder;
			//std::vector<Task*> ThB = std::vector<Task*>();

			int i = 0, ik = 0;

			int **TablInit = new int*[8]; for (int g = 0; g < 8; g++)TablInit[g] = new int[8];
			if (Order == 1)
			{
				a = 1;
			}
			else
			{
				a = -1;
			}
			int j = 0;
			//if (iAStarGreedy>=0)
			//return null;
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)
					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return ;
					}


				}

			}

			CurrentAStarGredyMax = AStarGreedyiLevelMax - iAStarGreedy;
			iAStarGreedy--;

			if (iAStarGreedy >= 0 && iAStarGreedy < MaxDuringLevelThinkingCreation)
			{
				MaxDuringLevelThinkingCreation = iAStarGreedy;
				////auto O = new Object();
				DepthIterative++;
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					OutPut += std::wstring(L"\r\nMinimum Level During Thinking Tree Creation is ") + StringConverterHelper::toString(MaxDuringLevelThinkingCreation) + std::wstring(L"at Iterative ") + StringConverterHelper::toString(DepthIterative);
				}
				//RefreshBoxText();

			}




			if (!FOUND)
			{
				////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (o)
				{
					if (Order == 1)
					{
						InitiateAStarGreedytObjectGray(i, j, Table, DummyOrder, DummyCurrentOrder, iAStarGreedy, ii, jj, a, Tab, Order, TB, FOUND, LeafAStarGreedy);
					}
					else
					{
						InitiateAStarGreedytObjectBrown(i, j, Table, DummyOrder, DummyCurrentOrder, iAStarGreedy, ii, jj, a, Tab, Order, TB, FOUND, LeafAStarGreedy);
					}
				}
			}

			if (FOUND)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					Tabl = CloneATable(Table);
					FoundOfLeafDepenOfKindFullGame(Tabl, Order, iAStarGreedy, ii, jj, ik, j, FOUND, LeafAStarGreedy);
				}
			}
			else
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					Order = DummyOrder;
					ChessRules::CurrentOrder = DummyCurrentOrder;
					int Ord = Order, iAStarGreedy1 = iAStarGreedy, ii1 = ii, jj1 = jj, ik1 = ik, j1 = j;
					//int Ord = Order, iAStarGreedy1 = iAStarGreedy, ii1 = ii, jj1 = jj, ik1 = ik, j1 = j;
					//System.Threading.Thread.Sleep(2);
					//Parallel.Invoke(() =>
					{
						Do |= FullGameThinkingTree(Ord, iAStarGreedy1, ii1, jj1, ik1, j1, false, LeafAStarGreedy);
					} //);
				}

			}
			////auto Om = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (Om)
			{
				if (!Do)
				{
					if (iAStarGreedy < MinThinkingTreeDepth)
					{
						MinThinkingTreeDepth = iAStarGreedy;
					}
				}
			}
			return ;
		}
	}
	bool AllDraw::KingDan(int** Tab, int Order)
	{
		bool IsDang = false;
		ChessRules *A = new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Order);
		IsDang = A->ObjectDangourKingMove(Order, Tab);
		if (Order == 1 && (IsDang))
		{
			if (A->CheckBrownObjectDangour && ((!A->CheckGrayObjectDangour)))
			{
				IsDang = false;
			}
		}
		if (Order == -1 && (IsDang))
		{
			if (A->CheckGrayObjectDangour && ((!A->CheckBrownObjectDangour)))
			{
				IsDang = false;
			}
		}
		return IsDang;

	}
	void AllDraw::BlitzGameThinkingTreeSolderGray(double PreviousLessS, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Soldeir
		for (ik = 0; ik < SodierMidle; ik++)
		{
			
				if ((&(SolderesOnTable) == nullptr) || (&(SolderesOnTable[ik]) == nullptr) || (&(SolderesOnTable[ik].SoldierThinking) == nullptr) || (&(SolderesOnTable[ik].SoldierThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < SolderesOnTable[ik].SoldierThinking[0].HuristicListSolder.size(); j++)
				{
					if (SolderesOnTable[ik].SoldierThinking[0].IsSupHu[j])
					{
						continue;
					}

					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						if (CheckeHuristci(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j], Order, ik, j, 0))
						{
							continue;
						}

						if (AllDraw::OrderPlate == Order)
						{
							if (SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessS || (SolderesOnTable[ik].SoldierThinking[0].PenaltyRegardListSolder[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{

							}

							else
							{
								PreviousLessS = SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[0] = ik;
								jIndex[0] = j;
							}
						}
						else
						{
							if (SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessS || (SolderesOnTable[ik].SoldierThinking[0].PenaltyRegardListSolder[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{

							}

							else
							{
								PreviousLessS = SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[0] = ik;
								jIndex[0] = j;
							}
						}

					}
				}

				//Elephant
		
		}
	}
	void AllDraw::BlitzGameThinkingTreeElephantGray(double PreviousLessE, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Elephant
		for (ik = 0; ik < ElefantMidle; ik++)
		{
			
				if ((&(ElephantOnTable) == nullptr) || (&(ElephantOnTable[ik]) == nullptr) || (&(ElephantOnTable[ik].ElefantThinking) == nullptr) || (&(ElephantOnTable[ik].ElefantThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < ElephantOnTable[ik].ElefantThinking[0].HuristicListElefant.size(); j++)
				{
					if (ElephantOnTable[ik].ElefantThinking[0].IsSupHu[j])
					{
						continue;
					}
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						if (CheckeHuristci(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j], Order, ik, j, 0))
						{
							continue;
						}


						if (AllDraw::OrderPlate == Order)
						{
							if (ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessE || (ElephantOnTable[ik].ElefantThinking[0].PenaltyRegardListElefant[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = null;
								//ElephantOnTable[ik] = null;
								//continue;
							}

							else
							{
								PreviousLessE = ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[1] = ik;
								jIndex[1] = j;
							}
						}
						else
						{
							if (ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessE || (ElephantOnTable[ik].ElefantThinking[0].PenaltyRegardListElefant[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = null;
								//ElephantOnTable[ik] = null;
								//continue;
							}

							else
							{
								PreviousLessE = ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[1] = ik;
								jIndex[1] = j;
							}
						}

					}
				}
		
		}
	}
	void AllDraw::BlitzGameThinkingTreeHourseGray(double PreviousLessH, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Hourse.
		for (ik = 0; ik < HourseMidle; ik++)
		{
			
				if ((&(HoursesOnTable) == nullptr) || (&(HoursesOnTable[ik]) == nullptr) || (&(HoursesOnTable[ik].HourseThinking) == nullptr) || (&(HoursesOnTable[ik].HourseThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < HoursesOnTable[ik].HourseThinking[0].HuristicListHourse.size(); j++)
				{
					if (HoursesOnTable[ik].HourseThinking[0].IsSupHu[j])
					{
						continue;
					}
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						if (CheckeHuristci(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j], Order, ik, j, 0))
						{
							continue;
						}

						if (AllDraw::OrderPlate == Order)
						{
							if (HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessH || (HoursesOnTable[ik].HourseThinking[0].PenaltyRegardListHourse[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//HoursesOnTable[ik].HourseThinking[0].AStarGreedy = null;
								//continue;
							}

							else
							{
								PreviousLessH = HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[2] = ik;
								jIndex[2] = j;
							}
						}
						else
						{

							if (HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessH || (HoursesOnTable[ik].HourseThinking[0].PenaltyRegardListHourse[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//HoursesOnTable[ik].HourseThinking[0].AStarGreedy = null;
								//continue;
							}

							else
							{
								PreviousLessH = HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[2] = ik;
								jIndex[2] = j;
							}
						}

					}
				}
		
		}
	}
	void AllDraw::BlitzGameThinkingTreeCastleGray(double PreviousLessB, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//Castle.
		for (ik = 0; ik < CastleMidle; ik++)
		{
			
				if ((&(CastlesOnTable) == nullptr) || (&(CastlesOnTable[ik]) == nullptr) || (&(CastlesOnTable[ik].CastleThinking) == nullptr) || (&(CastlesOnTable[ik].CastleThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < CastlesOnTable[ik].CastleThinking[0].HuristicListCastle.size(); j++)
				{
					if (CastlesOnTable[ik].CastleThinking[0].IsSupHu[j])
					{
						continue;
					}
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						if (CheckeHuristci(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j], Order, ik, j, 0))
						{
							continue;
						}

						if (AllDraw::OrderPlate == Order)
						{
							if (CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessB || (CastlesOnTable[ik].CastleThinking[0].PenaltyRegardListCastle[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{

								//CastlesOnTable[ik].CastleThinking[0].AStarGreedy = null;
								//CastlesOnTable[ik] = null;
								//continue;
							}

							else
							{
								PreviousLessB = CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[3] = ik;
								jIndex[3] = j;
							}
						}
						else
						{
							if (CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessB || (CastlesOnTable[ik].CastleThinking[0].PenaltyRegardListCastle[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{

								//CastlesOnTable[ik].CastleThinking[0].AStarGreedy = null;
								//CastlesOnTable[ik] = null;
								//continue;
							}

							else
							{
								PreviousLessB = CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false);
								Index[3] = ik;
								jIndex[3] = j;
							}
						}
					}
				}
		
		}

	}
	void AllDraw::BlitzGameThinkingTreeMinisterGray(double PreviousLessM, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Minister.
		for (ik = 0; ik < MinisterMidle; ik++)
		{
			
			if ((&(MinisterOnTable) == nullptr) || (&(MinisterOnTable[ik]) == nullptr) || (&(MinisterOnTable[ik].MinisterThinking) == nullptr) || (&(MinisterOnTable[ik].MinisterThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < MinisterOnTable[ik].MinisterThinking[0].HuristicListMinister.size(); j++)
				{
					if (MinisterOnTable[ik].MinisterThinking[0].IsSupHu[j])
					{
						continue;
					}

					if (CheckeHuristci(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order, ik, j, 0))
					{
						continue;
					}


					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						if (AllDraw::OrderPlate == Order)
						{
							if (MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessM || (MinisterOnTable[ik].MinisterThinking[0].PenaltyRegardListMinister[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = null;
								// MinisterOnTable[ik] = null;

								// continue;
							}

							else
							{
								Index[4] = ik;
								jIndex[4] = j;
								PreviousLessM = MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false);
							}
						}
						else
						{
							if (MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessM || (MinisterOnTable[ik].MinisterThinking[0].PenaltyRegardListMinister[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = null;
								// MinisterOnTable[ik] = null;

								// continue;
							}

							else
							{
								Index[4] = ik;
								jIndex[4] = j;
								PreviousLessM = MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false);
							}
						}

					}
				}
		
		}
	}
	void AllDraw::BlitzGameThinkingTreeKingGray(double PreviousLessK, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //King.
		for (ik = 0; ik < KingMidle; ik++)
		{
			
			if ((&(KingOnTable) == nullptr) || (&(KingOnTable[ik]) == nullptr) || (&(KingOnTable[ik].KingThinking) == nullptr) || (&(KingOnTable[ik].KingThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < KingOnTable[ik].KingThinking[0].HuristicListKing.size(); j++)
				{
					if (KingOnTable[ik].KingThinking[0].IsSupHu[j])
					{
						continue;
					}

					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						if (CheckeHuristci(KingOnTable[ik].KingThinking[0].TableListKing[j], Order, ik, j, 0))
						{
							continue;
						}

						if (AllDraw::OrderPlate == Order)
						{
							if (KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessK || (KingOnTable[ik].KingThinking[0].PenaltyRegardListKing[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//KingOnTable[ik].KingThinking[0].AStarGreedy = null;
								//KingOnTable[ik] = null;
								//continue;
							}

							else
							{
								Index[5] = ik;
								jIndex[5] = j;
								PreviousLessK = KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false);
							}
						}
						else
						{
							if (KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessK || (KingOnTable[ik].KingThinking[0].PenaltyRegardListKing[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
							{
								//KingOnTable[ik].KingThinking[0].AStarGreedy = null;
								//KingOnTable[ik] = null;
								//continue;
							}

							else
							{
								Index[5] = ik;
								jIndex[5] = j;
								PreviousLessK = KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false);
							}
						}

					}
				}
		
		}
	}
	void AllDraw::BlitzGameTreeCreationThinkingTreeSolder(int a, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//std::vector<Task*> tHA = std::vector<Task*>();
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			if (Index[0] != -1)
			{
				if (SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.empty())
				{
					SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				}
				SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy[SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.size() - 1].TableList.clear();
				SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy[SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.size() - 1].TableList.push_back(SolderesOnTable[Index[0]].SoldierThinking[0].TableListSolder[jIndex[0]]);
				SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy[SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
				//SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy[SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, SolderesOnTable[Index[0]].SoldierThinking[0].TableListSolder[jIndex[0]], Order, false);
				//ParameterizedThreadStart start = new ParameterizedThreadStart(SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy[SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
				//Task *array_Renamed = Task::Factory->StartNew([&] ()
				{
					SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy[SolderesOnTable[Index[0]].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, SolderesOnTable[Index[0]].SoldierThinking[0].RowColumnSoldier[jIndex[0]][0], SolderesOnTable[Index[0]].SoldierThinking[0].RowColumnSoldier[jIndex[0]][1], a, SolderesOnTable[Index[0]].SoldierThinking[0].TableListSolder[jIndex[0]], Order, false, FOUND, LeafAStarGreedy);
				}//);
				////auto ttttt = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ttttt)
				{
					//tHA.push_back(array_Renamed);
				}
				//array_Renamed->Wait();
				//array.Name = "S" + i.ToString();
				//array.Start();

			}
		}
		//Parallel.ForEach(tHA, items => Task.WaitAny(items));


	}
	void AllDraw::BlitzGameTreeCreationThinkingTreeElephant(int a, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//std::vector<Task*> tHA = std::vector<Task*>();
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (Index[1] != -1)
			{
				if (ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.empty())
				{
					ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				}
				ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy[ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.size() - 1].TableList.clear();
				ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy[ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.size() - 1].TableList.push_back(ElephantOnTable[Index[1]].ElefantThinking[0].TableListElefant[jIndex[1]]);
				ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy[ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
				//ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy[ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, ElephantOnTable[Index[1]].ElefantThinking[0].TableListElefant[jIndex[1]], Order, false);
				//ParameterizedThreadStart start = new ParameterizedThreadStart(ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy[ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
				//Task *array_Renamed = Task::Factory->StartNew([&] ()
				{
					ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy[ElephantOnTable[Index[1]].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ElephantOnTable[Index[1]].ElefantThinking[0].RowColumnElefant[jIndex[1]][0], ElephantOnTable[Index[1]].ElefantThinking[0].RowColumnElefant[jIndex[1]][1], a, ElephantOnTable[Index[1]].ElefantThinking[0].TableListElefant[jIndex[1]], Order, false, FOUND, LeafAStarGreedy);
				}//);
				////auto ttttt = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ttttt)
				{
					//tHA.push_back(array_Renamed);
				}
				//array.Name = "E" + i.ToString();
				//array.Start();
				//array_Renamed->Wait();

			}
		}
		//Parallel.ForEach(tHA, items => Task.WaitAny(items));
	}
	void AllDraw::BlitzGameTreeCreationThinkingTreeHourse(int a, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//std::vector<Task*> tHA = std::vector<Task*>();
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (Index[2] != -1)
			{
				if (HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.empty())
				{
					HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				}
				HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy[HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.size() - 1].TableList.clear();
				HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy[HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.size() - 1].TableList.push_back(HoursesOnTable[Index[2]].HourseThinking[0].TableListHourse[jIndex[2]]);
				HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy[HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
				//HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy[HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, HoursesOnTable[Index[2]].HourseThinking[0].TableListHourse[jIndex[2]], Order, false);
				//ParameterizedThreadStart start = new ParameterizedThreadStart(HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy[HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
				//Task *array_Renamed = Task::Factory->StartNew([&] ()
				{
					HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy[HoursesOnTable[Index[2]].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, HoursesOnTable[Index[2]].HourseThinking[0].RowColumnHourse[jIndex[2]][0], HoursesOnTable[Index[2]].HourseThinking[0].RowColumnHourse[jIndex[2]][1], a, HoursesOnTable[Index[2]].HourseThinking[0].TableListHourse[jIndex[2]], Order, false, FOUND, LeafAStarGreedy);
				}//);
				////auto ttttt = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ttttt)
				{
					//tHA.push_back(array_Renamed);
				}
				//array.Name = "H" + i.ToString();
				//array.Start();
				//array_Renamed->Wait();

			}
		}
		//Parallel.ForEach(tHA, items => Task.WaitAny(items));
	}
	void AllDraw::BlitzGameTreeCreationThinkingTreeCastle(int a, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//std::vector<Task*> tHA = std::vector<Task*>();
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (Index[3] != -1)
			{
				if (CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.empty())
				{
					CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				}
				CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy[CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.size() - 1].TableList.clear();
				CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy[CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.size() - 1].TableList.push_back(CastlesOnTable[Index[3]].CastleThinking[0].TableListCastle[jIndex[3]]);
				CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy[CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
				//CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy[CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CastlesOnTable[Index[3]].CastleThinking[0].TableListCastle[jIndex[3]], Order, false);
				//ParameterizedThreadStart start = new ParameterizedThreadStart(CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy[CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
				//Task *array_Renamed = Task::Factory->StartNew([&] ()
				{
					CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy[CastlesOnTable[Index[3]].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, CastlesOnTable[Index[3]].CastleThinking[0].RowColumnCastle[jIndex[3]][0], CastlesOnTable[Index[3]].CastleThinking[0].RowColumnCastle[jIndex[3]][1], a, CastlesOnTable[Index[3]].CastleThinking[0].TableListCastle[jIndex[3]], Order, false, FOUND, LeafAStarGreedy);
				}//);
				///array_Renamed->Wait();
				////auto ttttt = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ttttt)
				{
					//tHA.push_back(array_Renamed);
				}
				//array.Name = "B" + i.ToString();
				//array.Start();

			}
			//Parallel.ForEach(tHA, items => Task.WaitAny(items));
		}
	}
	void AllDraw::BlitzGameTreeCreationThinkingTreeMinister(int a, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//std::vector<Task*> tHA = std::vector<Task*>();
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (Index[4] != -1)
			{
				if (MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.empty())
				{
					MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				}
				MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy[MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.size() - 1].TableList.clear();
				MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy[MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.size() - 1].TableList.push_back(MinisterOnTable[Index[4]].MinisterThinking[0].TableListMinister[jIndex[4]]);
				MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy[MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
				//MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy[MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, MinisterOnTable[Index[4]].MinisterThinking[0].TableListMinister[jIndex[4]], Order, false);
				//ParameterizedThreadStart start = new ParameterizedThreadStart(MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy[MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
				//Task *array_Renamed = Task::Factory->StartNew([&] ()
				{
					MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy[MinisterOnTable[Index[4]].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, MinisterOnTable[Index[4]].MinisterThinking[0].RowColumnMinister[jIndex[4]][0], MinisterOnTable[Index[4]].MinisterThinking[0].RowColumnMinister[jIndex[4]][1], a, MinisterOnTable[Index[4]].MinisterThinking[0].TableListMinister[jIndex[4]], Order, false, FOUND, LeafAStarGreedy);
				}//);
				////auto ttttt = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ttttt)
				{
					//tHA.push_back(array_Renamed);
				}
				//array.Name = "M" + i.ToString();
				//array.Start();
				//array_Renamed->Wait();

			}
			//Parallel.ForEach(tHA, items => Task.WaitAny(items));
		}
	}
	void AllDraw::BlitzGameTreeCreationThinkingTreeKing(int a, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		//std::vector<Task*> tHA = std::vector<Task*>();
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (Index[5] != -1)
			{
				if (KingOnTable[Index[5]].KingThinking[0].AStarGreedy.empty())
				{
					KingOnTable[Index[5]].KingThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				}
				KingOnTable[Index[5]].KingThinking[0].AStarGreedy[KingOnTable[Index[5]].KingThinking[0].AStarGreedy.size() - 1].TableList.clear();
				KingOnTable[Index[5]].KingThinking[0].AStarGreedy[KingOnTable[Index[5]].KingThinking[0].AStarGreedy.size() - 1].TableList.push_back(KingOnTable[Index[5]].KingThinking[0].TableListKing[jIndex[5]]);
				KingOnTable[Index[5]].KingThinking[0].AStarGreedy[KingOnTable[Index[5]].KingThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
				//KingOnTable[Index[5]].KingThinking[0].AStarGreedy[KingOnTable[Index[5]].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, KingOnTable[Index[5]].KingThinking[0].TableListKing[jIndex[5]], Order, false);
				//ParameterizedThreadStart start = new ParameterizedThreadStart(KingOnTable[Index[5]].KingThinking[0].AStarGreedy[KingOnTable[Index[5]].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
				//Task *array_Renamed = Task::Factory->StartNew([&] ()
				{
					KingOnTable[Index[5]].KingThinking[0].AStarGreedy[KingOnTable[Index[5]].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, KingOnTable[Index[5]].KingThinking[0].RowColumnKing[jIndex[5]][0], KingOnTable[Index[5]].KingThinking[0].RowColumnKing[jIndex[5]][1], a, KingOnTable[Index[5]].KingThinking[0].TableListKing[jIndex[5]], Order, false, FOUND, LeafAStarGreedy);
				}//);
				////auto ttttt = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ttttt)
				{
					//tHA.push_back(array_Renamed);
				}
				//array.Name = "K" + i.ToString();
				//array.Start();
				//array_Renamed->Wait();

			}
			//Parallel.ForEach(tHA, items => Task.WaitAny(items));
		}
	}
	void AllDraw::BlitzGameThinkingTreeSolderBrown(double PreviousLessS, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{
		for (ik = SodierMidle; ik < SodierHigh; ik++)
		{
			
				if ((&(SolderesOnTable) == nullptr) || (&(SolderesOnTable[ik]) == nullptr) || (&(SolderesOnTable[ik].SoldierThinking) == nullptr) || (&(SolderesOnTable[ik].SoldierThinking[0]) == nullptr))
				{
					continue;
				}
				//Soldier.
				for (j = 0; j < SolderesOnTable[ik].SoldierThinking[0].HuristicListSolder.size(); j++)
				{
					if (SolderesOnTable[ik].SoldierThinking[0].IsSupHu[j])
					{
						continue;
					}

					if (CheckeHuristci(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j], Order, ik, j, 0))
					{
						continue;
					}


					if (AllDraw::OrderPlate == Order)
					{
						if (SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessS || (SolderesOnTable[ik].SoldierThinking[0].PenaltyRegardListSolder[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
						{
							//SolderesOnTable[ik].SoldierThinking[0].AStarGreedy = null;
							//SolderesOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[0] = ik;
							jIndex[0] = j;
							PreviousLessS = SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}
					else
					{
						if (SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessS || (SolderesOnTable[ik].SoldierThinking[0].PenaltyRegardListSolder[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
						{
							//SolderesOnTable[ik].SoldierThinking[0].AStarGreedy = null;
							//SolderesOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[0] = ik;
							jIndex[0] = j;
							PreviousLessS = SolderesOnTable[ik].SoldierThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}
				}

		
		}
	}
	void AllDraw::BlitzGameThinkingTreeElephantBrown(double PreviousLessE, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Elephant
		for (ik = ElefantMidle; ik < ElefantHigh; ik++)
		{
			
				if ((&(ElephantOnTable) == nullptr) || (&(ElephantOnTable[ik]) == nullptr) || (&(ElephantOnTable[ik].ElefantThinking) == nullptr) || (&(ElephantOnTable[ik].ElefantThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < ElephantOnTable[ik].ElefantThinking[0].HuristicListElefant.size(); j++)
				{
					if (ElephantOnTable[ik].ElefantThinking[0].IsSupHu[j])
					{
						continue;
					}
					if (CheckeHuristci(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j], Order, ik, j, 0))
					{
						continue;
					}

					if (AllDraw::OrderPlate == Order)
					{
						if (ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessE || (ElephantOnTable[ik].ElefantThinking[0].PenaltyRegardListElefant[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = null;
							//ElephantOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[1] = ik;
							jIndex[1] = j;
							PreviousLessE = ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}
					else
					{
						if (ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessE || (ElephantOnTable[ik].ElefantThinking[0].PenaltyRegardListElefant[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = null;
							//ElephantOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[1] = ik;
							jIndex[1] = j;
							PreviousLessE = ElephantOnTable[ik].ElefantThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}


				}
		
		}

	}
	void AllDraw::BlitzGameThinkingTreeHourseBrown(double PreviousLessH, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Hourse.
		for (ik = HourseMidle; ik < HourseHight; ik++)
		{
			
				if ((&(HoursesOnTable) == nullptr) || (&(HoursesOnTable[ik]) == nullptr) || (&(HoursesOnTable[ik].HourseThinking) == nullptr) || (&(HoursesOnTable[ik].HourseThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < HoursesOnTable[ik].HourseThinking[0].HuristicListHourse.size(); j++)
				{
					if (HoursesOnTable[ik].HourseThinking[0].IsSupHu[j])
					{
						continue;
					}
					if (CheckeHuristci(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j], Order, ik, j, 0))
					{
						continue;
					}

					if (AllDraw::OrderPlate == Order)
					{
						if (HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessH || (HoursesOnTable[ik].HourseThinking[0].PenaltyRegardListHourse[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//HoursesOnTable[ik].HourseThinking[0].AStarGreedy = null;
							//HoursesOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[2] = ik;
							jIndex[2] = j;
							PreviousLessH = HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false);
						}

					}
					else
					{
						if (HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessH || (HoursesOnTable[ik].HourseThinking[0].PenaltyRegardListHourse[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//HoursesOnTable[ik].HourseThinking[0].AStarGreedy = null;
							//HoursesOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[2] = ik;
							jIndex[2] = j;
							PreviousLessH = HoursesOnTable[ik].HourseThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}

				}
		
		}

	}
	int AllDraw::FullGameMakimgBlitz(int* Index, int* jIndex, int Order, int LeafAStarGreedy)
	{
		int Kind = -1;
		double PS = -DBL_MAX, PE = -DBL_MAX, PH = -DBL_MAX, PB = -DBL_MAX, PM = -DBL_MAX, PK = -DBL_MAX;
		if (Order != AllDraw::OrderPlate)
		{
			PS = DBL_MAX;
			PE = DBL_MAX;
			PH = DBL_MAX;
			PB = DBL_MAX;
			PM = DBL_MAX;
			PK = DBL_MAX;

		}

		int index[6] = {-1, -1, -1, -1, -1, -1};
		int jindex[6] = {-1, -1, -1, -1, -1, -1};
		if (Order == 1)
		{
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O)
			{
				BlitzGameThinkingTreeSolderGray(PS, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeElephantGray(PE, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeHourseGray(PH, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeCastleGray(PB, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeMinisterGray(PM, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeKingGray(PK, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
			}

		}
		else
		{
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O)
			{
				BlitzGameThinkingTreeSolderBrown(PS, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeElephantBrown(PE, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeHourseBrown(PH, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeCastleBrown(PB, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeMinisterBrown(PM, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
				BlitzGameThinkingTreeKingBrown(PK, index, jindex, Order, 0, 0, 0, false, LeafAStarGreedy);
			}
		}
		int JI = -1;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			if (Order == OrderPlate)
			{
				JI = MaxOfSixHuristic(PS, PE, PH, PB, PM, PK);
			}
			else
			{
				JI = MinOfSixHuristic(PS, PE, PH, PB, PM, PK);
			}
		}
		if (JI != -1)
		{
			Kind = JI;
			for (int i = 0; i < 6; i++)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					Index[i] = index[i];
					jIndex[i] = jindex[i];
				}
			}

		}
		return abs(Kind);
	}
	void AllDraw::BlitzGameThinkingTreeCastleBrown(double PreviousLessB, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Castles.
		for (ik = CastleMidle; ik < CastleHigh; ik++)
		{
			
				if ((&(CastlesOnTable) == nullptr) || (&(CastlesOnTable[ik]) == nullptr) || (&(CastlesOnTable[ik].CastleThinking) == nullptr) || (&(CastlesOnTable[ik].CastleThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < CastlesOnTable[ik].CastleThinking[0].HuristicListCastle.size(); j++)
				{
					if (CastlesOnTable[ik].CastleThinking[0].IsSup[j])
					{
						continue;
					}

					if (CheckeHuristci(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j], Order, ik, j, 0))
					{
						continue;
					}


					if (AllDraw::OrderPlate == Order)
					{
						if (CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessB || (CastlesOnTable[ik].CastleThinking[0].PenaltyRegardListCastle[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//CastlesOnTable[ik].CastleThinking[0].AStarGreedy = null;
							//CastlesOnTable[ik] = null;
							//continue;
						}


						else
						{
							Index[3] = ik;
							jIndex[3] = j;
							PreviousLessB = CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false);
						}

					}
					else
					{
						if (CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessB || (CastlesOnTable[ik].CastleThinking[0].PenaltyRegardListCastle[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//CastlesOnTable[ik].CastleThinking[0].AStarGreedy = null;
							//CastlesOnTable[ik] = null;
							//continue;
						}


						else
						{
							Index[3] = ik;
							jIndex[3] = j;
							PreviousLessB = CastlesOnTable[ik].CastleThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}

				}
		
		}

	}
	void AllDraw::BlitzGameThinkingTreeMinisterBrown(double PreviousLessM, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //Minister.
		for (ik = MinisterMidle; ik < MinisterHigh; ik++)
		{
			
			if ((&(MinisterOnTable) == nullptr) || (&(MinisterOnTable[ik]) == nullptr) || (&(MinisterOnTable[ik].MinisterThinking) == nullptr) || (&(MinisterOnTable[ik].MinisterThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < MinisterOnTable[ik].MinisterThinking[0].HuristicListMinister.size(); j++)
				{
					if (MinisterOnTable[ik].MinisterThinking[0].IsSup[j])
					{
						continue;
					}

					if (CheckeHuristci(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order, ik, j, 0))
					{
						continue;
					}

					if (AllDraw::OrderPlate == Order)
					{
						if (MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessM || (MinisterOnTable[ik].MinisterThinking[0].PenaltyRegardListMinister[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))

						{
							//MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = null;
							//MinisterOnTable[ik] = null;
							//continue;
						}
						else
						{
					   //if (KingDan(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order))
							Index[4] = ik;
							jIndex[4] = j;
							PreviousLessM = MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}
					else
					{
						if (MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessM || (MinisterOnTable[ik].MinisterThinking[0].PenaltyRegardListMinister[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
						{
							//MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = null;
							//MinisterOnTable[ik] = null;
							//continue;
						}
						else
						{
		//if (KingDan(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order))
							Index[4] = ik;
							jIndex[4] = j;
							PreviousLessM = MinisterOnTable[ik].MinisterThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}
				}

		
		}

	}
	void AllDraw::BlitzGameThinkingTreeKingBrown(double PreviousLessK, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy)
	{ //King.
		for (ik = KingMidle; ik < KingHigh; ik++)
		{
			
			if ((&(KingOnTable) == nullptr) || (&(KingOnTable[ik]) == nullptr) || (&(KingOnTable[ik].KingThinking) == nullptr) || (&(KingOnTable[ik].KingThinking[0]) == nullptr))
				{
					continue;
				}
				for (j = 0; j < KingOnTable[ik].KingThinking[0].HuristicListKing.size(); j++)
				{
					if (KingOnTable[ik].KingThinking[0].IsSup[j])
					{
						continue;
					}

					if (CheckeHuristci(KingOnTable[ik].KingThinking[0].TableListKing[j], Order, ik, j, 0))
					{
						continue;
					}

					if (AllDraw::OrderPlate == Order)
					{
						if (KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false) < PreviousLessK || (KingOnTable[ik].KingThinking[0].PenaltyRegardListKing[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
						{
							//KingOnTable[ik].KingThinking[0].AStarGreedy = null;
							//KingOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[5] = ik;
							jIndex[5] = j;
							PreviousLessK = KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}
					else
					{
						if (KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false) > PreviousLessK || (KingOnTable[ik].KingThinking[0].PenaltyRegardListKing[j].IsPenaltyAction() == 0 && UsePenaltyRegardMechnisamT))
						{
							//KingOnTable[ik].KingThinking[0].AStarGreedy = null;
							//KingOnTable[ik] = null;
							//continue;
						}

						else
						{
							Index[5] = ik;
							jIndex[5] = j;
							PreviousLessK = KingOnTable[ik].KingThinking[0].ReturnHuristic(-1, j, Order, false);
						}
					}


				}
		
		}
	}

	bool AllDraw::ReturnFullGameThinkingTreeSemaphore(int ik, int kind)
	{
		if (kind == 1)
		{
			if (SolderesOnTable[ik].SoldierThinking[0].ThinkingBegin && (!SolderesOnTable[ik].SoldierThinking[0].ThinkingFinished))
			{
				return true;
			}
		}
		else
		{
			if (kind == 2)
			{
			if (ElephantOnTable[ik].ElefantThinking[0].ThinkingBegin && (!ElephantOnTable[ik].ElefantThinking[0].ThinkingFinished))
			{
				return true;
			}
			}
		else if (kind == 3)
		{
			if (HoursesOnTable[ik].HourseThinking[0].ThinkingBegin && (!HoursesOnTable[ik].HourseThinking[0].ThinkingFinished))
			{
				return true;
			}
		}
		else if (kind == 4)
		{
			if (CastlesOnTable[ik].CastleThinking[0].ThinkingBegin && (!CastlesOnTable[ik].CastleThinking[0].ThinkingFinished))
			{
				return true;
			}
		}
		else
		{
			if (kind == 5)
			{
			if (MinisterOnTable[ik].MinisterThinking[0].ThinkingBegin && (!MinisterOnTable[ik].MinisterThinking[0].ThinkingFinished))
			{
				return true;
			}
			}
		else if (kind == 6)
		{
			if (KingOnTable[ik].KingThinking[0].ThinkingBegin && (!KingOnTable[ik].KingThinking[0].ThinkingFinished))
			{
				return true;
			}
		}
		}
		}
		return false;
	}

	bool AllDraw::ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(int ik, int kind, bool Penalty, int j)
	{
		if (Penalty)
		{
			if (kind == 1)
			{
				if (SolderesOnTable[ik].SoldierThinking[0].PenaltyRegardListSolder[j].IsPenaltyAction() != 0 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			else
			{
							if (kind == 2)
							{
				if (ElephantOnTable[ik].ElefantThinking[0].PenaltyRegardListElefant[j].IsPenaltyAction() != 0 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
							}
			else if (kind == 3)
			{
				if (HoursesOnTable[ik].HourseThinking[0].PenaltyRegardListHourse[j].IsPenaltyAction() != 0 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			else if (kind == 4)
			{
				if (CastlesOnTable[ik].CastleThinking[0].PenaltyRegardListCastle[j].IsPenaltyAction() != 0 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			else
			{
				if (kind == 5)
				{
				if (MinisterOnTable[ik].MinisterThinking[0].PenaltyRegardListMinister[j].IsPenaltyAction() != 0 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
				}
			else if (kind == 6)
			{
				if (KingOnTable[ik].KingThinking[0].PenaltyRegardListKing[j].IsPenaltyAction() != 0 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			}
			}
		}
		else
		{
			if (kind == 1)
			{
				if (SolderesOnTable[ik].SoldierThinking[0].PenaltyRegardListSolder[j].IsRewardAction() != 1 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			else
			{
					 if (kind == 2)
					 {
				if (ElephantOnTable[ik].ElefantThinking[0].PenaltyRegardListElefant[j].IsRewardAction() != 1 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
					 }
			else if (kind == 3)
			{
				if (HoursesOnTable[ik].HourseThinking[0].PenaltyRegardListHourse[j].IsRewardAction() != 1 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			else if (kind == 4)
			{
				if (CastlesOnTable[ik].CastleThinking[0].PenaltyRegardListCastle[j].IsRewardAction() != 1 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			else
			{
				if (kind == 5)
				{
				if (MinisterOnTable[ik].MinisterThinking[0].PenaltyRegardListMinister[j].IsRewardAction() != 1 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
				}
			else if (kind == 6)
			{
				if (KingOnTable[ik].KingThinking[0].PenaltyRegardListKing[j].IsRewardAction() != 1 || (!UsePenaltyRegardMechnisamT))
				{
					return true;
				}
			}
			}
			}
		}
		return false;
	}
	void AllDraw::BlitzNotValidFullGameThinkingTreePartOne(int ik, int Order, int kind)
	{
		if (kind == 1)
		{
			if (SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.empty())
			{
				SolderesOnTable[ik].SoldierThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 2)
		{
			if (ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.empty())
			{
				ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 3)
		{
			if (HoursesOnTable[ik].HourseThinking[0].AStarGreedy.empty())
			{
				HoursesOnTable[ik].HourseThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 4)
		{
			if (CastlesOnTable[ik].CastleThinking[0].AStarGreedy.empty())
			{
				CastlesOnTable[ik].CastleThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 5)
		{
			if (MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.empty())
			{
				MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 6)
		{
			if (KingOnTable[ik].KingThinking[0].AStarGreedy.empty())
			{
				KingOnTable[ik].KingThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			KingOnTable[ik].KingThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}

	}
	void AllDraw::BlitzNotValidFullGameThinkingTreePartTow(int ik, int Order, int kind)
	{
		if (kind == 1)
		{
			if (SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.empty())
			{
				SolderesOnTable[ik].SoldierThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 2)
		{
			if (ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.empty())
			{
				ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 3)
		{
			if (HoursesOnTable[ik].HourseThinking[0].AStarGreedy.empty())
			{
				HoursesOnTable[ik].HourseThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 4)
		{
			if (CastlesOnTable[ik].CastleThinking[0].AStarGreedy.empty())
			{
				CastlesOnTable[ik].CastleThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 5)
		{
			if (MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.empty())
			{
				MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 6)
		{
			if (KingOnTable[ik].KingThinking[0].AStarGreedy.empty())
			{
				KingOnTable[ik].KingThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			KingOnTable[ik].KingThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
	}
	void AllDraw::BlitzNotValidFullGameThinkingTreePartThree(int ik, int Order, int kind)
	{
		if (kind == 1)
		{
			if (SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.empty())
			{
				SolderesOnTable[ik].SoldierThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;

		}
		else if (kind == 2)
		{
			if (ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.empty())
			{
				ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 3)
		{
			if (HoursesOnTable[ik].HourseThinking[0].AStarGreedy.empty())
			{
				HoursesOnTable[ik].HourseThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 4)
		{
			if (CastlesOnTable[ik].CastleThinking[0].AStarGreedy.empty())
			{
				CastlesOnTable[ik].CastleThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 5)
		{
			if (MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.empty())
			{
				MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
		else if (kind == 6)
		{
			if (KingOnTable[ik].KingThinking[0].AStarGreedy.empty())
			{
				KingOnTable[ik].KingThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			KingOnTable[ik].KingThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
		}
	}
	void AllDraw::FullGameThinkingTreeInitialization(int ik, int j, int Order, int kind)
	{
		if (kind == 1)
		{
			if (SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.empty())
			{
				SolderesOnTable[ik].SoldierThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].TableList.clear();
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].TableList.push_back(CloneATable(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j]));
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].SetRowColumnFinishedWait();
		}
		else if (kind == 2)
		{
			if (ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.empty())
			{
				ElephantOnTable[ik].ElefantThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].TableList.clear();
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].TableList.push_back(CloneATable(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j]));
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].SetRowColumnFinishedWait();
		}
		else if (kind == 3)
		{
			if (HoursesOnTable[ik].HourseThinking[0].AStarGreedy.empty())
			{
				HoursesOnTable[ik].HourseThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].TableList.clear();
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].TableList.push_back(CloneATable(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j]));
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].SetRowColumnFinishedWait();
		}
		else if (kind == 4)
		{
			if (CastlesOnTable[ik].CastleThinking[0].AStarGreedy.empty())
			{
				CastlesOnTable[ik].CastleThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].TableList.clear();
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].TableList.push_back(CloneATable(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j]));
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].SetRowColumnFinishedWait();
		}
		else if (kind == 5)
		{
			if (MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.empty())
			{
				MinisterOnTable[ik].MinisterThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].TableList.clear();
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].TableList.push_back(CloneATable(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j]));
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].SetRowColumnFinishedWait();
		}
		else if (kind == 6)
		{
			if (KingOnTable[ik].KingThinking[0].AStarGreedy.empty())
			{
				KingOnTable[ik].KingThinking[0].AStarGreedy = std::vector<AllDraw>();
			}
			KingOnTable[ik].KingThinking[0].AStarGreedy.push_back(AllDraw(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].TableList.clear();
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].TableList.push_back(CloneATable(KingOnTable[ik].KingThinking[0].TableListKing[j]));
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].SetRowColumn(0);
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].SetRowColumnFinishedWait();
		}
	}
	void AllDraw::OpOfFullGameThinkingTree(int ik, int j, int Order, int iAStarGreedy, int ii, int jj, int a, int kind,bool FOUND,int LeafAStarGreedy)
	{
		if (kind == 1)
		{
			OutPutAction = std::wstring(L" ") + Alphabet(SolderesOnTable[ik].SoldierThinking[0].Row) + Number(SolderesOnTable[ik].SoldierThinking[0].Column) + Alphabet(SolderesOnTable[ik].SoldierThinking[0].RowColumnSoldier[j][0]) + Number(SolderesOnTable[ik].SoldierThinking[0].RowColumnSoldier[j][1]);
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nPerception Soldier AStarGreedy By Bob at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}
			else
			{
				OutPut += std::wstring(L"\r\nPerception Soldier AStarGreedy By Alice at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}

			PerceptionCount++;
			int iii = SolderesOnTable[ik].SoldierThinking[0].RowColumnSoldier[j][0];
			int jjj = SolderesOnTable[ik].SoldierThinking[0].RowColumnSoldier[j][1];
			int aa = a;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j]);
			int **Tab = CloneATable(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j]);
			int Ord = Order * -1;
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
			SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j]), Order * -1, false, FOUND, LeafAStarGreedy);

			//Task array = Task.Factory.StartNew(() => SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j]), Order, false, FOUND, LeafAStarGreedy));

			//SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, iii, jjj, aa, Tab, Ord*-1, false, FOUND, LeafAStarGreedy);
			//array.Start();
			/*bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
			{
			    Object ttttt = new Object(); //lock (ttttt) { tHA.Add(array); }
			}
			else
			{
			    Object ttttt = new Object(); //lock (ttttt) { array.Wait(); }
			}
			*/
			//array.Name = "S" + i.ToString();
		}
		else if (kind == 2)
		{
			OutPutAction = std::wstring(L" ") + Alphabet(ElephantOnTable[ik].ElefantThinking[0].Row) + Number(ElephantOnTable[ik].ElefantThinking[0].Column) + Alphabet(ElephantOnTable[ik].ElefantThinking[0].RowColumnElefant[j][0]) + Number(ElephantOnTable[ik].ElefantThinking[0].RowColumnElefant[j][1]);
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nPerception Elephant AStarGreedy By Bob at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}
			else
			{
				OutPut += std::wstring(L"\r\nPerception Elephant AStarGreedy By Alice at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}

			PerceptionCount++;
			int iii = ElephantOnTable[ik].ElefantThinking[0].RowColumnElefant[j][0];
			int jjj = ElephantOnTable[ik].ElefantThinking[0].RowColumnElefant[j][1];
			int aa = a;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j]);
			int **Tab = CloneATable(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j]);
			int Ord = Order * -1;
			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;

			ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, iii, jjj, aa, Tab, Ord * -1, false, FOUND, LeafAStarGreedy);
			//Task array = Task.Factory.StartNew(() => ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j]), Order, false, FOUND, LeafAStarGreedy));

			//array.Start();
			/*bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
			{
			    Object ttttt = new Object(); //lock (ttttt) { tHA.Add(array); }
			}
			else
			{
			    Object ttttt = new Object(); //lock (ttttt) { array.Wait(); }
			}*/
			//array.Name = "E" + i.ToString();
		}
		else if (kind == 3)
		{
			OutPutAction = std::wstring(L" ") + Alphabet(HoursesOnTable[ik].HourseThinking[0].Row) + Number(HoursesOnTable[ik].HourseThinking[0].Column) + Alphabet(HoursesOnTable[ik].HourseThinking[0].RowColumnHourse[j][0]) + Number(HoursesOnTable[ik].HourseThinking[0].RowColumnHourse[j][1]);
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nPerception Hourse AStarGreedy By Bob at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}
			else
			{
				OutPut += std::wstring(L"\r\nPerception Hourse AStarGreedy By Alice at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}

			PerceptionCount++;
			int iii = HoursesOnTable[ik].HourseThinking[0].RowColumnHourse[j][0];
			int jjj = HoursesOnTable[ik].HourseThinking[0].RowColumnHourse[j][1];
			int aa = a;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j]);
			int **Tab = CloneATable(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j]);
			int Ord = Order * -1;
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
			HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, iii, jjj, aa, Tab, Ord * -1, false, FOUND, LeafAStarGreedy);

			//Task array = Task.Factory.StartNew(() => HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j]), Order, false, FOUND, LeafAStarGreedy));

			//array.Start();
			/*bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
		   {
			   Object ttttt = new Object(); //lock (ttttt) { tHA.Add(array); }
		   }
		   else
		   {
			   Object ttttt = new Object(); //lock (ttttt) { array.Wait(); }
		   }
		   */
			//array.Name = "H" + i.ToString();
		}
		else if (kind == 4)
		{
			OutPutAction = std::wstring(L" ") + Alphabet(CastlesOnTable[ik].CastleThinking[0].Row) + Number(CastlesOnTable[ik].CastleThinking[0].Column) + Alphabet(CastlesOnTable[ik].CastleThinking[0].RowColumnCastle[j][0]) + Number(CastlesOnTable[ik].CastleThinking[0].RowColumnCastle[j][1]);
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nPerception Castle AStarGreedy By Bob at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}
			else
			{
				OutPut += std::wstring(L"\r\nPerception Castle AStarGreedy By Alice at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}

			PerceptionCount++;
			int iii = CastlesOnTable[ik].CastleThinking[0].RowColumnCastle[j][0];
			int jjj = CastlesOnTable[ik].CastleThinking[0].RowColumnCastle[j][1];
			int aa = a;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j]);
			int **Tab = CloneATable(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j]);
			int Ord = Order * -1;
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;
			//Task array = Task.Factory.StartNew(() => CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j]), Order, false, FOUND, LeafAStarGreedy));
			CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, iii, jjj, aa, Tab, Ord * -1, false, FOUND, LeafAStarGreedy);
			//array.Start();
			/*bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
			{
			    Object ttttt = new Object(); //lock (ttttt) { tHA.Add(array); }
			}
			else
			{
			    Object ttttt = new Object(); //lock (ttttt) { array.Wait(); }
			}
			*/
			//array.Name = "B" + i.ToString();
		}
		else if (kind == 5)
		{
			OutPutAction = std::wstring(L" ") + Alphabet(MinisterOnTable[ik].MinisterThinking[0].Row) + Number(MinisterOnTable[ik].MinisterThinking[0].Column) + Alphabet(MinisterOnTable[ik].MinisterThinking[0].RowColumnMinister[j][0]) + Number(MinisterOnTable[ik].MinisterThinking[0].RowColumnMinister[j][1]);
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nPerception Minister AStarGreedy By Bob at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}
			else
			{
				OutPut += std::wstring(L"\r\nPerception Minister AStarGreedy By Alice at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}

			PerceptionCount++;
			int iii = MinisterOnTable[ik].MinisterThinking[0].RowColumnMinister[j][0];
			int jjj = MinisterOnTable[ik].MinisterThinking[0].RowColumnMinister[j][1];
			int aa = a;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j]);
			int **Tab = CloneATable(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j]);
			int Ord = Order * -1;
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;

			//Task array = Task.Factory.StartNew(() => MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j]), Order, false, FOUND, LeafAStarGreedy));
			MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, iii, jjj, aa, Tab, Ord * -1, false, FOUND, LeafAStarGreedy);
			//array.Start();
			/*bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
			{
			    Object ttttt = new Object(); //lock (ttttt) { tHA.Add(array); }
			}
			else
			{
			    Object ttttt = new Object(); //lock (ttttt) { array.Wait(); }
			}*/
			//array.Name = "M" + i.ToString();
		}
		else if (kind == 6)
		{
			OutPutAction = std::wstring(L" ") + Alphabet(KingOnTable[ik].KingThinking[0].Row) + Number(KingOnTable[ik].KingThinking[0].Column) + Alphabet(KingOnTable[ik].KingThinking[0].RowColumnKing[j][0]) + Number(KingOnTable[ik].KingThinking[0].RowColumnKing[j][1]);
			if (Order == 1)
			{
				OutPut += std::wstring(L"\r\nPerception King AStarGreedy By Bob at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}
			else
			{
				OutPut += std::wstring(L"\r\nPerception King AStarGreedy By Alice at Level ") + StringConverterHelper::toString(iAStarGreedy) + std::wstring(L" By ") + StringConverterHelper::toString(PerceptionCount) + std::wstring(L"th Perception String ") + OutPutAction;
			}

			PerceptionCount++;

			int iii = KingOnTable[ik].KingThinking[0].RowColumnKing[j][0];
			int jjj = KingOnTable[ik].KingThinking[0].RowColumnKing[j][1];
			int aa = a;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(KingOnTable[ik].KingThinking[0].TableListKing[j]);
			int **Tab = CloneATable(KingOnTable[ik].KingThinking[0].TableListKing[j]);
			int Ord = Order * -1;
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].AStarGreedyString = this;

			//Task array = Task.Factory.StartNew(() => KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CloneATable(KingOnTable[ik].KingThinking[0].TableListKing[j]), Order, false, FOUND, LeafAStarGreedy));
			KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, iii, jjj, aa, Tab, Ord * -1, false, FOUND, LeafAStarGreedy);


			//array.Start();
			/*bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
			{
			    Object ttttt = new Object(); //lock (ttttt) { tHA.Add(array); }
			}
			else
			{
			    Object ttttt = new Object(); //lock (ttttt) { array.Wait(); }
			}*/
			//array.Name = "K" + i.ToString();
		}
	}
		bool AllDraw::FullGameThinkingTreeSoldier(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
		{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO1)
			{
				TaskBegin++;
				//int S = 0;
				while (ReturnFullGameThinkingTreeSemaphore(ik, 1))
				{
					//delay(2);
				}

			}
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)
					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return false;
					}
				}
			}

			//Parallel.For(0, SolderesOnTable[ik].SoldierThinking[0].TableListSolder.size(), j =>
			for (int j = 0; j < SolderesOnTable[ik].SoldierThinking[0].TableListSolder.size(); j++)
			{
				////auto ooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ooo)
				{
					if (CheckeHuristci(SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j], Order, ik, j, 0))
					{
						continue;
					}

					if (SolderesOnTable[ik].SoldierThinking[0].IsSupHu[j])
					{
						continue;
					}
					
						if (AllDraw::OrderPlate == Order)
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 1, true, j))
							{
								if (AllDraw::Blitz)
								{
									if (Index[0] != -1)
									{
										if (ik != Index[0])
										{
											BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 1);
											continue;
										}
										else
										{
										if (j != jindex[0])
										{
											BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 1);
											continue;
										}
										}
									}
									else
									{
										BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 1);
										continue;
									}
								}
								////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O3)
								{
									FullGameThinkingTreeInitialization(ik, j, Order, 1);
								}
								//SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j], Order, false);
								//ParameterizedThreadStart start = new ParameterizedThreadStart(SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
								if (SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() > 0)
								{
									////auto O = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O)
									{
										OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 1,FOUND,LeafAStarGreedy);

										Do = true;
									}
								}
							}
						}
						else
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 1, false, j))
							{
								//if (JI == 0)
								// if (Index[0] != -1)
								{
									if (Index[0] != -1)
									{
										if (ik != Index[0])
										{
											BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 1);
											continue;
										}
										else
										{
										if (j != jindex[0])
										{
											BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 1);
											continue;
										}
										}
									}
									else
									{
										BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 1);
										continue;
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 1);
									}
									//SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, SolderesOnTable[ik].SoldierThinking[0].TableListSolder[j], Order, false);
									//ParameterizedThreadStart start = new ParameterizedThreadStart(SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
									if (SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size() > 0)
									{
										////auto O = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O)
										{
											OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 1,FOUND,LeafAStarGreedy);

											Do = true;
										}
									}

								}
							}
						}
				
				}
			} //);
			/*if (tHA.size() > 1)
			{
			    Task array = Task.Factory.StartNew(() => Parallel.ForEach(tHA, items => Task.WaitAny(items)));
			    //array.Start();
			    Task.WaitAll(array);
			}
		*/
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				TaskEnd++;
			}
		}
		for (int h = 0; h < SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size(); h++)
		{
			SolderesOnTable[ik].WinOcuuredatChiled += SumOfObjects(SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[h], Order);
		}
		for (int h = 0; h < SolderesOnTable[ik].SoldierThinking[0].AStarGreedy.size(); h++)
		{
			SolderesOnTable[ik].LoseOcuuredatChiled += SumMinusOfObjects(SolderesOnTable[ik].SoldierThinking[0].AStarGreedy[h], Order);
		}

		return Do;
		//Elephant
		}
	bool AllDraw::FullGameThinkingTreeSoldierGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			
				////Parallel.For(0, SodierMidle, ik =>
				for (int ik = 0; ik < SodierMidle; ik++)
				{
					if (((&SolderesOnTable) != nullptr) && (&(SolderesOnTable[ik]) != nullptr) && (&(SolderesOnTable[ik].SoldierThinking) != nullptr) && (&(SolderesOnTable[ik].SoldierThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeSoldier(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeElephant(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO1)
			{
				TaskBegin++;
				while (ReturnFullGameThinkingTreeSemaphore(ik, 2))
				{
					//delay(2);
				}
			}
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)

					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return false;
					}


				}
			}

			////Parallel.For(0, ElephantOnTable[ik].ElefantThinking[0].TableListElefant.size(), j =>
			for (int j = 0; j < ElephantOnTable[ik].ElefantThinking[0].TableListElefant.size(); j++)
			{
				////auto ooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ooo)
				{
					if (CheckeHuristci(ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j], Order, ik, j, 0))
					{
						continue;
					}

					if (ElephantOnTable[ik].ElefantThinking[0].IsSupHu[j])
					{
						continue;
					}
					
						if (AllDraw::OrderPlate == Order)
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 2, true, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[1] != -1)
										{

											if (ik != Index[1])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 2);
												continue;
											}
											else
											{
												if (j != jindex[1])
												{
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 2);
												continue;
												}
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 2);
											continue;
										}
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 2);

										//ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j], Order, false);
										//ParameterizedThreadStart start = new ParameterizedThreadStart(ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
										if (ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() > 0)
										{
											////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (O)
											{
												OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 2,FOUND,LeafAStarGreedy);
												Do = true;
											}
										}
									}
							}
						}
						else
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 2, false, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[1] != -1)
										{

											if (ik != Index[1])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 2);
												continue;
											}
											else
											{
												if (j != jindex[1])
												{
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 2);
												continue;
												}
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 2);
											continue;
										}
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 2);

										//ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, ElephantOnTable[ik].ElefantThinking[0].TableListElefant[j], Order, false);
										//ParameterizedThreadStart start = new ParameterizedThreadStart(ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
										if (ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size() > 0)
										{
											////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (O)
											{
												OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 2, FOUND, LeafAStarGreedy);
												Do = true;
											}
										}

									}
							}
						}
				
				}
			} //);
			/*if (tHA.size() > 1)
			{
			    Task array = Task.Factory.StartNew(() => Parallel.ForEach(tHA, items => Task.WaitAny(items)));
			    //array.Start();
			    Task.WaitAll(array);
			}
			*/
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				TaskEnd++;
			}
		}
		for (int h = 0; h < ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size(); h++)
		{
			ElephantOnTable[ik].WinOcuuredatChiled += SumOfObjects(ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[h], Order);
		}
		for (int h = 0; h < ElephantOnTable[ik].ElefantThinking[0].AStarGreedy.size(); h++)
		{
			ElephantOnTable[ik].LoseOcuuredatChiled += SumMinusOfObjects(ElephantOnTable[ik].ElefantThinking[0].AStarGreedy[h], Order);
		}

		return Do;
	}
	bool AllDraw::FullGameThinkingTreeElephantGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Elephant
			
				////Parallel.For(0, ElefantMidle, ik =>
				for (int ik = 0; ik < ElefantMidle; ik++)
				{
					if (((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[ik]) != nullptr) && (&(ElephantOnTable[ik].ElefantThinking) != nullptr) && (&(ElephantOnTable[ik].ElefantThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeElephant(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeHourse(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{

		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO1)
			{
				TaskBegin++;
				//int S = 0;
				while (ReturnFullGameThinkingTreeSemaphore(ik, 3))
				{
					//delay(2);
				}
			}

			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)

					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return false;
					}

				}
			}

			////Parallel.For(0, HoursesOnTable[ik].HourseThinking[0].TableListHourse.size(), j =>
			for (int j = 0; j < HoursesOnTable[ik].HourseThinking[0].TableListHourse.size(); j++)
			{
				////auto ooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ooo)
				{
					if (CheckeHuristci(HoursesOnTable[ik].HourseThinking[0].TableListHourse[j], Order, ik, j, 0))
					{
						continue;
					}

					if (HoursesOnTable[ik].HourseThinking[0].IsSupHu[j])
					{
						continue;
					}

					
						if (AllDraw::OrderPlate == Order)
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 3, true, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[2] != -1)
										{

											if (ik != Index[2])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 3);
												continue;
											}
											else
											{
												if (j != jindex[2])
												{
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 3);
												continue;
												}
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 3);
											continue;
										}
									}

									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 3);
									}
									//HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, HoursesOnTable[ik].HourseThinking[0].TableListHourse[j], Order, false);
									//ParameterizedThreadStart start = new ParameterizedThreadStart(HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
									if (HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() > 0)
									{
										////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O)
										{
											OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 3, FOUND, LeafAStarGreedy);
											Do = true;
										}
									}

							}
							else
							{
								if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 3, false, j))
								{

										if (AllDraw::Blitz)
										{
											if (Index[2] != -1)
											{

												if (ik != Index[2])
												{
													BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 3);
													continue;
												}
												else
												{
													if (j != jindex[2])
													{
													BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 3);
													continue;
													}
												}
											}
											else
											{
												BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 3);
												continue;
											}
										}

										////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O3)
										{
											FullGameThinkingTreeInitialization(ik, j, Order, 3);
										}
										//HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, HoursesOnTable[ik].HourseThinking[0].TableListHourse[j], Order, false);
										//ParameterizedThreadStart start = new ParameterizedThreadStart(HoursesOnTable[ik].HourseThinking[0].AStarGreedy[HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
										if (HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size() > 0)
										{
											////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
											//lock (O)
											{
												OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 3, FOUND, LeafAStarGreedy);
												Do = true;
											}
										}

								}
							}
						}
				
				}
			} //);
			/*if (tHA.size() > 1)
			{
			    Task array = Task.Factory.StartNew(() => Parallel.ForEach(tHA, items => Task.WaitAny(items)));
			    //array.Start();
			    Task.WaitAll(array);
			}
			*/
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				TaskEnd++;
			}
		}
		for (int h = 0; h < HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size(); h++)
		{
			HoursesOnTable[ik].WinOcuuredatChiled += SumOfObjects(HoursesOnTable[ik].HourseThinking[0].AStarGreedy[h], Order);
		}
		for (int h = 0; h < HoursesOnTable[ik].HourseThinking[0].AStarGreedy.size(); h++)
		{
			HoursesOnTable[ik].LoseOcuuredatChiled += SumMinusOfObjects(HoursesOnTable[ik].HourseThinking[0].AStarGreedy[h], Order);
		}

		return Do;
	}
	bool AllDraw::FullGameThinkingTreeHourseGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Hourse.
			
				////Parallel.For(0, HourseMidle, ik =>
				for (int ik = 0; ik < HourseMidle; ik++)
				{
					if (((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[ik]) != nullptr) && (&(HoursesOnTable[ik].HourseThinking) != nullptr) && (&(HoursesOnTable[ik].HourseThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeHourse(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeCastle(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{

		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO1)
			{
				TaskBegin++;

				while (ReturnFullGameThinkingTreeSemaphore(ik, 4))
				{
					//delay(2);
				}
			}
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)

					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return false;
					}

				}
			}

			////Parallel.For(0, CastlesOnTable[ik].CastleThinking[0].TableListCastle.size(), j =>
			for (int j = 0; j < CastlesOnTable[ik].CastleThinking[0].TableListCastle.size(); j++)
			{
				if (CheckeHuristci(CastlesOnTable[ik].CastleThinking[0].TableListCastle[j], Order, ik, j, 0))
				{
					continue;
				}

				if (CastlesOnTable[ik].CastleThinking[0].IsSupHu[j])
				{
					continue;
				}
				////auto ooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ooo)
				{
					
						if (AllDraw::OrderPlate == Order)
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 4, true, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[3] != -1)
										{
											if (ik != Index[3])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 4);
												continue;
											}
											else
											{
												if (j != jindex[0])
												{
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 4);
												continue;
												}
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 4);
											continue;
										}
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 4);
									}
									//CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CastlesOnTable[ik].CastleThinking[0].TableListCastle[j], Order, false);
									//ParameterizedThreadStart start = new ParameterizedThreadStart(CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
									if (CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() > 0)
									{
										////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O)
										{
											OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 4, FOUND, LeafAStarGreedy);
											Do = true;
										}
									}
							}
						}
						else
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 4, false, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[3] != -1)
										{
											if (ik != Index[3])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 4);
												continue;
											}
											else
											{
												if (j != jindex[0])
												{
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 4);
												continue;
												}
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 4);
											continue;
										}
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 4);
									}
									//CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, CastlesOnTable[ik].CastleThinking[0].TableListCastle[j], Order, false);
									//ParameterizedThreadStart start = new ParameterizedThreadStart(CastlesOnTable[ik].CastleThinking[0].AStarGreedy[CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
									if (CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size() > 0)
									{
										////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O)
										{
											OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 4, FOUND, LeafAStarGreedy);
											Do = true;
										}
									}

							}
						}
				
				}
			} //);
			/*if (tHA.size() > 1)
			{
			    Task array = Task.Factory.StartNew(() => Parallel.ForEach(tHA, items => Task.WaitAny(items)));
			    //array.Start();
			    Task.WaitAll(array);
			}*/
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				TaskEnd++;
			}
		}
		for (int h = 0; h < CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size(); h++)
		{
			CastlesOnTable[ik].WinOcuuredatChiled += SumOfObjects(CastlesOnTable[ik].CastleThinking[0].AStarGreedy[h], Order);
		}
		for (int h = 0; h < CastlesOnTable[ik].CastleThinking[0].AStarGreedy.size(); h++)
		{
			CastlesOnTable[ik].LoseOcuuredatChiled += SumMinusOfObjects(CastlesOnTable[ik].CastleThinking[0].AStarGreedy[h], Order);
		}

		return Do;
	}
	bool AllDraw::FullGameThinkingTreeCastleGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Castle.
			
				////Parallel.For(0, CastleMidle, ik =>
				for (int ik = 0; ik < CastleMidle; ik++)
				{
					if (((&CastlesOnTable) != nullptr) &&(&(CastlesOnTable[ik]) != nullptr) && (&(CastlesOnTable[ik].CastleThinking) != nullptr) && (&(CastlesOnTable[ik].CastleThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeCastle(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeMinister(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO1)
			{
				TaskBegin++;

				while (ReturnFullGameThinkingTreeSemaphore(ik, 5))
				{
					//delay(2);
				}
			}
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)

					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return false;
					}


				}
			}

			////Parallel.For(0, MinisterOnTable[ik].MinisterThinking[0].TableListMinister.size(), j =>
			for (int j = 0; j < MinisterOnTable[ik].MinisterThinking[0].TableListMinister.size(); j++)
			{
				if (CheckeHuristci(MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order, ik, j, 0))
				{
					continue;
				}

				if (MinisterOnTable[ik].MinisterThinking[0].IsSupHu[j])
				{
					continue;
				}

				////auto ooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ooo)
				{

					
						if (AllDraw::OrderPlate == Order)
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 5, true, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[4] != -1)
										{
											if (ik != Index[4])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 5);
												continue;
											}
											else
											{
												 if (j != jindex[4])

												 {
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 5);
												continue;
												 }
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 5);
											continue;
										}
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 5);
									}
									//MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order, false);
									//ParameterizedThreadStart start = new ParameterizedThreadStart(MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
									if (MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() > 0)
									{
										////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O)
										{
											OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 5, FOUND, LeafAStarGreedy);
											Do = true;

										}

									}
							}
						}
						else
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 5, false, j))
							{

									if (AllDraw::Blitz)
									{
										if (Index[4] != -1)
										{
											if (ik != Index[4])
											{
												BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 5);
												continue;
											}
											else
											{
												 if (j != jindex[4])

												 {
												BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 5);
												continue;
												 }
											}
										}
										else
										{
											BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 5);
											continue;
										}
									}
									////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O3)
									{
										FullGameThinkingTreeInitialization(ik, j, Order, 5);
									}
									//MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, MinisterOnTable[ik].MinisterThinking[0].TableListMinister[j], Order, false);
									//ParameterizedThreadStart start = new ParameterizedThreadStart(MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
									if (MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size() > 0)
									{
										////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O)
										{
											OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 5, FOUND, LeafAStarGreedy);
											Do = true;

										}

									}

							}
						}
				
				}
			} //);
			/*if (tHA.size() > 1)
			{
			    Task array = Task.Factory.StartNew(() => Parallel.ForEach(tHA, items => Task.WaitAny(items)));
			    Task.WaitAll(array);
			    //array.Start();
			}
			*/
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				TaskEnd++;
			}
		}
		for (int h = 0; h < MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size(); h++)
		{
			MinisterOnTable[ik].WinOcuuredatChiled += SumOfObjects(MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[h], Order);
		}
		for (int h = 0; h < MinisterOnTable[ik].MinisterThinking[0].AStarGreedy.size(); h++)
		{
			MinisterOnTable[ik].LoseOcuuredatChiled += SumMinusOfObjects(MinisterOnTable[ik].MinisterThinking[0].AStarGreedy[h], Order);
		}

		return Do;
	}
	bool AllDraw::FullGameThinkingTreeMinisterGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Minister.
			
				////Parallel.For(0, MinisterMidle, ik =>
				for (int ik = 0; ik < MinisterMidle; ik++)
				{
					if (((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[ik]) != nullptr) && (&(MinisterOnTable[ik].MinisterThinking) != nullptr) && (&(MinisterOnTable[ik].MinisterThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeMinister(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeKing(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO1)
			{
				TaskBegin++;
				//int S = 0;
				while (ReturnFullGameThinkingTreeSemaphore(ik, 6))
				{
					//delay(2);
				}
			}
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OOOO)
			{
				{
				//if (iAStarGreedy < 0)

					if (FullBoundryConditions(CurrentAStarGredyMax, Order, iAStarGreedy))
					{
						return false;
					}


				}

			}

			if (KingOnTable[ik].KingThinking[0].TableListKing.empty())
			{
				return Do;
			}
			// //Parallel.For(0, KingOnTable[ik].KingThinking[0].TableListKing.size(), j =>
			for (int j = 0; j < KingOnTable[ik].KingThinking[0].TableListKing.size(); j++)
			{
				if (CheckeHuristci(KingOnTable[ik].KingThinking[0].TableListKing[j], Order, ik, j, 0))
				{
					continue;
				}

				if (KingOnTable[ik].KingThinking[0].IsSupHu[j])
				{
					continue;
				}

				////auto ooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (ooo)
				{

					
						if (AllDraw::OrderPlate == Order)
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 6, true, j))
							{
								if (AllDraw::Blitz)
								{
									if (Index[5] != -1)
									{
										if (ik != Index[5])
										{
											BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 6);
											continue;
										}
										else
										{
											 if (j != jindex[5])
											 {
											BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 6);
											continue;
											 }
										}
									}
									else
									{
										BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 6);
										continue;
									}

								}
								////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O3)
								{
									FullGameThinkingTreeInitialization(ik, j, Order, 6);
								}
								//KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, KingOnTable[ik].KingThinking[0].TableListKing[j], Order, false);
								//ParameterizedThreadStart start = new ParameterizedThreadStart(KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
								if (KingOnTable[ik].KingThinking[0].AStarGreedy.size() > 0)
								{
									////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O)
									{
										OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 6, FOUND, LeafAStarGreedy);
										Do = true;
									}
								}
							}
						}
						else
						{
							if (ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(ik, 6, false, j))
							{
								if (AllDraw::Blitz)
								{
									if (Index[5] != -1)
									{
										if (ik != Index[5])
										{
											BlitzNotValidFullGameThinkingTreePartOne(ik, Order, 6);
											continue;
										}
										else
										{
											 if (j != jindex[5])
											 {
											BlitzNotValidFullGameThinkingTreePartTow(ik, Order, 6);
											continue;
											 }
										}
									}
									else
									{
										BlitzNotValidFullGameThinkingTreePartThree(ik, Order, 6);
										continue;
									}

								}
								////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O3)
								{
									FullGameThinkingTreeInitialization(ik, j, Order, 6);
								}
								//KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt(iAStarGreedy, ii, jj, a, KingOnTable[ik].KingThinking[0].TableListKing[j], Order, false);
								//ParameterizedThreadStart start = new ParameterizedThreadStart(KingOnTable[ik].KingThinking[0].AStarGreedy[KingOnTable[ik].KingThinking[0].AStarGreedy.size() - 1].InitiateAStarGreedyt);
								if (KingOnTable[ik].KingThinking[0].AStarGreedy.size() > 0)
								{
									////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O)
									{
										OpOfFullGameThinkingTree(ik, j, Order, iAStarGreedy, ii, jj, a, 6, FOUND, LeafAStarGreedy);
										Do = true;
									}
								}
							}
						}
				
				}
			} //);
			/*if (tHA.size() > 1)
			{
			    Task array = Task.Factory.StartNew(() => Parallel.ForEach(tHA, items => Task.WaitAny(items)));
			    Task.WaitAll(array);
			    //array.Start();
			}*/
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				TaskEnd++;
			}
		}
		for (int h = 0; h < KingOnTable[ik].KingThinking[0].AStarGreedy.size(); h++)
		{
			KingOnTable[ik].WinOcuuredatChiled += SumOfObjects(KingOnTable[ik].KingThinking[0].AStarGreedy[h], Order);
		}
		for (int h = 0; h < KingOnTable[ik].KingThinking[0].AStarGreedy.size(); h++)
		{
			KingOnTable[ik].LoseOcuuredatChiled += SumMinusOfObjects(KingOnTable[ik].KingThinking[0].AStarGreedy[h], Order);
		}

		return Do;
	}
	bool AllDraw::FullGameThinkingTreeKingGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			//int ik;
			//King.
			
				////Parallel.For(0, KingMidle, ik =>
				for (int ik = 0; ik < KingMidle; ik++)
				{
					if (((&KingOnTable) != nullptr) && (&(KingOnTable[ik]) != nullptr) && (&(KingOnTable[ik].KingThinking) != nullptr) && (&(KingOnTable[ik].KingThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeKing(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeSoldierBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			
				////Parallel.For(SodierMidle, SodierHigh, ik =>
				for (int ik = SodierMidle; ik < SodierHigh; ik++)
				{
					if (((&SolderesOnTable) != nullptr) && (&(SolderesOnTable[ik]) != nullptr) && (&(SolderesOnTable[ik].SoldierThinking) != nullptr) && (&(SolderesOnTable[ik].SoldierThinking[0]) != nullptr))
					{
						//Soldier.
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeSoldier(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeElephantBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Elephant
			
				////Parallel.For(ElefantMidle, ElefantHigh, ik =>
				for (int ik = ElefantMidle; ik < ElefantHigh; ik++)
				{
					if (((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[ik] )!= nullptr) && (&(ElephantOnTable[ik].ElefantThinking) != nullptr) && (&(ElephantOnTable[ik].ElefantThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeElephant(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeHourseBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			//Hourse.
			
				////Parallel.For(HourseMidle, HourseHight, ik =>
				for (int ik = HourseMidle; ik < HourseHight; ik++)
				{
					if (((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[ik]) != nullptr) && (&(HoursesOnTable[ik].HourseThinking) != nullptr) && (&(HoursesOnTable[ik].HourseThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeHourse(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeCastleBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			//Castles.
			
				////Parallel.For(CastleMidle, CastleHigh, ik =>
				for (int ik = CastleMidle; ik < CastleHigh; ik++)
				{
					if (((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[ik]) != nullptr) && (&(CastlesOnTable[ik].CastleThinking) != nullptr) && (&(CastlesOnTable[ik].CastleThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeCastle(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeMinisterBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Minister.
			
				////Parallel.For(MinisterMidle, MinisterHigh, ik =>
				for (int ik = MinisterMidle; ik < MinisterHigh; ik++)
				{
					if (((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[ik]) != nullptr) && (&(MinisterOnTable[ik].MinisterThinking) != nullptr) && (&(MinisterOnTable[ik].MinisterThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeMinister(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}
				} //);
		
		}
		return Do;
	}
	bool AllDraw::FullGameThinkingTreeKingBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		bool Do = false;
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			//King.
			
				////Parallel.For(KingMidle, KingHigh, ik =>
				for (int ik = KingMidle; ik < KingHigh; ik++)
				{

					if (((&KingOnTable) != nullptr) && (&(KingOnTable[ik]) != nullptr) && (&(KingOnTable[ik].KingThinking) != nullptr) && (&(KingOnTable[ik].KingThinking[0]) != nullptr))
					{
						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							Do = FullGameThinkingTreeKing(ik, a, Order, iAStarGreedy, ii, jj, ik1, j1, FOUND, LeafAStarGreedy);
						}
					}

				} //);
		
			{
				//if (JI == 0)
				//if (JI == 1)
				//if (JI == 2)
				//if (JI == 3)
				//if (JI == 4)
				//if (JI == 5)
			}
		}
		return Do;
	}
	int** AllDraw::CloneATable(int** Tab)
	{
		int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tab[i][j];
			}
		}
		return Table;
	}
	//best movement indexes founder method.
	
	
	bool AllDraw::TableZero(int** Ta)
	{
		bool Zerro = true;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (Ta[i][j] != 0)
				{
					Zerro = false;
				}
			}
		}
		return Zerro;
	}
	
	//Main Initiate Thinking Method.
	int** AllDraw::Initiate(int ii, int jj, int a, int** Table, int Order, bool TB, bool FOUND, int LeafAStarGreedy, bool SetDept = false)
	{
		////auto parallelOptions = new ParallelOptions();
		//parallelOptions->MaxDegreeOfParallelism = PlatformHelper::ProcessorCount;
		SetDeptIgnore = SetDept;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableHuristic = nullptr;
		int **TableHuristic = nullptr;
		int Current = ChessRules::CurrentOrder;
		int DummyOrder = Order;

		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			AllDraw::ActionStringReady = false;
			ThinkingChess::LearningVarsCheckedMateOccured = false;
			ThinkingChess::LearningVarsCheckedMateOccuredOneCheckedMate = false;
			RegardOccurred = false;
			////auto OO21 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (OO21)
			{
				TaskBegin = 0;
				TaskEnd = 0;
			}

			////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (OO1)
			{
				MaxDuringLevelThinkingCreation = StringConverterHelper::fromString<int>(AllDraw::THIScomboBoxMaxLevelText);
			}
			////auto Om1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (Om1)
			{
				MinThinkingTreeDepth = 0;
			}

			ThinkingChess::FoundFirstMating = 0;
			ThinkingChess::FoundFirstSelfMating = 0;
			//Monitor Log File Appending First Line. 
			////auto On = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (On)
			{

				OutPut += std::wstring(L"\n\r=====================================================================================================================================================================<br/>");
				;
				OutPut += std::wstring(L"\n\rMovment Number: ") +StringConverterHelper::toString(AllDraw::MovmentsNumber);

			}
			//Initiate Local and Global Variables.            
			////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (ol)
			{
				CurrentHuristic = -DBL_MAX;
				MaxHuristicxT = -DBL_MAX;
				DrawCastle::MaxHuristicxC = -DBL_MAX;
				DrawElefant::MaxHuristicxE = -DBL_MAX;
				DrawHourse::MaxHuristicxH = -DBL_MAX;
				DrawKing::MaxHuristicxK = -DBL_MAX;
				DrawMinister::MaxHuristicxM = -DBL_MAX;
				DrawSoldier::MaxHuristicxS = -DBL_MAX;
				MovementsAStarGreedyHuristicFoundT = false;
				DrawTable = false;
				ChessRules::CheckBrownObjectDangourFirstTimesOcured = false;
				ChessRules::CheckGrayObjectDangourFirstTimesOcured = false;
			}
		}

			MaxHuristicAStarGreedytBackWard.clear();

//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = nullptr;
			int **Tab = nullptr;

			if (!FOUND)
			{
				////auto O7 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				////lock (O7)
				{
					ThinkingChess::NotSolvedKingDanger = false;
					LoopHuristicIndex = 0;
					Less = -DBL_MAX;
				}
			}
			{
			//Invoke((MethodInvoker)delegate()
				////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				////lock (OOO)
				{
					if (!SetDept)
					{
						MaxAStarGreedy = AllDraw::MaxDuringLevelThinkingCreation;
					}
					AllDraw::AStarGreedyiLevelMax = MaxAStarGreedy;
					AStarGreedyiLevelMax = AllDraw::MaxDuringLevelThinkingCreation;
					AllDraw::MaxAStarGreedyHuristicProgress = 6;
					for (int i = 0; i <= MaxAStarGreedy; i++)
					{
						AllDraw::MaxAStarGreedyHuristicProgress += AllDraw::MaxAStarGreedyHuristicProgress * 6;
					}
					increasedProgress = static_cast<double>(999999999) / static_cast<double>(AllDraw::MaxAStarGreedyHuristicProgress);
					////auto Omm1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					////lock (Omm1)
					{
						AStarGreedytMaxCount = static_cast<double>(MaxAStarGreedy);
					}
				}
			} //);

			ChessRules::CurrentOrder = Current;
			Order = DummyOrder;
			int iiii = ii, jjjj = jj, Ord = Order;
			int MaxAStarGreedy1 = 0;
			////auto OOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		   ////lock (OOOO)
		   {
				MaxAStarGreedy1 = MaxAStarGreedy;
		   }
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tabl = CloneATable(Table);
			int **Tabl = CloneATable(Table);
			int aaa = a;
			InitiateAStarGreedyt(MaxAStarGreedy1, iiii, jjjj, aaa, Tabl, Ord, false, FOUND, LeafAStarGreedy);

			////auto Om = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (Om)
			{
				MinThinkingTreeDepth = MaxAStarGreedy - MinThinkingTreeDepth;
				//Initaite Local Varibales.
				Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
				Less = -DBL_MAX;
			}
			ChessRules::CurrentOrder = Current;
			Order = DummyOrder;
			////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (OO)
			{
				OutPut += std::wstring(L"\r\nMinimum Thinking Tree Depth:") + StringConverterHelper::toString(MinThinkingTreeDepth) + std::wstring(L"!");
			}
			Order = OrderP;

			TableHuristic = HuristicAStarGreedySearch(0, a, Order, false);
		if ((TableHuristic == nullptr || ((TableZero(TableHuristic)))) && UsePenaltyRegardMechnisamT)
		{

			
				////auto OOoOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				////lock (OOoOO)
				{
					OutPut += std::wstring(L"\r\nTable Zero.Possibly Full Penalty!");


					//RefreshBoxText();
					bool aa = UsePenaltyRegardMechnisamT;
					UsePenaltyRegardMechnisamT = false;
					//THISDummy = THISDummy.RemovePenalltyFromFirstBranches(Order);
					RemovePenalltyFromFirstBranches(Order);
					MaxAStarGreedy = 1;
					AStarGreedyiLevelMax = 1;
					Less = -DBL_MAX;
					//TableHuristic = THISDummy.HuristicAStarGreedySearchPenalties(0, a, Order, false);
					//TableHuristic = THISDummy.HuristicAStarGreedySearch(0, a, Order, false);
					TableHuristic = HuristicAStarGreedySearch(0, a, Order, false);
					//THISDummy.UsePenaltyRegardMechnisamT = aa;
					UsePenaltyRegardMechnisamT = aa;
				}

		
		}
		else
		{
		if ((TableHuristic == nullptr || ((TableZero(TableHuristic)))))
		{
			OutPut += std::wstring(L"\r\nTable Zero.Possibly Full failed!");
		}
		}

		//If Table Found.

		if (TableHuristic != nullptr)
		{
			////auto OOOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (OOOOO)
			{
				Ord = Order;
				if (Ord == 1)
				{
					OutPut += std::wstring(L"\r\nHuristic Find Best Movements AStarGreedy ") + StringConverterHelper::toString(AStarGreedy) + std::wstring(L" By Bob!");
				}
				else
				{
					OutPut += std::wstring(L"\r\nHuristic Find Best Movements AStarGreedy ") + StringConverterHelper::toString(AStarGreedy) + std::wstring(L" By Alice!");

				}
			}
			Order = DummyOrder;
			ChessRules::CurrentOrder = Current;
		}
		else
		{
			////auto OOoOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (OOoOO)
			{
				//Clear AStarGreedy Varibales.
				AllDraw::StoreADraw.clear();
				TableCurrent.clear();
				AStarGreedy = 0;
			}

			Order = DummyOrder;
			ChessRules::CurrentOrder = Current;
			//THISDummy.Dispose();
			////auto Omm = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (Omm)
			{
				DrawTable = true;
				FoundATable = true;
			}
		}
		return TableHuristic;
	}
	bool AllDraw::FullGameThinkingTree(int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy)
	{
		//List<Task> tH = new List<Task>();
		bool Do = false;
		//Initiatye Variables.
		int DummyOrder = Order;
		int DummyCurrentOrder = ChessRules::CurrentOrder;

		int a;
		if (Order == 1)
			a = 1;
		else
			a = -1;
		////Order *= -1;
		//Index = -1;
		//jindex = -1;
		//Kind =
		//Object O = new Object();
		//lock(O)
		{
			if (AllDraw::Blitz)
				FullGameMakimgBlitz(Index, jindex, Order, LeafAStarGreedy);
		}
		

		if (Order == -1)
		{
		//Index[0] = -1;
		//Soldeir
		//Initiatye Variables.
		int ii1 = ii, jj1 = jj, ik11 = ik1, j11 = j1;
		int Ord1 = Order;
		int a1 = a;
		int iAStarGreedy1 = iAStarGreedy;
		Do |= FullGameThinkingTreeSoldierGray(a1, Ord1, iAStarGreedy1, ii1, jj1, ik11, j11, FOUND, LeafAStarGreedy);
		//array1.Start();
		//Object tttt1 = new Object(); lock (tttt1) { TH.Add(array1); }

		Order = DummyOrder;
		ChessRules::CurrentOrder = DummyCurrentOrder;


		if (Order == 1)
		a = 1;
		else
		a = -1;
		//Order *= -1;
		//ChessRules::CurrentOrder *= -1;

		int ii2 = ii, jj2 = jj, ik12 = ik1, j12 = j1;
		int Ord2 = Order;
		int a2 = a;
		int iAStarGreedy2 = iAStarGreedy;
		Do |= FullGameThinkingTreeElephantGray(a2, Ord2, iAStarGreedy2, ii2, jj2, ik12, j12, FOUND, LeafAStarGreedy);
		//array2.Start();
		//Object tttt2 = new Object(); lock (tttt2) { TH.Add(array2); }

		//Initiatye Variables.
		Order = DummyOrder;
		ChessRules::CurrentOrder = DummyCurrentOrder;


		if (Order == 1)
		a = 1;
		else
		a = -1;
		//Order *= -1;
		//ChessRules::CurrentOrder *= -1;

		int ii3 = ii, jj3 = jj, ik13 = ik1, j13 = j1;
		int Ord3 = Order;
		int a3 = a;
		int iAStarGreedy3 = iAStarGreedy;
		 Do |= FullGameThinkingTreeHourseGray(a3, Ord3, iAStarGreedy3, ii3, jj3, ik13, j13, FOUND, LeafAStarGreedy);
		///array3.Start();
		//Object tttt3 = new Object(); lock (tttt3) { TH.Add(array3); }

		//Initiatye Variables.
		Order = DummyOrder;
		ChessRules::CurrentOrder = DummyCurrentOrder;


		if (Order == 1)
		a = 1;
		else
		a = -1;
		//Order *= -1;
		//ChessRules::CurrentOrder *= -1;

		int ii4 = ii, jj4 = jj, ik14 = ik1, j14 = j1;
		int Ord4 = Order;
		int a4 = a;
		int iAStarGreedy4 = iAStarGreedy;
		Do |= FullGameThinkingTreeCastleGray(a4, Ord4, iAStarGreedy4, ii4, jj4, ik14, j14, FOUND, LeafAStarGreedy);
		//array4.Start();
		//Object tttt4 = new Object(); lock (tttt4) { TH.Add(array4); }

		//Initiatye Variables.
		Order = DummyOrder;
		ChessRules::CurrentOrder = DummyCurrentOrder;


		if (Order == 1)
		a = 1;
		else
		a = -1;
		//Order *= -1;
		//ChessRules::CurrentOrder *= -1;
		int ii5 = ii, jj5 = jj, ik15 = ik1, j15 = j1;
		int Ord5 = Order;
		int a5 = a;
		int iAStarGreedy5 = iAStarGreedy;
		 Do |= FullGameThinkingTreeMinisterGray(a5, Ord5, iAStarGreedy5, ii5, jj5, ik15, j15, FOUND, LeafAStarGreedy);
		//array5.Start();
		//Object tttt5 = new Object(); lock (tttt5) { TH.Add(array5); }

		//Initiatye Variables.
		Order = DummyOrder;
		ChessRules::CurrentOrder = DummyCurrentOrder;


		if (Order == 1)
		a = 1;
		else
		a = -1;
		//Order *= -1;
		//ChessRules::CurrentOrder *= -1;
		int ii6 = ii, jj6 = jj, ik16 = ik1, j16 = j1;
		int Ord6 = Order;
		int a6 = a;
		int iAStarGreedy6 = iAStarGreedy;
		 Do |= FullGameThinkingTreeKingGray(a6, Ord6, iAStarGreedy6, ii6, jj6, ik16, j16, FOUND, LeafAStarGreedy);
		//array6.Start();
		//Object tttt6 = new Object(); lock (tttt6) { TH.Add(array6); }

		}
		//For Brown Order Blitz Game Calculate Maximum Table Inclusive AStarGreedy First Game Search.
		else
		{
			int ii1 = ii, jj1 = jj, ik11 = ik1, j11 = j1;
			int Ord1 = Order;
			int a1 = a;
			int iAStarGreedy1 = iAStarGreedy;
			 Do |= FullGameThinkingTreeSoldierBrown(a1, Ord1, iAStarGreedy1, ii1, jj1, ik11, j11, FOUND, LeafAStarGreedy);
			//array1.Start();
			//Object tttt1 = new Object(); lock (tttt1) { TH.Add(array1); }

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;


			if (Order == 1)
				a = 1;
			else
				a = -1;
			//Order *= -1;
			//ChessRules::CurrentOrder *= -1;

			int ii2 = ii, jj2 = jj, ik12 = ik1, j12 = j1;
			int Ord2 = Order;
			int a2 = a;
			int iAStarGreedy2 = iAStarGreedy;
			 Do |= FullGameThinkingTreeElephantBrown(a2, Ord2, iAStarGreedy2, ii2, jj2, ik12, j12, FOUND, LeafAStarGreedy);
			//array2.Start();
			//Object tttt2 = new Object(); lock (tttt2) { TH.Add(array2); }

			//Initiatye Variables.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;


			if (Order == 1)
				a = 1;
			else
				a = -1;
			//Order *= -1;
			//ChessRules::CurrentOrder *= -1;

			int ii3 = ii, jj3 = jj, ik13 = ik1, j13 = j1;
			int Ord3 = Order;
			int a3 = a;
			int iAStarGreedy3 = iAStarGreedy;
			 Do |= FullGameThinkingTreeHourseBrown(a3, Ord3, iAStarGreedy3, ii3, jj3, ik13, j13, FOUND, LeafAStarGreedy);
			///array3.Start();
			//Object tttt3 = new Object(); lock (tttt3) { TH.Add(array3); }

			//Initiatye Variables.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;


			if (Order == 1)
				a = 1;
			else
				a = -1;
			//Order *= -1;
			//ChessRules::CurrentOrder *= -1;

			int ii4 = ii, jj4 = jj, ik14 = ik1, j14 = j1;
			int Ord4 = Order;
			int a4 = a;
			int iAStarGreedy4 = iAStarGreedy;
			 Do |= FullGameThinkingTreeCastleBrown(a4, Ord4, iAStarGreedy4, ii4, jj4, ik14, j14, FOUND, LeafAStarGreedy);
			//array4.Start();
			//Object tttt4 = new Object(); lock (tttt4) { TH.Add(array4); }

			//Initiatye Variables.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;


			if (Order == 1)
				a = 1;
			else
				a = -1;
			//Order *= -1;
			//ChessRules::CurrentOrder *= -1;
			int ii5 = ii, jj5 = jj, ik15 = ik1, j15 = j1;
			int Ord5 = Order;
			int a5 = a;
			int iAStarGreedy5 = iAStarGreedy;
			 Do |= FullGameThinkingTreeMinisterBrown(a5, Ord5, iAStarGreedy5, ii5, jj5, ik15, j15, FOUND, LeafAStarGreedy);
			//array5.Start();
			//Object tttt5 = new Object(); lock (tttt5) { TH.Add(array5); }

			//Initiatye Variables.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;


			if (Order == 1)
				a = 1;
			else
				a = -1;
			//Order *= -1;
			//ChessRules::CurrentOrder *= -1;
			int ii6 = ii, jj6 = jj, ik16 = ik1, j16 = j1;
			int Ord6 = Order;
			int a6 = a;
			int iAStarGreedy6 = iAStarGreedy;
			Do |= FullGameThinkingTreeKingBrown(a6, Ord6, iAStarGreedy6, ii6, jj6, ik16, j16, FOUND, LeafAStarGreedy);
		}
		

		return Do;
	}

	void AllDraw::FoundOfLeafDepenOfKindFullGame(int** table, int Order, int iAStarGreedy, int ii, int jj, int ik, int jjj, bool FOUND, int LeafAStarGreedy)
	{
		//Object a1 = new Object();
		//lock(a1)
		{
			//if()
			bool FullGameFound = false;
			//if (ThinkingChess::FoundFirstMating > MaxAStarGreedy)
			//   return;
			//Object O = new Object();
			//lock(O)
			{
				table = CloneATable(table);
				//OutPut += "\r\nLeaf Tree Creation is " + LeafAStarGreedy.ToString() + "at AStarGreedy " + iAStarGreedy.ToString();
				if (Order == 1)
				{

					for (int i = 0; i < SodierMidle; i++)
						for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) &&  (&(SolderesOnTable[i].SoldierThinking[0]) != nullptr) && j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size(); j++)
						{

							
								if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);

								}
								else
									for (int iii = 0; iii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										SolderesOnTable[i].SoldierThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(SolderesOnTable[i].SoldierThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}

							
						}
					for (int i = 0; i < ElefantMidle; i++)
						for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking[0]) != nullptr) && j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size(); j++)
						{
							
								if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										ElephantOnTable[i].ElefantThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(ElephantOnTable[i].ElefantThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}


							
						}
					for (int i = 0; i < HourseMidle; i++)
						for (int j = 0; ((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking[0]) != nullptr) && j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size(); j++)
						{
								if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										HoursesOnTable[i].HourseThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(HoursesOnTable[i].HourseThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}



						}
					for (int i = 0; i < CastleMidle; i++)
						for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking[0]) != nullptr) && j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size(); j++)
						{
							
								if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										CastlesOnTable[i].CastleThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(CastlesOnTable[i].CastleThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}
							

						}
					for (int i = 0; i < MinisterMidle; i++)
						for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking[0]) != nullptr) && j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size(); j++)
						{
								if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										MinisterOnTable[i].MinisterThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(MinisterOnTable[i].MinisterThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}


							

						}
					for (int i = 0; i < KingMidle; i++)
						for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking[0]) != nullptr) && j < KingOnTable[i].KingThinking[0].TableListKing.size(); j++)
						{
							
								if (KingOnTable[i].KingThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										KingOnTable[i].KingThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(KingOnTable[i].KingThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}

							

						}
				}
				else
				{
					for (int i = SodierMidle; i < SodierHigh; i++)
						for (int j = 0; ((&SolderesOnTable) != nullptr) && ((&(SolderesOnTable[i])) != nullptr) &&  (&(SolderesOnTable[i].SoldierThinking) != nullptr) && j < SolderesOnTable[i].SoldierThinking[0].TableListSolder.size(); j++)
						{
							

								if (SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; ii < SolderesOnTable[i].SoldierThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										SolderesOnTable[i].SoldierThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(SolderesOnTable[i].SoldierThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}
							
						}
					for (int i = ElefantMidle; i < ElefantHigh; i++)
						for (int j = 0; ((&ElephantOnTable) != nullptr) && (&(ElephantOnTable[i]) != nullptr) && (&(ElephantOnTable[i].ElefantThinking[0]) != nullptr) && j < ElephantOnTable[i].ElefantThinking[0].TableListElefant.size(); j++)
						{
							

								if (ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < ElephantOnTable[i].ElefantThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										ElephantOnTable[i].ElefantThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(ElephantOnTable[i].ElefantThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}
							
						}
					for (int i = HourseMidle; i < HourseHight; i++)
						for (int j = 0; ((& HoursesOnTable) != nullptr) && (&(HoursesOnTable[i]) != nullptr) && (&(HoursesOnTable[i].HourseThinking[0]) != nullptr) && j < HoursesOnTable[i].HourseThinking[0].TableListHourse.size(); j++)
						{
							

								if (HoursesOnTable[i].HourseThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < HoursesOnTable[i].HourseThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										HoursesOnTable[i].HourseThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(HoursesOnTable[i].HourseThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}
							
						}
					for (int i = CastleMidle; i < CastleHigh; i++)
						for (int j = 0; ((&CastlesOnTable) != nullptr) && (&(CastlesOnTable[i]) != nullptr) && (&(CastlesOnTable[i].CastleThinking[0]) != nullptr) && j < CastlesOnTable[i].CastleThinking[0].TableListCastle.size(); j++)
						{
							

								if (CastlesOnTable[i].CastleThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < CastlesOnTable[i].CastleThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										CastlesOnTable[i].CastleThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(CastlesOnTable[i].CastleThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}

							
						}
					for (int i = MinisterMidle; i < MinisterHigh; i++)
						for (int j = 0; ((&MinisterOnTable) != nullptr) && (&(MinisterOnTable[i]) != nullptr) && (&(MinisterOnTable[i].MinisterThinking[0]) != nullptr) && j < MinisterOnTable[i].MinisterThinking[0].TableListMinister.size(); j++)
						{
							
								if (MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size() == 0)
								{

									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < MinisterOnTable[i].MinisterThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										MinisterOnTable[i].MinisterThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(MinisterOnTable[i].MinisterThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}

							
						}
					for (int i = KingMidle; i < KingHigh; i++)
						for (int j = 0; ((&KingOnTable) != nullptr) && (&(KingOnTable[i]) != nullptr) && (&(KingOnTable[i].KingThinking[0]) != nullptr) && j < KingOnTable[i].KingThinking[0].TableListKing.size(); j++)
						{
							
								if (KingOnTable[i].KingThinking[0].AStarGreedy.size() == 0)
								{
									FullGameFound = true;
									FullGameThinkingTree(Order, iAStarGreedy, ii, jj, ik, jjj, false, LeafAStarGreedy);
								}
								else
									for (int iii = 0; iii < KingOnTable[i].KingThinking[0].AStarGreedy.size(); iii++)
									{
										ThinkingChess::NumbersOfAllNode++;
										KingOnTable[i].KingThinking[0].AStarGreedy[iii].FoundOfLeafDepenOfKindFullGame(KingOnTable[i].KingThinking[0].TableT, Order * -1, iAStarGreedy, ii, jj, ik, jjj, FOUND, LeafAStarGreedy++);
									}


							
						}
				}
			}
			if (!FullGameFound)
			{
				
					iAStarGreedy++;
					int a = 1;
					if (Order == -1)
						a = -1;
					InitiateAStarGreedytObject(MaxAStarGreedy, ii, jj, a, table, Order, false, false, LeafAStarGreedy);
					//Initiate(ii, jj, a, table, Order, false, false,LeafAStarGreedy);
				
			}
			return;
		}
	}

	//Identification of Illegal AStarGreedy First and Common Hurist Movments.

	void AllDraw::InitializeInstanceFields()
	{
		SetDeptIgnore = false;
		
		OrderP = 0;
		PerceptionCount = 0;
		OutPutAction = L"";
		ValuableSelfSupported = std::vector<int*>();
		CurrentAStarGredyMax = 0;
		SetRowColumnFinished = false;
		MaxHuristicxT = -DBL_MAX;
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		int temp_Index[6] = {-1, -1, -1, -1, -1, -1};
		for (int element = 0; element < sizeof(temp_Index) / sizeof(temp_Index[0]); element++)
			Index[element] = temp_Index[element];
		int temp_jindex[6] = {-1, -1, -1, -1, -1, -1};
		for (int element = 0; element < sizeof(temp_jindex) / sizeof(temp_jindex[0]); element++)
			jindex[element] = temp_jindex[element];
		int temp_Kind[6] = {-1, -1, -1, -1, -1, -1};
		for (int element = 0; element < sizeof(temp_Kind) / sizeof(temp_Kind[0]); element++)
			Kind[element] = temp_Kind[element];
		ArrangmentsChanged = false;
		CastlesKing = false;
		MaxHuristicAStarGreedytBackWardTable = std::vector<int**>();
		SodierMidle = 0;
		SodierHigh = 0;
		ElefantMidle = 0;
		ElefantHigh = 0;
		HourseMidle = 0;
		HourseHight = 0;
		CastleMidle = 0;
		CastleHigh = 0;
		MinisterMidle = 0;
		MinisterHigh = 0;
		KingMidle = 0;
		KingHigh = 0;
		RW = 0;
		CL = 0;
		Ki = 0;
		RW1 = 0;
		CL1 = 0;
		Ki1 = 0;
		MaxLess1 = 0;
		RW2 = 0;
		CL2 = 0;
		Ki2 = 0;
		MaxLess2 = 0;
		RW3 = 0;
		CL3 = 0;
		Ki3 = 0;
		MaxLess3 = 0;
		RW4 = 0;
		CL4 = 0;
		Ki4 = 0;
		MaxLess4 = 0;
		RW5 = 0;
		CL5 = 0;
		Ki5 = 0;
		MaxLess5 = 0;
		RW6 = 0;
		CL6 = 0;
		Ki6 = 0;
		MaxLess6 = 0;
		Move = 0;
		TableList = std::vector<int**>();
		AStarGreedy = 0;
		MaxHuristicAStarGreedytBackWard = std::vector<double*>();
		AStarGreedyString = 0;
	}
	}