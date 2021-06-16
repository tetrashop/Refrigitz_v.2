Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace LearningMachine
	Class HermitInterpolation
		Shared Function SimplifyLxi(s As [Double](), x As [Double](), p As Integer, j As Integer, i As Integer) As [Double]()
			If j = p Then
				Return s
			End If
			If s.Length > 2 Then
				If j <> i Then
					Dim k As Integer = p - 1
					While k >= 0
						s(k + 1) = s(k)
						k -= 1
					End While
					s(0) = 0
					Dim k As Integer = 1
					While k < s.Length
						s(k - 1) = s(k - 1) - s(k) * x(j + 1)
						k += 1
					End While
				End If
			End If
			s = SimplifyLxi(s, x, p, j + 1, i)
			Return s
		End Function
		Shared Function Derivate(za As [Double](), n As Integer) As [Double]()
			Dim sz As [Double]() = New [Double](n - 1) {}
			Dim i As Integer = (n - 1)
			While i > 0
				sz(i - 1) = za(i) * (i)
				i -= 1
			End While
			Return sz
		End Function
		Private Shared Function pxLxi(s As [Double](), x As [Double](), n As Integer, i As Integer) As [Double]()
			Dim ss As [Double] = 1
			Dim j As Integer = 0
			While j < n
				If j <> i Then
					ss = ss * (x(i) - x(j))
				End If
				j += 1
			End While
			Dim sas As [Double]() = New [Double](n) {}
			If i = 0 Then
				sas(0) = -1 * x(1)
			Else
				sas(0) = -1 * x(0)
			End If
			sas(1) = 1
			Dim aa As [Double]() = SimplifyLxi(sas, x, n - 1, 1, i)
			Dim a As Integer = 0
			While a < n
				aa(a) = aa(a) / ss
				a += 1
			End While
			Return aa
		End Function
		Shared Function pxuxi(x As [Double](), f As [Double](), n As Integer, i As Integer) As [Double]()
			Dim uxi As [Double]() = New [Double](2 * n + n) {}
			Dim result As [Double]() = New [Double](2 * n + n) {}
			Dim firstpar As [Double]() = New [Double](2) {}
			firstpar(0) = 2 * x(i)
			firstpar(1) = -2
			Dim Lxi As [Double]() = pxLxi(f, x, n, i)
			Dim Lxi2 As [Double]() = New [Double](2 * n) {}
			Dim lprinlxi As [Double]() = Derivate(Lxi, n)

			Dim r As Integer = 0
			While r < n - 1
				uxi(r) = firstpar(0) * lprinlxi(r)
				r += 1
			End While
			Dim r As Integer = 0
			While r < n - 1
				uxi(r + 1) = uxi(r + 1) + firstpar(1) * lprinlxi(r)
				r += 1
			End While
			uxi(0) = uxi(0) + 1
			Dim r As Integer = 0
			While r < n
				Dim w As Integer = 0
				While w < n
					Lxi2(r + w) = Lxi2(r + w) + Lxi(r) * Lxi(w)
					w += 1
				End While
				r += 1
			End While
			Dim r As Integer = 0
			While r < n
				Dim w As Integer = 0
				While w < 2 * n
					result(r + w) = result(r + w) + uxi(r) * Lxi2(w)
					w += 1
				End While
				r += 1
			End While

			Return result

		End Function
		Shared Function pxvxi(x As [Double](), f As [Double](), n As Integer, i As Integer) As [Double]()
			Dim result As [Double]() = New [Double](2 * n + n) {}
			Dim vxi As [Double]() = New [Double](2 * n + n) {}
			Dim firstpar As [Double]() = New [Double](2) {}
			vxi(0) = (-1) * x(i)
			vxi(1) = 1
			Dim Lxi As [Double]() = pxLxi(f, x, n, i)
			Dim Lxi2 As [Double]() = New [Double](2 * n) {}
			Dim lprinlxi As [Double]() = Derivate(Lxi, n)

			Dim r As Integer = 0
			While r < n
				Dim w As Integer = 0
				While w < n
					Lxi2(r + w) = Lxi2(r + w) + Lxi(r) * Lxi(w)
					w += 1
				End While
				r += 1
			End While
			Dim r As Integer = 0
			While r < n
				Dim w As Integer = 0
				While w < 2 * n
					result(r + w) = result(r + w) + vxi(r) * Lxi2(w)
					w += 1
				End While
				r += 1
			End While
			Return result

		End Function
		Shared Function fperinvalue(x As [Double](), f As [Double](), n As Integer) As [Double]()
			Dim fperin As [Double]() = New [Double](n) {}
			Dim i As Integer = 0
			While i < n / 2
				Dim J As Integer = 0
				While J < n / 2
					fperin(i) = fperin(i) + System.Math.Pow(-1, J) * ((1) / (J + 1)) * deltaiForward(x, f, J + 1)
					J += 1
				End While
				i += 1
			End While
			Dim i As Integer = n / 2 + 1
			While i < n
				Dim J As Integer = n / 2 + 1
				While J < n
					fperin(i) = fperin(i) + System.Math.Pow(-1, J - n / 2 - 1) * ((1) / (J + 1 - n / 2 - 1)) * deltaibackward(x, f, J - n / 2)
					J += 1
				End While
				i += 1
			End While
			Return fperin
		End Function
		Public Shared Function pxHermit(x As [Double](), f As [Double](), n As Integer) As [Double]()
			Dim fperin As [Double]() = fperinvalue(x, f, n)
			Dim Result As [Double]() = New [Double](2 * n + n) {}
			Dim Dummy As [Double]() = New [Double](2 * n + n) {}
			Dim uxi2 As [Double](,) = New [Double](n, 2 * n + n) {}
			Dim vxi2 As [Double](,) = New [Double](n, 2 * n + n) {}
			Dim i As Integer = 0
			While i < n
				Dummy = pxuxi(x, f, n, i)
				Dim G As Integer = 0
				While G < 2 * n + n
					uxi2(i, G) = Dummy(G)
					G += 1
				End While
				Dummy = pxvxi(x, f, n, i)
				Dim G As Integer = 0
				While G < 2 * n + n
					vxi2(i, G) = Dummy(G)
					G += 1


				End While
				i += 1
			End While
			Dim i As Integer = 0
			While i < n
				Dim j As Integer = 0
				While j < 2 * n + n
					Result(j) = Result(j) + uxi2(i, j) * f(i) + vxi2(i, j) * fperin(i)
					j += 1
				End While
				i += 1
			End While
			Return Result
		End Function
		Shared Function deltaiForward(x As [Double](), f As [Double](), index As Integer) As [Double]
			Dim ad As [Double] = 0
			Dim j As Integer = 0
			While j < index
				ad = ad + System.Math.Pow(-1, j) * Combinition(index, j) * f(index - j)
				j += 1
			End While
			Return ad
		End Function
		Shared Function deltaibackward(x As [Double](), f As [Double](), index As Integer) As [Double]
			Dim ad As [Double] = 0
			Dim j As Integer = 0
			While j < index
				ad = ad + System.Math.Pow(-1, j) * Combinition(index, j) * f(index - j)
				j += 1
			End While
			Return ad
		End Function
		Shared Function factorial(n As Integer) As Integer
			If n = 1 OrElse n = 0 Then
				Return 1
			End If
			Return n * factorial(n - 1)

		End Function
		Private Shared Function Combinition(nb As Integer, kb As Integer) As Integer
			If nb = kb Then
				Return 1
			End If
			Return (factorial(nb)) / (factorial(kb) * factorial(nb - kb))
		End Function
	End Class
End Namespace