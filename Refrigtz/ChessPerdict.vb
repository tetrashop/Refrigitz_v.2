Imports System.IO
Imports System.Threading
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'********************************************************************************************
' * tring to predictative orderly movments.****************************************************
' * Ramin Edjlal*******************************************************************************
' * This Class should Predict the Validity Movements Of Current Order an Enemy of Current Order*(_)
' * Predict Not Working************************************************************************(+)
' * Chess Predict Taking A Lot Of Time********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Prediction Caused to Initial AllDraw Method in Achmaz state not Working.************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Kish' Achmaz Attacker by Gray Minister to Brown 'King' Not Removed by Brown Soldier******RS*****0.12**4**Managements and Cuation Programing**(+)
' * The State of Soldier Supporter By Soldier Brown Doesn’t Detected.*************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Predict Doesn’t Act The Supporter of Soldier****************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Predict Supporter Successful For Kishing 'Alice' by Person**************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess 'Alice' By 'Bob' Supporter Misleading***********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Predict at Tow Level Taking a lot of time.******************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Predict Not Working*****************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * **********************************************************************************************************************************************(+:Sum(10)) (_:Sum(1))



Namespace Refrigtz
	Class ChessPerdict
		'Initiate Global Variables.                           
		Private APredict As ChessPerdict = Nothing
		Private OrderDummy As Integer = 0
		Public Shared SodierValue As Integer = 1
		Public Shared ElefantValue As Integer = 2
		Public Shared HourseValue As Integer = 3
		Public Shared BridgeValue As Integer = 5
		Public Shared MinisterValue As Integer = 7
		Public Shared KingValue As Integer = 10
		Private RW As Integer = 0
		Private CL As Integer = 0
		Private Ki As Integer = 0
		Public Shared LoopHuristicIndex As Integer = 0
		Shared RWList As New List(Of Integer)()
		Shared ClList As New List(Of Integer)()
		Shared KiList As New List(Of Integer)()
		Public Shared TableListAction As New List(Of Integer(,))()
		Public Move As Integer = 0
		Public Shared MouseClick As Integer = 0
		Private DeptIndex As Integer() = New Integer(20) {}
		Public A As List(Of AllDraw) = Nothing
		Public TableList As New List(Of Integer(,))()
		Public Dept As Integer = 0
		Public SolderesOnTable As DrawSoldier() = Nothing
		Public ElephantOnTable As DrawElefant() = Nothing
		Public HoursesOnTable As DrawHourse() = Nothing
		Public BridgesOnTable As DrawBridge() = Nothing
		Public MinisterOnTable As DrawMinister() = Nothing
		Public KingOnTable As DrawKing() = Nothing
		Private THIS As FormRefrigtz
		Shared Sub Log(ex As Exception)
			Try
				Dim stackTrace As String = ex.ToString()
					' path of file where stack trace will be stored.
				File.AppendAllText(FormRefrigtz.Root + "\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Constructor.
		Public Sub New(ByRef Th As FormRefrigtz)
			'Initiate Global Variable By Local Parameters.
			THIS = Th
			A = New List(Of AllDraw)()
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
		'Determination of Current Thinking Operations Thread Finished His Worke.
		Public Function AllCurrentDeptThinkingFinished(Dum As AllDraw, i As Integer, j As Integer, Kind As Integer) As Boolean
			'Initiate Local Variables.
			Dim Finished As Boolean = False
			'Soldeir Kind.
			If Kind = 1 Then
				'Wait For Flag Become Valid.
				If Dum.SolderesOnTable(i).SoldierThinking(j).ThinkingFinished Then
					Return True
				End If
			'Elephant Kind.
			ElseIf Kind = 2 Then
				'Wait For Flag Become Valid.
				If Dum.ElephantOnTable(i).ElefantThinking(j).ThinkingFinished Then
					Return True
				End If
			'Hourse Kind.
			ElseIf Kind = 3 Then
				'Wait For Flag Become Valid.
				If Dum.HoursesOnTable(i).HourseThinking(j).ThinkingFinished Then
					Return True
				End If
			'Bridges Kind.
			ElseIf Kind = 4 Then
				'Wait For Flag Become Valid.
				If Dum.BridgesOnTable(i).BridgeThinking(j).ThinkingFinished Then
					Return True
				End If
			'Minister Kind.
			ElseIf Kind = 5 Then
				'Wait For Flag Become Valid.
				If Dum.MinisterOnTable(i).MinisterThinking(j).ThinkingFinished Then
					Return True
				End If
			'King Kind.
			ElseIf Kind = 6 Then
				'Wait For Flag Become Valid.
				If Dum.KingOnTable(i).KingThinking(j).ThinkingFinished Then
					Return True
				End If
			End If
			'Return Flag.
			Return Finished

		End Function
		'Wait Method For Thinking Operation.
		Sub Wait(Dum As AllDraw, i As Integer, j As Integer, Kind As Integer)
			'Wait For All Thinking Operation Finished.
			Do
				THIS.SetBoxText(vbCr & vbLf & "Dept Predict :" + AllDraw.SyntaxToWrite)

				THIS.RefreshBoxText()
			Loop While Not AllCurrentDeptThinkingFinished(Dum, i, j, Kind)


		End Sub
		'Initiate For Every Initiation Objects.
		Public Sub InitiateForEveryKindThingHome(DummyHA As AllDraw, ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, _
			TB As Boolean, [IN] As Integer)
			Dim i As Integer = 0, j As Integer = 0
			Dim Dummy As New AllDraw(THIS)
			'Gray Order.
			If Order = 1 Then
				'For All Gray Soldiers.
				i = 0
				While i < AllDraw.SodierMidle
					Try
						'When Current Soldeir is Not Existing Continue Traversal Back.
						If SolderesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(SolderesOnTable(i).Row, Integer)
						jj = CType(SolderesOnTable(i).Column, Integer)
						'Construction of Thinking Solders Gray Object.
						Dummy.SolderesOnTable(i) = New DrawSoldier(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Movments.
						j = 0
						While j < AllDraw.SodierMovments
							'Thinking Operations.
							Dummy.SolderesOnTable(i).SoldierThinking(j).Table = SolderesOnTable(i).SoldierThinking(j).Table
							Dummy.SolderesOnTable(i).SoldierThinking(j).ThinkingBegin = True
							Dummy.SolderesOnTable(i).SoldierThinking(j).ThinkingFinished = False
							Dummy.SolderesOnTable(i).SoldierThinking(j).t = New Thread(New ThreadStart(Dummy.SolderesOnTable(i).SoldierThinking(j).Thinking))
							Dummy.SolderesOnTable(i).SoldierThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 1)
							j += 1
						End While
					Catch t As Exception
						Dummy.SolderesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Gray Elephant Objects.
				i = 0
				While i < AllDraw.ElefantMidle
					Try
						'When Gray Elephant Not Existing Continue Traversal Back.
						If ElephantOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(ElephantOnTable(i).Row, Integer)
						jj = CType(ElephantOnTable(i).Column, Integer)
						'Construction of Gray Elepahnt Thinking Objectes.
						Dummy.ElephantOnTable(i) = New DrawElefant(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Movments.
						j = 0
						While j < AllDraw.ElefantMovments
							'Elephant Gray Thinking Operations.
							Dummy.ElephantOnTable(i).ElefantThinking(j).Table = ElephantOnTable(i).ElefantThinking(j).Table
							Dummy.ElephantOnTable(i).ElefantThinking(j).ThinkingBegin = True
							Dummy.ElephantOnTable(i).ElefantThinking(j).ThinkingFinished = False
							Dummy.ElephantOnTable(i).ElefantThinking(j).t = New Thread(New ThreadStart(Dummy.ElephantOnTable(i).ElefantThinking(j).Thinking))
							Dummy.ElephantOnTable(i).ElefantThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 2)
							j += 1
						End While
					Catch t As Exception
						Dummy.ElephantOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While


				'For All Hourse Gray Objects.
				i = 0
				While i < AllDraw.HourseMidle
					Try
						'When Gray Hourses Not Exsisting Continue Traversal Back.
						If HoursesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(HoursesOnTable(i).Row, Integer)
						jj = CType(HoursesOnTable(i).Column, Integer)

						Dummy.HoursesOnTable(i) = New DrawHourse(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Movments.
						j = 0
						While j < AllDraw.HourseMovments
							'Hourse Thinking Gray Objects Operations.
							Dummy.HoursesOnTable(i).HourseThinking(j).Table = HoursesOnTable(i).HourseThinking(j).Table
							Dummy.HoursesOnTable(i).HourseThinking(j).ThinkingBegin = True
							Dummy.HoursesOnTable(i).HourseThinking(j).ThinkingFinished = False
							Dummy.HoursesOnTable(i).HourseThinking(j).t = New Thread(New ThreadStart(Dummy.HoursesOnTable(i).HourseThinking(j).Thinking))
							Dummy.HoursesOnTable(i).HourseThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 3)
							j += 1
						End While
					Catch t As Exception
						Dummy.HoursesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Bridges Gray Objects.
				i = 0
				While i < AllDraw.BridgeMidle
					Try
						'When Gray Brideges Not Exsisting Traversal Back.
						If BridgesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(BridgesOnTable(i).Row, Integer)
						jj = CType(BridgesOnTable(i).Column, Integer)
						'Construction of Bridegs Gray With Local variables.
						Dummy.BridgesOnTable(i) = New DrawBridge(ii, jj, a, Table, Order, False, _
							i)

						j = 0
						While j < 16
							'Gray Bridges Thinking Operations.
							Dummy.BridgesOnTable(i).BridgeThinking(j).Table = BridgesOnTable(i).BridgeThinking(j).Table
							Dummy.BridgesOnTable(i).BridgeThinking(j).ThinkingBegin = True
							Dummy.BridgesOnTable(i).BridgeThinking(j).ThinkingFinished = False
							Dummy.BridgesOnTable(i).BridgeThinking(j).t = New Thread(New ThreadStart(Dummy.BridgesOnTable(i).BridgeThinking(j).Thinking))
							Dummy.BridgesOnTable(i).BridgeThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 4)
							j += 1
						End While
					Catch t As Exception
						Dummy.BridgesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Minister Objets.
				i = 0
				While i < AllDraw.MinisterMidle
					Try
						'Whe Gray Minister Not Exsisting Continue Traversal back.
						If MinisterOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(MinisterOnTable(i).Row, Integer)
						jj = CType(MinisterOnTable(i).Column, Integer)
						'Constructionof Ministerb Gray With Local Variables.
						Dummy.MinisterOnTable(i) = New DrawMinister(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Movments.
						j = 0
						While j < AllDraw.MinisterMovments
							'Thinking Gray Ministers Operations.
							Dummy.MinisterOnTable(i).MinisterThinking(j).Table = MinisterOnTable(i).MinisterThinking(j).Table
							Dummy.MinisterOnTable(i).MinisterThinking(j).ThinkingBegin = True
							Dummy.MinisterOnTable(i).MinisterThinking(j).ThinkingFinished = False
							Dummy.MinisterOnTable(i).MinisterThinking(j).t = New Thread(New ThreadStart(Dummy.MinisterOnTable(i).MinisterThinking(j).Thinking))
							Dummy.MinisterOnTable(i).MinisterThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 5)
							j += 1
						End While
					Catch t As Exception
						Dummy.MinisterOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Possible Gray Kings.
				i = 0
				While i < AllDraw.KingMidle
					Try
						'When Gray King Not Exsisting Continue Traversal Back.
						If KingOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(KingOnTable(i).Row, Integer)
						jj = CType(KingOnTable(i).Column, Integer)
						'Construction of Gray King With Local Variables.
						Dummy.KingOnTable(i) = New DrawKing(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Movements.
						j = 0
						While j < AllDraw.KingMovments
							'Thinking Gray King Operatons.
							Dummy.KingOnTable(i).KingThinking(j).Table = KingOnTable(i).KingThinking(j).Table
							Dummy.KingOnTable(i).KingThinking(j).ThinkingBegin = True
							Dummy.KingOnTable(i).KingThinking(j).ThinkingFinished = False
							Dummy.KingOnTable(i).KingThinking(j).t = New Thread(New ThreadStart(Dummy.KingOnTable(i).KingThinking(j).Thinking))
							Dummy.KingOnTable(i).KingThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 6)
							j += 1
						End While
					Catch t As Exception
						Dummy.KingOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
			Else
				'Brown Order.
				'For All Possible Brown Solders.
				i = AllDraw.SodierMidle
				While i < AllDraw.SodierHigh
					Try
						'Whn Not Existing Braown Solder Continue Traversal Back.
						If SolderesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(SolderesOnTable(i).Row, Integer)
						jj = CType(SolderesOnTable(i).Column, Integer)
						'Construction Of Brown Soldeir With Local Variables.
						Dummy.SolderesOnTable(i) = New DrawSoldier(ii, jj, a, Table, Order, False, _
							i)
						j = 0
						While j < 4
							'Thinking of Brown  Soldiers Operations.
							Dummy.SolderesOnTable(i).SoldierThinking(j).Table = SolderesOnTable(i).SoldierThinking(j).Table
							Dummy.SolderesOnTable(i).SoldierThinking(j).ThinkingBegin = True
							Dummy.SolderesOnTable(i).SoldierThinking(j).ThinkingFinished = False
							Dummy.SolderesOnTable(i).SoldierThinking(j).t = New Thread(New ThreadStart(Dummy.SolderesOnTable(i).SoldierThinking(j).Thinking))
							Dummy.SolderesOnTable(i).SoldierThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 1)
							j += 1
						End While
					Catch t As Exception
						Dummy.SolderesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Brown elepahnt Objects.
				i = AllDraw.ElefantMidle
				While i < AllDraw.ElefantHigh
					Try
						'Continue Traversal Back Of Non Existing Objects.
						If ElephantOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(ElephantOnTable(i).Row, Integer)
						jj = CType(ElephantOnTable(i).Column, Integer)
						'Construction of Brown Elephant Thinking Object.
						Dummy.ElephantOnTable(i) = New DrawElefant(ii, jj, a, Table, Order, False, _
							i)
						j = 0
						While j < AllDraw.ElefantMovments
							'Thinking Brown Elephant Operations.
							Dummy.ElephantOnTable(i).ElefantThinking(j).Table = ElephantOnTable(i).ElefantThinking(j).Table
							Dummy.ElephantOnTable(i).ElefantThinking(j).ThinkingBegin = True
							Dummy.ElephantOnTable(i).ElefantThinking(j).ThinkingFinished = False
							Dummy.ElephantOnTable(i).ElefantThinking(j).t = New Thread(New ThreadStart(Dummy.ElephantOnTable(i).ElefantThinking(j).Thinking))
							Dummy.ElephantOnTable(i).ElefantThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 2)
							j += 1
						End While
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
						'For Non Existing Brown Elephant Continue Traversal Back.
						If HoursesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(HoursesOnTable(i).Row, Integer)
						jj = CType(HoursesOnTable(i).Column, Integer)
						'Construction of Brown Hourse With Local Variables.
						Dummy.HoursesOnTable(i) = New DrawHourse(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Hourse Movments.
						j = 0
						While j < AllDraw.HourseMovments
							'Thinking of Brown Hourse Operations.
							Dummy.HoursesOnTable(i).HourseThinking(j).Table = HoursesOnTable(i).HourseThinking(j).Table
							Dummy.HoursesOnTable(i).HourseThinking(j).ThinkingBegin = True
							Dummy.HoursesOnTable(i).HourseThinking(j).ThinkingFinished = False
							Dummy.HoursesOnTable(i).HourseThinking(j).t = New Thread(New ThreadStart(Dummy.HoursesOnTable(i).HourseThinking(j).Thinking))
							Dummy.HoursesOnTable(i).HourseThinking(j).t.Start()
							'Wait For Thinking Finsishing.
							Wait(Dummy, i, j, 3)
							j += 1
						End While
					Catch t As Exception
						Dummy.HoursesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Bridesg Brown Objects.
				i = AllDraw.BridgeMidle
				While i < AllDraw.BridgeHigh
					Try
						'When Brown Bridges Non Existing Continue Traversal Back.
						If BridgesOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(BridgesOnTable(i).Row, Integer)
						jj = CType(BridgesOnTable(i).Column, Integer)
						'Construction of Brown Bridges With Local Variables.
						Dummy.BridgesOnTable(i) = New DrawBridge(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Bridges Movments.
						j = 0
						While j < AllDraw.BridgeMovments
							'Thinking of Brown Bridges Operations.
							Dummy.BridgesOnTable(i).BridgeThinking(j).Table = BridgesOnTable(i).BridgeThinking(j).Table
							Dummy.BridgesOnTable(i).BridgeThinking(j).ThinkingBegin = True
							Dummy.BridgesOnTable(i).BridgeThinking(j).ThinkingFinished = False
							Dummy.BridgesOnTable(i).BridgeThinking(j).t = New Thread(New ThreadStart(Dummy.BridgesOnTable(i).BridgeThinking(j).Thinking))
							Dummy.BridgesOnTable(i).BridgeThinking(j).t.Start()
							'Wait For Thinking Finsishing.                           
							Wait(Dummy, i, j, 4)
							j += 1
						End While
					Catch t As Exception
						Dummy.BridgesOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
				'For All Possible Brown Minster Objects.
				i = AllDraw.MinisterMidle
				While i < AllDraw.MinisterHigh
					Try
						'When Brown Minister Non Existing Continue Traversal Back.
						If MinisterOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(MinisterOnTable(i).Row, Integer)
						jj = CType(MinisterOnTable(i).Column, Integer)
						'Construction of Brown Minister Thinking Objects.
						Dummy.MinisterOnTable(i) = New DrawMinister(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Minister Brown Movments.
						j = 0
						While j < AllDraw.MinisterMovments
							'Brown Minister Thinking Operations.
							Dummy.MinisterOnTable(i).MinisterThinking(j).Table = MinisterOnTable(i).MinisterThinking(j).Table
							Dummy.MinisterOnTable(i).MinisterThinking(j).ThinkingBegin = True
							Dummy.MinisterOnTable(i).MinisterThinking(j).ThinkingFinished = False
							Dummy.MinisterOnTable(i).MinisterThinking(j).t = New Thread(New ThreadStart(Dummy.MinisterOnTable(i).MinisterThinking(j).Thinking))
							Dummy.MinisterOnTable(i).MinisterThinking(j).t.Start()
							Wait(Dummy, i, j, 5)
							j += 1
						End While
					Catch t As Exception
						Dummy.MinisterOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While

				'For All Brown King Objects.
				i = AllDraw.KingMidle
				While i < AllDraw.KingHigh
					Try
						'When Brown King Non Existing Continue Traversal Back.
						If KingOnTable(i) Is Nothing Then
							Continue Try
						End If
						'Initiate Local Variables.
						ii = CType(KingOnTable(i).Row, Integer)
						jj = CType(KingOnTable(i).Column, Integer)
						'Construction of Brown King Thinking Operation.
						Dummy.KingOnTable(i) = New DrawKing(ii, jj, a, Table, Order, False, _
							i)
						'For All Possible Brown King Movements.
						j = 0
						While j < AllDraw.KingMovments
							'Thinking of Brown King Thinking Operations.
							Dummy.KingOnTable(i).KingThinking(j).Table = KingOnTable(i).KingThinking(j).Table
							Dummy.KingOnTable(i).KingThinking(j).ThinkingBegin = True
							Dummy.KingOnTable(i).KingThinking(j).ThinkingFinished = False
							Dummy.KingOnTable(i).KingThinking(j).t = New Thread(New ThreadStart(Dummy.KingOnTable(i).KingThinking(j).Thinking))
							Dummy.KingOnTable(i).KingThinking(j).t.Start()
							'Wait For Thinking Finished.
							Wait(Dummy, i, j, 6)
							j += 1
						End While
					Catch t As Exception
						Dummy.KingOnTable(i) = Nothing
						Log(t)
					End Try
					i += 1
				End While
			End If

			A.Add(Dummy)

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
				If True Then
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

				End If
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
										If So1 > AllDraw.SodierMidle Then
											AllDraw.SodierMidle += 1
											AllDraw.SodierHigh += 1

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
										If So2 > AllDraw.SodierHigh Then
											AllDraw.SodierHigh += 1
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
										If El1 > AllDraw.ElefantMidle Then
											AllDraw.ElefantMidle += 1
											AllDraw.ElefantHigh += 1
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
										If El2 > AllDraw.ElefantHigh Then
											AllDraw.ElefantHigh += 1

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
										If Ho1 > AllDraw.HourseMidle Then
											AllDraw.HourseMidle += 1
											AllDraw.HourseHight += 1
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
										If Ho2 > AllDraw.HourseHight Then
											AllDraw.HourseHight += 1
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
										If Br1 > AllDraw.BridgeMidle Then
											AllDraw.BridgeMidle += 1
											AllDraw.BridgeHigh += 1

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
										If Br2 > AllDraw.BridgeHigh Then
											AllDraw.BridgeHigh += 1

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
										If Mi1 > AllDraw.MinisterMidle Then
											AllDraw.MinisterMidle += 1
											AllDraw.MinisterHigh += 1
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
										If Mi2 > AllDraw.MinisterHigh Then
											AllDraw.MinisterHigh += 1

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
										If Ki1 > AllDraw.KingMidle Then
											AllDraw.KingMidle += 1

											AllDraw.KingHigh += 1

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
										If Ki2 > AllDraw.KingHigh Then
											AllDraw.KingHigh += 1
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
		'Huristic of Kish Method.    
		Public Function HuristicKish(A As List(Of AllDraw), a As Color, ij As Integer, ByRef Less As Double, Order As Integer) As Integer(,)
			'Inititae Local Varibales.
			Dim i As Integer = 0, j As Integer = 0
			Dim Table As Integer(,) = New Integer(8, 8) {}
			Dim Act As Boolean = False
			Dim ii As Integer = ij
			'If List Exist.
			If A.Count > 0 Then
				ThinkingChess.Kind = 1
				'Fo All Soldeirs.
				i = 0
				While i < AllDraw.SodierHigh

					'Calculate Thinking Operation of Current Soldier.
					Dim k As Integer = 0
					While k < AllDraw.SodierMovments
						j = 0
						While SolderesOnTable(i) IsNot Nothing AndAlso SolderesOnTable(i).SoldierThinking(k) IsNot Nothing AndAlso j < SolderesOnTable(i).SoldierThinking(k).TableListSolder.Count
							Try
								'If there is Penalty Situation Continue.
								If FormRefrigtz.OrderPlate = Order Then
									If SolderesOnTable(i).SoldierThinking(k).PenaltyRegardListSolder(j).IsPenaltyAction() = 0 Then
										Less = -200000000
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If FormRefrigtz.OrderPlate = Order Then
									If SolderesOnTable(i).SoldierThinking(k).ReturnHuristic(i, j) >= Less Then
										'Initiate Table of Current Object.
										Dim TableS As Integer(,) = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)

										If True Then
											'Achamaz Kish Mate of Current Table.
											If (New ChessRules(1, TableS, Order, SolderesOnTable(i).SoldierThinking(k).Row, SolderesOnTable(i).SoldierThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not AllDraw.NoTableFound Then
												'If Order is Gray.
												If Order = 1 Then
													If ChessRules.KishGrayAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												Else
													'If Order is Brown.
													If ChessRules.KishBrownAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												End If

											Else
											End If
										End If
										If Order = 1 Then
											'If Order is Gray.
											'If KishAchmaz Occured and Dept Huristic Not Exist.
											If ChessRules.KishGrayAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
											If ChessRules.KishBrownAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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

										Less = SolderesOnTable(i).SoldierThinking(k).ReturnHuristic(i, j)


										Table = SolderesOnTable(i).SoldierThinking(k).TableListSolder(j)
										Dim Hit As Boolean = False
										If SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j) > 0 Then
											Hit = True
										End If
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
												SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
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
												AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
													SolderesOnTable(i).SoldierThinking(k).HitNumberSoldier(j), ChessRules.BridgeActBrown, True)
											Else
												AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -1, SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(1), SolderesOnTable(i).SoldierThinking(k).RowColumnSoldier(j)(0), Hit, _
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
				ThinkingChess.Kind = 2
				'Calculate Thinking Operation of Current Elephant.                   
				i = 0
				While i < AllDraw.ElefantHigh
					Dim k As Integer = 0
					While k < AllDraw.ElefantMovments
						j = 0
						While ElephantOnTable(i) IsNot Nothing AndAlso ElephantOnTable(i).ElefantThinking(k) IsNot Nothing AndAlso j < ElephantOnTable(i).ElefantThinking(k).TableListElefant.Count
							Try
								'If there is Penalty Situation Continue.
								If FormRefrigtz.OrderPlate = Order Then
									If ElephantOnTable(i).ElefantThinking(k).PenaltyRegardListElefant(j).IsPenaltyAction() = 0 Then
										Less = -200000000
										Continue Try
									End If
								End If

								'For Higher Huristic Values.
								If FormRefrigtz.OrderPlate = Order Then
									If ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j) >= Less Then

										'Initiate Table of Current Object.
										Dim TableS As Integer(,) = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
										If True Then
											'Achamaz Kish Mate of Current Table.
											If (New ChessRules(2, TableS, Order, ElephantOnTable(i).ElefantThinking(k).Row, ElephantOnTable(i).ElefantThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not AllDraw.NoTableFound Then
												'If Order is Gray.
												If Order = 1 Then
													If ChessRules.KishGrayAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												Else
													'If Order is Brown.
													If ChessRules.KishBrownAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												End If
											Else

												'}
											End If
										End If
										If Order = 1 Then
											'If Order is Gray.
											'If KishAchmaz Occured and Dept Huristic Not Exist.
											If ChessRules.KishGrayAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
												Table = APredict.InitiatePerdictKish(CType(APredict.ElephantOnTable(i).Row, Integer), CType(APredict.ElephantOnTable(i).Column, Integer), B, TableS, Order, False)
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
													RW = i
													CL = k
													Ki = 1
													Act = True

													Less = ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j)
												End If
											End If
										Else
											If ChessRules.KishBrownAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
												ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -2, ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(1), ElephantOnTable(i).ElefantThinking(k).RowColumnElefant(j)(0), Hit, _
												ElephantOnTable(i).ElefantThinking(k).HitNumberElefant(j), ChessRules.BridgeActBrown, False)
										End If

										FormRefrigtz.LastRow = ElephantOnTable(i).ElefantThinking(k).Row
										FormRefrigtz.LastColumn = ElephantOnTable(i).ElefantThinking(k).Column

										RW = i
										CL = k
										Ki = 2
										Act = True
										Less = ElephantOnTable(i).ElefantThinking(k).ReturnHuristic(i, j)

										Table = ElephantOnTable(i).ElefantThinking(k).TableListElefant(j)
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
				ThinkingChess.Kind = 3
				'Calculate Thinking Operation of Current Hourse.                   
				i = 0
				While i < AllDraw.HourseHight

					Dim k As Integer = 0
					While k < AllDraw.HourseMovments
						j = 0
						While HoursesOnTable(i) IsNot Nothing AndAlso HoursesOnTable(i).HourseThinking(k) IsNot Nothing AndAlso j < HoursesOnTable(i).HourseThinking(k).TableListHourse.Count
							Try
								'If there is Penalty Situation Continue.
								If FormRefrigtz.OrderPlate = Order Then
									If HoursesOnTable(i).HourseThinking(k).PenaltyRegardListHourse(j).IsPenaltyAction() = 0 Then
										Less = -200000000
										Continue Try
									End If
								End If


								'For Higher Huristic Values.
								If FormRefrigtz.OrderPlate = Order Then
									If HoursesOnTable(i).HourseThinking(k).ReturnHuristic(i, j) >= Less Then
										'Initiate Table of Current Object.
										Dim TableS As Integer(,) = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
										If True Then
											If True Then
												'Achamaz Kish Mate of Current Table.
												If (New ChessRules(3, TableS, Order, HoursesOnTable(i).HourseThinking(k).Row, HoursesOnTable(i).HourseThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not AllDraw.NoTableFound Then
													'If Order is Gray.
													If Order = 1 Then
														If ChessRules.KishGrayAchmaz AndAlso AllDraw.DeptFirstSearch Then
															Continue Try
														End If
													Else
														'If Order is Brown.
														If ChessRules.KishBrownAchmaz AndAlso AllDraw.DeptFirstSearch Then
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
											If ChessRules.KishGrayAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
										Else
											If ChessRules.KishBrownAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
													(New ChessRules(1, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
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
													Less = HoursesOnTable(i).HourseThinking(k).ReturnHuristic(i, j)
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
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
												HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -3, HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(1), HoursesOnTable(i).HourseThinking(k).RowColumnHourse(j)(0), Hit, _
												HoursesOnTable(i).HourseThinking(k).HitNumberHourse(j), ChessRules.BridgeActBrown, False)
										End If
										FormRefrigtz.LastRow = HoursesOnTable(i).HourseThinking(k).Row
										FormRefrigtz.LastColumn = HoursesOnTable(i).HourseThinking(k).Column

										RW = i
										CL = k
										Ki = 3
										Act = True
										Less = HoursesOnTable(i).HourseThinking(k).ReturnHuristic(i, j)

										Table = HoursesOnTable(i).HourseThinking(k).TableListHourse(j)
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
				ThinkingChess.Kind = 4
				'Calculate Thinking Operation of Current Bridges.
				i = 0
				While i < AllDraw.BridgeHigh
					Dim k As Integer = 0
					While k < AllDraw.BridgeMovments
						j = 0
						While BridgesOnTable(i) IsNot Nothing AndAlso BridgesOnTable(i).BridgeThinking(k) IsNot Nothing AndAlso j < BridgesOnTable(i).BridgeThinking(k).TableListBridge.Count
							Try
								'If there is Penalty Situation Continue.
								If FormRefrigtz.OrderPlate = Order Then
									If BridgesOnTable(i).BridgeThinking(k).PenaltyRegardListMinister(j).IsPenaltyAction() = 0 Then
										Less = -200000000
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If FormRefrigtz.OrderPlate = Order Then
									If BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j) >= Less Then
										'Initiate Table of Current Object.
										Dim TableS As Integer(,) = BridgesOnTable(i).BridgeThinking(k).TableListBridge(j)
										If True Then
											'Achamaz Kish Mate of Current Table.
											If (New ChessRules(4, TableS, Order, BridgesOnTable(i).BridgeThinking(k).Row, BridgesOnTable(i).BridgeThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not AllDraw.NoTableFound Then
												'If Order is Gray.
												If Order = 1 Then
													If ChessRules.KishGrayAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												Else
													'If Order is Brown.
													If ChessRules.KishBrownAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												End If

											Else
											End If
										End If
										If Order = 1 Then
											'If Order is Gray.
											'If KishAchmaz Occured and Dept Huristic Not Exist.
											If ChessRules.KishGrayAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
										Else
											If ChessRules.KishBrownAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
													(New ChessRules(1, Table, FormRefrigtz.OrderPlate, -1, -1)).Kish(Table, FormRefrigtz.OrderPlate)
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
													Less = BridgesOnTable(i).BridgeThinking(k).ReturnHuristic(i, j)

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
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
												BridgesOnTable(i).BridgeThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -4, BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(1), BridgesOnTable(i).BridgeThinking(k).RowColumnBridge(j)(0), Hit, _
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
				ThinkingChess.Kind = 5
				'Calculate Thinking Operation of Current Minister.          
				i = 0
				While i < AllDraw.MinisterHigh

					Dim k As Integer = 0
					While k < AllDraw.MinisterMovments
						j = 0
						While MinisterOnTable(i) IsNot Nothing AndAlso MinisterOnTable(i).MinisterThinking(k) IsNot Nothing AndAlso j < MinisterOnTable(i).MinisterThinking(k).TableListMinister.Count
							Try
								'If there is Penalty Situation Continue.
								If FormRefrigtz.OrderPlate = Order Then
									If MinisterOnTable(i).MinisterThinking(k).PenaltyRegardListMinister(j).IsPenaltyAction() = 0 Then
										Less = -200000000
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If FormRefrigtz.OrderPlate = Order Then
									If MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j) > Less Then
										'Initiate Table of Current Object.
										Dim TableS As Integer(,) = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
										If True Then
											If True Then
												'Achamaz Kish Mate of Current Table.
												If (New ChessRules(5, TableS, Order, MinisterOnTable(i).MinisterThinking(k).Row, MinisterOnTable(i).MinisterThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not AllDraw.NoTableFound Then
													'If Order is Gray.
													If Order = 1 Then
														If ChessRules.KishGrayAchmaz AndAlso AllDraw.DeptFirstSearch Then
															Continue Try
														End If
													Else
														'If Order is Brown.
														If ChessRules.KishBrownAchmaz AndAlso AllDraw.DeptFirstSearch Then
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
											If ChessRules.KishGrayAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
										Else
											If ChessRules.KishBrownAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
										If MinisterOnTable(i).MinisterThinking(k).HitNumberMinister(j) > 0 Then
											Hit = True
										End If
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
												MinisterOnTable(i).MinisterThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -5, MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(1), MinisterOnTable(i).MinisterThinking(k).RowColumnMinister(j)(0), Hit, _
												MinisterOnTable(i).MinisterThinking(k).HitNumberBridge(j), ChessRules.BridgeActBrown, False)
										End If

										FormRefrigtz.LastRow = MinisterOnTable(i).MinisterThinking(k).Row
										FormRefrigtz.LastColumn = MinisterOnTable(i).MinisterThinking(k).Column

										RW = i
										CL = k
										Ki = 5
										Act = True
										Less = MinisterOnTable(i).MinisterThinking(k).ReturnHuristic(i, j)

										Table = MinisterOnTable(i).MinisterThinking(k).TableListMinister(j)
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
				ThinkingChess.Kind = 6
				'Calculate Thinking Operation of Current King.                   
				i = 0
				While i < AllDraw.KingHigh
					Dim k As Integer = 0
					While k < AllDraw.KingMovments
						j = 0
						While KingOnTable(i) IsNot Nothing AndAlso KingOnTable(i).KingThinking(k) IsNot Nothing AndAlso j < KingOnTable(i).KingThinking(k).TableListKing.Count
							Try
								'If there is Penalty Situation Continue.
								If FormRefrigtz.OrderPlate = Order Then
									If KingOnTable(i).KingThinking(k).PenaltyRegardListKing(j).IsPenaltyAction() = 0 Then
										Less = -200000000
										Continue Try
									End If
								End If
								'For Higher Huristic Values.
								If FormRefrigtz.OrderPlate = Order Then
									If KingOnTable(i).KingThinking(k).ReturnHuristic(i, j) >= Less Then
										'Initiate Table of Current Object.
										Dim TableS As Integer(,) = KingOnTable(i).KingThinking(k).TableListKing(j)
										If True Then
											'Achamaz Kish Mate of Current Table.
											If (New ChessRules(6, TableS, Order, KingOnTable(i).KingThinking(k).Row, KingOnTable(i).KingThinking(k).Column).AchmazKingMove(Order, TableS, False)) AndAlso Not AllDraw.NoTableFound Then
												'If Order is Gray.
												If Order = 1 Then
													If ChessRules.KishGrayAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												Else
													'If Order is Brown.
													If ChessRules.KishBrownAchmaz AndAlso AllDraw.DeptFirstSearch Then
														Continue Try
													End If
												End If

											Else
											End If
										End If
										If Order = 1 Then
											'If Order is Gray.
											'If KishAchmaz Occured and Dept Huristic Not Exist.
											If ChessRules.KishGrayAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
										Else
											If ChessRules.KishBrownAchmaz AndAlso Not AllDraw.DeptFirstSearch Then
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
													RW = i
													CL = k
													Ki = 1
													Act = True
													Less = KingOnTable(i).KingThinking(k).ReturnHuristic(i, j)
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
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, 6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
												MinisterOnTable(i).MinisterThinking(k).HitNumberKing(j), ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(Table, FormRefrigtz.MovmentsNumber, -6, KingOnTable(i).KingThinking(k).RowColumnKing(j)(1), KingOnTable(i).KingThinking(k).RowColumnKing(j)(0), Hit, _
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
		'Iniatite Prediction Method.
		Public Function InitiatePerdictKish(ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, TB As Boolean) As Integer(,)
			'Initaite Local and Global Variables.
			Dim TablInit As Integer(,) = New Integer(8, 8) {}

			Dim TablInitOne As Integer(,) = New Integer(8, 8) {}
			Dim TablInitKish As Integer(,) = New Integer(8, 8) {}

			Dim Current As Integer = ChessRules.CurrentOrder
			OrderDummy = Order
			A.Clear()
			TableList.Clear()
			Dim Dummy As Boolean = ThinkingChess.NotSolvedKingDanger
			ThinkingChess.NotSolvedKingDanger = False
			LoopHuristicIndex = 0
			'Clone a Copy.
			Dim iii As Integer = 0
			While iii < 8
				Dim jjj As Integer = 0
				While jjj < 8
					TablInitOne(iii, jjj) = Table(iii, jjj)
					jjj += 1
				End While
				iii += 1
			End While
			'Clone A Copy.
			Dim iii As Integer = 0
			While iii < 8
				Dim jjj As Integer = 0
				While jjj < 8
					TablInitKish(iii, jjj) = TablInitOne(iii, jjj)
					jjj += 1
				End While
				iii += 1
			End While
			'Kish Consideration.
			If New ChessRules(1, TablInitKish, Order, -1, -1).Kish(TablInitKish, Order) Then
				If OrderDummy = 1 Then
					If ChessRules.KishGray Then
						Return Nothing

					End If
				Else
					If ChessRules.KishGray Then
						Return Nothing
					End If
				End If
			End If
			'For Tow Times
			Dim i As Integer = 0
			While i < 2

				If i <> 0 Then
					Me.SetRowColumn(i)
				End If
				If Order = 1 Then
					THIS.SetBoxText(vbCr & vbLf & "Chess Predict Thinking Dept " + (i + 1).ToString() + " By Bob!")
					THIS.RefreshBoxText()
				Else
					THIS.SetBoxText(vbCr & vbLf & "Chess Predict Thinking Dept " + (i + 1).ToString() + " By Alice!")
					THIS.RefreshBoxText()
				End If
				'Gray Order.
				If Order = 1 Then
					a = Color.Gray
				Else
					'Brown Order.
					a = Color.Brown
				End If
				'Initiate Local Variables and Take a Randomly Soldiers.
				Dim [In] As Integer = 0
				Dim iiii As Integer = 0
				Do
					If Order = 1 Then
						[In] = (New System.Random()).[Next](0, 8)
					Else

						[In] = (New System.Random()).[Next](8, 16)
					End If
					iiii += 1
				Loop While SolderesOnTable([In]) Is Nothing AndAlso iiii < 16
				'For Sixteen Times Take a Look At Thinking.
				If iiii < 16 Then
					Me.InitiateForEveryKindThingHome(New AllDraw(THIS), CType(CType(SolderesOnTable([In]).Row, Integer), Integer), CType(CType(SolderesOnTable([In]).Column, Integer), Integer), a, TablInit, Order, _
						False, [In])
				Else
					Me.InitiateForEveryKindThingHome(New AllDraw(THIS), CType(1, Integer), 2, a, TablInit, Order, _
						False, [In])
				End If

				'Initiate Local Variables.
				Dim Less As Double = -100000
				Dim Tab As Integer(,) = Nothing
				'List Not Empty.
				If A.Count > 0 Then
					'Gray Order.
					If Order = 1 Then
						THIS.SetBoxText(vbCr & vbLf & "Huristic Kish Considerasion Movements Dept " + i.ToString() + " By Bob!")
						THIS.RefreshBoxText()
					Else
						'Brown Order.
						THIS.SetBoxText(vbCr & vbLf & "Huristic Kish Considerasion Movements Dept " + i.ToString() + " By Alice!")

						THIS.RefreshBoxText()
					End If
					'Huristic Foundation of Table.
					Tab = HuristicKish(A, a, i, Less, Order)
				End If
				'Table is Not Found.
				If Tab Is Nothing Then
					'Initiate Not Found Variables.
					ThinkingChess.NotSolvedKingDanger = Dummy
					ChessRules.CurrentOrder = Current
					Order = OrderDummy
					Return Nothing
				End If

				'Table Foundation.
				If Tab IsNot Nothing Then
					'Clone a Copy.
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
					'Order = Order * -1;
					'ChessRules.CurrentOrder = Order;

					Dept += 1
					ChessRules.CurrentOrder *= -1



					Order *= -1
				Else
					'Table Not Found.
					ThinkingChess.NotSolvedKingDanger = Dummy
					ChessRules.CurrentOrder = Current
					Order = OrderDummy

					Return Nothing
				End If
				i += 1
			End While
			'Initiat Local Variables.
			ThinkingChess.NotSolvedKingDanger = Dummy
			ChessRules.CurrentOrder = Current
			Order = OrderDummy

			Return TablInitOne
		End Function
		'Enemy Non Used Kish Predict Found.
		Public Function InitiatePerdictKishEnemy(ii As Integer, jj As Integer, a As Color, Table As Integer(,), Order As Integer, TB As Boolean) As Boolean
			'Iniatite Local and Global Variables.
			Dim Current As Integer = ChessRules.CurrentOrder
			Dim OrderDummy As Integer = Order
			A.Clear()
			TableList.Clear()
			ChessRules.CurrentOrder *= -1
			Order *= -1
			Dim Dummy As Boolean = ThinkingChess.NotSolvedKingDanger
			ThinkingChess.NotSolvedKingDanger = False
			LoopHuristicIndex = 0
			'For One Time.
			Dim i As Integer = 0
			While i < 1
				'Initiate Local Variables.
				Dim TablInit As Integer(,) = New Integer(8, 8) {}
				If Order = 1 Then
					a = Color.Gray
				Else
					a = Color.Brown
				End If
				Dim [In] As Integer = 0
				'Found of a Randomly Soldeir.
				Do
					If Order = 1 Then
						[In] = (New System.Random()).[Next](0, 8)
					Else
						[In] = (New System.Random()).[Next](8, 16)
					End If
				Loop While SolderesOnTable([In]) Is Nothing
				'Intiatation of Thinking.
				Me.InitiateForEveryKindThingHome(New AllDraw(THIS), CType(SolderesOnTable([In]).Row, Integer), CType(SolderesOnTable([In]).Column, Integer), a, Table, Order, _
					False, [In])
				'Iniatite Local Variables.
				Dim Less As Double = 0
				Dim Tab As Integer(,) = Nothing
				'When Thinking Found Take Huristic.
				If A.Count > 0 Then
					Tab = HuristicKish(A, a, i, Less, Order)
				End If
				'Table Not Foundation Condition.
				If Tab Is Nothing Then
					'Initaiation of Not Founding Variables.
					ThinkingChess.NotSolvedKingDanger = Dummy
					ChessRules.CurrentOrder = Current
					Order = OrderDummy
					Return False
				End If
				'Table Reapetedly Consideration.
				If ThinkingChess.ExistTableInList(Tab, TableListAction, 0) Then
					'Remove Whle is Repeatedly.
					While ThinkingChess.ExistTableInList(Tab, TableListAction, 0)
						TableListAction.RemoveAt(LoopHuristicIndex)
					End While
					'Genetic Algorithm Construction.
					Dim R As ChessGeneticAlgorithm = (New ChessGeneticAlgorithm())
					'Found Of Genetic Algorithm Table Method.

					Tab = R.GenerateTable(TableListAction, LoopHuristicIndex, Order)
				End If
				'Table Foundation Condition.
				If Tab IsNot Nothing Then
					'Clone a Copy.
					Dim iii As Integer = 0
					While iii < 8
						Dim jjj As Integer = 0
						While jjj < 8
							TablInit(iii, jjj) = Tab(iii, jjj)
							jjj += 1
						End While
						iii += 1
					End While
					'Iniatiet Local Variables.
					Table = New Integer(8, 8) {}
					'Clone a Copy.
					Dim iii As Integer = 0
					While iii < 8
						Dim jjj As Integer = 0
						While jjj < 8
							Table(iii, jjj) = TablInit(iii, jjj)
							jjj += 1
						End While
						iii += 1
					End While
					'Initaiation of Local and Global Variables. 
					TableList.Add(TablInit)
					ClList.Add(CL)
					RWList.Add(RW)
					KiList.Add(Ki)
					Order = Order * -1
					ChessRules.CurrentOrder = Order

					Dept += 1
				End If
				i += 1
			End While
			'Iniatiation of Local and Global Variables.
			ThinkingChess.NotSolvedKingDanger = Dummy
			ChessRules.CurrentOrder = Current
			Order = OrderDummy
			Return True
		End Function


	End Class
End Namespace