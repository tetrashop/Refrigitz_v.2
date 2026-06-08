Imports System.IO
Imports System.Media
Imports System.Data.OleDb
Imports System.Threading
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Text
Imports System.Linq
Imports System.Drawing
Imports System.Data
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System
'**********************************************************************************************
' * Main class of Form Inherited of Form Main in the C#.*****************************************
' * Ramin Edjlal*******************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Mouse Event Handling Error*****************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Some Soldiers Loos Location  And Virutuallization at Click*********************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Some Codes Lines Frizes********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Hit things Abnormal behaviour**************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Virtualization Things Error****************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * No Reason Logically For Equality of 'SoldierP' and 'Soldier'*******************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Problem of Sameness of Hit Enemys Solved.No Reason For Equality of 'Soldier' and 'SoldierP'RS--************(-+)
' * No Problem For Hiting**********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Bridges of Gray Color Conversion to Kings Brown********************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Bridges Conversion To King Brown Abnormally no Reasonably**********************************CU*****0.88**1**Risk Control************************(*)
' * Color Conversion In Virtualization Hit Enemy***********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Need To Find Enemy Detection on Current OrderPlate*****************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Mate an Kish Dosn't Work*******************************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * No Movments By Computer********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Illegal Virtualization. The Thinking By 'Alice' (My Computer) ChessRules Misleading********RS*****0.12**4**Managements and Cuation Programing**(+)
' * permutative Constant Huristic Results******************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * In Existence of Adding Suported Huristic Constant Huristic Result Detection****************RS*****0.12**4**Managements and Cuation Programing**(+)
' * OrderPlate Not Configured******************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Non Color Hourse Hit Assignment Misleading(Abnormal)***************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Undetected Error Table Content Malfunction*************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * MalFunction Movments Greate than 5 by 'Alice'.*********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Kish' Second Time 'Alice' MalFanction*****************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Kish' 'Alice' Mechnisam Failure***********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' '* Mate' of Unsatisfied in 'Alice'***********************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Mate Dosn't Recognized.********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Virtualization Filed (Not Responding) at Indpencdency State********************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Unable To Draw Timer  Content at Tow Picture Box*******************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Timer Working Hardly.**********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Dead Lock In Drawing Images.***************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Misleading Thread OrderPlate And Time Sharing**********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Thinkings Taking a lot of Time.************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * AntiVirus Protextion and Existance Caused to Reduce Speed of Thinking and lead to Lose.****RS*****0.12**4**Managements and Cuation Programing**(+)
' * No Programatically Reason For Speed Reduction.*********************************************RS*****0.12**4**Managements and Cuation Programing**(+) 
' * Mybe Windows Filrewall Has no been correctly Arranges to reduce speed.*********************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Method on Leave not Work.******************************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * OrderPlate Reader Table MalFunction.*******************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Wrong Sysntax To Read.*********************************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Some Tables of Hitting Tow Person Are Missing.*********************************************__**************(_)
' * Some Syntaxes at Table Read Are Missing.***************************************************__**************(_)
' * Chess Refregitz Sometimes Not Responding due to Cpu Power Non Ability.*********************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Chess Refregitz Sometimes stop working.****************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * 1395/1/16**********************************************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * OrderPlate MalFunction.********************************************************************RS*****0.12**4**Managements and Cuation Programing**{+}
' * Virtualization Error.No Reason For MalFunctionla Operation of Program at Sysntax and Orde.*CU*****0.88**1**Risk Control************************{*}QC-OK.
' * Cause Sensitive Problems of 'Kish' And 'Mate By 'Alice' is borring at StateCP.*************CU*****0.88**1**Risk Control************************{*}QC-OK.
' * Table Content Misleading.******************************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Documentation Faulting On Removing Detials.************************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Loading Games  to Continue failed Unreasonly.**********************************************CU*****0.88**1**Risk Control************************<*>QC-OK.
' * "Thread is dead.The state can not be accessed.".*******************************************CU*****0.88**1**Risk Control************************{*}QC-OK.
' * Illegal Syntax Mechanisam Detection By Genetic Algorithm.**********************************CU*****0.88**1**Risk Control************************<*>QC-Ok.
' * 'MaxCurrentMovmentsNumber' Changes Illegal to Reduced.*************************************CU*****0.88**1**Risk Control************************{*}QC-OK.
' * ***********************************************************************************************************
' * ***********************************************************************************************************
' 



Namespace Refrigtz
	'Constructor
	Public Partial Class FormRefrigtz
		Inherits Form

		'Initiate Global Variable.
		Public Shared MaxCurrentMovmentsNumber As Integer = 1
		Public Shared ErrorTrueMonitorFalse As Boolean = True
		Private tM As Thread = Nothing
		Private Clicked As Boolean = True
		Public Shared MaxDeptHuristicProgress As Integer = 0
		Public Shared Root As [String] = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()(0))
		Public MouseClicked As Boolean = False
		Public Shared Blitz As Boolean = False
		Private PreviousTime As DateTime
		Shared LoadAG As Boolean = False
		Shared _1 As Boolean = False
		Shared _2 As Boolean = False
		Shared _3 As Boolean = False
		Shared _4 As Boolean = False
		Shared Hideag As Boolean = False
		Private [exit] As Boolean = False
		Public Sec As New FormSelect()
		Private AllDrawLoad As Boolean = False
		Private AllOperate As Thread = Nothing
		Shared Paused As Boolean = False
		Shared UpdateConfigurationTableVal As Boolean = False
		Shared NewTable As Boolean = False
		Private bookConn As OleDbConnection
		Private oleDbCmd As New OleDbCommand()
		Private oleDbCmdUser As New OleDbCommand()
		Private TimerImage As Image = Nothing
		Private g1 As Graphics = Nothing
		Private TimerImage1 As Image = Nothing
		Private g2 As Graphics = Nothing
		Private g As Graphics = Nothing
		Private ChessTable As Image = Nothing
		Public Shared LastRow As Integer = -1
		Public Shared LastColumn As Integer = -1
		Private t1 As Thread = Nothing
		Private t2 As Thread = Nothing
		Private t3 As Thread = Nothing
		Private t4 As Thread = Nothing
		Private TTimerSet As Thread
		Public Shared LoadedTable As Boolean = False
		Private GrayWinner As Boolean = False
		Private BrownWiner As Boolean = False
		Public TimerText As Timer = Nothing
		Public GrayTimer As Timer = Nothing
		Public BrownTimer As Timer = Nothing
		Public Shared MovmentsNumber As Integer = 0
		Public Shared EndOfGame As Boolean = False
		Private Maximize As Boolean = False
		Shared RowP As Integer = 0, ColP As Integer = 0, RowS As Integer = 0, ColS As Integer = 0
		Private BobSection As Boolean = True
		Private AliceSection As Boolean = False
		Public Shared Person As Boolean = True
		Shared CurrentKind As Integer = 0
		Public Shared StateCC As Boolean = False
		'Computer With Computer
		Public Shared StateCP As Boolean = False
		'Person With Computer
		Public Shared StateGe As Boolean = False
		'For Genetic Games.
		Private Draw As AllDraw
		Public Shared OrderPlate As Integer = 1
		' int AllDraw.MouseClick;
		Private Soldier As Integer
		Private Elefant As Integer
		Private Hourse As Integer
		Private Bridge As Integer
		Private Minister As Integer
		Private King As Integer
		Private RowClickP As Single = -1, ColumnClickP As Single = -1
		Private RowClick As Integer = -1, ColumnClick As Integer = -1
		Private RowRealesedP As Single = -1, ColumnRealeasedP As Single = -1
		Private RowRealesed As Single = -1, ColumnRealeased As Single = -1
		Public Table As Integer(,) = New Integer(8, 8) {}
		Private THIs As FormRefrigtz = Nothing
		'Error Handling.
		Shared Sub Log(ex As Exception)
			Try
				Dim stackTrace As String = ex.ToString()
					' path of file where stack trace will be stored.
				File.AppendAllText(Root + "\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Constructor No2
		Public Sub New(AllDra As Boolean)

			AllDrawLoad = AllDra
			InitializeComponent()

			If Not AllDrawLoad Then
				Me.pictureBoxRefrigtz.Size = New Size((Me.pictureBoxRefrigtz.Width / 8) * 8, (Me.pictureBoxRefrigtz.Height / 8) * 8)

				t1 = New Thread(New ThreadStart(AliceWithPerson))
				t2 = New Thread(New ThreadStart(BobAction))
				t3 = New Thread(New ThreadStart(AliceAction))

				t4 = New Thread(New ThreadStart(GeneticAction))
			End If


			THIs = Me
			Draw = New AllDraw(THIs)

			If Not AllDrawLoad Then
				BrownTimer = New Timer(False)
				GrayTimer = New Timer(False)
				TimerText = New Timer(True)

				BrownTimer.TimerInitiate()
				GrayTimer.TimerInitiate()
				TTimerSet = New Thread(New ThreadStart(SetTimer))
				TTimerSet.Start()

				TimerText.TimerInitiate()

				TimerText.StartTime()
			End If
			ChessRules.KishBrown = False
			ChessRules.KishGray = False
			ChessRules.MateBrown = False
			ChessRules.MateGray = False


			If Not AllDrawLoad Then
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Table(i, j) = 0
						j += 1
					End While
					i += 1
				End While

				Dim i As Integer = 0
				While i < 8
					Table(i, 1) = 1
					i += 1
				End While

				Dim i As Integer = 8
				While i < 16
					Table(i - 8, 6) = -1
					i += 1
				End While
				Table(2, 0) = 2
				Table(5, 0) = 2
				Table(2, 7) = -2
				Table(5, 7) = -2

				Table(1, 0) = 3
				Table(6, 0) = 3
				Table(1, 7) = -3
				Table(6, 7) = -3

				Table(0, 0) = 4
				Table(7, 0) = 4
				Table(0, 7) = -4
				Table(7, 7) = -4

				Table(3, 0) = 5
				Table(3, 7) = -5

				Table(4, 0) = 6
				Table(4, 7) = -6
			End If
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					AllDraw.TableVeryfy(i, j) = Table(i, j)
					AllDraw.TableVeryfyConst(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While
			If Not AllDrawLoad Then
				AllDraw.TableListAction.Add(Table)
			End If
			Dim i As Integer = 0
			While i < 8
				Draw.SolderesOnTable(i) = New DrawSoldier(i, 1, Color.Gray, Table, 1, False, _
					i)
				i += 1
			End While
			Dim i As Integer = 8
			While i < 16
				Draw.SolderesOnTable(i) = New DrawSoldier(i - 8, 6, Color.Brown, Table, -1, False, _
					i)
				i += 1
			End While
			Draw.ElephantOnTable(0) = New DrawElefant(2, 0, Color.Gray, Table, 1, False, _
				0)
			Draw.ElephantOnTable(1) = New DrawElefant(5, 0, Color.Gray, Table, 1, False, _
				1)
			Draw.ElephantOnTable(2) = New DrawElefant(2, 7, Color.Brown, Table, -1, False, _
				2)
			Draw.ElephantOnTable(3) = New DrawElefant(5, 7, Color.Brown, Table, -1, False, _
				3)

			Draw.HoursesOnTable(0) = New DrawHourse(1, 0, Color.Gray, Table, 1, False, _
				0)
			Draw.HoursesOnTable(1) = New DrawHourse(6, 0, Color.Gray, Table, 1, False, _
				1)
			Draw.HoursesOnTable(2) = New DrawHourse(1, 7, Color.Brown, Table, -1, False, _
				2)
			Draw.HoursesOnTable(3) = New DrawHourse(6, 7, Color.Brown, Table, -1, False, _
				3)

			Draw.BridgesOnTable(0) = New DrawBridge(0, 0, Color.Gray, Table, 1, False, _
				0)
			Draw.BridgesOnTable(1) = New DrawBridge(7, 0, Color.Gray, Table, 1, False, _
				1)
			Draw.BridgesOnTable(2) = New DrawBridge(0, 7, Color.Brown, Table, -1, False, _
				2)
			Draw.BridgesOnTable(3) = New DrawBridge(7, 7, Color.Brown, Table, -1, False, _
				3)

			Draw.MinisterOnTable(0) = New DrawMinister(3, 0, Color.Gray, Table, 1, False, _
				0)
			Draw.MinisterOnTable(1) = New DrawMinister(3, 7, Color.Brown, Table, -1, False, _
				1)

			Draw.KingOnTable(0) = New DrawKing(4, 0, Color.Gray, Table, 1, False, _
				0)
			Draw.KingOnTable(1) = New DrawKing(4, 7, Color.Brown, Table, -1, False, _
				1)



				'TakeRoot.CalculateRootGray(Draw);
			AllDraw.TableListAction.Add(Table)
		End Sub
		'Acccess Point
		Public Property accessDraw() As AllDraw
			Get
				Return Draw
			End Get
			Set
				Draw = value
			End Set
		End Property

		'Syncronization Between Class Dlls.
		Private Sub SetTimer()
			Do
				'while (!StateCC && !StateCP && !StateGe)
				Thread.Sleep(50)
				Timer.DeptFirstSearch = AllDraw.DeptFirstSearch
				Timer.DeptiLevelMax = AllDraw.DeptiLevelMax
				Timer.UseDoubleTime = AllDraw.UseDoubleTime
				Timer.StoreAllDrawCount = AllDraw.StoreADraw.Count
			Loop While True

		End Sub
		Delegate Sub SetlableRefregitzMaxValueCalBack(Refregitz As Label, value As [String])
		Private Sub SetlableRefregitzMaxValue(Refregitz As Label, value As [String])
			Try
				If Refregitz.InvokeRequired Then
					Dim d As New SetlableRefregitzMaxValueCalBack(SetlableRefregitzMaxValue)
					Refregitz.Invoke(New Action(Function() Refregitz.Text = value))
				Else
					Refregitz.Text = value
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
					Refregitz.Value = value
				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		Delegate Sub SetprogressBarRefregitzMaxValueCalBack(Refregitz As ProgressBar, value As Int32)
		Private Sub SetprogressBarRefregitzMaxValue(Refregitz As ProgressBar, value As Int32)
			Try
				If Refregitz.InvokeRequired Then
					Dim d As New SetprogressBarRefregitzMaxValueCalBack(SetprogressBarRefregitzMaxValue)
					Refregitz.Invoke(New Action(Function() Refregitz.Maximum = value))
				Else
					Refregitz.Maximum = value
				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub

		'Boolean Setting of Illustration at Slected Object Rules.
		Function VeryFye(Table As Integer(,), Order As Integer, a As Color) As Boolean(,)
			Dim Tab As Boolean(,) = New Boolean(8, 8) {}
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					If (New ChessRules(1, Table, Order, -1, -1)).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), i, j, a, Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer))) Then
						Tab(i, j) = True
					End If
					j += 1
				End While
				i += 1
			End While
			Return Tab
		End Function
		'Delegate Of Form Close Visibility.
		Delegate Sub SetCloseVisibleCallback()

		Public Sub SetCloseVisible()
			' InvokeRequired required compares the thread ID of the
			' calling thread to the thread ID of the creating thread.
			' If these threads are different, it returns true.
			If Me.InvokeRequired Then
				Try

					Dim d As New SetCloseVisibleCallback(SetCloseVisible)
					Me.Invoke(New Action(Function() Me.Close()))
				Catch t As Exception
					Log(t)
				End Try
			Else
				Try
					Me.Close()
				Catch t As Exception
					Log(t)
				End Try
			End If

		End Sub
		'Load Refregitz Form.
		Private Sub Form1_Load(sender As Object, e As EventArgs)

			If File.Exists(Root + "\Run.txt") Then
				AllDrawLoad = False
				NewTable = False
			End If

			If Not [exit] Then
				[exit] = True
				If Sec.radioButtonGrayOrder.Checked Then
					ChessRules.CurrentOrder = 1
					OrderPlate = 1
				ElseIf Sec.radioButtonBrownOrder.Checked Then
					ChessRules.CurrentOrder = -1
					OrderPlate = -1
				End If
				If Not LoadAG Then
					Dim a As New List(Of Process)()
					a.AddRange(Process.GetProcessesByName("Refrigtz"))
					If a.Count > 1 Then

						If System.Windows.Forms.MessageBox.Show(Nothing, "New Instant Of Refregitz!", "New Instant", MessageBoxButtons.YesNo) = DialogResult.No Then
							Dim i As Integer = 0
							While i < a.Count
								Try

									a(i).Kill()
									exitToolStripMenuItem_Click(sender, e)
								Catch t As Exception
									Log(t)
									Application.ExitThread()

								End Try
								i += 1

							End While
						End If
					End If
				End If
				If True Then
					If Not Directory.Exists(Root + "\DataBase") Then
						If Not Directory.Exists(Root + "\DataBase\MainBank") Then
							Directory.CreateDirectory(Root + "\DataBase\MainBank")
							File.Move(Root + "\ChessBank.accdb", Root + "\DataBase\MainBank\ChessBank.accdb")
						End If
					End If
					If Not Directory.Exists(Root + "\Images") Then
						If Not Directory.Exists(Root + "\Images\Original") Then
							Directory.CreateDirectory(Root + "\Images\Original")
						End If
					End If
					Try
						File.Move(Root + "\OBrB.png", Root + "\Images\Original\BrB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OBrG.png", Root + "\Images\Original\BrG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OEB.png", Root + "\Images\Original\EB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OEG.png", Root + "\Images\Original\EG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OHB.png", Root + "\Images\Original\HB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OHG.png", Root + "\Images\Original\HG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OKB.png", Root + "\Images\Original\KB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OKG.png", Root + "\Images\Original\KG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OMB.png", Root + "\Images\Original\MB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OMG.png", Root + "\Images\Original\MG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OSB.png", Root + "\Images\Original\SB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\OSG.png", Root + "\Images\Original\SG.png")
					Catch t As Exception
						Log(t)
					End Try

					If Not Directory.Exists(Root + "\Images\Fit\Small\") Then
						Directory.CreateDirectory(Root + "\Images\Fit\Small")
					End If
					Try
						File.Move(Root + "\FSBrB.png", Root + "\Images\Fit\Small\BrB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSBrG.png", Root + "\Images\Fit\Small\BrG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSEB.png", Root + "\Images\Fit\Small\EB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSEG.png", Root + "\Images\Fit\Small\EG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSHB.png", Root + "\Images\Fit\Small\HB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSHG.png", Root + "\Images\Fit\Small\HG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSKB.png", Root + "\Images\Fit\Small\KB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSKG.png", Root + "\Images\Fit\Small\KG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSMB.png", Root + "\Images\Fit\Small\MB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSMG.png", Root + "\Images\Fit\Small\MG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSSB.png", Root + "\Images\Fit\Small\SB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FSSG.png", Root + "\Images\Fit\Small\SG.png")
					Catch t As Exception
						Log(t)
					End Try

					If Not Directory.Exists(Root + "\Images\Fit\Big") Then
						Directory.CreateDirectory(Root + "\Images\Fit\Big")
					End If
					Try
						File.Move(Root + "\FBBrB.png", Root + "\Images\Fit\Big\BrB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBBrG.png", Root + "\Images\Fit\Big\BrG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBEB.png", Root + "\Images\Fit\Big\EB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBEG.png", Root + "\Images\Fit\Big\EG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBHB.png", Root + "\Images\Fit\Big\HB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBHG.png", Root + "\Images\Fit\Big\HG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBKB.png", Root + "\Images\Fit\Big\KB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBKG.png", Root + "\Images\Fit\Big\KG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBMB.png", Root + "\Images\Fit\Big\MB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBMG.png", Root + "\Images\Fit\Big\MG.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBSB.png", Root + "\Images\Fit\Big\SB.png")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\FBSG.png", Root + "\Images\Fit\Big\SG.png")
					Catch t As Exception
						Log(t)
					End Try

					If Not Directory.Exists(Root + "\Images\Program") Then
						Directory.CreateDirectory(Root + "\Images\Program")
					End If

					Try
						File.Move(Root + "\Black.jpg", Root + "\Images\Program\Black.jpg")
					Catch t As Exception
						Log(t)
					End Try
					Try
						File.Move(Root + "\White.jpg", Root + "\Images\Program\White.jpg")
					Catch t As Exception
						Log(t)
					End Try


					If Not Directory.Exists(Root + "\Music") Then
						Directory.CreateDirectory(Root + "\Music")
					End If
					Try
						File.Move(Root + "Click6.wav", Root + "\Music\Click6.wav")
					Catch t As Exception
						Log(t)
					End Try
				End If
				If Not AllDrawLoad Then
					If Not System.IO.File.Exists(Root + "\Database\CurrentBank.accdb") Then
						System.IO.File.Copy(Root + "\Database\MainBank\ChessBank.accdb", Root + "\Database\CurrentBank.accdb")
						InsertTableAtDataBase(Table)
						CreateConfigurationTable()
					Else
						If Not NewTable Then
							ChessRules.CurrentOrder = 1
							OrderPlate = 1
							'Read Last Table and Set MovementNumber
							Table = ReadTable(0, MovmentsNumber)
							'Clear Table List.
							Draw.TableList.Clear()
							'Add Table List.
							Draw.TableList.Add(Table)
							'Construction of Draw Things and Thinkings.

							Draw.SetRowColumn(0)
							'When Configuration is Allowed Read Configuration.
							If Not UpdateConfigurationTableVal Then
								ReadConfigurationTable()
							End If
							'Set Configuration To True for some unknown reason!.

							UpdateConfigurationTableVal = True
						Else
							Dim iii As Integer = 0
							Do
								iii += 1
							Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
							System.IO.File.Copy(Root + "\Database\CurrentBank.accdb", Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
							System.IO.File.Delete(Root + "\Database\CurrentBank.accdb")
							System.IO.File.Copy(Root + "\Database\MainBank\ChessBank.accdb", Root + "\Database\CurrentBank.accdb")
							System.IO.File.Copy(Root + "\Database\MainBank\Monitor_Log.txt", Root + "\Database\Monitor.txt")

							InsertTableAtDataBase(Table)

							CreateConfigurationTable()
						End If
					End If




					AllOperate = New Thread(New ThreadStart(AllOperations))
					AllOperate.Start()
					If OrderPlate = 1 Then
						BrownTimer.StopTime()
						GrayTimer.StartTime()
					Else
						GrayTimer.StopTime()
						BrownTimer.StartTime()
					End If
				Else
					If t1 IsNot Nothing Then
						t1.Abort()
					End If
					If t2 IsNot Nothing Then
						t2.Abort()
					End If
					If t3 IsNot Nothing Then
						t3.Abort()
					End If
					If t4 IsNot Nothing Then
						t4.Abort()
					End If
				End If
				AllDraw.DrawTable = True
			Else
				If t1 IsNot Nothing Then
					t1.Abort()
				End If
				If t2 IsNot Nothing Then
					t2.Abort()
				End If
				If t3 IsNot Nothing Then
					t3.Abort()
				End If
				If t4 IsNot Nothing Then
					t4.Abort()
				End If

				If AllOperate IsNot Nothing Then
					AllOperate.Abort()
				End If
				Application.[Exit]()
			End If



			If File.Exists(Root + "\Run.txt") Then
				Dim _0 As [String] = File.ReadAllText(Root + "\Run.txt")
				If _0(0) = "1"C Then
					_1 = True
				Else
					_1 = False
				End If
				If _0(1) = "1"C Then
					_2 = True
				Else
					_2 = False
				End If
				If _0(2) = "1"C Then
					_3 = True
				Else
					_3 = False
				End If
				If _0(3) = "1"C Then
					_4 = True
				Else
					_4 = False
				End If
				File.Delete(Root + "Run.txt")
				continueAGameToolStripMenuItem.Visible = False
				If _1 Then
					computerWithComputerToolStripMenuItem_Click(sender, e)
				ElseIf _2 Then
					computerWithComputerToolStripMenuItem1_Click(sender, e)
				ElseIf _3 Then
					toolStripMenuItem3_Click(sender, e)
				ElseIf _4 Then
					toolStripMenuItem6_Click(sender, e)

				End If
			End If

		End Sub
		'Reading Table Database.
		Function ReadTable(Movment As Integer, ByRef MoveNumber As Integer) As Integer(,)
			Dim Tab As Integer(,) = Table
			Dim Move As Integer = 0
			AllDraw.TableListAction.Clear()
			Do
				Try
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"
					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn
					Dim TableName As [String] = Move.ToString()
					Dim Zero As [String] = "Table"
					Dim i As Integer = 0
					While i < 8 - TableName.Length
						Zero += "0"
						i += 1
					End While
					TableName = Zero + TableName

					oleDbCmd.CommandText = "Select * From " + TableName
					Dim dr As OleDbDataReader = Nothing
					dr = oleDbCmd.ExecuteReader()
					Dim ii As Integer = 0
					While dr.Read()
						Tab(0, ii) = System.Convert.ToInt32(dr("a"))
						Tab(1, ii) = System.Convert.ToInt32(dr("b"))
						Tab(2, ii) = System.Convert.ToInt32(dr("c"))
						Tab(3, ii) = System.Convert.ToInt32(dr("d"))
						Tab(4, ii) = System.Convert.ToInt32(dr("e"))
						Tab(5, ii) = System.Convert.ToInt32(dr("f"))
						Tab(6, ii) = System.Convert.ToInt32(dr("g"))
						Tab(7, ii) = System.Convert.ToInt32(dr("h"))
						ii += 1
					End While
					Dim TableA As Integer(,) = New Integer(8, 8) {}
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							TableA(i, j) = Tab(i, j)
							j += 1
						End While
						i += 1
					End While
					MaxCurrentMovmentsNumber += 1
					Draw.TableList.Clear()
					Draw.TableList.Add(TableA)
					Draw.SetRowColumn(0)
					AllDraw.TableListAction.Add(TableA)
					If AllDraw.TableListAction.Count > 1 Then
						Dim R As New ChessGeneticAlgorithm()
						If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
							Dim HitVal As Boolean = False
							Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
							If Hit <> 0 Then
								HitVal = True
							End If
							Dim Convert As Boolean = False
							If OrderPlate = 1 Then
								If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
									If R.CromosomColumn = 7 Then
										Convert = True
									End If
								End If
								If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
									ChessRules.BridgeActGray = True
								End If
								AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MoveNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
									Hit, ChessRules.BridgeActGray, Convert)
							Else
								If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
									If R.CromosomColumn = 0 Then
										Convert = True
									End If
								End If
								If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
									ChessRules.BridgeActBrown = True
								End If

								AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MoveNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
									Hit, ChessRules.BridgeActBrown, Convert)
							End If
							SetBoxStatistic(AllDraw.SyntaxToWrite)
							RefreshBoxStatistic()
						End If
					End If


					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					Move += 1
					If Move > 1 Then
						MoveNumber += 1
					End If
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							TableA(i, j) = Tab(i, j)
							j += 1
						End While
						i += 1
					End While


					If (New ChessRules(1, TableA, OrderPlate, -1, -1).Mate(TableA, OrderPlate)) Then
						Dim iii As Integer = 0
						Do
							iii += 1
						Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
						System.IO.File.Copy(Root + "\Database\CurrentBank.accdb", "Database\Games\CurrentBank" + iii.ToString() + ".accdb")
						System.IO.File.Delete(Root + "\Database\CurrentBank.accdb")

						Exit Try
					End If
				Catch t As Exception
					Log(t)
					Try
						bookConn.Close()
						oleDbCmd.Dispose()
						bookConn.Dispose()

						Move += 1

						Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"
						bookConn = New OleDbConnection(connParam)
						bookConn.Open()
						oleDbCmd.Connection = bookConn
						Dim TableName As [String] = (Move).ToString()
						Dim Zero As [String] = "Table"
						Dim i As Integer = 0
						While i < 8 - TableName.Length
							Zero += "0"
							i += 1
						End While
						TableName = Zero + TableName

						oleDbCmd.CommandText = "Select * From " + TableName
						Dim dr As OleDbDataReader = Nothing
						dr = oleDbCmd.ExecuteReader()
						Dim ii As Integer = 0
						While dr.Read()
							Tab(0, ii) = System.Convert.ToInt32(dr("a"))
							Tab(1, ii) = System.Convert.ToInt32(dr("b"))
							Tab(2, ii) = System.Convert.ToInt32(dr("c"))
							Tab(3, ii) = System.Convert.ToInt32(dr("d"))
							Tab(4, ii) = System.Convert.ToInt32(dr("e"))
							Tab(5, ii) = System.Convert.ToInt32(dr("f"))
							Tab(6, ii) = System.Convert.ToInt32(dr("g"))
							Tab(7, ii) = System.Convert.ToInt32(dr("h"))
							ii += 1
						End While
						Dim TableA As Integer(,) = New Integer(8, 8) {}
						Dim i As Integer = 0
						While i < 8
							Dim j As Integer = 0
							While j < 8
								TableA(i, j) = Tab(i, j)
								j += 1
							End While
							i += 1
						End While

						Draw.TableList.Clear()
						Draw.TableList.Add(TableA)
						Draw.SetRowColumn(0)
						AllDraw.TableListAction.Add(TableA)
						If AllDraw.TableListAction.Count >= 1 Then
							Dim R As New ChessGeneticAlgorithm()
							If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
								Dim HitVal As Boolean = False
								Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
								If Hit <> 0 Then
									HitVal = True
								End If
								Dim Convert As Boolean = False
								If OrderPlate = 1 Then
									If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
										If R.CromosomColumn = 7 Then
											Convert = True
										End If
									End If
									AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MoveNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
										Hit, ChessRules.BridgeActGray, Convert)
								Else
									If AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst) = -1 Then
										If R.CromosomColumn = 0 Then
											Convert = True
										End If
									End If
									AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MoveNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
										Hit, ChessRules.BridgeActBrown, Convert)
								End If
								SetBoxStatistic(AllDraw.SyntaxToWrite)
								RefreshBoxStatistic()
							End If
						End If


						bookConn.Close()
						oleDbCmd.Dispose()
						bookConn.Dispose()
						Dim i As Integer = 0
						While i < 8
							Dim j As Integer = 0
							While j < 8
								TableA(i, j) = Tab(i, j)
								j += 1
							End While
							i += 1
						End While


						If (New ChessRules(1, TableA, OrderPlate, -1, -1).Mate(TableA, OrderPlate)) Then
							Dim iii As Integer = 0
							Do
								iii += 1
							Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
							System.IO.File.Copy(Root + "\Database\CurrentBank.accdb", Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
							System.IO.File.Delete(Root + "\Database\CurrentBank.accdb")

							Exit Try

						End If
					Catch tt As Exception
						Log(tt)
						bookConn.Close()
						oleDbCmd.Dispose()
						bookConn.Dispose()
						Exit Try
					End Try
				End Try
				If Move > 1 Then
					OrderPlate *= -1
					ChessRules.CurrentOrder = OrderPlate


				End If
			Loop While True
			Return Tab


		End Function
		'Verify Accuarance of Table Games Methos.
		Function VerifyTable(FileName As [String], Movment As Integer, ByRef MoveNumber As Integer) As Boolean
			Dim PreviouseKish As Boolean = False

			Dim Tab As Integer(,) = Table
			Dim Move As Integer = 1
			Dim Order As Integer = 1
			Dim TowKishFromOneKind As Boolean = False
			Do
				If Move > 5000 Then
					Exit Do
				End If
				Try
					If Move Mod 2 = 1 Then
						Order = 1
					Else
						Order = -1
					End If
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Persist Security Info=true;Jet OLEDB:Database Password=''"
					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn
					Dim TableName As [String] = Move.ToString()
					Dim Zero As [String] = "Table"
					Dim i As Integer = 0
					While i < 8 - TableName.Length
						Zero += "0"
						i += 1
					End While
					TableName = Zero + TableName

					oleDbCmd.CommandText = "Select * From " + TableName
					Dim dr As OleDbDataReader = Nothing
					Try
						dr = oleDbCmd.ExecuteReader()
					Catch t As Exception
						Log(t)
						Move += 1
						Exit Try
					End Try
					Dim ii As Integer = 0
					While dr.Read()
						Tab(0, ii) = System.Convert.ToInt32(dr("a"))
						Tab(1, ii) = System.Convert.ToInt32(dr("b"))
						Tab(2, ii) = System.Convert.ToInt32(dr("c"))
						Tab(3, ii) = System.Convert.ToInt32(dr("d"))
						Tab(4, ii) = System.Convert.ToInt32(dr("e"))
						Tab(5, ii) = System.Convert.ToInt32(dr("f"))
						Tab(6, ii) = System.Convert.ToInt32(dr("g"))
						Tab(7, ii) = System.Convert.ToInt32(dr("h"))
						ii += 1
					End While
					Dim TableA As Integer(,) = New Integer(8, 8) {}
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							TableA(i, j) = Tab(i, j)
							j += 1
						End While
						i += 1
					End While
					Draw.TableList.Clear()
					Draw.TableList.Add(TableA)
					Draw.SetRowColumn(0)
					If Not Draw.isEnemyThingsinStable(TableA, AllDraw.TableVeryfy, Order) Then
						Tab = Nothing
						Tab(0, 0) = -1
					Else
						Dim i As Integer = 0
						While i < 8
							Dim j As Integer = 0
							While j < 8
								AllDraw.TableVeryfy(i, j) = Tab(i, j)
								j += 1
							End While
							i += 1

						End While
					End If


					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					Move += 1
					If Move > 1 Then
						MoveNumber += 1
					End If
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							TableA(i, j) = Tab(i, j)
							j += 1
						End While
						i += 1
					End While


					If (New ChessRules(1, TableA, OrderPlate, -1, -1).Mate(TableA, OrderPlate)) Then

						Dim iii As Integer = 0
						Do
							iii += 1
						Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
						System.IO.File.Copy(Root + "\Database\CurrentBank.accdb", Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
						System.IO.File.Delete(Root + "\Database\CurrentBank.accdb")

						Exit Try
					End If
					If ChessRules.KishGray AndAlso TowKishFromOneKind Then
						Tab = Nothing

						Tab(0, 0) = -1
					ElseIf Order = 1 AndAlso ChessRules.KishGray Then
						TowKishFromOneKind = True
					Else
						TowKishFromOneKind = False
					End If

					If ChessRules.KishGray AndAlso TowKishFromOneKind Then
						Tab = Nothing

						Tab(0, 0) = -1
					ElseIf Order = 1 AndAlso ChessRules.KishGray Then
						TowKishFromOneKind = True
					Else
						TowKishFromOneKind = False
					End If

					If ChessRules.KishBrown OrElse ChessRules.KishGray Then
						If PreviouseKish Then
							Return False
						Else
							PreviouseKish = True
						End If
					Else
						PreviouseKish = False
					End If
				Catch t As Exception

					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					Log(t)

					Do
						Try

							Move += 1

							Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Persist Security Info=true;Jet OLEDB:Database Password=''"
							bookConn = New OleDbConnection(connParam)
							bookConn.Open()
							oleDbCmd.Connection = bookConn
							Dim TableName As [String] = (Move).ToString()
							Dim Zero As [String] = "Table"
							Dim i As Integer = 0
							While i < 8 - TableName.Length
								Zero += "0"
								i += 1
							End While
							TableName = Zero + TableName

							oleDbCmd.CommandText = "Drop Table " + TableName
							Dim dr As OleDbDataReader = Nothing
							dr = oleDbCmd.ExecuteReader()
							bookConn.Close()
							oleDbCmd.Dispose()
								'return true;

							bookConn.Dispose()
						Catch tt As Exception
							Log(tt)
							bookConn.Close()
							oleDbCmd.Dispose()
							bookConn.Dispose()
							Return False
						End Try
					Loop While True
				End Try
				If Move > 1 Then
					OrderPlate *= -1
					ChessRules.CurrentOrder = OrderPlate


				End If
			Loop While True
			bookConn.Close()
			oleDbCmd.Dispose()
			bookConn.Dispose()

			Return True


		End Function
		'Read Specific Table Number.
		Function ReadTableMovmentNumber() As Integer(,)
			Dim Tab As Integer(,) = Table
			Dim Move As Integer = MovmentsNumber
			AllDraw.TableListAction.Clear()

			Try
				If Move > 1 Then
					If MovmentsNumber Mod 2 = 0 Then
						OrderPlate = 1
					Else
						OrderPlate = -1
					End If
					ChessRules.CurrentOrder = OrderPlate
				End If
				Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"
				bookConn = New OleDbConnection(connParam)
				bookConn.Open()
				oleDbCmd.Connection = bookConn
				Dim TableName As [String] = Move.ToString()
				Dim Zero As [String] = "Table"
				Dim i As Integer = 0
				While i < 8 - TableName.Length
					Zero += "0"
					i += 1
				End While
				TableName = Zero + TableName

				oleDbCmd.CommandText = "Select * From " + TableName
				Dim dr As OleDbDataReader = Nothing
				dr = oleDbCmd.ExecuteReader()
				Dim ii As Integer = 0
				While dr.Read()
					Tab(0, ii) = System.Convert.ToInt32(dr("a"))
					Tab(1, ii) = System.Convert.ToInt32(dr("b"))
					Tab(2, ii) = System.Convert.ToInt32(dr("c"))
					Tab(3, ii) = System.Convert.ToInt32(dr("d"))
					Tab(4, ii) = System.Convert.ToInt32(dr("e"))
					Tab(5, ii) = System.Convert.ToInt32(dr("f"))
					Tab(6, ii) = System.Convert.ToInt32(dr("g"))
					Tab(7, ii) = System.Convert.ToInt32(dr("h"))
					ii += 1
				End While
				Dim TableA As Integer(,) = New Integer(8, 8) {}
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						TableA(i, j) = Tab(i, j)
						j += 1
					End While
					i += 1
				End While

				AllDraw.TableListAction.Add(TableA)
				If AllDraw.TableListAction.Count >= 1 Then
					Dim R As New ChessGeneticAlgorithm()
					If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
						Dim HitVal As Boolean = False
						Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
						If Hit <> 0 Then
							HitVal = True
						End If
						Dim Convert As Boolean = False
						If OrderPlate = 1 Then
							If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
								If R.CromosomColumn = 7 Then
									Convert = True
								End If
							End If
							AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MovmentsNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
								Hit, ChessRules.BridgeActGray, Convert)
						Else
							If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRowFirst, R.CromosomColumnFirst) = -1 Then
								If R.CromosomColumn = 0 Then
									Convert = True
								End If
							End If
							AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MovmentsNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
								Hit, ChessRules.BridgeActBrown, Convert)
						End If
						SetBoxStatistic(AllDraw.SyntaxToWrite)
						RefreshBoxStatistic()
					End If
				End If


				bookConn.Close()
				oleDbCmd.Dispose()
				bookConn.Dispose()
				Move += 1

				If (New ChessRules(1, Tab, OrderPlate, -1, -1).Mate(Tab, OrderPlate)) Then
					Dim iii As Integer = 0
					Do
						iii += 1
					Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
					System.IO.File.Copy(Root + "\Database\CurrentBank.accdb", Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
					System.IO.File.Delete(Root + "\Database\CurrentBank.accdb")

					Return TableA
				End If
			Catch t As Exception
				Log(t)
				Try
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()

					Move += 1

					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"
					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn
					Dim TableName As [String] = (Move).ToString()
					Dim Zero As [String] = "Table"
					Dim i As Integer = 0
					While i < 8 - TableName.Length
						Zero += "0"
						i += 1
					End While
					TableName = Zero + TableName

					oleDbCmd.CommandText = "Select * From " + TableName
					Dim dr As OleDbDataReader = Nothing
					dr = oleDbCmd.ExecuteReader()
					Dim ii As Integer = 0
					While dr.Read()
						Tab(0, ii) = System.Convert.ToInt32(dr("a"))
						Tab(1, ii) = System.Convert.ToInt32(dr("b"))
						Tab(2, ii) = System.Convert.ToInt32(dr("c"))
						Tab(3, ii) = System.Convert.ToInt32(dr("d"))
						Tab(4, ii) = System.Convert.ToInt32(dr("e"))
						Tab(5, ii) = System.Convert.ToInt32(dr("f"))
						Tab(6, ii) = System.Convert.ToInt32(dr("g"))
						Tab(7, ii) = System.Convert.ToInt32(dr("h"))
						ii += 1
					End While
					Dim TableA As Integer(,) = New Integer(8, 8) {}
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							TableA(i, j) = Tab(i, j)
							j += 1
						End While
						i += 1
					End While

					AllDraw.TableListAction.Add(TableA)
					If AllDraw.TableListAction.Count >= 1 Then
						Dim R As New ChessGeneticAlgorithm()
						If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
							Dim HitVal As Boolean = False
							Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
							If Hit <> 0 Then
								HitVal = True
							End If
							Dim Convert As Boolean = False
							If OrderPlate = 1 Then
								If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
									If R.CromosomColumn = 7 Then
										Convert = True
									End If
								End If
								AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MovmentsNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
									Hit, ChessRules.BridgeActGray, Convert)
							Else
								If AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst) = -1 Then
									If R.CromosomColumn = 0 Then
										Convert = True
									End If
								End If
								AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableA, MovmentsNumber, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
									Hit, ChessRules.BridgeActBrown, Convert)
							End If
							SetBoxStatistic(AllDraw.SyntaxToWrite)
							RefreshBoxStatistic()
						End If
					End If

					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					If (New ChessRules(1, Tab, OrderPlate, -1, -1).Mate(Tab, OrderPlate)) Then
						Dim iii As Integer = 0
						Do
							iii += 1
						Loop While System.IO.File.Exists("Database\Games\CurrentBank" + iii.ToString() + ".accdb")
						System.IO.File.Copy("Database\CurrentBank.accdb", Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
						System.IO.File.Delete("Database\CurrentBank.accdb")
						Return TableA

						


					End If
				Catch tt As Exception
					Log(tt)
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					Return Nothing
				End Try
			End Try



			Return Tab


		End Function
		'Creation of New Tables at DatabaseMethod.
		Function CreatTable() As [String]
			Begin12:
			Try
				Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

				bookConn = New OleDbConnection(connParam)
				bookConn.Open()
				oleDbCmd.Connection = bookConn
				Dim TableName As [String] = MovmentsNumber.ToString()
				Dim Zero As [String] = "Table"
				Dim i As Integer = 0
				While i < 8 - TableName.Length
					Zero += "0"
					i += 1
				End While
				TableName = Zero + TableName

				oleDbCmd.CommandText = "Create Table " + TableName + " (a Number NOT NULL,b Number NOT NULL,c Number NOT NULL,d Number NOT NULL,e Number NOT NULL,f Number NOT NULL,g Number NOT NULL,h Number NOT NULL)"
				Dim temp As Integer = 0
				temp = oleDbCmd.ExecuteNonQuery()
				bookConn.Close()
				oleDbCmd.Dispose()
				bookConn.Dispose()
				Return TableName
			Catch t As Exception
				Log(t)
				Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

				bookConn = New OleDbConnection(connParam)
				bookConn.Open()
				oleDbCmd.Connection = bookConn
				Dim TableName As [String] = MovmentsNumber.ToString()
				Dim Zero As [String] = "Table"
				Dim i As Integer = 0
				While i < 8 - TableName.Length
					Zero += "0"
					i += 1
				End While
				TableName = Zero + TableName

				oleDbCmd.CommandText = "Drop Table " + TableName
				Dim temp As Integer = 0
				temp = oleDbCmd.ExecuteNonQuery()
				bookConn.Close()
				oleDbCmd.Dispose()
				bookConn.Dispose()

				GoTo Begin12
			End Try
		End Function
		'Creatiopn of Configuration Table
		Sub CreateConfigurationTable()
			If Not AllDrawLoad Then
				Begin12:
				Try
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn

					oleDbCmd.CommandText = "Create Table Configuration (checkBoxDeptHuristic Number NOT NULL,checkBoxPredictHuristci Number NOT NULL,checkBoxDeptFirstSearch Number NOT NULL,checkBoxBestMovments Number NOT NULL,checkBoxOnlySelf Number NOT NULL,radioButtonOriginalImages Number NOT NULL,radioButtonBigFittingImages Number NOT NULL,radioButtonSmallFittingImages Number NOT NULL,checkBoxDeptMovement Number NOT NULL,checkBoxUseDoubleTime Number NOT NULL,checkBoxUsePenaltyRegradMechnisam Number NOT NULL,checkBoxDynamicProgrammingDeptFirst Number NOT NULL,comboBoxMaxTree Number NOT NULL,comboBoxAttack Number NOT NULL,comboBoxAchmaz Number NOT NULL,comboBoxReducedAttacked Number NOT NULL,comboBoxSupport Number NOT NULL,comboBoxHitting Number NOT NULL,comboBoxMovments Number NOT NULL)"
					Dim temp As Integer = 0
					temp = oleDbCmd.ExecuteNonQuery()
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn

					oleDbCmd.CommandText = "Insert into Configuration (checkBoxDeptHuristic,checkBoxPredictHuristci,checkBoxDeptFirstSearch,checkBoxBestMovments,checkBoxOnlySelf,radioButtonOriginalImages,radioButtonBigFittingImages,radioButtonSmallFittingImages,checkBoxDeptMovement,checkBoxUseDoubleTime,checkBoxUsePenaltyRegradMechnisam,checkBoxDynamicProgrammingDeptFirst,comboBoxMaxTree,comboBoxAttack,comboBoxAchmaz,comboBoxReducedAttacked,comboBoxSupport,comboBoxHitting,comboBoxMovments) values(" + System.Convert.ToInt32(checkBoxDeptHuristic.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxPredictHuristci.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxDeptFirstSearch.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxBestMovments.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxOnlySelf.Checked).ToString() + "," + System.Convert.ToInt32(radioButtonOriginalImages.Checked).ToString() + "," + System.Convert.ToInt32(radioButtonBigFittingImages.Checked).ToString() + "," + System.Convert.ToInt32(radioButtonSmallFittingImages.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxBestMovments.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxUseDoubleTime.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxUsePenaltyRegradMechnisam.Checked).ToString() + "," + System.Convert.ToInt32(checkBoxDynamicProgrammingDeptFirst.Checked).ToString() + "," + System.Convert.ToInt32(comboBoxMaxTree.Text).ToString() + "," + System.Convert.ToInt32(comboBoxAttack.Text).ToString() + "," + System.Convert.ToInt32(comboBoxAchmaz.Text).ToString() + "," + System.Convert.ToInt32(comboBoxReducedAttacked.Text).ToString() + "," + System.Convert.ToInt32(comboBoxSupport.Text).ToString() + "," + System.Convert.ToInt32(comboBoxHitting.Text).ToString() + "," + System.Convert.ToInt32(comboBoxMovments.Text).ToString() + ")"

					temp = oleDbCmd.ExecuteNonQuery()
					bookConn.Close()
					oleDbCmd.Dispose()

					bookConn.Dispose()
				Catch t As Exception
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()

					Log(t)
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn
					oleDbCmd.CommandText = "Drop Table Configuration"
					Dim temp As Integer = 0
					temp = oleDbCmd.ExecuteNonQuery()
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()

					GoTo Begin12
				End Try
			End If
		End Sub
		'Reading of Configuration Table Method.
		Sub ReadConfigurationTable()
			If Not AllDrawLoad Then
				Begin12:
				Try
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn

					oleDbCmd.CommandText = "Select * from Configuration"
					Dim dr As OleDbDataReader = Nothing
					dr = oleDbCmd.ExecuteReader()
					If dr.Read() Then
						checkBoxDeptHuristic.Checked = System.Convert.ToBoolean(dr("checkBoxDeptHuristic"))
						checkBoxPredictHuristci.Checked = System.Convert.ToBoolean(dr("checkBoxPredictHuristci"))
						checkBoxDeptFirstSearch.Checked = System.Convert.ToBoolean(dr("checkBoxDeptFirstSearch"))
						checkBoxBestMovments.Checked = System.Convert.ToBoolean(dr("checkBoxBestMovments"))
						checkBoxOnlySelf.Checked = System.Convert.ToBoolean(dr("checkBoxOnlySelf"))
						radioButtonOriginalImages.Checked = System.Convert.ToBoolean(dr("radioButtonOriginalImages"))
						radioButtonBigFittingImages.Checked = System.Convert.ToBoolean(dr("radioButtonBigFittingImages"))
						radioButtonSmallFittingImages.Checked = System.Convert.ToBoolean(dr("radioButtonSmallFittingImages"))
						checkBoxDeptMovement.Checked = System.Convert.ToBoolean(dr("checkBoxDeptMovement"))
						checkBoxUseDoubleTime.Checked = System.Convert.ToBoolean(dr("checkBoxUseDoubleTime"))
						checkBoxUsePenaltyRegradMechnisam.Checked = System.Convert.ToBoolean(dr("checkBoxUsePenaltyRegradMechnisam"))
						checkBoxDynamicProgrammingDeptFirst.Checked = System.Convert.ToBoolean(dr("checkBoxDynamicProgrammingDeptFirst"))
						comboBoxMaxTree.Text = System.Convert.ToString(dr("comboBoxMaxTree"))
						comboBoxAttack.Text = System.Convert.ToString(dr("comboBoxAttack"))
						comboBoxAchmaz.Text = System.Convert.ToString(dr("comboBoxAchmaz"))
						comboBoxReducedAttacked.Text = System.Convert.ToString(dr("comboBoxReducedAttacked"))
						comboBoxSupport.Text = System.Convert.ToString(dr("comboBoxSupport"))
						comboBoxHitting.Text = System.Convert.ToString(dr("comboBoxHitting"))

						comboBoxMovments.Text = System.Convert.ToString(dr("comboBoxMovments"))
					End If
					bookConn.Close()
					oleDbCmd.Dispose()

					bookConn.Dispose()
				Catch t As Exception
					Log(t)
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()
					Try
						Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

						bookConn = New OleDbConnection(connParam)
						bookConn.Open()
						oleDbCmd.Connection = bookConn
						oleDbCmd.CommandText = "Drop Table Configuration"
						Dim temp As Integer = 0
						temp = oleDbCmd.ExecuteNonQuery()
						bookConn.Close()
						oleDbCmd.Dispose()
						bookConn.Dispose()
					Catch tt As Exception
						Log(tt)
						bookConn.Close()
						oleDbCmd.Dispose()
						bookConn.Dispose()

						CreateConfigurationTable()
					End Try

					GoTo Begin12
				End Try
			End If
		End Sub
		'Updating of Configuration Method.
		Sub UpdateConfigurationTable()
			If UpdateConfigurationTableVal Then
				Begin12:
				Try
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn

					oleDbCmd.CommandText = "Update Configuration Set checkBoxDeptHuristic=" + System.Convert.ToInt32(checkBoxDeptHuristic.Checked).ToString() + ",checkBoxPredictHuristci=" + System.Convert.ToInt32(checkBoxPredictHuristci.Checked).ToString() + ",checkBoxDeptFirstSearch=" + System.Convert.ToInt32(checkBoxDeptFirstSearch.Checked).ToString() + ",checkBoxBestMovments=" + System.Convert.ToInt32(checkBoxBestMovments.Checked).ToString() + ",checkBoxOnlySelf=" + System.Convert.ToInt32(checkBoxOnlySelf.Checked).ToString() + ",radioButtonOriginalImages=" + System.Convert.ToInt32(radioButtonOriginalImages.Checked).ToString() + ",radioButtonBigFittingImages=" + System.Convert.ToInt32(radioButtonBigFittingImages.Checked).ToString() + ",radioButtonSmallFittingImages=" + System.Convert.ToInt32(radioButtonSmallFittingImages.Checked).ToString() + ",checkBoxDeptMovement=" + System.Convert.ToInt32(checkBoxDeptMovement.Checked).ToString() + ",checkBoxUseDoubleTime=" + System.Convert.ToInt32(checkBoxUseDoubleTime.Checked).ToString() + ",checkBoxUsePenaltyRegradMechnisam=" + System.Convert.ToInt32(checkBoxUsePenaltyRegradMechnisam.Checked).ToString() + ",checkBoxDynamicProgrammingDeptFirst=" + System.Convert.ToInt32(checkBoxDynamicProgrammingDeptFirst.Checked).ToString() + ",comboBoxMaxTree=" + comboBoxMaxTree.Text + ",comboBoxAttack=" + comboBoxAttack.Text + ",comboBoxAchmaz=" + comboBoxAchmaz.Text + ",comboBoxReducedAttacked=" + comboBoxReducedAttacked.Text + ",comboBoxSupport=" + comboBoxSupport.Text + ",comboBoxHitting=" + comboBoxHitting.Text + ",comboBoxMovments=" + comboBoxMovments.Text

					Dim temp As Integer = oleDbCmd.ExecuteNonQuery()
					bookConn.Close()
					oleDbCmd.Dispose()

					bookConn.Dispose()
				Catch t As Exception
					Log(t)
					Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

					bookConn = New OleDbConnection(connParam)
					bookConn.Open()
					oleDbCmd.Connection = bookConn
					oleDbCmd.CommandText = "Drop Table Configuration"
					Dim temp As Integer = 0
					temp = oleDbCmd.ExecuteNonQuery()
					bookConn.Close()
					oleDbCmd.Dispose()
					bookConn.Dispose()

					GoTo Begin12
				End Try
			End If
		End Sub
		'Inserting of New Tabler at Database.
		Sub InsertTableAtDataBase(Table As Integer(,))
			Dim Tab As Integer(,) = New Integer(8, 8) {}
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					Tab(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While
			Dim TableName As [String] = CreatTable()
			Dim connParam As [String] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Root + "\" + "Database\CurrentBank.accdb;Persist Security Info=true;Jet OLEDB:Database Password=''"

			bookConn = New OleDbConnection(connParam)
			bookConn.Open()
			oleDbCmd.Connection = bookConn
			Dim i As Integer = 0
			While i < 8
				oleDbCmd.CommandText = "insert into " + TableName + "(a,b,c,d,e,f,g,h)  values (" + Tab(0, i).ToString() + "," + Tab(1, i).ToString() + "," + Tab(2, i).ToString() + "," + Tab(3, i).ToString() + "," + Tab(4, i).ToString() + "," + Tab(5, i).ToString() + "," + Tab(6, i).ToString() + "," + Tab(7, i).ToString() + ")"
				Dim temp As Integer = 0

				temp = oleDbCmd.ExecuteNonQuery()
				i += 1
			End While
			MaxCurrentMovmentsNumber += 1
			bookConn.Close()
			oleDbCmd.Dispose()
			bookConn.Dispose()

		End Sub
		'Painting of Form Refregitz PictureBox and Tow Timer Pictue Box on Time.
		Private Sub pictureBoxRefrigtz_Paint(sender As Object, e As PaintEventArgs)
			'System.Threading.Thread.Sleep(20);

			If AllDraw.TableListAction.Count > 3 Then
				toolStripMenuItemRandomGeneticGames.Enabled = True
			Else
				toolStripMenuItemRandomGeneticGames.Enabled = False
			End If
			If Not GrayTimer.Paused Then
				Try
					TimerImage = CType(New Bitmap(pictureBoxTimerGray.Width, pictureBoxTimerGray.Height), Image)
					g1 = Graphics.FromImage(TimerImage)
					g1.FillRectangle(New SolidBrush(Color.Gray), New Rectangle(New Point(0, 0), New Size(pictureBoxTimerGray.Width, pictureBoxTimerGray.Height)))
					g1.DrawString(GrayTimer.ReturnTime(), New Font("Times New Roman", 30), New SolidBrush(Color.Black), New PointF(5, 5))
					pictureBoxTimerGray.Image = TimerImage
					g1.Dispose()
					GrayTimer.TextChanged = False
				Catch t As Exception
					pictureBoxTimerGray.Update()
					pictureBoxTimerGray.Invalidate()
					RunInFront()
					Log(t)
				End Try
			End If



			If Not BrownTimer.Paused Then
				Try
					TimerImage1 = CType(New Bitmap(pictureBoxTimerBrown.Width, pictureBoxTimerBrown.Height), Image)
					g2 = Graphics.FromImage(TimerImage1)
					g2.FillRectangle(New SolidBrush(Color.Brown), New Rectangle(New Point(0, 0), New Size(pictureBoxTimerBrown.Width, pictureBoxTimerBrown.Height)))
					g2.DrawString(BrownTimer.ReturnTime(), New Font("Times New Roman", 30), New SolidBrush(Color.Black), New PointF(5, 5))
					pictureBoxTimerBrown.Image = TimerImage1
					g2.Dispose()
					BrownTimer.TextChanged = False
				Catch t As Exception
					Log(t)
					pictureBoxTimerBrown.Update()
					pictureBoxTimerBrown.Invalidate()
					RunInFront()
				End Try
			End If

			If GrayTimer.EndTime Then
				BrownWiner = True
			End If
			If BrownTimer.EndTime Then
				GrayWinner = True
			End If
			If GrayWinner OrElse BrownWiner Then
				If t1 IsNot Nothing Then
					t1.Abort()
				End If
				If t2 IsNot Nothing Then
					t2.Abort()
				End If
				If t3 IsNot Nothing Then
					t3.Abort()
				End If
				If GrayWinner Then
					SetBoxText(vbCr & vbLf & "Gray Winees!")
				End If
				If BrownWiner Then
					SetBoxText(vbCr & vbLf & "Brown Winees!")
				End If

				Return
			End If
			Try
				If AllDraw.DrawTable Then
					'ReconstructTable();
					pictureBoxRefrigtz.Image = CType(New Bitmap(pictureBoxRefrigtz.Width, pictureBoxRefrigtz.Height), Image)
					ChessTable = CType(New Bitmap(pictureBoxRefrigtz.Image.Width, pictureBoxRefrigtz.Image.Height), Image)
					g = Graphics.FromImage(ChessTable)
					g.FillRectangle(New SolidBrush(Color.Yellow), New Rectangle(0, 0, pictureBoxRefrigtz.Width, pictureBoxRefrigtz.Height))
					Dim a As Color = Color.Gray
					If OrderPlate = -1 Then
						a = Color.Brown
					End If
					Dim Tab As Boolean(,) = Nothing
					If RowClickP <> -1 AndAlso ColumnClickP <> -1 Then
						Tab = VeryFye(Table, OrderPlate, a)
					End If
					Dim i As Integer = 0
					While i < pictureBoxRefrigtz.Image.Width
						Dim j As Integer = 0
						While j < pictureBoxRefrigtz.Image.Height
							Try
								If (i + j) Mod 2 = 0 Then
									g.DrawImage(Image.FromFile(Root + "\Images\Program\Black.jpg"), New Rectangle(i, j, Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))
								Else
									g.DrawImage(Image.FromFile(Root + "\Images\Program\White.jpg"), New Rectangle(i, j, Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))
								End If
								If Tab(i / (pictureBoxRefrigtz.Image.Width / 8), j / (pictureBoxRefrigtz.Image.Height / 8)) Then
									g.DrawString("*", New Font("Times New Roman", 50), New SolidBrush(Color.Red), New Rectangle(i, j, Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))

								End If
							Catch t As Exception
								Log(t)
							End Try
							j += pictureBoxRefrigtz.Image.Height / 8
						End While
						i += pictureBoxRefrigtz.Image.Width / 8
					End While
				End If
				Dim i As Integer = 0
				While i < AllDraw.SodierHigh
					Try
						Draw.SolderesOnTable(i).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
					Catch t As Exception
						Log(t)
					End Try
					i += 1
				End While
				Dim i As Integer = 0
				While i < AllDraw.ElefantHigh
					Try
						Draw.ElephantOnTable(i).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
					Catch t As Exception
						Log(t)
					End Try
					i += 1
				End While
				Dim i As Integer = 0
				While i < AllDraw.HourseHight
					Try
						Draw.HoursesOnTable(i).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
					Catch t As Exception
						Log(t)
					End Try
					i += 1
				End While
				Dim i As Integer = 0
				While i < AllDraw.BridgeHigh
					Try
						Draw.BridgesOnTable(i).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
					Catch t As Exception
						Log(t)

					End Try
					i += 1
				End While


				Dim i As Integer = 0
				While i < AllDraw.MinisterHigh
					Try
						Draw.MinisterOnTable(i).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
					Catch t As Exception
						Log(t)
					End Try
					i += 1
				End While

				Dim i As Integer = 0
				While i < AllDraw.KingHigh
					Try
						Draw.KingOnTable(i).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
					Catch t As Exception
						Log(t)
					End Try
					i += 1
				End While


				pictureBoxRefrigtz.Image = ChessTable
				g.Dispose()

				LoadedTable = True
			Catch t As Exception
				Log(t)
				pictureBoxRefrigtz.Update()
				pictureBoxRefrigtz.Invalidate()
				RunInFront()
			End Try
			'System.Threading.Thread.Sleep(5);
			Return
		End Sub
		Sub Movements()
			Do
				Dim TabStor As Integer(,) = New Integer(8, 8) {}
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						TabStor(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While

				Try
					If (Not StateCC AndAlso StateCP) OrElse Person OrElse Blitz Then
						If Sec.radioButtonGrayOrder.Checked Then
							If ColumnClickP = ColumnRealeased AndAlso System.Math.Abs(RowClickP - RowRealesed) >= 0 AndAlso Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 6 Then


								If AllDraw.MouseClick = 1 Then
									Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										King)

									Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(7, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 7) Then
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnRealeased, Integer)
										CurrentKind = 7
										Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
											King)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0

										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 6

										Dim Bridges As Integer = -1
										If RowClickP < RowRealesed Then
											Table(CType(RowRealesed, Integer) - 1, CType(ColumnRealeased, Integer)) = 4
											Table(CType(RowRealesed, Integer) + 1, CType(ColumnRealeased, Integer)) = 0
											Dim i As Integer = 0
											While i < AllDraw.BridgeHigh
												If Draw.BridgesOnTable(i).Row = RowClickP + 3 AndAlso Draw.BridgesOnTable(i).Column = ColumnClick Then
													Draw.BridgesOnTable(i) = New DrawBridge(RowRealesed + 1, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
														King)
													Bridges = i


													Exit While

												End If
												i += 1
											End While
											If Bridges <> -1 Then
												Draw.BridgesOnTable(Bridges).Row = RowClickP + 3
												Draw.BridgesOnTable(Bridges).Column = ColumnClickP


											End If
										Else
											Table(CType(RowRealesed, Integer) + 1, CType(ColumnRealeased, Integer)) = 4
											Table(CType(RowRealesed, Integer) - 2, CType(ColumnRealeased, Integer)) = 0
											Dim i As Integer = 0
											While i < AllDraw.BridgeHigh
												If Draw.BridgesOnTable(i).Row = RowClickP - 4 AndAlso Draw.BridgesOnTable(i).Column = ColumnClickP Then
													Draw.BridgesOnTable(i) = New DrawBridge(RowRealesed - 1, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
														King)
													Bridges = i

													Exit While

												End If
												i += 1
											End While
											If Bridges <> -1 Then
												Draw.BridgesOnTable(Bridges).Row = RowClickP - 4
												Draw.BridgesOnTable(Bridges).Column = ColumnClickP

											End If
										End If

										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)


										GrayTimer.StopTime()
										BrownTimer.StartTime()

										Person = False
										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										InsertTableAtDataBase(Table)
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												Dim HitVal As Boolean = False
												Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()

										Clicked = False
										'TakeRoot.CalculateRootGray(Draw);
										Return
									Else

										If ColumnClickP = 0 Then
											Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 6
										ElseIf ColumnClickP = 7 Then
											Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -6
										End If
										Draw.KingOnTable(King) = New DrawKing(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											King)
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										MovmentsNumber += 1
										Clicked = False




									End If
								End If
							End If

							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 1 Then
								If AllDraw.MouseClick = 1 Then

									Draw.SolderesOnTable(Soldier) = New DrawSoldier(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										Soldier)
									Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then

									If (New ChessRules(1, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 1) Then
										ThingsConverter.ActOfClickEqualTow = True
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = 1
										Draw.SolderesOnTable(Soldier).ConvertOperation(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, Table, OrderPlate, False, _
											Soldier)
										If Draw.SolderesOnTable(Soldier).Convert Then
											Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
											Dim HitVal As Boolean = False
											If Hit <> 0 Then
												HitVal = True
											End If

											Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
											If Draw.SolderesOnTable(Soldier).ConvertedToMinister Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 5
											ElseIf Draw.SolderesOnTable(Soldier).ConvertedToBridge Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 4
											ElseIf Draw.SolderesOnTable(Soldier).ConvertedToHourse Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 3
											ElseIf Draw.SolderesOnTable(Soldier).ConvertedToElefant Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 2
											End If

											Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Else
											Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
											Dim HitVal As Boolean = False
											If Hit <> 0 Then
												HitVal = True
											End If

											Draw.SolderesOnTable(Soldier) = New DrawSoldier(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
												Soldier)
											Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
											Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 1
											Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										End If

										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Person = False
										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												Dim HitVal As Boolean = False
												Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Draw.SolderesOnTable(Soldier) = New DrawSoldier(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											Soldier)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 1
										Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False


									End If


								End If
							End If

							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 2 Then
								If AllDraw.MouseClick = 1 Then
									Draw.ElephantOnTable(Elefant) = New DrawElefant(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										Elefant)
									Draw.ElephantOnTable(Elefant).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(2, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 2) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = 2
										Draw.ElephantOnTable(Elefant) = New DrawElefant(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
											Elefant)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 2
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.ElephantOnTable(Elefant).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Person = False
										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 2
										Draw.ElephantOnTable(Elefant) = New DrawElefant(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											Elefant)
										Draw.ElephantOnTable(Elefant).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False
									End If


								End If
							End If

							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 3 Then


								If AllDraw.MouseClick = 1 Then
									Draw.HoursesOnTable(Hourse) = New DrawHourse(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										Hourse)
									Draw.HoursesOnTable(Hourse).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(3, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 3) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = 3
										Draw.HoursesOnTable(Hourse) = New DrawHourse(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
											Hourse)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 3
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.HoursesOnTable(Hourse).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 3
										Draw.HoursesOnTable(Hourse) = New DrawHourse(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											Hourse)
										Draw.HoursesOnTable(Hourse).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Clicked = False


									End If


								End If
							End If

							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 4 Then


								If AllDraw.MouseClick = 1 Then
									Draw.BridgesOnTable(Bridge) = New DrawBridge(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										Bridge)
									Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(4, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 4) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = 4
										Draw.BridgesOnTable(Bridge) = New DrawBridge(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
											Bridge)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 4
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 4
										Draw.BridgesOnTable(Bridge) = New DrawBridge(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											Bridge)
										Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False
									End If


								End If
							End If


							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 5 Then


								If AllDraw.MouseClick = 1 Then
									Draw.MinisterOnTable(Minister) = New DrawMinister(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										Minister)

									Draw.MinisterOnTable(Minister).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then

									If (New ChessRules(5, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 5) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = 5
										Draw.MinisterOnTable(Minister) = New DrawMinister(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
											Minister)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 5
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.MinisterOnTable(Minister).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 5
										Draw.MinisterOnTable(Minister) = New DrawMinister(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											Minister)
										Draw.MinisterOnTable(Minister).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False

									End If


								End If
							End If

							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 6 Then


								If AllDraw.MouseClick = 1 Then
									Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
										King)

									Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(6, Table, 1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, 6) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = 6
										Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Gray, Table, OrderPlate, False, _
											King)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = 6
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										GrayTimer.StopTime()
										BrownTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else


										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 6
										Draw.KingOnTable(King) = New DrawKing(RowClickP, ColumnClickP, Color.Gray, Table, OrderPlate, False, _
											King)
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False

									End If


								End If
							End If
						End If


						If Sec.radioButtonBrownOrder.Checked Then
							If ColumnRealeased = ColumnClickP AndAlso System.Math.Abs(RowClickP - RowClickP) > 1 AndAlso Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -6 Then


								If AllDraw.MouseClick = 1 Then
									Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										King)

										'Table[(int)RowClickP, (int)ColumnClickP] = -6;
									Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-7, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -7) Then
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -7
										Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
											King)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -6
										If RowClickP > RowRealesed Then
											Table(CType(RowRealesed, Integer) - 1, CType(ColumnRealeased, Integer)) = 4
											Dim i As Integer = 0
											While i < 4
												If Draw.BridgesOnTable(i).Row = RowRealesed AndAlso Draw.BridgesOnTable(i).Column = ColumnRealeased Then
													Draw.BridgesOnTable(i) = New DrawBridge(RowRealesed + 1, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
														King)

													Exit While

												End If
												i += 1
											End While
										Else

											Table(CType(RowRealesed, Integer) + 1, CType(ColumnRealeased, Integer)) = 4
											Dim i As Integer = 0
											While i < 4
												If Draw.BridgesOnTable(i).Row = RowRealesed AndAlso Draw.BridgesOnTable(i).Column = ColumnRealeased Then
													Draw.BridgesOnTable(i) = New DrawBridge(RowRealesed - 1, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
														King)

													Exit While

												End If
												i += 1
											End While
										End If

										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)


										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												Dim HitVal As Boolean = False
												Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else


										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -6
										Draw.KingOnTable(King) = New DrawKing(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											King)
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False


									End If


								End If
							End If
							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -1 Then

								If AllDraw.MouseClick = 1 Then
									Draw.SolderesOnTable(Soldier) = New DrawSoldier(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										Soldier)

									Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-1, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -1) Then
										ThingsConverter.ActOfClickEqualTow = True
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -1
										Draw.SolderesOnTable(Soldier).ConvertOperation(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Gray, Table, OrderPlate, False, _
											Soldier)
										If Draw.SolderesOnTable(Soldier).Convert Then
											Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
											Dim HitVal As Boolean = False
											If Hit <> 0 Then
												HitVal = True
											End If

											Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
											If Draw.SolderesOnTable(Soldier).ConvertedToMinister Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -5
											ElseIf Draw.SolderesOnTable(Soldier).ConvertedToBridge Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -4
											ElseIf Draw.SolderesOnTable(Soldier).ConvertedToHourse Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -3
											ElseIf Draw.SolderesOnTable(Soldier).ConvertedToElefant Then
												Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -2
											End If

											Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Else
											Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
											Dim HitVal As Boolean = False
											If Hit <> 0 Then
												HitVal = True
											End If

											Draw.SolderesOnTable(Soldier) = New DrawSoldier(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
												Soldier)
											Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
											Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -1
										End If
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												Dim HitVal As Boolean = False
												Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -1
										Draw.SolderesOnTable(Soldier) = New DrawSoldier(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											Soldier)
										Draw.SolderesOnTable(Soldier).DrawSoldierOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False

									End If


								End If
							End If
							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -2 Then
								If AllDraw.MouseClick = 1 Then
									Draw.ElephantOnTable(Elefant) = New DrawElefant(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										Elefant)
									Draw.ElephantOnTable(Elefant).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-2, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -2) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -2
										Draw.ElephantOnTable(Elefant) = New DrawElefant(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
											Elefant)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -2
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.ElephantOnTable(Elefant).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -2
										Draw.ElephantOnTable(Elefant) = New DrawElefant(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											Elefant)
										Draw.ElephantOnTable(Elefant).DrawElefantOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False

									End If


								End If
							End If

							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -3 Then

								If AllDraw.MouseClick = 1 Then
									Draw.HoursesOnTable(Hourse) = New DrawHourse(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										Hourse)

									Draw.HoursesOnTable(Hourse).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-3, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -3) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -3
										Draw.HoursesOnTable(Hourse) = New DrawHourse(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
											Hourse)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -3
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.HoursesOnTable(Hourse).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -3
										Draw.HoursesOnTable(Hourse) = New DrawHourse(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											Hourse)
										Draw.HoursesOnTable(Hourse).DrawHourseOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False
									End If


								End If
							End If
							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -4 Then


								If AllDraw.MouseClick = 1 Then
									Draw.BridgesOnTable(Bridge) = New DrawBridge(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										Bridge)

									Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-4, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -4) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -4
										Draw.BridgesOnTable(Bridge) = New DrawBridge(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
											Bridge)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -4
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else

										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -4
										Draw.BridgesOnTable(Bridge) = New DrawBridge(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											Bridge)
										Draw.BridgesOnTable(Bridge).DrawBridgeOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False

									End If


								End If
							End If
							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -5 Then


								If AllDraw.MouseClick = 1 Then
									Draw.MinisterOnTable(Minister) = New DrawMinister(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										Minister)

									Draw.MinisterOnTable(Minister).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-5, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -5) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -5
										Draw.MinisterOnTable(Minister) = New DrawMinister(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
											Minister)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -5
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.MinisterOnTable(Minister).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)

										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										'TakeRoot.CalculateRootGray(Draw);
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1
										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False

										Return
									Else
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -5
										Draw.MinisterOnTable(Minister) = New DrawMinister(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											Minister)

										Draw.MinisterOnTable(Minister).DrawMinisterOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False



									End If


								End If
							End If
							If Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -6 Then


								If AllDraw.MouseClick = 1 Then
									Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
										King)

									Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
								ElseIf AllDraw.MouseClick = 2 Then
									If (New ChessRules(-6, Table, -1, CType(RowClickP, Integer), CType(ColumnClickP, Integer))).Rules(CType(RowClickP, Integer), CType(ColumnClickP, Integer), CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Color.Brown, -6) Then
										Dim Hit As Integer = Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer))
										Dim HitVal As Boolean = False
										If Hit <> 0 Then
											HitVal = True
										End If
										LastRow = CType(RowRealesed, Integer)
										LastColumn = CType(ColumnClickP, Integer)
										CurrentKind = -6
										Draw.KingOnTable(King) = New DrawKing(RowRealesed, ColumnRealeased, Color.Brown, Table, OrderPlate, False, _
											King)
										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
										Table(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer)) = -6
										If (New ChessRules(1, Table, OrderPlate, -1, -1).Kish(Table, OrderPlate)) Then
											If ChessRules.KishGray AndAlso OrderPlate = 1 Then
												Table = TabStor
												Return

											ElseIf ChessRules.KishBrown AndAlso OrderPlate = -1 Then
												Table = TabStor
												Return
											End If
										End If
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)


										Dim TableCon As Integer(,) = New Integer(8, 8) {}
										Dim i As Integer = 0
										While i < 8
											Dim j As Integer = 0
											While j < 8
												TableCon(i, j) = Table(i, j)
												j += 1
											End While
											i += 1
										End While
										AllDraw.TableListAction.Add(TableCon)
										Person = False
										If AllDraw.DeptFirstSearch AndAlso AllDraw.StoreADraw.Count > 0 Then
											AllDraw.StoreADraw.RemoveAt(0)
											AllDraw.StoreADraw(0).TableList.Clear()
											AllDraw.StoreADraw(0).TableList.Add(Table)
											AllDraw.StoreADraw(0).SetRowColumn(0)
										End If
										If AllDraw.TableListAction.Count > 1 Then
											Dim R As New ChessGeneticAlgorithm()
											If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
												HitVal = False
												Hit = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
												If Hit <> 0 Then
													HitVal = True
												End If
												Dim Convert As Boolean = False
												If OrderPlate = 1 Then
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
														If R.CromosomColumn = 7 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
														ChessRules.BridgeActGray = True
													End If
													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActGray, Convert)
												Else
													If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
														If R.CromosomColumn = 0 Then
															Convert = True
														End If
													End If
													If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
														ChessRules.BridgeActBrown = True
													End If

													AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
														Hit, ChessRules.BridgeActBrown, Convert)
												End If
												SetBoxStatistic(AllDraw.SyntaxToWrite)
												RefreshBoxStatistic()
											End If
										End If
										OrderPlate = OrderPlate * -1
										ChessRules.CurrentOrder = OrderPlate
										MovmentsNumber += 1

										BrownTimer.StopTime()
										GrayTimer.StartTime()
										InsertTableAtDataBase(Table)
										Clicked = False
										Return
									Else


										Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = -6
										Draw.KingOnTable(King) = New DrawKing(RowClickP, ColumnClickP, Color.Brown, Table, OrderPlate, False, _
											King)
										Draw.KingOnTable(King).DrawKingOnTable(g, pictureBoxRefrigtz.Image.Width / 8, pictureBoxRefrigtz.Image.Height / 8)
										Clicked = False


									End If


								End If

							End If

						End If

					End If
				Catch T As Exception
					Log(T)
				End Try


				ChessRules.CurrentOrder = OrderPlate

			Loop While True
		End Sub
		Sub Wait()
			Do
				Thread.Sleep(100)
			Loop While Clicked
		End Sub
		'All Operation of Thinking Handling.
		Sub AllOperations()
			Do
				AllDraw.SyntaxToWrite = ""
				Try


					If ChessGeneticAlgorithm.NoGameFounf Then
						SetBoxText("No Game Could be continued!")

						RefreshBoxText()
					End If
					If AllDraw.MouseClick = 0 AndAlso Not ThinkingChess.ThinkingRun Then
						If (New ChessRules(1, Table, OrderPlate, -1, -1)).Mate(Table, OrderPlate) Then
							If ChessRules.MateGray OrElse ChessRules.MateBrown OrElse EndOfGame Then
								StateCC = False
								StateCP = False
								Person = False
								SetBoxText(vbCr & vbLf & "Mate!")
								RefreshBoxText()
								If AllOperate.IsAlive Then
									Syncronization(AllOperate, 1)




								End If
							Else
								If ChessRules.MateGray AndAlso OrderPlate = 1 Then


									If ChessRules.KishGray OrElse ChessRules.KishBrown Then
										If OrderPlate = 1 Then

											SetBoxText(vbCr & vbLf & "Gray OrderPlate!Kish!")
										Else
											SetBoxText(vbCr & vbLf & "Brown OrderPlate!Kish!")


										End If
									End If
								End If
							End If
						End If
					End If

					If ((Not StateCC OrElse StateCP) OrElse Person OrElse Blitz) Then


						Try
							Dim a As Color = Color.Gray
							If OrderPlate = -1 Then
								a = Color.Brown
							End If
							Dim Tab As Boolean(,) = Nothing
							If RowClickP <> -1 AndAlso ColumnClickP <> -1 Then
								Tab = VeryFye(Table, OrderPlate, a)
							End If
							If (RowRealesed + ColumnRealeased) Mod 2 = 0 Then
								g.DrawImage(Image.FromFile(Root + "\Images\Program\Black.jpg"), New Rectangle(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))
							Else
								g.DrawImage(Image.FromFile(Root + "\Images\Program\White.jpg"), New Rectangle(CType(RowRealesed, Integer), CType(ColumnRealeased, Integer), Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))

							End If
						Catch t As Exception
							RunInFront()
							Log(t)
						End Try

						Dim [Or] As Integer = 1
						If Sec.radioButtonBrownOrder.Checked Then
							[Or] = -1
						End If
						If (StateCP OrElse Blitz) AndAlso (OrderPlate = [Or]) Then


							If True Then
								If tM Is Nothing Then
									tM = New Thread(New ThreadStart(Movements))
								End If
								If Not tM.IsAlive Then
									tM.Start()
								End If
								Wait()
								Clicked = True
								pictureBoxRefrigtz.Invalidate()
								pictureBoxRefrigtz.Update()
							End If
						Else
							If tM IsNot Nothing Then
								Try
									tM.Abort()
									tM.Join()
									tM = Nothing
								Catch t As Exception
									Log(t)
								End Try
							End If
							If (StateCP AndAlso Not Person) OrElse Blitz Then
								If Sec.radioButtonGrayOrder.Checked AndAlso OrderPlate = -1 Then
									Person = True
									If t1.IsAlive AndAlso t1.IsBackground Then
										Syncronization(t1, 3)
									ElseIf Not t1.IsAlive Then
										t1 = New Thread(New ThreadStart(AliceWithPerson))
										t1.Start()
									Else
										Thread.Sleep(1000)
									End If
									pictureBoxRefrigtz.Invalidate()

									pictureBoxRefrigtz.Update()
								ElseIf Sec.radioButtonBrownOrder.Checked AndAlso OrderPlate = 1 Then
									Person = True
									If t1.IsAlive AndAlso t1.IsBackground Then
										Syncronization(t1, 3)
									ElseIf Not t1.IsAlive Then
										If t1 IsNot Nothing Then
											t1.Abort()
										End If

										t1 = New Thread(New ThreadStart(BobWithPerson))
										t1.Start()
									Else
										Thread.Sleep(1000)
									End If

									pictureBoxRefrigtz.Invalidate()

									pictureBoxRefrigtz.Update()
								End If
							End If
						End If

						If StateCC Then
							If BobSection Then
								If t3.IsAlive Then
									Syncronization(t3, 1)
								End If
								

								BobSection = False
								If t2.IsAlive AndAlso t2.IsBackground Then
									Syncronization(t2, 3)
								ElseIf Not t2.IsAlive Then
									If t2 IsNot Nothing Then
										t2.Abort()
									End If
									t2 = New Thread(New ThreadStart(BobAction))

									t2.Start()
								Else
									Thread.Sleep(1000)
								End If
								pictureBoxRefrigtz.Invalidate()

								pictureBoxRefrigtz.Update()
							Else
								If AliceSection Then
									If t2.IsAlive Then
										Syncronization(t2, 1)
									End If
									

									AliceSection = False
									If t3.IsAlive AndAlso t3.IsBackground Then
										Syncronization(t3, 3)
									ElseIf Not t3.IsAlive Then
										If t3 IsNot Nothing Then
											t3.Abort()
										End If
										t3 = New Thread(New ThreadStart(AliceAction))
										t3.Start()
									Else
										Thread.Sleep(1000)
									End If

									pictureBoxRefrigtz.Invalidate()
									pictureBoxRefrigtz.Update()
								End If
							End If
						ElseIf StateGe Then
							If t4.IsAlive AndAlso t4.IsBackground Then
								Syncronization(t4, 3)
							ElseIf Not t4.IsAlive Then
								If t4 IsNot Nothing Then
									t4.Abort()
								End If
								t4 = New Thread(New ThreadStart(GeneticAction))
								t4.Start()
							Else
								Thread.Sleep(1000)
							End If
							pictureBoxRefrigtz.Invalidate()

							pictureBoxRefrigtz.Update()
						End If



						While (Not StateCP AndAlso Not StateCC AndAlso Not StateGe AndAlso Not Blitz)
							Thread.Sleep(1)
						End While
					End If
					If True Then


						If AllDraw.MouseClick = 0 AndAlso RowClickP <> -1 Then

							HitRecustruct()
							ChessRules.CurrentOrder = OrderPlate
							ChessRules.ExistInDestinationEnemy = False
							RowClick = -1
							ColumnClick = -1
							RowClickP = -1
							ColumnClickP = -1
							RowRealesed = -1
							ColumnRealeased = -1
							RowRealesedP = -1

							ColumnClickP = -1
						Else
							If AllDraw.MouseClick >= 2 Then

								Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
									soundClick.Play()
									soundClick.Dispose()
								End Using

								AllDraw.MouseClick = 0
								SetBoxText(vbCr & vbLf & "Object Realeased.")


								RefreshBoxText()
							End If
						End If


						AllDraw.RedrawTable = False
					End If
					If AllDraw.MouseClick = 1 Then
						SetBoxText(vbCr & vbLf & "Object Selected.")
						RefreshBoxText()
					End If
				Catch t As Exception
					Log(t)
				End Try
			Loop While True

		End Sub
		'Deligation of Control Threading.
		Delegate Sub SetTextBoxTextCallback(state As [String])

		Public Sub SetBoxText(state As [String])
			' InvokeRequired required compares the thread ID of the
			' calling thread to the thread ID of the creating thread.
			' If these threads are different, it returns true.
			If Me.InvokeRequired Then
				Try
					Dim A As [String] = TimerText.ReturnTime()
					If OrderPlate = -1 Then
						A = TimerText.ReturnTime()
					End If

					Dim d As New SetTextBoxTextCallback(SetBoxText)
					Me.Invoke(New Action(Function() textBoxText.AppendText(state + " At Time " + A)))
					File.AppendAllText(Root + "\Database\Monitor.txt", vbLf & vbTab + state + " At Time " + A)
				Catch t As Exception
					Log(t)
				End Try
			Else
				Try
					Dim A As [String] = GrayTimer.ReturnTime()
					If OrderPlate = -1 Then
						A = BrownTimer.ReturnTime()
					End If

					textBoxText.AppendText(state + " At Time " + A)
				Catch t As Exception
					Log(t)
				End Try
			End If
			Me.RefreshBoxText()
		End Sub
		Delegate Sub RefreshhTextBoxTextCallback()

		Public Sub RefreshBoxText()
			' InvokeRequired required compares the thread ID of the
			' calling thread to the thread ID of the creating thread.
			' If these threads are different, it returns true.
			If Me.InvokeRequired Then
				Try
					Dim d As New RefreshhTextBoxTextCallback(RefreshBoxText)
					Me.Invoke(New Action(Function() textBoxText.Refresh()))
				Catch t As Exception
					Log(t)
				End Try
			Else
				Try
					textBoxStatistic.Refresh()
				Catch t As Exception
					Log(t)
				End Try
			End If

		End Sub
		Delegate Sub SetTextBoxStatisticCallback(state As [String])

		Public Sub SetBoxStatistic(state As [String])
			' InvokeRequired required compares the thread ID of the
			' calling thread to the thread ID of the creating thread.
			' If these threads are different, it returns true.
			If Me.InvokeRequired Then
				Try
					Dim d As New SetTextBoxStatisticCallback(SetBoxStatistic)
					Me.Invoke(New Action(Function() textBoxStatistic.AppendText(state)))
				Catch t As Exception
					Log(t)
				End Try
			Else
				Try

					textBoxStatistic.AppendText(state)
				Catch t As Exception
					Log(t)
				End Try
			End If
			Me.RefreshBoxStatistic()
		End Sub
		Delegate Sub RefreshhTextBoxStatisticCallback()

		Public Sub RefreshBoxStatistic()
			' InvokeRequired required compares the thread ID of the
			' calling thread to the thread ID of the creating thread.
			' If these threads are different, it returns true.
			If Me.InvokeRequired Then
				Dim d As New RefreshhTextBoxStatisticCallback(RefreshBoxStatistic)

				Me.Invoke(New Action(Function() textBoxStatistic.Refresh()))
			Else
				textBoxStatistic.Refresh()
			End If

		End Sub
		'The State of Alice with Person Thinking.
		Sub AliceWithPerson()
			ThinkingChess.ThinkingRun = True

			Try
				Begin1:
				Dim StoreStateCC As Boolean = StateCC
				Dim StoreStateCP As Boolean = StateCP
				Dim StoreStateGe As Boolean = StateGe
				StateCC = False
				StateCP = False
				StateGe = False

				MovmentsNumber += 1

				SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Brown OrderPlate!")
				RefreshBoxText()

				SetBoxText(vbCr & vbLf & "Thinking Begin!")
				RefreshBoxText()
				Dim a As Color = Color.Gray
				If OrderPlate = -1 Then
					a = Color.Brown
				End If
				Draw.Initiate(1, 4, a, Table, OrderPlate, False, _
					TimerText, BrownTimer)
				Me.SetBoxText(vbCr & vbLf & "Thinking Finished!")
				Try
					Table = Draw.TableList(0)
					If Not TableZero(Table) Then
						System.IO.File.AppendAllText("CheckSum.btt", vbLf & vbTab & "Installation Begine On " + DateTime.Now.ToString())
						Dim FolderLocation As [String] = Root
						Dim exitCode As Integer = 0

						' Prepare the process to run
						Dim start As New ProcessStartInfo()
						' Prepare the process to run
						' Enter in the command line arguments, everything you would enter after the executable name itself
						start.Arguments = ""
						' Enter the executable to run, including the complete path
						start.FileName = """" + FolderLocation + "\" + "LoadRP.exe" + """"
						' Do you want to show a console window?
						start.WindowStyle = ProcessWindowStyle.Normal
						start.CreateNoWindow = True
						start.UseShellExecute = True

						' Run the external process & wait for it to finish
						Using proc As Process = Process.Start(start)
							proc.WaitForExit(20000)
							' Retrieve the app's exit code
							exitCode = proc.ExitCode
						End Using
						Application.[Exit]()

					End If
				Catch t As Exception
					Log(t)
					GoTo Begin1
				End Try

				OrderPlate = OrderPlate * -1
				Draw.SetRowColumn(0)
				ChessRules.CurrentOrder = OrderPlate
				Dim TableCon As Integer(,) = New Integer(8, 8) {}
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						TableCon(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While
				AllDraw.TableListAction.Add(TableCon)
				If AllDraw.TableListAction.Count > 1 Then
					Dim R As New ChessGeneticAlgorithm()
					If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
						Dim HitVal As Boolean = False
						Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
						If Hit <> 0 Then
							HitVal = True
						End If
						Dim Convert As Boolean = False
						If OrderPlate = 1 Then
							If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
								If R.CromosomColumn = 7 Then
									Convert = True
								End If
							End If
							If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
								ChessRules.BridgeActGray = True
							End If
							AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
								Hit, ChessRules.BridgeActGray, Convert)
						Else
							If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
								If R.CromosomColumn = 0 Then
									Convert = True
								End If
							End If
							If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
								ChessRules.BridgeActBrown = True
							End If

							AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
								Hit, ChessRules.BridgeActBrown, Convert)
						End If
						SetBoxStatistic(AllDraw.SyntaxToWrite)
						RefreshBoxStatistic()
					End If
				End If

				BrownTimer.StopTime()
				GrayTimer.StartTime()

				Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
					soundClick.Play()
					soundClick.Dispose()
				End Using

				InsertTableAtDataBase(Table)
				Person = True
				StateCC = StoreStateCC
				StateCP = StoreStateCP
				StateGe = StoreStateGe

				ThinkingChess.ThinkingRun = False
			Catch t As Exception
				Log(t)
				Me.SetBoxText(vbCr & vbLf & "Error!")
			End Try
		End Sub
		'The State of Bob with Person Thinking.
		Sub BobWithPerson()
			ThinkingChess.ThinkingRun = True
			Try
				Begin1:
				Dim StoreStateCC As Boolean = StateCC
				Dim StoreStateCP As Boolean = StateCP
				Dim StoreStateGe As Boolean = StateGe
				StateCC = False
				StateCP = False
				StateGe = False

				MovmentsNumber += 1

				SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Gray OrderPlate!")
				RefreshBoxText()

				SetBoxText(vbCr & vbLf & "Thinking Begin!")
				RefreshBoxText()
				Dim a As Color = Color.Gray
				If OrderPlate = -1 Then
					a = Color.Brown
				End If
				Draw.Initiate(1, 4, a, Table, OrderPlate, False, _
					TimerText, GrayTimer)
				Me.SetBoxText(vbCr & vbLf & "Thinking Finished!")
				Try
					Table = Draw.TableList(0)
					If Not TableZero(Table) Then
						System.IO.File.AppendAllText("CheckSum.btt", vbLf & vbTab & "Installation Begine On " + DateTime.Now.ToString())
						Dim FolderLocation As [String] = Root
						Dim exitCode As Integer = 0

						' Prepare the process to run
						Dim start As New ProcessStartInfo()
						' Prepare the process to run
						' Enter in the command line arguments, everything you would enter after the executable name itself
						start.Arguments = ""
						' Enter the executable to run, including the complete path
						start.FileName = """" + FolderLocation + "\" + "LoadRP.exe" + """"
						' Do you want to show a console window?
						start.WindowStyle = ProcessWindowStyle.Normal
						start.CreateNoWindow = True
						start.UseShellExecute = True

						' Run the external process & wait for it to finish
						Using proc As Process = Process.Start(start)
							proc.WaitForExit(20000)
							' Retrieve the app's exit code
							exitCode = proc.ExitCode
						End Using
						Application.[Exit]()


					End If
				Catch t As Exception
					Log(t)
					GoTo Begin1
				End Try

				OrderPlate = OrderPlate * -1
				Draw.SetRowColumn(0)
				ChessRules.CurrentOrder = OrderPlate
				Dim TableCon As Integer(,) = New Integer(8, 8) {}
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						TableCon(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While
				AllDraw.TableListAction.Add(TableCon)
				If AllDraw.TableListAction.Count > 1 Then
					Dim R As New ChessGeneticAlgorithm()
					If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
						Dim HitVal As Boolean = False
						Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
						If Hit <> 0 Then
							HitVal = True
						End If
						Dim Convert As Boolean = False
						If OrderPlate = 1 Then
							If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
								If R.CromosomColumn = 7 Then
									Convert = True
								End If
							End If
							If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
								ChessRules.BridgeActGray = True
							End If
							AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
								Hit, ChessRules.BridgeActGray, Convert)
						Else
							If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
								If R.CromosomColumn = 0 Then
									Convert = True
								End If
							End If
							If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
								ChessRules.BridgeActBrown = True
							End If

							AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
								Hit, ChessRules.BridgeActBrown, Convert)
						End If
						SetBoxStatistic(AllDraw.SyntaxToWrite)
						RefreshBoxStatistic()
					End If
				End If

				GrayTimer.StartTime()
				BrownTimer.StopTime()

				Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
					soundClick.Play()
					soundClick.Dispose()
				End Using

				InsertTableAtDataBase(Table)
				Person = True
				StateCC = StoreStateCC
				StateCP = StoreStateCP
				StateGe = StoreStateGe

				ThinkingChess.ThinkingRun = False
			Catch t As Exception
				Log(t)
				Me.SetBoxText(vbCr & vbLf & "Error!")
			End Try
		End Sub
		Function TableZero(Ta As Integer(,)) As Boolean
			Dim NotZerro As Boolean = False
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8L
					If Ta(i, j) <> 0 Then
						NotZerro = True
					End If
					j += 1
				End While
				i += 1
			End While
			Return NotZerro
		End Function
		'Alice Section of Computer by Computer Thinking.
		Sub AliceAction()
			ThinkingChess.ThinkingRun = True
			Begin4:
			Dim StoreStateCC As Boolean = StateCC
			Dim StoreStateCP As Boolean = StateCP
			Dim StoreStateGe As Boolean = StateGe
			StateCC = False
			StateCP = False
			StateGe = False

			MovmentsNumber += 1


			SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Brown OrderPlate!")
			RefreshBoxText()

			SetBoxText(vbCr & vbLf & "Thinking Begin By Alice!")
			RefreshBoxText()
			RefreshBoxText()
			Dim a As Color = Color.Gray
			If OrderPlate = -1 Then
				a = Color.Brown
			End If

			Draw.Initiate(1, 4, a, Table, OrderPlate, False, _
				TimerText, BrownTimer)
			'StateCP = false;
			Try
				Table = Draw.TableList(0)
				If Not TableZero(Table) Then
					System.IO.File.AppendAllText("CheckSum.btt", vbLf & vbTab & "Installation Begine On " + DateTime.Now.ToString())
					Dim FolderLocation As [String] = Root
					Dim exitCode As Integer = 0

					' Prepare the process to run
					Dim start As New ProcessStartInfo()
					' Prepare the process to run
					' Enter in the command line arguments, everything you would enter after the executable name itself
					start.Arguments = ""
					' Enter the executable to run, including the complete path
					start.FileName = """" + FolderLocation + "\" + "LoadRP.exe" + """"
					' Do you want to show a console window?
					start.WindowStyle = ProcessWindowStyle.Normal
					start.CreateNoWindow = True
					start.UseShellExecute = True

					' Run the external process & wait for it to finish
					Using proc As Process = Process.Start(start)
						proc.WaitForExit(20000)
						' Retrieve the app's exit code
						exitCode = proc.ExitCode
					End Using
					Application.[Exit]()

				End If
			Catch t As Exception
				Log(t)
				GoTo Begin4
			End Try
			' Person = true;
			Dim TableCon As Integer(,) = New Integer(8, 8) {}
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					TableCon(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While
			AllDraw.TableListAction.Add(TableCon)
			OrderPlate = OrderPlate * -1
			Draw.SetRowColumn(0)
			ChessRules.CurrentOrder = OrderPlate

			Me.SetBoxText(vbCr & vbLf & "Thinking Finished By Alice!")
			RefreshBoxText()
			If AllDraw.TableListAction.Count > 1 Then
				Dim R As New ChessGeneticAlgorithm()
				If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
					Dim HitVal As Boolean = False
					Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
					If Hit <> 0 Then
						HitVal = True
					End If
					Dim Convert As Boolean = False
					If OrderPlate = 1 Then
						If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
							If R.CromosomColumn = 7 Then
								Convert = True
							End If
						End If
						If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
							ChessRules.BridgeActGray = True
						End If
						AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
							Hit, ChessRules.BridgeActGray, Convert)
					Else
						If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
							If R.CromosomColumn = 0 Then
								Convert = True
							End If
						End If
						If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
							ChessRules.BridgeActBrown = True
						End If

						AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
							Hit, ChessRules.BridgeActBrown, Convert)
					End If
					SetBoxStatistic(AllDraw.SyntaxToWrite)
					RefreshBoxStatistic()
				End If
			End If
			BrownTimer.StopTime()
			GrayTimer.StartTime()

			Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
				soundClick.Play()
				soundClick.Dispose()
			End Using

			InsertTableAtDataBase(Table)
			BobSection = True
			StateCC = StoreStateCC
			StateCP = StoreStateCP
			StateGe = StoreStateGe

			ThinkingChess.ThinkingRun = False
		End Sub
		Sub GeneticAction()

			ThinkingChess.ThinkingRun = True
			StateGe = False
			MovmentsNumber += 1


			If OrderPlate = 1 Then

				SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Gray OrderPlate!")
			Else
				SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Brown OrderPlate!")
			End If
			RefreshBoxText()
			Begin4:
			If OrderPlate = 1 Then
				SetBoxText(vbCr & vbLf & "Thinking Begin By Bob!")
			Else
				SetBoxText(vbCr & vbLf & "Thinking Begin By Alice!")
			End If
			RefreshBoxText()
			Dim a As Color = Color.Gray
			If OrderPlate = -1 Then
				a = Color.Brown
			End If
			Draw.InitiateGenetic(1, 4, a, Table, OrderPlate, False)

			Try
				Table = Draw.TableList(0)
			Catch t As Exception
				Log(t)
				GoTo Begin4
			End Try

			AllDraw.TableListAction.Add(Table)
			OrderPlate = OrderPlate * -1
			Draw.SetRowColumn(0)

			ChessRules.CurrentOrder = OrderPlate

			Me.SetBoxText(vbCr & vbLf & "Thinking Finished By Alice!")
			RefreshBoxText()
			AllDraw.TableListAction.Add(Table)
			If AllDraw.TableListAction.Count >= 1 Then
				Dim R As New ChessGeneticAlgorithm()
				If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
					Dim HitVal As Boolean = False
					Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
					If Hit <> 0 Then
						HitVal = True
					End If
					Dim Convert As Boolean = False
					If OrderPlate = 1 Then
						If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
							If R.CromosomColumn = 7 Then
								Convert = True
							End If
						End If
						If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
							ChessRules.BridgeActGray = True
						End If
						AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
							Hit, ChessRules.BridgeActGray, Convert)
					Else
						If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
							If R.CromosomColumn = 0 Then
								Convert = True
							End If
						End If
						If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
							ChessRules.BridgeActBrown = True
						End If

						AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
							Hit, ChessRules.BridgeActBrown, Convert)
					End If
					SetBoxStatistic(AllDraw.SyntaxToWrite)
					RefreshBoxStatistic()
				End If
			End If
			If OrderPlate = 1 Then
				BrownTimer.StopTime()
				GrayTimer.StartTime()
			Else
				GrayTimer.StopTime()

				BrownTimer.StartTime()
			End If

			Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
				soundClick.Play()
				soundClick.Dispose()
			End Using

			StateGe = True
			InsertTableAtDataBase(Table)
			ThinkingChess.ThinkingRun = False
			If t4.IsAlive Then
				Syncronization(t4, 1)
			End If
			

		End Sub
		'Bob Section of Computer By Computer Thinking.
		Sub BobAction()
			ThinkingChess.ThinkingRun = True
			Begin2:
			Dim StoreStateCC As Boolean = StateCC
			Dim StoreStateCP As Boolean = StateCP
			Dim StoreStateGe As Boolean = StateGe
			StateCC = False
			StateCP = False
			StateGe = False


			MovmentsNumber += 1
			If OrderPlate = 1 Then

				SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Gray OrderPlate!")
			Else
				SetBoxText(vbCr & vbLf & " Movments Number " + MovmentsNumber.ToString() + " is Brown OrderPlate!")
			End If
			RefreshBoxText()

			SetBoxText(vbCr & vbLf & "Thinking Begin By Bob!")
			RefreshBoxText()
			Dim a As Color = Color.Gray
			If OrderPlate = -1 Then
				a = Color.Brown
			End If
			Draw.Initiate(1, 4, a, Table, OrderPlate, False, _
				TimerText, GrayTimer)




			Try
				Table = Draw.TableList(0)
				If Not TableZero(Table) Then
					System.IO.File.AppendAllText("CheckSum.btt", vbLf & vbTab & "Installation Begine On " + DateTime.Now.ToString())
					Dim FolderLocation As [String] = Root
					Dim exitCode As Integer = 0

					' Prepare the process to run
					Dim start As New ProcessStartInfo()
					' Prepare the process to run
					' Enter in the command line arguments, everything you would enter after the executable name itself
					start.Arguments = ""
					' Enter the executable to run, including the complete path
					start.FileName = """" + FolderLocation + "\" + "LoadRP.exe" + """"
					' Do you want to show a console window?
					start.WindowStyle = ProcessWindowStyle.Normal
					start.CreateNoWindow = True
					start.UseShellExecute = True

					' Run the external process & wait for it to finish
					Using proc As Process = Process.Start(start)
						proc.WaitForExit(20000)
						' Retrieve the app's exit code
						exitCode = proc.ExitCode
					End Using
					Application.[Exit]()


				End If
			Catch t As Exception
				Log(t)
				GoTo Begin2
			End Try
			Dim TableCon As Integer(,) = New Integer(8, 8) {}
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					TableCon(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While
			AllDraw.TableListAction.Add(TableCon)
			OrderPlate = OrderPlate * -1
			Draw.SetRowColumn(0)
			ChessRules.CurrentOrder = OrderPlate

			Me.SetBoxText(vbCr & vbLf & "Thinking Finished by Bob!")
			RefreshBoxText()

			If AllDraw.TableListAction.Count >= 1 Then
				Dim R As New ChessGeneticAlgorithm()
				If R.FindGenToModified(AllDraw.TableListAction(AllDraw.TableListAction.Count - 2), AllDraw.TableListAction(AllDraw.TableListAction.Count - 1), AllDraw.TableListAction, 0, OrderPlate, True) Then
					Dim HitVal As Boolean = False
					Dim Hit As Integer = AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRow, R.CromosomColumn)
					If Hit <> 0 Then
						HitVal = True
					End If
					Dim Convert As Boolean = False
					If OrderPlate = 1 Then
						If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = 1 Then
							If R.CromosomColumn = 7 Then
								Convert = True
							End If
						End If
						If ChessRules.SmallKingBridgeGray OrElse ChessRules.BigKingBridgeGray Then
							ChessRules.BridgeActGray = True
						End If
						AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
							Hit, ChessRules.BridgeActGray, Convert)
					Else
						If AllDraw.TableListAction(AllDraw.TableListAction.Count - 1)(R.CromosomRow, R.CromosomColumn) = -1 Then
							If R.CromosomColumn = 0 Then
								Convert = True
							End If
						End If
						If ChessRules.SmallKingBridgeBrown OrElse ChessRules.BigKingBridgeBrown Then
							ChessRules.BridgeActBrown = True
						End If

						AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, MovmentsNumber + 1, AllDraw.TableListAction(AllDraw.TableListAction.Count - 2)(R.CromosomRowFirst, R.CromosomColumnFirst), R.CromosomColumn, R.CromosomRow, HitVal, _
							Hit, ChessRules.BridgeActBrown, Convert)
					End If
					SetBoxStatistic(AllDraw.SyntaxToWrite)
					RefreshBoxStatistic()
				End If
			End If
			GrayTimer.StopTime()
			BrownTimer.StartTime()
			Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
				soundClick.Play()
				soundClick.Dispose()
			End Using

			InsertTableAtDataBase(Table)
			AliceSection = True
			StateCC = StoreStateCC
			StateCP = StoreStateCP
			StateGe = StoreStateGe
			ThinkingChess.ThinkingRun = False

		End Sub
		'Hit Reconstruction of Table.
		Sub HitRecustruct()
			If ChessRules.ExistInDestinationEnemy Then
				If System.Math.Abs(CurrentKind) = 1 Then
					Dim i As Integer = AllDraw.SodierMidle
					While i < AllDraw.SodierHigh
						Try
							If Draw.SolderesOnTable(Soldier).Row = Draw.SolderesOnTable(i).Row AndAlso Draw.SolderesOnTable(Soldier).Column = Draw.SolderesOnTable(i).Column Then
								Draw.SolderesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.ElefantHigh
						Try
							If Draw.SolderesOnTable(Soldier).Row = Draw.ElephantOnTable(i).Row AndAlso Draw.SolderesOnTable(Soldier).Column = Draw.ElephantOnTable(i).Column Then
								Draw.ElephantOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.HourseHight
						Try
							If Draw.SolderesOnTable(Soldier).Row = Draw.HoursesOnTable(i).Row AndAlso Draw.SolderesOnTable(Soldier).Column = Draw.HoursesOnTable(i).Column Then
								Draw.HoursesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.BridgeHigh
						Try
							If Draw.SolderesOnTable(Soldier).Row = Draw.BridgesOnTable(i).Row AndAlso Draw.SolderesOnTable(Soldier).Column = Draw.BridgesOnTable(i).Column Then
								Draw.BridgesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.MinisterHigh
						Try
							If Draw.SolderesOnTable(Soldier).Row = Draw.MinisterOnTable(i).Row AndAlso Draw.SolderesOnTable(Soldier).Column = Draw.MinisterOnTable(i).Column Then
								Draw.MinisterOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.KingHigh
						Try
							If Draw.SolderesOnTable(Soldier).Row = Draw.KingOnTable(i).Row AndAlso Draw.SolderesOnTable(Soldier).Column = Draw.KingOnTable(i).Column Then
								Draw.KingOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
				ElseIf System.Math.Abs(CurrentKind) = 2 Then

					Dim i As Integer = 0
					While i < AllDraw.SodierHigh
						Try
							If Draw.ElephantOnTable(Elefant).Row = Draw.SolderesOnTable(i).Row AndAlso Draw.ElephantOnTable(Elefant).Column = Draw.SolderesOnTable(i).Column Then
								Draw.SolderesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = AllDraw.ElefantMidle
					While i < AllDraw.ElefantHigh
						Try
							If Draw.ElephantOnTable(Elefant).Row = Draw.ElephantOnTable(i).Row AndAlso Draw.ElephantOnTable(Elefant).Column = Draw.ElephantOnTable(i).Column Then
								Draw.ElephantOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.HourseHight
						Try
							If Draw.ElephantOnTable(Elefant).Row = Draw.HoursesOnTable(i).Row AndAlso Draw.ElephantOnTable(Elefant).Column = Draw.HoursesOnTable(i).Column Then
								Draw.HoursesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.BridgeHigh
						Try

							If Draw.ElephantOnTable(Elefant).Row = Draw.BridgesOnTable(i).Row AndAlso Draw.ElephantOnTable(Elefant).Column = Draw.BridgesOnTable(i).Column Then
								Draw.BridgesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.MinisterHigh
						Try
							If Draw.ElephantOnTable(Elefant).Row = Draw.MinisterOnTable(i).Row AndAlso Draw.ElephantOnTable(Elefant).Column = Draw.MinisterOnTable(i).Column Then
								Draw.MinisterOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.KingHigh
						Try
							If Draw.ElephantOnTable(Elefant).Row = Draw.KingOnTable(i).Row AndAlso Draw.ElephantOnTable(Elefant).Column = Draw.KingOnTable(i).Column Then
								Draw.KingOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1

					End While
				ElseIf System.Math.Abs(CurrentKind) = 3 Then

					Dim i As Integer = 0
					While i < AllDraw.SodierHigh
						Try
							If Draw.HoursesOnTable(Hourse).Row = Draw.SolderesOnTable(i).Row AndAlso Draw.HoursesOnTable(Hourse).Column = Draw.SolderesOnTable(i).Column Then
								Draw.SolderesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.ElefantHigh
						Try
							If Draw.HoursesOnTable(Hourse).Row = Draw.ElephantOnTable(i).Row AndAlso Draw.HoursesOnTable(Hourse).Column = Draw.ElephantOnTable(i).Column Then
								Draw.ElephantOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = AllDraw.HourseMidle
					While i < AllDraw.HourseHight
						Try
							If Draw.HoursesOnTable(Hourse).Row = Draw.HoursesOnTable(i).Row AndAlso Draw.HoursesOnTable(Hourse).Column = Draw.HoursesOnTable(i).Column Then
								Draw.HoursesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.BridgeHigh
						Try
							If Draw.HoursesOnTable(Hourse).Row = Draw.BridgesOnTable(i).Row AndAlso Draw.HoursesOnTable(Hourse).Column = Draw.BridgesOnTable(i).Column Then
								Draw.BridgesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While

					Dim i As Integer = 0
					While i < AllDraw.MinisterHigh
						Try
							If Draw.HoursesOnTable(Hourse).Row = Draw.MinisterOnTable(i).Row AndAlso Draw.HoursesOnTable(Hourse).Column = Draw.MinisterOnTable(i).Column Then
								Draw.MinisterOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.KingHigh
						Try
							If Draw.HoursesOnTable(Hourse).Row = Draw.KingOnTable(i).Row AndAlso Draw.HoursesOnTable(Hourse).Column = Draw.KingOnTable(i).Column Then
								Draw.KingOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1

					End While
				ElseIf System.Math.Abs(CurrentKind) = 4 Then

					Dim i As Integer = 0
					While i < AllDraw.SodierHigh
						Try
							If Draw.BridgesOnTable(Bridge).Row = Draw.SolderesOnTable(i).Row AndAlso Draw.BridgesOnTable(Bridge).Column = Draw.SolderesOnTable(i).Column Then
								Draw.SolderesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.ElefantHigh
						Try
							If Draw.BridgesOnTable(Bridge).Row = Draw.ElephantOnTable(i).Row AndAlso Draw.BridgesOnTable(Bridge).Column = Draw.ElephantOnTable(i).Column Then
								Draw.ElephantOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While

					Dim i As Integer = 0
					While i < AllDraw.HourseHight
						Try
							If Draw.BridgesOnTable(Bridge).Row = Draw.HoursesOnTable(i).Row AndAlso Draw.BridgesOnTable(Bridge).Column = Draw.HoursesOnTable(i).Column Then
								Draw.HoursesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = AllDraw.BridgeMidle
					While i < AllDraw.BridgeHigh
						Try
							If Draw.BridgesOnTable(Bridge).Row = Draw.BridgesOnTable(i).Row AndAlso Draw.BridgesOnTable(Bridge).Column = Draw.BridgesOnTable(i).Column Then
								Draw.BridgesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.MinisterHigh
						Try
							If Draw.BridgesOnTable(Bridge).Row = Draw.MinisterOnTable(i).Row AndAlso Draw.BridgesOnTable(Bridge).Column = Draw.MinisterOnTable(i).Column Then
								Draw.MinisterOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.KingHigh
						Try
							If Draw.BridgesOnTable(Bridge).Row = Draw.KingOnTable(i).Row AndAlso Draw.BridgesOnTable(Bridge).Column = Draw.KingOnTable(i).Column Then
								Draw.KingOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
				ElseIf System.Math.Abs(CurrentKind) = 5 Then

					Dim i As Integer = 0
					While i < AllDraw.SodierHigh
						Try
							If Draw.MinisterOnTable(Minister).Row = Draw.SolderesOnTable(i).Row AndAlso Draw.MinisterOnTable(Minister).Column = Draw.SolderesOnTable(i).Column Then
								Draw.SolderesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.ElefantHigh
						Try
							If Draw.MinisterOnTable(Minister).Row = Draw.ElephantOnTable(i).Row AndAlso Draw.MinisterOnTable(Minister).Column = Draw.ElephantOnTable(i).Column Then
								Draw.ElephantOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While

					Dim i As Integer = 0
					While i < AllDraw.HourseHight
						Try
							If Draw.MinisterOnTable(Minister).Row = Draw.HoursesOnTable(i).Row AndAlso Draw.MinisterOnTable(Minister).Column = Draw.HoursesOnTable(i).Column Then
								Draw.HoursesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While

					Dim i As Integer = 0
					While i < AllDraw.BridgeHigh
						Try
							If Draw.MinisterOnTable(Minister).Row = Draw.BridgesOnTable(i).Row AndAlso Draw.MinisterOnTable(Minister).Column = Draw.BridgesOnTable(i).Column Then
								Draw.BridgesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = AllDraw.MinisterMidle
					While i < AllDraw.MinisterHigh
						Try
							If Draw.MinisterOnTable(Minister).Row = Draw.MinisterOnTable(i).Row AndAlso Draw.MinisterOnTable(Minister).Column = Draw.MinisterOnTable(i).Column Then
								Draw.MinisterOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.KingHigh
						Try
							If Draw.MinisterOnTable(Minister).Row = Draw.KingOnTable(i).Row AndAlso Draw.MinisterOnTable(Minister).Column = Draw.KingOnTable(i).Column Then
								Draw.KingOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
				ElseIf System.Math.Abs(CurrentKind) = 6 Then

					Dim i As Integer = 0
					While i < AllDraw.SodierHigh
						Try
							If Draw.KingOnTable(King).Row = Draw.SolderesOnTable(i).Row AndAlso Draw.KingOnTable(King).Column = Draw.SolderesOnTable(i).Column Then
								Draw.SolderesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.ElefantHigh
						Try
							If Draw.KingOnTable(King).Row = Draw.ElephantOnTable(i).Row AndAlso Draw.KingOnTable(King).Column = Draw.ElephantOnTable(i).Column Then
								Draw.ElephantOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.HourseHight
						Try
							If Draw.KingOnTable(King).Row = Draw.HoursesOnTable(i).Row AndAlso Draw.KingOnTable(King).Column = Draw.HoursesOnTable(i).Column Then
								Draw.HoursesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.BridgeHigh
						Try
							If Draw.KingOnTable(King).Row = Draw.BridgesOnTable(i).Row AndAlso Draw.KingOnTable(King).Column = Draw.BridgesOnTable(i).Column Then
								Draw.BridgesOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = 0
					While i < AllDraw.MinisterHigh
						Try
							If Draw.KingOnTable(King).Row = Draw.MinisterOnTable(i).Row AndAlso Draw.KingOnTable(King).Column = Draw.MinisterOnTable(i).Column Then
								Draw.MinisterOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
					Dim i As Integer = AllDraw.KingMidle
					While i < AllDraw.KingHigh
						Try
							If Draw.KingOnTable(King).Row = Draw.KingOnTable(i).Row AndAlso Draw.KingOnTable(King).Column = Draw.KingOnTable(i).Column Then
								Draw.KingOnTable(i) = Nothing
								Table(CType(RowClickP, Integer), CType(ColumnClickP, Integer)) = 0
								Return
							End If
						Catch t As Exception
							Log(t)
						End Try
						i += 1
					End While
				End If
			End If
		End Sub
		'About Tool Strip Calling.
		Private Sub aboutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim ChessRefrigitz As New AboutBoxChessRefrigitz()
			ChessRefrigitz.ShowDialog()
			ChessRefrigitz.Dispose()
		End Sub
		'Mouse Click Form Refregitz pictureBox Event Handling.
		Private Sub pictureBoxRefrigtz_MouseClick(sender As Object, e As MouseEventArgs)
			MouseClicked = True
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					If System.Math.Abs(e.X - i * (pictureBoxRefrigtz.Image.Width / 8)) < pictureBoxRefrigtz.Image.Width / 8 AndAlso System.Math.Abs(e.Y - j * (pictureBoxRefrigtz.Image.Height / 8)) < pictureBoxRefrigtz.Image.Height / 8 Then


						If AllDraw.MouseClick = 0 Then
							RowClickP = i
							ColumnClickP = j
							Dim ii As Integer = 0
							While ii < AllDraw.SodierHigh
								Try
									If (Draw.SolderesOnTable(ii).Row = i And Draw.SolderesOnTable(ii).Column = j) AndAlso System.Math.Abs(Table(i, j)) = 1 Then
										Soldier = ii
										AllDraw.MouseClick += 1
										Return
									End If
								Catch t As Exception
									Log(t)

								End Try
								ii += 1
							End While
							Dim ii As Integer = 0
							While ii < AllDraw.ElefantHigh
								Try
									If (Draw.ElephantOnTable(ii).Row = i And Draw.ElephantOnTable(ii).Column = j) AndAlso System.Math.Abs(Table(i, j)) = 2 Then
										Elefant = ii
										AllDraw.MouseClick += 1
										Return
									End If
								Catch t As Exception
									Log(t)

								End Try
								ii += 1
							End While
							Dim ii As Integer = 0
							While ii < AllDraw.HourseHight
								Try
									If (Draw.HoursesOnTable(ii).Row = i And Draw.HoursesOnTable(ii).Column = j) AndAlso System.Math.Abs(Table(i, j)) = 3 Then
										Hourse = ii
										AllDraw.MouseClick += 1
										Return
									End If
								Catch t As Exception
									Log(t)
								End Try
								ii += 1
							End While
							Dim ii As Integer = 0
							While ii < AllDraw.BridgeHigh
								Try
									If (Draw.BridgesOnTable(ii).Row = i And Draw.BridgesOnTable(ii).Column = j) AndAlso System.Math.Abs(Table(i, j)) = 4 Then
										Bridge = ii
										AllDraw.MouseClick += 1
										Return
									End If
								Catch t As Exception
									Log(t)
								End Try
								ii += 1
							End While

							Dim ii As Integer = 0
							While ii < AllDraw.MinisterHigh
								Try
									If (Draw.MinisterOnTable(ii).Row = i And Draw.MinisterOnTable(ii).Column = j) AndAlso System.Math.Abs(Table(i, j)) = 5 Then
										Minister = ii
										AllDraw.MouseClick += 1
										Return
									End If
								Catch t As Exception
									Log(t)
								End Try
								ii += 1
							End While

							Dim ii As Integer = 0
							While ii < AllDraw.KingHigh
								Try
									If (Draw.KingOnTable(ii).Row = i And Draw.KingOnTable(ii).Column = j) AndAlso System.Math.Abs(Table(i, j)) = 6 Then
										King = ii
										AllDraw.MouseClick += 1
										Return
									End If
								Catch t As Exception
									Log(t)

								End Try
								ii += 1


							End While
						Else
							If AllDraw.MouseClick = 1 Then

								RowRealesed = i
								ColumnRealeased = j

								RowClick = i

								ColumnClick = j

							End If
						End If
						AllDraw.MouseClick += 1
						Return
					End If
					j += 1
				End While
				i += 1
			End While


		End Sub

		'Mouse Movments of FormRefregitz PictureBox Event Handling.
		Private Sub pictureBoxRefrigtz_MouseMove(sender As Object, e As MouseEventArgs)
			Thread.Sleep(1)
			Try

				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						If System.Math.Abs(e.X - i * (pictureBoxRefrigtz.Image.Width / 8)) < pictureBoxRefrigtz.Image.Width / 8 AndAlso System.Math.Abs(e.Y - j * (pictureBoxRefrigtz.Image.Height / 8)) < pictureBoxRefrigtz.Image.Height / 8 Then
							If AllDraw.MouseClick = 1 Then

								Dim ii As Integer = 0
								While ii < pictureBoxRefrigtz.Image.Width
									Dim jj As Integer = 0
									While jj < pictureBoxRefrigtz.Image.Height
										Try
											Dim a As Color = Color.Gray
											If OrderPlate = -1 Then
												a = Color.Brown
											End If
											Dim Tab As Boolean(,) = Nothing
											If RowClickP <> -1 AndAlso ColumnClickP <> -1 Then
												Tab = VeryFye(Table, OrderPlate, a)
											End If
											If (ii + jj) Mod 2 = 0 Then
												g.DrawImage(Image.FromFile(Root + "\Images\Program\Black.jpg"), New Rectangle(ii, jj, Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))
											Else
												g.DrawImage(Image.FromFile(Root + "\Images\Program\White.jpg"), New Rectangle(ii, jj, Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))
											End If
											If Tab(i / (pictureBoxRefrigtz.Image.Width / 8), j / (pictureBoxRefrigtz.Image.Height / 8)) Then
												g.DrawString("*", New Font("Times New Roman", 50), New SolidBrush(Color.Red), New Rectangle(i, j, Me.pictureBoxRefrigtz.Width / 8, Me.pictureBoxRefrigtz.Height / 8))
											End If
										Catch t As Exception
											Log(t)
										End Try
										jj += pictureBoxRefrigtz.Image.Height / 8
									End While
									ii += pictureBoxRefrigtz.Image.Width / 8
								End While


								If RowRealesed = -1 AndAlso (ColumnRealeased = -1 And RowRealesedP = -1) AndAlso ColumnRealeasedP = -1 Then
									RowRealesed = i
									ColumnRealeased = j
									RowRealesedP = i
									ColumnRealeasedP = j



								End If
							End If
							RowRealesedP = RowRealesed
							ColumnRealeasedP = ColumnRealeased
							RowRealesed = i
							ColumnRealeased = j
							Return
						End If
						j += 1
					End While
					i += 1
				End While
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Computer By Computer tool Strip Menu Item Event Handlimng.
		Private Sub computerWithComputerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			StateCC = True
			If OrderPlate = 1 Then
				BobSection = True
				AliceSection = False
				GrayTimer.StartTime()
			Else
				BobSection = False
				AliceSection = True
				BrownTimer.StartTime()
			End If
		End Sub
		'Computer by Person Illegal name tool Strip Evnt Handling.
		Private Sub computerWithComputerToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			BobSection = False
			AliceSection = False
			StateCC = False
			StateGe = False
			If OrderPlate = 1 AndAlso Sec.radioButtonGrayOrder.Checked Then
				Person = True
				StateCP = True
				GrayTimer.StartTime()
			ElseIf Sec.radioButtonBrownOrder.Checked AndAlso OrderPlate = -1 Then
				Person = False
				StateCP = True
				BrownTimer.StartTime()
			Else
				StateCP = True
				Person = False
			End If





		End Sub
		'Button Next Game Analysis Click Event Handling.
		Private Sub buttonNext_Click(sender As Object, e As EventArgs)
			Try
				If MovmentsNumber < MaxCurrentMovmentsNumber Then
					'Increased a movments.
					MovmentsNumber += 1
					'Read Increased Movments.
					Table = ReadTableMovmentNumber()
					'Clear Table List of Draw.
					Draw.TableList.Clear()
					'Add Table to Table List.
					Draw.TableList.Add(Table)
					'Constructed a Draw All.
					Draw.SetRowColumn(0)
					'OutPut.
					SetBoxText(vbCr & vbLf & "Movments Number " + MovmentsNumber.ToString() + " Fronted.")
					'Refresh TextBox.
					RefreshBoxText()
					'Sound a Music.
					Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
						soundClick.Play()
						soundClick.Dispose()
					End Using

				End If
			Catch t As Exception
				Log(t)
			End Try

		End Sub
		'Previous Game Analysis Click Event Handling
		Private Sub buttonPrevious_Click(sender As Object, e As EventArgs)
			Try
				If MovmentsNumber > 0 Then
					MovmentsNumber -= 1
					'Read Current Table List
					Table = ReadTableMovmentNumber()
					'Clear Current TableList.
					Draw.TableList.Clear()
					'Add Table To Table List
					Draw.TableList.Add(Table)
					'Construction of All Things and Thinkings.
					Draw.SetRowColumn(0)
					'Out Put
					SetBoxText(vbCr & vbLf & "Movments Number " + MovmentsNumber.ToString() + " Backed.")
					'Refresh TextBox.
					RefreshBoxText()
					'Sound a Music.
					Using soundClick As New SoundPlayer(Root + "\Music\Click6.wav")
						soundClick.Play()
						soundClick.Dispose()
						'Decreased a Movments.

					End Using
				End If
			Catch t As Exception
				Log(t)
			End Try

		End Sub
		'Mouse Double Click pictureBoxRefregitz Click Event Handlimng.
		Private Sub pictureBoxRefrigtz_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Thread.Sleep(1)
			If Not Maximize Then
				RowP = pictureBoxRefrigtz.Width
				ColP = pictureBoxRefrigtz.Height
				RowS = Me.Width
				ColS = Me.Height
				Me.MaximumSize = New Size(1000, 700)
				pictureBoxRefrigtz.MaximumSize = New Size(900, 600)

				Maximize = True
			Else
				Me.MaximumSize = New Size(RowS, ColS)
				pictureBoxRefrigtz.MaximumSize = New Size(RowP, ColP)

				RowP = pictureBoxRefrigtz.Width
				ColP = pictureBoxRefrigtz.Height
				RowS = Me.Width
				ColS = Me.Height

				Maximize = False
			End If
		End Sub
		'New Game tool Strip Event Handling. 
		Private Sub toolStripMenuItem2_Click(sender As Object, e As EventArgs)
			NewTable = True
			Me.Hide()
			StateCC = False
			BobSection = False
			AliceSection = False
			StateCP = False
			Person = False
			Dim [New] As New FormRefrigtz(False)
			[New].ShowDialog()
			[New].Dispose()
		End Sub
		'Leave FormRefregitz Event Handling. 
		Private Sub FormRefrigtz_Leave(sender As Object, e As EventArgs)
			Sec.Dispose()
			Draw.THIS.Dispose()
			THIs.Dispose()
			Me.Dispose()
		End Sub
		'Exit ToolStrip Event Handling.
		Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				File.Delete("Run.txt")
			Catch t As Exception
				Log(t)
			End Try
			If True Then
				If TTimerSet IsNot Nothing Then
					TTimerSet.Abort()
				End If
				If AllOperate IsNot Nothing Then
					AllOperate.Abort()
				End If
				If t1 IsNot Nothing Then
					t1.Abort()
				End If
				If t2 IsNot Nothing Then
					t2.Abort()
				End If
				If t3 IsNot Nothing Then
					t3.Abort()
				End If
				If t4 IsNot Nothing Then
					t4.Abort()
				End If
				GrayTimer.StopTime()
				BrownTimer.StopTime()
				TimerText.StopTime()

				StateCC = False
				StateCP = False
				StateGe = False
				Person = False
				If Not Directory.Exists(Root + "\DataBase\Games") Then
					Directory.CreateDirectory(Root + "\DataBase\Games")
				End If
				Dim i As Integer = 0
				Do
					i += 1
				Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + i.ToString() + ".accdb")
				System.IO.File.Copy(Root + "\Database\CurrentBank.accdb", Root + "\Database\Games\CurrentBank" + i.ToString() + ".accdb")
				System.IO.File.Delete(Root + "\Database\CurrentBank.accdb")
				Application.[Exit]()
				Return
			End If

		End Sub

		'Dept Huristic Checkbox Checked Event Handling.
		Private Sub checkBoxDeptHuristic_CheckedChanged(sender As Object, e As EventArgs)
			RunInBackGround()
			If checkBoxDeptHuristic.Checked Then
				ThinkingChess.DeptHuristic = True
			Else
				ThinkingChess.DeptHuristic = False
			End If
			UpdateConfigurationTable()
			RunInFront()
		End Sub
		'radio Button Checked Box Checked Event Handling.
		Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs)
			Try

				RunInBackGround()
				If radioButtonOriginalImages.Checked Then
					AllDraw.ImagesSubRoot = AllDraw.ImageRoot + "\Original\"
				End If
				UpdateConfigurationTable()
				RunInFront()
			Catch t As Exception
				RunInFront()
				Log(t)
			End Try
		End Sub
		'Big Fitting Checked Box Checked Event Handling.
		Private Sub radioButtonBigFittingImages_CheckedChanged(sender As Object, e As EventArgs)
			Try
				RunInBackGround()
				If radioButtonBigFittingImages.Checked Then
					AllDraw.ImagesSubRoot = AllDraw.ImageRoot + "\Fit\Big\"
				End If
				UpdateConfigurationTable()
				RunInFront()
			Catch t As Exception
				RunInFront()
				Log(t)
			End Try
		End Sub
		'Samll Fitting Radio Button Checked Event Handling.
		Private Sub radioButtonSmallFittingImages_CheckedChanged(sender As Object, e As EventArgs)
			Try
				RunInBackGround()
				If radioButtonSmallFittingImages.Checked Then
					AllDraw.ImagesSubRoot = AllDraw.ImageRoot + "\Fit\Small\"
				End If
				UpdateConfigurationTable()
				RunInFront()
			Catch t As Exception
				RunInFront()
				Log(t)
			End Try
		End Sub
		'Genetic Algorithm Game tool Strip Event Handling. 
		Private Sub toolStripMenuItem3_Click(sender As Object, e As EventArgs)
			StateGe = True
		End Sub
		'Stop Button Click Event Handling.
		Private Sub buttonStop_Click(sender As Object, e As EventArgs)
			RunInBackGround()
			SetBoxText(vbCr & vbLf & "All Stop!.")

		End Sub
		'Dept First Search Checked BOX Checked Event Handling.
		Private Sub checkBoxDeptFirstSearch_CheckedChanged(sender As Object, e As EventArgs)
			Try
				AllDraw.DeptFirstSearch = True
				If checkBoxDeptFirstSearch.Checked Then
					checkBoxUseDoubleTime.Visible = True
				Else
					checkBoxUseDoubleTime.Visible = False
				End If
			Catch t As Exception
				RunInFront()
				Log(t)
			End Try



		End Sub
		'Hardes Games tool Strip Event Handling.
		Private Sub hardestToolStripMenuItem_Click(sender As Object, e As EventArgs)
			checkBoxDeptHuristic.Checked = True
			checkBoxPredictHuristci.Checked = True
			checkBoxDeptFirstSearch.Checked = True
			checkBoxBestMovments.Checked = False
			checkBoxOnlySelf.Checked = False
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()
		End Sub
		'Medum Game tool Strip Event Handling .
		Private Sub medumToolStripMenuItem_Click(sender As Object, e As EventArgs)
			checkBoxDeptHuristic.Checked = True
			checkBoxPredictHuristci.Checked = True
			checkBoxDeptFirstSearch.Checked = False
			checkBoxBestMovments.Checked = False
			checkBoxOnlySelf.Checked = False
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub
		'Easest tool Strip Event Handling .
		Private Sub easestToolStripMenuItem_Click(sender As Object, e As EventArgs)
			checkBoxDeptHuristic.Checked = False

			checkBoxPredictHuristci.Checked = False
			checkBoxDeptFirstSearch.Checked = False
			AllDraw.DeptFirstSearch = False
			checkBoxBestMovments.Checked = False
			checkBoxOnlySelf.Checked = True
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub
		'Maximum Size Form Refregitz Evemnt Handling Operation.
		Private Sub FormRefrigtz_MaximumSizeChanged(sender As Object, e As EventArgs)


			If t1.IsAlive Then
				Syncronization(t1, 1)
			End If
			

			If t2.IsAlive Then
				Syncronization(t2, 1)
			End If
			

			If t3.IsAlive Then
				Syncronization(t3, 1)
			End If
			

			If t4.IsAlive Then
				Syncronization(t4, 1)
			End If
			






			pictureBoxRefrigtz.Update()
			pictureBoxRefrigtz.Invalidate()

			System.Threading.Thread.Sleep(1000)

			If t1.IsBackground Then
				Syncronization(t1, 3)
			End If
			If t2.IsBackground Then
				Syncronization(t2, 3)
			End If
			If t3.IsBackground Then
				Syncronization(t3, 3)
			End If
			If t4.IsBackground Then
				Syncronization(t4, 3)
			End If
		End Sub
		'Leave toll Strips Event Handling Operation.
		Private Sub menuStripChessRefrigitz_Leave(sender As Object, e As EventArgs)
			If t1 IsNot Nothing Then
				t1.Abort()
			End If
			If t2 IsNot Nothing Then
				t2.Abort()
			End If
			If t3 IsNot Nothing Then
				t3.Abort()
			End If
			If t4 IsNot Nothing Then
				t4.Abort()
			End If


		End Sub
		'Puased Click Event Handling
		Private Sub buttonPause_Click(sender As Object, e As EventArgs)
			If Paused Then
				Try
					Paused = True
					RunInBackGround()

					buttonPauseStart.Text = "Start"
				Catch t As Exception
					Log(t)
				End Try
			Else
				Try
					RunInFront()
					Paused = False
					buttonPauseStart.Text = "Stop"
				Catch t As Exception
					Log(t)
				End Try
			End If
		End Sub
		'Run In Backgroud Thread Handling Method.
		Sub RunInBackGround()

			If t1.IsAlive Then
				Syncronization(t1, 1)
			End If
			

			If t2.IsAlive Then
				Syncronization(t2, 1)
			End If
			

			If t3.IsAlive Then
				Syncronization(t3, 1)
			End If
			

			If t4.IsAlive Then
				Syncronization(t4, 1)
			End If
			


		End Sub
		'Run In Front Thread Handling Method.
		Sub RunInFront()
			If StateCC AndAlso AliceSection AndAlso t3.IsBackground Then
				Syncronization(t3, 3)
			End If
			If StateCC AndAlso BobSection AndAlso t2.IsBackground Then
				Syncronization(t2, 3)
			End If
			If ((StateCP AndAlso Not Person) OrElse Blitz) AndAlso t1.IsBackground Then
				Syncronization(t1, 3)
			End If
			If t4.IsAlive AndAlso t4.IsBackground Then
				Syncronization(t4, 3)
			End If

		End Sub

		Private Sub continueAGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Try
					File.Delete(Root + "\Run.txt")
				Catch t As Exception
					Log(t)
				End Try
				Dim R As New FormKindOfGameContinue()
				R.ShowDialog()
				Try
					File.Delete(Root + "\DataBase\CurrentBank.accdb")
				Catch tt As Exception
					Log(tt)
				End Try
				File.Copy(Root + "\Database\Games\" + R.comboBoxDatabase.Text, Root + "\Database\CurrentBank.accdb")
				Try
					File.Delete(Root + "\DataBase\Games\" + R.comboBoxDatabase.Text)
				Catch ttt As Exception
					Log(ttt)
				End Try
				_1 = R.radioButtonComputerByComputer.Checked
				_2 = R.radioButtonComputerByPerson.Checked
				_3 = R.radioButtonGeneticGame.Checked
				_4 = R.radioButtonBlitz.Checked
				Dim a As [String] = ""
				If _1 Then
					a += 1
				Else
					a += 0
				End If
				If _2 Then
					a += 1
				Else
					a += 0
				End If
				If _3 Then
					a += 1
				Else
					a += 0
				End If
				If _4 Then
					a += 1
				Else
					a += 0
				End If
				File.WriteAllText(Root + "\Run.txt", a)
				Dim FolderLocation As [String] = Root
				Dim exitCode As Integer = 0

				' Prepare the process to run

				Dim start As New ProcessStartInfo()
				' Prepare the process to run
				' Enter in the command line arguments, everything you would enter after the executable name itself
				start.Arguments = ""
				' Enter the executable to run, including the complete path
				start.FileName = """" + FolderLocation + "\" + "Run.exe" + """"
				' Do you want to show a console window?
				start.WindowStyle = ProcessWindowStyle.Hidden
				start.CreateNoWindow = True
				start.UseShellExecute = True
				' Do not 'Run the external process & wait for it to finish'
				Using proc As Process = Process.Start(start)
					proc.WaitForExit()
					' Retrieve the app's exit code
					exitCode = proc.ExitCode
				End Using


				Application.[Exit]()
			Catch p As Exception
				Log(p)
			End Try
		End Sub

		Private Sub startGameToolStripMenuItem_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub progressBarVerify_CursorChanged(sender As Object, e As EventArgs)
			If PreviousTime IsNot Nothing Then
				Dim Remaining As DateTime = (New RefregitzReader.RefregitzReader(Nothing)).ConvertRefregitzStringToDateTime(((1 - (CType(progressBarVerify.Value, Single) / CType(progressBarVerify.Maximum, Single))) * (DateTime.Now.Ticks / 1000 - PreviousTime.Ticks / 1000)).ToString())
				labelTimesRemaining.Text = (Remaining.Day.ToString() + ":" + Remaining.Minute.ToString() + ":" + Remaining.Second.ToString()) + " Remaining"
				labelTimesRemaining.Update()
				labelTimesRemaining.Invalidate()
			Else
				PreviousTime = DateTime.Now
			End If
			Thread.Sleep(100)
		End Sub



		Private Sub progressBarVerify_Click(sender As Object, e As EventArgs)
			progressBarVerify_CursorChanged(sender, e)
		End Sub

		Private Sub progressBarVerify_Validated(sender As Object, e As EventArgs)
			progressBarVerify_Click(sender, e)
		End Sub

		Private Sub toolStripMenuItem6_Click(sender As Object, e As EventArgs)
			GrayTimer = New Timer(True)
			BrownTimer = New Timer(True)
			GrayTimer.TimerInitiate()
			BrownTimer.TimerInitiate()
			BobSection = False
			AliceSection = False
			StateCP = False
			StateCC = False
			StateGe = False
			If OrderPlate = 1 Then
				GrayTimer.StartTime()
			ElseIf OrderPlate = -1 Then
				BrownTimer.StartTime()
			Else
				Blitz = False
			End If
			Blitz = True

		End Sub


		Private Sub pictureBoxRefrigtz_MouseLeave(sender As Object, e As EventArgs)
			MouseClicked = False
		End Sub

		Private Sub checkBoxIgnoreSelf_CheckedChanged(sender As Object, e As EventArgs)
			If checkBoxIgnoreSelf.Checked Then
				ThinkingChess.IgnoreSelfObjects = True
			Else
				ThinkingChess.IgnoreSelfObjects = False
			End If
		End Sub

		'Dept Movments Event Handl;ing Operations Method.
		Private Sub checkBoxDeptMovement_Enter(sender As Object, e As EventArgs)
			If checkBoxDeptMovement.Checked Then
				AllDraw.SodierMovments = 4
				AllDraw.ElefantMovments = 16
				AllDraw.HourseMovments = 8
				AllDraw.BridgeMovments = 16
				AllDraw.MinisterMovments = 32

				AllDraw.KingMovments = 8
			Else
				AllDraw.SodierMovments = 1
				AllDraw.ElefantMovments = 1
				AllDraw.HourseMovments = 1
				AllDraw.BridgeMovments = 1
				AllDraw.MinisterMovments = 1
				AllDraw.KingMovments = 1
			End If

		End Sub
		'Double Time Checked Box Checked Event Handling.
		Private Sub checkBoxUseDoubleTime_CheckedChanged(sender As Object, e As EventArgs)
			Try
				RunInBackGround()
				If AllDraw.DeptFirstSearch Then
					checkBoxUseDoubleTime.Visible = True

					If checkBoxUseDoubleTime.Checked Then
						AllDraw.UseDoubleTime = True
					End If
				Else
					checkBoxUseDoubleTime.Visible = False
					AllDraw.UseDoubleTime = False
				End If

				UpdateConfigurationTable()
				RunInFront()
			Catch t As Exception
				RunInFront()
				Log(t)
			End Try

		End Sub
		'Penalty Regrad Mechansiam Checed Box Event Handling Operation Method.
		Private Sub checkBoxUsePenaltyRegradMechnisam_CheckedChanged(sender As Object, e As EventArgs)
			Try
				RunInBackGround()
				If checkBoxUsePenaltyRegradMechnisam.Checked Then
					ThinkingChess.UsePenaltyRegardMechnisam = True
				Else
					ThinkingChess.UsePenaltyRegardMechnisam = False
				End If
				UpdateConfigurationTable()
				RunInFront()
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Dynamic Programming Dept First checked Event Handling.
		Private Sub checkBoxDynamicProgrammingDeptFirst_CheckedChanged(sender As Object, e As EventArgs)
			Try
				RunInBackGround()
				If checkBoxDynamicProgrammingDeptFirst.Checked Then
					AllDraw.DynamicDeptFirstPrograming = True
				Else
					AllDraw.DynamicDeptFirstPrograming = False
				End If
				UpdateConfigurationTable()
				RunInFront()
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Help Event Handling Show Method.
		Private Sub toolStripMenuItem3_Click_1(sender As Object, e As EventArgs)
			Help.ShowHelp(Me, "Help.chm")

		End Sub
		Private sender As Object
		Private e As EventArgs
		Sub Veryfi()
			Dim Max As Integer = 0
			Do
				Max += 1
			Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + Max.ToString() + ".accdb")
			Dim iii As Integer = 0
			Do
				progressBarVerify_Validated(sender, e)

				progressBarVerify.Value = CType(((CType(iii, Double) / CType(Max, Double)) * 100.0), Integer)
				iii += 1
				Dim FileName As [String] = Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb"
				'Read Last Table and Set MovementNumber
				MovmentsNumber = 0
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						AllDraw.TableVeryfy(i, j) = AllDraw.TableVeryfyConst(i, j)
						j += 1
					End While
					i += 1
				End While

				Try
					VerifyTable(FileName, 0, MovmentsNumber)
				Catch t As Exception
					Log(t)

				End Try
			Loop While System.IO.File.Exists(Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
			MovmentsNumber = 0

		End Sub
		'Verify tool Srtip Games Folder Databases Event Handling Operation.
		Private Sub verifyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.sender = sender
			Me.e = e
			Dim t As New Thread(New ThreadStart(Veryfi))
			t.Start()
		End Sub

		Private Sub clearToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If File.Exists(Root + "ErrorProgramRun.txt") OrElse File.Exists(Root + "\Run.txt") Then
				Me.SetBoxText("Clearing..." & vbLf & vbLf & vbLf)
				If File.Exists(Root + "ErrorProgramRun.txt") Then
					File.Delete(Root + "\ErrorProgramRun.txt")
				End If
				If File.Exists(Root + "\Run.txt") Then
					File.Delete(Root + "\Run.txt")
				End If

				Me.SetBoxText("Finished.")
			End If
		End Sub

		Private Sub checkBoxPredictHuristci_CheckedChanged(sender As Object, e As EventArgs)

			RunInBackGround()
			If checkBoxPredictHuristci.Checked Then
				ThinkingChess.PredictHuristic = True
			Else
				ThinkingChess.PredictHuristic = False
			End If
			UpdateConfigurationTable()
			RunInFront()
		End Sub

		Private Sub comboBoxMaxTree_SelectedIndexChanged(sender As Object, e As EventArgs)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub

		Private Sub repairToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim iii As Integer = 1, Max As Integer = 1
			Dim t As Integer = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond

			Do
				If System.IO.File.Exists(FormRefrigtz.Root + "\Database\Games\CurrentBank" + Max.ToString() + ".accdb") Then
					Max += 1
				End If

				If DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - t > 2000 Then
					Exit Do
				End If
			Loop While True
			progressBarVerify.Maximum = Max
			Do
				iii += 1
				Try
					progressBarVerify.Value = iii
					progressBarVerify.Update()
				Catch t6 As Exception
					Log(t6)
					progressBarVerify.Value = Max

					progressBarVerify.Update()
				End Try
				If System.IO.File.Exists(FormRefrigtz.Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb") Then
					Try
						File.Copy(FormRefrigtz.Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb", Root + "\CurrentBank.accdb")
					Catch t1 As Exception
						Log(t1)
					End Try
					Try
						File.Delete(FormRefrigtz.Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
					Catch t2 As Exception
						Log(t2)
					End Try
					Try

						CreateConfigurationTable()
					Catch t3 As Exception
						Log(t3)
					End Try
					Try
						File.Copy(Root + "\CurrentBank.accdb", FormRefrigtz.Root + "\Database\Games\CurrentBank" + iii.ToString() + ".accdb")
					Catch t4 As Exception
						Log(t4)
					End Try
					Try
						File.Delete(Root + "\CurrentBank.accdb")
					Catch t5 As Exception
						Log(t5)
					End Try

				End If
			Loop While iii < Max


		End Sub

		Private Sub comboBoxAttack_SelectedIndexChanged(sender As Object, e As EventArgs)
			AllDraw.SignAttack = System.Convert.ToInt32((CType((sender), ComboBox)).Text)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()


		End Sub

		Private Sub comboBoxAchmaz_SelectedIndexChanged(sender As Object, e As EventArgs)
			AllDraw.SignAchmaz = System.Convert.ToInt32((CType((sender), ComboBox)).Text)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub

		Private Sub comboBoxReducedAttacked_SelectedIndexChanged(sender As Object, e As EventArgs)
			AllDraw.SignReducedAttacked = System.Convert.ToInt32((CType((sender), ComboBox)).Text)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub

		Private Sub comboBoxSupport_SelectedIndexChanged(sender As Object, e As EventArgs)
			AllDraw.SignSupport = System.Convert.ToInt32((CType((sender), ComboBox)).Text)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub

		Private Sub comboBoxHitting_SelectedIndexChanged(sender As Object, e As EventArgs)
			AllDraw.SignHitting = System.Convert.ToInt32((CType((sender), ComboBox)).Text)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub

		Private Sub comboBoxMovments_SelectedIndexChanged(sender As Object, e As EventArgs)
			AllDraw.SignMovments = System.Convert.ToInt32((CType((sender), ComboBox)).Text)
			RunInBackGround()
			UpdateConfigurationTable()
			RunInFront()

		End Sub

		Private Sub errorOpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			ErrorTrueMonitorFalse = True
			(New FormTXT()).Show()
		End Sub

		Private Sub monitorOpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			ErrorTrueMonitorFalse = False
			(New FormTXT()).Show()

		End Sub

		Private Sub toolStripMenuItem7_Click(sender As Object, e As EventArgs)


		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs)
			Try
				folderBrowserDialogBackup.ShowDialog()
				File.Copy(FormRefrigtz.Root + "\Database\CurrentBank.accdb", folderBrowserDialogBackup.SelectedPath + "\CurrentBank.accdb")
				File.Copy(FormRefrigtz.Root + "\Database\Monitor.txt", folderBrowserDialogBackup.SelectedPath + "\Monitor.txt")
				MessageBox.Show("Backup Finished.")
			Catch t As Exception
				Log(t)
				MessageBox.Show(t.ToString())
			End Try
		End Sub

		Private Sub toolStripMenuItem7_Click_1(sender As Object, e As EventArgs)
			GrayTimer = New Timer(True)
			BrownTimer = New Timer(True)
			GrayTimer.TimerInitiate()
			BrownTimer.TimerInitiate()
			BobSection = False
			AliceSection = False
			StateCP = True
			StateCC = False
			StateGe = False
			If OrderPlate = 1 AndAlso Sec.radioButtonGrayOrder.Checked Then
				Person = True
				StateCP = True
				GrayTimer.StartTime()
			ElseIf Sec.radioButtonBrownOrder.Checked AndAlso OrderPlate = -1 Then
				Person = False
				StateCP = True
				BrownTimer.StartTime()
			Else
				StateCP = True
				Person = False
			End If

		End Sub
	End Class

End Namespace