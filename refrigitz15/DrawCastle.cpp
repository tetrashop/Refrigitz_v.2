#pragma once
#include "DrawCastle.h"



namespace RefrigtzDLL
{

	inline bool operator==(const DrawCastle& lhs, const std::nullptr_t& rhs) { return  (lhs == rhs); }
	inline bool operator!=(const DrawCastle& lhs, const std::nullptr_t& rhs) { return (lhs != rhs); }


	double DrawCastle::MaxHuristicxC = -20000000000000000;

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
	}
	*/
	const DrawCastle& DrawCastle::operator[] (const int index) const
	{
		return this[index];
	}

	DrawCastle::~DrawCastle()
	{
		InitializeInstanceFields();
		ValuableSelfSupported.clear();
		//		M = nullptr;
	}

	bool DrawCastle::MaxFound(bool &MaxNotFound)
	{

		double a = ReturnHuristic();
		if (MaxHuristicxC < a)
		{

			MaxNotFound = false;
			if (ThinkingChess::MaxHuristicx < MaxHuristicxC)
			{
				ThinkingChess::MaxHuristicx = a;
			}
			MaxHuristicxC = a;

			return true;
		}

		MaxNotFound = true;
		return false;
	}
	//void* DrawCastle::operator*(std::size_t idx) { return malloc(idx * sizeof(this)); }
	double DrawCastle::ReturnHuristic()
	{
		double a = 0;
		for (int ii = 0; ii < AllDraw::CastleMovments; ii++)
		{
			a += CastleThinking[0].ReturnHuristic(-1, -1, Order, false);

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

	DrawCastle::DrawCastle(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int** Tab, int Ord, bool TB, int Cur)
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
		Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii] = new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Table[ii][jj] = Tab[ii][jj];
			}
		}
		CastleThinking = std::vector<ThinkingChess>();
		CastleThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, i, j, a, Tab, 32, Ord, TB, Cur, 2, 5));

		Row = i;
		Column = j;
		color = a;
		Current = Cur;
		Order = Ord;
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
		//Initiate an Object and Clone a Construction Objectve.
		AA = DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, color, Table, Order, false, Current);
		AA.ArrangmentsChanged = ArrangmentsChanged;
		for (int i = 0; i < AllDraw::CastleMovments; i++)
		{
			AA.CastleThinking.push_back(ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column));

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

	void DrawCastle::DrawCastleOnTable(int CellW, int CellH)
	{
		/*		//try
		{

		//autobalance//lockS = new Object();

		//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (balance//lockS)
		{
		if (M == nullptr || M[1] == nullptr)
		{
		M = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"MG.png"));
		M[1] = Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"MB.png"));
		} //Gray int.
		if ((static_cast<int>(Row) >= 0) Row) < 8) Column) >= 0) Column) < 8))
		{
		//Gray Order.
		if (Order == 1)
		{
		//autoO1 = new Object();
		//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{ //Draw an Instant from File of Gray Soldeirs.
		//Draw a Gray Instatnt Castle Image on the Table.
		g.DrawImage(M, Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), Column * static_cast<float>(CellH)), CellW, CellH));
		}
		}
		else
		{
		//autoO1 = new Object();
		//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{ //Draw an Instant from File of Gray Soldeirs.
		//Draw a Brown Instatnt Castle Image on the Table.
		g.DrawImage(M[1], Rectangle(static_cast<int>(Row * CellW), Column * static_cast<float>(CellH)), CellW, CellH));
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

	void DrawCastle::InitializeInstanceFields()
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
		Row = 0;
		Column = 0;
		Table = 0;
		Current = 0;
		Order = 0;
		CurrentAStarGredyMax = -1;
	}
}
