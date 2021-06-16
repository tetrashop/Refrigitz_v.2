Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'*****************************
' * Ramin Edjlal CopyRigth 2015
' * Polynomial Interpolate 
' * Implementation recursivley.
' * Determinant
' * TransPoset
' * Recurve Matrix.
' 


Namespace LearningMachine
	Class Interpolate
		Shared D As [Double](,)
		Shared F As [Double]()

		Public Shared Function Array(ArrayInput As [Double](), n As Int32) As [Double]()
			Dim ArrayOutputA As [Double]() = New [Double](n) {}
			Dim ArrayOutput As [Double]()
			Dim Array As [Double]() = New [Double](n) {}
			ArrayOutput = Answer(ArrayInput, n)
			Dim i As Integer = 0
			While i < n
				Array(i) = CType(ArrayOutput(i), [Double])
				i += 1
			End While
			Return Array

		End Function
		Shared Function Answer(a As [Double](), n As Int32) As [Double]()
			Dim Ans As [Double]() = New [Double](n) {}
			D = New [Double](n, n) {}
			F = New [Double](n) {}
			Dim i As Integer = 0
			While i < n
				D(i, 0) = 1
				i += 1
			End While
			Dim i As Integer = 0
			While i < n
				Dim j As Integer = 1
				While j < n
					D(i, j) = System.Math.Pow(i, j)
					j += 1
				End While
				i += 1
			End While
			Dim i As Integer = 0
			While i < n
				F(i) = a(i)
				i += 1
			End While

			D = AMinuseOne(D, n)

			Dim i As Int32 = 0
			While i < n
				Dim j As Int32 = 0
				While j < n
					Ans(i) = Ans(i) + D(i, j) * F(j)
					j += 1
				End While
				i += 1
			End While
			Return Ans
		End Function
		Private Shared Function AMinuseOne(A As [Double](,), n As Int32) As [Double](,)
			Dim N As [Double](,) = New [Double](n, n) {}
			Dim Ast As [Double](,) = New [Double](n - 1, n - 1) {}
			Dim ii As Int32 = 0
			While ii < n
				Dim jj As Int32 = 0
				While jj < n
					N(ii, jj) = System.Math.Pow(-1, ii + jj) * Det(AStar(A, n, ii, jj), n - 1)
					jj += 1
				End While
				ii += 1
			End While

			Dim i As Integer = 0
			While i < n
				Dim j As Integer = i + 1
				While j < n
					Dim [AS] As [Double] = N(i, j)
					N(i, j) = N(j, i)
					N(j, i) = [AS]
					j += 1
				End While
				i += 1
			End While
			Dim SAS As [Double] = 1 / Det(A, n)
			Dim i As Integer = 0
			While i < n
				Dim j As Integer = 0
				While j < n
					N(i, j) = SAS * N(i, j)
					j += 1
				End While
				i += 1
			End While
			Return N
		End Function
		Shared Function Det(A As [Double](,), n As Int32) As [Double]
			If n = 0 Then
				Return 0
			End If
			If n = 1 Then
				Return A(0, 0)
			End If
			If n = 2 Then
				Return A(0, 0) * A(1, 1) - A(0, 1) * A(1, 0)
			End If
			Dim AA As [Double] = 0
			Dim i As Integer = 0
			While i < n
				AA = AA + A(0, i) * System.Math.Pow(-1, i) * Det(AStar(A, n, 0, i), n - 1)
				i += 1
			End While
			Return AA
		End Function
		Shared Function AStar(A As [Double](,), n As Int32, ii As Int32, jj As Int32) As [Double](,)
			Dim Ast As [Double](,) = New [Double](n - 1, n - 1) {}
			Dim ni As Int32 = 0, nj As Int32 = 0
			Dim i As Integer = 0
			While i < n
				nj = 0
				If (i = ii) Then
					i += 1
				End If
				If i = n Then
					Exit While
				End If
				Dim j As Integer = 0
				While j < n
					If (j <> jj) Then
						Ast(ni, nj) = A(i, j)
						nj += 1
					End If
					j += 1
				End While

				ni += 1
				i += 1
			End While
			Return Ast
		End Function
	End Class
End Namespace