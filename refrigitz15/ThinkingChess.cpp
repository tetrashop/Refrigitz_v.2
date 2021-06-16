#pragma once
#include "ThinkingChess.h"



namespace RefrigtzDLL
{
	inline bool operator==(const AllDraw& lhs, const std::nullptr_t rhs) { return (lhs == rhs); }
	inline bool operator!=(const AllDraw& lhs, const std::nullptr_t rhs) { return !(lhs != rhs); }
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
	/*
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
	
	inline AllDraw operator[](const std::vector<AllDraw> lhs, const int rhs) { return lhs[rhs]; }
	inline DrawSoldier operator[](const std::vector<DrawSoldier> lhs, const int rhs) { return lhs[rhs]; }
	inline DrawCastle operator[](const std::vector<DrawCastle> lhs, const int rhs) { return lhs[rhs]; }
	inline DrawElefant operator[](const std::vector<DrawElefant> lhs, const int rhs) { return lhs[rhs]; }
	inline DrawHourse operator[](const std::vector<DrawHourse> lhs, const int rhs) { return lhs[rhs]; }
	inline DrawMinister operator[](const std::vector<DrawMinister> lhs, const int rhs) { return lhs[rhs]; }
	inline DrawKing operator[](const std::vector<DrawKing> lhs, const int rhs) { return lhs[rhs]; }
	inline ThinkingChess operator[](const std::vector<ThinkingChess> lhs, const int rhs) { return lhs[rhs]; }

	*/

	inline std::wstring operator+=(const std::wstring &out, const std::wstring &course)
	{
		std::wstring& lef = std::wstring();
		lef = out + course; // for example
		return lef;

	}

NetworkQuantumLearningKrinskyAtamata *ThinkingChess::LearniningTable = nullptr;
std::wstring ThinkingChess::ActionsString = L"";
bool ThinkingChess::LearningVarsCheckedMateOccured = false;
bool ThinkingChess::LearningVarsCheckedMateOccuredOneCheckedMate = false;
double ThinkingChess::MaxHuristicx = -DBL_MAX;
int ThinkingChess::NumbersOfCurrentBranchesPenalties = 0;
int ThinkingChess::NumbersOfAllNode = 0;
bool ThinkingChess::KingMaovableGray = false;
bool ThinkingChess::KingMaovableBrown = false;
int ThinkingChess::FoundFirstMating = 0;
int ThinkingChess::FoundFirstSelfMating = 0;
int ThinkingChess::BeginThread = 0;
int ThinkingChess::EndThread = 0;
bool ThinkingChess::NotSolvedKingDanger = false;
bool ThinkingChess::ThinkingRun = false;

	

	void ThinkingChess::SetObjectNumbersInList(int **Tab)
	{
		SetObjectNumbers(Tab);

		int **A = new int*[6]; for (int g = 0; g < 6; g++)A[g] = new int[2];
		A[0][0] = SodierMidle;
		A[1][0] = SodierHigh;


		A[0][1] = ElefantMidle;
		A[1][1] = ElefantHigh;


		A[0][2] = HourseMidle;
		A[1][2] = HourseHight;


		A[0][3] = CastleMidle;
		A[1][3] = CastleHigh;


		A[0][4] = MinisterMidle;
		A[1][4] = MinisterHigh;


		A[0][5] = KingMidle;
		A[1][5] = KingHigh;
		ObjectNumbers.push_back(A);
	}

	void ThinkingChess::SetObjectNumbers(int **TabS)
	{
		////auto a = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (a)
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

	ThinkingChess::ThinkingChess(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j)
	{
		//Kind = Kin;
		InitializeInstanceFields();
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//////lock (O)
		{
			//Initiate Variables.

			CurrentAStarGredyMax = CurrentAStarGredy;
			MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
			IgnoreSelfObjectsT = IgnoreSelfObject;
			UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
			BestMovmentsT = BestMovment;
			PredictHuristicT = PredictHurist;
			OnlySelfT = OnlySel;
			AStarGreedyHuristicT = AStarGreedyHuris;
			ArrangmentsChanged = Arrangments;
			//SetObjectNumbers(TableConst);
			Row = i;
			Column = j;
			AStarGreedy = std::vector<AllDraw>();
			//Clear Dearty Part.
			/*TableListSolder.Clear();
			TableListElefant.Clear();
			TableListHourse.Clear();
			TableListCastle.Clear();
			TableListMinister.Clear();
			TableListKing.Clear();
			RowColumnSoldier = new List<int*>();
			RowColumnElefant = new List<int*>();
			RowColumnHourse = new List<int*>();
			RowColumnCastle = new List<int*>();
			RowColumnMinister = new List<int*>();
			RowColumnKing = new List<int*>();
			HitNumberSoldier = new List<int>();
			HitNumberElefant = new List<int>();
			HitNumberHourse = new List<int>();
			HitNumberCastle = new List<int>();
			HitNumberMinister = new List<int>();
			HitNumberKing = new List<int>();
			PenaltyRegardListSolder = new List<QuantumAtamata>();
			PenaltyRegardListElefant = new List<QuantumAtamata>();
			PenaltyRegardListHourse = new List<QuantumAtamata>();
			PenaltyRegardListCastle = new List<QuantumAtamata>();
			PenaltyRegardListMinister = new List<QuantumAtamata>();
			PenaltyRegardListKing = new List<QuantumAtamata>();
			AStarGreedy = new List<AllDraw>();
			*/
			//Network  QuantumAtamata Book Initiate For Every Clone.
			//ObjectValueCalculator(TableConst);

		}
	}

	bool ThinkingChess::BeginArragmentsOfOrderFinished(int **Table, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//////lock (O)
		{
			int CH = 0;
			if (ArrangmentsChanged)
			{
				if (Order == 1)
				{
					//Number of Gray Objects at Last Row Bottmm.
					for (int i = 0; i < 2; i++)
					{
						for (int j = 6; j < 8; j++)
						{
							if (Table[i][j] > 0)
							{
								CH++;
							}
						}
					}
				}
				else
				{
					//Number of Brown Objects at Last tow Row Upper.
					for (int i = 0; i < 8; i++)
					{
						for (int j = 0; j < 2; j++)
						{
							if (Table[i][j] < 0)
							{
								CH++;
							}
						}
					}
				}

			}
			else
			{
				if (Order == -1)
				{
					//Number of Brown Objects Table at Last tow row Uppper.
					for (int i = 0; i < 8; i++)
					{
						for (int j = 6; j < 2; j++)
						{
							if (Table[i][j] > 0)
							{
								CH++;
							}
						}
					}
				}
				else
				{
					//Number of Gray Objects Table at Last tow rown below.
					for (int i = 0; i < 2; i++)
					{
						for (int j = 0; j < 8; j++)
						{
							if (Table[i][j] < 0)
							{
								CH++;
							}
						}
					}
				}
			}

			if (CH <= 8)
			{
				return true;
			}
			return false;
		}
	}

	ThinkingChess::ThinkingChess(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j, int a, int **Tab, int Ma, int Ord, bool ThinkingBeg, int CurA, int ThingN, int Kin)
	{
		InitializeInstanceFields();
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//////lock (O)
		{
			CurrentAStarGredyMax = CurrentAStarGredy;
			MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
			IgnoreSelfObjectsT = IgnoreSelfObject;
			UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
			BestMovmentsT = BestMovment;
			PredictHuristicT = PredictHurist;
			OnlySelfT = OnlySel;
			AStarGreedyHuristicT = AStarGreedyHuris;
			//Initiate Variables.
			ArrangmentsChanged = Arrangments;
			Kind = Kin;
			SetObjectNumbers(Tab);
			//THIS = TH;
			AStarGreedy = std::vector<AllDraw>();
			ThingsNumber = ThingN;
			CurrentArray = CurA;
			/*TableListSolder.Clear();
			TableListElefant.Clear();
			TableListHourse.Clear();
			TableListCastle.Clear();
			TableListMinister.Clear();
			TableListKing.Clear();
			RowColumnSoldier = new List<int*>();
			RowColumnElefant = new List<int*>();
			RowColumnHourse = new List<int*>();
			RowColumnCastle = new List<int*>();
			RowColumnMinister = new List<int*>();
			RowColumnKing = new List<int*>();
			RowColumn = new int[1000000, 2];
			HitNumberSoldier = new List<int>();
			HitNumberElefant = new List<int>();
			HitNumberHourse = new List<int>();
			HitNumberCastle = new List<int>();
			HitNumberMinister = new List<int>();
			HitNumberKing = new List<int>();
			PenaltyRegardListSolder = new List<QuantumAtamata>();
			PenaltyRegardListElefant = new List<QuantumAtamata>();
			PenaltyRegardListHourse = new List<QuantumAtamata>();
			PenaltyRegardListCastle = new List<QuantumAtamata>();
			PenaltyRegardListMinister = new List<QuantumAtamata>();
			PenaltyRegardListKing = new List<QuantumAtamata>();
			*/
			Row = i;
			Column = j;
			color = a;
			Max = Ma;
			TableT = Tab;
			//Index = 0;
			IndexSoldier = 0;
			IndexElefant = 0;
			IndexHourse = 0;
			IndexCastle = 0;
			IndexMinister = 0;
			IndexKing = 0;
			TableConst = new int*[8]; for (int g = 0; g > 8; g++)TableConst[g] = new int[8];
			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					TableConst[ii][jj] = Tab[ii][jj];
				}
			}
			Order = Ord;
			ThinkingBegin = ThinkingBeg;
			AStarGreedy = std::vector<AllDraw>();
			//AStarGreedy = new List<AllDraw>();
			/*Object o = new Object();
			////lock (O)
			{
			    for (int h = 0; h < 8; h++)
			        for (int m = 0; m < 8; m++)
			        {
			            if (TableConst != null)
			            {
			                if (TableConst[h, m] == 0)
			                    continue;
			                Value[h, m] = ObjectValueCalculator(TableConst, Order, h, m);
			            }
	
			        }
			}
			*/
			//ObjectValueCalculator(TableConst, Row, Column);
			//SetObjectNumbers(TableConst);
		}
	}

	int **ThinkingChess::CloneATable(int **Tab)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//////lock (O)
		{
			//Create and new an Object.
			int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
			//Assigne Parameter To New Objects.
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Table[i][j] = Tab[i][j];
				}
			}
			//Return New Object.
			return Table;
		}
	}

	int *ThinkingChess::CloneAList(int *Tab, int Count)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate new Objects.
			int *Table = new int[Count];
			//Asigne to new Objects.
			for (int i = 0; i < Count; i++)
			{
				Table[i] = Tab[i];
			}
			//Retrun new Object.
			return Table;
		}
	}

	double *ThinkingChess::CloneAList(double *Tab, int Count)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate New Object.
			double *Table = new double[Count];
			//Assigne to new Object.,
			for (int i = 0; i < Count; i++)
			{
				Table[i] = Tab[i];
			}
			//Return New Object.
			return Table;
		}
	}

	double ThinkingChess::GetValue(int i, int j)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			return Value[i][j];
			//return 1;
		}
	}
/*
	void ThinkingChess::Clone(ThinkingChess AA)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Assignment Content to New Content Object.
			//Initaite New Object.
			if ((&AA) == nullptr)
			{
				AA = ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column); //, Kind
			}
			AA.ArrangmentsChanged = ArrangmentsChanged;
			//When Depth Object is not NULL.
			if (AStarGreedy.size() != 0)
			{
				AA.AStarGreedy = std::vector<AllDraw>();
				//For All Depth(s).
				for (int i = 0; i < AStarGreedy.size(); i++)
				{

						//Clone a Copy From Depth Objects.
						AStarGreedy[i].Clone(AA.AStarGreedy[i]);

				}
			}
			//For All Moves Indexx Solders List Count.
			for (int j = 0; j < RowColumnSoldier.size(); j++)

			{
				//Add a Clone To New Solder indexx Object.
				AA.RowColumnSoldier.push_back(CloneAList(RowColumnSoldier[j], 2));
			}
			//For All Castle List Count.
			for (int j = 0; j < RowColumnCastle.size(); j++)
			{
				//Add a Clone to New Castle index Objects List.
				AA.RowColumnCastle.push_back(CloneAList(RowColumnCastle[j], 2));
			}

			//For All Elephant index List Count.
			for (int j = 0; j < RowColumnElefant.size(); j++)
			{
				//Add a Clone to New Elephant Object List.
				AA.RowColumnElefant.push_back(CloneAList(RowColumnElefant[j], 2));
			}
			//For All Hourse index List Count.
			for (int j = 0; j < RowColumnHourse.size(); j++)
			{
				//Add a Clone to New Hourse index List.
				AA.RowColumnHourse.push_back(CloneAList(RowColumnHourse[j], 2));
			}
			//For All King index List Count.
			for (int j = 0; j < RowColumnKing.size(); j++)
			{
				//Add a Clone To New King Object List.
				AA.RowColumnKing.push_back(CloneAList(RowColumnKing[j], 2));
			}
			//For All Minister index Count.
			for (int j = 0; j < RowColumnMinister.size(); j++)
			{
				//Add a Clone To Minister New index List.
				AA.RowColumnMinister.push_back(CloneAList(RowColumnMinister[j], 2));
			}
			//Assgine thread.
			//AA.t = t;
			//Create and Initiate new Table Object.
			AA.TableT = new int*[8]; for (int g = 0; g < 8; g++)AA.TableT[g] = new int[8];
			//Create and Initaite New Table Object.
			AA.TableConst = new int*[8]; for (int g = 0; g < 8; g++)AA.TableConst[g] = new int[8];
			//if Table is not NULL>
			if (TableT != nullptr)
			{
				//For All Items in Table Object.
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						//Assgine Table items in New Table Object.
						AA.TableT[i][j] = TableT[i][j];
					}
				}
			}
			//If Table is Not Null.
			if (TableConst != nullptr)
			{
				//For All Items in Table Object.
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						//Assignm Items in New Table Object.
						AA.TableConst[i][j] = TableConst[i][j];
					}
				}
			}
			//For All Table State Movements in Castles Objects.
			for (int i = 0; i < TableListCastle.size(); i++)
			{
				//Add aclon of a Table in New Briges Table List.
				AA.TableListCastle.push_back(CloneATable(TableListCastle[i]));
			}
			//For All Table List Movements in  Elephant Objects 
			for (int i = 0; i < TableListElefant.size(); i++)
			{
				//Add a Clone of Tables in Elephant Mevments Obejcts List To New One.
				AA.TableListElefant.push_back(CloneATable(TableListElefant[i]));
			}
			//For All Hourse Table Movemnts items.
			for (int i = 0; i < TableListHourse.size(); i++)
			{
				//Add a Clone of Hourse Table Movement in New List.
				AA.TableListHourse.push_back(CloneATable(TableListHourse[i]));
			}
			//For All King Tables Movment Count.
			for (int i = 0; i < TableListKing.size(); i++)
			{
				//Add a Clone To New King Table List.
				AA.TableListKing.push_back(CloneATable(TableListKing[i]));
			}
			//For All Minister Table Movment Items.
			for (int i = 0; i < TableListMinister.size(); i++)
			{
				//Add a clone To New Minister Table Movment List.
				AA.TableListMinister.push_back(CloneATable(TableListMinister[i]));
			}
			//For All Solder Table Movment Count.
			for (int i = 0; i < TableListSolder.size(); i++)
			{
				//Add a Clone of Table item to New Table List Movments.
				AA.TableListSolder.push_back(CloneATable(TableListSolder[i]));
			}

			//For All Solder Husrist List Count.
			for (int i = 0; i < HuristicListSolder.size(); i++)
			{
				//Ad a Clone of Hueristic Solders To New List.
				AA.HuristicListSolder.push_back(CloneAList(HuristicListSolder[i], 4));
			}
			//For All Elephant Huristic List Count. 
			for (int i = 0; i < HuristicListElefant.size(); i++)
			{
				//Add A Clone of Copy to New Elephant Huristic List.
				AA.HuristicListElefant.push_back(CloneAList(HuristicListElefant[i], 4));
			}
			//For All Hours Huristic Hourse Count.
			for (int i = 0; i < HuristicListHourse.size(); i++)
			{
				//Add a Clone of Copy To New Housre Huristic List.
				AA.HuristicListHourse.push_back(CloneAList(HuristicListHourse[i], 4));
			}
			//For All Castles Huristic List Count.
			for (int i = 0; i < HuristicListCastle.size(); i++)
			{
				//Add a Clone of Copy to New Castles Huristic List.
				AA.HuristicListCastle.push_back(CloneAList(HuristicListCastle[i], 4));
			}
			//For All Minister Huristic List Count.
			for (int i = 0; i < HuristicListMinister.size(); i++)
			{
				//Add a Clone of Copy to New Minister List.
				AA.HuristicListMinister.push_back(CloneAList(HuristicListMinister[i], 4));
			}
			//For All King Husrict List Items.
			for (int i = 0; i < HuristicListKing.size(); i++)
			{
				//Add a Clone of Copy to New King Hursitic List.
				AA.HuristicListKing.push_back(CloneAList(HuristicListKing[i], 4));
			}
			//Initiate and create Penalty Solder List.
			AA.PenaltyRegardListSolder = std::vector<QuantumAtamata>();
			//For All Solder Penalty List Count.
			if (Kind == 1)
			{
				AA.PenaltyRegardListSolder = std::vector<QuantumAtamata>();
				for (int i = 0; i < PenaltyRegardListSolder.size(); i++)
				{
					//Initiate a new  QuantumAtamata Object
					//QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					//Add New Object Create to New Penalty Solder List.
					AA.PenaltyRegardListSolder.push_back(PenaltyRegardListSolder[i]);
				}
			}
			else
			{
			if (Kind == 2)
			{
				//Initaite and Create Elephant Penalty List Object.
				AA.PenaltyRegardListElefant = std::vector<QuantumAtamata>();
				//For All Elepahtn Penalty List Count.
				for (int i = 0; i < PenaltyRegardListElefant.size(); i++)
				{
					//Initiate a new  QuantumAtamata Object
					//QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					//Clone a Copy Of Penalty Elephant.
					AA.PenaltyRegardListElefant.push_back(PenaltyRegardListElefant[i]);
					//Add New Object Create to New Penalty Elephant List.
					//AA.PenaltyRegardListElefant.Add(Current);
				}

			}
			else
			{
		if (Kind == 3)
		{

				//Initaite and Create Hourse Penalty List Object.
				AA.PenaltyRegardListHourse = std::vector<QuantumAtamata>();
				//For All Solder Hourse List Count.
				for (int i = 0; i < PenaltyRegardListHourse.size(); i++)
				{
					//Initiate a new  QuantumAtamata Object
					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					//Clone a Copy Of Penalty Hourse.
					//PenaltyRegardListHourse[i].Clone( Current);
					//Add New Object Create to New Penalty Hourse List.
					AA.PenaltyRegardListHourse.push_back(PenaltyRegardListHourse[i]);
				}

		}
			else
			{
			if (Kind == 4)
			{

				//Initaite and Create Castles Penalty List Object.
				AA.PenaltyRegardListCastle = std::vector<QuantumAtamata>();
				//For All Solder Castle List Count.
				for (int i = 0; i < PenaltyRegardListCastle.size(); i++)
				{
					//Initiate a new  QuantumAtamata Object
					//QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					//Clone a Copy Of Penalty Castles.
					//PenaltyRegardListCastle[i].Clone( Current);
					//Add New Object Create to New Penalty Castles List.
					AA.PenaltyRegardListCastle.push_back(PenaltyRegardListCastle[i]);
				}
			}
			else
			{
			if (Kind == 5)
			{

				//Initaite and Create Minister Penalty List Object.
				AA.PenaltyRegardListMinister = std::vector<QuantumAtamata>();
				//For All Solder Minster List Count.
				for (int i = 0; i < PenaltyRegardListMinister.size(); i++)
				{
					//Initiate a new  QuantumAtamata Object
					//QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					//Clone a Copy Of Penalty Minsiter.
					//PenaltyRegardListMinister[i].Clone( Current);
					//Add New Object Create to New Penalty Minsietr List.
					AA.PenaltyRegardListMinister.push_back(PenaltyRegardListMinister[i]);
				}
			}
			else
			{
			if (Kind == 6)
			{

				//Initaite and Create King Penalty List Object.
				AA.PenaltyRegardListKing = std::vector<QuantumAtamata>();
				//For All Solder King List Count.
				for (int i = 0; i < PenaltyRegardListKing.size(); i++)
				{
					//Initiate a new  QuantumAtamata Object
					//QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					//Clone a Copy Of Penalty King.
					//PenaltyRegardListKing[i].Clone( Current);
					//Add New Object Create to New Penalty King List.
					AA.PenaltyRegardListKing.push_back(PenaltyRegardListKing[i]);
				}
			}
			}
			}
			}
			}
			}
			//Iniktiate Same Obejcts to New Same Obejcts.
			AA.AStarGreedy = AStarGreedy;
			AA.CastleValue = CastleValue;
			AA.color = color;
			AA.Column = Column;
			AA.CurrentArray = CurrentArray;
			AA.CurrentColumn = CurrentColumn;
			AA.CurrentRow = CurrentRow;
			AA.ElefantValue = ElefantValue;
			AA.ExistingOfEnemyHiiting = ExistingOfEnemyHiiting;
			AA.HourseValue = HourseValue;
			AA.IgnoreObjectDangour = IgnoreObjectDangour;
			AA.IndexCastle = IndexCastle;
			AA.IndexElefant = IndexElefant;
			AA.IndexHourse = IndexHourse;
			AA.IndexKing = IndexKing;
			AA.IndexMinister = IndexMinister;
			AA.IndexSoldier = IndexSoldier;
			AA.IsCheck = IsCheck;
			AA.Kind = Kind;
			AA.KingValue = KingValue;
			AA.CheckMateAStarGreedy = CheckMateAStarGreedy;
			AA.CheckMateOcuured = CheckMateOcuured;
			AA.Max = Max;
			AA.MinisterValue = MinisterValue;
			AA.Order = Order;
			AA.Row = Row;
			AA.SodierValue = SodierValue;
			AA.ThingsNumber = ThingsNumber;
			AA.ThinkingBegin = ThinkingBegin;
			AA.ThinkingFinished = ThinkingFinished;
		}
	}
*/
	double ThinkingChess::HuristicAttack(bool Before, int **Table, int Ord, int aa, int RowS, int ColS, int RowD, int ColD)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double HuristicAttackValue = 0;
			double HA = 0;
			int DumOrder = Order;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			///When AStarGreedy Huristic is Not Assigned.

				//When Huristic is not Greedy.
				if (!AStarGreedyHuristicT)
				{
					int Order = int();
					int a = int();
					a = aa;
					if (RowS == RowD && ColS == ColD)
					{
						return HuristicAttackValue;
					}
					double Sign = double();
					Order = DummyOrder;
					///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
					///What is Attack!
					///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
					if (Table[RowD][ColD] > 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
					{
						Order = -1;
						Sign = AllDraw::SignAttack;
						ChessRules::CurrentOrder = -1;
						a = -1;
					}
					else if (Table[RowD][ColD] < 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
					{
						Order = 1;
						Sign = AllDraw::SignAttack;
						ChessRules::CurrentOrder = -1;
						a = 1;
					}
					else
					{
						return HuristicAttackValue;
					}
					//For Attack Movments.- GetObjectValueHuristic
					////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						if (Before)
						{
							if (Attack(Table, RowS, ColS, RowD, ColD, a, Order))
							{

								//Find Huristic Value Of Current and Add to Sumation.
								HA += (Sign * (abs(ObjectValueCalculator(Table, RowS, ColS, RowD, ColD))));
							//When there is supporter of attacked Objects take huristic negative else take muliply sign and muliply huristic.
							/*int Supported = new int();
							int SupportedS = new int();
							Supported = 0;
							SupportedS = 0;
							//For All Enemy Obejcts.                                             
							////Parallel.For(0, 8, g =>
							for (int g = 0; g < 8; g++)
							{
							    ////Parallel.For(0, 8, h =>
							    for (int h = 0; h < 8; h++)
							    {
							        //Ignore Of Self Objects.
							        if (Order == 1 && Table[g, h] >= 0)
							            continue;
							        if (Order == -1 && Table[g, h] <= 0)
							            continue;
							        int aaa = new int();
							        //Assgin Enemy ints.
							        aaa = int.Gray;
							        if (Order * -1 == -1)
							            aaa = int.Brown;
							        else
							            aaa = int.Gray;
							        //When Enemy is Supported.
							        bool A = new bool();
							        bool B = new bool();
							        Object O2 = new Object();
							        //lock (O2)
							        {
							            A = Support(Table, g, h, RowD, ColD, aaa, Order * -1);
							            B = Support(Table, g, h, RowS, ColS, a, Order);
							        }
							        //When Enemy is Supported.
							        if (B)
							        {
							            //Assgine variable.
							            SupportedS++;
	
							        }
							        if (A)
							        {
							            //Assgine variable.
							            Supported++;
							            continue;
	
							        }
	
							    }//);
							}//);
							if (SupportedS != 0)
							    HA *= System.Math.Pow(2, SupportedS);
	
							if (Supported != 0)
							    HA *= (-1 * System.Math.Pow(2, Supported));
	*/
							}
						}
					}

				}
				//For All Table Homes find Attack Huristic.
				else
				{
					int Order = int();
					int a = int();
					a = aa;
					//Ignore of Current.
					if (RowS == RowD && ColS == ColD)
					{
						return HuristicAttackValue;
					}
					Order = DummyOrder;
					double Sign = 1;
					///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
					///What is Attack!
					///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
					if (Table[RowD][ColD] > 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
					{
						Order = -1;
						Sign = AllDraw::SignAttack;
						ChessRules::CurrentOrder = -1;
						a = -1;
					}
					else if (Table[RowD][ColD] < 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
					{
						Order = 1;
						Sign = AllDraw::SignAttack;
						ChessRules::CurrentOrder = -1;
						a = 1;
					}
					else
					{
						return HuristicAttackValue;
					}
					int Supported = 0;

					//For Attack Movments.
					////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O2)
					{
						if (Before)
						{
							if (Attack(Table, RowS, ColS, RowD, ColD, a, Order))
							{

								HA += (Sign * (abs(ObjectValueCalculator(Table, RowS, ColS, RowD, ColD))));

								//When there is supporter of attacked Objects take huristic negative else take muliply sign and muliply huristic.
								//For All Enemy Obejcts.                                             
								////Parallel.For(0, 8, g =>

								/*int SupportedS = new int();
								Supported = 0;
								SupportedS = 0;
								//For All Enemy Obejcts.                                             
								////Parallel.For(0, 8, g =>
								for (int g = 0; g < 8; g++)
								{
								    ////Parallel.For(0, 8, h =>
								    for (int h = 0; h < 8; h++)
								    {
								        //Ignore Of Self Objects.
								        if (Order == 1 && Table[g, h] >= 0)
								            continue;
								        if (Order == -1 && Table[g, h] <= 0)
								            continue;
								        int aaa = new int();
								        //Assgin Enemy ints.
								        aaa = int.Gray;
								        if (Order * -1 == -1)
								            aaa = int.Brown;
								        else
								            aaa = int.Gray;
								        //When Enemy is Supported.
								        bool A = new bool();
								        bool B = new bool();
								        Object O12 = new Object();
								        //lock (O12)
								        {
								            A = Support(Table, g, h, RowD, ColD, aaa, Order * -1);
								            B = Support(Table, g, h, RowS, ColS, a, Order);
								        }
								        //When Enemy is Supported.
								        if (B)
								        {
								            //Assgine variable.
								            SupportedS++;
	
								        }
								        if (A)
								        {
								            //Assgine variable.
								            Supported++;
								            continue;
	
								        }
	
								    }//);
								}//);
								if (SupportedS != 0)
								    HA *= System.Math.Pow(2, SupportedS);
	
								if (Supported != 0)
								    HA *= (-1 * System.Math.Pow(2, Supported));
						   */
							}
						}
					}
				}
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			Order = DumOrder;
			//Initiate to Begin Call Orders.
			return 1 * HA;
		}
	}

	double ThinkingChess::HuristicReducsedAttack(bool Before, int **Table, int Ord, int aa, int RowS, int ColS, int RowD, int ColD)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double HuristicReducedAttackValue = 0;
			//Initiate Objects.
			double HA = 0;
			int DumOrder = Order;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			double Sign = 1;
			///When AStarGreedy Huristic is Not Assigned.


				if (!AStarGreedyHuristicT)
				{
					//int RowS = RowSS, ColS = ColSS;
					//For All Self
					//for (int RowD = 0; RowD < 8; RowD++)
					{
						{
						//for (int ColD = 0; ColD < 8; ColD++)

							//For Current Object Lcation.
							int Order = int();
							Order = DumOrder;
							int a = int();
							a = aa;

							//Ignore Current Unnessery Home.
							if (RowS == RowD && ColS == ColD)
							{
								return 0;
							}
							//Default Is Gray One.

							Order = DummyOrder;
							///When Supporte is true. means [RowD,ColD] Supportes [RowS,ColS].
							///What is Supporte!
							///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
							//if (Order == 1 && Table[RowD, ColD] >= 0)
							//continue;
							//if (Order == -1 && Table[RowD, ColD] <= 0)
							//continue;
							//if (!Scop(RowD, ColD, RowS, ColS, System.Math.Abs(Table[RowD, ColD])))
							//continue;
							///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
							///What is Attack!
							///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
							if (Table[RowD][ColD] > 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
							{
								Order = 1;
								Sign = -1 * AllDraw::SignAttack;
								ChessRules::CurrentOrder = 1;
								a = 1;
							}
							else if (Table[RowD][ColD] < 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
							{
								Order = -1;
								Sign = -1 * AllDraw::SignAttack;
								ChessRules::CurrentOrder = -1;
								a = -1;
							}
							else
							{
								return HuristicReducedAttackValue;
							}

							//For Attack Movments.
							////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{
								if (Before)
								{
									if (Attack(Table, RowD, ColD, RowS, ColS, a, Order))
									{

										HA += (Sign * (abs(ObjectValueCalculator(Table, RowD, ColD,RowS, ColS))));
										/*int Reduced = new int();
										int Increased = new int();
										Reduced = 0;
										Increased = 0;
	
										////Parallel.For(0, 8, g =>
										for (int g = 0; g < 8; g++)
										{
										    ////Parallel.For(0, 8, h =>
										    for (int h = 0; h < 8; h++)
	
										    {
										        //Ignore Of Enemy Objects.
										        if (Order == 1 && Table[g, h] == 0)
										            continue;
										        if (Order == -1 && Table[g, h] == 0)
										            continue;
										        int aaa = new int();
										        //Assgin Enemy ints.
										        if (Order * -1 == -1)
										            aaa = int.Brown;
										        else
										            aaa = int.Gray;
										        bool A = new bool();
										        bool B = new bool();
										        
										        Object O2 = new Object();
										        //lock (O2)
										        {
										            A = Support(Table, g, h, RowD, ColD, aaa, Order * 1);
										            B = Support(Table, g, h, RowS, ColS, a, Order);
										        }
										        //When Enemy is Supported.
										        if (B)
										        {
										            //Assgine variable.
										            Increased++;
										            
										        }
										        if (A)
										        {
										            //Assgine variable.
										            Reduced++;
										            continue;
										        }
										    }//);
	
										}//);
	
										if (Reduced != 0)
										    HA *= (-1 * System.Math.Pow(2, Reduced));
										if (Increased != 0)
										    HA *= System.Math.Pow(2, Increased);
	
									*/

									}
								}
							}
						}
					}
				}
				//For All Table Homes find Attack Huristic.
				else
				{
					{
					//for (int RowS = 0; RowS < 8; RowS++)
						//for (int ColS = 0; ColS < 8; ColS++)
						{
							{
							//for (int RowD = 0; RowD < 8; RowD++)
								//for (int ColD = 0; ColD < 8; ColD++)
								{
									int Order = int();
									int a = int();
									a = aa;
									{
										//Ignore Current Home.
										//if (Order == 1 && Table[RowD, ColD] >= 0)
										//continue;
										//if (Order == -1 && Table[RowD, ColD] <= 0)
										//continue;
										//if (!Scop(RowD, ColD, RowS, ColS, System.Math.Abs(Table[RowD, ColD])))
										//  continue;
										///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
										///What is Attack!
										///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
										if (Table[RowD][ColD] > 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
										{
											Order = 1;
											Sign = -1 * AllDraw::SignAttack;
											ChessRules::CurrentOrder = 1;
											a = 1;
										}
										else if (Table[RowD][ColD] < 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
										{
											Order = -1;
											Sign = -1 * AllDraw::SignAttack;
											ChessRules::CurrentOrder = -1;
											a = -1;
										}
										else
										{
											return HuristicReducedAttackValue;
										}
										//For Attack Movments.
										////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O1)
										{
											if (Before)
											{
												if (Attack(Table, RowD, ColD, RowS, ColS, a, Order))
												{

													HA += (Sign * (abs(ObjectValueCalculator(Table, RowD, ColD,RowS, ColS))));
													/*int Reduced = new int();
													int Increased = new int();
													Reduced = 0;
													Increased = 0;
													//For All Self Obejcts.                                             
													////Parallel.For(0, 8, g =>
													////Parallel.For(0, 8, g =>
													for (int g = 0; g < 8; g++)
													{
													    ////Parallel.For(0, 8, h =>
													    for (int h = 0; h < 8; h++)
	
													    {
													        //Ignore Of Enemy Objects.
													        if (Order == 1 && Table[g, h] == 0)
													            continue;
													        if (Order == -1 && Table[g, h] == 0)
													            continue;
													        int aaa = new int();
													        //Assgin Enemy ints.
													        if (Order * -1 == -1)
													            aaa = int.Brown;
													        else
													            aaa = int.Gray;
													        bool A = new bool();
													        bool B = new bool();
	
													        Object O2 = new Object();
													        //lock (O2)
													        {
													            A = Support(Table, g, h, RowD, ColD, aaa, Order * 1);
													            B = Support(Table, g, h, RowS, ColS, a, Order);
													        }
													        //When Enemy is Supported.
													        if (B)
													        {
													            //Assgine variable.
													            Increased++;
													            
													        }
													        if (A)
													        {
													            //Assgine variable.
													            Reduced++;
													            continue;
													        }
													    }//);
	
													}//);
	
													if (Reduced != 0)
													    HA *= (-1 * System.Math.Pow(2, Reduced));
													if (Increased != 0)
													    HA *= System.Math.Pow(2, Increased);
												*/
												}
											}
										}
									}
								}
							}
						}
					}
				}
			//Initiate to Begin Call Orders.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			Order = DumOrder;
			//Add Local Huristic to Global One.
			return HA * 1;
		}
	}

	int ThinkingChess::GetObjectValue(int **Tabl, int ii, int jj, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			return abs(Tabl[ii][jj]);
		}
	}

	double ThinkingChess::HuristicObjectDangour(int **Table, int Order, int a, int RowS, int ColS, int RowD, int ColD)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double HuristicObjectDangourCheckMateValue = 0;
			double HA = 0;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			///When There is no AStarGreedyHuristicT

				if (!AStarGreedyHuristicT)
				{
					///For All Object in Current Table.
					if (RowS == RowD && ColS == ColD)
					{
						return HuristicObjectDangourCheckMateValue;
					}
					Order = DummyOrder;
					double Sign = 1;
					///When ObjectDanger is true. means [RowD,ColD] is in ObjectDanger by [RowS,ColS].
					///What is ObjectDanger!
					///Ans:When [RowS,ColS] is Attacked [RowD,ColD] return true when enemy is located in [RowD,ColD].
					if (Table[RowD][ColD] > 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
					{
						Order = 1;
						////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{
							Sign = -1 * AllDraw::SignAttack;
							ChessRules::CurrentOrder = 1;
						}
						a = 1;
					}
					else if (Table[RowD][ColD] < 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
					{
						Order = -1;
						////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{
							Sign = -1 * AllDraw::SignAttack;
							ChessRules::CurrentOrder = -1;
						}
						a = -1;
					}
					else
					{
						return HuristicObjectDangourCheckMateValue;
					}
					//For ObjectDanger Movments.
					if (ObjectDanger(Table, RowD, ColD, RowS, ColS, a, Order))
					{
						//Find Local Sumation of ObjectDanger Huristic.                                
						HA += Sign * (ObjectValueCalculator(Table, RowD, ColD,RowS, ColS));
					}
				}
				//For All Table Home Find ObjectDanger Huristic
				else
				{
					if (RowS == RowD && ColS == ColD)
					{
						return HuristicObjectDangourCheckMateValue;
					}
					double Sign = 1;
					///When ObjectDanger is true. means [RowD,ColD] is in ObjectDanger by [RowS,ColS].
					///What is ObjectDanger!
					///Ans:When [RowS,ColS] is Attacked [RowD,ColD] return true when enemy is located in [RowD,ColD].
					if (Table[RowD][ColD] > 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
					{
						Order = 1;
						////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							Sign = -1 * AllDraw::SignAttack;
							ChessRules::CurrentOrder = 1;
						}
						a = 1;
					}
					else if (Table[RowD][ColD] < 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
					{
						Order = -1;
						////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O3)
						{
							Sign = -1 * AllDraw::SignAttack;
							ChessRules::CurrentOrder = -1;
						}
						a = -1;
					}
					else
					{
						return HuristicObjectDangourCheckMateValue;
					}
					//For ObjectDanger Movments.
					////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						if (ObjectDanger(Table, RowD, ColD, RowS, ColS, a, Order))
						{
							//Find Local Sumation of ObjectDanger Huristic.                                
							HA += Sign * (ObjectValueCalculator(Table, RowD, ColD,RowS, ColS));
						}
					}
				}

			//Initiate Orders to Call Begining.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			//Assignments of Global Huristic with Local One.
			//return Local Huristic.
			return HA * 1;
		}
	}

	double ThinkingChess::HuristicKiller(int Killed, int **Tabl, int RowS, int ColS, int RowD, int ColD, int Ord, int aa, bool Hit)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			for (int ik = 0; ik < 8; ik++)
			{
				for (int jk = 0; jk < 8; jk++)
				{
					Tab[ik][jk] = Tabl[ik][jk];
				}
			}
			double HuristicKillerValue = 0;
			//Defualt is Gray Order.
			double HA = 0.0;
			double Sign = AllDraw::SignKiller;
			int DummyOrder = Ord;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			//Make live when there is killed.
			if (Killed != 0)
			{
				Tab[RowD][ColD] = Tab[RowS][ColS];
				Tab[RowS][ColS] = Killed;
			}


				int Order = int();
				Order = DummyOrder;
				int a = int();
				a = aa;

				int colorAS = a;
				//Ignore of Self.
				if (Order == 1 && Tab[RowD][ColD] >= 0)
				{
					return HuristicKillerValue;
				}
				if (Order == -1 && Tab[RowD][ColD] <= 0)
				{
					return HuristicKillerValue;
				}
				bool EnemyNotSupported = false;
				a = 1;
				if (Order == -1)
				{
					a = -1;
				}
				//Wehn Curfrent Movemnet is on attack.
				////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O1)
				{
					EnemyNotSupported = InAttackEnemyThatIsNotSupported(Killed, Tab, Order, aa, RowS, ColS, RowD, ColD);
					//When there is Attacks to Current Objects and is killable..
					if (Attack(Tab, RowS, ColS, RowD, ColD, a, Order))
					{
						if (EnemyNotSupported)
						{
							//Huristic positive.
							HA += AllDraw::SignKiller * static_cast<double>((ObjectValueCalculator(Tab,RowS, ColS, RowD, ColD)));
						}
						else
						{
							//Huristic ngative.
							HA += AllDraw::SignKiller * static_cast<double>((ObjectValueCalculator(Tab,RowS, ColS, RowD, ColD)) * -1);
						}
					}
					a = colorAS;
				}

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;

			return 1 * HA;
		}
	}

	bool ThinkingChess::InAttackEnemyThatIsNotSupported(int Kilded, int **Table, int Order, int a, int i, int j, int ii, int jj)
	{

		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Global Variables.                
			int Ord = Order;
			bool S = true;
			//int i = iij, j = jji;
			bool EnemyNotSupported = true;
			if (Kilded != 0)
			{
				EnemyNotSupported = true;
				//Enemy
				////Parallel.For(0, 8, RowS =>
				for (int RowS = 0; RowS < 8; RowS++)

				{
					////Parallel.For(0, 8, ColS =>
					for (int ColS = 0; ColS < 8; ColS++)
					{
						if (!EnemyNotSupported)
						{
							continue;
						}
						int Order1 = int();
						Order1 = Ord;
						int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
						////Parallel.For(0, 8, ik =>
						for (int ik = 0; ik < 8; ik++)
						{
							if (!EnemyNotSupported)
							{
								continue;
							}
							for (int jk = 0; jk < 8; jk++)
							{
							////Parallel.For(0, 8, jk =>
								////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O3)
								{
									Tab[ik][jk] = Table[ik][jk];
								}
							} //);
						} //);
						////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							Tab[i][j] = Tab[ii][jj];
							Tab[ii][jj] = Kilded;
						}
						//Ignore of Current
						if (Order1 == 1 && Tab[RowS][ColS] >= 0)
						{
							continue;
						}
						else
						{
								if (Order1 == -1 && Tab[RowS][ColS] <= 0)
								{
							continue;
								}
						}
						a = 1;
						if (Order1 * -1 == -1)
						{
							a = -1;
						}
						//When Enemy is Supported.
						////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O1)
						{
							if (Support(Tab, RowS, ColS, ii, jj, a, Order1 * -1) && ObjectValueCalculator(Tab, i, j) >= ObjectValueCalculator(Tab, ii, jj))

							//Wehn [i,j] (Current) is less or equal than [ii,jj] (Enemy) 
							//EnemyNotSupported method Should continue [valid]
							//By this situation continue not valid
							{

								EnemyNotSupported = false;
								continue;
							}
						}
					} //);
					if (!EnemyNotSupported)
					{
						continue;
					}
				} //);

				if (EnemyNotSupported)
				{
					S = false;
				}

			}

			//When S is not valid there is one node in [EnemyNotSupported]
			if (!S)
			{
				Order = Ord;
				return true;
			}

			Order = Ord;
			return false;
		}
	}

	bool ThinkingChess::InAttackEnemyThatIsNotSupportedAll(bool EnemyIsValuable, int **Table, int Order, int a, int ij, int ji, int iij, int jji, std::vector<int*> &ValuableEnemyNotSupported)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Global Variables.
			int Ord = Order;
			////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O4)
			{
				int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tab[ik][jk] = Table[ik][jk];
					}
				}
				bool S = true;
				bool EnemyNotSupported = true;
				bool InAttackedNotEnemySupported = false;
				//int i = iij, j = jji;
				//For Current
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						//Ignore of Enemy
						if (Order == 1 && Tab[i][j] <= 0)
						{
							continue;
						}
						else
						{
							if (Order == -1 && Tab[i][j] >= 0)
							{
							continue;
							}
						}
						//For Enemies.
						for (int ii = 0; ii < 8; ii++)
						{
							for (int jj = 0; jj < 8; jj++)
							{
								//Ignore of Curent
								if (Order == 1 && Tab[ii][jj] >= 0)
								{
									continue;
								}
								else
								{
									if (Order == -1 && Tab[ii][jj] <= 0)
									{
									continue;
									}
								}
								////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{
									if (EnemyIsValuable && (!IsObjectValaubleObjectEnemy(ii, jj, Tab[ii][jj], ValuableEnemyNotSupported)))
									{
										continue;
									}

									EnemyNotSupported = true;
									InAttackedNotEnemySupported = false;
									if (Attack(Tab, i, j, ii, jj, a, Order))
									{
										InAttackedNotEnemySupported = true;

										//Enemy
										for (int RowS = 0; RowS < 8; RowS++)
										{
											for (int ColS = 0; ColS < 8; ColS++)
											{
												//Ignore of Current
												if (Order == 1 && Tab[RowS][ColS] >= 0)
												{
													continue;
												}
												else
												{
													if (Order == -1 && Tab[RowS][ColS] <= 0)
													{
													continue;
													}
												}
												a = 1;
												if (Order * -1 == -1)
												{
													a = -1;
												}
												//
												if (Support(Tab, RowS, ColS, ii, jj, a, Order * -1))
													//&& (ObjectValueCalculator(Tab,i,j) >= ObjectValueCalculator(Tab,ii,jj)
													//Wehn [i,j] (Current) is less or equal than [ii,jj] (Enemy) 
													//EnemyNotSupported method Should return [valid]
													//By this situation return not valid
												{
													EnemyNotSupported = false;
												}
											}
											if (!EnemyNotSupported)
											{
												break;
											}
										}
									}
									if (EnemyNotSupported && InAttackedNotEnemySupported)
									{
										S = false;
										break;

									}
								}
							}
							if (!S)
							{
								break;
							}
						}

						if (!S)
						{
							break;
						}
					}
					if (!S)
					{
						break;
					}
				}
				//When there is at leat tow enmy of attackment.

				if (!S)
				{
					Order = Ord;
					return true;
				}

				Order = Ord;
			}
			return false;
		}
	}

	int ThinkingChess::IsNotSafeToMoveAenemeyToAttackMoreThanTowObject(int AttackCount, int **Table, int Order, int i, int j, int ii, int jj)
	{

		//For All Enemie
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			//Ignore of Self
			if (Order == 1 && Table[i][j] >= 0)
			{
				return 0;
			}
			if (Order == -1 && Table[i][j] <= 0)
			{
				return 0;
			}
			//For All Self and Empty.
			//Ignore of Enemy.
			if (Order == 1 && Table[ii][jj] < 0)
			{
				return 0;
			}
			if (Order == -1 && Table[ii][jj] > 0)
			{
				return 0;
			}
			ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[i][j], Table, Order * -1, i, j);
			int a = 1;
			if (Order * -1 == -1)
			{
				a = -1;
			}
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tab[ik][jk] = Table[ik][jk];
					}
				}
			}
			//When there is attack to some self node.
			////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (OO)
			{
				if (A->Rules(i, j, ii, jj, a, Tab[i][j]))
				{
					//take move
					Tab[ii][jj] = Tab[i][j];
					Tab[i][j] = 0;
					AttackCount = 0;
					//For All Self
					for (int RowS = 0; RowS < 8; RowS++)
					{
					////Parallel.For(0, 8, RowS =>
						//if (AttackCount > 1)
						//continue;
						for (int ColS = 0; ColS < 8; ColS++)
						{
						////Parallel.For(0, 8, ColS =>
							if (AttackCount > 1)
							{
								continue;
							}

							//Ignore of Enemy.
							if (Order == 1 && Tab[RowS][ColS] <= 0)
							{
								continue;
							}
							if (Order == -1 && Tab[RowS][ColS] >= 0)
							{
								continue;
							}
							a = 1;
							if (Order * -1 == -1)
							{
								a = -1;
							}
							//when there is attack to some self node.
							if (Attack(Tab, ii, jj, RowS, ColS, a, Order * -1))
							{
								bool Supporte = false;
								//For All Self
								////Parallel.For(0, 8, RowD =>
								for (int RowD = 0; RowD < 8; RowD++)
								{
									if (AttackCount > 1)
									{
										continue;
									}
									////Parallel.For(0, 8, ColD =>
									for (int ColD = 0; ColD < 8; ColD++)
									{
										if (AttackCount > 1)
										{
											continue;
										}

										//Ignore of Enemy.
										if (Order == 1 && Tab[RowD][ColD] <= 0)
										{
											continue;
										}
										if (Order == -1 && Tab[RowD][ColD] >= 0)
										{
											continue;
										}
										a = 1;
										if (Order == -1)
										{
											a = -1;
										}
										//when there is attack of self node to that enemy node.
										if (Support(Tab, RowD, ColD, RowS, ColS, a, Order) || Attack(Tab, RowD, ColD, ii, jj, a, Order))
										{

											Supporte = true;
											continue;
										}
									} //);
								} //);
								if (!Supporte)
								{
									AttackCount++;
								}
							}
							else
							{
								continue;
							}
							if (AttackCount > 1)
							{
								continue;
							}
						} //);
						if (AttackCount > 1)
						{
							continue;
						}
					} //);
				}
				else
				{
					return 0;
				}
			}

			return AttackCount;
		}
	}

	bool ThinkingChess::InAttackSelfThatNotSupported(int **TableS, int Order, int a, int ij, int ji, int ii, int jj)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Variables.
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tab[ik][jk] = TableS[ik][jk];
					}
				}
				int Ord = Order;
				bool SelfSupported = false;
				bool InAttackedNotSelfSupported = false;
				bool IsObjDangerest = false;
				bool S = true;
				int i = ii, j = jj;
				//Ignore of Current
				//For Enemy.
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						//Ignore of Current
						if (Order == 1 && Tab[RowS][ColS] >= 0)
						{
							continue;
						}
						else
						{
						if (Order == -1 && Tab[RowS][ColS] <= 0)
						{
							continue;
						}
						}
						//Enemy
						a = 1;
						if (Order * -1 == -1)
						{
							a = -1;
						}
						for (int ik = 0; ik < 8; ik++)
						{
							for (int jk = 0; jk < 8; jk++)
							{
								Tab[ik][jk] = TableS[ik][jk];
							}
						}
						InAttackedNotSelfSupported = false;
						SelfSupported = false;
						////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (OO)
						{
							if (Attack(Tab, RowS, ColS, i, j, a, Order * -1))
							{
								InAttackedNotSelfSupported = true;
								a = 1;
								if (Order == -1)
								{
									a = -1;
								}

								//For Self.
								for (int RowD = 0; RowD < 8; RowD++)
								{
									for (int ColD = 0; ColD < 8; ColD++)
									{
										//Ignore of Enemies
										if (Order == 1 && Tab[RowD][ColD] <= 0)
										{
											continue;
										}
										else
										{
											if (Order == -1 && Tab[RowD][ColD] >= 0)
											{
											continue;
											}
										}
										a = 1;
										if (Order == -1)
										{
											a = -1;
										}
										for (int ik = 0; ik < 8; ik++)
										{
											for (int jk = 0; jk < 8; jk++)
											{
												Tab[ik][jk] = TableS[ik][jk];
											}
										}
										//When there is support and cuurent is less than enemy.
										//method return true when is not supporte and the enemy is less than cuurent in to be hitten.
										if (Support(Tab, RowD, ColD, i, j, a, Order))
										{
											SelfSupported = true;
											S = S && true;
											break;
										}
									}
									if (SelfSupported)
									{
										break;
									}
								}
								//When a source enemy object attack a destination source object 
								//a source object is greater than another source object. Is = -1 Is another object valuable.
								//a source object is less than or equal  than another source object.Is = 1 Is not another object valuable.
								//IsObjDangerest = IsAnotherObjectMakeDangoure(TableS, Order, color, i, j, RowS, ColS);
							}
						}
						if ((!SelfSupported && InAttackedNotSelfSupported)) //|| IsObjDangerest
						{
							S = false;
							break;
						}

					}
					if ((!SelfSupported && InAttackedNotSelfSupported) || IsObjDangerest)
					{
						S = false;
						break;
					}
				}
				if (!SelfSupported && InAttackedNotSelfSupported)
				{
					S = false;
				}

				if (!SelfSupported && InAttackedNotSelfSupported)
				{
					S = false;
				}


				Order = Ord;
				//When S is valid the any is not in [SelfNotSupported];Self is Supporeted.
				if (S)
				{
					return false;
				}

				return true;
			}
		}
	}

	bool ThinkingChess::InAttackSelfThatNotSupportedAll(int **TableS, int Order, int a, int i, int j, int RowS, int ColS, int ikk, int jkk, int iik, int jjk)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool S = true;
			int Ord = Order;
			std::vector<int*> ValuableSelfSupported = std::vector<int*>();
			bool IsTowValuableObject = false;
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				IsTowValuableObject = InAttackSelfThatNotSupportedCalculateValuableAll(TableS, Order, color, ikk, jkk, iik, jjk, ValuableSelfSupported);
				//Initiate Variables.
				int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tab[ik][jk] = TableS[ik][jk];
					}
				}
				bool SelfSupported = false;
				bool InAttackedNotSelfSupported = false;

				S = true;
				Order = Ord;
				//Ignore of Enemies
				if (Order == 1 && Tab[i][j] <= 0)
				{
					return false;
				}
				else
				{
					if (Order == -1 && Tab[i][j] >= 0)
					{
					return false;
					}
				}
				//when there is another object valuable in List continue.
				if (IsTowValuableObject && (!IsObjectValaubleObjectSelf(i, j, Tab[i][j], ValuableSelfSupported)))
				{
					return false;
				}

				Order = Ord;
				//Ignore of Current
				if (Order == 1 && Tab[RowS][ColS] >= 0)
				{
					return false;
				}
				else
				{
					if (Order == -1 && Tab[RowS][ColS] <= 0)
					{
					return false;
					}
				}
				if (i == RowS && j == ColS)
				{
					return false;
				}
				//Enemy
				a = 1;
				Order = Ord;
				if (Order * -1 == -1)
				{
					a = -1;
				}
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tab[ik][jk] = TableS[ik][jk];
					}
				}
				InAttackedNotSelfSupported = false;
				SelfSupported = false;
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tab[ik][jk] = TableS[ik][jk];
					}
				}
				////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					if (Attack(Tab, RowS, ColS, i, j, a, Order * -1))
					{
						InAttackedNotSelfSupported = true;
						a = 1;
						if (Order == -1)
						{
							a = -1;
						}

						//For Self.
						for (int RowD = 0; RowD < 8; RowD++)
						{
							for (int ColD = 0; ColD < 8; ColD++)
							{
								//Ignore of Enemies
								if (Order == 1 && Tab[RowD][ColD] <= 0)
								{
									continue;
								}
								else
								{
									if (Order == -1 && Tab[RowD][ColD] >= 0)
									{
									continue;
									}
								}
								if (i == RowD && j == ColD)
								{
									continue;
								}
								a = 1;
								if (Order == -1)
								{
									a = -1;
								}
								for (int ik = 0; ik < 8; ik++)
								{
									for (int jk = 0; jk < 8; jk++)
									{
										Tab[ik][jk] = TableS[ik][jk];
									}
								}
								//When there is supporte and cuurent is less than enemy.
								//method return true when is not supporte and the enemy is less than cuurent in to be hitten.
								if (Support(Tab, RowD, ColD, i, j, a, Order) && (ObjectValueCalculator(Tab, i, j) <= ObjectValueCalculator(Tab, RowS, ColS)))
								{
									SelfSupported = true;
									S = S && true;
									break;

								}
							}
							//When a source enemy object attack a destination source object 
							//a source object is greater than another source object. Is = -1 Is another object valuable.
							//a source object is less than or equal  than another source object.Is = 1 Is not another object valuable.                                    
							if (SelfSupported)
							{
								break;
							}
						}
					}
				}
				if ((!SelfSupported && InAttackedNotSelfSupported))
				{
					S = false;
				}
			}
			Order = Ord;
			//When S is valid the any is not in [SelfNotSupported];Self is Supporeted.
			if (S)
			{
				return false;
			}
			return true;
		}
	}

	bool ThinkingChess::InAttackSelfThatNotSupportedCalculateValuableAll(int **TableS, int Order, int a, int ij, int ji, int ii, int jj, std::vector<int*> &ValuableSelfSupported)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Variables.
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			for (int ik = 0; ik < 8; ik++)
			{
				for (int jk = 0; jk < 8; jk++)
				{
					Tab[ik][jk] = TableS[ik][jk];
				}
			}
			int Ord = Order;
			bool SelfSupported = false;
			bool InAttackedNotSelfSupported = false;

			bool S = true;
			//int i = ii, j = jj;
			//For Self
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					S = true;
					//Ignore of Enemy
					if (Order == 1 && Tab[i][j] <= 0)
					{
						continue;
					}
					else
					{
						if (Order == -1 && Tab[i][j] >= 0)
						{
						continue;
						}
					}
					//For Enemy.
					for (int RowS = 0; RowS < 8; RowS++)
					{
						for (int ColS = 0; ColS < 8; ColS++)
						{
							//Ignore of Current
							if (Order == 1 && Tab[RowS][ColS] >= 0)
							{
								continue;
							}
							else
							{
								if (Order == -1 && Tab[RowS][ColS] <= 0)
								{
								continue;
								}
							}
							//Enemy
							a = 1;
							if (Order * -1 == -1)
							{
								a = -1;
							}
							for (int ik = 0; ik < 8; ik++)
							{
								for (int jk = 0; jk < 8; jk++)
								{
									Tab[ik][jk] = TableS[ik][jk];
								}
							}
							InAttackedNotSelfSupported = false;
							SelfSupported = false;
							S = true;
							//Wehn an Object of Enemy Attack Self Object
							////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{
								if (Attack(Tab, RowS, ColS, i, j, a, Order * -1))
								{
									InAttackedNotSelfSupported = true;
									a = 1;
									if (Order == -1)
									{
										a = -1;
									}

									//For Self.
									for (int RowD = 0; RowD < 8; RowD++)
									{
										for (int ColD = 0; ColD < 8; ColD++)
										{
											//Ignore of Enemies
											if (Order == 1 && Tab[RowD][ColD] <= 0)
											{
												continue;
											}
											else
											{
												if (Order == -1 && Tab[RowD][ColD] >= 0)
												{
												continue;
												}
											}
											a = 1;
											if (Order == -1)
											{
												a = -1;
											}
											for (int ik = 0; ik < 8; ik++)
											{
												for (int jk = 0; jk < 8; jk++)
												{
													Tab[ik][jk] = TableS[ik][jk];
												}
											}
											//When There is Supporter For Attacked Self Object and Is Greater than Attacking Object.
											if (Support(Tab, RowD, ColD, i, j, a, Order) && (ObjectValueCalculator(Tab, i, j) <= ObjectValueCalculator(Tab, RowS, ColS)))
											{
												SelfSupported = true;
												S = S && true;
												break;

											}
										}
										if (SelfSupported)
										{
											break;
										}
									}

									//When a source enemy object attack a destination source object 
									//a source object is greater than another source object. Is = -1 Is another object valuable.
									//a source object is less than or equal  than another source object.Is = 1 Is not another object valuable.                                        
								}
							}
							//When Attacked Current Object is not supported and there is another object valuable
							////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O2)
							{
								if ((!SelfSupported && InAttackedNotSelfSupported))
								{
									S = false;
									if (!S)
									{
										int Valuable[3];
										//First is Value;Second and Third is Row and Column.
										Valuable[0] = TableS[i][j];
										Valuable[1] = i;
										Valuable[2] = j;
										if (!ExistValuble(Valuable, ValuableSelfSupported))
										{
											ValuableSelfSupported.push_back(Valuable);
										}
										S = true;
									}
								}
							}
						}
					}
				}
			}
			Order = Ord;
			//When There is at last tow SelfNotSupporeted Object.
			if (ValuableSelfSupported.size() > 1)
			{
				return true;
			}
			return false;
		}
	}

	bool ThinkingChess::ExistValuble(int Table[], std::vector<int*> &ValuableSelfSupported)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;
			for (int i = 0; i < ValuableSelfSupported.size(); i++)
			{

				if (ValuableSelfSupported[i][0] == Table[0] && ValuableSelfSupported[i][1] == Table[1] && ValuableSelfSupported[i][2] == Table[2])
				{
					return true;
				}
			}
			return Is;
		}
	}

	bool ThinkingChess::MaxObjecvts(std::vector<int> &Obj, int Max)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool MaxO = true;
			if (Obj.size() > 0)
			{
				if (Max == 0)
				{
					return !MaxO;
				}
				if (Max > 0)
				{
					if (Obj[0] < 0)
					{
						return !MaxO;
					}
				}
				if (Max < 0)
				{
					if (Obj[0] > 0)
					{
						return !MaxO;
					}
				}
				for (int i = 0; i < Obj.size(); i++)
				{
					if (abs(Obj[i]) > abs(Max))
					{
						MaxO = true;
						return MaxO;
					}
					else
					{
						MaxO = false;
					}
				}
			}
			return MaxO;
		}
	}

	bool ThinkingChess::IsCurrentMoveTakeSupporte(int **Table, int Order, int a, int i, int j, int ii, int jj)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Variables.
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			for (int ik = 0; ik < 8; ik++)
			{
				for (int jk = 0; jk < 8; jk++)
				{
					Tab[ik][jk] = Table[ik][jk];
				}
			}
			bool SelfSupported = false;
			int Dum = ChessRules::CurrentOrder;
			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					//Ignore of Enemy Objects.
					if (Tab[RowS][ColS] <= 0 && Order == 1)
					{
						continue;
					}
					if (Tab[RowS][ColS] >= 0 && Order == -1)
					{
						continue;
					}
					a = 1;
					if (Order == -1)
					{
						a = -1;
					}


					//When there is Attacks.
					if (Support(Tab, RowS, ColS, ii, jj, a, Order))
					{
						SelfSupported = true;
					}
				}
			}
			return SelfSupported;
		}
	}

	double ThinkingChess::HeuristicKingSafety(int **Tab, int Order, int a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD)
	{
		/*Object O = new Object();
		////lock (O)
		{
		    double HeuristicKingSafe = 0;
		    double HA = 0;
	
		    //For Enemies.
	
		    ////Parallel.For(0, 8, RowS =>
		    //for (int RowS = 0; RowS < 8; RowS++)
		    {
		        ////Parallel.For(0, 8, ColS =>
		        //for (int ColS = 0; ColS < 8; ColS++)
		        {
		            if (Order == 1 && Tab[RowS, ColS] >= 0)
		                return 0;
		            if (Order == -1 && Tab[RowS, ColS] <= 0)
		                return 0;
		            ChessRules A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[RowS, ColS], Tab, Order * -1, RowS, ColS);
		            //For Current and Empty
		            ////Parallel.For(0, 8, RowD =>
		            //for (int RowD = 0; RowD < 8; RowD++)
		            {
		                ////Parallel.For(0, 8, ColD =>
		                //for (int ColD = 0; ColD < 8; ColD++)
		                {
		                    //Ignore of Enemy.
		                    if (Order == 1 && Tab[RowD, ColD] < 0)
		                        return 0;
		                    if (Order == -1 && Tab[RowD, ColD] > 0)
		                        return 0;
		                    int[,] Table = new int[8, 8];
		                    //Clone a Copy.
		                    for (int ij = 0; ij < 8; ij++)
		                    {
		                        for (int ji = 0; ji < 8; ji++)
		                        {
		                            Object O2 = new Object();
		                            //lock (O2)
		                            {
		                                Table[ij, ji] = Tab[ij, ji];
		                            }
		                        }
		                    }
		                    int AA = int.Gray;
		                    if (Order * -1 == -1)
		                        AA = int.Brown;
		                    //When Enemy can Move
		                    Object O1 = new Object();
		                    //lock (O1)
		                    {
		                        if (A.Rules(RowS, ColS, RowD, ColD, AA, Table[RowS, ColS]))
		                        {
		                            //Take Movment.
		                            Table[RowD, ColD] = Table[RowS, ColS];
		                            Table[RowS, ColS] = 0;
		                            //Is Dangrous for King.
		                            A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[RowD, ColD], Table, Order * -1, RowD, ColD);
		                            //if (A.ObjectDangourKingMove(Order, Table, false))
		                            A.ObjectDangourKingMove(Order, Table, false);
		                            {
		                               for (int ij = 0; ij < 8; ij++)
		                                {
		                                    for (int ji = 0; ji < 8; ji++)
		                                    {
		                                        Object O2 = new Object();
		                                        //lock (O2)
		                                        {
		                                            Table[ij, ji] = Tab[ij, ji];
		                                        }
		                                    }
		                                }
		                                Object ol = new Object();
		                                //lock (ol)
		                                {
		                                    //When Before Move such situation is observed calculate huristic count.
		                                    if (Order == 1 && A.CheckGrayObjectDangour)
		                                        HA +=// AllDraw.SignKingSafe * 
		                                            (ObjectValueCalculator(Table, RowS, ColS, RowD, ColD));
		                                    else
		                                    if (Order == -1 && A.CheckBrownObjectDangour)
		                                        HA += //AllDraw.SignKingSafe * 
		                                            (ObjectValueCalculator(Table, RowS, ColS, RowD, ColD));
	
		                                }               
		                            }
		                        }
		                    }
		                }//);
		            }//);
		        }//);
		    }//);
		    //For Enemy and Self Sign.
		    HeuristicKingSafe += (HA * 1);
		    return HeuristicKingSafe;
		}*/
		int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];

		for (int ij = 0; ij < 8; ij++)
		{
			for (int ji = 0; ji < 8; ji++)
			{
				////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					Table[ij][ji] = Tab[ij][ji];
				}
			}
		}
		double HA = 0;
		ChessRules *A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[RowD][ColD], Table, Order * -1, RowD, ColD);
		//if (A.ObjectDangourKingMove(Order, Table, false))
		A->ObjectDangourKingMove(Order, Table);
		{
			for (int ij = 0; ij < 8; ij++)
			{
				for (int ji = 0; ji < 8; ji++)
				{
					////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O2)
					{
						Table[ij][ji] = Tab[ij][ji];
					}
				}
			}
			////auto ol = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (ol)
			{
				//When Before Move such situation is observed calculate huristic count.
				if (Order == 1 && A->CheckGrayObjectDangour)
				{
					HA += (AllDraw::SignKingSafe * (ObjectValueCalculator(Table, RowS, ColS, RowD, ColD)));
				}
				else
				{
				if (Order == -1 && A->CheckBrownObjectDangour)
				{
					HA += (AllDraw::SignKingSafe * (ObjectValueCalculator(Table, RowS, ColS, RowD, ColD)));
				}
				}

			}
		}
		return HA;
	}

	double ThinkingChess::HeuristicKingDangourous(int **Tab, int Order, int a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD)
	{
			/*Object O = new Object();
			////lock (O)
			{
			    double HeuristicKingDangour = 0;
			    double HA = 0;
			    //For Self.
			    //for (int RowS = 0; RowS < 8; RowS++)
			    ////Parallel.For(0, 8, RowS =>
			    {
			        ////Parallel.For(0, 8, ColS =>
			        //for (int ColS = 0; ColS < 8; ColS++)
			        {
			            //Ignore of Enemy and Empty.
			            if (Order == 1 && Tab[RowS, ColS] <= 0)
			                return 0;
			            if (Order == -1 && Tab[RowS, ColS] >= 0)
			                return 0;
			            ChessRules A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[RowS, ColS], Tab, Order, RowS, ColS);
			            //For Enemy and Empty.
			            ////Parallel.For(0, 8, RowD =>
			            //for (int RowD = 0; RowD < 8; RowD++)
			            {
			                ////Parallel.For(0, 8, ColD =>
			                //for (int ColD = 0; ColD < 8; ColD++)
			                {
			                    //Ignore of Self.
			                    if (Order == 1 && Tab[RowD, ColD] > 0)
			                        return 0;
			                    if (Order == -1 && Tab[RowD, ColD] < 0)
			                        return 0;
			                    int[,] Table = new int[8, 8];
			                    //Clone a Copy.
			                    for (int ij = 0; ij < 8; ij++)
			                    {
			                        for (int ji = 0; ji < 8; ji++)
			                        {
			                            Object O2 = new Object();
			                            //lock (O2)
			                            {
			                                Table[ij, ji] = Tab[ij, ji];
			                            }
			                        }
			                    }
			                    int AA = int.Gray;
			                    if (Order == -1)
			                        AA = int.Brown;
			                    //When Self Move
			                    if (A.Rules(RowS, ColS, RowD, ColD, AA, Table[RowS, ColS]))
			                    {
			                        //Take Mo0vment
			                        Object O2 = new Object();
			                        //lock (O2)
			                        {
			                            Table[RowD, ColD] = Table[RowS, ColS];
			                            Table[RowS, ColS] = 0;
			                        }
			                        //The Move is Dqangrous.
			                        Object O3 = new Object();
			                        //lock (O3)
			                        {
			                            //if (A.ObjectDangourKingMove(Order, Table, false))
			                            A.ObjectDangourKingMove(Order, Table, false);
			                            {
			                                int[,] Table1 = new int[8, 8];
			                                //Clone a Copy.
	
			                                for (int ij = 0; ij < 8; ij++)
			                                {
			                                    for (int ji = 0; ji < 8; ji++)
			                                    {
			                                        Object OO2 = new Object();
			                                        //lock (OO2)
			                                        {
			                                            Table[ij, ji] = Tab[ij, ji];
			                                        }
			                                    }
			                                }
			                                //When Situation Observed Take Situation calcualte Huristic.
			                                Object O4 = new Object();
			                                //lock (O4)
			                                {
			                                    if (Order == -1 && A.CheckGrayObjectDangour)
			                                        HA += AllDraw.SignKingDangour * (ObjectValueCalculator(Table1,RowS,ColS,RowD,ColD));
			                                    else
			                                        if (Order == 1 && A.CheckBrownObjectDangour)
			                                        HA += AllDraw.SignKingDangour * (ObjectValueCalculator(Table1,RowS,ColS,RowD,ColD));
	
	
			                                }
	
			                            }
			                        }
			                    }
			                }//);
			            }//);
			        }//);
			    }//);
			    //For Order Sign.
			    HeuristicKingDangour += HA * 1;
			    return HeuristicKingDangour;
			}*/
int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];

			for (int ij = 0; ij < 8; ij++)
			{
				for (int ji = 0; ji < 8; ji++)
				{
					////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O2)
					{
						Table[ij][ji] = Tab[ij][ji];
					}
				}
			}
			ChessRules *A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[RowS][ColS], Tab, Order, RowS, ColS);

			double HA = 0;
			////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O3)
			{
				//if (A.ObjectDangourKingMove(Order, Table, false))
				A->ObjectDangourKingMove(Order, Table);
				{
					int **Table1 = new int*[8]; for (int g = 0; g < 8; g++)Table1[g] = new int[8];
					//Clone a Copy.

					//When Situation Observed Take Situation calcualte Huristic.
					////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O4)
					{
						if (Order == -1 && A->CheckGrayObjectDangour)
						{
							HA += (ObjectValueCalculator(Table1, RowS, ColS, RowD, ColD)); // AllDraw.SignKingDangour *
						}
						else
						{
							if (Order == 1 && A->CheckBrownObjectDangour)
							{
							HA += (ObjectValueCalculator(Table1, RowS, ColS, RowD, ColD)); // AllDraw.SignKingDangour *
							}
						}


					}

				}
			}
		return HA;
	}

	double ThinkingChess::HuristicSelfSupported(int **Tab, int Ord, int aa, int RowS, int ColS, int RowD, int ColD)
	{
	////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
	////lock (O)
	{
		double HuristicSelfSupportedValue = 0;
		//Initiate Local Vrariables.
		double HA = 0;
		int DumOrder = Order;
		int DummyOrder = Order;
		int DummyCurrentOrder = ChessRules::CurrentOrder;

		//If There is Not AStarGreedy Huristic Boolean Value.

			if (!AStarGreedyHuristicT)
			{
				//int RowS = RowSS, ColS = ColSS;
				//For All Self
				//for (int RowD = 0; RowD < 8; RowD++)
				{
					{
					//for (int ColD = 0; ColD < 8; ColD++)

						//For Current Object Lcation.
						int Order = int();
						Order = DumOrder;
						int a = int();
						a = aa;

						//Ignore Current Unnessery Home.
						if (RowS == RowD && ColS == ColD)
						{
							return 0;
						}
						//Default Is Gray One.
						double Sign = 1;
						Order = DummyOrder;
						///When Supporte is true. means [RowD,ColD] Supportes [RowS,ColS].
						///What is Supporte!
						///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
						//if (Order == 1 && Tab[RowD, ColD] <= 0)
						//continue;
						//if (Order == -1 && Tab[RowD, ColD] >= 0)
						//continue;
						//if (!Scop(RowS, ColS, RowD, ColD, System.Math.Abs(Tab[RowS, ColS])))
						//continue;
						if (Tab[RowD][ColD] < 0 && DummyOrder == -1 && Tab[RowS][ColS] <= 0)
						{
							Order = -1;
							////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{
								Sign = 1 * AllDraw::SignSupport;
								ChessRules::CurrentOrder = -1;
							}
							a = -1;
						}
						else if (Tab[RowD][ColD] > 0 && DummyOrder == 1 && Tab[RowS][ColS] > 0)
						{
							Order = 1;
							////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{
								Sign = 1 * AllDraw::SignSupport;
								ChessRules::CurrentOrder = 1;
							}
							a = 1;
						}
						else
						{
							return HuristicSelfSupportedValue;
						}
						//For Support Movments.
						if (Support(Tab, RowS, ColS, RowD, ColD, a, Order))
						{
							//Calculate Local Support Huristic.
							HA += (Sign * (abs((ObjectValueCalculator(Tab, RowS, ColS, RowD, ColD)))));
						   /* int Supported = new int();
						    int SupportedE = new int();
						    Supported = 0;
						    SupportedE = 0;
						    //For All Self Obejcts.                                             
						    ////Parallel.For(0, 8, g =>
						    for (int g = 0; g < 8; g++)
						    {
						        //if (Supported)
						        //return;
						        ////Parallel.For(0, 8, h =>
						        for (int h = 0; h < 8; h++)
						        {
						            Object O2 = new Object();
						            //lock (O2)
						            {
						                //if (Supported)
						                //return;
						                //Ignore Of Enemy Objects.
						                if (Order == 1 && Tab[g, h] == 0)
						                    continue;
						                if (Order == -1 && Tab[g, h] == 0)
						                    continue;
						                if (!Scop(g, h, RowS, ColS, System.Math.Abs(Tab[g, h])))
						                    continue;
	
						                int aaa = new int();
						                //Assgin Enemy ints.
						                aaa = int.Gray;
						                aa = int.Gray;
	
						                if (Order == -1)
						                    aaa = int.Brown;
						                else
						                    aaa = int.Gray;
						                if (Order * -1 == -1)
						                    aa = int.Brown;
						                else
						                    aa = int.Gray;
						                //When Enemy is Supported.
						                bool A = new bool();
						                bool B = new bool();
						                A = Support(Tab, g, h, RowS, ColS, aaa, Order);
						                B = Attack(Tab, g, h, RowS, ColS, aa, Order * -1);
						                //When Enemy is Supported.
						                if (A)
						                {
						                    //Assgine variable.
						                    Supported++;
						                    //return;
	
						                }
						                if (B)
						                {
						                    //Assgine variable.
						                    SupportedE++;
						                    //return;
	
						                }
						            }
						        }//);
	
						        // if (Supported)
						        //   return;
						    }//);
	
						    Object O1 = new Object();
						    //lock (O1)
						    {
						        if (Supported != 0)
						            //When is Not Supported multyply 100.
						            HA *= System.Math.Pow(2, Supported);
						        else
						            if (SupportedE != 0)
						            //When is Supported Multyply -100.
						            HA *= (-1 * System.Math.Pow(2, SupportedE));
						    }*/

						}
					}
				}
			}

			//For All Homes Table.
			else
			{
				{
				//for (int RowS = 0; RowS < 8; RowS++)
					//for (int ColS = 0; ColS < 8; ColS++)
					{
						{
						//for (int RowD = 0; RowD < 8; RowD++)
							//for (int ColD = 0; ColD < 8; ColD++)
							{
								int Order = int();
								int a = int();
								a = aa;
								{
									//Ignore Current Home.
									if (RowS == RowD && ColS == ColD)
									{
										return 0;
									}
									//Initiate Local Variables.
									double Sign = 1;
									Order = DummyOrder;
									///When Supporte is true. means [RowD,ColD] is in SelfSupported.by [RowS,ColS].
									///What is Supporte!
									///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
									//if (!Scop(RowS, ColS, RowD, ColD, System.Math.Abs(Tab[RowS, ColS])))
									//  continue;
									if (Tab[RowD][ColD] < 0 && DummyOrder == -1 && Tab[RowS][ColS] <= 0)
									{
										Order = -1;
										////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O2)
										{
											Sign = 1 * AllDraw::SignSupport;
											ChessRules::CurrentOrder = -1;
											a = -1;
										}
									}
									else if (Tab[RowD][ColD] > 0 && DummyOrder == 1 && Tab[RowS][ColS] > 0)
									{
										Order = 1;
										////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
										//lock (O2)
										{
											Sign = 1 * AllDraw::SignSupport;
											ChessRules::CurrentOrder = 1;
											a = 1;
										}
									}
									else
									{
										return HuristicSelfSupportedValue;
									}
									//For Support Movments.
									if (Support(Tab, RowS, ColS, RowD, ColD, a, Order))
									{
										//Calculate Local Support Huristic.
										HA += (Sign * (abs((ObjectValueCalculator(Tab, RowS, ColS, RowD, ColD)))));
									 /*   int Supported = new int();
									    int SupportedE = new int();
									    Supported = 0;
									    SupportedE = 0;
									    //For All Self Obejcts.                                             
									    ////Parallel.For(0, 8, g =>
									    for (int g = 0; g < 8; g++)
									    {
									        //if (Supported)
									        //return;
									        ////Parallel.For(0, 8, h =>
									        for (int h = 0; h < 8; h++)
									        {
									            Object O2 = new Object();
									            //lock (O2)
									            {
									                //if (Supported)
									                //return;
									                //Ignore Of Enemy Objects.
									                if (Order == 1 && Tab[g, h] == 0)
									                    continue;
									                if (Order == -1 && Tab[g, h] == 0)
									                    continue;
									                if (!Scop(g, h, RowS, ColS, System.Math.Abs(Tab[g, h])))
									                    continue;
	
									                int aaa = new int();
									                //Assgin Enemy ints.
									                aaa = int.Gray;
									                aa = int.Gray;
	
									                if (Order == -1)
									                    aaa = int.Brown;
									                else
									                    aaa = int.Gray;
									                if (Order * -1 == -1)
									                    aa = int.Brown;
									                else
									                    aa = int.Gray;
									                //When Enemy is Supported.
									                bool A = new bool();
									                bool B = new bool();
									                A = Support(Tab, g, h, RowS, ColS, aaa, Order);
									                B = Attack(Tab, g, h, RowS, ColS, aa, Order * -1);
									                //When Enemy is Supported.
									                if (A)
									                {
									                    //Assgine variable.
									                    Supported++;
									                    //return;
	
									                }
									                if (B)
									                {
									                    //Assgine variable.
									                    SupportedE++;
									                    //return;
	
									                }
									            }
									        }//);
	
									        // if (Supported)
									        //   return;
									    }//);
	
									    Object O1 = new Object();
									    //lock (O1)
									    {
									        if (Supported != 0)
									            //When is Not Supported multyply 100.
									            HA *= System.Math.Pow(2, Supported);
									        else
									            if (SupportedE != 0)
									            //When is Supported Multyply -100.
									            HA *= (-1 * System.Math.Pow(2, SupportedE));
									   }*/

									}
								}
							}
						}
					}
				}
			}

		//Reassignments of Global Orders with Local Begining One.
		Order = DummyOrder;
		ChessRules::CurrentOrder = DummyCurrentOrder;
		Order = DumOrder;
		return HA * 1;
	}
	} ///Identification of Equality

	bool ThinkingChess::TableEqual(int **Tab1, int **Tab2)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

				//For All Home
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						//When there is different values in same location of tow Table return non equality.
						if (Tab1[i][j] != Tab2[i][j])
						{
							return false;
						}
					}
				}
				//Else return equlity.
				return true;

		}
	}

	bool ThinkingChess::TableEqual(int Tab1, int Tab2)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

				//When there is different values in same location of tow Table return non equality.
				if (Tab1 != Tab2)
				{
					return false;
				}
				//Else return equlity.
				return true;

		}
	}

	bool ThinkingChess::ExistTableInList(int **Tab, std::vector<int**> List, int Index)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Local Variables.
			bool Exist = false;
			//For All Tables of Table List.
			for (int i = Index; i < List.size(); i++)
			{
				//Strore Equality Value.
				bool Eq = TableEqual(Tab, List[i]);
				//When is Equality is Occurred.
				if (Eq)
				{
					//Store Equality Local Value in a Global static value.
					AllDraw::LoopHuristicIndex = i;
					return Eq;
				}
				Exist |= Eq;
			}
			//return Equality Local value of all lists.
			return Exist;
		}
	}

	bool ThinkingChess::Movable(int **Tab, int i, int j, int ii, int jj, int a, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
			for (int p = 0; p < 8; p++)
			{
				for (int k = 0; k < 8; k++)
				{
					Table[p][k] = Tab[p][k];
				}
			}
			//Initiate Local Variables.
			int Store = Table[ii][jj];
			ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[i][j], Table, Order, i, j);
			///Table[ii, jj] = 0;
			//Menen Parameter is Moveble to Second Parameters Location returm Movable.
			if (A->Rules(i, j, ii, jj, a, Order))
			{
				//Initiate Movments.
				Table[ii][jj] = Table[i][j];
				Table[i][j] = 0;
				//Default Order Assignments.
				int Ord = 1;
				//Brown Order Consideration.
				if (Table[ii][jj] < 0)
				{
					Ord = -1;
				}
				//Store of Local Order Assignments in Global Assignments.
				int DummyOrder = Order;
				int DummyCurrentOrder = ChessRules::CurrentOrder;
				//Consider Global Check Variables.
				ChessRules AA =  ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[ii][jj], Table, Ord, ii, jj);
				AA.Check(Table, Ord);
				//Reaasignment of Premitive Variables.
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
				//Reassignments of Table Content and Consider CheckMate Specific Order.
				Table[i][j] = Table[ii][jj];
				//When Gray.
				if (Table[i][j] > 0)
				{
					//And CheckedMated is Occured for gray. return false.
					Table[ii][jj] = Store;
					if (AA.CheckMateGray)
					{
						return false;
					}


					return true;
				}

				//When Brown.
				if (Table[i][j] < 0)
				{
					Table[ii][jj] = Store;
					//When CheckedMated occured for Brown return false.
					if (AA.CheckMateBrown)
					{
						return false;
					}
					return true;
				}
			}
			Table[ii][jj] = Store;
			return false;
		}
	}

	double ThinkingChess::SignOrderToPlate(int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double Sign = 1.0;
			//When Current Order Sign Positive.
			if (Order == AllDraw::OrderPlate)
			{
				Sign = 1.0;
			}
			else
			{
				//When Order is Opposite Sign Negative.
				if (Order != AllDraw::OrderPlate)
				{
				Sign = -1.0;
				}
			}

			return Sign;
		}

	}

	bool ThinkingChess::RemovePenalty(int **Tab, int Order, int i, int j)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Remove = false;
			//Create Objects.
			ChessRules AA =  ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[i][j], Tab, Order, i, j);
			//When is Check.
			if (AA.Check(Tab, Order))
			{
				//When there is Current Checked or Objects Danger return false.
				if (Order == 1 && (AA.CheckGray || AA.CheckGrayObjectDangour))
				{
					return Remove;
				}
				if (Order == -1 && (AA.CheckBrown || AA.CheckBrownObjectDangour))
				{
					return Remove;
				}
			}



			//For Enemy.
			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					if (Order == 1 && Tab[ii][jj] >= 0)
					{
						continue;
					}
					if (Order == -1 && Tab[ii][jj] <= 0)
					{
						continue;
					}
					//Clone a Copy.
					int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
					//Clone a Table.
					for (int RowS = 0; RowS < 8; RowS++)
					{
						for (int ColS = 0; ColS < 8; ColS++)
						{
							Table[RowS][ColS] = Tab[RowS][ColS];
						}
					}
					ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[ii][jj], Table, Order * -1, ii, jj);
					int a = 1;
					if (Order * -1 == -1)
					{
						a = -1;
					}
					//When there is movment to current OPbject.
					if (A->Rules(ii, jj, i, j, a, Table[ii][jj]))
					{
						//Number of Attacks and take move.
						int Count = AttackerCount(Table, Order * -1, a, ii, jj);
						//When there is Object Danger.
						//Clone a Copy.
						for (int RowS = 0; RowS < 8; RowS++)
						{
							for (int ColS = 0; ColS < 8; ColS++)
							{
								Table[RowS][ColS] = Tab[RowS][ColS];
							}
						}
						//Create New Chess Rule Object.
						A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[ii][jj], Table, Order, ii, jj);
						//Detect int.
						a = 1;
						if (Order == -1)
						{
							a = -1;
						}
						//When Current Movments Attacks Enemy.
						if (Attack(Table, i, j, ii, jj, a, Order))
						{
							//For Current Home.
							for (int RowS = 0; RowS < 8; RowS++)
							{
								for (int ColS = 0; ColS < 8; ColS++)
								{
									//Ignore of Enemy.
									if (Order == 1 && Tab[RowS][ColS] <= 0)
									{
										continue;
									}
									if (Order == -1 && Tab[RowS][ColS] >= 0)
									{
										continue;
									}
									//Whn Value Of Current is Less That Enemy.
									if (ObjectValueCalculator(Table, i, j) < ObjectValueCalculator(Table, ii, jj))
									{
										//Take Move.
										Table[ii][jj] = Table[i][j];
										Table[i][j] = 0;
										a = 1;
										if (Order * -1 == -1)
										{
											a = -1;
										}
										//When Enemy Attacks Current Moved.
										if (!Attack(Table, RowS, ColS, ii, jj, a, Order * -1))
										{
											//For Current Order.
											for (int RowD = 0; RowD < 8; RowD++)
											{
												for (int ColD = 0; ColD < 8; ColD++)
												{
													//Ignore of Enemy.
													if (Order == 1 && Tab[RowD][ColD] <= 0)
													{
														continue;
													}
													if (Order == -1 && Tab[RowD][ColD] >= 0)
													{
														continue;
													}
													a = 1;
													if (Order == -1)
													{
														a = -1;
													}
													//When Self Supported Current
													if (Support(Table, RowD, ColD, i, j, a, Order))
													{
														//If V alue of Enemy is Greater Than Current and Value of Enemy is Greater than Supporter.
														if (ObjectValueCalculator(Table, RowS, ColS) < ObjectValueCalculator(Table, ii, jj) && ObjectValueCalculator(Table, RowS, ColS) > ObjectValueCalculator(Table, Row, ColS))
														{
															Remove = true;
															return Remove;
														}
														else
														{
															return Remove;
														}
													}
													else
													{
														return Remove;
													}
												}
											}
										}
										else
										{
											return Remove;
										}

									}
									else
									{
										return Remove;
									}
								}
							}
						}
					}
				}
			}
			return Remove;
		}
	}

	bool ThinkingChess::IsCurrentStateIsDangreousForCurrentOrder(int **Tabl, int Order, int a, int ii, int jj)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Initiate Object.
			ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 1, Tabl, 1, Row, Column);
			//Gray Order.
			if (Order == 1)
			{
				//Find location of Gray King.
				int RowG = -1, ColumnG = -1;
				A->FindGrayKing(Tabl, RowG, ColumnG);
				//When found.
				if (RowG != -1 && ColumnG != -1)
				{
					//For Brown
					for (int i = 0; i < 8; i++)
					{
						for (int j = 0; j < 8; j++)
						{
							//Ignore of Gray and Empty
							if (Tabl[i][j] >= 0)
							{
								continue;
							}

							if (i != ii && j != jj)
							{
								//Create new Objects of Table
								int **TablCon = new int*[8]; for (int g = 0; g < 8; g++)TablCon[g] = new int[8];
								for (int RowS = 0; RowS < 8; RowS++)
								{
									for (int ColS = 0; ColS < 8; ColS++)
									{
										TablCon[RowS][ColS] = Tabl[RowS][ColS];
									}
								}
								//For Enemy Order.
								if (TablCon[i][j] < 0)
								{
									//For Gray and Empty Objects.
									if (TablCon[ii][jj] >= 0)
									{
										//Setting Enemy Order.
										int DummyOrder = Order;
										int DummyCurrentOrder = ChessRules::CurrentOrder;
										A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TablCon[i][j], TablCon, -1, i, j);
										//When Enemy is Attacked Gray Objects.
										if (A->Rules(i, j, ii, jj, -1, TablCon[i][j]))
										{
											//Take Movments.
											TablCon[ii][jj] = TablCon[i][j];
											TablCon[i][j] = 0;
											//Settting Current Order.
											ChessRules::CurrentOrder = 1;
											//Settting Object.
											A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TablCon[ii][jj], TablCon, 1, ii, jj);
											//When Occured Check.
											if (A->Check(TablCon, 1))
											{
												//When Gray is Check.
												if (A->CheckGray)
												{
													//For Enemy Order Objects.
													for (int RowD = 0; RowD < 8; RowD++)
													{
														for (int ColD = 0; ColD < 8; ColD++)
														{
															//When is not Conflict.
															if (RowD != i && ColD != j && RowD != ii && ColD != jj)
															{
																//Setting Enemy.
																ChessRules::CurrentOrder = -1;
																//When Enemy is Supported 
																if (Support(TablCon, RowD, ColD, i, j, -1, -1))
																{
																	//restore and return true.
																	Order = DummyOrder;
																	ChessRules::CurrentOrder = DummyCurrentOrder;
																	return true;
																}
															}
														}
													}
												}
												Order = DummyOrder;
												ChessRules::CurrentOrder = DummyCurrentOrder;

											}
										}

									}
								}
							}
						}
					}
				}
			}
			//For Brown Order.
			else if (Order == -1)
			{
				//Found of Brown King.
				int RowB = -1, ColumnB = -1;
				A->FindBrownKing(Tabl, RowB, ColumnB);
				//When found.
				if (RowB != -1 && ColumnB != -1)
				{
					//For Gray.
					for (int i = 0; i < 8; i++)
					{
						for (int j = 0; j < 8; j++)
						{
							if (Tabl[i][j] <= 0)
							{
								continue;
							}

							if (i != ii && j != jj)
							{
								//Create new Objects of Table
								int **TablCon = new int*[8]; for (int g = 0; g < 8; g++)TablCon[g] = new int[8];
								for (int RowS = 0; RowS < 8; RowS++)
								{
									for (int ColS = 0; ColS < 8; ColS++)
									{
										TablCon[RowS][ColS] = Tabl[RowS][ColS];
									}
								}
								//For Enemy Objects.
								if (TablCon[i][j] > 0)
								{
									//For Self Objects and Empty.
									if (TablCon[ii][jj] <= 0)
									{
										//Store and Enemy Order.
										int DummyOrder = Order;
										int DummyCurrentOrder = ChessRules::CurrentOrder;
										A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TablCon[i][j], TablCon, 1, i, j);
										ChessRules::CurrentOrder = 1;
										//When Enemy Attacked Self Objects.
										if (A->Rules(i, j, ii, jj, 1, TablCon[i][j]))
										{
											//Take movemnts.
											TablCon[ii][jj] = TablCon[i][j];
											TablCon[i][j] = 0;
											//Setting current Order.
											ChessRules::CurrentOrder = -1;
											A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TablCon[ii][jj], TablCon, -1, ii, jj);
											//When Check Occured.
											if (A->Check(TablCon, -1))
											{
												//When Current is Check.
												if (A->CheckBrown)
												{
													//For Enemy Objecvts.
													for (int RowD = 0; RowD < 8; RowD++)
													{
														for (int ColD = 0; ColD < 8; ColD++)
														{
															//Ignore of Conflit.
															if (RowD != i && ColD != j && RowD != ii && ColD != jj)
															{
																//Setting Enemy Order
																ChessRules::CurrentOrder = 1;
																//When Enemy is Supported.
																if (Support(TablCon, RowD, ColD, i, j, 1, 1))
																{
																	//restore and return true.
																	Order = DummyOrder;
																	ChessRules::CurrentOrder = DummyCurrentOrder;
																	return true;
																}
															}
														}
													}
												}
												//restore.
												Order = DummyOrder;
												ChessRules::CurrentOrder = DummyCurrentOrder;
											}
										}

									}
								}
							}

						}
					}
				}
			}
			//return false.
			return false;
		}
	}

	int *ThinkingChess::IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(int Order, int **Tabl, int ik, int jk, int iki, int jki, int OrderPalte, int OrderPalteMulMinuse, int Depth, bool KindCheckedSelf)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Is[4];
			////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O3)
			{
				Is[0] = 0;
				Is[1] = 0;
				Is[2] = 0;
				Is[3] = 0;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab2 = CloneATable(Tabl);
				int **Tab2 = CloneATable(Tabl);
				ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab2[ik][jk], Tab2, Order * -1, ik, jk);
				if (Order * -1 == 1)
				{
					color = 1;
				}
				else
				{
					color = -1;
				}
				//When Enemy Attack Currnet.
				if (A->Rules(ik, jk, iki, jki, color, Tab2[ik][jk]))
				{
					Tab2[iki][jki] = Tab2[ik][jk];
					Tab2[ik][jk] = 0;
					A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab2[iki][jki], Tab2, Order * -1, iki, jki);
					//When Current Always is in CheckedMate.
					if (A->CheckMate(Tab2, Order * -1))
					{
						//When Order is Gray.
						if (OrderPalte == 1)
						{
							if (A->CheckMateGray)
							{
								Is[0] = 1;
								if (KindCheckedSelf)
								{
									Is[1] = Depth;
								}

							}
							else
							{
								//if (A.CheckMateBrown)
								//return Is;
							}
						}
						//When Order is Brown.
						else
						{
						   if (OrderPalte == -1)
						   {
							if (A->CheckMateBrown)
							{
								Is[0] = 1;
								Is[1] = Depth;
							}
							else
							{
								//if (A.CheckMateGray)
								//return Is;
							}
						   }
						}


						//When Order * -1 is Gray
						if (OrderPalteMulMinuse == 1)
						{
							if (A->CheckMateGray)
							{
								Is[2] = 1;
								Is[3] = Depth;
							}
							else
							{
								//if (A.CheckMateBrown)
								//return Is;
							}
						}
						//When Order * -1 is Brown
						else
						{
						   if (OrderPalteMulMinuse == -1)
						   {
							if (A->CheckMateBrown)
							{
								Is[2] = 1;
								Is[3] = Depth;
							}
							else
							{
								//if (A.CheckMateGray)
								//return Is;
							}
						   }
						}


					}

					if (Order * -1 == 1)
					{
						color = 1;
					}
					else
					{
						color = -1;
					}
					//if (Tab2[iki, jki] == 0)
					//return Is;
					//For Movements.
					int Ord = Order * -1;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tab2);
					int **Tab = CloneATable(Tab2);
					int a = color;
					if (Ord == 1)
					{
						a = 1;
					}
					else
					{
						a = -1;
					}
					int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMulMinuse, Depth1 = Depth + 1;
					bool KindCheckedSelf1 = KindCheckedSelf;
					////auto O1 = new Object();
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
					int *IS = nullptr;
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovment(Tab, Ord, a, Depth1, OrderP, OrderM, KindCheckedSelf1);
					}
					if (IS[0] == 1)
					{
						Is[0] = 1;
					}
					if (IS[2] == 1)
					{
						Is[2] = 1;
					}

					Is[1] = IS[1];
					Is[3] = IS[3];
				}
			}
			return Is;
		}
	}

	bool ThinkingChess::IsNextMovmentIsCheckOrCheckMateForCurrentMovmentOnCurrentMovemnet(int Order, int **Tabl, int ik, int jk, int iki, int jki, int OrderPalte)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;
			int **Tab2 = new int*[8]; for (int g = 0; g < 8; g++)Tab2[g] = new int[8];
			for (int ki = 0; ki < 8; ki++)
			{
				for (int kj = 0; kj < 8; kj++)
				{
					Tab2[ki][kj] = Tabl[ki][kj];
				}
			}
			ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab2[ik][jk], Tab2, Order - 1, ik, jk);
			//When Enemy Attack Currnet.
			A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab2[iki][jki], Tab2, OrderPalte, iki, jki);
			//When Current Always is in CheckedMate.
			if (A->CheckMate(Tab2, OrderPalte))
			{
				//When for penalty.
				if (OrderPalte == AllDraw::OrderPlate)
				{
					//When Order is Gray.
					if (OrderPalte == 1)
					{
						if (A->CheckMateGray)
						{
							Is = true;
						}
						else
						{
							if (A->CheckMateBrown)
							{
								return Is;
							}
						}
					}
					//When Order is Brown.
					else
					{
					   if (OrderPalte == -1)
					   {
						if (A->CheckMateBrown)
						{
							Is = true;
						}
						else
						{
							if (A->CheckMateGray)
							{
								return Is;
							}
						}
					   }
					}

				}
				//When for regard.
				else
				{
					//When Order * -1 is Gray
					if (OrderPalte == 1)
					{
						if (A->CheckMateGray)
						{
							Is = true;
						}
						else
						{
							if (A->CheckMateBrown)
							{
								return Is;
							}
						}
					}
					//When Order * -1 is Brown
					else
					{
					   if (OrderPalte == -1)
					   {
						if (A->CheckMateBrown)
						{
							Is = true;
						}
						else
						{
							if (A->CheckMateGray)
							{
								return Is;
							}
						}
					   }
					}
				}
			}
			return Is;
		}
	}

	int *ThinkingChess::IsNextMovmentIsCheckOrCheckMateForCurrentMovment(int **Tabl, int Order, int a, int Depth, int OrderPalte, int OrderPalteMinusPluse, bool KindCheckedSelf)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Is[4];
			////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O3)
			{
				Is[0] = 0;
				Is[1] = 0;
				Is[2] = 0;
				Is[3] = 0;
				int DummyOrder = Order;
				int DummyCurrentOrder = ChessRules::CurrentOrder;
				if (Depth >= AllDraw::MaxAStarGreedy)
				{
					return Is;
				}
				//For All Enemies.
				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					////Parallel.For(0, 8, ik =>
					////Parallel.For(0, 8, jk =>
					{
						//Ignore of Current
						if (Order == 1 && Tabl[ik][jk] >= 0)
						{
							continue;
						}
						if (Order == -1 && Tabl[ik][jk] <= 0)
						{
							continue;
						}
						if (abs(Tabl[ik][jk]) == 1)
						{
							//For Current Home
							for (int iki = ik - 2; iki < ik + 3; iki++)
							{
								for (int jki = jk - 2; jki < jk + 3; jki++)

								////Parallel.For(ik - 2, ik + 3, iki =>
								////Parallel.For(jk - 2, jk + 3, jki =>
								// init subtotal
								{
									if (!Scop(ik, jk, iki, jki, 1))
									{
										continue;
									}
									//Ignore of Enemy
									if (Order == 1 && Tabl[iki][jki] < 0)
									{
										continue;
									}
									if (Order == -1 && Tabl[iki][jki] > 0)
									{
										continue;
									}
									if (Is[0] == 1)
									{
										continue;
									}
									int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
									int **Tab = CloneATable(Tabl);
									int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
									bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
									int *IS = nullptr;
									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
										if (IS[0] == 1)
										{
											Is[0] = 1;
										}
										if (IS[2] == 1)
										{
											Is[2] = 1;
										}
										Is[1] = IS[1];
										Is[3] = IS[3];
									}

								}
							}
							//));
						}
						else
						{
						if (abs(Tabl[ik][jk]) == 2)
						{

							//For Current Home
							////Parallel.For(0, 8, iki =>
							for (int iki = 0; iki < 8; iki++)
							{
								int jki = iki + jk - ik;
								if (!Scop(ik, jk, iki, jki, 2))
								{
									continue;
								}
								//Ignore of Enemy
								if (Order == 1 && Tabl[iki][jki] < 0)
								{
									continue;
								}
								if (Order == -1 && Tabl[iki][jki] > 0)
								{
									continue;
								}

								if (Is[0] == 1)
								{
									continue;
								}
								int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
								int **Tab = CloneATable(Tabl);
								int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
								bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
								int *IS = nullptr;
								////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{
									IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
									if (IS[0] == 1)
									{
										Is[0] = 1;
									}
									if (IS[2] == 1)
									{
										Is[2] = 1;
									}
									Is[1] = IS[1];
									Is[3] = IS[3];
								}

							} //);
							 //For Current Home
							 ////Parallel.For(0, 8, iki =>
							for (int iki = 0; iki < 8; iki++)
							{
								int jki = iki * -1 + jk + ik;
								if (!Scop(ik, jk, iki, jki, 2))
								{
									continue;
								}
								//Ignore of Enemy
								if (Order == 1 && Tabl[iki][jki] < 0)
								{
									continue;
								}
								if (Order == -1 && Tabl[iki][jki] > 0)
								{
									continue;
								}

								if (Is[0] == 1)
								{
									continue;
								}
								int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
								int **Tab = CloneATable(Tabl);
								int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
								bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
								int *IS = nullptr;
								////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{
									IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
									if (IS[0] == 1)
									{
										Is[0] = 1;
									}
									if (IS[2] == 1)
									{
										Is[2] = 1;
									}
									Is[1] = IS[1];
									Is[3] = IS[3];
								}
							} //);
						}
						else
						{
						if (abs(Tabl[ik][jk]) == 3)
						{
							//For Current Home
							////Parallel.For(ik - 2, ik + 3, iki =>
							////Parallel.For(jk - 2, jk + 3, jki =>
							for (int iki = ik - 2; iki < ik + 3; iki++)
							{
								for (int jki = jk - 2; jki < jk + 3; jki++)

								{
									if (!Scop(ik, jk, iki, jki, 3))
									{
										continue;
									}
									//Ignore of Enemy
									if (Order == 1 && Tabl[iki][jki] < 0)
									{
										continue;
									}
									if (Order == -1 && Tabl[iki][jki] > 0)
									{
										continue;
									}

									int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
									int **Tab = CloneATable(Tabl);
									int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
									bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
									int *IS = nullptr;
									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
										if (IS[0] == 1)
										{
											Is[0] = 1;
										}
										if (IS[2] == 1)
										{
											Is[2] = 1;
										}
										Is[1] = IS[1];
										Is[3] = IS[3];
									}
								} //));
							}
						}
						else
						{
						if (abs(Tabl[ik][jk]) == 4)
						{
							//For Current Home
							////Parallel.For(0, 8, iki =>
							for (int iki = 0; iki < 8; iki++)
							{
								int jki = jk;
								if (!Scop(ik, jk, iki, jki, 4))
								{
									continue;
								}
								//Ignore of Enemy
								if (Order == 1 && Tabl[iki][jki] < 0)
								{
									continue;
								}
								if (Order == -1 && Tabl[iki][jki] > 0)
								{
									continue;
								}

								if (Is[0] == 1)
								{
									continue;
								}
								int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
								int **Tab = CloneATable(Tabl);
								int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
								bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
								int *IS = nullptr;
								////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{
									IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
									if (IS[0] == 1)
									{
										Is[0] = 1;
									}
									if (IS[2] == 1)
									{
										Is[2] = 1;
									}
									Is[1] = IS[1];
									Is[3] = IS[3];
								}
							} //);
							 //For Current Home
							 ////Parallel.For(0, 8, jki =>
							for (int jki = 0; jki < 8; jki++)
							{
								int iki = ik;
								if (!Scop(ik, jk, iki, jki, 4))
								{
									continue;
								}
								//Ignore of Enemy
								if (Order == 1 && Tabl[iki][jki] < 0)
								{
									continue;
								}
								if (Order == -1 && Tabl[iki][jki] > 0)
								{
									continue;
								}

								if (Is[0] == 1)
								{
									continue;
								}
								int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
								int **Tab = CloneATable(Tabl);
								int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
								bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
								int *IS = nullptr;
								////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O1)
								{
									IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
									if (IS[0] == 1)
									{
										Is[0] = 1;
									}
									if (IS[2] == 1)
									{
										Is[2] = 1;
									}
									Is[1] = IS[1];
									Is[3] = IS[3];
								}
							} //);
						}
						else
						{
						if (abs(Tabl[ik][jk]) == 5)
						{

							//For Current Home
							////Parallel.For(0, 8, iki =>
							////Parallel.For(0, 8, jki =>
							for (int iki = 0; iki < 8; iki++)
							{
								for (int jki = 0; jki < 8; jki++)
								{
									//Ignore of Enemy
									if (Order == 1 && Tabl[iki][jki] < 0)
									{
										continue;
									}
									if (Order == -1 && Tabl[iki][jki] > 0)
									{
										continue;
									}
									if (!Scop(ik, jk, iki, jki, 5))
									{
										continue;
									}

									if (Is[0] == 1)
									{
										continue;
									}
									int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
									int **Tab = CloneATable(Tabl);
									int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
									bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
									int *IS = nullptr;
									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
										if (IS[0] == 1)
										{
											Is[0] = 1;
										}
										if (IS[2] == 1)
										{
											Is[2] = 1;
										}
										Is[1] = IS[1];
										Is[3] = IS[3];
									}
								} //));
							}
						}
						else
						{
						if (abs(Tabl[ik][jk]) == 6)
						{
							//For Current Home
							////Parallel.For(ik - 1, ik + 2, iki =>
							////Parallel.For(jk - 1, jk + 2, jki =>
							for (int iki = ik - 1; iki < ik + 2; iki++)
							{
								for (int jki = jk - 1; jki < jk + 2; jki++)

								{
									if (!Scop(ik, jk, iki, jki, 6))
									{
										continue;
									}
									//Ignore of Enemy
									if (Order == 1 && Tabl[iki][jki] < 0)
									{
										continue;
									}
									if (Order == -1 && Tabl[iki][jki] > 0)
									{
										continue;
									}

									if (Is[0] == 1)
									{
										continue;
									}
									int Ord = Order;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(Tabl);
									int **Tab = CloneATable(Tabl);
									int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
									bool KindCheckedSelf1 = KindCheckedSelf;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int* IS = nullptr;
									int *IS = nullptr;
									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(Ord, Tab, ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1);
										if (IS[0] == 1)
										{
											Is[0] = 1;
										}
										if (IS[2] == 1)
										{
											Is[2] = 1;
										}
										Is[1] = IS[1];
										Is[3] = IS[3];
									}
								} //));
							}
						}
						}
						}
						}
						}
						}
					} //));
				}
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
			}
			return Is;
		}
	}

	bool ThinkingChess::IsGardForCurrentMovmentsAndIsNotMovable(int **Tab, int Order, int a, int ii, int jj, int RowS, int ColS)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			//Setting false.
			bool Attacked = true;
			int NumberOfCurrentEnemyAttackSuchObject = 0;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			//For Enemy Order.
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				//Ignore of Self Objects.
				if (Order == 1 && Tab[ii][jj] >= 0)
				{
					return false;
				}
				else
				{
					if (Order == -1 && Tab[ii][jj] <= 0)
					{
					return false;
					}
				}

				//Restore
				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
				NumberOfCurrentEnemyAttackSuchObject = 0;
				//For Self Objects and Empty.
				//Ignore of Enemy Objects.
				if (Order == 1 && Tab[RowS][ColS] < 0)
				{
					return false;
				}
				else
				{
					if (Order == -1 && Tab[RowS][ColS] > 0)
					{
					return false;
					}
				}
				//For Enemy Order.
				ChessRules::CurrentOrder = Order * -1;
				//Initiate for not exiting from abnormal loop.
				Attacked = false;
				int aa = 1;
				if (Order * -1 == -1)
				{
					aa = -1;
				}
				//When Enemy Attacked Current Movements.
				if (Attack(Tab, ii, jj, RowS, ColS, aa, Order * -1) && (ObjectValueCalculator(Tab, ii, jj) < ObjectValueCalculator(Tab, RowS, ColS)))
				{
					NumberOfCurrentEnemyAttackSuchObject++;
					//Clone a Table.
					int **TabS = new int*[8]; for (int g = 0; g < 8; g++)TabS[g] = new int[8];
					for (int p = 0; p < 8; p++)
					{
						for (int m = 0; m < 8; m++)
						{
							TabS[p][m] = Tab[p][m];
						}
					}
					TabS[RowS][ColS] = TabS[ii][jj];
					TabS[ii][jj] = 0;

					//For Self Objects.
					////Parallel.For(0, 8, RowD =>
					for (int RowD = 0; RowD < 8; RowD++)

					{
						if (!Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
						{
							continue;
						}

						////Parallel.For(0, 8, ColD =>
						for (int ColD = 0; ColD < 8; ColD++)
						{
							if (!Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
							{
								//continue;//Ignore Enmy Objects.
								if (Order == 1 && Tab[RowD][ColD] <= 0)
								{
									continue;
								}
								else
								{
										if (Order == -1 && Tab[RowD][ColD] >= 0)
										{
									continue;
										}
								}
							}
							//Show the Attacked.
							Attacked = true;
							//For Self Objects and Empty.
							////Parallel.For(0, 8, iiiii =>
							for (int iiiii = 0; iiiii < 8; iiiii++)
							{
								////Parallel.For(0, 8, jjjjj =>
								for (int jjjjj = 0; jjjjj < 8; jjjjj++)
								{
									//Ignore of Enemy Objects.
									if (Order == 1 && Tab[iiiii][jjjjj] < 0)
									{
										continue;
									}
									else
									{
										   if (Order == -1 && Tab[iiiii][jjjjj] > 0)
										   {
										continue;
										   }
									}
									//When Current Objects Movable not need to consideration mor going to next Current object.
									////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O2)
									{
										if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TabS[RowD][ColD], TabS, Order, RowD, ColD))->Rules(RowD, ColD, iiiii, jjjjj, a, TabS[RowD][ColD]))
										{
											Attacked = Attacked && false;
											continue;
										}
									}
								} //);
								if (!Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
								{
									continue;
								}
							} //);
							if (Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
							{
								continue;
							}
						} //);
						if (Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
						{
							continue;
						}
					} //);
				}
				else
				{
					return false;
				}
			}
			//Restore.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;

			//continue Variable when true show an object is not movable or one enemy object attack more than one current Object.
			return Attacked || NumberOfCurrentEnemyAttackSuchObject > 1;
		}
	}

	bool ThinkingChess::IsCurrentCanGardHighPriorityEnemy(int Depth, int **Table, int Order, int a, int ij, int ji, int iij, int jji, int OrderPlate)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			if (Depth >= CurrentAStarGredyMax)
			{
				return false;
			}
			////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O4)
			{
				Depth++;
				IsGardHighPriority = false;

				int **Tabl1 = new int*[8]; for (int g = 0; g < 8; g++)Tabl1[g] = new int[8];

				for (int ik = 0; ik < 8; ik++)
				{
					for (int jk = 0; jk < 8; jk++)
					{
						Tabl1[ik][jk] = Table[ik][jk];
					}
				}
				//For Current.
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						//Ignore of Enemy.QC_OK.
						if (Order == 1 && Tabl1[i][j] <= 0)
						{
							continue;
						}
						else
						{
							if (Order == -1 && Tabl1[i][j] >= 0)
							{
							continue;
							}
						}
						//For Enemy.
						for (int ii = 0; ii < 8; ii++)
						{
							for (int jj = 0; jj < 8; jj++)
							{
								//Ignore of Current.QC_OK.
								if (Order == 1 && Tabl1[ii][jj] >= 0)
								{
									continue;
								}
								else
								{
									if (Order == -1 && Tabl1[ii][jj] >= 0)
									{
									continue;
									}
								}
								for (int ik = 0; ik < 8; ik++)
								{
									for (int jk = 0; jk < 8; jk++)
									{
										Tabl1[ik][jk] = Table[ik][jk];
									}
								}
								//Take Movement.
								if (Attack(Tabl1, i, j, ii, jj, a, Order * -1))
								{
									//When Current Movments is
									if (ObjectValueCalculator(Tabl1, i, j) <= ObjectValueCalculator(Tabl1, ii, jj))
									{
										if (Order == OrderPlate)
										{
											IsGardHighPriority = true;
										}
									}
									else
									{
										Tabl1[ii][jj] = Tabl1[i][j];
										Tabl1[i][j] = 0;
										if (Order * -1 == 1)
										{
											a = 1;
										}
										else
										{
											a = -1;
										}
										IsGardHighPriority = IsGardHighPriority || IsCurrentCanGardHighPriorityEnemy(Depth, Table, Order * -1, a, ii, jj, i, j, OrderPlate);
									}

								}
							}
						}
					}
				}
			}
			return IsGardHighPriority;
		}
	}

	double ThinkingChess::HuristicCheckAndCheckMate(int **Table, int a)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double HA = 0;
			//int DummyOrder = AllDraw.OrderPlate;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			//double ObjectDangour = 1;
			//double Check = 1000;
			double ObjectDangour = 0; // 100;
			double Check = 0; // 1000;
			double CheckMate = 100000;
			//When is self objects order divide valuse by 100
			//Becuse reduce from danger is most favareable of caused to enemy attack
			/*if (Order == AllDraw.OrderPlate)
			{
			    ObjectDangour = 0.01;
			    Check = 100;
			    CheckMate = 1000;
			}*/

				////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O1)
				{
					//Consider Global Check CheckMate ObjectDanger Variables Orderly.
					ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[Row][Column], Table, Order, Row, Column);
					ChessRules AAA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[Row][Column], Table, Order, Row, Column);
					A->CheckMate(Table, Order);
					AAA.Check(Table, Order);
					ChessRules AA =  ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[Row][Column], Table, Order, Row, Column);
					AA.ObjectDangourKingMove(Order, Table, false);
					{
						//Consider Value to More Valuable Positive and Negative Check CheckMate ObjectDanger 
						if (A->CheckMateGray || A->CheckMateBrown)
						{ //When is Brown CheckedMate.
							if (DummyOrder == 1 && A->CheckMateBrown)
							{
								HA += CheckMate;
								MovementsAStarGreedyHuristicFoundT = true;
							}
							//When is Gray CheckedMate.
							if (DummyOrder == -1 && A->CheckMateGray)
							{
								HA += CheckMate;
								MovementsAStarGreedyHuristicFoundT = true;
							}
						}
						//When is Checked.
						if (AAA.CheckGray || AAA.CheckBrown)
						{
							//When is Gray Checked 
							if (DummyOrder == 1 && AAA.CheckBrown)
							{
								HA += Check;
								MovementsAStarGreedyHuristicFoundT = true;
							}
							//When is Brown Check.
							if (DummyOrder == -1 && AAA.CheckGray)
							{
								HA += Check;
								MovementsAStarGreedyHuristicFoundT = true;
							}
						}
						//When is Objects Dangoure.
						if (AA.CheckGrayObjectDangour || AA.CheckBrownObjectDangour)
						{
							//when is Gray Objects Dangoure.
							if (DummyOrder == 1 && AA.CheckBrownObjectDangour)
							{
								HA += ObjectDangour;
								MovementsAStarGreedyHuristicFoundT = true;
							}
							//when is Gray Objects Dangoure.
							if (DummyOrder == -1 && AA.CheckGrayObjectDangour)
							{
								HA += ObjectDangour;
								MovementsAStarGreedyHuristicFoundT = true;
							}
						}
						//When is CheckMate
						if (A->CheckMateGray || A->CheckMateBrown)
						{
							//When is Gray Check Mate.
							if (DummyOrder == 1 && A->CheckMateGray)
							{
								HA -= CheckMate;
							}
							//when is Brown CheckMate.
							if (DummyOrder == -1 && A->CheckMateBrown)
							{
								HA -= CheckMate;
							}
						}
						//when is Check
						if (AAA.CheckGray || AAA.CheckBrown)
						{
							//when is Gray Check
							if (DummyOrder == 1 && AAA.CheckGray)
							{
								HA -= Check;
							}
							//When is Brown Check.
							if (DummyOrder == -1 && AAA.CheckBrown)
							{
								HA -= Check;
							}
						}
						//When is Object Dangoure.
						if (AA.CheckBrownObjectDangour || AA.CheckGrayObjectDangour)
						{
							//When is Gray Object.
							if (DummyOrder == 1 && AA.CheckGrayObjectDangour)
							{
								HA -= ObjectDangour;
							}
							//When is Brown Object Dangoure.
							if (DummyOrder == -1 && AA.CheckBrownObjectDangour)
							{
								HA -= ObjectDangour;
							}
						}
					}
				}

			//if (HA < 0)
			//IgnoreFromCheckandMateHuristic = true;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return HA * 1;
		}
	}

	int ThinkingChess::VeryFye(int **Table, int Order, int a)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int HA = 0;
			int Object = Table[Row][Column];
			//Wehn Solider.
			if (abs(Object) == 1)
			{
				HA = 1;
			}
			//When Elephant.
			else if (abs(Object) == 2)
			{
				HA = 2;
			}
			//When Hourse.
			else if (abs(Object) == 3)
			{
				HA = 3;
			}
			//When Castles.
			else if (abs(Object) == 4)
			{
				HA = 5;
			}
			//When Minster.
			else if (abs(Object) == 5)
			{
				HA = 8;
			}
			//When King.
			else if (abs(Object) == 6)
			{
				HA = 10;
			}
			return HA;
		}
	}

	int ThinkingChess::SupporterCount(int **Table, int Order, int a, int ii, int jj)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Count = 0;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			if (Order == 1)
			{
				ChessRules::CurrentOrder = 1;
			}
			else
			{
				ChessRules::CurrentOrder = -1;
			}
			bool Tab[8][8];
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (Order == 1 && Table[i][j] <= 0)
					{
						continue;
					}
					else
					{
						if (Order == -1 && Table[i][j] >= 0)
						{
						continue;
						}
					}
					if (Support(Table, i, j, ii, jj, a, Order))
					{
						Count++;
					}
				}
			}

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return Count;
		}
	}

	int ThinkingChess::AttackerCount(int **Table, int Order, int a, int i, int j)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Count = 0;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			for (int h = 0; h < 8; h++)
			{
				for (int k = 0; k < 8; k++)
				{
					Tab[h][k] = Table[h][k];
				}
			}
			//For Slef Objects..
			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					//Ignore Of Self Objects
					if (Order == 1 && Tab[ii][jj] >= 0)
					{
						continue;
					}
					else
					{
						if (Order == -1 && Tab[ii][jj] <= 0)
						{
						continue;
						}
					}
					//If Current Attacks Enemy.
					if (Attack(Tab, i, j, ii, jj, a, Order))
					{
						Count++;
					}
				}
			}

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return Count;
		}
	}

	int ThinkingChess::EnemyAttackerCount(int **Table, int Order, int a, int ii, int jj)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Count = 0;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			if (Order == 1)
			{
				ChessRules::CurrentOrder = 1;
			}
			else
			{
				ChessRules::CurrentOrder = -1;
			}
			int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];
			for (int h = 0; h < 8; h++)
			{
				for (int k = 0; k < 8; k++)
				{
					Tab[h][k] = Table[h][k];
				}
			}
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (Order == 1 && Table[i][j] >= 0)
					{
						continue;
					}
					else
					{
						if (Order == -1 && Table[i][j] <= 0)
						{
						continue;
						}
					}
					if (Attack(Table, i, j, ii, jj, a, Order * -1))
					{
						Count++;
					}
				}
			}

			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			return Count;
		}
	}

	double ThinkingChess::HeuristicDistabceOfCurrentMoveFromEnemyKing(int **Tab, int Order, int RowS, int ColS)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			  //Initiate.
			int RowG = -1, ColumnG = -1, RowB = -1, ColumnB = -1;
			//Create ChessRules Objects.
			ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Tab[RowS][ColS], Tab, Order, RowS, ColS);
			double Dis = 0;
			//Order is  Gray.
			if (Order == -1)
			{
				//Found of Gray King Location.
				A->FindGrayKing(Tab, RowG, ColumnG);

				//When Soldier.
				if (abs(Tab[RowS][ColS]) == 1)
				{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowG, 2) + pow(ColS - ColumnG, 2));
				}
				else
				{
					//When Elephant.
					if (abs(Tab[RowS][ColS]) == 2)
					{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowG, 2) + pow(ColS - ColumnG, 2));
					}
				else
				{
						//When Hourse.
						if (abs(Tab[RowS][ColS]) == 3)
						{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowG, 2) + pow(ColS - ColumnG, 2));
						}
				else
				{
							//When Castles.
							if (abs(Tab[RowS][ColS]) == 4)
							{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowG, 2) + pow(ColS - ColumnG, 2));
							}
				else
				{
								//When minister.
								if (abs(Tab[RowS][ColS]) == 5)
								{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowG, 2) + pow(ColS - ColumnG, 2));
								}
				else
				{
									//When King.
									if (abs(Tab[RowS][ColS]) == 6)
									{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowG, 2) + pow(ColS - ColumnG, 2));
									}
				}
				}
				}
				}
				}

			}
			//Brown Order.
			else
			{
				//Found of Brown King Location.
				A->FindBrownKing(Tab, RowB, ColumnB);
				//When Soldier.
				if (abs(Tab[RowS][ColS]) == 1)
				{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowB, 2) + pow(ColS - ColumnB, 2));
				}
				else
				{
					//When Elephant.
					if (abs(Tab[RowS][ColS]) == 2)
					{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowB, 2) + pow(ColS - ColumnB, 2));
					}
				else
				{
						//When Hourse.
						if (abs(Tab[RowS][ColS]) == 3)
						{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowB, 2) + pow(ColS - ColumnB, 2));
						}
				else
				{
							//When Castles.
							if (abs(Tab[RowS][ColS]) == 4)
							{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowB, 2) + pow(ColS - ColumnB, 2));
							}
				else
				{
								//When Minister.
								if (abs(Tab[RowS][ColS]) == 5)
								{
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowB, 2) + pow(ColS - ColumnB, 2));
								}
				else
				{
					//When King.
					Dis = AllDraw::SignDistance * sqrt(pow(RowS - RowB, 2) + pow(ColS - ColumnB, 2));
				}
				}
				}
				}
				}
				//Dis = -1000.0;

			}
			return Dis;
		}
	}

	double ThinkingChess::HuristicSoldierFromCenter(int **Table, int aa, int Ord, int ii, int jj, int i, int j)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double HA = 0;
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				if (abs(Table[ii][jj]) == 1)
				{
					if (!ArrangmentsChanged)
					{
						if (Order == 1)
						{
							if (i < 4 && j < 4)
							{
								HA += ((-1) * sqrt(pow(i - 3, 2) + pow(j - 3, 2)));

							}
							if (i < 4 && j >= 4)
							{
								HA += ((-1)*sqrt(pow(i - 3, 2) + pow(j - 4, 2)));
							}

						}
						else
						{
							if (i >= 4 && j < 4)
							{
								HA += ((-1)*sqrt(pow(i - 4, 2) + pow(j - 3, 2)));
							}
							if (i >= 4 && j >= 4)
							{
								HA += ((-1)*sqrt(pow(i - 4, 2) + pow(j - 4, 2)));
							}
						}
					}
					else
					{
						if (Order == -1)
						{
							if (i < 4 && j < 4)
							{
								HA += ((-1)*sqrt(pow(i - 3, 2) + pow(j - 3, 2)));
							}
							if (i < 4 && j >= 4)
							{
								HA += ((-1)*sqrt(pow(i - 3, 2) + pow(j - 4, 2)));
							}

						}
						else
						{
							if (i >= 4 && j < 4)
							{
								HA += ((-1)*sqrt(pow(i - 4, 2) + pow(j - 3, 2)));
							}
							if (i >= 4 && j >= 4)
							{
								HA += ((-1)*sqrt(pow(i - 4, 2) + pow(j - 4, 2)));
							}
						}
					}



				}
				else if (abs(Table[ii][jj]) == 1)
				{
					if (!ArrangmentsChanged)
					{
						if (Order == 1)
						{
							if (ii < 4 && jj < 4)
							{
								HA += ((-1)*sqrt(pow(ii - 3, 2) + pow(jj - 3, 2)));
							}
							if (ii < 4 && jj >= 4)
							{
								HA += ((-1)*sqrt(pow(ii - 3, 2) + pow(jj - 4, 2)));
							}

						}
						else
						{
							if (ii >= 4 && jj < 4)
							{
								HA += ((-1)*sqrt(pow(ii - 4, 2) + pow(jj - 3, 2)));
							}
							if (ii >= 4 && jj >= 4)
							{
								HA += ((-1)*sqrt(pow(ii - 4, 2) + pow(jj - 4, 2)));
							}
						}
					}
					else
					{
						if (Order == -1)
						{
							if (ii < 4 && jj < 4)
							{
								HA += ((-1)*sqrt(pow(ii - 3, 2) + pow(jj - 3, 2)));
							}
							if (ii < 4 && jj >= 4)
							{
								HA += ((-1)*sqrt(pow(ii - 3, 2) + pow(jj - 4, 2)));
							}

						}
						else
						{
							if (ii >= 4 && jj < 4)
							{
								HA += ((-1)*sqrt(pow(ii - 4, 2) + pow(jj - 3, 2)));
							}
							if (ii >= 4 && jj >= 4)
							{
								HA += ((-1)*sqrt(pow(ii - 4, 2) + pow(jj - 4, 2)));
							}
						}
					}


				}
			}
			return 1 * HA;
		}
	}

	double *ThinkingChess::HuristicAll(bool Before, int Killed, int **Table, int aa, int Ord, int RowS, int ColS, int RowD, int ColD)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double Huristic[6];
			//Initiate Local Variable.

			//int RowS = RowD, ColS = ColS;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			///When AStarGreedy Huristic is Not Assigned.

				if (!AStarGreedyHuristicT)
				{
					//For Current Objects.
					////Parallel.For(0, 8, RowS =>
					{
						{
						////Parallel.For(0, 8, ColS =>
							////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O1)
							{
								int i1 = RowS, j1 = ColS, iiii1 = RowD, jjjj1 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table1 = CloneATable(Table);
								int **Table1 = CloneATable(Table);
								int Ord1 = Ord;
								int aa1 = aa;
								double HAA1 = HuristicAttack(Before, Table1, Ord1, aa1, i1, j1, iiii1, jjjj1);
								if (HAA1 != 0)
								{
									Huristic[0] += HAA1;
								}

								int i2 = RowS, j2 = ColS, iiii2 = RowD, jjjj2 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table2 = CloneATable(Table);
								int **Table2 = CloneATable(Table);
								int Ord2 = Ord;
								int aa2 = aa;
								int Killed1 = Killed;
								double HAA2 = HuristicKiller(Killed1, Table2, i2, j2, iiii2, jjjj2, Ord2, aa2, false);
								if (HAA2 != 0)
								{
									Huristic[1] += HAA2;
								}

								int i3 = RowS, j3 = ColS, iiii3 = RowD, jjjj3 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table3 = CloneATable(Table);
								int **Table3 = CloneATable(Table);
								int Ord3 = Ord;
								int aa3 = aa;
								double HAA3 = HuristicMovment(Before, Table3, aa3, Ord3, i3, j3, iiii3, jjjj3);
								if (HAA3 != 0)
								{
									Huristic[2] += HAA3;
								}

								int i4 = RowS, j4 = ColS, iiii4 = RowD, jjjj4 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table4 = CloneATable(Table);
								int **Table4 = CloneATable(Table);
								int Ord4 = Ord;
								int aa4 = aa;
								double HAA4 = HuristicObjectDangour(Table4, Ord4, aa4, i4, j4, iiii4, jjjj4);
								if (HAA4 != 0)
								{
									Huristic[3] += HAA4;
								}

								int i5 = RowS, j5 = ColS, iiii5 = RowD, jjjj5 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table5 = CloneATable(Table);
								int **Table5 = CloneATable(Table);
								int Ord5 = Ord;
								int aa5 = aa;
								double HAA5 = HuristicReducsedAttack(Before, Table5, Ord5, aa5, i5, j5, iiii5, jjjj5);
								if (HAA5 != 0)
								{
									Huristic[4] += HAA5;
								}

								int i6 = RowS, j6 = ColS, iiii6 = RowD, jjjj6 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table6 = CloneATable(Table);
								int **Table6 = CloneATable(Table);
								int Ord6 = Ord;
								int aa6 = aa;
								double HAA6 = HuristicSelfSupported(Table6, Ord6, aa6, i6, j6, iiii6, jjjj6);
								if (HAA6 != 0)
								{
									Huristic[5] += HAA6;
								}
							}

						} //);
					} //);
				}
				//For All Homes Table.
				else
				{
					{
					////Parallel.For(0, 8, RowS =>
						////Parallel.For(0, 8, ColS =>
						{
							////Parallel.For(0, 8, ii =>
							for (int ii = 0; ii < 8; ii++)
							{
								////Parallel.For(0, 8, jj =>
								for (int jj = 0; jj < 8; jj++)
								{
									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										int i1 = RowS, j1 = ColS, iiii1 = RowD, jjjj1 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table1 = CloneATable(Table);
										int **Table1 = CloneATable(Table);
										int Ord1 = Ord;
										int aa1 = aa;
										double HAA1 = HuristicAttack(Before, Table1, Ord1, aa1, i1, j1, iiii1, jjjj1);
										Huristic[0] += HAA1;

										int i2 = RowS, j2 = ColS, iiii2 = RowD, jjjj2 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table2 = CloneATable(Table);
										int **Table2 = CloneATable(Table);
										int Ord2 = Ord;
										int aa2 = aa;
										int Killed1 = Killed;
										double HAA2 = HuristicKiller(Killed1, Table2, i2, j2, iiii2, jjjj2, Ord2, aa2, false);
										Huristic[1] += HAA2;

										int i3 = RowS, j3 = ColS, iiii3 = RowD, jjjj3 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table3 = CloneATable(Table);
										int **Table3 = CloneATable(Table);
										int Ord3 = Ord;
										int aa3 = aa;
										double HAA3 = HuristicMovment(Before, Table3, aa3, Ord3, i3, j3, iiii3, jjjj3);
										Huristic[2] += HAA3;

										int i4 = RowS, j4 = ColS, iiii4 = RowD, jjjj4 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table4 = CloneATable(Table);
										int **Table4 = CloneATable(Table);
										int Ord4 = Ord;
										int aa4 = aa;
										double HAA4 = HuristicObjectDangour(Table4, Ord4, aa4, i4, j4, iiii4, jjjj4);
										Huristic[3] += HAA4;

										int i5 = RowS, j5 = ColS, iiii5 = RowD, jjjj5 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table5 = CloneATable(Table);
										int **Table5 = CloneATable(Table);
										int Ord5 = Ord;
										int aa5 = aa;
										double HAA5 = HuristicReducsedAttack(Before, Table5, Ord5, aa5, i5, j5, iiii5, jjjj5);
										Huristic[4] += HAA5;

										int i6 = RowS, j6 = ColS, iiii6 = RowD, jjjj6 = ColD;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Table6 = CloneATable(Table);
										int **Table6 = CloneATable(Table);
										int Ord6 = Ord;
										int aa6 = aa;
										double HAA6 = HuristicSelfSupported(Table6, Ord6, aa6, i6, j6, iiii6, jjjj6);
										Huristic[5] += HAA6;
									}
								} //);
							} //);
						} //);
					} //);
				}


			//Reassignments of Begin Call Global Orders.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			//Store Local Huristic in Global One.
			//Huristic[0] = (Huristic[0]* SignOrderToPlate(Order));
			//Huristic[1] = (Huristic[1]* SignOrderToPlate(Order));
			//Huristic[2] = (Huristic[2]* SignOrderToPlate(Order));
			//Huristic[3] = (Huristic[3]* SignOrderToPlate(Order));
			//Huristic[4] = (Huristic[4]* SignOrderToPlate(Order));
			//Huristic[5] = (Huristic[5]* SignOrderToPlate(Order));
			//Return Local Huristic.
			return Huristic;
		}
	}

	double ThinkingChess::HuristicMovment(bool Before, int **Table, int aa, int Ord, int RowS, int ColS, int RowD, int ColD)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			double HuristicMovementValue = 0;
			//Initiate Local Variable.
			double HA = 0;
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			///When AStarGreedy Huristic is Not Assigned.

			if (!AStarGreedyHuristicT)
			{
				int Order = int();
				int a = int();
				a = aa;
				Order = DummyOrder;
				double Sign = double();
				///When Moveble is true. means [RowS,ColS] is in Movmebale to [RowD,ColD].
				///What is Moveable!
				///Ans:When [RowS,ColS] is Movebale to [RowD,ColD] continue true when Empty or Enemy is located in [RowS,ColS].
				if (Table[RowD][ColD] == 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
				{
					Order = -1;
					////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						Sign = 1 * AllDraw::SignMovments;
						ChessRules::CurrentOrder = -1;
					}
					a = -1;
				}
				else if (Table[RowD][ColD] == 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
				{
					Order = 1;
					////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						Sign = 1 * AllDraw::SignMovments;
						ChessRules::CurrentOrder = 1;
					}
					a = 1;
				}
				else
				{
					return HuristicMovementValue;
				}
				if (Before)
				{
					//When is Movable Movement inCurrent.
					if (Movable(Table, RowS, ColS, RowD, ColD, a, Order))
					{
						int **Tab = new int*[8]; for (int g = 0; g < 8; g++)Tab[g] = new int[8];

						for (int ik = 0; ik < 8; ik++)
						{
							for (int jk = 0; jk < 8; jk++)
							{
								Tab[ik][jk] = Table[ik][jk];
							}
						}
						HA += (Sign * (abs(ObjectValueCalculator(Table, RowS, ColS, RowD, ColD))));
						/* int Supported = 0;
						 int Attacked = 0;
						 //For All Enemy Obejcts.                                             
						 for (int g = 0; g < 8; g++)
						 ////Parallel.For(0, 8, g =>
						 {
						     ////Parallel.For(0, 8, h =>
						     for (int h = 0; h < 8; h++)
						     {
						         Object O2 = new Object();
						         //lock (O2)
						         {
						             //Ignore Of Self Objects.
						             if (Order == 1 && Table[g, h] == 0)
						                 continue;
						             if (Order == -1 && Table[g, h] == 0)
						                 continue;
						             int aaa = new int();
						             //Assgin Enemy ints.
						             aaa = int.Gray;
						             if (Order * -1 == -1)
						                 aaa = int.Brown;
						             else
						                 aaa = int.Gray;
						             //When Enemy is Supported.
						             bool A = new bool();
						             bool B = new bool();
						             A = Support(Tab, g, h, RowS, ColS, a, Order);
						             B = Attack(Tab, g, h, RowS, ColS, aaa, Order * -1);
						             //When Enemy is Supported.
						             if (B)
						             {
						                 //Assgine variable.
						                 Attacked++;
						             }
						             if (A)
						             {
						                 //Assgine variable.
						                 Supported++;
						                 continue;
						             }
						         }
						     }//);
	
						 }//);
						 Object O1 = new Object();
						 //lock (O1)
						 {
						     if (Supported != 0)
						         //When is Not Supported multyply 100.
						         HA *= System.Math.Pow(2, Supported);
	
						     //When is Supported Multyply -100.
						     if (Attacked != 0)
						         //When is Not Supported multyply 100.
						         HA *= -(1 * System.Math.Pow(2, Attacked));
	
						 }*/
					}
				}

			}
			//For All Homes Table.
			else
			{
				int Order = int();
				int a = int();
				a = aa;
				if (RowD == RowS && ColD == ColS)
				{
					return HuristicMovementValue;
				}
				double Sign = double();
				Order = DummyOrder;
				///When Moveble is true. means [RowS,ColS] is in Movmebale to [RowD,ColD].
				///What is Moveable!
				///Ans:When [RowS,ColS] is Movebale to [RowD,ColD] continue true when Empty or Enemy is located in [RowS,ColS].
				if (Table[RowD][ColD] == 0 && DummyOrder == -1 && Table[RowS][ColS] < 0)
				{
					Order = -1;
					////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						Sign = 1 * AllDraw::SignMovments;
						ChessRules::CurrentOrder = -1;
						a = -1;
					}
				}
				else if (Table[RowD][ColD] == 0 && DummyOrder == 1 && Table[RowS][ColS] > 0)
				{
					Order = 1;
					////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O1)
					{
						Sign = 1 * AllDraw::SignMovments;
						ChessRules::CurrentOrder = 1;
						a = 1;
					}
				}
				else
				{
					return HuristicMovementValue;
				}
				if (Before)
				{
					//When is Movable Movement inCurrent.
					if (Movable(Table, RowS, ColS, RowD, ColD, a, Order))
					{
						HA += (Sign * (abs(ObjectValueCalculator(Table, RowS, ColS, RowD, ColD))));
						/*int Supported = 0;
						int Attacked = 0;
						//For All Enemy Obejcts.                                             
						for (int g = 0; g < 8; g++)
						////Parallel.For(0, 8, g =>
						{
						    ////Parallel.For(0, 8, h =>
						    for (int h = 0; h < 8; h++)
						    {
						        Object O2 = new Object();
						        //lock (O2)
						        {
						            //Ignore Of Self Objects.
						            if (Order == 1 && Table[g, h] == 0)
						                continue;
						            if (Order == -1 && Table[g, h] == 0)
						                continue;
						            int aaa = new int();
						            //Assgin Enemy ints.
						            aaa = int.Gray;
						            if (Order * -1 == -1)
						                aaa = int.Brown;
						            else
						                aaa = int.Gray;
						            //When Enemy is Supported.
						            bool A = new bool();
						            bool B = new bool();
						            A = Support(Table, g, h, RowS, ColS, a, Order);
						            B = Attack(Table, g, h, RowS, ColS, aaa, Order * -1);
						            //When Enemy is Supported.
						            if (B)
						            {
						                //Assgine variable.
						                Attacked++;
						            }
						            if (A)
						            {
						                //Assgine variable.
						                Supported++;
						                continue;
						            }
						        }
						    }//);
	
						}//);
						Object O1 = new Object();
						//lock (O1)
						{
						    if (Supported != 0)
						        //When is Not Supported multyply 100.
						        HA *= System.Math.Pow(2, Supported);
	
						    //When is Supported Multyply -100.
						    if (Attacked != 0)
						        //When is Not Supported multyply 100.
						        HA *= (-1 * System.Math.Pow(2, Attacked));
	
						}*/
					}
				}
			}

			//Reassignments of Begin Call Global Orders.
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			//Store Local Huristic in Global One.
			return HA * 1;
		}
	}

	bool ThinkingChess::Attack(int **Tab, int i, int j, int ii, int jj, int a, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int CCurentOrder = ChessRules::CurrentOrder;
			//Initiate Global static  Variable.
			ChessRules::CurrentOrder = Order;
			int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
			for (int ik = 0; ik < 8; ik++)
			{
				for (int jk = 0; jk < 8; jk++)
				{
					Table[ik][jk] = Tab[ik][jk];
				}
			}

			//when there is a Movment from Parameter One to Second Parameter return Attacke..
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[i][j], Table, Order, i, j))->Rules(i, j, ii, jj, a, Order)) //&& Table[ii, jj] != 0
			{
				ChessRules::CurrentOrder = CCurentOrder;
				return true;
			}
			ChessRules::CurrentOrder = CCurentOrder;
			return false;
		}
	}

	bool ThinkingChess::ObjectDanger(int **Tab, int i, int j, int ii, int jj, int a, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int CCurrentOrder = ChessRules::CurrentOrder;
			//Initiate Local Varibales.
			int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];
			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					Table[RowS][ColS] = Tab[RowS][ColS];
				}
			}
			ChessRules::CurrentOrder = Order;
			///When [i,j] is Attacked [ii,jj] retrun true when enemy is located in [ii,jj].
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[i][j], Table, Order, i, j))->Rules(i, j, ii, jj, a, Order))
			{
				//Initiate Local Variables.
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						Table[RowS][ColS] = Tab[RowS][ColS];
					}
				}
				//Take Movments.
				Table[ii][jj] = Table[i][j];
				Table[i][j] = 0;
				//Consider Check.
				ChessRules AA =  ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[ii][jj], Table, Order, ii, jj);
				if (AA.ObjectDangourKingMove(Order, Table, false))
				{
					ChessRules::CurrentOrder = CCurrentOrder;
					//Return ObjectDanger.
					if ((AA.CheckGrayObjectDangour) && Order == 1)
					{
						return true;
					}
					else
					{
						if ((AA.CheckBrownObjectDangour) && Order == -1)
						{
						return true;
						}
					}

				}
				if (AA.CheckMate(Table, Order))
				{
					ChessRules::CurrentOrder = CCurrentOrder;
					//Return ObjectDanger.
					if ((AA.CheckGray || AA.CheckMateGray) && Order == 1)
					{
						return true;
					}
					else
					{
						if ((AA.CheckBrown || AA.CheckMateBrown) && Order == -1)
						{
						return true;
						}
					}

				}
			}





			ChessRules::CurrentOrder = CCurrentOrder;
			//return Non ObjectDanger.
			return false;
		}
	}

	bool ThinkingChess::Support(int **Tab, int i, int j, int ii, int jj, int a, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			//Initiate Local Variables.
			int **Table = new int*[8]; for (int g = 0; g < 8; g++)Table[g] = new int[8];

			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					Table[RowS][ColS] = Tab[RowS][ColS];
				}
			}
			///When All Tables is Gray.
			if (Table[i][j] > 0 && Table[ii][jj] > 0)
			{
				///When [i,j] Supporte [ii,jj].
				if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[i][j], Table, Order, i, j))->Rules(i, j, ii, jj, a, Table[i][j], false))
				{

					return true;
				}

			}

			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					Table[RowS][ColS] = Tab[RowS][ColS];
				}
			}
			///When All is Brown.
			if (Table[i][j] < 0 && Table[ii][jj] < 0)
			{
				///When [i,j] Supporetd [ii,jj].
				if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[i][j], Table, Order, i, j))->Rules(i, j, ii, jj, a, Table[i][j], false))
				{
					return true;
				}
			}

			return false;
		}
	}

	bool ThinkingChess::MaxHuristic(int &j, int Kin, double &Less, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{





			bool Found = false;
			//When Solders.
			if (Kin == 1)
			{
				for (int i = 0; i < PenaltyRegardListSolder.size(); i++)
				{
					if (PenaltyRegardListSolder[i].IsPenaltyAction() != 0)
					{
						if (Order == AllDraw::OrderPlate)
						{
							if (Less > HuristicListSolder[i][0] + HuristicListSolder[i][1] + HuristicListSolder[i][2] + HuristicListSolder[i][3] + HuristicListSolder[i][4] + HuristicListSolder[i][5] + HuristicListSolder[i][6] + HuristicListSolder[i][7] + HuristicListSolder[i][8] + HuristicListSolder[i][9])
							{
								Less = HuristicListSolder[i][0] + HuristicListSolder[i][1] + HuristicListSolder[i][2] + HuristicListSolder[i][3] + HuristicListSolder[i][4] + HuristicListSolder[i][5] + HuristicListSolder[i][6] + HuristicListSolder[i][7] + HuristicListSolder[i][8] + HuristicListSolder[i][9];
								j = i;
								Found = true;
							}
						}
						else
						{
							if (Less < HuristicListSolder[i][0] + HuristicListSolder[i][1] + HuristicListSolder[i][2] + HuristicListSolder[i][3] + HuristicListSolder[i][4] + HuristicListSolder[i][5] + HuristicListSolder[i][6] + HuristicListSolder[i][7] + HuristicListSolder[i][8] + HuristicListSolder[i][9])
							{
								Less = HuristicListSolder[i][0] + HuristicListSolder[i][1] + HuristicListSolder[i][2] + HuristicListSolder[i][3] + HuristicListSolder[i][4] + HuristicListSolder[i][5] + HuristicListSolder[i][6] + HuristicListSolder[i][7] + HuristicListSolder[i][8] + HuristicListSolder[i][9];
								j = i;
								Found = true;
							}
						}

					}
				}

			}

			else //When Elephant.
			{
				if (Kin == 2)
				{
				for (int i = 0; i < PenaltyRegardListElefant.size(); i++)
				{
					if (PenaltyRegardListElefant[i].IsPenaltyAction() != 0)
					{
						if (Order == AllDraw::OrderPlate)
						{
							if (Less > HuristicListElefant[i][0] + HuristicListElefant[i][1] + HuristicListElefant[i][2] + HuristicListElefant[i][3] + HuristicListElefant[i][4] + HuristicListElefant[i][5] + HuristicListElefant[i][6] + HuristicListElefant[i][7] + HuristicListElefant[i][8] + HuristicListElefant[i][9])
							{
								Less = HuristicListElefant[i][0] + HuristicListElefant[i][1] + HuristicListElefant[i][2] + HuristicListElefant[i][3] + HuristicListElefant[i][4] + HuristicListElefant[i][5] + HuristicListElefant[i][6] + HuristicListElefant[i][7] + HuristicListElefant[i][8] + HuristicListElefant[i][9];
								j = i;
								Found = true;
							}
						}
						else
						{
							if (Less < HuristicListElefant[i][0] + HuristicListElefant[i][1] + HuristicListElefant[i][2] + HuristicListElefant[i][3] + HuristicListElefant[i][4] + HuristicListElefant[i][5] + HuristicListElefant[i][6] + HuristicListElefant[i][7] + HuristicListElefant[i][8] + HuristicListElefant[i][9])
							{
								Less = HuristicListElefant[i][0] + HuristicListElefant[i][1] + HuristicListElefant[i][2] + HuristicListElefant[i][3] + HuristicListElefant[i][4] + HuristicListElefant[i][5] + HuristicListElefant[i][6] + HuristicListElefant[i][7] + HuristicListElefant[i][8] + HuristicListElefant[i][9];
								j = i;
								Found = true;
							}
						}

					}
				}
				}
			else //When Hourse.
			{
					if (Kin == 3)
					{
				for (int i = 0; i < PenaltyRegardListHourse.size(); i++)
				{
					if (PenaltyRegardListHourse[i].IsPenaltyAction() != 0)
					{
						if (Order == AllDraw::OrderPlate)
						{
							if (Less > HuristicListHourse[i][0] + HuristicListHourse[i][1] + HuristicListHourse[i][2] + HuristicListHourse[i][3] + HuristicListHourse[i][4] + HuristicListHourse[i][5] + HuristicListHourse[i][6] + HuristicListHourse[i][7] + HuristicListHourse[i][8] + HuristicListHourse[i][9])
							{
								Less = HuristicListHourse[i][0] + HuristicListHourse[i][1] + HuristicListHourse[i][2] + HuristicListHourse[i][3] + HuristicListHourse[i][4] + HuristicListHourse[i][5] + HuristicListHourse[i][6] + HuristicListHourse[i][7] + HuristicListHourse[i][8] + HuristicListHourse[i][9];
								j = i;
								Found = true;
							}
						}
						else
						{
							if (Less < HuristicListHourse[i][0] + HuristicListHourse[i][1] + HuristicListHourse[i][2] + HuristicListHourse[i][3] + HuristicListHourse[i][4] + HuristicListHourse[i][5] + HuristicListHourse[i][6] + HuristicListHourse[i][7] + HuristicListHourse[i][8] + HuristicListHourse[i][9])
							{
								Less = HuristicListHourse[i][0] + HuristicListHourse[i][1] + HuristicListHourse[i][2] + HuristicListHourse[i][3] + HuristicListHourse[i][4] + HuristicListHourse[i][5] + HuristicListHourse[i][6] + HuristicListHourse[i][7] + HuristicListHourse[i][8] + HuristicListHourse[i][9];
								j = i;
								Found = true;
							}
						}

					}
				}
					}
			else //When Castles.
			{
						if (Kin == 4)
						{
				for (int i = 0; i < PenaltyRegardListCastle.size(); i++)
				{
					if (PenaltyRegardListCastle[i].IsPenaltyAction() != 0)
					{
						if (Order == AllDraw::OrderPlate)
						{
							if (Less > HuristicListCastle[i][0] + HuristicListCastle[i][1] + HuristicListCastle[i][2] + HuristicListCastle[i][3] + HuristicListCastle[i][4] + HuristicListCastle[i][5] + HuristicListCastle[i][6] + HuristicListCastle[i][7] + HuristicListCastle[i][8] + HuristicListCastle[i][9])
							{
								Less = HuristicListCastle[i][0] + HuristicListCastle[i][1] + HuristicListCastle[i][2] + HuristicListCastle[i][3] + HuristicListCastle[i][4] + HuristicListCastle[i][5] + HuristicListCastle[i][6] + HuristicListCastle[i][7] + HuristicListCastle[i][8] + HuristicListCastle[i][9];
								j = i;
								Found = true;
							}
						}
						else
						{
							if (Less < HuristicListCastle[i][0] + HuristicListCastle[i][1] + HuristicListCastle[i][2] + HuristicListCastle[i][3] + HuristicListCastle[i][4] + HuristicListCastle[i][5] + HuristicListCastle[i][6] + HuristicListCastle[i][7] + HuristicListCastle[i][8] + HuristicListCastle[i][9])
							{
								Less = HuristicListCastle[i][0] + HuristicListCastle[i][1] + HuristicListCastle[i][2] + HuristicListCastle[i][3] + HuristicListCastle[i][4] + HuristicListCastle[i][5] + HuristicListCastle[i][6] + HuristicListCastle[i][7] + HuristicListCastle[i][8] + HuristicListCastle[i][9];
								j = i;
								Found = true;
							}
						}
					}
				}
						}
			else //When Minister.
			{
							if (Kin == 5)
							{
				for (int i = 0; i < PenaltyRegardListMinister.size(); i++)
				{
					if (PenaltyRegardListMinister[i].IsPenaltyAction() != 0)
					{
						if (Order == AllDraw::OrderPlate)
						{
							if (Less > HuristicListMinister[i][0] + HuristicListMinister[i][1] + HuristicListMinister[i][2] + HuristicListMinister[i][3] + HuristicListMinister[i][4] + HuristicListMinister[i][5] + HuristicListMinister[i][6] + HuristicListMinister[i][7] + HuristicListMinister[i][8] + HuristicListMinister[i][9])
							{
								Less = HuristicListMinister[i][0] + HuristicListMinister[i][1] + HuristicListMinister[i][2] + HuristicListMinister[i][3] + HuristicListMinister[i][4] + HuristicListMinister[i][5] + HuristicListMinister[i][6] + HuristicListMinister[i][7] + HuristicListMinister[i][8] + HuristicListMinister[i][9];
								j = i;
								Found = true;
							}
						}
						else
						{
							if (Less < HuristicListMinister[i][0] + HuristicListMinister[i][1] + HuristicListMinister[i][2] + HuristicListMinister[i][3] + HuristicListMinister[i][4] + HuristicListMinister[i][5] + HuristicListMinister[i][6] + HuristicListMinister[i][7] + HuristicListMinister[i][8] + HuristicListMinister[i][9])
							{
								Less = HuristicListMinister[i][0] + HuristicListMinister[i][1] + HuristicListMinister[i][2] + HuristicListMinister[i][3] + HuristicListMinister[i][4] + HuristicListMinister[i][5] + HuristicListMinister[i][6] + HuristicListMinister[i][7] + HuristicListMinister[i][8] + HuristicListMinister[i][9];
								j = i;
								Found = true;
							}
						}
					}
				}
							}
			else //When King.
			{
								if (Kin == 6)
								{
				for (int i = 0; i < PenaltyRegardListKing.size(); i++)
				{
					if (PenaltyRegardListKing[i].IsPenaltyAction() != 0)
					{
						if (Order == AllDraw::OrderPlate)
						{
							if (Less > HuristicListKing[i][0] + HuristicListKing[i][1] + HuristicListKing[i][2] + HuristicListKing[i][3] + HuristicListKing[i][4] + HuristicListKing[i][5] + HuristicListKing[i][6] + HuristicListKing[i][7] + HuristicListKing[i][8] + HuristicListKing[i][9])
							{
								Less = HuristicListKing[i][0] + HuristicListKing[i][1] + HuristicListKing[i][2] + HuristicListKing[i][3] + HuristicListKing[i][4] + HuristicListKing[i][5] + HuristicListKing[i][6] + HuristicListKing[i][7] + HuristicListKing[i][8] + HuristicListKing[i][9];
								j = i;
								Found = true;
							}
						}
						else
						{
							if (Less < HuristicListKing[i][0] + HuristicListKing[i][1] + HuristicListKing[i][2] + HuristicListKing[i][3] + HuristicListKing[i][4] + HuristicListKing[i][5] + HuristicListKing[i][6] + HuristicListKing[i][7] + HuristicListKing[i][8] + HuristicListKing[i][9])
							{
								Less = HuristicListKing[i][0] + HuristicListKing[i][1] + HuristicListKing[i][2] + HuristicListKing[i][3] + HuristicListKing[i][4] + HuristicListKing[i][5] + HuristicListKing[i][6] + HuristicListKing[i][7] + HuristicListKing[i][8] + HuristicListKing[i][9];
								j = i;
								Found = true;
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
			return Found;
		}
	}
/*
	int ThinkingChess::SolderOnTableCount(DrawSoldier *So, bool Mi, int MaxCount)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			int Count = 0, i = 0;
			//For Alll Solders on int Calculate Solkder Count.
			while (i < MaxCount)
			{
				//The Index out of range exeption is not fixable.

					if (So != nullptr)
					{
						if (So[i] != nullptr)
						{
							//When int is Gray or Brown.
							if (So[i].color == 1 || So[i].color == -1)
							{
								if (Mi)
								{
									if (So[i].color == 1)
									{
										Count++;
									}
								}
								else
								{
									Count++;
								}
							}
							else
							{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
								delete So[i];
							}
						}
					}

				i++;

			};

			return Count;
		}
	}

	int ThinkingChess::ElefantOnTableCount(DrawElefant *So, bool Mi, int MaxCount)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{


			int Count = 0, i = 0;
			//For All Elephant items in Table.
			while (i < MaxCount)
			{

					//The Index out of range exeption is not fixable.
					if (So != nullptr)
					{
						if (So[i] != nullptr)
						{
							//when Elaphant int is Gray or Brown.
							if (So[i].color == 1 || So[i].color == -1)
							{
								if (Mi)
								{
									if (So[i].color == 1)
									{
										Count++;
									}
								}
								else
								{
									Count++;
								}
							}
							else
							{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
								delete So[i];
							}
						}
					}

				i++;
			};
			return Count;
		}
	}

	int ThinkingChess::HourseOnTableCount(DrawHourse *So, bool Mi, int MaxCount)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			int Count = 0, i = 0;
			while (i < MaxCount)
			{
				//For All Hourse on Table .
				//The Index out of range exeption is not fixable.

					if (So != nullptr)
					{
						if (So[i] != nullptr)
						{
							//When int is Gray or Brown.
							if (So[i].color == 1 || So[i].color == -1)
							{
								if (Mi)
								{
									if (So[i].color == 1)
									{
										Count++;
									}
								}
								else
								{
									Count++;
								}
							}
							else
							{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
								delete So[i];
							}
						}
					}

				i++;
			};

			return Count;
		}
	}

	int ThinkingChess::CastleOnTableCount(DrawCastle *So, bool Mi, int MaxCount)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			int Count = 0, i = 0;
			while (i < MaxCount)
			{

					//The Index out of range exeption is not fixable.
					if (So != nullptr)
					{
						if (So[i] != nullptr)
						{
							//When Castles int is Gray or Brown.
							if (So[i].color == 1 || So[i].color == -1)
							{
								if (Mi)
								{
									if (So[i].color == 1)
									{
										Count++;
									}
								}
								else
								{
									Count++;
								}
							}
							else
							{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
								delete So[i];
							}
						}
					}


				i++;
			};

			return Count;
		}
	}

	int ThinkingChess::MinisterOnTableCount(DrawMinister *So, bool Mi, int MaxCount)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			int Count = 0, i = 0;
			while (i < MaxCount)
			{

					//The Index out of range exeption is not fixable.
					if (So != nullptr)
					{
						if (So[i] != nullptr)
						{
							//When int of items is gray or Brown.
							if (So[i].color == 1 || So[i].color == -1)
							{
								if (Mi)
								{
									if (So[i].color == 1)
									{
										Count++;
									}
								}
								else
								{
									Count++;
								}
							}
							else
							{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
								delete So[i];
							}
						}
					}

				i++;
			};
			return Count;
		}
	}

	int ThinkingChess::KingOnTableCount(DrawKing *So, bool Mi, int MaxCount)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			int Count = 0, i = 0;
			while (i < MaxCount)
			{

					//The Index out of range exeption is not fixable.
					if (So != nullptr)
					{
						if (So[i] != nullptr)
						{
							//when int is Gray or Brown.
							if (So[i].color == 1 || So[i].color == -1)
							{
								if (Mi)
								{
									if (So[i].color == 1)
									{
										Count++;
									}
								}
								else
								{
									Count++;
								}
							}
							else
							{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
								delete So[i];
							}
						}
					}

				i++;
			};
			return Count;
		}
	}
*/
	double ThinkingChess::ReturnHuristic(int ii, int j, int Order, bool AA)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			AllDraw::OutPut = L"";
			//AllDraw.ActionStringReady = false;
			//NumbersOfCurrentBranchesPenalties = 0;
			//calculation of huristic methos and storing value retured.
			double Hur = double();
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				if (!AA)
				{
					if (ii >= 0 && UsePenaltyRegardMechnisamT)
					{
						Hur = ReturnHuristicCalculartor(0, ii, j, Order) * LearniningTable->LearingValue(Row, Column);
					}
					else
					{
						Hur = ReturnHuristicCalculartor(0, ii, j, Order);
					}
				}
				else
				{
					Hur = ReturnHuristicCalculartor(0, ii, j, Order) + 1000;
				}

				//Optimization depend of numbers of unpealties nodes quefficient.  
				if (UsePenaltyRegardMechnisamT)
				{
					return Hur * (static_cast<double>(NumbersOfAllNode - NumbersOfCurrentBranchesPenalties) / static_cast<double>(NumbersOfAllNode));
				}
				return Hur;

			}
		}
	}

	std::wstring ThinkingChess::Alphabet(int RowRealesed)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			std::wstring A = L"";
			if (RowRealesed == 0)
			{
				A = L"a";
			}
			else
			{
				if (RowRealesed == 1)
				{
				A = L"b";
				}
			else
			{
					if (RowRealesed == 2)
					{
				A = L"c";
					}
			else
			{
						if (RowRealesed == 3)
						{
				A = L"d";
						}
			else
			{
							if (RowRealesed == 4)
							{
				A = L"e";
							}
			else
			{
								if (RowRealesed == 5)
								{
				A = L"f";
								}
			else
			{
									if (RowRealesed == 6)
									{
				A = L"g";
									}
			else
			{
										if (RowRealesed == 7)
										{
				A = L"h";
										}
			}
			}
			}
			}
			}
			}
			}
			return A;
		}
	}

	std::wstring ThinkingChess::Number(int ColumnRealeased)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			std::wstring A = L"";
			if (ColumnRealeased == 7)
			{
				A = L"0";
			}
			else
			{
				if (ColumnRealeased == 6)
				{
				A = L"1";
				}
			else
			{
					if (ColumnRealeased == 5)
					{
				A = L"2";
					}
			else
			{
						if (ColumnRealeased == 4)
						{
				A = L"3";
						}
			else
			{
							if (ColumnRealeased == 3)
							{
				A = L"4";
							}
			else
			{
								if (ColumnRealeased == 2)
								{
				A = L"5";
								}
			else
			{
									if (ColumnRealeased == 1)
									{
				A = L"6";
									}
			else
			{
										if (ColumnRealeased == 0)
										{
				A = L"7";
										}
			}
			}
			}
			}
			}
			}
			}
			return A;
		}
	}

	double ThinkingChess::ReturnHuristicCalculartor(int iAstarGready, int ii, int j, int Order)
	{
		//bool ActionStringSetting = false;double[]
		//auto O = new Object();
		//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock(O)
		{
			double Huristic = 0;
			if (AStarGreedy.empty())
			{
				return 0;
			}
			NumbersOfCurrentBranchesPenalties += NumberOfPenalties;
			int DummyOrder = Order;
			if (ii != -1)
			{
				//return 0;
				/*SetObjectNumbers(TableConst);
				//NumbersOfCurrentBranchesPenalties = 0;

				int[] iIndex = { -1, -1, -1, -1, -1, -1 }, mIndex = { -1, -1, -1, -1, -1, -1 }, jIndex = { -1, -1, -1, -1, -1, -1 }, Kin = { 1, 2, 3, 4, 5, 6 };
				double[] Less = new double[6];
				if (Order == AllDraw.OrderPlate)
				{
				for (int i = 0; i < 6; i++)
				{
				Less[i] = new double();
				Less[i] = Double.MinValue;
				}
				}
				else
				{
				for (int i = 0; i < 6; i++)
				{
				Less[i] = new double();
				Less[i] = Double.MaxValue;
				}
				}
				iAstarGready++;
				//Calculate numbers of current branches penalties.

				//When is Gray.
				if (Order == 1)
				{
				//For All Depth Count.
				for (int i = 0; i < AStarGreedy.Count; i++)
				{
				//For All solder DrawOn Table Count.
				for (int m = 0; m < SolderOnTableCount(ref AStarGreedy[i].SolderesOnTable, true, AStarGreedy[i].SodierHigh); m++)
				for (int m = 0; m < AStarGreedy[i].SodierMidle; m++)
				{
				//When Depth of Solders On Table is Not NULL.
				if (AStarGreedy[i].SolderesOnTable[m] != null)
				{
				if (AStarGreedy[i].SolderesOnTable[m].SoldierThinking[0].IsSupHu[j])
				continue;
				//Calculate Maximum Huristic in Branch.
				if (AStarGreedy[i].SolderesOnTable[m].SoldierThinking[0].MaxHuristic(ref jIndex[0], Kin[0], ref Less[0], Order *-1))
				{
				iIndex[0] = i;
				mIndex[0] = m;
				Kin[0] = 1;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());


				}
				//For All Elephant On Table Count.
				for (int m = 0; m < ElefantOnTableCount(ref AStarGreedy[i].ElephantOnTable, true, AStarGreedy[i].ElefantHigh); m++)
				for (int m = 0; m < AStarGreedy[i].ElefantMidle; m++)
				{

				//For All Elephant in Depth Count.
				if (AStarGreedy[i].ElephantOnTable[m] != null)
				{
				if (AStarGreedy[i].ElephantOnTable[m].ElefantThinking[0].IsSupHu[j])
				continue;
				//Found of Maxmimum in Branch.
				if (AStarGreedy[i].ElephantOnTable[m].ElefantThinking[0].MaxHuristic(ref jIndex[1], Kin[1], ref Less[1], Order *-1))
				{
				iIndex[1] = i;
				mIndex[1] = m;
				Kin[1] = 2;
				//Huristic = Less;
				}
				//else
				// CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());


				}
				//For All Hourse on Table Count.
				for (int m = 0; m < HourseOnTableCount(ref AStarGreedy[i].HoursesOnTable, true, AStarGreedy[i].HourseHight); m++)
				for (int m = 0; m < AStarGreedy[i].HourseMidle; m++)
				{
				//When is HourseOn Table Depth Object is Not NULL.
				if (AStarGreedy[i].HoursesOnTable[m] != null)
				{
				if (AStarGreedy[i].HoursesOnTable[m].HourseThinking[0].IsSupHu[j])
				continue;
				//Forund of Maximum on on Branch.
				if (AStarGreedy[i].HoursesOnTable[m].HourseThinking[0].MaxHuristic(ref jIndex[2], Kin[2], ref Less[2], Order *-1))
				{
				iIndex[2] = i;
				mIndex[2] = m;
				Kin[2] = 3;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());


				}
				//For All Castles on table Count.
				for (int m = 0; m < CastleOnTableCount(ref AStarGreedy[i].CastlesOnTable, true, AStarGreedy[i].CastleHigh); m++)
				for (  int m = 0; m < AStarGreedy[i].CastleMidle; m++)
				{
				//When Depth Objects of Hourse Table is Not NULL.
				if (AStarGreedy[i].CastlesOnTable[m] != null)
				{
				if (AStarGreedy[i].CastlesOnTable[m].CastleThinking[0].IsSupHu[j])
				continue;
				//Found of Maximum Castles Branch.
				if (AStarGreedy[i].CastlesOnTable[m].CastleThinking[0].MaxHuristic(ref jIndex[3], Kin[3], ref Less[3], Order *-1))
				{
				iIndex[3] = i;
				mIndex[3] = m;
				Kin[3] = 4;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());


				}
				//For All Minsiter on table count.
				for (int m = 0; m < MinisterOnTableCount(ref AStarGreedy[i].MinisterOnTable, true, AStarGreedy[i].MinisterHigh); m++)
				for (int m = 0; m < AStarGreedy[i].MinisterMidle; m++)
				{
				//When Minster of Depth is Not Null.
				if (AStarGreedy[i].MinisterOnTable[m] != null)
				{
				if (AStarGreedy[i].MinisterOnTable[m].MinisterThinking[0].IsSupHu[j])
				continue;
				//Found of Maximum Minster on table Branches.
				if (AStarGreedy[i].MinisterOnTable[m].MinisterThinking[0].MaxHuristic(ref jIndex[4], Kin[4], ref Less[4], Order *-1))
				{
				iIndex[4] = i;
				mIndex[4] = m;
				Kin[4] = 5;
				//Huristic = Less;
				}
				}

				}
				//For All King on table Count.
				for (int m = 0; m < KingOnTableCount(ref AStarGreedy[i].KingOnTable, true, AStarGreedy[i].KingHigh); m++)
				for (int m = 0; m < AStarGreedy[i].KingMidle; m++)
				{
				//When Depth Object of King Table is Not NULL.
				if (AStarGreedy[i].KingOnTable[m] != null)
				{
				if (AStarGreedy[i].KingOnTable[m].KingThinking[0].IsSupHu[j])
				continue;
				//Found of Maximum on table Branches.
				if (AStarGreedy[i].KingOnTable[m].KingThinking[0].MaxHuristic(ref jIndex[5], Kin[5], ref Less[5], Order *-1))
				{
				iIndex[5] = i;
				mIndex[5] = m;
				Kin[5] = 6;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				// else
				// CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());


				}
				}

				}
				else
				{
				//For All Depth Variables.
				for (int i = 0; i < AStarGreedy.Count; i++)
				{
				//For All Brown Solders on table count.
				for (int m = SolderOnTableCount(ref AStarGreedy[i].SolderesOnTable, true, AStarGreedy[i].SodierHigh); m < SolderOnTableCount(ref AStarGreedy[i].SolderesOnTable, false, AStarGreedy[i].SodierHigh); m++)
				for (int m = AStarGreedy[i].SodierMidle; m < AStarGreedy[i].SodierHigh; m++)
				{
				//When solderis on table depth obejcts is nopt null.
				if (AStarGreedy[i].SolderesOnTable[m] != null)
				{
				if (AStarGreedy[i].SolderesOnTable[m].SoldierThinking[0].IsSupHu[j])
				continue;
				//Found of Maximum on Depth solders on table items.
				if (AStarGreedy[i].SolderesOnTable[m].SoldierThinking[0].MaxHuristic(ref jIndex[0], Kin[0], ref Less[0], Order *-1))
				{
				iIndex[0] = i;
				mIndex[0] = m;
				Kin[0] = 1;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				// else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				//For All Elephant On Table Count.
				for (int m = ElefantOnTableCount(ref AStarGreedy[i].ElephantOnTable, true, AStarGreedy[i].ElefantHigh); m < ElefantOnTableCount(ref AStarGreedy[i].ElephantOnTable, false, AStarGreedy[i].ElefantHigh); m++)
				for (int m = AStarGreedy[i].ElefantMidle; m < AStarGreedy[i].ElefantHigh; m++)
				{
				//For All Elephant in Depth Count.
				if (AStarGreedy[i].ElephantOnTable[m] != null)
				{
				if (AStarGreedy[i].ElephantOnTable[m].ElefantThinking[0].IsSupHu[j])
				continue;
				//Found of Maxmimum in Branch.
				if (AStarGreedy[i].ElephantOnTable[m].ElefantThinking[0].MaxHuristic(ref jIndex[1], Kin[1], ref Less[1], Order *-1))
				{
				iIndex[1] = i;
				mIndex[1] = m;
				Kin[1] = 2;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());


				}
				//For All Hourse on Table Count.
				for (int m = HourseOnTableCount(ref AStarGreedy[i].HoursesOnTable, true, AStarGreedy[i].HourseHight); m < HourseOnTableCount(ref AStarGreedy[i].HoursesOnTable, false, AStarGreedy[i].HourseHight); m++)
				for (int m = AStarGreedy[i].HourseMidle; m < AStarGreedy[i].HourseHight; m++)
				{
				//When is HourseOn Table Depth Object is Not NULL.
				if (AStarGreedy[i].HoursesOnTable[m] != null)
				{
				if (AStarGreedy[i].HoursesOnTable[m].HourseThinking[0].IsSupHu[j])
				continue;
				//Forund of Maximum on on Branch.
				if (AStarGreedy[i].HoursesOnTable[m].HourseThinking[0].MaxHuristic(ref jIndex[2], Kin[2], ref Less[2], Order *-1))
				{
				iIndex[2] = i;
				mIndex[2] = m;
				Kin[2] = 3;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//For All Castles on table Count.
				for (int m = CastleOnTableCount(ref AStarGreedy[i].CastlesOnTable, true, AStarGreedy[i].CastleHigh); m < CastleOnTableCount(ref AStarGreedy[i].CastlesOnTable, false, AStarGreedy[i].CastleHigh); m++)
				for (int m = AStarGreedy[i].CastleMidle; m < AStarGreedy[i].CastleHigh; m++)
				{
				//When Depth Objects of Hourse Table is Not NULL.
				if (AStarGreedy[i].CastlesOnTable[m] != null)
				{
				if (AStarGreedy[i].CastlesOnTable[m].CastleThinking[0].IsSupHu[j])
				continue;
				//Found of Maximum Castles Branch.
				if (AStarGreedy[i].CastlesOnTable[m].CastleThinking[0].MaxHuristic(ref jIndex[3], Kin[3], ref Less[3], Order *-1))
				{
				iIndex[3] = i;
				mIndex[3] = m;
				Kin[3] = 4;
				//Huristic = Less;
				}
				// else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				//For All Minsiter on table count.
				for (int m = MinisterOnTableCount(ref AStarGreedy[i].MinisterOnTable, true, AStarGreedy[i].MinisterHigh); m < MinisterOnTableCount(ref AStarGreedy[i].MinisterOnTable, false, AStarGreedy[i].MinisterHigh); m++)
				for (int m = AStarGreedy[i].MinisterMidle; m < AStarGreedy[i].MinisterHigh; m++)
				{
				//When Minster of Depth is Not Null.
				if (AStarGreedy[i].MinisterOnTable[m] != null)
				{
				if (AStarGreedy[i].MinisterOnTable[m].MinisterThinking[0].IsSupHu[j])
				continue;
				//Found of Maximum Minster on table Branches.
				if (AStarGreedy[i].MinisterOnTable[m].MinisterThinking[0].MaxHuristic(ref jIndex[4], Kin[4], ref Less[4], Order *-1))
				{
				iIndex[4] = i;
				mIndex[4] = m;
				Kin[4] = 5;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				//For All King on table Count.
				for (int m = KingOnTableCount(ref AStarGreedy[i].KingOnTable, true, AStarGreedy[i].KingHigh); m < KingOnTableCount(ref AStarGreedy[i].KingOnTable, false, AStarGreedy[i].KingHigh); m++)
				for (int m = AStarGreedy[i].KingMidle; m < AStarGreedy[i].KingHigh; m++)
				{
				//When Minster of Depth is Not Null.
				if (AStarGreedy[i].KingOnTable[m] != null)
				{
				if (AStarGreedy[i].KingOnTable[m].KingThinking[0].IsSupHu[j])
				continue;
				//When Depth Object of King Table is Not NULL.
				if (AStarGreedy[i].KingOnTable[m].KingThinking[0].MaxHuristic(ref jIndex[5], Kin[5], ref Less[5], Order * -1))
				{
				iIndex[5] = i;
				mIndex[5] = m;
				Kin[5] = 6;
				//Huristic = Less;
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());
				}
				//else
				//CodeClass.SaveByCode(2, callStack.GetFileLineNumber(), callStack.GetFileName());

				}
				}

				}
				*/
				if ((!(IsSupHu[j])) && j < IsSupHu.size() && j >= 0)
				{
					// int IJ = -1;
					// if (Order == AllDraw.OrderPlate)
					// IJ = MaxOfSixHuristic(Less) + 1;
					//else
					//IJ = MinOfSixHuristic(Less) + 1;
					// Calculate Huristic of Current Node.
					//When Sodleris Kind.
					//System.Math.Abs(Kind) == 1 &&
					for (j = 0; HuristicListSolder.size() > 0 && j < HuristicListSolder.size(); j++)
					{
						{
							//if (!ActionStringSetting)
							Huristic += HuristicListSolder[j][0] + HuristicListSolder[j][1] + HuristicListSolder[j][2] + HuristicListSolder[j][3] + HuristicListSolder[j][4] + HuristicListSolder[j][5] + HuristicListSolder[j][6] + HuristicListSolder[j][7] + HuristicListSolder[j][8] + HuristicListSolder[j][9];
							//auto O1 = new Object();
							//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock(O1)
							{
								ActionsString = std::wstring(L" ") + Alphabet(Row) + Number(Column) + Alphabet(RowColumnSoldier[j][0]) + Number(RowColumnSoldier[j][1]);
								if (Order == 1)
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Soldier AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
								else
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Soldier AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
							}
							//ActionStringSetting = true;
						}
					}

					//When Elephant Kind.
					for (j = 0; HuristicListElefant.size() > 0 && j < HuristicListElefant.size(); j++)
					{
						{
							//if (!ActionStringSetting)
							Huristic += HuristicListElefant[j][0] + HuristicListElefant[j][1] + HuristicListElefant[j][2] + HuristicListElefant[j][3] + HuristicListElefant[j][4] + HuristicListElefant[j][5] + HuristicListElefant[j][6] + HuristicListElefant[j][7] + HuristicListElefant[j][8] + HuristicListElefant[j][9];
							//auto O1 = new Object();
							//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock(O1)
							{
								ActionsString = std::wstring(L" ") + Alphabet(Row) + Number(Column) + Alphabet(RowColumnElefant[j][0]) + Number(RowColumnElefant[j][1]);
								if (Order == 1)
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Elephant AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
								else
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Elephant AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
							}

							//ActionStringSetting = true;
						}
					}
					for (j = 0; HuristicListHourse.size() > 0 && j < HuristicListHourse.size(); j++)
					{
						{
							//if (!ActionStringSetting)
							Huristic += HuristicListHourse[j][0] + HuristicListHourse[j][1] + HuristicListHourse[j][2] + HuristicListHourse[j][3] + HuristicListHourse[j][4] + HuristicListHourse[j][5] + HuristicListHourse[j][6] + HuristicListHourse[j][7] + HuristicListHourse[j][8] + HuristicListHourse[j][9];
							//auto O1 = new Object();
							//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock(O1)
							{
								ActionsString = std::wstring(L" ") + Alphabet(Row) + Number(Column) + Alphabet(RowColumnHourse[j][0]) + Number(RowColumnHourse[j][1]);
								if (Order == 1)
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Hourse AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
								else
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Hourse AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
							}

							//ActionStringSetting = true;
						}
					}
					for (j = 0; HuristicListCastle.size() > 0 && j < HuristicListCastle.size(); j++)
					{
						{
							//if (!ActionStringSetting)
							Huristic += HuristicListCastle[j][0] + HuristicListCastle[j][1] + HuristicListCastle[j][2] + HuristicListCastle[j][3] + HuristicListCastle[j][4] + HuristicListCastle[j][5] + HuristicListCastle[j][6] + HuristicListCastle[j][7] + HuristicListCastle[j][8] + HuristicListCastle[j][9];
							//auto O1 = new Object();
							//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock(O1)
							{
								ActionsString = std::wstring(L" ") + Alphabet(Row) + Number(Column) + Alphabet(RowColumnCastle[j][0]) + Number(RowColumnCastle[j][1]);
								if (Order == 1)
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Castle AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
								else
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Castle AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
							}

							//ActionStringSetting = true;
						}
					}
					for (j = 0; HuristicListMinister.size() > 0 && j < HuristicListMinister.size(); j++)
					{
						{
							//if (!ActionStringSetting)
							Huristic += HuristicListMinister[j][0] + HuristicListMinister[j][1] + HuristicListMinister[j][2] + HuristicListMinister[j][3] + HuristicListMinister[j][4] + HuristicListMinister[j][5] + HuristicListMinister[j][6] + HuristicListMinister[j][7] + HuristicListMinister[j][8] + HuristicListMinister[j][9];
							//auto O1 = new Object();
							//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock(O1)
							{
								ActionsString = std::wstring(L" ") + Alphabet(Row) + Number(Column) + Alphabet(RowColumnMinister[j][0]) + Number(RowColumnMinister[j][1]);
								if (Order == 1)
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Minister AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
								else
								{
									AllDraw::OutPut += std::wstring(L"\r\nHuristic Minister AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
								}
							}
							//ActionStringSetting = true;
						}
					}
					for (j = 0; HuristicListKing.size() > 0 && j < HuristicListKing.size(); j++)
					{
						{
							{
								//if (!ActionStringSetting)
								Huristic += HuristicListKing[j][0] + HuristicListKing[j][1] + HuristicListKing[j][2] + HuristicListKing[j][3] + HuristicListKing[j][4] + HuristicListKing[j][5] + HuristicListKing[j][6] + HuristicListKing[j][7] + HuristicListKing[j][8] + HuristicListKing[j][9];
								//auto O1 = new Object();
								//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock(O1)
								{
									ActionsString = std::wstring(L" ") + Alphabet(Row) + Number(Column) + Alphabet(RowColumnKing[j][0]) + Number(RowColumnKing[j][1]);
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic King AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic King AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ") + StringConverterHelper::toString(iAstarGready) + std::wstring(L" By Action String ") + ActionsString;
									}
								}
								//ActionStringSetting = true;
							}
						}
					}

				}
				else
				{
					return -DBL_MAX;
				}
				if (AStarGreedy.size() > 0)
				{
					for (int k = 0; k < AStarGreedy.size(); k++)
					{

						if ((&AStarGreedy[k]) == nullptr)
						{
							continue;
						}
						//auto OOO = new Object();
						//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock(OOO)
						{
							if (Order == -1)
							{
								//Repeate for Solder.
								for (int m = 0; m < AStarGreedy[k].SodierMidle; m++)
								{
									if ((&(AStarGreedy[k].SolderesOnTable) == nullptr) || (&(AStarGreedy[k].SolderesOnTable[m] )== nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Soldier AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Soldier AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].TableListSolder.size()); jj++)
									{
										Huristic += AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Elephant.
								for (int m = 0; m < AStarGreedy[k].ElefantMidle; m++)
								{
									if ((&(AStarGreedy[k].ElephantOnTable) == nullptr) || (&(AStarGreedy[k].ElephantOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Elephant AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Elephant AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].TableListElefant.size()); jj++)
									{
										Huristic += AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Hourse.
								for (int m = 0; m < AStarGreedy[k].HourseMidle; m++)
								{
									if ((&(AStarGreedy[k].HoursesOnTable) == nullptr) || (&(AStarGreedy[k].HoursesOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Hourse AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Hourse AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].TableListHourse.size()); jj++)
									{
										Huristic += AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Castles.
								for (int m = 0; m < AStarGreedy[k].CastleMidle; m++)
								{
									if ((&(AStarGreedy[k].CastlesOnTable) == nullptr) || (&(AStarGreedy[k].CastlesOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Castle AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Castle AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].TableListCastle.size()); jj++)
									{
										Huristic += AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Minstre.
								for (int m = 0; m < AStarGreedy[k].MinisterMidle; m++)
								{
									if ((&(AStarGreedy[k].MinisterOnTable) == nullptr) || (&(AStarGreedy[k].MinisterOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Minister AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Minister AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].TableListMinister.size()); jj++)
									{
										Huristic += AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for King.
								for (int m = 0; m < AStarGreedy[k].KingMidle; m++)
								{
									if ((&(AStarGreedy[k].KingOnTable) == nullptr) || (&(AStarGreedy[k].KingOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning King AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning King AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].KingOnTable[m].KingThinking[0].TableListKing.size()); jj++)
									{
										Huristic += AStarGreedy[k].KingOnTable[m].KingThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
							}
							else
							{
								for (int m = AStarGreedy[k].SodierMidle; m < AStarGreedy[k].SodierHigh; m++)
								{
									if ((&(AStarGreedy[k].SolderesOnTable) == nullptr) || (&(AStarGreedy[k].SolderesOnTable[m] )== nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Soldier AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Soldier AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].TableListSolder.size()); jj++)
									{
										Huristic += AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Elephant.
								for (int m = AStarGreedy[k].ElefantMidle; m < AStarGreedy[k].ElefantHigh; m++)
								{
									if ((&(AStarGreedy[k].ElephantOnTable) == nullptr) || (&(AStarGreedy[k].ElephantOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Elephant AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Elephant AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].TableListElefant.size()); jj++)
									{
										Huristic += AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Hourse.
								for (int m = AStarGreedy[k].HourseMidle; m < AStarGreedy[k].HourseHight; m++)
								{
									if ((&(AStarGreedy[k].HoursesOnTable) == nullptr) || (&(AStarGreedy[k].HoursesOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Hourse AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Hourse AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].TableListHourse.size()); jj++)
									{
										Huristic += AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Castles.
								for (int m = AStarGreedy[k].CastleMidle; m < AStarGreedy[k].CastleHigh; m++)
								{
									if ((&(AStarGreedy[k].CastlesOnTable) == nullptr) || (&(AStarGreedy[k].CastlesOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Castle AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Castle AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].TableListCastle.size()); jj++)
									{
										Huristic += AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for Minstre.
								for (int m = AStarGreedy[k].MinisterMidle; m < AStarGreedy[k].MinisterHigh; m++)
								{
									if ((&(AStarGreedy[k].MinisterOnTable) == nullptr) || (&(AStarGreedy[k].MinisterOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning Minister AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning Minister AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].TableListMinister.size()); jj++)
									{
										Huristic += AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
								//Repeate for King.
								for (int m = AStarGreedy[k].KingMidle; m < AStarGreedy[k].KingHigh; m++)
								{
									if ((&(AStarGreedy[k].KingOnTable) == nullptr) || (&(AStarGreedy[k].KingOnTable[m]) == nullptr))
									{
										continue;
									}
									if (Order == 1)
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deep Learning King AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at Level ");
									}
									else
									{
										AllDraw::OutPut += std::wstring(L"\r\nHuristic Deap Learning King AstarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at Level ");
									}
									for (int jj = 0; (jj < AStarGreedy[k].KingOnTable[m].KingThinking[0].TableListKing.size()); jj++)
									{
										Huristic += AStarGreedy[k].KingOnTable[m].KingThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jj, Order * -1);
									}
								}
							}
						}
					}

					//When Kind Found.
					//if (IJ != -1)

					{
						/*
						//Reapeate for Solders.
						if (//IJ == 1 &&
						AStarGreedy.Count > 0 && iIndex[0] != -1)
						Huristic += AStarGreedy[iIndex[0]].SolderesOnTable[mIndex[0]].SoldierThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jIndex[0], Order * -1);
						//Repeate for Elephant.
						if (//IJ == 2 &&
						AStarGreedy.Count > 0 && iIndex[1] != -1)
						Huristic += AStarGreedy[iIndex[1]].ElephantOnTable[mIndex[1]].ElefantThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jIndex[1], Order * -1);
						//Repeate for Hourse.
						if (//IJ == 3 &&
						AStarGreedy.Count > 0 && iIndex[2] != -1)
						Huristic += AStarGreedy[iIndex[2]].HoursesOnTable[mIndex[2]].HourseThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jIndex[2], Order * -1);
						//Repeate for Castles.
						if (//IJ == 4 &&
						AStarGreedy.Count > 0 && iIndex[3] != -1)
						Huristic += AStarGreedy[iIndex[3]].CastlesOnTable[mIndex[3]].CastleThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jIndex[3], Order * -1);
						//Repeate for Minstre.
						if (//IJ == 5 &&
						AStarGreedy.Count > 0 && iIndex[4] != -1)
						Huristic += AStarGreedy[iIndex[4]].MinisterOnTable[mIndex[4]].MinisterThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jIndex[4], Order * -1);
						//Repeate for King.
						if (//IJ == 6 &&
						AStarGreedy.Count > 0 && iIndex[5] != -1)
						Huristic += AStarGreedy[iIndex[5]].KingOnTable[mIndex[5]].KingThinking[0].ReturnHuristicCalculartor(iAstarGready, ii, jIndex[5], Order * -1);
						*/
					}
				}
			}
			else
			{
				if ((!(IsSup[j])) && j < IsSup.size() && j >= 0)
				{
					//When Solder Kind.
					if (abs(Kind) == 1 && HuristicListSolder.size() > 0)
					{
						Huristic += HuristicListSolder[j][0] + HuristicListSolder[j][1] + HuristicListSolder[j][2] + HuristicListSolder[j][3] + HuristicListSolder[j][4] + HuristicListSolder[j][5] + HuristicListSolder[j][6] + HuristicListSolder[j][7] + HuristicListSolder[j][8] + HuristicListSolder[j][9];

					}
					else
					{
						//When Elephant Kind.
						if (abs(Kind) == 2 && HuristicListElefant.size() > 0)
						{
							Huristic += HuristicListElefant[j][0] + HuristicListElefant[j][1] + HuristicListElefant[j][2] + HuristicListElefant[j][3] + HuristicListElefant[j][4] + HuristicListElefant[j][5] + HuristicListElefant[j][6] + HuristicListElefant[j][7] + HuristicListElefant[j][8] + HuristicListElefant[j][9];

						}
						else
						{
							//When Hourse Kind.
							if (abs(Kind) == 3 && HuristicListHourse.size() > 0)
							{
								Huristic += HuristicListHourse[j][0] + HuristicListHourse[j][1] + HuristicListHourse[j][2] + HuristicListHourse[j][3] + HuristicListHourse[j][4] + HuristicListHourse[j][5] + HuristicListHourse[j][6] + HuristicListHourse[j][7] + HuristicListHourse[j][8] + HuristicListHourse[j][9];
							}
							else
							{
								//When Castles Kind.
								if (abs(Kind) == 4 && HuristicListCastle.size() > 0)
								{
									Huristic += HuristicListCastle[j][0] + HuristicListCastle[j][1] + HuristicListCastle[j][2] + HuristicListCastle[j][3] + HuristicListCastle[j][4] + HuristicListCastle[j][5] + HuristicListCastle[j][6] + HuristicListCastle[j][7] + HuristicListCastle[j][8] + HuristicListCastle[j][9];
								}
								else
								{
									//When Minister Kind.
									if (abs(Kind) == 5 && HuristicListMinister.size() > 0)
									{
										Huristic += HuristicListMinister[j][0] + HuristicListMinister[j][1] + HuristicListMinister[j][2] + HuristicListMinister[j][3] + HuristicListMinister[j][4] + HuristicListMinister[j][5] + HuristicListMinister[j][6] + HuristicListMinister[j][7] + HuristicListMinister[j][8] + HuristicListMinister[j][9];
									}
									else
									{
										//When King Kind.
										if (abs(Kind) == 6 && HuristicListKing.size() > 0)
										{
											Huristic += HuristicListKing[j][0] + HuristicListKing[j][1] + HuristicListKing[j][2] + HuristicListKing[j][3] + HuristicListKing[j][4] + HuristicListKing[j][5] + HuristicListKing[j][6] + HuristicListKing[j][7] + HuristicListKing[j][8] + HuristicListKing[j][9];
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (Order == AllDraw::OrderPlate)
					{
						return -DBL_MAX;
					}
					else
					{
						return DBL_MAX;
					}
				}
			}
			Order = DummyOrder;
			return Huristic;
		}
	}


	bool ThinkingChess::Scop(int i, int j, int ii, int jj, int Kind)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			if (i == ii && j == jj)
			{
				return false;
			}
			//Scope of index out of range.
			if (i < 0)
			{
				return false;
			}
			if (j < 0)
			{
				return false;
			}
			if (ii < 0)
			{
				return false;
			}
			if (jj < 0)
			{
				return false;
			}
			if (i > 7)
			{
				return false;
			}
			if (j > 7)
			{
				return false;
			}
			if (ii > 7)
			{
				return false;
			}
			if (jj > 7)
			{
				return false;
			}

			bool Validity = false;
			//Scope on estimation on rule movment.
			if (Kind == 1) //Sodier
			{
				if (ArrangmentsChanged)
				{
					if (Order == 1)
					{
						if (j <= jj)
						{
							return false;
						}
					}
					else
					{
						if (j >= jj)
						{
							return false;
						}
					}
				}
				else if (!ArrangmentsChanged)
				{
					if (Order == -1)
					{
						if (j <= jj)
						{
							return false;
						}
					}
					else
					{
						if (j >= jj)
						{
							return false;
						}
					}
				}

				if (abs(i - ii) <= 2 && abs(j - jj) <= 2)

				{
					Validity = true;
				}
			}
			else
			{
				if (Kind == 2) //Elephant
				{
				if (abs(i - ii) == abs(j - jj))
				{

					Validity = true;
				}
				}
			else
			{
					if (Kind == 3) //Hourse
					{
				if (abs(i - ii) == 1 && abs(j - jj) == 2)
				{
					Validity = true;
				}
				if (abs(i - ii) == 2 && abs(j - jj) == 1)
				{
					Validity = true;
				}
					}
			else
			{
						if (Kind == 4) //Castle
						{
				if ((i == ii && j != jj) || (i != ii && j == jj))
				{
					Validity = true;
				}
						}
			else
			{
							if (Kind == 5) //Minister
							{
				if (((i == ii && j != jj) || (i != ii && j == jj)) || abs(i - ii) == abs(j - jj))
				{
					Validity = true;
				}
							}
			else
			{
		  if (Kind == 6) //King
		  {
				if (abs(i - ii) <= 1 && abs(j - jj) <= 1)
				{
					Validity = true;
				}
		  }
			}
			}
			}
			}
			}
			return Validity;
		}
	}

	int ThinkingChess::MaxOfSixHuristic(double Less[])
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Value = -1;
			double Les = -DBL_MAX;
			for (int i = 0; i < 6; i++)
			{
				if (Less[i] > Les)
				{
					Les = Less[i];
					Value = i;
				}
			}
			return Value;
		}
	}

	int ThinkingChess::MinOfSixHuristic(double Less[])
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int Value = -1;
			double Les = DBL_MAX;
			for (int i = 0; i < 6; i++)
			{
				if (Less[i] < Les)
				{
					Les = Less[i];
					Value = i;
				}
			}
			return Value;
		}
	}

	void ThinkingChess::KingThinkingChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///When There is Movments.
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[RowSource][ColumnSource], TableS, Order, RowSource, ColumnSource))->Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource][ColumnSource], false))
			{

					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					ThinkingAtRun = true;
					int CheckedM = 0;

					bool Sup = false;
				if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
				{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
				}
				else
				{
				if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
				{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
				}
				else
				{
					IsSup.push_back(false);
					IsSupHu.push_back(false);
					Sup = false;
				}
				}
					if (!Sup)
					{

						///Add Table to List of Private.
						HitNumberKing.push_back(TableS[RowDestination][ColumnDestination]);

						////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (OO)
						{
							ThinkingRun = true;
						}
					}
					///Predict Huristic.
					////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A)
					{
						//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
					}
					////auto A1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A1)
					{
						if (!Sup)
						{
							NumbersOfAllNode++;
						}
					}
					int Killed = 0;
					if (!Sup)
					{
						////auto A2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A2)
						{
							Killed = TableS[RowDestination][ColumnDestination];
							TableS[RowDestination][ColumnDestination] = TableS[RowSource][ColumnSource];
							TableS[RowSource][ColumnSource] = 0;
						}
					}



					{
				   // if (!Sup)
						////auto A3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A3)
						{
							PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 6, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);
							//{ ThinkingAtRun = false; return; }
						}
					}

					///Store of Indexes Changes and Table in specific List.
					if (!Sup)
					{
						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnKing.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListKing.push_back(CloneATable(TableS));
							IndexKing++;
						}
					}
					///Wehn Predict of Operation Do operate a Predict of this movments.
					////auto A5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A5)
					{
						//Caused this for Stachostic results.
						if (!Sup)
						{
							CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
						}
					}

					//Calculate Huristic and Add to List and Cal Syntax.
					if (!Sup)
					{
						std::wstring H = L"";
						////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A6)
						{
							double Hu[10];
							//if (!(IsSup[j]))
							{
								HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
								if (IgnoreFromCheckandMateHuristic)
								{
									HuristicObjectDangourCheckMateValue = 0;
								}
								Hu[0] += HuristicAttackValue;
								Hu[1] += HuristicMovementValue;
								Hu[2] += HuristicSelfSupportedValue;
								Hu[3] += HuristicObjectDangourCheckMateValue;
								Hu[4] += HuristicKillerValue;
								Hu[5] += HuristicReducedAttackValue;
								Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
								Hu[7] += HeuristicKingSafe;
								Hu[8] = HeuristicFromCenter;
								Hu[9] = HeuristicKingDangour;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
								H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
								HuristicListKing.push_back(Hu);
							}
							/*else
							{
							    HuristicPenaltyValuePerform(Current, Order,  HuristicAttackValue);
							    if (IgnoreFromCheckandMateHuristic)
							        HuristicObjectDangourCheckMateValue = 0;
							    Hu[0] += HuristicAttackValue + HuristicAttackValueSup;
							    HuristicAttackValueSup = 0;
							    Hu[1] += HuristicMovementValue + HuristicMovementValueSup;
							    HuristicMovementValueSup = 0;
							    Hu[2] += HuristicSelfSupportedValue + HuristicSelfSupportedValueSup;
							    HuristicSelfSupportedValueSup = 0;
							    Hu[3] += HuristicObjectDangourCheckMateValue + HuristicObjectDangourCheckMateValueSup;
							    HuristicObjectDangourCheckMateValueSup = 0;
							    Hu[4] += HuristicKillerValue + HuristicKillerValueSup;
							    HuristicKillerValueSup = 0;
							    Hu[5] += HuristicReducedAttackValue + HuristicReducedAttackValueSup;
							    HuristicReducedAttackValueSup = 0;
							    Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue + HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							    HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							    Hu[7] += HeuristicKingSafe + HeuristicKingSafeSup;
							    HeuristicKingSafeSup = 0;
							    Hu[8] = HeuristicFromCenter + HeuristicFromCenterSup;
							    HeuristicFromCenterSup = 0;
							    Hu[9] = HeuristicKingDangour + HeuristicKingDangourSup;
							    HeuristicKingDangourSup = 0;
							    H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
							    HuristicListKing.Add(Hu);
							    IsSup = false;
							}*/
						}
						////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O4)
						{
							/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
							if (Order == 1)
							    AllDraw.OutPut +="\r\nThinking King AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
							else
							    AllDraw.OutPut +="\r\nThinking King AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
							*/	ThinkingLevel++;
							ThinkingAtRun = false;
						}
					}
					else
					{
						HuristicAttackValueSup += HuristicAttackValue;
						HuristicMovementValueSup += HuristicMovementValue;
						HuristicSelfSupportedValueSup += HuristicSelfSupportedValue;
						HuristicObjectDangourCheckMateValueSup += HuristicObjectDangourCheckMateValue;
						HuristicKillerValueSup += HuristicKillerValue;
						HuristicReducedAttackValueSup += HuristicReducedAttackValue;
						HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
						HeuristicKingSafeSup += HeuristicKingSafe;
						HeuristicFromCenterSup += HeuristicFromCenter;
						HeuristicKingDangourSup += HeuristicKingDangour;
						double Hu[10];
						Hu[0] = HuristicAttackValueSup;
						//HuristicAttackValueSup = 0;
						Hu[1] = HuristicMovementValueSup;
						//HuristicMovementValueSup = 0;
						Hu[2] = HuristicSelfSupportedValueSup;
						//HuristicSelfSupportedValueSup = 0;
						Hu[3] = HuristicObjectDangourCheckMateValueSup;
						//HuristicObjectDangourCheckMateValueSup = 0;
						Hu[4] = HuristicKillerValueSup;
						//HuristicKillerValueSup = 0;
						Hu[5] = HuristicReducedAttackValueSup;
						//HuristicReducedAttackValueSup = 0;
						Hu[6] = HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
						//HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
						Hu[7] = HeuristicKingSafeSup;
						//HeuristicKingSafeSup = 0;
						Hu[8] = HeuristicFromCenterSup;
						//HeuristicFromCenterSup = 0;
						Hu[9] = HeuristicKingDangourSup;
						//HeuristicKingDangourSup = 0;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
						std::wstring H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);

					////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A4)
					{
						 int AS[2];
						AS[0] = RowDestination;
						AS[1] = ColumnDestination;
						RowColumnKing.push_back(AS);
						//RowColumn[Index, 0] = RowDestination;
						//RowColumn[Index, 1] = ColumnDestination;
						//Index+=1;
						TableListKing.push_back(CloneATable(TableS));
						IndexKing++;

						HuristicListKing.push_back(Hu);

						HitNumberKing.push_back(TableS[RowDestination][ColumnDestination]);
					}



					/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
					    if (Order == 1)
					        AllDraw.OutPut +="\r\nThinking King AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    else
					        AllDraw.OutPut +="\r\nThinking King AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    */
					ThinkingAtRun = false;
					}



			}
		}
		ThinkingAtRun = false;
	}

	std::wstring ThinkingChess::CheM(int A)
	{
		std::wstring AA = L"";
		if (A <= -1 && A < 0)
		{
			AA = L"+SelfChecked ";
		}

		if (A >= 1 && A > 0)
		{
			AA = L"+EnemeyChecked ";
		}

		if (A <= -2 && A < 0)
		{
			AA = L"++SelfMate ";
		}

		if (A >= 2 && A > 0)
		{
			AA = L"++EnemeyMate ";
		}

		if (A <= -3 && A < 0)
		{
			AA = L"++SelfFinished ";
		}

		if (A >= 3 && A > 0)
		{
			AA = L"++EnemeyFinsished ";
		}
		return AA;
	}

	void ThinkingChess::MinisterThinkingChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto O11 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O11)
		{

			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///When There is Movments.
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[RowSource][ColumnSource], TableS, Order, RowSource, ColumnSource))->Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource][ColumnSource], false))
			{

					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					ThinkingAtRun = true;
					int CheckedM = 0;

					bool Sup = false;
				if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
				{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
				}
				else
				{
			if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
			{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
			}
				else
				{
					IsSup.push_back(false);
					IsSupHu.push_back(false);
					Sup = false;
				}
				}
				if (!Sup)
				{

						///Add Table to List of Private.
						HitNumberMinister.push_back(TableS[RowDestination][ColumnDestination]);

						////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (OO)
						{
							ThinkingRun = true;
						}
				}
					///Predict Huristic.
					////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A)
					{
						//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
					}
					////auto A1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A1)
					{
						if (!Sup)
						{
							NumbersOfAllNode++;
						}
					}
					int Killed = 0;
					if (!Sup)
					{
						////auto A2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A2)
						{
							Killed = TableS[RowDestination][ColumnDestination];
							TableS[RowDestination][ColumnDestination] = TableS[RowSource][ColumnSource];
							TableS[RowSource][ColumnSource] = 0;
						}
					}



					{
				   // if (!Sup)
						////auto A3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A3)
						{
							PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 5, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);
							//{ ThinkingAtRun = false; return; }
						}
					}

					///Store of Indexes Changes and Table in specific List.
					if (!Sup)
					{
						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnMinister.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListMinister.push_back(CloneATable(TableS));
							IndexMinister++;
						}
					}
					///Wehn Predict of Operation Do operate a Predict of this movments.
					////auto A5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A5)
					{
						//Caused this for Stachostic results.
						if (!Sup)
						{
							CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
						}
					}

					//Calculate Huristic and Add to List and Cal Syntax.
					if (!Sup)
					{
						std::wstring H = L"";
						////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A6)
						{
							double Hu[10];
							//if (!(IsSup[j]))
							{
								HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
								if (IgnoreFromCheckandMateHuristic)
								{
									HuristicObjectDangourCheckMateValue = 0;
								}
								Hu[0] += HuristicAttackValue;
								Hu[1] += HuristicMovementValue;
								Hu[2] += HuristicSelfSupportedValue;
								Hu[3] += HuristicObjectDangourCheckMateValue;
								Hu[4] += HuristicKillerValue;
								Hu[5] += HuristicReducedAttackValue;
								Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
								Hu[7] += HeuristicKingSafe;
								Hu[8] = HeuristicFromCenter;
								Hu[9] = HeuristicKingDangour;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
								H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
								HuristicListMinister.push_back(Hu);
							}
							/*else
							{
							    HuristicPenaltyValuePerform(Current, Order,  HuristicAttackValue);
							    if (IgnoreFromCheckandMateHuristic)
							        HuristicObjectDangourCheckMateValue = 0;
							    Hu[0] += HuristicAttackValue + HuristicAttackValueSup;
							    //HuristicAttackValueSup = 0;
							    Hu[1] += HuristicMovementValue + HuristicMovementValueSup;
							    //HuristicMovementValueSup = 0;
							    Hu[2] += HuristicSelfSupportedValue + HuristicSelfSupportedValueSup;
							    //HuristicSelfSupportedValueSup = 0;
							    Hu[3] += HuristicObjectDangourCheckMateValue + HuristicObjectDangourCheckMateValueSup;
							    //HuristicObjectDangourCheckMateValueSup = 0;
							    Hu[4] += HuristicKillerValue + HuristicKillerValueSup;
							    //HuristicKillerValueSup = 0;
							    Hu[5] += HuristicReducedAttackValue + HuristicReducedAttackValueSup;
							    //HuristicReducedAttackValueSup = 0;
							    Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue + HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							    //HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							    Hu[7] += HeuristicKingSafe + HeuristicKingSafeSup;
							    //HeuristicKingSafeSup = 0;
							    Hu[8] = HeuristicFromCenter + HeuristicFromCenterSup;
							    //HeuristicFromCenterSup = 0;
							    Hu[9] = HeuristicKingDangour + HeuristicKingDangourSup;
							    //HeuristicKingDangourSup = 0;
							    H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
							    HuristicListMinister.Add(Hu);
							    IsSup = false;
							}*/
						}
						////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O4)
						{
							/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
							if (Order == 1)
							    AllDraw.OutPut +="\r\nThinking Minister AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
							else
							    AllDraw.OutPut +="\r\nThinking Minister AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
							*/	ThinkingLevel++;
							ThinkingAtRun = false;
						}
					}
					else
					{
						HuristicAttackValueSup += HuristicAttackValue;
						HuristicMovementValueSup += HuristicMovementValue;
						HuristicSelfSupportedValueSup += HuristicSelfSupportedValue;
						HuristicObjectDangourCheckMateValueSup += HuristicObjectDangourCheckMateValue;
						HuristicKillerValueSup += HuristicKillerValue;
						HuristicReducedAttackValueSup += HuristicReducedAttackValue;
						HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
						HeuristicKingSafeSup += HeuristicKingSafe;
						HeuristicFromCenterSup += HeuristicFromCenter;
						HeuristicKingDangourSup += HeuristicKingDangour;
						double Hu[10];
						Hu[0] = HuristicAttackValueSup;
						//HuristicAttackValueSup = 0;
						Hu[1] = HuristicMovementValueSup;
						//HuristicMovementValueSup = 0;
						Hu[2] = HuristicSelfSupportedValueSup;
						//HuristicSelfSupportedValueSup = 0;
						Hu[3] = HuristicObjectDangourCheckMateValueSup;
						//HuristicObjectDangourCheckMateValueSup = 0;
						Hu[4] = HuristicKillerValueSup;
						//HuristicKillerValueSup = 0;
						Hu[5] = HuristicReducedAttackValueSup;
						//HuristicReducedAttackValueSup = 0;
						Hu[6] = HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
						//HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
						Hu[7] = HeuristicKingSafeSup;
						//HeuristicKingSafeSup = 0;
						Hu[8] = HeuristicFromCenterSup;
						//HeuristicFromCenterSup = 0;
						Hu[9] = HeuristicKingDangourSup;
						//HeuristicKingDangourSup = 0;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
						std::wstring H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);


					////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A4)
					{
						 int AS[2];
						AS[0] = RowDestination;
						AS[1] = ColumnDestination;
						RowColumnMinister.push_back(AS);
						//RowColumn[Index, 0] = RowDestination;
						//RowColumn[Index, 1] = ColumnDestination;
						//Index+=1;
						TableListMinister.push_back(CloneATable(TableS));
						IndexMinister++;

						HuristicListMinister.push_back(Hu);

						HitNumberMinister.push_back(TableS[RowDestination][ColumnDestination]);

					}
					/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
					    if (Order == 1)
					        AllDraw.OutPut +="\r\nThinking Minister AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    else
					        AllDraw.OutPut +="\r\nThinking Minster AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    */
					ThinkingAtRun = false;
					}


			}
		}
		ThinkingAtRun = false;
	}

	bool ThinkingChess::IsPrviousMovemntIsDangrousForCurrent(int **TableS, int Order)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Dang = false;
			int BREAK = 0;
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				//.Current
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						BREAK = 0;
						if (Order == 1 && TableS[i][j] <= 0)
						{
							continue;
						}
						else
						{
							if (Order == -1 && TableS[i][j] >= 0)
							{
							continue;
							}
						}
						//Enemy
						for (int ii = 0; ii < 8; ii++)
						{
							for (int jj = 0; jj < 8; jj++)
							{
								BREAK = 0;
								if (Order == 1 && TableS[ii][jj] >= 0)
								{
									continue;
								}
								else
								{
									if (Order == -1 && TableS[ii][jj] <= 0)
									{
									continue;
									}
								}
								int a = 1;
								if (Order * -1 == -1)
								{
									a = -1;
								}
								if (Attack(TableS, ii, jj, i, j, a, Order * -1))
								{
									BREAK = 1;
									//Current
									for (int RowS = 0; RowS < 8; RowS++)
									{
										for (int ColS = 0; ColS < 8; ColS++)
										{
											BREAK = 0;
											if (Order == 1 && TableS[RowS][ColS] <= 0)
											{
												continue;
											}
											else
											{
												if (Order == -1 && TableS[RowS][ColS] >= 0)
												{
												continue;
												}
											}
											a = 1;
											if (Order == -1)
											{
												a = -1;
											}
											if (Support(TableS, RowS, ColS, i, j, a, Order))
											{
												BREAK = 2;
												break;
											}
										}
										if (BREAK == 2)
										{
											break;
										}
									}
								}
								if (BREAK == 1)
								{
									break;
								}

							}
							if (BREAK == 1)
							{
								break;
							}

						}
						if (BREAK == 1)
						{
							break;
						}

					}
					if (BREAK == 1)
					{
						break;
					}

				}
				if (BREAK == 1)
				{
					Dang = true;
				}
			}
			return Dang;
		}
	}

	bool ThinkingChess::IsObjectValaubleObjectSelf(int i, int j, int Object, std::vector<int*> &ValuableSelfSupported)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = true;
			for (int k = 0; k < ValuableSelfSupported.size(); k++)
			{
				if (ValuableSelfSupported[k][0] > 0 && Object > 0)
				{
					if (abs(ValuableSelfSupported[k][0]) > abs(Object))
					{
						Is = false;
					}
				}
				else
				{
				   if (ValuableSelfSupported[k][0] < 0 && Object < 0)
				   {
					if (abs(ValuableSelfSupported[k][0]) > abs(Object))
					{
						Is = false;
					}
				   }
				}
				if (Is == false)
				{
					break;
				}
			}
			return Is;
		}
	}

	bool ThinkingChess::IsObjectValaubleObjectEnemy(int i, int j, int Object, std::vector<int*> &ValuableEnemyNotSupported)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			bool Is = true;
			for (int k = 0; k < ValuableEnemyNotSupported.size(); k++)
			{
				if (abs(ValuableEnemyNotSupported[k][0]) < abs(Object))
				{
					Is = false;
					break;
				}
			}
			return Is;
		}
	}

	bool *ThinkingChess::SomeLearningVarsCalculator(int **TableS, int ik, int jk, int iik, int jjk)
	{
		////auto O22 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O22)
		{

			int AttackCount = 0;

			bool LearningV[3];
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				////Parallel.For(0, 8, i =>
				for (int i = 0; i < 8; i++)
				{
					if ((LearningV[0] || LearningV[1] || LearningV[2]))
					{
						continue;
					}
					////Parallel.For(0, 8, j =>
					for (int j = 0; j < 8; j++)
					{
						if ((LearningV[0] || LearningV[1] || LearningV[2]))
						{
							continue;
						}
						////Parallel.For(0, 8, RowS =>
						for (int RowS = 0; RowS < 8; RowS++)
						{
							if ((LearningV[0] || LearningV[1] || LearningV[2]))
							{
								continue;
							}

							////Parallel.For(0, 8, ColS =>
							for (int ColS = 0; ColS < 8; ColS++)
							{
								if ((LearningV[0] || LearningV[1] || LearningV[2]))
								{
									continue;
								}

								{
								//Parallel.Invoke(() =>

									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										if (!(LearningV[0] || LearningV[1] || LearningV[2]))
										{
											LearningV[0] = LearningV[0] || InAttackSelfThatNotSupportedAll(TableS, Order, color, i, j, RowS, ColS, ik, jk, iik, jjk);
										}
									}
								} //, () =>
								{

									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										if ((LearningV[0] || LearningV[1] || LearningV[2]))
										{
											continue;
										}

										if (AttackCount <= 1 && (!(LearningV[0] || LearningV[1] || LearningV[2])))
										{
											AttackCount = AttackCount + IsNotSafeToMoveAenemeyToAttackMoreThanTowObject(AttackCount, TableS, Order, i, j, RowS, ColS); //, ii, jj, RowD, ColD
										}
										else
										{
										if (!(LearningV[0] || LearningV[1] || LearningV[2]))
										{
											LearningV[1] = true;
										}
										}
									}
								} //, () =>
								{
									////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										if (!(LearningV[0] || LearningV[1] || LearningV[2]))
										{
											LearningV[2] = LearningV[2] || IsGardForCurrentMovmentsAndIsNotMovable(TableS, Order, color, i, j, RowS, ColS); //, ii, jj, RowD, ColD
										}
									}
								} //);
							} //);

						} //);
					} //);
				} //);
			}
			return LearningV;
		}
	}

	bool *ThinkingChess::CalculateLearningVars(int Killed, int **TableS, int i, int j, int ii, int jj)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool LearningV[14];

			bool IsCurrentCanGardHighPriorityEne = bool();
			bool IsNextMovemntIsCheckOrCheckMateForCurrent = bool();
			bool IsDangerous = bool();
			bool CanKillerAnUnSupportedEnemy = bool();
			bool InDangrousUnSupported = bool();
			bool Support = bool();
			bool IsNextMovemntIsCheckOrCheckMateForEnemy = bool();
			bool IsPrviousMovemntIsDangrousForCurr = bool();
			bool PDo = bool();
			bool RDo = bool();
			bool SelfNotSupported = bool();
			bool EnemyNotSupported = bool();
			bool IsGardForCurrentMovmentsAndIsNotMova = bool();
			bool IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = bool();

			bool P = bool();
			bool R = bool();
			bool IsTowValuableObjectEnemy = false;
			std::vector<int*> ValuableEnemyNotSupported = std::vector<int*>();
			std::vector<int*> ValuableSelfSupported = std::vector<int*>();

			//When true must penalty
			////auto O11 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O11)
			{
				IsPrviousMovemntIsDangrousForCurr = IsPrviousMovemntIsDangrousForCurrent(TableS, Order);
				//when true must penalty
				if (!IsPrviousMovemntIsDangrousForCurr)
				{
					SelfNotSupported = InAttackSelfThatNotSupported(TableS, Order, color, i, j, ii, jj);
				}
				//when true must regard

				Support = false;
				int SelfChackedMateDepth = 0;
				int EnemyCheckedMateDepth = 0;

				IsDangerous = false; //No Needed.
									//For All Current
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: bool* LearningVars = SomeLearningVarsCalculator(TableS, ii, jj, i, j);
				bool *LearningVars = SomeLearningVarsCalculator(TableS, ii, jj, i, j);
				////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O4)
				{
					SelfNotSupported = LearningVars[0];
					IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = LearningVars[1];
					IsGardForCurrentMovmentsAndIsNotMova = LearningVars[2];
				}
				if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!IsDangerous))
				{
					int *Is = new int[4];

					Is[0] = 0;
					Is[1] = 0;
					Is[2] = 0;
					Is[3] = 0;
					if (CurrentAStarGredyMax == 0)
					{
						int Depth = int();
						Depth = 0;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Tab = CloneATable(TableS);
						int **Tab = CloneATable(TableS);
						int Ord = Order;
						int a = color;
						int Ord1 = AllDraw::OrderPlate;
						int Ord2 = AllDraw::OrderPlate * -1;
						//when is true must penalty(Superposition)
						Is = IsNextMovmentIsCheckOrCheckMateForCurrentMovment(Tab, Ord, a, Depth, Ord1, Ord2, true);
						//A

					}
					////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (OO1)
					{
						if (Is[0] >= 1)
						{
							IsNextMovemntIsCheckOrCheckMateForCurrent = true;
						}
						else
						{
							IsNextMovemntIsCheckOrCheckMateForCurrent = false;
						}
						if (Is[2] >= 1)
						{
							IsNextMovemntIsCheckOrCheckMateForEnemy = true;
						}
						else
						{
							IsNextMovemntIsCheckOrCheckMateForEnemy = false;
						}
						SelfChackedMateDepth = Is[1];
						EnemyCheckedMateDepth = Is[3];
					}

				}
				//Order Depth Consideration Constraint.
				if (IsNextMovemntIsCheckOrCheckMateForCurrent && IsNextMovemntIsCheckOrCheckMateForEnemy)
				{
					////auto OO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (OO2)
					{
						if (SelfChackedMateDepth < EnemyCheckedMateDepth)
						{
							IsNextMovemntIsCheckOrCheckMateForEnemy = false;
						}
						else
						{
						if (SelfChackedMateDepth > EnemyCheckedMateDepth)
						{
							IsNextMovemntIsCheckOrCheckMateForCurrent = false;
						}
						}
					}
				}
				if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!IsDangerous))
				{
					EnemyNotSupported = InAttackEnemyThatIsNotSupportedAll(IsTowValuableObjectEnemy, TableS, Order, color, i, j, ii, jj, ValuableEnemyNotSupported);
				}
				if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!EnemyNotSupported) && (!IsDangerous))
				{
					EnemyNotSupported = InAttackEnemyThatIsNotSupported(Killed, TableS, Order, color, i, j, ii, jj);
				}
				if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!EnemyNotSupported) && (!IsDangerous))
				{
					EnemyNotSupported = InAttackEnemyThatIsNotSupportedAll(IsTowValuableObjectEnemy, TableS, Order, color, i, j, ii, jj, ValuableEnemyNotSupported);
				}
				if (CurrentAStarGredyMax == 0 && (!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!EnemyNotSupported) && (!IsDangerous))
				{
					//when is true must regard.
					IsCurrentCanGardHighPriorityEne = IsCurrentCanGardHighPriorityEnemy(0, TableS, Order, color, i, j, ii, jj, Order);
				}
				if (SelfNotSupported || IsNextMovemntIsCheckOrCheckMateForCurrent || IsPrviousMovemntIsDangrousForCurr || IsGardForCurrentMovmentsAndIsNotMova && IsDangerous)
				{
					IsCurrentCanGardHighPriorityEne = false;
					EnemyNotSupported = false;
					IsNextMovemntIsCheckOrCheckMateForEnemy = false;
				}
				////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (OO)
				{
					LearningV[0] = IsCurrentCanGardHighPriorityEne;
					LearningV[1] = IsNextMovemntIsCheckOrCheckMateForCurrent;
					LearningV[2] = IsDangerous;
					LearningV[3] = CanKillerAnUnSupportedEnemy;
					LearningV[4] = InDangrousUnSupported;
					LearningV[5] = Support;
					LearningV[6] = IsNextMovemntIsCheckOrCheckMateForEnemy;
					LearningV[7] = IsPrviousMovemntIsDangrousForCurr;
					LearningV[8] = PDo;
					LearningV[9] = RDo;
					LearningV[10] = SelfNotSupported;
					LearningV[11] = EnemyNotSupported;
					LearningV[12] = IsGardForCurrentMovmentsAndIsNotMova;
					LearningV[13] = IsNotSafeToMoveAenemeyToAttackMoreThanTowObj;
					if (IsNextMovemntIsCheckOrCheckMateForCurrent)
					{
						IgnoreFromCheckandMateHuristic = true;
					}
					CanKillerAnUnSupportedEnemy = Support || EnemyNotSupported || IsCurrentCanGardHighPriorityEne || IsNextMovemntIsCheckOrCheckMateForEnemy || IsNextMovemntIsCheckOrCheckMateForCurrent; //B
					P = IsNotSafeToMoveAenemeyToAttackMoreThanTowObj || IsGardForCurrentMovmentsAndIsNotMova || IsPrviousMovemntIsDangrousForCurr || SelfNotSupported || IsDangerous || IsCurrentCanGardHighPriorityEne || IsNextMovemntIsCheckOrCheckMateForEnemy || IsNextMovemntIsCheckOrCheckMateForCurrent; //C
					R = CanKillerAnUnSupportedEnemy; //D
					InDangrousUnSupported = P && (!R);
					PDo = P & (!R);
					//B+C
					RDo = R && (!P);
				}
			}
			return LearningV;
		}
	}

	void ThinkingChess::CastlesThinkingChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto O22 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O22)
		{

			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///When There is Movments.
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[RowSource][ColumnSource], TableS, Order, RowSource, ColumnSource))->Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource][ColumnSource], false))
			{


					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					ThinkingAtRun = true;
					int CheckedM = 0;

					bool Sup = false;
				if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
				{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
				}
				else
				{
			 if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
			 {
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
			 }
				else
				{
					IsSup.push_back(false);
					IsSupHu.push_back(false);
					Sup = false;
				}
				}
				if (!Sup)
				{

						///Add Table to List of Private.
						HitNumberCastle.push_back(TableS[RowDestination][ColumnDestination]);

						////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (OO)
						{
							ThinkingRun = true;
						}
				}
					///Predict Huristic.
					////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A)
					{
						//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
					}
					////auto A1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A1)
					{
						if (!Sup)
						{
							NumbersOfAllNode++;
						}
					}
					int Killed = 0;
					if (!Sup)
					{
						////auto A2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A2)
						{
							Killed = TableS[RowDestination][ColumnDestination];
							TableS[RowDestination][ColumnDestination] = TableS[RowSource][ColumnSource];
							TableS[RowSource][ColumnSource] = 0;
						}
					}



					{
					//if (!Sup)
						////auto A3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A3)
						{
							PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 4, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);
							//{ ThinkingAtRun = false; return; }
						}
					}

					///Store of Indexes Changes and Table in specific List.
					if (!Sup)
					{
						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnCastle.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListCastle.push_back(CloneATable(TableS));
							IndexCastle++;
						}
					}
					///Wehn Predict of Operation Do operate a Predict of this movments.
					////auto A5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A5)
					{
						//Caused this for Stachostic results.
						if (!Sup)
						{
							CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
						}
					}

					//Calculate Huristic and Add to List and Cal Syntax.
					if (!Sup)
					{
						std::wstring H = L"";
						////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A6)
						{
							double Hu[10];
							//if (!(IsSup[j]))
							{
								HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
								if (IgnoreFromCheckandMateHuristic)
								{
									HuristicObjectDangourCheckMateValue = 0;
								}
								Hu[0] += HuristicAttackValue;
								Hu[1] += HuristicMovementValue;
								Hu[2] += HuristicSelfSupportedValue;
								Hu[3] += HuristicObjectDangourCheckMateValue;
								Hu[4] += HuristicKillerValue;
								Hu[5] += HuristicReducedAttackValue;
								Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
								Hu[7] += HeuristicKingSafe;
								Hu[8] = HeuristicFromCenter;
								Hu[9] = HeuristicKingDangour;

//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
								H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
								HuristicListCastle.push_back(Hu);
							}
							/*else
							{
							    {
							        HuristicPenaltyValuePerform(Current, Order,  HuristicAttackValue);
							        if (IgnoreFromCheckandMateHuristic)
							            HuristicObjectDangourCheckMateValue = 0;
							        Hu[0] += HuristicAttackValue + HuristicAttackValueSup;
							        //HuristicAttackValueSup = 0;
							        Hu[1] += HuristicMovementValue + HuristicMovementValueSup;
							        //HuristicMovementValueSup = 0;
							        Hu[2] += HuristicSelfSupportedValue + HuristicSelfSupportedValueSup;
							        //HuristicSelfSupportedValueSup = 0;
							        Hu[3] += HuristicObjectDangourCheckMateValue + HuristicObjectDangourCheckMateValueSup;
							        //HuristicObjectDangourCheckMateValueSup = 0;
							        Hu[4] += HuristicKillerValue + HuristicKillerValueSup;
							        //HuristicKillerValueSup = 0;
							        Hu[5] += HuristicReducedAttackValue + HuristicReducedAttackValueSup;
							        //HuristicReducedAttackValueSup = 0;
							        Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue + HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							        //HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							        Hu[7] += HeuristicKingSafe + HeuristicKingSafeSup;
							        //HeuristicKingSafeSup = 0;
							        Hu[8] = HeuristicFromCenter + HeuristicFromCenterSup;
							        //HeuristicFromCenterSup = 0;
							        Hu[9] = HeuristicKingDangour + HeuristicKingDangourSup;
							        //HeuristicKingDangourSup = 0;
							        H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
							        HuristicListCastle.Add(Hu);
							        IsSup = false;
							    }
							}*/
							////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O4)
							{
								/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
								if (Order == 1)
								    AllDraw.OutPut +="\r\nThinking Castle AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
								else
								    AllDraw.OutPut +="\r\nThinking Castle AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
								*/	ThinkingLevel++;
								ThinkingAtRun = false;
							}
						}
					}
					else
					{
						HuristicAttackValueSup += HuristicAttackValue;
						HuristicMovementValueSup += HuristicMovementValue;
						HuristicSelfSupportedValueSup += HuristicSelfSupportedValue;
						HuristicObjectDangourCheckMateValueSup += HuristicObjectDangourCheckMateValue;
						HuristicKillerValueSup += HuristicKillerValue;
						HuristicReducedAttackValueSup += HuristicReducedAttackValue;
						HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
						HeuristicKingSafeSup += HeuristicKingSafe;
						HeuristicFromCenterSup += HeuristicFromCenter;
						HeuristicKingDangourSup += HeuristicKingDangour;
						double Hu[10];
						Hu[0] = HuristicAttackValueSup;
						//HuristicAttackValueSup = 0;
						Hu[1] = HuristicMovementValueSup;
						//HuristicMovementValueSup = 0;
						Hu[2] = HuristicSelfSupportedValueSup;
						//HuristicSelfSupportedValueSup = 0;
						Hu[3] = HuristicObjectDangourCheckMateValueSup;
						//HuristicObjectDangourCheckMateValueSup = 0;
						Hu[4] = HuristicKillerValueSup;
						//HuristicKillerValueSup = 0;
						Hu[5] = HuristicReducedAttackValueSup;
						//HuristicReducedAttackValueSup = 0;
						Hu[6] = HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
						//HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
						Hu[7] = HeuristicKingSafeSup;
						//HeuristicKingSafeSup = 0;
						Hu[8] = HeuristicFromCenterSup;
						//HeuristicFromCenterSup = 0;
						Hu[9] = HeuristicKingDangourSup;
						//HeuristicKingDangourSup = 0;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
						std::wstring H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
					////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A4)
					{
						 int AS[2];
						AS[0] = RowDestination;
						AS[1] = ColumnDestination;
						RowColumnCastle.push_back(AS);
						//RowColumn[Index, 0] = RowDestination;
						//RowColumn[Index, 1] = ColumnDestination;
						//Index+=1;
						TableListCastle.push_back(CloneATable(TableS));
						IndexCastle++;

						HuristicListCastle.push_back(Hu);

						HitNumberCastle.push_back(TableS[RowDestination][ColumnDestination]);
					}


					/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
			 if (Order == 1)
				 AllDraw.OutPut +="\r\nThinking Castle AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
			 else
				 AllDraw.OutPut +="\r\nThinking Castle AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
		*/
					ThinkingAtRun = false;
					}

			}
		}
	ThinkingAtRun = false;
	}

	void ThinkingChess::HourseThinkingChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (OO)
		{

			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///When There is Movments.

			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[RowSource][ColumnSource], TableS, Order, RowSource, ColumnSource))->Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource][ColumnSource], false))
			{

					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					ThinkingAtRun = true;
					int CheckedM = 0;

					bool Sup = false;
					if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
					{
						IsSup.push_back(true);
						IsSupHu.push_back(true);
						Sup = true;
					}
					else
					{
					if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
					{
						IsSup.push_back(true);
						IsSupHu.push_back(true);
						Sup = true;
					}
					else
					{
						IsSup.push_back(false);
						IsSupHu.push_back(false);
						Sup = false;
					}
					}
					if (!Sup)
					{

						///Add Table to List of Private.
						HitNumberHourse.push_back(TableS[RowDestination][ColumnDestination]);

						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						////lock (O)
						{
							ThinkingRun = true;
						}
					}
					///Predict Huristic.
					////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A)
					{
						//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
					}
					////auto A1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A1)
					{
						if (!Sup)
						{
							NumbersOfAllNode++;
						}
					}
					int Killed = 0;
					if (!Sup)
					{
						////auto A2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A2)
						{
							Killed = TableS[RowDestination][ColumnDestination];
							TableS[RowDestination][ColumnDestination] = TableS[RowSource][ColumnSource];
							TableS[RowSource][ColumnSource] = 0;
						}
					}



					{
				   // if (!Sup)
						////auto A3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A3)
						{
							PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 3, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);
							//{ ThinkingAtRun = false; return; }
						}
					}

					///Store of Indexes Changes and Table in specific List.
					if (!Sup)
					{
						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnHourse.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListHourse.push_back(CloneATable(TableS));
							IndexHourse++;
						}
					}
					///Wehn Predict of Operation Do operate a Predict of this movments.
					////auto A5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A5)
					{
						//Caused this for Stachostic results.
						if (!Sup)
						{
							CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
						}
					}

					//Calculate Huristic and Add to List and Cal Syntax.
					if (!Sup)
					{
						std::wstring H = L"";
						////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A6)
						{
							double Hu[10];
							//if (!(IsSup[j]))
							{
								HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
								if (IgnoreFromCheckandMateHuristic)
								{
									HuristicObjectDangourCheckMateValue = 0;
								}
								Hu[0] += HuristicAttackValue;
								Hu[1] += HuristicMovementValue;
								Hu[2] += HuristicSelfSupportedValue;
								Hu[3] += HuristicObjectDangourCheckMateValue;
								Hu[4] += HuristicKillerValue;
								Hu[5] += HuristicReducedAttackValue;
								Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
								Hu[7] += HeuristicKingSafe;
								Hu[8] = HeuristicFromCenter;
								Hu[9] = HeuristicKingDangour;

//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
								H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
								HuristicListHourse.push_back(Hu);
							}
							/*else
							{
							    {
							        HuristicPenaltyValuePerform(Current, Order,  HuristicAttackValue);
							        if (IgnoreFromCheckandMateHuristic)
							            HuristicObjectDangourCheckMateValue = 0;
							        Hu[0] += HuristicAttackValue + HuristicAttackValueSup;
							        //HuristicAttackValueSup = 0;
							        Hu[1] += HuristicMovementValue + HuristicMovementValueSup;
							        //HuristicMovementValueSup = 0;
							        Hu[2] += HuristicSelfSupportedValue + HuristicSelfSupportedValueSup;
							        //HuristicSelfSupportedValueSup = 0;
							        Hu[3] += HuristicObjectDangourCheckMateValue + HuristicObjectDangourCheckMateValueSup;
							        //HuristicObjectDangourCheckMateValueSup = 0;
							        Hu[4] += HuristicKillerValue + HuristicKillerValueSup;
							        //HuristicKillerValueSup = 0;
							        Hu[5] += HuristicReducedAttackValue + HuristicReducedAttackValueSup;
							        //HuristicReducedAttackValueSup = 0;
							        Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue + HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							        //HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							        Hu[7] += HeuristicKingSafe + HeuristicKingSafeSup;
							        //HeuristicKingSafeSup = 0;
							        Hu[8] = HeuristicFromCenter + HeuristicFromCenterSup;
							        //HeuristicFromCenterSup = 0;
							        Hu[9] = HeuristicKingDangour + HeuristicKingDangourSup;
							        //HeuristicKingDangourSup = 0;
							        H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
							        HuristicListHourse.Add(Hu);
							        IsSup = false;
							    }
							}*/
						////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O4)
								{
									/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
									if (Order == 1)
									    AllDraw.OutPut +="\r\nThinking Hourse AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
									else
									    AllDraw.OutPut +="\r\nThinking Hourse AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
									*/	ThinkingLevel++;
									ThinkingAtRun = false;
								}
						}
					}
						else
						{
							HuristicAttackValueSup += HuristicAttackValue;
							HuristicMovementValueSup += HuristicMovementValue;
							HuristicSelfSupportedValueSup += HuristicSelfSupportedValue;
							HuristicObjectDangourCheckMateValueSup += HuristicObjectDangourCheckMateValue;
							HuristicKillerValueSup += HuristicKillerValue;
							HuristicReducedAttackValueSup += HuristicReducedAttackValue;
							HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
							HeuristicKingSafeSup += HeuristicKingSafe;
							HeuristicFromCenterSup += HeuristicFromCenter;
							HeuristicKingDangourSup += HeuristicKingDangour;
							double Hu[10];
							Hu[0] = HuristicAttackValueSup;
							//HuristicAttackValueSup = 0;
							Hu[1] = HuristicMovementValueSup;
							//HuristicMovementValueSup = 0;
							Hu[2] = HuristicSelfSupportedValueSup;
							//HuristicSelfSupportedValueSup = 0;
							Hu[3] = HuristicObjectDangourCheckMateValueSup;
							//HuristicObjectDangourCheckMateValueSup = 0;
							Hu[4] = HuristicKillerValueSup;
							//HuristicKillerValueSup = 0;
							Hu[5] = HuristicReducedAttackValueSup;
							//HuristicReducedAttackValueSup = 0;
							Hu[6] = HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							//HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							Hu[7] = HeuristicKingSafeSup;
							//HeuristicKingSafeSup = 0;
							Hu[8] = HeuristicFromCenterSup;
							//HeuristicFromCenterSup = 0;
							Hu[9] = HeuristicKingDangourSup;
							//HeuristicKingDangourSup = 0;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
							std::wstring H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);

						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnHourse.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListHourse.push_back(CloneATable(TableS));
							IndexHourse++;

							HuristicListHourse.push_back(Hu);

							HitNumberHourse.push_back(TableS[RowDestination][ColumnDestination]);


						}
						/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
						    if (Order == 1)
						        AllDraw.OutPut +="\r\nThinking Hourse AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
						    else
						        AllDraw.OutPut +="\r\nThinking Hourse AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
						        */
						ThinkingAtRun = false;
						}

			}
		}
			ThinkingAtRun = false;
	}

	void ThinkingChess::ElephantThinkingChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (OO)
		{
			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///When There is Movments.
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[RowSource][ColumnSource], TableS, Order, RowSource, ColumnSource))->Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource][ColumnSource], false))
			{

					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					ThinkingAtRun = true;
					int CheckedM = 0;

					bool Sup = false;
				if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
				{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
				}
				else
				{
			if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
			{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
			}
				else
				{
					IsSup.push_back(false);
					IsSupHu.push_back(false);
					Sup = false;
				}
				}
				if (!Sup)
				{

						///Add Table to List of Private.
						HitNumberElefant.push_back(TableS[RowDestination][ColumnDestination]);

						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						////lock (O)
						{
							ThinkingRun = true;
						}
				}
					///Predict Huristic.
					////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A)
					{
						//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
					}
					////auto A1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A1)
					{
						if (!Sup)
						{
							NumbersOfAllNode++;
						}
					}
					int Killed = 0;
					if (!Sup)
					{
						////auto A2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A2)
						{
							Killed = TableS[RowDestination][ColumnDestination];
							TableS[RowDestination][ColumnDestination] = TableS[RowSource][ColumnSource];
							TableS[RowSource][ColumnSource] = 0;
						}
					}



					{
					//if (!Sup)
						////auto A3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A3)
						{
							PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 2, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);
							//{ ThinkingAtRun = false; return; }
						}
					}

					///Store of Indexes Changes and Table in specific List.
					if (!Sup)
					{
						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnElefant.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListElefant.push_back(CloneATable(TableS));
							IndexElefant++;
						}
					}
					///Wehn Predict of Operation Do operate a Predict of this movments.
					////auto A5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A5)
					{
						//Caused this for Stachostic results.
						if (!Sup)
						{
							CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
						}
					}

					//Calculate Huristic and Add to List and Cal Syntax.
					if (!Sup)
					{
						std::wstring H = L"";
						////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A6)
						{
							double Hu[10];
							//if (!(IsSup[j]))
							{
								HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
								if (IgnoreFromCheckandMateHuristic)
								{
									HuristicObjectDangourCheckMateValue = 0;
								}
								Hu[0] += HuristicAttackValue;
								Hu[1] += HuristicMovementValue;
								Hu[2] += HuristicSelfSupportedValue;
								Hu[3] += HuristicObjectDangourCheckMateValue;
								Hu[4] += HuristicKillerValue;
								Hu[5] += HuristicReducedAttackValue;
								Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
								Hu[7] += HeuristicKingSafe;
								Hu[8] = HeuristicFromCenter;
								Hu[9] = HeuristicKingDangour;

//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
								H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
								HuristicListElefant.push_back(Hu);
							}
							/*else
							{
							    {
							        HuristicPenaltyValuePerform(Current, Order,  HuristicAttackValue);
							        if (IgnoreFromCheckandMateHuristic)
							            HuristicObjectDangourCheckMateValue = 0;
							        Hu[0] += HuristicAttackValue + HuristicAttackValueSup;
							        //HuristicAttackValueSup = 0;
							        Hu[1] += HuristicMovementValue + HuristicMovementValueSup;
							        //HuristicMovementValueSup = 0;
							        Hu[2] += HuristicSelfSupportedValue + HuristicSelfSupportedValueSup;
							        //HuristicSelfSupportedValueSup = 0;
							        Hu[3] += HuristicObjectDangourCheckMateValue + HuristicObjectDangourCheckMateValueSup;
							        //HuristicObjectDangourCheckMateValueSup = 0;
							        Hu[4] += HuristicKillerValue + HuristicKillerValueSup;
							        //HuristicKillerValueSup = 0;
							        Hu[5] += HuristicReducedAttackValue + HuristicReducedAttackValueSup;
							        //HuristicReducedAttackValueSup = 0;
							        Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue + HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							        //HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							        Hu[7] += HeuristicKingSafe + HeuristicKingSafeSup;
							        //HeuristicKingSafeSup = 0;
							        Hu[8] = HeuristicFromCenter + HeuristicFromCenterSup;
							        //HeuristicFromCenterSup = 0;
							        Hu[9] = HeuristicKingDangour + HeuristicKingDangourSup;
							        //HeuristicKingDangourSup = 0;
							        H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
							        HuristicListElefant.Add(Hu);
							        IsSup = false;
							    }
							}*/
							////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O4)
							{
								/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
								if (Order == 1)
								    AllDraw.OutPut +="\r\nThinking Hourse AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
								else
								    AllDraw.OutPut +="\r\nThinking Hourse AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
								*/	ThinkingLevel++;
								ThinkingAtRun = false;
							}
						}
					}
					else
					{
						HuristicAttackValueSup += HuristicAttackValue;
						HuristicMovementValueSup += HuristicMovementValue;
						HuristicSelfSupportedValueSup += HuristicSelfSupportedValue;
						HuristicObjectDangourCheckMateValueSup += HuristicObjectDangourCheckMateValue;
						HuristicKillerValueSup += HuristicKillerValue;
						HuristicReducedAttackValueSup += HuristicReducedAttackValue;
						HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
						HeuristicKingSafeSup += HeuristicKingSafe;
						HeuristicFromCenterSup += HeuristicFromCenter;
						HeuristicKingDangourSup += HeuristicKingDangour;
						double Hu[10];
						Hu[0] = HuristicAttackValueSup;
						//HuristicAttackValueSup = 0;
						Hu[1] = HuristicMovementValueSup;
						//HuristicMovementValueSup = 0;
						Hu[2] = HuristicSelfSupportedValueSup;
						//HuristicSelfSupportedValueSup = 0;
						Hu[3] = HuristicObjectDangourCheckMateValueSup;
						//HuristicObjectDangourCheckMateValueSup = 0;
						Hu[4] = HuristicKillerValueSup;
						//HuristicKillerValueSup = 0;
						Hu[5] = HuristicReducedAttackValueSup;
						//HuristicReducedAttackValueSup = 0;
						Hu[6] = HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
						//HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
						Hu[7] = HeuristicKingSafeSup;
						//HeuristicKingSafeSup = 0;
						Hu[8] = HeuristicFromCenterSup;
						//HeuristicFromCenterSup = 0;
						Hu[9] = HeuristicKingDangourSup;
						//HeuristicKingDangourSup = 0;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
						std::wstring H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
					////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A4)
					{
						 int AS[2];
						AS[0] = RowDestination;
						AS[1] = ColumnDestination;
						RowColumnElefant.push_back(AS);
						//RowColumn[Index, 0] = RowDestination;
						//RowColumn[Index, 1] = ColumnDestination;
						//Index+=1;
						TableListElefant.push_back(CloneATable(TableS));
						IndexElefant++;

						HuristicListElefant.push_back(Hu);

						HitNumberElefant.push_back(TableS[RowDestination][ColumnDestination]);

					}



					/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
					    if (Order == 1)
					        AllDraw.OutPut +="\r\nThinking Elephant AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    else
					        AllDraw.OutPut +="\r\nThinking Elephant AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    */
					ThinkingAtRun = false;
					}

			}
		}
		ThinkingAtRun = false;
	}

	bool ThinkingChess::EqualitTow(bool PenRegStrore, int kind)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Equality = false;
			if (kind == 1 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder.size() == TableListSolder.size())
			{
				Equality = true;
			}
			else
			{
				if (kind == 2 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListElefant.size() == TableListElefant.size())
				{
				Equality = true;
				}
			else
			{
					if (kind == 3 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListHourse.size() == TableListHourse.size())
					{
				Equality = true;
					}
			else
			{
						if (kind == 4 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListCastle.size() == TableListCastle.size())
						{
				Equality = true;
						}
			else
			{
							if (kind == 5 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListMinister.size() == TableListMinister.size())
							{
				Equality = true;
							}
			else
			{
								if (kind == 6 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListKing.size() == TableListKing.size())
								{
				Equality = true;
								}
			}
			}
			}
			}
			}
			return Equality;
		}
	}

	bool ThinkingChess::EqualitOne(QuantumAtamata Current, int kind)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			bool Equality = false;
			if (kind == 1 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder.size() == TableListSolder.size())
			{
				Equality = true;
			}

			else
			{
				if (kind == 2 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListElefant.size() == TableListElefant.size())
				{
				Equality = true;
				}
			else
			{
					if (kind == 3 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListHourse.size() == TableListHourse.size())
					{
				Equality = true;
					}
			else
			{
						if (kind == 4 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListMinister.size() == TableListMinister.size())
						{
				Equality = true;
						}
			else
			{
							if (kind == 5 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListKing.size() == TableListKing.size())
							{
				Equality = true;
							}
			else
			{
								if (kind == 6 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder.size() == TableListSolder.size())
								{
				Equality = true;
								}
			}
			}
			}
			}
			}
			return Equality;
		}
	}

	void ThinkingChess::AddAtList(int kind, QuantumAtamata Current)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			//Adding Autamata Object to Specified List.
			if (kind == 1)
			{
				//Soldier
				PenaltyRegardListSolder.push_back(Current);
			}
			else
			{
			if (kind == 2)
			{
				//Elefant
				PenaltyRegardListElefant.push_back(Current);
			}
			else
			{
				if (kind == 3)
				{
				//Hourse
				PenaltyRegardListHourse.push_back(Current);
				}
			else
			{
					if (kind == 4)
					{
				//Castles.
				PenaltyRegardListCastle.push_back(Current);
					}
			else
			{
						if (kind == 5)
						{
				//Minister.
				PenaltyRegardListMinister.push_back(Current);
						}
			else
			{
							if (kind == 6)
							{
				//King.
				PenaltyRegardListKing.push_back(Current);
							}
			}
			}
			}
			}
			}
		}
	}

	void ThinkingChess::RemoveAtList(int kind)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			//Remove Last Atutamata Object.
			if (kind == 1)
			{
				//Soldier
				PenaltyRegardListSolder.pop_back();
			}
			else
			{
			if (kind == 2)
			{
				//Elefant
				PenaltyRegardListElefant.pop_back();
			}
			else
			{
				if (kind == 3)
				{
				//Hourse
				PenaltyRegardListHourse.pop_back();
				}
			else
			{
					if (kind == 4)
					{
				//Castles
				PenaltyRegardListCastle.pop_back();
					}
			else
			{
						if (kind == 5)
						{
				//Minister
				PenaltyRegardListMinister.pop_back();
						}
			else
			{
							if (kind == 6)
							{
				//King.
				PenaltyRegardListKing.pop_back();
							}
			}
			}
			}
			}
			}
		}
	}

	bool ThinkingChess::PenaltyMechanisam(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int &CheckedM, int Killed, bool Before, int kind, int **TableS, int ii, int jj, QuantumAtamata Current, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int i, int j, bool Castle)
	{
		////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (OO)
		{
			bool RETURN = false;
			////auto O3 = new Object();
			ChessRules AA =  ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[ii][jj], TableS, AllDraw::OrderPlate, ii, jj);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				if (!UsePenaltyRegardMechnisamT)
				{
					RETURN = true;
					AddAtList(kind, Current);
				}
				//Consideration to go to Check.  

				//if (!UsePenaltyRegardMechnisamT)
				AA.CheckMate(TableS, AllDraw::OrderPlate);
				{
					if (AllDraw::OrderPlate == 1 && AA.CheckMateBrown)
					{
						////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A)
						{
							IsThereMateOfEnemy = true;
							FoundFirstMating++;
							WinOcuuredatChiled = 2;
							Current.LearningAlgorithmRegard();
							RemoveAtList(kind);
							AddAtList(kind, Current);
							CheckedM = 3;
							//return true;
						}


					}
					if (AllDraw::OrderPlate == -1 && AA.CheckMateGray)
					{
						DoEnemySelf = false;
						////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A)
						{
							IsThereMateOfEnemy = true;

							FoundFirstMating++;
							WinOcuuredatChiled = 2;
							RemoveAtList(kind);
							Current.LearningAlgorithmRegard();
							AddAtList(kind, Current);
							CheckedM = 3;
							//return true;
						}
					}
					if ((AllDraw::OrderPlate == -1 && AA.CheckMateBrown))
					{
						////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A)
						{
							IsThereMateOfSelf = true;
							FoundFirstSelfMating++;
							LoseOcuuredatChiled = -2;
							Current.LearningAlgorithmPenalty();
							RemoveAtList(kind);
							AddAtList(kind, Current);
							CheckedM = 3;
							//return true;
						}


					}
					if ((AllDraw::OrderPlate == 1 && AA.CheckMateGray)) //(AllDraw.OrderPlate == 1 && AA.CheckGray) ||
					{
						DoEnemySelf = false;
						////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A)
						{
							IsThereMateOfSelf = true;
							FoundFirstSelfMating++;
							LoseOcuuredatChiled = -2;
							RemoveAtList(kind);
							Current.LearningAlgorithmPenalty();
							AddAtList(kind, Current);
							CheckedM = 3;
							//return true;
						}
					}

					{
					//if (FoundFirstSelfMating > 0)
						/*if ((new IsNextEnemyMovementForCheckedMate(Order * -1, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS)).Is())
						{
						    IsThereMateOfSelf = true;
						    FoundFirstSelfMating++;
						    LoseOcuuredatChiled = -2;
						    RemoveAtList(kind);
						    Current.LearningAlgorithmPenalty();
						    AddAtList(kind, Current);
						    CheckedM = 3;
						    //return true;
						}*/
					}

					if (Order == 1 && AA.CheckMateBrown)
					{
						DoEnemySelf = false;
						EnemyCheckMateActionsString = true;
						CheckedM = -2;
						//return true;
					}
					if (Order == -1 && AA.CheckMateGray)
					{
						DoEnemySelf = false;
						EnemyCheckMateActionsString = true;
						CheckedM = -2;
						//return true;
					}
					if (Order == 1 && AA.CheckMateGray)
					{

						EnemyCheckMateActionsString = false;
						CheckedM = -2;
						//return true;
					}
					if (Order == -1 && AA.CheckMateBrown)
					{

						EnemyCheckMateActionsString = false;
						CheckedM = -2;
						//return true;
					}

					if (Order == 1 && AA.CheckGray)
					{
						//KishBefore = true;
						////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A)
						{
							NumberOfPenalties++;
						}
						CheckedM = -1;
						//return true;
					}
					else
					{
						if (Order == -1 && AA.CheckBrown)
						{
						//KishBefore = true;
						////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A)
						{
							NumberOfPenalties++;
						}
						CheckedM = -1;
						//return true;
						}
					}
				}
				if (RETURN)
				{
					return false;
				}
			}

			//Initiate Local Variables.
			bool IsCurrentCanGardHighPriorityEne = bool();
			bool IsNextMovemntIsCheckOrCheckMateForCurrent = bool();
			bool IsNextMovemntIsCheckOrCheckMateForEnemy = bool();
			bool IsDangerous = bool();
			bool CanKillerAnUnSupportedEnemy = bool();
			bool InDangrousUnSupported = bool();
			bool Support = bool();
			bool IsPrviousMovemntIsDangrousForCurr = bool();
			bool PDo = bool(), RDo = bool();
			bool SelfNotSupported = bool();
			bool EnemyNotSupported = bool();
			bool IsGardForCurrentMovmentsAndIsNotMova = bool();
			bool IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = bool();

//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: bool* LearningV = nullptr;
			bool *LearningV = nullptr;
			//Mechanisam of Regrad.  
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				if (kind == 1 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder.size() == TableListSolder.size())
				{
					LearningV = CalculateLearningVars(Killed, TableS, ii, jj, i, j);
				}
				else
				{
				if (kind == 2 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListElefant.size() == TableListElefant.size())
				{
					LearningV = CalculateLearningVars(Killed, TableS, ii, jj, i, j);
				}
				else
				{
					if (kind == 3 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListHourse.size() == TableListHourse.size())
					{
					LearningV = CalculateLearningVars(Killed, TableS, ii, jj, i, j);
					}
				else
				{
						if (kind == 4 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListMinister.size() == TableListMinister.size())
						{
					LearningV = CalculateLearningVars(Killed, TableS, ii, jj, i, j);
						}
				else
				{
							if (kind == 5 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListKing.size() == TableListKing.size())
							{
					LearningV = CalculateLearningVars(Killed, TableS, ii, jj, i, j);
							}
				else
				{
								if (kind == 6 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder.size() == TableListSolder.size())
								{
					LearningV = CalculateLearningVars(Killed, TableS, ii, jj, i, j);
								}
				}
				}
				}
				}
				}
			}
			////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O2)
			{

				IsCurrentCanGardHighPriorityEne = LearningV[0];
				IsNextMovemntIsCheckOrCheckMateForCurrent = LearningV[1];
				IsDangerous = LearningV[2];
				CanKillerAnUnSupportedEnemy = LearningV[3];
				InDangrousUnSupported = LearningV[4];
				Support = LearningV[5];
				IsNextMovemntIsCheckOrCheckMateForEnemy = LearningV[6];
				IsPrviousMovemntIsDangrousForCurr = LearningV[7];
				PDo = LearningV[8];
				RDo = LearningV[9];
				SelfNotSupported = LearningV[10];
				EnemyNotSupported = LearningV[11];
				IsGardForCurrentMovmentsAndIsNotMova = LearningV[12];
				IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = LearningV[13];
			}
			//Consideration of Itterative Movments to ignore.
			//Operation of Penalty Regard Mechanisam on Check and mate speciffically.
			bool Equality = EqualitOne(Current, kind);

			////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O4)
			{
				if (Equality)
				{
					ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[ii][jj], TableS, Order, Row, Column);
					if (A->Check(TableS, Order))
					{
						if (Order == 1 && (A->CheckGray))
						{
							NumberOfPenalties++;
							Current.LearningAlgorithmPenalty();
						}
						else
						{
							if (Order == -1 && (A->CheckBrown))
							{
							NumberOfPenalties++;
							Current.LearningAlgorithmPenalty();
							}
						}
						AddAtList(kind, Current);
					}
					else
					{
						if (IsCurrentStateIsDangreousForCurrentOrder(TableS, Order, color, i, j) && DoEnemySelf)
						{
							NumberOfPenalties++;
							Current.LearningAlgorithmPenalty();

							AddAtList(kind, Current);
						}
						else
						{
							AddAtList(kind, Current);
						}
					}

					//When There is Penalty or Regard.To Side can not be equal.
					if (PDo || RDo)
					{
						//Penalty.
						if (PDo)
						{
							////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (OO1)
							{
								for (int ik = 0; ik < abs(TableS[i][j]); ik++)
								{
									LearniningTable->LearningAlgorithmPenaltyNet(ii, jj);
								}
							}
							//When previous Move of Enemy goes to Dangoure Current Object.
							if (IsPrviousMovemntIsDangrousForCurr && Current.IsPenaltyAction() != 0)
							{
								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}
							//For Not Suppored In Attacked.
							if (SelfNotSupported && Current.IsPenaltyAction() != 0)
							{
								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}
							//When Current Move Dos,'t Supporte.
							//For Ocuuring in Enemy CheckMate.
							if (SelfNotSupported && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}
							if (IsGardForCurrentMovmentsAndIsNotMova && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}
							if (IsNotSafeToMoveAenemeyToAttackMoreThanTowObj && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}

							if (IsDangerous && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}


							if (EnemyNotSupported && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
							{
								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmRegard();

								AddAtList(kind, Current);
							}


						}
						else if (RDo)
						{
							////auto OOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (OOO)
							{
								for (int ik = 0; ik < abs(TableS[i][j]); ik++)
								{
									LearniningTable->LearningAlgorithmRegardNet(ii, jj);
								}
							}

							if (SelfNotSupported && Current.IsPenaltyAction() != 0)
							{
								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);
							}
							if (IsGardForCurrentMovmentsAndIsNotMova && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}

							if (IsNotSafeToMoveAenemeyToAttackMoreThanTowObj && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}
							if (IsDangerous && Current.IsPenaltyAction() != 0)
							{

								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmPenalty();

								AddAtList(kind, Current);

							}

							if (EnemyNotSupported && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
							{
								NumberOfPenalties++;

								RemoveAtList(kind);

								Current.LearningAlgorithmRegard();

								AddAtList(kind, Current);
							}



							if (IsCurrentCanGardHighPriorityEne && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
							{
								RemoveAtList(kind);

								Current.LearningAlgorithmRegard();

								AddAtList(kind, Current);
							}
							//For Ocuuring Enemy Garding Objects.
							if (Support && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
							{
								RemoveAtList(kind);

								Current.LearningAlgorithmRegard();

								AddAtList(kind, Current);
							}

						}


					}
					else
					{
						////auto OO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (OO1)
						{
							for (int ik = 0; ik < abs(TableS[i][j]); ik++)
							{
								LearniningTable->LearningAlgorithmRegardNet(ii, jj);
								LearniningTable->LearningAlgorithmPenaltyNet(ii, jj);
							}
						}

						if (IsNextMovemntIsCheckOrCheckMateForCurrent && Current.IsPenaltyAction() != 0)
						{
							NumberOfPenalties++;

							RemoveAtList(kind);

							Current.LearningAlgorithmPenalty();

							AddAtList(kind, Current);

						}

						if (SelfNotSupported && Current.IsPenaltyAction() != 0)
						{

							RemoveAtList(kind);

							Current.LearningAlgorithmPenalty();

							AddAtList(kind, Current);

						}
						if (IsGardForCurrentMovmentsAndIsNotMova && Current.IsPenaltyAction() != 0)
						{

							NumberOfPenalties++;

							RemoveAtList(kind);

							Current.LearningAlgorithmPenalty();

							AddAtList(kind, Current);

						}
						if (IsNotSafeToMoveAenemeyToAttackMoreThanTowObj && Current.IsPenaltyAction() != 0)
						{

							NumberOfPenalties++;

							RemoveAtList(kind);

							Current.LearningAlgorithmPenalty();

							AddAtList(kind, Current);

						}

						if (IsDangerous && Current.IsPenaltyAction() != 0)
						{

							NumberOfPenalties++;

							RemoveAtList(kind);

							Current.LearningAlgorithmPenalty();

							AddAtList(kind, Current);

						}



						if (IsNextMovemntIsCheckOrCheckMateForEnemy && Current.IsPenaltyAction() != 0)
						{
							RemoveAtList(kind);

							Current.LearningAlgorithmRegard();

							AddAtList(kind, Current);

						}

						if (IsCurrentCanGardHighPriorityEne && Current.IsPenaltyAction() != 0)
						{
							RemoveAtList(kind);

							Current.LearningAlgorithmRegard();

							AddAtList(kind, Current);

						}
						if (EnemyNotSupported && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
						{
							NumberOfPenalties++;

							RemoveAtList(kind);

							Current.LearningAlgorithmRegard();

							AddAtList(kind, Current);
						}
					}
				}
			}
			return false;
		}
	}

	void ThinkingChess::SolderThinkingChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///When There is Movments.
			if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[RowSource][ColumnSource], TableS, Order, RowSource, ColumnSource))->Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource][ColumnSource], false))
			{

					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					ThinkingAtRun = true;
					int CheckedM = 0;

					bool Sup = false;
				if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
				{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
				}
				else
				{
			if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
			{
					IsSup.push_back(true);
					IsSupHu.push_back(true);
					Sup = true;
			}
				else
				{
					IsSup.push_back(false);
					IsSupHu.push_back(false);
					Sup = false;
				}
				}
				if (!Sup)
				{

						///Add Table to List of Private.
						HitNumberSoldier.push_back(TableS[RowDestination][ColumnDestination]);

						////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						////lock (O)
						{
							ThinkingRun = true;
						}
				}
					///Predict Huristic.
					////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A)
					{
						//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
					}
					////auto A1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A1)
					{
						if (!Sup)
						{
							NumbersOfAllNode++;
						}
					}
					int Killed = 0;
					if (!Sup)
					{
						////auto A2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A2)
						{
							Killed = TableS[RowDestination][ColumnDestination];
							TableS[RowDestination][ColumnDestination] = TableS[RowSource][ColumnSource];
							TableS[RowSource][ColumnSource] = 0;
						}
					}



					{
					//if (!Sup)
						////auto A3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A3)
						{
							PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 1, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);
							//{ ThinkingAtRun = false; return; }
						}
					}

					///Store of Indexes Changes and Table in specific List.
					if (!Sup)
					{
						////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A4)
						{
							 int AS[2];
							AS[0] = RowDestination;
							AS[1] = ColumnDestination;
							RowColumnSoldier.push_back(AS);
							//RowColumn[Index, 0] = RowDestination;
							//RowColumn[Index, 1] = ColumnDestination;
							//Index+=1;
							TableListSolder.push_back(CloneATable(TableS));
							IndexSoldier++;
						}
					}
					///Wehn Predict of Operation Do operate a Predict of this movments.
					////auto A5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A5)
					{
						//Caused this for Stachostic results.
						if (!Sup)
						{
							CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
						}
					}

					//Calculate Huristic and Add to List and Cal Syntax.
					if (!Sup)
					{
						std::wstring H = L"";
						////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (A6)
						{
							double Hu[10];
							//if (!(IsSup[j]))
							{
								HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
								if (IgnoreFromCheckandMateHuristic)
								{
									HuristicObjectDangourCheckMateValue = 0;
								}
								Hu[0] += HuristicAttackValue;
								Hu[1] += HuristicMovementValue;
								Hu[2] += HuristicSelfSupportedValue;
								Hu[3] += HuristicObjectDangourCheckMateValue;
								Hu[4] += HuristicKillerValue;
								Hu[5] += HuristicReducedAttackValue;
								Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
								Hu[7] += HeuristicKingSafe;
								Hu[8] = HeuristicFromCenter;
								Hu[9] = HeuristicKingDangour;

//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
								H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
								HuristicListSolder.push_back(Hu);
							}
							/*else
							{
							    HuristicPenaltyValuePerform(Current, Order,  HuristicAttackValue);
							    if (IgnoreFromCheckandMateHuristic)
							        HuristicObjectDangourCheckMateValue = 0;
							    Hu[0] += HuristicAttackValue + HuristicAttackValueSup;
							    HuristicAttackValueSup = 0;
							    Hu[1] += HuristicMovementValue + HuristicMovementValueSup;
							    HuristicMovementValueSup = 0;
							    Hu[2] += HuristicSelfSupportedValue + HuristicSelfSupportedValueSup;
							    HuristicSelfSupportedValueSup = 0;
							    Hu[3] += HuristicObjectDangourCheckMateValue + HuristicObjectDangourCheckMateValueSup;
							    HuristicObjectDangourCheckMateValueSup = 0;
							    Hu[4] += HuristicKillerValue + HuristicKillerValueSup;
							    HuristicKillerValueSup = 0;
							    Hu[5] += HuristicReducedAttackValue + HuristicReducedAttackValueSup;
							    HuristicReducedAttackValueSup = 0;
							    Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue + HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
							    HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
							    Hu[7] += HeuristicKingSafe + HeuristicKingSafeSup;
							    HeuristicKingSafeSup = 0;
							    Hu[8] = HeuristicFromCenter + HeuristicFromCenterSup;
							    HeuristicFromCenterSup = 0;
							    Hu[9] = HeuristicKingDangour + HeuristicKingDangourSup;
							    HeuristicKingDangourSup = 0;
							    H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
							    HuristicListSolder.Add(Hu);
							    IsSup = false;
							}*/
						}
						////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O4)
						{
							/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
							if (Order == 1)
							    AllDraw.OutPut +="\r\nThinking Soldier AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
							else
							    AllDraw.OutPut +="\r\nThinking Soldier AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
							*/	ThinkingLevel++;
							ThinkingAtRun = false;
						}
					}
					else
					{
						HuristicAttackValueSup += HuristicAttackValue;
						HuristicMovementValueSup += HuristicMovementValue;
						HuristicSelfSupportedValueSup += HuristicSelfSupportedValue;
						HuristicObjectDangourCheckMateValueSup += HuristicObjectDangourCheckMateValue;
						HuristicKillerValueSup += HuristicKillerValue;
						HuristicReducedAttackValueSup += HuristicReducedAttackValue;
						HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
						HeuristicKingSafeSup += HeuristicKingSafe;
						HeuristicFromCenterSup += HeuristicFromCenter;
						HeuristicKingDangourSup += HeuristicKingDangour;
						double Hu[10];
						Hu[0] = HuristicAttackValueSup;
						//HuristicAttackValueSup = 0;
						Hu[1] = HuristicMovementValueSup;
						//HuristicMovementValueSup = 0;
						Hu[2] = HuristicSelfSupportedValueSup;
						//HuristicSelfSupportedValueSup = 0;
						Hu[3] = HuristicObjectDangourCheckMateValueSup;
						//HuristicObjectDangourCheckMateValueSup = 0;
						Hu[4] = HuristicKillerValueSup;
						//HuristicKillerValueSup = 0;
						Hu[5] = HuristicReducedAttackValueSup;
						//HuristicReducedAttackValueSup = 0;
						Hu[6] = HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
						//HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = 0;
						Hu[7] = HeuristicKingSafeSup;
						//HeuristicKingSafeSup = 0;
						Hu[8] = HeuristicFromCenterSup;
						//HeuristicFromCenterSup = 0;
						Hu[9] = HeuristicKingDangourSup;
						//HeuristicKingDangourSup = 0;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
						std::wstring H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);

					////auto A4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (A4)
					{
						 int AS[2];
						AS[0] = RowDestination;
						AS[1] = ColumnDestination;
						RowColumnSoldier.push_back(AS);
						//RowColumn[Index, 0] = RowDestination;
						//RowColumn[Index, 1] = ColumnDestination;
						//Index+=1;
						TableListSolder.push_back(CloneATable(TableS));
						IndexSoldier++;

						HuristicListSolder.push_back(Hu);

						HitNumberSoldier.push_back(TableS[RowDestination][ColumnDestination]);
					}
					/*OutPutAction = " " + Alphabet(RowSource) + Number(ColumnSource) + Alphabet(RowDestination) + Number(ColumnDestination) + CheM(CheckedM) + " With Huristic " + H;
					    if (Order == 1)
					        AllDraw.OutPut +="\r\nThinking Soldier AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Bob at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    else
					        AllDraw.OutPut +="\r\nThinking Soldier AStarGreedy By Level " + CurrentAStarGredyMax.ToString() + " Alice at " + ThinkingLevel.ToString() + "th Thinking String " + OutPutAction;
					    */
					ThinkingAtRun = false;
					}


			}
		}
		ThinkingAtRun = false;
	}

	void ThinkingChess::CastleThinkingBrown(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			ThinkingAtRun = true;
			int CheckedM = 0;
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			//When is Brown Castles King.

			bool Sup = false;
			if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
			{
				IsSup.push_back(true);
				IsSupHu.push_back(true);
				Sup = true;
			}
			else
			{
		 if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
		 {
				IsSup.push_back(true);
				IsSupHu.push_back(true);
				Sup = true;
		 }
			else
			{
				IsSup.push_back(false);
				IsSupHu.push_back(false);
				Sup = false;
			}
			}

			//Calcuilate Huristic Before Movment.
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				ThinkingRun = true;
			}
			//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
			////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (A)
			{
				NumbersOfAllNode++;
			}
		   int Killed = 0;
			if (RowDestination < RowSource)
			{
				TableS[RowSource - 1][ColumnDestination] = -4;
				TableS[RowSource - 2][ColumnDestination] = -6;
				TableS[RowSource][ColumnSource] = 0;
				//TableS[0, ColumnSource] = 0;

			}

			else
			{
				TableS[RowSource + 1][ColumnDestination] = -4;
				TableS[RowSource + 2][ColumnDestination] = -6;
				TableS[RowSource][ColumnSource] = 0;
				//TableS[7, ColumnSource] = 0;

			}
			PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 7, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);

			//{ ThinkingAtRun = false; return; }
			//Store Movments Items. 
			 int AS[2];
			AS[0] = RowDestination;
			AS[1] = ColumnDestination;
			RowColumnKing.push_back(AS);
			TableListKing.push_back(CloneATable(TableS));
			IndexKing++;
			//Calculate Huristic Sumation and Store in Specific List.
			double Hu[10];
			std::wstring H = L"";
			////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (A6)
			{
				HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
				if (IgnoreFromCheckandMateHuristic)
				{
					HuristicObjectDangourCheckMateValue = 0;
				}
				Hu[0] += HuristicAttackValue;
				Hu[1] += HuristicMovementValue;
				Hu[2] += HuristicSelfSupportedValue;
				Hu[3] += HuristicObjectDangourCheckMateValue;
				Hu[4] += HuristicKillerValue;
				Hu[5] += HuristicReducedAttackValue;
				Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
				Hu[7] += HeuristicKingSafe;
				Hu[8] = HeuristicFromCenter;
				Hu[9] = HeuristicKingDangour;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);
				HuristicListKing.push_back(Hu);

			}
			Castle = true;
			////auto O7 = new Object();
			SetObjectNumbersInList(TableS);
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O7)
			{
				if (RowDestination < RowSource)
				{
					if (Order == 1)
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O-O") + std::wstring(L" With Huristic ") + H;
					}
					else
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O-O") + std::wstring(L" With Huristic ") + H;
					}
					ThinkingLevel++;
				}
				else
				{
					if (Order == 1)
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O") + std::wstring(L" With Huristic ") + H;
					}
					else
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O") + std::wstring(L" With Huristic ") + H;
					}
					ThinkingLevel++;
				}
				//HuristicListKing.Add(Hu);

				ThinkingAtRun = false;
			}

		}
		ThinkingAtRun = false;
	}

	void ThinkingChess::CalculateHuristics(bool Before, int Killed, int **TableS, int RowS, int ColS, int RowD, int ColD, int color, double &HuristicAttackValue, double &HuristicMovementValue, double &HuristicSelfSupportedValue, double &HuristicObjectDangourCheckMateValue, double &HuristicKillerValue, double &HuristicReducedAttackValue, double &HeuristicDistabceOfCurrentMoveFromEnemyKingValue, double &HeuristicKingSafe, double &HeuristicFromCenter, double &HeuristicKingDangour)
	{
		////auto OO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (OO)
		{

//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: double* Huriistic = nullptr;
			double *Huriistic = nullptr;
			double HCheck = double();
			double HDistance = double();
			double HKingSafe = double();
			double HKingDangour = double();
			double HFromCenter = 0;
			//Parallel::Invoke([&] () //,  HeuristicKingSafe - ,  HeuristicKingSafe - ,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue - ,  HuristicObjectDangourCheckMateValue
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//////lock (O)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableSS = CloneATable(TableS);
					int **TableSS = CloneATable(TableS);
					Huriistic = HuristicAll(Before, Killed, TableSS, color, Order, RowS, ColS, RowD, ColD);
				}
			}
		   //, [&] ()
		   {
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//////lock (O)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableSS = CloneATable(TableS);
					int **TableSS = CloneATable(TableS);
					HCheck = HuristicCheckAndCheckMate(TableSS, color);
				}
		   }
		   //, [&] ()
		   {
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//////lock (O)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableSS = CloneATable(TableS);
					int **TableSS = CloneATable(TableS);
					HDistance = HeuristicDistabceOfCurrentMoveFromEnemyKing(TableSS, Order, RowS, ColS);
				}
		   }
		   //, [&] ()
		   {
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//////lock (O)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableSS = CloneATable(TableS);
					int **TableSS = CloneATable(TableS);
					HKingSafe = HeuristicKingSafety(TableSS, Order, color, RowS, ColS, RowD, ColD, CurrentAStarGredyMax);
				}
		   }
		   //, [&] ()
		   {
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//////lock (O)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableSS = CloneATable(TableS);
					int **TableSS = CloneATable(TableS);
					HKingDangour = HeuristicKingDangourous(TableSS, Order, color, RowS, ColS, RowD, ColD, CurrentAStarGredyMax);
				}
		   }
		  // , [&] ()
		   {
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//////lock (O)
				{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] TableSS = CloneATable(TableS);
					int **TableSS = CloneATable(TableS);
					HFromCenter = HuristicSoldierFromCenter(TableSS, color, Order, RowS, ColS, RowD, ColD);
				}
		   }//);
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O1)
			{


				/*HuristicAttackValue = Huriistic[0] * SignOrderToPlate(Order);
				HuristicKillerValue = Huriistic[1] * SignOrderToPlate(Order);
				HuristicMovementValue = Huriistic[2] * SignOrderToPlate(Order);
				HuristicObjectDangourCheckMateValue = (Huriistic[3] + HCheck) * SignOrderToPlate(Order);
				HuristicReducedAttackValue = Huriistic[4] * SignOrderToPlate(Order);
				HuristicSelfSupportedValue = Huriistic[5] * SignOrderToPlate(Order);
				HeuristicDistabceOfCurrentMoveFromEnemyKingValue = HDistance * SignOrderToPlate(Order);
				HeuristicKingSafe = HKingSafe * SignOrderToPlate(Order);
				HeuristicFromCenter = HFromCenter * SignOrderToPlate(Order);
				HeuristicKingDangour = HKingDangour * SignOrderToPlate(Order);
				*/
				HDistance /= 10;
				//HKingSafe /= 10;
				HFromCenter /= 10;
				//HKingDangour /= 10;
				if (Before)
				{
					/*HuristicAttackValue = Huriistic[0];
					HuristicKillerValue = Huriistic[1];
					HuristicMovementValue = Huriistic[2];
					HuristicObjectDangourCheckMateValue = (Huriistic[3] + HCheck);
					HuristicReducedAttackValue = Huriistic[4];
					HuristicSelfSupportedValue = Huriistic[5];
					HeuristicDistabceOfCurrentMoveFromEnemyKingValue = HDistance;
					HeuristicKingSafe = HKingSafe;
					HeuristicFromCenter = HFromCenter;
					HeuristicKingDangour = HKingDangour;
					*/

					HuristicAttackValue = (Huriistic[0] * SignOrderToPlate(Order));
					HuristicKillerValue = (Huriistic[1] * SignOrderToPlate(Order));
					HuristicMovementValue = Huriistic[2] * SignOrderToPlate(Order);
					HuristicObjectDangourCheckMateValue = ((Huriistic[3] + HCheck) * SignOrderToPlate(Order));
					HuristicReducedAttackValue = (Huriistic[4] * SignOrderToPlate(Order));
					HuristicSelfSupportedValue = (Huriistic[5] * SignOrderToPlate(Order));
					HeuristicDistabceOfCurrentMoveFromEnemyKingValue = (HDistance * SignOrderToPlate(Order));
					HeuristicKingSafe = (HKingSafe * SignOrderToPlate(Order));
					HeuristicFromCenter = (HFromCenter * SignOrderToPlate(Order));
					HeuristicKingDangour = (HKingDangour * SignOrderToPlate(Order));
					/*if (Killed != 0)
					    {
					        if (Order == 1)
					        {
					            //When Current Order is on Attack
					            if (Killed > 0)
					            {
					                HuristicKillerValue = Double.MinValue / 2;
					            }
					            else
					            //When Enemy has Attacked.
					            if (Killed < 0)
					            {
					                HuristicKillerValue = Double.MaxValue / 2;
	
					            }
					        }
					        else
					        {
					            if (Killed < 0)
					            {
					                HuristicKillerValue = Double.MinValue / 2;
					            }
					            else
					            //When Enemy has Attacked.
					            if (Killed > 0)
					            {
					                HuristicKillerValue = Double.MaxValue / 2;
	
					            }
					        }
	
					    }*/
				}
				else

				{
				/*
				    HuristicAttackValue += Huriistic[0];
				    HuristicKillerValue += Huriistic[1];
				    HuristicMovementValue += Huriistic[2];
				    HuristicObjectDangourCheckMateValue += (Huriistic[3] + HCheck);
				    HuristicReducedAttackValue += Huriistic[4];
				    HuristicSelfSupportedValue += Huriistic[5];
				    HeuristicDistabceOfCurrentMoveFromEnemyKingValue += HDistance;
				    HeuristicKingSafe += HKingSafe;
				    HeuristicFromCenter += HFromCenter;
				    HeuristicKingDangour += HKingDangour;
				    */

					HuristicAttackValue += (Huriistic[0] * SignOrderToPlate(Order));
					HuristicKillerValue += (Huriistic[1] * SignOrderToPlate(Order));
					HuristicMovementValue = Huriistic[2] * SignOrderToPlate(Order);
					HuristicObjectDangourCheckMateValue += ((Huriistic[3] + HCheck) * SignOrderToPlate(Order));
					HuristicReducedAttackValue += (Huriistic[4] * SignOrderToPlate(Order));
					HuristicSelfSupportedValue += (Huriistic[5] * SignOrderToPlate(Order));
					HeuristicDistabceOfCurrentMoveFromEnemyKingValue += (HDistance * SignOrderToPlate(Order));
					HeuristicKingSafe += (HKingSafe * SignOrderToPlate(Order));
					HeuristicFromCenter += (HFromCenter * SignOrderToPlate(Order));
					HeuristicKingDangour += (HKingDangour * SignOrderToPlate(Order));
					/*if (Killed != 0)
			  {
				  if (Order == 1)
				  {
					  //When Current Order is on Attack
					  if (Killed > 0)
					  {
					      HuristicKillerValue = Double.MinValue / 2;
					  }
					  else
					  //When Enemy has Attacked.
					  if (Killed < 0)
					  {
					      HuristicKillerValue = Double.MaxValue / 2;
	
					  }
				  }
				  else
				  {
					  //When Self is On attach
					  if (Killed < 0)
					  {
					      HuristicKillerValue = Double.MinValue / 2;
					  }
					  else
					  //When Enemy has on Attack.
					  if (Killed > 0)
					  {
					      HuristicKillerValue = Double.MaxValue / 2;
	
					  }
				  }
			  }*/

				}
			}
		}

	}

	void ThinkingChess::CastleThinkingGray(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			double HuristicAttackValue = double();
			double HuristicMovementValue = double();
			double HuristicSelfSupportedValue = double();
			double HuristicObjectDangourCheckMateValue = double();
			double HuristicKillerValue = double();
			double HuristicReducedAttackValue = double();
			double HeuristicDistabceOfCurrentMoveFromEnemyKingValue = double();
			double HeuristicKingSafe = double();
			double HeuristicFromCenter = double();
			double HeuristicKingDangour = double();

			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			ThinkingAtRun = true;
			int CheckedM = 0;
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			//When is Castles Gray King.
			//Predict Huristic Caluculatio Before Movments.
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				ThinkingRun = true;
			}

			//CalculateHuristics(true, 0, TableS, RowSource, ColumnSource, RowDestination, ColumnDestination, color,  HuristicAttackValue,  HuristicMovementValue,  HuristicSelfSupportedValue,  HuristicObjectDangourCheckMateValue,  HuristicKillerValue,  HuristicReducedAttackValue,  HeuristicDistabceOfCurrentMoveFromEnemyKingValue,  HeuristicKingSafe,  HeuristicFromCenter,  HeuristicKingDangour);
			////auto A = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (A)
			{
				NumbersOfAllNode++;
			}
			 bool Sup = false;
			if (TableS[RowDestination][ColumnDestination] > 0 && TableS[RowSource][ColumnSource] > 0)
			{
				IsSup.push_back(true);
				IsSupHu.push_back(true);
				Sup = true;
			}
			else
			{
		 if (TableS[RowDestination][ColumnDestination] < 0 && TableS[RowSource][ColumnSource] < 0)
		 {
				IsSup.push_back(true);
				IsSupHu.push_back(true);
				Sup = true;
		 }
			else
			{
				IsSup.push_back(false);
				IsSupHu.push_back(false);
				Sup = false;
			}
			}

			int Killed = 0;
			if (RowDestination < RowSource)
			{
				TableS[RowSource - 1][ColumnDestination] = 4;
				TableS[RowSource - 2][ColumnDestination] = 6;
				TableS[RowSource][ColumnSource] = 0;
				//TableS[0, ColumnSource] = 0;

			}

			else
			{
				TableS[RowSource + 1][ColumnDestination] = 4;
				TableS[RowSource + 2][ColumnDestination] = 6;
				TableS[RowSource][ColumnSource] = 0;
				//TableS[7, ColumnSource] = 0;

			}
			PenaltyMechanisam(LoseOcuuredatChiled, WinOcuuredatChiled, CheckedM, Killed, false, 7, TableS, RowSource, ColumnSource, Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle);

			//{ ThinkingAtRun = false; return; }

			//Store Movments Items.
			int AS[2];
			AS[0] = RowDestination;
			AS[1] = ColumnDestination;
			RowColumnKing.push_back(AS);
			TableListKing.push_back(CloneATable(TableS));
			IndexKing++;
			//Calculate Movment Huristic After Movments.
			//Caused this for Stachostic results.
			 CalculateHuristics(false, Killed, TableS, RowDestination, ColumnDestination, RowSource, ColumnSource, color, HuristicAttackValue, HuristicMovementValue, HuristicSelfSupportedValue, HuristicObjectDangourCheckMateValue, HuristicKillerValue, HuristicReducedAttackValue, HeuristicDistabceOfCurrentMoveFromEnemyKingValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour);
			std::wstring H = L"";
			double Hu[10];
			////auto A6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (A6)
			{
				HuristicPenaltyValuePerform(Current, Order, HuristicAttackValue);
				if (IgnoreFromCheckandMateHuristic)
				{
					HuristicObjectDangourCheckMateValue = 0;
				}
				Hu[0] += HuristicAttackValue;
				Hu[1] += HuristicMovementValue;
				Hu[2] += HuristicSelfSupportedValue;
				Hu[3] += HuristicObjectDangourCheckMateValue;
				Hu[4] += HuristicKillerValue;
				Hu[5] += HuristicReducedAttackValue;
				Hu[6] += HeuristicDistabceOfCurrentMoveFromEnemyKingValue;
				Hu[7] += HeuristicKingSafe;
				Hu[8] = HeuristicFromCenter;
				Hu[9] = HeuristicKingDangour;
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				H = std::wstring(L" HAttack:") + StringConverterHelper::toString(Hu[0]) + std::wstring(L" HMove:") + StringConverterHelper::toString<int>(Hu[1]) + std::wstring(L" HSelSup:") + StringConverterHelper::toString<int>(Hu[2]) + std::wstring(L" HCheckedMateDang:") + StringConverterHelper::toString<int>(Hu[3]) + std::wstring(L" HKiller:") + StringConverterHelper::toString<int>(Hu[4]) + std::wstring(L" HReduAttack:") + StringConverterHelper::toString<int>(Hu[5]) + std::wstring(L" HDisFromCurrentEnemyking:") + StringConverterHelper::toString<int>(Hu[6]) + std::wstring(L" HKingSafe:") + StringConverterHelper::toString<int>(Hu[7]) + std::wstring(L" HObjFromCeneter:") + StringConverterHelper::toString<int>(Hu[8]) + std::wstring(L" HKingDang:") + StringConverterHelper::toString<int>(Hu[9]);

			}
			////auto O7 = new Object();
			SetObjectNumbersInList(TableS);
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O7)
			{
				if (RowDestination < RowSource)
				{
					if (Order == 1)
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O-O") + std::wstring(L" With Huristic ") + H;
					}
					else
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O-O") + std::wstring(L" With Huristic ") + H;
					}
					ThinkingLevel++;
				}
				else
				{
					if (Order == 1)
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Bob at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O") + std::wstring(L" With Huristic ") + H;
					}
					else
					{
						AllDraw::OutPut += std::wstring(L"\r\nThinking Castle AStarGreedy By Level ") + StringConverterHelper::toString(CurrentAStarGredyMax) + std::wstring(L" Alice at ") + StringConverterHelper::toString(ThinkingLevel) + std::wstring(L"th Thinking String ") + std::wstring(L"O-O") + std::wstring(L" With Huristic ") + H;
					}
					ThinkingLevel++;
				}
				HuristicListKing.push_back(Hu);

				ThinkingAtRun = false;
			}
		}
		ThinkingAtRun = false;
	}

	void ThinkingChess::HuristicPenaltyValuePerform(QuantumAtamata Current, int Order, double &HuristicAttackValue, bool AllDrawClass = false)
	{

		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			if (LearningVarsObject.empty() || AllDrawClass)
			{
				if (AllDraw::OrderPlate == Order)
				{
					if (Current.IsPenaltyAction() == 0)
					{
						//HuristicAttackValue += (-300 / DivisionPenaltyRegardHeuristicQueficient);
						HuristicAttackValue--;
					}
				}
				else
				{
					if (AllDraw::OrderPlate != Order)
					{
					if (Current.IsPenaltyAction() == 0)
					{
						//HuristicAttackValue += (300 / DivisionPenaltyRegardHeuristicQueficient);
						HuristicAttackValue++;
					}
					}
				}
				if (AllDraw::OrderPlate == Order)
				{
					if (Current.IsRewardAction() == 1)
					{
						//HuristicAttackValue += (300 / DivisionPenaltyRegardHeuristicQueficient);
						HuristicAttackValue++;
					}
				}
				else
				{
					if (AllDraw::OrderPlate != Order)
					{
					if (Current.IsRewardAction() == 1)
					{
						//HuristicAttackValue += (-300 / DivisionPenaltyRegardHeuristicQueficient);
						HuristicAttackValue++;
					}
					}
				}
			}
			else
			{
				if ((LearningVarsObject[LearningVarsObject.size() - 1][1] && !LearningVarsObject[LearningVarsObject.size() - 1][4]))
				{
					if (AllDraw::OrderPlate == Order)
					{
						if (Current.IsPenaltyAction() == 0)
						{
							//HuristicAttackValue += (-1000000 / DivisionPenaltyRegardHeuristicQueficient);
							HuristicAttackValue -= 2;
						}
					}
					else
					{
					  if (AllDraw::OrderPlate != Order)
					  {
						if (Current.IsPenaltyAction() == 0)
						{
							//HuristicAttackValue += (1000000 / DivisionPenaltyRegardHeuristicQueficient);
							HuristicAttackValue += 2;
						}
					  }
					}
					if (AllDraw::OrderPlate == Order)
					{
						if (Current.IsRewardAction() == 1)
						{
							//HuristicAttackValue += (1000000 / DivisionPenaltyRegardHeuristicQueficient);
							HuristicAttackValue += 2;
						}
					}
					else
					{
						if (AllDraw::OrderPlate != Order)
						{
						if (Current.IsRewardAction() == 1)
						{
							//    HuristicAttackValue += (-1000000 / DivisionPenaltyRegardHeuristicQueficient);
							HuristicAttackValue -= 2;
						}
						}
					}
				}
			}
		}
	}

	void ThinkingChess::ThinkingSoldierBase(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					TableS[RowS][ColS] = TableConst[RowS][ColS];
				}
			}
			if (Scop(ii, jj, i, j, 1) && abs(TableS[ii][jj]) == 1 && abs(Kind) == 1)
			{
				Order = ord;

				SolderThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle);
			}
		}
	}

	void ThinkingChess::ThinkingSoldier(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////Parallel.For(ii - 2, ii + 3, i =>
			for (int i = ii - 2; i < ii + 3; i++)
			{
				////Parallel.For(jj - 2, jj + 3, j =>
				for (int j = jj - 2; j < jj + 3; j++)
				{
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					////lock (O)
					{

						if (Scop(ii, jj, i, j, 1))
						{
							ThinkingSoldierBase(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
							while (ThinkingAtRun)
							{
							}
						}

					}

				} //);
			} //);
		}
	}

	void ThinkingChess::ThinkingElephantBase(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];

			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				///Else for Elephant Thinking.
				if (Scop(ii, jj, i, j, 2) && abs(TableS[ii][jj]) == 2 && abs(Kind) == 2)
				{
					Order = ord;
					ElephantThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingElephant(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O2)
		{

			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				////Parallel.For(0, 8, i =>
				for (int i = 0; i < 8; i++)
				{
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					////lock (O)
					{


						int j = i + jj - ii;
						if (Scop(ii, jj, i, j, 2))
						{
							ThinkingElephantBase(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
							while (ThinkingAtRun)
							{
							}
						}

					}
				} //);
				//==================
				////Parallel.For(0, 8, i =>
				for (int i = 0; i < 8; i++)
				{
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					////lock (O)
					{

						int j = i * -1 + ii + jj;
						if (Scop(ii, jj, i, j, 2))
						{
							ThinkingElephantBase(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
							while (ThinkingAtRun)
							{
							}
						}

						ThinkingAtRun = false;
					}
				} //);
			}
		}
	}

	void ThinkingChess::ThinkingHourseOne(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];


			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				Order = ord;
				if (Scop(ii, jj, ii + 2, jj + 1, 3))
				{
					HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 2, jj + 1, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingHourseTwo(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];



			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					TableS[RowS][ColS] = TableConst[RowS][ColS];
				}
			}
			Order = ord;
			if (Scop(ii, jj, ii - 2, jj - 1, 3))
			{
				HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 2, jj - 1, Castle);
			}

		}
	}

	void ThinkingChess::ThinkingHourseThree(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];


			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				Order = ord;
				if (Scop(ii, jj, ii + 2, jj - 1, 3))
				{
					HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 2, jj - 1, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingHourseFour(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];


			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					TableS[RowS][ColS] = TableConst[RowS][ColS];
				}
			}
			Order = ord;
			if (Scop(ii, jj, ii - 2, jj + 1, 3))
			{
				HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 2, jj + 1, Castle);
			}
		}
	}

	void ThinkingChess::ThinkingHourseFive(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];



			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				Order = ord;
				if (Scop(ii, jj, ii + 1, jj + 2, 3))
				{
					HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 1, jj + 2, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingHourseSix(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];



			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				Order = ord;
				if (Scop(ii, jj, ii - 1, jj - 2, 3))
				{
					HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 1, jj - 2, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingHourseSeven(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];




			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O111 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O111)
			{
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				Order = ord;
				if (Scop(ii, jj, ii + 1, jj - 2, 3))
				{
					HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 1, jj - 2, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingHourseEight(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O111 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O111)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];


			///Initiate a Local Variables.

			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				Order = ord;
				if (Scop(ii, jj, ii - 1, jj + 2, 3))
				{
					HourseThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 1, jj + 2, Castle);
				}
			}
		}
	}

	void ThinkingChess::ThinkingHourse(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{

			ThinkingHourseOne(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			ThinkingHourseTwo(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O2)
		{

			ThinkingHourseThree(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O3)
		{

			ThinkingHourseFour(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O4 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O4)
		{

			ThinkingHourseFive(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O5 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O5)
		{

			ThinkingHourseSix(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O6 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O6)
		{

			ThinkingHourseSeven(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
		////auto O7 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O7)
		{

			ThinkingHourseEight(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			while (ThinkingAtRun)
			{
			}
		}
	}

	void ThinkingChess::ThinkingCastleOne(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{

		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////Parallel.For(0, 8, i =>
			for (int i = 0; i < 8; i++)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				////lock (O)
				{


					int j = jj;

					///Initiate a Local Variables.
					int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
					///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					for (int RowS = 0; RowS < 8; RowS++)
					{
						for (int ColS = 0; ColS < 8; ColS++)
						{
							TableS[RowS][ColS] = TableConst[RowS][ColS];
						}
					}
					if (Scop(ii, jj, i, j, 4) && abs(TableS[ii][jj]) == 4 && abs(Kind) == 4)
					{
						while (ThinkingAtRun)
						{
						}
						Order = ord;
						CastlesThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle);
					}
				}
			} //);
		}
	}

	void ThinkingChess::ThinkingCastleTow(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{ //==================
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			////Parallel.For(0, 8, j =>
			for (int j = 0; j < 8; j++)
			{
				////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				////lock (O)
				{


					int i = ii;

					///Initiate a Local Variables.
					int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
					///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
					QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
					for (int RowS = 0; RowS < 8; RowS++)
					{
						for (int ColS = 0; ColS < 8; ColS++)
						{
							TableS[RowS][ColS] = TableConst[RowS][ColS];
						}
					}
					if (Scop(ii, jj, i, j, 4) && abs(TableS[ii][jj]) == 4 && abs(Kind) == 4)
					{
						while (ThinkingAtRun)
						{
						}
						Order = ord;
						CastlesThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle);
					}

				}

			} //);
		}
	}

	void ThinkingChess::ThinkingCastle(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{

		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			ThinkingCastleOne(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
			ThinkingCastleTow(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
		}

	}

	void ThinkingChess::ThinkingMinisterBase(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{



			///Initiate a Local Variables.
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				while (ThinkingAtRun)
				{
				}
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				if (Scop(ii, jj, i, j, 5) && abs(TableS[ii][jj]) == 5 && abs(Kind) == 5)
				{
					while (ThinkingAtRun)
					{
					}
					Order = ord;
					MinisterThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle);
				}

			}
		}
	}

	void ThinkingChess::ThinkingMinister(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{

			////Parallel.For(0, 8, i =>
			for (int i = 0; i < 8; i++)
			{
				////Parallel.For(0, 8, j =>
				for (int j = 0; j < 8; j++)
				{
					////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					////lock (O)
					{

						ThinkingMinisterBase(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);

					}
				} //);
			} //);
		}
	}

	void ThinkingChess::ThinkingCastleGray(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			for (int i = ii - 2; i < ii + 2; i++)
			{
				while (ThinkingAtRun)
				{
				}



				///Initiate a Local Variables.
				int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
				///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
				QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				///Calculate of Castles of Brown.
				if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, -7, TableS, Order, ii, jj))->Rules(ii, jj, i, jj, color, -7) && (ChessRules::CastleKingAllowedBrown))
				{
					CastleThinkingBrown(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, jj, Castle);
				}
				ThinkingAtRun = false;
			}
		}

	}

	void ThinkingChess::ThinkingCastleBrown(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			for (int i = ii - 2; i < ii + 2; i++)
			{
				while (ThinkingAtRun)
				{
				}


				///Initiate a Local Variables.
				int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
				///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
				QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
				for (int RowS = 0; RowS < 8; RowS++)
				{
					for (int ColS = 0; ColS < 8; ColS++)
					{
						TableS[RowS][ColS] = TableConst[RowS][ColS];
					}
				}
				if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, 7, TableS, Order, ii, jj))->Rules(ii, jj, i, jj, color, 7) && (ChessRules::CastleKingAllowedGray))
				{
					CastleThinkingGray(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, jj, Castle);
				}
				ThinkingAtRun = false;
			}

		}
	}

	void ThinkingChess::ThinkingKing(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
	{
		////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
			////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			////lock (O)
			{
				////Parallel.For(ii - 1, ii + 2, i =>
				for (int i = ii - 1; i < ii + 2; i++)
				{
					////Parallel.For(jj - 1, jj + 2, j =>
					for (int j = jj - 1; j < jj + 2; j++)
					{


						if (i == ii && j == jj)
						{
							continue;
						}
						///Initiate a Local Variables.
						
						int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
						///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
						QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
						for (int RowS = 0; RowS < 8; RowS++)
						{
							for (int ColS = 0; ColS < 8; ColS++)
							{
								TableS[RowS][ColS] = TableConst[RowS][ColS];
							}
						}
						if (Scop(ii, jj, i, j, 6) && abs(TableS[ii][jj]) == 6 && abs(Kind) == 6)
						{
							while (ThinkingAtRun)
							{
							}
							Order = ord;
							KingThinkingChess(LoseOcuuredatChiled, WinOcuuredatChiled, DummyOrder, DummyCurrentOrder, TableS, ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle);
						}
					} //);
				} //);
			}
		}
	}

	void ThinkingChess::Thinking(int &LoseOcuuredatChiled, int &WinOcuuredatChiled)
	{

		int ord = Order;
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			if (CurrentAStarGredyMax > AllDraw::MaxAStarGreedy)
			{
				ThinkingFinished = true;
				return;
			}
			while (!ThinkingBegin)
			{
				//delay(2);
			} // S += 2; if (AllDraw.Blitz) { if (S > ThresholdBlitz)break; } else { if (S > ThresholdFullGame)break; } }

			NumberOfPenalties = 0;
			SetObjectNumbers(CloneATable(TableConst));
			bool PenRegStrore = true;
			// if (Order == AllDraw.OrderPlate)
			//  PenRegStrore = false;

			//Thread.Sleep(500);
			////auto O1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O1)
			{
				BeginThread++;
			}
			{
			//bool ASS = false; Object OOOAAA = new Object(); //lock (OOOAAA) { ASS = AllDraw.Blitz; }  if (!ASS)
				if (FoundFirstSelfMating > AllDraw::MaxAStarGreedy) //CheckMateOcuured ||
				{
					////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O2)
					{
						AllDraw::OutPut += std::wstring(L"\r\nBoundry Condition at Thinking at ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating) + std::wstring(L" Checkmate SELF");
						ThinkingBegin = false;
						ThinkingFinished = true;
						EndThread++;
					}
					return;
				}
				if (FoundFirstMating > AllDraw::MaxAStarGreedy) //CheckMateOcuured ||
				{
					////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O2)
					{
						AllDraw::OutPut += std::wstring(L"\r\nBoundry Condition at Thinking at ") + StringConverterHelper::toString(ThinkingChess::FoundFirstMating) + std::wstring(L" Checkmate ENEY");
						ThinkingBegin = false;
						ThinkingFinished = true;
						EndThread++;
					}
					return;
				}

			}
			int DummyOrder = Order;
			int DummyCurrentOrder = ChessRules::CurrentOrder;
			//Initiate Locallly Global Variables. 
			IndexSoldier = 0;
			IndexElefant = 0;
			IndexHourse = 0;
			IndexCastle = 0;
			IndexMinister = 0;
			IndexKing = 0;
			int**TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			///Most Dot Net FrameWork Hot Path
			///Create A Clone of Current Table Constant in ThinkingChess Object Tasble.
		   /* for (int RowS = 0; RowS < 8; RowS++)
		        for (int ColS = 0; ColS < 8; ColS++)
		        {
		            TableS[RowS, ColS] = TableConst[RowS, ColS];
		        }
		    */
			///For Stored Location of Objects.
			int ii = Row;
			int jj = Column;
			if (CheckMateOcuured || FoundFirstMating > AllDraw::MaxAStarGreedy)
			{

				////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					AllDraw::OutPut += std::wstring(L"\r\nBoundry Condition at Thinking at ") + StringConverterHelper::toString(ThinkingChess::FoundFirstMating) + std::wstring(L" Checkmate ENEMY");
					ThinkingFinished = true;
					ThinkingBegin = false;
					EndThread++;
				}
				return;
			}
			if (CheckMateOcuured || FoundFirstSelfMating > AllDraw::MaxAStarGreedy)
			{

				////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					AllDraw::OutPut += std::wstring(L"\r\nBoundry Condition at Thinking at ") + StringConverterHelper::toString(ThinkingChess::FoundFirstSelfMating) + std::wstring(L" Checkmate SLEF");
					ThinkingFinished = true;
					ThinkingBegin = false;
					EndThread++;
				}
				return;
			}
			IgnoreObjectDangour = -1;
			///Initiate a Local Variables.
			TableS = new int*[8]; for (int g = 0; g < 8; g++)TableS[g] = new int[8];
			///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
			QuantumAtamata Current =  QuantumAtamata(3, 3, 3);
			///Most Dot Net FrameWork Hot Path
			///Create A Clone of Current Table Constant in ThinkingChess Object Tasble.
			for (int RowS = 0; RowS < 8; RowS++)
			{
				for (int ColS = 0; ColS < 8; ColS++)
				{
					TableS[RowS][ColS] = TableConst[RowS][ColS];
				}
			}
			///Deterimine for Castle King Wrongly Desision.
			bool Castle = false;
			//ExistInDestinationEnemy = false;
			bool DoEnemySelf = true;
			ChessRules AAA = ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, TableS[ii][jj], TableS, AllDraw::OrderPlate, ii, jj);
			if (AAA.CheckMate(TableS, AllDraw::OrderPlate))
			{
				if (AAA.CheckMateGray || AAA.CheckMateBrown)
				{
					////auto O2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O2)
					{
						AllDraw::OutPut += std::wstring(L"\r\nBoundry Condition at Thinking at ") + StringConverterHelper::toString(ThinkingChess::FoundFirstMating) + std::wstring(L" Checkmate");
						ThinkingFinished = true;
						CheckMateOcuured = true;
						if ((AAA.CheckGray && AllDraw::OrderPlate == 1) || (AAA.CheckBrown && AllDraw::OrderPlate == -1) || (AAA.CheckMateGray && AllDraw::OrderPlate == 1) || (AAA.CheckMateBrown && AllDraw::OrderPlate == -1))
						{
							FoundFirstSelfMating++;
							LoseOcuuredatChiled = -2;
						}
						if ((AAA.CheckMateGray && AllDraw::OrderPlate == -1) || (AAA.CheckMateBrown && AllDraw::OrderPlate == 1))
						{
							WinOcuuredatChiled = 3;
							FoundFirstMating++;
						}
						EndThread++;
					}
					return;
				}
			}
			if (Order == 1 && AAA.CheckGray)
			{
				IgnoreObjectDangour = 0;
				IsCheck = true;
				DoEnemySelf = false;
			}
			if (Order == -1 && AAA.CheckBrown)
			{
				IgnoreObjectDangour = 0;
				IsCheck = true;
				DoEnemySelf = false;
			}

			//When Root is CheckMate Benefit of Current Order No Consideration.
			int CDumnmy = ChessRules::CurrentOrder;
			bool EnemyCheckMateActionsString = false;
			Order = DummyOrder;
			ChessRules::CurrentOrder = DummyCurrentOrder;
			///Calculate Castles of Gray King.
			///


				if (Kind == 7)
				{
					ThinkingCastleBrown(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
				}
				else
				{
					if (Kind == -7)
					{
					ThinkingCastleGray(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
					}
				else
				{
						if (abs(Kind) == 1) ///For Soldier Thinking
						{
					ThinkingSoldier(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
						}
				else
				{
							if (abs(Kind) == 2) ///For Elephant Thinking
							{
					ThinkingElephant(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
							}
				///Else for Hourse Thinking.
				else
				{
								if (abs(Kind) == 3) ///For Hourse Thinking
								{
					ThinkingHourse(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
								}
				///Else For Castles Thinking.
				else
				{
									if (abs(Kind) == 4) ///For Castle Thinking
									{
					ThinkingCastle(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
									}
				///Else for Minister Thinkings.
				else
				{
										if (abs(Kind) == 5) ///For Minister Thinking
										{
					ThinkingMinister(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);
										}
				///Else For Kings Thinkings.
				else
				{
											if (abs(Kind) == 6) ///For King Thinking
											{
					ThinkingKing(LoseOcuuredatChiled, WinOcuuredatChiled, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle);

											}
				}
				}
				}
				}
				}
				}
				}

			////auto O3 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (O3)
			{
				///Initiate Global Varibales at END.
				ThinkingBegin = false;
				///This Variable Not Work! 
				ThinkingFinished = true;

				Order = DummyOrder;
				ChessRules::CurrentOrder = DummyCurrentOrder;
				EndThread++;
			}
			//UsePenaltyRegardMechnisamT = PenRegStrore;
			//
			///Return at End.
		}
		return;
	}

	double ThinkingChess::RetrunValValue(int RowS, int ColS, int RowO, int ColO, int **Tab, int Sign)
	{
		double O = 0;
		if (RowO == -1 && ColO == -1)
		{
			O = abs(Tab[RowS][ColS]);
		}
		else
		{
			O = abs(Tab[RowS][ColS]) + abs(Tab[RowO][ColO]);
		}
		O *= Sign;
		return O;
	}

	double ThinkingChess::ObjectValueCalculator(int **Table, int RowS, int ColS, int RowO, int ColumnO)
	{
		double Val = 1;
		/*
		ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[RowS, ColS], Table, Order, RowS, ColS);
		Object O1 = new Object();
		//lock (O1)
		{
	
		    //if (BeginArragmentsOfOrderFinished(Tabl, Order))
		    {
	
	
		        int a = int.Gray;
		        int aa = int.Gray;
		        if (Order == -1)
		            a = int.Brown;
		        if (Order * -1 == -1)
		            aa = int.Brown;
		        ////Parallel.For(0, 8, RowO =>
		        //for (int RowO = 0; RowO < 8; RowO++)
	
		        ////Parallel.For(0, 8, ColumnO =>
		        //for (int ColumnO = 0; ColumnO < 8; ColumnO++)
		        {
		            //for (int RowS = 0; RowS < 8; RowS++)
		            ////Parallel.For(0, 8, RowS =>
		            {
		                /////Parallel.For(0, 8, ColS =>
		                //for (int ColS = 0; ColS < 8; ColS++)
		                {
	
	
		                    Object O = new Object();
		                    ////lock (O)
		                    {
	
	
		                        if (Scop(RowS, ColS, RowO, ColumnO, System.Math.Abs(Table[RowS, ColS])))
		                        {
		                            int AAB = int.Gray;
		                            int Ord = 0;
		                              if (SignEqualSelf(Table[RowS, ColS], Table[RowO, ColumnO], Order,  Ord,  AAB))
		                            {
		                                if (Support(Table, RowS, ColS, RowO, ColumnO, AAB, Ord))
		                                    Val++;//Val += (Val + RetrunValValue(RowS, ColS, RowO, ColumnO, Table, 1));
		                                //else
		                                    //Val--;
		                            }
		                            else
		                            if (SignNotEqualSelf(Table[RowS, ColS], Table[RowO, ColumnO], Order,  Ord,  AAB))
		                            {
		                                if (Attack(Table, RowS, ColS, RowO, ColumnO, AAB, Ord))
		                                    Val++;//Val += (Val + RetrunValValue(RowS, ColS, RowO, ColumnO, Table, 1));
		                                //else
		                                    //Val--;
		                            }//when there is self support inc.                                                                                            
		                        }
		                        else
		                        if (Scop(RowO, ColumnO, RowS, ColS, System.Math.Abs(Table[RowO, ColumnO])))
		                        {
		                            int AAB = int.Gray;
		                            int Ord = 0;
		                            if (SignEnemyEmpty(Table[RowO, ColumnO], Table[RowS, ColS], Order,  Ord,  AAB))
		                            {
		                                if (Support(Table, RowO, ColumnO, RowS, ColS, AAB, Ord))
		                                    Val--;//Val += (Val + RetrunValValue(RowS, ColS, RowO, ColumnO, Table, 1));
		                                //else
		                                    //Val--;
		                            }
		                            else
		                                if (SignNotEqualEnemy(Table[RowO, ColumnO], Table[RowS, ColS], Order,  Ord,  AAB))
		                            {
		                                if (Attack(Table, RowO, ColumnO, RowS, ColS, AAB, Ord))
		                                    Val--;//Val += (Val + RetrunValValue(RowS, ColS, RowO, ColumnO, Table, 1));
		                                //else
		                                    //Val++;
		                            }//when there is self support inc.                                                                                            else
		                        }
		                    }
		                }
	
		            }//);
		        }//)/\;
		    }//));
		    A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Table[RowS, ColS], Table, Order, RowS, ColS);
		    if (A.ObjectDangourKingMove(Order, Table, false,RowS,ColS))
		    {
		        if (Order == 1 && A.CheckGrayObjectDangour)
		            Val--;
		        //else
		            //Val++;
		        if (Order == -1 && A.CheckBrownObjectDangour)
		            Val--;
		        //else
		            //Val++;
		        if (Order == -1 && A.CheckGrayObjectDangour)
		            Val++;//Val += RetrunValValue(RowS, ColS, -1, -1, Table, 1);
		        //else
		            ///Val--;
		        if (Order == 1 && A.CheckBrownObjectDangour)
		            Val++;//Val += RetrunValValue(RowS, ColS, -1, -1, Table, 1);
		        ///else
		            //Val--;
		        
		    }
		   */
		if (Table[RowS][ColS] / Order > 0)
		{
			if (abs(Table[RowS][ColS]) == 2)
			{
				Val = Val * 3;
			}
			else
			{
					if (abs(Table[RowS][ColS]) == 3)
					{
				Val = Val * 3;
					}
			else
			{
						if (abs(Table[RowS][ColS]) == 4)
						{
				Val = Val * 5;
						}
			else
			{
							if (abs(Table[RowS][ColS]) == 5)
							{
				Val = Val * 9;
							}
			else
			{
							if (abs(Table[RowS][ColS]) == 6)
							{
				Val = Val * 10;
							}
			}
			}
			}
			}
		}
		else
		{
		if (Table[RowO][ColumnO] / Order > 0)
		{
			if (abs(Table[RowO][ColumnO]) == 2)
			{
				Val = Val * 3;
			}
			else
			{
			   if (abs(Table[RowO][ColumnO]) == 3)
			   {
				Val = Val * 3;
			   }
			else
			{
				   if (abs(Table[RowO][ColumnO]) == 4)
				   {
				Val = Val * 5;
				   }
			else
			{
					   if (abs(Table[RowO][ColumnO]) == 5)
					   {
				Val = Val * 9;
					   }
			else
			{
					   if (abs(Table[RowO][ColumnO]) == 6)
					   {
				Val = Val * 10;
					   }
			}
			}
			}
			}
		}
		}
		//}
		//       if (Val < 0)
		//         Val = 0;
		return Val;



		/*if (System.Math.Abs(Table[RowS, ColS]) == 1)
		{
		    Val = 1;
		}
		else
		if (System.Math.Abs(Table[RowS, ColS]) == 2)
		{
		    Val = 3;
		}
		else
		            if (System.Math.Abs(Table[RowS, ColS]) == 3)
		{
		    Val = 3;
		}
		else
		                if (System.Math.Abs(Table[RowS, ColS]) == 4)
		{
		    Val = 5;
		}
		else
		                    if (System.Math.Abs(Table[RowS, ColS]) == 5)
		{
		    Val = 9;
		}
		else
		                    if (System.Math.Abs(Table[RowS, ColS]) == 6)
		{
		    Val = 10;
		}
		return Val;*/
	}

	double ThinkingChess::ObjectValueCalculator(int **Table, int RowS, int ColS)
	{
		double Val = 1;



		if (abs(Table[RowS][ColS]) == 1)
		{
			Val = 1;
		}
		else
		{
		if (abs(Table[RowS][ColS]) == 2)
		{
			Val = 3;
		}
		else
		{
					if (abs(Table[RowS][ColS]) == 3)
					{
			Val = 3;
					}
		else
		{
						if (abs(Table[RowS][ColS]) == 4)
						{
			Val = 5;
						}
		else
		{
							if (abs(Table[RowS][ColS]) == 5)
							{
			Val = 9;
							}
		else
		{
							if (abs(Table[RowS][ColS]) == 6)
							{
			Val = 10;
							}
		}
		}
		}
		}
		}
		return Val;
	}

	bool ThinkingChess::SignSelfEmpty(int Obj1, int Obj2, int Order, int &Ord, int &A)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;

			if (Order == 1)
			{
				if (Obj1 > 0 && Obj2 == 0)
				{
					Is = true;
					A = 1;
					Ord = 1;
				}
			}
			else
			{
				if (Obj1 < 0 && Obj2 == 0)
				{
					Is = true;
					A = -1;
					Ord = -1;
				}
			}

			return Is;
		}
	}

	bool ThinkingChess::SignEnemyEmpty(int Obj1, int Obj2, int Order, int &Ord, int &A)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;

			if (Order == 1)
			{
				if (Obj1 < 0 && Obj2 == 0)
				{
					Is = true;
					A = -1;
					Ord = -1;
				}
			}
			else
			{
				if (Obj1 > 0 && Obj2 == 0)
				{
					Is = true;
					A = 1;
					Ord = 1;
				}
			}

			return Is;
		}
	}

	bool ThinkingChess::SignNotEqualEnemy(int Obj1, int Obj2, int Order, int &Ord, int &A)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;


			if (Order == 1)
			{
				if (Obj1 < 0 && Obj2 > 0)
				{
					Is = true;
					A = -1;
					Ord = -1;
				}
			}
			else
			{
				if (Obj1 > 0 && Obj2 < 0)
				{
					Is = true;
					A = 1;
					Ord = 1;
				}
			}

			return Is;
		}
	}

	bool ThinkingChess::SignEqualSelf(int Obj1, int Obj2, int Order, int &Ord, int &A)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;


			if (Order == 1)
			{
				if (Obj1 > 0 && Obj2 > 0)
				{
					Is = true;
					A = 1;
					Ord = 1;
				}
			}
			else
			{
				if (Obj1 < 0 && Obj2 < 0)
				{
					Is = true;
					A = -1;
					Ord = -1;
				}
			}

			return Is;
		}
	}

	bool ThinkingChess::SignNotEqualSelf(int Obj1, int Obj2, int Order, int &Ord, int &A)
	{
		////auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		////lock (O)
		{
			bool Is = false;
			if (Order == 1)
			{
				if (Obj1 > 0 && Obj2 < 0)
				{
					Is = true;
					A = 1;
					Ord = 1;
				}
			}
			else
			{
				if (Obj1 < 0 && Obj2 > 0)
				{
					Is = true;
					A = -1;
					Ord = -1;
				}
			}
			return Is;
		}
	}

	void ThinkingChess::InitializeInstanceFields()
	{
		HuristicAttackValueSup = double();
		HuristicMovementValueSup = double();
		HuristicSelfSupportedValueSup = double();
		HuristicObjectDangourCheckMateValueSup = double();
		HuristicKillerValueSup = double();
		HuristicReducedAttackValueSup = double();
		HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup = double();
		HeuristicKingSafeSup = double();
		HeuristicFromCenterSup = double();
		HeuristicKingDangourSup = double();
		IsSup = std::vector<bool>();
		IsSupHu = std::vector<bool>();
		//callStack = new StackFrame(1, true);
		IsThereMateOfEnemy = false;
		IsThereMateOfSelf = false;
		ThinkingAtRun = false;
		OutPutAction = L"";
		ThinkingLevel = 0;
		LearningVarsObject = std::vector<bool*>();
		IsGardHighPriority = false;
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = false;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		ArrangmentsChanged = false;
		NumberOfPenalties = 0;
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
		SodierValue = 1 * 3;
		ElefantValue = 2 * 16;
		HourseValue = 3 * 8;
		CastleValue = 5 * 16;
		MinisterValue = 8 * 32;
		KingValue = 10 * 8;
		ExistingOfEnemyHiiting = false;
		IgnoreObjectDangour = -1;
		CheckMateAStarGreedy = 0;
		CheckMateOcuured = false;
		CurrentRow = -1;
		CurrentColumn = -1;
		IsCheck = false;
		Kind = 0;
		HitNumber = std::vector<int>();
		ThingsNumber = 0;
		CurrentArray = 0;
		ThinkingBegin = false;
		ThinkingFinished = false;
		IndexSoldier = 0;
		IndexElefant = 0;
		IndexHourse = 0;
		IndexCastle = 0;
		IndexMinister = 0;
		IndexKing = 0;
		RowColumnSoldier = std::vector<int*>();
		RowColumnElefant = std::vector<int*>();
		RowColumnHourse = std::vector<int*>();
		RowColumnCastle = std::vector<int*>();
		RowColumnMinister = std::vector<int*>();
		RowColumnKing = std::vector<int*>();
		HitNumberSoldier = std::vector<int>();
		HitNumberElefant = std::vector<int>();
		HitNumberHourse = std::vector<int>();
		HitNumberCastle = std::vector<int>();
		HitNumberMinister = std::vector<int>();
		HitNumberKing = std::vector<int>();
		TableListSolder = std::vector<int**>();
		TableListElefant = std::vector<int**>();
		TableListHourse = std::vector<int**>();
		TableListCastle = std::vector<int**>();
		TableListMinister = std::vector<int**>();
		TableListKing = std::vector<int**>();
		HuristicListSolder = std::vector<double*>();
		HuristicListElefant = std::vector<double*>();
		HuristicListHourse = std::vector<double*>();
		HuristicListCastle = std::vector<double*>();
		HuristicListMinister = std::vector<double*>();
		HuristicListKing = std::vector<double*>();
		PenaltyRegardListSolder = std::vector<QuantumAtamata>();
		PenaltyRegardListElefant = std::vector<QuantumAtamata>();
		PenaltyRegardListHourse = std::vector<QuantumAtamata>();
		PenaltyRegardListCastle = std::vector<QuantumAtamata>();
		PenaltyRegardListMinister = std::vector<QuantumAtamata>();
		PenaltyRegardListKing = std::vector<QuantumAtamata>();
		Max = 0;
		Row = 0;
		Column = 0;
		Order = 0;
		//t = 0;
		AStarGreedy = std::vector<AllDraw>();
		IgnoreFromCheckandMateHuristic = false;
		CurrentAStarGredyMax = -1;
		ObjectNumbers = std::vector<int**>();
	}
}
