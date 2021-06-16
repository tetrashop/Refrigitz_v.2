Imports System.Threading.Tasks
Imports System.Diagnostics
Imports System.IO
Imports LearningMachine
Imports System.Threading
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'***************************************************************************
' * Thinking Operation class.*************************************************
' * Ramin Edjlal**************************************************************
' * Drived Classess of Autamata Cellular Quantum Thinking Kernel**************
' * 1394/12/19****************************************************************
' * Crashed with Stack Overflow Exception*************************************(+)
' * Drives Caused Memory lack*************************************************(+)
' * New Version Cased Stack Overflow******************************************(+)
' * Scanning Four Dimension Homes of Thing Existences Taking A lot Of Time****(+)
' * All Data in This Scope From AllDraw Become Clear When Scope Changes*******(+)
' * Heuristic Work but the Movements And Attack Method Doesn’t work***********(+)
' * Probability Heuristic constant Table return*******************************(+)
' * Heuristic Working Not Constant Immunity***********************************(+)
' * Heuristic Constant Result Mechanism***************************************(+)
' * Things Order and Virtualization Error*************************************(+)
' * Misleading Things Order movement******************************************(+)
' * Multi Movements (3 ) In Chess Thinking************************************(+)
' * Location of Horse 'Bob' (Gray) After Hitting Un logically Unsupported*****(+)
' * Kish Thinking 'Alice' Malfunction*****************************************(+)
' * 'Mate' By 'Bob' Have Not Been Recognized.*********************************(+)
' * 'Kish' By 'Bob' Not Recognized.*******************************************(+)
' * 'Kish' 'Alice' Detected. No Action Was Done.******************************(+)
' * 'Kish' Mechanism Failure.*************************************************(+)
' * Strategy By 'Alice' Changed. 'Kish' Not Recognized By 'Alice'.************(+)
' * Heuristic Loop************************************************************(+)
' * 'Kish' Mechanism For Penalty Regard Is Malfunction************************(*)QC-OK.
' * Things Location Failure. Row and Column of this Objects class Malfunction*(+)
' * Malfunction Of Operating Lists in this class.*****************************(+)
' * Some Movements of All Possible Movements is not Identified****************(+)
' * Malfunction Clone Data To be Copied. List Will be erased******************(+)
' * King Cannot Hit Unsupported Enemy Things at Kish.*************************(+)
' * Thinking Time Taking al lot of time.**************************************(+)
' * There is No Reason For Mal Function of Thinking.**************************[+]
' * Huristic Supported at horse huristic cal at table content malfunction.****[+]
' * No Reason for malfunctioning of table content at huristic supported.******[+]
' * Thinking Finished Misleading.bool Variable of Think Finished Not Work on.*(+) 
' * A non Identified King Table List Alice is in List and Unhabitly ignored.**(+)
' * The Location of Penalty Regard Mechansim is Misleading.*******************(+)
' * Penalty Reagrd List is Empty.No Misleading List of Penalty Regard Mec.****(+)
' * No Ilegal Non Achmaz and Kish By 'Alice' at Current Game in PR Mech.******(+)
' * **************************************************************************(+:Sum(26)) (*:Sum(1)) 5:(+:Sum(3)) 6.(+:Sum(+)) 7.(QC-OK:Sum(1))
' * **************************************************************************
' 




Namespace Refrigtz
	Public Class ThinkingChess
		'Initiate Global Variables.
		Public Shared Sign As Integer = 1
		Public Shared Kind As Integer = 0
		Public Shared MaxHuristicx As Double = -20000000000000000L
		Public Shared MovementsDeptHuristicFound As Boolean = False
		Public Shared IgnoreSelfObjects As Boolean = False
		Public Shared UsePenaltyRegardMechnisam As Boolean = False
		Public Shared BestMovments As Boolean = True
		Public Shared PredictHuristic As Boolean = False
		Public Shared OnlySelf As Boolean = False
		Public Shared DeptHuristic As Boolean = False
		Public HitNumber As New List(Of Integer)()
		Public Shared NotSolvedKingDanger As Boolean = False
		Public Shared ThinkingRun As Boolean = False
		Private ThingsNumber As Integer = 0
		Private CurrentArray As Integer = 0
		Public HuristicValue As Double = 0
		Public HuristicValueMovement As Double = 0
		Public HuristicValueSupported As Double = 0
		Public HuristicValueAchmazKishMate As Double = 0
		Public ThinkingBegin As Boolean = False
		Public ThinkingFinished As Boolean = False
		Public IndexSoldier As Integer = 0
		Public IndexElefant As Integer = 0
		Public IndexHourse As Integer = 0
		Public IndexBridge As Integer = 0
		Public IndexMinister As Integer = 0
		Public IndexKing As Integer = 0
		Public Shared Index As Integer = 0
		Public Shared RowColumn As Integer(,)
		Public RowColumnSoldier As List(Of Integer())
		Public RowColumnElefant As List(Of Integer())
		Public RowColumnHourse As List(Of Integer())
		Public RowColumnBridge As List(Of Integer())
		Public RowColumnMinister As List(Of Integer())
		Public RowColumnKing As List(Of Integer())
		Public Table As Integer(,)
		Public HitNumberSoldier As List(Of Integer)
		Public HitNumberElefant As List(Of Integer)
		Public HitNumberHourse As List(Of Integer)
		Public HitNumberBridge As List(Of Integer)
		Public HitNumberMinister As List(Of Integer)
		Public HitNumberKing As List(Of Integer)
		Public TableConst As Integer(,)
		Public TableListSolder As New List(Of Integer(,))()
		Public TableListElefant As New List(Of Integer(,))()
		Public TableListHourse As New List(Of Integer(,))()
		Public TableListBridge As New List(Of Integer(,))()
		Public TableListMinister As New List(Of Integer(,))()
		Public TableListKing As New List(Of Integer(,))()
		Public HuristicListSolder As New List(Of Double())()
		Public HuristicListElefant As New List(Of Double())()
		Public HuristicListHourse As New List(Of Double())()
		Public HuristicListBridge As New List(Of Double())()
		Public HuristicListMinister As New List(Of Double())()
		Public HuristicListKing As New List(Of Double())()
		Public PenaltyRegardListSolder As New List(Of QuantumAtamata)()
		Public PenaltyRegardListElefant As New List(Of QuantumAtamata)()
		Public PenaltyRegardListHourse As New List(Of QuantumAtamata)()
		Public PenaltyRegardListBridge As New List(Of QuantumAtamata)()
		Public PenaltyRegardListMinister As New List(Of QuantumAtamata)()
		Public PenaltyRegardListKing As New List(Of QuantumAtamata)()
		Public Max As Integer
		Public Row As Integer, Column As Integer
		Private color As Color
		Private Order As Integer
		Public t As Thread = Nothing
		Public Dept As List(Of AllDraw) = Nothing

		Private Shared result1 As ParallelLoopResult
		Public Shared Property SomeExtremelyLargeNumber() As Long
		'''Log of Errors.
		Shared Sub Log(ex As Exception)
			Try
				Dim stackTrace As String = ex.ToString()
					''' path of file where stack trace will be stored.
				File.AppendAllText(FormRefrigtz.Root + "\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
			Catch t As Exception
				Log(t)
			End Try
		End Sub

		Public Sub New(ik As Integer, j As Integer)
			'Clear Dearty Part.
			TableListSolder.Clear()
			TableListElefant.Clear()
			TableListHourse.Clear()
			TableListBridge.Clear()
			TableListMinister.Clear()
			TableListKing.Clear()
			RowColumnSoldier = New List(Of Integer())()
			RowColumnElefant = New List(Of Integer())()
			RowColumnHourse = New List(Of Integer())()
			RowColumnBridge = New List(Of Integer())()
			RowColumnMinister = New List(Of Integer())()
			RowColumnKing = New List(Of Integer())()
			HitNumberSoldier = New List(Of Integer)()
			HitNumberElefant = New List(Of Integer)()
			HitNumberHourse = New List(Of Integer)()
			HitNumberBridge = New List(Of Integer)()
			HitNumberMinister = New List(Of Integer)()
			HitNumberKing = New List(Of Integer)()
			PenaltyRegardListSolder = New List(Of QuantumAtamata)()
			PenaltyRegardListElefant = New List(Of QuantumAtamata)()
			PenaltyRegardListHourse = New List(Of QuantumAtamata)()
			PenaltyRegardListBridge = New List(Of QuantumAtamata)()
			PenaltyRegardListMinister = New List(Of QuantumAtamata)()
			PenaltyRegardListKing = New List(Of QuantumAtamata)()

			Dept = New List(Of AllDraw)()
		End Sub
		'''Constructor
		Public Sub New(i As Integer, j As Integer, a As Color, Tab As Integer(,), Ma As Integer, Ord As Integer, _
			ThinkingBeg As Boolean, CurA As Integer, ThingN As Integer)
			Dept = New List(Of AllDraw)()
			ThingsNumber = ThingN
			CurrentArray = CurA
			TableListSolder.Clear()
			TableListElefant.Clear()
			TableListHourse.Clear()
			TableListBridge.Clear()
			TableListMinister.Clear()
			TableListKing.Clear()
			RowColumnSoldier = New List(Of Integer())()
			RowColumnElefant = New List(Of Integer())()
			RowColumnHourse = New List(Of Integer())()
			RowColumnBridge = New List(Of Integer())()
			RowColumnMinister = New List(Of Integer())()
			RowColumnKing = New List(Of Integer())()
			RowColumn = New Integer(1000000, 2) {}
			HitNumberSoldier = New List(Of Integer)()
			HitNumberElefant = New List(Of Integer)()
			HitNumberHourse = New List(Of Integer)()
			HitNumberBridge = New List(Of Integer)()
			HitNumberMinister = New List(Of Integer)()
			HitNumberKing = New List(Of Integer)()
			PenaltyRegardListSolder = New List(Of QuantumAtamata)()
			PenaltyRegardListElefant = New List(Of QuantumAtamata)()
			PenaltyRegardListHourse = New List(Of QuantumAtamata)()
			PenaltyRegardListBridge = New List(Of QuantumAtamata)()
			PenaltyRegardListMinister = New List(Of QuantumAtamata)()
			PenaltyRegardListKing = New List(Of QuantumAtamata)()
			Row = i
			Column = j
			color = a
			Max = Ma
			Table = Tab
			Index = 0
			IndexSoldier = 0
			IndexElefant = 0
			IndexHourse = 0
			IndexBridge = 0
			IndexMinister = 0
			IndexKing = 0
			TableConst = New Integer(8, 8) {}
			Dim ii As Integer = 0
			While ii < 8
				Dim jj As Integer = 0
				While jj < 8
					TableConst(ii, jj) = Table(ii, jj)
					jj += 1
				End While
				ii += 1
			End While
			Order = Ord
			ThinkingBegin = ThinkingBeg

			Dept = New List(Of AllDraw)()
		End Sub

		Function CloneATable(Tab As Integer(,)) As Integer(,)
			Dim Table As Integer(,) = New Integer(8, 8) {}
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					Table(i, j) = Tab(i, j)
					j += 1
				End While
				i += 1
			End While
			Return Table
		End Function
		Function CloneAList(Tab As Integer(), Count As Integer) As Integer()
			Dim Table As Integer() = New Integer(Count) {}
			Dim i As Integer = 0
			While i < Count
				Table(i) = Tab(i)
				i += 1
			End While
			Return Table
		End Function
		Function CloneAList(Tab As Double(), Count As Integer) As Double()
			Dim Table As Double() = New Double(Count) {}
			Dim i As Integer = 0
			While i < Count
				Table(i) = Tab(i)
				i += 1
			End While
			Return Table
		End Function
		'''Clone a Copy.
		Public Sub Clone(ByRef AA As ThinkingChess, ByRef THIS As FormRefrigtz)
			'Assignment Contert to New Content Object.
			AA = New ThinkingChess(Row, Column)
			AA.color = color
			AA.Column = Column
			AA.HuristicValue = HuristicValue
			AA.HuristicValueMovement = HuristicValueMovement
			AA.HuristicValueAchmazKishMate = HuristicValueAchmazKishMate
			AA.HuristicValueSupported = HuristicValueSupported
			AA.HitNumber = HitNumber
			AA.HitNumberBridge = HitNumberBridge
			AA.HitNumberElefant = HitNumberElefant
			AA.HitNumberHourse = HitNumberHourse
			AA.HitNumberKing = HitNumberKing
			AA.HitNumberMinister = HitNumberMinister
			AA.HitNumberSoldier = HitNumberSoldier
			AA.IndexBridge = IndexBridge
			AA.IndexElefant = IndexElefant
			AA.IndexHourse = IndexHourse
			AA.IndexKing = IndexKing
			AA.IndexMinister = IndexMinister
			AA.IndexSoldier = IndexSoldier
			AA.Max = Max
			AA.Order = Order
			AA.Row = Row
			If Dept.Count <> 0 Then

				Dim i As Integer = 0
				While i < Dept.Count
					AA.Dept.Add(New AllDraw(THIS))
					Dept(i).Clone(AA.Dept(i))
					i += 1
				End While
			End If

			Dim j As Integer = 0
			While j < RowColumnSoldier.Count

				AA.RowColumnSoldier.Add(CloneAList(RowColumnSoldier(j), 2))
				j += 1
			End While

			Dim j As Integer = 0
			While j < RowColumnBridge.Count
				AA.RowColumnBridge.Add(CloneAList(RowColumnBridge(j), 2))
				j += 1
			End While


			Dim j As Integer = 0
			While j < RowColumnElefant.Count
				AA.RowColumnElefant.Add(CloneAList(RowColumnElefant(j), 2))
				j += 1
			End While

			Dim j As Integer = 0
			While j < RowColumnHourse.Count
				AA.RowColumnHourse.Add(CloneAList(RowColumnHourse(j), 2))
				j += 1
			End While

			Dim j As Integer = 0
			While j < RowColumnKing.Count
				AA.RowColumnKing.Add(CloneAList(RowColumnKing(j), 2))
				j += 1
			End While

			Dim j As Integer = 0
			While j < RowColumnMinister.Count
				AA.RowColumnMinister.Add(CloneAList(RowColumnMinister(j), 2))
				j += 1
			End While

			AA.t = t
			AA.Table = New Integer(8, 8) {}
			AA.TableConst = New Integer(8, 8) {}
			If Table IsNot Nothing Then
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						AA.Table(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While
			End If
			If TableConst IsNot Nothing Then
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						AA.TableConst(i, j) = TableConst(i, j)
						j += 1
					End While
					i += 1
				End While
			End If
			Dim i As Integer = 0
			While i < TableListBridge.Count
				AA.TableListBridge.Add(CloneATable(TableListBridge(i)))
				i += 1
			End While

			Dim i As Integer = 0
			While i < TableListElefant.Count
				AA.TableListElefant.Add(CloneATable(TableListElefant(i)))
				i += 1
			End While

			Dim i As Integer = 0
			While i < TableListHourse.Count
				AA.TableListHourse.Add(CloneATable(TableListHourse(i)))
				i += 1
			End While

			Dim i As Integer = 0
			While i < TableListKing.Count
				AA.TableListKing.Add(CloneATable(TableListKing(i)))
				i += 1
			End While

			Dim i As Integer = 0
			While i < TableListMinister.Count
				AA.TableListMinister.Add(CloneATable(TableListMinister(i)))
				i += 1
			End While

			Dim i As Integer = 0
			While i < TableListSolder.Count
				AA.TableListSolder.Add(CloneATable(TableListSolder(i)))
				i += 1
			End While


			Dim i As Integer = 0
			While i < HuristicListSolder.Count
				AA.HuristicListSolder.Add(CloneAList(HuristicListSolder(i), 4))
				i += 1
			End While


			Dim i As Integer = 0
			While i < HuristicListElefant.Count
				AA.HuristicListElefant.Add(CloneAList(HuristicListElefant(i), 4))
				i += 1
			End While

			Dim i As Integer = 0
			While i < HuristicListHourse.Count
				AA.HuristicListHourse.Add(CloneAList(HuristicListHourse(i), 4))
				i += 1
			End While


			Dim i As Integer = 0
			While i < HuristicListBridge.Count
				AA.HuristicListBridge.Add(CloneAList(HuristicListBridge(i), 4))
				i += 1
			End While

			Dim i As Integer = 0
			While i < HuristicListMinister.Count
				AA.HuristicListMinister.Add(CloneAList(HuristicListMinister(i), 4))
				i += 1
			End While

			Dim i As Integer = 0
			While i < HuristicListKing.Count
				AA.HuristicListKing.Add(CloneAList(HuristicListKing(i), 4))
				i += 1
			End While



			Dim i As Integer = 0
			While i < PenaltyRegardListSolder.Count
				AA.PenaltyRegardListSolder.Add(PenaltyRegardListSolder(i))
				i += 1
			End While


			Dim i As Integer = 0
			While i < PenaltyRegardListElefant.Count
				AA.PenaltyRegardListElefant.Add(PenaltyRegardListElefant(i))
				i += 1
			End While

			Dim i As Integer = 0
			While i < PenaltyRegardListHourse.Count
				AA.PenaltyRegardListHourse.Add(PenaltyRegardListHourse(i))
				i += 1
			End While


			Dim i As Integer = 0
			While i < PenaltyRegardListBridge.Count
				AA.PenaltyRegardListBridge.Add(PenaltyRegardListBridge(i))
				i += 1
			End While

			Dim i As Integer = 0
			While i < PenaltyRegardListMinister.Count
				AA.PenaltyRegardListMinister.Add(PenaltyRegardListMinister(i))
				i += 1
			End While

			Dim i As Integer = 0
			While i < PenaltyRegardListKing.Count
				AA.PenaltyRegardListKing.Add(PenaltyRegardListKing(i))
				i += 1
			End While

			AA.ThinkingBegin = ThinkingBegin
			AA.ThinkingFinished = ThinkingFinished

		End Sub
		'''Determine of Chossing Max Hitting Value in Hit State.
		Function MaxOrderEnemyAndSelf(Tab As Integer(,), i As Integer, j As Integer, ii As Integer, jj As Integer, Order As Integer) As Integer
			'Initiate Local Variable.
			Dim MaxOrder As Integer = 0
			'When is Gray Order.
			If Order = 1 Then
				'For Gray Things.
				If Tab(i, j) > 0 Then
					'Find Maximum Hitting Movments.
					Dim Store As Integer = Tab(ii, jj)
					Tab(ii, jj) = 0
					Dim iii As Integer = 0
					While iii < 8
						Dim jjj As Integer = 0
						While jjj < 8
							If Not Attack(Tab, iii, jjj, i, j, Color.Brown, _
								Order) Then
								If System.Math.Abs(Tab(i, j)) < System.Math.Abs(Tab(ii, jj)) Then
									MaxOrder = Tab(ii, jj)
								Else
									MaxOrder = Tab(i, j)
								End If
							End If
							jjj += 1
						End While
						iii += 1
					End While

					Tab(ii, jj) = Store

				End If
			End If
			'For Brown Order.
			If Order = -1 Then
				'For Brown Objects.
				If Tab(i, j) < 0 Then
					'Find Maximum Brown Hitting Movments.
					Dim Store As Integer = Tab(ii, jj)
					Tab(ii, jj) = 0
					Dim iii As Integer = 0
					While iii < 8
						Dim jjj As Integer = 0
						While jjj < 8
							If Not Attack(Tab, iii, jjj, i, j, Color.Brown, _
								Order) Then
								If System.Math.Abs(Tab(i, j)) < System.Math.Abs(Tab(ii, jj)) Then
									MaxOrder = Tab(ii, jj)
								Else
									MaxOrder = Tab(i, j)
								End If
							End If
							jjj += 1
						End While
						iii += 1
					End While
					Tab(ii, jj) = Store

				End If
			End If
			'return Maximum Hitting.
			Return MaxOrder

		End Function
		'''Huristic of Attacker.
		Function HuristicAttack(Table As Integer(,), Order As Integer, a As Color) As Single
			Dim HA As Integer = 0
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'''When Dept Huristic is Not Assigned.
			If Not DeptHuristic Then
				'''For Every Objects.
				Dim i As Integer = Row, j As Integer = Column
				'''For All Movments.
				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						If i = ii AndAlso j = jj Then
							Continue While
						End If
						Dim Sign As Integer = 1
						Order = DummyOrder
						'''When Attack is true. means [ii,jj] is in Attacked  [i,j].
						'''What is Attack!
						'''Ans:When [ii,jj] is Attacked [i,j] return true when enemy is located in [ii,jj].
						If Table(ii, jj) > 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
							Order = -1
							Sign = 1 * AllDraw.SignAttack
							ChessRules.CurrentOrder = -1
							a = Color.Brown
						ElseIf Table(ii, jj) < 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
							Order = 1
							Sign = 1 * AllDraw.SignAttack
							ChessRules.CurrentOrder = 1
							a = Color.Gray
						Else
							'else
'                            if (Table[ii, jj] < 0 && DummyOrder == -1 && Table[i, j] > 0)
'                            {
'                                Order = 1;
'                                Sign = -1 * AllDraw.SignAttack;
'                                ChessRules.CurrentOrder = 1;
'                                a = Color.Gray;
'                            }
'                            else if (Table[ii, jj] > 0 && DummyOrder == 1 && Table[i, j] < 0)
'                            {
'                                Order = -1;
'                                Sign = -1 * AllDraw.SignAttack;
'                                ChessRules.CurrentOrder = -1;
'                                a = Color.Brown;
'                            }

							Continue While
						End If
						'For Attack Movments.
						If Attack(Table, i, j, ii, jj, a, _
							Order) Then
							'Finf Huristic Value Of Current and Add to Sumation.
							'  if (System.Math.Abs(Table[i, j]) < MaxOrderEnemyAndSelf(Table, i, j, ii, jj, Order))
							If True Then
								If System.Math.Abs(Table(i, j)) = 1 Then
									HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 2 Then
									HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 3 Then
									HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 4 Then
									HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 5 Then
									HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 6 Then
									HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
								End If



							End If





						End If
						jj += 1
					End While
					ii += 1

				End While
			Else
				'For All Table Homes find Attack Huristic.
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								Order = DummyOrder
								Dim Sign As Integer = 1
								'''When Attack is true. means [ii,jj] is in Attacked  [i,j].
								'''What is Attack!
								'''Ans:When [ii,jj] is Attacked [i,j] return true when enemy is located in [ii,jj].
								If Table(ii, jj) > 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
									Order = -1
									Sign = 1 * AllDraw.SignAttack
									ChessRules.CurrentOrder = -1
									a = Color.Brown
								ElseIf Table(ii, jj) < 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
									Order = 1
									Sign = 1 * AllDraw.SignAttack
									ChessRules.CurrentOrder = 1
									a = Color.Gray
								Else
									'else
'                                    if (Table[ii, jj] < 0 && DummyOrder == -1 && Table[i, j] > 0)
'                                    {
'                                        Order = 1;
'                                        Sign = -1 * AllDraw.SignAttack;
'                                        ChessRules.CurrentOrder = 1;
'                                        a = Color.Gray;
'                                    }
'                                    else if (Table[ii, jj] > 0 && DummyOrder == 1 && Table[i, j] < 0)
'                                    {
'                                        Order = -1;
'                                        Sign = -1 * AllDraw.SignAttack;
'                                        ChessRules.CurrentOrder = -1;
'                                        a = Color.Brown;
'                                    }

									Continue While
								End If
								'For Attack Movments.
								If Attack(Table, i, j, ii, jj, a, _
									Order) Then
									'Find Huristic Movments Attack.
									If True Then
										If System.Math.Abs(Table(i, j)) = 1 Then
											HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 2 Then
											HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 3 Then
											HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 4 Then
											HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 5 Then
											HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 6 Then
											HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
										End If
									End If
								End If
								jj += 1
							End While
							ii += 1
						End While
						j += 1
					End While
					i += 1
				End While
			End If
			'Initiate to Begin Call Orders.
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder
			'Add Local Huristic to Global One.
			HuristicValue += HA * SignOrderToPlate(Order)
			Return HA
		End Function
		Function HuristicReducsedAttack(Table As Integer(,), Order As Integer, a As Color) As Single
			Dim HA As Integer = 0
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'''When Dept Huristic is Not Assigned.
			If Not DeptHuristic Then
				'''For Every Objects.
				Dim i As Integer = Row, j As Integer = Column
				'''For All Movments.
				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						If i = ii AndAlso j = jj Then
							Continue While
						End If
						Dim Sign As Integer = 1
						Order = DummyOrder
						'''When Attack is true. means [ii,jj] is in Attacked  [i,j].
						'''What is Attack!
						'''Ans:When [ii,jj] is Attacked [i,j] return true when enemy is located in [ii,jj].
						If Table(ii, jj) > 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
							Order = 1
							Sign = -1 * AllDraw.SignReducedAttacked
							ChessRules.CurrentOrder = 1
							a = Color.Gray
						ElseIf Table(ii, jj) < 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
							Order = -1
							Sign = -1 * AllDraw.SignReducedAttacked
							ChessRules.CurrentOrder = -1
							a = Color.Brown
						Else
							'else
'                            if (Table[ii, jj] < 0 && DummyOrder == -1 && Table[i, j] > 0)
'                            {
'                                Order = -1;
'                                Sign = 1 * AllDraw.SignReducedAttacked;
'                                ChessRules.CurrentOrder = -1;
'                                a = Color.Brown;
'                            }
'                            else if (Table[ii, jj] > 0 && DummyOrder == 1 && Table[i, j] < 0)
'                            {
'                                Order = 1;
'                                Sign = 1 * AllDraw.SignReducedAttacked;
'                                ChessRules.CurrentOrder = 1;
'                                a = Color.Gray;
'                            }

							Continue While
						End If
						'For Attack Movments.
						If Attack(Table, ii, jj, i, j, a, _
							Order) Then
							'Finf Huristic Value Of Current and Add to Sumation.
							If True Then
								If System.Math.Abs(Table(ii, jj)) = 1 Then
									HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(i, j)))
								ElseIf System.Math.Abs(Table(ii, jj)) = 2 Then
									HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(i, j)))
								ElseIf System.Math.Abs(Table(ii, jj)) = 3 Then
									HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(i, j)))
								ElseIf System.Math.Abs(Table(ii, jj)) = 4 Then
									HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(i, j)))
								ElseIf System.Math.Abs(Table(ii, jj)) = 5 Then
									HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(i, j)))
								ElseIf System.Math.Abs(Table(ii, jj)) = 6 Then
									HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(i, j)))
								End If



							End If





						End If
						jj += 1
					End While
					ii += 1

				End While
			Else
				'For All Table Homes find Attack Huristic.
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								Order = DummyOrder
								Dim Sign As Integer = 1
								'''When Attack is true. means [ii,jj] is in Attacked  [i,j].
								'''What is Attack!
								'''Ans:When [ii,jj] is Attacked [i,j] return true when enemy is located in [ii,jj].
								If Table(ii, jj) > 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
									Order = 1
									Sign = -1 * AllDraw.SignReducedAttacked
									ChessRules.CurrentOrder = 1
									a = Color.Gray
								ElseIf Table(ii, jj) < 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
									Order = -1
									Sign = -1 * AllDraw.SignReducedAttacked
									ChessRules.CurrentOrder = -1
									a = Color.Brown
								End If
								'else
'                                    if (Table[ii, jj] < 0 && DummyOrder == -1 && Table[i, j] > 0)
'                                    {
'                                        Order = -1;
'                                        Sign = 1 * AllDraw.SignReducedAttacked;
'                                        ChessRules.CurrentOrder = -1;
'                                        a = Color.Brown;
'                                    }
'                                    else if (Table[ii, jj] > 0 && DummyOrder == 1 && Table[i, j] < 0)
'                                    {
'                                        Order = 1;
'                                        Sign = 1 * AllDraw.SignReducedAttacked;
'                                        ChessRules.CurrentOrder = 1;
'                                        a = Color.Gray;
'                                    }
'                                    else

								Continue While
								'For Attack Movments.
								If Attack(Table, ii, jj, i, j, a, _
									Order) Then
									'Find Huristic Movments Attack.
									If True Then

										If System.Math.Abs(Table(ii, jj)) = 1 Then
											HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(i, j)))
										ElseIf System.Math.Abs(Table(ii, jj)) = 2 Then
											HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(i, j)))
										ElseIf System.Math.Abs(Table(ii, jj)) = 3 Then
											HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(i, j)))
										ElseIf System.Math.Abs(Table(ii, jj)) = 4 Then
											HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(i, j)))
										ElseIf System.Math.Abs(Table(ii, jj)) = 5 Then
											HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(i, j)))
										ElseIf System.Math.Abs(Table(ii, jj)) = 6 Then
											HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(i, j)))
										End If
									End If
								End If
								jj += 1
							End While
							ii += 1
						End While
						j += 1
					End While
					i += 1
				End While
			End If
			'Initiate to Begin Call Orders.
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder
			'Add Local Huristic to Global One.
			HuristicValue += HA * SignOrderToPlate(Order)
			Return HA
		End Function

		'''Huristic of Achmaz.
		Function HuristicAchmaz(Table As Integer(,), Order As Integer, a As Color) As Single
			Dim HA As Integer = 0
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'''When There is no DeptHuristic
			If Not DeptHuristic Then
				'''For Every Object.
				Dim i As Integer = Row, j As Integer = Column
				'''For All Object in Current Table.
				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						If i = ii AndAlso j = jj Then
							Continue While
						End If
						Order = DummyOrder
						Dim Sign As Integer = 1
						'''When Achmaz is true. means [ii,jj] is in Achmaz by [i,j].
						'''What is Achmaz!
						'''Ans:When [i,j] is Attacked [ii,jj] return true when enemy is located in [ii,jj].
						If Table(ii, jj) > 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
							Order = 1
							Sign = -1 * AllDraw.SignAchmaz
							ChessRules.CurrentOrder = 1
							a = Color.Gray
						ElseIf Table(ii, jj) < 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
							Order = -1
							Sign = -1 * AllDraw.SignAchmaz
							ChessRules.CurrentOrder = -1
							a = Color.Brown
						Else
							'
'                            if (Table[ii, jj] < 0 && DummyOrder == -1 && Table[i, j] > 0)
'                            {
'                                Order = -1;
'                                Sign = 1 * AllDraw.SignAchmaz;
'                                ChessRules.CurrentOrder = -1;
'                                a = Color.Brown;
'                            }
'                            else if (Table[ii, jj] > 0 && DummyOrder == 1 && Table[i, j] < 0)
'                            {
'                                Order = 1;
'                                Sign = 1 * AllDraw.SignAchmaz;
'                                ChessRules.CurrentOrder = 1;
'                                a = Color.Gray;
'                            }
'                            else
							Continue While
						End If
						'For Achmaz Movments.
						If Achmaz(Table, ii, jj, i, j, a, _
							Order) Then
							'Find Local Sumation of Achmaz Huristic.
							If True Then
								If System.Math.Abs(Table(i, j)) = 1 Then
									HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 2 Then
									HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 3 Then
									HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 4 Then
									HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 5 Then
									HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 6 Then
									HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
								End If



							End If





						End If
						jj += 1
					End While
					ii += 1

				End While
			Else
				'For All Table Home Find Achmaz Huristic
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								Dim Sign As Integer = 1
								'''When Achmaz is true. means [ii,jj] is in Achmaz by [i,j].
								'''What is Achmaz!
								'''Ans:When [i,j] is Attacked [ii,jj] return true when enemy is located in [ii,jj].
								If Table(ii, jj) > 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
									Order = 1
									Sign = -1 * AllDraw.SignAchmaz
									ChessRules.CurrentOrder = 1
									a = Color.Gray
								ElseIf Table(ii, jj) < 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
									Order = -1
									Sign = -1 * AllDraw.SignAchmaz
									ChessRules.CurrentOrder = -1
									a = Color.Brown
								Else
									'
'                                    if (Table[ii, jj] < 0 && DummyOrder == -1 && Table[i, j] > 0)
'                                    {
'                                        Order = -1;
'                                        Sign = 1 * AllDraw.SignAchmaz;
'                                        ChessRules.CurrentOrder = -1;
'                                        a = Color.Brown;
'                                    }
'                                    else if (Table[ii, jj] > 0 && DummyOrder == 1 && Table[i, j] < 0)
'                                    {
'                                        Order = 1;
'                                        Sign = 1 * AllDraw.SignAchmaz;
'                                        ChessRules.CurrentOrder = 1;
'                                        a = Color.Gray;
'                                    }
'                                    else
									Continue While
								End If

								'For Current Movments of legal Movments.
								If Achmaz(Table, ii, jj, i, j, a, _
									Order) Then
									'Find Achmaz Huristic Locals.
									If True Then
										If System.Math.Abs(Table(i, j)) = 1 Then
											HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 2 Then
											HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 3 Then
											HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 4 Then
											HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 5 Then
											HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 6 Then
											HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
										End If


									End If





								End If
								jj += 1
							End While
							ii += 1
						End While
						j += 1
					End While
					i += 1
				End While
			End If
			'Initiate Orders to Call Begining.
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder
			'Assignments of Global Huristic with Local One.
			HuristicValueAchmazKishMate += HA * SignOrderToPlate(Order)
			'return Local Huristic.
			Return HA
		End Function
		Sub HuristicHitting(Tab As Integer(,), i As Integer, j As Integer, ii As Integer, jj As Integer, Order As Integer, _
			a As Color, Hit As Boolean)
			'Defualt is Gray Order.
			Dim HA As Double = 0.0
			Dim Sign As Integer = 999 * AllDraw.SignHitting
			'For Brown One.
			'If Hitting Occured Find Positive Hitting Huristic.
			'if (Hit)
			Dim iii As Integer = 0
			While iii < 8
				Dim jjj As Integer = 0
				While jjj < 8
					Dim CDummyOrder As Integer = Order
					Dim CCurrentDummy As Integer = ChessRules.CurrentOrder
					Dim colorAS As Color = a
					If Tab(iii, jjj) > 0 Then
						Order = 1
						ChessRules.CurrentOrder = 1
						a = Color.Gray
					ElseIf Tab(iii, jjj) < 0 Then
						Order = -1
						ChessRules.CurrentOrder = -1
						a = Color.Brown
					End If
					If (New ThinkingChess(iii, jjj)).Attack(Tab, iii, jjj, i, j, a, _
						Order) Then
						Sign = -999 * AllDraw.SignHitting
						If System.Math.Abs(Table(iii, jjj)) = 1 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.SodierValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 2 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.ElefantValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 3 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.HourseValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 4 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.BridgeValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 5 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.MinisterValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 6 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.KingValue) * Sign), Single)
						End If
					End If
					If Tab(i, j) > 0 Then
						Order = 1
						ChessRules.CurrentOrder = 1
						a = Color.Gray
					ElseIf Tab(i, j) < 0 Then
						Order = -1
						ChessRules.CurrentOrder = -1
						a = Color.Brown
					End If

					If (New ThinkingChess(iii, jjj)).Attack(Tab, i, j, iii, jjj, a, _
						Order) Then
						Sign = 999 * AllDraw.SignHitting
						If System.Math.Abs(Table(iii, jjj)) = 1 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.SodierValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 2 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.ElefantValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 3 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.HourseValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 4 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.BridgeValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 5 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.MinisterValue) * Sign), Single)
						ElseIf System.Math.Abs(Table(iii, jjj)) = 6 Then
							HA += CType(((System.Math.Abs(Tab(ii, jj)) - AllDraw.KingValue) * Sign), Single)
						End If
					End If



					a = colorAS
					Order = CDummyOrder
					ChessRules.CurrentOrder = CCurrentDummy
					HuristicValue += HA * SignOrderToPlate(Order)
					jjj += 1
				End While
				iii += 1
			End While
		End Sub
		'''Huristic of Suportation.
		Function HuristicSupported(Tab As Integer(,), Order As Integer, a As Color) As Single
			'Initiate Local Vrariables.
			Dim HA As Integer = 0
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'If There is Not Dept Huristic Boolean Value.
			If Not DeptHuristic Then
				'For Current Object Lcation.
				Dim i As Integer = Row, j As Integer = Column
				'In All Homes of Table.
				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						'Ignore Current Unnessery Home.
						If i = ii AndAlso j = jj Then
							Continue While
						End If
						'Default Is Gray One.
						Dim Sign As Integer = 1
						Order = DummyOrder
						'''When Supporte is true. means [ii,jj] is in Supportes [i,j].
						'''What is Supporte!
						'''Ans:When [i,j] is Supporte [ii,jj] return true when Self is located in [ii,jj].
						If Table(ii, jj) < 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
							Order = -1
							Sign = 1 * AllDraw.SignSupport
							ChessRules.CurrentOrder = -1
							a = Color.Brown
						ElseIf Table(ii, jj) > 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
							Order = 1
							Sign = 1 * AllDraw.SignSupport
							ChessRules.CurrentOrder = 1
							a = Color.Gray
						Else
							'else
'                            if (Table[ii, jj] > 0 && DummyOrder == -1 && Table[i, j] > 0)
'                            {
'                                Order = 1;
'                                Sign = -1 * AllDraw.SignSupport;
'                                ChessRules.CurrentOrder = 1;
'                                a = Color.Gray;
'                            }
'                            else if (Table[ii, jj] < 0 && DummyOrder == 1 && Table[i, j] < 0)
'                            {
'                                Order = -1;
'                                Sign = -1 * AllDraw.SignSupport;
'                                ChessRules.CurrentOrder = -1;
'                                a = Color.Brown;
'                            }

							Continue While
						End If
						'For Support Movments.
						If Support(Tab, ii, jj, i, j, a, _
							Order) Then
							'Calculate Local Support Huristic.
							If True Then

								If System.Math.Abs(Table(i, j)) = 1 Then
									HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 2 Then
									HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 3 Then
									HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 4 Then
									HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 5 Then
									HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 6 Then
									HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
								End If

							End If


						End If
						jj += 1
					End While
					ii += 1

				End While
			Else
				'For All Homes Table.
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								'Ignore Current Home.
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								'Initiate Local Variables.
								Dim Sign As Integer = 1
								Order = DummyOrder
								'''When Supporte is true. means [ii,jj] is in Supported.by [i,j].
								'''What is Supporte!
								'''Ans:When [i,j] is Supporte [ii,jj] return true when Self is located in [ii,jj].
								If Table(ii, jj) < 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
									Order = -1
									Sign = 1 * AllDraw.SignSupport
									ChessRules.CurrentOrder = -1
									a = Color.Brown
								ElseIf Table(ii, jj) > 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
									Order = 1
									Sign = 1 * AllDraw.SignSupport
									ChessRules.CurrentOrder = 1
									a = Color.Gray
								Else
									' else
'                                     if (Table[ii, jj] > 0 && DummyOrder == -1 && Table[i, j] > 0)
'                                     {
'                                         Order = 1;
'                                         Sign = -1 * AllDraw.SignSupport;
'                                         ChessRules.CurrentOrder = 1;
'                                         a = Color.Gray;
'                                     }
'                                     else if (Table[ii, jj] < 0 && DummyOrder == 1 && Table[i, j] < 0)
'                                     {
'                                         Order = -1;
'                                         Sign = -1 * AllDraw.SignSupport;
'                                         ChessRules.CurrentOrder = -1;
'                                         a = Color.Brown;
'                                     }

									Continue While
								End If
								'For Support Movments.
								If Support(Table, ii, jj, i, j, a, _
									Order) Then
									If True Then
										If System.Math.Abs(Table(i, j)) = 1 Then
											HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 2 Then
											HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 3 Then
											HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 4 Then
											HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 5 Then
											HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 6 Then
											HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
										End If


									End If
								End If
								jj += 1
							End While
							ii += 1
						End While
						j += 1
					End While
					i += 1
				End While
			End If
			'Reassignments of Global Orders with Local Begining One.
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder
			HuristicValueSupported += HA * SignOrderToPlate(Order)
			Return HA
		End Function
		'''Identification of Equality
		Public Shared Function TableEqual(Tab1 As Integer(,), Tab2 As Integer(,)) As Boolean
			Try
				'For All Home
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						'When there is different values in same location of tow Table return non equality.
						If Tab1(i, j) <> Tab2(i, j) Then
							Return False
						End If
						j += 1
					End While
					i += 1
				End While
				'Else return equlity.
				Return True
			Catch t As Exception
				Log(t)
				Return False
			End Try
		End Function
		'''Deterimination of Existance of Table in List.
		Public Shared Function ExistTableInList(Tab As Integer(,), List As List(Of Integer(,)), Index As Integer) As Boolean
			'Initiate Local Variables.
			Dim Exist As Boolean = False
			'For All Tables of Table List.
			Dim i As Integer = Index
			While i < List.Count
				'Strore Equality Value.
				Dim Eq As Boolean = TableEqual(Tab, List(i))
				'When is Equality is Occurred.
				If Eq Then
					'Store Equality Local Value in a Global static value.
					AllDraw.LoopHuristicIndex = i
					Return Eq
				End If
				Exist = Exist Or Eq
				i += 1
			End While
			'return Equality Local value of all lists.
			Return Exist
		End Function

		'''Move Determination.
		Public Function Movable(Table As Integer(,), i As Integer, j As Integer, ii As Integer, jj As Integer, a As Color, _
			Order As Integer) As Boolean
			'Initiate Local Variables.
			Dim Store As Integer = Table(ii, jj)
			'''Table[ii, jj] = 0;
			'Menen Parameter is Moveble to Second Parameters Location returm Movable.
			If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Order) Then
				'Initiate Movments.
				Table(ii, jj) = 0
				Table(ii, jj) = Table(i, j)
				'Default Order Assignments.
				Dim Ord As Integer = 1
				'Brown Order Consideration.
				If Table(ii, jj) < 0 Then
					Ord = -1
				End If
				'Store of Local Order Assignments in Global Assignments.
				Dim Dummy As Integer = ChessRules.CurrentOrder
				ChessRules.CurrentOrder = Ord
				'Consider Global Kish Variables.
				(New ChessRules(Table(ii, jj), Table, Ord, Row, Column)).Kish(Table, Ord)
				'Reaasignment of Premitive Variables.
				ChessRules.CurrentOrder = Dummy
				'Reassignments of Table Content and Consider Mate Specific Order.
				Table(i, j) = Table(ii, jj)

				If Table(i, j) > 0 Then
					Table(ii, jj) = Store
					If ChessRules.MateGray Then
						Return False
					End If


					Return True
				End If


				If Table(i, j) < 0 Then
					Table(ii, jj) = Store
					If ChessRules.MateBrown Then
						Return False
					End If
					Return True


				End If
			End If

			Table(ii, jj) = Store
			Return False
		End Function
		Function SignOrderToPlate(Order As Integer) As Double
			Dim Sign As Double = 1.0
			If Order = FormRefrigtz.OrderPlate Then
				Sign = 1.0
			ElseIf Order <> FormRefrigtz.OrderPlate Then
				Sign = -1.0
			End If
			Return Sign

		End Function
		'''Huristic of Kish and Mate.
		Public Sub HuristicKishAndMate(Table As Integer(,), a As Color)
			If DeptHuristic Then
				'Consider Global Kish Mate Achmaz Variables Orderly.
				(New ChessRules(1, Table, Order, Row, Column)).Mate(Table, Order)
				(New ChessRules(1, Table, Order, Row, Column)).AchmazKingMove(Order, Table, False)
				If True Then
					'Consider Value to More Valuable Positive and Negative Kish Mate Achmaz 
					If ChessRules.MateGray OrElse ChessRules.MateBrown Then
						If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.MateBrown Then
							HuristicValueAchmazKishMate += 99999999
							ThinkingChess.MovementsDeptHuristicFound = True
						End If
						If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.MateGray Then
							HuristicValueAchmazKishMate += 99999999
							ThinkingChess.MovementsDeptHuristicFound = True
						End If
					End If

					If ChessRules.KishGray OrElse ChessRules.KishBrown Then

						If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishBrown Then
							HuristicValueAchmazKishMate += 99
							ThinkingChess.MovementsDeptHuristicFound = True
						End If
						If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGray Then
							HuristicValueAchmazKishMate += 99
							ThinkingChess.MovementsDeptHuristicFound = True
						End If
					End If

					If ChessRules.KishGrayAchmaz OrElse ChessRules.KishBrownAchmaz Then

						If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishBrownAchmaz Then
							HuristicValueAchmazKishMate += 9
							ThinkingChess.MovementsDeptHuristicFound = True
						End If
						If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishGrayAchmaz Then
							HuristicValueAchmazKishMate += 9
							ThinkingChess.MovementsDeptHuristicFound = True
						End If
					End If
					If ChessRules.MateGray OrElse ChessRules.MateBrown Then

						If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.MateGray Then
							HuristicValueAchmazKishMate -= 99999999
						End If
						If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.MateBrown Then
							HuristicValueAchmazKishMate -= 99999999
						End If
					End If

					If ChessRules.KishGray OrElse ChessRules.KishBrown Then

						If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGray Then
							HuristicValueAchmazKishMate -= 99
						End If
						If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishBrown Then
							HuristicValueAchmazKishMate -= 99
						End If
					End If
					If ChessRules.KishBrownAchmaz OrElse ChessRules.KishGrayAchmaz Then

						If FormRefrigtz.OrderPlate = 1 AndAlso ChessRules.KishGrayAchmaz Then
							HuristicValueAchmazKishMate -= 9
						End If
						If FormRefrigtz.OrderPlate = -1 AndAlso ChessRules.KishBrownAchmaz Then
							HuristicValueAchmazKishMate -= 9
						End If
					End If

				End If
			End If
		End Sub
		'''Huristic of Movments.
		Public Function HuristicMovment(Table As Integer(,), a As Color) As Single
			'Initiate Local Variable.
			Dim HA As Integer = 0
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'''When Dept Huristic is Not Assigned.
			If Not DeptHuristic Then
				'''For Current Objects.
				Dim i As Integer = Row, j As Integer = Column
				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						If i = ii AndAlso j = jj Then
							Continue While
						End If
						Order = DummyOrder
						Dim Sign As Integer = 1
						'''When Moveble is true. means [i,j] is in Movmebale to [ii,jj].
						'''What is Moveable!
						'''Ans:When [i,j] is Movebale to [ii,jj] return true when Empty or Enemy is located in [ii,jj].
						If Table(ii, jj) >= 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
							Order = -1
							Sign = 1 * AllDraw.SignMovments
							ChessRules.CurrentOrder = -1
							a = Color.Brown
						ElseIf Table(ii, jj) <= 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
							Order = 1
							Sign = 1 * AllDraw.SignMovments
							ChessRules.CurrentOrder = 1
							a = Color.Gray
						Else
							'else
'                            if (Table[ii, jj] <= 0 && DummyOrder == -1 && Table[i, j] > 0)
'                            {
'                                Order = 1;
'                                Sign = -1 * AllDraw.SignMovments;
'                                ChessRules.CurrentOrder = 1;
'                                a = Color.Gray;
'                            }
'                            else if (Table[ii, jj] >= 0 && DummyOrder == 1 && Table[i, j] < 0)
'                            {
'                                Order = -1;
'                                Sign = -1 * AllDraw.SignMovments;
'                                ChessRules.CurrentOrder = -1;
'                                a = Color.Brown;
'                            }

							Continue While
						End If
						'When is Movable Movement inCurrent.
						If Movable(Table, i, j, ii, jj, a, _
							Order) Then
							'Calculate Local Huristic Sumation.
							If True Then
								If System.Math.Abs(Table(i, j)) = 1 Then
									HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 2 Then
									HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 3 Then
									HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 4 Then
									HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 5 Then
									HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
								ElseIf System.Math.Abs(Table(i, j)) = 6 Then
									HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
								End If
								Dim iii As Integer = 0
								While iii < 8
									Dim jjj As Integer = 0
									While jjj < 8
										If iii = i AndAlso iii = j Then
											Continue While
										End If
										If ii = i AndAlso jj = j Then
											Continue While
										End If
										If Table(iii, jjj) < 0 Then
											Order = -1
											Sign = -1 * AllDraw.SignMovments
											ChessRules.CurrentOrder = -1
											a = Color.Brown
										ElseIf Table(iii, jjj) > 0 Then
											Order = 1
											Sign = -1 * AllDraw.SignMovments
											ChessRules.CurrentOrder = 1
											a = Color.Gray
										End If
										If Attack(Table, iii, jjj, i, j, a, _
											Order) Then
											If System.Math.Abs(Table(iii, jjj)) = 1 Then
												HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(i, j)))
											ElseIf System.Math.Abs(Table(iii, jjj)) = 2 Then
												HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(i, j)))
											ElseIf System.Math.Abs(Table(iii, jjj)) = 3 Then
												HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(i, j)))
											ElseIf System.Math.Abs(Table(iii, jjj)) = 4 Then
												HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(i, j)))
											ElseIf System.Math.Abs(Table(iii, jjj)) = 5 Then
												HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(i, j)))
											ElseIf System.Math.Abs(Table(iii, jjj)) = 6 Then
												HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(i, j)))

											End If
										End If
										jjj += 1
									End While
									iii += 1
								End While
							End If

						End If
						jj += 1
					End While
					ii += 1

				End While
			Else
				'For All Homes Table.
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								Dim Sign As Integer = 1
								Order = DummyOrder
								'''When Moveble is true. means [i,j] is in Movmebale to [ii,jj].
								'''What is Moveable!
								'''Ans:When [i,j] is Movebale to [ii,jj] return true when Empty or Enemy is located in [ii,jj].
								If Table(ii, jj) >= 0 AndAlso DummyOrder = -1 AndAlso Table(i, j) < 0 Then
									Order = -1
									Sign = 1 * AllDraw.SignMovments
									ChessRules.CurrentOrder = -1
									a = Color.Brown
								ElseIf Table(ii, jj) <= 0 AndAlso DummyOrder = 1 AndAlso Table(i, j) > 0 Then
									Order = 1
									Sign = 1 * AllDraw.SignMovments
									ChessRules.CurrentOrder = 1
									a = Color.Gray
								Else
									'else
'                                    if (Table[ii, jj] <= 0 && DummyOrder == -1 && Table[i, j] > 0)
'                                    {
'                                        Order = 1;
'                                        Sign = -1 * AllDraw.SignMovments;
'                                        ChessRules.CurrentOrder = 1;
'                                        a = Color.Gray;
'                                    }
'                                    else if (Table[ii, jj] >= 0 && DummyOrder == 1 && Table[i, j] < 0)
'                                    {
'                                        Order = -1;
'                                        Sign = -1 * AllDraw.SignMovments;
'                                        ChessRules.CurrentOrder = -1;
'                                        a = Color.Brown;
'                                    }

									Continue While
								End If
								'If Current Home is Moveble.
								If Movable(Table, i, j, ii, jj, a, _
									Order) Then
									'Caculate Local Huristic.
									If True Then
										If System.Math.Abs(Table(i, j)) = 1 Then
											HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 2 Then
											HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 3 Then
											HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 4 Then
											HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 5 Then
											HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(ii, jj)))
										ElseIf System.Math.Abs(Table(i, j)) = 6 Then
											HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(ii, jj)))
										End If
										Dim iii As Integer = 0
										While iii < 8
											Dim jjj As Integer = 0
											While jjj < 8
												If iii = i AndAlso iii = j Then
													Continue While
												End If
												If ii = i AndAlso jj = j Then
													Continue While
												End If
												If Table(iii, jjj) < 0 Then
													Order = -1
													Sign = -1 * AllDraw.SignMovments
													ChessRules.CurrentOrder = -1
													a = Color.Brown
												ElseIf Table(iii, jjj) > 0 Then
													Order = 1
													Sign = -1 * AllDraw.SignMovments
													ChessRules.CurrentOrder = 1
													a = Color.Gray
												End If
												If Attack(Table, iii, jjj, i, j, a, _
													Order) Then
													If System.Math.Abs(Table(iii, jjj)) = 1 Then
														HA += Sign * System.Math.Abs(AllDraw.SodierValue - System.Math.Abs(Table(i, j)))
													ElseIf System.Math.Abs(Table(iii, jjj)) = 2 Then
														HA += Sign * System.Math.Abs(AllDraw.ElefantValue - System.Math.Abs(Table(i, j)))
													ElseIf System.Math.Abs(Table(iii, jjj)) = 3 Then
														HA += Sign * System.Math.Abs(AllDraw.HourseValue - System.Math.Abs(Table(i, j)))
													ElseIf System.Math.Abs(Table(iii, jjj)) = 4 Then
														HA += Sign * System.Math.Abs(AllDraw.BridgeValue - System.Math.Abs(Table(i, j)))
													ElseIf System.Math.Abs(Table(iii, jjj)) = 5 Then
														HA += Sign * System.Math.Abs(AllDraw.MinisterValue - System.Math.Abs(Table(i, j)))
													ElseIf System.Math.Abs(Table(iii, jjj)) = 6 Then
														HA += Sign * System.Math.Abs(AllDraw.KingValue - System.Math.Abs(Table(i, j)))

													End If
												End If
												jjj += 1
											End While
											iii += 1
										End While
									End If

								End If
								jj += 1
							End While
							ii += 1
						End While
						j += 1
					End While
					i += 1
				End While
			End If
			'Reassignments of Begin Call Global Orders.
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder
			'Store Local Huristic in Global One.
			HuristicValueMovement += HA * SignOrderToPlate(Order)
			'Return Local Huristic.
			Return HA

		End Function

		'''Attack Determination.
		Public Function Attack(Table As Integer(,), i As Integer, j As Integer, ii As Integer, jj As Integer, a As Color, _
			Order As Integer) As Boolean
			If Table(ii, jj) = -6 Then
				If System.Math.Abs(i - ii) = 1 AndAlso System.Math.Abs(j - jj) = 1 AndAlso j < jj Then
					If Table(ii, jj) = -6 Then
						Return True
					End If
				End If
			ElseIf Table(ii, jj) = 6 Then
				If System.Math.Abs(i - ii) = 1 AndAlso System.Math.Abs(j - jj) = 1 AndAlso j > jj Then
					If Table(ii, jj) = 6 Then
						Return True
					End If
				End If
			End If
			If Table(ii, jj) = -6 Then
				Table(ii, jj) = 0
				If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Order) Then
					Table(ii, jj) = -6
					Return True
				End If
				Table(ii, jj) = -6
			ElseIf Table(ii, jj) = 6 Then
				Table(ii, jj) = 0
				If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Order) Then
					Table(ii, jj) = 6
					Return True
				End If
				Table(ii, jj) = 6
			End If
			'Initiate Global static  Variable.
			'when there is a Movment from Parameter One to Second Parameter return Attacke..
			If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Order) Then
				Return True
			End If
			Return False
		End Function
		'''Achmaz Determination.
		Public Function Achmaz(Tab As Integer(,), i As Integer, j As Integer, ii As Integer, jj As Integer, a As Color, _
			Order As Integer) As Boolean
			'Initiate Local Varibales.
			Dim Table As Integer(,) = New Integer(8, 8) {}
			Dim iii As Integer = 0
			While iii < 8
				Dim jjj As Integer = 0
				While jjj < 8
					Table(iii, jjj) = Tab(iii, jjj)
					jjj += 1
				End While
				iii += 1
			End While
			Table(ii, jj) = 0
			'''When [i,j] is Attacked [ii,jj] reterun true when enemy is located in [ii,jj].
			If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Order) Then
				'Initiate Local Variables.
				Dim iii As Integer = 0
				While iii < 8
					Dim jjj As Integer = 0
					While jjj < 8
						Table(iii, jjj) = Tab(iii, jjj)
						jjj += 1
					End While
					iii += 1
				End While
				'Take Movments.
				Table(ii, jj) = Table(i, j)
				Table(i, j) = 0
				'Consider Kish.
				If (New ChessRules(Table(ii, jj), Table, Order, Row, Column).Kish(Table, Order)) Then
					'Return Achmaz.
					Return True


				End If
			End If
			'return Non Achmaz.
			Return False
		End Function
		'''Supportation Determination.
		Public Function Support(Tab As Integer(,), i As Integer, j As Integer, ii As Integer, jj As Integer, a As Color, _
			Order As Integer) As Boolean
			'Initiate Local Variables.
			Dim Table As Integer(,) = New Integer(8, 8) {}

			Dim iii As Integer = 0
			While iii < 8
				Dim jjj As Integer = 0
				While jjj < 8
					Table(iii, jjj) = Tab(iii, jjj)
					jjj += 1
				End While
				iii += 1
			End While
			'''When All Tables is Gray.
			If Table(i, j) > 0 AndAlso Table(ii, jj) > 0 Then
				Dim Store As Integer = Table(ii, jj)
				Table(ii, jj) = 0
				'''When [i,j] Supporte [ii,jj].
				If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Order) Then
					Table(ii, jj) = Store
					Return True
				End If
				Table(ii, jj) = Store
			End If

			Dim iii As Integer = 0
			While iii < 8
				Dim jjj As Integer = 0
				While jjj < 8
					Table(iii, jjj) = Tab(iii, jjj)
					jjj += 1
				End While
				iii += 1
			End While
			'''When All is Brown.
			If Table(i, j) < 0 AndAlso Table(ii, jj) < 0 Then
				Dim Store As Integer = Table(ii, jj)
				Table(ii, jj) = 0
				'''When [i,j] Supporetd [ii,jj].
				If (New ChessRules(Table(i, j), Table, Order, Row, Column)).Rules(i, j, ii, jj, a, Table(i, j)) Then
					Table(ii, jj) = Store
					Return True
				End If
				Table(ii, jj) = Store
			End If

			Return False
		End Function
		Public Function ReturnHuristic(ii As Integer, j As Integer) As Double
			Dim Ki As Integer = Kind
			If Me.Dept Is Nothing Then

				Return 0
			End If
			Kind *= Sign
			Sign *= -1
			Dim a As Double = 0
			If j <> -1 Then
				If System.Math.Abs(Kind) = 1 Then
					Dim i As Integer = 0
					While i < HuristicListSolder.Count
						a += HuristicListSolder(i)(0) + HuristicListSolder(i)(1) + HuristicListSolder(i)(2) + HuristicListSolder(i)(3)

						Dim iii As Integer = 0
						While iii < Me.Dept.Count
							Try
								If FormRefrigtz.OrderPlate = 1 Then
									Kind = 1
									Dim h As Integer = 0
									While h < AllDraw.SodierHigh
										Try
											a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 2
									Dim h As Integer = 0
									While h < AllDraw.ElefantHigh
										Try
											a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 3
									Dim h As Integer = 0
									While h < AllDraw.HourseHight
										Try
											a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 4
									Dim h As Integer = 0
									While h < AllDraw.BridgeHigh
										Try
											a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 5
									Dim h As Integer = 0
									While h < AllDraw.MinisterHigh
										Try
											a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 6
									Dim h As Integer = 0
									While h < AllDraw.KingHigh
										Try
											a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
								Else
									If FormRefrigtz.OrderPlate = -1 Then
										Kind = -1
										Dim h As Integer = 0
										While h < AllDraw.SodierHigh
											Try
												a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -2
										Dim h As Integer = 0
										While h < AllDraw.ElefantHigh
											Try
												a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -3
										Dim h As Integer = 0
										While h < AllDraw.HourseHight
											Try
												a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -4
										Dim h As Integer = 0
										While h < AllDraw.BridgeHigh
											Try
												a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -5
										Dim h As Integer = 0
										While h < AllDraw.MinisterMidle
											Try
												a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -6
										Dim h As Integer = 0
										While h < AllDraw.KingHigh
											Try
												a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While

									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							iii += 1
						End While
						i += 1
					End While
				ElseIf System.Math.Abs(Kind) = 2 Then
					Dim i As Integer = 0
					While i < HuristicListElefant.Count
						a += HuristicListElefant(i)(0) + HuristicListElefant(i)(1) + HuristicListElefant(i)(2) + HuristicListElefant(i)(3)
						Dim iii As Integer = 0
						While iii < Me.Dept.Count
							Try
								If FormRefrigtz.OrderPlate = 1 Then
									Kind = 1
									Dim h As Integer = 0
									While h < AllDraw.SodierHigh
										Try
											a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 2
									Dim h As Integer = 0
									While h < AllDraw.ElefantHigh
										Try
											a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 3
									Dim h As Integer = 0
									While h < AllDraw.HourseHight
										Try
											a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 4
									Dim h As Integer = 0
									While h < AllDraw.BridgeHigh
										Try
											a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 5
									Dim h As Integer = 0
									While h < AllDraw.MinisterHigh
										Try
											a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 6
									Dim h As Integer = 0
									While h < AllDraw.KingHigh
										Try
											a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
								Else
									If FormRefrigtz.OrderPlate = -1 Then
										Kind = -1
										Dim h As Integer = 0
										While h < AllDraw.SodierHigh
											Try
												a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -2
										Dim h As Integer = 0
										While h < AllDraw.ElefantHigh
											Try
												a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -3
										Dim h As Integer = 0
										While h < AllDraw.HourseHight
											Try
												a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -4
										Dim h As Integer = 0
										While h < AllDraw.BridgeHigh
											Try
												a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -5
										Dim h As Integer = 0
										While h < AllDraw.MinisterMidle
											Try
												a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -6
										Dim h As Integer = 0
										While h < AllDraw.KingHigh
											Try
												a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While

									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							iii += 1
						End While
						i += 1
					End While
				ElseIf System.Math.Abs(Kind) = 3 Then
					Dim i As Integer = 0
					While i < HuristicListHourse.Count
						a += HuristicListHourse(i)(0) + HuristicListHourse(i)(1) + HuristicListHourse(i)(2) + HuristicListHourse(i)(3)
						Dim iii As Integer = 0
						While iii < Me.Dept.Count
							Try
								If FormRefrigtz.OrderPlate = 1 Then
									Kind = 1
									Dim h As Integer = 0
									While h < AllDraw.SodierHigh
										Try
											a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 2
									Dim h As Integer = 0
									While h < AllDraw.ElefantHigh
										Try
											a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 3
									Dim h As Integer = 0
									While h < AllDraw.HourseHight
										Try
											a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 4
									Dim h As Integer = 0
									While h < AllDraw.BridgeHigh
										Try
											a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 5
									Dim h As Integer = 0
									While h < AllDraw.MinisterHigh
										Try
											a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 6
									Dim h As Integer = 0
									While h < AllDraw.KingHigh
										Try
											a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
								Else
									If FormRefrigtz.OrderPlate = -1 Then
										Kind = -1
										Dim h As Integer = 0
										While h < AllDraw.SodierHigh
											Try
												a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -2
										Dim h As Integer = 0
										While h < AllDraw.ElefantHigh
											Try
												a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -3
										Dim h As Integer = 0
										While h < AllDraw.HourseHight
											Try
												a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -4
										Dim h As Integer = 0
										While h < AllDraw.BridgeHigh
											Try
												a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -5
										Dim h As Integer = 0
										While h < AllDraw.MinisterMidle
											Try
												a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -6
										Dim h As Integer = 0
										While h < AllDraw.KingHigh
											Try
												a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While

									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							iii += 1
						End While
						i += 1
					End While
				ElseIf System.Math.Abs(Kind) = 4 Then
					Dim i As Integer = 0
					While i < HuristicListBridge.Count
						a += HuristicListBridge(i)(0) + HuristicListBridge(i)(1) + HuristicListBridge(i)(2) + HuristicListBridge(i)(3)
						Dim iii As Integer = 0
						While iii < Me.Dept.Count
							Try
								If FormRefrigtz.OrderPlate = 1 Then
									Kind = 1
									Dim h As Integer = 0
									While h < AllDraw.SodierHigh
										Try
											a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 2
									Dim h As Integer = 0
									While h < AllDraw.ElefantHigh
										Try
											a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 3
									Dim h As Integer = 0
									While h < AllDraw.HourseHight
										Try
											a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 4
									Dim h As Integer = 0
									While h < AllDraw.BridgeHigh
										Try
											a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 5
									Dim h As Integer = 0
									While h < AllDraw.MinisterHigh
										Try
											a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 6
									Dim h As Integer = 0
									While h < AllDraw.KingHigh
										Try
											a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
								Else
									If FormRefrigtz.OrderPlate = -1 Then
										Kind = -1
										Dim h As Integer = 0
										While h < AllDraw.SodierHigh
											Try
												a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -2
										Dim h As Integer = 0
										While h < AllDraw.ElefantHigh
											Try
												a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -3
										Dim h As Integer = 0
										While h < AllDraw.HourseHight
											Try
												a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -4
										Dim h As Integer = 0
										While h < AllDraw.BridgeHigh
											Try
												a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -5
										Dim h As Integer = 0
										While h < AllDraw.MinisterMidle
											Try
												a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -6
										Dim h As Integer = 0
										While h < AllDraw.KingHigh
											Try
												a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While

									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							iii += 1
						End While
						i += 1
					End While
				ElseIf System.Math.Abs(Kind) = 5 Then
					Dim i As Integer = 0
					While i < HuristicListMinister.Count
						a += HuristicListMinister(i)(0) + HuristicListMinister(i)(1) + HuristicListMinister(i)(2) + HuristicListMinister(i)(3)
						Dim iii As Integer = 0
						While iii < Me.Dept.Count
							Try
								If FormRefrigtz.OrderPlate = 1 Then
									Kind = 1
									Dim h As Integer = 0
									While h < AllDraw.SodierHigh
										Try
											a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 2
									Dim h As Integer = 0
									While h < AllDraw.ElefantHigh
										Try
											a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 3
									Dim h As Integer = 0
									While h < AllDraw.HourseHight
										Try
											a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 4
									Dim h As Integer = 0
									While h < AllDraw.BridgeHigh
										Try
											a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 5
									Dim h As Integer = 0
									While h < AllDraw.MinisterHigh
										Try
											a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 6
									Dim h As Integer = 0
									While h < AllDraw.KingHigh
										Try
											a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
								Else
									If FormRefrigtz.OrderPlate = -1 Then
										Kind = -1
										Dim h As Integer = 0
										While h < AllDraw.SodierHigh
											Try
												a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -2
										Dim h As Integer = 0
										While h < AllDraw.ElefantHigh
											Try
												a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -3
										Dim h As Integer = 0
										While h < AllDraw.HourseHight
											Try
												a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -4
										Dim h As Integer = 0
										While h < AllDraw.BridgeHigh
											Try
												a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -5
										Dim h As Integer = 0
										While h < AllDraw.MinisterMidle
											Try
												a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -6
										Dim h As Integer = 0
										While h < AllDraw.KingHigh
											Try
												a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While


									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							iii += 1
						End While
						i += 1

					End While
				ElseIf System.Math.Abs(Kind) = 6 Then
					Dim i As Integer = 0
					While i < HuristicListKing.Count
						a += HuristicListKing(i)(0) + HuristicListKing(i)(1) + HuristicListKing(i)(2) + HuristicListKing(i)(3)
						Dim iii As Integer = 0
						While iii < Me.Dept.Count
							Try
								If FormRefrigtz.OrderPlate = 1 Then
									Kind = 1
									Dim h As Integer = 0
									While h < AllDraw.SodierHigh
										Try
											a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 2
									Dim h As Integer = 0
									While h < AllDraw.ElefantHigh
										Try
											a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 3
									Dim h As Integer = 0
									While h < AllDraw.HourseHight
										Try
											a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 4
									Dim h As Integer = 0
									While h < AllDraw.BridgeHigh
										Try
											a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 5
									Dim h As Integer = 0
									While h < AllDraw.MinisterHigh
										Try
											a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
									Kind = 6
									Dim h As Integer = 0
									While h < AllDraw.KingHigh
										Try
											a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
										Catch t As Exception
											Log(t)
										End Try
										h += 1
									End While
								Else
									If FormRefrigtz.OrderPlate = -1 Then
										Kind = -1
										Dim h As Integer = 0
										While h < AllDraw.SodierHigh
											Try
												a += Me.Dept(iii).SolderesOnTable(h).SoldierThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -2
										Dim h As Integer = 0
										While h < AllDraw.ElefantHigh
											Try
												a += Me.Dept(iii).ElephantOnTable(h).ElefantThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -3
										Dim h As Integer = 0
										While h < AllDraw.HourseHight
											Try
												a += Me.Dept(iii).HoursesOnTable(h).HourseThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -4
										Dim h As Integer = 0
										While h < AllDraw.BridgeHigh
											Try
												a += Me.Dept(iii).BridgesOnTable(h).BridgeThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -5
										Dim h As Integer = 0
										While h < AllDraw.MinisterMidle
											Try
												a += Me.Dept(iii).MinisterOnTable(h).MinisterThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While
										Kind = -6
										Dim h As Integer = 0
										While h < AllDraw.KingHigh
											Try
												a += Me.Dept(iii).KingOnTable(h).KingThinking(0).ReturnHuristic(i, j)
											Catch t As Exception
												Log(t)
											End Try
											h += 1
										End While

									End If
								End If
							Catch t As Exception
								Log(t)
							End Try
							iii += 1

						End While
						i += 1
					End While

				End If
			Else

				If System.Math.Abs(Kind) = 1 Then
					a += HuristicListSolder(j)(0) + HuristicListSolder(j)(1) + HuristicListSolder(j)(2) + HuristicListSolder(j)(3)
				ElseIf System.Math.Abs(Kind) = 2 Then
					a += HuristicListElefant(j)(0) + HuristicListElefant(j)(1) + HuristicListElefant(j)(2) + HuristicListElefant(j)(3)
				ElseIf System.Math.Abs(Kind) = 3 Then
					a += HuristicListHourse(j)(0) + HuristicListHourse(j)(1) + HuristicListHourse(j)(2) + HuristicListHourse(j)(3)
				ElseIf System.Math.Abs(Kind) = 4 Then
					a += HuristicListBridge(j)(0) + HuristicListBridge(j)(1) + HuristicListBridge(j)(2) + HuristicListBridge(j)(3)
				ElseIf System.Math.Abs(Kind) = 5 Then
					a += HuristicListMinister(j)(0) + HuristicListMinister(j)(1) + HuristicListMinister(j)(2) + HuristicListMinister(j)(3)
				ElseIf System.Math.Abs(Kind) = 6 Then
					a += HuristicListKing(j)(0) + HuristicListKing(j)(1) + HuristicListKing(j)(2) + HuristicListKing(j)(3)
				End If
			End If
			Kind = Ki
			Return a
		End Function
		Function Scop(i As Integer, j As Integer, ii As Integer, jj As Integer, Kind As Integer) As Boolean
			Dim Validity As Boolean = False
			If Kind = 1 Then
				'Sodier
				If System.Math.Abs(i - ii) <= 2 AndAlso System.Math.Abs(j - jj) <= 2 Then
					Validity = True
				End If
			ElseIf Kind = 2 Then
				'Elephant
				If System.Math.Abs(i - ii) = System.Math.Abs(j - jj) Then

					Validity = True
				End If
			ElseIf Kind = 3 Then
				If System.Math.Abs(i - ii) <= 2 AndAlso System.Math.Abs(j - jj) <= 2 Then
					Validity = True
				End If
			ElseIf Kind = 4 Then
				If (i = ii AndAlso j <> jj) OrElse (i <> ii AndAlso j = jj) Then
					Validity = True
				End If
			ElseIf Kind = 5 Then
				If ((i = ii AndAlso j <> jj) OrElse (i <> ii AndAlso j = jj)) OrElse System.Math.Abs(i - ii) = System.Math.Abs(j - jj) Then
					Validity = True
				End If
			ElseIf Kind = 6 Then
				If System.Math.Abs(i - ii) <= 1 AndAlso System.Math.Abs(j - jj) <= 1 Then
					Validity = True
				End If
			End If
			Return Validity
		End Function

		'''Kernel of Thinking
		Public Sub Thinking()
			Dim DummyOrder As Integer = Order
			Dim DummyCurrentOrder As Integer = ChessRules.CurrentOrder
			'Initiate Locallly Global Variables. 
			TableListSolder.Clear()
			TableListElefant.Clear()
			TableListHourse.Clear()
			TableListBridge.Clear()
			TableListMinister.Clear()
			TableListKing.Clear()
			HuristicListBridge.Clear()
			HuristicListElefant.Clear()
			HuristicListHourse.Clear()
			HuristicListKing.Clear()
			HuristicListMinister.Clear()
			HuristicListSolder.Clear()
			RowColumnSoldier.Clear()
			RowColumnElefant.Clear()
			RowColumnHourse.Clear()
			RowColumnBridge.Clear()
			RowColumnMinister.Clear()
			RowColumnKing.Clear()
			HitNumberSoldier.Clear()
			HitNumberElefant.Clear()
			HitNumberHourse.Clear()
			HitNumberBridge.Clear()
			HitNumberMinister.Clear()
			HitNumberKing.Clear()

			IndexSoldier = 0
			IndexElefant = 0
			IndexHourse = 0
			IndexBridge = 0
			IndexMinister = 0
			IndexKing = 0
			If True Then
				'''For Stored Location of Objects.
				Dim ii As Integer = Row
				Dim jj As Integer = Column
				If True Then
					If True Then
						'''For Every Tables Home.
						Dim i As Integer = 0
						While i < 8
							Dim j As Integer = 0
							While j < 8
								'''Current is Ignored for Increased of Performance.
								If ii = i AndAlso jj = j Then
									Continue While
								End If
								HuristicValue = New Double()
								HuristicValueMovement = New Double()
								HuristicValueSupported = New Double()
								HuristicValueAchmazKishMate = New Double()

								If IgnoreSelfObjects Then
									If Kind > 0 AndAlso Table(i, j) > 0 Then
										Continue While
									End If
									If Kind < 0 AndAlso Table(i, j) < 0 Then
										Continue While
									End If
								End If
								'''Initiate a Local Variables.
								Dim TableS As Integer(,) = New Integer(8, 8) {}
								'''"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
								Dim Current As New QuantumAtamata(3, 3, 3)
								'''Most Dot Net FrameWork Hot Path
								'''Create A Clone of Current Table Constant in ThinkingChess Object Tasble.
								Dim iii As Integer = 0
								While iii < 8
									Dim jjj As Integer = 0
									While jjj < 8
										TableS(iii, jjj) = TableConst(iii, jjj)
										jjj += 1
									End While
									iii += 1
								End While
								'''Deterimine Current Table Order and Color.
								If TableS(ii, jj) > 0 AndAlso CurrentArray < ThingsNumber / 2 AndAlso Order = 1 Then
									color = Color.Gray
								ElseIf TableS(ii, jj) < 0 AndAlso CurrentArray >= ThingsNumber / 2 AndAlso Order = -1 Then
									color = Color.Brown
								Else
									If Not ThinkingBegin Then
										ThinkingFinished = True
										'ThinkingRun = false;
										Return
									End If
									Continue While
								End If

								'''Ignore of Additinal Non Profit Objects and Empty Home. 
								If Order = 1 AndAlso TableS(i, j) > 0 Then
									Continue While
								End If
								If Order = -1 AndAlso TableS(i, j) < 0 Then
									Continue While
								End If
								If Order = 1 AndAlso TableS(ii, jj) < 0 Then
									Continue While
								End If
								If Order = -1 AndAlso TableS(ii, jj) > 0 Then
									Continue While
								End If
								'''Deterimine for Bridge King Wrongly Desision.
								Dim Bridge As Boolean = False
								ChessRules.ExistInDestinationEnemy = False
								'''Calculate Bridges of Gray King.
								If Not ChessRules.BridgeActGray AndAlso Order = 1 AndAlso TableS(ii, jj) = 6 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'When is Bridges Gray King.
									If (New ChessRules(7, TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, 7) Then
										'Predict Huristic Caluculatio Before Movments.
										ThinkingRun = True
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicReducsedAttack(TableS, Order, color)
										'Act Movments.
										If i < ii Then
											TableS(ii - 1, j) = 4
											TableS(ii - 2, j) = 6
											TableS(ii, jj) = 0

											TableS(0, jj) = 0
										Else

											TableS(ii + 1, j) = 4
											TableS(ii + 2, j) = 6
											TableS(ii, jj) = 0

											TableS(7, jj) = 0
										End If
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'Store Movments Items.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnKing.Add([AS])
										RowColumn(Index, 0) = i
										RowColumn(Index, 1) = j

										Index += 1
										TableListKing.Add(TableS)
										IndexKing += 1
										Row = i
										Column = j
										'Calculate Movment Huristic After Movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)
											HuristicReducsedAttack(TableS, Order, color)
										End If
										'Calculate Huristic Sumaton and Stor Specificcaly.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListKing.Add(Hu)
										ChessRules.BridgeActGray = True

										Bridge = True
									End If
								'''Calculate of Bridges of Brown.
								ElseIf Not ChessRules.BridgeActBrown AndAlso Order = -1 AndAlso TableS(ii, jj) = -6 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'When is Brown Bridges King.
									If (New ChessRules(-7, TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, -7) Then
										'Calcuilate Huristic Before Movment.
										ThinkingRun = True
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicReducsedAttack(TableS, Order, color)
										'Act Movment.
										If i < ii Then
											TableS(ii - 1, j) = 4
											TableS(ii - 2, j) = 6
											TableS(ii, jj) = 0

											TableS(0, jj) = 0
										Else

											TableS(ii + 1, j) = 4
											TableS(ii + 2, j) = 6
											TableS(ii, jj) = 0

											TableS(7, jj) = 0
										End If

										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'Store Movments Items. 
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnKing.Add([AS])
										RowColumn(Index, 0) = i
										RowColumn(Index, 1) = j
										Index += 1
										TableListKing.Add(TableS)
										IndexKing += 1
										Row = i
										Column = j
										'Calculatre Huristic After Movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)
											HuristicReducsedAttack(TableS, Order, color)
										End If
										'Calculate Huristic Sumation and Store in Specific List.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListKing.Add(Hu)
										ChessRules.BridgeActBrown = True
										Bridge = True

									End If
								'''For Soldier Thinking
								ElseIf Scop(ii, jj, i, j, 1) AndAlso System.Math.Abs(TableS(ii, jj)) = 1 AndAlso System.Math.Abs(Kind) = 1 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'''When There is Movments.
									If (New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, TableS(ii, jj)) Then
										'''Calculate Hit Occured and Value of Object.
										Dim Hit As Boolean = False
										Dim HitNumber As Integer = TableS(i, j)
										If System.Math.Abs(TableS(i, j)) > 0 Then
											Hit = True
										End If
										'''Add Table to List of Private.
										HitNumberSoldier.Add(TableS(i, j))
										ThinkingRun = True
										'''Predict Huristic.
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicHitting(TableS, i, j, ii, jj, Order, _
											color, Hit)
										HuristicReducsedAttack(TableS, Order, color)
										'''Action of Movements.
										TableS(i, j) = TableS(ii, jj)
										TableS(ii, jj) = 0
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'''Consideration of Itterative Movments to ignore.
										If ThinkingChess.ExistTableInList(TableS, TableListSolder, 0) Then
											'''Set Predict Huristic and Movments Backward.
											TableS(ii, jj) = TableS(i, j)
											TableS(i, j) = 0
											HuristicValue = 0
											HuristicValueMovement = 0
											HuristicValueSupported = 0
											HuristicValueAchmazKishMate = 0
											HuristicReducsedAttack(TableS, Order, color)

											Continue While
										End If
										'''Operation of Penalty Regard Mechanisam on Kish and mate speciffically.
										If UsePenaltyRegardMechnisam Then
											Dim A As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
											If A.AchmazKingMove(Order, TableS, False) Then
												If Order = 1 AndAlso (ChessRules.KishGrayAchmaz) Then
													Current.LearningAlgorithmPenalty()
												ElseIf Order = -1 AndAlso (ChessRules.KishBrownAchmaz) Then
													Current.LearningAlgorithmPenalty()
												End If
												PenaltyRegardListSolder.Add(Current)
											Else
												PenaltyRegardListSolder.Add(Current)
											End If
										Else
											PenaltyRegardListSolder.Add(Current)
										End If
										'''Store of Indexes Changes and Table in specific List.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnSoldier.Add([AS])
										RowColumn(Index, 0) = i
										RowColumn(Index, 1) = j
										Index += 1
										TableListSolder.Add(TableS)
										IndexSoldier += 1
										Row = i
										Column = j
										'''Wehn Predict of Operation Do operate a Predict of this movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)
											HuristicReducsedAttack(TableS, Order, color)
										End If
										'''Calculate Huristic and Add to List Speciifically and Cal Syntax.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListSolder.Add(Hu)
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, 1, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, -1, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										End If

										AllDraw.SyntaxToWrite += "Huristic :" + (Hu(0) + Hu(1) + Hu(2) + Hu(3)).ToString()
									End If
								'''Else for Elephant Thinking.
								ElseIf Scop(ii, jj, i, j, 2) AndAlso System.Math.Abs(TableS(ii, jj)) = 2 AndAlso System.Math.Abs(Kind) = 2 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'''When There is Movments.
									If (New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, TableS(ii, jj)) Then
										'''Calculate Hit Occured and Value of Object.
										Dim Hit As Boolean = False
										Dim HitNumber As Integer = TableS(i, j)
										If System.Math.Abs(TableS(i, j)) > 0 Then
											Hit = True
										End If
										'''Add Table to List of Private.
										HitNumberElefant.Add(TableS(i, j))
										ThinkingRun = True
										'''Predict Huristic.
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicHitting(TableS, i, j, ii, jj, Order, _
											color, Hit)
										HuristicReducsedAttack(TableS, Order, color)
										'''Action of Movements.
										TableS(i, j) = TableS(ii, jj)
										TableS(ii, jj) = 0
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'''Consideration of Itterative Movments to ignore.
										If ThinkingChess.ExistTableInList(TableS, TableListElefant, 0) Then
											'''Set Predict Huristic and Movments Backward.
											TableS(ii, jj) = TableS(i, j)
											TableS(i, j) = 0
											HuristicValue = 0
											HuristicValueMovement = 0
											HuristicValueSupported = 0
											HuristicValueAchmazKishMate = 0

											Continue While
										End If
										'''Operation of Penalty Regard Mechanisam on Kish and mate speciffically.
										If UsePenaltyRegardMechnisam Then
											Dim A As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
											If A.AchmazKingMove(Order, TableS, False) Then
												If Order = 1 AndAlso (ChessRules.KishGrayAchmaz) Then
													Current.LearningAlgorithmPenalty()
												ElseIf Order = -1 AndAlso (ChessRules.KishBrownAchmaz) Then
													Current.LearningAlgorithmPenalty()
												End If
												PenaltyRegardListElefant.Add(Current)
											Else
												PenaltyRegardListElefant.Add(Current)
											End If
										Else
											PenaltyRegardListElefant.Add(Current)
										End If
										'''Store of Indexes Changes and Table in specific List.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnElefant.Add([AS])

										RowColumn(Index, 0) = i
										RowColumn(Index, 1) = j
										Index += 1
										TableListElefant.Add(TableS)
										IndexElefant += 1
										Row = i
										Column = j
										'''Wehn Predict of Operation Do operate a Predict of this movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)
											HuristicReducsedAttack(TableS, Order, color)
										End If
										'''Calculate Huristic and Add to List Speciifically and Cal Syntax.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListElefant.Add(Hu)
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, 2, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, -2, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										End If
										AllDraw.SyntaxToWrite += "Huristic :" + (Hu(0) + Hu(1) + Hu(2) + Hu(3)).ToString()
									End If
								'''Else for Hourse Thinking.
								ElseIf Scop(ii, jj, i, j, 3) AndAlso System.Math.Abs(TableS(ii, jj)) = 3 AndAlso System.Math.Abs(Kind) = 3 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'''When There is Movments.
									If (New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, TableS(ii, jj)) Then
										'''Calculate Hit Occured and Value of Object.
										Dim Hit As Boolean = False
										Dim HitNumber As Integer = TableS(i, j)
										If System.Math.Abs(TableS(i, j)) > 0 Then
											Hit = True
										End If
										'''Add Table to List of Private.
										HitNumberHourse.Add(TableS(i, j))
										ThinkingRun = True
										'''Predict Huristic.
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicHitting(TableS, i, j, ii, jj, Order, _
											color, Hit)
										HuristicReducsedAttack(TableS, Order, color)
										'''Action of Movements.
										TableS(i, j) = TableS(ii, jj)
										TableS(ii, jj) = 0
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'''Consideration of Itterative Movments to ignore.
										If ThinkingChess.ExistTableInList(TableS, TableListHourse, 0) Then
											'''Set Predict Huristic and Movments Backward.
											TableS(ii, jj) = TableS(i, j)
											TableS(i, j) = 0
											HuristicValue = 0
											HuristicValueMovement = 0
											HuristicValueSupported = 0
											HuristicValueAchmazKishMate = 0

											Continue While
										End If
										'''Operation of Penalty Regard Mechanisam on Kish and mate speciffically.
										If UsePenaltyRegardMechnisam Then
											Dim A As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
											If A.AchmazKingMove(Order, TableS, False) Then
												If Order = 1 AndAlso (ChessRules.KishGrayAchmaz) Then
													Current.LearningAlgorithmPenalty()
												ElseIf Order = -1 AndAlso (ChessRules.KishBrownAchmaz) Then
													Current.LearningAlgorithmPenalty()
												End If
												PenaltyRegardListHourse.Add(Current)
											Else
												PenaltyRegardListHourse.Add(Current)
											End If
										Else
											PenaltyRegardListHourse.Add(Current)
										End If
										'''Store of Indexes Changes and Table in specific List.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnHourse.Add([AS])

										ThinkingChess.RowColumn(Index, 0) = i
										ThinkingChess.RowColumn(Index, 1) = j
										Index += 1
										TableListHourse.Add(TableS)
										IndexHourse += 1
										Row = i
										Column = j
										'''Wehn Predict of Operation Do operate a Predict of this movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)
											HuristicReducsedAttack(TableS, Order, color)
										End If
										'Calculate Huristic and Add to List and Cal Syntax.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListHourse.Add(Hu)
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, 3, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, -3, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										End If
										AllDraw.SyntaxToWrite += "Huristic :" + (Hu(0) + Hu(1) + Hu(2) + Hu(3)).ToString()
									End If
								'''Else For Bridges Thinking.
								ElseIf Scop(ii, jj, i, j, 4) AndAlso System.Math.Abs(TableS(ii, jj)) = 4 AndAlso System.Math.Abs(Kind) = 4 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'''When There is Movments.
									If (New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, TableS(ii, jj)) Then
										'''Calculate Hit Occured and Value of Object.
										Dim Hit As Boolean = False
										Dim HitNumber As Integer = TableS(i, j)
										If System.Math.Abs(TableS(i, j)) > 0 Then
											Hit = True
										End If
										'''Add Table to List of Private.
										HitNumberBridge.Add(TableS(i, j))
										ThinkingRun = True
										'''Predict Huristic.
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicHitting(TableS, i, j, ii, jj, Order, _
											color, Hit)
										HuristicReducsedAttack(TableS, Order, color)
										'''Action of Movements.
										TableS(i, j) = TableS(ii, jj)
										TableS(ii, jj) = 0
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'''Consideration of Itterative Movments to ignore.
										If ExistTableInList(TableS, TableListBridge, 0) Then
											'''Set Predict Huristic and Movments Backward.
											TableS(ii, jj) = TableS(i, j)
											TableS(i, j) = 0
											HuristicValue = 0
											HuristicValueMovement = 0
											HuristicValueSupported = 0
											HuristicValueAchmazKishMate = 0
											HuristicReducsedAttack(TableS, Order, color)

											Continue While
										End If
										'''Operation of Penalty Regard Mechanisam on Kish and mate speciffically.
										If UsePenaltyRegardMechnisam Then
											Dim A As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
											If A.AchmazKingMove(Order, TableS, False) Then
												If Order = 1 AndAlso (ChessRules.KishGrayAchmaz) Then
													Current.LearningAlgorithmPenalty()
												ElseIf Order = -1 AndAlso (ChessRules.KishBrownAchmaz) Then
													Current.LearningAlgorithmPenalty()
												End If
												PenaltyRegardListBridge.Add(Current)
											Else
												PenaltyRegardListBridge.Add(Current)
											End If
										Else
											PenaltyRegardListBridge.Add(Current)
										End If
										'''Store of Indexes Changes and Table in specific List.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnBridge.Add([AS])
										ThinkingChess.RowColumn(Index, 0) = i
										ThinkingChess.RowColumn(Index, 1) = j
										Index += 1
										TableListBridge.Add(TableS)
										IndexBridge += 1
										Row = i
										Column = j
										'''Wehn Predict of Operation Do operate a Predict of this movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)

											HuristicReducsedAttack(TableS, Order, color)
										End If
										'''Calculate Huristic and Add to List Speciifically and Cal Syntax.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListBridge.Add(Hu)
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, 4, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, -4, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										End If
										AllDraw.SyntaxToWrite += "Huristic :" + (Hu(0) + Hu(1) + Hu(2) + Hu(3)).ToString()
									End If
								'''Else for Minister Thinkings.
								ElseIf Scop(ii, jj, i, j, 5) AndAlso System.Math.Abs(TableS(ii, jj)) = 5 AndAlso System.Math.Abs(Kind) = 5 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'''When There is Movments.
									If (New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, TableS(ii, jj)) Then
										'''Calculate Hit Occured and Value of Object.
										Dim Hit As Boolean = False
										Dim HitNumber As Integer = TableS(i, j)
										If System.Math.Abs(TableS(i, j)) > 0 Then
											Hit = True
										End If
										'''Add Table to List of Private.
										HitNumberMinister.Add(TableS(i, j))
										ThinkingRun = True
										'''Predict Huristic.
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicHitting(TableS, i, j, ii, jj, Order, _
											color, Hit)
										HuristicReducsedAttack(TableS, Order, color)
										'''Action of Movements.
										TableS(i, j) = TableS(ii, jj)
										TableS(ii, jj) = 0
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If
										'''Consideration of Itterative Movments to ignore.
										If ExistTableInList(TableS, TableListMinister, 0) Then
											'''Set Predict Huristic and Movments Backward.
											TableS(ii, jj) = TableS(i, j)
											TableS(i, j) = 0
											HuristicValue = 0
											HuristicValueMovement = 0
											HuristicValueSupported = 0
											HuristicValueAchmazKishMate = 0

											Continue While
										End If
										'''Operation of Penalty Regard Mechanisam on Kish and mate speciffically.
										If UsePenaltyRegardMechnisam Then
											Dim A As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
											If A.AchmazKingMove(Order, TableS, False) Then
												If Order = 1 AndAlso (ChessRules.KishGrayAchmaz) Then
													Current.LearningAlgorithmPenalty()
												ElseIf Order = -1 AndAlso (ChessRules.KishBrownAchmaz) Then
													Current.LearningAlgorithmPenalty()
												End If
												PenaltyRegardListMinister.Add(Current)
											Else
												PenaltyRegardListMinister.Add(Current)
											End If
										Else
											PenaltyRegardListMinister.Add(Current)
										End If
										'''Store of Indexes Changes and Table in specific List.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnMinister.Add([AS])
										RowColumn(Index, 0) = i
										RowColumn(Index, 1) = j
										Index += 1
										TableListMinister.Add(TableS)
										IndexMinister += 1
										Row = i
										Column = j
										'''Wehn Predict of Operation Do operate a Predict of this movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)
											HuristicReducsedAttack(TableS, Order, color)
										End If
										'''Calculate Huristic and Add to List Speciifically and Cal Syntax.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListMinister.Add(Hu)
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, 5, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, -5, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										End If
										AllDraw.SyntaxToWrite += "Huristic :" + (Hu(0) + Hu(1) + Hu(2) + Hu(3)).ToString()
									End If
								'''Else For Kings Thinkings.
								ElseIf Scop(ii, jj, i, j, 6) AndAlso System.Math.Abs(TableS(ii, jj)) = 6 AndAlso System.Math.Abs(Kind) = 6 Then
									Order = DummyOrder
									ChessRules.CurrentOrder = DummyCurrentOrder
									'''When There is Movments.
									If (New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)).Rules(ii, jj, i, j, color, TableS(ii, jj)) Then
										'''Calculate Hit Occured and Value of Object.
										Dim Hit As Boolean = False
										Dim HitNumber As Integer = TableS(i, j)
										If System.Math.Abs(TableS(i, j)) > 0 Then
											Hit = True
										End If
										'''Add Table to List of Private.
										HitNumberKing.Add(TableS(i, j))
										ThinkingRun = True
										'''Predict Huristic.
										HuristicAttack(TableS, Order, color)
										HuristicMovment(TableS, color)
										HuristicSupported(TableS, Order, color)
										HuristicKishAndMate(TableS, color)
										HuristicAchmaz(TableS, Order, color)
										HuristicHitting(TableS, i, j, ii, jj, Order, _
											color, Hit)
										HuristicReducsedAttack(TableS, Order, color)
										'''Action of Movements.
										TableS(i, j) = TableS(ii, jj)
										TableS(ii, jj) = 0

										'''Consideration of Itterative Movments to ignore.
										If ExistTableInList(TableS, TableListKing, 0) Then
											'''Set Predict Huristic and Movments Backward.
											TableS(ii, jj) = TableS(i, j)
											TableS(i, j) = 0
											HuristicValue = 0
											HuristicValueMovement = 0
											HuristicValueSupported = 0
											HuristicValueAchmazKishMate = 0

											Continue While
										End If
										Dim AA As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
										If AA.Kish(TableS, Order) Then
											If Order = 1 AndAlso ChessRules.KishGray Then
												Continue While
											End If
											If Order = -1 AndAlso ChessRules.KishBrown Then
												Continue While
											End If
										End If

										'''Operation of Penalty Regard Mechanisam on Kish and mate speciffically.
										If UsePenaltyRegardMechnisam Then
											Dim A As New ChessRules(TableS(ii, jj), TableS, Order, Row, Column)
											If A.AchmazKingMove(Order, TableS, False) Then
												If Order = 1 AndAlso (ChessRules.KishGrayAchmaz) Then
													Current.LearningAlgorithmPenalty()
												ElseIf Order = -1 AndAlso (ChessRules.KishBrownAchmaz) Then
													Current.LearningAlgorithmPenalty()
												End If
												PenaltyRegardListKing.Add(Current)
											Else
												PenaltyRegardListKing.Add(Current)
											End If
										Else
											PenaltyRegardListKing.Add(Current)
										End If

										'''Store of Indexes Changes and Table in specific List.
										Dim [AS] As Integer() = New Integer(2) {}
										[AS](0) = i
										[AS](1) = j
										RowColumnKing.Add([AS])
										RowColumn(Index, 0) = i
										RowColumn(Index, 1) = j
										Index += 1
										TableListKing.Add(TableS)
										IndexKing += 1
										Row = i
										Column = j
										'''Wehn Predict of Operation Do operate a Predict of this movments.
										If PredictHuristic Then
											HuristicAttack(TableS, Order, color)
											HuristicMovment(TableS, color)
											HuristicSupported(TableS, Order, color)
											HuristicKishAndMate(TableS, color)
											HuristicAchmaz(TableS, Order, color)

											HuristicReducsedAttack(TableS, Order, color)
										End If
										'''Calculate Huristic and Add to List Speciifically and Cal Syntax.
										Dim Hu As Double() = New Double(4) {}
										Hu(0) = HuristicValue
										Hu(1) = HuristicValueMovement
										Hu(2) = HuristicValueSupported
										Hu(3) = HuristicValueAchmazKishMate
										HuristicListKing.Add(Hu)
										If Order = 1 Then
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, 6, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										Else
											AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(TableS, FormRefrigtz.MovmentsNumber, -6, j, i, Hit, _
												HitNumber, ChessRules.BridgeActBrown, False)
										End If

										AllDraw.SyntaxToWrite += "Huristic :" + (Hu(0) + Hu(1) + Hu(2) + Hu(3)).ToString()
									End If

								End If
								j += 1
							End While

							'''Wehn Thinkings finished by Movments found breaks.
							If ThinkingFinished Then
								Exit While

							End If
							i += 1
						End While

					End If
				End If
				'''Initiate Global Varibales at END.
				ThinkingBegin = False
				'''This Variable Not Work! 
				ThinkingFinished = True

			End If
			Order = DummyOrder
			ChessRules.CurrentOrder = DummyCurrentOrder

			'''Return at End.
			Return
		End Sub

	End Class
End Namespace