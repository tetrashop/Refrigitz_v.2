#include "ChessPerdict.h"
#include "ChessRules.h"
#include "ThingsConverter.h"
#include "ThinkingChess.h"
#include "ChessGeneticAlgorithm.h"


namespace RefrigtzDLL
{

int ChessPerdict::SodierValue = 1;
int ChessPerdict::ElefantValue = 1;
int ChessPerdict::HourseValue = 1;
int ChessPerdict::CastleValue = 1;
int ChessPerdict::MinisterValue = 1;
int ChessPerdict::KingValue = 1;
int ChessPerdict::LoopHuristicIndex = 0;
std::vector<int> ChessPerdict::RWList = std::vector<int>();
std::vector<int> ChessPerdict::ClList = std::vector<int>();
std::vector<int> ChessPerdict::KiList = std::vector<int>();
std::vector<int[][]> ChessPerdict::TableListAction = std::vector<int[][]>();
int ChessPerdict::MouseClick = 0;

	void ChessPerdict::Log(std::exception &ex)
	{
		try
		{
			//autoa = new Object();
			////lock (a)
			{
				std::wstring stackTrace = ex.what();
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				File::AppendAllText(AllDraw::Root + std::wstring(L"\\ErrorProgramRun.txt"), stackTrace + std::wstring(L": On") + DateTime::Now.ToString()); // path of file where stack trace will be stored.
			}
		}
		catch (std::exception &t)
		{
			Log(t);
		}
	}

	void ChessPerdict::SetObjectNumbers(int TabS[8][8])
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

	float *ChessPerdict::FoundLocationOfObject(int Tabl[8][8], int Kind, bool IsGray)
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
						Location = i;
						Location[1] = j;
						Tabl[i][j] = 0;

					}
				}
				else
				{
					if (Tabl[i][j] * -1 == Kind)
					{
						Location = i;
						Location[1] = j;
						Tabl[i][j] = 0;

					}
				}

			}
		}
		return Location;
	}

	ChessPerdict::ChessPerdict(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		InitializeInstanceFields();
		CurrentAStarGredyMax = CurrentAStarGredy;
		MaxHuristicxT = -DBL_MAX;
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		ArrangmentsChanged = Arrangments;
		//Initiate Global Variable By Local Parameters.
		//THIS = Th;
		//A = new List<AllDraw>();
		if (TableList.size() > 0)
		{
			int A = 1;
			int Tab[8][8];
			for (int g = 0; g < 8; g++)
			{
				for (int k = 0; k < 8; k++)
				{
					Tab[g][k] = TableList[g][k];
				}
			}
			int Tabl[8][8];
			for (int g = 0; g < 8; g++)
			{
				for (int k = 0; k < 8; k++)
				{
					Tabl[g][k] = TableList[g][k];
				}
			}
			int Order = 1;
			bool TB = false;

			SolderesOnTable = new DrawSoldier[SodierHigh];
			for (int i = 0; i < SodierHigh; i++)
			{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
				float *Location = nullptr;
				if (i <= SodierMidle)
				{
					A = 1;
					Location = FoundLocationOfObject(Tabl, 1, true);
					Order = 1;
				}
				else
				{
					A = -1;
					Location = FoundLocationOfObject(Tabl, -1, false);
					Order = -1;
				}
				SolderesOnTable[i] = new DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
			}
			ElephantOnTable = new DrawElefant[ElefantHigh];
			for (int i = 0; i < ElefantHigh; i++)
			{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
				float *Location = nullptr;
				if (i <= ElefantMidle)
				{
					A = 1;
					Location = FoundLocationOfObject(Tabl, 1, true);
					Order = 1;
				}
				else
				{
					A = -1;
					Location = FoundLocationOfObject(Tabl, -1, false);
					Order = -1;
				}
				ElephantOnTable[i] = new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
			}
			HoursesOnTable = new DrawHourse[HourseHight];
			for (int i = 0; i < HourseHight; i++)
			{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
				float *Location = nullptr;
				if (i <= HourseMidle)
				{
					A = 1;
					Location = FoundLocationOfObject(Tabl, 1, true);
					Order = 1;
				}
				else
				{
					A = -1;
					Location = FoundLocationOfObject(Tabl, -1, false);
					Order = -1;
				}
				HoursesOnTable[i] = new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
			}
			CastlesOnTable = new DrawCastle[CastleHigh];
			for (int i = 0; i < CastleHigh; i++)
			{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
				float *Location = nullptr;
				if (i <= CastleMidle)
				{
					A = 1;
					Location = FoundLocationOfObject(Tabl, 1, true);
					Order = 1;
				}
				else
				{
					A = -1;
					Location = FoundLocationOfObject(Tabl, -1, false);
					Order = -1;
				}
				CastlesOnTable[i] = new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
			}
			MinisterOnTable = new DrawMinister[MinisterHigh];
			for (int i = 0; i < MinisterHigh; i++)
			{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
				float *Location = nullptr;
				if (i <= MinisterMidle)
				{
					A = 1;
					Location = FoundLocationOfObject(Tabl, 1, true);
					Order = 1;
				}
				else
				{
					A = -1;
					Location = FoundLocationOfObject(Tabl, -1, false);
					Order = -1;
				}
				MinisterOnTable[i] = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
			}
			KingOnTable = new DrawKing[KingHigh];
			for (int i = 0; i < KingHigh; i++)
			{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
				float *Location = nullptr;
				if (i <= KingMidle)
				{
					A = 1;
					Location = FoundLocationOfObject(Tabl, 1, true);
				}
				else
				{
					A = -1;
					Location = FoundLocationOfObject(Tabl, -1, false);
				}
				KingOnTable[i] = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
			}
		}
	}

	bool ChessPerdict::AllCurrentAStarGreedyThinkingFinished(AllDraw *Dum, int i, int j, int Kind)
	{
		//Initiate Local Variables.
		bool Finished = false;
		//Soldeir Kind.
		if (Kind == 1)
		{
			//Wait For Flag Become Valid.
			if (Dum->SolderesOnTable[i]->SoldierThinking[j].ThinkingFinished)
			{
				return true;
			}
		}
		//Elephant Kind.
		else if (Kind == 2)
		{
			//Wait For Flag Become Valid.
			if (Dum->ElephantOnTable[i]->ElefantThinking[j].ThinkingFinished)
			{
				return true;
			}
		} //Hourse Kind.
		else if (Kind == 3)
		{
			//Wait For Flag Become Valid.
			if (Dum->HoursesOnTable[i]->HourseThinking[j].ThinkingFinished)
			{
				return true;
			}
		} //Castles Kind.
		else if (Kind == 4)
		{
			//Wait For Flag Become Valid.
			if (Dum->CastlesOnTable[i]->CastleThinking[j].ThinkingFinished)
			{
				return true;
			}
		} //Minister Kind.
		else if (Kind == 5)
		{
			//Wait For Flag Become Valid.
			if (Dum->MinisterOnTable[i]->MinisterThinking[j].ThinkingFinished)
			{
				return true;
			}
		} //King Kind.
		else if (Kind == 6)
		{
			//Wait For Flag Become Valid.
			if (Dum->KingOnTable[i]->KingThinking[j].ThinkingFinished)
			{
				return true;
			}
		}
		//Return Flag.
		return Finished;

	}

	void ChessPerdict::Wait(AllDraw *Dum, int i, int j, int Kind)
	{
		//Wait For All Thinking Operation Finished.
		do
		{
			//THIS.SetBoxText("\r\nAStarGreedy Predict :" + AllDraw.SyntaxToWrite);
			//THIS.RefreshBoxText();

		} while (!AllCurrentAStarGreedyThinkingFinished(Dum, i, j, Kind));


	}

	void ChessPerdict::InitiateForEveryKindThingHome(AllDraw *DummyHA, int ii, int jj, int a, int Table[8][8], int Order, bool TB, int IN)
	{
		int i = 0, j = 0;
		AllDraw *Dummy = new AllDraw(Order, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged);
		//Gray Order.
		if (Order == 1)
		{
			//For All Gray Soldiers.
			for (i = 0; i < SodierMidle; i++)
			{
				try
				{
					//When Current Soldeir is Not Existing Continue Traversal Back.
					if (SolderesOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(SolderesOnTable[i]->Row);
					jj = static_cast<int>(SolderesOnTable[i]->Column);
					//Construction of Thinking Solders Gray Object.
					Dummy->SolderesOnTable[i] = new DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Movments.
					for (j = 0; j < AllDraw::SodierMovments; j++)
					{
						//Thinking Operations.
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->TableT = SolderesOnTable[i]->SoldierThinking[j].TableT;
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->ThinkingBegin = true;
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->ThinkingFinished = false;
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->t = new Task(new std::function<void()>(Dummy->SolderesOnTable[i]->SoldierThinking[j].Thinking));
						Dummy->SolderesOnTable[i]->SoldierThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 1);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->SolderesOnTable[i];
					Log(t);
				}
			}
			//For All Gray Elephant Objects.
			for (i = 0; i < ElefantMidle; i++)
			{
				try
				{
					//When Gray Elephant Not Existing Continue Traversal Back.
					if (ElephantOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(ElephantOnTable[i]->Row);
					jj = static_cast<int>(ElephantOnTable[i]->Column);
					//Construction of Gray Elepahnt Thinking Objectes.
					Dummy->ElephantOnTable[i] = new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Movments.
					for (j = 0; j < AllDraw::ElefantMovments; j++)
					{
						//Elephant Gray Thinking Operations.
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->TableT = ElephantOnTable[i]->ElefantThinking[j].TableT;
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->ThinkingBegin = true;
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->ThinkingFinished = false;
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->t = new Task(new std::function<void()>(Dummy->ElephantOnTable[i]->ElefantThinking[j].Thinking));
						Dummy->ElephantOnTable[i]->ElefantThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 2);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->ElephantOnTable[i];
					Log(t);
				}
			}


			//For All Hourse Gray Objects.
			for (i = 0; i < HourseMidle; i++)
			{
				try
				{
					//When Gray Hourses Not Exsisting Continue Traversal Back.
					if (HoursesOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(HoursesOnTable[i]->Row);
					jj = static_cast<int>(HoursesOnTable[i]->Column);

					Dummy->HoursesOnTable[i] = new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Movments.
					for (j = 0; j < AllDraw::HourseMovments; j++)
					{
						//Hourse Thinking Gray Objects Operations.
						Dummy->HoursesOnTable[i]->HourseThinking[j]->TableT = HoursesOnTable[i]->HourseThinking[j].TableT;
						Dummy->HoursesOnTable[i]->HourseThinking[j]->ThinkingBegin = true;
						Dummy->HoursesOnTable[i]->HourseThinking[j]->ThinkingFinished = false;
						Dummy->HoursesOnTable[i]->HourseThinking[j]->t = new Task(new std::function<void()>(Dummy->HoursesOnTable[i]->HourseThinking[j].Thinking));
						Dummy->HoursesOnTable[i]->HourseThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 3);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->HoursesOnTable[i];
					Log(t);
				}
			}

			//For All Castles Gray Objects.
			for (i = 0; i < CastleMidle; i++)
			{
				try
				{
					//When Gray Brideges Not Exsisting Traversal Back.
					if (CastlesOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(CastlesOnTable[i]->Row);
					jj = static_cast<int>(CastlesOnTable[i]->Column);
					//Construction of Bridegs Gray With Local variables.
					Dummy->CastlesOnTable[i] = new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);

					for (j = 0; j < 16; j++)
					{
						//Gray Castles Thinking Operations.
						Dummy->CastlesOnTable[i]->CastleThinking[j]->TableT = CastlesOnTable[i]->CastleThinking[j].TableT;
						Dummy->CastlesOnTable[i]->CastleThinking[j]->ThinkingBegin = true;
						Dummy->CastlesOnTable[i]->CastleThinking[j]->ThinkingFinished = false;
						Dummy->CastlesOnTable[i]->CastleThinking[j]->t = new Task(new std::function<void()>(Dummy->CastlesOnTable[i]->CastleThinking[j].Thinking));
						Dummy->CastlesOnTable[i]->CastleThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 4);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->CastlesOnTable[i];
					Log(t);
				}
			}
			//For All Minister Objets.
			for (i = 0; i < MinisterMidle; i++)
			{
				try
				{
					//Whe Gray Minister Not Exsisting Continue Traversal back.
					if (MinisterOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(MinisterOnTable[i]->Row);
					jj = static_cast<int>(MinisterOnTable[i]->Column);
					//Constructionof Ministerb Gray With Local Variables.
					Dummy->MinisterOnTable[i] = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Movments.
					for (j = 0; j < AllDraw::MinisterMovments; j++)
					{
						//Thinking Gray Ministers Operations.
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->TableT = MinisterOnTable[i]->MinisterThinking[j].TableT;
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->ThinkingBegin = true;
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->ThinkingFinished = false;
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->t = new Task(new std::function<void()>(Dummy->MinisterOnTable[i]->MinisterThinking[j].Thinking));
						Dummy->MinisterOnTable[i]->MinisterThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 5);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->MinisterOnTable[i];
					Log(t);
				}
			}

			//For All Possible Gray Kings.
			for (i = 0; i < KingMidle; i++)
			{
				try
				{
					//When Gray King Not Exsisting Continue Traversal Back.
					if (KingOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(KingOnTable[i]->Row);
					jj = static_cast<int>(KingOnTable[i]->Column);
					//Construction of Gray King With Local Variables.
					Dummy->KingOnTable[i] = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Movements.
					for (j = 0; j < AllDraw::KingMovments; j++)
					{
						//Thinking Gray King Operatons.
						Dummy->KingOnTable[i]->KingThinking[j]->TableT = KingOnTable[i]->KingThinking[j].TableT;
						Dummy->KingOnTable[i]->KingThinking[j]->ThinkingBegin = true;
						Dummy->KingOnTable[i]->KingThinking[j]->ThinkingFinished = false;
						Dummy->KingOnTable[i]->KingThinking[j]->t = new Task(new std::function<void()>(Dummy->KingOnTable[i]->KingThinking[j].Thinking));
						Dummy->KingOnTable[i]->KingThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 6);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->KingOnTable[i];
					Log(t);
				}
			}
		}
		else //Brown Order.
		{
			//For All Possible Brown Solders.
			for (i = SodierMidle; i < SodierHigh; i++)
			{
				try
				{
					//Whn Not Existing Braown Solder Continue Traversal Back.
					if (SolderesOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(SolderesOnTable[i]->Row);
					jj = static_cast<int>(SolderesOnTable[i]->Column);
					//Construction Of Brown Soldeir With Local Variables.
					Dummy->SolderesOnTable[i] = new DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					for (j = 0; j < 4; j++)
					{
						//Thinking of Brown  Soldiers Operations.
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->TableT = SolderesOnTable[i]->SoldierThinking[j].TableT;
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->ThinkingBegin = true;
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->ThinkingFinished = false;
						Dummy->SolderesOnTable[i]->SoldierThinking[j]->t = new Task(new std::function<void()>(Dummy->SolderesOnTable[i]->SoldierThinking[j].Thinking));
						Dummy->SolderesOnTable[i]->SoldierThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 1);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->SolderesOnTable[i];
					Log(t);
				}
			}
			//For All Brown elepahnt Objects.
			for (i = ElefantMidle; i < ElefantHigh; i++)
			{
				try
				{
					//Continue Traversal Back Of Non Existing Objects.
					if (ElephantOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(ElephantOnTable[i]->Row);
					jj = static_cast<int>(ElephantOnTable[i]->Column);
					//Construction of Brown Elephant Thinking Object.
					Dummy->ElephantOnTable[i] = new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					for (j = 0; j < AllDraw::ElefantMovments; j++)
					{
						//Thinking Brown Elephant Operations.
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->TableT = ElephantOnTable[i]->ElefantThinking[j].TableT;
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->ThinkingBegin = true;
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->ThinkingFinished = false;
						Dummy->ElephantOnTable[i]->ElefantThinking[j]->t = new Task(new std::function<void()>(Dummy->ElephantOnTable[i]->ElefantThinking[j].Thinking));
						Dummy->ElephantOnTable[i]->ElefantThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 2);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->ElephantOnTable[i];
					Log(t);
				}
			}

			//For All Possible Hourse Objects.
			for (i = HourseMidle; i < HourseHight; i++)
			{
				try
				{
					//For Non Existing Brown Elephant Continue Traversal Back.
					if (HoursesOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(HoursesOnTable[i]->Row);
					jj = static_cast<int>(HoursesOnTable[i]->Column);
					//Construction of Brown Hourse With Local Variables.
					Dummy->HoursesOnTable[i] = new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Hourse Movments.
					for (j = 0; j < AllDraw::HourseMovments; j++)
					{
						//Thinking of Brown Hourse Operations.
						Dummy->HoursesOnTable[i]->HourseThinking[j]->TableT = HoursesOnTable[i]->HourseThinking[j].TableT;
						Dummy->HoursesOnTable[i]->HourseThinking[j]->ThinkingBegin = true;
						Dummy->HoursesOnTable[i]->HourseThinking[j]->ThinkingFinished = false;
						Dummy->HoursesOnTable[i]->HourseThinking[j]->t = new Task(new std::function<void()>(Dummy->HoursesOnTable[i]->HourseThinking[j].Thinking));
						Dummy->HoursesOnTable[i]->HourseThinking[j].t.Start();
						//Wait For Thinking Finsishing.
						Wait(Dummy, i, j, 3);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->HoursesOnTable[i];
					Log(t);
				}
			}

			//For All Bridesg Brown Objects.
			for (i = CastleMidle; i < CastleHigh; i++)
			{
				try
				{
					//When Brown Castles Non Existing Continue Traversal Back.
					if (CastlesOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(CastlesOnTable[i]->Row);
					jj = static_cast<int>(CastlesOnTable[i]->Column);
					//Construction of Brown Castles With Local Variables.
					Dummy->CastlesOnTable[i] = new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Castles Movments.
					for (j = 0; j < AllDraw::CastleMovments; j++)
					{
						//Thinking of Brown Castles Operations.
						Dummy->CastlesOnTable[i]->CastleThinking[j]->TableT = CastlesOnTable[i]->CastleThinking[j].TableT;
						Dummy->CastlesOnTable[i]->CastleThinking[j]->ThinkingBegin = true;
						Dummy->CastlesOnTable[i]->CastleThinking[j]->ThinkingFinished = false;
						Dummy->CastlesOnTable[i]->CastleThinking[j]->t = new Task(new std::function<void()>(Dummy->CastlesOnTable[i]->CastleThinking[j].Thinking));
						Dummy->CastlesOnTable[i]->CastleThinking[j].t.Start();
						//Wait For Thinking Finsishing.                           
						Wait(Dummy, i, j, 4);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->CastlesOnTable[i];
					Log(t);
				}
			}
			//For All Possible Brown Minster Objects.
			for (i = MinisterMidle; i < MinisterHigh; i++)
			{
				try
				{
					//When Brown Minister Non Existing Continue Traversal Back.
					if (MinisterOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(MinisterOnTable[i]->Row);
					jj = static_cast<int>(MinisterOnTable[i]->Column);
					//Construction of Brown Minister Thinking Objects.
					Dummy->MinisterOnTable[i] = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Minister Brown Movments.
					for (j = 0; j < AllDraw::MinisterMovments; j++)
					{
						//Brown Minister Thinking Operations.
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->TableT = MinisterOnTable[i]->MinisterThinking[j].TableT;
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->ThinkingBegin = true;
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->ThinkingFinished = false;
						Dummy->MinisterOnTable[i]->MinisterThinking[j]->t = new Task(new std::function<void()>(Dummy->MinisterOnTable[i]->MinisterThinking[j].Thinking));
						Dummy->MinisterOnTable[i]->MinisterThinking[j].t.Start();
						Wait(Dummy, i, j, 5);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->MinisterOnTable[i];
					Log(t);
				}
			}

			//For All Brown King Objects.
			for (i = KingMidle; i < KingHigh; i++)
			{
				try
				{
					//When Brown King Non Existing Continue Traversal Back.
					if (KingOnTable[i] == nullptr)
					{
						continue;
					}
					//Initiate Local Variables.
					ii = static_cast<int>(KingOnTable[i]->Row);
					jj = static_cast<int>(KingOnTable[i]->Column);
					//Construction of Brown King Thinking Operation.
					Dummy->KingOnTable[i] = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, ii, jj, a, Table, Order, false, i);
					//For All Possible Brown King Movements.
					for (j = 0; j < AllDraw::KingMovments; j++)
					{
						//Thinking of Brown King Thinking Operations.
						Dummy->KingOnTable[i]->KingThinking[j]->TableT = KingOnTable[i]->KingThinking[j].TableT;
						Dummy->KingOnTable[i]->KingThinking[j]->ThinkingBegin = true;
						Dummy->KingOnTable[i]->KingThinking[j]->ThinkingFinished = false;
						Dummy->KingOnTable[i]->KingThinking[j]->t = new Task(new std::function<void()>(Dummy->KingOnTable[i]->KingThinking[j].Thinking));
						Dummy->KingOnTable[i]->KingThinking[j].t.Start();
						//Wait For Thinking Finished.
						Wait(Dummy, i, j, 6);
					}
				}
				catch (std::exception &t)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy->KingOnTable[i];
					Log(t);
				}
			}
		}

		A.push_back(Dummy);

	}

	void ChessPerdict::SetRowColumn(int index)
	{
		try
		{
			Move = 0;
			//Intiate Dummy Variables.
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
			//When Conversion Occured.
			if (TableList.size() > 0)
			{
				int A = 1;
				int Tab[8][8];
				for (int g = 0; g < 8; g++)
				{
					for (int k = 0; k < 8; k++)
					{
						Tab[g][k] = TableList[g][k];
					}
				}
				int Tabl[8][8];
				for (int g = 0; g < 8; g++)
				{
					for (int k = 0; k < 8; k++)
					{
						Tabl[g][k] = TableList[g][k];
					}
				}
				int Order = 1;
				bool TB = false;

				SolderesOnTable = new DrawSoldier[SodierHigh];
				for (int i = 0; i < SodierHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
					float *Location = nullptr;
					if (i <= SodierMidle)
					{
						Order = 1;
						A = 1;
						Location = FoundLocationOfObject(Tabl, 1, true);
					}
					else
					{
						Order = -1;
						A = -1;
						Location = FoundLocationOfObject(Tabl, -1, false);
					}
					SolderesOnTable[i] = new DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
				}
				ElephantOnTable = new DrawElefant[ElefantHigh];
				for (int i = 0; i < ElefantHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
					float *Location = nullptr;
					if (i <= ElefantMidle)
					{
						Order = 1;
						A = 1;
						Location = FoundLocationOfObject(Tabl, 1, true);
					}
					else
					{
						Order = -1;
						A = -1;
						Location = FoundLocationOfObject(Tabl, -1, false);
					}
					ElephantOnTable[i] = new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
				}
				HoursesOnTable = new DrawHourse[HourseHight];
				for (int i = 0; i < HourseHight; i++)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
					float *Location = nullptr;
					if (i <= HourseMidle)
					{
						Order = 1;
						A = 1;
						Location = FoundLocationOfObject(Tabl, 1, true);
					}
					else
					{
						A = -1;
						Location = FoundLocationOfObject(Tabl, -1, false);
						Order = -1;
					}
					HoursesOnTable[i] = new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
				}
				CastlesOnTable = new DrawCastle[CastleHigh];
				for (int i = 0; i < CastleHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
					float *Location = nullptr;
					if (i <= CastleMidle)
					{
						Order = 1;
						A = 1;
						Location = FoundLocationOfObject(Tabl, 1, true);
					}
					else
					{
						A = -1;
						Location = FoundLocationOfObject(Tabl, -1, false);
						Order = -1;
					}
					CastlesOnTable[i] = new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
				}
				MinisterOnTable = new DrawMinister[MinisterHigh];
				for (int i = 0; i < MinisterHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
					float *Location = nullptr;
					if (i <= MinisterMidle)
					{
						Order = 1;
						A = 1;
						Location = FoundLocationOfObject(Tabl, 1, true);
					}
					else
					{
						Order = -1;
						A = -1;
						Location = FoundLocationOfObject(Tabl, -1, false);
					}
					MinisterOnTable[i] = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
				}
				KingOnTable = new DrawKing[KingHigh];
				for (int i = 0; i < KingHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: float[] Location = nullptr;
					float *Location = nullptr;
					if (i <= KingMidle)
					{
						Order = 1;
						A = 1;
						Location = FoundLocationOfObject(Tabl, 1, true);
					}
					else
					{
						Order = -1;
						A = -1;
						Location = FoundLocationOfObject(Tabl, -1, false);
					}
					KingOnTable[i] = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Location, Location[1], A, Tab, Order, TB, i);
				}
				AllDraw::SodierConversionOcuured = false;

			}
			//When Table Exist.
			if (TableList.size() > 0)
			{
				//For Every Table Things.
				for (int Column = 0; Column < 8; Column++)
				{
					for (int Row = 0; Row < 8; Row++)
					{
						//When Things are Soldiers.
						if (abs(this->TableList[index][Row][Column]) == 1)
						{
							//Determine int
							int a;

							if (this->TableList[index][Row][Column] > 0)
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
								try
								{
									//When Solders ate current location differs add move.
									try
									{
										if (SolderesOnTable[So1]->Row != Row || SolderesOnTable[So1]->Column != Column)
										{
											Move++;
										}
									}
									catch (std::exception &t)
									{
										Log(t);
									}
									//Construct Soder Gray.
									SolderesOnTable[So1] = new DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], 1, false, So1);
									//Increase So1.
									So1++;
									if (So1 > SodierMidle)
									{
										SodierMidle++;
										SodierHigh++;
									}

								}
								catch (std::exception &t)
								{
									Log(t);
								}
							}
							//When int is Brown
							else
							{
								try
								{
									//When Solders ate current location differs add move.
									try
									{
										if (SolderesOnTable[So2]->Row != Row || SolderesOnTable[So2]->Column != Column)
										{
											Move++;
										}
									}
									catch (std::exception &t)
									{
										Log(t);
									}
									//Construct Soldeir Brown.
									SolderesOnTable[So2] = new DrawSoldier(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], -1, false, So2);
									//Increase So2.
									So2++;
									if (So2 > SodierHigh)
									{
										SodierHigh++;
									}
								}
								catch (std::exception &t)
								{
									Log(t);
								}
							}
						}
						else //For Elephant Objects.
						{
							if (abs(this->TableList[index][Row][Column]) == 2)
							{
								//Initiate Local Variables.
								int a;
								if (this->TableList[index][Row][Column] > 0)
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
									try
									{
										try
										{
											//Calculation of Movment Number.
											if (ElephantOnTable[El1]->Row != Row || ElephantOnTable[El1]->Column != Column)
											{
												Move++;
											}
										}
										catch (std::exception &t)
										{
											Log(t);
										}
										//Construction of Draw Object.
										ElephantOnTable[El1] = new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], 1, false, El1);
										//Increament of Gray Index.
										El1++;
									//If New ObjectIncreament Gray Objects.
									if (El1 > ElefantMidle)
									{
											ElefantMidle++;
										ElefantHigh++;
									}
									}
									catch (std::exception &t)
									{
										Log(t);
									}
								}
								else //For Brown Elephant .Objects
								{
									try
									{
										try
										{
											//Calculation of Movments Numbers.
											if (ElephantOnTable[El2]->Row != Row || ElephantOnTable[El2]->Column != Column)
											{
												Move++;
											}
										}
										catch (std::exception &t)
										{
											Log(t);
										}
										//Construction of Draw Brown Elephant Object. 
										ElephantOnTable[El2] = new DrawElefant(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], -1, false, El2);
										//Increament of Index.
										El2++;
									//When New Brown Elephant ObjectIncreament of Index.
									if (El2 > ElefantHigh)
									{
											ElefantHigh++;
									}

									}
									catch (std::exception &t)
									{
										Log(t);
									}

								}
							}
							else //For Hourse Objects.
							{
								if (abs(this->TableList[index][Row][Column]) == 3)
								{
									//Initiate Local Varibale and int.
									int a;
									if (this->TableList[index][Row][Column] > 0)
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

										try
										{
											try
											{
												//Calculation of Movments Number.
												if (HoursesOnTable[Ho1]->Row != Row || HoursesOnTable[Ho1]->Column != Column)
												{
													Move++;
												}
											}
											catch (std::exception &t)
											{
												Log(t);
											}
											//Construction of Draw Brown Hourse.
											HoursesOnTable[Ho1] = new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], 1, false, Ho1);
											//Increament of Index.
											Ho1++;
									//when There is New Gray Hourse Increase.
									if (Ho1 > HourseMidle)
									{
												HourseMidle++;
										HourseHight++;
									}
										}
										catch (std::exception &t)
										{
											Log(t);
										}
									} //For Brown Hourses.
									else
									{
										try
										{
											try
											{
												//Calculation of Movments Number.
												if (HoursesOnTable[Ho2]->Row != Row | HoursesOnTable[Ho2]->Column != Column)
												{
													Move++;
												}
											}
											catch (std::exception &t)
											{
												Log(t);
											}
											//Construction of Draw Brown Hourse.
											HoursesOnTable[Ho2] = new DrawHourse(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], -1, false, Ho2);
											//Increament of Index.
											Ho2++;
									//When New Brown Hourse Exist Exist Index.
									if (Ho2 > HourseHight)
									{
												HourseHight++;
									}
										}
										catch (std::exception &t)
										{
											Log(t);
										}
									}
								}
								else //For Castles Objects.
								{
									if (abs(this->TableList[index][Row][Column]) == 4)
									{
										//Initiate of Local Variables.
										int a;
										if (this->TableList[index][Row][Column] > 0)
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

											try
											{
												try
												{
													//Calculation of Movments Number.
													if (CastlesOnTable[Br1]->Row != Row || CastlesOnTable[Br1]->Column != Column)
													{
														Move++;
													}
												}
												catch (std::exception &t)
												{
													Log(t);
												}
												//Construction of New Draw Gray Castles.
												CastlesOnTable[Br1] = new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], 1, false, Br1);
												//Increamnt of Index.
												Br1++;
									//When New Gray Briges Increamnt Max Index.
									if (Br1 > CastleMidle)
									{
													CastleMidle++;
										CastleHigh++;
									}

											}
											catch (std::exception &t)
											{
												Log(t);
											}
										} //For Brown Castles.
										else
										{
											try
											{
												try
												{
													//Calculation of Movments Number.
													if (CastlesOnTable[Br2]->Row != Row || CastlesOnTable[Br2]->Column != Column)
													{
														Move++;
													}
												}
												catch (std::exception &t)
												{
													Log(t);
												}
												//Construction Draw of New Brown Castles.
												CastlesOnTable[Br2] = new DrawCastle(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], -1, false, Br2);
												//Increament of Index.
												Br2++;
									//wehn Brown New Castles Detected Increament Max Index.
									if (Br2 > CastleHigh)
									{
													CastleHigh++;
									}

											}
											catch (std::exception &t)
											{
												Log(t);
											}
										}
									}
									else //For Minister Objects.
									{
										if (abs(this->TableList[index][Row][Column]) == 5)
										{
											//Initiate Local int Varibales.
											int a;
											if (this->TableList[index][Row][Column] > 0)
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

												try
												{
													try
													{
														//Clculationb of Movments Number.
														if (MinisterOnTable[Mi1]->Row != Row || MinisterOnTable[Mi1]->Column != Column)
														{
															Move++;
														}
													}
													catch (std::exception &t)
													{
														Log(t);
													}
													//construction of new draw Gray Minster.
													MinisterOnTable[Mi1] = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], 1, false, Mi1);
													//Increament of Index.
													Mi1++;
									//Wehn New Gray Minster Detected Increament Max Indexes.
									if (Mi1 > MinisterMidle)
									{
														MinisterMidle++;
										MinisterHigh++;
									}
												}
												catch (std::exception &t)
												{
													Log(t);
												}

											} //For Brown  ints.
											else
											{
												try
												{
													try
													{
														//Calculation of Movments Number.
														if (MinisterOnTable[Mi2]->Row != Row || MinisterOnTable[Mi2]->Column != Column)
														{
															Move++;
														}
													}
													catch (std::exception &t)
													{
														Log(t);
													}
													//Construction of New Draw Brown Minster.
													MinisterOnTable[Mi2] = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], -1, false, Mi2);
													//Increament Index.
													Mi2++;
									//When New Brown Minister Detected Increament Max Index.
									if (Mi2 > MinisterHigh)
									{
														MinisterHigh++;
									}

												}
												catch (std::exception &t)
												{
													Log(t);
												}
											}
										}
										else //for King Objects.
										{
											if (abs(this->TableList[index][Row][Column]) == 6)
											{
												//Initiate Of int.
												int a;
												if (this->TableList[index][Row][Column] > 0)
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

													try
													{
														try
														{
															//Calculation of Movments Number.
															if (KingOnTable[Ki1]->Row != Row || KingOnTable[Ki1]->Column != Column)
															{
																Move++;
															}

														}
														catch (std::exception &t)
														{
															Log(t);
														}
														//Construction of New Draw Gray King.
														KingOnTable[Ki1] = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], 1, false, Ki1);
														//Increament of Index.
														Ki1++;
									//when New Draw  ObjectDetected Increament Max Index.
									if (Ki1 > KingMidle)
									{
															KingMidle++;
										KingHigh++;

									}

													}
													catch (std::exception &t)
													{
														Log(t);
													}
												} //For Brown King int
												else
												{
													try
													{
														try
														{
															//Calculation of Movment Number.
															if (KingOnTable[Ki2]->Row != Row || KingOnTable[Ki2]->Column != Column)
															{
																Move++;
															}
														}
														catch (std::exception &t)
														{
															Log(t);
														}
														//Construction of New Draw King Brown Object.
														KingOnTable[Ki2] = new DrawKing(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, a, this->TableList[index], -1, false, Ki2);
														//Increament of Index.
														Ki2++;
									//When New ObjectDetected Increament Of Brown King Max Index.
									if (Ki2 > KingHigh)
									{
															KingHigh++;
									}
													}
													catch (std::exception &t)
													{
														Log(t);
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
				//Make Empty Remaining.
				for (int i = So1; i < SodierMidle; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete SolderesOnTable[i];
				}

				for (int i = So2; i < SodierHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete SolderesOnTable[i];
				}

				for (int i = El1; i < ElefantMidle; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete ElephantOnTable[i];
				}

				for (int i = El2; i < ElefantHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete ElephantOnTable[i];
				}

				for (int i = Ho1; i < HourseMidle; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete HoursesOnTable[i];
				}

				for (int i = Ho2; i < HourseHight; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete HoursesOnTable[i];
				}

				for (int i = Br1; i < CastleMidle; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete CastlesOnTable[i];
				}

				for (int i = Br2; i < CastleHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete CastlesOnTable[i];
				}

				for (int i = Mi1; i < MinisterMidle; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete MinisterOnTable[i];
				}

				for (int i = Mi2; i < MinisterHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete MinisterOnTable[i];
				}

				for (int i = Ki1; i < KingMidle; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete KingOnTable[i];
				}

				for (int i = Ki2; i < KingHigh; i++)
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete KingOnTable[i];
				}

			}

		}
		catch (std::exception &t)
		{
			Log(t);
		}
	}

	int **ChessPerdict::HuristicCheck(std::vector<AllDraw*> &A, int a, int ij, double &Less, int Order)
	{
		//Inititae Local Varibales.
		int i = 0, j = 0;
		int Table[8][8];
		bool Act = false;
		int ii = ij;
		bool AAAA = false;
		ChessRules *AA = nullptr;
		//If List Exist.
		if (A.size() > 0)
		{
			//Fo All Soldeirs.
			for (i = 0; i < SodierHigh; i++)
			{

				//Calculate Thinking Operation of Current Soldier.
				for (int k = 0; k < AllDraw::SodierMovments; k++)
				{
					for (j = 0; SolderesOnTable != nullptr && SolderesOnTable[i] != nullptr && SolderesOnTable[i]->SoldierThinking[k] != nullptr && j < SolderesOnTable[i]->SoldierThinking[k].TableListSolder.size(); j++)
					{
						try
						{
							//If there is Penalty Situation Continue.
							if (AllDraw::OrderPlate == Order)
							{
								if (SolderesOnTable[i]->SoldierThinking[k].PenaltyRegardListSolder[j].IsPenaltyAction() == 0)
								{
									Less = -200000000;
									continue;
								}
							}
							//For Higher Huristic Values.
							if (AllDraw::OrderPlate == Order)
							{
								if (SolderesOnTable[i]->SoldierThinking[k].ReturnHuristic(i, j, Order,AAAA) >= Less)
								{
									//Initiate Table of Current Object.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = SolderesOnTable[i].SoldierThinking[k].TableListSolder[j];
									int **TableS = SolderesOnTable[i]->SoldierThinking[k].TableListSolder[j];

									{
										AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, TableS, Order, SolderesOnTable[i]->SoldierThinking[k].Row, SolderesOnTable[i]->SoldierThinking[k].Column);
										//Achamaz Check CheckMate of Current Table.
										if (AA->ObjectDangourKingMove(Order, TableS, false) && !AllDraw::NoTableFound)
										{
											//If Order is Gray.
											if (Order == 1)
											{
												if (AA->CheckGrayObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
											else //If Order is Brown.
											{
												if (AA->CheckBrownObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
										}
										else
										{

										}
									}
									if (Order == 1) //If Order is Gray.
									{
										//If CheckObjectDangour Occured and AStarGreedyGreedy Huristic Not Exist.
										if (AA->CheckGrayObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->SolderesOnTable[i]->Row), static_cast<int>(APredict->SolderesOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											else
											{
												AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
												AA->Check(Table, AllDraw::OrderPlate);
												if (AllDraw::OrderPlate == 1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												if (AllDraw::OrderPlate == -1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												Act = true;
												Less = SolderesOnTable[i]->SoldierThinking[k].HuristicListSolder[j] + SolderesOnTable[i]->SoldierThinking[k].HuristicListSolder[j][1] + SolderesOnTable[i]->SoldierThinking[k].HuristicListSolder[j][2] + SolderesOnTable[i]->SoldierThinking[k].HuristicListSolder[j][3];

												continue;


											}

										}
									}
									else
									{
										if (AA->CheckBrownObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->SolderesOnTable[i]->Row), static_cast<int>(APredict->SolderesOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											ChessRules *AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AAA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AAA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AAA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
										}
									}
									//Initaiet Local Varibale and Syntax and Table Found.
									RW = i;
									CL = k;
									Ki = 1;
									Act = true;
									AllDraw::LastRow = SolderesOnTable[i]->SoldierThinking[k].Row;
									AllDraw::LastColumn = SolderesOnTable[i]->SoldierThinking[k].Column;

									Less = SolderesOnTable[i]->SoldierThinking[k].ReturnHuristic(i, j, Order,AAAA);
									;


									Table = SolderesOnTable[i]->SoldierThinking[k].TableListSolder[j];



									//autoO = new Object();
									////lock (O)
									{
										ThingsConverter::ActOfClickEqualTow = true;
									}
									SolderesOnTable[i]->ConvertOperation(SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j], SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j][1], a, SolderesOnTable[i]->SoldierThinking[k].TableListSolder[j], Order, false, i);
									int Sign = 1;
									if (a == -1)
									{
										Sign = -1;
									}
									if (SolderesOnTable[i]->Convert)
									{

										if (SolderesOnTable[i]->ConvertedToMinister)
										{
											Table[SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j]][SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j][1]] = 5 * Sign;
										}
										else if (SolderesOnTable[i]->ConvertedToCastle)
										{
											Table[SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j]][SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j][1]] = 4 * Sign;
										}
										else if (SolderesOnTable[i]->ConvertedToHourse)
										{
											Table[SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j]][SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j][1]] = 3 * Sign;
										}
										else if (SolderesOnTable[i]->ConvertedToElefant)
										{
											Table[SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j]][SolderesOnTable[i]->SoldierThinking[k].RowColumnSoldier[j][1]] = 2 * Sign;
										}
										TableList.clear();
										TableList.push_back(Table);
										SetRowColumn(0);
										TableList.clear();

									}


								}
							}
						}
						catch (std::exception &t)
						{
							Log(t);
						}
					}
				}

			}
			//Calculate Thinking Operation of Current Elephant.                   
			for (i = 0; i < ElefantHigh; i++)
			{
				for (int k = 0; k < AllDraw::ElefantMovments; k++)
				{
					for (j = 0; ElephantOnTable != nullptr && ElephantOnTable[i] != nullptr && ElephantOnTable[i]->ElefantThinking[k] != nullptr && j < ElephantOnTable[i]->ElefantThinking[k].TableListElefant.size(); j++)
					{
						try
						{
							//If there is Penalty Situation Continue.
							if (AllDraw::OrderPlate == Order)
							{
								if (ElephantOnTable[i]->ElefantThinking[k].PenaltyRegardListElefant[j].IsPenaltyAction() == 0)
								{
									Less = -200000000;
									continue;
								}
							}

							//For Higher Huristic Values.
							if (AllDraw::OrderPlate == Order)
							{
								if (ElephantOnTable[i]->ElefantThinking[k].ReturnHuristic(i, j, Order,AAAA) >= Less)
								{

									//Initiate Table of Current Object.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = ElephantOnTable[i].ElefantThinking[k].TableListElefant[j];
									int **TableS = ElephantOnTable[i]->ElefantThinking[k].TableListElefant[j];
									{
										AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 2, TableS, Order, ElephantOnTable[i]->ElefantThinking[k].Row, ElephantOnTable[i]->ElefantThinking[k].Column);
										//Achamaz Check CheckMate of Current Table.
										if (AA->ObjectDangourKingMove(Order, TableS, false) && !AllDraw::NoTableFound)
										{
											//If Order is Gray.
											if (Order == 1)
											{
												if (AA->CheckGrayObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
											else //If Order is Brown.
											{
												if (AA->CheckBrownObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
										}
										//}
										else
										{

										}
									}
									if (Order == 1) //If Order is Gray.
									{
										//If CheckObjectDangour Occured and AStarGreedyGreedy Huristic Not Exist.
										if (AA->CheckGrayObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->ElephantOnTable[i]->Row), static_cast<int>(APredict->ElephantOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											else
											{
												AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
												AA->Check(Table, AllDraw::OrderPlate);
												if (AllDraw::OrderPlate == 1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												if (AllDraw::OrderPlate == -1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												RW = i;
												CL = k;
												Ki = 1;
												Act = true;
												Less = ElephantOnTable[i]->ElefantThinking[k].ReturnHuristic(i, j, Order,AAAA);
												;

											}
										}
									}
									else
									{
										if (AA->CheckBrownObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(ii);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->ElephantOnTable[i]->Row), static_cast<int>(APredict->ElephantOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}

										}
									}
									//Initaiet Local Varibale and Syntax and Table Found.

									AllDraw::LastRow = ElephantOnTable[i]->ElefantThinking[k].Row;
									AllDraw::LastColumn = ElephantOnTable[i]->ElefantThinking[k].Column;

									RW = i;
									CL = k;
									Ki = 2;
									Act = true;
									Less = ElephantOnTable[i]->ElefantThinking[k].ReturnHuristic(i, j, Order,AAAA);
									;
									Table = ElephantOnTable[i]->ElefantThinking[k].TableListElefant[j];

								}
							}
						}
						catch (std::exception &t)
						{
							Log(t);
						}
					}
				}

			}
			//Calculate Thinking Operation of Current Hourse.                   
			for (i = 0; i < HourseHight; i++)
			{

				for (int k = 0; k < AllDraw::HourseMovments; k++)
				{
					for (j = 0; HoursesOnTable != nullptr && HoursesOnTable[i] != nullptr && HoursesOnTable[i]->HourseThinking[k] != nullptr && j < HoursesOnTable[i]->HourseThinking[k].TableListHourse.size(); j++)
					{
						try
						{
							//If there is Penalty Situation Continue.
							if (AllDraw::OrderPlate == Order)
							{
								if (HoursesOnTable[i]->HourseThinking[k].PenaltyRegardListHourse[j].IsPenaltyAction() == 0)
								{
									Less = -200000000;
									continue;
								}
							}


							//For Higher Huristic Values.
							if (AllDraw::OrderPlate == Order)
							{
								if (HoursesOnTable[i]->HourseThinking[k].ReturnHuristic(i, j, Order,AAAA) >= Less)
								{
									//Initiate Table of Current Object.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = HoursesOnTable[i].HourseThinking[k].TableListHourse[j];
									int **TableS = HoursesOnTable[i]->HourseThinking[k].TableListHourse[j];
									{
										{
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 3, TableS, Order, HoursesOnTable[i]->HourseThinking[k].Row, HoursesOnTable[i]->HourseThinking[k].Column);
											//Achamaz Check CheckMate of Current Table.
											if (AA->ObjectDangourKingMove(Order, TableS, false) && !AllDraw::NoTableFound)
											{
												//If Order is Gray.
												if (Order == 1)
												{
													if (AA->CheckGrayObjectDangour && AllDraw::AStarGreadyFirstSearch)
													{
														continue;
													}
												}
												else //If Order is Brown.
												{
													if (AA->CheckBrownObjectDangour && AllDraw::AStarGreadyFirstSearch)
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

									if (Order == 1) //If Order is Gray.
									{
										//If CheckObjectDangour Occured and AStarGreedyGreedy Huristic Not Exist.
										if (AA->CheckGrayObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->HoursesOnTable[i]->Row), static_cast<int>(APredict->HoursesOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
										}
									}
									else
									{
										if (AA->CheckBrownObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->HoursesOnTable[i]->Row), static_cast<int>(APredict->HoursesOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											else
											{
												AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
												AA->Check(Table, AllDraw::OrderPlate);
												if (AllDraw::OrderPlate == 1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												if (AllDraw::OrderPlate == -1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												RW = i;
												CL = k;
												Ki = 1;
												Act = true;
												Less = HoursesOnTable[i]->HourseThinking[k].ReturnHuristic(i, j, Order,AAAA);
												;
												continue;
											}

										}
									}
									//Initaiet Local Varibale and Syntax and Table Found.
									AllDraw::LastRow = HoursesOnTable[i]->HourseThinking[k].Row;
									AllDraw::LastColumn = HoursesOnTable[i]->HourseThinking[k].Column;

									RW = i;
									CL = k;
									Ki = 3;
									Act = true;
									Less = HoursesOnTable[i]->HourseThinking[k].ReturnHuristic(i, j, Order,AAAA);
									;
									Table = HoursesOnTable[i]->HourseThinking[k].TableListHourse[j];

								}
							}
						}
						catch (std::exception &t)
						{
							Log(t);
						}
					}
				}


			}
			//Calculate Thinking Operation of Current Castles.
			for (i = 0; i < CastleHigh; i++)
			{
				for (int k = 0; k < AllDraw::CastleMovments; k++)
				{
					for (j = 0; CastlesOnTable != nullptr && CastlesOnTable[i] != nullptr && CastlesOnTable[i]->CastleThinking[k] != nullptr && j < CastlesOnTable[i]->CastleThinking[k].TableListCastle.size(); j++)
					{
						try
						{
							//If there is Penalty Situation Continue.
							if (AllDraw::OrderPlate == Order)
							{
								if (CastlesOnTable[i]->CastleThinking[k].PenaltyRegardListMinister[j].IsPenaltyAction() == 0)
								{
									Less = -200000000;
									continue;
								}
							}
							//For Higher Huristic Values.
							if (AllDraw::OrderPlate == Order)
							{
								if (CastlesOnTable[i]->CastleThinking[k].ReturnHuristic(i, j, Order,AAAA) >= Less)
								{
									//Initiate Table of Current Object.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = CastlesOnTable[i].CastleThinking[k].TableListCastle[j];
									int **TableS = CastlesOnTable[i]->CastleThinking[k].TableListCastle[j];
									{
										AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 4, TableS, Order, CastlesOnTable[i]->CastleThinking[k].Row, CastlesOnTable[i]->CastleThinking[k].Column);
										//Achamaz Check CheckMate of Current Table.
										if (AA->ObjectDangourKingMove(Order, TableS, false) && !AllDraw::NoTableFound)
										{
											//If Order is Gray.
											if (Order == 1)
											{
												if (AA->CheckGrayObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
											else //If Order is Brown.
											{
												if (AA->CheckBrownObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
										}
										else
										{

										}
									}
									if (Order == 1) //If Order is Gray.
									{
										//If CheckObjectDangour Occured and AStarGreedyGreedy Huristic Not Exist.
										if (AA->CheckGrayObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->CastlesOnTable[i]->Row), static_cast<int>(APredict->CastlesOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
										}
									}
									else
									{
										if (AA->CheckBrownObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(CastlesOnTable[i]->Row), static_cast<int>(CastlesOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											else
											{
												AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
												AA->Check(Table, AllDraw::OrderPlate);
												if (AllDraw::OrderPlate == 1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												if (AllDraw::OrderPlate == -1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												RW = i;
												CL = k;
												Ki = 1;
												Act = true;
												Less = CastlesOnTable[i]->CastleThinking[k].ReturnHuristic(i, j, Order,AAAA);
												;

												continue;
											}
										}
									}
									//Initaiet Local Varibale and Syntax and Table Found.

									AllDraw::LastRow = CastlesOnTable[i]->CastleThinking[k].Row;
									AllDraw::LastColumn = CastlesOnTable[i]->CastleThinking[k].Column;

									RW = i;
									CL = k;
									Ki = 4;
									Act = true;
									Less = CastlesOnTable[i]->CastleThinking[k].ReturnHuristic(i, j, Order,AAAA);
									;
									Table = CastlesOnTable[i]->CastleThinking[k].TableListCastle[j];

								}
							}
						}
						catch (std::exception &t)
						{
							Log(t);
						}
					}
				}

			}
			//Calculate Thinking Operation of Current Minister.          
			for (i = 0; i < MinisterHigh; i++)
			{

				for (int k = 0; k < AllDraw::MinisterMovments; k++)
				{
					for (j = 0; MinisterOnTable != nullptr && MinisterOnTable[i] != nullptr && MinisterOnTable[i]->MinisterThinking[k] != nullptr && j < MinisterOnTable[i]->MinisterThinking[k].TableListMinister.size(); j++)
					{
						try
						{
							//If there is Penalty Situation Continue.
							if (AllDraw::OrderPlate == Order)
							{
								if (MinisterOnTable[i]->MinisterThinking[k].PenaltyRegardListMinister[j].IsPenaltyAction() == 0)
								{
									Less = -200000000;
									continue;
								}
							}
							//For Higher Huristic Values.
							if (AllDraw::OrderPlate == Order)
							{
								if (MinisterOnTable[i]->MinisterThinking[k].ReturnHuristic(i, j, Order,AAAA) >= Less)
								{
									//Initiate Table of Current Object.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = MinisterOnTable[i].MinisterThinking[k].TableListMinister[j];
									int **TableS = MinisterOnTable[i]->MinisterThinking[k].TableListMinister[j];
									{
										{
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 5, TableS, Order, MinisterOnTable[i]->MinisterThinking[k].Row, MinisterOnTable[i]->MinisterThinking[k].Column);
											//Achamaz Check CheckMate of Current Table.
											if (AA->ObjectDangourKingMove(Order, TableS, false) && !AllDraw::NoTableFound)
											{
												//If Order is Gray.
												if (Order == 1)
												{
													if (AA->CheckGrayObjectDangour && AllDraw::AStarGreadyFirstSearch)
													{
														continue;
													}
												}
												else //If Order is Brown.
												{
													if (AA->CheckBrownObjectDangour && AllDraw::AStarGreadyFirstSearch)
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
									if (Order == 1) //If Order is Gray.
									{
										//If CheckObjectDangour Occured and AStarGreedyGreedy Huristic Not Exist.
										if (AA->CheckGrayObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->MinisterOnTable[i]->Row), static_cast<int>(APredict->MinisterOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
										}

									}
									else
									{
										if (AA->CheckBrownObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->MinisterOnTable[i]->Row), static_cast<int>(APredict->MinisterOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
										}
									}
									//Initaiet Local Varibale and Syntax and Table Found.

									AllDraw::LastRow = MinisterOnTable[i]->MinisterThinking[k].Row;
									AllDraw::LastColumn = MinisterOnTable[i]->MinisterThinking[k].Column;

									RW = i;
									CL = k;
									Ki = 5;
									Act = true;
									Less = MinisterOnTable[i]->MinisterThinking[k].ReturnHuristic(i, j, Order,AAAA);
									;
									Table = MinisterOnTable[i]->MinisterThinking[k].TableListMinister[j];

								}
							}
						}
						catch (std::exception &t)
						{
							Log(t);
						}
					}
				}

			}

			//Calculate Thinking Operation of Current King.                   
			for (i = 0; i < KingHigh; i++)
			{
				for (int k = 0; k < AllDraw::KingMovments; k++)
				{
					for (j = 0; KingOnTable != nullptr && KingOnTable[i] != nullptr && KingOnTable[i]->KingThinking[k] != nullptr && j < KingOnTable[i]->KingThinking[k].TableListKing.size(); j++)
					{
						try
						{
							//If there is Penalty Situation Continue.
							if (AllDraw::OrderPlate == Order)
							{
								if (KingOnTable[i]->KingThinking[k].PenaltyRegardListKing[j].IsPenaltyAction() == 0)
								{
									Less = -200000000;
									continue;
								}
							}
							//For Higher Huristic Values.
							if (AllDraw::OrderPlate == Order)
							{
								if (KingOnTable[i]->KingThinking[k].ReturnHuristic(i, j, Order,AAAA) >= Less)
								{
									//Initiate Table of Current Object.
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableS = KingOnTable[i].KingThinking[k].TableListKing[j];
									int **TableS = KingOnTable[i]->KingThinking[k].TableListKing[j];
									{
										AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 6, TableS, Order, KingOnTable[i]->KingThinking[k].Row, KingOnTable[i]->KingThinking[k].Column);
										//Achamaz Check CheckMate of Current Table.
										if (AA->ObjectDangourKingMove(Order, TableS, false) && !AllDraw::NoTableFound)
										{
											//If Order is Gray.
											if (Order == 1)
											{
												if (AA->CheckGrayObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
											else //If Order is Brown.
											{
												if (AA->CheckBrownObjectDangour && AllDraw::AStarGreadyFirstSearch)
												{
													continue;
												}
											}
										}
										else
										{

										}
									}
									if (Order == 1) //If Order is Gray.
									{
										//If CheckObjectDangour Occured and AStarGreedyGreedy Huristic Not Exist.
										if (AA->CheckGrayObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->KingOnTable[i]->Row), static_cast<int>(APredict->KingOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
											AA->Check(Table, AllDraw::OrderPlate);
											if (AllDraw::OrderPlate == 1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
											if (AllDraw::OrderPlate == -1 && AA->CheckGray)
											{
												Table = nullptr;
												continue;
											}
										}
									}
									else
									{
										if (AA->CheckBrownObjectDangour && !AllDraw::AStarGreadyFirstSearch)
										{
											//Prdeict Huristic.
											int B;
											if (a == 1)
											{
												B = -1;
											}
											else
											{
												B = 1;
											}
											APredict->TableList.clear();
											APredict->TableList.push_back(TableS);
											APredict->SetRowColumn(0);
											Table = APredict->InitiatePerdictCheck(static_cast<int>(APredict->KingOnTable[i]->Row), static_cast<int>(APredict->KingOnTable[i]->Column), B, TableS, Order, false);
											if (Table == nullptr)
											{
												continue;
											}
											else
											{
												AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Table, AllDraw::OrderPlate, -1, -1);
												AA->Check(Table, AllDraw::OrderPlate);
												if (AllDraw::OrderPlate == 1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												if (AllDraw::OrderPlate == -1 && AA->CheckGray)
												{
													Table = nullptr;
													continue;
												}
												RW = i;
												CL = k;
												Ki = 1;
												Act = true;
												Less = KingOnTable[i]->KingThinking[k].ReturnHuristic(i, j, Order,AAAA);
												;
												continue;
											}

										}
									}


									AllDraw::LastRow = KingOnTable[i]->KingThinking[k].Row;
									AllDraw::LastColumn = KingOnTable[i]->KingThinking[k].Column;

									RW = i;
									CL = k;
									Ki = 6;
									Act = true;
									Less = KingOnTable[i]->KingThinking[k].ReturnHuristic(i, j, Order,AAAA);
									Table = KingOnTable[i]->KingThinking[k].TableListKing[j];

								}
							}
						}
						catch (std::exception &t)
						{
							Log(t);
						}
					}
				}

			}
		}
		//If There is A Movments Return Table.
		if (Act)
		{
			return Table;
		}
		//What Kind Of Table.

		return Table;
	}

	int **ChessPerdict::InitiatePerdictCheck(int ii, int jj, int a, int Table[8][8], int Order, bool TB)
	{
		//Initaite Local and Global Variables.
		ChessRules *AA = nullptr;
		bool Dummy = ThinkingChess::NotSolvedKingDanger;
		int TablInit[8][8];

		int TablInitOne[8][8];
		int TablInitCheck[8][8];

		int Current = ChessRules::CurrentOrder;
		OrderDummy = Order;
		A.clear();
		TableList.clear();
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			ThinkingChess::NotSolvedKingDanger = false;
		}
		LoopHuristicIndex = 0;
		//Clone a Copy.
		for (int iii = 0; iii < 8; iii++)
		{
			for (int jjj = 0; jjj < 8; jjj++)
			{
				TablInitOne[iii][jjj] = Table[iii][jjj];
			}
		}
		//Clone A Copy.
		for (int iii = 0; iii < 8; iii++)
		{
			for (int jjj = 0; jjj < 8; jjj++)
			{
				TablInitCheck[iii][jjj] = TablInitOne[iii][jjj];
			}
		}
		AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, TablInitCheck, Order, -1, -1);
		//Check Consideration.
		if (AA->Check(TablInitCheck, Order))
		{
			if (OrderDummy == 1)
			{
				if (AA->CheckGray)
				{
					return nullptr;
				}

			}
			else
			{
				if (AA->CheckGray)
				{
					return nullptr;
				}
			}
		}
		//For Tow Times
		for (int i = 0; i < 2; i++)
		{

			if (i != 0)
			{
				this->SetRowColumn(i);
			}
			if (Order == 1)
			{
				//THIS.SetBoxText("\r\nChess Predict Thinking AStarGreedyGreedy " + (i + 1).ToString() + " By Bob!");
				//THIS.RefreshBoxText();
			}
			else
			{
				//THIS.SetBoxText("\r\nChess Predict Thinking AStarGreedyGreedy " + (i + 1).ToString() + " By Alice!");
				//THIS.RefreshBoxText();
			}
			//Gray Order.
			if (Order == 1)
			{
				a = 1;
			}
			else //Brown Order.
			{
				a = -1;
			}
			//Initiate Local Variables and Take a Randomly Soldiers.
			int In = 0;
			int iiii = 0;
			do
			{
				if (Order == 1)
				{
					In = (new System::Random())->Next(0, 8);
				}
				else

				{
					In = (new System::Random())->Next(8, 16);
				}
				iiii++;
			} while (SolderesOnTable[In] == nullptr || iiii < 16);
			//For Sixteen Times Take a Look At Thinking.
			if (iiii < 16)
			{
				this->InitiateForEveryKindThingHome(new AllDraw(Order, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged), static_cast<int>(static_cast<int>(SolderesOnTable[In]->Row)), static_cast<int>(static_cast<int>(SolderesOnTable[In]->Column)), a, TablInit, Order, false, In);
			}
			else
			{
				this->InitiateForEveryKindThingHome(new AllDraw(Order, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged), static_cast<int>(1), 2, a, TablInit, Order, false, In);
			}

			//Initiate Local Variables.
			double Less = -100000;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = nullptr;
			int **Tab = nullptr;
			//List Not Empty.
			if (A.size() > 0)
			{
				//Gray Order.
				if (Order == 1)
				{
					//THIS.SetBoxText("\r\nHuristic Check Considerasion Movements AStarGreedyGreedy " + i.ToString() + " By Bob!");
					//THIS.RefreshBoxText();
				}
				else //Brown Order.
				{
					//THIS.SetBoxText("\r\nHuristic Check Considerasion Movements AStarGreedyGreedy " + i.ToString() + " By Alice!");
					//THIS.RefreshBoxText();

				}
				//Huristic Foundation of Table.
				Tab = HuristicCheck(A, a, i, Less, Order);
			}
			//Table is Not Found.
			if (Tab == nullptr)
			{
				//Initiate Not Found Variables.
				//autoO3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O3)
				{
					ThinkingChess::NotSolvedKingDanger = Dummy;
					ChessRules::CurrentOrder = Current;
				}
				Order = OrderDummy;
				return nullptr;
			}

			//Table Foundation.
			if (Tab != nullptr)
			{
				//Clone a Copy.
				for (int iii = 0; iii < 8; iii++)
				{
					for (int jjj = 0; jjj < 8; jjj++)
					{
						TablInit[iii][jjj] = Tab[iii][jjj];
					}
				}
				//Initiate Local Varibales.
				TableList.push_back(TablInit);
				ClList.push_back(CL);
				RWList.push_back(RW);
				KiList.push_back(Ki);
				//Order = Order * -1;
				//ChessRules.CurrentOrder = Order;

				AStarGreedyGreedy++;
				ChessRules::CurrentOrder *= -1;
				Order *= -1;



			}
			else //Table Not Found.
			{
				//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O1)
				{
					ThinkingChess::NotSolvedKingDanger = Dummy;
					ChessRules::CurrentOrder = Current;
				}
				Order = OrderDummy;

				return nullptr;
			}
		}
		//Initiat Local Variables.
		//autoO4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O4)
		{
			ThinkingChess::NotSolvedKingDanger = Dummy;
			ChessRules::CurrentOrder = Current;
		}
		Order = OrderDummy;

		return TablInitOne;
	}

	bool ChessPerdict::InitiatePerdictCheckEnemy(int ii, int jj, int a, int Table[8][8], int Order, bool TB)
	{
		//Iniatite Local and Global Variables.
		int Current = ChessRules::CurrentOrder;
		int OrderDummy = Order;
		A.clear();
		TableList.clear();
		ChessRules::CurrentOrder *= -1;
		Order *= -1;
		bool Dummy = ThinkingChess::NotSolvedKingDanger;
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			ThinkingChess::NotSolvedKingDanger = false;
		}
		LoopHuristicIndex = 0;
		//For One Time.
		for (int i = 0; i < 1; i++)
		{
			//Initiate Local Variables.
			int TablInit[8][8];
			if (Order == 1)
			{
				a = 1;
			}
			else
			{
				a = -1;
			}
			int In = 0;
			//Found of a Randomly Soldeir.
			do
			{
				if (Order == 1)
				{
					In = (new System::Random())->Next(0, 8);
				}
				else
				{
					In = (new System::Random())->Next(8, 16);
				}
			} while (SolderesOnTable[In] == nullptr);
			//Intiatation of Thinking.
			this->InitiateForEveryKindThingHome(new AllDraw(Order, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged), static_cast<int>(SolderesOnTable[In]->Row), static_cast<int>(SolderesOnTable[In]->Column), a, Table, Order, false, In);
			//Iniatite Local Variables.
			double Less = 0;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = nullptr;
			int **Tab = nullptr;
			//When Thinking Found Take Huristic.
			if (A.size() > 0)
			{
				Tab = HuristicCheck(A, a, i, Less, Order);
			}
			//Table Not Foundation Condition.
			if (Tab == nullptr)
			{
				//Initaiation of Not Founding Variables.
				//autoO6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O6)
				{
					ThinkingChess::NotSolvedKingDanger = Dummy;
					ChessRules::CurrentOrder = Current;
				}
				Order = OrderDummy;
				return false;
			}
			//Table Reapetedly Consideration.
			if (ThinkingChess::ExistTableInList(Tab, TableListAction, 0))
			{
				//Remove Whle is Repeatedly.
				while (ThinkingChess::ExistTableInList(Tab, TableListAction, 0))
				{
					TableListAction.RemoveAt(LoopHuristicIndex);
				}
				//Genetic Algorithm Construction.
				ChessGeneticAlgorithm *R = (new ChessGeneticAlgorithm(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged));
				//Found Of Genetic Algorithm Table Method.
				Tab = R->GenerateTable(TableListAction, LoopHuristicIndex, Order);

			}
			//Table Foundation Condition.
			if (Tab != nullptr)
			{
				//Clone a Copy.
				for (int iii = 0; iii < 8; iii++)
				{
					for (int jjj = 0; jjj < 8; jjj++)
					{
						TablInit[iii][jjj] = Tab[iii][jjj];
					}
				}
				//Iniatiet Local Variables.
				Table = new int[8][8];
				//Clone a Copy.
				for (int iii = 0; iii < 8; iii++)
				{
					for (int jjj = 0; jjj < 8; jjj++)
					{
						Table[iii][jjj] = TablInit[iii][jjj];
					}
				}
				//Initaiation of Local and Global Variables. 
				TableList.push_back(TablInit);
				ClList.push_back(CL);
				RWList.push_back(RW);
				KiList.push_back(Ki);
				Order = Order * -1;
				ChessRules::CurrentOrder = Order;
				AStarGreedyGreedy++;

			}
		}
		//Iniatiation of Local and Global Variables.
		//autoO5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O5)
		{
			ThinkingChess::NotSolvedKingDanger = Dummy;
			ChessRules::CurrentOrder = Current;
		}
		Order = OrderDummy;
		return true;
	}
}
