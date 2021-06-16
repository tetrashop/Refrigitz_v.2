
#pragma once


#include "stdafx.h"
#include <string>
#include <vector>
#include <cmath>
#include <float.h>
#include <stdexcept>
/*
#include "DrawCastle.h"
#include "DrawHourse.h"
#include "DrawSoldire.h"
#include "DrawMinister.h"
#include "DrawElefant.h"
#include "DrawKing.h"
*/


class DrawSoldier;
class DrawElefant;
class DrawHourse;
class DrawCastle;
class DrawMinister;
class DrawKing;
class ThinkingChess;

using namespace std;


/*******************************************************************************************
 * Initiate and Decision making class.******************************************************
 * Ramin Edjlal*****************************************************************************
  * Call Of Constructor From Constructor***************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * The Storing AllDraw Object in Self Constructor Caused Stack Overflow*******************0.12**4**Managements and Cuation Programing**********************(+)
 * Link List Of Storing String Caused A Stack Over Flow***********************************0.12**4**Managements and Cuation Programing**********************(+)
 * Wait For Finished Current AStarGreedy Caused To Long Time*************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Need To Heuristic (Arvin) Function(s) to Manage Cell in Form1**************************0.12**4**Managements and Cuation Programing**********************(+)
 * First Scanning Movements of Things Anomaly*********************************************0.12**4**Managements and Cuation Programing**********************(+)
 * In Current Version of Heuristic Table Doesn’t Reached(Zero)****************************0.12**4**Managements and Cuation Programing**********************(+)
 * In Current Version InitiateForEveryThisngsHome Dosn't Work*****************************0.12**4**Managements and Cuation Programing**********************(+)
 * In This Version Thinking Taking A LotofTime(AStarGreedyt Array Tree)**********************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Work In AStarGreedys. But Scanning Dosen’t Works************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Adding Clone Caused To Stack Overflow**************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Clone Caused To StackOverFlow**********************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Row And Column Become Zero in Virtualization*******************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Initiate Error*************************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Seems To Be Logical Drawing ***********************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * int Suddenly Changing****************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * AllDraw Object Sub Objects List When Return from local Scope Become Zero.**************0.12**4**Managements and Cuation Programing**********************(+)
 * Huristic Dosn't Work*******************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * int Order Of Visualization Changed Suddenly******************************************0.12**4**Managements and Cuation Programing**********************(+)
 * int Changes with no movement*********************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Table Not Gate (Inversion of Table List) Doesn’t help to do Normally*******************0.12**4**Managements and Cuation Programing**********************(+)
 * Literally Errors Correction************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * From Arrangements of Things Reaches Suddenly Things Location OccuRS********************0.12**4**Managements and Cuation Programing**********************(+)
 * The Arrangements is Logical************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * The int changes and the arrangements changes are not clearly obvious*****************0.12**4**Managements and Cuation Programing**********************(+)
 * int Changes Solved. no movements*****************************************************0.12**4**Managements and Cuation Programing**********************(+)(-+)
 * Things movements Anomally**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Chess Rules Anomally*******************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Function Not Work************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Work But the Table is Empty**************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Table is Not Empty But the Movement is Not Logical*************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Clear Dirty Part.**********************************************************************0.88**1**Risk Control********************************************(*)QC-OK.
 * Need to Restricted Approval. Taking a lot of time Thinking Computation*****************0.12**4**Managements and Cuation Programing**********************(+)
 * No movements In Virtualization*********************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Chess Rules Abnormal thinking movements. No movement greater than 2********************0.12**4**Managements and Cuation Programing**********************(+)
 * Problem For Drawing of Thinking Things*************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Constant Result**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * One movements Right .Heuristic Remaining Constant Results******************************0.12**4**Managements and Cuation Programing**********************(+)
 * Constant Heuristic Result**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Need To Add A Heuristic Useful Another*************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Function Does’ Work Allis suddenly Become Zero that Previously Working*******0.12**4**Managements and Cuation Programing**********************(+)
 * No Movement Greater than one order in Computer 'Alice'*********************************0.12**4**Managements and Cuation Programing**********************(+)
 * Tow movements in Computer 'Alice' Of two Different Order int*************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Not Work Greater than 3 Length Count of A************************************0.12**4**Managements and Cuation Programing**********************(+)
 * 'They Don't Really Take care about us'. Misleading in Heuristic King Supported*********0.12**4**Managements and Cuation Programing**********************(+)
 * Non Order Movments*********************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Misleading at Stage three. no illegal movement greater than three**********************0.12**4**Managements and Cuation Programing**********************(+)
 * Thinking Order Misleading**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Hit Mechanism Malfunctional************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Tow movements At One 'Alice' Order time************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Computer By Computer 'Alice' by 'Bob' Caused to Loop Heuristic.**************0.12**4**Managements and Cuation Programing**********************(+)
 * Learning //automata of Quantum also leads to re loop heuristic***************************0.88**1**Risk Control********************************************(*)QC-OK.
 * Heuristic Learning //automata 'Alice' By 'Bob' Leads to Re loop**************************0.12**4**Managements and Cuation Programing**********************(+)
 * Heuristic Things Loop 'Alice' By 'Bob'*************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Self 'Check' Detection Failure By 'Alice'***********************************************0.12**4**Managements and Cuation Programing**********************(+)
 * 'Penalty' Value Of All Become zero althouth the one should be non Penalty**************0.88**1**Risk Control********************************************(*)
 * Clone Dosn't Copy All Content of AllDraw Dummy*****************************************0.12**4**Managements and Cuation Programing**********************(+)
 * CheckRemovable By Self King Solved.Penalty Action Misleading****************************0.88**1**Risk Control********************************************(-*)QC-OK.
 * 'Check' Detection Failure***************************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Mechanisam Of Order in Predict Failed.*************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * 'Alice' King Virtualization or Table Content of King Misleading************************0.12**4**Managements and Cuation Programing**********************(+)
 * With The All Things Huristic Signing Mechnisam Some Movments become null Table.********0.12**4**Managements and Cuation Programing**********************(+)
 * AStarGreedy First Search Not Working. Misleading MalFunction Virtualization.******************0.12**4**Managements and Cuation Programing**********************(+)
 * AStarGreedy First Table is Null at Bob Order.*************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * AStarGreedy First SetVirtualization and Table Misleading By Alice.****************************0.12**4**Managements and Cuation Programing**********************(+)
 * No Reason Logically For MalFunction  Refrigtz.Timer AStarGreedy First Dynamic Refrigtz.Timer.*******************0.12**4**Managements and Cuation Programing**********************(+)
 * AStarGreedyt Thinking Taking a lot of time.***********************************************0.12**4**Managements and Cuation Programing**********************([+]
 * AStarGreedy First Not Work.*******************************************************************0.12**4**Managements and Cuation Programing**********************[+]
 * AStarGreedy First Not Work.Refrigtz.Timer Stop At Greater than 2,3,4,5,6,7 Movments.*******************0.12**4**Managements and Cuation Programing**********************[+]
 * No Reason For MalFunction of AStarGreedytNotFoundHuristicAStarGreedyt.***********************0.12**4**Managements and Cuation Programing**********************[+]
 * Problem Solved.No Reason to NullExeption of AStarGreedytHuristic Algorithm.***************0.88**1**Risk Control********************************************[-*]QC-OK.
 * Function Evaluation Disabled .At Initiate AStarGreedytGenetic Found Sysntax.**************0.88**1**Risk Control********************************************[*]
 * Index Was Out Of Range Exeption Was Not Handled.Colud Not Be Handle.*******************0.12**4**Managements and Cuation Programing**********************{+}
 * No Logical Mechanism To Reconstructe Current AllDraw Objects.**************************0.12**4**Managements and Cuation Programing**********************{+}
 * AStarGreedy First Sysntax is legal and The Table is constant Table.***************************0.12**4**Managements and Cuation Programing**********************{+}
 * Table Content Empty. No Syntax Exist.**************************************************0.12**4**Managements and Cuation Programing**********************{+}
 * Game Begin From First When the Soldiers Move Ordinary Complete in AStarGreedy First***********0.88**1**Risk Control********************************************{*}QC-OK.
 * New Instatnt Of Program Cuase to Begin Fron First.*************************************0.12**4**Managements and Cuation Programing**********************<+>
 * No Logically Reason For New Game Of Program. New Instatnt Not Detected.****************0.12**4**Managements and Cuation Programing**********************<+>
 * Internal New Instatnt Of FormeRefregitz is MalFunction.********************************0.12**4**Managements and Cuation Programing**********************<+>
 * AStarGreedy First CC Changes to CC Normal Game.***********************************************0.12**4**Managements and Cuation Programing**********************<+>
 * Game CC UnContoroled.******************************************************************0.12**4**Managements and Cuation Programing**********************<+>
 * MalFunction of Syntax and Movments.By Alice and Bob.***********************************0.12**4**Managements and Cuation Programing**********************<+>
 * Threading Solved! The OutOfRangeIndex Not Work.****************************************0.12**4**Managements and Cuation Programing**********************[-+]
 * Vituallization error!No Best Matches between Truth of Table content and irtualization**0.12**4**Managements and Cuation Programing**********************[+]
 * Dynamic Programming for Stroring ADraw THISDummy Adraw Value MalFunction.**************0.12**4**Managements and Cuation Programing**********************(+)
 * Order is Constant in Dynamic Programming.**********************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Table MalFunction at Dynamic Programming.At Step 3.************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Some Movments are MalFuncational at Dynamic Programming.*******************************0.12**4**Managements and Cuation Programing**********************(+)
 * Huristic Overlay Tow Part of ADraw and StoreADraw Sections at Different levels Tab Cal.0.12**4**Managements and Cuation Programing**********************(+)
 * Not to be needing again calculation. MalFunction is depend of tow part.****************0.12**4**Managements and Cuation Programing**********************(+)
 * BackWard Loos of Things AllDraw Mechnisam.*********************************************0.88**1**Risk Control********************************************(*)QC-OK.
 * Some Dynamic Programming MalFunction Movments.*****************************************0.88**1**Risk Control********************************************(*)QC-OK.
 * Syntax and Forward and Backward Movments Syntax is MalFunction.************************0.12**4**Managements and Cuation Programing**********************<+>
 * Database and Virtualization Forward and Backward MalFunction***************************0.12**4**Managements and Cuation Programing**********************<+>
 * Reproduction of Thinfs Missleading.****************************************************0.88**1**Risk Control********************************************<*>QC-OK.
 * Reproduction of Some Things are MalFunction Movments.**********************************0.12**4**Managements and Cuation Programing**********************{+}
 * AStarGreedy Count of Dynamic Programming Misleadig.AStarGreedy Operation Count Mal Function.*********0.88**1**Risk Control********************************************(*)QC-OK.
 * Huristic By Alice is MalFunction.******************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * ObjectDanger Identification By Alice is MalFunction.*****************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Check Identification By Alice is MalFunction.*******************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Check Recognized But CheckMate Not Recognized!***********************************************0.12**4**Managements and Cuation Programing**********************(_+)
 * Penalty Regard Mechanism Misleading.***************************************************0.12**4**Managements and Cuation Programing**********************{+}
 * Inhereted LearningKrinskyAtamata Caused to Shared Parent Allocated Variable.******************0.12**4**Managements and Cuation Programing**********************{+}
 * 'Check' By 'Alice' Not Removed Unreasonably.********************************************0.88**1**Risk Control********************************************{*}QC-OK.
 * AStarGreedyt Huristic Found MalFunction at Check Alice.************************************0.12**4**Managements and Cuation Programing**********************{+}
 * Sortments of ADRAW and Construction is MalFunction at AStarGreedy Dynamic Programming.********0.12**4**Managements and Cuation Programing**********************{+}
 * Huristic AStarGreedy First were Worked Out Unreasonably such Situation(Golden Sword Magic).***0.88**1**Risk Control********************************************{*}QC-OK.
 * Converted 'King' of 'Alice' to 'Elephant' UnReasonably.********************************0.12**4**Managements and Cuation Programing**********************(+)
 * 'Long Game' ; But MalFunction of Game.*************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * 'Always' in Current game is 'Bob'.*****************************************************0.12**4**Managements and Cuation Programing**********************(+)
 * Current Table of ADRAW is Correct Table But the Game is MalFunction.*******************0.12**4**Managements and Cuation Programing**********************(+)
 * Move of Current Table AStarGreedy First Huristic found ;found an ovelay in 'Bob' and 'Alice'**0.12**4**Managements and Cuation Programing**********************(+)
 * Current Table in High Level Become Null and prevent of 'LongGame' Strategy.************0.12**4**Managements and Cuation Programing**********************(+)
 * 'LongGame' Become short Undetectably Unreasonably;Clear Store Non Detectably.**********0.88**1**Risk Control********************************************(*)QC-OK.
 * All Draw AStarGreedy First section some movments have not been accurred considerably.*********0.88**1**Risk Control********************************************(*)QC-OK.
 * 'Long Game' Breaks Suddendly without Monitor Caused.***********************************0.12**4**Managements and Cuation Programing**********************{+}
 * Overlay Some Movments of 'Long Game' Breaked.Caused Probability to break.**************0.12**4**Managements and Cuation Programing**********************{+}
 * SomeTimes All Situation of Current Games Become Cleared and No Table Founded.**********0.12**4**Managements and Cuation Programing**********************{+}
 * Gray Soldeir is Only Movmnets and Converts in Huristic and No Move are detectable.*****0.12**4**Managements and Cuation Programing**********************{+}
 * DEEPLY Recursive Tree of Second Version Become in Some Null At Hurristic Finsished.****0.12**4**Managements and Cuation Programing**********************{+}
 * AStarGreedy Huristic Content is Zero. No Calculation of AStarGreedy Huristic Calculation.************0.12**4**Managements and Cuation Programing**********************{+}
 * MalFunction of Dep Huristic Person and MalFunction Movments of CC AStarGreedy Huristic********0.88**1**Risk Control********************************************{*}QC-OK.
 * Mal Function of Reconstruction of AStarGreedy Objects In Initiate AStarGreedy First.*****************0.12**4**Managements and Cuation Programing**********************<+>
 * Hurisic Operantional Have Mal Function Behaviour.**************************************0.12**4**Managements and Cuation Programing**********************<+>
 * Table Zero of AStarGreedy First Huristic Mal Function.****************************************0.12**4**Managements and Cuation Programing**********************<+>
 * AStarGreedy First Initiate Method Result Object Content Mal Function.*************************0.12**4**Managements and Cuation Programing**********************<+>
 * Table Nopt Found Of AStarGreedy First Huristic.Mal Function of Initiate and Huristic.*********0.12**4**Managements and Cuation Programing**********************<+>
 * Table Foundation Successfule. Traversaling of All Tree Not Successfule.****************0.12**4**Managements and Cuation Programing**********************<+>
 * Table Some Movments Intiaiazation Mal Function.****************************************0.12**4**Managements and Cuation Programing**********************{+}
 * BackWard Max Check CheckMate Mechanism For Best Huristic is Unknown**************************0.12**4**Managements and Cuation Programing**********************{+}
 * Minister After Calculation AStarGreedyHuristic At AStarGreedyHuristic becomes Null.******************0.88**1**Risk Control********************************************(*)QC-OK
 * All Objects Possible Movments Not calculating During AStarGreedytSerach Method.***********0.88**1**Risk Control********************************************{*}QC_OK
 * Mechanisam olf AStarGreedytHuristic and Hurisistic is QC-Ok. But Table foundation Illegal.0.88**1**Risk Control********************************************<*>QC-OK
 * Full Game Indexing Parameters Misleading UnLogically.*************************************0.88**1**Risk Control********************************************(*)QC_OK
 * Index out of Range Unlogically at Full Game Soldier Order Brown.**************************0.88**1**Risk Control********************************************<*>QC_OK
 * Execution make zero Table but trace make valid Table.*************************************0.88**1**Risk Control********************************************{*}Qc-OK.
 * Virtualization need to more hardware capabilities gone to malfunction virtualization.******0.88**1**Risk Control*******************************************{*}QC-BAD.
 * MalFunction on AllDraw Hadeling of Draw Midle Target Motion Graphics.**********************0.88**1**Risk Control*******************************************{*}QC-BAD.
 * ********************************************************************************************************************************************************(+:Sum(63)) 
 * 1394/12/19**********************************************************************************************************************************************(*:Sum(4))
 * ********************************************************************************************************************************************************(-:sum(2)) (_:Sum(0)):2:(+:Sum(3)) (-:Sum(1)) (*:Sum(2)) 3: (+:Sum(4)) (*:Sum(1)) 4:(+:Sum(6))  5:(+:Sum(2)) (-:Sum(1)) 6:(+:Sum(6)) (*:Sum(2)) 7.(+:Sum(2)) (*:Sum(1)) 8.(+:Sum(1)) 9.(+:Sum(4)) (*:Sum(1)) (-:Sum(1)) 10.(+:Sum(4)) (*:Sum(2)) 11.(+:Sum(4)) 12.(+:Sum(2)) (*:Sum(2)) 13.(+:Sum(4)) 14.(+:Sum(2)) (*:Sum(1)) 15.(+:Sum(6)) 16.(+:Sum(2)) 17.(QC-OK.:Sum(13))
 */
namespace RefrigtzDLL
{

	//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
	//ORIGINAL LINE: [Serializable] public class AllDraw
	class AllDraw
	{

	public:
		int AStarGreedy;
		bool SetDeptIgnore;
		long long Now;
		long long Later;
		//		StackFrame *callStack;
		int **Tabl;
	public:
		int OrderP;
		static int DepthIterative;
	public:
		int PerceptionCount;
	public:
		std::wstring OutPutAction;
		static std::wstring OutPut;
		static std::wstring ActionString;
		static bool ActionStringReady;
		//static variable to be Initiate
	public:
		std::vector<int*> ValuableSelfSupported;
	public:
		std::vector<int**> MaxHuristicAStarGreedytBackWardTable;
		static bool RegardOccurred;
		static int SuppportCountStaticGray;
		static int SuppportCountStaticBrown;
	public:
		int CurrentAStarGredyMax;
	public:
		static int TaskBegin;
		static int TaskEnd;
		static std::wstring Root;
		static int OrderPlate;
		static bool Blitz;
		static int ConvertedKind;
		static bool ConvertWait;
		static bool Stockfish;
		static bool Person;
		static bool THISSecradioButtonGrayOrderChecked;
		static bool THISSecradioButtonBrownOrderChecked;
		static std::wstring THIScomboBoxMaxLevelText;
		static AllDraw THISDummy;
		static bool StateCP;
		static int LastRow;
		static int LastColumn;
		static int NextRow;
		static int NextColumn;
		static int MovmentsNumber;
		static int MaxAStarGreedyHuristicProgress;
		static bool EndOfGame;
		//Initiate Variables.        
	public:
		static  int ThresholdBlitz;
		static  int ThresholdFullGame;
	public:
		bool SetRowColumnFinished;
		static int MinThinkingTreeDepth;
	public:
		static int MaxDuringLevelThinkingCreation;
	public:
		double MaxHuristicxT;
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
	public:
		int *Index, *jindex, *Kind;
	public:
		bool ArrangmentsChanged;
		static double AStarGreedytMaxCount;
		static bool FoundATable;
		static double Less;
		bool CastlesKing;
	public:
		std::vector<int**> MaxHuristicAStarGreedytBackWarTable;
	public:
		static int increasedProgress;
		static double CurrentHuristic;
		static double SignAttack;
		static double SignObjectDangour;
		static double SignReducedAttacked;
		static double SignSupport;
		static double SignKiller;
		static double SignMovments;
		static double SignDistance;
		static double SignKingSafe;
		static double SignKingDangour;
		static bool DrawTable;
		static int **TableVeryfy;
		static int MaxAStarGreedy;
		static int **TableVeryfyConst;
		static std::vector<int**> TableCurrent;
		static bool NoTableFound;
		static bool DynamicAStarGreedytPrograming;
		static std::vector<AllDraw> StoreADraw;
		static std::vector<int> StoreADrawAStarGreedy;
		static bool UseDoubleTime;
		static int AStarGreedyiLevelMax;
		static bool AStarGreadyFirstSearch;
		static std::wstring ImageRoot;
		static std::wstring ImagesSubRoot;
		static bool RedrawTable;
		static std::wstring SyntaxToWrite;
		static bool SodierConversionOcuured;
		static int SodierMovments;
		static int ElefantMovments;
		static int HourseMovments;
		static int CastleMovments;
		static int MinisterMovments;
		static int KingMovments;
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
		//ChessPerdict APredict = null;
	public:
		int RW;
		int CL;
		int Ki;
		int RW1;
		int CL1;
		int Ki1;
		double MaxLess1;
		int RW2;
		int CL2;
		int Ki2;
		double MaxLess2;
		int RW3;
		int CL3;
		int Ki3;
		double MaxLess3;
		int RW4;
		int CL4;
		int Ki4;
		double MaxLess4;
		int RW5;
		int CL5;
		int Ki5;
		double MaxLess5;
		int RW6;
		int CL6;
		int Ki6;
		double MaxLess6;
	public:
		AllDraw *AStarGreedyString;
		static int LoopHuristicIndex;
	public:
		static std::vector<int> RWList;
		static std::vector<int> ClList;
		static std::vector<int> KiList;
	public:
		static std::vector<int**> TableListAction;
		int Move;
		static int MouseClick;
	public:

		/*
		template <class T, size_t N>
		struct Array {
		T data[N];

		T &operator*(size_t index) { return data[index]; }
		T &operator*(size_t index)  { return data[index]; }
		T *begin() { return &data[0]; }
		T *begin()  { return &data[0]; }
		T *end() { return &data[N]; }
		T *end()  { return &data[N]; }
		};*/
	public:
		static int MinThinkingDepth;
		int CurS;
		int RowS;
		int ColumS;
		std::vector<int**> TableList;
		int AStarGreedyInt;
		std::vector<DrawSoldier> SolderesOnTable;// [16];
		std::vector<DrawElefant> ElephantOnTable;// [4];
		std::vector<DrawHourse> HoursesOnTable;// [4];
		std::vector<DrawCastle> CastlesOnTable;// [4];
		std::vector<DrawMinister> MinisterOnTable;// [2];
		std::vector<DrawKing> KingOnTable; // [2];
										   /*std::vector<DrawSoldier> SolderesOnTable;
										   std::vector<DrawElefant> ElephantOnTable;
										   std::vector<DrawHourse> HoursesOnTable;
										   std::vector<DrawCastle> CastlesOnTable;
										   std::vector<DrawMinister> MinisterOnTable;
										   std::vector<DrawKing> KingOnTable;*/
										   /*DrawSoldier SolderesOnTable[16];
										   DrawElefant ElephantOnTable[4];
										   DrawHourse HoursesOnTable[4];
										   DrawCastle CastlesOnTable[4];
										   DrawMinister MinisterOnTable[2];
										   DrawKing KingOnTable[2];*/
	public:

		//static bool stopOnPonderhit;
		std::vector<double*> MaxHuristicAStarGreedytBackWard;
		static  int MaxSoldeirFounded;
		static  int MaxElephntFounded;
		static  int MaxHourseFounded;
		static  int MaxCastlesFounded;
		static  int MaxMinisterFounded;
		static  int MaxKingFounded;
	public:
		int *AStarGreedyIndex;// [20];
		//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
		//ORIGINAL LINE: [NonSerialized()] public Task ob;
		//Task *ob;
		//Making String datastructure to root variable
		AllDraw *StarGreedyString;
		std::wstring Number(int ColumnRealeased);
		int SumOfObjects(AllDraw A, int Order);
		int SumMinusOfObjects(AllDraw A, int Order);
		//Error Handling
	public:
		std::wstring Alphabet(int RowRealesed);
		static bool IsAQuantumeMoveOccured(bool IsQuantumMove);
	public:
		void SetObjectNumbers(int **TabS);
	public:
		float *FoundLocationOfObject(int **Tabl, int Kind, bool IsGray);
		//Constructor
	public:

		void MakePenaltyAllCheckMateBranches(AllDraw A, int Order);
		void FoundOfLeafDepenOfKind(int **Table, int Order, int iAStarGreedy, int ii, int jj, int ik, int jjj, bool FOUND, int LeafAStarGreedy);
		//bool IsToCheckMateHasLessDeeperThanForCheckMate(int Order, int ToCheckMate, int ForCheckMate, int AStarGreedyInt);
		std::vector<std::vector<double>> FoundOfBestMovments(int AStarGreedyInt, std::vector<double> i, std::vector<double> j, std::vector<double> k, AllDraw Dummy, int a, int Order);
		bool TableZero(int ** Ta);
		void CheckedMateConfiguratiionSoldier(int Order, int i, bool Regrad);
		void CheckedMateConfiguratiionElephant(int Order, int i, bool Regrad);
		void CheckedMateConfiguratiionHourse(int Order, int i, bool Regrad);
		//AllDraw CopyRemeiningItems(AllDraw ADummy, int Order);
		void CheckedMateConfiguratiion(int Order);
		void SemaphoreExxedTime(int time, int Kind);
		//int SumOfObjects(AllDraw A, int Order);
		bool IsEnemyThingsinStable(int** TableHuristic, int** TableAction, int Order);
		std::vector<int*> WhereNumbers(std::wstring Tag);
		std::wstring CreateHtmlTag(std::wstring Tag);
		void IsPenaltyRegardCheckMateAtBranch(int Order, int Do, AllDraw Base);
		AllDraw(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, int a, int** Tab, int Ord, bool TB, int Cur);
		AllDraw(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments);
		//Clone Copy Method
		//void Clone(AllDraw& AA);
		//		int SumOfObjects(AllDraw A, int Order);
		//aBlanck Constructor		
		//AllDraw(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, AllDraw THi);



	
		//Check For Thinking Of Current Item Movments Finished.
		//void BlitzGameThinkingSolderGray(double PreviousLessS, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		//int** Initiate(int ii, int jj, int a, int** Table, int Order, bool TB, bool FOUND, int LeafAStarGreedy, bool SetDept = false);
		/*void SetQuantumRowColumn(int Kind, int Section)
		{
		if (Kind == 1)
		{
		if (Section == 1)
		{ }
		else
		{ }

		}
		else


		if (Kind == 2)
		{
		if (Section == 1)
		{ }
		else
		{ }

		}
		else
		if (Kind == 3)
		{
		if (Section == 1)
		{ }
		else
		{ }

		}
		else
		if (Kind == 4)
		{
		if (Section == 1)
		{ }
		else
		{ }

		}
		else
		if (Kind == 5)
		{
		if (Section == 1)
		{ }
		else
		{ }

		}
		else
		if (Kind == 6)
		{
		if (Section == 1)
		{ }
		else
		{ }

		}

		}*/
		//bool AllCurrentAStarGreedyIntThinkingFinished(AllDraw Dum, int i, int j, int Kind);
		//Rearrange AllDraw Object Content.
		void SetRowColumn(int index);
	public:
		bool KingDan(int** Tab, int Order);
		void SetRowColumnFinishedWait();
		void BeginIndexFoundingMaxLessofMaxList(int ListIndex, std::vector<double>& Founded, double & LessB);
		//Max Index List Of Huristic AStarGreedy First Method.
	public:



		bool TableEqual(int **t1, int **t2);
		//void FoundOfLeafDepenOfKindAllDraw(int **Table, int Order, int iAStarGreedy, int ii, int jj, int ik, int jjj, bool FOUND, int LeafAStarGreedy);
		//Method for Check of Existence of Checkmate less than for checked mate.
	public:
		//When Penalty Regard Branches expanded to sub branches.

	public:
		
		bool IsToCheckMateHasLessDeeperThanForCheckMate(int Order, int ToCheckMate, int ForCheckMate, int AStarGreedyInt);
		void RemovePenalltyFromFirstBranches(int Order);
		AllDraw FoundOfLeafDepenOfKind(int Kind, AllDraw Leaf, bool & Found, int Order, int  OrderLeaf);
		AllDraw FoundOfCurrentTableNode(int **Tab, int Order, AllDraw THIS, bool &Found);

		bool IsFoundOfLeafDepenOfKindhaveVictory(int Kind, bool &Found, int Order);
		void MakeRegardAllCheckMateBranches(AllDraw A, int Order);
		bool ReturnConsiderationOfPermitForValidationOfLearningInFullGameThinkingTree(int ik, int kind, bool Penalty, int j);
		void BlitzNotValidFullGameThinkingTreePartOne(int ik, int Order, int kind);
		void BlitzNotValidFullGameThinkingTreePartTow(int ik, int Order, int kind);
		void BlitzNotValidFullGameThinkingTreePartThree(int ik, int Order, int kind);
		void FullGameThinkingTreeInitialization(int ik, int j, int Order, int kind);
		void OpOfFullGameThinkingTree(int ik, int j, int Order, int iAStarGreedy, int ii, int jj, int a, int kind, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeSoldier(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeSoldierGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeElephant(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeElephantGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeHourse(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeHourseGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeCastle(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeCastleGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeMinister(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeMinisterGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeKing(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeKingGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeSoldierBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeElephantBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeHourseBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeCastleBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeMinisterBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingTreeKingBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		int** CloneATable(int** Tab);
		int MaxOfSixHuristic(double _1, double _2, double _3, double _4, double _5, double _6);
		int MinOfSixHuristic(double _1, double _2, double _3, double _4, double _5, double _6);
	public:

		void StringHuristics(int Obj, int Sec, bool AA, int Do, int WinOcuuredatChiled, int LoseOcuuredatChiled);
		void SaveLess(int i, int j, int k, int Kind, double & Less, bool AA, int Order);
		void SaveTableHuristic(int i, int j, int k, int Kind, int ** TableHuristic);
		void SaveBeginEndLocation(int i, int j, int k, int Kind);
		bool HuristicRegardSection(int i, int j, int k, bool & Act, int ** TableHuristic, bool & AA, int a, int Kind, int & Do, int AStarGreedyi, int Order);
		void InitiateVars(int i, int j, int k, int Kind);
		bool CheckeHuristci(int ** TableS, int Order, int i, int j, int k);
		void OutputHuristic(int Order);
		bool HuristicMainBody(int i, int j, int k, bool & Act, int ** TableHuristic, bool & CurrentTableHuristic, bool & AA, int a, int Kind, int & Do, int AStarGreedyi, int Order);
		int ** HuristicAStarGreadySearchSoldier(int ** TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchSoldierGray(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchSoldierBrown(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchElephantGray(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchElephantBrown(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchElephant(int ** TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchHourseGray(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchHourseBrown(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchHourse(int ** TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchCastleGray(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchCastleBrown(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchCastle(int ** TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchMinsisterGray(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchMinsisterBrown(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchMinsister(int ** TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchKingGray(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchKingBrown(int ** TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchKing(int ** TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchGray(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** HuristicAStarGreadySearchBrown(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
		int ** BrownHuristicAStarGreaedySearchPenalites(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool & Act);
	
	/*	int **HuristicAStarGreadySearchSoldierGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchSoldierBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchElephantGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchElephantBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchElephant(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchHourseGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchHourseBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchHourse(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchCastleGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchCastleBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchCastle(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchMinsisterGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchMinsisterBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchMinsister(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchKingGray(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchKingBrown(int **TableHuristic, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchKing(int **TableHuristic, int i, int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchGray(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
		int **HuristicAStarGreadySearchBrown(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic, bool Act);
*/
		//AStarGreedy First Huristic Method.
	public:
		void Clone(AllDraw AA);
	    //bool AllCurrentAStarGreedyThinkingFinished(AllDraw Dum, int i, int j, int Kind);
		//int** CloneATable(int** Tab);
		int **HuristicAStarGreedySearch(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic);
		//int **HuristicAStarGreedySearchPenalties(int AStarGreedyi, int a, int Order, bool CurrentTableHuristic);
		//Genethic Algorithm Game Method.
		//void InitiateGenetic(int ii, int jj, int a, int **Table, int Order, bool TB);
		
		//AStarGreedy First Initiat Thinking Main Method.
		void InitiateAStarGreedytOneNode(int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, int iIndex, int KindIndex, int LeafAStarGreedy);
		int** Initiate(int ii, int jj, int a, int** Table, int Order, bool TB, bool FOUND, int LeafAStarGreedy, bool SetDept);
		void FoundOfLeafDepenOfKindFullGame(int** table, int Order, int iAStarGreedy, int ii, int jj, int ik, int jjj, bool FOUND, int LeafAStarGreedy);
		//void StringHuristics(int Obj, int Sec, bool AA, int Do, int WinOcuuredatChiled, int LoseOcuuredatChiled);
	public:
		//int ** HuristicAStarGreedyIntSearch(int AStarGreedyInti, int a, int Order, bool CurrentTableHuristic);
		//void InitiateAStarGreedytObjectGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		int MaxGrayMidle();
		int MaxBrownHigh();
		int MinBrownMidle();
		void InitiateAStarGreedytObjectBrown(int iii, int jjj, int ** Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int ** Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		//void InitiateAStarGreedytObjectBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy); //,  Refrigtz.Timer timer,  Refrigtz.Timer Timerint,  double Less
		//int FoundTableIndex(std::vector<int**> *T, int TAab[8][8]);
		void Serve(int Order);
		int FoundTableIndex(std::vector<int**> T, int **TAab);
		//Parallel.ForEach(tH, items => Task.WaitAny(items));
		void ServeISSup(int Order, int Kind, int ii);
		void InitiateAStarGreedyt(int iAStarGreedy, int ii, int jj, int a, int** Tab, int Order, bool TB, int FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedytSodlerGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedytElephantGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythHourseGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythCastleGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythMinisterGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythKingGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythSoldierBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythElephantBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythHourseBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythCastleBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythMinisterBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedythKingBrown(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		//AlDraw InitiateAStarGreedyt(int Order, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int i, int j, int ii, int jj, int **Table, int a, bool TB, bool FOUND, int LeafAStarGreedy);

		bool FullBoundryConditions(int Current, int Order, int iAStarGreedy);
		void AStarGreedyThinking(int Order, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int i, int j, int ii, int jj, int ** Table, int a, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedytObjectGray(int iii, int jjj, int ** Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int ** Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void InitiateAStarGreedytObject(int iAStarGreedy, int ii, int jj, int a, int ** Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeSolderGray(double PreviousLessS, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeElephantGray(double PreviousLessE, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeCastleGray(double PreviousLessB, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeMinisterGray(double PreviousLessM, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeKingGray(double PreviousLessK, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingTreeSolder(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingSolder(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingElephant(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingHourse(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingCastle(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingMinister(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingKing(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingTreeElephant(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingTreeHourse(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingTreeCastle(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingTreeMinister(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameTreeCreationThinkingTreeKing(int a, int * Index, int * jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeSolderBrown(double PreviousLessS, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeElephantBrown(double PreviousLessE, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeHourseBrown(double PreviousLessH, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeCastleBrown(double PreviousLessB, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeMinisterBrown(double PreviousLessM, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeKingBrown(double PreviousLessK, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		bool ReturnFullGameThinkingTreeSemaphore(int ik, int kind);
		void BlitzGameThinkingTree(int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);
		void BlitzGameThinkingTreeHourseGray(double PreviousLessH, int* Index, int* jIndex, int Order, int iAStarGreedy, int ik, int j, bool FOUND, int LeafAStarGreedy);

		int  FullGameMakimgBlitz(int* Index, int* jIndex, int Order, int LeafAStarGreedy);
		bool FullGameThinkingTree(int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingSoldier(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingSoldierGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingSoldierBrowm(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingElephant(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingElephantGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingElephantBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingHourse(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingHourseGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingHourseBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingCastle(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingMinister(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingMinisterGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingKing(int ik, int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingSoldierBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingCastleBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingKingGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingCastleGray(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingMinisterBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		bool FullGameThinkingKingBrown(int a, int Order, int iAStarGreedy, int ii, int jj, int ik1, int j1, bool FOUND, int LeafAStarGreedy);
		//void FoundOfLeafDepenOfKind(int **Table, int Order, int iAStarGreedy, int ii, int jj, int ik, int jjj, bool FOUND, int LeafAStarGreedy);
		//void InitiateAStarGreedytObjectGray(int iii, int jjj, int **Table, int DummyOrder, int DummyCurrentOrder, int iAStarGreedy, int ii, int jj, int a, int **Tab, int Order, bool TB, bool FOUND, int LeafAStarGreedy);
	public:
		void InitializeInstanceFields();
		void CheckedMateConfiguratiionCastle(int Order, int ii, bool Regrad);
		void CheckedMateConfiguratiionMinister(int Order, int i, bool Regrad);
		void CheckedMateConfiguratiionking(int Order, int i, bool Regrad);



	};
	//End of Documentation.
}