Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'*****************************************************************************
' * Ramin Edjlal CopyRigth 2015.************************************************
' * Learning Autamata.**********************************************************
' * The every sum of probability is one.****************************************
' * four formula .tow for Regard regim and tow for penalty regim.***************
' * Derived Quantum Auatamata Penalt All Objects of Derived Autamata************
' * MalFunctional Reward and Penalty Detection**********************************
' * Penaly Reward Action Failure************************************************
' * Mixturing of Penalty and Regard Data in IsRegard and IsPenalty Values*******
' * No Reason For MalFunctions of Reward and Penalty Mechanism******************
' * 1395/1/2********************************************************************
' *****************************************************************************


Namespace LearningMachine

	Public Class LearningKrinskyAtamata
		Private r As Integer = 100
		Private m As Integer = 100
		Private k As Integer = 100
		Public alpha As Double()
		Private beta As Boolean = True
		Private fi As Double()
		Private IsReward As Boolean = False
		Private IsPenalty As Boolean = False
		Public Reward As Double
		Public Penalty As Double
		Public Success As Integer = 0, Failer As Integer = 0
		Public State As Integer = 0
		'int State = 1;
		Public Sub New(r0 As Integer, m0 As Integer, k0 As Integer)
			If r0 >= m0 Then
				r = r0
				m = m0
				k = k0
				alpha = New Double(r) {}
				fi = New Double(k) {}
				fi = New Double(r) {}
				Dim i As Integer = 0
				While i < r
					alpha(i) = 1.0 / CType(r, Double)
					i += 1
				End While
				Dim i As Integer = 0
				While i < k
					fi(i) = 1.0 / CType(k, Double)
					i += 1
				End While

				'Reward[i] = (double)(new Random()).Next(0, 100000) / 100000.0;
				Reward = 1.0 / CType(r, Double)
				'Penalty[i] = (double)(new Random()).Next(0, 100000) / 100000.0;
				Penalty = 1.0 / CType(r, Double)
			Else
				System.Windows.Forms.MessageBox.Show("Wrong Data! Action is Less Than Learning Automata Input!")
			End If
		End Sub
		Public Sub Clone(ByRef AA As QuantumAtamata)
			AA.r = Me.r
			AA.m = Me.m
			AA.k = Me.k
			alpha = New Double(AA.r) {}
			Dim i As Integer = 0
			While i < AA.r
				AA.alpha(i) = Me.alpha(i)
				i += 1
			End While
			AA.beta = Me.beta
			AA.Failer = Me.Failer
			fi = New Double(AA.k) {}
			Dim i As Integer = 0
			While i < AA.k
				AA.fi(i) = Me.fi(i)
				i += 1
			End While
			AA.IsPenalty = Me.IsPenalty
			AA.IsReward = Me.IsReward
			AA.Reward = Me.Reward
			AA.Penalty = Me.Penalty
			AA.Success = Me.Success
			AA.Failer = Me.Failer
			AA.State = Me.State
		End Sub
		Public Sub SuccessState()
			Success += 1
			If State <= r Then
				State = 1
			Else
				State = r - 1
			End If
		End Sub
		Public Sub FailureState()
			Failer += 1
			If Success < Failer Then
				If State < r - 1 Then
					State += 1
				Else
					State -= 1
				End If
			End If
		End Sub
		Public Function IsSecondDerivitionIsPositive() As Integer
			Dim i As Integer = 0
			While i < r - 2
				If ((alpha(i + 2) - 2 * alpha(i + 1) + alpha(i)) / (1.0 / CType(r, Double))) < 0 Then
					Return -1
				End If
				i += 1
			End While
			Return 1
		End Function
		Public Function LearningAlgorithmRegard() As Double
			Me.IsReward = True
			Me.IsReward = False
			alpha(State) += Reward * (1 - alpha(State))
			Dim i As Integer = 0
			While i < r
				If i <> State Then
					alpha(i) -= Reward * alpha(i)
				End If
				i += 1
			End While
			beta = False
			Return alpha(State)

		End Function
		Public Function IsRewardAction() As Integer
			If Me.IsReward Then
				Return 1
			End If
			Return -1

		End Function

		Public Function IsPenaltyAction() As Double
			If Me.IsPenalty Then
				Return 0
			End If
			Return -1
		End Function
		Public Function LearningAlgorithmPenalty() As Double
			Me.IsPenalty = True
			Me.IsReward = False
			alpha(State) -= Penalty * alpha(State)
			Dim i As Integer = 0
			While i < r
				If i <> State Then
					alpha(i) -= Penalty * alpha(i)
					alpha(i) += (Penalty / (r - 1))
				End If
				i += 1
			End While
			beta = True
			Return alpha(State)
		End Function
	End Class
End Namespace