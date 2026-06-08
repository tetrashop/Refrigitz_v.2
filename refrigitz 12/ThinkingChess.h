
#pragma once
#include "stdafx.h"
#include <string>
#include <vector>
#include <cmath>
#include <float.h>
#include <stdexcept>
#include "AllDraw.h"
#include "DrawSoldire.h"
#include "DrawElefant.h"
#include "DrawHourse.h"
#include "DrawCastle.h"
#include "DrawMinister.h"
#include "DrawKing.h"
#include "StringConverterHelper.h"
#include "LearningKrinskyAtamata.h"
#include "ChessRules.h"

//#include "stdafx.h"
/****************************************************************************
 * Thinking Operation class.*************************************************
 * Ramin Edjlal**************************************************************
 * Drived Classess of Autamata Cellular  Thinking Kernel**************
 * 1394/12/19****************************************************************
 * Crashed with Stack Overflow Exception***************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Drives Caused Memory lack***************************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * New Version Cased Stack Overflow********************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Scanning Four Dimension Homes of Thing Existences Taking A lot Of Time******R**x0.12**4**Managements and Cuation Programing**********************(+)
 * All Data in This Scope From AllDraw Become Clear When Scope Change***x******R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Work but the Movements And Attack Method Doesn’t work*************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Probability Heuristic constant Table return*********************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Working Not Constant Immunity*************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Constant Result Mechanism*****************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Things Order and Virtualization Error***************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Misleading Things Order movement********************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Multi Movements (3 ) In Chess Thinking**************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Location of Horse 'Bob' (Gray) After Killer Un logically UnSelfSupported***R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Check Thinking 'Alice' Malfunction*******************************************R**x0.12**4**Managements and Cuation Programing*********************(+)
 * 'CheckMate' By 'Bob' Have Not Been Recognized.***********************************R**x0.12**4**Managements and Cuation Programing*****************(+)
 * 'Check' By 'Bob' Not Recognized.*********************************************R**x0.12**4**Managements and Cuation Programing*********************(+)
 * 'Check' 'Alice' Detected. No ActionsString Was Done.********************************R**x0.12**4**Managements and Cuation Programing*********************(+)
 * 'Check' Mechanism Failure.***************************************************R**x0.12**4**Managements and Cuation Programing*********************(+)
 * Strategy By 'Alice' Changed. 'Check' Not Recognized By 'Alice'.**************R**x0.12**4**Managements and Cuation Programing*********************(+)
 * Heuristic Loop**************************************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * 'Check' Mechanism For Penalty Regard Is Malfunction**************************RC**0.88**1**Risk Control*******************************************(*).
 * Things Location Failure. Row and Column of this Objects class Malfunction***R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Malfunction Of Operating Lists in this class.*******************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Some Movements of All Possible Movements is not Identified******************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Malfunction Clone Data To be Copied. List Will be erased********************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * King Cannot Hit UnSelfSupported Enemy Things at Check.***********************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Thinking Time Taking al lot of time.****************************************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * There is No Reason For Mal Function of Thinking.****************************R**x0.12**4**Managements and Cuation Programing**********************[+]
 * Huristic SelfSupported at horse huristic cal at table content malfunction.**R**x0.12**4**Managements and Cuation Programing**********************[+]
 * No Reason for malfunctioning of table content at huristic SelfSupported.****R**x0.12**4**Managements and Cuation Programing**********************[+]
 * Thinking Finished Misleading.bool Variable of Think Finished Not Work on.***R**x0.12**4**Managements and Cuation Programing**********************(+) 
 * A non Identified King Table List Alice is in List and Unhabitly ignored.****R**x0.12**4**Managements and Cuation Programing**********************(+)
 * The Location of Penalty Regard Mechansim is Misleading.*********************R**x0.12**4**Managements and Cuation Programing**********************(+)
 * Penalty Reagrd List is Empty.No Misleading List of Penalty Regard Mec.******R**x0.12**4**Managements and Cuation Programing**********************(+)
 * No Ilegal Non ObjectDanger and Check By 'Alice' at Current Game in PR Mech.********R**x0.12**4**Managements and Cuation Programing***************(+)
 * Mechansianm For Like Napeloonires KLish CheckMate is Incompletable.**************RC**0.88**1**Risk Control***************************************(*).
 * Ileegal Table Content Ignoring of Objects Kind.*****************************RC**0.88**1**Risk Control********************************************(*).
 * Tree Construction of AStarGready is Uncompleted.Some Nodes Become Empty.****R**x0.12**4**Managements and Cuation Programing**********************<+>
 * All Penalty Leads to 16 Objects Unmovable or Make Penalty But in Reality Non Penalty Exist.******************************************************(+)
 * All Self and Enemy CheckMate Mechanisam is Logical else Mislaeading.*************RC**0.88**1**Risk Control***************************************(*).QC-Ok.
 * Proccess of Thinking Stop Misleading With Error.*********************************RC**0.88**1**Risk Control***************************************{*}.QC-Ok.
 * All List of this class make differncy at several runable state of one table board state.RC**0.88**1**Risk Control********************************{*}..
 * Thinking Act Misleading.***************************************************************.RC**0.88**1**Risk Control********************************{*}.
 * The Achmaz Removing and maybe SelfNotSupported in Attacker conflict and thus Ignore.RC**0.88**1**Risk Control************************************(*).
 * The Self Supporter in Attacker somthime goes to misleading act.********************.RC**0.88**1**Risk Control************************************(*)QC-Ok.
 * Enemy Attacker Not Supported act Misleading.***************************************.RC**0.88**1**Risk Control************************************(*)QC_OK.
 * Heuristic proccesing dosne't haave any aim.****************************************.RC**0.88**1**Risk Control************************************(*).
 * Rating of Alice as Computer Game is very weak as compatitor of users.**************.RC**0.88**1**Risk Control************************************<*>QC_BAD.
 * Thinking gone to take some part of stones.*****************************************.RC**0.88**1**Risk Control************************************<*>QC_BAD.
 * Thinking failed becuase of all possible movment penalties of first level**.********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Object Dangour and Check is aditive of HeuristicCheckedand checked mated.**********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Heuristics take some part of stone.************************************************.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Branch Dept at Thinking Tree is low becuse of harware constraints and speed.*******.RC**0.88**1**Risk Control************************************<*>QC_BAD.
 * Thinking falied becuase of All Possible of Penalties movments.*********************.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Tow Confliction Misleading in Self Attacked and King Dangoure Separatedly.*********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Conflict in Restoring UsePenaltyRegardMechanisam value during User false.**********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Self Objects Movments Comes to Dangrous Location.**********************************.RC**0.88**1**Risk Control************************************(*).QC_OK
 * Thinking Tree Construction was not Complition and have empty with no reason.********RC**0.88**1**Risk Control************************************{*}QC_OK
 * Heuristic of 'Attack';'Movment';'Support';'CheckMate...' Undisiarable.**************RC**0.88**1**Risk Control************************************<*>QC _BAD
 * Huristic and Learning regime work in worth state.***********************************RC**0.88**1**Risk Control************************************(*)QC_BAD
 * Mal Function in Boundray Conditions founding in Leaf Creation Tree.*****************RC**0.88**1**Risk Control************************************(*)QC_BAD
 * Index was out of range in same grope of Thinking objects by hitting.****************RC**0.88**1**Risk Control************************************(*)QC_BAD
 * **************************************************************************(+:Sum(26)) (*:Sum(1)) 5:(+:Sum(3)) 6.(+:Sum0.12**4**Managements and Cuation Programing**********************(+)) 7.(:Sum(1))
 * **************************************************************************
 */



//namespace RefrigtzDLL
//{
	
		
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class ThinkingChess
	class ThinkingChess
	{
	public:
		double HuristicAttackValueSup;
		double HuristicMovementValueSup;
		double HuristicSelfSupportedValueSup;
		double HuristicObjectDangourCheckMateValueSup;
		double HuristicKillerValueSup;
		double HuristicReducedAttackValueSup;
		double HeuristicDistabceOfCurrentMoveFromEnemyKingValueSup;
		double HeuristicKingSafeSup;
		double HeuristicFromCenterSup;
		double HeuristicKingDangourSup;
		bool IsSup;
		bool IsSupHu;

	public:
		//StackFrame *callStack;
		//Initiate Global and Static Variables. 
	public:
		bool IsThereMateOfEnemy;
		bool IsThereMateOfSelf;		
		void CastleThinkingGray(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void HuristicPenaltyValuePerform(LearningKrinskyAtamata Current, int Order, double HuristicAttackValue, bool AllDrawClass = false);
	public:
		bool ThinkingAtRun;
	public:
		static std::wstring ActionsString;
	public:
		std::wstring OutPutAction;
		int ThinkingLevel;
	public:
		std::vector<bool*> LearningVarsObject;
		static bool LearningVarsCheckedMateOccured;
		static bool LearningVarsCheckedMateOccuredOneCheckedMate;
	public:
		bool IsGardHighPriority;
		static  int ThresholdBlitz ;
		static  int ThresholdFullGame;
	public:
		static double MaxHuristicx;
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
	public:
		bool ArrangmentsChanged;
	public:
		int NumberOfPenalties;
	public:
		static int NumbersOfCurrentBranchesPenalties;
	public:
		static int NumbersOfAllNode;
		/*public int SodierMidle = 8;
		public int SodierHigh = 16;
		public int ElefantMidle = 2;
		public int ElefantHigh = 4;
		public int HourseMidle = 2;
		public int HourseHight = 4;
		public int CastleMidle = 2;
		public int CastleHigh = 4;
		public int MinisterMidle = 1;
		public int MinisterHigh = 2;
		public int KingMidle = 1;
		public int KingHigh = 2;
		*/
		int SodierMidle;
		int SodierHigh;
		int ElefantMidle;
		int ElefantHigh;
		int HourseMidle;
		int HourseHight;
		int CastleMidle;
		int CastleHigh;
		int MinisterMidle;
		int MinisterHigh;
		int KingMidle;
		int KingHigh;

		static bool KingMaovableGray;
		static bool KingMaovableBrown;
		static int FoundFirstMating;
		static int FoundFirstSelfMating;
		int SodierValue;
		int ElefantValue;
		int HourseValue;
		int CastleValue;
		int MinisterValue;
		int KingValue;
		static int BeginThread;
		static int EndThread;
	public:
		bool ExistingOfEnemyHiiting;
		int IgnoreObjectDangour;
	public:
		int CheckMateAStarGreedy;
	public:
		bool CheckMateOcuured;
		int CurrentRow, CurrentColumn;
	public:
		int CheckedM;
		bool IsCheck;
		int Kind;
		std::vector<int> HitNumber;
		static bool NotSolvedKingDanger;
		static bool ThinkingRun;
		int ThingsNumber;
		int CurrentArray;
		bool ThinkingBegin;
		bool ThinkingFinished;
		int IndexSoldier;
		int IndexElefant;
		int IndexHourse;
		int IndexCastle;
		int IndexMinister;
		int IndexKing;
		//static public int Index = 0;
		//static public int[,] RowColumn;
		std::vector<int*> RowColumnSoldier;
		std::vector<int*> RowColumnElefant;
		std::vector<int*> RowColumnHourse;
		std::vector<int*> RowColumnCastle;
		std::vector<int*> RowColumnMinister;
		std::vector<int*> RowColumnKing;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public int[,] TableT;
		int **TableT;
		std::vector<int> HitNumberSoldier;
		std::vector<int> HitNumberElefant;
		std::vector<int> HitNumberHourse;
		std::vector<int> HitNumberCastle;
		std::vector<int> HitNumberMinister;
		std::vector<int> HitNumberKing;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public int[,] TableConst;
		int **TableConst;
		std::vector<int**> TableListSolder;
		std::vector<int**> TableListElefant;
		std::vector<int**> TableListHourse;
		std::vector<int**> TableListCastle;
		std::vector<int**> TableListMinister;
		std::vector<int**> TableListKing;
		std::vector<double*> HuristicListSolder;
		std::vector<double*> HuristicListElefant;
		std::vector<double*> HuristicListHourse;
		std::vector<double*> HuristicListCastle;
		std::vector<double*> HuristicListMinister;
		std::vector<double*> HuristicListKing;
		std::vector<LearningKrinskyAtamata> PenaltyRegardListSolder;
		std::vector<LearningKrinskyAtamata> PenaltyRegardListElefant;
		std::vector<LearningKrinskyAtamata> PenaltyRegardListHourse;		
		std::vector<LearningKrinskyAtamata> PenaltyRegardListCastle;
		std::vector<LearningKrinskyAtamata> PenaltyRegardListMinister;
		std::vector<LearningKrinskyAtamata> PenaltyRegardListKing;
		int Max;
		int Row, Column;
		int color;
		int Order;	
		std::vector<AllDraw> AStarGreedy;
		
	public:
		
		double Value[8][8];
		bool IgnoreFromCheckandMateHuristic;
		int CurrentAStarGredyMax;
		std::vector<int**> ObjectNumbers;

		///Log of Errors.
		//static void Log(std::exception ex);
		void SetObjectNumbersInList(int **Tab);
	public:
		void SetObjectNumbers(int **TabS);
		//Constructor
		ThinkingChess(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j);
		/*double SetObjectValue(int[,] Tab, int Row, int Column)
		{
		    Object o = new Object();
		    //lock (o)
		    {
		        for (int h = 0; h < 8; h++)
		        for (int m = 0; m < 8; m++)
		        {
		            //if (h != Row || m != Column)
		            //return;
		            Value[Row, Column] = 0;
		            {
		                if (Tab == null)
		                    return 0;
		                else
		                    Value[Row, Column] += ObjectValueCalculator(Tab, Row, Column);
		            }
		        }
		    }
		    return Value[Row, Column];
		}
		double SetObjectValue(int[,] Tab//, int Row, int Column
		    )
		{
		                Value[h, m] = 0;
		                {
		                    if (Tab == null)
		                        return 0;
		                    else
		                        Value[h, m] += ObjectValueCalculator(Tab, h, m);
		                }
		            }
		    return Value[Row, Column];
		}*/

		//determine When Arrangment of Table Objects is Validated at Begin.
	public:
		//bool BeginArragmentsOfOrderFinished(int **Table, int Order);
		//Constructor
	public:
		//void CastleThinkingGray(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		ThinkingChess(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j, int a, int **Tab, int Ma, int Ord, bool ThinkingBeg, int CurA, int ThingN, int Kin);
		//Clone A Table
	public:
		int **CloneATable(int **Tab);
		//Clone A List.  
		int *CloneAList(int *Tab, int Count);
		//Clone a copy of an array.
		double *CloneAList(double *Tab, int Count);
		//Gwt Value of Book Netwrok  Atamtat at Every Need time form parameters index.
		double GetValue(int i, int j);
		void Clone(ThinkingChess * AA);		
		///Clone a Copy.
	public:
		//void Clone(ThinkingChess AA);
		///Huristic of Attacker.
	public:
		double HuristicAttack(bool Before, int **Table, int Ord, int aa, int RowS, int ColS, int RowD, int ColD);
		double HuristicReducsedAttack(bool Before, int **Table, int Ord, int aa, int RowS, int ColS, int RowD, int ColD);
		///Value of Object method.
		int GetObjectValue(int **Tabl, int ii, int jj, int Order);
		///Huristic of ObjectDanger.
		double HuristicObjectDangour(int **Table, int Order, int a, int RowS, int ColS, int RowD, int ColD);
		double HuristicKiller(int Killed, int **Tabl, int RowS, int ColS, int RowD, int ColD, int Ord, int aa, bool Hit);
		//Attacks Of Enemy that is not Supported.QC_OK
		bool InAttackEnemyThatIsNotSupported(int Kilded, int **Table, int Order, int a, int i, int j, int ii, int jj);
		//bool InAttackEnemyThatIsNotSupportedAll(bool EnemyIsValuable, int ** Table, int Order, int a, int ij, int ji, int iij, int jji, std::vector<int> ValuableEnemyNotSupported);
		//When at least one Attacked Self Object return true.
		//bool InAttackEnemyThatIsNotSupportedAll(bool EnemyIsValuable, int **Table, int Order, int a, int ij, int ji, int iij, int jji, std::vector<int> ValuableEnemyNotSupported);
		//When  there is more than tow self object not supported on atacked by movement return true.
		int IsNotSafeToMoveAenemeyToAttackMoreThanTowObject(int AttackCount, int **Table, int Order, int i, int j, int ii, int jj);
		//Supported of Self that is Not Attacks.QC_BAD
		bool InAttackSelfThatNotSupported(int **TableS, int Order, int a, int ij, int ji, int ii, int jj);
		//When there is at least on self object that is not safty.
		bool InAttackSelfThatNotSupportedAll(int **TableS, int Order, int a, int i, int j, int RowS, int ColS, int ikk, int jkk, int iik, int jjk);
		//Creation A Complete List of Attacked Self Object(s).
		bool InAttackSelfThatNotSupportedCalculateValuableAll(int **TableS, int Order, int a, int ij, int ji, int ii, int jj, std::vector<int*> ValuableSelfSupported);
		bool ExistValuble(int *Table, std::vector<int*> ValuableSelfSupported);
		bool MaxObjecvts(std::vector<int> Obj, int Max);
		//When Current Movment Take Supporte.QC_OK
		bool IsCurrentMoveTakeSupporte(int **Table, int Order, int a, int i, int j, int ii, int jj);
		///Huristic of King safty.
		double HeuristicKingSafety(int **Tab, int Order, int a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD);
		double HeuristicKingDangourous(int **Tab, int Order, int a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD);
			//Huristic of Supportation.
			double HuristicSelfSupported(int **Tab, int Ord, int aa, int RowS, int ColS, int RowD, int ColD);
	public:
		static bool TableEqual(int **Tab1, int **Tab2);
		//If tow int Objects is equal.
		static bool TableEqual(int Tab1, int Tab2);
		//Deterimination of Existance of Table in List..
		static bool ExistTableInList(int **Tab, std::vector<int**> List, int Index);
		///Move Determination.
		bool Movable(int **Tab, int i, int j, int ii, int jj, int a, int Order);
		//
		//When Oredrs of OrderPalte and Calculation Order is not equal return negative one and else return one.
	public:
		double SignOrderToPlate(int Order);
		//Remove Penalties of Unnesserily Nodes.
	public:
		bool RemovePenalty(int **Tab, int Order, int i, int j);
		//Dangouring of current movment fo current Order.
	public:
		bool InAttackEnemyThatIsNotSupportedAll(bool EnemyIsValuable, int **Table, int Order, int a, int ij, int ji, int iij, int jji, std::vector<int> ValuableEnemyNotSupported);
		bool IsCurrentStateIsDangreousForCurrentOrder(int **Tabl, int Order, int a, int ii, int jj);

		//When Next Movements is Checked.QC_OK.
		int *IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(int Order, int **Tabl, int ik, int jk, int iki, int jki, int OrderPalte, int OrderPalteMulMinuse, int Depth, bool KindCheckedSelf);
		//When Next Movements is Checked.QC_OK.
		bool IsNextMovmentIsCheckOrCheckMateForCurrentMovmentOnCurrentMovemnet(int Order, int **Tabl, int ik, int jk, int iki, int jki, int OrderPalte);
		int *IsNextMovmentIsCheckOrCheckMateForCurrentMovment(int **Tabl, int Order, int a, int Depth, int OrderPalte, int OrderPalteMinusPluse, bool KindCheckedSelf);
		//When Current Movements is in dangrous and is not movable.
		bool IsGardForCurrentMovmentsAndIsNotMovable(int **Tab, int Order, int a, int ii, int jj, int RowS, int ColS);

		///when current movments gards enemy with higer priority at movment.QC_OK
		bool IsCurrentCanGardHighPriorityEnemy(int Depth, int **Table, int Order, int a, int ij, int ji, int iij, int jji, int OrderPlate);
		///Huristic of Check and CheckMate.
	public:
		double HuristicCheckAndCheckMate(int **Table, int a);
		//Veryfy and detect Object Value.
	public:
		int VeryFye(int **Table, int Order, int a);
		//QC_OK
		//Numbers of Supporting Current Objects method.
		int SupporterCount(int **Table, int Order, int a, int ii, int jj);
		//Attacks on Enemies.
		int AttackerCount(int **Table, int Order, int a, int i, int j);
		//Attackers of Enemies.QC_OK.
		int EnemyAttackerCount(int **Table, int Order, int a, int ii, int jj);
		//Distance of Enemy Kings from Current Object.
	public:
		double HeuristicDistabceOfCurrentMoveFromEnemyKing(int **Tab, int Order, int RowS, int ColS);
		double HuristicSoldierFromCenter(int **Table, int aa, int Ord, int ii, int jj, int i, int j);
		double *HuristicAll(bool Before, int Killed, int **Table, int aa, int Ord, int RowS, int ColS, int RowD, int ColD);
		//void HuristicPenaltyValuePerform(LearningKrinskyAtamata Current, int Order, double HuristicAttackValue, bool AllDraw Class = false);
		
		///Huristic of Movments.
		double HuristicMovment(bool Before, int **Table, int aa, int Ord, int RowS, int ColS, int RowD, int ColD);
		///Attack Determination.QC_Ok
		bool Attack(int **Tab, int i, int j, int ii, int jj, int a, int Order);
		//Object Danger Determination.
		bool ObjectDanger(int **Tab, int i, int j, int ii, int jj, int a, int Order);
		///Supportation Determination.QC_OK
		bool Support(int **Tab, int i, int j, int ii, int jj, int a, int Order);

		//Return Msx Huiristic of Child Level.
		bool MaxHuristic(int j, int Kin, double Less, int Order);
		//Setting Numbers of Objects in Current Table boards.
		//Count of Solders on Table.
	public:
		/*int SolderOnTableCount(DrawSoldier So*, bool Mi, int MaxCount);
		//Elepahnt On Table Count.
		int ElefantOnTableCount(DrawElefant So*, bool Mi, int MaxCount);
		//Calculate Hourse on table.
		int HourseOnTableCount(DrawHourse So*, bool Mi, int MaxCount);
		//Calculate Castles Count.
		int CastleOnTableCount(DrawCastle So*, bool Mi, int MaxCount);
		//Calculate Minsiter Count.
		int MinisterOnTableCount(DrawMinister So*, bool Mi, int MaxCount);
		//Calculate King on Table.
		int KingOnTableCount(DrawKing So*, bool Mi, int MaxCount);
		*/
		//Return Huristic.
	public:
		double ReturnHuristic(int ii, int j, int Order, bool AA);
	public:
		std::wstring Alphabet(int RowRealesed);
		std::wstring Number(int ColumnRealeased);
	public:
		double ReturnHuristicCalculartor(int iAstarGready, int ii, int j, int Order);
		//Returrn of Hurestic Tree.QC_Ok.
		//Scope of Every Objects Movments.
	public:
		bool Scop(int i, int j, int ii, int jj, int Kind);
		//Calculate Maximum of Six Max Huristic of Six Kind Objects.
		int MaxOfSixHuristic(double *Less);
		//Calculate Minimum of Six Min Huristic of Six Kind Objects.note the enemy Huristic are negative.
		int MinOfSixHuristic(double *Less);


		void KingThinkinChess(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		std::wstring CheM(int A);

		void MinisterThinkingChess(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		bool IsPrviousMovemntIsDangrousForCurrent(int **TableS, int Order);
		//When There is not valuable Object in List Greater than Target Self Object return true.        
		bool IsObjectValaubleObjectSelf(int i, int j, int Object, std::vector<int*> ValuableSelfSupported);
		bool IsObjectValaubleObjectEnemy(int i, int j, int Object, std::vector<int> ValuableEnemyNotSupported);
		bool *SomeLearningVarsCalculator(int **TableS, int ik, int jk, int iik, int jjk);
		bool *CalculateLearningVars(int Killed, int **TableS, int i, int j, int ii, int jj);
		void CastlesThinkingChess(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void HourseThinkingChess(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void ElephantThinkingChess(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		bool EqualitTow(bool PenRegStrore, int kind);
		bool EqualitOne(LearningKrinskyAtamata  Current, int kind);
		void AddAtList(int kind, LearningKrinskyAtamata   Current);
		void RemoveAtList(int kind);
    	bool PenaltyMechanisam(int LoseOcuuredatChiled, int WinOcuuredatChiled, int CheckedM, int Killed, bool Before, int kind, int **TableS, int ii, int jj, LearningKrinskyAtamata  Current, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int i, int j, bool Castle);
		void SolderThinkingChess(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void CastleThinkingBrown(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);

	public:		
		void CalculateHuristics(bool Before, int Killed, int **TableS, int RowS, int ColS, int RowD, int ColD, int color, double HuristicAttackValue, double HuristicMovementValue, double HuristicSelfSupportedValue, double HuristicObjectDangourCheckMateValue, double HuristicKillerValue, double HuristicReducedAttackValue, double HeuristicDistabceOfCurrentMoveFromEnemyKingValue, double HeuristicKingSafe, double HeuristicFromCenter, double HeuristicKingDangour);

	//public:
		//void CastleThinkingGray(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);		
	public:
		//bool AttackSelfThatNotSupportedCalculateValuableAll(int **TableS, int Order, int a, int ij, int ji, int ii, int jj, std::vector<int*> ValuableSelfSupported);
		void ThinkingSoldierBase(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingSoldier(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingElephantBase(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);

		void ThinkingElephant(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseOne(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseTwo(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseThree(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseFour(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseFive(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseSix(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseSeven(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingHourseEight(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);


		void ThinkingHourse(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingCastleOne(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingCastleTow(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingCastle(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingMinisterBase(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingMinister(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingCastleGray(int  LoseOcuuredatChiled, int  WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingCastleBrown(int  LoseOcuuredatChiled, int  WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		//void CastleThinkingGray(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		//void CastleThinkingBrown(int LoseOcuuredatChiled, int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int **TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void ThinkingKing(int LoseOcuuredatChiled, int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		///Kernel of Thinking
		void Thinking(int LoseOcuuredatChiled, int WinOcuuredatChiled);
	public:
		double RetrunValValue(int RowS, int ColS, int RowO, int ColO, int **Tab, int Sign);

		double ObjectValueCalculator(int **Table, int RowS, int ColS, int RowO, int ColumnO); //, int Order
		double ObjectValueCalculator(int **Table, int RowS, int ColS); //, int Order
		bool SignSelfEmpty(int Obj1, int Obj2, int Order, int Ord, int A);
		bool SignEnemyEmpty(int Obj1, int Obj2, int Order, int Ord, int A);
		bool SignNotEqualEnemy(int Obj1, int Obj2, int Order, int Ord, int A);
		bool SignEqualSelf(int Obj1, int Obj2, int Order, int Ord, int A);
		bool SignNotEqualSelf(int Obj1, int Obj2, int Order, int Ord, int A);
		

	public:
		void InitializeInstanceFields();
	};
//}

//End of Documentation.
