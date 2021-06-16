Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace Refrigtz
	Public Class DrawKing
        'Initiate Global Variables.
        Public Row As Single, Column As Single

        Public color As Color
		Public Table As Integer(,) = Nothing
		Public KingThinking As ThinkingChess() = New ThinkingChess(AllDraw.KingMovments) {}
		Public Current As Integer = 0
		Public Order As Integer

		Shared Sub Log(ex As Exception)
			Try
				Dim stackTrace As String = ex.ToString()
					' path of file where stack trace will be stored.
				File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
			Catch t As Exception
				Log(t)
			End Try
		End Sub
		'Constructor 1.
		Public Sub New()
		End Sub
		'Constructor 2.
		Public Sub New(i As Single, j As Single, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean, _
			Cur As Integer)
			'Iniatite Global Variables.
			Table = Tab
            Dim ii As Integer
            ii = 0
            While ii < AllDraw.KingMovments
				KingThinking(ii) = New ThinkingChess(CType(i, Integer), CType(j, Integer), a, Tab, 8, Ord, _
					TB, Cur, 2)
				ii += 1
			End While

			Row = i
			Column = j
			color = a
			Order = Ord

			Current = Cur
		End Sub
		'Clone a Copy.
		Public Sub Clone(ByRef AA As DrawKing, ByRef THIS As FormRefrigtz)
			'Initiate a Construction Object and Clone a Copy.
			AA = New DrawKing(Me.Row, Me.Column, Me.color, Me.Table, Me.Order, False, _
				Me.Current)
            Dim i As Integer
            i = 0
            While i < AllDraw.KingMovments
				Try
					AA.KingThinking(i) = New ThinkingChess()
					Me.KingThinking(i).Clone(AA.KingThinking(i), THIS)
				Catch t As Exception
					Log(t)
					AA.KingThinking(i) = Nothing
				End Try
				i += 1
			End While
		End Sub
		'Draw an Instatnt King on the Table Method.
		Public Sub DrawKingOnTable(ByRef g As Graphics, CellW As Integer, CellH As Integer)

			Try
				'Gray Order.
				If color = Color.Gray Then
					'Draw an Instatnt Gray King Image On the Table.

					g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "KG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
				Else
					'Draw an Instatnt Brown King Image On the Table.
					g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "KB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
				End If
			Catch t As Exception
				Log(t)
			End Try

		End Sub
	End Class
End Namespace