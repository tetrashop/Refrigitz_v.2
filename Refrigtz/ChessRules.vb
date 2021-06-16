Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'**********************************************************************************
' * Every Ruls of objective condition of chess game.*********************************
' * Current Rules Have not Attack Movements****************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Ramin Edjlal********************************************************************
' * Current Rules Have Not 'Kish' And 'Mate' *************************************RS*****0.12**4**Managements and Cuation Programing**(+*)QC-OK.
' * Elephant Rules Hardly*********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Horse Rules Hardly************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Minister Rules Hardly*********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * King Rules Hardly*************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Bridges Rules Hardly**********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Restricted has been solved****************************************************--**(-)
' * No movements greater than one. Some Abnormal Movements************************RS*****0.12**4**Managements and Cuation Programing**(++)
' * Abnormal Movements Correction*************************************************--**(-)
' * Clear Dirty Part**************************************************************--**(-)
' * Chess Rules Soldier Not Moved Jump From Enemy to 2****************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Rules Abnormally Minister Gray Elephant to Right************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Rules Elephant Normally*************************************************--**(-)
' * Abnormally Recursive Method***************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Rule Kish Mate Doesn’t Work*********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Clicking 'Table' Content Has been Abnormally**********************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * The Mechanism of Kish Declared and Act 'Not' Logically************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * The Mechanism of Table Assignments and the Virtualization Misleading**********RS*****0.12**4**Managements and Cuation Programing**(+)
' * The Movements of horse Brown 'Alice' Left Side Cause to Mislead***************RS*****0.12**4**Managements and Cuation Programing**(+)
' * ExistInDestinationEnemy Thinking Misleading Operations************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Null Thinking Exception Handling Should be Configured*************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Malfunction of Mouse 'Bob' Event Handling For Movements***********************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Non 'Kish' Second Rules 'Alice' Move to 'Kish' State**************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Mate' Not Recognized By 'Alice'.*********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Kish' Recognized From 'Hard' Game. Mate Have Not Been Identified.************RSPB(+*)
' * Chess Rules MalFunctional*****************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Unsatisfied Mate By 'Bob' With 'Alice'****************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Removable 'Kish' by 'Bob' Was Not done by 'Alice' ****************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Unknown 'KishRemovable' and Unknown 'Kish' Mechanism**************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Table Content at 'Bob' 'Kish' of 'Alice', Malfunction with 'horse'************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Can Hit 'King'****************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Gone to 'Kish' State Deterministic********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * King hitting. Gone to Achmaz State by 'Alice' and 'Bob'***********************RSRS(++)
' * King Hitting By 'Alice' and Gone to Achmaz Remaining**************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Hitting Kish Solved by Changing Strategy. Kish by 'Alice' Cannot Been Removed.RS*****0.12**4**Managements and Cuation Programing**(-+)
' * Bridge King Mechanism Failed**************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Arguments IgonoreTowEnemy Between King and Attaker in Kish Achmaz Misleading**RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Kish' Ignore. Un Rulement 'Bob Movements*************************************RSRS(++)
' * Unidentified 'Bob' Minister Movements in Kish and Unrulements Movements*******RS*****0.12**4**Managements and Cuation Programing**(+)
' * Tow King Beside Them**********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * King of 'Bob' Gone to Achmaz.*************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Gone to Kish by 'Bob'*********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Chess Order and Chess Kish by Bob Malfunctioned*******************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 'Mate' of 'Alice' Ended by Moving of 'Bob' King Unrulments********************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Movements of 'Alice' Soldier to Backward.*************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * BrigdeKing Movements in Large Bridge King Misleading**************************RS*****0.12**4**Managements and Cuation Programing**(_)
' * Syntax Statements Failed By Halting.******************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Kish Of Bob Misleading no reason.*********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Syntax Error At Genetic Algorithm By Bob.*************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 1394/12/20********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+:Sum(48)) (_ :Sum(1)) (-:Sum(5)) (*:Sum(2))
' * Chess Syntax MalFunction.*****************************************************RS*****0.12**4**Managements and Cuation Programing**[+]
' * Chess Rules Non Soldier Colud Not been Detected. For Dept Fist Algorithm.*****RS*****0.12**4**Managements and Cuation Programing**{+}
' * 'Kish' Released isolatly.'Kish' of Brown (Alice) No Matched Realesed.*********RS*****0.12**4**Managements and Cuation Programing**<+>
' * 'Kish' Not Detected By Bob.***************************************************RS*****0.12**4**Managements and Cuation Programing**<+>
' * Bob Cloud not Remove 'Kish'.**************************************************RS*****0.12**4**Managements and Cuation Programing**<+>
' * Bob Colud not Move.No Kish asnd Mate.*****************************************RS*****0.12**4**Managements and Cuation Programing**<+>
' * Kings Have been Realeased Attacked.By Alice and Bob.**************************RS*****0.12**4**Managements and Cuation Programing**<+>
' * Achmaz kings Not work!********************************************************CU*****0.88**1**Risk Control************************<*>QC-OK.
' * Chess Rules of Movments Dept First caused to Databse MalFunction.*************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Mal Function of Table.Table zero.!********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Timer of Bob and Alice do not works!******************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Not Right of Penalty Regard Mechansim.Misleading of Operations.***************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Reveal From Mate By Alice MalFunction.****************************************RS*****0.12**4**Managements and Cuation Programing**{+}
' * Mate Not Work On Statistic and More By Alice.*********************************RS*****0.12**4**Managements and Cuation Programing**{+}
' * Mate Operation By Alice is MalFunction.***************************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * 'Minister' Alice Have been Kish unreasonably.*********************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * 'Alice' Supposed Wrongly KishAchmaz Means Kish.*******************************CU*****0.88**1**Risk Control************************(*)QC-OK.
' * Illegal King Foundation in Rules Function No Reasonaly.***********************RS*****0.12**4**Managements and Cuation Programing**<+>
' * Brown (Alice) King Dosn't exist.**********************************************RS*****0.12**4**Managements and Cuation Programing**<+>
' * Mal Function of Bridges King User Determination.******************************CU*****0.88**1**Risk Control************************{*}QC-OK
' * Mal Function of Kish Color Detection at Achmazing.****************************CU*****0.88**1**Risk Control************************<*>
' * Assignment of Kish State at AchmazKishRemove Method Not Occured.**************CU*****0.88**1**Risk Control************************<*>
' * ************************************************************************************************************************************(+):Sum(1)) 4:(+:Sum(5)) 5.(*:Sum(1)) 6.(+:Sum(2)) (*:Sum(2)) 7.(+:Sum(2)) 8.(*:Sum(3)) 9.(QC-OK.:Sum(7))
' * ********************************************************************************
' 



Namespace Refrigtz
	Class ChessRules
		'Inititae Global Variables.
		Public Shared KingAttacker As Boolean = False
		Public Shared SmallKingBridgeBrown As Boolean = False
		Public Shared SmallKingBridgeGray As Boolean = False
		Public Shared BigKingBridgeBrown As Boolean = False
		Public Shared BigKingBridgeGray As Boolean = False
		Public Shared KishAchmazIgnoreSelfThingBetweenTowEnemyKingHaveSupporter As Boolean = False
		Public Shared KishAchmazIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber As Integer = 0
		Public Shared KishAchmazIgnoreSelfThingBetweenTowEnemyKing As Boolean = False
		Public Shared KishGrayAchmaz As Boolean = False
		Public Shared KishBrownAchmaz As Boolean = False
		Public Shared KishGrayAchmazFirstTimesOcured As Boolean = False
		Public Shared KishBrownAchmazFirstTimesOcured As Boolean = False
		Public Shared BridgeActGray As Boolean = False
		Public Shared BridgeActBrown As Boolean = False
		Public Shared CurrentOrder As Integer = 1
		Public Shared KishGray As Boolean = False
		Public Shared KishBrown As Boolean = False
		Public Shared MateGray As Boolean = False
		Public Shared MateBrown As Boolean = False
		Public Shared KishGrayRemovable As Boolean = True
		Public Shared KishBrownRemovable As Boolean = True
		Public Shared KishGrayRemovableValueRowi As Integer = 0
		Public Shared KishGrayRemovableValueColumni As Integer = 0
		Public Shared KishGrayRemovableValueRowii As Integer = 0
		Public Shared KishGrayRemovableValueColumnjj As Integer = 0
		Public Shared KishBrownRemovableValueRowi As Integer = 0
		Public Shared KishBrownRemovableValueColumnj As Integer = 0
		Public Shared KishBrownRemovableValueRowii As Integer = 0
		Public Shared KishBrownRemovableValueColumnjj As Integer = 0
		Private Kind As Integer
		Private KindNA As Integer
		Private Row As Integer, Column As Integer
		Private Table As Integer(,) = New Integer(8, 8) {}
		Shared Order As Integer = 0
		Public Shared ExistInDestinationEnemy As Boolean = False
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
		Public Sub New(Ki As Integer, A As Integer(,), Ord As Integer, i As Integer, j As Integer)

			Row = i
			Column = j

			'Initiate Global Variables By Local Parameters.
			KindNA = Ki
			Kind = System.Math.Abs(Ki)
			Table = A
			Order = Ord
		End Sub
		'Initiate of Rules of Chess Refregitz.
		'The First Click Row
		'The First Click Column.
		'The Destination Click Row
		'The Destination Click Column
		'Color.  
		Public Function Rules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, color As Color, Ki As Integer) As Boolean
		'Current Kind.
			'Initaite Global Varibales.
			KishAchmazIgnoreSelfThingBetweenTowEnemyKingHaveSupporter = False
			KishAchmazIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber = 0
			'When Order is Non Detectable Continue Traversal Back.
			If Order <> CurrentOrder Then
				Return False
			End If
			'Found Location of Tow Gray and Brown Kings. 
			Dim RowB As Integer = 0, ColumnB As Integer = 0
			Dim RowG As Integer = 0, ColumnG As Integer = 0
			FindBrownKing(Table, RowB, ColumnB)
			FindGrayKing(Table, RowG, ColumnG)
			'Gray Order.
			If Order = 1 Then
				'Illegal King Foundation.
				If System.Math.Abs(RowB - RowG) <= 1 AndAlso System.Math.Abs(ColumnB - ColumnG) <= 1 Then
					Return False
				End If
			Else
				'Brown Order.
				'Ilegal Kings Foundation.
				If System.Math.Abs(RowB - RowG) <= 1 AndAlso System.Math.Abs(ColumnB - ColumnG) <= 1 Then
					Return False

				End If
			End If
			'Determination of Enemy in the Destionation Home.
			ExistInDestinationEnemy = False
			If Table(RowFirst, ColumnFirst) > 0 AndAlso Table(RowSecond, ColumnSecond) < 0 AndAlso color = Color.Gray Then
				ExistInDestinationEnemy = True
			ElseIf Table(RowFirst, ColumnFirst) < 0 AndAlso Table(RowSecond, ColumnSecond) > 0 AndAlso color = Color.Brown Then
				ExistInDestinationEnemy = True
			End If
			'If There is A Source of Soldier.
			If System.Math.Abs(Kind) = 1 Then
				'Solders of Gray at Begining.
				If ColumnFirst = 1 AndAlso color = Color.Gray Then
					Return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, True, color, _
						ExistInDestinationEnemy, Ki)
				'Solder of Brown At Begining.
				ElseIf ColumnFirst = 6 AndAlso color = Color.Brown Then
					Return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, True, color, _
						ExistInDestinationEnemy, Ki)
				Else
					'Another Solder Movments.
					Return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, False, color, _
						ExistInDestinationEnemy, Ki)

				End If
			Else
				'For another Kind of Objects.
				Return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, False, color, _
					ExistInDestinationEnemy, Ki)
			End If

		End Function
		'Bridge King Movment Consideration.
		Public Function BridgeKing(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			Ki As Integer) As Boolean
			'Gray Order.
			If Order = 1 Then
				'When Gray Bridges Not Act.
				If Not BridgeActGray Then
					'If Column is At First Location.
					If ColumnFirst = 0 AndAlso ColumnSecond = 0 Then
						'When Kings Moves for Small Kings Bridges Movments.
						If RowFirst = RowSecond - 2 Then
							'Consideration of Bridges King of Gray King.
							If Table(RowSecond - 2, ColumnSecond) = 6 AndAlso Table(RowSecond - 1, ColumnSecond) = 0 AndAlso Table(RowSecond, ColumnSecond) = 0 AndAlso Table(RowSecond + 1, ColumnSecond) = 4 Then
								BridgeActGray = True
								SmallKingBridgeGray = True
								Return True

							End If
						'For Greates Bridges King Movments.
						ElseIf RowFirst = RowSecond + 2 Then
							'Consideration of Bridges King M<ovments.
							Try
								If Table(RowSecond + 2, ColumnSecond) = 6 AndAlso Table(RowSecond + 1, ColumnSecond) = 0 AndAlso Table(RowSecond, ColumnSecond) = 0 AndAlso Table(RowSecond - 1, ColumnSecond) = 0 AndAlso Table(RowSecond - 2, ColumnSecond) = 4 Then
									BridgeActGray = True
									BigKingBridgeGray = True
									Return True
								End If
							Catch t As Exception
								Log(t)

							End Try
						End If
					End If
				End If
			Else
				'Order of Brown.
				'When Brown Bridges King Not Occured.
				If Not BridgeActBrown Then
					'Column Situation.
					If ColumnFirst = 7 AndAlso ColumnSecond = 7 Then
						'Small Brown King Bridges Consideration.
						If RowFirst = RowSecond - 2 Then
							Try

								If Table(RowSecond - 2, ColumnSecond) = -6 AndAlso Table(RowSecond - 1, ColumnSecond) = 0 AndAlso Table(RowSecond, ColumnSecond) = 0 AndAlso Table(RowSecond + 1, ColumnSecond) = -4 Then
									BridgeActBrown = True
									SmallKingBridgeBrown = True
									Return True
								End If
							Catch t As Exception
								Log(t)

							End Try
						ElseIf RowFirst = RowSecond + 2 Then
							'Brown Kings.Big King Bridges Consideration.
							Try
								If Table(RowSecond + 2, ColumnSecond) = -6 AndAlso Table(RowSecond + 1, ColumnSecond) = 0 AndAlso Table(RowSecond, ColumnSecond) = 0 AndAlso Table(RowSecond - 1, ColumnSecond) = 0 AndAlso Table(RowSecond - 2, ColumnSecond) = -4 Then
									BridgeActBrown = True
									BigKingBridgeBrown = True
									Return True
								End If
							Catch t As Exception
								Log(t)
							End Try
						End If
					End If
				End If
			End If
			Return False
		End Function
		'Simulation and Consdtruction of Kish.
		Public Function KishConstructor(color As Color, RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, Ki As Integer, _
			Order As Integer) As Boolean
			'Initiate a Local Variable.
			Dim tab As Integer(,) = New Integer(8, 8) {}
			'Clone A Copy of Table.
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					tab(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While

			'Act a Move.
			tab(RowSecond, ColumnSecond) = tab(RowFirst, ColumnFirst)
			tab(RowFirst, ColumnFirst) = 0
			'If There is Kish State.
			If Kish(tab, Order) Then
				'When Color of Order is Gray Kish return Kish State.
				If color = Color.Gray Then
					If KishGray Then
						Return True
					End If
				End If
				'When Color is Brown State  there is Kish State return Kish State.
				If color = Color.Brown Then
					If KishBrown Then
						Return True
					End If
				End If
			End If
			'Return Non Kish State.
			Return False
		End Function
		'Method of Self Home Color Objects Consideration.
		Private Function ExistSelfHome(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			Ki As Integer) As Boolean
			'Initiate of Local Variable.
			Dim NotExistInDestinationSelfHome As Boolean = False
			'When There is Not Source and Destination is the Same Home Location. 
			If RowFirst <> RowSecond OrElse ColumnFirst <> ColumnSecond Then
				'If the Same Gray Color Return Self Home. 
				If Table(RowSecond, ColumnSecond) > 0 AndAlso Table(RowFirst, ColumnFirst) > 0 Then
					NotExistInDestinationSelfHome = True
				'If The Same Color Brown Return Self Home.
				ElseIf Table(RowSecond, ColumnSecond) < 0 AndAlso Table(RowFirst, ColumnFirst) < 0 Then
					NotExistInDestinationSelfHome = True
				End If
			End If
			Return NotExistInDestinationSelfHome
		End Function
		'Achmaz Consideration.
		Public Function AchmazKingMove(Order As Integer, Table As Integer(,), DoIgnore As Boolean) As Boolean
			Dim Tab As Integer(,) = New Integer(8, 8) {}
			'Clone a Copy
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					Tab(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While
			'Initiate Variables.
			KishGray = False
			KishBrown = False
			KishGrayAchmaz = False
			KishBrownAchmaz = False
			Dim RowG As Integer = 0, ColumnG As Integer = 0
			Dim RowB As Integer = 0, ColumnB As Integer = 0
			If DoIgnore Then
				ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = True
			End If
			'Kish identification.
			Kish(Tab, Order)
			Dim KishGrayDummy As Boolean = KishGray
			Dim KishBrownDummy As Boolean = KishBrown
			'If There is Kish on Tow Side.
			If KishBrown OrElse KishGray Then
				'Kish meand achmaz.
				If KishBrown Then
					KishBrownAchmaz = True
				End If
				If KishGray Then
					KishGrayAchmaz = True
				End If

				Return True
			End If
			Dim CDummy As Integer = ChessRules.CurrentOrder
			ChessRules.CurrentOrder = -1
			Order = -1

			'Location of King Gary
			If FindGrayKing(Tab, RowG, ColumnG) Then
				'Iniatite Global Varibales.
				ChessRules.CurrentOrder = -1
				Order = -1

				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						Dim iii As Integer = 0
						While iii < 8
							Dim jjj As Integer = 0
							While jjj < 8
								If (Tab(ii, jj) < 0 AndAlso Tab(iii, jjj) > 0) Then
									If (New ThinkingChess(ii, jj)).Attack(Tab, ii, jj, iii, jjj, Color.Brown, _
										Order) Then
										Dim a As Integer = Tab(iii, jjj)
										Tab(iii, jjj) = Tab(ii, jj)
										Tab(ii, jj) = 0
										If Kish(Tab, Order) Then
											If ChessRules.KishGray Then
												' if (Row != -1 && Column != -1)
												' {
												'      if (Row != ii && Column != jj)
												'          continue;
												'   }
												KishGrayAchmazFirstTimesOcured = True
												KishGrayAchmaz = True
												Tab(ii, jj) = Tab(iii, jjj)

												Tab(iii, jjj) = a
											End If
										End If
										Tab(ii, jj) = Tab(iii, jjj)


										Tab(iii, jjj) = a
									End If

								End If
								jjj += 1
							End While
							iii += 1
						End While
						jj += 1
					End While
					ii += 1
				End While
			End If

			'Location of King Brown
			If FindBrownKing(Tab, RowB, ColumnB) Then
				'Iniatite Global Varibales.
				ChessRules.CurrentOrder = 1
				Order = 1

				Dim ii As Integer = 0
				While ii < 8
					Dim jj As Integer = 0
					While jj < 8
						Dim iii As Integer = 0
						While iii < 8
							Dim jjj As Integer = 0
							While jjj < 8

								If (Tab(ii, jj) > 0 AndAlso Tab(iii, jjj) < 0) Then
									If (New ThinkingChess(ii, jj)).Attack(Tab, ii, jj, iii, jjj, Color.Gray, _
										Order) Then
										Dim a As Integer = Tab(iii, jjj)
										Tab(iii, jjj) = Tab(ii, jj)
										Tab(ii, jj) = 0
										If Kish(Tab, Order) Then
											If ChessRules.KishBrown Then
												' if (Row != -1 && Column != -1)
												' {
												'''     if (Row != ii && Column != jj)
												'   continue;
												'  }
												KishBrownAchmazFirstTimesOcured = True
												KishBrownAchmaz = True
												Tab(ii, jj) = Tab(iii, jjj)

												Tab(iii, jjj) = a
											End If
										End If
										Tab(ii, jj) = Tab(iii, jjj)
										Tab(iii, jjj) = a
									End If
								End If
								jjj += 1
							End While
							iii += 1
						End While
						jj += 1
					End While
					ii += 1
				End While
			End If

			'
'                    //For Every Enemy
'                    for (int i = 0; i < 8; i++)
'                    {
'                        for (int j = 0; j < 8; j++)
'                        {
'                            if (i == RowG && j == ColumnG)
'                                continue;
'
'                            {
'                                //Exaturation Condition.                                
'                                if (Tab[i, j] == -1)
'                                {
'                                    //
'                                    if (System.Math.Abs(i - RowG) == 1 && System.Math.Abs(j - ColumnG) == 1)
'                                    {
'                                        if (i > RowG)
'                                        {
'
'                                            KishGrayAchmaz = true;
'                                            KishGrayAchmazFirstTimesOcured = true;
'                                            ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = false;
'
'                                        }
'                                    }
'                                }
'
'                                //Prevent of Going Achamaz
'                                if ((new ChessRules(6, Tab, Order, Row, Column)).Rules(RowG, ColumnG, i, j, Color.Gray, Order))
'                                {
'                                    CDummy = ChessRules.CurrentOrder;
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                        {
'                                            int a = Tab[i, j];
'                                            Tab[i, j] = 6;
'                                            Tab[RowG, ColumnG] = 0;
'                                            ChessRules.CurrentOrder = -1;
'                                            if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, i, j, Color.Brown, -1))
'                                            {
'                                                if (Row != -1 && Column != -1)
'                                                {
'                                                    if (Row != ii && Column != jj)
'                                                        continue;
'                                                }
'                                                KishGrayAchmazFirstTimesOcured = true;
'                                                KishGrayAchmaz = true;
'                                            }
'                                            Tab[i, j] = a;
'                                            Tab[RowG, ColumnG] = 6;
'                                            ChessRules.CurrentOrder = CDummy;
'                                        }
'
'                                }
'                                //Iniatite Global Varibales.
'                                ChessRules.CurrentOrder = CDummy;
'                                ChessRules.CurrentOrder = -1;
'                                Order = -1;
'                                //If Current Enemy is Attacked.Correction needing 
'                                if ((new ThinkingChess(i, j)).Attack(Tab, i, j, RowG, ColumnG,
'                                    Color.Brown
'                                    , -1) && Tab[i, j] < 0)
'                                {
'
'                                    //If Things Between is not needed.
'                                    if (!DoIgnore)
'                                    {
'                                        KishGrayAchmazFirstTimesOcured = true;
'                                        KishGrayAchmaz = true;
'                                        //KishGrayAchmazFirstTimesOcured = true;
'
'                                    }
'                                    ChessRules.CurrentOrder = CDummy;
'                                    //When King Gray is Movable.
'                                    for (int iii = 0; iii < 8; iii++)
'                                        for (int jjj = 0; jjj < 8; jjj++)
'                                            if ((new ThinkingChess(RowG, ColumnG)).Movable(Tab, RowG, ColumnG, iii, jjj, Color.Gray, Order))
'                                            {
'                                                if (Row != -1 && Column != -1)
'                                                {
'                                                    if (Row != RowG && Column != ColumnG)
'                                                        continue;
'                                                }
'                                                KishGrayAchmaz = false;
'                                                KishGrayAchmazFirstTimesOcured = false;
'                                                break;
'                                            }
'                                    //Action off Supporte and Attacker.
'                                    int Supported = 0;
'                                    int Attacked = 0;
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                        {
'                                            if ((Tab[ii, jj] == 3 || Tab[ii, jj] == 4 || Tab[ii, jj] == 5) && (Tab[ii, jj] > 0) || (Tab[ii, jj] > 0 && System.Math.Abs(ii - RowG) < 4 && System.Math.Abs(jj - ColumnG) < 4))
'                                            {
'                                                if ((new ThinkingChess(ii, jj)).Support(Tab, ii, jj, RowG, ColumnG, Color.Gray, Order))
'                                                    Supported++;
'                                            }
'
'                                        }
'                                    //Cal Attacker
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                            for (int iii = 0; iii < 8; iii++)
'                                                for (int jjj = 0; jjj < 8; jjj++)
'                                                {
'
'                                                    if (((Tab[ii, jj] == -3 || Tab[ii, jj] == -4 || Tab[ii, jj] == -5) && (Tab[ii, jj] < 0 && Tab[iii, jjj] > 0)) || (Tab[ii, jj] < 0 && Tab[iii, jjj] > 0 && System.Math.Abs(ii - RowG) < 4 && System.Math.Abs(iii - RowG) < 4 && System.Math.Abs(jj - ColumnG) < 4 && System.Math.Abs(jjj - ColumnG) < 4))
'                                                    {
'                                                        if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, iii, jjj, Color.Gray, Order))
'                                                            Attacked++;
'                                                    }
'                                                }
'                                    //Cal Supporter.
'                                    bool SupportedAttacker = false;
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                        {
'                                            if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, RowG, ColumnG, Color.Gray, Order))
'                                            {
'
'                                                for (int iii = 0; iii < 8; iii++)
'                                                {
'                                                    for (int jjj = 0; jjj < 8; jjj++)
'                                                        if ((new ThinkingChess(iii, jjj)).Support(Tab, iii, jjj, ii, jj, Color.Brown, Order * -1))
'                                                        {
'                                                            SupportedAttacker = true;
'                                                            break;
'                                                        }
'                                                    if (SupportedAttacker)
'                                                        break;
'                                                }
'
'
'                                            }
'
'                                        }
'
'                                    //When Supporter is less than Attacker.
'                                    if (SupportedAttacker)
'                                    {
'                                        if (Supported < Attacked)
'                                        {
'                                            KishGrayAchmaz = true;
'                                            KishGrayAchmazFirstTimesOcured = true;
'                                        }
'
'                                    }
'                                    ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = false;
'
'                                }
'                                ChessRules.CurrentOrder = CDummy;
'                            }
'
'
'                        }
'                    }
'                }
'            }
'            //Brown Order.
'            if (FormRefrigtz.OrderPlate == -1 || !ThinkingChess.OnlySelf)
'            {  //Iniatite Global Varibales.
'                int CDummy = ChessRules.CurrentOrder;
'                ChessRules.CurrentOrder = 1;
'                Order = 1;
'
'                for (int ii = 0; ii < 8; ii++)
'                    for (int jj = 0; jj < 8; jj++)
'                        for (int iii = 0; iii < 8; iii++)
'                            for (int jjj = 0; jjj < 8; jjj++)
'                            {
'
'                                if ((Tab[ii, jj] > 0 && Tab[iii, jjj] < 0))
'                                {
'                                    if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, iii, jjj, Color.Gray, Order))
'                                    {
'                                        //Inaitaite Achmaz Kish Brown.
'                                        int a = Tab[iii, jjj];
'                                        Tab[iii, jjj] = Tab[ii, jj];
'                                        Tab[ii, jj] = 0;
'                                        if (Kish(Tab, Order))
'                                        {
'                                            if (ChessRules.KishBrown)
'                                            {
'                                                if (Row != -1 && Column != -1)
'                                                {
'                                                    if (Row != ii && Column != jj)
'                                                    {
'                                                        Tab[ii, jj] = Tab[iii, jjj];
'                                                        Tab[iii, jjj] = a;
'                                                        continue;
'                                                    }
'                                                }
'
'                                                KishBrownAchmazFirstTimesOcured = false;
'                                                KishBrownAchmaz = false;
'                                                Tab[ii, jj] = Tab[iii, jjj];
'                                                Tab[iii, jjj] = a;
'                                                return true;
'                                            }
'                                        }
'                                        Tab[ii, jj] = Tab[iii, jjj];
'                                        Tab[iii, jjj] = a;
'
'
'                                    }
'                                }
'                            }
'
'                //Foundation of Brown King.
'                if (FindBrownKing(Tab, ref RowB, ref ColumnB))
'                {
'                    //For All Home Tables.
'                    for (int i = 0; i < 8; i++)
'                    {
'                        for (int j = 0; j < 8; j++)
'                        {
'                            //If Current is Brown Kings Continue Traversal
'                            if (i == RowB && j == ColumnB)
'                                continue;
'                            {
'                                //If Table Home is Gray Soldeir. 
'                                if (Tab[i, j] == 1)
'                                {
'                                    //When Distance of Brown King and Gray Soldeir is One Home.
'                                    if (System.Math.Abs(i - RowB) == 1 && System.Math.Abs(j - ColumnB) == 1)
'                                    {
'                                        //If Attaccker.
'                                        if (i < RowB)
'                                        {
'                                            //Initiate Global Variables.
'                                            KishBrownAchmaz = true;
'                                            KishBrownAchmazFirstTimesOcured = true;
'                                            ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = false;
'                                        }
'                                    }
'                                }
'
'                                //If Brown King is Movmebale to Location of Table Home.
'                                if ((new ChessRules(-6, Table, Order, Row, Column)).Rules(RowB, ColumnB, i, j, Color.Brown, Order))
'                                {
'                                    //Iniatite Local Varibales.
'                                    CDummy = ChessRules.CurrentOrder;
'                                    //For All Home Table.
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                        {
'                                            //Iniatite Local Varibales.
'                                            int a = Tab[i, j];
'                                            Tab[i, j] = -6;
'                                            Tab[RowB, ColumnB] = 0;
'                                            ChessRules.CurrentOrder = 1;
'                                            //If Home Second Table Is Attacker To First Home table.
'                                            if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, i, j, Color.Gray, 1))
'                                            {
'                                                if (Row != -1 && Column != -1)
'                                                {
'                                                    if (Row != ii && Column != jj)
'                                                    {
'                                                        Tab[i, j] = a;
'                                                        Tab[RowB, ColumnB] = -6;
'                                                        ChessRules.CurrentOrder = CDummy;
'                                                        continue;
'                                                    }
'                                                }
'
'                                                //Iniatite Kiish Brown Achmaz.
'                                                KishBrownAchmazFirstTimesOcured = true;
'                                                KishBrownAchmaz = true;
'                                            }
'                                            //Iniatite Local and Global Varibales.
'                                            Tab[i, j] = a;
'                                            Tab[RowB, ColumnB] = -6;
'                                            ChessRules.CurrentOrder = CDummy;
'
'                                        }
'
'                                }
'                                ChessRules.CurrentOrder = CDummy;
'                                ChessRules.CurrentOrder = 1;
'                                Order = 1;
'                              
'
'                                //If Home Table is Attacker og Brown King.
'                                if ((new ThinkingChess(i, j)).Attack(Tab, i, j, RowB, ColumnB
'                                    //, Color.Brown
'                                    , Color.Gray
'                                    //, Order
'                                , 1) && Tab[i, j] > 0)
'                                {
'                                    //Iniatite Global Varibale.
'                                    ChessRules.CurrentOrder = CDummy;
'                                    //if Ignote Of Some Situation is Not Acts.
'                                    if (!DoIgnore)
'                                    {
'                                        //Kihs Achmaz Set Valid.
'                                        KishBrownAchmaz = true;
'
'                                    }
'                                    //For All Third Home Table.
'                                    for (int iii = 0; iii < 8; iii++)
'                                        for (int jjj = 0; jjj < 8; jjj++)
'                                            //If Brown King is Movable  to Third Home Table. 
'                                            if ((new ThinkingChess(RowB, ColumnB)).Movable(Tab, RowB, ColumnB, iii, jjj, Color.Brown, Order))
'                                            {
'                                                if (Row != -1 && Column != -1)
'                                                {
'                                                    if (Row != RowB && Column != ColumnB)
'                                                        continue;
'                                                }
'
'                                                //Inaitaite Achmaz Kish Brown.
'                                                KishBrownAchmazFirstTimesOcured = false;
'                                                KishBrownAchmaz = false;
'                                                break;
'                                            }
'                                    //Inaiate Supporter and Attacker.
'                                    int Supported = 0;
'                                    int Attacked = 0;
'                                    //For All Second Home Table.
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                        {
'                                            //If Situation of Supporeter is Valid.
'                                            if (((Tab[ii, jj] == -3 || Tab[ii, jj] == -4 || Tab[ii, jj] == -5) && (Tab[ii, jj] < 0) || (Tab[ii, jj] < 0 && System.Math.Abs(ii - RowB) < 4 && System.Math.Abs(jj - ColumnB) < 4)))
'                                            {
'                                                //If Second Home Table Supported The Brown  King Increament Supporter.
'                                                if ((new ThinkingChess(ii, jj)).Support(Tab, ii, jj, RowB, ColumnB, Color.Brown, Order))
'                                                    Supported++;
'                                            }
'
'
'
'                                        }
'                                    //For Second and Third Home Table. 
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                            for (int iii = 0; iii < 8; iii++)
'                                                for (int jjj = 0; jjj < 8; jjj++)
'                                                {
'                                                    //If Situation of Attacker is Vaild.
'                                                    if (((Tab[ii, jj] == 3 || Tab[ii, jj] == 4 || Tab[ii, jj] == 5) && (Tab[ii, jj] > 0 && Tab[iii, jjj] < 0)) || (Tab[ii, jj] > 0 && Tab[iii, jjj] < 0 && System.Math.Abs(ii - RowB) < 4 && System.Math.Abs(iii - RowB) < 4 && System.Math.Abs(jj - ColumnB) < 4 && System.Math.Abs(jjj - ColumnB) < 4))
'                                                    {
'                                                        //When Second Home is Ataccked Third Home Increament of Attacker.
'                                                        if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, iii, jjj, Color.Brown, Order))
'                                                            Attacked++;
'                                                    }
'                                                }
'                                    //Iniatite of Local Varibale. 
'                                    bool SupportedAttacker = false;
'                                    //For All Second Home Table.
'                                    for (int ii = 0; ii < 8; ii++)
'                                        for (int jj = 0; jj < 8; jj++)
'                                        {
'                                            //If Second Home Table is Attacked Brown King.
'                                            if ((new ThinkingChess(ii, jj)).Attack(Tab, ii, jj, RowB, ColumnB, Color.Brown, Order))
'                                            {
'                                                //For Third Home Tables.
'                                                for (int iii = 0; iii < 8; iii++)
'                                                {
'                                                    for (int jjj = 0; jjj < 8; jjj++)
'                                                        //If Third Home Table is Supported Second Home Table Increamnt SupportedAttacker.
'                                                        if ((new ThinkingChess(iii, jjj)).Support(Tab, iii, jjj, ii, jj, Color.Gray, Order * -1))
'                                                        {
'                                                            SupportedAttacker = true;
'                                                            break;
'                                                        }
'                                                    //if SupportedAttacker Break Loop.
'                                                    if (SupportedAttacker)
'                                                        break;
'                                                }
'
'
'                                            }
'
'                                        }
'                                    //If SupporetdAttacker.
'                                    if (SupportedAttacker)
'                                    {
'                                        //When Supported is Less Than Attacker 
'                                        if (Supported < Attacked)
'                                        {
'                                            //Iniatite Brown Achmaz.
'                                            KishBrownAchmaz = true;
'                                            KishBrownAchmazFirstTimesOcured = true;
'                                        }
'
'                                    }
'                                    //Iniatite Global Varibles.
'                                    ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = false;
'
'
'                                }
'                                //Iniatiate Global Variables.
'                                ChessRules.CurrentOrder = CDummy;
'
'                            }
'                        }
'                    }



			'Iniaiate Global Variables.
			ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = False
			'If There is Brown Achmaz Or Gray Achmaz.
			If KishBrownAchmaz OrElse KishGrayAchmaz Then
				'Iniaate Global Kish Variable By Local Variables.
				KishGray = KishGrayDummy
				KishBrown = KishBrownDummy
				'Achamz is Validity.
				Return True
			End If
			'Iniatiate Of Global Varibales By Local Variables.
			KishGray = KishGrayDummy
			KishBrown = KishBrownDummy
			'Return Not Validiy.
			Return False
		End Function
		'Gray King Founder.
		Function FindGrayKing(Table As Integer(,), ByRef Row As Integer, ByRef Column As Integer) As Boolean
			'For All Home Table.
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					'If Current is Gray Home 
					If Table(i, j) = 6 Then
						'Initiate Refreable Parameters.
						Row = i
						Column = j
						Return True
					End If
					j += 1
				End While
				i += 1
			End While
			'Not Found.
			Return False
		End Function
		'Alpahber Object Consideration.
		Shared Function ThingsAlphabet(i As Integer) As [String]
			'Initiate a Local Varibale. 
			Dim A As [String] = ""
			'Determinbe Gray Or Brown Movment.
			If i < 0 Then
				A = "Brown:"
			End If
			If i > 0 Then
				A = "Gray:"
			End If
			'Determine Object Alhpabet. 
			If System.Math.Abs(i) = 1 Then
				A += "(S)"
			End If
			If System.Math.Abs(i) = 2 Then
				A += "(E)"
			End If
			If System.Math.Abs(i) = 3 Then
				A += "(H)"
			End If
			If System.Math.Abs(i) = 4 Then
				A += "(B)"
			End If
			If System.Math.Abs(i) = 5 Then
				A += "(M)"
			End If
			If System.Math.Abs(i) = 6 Then
				A += "(K)"
			End If
			'Retrun Alphabet.
			Return A

		End Function
		'Row Alphabet Consideration.
		Shared Function RowAlphabet(i As Integer) As [String]
			'Initiate Local Variable.
			Dim A As [String] = ""
			'Row Alphabet Consideration.
			If i = 0 Then
				A = "a"
			End If
			If i = 1 Then
				A = "b"
			End If
			If i = 2 Then
				A = "c"
			End If
			If i = 3 Then
				A = "d"
			End If
			If i = 4 Then
				A = "e"
			End If
			If i = 5 Then
				A = "f"
			End If
			If i = 6 Then
				A = "g"
			End If
			If i = 7 Then
				A = "h"
			End If
			'Return Row Alphabet.
			Return A

		End Function
		'Create Syntax of Movments.
		Public Shared Function CreateStatistic(Tab As Integer(,), Movments As Integer, SourceThings As Integer, Column As Integer, Row As Integer, Hit As Boolean, _
			HitThings As Integer, BridgeKing As Boolean, SodierConvert As Boolean) As [String]

			Dim ms As Boolean = False
			Dim bn As Integer = Movments
			If bn Mod 2 = 1 Then
				ms = True
			End If
			'Movments String Number Creation in String.
			bn = bn / 2 + 1
			Dim SN As [String] = ""
			Dim S As [String] = ""
			If ms Then
				SN = bn.ToString() + "."
			End If



			'Consider Mate Condition of Table.

			(New ChessRules(1, Tab, 1, Row, Column)).Mate(Tab, Order)

			'When Solder Converted or Bridges King Acts.
			If SodierConvert OrElse BridgeKing Then
				'When Bridges Acts.
				If BridgeKing Then
					'Bridges Brown King.
					If ChessRules.SmallKingBridgeGray Then
						S += "Gray-BK-S"
						ChessRules.SmallKingBridgeGray = False
					ElseIf ChessRules.BigKingBridgeGray Then
						'Bridges Brown King.                    
						S += "Gray-BK-B"
						ChessRules.BigKingBridgeGray = False
					ElseIf ChessRules.SmallKingBridgeBrown Then
						'Bridges Brown King.                    
						S += "Brown-BK-S"
						ChessRules.SmallKingBridgeBrown = False
					ElseIf ChessRules.BigKingBridgeBrown Then
						'Bridges Brown King.                    

						S += "Brown-BK-B"
						ChessRules.BigKingBridgeBrown = False
						'Bridges Brown King.                    

						'Great Bridges Gray King.

					End If
				End If
				'Soldier Converted.
				If SodierConvert Then
					'Object Kind String Addition.
					S += ThingsAlphabet(SourceThings)
					'If Hit Acts.
					If Hit Then
						S += "x"
					End If
					S += Column.ToString()
					'Mate of Gray Or Brown
					If MateGray OrElse MateBrown Then
						S += "++"
					'Kish Of Gray Or Brown.
					ElseIf KishBrown OrElse KishGray Then
						S += "+"

					End If
				End If
			Else
				'Brown Order.
				'Object of Kind.
				S += ThingsAlphabet(SourceThings)
				'Hit Consideration.
				If Hit Then
					S += "x"
				End If
				'Row Column Consideration.
				S += RowAlphabet(Row)
				S += Column.ToString()
				'Mate Consideration.
				If MateGray OrElse MateBrown Then
					S += "++"
				'Gray Consideration.
				ElseIf KishBrown OrElse KishGray Then
					S += "+"

				End If
			End If
			'Separate.
			If AllDraw.CurrentHuristic <> -999999999999999999L Then
				S += " With Huristic (" + AllDraw.CurrentHuristic.ToString() + ")--"
			Else
				S += " --"
			End If
			'Return String Sysntax.
			Return SN + S
		End Function
		'Consideration of Existing Table in List.
		Function ArrayInList(List As List(Of Integer()), A As Integer()) As Boolean
			'Initiate Local Variables.
			Dim [Is] As Boolean = False
			'For each Items of a Tow Part List.
			Dim i As Integer = 0
			While i < List.Count
				'If Listis Equal Setting of Local Variable Equality.
				If A(0) = List(i)(0) AndAlso A(1) = List(i)(1) Then
					[Is] = True
				End If
				i += 1
			End While
			'Retrun Condition.
			Return [Is]
		End Function
		'Find a Specific Objects.
		Public Function FindAThing(Table As Integer(,), ByRef Row As Integer, ByRef Column As Integer, Thing As Integer, BeMovable As Boolean, List As List(Of Integer())) As Boolean
			'For All Items In Table Home.
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					'Initiate Local Variables.
					Dim AA As Integer() = New Integer(2) {}
					AA(0) = i
					AA(1) = j
					'If Table Home is Eqaul Tow Things Object.
					If Table(i, j) = Thing Then
						'If Set A Global Variable Low Logical.
						If Not BeMovable Then
							'If Array Exist In List Continue Traversal Back.
							If ArrayInList(List, AA) Then
								Continue While
							End If
							'Iniatiate Local Varibales.
							Row = i
							Column = j
							'Found State.
							Return True
						Else
							'Else of Condition.
							'Iniatiate Local Variables.
							Dim A As Color = Color.Gray
							If Order = -1 Then
								A = Color.Brown
							End If
							'For All Second Home.
							Dim ii As Integer = 0
							While ii < 8
								Dim jj As Integer = 0
								While jj < 8
									'If First Home is Movable to Second Home.
									If (New ThinkingChess(i, j)).Movable(Table, i, j, ii, jj, A, _
										Order) Then
										'If Array Exist in Home.
										If ArrayInList(List, AA) Then
											Continue While
										End If
										'Initaite Local Variables.
										Row = i
										Column = j
										'Found of State
										Return True

									End If
									jj += 1
								End While
								ii += 1
							End While

						End If
					End If
					j += 1
				End While
				i += 1
			End While
			'Not Found State.
			Return False
		End Function
		'Brown King Found  Consideration.
		Function FindBrownKing(Table As Integer(,), ByRef Row As Integer, ByRef Column As Integer) As Boolean
			'For All Home Table.
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					'If Current Home is Brown King.
					If Table(i, j) = -6 Then
						'Initiate Refrencable Parameter.
						Row = i
						Column = j
						'Found of Brown King.
						Return True
					End If
					j += 1
				End While
				i += 1
			End While
			'Not Found.
			Return False
		End Function
		'A Constraint Kish Removed Unused Method.
		Public Function KishRemovableByAttack(Table As Integer(,), Order As Integer) As Boolean
			'Initiate Local Variables.
			Dim Tabl As Integer(,) = New Integer(8, 8) {}
			'Clone a Copy.
			Dim i As Integer = 0
			While i < 8
				Dim j As Integer = 0
				While j < 8
					Tabl(i, j) = Table(i, j)
					j += 1
				End While
				i += 1
			End While
			'Initiate Global Variables.
			KishGrayRemovable = True

			KishBrownRemovable = True

			Kish(Tabl, Order)
			'if (Order == -1)
			If True Then
				'For All Home Tables in Fourth Second Traversal.
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								'If Tow How is the Same Continue Traversal Back.
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								'If is Brown Order.
								If Table(i, j) < 0 Then
									'If Is Gray Order.
									If Table(ii, jj) > 0 Then
										'Initiate Local Variables.
										Dim Tab As Integer(,) = New Integer(8, 8) {}
										'Clone  a Copy.
										Dim iii As Integer = 0
										While iii < 8
											Dim jjj As Integer = 0
											While jjj < 8
												Tab(iii, jjj) = Table(iii, jjj)
												jjj += 1
											End While
											iii += 1
										End While
										'If Is Movable.
										If (New ThinkingChess(i, j)).Movable(Tab, i, j, ii, jj, Color.Brown, _
											-1) Then
											'Clone a Copy.
											Dim iii As Integer = 0
											While iii < 8
												Dim jjj As Integer = 0
												While jjj < 8
													Tab(iii, jjj) = Table(iii, jjj)
													jjj += 1
												End While
												iii += 1
											End While
											'If Brown Kish.
											If KishBrown Then
												'Initiate Local Variables.
												Tab(ii, jj) = Tab(i, j)
												Tab(i, j) = 0
												'If There is Not Kish.
												If Not Kish(Tab, Order) Then
													'If Is Not Brown Kish.
													If Not KishBrown Then
														'Initiate and Move.
														Tab(i, j) = Table(ii, jj)
														Tab(ii, jj) = 0
														KishBrownRemovableValueRowi = i
														KishGrayRemovableValueColumni = j
														KishGrayRemovableValueRowii = ii
														KishGrayRemovableValueColumnjj = jj
														KishGrayRemovable = True
													End If
												End If
												'Move Back.
												Tab(i, j) = Table(ii, jj)
												Tab(ii, jj) = 0


											End If
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
			If True Then
				'For All Second Traversal Homes.
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Dim ii As Integer = 0
						While ii < 8
							Dim jj As Integer = 0
							While jj < 8
								'if The Tow Traversal are the ame Continue Traversal Back.
								If i = ii AndAlso j = jj Then
									Continue While
								End If
								'If the Gray.
								If Table(i, j) > 0 Then
									'If the Brown.
									If Table(ii, jj) < 0 Then
										'Inaitate Local Variables.
										Dim Tab As Integer(,) = New Integer(8, 8) {}
										'Clone a Copy.
										Dim iii As Integer = 0
										While iii < 8
											Dim jjj As Integer = 0
											While jjj < 8
												Tab(iii, jjj) = Table(iii, jjj)
												jjj += 1
											End While
											iii += 1
										End While
										'Moveable Movemnts in the Tow Traversal Kind.
										If (New ThinkingChess(i, j)).Movable(Tab, i, j, ii, jj, Color.Gray, _
											1) Then
											Dim iii As Integer = 0
											While iii < 8
												Dim jjj As Integer = 0
												While jjj < 8
													Tab(iii, jjj) = Table(iii, jjj)
													jjj += 1
												End While
												iii += 1
											End While
											'If the Gray Kish.
											If KishGray Then
												'Move 
												Tab(ii, jj) = Tab(i, j)
												Tab(i, j) = 0
												'If ther is Not Kish.
												If Not Kish(Tab, Order) Then
													'If there is Not Gray Kish.
													If Not KishGray Then
														'Move and Initaite Local and Global Variables.
														Tab(i, j) = Table(ii, jj)
														Tab(ii, jj) = 0
														KishBrownRemovableValueRowi = i
														KishBrownRemovableValueColumnj = j
														KishBrownRemovableValueRowii = ii
														KishBrownRemovableValueColumnjj = jj

														KishBrownRemovable = True
													End If
												End If
												'Move Back.
												Tab(i, j) = Table(ii, jj)
												Tab(ii, jj) = 0


											End If
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
			'If Kish Remoavbe Brown Or Gray Return Removable.
			If KishBrownRemovable OrElse KishGrayRemovable Then
				Return True
			End If
			'Return Not Removable.
			Return False
		End Function
		'Kish Consideration Method.
		Public Function Kish(Table As Integer(,), Order As Integer) As Boolean
			'Initiate Local and Global Briables.
			Dim Store As Boolean = ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing
			ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = False
			KishGray = False
			KishBrown = False
			Dim Tab As Integer(,) = New Integer(8, 8) {}
			'Clone a Copy.
			Dim ii As Integer = 0
			While ii < 8
				Dim jj As Integer = 0
				While jj < 8
					Tab(ii, jj) = Table(ii, jj)
					jj += 1
				End While
				ii += 1
			End While
			'Initiate Local Variables.
			Dim RowG As Integer = 0, ColumnG As Integer = 0
			Dim RowB As Integer = 0, ColumnB As Integer = 0
			If True Then
				'Foud of Gray King.
				If FindGrayKing(Tab, RowG, ColumnG) Then
					'For All Home Table.
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							'If The Current Home is the Gray King Continue Traversal Back.
							If i = RowG AndAlso j = ColumnG Then
								Continue While
							End If
							If Tab(i, j) < 0 Then
								'Initiate Global Variables.
								Dim Dummt As Integer = ChessRules.CurrentOrder
								ChessRules.CurrentOrder = -1
								'Clone a Copy.
								Dim ii As Integer = 0
								While ii < 8
									Dim jj As Integer = 0
									While jj < 8
										Tab(ii, jj) = Table(ii, jj)
										jj += 1
									End While
									ii += 1
								End While
								'If First Traversal Attacks Second Traversal Homes.
								If (New ThinkingChess(i, j)).Attack(Tab, i, j, RowG, ColumnG, Color.Brown, _
									-1) Then
									'Initiate Local Is Kish Variables.
									KishGray = True

									ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = Store
								End If
								'Initiate Global Variables.
								ChessRules.CurrentOrder = Dummt


							End If
							j += 1
						End While
						i += 1
					End While
				End If
			End If
			If True Then
				'Found of Brown King.
				If FindBrownKing(Tab, RowB, ColumnB) Then
					'For All First Traversal Homes Table.
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							'If the Current Home is the Brown King.
							If i = RowB AndAlso j = ColumnB Then
								Continue While
							End If
							'If the Gray Home.
							If Tab(i, j) > 0 Then
								'Iniatiate Local Variables.
								Dim Dummt As Integer = ChessRules.CurrentOrder
								ChessRules.CurrentOrder = 1
								'Clone a Copy.
								Dim ii As Integer = 0
								While ii < 8
									Dim jj As Integer = 0
									While jj < 8
										Tab(ii, jj) = Table(ii, jj)
										jj += 1
									End While
									ii += 1
								End While
								'If The First Traversal Home Attackes the Second Traversal Home table. 
								If (New ThinkingChess(i, j)).Attack(Tab, i, j, RowB, ColumnB, Color.Gray, _
									1) Then
									'Initaite Kish Brown Global Variables.
									ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = Store

									KishBrown = True
								End If
								'Iniatiate Global Variables.
								ChessRules.CurrentOrder = Dummt
							End If
							j += 1
						End While
						i += 1
					End While
				End If
			End If
			'Initiate Global variables.
			ChessRules.KishAchmazIgnoreSelfThingBetweenTowEnemyKing = Store
			'If Gray Kish Or brwon Kish return Kish..
			If KishBrown OrElse KishGray Then
				Return True
			End If
			'Return Non Kish.
			Return False
		End Function
		'Mate Consideration.
		Public Function Mate(Tab As Integer(,), Order As Integer) As Boolean
			'Initiate Local and Global  Varibales.
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
			KishGray = False
			KishBrown = False
			MateBrown = False
			MateGray = False
			Dim ActMove As Boolean = True
			Dim ActMoveF As Boolean = True
			Dim RowG As Integer = 0, ColumnG As Integer = 0
			Dim RowB As Integer = 0, ColumnB As Integer = 0
			Dim Dumny As Integer = ChessRules.CurrentOrder
			'Kish Consideration.
			Kish(Table, Order)
			'Initiate Local Varibales.
			Dim KishGrayDummy As Boolean = KishGray
			Dim KishBrownDummy As Boolean = KishBrown
			If True Then
				ActMove = True
				ActMoveF = True
				'Found of Gray King.
				If FindGrayKing(Table, RowG, ColumnG) Then
					'For All Home Table.
					Dim i As Integer = 0
					While i < 8
						Dim j As Integer = 0
						While j < 8
							'Initiate Global varibales. 
							KishGray = KishGrayDummy
							KishBrown = KishBrownDummy
							'Clone a Copy.
							Dim ii As Integer = 0
							While ii < 8
								Dim jj As Integer = 0
								While jj < 8
									Table(ii, jj) = Tab(ii, jj)
									jj += 1
								End While
								ii += 1
							End While
							'If There is Gray Kish.
							If KishGray Then
								'Initiate Global Variables.
								ChessRules.CurrentOrder = 1
								'Ig Gray King is Movable to First Home Table.
								If (New ThinkingChess(RowG, ColumnG)).Movable(Table, RowG, ColumnG, i, j, Color.Gray, _
									1) Then
									'Initaite Loval and Move.
									ActMove = False
									Dim Store As Integer = Table(i, j)
									'For Another Methods
									Table(i, j) = Table(RowG, ColumnG)
									Table(RowG, ColumnG) = 0
									'If Is Kish.
									If Kish(Table, 1) Then
										'Move Back.
										Table(RowG, ColumnG) = Table(i, j)
										Table(i, j) = Store
										'If Gray Kish.
										If KishGray Then
											'Move Mack.
											ActMove = True
											Table(RowG, ColumnG) = Table(i, j)
											Table(i, j) = Store
											Continue While
										Else
											'If There is Not Gray Kish.
											'Move Back.
											Table(RowG, ColumnG) = Table(i, j)
											Table(i, j) = Store
											ActMove = False
											Exit While

										End If
									End If
									'Comon Move Back.
									Table(RowG, ColumnG) = Table(i, j)
									Table(i, j) = Store
									ActMove = False

									Exit While
								End If
								'Initiate Local Varibale.
								ActMoveF = True
								'For All Second Home Table.
								Dim ii As Integer = 0
								While ii < 8

									Dim jj As Integer = 0
									While jj < 8
										'Clone a Copy.
										Dim iii As Integer = 0
										While iii < 8
											Dim jjj As Integer = 0
											While jjj < 8
												Table(iii, jjj) = Tab(iii, jjj)
												jjj += 1
											End While
											iii += 1
										End While
										'If First Home Table is Movable To Second Home Table.  
										If (New ThinkingChess(i, j)).Movable(Table, i, j, ii, jj, Color.Gray, _
											1) Then
											'Initiate Local Varibales and Move.
											ActMoveF = False
											'For Another Methods
											Dim Store As Integer = Table(i, j)
											Table(ii, jj) = Table(i, j)
											Table(i, j) = 0
											'If Kish.
											If Kish(Table, -1) Then
												'Move Back.
												Table(i, j) = Table(ii, jj)
												Table(ii, jj) = Store
												'If Gray Kish.
												If KishGray Then
													'Initiate and Move Back.
													ActMoveF = True
													Table(i, j) = Table(ii, jj)
													Table(ii, jj) = Store
													Continue While
												Else
													'If There is Not Gray Kish.
													'Initiate Varaible and Move Back.
													ActMoveF = False
													Table(i, j) = Table(ii, jj)
													Table(ii, jj) = Store
													Exit While
												End If
											End If
											'Move Back and Initiate.
											Table(RowB, ColumnB) = Table(i, j)
											Table(i, j) = Store
											ActMoveF = False

											Exit While
										End If
										jj += 1
									End While
									'If Not Movable Break.
									If Not ActMoveF Then
										Exit While
									End If
									ii += 1

								End While
							End If
							'If Not Movable Break.
							If Not ActMoveF Then
								Exit While

							End If
							j += 1
						End While
						'If One of The Not Movable.
						If Not ActMove OrElse Not ActMoveF Then
							Exit While
						End If
						i += 1
					End While
					'Intiate Global Variables.
					KishGray = KishGrayDummy
					KishBrown = KishBrownDummy
					'Condition of Mate Gray King.
					If KishGray AndAlso ActMove AndAlso ActMoveF Then
						MateGray = True
					End If
				End If
			End If
			If True Then
				'Intiate Local Variables.
				ActMove = True
				ActMoveF = True
				'Found of Brown King.
				If FindBrownKing(Table, RowB, ColumnB) Then
					'For All Home Tables. 
					Dim i As Integer = 0
					While i < 8

						Dim j As Integer = 0
						While j < 8
							'Intiate Global Variables.
							KishGray = KishGrayDummy
							KishBrown = KishBrownDummy
							'Clone a Copy.
							Dim ii As Integer = 0
							While ii < 8
								Dim jj As Integer = 0
								While jj < 8
									Table(ii, jj) = Tab(ii, jj)
									jj += 1
								End While
								ii += 1
							End While
							'If is Brown Kish King.
							If KishBrown Then
								'Initiate Global Variable.
								ChessRules.CurrentOrder = -1
								'If Brown King is Movable to First Home Table.
								If (New ThinkingChess(RowB, ColumnB)).Movable(Table, RowB, ColumnB, i, j, Color.Brown, _
									-1) Then
									'Initiate Local and Move.
									ActMove = False
									'For Another Methods
									Dim Store As Integer = Table(i, j)
									Table(i, j) = Table(RowB, ColumnB)
									Table(RowB, ColumnB) = 0
									'If there is Kish.
									If Kish(Table, -1) Then
										'Move Back.
										Table(RowB, ColumnB) = Table(i, j)
										Table(i, j) = Store
										'If Is Brown Kish.
										If KishBrown Then
											'Initiate Local Varibale and Move Back.
											ActMove = True
											Table(RowB, ColumnB) = Table(i, j)
											Table(i, j) = Store
											Continue While
										Else
											'If There is Not Brown Kish.
											'Initiate Local Varibale and Move Back.
											ActMove = False
											Table(RowB, ColumnB) = Table(i, j)
											Table(i, j) = Store
											Exit While




										End If
									End If
									'Move Back and Initiate.
									Table(RowB, ColumnB) = Table(i, j)
									Table(i, j) = Store
									ActMove = False

									Exit While
								End If
								'Initiate Local Variable.
								ActMoveF = True
								'For All second Home Tables.
								Dim ii As Integer = 0
								While ii < 8
									Dim jj As Integer = 0
									While jj < 8
										'Clone a Copy.
										Dim iii As Integer = 0
										While iii < 8
											Dim jjj As Integer = 0
											While jjj < 8
												Table(iii, jjj) = Tab(iii, jjj)
												jjj += 1
											End While
											iii += 1
										End While
										'If First Home Table is Movable to second Home table. 
										If (New ThinkingChess(i, j)).Movable(Table, i, j, ii, jj, Color.Brown, _
											-1) Then
											'Initiate Local and Move.
											ActMoveF = False
											'For Another Methods
											Dim Store As Integer = Table(i, j)
											Table(ii, jj) = Table(i, j)
											Table(i, j) = 0
											'If There is Kish.
											If Kish(Table, -1) Then
												'Move Back.
												Table(i, j) = Table(ii, jj)
												Table(ii, jj) = Store
												'If There is Brown Kish.
												If KishBrown Then
													'Initiate Local and Move Back.
													ActMoveF = True
													Table(i, j) = Table(ii, jj)
													Table(ii, jj) = Store
													Continue While
												Else
													'If There is Not Brown Kish.
													'Initiate Local and Move Back.
													ActMoveF = False
													Table(i, j) = Table(ii, jj)
													Table(ii, jj) = Store
													Exit While




												End If
											End If
											'Move Back and Initiate.
											Table(RowB, ColumnB) = Table(i, j)
											Table(i, j) = Store
											ActMoveF = False

											Exit While
										End If
										jj += 1
									End While
									'If is Not Movable Break.
									If Not ActMoveF Then
										Exit While
									End If
									ii += 1
								End While
							End If
							'If is Not Movable Break.
							If Not ActMoveF Then
								Exit While

							End If
							j += 1
						End While
						'If One of the Not Movable Break.
						If Not ActMove OrElse Not ActMoveF Then
							Exit While

						End If
						i += 1
					End While
					'Initiate Global Varibales.
					KishGray = KishGrayDummy
					KishBrown = KishBrownDummy
					'Condition of Brown Mate.
					If KishBrown AndAlso (ActMove AndAlso ActMoveF) Then
						MateBrown = True

					End If
				End If
			End If
			'Initiate Global Variables.
			ChessRules.CurrentOrder = Dumny
			'If Brown Mate and Gray.
			If MateGray OrElse MateBrown Then
				'Initiate Global Variable and Return Mate.
				KishGray = KishGrayDummy
				KishBrown = KishBrownDummy
				FormRefrigtz.EndOfGame = True
				Return True
			End If
			'Initiate Global Variables.
			KishGray = KishGrayDummy
			KishBrown = KishBrownDummy
			'Return Not Mate.
			Return False
		End Function
		'Internal Rule of Chess Method.
		Private Function Rule(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean, Ki As Integer) As Boolean
			'When is Not Bridges King State.
			If Kind <> 7 Then
				'Determination of Enemy Existing.
				If ExistSelfHome(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					Ki) Then
					Return False
				End If
			End If
			'Determination of King Enemy at Destination Home.
			If Not KingAttacker Then
				'Coluld not hit King In Destination Enemy.
				If Order = 1 AndAlso Table(RowSecond, ColumnSecond) = -6 Then
					Return False
				End If
				If Order = -1 AndAlso Table(RowSecond, ColumnSecond) = 6 Then
					Return False
				End If
			End If
			'If Source and The Destination are The Same.
			If RowFirst = RowSecond AndAlso ColumnFirst = ColumnSecond Then
				Return False
			End If
			'Initiate Global Variable.
			KingAttacker = False
			'Rule of Soldeir.
			If Kind = 1 Then

				Return SoldierRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					ExistInDestinationEnemy)

			'Rule of Bridges.
			ElseIf Kind = 4 Then
				Return BridgeRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					ExistInDestinationEnemy, Ki)

			'Rule of Hourses.
			ElseIf Kind = 3 Then
				Return HourseRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					ExistInDestinationEnemy)
			'Rule of Elephant.
			ElseIf Kind = 2 Then
				Return ElefantRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					ExistInDestinationEnemy, Ki)
			ElseIf Kind = 5 Then
				'Rule of Ministers.
				Return MinisterRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					ExistInDestinationEnemy, Ki)
			ElseIf Kind = 6 Then
				'Rule of Kings.
				Return KingRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					ExistInDestinationEnemy, Ki)
			ElseIf Kind = 7 Then
				'Rule of Bridges King.
				Return BridgeKing(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
					Ki)
			End If


			'Non Rulements.
			Return False
		End Function
		'King Rule Method.
		Public Function KingRules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean, Ki As Integer) As Boolean
			'When Miniaster Rule is Valid.
			If MinisterRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
				ExistInDestinationEnemy, Ki) AndAlso (System.Math.Abs(RowFirst - RowSecond) <= 1 AndAlso System.Math.Abs(ColumnFirst - ColumnSecond) <= 1) Then
				'Initiate Local Variable.
				Dim Tab As Integer(,) = New Integer(8, 8) {}
				'Clone A Copy.,
				Dim i As Integer = 0
				While i < 8
					Dim j As Integer = 0
					While j < 8
						Tab(i, j) = Table(i, j)
						j += 1
					End While
					i += 1
				End While
				'Initiate Local Varibale and Move.
				Dim Store As Integer = Tab(RowSecond, ColumnSecond)
				Tab(RowSecond, ColumnSecond) = Tab(RowFirst, ColumnFirst)
				Tab(RowFirst, ColumnFirst) = 0
				'When There is Kish State.
				If Kish(Tab, Order) Then
					'Kish Gray State return Non Rule.
					If Order = 1 AndAlso ChessRules.KishGray Then
						Return False
					'Brown Kish State return Non Rule.
					ElseIf Order = -1 AndAlso ChessRules.KishBrown Then
						Return False
					End If
				End If

				'Determination of Gray Enemy State Kish at Enemy King at Around Existing Return Not Validity.
				If Order = 1 AndAlso Table(RowFirst, ColumnFirst) = 6 Then
					Try
						If Table(RowSecond + 1, ColumnSecond) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond, ColumnSecond + 1) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond + 1, ColumnSecond + 1) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond - 1, ColumnSecond) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond, ColumnSecond - 1) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond - 1, ColumnSecond - 1) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond + 1, ColumnSecond - 1) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond - 1, ColumnSecond + 1) = -6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)


					End Try
				'Determination of Brown Enemy State Kish at Enemy King at Around Existing Return Not Validity.         
				ElseIf Order = -1 AndAlso Table(RowFirst, ColumnFirst) = -6 Then
					Try
						If Table(RowSecond + 1, ColumnSecond) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond, ColumnSecond + 1) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond + 1, ColumnSecond + 1) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond - 1, ColumnSecond) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond, ColumnSecond - 1) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond - 1, ColumnSecond - 1) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond + 1, ColumnSecond - 1) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)
					End Try
					Try
						If Table(RowSecond - 1, ColumnSecond + 1) = 6 Then
							Return False
						End If
					Catch t As Exception
						Log(t)

					End Try
				End If
				Return True
			End If
			Return False
		End Function
		'Rules of Minister Method.
		Public Function MinisterRules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean, Ki As Integer) As Boolean
			'When is Bridges Rule.
			If BridgeRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
				ExistInDestinationEnemy, Ki) Then
				'Return Validity.,
				Return True
			End If
			'When is Elephant Rule.
			If ElefantRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, _
				ExistInDestinationEnemy, Ki) Then
				' if (ExistInDestinationEnemy)
				'     Table[RowSecond, ColumnSecond] = 0;  
				'Return Validity.
				Return True
			End If
			'Return Not Valididty.
			Return False
		End Function
		'Bridges Rule Method.
		Public Function BridgeRules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean, Ki As Integer) As Boolean
			'If Variation is Only in Row.
			If System.Math.Abs(ColumnFirst - ColumnSecond) = 0 AndAlso System.Math.Abs(RowFirst - RowSecond) <> 0 Then
				'Initiate Local Variables.
				Dim RowU As Integer = RowSecond, RowD As Integer = RowFirst
				Dim ColD As Integer = ColumnFirst, ColU As Integer = ColumnSecond
				Dim Rowf As Integer = 1, Colf As Integer = 1
				If RowU < RowD Then
					Rowf = -1
				End If
				If ColU < ColD Then
					Colf = -1
				End If
				Dim incf As Integer = 0, incR As Integer = 0
				If Rowf < 0 Then
					incf = -1
				End If
				If Colf < 0 Then
					incR = -1
				End If
				Dim F As Integer = 0, G As Integer = 0
				Dim A As Integer = 0, B As Integer = 0
				If incf < 0 Then
					F = RowU
					G = RowD
				Else
					F = RowD

					G = RowU
				End If
				If incR < 0 Then
					A = ColU
					B = ColD
				Else
					A = ColD

					B = ColU
				End If
				If True Then
					'For Variation of Row Home.
					Dim i As Integer = F
					While i <= G
						'When is Not Current Source Home.
						If i <> RowFirst Then
							'When There is Self Home at Home of Gray Return Not Validity.
							If Table(i, ColumnFirst) > 0 AndAlso Table(RowFirst, ColumnFirst) > 0 Then
								Return False
							End If
							'When There is Self Home of Brown Objects Return Not Validity.
							If Table(i, ColumnFirst) < 0 AndAlso Table(RowFirst, ColumnFirst) < 0 Then
								Return False
							End If

							'If Situation is Occured.
							If i <> RowSecond Then
								'When There is Slef Home at Root Return Not Valididty.
								If (Table(i, ColumnFirst) < 0 OrElse Table(i, ColumnFirst) > 0) AndAlso Table(RowFirst, ColumnFirst) > 0 Then
									Return False
								End If
								'When There is Slef Home at Root Return Not Valididty.
								If (Table(i, ColumnFirst) > 0 OrElse Table(i, ColumnFirst) < 0) AndAlso Table(RowFirst, ColumnFirst) < 0 Then
									Return False
								End If
							End If

						End If
						i += 1
					End While
				End If
				'Return not Vailidity.
				Return True
			End If
			'When There is Only Column Variation Home Changes.
			If System.Math.Abs(ColumnFirst - ColumnSecond) <> 0 AndAlso System.Math.Abs(RowFirst - RowSecond) = 0 Then
				'Initiate Local Variables.
				Dim RowU As Integer = RowSecond, RowD As Integer = RowFirst
				Dim ColD As Integer = ColumnFirst, ColU As Integer = ColumnSecond
				Dim Rowf As Integer = 1, Colf As Integer = 1
				If RowU < RowD Then
					Rowf = -1
				End If
				If ColU < ColD Then
					Colf = -1
				End If
				Dim incf As Integer = 0, incR As Integer = 0
				If Rowf < 0 Then
					incf = -1
				End If
				If Colf < 0 Then
					incR = -1
				End If
				Dim F As Integer = 0, G As Integer = 0
				Dim A As Integer = 0, B As Integer = 0
				If incf < 0 Then
					F = RowU
					G = RowD
				Else
					F = RowD

					G = RowU
				End If
				If incR < 0 Then
					A = ColU
					B = ColD
				Else
					A = ColD

					B = ColU
				End If

				'For All Column Home Variation.
				Dim j As Integer = A
				While j <= B
					'When The Source is Not The Current.
					If j <> ColumnFirst Then
						'For All Self Home at Root Return Not Validity
						If Table(RowFirst, j) > 0 AndAlso Table(RowFirst, ColumnFirst) > 0 Then
							Return False
						End If
						'For All Self Home at Root Return Not Validity.                       
						If Table(RowFirst, j) < 0 AndAlso Table(RowFirst, ColumnFirst) < 0 Then
							Return False
						End If
						'Condition Determination.
						If j <> ColumnSecond Then
							'Existing of Self Home At Root Cuased to Not validity.
							If (Table(RowFirst, j) < 0 OrElse Table(RowFirst, j) > 0) AndAlso Table(RowFirst, ColumnFirst) > 0 Then
								Return False
							End If
							'Existing of Self Home At Root Cuased to Not validity.
							If (Table(RowFirst, j) > 0 OrElse Table(RowFirst, j) < 0) AndAlso Table(RowFirst, ColumnFirst) < 0 Then
								Return False
							End If
						End If


					End If
					j += 1
				End While
				'Return Validity.
				Return True
			End If

			'Return Not Validity.
			Return False

		End Function
		'Elephant Rule Method.
		Public Function ElefantRules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean, Ki As Integer) As Boolean
			'Orthogonal Movments of One Abs Derivation.
			If System.Math.Abs(ColumnFirst - ColumnSecond) = System.Math.Abs(RowFirst - RowSecond) Then
				'Initaiet Of Local Variables.
				Dim RowU As Integer = RowSecond, RowD As Integer = RowFirst
				Dim ColD As Integer = ColumnFirst, ColU As Integer = ColumnSecond
				Dim Rowf As Integer = 1, Colf As Integer = 1
				If RowU < RowD Then
					Rowf = -1
				End If
				If ColU < ColD Then
					Colf = -1
				End If
				Dim incf As Integer = 0, incR As Integer = 0
				If Rowf < 0 Then
					incf = -1
				End If
				If Colf < 0 Then
					incR = -1
				End If
				Dim F As Integer = 0, G As Integer = 0
				Dim A As Integer = 0, B As Integer = 0
				If incf < 0 Then
					F = RowU
					G = RowD
				Else
					F = RowD

					G = RowU
				End If
				If incR < 0 Then
					A = ColU
					B = ColD
				Else
					A = ColD

					B = ColU
				End If
				'For All Root Source to Destination.
				Dim i As Integer = F
				While i <= G
					Dim j As Integer = A
					While j <= B
						'If Abs Derivation is Not One Continue. 
						If System.Math.Abs(i - RowFirst) <> System.Math.Abs(j - ColumnFirst) Then
							Continue While
						End If
						'If the Current is Not Source Home.
						If i <> RowFirst AndAlso j <> ColumnFirst Then
							If True Then
								'If the Root Contains Self Home Return Not Validity.
								If Table(i, j) > 0 AndAlso Table(RowFirst, ColumnFirst) > 0 Then
									Return False
								End If
								'If The Root Contains Self Home Return Not vALIDITY. 
								If Table(i, j) < 0 AndAlso Table(RowFirst, ColumnFirst) < 0 Then
									Return False
								End If
								'When the Current is Not The Source Home.
								If i <> RowSecond AndAlso j <> ColumnSecond Then
									'When the Self ObjectExisting at the Root .
									If (Table(i, j) > 0 OrElse Table(i, j) < 0) AndAlso Table(RowFirst, ColumnFirst) > 0 Then
										Return False
									End If
									'When the Self ObjectExisting at the Root .
									If (Table(i, j) < 0 OrElse Table(i, j) > 0) AndAlso Table(RowFirst, ColumnFirst) < 0 Then
										Return False
									End If
								End If
							End If

						End If
						j += 1
					End While
					i += 1
				End While
				'Return Validity.
				Return True
			End If
			'Return Not Validity.
			Return False
		End Function
		'Hource Rule Method.
		Public Function HourseRules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean) As Boolean
			'When L Movament is Occured. 
			If System.Math.Abs(ColumnFirst - ColumnSecond) = 2 AndAlso System.Math.Abs(RowFirst - RowSecond) = 1 Then
				'Retrun Validity.
				Return True
			End If
			'When Second L Movments Occured.
			If System.Math.Abs(ColumnFirst - ColumnSecond) = 1 AndAlso System.Math.Abs(RowFirst - RowSecond) = 2 Then
				'Return Validity.
				Return True
			End If
			'Return Not Validity.
			Return False
		End Function
		'Solder Rule Method.
		Public Function SoldierRules(RowFirst As Integer, ColumnFirst As Integer, RowSecond As Integer, ColumnSecond As Integer, NotMoved As Boolean, color As Color, _
			ExistInDestinationEnemy As Boolean) As Boolean
			'When Color is Gray.
			If color = Color.Gray Then
				'If Not Forward Return Not Validity.
				If ColumnFirst > ColumnSecond Then
					Return False
				End If
			'Color of Brown.
			ElseIf color = Color.Brown Then
				'If Not Back Wrad Return Not Vlaidity.
				If ColumnFirst < ColumnSecond Then
					Return False
				End If
			End If
			'When Soldier Not Moved in Original Location do
			If NotMoved Then
				If color = Color.Gray AndAlso Order = 1 Then
					'Depend on First Move do For Land Of Islam
					Try
						If (RowFirst = RowSecond) AndAlso (((ColumnSecond = ColumnFirst + 2 AndAlso Table(RowSecond, ColumnSecond - 1) = 0)) OrElse (ColumnSecond = ColumnFirst + 1 AndAlso Table(RowSecond, ColumnSecond) = 0)) Then
							'When Destination is The Empty Return Validity Else Return Not Validity.
							If Table(RowSecond, ColumnSecond) = 0 Then
								Return True
							Else
								Return False
							End If
						'Hit Gray Soldier Rulments.
						ElseIf ColumnSecond = ColumnFirst + 1 Then
							If (RowFirst = RowSecond - 1 OrElse RowFirst = RowSecond + 1) AndAlso ExistInDestinationEnemy Then
								' if (ExistInDestinationEnemy)
								'     if (Table[RowSecond, ColumnSecond] == -6)
								'        return false; 
								'Return Validity.
								Return True

							End If
						End If
					Catch t As Exception
						Log(t)
					End Try
				'Brown Color.
				ElseIf Order = -1 Then
					'Depend Of First Move do For Positivism
					Try
						If (RowFirst = RowSecond) AndAlso ((ColumnFirst = ColumnSecond + 2 AndAlso Table(RowSecond, ColumnSecond + 1) = 0) OrElse (ColumnFirst = ColumnSecond + 1 AndAlso Table(RowSecond, ColumnSecond) = 0)) Then
							'If The Destination is Empty Return Validity Else Return Not Validity.
							If Table(RowSecond, ColumnSecond) = 0 Then
								Return True
							Else
								Return False
							End If
						'Hit Condition Enemy Movments.
						ElseIf ColumnFirst = ColumnSecond + 1 Then
							If (RowFirst = RowSecond - 1 OrElse RowFirst = RowSecond + 1) AndAlso ExistInDestinationEnemy Then
								'Return Validity.
								Return True
							End If
						End If
					Catch t As Exception
						Log(t)
					End Try
				End If
			Else
				'If Soldeior Moved Previously.
				'For Gray Color.
				If color = Color.Gray AndAlso Order = 1 Then
					'Depend on Second Move do For Land Of Islam
					Try
						If (RowFirst = RowSecond) AndAlso (ColumnSecond = ColumnFirst + 1) Then
							'When Destination is Empty Rerturn Validity Else Return Not Validty.
							If Table(RowSecond, ColumnSecond) = 0 Then
								Return True
							Else
								Return False
							End If
						'Hitiing Rulmemnts.
						ElseIf ColumnSecond = ColumnFirst + 1 Then
							If (RowFirst = RowSecond - 1 OrElse RowFirst = RowSecond + 1) AndAlso ExistInDestinationEnemy Then
								'Return Validity.
								Return True


							End If
						End If
					Catch t As Exception
						Log(t)
					End Try
				'Brown Color.
				ElseIf Order = -1 Then
					'Depend Of Second Move do For Positivism Land
					Try
						If (RowSecond = RowFirst) AndAlso (ColumnFirst = ColumnSecond + 1) Then
							'Destination Empty Consideration 
							If Table(RowSecond, ColumnSecond) = 0 Then
								Return True
							Else
								Return False
							End If
						'Hitting Rulments.
						ElseIf ColumnFirst = ColumnSecond + 1 Then
							If (RowFirst = RowSecond - 1 OrElse RowFirst = RowSecond + 1) AndAlso ExistInDestinationEnemy Then
								'Return Validity.
								Return True

							End If
						End If
					Catch t As Exception
						Log(t)
					End Try
				End If
			End If
			'''Return Not Validity.
			Return False
		End Function
	End Class
End Namespace