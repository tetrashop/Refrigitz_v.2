#pragma once
#include "DrawKing.h"
#include "DrawSoldire.h"
#include "DrawMinister.h"
#include "DrawCastle.h"
#include "DrawHourse.h"
#include "DrawElefant.h"
#include "ThinkingChess.h"

//namespace RefrigtzDLL
//{
    inline bool operator==(const DrawKing& lhs, const std::nullptr_t& rhs) { return  (lhs == rhs); }
	inline bool operator!=(const DrawKing& lhs, const std::nullptr_t& rhs) { return !(lhs == rhs); }

bool DrawKing::KingGrayNotCheckedByQuantumMove = false;
bool DrawKing::KingBrownNotCheckedByQuantumMove = false;
double DrawKing::MaxHuristicxK = -20000000000000000;

	/*void DrawKing::Log(std::exception ex)
	{
		//try
		{
			//autoa = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (a)
			{
				std::wstring stackTrace = ex.what();
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				File::AppendAllText(AllDraw::Root + std::wstring(L"\\ErrorProgramRun.txt"), stackTrace + std::wstring(L": On") + DateTime::Now.ToString()); // path of file where stack trace will be stored.
			}
		}
		//catch(std::exception t)
		{
			
		}
	}
	*/
	DrawKing::~DrawKing()
	{
		InitializeInstanceFields();
		ValuableSelfSupported.clear();
//		K = nullptr;
	}
	const DrawKing& DrawKing::operator[] (const int index) const
	{
		return this[index];
	}

	double DrawKing::ReturnHuristic()
	{
		double a = 0;
		for (int ii = 0; ii < AllDraw::KingMovments; ii++)
		{
			//try
			{
				a += KingThinking[0].ReturnHuristic(-1, -1, Order,false);
			}
			//catch(std::exception t)
			{
				
			}
		}

		return a;
	}
	//* DrawKing::operator*(std::size_t idx) { return malloc(idx * sizeof(this)); }
	bool DrawKing::MaxFound(bool MaxNotFound)
	{
		
			double a = ReturnHuristic();
			if (MaxHuristicxK < a)
			{
				
					MaxNotFound = false;
					if (ThinkingChess::MaxHuristicx < MaxHuristicxK)
					{
						ThinkingChess::MaxHuristicx = a;
					}
					MaxHuristicxK = a;
				
				return true;
			}
		
		MaxNotFound = true;
		return false;
	}
	DrawKing::DrawKing(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		CurrentAStarGredyMax = CurrentAStarGredy;
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		ArrangmentsChanged = Arrangments;
	}

	DrawKing::DrawKing(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur)
	{
		InitializeInstanceFields();



		CurrentAStarGredyMax = CurrentAStarGredy;
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		ArrangmentsChanged = Arrangments;
		//Iniatite Global Variables.
		Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii] =new  int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Table[ii][jj] = Tab[ii][jj];
			}
		}
		KingThinking = std::vector<ThinkingChess>();
		KingThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(i), static_cast<int>(j), a, Tab, 8, Ord, TB, Cur, 2, 6));

		Row = i;
		Column = j;
		color = a;
		Order = Ord;
		Current = Cur;
	}

	void DrawKing::Clone(DrawKing AA)
	{
		int **Tab;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate a Construction Object and Clone a Copy.
		AA = DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, color, Table, Order, false, Current);
		AA.ArrangmentsChanged = ArrangmentsChanged;
		AA.KingThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(Row), static_cast<int>(Column)));
		//KingThinking[0].Clone(AA.KingThinking);


		AA.Table = new int*[8]; for (int ii = 0; ii < 8; ii++)AA.Table[ii] - new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				AA.Table[ii][jj] = Tab[ii][jj];
			}
		}
		AA.Row = Row;
		AA.Column = Column;
		AA.Order = Order;
		AA.Current = Current;
		AA.color = color;

	}
	
	void DrawKing::DrawKingOnTable( int CellW, int CellH)
	{/*

		//try
		{

			//autobalance//lockS = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (balance//lockS)
			{
				if (K == nullptr || K[1] == nullptr)
				{
					K = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"KG.png"));
					K[1] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"KB.png"));
				}
				if ((static_cast<int>(Row) >= 0) static_cast<int>(Row) < 8) static_cast<int>(Column) >= 0) static_cast<int>(Column) < 8))
				{ //Gray Order.
					if (Order == 1)
					{
						//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{ //Draw an Instant from File of Gray Soldeirs.
							 //Draw an Instatnt Gray King Image On the Table.
							g.DrawImage(K, Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));

						}

					}
					else
					{
						//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{ //Draw an Instant from File of Gray Soldeirs.
							 //Draw an Instatnt Brown King Image On the Table.
							g.DrawImage(K[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));

						}
					}
				}
			}
		}
		//catch(std::exception t)
		{
			
		}
		*/
	}

	void DrawKing::InitializeInstanceFields()
	{
		WinOcuuredatChiled = 0;
		LoseOcuuredatChiled = 0;
		ValuableSelfSupported = std::vector<int>();
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		ArrangmentsChanged = false;
		Row = 0;
		Column = 0;
		Table = 0;
		Current = 0;
		Order = 0;
		CurrentAStarGredyMax = -1;
	}
//}
