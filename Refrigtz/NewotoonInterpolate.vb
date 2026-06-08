Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
'*****************************
' * Ramin Edjlal CopyRigth 2015
' * Newotoon Interpolate 
' * Implementation recursivley.
' 


Namespace LearningMachine
	Class NewotoonInterpolate
		Private Shared Function fx0untinxn(x As [Double](), f As [Double](), n As Integer, i As Integer, j As Integer) As [Double]
			If (i = j - 1) OrElse (i + 1 = j) Then
				Return (f(i) - f(j)) / (x(i) - x(j))
			End If
			Dim f1 As [Double] = fx0untinxn(x, f, n, i, j - 1)
			Dim f2 As [Double] = fx0untinxn(x, f, n, i + 1, j)
			Return (f1 - f2) / (x(i) - x(j))
		End Function

		Public Shared Function px(x As [Double](), f As [Double](), n As Integer) As [Double]()
			'Double s = f[0];
'            for (int i = 1; i < n; i++)
'            {
'                Double d = 1;
'                for (int j = 0; j < i; j++)
'                    d = d * (x0 - x[j]);
'                d = d * fx0untinxn(x, f, i, 0, i);
'                s = s + d;
'            }
'            return s;
'             

			Dim s As [Double]() = New [Double](n) {}

			s(0) = f(0)

			Dim i As Integer = 1
			While i < n
				Dim d As [Double] = 1
				Dim p As [Double]() = New [Double](i + 1) {}
				p(0) = (-1) * x(0)
				p(1) = 1
				p = Simplify(p, x, i, 1)
				Dim jj As [Double] = fx0untinxn(x, f, i, 0, i)
				Dim j As Integer = 0
				While j <= i
					p(j) = p(j) * jj
					s(j) = p(j) + s(j)
					p(j) = 0
					j += 1
				End While
				i += 1
			End While
			Return s
		End Function
		Shared Function Simplify(s As [Double](), x As [Double](), i As Integer, j As Integer) As [Double]()
			If j = i Then
				Return s
			End If
			Dim k As Integer = i - 1
			While k >= 0
				s(k + 1) = s(k)
				k -= 1
			End While

			s(0) = 0

			Dim k As Integer = 1
			While k < s.Length
				s(k - 1) = s(k - 1) - s(k) * x(j)
				k += 1
			End While

			s = Simplify(s, x, i, j + 1)
			Return s

		End Function
		'public static bool test(Double[] x, Double[] f, int n,Double x0)
'        {
'
'            if (((0.5) * System.Math.Pow(x0, 3) - (7 / 2) * System.Math.Pow(x0, 2) + 9 * x0 - 2) == (px(x, f, n, x0)))
'                return true;
'            return false;
'        }
'         

	End Class
End Namespace