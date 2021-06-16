Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
Namespace Refrigtz
	Public Class DrawMinister
        ':DrawKing
        'Initiate Global Variable.
        Public Row As Single, Column As Single
        Public color As Color
		Public Table As Integer(,) = Nothing
		Public Current As Integer = 0
		Public Order As Integer
		Public MinisterThinking As ThinkingChess() = New ThinkingChess(AllDraw.MinisterMovments) {}
		Shared Sub Log(ex As Exception)
			Try
				Dim stackTrace As String = ex.ToString()
					' path of file where stack trace will be stored.
				File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'constructor 1.
		Public Sub New()
		End Sub
		'Constructor 2.
		Public Sub New(i As Single, j As Single, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean, _
			Cur As Integer)
			'Initiate Global Variables.
			Table = Tab
            Dim ii As Integer
            ii = 0
            While ii < AllDraw.MinisterMovments
				MinisterThinking(ii) = New ThinkingChess(CType(i, Integer), CType(j, Integer), a, Tab, 32, Ord, _
					TB, Cur, 2)
				ii += 1
			End While

			Row = i
			Column = j
			color = a
			Current = Cur

			Order = Ord
		End Sub
		'Clone a Copy.
		Public Sub Clone(ByRef AA As DrawMinister, ByRef THIS As FormRefrigtz)
			'Initiate an Object and Clone a Construction Objectve.
			AA = New DrawMinister(Me.Row, Me.Column, Me.color, Me.Table, Me.Order, False, _
				Me.Current)
            Dim i As Integer
            i = 0
            While i < AllDraw.MinisterMovments
				Try
					AA.MinisterThinking(i) = New ThinkingChess()
					Me.MinisterThinking(i).Clone(AA.MinisterThinking(i), THIS)
				Catch t As Exception
					Log(t)
					AA.MinisterThinking(i) = Nothing

				End Try
				i += 1
			End While
		End Sub
		'Draw an Mnister on the Table.
		Public Sub DrawMinisterOnTable(ByRef g As Graphics, CellW As Integer, CellH As Integer)
			Try
				'Gray Order.
				If color = Color.Gray Then
					'Draw a Gray Instatnt Minister Image on the Table.
					g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
				Else
					'Draw a Brwon Instatnt Minister Image on the Table.
					g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MB.png"), New Rectangle(CType((Row * CellW), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))

				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub
	End Class
End Namespace