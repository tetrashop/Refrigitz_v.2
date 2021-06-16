Imports System.Text
Imports System.Linq
Imports System.Drawing
Imports System.Collections.Generic
Imports System

Namespace Refrigtz
	<Serializable> _
	Public Shared Class TakeRoot
		Shared Node As AllDraw = Nothing
		'  POINTER IS THE MEMMERY LOCATION OF LAST MOVMENTS.
		Public Shared Pointer As AllDraw = Nothing

		Public Shared Sub CalculateRootGray(Curent As AllDraw)
			Try
				If Node IsNot Nothing Then
					If Node.Dept IsNot Nothing Then
						Pointer.Dept = Curent
					Else
						Node.Dept = Curent
					End If
				Else
					Node = Curent
				End If
			Catch tt As Exception
				Return
			End Try
			Return
		End Sub

	End Class
End Namespace