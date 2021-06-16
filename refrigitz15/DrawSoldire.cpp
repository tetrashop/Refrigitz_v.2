#pragma once
#include <string>
#include <vector>
#include <stdexcept>
#include "DrawSoldire.h"
#include "AllDraw.h"
#include "ThinkingChess.h"

namespace RefrigtzDLL
{
	inline bool operator==(const DrawSoldier& lhs, DrawSoldier& rhs) { return  (lhs == rhs); }
	inline bool operator!=(const DrawSoldier& lhs, DrawSoldier& rhs) { return !(lhs == rhs); }


	double DrawSoldier::MaxHuristicxS = -DBL_MAX;



	DrawSoldier::~DrawSoldier()
	{
		InitializeInstanceFields();
		ValuableSelfSupported.clear();
		//S = nullptr;
	}

	bool DrawSoldier::MaxFound(bool &MaxNotFound)
	{

		double a = ReturnHuristic();
		if (MaxHuristicxS < a)
		{
			//auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{
				MaxNotFound = false;
				if (ThinkingChess::MaxHuristicx < MaxHuristicxS)
				{
					ThinkingChess::MaxHuristicx = a;
				}
				MaxHuristicxS = a;
			}
			return true;
		}

		MaxNotFound = true;
		return false;
	}

	double DrawSoldier::ReturnHuristic()
	{
		double a = 0;
		for (int ii = 0; ii < AllDraw::SodierMovments; ii++)

		{
			a += SoldierThinking[ii].ReturnHuristic(-1, -1, Order, false);
		}

		return a;
	}
	const DrawSoldier& DrawSoldier::operator[] (const int index) const
	{
		return this[index];
	}
	DrawSoldier::DrawSoldier(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int **Tab, int Ord, bool TB, int Cur) : ThingsConverter(Arrangments, i, j, a, Tab, Ord, TB, Cur)
	{
		InitializeInstanceFields();
		//auto balance//lock = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (balance//lock)
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
			//Initiate Global Variables.  
			Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];

			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					Table[ii][jj] = Tab[ii][jj];
				}
			}
			SoldierThinking = std::vector<ThinkingChess>();
			SoldierThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, i, j, a, Tab, 4, Ord, TB, Cur, 16, 1));

			RowS = i;
			ColumnS = j;
			color = a;
			Order = Ord;
			Current = Cur;
		}
	}

	void DrawSoldier::Clone(DrawSoldier AA)
	{
		int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate a Object and Assignemt of a Clone to Construction of a Copy.

		AA = DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, color, Tab, Order, false, Current);
		AA.ArrangmentsChanged = ArrangmentsChanged;
		for (int i = 0; i < AllDraw::SodierMovments; i++)
		{

			AA.SoldierThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column));
			SoldierThinking[i].Clone(AA.SoldierThinking[i]);

		}
		AA.Table = new int*[8]; for (int g = 0; g < 8; g++)AA.Table[g] = new int[8];

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

	void DrawSoldier::DrawSoldierOnTable(int CellW, int CellH)
	{
		try
		{
			////auto balance////lockS = new Object();

//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (balance//lockS)
			{
				/*if (S[0] == nullptr || S[1] == nullptr)
				{
					S[0] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"SG.png"));
					S[1] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"SB.png"));
				}*/
				//When Conversion Solders Not Occured.
				if (!ConvertOperation(static_cast<int>(Row), static_cast<int>(Column), color, Table, Order, false, Current))
				{

					//Gray int.
					if ((static_cast<int>(Row) >= 0) && (static_cast<int>(Row) < 8) && (static_cast<int>(Column) >= 0) && (static_cast<int>(Column) < 8))
					{


						//If Order is Gray.
						if (Order == 1)
						{
							//auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								//g->DrawImage(S[0], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));

							}
						}
						else
						{
							//auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{ //Draw an Instant from File of Gray Soldeirs.
								 //Draw an Instatnt of Brown Soldier File On the Table.
								//g->DrawImage(S[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
							}
						}


					}
					else //If Minsister Conversion Occured.
					{
						if (ConvertedToMinister)
						{

							//int of Gray.
							if (Order == 1)
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw an Instant from File of Gray Soldeirs.
									 //Draw of Gray Minsister Image File By an Instant.
									//g->DrawImage(DrawMinister::M[0], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}
							else
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw an Instant from File of Gray Soldeirs.
									 //Draw a Image File on the Table Form n Instatnt One.
									//g->DrawImage(DrawMinister::M[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}

						}
						else if (ConvertedToCastle) //When Castled Converted.
						{

							//int of Gray.
							if (Order == 1)
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw an Instant from File of Gray Soldeirs.
									 //Create on the Inststant of Gray Castles Images.
									//g->DrawImage(DrawCastle::C[0], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}
							else
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw an Instant from File of Gray Soldeirs.
									 //Creat of an Instant of Brown Image Castles.
									//g->DrawImage(DrawCastle::C[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}

						}
						else if (ConvertedToHourse) //When Hourse Conversion Occured.
						{


							//int of Gray.
							if (Order == 1)
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw an Instatnt of Gray Hourse Image File.
									//g->DrawImage(DrawHourse::H[0], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * CellH)), CellW, CellH));
								}
							}
							else
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Creat of an Instatnt Hourse Image File.
									//g->DrawImage(DrawHourse::H[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}


						}
						else if (ConvertedToElefant) //When Elephant Conversion.
						{

							//int of Gray.
							if (Order == 1)
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw an Instatnt Image of Gray Elephant.
									//g->DrawImage(DrawElefant::E[0], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}
							else
							{
								//auto O1 = new Object();
	//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{ //Draw of Instant Image of Brown Elephant.
									//g->DrawImage(DrawElefant::E[1], Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
								}
							}


						}
					}
				}
			}
		}
		catch (std::exception &t)
		{

		}
	}

	void DrawSoldier::InitializeInstanceFields()
	{
		WinOcuuredatChiled = 0;
		LoseOcuuredatChiled = 0;
		ValuableSelfSupported = std::vector<int*>();
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
}
