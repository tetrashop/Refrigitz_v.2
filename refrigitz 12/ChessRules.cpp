#pragma once
#include "ChessRules.h"
#include "AllDraw.h"
#include "ThinkingChess.h"
#include "DrawKing.h"

//namespace RefrigtzDLL
//{
	
int ChessRules::ObjectHittedRow = -1;
bool ChessRules::SelfHomeStatCP = false;
int ChessRules::ObjectHittedColumn = -1;
int ChessRules::NumbersofKingMovesToPatGray = 0;
int ChessRules::NumbersofKingMovesToPatBrown = 0;
bool ChessRules::PatCheckedInKingRule = false;
bool ChessRules::CastleKingAllowedGray = true;
bool ChessRules::CastleKingAllowedBrown = true;
bool ChessRules::KingAttacker = false;
bool ChessRules::SmallKingCastleBrown = false;
bool ChessRules::KingCastleBrown = false;
bool ChessRules::SmallKingCastleGray = false;
bool ChessRules::KingCastleGray = false;
bool ChessRules::BigKingCastleBrown = false;
bool ChessRules::BigKingCastleGray = false;
bool ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporter = false;
int ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber = 0;
bool ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
bool ChessRules::CheckGrayObjectDangourFirstTimesOcured = false;
bool ChessRules::CheckBrownObjectDangourFirstTimesOcured = false;
bool ChessRules::CastleActGray = false;
bool ChessRules::CastleActBrown = false;
int ChessRules::CurrentOrder = 1;
bool ChessRules::CheckGrayRemovable = true;
bool ChessRules::CheckBrownRemovable = true;
int ChessRules::CheckGrayRemovableValueRowi = 0;
int ChessRules::CheckGrayRemovableValueColumni = 0;
int ChessRules::CheckGrayRemovableValueRowii = 0;
int ChessRules::CheckGrayRemovableValueColumnjj = 0;
int ChessRules::CheckBrownRemovableValueRowi = 0;
int ChessRules::CheckBrownRemovableValueColumnj = 0;
int ChessRules::CheckBrownRemovableValueRowii = 0;
int ChessRules::CheckBrownRemovableValueColumnjj = 0;

	/*void ChessRules::Log(std::exception ex)
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

/*	ChessRules::ChessRules((((int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments))));Changed, int oRDER)
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
		Order = oRDER;
		ArrangmentsBoard = ArrangmentsChanged;
	}
*/
	ChessRules::ChessRules(int CurrentAStarGredy, int oRDER, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged)
	{
		InitializeInstanceFields();
		CurrentAStarGredyMax = CurrentAStarGredy;
		Order = oRDER;
		MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
		IgnoreSelfObjectsT = IgnoreSelfObject;
		UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
		BestMovmentsT = BestMovment;
		PredictHuristicT = PredictHurist;
		OnlySelfT = OnlySel;
		AStarGreedyHuristicT = AStarGreedyHuris;
		ArrangmentsBoard = ArrangmentsChanged;
	}
	

	ChessRules::ChessRules(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int Ki, int **A, int Ord, int i, int j)
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
		ArrangmentsBoard = ArrangmentsChanged;
		Row = i;
		Column = j;

		//Initiate Global Variables By Local Parameters.
		KindNA = Ki;
		Kind = abs(Ki);
		//Table = new int*[8]; for (int ii = 0; ii < 8; ii++)Table[ii]-new int[8];
		for (int ik = 0; ik < 8; ik++)
		{
			for (int jk = 0; jk < 8; jk++)
			{
				Table[ik][jk] = A[ik][jk];
			}
		}
		Order = Ord;
	}

	bool ChessRules::Rules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, int color, int Ki, bool SelfHomeStatCP )
	{
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{

			if (Table[RowFirst][ColumnFirst] > 0 && Table[RowSecond][ColumnSecond] > 0)
			{
				if (!SelfHomeStatCP)
				{
					IgnoreSelfObject = true;
				}
				else
				{
					IgnoreSelfObject = false;
				}
			}
			else
			{
				IgnoreSelfObject = false;
			}

			if (Table[RowFirst][ColumnFirst] < 0 && Table[RowSecond][ColumnSecond] < 0)
			{
				if (!SelfHomeStatCP)
				{
					IgnoreSelfObject = true;
				}
				else
				{
					IgnoreSelfObject = false;
				}
			}
			else
			{
				IgnoreSelfObject = false;
			}
		}
		//Initaite Global Varibales.
		//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporter = false;
			CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber = 0;
		}
		//When Order is Non Detectable Continue Traversal Back.
		//if (Order != CurrentOrder)
		//  return false;
		//Found Location of Tow Gray and Brown Kings. 
		int RowB = 0, ColumnB = 0;
		int RowG = 0, ColumnG = 0;
		FindBrownKing(Table, RowB, ColumnB);
		FindGrayKing(Table, RowG, ColumnG);

		//Gray Order.
		if ((Order == 1))
		{
			if (Table[RowFirst][ColumnFirst] == 6)
			{
				if (abs(RowB-RowSecond) <= 1 && abs(ColumnB-ColumnSecond) <= 1)
				{
					return false;
				}
			}
			//Illegal King Foundation.
			if (abs(RowB-RowG) <= 1 && abs(ColumnB-ColumnG) <= 1)
			{
				return false;
			}
		} //Brown Order.
		else
		{
			if (Table[RowFirst][ColumnFirst] == -6)
			{
				if (abs(RowG-RowSecond) <= 1 && abs(ColumnG-ColumnSecond) <= 1)
				{
					return false;
				}
			}
			//Ilegal Kings Foundation.
			if (abs(RowB-RowG) <= 1 && abs(ColumnB-ColumnG) <= 1)
			{
				return false;
			}

		}
		//Determination of Enemy in the Destionation Home.
		bool ExistInDestinationEnemy = bool();
		if (((Table[RowFirst][ColumnFirst] > 0) && (Table[RowSecond][ColumnSecond] < 0) && Order == 1))
		{
			ExistInDestinationEnemy = true;
		}
		else
		{
			if ((Table[RowFirst][ColumnFirst] < 0) && (Table[RowSecond][ColumnSecond] > 0) && Order == -1)
			{
				ExistInDestinationEnemy = true;
			}
		}

		//If There is A Source of Soldier.
		if (abs(Kind) == 1)
		{
			if (!(ArrangmentsBoard))
			{
				//Solders of Gray at Begining.
				if (ColumnFirst == 1 && Order == 1)
				{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
				}
				else //Solder of Brown At Begining.
				{
					if (ColumnFirst == 6 && Order == -1)
					{
						return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
					}
					else //Another Solder Movments.
					{
						return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
					}
				}
			}
			else
			{
				//Solders of Gray at Begining.
				if (ColumnFirst == 6 && Order == 1)
				{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
				}
				else //Solder of Brown At Begining.
				{
					if (ColumnFirst == 1 && Order == -1)
					{
						return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
					}
					else //Another Solder Movments.
					{
						return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
					}
				}

			}
		}
		else //For another Kind of Objects.
		{
			return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
		}

	}

	bool ChessRules::CastleKing(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, int Ki)
	{
		if (!(ArrangmentsBoard))
		{ //Gray Order.
			if (Order == 1)
			{
				//When Gray Castles Not Act.
				if (ChessRules::CastleKingAllowedGray)
				{
					//If Column is At First Location.
					if (ColumnFirst == 0 && ColumnSecond == 0)
					{
						//When Kings Moves for Small Kings Castles Movments.
						if ((RowFirst == RowSecond-2) && (RowSecond-2 >= 0))
						{
							//Consideration of Castles King of Gray King.
							//try
							{
								if ((RowSecond-1 >= 0) && (RowSecond + 1 < 8) && (RowSecond-2 >= 0) && Table[RowSecond-2][ColumnSecond] == 6 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond + 1][ColumnSecond] == 4)
								{
									//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O)
									{
										CastleActGray = true;
										SmallKingCastleGray = true;
									}

									return true;
								}
							}
							//catch(std::exception t)
							{
								
							}
						}

						else //For Greates Castles King Movments.
						{
							if ((RowFirst == RowSecond + 2) && (RowSecond + 2 < 8))
							{
								//Consideration of Castles King M<ovments.
								//try
								{
									if ((RowSecond + 2 < 8) && (RowSecond-1 >= 0) && (RowSecond + 1 < 8) && (RowSecond-2 >= 0) && Table[RowSecond + 2][ColumnSecond] == 6 && Table[RowSecond + 1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond-2][ColumnSecond] == 4)
									{
									//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O)
									{
										CastleActGray = true;
										BigKingCastleGray = true;
									}
										return true;
									}
								}
								//catch(std::exception t)
								{
									
								}

							}
						}
					}
				}
			}
			else //Order of Brown.
			{
				//When Brown Castles King Not Occured.
				if (ChessRules::CastleKingAllowedBrown)
				{
					//Column Situation.
					if (ColumnFirst == 7 && ColumnSecond == 7)
					{
						//Small Brown King Castles Consideration.
						if ((RowFirst == RowSecond-2) && (RowSecond-2 < 8))
						{
							//try
							{

								if ((RowSecond-1 >= 0) && (RowSecond + 1 < 8) && Table[RowSecond-2][ColumnSecond] == -6 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond + 1][ColumnSecond] == -4)
								{
									//CastleActBrown = true;
									//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O1)
									{
										SmallKingCastleBrown = true;
									}
									return true;
								}
							}
							//catch(std::exception t)
							{
								
							}

						}
						else
						{
							if ((RowFirst == RowSecond + 2) && (RowSecond + 2 < 8))
							{
							//Brown Kings.Big King Castles Consideration.
								//try
								{
									if ((RowSecond + 2 < 8) && (RowSecond-1 >= 0) && (RowSecond + 1 < 8) && (RowSecond-2 >= 0) && Table[RowSecond + 2][ColumnSecond] == -6 && Table[RowSecond + 1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond-2][ColumnSecond] == -4)
									{
									//CastleActBrown = true;
									//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
									//lock (O)
									{
										BigKingCastleBrown = true;
									}
										return true;
									}
								}
								//catch(std::exception t)
								{
									
								}
							}
						}
					}
				}
			}
		}
		else
		{
			//Gray Order.
			if (Order == 1)
			{
				//When Gray Castles Not Act.
				if (ChessRules::CastleKingAllowedGray)
				{
					//If Column is At First Location.
					if (ColumnFirst == 7 && ColumnSecond == 7)
					{
						//When Kings Moves for Small Kings Castles Movments.
						if ((RowFirst == RowSecond-2) && (RowSecond-2 >= 0))
						{
							//Consideration of Castles King of Gray King.
							//try
							{

								if ((RowSecond-2 >= 0) && (RowSecond-1 >= 0) && (RowSecond + 1 < 8) && Table[RowSecond-2][ColumnSecond] == 6 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond + 1][ColumnSecond] == 4)
								{
									//CastleActGray = true;
									//SmallKingCastleGray = true;
									return true;
								}
							}
							//catch(std::exception t)
							{
								
							}
						}

						else //For Greates Castles King Movments.
						{
							if (RowFirst == RowSecond + 2 && (RowSecond + 2 < 8))
							{
								//Consideration of Castles King M<ovments.
								//try
								{
									if ((RowSecond + 2 < 8) && (RowSecond-1 >= 0) && (RowSecond + 1 < 8) && (RowSecond-2 >= 0) && Table[RowSecond + 2][ColumnSecond] == 6 && Table[RowSecond + 1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond-2][ColumnSecond] == 4)
									{
										//CastleActGray = true;
										//BigKingCastleGray = true;
										return true;
									}
								}
								//catch(std::exception t)
								{
									
								}

							}
						}
					}
				}
			}
			else //Order of Brown.
			{
				//When Brown Castles King Not Occured.
				if (ChessRules::CastleKingAllowedBrown)
				{
					//Column Situation.
					if (ColumnFirst == 0 && ColumnSecond == 0)
					{
						//Small Brown King Castles Consideration.
						if (RowFirst == RowSecond-2 && (RowSecond-2 > 0))
						{
							//try
							{

								if ((RowSecond-2 >= 0) && (RowSecond-1 >= 0) && (RowSecond + 1 < 8) && Table[RowSecond-2][ColumnSecond] == -6 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond + 1][ColumnSecond] == -4)
								{
									//CastleActBrown = true;
									//SmallKingCastleBrown = true;
									return true;
								}
							}
							//catch(std::exception t)
							{
								
							}

						}
						else
						{
							if (RowFirst == RowSecond + 2 && (RowSecond + 2 < 8))
							{
							//Brown Kings.Big King Castles Consideration.
								//try
								{
									if ((RowSecond + 2 < 8) && (RowSecond-1 >= 0) && (RowSecond + 1 < 8) && (RowSecond-2 >= 0) && Table[RowSecond + 2][ColumnSecond] == -6 && Table[RowSecond + 1][ColumnSecond] == 0 && Table[RowSecond][ColumnSecond] == 0 && Table[RowSecond-1][ColumnSecond] == 0 && Table[RowSecond-2][ColumnSecond] == -4)
									{
										//  CastleActBrown = true;
										//BigKingCastleBrown = true;
										return true;
									}
								}
								//catch(std::exception t)
								{
									
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	bool ChessRules::CheckConstructor(int color, int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, int Ki, int Order)
	{
		//Initiate a Local Variable.
		int **tab = new int*[8];
		for (int i = 0; i < 8; i++)
			tab[i] =new  int[8];
		//Clone A Copy of Table.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				tab[i][j] = Table[i][j];
			}
		}

		//Act a Move.
		tab[RowSecond][ColumnSecond] = tab[RowFirst][ColumnFirst];
		tab[RowFirst][ColumnFirst] = 0;
		//If There is Check State.
		if (Check(tab, Order))
		{
			//When int of Order is Gray Check return Check State.
			if (Order == 1)
			{
				if (CheckGray)
				{
					return true;
				}
			}
			//When int is Brown State  there is Check State return Check State.
			if (Order == -1)
			{
				if (CheckBrown)
				{
					return true;
				}
			}
		}
		//Return Non Check State.
		return false;
	}

	bool ChessRules::ExistSelfHome(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, int Ki)
	{
		//Initiate of Local Variable.
		bool NotExistInDestinationSelfHome = false;
		//When There is Not Source and Destination is the Same Home Location. 
		if (RowFirst != RowSecond || ColumnFirst != ColumnSecond)
		{
			//If the Same Gray int Return Self Home. 
			if (Table[RowSecond][ColumnSecond] > 0 && Table[RowFirst][ColumnFirst] > 0)
			{
				NotExistInDestinationSelfHome = true;
			}
			else //If The Same int Brown Return Self Home.
			{
				if (Table[RowSecond][ColumnSecond] < 0 && Table[RowFirst][ColumnFirst] < 0)
				{
					NotExistInDestinationSelfHome = true;
				}
			}
		}
		return NotExistInDestinationSelfHome;
	}

	bool ChessRules::ObjectDangourKingMove(int Order, int **Table, bool DoIgnore)
	{
		int **Tab;
		//Clone a Copy
		for (int i = 0; i < 8; i++)
		{
		for (int j = 0; j < 8; j++)
		{
		Tab[i][j] = Table[i][j];
		}
		}
		//Initiate Variables.
		CheckGray = false;
		CheckBrown = false;
		CheckGrayObjectDangour = false;
		CheckBrownObjectDangour = false;
		int RowG = 0, ColumnG = 0;
		int RowB = 0, ColumnB = 0;
		//Object O = new Object();
		//////lock (O)
		///{
		/// if (DoIgnore)
		///RefrigtzDLL.ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = true;
		// }
		//Check identification.
		//Check(Tab, Order);
		bool CheckGrayDummy = CheckGray;
		bool CheckBrownDummy = CheckBrown;
		//If There is Check on Tow Side.
		/*if (CheckBrown || CheckGray)
		{
		    //Check meand achmaz.
		    if (CheckBrown)
		        CheckBrownObjectDangour = true;
		    if (CheckGray)
		        CheckGrayObjectDangour = true;
		    return true;
	
		}*/
		int CDummy = ChessRules::CurrentOrder;
		int COrder = Order;
		if (Order == 1)
		{
			//Location of King Gary
			if (FindGrayKing(Tab, RowG, ColumnG))
			{
				//For Enemy Brown.
				for (int ii = 0; ii < 8; ii++)
				{
					for (int jj = 0; jj < 8; jj++)
					{

						//Ignore Gray.
						if (Tab[ii][jj] >= 0)
						{
							continue;
						}
						//For Current Gray and Empty.
						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								for (int i = 0; i < 8; i++)
								{
									for (int j = 0; j < 8; j++)
									{
										Tab[i][j] = Table[i][j];
									}
								}
								//Ignore Brown.
								if (Tab[iii][jjj] < 0)
								{
									continue;
								}
								ThinkingChess AA =  ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, ii, jj);
								//When There is Attacked to Gray from Brown.
								if (AA.Attack(Tab, ii, jj, iii, jjj, -1, Order * -1))
								{
									//Move.
									int a = Tab[iii][jjj];
									Tab[iii][jjj] = Tab[ii][jj];
									Tab[ii][jj] = 0;
									int **Tabl;
									for (int h = 0; h < 8; h++)
									{
										for (int g = 0; g < 8; g++)
										{
											Tabl[h][g] = Tab[h][g];
										}
									}
									ChessRules *AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tabl[iii][jjj], Tabl, Order, iii, jjj);
									//When there is checked or checkmate.
									if (AAA->CheckMate(Tabl, Order))
									{
										//if (AAA->CheckMateGray)
										if (AAA->CheckMateGray)
										{
											CheckGrayObjectDangour = true;
											break;
										}
									}
									//CheckGrayObjectDangour = true;
								}
								if (CheckGrayObjectDangour)
								{
									break;
								}

							}
							if (CheckGrayObjectDangour)
							{
								break;
							}
						}
						if (CheckGrayObjectDangour)
						{
							break;
						}

					}
					if (CheckGrayObjectDangour)
					{
						break;
					}

				}
			}
		}
		else
		{
			//Location of King Brown
			if (FindBrownKing(Tab, RowB, ColumnB))
			{

				//For Gray Enemy.
				for (int ii = 0; ii < 8; ii++)
				{
					for (int jj = 0; jj < 8; jj++)
					{
						//Ignore Brown
						if (Tab[ii][jj] <= 0)
						{
							continue;
						}
						//For Current Brown.
						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								for (int i = 0; i < 8; i++)
								{
									for (int j = 0; j < 8; j++)
									{
										Tab[i][j] = Table[i][j];
									}
								}
								//Ignore Gray.
								if (Tab[iii][jjj] > 0)
								{
									continue;
								}

								ThinkingChess AA =  ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, ii, jj);
								//When There is Attack to Brown.
								if (AA.Attack(Tab, ii, jj, iii, jjj, 1, Order * -1))
								{
									//Move
									int a = Tab[iii][jjj];
									Tab[iii][jjj] = Tab[ii][jj];
									Tab[ii][jj] = 0;
									int **Tabl;
									for (int h = 0; h < 8; h++)
									{
										for (int g = 0; g < 8; g++)
										{
											Tabl[h][g] = Tab[h][g];
										}
									}
									ChessRules *AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tabl[iii][jjj], Tabl, Order, iii, jjj);
									//When There is Check or Checkedmate
									if (AAA->CheckMate(Tabl, Order))
									{
										//if (AAA->CheckMateBrown)
										if (AAA->CheckMateBrown)
										{
											CheckBrownObjectDangour = true;
											break;
										}

									}

									//CheckBrownObjectDangour = true;

								}
								if (CheckBrownObjectDangour)
								{
									break;
								}
							}
							if (CheckBrownObjectDangour)
							{
								break;
							}
						}
						if (CheckBrownObjectDangour)
						{
							break;
						}

					}
					if (CheckBrownObjectDangour)
					{
						break;
					}

				}
			}
		}
		//Iniaiate Global Variables.
		//Object O1 = new Object();
		////lock (O1)
		//{
		//RefrigtzDLL.ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
		//}
		//If There is Brown ObjectDanger Or Gray ObjectDanger.
		if (CheckBrownObjectDangour || CheckGrayObjectDangour)
		{
			//Iniaate Global Check Variable By Local Variables.
			ChessRules::CurrentOrder = CDummy;
			Order = COrder;
			CheckGray = CheckGrayDummy;
			CheckBrown = CheckBrownDummy;
			//Achamz is Validity.
			return true;
		}
		ChessRules::CurrentOrder = CDummy;
		Order = COrder;

		//Iniatiate Of Global Varibales By Local Variables.
		CheckGray = CheckGrayDummy;
		CheckBrown = CheckBrownDummy;
		//Return Not Validiy.
		return false;
	}

	bool ChessRules::ObjectDangourKingMove(int Order, int **Table)
	{
		int **Tab;
		//Clone a Copy
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate Variables.
		CheckGray = false;
		CheckBrown = false;
		CheckGrayObjectDangour = false;
		CheckBrownObjectDangour = false;
		int RowG = 0, ColumnG = 0;
		int RowB = 0, ColumnB = 0;
		//Object O = new Object();
		//////lock (O)
		///{
		/// if (DoIgnore)
		///RefrigtzDLL.ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = true;
		// }
		//Check identification.
		//Check(Tab, Order);
		bool CheckGrayDummy = CheckGray;
		bool CheckBrownDummy = CheckBrown;
		//If There is Check on Tow Side.
		/*if (CheckBrown || CheckGray)
		{
		    //Check meand achmaz.
		    if (CheckBrown)
		        CheckBrownObjectDangour = true;
		    if (CheckGray)
		        CheckGrayObjectDangour = true;
		    return true;
	
		}*/
		int CDummy = ChessRules::CurrentOrder;
		int COrder = Order;
		if (Order == 1)
		{
			//Location of King Gary
			if (FindGrayKing(Tab, RowG, ColumnG))
			{
				//For Enemy Brown.
				for (int ii = 0; ii < 8; ii++)
				{
					for (int jj = 0; jj < 8; jj++)
					{

						//Ignore Gray.
						if (Tab[ii][jj] >= 0)
						{
							continue;
						}
						//For Current Gray and Empty.
						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								for (int i = 0; i < 8; i++)
								{
									for (int j = 0; j < 8; j++)
									{
										Tab[i][j] = Table[i][j];
									}
								}
								//Ignore Brown.
								if (Tab[iii][jjj] < 0)
								{
									continue;
								}
								ThinkingChess AA =  ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, ii, jj);
								//When There is Attacked to Gray from Brown.
								if (AA.Attack(Tab, ii, jj, iii, jjj, -1, Order * -1))
								{
									//Move.
									int a = Tab[iii][jjj];
									Tab[iii][jjj] = Tab[ii][jj];
									Tab[ii][jj] = 0;
									int **Tabl;
									for (int h = 0; h < 8; h++)
									{
										for (int g = 0; g < 8; g++)
										{
											Tabl[h][g] = Tab[h][g];
										}
									}
									ChessRules *AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tabl[iii][jjj], Tabl, Order, iii, jjj);
									//When there is checked or checkmate.
									if (AAA->Check(Tabl, Order))
									{
										//if (AAA->CheckMateGray)
										if (AAA->CheckGray)
										{
											CheckGrayObjectDangour = true;
											break;
										}
									}
									//CheckGrayObjectDangour = true;
								}
								if (CheckGrayObjectDangour)
								{
									break;
								}

							}
							if (CheckGrayObjectDangour)
							{
								break;
							}
						}
						if (CheckGrayObjectDangour)
						{
							break;
						}

					}
					if (CheckGrayObjectDangour)
					{
						break;
					}

				}
			}
		}
		else
		{
			//Location of King Brown
			if (FindBrownKing(Tab, RowB, ColumnB))
			{

				//For Gray Enemy.
				for (int ii = 0; ii < 8; ii++)
				{
					for (int jj = 0; jj < 8; jj++)
					{
						//Ignore Brown
						if (Tab[ii][jj] <= 0)
						{
							continue;
						}
						//For Current Brown.
						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								for (int i = 0; i < 8; i++)
								{
									for (int j = 0; j < 8; j++)
									{
										Tab[i][j] = Table[i][j];
									}
								}
								//Ignore Gray.
								if (Tab[iii][jjj] > 0)
								{
									continue;
								}

								ThinkingChess AA =  ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, ii, jj);
								//When There is Attack to Brown.
								if (AA.Attack(Tab, ii, jj, iii, jjj, 1, Order * -1))
								{
									//Move
									int a = Tab[iii][jjj];
									Tab[iii][jjj] = Tab[ii][jj];
									Tab[ii][jj] = 0;
									int **Tabl;
									for (int h = 0; h < 8; h++)
									{
										for (int g = 0; g < 8; g++)
										{
											Tabl[h][g] = Tab[h][g];
										}
									}
									ChessRules *AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tabl[iii][jjj], Tabl, Order, iii, jjj);
									//When There is Check or Checkedmate
									if (AAA->Check(Tabl, Order))
									{
										//if (AAA->CheckMateBrown)
										if (AAA->CheckBrown)
										{
											CheckBrownObjectDangour = true;
											break;
										}

									}

									//CheckBrownObjectDangour = true;

								}
								if (CheckBrownObjectDangour)
								{
									break;
								}
							}
							if (CheckBrownObjectDangour)
							{
								break;
							}
						}
						if (CheckBrownObjectDangour)
						{
							break;
						}

					}
					if (CheckBrownObjectDangour)
					{
						break;
					}

				}
			}
		}
		//Iniaiate Global Variables.
		//Object O1 = new Object();
		////lock (O1)
		//{
		//RefrigtzDLL.ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
		//}
		//If There is Brown ObjectDanger Or Gray ObjectDanger.
		if (CheckBrownObjectDangour || CheckGrayObjectDangour)
		{
			//Iniaate Global Check Variable By Local Variables.
			ChessRules::CurrentOrder = CDummy;
			Order = COrder;
			CheckGray = CheckGrayDummy;
			CheckBrown = CheckBrownDummy;
			//Achamz is Validity.
			return true;
		}
		ChessRules::CurrentOrder = CDummy;
		Order = COrder;

		//Iniatiate Of Global Varibales By Local Variables.
		CheckGray = CheckGrayDummy;
		CheckBrown = CheckBrownDummy;
		//Return Not Validiy.
		return false;
	}

	bool ChessRules::AchmazCheckByMoveByRule(int **Tabl, int RowF, int ColumnF, int RowS, int ColumnS, int Order)
	{
		bool Achmaz = false;
		int **Table;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tabl[i][j];
			}
		}
		Table[RowS][ColumnS] = Table[RowF][ColumnF];
		Table[RowF][ColumnF] = 0;
		if (Check(Table, Order))
		{
			if (Order == 1 && CheckGray)
			{
				Achmaz = true;
			}
			if (Order == -1 && CheckBrown)
			{
				Achmaz = true;
			}

		}
		return Achmaz;
	}

	bool ChessRules::ObjectDangourKingMove(int Order, int **Table, bool DoIgnore, int ii, int jj)
	{
		int **Tab;
		//Clone a Copy
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tab[i][j] = Table[i][j];
			}
		}
		//Initiate Variables.
		CheckGray = false;
		CheckBrown = false;
		CheckGrayObjectDangour = false;
		CheckBrownObjectDangour = false;
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			if (DoIgnore)
			{
				ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = true;
			}
		}

		//Check identification.
		Check(Tab, Order);
		bool CheckGrayDummy = CheckGray;
		bool CheckBrownDummy = CheckBrown;
		//If There is Check on Tow Side.
		if (CheckBrown || CheckGray)
		{
			//Check meand achmaz.
			if (CheckBrown)
			{
				CheckBrownObjectDangour = true;
			}
			if (CheckGray)
			{
				CheckGrayObjectDangour = true;
			}
			return true;

		}
		int CDummy = ChessRules::CurrentOrder;
		int COrder = Order;

		//Location of King Gary

		{
			//Iniatite Global Varibales.
			ChessRules::CurrentOrder = -1;
			Order = -1;
			//For Enemies.
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					//Ignore of current.
					if (Order == 1 && Tab[i][i] >= 0)
					{
						continue;
					}
					if (Order == -1 && Tab[i][i] <= 0)
					{
						continue;
					}
					//For All Current
					for (int iii = 0; iii < 8; iii++)
					{
						for (int jjj = 0; jjj < 8; jjj++)
						{
							//Ignore of enemies.
							if (Order == 1 && Tab[iii][jjj] <= 0)
							{
								continue;
							}
							if (Order == -1 && Tab[iii][jjj] >= 0)
							{
								continue;
							}


							//Clone a Copy
							for (int ik = 0; ik < 8; ik++)
							{
								for (int jk = 0; jk < 8; jk++)
								{
									Tab[ik][jk] = Table[ik][jk];
								}
							}
							ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tab[i][j], Tab, Order * -1, i, j);
							int a = 1;
							if (Order * -1 == -1)
							{
								a = -1;
							}
							//When Enemies can gard King
							if (A->Rules(i, j, iii, jjj, a, Tab[i][j]))
							{
								Tab[iii][jjj] = Tab[i][j];
								Tab[i][j] = 0;
								if (A->CheckMate(Tab, Order))
								{
									if (Order == 1 && A->CheckMateGray)
									{
										//For Current.
										for (int iiii = 0; iiii < 8; iiii++)
										{
											for (int jjjj = 0; jjjj < 8; jjjj++)
											{
												//Ignore of enemies.
												if (Order == 1 && Tab[iiii][jjjj] <= 0)
												{
													continue;
												}
												if (Order == -1 && Tab[iiii][jjjj] >= 0)
												{
													continue;
												}
												//For Enemies and Emety.
												for (int iiiii = 0; iiiii < 8; iiiii++)
												{
													for (int jjjjj = 0; jjjjj < 8; jjjjj++)
													{
														//Ignore of Current.
														if (Order == 1 && Tab[iiiii][jjjjj] > 0)
														{
															continue;
														}
														if (Order == -1 && Tab[iiiii][jjjjj] < 0)
														{
															continue;
														}
														for (int ik = 0; ik < 8; ik++)
														{
															for (int jk = 0; jk < 8; jk++)
															{
																Tab[ik][jk] = Table[ik][jk];
															}
														}
														Tab[iii][jjj] = Tab[i][j];
														Tab[i][j] = 0;

														A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tab[iiii][jjjj], Tab, Order, iiii, jjjj);
														if (A->Rules(iiii, jjjj, iiiii, jjjjj, a, Tab[i][j]))
														{
															Tab[iiiii][jjjjj] = Tab[iiii][jjjj];
															Tab[iiii][jjjj] = 0;
															if (A->CheckMate(Tab, Order))
															{
																CheckBrown = A->CheckBrown;
																CheckGray = A->CheckGray;
																CheckMateGray = A->CheckMateGray;
																CheckMateBrown = A->CheckMateBrown;
																CheckGrayObjectDangour = A->CheckGrayObjectDangour;
																CheckBrownObjectDangour = A->CheckBrownObjectDangour;
																ChessRules::CurrentOrder = CDummy;
																Order = COrder;
																return true;
															}
														}
													}
												}
											}
										}

									}
									else
									{
										if (Order == -1 && A->CheckMateBrown)
										{

											//For Current.
											for (int iiii = 0; iiii < 8; iiii++)
											{
												for (int jjjj = 0; jjjj < 8; jjjj++)
												{
													//Ignore of enemies.
													if (Order == 1 && Tab[iiii][jjjj] <= 0)
													{
														continue;
													}
													if (Order == -1 && Tab[iiii][jjjj] >= 0)
													{
														continue;
													}
													//For Enemies and Emety.
													for (int iiiii = 0; iiiii < 8; iiiii++)
													{
														for (int jjjjj = 0; jjjjj < 8; jjjjj++)
														{
															//Ignore of Current.
															if (Order == 1 && Tab[iiiii][jjjjj] > 0)
															{
																continue;
															}
															if (Order == -1 && Tab[iiiii][jjjjj] < 0)
															{
																continue;
															}
															for (int ik = 0; ik < 8; ik++)
															{
																for (int jk = 0; jk < 8; jk++)
																{
																	Tab[ik][jk] = Table[ik][jk];
																}
															}
															Tab[iii][jjj] = Tab[i][j];
															Tab[i][j] = 0;

															A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Tab[iiii][jjjj], Tab, Order, iiii, jjjj);
															if (A->Rules(iiii, jjjj, iiiii, jjjjj, a, Tab[i][j]))
															{
																Tab[iiiii][jjjjj] = Tab[iiii][jjjj];
																Tab[iiii][jjjj] = 0;
																if (A->CheckMate(Tab, Order))
																{
																	CheckBrown = A->CheckBrown;
																	CheckGray = A->CheckGray;
																	CheckMateGray = A->CheckMateGray;
																	CheckMateBrown = A->CheckMateBrown;
																	CheckGrayObjectDangour = A->CheckGrayObjectDangour;
																	CheckBrownObjectDangour = A->CheckBrownObjectDangour;
																	ChessRules::CurrentOrder = CDummy;
																	Order = COrder;
																	return true;
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

						}
					}
				}
			}

		}

		ChessRules::CurrentOrder = CDummy;
		Order = COrder;

		//Iniatiate Of Global Varibales By Local Variables.
		//Return Not Validiy.
		return false;
	}

	bool ChessRules::FindGrayKing(int **Table, int Row, int Column)
	{
		//For All Home Table.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				//If Current is Gray Home 
				if (Table[i][j] == 6)
				{
					//Initiate Refreable Parameters.
					Row = i;
					Column = j;
					return true;
				}
			}
		}
		//Not Found.
		return false;
	}

	std::wstring ChessRules::ThingsAlphabet(int i)
	{
		//Initiate a Local Varibale. 
		std::wstring A = L"";
		//Determinbe Gray Or Brown Movment.
		if (i < 0)
		{
			A = L"Brown:";
		}
		if (i > 0)
		{
			A = L"Gray:";
		}
		//Determine Object Alhpabet. 
		if (abs(i) == 1)
		{
			A += std::wstring(L"(S)");
		}
		if (abs(i) == 2)
		{
			A += std::wstring(L"(E)");
		}
		if (abs(i) == 3)
		{
			A += std::wstring(L"(H)");
		}
		if (abs(i) == 4)
		{
			A += std::wstring(L"(B)");
		}
		if (abs(i) == 5)
		{
			A += std::wstring(L"(M)");
		}
		if (abs(i) == 6)
		{
			A += std::wstring(L"(K)");
		}
		//Retrun Alphabet.
		return A;

	}

	std::wstring ChessRules::RowAlphabet(int i)
	{
		//Initiate Local Variable.
		std::wstring A = L"";
		//Row Alphabet Consideration.
		if (i == 0)
		{
			A = L"a";
		}
		if (i == 1)
		{
			A = L"b";
		}
		if (i == 2)
		{
			A = L"c";
		}
		if (i == 3)
		{
			A = L"d";
		}
		if (i == 4)
		{
			A = L"e";
		}
		if (i == 5)
		{
			A = L"f";
		}
		if (i == 6)
		{
			A = L"g";
		}
		if (i == 7)
		{
			A = L"h";
		}
		//Return Row Alphabet.
		return A;

	}

	std::wstring ChessRules::CreateStatistic(bool Arrange, int **Tab, int Movments, int SourceThings, int Column, int Row, bool Hit, int HitThings, bool CastleKing, bool SodierConvert)
	{
		//autoOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (OOO)
		{
			ArrangmentsBoard = Arrange;

			bool ms = false;
			int bn = Movments;
			if (bn % 2 == 1)
			{
				ms = true;
			}
			//Movments String Number Creation in String.
			bn = bn / 2 + 1;
			std::wstring SN = L"";
			std::wstring S = L"";
			if (ms)
			{
				SN = StringConverterHelper::toString(bn) + std::wstring(L".");
			}



			//Consider CheckMate Condition of Table.
			ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, Arrange, 1, Tab, 1, Row, Column);
			ChessRules *AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, Arrange, 1, Tab, 1, Row, Column);
			ChessRules *AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, Arrange, 1, Tab, 1, Row, Column);
			A->CheckMate(Tab, Order);
			AA->ObjectDangourKingMove(Order, Tab, false);
			int a = 1;
			if (Order == -1)
			{
				a = -1;
			}
			AAA->Pat(Tab, Order, a);
			if (A->CheckGray)
			{
				//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					ChessRules::CastleKingAllowedGray = false;
					ChessRules::CastleActGray = true;
					ThinkingChess::KingMaovableGray = true;
				}
			}
			else if (A->CheckBrown)
			{
				//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					ChessRules::CastleActBrown = true;
					ChessRules::CastleKingAllowedBrown = false;
					ThinkingChess::KingMaovableBrown = true;
				}
			}
			bool Castles = false;
			if (Order == 1)
			{
				if (ChessRules::SmallKingCastleGray || ChessRules::BigKingCastleGray)
				{
					Castles = true;
				}
			}
			if (Order == -1)
			{
				if (ChessRules::SmallKingCastleBrown || ChessRules::BigKingCastleBrown)
				{
					Castles = true;
				}
			}
			//When Solder Converted or Castles King Acts.
			if (SodierConvert || (CastleKing  &&Castles))
			{
				//When Castles Acts.
				if (CastleKing)
				{
					//Castles Brown King.
					if (ChessRules::SmallKingCastleGray)
					{
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							ThinkingChess::KingMaovableGray = true;
							S += std::wstring(L"Gray-BK-S");
							//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O)
							{
								if (!AllDraw::Stockfish)
								{
									ChessRules::SmallKingCastleGray = false;
									ChessRules::CastleKingAllowedGray = false;
								}
							}
						}
					}
					else
					{
						if (ChessRules::BigKingCastleGray)
						{
					//Castles Brown King.                    
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							S += std::wstring(L"Gray-BK-B");
							ThinkingChess::KingMaovableGray = true;
							//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O)
							{
								if (!AllDraw::Stockfish)
								{
									ChessRules::BigKingCastleGray = false;
									ChessRules::CastleKingAllowedGray = false;
								}
							}
						}
						}
					else
					{
							if (ChessRules::SmallKingCastleBrown)
							{
					//Castles Brown King.                    
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							S += std::wstring(L"Brown-BK-S");
							ThinkingChess::KingMaovableBrown = true;
							//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O)
							{
								if (!AllDraw::Stockfish)
								{
									ChessRules::SmallKingCastleBrown = false;
									ChessRules::CastleKingAllowedBrown = false;
								}
							}
						}
							}
					else
					{
								if (ChessRules::BigKingCastleBrown)
								{
					//Castles Brown King.                    

						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							S += std::wstring(L"Brown-BK-B");
							ThinkingChess::KingMaovableBrown = true;
							//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O)
							{
								if (!AllDraw::Stockfish)
								{
									ChessRules::BigKingCastleBrown = false;
									ChessRules::CastleKingAllowedBrown = false;
								}
							}
						}
								}
					}
					}
					}
					//Castles Brown King.                    

					//Great Castles Gray King.

				}
				//Soldier Converted.
				if (SodierConvert)
				{
					//Object Kind String Addition.
					S += ThingsAlphabet(SourceThings);
					//If Hit Acts.
					if (Hit)
					{
						//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O)
						{
							ObjectHittedRow = Row;
							ObjectHittedColumn = Column;
						}
						//THIS.SetObjectInPictureBox(Row, Column);

						S += std::wstring(L"x");
					}
					S += StringConverterHelper::toString(Column);
					//CheckMate of Gray Or Brown
					if (AAA->PatkGray || AAA->PatBrown)
					{
						S += std::wstring(L"-O-");
					}
					else
					{
						if (A->CheckMateGray || A->CheckMateBrown)
						{
						S += std::wstring(L"++");
						}
					//Check Of Gray Or Brown.
					else if (A->CheckBrown || A->CheckGray)
					{

						S += std::wstring(L"+");
						if (A->CheckBrown  &&Order == -1)
						{
							//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O2)
							{
								ThinkingChess::KingMaovableBrown = true;
								ChessRules::BigKingCastleBrown = false;
								ChessRules::CastleKingAllowedBrown = false;
							}
						}
						if (A->CheckGray  &&Order == 1)
						{
							//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O2)
							{
								ThinkingChess::KingMaovableGray = true;
								ChessRules::BigKingCastleGray = false;
								ChessRules::CastleKingAllowedGray = false;
							}
						}
					}
					else if (AA->CheckGrayObjectDangour || AA->CheckBrownObjectDangour)
					{

						if (AA->CheckGrayObjectDangour&&  Order == -1)
						{
							//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O2)
							{
								ThinkingChess::KingMaovableBrown = true;

							}
						}
						if (AA->CheckBrownObjectDangour  &&Order == 1)
						{
							//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
							//lock (O2)
							{
								ThinkingChess::KingMaovableGray = true;

							}
						}
					}
					}

				}
			}
			else //Brown Order.
			{
				//Object of Kind.
				S += ThingsAlphabet(SourceThings);
				//Hit Consideration.
				if (Hit)
				{
					//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (O)
					{
						ObjectHittedRow = Row;
						ObjectHittedColumn = Column;
					}
					//THIS.SetObjectInPictureBox(Row, Column);
					S += std::wstring(L"x");
				}
				//Row Column Consideration.
				S += RowAlphabet(Row);
				S += StringConverterHelper::toString(Column);
				//CheckMate Consideration.
				if (AAA->PatkGray || AAA->PatBrown)
				{
					S += std::wstring(L"-O-");
				}
				else

				{
					if (A->CheckMateGray || A->CheckMateBrown)
					{
					S += std::wstring(L"++");
					}
				//Gray Consideration.
				else if (A->CheckBrown || A->CheckGray)
				{
					S += std::wstring(L"+");
					if (A->CheckBrown  &&Order == -1)
					{
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							ChessRules::BigKingCastleBrown = false;
							ChessRules::CastleKingAllowedBrown = false;
							ThinkingChess::KingMaovableGray = true;

						}
					}
					if (A->CheckGray  &&Order == 1)
					{
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							ChessRules::BigKingCastleGray = false;
							ChessRules::CastleKingAllowedGray = false;
							ThinkingChess::KingMaovableGray = true;

						}
					}
				}
				else if (AA->CheckGrayObjectDangour || AA->CheckBrownObjectDangour)
				{

					if (AA->CheckGrayObjectDangour && Order == -1)
					{
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							ThinkingChess::KingMaovableBrown = true;

						}
					}
					if (AA->CheckBrownObjectDangour  &&Order == 1)
					{
						//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
						//lock (O2)
						{
							ThinkingChess::KingMaovableGray = true;

						}
					}
				}
				}


			}
			//Separate.
			if (AllDraw::Less != -DBL_MAX)
			{
				S += std::wstring(L" With Huristic (") + StringConverterHelper::toString(AllDraw::Less) + std::wstring(L")--");
			}
			else
			{
				S += std::wstring(L" --");
			}
			//Return String Sysntax.
			return SN + S;
		}
	}

	bool ChessRules::ArrayInList(std::vector<int> *List, int *A)
	{
		//Initiate Local Variables.
		bool Is = false;
		//For each Items of a Tow Part List.
		for (int i = 0; i < List->size(); i++)
		{
			//If Listis Equal Setting of Local Variable Equality.
			if (A[i] == List[i][0] && A[1] == List[i][1])
			{
				Is = true;
			}
		}
		//Retrun Condition.
		return Is;
	}

	bool ChessRules::FindAThing(int **Table, int Row, int Column, int Thing, bool BeMovable, std::vector<int> *List)
	{
		//For All Items In Table Home.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				//Initiate Local Variables.
				int AA[2];
				AA[0] = i;
				AA[1] = j;
				//If Table Home is Eqaul Tow Things Object.
				if (Table[i][j] == Thing)
				{
					//If Set A Global Variable Low Logical.
					if (!BeMovable)
					{
						//If Array Exist In List Continue Traversal Back.
						if (ArrayInList(List, AA))
						{
							continue;
						}
						//Iniatiate Local Varibales.
						Row = i;
						Column = j;
						//Found State.
						return true;
					}
					else //Else of Condition.
					{
						//Iniatiate Local Variables.
						int A = 1;
						if (Order == -1)
						{
							A = -1;
						}
						//For All Second Home.
						for (int ii = 0; ii < 8; ii++)
						{
							for (int jj = 0; jj < 8; jj++)
							{
								//If First Home is Movable to Second Home.
								if ((new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, i, j))->Movable(Table, i, j, ii, jj, A, Order))
								{
									//If Array Exist in Home.
									if (ArrayInList(List, AA))
									{
										continue;
									}
									//Initaite Local Variables.
									Row = i;
									Column = j;
									//Found of State
									return true;
								}

							}
						}
					}

				}
			}
		}
		//Not Found State.
		return false;
	}

	bool ChessRules::FindBrownKing(int **Table, int Row, int Column)
	{
		//For All Home Table.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				//If Current Home is Brown King.
				if (Table[i][j] == -6)
				{
					//Initiate Refrencable Parameter.
					Row = i;
					Column = j;
					//Found of Brown King.
					return true;
				}
			}
		}
		//Not Found.
		return false;
	}

	bool ChessRules::CheckRemovableByAttack(int **Table, int Order)
	{
		//Initiate Local Variables.
		int **Tabl;
		//Clone a Copy.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Tabl[i][j] = Table[i][j];
			}
		}
		//Initiate Global Variables.
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			CheckGrayRemovable = true;

			CheckBrownRemovable = true;
		}

		Check(Tabl, Order);
		//if (Order == -1)
		{
			//For All Home Tables in Fourth Second Traversal.
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					for (int ii = 0; ii < 8; ii++)
					{
						for (int jj = 0; jj < 8; jj++)
						{
							//If Tow How is the Same Continue Traversal Back.
							if (i == ii  &&j == jj)
							{
								continue;
							}
							//If is Brown Order.
							if (Table[i][j] < 0)
							{
								//If Is Gray Order.
								if (Table[ii][jj] > 0)
								{
									//Initiate Local Variables.
									int **Tab;
									//Clone  a Copy.
									for (int iii = 0; iii < 8; iii++)
									{
										for (int jjj = 0; jjj < 8; jjj++)
										{
											Tab[iii][jjj] = Table[iii][jjj];
										}
									}
									//If Is Movable.
									if ((new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, i, j))->Movable(Tab, i, j, ii, jj, -1, -1))
									{
										//Clone a Copy.
										for (int iii = 0; iii < 8; iii++)
										{
											for (int jjj = 0; jjj < 8; jjj++)
											{
												Tab[iii][jjj] = Table[iii][jjj];
											}
										}
										//If Brown Check.
										if (CheckBrown)
										{
											//Initiate Local Variables.
											Tab[ii][jj] = Tab[i][j];
											Tab[i][j] = 0;
											//If There is Not Check.
											if (!Check(Tab, Order))
											{
												//If Is Not Brown Check.
												if (!CheckBrown)
												{
													//Initiate and Move.
													Tab[i][j] = Table[ii][jj];
													Tab[ii][jj] = 0;
													//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
													//lock (O1)
													{
														CheckBrownRemovableValueRowi = i;
														CheckGrayRemovableValueColumni = j;
														CheckGrayRemovableValueRowii = ii;
														CheckGrayRemovableValueColumnjj = jj;
														CheckGrayRemovable = true;
													}
												}
											}
											//Move Back.
											Tab[i][j] = Table[ii][jj];
											Tab[ii][jj] = 0;
										}


									}
								}
							}
						}
					}
				}
			}
		}
		{
			//For All Second Traversal Homes.
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					for (int ii = 0; ii < 8; ii++)
					{
						for (int jj = 0; jj < 8; jj++)
						{
							//if The Tow Traversal are the ame Continue Traversal Back.
							if (i == ii  &&j == jj)
							{
								continue;
							}
							//If the Gray.
							if (Table[i][j] > 0)
							{
								//If the Brown.
								if (Table[ii][jj] < 0)
								{
									//Inaitate Local Variables.
									int **Tab;
									//Clone a Copy.
									for (int iii = 0; iii < 8; iii++)
									{
										for (int jjj = 0; jjj < 8; jjj++)
										{
											Tab[iii][jjj] = Table[iii][jjj];
										}
									}
									//Moveable Movemnts in the Tow Traversal Kind.
									if ((new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, i, j))->Movable(Tab, i, j, ii, jj, 1, 1))
									{
										for (int iii = 0; iii < 8; iii++)
										{
											for (int jjj = 0; jjj < 8; jjj++)
											{
												Tab[iii][jjj] = Table[iii][jjj];
											}
										}
										//If the Gray Check.
										if (CheckGray)
										{
											//Move 
											Tab[ii][jj] = Tab[i][j];
											Tab[i][j] = 0;
											//If ther is Not Check.
											if (!Check(Tab, Order))
											{
												//If there is Not Gray Check.
												if (!CheckGray)
												{
													//Move and Initaite Local and Global Variables.
													Tab[i][j] = Table[ii][jj];
													Tab[ii][jj] = 0;
													//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
													//lock (O1)
													{
														CheckBrownRemovableValueRowi = i;
														CheckBrownRemovableValueColumnj = j;
														CheckBrownRemovableValueRowii = ii;
														CheckBrownRemovableValueColumnjj = jj;
														CheckBrownRemovable = true;
													}

												}
											}
											//Move Back.
											Tab[i][j] = Table[ii][jj];
											Tab[ii][jj] = 0;
										}


									}
								}
							}
						}
					}
				}
			}
		}
		//If Check Remoavbe Brown Or Gray Return Removable.
		if (CheckBrownRemovable || CheckGrayRemovable)
		{
			return true;
		}
		//Return Not Removable.
		return false;
	}

	bool **ChessRules::VeryFye(int **Table, int Order, int a, int ii, int jj)
	{
		int Cdummy = ChessRules::CurrentOrder;
		if (Order == 1)
		{
			ChessRules::CurrentOrder = 1;
		}
		else
		{
			ChessRules::CurrentOrder = -1;
		}
		bool **Tab = new bool*[8];
		for (int i = 0; i < 8; i++)
			Tab[i] =new  bool[8];
		

		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (i == ii  &&j == jj)
				{
					continue;
				}


				if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[ii][jj], Table, Order, ii, jj))->Rules(ii, jj, i, j, a, Table[ii][jj]))
				{
					Tab[i][j] = true;
				}
				if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[ii][jj], Table, Order, ii, jj))->Rules(ii, jj, i, j, a, Table[ii][jj]))
				{
					Tab[i][j] = true;
				}
			}
		}
		ChessRules::CurrentOrder = Cdummy;
		return Tab;
	}

	bool ChessRules::OnlyKingMovable(int **Tab, bool TabB[8][8], int Order)
	{
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (TabB[i][j])
				{
					if (Order == 1)
					{
						if (Tab[i][j] != 6)
						{
							return false;
						}
					}
					else
					{
						if (Tab[i][j] != -6)
						{
							return false;
						}
					}
				}

			}
		}
		return true;

	}

	bool ChessRules::Pat(int **Tab, int Order, int a)
	{
		int **Table;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tab[i][j];
			}
		}
		bool Pat = false;
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			PatCheckedInKingRule = true;
		}
		if (!Check(Table, Order))
		{
			bool TableS[8][8];
			//  if (Order == -1)

			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					if (Table[ii][jj] > 0)
					{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: bool[,] TableSS = VeryFye(Table, 1, int.Gray, ii, jj);
						bool **TableSS = VeryFye(Table, 1, 1, ii, jj);

						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								TableS[iii][jjj] |= TableSS[iii][jjj];
							}
						}
					}
				}
			}
			if (OnlyKingMovable(Table, TableS, 1))
			{
				NumbersofKingMovesToPatGray++;
			}
			Pat = false;
			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					Pat |= TableS[ii][jj];
				}
			}
			Pat = !Pat;
			if (Pat || NumbersofKingMovesToPatGray > 16)
			{
				//autoOn = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					AllDraw::EndOfGame = true;
					PatkGray = true;
				}
			}
			//TableS = new bool[8][8];

			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					if (Table[ii][jj] < 0)
					{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: bool[,] TableSS = VeryFye(Table, -1, int.Brown, ii, jj);
						bool **TableSS = VeryFye(Table, -1, -1, ii, jj);
						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								TableS[iii][jjj] |= TableSS[iii][jjj];
							}
						}
					}
				}
			}
			if (OnlyKingMovable(Table, TableS, -1))
			{
				NumbersofKingMovesToPatBrown++;
			}
			Pat = false;
			for (int ii = 0; ii < 8; ii++)
			{
				for (int jj = 0; jj < 8; jj++)
				{
					Pat |= TableS[ii][jj];
				}
			}
			Pat = !Pat;
			if (Pat || NumbersofKingMovesToPatBrown >= 16)
			{
				//autoOn = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (On)
				{
					AllDraw::EndOfGame = true;
					PatBrown = true;
				}
			}
			if (PatkGray || PatBrown)
			{
				Pat = true;
			}
		}
		else
		{
			if (CheckGray)
			{
				NumbersofKingMovesToPatGray = 0;
			}
			else
			{
				if (CheckBrown)
				{
					NumbersofKingMovesToPatBrown = 0;
				}
			}

		}
		//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			PatCheckedInKingRule = false;
		}
		return Pat;
	}

	void ChessRules::CheckKing(int **Table, int Order, int RowK, int ColumnK)
	{
		int **Tab;
		//Clone a Copy.
		for (int ii = 0; ii < 8; ii++)
		{
			for (int jj = 0; jj < 8; jj++)
			{
				Tab[ii][jj] = Table[ii][jj];
			}
		}
		int Ord = Order;
		int aa = 1;
		if (Ord == -1)
		{
			aa = -1;
		}
		bool BREAK = false;
		//For All Home Table.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				//If The Current Home is the Gray King Continue Traversal Back.
				if (i == RowK  &&j == ColumnK)
				{
					continue;
				}
				if (Ord == 1 && Tab[i][j] <= 0)
				{
					continue;
				}
				if (Ord == -1 && Tab[i][j] >= 0)
				{
					continue;
				}
				//Initiate Global Variables.
				int Dummt = ChessRules::CurrentOrder;
				ChessRules::CurrentOrder = -1;
				//Clone a Copy.
				for (int ii = 0; ii < 8; ii++)
				{
					for (int jj = 0; jj < 8; jj++)
					{
						Tab[ii][jj] = Table[ii][jj];
					}
				}

				int a = 1;
				if (Ord == -1)
				{
					a = -1;
				}
				ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[i][j], Table, Ord, i, j);
				if (Ord == 1)
				{
					//Menen Parameter is Moveble to Second Parameters Location returm Movable.
					if (A->Rules(i, j, RowK, ColumnK, aa, Ord))
					{
						BREAK = true;
						//Initiate Local Is Check Variables.
						CheckBrown = true;
						break;
					}
				}
				else
				{ //Menen Parameter is Moveble to Second Parameters Location returm Movable.
					if (A->Rules(i, j, RowK, ColumnK, aa, Ord))
					{
						BREAK = true;
						CheckGray = true;
						break;
					}
				}

				//Initiate Global Variables.
				ChessRules::CurrentOrder = Dummt;


			}
			if (BREAK)
			{
				break;
			}
		}

	}

	bool ChessRules::Check(int **Table, int Ord)
	{
		//A player is not required to move their king out of check and the game concludes when there is a 100 % probability that one of the kings has been taken. As a result there is no checkmate.
		if (DrawKing::KingGrayNotCheckedByQuantumMove  &&Ord == 1)
		{
			return false;
		}
		else
		{
			if (DrawKing::KingBrownNotCheckedByQuantumMove  &&Ord == -1)
			{
			return false;
			}
		}
		int DummyOrder = Ord;
		//Initiate Local and Global Briables.
		bool Store = ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing;
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			ChessRules::CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
		}
		CheckGray = false;
		CheckBrown = false;
		//Initiate Local Variables.
		int RowG = 0, ColumnG = 0;
		int RowB = 0, ColumnB = 0;
		//if (Ord == 1)

		//Foud of Gray King.
		if (FindGrayKing(Table, RowG, ColumnG))
		{
			CheckKing(Table, -1, RowG, ColumnG);
		}

		//Found of Brown King.
		if (FindBrownKing(Table, RowB, ColumnB))
		{
			CheckKing(Table, 1, RowB, ColumnB);
		}

		Ord = DummyOrder;
		//If Gray Check Or brwon Check return Check..
		if (CheckBrown || CheckGray)
		{
			return true;
		}
		//Return Non Check.
		return false;
	}

	void ChessRules::CheckMateKing(int **Tab, int Ord, bool CheckGrayDummy, bool CheckBrownDummy, int RowK, int ColumnK, bool ActMove, bool Checked)
	{
		int DummyOrder = Order;
		//For All Home Table.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (Ord == 1 && Tab[i][j] > 0)
				{
					continue;
				}
				if (Ord == -1 && Tab[i][j] < 0)
				{
					continue;
				}

				//Clone a Copy.
				CheckGray = CheckGrayDummy;
				CheckBrown = CheckBrownDummy;
				//If There is Gray Check.
				if (Checked)
				{
					//Initiate Global Variables.
					ChessRules::CurrentOrder = 1;
					//Ig Gray King is Movable to First Home Table.
					int a = 1;
					if (Ord == -1)
					{
						a = -1;
					}
					ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[RowK][ColumnK], Table, Ord, RowK, ColumnK);
					Order = DummyOrder;
					///Table[ii, jj] = 0;
					//Menen Parameter is Moveble to Second Parameters Location returm Movable.
					for (int k = 0; k < 8; k++)
					{
						for (int p = 0; p < 8; p++)
						{
							Table[k][p] = Tab[k][p];
						}
					}
					if (A->Rules(RowK, ColumnK, i, j, a, Ord))
					{
						Order = DummyOrder;
						//Initaite Loval and Move.
						//ActMove = false;
						int Store = Table[i][j];
						//For Another Methods
						Table[i][j] = Table[RowK][ColumnK];
						Table[RowK][ColumnK] = 0;
						//If Is Check.
						if (A->Check(Table, Ord))
						{
							//Move Back.
							//If Gray Check.
							if (Ord == 1)
							{
								if (A->CheckGray)
								{
									//Move Mack.
									(ActMove) = true;
									continue;
								}
								else //If There is Not Gray Check.
								{
									//Move Back.
									ActMove = false;
									break;
								}
							}
							else
							{
								if (A->CheckBrown)
								{
									//Move Mack.
									(ActMove) = true;
									continue;
								}
								else //If There is Not Gray Check.
								{
									//Move Back.
									ActMove = false;
									break;
								}
							}

						}
						else
						{
							//Comon Move Back.
							ActMove = false;
							break;
						}

					}
				}

			}
			//If One of The Not Movable.
			if (!ActMove)
			{
				break;
			}
		}
		Order = DummyOrder;
	}

	void ChessRules::CheckMateNotKing(int **Tab, int Ord, bool CheckGrayDummy, bool CheckBrownDummy, bool ActMove)
	{
		int DummyOrder = Ord;
		//For All Home Table.
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (Ord == 1 && Tab[i][j] <= 0)
				{
					continue;
				}
				if (Ord == -1 && Tab[i][j] >= 0)
				{
					continue;
				}
				//Initiate Global varibales. 
				CheckGray = CheckGrayDummy;
				CheckBrown = CheckBrownDummy;
				//Clone a Copy.
				CheckGray = CheckGrayDummy;
				CheckBrown = CheckBrownDummy;
				//If There is Gray Check.
				//Initiate Local Varibale.
				(ActMove) = true;
				//For All Second Home Table.
				for (int ii = 0; ii < 8; ii++)
				{

					for (int jj = 0; jj < 8; jj++)
					{
						if (Ord == 1 && Tab[ii][jj] > 0)
						{
							continue;
						}
						if (Ord == -1 && Tab[ii][jj] < 0)
						{
							continue;
						}
						//Clone a Copy.
						for (int iii = 0; iii < 8; iii++)
						{
							for (int jjj = 0; jjj < 8; jjj++)
							{
								Table[iii][jjj] = Tab[iii][jjj];
							}
						}
						int a = 1;
						if (Ord == -1)
						{
							a = -1;
						}
						ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[i][j], Table, Ord, i, j);
						///Table[ii, jj] = 0;
						//Menen Parameter is Moveble to Second Parameters Location returm Movable.
						if (A->Rules(i, j, ii, jj, a, Ord))
						{
							Order = DummyOrder;
							//Initiate Local Varibales and Move.
							//ActMove = false;
							//For Another Methods
							int Store = Table[i][j];
							Table[ii][jj] = Table[i][j];
							Table[i][j] = 0;
							//If Check.
							A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[ii][jj], Table, Ord, ii, jj);
							if (A->Check(Table, Ord))
							{
								Order = DummyOrder;
								//Move Back.
								Table[i][j] = Table[ii][jj];
								Table[ii][jj] = Store;
								//If Gray Check.
								if (Ord == 1)
								{
									if (A->CheckGray)
									{
										//Initiate and Move Back.
										(ActMove) = true;
										Table[i][j] = Table[ii][jj];
										Table[ii][jj] = Store;
										continue;
									}
									//If There is Not Gray Check.
									else
									{
										//Initiate Varaible and Move Back.
										ActMove = false;
										Table[i][j] = Table[ii][jj];
										Table[ii][jj] = Store;
										break;
									}
								}
								else
								{
									if (A->CheckBrown)
									{
										//Initiate and Move Back.
										(ActMove) = true;
										Table[i][j] = Table[ii][jj];
										Table[ii][jj] = Store;
										continue;
									}
									//If There is Not Gray Check.
									else
									{
										//Initiate Varaible and Move Back.
										ActMove = false;
										Table[i][j] = Table[ii][jj];
										Table[ii][jj] = Store;
										break;
									}
								}
							}
							else
							{
								//Move Back and Initiate.
								Table[i][j] = Table[ii][jj];
								Table[ii][jj] = Store;
								ActMove = false;
								break;
							}
						}
					}
					//If Not Movable Break.
					if (!ActMove)
					{
						break;
					}
				}

				if (!ActMove)
				{
					break;
				}
			}
			//If Not Movable Break.
			if (!ActMove)
			{
				break;
			}
		}
		Order = DummyOrder;
	}

	bool ChessRules::CheckMate(int **Tab, int Ord)
	{

		//Initiate Local and Global  Varibales.
		int **Table;
		//try
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Table[i][j] = Tab[i][j];
				}
			}
		}
		//catch(std::exception t)
		{
			
			return false;
		}
		CheckGray = false;
		CheckBrown = false;
		CheckMateBrown = false;
		CheckMateGray = false;
		bool ActMoveG = new bool();	(ActMoveG) = true;
		bool ActMoveGF = new bool();	(ActMoveGF) = true;
		bool ActMoveB = new bool();	(ActMoveB) = true;
		int RowG = 0, ColumnG = 0;
		int RowB = 0, ColumnB = 0;
		int DumnyOrder = Ord;
		//Check Consideration.
		Check(Table, Ord);
		//Initiate Local Varibales.
		bool CheckGrayDummy = CheckGray;
		bool CheckBrownDummy = CheckBrown;

		(ActMoveG) = true;
		(ActMoveGF) = true;

		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tab[i][j];
			}
		}
		ChessRules *A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[RowG][ColumnG], Table, Ord, RowG, ColumnG);

		//Found of Gray King.
		if (FindGrayKing(Table, RowG, ColumnG))
		{
			A->CheckMateKing(Table, 1, CheckGrayDummy, CheckBrownDummy, RowG, ColumnG, ActMoveG, CheckGray);
		}

		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tab[i][j];
			}
		}
		//Found of Gray King.
		if (FindGrayKing(Table, RowG, ColumnG))
		{
			A->CheckMateNotKing(Table, 1, CheckGrayDummy, CheckBrownDummy, ActMoveGF);
		}

		//Intiate Global Variables.
		CheckGray = CheckGrayDummy;
		CheckBrown = CheckBrownDummy;

		//Condition of CheckMate Gray King.
		if (CheckGray &&ActMoveG  &&ActMoveGF)
		{
			CheckMateGray = true;
		}


		(ActMoveB) = true;
		(ActMoveGF) = true;

		ChessRules *AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsBoard, Table[RowB][ColumnB], Table, Ord, RowB, ColumnB);
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tab[i][j];
			}
		}
		//Found of Brown King.
		if (FindBrownKing(Table, RowB, ColumnB))
		{
			AA->CheckMateKing(Table, -1, CheckGrayDummy, CheckBrownDummy, RowB, ColumnB, ActMoveB, CheckBrown);
		}
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Table[i][j] = Tab[i][j];
			}
		}
		//Found of Brown King.
		if (FindBrownKing(Table, RowB, ColumnB))
		{
			AA->CheckMateNotKing(Table, -1, CheckGrayDummy, CheckBrownDummy, ActMoveGF);
		}


		//Initiate Global Varibales.
		CheckGray = CheckGrayDummy;
		CheckBrown = CheckBrownDummy;
		//Condition of Brown CheckMate.
		if (CheckBrown &&ActMoveB  &&ActMoveGF)
		{
			CheckMateBrown = true;
		}

		//Initiate Global Variables.
		Ord = DumnyOrder;
		//If Brown CheckMate and Gray.
		if (CheckMateGray || CheckMateBrown)
		{
			//Initiate Global Variable and Return CheckMate.
			CheckGray = CheckGrayDummy;
			CheckBrown = CheckBrownDummy;
			//autoOn = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (On)
			{
				AllDraw::EndOfGame = true;
				return true;
			}
		}
		//Initiate Global Variables.
		CheckGray = CheckGrayDummy;
		CheckBrown = CheckBrownDummy;
		//Return Not CheckMate.
		return false;
	}

	bool ChessRules::Rule(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki, bool SelfHomeStatCP)
	{
		//When is Not Castles King State.
		if (Kind != 7)
		{
			//Determination of Enemy Existing.
			if (ExistSelfHome(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, Ki) && SelfHomeStatCP)
			{
				return false;
			}
		}
		//Determination of King Enemy at Destination Home.
		/*if (!KingAttacker)
		{
		    //Coluld not hit King In Destination Enemy.
		    if (Order == 1  Table[RowSecond, ColumnSecond] == -6)
		        return false;
		    if (Order == -1  Table[RowSecond, ColumnSecond] == 6)
		        return false;
		}*/
		//If Source and The Destination are The Same.
		if (RowFirst == RowSecond  &&ColumnFirst == ColumnSecond)
		{
			return false;
		}
		//Initiate Global Variable.
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			KingAttacker = false;
		}
		//Rule of Soldeir.
		if (Kind == 1)

		{
			return SoldierRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);
		}

		else //Rule of Castles.
		{
			if (Kind == 4)
			{
				return CastleRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);
			}

			else //Rule of Hourses.
			{
				if (Kind == 3)
				{
					return HourseRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);
				}
				else //Rule of Elephant.
				{
					if (Kind == 2)
					{
						return ElefantRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);
					}
					else
					{
						if (Kind == 5) //Rule of Ministers.
						{
							return MinisterRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);
						}
						else
						{
							if (Kind == 6) //Rule of Kings.
							{
								return KingRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);
							}
							else
							{
								if (Kind == 7) //Rule of Castles King.
								{
									return CastleKing(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, Ki);
								}
							}
						}
					}
				}
			}
		}


		//Non Rulements.
		return false;
	}

	bool ChessRules::KingRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki)
	{
		bool Move = false;
		//When Miniaster Rule is Valid.
		if (MinisterRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki) && abs(RowFirst-RowSecond) <= 1 && abs(ColumnFirst-ColumnSecond) <= 1)
		{
			//Initiate Local Variable.
			/* int[,] Tab = new int[8, 8];
			 //Clone A Copy.,
			 for (int i = 0; i < 8; i++)
			     for (int j = 0; j < 8; j++)
			     {
			         Tab[i, j] = Table[i, j];
			     }
			 //Initiate Local Varibale and Move.
			 int Store = Tab[RowSecond, ColumnSecond];
			 Tab[RowSecond, ColumnSecond] = Tab[RowFirst, ColumnFirst];
			 Tab[RowFirst, ColumnFirst] = 0;
			 //When There is Check State.
			 if (Check(Tab, Order))
			 {
			     if (!PatCheckedInKingRule)
			     {
			         //Check Gray State return Non Rule.
			         if (Order == 1  CheckGray)
			             return false;
			         else//Brown Check State return Non Rule.
			             if (Order == -1  CheckBrown)
			                 return false;
			     }
			     else
			     {
			         //Check Gray State return Non Rule.
			         if (Order == -1  CheckGray)
			             return false;
			         else//Brown Check State return Non Rule.
			             if (Order == 1  CheckBrown)
			                 return false;
			     }
			 }
	
			 //Determination of Gray Enemy State Check at Enemy King at Around Existing Return Not Validity.
			 if (Order == 1  Table[RowFirst, ColumnFirst] == 6)
			 {
			     //try
			     {
			         if ((RowSecond + 1 < 8)
			         {
			             if (Table[RowSecond + 1, ColumnSecond] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if ((ColumnSecond + 1) < 8)
			         {
			             if (Table[RowSecond, ColumnSecond + 1] == -6)
			                 return false;
			         }
			     }
	
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond + 1 < 8) (ColumnSecond + 1) < 8))
			         {
			             if (Table[RowSecond + 1, ColumnSecond + 1] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond-1 >= 0))
			         {
			             if (Table[RowSecond-1, ColumnSecond] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (ColumnSecond.1 >= 0)
			         {
			             if (Table[RowSecond, ColumnSecond-1] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond-1 >= 0) (ColumnSecond.1) >= 0))
			         {
			             if (Table[RowSecond-1, ColumnSecond-1] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond + 1 < 8) (ColumnSecond.1) >= 0))
			         {
			             if (Table[RowSecond + 1, ColumnSecond-1] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond-1 >= 0) (ColumnSecond + 1) < 8))
			         {
			             if (Table[RowSecond-1, ColumnSecond + 1] == -6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
	
			 }//Determination of Brown Enemy State Check at Enemy King at Around Existing Return Not Validity.         
			 else if (Order == -1  Table[RowFirst, ColumnFirst] == -6)
			 {
			     //try
			     {
			         if ((RowSecond + 1 < 8)
			         {
			             if (Table[RowSecond + 1, ColumnSecond] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if ((ColumnSecond + 1) < 8)
			         {
			             if (Table[RowSecond, ColumnSecond + 1] == 6)
			                 return false;
			         }
			     }
	
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond + 1 < 8) (ColumnSecond + 1) < 8))
			         {
			             if (Table[RowSecond + 1, ColumnSecond + 1] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond-1 >= 0))
			         {
			             if (Table[RowSecond-1, ColumnSecond] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (ColumnSecond.1 >= 0)
			         {
			             if (Table[RowSecond, ColumnSecond-1] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond-1 >= 0) (ColumnSecond.1) >= 0))
			         {
			             if (Table[RowSecond-1, ColumnSecond-1] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond + 1 < 8) (ColumnSecond.1) >= 0))
			         {
			             if (Table[RowSecond + 1, ColumnSecond-1] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
			     //try
			     {
			         if (((RowSecond-1 >= 0) (ColumnSecond + 1) < 8))
			         {
			             if (Table[RowSecond-1, ColumnSecond + 1] == 6)
			                 return false;
			         }
			     }
			     //catch(Exception t) {  }
	
			 }
			 */
			Move = true;
		}
		return Move;
	}

	bool ChessRules::MinisterRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki)
	{
		bool Move = false;
		//When is Castles Rule.
		if (CastleRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki))
		{
			//Return Validity.,
			Move = true;
		}
		else
		{
			//When is Elephant Rule.
			if (ElefantRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki))
			{
				//Return Validity.,
				Move = true;
			}
		}
		//Return Not Valididty.
		return Move;
	}

	bool ChessRules::CastleRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki)
	{
		bool Move = false;
		bool Act = new bool();	(Act) = false;
		//If Variation is Only in Row.
		if (abs(ColumnFirst-ColumnSecond) == 0 && abs(RowFirst-RowSecond) != 0)
		{
			//Initiate Local Variables.
			int RowU = RowSecond, RowD = RowFirst;
			int ColD = ColumnFirst, ColU = ColumnSecond;
			int Rowf = 1, Colf = 1;
			if (RowU < RowD)
			{
				Rowf = -1;
			}
			if (ColU < ColD)
			{
				Colf = -1;
			}
			int incf = 0, incR = 0;
			if (Rowf < 0)
			{
				incf = -1;
			}
			if (Colf < 0)
			{
				incR = -1;
			}
			int F = 0, G = 0;
			int A = 0, B = 0;
			if (incf < 0)
			{
				F = RowU;
				G = RowD;
			}
			else
			{
				F = RowD;
				G = RowU;

			}
			if (incR < 0)
			{
				A = ColU;
				B = ColD;
			}
			else
			{
				A = ColD;
				B = ColU;

			}
			{
				//For Variation of Row Home.
				for (int i = F; i <= G; i++)
				{
					if (IgnoreSelfObject  &&i == RowSecond)
					{
						continue;
					}
					//When is Not Current Source Home.
					if (i != RowFirst)
					{
						//When There is Self Home at Home of Gray Return Not Validity.
						if (Table[i][ColumnFirst] > 0 && Table[RowFirst][ColumnFirst] > 0)
						{
							Move = false;
							(Act) = true;
						}
						//When There is Self Home of Brown Objects Return Not Validity.
						if (Table[i][ColumnFirst] < 0 && Table[RowFirst][ColumnFirst] < 0)
						{
							(Act) = true;
							Move = false;
						}

						//If Situation is Occured.
						if (i != RowSecond)
						{
							//When There is Slef Home at Root Return Not Valididty.
							if ((Table[i][ColumnFirst] < 0 || Table[i][ColumnFirst] > 0) && Table[RowFirst][ColumnFirst] > 0)
							{
								(Act) = true;
								Move = false;
							}
							//When There is Slef Home at Root Return Not Valididty.
							if ((Table[i][ColumnFirst] > 0 || Table[i][ColumnFirst] < 0) && Table[RowFirst][ColumnFirst] < 0)
							{
								(Act) = true;
								Move = false;
							}
						}
					}

				}
			}
			if (!Act)
			{
				Move = true;
			}

		}
		//When There is Only Column Variation Home Changes.
		if (abs(ColumnFirst-ColumnSecond) != 0 && abs(RowFirst-RowSecond) == 0)
		{
			//Initiate Local Variables.
			int RowU = RowSecond, RowD = RowFirst;
			int ColD = ColumnFirst, ColU = ColumnSecond;
			int Rowf = 1, Colf = 1;
			if (RowU < RowD)
			{
				Rowf = -1;
			}
			if (ColU < ColD)
			{
				Colf = -1;
			}
			int incf = 0, incR = 0;
			if (Rowf < 0)
			{
				incf = -1;
			}
			if (Colf < 0)
			{
				incR = -1;
			}
			int F = 0, G = 0;
			int A = 0, B = 0;
			if (incf < 0)
			{
				F = RowU;
				G = RowD;
			}
			else
			{
				F = RowD;
				G = RowU;

			}
			if (incR < 0)
			{
				A = ColU;
				B = ColD;
			}
			else
			{
				A = ColD;
				B = ColU;

			}

			//For All Column Home Variation.
			for (int j = A; j <= B; j++)
			{
				if (IgnoreSelfObject  &&j == ColumnSecond)
				{
					continue;
				}
				//When The Source is Not The Current.
				if (j != ColumnFirst)
				{
					//For All Self Home at Root Return Not Validity
					if (Table[RowFirst][j] > 0 && Table[RowFirst][ColumnFirst] > 0)
					{
						(Act) = true;
						Move = false;
					}
					//For All Self Home at Root Return Not Validity.                       
					if (Table[RowFirst][j] < 0 && Table[RowFirst][ColumnFirst] < 0)
					{
						(Act) = true;
						Move = false;
					}
					//Condition Determination.
					if (j != ColumnSecond)
					{
						//Existing of Self Home At Root Cuased to Not validity.
						if ((Table[RowFirst][j] < 0 || Table[RowFirst][j] > 0) && Table[RowFirst][ColumnFirst] > 0)
						{
							(Act) = true;
							Move = false;
						}
						//Existing of Self Home At Root Cuased to Not validity.
						if ((Table[RowFirst][j] > 0 || Table[RowFirst][j] < 0) && Table[RowFirst][ColumnFirst] < 0)
						{
							(Act) = true;
							Move = false;
						}
					}
				}


			}
			//Return Validity.
			if (!Act)
			{
				Move = true;
			}
		}

		//Return Not Validity.
		/*if (Move  System.Math.Abs(Ki) != 6)
		{
		    if (AchmazCheckByMoveByRule(Table, RowFirst, ColumnFirst, RowSecond, ColumnSecond, Order))
		        Move = false;
		}
		 */

		//Return not Vailidity.
		return Move;

	}

	bool ChessRules::ElefantRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki)
	{
		bool Move = false;
		bool Act = new bool(); (Act) = false;
		//Orthogonal Movments of One Abs Derivation.
		if (abs(ColumnFirst-ColumnSecond) == abs(RowFirst-RowSecond))
		{
			//Initaiet Of Local Variables.
			int RowU = RowSecond, RowD = RowFirst;
			int ColD = ColumnFirst, ColU = ColumnSecond;
			int Rowf = 1, Colf = 1;
			if (RowU < RowD)
			{
				Rowf = -1;
			}
			if (ColU < ColD)
			{
				Colf = -1;
			}
			int incf = 0, incR = 0;
			if (Rowf < 0)
			{
				incf = -1;
			}
			if (Colf < 0)
			{
				incR = -1;
			}
			int F = 0, G = 0;
			int A = 0, B = 0;
			if (incf < 0)
			{
				F = RowU;
				G = RowD;
			}
			else
			{
				F = RowD;
				G = RowU;

			}
			if (incR < 0)
			{
				A = ColU;
				B = ColD;
			}
			else
			{
				A = ColD;
				B = ColU;

			}
			//For All Root Source to Destination.
			for (int i = F; i <= G; i++)
			{
				for (int j = A; j <= B; j++)
				{
					if (IgnoreSelfObject  &&i == RowSecond  &&j == ColumnSecond)
					{
						continue;
					}

					//If Abs Derivation is Not One Continue. 
					if (abs(i-RowFirst) != abs(j-ColumnFirst))
					{
						continue;
					}
					//If the Current is Not Source Home.
					if (i != RowFirst  &&j != ColumnFirst)
					{
						{
							//If the Root Contains Self Home Return Not Validity.
							if (Table[i][j] > 0 && Table[RowFirst][ColumnFirst] > 0)
							{
								(Act) = true;
								Move = false;
							}
							//If The Root Contains Self Home Return Not vALIDITY. 
							if (Table[i][j] < 0 && Table[RowFirst][ColumnFirst] < 0)
							{
								(Act) = true;
								Move = false;
							}
							//When the Current is Not The Source Home.
							if (i != RowSecond  &&j != ColumnSecond)
							{
								//When the Self ObjectExisting at the Root .
								if ((Table[i][j] > 0 || Table[i][j] < 0) && Table[RowFirst][ColumnFirst] > 0)
								{
									(Act) = true;
									Move = false;
								}
								//When the Self ObjectExisting at the Root .
								if ((Table[i][j] < 0 || Table[i][j] > 0) && Table[RowFirst][ColumnFirst] < 0)
								{
									(Act) = true;
									Move = false;
								}
							}
						}
					}

				}
			}
			//Return Validity.
			if (!Act)
			{
				Move = true;
			}
		}
		/*if (Move  System.Math.Abs(Ki) != 6)
		{
		    if (AchmazCheckByMoveByRule(Table, RowFirst, ColumnFirst, RowSecond, ColumnSecond, Order))
		        Move = false;
		}
		 */

		//Return Not Validity.
		return Move;
	}

	bool ChessRules::HourseRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy)
	{
		bool Move = false;
		//When L Movament is Occured. 
		if (abs(ColumnFirst-ColumnSecond) == 2 && abs(RowFirst-RowSecond) == 1)
		{
			//Retrun Validity.
			Move = true;
		}
		//When Second L Movments Occured.
		if (abs(ColumnFirst-ColumnSecond) == 1 && abs(RowFirst-RowSecond) == 2)
		{
			//Return Validity.
			Move = true;
		}
		//Return Not Validity.
		/* if (Move)
		 {
		     if (AchmazCheckByMoveByRule(Table, RowFirst, ColumnFirst, RowSecond, ColumnSecond, Order))
		         Move = false;
		 }
		 */

		return Move;
	}

	bool ChessRules::SoldierRulesaArrangmentsBoardOne(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy)
	{
		bool Move = false;
		//When int is Gray.
		if (Order == 1)
		{
			//If Not Forward Return Not Validity.
			if (ColumnFirst < ColumnSecond)
			{
				Move = false;
			}
		}
		else //int of Brown.
		{
			if (Order == -1)
			{
				//If Not Back Wrad Return Not Vlaidity.
				if (ColumnFirst > ColumnSecond)
				{
					Move = false;
				}
			}
		}
		//When Soldier Not Moved in Original Location do
		if (NotMoved)
		{
			if (Order == -1 && Table[RowFirst][ColumnFirst] < 0)
			{
				//Depend on First Move do For Land Of Islam
				//try
				{

					if ((ColumnFirst + 2 < 8) && (ColumnFirst + 1 < 8) && (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 2) && (Table[RowSecond][ColumnSecond-1] == 0))
					{
						//When Destination is The Empty Return Validity Else Return Not Validity.
						if (Table[RowSecond][ColumnSecond] == 0)
						{
							Move = true;
						}
						else
						{
							Move = false;
						}
					}
					else
					{
						if ((ColumnFirst + 1 < 8) && (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond][ColumnSecond] == 0))
						{
							//When Destination is The Empty Return Validity Else Return Not Validity.
							if (Table[RowSecond][ColumnSecond] == 0)
							{
								Move = true;
							}
							else
							{
								Move = false;
							}
						}
						else //Hit Brown Soldier Rulments.
						{
							if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
							{
								if (((RowSecond-1 < 8) &(RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									Move = true;
								}
								if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									Move = true;
								}

							}
						}
					}
				}
				//catch(std::exception t)
				{
					
				}
			}
			else //Gray int.
			{
				if (Order == 1 && Table[RowFirst][ColumnFirst] > 0)
				{
					//Depend Of First Move do For Positivism
					//try
					{
						if ((ColumnSecond + 2 < 8) && (ColumnSecond + 1 < 8) && (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 2) && (Table[RowSecond][ColumnSecond + 1] == 0))
						{
							//When Destination is The Empty Return Validity Else Return Not Validity.
							if (Table[RowSecond][ColumnSecond] == 0)
							{
								Move = true;
							}
							else
							{
								Move = false;
							}
						}
						else
						{
							if ((ColumnSecond + 1 < 8) && (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond][ColumnSecond] == 0))
							{
								//When Destination is The Empty Return Validity Else Return Not Validity.
								if (Table[RowSecond][ColumnSecond] == 0)
								{
									Move = true;
								}
								else
								{
									Move = false;
								}
							}
							else //Hit Condition Enemy Movments.
							{
								if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
								{
									if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
									{
										//Return Validity.
										Move = true;
									}
									if (((RowSecond-1 >= 0) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
									{
										//Return Validity.
										Move = true;
									}
								}
							}
						}
					}
					//catch(std::exception t)
					{
						
					}
				}
			}
		}
		else //If Soldeior Moved Previously.
		{
			//For Brown int.
			if (Order == -1 && Table[RowFirst][ColumnFirst] < 0)
			{
				//Depend on Second Move do For Land Of Islam
				//try
				{
					if ((ColumnFirst + 1 < 8) && (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond][ColumnSecond] == 0))
					{
						//When Destination is The Empty Return Validity Else Return Not Validity.
						if (Table[RowSecond][ColumnSecond] == 0)
						{
							Move = true;
						}
						else
						{
							Move = false;
						}
					}
					else //Hit Brown Soldier Rulments.
					{
						if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
						{
							if (((RowSecond-1 < 8) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
							{
								Move = true;
							}
							if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
							{
								Move = true;
							}

						}
					}
				}
				//catch(std::exception t)
				{
					
				}
			}
			else //Gray int.
			{
				if (Order == 1 && Table[RowFirst][ColumnFirst] > 0)
				{
					//Depend Of Second Move do For Positivism Land
					//try
					{
						if ((ColumnSecond + 1 < 8) && (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond][ColumnSecond] == 0))
						{
							//When Destination is The Empty Return Validity Else Return Not Validity.
							if (Table[RowSecond][ColumnSecond] == 0)
							{
								Move = true;
							}
							else
							{
								Move = false;
							}
						}
						else //Hit Condition Enemy Movments.
						{
							if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
							{
								if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									//Return Validity.
									Move = true;
								}
								if (((RowSecond-1 >= 0) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									//Return Validity.
									Move = true;
								}
							}
						}
					}
					//catch(std::exception t)
					{
						
					}
				}
			}
		}
		return Move;

	}

	bool ChessRules::SoldierRulesaArrangmentsBoardZero(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy)
	{
		bool Move = false;
		//When int is Gray.
		if (Order == 1)
		{
			//If Not Forward Return Not Validity.
			if (ColumnFirst > ColumnSecond)
			{
				Move = false;
			}
		}
		else //int of Brown.
		{
			if (Order == -1)
			{
				//If Not Back Wrad Return Not Vlaidity.
				if (ColumnFirst < ColumnSecond)
				{
					Move = false;
				}
			}
		}
		//When Soldier Not Moved in Original Location do
		if (NotMoved)
		{
			if (Order == 1 && Table[RowFirst][ColumnFirst] > 0)
			{
				//Depend on First Move do For Land Of Islam
				//try
				{

					if ((ColumnFirst + 2 < 8) && (ColumnFirst + 1 < 8) && (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 2) && Table[RowSecond][ColumnSecond=1] == 0)
					{
						//When Destination is The Empty Return Validity Else Return Not Validity.
						if (Table[RowSecond][ColumnSecond] == 0)
						{
							Move = true;
						}
						else
						{
							Move = false;
						}
					}
					else
					{
						if ((ColumnFirst + 1 < 8) && (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond][ColumnSecond] == 0))
						{
							//When Destination is The Empty Return Validity Else Return Not Validity.
							if (Table[RowSecond][ColumnSecond] == 0)
							{
								Move = true;
							}
							else
							{
								Move = false;
							}
						}
						else //Hit Gray Soldier Rulments.
						{
							if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
							{
								if (((RowSecond-1 < 8) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									Move = true;
								}
								if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									Move = true;
								}

							}
						}
					}
				}
				//catch(std::exception t)
				{
					
				}
			}
			else //Brown int.
			{
				if (Order == -1 && Table[RowFirst][ColumnFirst] < 0)
				{
					//Depend Of First Move do For Positivism
					//try
					{
						if ((ColumnSecond + 2 < 8) && (ColumnSecond + 1 < 8) && (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 2) && Table[RowSecond][ColumnSecond + 1] == 0)
						{
							//When Destination is The Empty Return Validity Else Return Not Validity.
							if (Table[RowSecond][ColumnSecond] == 0)
							{
								Move = true;
							}
							else
							{
								Move = false;
							}
						}
						else
						{
							if ((ColumnSecond + 1 < 8) && (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond][ColumnSecond] == 0))
							{
								//When Destination is The Empty Return Validity Else Return Not Validity.
								if (Table[RowSecond][ColumnSecond] == 0)
								{
									Move = true;
								}
								else
								{
									Move = false;
								}
							}
							else //Hit Condition Enemy Movments.
							{
								if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
								{
									if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
									{
										//Return Validity.
										Move = true;
									}
									if (((RowSecond-1 >= 0) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
									{
										//Return Validity.
										Move = true;
									}
								}
							}
						}
					}
					//catch(std::exception t)
					{
						
					}
				}
			}
		}
		else //If Soldeior Moved Previously.
		{
			//For Gray int.
			if (Order == 1 && Table[RowFirst][ColumnFirst] > 0)
			{
				//Depend on Second Move do For Land Of Islam
				//try
				{
					if ((ColumnFirst + 1 < 8) && (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond][ColumnSecond] == 0))
					{
						//When Destination is The Empty Return Validity Else Return Not Validity.
						if (Table[RowSecond][ColumnSecond] == 0)
						{
							Move = true;
						}
						else
						{
							Move = false;
						}
					}
					else //Hit Gray Soldier Rulments.
					{
						if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
						{
							if (((RowSecond-1 < 8) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
							{
								Move = true;
							}
							if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
							{
								Move = true;
							}

						}
					}
				}
				//catch(std::exception t)
				{
					
				}
			}
			else //Brown int.
			{
				if (Order == -1 && Table[RowFirst][ColumnFirst] < 0)
				{
					//Depend Of Second Move do For Positivism Land
					//try
					{
						if ((ColumnSecond + 1 < 8) && (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond][ColumnSecond] == 0))
						{
							//When Destination is The Empty Return Validity Else Return Not Validity.
							if (Table[RowSecond][ColumnSecond] == 0)
							{
								Move = true;
							}
							else
							{
								Move = false;
							}
						}
						else //Hit Condition Enemy Movments.
						{
							if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
							{
								if (((RowSecond + 1 < 8) && (RowFirst == RowSecond + 1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									//Return Validity.
									Move = true;
								}
								if (((RowSecond-1 >= 0) && (RowFirst == RowSecond-1) && ExistInDestinationEnemy) || IgnoreSelfObject)
								{
									//Return Validity.
									Move = true;
								}
							}
						}
					}
					//catch(std::exception t)
					{
						
					}
				}
			}
		}
		return Move;
	}

	bool ChessRules::SoldierRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy)
	{

		if (!(ArrangmentsBoard))
		{
			return SoldierRulesaArrangmentsBoardZero(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);
		}
		else
		{
			return SoldierRulesaArrangmentsBoardOne(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);
		}
		/*if (Move)
		{
		    if (AchmazCheckByMoveByRule(Table, RowFirst, ColumnFirst, RowSecond, ColumnSecond, Order))
		        Move = false;
		}
		 */
		///Return Not Validity.

	}

	void ChessRules::InitializeInstanceFields()
	{
		IgnoreSelfObject = false;
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		CheckGrayObjectDangour = false;
		CheckBrownObjectDangour = false;
		PatkGray = false;
		PatBrown = false;
		CheckGray = false;
		CheckBrown = false;
		CheckMateGray = false;
		CheckMateBrown = false;
		Kind = 0;
		KindNA = 0;
		Row = 0;
		Column = 0;
		Order = 0;
		ArrangmentsBoard = false;
		CurrentAStarGredyMax = -1;
	}
//}
