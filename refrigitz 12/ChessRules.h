#pragma once
#include "stdafx.h"
#include <string>
#include <vector>
#include <cmath>
#include <float.h>
#include <stdexcept>
#include "StringConverterHelper.h"
//#include "stdafx.h"
/***********************************************************************************
 * Every Ruls of objective condition of chess game.*********************************
 * Current Rules Have not Attack Movement***x*************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Ramin Edjlal********************************************************************
 * Current Rules Have Not 'Check' And 'CheckMate' *************************************R***x**0.12**4**Managements and Cuation Programing**(+*)QC-OK.
 * Elephant Rules Hardly*********************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Horse Rules Hardly************************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Minister Rules Hardly*********************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * King Rules Hardly*************************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Castles Rules Hardly**********************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Restricted has been solved****************************************************--**(-)
 * No movements greater than one. Some Abnormal Movement***x*********************R***x**0.12**4**Managements and Cuation Programing**(++)
 * Abnormal Movements Correction*************************************************--**(-)
 * Clear Dirty Part**************************************************************--**(-)
 * Chess Rules Soldier Not Moved Jump From Enemy to 2****************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Chess Rules Abnormally Minister Gray Elephant to Right************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Chess Rules Elephant Normally*************************************************--**(-)
 * Abnormally Recursive Method***************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Chess Rule Check CheckMate Doesn’t Work*********************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Clicking 'Table' Content Has been Abnormally**********************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * The Mechanism of Check Declared and Act 'Not' Logically************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * The Mechanism of Table Assignments and the Virtualization Misleading**********R***x**0.12**4**Managements and Cuation Programing**(+)
 * The Movements of horse Brown 'Alice' Left Side Cause to Mislead***************R***x**0.12**4**Managements and Cuation Programing**(+)
 * ExistInDestinationEnemy Thinking Misleading Operation***x*********************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Null Thinking Exception Handling Should be Configured*************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Malfunction of Mouse 'Bob' Event Handling For Movement***x********************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Non 'Check' Second Rules 'Alice' Move to 'Check' State**************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * 'CheckMate' Not Recognized By 'Alice'.*********************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * 'Check' Recognized From 'Hard' Game. CheckMate Have Not Been Identified.************RSPB(+*)
 * Chess Rules MalFunctional*****************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Unsatisfied CheckMate By 'Bob' With 'Alice'****************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Removable 'Check' by 'Bob' Was Not done by 'Alice' ****************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Unknown 'CheckRemovable' and Unknown 'Check' Mechanism**************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Table Content at 'Bob' 'Check' of 'Alice', Malfunction with 'horse'************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Can Hit 'King'****************************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Gone to 'Check' State Deterministic********************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * King Killer. Gone to ObjectDanger State by 'Alice' and 'Bob'***********************RSRS(++)
 * King Killer By 'Alice' and Gone to ObjectDanger Remaining**************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Killer Check Solved by Changing Strategy. Check by 'Alice' Cannot Been Removed.R***x**0.12**4**Managements and Cuation Programing**(-+)
 * Castle King Mechanism Failed**************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Arguments IgonoreTowEnemy Between King and Attaker in Check ObjectDanger Misleading**R***x**0.12**4**Managements and Cuation Programing**(+)
 * 'Check' Ignore. Un Rulement 'Bob Movement***x**********************************RSRS(++)
 * Unidentified 'Bob' Minister Movements in Check and Unrulements Movement***x****R***x**0.12**4**Managements and Cuation Programing**(+)
 * Tow King Beside Them**********************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * King of 'Bob' Gone to ObjectDanger.*************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Gone to Check by 'Bob'*********************************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Chess Order and Chess Check by Bob Malfunctioned*******************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * 'CheckMate' of 'Alice' Ended by Moving of 'Bob' King Unrulment***x*****************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Movements of 'Alice' Soldier to Backward.*************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * BrigdeKing Movements in Large Castle King Misleading**************************R***x**0.12**4**Managements and Cuation Programing**(_)
 * Syntax Statements Failed By Halting.******************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Check Of Bob Misleading no reason.*********************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Syntax Error At Genetic Algorithm By Bob.*************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * 1394/12/20********************************************************************R***x**0.12**4**Managements and Cuation Programing**(+:Sum(48)) (_ :Sum(1)) (-:Sum(5)) (*:Sum(2))
 * Chess Syntax MalFunction.*****************************************************R***x**0.12**4**Managements and Cuation Programing**[+]
 * Chess Rules Non Soldier Colud Not been Detected. For (CastleThinking.) Fist Algorithm.*****R***x**0.12**4**Managements and Cuation Programing**{+}
 * 'Check' Released isolatly.'Check' of Brown (Alice) No Matched Realesed.*********R***x**0.12**4**Managements and Cuation Programing**<+>
 * 'Check' Not Detected By Bob.***************************************************R***x**0.12**4**Managements and Cuation Programing**<+>
 * Bob Cloud not Remove 'Check'.**************************************************R***x**0.12**4**Managements and Cuation Programing**<+>
 * Bob Colud not Move.No Check asnd CheckMate.*****************************************R***x**0.12**4**Managements and Cuation Programing**<+>
 * Kings Have been Realeased Attacked.By Alice and Bob.**************************R***x**0.12**4**Managements and Cuation Programing**<+>
 * ObjectDanger kings Not work!********************************************************CU*****0.88**1**Risk Control************************<*>QC-OK.
 * Chess Rules of Movments (CastleThinking.) First caused to Databse MalFunction.*************CU*****0.88**1**Risk Control************************(*)QC-OK.
 * Mal Function of Table.Table zero.!********************************************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Timer of Bob and Alice do not works!******************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
 * Not Right of Penalty Regard Mechansim.Misleading of Operations.***************R***x**0.12**4**Managements and Cuation Programing**(+)
 * Reveal From CheckMate By Alice MalFunction.****************************************R***x**0.12**4**Managements and Cuation Programing**{+}
 * CheckMate Not Work On Statistic and More By Alice.*********************************R***x**0.12**4**Managements and Cuation Programing**{+}
 * CheckMate Operation By Alice is MalFunction.***************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
 * 'Minister' Alice Have been Check unreasonably.*********************************CU*****0.88**1**Risk Control************************(*)QC-OK.
 * 'Alice' Supposed Wrongly CheckObjectDangour Means Check.*******************************CU*****0.88**1**Risk Control************************(*)QC-OK.
 * Illegal King Foundation in Rules Function No Reasonaly.***********************R***x**0.12**4**Managements and Cuation Programing**<+>
 * Brown (Alice) King Dosn't exist.**********************************************R***x**0.12**4**Managements and Cuation Programing**<+>
 * Mal Function of Castles King User Determination.******************************CU*****0.88**1**Risk Control************************{*}QC-OK
 * Mal Function of Check int Detection at ObjectDangouring.****************************CU*****0.88**1**Risk Control************************<*>QC_OK
 * Assignment of Check State at ObjectDangourCheckRemove Method Not Occured.**************CU*****0.88**1**Risk Control************************<*>QC_OK.
 * Table Incredible Content Leads to Undisirable Result in Check and ....*********R**x0.12**4**Managements and Cuation Programing*****(+)
 * CheckedMate Complexity Over Numbers Of Cores Compexity.************************CU*****0.88**1**Risk Control************************{*}QC-OK.
 * Alice Castles King Statistic is misleading.************************************.CU*****0.88**1**Risk Control************************{*}Qc_OK
 * Sodiers of Alice get to go backward and non Existining Enemy of Killer sometimes.CU*****0.88**1**Risk Control************************{*}Qc_Bad.
 * Pat Mechanisam Dosn't act Misleading.*********************************************.CU*****0.88**1**Risk Control************************{*}QC_OK.
 * ************************************************************************************************************************************(+):Sum(1)) 4:(+:Sum(5)) 5.(*:Sum(1)) 6.(+:Sum(2)) (*:Sum(2)) 7.(+:Sum(2)) 8.(*:Sum(3)) 9.(QC-OK.:Sum(7))
 * ********************************************************************************
 */
//namespace RefrigtzDLL
//{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class ChessRules
	class ChessRules
	{
	public:
		bool IgnoreSelfObject;
		static int ObjectHittedRow;
		static bool SelfHomeStatCP;
		static int ObjectHittedColumn;
		//Inititae Global Variables.
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
	public:
		static int NumbersofKingMovesToPatGray;
		static int NumbersofKingMovesToPatBrown;
	public:
		static bool PatCheckedInKingRule;
		static bool CastleKingAllowedGray;
		static bool CastleKingAllowedBrown;
		static bool KingAttacker;
		static bool SmallKingCastleBrown;
		static bool KingCastleBrown;
		static bool SmallKingCastleGray;
		static bool KingCastleGray;
		static bool BigKingCastleBrown;
		static bool BigKingCastleGray;
		static bool CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporter;
		static int CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber;
		static bool CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing;
		bool CheckGrayObjectDangour;
		bool CheckBrownObjectDangour;
		static bool CheckGrayObjectDangourFirstTimesOcured;
		static bool CheckBrownObjectDangourFirstTimesOcured;
		static bool CastleActGray;
		static bool CastleActBrown;
		static int CurrentOrder;
		bool PatkGray;
		bool PatBrown;
		bool CheckGray;
		bool CheckBrown;
		bool CheckMateGray;
		bool CheckMateBrown;
		static bool CheckGrayRemovable;
		static bool CheckBrownRemovable;
		static int CheckGrayRemovableValueRowi;
		static int CheckGrayRemovableValueColumni;
		static int CheckGrayRemovableValueRowii;
		static int CheckGrayRemovableValueColumnjj;
		static int CheckBrownRemovableValueRowi;
		static int CheckBrownRemovableValueColumnj;
		static int CheckBrownRemovableValueRowii;
		static int CheckBrownRemovableValueColumnjj;
	public:
		int Kind;
		int KindNA;
		int Row, Column;
		int **Table;
		int Order;
		//public bool ExistInDestinationEnemy = false;
		bool ArrangmentsBoard;
		int CurrentAStarGredyMax;
		//static void Log(std::exception ex);
	public:
		ChessRules(int CurrentAStarGredy, int oRDER, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged);
		//Constructor 
		ChessRules(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int Ki, int **A, int Ord, int i, int j);
		//Initiate of Rules of Chess Refregitz.
		bool Rules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, int color, int Ki, bool SelfHomeStatCP=true); //Current Kind..int..The Destination Click Column.The Destination Click Row.The First Click Column..The First Click Row
		//Castle King Movment Consideration.
		bool CastleKing(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, int Ki);
		//Simulation and Consdtruction of Check.
		bool CheckConstructor(int color, int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, int Ki, int Order);
		//Method of Self Home int Objects Consideration.
	public:
		bool ObjectDangourKingMove(int Order, int **Table);

		bool ArrayInList(std::vector<int> *List, int *A);

		bool ExistSelfHome(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, int Ki);

		//Object Danger Consideration
	public:
		bool ObjectDangourKingMove(int Order, int **Table, bool DoIgnore);
		//bool ObjectDangourKingMove(int Order, int **Table);
	public:
		bool AchmazCheckByMoveByRule(int **Tabl, int RowF, int ColumnF, int RowS, int ColumnS, int Order);
	public:
		bool ObjectDangourKingMove(int Order, int **Table, bool DoIgnore, int ii, int jj);
		//Gray King Founder.
		bool FindGrayKing(int **Table, int Row, int Column);
		//Alpahber Object Consideration.
	public:
		static std::wstring ThingsAlphabet(int i);
		//Row Alphabet Consideration.
		static std::wstring RowAlphabet(int i);
		//Create Syntax of Movments.
	public:
		std::wstring CreateStatistic(bool Arrange, int **Tab, int Movments, int SourceThings, int Column, int Row, bool Hit, int HitThings, bool CastleKing, bool SodierConvert);
		
		//Consideration of Existing Table in List.
	public:
		
		//Find a Specific Objects.
	public:
		bool FindAThing(int **Table, int Row, int Column, int Thing, bool BeMovable, std::vector<int> *List);
		//Brown King Found  Consideration.
		bool FindBrownKing(int **Table, int Row, int Column);
		//A Constraint Check Removed Unused Method.
		bool CheckRemovableByAttack(int **Table, int Order);
	public:
		bool **VeryFye(int **Table, int Order, int a, int ii, int jj);
	public:
		bool OnlyKingMovable(int **Tab, bool TabB[8][8], int Order);
		bool Pat(int **Tab, int Order, int a);
	public:
		void CheckKing(int **Table, int Order, int RowK, int ColumnK);
		//Check Consideration Method.
	public:
		bool Check(int **Table, int Ord);
	public:
		void CheckMateKing(int **Tab, int Ord, bool CheckGrayDummy, bool CheckBrownDummy, int RowK, int ColumnK, bool ActMove, bool Checked);
		void CheckMateNotKing(int **Tab, int Ord, bool CheckGrayDummy, bool CheckBrownDummy, bool ActMove);
		//CheckMate Consideration.QC-OK
	public:
		bool CheckMate(int **Tab, int Ord);
		//Internal Rule of Chess Method.
	public:
		bool Rule(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki, bool SelfHomeStatCP);
		//King Rule Method.
	public:
		bool KingRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki);
		//Rules of Minister Method.
		bool MinisterRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki);
		//Castles Rule Method.
		bool CastleRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki);
		//Elephant Rule Method.
		bool ElefantRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy, int Ki);
		//Hource Rule Method.
		bool HourseRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy);
		bool SoldierRulesaArrangmentsBoardOne(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy);
		bool SoldierRulesaArrangmentsBoardZero(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy);
		//Solder Rule Method.
		bool SoldierRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, int color, bool ExistInDestinationEnemy);

	public:
		void InitializeInstanceFields();
	};
//}

//End of Documentation.
