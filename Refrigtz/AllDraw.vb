Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Imports System.Drawing
Imports System.Text
Imports System.Collections.Generic
Imports System
'******************************************************************************************
' * Initiate and Decision making class.******************************************************
' * Ramin Edjlal*****************************************************************************
' * Call Of Constructor From Constructor***************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * The Storing AllDraw Object in Self Constructor Caused Stack Overflow*******************0.12**4**Managements and Cuation Programing**********************(+)
' * Link List Of Storing String Caused A Stack Over Flow***********************************0.12**4**Managements and Cuation Programing**********************(+)
' * Wait For Finished Current Dept Caused To Long Time*************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Need To Heuristic (Arvin) Function(s) to Manage Cell in Form1**************************0.12**4**Managements and Cuation Programing**********************(+)
' * First Scanning Movements of Things Anomaly*********************************************0.12**4**Managements and Cuation Programing**********************(+)
' * In Current Version of Heuristic Table Doesn’t Reached(Zero)****************************0.12**4**Managements and Cuation Programing**********************(+)
' * In Current Version InitiateForEveryThisngsHome Dosn't Work*****************************0.12**4**Managements and Cuation Programing**********************(+)
' * In This Version Thinking Taking A LotofTime(DeptFirst Array Tree)**********************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Work In Depts. But Scanning Dosen’t Works************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Adding Clone Caused To Stack Overflow**************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Clone Caused To StackOverFlow**********************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Row And Column Become Zero in Virtualization*******************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Initiate Error*************************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Seems To Be Logical Drawing ***********************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Color Suddenly Changing****************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * AllDraw Object Sub Objects List When Return from local Scope Become Zero.**************0.12**4**Managements and Cuation Programing**********************(+)
' * Huristic Dosn't Work*******************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Color Order Of Visualization Changed Suddenly******************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Color Changes with no movement*********************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Table Not Gate (Inversion of Table List) Doesn’t help to do Normally*******************0.12**4**Managements and Cuation Programing**********************(+)
' * Literally Errors Correction************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * From Arrangements of Things Reaches Suddenly Things Location OccuRS********************0.12**4**Managements and Cuation Programing**********************(+)
' * The Arrangements is Logical************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * The Color changes and the arrangements changes are not clearly obvious*****************0.12**4**Managements and Cuation Programing**********************(+)
' * Color Changes Solved. no movements*****************************************************0.12**4**Managements and Cuation Programing**********************(+)(-+)
' * Things movements Anomally**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Chess Rules Anomally*******************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Function Not Work************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Work But the Table is Empty**************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Table is Not Empty But the Movement is Not Logical*************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Clear Dirty Part.**********************************************************************0.88**1**Risk Control********************************************(*)QC-OK.
' * Need to Restricted Approval. Taking a lot of time Thinking Computation*****************0.12**4**Managements and Cuation Programing**********************(+)
' * No movements In Virtualization*********************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Chess Rules Abnormal thinking movements. No movement greater than 2********************0.12**4**Managements and Cuation Programing**********************(+)
' * Problem For Drawing of Thinking Things*************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Constant Result**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * One movements Right .Heuristic Remaining Constant Results******************************0.12**4**Managements and Cuation Programing**********************(+)
' * Constant Heuristic Result**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Need To Add A Heuristic Useful Another*************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Function Does’ Work Allis suddenly Become Zero that Previously Working*******0.12**4**Managements and Cuation Programing**********************(+)
' * No Movement Greater than one order in Computer 'Alice'*********************************0.12**4**Managements and Cuation Programing**********************(+)
' * Tow movements in Computer 'Alice' Of two Different Order Color*************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Not Work Greater than 3 Length Count of A************************************0.12**4**Managements and Cuation Programing**********************(+)
' * 'They Don't Really Take care about us'. Misleading in Heuristic King Supported*********0.12**4**Managements and Cuation Programing**********************(+)
' * Non Order Movments*********************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Misleading at Stage three. no illegal movement greater than three**********************0.12**4**Managements and Cuation Programing**********************(+)
' * Thinking Order Misleading**************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Hit Mechanism Malfunctional************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Tow movements At One 'Alice' Order time************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Computer By Computer 'Alice' by 'Bob' Caused to Loop Heuristic.**************0.12**4**Managements and Cuation Programing**********************(+)
' * Learning Automata of Quantum also leads to re loop heuristic***************************0.88**1**Risk Control********************************************(*)QC-OK.
' * Heuristic Learning Automata 'Alice' By 'Bob' Leads to Re loop**************************0.12**4**Managements and Cuation Programing**********************(+)
' * Heuristic Things Loop 'Alice' By 'Bob'*************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Self 'Kish' Detection Failure By 'Alice'***********************************************0.12**4**Managements and Cuation Programing**********************(+)
' * 'Penalty' Value Of All Become zero althouth the one should be non Penalty**************0.88**1**Risk Control********************************************(*)
' * Clone Dosn't Copy All Content of AllDraw Dummy*****************************************0.12**4**Managements and Cuation Programing**********************(+)
' * KishRemovable By Self King Solved.Penalty Action Misleading****************************0.88**1**Risk Control********************************************(-*)QC-OK.
' * 'Kish' Detection Failure***************************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Mechanisam Of Order in Predict Failed.*************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * 'Alice' King Virtualization or Table Content of King Misleading************************0.12**4**Managements and Cuation Programing**********************(+)
' * With The All Things Huristic Signing Mechnisam Some Movments become null Table.********0.12**4**Managements and Cuation Programing**********************(+)
' * Dept First Search Not Working. Misleading MalFunction Virtualization.******************0.12**4**Managements and Cuation Programing**********************(+)
' * Dept First Table is Null at Bob Order.*************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Dept First SetVirtualization and Table Misleading By Alice.****************************0.12**4**Managements and Cuation Programing**********************(+)
' * No Reason Logically For MalFunction  Timer Dept First Dynamic Timer.*******************0.12**4**Managements and Cuation Programing**********************(+)
' * DeptFirst Thinking Taking a lot of time.***********************************************0.12**4**Managements and Cuation Programing**********************([+]
' * Dept First Not Work.*******************************************************************0.12**4**Managements and Cuation Programing**********************[+]
' * Dept First Not Work.Timer Stop At Greater than 2,3,4,5,6,7 Movments.*******************0.12**4**Managements and Cuation Programing**********************[+]
' * No Reason For MalFunction of DeptFirstNotFoundHuristicDeptFirst.***********************0.12**4**Managements and Cuation Programing**********************[+]
' * Problem Solved.No Reason to NullExeption of DeptFirstHuristic Algorithm.***************0.88**1**Risk Control********************************************[-*]QC-OK.
' * Function Evaluation Disabled .At Initiate DeptFirstGenetic Found Sysntax.**************0.88**1**Risk Control********************************************[*]
' * Index Was Out Of Range Exeption Was Not Handled.Colud Not Be Handle.*******************0.12**4**Managements and Cuation Programing**********************{+}
' * No Logical Mechanism To Reconstructe Current AllDraw Objects.**************************0.12**4**Managements and Cuation Programing**********************{+}
' * Dept First Sysntax is legal and The table is constant table.***************************0.12**4**Managements and Cuation Programing**********************{+}
' * Table Content Empty. No Syntax Exist.**************************************************0.12**4**Managements and Cuation Programing**********************{+}
' * Game Begin From First When the Soldiers Move Ordinary Complete in Dept First***********0.88**1**Risk Control********************************************{*}QC-OK.
' * New Instatnt Of Program Cuase to Begin Fron First.*************************************0.12**4**Managements and Cuation Programing**********************<+>
' * No Logically Reason For New Game Of Program. New Instatnt Not Detected.****************0.12**4**Managements and Cuation Programing**********************<+>
' * Internal New Instatnt Of FormeRefregitz is MalFunction.********************************0.12**4**Managements and Cuation Programing**********************<+>
' * Dept First CC Changes to CC Normal Game.***********************************************0.12**4**Managements and Cuation Programing**********************<+>
' * Game CC UnContoroled.******************************************************************0.12**4**Managements and Cuation Programing**********************<+>
' * MalFunction of Syntax and Movments.By Alice and Bob.***********************************0.12**4**Managements and Cuation Programing**********************<+>
' * Threading Solved! The OutOfRangeIndex Not Work.****************************************0.12**4**Managements and Cuation Programing**********************[-+]
' * Vituallization error!No Best Matches between Truth of table content and irtualization**0.12**4**Managements and Cuation Programing**********************[+]
' * Dynamic Programming for Stroring ADraw THISDummy Adraw Value MalFunction.**************0.12**4**Managements and Cuation Programing**********************(+)
' * Order is Constant in Dynamic Programming.**********************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Table MalFunction at Dynamic Programming.At Step 3.************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Some Movments are MalFuncational at Dynamic Programming.*******************************0.12**4**Managements and Cuation Programing**********************(+)
' * Huristic Overlay Tow Part of ADraw and StoreADraw Sections at Different levels Tab Cal.0.12**4**Managements and Cuation Programing**********************(+)
' * Not to be needing again calculation. MalFunction is depend of tow part.****************0.12**4**Managements and Cuation Programing**********************(+)
' * BackWard Loos of Things AllDraw Mechnisam.*********************************************0.88**1**Risk Control********************************************(*)QC-OK.
' * Some Dynamic Programming MalFunction Movments.*****************************************0.88**1**Risk Control********************************************(*)QC-OK.
' * Syntax and Forward and Backward Movments Syntax is MalFunction.************************0.12**4**Managements and Cuation Programing**********************<+>
' * Database and Virtualization Forward and Backward MalFunction***************************0.12**4**Managements and Cuation Programing**********************<+>
' * Reproduction of Thinfs Missleading.****************************************************0.88**1**Risk Control********************************************<*>QC-OK.
' * Reproduction of Some Things are MalFunction Movments.**********************************0.12**4**Managements and Cuation Programing**********************{+}
' * Dept Count of Dynamic Programming Misleadig.Dept Operation Count Mal Function.*********0.88**1**Risk Control********************************************(*)QC-OK.
' * Huristic By Alice is MalFunction.******************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Achmaz Identification By Alice is MalFunction.*****************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Kish Identification By Alice is MalFunction.*******************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Kish Recognized But Mate Not Recognized!***********************************************0.12**4**Managements and Cuation Programing**********************(_+)
' * Penalty Regard Mechanism Misleading.***************************************************0.12**4**Managements and Cuation Programing**********************{+}
' * Inhereted LearningAtamata Caused to Shared Parent Allocated Variable.******************0.12**4**Managements and Cuation Programing**********************{+}
' * 'Kish' By 'Alice' Not Removed Unreasonably.********************************************0.88**1**Risk Control********************************************{*}QC-OK.
' * DeptFirst Huristic Found MalFunction at Kish Alice.************************************0.12**4**Managements and Cuation Programing**********************{+}
' * Sortments of ADRAW and Construction is MalFunction at Dept Dynamic Programming.********0.12**4**Managements and Cuation Programing**********************{+}
' * Huristic Dept First were Worked Out Unreasonably such Situation(Golden Sword Magic).***0.88**1**Risk Control********************************************{*}QC-OK.
' * Converted 'King' of 'Alice' to 'Elephant' UnReasonably.********************************0.12**4**Managements and Cuation Programing**********************(+)
' * 'Long Game' ; But MalFunction of Game.*************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * 'Always' in Current game is 'Bob'.*****************************************************0.12**4**Managements and Cuation Programing**********************(+)
' * Current Table of ADRAW is Correct Table But the Game is MalFunction.*******************0.12**4**Managements and Cuation Programing**********************(+)
' * Move of Current Table Dept First Huristic found ;found an ovelay in 'Bob' and 'Alice'**0.12**4**Managements and Cuation Programing**********************(+)
' * Current Table in High Level Become Null and prevent of 'LongGame' Strategy.************0.12**4**Managements and Cuation Programing**********************(+)
' * 'LongGame' Become short Undetectably Unreasonably;Clear Store Non Detectably.**********0.88**1**Risk Control********************************************(*)QC-OK.
' * All Draw Dept First section some movments have not been accurred considerably.*********0.88**1**Risk Control********************************************(*)QC-OK.
' * 'Long Game' Breaks Suddendly without Monitor Caused.***********************************0.12**4**Managements and Cuation Programing**********************{+}
' * Overlay Some Movments of 'Long Game' Breaked.Caused Probability to break.**************0.12**4**Managements and Cuation Programing**********************{+}
' * SomeTimes All Situation of Current Games Become Cleared and No Table Founded.**********0.12**4**Managements and Cuation Programing**********************{+}
' * Gray Soldeir is Only Movmnets and Converts in Huristic and No Move are detectable.*****0.12**4**Managements and Cuation Programing**********************{+}
' * DEEPLY Recursive Tree of Second Version Become in Some Null At Hurristic Finsished.****0.12**4**Managements and Cuation Programing**********************{+}
' * Dept Huristic Content is Zero. No Calculation of Dept Huristic Calculation.************0.12**4**Managements and Cuation Programing**********************{+}
' * MalFunction of Dep Huristic Person and MalFunction Movments of CC Dept Huristic********0.88**1**Risk Control********************************************{*}QC-OK.
' * Mal Function of Reconstruction of Dept Objects In Initiate Dept First.*****************0.12**4**Managements and Cuation Programing**********************<+>
' * Hurisic Operantional Have Mal Function Behaviour.**************************************0.12**4**Managements and Cuation Programing**********************<+>
' * Table Zero of Dept First Huristic Mal Function.****************************************0.12**4**Managements and Cuation Programing**********************<+>
' * Dept First Initiate Method Result Object Content Mal Function.*************************0.12**4**Managements and Cuation Programing**********************<+>
' * Table Nopt Found Of Dept First Huristic.Mal Function of Initiate and Huristic.*********0.12**4**Managements and Cuation Programing**********************<+>
' * Table Foundation Successfule. Traversaling of All Tree Not Successfule.****************0.12**4**Managements and Cuation Programing**********************<+>
' * Table Some Movments Intiaiazation Mal Function.****************************************0.12**4**Managements and Cuation Programing**********************{+}
' * BackWard Max Kish Mate Mechanism For Best Huristic is Unknown**************************0.12**4**Managements and Cuation Programing**********************{+}
' * Minister After Calculation DeptHuristic At DeptHuristic becomes Null.******************0.88**1**Risk Control********************************************(*)QC-OK
' * All Objects Possible Movments Not calculating During DeptFirstSerach Method.***********0.88**1**Risk Control********************************************{*}QC_OK
' * Mechanisam olf DeptFirstHuristic and Hurisistic is QC-Ok. But Table foundation Illegal.0.88**1**Risk Control********************************************<*>QC-OK
' * ********************************************************************************************************************************************************(+:Sum(63)) 
' * 1394/12/19**********************************************************************************************************************************************(*:Sum(4))
' * ********************************************************************************************************************************************************(-:sum(2)) (_:Sum(0)):2:(+:Sum(3)) (-:Sum(1)) (*:Sum(2)) 3: (+:Sum(4)) (*:Sum(1)) 4:(+:Sum(6))  5:(+:Sum(2)) (-:Sum(1)) 6:(+:Sum(6)) (*:Sum(2)) 7.(+:Sum(2)) (*:Sum(1)) 8.(+:Sum(1)) 9.(+:Sum(4)) (*:Sum(1)) (-:Sum(1)) 10.(+:Sum(4)) (*:Sum(2)) 11.(+:Sum(4)) 12.(+:Sum(2)) (*:Sum(2)) 13.(+:Sum(4)) 14.(+:Sum(2)) (*:Sum(1)) 15.(+:Sum(6)) 16.(+:Sum(2)) 17.(QC-OK.:Sum(13))
' 





Namespace Refrigtz
	Public Class AllDraw
		'Initiate Variables.
		Public BridgesKing As Boolean = False
		Private MaxHuristicDeptFirstBackWardTable As New List(Of Integer(,))()
		Public Shared increasedProgress As Integer = 0
		Public Shared CurrentHuristic As Double = -999999999999999999L
		Public Shared SignAttack As Integer = 1
		Public Shared SignAchmaz As Integer = 1
		Public Shared SignReducedAttacked As Integer = 1
		Public Shared SignSupport As Integer = 1
		Public Shared SignHitting As Integer = 1
		Public Shared SignMovments As Integer = 1
		Private Hureturn As Integer = 0
		Public Shared DrawTable As Boolean = False
		Public Shared TableVeryfy As Integer(,) = New Integer(8, 8) {}
		Public Shared MaxDept As Integer = 1
		Public Shared TableVeryfyConst As Integer(,) = New Integer(8, 8) {}
		Shared TableHuristic As Integer(,) = New Integer(8, 8) {}
		Public Shared TableCurrent As New List(Of Integer(,))()
		Public Shared NoTableFound As Boolean = False
		Public Shared DynamicDeptFirstPrograming As Boolean = False
		Public Shared StoreADraw As New List(Of AllDraw)()
		Public Shared StoreADrawDept As New List(Of Integer)()
		Shared LevelDeptFirsDynamic As Integer = 1
		Public Shared UseDoubleTime As Boolean = False
		Public Shared DeptiLevelMax As Integer = 2
		Public Shared DeptFirstSearch As Boolean = False
		Public Shared ImageRoot As [String] = FormRefrigtz.Root + "\Images"
		Public Shared ImagesSubRoot As [String] = AllDraw.ImageRoot + "\Fit\Small\"
		Public Shared RedrawTable As Boolean = True
		Public Shared SyntaxToWrite As [String] = ""
		Public Shared SodierConversionOcuured As Boolean = False
		Public Shared SodierMovments As Integer = 1
		Public Shared ElefantMovments As Integer = 1
		Public Shared HourseMovments As Integer = 1
		Public Shared BridgeMovments As Integer = 1
		Public Shared MinisterMovments As Integer = 1
		Public Shared KingMovments As Integer = 1
		Public Shared SodierMidle As Integer = 8
		Public Shared SodierHigh As Integer = 16
		Public Shared ElefantMidle As Integer = 2
		Public Shared ElefantHigh As Integer = 4
		Public Shared HourseMidle As Integer = 2
		Public Shared HourseHight As Integer = 4
		Public Shared BridgeMidle As Integer = 2
		Public Shared BridgeHigh As Integer = 4
		Public Shared MinisterMidle As Integer = 1
		Public Shared MinisterHigh As Integer = 2
		Public Shared KingMidle As Integer = 1
		Public Shared KingHigh As Integer = 2
		Private APredict As ChessPerdict = Nothing
		Public Shared SodierValue As Integer = 1 * 4
		Public Shared ElefantValue As Integer = 3 * 16
		Public Shared HourseValue As Integer = 3 * 12
		Public Shared BridgeValue As Integer = 5 * 16
		Public Shared MinisterValue As Integer = 9 * 32
		Public Shared KingValue As Integer = 10 * 8
		Private RW As Integer = 0
		Private CL As Integer = 0
		Private Ki As Integer = 0
		Private RW1 As Integer = 0
		Private CL1 As Integer = 0
		Private Ki1 As Integer = 0
		Private MaxLess1 As Integer = 0
		Private RW2 As Integer = 0
		Private CL2 As Integer = 0
		Private Ki2 As Integer = 0
		Private MaxLess2 As Integer = 0
		Private RW3 As Integer = 0
		Private CL3 As Integer = 0
		Private Ki3 As Integer = 0
		Private MaxLess3 As Integer = 0
		Private RW4 As Integer = 0
		Private CL4 As Integer = 0
		Private Ki4 As Integer = 0
		Private MaxLess4 As Integer = 0
		Private RW5 As Integer = 0
		Private CL5 As Integer = 0
		Private Ki5 As Integer = 0
		Private MaxLess5 As Integer = 0
		Private RW6 As Integer = 0
		Private CL6 As Integer = 0
		Private Ki6 As Integer = 0
		Private MaxLess6 As Integer = 0
		Public Shared LoopHuristicIndex As Integer = 0
		Shared RWList As New List(Of Integer)()
		Shared ClList As New List(Of Integer)()
		Shared KiList As New List(Of Integer)()
		Public Shared TableListAction As New List(Of Integer(,))()
		Public Move As Integer = 0
		Public Shared MouseClick As Integer = 0
		Private DeptIndex As Integer() = New Integer(20) {}
		Private DeptIndexVlue As Integer = 0
		Public CurrentTable As Integer(,) = New Integer(8, 8) {}
		Public ADraw As List(Of AllDraw) = Nothing
		Public TableList As New List(Of Integer(,))()
		Public Dept As Integer = 0
		Public SolderesOnTable As DrawSoldier() = Nothing
		Public ElephantOnTable As DrawElefant() = Nothing
		Public HoursesOnTable As DrawHourse() = Nothing
		Public BridgesOnTable As DrawBridge() = Nothing
		Public MinisterOnTable As DrawMinister() = Nothing
		Public KingOnTable As DrawKing() = Nothing
		Private MaxHuristicDeptFirstBackWard As New List(Of Integer())()
		Const MaxSoldeirFounded As Integer = 2
		Const MaxElephntFounded As Integer = 6
		Const MaxHourseFounded As Integer = 10
		Const MaxBridgesFounded As Integer = 14
		Const MaxMinisterFounded As Integer = 18
		Const MaxKingFounded As Integer = 22
		Public THIS As FormRefrigtz
		'Error Handling
		Shared Sub Log(ex As Exception)
			Try
				Dim stackTrace As String = ex.ToString()
					' path of file where stack trace will be stored.
				File.AppendAllText(FormRefrigtz.Root + "\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Constructor
		Public Sub New(ByRef th As FormRefrigtz)
			'Initiayte Locally Variables.
			THIS = th
			APredict = New ChessPerdict(th)
			ADraw = New List(Of AllDraw)()
			SolderesOnTable = New DrawSoldier(AllDraw.SodierHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.SodierHigh
				SolderesOnTable(i) = New DrawSoldier()
				i += 1
			End While
			ElephantOnTable = New DrawElefant(AllDraw.ElefantHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.ElefantHigh
				ElephantOnTable(i) = New DrawElefant()
				i += 1
			End While
			HoursesOnTable = New DrawHourse(AllDraw.HourseHight) {}
			Dim i As Integer = 0
			While i < AllDraw.HourseHight
				HoursesOnTable(i) = New DrawHourse()
				i += 1
			End While
			BridgesOnTable = New DrawBridge(AllDraw.BridgeHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.BridgeHigh
				BridgesOnTable(i) = New DrawBridge()
				i += 1
			End While
			MinisterOnTable = New DrawMinister(AllDraw.MinisterHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.MinisterHigh
				MinisterOnTable(i) = New DrawMinister()
				i += 1
			End While
			KingOnTable = New DrawKing(AllDraw.KingHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.KingHigh
				KingOnTable(i) = New DrawKing()
				i += 1


			End While
		End Sub
		'Clone Copy Method
		Public Sub Clone(AA As AllDraw)
			'Initiate a new class object and clone a copy.
			AA.SolderesOnTable = New DrawSoldier(AllDraw.SodierHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.SodierHigh
				Try
					Me.SolderesOnTable(i).Clone(AA.SolderesOnTable(i), THIS)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			AA.ElephantOnTable = New DrawElefant(AllDraw.ElefantHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.ElefantHigh
				Try

					Me.ElephantOnTable(i).Clone(AA.ElephantOnTable(i), THIS)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			AA.HoursesOnTable = New DrawHourse(AllDraw.HourseHight) {}
			Dim i As Integer = 0
			While i < AllDraw.HourseHight
				Try

					Me.HoursesOnTable(i).Clone(AA.HoursesOnTable(i), THIS)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			AA.BridgesOnTable = New DrawBridge(AllDraw.BridgeHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.BridgeHigh
				Try

					Me.BridgesOnTable(i).Clone(AA.BridgesOnTable(i), THIS)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			AA.MinisterOnTable = New DrawMinister(AllDraw.MinisterHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.MinisterHigh
				Try

					Me.MinisterOnTable(i).Clone(AA.MinisterOnTable(i), THIS)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			AA.KingOnTable = New DrawKing(AllDraw.KingHigh) {}
			Dim i As Integer = 0
			While i < AllDraw.KingHigh
				Try

					Me.KingOnTable(i).Clone(AA.KingOnTable(i), THIS)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			AA.ADraw = New List(Of AllDraw)()
			AA.Dept = Me.Dept
			Dim i As Integer = 0
			While i < Me.ADraw.Count

				AA.ADraw.Add(Me.ADraw(i))
				i += 1
			End While
			Dim i As Integer = 0
			While i < Me.TableList.Count
				AA.TableList.Add(Me.TableList(i))
				i += 1
			End While

		End Sub
		'aBlanck Constructor
		Public Sub New(THi As AllDraw)
		End Sub
		'Check For Thinking Of Current Item Movments Finished.
		Public Function AllCurrentDeptThinkingFinished(Dum As AllDraw, i As Integer, j As Integer, Kind As Integer) As Boolean
			'For All kind of Current Thinking depend of current type consider finshing state thinking.
			Dim Finished As Boolean = False
			If True Then
				If Kind = 1 Then
					If Dum.SolderesOnTable(i).SoldierThinking(0).ThinkingFinished Then
						Return True
					End If
				ElseIf Kind = 2 Then
					If Dum.ElephantOnTable(i).ElefantThinking(0).ThinkingFinished Then
						Return True
					End If
				ElseIf Kind = 3 Then
					If Dum.HoursesOnTable(i).HourseThinking(0).ThinkingFinished Then
						Return True
					End If
				ElseIf Kind = 4 Then
					If Dum.BridgesOnTable(i).BridgeThinking(0).ThinkingFinished Then
						Return True
					End If
				ElseIf Kind = 5 Then
					If Dum.MinisterOnTable(i).MinisterThinking(0).ThinkingFinished Then
						Return True
					End If
				ElseIf Kind = 6 Then
					If Dum.KingOnTable(i).KingThinking(0).ThinkingFinished Then
						Return True
					End If
				End If
			End If
			Return Finished

		End Function
		'Wait For Thinking Of Current Item Finished.
		Sub Wait(Dum As AllDraw, i As Integer, j As Integer, k As Integer, Kind As Integer, Dept As Boolean)
			'While Thinking not finished do while.
			Do
				Thread.Sleep(1)
			Loop While Not AllCurrentDeptThinkingFinished(Dum, i, j, Kind)


		End Sub
		'(Non Dept First ) Huristic Non Coplement Search Method.
		Public Sub InitiateForEveryKindThingHome(DummyHA As AllDraw, ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, _
			TB As Boolean, [IN] As Integer)
			'Initiate Local Variables.
			Dim i As Integer = 0, j As Integer = 0
			Dim Dummy As New AllDraw(THIS)
			'When Order is Gray.
			If Order = 1 Then
				'For All Gray Soldeirs.
				i = 0
				While i < AllDraw.SodierMidle
					Try
						ThinkingChess.Kind = 1
						'If there is not Soldeir continue Traversal.
						If SolderesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Store Objective Current Variables in Local Variable.
						ii = CType(SolderesOnTable(i).Row, Integer)
						jj = CType(SolderesOnTable(i).Column, Integer)
						Table = SolderesOnTable(i).Table
						'Construction of New Thinking Dummy Variables depend of Local Variables.
						Dummy.SolderesOnTable(i) = New DrawSoldier(ii, jj, a, Table, Order, False, _
							i)
						If True Then
							'For All Gray Soldeir Movable Situation.
							j = 0
							While j < AllDraw.SodierMovments
								'Operation of Thinking Iniatation.
								Dummy.SolderesOnTable(i).SoldierThinking(0).ThinkingBegin = True
								Dummy.SolderesOnTable(i).SoldierThinking(0).ThinkingFinished = False
								Dummy.SolderesOnTable(i).SoldierThinking(0).t = New Thread(New ThreadStart(Dummy.SolderesOnTable(i).SoldierThinking(0).Thinking))
								Dummy.SolderesOnTable(i).SoldierThinking(0).t.Start()
								'Wait for finishing.
								Wait(Dummy, i, j, 0, 1, False)
								Dummy.SolderesOnTable(i).SoldierThinking(0).t.Abort()

								Dummy.SolderesOnTable(i).SoldierThinking(0).t.Join()
								j += 1
							End While
						End If
					Catch t As Exception
						Dummy.SolderesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For all Elefant Gray 
				i = 0
				While i < AllDraw.ElefantMidle
					Try
						ThinkingChess.Kind = 2
						'If The Elephant is not exist continue traversal.
						If ElephantOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Objective Elefphant Variables by Local One.
						ii = CType(ElephantOnTable(i).Row, Integer)
						jj = CType(ElephantOnTable(i).Column, Integer)
						Table = ElephantOnTable(i).Table
						'Construction of Elephant Thinking Object by Local Variables.
						Dummy.ElephantOnTable(i) = New DrawElefant(ii, jj, a, Table, Order, False, _
							i)
						If True Then
							'For All Gray Elephant Movable.
							j = 0
							While j < AllDraw.ElefantMovments
								'Operation of Elephant of Current Gray Thinking.
								Dummy.ElephantOnTable(i).ElefantThinking(0).ThinkingBegin = True
								Dummy.ElephantOnTable(i).ElefantThinking(0).ThinkingFinished = False
								Dummy.ElephantOnTable(i).ElefantThinking(0).t = New Thread(New ThreadStart(Dummy.ElephantOnTable(i).ElefantThinking(0).Thinking))
								Dummy.ElephantOnTable(i).ElefantThinking(0).t.Start()
								'Wait for Finishing.
								Wait(Dummy, i, j, 0, 2, False)
								Dummy.ElephantOnTable(i).ElefantThinking(0).t.Abort()
								Dummy.ElephantOnTable(i).ElefantThinking(0).t.Join()
								j += 1
							End While
						End If

					Catch t As Exception
						Dummy.ElephantOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While


				'For All Gray Hourse
				i = 0
				While i < AllDraw.HourseMidle
					Try
						ThinkingChess.Kind = 3
						'Igone of Non Exist HourseGray.
						If HoursesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initae Of Local Variables By Objective Variables.
						ii = CType(HoursesOnTable(i).Row, Integer)
						jj = CType(HoursesOnTable(i).Column, Integer)
						Table = HoursesOnTable(i).Table
						'Construction of Hourse Gray By Local Variables.
						Dummy.HoursesOnTable(i) = New DrawHourse(ii, jj, a, Table, Order, False, _
							i)


						If True Then
							'For All Possible Movments.
							j = 0
							While j < AllDraw.HourseMovments
								'Thinking of Hourse Current Operation.
								Dummy.HoursesOnTable(i).HourseThinking(0).ThinkingBegin = True
								Dummy.HoursesOnTable(i).HourseThinking(0).ThinkingFinished = False
								Dummy.HoursesOnTable(i).HourseThinking(0).t = New Thread(New ThreadStart(Dummy.HoursesOnTable(i).HourseThinking(0).Thinking))
								Dummy.HoursesOnTable(i).HourseThinking(0).t.Start()
								'Wait for Thinking Finsished.
								Wait(Dummy, i, j, 0, 3, False)
								Dummy.HoursesOnTable(i).HourseThinking(0).t.Abort()
								Dummy.HoursesOnTable(i).HourseThinking(0).t.Join()
								j += 1
							End While

						End If
					Catch t As Exception
						Dummy.HoursesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While



				'For All Possible Gray Bridges
				i = 0
				While i < AllDraw.BridgeMidle
					Try
						ThinkingChess.Kind = 4
						'If Bridges NonExist Continue Traversal
						If BridgesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables for Objective Parameters.
						ii = CType(BridgesOnTable(i).Row, Integer)
						jj = CType(BridgesOnTable(i).Column, Integer)
						Table = BridgesOnTable(i).Table
						'Construction of Thinking Variables Objective By Local Variables.
						Dummy.BridgesOnTable(i) = New DrawBridge(ii, jj, a, Table, Order, False, _
							i)

						If True Then
							'For All Possible Bridge Movments.
							j = 0
							While j < AllDraw.BridgeMovments
								'Thinking Of Gray Briges of Current.
								Dummy.BridgesOnTable(i).BridgeThinking(0).ThinkingBegin = True
								Dummy.BridgesOnTable(i).BridgeThinking(0).ThinkingFinished = False
								Dummy.BridgesOnTable(i).BridgeThinking(0).t = New Thread(New ThreadStart(Dummy.BridgesOnTable(i).BridgeThinking(0).Thinking))
								Dummy.BridgesOnTable(i).BridgeThinking(0).t.Start()
								'Wait for Thinking Finshing.
								Wait(Dummy, i, j, 0, 4, False)
								Dummy.BridgesOnTable(i).BridgeThinking(0).t.Abort()
								Dummy.BridgesOnTable(i).BridgeThinking(0).t.Join()
								j += 1
							End While

						End If
					Catch t As Exception
						Dummy.BridgesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Minister Gray Objectes.
				i = 0
				While i < AllDraw.MinisterMidle
					Try
						ThinkingChess.Kind = 5
						'For Non Exist Gray Minster Ignore and Continue.
						If MinisterOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables By Objective Current State.
						ii = CType(MinisterOnTable(i).Row, Integer)
						jj = CType(MinisterOnTable(i).Column, Integer)
						Table = MinisterOnTable(i).Table
						'Construction of Gray Minister Thinking Objectives.
						Dummy.MinisterOnTable(i) = New DrawMinister(ii, jj, a, Table, Order, False, _
							i)


						If True Then
							'For All Possible Movments that is ignored.
							j = 0
							While j < AllDraw.MinisterMovments
								'Thinking of Current Minister Gray 
								Dummy.MinisterOnTable(i).MinisterThinking(0).ThinkingBegin = True
								Dummy.MinisterOnTable(i).MinisterThinking(0).ThinkingFinished = False
								Dummy.MinisterOnTable(i).MinisterThinking(0).t = New Thread(New ThreadStart(Dummy.MinisterOnTable(i).MinisterThinking(0).Thinking))
								Dummy.MinisterOnTable(i).MinisterThinking(0).t.Start()
								'Wait Until Thinking Finished.
								Wait(Dummy, i, j, 0, 5, False)
								Dummy.MinisterOnTable(i).MinisterThinking(0).t.Abort()
								Dummy.MinisterOnTable(i).MinisterThinking(0).t.Join()
								j += 1
							End While


						End If
					Catch t As Exception
						Dummy.MinisterOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Possible Gray Kings Objective.
				i = 0
				While i < AllDraw.KingMidle
					Try
						ThinkingChess.Kind = 6
						'Ignore of Non Exists Gray King.
						If KingOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate of Local Variables by Objective Current Gray King Variables.
						ii = CType(KingOnTable(i).Row, Integer)
						jj = CType(KingOnTable(i).Column, Integer)
						Table = KingOnTable(i).Table
						'Construction of Gray King Thinking Objects.
						Dummy.KingOnTable(i) = New DrawKing(ii, jj, a, Table, Order, False, _
							i)


						If True Then
							'For All Possible Gray Kings Movments of Current Objects.
							j = 0
							While j < AllDraw.KingMovments
								'Gray King Thinking Operations.
								Dummy.KingOnTable(i).KingThinking(0).ThinkingBegin = True
								Dummy.KingOnTable(i).KingThinking(0).ThinkingFinished = False
								Dummy.KingOnTable(i).KingThinking(0).t = New Thread(New ThreadStart(Dummy.KingOnTable(i).KingThinking(0).Thinking))
								Dummy.KingOnTable(i).KingThinking(0).t.Start()
								'Wait Untile Thinking Finished.
								Wait(Dummy, i, j, 0, 6, False)
								Dummy.KingOnTable(i).KingThinking(0).t.Abort()
								Dummy.KingOnTable(i).KingThinking(0).t.Join()
								j += 1
							End While


						End If
					Catch t As Exception
						Log(t)
						Dummy.KingOnTable(i) = Nothing
					End Try
					i += 1
				End While
			Else
				'for All brown thinking Operation.
				'For All Brown soldeir Objects.
				i = AllDraw.SodierMidle
				While i < AllDraw.SodierHigh
					Try
						ThinkingChess.Kind = -1
						'For Non Exist Brown soldeir continue and Traverse Back.
						If SolderesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables By Global Objective Varibales of current Soldier On Consideration.
						ii = CType(SolderesOnTable(i).Row, Integer)
						jj = CType(SolderesOnTable(i).Column, Integer)
						Table = SolderesOnTable(i).Table
						'Construction ofBraown soldeir On Thinking Objects.
						Dummy.SolderesOnTable(i) = New DrawSoldier(ii, jj, a, Table, Order, False, _
							i)

						If True Then
							'For Al Possible Ignored Movments.
							j = 0
							While j < AllDraw.SodierMovments
								'Thinking of Brown Solder Operations.
								Dummy.SolderesOnTable(i).SoldierThinking(0).ThinkingBegin = True
								Dummy.SolderesOnTable(i).SoldierThinking(0).ThinkingFinished = False
								Dummy.SolderesOnTable(i).SoldierThinking(0).t = New Thread(New ThreadStart(Dummy.SolderesOnTable(i).SoldierThinking(0).Thinking))
								Dummy.SolderesOnTable(i).SoldierThinking(0).t.Start()
								'Wait For Thinkings Finishing.
								Wait(Dummy, i, j, 0, 1, False)

								Dummy.SolderesOnTable(i).SoldierThinking(0).t.Abort()

								Dummy.SolderesOnTable(i).SoldierThinking(0).t.Join()
								j += 1
							End While
						End If
					Catch t As Exception
						Dummy.SolderesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Brown Elephant Objects.
				i = AllDraw.ElefantMidle
				While i < AllDraw.ElefantHigh
					Try
						ThinkingChess.Kind = -2
						'When there is not A Objects and is Zero Continue Traveral
						If ElephantOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Varibale By Global Object Vriables.
						ii = CType(ElephantOnTable(i).Row, Integer)
						jj = CType(ElephantOnTable(i).Column, Integer)
						Table = ElephantOnTable(i).Table
						'Construction of Current Brown Elephant Thinking Object.
						Dummy.ElephantOnTable(i) = New DrawElefant(ii, jj, a, Table, Order, False, _
							i)

						If True Then
							'For All  Possible Brown Elephant Movments.
							j = 0
							While j < AllDraw.ElefantMovments
								'Elephant Brown Current Object Thinking Operations.
								Dummy.ElephantOnTable(i).ElefantThinking(0).ThinkingBegin = True
								Dummy.ElephantOnTable(i).ElefantThinking(0).ThinkingFinished = False
								Dummy.ElephantOnTable(i).ElefantThinking(0).t = New Thread(New ThreadStart(Dummy.ElephantOnTable(i).ElefantThinking(0).Thinking))
								Dummy.ElephantOnTable(i).ElefantThinking(0).t.Start()
								'Wait For Thinking Finished.
								Wait(Dummy, i, j, 0, 2, False)
								Dummy.ElephantOnTable(i).ElefantThinking(0).t.Abort()
								Dummy.ElephantOnTable(i).ElefantThinking(0).t.Join()
								j += 1
							End While
						End If

					Catch t As Exception
						Dummy.ElephantOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Possible Hourse Objects.
				i = AllDraw.HourseMidle
				While i < AllDraw.HourseHight
					Try
						ThinkingChess.Kind = -3
						'If Current Brown Hourse Not Exist Continue.
						If HoursesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Varables By Gobal Objective Global Variables..
						ii = CType(HoursesOnTable(i).Row, Integer)
						jj = CType(HoursesOnTable(i).Column, Integer)
						Table = HoursesOnTable(i).Table
						'Construction of Thinking Objects By Local Variables.
						Dummy.HoursesOnTable(i) = New DrawHourse(ii, jj, a, Table, Order, False, _
							i)

						If True Then
							'For All Possible Current Object Movment.
							j = 0
							While j < AllDraw.HourseMovments
								'Operation of Brown Current Hourse Thinking.
								Dummy.HoursesOnTable(i).HourseThinking(0).ThinkingBegin = True
								Dummy.HoursesOnTable(i).HourseThinking(0).ThinkingFinished = False
								Dummy.HoursesOnTable(i).HourseThinking(0).t = New Thread(New ThreadStart(Dummy.HoursesOnTable(i).HourseThinking(0).Thinking))
								Dummy.HoursesOnTable(i).HourseThinking(0).t.Start()
								'Wait Until Current Hourse Thinking Finished.
								Wait(Dummy, i, j, 0, 3, False)
								Dummy.HoursesOnTable(i).HourseThinking(0).t.Abort()
								Dummy.HoursesOnTable(i).HourseThinking(0).t.Join()
								j += 1
							End While

						End If
					Catch t As Exception
						Dummy.HoursesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Brown Bridges Objects.
				i = AllDraw.BridgeMidle
				While i < AllDraw.BridgeHigh
					Try
						ThinkingChess.Kind = -4
						'Ignore for Current Non Exist Objects and Continue.
						If BridgesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variable with Global Objects Variables.
						ii = CType(BridgesOnTable(i).Row, Integer)
						jj = CType(BridgesOnTable(i).Column, Integer)
						Table = BridgesOnTable(i).Table
						'Construction of Brown Bridge thinking Object Thinking. 
						Dummy.BridgesOnTable(i) = New DrawBridge(ii, jj, a, Table, Order, False, _
							i)

						If True Then
							j = 0
							While j < AllDraw.BridgeMovments
								'Operational Thinking of Current Brown Bridge.
								Dummy.BridgesOnTable(i).BridgeThinking(0).ThinkingBegin = True
								Dummy.BridgesOnTable(i).BridgeThinking(0).ThinkingFinished = False
								Dummy.BridgesOnTable(i).BridgeThinking(0).t = New Thread(New ThreadStart(Dummy.BridgesOnTable(i).BridgeThinking(0).Thinking))
								Dummy.BridgesOnTable(i).BridgeThinking(0).t.Start()
								'Wiat for Finishing of Current Brown Bridge. 
								Wait(Dummy, i, j, 0, 4, False)
								Dummy.BridgesOnTable(i).BridgeThinking(0).t.Abort()
								Dummy.BridgesOnTable(i).BridgeThinking(0).t.Join()
								j += 1
							End While

						End If
					Catch t As Exception
						Dummy.BridgesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Brown Minister Objects.
				i = MinisterMidle
				While i < AllDraw.MinisterHigh
					Try
						ThinkingChess.Kind = -5
						'Ignore of Current Brown Minsiter Object.
						If MinisterOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate for Local Variables by Global Current Brown Object.
						ii = CType(MinisterOnTable(i).Row, Integer)
						jj = CType(MinisterOnTable(i).Column, Integer)
						Table = MinisterOnTable(i).Table
						'construction of Brown Minster Thinking Object.
						Dummy.MinisterOnTable(i) = New DrawMinister(ii, jj, a, Table, Order, False, _
							i)


						If True Then
							'for All Possible Brown Minister Movments.
							j = 0
							While j < AllDraw.MinisterMovments
								'Operational Thinking of Brown Minister 
								Dummy.MinisterOnTable(i).MinisterThinking(0).ThinkingBegin = True
								Dummy.MinisterOnTable(i).MinisterThinking(0).ThinkingFinished = False
								Dummy.MinisterOnTable(i).MinisterThinking(0).t = New Thread(New ThreadStart(Dummy.MinisterOnTable(i).MinisterThinking(0).Thinking))
								Dummy.MinisterOnTable(i).MinisterThinking(0).t.Start()
								'Wait Until Thinking Finished.
								Wait(Dummy, i, j, 0, 5, False)
								Dummy.MinisterOnTable(i).MinisterThinking(0).t.Abort()
								Dummy.MinisterOnTable(i).MinisterThinking(0).t.Join()
								j += 1
							End While


						End If
					Catch t As Exception
						Dummy.MinisterOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Possible Brown King Objects.
				i = AllDraw.KingMidle
				While i < AllDraw.KingHigh
					Try
						ThinkingChess.Kind = -6
						'Ignore of Current Non Exist Brown King Object and Continue.
						If KingOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate of Local varibale By Global Objective Brown King Varibales.
						ii = CType(KingOnTable(i).Row, Integer)
						jj = CType(KingOnTable(i).Column, Integer)
						Table = KingOnTable(i).Table
						'Construction of Brown King Thinking Objects.
						Dummy.KingOnTable(i) = New DrawKing(ii, jj, a, Table, Order, False, _
							i)

						If True Then
							'For All Possible Non Exist and Ignored King Movments.
							j = 0
							While j < AllDraw.KingMovments
								'Operational Brown King Thinking.
								Dummy.KingOnTable(i).KingThinking(0).ThinkingBegin = True
								Dummy.KingOnTable(i).KingThinking(0).ThinkingFinished = False
								Dummy.KingOnTable(i).KingThinking(0).t = New Thread(New ThreadStart(Dummy.KingOnTable(i).KingThinking(0).Thinking))
								Dummy.KingOnTable(i).KingThinking(0).t.Start()
								'Wait Untile Brown King Operation finished.
								Wait(Dummy, i, j, 0, 6, False)
								Dummy.KingOnTable(i).KingThinking(0).t.Abort()
								Dummy.KingOnTable(i).KingThinking(0).t.Join()
								j += 1
							End While

						End If
					Catch t As Exception
						Log(t)
						Dummy.KingOnTable(i) = Nothing
					End Try
					i += 1

				End While
			End If
			'when Dept First Thinking finished.
			If AllDraw.DeptFirstSearch Then
				'Construction of New All Draw Enemy And Self Movments Objects.
				Dim AdumnmyConstructed As AllDraw = Dummy.CopyRemeiningItems(Me, Order * -1)
				If ADraw IsNot Nothing Then
					Me.ADraw.Clear()
				Else
					Me.ADraw = New List(Of AllDraw)()
				End If
				Me.ADraw.Add(Dummy)
			Else
				If ADraw IsNot Nothing Then
					Me.ADraw = New List(Of AllDraw)()
				Else
					Me.ADraw.Clear()
				End If
				Me.ADraw.Add(Dummy)
			End If

		End Sub
		'Rearrange AllDraw Object Content.
		Public Sub SetRowColumn(index As Integer)
			Try
				Move = 0
				'Intiate Dummy Variables.
				Dim So1 As Integer = 0
				Dim So2 As Integer = AllDraw.SodierMidle
				Dim El1 As Integer = 0
				Dim El2 As Integer = AllDraw.ElefantMidle
				Dim Ho1 As Integer = 0
				Dim Ho2 As Integer = AllDraw.HourseMidle
				Dim Br1 As Integer = 0
				Dim Br2 As Integer = AllDraw.BridgeMidle
				Dim Mi1 As Integer = 0
				Dim Mi2 As Integer = AllDraw.MinisterMidle
				Dim Ki1 As Integer = 0
				Dim Ki2 As Integer = AllDraw.KingMidle
				'When Conversion Occured.
				'A = new List<AllDraw>();
				SolderesOnTable = New DrawSoldier(AllDraw.SodierHigh) {}
				Dim i As Integer = 0
				While i < AllDraw.SodierHigh
					SolderesOnTable(i) = New DrawSoldier()
					i += 1
				End While
				ElephantOnTable = New DrawElefant(AllDraw.ElefantHigh) {}
				Dim i As Integer = 0
				While i < AllDraw.ElefantHigh
					ElephantOnTable(i) = New DrawElefant()
					i += 1
				End While
				HoursesOnTable = New DrawHourse(AllDraw.HourseHight) {}
				Dim i As Integer = 0
				While i < AllDraw.HourseHight
					HoursesOnTable(i) = New DrawHourse()
					i += 1
				End While
				BridgesOnTable = New DrawBridge(AllDraw.BridgeHigh) {}
				Dim i As Integer = 0
				While i < AllDraw.BridgeHigh
					BridgesOnTable(i) = New DrawBridge()
					i += 1
				End While
				MinisterOnTable = New DrawMinister(AllDraw.MinisterHigh) {}
				Dim i As Integer = 0
				While i < AllDraw.MinisterHigh
					MinisterOnTable(i) = New DrawMinister()
					i += 1
				End While
				KingOnTable = New DrawKing(AllDraw.KingHigh) {}
				Dim i As Integer = 0
				While i < AllDraw.KingHigh
					KingOnTable(i) = New DrawKing()
					i += 1
				End While
				AllDraw.SodierConversionOcuured = False

				'When Table Exist.
				If TableList.Count > 0 Then
					'For Every Table Things.
					Dim Column As Integer = 0
					While Column < 8
						Dim Row As Integer = 0
						While Row < 8
							'When Things are Soldiers.
							If System.Math.Abs(Me.TableList(index)(Row, Column)) = 1 Then
								'Determine Color
								Dim a As Color

								If Me.TableList(index)(Row, Column) > 0 Then
									a = Color.Gray
								Else
									a = Color.Brown
								End If
								'When Color is Gray. 
								If a = Color.Gray Then
									Try
										'When Solders ate current location differs add move.
										Try
											If SolderesOnTable(So1).Row <> Row OrElse SolderesOnTable(So1).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construct Soder Gray.
										SolderesOnTable(So1) = New DrawSoldier(Row, Column, a, Me.TableList(index), 1, False, _
											So1)
										'Increase So1.
										So1 += 1
										If So1 > SodierMidle Then
											SodierMidle += 1
											SodierHigh += 1

										End If
									Catch t As Exception
										Log(t)
									End Try
								Else
									'When Color is Brown
									Try
										'When Solders ate current location differs add move.
										Try
											If SolderesOnTable(So2).Row <> Row OrElse SolderesOnTable(So2).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construct Soldeir Brown.
										SolderesOnTable(So2) = New DrawSoldier(Row, Column, a, Me.TableList(index), -1, False, _
											So2)
										'Increase So2.
										So2 += 1
										If So2 > SodierHigh Then
											SodierHigh += 1
										End If
									Catch t As Exception
										Log(t)
									End Try
								End If
							'For Elephant Objects.
							ElseIf System.Math.Abs(Me.TableList(index)(Row, Column)) = 2 Then
								'Initiate Local Variables.
								Dim a As Color
								If Me.TableList(index)(Row, Column) > 0 Then
									a = Color.Gray
								Else
									a = Color.Brown
								End If
								'If Gray Elepahnt
								If a = Color.Gray Then
									Try
										Try
											'Calculation of Movment Number.
											If ElephantOnTable(El1).Row <> Row OrElse ElephantOnTable(El1).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of Draw Object.
										ElephantOnTable(El1) = New DrawElefant(Row, Column, a, Me.TableList(index), 1, False, _
											El1)
										'Increament of Gray Index.
										El1 += 1
										'If New Object Increament Gray Objects.
										If El1 > ElefantMidle Then
											ElefantMidle += 1
											ElefantHigh += 1
										End If
									Catch t As Exception
										Log(t)
									End Try
								Else
									'For Brown Elephant .Objects
									Try
										Try
											'Calculation of Movments Numbers.
											If ElephantOnTable(El2).Row <> Row OrElse ElephantOnTable(El2).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of Draw Brown Elephant Object. 
										ElephantOnTable(El2) = New DrawElefant(Row, Column, a, Me.TableList(index), -1, False, _
											El2)
										'Increament of Index.
										El2 += 1
										'When New Brown Elephant Object Increament of Index.
										If El2 > ElefantHigh Then
											ElefantHigh += 1

										End If
									Catch t As Exception
										Log(t)

									End Try
								End If
							'For Hourse Objects.
							ElseIf System.Math.Abs(Me.TableList(index)(Row, Column)) = 3 Then
								'Initiate Local Varibale and Color.
								Dim a As Color
								If Me.TableList(index)(Row, Column) > 0 Then
									a = Color.Gray
								Else
									a = Color.Brown
								End If
								'If Gray Hourse.
								If a = Color.Gray Then

									Try
										Try
											'Calculation of Movments Number.
											If HoursesOnTable(Ho1).Row <> Row OrElse HoursesOnTable(Ho1).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of Draw Brown Hourse.
										HoursesOnTable(Ho1) = New DrawHourse(Row, Column, a, Me.TableList(index), 1, False, _
											Ho1)
										'Increament of Index.
										Ho1 += 1
										'when There is New Gray Hourse Increase.
										If Ho1 > HourseMidle Then
											HourseMidle += 1
											HourseHight += 1
										End If
									Catch t As Exception
										Log(t)
									End Try
								Else
									'For Brown Hourses.
									Try
										Try
											'Calculation of Movments Number.
											If HoursesOnTable(Ho2).Row <> Row Or HoursesOnTable(Ho2).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of Draw Brown Hourse.
										HoursesOnTable(Ho2) = New DrawHourse(Row, Column, a, Me.TableList(index), -1, False, _
											Ho2)
										'Increament of Index.
										Ho2 += 1
										'When New Brown Hourse Exist Exist Index.
										If Ho2 > HourseHight Then
											HourseHight += 1
										End If
									Catch t As Exception
										Log(t)
									End Try
								End If
							'For Bridges Objects.
							ElseIf System.Math.Abs(Me.TableList(index)(Row, Column)) = 4 Then
								'Initiate of Local Variables.
								Dim a As Color
								If Me.TableList(index)(Row, Column) > 0 Then
									a = Color.Gray
								Else
									a = Color.Brown
								End If
								'For Gray Color.
								If a = Color.Gray Then

									Try
										Try
											'Calculation of Movments Number.
											If BridgesOnTable(Br1).Row <> Row OrElse BridgesOnTable(Br1).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of New Draw Gray Bridges.
										BridgesOnTable(Br1) = New DrawBridge(Row, Column, a, Me.TableList(index), 1, False, _
											Br1)
										'Increamnt of Index.
										Br1 += 1
										'When New Gray Briges Increamnt Max Index.
										If Br1 > BridgeMidle Then
											BridgeMidle += 1
											BridgeHigh += 1

										End If
									Catch t As Exception
										Log(t)
									End Try
								Else
									'For Brown Bridges.
									Try
										Try
											'Calculation of Movments Number.
											If BridgesOnTable(Br2).Row <> Row OrElse BridgesOnTable(Br2).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction Draw of New Brown Bridges.
										BridgesOnTable(Br2) = New DrawBridge(Row, Column, a, Me.TableList(index), -1, False, _
											Br2)
										'Increament of Index.
										Br2 += 1
										'wehn Brown New Bridges Detected Increament Max Index.
										If Br2 > BridgeHigh Then
											BridgeHigh += 1

										End If
									Catch t As Exception
										Log(t)
									End Try
								End If
							'For Minister Objects.
							ElseIf System.Math.Abs(Me.TableList(index)(Row, Column)) = 5 Then
								'Initiate Local Color Varibales.
								Dim a As Color
								If Me.TableList(index)(Row, Column) > 0 Then
									a = Color.Gray
								Else
									a = Color.Brown
								End If
								'For Gray Colors.
								If a = Color.Gray Then

									Try
										Try
											'Clculationb of Movments Number.
											If MinisterOnTable(Mi1).Row <> Row OrElse MinisterOnTable(Mi1).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'construction of new draw Gray Minster.
										MinisterOnTable(Mi1) = New DrawMinister(Row, Column, a, Me.TableList(index), 1, False, _
											Mi1)
										'Increament of Index.
										Mi1 += 1
										'Wehn New Gray Minster Detected Increament Max Indexes.
										If Mi1 > MinisterMidle Then
											MinisterMidle += 1
											MinisterHigh += 1
										End If
									Catch t As Exception
										Log(t)

									End Try
								Else
									'For Brown  Colors.
									Try
										Try
											'Calculation of Movments Number.
											If MinisterOnTable(Mi2).Row <> Row OrElse MinisterOnTable(Mi2).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of New Draw Brown Minster.
										MinisterOnTable(Mi2) = New DrawMinister(Row, Column, a, Me.TableList(index), -1, False, _
											Mi2)
										'Increament Index.
										Mi2 += 1
										'When New Brown Minister Detected Increament Max Index.
										If Mi2 > MinisterHigh Then
											MinisterHigh += 1

										End If
									Catch t As Exception
										Log(t)
									End Try
								End If
							'for King Objects.
							ElseIf System.Math.Abs(Me.TableList(index)(Row, Column)) = 6 Then
								'Initiate Of Color.
								Dim a As Color
								If Me.TableList(index)(Row, Column) > 0 Then
									a = Color.Gray
								Else
									a = Color.Brown
								End If
								'Color consideration.
								If a = Color.Gray Then

									Try
										Try
											'Calculation of Movments Number.
											If KingOnTable(Ki1).Row <> Row OrElse KingOnTable(Ki1).Column <> Column Then
												Move += 1

											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of New Draw Gray King.
										KingOnTable(Ki1) = New DrawKing(Row, Column, a, Me.TableList(index), 1, False, _
											Ki1)
										'Increament of Index.
										Ki1 += 1
										'when New Draw  Object Detected Increament Max Index.
										If Ki1 > KingMidle Then
											KingMidle += 1

											KingHigh += 1

										End If
									Catch t As Exception
										Log(t)
									End Try
								Else
									'For Brown King Color
									Try
										Try
											'Calculation of Movment Number.
											If KingOnTable(Ki2).Row <> Row OrElse KingOnTable(Ki2).Column <> Column Then
												Move += 1
											End If
										Catch t As Exception
											Log(t)
										End Try
										'Construction of New Draw King Brown Object.
										KingOnTable(Ki2) = New DrawKing(Row, Column, a, Me.TableList(index), -1, False, _
											Ki2)
										'Increament of Index.
										Ki2 += 1
										'When New Object Detected Increament Of Brown King Max Index.
										If Ki2 > KingHigh Then
											KingHigh += 1
										End If
									Catch t As Exception
										Log(t)
									End Try

								End If
							End If
							Row += 1
						End While
						Column += 1
					End While
					'Make Empty Remaining.
					Dim i As Integer = So1
					While i < AllDraw.SodierMidle
						SolderesOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = So2
					While i < AllDraw.SodierHigh
						SolderesOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = El1
					While i < AllDraw.ElefantMidle
						ElephantOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = El2
					While i < AllDraw.ElefantHigh
						ElephantOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Ho1
					While i < AllDraw.HourseMidle
						HoursesOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Ho2
					While i < AllDraw.HourseHight
						HoursesOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Br1
					While i < AllDraw.BridgeMidle
						BridgesOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Br2
					While i < AllDraw.BridgeHigh
						BridgesOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Mi1
					While i < AllDraw.MinisterMidle
						MinisterOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Mi2
					While i < AllDraw.MinisterHigh
						MinisterOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Ki1
					While i < AllDraw.KingMidle
						KingOnTable(i) = Nothing
						i += 1
					End While

					Dim i As Integer = Ki2
					While i < AllDraw.KingHigh
						KingOnTable(i) = Nothing
						i += 1

					End While


				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Max Index List Of Huristic Dept First Method.
		Public Sub BeginIndexFoundingMaxLessofMaxList(ListIndex As Integer, Founded As List(Of Integer), ByRef Less As Integer)
			If MaxHuristicDeptFirstBackWard.Count > 0 Then
				If ListIndex < MaxHuristicDeptFirstBackWard.Count Then
					Return
				End If
				Dim Added As Boolean = False
				BeginIndexFoundingMaxLessofMaxList(ListIndex),ListIndex - 1 += 1
				If Less < MaxHuristicDeptFirstBackWard(ListIndex)(1) Then
					Less = MaxHuristicDeptFirstBackWard(ListIndex)(1)
					Added = True

					Founded.Add(2)
				End If
				If Less < MaxHuristicDeptFirstBackWard(ListIndex)(5) Then
					Less = MaxHuristicDeptFirstBackWard(ListIndex)(5)
					If Added Then
						Founded.RemoveAt(Founded.Count - 1)
					End If
					Added = True
					Founded.Add(6)
				End If
				If Less < MaxHuristicDeptFirstBackWard(ListIndex)(9) Then
					Less = MaxHuristicDeptFirstBackWard(ListIndex)(9)
					If Added Then
						Founded.RemoveAt(Founded.Count - 1)
					End If
					Added = True
					Founded.Add(10)
				End If
				If Less < MaxHuristicDeptFirstBackWard(ListIndex)(13) Then
					Less = MaxHuristicDeptFirstBackWard(ListIndex)(13)
					If Added Then
						Founded.RemoveAt(Founded.Count - 1)
					End If
					Added = True
					Founded.Add(14)
				End If
				If Less < MaxHuristicDeptFirstBackWard(ListIndex)(18) Then
					Less = MaxHuristicDeptFirstBackWard(ListIndex)(18)
					If Added Then
						Founded.RemoveAt(Founded.Count - 1)
					End If
					Added = True
					Founded.Add(19)
				End If
				If Less < MaxHuristicDeptFirstBackWard(ListIndex)(22) Then
					Less = MaxHuristicDeptFirstBackWard(ListIndex)(22)
					If Added Then
						Founded.RemoveAt(Founded.Count - 1)
					End If
					Added = True
					Founded.Add(23)
				End If
			End If
		End Sub

		'Dept First Huristic Method.
		Public Function HuristicDeptSearch(Depti As Integer, A As List(Of AllDraw), a As Color, ByRef Less As Double, Order As Integer, CurrentTableHuristic As Boolean) As Integer(,)
			If Dept > MaxDept Then
				Return TableHuristic
			End If
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder

			'Initiate For Dynamic Backward Current Depti Non Minus Founded Max Movments Detection Global Variables.
			Dim Founded As New List(Of Integer)()
			'Initiateing Indicating Huristic Multiple Same Value Best Found of Movments.
			MaxLess1 = -1
			MaxLess2 = -1
			MaxLess3 = -1
			MaxLess4 = -1
			MaxLess5 = -1
			MaxLess6 = -1
			RW1 = -1
			CL1 = -1
			Ki1 = -1
			RW2 = -1
			CL2 = -1
			Ki2 = -1
			RW3 = -1
			CL3 = -1
			Ki3 = -1
			RW4 = -1
			CL4 = -1
			Ki4 = -1
			RW5 = -1
			CL5 = -1
			Ki5 = -1
			RW6 = -1
			CL6 = -1
			Ki6 = -1
			Dim BacWard As Integer() = New Integer(25) {}
			If Depti > MaxDept Then
				Return TableHuristic
			End If
			Depti += 1
			Dim i As Integer = 0, j As Integer = 0
			Dim Act As Boolean = False
			If Order = 1 Then
				THIS.SetBoxText(vbCr & vbLf & "Chess Huristic By Bob!")
				THIS.RefreshBoxText()
			Else
				'If Order is Brown.
				THIS.SetBoxText(vbCr & vbLf & "Chess Huristic By Alice!")
				THIS.RefreshBoxText()
			End If
			'When There is Some A.Count
			If True Then
				'FormatException Every BridgeMovments.
				If True Then
					If Order = 1 Then
						'For Every Soldeir
						i = 0
						While i < AllDraw.SodierMidle


							'For Every Soldier Movments Dept.
							Dim k As Integer = 0
							While k < AllDraw.SodierMovments
								'When There is an Movment in such situation.
								Try
									ThinkingChess.Kind = 1
									j = 0
									While SolderesOnTable(i) IsNot Nothing AndAlso SolderesOnTable(i) IsNot Nothing AndAlso SolderesOnTable(i).SoldierThinking(k) IsNot Nothing AndAlso SolderesOnTable(i).SoldierThinking(k) IsNot Nothing AndAlso j < SolderesOnTable(i).SoldierThinking(k).TableListSolder.Count
										If True Then
											Try
												'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
												If FormRefrigtz.OrderPlate = Order Then
													If SolderesOnTable(i).SoldierThinking(k).PenaltyRegardListSolder(j).IsPenaltyAction() = 0 Then
														Continue Try
													End If
												End If

												'When There is No Movments in Such Order Enemy continue.
												If Order <> FormRefrigtz.OrderPlate Then
													If SolderesOnTable(i).SoldierThinking(0).ReturnHuristic(i, j) >= Less Then
														Continue Try
													End If
												End If
												'When There is greater Huristic Movments.
												If SolderesOnTable(i).SoldierThinking(0).ReturnHuristic(i, j) >= Less Then
													If Order = 1 Then
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Sodier By Bob!")
														THIS.RefreshBoxText()
													Else
														'If Order is Brown.
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Sodier By Alice!")
														THIS.RefreshBoxText()
													End If
													'retrive table of current huristic.
													Dim TableS As Integer(,) = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)
													Dim TableSS As Integer(,) = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)

													'checked for Legal Movments ArgumentOutOfRangeException curnt game.
													If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
														Try
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try
															End If
														Catch t As Exception
															Log(t)
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try

															End If

														End Try
													End If
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(1, TableS, Order, SolderesOnTable(i).SoldierThinking(k).Row, SolderesOnTable(i).SoldierThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															End If
														Else

															' }
														End If
														'When Order is gray.
														If Order = 1 Then
															'When KishGrayAchmaz and There is not DeptFirst search.
															If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.SolderesOnTable(i).Row, Integer), CType(APredict.SolderesOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try
																Else
																	Act = True
																	Less = SolderesOnTable(i).SoldierThinking(k).ReturnHuristic(i, j)



																	Continue Try

																End If
															End If
														Else
															'When Order is Bromn and there is not DeptFirstSearch.
															If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
																'Prdedict Kish.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.SolderesOnTable(i).Row, Integer), CType(APredict.SolderesOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try

																End If
															End If
														End If
													End If
													'Sodleirs Initiate.
													RW1 = i
													CL1 = k
													Ki1 = j
													RW2 = -1
													CL2 = -1
													Ki2 = -1
													RW3 = -1
													CL3 = -1
													Ki3 = -1
													RW4 = -1
													CL4 = -1
													Ki4 = -1
													RW5 = -1
													CL5 = -1
													Ki5 = -1
													RW6 = -1
													CL6 = -1
													Ki6 = -1
													'Set Max of Soldier.
													MaxLess1 = CType((SolderesOnTable(RW1).SoldierThinking(CL1).ReturnHuristic(i, j)), Integer)
													'When Soldeirs is Greater than Others these Set Max.
													If MaxLess1 > MaxLess2 Then
														MaxLess2 = -1
													End If
													If MaxLess1 > MaxLess3 Then
														MaxLess3 = -1
													End If
													If MaxLess1 > MaxLess4 Then
														MaxLess4 = -1
													End If
													If MaxLess1 > MaxLess5 Then
														MaxLess5 = -1
													End If
													If MaxLess1 > MaxLess6 Then
														MaxLess6 = -1
													End If

													If Depti = 1 Then
														'Set Table and Huristic Value and Syntax.
														Act = True
														FormRefrigtz.LastRow = SolderesOnTable(i).SoldierThinking(k).Row
														FormRefrigtz.LastColumn = SolderesOnTable(i).SoldierThinking(k).Column

														Less = SolderesOnTable(i).SoldierThinking(k).ReturnHuristic(i, j)


														TableHuristic = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)
														Dim Hit As Boolean = False
														If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
																SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
																SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
														End If


														ThingsConverter.ActOfClickEqualTow = True
														SolderesOnTable(i).ConvertOperation(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), a, SolderesOnTable(i).SoldierThinking(k).TableListSolder(j), Order, False, _
															i)
														Dim Sign As Integer = 1
														If a = Color.Brown Then
															Sign = -1
														End If
														'If there is Soldier Convert.
														If SolderesOnTable(i).Convert Then
															Hit = False
															If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
																	SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
																	SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
															End If

															If SolderesOnTable(i).ConvertedToMinister Then
																TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 5 * Sign
															ElseIf SolderesOnTable(i).ConvertedToBridge Then
																TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 4 * Sign
															ElseIf SolderesOnTable(i).ConvertedToHourse Then
																TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 3 * Sign
															ElseIf SolderesOnTable(i).ConvertedToElefant Then
																TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 2 * Sign
															End If
															TableList.Clear()
															TableList.Add(TableHuristic)
															If A.Count > 1 Then
																SetRowColumn(0)
															End If

															TableList.Clear()
														End If


													End If
												Else
													'Set Table and Huristic Value and Syntax.
													Try
														If Depti = 1 Then
															'TakeRoot.Pointer = this;
															'Found of Max Non Probable Movments.
															Founded.Clear()
															Dim LessB As Integer = -1000000000
															BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
															RW1 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
															CL1 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
															Ki1 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
															If Founded(0) <> MaxSoldeirFounded Then
																Continue Try
															End If
															Act = True
															FormRefrigtz.LastRow = SolderesOnTable(RW1).SoldierThinking(CL1).Row
															FormRefrigtz.LastColumn = SolderesOnTable(RW1).SoldierThinking(CL1).Column

															Less = SolderesOnTable(RW1).SoldierThinking(CL1).ReturnHuristic(RW1, Ki1)


															TableHuristic = SolderesOnTable(RW1).SoldierThinking(CL1).TableListSolder(Ki1)
															Dim Hit As Boolean = False
															If SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																	SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, False)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																	SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, False)
															End If


															ThingsConverter.ActOfClickEqualTow = True
															SolderesOnTable(RW1).ConvertOperation(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), a, SolderesOnTable(RW1).SoldierThinking(CL1).TableListSolder(Ki1), Order, False, _
																i)
															Dim Sign As Integer = 1
															If a = Color.Brown Then
																Sign = -1
															End If
															'If there is Soldier Convert.
															If SolderesOnTable(RW1).Convert Then
																Hit = False
																If SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1) > 0 Then
																	Hit = True
																End If
																If Order = 1 Then
																	SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																		SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, True)
																Else
																	SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																		SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, True)
																End If

																If SolderesOnTable(RW1).ConvertedToMinister Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 5 * Sign
																ElseIf SolderesOnTable(RW1).ConvertedToBridge Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 4 * Sign
																ElseIf SolderesOnTable(RW1).ConvertedToHourse Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 3 * Sign
																ElseIf SolderesOnTable(RW1).ConvertedToElefant Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 2 * Sign
																End If
																TableList.Clear()
																TableList.Add(TableHuristic)
																If A.Count > 1 Then
																	SetRowColumn(0)
																End If

																TableList.Clear()
															End If
														End If
													Catch t As Exception
														Log(t)
													End Try

												End If
											Catch t As Exception
												Log(t)
											End Try
										End If
										j += 1

									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < SolderesOnTable(i).SoldierThinking(0).Dept.Count
									SolderesOnTable(i).SoldierThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder

							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder

							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While
						'Do For Remaining Objects same as Soldeir Documentation.
						i = 0
						While i < AllDraw.ElefantMidle
							ThinkingChess.Kind = 2
							Dim k As Integer = 0
							While k < AllDraw.ElefantMovments
								Try
									j = 0
									While ElephantOnTable(i) IsNot Nothing AndAlso ElephantOnTable(i) IsNot Nothing AndAlso ElephantOnTable(i).ElefantThinking(k) IsNot Nothing AndAlso ElephantOnTable(i).ElefantThinking(k) IsNot Nothing AndAlso j < ElephantOnTable(i).ElefantThinking(k).TableListElefant.Count
										If True Then
											Try
												'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.

												If FormRefrigtz.OrderPlate = Order Then
													If ElephantOnTable(i).ElefantThinking(k).PenaltyRegardListElefant(j).IsPenaltyAction() = 0 Then
														Continue Try
													End If
												End If

												'When There is No Movments in Such Order Enemy continue.
												If Order <> FormRefrigtz.OrderPlate Then
													If ElephantOnTable(i).ElefantThinking(0).ReturnHuristic(i, j) >= Less Then
														Continue Try
													End If
												End If
												'When There is greater Huristic Movments.
												If ElephantOnTable(i).ElefantThinking(0).ReturnHuristic(i, j) >= Less Then
													If Order = 1 Then
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Elephant By Bob!")
														THIS.RefreshBoxText()
													Else
														'If Order is Brown.
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Elephant By Alice!")
														THIS.RefreshBoxText()
													End If
													'retrive table of current huristic.
													Dim TableS As Integer(,) = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
													Dim TableSS As Integer(,) = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
													'checked for Legal Movments ArgumentOutOfRangeException curnt game.
													If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
														Try
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try
															End If
														Catch t As Exception
															Log(t)
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try

															End If


														End Try
													End If
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(2, TableS, Order, -1, -1).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															End If

														Else
														End If

														'When Order is gray.
														If Order = 1 Then
															'When KishGrayAchmaz and There is not DeptFirst search.
															If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.ElephantOnTable(i).Row, Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try
																Else
																	Act = True

																	Less = ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j)
																End If
															End If
														Else
															If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.ElephantOnTable(i).Row, Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try


																End If
															End If

														End If
													End If
													RW2 = i
													CL2 = k
													Ki2 = j
													RW1 = -1
													CL1 = -1
													Ki1 = -1
													RW3 = -1
													CL3 = -1
													Ki3 = -1
													RW4 = -1
													CL4 = -1
													Ki4 = -1
													RW5 = -1
													CL5 = -1
													Ki5 = -1
													RW6 = -1
													CL6 = -1
													Ki6 = -1
													MaxLess2 = CType((ElephantOnTable(RW2).ElefantThinking(CL2).ReturnHuristic(RW2, Ki2)), Integer)
													If MaxLess2 > MaxLess1 Then
														MaxLess1 = -1
													End If
													If MaxLess2 > MaxLess3 Then
														MaxLess3 = -1
													End If
													If MaxLess2 > MaxLess4 Then
														MaxLess4 = -1
													End If
													If MaxLess2 > MaxLess5 Then
														MaxLess5 = -1
													End If
													If MaxLess2 > MaxLess6 Then
														MaxLess6 = -1
													End If

													If Depti = 1 Then
														'Set Table and Huristic Value and Syntax.
														Dim Hit As Boolean = False
														If ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
																ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
																ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = ElephantOnTable(i).ElefantThinking(k).Row
														FormRefrigtz.LastColumn = ElephantOnTable(i).ElefantThinking(k).Column

														Act = True
														Less = ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j)
														TableHuristic = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
													End If
												Else

													Try
														If Depti = 1 Then
															'TakeRoot.Pointer = this;
															'Found of Max Non Probable Movments.
															Founded.Clear()
															Dim LessB As Integer = -1000000000
															BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
															RW2 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
															CL2 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
															Ki2 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
															If Founded(0) <> MaxElephntFounded Then
																Continue Try
															End If
															Dim Hit As Boolean = False
															If ElephantOnTable(RW2).ElefantThinking(CL2).HitNumberElefant(Ki2) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 2, ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(1), ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(0), Hit, _
																	ElephantOnTable(RW2).ElefantThinking(CL2).HitNumberElefant(Ki2), ChessRules.BridgeActBrown, False)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -2, ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(1), ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(0), Hit, _
																	ElephantOnTable(RW2).ElefantThinking(CL2).HitNumberElefant(Ki2), ChessRules.BridgeActBrown, False)
															End If

															FormRefrigtz.LastRow = ElephantOnTable(RW2).ElefantThinking(CL2).Row
															FormRefrigtz.LastColumn = ElephantOnTable(RW2).ElefantThinking(CL2).Column

															Act = True
															Less = ElephantOnTable(RW2).ElefantThinking(CL2).HuristicListElefant(Ki2)(0) + ElephantOnTable(RW2).ElefantThinking(CL2).HuristicListElefant(Ki2)(1) + ElephantOnTable(RW2).ElefantThinking(CL2).HuristicListElefant(Ki2)(2) + ElephantOnTable(RW2).ElefantThinking(CL2).HuristicListElefant(Ki2)(3)
															TableHuristic = ElephantOnTable(RW2).ElefantThinking(CL2).TableListElefant(Ki2)
														End If
													Catch t As Exception
														Log(t)
													End Try

												End If
											Catch t As Exception
												Log(t)
											End Try

										End If
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder = DummyCurrentOrder
								Dim p As Integer = 0
								While p < ElephantOnTable(i).ElefantThinking(0).Dept.Count
									ElephantOnTable(i).ElefantThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While

								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While

						i = 0
						While i < AllDraw.HourseMidle
							ThinkingChess.Kind = 3
							Dim k As Integer = 0
							While k < AllDraw.HourseMovments
								Try
									j = 0
									While HoursesOnTable(i) IsNot Nothing AndAlso HoursesOnTable(i) IsNot Nothing AndAlso HoursesOnTable(i).HourseThinking(k) IsNot Nothing AndAlso HoursesOnTable(i).HourseThinking(k) IsNot Nothing AndAlso j < HoursesOnTable(i).HourseThinking(k).TableListHourse.Count
										If True Then
											Try
												'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.

												If FormRefrigtz.OrderPlate = Order Then
													If HoursesOnTable(i).HourseThinking(k).PenaltyRegardListHourse(j).IsPenaltyAction() = 0 Then
														Continue Try
													End If
												End If
												'When There is No Movments in Such Order Enemy continue.
												If Order <> FormRefrigtz.OrderPlate Then
													If HoursesOnTable(i).HourseThinking(0).ReturnHuristic(i, j) >= Less Then
														Continue Try
													End If
												End If
												'When There is greater Huristic Movments.
												If HoursesOnTable(i).HourseThinking(0).ReturnHuristic(i, j) >= Less Then
													'retrive table of current huristic.
													If Order = 1 Then
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Hourse By Bob!")
														THIS.RefreshBoxText()
													Else
														'If Order is Brown.
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Hourse By Alice!")
														THIS.RefreshBoxText()
													End If
													Dim TableS As Integer(,) = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
													Dim TableSS As Integer(,) = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
													If True Then
														'checked for Legal Movments ArgumentOutOfRangeException curnt game.
														If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
															Try
																If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																	Continue Try
																End If
															Catch t As Exception
																Log(t)
																If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																	Continue Try

																End If

															End Try
														End If
														'When there is not Penalty regard mechanism.
														If Not ThinkingChess.UsePenaltyRegardMechnisam Then
															'If there is kish or kshachamaz Order.
															If (New ChessRules(3, TableS, Order, HoursesOnTable(i).HourseThinking(k).Row, HoursesOnTable(i).HourseThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
																'When Order is Gray.
																If Order = 1 Then
																	'Continue When is kish KishAchmaz and DeptFirstSearch .
																	If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																		Continue Try
																	End If
																Else
																	'Continue when KishBrown and DeptFirstSearch. 
																	If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																		Continue Try
																	End If
																End If

															Else
															End If
														End If


														'When Order is gray.
														If Order = 1 Then
															'When KishGrayAchmaz and There is not DeptFirst search.
															If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.HoursesOnTable(i).Row, Integer), CType(APredict.HoursesOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try

																End If
															End If
														Else
															If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.HoursesOnTable(i).Row, Integer), CType(APredict.HoursesOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try
																Else
																	Act = True
																	Less = HoursesOnTable(i).HourseThinking(k).ReturnHuristic(i, j)
																	Continue Try

																End If
															End If
														End If
													End If
													RW3 = i
													CL3 = k
													Ki3 = j
													RW1 = -1
													CL1 = -1
													Ki1 = -1
													RW2 = -1
													CL2 = -1
													Ki2 = -1
													RW4 = -1
													CL4 = -1
													Ki4 = -1
													RW5 = -1
													CL5 = -1
													Ki5 = -1
													RW6 = -1
													CL6 = -1
													Ki6 = -1
													MaxLess3 = CType((HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(0) + HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(1) + HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(2) + HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(3)), Integer)
													If MaxLess3 > MaxLess1 Then
														MaxLess1 = -1
													End If
													If MaxLess3 > MaxLess2 Then
														MaxLess2 = -1
													End If
													If MaxLess3 > MaxLess4 Then
														MaxLess4 = -1
													End If
													If MaxLess3 > MaxLess5 Then
														MaxLess5 = -1
													End If
													If MaxLess3 > MaxLess6 Then
														MaxLess6 = -1
													End If

													If Depti = 1 Then
														'Set Table and Huristic Value and Syntax.
														Dim Hit As Boolean = False
														If HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
																HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
																HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
														End If
														FormRefrigtz.LastRow = HoursesOnTable(i).HourseThinking(k).Row
														FormRefrigtz.LastColumn = HoursesOnTable(i).HourseThinking(k).Column

														Act = True
														Less = HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(0) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(1) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(2) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(3)

														TableHuristic = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)

													End If
												Else
													'Set Table and Huristic Value and Syntax.
													Try
														If Depti = 1 Then
															'TakeRoot.Pointer = this;
															'Found of Max Non Probable Movments.
															Founded.Clear()
															Dim LessB As Integer = -1000000000
															BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
															RW3 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
															CL3 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
															Ki3 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
															If Founded(0) <> MaxHourseFounded Then
																Continue Try
															End If
															Dim Hit As Boolean = False
															If HoursesOnTable(RW3).HourseThinking(CL3).HitNumberHourse(Ki3) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 3, HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(1), HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(0), Hit, _
																	HoursesOnTable(RW3).HourseThinking(CL3).HitNumberHourse(Ki3), ChessRules.BridgeActBrown, False)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -3, HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(1), HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(0), Hit, _
																	HoursesOnTable(RW3).HourseThinking(CL3).HitNumberHourse(Ki3), ChessRules.BridgeActBrown, False)
															End If
															FormRefrigtz.LastRow = HoursesOnTable(RW3).HourseThinking(CL3).Row
															FormRefrigtz.LastColumn = HoursesOnTable(RW3).HourseThinking(CL3).Column

															Act = True
															Less = HoursesOnTable(RW3).HourseThinking(CL3).ReturnHuristic(RW3, Ki3)
															TableHuristic = HoursesOnTable(RW3).HourseThinking(CL3).TableListHourse(Ki3)
														End If
													Catch t As Exception
														Log(t)
													End Try
												End If
											Catch t As Exception
												Log(t)
											End Try
										End If
										' else
										If True Then


										End If
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder = DummyCurrentOrder
								Dim p As Integer = 0
								While p < HoursesOnTable(i).HourseThinking(0).Dept.Count
									HoursesOnTable(i).HourseThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While

								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)

							End Try
							i += 1
						End While

						i = 0
						While i < AllDraw.BridgeMidle
							ThinkingChess.Kind = 4
							Dim k As Integer = 0
							While k < AllDraw.BridgeMovments
								Try
									j = 0
									While BridgesOnTable(i) IsNot Nothing AndAlso BridgesOnTable(i) IsNot Nothing AndAlso BridgesOnTable(i).BridgeThinking(k) IsNot Nothing AndAlso BridgesOnTable(i).BridgeThinking(k) IsNot Nothing AndAlso j < BridgesOnTable(i).BridgeThinking(k).TableListBridge.Count
										If True Then
											Try
												'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.

												If FormRefrigtz.OrderPlate = Order Then
													If BridgesOnTable(i).BridgeThinking(k).PenaltyRegardListBridge(j).IsPenaltyAction() = 0 Then
														Continue Try
													End If
												End If
												'When There is No Movments in Such Order Enemy continue.
												If Order <> FormRefrigtz.OrderPlate Then
													If BridgesOnTable(i).BridgeThinking(0).ReturnHuristic(i, j) >= Less Then
														Continue Try
													End If
												End If
												'When There is greater Huristic Movments.
												If BridgesOnTable(i).BridgeThinking(0).ReturnHuristic(i, j) >= Less Then
													If Order = 1 Then
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Bridges By Bob!")
														THIS.RefreshBoxText()
													Else
														'If Order is Brown.
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Bridges By Alice!")
														THIS.RefreshBoxText()
													End If
													'retrive table of current huristic.
													Dim TableS As Integer(,) = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
													Dim TableSS As Integer(,) = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
													'checked for Legal Movments ArgumentOutOfRangeException curnt game.
													If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
														Try
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try
															End If
														Catch t As Exception
															Log(t)
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try

															End If


														End Try
													End If
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(4, TableS, Order, BridgesOnTable(i).BridgeThinking(k).Row, BridgesOnTable(i).BridgeThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															End If

														Else
														End If

														If Order = 1 Then
															If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.BridgesOnTable(i).Row, Integer), CType(APredict.BridgesOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try

																End If
															End If
														Else
															If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(BridgesOnTable(i).Row, Integer), CType(BridgesOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try
																Else
																	Act = True
																	Less = BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j)

																	Continue Try
																End If
															End If
														End If
													End If
													RW4 = i
													CL4 = k
													Ki4 = j
													RW1 = -1
													CL1 = -1
													Ki1 = -1
													RW2 = -1
													CL2 = -1
													Ki2 = -1
													RW3 = -1
													CL3 = -1
													Ki3 = -1
													RW5 = -1
													CL5 = -1
													Ki5 = -1
													RW6 = -1
													CL6 = -1
													Ki6 = -1
													MaxLess4 = CType((BridgesOnTable(RW4).BridgeThinking(CL4).ReturnHuristic(RW4, Ki4)), Integer)
													If MaxLess4 > MaxLess1 Then
														MaxLess1 = -1
													End If
													If MaxLess4 > MaxLess2 Then
														MaxLess2 = -1
													End If
													If MaxLess4 > MaxLess3 Then
														MaxLess3 = -1
													End If
													If MaxLess4 > MaxLess5 Then
														MaxLess5 = -1
													End If
													If MaxLess4 > MaxLess6 Then
														MaxLess6 = -1
													End If


													If Depti = 1 Then
														'Set Table and Huristic Value and Syntax.
														Dim Hit As Boolean = False
														If BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
																BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
																BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = BridgesOnTable(i).BridgeThinking(k).Row
														FormRefrigtz.LastColumn = BridgesOnTable(i).BridgeThinking(k).Column

														Act = True
														Less = BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j)

														TableHuristic = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
													End If
												Else
													'Set Table and Huristic Value and Syntax.
													Try
														If Depti = 1 Then
															'TakeRoot.Pointer = this;
															'Found of Max Non Probable Movments.
															Founded.Clear()
															Dim LessB As Integer = -1000000000
															BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
															RW4 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
															CL4 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
															Ki4 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
															If Founded(0) <> MaxBridgesFounded Then
																Continue Try
															End If
															Dim Hit As Boolean = False
															If BridgesOnTable(RW4).BridgeThinking(CL4).HitNumberBridge(Ki4) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 4, BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(1), BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(0), Hit, _
																	BridgesOnTable(RW4).BridgeThinking(CL4).HitNumberBridge(Ki4), ChessRules.BridgeActBrown, False)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -4, BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(1), BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(0), Hit, _
																	BridgesOnTable(RW4).BridgeThinking(CL4).HitNumberBridge(Ki4), ChessRules.BridgeActBrown, False)
															End If

															FormRefrigtz.LastRow = BridgesOnTable(RW4).BridgeThinking(CL4).Row
															FormRefrigtz.LastColumn = BridgesOnTable(RW4).BridgeThinking(CL4).Column

															Act = True
															Less = BridgesOnTable(RW4).BridgeThinking(CL4).ReturnHuristic(RW4, Ki4)
															TableHuristic = BridgesOnTable(RW4).BridgeThinking(CL4).TableListBridge(Ki4)
														End If
													Catch t As Exception
														Log(t)
													End Try
												End If
											Catch t As Exception
												Log(t)
											End Try
										End If
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < BridgesOnTable(i).BridgeThinking(0).Dept.Count
									BridgesOnTable(i).BridgeThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While


						i = 0
						While i < AllDraw.MinisterMidle
							ThinkingChess.Kind = 5
							Dim k As Integer = 0
							While k < AllDraw.MinisterMovments
								Try
									j = 0
									While MinisterOnTable(i) IsNot Nothing AndAlso MinisterOnTable(i) IsNot Nothing AndAlso MinisterOnTable(i).MinisterThinking(k) IsNot Nothing AndAlso MinisterOnTable(i).MinisterThinking(k) IsNot Nothing AndAlso j < MinisterOnTable(i).MinisterThinking(k).TableListMinister.Count
										If True Then
											'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
											If FormRefrigtz.OrderPlate = Order Then
												If MinisterOnTable(i).MinisterThinking(k).PenaltyRegardListMinister(j).IsPenaltyAction() = 0 Then
													Continue While
												End If
											End If
											If Order <> FormRefrigtz.OrderPlate Then
												If MinisterOnTable(i).MinisterThinking(0).ReturnHuristic(i, j) >= Less Then
													Continue While
												End If
											End If
											If MinisterOnTable(i).MinisterThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Minister By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Minister By Alice!")
													THIS.RefreshBoxText()
												End If
												'retrive table of current huristic.
												Dim TableS As Integer(,) = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
												Dim TableSS As Integer(,) = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
												'checked for Legal Movments ArgumentOutOfRangeException curnt game.
												If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
													Try
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try
														End If
													Catch t As Exception
														Log(t)
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try

														End If

													End Try
												End If
												If True Then
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(5, TableS, Order, MinisterOnTable(i).MinisterThinking(k).Row, MinisterOnTable(i).MinisterThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue While
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue While
																End If
															End If

														Else
														End If
													End If

													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.MinisterOnTable(i).Row, Integer), CType(APredict.MinisterOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue While

															End If

														End If
													Else
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															If Nothing = APredict.InitiatePerdictKish(CType(APredict.MinisterOnTable(i).Row, Integer), CType(APredict.MinisterOnTable(i).Column, Integer), B, TableS, Order, False) Then
																Continue While

															End If
														End If
													End If

												End If
												RW5 = i
												CL5 = k
												Ki5 = j
												RW1 = -1
												CL1 = -1
												Ki1 = -1
												RW2 = -1
												CL2 = -1
												Ki2 = -1
												RW3 = -1
												CL3 = -1
												Ki3 = -1
												RW4 = -1
												CL4 = -1
												Ki4 = -1
												RW6 = -1
												CL6 = -1
												Ki6 = -1
												MaxLess5 = CType((MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j)), Integer)
												If MaxLess5 > MaxLess1 Then
													MaxLess1 = -1
												End If
												If MaxLess5 > MaxLess2 Then
													MaxLess2 = -1
												End If
												If MaxLess5 > MaxLess3 Then
													MaxLess3 = -1
												End If
												If MaxLess5 > MaxLess4 Then
													MaxLess4 = -1
												End If
												If MaxLess5 > MaxLess6 Then
													MaxLess6 = -1
												End If


												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Dim Hit As Boolean = False
													If MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
															MinisterOnTable(i).MinisterThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
															MinisterOnTable(i).MinisterThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
													End If

													FormRefrigtz.LastRow = MinisterOnTable(i).MinisterThinking(k).Row
													FormRefrigtz.LastColumn = MinisterOnTable(i).MinisterThinking(k).Column

													Act = True
													Less = MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j)

													TableHuristic = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
												End If
											Else
												'Set Table and Huristic Value and Syntax.
												Try
													If Depti = 1 Then
														'TakeRoot.Pointer = this;
														'Found of Max Non Probable Movments.
														Founded.Clear()
														Dim LessB As Integer = -1000000000
														BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
														RW5 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
														CL5 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
														Ki5 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
														If Founded(0) <> MaxMinisterFounded Then
															Continue Try
														End If
														Dim Hit As Boolean = False
														If MinisterOnTable(RW5).MinisterThinking(CL5).HitNumberMinister(Ki5) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 5, MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(1), MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(0), Hit, _
																MinisterOnTable(RW5).MinisterThinking(CL5).HitNumberBridge(Ki5), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -5, MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(1), MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(0), Hit, _
																MinisterOnTable(RW5).MinisterThinking(CL5).HitNumberBridge(Ki5), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = MinisterOnTable(RW5).MinisterThinking(CL5).Row
														FormRefrigtz.LastColumn = MinisterOnTable(RW5).MinisterThinking(CL5).Column

														Act = True
														Less = MinisterOnTable(RW5).MinisterThinking(CL5).ReturnHuristic(RW5, Ki5)
														TableHuristic = MinisterOnTable(RW5).MinisterThinking(CL5).TableListMinister(Ki5)
													End If
												Catch t As Exception
													Log(t)
												End Try
											End If
										End If
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < MinisterOnTable(i).MinisterThinking(0).Dept.Count
									MinisterOnTable(i).MinisterThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While

								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While

						i = 0
						While i < AllDraw.KingMidle
							ThinkingChess.Kind = 6
							Dim k As Integer = 0
							While k < AllDraw.KingMovments
								Try
									j = 0
									While KingOnTable(i) IsNot Nothing AndAlso KingOnTable(i) IsNot Nothing AndAlso KingOnTable(i).KingThinking(k) IsNot Nothing AndAlso KingOnTable(i).KingThinking(k) IsNot Nothing AndAlso j < KingOnTable(i).KingThinking(k).TableListKing.Count
										If True Then
											Try
												'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
												If FormRefrigtz.OrderPlate = Order Then
													If KingOnTable(i).KingThinking(k).PenaltyRegardListKing(j).IsPenaltyAction() = 0 Then
														Continue Try
													End If
												End If
												'When There is No Movments in Such Order Enemy continue.
												If Order <> FormRefrigtz.OrderPlate Then
													If KingOnTable(i).KingThinking(0).ReturnHuristic(i, j) >= Less Then
														Continue Try
													End If
												End If
												'When There is greater Huristic Movments.
												If KingOnTable(i).KingThinking(0).ReturnHuristic(i, j) >= Less Then
													If Order = 1 Then
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic King By Bob!")
														THIS.RefreshBoxText()
													Else
														'If Order is Brown.
														THIS.SetBoxText(vbCr & vbLf & "Chess Huristic King By Alice!")
														THIS.RefreshBoxText()
													End If
													'retrive table of current huristic.
													Dim TableS As Integer(,) = KingOnTable(i).KingThinking(k).TableListKing(j)
													Dim TableSS As Integer(,) = KingOnTable(i).KingThinking(k).TableListKing(j)
													'checked for Legal Movments ArgumentOutOfRangeException curnt game.
													If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
														Try
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try
															End If
														Catch t As Exception
															Log(t)
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try

															End If
														End Try
													End If
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(6, TableS, Order, KingOnTable(i).KingThinking(k).Row, KingOnTable(i).KingThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															End If

														Else
														End If

														'When Order is gray.
														If Order = 1 Then
															'When KishGrayAchmaz and There is not DeptFirst search.
															If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.KingOnTable(i).Row, Integer), CType(APredict.KingOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try

																End If
															End If
														Else
															If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
																'predict Search.
																Dim B As Color
																If a = Color.Gray Then
																	B = Color.Brown
																Else
																	B = Color.Gray
																End If
																APredict.TableList.Clear()
																APredict.TableList.Add(TableS)
																APredict.SetRowColumn(0)
																TableHuristic = APredict.InitiatePerdictKish(CType(APredict.KingOnTable(i).Row, Integer), CType(APredict.KingOnTable(i).Column, Integer), B, TableS, Order, False)
																If TableHuristic Is Nothing Then
																	Continue Try
																Else
																	Act = True
																	Less = KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)
																	Continue Try

																End If
															End If

														End If
													End If


													RW6 = i
													CL6 = k
													Ki6 = j
													RW1 = -1
													CL1 = -1
													Ki1 = -1
													RW2 = -1
													CL2 = -1
													Ki2 = -1
													RW3 = -1
													CL3 = -1
													Ki3 = -1
													RW4 = -1
													CL4 = -1
													Ki4 = -1
													RW5 = -1
													CL5 = -1
													Ki5 = -1
													MaxLess6 = CType((KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)), Integer)
													If MaxLess6 > MaxLess1 Then
														MaxLess1 = -1
													End If
													If MaxLess6 > MaxLess2 Then
														MaxLess2 = -1
													End If
													If MaxLess6 > MaxLess3 Then
														MaxLess3 = -1
													End If
													If MaxLess6 > MaxLess4 Then
														MaxLess4 = -1
													End If
													If MaxLess6 > MaxLess5 Then
														MaxLess5 = -1
													End If


													If Depti = 1 Then
														'Set Table and Huristic Value and Syntax.
														Dim Hit As Boolean = False
														If KingOnTable(i).KingThinking(k).HitNumberKing(j) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
																KingOnTable(i).KingThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
																KingOnTable(i).KingThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = KingOnTable(i).KingThinking(k).Row
														FormRefrigtz.LastColumn = KingOnTable(i).KingThinking(k).Column

														Act = True
														Less = KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)
														TableHuristic = KingOnTable(i).KingThinking(k).TableListKing(j)


													End If
												Else
													'Set Table and Huristic Value and Syntax.
													Try
														If Depti = 1 Then
															'TakeRoot.Pointer = this;
															'Found of Max Non Probable Movments.
															Founded.Clear()
															Dim LessB As Integer = -1000000000
															BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
															RW6 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
															CL6 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
															Ki6 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
															If Founded(0) <> MaxKingFounded Then
																Continue Try
															End If
															Dim Hit As Boolean = False
															If KingOnTable(RW6).KingThinking(CL6).HitNumberKing(Ki6) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 6, KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(1), KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(0), Hit, _
																	KingOnTable(RW6).KingThinking(CL6).HitNumberKing(Ki6), ChessRules.BridgeActBrown, False)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -6, KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(1), KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(0), Hit, _
																	KingOnTable(RW6).KingThinking(CL6).HitNumberKing(Ki6), ChessRules.BridgeActBrown, False)
															End If

															FormRefrigtz.LastRow = KingOnTable(RW6).KingThinking(CL6).Row
															FormRefrigtz.LastColumn = KingOnTable(RW6).KingThinking(CL6).Column

															Act = True
															Less = KingOnTable(RW6).KingThinking(CL6).ReturnHuristic(RW6, Ki6)
															TableHuristic = KingOnTable(RW6).KingThinking(CL6).TableListKing(Ki6)
														End If
													Catch t As Exception
														Log(t)
													End Try
												End If
											Catch t As Exception
												Log(t)
											End Try
										End If
										' else
										If True Then

										End If
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < KingOnTable(i).KingThinking(0).Dept.Count
									KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While

								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1

						End While
					Else
						'For Every Soldeir
						i = SodierMidle
						While i < AllDraw.SodierHigh

							ThinkingChess.Kind = -1
							'For Every Soldier Movments Dept.
							Dim k As Integer = 0
							While k < AllDraw.SodierMovments
								'When There is an Movment in such situation.
								Try
									j = 0
									While SolderesOnTable(i) IsNot Nothing AndAlso SolderesOnTable(i) IsNot Nothing AndAlso SolderesOnTable(i).SoldierThinking(k) IsNot Nothing AndAlso SolderesOnTable(i).SoldierThinking(k) IsNot Nothing AndAlso j < SolderesOnTable(i).SoldierThinking(k).TableListSolder.Count
										Try
											ThinkingChess.Kind = -1
											'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
											If FormRefrigtz.OrderPlate = Order Then
												If SolderesOnTable(i).SoldierThinking(k).PenaltyRegardListSolder(j).IsPenaltyAction() = 0 Then
													Continue Try
												End If
											End If
											'When There is No Movments in Such Order Enemy continue.
											If Order <> FormRefrigtz.OrderPlate Then
												If SolderesOnTable(i).SoldierThinking(0).ReturnHuristic(i, j) >= Less Then
													Continue Try
												End If
											End If
											'When There is greater Huristic Movments.
											If SolderesOnTable(i).SoldierThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Sodier By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Sodier By Alice!")
													THIS.RefreshBoxText()
												End If
												'if (KishG || KishB)
												'{
												'retrive table of current huristic.
												Dim TableS As Integer(,) = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)

												'checked for Legal Movments ArgumentOutOfRangeException curnt game.
												If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
													Try
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try
														End If
													Catch t As Exception
														Log(t)
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try

														End If
													End Try
												End If
												'When there is not Penalty regard mechanism.
												If Not ThinkingChess.UsePenaltyRegardMechnisam Then
													'If there is kish or kshachamaz Order.
													If (New ChessRules(1, TableS, Order, SolderesOnTable(i).SoldierThinking(k).Row, SolderesOnTable(i).SoldierThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
														'When Order is Gray.
														If Order = 1 Then
															'Continue When is kish KishAchmaz and DeptFirstSearch .
															If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														Else
															'Continue when KishBrown and DeptFirstSearch. 
															If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														End If
													Else

														' }
													End If
													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.SolderesOnTable(i).Row, Integer), CType(APredict.SolderesOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try
															Else
																Act = True
																Less = SolderesOnTable(i).SoldierThinking(k).ReturnHuristic(i, j)



																Continue Try

															End If
														End If
													Else
														'When Order is Bromn and there is not DeptFirstSearch.
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'Prdedict Kish.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.SolderesOnTable(i).Row, Integer), CType(APredict.SolderesOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try

															End If
														End If
													End If
												End If
												RW1 = i
												CL1 = k
												Ki1 = j
												RW2 = -1
												CL2 = -1
												Ki2 = -1
												RW3 = -1
												CL3 = -1
												Ki3 = -1
												RW4 = -1
												CL4 = -1
												Ki4 = -1
												RW5 = -1
												CL5 = -1
												Ki5 = -1
												RW6 = -1
												CL6 = -1
												Ki6 = -1
												MaxLess1 = CType((SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(0) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(1) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(2) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(3)), Integer)
												If MaxLess1 > MaxLess2 Then
													MaxLess2 = -1
												End If
												If MaxLess1 > MaxLess3 Then
													MaxLess3 = -1
												End If
												If MaxLess1 > MaxLess4 Then
													MaxLess4 = -1
												End If
												If MaxLess1 > MaxLess5 Then
													MaxLess5 = -1
												End If
												If MaxLess1 > MaxLess6 Then
													MaxLess6 = -1
												End If

												'Set Table and Huristic Value and Syntax.
												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Act = True
													FormRefrigtz.LastRow = SolderesOnTable(i).SoldierThinking(k).Row
													FormRefrigtz.LastColumn = SolderesOnTable(i).SoldierThinking(k).Column

													Less = SolderesOnTable(i).SoldierThinking(k).ReturnHuristic(i, j)


													TableHuristic = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)
													Dim Hit As Boolean = False
													If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
															SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
															SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
													End If


													ThingsConverter.ActOfClickEqualTow = True
													SolderesOnTable(i).ConvertOperation(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), a, SolderesOnTable(i).SoldierThinking(k).TableListSolder(j), Order, False, _
														i)
													Dim Sign As Integer = 1
													If a = Color.Brown Then
														Sign = -1
													End If
													'If there is Soldier Convert.
													If SolderesOnTable(i).Convert Then
														Hit = False
														If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
																SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
																SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
														End If

														If SolderesOnTable(i).ConvertedToMinister Then
															TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 5 * Sign
														ElseIf SolderesOnTable(i).ConvertedToBridge Then
															TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 4 * Sign
														ElseIf SolderesOnTable(i).ConvertedToHourse Then
															TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 3 * Sign
														ElseIf SolderesOnTable(i).ConvertedToElefant Then
															TableHuristic(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 2 * Sign
														End If
														TableList.Clear()
														TableList.Add(TableHuristic)
														If A.Count > 1 Then
															SetRowColumn(0)
														End If

														TableList.Clear()

													End If
												Else
													'Set Table and Huristic Value and Syntax.
													Try
														If Depti = 1 Then
															'TakeRoot.Pointer = this;
															'Found of Max Non Probable Movments.
															Founded.Clear()
															Dim LessB As Integer = -1000000000
															BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
															RW1 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
															CL1 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
															Ki1 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
															If Founded(0) <> MaxSoldeirFounded Then
																Continue Try
															End If
															Act = True
															FormRefrigtz.LastRow = SolderesOnTable(RW1).SoldierThinking(CL1).Row
															FormRefrigtz.LastColumn = SolderesOnTable(RW1).SoldierThinking(CL1).Column

															Less = SolderesOnTable(RW1).SoldierThinking(CL1).ReturnHuristic(RW1, Ki1)


															TableHuristic = SolderesOnTable(RW1).SoldierThinking(CL1).TableListSolder(Ki1)
															Dim Hit As Boolean = False
															If SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1) > 0 Then
																Hit = True
															End If
															If Order = 1 Then
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																	SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, False)
															Else
																SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																	SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, False)
															End If


															ThingsConverter.ActOfClickEqualTow = True
															SolderesOnTable(RW1).ConvertOperation(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), a, SolderesOnTable(RW1).SoldierThinking(CL1).TableListSolder(Ki1), Order, False, _
																i)
															Dim Sign As Integer = 1
															If a = Color.Brown Then
																Sign = -1
															End If
															'If there is Soldier Convert.
															If SolderesOnTable(RW1).Convert Then
																Hit = False
																If SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1) > 0 Then
																	Hit = True
																End If
																If Order = 1 Then
																	SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																		SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, True)
																Else
																	SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), Hit, _
																		SolderesOnTable(RW1).SoldierThinking(CL1).HitNumberSoldier(Ki1), ChessRules.BridgeActBrown, True)
																End If

																If SolderesOnTable(RW1).ConvertedToMinister Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 5 * Sign
																ElseIf SolderesOnTable(RW1).ConvertedToBridge Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 4 * Sign
																ElseIf SolderesOnTable(RW1).ConvertedToHourse Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 3 * Sign
																ElseIf SolderesOnTable(RW1).ConvertedToElefant Then
																	TableHuristic(SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(0), SolderesOnTable(RW1).SoldierThinking(CL1).RowColumnSoldier(Ki1)(1)) = 2 * Sign
																End If
																TableList.Clear()
																TableList.Add(TableHuristic)
																If A.Count > 1 Then
																	SetRowColumn(0)
																End If
																TableList.Clear()
															End If
														End If
													Catch t As Exception
														Log(t)

													End Try
												End If
											End If
										Catch t As Exception
											Log(t)
										End Try
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < SolderesOnTable(i).SoldierThinking(0).Dept.Count
									SolderesOnTable(i).SoldierThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While
						'Do For Remaining Objects same as Soldeir Documentation.
						i = ElefantMidle
						While i < AllDraw.ElefantHigh
							ThinkingChess.Kind = -2
							Dim k As Integer = 0
							While k < AllDraw.ElefantMovments
								Try
									j = 0
									While ElephantOnTable(i) IsNot Nothing AndAlso ElephantOnTable(i) IsNot Nothing AndAlso ElephantOnTable(i).ElefantThinking(k) IsNot Nothing AndAlso ElephantOnTable(i).ElefantThinking(k) IsNot Nothing AndAlso j < ElephantOnTable(i).ElefantThinking(k).TableListElefant.Count
										Try
											'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
											If FormRefrigtz.OrderPlate = Order Then
												If ElephantOnTable(i).ElefantThinking(k).PenaltyRegardListElefant(j).IsPenaltyAction() = 0 Then
													Continue Try
												End If
											End If
											'When There is No Movments in Such Order Enemy continue.
											If ElephantOnTable(i).ElefantThinking(k).PenaltyRegardListElefant(j).IsPenaltyAction() = 0 Then
												Continue Try
											End If
											'When There is No Movments in Such Order Enemy continue.
											If Order <> FormRefrigtz.OrderPlate Then
												If ElephantOnTable(i).ElefantThinking(0).ReturnHuristic(i, j) >= Less Then
													Continue Try
												End If
											End If
											'When There is greater Huristic Movments.
											If ElephantOnTable(i).ElefantThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Elephant By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Elephant By Alice!")
													THIS.RefreshBoxText()
												End If
												'if (KishG || KishB)
												'{
												'retrive table of current huristic.
												Dim TableS As Integer(,) = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
												'checked for Legal Movments ArgumentOutOfRangeException curnt game.
												If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
													Try
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try
														End If
													Catch t As Exception
														Log(t)
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try

														End If
													End Try
												End If
												'When there is not Penalty regard mechanism.
												If Not ThinkingChess.UsePenaltyRegardMechnisam Then
													'If there is kish or kshachamaz Order.
													If (New ChessRules(2, TableS, Order, ElephantOnTable(i).ElefantThinking(k).Row, ElephantOnTable(i).ElefantThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
														'When Order is Gray.
														If Order = 1 Then
															'Continue When is kish KishAchmaz and DeptFirstSearch .
															If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														Else
															'Continue when KishBrown and DeptFirstSearch. 
															If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														End If

													Else
													End If

													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.ElephantOnTable(i).Row, Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try
															Else
																Act = True

																Less = ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j)
															End If
														End If
													Else
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.ElephantOnTable(i).Row, Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try


															End If
														End If

													End If
												End If
												RW2 = i
												CL2 = k
												Ki2 = j
												RW1 = -1
												CL1 = -1
												Ki1 = -1
												RW3 = -1
												CL3 = -1
												Ki3 = -1
												RW4 = -1
												CL4 = -1
												Ki4 = -1
												RW5 = -1
												CL5 = -1
												Ki5 = -1
												RW6 = -1
												CL6 = -1
												Ki6 = -1
												MaxLess2 = CType((ElephantOnTable(RW2).ElefantThinking(CL2).ReturnHuristic(RW2, Ki2)), Integer)
												If MaxLess2 > MaxLess1 Then
													MaxLess1 = -1
												End If
												If MaxLess2 > MaxLess3 Then
													MaxLess3 = -1
												End If
												If MaxLess2 > MaxLess4 Then
													MaxLess4 = -1
												End If
												If MaxLess2 > MaxLess5 Then
													MaxLess5 = -1
												End If
												If MaxLess2 > MaxLess6 Then
													MaxLess6 = -1
												End If
												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Dim Hit As Boolean = False
													If ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
															ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
															ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
													End If

													FormRefrigtz.LastRow = ElephantOnTable(i).ElefantThinking(k).Row
													FormRefrigtz.LastColumn = ElephantOnTable(i).ElefantThinking(k).Column

													Act = True
													Less = ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j)

													TableHuristic = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
												End If
											Else
												'Set Table and Huristic Value and Syntax.
												Try
													If Depti = 1 Then
														'TakeRoot.Pointer = this;
														'Found of Max Non Probable Movments.
														Founded.Clear()
														Dim LessB As Integer = -1000000000
														BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
														RW2 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
														CL2 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
														Ki2 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
														If Founded(0) <> MaxElephntFounded Then
															Continue Try
														End If
														Dim Hit As Boolean = False
														If ElephantOnTable(RW2).ElefantThinking(CL2).HitNumberElefant(Ki2) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 2, ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(1), ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(0), Hit, _
																ElephantOnTable(RW2).ElefantThinking(CL2).HitNumberElefant(Ki2), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -2, ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(1), ElephantOnTable(RW2).ElefantThinking(CL2).RowColumnElefant(Ki2)(0), Hit, _
																ElephantOnTable(RW2).ElefantThinking(CL2).HitNumberElefant(Ki2), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = ElephantOnTable(RW2).ElefantThinking(CL2).Row
														FormRefrigtz.LastColumn = ElephantOnTable(RW2).ElefantThinking(CL2).Column

														Act = True
														Less = ElephantOnTable(RW2).ElefantThinking(CL2).ReturnHuristic(RW2, Ki2)
														TableHuristic = ElephantOnTable(RW2).ElefantThinking(CL2).TableListElefant(Ki2)
													End If
												Catch t As Exception
													Log(t)

												End Try

											End If
										Catch t As Exception
											Log(t)
										End Try
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < ElephantOnTable(i).ElefantThinking(0).Dept.Count
									ElephantOnTable(i).ElefantThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While

						i = HourseMidle
						While i < AllDraw.HourseHight
							ThinkingChess.Kind = -3
							Dim k As Integer = 0
							While k < AllDraw.HourseMovments
								Try
									j = 0
									While HoursesOnTable(i) IsNot Nothing AndAlso HoursesOnTable(i) IsNot Nothing AndAlso HoursesOnTable(i).HourseThinking(k) IsNot Nothing AndAlso HoursesOnTable(i).HourseThinking(k) IsNot Nothing AndAlso j < HoursesOnTable(i).HourseThinking(k).TableListHourse.Count
										Try
											'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
											If FormRefrigtz.OrderPlate = Order Then
												If HoursesOnTable(i).HourseThinking(k).PenaltyRegardListHourse(j).IsPenaltyAction() = 0 Then
													Continue Try
												End If
											End If
											'When There is No Movments in Such Order Enemy continue.
											If Order <> FormRefrigtz.OrderPlate Then
												If HoursesOnTable(i).HourseThinking(0).ReturnHuristic(i, j) >= Less Then

													Continue Try
												End If
											End If
											'When There is greater Huristic Movments.
											If HoursesOnTable(i).HourseThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Hourse By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Hourse By Alice!")
													THIS.RefreshBoxText()
												End If
												'retrive table of current huristic.
												Dim TableS As Integer(,) = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
												If True Then
													'checked for Legal Movments ArgumentOutOfRangeException curnt game.
													If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
														Try
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try
															End If
														Catch t As Exception
															Log(t)
															If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
																Continue Try

															End If

														End Try
													End If
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(3, TableS, Order, HoursesOnTable(i).HourseThinking(k).Row, HoursesOnTable(i).HourseThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															End If

														Else
														End If
													End If


													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.HoursesOnTable(i).Row, Integer), CType(APredict.HoursesOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try

															End If
														End If
													Else
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.HoursesOnTable(i).Row, Integer), CType(APredict.HoursesOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try
															Else
																Act = True
																Less = HoursesOnTable(i).HourseThinking(k).ReturnHuristic(i, j)
																Continue Try

															End If
														End If
													End If
												End If
												RW3 = i
												CL3 = k
												Ki3 = j
												MaxLess3 = CType((HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(0) + HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(1) + HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(2) + HoursesOnTable(RW3).HourseThinking(CL3).HuristicListHourse(Ki3)(3)), Integer)
												

												If MaxLess3 > MaxLess1 Then
													MaxLess1 = -1
												End If
												If MaxLess3 > MaxLess2 Then
													MaxLess2 = -1
												End If
												If MaxLess3 > MaxLess4 Then
													MaxLess4 = -1
												End If
												If MaxLess3 > MaxLess5 Then
													MaxLess5 = -1
												End If
												If MaxLess3 > MaxLess6 Then
													MaxLess6 = -1
												End If

												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Dim Hit As Boolean = False
													If HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
															HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
															HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
													End If
													FormRefrigtz.LastRow = HoursesOnTable(i).HourseThinking(k).Row
													FormRefrigtz.LastColumn = HoursesOnTable(i).HourseThinking(k).Column

													Act = True
													Less = HoursesOnTable(i).HourseThinking(k).ReturnHuristic(i, j)

													TableHuristic = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
												End If
											Else
												'Set Table and Huristic Value and Syntax.
												Try
													If Depti = 1 Then
														'TakeRoot.Pointer = this;
														'Found of Max Non Probable Movments.
														Founded.Clear()
														Dim LessB As Integer = -1000000000
														BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
														RW3 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
														CL3 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
														Ki3 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
														If Founded(0) <> MaxHourseFounded Then
															Continue Try
														End If
														Dim Hit As Boolean = False
														If HoursesOnTable(RW3).HourseThinking(CL3).HitNumberHourse(Ki3) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 3, HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(1), HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(0), Hit, _
																HoursesOnTable(RW3).HourseThinking(CL3).HitNumberHourse(Ki3), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -3, HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(1), HoursesOnTable(RW3).HourseThinking(CL3).RowColumnHourse(Ki3)(0), Hit, _
																HoursesOnTable(RW3).HourseThinking(CL3).HitNumberHourse(Ki3), ChessRules.BridgeActBrown, False)
														End If
														FormRefrigtz.LastRow = HoursesOnTable(RW3).HourseThinking(CL3).Row
														FormRefrigtz.LastColumn = HoursesOnTable(RW3).HourseThinking(CL3).Column

														Act = True
														Less = HoursesOnTable(RW3).HourseThinking(CL3).ReturnHuristic(RW3, Ki3)
														TableHuristic = HoursesOnTable(RW3).HourseThinking(CL3).TableListHourse(Ki3)
													End If
												Catch t As Exception
													Log(t)


												End Try

											End If
										Catch t As Exception
											Log(t)
										End Try
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < HoursesOnTable(i).HourseThinking(0).Dept.Count
									HoursesOnTable(i).HourseThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While

						i = BridgeMidle
						While i < AllDraw.BridgeHigh
							ThinkingChess.Kind = -4
							Dim k As Integer = 0
							While k < AllDraw.BridgeMovments
								Try
									j = 0
									While BridgesOnTable(i) IsNot Nothing AndAlso BridgesOnTable(i) IsNot Nothing AndAlso BridgesOnTable(i).BridgeThinking(k) IsNot Nothing AndAlso BridgesOnTable(i).BridgeThinking(k) IsNot Nothing AndAlso j < BridgesOnTable(i).BridgeThinking(k).TableListBridge.Count
										Try
											'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
											If FormRefrigtz.OrderPlate = Order Then
												If BridgesOnTable(i).BridgeThinking(k).PenaltyRegardListBridge(j).IsPenaltyAction() = 0 Then
													Continue Try
												End If
											End If
											If Order <> FormRefrigtz.OrderPlate Then
												If BridgesOnTable(i).BridgeThinking(0).ReturnHuristic(i, j) >= Less Then
													Continue Try
												End If
											End If
											'When There is greater Huristic Movments.
											If BridgesOnTable(i).BridgeThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Bridges By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Bridges By Alice!")
													THIS.RefreshBoxText()
												End If
												'retrive table of current huristic.
												Dim TableS As Integer(,) = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
												'checked for Legal Movments ArgumentOutOfRangeException curnt game.
												If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
													Try
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try
														End If
													Catch t As Exception
														Log(t)
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try

														End If

													End Try
												End If
												'When there is not Penalty regard mechanism.
												If Not ThinkingChess.UsePenaltyRegardMechnisam Then
													'If there is kish or kshachamaz Order.
													If (New ChessRules(4, TableS, Order, BridgesOnTable(i).BridgeThinking(k).Row, BridgesOnTable(i).BridgeThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
														'When Order is Gray.
														If Order = 1 Then
															'Continue When is kish KishAchmaz and DeptFirstSearch .
															If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														Else
															'Continue when KishBrown and DeptFirstSearch. 
															If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														End If

													Else
													End If

													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.BridgesOnTable(i).Row, Integer), CType(APredict.BridgesOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try

															End If
														End If
													Else
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(BridgesOnTable(i).Row, Integer), CType(BridgesOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try
															Else
																Act = True
																Less = BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j)


																Continue Try
															End If
														End If
													End If
												End If
												RW4 = i
												CL4 = k
												Ki4 = j
												RW1 = -1
												CL1 = -1
												Ki1 = -1
												RW2 = -1
												CL2 = -1
												Ki2 = -1
												RW3 = -1
												CL3 = -1
												Ki3 = -1
												RW5 = -1
												CL5 = -1
												Ki5 = -1
												RW6 = -1
												CL6 = -1
												Ki6 = -1
												MaxLess4 = CType((BridgesOnTable(RW4).BridgeThinking(CL4).ReturnHuristic(RW4, Ki4)), Integer)
												If MaxLess4 > MaxLess1 Then
													MaxLess1 = -1
												End If
												If MaxLess4 > MaxLess2 Then
													MaxLess2 = -1
												End If
												If MaxLess4 > MaxLess3 Then
													MaxLess3 = -1
												End If
												If MaxLess4 > MaxLess5 Then
													MaxLess5 = -1
												End If
												If MaxLess4 > MaxLess6 Then
													MaxLess6 = -1
												End If

												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Dim Hit As Boolean = False
													If BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
															BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
															BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
													End If

													FormRefrigtz.LastRow = BridgesOnTable(i).BridgeThinking(k).Row
													FormRefrigtz.LastColumn = BridgesOnTable(i).BridgeThinking(k).Column

													Act = True
													Less = BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j)

													TableHuristic = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
												End If
											Else
												'Set Table and Huristic Value and Syntax.
												Try
													If Depti = 1 Then
														'TakeRoot.Pointer = this;
														'Found of Max Non Probable Movments.
														Founded.Clear()
														Dim LessB As Integer = -1000000000
														BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
														RW4 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
														CL4 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
														Ki4 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
														If Founded(0) <> MaxBridgesFounded Then
															Continue Try
														End If
														Dim Hit As Boolean = False
														If BridgesOnTable(RW4).BridgeThinking(CL4).HitNumberBridge(Ki4) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 4, BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(1), BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(0), Hit, _
																BridgesOnTable(RW4).BridgeThinking(CL4).HitNumberBridge(Ki4), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -4, BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(1), BridgesOnTable(RW4).BridgeThinking(CL4).RowColumnBridge(Ki4)(0), Hit, _
																BridgesOnTable(RW4).BridgeThinking(CL4).HitNumberBridge(Ki4), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = BridgesOnTable(RW4).BridgeThinking(CL4).Row
														FormRefrigtz.LastColumn = BridgesOnTable(RW4).BridgeThinking(CL4).Column

														Act = True
														Less = BridgesOnTable(RW4).BridgeThinking(CL4).ReturnHuristic(RW4, Ki4)
														TableHuristic = BridgesOnTable(RW4).BridgeThinking(CL4).TableListBridge(Ki4)
													End If
												Catch t As Exception
													Log(t)

												End Try
											End If
										Catch t As Exception
											Log(t)
										End Try
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < BridgesOnTable(i).BridgeThinking(0).Dept.Count
									BridgesOnTable(i).BridgeThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try
							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While


						i = MinisterMidle
						While i < AllDraw.MinisterHigh
							ThinkingChess.Kind = -5
							Dim k As Integer = 0
							While k < AllDraw.MinisterMovments
								Try
									j = 0
									While MinisterOnTable(i) IsNot Nothing AndAlso MinisterOnTable(i) IsNot Nothing AndAlso MinisterOnTable(i).MinisterThinking(k) IsNot Nothing AndAlso MinisterOnTable(i).MinisterThinking(k) IsNot Nothing AndAlso j < MinisterOnTable(i).MinisterThinking(k).TableListMinister.Count
										Try
											'For Penalty Reagrad Mechanisam of Current Kish Mate Current Movments.
											If FormRefrigtz.OrderPlate = Order Then
												If MinisterOnTable(i).MinisterThinking(k).PenaltyRegardListMinister(j).IsPenaltyAction() = 0 Then
													Continue Try
												End If
											End If
											'When There is No Movments in Such Order Enemy continue.
											If Order <> FormRefrigtz.OrderPlate Then
												If MinisterOnTable(i).MinisterThinking(0).ReturnHuristic(i, j) >= Less Then
													Continue Try
												End If
											End If
											'When There is greater Huristic Movments.
											If MinisterOnTable(i).MinisterThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Minister By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic Minister By Alice!")
													THIS.RefreshBoxText()
												End If
												'retrive table of current huristic.
												Dim TableS As Integer(,) = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
												'checked for Legal Movments ArgumentOutOfRangeException curnt game.
												If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
													Try
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try
														End If
													Catch t As Exception
														Log(t)
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try

														End If
													End Try
												End If
												If True Then
													'When there is not Penalty regard mechanism.
													If Not ThinkingChess.UsePenaltyRegardMechnisam Then
														'If there is kish or kshachamaz Order.
														If (New ChessRules(5, TableS, Order, MinisterOnTable(i).MinisterThinking(k).Row, MinisterOnTable(i).MinisterThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
															'When Order is Gray.
															If Order = 1 Then
																'Continue When is kish KishAchmaz and DeptFirstSearch .
																If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															Else
																'Continue when KishBrown and DeptFirstSearch. 
																If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																	Continue Try
																End If
															End If

														Else
														End If
													End If

													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.MinisterOnTable(i).Row, Integer), CType(APredict.MinisterOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try
															Else
																Act = True
																Less = MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j)
																Continue Try
															End If

														End If
													Else
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															If Nothing = APredict.InitiatePerdictKish(CType(APredict.MinisterOnTable(i).Row, Integer), CType(APredict.MinisterOnTable(i).Column, Integer), B, TableS, Order, False) Then
																Continue Try

															End If
														End If
													End If

												End If
												RW5 = i
												CL5 = k
												Ki5 = j
												RW1 = -1
												CL1 = -1
												Ki1 = -1
												RW2 = -1
												CL2 = -1
												Ki2 = -1
												RW3 = -1
												CL3 = -1
												Ki3 = -1
												RW4 = -1
												CL4 = -1
												Ki4 = -1
												RW6 = -1
												CL6 = -1
												Ki6 = -1
												MaxLess5 = CType((MinisterOnTable(RW5).MinisterThinking(CL5).ReturnHuristic(RW5, Ki5)), Integer)
												If MaxLess5 > MaxLess1 Then
													MaxLess1 = -1
												End If
												If MaxLess5 > MaxLess2 Then
													MaxLess2 = -1
												End If
												If MaxLess5 > MaxLess3 Then
													MaxLess3 = -1
												End If
												If MaxLess5 > MaxLess4 Then
													MaxLess4 = -1
												End If
												If MaxLess5 > MaxLess6 Then
													MaxLess6 = -1
												End If
												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Dim Hit As Boolean = False
													If MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
															MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
															MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j), ChessRules.BridgeActBrown, False)
													End If

													FormRefrigtz.LastRow = MinisterOnTable(i).MinisterThinking(k).Row
													FormRefrigtz.LastColumn = MinisterOnTable(i).MinisterThinking(k).Column

													Act = True
													Less = MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j)

													TableHuristic = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
												End If
											Else
												'Set Table and Huristic Value and Syntax.
												Try
													If Depti = 1 Then
														'TakeRoot.Pointer = this;
														'Found of Max Non Probable Movments.
														Founded.Clear()
														Dim LessB As Integer = -1000000000
														BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
														RW5 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
														CL5 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
														Ki5 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
														If Founded(0) <> MaxMinisterFounded Then
															Continue Try
														End If
														Dim Hit As Boolean = False
														If MinisterOnTable(RW5).MinisterThinking(CL5).HitNumberMinister(Ki5) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 5, MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(1), MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(0), Hit, _
																MinisterOnTable(RW5).MinisterThinking(CL5).HitNumberBridge(Ki5), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -5, MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(1), MinisterOnTable(RW5).MinisterThinking(CL5).RowColumnMinister(Ki5)(0), Hit, _
																MinisterOnTable(RW5).MinisterThinking(CL5).HitNumberBridge(Ki5), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = MinisterOnTable(RW5).MinisterThinking(CL5).Row
														FormRefrigtz.LastColumn = MinisterOnTable(RW5).MinisterThinking(CL5).Column

														Act = True
														Less = MinisterOnTable(RW5).MinisterThinking(CL5).ReturnHuristic(RW5, Ki5)
														TableHuristic = MinisterOnTable(RW5).MinisterThinking(CL5).TableListMinister(Ki5)
													End If
												Catch t As Exception
													Log(t)
												End Try
											End If
										Catch t As Exception
											Log(t)
										End Try
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < MinisterOnTable(i).MinisterThinking(0).Dept.Count
									MinisterOnTable(i).MinisterThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While

						i = KingMidle
						While i < AllDraw.KingHigh
							ThinkingChess.Kind = -6
							Dim k As Integer = 0
							While k < AllDraw.KingMovments
								Try
									j = 0
									While KingOnTable(i) IsNot Nothing AndAlso KingOnTable(i) IsNot Nothing AndAlso KingOnTable(i).KingThinking(k) IsNot Nothing AndAlso KingOnTable(i).KingThinking(k) IsNot Nothing AndAlso j < KingOnTable(i).KingThinking(k).TableListKing.Count
										Try

											If FormRefrigtz.OrderPlate = Order Then
												If KingOnTable(i).KingThinking(k).PenaltyRegardListKing(j).IsPenaltyAction() = 0 Then
													Continue Try
												End If
											End If
											'When There is No Movments in Such Order Enemy continue.
											If Order <> FormRefrigtz.OrderPlate Then
												If KingOnTable(i).KingThinking(0).ReturnHuristic(i, j) >= Less Then
													Continue Try
												End If
											End If
											'When There is greater Huristic Movments.
											If KingOnTable(i).KingThinking(0).ReturnHuristic(i, j) >= Less Then
												If Order = 1 Then
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic King By Bob!")
													THIS.RefreshBoxText()
												Else
													'If Order is Brown.
													THIS.SetBoxText(vbCr & vbLf & "Chess Huristic King By Alice!")
													THIS.RefreshBoxText()
												End If
												'retrive table of current huristic.
												Dim TableS As Integer(,) = KingOnTable(i).KingThinking(k).TableListKing(j)
												'checked for Legal Movments ArgumentOutOfRangeException curnt game.
												If DynamicDeptFirstPrograming AndAlso Not CurrentTableHuristic AndAlso Depti = 1 Then
													Try
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try
														End If
													Catch t As Exception
														Log(t)
														If Not isEnemyThingsinStable(TableS, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), FormRefrigtz.OrderPlate) Then
															Continue Try

														End If

													End Try
												End If
												'When there is not Penalty regard mechanism.
												If Not ThinkingChess.UsePenaltyRegardMechnisam Then
													'If there is kish or kshachamaz Order.
													If (New ChessRules(6, TableS, Order, KingOnTable(i).KingThinking(k).Row, KingOnTable(i).KingThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
														'When Order is Gray.
														If Order = 1 Then
															'Continue When is kish KishAchmaz and DeptFirstSearch .
															If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														Else
															'Continue when KishBrown and DeptFirstSearch. 
															If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
																Continue Try
															End If
														End If

													Else
													End If

													'When Order is gray.
													If Order = 1 Then
														'When KishGrayAchmaz and There is not DeptFirst search.
														If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.KingOnTable(i).Row, Integer), CType(APredict.KingOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try

															End If
														End If
													Else
														If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
															'predict Search.
															Dim B As Color
															If a = Color.Gray Then
																B = Color.Brown
															Else
																B = Color.Gray
															End If
															APredict.TableList.Clear()
															APredict.TableList.Add(TableS)
															APredict.SetRowColumn(0)
															TableHuristic = APredict.InitiatePerdictKish(CType(APredict.KingOnTable(i).Row, Integer), CType(APredict.KingOnTable(i).Column, Integer), B, TableS, Order, False)
															If TableHuristic Is Nothing Then
																Continue Try
															Else
																Act = True
																Less = KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)
																Continue Try

															End If
														End If

													End If
												End If
												RW6 = i
												CL6 = k
												Ki6 = j
												RW1 = -1
												CL1 = -1
												Ki1 = -1
												RW2 = -1
												CL2 = -1
												Ki2 = -1
												RW3 = -1
												CL3 = -1
												Ki3 = -1
												RW4 = -1
												CL4 = -1
												Ki4 = -1
												RW5 = -1
												CL5 = -1
												Ki5 = -1
												MaxLess6 = CType((KingOnTable(i).KingThinking(k).HuristicListKing(j)(0) + KingOnTable(i).KingThinking(k).HuristicListKing(j)(1) + KingOnTable(i).KingThinking(k).HuristicListKing(j)(2) + KingOnTable(i).KingThinking(k).HuristicListKing(j)(3)), Integer)
												If MaxLess6 > MaxLess1 Then
													MaxLess1 = -1
												End If
												If MaxLess6 > MaxLess2 Then
													MaxLess2 = -1
												End If
												If MaxLess6 > MaxLess3 Then
													MaxLess3 = -1
												End If
												If MaxLess6 > MaxLess4 Then
													MaxLess4 = -1
												End If
												If MaxLess6 > MaxLess5 Then
													MaxLess5 = -1
												End If
												If Depti = 1 Then
													'Set Table and Huristic Value and Syntax.
													Dim Hit As Boolean = False
													If KingOnTable(i).KingThinking(k).HitNumberKing(j) > 0 Then
														Hit = True
													End If
													If Order = 1 Then
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
															KingOnTable(i).KingThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
													Else
														SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
															KingOnTable(i).KingThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
													End If

													FormRefrigtz.LastRow = KingOnTable(i).KingThinking(k).Row
													FormRefrigtz.LastColumn = KingOnTable(i).KingThinking(k).Column

													Act = True
													Less = KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)

													TableHuristic = KingOnTable(i).KingThinking(k).TableListKing(j)
												End If
											Else
												'Set Table and Huristic Value and Syntax.
												Try
													If Depti = 1 Then
														'TakeRoot.Pointer = this;
														'Found of Max Non Probable Movments.
														Founded.Clear()
														Dim LessB As Integer = -1000000000
														BeginIndexFoundingMaxLessofMaxList(0, Founded, LessB)
														If Founded(0) <> 1 Then
															Continue Try
														End If
														RW6 = MaxHuristicDeptFirstBackWard(0)(Founded(0))
														CL6 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 1)
														Ki6 = MaxHuristicDeptFirstBackWard(0)(Founded(0) + 2)
														If Founded(0) <> MaxKingFounded Then
															Continue Try
														End If
														Dim Hit As Boolean = False
														If KingOnTable(RW6).KingThinking(CL6).HitNumberKing(Ki6) > 0 Then
															Hit = True
														End If
														If Order = 1 Then
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, 6, KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(1), KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(0), Hit, _
																KingOnTable(RW6).KingThinking(CL6).HitNumberKing(Ki6), ChessRules.BridgeActBrown, False)
														Else
															SyntaxToWrite = ChessRules.CreateStatistic(TableHuristic, FormRefrigtz.MovmentsNumber, -6, KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(1), KingOnTable(RW6).KingThinking(CL6).RowColumnKing(Ki6)(0), Hit, _
																KingOnTable(RW6).KingThinking(CL6).HitNumberKing(Ki6), ChessRules.BridgeActBrown, False)
														End If

														FormRefrigtz.LastRow = KingOnTable(RW6).KingThinking(CL6).Row
														FormRefrigtz.LastColumn = KingOnTable(RW6).KingThinking(CL6).Column

														Act = True
														Less = KingOnTable(RW6).KingThinking(CL6).ReturnHuristic(RW6, Ki6)
														TableHuristic = KingOnTable(RW6).KingThinking(CL6).TableListKing(Ki6)
													End If
												Catch t As Exception
													Log(t)

												End Try
											End If

											'else
											If True Then
											End If
										Catch t As Exception
											Log(t)
										End Try
										j += 1
									End While
								Catch t As Exception
									Log(t)
								End Try
								k += 1
							End While
							Try
								Order *= -1
								ChessRules.CurrentOrder *= -1
								Dim p As Integer = 0
								While p < KingOnTable(i).KingThinking(0).Dept.Count
									KingOnTable(i).KingThinking(0).Dept(p).HuristicDeptSearch(Depti, A, a, Less, Order, False)
									p += 1
								End While
								Order = DummyOrder
								ChessRules.CurrentOrder = DummyCurrentOrder
							Catch t As Exception
								Log(t)
							End Try

							Order = DummyOrder
							ChessRules.CurrentOrder = DummyCurrentOrder
							i += 1
						End While
					End If

				End If

			End If
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder
			'Store In Local Variable and Dynamic Purpose Proccessing.
			'Every Non Minuse Non Idept in List Has Gretest Max Order.
			'Is Desired of Idept Oner Best Movments.
			BacWard(0) = Depti

			BacWard(1) = MaxLess1
			BacWard(2) = RW1
			BacWard(3) = RW1
			BacWard(4) = Ki1


			BacWard(5) = MaxLess2
			BacWard(6) = RW2
			BacWard(7) = RW2
			BacWard(8) = Ki2

			BacWard(9) = MaxLess3
			BacWard(10) = RW3
			BacWard(11) = RW3
			BacWard(12) = Ki3

			BacWard(13) = MaxLess4
			BacWard(14) = RW4
			BacWard(15) = RW4
			BacWard(16) = Ki4

			BacWard(17) = MaxLess5
			BacWard(18) = RW5
			BacWard(19) = RW5
			BacWard(20) = Ki5

			BacWard(21) = MaxLess6
			BacWard(22) = RW6
			BacWard(23) = RW6
			BacWard(24) = Ki6

			'We Have Information of Maximum of Huristic in Each Level and Table.
			MaxHuristicDeptFirstBackWard.Add(BacWard)
			MaxHuristicDeptFirstBackWardTable.Add(TableHuristic)

			Founded.Clear()
			'If Found retrun table.
			If Act Then
				Return TableHuristic
			End If
			'Return what found table.
			Return TableHuristic

		End Function
		'Common Non Dept Huristic Method.
		Public Function Huristic(A As List(Of AllDraw), a As Color, ij As Integer, ByRef Less As Double, Order As Integer) As Integer(,)
			'Inititae Local Varibales.
			Dim i As Integer = 0, j As Integer = 0
			Dim Table As Integer(,) = New Integer(8, 8) {}
			Dim Act As Boolean = False
			Dim ii As Integer = ij
			'If List Exist.
			If A.Count > 0 Then
				'Fo All Soldeirs.
				i = 0
				While i < AllDraw.SodierHigh
					ThinkingChess.Kind = 1
					'Calculate Thinking Operation of Current Soldier.
					Dim k As Integer = 0
					While k < AllDraw.SodierMovments
						j = 0
						While SolderesOnTable(i) IsNot Nothing AndAlso SolderesOnTable(i).SoldierThinking(k) IsNot Nothing AndAlso j < SolderesOnTable(i).SoldierThinking(k).TableListSolder.Count
							Try
								'If there is Penalty Situation Continue.
								If Order = FormRefrigtz.OrderPlate Then
									If SolderesOnTable(i).SoldierThinking(k).PenaltyRegardListSolder(j).IsPenaltyAction() = 0 AndAlso Not NoTableFound Then
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If SolderesOnTable(i).SoldierThinking(0).ReturnHuristic(i, j) > Less Then
									'Initiate Table of Current Object.
									Dim TableS As Integer(,) = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)

									If True Then
										'Achamaz Kish Mate of Current Table.
										If (New ChessRules(1, TableS, Order, SolderesOnTable(i).SoldierThinking(k).Row, SolderesOnTable(i).SoldierThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
											'If Order is Gray.
											If Order = 1 Then
												If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											Else
												'If Order is Brown.
												If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											End If
										End If
									End If
									If Order = 1 Then
										'If Order is Gray.
										'If KishAchmaz Occured and Dept Huristic Not Exist.
										If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.SolderesOnTable(i).Row, Integer), CType(APredict.SolderesOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											Else
												(New ChessRules(1, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
												If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
													Table = Nothing
													Continue Try
												End If
												If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
													Table = Nothing
													Continue Try
												End If
												Act = True
												Less = SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(0) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(1) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(2) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(3)
												Continue Try


											End If
										End If
									Else
										If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType((APredict.SolderesOnTable(i).Row), Integer), CType(APredict.SolderesOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(1, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try

											End If
										End If
									End If
									'Initaiet Local Varibale and Syntax and Table Found.
									RW = i
									CL = k
									Ki = 1
									Act = True
									FormRefrigtz.LastRow = SolderesOnTable(i).SoldierThinking(k).Row
									FormRefrigtz.LastColumn = SolderesOnTable(i).SoldierThinking(k).Column

									Less = SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(0) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(1) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(2) + SolderesOnTable(i).SoldierThinking(k).HuristicListSolder(j)(3)


									Table = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)
									Dim Hit As Boolean = False
									If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
										Hit = True
									End If
									If Order = 1 Then
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
											SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
									Else
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
											SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
									End If


									ThingsConverter.ActOfClickEqualTow = True
									SolderesOnTable(i).ConvertOperation(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), a, SolderesOnTable(i).SoldierThinking(k).TableListSolder(j), Order, False, _
										i)
									Dim Sign As Integer = 1
									If a = Color.Brown Then
										Sign = -1
									End If
									If SolderesOnTable(i).Convert Then
										Hit = False
										If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
											Hit = True
										End If
										If Order = 1 Then
											SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
												SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
										Else
											SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
												SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
										End If

										If SolderesOnTable(i).ConvertedToMinister Then
											Table(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 5 * Sign
										ElseIf SolderesOnTable(i).ConvertedToBridge Then
											Table(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 4 * Sign
										ElseIf SolderesOnTable(i).ConvertedToHourse Then
											Table(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 3 * Sign
										ElseIf SolderesOnTable(i).ConvertedToElefant Then
											Table(SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1)) = 2 * Sign
										End If
										TableList.Clear()
										TableList.Add(Table)
										SetRowColumn(0)

										TableList.Clear()


									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							j += 1
						End While
						k += 1

					End While
					i += 1
				End While
				'Calculate Thinking Operation of Current Elephant.                   
				i = 0
				While i < AllDraw.ElefantHigh
					ThinkingChess.Kind = 2
					Dim k As Integer = 0
					While k < AllDraw.ElefantMovments
						j = 0
						While ElephantOnTable(i) IsNot Nothing AndAlso ElephantOnTable(i).ElefantThinking(k) IsNot Nothing AndAlso j < ElephantOnTable(i).ElefantThinking(k).TableListElefant.Count
							Try
								'If there is Penalty Situation Continue.
								If Order = FormRefrigtz.OrderPlate Then
									If ElephantOnTable(i).ElefantThinking(k).PenaltyRegardListElefant(j).IsPenaltyAction() = 0 AndAlso Not NoTableFound Then
										Continue Try
									End If
								End If

								'For Higher Huristic Values.
								If ElephantOnTable(i).ElefantThinking(0).ReturnHuristic(i, j) > Less Then

									'Initiate Table of Current Object.
									Dim TableS As Integer(,) = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
									If True Then
										'Achamaz Kish Mate of Current Table.
										If (New ChessRules(2, TableS, Order, ElephantOnTable(i).ElefantThinking(k).Row, ElephantOnTable(i).ElefantThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
											'If Order is Gray.
											If Order = 1 Then
												If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											Else
												'If Order is Brown.
												If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											End If
										End If
									End If
									If Order = 1 Then
										'If Order is Gray.
										'If KishAchmaz Occured and Dept Huristic Not Exist.
										If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType((APredict.ElephantOnTable(i).Row), Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
											(New ChessRules(2, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If Table Is Nothing Then
												Continue Try
											Else
												RW = i
												CL = k
												Ki = 1
												Act = True

												Less = ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(0) + ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(1) + ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(2) + ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(3)
											End If
										End If
									Else
										If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(ii)
											Table = APredict.InitiatePerdictKish(CType(APredict.ElephantOnTable(i).Row, Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(1, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try


											End If
										End If
									End If
									'Initaiet Local Varibale and Syntax and Table Found.
									Dim Hit As Boolean = False
									If ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j) > 0 Then
										Hit = True
									End If
									If Order = 1 Then
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
											ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
									Else
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
											ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
									End If

									FormRefrigtz.LastRow = ElephantOnTable(i).ElefantThinking(k).Row
									FormRefrigtz.LastColumn = ElephantOnTable(i).ElefantThinking(k).Column

									RW = i
									CL = k
									Ki = 2
									Act = True
									Less = ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(0) + ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(1) + ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(2) + ElephantOnTable(i).ElefantThinking(k).HuristicListElefant(j)(3)

									Table = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
								End If
							Catch t As Exception
								Log(t)
							End Try
							j += 1
						End While
						k += 1

					End While
					i += 1
				End While
				'Calculate Thinking Operation of Current Hourse.                   
				i = 0
				While i < AllDraw.HourseHight
					ThinkingChess.Kind = 3

					Dim k As Integer = 0
					While k < AllDraw.HourseMovments
						j = 0
						While HoursesOnTable(i) IsNot Nothing AndAlso HoursesOnTable(i).HourseThinking(k) IsNot Nothing AndAlso j < HoursesOnTable(i).HourseThinking(k).TableListHourse.Count
							Try
								'If there is Penalty Situation Continue.
								If Order = FormRefrigtz.OrderPlate Then
									If HoursesOnTable(i).HourseThinking(k).PenaltyRegardListHourse(j).IsPenaltyAction() = 0 AndAlso Not NoTableFound Then
										Continue Try
									End If
								End If


								'For Higher Huristic Values.
								If HoursesOnTable(i).HourseThinking(0).ReturnHuristic(i, j) > Less Then
									'Initiate Table of Current Object.
									Dim TableS As Integer(,) = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
									If True Then
										If True Then
											'Achamaz Kish Mate of Current Table.
											If (New ChessRules(3, TableS, Order, HoursesOnTable(i).HourseThinking(k).Row, HoursesOnTable(i).HourseThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
												'If Order is Gray.
												If Order = 1 Then
													If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
														Continue Try
													End If
												Else
													'If Order is Brown.
													If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
														Continue Try
													End If
												End If

											Else
											End If
										End If
									End If

									If Order = 1 Then
										'If Order is Gray.
										'If KishAchmaz Occured and Dept Huristic Not Exist.
										If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.HoursesOnTable(i).Row, Integer), CType(APredict.HoursesOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(3, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
										End If
									Else
										If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.HoursesOnTable(i).Row, Integer), CType(APredict.HoursesOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											Else
												(New ChessRules(3, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
												If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
													Table = Nothing
													Continue Try
												End If
												If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
													Table = Nothing
													Continue Try
												End If
												RW = i
												CL = k
												Ki = 1
												Act = True
												Less = HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(0) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(1) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(2) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(3)
												Continue Try

											End If
										End If
									End If
									'Initaiet Local Varibale and Syntax and Table Found.
									Dim Hit As Boolean = False
									If HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j) > 0 Then
										Hit = True
									End If
									If Order = 1 Then
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
											HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
									Else
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
											HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
									End If
									FormRefrigtz.LastRow = HoursesOnTable(i).HourseThinking(k).Row
									FormRefrigtz.LastColumn = HoursesOnTable(i).HourseThinking(k).Column

									RW = i
									CL = k
									Ki = 3
									Act = True
									Less = HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(0) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(1) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(2) + HoursesOnTable(i).HourseThinking(k).HuristicListHourse(j)(3)

									Table = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
								End If
							Catch t As Exception
								Log(t)
							End Try
							j += 1
						End While
						k += 1


					End While
					i += 1
				End While
				'Calculate Thinking Operation of Current Bridges.
				i = 0
				While i < AllDraw.BridgeHigh
					ThinkingChess.Kind = 4
					Dim k As Integer = 0
					While k < AllDraw.BridgeMovments
						j = 0
						While BridgesOnTable(i) IsNot Nothing AndAlso BridgesOnTable(i).BridgeThinking(k) IsNot Nothing AndAlso j < BridgesOnTable(i).BridgeThinking(k).TableListBridge.Count
							Try
								'If there is Penalty Situation Continue.
								If Order = FormRefrigtz.OrderPlate Then
									If BridgesOnTable(i).BridgeThinking(k).PenaltyRegardListBridge(j).IsPenaltyAction() = 0 AndAlso Not NoTableFound Then
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If BridgesOnTable(i).BridgeThinking(0).ReturnHuristic(i, j) > Less Then
									'Initiate Table of Current Object.
									Dim TableS As Integer(,) = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
									If True Then
										'Achamaz Kish Mate of Current Table.
										If (New ChessRules(4, TableS, Order, BridgesOnTable(i).BridgeThinking(k).Row, BridgesOnTable(i).BridgeThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
											'If Order is Gray.
											If Order = 1 Then
												If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											Else
												'If Order is Brown.
												If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											End If
										End If
									End If
									If Order = 1 Then
										'If Order is Gray.
										'If KishAchmaz Occured and Dept Huristic Not Exist.
										If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.BridgesOnTable(i).Row, Integer), CType(APredict.BridgesOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(4, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try

											End If
										End If
									Else
										If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(BridgesOnTable(i).Row, Integer), CType(BridgesOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											Else
												(New ChessRules(4, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
												If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
													Continue Try
												End If
												If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
													Continue Try
												End If

												RW = i
												CL = k
												Ki = 1
												Act = True
												Less = BridgesOnTable(i).BridgeThinking(k).HuristicListBridge(j)(0) + BridgesOnTable(i).BridgeThinking(k).HuristicListBridge(j)(1) + BridgesOnTable(i).BridgeThinking(k).HuristicListBridge(j)(2) + BridgesOnTable(i).BridgeThinking(k).HuristicListBridge(j)(3)

												Continue Try
											End If
										End If
									End If
									'Initaiet Local Varibale and Syntax and Table Found.
									Dim Hit As Boolean = False
									If BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j) > 0 Then
										Hit = True
									End If
									If Order = 1 Then
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
											BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
									Else
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
											BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
									End If

									FormRefrigtz.LastRow = BridgesOnTable(i).BridgeThinking(k).Row
									FormRefrigtz.LastColumn = BridgesOnTable(i).BridgeThinking(k).Column

									RW = i
									CL = k
									Ki = 4
									Act = True
									Less = BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j)

									Table = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
								End If
							Catch t As Exception
								Log(t)
							End Try
							j += 1
						End While
						k += 1

					End While
					i += 1
				End While
				'Calculate Thinking Operation of Current Minister.          
				i = 0
				While i < AllDraw.MinisterHigh
					ThinkingChess.Kind = 5
					Dim k As Integer = 0
					While k < AllDraw.MinisterMovments
						j = 0
						While MinisterOnTable(i) IsNot Nothing AndAlso MinisterOnTable(i).MinisterThinking(k) IsNot Nothing AndAlso j < MinisterOnTable(i).MinisterThinking(k).TableListMinister.Count
							Try
								'If there is Penalty Situation Continue.
								If Order = FormRefrigtz.OrderPlate Then
									If MinisterOnTable(i).MinisterThinking(k).PenaltyRegardListMinister(j).IsPenaltyAction() = 0 AndAlso Not NoTableFound Then
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j) > Less Then
									'Initiate Table of Current Object.
									Dim TableS As Integer(,) = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
									If True Then
										If True Then
											'Achamaz Kish Mate of Current Table.
											If (New ChessRules(5, TableS, Order, MinisterOnTable(i).MinisterThinking(k).Row, MinisterOnTable(i).MinisterThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
												'If Order is Gray.
												If Order = 1 Then
													If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
														Continue Try
													End If
												Else
													'If Order is Brown.
													If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
														Continue Try
													End If
												End If
											End If
										End If
									End If
									If Order = 1 Then
										'If Order is Gray.
										'If KishAchmaz Occured and Dept Huristic Not Exist.
										If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.MinisterOnTable(i).Row, Integer), CType(APredict.MinisterOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(5, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try

											End If

										End If
									Else
										If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											If Nothing = APredict.InitiatePerdictKish(CType(APredict.MinisterOnTable(i).Row, Integer), CType(APredict.MinisterOnTable(i).Column, Integer), B, TableS, Order, False) Then
												Continue Try

											End If
										End If
									End If
									'Initaiet Local Varibale and Syntax and Table Found.
									Dim Hit As Boolean = False
									If MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j) > 0 Then
										Hit = True
									End If
									If Order = 1 Then
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
											MinisterOnTable(i).MinisterThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
									Else
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
											MinisterOnTable(i).MinisterThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
									End If

									FormRefrigtz.LastRow = MinisterOnTable(i).MinisterThinking(k).Row
									FormRefrigtz.LastColumn = MinisterOnTable(i).MinisterThinking(k).Column

									RW = i
									CL = k
									Ki = 5
									Act = True
									Less = MinisterOnTable(i).MinisterThinking(k).HuristicListMinister(j)(0) + MinisterOnTable(i).MinisterThinking(k).HuristicListMinister(j)(1) + MinisterOnTable(i).MinisterThinking(k).HuristicListMinister(j)(2) + MinisterOnTable(i).MinisterThinking(k).HuristicListMinister(j)(3)

									Table = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
								End If
							Catch t As Exception
								Log(t)
							End Try
							j += 1
						End While
						k += 1

					End While
					i += 1
				End While
				'Calculate Thinking Operation of Current King.                   
				i = 0
				While i < AllDraw.KingHigh
					ThinkingChess.Kind = 6
					Dim k As Integer = 0
					While k < AllDraw.KingMovments
						j = 0
						While KingOnTable(i) IsNot Nothing AndAlso KingOnTable(i).KingThinking(k) IsNot Nothing AndAlso j < KingOnTable(i).KingThinking(k).TableListKing.Count
							Try
								'If there is Penalty Situation Continue.
								If Order = FormRefrigtz.OrderPlate Then
									If KingOnTable(i).KingThinking(k).PenaltyRegardListKing(j).IsPenaltyAction() = 0 AndAlso Not NoTableFound Then
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If KingOnTable(i).KingThinking(0).ReturnHuristic(i, j) > Less Then
									'Initiate Table of Current Object.
									Dim TableS As Integer(,) = KingOnTable(i).KingThinking(k).TableListKing(j)
									If True Then
										'Achamaz Kish Mate of Current Table.
										If (New ChessRules(6, TableS, Order, KingOnTable(i).KingThinking(k).Row, KingOnTable(i).KingThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not NoTableFound Then
											'If Order is Gray.
											If Order = 1 Then
												If ChessRules.KishGrayAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											Else
												'If Order is Brown.
												If ChessRules.KishBrownAchmaz AndAlso DeptFirstSearch Then
													Continue Try
												End If
											End If

										Else
										End If
									End If
									If Order = 1 Then
										'If Order is Gray.
										'If KishAchmaz Occured and Dept Huristic Not Exist.
										If ChessRules.KishGrayAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.KingOnTable(i).Row, Integer), CType(APredict.KingOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(6, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try

											End If
										End If
									Else
										If ChessRules.KishBrownAchmaz AndAlso Not DeptFirstSearch Then
											'Prdeict Huristic.
											Dim B As Color
											If a = Color.Gray Then
												B = Color.Brown
											Else
												B = Color.Gray
											End If
											APredict.TableList.Clear()
											APredict.TableList.Add(TableS)
											APredict.SetRowColumn(0)
											Table = APredict.InitiatePerdictKish(CType(APredict.KingOnTable(i).Row, Integer), CType(APredict.KingOnTable(i).Column, Integer), B, TableS, Order, False)
											If Table Is Nothing Then
												Continue Try
											End If
											(New ChessRules(6, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
											If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											End If
											If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
												Table = Nothing
												Continue Try
											Else
												RW = i
												CL = k
												Ki = 1
												Act = True
												Less = KingOnTable(i).KingThinking(k).HuristicListKing(j)(0) + KingOnTable(i).KingThinking(k).HuristicListKing(j)(1) + KingOnTable(i).KingThinking(k).HuristicListKing(j)(2) + KingOnTable(i).KingThinking(k).HuristicListKing(j)(3)
												Continue Try

											End If
										End If
									End If
									'Initaiet Local Varibale and Syntax and Table Found.
									Dim Hit As Boolean = False
									If MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j) > 0 Then
										Hit = True
									End If
									If Order = 1 Then
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
											MinisterOnTable(i).MinisterThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
									Else
										SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
											MinisterOnTable(i).MinisterThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
									End If

									FormRefrigtz.LastRow = KingOnTable(i).KingThinking(k).Row
									FormRefrigtz.LastColumn = KingOnTable(i).KingThinking(k).Column

									RW = i
									CL = k
									Ki = 6
									Act = True
									Less = KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)

									Table = KingOnTable(i).KingThinking(k).TableListKing(j)
								End If
							Catch t As Exception
								Log(t)
							End Try
							j += 1
						End While
						k += 1

					End While
					i += 1
				End While
			End If
			'If There is A Movments Return Table.
			If Act Then
				Return Table
			End If
			'What Kind Of Table.

			Return Table
		End Function
		'Genethic Algorithm Game Method.
		Public Sub InitiateGenetic(ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, TB As Boolean)
			'Initiate Local and Global Variables.
			Dim Current As Integer = ChessRules.CurrentOrder
			Dim DummyOrder As Integer = Order
			ADraw.Clear()
			TableList.Clear()
			TableList.Add(Table)
			SetRowColumn(0)
			TableList.Clear()
			ThinkingChess.NotSolvedKingDanger = False
			LoopHuristicIndex = 0
			'For One time.
			Dim i As Integer = 0
			While i < 1
				'If Order is Gray.
				If Order = 1 Then
					THIS.SetBoxText(vbCr & vbLf & "Chess Genetic By Bob!")
					THIS.RefreshBoxText()
				Else
					'If Order is Brown.
					THIS.SetBoxText(vbCr & vbLf & "Chess Genetic By Alice!")

					THIS.RefreshBoxText()
				End If
				'Initiate Local Variables.
				Dim TablInit As Integer(,) = New Integer(8, 8) {}
				If Order = 1 Then
					a = Color.Gray
				Else
					a = Color.Brown
				End If
				Dim [In] As Integer = 0
				'Found Of Random Movments.
				Do
					If Order = 1 Then
						[In] = (New System.Random()).[Next](0, 8)
					Else
						[In] = (New System.Random()).[Next](8, 16)
					End If
				Loop While SolderesOnTable([In]) Is Nothing


				'If Order is Gray.
				If Order = 1 Then
					THIS.SetBoxText(vbCr & vbLf & "Genetic Algorithm Begin Dept " + i.ToString() + " By Bob!")
					THIS.RefreshBoxText()
				Else
					'If Order is Brown.
					THIS.SetBoxText(vbCr & vbLf & "Genetic Algirithm Begin Dept " + i.ToString() + " By Alice!")

					THIS.RefreshBoxText()
				End If
				'Found Of Genetic Algorithm Movments By GeneticAlgorithm Call Objectsand Method.
				Dim R As ChessGeneticAlgorithm = (New ChessGeneticAlgorithm())
				'Found Table.
				Dim Tab As Integer(,) = R.GenerateTable(TableListAction, 0, Order)
				'If Order is Gray.
				If Order = 1 Then
					THIS.SetBoxText(vbCr & vbLf & "Genetic Algorithm Finsished Dept " + i.ToString() + " By Bob!")
					THIS.RefreshBoxText()
				Else
					'If Order is Brown.
					THIS.SetBoxText(vbCr & vbLf & "Genetic Algirithm Finished Dept " + i.ToString() + " By Alice!")

					THIS.RefreshBoxText()
				End If

				'If Table Found.
				If Tab IsNot Nothing Then
					'Construct a Clone Copy of Table.
					Dim iii As Integer = 0
					While iii < 8
						Dim jjj As Integer = 0
						While jjj < 8
							TablInit(iii, jjj) = Tab(iii, jjj)
							jjj += 1
						End While
						iii += 1
					End While
					'Initiate a Table.
					Table = New Integer(8, 8) {}
					'Construct a Clone Copy of Table.
					Dim iii As Integer = 0
					While iii < 8
						Dim jjj As Integer = 0
						While jjj < 8
							Table(iii, jjj) = TablInit(iii, jjj)
							jjj += 1
						End While
						iii += 1
					End While
					'Initiate Local and Global Varibales.
					TableList.Add(TablInit)
					ClList.Add(CL)
					RWList.Add(RW)
					KiList.Add(Ki)
					' Order = Order * -1;
					' ChessRules.CurrentOrder = Order;
						'return;

					Dept += 1
				End If
				i += 1
			End While
			'Determination of Mate Consideration.
			(New ChessRules(1, Table, Order, -1, -1)).Mate(Table, Order)

			'Reconstruction of Order Global Varibales.
			Order = DummyOrder
			ChessRules.CurrentOrder = Current


		End Sub
		Delegate Sub IncreaseprogressBarRefregitzValueCalBack(Refregitz As ProgressBar, value As Int32)
		Private Sub IncreaseprogressBarRefregitzValue(Refregitz As ProgressBar, value As Int32)
			Try
				If Refregitz.InvokeRequired Then
					Dim d As New IncreaseprogressBarRefregitzValueCalBack(IncreaseprogressBarRefregitzValue)
					Refregitz.Invoke(New Action(Function() Refregitz.Value += value))
				Else

					Refregitz.Value += value
				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		Delegate Sub SetprogressBarRefregitzValueCalBack(Refregitz As ProgressBar, value As Int32)
		Private Sub SetprogressBarRefregitzValue(Refregitz As ProgressBar, value As Int32)
			Try
				If Refregitz.InvokeRequired Then
					Dim d As New SetprogressBarRefregitzValueCalBack(SetprogressBarRefregitzValue)
					Refregitz.Invoke(New Action(Function() Refregitz.Value = value))
				Else

					Refregitz.Value += value
				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		Delegate Sub SetprogressBarRefregitzUpdateCalBack(Refregitz As ProgressBar)
		Private Sub SetprogressBarUpdate(Refregitz As ProgressBar)
			Try
				If Refregitz.InvokeRequired Then
					Dim d As New SetprogressBarRefregitzUpdateCalBack(SetprogressBarUpdate)
					Refregitz.Invoke(New Action(Function() Refregitz.Update()))
				Else

					Refregitz.Update()
				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub

		'Dept First Initiat Thinking Main Method.
		Public Function InitiateDeptFirst(iDept As Integer, ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, _
			TB As Boolean, ByRef timer As Timer, ByRef TimerColor As Timer, ByRef Less As Double) As AllDraw
			Dim MaxNotFound As Boolean = True
			'Retrun Recursive Method Condition.
			If iDept >= MaxDept Then
				Return Nothing
			End If

			'if (ThinkingChess.MovementsDeptHuristicFound && iDept != 1)
			'    return null;
			'Incrimentes of Recursive Varibale.
			iDept += 1
			'Initiate of global Variables Byte Local Variables.
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'End Timer Condition Limitation.
			timer.MidleDeptFirstTimer(iDept)
			'Mathematicall Formula for Calculation DeptFirstMaxLevel Not Work.
			Dim S As Integer = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
			If S = 1 Then
				DeptiLevelMax += 1
			Else
				'have to Zero. Non Decreamet Algorithm not found.
				DeptiLevelMax = 0
			End If
			'Consideration of Recursive Condition.
			If iDept > DeptiLevelMax AndAlso iDept <> 1 AndAlso Not FormRefrigtz.Blitz Then

				Return Nothing
			End If
			'Initiate of Local Varibales.
			Dim i As Integer = 0
			'If Order is Gray.
			If Order = 1 Then
				THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " By Bob!")
				THIS.RefreshBoxText()
			Else
				'If Order is Brown.
				THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " By Alice!")
				THIS.RefreshBoxText()
			End If
			'Initiate Of Local Variables.
			Dim TablInit As Integer(,) = New Integer(8, 8) {}
			If Order = 1 Then
				a = Color.Gray
			Else
				a = Color.Brown
			End If
			If True Then


				Dim j As Integer = 0
				If True Then
					'If Order is Gray.
					If Order = 1 Then



						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder

						'For Gray Soldeirs Objects. 
						i = 0
						While i < AllDraw.SodierMidle
							Try
								ThinkingChess.Kind = 1
								'If Solders Not Exist Continue and Traversal Back.
								If SolderesOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate of Local Variables By Global Objective Gray Current Solder.
								ii = CType(SolderesOnTable(i).SoldierThinking(0).Row, Integer)
								jj = CType(SolderesOnTable(i).SoldierThinking(0).Column, Integer)
								'Construction of Thinking Gray Soldier By Local Variables.
								SolderesOnTable(i) = New DrawSoldier(ii, jj, a, Table, Order, False, _
									i)
								'If There is no Thinking Movments on Current Object 
								If SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count = 0 Then
									'For All Movable Gray Solders.
									j = 0
									While j < AllDraw.SodierMovments
										'Thinking of Gray Solder Operation.
										SolderesOnTable(i).SoldierThinking(0).Table = SolderesOnTable(i).SoldierThinking(0).Table
										SolderesOnTable(i).SoldierThinking(0).ThinkingBegin = True
										SolderesOnTable(i).SoldierThinking(0).ThinkingFinished = False
										SolderesOnTable(i).SoldierThinking(0).t = New Thread(New ThreadStart(SolderesOnTable(i).SoldierThinking(0).Thinking))
										SolderesOnTable(i).SoldierThinking(0).t.Start()
										'Wait For Thinking Finished.
										Wait(Me, i, j, 0, 1, False)
										SolderesOnTable(i).SoldierThinking(0).t.Abort()
										SolderesOnTable(i).SoldierThinking(0).t.Join()
										'When Thinking Not Successful Continue.
										If SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Soldeirs By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Soldeirs By Alice!")
											THIS.RefreshBoxText()
										End If
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										'Operation of Dept Caaling Main Method.
										SolderesOnTable(i).SoldierThinking(0).Dept.Add(New AllDraw(THIS))
										' SolderesOnTable[i].SoldierThinking[0].Dept[SolderesOnTable[i].SoldierThinking[0].Dept.Count - 1].SolderesOnTable[i] = new DrawSoldier(SolderesOnTable[i].Row, SolderesOnTable[i].Column, SolderesOnTable[i].color, SolderesOnTable[i].Table, SolderesOnTable[i].Order, false, SolderesOnTable[i].Current);

										SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1), Order * -1)
										SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Initiate of Local Order By Global Variable. 
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer Finsining Thinking. 
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											SolderesOnTable(i).SoldierThinking(0).Dept = Nothing
											Return Nothing


										End If
										j += 1
									End While
								Else
									'If There is A Soldeir Movments.                                   
									'For Numbers of Gray Soldeirs Movements.
									j = 0
									While j < SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count
										'Initiate of Local Variables By Global Objective Gray Current Solder.
										SolderesOnTable(i).Row = CType(SolderesOnTable(i).SoldierThinking(0).RowColumnSoldier(j)(0), Integer)
										SolderesOnTable(i).Column = CType(SolderesOnTable(i).SoldierThinking(0).RowColumnSoldier(j)(0), Integer)
										'Construction of Thinking Gray Soldier By Local Variables.
										SolderesOnTable(i).Table = SolderesOnTable(i).SoldierThinking(0).TableListSolder(j)

										'Thinking of Gray Soldeir Operations.
										SolderesOnTable(i).SoldierThinking(0).Table = SolderesOnTable(i).SoldierThinking(0).TableListSolder(j)
										SolderesOnTable(i).SoldierThinking(0).ThinkingBegin = True
										SolderesOnTable(i).SoldierThinking(0).ThinkingFinished = False
										SolderesOnTable(i).SoldierThinking(0).t = New Thread(New ThreadStart(SolderesOnTable(i).SoldierThinking(0).Thinking))
										SolderesOnTable(i).SoldierThinking(0).t.Start()
										'Wait For Thinking Finishing.
										Wait(Me, i, j, 0, 1, False)
										SolderesOnTable(i).SoldierThinking(0).t.Abort()
										SolderesOnTable(i).SoldierThinking(0).t.Join()
										If SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count = 0 Then
											Continue While
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										SolderesOnTable(i).SoldierThinking(0).Dept.Add(New AllDraw(THIS))
										'SolderesOnTable[i].SoldierThinking[0].Dept[SolderesOnTable[i].SoldierThinking[0].Dept.Count - 1].SolderesOnTable[i] = new DrawSoldier(SolderesOnTable[i].Row, SolderesOnTable[i].Column, SolderesOnTable[i].color, SolderesOnTable[i].Table, SolderesOnTable[i].Order, false, SolderesOnTable[i].Current);
										SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initaie Order Gray.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer of Finishing Calling.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											SolderesOnTable(i).SoldierThinking(0).Dept = Nothing
											Return Nothing


										End If
										j += 1
									End While
								End If
							Catch t As Exception
								'SolderesOnTable[i] = null;
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder

						'For All Gray Elephant Objects.
						i = 0
						While i < AllDraw.ElefantMidle
							Try
								ThinkingChess.Kind = 2
								'Ignore of Non Exist Current Elephant Gray Objects.
								If ElephantOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Inititae Local Varibale By Global Gray Elephant Objects Varibales.
								ii = CType(ElephantOnTable(i).Row, Integer)
								jj = CType(ElephantOnTable(i).Column, Integer)
								'Construction of Thinking Objects By Local Varibales.
								ElephantOnTable(i) = New DrawElefant(ii, jj, a, Table, Order, False, _
									i)
								'If There is Not Thinking Objetive List Elephant Gray. 
								If ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count = 0 Then
									'For All Possible Movments.
									j = 0
									While j < AllDraw.ElefantMovments
										'Operational Thinking Gray Elephant. 
										ElephantOnTable(i).ElefantThinking(0).Table = ElephantOnTable(i).ElefantThinking(0).Table
										ElephantOnTable(i).ElefantThinking(0).ThinkingBegin = True
										ElephantOnTable(i).ElefantThinking(0).ThinkingFinished = False
										ElephantOnTable(i).ElefantThinking(0).t = New Thread(New ThreadStart(ElephantOnTable(i).ElefantThinking(0).Thinking))
										ElephantOnTable(i).ElefantThinking(0).t.Start()
										'Wait Until Thinking Finished.
										Wait(Me, i, j, 0, 2, False)
										ElephantOnTable(i).ElefantThinking(0).t.Abort()
										ElephantOnTable(i).ElefantThinking(0).t.Join()
										'Continue When There is Not Thinking Results.
										If ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Elephant By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Elephant By Alice!")
											THIS.RefreshBoxText()
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										ElephantOnTable(i).ElefantThinking(0).Dept.Add(New AllDraw(THIS))
										'ElephantOnTable[i].ElefantThinking[0].Dept[ElephantOnTable[i].ElefantThinking[0].Dept.Count - 1].ElephantOnTable[i] = new DrawElefant(ElephantOnTable[i].Row, ElephantOnTable[i].Column, ElephantOnTable[i].color, ElephantOnTable[i].Table, ElephantOnTable[i].Order, false, ElephantOnTable[i].Current);
										ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Global Order Initiate.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer Finishing Operational Recursive Ended.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then

											ElephantOnTable(i).ElefantThinking(0).Dept = Nothing
											Return Nothing

										End If
										j += 1
									End While
								Else
									'If There is Movment Thinking Gary Elphant Object List.
									'For Every Gray Elephant Thinking Movments.
									j = 0
									While j < ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count
										'Inititae Local Varibale By Global Gray Elephant Objects Varibales.
										ElephantOnTable(i).Row = CType(ElephantOnTable(i).ElefantThinking(0).RowColumnElefant(j)(0), Integer)
										ElephantOnTable(i).Column = CType(ElephantOnTable(i).ElefantThinking(0).RowColumnElefant(j)(1), Integer)
										'Construction of Thinking Objects By Local Varibales.
										ElephantOnTable(i).Table = ElephantOnTable(i).ElefantThinking(0).TableListElefant(j)

										'Gray Elephant Object Thinking Operations.
										ElephantOnTable(i).ElefantThinking(0).Table = ElephantOnTable(i).ElefantThinking(0).TableListElefant(j)
										ElephantOnTable(i).ElefantThinking(0).ThinkingBegin = True
										ElephantOnTable(i).ElefantThinking(0).ThinkingFinished = False
										ElephantOnTable(i).ElefantThinking(0).t = New Thread(New ThreadStart(ElephantOnTable(i).ElefantThinking(0).Thinking))
										ElephantOnTable(i).ElefantThinking(0).t.Start()
										'Wait While Thinking Finishing.
										Wait(Me, i, j, 0, 2, False)
										ElephantOnTable(i).ElefantThinking(0).t.Abort()
										ElephantOnTable(i).ElefantThinking(0).t.Join()
										'When Thinking Object Not Exist Continue.
										If ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count = 0 Then
											Continue While
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										ElephantOnTable(i).ElefantThinking(0).Dept.Add(New AllDraw(THIS))
										'ElephantOnTable[i].ElefantThinking[0].Dept[ElephantOnTable[i].ElefantThinking[0].Dept.Count - 1].ElephantOnTable[i] = new DrawElefant(ElephantOnTable[i].Row, ElephantOnTable[i].Column, ElephantOnTable[i].color, ElephantOnTable[i].Table, ElephantOnTable[i].Order, false, ElephantOnTable[i].Current);
										ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initiatiozation Global Order 
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer Finsihing Recursive Operations.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											ElephantOnTable(i).ElefantThinking(0).Dept = Nothing
											Return Nothing

										End If
										j += 1
									End While
								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder

						'For All Gray Hourse Objects.
						i = 0
						While i < AllDraw.HourseMidle
							Try
								ThinkingChess.Kind = 3
								'Ignore of Non Exist Current Gray Hourse Objects.
								If HoursesOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate of Local Variables By Global Gray Hourse Objectives.
								ii = CType(HoursesOnTable(i).Row, Integer)
								jj = CType(HoursesOnTable(i).Column, Integer)
								'Construction of Gray Hourse Thinking Objects..
								HoursesOnTable(i) = New DrawHourse(ii, jj, a, Table, Order, False, _
									i)
								'When There is Not HourseList Count. 
								If HoursesOnTable(i).HourseThinking(0).TableListHourse.Count = 0 Then
									'For All Possible Movments.
									j = 0
									While j < AllDraw.HourseMovments
										'Thinking of Gray Hourse Oprational.
										HoursesOnTable(i).HourseThinking(0).Table = HoursesOnTable(i).HourseThinking(0).Table
										HoursesOnTable(i).HourseThinking(0).ThinkingBegin = True
										HoursesOnTable(i).HourseThinking(0).ThinkingFinished = False
										HoursesOnTable(i).HourseThinking(0).t = New Thread(New ThreadStart(HoursesOnTable(i).HourseThinking(0).Thinking))
										HoursesOnTable(i).HourseThinking(0).t.Start()
										'Wait While Thinking Finished.
										Wait(Me, i, j, 0, 3, False)
										HoursesOnTable(i).HourseThinking(0).t.Abort()
										HoursesOnTable(i).HourseThinking(0).t.Join()
										'When Thinking of Hourse List Not Successful Constinue.
										If HoursesOnTable(i).HourseThinking(0).TableListHourse.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Hourse By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Hourse By Alice!")
											THIS.RefreshBoxText()
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										HoursesOnTable(i).HourseThinking(0).Dept.Add(New AllDraw(THIS))
										'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].HoursesOnTable[i] = new DrawHourse(HoursesOnTable[i].Row, HoursesOnTable[i].Column, HoursesOnTable[i].color, HoursesOnTable[i].Table, HoursesOnTable[i].Order, false, HoursesOnTable[i].Current);
										HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Global Order.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer Finishing Recursive Ending.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											HoursesOnTable(i).HourseThinking(0).Dept = Nothing
											Return Nothing


										End If
										j += 1
									End While
								Else
									'If Table List Exist int The Thinking.
									'For All Possible Movments of Thinking.
									j = 0
									While j < HoursesOnTable(i).HourseThinking(0).TableListHourse.Count
										'Initiate of Local Variables By Global Gray Hourse Objectives.
										HoursesOnTable(i).Row = CType(HoursesOnTable(i).HourseThinking(0).RowColumnHourse(j)(0), Integer)
										HoursesOnTable(i).Column = CType(HoursesOnTable(i).HourseThinking(0).RowColumnHourse(j)(1), Integer)
										'Construction of Gray Hourse Thinking Objects..
										HoursesOnTable(i).Table = HoursesOnTable(i).HourseThinking(0).TableListHourse(j)

										'Thinking Operation of Gray Hourse.
										HoursesOnTable(i).HourseThinking(0).Table = HoursesOnTable(i).HourseThinking(0).TableListHourse(j)
										HoursesOnTable(i).HourseThinking(0).ThinkingBegin = True
										HoursesOnTable(i).HourseThinking(0).ThinkingFinished = False
										HoursesOnTable(i).HourseThinking(0).t = New Thread(New ThreadStart(HoursesOnTable(i).HourseThinking(0).Thinking))
										HoursesOnTable(i).HourseThinking(0).t.Start()
										'Wait For Thinking Finsished.
										Wait(Me, i, j, 0, 3, False)
										HoursesOnTable(i).HourseThinking(0).t.Abort()
										HoursesOnTable(i).HourseThinking(0).t.Join()
										'If Thinking Not Successful of the Thinking Operation Continue Traversal Back.
										If HoursesOnTable(i).HourseThinking(0).TableListHourse.Count = 0 Then
											Continue While
										End If
										'Operational Thinking of Dept Recursive Calling <MainMethod.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										HoursesOnTable(i).HourseThinking(0).Dept.Add(New AllDraw(THIS))
										'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].HoursesOnTable[i] = new DrawHourse(HoursesOnTable[i].Row, HoursesOnTable[i].Column, HoursesOnTable[i].color, HoursesOnTable[i].Table, HoursesOnTable[i].Order, false, HoursesOnTable[i].Current);
										HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Iniateie of Glbal Varibale By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer End of Thinking Finsishing Recursively.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											HoursesOnTable(i).HourseThinking(0).Dept = Nothing
											Return Nothing


										End If
										j += 1

									End While
								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder


						'For All Possible Gray Bridges Objects.
						i = 0
						While i < AllDraw.BridgeMidle
							Try
								ThinkingChess.Kind = 4
								'When Current Bridges Gray Not Exist Continue Traversal Back.
								If BridgesOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initaiate of Local Varibales By Global Varoiables.
								ii = CType(BridgesOnTable(i).Row, Integer)
								jj = CType(BridgesOnTable(i).Column, Integer)
								'Construction of Thinking Variables By Local Variables.
								BridgesOnTable(i) = New DrawBridge(ii, jj, a, Table, Order, False, _
									i)
								'When Count of Table Bridges of Thinking Not Exist Do Operational.
								If BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count = 0 Then
									'For All Possible Movments.
									j = 0
									While j < AllDraw.BridgeMovments
										'Thinking of Gray Bridges Operational.
										BridgesOnTable(i).BridgeThinking(0).Table = BridgesOnTable(i).BridgeThinking(0).Table
										BridgesOnTable(i).BridgeThinking(0).ThinkingBegin = True
										BridgesOnTable(i).BridgeThinking(0).ThinkingFinished = False
										BridgesOnTable(i).BridgeThinking(0).t = New Thread(New ThreadStart(BridgesOnTable(i).BridgeThinking(0).Thinking))
										BridgesOnTable(i).BridgeThinking(0).t.Start()
										'Wait For Thinking of curent Object Finished.
										Wait(Me, i, j, 0, 4, False)
										BridgesOnTable(i).BridgeThinking(0).t.Abort()
										BridgesOnTable(i).BridgeThinking(0).t.Join()
										'When Bridges Thinking Not Successfule Continue Traversal Back.
										If BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Bridges By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Bridges By Alice!")
											THIS.RefreshBoxText()
										End If

										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										BridgesOnTable(i).BridgeThinking(0).Dept.Add(New AllDraw(THIS))
										'BridgesOnTable[i].BridgeThinking[0].Dept[BridgesOnTable[i].BridgeThinking[0].Dept.Count - 1].BridgesOnTable[i] = new DrawBridge(BridgesOnTable[i].Row, BridgesOnTable[i].Column, BridgesOnTable[i].color, BridgesOnTable[i].Table, BridgesOnTable[i].Order, false, BridgesOnTable[i].Current);
										BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Finishing of Tiimer Limitation Constraint.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											BridgesOnTable(i).BridgeThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1
									End While
								Else
									'When There is Possible Thinking Bridge of Gray Table
									'for Each Thinknking  Movments of Gray Bridges do Perational.
									j = 0
									While j < BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count
										'Initaiate of Local Varibales By Global Varoiables.
										BridgesOnTable(i).Row = CType(BridgesOnTable(i).BridgeThinking(0).RowColumnBridge(j)(0), Integer)
										BridgesOnTable(i).Column = CType(BridgesOnTable(i).BridgeThinking(0).RowColumnBridge(j)(1), Integer)
										'Construction of Thinking Variables By Local Variables.
										BridgesOnTable(i).Table = BridgesOnTable(i).BridgeThinking(0).TableListBridge(j)

										'Thinking of Gray Bridges  Objective Movments.
										BridgesOnTable(i).BridgeThinking(0).Table = BridgesOnTable(i).BridgeThinking(0).TableListBridge(j)
										BridgesOnTable(i).BridgeThinking(0).ThinkingBegin = True
										BridgesOnTable(i).BridgeThinking(0).ThinkingFinished = False
										BridgesOnTable(i).BridgeThinking(0).t = New Thread(New ThreadStart(BridgesOnTable(i).BridgeThinking(0).Thinking))
										BridgesOnTable(i).BridgeThinking(0).t.Start()
										'Wait For Thinking Finished.
										Wait(Me, i, j, 0, 4, False)
										BridgesOnTable(i).BridgeThinking(0).t.Abort()
										BridgesOnTable(i).BridgeThinking(0).t.Join()
										'If Gray Bridges Thinking Not Successful Continue Traversal Back.
										If BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count = 0 Then
											Continue While
										End If
										'Thinking of Gray Bridges Dept Traversal Back Operations.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										BridgesOnTable(i).BridgeThinking(0).Dept.Add(New AllDraw(THIS))
										'BridgesOnTable[i].BridgeThinking[0].Dept[BridgesOnTable[i].BridgeThinking[0].Dept.Count - 1].BridgesOnTable[i] = new DrawBridge(BridgesOnTable[i].Row, BridgesOnTable[i].Column, BridgesOnTable[i].color, BridgesOnTable[i].Table, BridgesOnTable[i].Order, false, BridgesOnTable[i].Current);
										BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initiate of Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'thinking of Finished Timer.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											BridgesOnTable(i).BridgeThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1

									End While
								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder
						Try
							'For All Possible Gray Minister Movments.
							i = 0
							While i < AllDraw.MinisterMidle
								ThinkingChess.Kind = 5
								'For Each Non Exist Gray Minister Objectives.
								If MinisterOnTable(i) Is Nothing Then
									Continue While
								End If
								'Inititate Local Variables By Global Varibales.
								ii = CType(MinisterOnTable(i).Row, Integer)
								jj = CType(MinisterOnTable(i).Column, Integer)
								'Construction of Thinking Objects Gray Minister.
								MinisterOnTable(i) = New DrawMinister(ii, jj, a, Table, Order, False, _
									i)
								'If There is Not Minister Of Gray In The Thinking Table List.   
								If MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count = 0 Then
									'For All Possible Movments.
									j = 0
									While j < AllDraw.MinisterMovments
										'Thinking of Gray Minister Operational.
										MinisterOnTable(i).MinisterThinking(0).Table = MinisterOnTable(i).MinisterThinking(0).Table
										MinisterOnTable(i).MinisterThinking(0).ThinkingBegin = True
										MinisterOnTable(i).MinisterThinking(0).ThinkingFinished = False
										MinisterOnTable(i).MinisterThinking(0).t = New Thread(New ThreadStart(MinisterOnTable(i).MinisterThinking(0).Thinking))
										MinisterOnTable(i).MinisterThinking(0).t.Start()
										'Wait For Thinking Finsihed.
										Wait(Me, i, j, 0, 5, False)
										MinisterOnTable(i).MinisterThinking(0).t.Abort()
										MinisterOnTable(i).MinisterThinking(0).t.Join()
										'If Gray Minister Thinking Not Successful Continue Traversal Back.                                      
										If MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Minister By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Minister By Alice!")
											THIS.RefreshBoxText()
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										'Thinking of Dept Gray Minister Recursive Main Calling.
										MinisterOnTable(i).MinisterThinking(0).Dept.Add(New AllDraw(THIS))
										'MinisterOnTable[i].MinisterThinking[0].Dept[MinisterOnTable[i].MinisterThinking[0].Dept.Count - 1].MinisterOnTable[i] = new DrawMinister(MinisterOnTable[i].Row, MinisterOnTable[i].Column, MinisterOnTable[i].color, MinisterOnTable[i].Table, MinisterOnTable[i].Order, false, MinisterOnTable[i].Current);
										MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Initiate of Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer Finishing Recursive. 
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											MinisterOnTable(i).MinisterThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1
									End While
								Else
									'When There is Table Gray Minister Count of Thinking.
									'For Each Table Gray Minister Count Thinking.
									j = 0
									While j < MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count
										'Inititate Local Variables By Global Varibales.
										MinisterOnTable(i).Row = CType(MinisterOnTable(i).MinisterThinking(0).RowColumnMinister(j)(0), Integer)
										MinisterOnTable(i).Column = CType(MinisterOnTable(i).MinisterThinking(0).RowColumnMinister(j)(1), Integer)
										'Construction of Thinking Objects Gray Minister.
										MinisterOnTable(i).Table = MinisterOnTable(i).MinisterThinking(0).TableListMinister(j)
										MinisterOnTable(i).MinisterThinking(0).ThinkingBegin = True
										MinisterOnTable(i).MinisterThinking(0).ThinkingFinished = False
										MinisterOnTable(i).MinisterThinking(0).t = New Thread(New ThreadStart(MinisterOnTable(i).MinisterThinking(0).Thinking))
										MinisterOnTable(i).MinisterThinking(0).t.Start()
										'Wait For thinking finsishing.
										Wait(Me, i, j, 0, 5, False)
										MinisterOnTable(i).MinisterThinking(0).t.Abort()
										MinisterOnTable(i).MinisterThinking(0).t.Join()
										'If Thinking of Table Gray M inister Thinking Not Successfull  Continuue traversal Back. 
										If MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count = 0 Then
											Continue While
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										MinisterOnTable(i).MinisterThinking(0).Dept.Add(New AllDraw(THIS))
										'MinisterOnTable[i].MinisterThinking[0].Dept[MinisterOnTable[i].MinisterThinking[0].Dept.Count - 1].MinisterOnTable[i] = new DrawMinister(MinisterOnTable[i].Row, MinisterOnTable[i].Column, MinisterOnTable[i].color, MinisterOnTable[i].Table, MinisterOnTable[i].Order, false, MinisterOnTable[i].Current);
										MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initiate of Global Vaaribalke By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer  Finsishing Recursive End Call.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											MinisterOnTable(i).MinisterThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1

									End While
								End If
								i += 1
							End While
						Catch t As Exception
							Log(t)
						End Try
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder


						'For All Possible Gray King Objects.
						i = 0
						While i < AllDraw.KingMidle
							Try
								ThinkingChess.Kind = 6
								'If There is Not Current Object Continue Traversal Back.
								If KingOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(CType(KingOnTable(i).Row, Integer), Integer)
								jj = CType(KingOnTable(i).Column, Integer)
								'Construction of Gray King Thinking Objects.
								KingOnTable(i) = New DrawKing(ii, jj, a, Table, Order, False, _
									i)
								'When There is Not Thinking Table Gray King Movments.
								If KingOnTable(i).KingThinking(0).TableListKing.Count = 0 Then
									'For All Possible Gray King Movments.
									j = 0
									While j < AllDraw.KingMovments
										'Thinking Of Gray King Operatins.
										KingOnTable(i).KingThinking(0).Table = KingOnTable(i).KingThinking(0).Table
										KingOnTable(i).KingThinking(0).ThinkingBegin = True
										KingOnTable(i).KingThinking(0).ThinkingFinished = False
										KingOnTable(i).KingThinking(0).t = New Thread(New ThreadStart(KingOnTable(i).KingThinking(0).Thinking))
										KingOnTable(i).KingThinking(0).t.Start()
										'Wait For Thinking Finishing.
										Wait(Me, i, j, 0, 6, False)
										KingOnTable(i).KingThinking(0).t.Abort()
										KingOnTable(i).KingThinking(0).t.Join()
										If KingOnTable(i).KingThinking(0).TableListKing.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For King By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For King By Alice!")
											THIS.RefreshBoxText()
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = -1
										ChessRules.CurrentOrder = -1
										KingOnTable(i).KingThinking(0).Dept.Add(New AllDraw(THIS))
										'KingOnTable[i].KingThinking[0].Dept[KingOnTable[i].KingThinking[0].Dept.Count - 1].KingOnTable[i] = new DrawKing(KingOnTable[i].Row, KingOnTable[i].Column, KingOnTable[i].color, KingOnTable[i].Table, KingOnTable[i].Order, false, KingOnTable[i].Current);
										KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'KingOnTable[i].KingThinking[0].Clone(ref KingOnTable[i].KingThinking[0].Dept[KingOnTable[i].KingThinking[0].Dept.Count - 1].KingOnTable[i].KingThinking[0], ref THIS);
										KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Initiate of Global Variables BVy Local Variables.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'End Timer of  Recursive Functions.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											KingOnTable(i).KingThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1


									End While
								Else
									'When Thinking Gray King Count of Existing Operations.
									'For Each Existing Gray King Thinking Count Objects Movments.
									j = 0
									While j < KingOnTable(i).KingThinking(0).TableListKing.Count
										'Initiate Local varibale By Global Objective Varibales.
										KingOnTable(i).Row = CType(CType(KingOnTable(i).KingThinking(0).RowColumnKing(j)(0), Integer), Integer)
										KingOnTable(i).Column = CType(KingOnTable(i).KingThinking(0).RowColumnKing(j)(0), Integer)
										'Construction of Gray King Thinking Objects.
										KingOnTable(i).Table = KingOnTable(i).KingThinking(0).TableListKing(j)
										'Gray King Thinking Operations.                                        
										KingOnTable(i).KingThinking(0).ThinkingBegin = True
										KingOnTable(i).KingThinking(0).ThinkingFinished = False
										KingOnTable(i).KingThinking(0).t = New Thread(New ThreadStart(KingOnTable(i).KingThinking(0).Thinking))
										KingOnTable(i).KingThinking(0).t.Start()
										'Wait For Thinking Finsishing.
										Wait(Me, i, j, 0, 6, False)

										KingOnTable(i).KingThinking(0).t.Abort()
										KingOnTable(i).KingThinking(0).t.Join()
										'If There is Thinking of Gray King Movments.
										If KingOnTable(i).KingThinking(0).TableListKing.Count = 0 Then
											Continue While
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order *= -1
										ChessRules.CurrentOrder *= -1
										KingOnTable(i).KingThinking(0).Dept.Add(New AllDraw(THIS))
										'KingOnTable[i].KingThinking[0].Dept[KingOnTable[i].KingThinking[0].Dept.Count - 1].KingOnTable[i] = new DrawKing(KingOnTable[i].Row, KingOnTable[i].Column, KingOnTable[i].color, KingOnTable[i].Table, KingOnTable[i].Order, false, KingOnTable[i].Current);
										KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initaiet of Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'End Timer Finsishing Recursive Calling.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											KingOnTable(i).KingThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1


									End While


								End If
							Catch t As Exception
								' KingOnTable[i] = null;
								Log(t)
							End Try
							i += 1
						End While
					Else
						'Brown Order Considarations.

						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder

						'For Each Objects of Brown Sodiers.
						i = AllDraw.SodierMidle
						While i < AllDraw.SodierHigh
							Try
								ThinkingChess.Kind = -1
								'Wheen Brown King Object There is Not Continue Traversal Back.
								If SolderesOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(SolderesOnTable(i).Row, Integer)
								jj = CType(SolderesOnTable(i).Column, Integer)
								'Construction of Thinking Brown Current Objects.
								SolderesOnTable(i) = New DrawSoldier(ii, jj, a, Table, Order, False, _
									i)
								If True Then
									'When There is Current Brown Object Table List Thinking Objective Movments.
									If SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count = 0 Then
										'For Each Brown Possible Movments. 
										j = 0
										While j < AllDraw.SodierMovments
											'Thinking Operations of Brown Current Objects.
											SolderesOnTable(i).SoldierThinking(0).Table = SolderesOnTable(i).SoldierThinking(0).Table
											SolderesOnTable(i).SoldierThinking(0).ThinkingBegin = True
											SolderesOnTable(i).SoldierThinking(0).ThinkingFinished = False
											SolderesOnTable(i).SoldierThinking(0).t = New Thread(New ThreadStart(SolderesOnTable(i).SoldierThinking(0).Thinking))
											SolderesOnTable(i).SoldierThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 1, False)
											SolderesOnTable(i).SoldierThinking(0).t.Abort()
											SolderesOnTable(i).SoldierThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Objective Movments. 
											If SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count = 0 Then
												Continue While
											End If
											If Order = 1 Then
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Soldier By Bob!")
												THIS.RefreshBoxText()
											Else
												'If Order is Brown.
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Soldier By Alice!")
												THIS.RefreshBoxText()
											End If
											'Initiate of Local Varibale By Global Orders.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											SolderesOnTable(i).SoldierThinking(0).Dept.Add(New AllDraw(THIS))
											'SolderesOnTable[i].SoldierThinking[0].Dept[SolderesOnTable[i].SoldierThinking[0].Dept.Count - 1].SolderesOnTable[i] = new DrawSoldier(SolderesOnTable[i].Row, SolderesOnTable[i].Column, SolderesOnTable[i].color, SolderesOnTable[i].Table, SolderesOnTable[i].Order, false, SolderesOnTable[i].Current);
											SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
												False, timer, TimerColor, Less)
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												SolderesOnTable(i).SoldierThinking(0).Dept = Nothing
												Return Nothing
											End If
											j += 1

										End While
									Else

										'When There is Current Brown Existing Objective Thinking Movments.
										'For Each Current Brown Existing Objective Thinking Movments.
										j = 0
										While j < SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count
											'Initiate of Local Variables By Global Objective Gray Current Solder.
											SolderesOnTable(i).Row = CType(SolderesOnTable(i).SoldierThinking(0).RowColumnSoldier(j)(0), Integer)
											SolderesOnTable(i).Column = CType(SolderesOnTable(i).SoldierThinking(0).RowColumnSoldier(j)(0), Integer)
											'Construction of Thinking Gray Soldier By Local Variables.
											SolderesOnTable(i).Table = SolderesOnTable(i).SoldierThinking(0).TableListSolder(j)
											'Thinking of Thinking Brown CurrentTable Objective Operations.
											SolderesOnTable(i).SoldierThinking(0).ThinkingBegin = True
											SolderesOnTable(i).SoldierThinking(0).ThinkingFinished = False
											SolderesOnTable(i).SoldierThinking(0).t = New Thread(New ThreadStart(SolderesOnTable(i).SoldierThinking(0).Thinking))
											SolderesOnTable(i).SoldierThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 1, False)
											SolderesOnTable(i).SoldierThinking(0).t.Abort()
											SolderesOnTable(i).SoldierThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Thinking Objective Movments. 
											If SolderesOnTable(i).SoldierThinking(0).TableListSolder.Count = 0 Then
												Continue While
											End If
											'Dept Brown Thinking of Thinking Curretn Object Recursive Main Method Calling.                                           
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											SolderesOnTable(i).SoldierThinking(0).Dept.Add(New AllDraw(THIS))
											'SolderesOnTable[i].SoldierThinking[0].Dept[SolderesOnTable[i].SoldierThinking[0].Dept.Count - 1].SolderesOnTable[i] = new DrawSoldier(SolderesOnTable[i].Row, SolderesOnTable[i].Column, SolderesOnTable[i].color, SolderesOnTable[i].Table, SolderesOnTable[i].Order, false, SolderesOnTable[i].Current);
											SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(SolderesOnTable(i).SoldierThinking(0).Dept(SolderesOnTable(i).SoldierThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												SolderesOnTable(i).SoldierThinking(0).Dept = Nothing
												Return Nothing
											End If
											j += 1

										End While
									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder

						i = AllDraw.ElefantMidle
						While i < AllDraw.ElefantHigh
							Try
								ThinkingChess.Kind = -2
								If ElephantOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(ElephantOnTable(i).Row, Integer)
								jj = CType(ElephantOnTable(i).Column, Integer)
								'Construction of Thinking Brown Current Objects.
								ElephantOnTable(i) = New DrawElefant(ii, jj, a, Table, Order, False, _
									i)
								If True Then
									'When There is Current Brown Object Table List Thinking Objective Movments.
									If ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count = 0 Then
										'For Each Brown Possible Movments. 
										j = 0
										While j < AllDraw.ElefantMovments
											'Thinking Operations of Brown Current Objects.
											ElephantOnTable(i).ElefantThinking(0).Table = ElephantOnTable(i).ElefantThinking(0).Table
											ElephantOnTable(i).ElefantThinking(0).ThinkingBegin = True
											ElephantOnTable(i).ElefantThinking(0).ThinkingFinished = False
											ElephantOnTable(i).ElefantThinking(0).t = New Thread(New ThreadStart(ElephantOnTable(i).ElefantThinking(0).Thinking))
											ElephantOnTable(i).ElefantThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 2, False)
											ElephantOnTable(i).ElefantThinking(0).t.Abort()
											ElephantOnTable(i).ElefantThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Objective Movments. 
											If ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count = 0 Then
												Continue While
											End If
											If Order = 1 Then
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Elephant By Bob!")
												THIS.RefreshBoxText()
											Else
												'If Order is Brown.
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Elephant By Alice!")
												THIS.RefreshBoxText()
											End If

											'Initiate of Local Varibale By Global Orders.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											ElephantOnTable(i).ElefantThinking(0).Dept.Add(New AllDraw(THIS))
											'ElephantOnTable[i].ElefantThinking[0].Dept[ElephantOnTable[i].ElefantThinking[0].Dept.Count - 1].ElephantOnTable[i] = new DrawElefant(ElephantOnTable[i].Row, ElephantOnTable[i].Column, ElephantOnTable[i].color, ElephantOnTable[i].Table, ElephantOnTable[i].Order, false, ElephantOnTable[i].Current);
											ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
												False, timer, TimerColor, Less)
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												ElephantOnTable(i).ElefantThinking(0).Dept = Nothing
												Return Nothing
											End If
											j += 1
										End While
									Else
										'When There is Current Brown Existing Objective Thinking Movments.
										'For Each Current Brown Existing Objective Thinking Movments.
										j = 0
										While j < ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count
											'Inititae Local Varibale By Global Gray Elephant Objects Varibales.
											ElephantOnTable(i).Row = CType(ElephantOnTable(i).ElefantThinking(0).RowColumnElefant(j)(0), Integer)
											ElephantOnTable(i).Column = CType(ElephantOnTable(i).ElefantThinking(0).RowColumnElefant(j)(1), Integer)
											'Construction of Thinking Objects By Local Varibales.
											ElephantOnTable(i).Table = ElephantOnTable(i).ElefantThinking(0).TableListElefant(j)
											'Thinking of Thinking Brown CurrentTable Objective Operations.                                                   
											ElephantOnTable(i).ElefantThinking(0).ThinkingBegin = True
											ElephantOnTable(i).ElefantThinking(0).ThinkingFinished = False
											ElephantOnTable(i).ElefantThinking(0).t = New Thread(New ThreadStart(ElephantOnTable(i).ElefantThinking(0).Thinking))
											ElephantOnTable(i).ElefantThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 2, False)
											ElephantOnTable(i).ElefantThinking(0).t.Abort()
											ElephantOnTable(i).ElefantThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Thinking Objective Movments. 
											If ElephantOnTable(i).ElefantThinking(0).TableListElefant.Count = 0 Then
												Continue While
											End If
											'Initiate of Local Varibale By Global Orders.
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											ElephantOnTable(i).ElefantThinking(0).Dept.Add(New AllDraw(THIS))
											'ElephantOnTable[i].ElefantThinking[0].Dept[ElephantOnTable[i].ElefantThinking[0].Dept.Count - 1].ElephantOnTable[i] = new DrawElefant(ElephantOnTable[i].Row, ElephantOnTable[i].Column, ElephantOnTable[i].color, ElephantOnTable[i].Table, ElephantOnTable[i].Order, false, ElephantOnTable[i].Current);
											ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(ElephantOnTable(i).ElefantThinking(0).Dept(ElephantOnTable(i).ElefantThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												ElephantOnTable(i).ElefantThinking(0).Dept = Nothing
												Return Nothing
											End If
											j += 1
										End While
									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder



						i = AllDraw.HourseMidle
						While i < AllDraw.HourseHight
							Try
								ThinkingChess.Kind = -3
								If HoursesOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(HoursesOnTable(i).Row, Integer)
								jj = CType(HoursesOnTable(i).Column, Integer)
								'Construction of Thinking Brown Current Objects.
								HoursesOnTable(i) = New DrawHourse(ii, jj, a, Table, Order, False, _
									i)

								If True Then
									'When There is Current Brown Object Table List Thinking Objective Movments.
									If HoursesOnTable(i).HourseThinking(0).TableListHourse.Count = 0 Then
										'For Each Brown Possible Movments. 
										j = 0
										While j < AllDraw.HourseMovments
											'Thinking Operations of Brown Current Objects.
											HoursesOnTable(i).HourseThinking(0).Table = HoursesOnTable(i).HourseThinking(0).Table
											HoursesOnTable(i).HourseThinking(0).ThinkingBegin = True
											HoursesOnTable(i).HourseThinking(0).ThinkingFinished = False
											HoursesOnTable(i).HourseThinking(0).t = New Thread(New ThreadStart(HoursesOnTable(i).HourseThinking(0).Thinking))
											HoursesOnTable(i).HourseThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 3, False)
											HoursesOnTable(i).HourseThinking(0).t.Abort()
											HoursesOnTable(i).HourseThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Objective Movments. 
											If HoursesOnTable(i).HourseThinking(0).TableListHourse.Count = 0 Then
												Continue While
											End If
											If Order = 1 Then
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Hourse By Bob!")
												THIS.RefreshBoxText()
											Else
												'If Order is Brown.
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Hourse By Alice!")
												THIS.RefreshBoxText()
											End If

											'Initiate of Local Varibale By Global Orders.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											'Dept Brown Thinking Curretn Object Recursive Main Method Calling.
											'AllDraw AdumnmyConstructedD = new AllDraw(ref THIS);
											'this.CopyRemeiningItems(AdumnmyConstructedD);
											'AdumnmyConstructedD.HoursesOnTable[i].HourseThinking[0] = HoursesOnTable[i].HourseThinking[0];
											'Dummy = AdumnmyConstructedD;
											'int[,] Taba = ADraw[0].HuristicCurrentTable(ADraw[0], a, Order);
											HoursesOnTable(i).HourseThinking(0).Dept.Add(New AllDraw(THIS))
											'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].HoursesOnTable[i] = new DrawHourse(HoursesOnTable[i].Row, HoursesOnTable[i].Column, HoursesOnTable[i].color, HoursesOnTable[i].Table, HoursesOnTable[i].Order, false, HoursesOnTable[i].Current);
											HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1), Order * -1)
											'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].TableList.Clear();
											'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].TableList.Add(HoursesOnTable[i].HourseThinking[0].Table);
											'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].SetRowColumn(0);
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											'HoursesOnTable[i].HourseThinking[0].Clone(ref HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].HoursesOnTable[i].HourseThinking[0], ref THIS);
											HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
												False, timer, TimerColor, Less)
											'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].Clone(HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1]);
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												HoursesOnTable(i).HourseThinking(0).Dept = Nothing
												Return Nothing

											End If
											j += 1
										End While
									Else
										'When There is Current Brown Existing Objective Thinking Movments.
										'For Each Current Brown Existing Objective Thinking Movments.
										j = 0
										While j < HoursesOnTable(i).HourseThinking(0).TableListHourse.Count
											'Initiate of Local Variables By Global Gray Hourse Objectives.
											HoursesOnTable(i).Row = CType(HoursesOnTable(i).HourseThinking(0).RowColumnHourse(j)(0), Integer)
											HoursesOnTable(i).Column = CType(HoursesOnTable(i).HourseThinking(0).RowColumnHourse(j)(1), Integer)
											'Construction of Gray Hourse Thinking Objects..
											HoursesOnTable(i).Table = HoursesOnTable(i).HourseThinking(0).TableListHourse(j)
											'Thinking of Thinking Brown CurrentTable Objective Operations.                                          SolderesOnTable[i].SoldierThinking[0].Table = SolderesOnTable[i].SoldierThinking[0].TableListSolder[j];
											HoursesOnTable(i).HourseThinking(0).ThinkingBegin = True
											HoursesOnTable(i).HourseThinking(0).ThinkingFinished = False
											HoursesOnTable(i).HourseThinking(0).t = New Thread(New ThreadStart(HoursesOnTable(i).HourseThinking(0).Thinking))
											HoursesOnTable(i).HourseThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 3, False)
											HoursesOnTable(i).HourseThinking(0).t.Abort()
											HoursesOnTable(i).HourseThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Thinking Objective Movments. 
											If HoursesOnTable(i).HourseThinking(0).TableListHourse.Count = 0 Then
												Continue While
											End If
											'Initiate of Local Varibale By Global Orders.
											ChessRules.CurrentOrder *= -1
											'Dept Brown Thinking of Thinking Curretn Object Recursive Main Method Calling.                                           
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											HoursesOnTable(i).HourseThinking(0).Dept.Add(New AllDraw(THIS))
											'HoursesOnTable[i].HourseThinking[0].Dept[HoursesOnTable[i].HourseThinking[0].Dept.Count - 1].HoursesOnTable[i] = new DrawHourse(HoursesOnTable[i].Row, HoursesOnTable[i].Column, HoursesOnTable[i].color, HoursesOnTable[i].Table, HoursesOnTable[i].Order, false, HoursesOnTable[i].Current);
											HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(HoursesOnTable(i).HourseThinking(0).Dept(HoursesOnTable(i).HourseThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												HoursesOnTable(i).HourseThinking(0).Dept = Nothing
												Return Nothing

											End If
											j += 1
										End While
									End If

								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder




						i = AllDraw.BridgeMidle
						While i < AllDraw.BridgeHigh
							Try
								ThinkingChess.Kind = -4
								If BridgesOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(BridgesOnTable(i).Row, Integer)
								jj = CType(BridgesOnTable(i).Column, Integer)
								'Construction of Thinking Brown Current Objects.
								BridgesOnTable(i) = New DrawBridge(ii, jj, a, Table, Order, False, _
									i)

								If True Then
									'When There is Current Brown Object Table List Thinking Objective Movments.
									If BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count = 0 Then
										'For Each Brown Possible Movments. 
										j = 0
										While j < AllDraw.BridgeMovments
											'Thinking Operations of Brown Current Objects.
											BridgesOnTable(i).BridgeThinking(0).Table = BridgesOnTable(i).BridgeThinking(0).Table
											BridgesOnTable(i).BridgeThinking(0).ThinkingBegin = True
											BridgesOnTable(i).BridgeThinking(0).ThinkingFinished = False
											BridgesOnTable(i).BridgeThinking(0).t = New Thread(New ThreadStart(BridgesOnTable(i).BridgeThinking(0).Thinking))
											BridgesOnTable(i).BridgeThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 4, False)
											BridgesOnTable(i).BridgeThinking(0).t.Abort()
											BridgesOnTable(i).BridgeThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Objective Movments. 
											If BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count = 0 Then
												Continue While
											End If
											If Order = 1 Then
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Bridges By Bob!")
												THIS.RefreshBoxText()
											Else
												'If Order is Brown.
												THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Bridges By Alice!")
												THIS.RefreshBoxText()
											End If

											'Initiate of Local Varibale By Global Orders.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											BridgesOnTable(i).BridgeThinking(0).Dept.Add(New AllDraw(THIS))
											'BridgesOnTable[i].BridgeThinking[0].Dept[BridgesOnTable[i].BridgeThinking[0].Dept.Count - 1].BridgesOnTable[i] = new DrawBridge(BridgesOnTable[i].Row, BridgesOnTable[i].Column, BridgesOnTable[i].color, BridgesOnTable[i].Table, BridgesOnTable[i].Order, false, BridgesOnTable[i].Current);
											BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
												False, timer, TimerColor, Less)
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												BridgesOnTable(i).BridgeThinking(0).Dept = Nothing
												Return Nothing
											End If
											j += 1
										End While
									Else
										'When There is Current Brown Existing Objective Thinking Movments.
										'For Each Current Brown Existing Objective Thinking Movments.
										j = 0
										While j < BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count
											'Initaiate of Local Varibales By Global Varoiables.
											BridgesOnTable(i).Row = CType(BridgesOnTable(i).BridgeThinking(0).RowColumnBridge(j)(0), Integer)
											BridgesOnTable(i).Column = CType(BridgesOnTable(i).BridgeThinking(0).RowColumnBridge(j)(1), Integer)
											'Construction of Thinking Variables By Local Variables.
											BridgesOnTable(i).Table = BridgesOnTable(i).BridgeThinking(0).TableListBridge(j)
											'Thinking of Thinking Brown CurrentTable Objective Operations.        
											BridgesOnTable(i).BridgeThinking(0).ThinkingBegin = True
											BridgesOnTable(i).BridgeThinking(0).ThinkingFinished = False
											BridgesOnTable(i).BridgeThinking(0).t = New Thread(New ThreadStart(BridgesOnTable(i).BridgeThinking(0).Thinking))
											BridgesOnTable(i).BridgeThinking(0).t.Start()
											'Wait For Brown Current Objects Thinking Finishing.
											Wait(Me, i, j, 0, 4, False)
											BridgesOnTable(i).BridgeThinking(0).t.Abort()
											BridgesOnTable(i).BridgeThinking(0).t.Join()
											'If There is Not Brown Thinking Successfule Thinking Objective Movments. 
											If BridgesOnTable(i).BridgeThinking(0).TableListBridge.Count = 0 Then
												Continue While
											End If
											'Dept Brown Thinking of Thinking Curretn Object Recursive Main Method Calling.                                           
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											If Order * -1 = 1 Then
												a = Color.Gray
											Else
												a = Color.Brown
											End If
											Order = 1
											ChessRules.CurrentOrder = 1
											BridgesOnTable(i).BridgeThinking(0).Dept.Add(New AllDraw(THIS))
											'BridgesOnTable[i].BridgeThinking[0].Dept[BridgesOnTable[i].BridgeThinking[0].Dept.Count - 1].BridgesOnTable[i] = new DrawBridge(BridgesOnTable[i].Row, BridgesOnTable[i].Column, BridgesOnTable[i].color, BridgesOnTable[i].Table, BridgesOnTable[i].Order, false, BridgesOnTable[i].Current);
											BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(BridgesOnTable(i).BridgeThinking(0).Dept(BridgesOnTable(i).BridgeThinking(0).Dept.Count - 1), Order * -1)
											'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
											'Initaite Of Brown Order Global Varibales By Local Varibales.
											Order = DummyOrder
											ChessRules.CurrentOrder = DummyCurrentOrder
											'Timer finsishing of Ending Operation in Recursive Calling.
											S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
											If S = -1 Then
												'have to Zero. Non Decreamet Algorithm not found.
												DeptiLevelMax = 0
											End If

											If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
												BridgesOnTable(i).BridgeThinking(0).Dept = Nothing
												Return Nothing
											End If
											j += 1
										End While
									End If

								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder
						i = AllDraw.MinisterMidle
						While i < AllDraw.MinisterHigh
							Try
								ThinkingChess.Kind = -5
								If MinisterOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(MinisterOnTable(i).Row, Integer)
								jj = CType(MinisterOnTable(i).Column, Integer)
								'Construction of Thinking Brown Current Objects.
								MinisterOnTable(i) = New DrawMinister(ii, jj, a, Table, Order, False, _
									i)

								'When There is Current Brown Object Table List Thinking Objective Movments.
								If MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count = 0 Then
									'For Each Brown Possible Movments. 
									j = 0
									While j < AllDraw.MinisterMovments
										'Thinking Operations of Brown Current Objects.
										MinisterOnTable(i).MinisterThinking(0).Table = MinisterOnTable(i).MinisterThinking(0).Table
										MinisterOnTable(i).MinisterThinking(0).ThinkingBegin = True
										MinisterOnTable(i).MinisterThinking(0).ThinkingFinished = False
										MinisterOnTable(i).MinisterThinking(0).t = New Thread(New ThreadStart(MinisterOnTable(i).MinisterThinking(0).Thinking))
										MinisterOnTable(i).MinisterThinking(0).t.Start()
										'Wait For Brown Current Objects Thinking Finishing.
										Wait(Me, i, j, 0, 5, False)
										MinisterOnTable(i).MinisterThinking(0).t.Abort()
										MinisterOnTable(i).MinisterThinking(0).t.Join()
										'If There is Not Brown Thinking Successfule Objective Movments. 
										If MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Minister By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For Minister By Alice!")
											THIS.RefreshBoxText()
										End If

										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = 1
										ChessRules.CurrentOrder = 1
										'Dept Brown Thinking of Thinking Curretn Object Recursive Main Method Calling.                                           
										MinisterOnTable(i).MinisterThinking(0).Dept.Add(New AllDraw(THIS))
										'MinisterOnTable[i].MinisterThinking[0].Dept[MinisterOnTable[i].MinisterThinking[0].Dept.Count - 1].MinisterOnTable[i] = new DrawMinister(MinisterOnTable[i].Row, MinisterOnTable[i].Column, MinisterOnTable[i].color, MinisterOnTable[i].Table, MinisterOnTable[i].Order, false, MinisterOnTable[i].Current);
										MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Initaite Of Brown Order Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer finsishing of Ending Operation in Recursive Calling.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											MinisterOnTable(i).MinisterThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1
									End While
								Else
									'When There is Current Brown Existing Objective Thinking Movments.
									'For Each Current Brown Existing Objective Thinking Movments.
									j = 0
									While j < MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count
										'Inititate Local Variables By Global Varibales.
										MinisterOnTable(i).Row = CType(MinisterOnTable(i).MinisterThinking(0).RowColumnMinister(j)(0), Integer)
										MinisterOnTable(i).Column = CType(MinisterOnTable(i).MinisterThinking(0).RowColumnMinister(j)(1), Integer)
										'Construction of Thinking Objects Gray Minister.
										MinisterOnTable(i).Table = MinisterOnTable(i).MinisterThinking(0).TableListMinister(j)
										'Thinking of Thinking Brown CurrentTable Objective Operations.                                          SolderesOnTable[i].SoldierThinking[0].Table = SolderesOnTable[i].SoldierThinking[0].TableListSolder[j];
										MinisterOnTable(i).MinisterThinking(0).ThinkingBegin = True
										MinisterOnTable(i).MinisterThinking(0).ThinkingFinished = False
										MinisterOnTable(i).MinisterThinking(0).t = New Thread(New ThreadStart(MinisterOnTable(i).MinisterThinking(0).Thinking))
										MinisterOnTable(i).MinisterThinking(0).t.Start()
										'Wait For Brown Current Objects Thinking Finishing.
										Wait(Me, i, j, 0, 5, False)
										MinisterOnTable(i).MinisterThinking(0).t.Abort()
										MinisterOnTable(i).MinisterThinking(0).t.Join()
										'If There is Not Brown Thinking Successfule Thinking Objective Movments. 
										If MinisterOnTable(i).MinisterThinking(0).TableListMinister.Count = 0 Then
											Continue While
										End If
										'Dept Brown Thinking of Thinking Curretn Object Recursive Main Method Calling.                                           
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = 1
										ChessRules.CurrentOrder = 1
										MinisterOnTable(i).MinisterThinking(0).Dept.Add(New AllDraw(THIS))
										'MinisterOnTable[i].MinisterThinking[0].Dept[MinisterOnTable[i].MinisterThinking[0].Dept.Count - 1].MinisterOnTable[i] = new DrawMinister(MinisterOnTable[i].Row, MinisterOnTable[i].Column, MinisterOnTable[i].color, MinisterOnTable[i].Table, MinisterOnTable[i].Order, false, MinisterOnTable[i].Current);
										MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(MinisterOnTable(i).MinisterThinking(0).Dept(MinisterOnTable(i).MinisterThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initaite Of Brown Order Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer finsishing of Ending Operation in Recursive Calling.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											MinisterOnTable(i).MinisterThinking(0).Dept = Nothing
											Return Nothing
										End If
										j += 1

									End While
								End If
							Catch t As Exception
								Log(t)
							End Try
							i += 1
						End While
						'Progressing.
						'if (iDept == 1)
						If True Then
							IncreaseprogressBarRefregitzValue(THIS.progressBarVerify, increasedProgress)
							THIS.progressBarVerify.Invalidate()
							SetprogressBarUpdate(THIS.progressBarVerify)
						End If
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder


						i = AllDraw.KingMidle
						While i < AllDraw.KingHigh
							Try
								ThinkingChess.Kind = -6
								If KingOnTable(i) Is Nothing Then
									Continue Try
								End If
								'Initiate Local varibale By Global Objective Varibales.
								ii = CType(KingOnTable(i).Row, Integer)
								jj = CType(KingOnTable(i).Column, Integer)
								'Construction of Thinking Brown Current Objects.
								KingOnTable(i) = New DrawKing(ii, jj, a, Table, Order, False, _
									i)

								'When There is Current Brown Object Table List Thinking Objective Movments.
								If KingOnTable(i).KingThinking(0).TableListKing.Count = 0 Then
									'For Each Brown Possible Movments. 
									j = 0
									While j < AllDraw.KingMovments
										'Thinking Operations of Brown Current Objects.
										KingOnTable(i).KingThinking(0).Table = KingOnTable(i).KingThinking(0).Table
										KingOnTable(i).KingThinking(0).ThinkingBegin = True
										KingOnTable(i).KingThinking(0).ThinkingFinished = False
										KingOnTable(i).KingThinking(0).t = New Thread(New ThreadStart(KingOnTable(i).KingThinking(0).Thinking))
										KingOnTable(i).KingThinking(0).t.Start()
										'Wait For Brown Current Objects Thinking Finishing.
										Wait(Me, i, j, 0, 6, False)
										KingOnTable(i).KingThinking(0).t.Abort()
										KingOnTable(i).KingThinking(0).t.Join()
										'If There is Not Brown Thinking Successfule Objective Movments. 
										If KingOnTable(i).KingThinking(0).TableListKing.Count = 0 Then
											Continue While
										End If
										'Initiate of Local Varibale By Global Orders.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = 1
										ChessRules.CurrentOrder = 1
										KingOnTable(i).KingThinking(0).Dept.Add(New AllDraw(THIS))
										'KingOnTable[i].KingThinking[0].Dept[KingOnTable[i].KingThinking[0].Dept.Count - 1].KingOnTable[i] = new DrawKing(KingOnTable[i].Row, KingOnTable[i].Column, KingOnTable[i].color, KingOnTable[i].Table, KingOnTable[i].Order, false, KingOnTable[i].Current);
										KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, Table, Order, _
											False, timer, TimerColor, Less)
										'Initaite Of Brown Order Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer finsishing of Ending Operation in Recursive Calling.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											KingOnTable(i).KingThinking(0).Dept = Nothing
											Return Nothing

										End If
										j += 1
									End While
								Else
									'When There is Current Brown Existing Objective Thinking Movments.
									'For Each Current Brown Existing Objective Thinking Movments.
									j = 0
									While j < KingOnTable(i).KingThinking(0).TableListKing.Count
										'Initiate Local varibale By Global Objective Varibales.
										KingOnTable(i).Row = CType(KingOnTable(i).KingThinking(0).RowColumnKing(j)(0), Integer)
										KingOnTable(i).Column = CType(KingOnTable(i).KingThinking(0).RowColumnKing(j)(0), Integer)
										'Construction of Thinking Brown Current Objects.
										KingOnTable(i).Table = KingOnTable(i).KingThinking(0).TableListKing(j)
										'Thinking of Thinking Brown CurrentTable Objective Operations.       
										KingOnTable(i).KingThinking(0).Table = KingOnTable(i).KingThinking(0).TableListKing(j)
										KingOnTable(i).KingThinking(0).ThinkingBegin = True
										KingOnTable(i).KingThinking(0).ThinkingFinished = False
										KingOnTable(i).KingThinking(0).t = New Thread(New ThreadStart(KingOnTable(i).KingThinking(0).Thinking))
										KingOnTable(i).KingThinking(0).t.Start()
										'Wait For Brown Current Objects Thinking Finishing.
										Wait(Me, i, j, 0, 6, False)
										KingOnTable(i).KingThinking(0).t.Abort()
										KingOnTable(i).KingThinking(0).t.Join()
										'If There is Not Brown Thinking Successfule Thinking Objective Movments. 
										If KingOnTable(i).KingThinking(0).TableListKing.Count = 0 Then
											Continue While
										End If
										If Order = 1 Then
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For King By Bob!")
											THIS.RefreshBoxText()
										Else
											'If Order is Brown.
											THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " For King By Alice!")
											THIS.RefreshBoxText()
										End If

										'Dept Brown Thinking of Thinking Curretn Object Recursive Main Method Calling.                                           
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										If Order * -1 = 1 Then
											a = Color.Gray
										Else
											a = Color.Brown
										End If
										Order = 1
										ChessRules.CurrentOrder = 1
										KingOnTable(i).KingThinking(0).Dept.Add(New AllDraw(THIS))
										'KingOnTable[i].KingThinking[0].Dept[KingOnTable[i].KingThinking[0].Dept.Count - 1].KingOnTable[i] = new DrawKing(KingOnTable[i].Row, KingOnTable[i].Column, KingOnTable[i].color, KingOnTable[i].Table, KingOnTable[i].Order, false, KingOnTable[i].Current);
										KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1) = Me.CopyRemeiningItems(KingOnTable(i).KingThinking(0).Dept(KingOnTable(i).KingThinking(0).Dept.Count - 1), Order * -1)
										'Dummy = this.CopyRemeiningItems(Dummy, Order * -1);
										'Initaite Of Brown Order Global Varibales By Local Varibales.
										Order = DummyOrder
										ChessRules.CurrentOrder = DummyCurrentOrder
										'Timer finsishing of Ending Operation in Recursive Calling.
										S = (TimerColor.DeptiLevelMaxInitiate(timer, iDept))
										If S = -1 Then
											'have to Zero. Non Decreamet Algorithm not found.
											DeptiLevelMax = 0
										End If

										If iDept > DeptiLevelMax AndAlso iDept <> 1 Then
											KingOnTable(i).KingThinking(0).Dept = Nothing
											Return Nothing

										End If
										j += 1

									End While
								End If
							Catch t As Exception
								KingOnTable(i) = Nothing
								Log(t)
							End Try
							i += 1
						End While
					End If
				End If



				Order = DummyOrder
				ChessRules.CurrentOrder = DummyCurrentOrder

				'Blitz Condition Section
				If iDept <> MaxDept AndAlso Not MaxNotFound Then
					'to found of best movment in current dept.
					'initiate local variables.
					Dim [iF] As New List(Of Integer)(), jF As New List(Of Integer)(), kF As New List(Of Integer)()
					Order = DummyOrder
					ChessRules.CurrentOrder = DummyCurrentOrder
					Dim ObjectNumber As List(Of List(Of Integer)) = Nothing
					'found of best movment index.
					'depend of found act inner thinking tree development.
					If Not (FormRefrigtz.Blitz) Then
						ObjectNumber = FoundOfBestMovments(iDept - 1, [iF], jF, kF, Me, a, _
							Order)
					End If

					Order = DummyOrder
					ChessRules.CurrentOrder = DummyCurrentOrder
					'Condition of Order Consideration.
					If (Not FormRefrigtz.Blitz) AndAlso (ObjectNumber(0).Count > 0 OrElse ObjectNumber(1).Count > 0 OrElse ObjectNumber(2).Count > 0 OrElse ObjectNumber(3).Count > 0 OrElse ObjectNumber(4).Count > 0 OrElse ObjectNumber(5).Count > 0) Then
						ChessRules.CurrentOrder *= -1
						'Gray Order.
						If Order * -1 = 1 Then
							a = Color.Gray
						Else
							'Brown Order.
							a = Color.Brown
						End If
						'Next Order.
						Order *= -1
					End If
					'When There is Not Blitz Game Consider Dept First Initiation and calculation.
					If Not (FormRefrigtz.Blitz) Then

						'Soldeir
						Dim ik As Integer = 1
						While ik < ObjectNumber(0).Count
							Try
								SolderesOnTable(ObjectNumber(0)(ik)).SoldierThinking(0).Dept(SolderesOnTable(ObjectNumber(0)(ik)).SoldierThinking(0).Dept.Count - 1) = New AllDraw(THIS)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Elephant
						Dim ik As Integer = 1
						While ik < ObjectNumber(1).Count
							Try
								ElephantOnTable(ObjectNumber(1)(ik)).ElefantThinking(0).Dept(ElephantOnTable(ObjectNumber(1)(ik)).ElefantThinking(0).Dept.Count - 1) = New AllDraw(THIS)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Hourse.
						Dim ik As Integer = 1
						While ik < ObjectNumber(2).Count
							Try
								HoursesOnTable(ObjectNumber(2)(ik)).HourseThinking(0).Dept(HoursesOnTable(ObjectNumber(2)(ik)).HourseThinking(0).Dept.Count - 1) = New AllDraw(THIS)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Bridge.
						Dim ik As Integer = 1
						While ik < ObjectNumber(3).Count
							Try
								BridgesOnTable(ObjectNumber(3)(ik)).BridgeThinking(0).Dept(BridgesOnTable(ObjectNumber(3)(ik)).BridgeThinking(0).Dept.Count - 1) = New AllDraw(THIS)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Minister.
						Dim ik As Integer = 1
						While ik < ObjectNumber(4).Count
							Try
								MinisterOnTable(ObjectNumber(4)(ik)).MinisterThinking(0).Dept(MinisterOnTable(ObjectNumber(4)(ik)).MinisterThinking(0).Dept.Count - 1) = New AllDraw(THIS)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'King.
						Dim ik As Integer = 1
						While ik < ObjectNumber(5).Count
							Try
								KingOnTable(ObjectNumber(5)(ik)).KingThinking(0).Dept(KingOnTable(ObjectNumber(5)(ik)).KingThinking(0).Dept.Count - 1) = New AllDraw(THIS)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
					End If
					Dim PreviousLess As Double = -999999999999999999L

					'When thre is not B litz Game Calculate Dept First Searching Conditions and Calculation. 
					If Not (FormRefrigtz.Blitz) Then
						'sodier
						Dim ik As Integer = 0
						While ik < ObjectNumber(0).Count
							Try

								SolderesOnTable(ObjectNumber(0)(ik)).SoldierThinking(0).Dept(SolderesOnTable(ObjectNumber(0)(ik)).SoldierThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
									False, timer, TimerColor, Less)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Elephant
						Dim ik As Integer = 0
						While ik < ObjectNumber(1).Count
							Try
								ElephantOnTable(ObjectNumber(1)(ik)).ElefantThinking(0).Dept(ElephantOnTable(ObjectNumber(1)(ik)).ElefantThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
									False, timer, TimerColor, Less)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Hourse.
						Dim ik As Integer = 0
						While ik < ObjectNumber(2).Count
							Try
								HoursesOnTable(ObjectNumber(2)(ik)).HourseThinking(0).Dept(HoursesOnTable(ObjectNumber(2)(ik)).HourseThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
									False, timer, TimerColor, Less)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Bridges.                        
						Dim ik As Integer = 0
						While ik < ObjectNumber(3).Count
							Try
								BridgesOnTable(ObjectNumber(3)(ik)).BridgeThinking(0).Dept(BridgesOnTable(ObjectNumber(3)(ik)).BridgeThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
									False, timer, TimerColor, Less)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'Minister.
						Dim ik As Integer = 0
						While ik < ObjectNumber(4).Count
							Try
								MinisterOnTable(ObjectNumber(4)(ik)).MinisterThinking(0).Dept(MinisterOnTable(ObjectNumber(4)(ik)).MinisterThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
									False, timer, TimerColor, Less)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
						'King.
						Dim ik As Integer = 0
						While ik < ObjectNumber(5).Count
							Try
								KingOnTable(ObjectNumber(5)(ik)).KingThinking(0).Dept(KingOnTable(ObjectNumber(5)(ik)).KingThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
									False, timer, TimerColor, Less)
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
							ik += 1
						End While
					Else
						'When There is Blitz Game.
						'Initiatye Variables.
						Order = DummyOrder
						ChessRules.CurrentOrder = DummyCurrentOrder

						ChessRules.CurrentOrder *= -1
						If Order * -1 = 1 Then
							a = Color.Gray
						Else
							a = Color.Brown
						End If
						Order *= -1
						'For Gray Order calculating foreach Objects Maximum total Huristic Count Incl;usively.
						If Order = -1 Then
							'Soldeir
							Dim ik As Integer = AllDraw.SodierMidle
							While ik < AllDraw.SodierHigh
								Try
									If True Then

										If SolderesOnTable(ik).SoldierThinking(0).ReturnHuristic(i, j) < PreviousLess Then
											SolderesOnTable(ik).SoldierThinking(0).Dept = Nothing
											SolderesOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = SolderesOnTable(ik).SoldierThinking(0).ReturnHuristic(i, j)
										End If

									End If
									If SolderesOnTable(ik).SoldierThinking(0).Dept.Count = 0 Then
										SolderesOnTable(ik).SoldierThinking(0).Dept.Add(New AllDraw(THIS))
									End If
										'Elephant
									SolderesOnTable(ik).SoldierThinking(0).Dept(SolderesOnTable(ik).SoldierThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Elephant
							Dim ik As Integer = AllDraw.ElefantMidle
							While ik < AllDraw.ElefantHigh
								Try
									If True Then
										If ElephantOnTable(ik).ElefantThinking(0).ReturnHuristic(i, j) < PreviousLess Then
											ElephantOnTable(ik).ElefantThinking(0).Dept = Nothing
											ElephantOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = ElephantOnTable(ik).ElefantThinking(0).ReturnHuristic(i, j)
										End If
									End If
									If ElephantOnTable(ik).ElefantThinking(0).Dept.Count = 0 Then
										ElephantOnTable(ik).ElefantThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									ElephantOnTable(ik).ElefantThinking(0).Dept(ElephantOnTable(ik).ElefantThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Hourse.
							Dim ik As Integer = AllDraw.HourseMidle
							While ik < AllDraw.HourseHight
								Try
									If True Then
										If HoursesOnTable(ik).HourseThinking(0).ReturnHuristic(i, j) < PreviousLess Then
											HoursesOnTable(ik).HourseThinking(0).Dept = Nothing
											Continue Try
										Else
											PreviousLess = HoursesOnTable(ik).HourseThinking(0).ReturnHuristic(i, j)
										End If
									End If
									If HoursesOnTable(ik).HourseThinking(0).Dept.Count = 0 Then
										HoursesOnTable(ik).HourseThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									HoursesOnTable(ik).HourseThinking(0).Dept(HoursesOnTable(ik).HourseThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Bridge.
							Dim ik As Integer = AllDraw.BridgeMidle
							While ik < AllDraw.BridgeHigh
								Try
									If BridgesOnTable(ik).BridgeThinking(0).ReturnHuristic(i, j) < PreviousLess Then

										BridgesOnTable(ik).BridgeThinking(0).Dept = Nothing
										BridgesOnTable(ik) = Nothing
										Continue Try
									Else

										PreviousLess = BridgesOnTable(ik).BridgeThinking(0).ReturnHuristic(i, j)
									End If
									If BridgesOnTable(ik).BridgeThinking(0).Dept.Count = 0 Then
										BridgesOnTable(ik).BridgeThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									BridgesOnTable(ik).BridgeThinking(0).Dept(BridgesOnTable(ik).BridgeThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Minister.
							Dim ik As Integer = AllDraw.MinisterMidle
							While ik < AllDraw.MinisterHigh
								Try
									If True Then
										If MinisterOnTable(ik).MinisterThinking(0).ReturnHuristic(i, j) < PreviousLess Then
											MinisterOnTable(ik).MinisterThinking(0).Dept = Nothing
											MinisterOnTable(ik) = Nothing

											Continue Try
										Else
											PreviousLess = MinisterOnTable(ik).MinisterThinking(0).ReturnHuristic(i, j)
										End If
									End If
									If MinisterOnTable(ik).MinisterThinking(0).Dept.Count = 0 Then
										MinisterOnTable(ik).MinisterThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									MinisterOnTable(ik).MinisterThinking(0).Dept(MinisterOnTable(ik).MinisterThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'King.
							Dim ik As Integer = AllDraw.KingMidle
							While ik < AllDraw.KingHigh
								Try
									If True Then
										If KingOnTable(ik).KingThinking(0).ReturnHuristic(i, j) < PreviousLess Then
											KingOnTable(ik).KingThinking(0).Dept = Nothing
											KingOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = KingOnTable(ik).KingThinking(0).ReturnHuristic(i, j)
										End If
									End If
									If KingOnTable(ik).KingThinking(0).Dept.Count = 0 Then
										KingOnTable(ik).KingThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									KingOnTable(ik).KingThinking(0).Dept(KingOnTable(ik).KingThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
						Else
							'For Brown Order Blitz Game Calculate Maximum Huristic Inclusive Dept First Game Search.
							Dim ik As Integer = 0
							While ik < AllDraw.SodierMidle
								Try
									If True Then
										'Soldier.
										If SolderesOnTable(ik).SoldierThinking(0).ReturnHuristic(-1, -1) < PreviousLess Then
											SolderesOnTable(ik).SoldierThinking(0).Dept = Nothing
											SolderesOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = SolderesOnTable(ik).SoldierThinking(0).ReturnHuristic(-1, -1)
										End If

									End If
									If SolderesOnTable(ik).SoldierThinking(0).Dept.Count = 0 Then
										SolderesOnTable(ik).SoldierThinking(0).Dept.Add(New AllDraw(THIS))
									End If

									SolderesOnTable(ik).SoldierThinking(0).Dept(SolderesOnTable(ik).SoldierThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Elephant
							Dim ik As Integer = 0
							While ik < AllDraw.ElefantMidle
								Try
									If True Then
										If ElephantOnTable(ik).ElefantThinking(0).ReturnHuristic(-1, -1) < PreviousLess Then
											ElephantOnTable(ik).ElefantThinking(0).Dept = Nothing
											ElephantOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = ElephantOnTable(ik).ElefantThinking(0).ReturnHuristic(-1, -1)
										End If
									End If
									If ElephantOnTable(ik).ElefantThinking(0).Dept.Count = 0 Then
										ElephantOnTable(ik).ElefantThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									ElephantOnTable(ik).ElefantThinking(0).Dept(ElephantOnTable(ik).ElefantThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Hourse.
							Dim ik As Integer = 0
							While ik < AllDraw.HourseMidle
								Try
									If True Then
										If HoursesOnTable(ik).HourseThinking(0).ReturnHuristic(-1, -1) < PreviousLess Then
											HoursesOnTable(ik).HourseThinking(0).Dept = Nothing
											HoursesOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = HoursesOnTable(ik).HourseThinking(0).ReturnHuristic(-1, -1)
										End If
									End If
									If HoursesOnTable(ik).HourseThinking(0).Dept.Count = 0 Then
										HoursesOnTable(ik).HourseThinking(0).Dept.Add(New AllDraw(THIS))
									End If

									HoursesOnTable(ik).HourseThinking(0).Dept(HoursesOnTable(ik).HourseThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Bridges.
							Dim ik As Integer = 0
							While ik < AllDraw.BridgeMidle
								Try
									If BridgesOnTable(ik).BridgeThinking(0).ReturnHuristic(-1, -1) < PreviousLess Then

										BridgesOnTable(ik).BridgeThinking(0).Dept = Nothing
										BridgesOnTable(ik) = Nothing
										Continue Try
									Else

										PreviousLess = BridgesOnTable(ik).BridgeThinking(0).ReturnHuristic(-1, -1)
									End If
									If BridgesOnTable(ik).BridgeThinking(0).Dept.Count = 0 Then
										BridgesOnTable(ik).BridgeThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									BridgesOnTable(ik).BridgeThinking(0).Dept(BridgesOnTable(ik).BridgeThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'Minister.
							Dim ik As Integer = 0
							While ik < AllDraw.MinisterMidle
								Try
									If True Then
										If MinisterOnTable(ik).MinisterThinking(0).ReturnHuristic(-1, -1) < PreviousLess Then
											MinisterOnTable(ik).MinisterThinking(0).Dept = Nothing
											MinisterOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = MinisterOnTable(ik).MinisterThinking(0).ReturnHuristic(-1, -1)
										End If
									End If
									If MinisterOnTable(ik).MinisterThinking(0).Dept.Count = 0 Then
										MinisterOnTable(ik).MinisterThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									MinisterOnTable(ik).MinisterThinking(0).Dept(MinisterOnTable(ik).MinisterThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1
							End While
							'King.
							Dim ik As Integer = 0
							While ik < AllDraw.KingMidle
								Try
									If True Then
										If KingOnTable(ik).KingThinking(0).ReturnHuristic(-1, -1) < PreviousLess Then
											KingOnTable(ik).KingThinking(0).Dept = Nothing
											KingOnTable(ik) = Nothing
											Continue Try
										Else
											PreviousLess = KingOnTable(ik).KingThinking(0).ReturnHuristic(-1, -1)
										End If
									End If
									If KingOnTable(ik).KingThinking(0).Dept.Count = 0 Then
										KingOnTable(ik).KingThinking(0).Dept.Add(New AllDraw(THIS))
									End If
									KingOnTable(ik).KingThinking(0).Dept(KingOnTable(ik).KingThinking(0).Dept.Count - 1).InitiateDeptFirst(iDept, ii, jj, a, TableHuristic, Order, _
										False, timer, TimerColor, Less)
								Catch t As Exception
									Log(t)
								End Try
								ik += 1


							End While

						End If
					End If






					'Initiate of Local and Global Vriables.
					Order = DummyOrder
					ChessRules.CurrentOrder = DummyCurrentOrder

					'Gray Order.
					If Order = 1 Then
						THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " By Bob Finished!")
						THIS.RefreshBoxText()
					Else
						THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + iDept.ToString() + " By Alice Finished")
						THIS.RefreshBoxText()
					End If

					DeptIndexVlue = Dept
					Dept += 1
					Order = DummyOrder
					ChessRules.CurrentOrder = DummyCurrentOrder
				End If
			End If
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder

			Return Me
			'.CopyRemeiningItems(Dummy, Order);
			'return 
		End Function
		'best movement indexes founder method.
		Function FoundOfBestMovments(Dept As Integer, ByRef i As List(Of Integer), ByRef j As List(Of Integer), ByRef k As List(Of Integer), Dummy As AllDraw, a As Color, _
			Order As Integer) As List(Of List(Of Integer))
			'initiate local variables.
			Dim p As New List(Of List(Of Integer))()

			Dim ii As Integer = 0
			While ii < 6
				Dim pl As New List(Of Integer)()
				p.Add(pl)
				ii += 1
			End While
			Dim Less As Double = -999999999999999999L
			Dim DummyList As List(Of AllDraw) = New List(Of Refrigtz.AllDraw)()
			DummyList.Add(Dummy)
			MaxHuristicDeptFirstBackWard.Clear()
			'found best movment depend of max huristic.
			Dummy.HuristicDeptSearch(0, DummyList, a, Less, Order, False)
			'proccess from a stored global variable decicion making.
			If MaxHuristicDeptFirstBackWard(0)(1) <> -1 Then
				'soldier.
				i.Add(MaxHuristicDeptFirstBackWard(0)(2))
				j.Add(MaxHuristicDeptFirstBackWard(0)(3))
				k.Add(MaxHuristicDeptFirstBackWard(0)(4))
				p(0).Add(MaxHuristicDeptFirstBackWard(0)(2))
			ElseIf MaxHuristicDeptFirstBackWard(0)(5) <> -1 Then
				'Elephant
				i.Add(MaxHuristicDeptFirstBackWard(0)(6))
				j.Add(MaxHuristicDeptFirstBackWard(0)(7))
				k.Add(MaxHuristicDeptFirstBackWard(0)(8))
				p(1).Add(MaxHuristicDeptFirstBackWard(0)(6))
			ElseIf MaxHuristicDeptFirstBackWard(0)(9) <> -1 Then
				'Hourse
				i.Add(MaxHuristicDeptFirstBackWard(0)(10))
				j.Add(MaxHuristicDeptFirstBackWard(0)(11))
				k.Add(MaxHuristicDeptFirstBackWard(0)(12))
				p(2).Add(MaxHuristicDeptFirstBackWard(0)(10))
			ElseIf MaxHuristicDeptFirstBackWard(0)(13) <> -1 Then
				'Bridges.
				i.Add(MaxHuristicDeptFirstBackWard(0)(14))
				j.Add(MaxHuristicDeptFirstBackWard(0)(15))
				k.Add(MaxHuristicDeptFirstBackWard(0)(16))
				p(3).Add(MaxHuristicDeptFirstBackWard(0)(14))
			ElseIf MaxHuristicDeptFirstBackWard(0)(17) <> -1 Then
				'Minister
				i.Add(MaxHuristicDeptFirstBackWard(0)(18))
				j.Add(MaxHuristicDeptFirstBackWard(0)(19))
				k.Add(MaxHuristicDeptFirstBackWard(0)(20))
				p(4).Add(MaxHuristicDeptFirstBackWard(0)(18))
			ElseIf MaxHuristicDeptFirstBackWard(0)(21) <> -1 Then
				'King.
				i.Add(MaxHuristicDeptFirstBackWard(0)(22))
				j.Add(MaxHuristicDeptFirstBackWard(0)(23))
				k.Add(MaxHuristicDeptFirstBackWard(0)(24))
				p(5).Add(MaxHuristicDeptFirstBackWard(0)(22))
			End If
			'not found
			Return p
		End Function
		'Non Used Current Table Found Huristic Method.
		Public Function HuristicCurrentTable(ADra As AllDraw, a As Color, Order As Integer) As Integer(,)
			'Initiate of Local and Global Varaibles.
			AllDraw.SyntaxToWrite = ""
			Dim Tab As Integer(,) = New Integer(8, 8) {}
			Dim Ad As New List(Of AllDraw)()
			Ad.Add(ADra)
			Dim Less As Double = -20000000

			'Found of Current Table Huristics.
			Tab = Me.HuristicDeptSearch(0, Ad, a, Less, Order, True)
			THIS.SetBoxText(vbCr & vbLf & "Current Table Syntax:" + AllDraw.SyntaxToWrite)
			THIS.RefreshBoxText()
			Return Tab

		End Function
		'Copying of Items of Enemy Non Move and Current Moved.
		Public Function CopyRemeiningItems(ADummy As AllDraw, Order As Integer) As AllDraw
			'Initiate Local Variables.
			Dim Dummy As New AllDraw(THIS)
			Dummy.SolderesOnTable = New DrawSoldier(AllDraw.SodierHigh) {}
			Dummy.ElephantOnTable = New DrawElefant(AllDraw.ElefantHigh) {}
			Dummy.HoursesOnTable = New DrawHourse(AllDraw.HourseHight) {}
			Dummy.BridgesOnTable = New DrawBridge(AllDraw.BridgeHigh) {}
			Dummy.MinisterOnTable = New DrawMinister(AllDraw.MinisterHigh) {}
			Dummy.KingOnTable = New DrawKing(AllDraw.KingHigh) {}
			'For All Sodiers Movments.
			Dim i As Integer = 0
			While i < AllDraw.SodierHigh
				Try
					'Construction of Current Solders. 
					Dummy.SolderesOnTable(i) = New DrawSoldier(SolderesOnTable(i).Row, SolderesOnTable(i).Column, SolderesOnTable(i).color, SolderesOnTable(i).Table, SolderesOnTable(i).Order, False, _
						SolderesOnTable(i).Current)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			'For All Elephant Objects.
			Dim i As Integer = 0
			While i < AllDraw.ElefantHigh
				Try
					'Construction of Curren Elephant.
					Dummy.ElephantOnTable(i) = New DrawElefant(ElephantOnTable(i).Row, ElephantOnTable(i).Column, ElephantOnTable(i).color, ElephantOnTable(i).Table, ElephantOnTable(i).Order, False, _
						ElephantOnTable(i).Current)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			'for All Hourse Objects.
			Dim i As Integer = 0
			While i < AllDraw.HourseHight
				Try
					'Construction of Hourse Objects.
					Dummy.HoursesOnTable(i) = New DrawHourse(HoursesOnTable(i).Row, HoursesOnTable(i).Column, HoursesOnTable(i).color, HoursesOnTable(i).Table, HoursesOnTable(i).Order, False, _
						HoursesOnTable(i).Current)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			'For All Bridges Objects.
			Dim i As Integer = 0
			While i < AllDraw.BridgeHigh
				Try
					'Construction of Bridges Objects.
					Dummy.BridgesOnTable(i) = New DrawBridge(BridgesOnTable(i).Row, BridgesOnTable(i).Column, BridgesOnTable(i).color, BridgesOnTable(i).Table, BridgesOnTable(i).Order, False, _
						BridgesOnTable(i).Current)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			'For All Minister Objects.
			Dim i As Integer = 0
			While i < AllDraw.MinisterHigh
				Try
					'Construction of Current Minister.
					Dummy.MinisterOnTable(i) = New DrawMinister(MinisterOnTable(i).Row, MinisterOnTable(i).Column, MinisterOnTable(i).color, MinisterOnTable(i).Table, MinisterOnTable(i).Order, False, _
						MinisterOnTable(i).Current)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			'For All King Objects.
			Dim i As Integer = 0
			While i < AllDraw.KingHigh
				Try
					'Construction of Kings Objects.
					Dummy.KingOnTable(i) = New DrawKing(KingOnTable(i).Row, KingOnTable(i).Column, KingOnTable(i).color, KingOnTable(i).Table, KingOnTable(i).Order, False, _
						KingOnTable(i).Current)
				Catch t As Exception
					Log(t)
				End Try
				i += 1
			End While
			'Gray Order.
			If Order = 1 Then
				'For Gray Soders Objects.
				Dim i As Integer = 0
				While i < AllDraw.SodierMidle
					Try
						'Clone a Movments.
						ADummy.SolderesOnTable(i).Clone(Dummy.SolderesOnTable(i), THIS)
					Catch t As Exception
						Dummy.SolderesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For Gray Elephant.
				Dim i As Integer = 0
				While i < AllDraw.ElefantMidle
					Try
						'Clone a  Movments.
						ADummy.ElephantOnTable(i).Clone(Dummy.ElephantOnTable(i), THIS)
					Catch t As Exception
						Dummy.ElephantOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For Gray Hourses.
				Dim i As Integer = 0
				While i < AllDraw.HourseMidle
					Try
						'Clone a Movments.
						ADummy.HoursesOnTable(i).Clone(Dummy.HoursesOnTable(i), THIS)
					Catch t As Exception
						Dummy.HoursesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For Gray Bridges.
				Dim i As Integer = 0
				While i < AllDraw.BridgeMidle
					Try
						'Clone a Movments.
						ADummy.BridgesOnTable(i).Clone(Dummy.BridgesOnTable(i), THIS)
					Catch t As Exception
						Dummy.BridgesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For Gray Ministers.
				Dim i As Integer = 0
				While i < AllDraw.MinisterMidle
					Try
						'Clone a Movments.
						ADummy.MinisterOnTable(i).Clone(Dummy.MinisterOnTable(i), THIS)
					Catch t As Exception
						Dummy.MinisterOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For Gray King.
				Dim i As Integer = 0
				While i < AllDraw.KingMidle
					Try
						'Clone a Movments.
						ADummy.KingOnTable(i).Clone(Dummy.KingOnTable(i), THIS)
					Catch t As Exception
						Dummy.KingOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
					'For All Solders.
				End While
			Else
				'For Order Brown.
				If True Then
					'For Brown Solders.
					Dim i As Integer = AllDraw.SodierMidle
					While i < AllDraw.SodierHigh
						Try
							'Clone a Movments.
							ADummy.SolderesOnTable(i).Clone(Dummy.SolderesOnTable(i), THIS)
						Catch t As Exception
							Dummy.SolderesOnTable(i) = Nothing
							Log(t)
						End Try
						i += 1
					End While
					'For All Brown Elephants.
					Dim i As Integer = AllDraw.ElefantMidle
					While i < AllDraw.ElefantHigh
						Try
							'Clone a Enemy.
							ADummy.ElephantOnTable(i).Clone(Dummy.ElephantOnTable(i), THIS)
						Catch t As Exception
							Dummy.ElephantOnTable(i) = Nothing
							Log(t)
						End Try
						i += 1
					End While
					'For All Brown Hourses.
					Dim i As Integer = AllDraw.HourseMidle
					While i < AllDraw.HourseHight
						Try
							'Clone a Enemy.
							ADummy.HoursesOnTable(i).Clone(Dummy.HoursesOnTable(i), THIS)
						Catch t As Exception
							Dummy.HoursesOnTable(i) = Nothing
							Log(t)
						End Try
						i += 1
					End While
					'For Brown Bridges. 
					Dim i As Integer = AllDraw.BridgeMidle
					While i < AllDraw.BridgeHigh
						Try
							'Clone a Movments.
							ADummy.BridgesOnTable(i).Clone(Dummy.BridgesOnTable(i), THIS)
						Catch t As Exception
							Dummy.BridgesOnTable(i) = Nothing
							Log(t)
						End Try
						i += 1
					End While
					'For Gray Minsters.
					Dim i As Integer = AllDraw.MinisterMidle
					While i < AllDraw.MinisterHigh
						Try
							'Clone a Enemy.
							ADummy.MinisterOnTable(i).Clone(Dummy.MinisterOnTable(i), THIS)
						Catch t As Exception
							Dummy.MinisterOnTable(i) = Nothing
							Log(t)
						End Try
						i += 1
					End While
					'For Brown Kings.
					Dim i As Integer = AllDraw.KingMidle
					While i < AllDraw.KingHigh
						Try
							'Clone a Enemy.
							ADummy.KingOnTable(i).Clone(Dummy.KingOnTable(i), THIS)
						Catch t As Exception
							Dummy.KingOnTable(i) = Nothing
							Log(t)
						End Try
						i += 1
					End While

				End If
			End If

			'Return Constructed Tables.
			Return Dummy


		End Function
		'Reconstruction of AllDraw Object.
		Public Sub RecoonstructADraw(ByRef ADrawAll As List(Of AllDraw))
			'Recurve Conditions.
			If ADraw.Count = 0 Then
				Return
			End If
			'Adding Operations.
			ADrawAll.Add(Me.ADraw(0))
			'Recursive Main Method.
			ADraw(0).RecoonstructADraw(ADrawAll)
		End Sub
		'Main Initiate Thinking Method.
		Public Sub Initiate(ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, TB As Boolean, _
			ByRef timer As Timer, ByRef TimerColor As Timer)
			File.AppendAllText(FormRefrigtz.Root + "\Database\Monitor.txt", vbLf & vbTab & "=====================================================================================================================================================================")
			File.AppendAllText(FormRefrigtz.Root + "\Database\Monitor.txt", vbLf & vbTab & "Movment Number:" + FormRefrigtz.MovmentsNumber)
			ThinkingChess.Sign = 1
			CurrentHuristic = -999999999999999999L
			SetprogressBarRefregitzValue(THIS.progressBarVerify, 0)
			THIS.progressBarVerify.Invalidate()
			SetprogressBarUpdate(THIS.progressBarVerify)
			'Initiate Local and Global Variables.
			ThinkingChess.MaxHuristicx = -20000000000000000L
			DrawBridge.MaxHuristicxB = -20000000000000000L
			DrawElefant.MaxHuristicxE = -20000000000000000L
			DrawHourse.MaxHuristicxH = -20000000000000000L
			DrawKing.MaxHuristicxK = -20000000000000000L
			DrawMinister.MaxHuristicxM = -20000000000000000L
			DrawSoldier.MaxHuristicxS = -20000000000000000L
			ThinkingChess.MovementsDeptHuristicFound = False
			DrawTable = False
			Dim THISDummy As FormRefrigtz
			ChessRules.KishBrownAchmazFirstTimesOcured = False
			ChessRules.KishGrayAchmazFirstTimesOcured = False
			Dim Current As Integer = ChessRules.CurrentOrder
			Dim DummyOrder As Integer = Order

			'If There is Not Dept Huristic Boolean Chacked.
			If Not AllDraw.DeptFirstSearch Then
				AllDraw.StoreADraw.Clear()
				Dim Tab As Integer(,) = Nothing
				Dim TablInit As Integer(,) = Nothing

				ADraw.Clear()
				TableList.Clear()
				TableList.Add(Table)
				SetRowColumn(0)
				TableList.Clear()
				ThinkingChess.NotSolvedKingDanger = False
				LoopHuristicIndex = 0
				'For All Pssible One.
				Dim i As Integer = 0
				While i < 1
					'If Gray Order.
					If Order = 1 Then
						THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + i.ToString() + " By Bob!")
						THIS.RefreshBoxText()
					Else
						THIS.SetBoxText(vbCr & vbLf & "Chess Thinking Dept " + i.ToString() + " By Alice!")
						THIS.RefreshBoxText()
					End If
					'Initaite Local Variables.
					TablInit = New Integer(8, 8) {}
					If Order = 1 Then
						a = Color.Gray
					Else
						a = Color.Brown
					End If
					Dim [In] As Integer = 0
					'Determine a Random Solders Objects.
					Do
						'When Order is Gray Random is on Gray.
						If Order = 1 Then
							[In] = (New System.Random()).[Next](0, 8)
						Else
							[In] = (New System.Random()).[Next](8, 16)
						End If
					Loop While SolderesOnTable([In]) Is Nothing
					'Initiate a DFept On Movments.
					Me.InitiateForEveryKindThingHome(New AllDraw(THIS), CType(SolderesOnTable([In]).Row, Integer), CType(SolderesOnTable([In]).Column, Integer), a, Table, Order, _
						False, [In])
					'Initaite a Local Varibales of Huristics.
					Dim Less As Double = -999999999999999999L
					'For Greater Than Zero ADraw Count Varibale. 
					If ADraw.Count > 0 Then
						'If Gray Order.
						If Order = 1 Then
							THIS.SetBoxText(vbCr & vbLf & "Huristic Find Best Movements Dept " + i.ToString() + " By Bob!")
							THIS.RefreshBoxText()
						Else
							THIS.SetBoxText(vbCr & vbLf & "Huristic Find Best Movements Dept " + i.ToString() + " By Alice!")

							THIS.RefreshBoxText()
						End If
						Order = FormRefrigtz.OrderPlate
						ChessRules.CurrentOrder = FormRefrigtz.OrderPlate
						Tab = Me.ADraw(0).Huristic(ADraw, a, i, CurrentHuristic, Order)
					End If
					'If Repetedly Movments Occurred.
					If ThinkingChess.ExistTableInList(Tab, TableListAction, 0) Then
						'If Gray Order.
						If Order = 1 Then
							THIS.SetBoxText(vbCr & vbLf & "Genetic Algorithm Begin Dept " + i.ToString() + " By Bob!")
							THIS.RefreshBoxText()
						Else
							THIS.SetBoxText(vbCr & vbLf & "Genetic Algirithm Begin Dept " + i.ToString() + " By Alice!")

							THIS.RefreshBoxText()
						End If
						'Genetic Algorithm.
						Dim R As ChessGeneticAlgorithm = (New ChessGeneticAlgorithm())
						'Found of Table.
						Tab = R.GenerateTable(TableListAction, LoopHuristicIndex, Order)
						'Gray Order.
						If Order = 1 Then
							THIS.SetBoxText(vbCr & vbLf & "Genetic Algorithm Finsished Dept " + i.ToString() + " By Bob!")
							THIS.RefreshBoxText()
						Else
							THIS.SetBoxText(vbCr & vbLf & "Genetic Algirithm Finished Dept " + i.ToString() + " By Alice!")

							THIS.RefreshBoxText()
						End If
					End If
					'If Table Found.
					If Tab IsNot Nothing Then
						'Clone  A Copy.
						Dim iii As Integer = 0
						While iii < 8
							Dim jjj As Integer = 0
							While jjj < 8
								TablInit(iii, jjj) = Tab(iii, jjj)
								jjj += 1
							End While
							iii += 1
						End While
						'Initiate Local Varibales.
						TableList.Add(TablInit)
						ClList.Add(CL)
						RWList.Add(RW)
						KiList.Add(Ki)

						Dept += 1
					End If
					i += 1
				End While

				'Initaite Global Order Varibales By Local Varibales.
				Order = DummyOrder
				ChessRules.CurrentOrder = Current
				DrawTable = True

				Return
			Else
				'Initiate Local Varibales.
				TableHuristic = New Integer(8, 8) {}
				RW1 = -1
				CL1 = -1
				Ki1 = -1
				RW2 = -1
				CL2 = -1
				Ki2 = -1
				RW3 = -1
				CL3 = -1
				Ki3 = -1
				RW4 = -1
				CL4 = -1
				Ki4 = -1
				RW5 = -1
				CL5 = -1
				Ki5 = -1
				RW6 = -1
				CL6 = -1
				Ki6 = -1
				MaxHuristicDeptFirstBackWard.Clear()
				TableList.Clear()
				Dim Tab As Integer(,) = Nothing
				Dim TablInit As Integer(,) = Nothing

				AllDraw.DeptiLevelMax = 2
				THISDummy = New FormRefrigtz(True)
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						THISDummy.Table(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While
				THISDummy.accessDraw.TableList.Add(THISDummy.Table)
				THISDummy.accessDraw.SetRowColumn(0)
				Me.Clone(THISDummy.accessDraw)
				THISDummy.Dispose()


				THISDummy.accessDraw.THIS = Me.THIS
				DeptIndexVlue = 0
				ThinkingChess.NotSolvedKingDanger = False
				LoopHuristicIndex = 0
				If CurrentTable Is Nothing Then
					CurrentTable = New Integer(8, 8) {}
				End If
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						CurrentTable(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While
				Dim Less As Double = -999999999999999999L


				Dim Dummy As New AllDraw(THIS)
				THISDummy.accessDraw.ADraw.Clear()
				THISDummy.accessDraw.ADraw.Add(Dummy)
				' Simulate work.

					'for (int i = 0; i < MaxDept; i++)
				THIS.Invoke(CType(, MethodInvoker))
				'Iniatite Dehidspt Movments Of Possible.
				Dim DummtTHIS As AllDraw = New Refrigtz.AllDraw(THIS)
				THISDummy.accessDraw = THISDummy.accessDraw.InitiateDeptFirst(0, ii, jj, a, CurrentTable, Order, _
					False, timer, TimerColor, Less)
				SetprogressBarRefregitzValue(THIS.progressBarVerify, 999999999)
				THIS.progressBarVerify.Invalidate()
				SetprogressBarUpdate(THIS.progressBarVerify)

				'Initaite Local Varibales.
				Tab = New Integer(8, 8) {}

				MaxHuristicDeptFirstBackWard.Clear()
				Order = FormRefrigtz.OrderPlate
				ChessRules.CurrentOrder = FormRefrigtz.OrderPlate
				'Dept Huristic Consideration.
				THISDummy.accessDraw.HuristicDeptSearch(0, THISDummy.accessDraw.ADraw, a, CurrentHuristic, Order, False)
				' THISDummy.accessDraw.ADraw[0].HuristicDeptSearch(0, THISDummy.accessDraw.ADraw, a, ref Less, Order, false);
				If TimerColor.Times > 60 * 1000 Then
					MaxDept += 1
				Else
					MaxDept -= 1
				End If
				Try
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							Tab(i, j) = TableHuristic(i, j)
							j += 1
						End While
						i += 1
					End While
				Catch t As Exception
					Log(t)
				End Try
				TableList.Clear()
				'If Table Found.

				If Tab IsNot Nothing Then
					'Initiate Local Varibales.
					'THISDummy.Dispose();
					TableList.Add(Tab)
					If THISDummy.accessDraw.ADraw.Count > 0 Then
						If Order = 1 Then
							THIS.SetBoxText(vbCr & vbLf & "Huristic Find Best Movements Dept " + Dept.ToString() + " By Bob!")
							THIS.RefreshBoxText()
						Else
							THIS.SetBoxText(vbCr & vbLf & "Huristic Find Best Movements Dept " + Dept.ToString() + " By Alice!")

							THIS.RefreshBoxText()
						End If
						TablInit = New Integer(8, 8) {}
						Less = -999999999999999999L



						Order = DummyOrder
						ChessRules.CurrentOrder = Current
						'If There is Reapetedly Movments Number.
						If ThinkingChess.ExistTableInList(Tab, TableListAction, 0) Then
							'Order Gray.
							If Order = 1 Then
								THIS.SetBoxText(vbCr & vbLf & "Genetic Algorithm Begin Dept 0 By Bob!")
								THIS.RefreshBoxText()
							Else
								THIS.SetBoxText(vbCr & vbLf & "Genetic Algirithm Begin Dept 0 By Alice!")

								THIS.RefreshBoxText()
							End If
							'Genetic Algorithms.
							Dim R As ChessGeneticAlgorithm = (New ChessGeneticAlgorithm())
							'Found Of Tables.
							Tab = R.GenerateTable(TableListAction, LoopHuristicIndex, Order)
							'Adding Table To Movments Tables List.
							If Tab IsNot Nothing Then
								AllDraw.TableCurrent.Add(Tab)
							End If
							'Order Gray.
							If Order = 1 Then
								THIS.SetBoxText(vbCr & vbLf & "Genetic Algorithm Finsished Dept 0 By Bob!")
								THIS.RefreshBoxText()
							Else
								THIS.SetBoxText(vbCr & vbLf & "Genetic Algirithm Finished Dept 0 By Alice!")

								THIS.RefreshBoxText()
							End If
						End If
						'When Table Found.
						If Tab IsNot Nothing Then
							'Clone a Table Copy.
							Dim iii As Integer = 0
							While iii < 8
								Dim jjj As Integer = 0
								While jjj < 8
									TablInit(iii, jjj) = Tab(iii, jjj)
									jjj += 1
								End While
								iii += 1
							End While
							'Clear Lists.
							TableList.Clear()
							TableList.Add(TablInit)
							Dept += 1

							'Global Order By Local One.
							Order = DummyOrder
							ChessRules.CurrentOrder = Current
							Try
								'Iniatite of Global Varibales.
								ChessRules.CurrentOrder = Current
								'Genetic for Syntax of Table Found.
								Dim RR As New ChessGeneticAlgorithm()
								'Consideration of Autorithy.
								If RR.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), Tab, AllDraw.TableListAction, 0, Order, True) Then
									'Found of Syntax.
									Dim HitVal As Boolean = False
									Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(RR.CromosomRow, RR.CromosomColumn)
									If Hit <> 0 Then
										HitVal = True
									End If
									Dim Convert As Boolean = False
									If Order = 1 Then
										If Tab(RR.CromosomRow, RR.CromosomColumn) = 1 Then
											If RR.CromosomColumn = 7 Then
												Convert = True
											End If
										End If
										AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(RR.CromosomRowFirst, RR.CromosomColumnFirst), RR.CromosomColumn, RR.CromosomRow, HitVal, _
											Hit, ChessRules.BridgeActGray, Convert)
									Else
										If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(RR.CromosomRowFirst, RR.CromosomColumnFirst) = -1 Then
											If RR.CromosomColumn = 0 Then
												Convert = True
											End If
										End If
										AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(RR.CromosomRowFirst, RR.CromosomColumnFirst), RR.CromosomColumn, RR.CromosomRow, HitVal, _
											Hit, ChessRules.BridgeActBrown, Convert)
									End If
								End If
							Catch t As IndexOutOfRangeException
								Log(t)
							End Try
						Else
							'Clear Dept Varibales.
							AllDraw.StoreADraw.Clear()
							LevelDeptFirsDynamic = 1
							TableCurrent.Clear()
							Dept = 0
						End If
					End If
				Else
					'Clear Dept Varibales.
					AllDraw.StoreADraw.Clear()
					LevelDeptFirsDynamic = 1
					TableCurrent.Clear()
					Dept = 0
				End If
				Order = DummyOrder
				ChessRules.CurrentOrder = Current
				'THISDummy.Dispose();
				DrawTable = True
				Return
			End If

		End Sub
		'Identification of Illegal Dept First and Common Hurist Movments.
		Public Function isEnemyThingsinStable(TableHuristic As Integer(,), TableAction As Integer(,), Order As Integer) As Boolean
			'Iniatiet Local Variables.
			Dim Cromosom1 As Integer(,) = TableHuristic
			Dim Cromosom2 As Integer(,) = TableAction
			Dim [and] As Boolean = True

			Dim Find As Boolean = False
			'bool Hit = false;
			Dim FindNumber As Integer = 0
			'CromosomRowFirst = -1, CromosomColumnFirst = -1, 
			Dim CromosomRow As Integer = -1, CromosomColumn As Integer = -1
			'Initiate Local Variables.

			'For All Table Home
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					'Gray Order.
					If Order = 1 Then
						'Situation 11.
						If [and] Then
							'All The Brown Object Ignored.
							If Cromosom1(i, j) < 0 AndAlso Cromosom2(i, j) < 0 Then
								Continue While
							End If
						Else
							'''Situation 2.
							'All The Brown Ojects Ignored.
							If Cromosom1(i, j) < 0 OrElse Cromosom2(i, j) < 0 Then
								Continue While
							End If
						End If
					Else
						'Brown Order.
						'Situation 1.
						If [and] Then
							'All The Gray Objects Ignored.
							If Cromosom1(i, j) > 0 AndAlso Cromosom2(i, j) > 0 Then
								Continue While

							End If
						Else
							'All The Gray Objects Ignored.
							If Cromosom1(i, j) > 0 OrElse Cromosom2(i, j) > 0 Then
								Continue While
							End If
						End If
					End If
					If True Then
						If True Then
							If Order = 1 AndAlso j = 6 AndAlso i > 0 AndAlso i < 7 Then
								If ((Cromosom2(i, j + 1) > 0) OrElse (Cromosom2(i + 1, j + 1) > 0 AndAlso Cromosom1(i + 1, j + 1) < 0) OrElse (Cromosom2(i - 1, j + 1) > 0 AndAlso Cromosom1(i - 1, j + 1) < 0) AndAlso Cromosom1(i, j) = 1) Then
									Find = True
									FindNumber += 1

									AllDraw.SodierConversionOcuured = True

								End If
							ElseIf Order = -1 AndAlso j = 1 AndAlso i > 0 AndAlso i < 7 Then
								If ((Cromosom2(i, j - 1) < 0) OrElse (Cromosom2(i + 1, j - 1) < 0 AndAlso Cromosom1(i + 1, j - 1) > 0) OrElse (Cromosom2(i - 1, j - 1) < 0 AndAlso Cromosom1(i - 1, j - 1) < 0) AndAlso Cromosom1(i, j) = -1) Then
									Find = True
									FindNumber += 1
									AllDraw.SodierConversionOcuured = True
								End If
							End If
							If Order = 1 AndAlso j = 6 AndAlso i > 1 AndAlso i < 7 Then
								If ((Cromosom2(i, j + 1) > 0) OrElse (Cromosom2(i + 1, j + 1) > 0 AndAlso Cromosom1(i + 1, j + 1) < 0) OrElse (Cromosom2(i - 1, j + 1) > 0 AndAlso Cromosom1(i - 1, j + 1) < 0) AndAlso Cromosom1(i, j) = 1) Then
									Find = True
									FindNumber += 1

									AllDraw.SodierConversionOcuured = True

								End If
							ElseIf Order = -1 AndAlso j = 1 AndAlso i > 1 AndAlso i < 7 Then
								If ((Cromosom2(i, j - 1) < 0) OrElse (Cromosom2(i + 1, j - 1) < 0 AndAlso Cromosom1(i + 1, j - 1) > 0) OrElse (Cromosom2(i - 1, j - 1) < 0 AndAlso Cromosom1(i - 1, j - 1) < 0) AndAlso Cromosom1(i, j) = -1) Then
									Find = True
									FindNumber += 1
									AllDraw.SodierConversionOcuured = True
								End If
							End If
							If Order = 1 AndAlso j = 6 AndAlso i > 1 AndAlso i < 7 Then
								If ((Cromosom2(i, j + 1) > 0) OrElse (Cromosom2(i + 1, j + 1) > 0 AndAlso Cromosom1(i + 1, j + 1) < 0) OrElse (Cromosom2(i - 1, j + 1) > 0 AndAlso Cromosom1(i - 1, j + 1) < 0) AndAlso Cromosom1(i, j) = 1) Then
									Find = True
									FindNumber += 1

									AllDraw.SodierConversionOcuured = True

								End If
							ElseIf Order = -1 AndAlso j = 1 AndAlso i > 1 AndAlso i < 7 Then
								If ((Cromosom2(i, j - 1) < 0) OrElse (Cromosom2(i + 1, j - 1) < 0 AndAlso Cromosom1(i + 1, j - 1) > 0) OrElse (Cromosom2(i - 1, j - 1) < 0 AndAlso Cromosom1(i - 1, j - 1) < 0) AndAlso Cromosom1(i, j) = -1) Then
									Find = True
									FindNumber += 1
									AllDraw.SodierConversionOcuured = True
								End If
							End If
							If Order = 1 AndAlso j = 6 AndAlso i > 1 AndAlso i < 7 Then
								If ((Cromosom2(i, j + 1) > 0) OrElse (Cromosom2(i + 1, j + 1) > 0 AndAlso Cromosom1(i + 1, j + 1) < 0) OrElse (Cromosom2(i - 1, j + 1) > 0 AndAlso Cromosom1(i - 1, j + 1) < 0) AndAlso Cromosom1(i, j) = 1) Then
									Find = True
									FindNumber += 1

									AllDraw.SodierConversionOcuured = True

								End If
							ElseIf Order = -1 AndAlso j = 1 AndAlso i > 1 AndAlso i < 7 Then
								If ((Cromosom2(i, j - 1) < 0) OrElse (Cromosom2(i + 1, j - 1) < 0 AndAlso Cromosom1(i + 1, j - 1) > 0) OrElse (Cromosom2(i - 1, j - 1) < 0 AndAlso Cromosom1(i - 1, j - 1) < 0) AndAlso Cromosom1(i, j) = -1) Then
									Find = True
									FindNumber += 1
									AllDraw.SodierConversionOcuured = True
								End If
							End If

							'Bridges King Validity Condition.
							If Order = 1 AndAlso j = 0 Then
								'Small Gray Bridges King.
								If i = 6 AndAlso Cromosom2(i, j) = 6 AndAlso Cromosom2(i - 1, j) = 4 Then
									Find = True
									FindNumber += 1
									ChessRules.SmallKingBridgeGray = True
									BridgesKing = True
								'Big Briges King Gray.
								ElseIf i = 2 AndAlso Cromosom2(i, j) = 6 AndAlso Cromosom2(i + 1, j) = 4 Then
									Find = True
									FindNumber += 1
									ChessRules.BigKingBridgeGray = True
									BridgesKing = True

								End If
							ElseIf j = 7 Then
								'Small Bridges King Brown.
								If i = 6 AndAlso Cromosom2(i, j) = -6 AndAlso Cromosom2(i - 1, j) = -4 Then
									Find = True
									FindNumber += 1
									ChessRules.SmallKingBridgeBrown = True
									BridgesKing = True
								'Big Bridges King Brown.
								ElseIf i = 2 AndAlso Cromosom2(i, j) = -6 AndAlso Cromosom2(i + 1, j) = -4 Then
									Find = True
									FindNumber += 1
									ChessRules.BigKingBridgeBrown = True
									BridgesKing = True

								End If
							End If

						End If
					End If
					'When To Same Location Tbles are Different in Gen.
					If Cromosom1(i, j) <> Cromosom2(i, j) Then
						'When Cromosom 2 is Empty.
						If Cromosom2(i, j) = 0 Then
							'Initiate Location of Table.
							Continue While
						Else
							'Situation 1.
							If [and] Then
								'When Cromosom1 Current Location is Empty.
								If Cromosom1(i, j) = 0 Then
									'Initiate Location of Gen.
									CromosomRow = i
									CromosomColumn = j
									Find = True
									FindNumber += 1
									Continue While
								End If

							End If
						End If
						'Store Location of Gen and Calculate Gen Numbers.
						CromosomRow = i
						CromosomColumn = j
						Find = True

						FindNumber += 1


					End If
					j += 1
				End While
				i += 1
			End While
			'If Gen Foundation is Valid. 
			If ((FindNumber = 1 OrElse FindNumber = 2) AndAlso Find) OrElse BridgesKing OrElse AllDraw.SodierConversionOcuured Then
				Return Find
			End If
			'Gen Not Found.
			Return False


		End Function


	End Class

End Namespace