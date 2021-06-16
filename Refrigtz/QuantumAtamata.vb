Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'Ramin Edjlal.CopyRight 2014.AllRightReserved.
Namespace LearningMachine

	Public Class Bit
		Public Bits As Boolean() = New Boolean(2) {}
		Public Sub New()
			Bits(0) = False
			Bits(1) = False
		End Sub
		Public Function GetBits() As Boolean()
			Return Bits
		End Function
		Public Sub SetZeroZero()
		'State 0
			Bits(0) = False
			Bits(1) = False
		End Sub
		Public Sub SetZeroOne()
		'State 1
			Bits(0) = True
			Bits(1) = False
		End Sub
		Public Sub SetOneZero()
		'State SuperPosition
			Bits(0) = False
			Bits(1) = True
		End Sub
		Public Sub SetOneOne()
			Bits(0) = True
			Bits(1) = True
		End Sub
		Public Function IsZeroZero() As Boolean
			If Bits(0) = False AndAlso Bits(1) = False Then
				Return True
			End If
			Return False
		End Function
		Public Function IsZeroOne() As Boolean
			If Bits(0) = True AndAlso Bits(1) = False Then
				Return True
			End If
			Return False
		End Function
		Public Function IsOneZero() As Boolean
			If Bits(0) = False AndAlso Bits(1) = True Then
				Return True
			End If
			Return False
		End Function
		Public Function IsOneOne() As Boolean
			If Bits(0) = True AndAlso Bits(1) = True Then
				Return True
			End If
			Return False
		End Function
	End Class
	Public Class QuantumAtamata
		Inherits LearningKrinskyAtamata
		Private States As New List(Of [String])()
		Private StateByte As New List(Of [Byte])()
		Private r As Integer = 0, m As Integer = 0, k As Integer = 0
		Public BitState As Bit() = New Bit(3) {}
		Private QuatumProbabilities As Double() = New Double(3) {}

		Public ThreeSet As LearningKrinskyAtamata() = New LearningKrinskyAtamata(3) {}
		Public NumberActiveAtamata As Integer = 3
		Public FirstProbibility As Double() = Nothing
		Public SecondProbibility As Double() = Nothing
		Public ThirdProbibility As Double() = Nothing
		Private A1 As Integer = 0
		Private A2 As Integer = 0
		Private A3 As Integer = 0
		Public AA As [String] = ""
		Public AB As [String] = ""
		Public AC As [String] = ""

		Public CurrentState As [String] = ""
		Private CurrentStateByte As [Byte] = 0
		Public Sub New(r0 As Integer, m0 As Integer, k0 As Integer)
			MyBase.New(r0, m0, k0)
			Dim i As Integer = 0
			While i < 3
				BitState(i) = New Bit()
				ThreeSet(i) = New LearningKrinskyAtamata(r0, m0, k0)
				i += 1
			End While
			States.Clear()
			r = r0
			m = m0
			k = k0
			FirstProbibility = New Double(r) {}
			SecondProbibility = New Double(r) {}
			ThirdProbibility = New Double(r) {}
		End Sub
		Public Sub CurrenStateInitialize()
			A1 = FirstAtamataState()
			A2 = SecondAtamataState()
			A3 = ThirdAtamataState()
			AA = A1.ToString()
			AB = A2.ToString()
			AC = A3.ToString()
			If A1 = 0 Then
				AA = "|0>,"
			ElseIf A1 = 1 Then
				AA = "|1>,"
			ElseIf A1 = 2 Then
				AA = "|2>+|3>,"
			End If
			If A2 = 0 Then
				AB = "|0>,"
			ElseIf A2 = 1 Then
				AB = "|1>,"
			ElseIf A2 = 2 Then
				AB = "|2>+|3>,"
			End If
			If A3 = 0 Then
				AC = "|0>,"
			ElseIf A3 = 1 Then
				AC = "|1>,"
			ElseIf A3 = 2 Then
				AC = "|2>+|3>,"
			End If
			CurrentState = AA + AB + AC
			'  CurrentStateByte = System.Convert.ToByte(CurrentState, 2);
			States.Add(CurrentState)
			'   StateByte.Add(CurrentStateByte);
			If A1 = 2 Then
				If A2 = 2 Then
					If A3 = 2 Then
						NumberActiveAtamata = 1
						Dim i As Integer = 0
						While i < r
							FirstProbibility(i) = (ThreeSet(0).alpha(i) + ThreeSet(1).alpha(i) + ThreeSet(2).alpha(i)) / 3.0
							i += 1
						End While
					Else
						NumberActiveAtamata = 2
						Dim i As Integer = 0
						While i < r
							FirstProbibility(i) = (ThreeSet(0).alpha(i) + ThreeSet(1).alpha(i)) / 2.0
							SecondProbibility(i) = ThreeSet(2).alpha(i)
							i += 1
						End While
					End If
				Else
					If A3 = 2 Then

						NumberActiveAtamata = 2
						Dim i As Integer = 0
						While i < r
							FirstProbibility(i) = (ThreeSet(0).alpha(i) + ThreeSet(2).alpha(i)) / 2.0
							SecondProbibility(i) = ThreeSet(1).alpha(i)
							i += 1
						End While
					Else

						NumberActiveAtamata = 3
						Dim i As Integer = 0
						While i < r
							FirstProbibility(i) = ThreeSet(0).alpha(i)
							SecondProbibility(i) = ThreeSet(1).alpha(i)
							ThirdProbibility(i) = ThreeSet(2).alpha(i)
							i += 1
						End While
					End If
				End If
			Else
				If A2 = 2 Then
					If A3 = 2 Then
						NumberActiveAtamata = 2
						Dim i As Integer = 0
						While i < r
							FirstProbibility(i) = (ThreeSet(1).alpha(i) + ThreeSet(2).alpha(i)) / 2.0
							SecondProbibility(i) = ThreeSet(0).alpha(i)
							i += 1
						End While
					Else
						NumberActiveAtamata = 3
						Dim i As Integer = 0
						While i < r
							FirstProbibility(i) = ThreeSet(1).alpha(i)
							SecondProbibility(i) = ThreeSet(0).alpha(i)
							ThirdProbibility(i) = ThreeSet(2).alpha(i)
							i += 1
						End While
					End If
				ElseIf A3 = 2 Then
					NumberActiveAtamata = 3
					Dim i As Integer = 0
					While i < r
						FirstProbibility(i) = ThreeSet(2).alpha(i)
						SecondProbibility(i) = ThreeSet(0).alpha(i)
						ThirdProbibility(i) = ThreeSet(1).alpha(i)
						i += 1
					End While
				Else
					NumberActiveAtamata = 3
					Dim i As Integer = 0
					While i < r
						FirstProbibility(i) = ThreeSet(0).alpha(i)
						SecondProbibility(i) = ThreeSet(2).alpha(i)
						ThirdProbibility(i) = ThreeSet(1).alpha(i)
						i += 1
					End While
				End If
			End If

		End Sub

		Public Function FirstAtamataState() As Integer
			If BitState(0).IsZeroZero() Then
				'       BitState[0].SetZeroZero();
					'0 State
				Return 0
			ElseIf BitState(0).IsZeroOne() Then
				'          BitState[0].SetZeroOne();
					'1 State 
				Return 1
			End If
			' BitState[0].SetOneZero();
			Return 2
			'SuperPosition State
		End Function
		Public Function SecondAtamataState() As Integer
			If BitState(1).IsZeroZero() Then
				'BitState[1].SetZeroZero();
					'0 State
				Return 0
			ElseIf BitState(1).IsZeroOne() Then
				'      BitState[1].SetZeroOne();
					'1 State 
				Return 1
			End If

			'   BitState[1].SetOneZero();
			Return 2
			'SuperPosition State
		End Function
		Public Function ThirdAtamataState() As Integer
			If BitState(2).IsZeroZero() Then
				'     BitState[2].SetZeroZero();
					'0 State
				Return 0
			ElseIf BitState(2).IsZeroOne() Then
				'        BitState[2].SetZeroOne();
					'1 State 
				Return 1
			End If
			' BitState[2].SetOneZero();
			Return 2
			'SuperPosition State
		End Function

	End Class
End Namespace