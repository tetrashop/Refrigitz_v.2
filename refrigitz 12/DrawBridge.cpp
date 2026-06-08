#include "DrawBridge.h"


namespace RefrigtzDLL
{

double DrawBridge::MaxHuristicxB = -20000000000000000;

	/*void DrawBridge::Log(std::exception &ex)
	{
		try
		{
			std::wstring stackTrace = ex.what();
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			File::AppendAllText(AllDraw::Root + std::wstring(L"\\ErrorProgramRun.txt"), stackTrace + std::wstring(L": On") + DateTime::Now.ToString()); // path of file where stack trace will be stored.
		}
		catch (std::exception &t)
		{
			
		}
	}*/

	bool DrawBridge::MaxFound(bool &MaxNotFound)
	{
		try
		{
			double a = ReturnHuristic();
			if (MaxHuristicxB < a)
			{
				MaxNotFound = false;
				if (ThinkingChess::MaxHuristicx < MaxHuristicxB)
				{
					ThinkingChess::MaxHuristicx = a;
				}
				MaxHuristicxB = a;
				return true;
			}
		}
		catch (std::exception &t)
		{
			

		}
		MaxNotFound = true;
		return false;
	}

	double DrawBridge::ReturnHuristic()
	{
		double a = 0;
	
				a += BridgeThinking.ReturnHuristic(-1, -1, Order);
	
		return a;
	}

	DrawBridge::DrawBridge(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
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
	}

	DrawBridge::DrawBridge(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int Tab[8][8], int Ord, bool TB, int Cur)
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
		Table = new int*[8]; for (int ii = 0; ii < 8; ii++) Table[ii] = new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Table[ii][jj] = Tab[ii][jj];
			}
		}
		for (int ii = 0; ii < AllDraw::BridgeMovments; ii++)
		{
			BridgeThinking[ii] = new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(i), static_cast<int>(j), a, Tab, 16, Ord, TB, Cur, 4, 4);
		}

		Row = i;
		Column = j;
		color = a;
		Order = Ord;
		Current = Cur;

	}

	void DrawBridge::Clone(DrawBridge *&AA)
	{
		int Tab[8][8];
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = this->Table[i][j];
			}
		}
		//Initiate a Constructed Brideges an Clone a Copy.
		AA = new DrawBridge(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, this->Row, this->Column, this->color, this->Table, this->Order, false, this->Current);
		AA->ArrangmentsChanged = ArrangmentsChanged;
		for (int i = 0; i < AllDraw::BridgeMovments; i++)
		{
			try
			{
				AA->BridgeThinking[i] = new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, static_cast<int>(this->Row), static_cast<int>(this->Column));
				this->BridgeThinking[i].Clone(AA->BridgeThinking[i]);
			}
			catch (std::exception &t)
			{
				
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
				delete AA->BridgeThinking[i];
			}
		}
		AA->Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii]-new int[8];
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				AA->Table[ii][jj] = Tab[ii][jj];
			}
		}
		AA->Row = Row;
		AA->Column = Column;
		AA->Order = Order;
		AA->Current = Current;
		AA->color = color;

	}

	void DrawBridge::DrawBridgeOnTable( int CellW, int CellH)
	{
		try
		{
			if ((static_cast<int>(Row) >= 0) && (static_cast<int>(Row) < 8) && (static_cast<int>(Column) >= 0) && (static_cast<int>(Column) < 8))
			{ //Gray int.
				if (color == 1)
				{
					//Draw a Gray Bridges Instatnt Image On hte Tabe.
					g->DrawImage(Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"BrG.png")), Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));
				}
				else
				{
					//Draw an Instatnt of Brown Bridges On the Table.
					g->DrawImage(Image::FromFile(AllDraw::ImagesSubRoot + std::wstring(L"BrB.png")), Rectangle(static_cast<int>(Row * static_cast<float>(CellW)), static_cast<int>(Column * static_cast<float>(CellH)), CellW, CellH));
				}
			}
		}
		catch (std::exception &t)
		{
			
		}
	}
}
