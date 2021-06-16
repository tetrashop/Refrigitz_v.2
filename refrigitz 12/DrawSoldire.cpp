#pragma once
#include "DrawSoldire.h"
#include "DrawMinister.h"
#include "DrawCastle.h"
#include "DrawHourse.h"
#include "DrawElefant.h"
#include "ThinkingChess.h"

//namespace RefrigtzDLL
//{
	inline bool operator==( const DrawSoldier& lhs,  DrawSoldier& rhs) { return  (lhs == rhs); }
	inline bool operator!=( const DrawSoldier& lhs,  DrawSoldier& rhs) { return !(lhs == rhs); }

double DrawSoldier::MaxHuristicxS = -DBL_MAX;

	/*void DrawSoldier<T>::Log(std::exception ex)
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
const DrawSoldier& DrawSoldier::operator[] (const int index) const
{
	return this[index];
}

	DrawSoldier::~DrawSoldier()
	{
		InitializeInstanceFields();
		ValuableSelfSupported.clear();
//		S = nullptr;
	}
	bool DrawSoldier::MaxFound(bool MaxNotFound)
	{
		
			double a = ReturnHuristic();
			if (MaxHuristicxS < a)
			{
				
					MaxNotFound = false;
					if (ThinkingChess::MaxHuristicx < MaxHuristicxS)
					{
						ThinkingChess::MaxHuristicx = a;
					}
					MaxHuristicxS = a;
				
				return true;
			}
		
		MaxNotFound = true;
		return false;
	}

	double DrawSoldier::ReturnHuristic()
	{
		double a = 0;
		a += SoldierThinking[0].ReturnHuristic(-1, -1, Order, false);
		return a;
	}
	DrawSoldier::DrawSoldier(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments) //:ThingsConverter()
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
	DrawSoldier::DrawSoldier(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int** Tab, int Ord, bool TB, int Cur) : ThingsConverter(Arrangments, i, j, a, Tab, Ord, TB, Cur)
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
		//Initiate Global Variables.  
		Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii] =new  int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Table[ii][jj] = Tab[ii][jj];
			}
		}
		SoldierThinking = std::vector<ThinkingChess>();
		SoldierThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(i), static_cast<int>(j), a, Tab, 4, Ord, TB, Cur, 16, 1));
		RowS = i;
		ColumnS = j;
		color = a;
		Order = Ord;
		Current = Cur;

	}
	//void* DrawSoldier<T>::operator*(std::size_t idx) { return malloc(idx * sizeof(this)); }
	/*
	void DrawSoldier::Clone(DrawSoldier AA)
	{
		int **Tab;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate a Object and Assignemt of a Clone to Construction of a Copy.

		AA = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, RowS, ColumnS, color, Tab, Order, false, Current);
		AA.ArrangmentsChanged = ArrangmentsChanged;
		AA.SoldierThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(RowS), static_cast<int>(ColumnS)));
		//RefrigtzDLL::SoldierThinking.Clone(AA.RefrigtzDLL::SoldierThinking);
		AA.Table = new int*[8]; for (int ii = 0; ii < 8; ii++)AA.Table[ii] - new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				AA.Table[ii][jj] = Tab[ii][jj];
			}
		}
		AA.RowS = RowS;
		AA.ColumnS = ColumnS;
		AA.Order = Order;
		AA.Current = Current;
		AA.color = color;

	}
	*/


	void DrawSoldier::DrawSoldierOnTable(float CellW, float CellH)
	{
		/*///autobalance//lockS = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (balance//lockS)
		{
			if (S == nullptr || S[1] == nullptr)
			{
				S = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"SG.png"));
				S[1] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"SB.png"));
			}
			//When Conversion Solders Not Occured.
			if (!ConvertOperation(static_cast<T>(Row), static_cast<T>(Column), color, Table, Order, false, Current))
			{

				//Gray T.
				if ((static_cast<T>(Row) >= 0) static_cast<T>(Row) < 8) static_cast<T>(Column) >= 0) static_cast<T>(Column) < 8))
				{
					//try
					{

						//If Order is Gray.
						if (Order == 1)
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								g.DrawImage(S, Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));

							}
						}
						else
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								 //Draw an Instatnt of Brown Soldier File On the Table.
								g.DrawImage(S[1], Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
					}
					//catch(std::exception t)
					{
						
					}

				}
				else //If Minsister Conversion Occured.
				{
					if (ConvertedToMinister)
					{
					//try
					{
						//T of Gray.
						if (Order == 1)
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								 //Draw of Gray Minsister Image File By an Instant.
								g.DrawImage(DrawMinister::M, Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
						else
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								 //Draw a Image File on the Table Form n Instatnt One.
								g.DrawImage(DrawMinister::M[1], Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
					}
					//catch(std::exception t)
					{
						
					}
					}
				else if (ConvertedToCastle) //When Castled Converted.
				{
					//try
					{
						//T of Gray.
						if (Order == 1)
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								 //Create on the Inststant of Gray Castles Images.
								g.DrawImage(DrawCastle::C, Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
						else
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								 //Creat of an Instant of Brown Image Castles.
								g.DrawImage(DrawCastle::C[1], Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
					}
					//catch(std::exception t)
					{
						
					}
				}
				else if (ConvertedToHourse) //When Hourse Conversion Occured.
				{

					//try
					{
						//T of Gray.
						if (Order == 1)
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instatnt of Gray Hourse Image File.
								g.DrawImage(DrawHourse::H, Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
						else
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Creat of an Instatnt Hourse Image File.
								g.DrawImage(DrawHourse::H[1], Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
					}
					//catch(std::exception t)
					{
						
					}

				}
				else if (ConvertedToElefant) //When Elephant Conversion.
				{
					//try
					{
						//T of Gray.
						if (Order == 1)
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instatnt Image of Gray Elephant.
								g.DrawImage(DrawElefant::E, Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}
						else
						{
							//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw of Instant Image of Brown Elephant.
								g.DrawImage(DrawElefant::E[1], Rectangle(static_cast<T>(Row * static_cast<T>(CellW)), static_cast<T>(Column * static_cast<T>(CellH)), CellW, CellH));
							}
						}

					}
					//catch(std::exception t)
					{
						
					}
				}
				}
			}
		}*/
	}

	void DrawSoldier::InitializeInstanceFields()
	{
		WinOcuuredatChiled = 0;
		LoseOcuuredatChiled = 0;
		//ValuableSelfSupported = std::vector<AllDraw>();
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		ArrangmentsChanged = false;
		RowS = 0;
		ColumnS = 0;
		Table = 0;
		Order = 0;
		Current = 0;
		CurrentAStarGredyMax = -1;
	}
//}
