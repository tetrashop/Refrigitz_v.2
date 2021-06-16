Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'***********************************************************************************************************
' * Using Genetic Algorithm to produce new movment of repitativeloop conditions.*************RS*******************
' * ********************************************************************************************************** 
' * Ramin Edjlal********************************************************************************************RS*****0.12**4**Managements and Cuation Programing**
' * The Loop Genetic Mechanism Stop Working*****************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Table List Genetic Loop Huristic Stop Working***********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Program Stop Working************************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * IndexOutOfBout Exeption*********************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Order Misleading**********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Order Misleading.*******************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Failed by Adding Some New Things******************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * The Chess Sometimes Gone to Null Chromosome Row and Column**********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Looping Algorithm*******************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Disabled Functions.*******************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Misleading Movements By Alice.********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Misleading by Fault Movement By Alice.************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm could not find a Movements at Else of FindRowColumn Method By Bob.********************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Not Work. Infinity Loop Due to Order By Bob.******************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm To Misleading Movements of Bob and Alice.*********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm is legal but misleading By Alice.*****************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Order MalFunction.********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm Rules MalFunction.********************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Malfunction of Brown Order (Alice).No Chess Rules Identification By Genetic Algorithm*******************RS*****0.12**4**Managements and Cuation Programing**(+)
' * Genetic Algorithm MalFunction.**************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * No Logical Reason For Malfunction of NonRulements of Genetic Algorithm.*********************************RS*****0.12**4**Managements and Cuation Programing**(+)
' * No Logical Reason for Malfunction of Bob Soldier Attack Movements to go non enemy.**********************RS*****0.12**4**Managements and Cuation Programing**(+)
' * 1395/1/3************************************************************************************************RS*****0.12**4**Managements and Cuation Programing**(+:Sum(22))
' * Metric After Retrieve to Customer.*******************************************************************************************
' * 530 Error To Attempt Convert Chess rules and Thinking Chess to dll.**********************************************************
' * DRE=E/(E+D)=155[163]/(155[163]+530)=155[163]/685[693]=0.226[0.23]************************************************************
' * DRE2=E1/(E1+E2)=155[163]/(155[163]+4[6])=0.97[0.96]**************************************************************************
' * S'1=1.19*********************************************************************************************************************
' * DRE3=E2/(E2+E3)=6/(6+4)=0.6**************************************************************************************************
' * S'2=1.79*********************************************************************************************************************
' * DRE4=E2/(E2+E3)=[6]/(6+11)=[0.35]********************************************************************************************
' * S'3=2.14*********************************************************************************************************************
' * DRE5=E3/(E3+E4)=[11]/(11+7)=[0.61](For Level 1 of Learning Autamat:E4)*******************************************************
' * S'4=2.75*********************************************************************************************************************
' * Is=[(S-Sw)/(Sb-Sw)]*100=[([2.75]-[0.23])/(0.97-[0.23])]*100=([2.52]/[0.74])*100=[340.5]**************************************
' * S=DRE+DRE2+DRE3+DRE4+DRE5=2.816**********************************************************************************************
' * Sb=0.97**********************************************************************************************************************
' * Sw=[0.23]********************************************************************************************************************
' * The Level of Calculating are Successful state of Execution program results.**************************************************
' * DRE6=E4/(E4+E5)=([7]/(7+5))=[0.58]*******************************************************************************************
' * S2=S1+DRE6=[2.75]+[0.58]=[3.74]**********************************************************************************************
' * Sb2=0.97*********************************************************************************************************************
' * Sw2=[0.23]*******************************************************************************************************************
' * Is2=[(S2-Sw2)/(Sb2-Sw2)]=[([3.74]-[0.23])/(0.97-[0.23])]*100=[3.51]/[0.74]=2.77*100=277**************************************
' * Imp=[Is1-Is2]=340.5-277=63***************************************************************************************************
' * DRE7=E5/(E5+E6)=5/(5+8)=0.38*************************************************************************************************
' * S3=S2+DRE7=3.74+0.38=4.12****************************************************************************************************
' * Is3=[(S3-Sw3)/(Sb3-Sw3)]*100=[(4.12-0.23)/(0.97-0.23)]*100=[3.89/0.74]*100=525.67********************************************
' * Sw3=0.23*********************************************************************************************************************
' * Sb3=0.97*********************************************************************************************************************
' * Imp2=[Is2-Is3]=[277-525.67]=-248.67******************************************************************************************
' * DRE8=E6/(E6+E7)=8/(8+3)=0.72*************************************************************************************************
' * S4=S3+DRE8=4.12+0.72=4.84****************************************************************************************************
' * Is4=[(S4-Sw4)/(Sb4-Sw4)]*100=[(3.4-0.23)/(0.97-0.23)]*100=[3.17/0.74]*100=428.38*********************************************
' * Ipm3=[Is3-Is4]=660-428.38=-98.1**********************************************************************************************
' * DRE9=E7/(E7+E8)=3/(3+2)=0.6**************************************************************************************************
' * S5=S4+DRE9=4.84+0.6=5.44*****************************************************************************************************
' * Is5=[(S5-Sw5)/(Sb5-Sw5)]*100=[(6.44-0.23)/(0.97-0.23)]*100=[6.21/0.74]*100=839.18********************************************
' * Imp4=[Is4-Is5]=[758-839.18]*100=-81.18***************************************************************************************
' * DRE10=E8/(E8+E9)=2/(2+4)=0.34************************************************************************************************
' * S6=S5+DRE10=5.44+0.34=6.78***************************************************************************************************
' * Is6=[(S6-Sw6)/(Sb6-Sw6)]*100=[(6.78-0.23)/(0.97-0.23)]*100=[6.55/0.74]*100=885.13********************************************
' * Imp5=[Is5-Is6]=839.18-885.13=-45.95******************************************************************************************
' * DRE11=E9/(E9+E10)=4/(4+7)=0.36***********************************************************************************************
' * S7=S6+DRE11=5.78+0.44=7.14***************************************************************************************************
' * Is7=[(S7-Sw7)/(Sb7-Sw7)]*100=[(7.14-0.23)/(0.97-0.23]*100=[6.91/0.74]*100=933.78*********************************************
' * Imp6=[Is6-Is7]=[885.13-933.78]=-48.65****************************************************************************************
' * DRE12=E10/(E10+E11)=7/(7+51)=0.12**4**Managements and Cuation Programing*****************************************************
' * S8=S7+DRE12=7.14+0.12=7.26***************************************************************************************************
' * Is8=[(S8-Sw8)/(Sb8-Sw8)]*100=[(7.26-0.12)/(0.97-0.12)]*100=[7.14/0.85]*100=840***********************************************
' * Sw8=0.12**4**Managements and Cuation Programing******************************************************************************
' * Sb8=0.97*********************************************************************************************************************
' * Imp7=[Is7-Is8]=[933.78-840]=93.78********************************************************************************************
' * DRE13=E11/(E11+E12))=51/(51+4)=0.92******************************************************************************************
' * S9=S8+DRE13=7.26+0.92=8.18***************************************************************************************************
' * Is9=[(S9-Sw9)/(Sb9-Sw9)]*100=[(8.18-0.12)/(0.97-0.12]*100=[8.06/0.85]*100=948.23*********************************************
' * Imp8=[Is8-Is9]=[840-948.23]=-107.77******************************************************************************************
' * DRE14=E12+(E12+E13)=4/(4+4)=0.5**********************************************************************************************
' * S10=S9+DRE14=8.18+0.5=8.68***************************************************************************************************
' * Is10=[S10-Sw10)/(Sb10-Sw10)]*100==[(8.86-0.12)/(0.97-0.12)]*100=[8.74/0.85]*100=1028.23**************************************
' * Imp9=[Is9-Is10]=[948.23-1028.23]=-80*****************************************************************************************
' * DRE15=E13/(E13+E14)=4/(4+10)=0.28********************************************************************************************
' * S11=S10+DRE15=8.86+0.28=9.14*************************************************************************************************
' * Is11=[(S11-Sw11)/(Sb11-Sw11)]*100=[(9.14-0.12)/(0.97-0.12)]*100=[9.02/0.85]*100=1061.17**************************************
' * Imp10=[Is10-Is11]=[1028.23-1061.17]=-32.94***********************************************************************************
' * DRE16=E14/(E14+E15)=10/(10+3)=0.77*******************************************************************************************
' * S12=S11+DRE16=9.14+0.77=9.91*************************************************************************************************
' * Is12=[(S12-Sw12)/(Sb12-Sw12)]*100=[(9.91-0.12)/(0.97-0.12)]*100=[9.79/0.85]*100=1151.76**************************************
' * Imp11=[Is11-Is12]=[1061.17-1151.76]=-90.59***********************************************************************************
' * DRE17=E15/(E15+E16)=3/(3+6)=0.34*********************************************************************************************
' * S13=S12+DRE17=9.91+0.34=10.25************************************************************************************************
' * Is13=[(S13-Sw13)/(Sb13-Sw13)]*100=[(10.25-0.12)/(0.97-0.12)]*100=[10.13/0.85]*100=1191.76************************************
' * Imp12=[Is12-Is3]=[1151.76-1191.76]=-40***************************************************************************************
' * DRE18=E16/(E16+E17)=6/(6+2)=0.75*********************************************************************************************
' * S14=S13+DRE18=0.75+10.25=11**************************************************************************************************
' * Is14=[(S14-Sw14)/(Sb14-Sw14)]*100=[(11-0.12)/(0.97-0.12)]*100=[10.82/0.85]*100=1272.94***************************************
' * Imp13=[Is13-Is14]=[1191.76-1272.94]=-81.18***********************************************************************************
' * DRE19=E17/(E17+E18)=2/(2+2)=0.5**********************************************************************************************
' * S15=S14+DRE19=11+0.5=11.5****************************************************************************************************
' * Is15=[(S15-Sw15)/(Sb15-Sw15)]*100=[(11.5-0.12)/(0.97-0.12)]*100=[11.38/0.85]*100=1338.82*************************************
' * Imp14=[Is14-Is15]=[1272.94-1338.82]=-65.88***********************************************************************************
' * DErro1=(Ns/Na)*100=(20/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2)*100=(20/828)*100=(0.025)*100=2.5*********************
' * *****************************************************************************************************************************
' * DRE20=E18/(E18+E19)=2/(2+3)=0.4**********************************************************************************************
' * S16=S15+DRE20=11.5+0.4=11.9**************************************************************************************************
' * Is16=[(S16-Sw16)/(Sb16-Sw16)]*100=[(11.9-0.12)/(0.97-0.12)]*100=[11.78/0.85]*100=1358.88*************************************
' * Imp15=[Is15-Is16]=[1338.88-1358.82]=-19.94***********************************************************************************
' * DErro2=(Ns/Na)*100=(21/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3)*100=(21/831)*100=(0.025)*100=2.5*******************
' * DRE21=E19/(E19+E20)=3/(3+1)=0.75*********************************************************************************************
' * S17=S16+DRE20=11.9+0.75=12.65************************************************************************************************
' * Is17=[(S17-Sw17)/(Sb17-Sw17)]*100=[(12.65-0.12)/(0.97-0.12)]*100=[(12.53/0.85)]*100=1474.12**********************************
' * Imp16=[Is16-Is17]=[1358.88-1474.12]-115.24***********************************************************************************
' * DError3=(Ns/Na)*100=(22/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1)*100=(22/832)*100=(0.025)*100=2.6****************
' * DRE22=E20/(E20+E21)=1/(1+3)=1/4=0.25*****************************************************************************************
' * S18=S17+DRE21=12.65+0.25=13**************************************************************************************************
' * Is18=[(S18-Sw18)/(Sb18-Sw18)]*100=[(13-0.12)/(0.97-0.12)]*100=[12.88/0.85]*100=1515.29***************************************
' * Imp17=[Is17-Is18]=[1474.12-1515.29]=-0.97************************************************************************************
' * DError4=(Ns/Na)*100=(23/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1+3)*100=(23/835)*100=(0.028)*100=2.8**************
' * DRE23=E21/(E21+E22)=1/(1+1)=0.5**********************************************************************************************
' * S19=S18+DRE23=13+0.5=13.5****************************************************************************************************
' * Is19=[(S19-Sw19)/(Sb19-Sw19)]*100=[(13.5-0.12)/(0.97-0.12)]*100=[13.38/0.85]*100=1574.12*************************************
' * Imp18=[Is18-Is19]=[1515.29-1574.12]=-58.33***********************************************************************************
' * DError5=(Ns/Na)*100=(24/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1+3+1)*100=(24/836)*100=(0.029)*100=2.9************
' * DRE24=E22/(E22+E23)=1/(1+2)=0.33*********************************************************************************************
' * S20=S19+DRE24=0.33+13.5=13.83************************************************************************************************
' * Is20=[(S20-Sw20)/(Sb20-Sw20)]*100=[(13.83-0.12)/(0.97-0.12)]*100=[13.71/0.85]*100=1612.94************************************
' * Imp19=[Is19-Is20]=[1574.12-1612.94]=-38.82***********************************************************************************
' * DRerror6=(Ns/Na)*100=(25/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1+3+1+2)*100=(25/838)*100=(0.03)*100=3************
' * DRE25=E23/(E23+E24)=2/(2+2)=0.5**********************************************************************************************
' * S21=S20+DRE25=13.83+0.5=14.33************************************************************************************************
' * Is21=[(S21-Sw21)/(Sb21-Sw21)]*100=[(14.33-0.12)/(0.97-0.12)]*100=[14.21/0.85]*100=1671.77************************************
' * Imp20=[Is20-Is21]=[1612.94-1671.77]=-58.83***********************************************************************************
' * DRerror26=(Ns/Na)*100=(26/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1+3+1+2+2)*100=(26/840)*100=(0.03)*100=3*********
' * DRE26=E24/(E24+E25)=2/(2+1)=0.33*********************************************************************************************
' * S22=S21+DRE26=14.33+0.33=14.66***********************************************************************************************
' * Is22=[(S22-Sw22)/(Sb22-Sw22)]*100=[(14.66-0.12)/(0.97-0.12)]*100=[14.54/0.85]*100=1710.59************************************
' * Imp21=[Is21-Is22]=[1671.77-1710.59]=-38.82***********************************************************************************
' * DRerror26=(Ns/Na)*100=(27/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1+3+1+2+2+1)*100=(27/841)*100=(0.032)*100=3.2****
' * DRE27=E25/(E25+E26)=1/(1+1)=0.5**********************************************************************************************
' * S23=S22+DRE27=14.66+0.5=15.16************************************************************************************************
' * Is23=[(S23-Sw23)/(Sb23-Sw23)]*100=[(15.16-0.12)/(0.97-0.12)]*100=[15.04/0.85]*100=1769.41************************************
' * Imp22=[Is22-Is23]=[1710.59-1769.41]=-58.82***********************************************************************************
' * DRerror26=(Ns/Na)*100=(28/[155+530+6+4+11+7+7+5+8+3+2+4+7+51+4+4+10+6+2+2+3+1+3+1+2+2+1+1)*100=(28/842)*100=(0.033)*100=3.3**
' * * **************************************************************************************************************************


Namespace Refrigtz

	Class ChessGeneticAlgorithm
		'Initiate Global Variables.
		Public BridgesKing As Boolean = False
		Public Shared NoGameFounf As Boolean = False
		Private RowColumn As New List(Of Integer())()
		Private Ki As Integer = 0
		Public CromosomRow As Integer = -1, CromosomColumn As Integer = -1
		Public CromosomRowFirst As Integer = -1, CromosomColumnFirst As Integer = -1
		Private Gen1 As Integer = 0, Gen2 As Integer = 0
		Private GeneticTable As Integer(,) = New Integer(8, 8) {}
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
		Public Sub New()
			'Initiate Global Variables.
			RowColumn.Clear()
		End Sub
		'Found of Different Home Gen in Tow Chess Home Table Method. 
		Public Function FindGenToModified(Cromosom1 As Integer(,), Cromosom2 As Integer(,), List As List(Of Integer(,)), Index As Integer, Order As Integer, [and] As Boolean) As Boolean
			'Initiate Local Variables.
			Dim Find As Boolean = False
			Dim FindNumber As Integer = 0

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
							CromosomRowFirst = i
							CromosomColumnFirst = j
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
									Ki = List(Index)(CromosomRow, CromosomColumn)
									Continue While
								End If

							End If
						End If
						'Store Location of Gen and Calculate Gen Numbers.
						CromosomRow = i
						CromosomColumn = j
						Find = True
						FindNumber += 1

						Ki = List(Index)(CromosomRow, CromosomColumn)


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
		'Table Foundation of Genetic Alogorithm Method.
		Public Function GenerateTable(List As List(Of Integer(,)), Index As Integer, Order As Integer) As Integer(,)
			Begine5:
			'Initiate Local Variables.
			RowColumn.Clear()
			Dim Store As Integer = Index
			Dim Cromosom1 As Integer(,) = Nothing
			Dim Cromosom2 As Integer(,) = Nothing
			Try
				Cromosom1 = List(List.Count - 2)
				Cromosom2 = List(List.Count - 1)
			Catch t As IndexOutOfRangeException
				Log(t)
				Return Nothing
			End Try

			Index = Store
			'Found of Gen.
			If Not FindGenToModified(Cromosom1, Cromosom2, List, Index, Order, False) Then
				GoTo EndFindAThing
			End If
			BeginFind:





			'Initiate Global Variables.
			Dim color As Color = Color.Gray
			If Order = -1 Then
				color = Color.Brown
			End If
			Try
				'If Cromosom Location is Not Founded.
				If CromosomRow = -1 AndAlso CromosomColumn = -1 Then
					'Initiayte Local Variables.
					List.RemoveAt(List.Count - 1)
					Index -= 1
					GoTo Begine5
				End If
				'Found Kind Of Gen.
				Ki = List(List.Count - 1)(CromosomRow, CromosomColumn)
				'Initiate Local Variables.
				GeneticTable = New Integer(8, 8) {}
				'If Gen Kind Not Found Retrun Not Valididity.
				If List(List.Count - 1)(CromosomRow, CromosomColumn) = 0 Then
					Return Nothing
				Else
					'Clone a Copy.
					Dim ii As Integer = 0
					While ii < 8
						Dim jj As Integer = 0
						While jj < 8
							GeneticTable(ii, jj) = List(List.Count - 1)(ii, jj)
							jj += 1
						End While
						ii += 1
					End While
					

				End If
				'Initiate Global and Local Variables.
				color = Color.Gray
				If Order = -1 Then
					color = Color.Brown
				End If
				'For All Gens.
				Gen1 = 0
				While Gen1 < 8
					Gen2 = 0
					While Gen2 < 8
						'If Gen is Current Gen Location Continue Traversal Back.
						If Gen1 = CromosomRow AndAlso Gen2 = CromosomColumn Then
							Continue While
						End If
						'Rulement of Gen Movments.
						If (New ChessRules(GeneticTable(CromosomRow, CromosomColumn), GeneticTable, Order, CromosomRow, CromosomColumn)).Rules(CromosomRow, CromosomColumn, Gen1, Gen2, color, GeneticTable(CromosomRow, CromosomColumn)) Then
							'Initiate Global Variables and Syntax.
							Dim A As Integer() = New Integer(2) {}
							A(0) = CromosomRow
							A(1) = CromosomColumn
							RowColumn.Add(A)
							Dim Hit As Boolean = False
							If GeneticTable(Gen1, Gen2) <> 0 Then
								Hit = True
							End If

							If Order = 1 Then
								AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(GeneticTable, FormRefrigtz.MovmentsNumber, GeneticTable(CromosomRow, CromosomColumn), Gen2, Gen1, Hit, _
									GeneticTable(Gen1, Gen2), ChessRules.BridgeActBrown, False)
							Else
								AllDraw.SyntaxToWrite = ChessRules.CreateStatistic(GeneticTable, FormRefrigtz.MovmentsNumber, GeneticTable(CromosomRow, CromosomColumn), Gen2, Gen1, Hit, _
									GeneticTable(Gen1, Gen2), ChessRules.BridgeActBrown, False)
							End If

							GeneticTable(Gen1, Gen2) = GeneticTable(CromosomRow, CromosomColumn)
							GeneticTable(CromosomRow, CromosomColumn) = 0
							'Table Repeatative Consideration.
							If ThinkingChess.ExistTableInList(GeneticTable, List, 0) Then
								GeneticTable(CromosomRow, CromosomColumn) = GeneticTable(Gen1, Gen2)
								GeneticTable(Gen1, Gen2) = 0

								Continue While
							Else
								'Kish Consideration.
								If (New ChessRules(GeneticTable(CromosomRow, CromosomRow), GeneticTable, Order, CromosomRow, CromosomColumn)).Kish(GeneticTable, Order) Then
									GeneticTable(CromosomRow, CromosomColumn) = GeneticTable(Gen1, Gen2)
									GeneticTable(Gen1, Gen2) = 0
									Continue While
								Else


									'Return Genetic Table.
									Return GeneticTable

								End If
							End If


						End If
						Gen2 += 1
					End While
					Gen1 += 1
				End While
				'Initiate Try Catch.
				GeneticTable = Nothing
				Dim a As Integer = GeneticTable(0, 0)

			Catch t As NullReferenceException
				'Try Catch Expetion Handling of Not Successful Foundation of Gen.
				Log(t)
				If Order = 1 Then
					Ki = (New Random()).[Next](1, 7)
				Else
					Ki = (New Random()).[Next](1, 7) * -1
				End If

				If Order = 1 Then
					Dim Count As Integer = 0
					Do
						If Ki < 6 Then
							Ki += 1
						Else
							Ki = 1
						End If
						Count += 1
					Loop While Count < 6 AndAlso Not (New ChessRules(Ki, List(List.Count - 1), Order, CromosomRow, CromosomColumn)).FindAThing(List(List.Count - 1), CromosomRow, CromosomColumn, Ki, True, RowColumn)
					If Count >= 6 Then
						NoGameFounf = True
						Return Nothing


					End If
				Else
					Dim Count As Integer = 0
					Do
						If Ki > -6 Then
							Ki -= 1
						Else
							Ki = -1
						End If
						Count += 1
					Loop While Count < 6 AndAlso Not (New ChessRules(Ki, List(List.Count - 1), Order, CromosomRow, CromosomColumn)).FindAThing(List(List.Count - 1), CromosomRow, CromosomColumn, Ki, True, RowColumn)
					If Count >= 6 Then
						NoGameFounf = True
						Return Nothing






					End If
				End If

				GoTo BeginFind
			End Try
			EndFindAThing:

			'Foudn of Some Samness Gen.
			If Order = 1 Then
				Ki = (New Random()).[Next](1, 7)
			Else
				Ki = (New Random()).[Next](1, 7) * -1
			End If
			If Order = 1 Then
				Dim Count As Integer = 0
				Do
					If Ki < 6 Then
						Ki += 1
					Else
						Ki = 1
					End If
					Count += 1
				Loop While Count < 6 AndAlso Not (New ChessRules(Ki, List(List.Count - 1), Order, CromosomRow, CromosomColumn)).FindAThing(List(List.Count - 1), CromosomRow, CromosomColumn, Ki, True, RowColumn)
				If Count >= 6 Then
					Return Nothing

				End If
			Else
				Dim Count As Integer = 0
				Do
					If Ki > -6 Then
						Ki -= 1
					Else
						Ki = -1
					End If
					Count += 1
				Loop While Count < 6 AndAlso Not (New ChessRules(Ki, List(List.Count - 1), Order, CromosomRow, CromosomColumn)).FindAThing(List(List.Count - 1), CromosomRow, CromosomColumn, Ki, True, RowColumn)
				If Count >= 6 Then
					Return Nothing
				End If
			End If

			GoTo BeginFind


		End Function
	End Class

End Namespace