#include "stdafx.h"

namespace RefrigtzDLL
{

bool ChessGeneticAlgorithm::NoGameFounf = false;

	/*void ChessGeneticAlgorithm::Log(std::exception &ex)
	{
		try
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
		catch (std::exception &t)
		{
			
		}
	}
	*/
	ChessGeneticAlgorithm::ChessGeneticAlgorithm(bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		InitializeInstanceFields();
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		ArrangmentsChanged = Arrangments;
		//Initiate Global Variables.
		RowColumn.clear();
	}

	bool ChessGeneticAlgorithm::FindHitToModified(int **Cromosom1, int** Cromosom2, std::vector<int**> &List, int Index, int Order, bool and)
	{
		bool Find = false;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (Order == 1 && Cromosom1[i][j] <= 0)
				{
					continue;
				}
				if (Order == -1 && Cromosom1[i][j] >= 0)
				{
					continue;
				}
				if (Order == 1)
				{
					if (Cromosom1[i][j] != Cromosom2[i][j])
					{
						if (Order == 1)
						{
							if (Cromosom1[i][j] > 0 && Cromosom2[i][j] < 0)
							{
								CromosomRowHit = i;
								CromosomColumnHit = j;
								Find = true;
								break;
							}
						}
						else
						{
							if (Cromosom1[i][j] < 0 && Cromosom2[i][j] > 0)
							{
								CromosomRowHit = i;
								CromosomColumnHit = j;
								Find = true;
								break;
							}

						}
					}
				}

			}
			if (Find)
			{
				break;
			}
		}
		return Find;
	}

	bool ChessGeneticAlgorithm::FindGenToModified(int **Cromosom1, int** Cromosom2, std::vector<int**> &List, int Index, int Order, bool and)
	{
		ChessRules::SmallKingCastleBrown = false;
		ChessRules::SmallKingCastleGray = false;
		ChessRules::BigKingCastleBrown = false;
		ChessRules::BigKingCastleGray = false;
		//Initiate Local Variables.
		bool Find = false;
		int FindNumber = 0;
		bool Bri = false;

		//For All Table Home
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				//Gray Order.
				if (Order == 1)
				{
					//Situation 11.
					if (and)
					{
						//All The Brown ObjectIgnored.
						if (Cromosom1[i][j] < 0 && Cromosom2[i][j] < 0)
						{
							continue;
						}
					}
					else ///Situation 2.
					{
						//All The Brown Ojects Ignored.
						if (Cromosom1[i][j] < 0 || Cromosom2[i][j] < 0)
						{
							continue;
						}
					}
				}
				else //Brown Order.
				{
					//Situation 1.
					if (and)
					{
						//All The Gray Objects Ignored.
						if (Cromosom1[i][j] > 0 && Cromosom2[i][j] > 0)
						{
							continue;
						}

					}
					else
					{
						//All The Gray Objects Ignored.
						if (Cromosom1[i][j] > 0 || Cromosom2[i][j] > 0)
						{
							continue;
						}
					}
				}
				if (!ArrangmentsChanged)
				{
					{
						if (Order == 1 && j == 6 && i > 0 && i < 7)
						{
							if (((Cromosom2[i][j + 1] > 0) || (Cromosom2[i + 1][j + 1] > 0 && Cromosom1[i + 1][j + 1] < 0) || (Cromosom2[i - 1][j + 1] > 0 && Cromosom1[i - 1][j + 1] < 0)) && Cromosom1[i][j] == 1)
							{
								CromosomRowFirst = i;
								CromosomColumnFirst = j;
								if (Cromosom2[i][j + 1] > 0)
								{
									CromosomRow = i;
									CromosomColumn = j + 1;
								}
								else if (Cromosom2[i + 1][j + 1] > 0 && Cromosom1[i + 1][j + 1] < 0)
								{
									CromosomRow = i + 1;
									CromosomColumn = j + 1;
								}
								else if (Cromosom2[i - 1][j + 1] > 0 && Cromosom1[i - 1][j + 1] < 0)
								{
									CromosomRow = i - 1;
									CromosomColumn = j + 1;
								}
								Find = true;
								FindNumber++;
								AllDraw::SodierConversionOcuured = true;

							}

						}
						else
						{
							if (Order == -1 && j == 1 && i > 0 && i < 7)
							{
								if (((Cromosom2[i][j - 1] < 0) || (Cromosom2[i + 1][j - 1] < 0 && Cromosom1[i + 1][j - 1] > 0) || (Cromosom2[i - 1][j - 1] < 0 && Cromosom1[i - 1][j - 1] < 0)) && Cromosom1[i][j] == -1)
								{
									CromosomRowFirst = i;
									CromosomColumnFirst = j;
									if (Cromosom2[i][j - 1] > 0)
									{
										CromosomRow = i;
										CromosomColumn = j - 1;
									}
									else if (Cromosom2[i + 1][j - 1] > 0 && Cromosom1[i + 1][j - 1] < 0)
									{
										CromosomRow = i + 1;
										CromosomColumn = j - 1;
									}
									else if (Cromosom2[i - 1][j - 1] > 0 && Cromosom1[i - 1][j - 1] < 0)
									{
										CromosomRow = i - 1;
										CromosomColumn = j - 1;
									}
									FindNumber++;
									AllDraw::SodierConversionOcuured = true;
								}
							}
						}

						//Castles King Validity Condition.
						if (Order == 1 && j == 0)
						{
							//Small Gray Castles King.
							if (i == 6 && Cromosom2[i][j] == 6 && Cromosom2[i + 1][j] == 4 && Cromosom1[i][j] != 6 && Cromosom1[i + 1][j] != 4)
							{
								CromosomRowFirst = i - 3;
								CromosomColumnFirst = j;
								CromosomRow = i;
								CromosomColumn = j;
								Find = true;
								FindNumber++;
								ChessRules::SmallKingCastleGray = true;
								Bri = true;
							}
							else //Big Briges King Gray.
							{
								if (i == 3 && Cromosom2[i][j] == 4 && Cromosom2[i - 1][j] == 6 && Cromosom1[i][j] != 4 && Cromosom1[i - 1][j] != 6)
								{
									CromosomRowFirst = i + 3;
									CromosomColumnFirst = j;
									CromosomRow = i;
									CromosomColumn = j;
									Find = true;
									FindNumber++;
									ChessRules::BigKingCastleGray = true;
									Bri = true;
								}
							}

						}
						else if (j == 7)
						{
							//Small Castles King Brown.
							if (i == 6 && Cromosom2[i][j] == -6 && Cromosom2[i + 1][j] == -4 && Cromosom1[i][j] != -6 && Cromosom1[i + 1][j] != -4)
							{
								//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O)
								{
									CromosomRowFirst = i - 3;
									CromosomColumnFirst = j;
									CromosomRow = i;
									CromosomColumn = j;
									Find = true;
									FindNumber++;
									ChessRules::SmallKingCastleBrown = true;
									Bri = true;
								}
							}
							else //Big Castles King Brown.
							{
								if (i == 3 && Cromosom2[i][j] == -4 && Cromosom2[i - 1][j] == -6 && Cromosom1[i][j] != -4 && Cromosom1[i - 1][j] != -6)
								{
								//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O)
								{
									CromosomRowFirst = i + 3;
									CromosomColumnFirst = j;
									CromosomRow = i;
									CromosomColumn = j;
									Find = true;
									FindNumber++;
									ChessRules::BigKingCastleBrown = true;
									Bri = true;
								}
								}
							}

						}

					}
				}
				else
				{
					{
						if (Order == 1 && j == 1 && i > 0 && i < 7)
						{
							if (((Cromosom2[i][j - 1] > 0) || (Cromosom2[i + 1][j - 1] > 0 && Cromosom1[i + 1][j - 1] < 0) || (Cromosom2[i - 1][j - 1] > 0 && Cromosom1[i - 1][j - 1] < 0)) && Cromosom1[i][j] == 1)
							{
								CromosomRowFirst = i;
								CromosomColumnFirst = j;
								if (Cromosom2[i][j - 1] > 0)
								{
									CromosomRow = i;
									CromosomColumn = j - 1;
								}
								else if (Cromosom2[i + 1][j - 1] > 0 && Cromosom1[i + 1][j - 1] < 0)
								{
									CromosomRow = i + 1;
									CromosomColumn = j - 1;
								}
								else if (Cromosom2[i - 1][j - 1] > 0 && Cromosom1[i - 1][j - 1] < 0)
								{
									CromosomRow = i - 1;
									CromosomColumn = j - 1;
								}
								FindNumber++;
								AllDraw::SodierConversionOcuured = true;

							}

						}
						else
						{
							if (Order == -1 && j == 6 && i > 0 && i < 7)
							{
								if (((Cromosom2[i][j + 1] < 0) || (Cromosom2[i + 1][j + 1] < 0 && Cromosom1[i + 1][j + 1] > 0) || (Cromosom2[i - 1][j + 1] < 0 && Cromosom1[i - 1][j + 1] < 0)) && Cromosom1[i][j] == -1)
								{
									CromosomRowFirst = i;
									CromosomColumnFirst = j;
									if (Cromosom2[i][j + 1] > 0)
									{
										CromosomRow = i;
										CromosomColumn = j + 1;
									}
									else if (Cromosom2[i + 1][j + 1] > 0 && Cromosom1[i + 1][j + 1] < 0)
									{
										CromosomRow = i + 1;
										CromosomColumn = j + 1;
									}
									else if (Cromosom2[i - 1][j + 1] > 0 && Cromosom1[i - 1][j + 1] < 0)
									{
										CromosomRow = i - 1;
										CromosomColumn = j + 1;
									}
									Find = true;
									FindNumber++;
									AllDraw::SodierConversionOcuured = true;
								}
							}
						}

						//Castles King Validity Condition.
						if (Order == 1 && j == 7)
						{
							//Small Gray Castles King.
							if (i == 6 && Cromosom2[i][j] == 6 && Cromosom2[i + 1][j] == 4 && Cromosom1[i][j] != 6 && Cromosom1[i + 1][j] != 4)
							{
								CromosomRowFirst = i - 3;
								CromosomColumnFirst = j;
								CromosomRow = i;
								CromosomColumn = j;
								Find = true;
								FindNumber++;
								ChessRules::SmallKingCastleGray = true;
								Bri = true;
							}
							else //Big Briges King Gray.
							{
								if (i == 3 && Cromosom2[i][j] == 4 && Cromosom2[i - 1][j] == 6 && Cromosom1[i][j] != 4 && Cromosom1[i - 1][j] != 6)
								{
									CromosomRowFirst = i + 3;
									CromosomColumnFirst = j;
									CromosomRow = i;
									CromosomColumn = j;
									Find = true;
									FindNumber++;
									ChessRules::BigKingCastleGray = true;
									Bri = true;
								}
							}

						}
						else if (j == 0)
						{
							//Small Castles King Brown.
							if (i == 6 && Cromosom2[i][j] == -6 && Cromosom2[i + 1][j] == -4 && Cromosom1[i][j] != -6 && Cromosom1[i + 1][j] != -4)
							{
								//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O)
								{
									CromosomRowFirst = i - 3;
									CromosomColumnFirst = j;
									CromosomRow = i;
									CromosomColumn = j;
									Find = true;
									FindNumber++;
									ChessRules::SmallKingCastleBrown = true;
									Bri = true;
								}
							}
							else //Big Castles King Brown.
							{
								if (i == 3 && Cromosom2[i][j] == -4 && Cromosom2[i - 1][j] == -6 && Cromosom1[i][j] != -4 && Cromosom1[i - 1][j] != -6)
								{
								//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
								//lock (O)
								{
									CromosomRowFirst = i + 3;
									CromosomColumnFirst = j;
									CromosomRow = i;
									CromosomColumn = j;
									Find = true;
									FindNumber++;
									ChessRules::BigKingCastleBrown = true;
									Bri = true;
								}
								}
							}

						}

					}
				}

				//When To Same Location Tbles are Different in Gen.
				if (Cromosom1[i][j] != Cromosom2[i][j])
				{
					//When Cromosom 2 is Empty.
					if (Cromosom2[i][j] == 0)
					{
						//Initiate Location of Table.
						CromosomRowFirst = i;
						CromosomColumnFirst = j;
						continue;
					}
					else
					{
						//Situation 1.
						if (and)
						{
							//When Cromosom1 Current Location is Empty.
							if (Cromosom1[i][j] == 0)
							{
								//Initiate Location of Gen.
								CromosomRow = i;
								CromosomColumn = j;
								Find = true;
								FindNumber++;
								Ki = List[Index][CromosomRow][CromosomColumn];
								continue;
							}
						}

					}
					//Store Location of Gen and Calculate Gen Numbers.
					CromosomRow = i;
					CromosomColumn = j;
					Find = true;
					FindNumber++;
					Ki = List[Index][CromosomRow][CromosomColumn];

				}


			}
		}
		//If Gen Foundation is Valid. 
		if (((FindNumber == 1 || FindNumber == 2) && Find) || Bri || AllDraw::SodierConversionOcuured)
		{
			return Find;
		}
		//Gen Not Found.
		return false;
	}

	int **ChessGeneticAlgorithm::GenerateTable(std::vector<int**> &List, int Index, int Order)
	{
	//Initiate Local Variables.
	Begine5:
		RowColumn.clear();
		int Store = Index;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Cromosom1 = nullptr;
		int **Cromosom1 = nullptr;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: int[,] Cromosom2 = nullptr;
		int **Cromosom2 = nullptr;

		Cromosom1 = List[List.size() - 2];		
		Cromosom2 = List[List.size() - 1];

		Index = Store;
		//Found of Gen.
		if (!FindGenToModified(Cromosom1, Cromosom2, List, Index, Order, false))
		{
			goto EndFindAThing;
		}





		//Initiate Global Variables.
	BeginFind:
		int color = 1;
		if (Order == -1)
		{
			color = -1;
		}
		try
		{
			//If Cromosom Location is Not Founded.
			if (CromosomRow == -1 && CromosomColumn == -1)
			{
				//Initiayte Local Variables.
				List.pop_back();
				Index--;
				goto Begine5;
			}
			//Found Kind Of Gen.
			Ki = List[List.size() - 1][CromosomRow][CromosomColumn];
			//Initiate Local Variables.
			GeneticTable = new int*[8];
			for (int i = 0; i > 8; i++)
				GeneticTable[i] = new int[8];
			//If Gen Kind Not Found Retrun Not Valididity.
			if (List[List.size() - 1][CromosomRow][CromosomColumn] == 0)
			{
				return nullptr;
			}
			else
			{
				//Clone a Copy.
				for (int ii = 0; ii < 8; ii++)
				{
					for (int jj = 0; jj < 8; jj++)
					{
						GeneticTable[ii][jj] = List[List.size() - 1][ii][jj];
					}
				}
					;
			}
			//Initiate Global and Local Variables.
			color = 1;
			if (Order == -1)
			{
				color = -1;
			}
			//For All Gens.
			for (Gen1 = 0; Gen1 < 8; Gen1++)
			{
				for (Gen2 = 0; Gen2 < 8; Gen2++)
				{
					//If Gen is Current Gen Location Continue Traversal Back.
					if (Gen1 == CromosomRow && Gen2 == CromosomColumn)
					{
						continue;
					}
					//Rulement of Gen Movments.
					if ((new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, GeneticTable[CromosomRow][CromosomColumn], GeneticTable, Order, CromosomRow, CromosomColumn))->Rules(CromosomRow, CromosomColumn, Gen1, Gen2, color, GeneticTable[CromosomRow][CromosomColumn]))
					{
						//Initiate Global Variables and Syntax.
						int A[2];
						A = CromosomRow;
						A[1] = CromosomColumn;
						RowColumn.push_back(A);



						GeneticTable[Gen1][Gen2] = GeneticTable[CromosomRow][CromosomColumn];
						GeneticTable[CromosomRow][CromosomColumn] = 0;
						//Table Repeatative Consideration.
						if (ThinkingChess::ExistTableInList(GeneticTable, List, 0))
						{
							GeneticTable[CromosomRow][CromosomColumn] = GeneticTable[Gen1][Gen2];
							GeneticTable[Gen1][Gen2] = 0;
							continue;

						}
						else
						{
							//Check Consideration.
							if ((new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, GeneticTable[CromosomRow][CromosomRow], GeneticTable, Order, CromosomRow, CromosomColumn))->Check(GeneticTable, Order))
							{
								GeneticTable[CromosomRow][CromosomColumn] = GeneticTable[Gen1][Gen2];
								GeneticTable[Gen1][Gen2] = 0;
								continue;
							}

							else
							{

								//Return Genetic Table.
								return GeneticTable;
							}

						}
					}


				}
			}
			//Initiate Try Catch.
			GeneticTable = nullptr;
			int a = GeneticTable;
		}

		catch (NullReferenceException t)
		{
			//Try Catch Expetion Handling of Not Successful Foundation of Gen.
			
			if (Order == 1)
			{
				Ki = (new Random())->Next(1, 7);
			}
			else
			{
				Ki = (new Random())->Next(1, 7) * -1;
			}

			if (Order == 1)
			{
				int Count = 0;
				do
				{
					if (Ki < 6)
					{
						Ki++;
					}
					else
					{
						Ki = 1;
					}
					Count++;
				} while (Count < 6 && !(new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Ki, List[List.size() - 1], Order, CromosomRow, CromosomColumn))->FindAThing(List[List.size() - 1], CromosomRow, CromosomColumn, Ki, true, RowColumn));
				if (Count >= 6)
				{
					NoGameFounf = true;
					return nullptr;
				}


			}
			else
			{
				int Count = 0;
				do
				{
					if (Ki > -6)
					{
						Ki--;
					}
					else
					{
						Ki = -1;
					}
					Count++;
				} while (Count < 6 && !(new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Ki, List[List.size() - 1], Order, CromosomRow, CromosomColumn))->FindAThing(List[List.size() - 1], CromosomRow, CromosomColumn, Ki, true, RowColumn));
				if (Count >= 6)
				{
					NoGameFounf = true;
					return nullptr;
				}






			}

			goto BeginFind;
		}

	EndFindAThing:
		//Foudn of Some Samness Gen.
		if (Order == 1)
		{
			Ki = (rand() % 8);

		}
		else
		{
			Ki = (rand() % 8)*-1;
		}
		if (Order == 1)
		{
			int Count = 0;
			do
			{
				if (Ki < 6)
				{
					Ki++;
				}
				else
				{
					Ki = 1;
				}
				Count++;
			} while (Count < 6 && !(new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Ki, List[List.size() - 1], Order, CromosomRow, CromosomColumn))->FindAThing(List[List.size() - 1], CromosomRow, CromosomColumn, Ki, true, RowColumn));
			if (Count >= 6)
			{
				return nullptr;
			}

		}
		else
		{
			int Count = 0;
			do
			{
				if (Ki > -6)
				{
					Ki--;
				}
				else
				{
					Ki = -1;
				}
				Count++;
			} while (Count < 6 && !(new ChessRules(0, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Ki, List[List.size() - 1], Order, CromosomRow, CromosomColumn))->FindAThing(List[List.size() - 1], CromosomRow, CromosomColumn, Ki, true, RowColumn));
			if (Count >= 6)
			{
				return nullptr;
			}
		}

		goto BeginFind;


	}

	void ChessGeneticAlgorithm::InitializeInstanceFields()
	{
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		ArrangmentsChanged = false;
		CastlesKing = false;
		RowColumn = std::vector<int*>();
		Ki = 0;
		CromosomRow = -1;
		CromosomColumn = -1;
		CromosomRowHit = -1;
		CromosomColumnHit = -1;
		CromosomRowFirst = -1;
		CromosomColumnFirst = -1;
		Gen1 = 0;
		Gen2 = 0;
	}
}
