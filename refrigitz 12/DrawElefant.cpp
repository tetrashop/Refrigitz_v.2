#pragma once
#include "DrawElefant.h"
#include "DrawSoldire.h"
#include "DrawMinister.h"
#include "DrawCastle.h"
#include "DrawHourse.h"
#include "DrawElefant.h"
#include "ThinkingChess.h"

//namespace RefrigtzDLL
//{
	inline bool operator==(const DrawElefant& lhs,  const std::nullptr_t& rhs) { return  (lhs == rhs); }
	inline bool operator!=(const DrawElefant& lhs,  const std::nullptr_t& rhs) { return !(lhs == rhs); }

double DrawElefant::MaxHuristicxE = -20000000000000000;

	/*void DrawElefant::Log(std::exception ex)
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
const DrawElefant& DrawElefant::operator[] (const int index) const
{
	return this[index];
}

	DrawElefant::~DrawElefant()
	{
		InitializeInstanceFields();
		ValuableSelfSupported.clear();
//		E = nullptr;
	}

	bool DrawElefant::MaxFound(bool MaxNotFound)
	{
		//try
		{
			double a = ReturnHuristic();
			if (MaxHuristicxE < a)
			{
				//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					MaxNotFound = false;
					if (ThinkingChess::MaxHuristicx < MaxHuristicxE)
					{
						ThinkingChess::MaxHuristicx = a;
					}
					MaxHuristicxE = a;
				}
				return true;
			}
		}
		//catch(std::exception t)
		{
			

		}
		MaxNotFound = true;
		return false;
	}
	//void* DrawElefant::operator*(std::size_t idx) { return malloc(idx * sizeof(this)); }
	double DrawElefant::ReturnHuristic()
	{
		double a = 0;
		for (int ii = 0; ii < AllDraw::ElefantMovments; ii++)
		{
			//try
			{
				a += ElefantThinking[0].ReturnHuristic(-1, -1, Order, false);
			}
			//catch(std::exception t)
			{
				
			}
		}

		return a;
	}
	DrawElefant::DrawElefant(int CurrentAStarGredy, bool MoveentsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		CurrentAStarGredyMax = CurrentAStarGredy;
		MovementsAStarGreedyHuristicFoundT = MoveentsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		ArrangmentsChanged = Arrangments;
	}

	DrawElefant::DrawElefant(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur)
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
		//Initiate Global Variables By Local Parameters.
		Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii] - new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Table[ii][jj] = Tab[ii][jj];
			}
		}
		ElefantThinking = std::vector<ThinkingChess>();
		ElefantThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(i), static_cast<int>(j), a, Tab, 16, Ord, TB, Cur, 4, 2));

		Row = i;
		Column = j;
		color = a;
		Order = Ord;
		Current = Cur;


	}

	
	void DrawElefant::Clone(DrawElefant AA)
	{
		int **Tab;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate a Constructed Object an Clone a Copy.
		AA = DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, color, Table, Order, false, Current);
		AA.ArrangmentsChanged = ArrangmentsChanged;
		for (int i = 0; i < AllDraw::ElefantMovments; i++)
		{
			
				AA.ElefantThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(Row), static_cast<int>(Column)));
				//ElefantThinking[0].Clone(AA.ElefantThinking);
			
		}
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
	
	void DrawElefant::DrawElefantOnTable( int CellW, int CellH)
	{
	/*	//try
		{

			//autobalance//lockS = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (balance//lockS)
			{
				if (E == nullptr || E[1] == nullptr)
				{
					E = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"EG.png"));
					E[1] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"EB.png"));
				}

				//Gray int.
				if ((static_cast<int>(Row) >= 0) static_cast<int>(Row) < 8) static_cast<int>(Column) >= 0) static_cast<int>(Column) < 8))
				{
					if (Order == 1)
					{
						//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{ //Draw an Instant from File of Gray Soldeirs.
							 //Draw an Instatnt Gray Elephant On the Table.
							g.DrawImage(E, Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));
						}
					}
					else
					{
						//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{ //Draw an Instant from File of Gray Soldeirs.
							 //Draw an Instatnt Brown Elepehnt On the Table.
							g.DrawImage(E[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));
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

	void DrawElefant::InitializeInstanceFields()
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
