#pragma once
#include "DrawCastle.h"
#include "DrawHourse.h"
#include "DrawSoldire.h"
#include "DrawMinister.h"
#include "DrawHourse.h"
#include "DrawElefant.h"

#include "ThinkingChess.h"

//namespace RefrigtzDLL
//{
	inline bool operator==(const DrawCastle& lhs,  const std::nullptr_t& rhs) { return  (lhs == rhs); }
	inline bool operator!=(const DrawCastle& lhs,  const std::nullptr_t& rhs) { return !(lhs == rhs); }

double DrawCastle::MaxHuristicxB = -20000000000000000;

	/*void DrawCastle::Log(std::exception ex)
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
	}*/

	DrawCastle::~DrawCastle()
	{
	//	InitializeInstanceFields();
		//ValuableSelfSupported.clear();
//		C = nullptr;
	}
	const DrawCastle& DrawCastle::operator[] (const int index) const
	{
		return this[index];
	}
	//void* DrawCastle::operator*(std::size_t idx) { return malloc(idx * sizeof(this)); }
	bool DrawCastle::MaxFound(bool MaxNotFound)
	{
		//try
		{
			double a = ReturnHuristic();
			if (MaxHuristicxB < a)
			{
				MaxNotFound = false;
				//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					if (ThinkingChess::MaxHuristicx < MaxHuristicxB)
					{
						ThinkingChess::MaxHuristicx = a;
					}
					MaxHuristicxB = a;
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

	double DrawCastle::ReturnHuristic()
	{
		double a = 0;
		for (int ii = 0; ii < AllDraw::CastleMovments; ii++)
		{
			//try
			{
				a += CastleThinking[0].ReturnHuristic(-1, -1, Order, false);
			}
			//catch(std::exception t)
			{
				
			}
		}

		return a;
	}
	DrawCastle::DrawCastle(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
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
	DrawCastle::DrawCastle(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur)
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
		//Initiate Global Variable By Local Parmenter.
		Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii]=new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Table[ii][jj] = Tab[ii][jj];
			}
		}
		CastleThinking = std::vector<ThinkingChess>();
		CastleThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(i), static_cast<int>(j), a, Tab, 16, Ord, TB, Cur, 4, 4));

		Row = i;
		Column = j;
		color = a;
		Order = Ord;
		Current = Cur;


	}
	
	void DrawCastle::Clone(DrawCastle AA)
	{
		int **Tab;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate a Constructed Brideges an Clone a Copy.
		AA = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, color, Table, Order, false, Current);
		AA.ArrangmentsChanged = ArrangmentsChanged;
		for (int i = 0; i < AllDraw::CastleMovments; i++)
		{
				AA.CastleThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(Row), static_cast<int>(Column)));
				//CastleThinking.Clone(AA.CastleThinking);
			
		}
		AA.Table = new int*[8]; for (int ii = 0; ii < 8; ii++) AA.Table[ii] - new int[8];
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
	
	void DrawCastle::DrawCastleOnTable( int CellW, int CellH)
	{
		/*//try
		{
			//autobalance//lockS = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (balance//lockS)
			{

				if (C == nullptr || C[1] == nullptr)
				{
					C = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"BrG.png"));
					C[1] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"BrB.png"));
				}
				if ((static_cast<int>(Row) >= 0) static_cast<int>(Row) < 8) static_cast<int>(Column) >= 0) static_cast<int>(Column) < 8))
				{ //Gray int.
					if (Order == 1)
					{
						//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{ //Draw an Instant from File of Gray Soldeirs.
							 //Draw a Gray Castles Instatnt Image On hte Tabe.
							g.DrawImage(C, Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));
						}
					}
					else
					{
						//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{ //Draw an Instant from File of Gray Soldeirs.
							 //Draw an Instatnt of Brown Castles On the Table.
							g.DrawImage(C[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));
						}
					}
				}
			}
		}
		//catch(std::exception t)
		{
			
		}*/
	}

	void DrawCastle::InitializeInstanceFields()
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
