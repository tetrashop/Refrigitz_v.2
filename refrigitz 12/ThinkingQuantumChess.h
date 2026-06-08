#pragma once

#include "../../Refregitz/Refrigtz/bin/Debug/All/All/NetworkQuantumLearningKrinskyAtamata.h"
#include "../../Refregitz/Refrigtz/bin/Release/All/All/NetworkQuantumLearningKrinskyAtamata.h"
#include "../../Refregitz/Refrigtz/QuantumAtamata.h"
#include "../../Refregitz/Refrigtz/bin/Debug/All/All/QuantumAtamata.h"
#include "../../Refregitz/Refrigtz/bin/Release/All/All/QuantumAtamata.h"
#include "../../Refregitz/QuantumRefrigiz/AllDraw.h"
#include "../../Refregitz/QuantumRefrigiz/DrawSoldire.h"
#include "../../Refregitz/QuantumRefrigiz/DrawElefant.h"
#include "../../Refregitz/QuantumRefrigiz/DrawHourse.h"
#include "../../Refregitz/QuantumRefrigiz/DrawCastle.h"
#include "../../Refregitz/QuantumRefrigiz/DrawMinister.h"
#include "../../Refregitz/QuantumRefrigiz/DrawKing.h"
#include <string>
#include <vector>
#include <cmath>
#include <float.h>
#include <stdexcept>
#include "stringconverter.h"

/****************************************************************************
 * ThinkingQuantum Operation class.*************************************************
 * Ramin Edjlal**************************************************************
 * Drived Classess of Autamata Cellular Quantum ThinkingQuantum Kernel**************
 * 1394/12/19****************************************************************
 * Crashed with Stack Overflow Exception***************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Drives Caused Memory lack***************************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * New Version Cased Stack Overflow********************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Scanning Four Dimension Homes of Thing Existences Taking A lot Of Time******RS**0.12**4**Managements and Cuation Programing**********************(+)
 * All Data in This Scope From AllDraw Become Clear When Scope Changes*********RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Work but the Movements And Attack Method Doesn’t work*************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Probability Heuristic constant Table return*********************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Working Not Constant Immunity*************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Constant Result Mechanism*****************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Things Order and Virtualization Error***************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Misleading Things Order movement********************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Multi Movements (3 ) In Chess ThinkingQuantum**************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Location of Horse 'Bob' (Gray) After Killer Un logically UnSelfSupported***RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Check ThinkingQuantum 'Alice' Malfunction*******************************************RS**0.12**4**Managements and Cuation Programing*********************(+)
 * 'CheckMate' By 'Bob' Have Not Been Recognized.***********************************RS**0.12**4**Managements and Cuation Programing*****************(+)
 * 'Check' By 'Bob' Not Recognized.*********************************************RS**0.12**4**Managements and Cuation Programing*********************(+)
 * 'Check' 'Alice' Detected. No ActionsString Was Done.********************************RS**0.12**4**Managements and Cuation Programing*********************(+)
 * 'Check' Mechanism Failure.***************************************************RS**0.12**4**Managements and Cuation Programing*********************(+)
 * Strategy By 'Alice' Changed. 'Check' Not Recognized By 'Alice'.**************RS**0.12**4**Managements and Cuation Programing*********************(+)
 * Heuristic Loop**************************************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * 'Check' Mechanism For Penalty Regard Is Malfunction**************************RC**0.88**1**Risk Control*******************************************(*).
 * Things Location Failure. Row and Column of this Objects class Malfunction***RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Malfunction Of Operating Lists in this class.*******************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Some Movements of All Possible Movements is not Identified******************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Malfunction Clone Data To be Copied. List Will be erased********************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * King Cannot Hit UnSelfSupported Enemy Things at Check.***********************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * ThinkingQuantum Time Taking al lot of time.****************************************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * There is No Reason For Mal Function of ThinkingQuantum.****************************RS**0.12**4**Managements and Cuation Programing**********************[+]
 * Huristic SelfSupported at horse huristic cal at table content malfunction.**RS**0.12**4**Managements and Cuation Programing**********************[+]
 * No Reason for malfunctioning of table content at huristic SelfSupported.****RS**0.12**4**Managements and Cuation Programing**********************[+]
 * ThinkingQuantum Finished Misleading.bool Variable of Think Finished Not Work on.***RS**0.12**4**Managements and Cuation Programing**********************(+) 
 * A non Identified King Table List Alice is in List and Unhabitly ignored.****RS**0.12**4**Managements and Cuation Programing**********************(+)
 * The Location of Penalty Regard Mechansim is Misleading.*********************RS**0.12**4**Managements and Cuation Programing**********************(+)
 * Penalty Reagrd List is Empty.No Misleading List of Penalty Regard Mec.******RS**0.12**4**Managements and Cuation Programing**********************(+)
 * No Ilegal Non ObjectDanger and Check By 'Alice' at Current Game in PR Mech.********RS**0.12**4**Managements and Cuation Programing***************(+)
 * Mechansianm For Like Napeloonires KLish CheckMate is Incompletable.**************RC**0.88**1**Risk Control***************************************(*).
 * Ileegal Table Content Ignoring of Objects Kind.*****************************RC**0.88**1**Risk Control********************************************(*).
 * Tree Construction of AStarGready is Uncompleted.Some Nodes Become Empty.****RS**0.12**4**Managements and Cuation Programing**********************<+>
 * All Penalty Leads to 16 Objects Unmovable or Make Penalty But in Reality Non Penalty Exist.******************************************************(+)
 * All Self and Enemy CheckMate Mechanisam is Logical else Mislaeading.*************RC**0.88**1**Risk Control***************************************(*).QC-Ok.
 * Proccess of ThinkingQuantum Stop Misleading With Error.*********************************RC**0.88**1**Risk Control***************************************{*}.QC-Ok.
 * All List of this class make differncy at several runable state of one table board state.RC**0.88**1**Risk Control********************************{*}..
 * ThinkingQuantum Act Misleading.***************************************************************.RC**0.88**1**Risk Control********************************{*}.
 * The Achmaz Removing and maybe SelfNotSupported in Attacker conflict and thus Ignore.RC**0.88**1**Risk Control************************************(*).
 * The Self Supporter in Attacker somthime goes to misleading act.********************.RC**0.88**1**Risk Control************************************(*)QC-Ok.
 * Enemy Attacker Not Supported act Misleading.***************************************.RC**0.88**1**Risk Control************************************(*)QC_OK.
 * Heuristic proccesing dosne't haave any aim.****************************************.RC**0.88**1**Risk Control************************************(*).
 * Rating of Alice as Computer Game is very weak as compatitor of users.**************.RC**0.88**1**Risk Control************************************<*>QC_BAD.
 * ThinkingQuantum gone to take some part of stones.*****************************************.RC**0.88**1**Risk Control************************************<*>QC_BAD.
 * ThinkingQuantum failed becuase of all possible movment penalties of first level**.********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Object Dangour and Check is aditive of HeuristicCheckedand checked mated.**********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Heuristics take some part of stone.************************************************.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Branch Dept at ThinkingQuantum Tree is low becuse of harware constraints and speed.*******.RC**0.88**1**Risk Control************************************<*>QC_BAD.
 * ThinkingQuantum falied becuase of All Possible of Penalties movments.*********************.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Tow Confliction Misleading in Self Attacked and King Dangoure Separatedly.*********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Conflict in Restoring UsePenaltyRegardMechanisam value during User false.**********.RC**0.88**1**Risk Control************************************<*>QC_OK.
 * Self Objects Movments Comes to Dangrous Location.**********************************.RC**0.88**1**Risk Control************************************(*).QC_OK
 * ThinkingQuantum Tree Construction was not Complition and have empty with no reason.********RC**0.88**1**Risk Control************************************{*}QC_OK
 * Heuristic of 'Attack';'Movment';'Support';'CheckMate...' Undisiarable.**************RC**0.88**1**Risk Control************************************<*>QC _BAD
 * Huristic and Learning regime work in worth state.***********************************RC**0.88**1**Risk Control************************************(*)QC_BAD
 * Mal Function in Boundray Conditions founding in Leaf Creation Tree.*****************RC**0.88**1**Risk Control************************************(*)QC_BAD
 * Index was out of range in same grope of ThinkingQuantum objects by hitting.****************RC**0.88**1**Risk Control************************************(*)QC_BAD
 * **************************************************************************(+:Sum(26)) (*:Sum(1)) 5:(+:Sum(3)) 6.(+:Sum0.12**4**Managements and Cuation Programing**********************(+)) 7.(:Sum(1))
 * **************************************************************************
 */
using namespace LearningMachine;
namespace QuantumRefrigiz
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class ThinkingQuantumChess
	class ThinkingQuantumChess
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


	private:
		StackFrame *callStack;
		//Initiate Global and Static Variables. 
	public:
		bool IsThereMateOfEnemy;
		bool IsThereMateOfSelf;
		static NetworkQuantumLearningKrinskyAtamata *LearniningTable;
	private:
		bool ThinkingQuantumAtRun;
	public:
		static std::wstring ActionsString;
	private:
		std::wstring OutPutAction;
		int ThinkingQuantumLevel;
	public:
		std::vector<bool[]> LearningVarsObject;
		static bool LearningVarsCheckedMateOccured;
		static bool LearningVarsCheckedMateOccuredOneCheckedMate;
		//int DivisionPenaltyRegardHeuristicQueficient = 1;
		int SuppportCountStaticGray;
		int SuppportCountStaticBrown;
	private:
		bool IsGardHighPriority;
		static const int ThresholdBlitz = 10000;
		static const int ThresholdFullGame = 20000;
	public:
		static double MaxHuristicx;
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
	private:
		bool ArrangmentsChanged;
	public:
		int NumberOfPenalties;
	private:
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
	private:
		bool ExistingOfEnemyHiiting;
		int IgnoreObjectDangour;
	public:
		int CheckMateAStarGreedy;
	private:
		bool CheckMateOcuured;
		int CurrentRow, CurrentColumn;
	public:
		bool IsCheck;
		int Kind;
		std::vector<int> HitNumber;
		static bool NotSolvedKingDanger;
		static bool ThinkingQuantumRun;
		int ThingsNumber;
		int CurrentArray;
		bool ThinkingQuantumBegin;
		bool ThinkingQuantumFinished;
		int IndexSoldier;
		int IndexElefant;
		int IndexHourse;
		int IndexCastle;
		int IndexMinister;
		int IndexKing;
		//static public int Index = 0;
		//static public int[,] RowColumn;
		std::vector<int[]> RowColumnSoldier;
		std::vector<int[]> RowColumnElefant;
		std::vector<int[]> RowColumnHourse;
		std::vector<int[]> RowColumnCastle;
		std::vector<int[]> RowColumnMinister;
		std::vector<int[]> RowColumnKing;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public int[,] TableT;
		int **TableT;
		std::vector<int> HitNumberSoldier;
		std::vector<int> HitNumberElefant;
		std::vector<int> HitNumberHourse;
		std::vector<int> HitNumberCastle;
		std::vector<int> HitNumberMinister;
		std::vector<int> HitNumberKing;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public int[,] TableConst;
		int **TableConst;
		std::vector<int[][]> TableListSolder;
		std::vector<int[][]> TableListElefant;
		std::vector<int[][]> TableListHourse;
		std::vector<int[][]> TableListCastle;
		std::vector<int[][]> TableListMinister;
		std::vector<int[][]> TableListKing;
		std::vector<double[]> HuristicListSolder;
		std::vector<double[]> HuristicListElefant;
		std::vector<double[]> HuristicListHourse;
		std::vector<double[]> HuristicListCastle;
		std::vector<double[]> HuristicListMinister;
		std::vector<double[]> HuristicListKing;
		std::vector<QuantumAtamata*> PenaltyRegardListSolder;
		std::vector<QuantumAtamata*> PenaltyRegardListElefant;
		std::vector<QuantumAtamata*> PenaltyRegardListHourse;
		std::vector<QuantumAtamata*> PenaltyRegardListCastle;
		std::vector<QuantumAtamata*> PenaltyRegardListMinister;
		std::vector<QuantumAtamata*> PenaltyRegardListKing;
		int Max;
		int Row, Column;
		int color;
		int Order;
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [NonSerialized()] public Task t = nullptr;
		Task *t;
		std::vector<AllDraw*> AStarGreedy;
	private:
		double Value[8][8];
		bool IgnoreFromCheckandMateHuristic;
		int CurrentAStarGredyMax;
		std::vector<int[][]> ObjectNumbers;

		///Log of Errors.
		static void Log(std::exception &ex);
		void SetObjectNumbersInList(int Tab[][]);
	public:
		void SetObjectNumbers(int TabS[][]);
		//Constructor
		ThinkingQuantumChess(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j);
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
		    
		    return Value[Row, Column];
		}*/

		//determine When Arrangment of Table Objects is Validated at Begin.
	private:
		bool BeginArragmentsOfOrderFinished(int Table[][], int Order);
		//Constructor
	public:
		ThinkingQuantumChess(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j, int a, int Tab[][], int Ma, int Ord, bool ThinkingQuantumBeg, int CurA, int ThingN, int Kin);
		//Clone A Table
	private:
		int **CloneATable(int Tab[][]);
		//Clone A List.  
		int *CloneAList(int Tab[], int Count);
		//Clone a copy of an array.
		double *CloneAList(double Tab[], int Count);
		//Gwt Value of Book Netwrok Quantum Atamtat at Every Need time form parameters index.
		double GetValue(int i, int j);
		///Clone a Copy.
	public:
		void Clone(ThinkingQuantumChess *&AA);
		///Huristic of Attacker.
	private:
		double HuristicAttack(bool Before, int Table[][], int Ord, int aa, int RowS, int ColS, int RowD, int ColD);
		double HuristicReducsedAttack(bool Before, int Table[][], int Ord, int aa, int RowS, int ColS, int RowD, int ColD);
		///Value of Object method.
		int GetObjectValue(int Tabl[][], int ii, int jj, int Order);
		///Huristic of ObjectDanger.
		double HuristicObjectDangour(int Table[][], int Order, int a, int RowS, int ColS, int RowD, int ColD);
		double HuristicKiller(int Killed, int Tabl[][], int RowS, int ColS, int RowD, int ColD, int Ord, int aa, bool Hit);
		//Attacks Of Enemy that is not Supported.QC_OK
		bool InAttackEnemyThatIsNotSupported(int Kilded, int Table[][], int Order, int a, int i, int j, int ii, int jj);
		//When at least one Attacked Self Object return true.
		bool InAttackEnemyThatIsNotSupportedAll(bool EnemyIsValuable, int Table[][], int Order, int a, int ij, int ji, int iij, int jji, std::vector<int[]> &ValuableEnemyNotSupported);
		//When  there is more than tow self object not supported on atacked by movement return true.
		int IsNotSafeToMoveAenemeyToAttackMoreThanTowObject(int AttackCount, int Table[][], int Order, int i, int j, int ii, int jj);
		//Supported of Self that is Not Attacks.QC_BAD
		bool InAttackSelfThatNotSupported(int TableS[][], int Order, int a, int ij, int ji, int ii, int jj);
		//When there is at least on self object that is not safty.
		bool InAttackSelfThatNotSupportedAll(int TableS[][], int Order, int a, int i, int j, int RowS, int ColS, int ikk, int jkk, int iik, int jjk);
		//Creation A Complete List of Attacked Self Object(s).
		bool InAttackSelfThatNotSupportedCalculateValuableAll(int TableS[][], int Order, int a, int ij, int ji, int ii, int jj, std::vector<int[]> &ValuableSelfSupported);
		bool ExistValuble(int Table[], std::vector<int[]> &ValuableSelfSupported);
		bool MaxObjecvts(std::vector<int> &Obj, int Max);
		//When Current Movment Take Supporte.QC_OK
		bool IsCurrentMoveTakeSupporte(int Table[][], int Order, int a, int i, int j, int ii, int jj);
		///Huristic of King safty.
		double HeuristicKingSafety(int Tab[][], int Order, int a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD);
		double HeuristicKingDangourous(int Tab[][], int Order, int a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD);
		//Huristic of Supportation.
		double HuristicSelfSupported(int Tab[][], int Ord, int aa, int RowS, int ColS, int RowD, int ColD);
	public:
		static bool TableEqual(int Tab1[][], int Tab2[][]);
		//If tow int Objects is equal.
		static bool TableEqual(int Tab1, int Tab2);
		//Deterimination of Existance of Table in List..
		static bool ExistTableInList(int Tab[][], std::vector<int[][]> &List, int Index);
		///Move Determination.
		bool Movable(int Tab[][], int i, int j, int ii, int jj, int a, int Order);
		//
		//When Oredrs of OrderPalte and Calculation Order is not equal return negative one and else return one.
	private:
		double SignOrderToPlate(int Order);
		//Remove Penalties of Unnesserily Nodes.
	public:
		bool RemovePenalty(int Tab[][], int Order, int i, int j);
		//Dangouring of current movment fo current Order.
	private:
		bool IsCurrentStateIsDangreousForCurrentOrder(int Tabl[][], int Order, int a, int ii, int jj);

		//When Next Movements is Checked.QC_OK.
		int *IsNextMovmentIsCheckOrCheckMateForCurrentMovmentBaseKernel(int Order, int Tabl[][], int ik, int jk, int iki, int jki, int OrderPalte, int OrderPalteMulMinuse, int Depth, bool KindCheckedSelf);
		//When Next Movements is Checked.QC_OK.
		bool IsNextMovmentIsCheckOrCheckMateForCurrentMovmentOnCurrentMovemnet(int Order, int Tabl[][], int ik, int jk, int iki, int jki, int OrderPalte);
		int *IsNextMovmentIsCheckOrCheckMateForCurrentMovment(int Tabl[][], int Order, int a, int Depth, int OrderPalte, int OrderPalteMinusPluse, bool KindCheckedSelf);
		//When Current Movements is in dangrous and is not movable.
		bool IsGardForCurrentMovmentsAndIsNotMovable(int Tab[][], int Order, int a, int ii, int jj, int RowS, int ColS);

		///when current movments gards enemy with higer priority at movment.QC_OK
		bool IsCurrentCanGardHighPriorityEnemy(int Depth, int Table[][], int Order, int a, int ij, int ji, int iij, int jji, int OrderPlate);
		///Huristic of Check and CheckMate.
	public:
		double HuristicCheckAndCheckMate(int Table[][], int a);
		//Veryfy and detect Object Value.
	private:
		int VeryFye(int Table[][], int Order, int a);
		//QC_OK
		//Numbers of Supporting Current Objects method.
		int SupporterCount(int Table[][], int Order, int a, int ii, int jj);
		//Attacks on Enemies.
		int AttackerCount(int Table[][], int Order, int a, int i, int j);
		//Attackers of Enemies.QC_OK.
		int EnemyAttackerCount(int Table[][], int Order, int a, int ii, int jj);
		//Distance of Enemy Kings from Current Object.
	public:
		double HeuristicDistabceOfCurrentMoveFromEnemyKing(int Tab[][], int Order, int RowS, int ColS);
		double HuristicSoldierFromCenter(int Table[][], int aa, int Ord, int ii, int jj, int i, int j);
		double *HuristicAll(bool Before, int Killed, int Table[][], int aa, int Ord, int RowS, int ColS, int RowD, int ColD);
		///Huristic of Movments.
		double HuristicMovment(bool Before, int Table[][], int aa, int Ord, int RowS, int ColS, int RowD, int ColD);
		///Attack Determination.QC_Ok
		bool Attack(int Tab[][], int i, int j, int ii, int jj, int a, int Order);
		//Object Danger Determination.
		bool ObjectDanger(int Tab[][], int i, int j, int ii, int jj, int a, int Order);
		///Supportation Determination.QC_OK
		bool Support(int Tab[][], int i, int j, int ii, int jj, int a, int Order);
		//Return Msx Huiristic of Child Level.
		bool MaxHuristic(int &j, int Kin, double &Less, int Order);
		//Setting Numbers of Objects in Current Table boards.
		//Count of Solders on Table.
	private:
		int SolderOnTableCount(DrawSoldier So[], bool Mi, int MaxCount);
		//Elepahnt On Table Count.
		int ElefantOnTableCount(DrawElefant So[], bool Mi, int MaxCount);
		//Calculate Hourse on table.
		int HourseOnTableCount(DrawHourse So[], bool Mi, int MaxCount);
		//Calculate Castles Count.
		int CastleOnTableCount(DrawCastle So[], bool Mi, int MaxCount);
		//Calculate Minsiter Count.
		int MinisterOnTableCount(DrawMinister So[], bool Mi, int MaxCount);
		//Calculate King on Table.
		int KingOnTableCount(DrawKing So[], bool Mi, int MaxCount);
		//Return Huristic.
	public:
		double ReturnHuristic(int ii, int j, int Order, bool AA);
	private:
		std::wstring Alphabet(int RowRealesed);
		std::wstring Number(int ColumnRealeased);

	public:
		double ReturnHuristicCalculartor(int iAstarGready, int ii, int j, int Order);
		//Scope of Every Objects Movments.
	private:
		bool Scop(int i, int j, int ii, int jj, int Kind);
		//Calculate Maximum of Six Max Huristic of Six Kind Objects.
		int MaxOfSixHuristic(double Less[]);
		//Calculate Minimum of Six Min Huristic of Six Kind Objects.note the enemy Huristic are negative.
		int MinOfSixHuristic(double Less[]);


		void KingThinkingQuantumChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		std::wstring CheM(int A);

		void MinisterThinkingQuantumChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		bool IsPrviousMovemntIsDangrousForCurrent(int TableS[][], int Order);
		//When There is not valuable Object in List Greater than Target Self Object return true.        
		bool IsObjectValaubleObjectSelf(int i, int j, int Object, std::vector<int[]> &ValuableSelfSupported);
		bool IsObjectValaubleObjectEnemy(int i, int j, int Object, std::vector<int[]> &ValuableEnemyNotSupported);
		bool *SomeLearningVarsCalculator(int TableS[][], int ik, int jk, int iik, int jjk);
		bool *CalculateLearningVars(int Killed, int TableS[][], int i, int j, int ii, int jj);
		void CastlesThinkingQuantumChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void HourseThinkingQuantumChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void ElephantThinkingQuantumChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		bool EqualitTow(bool PenRegStrore, int kind);
		bool EqualitOne(QuantumAtamata *Current, int kind);
		void AddAtList(int kind, QuantumAtamata *Current);
		void RemoveAtList(int kind);
		bool PenaltyMechanisam(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int &CheckedM, int Killed, bool Before, int kind, int TableS[][], int ii, int jj, QuantumAtamata *&Current, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int i, int j, bool Castle);
		void SolderThinkingQuantumChess(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
		void CastleThinkingQuantumBrown(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);


	public:
		void CalculateHuristics(bool Before, int Killed, int TableS[][], int RowS, int ColS, int RowD, int ColD, int color, double &HuristicAttackValue, double &HuristicMovementValue, double &HuristicSelfSupportedValue, double &HuristicObjectDangourCheckMateValue, double &HuristicKillerValue, double &HuristicReducedAttackValue, double &HeuristicDistabceOfCurrentMoveFromEnemyKingValue, double &HeuristicKingSafe, double &HeuristicFromCenter, double &HeuristicKingDangour);
	private:
		void CastleThinkingQuantumGray(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int TableS[][], int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle);
	public:
		void HuristicPenaltyValuePerform(QuantumAtamata *Current, int Order, double &HuristicAttackValue, bool AllDrawClass = false);
		void ThinkingQuantumSoldierBase(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumSoldier(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumElephantBase(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);

		void ThinkingQuantumElephant(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseOne(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseTwo(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseThree(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseFour(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseFive(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseSix(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseSeven(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumHourseEight(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);


		void ThinkingQuantumHourse(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumCastleOne(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumCastleTow(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumCastle(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumMinisterBase(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumMinister(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumCastleGray(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumCastleBrown(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		void ThinkingQuantumKing(int &LoseOcuuredatChiled, int &WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle);
		///Kernel of ThinkingQuantum
		void ThinkingQuantum(int &LoseOcuuredatChiled, int &WinOcuuredatChiled);
	private:
		double RetrunValValue(int RowS, int ColS, int RowO, int ColO, int Tab[][], int Sign);

		double ObjectValueCalculator(int Table[][], int RowS, int ColS, int RowO, int ColumnO); //, int Order
		double ObjectValueCalculator(int Table[][], int RowS, int ColS); //, int Order
		bool SignSelfEmpty(int Obj1, int Obj2, int Order, int &Ord, int &A);
		bool SignEnemyEmpty(int Obj1, int Obj2, int Order, int &Ord, int &A);
		bool SignNotEqualEnemy(int Obj1, int Obj2, int Order, int &Ord, int &A);
		bool SignEqualSelf(int Obj1, int Obj2, int Order, int &Ord, int &A);
		bool SignNotEqualSelf(int Obj1, int Obj2, int Order, int &Ord, int &A);

	};
}

//End of Documentation.
