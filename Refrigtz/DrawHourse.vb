Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace Refrigtz
	Public Class DrawHourse
        'Iniatite Global Variables.
        Public Row As Single, Column As Single
        Public color As Color
		Public Table As Integer(,) = Nothing
		Public HourseThinking As ThinkingChess() = New ThinkingChess(AllDraw.HourseMovments) {}
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
		'Constructpor 2.
		Public Sub New(i As Single, j As Single, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean, _
			Cur As Integer)
			'Initiate Global Variable By Local Paramenters.
			Table = Tab
            Dim ii As Integer
            ii = 0
            While ii < AllDraw.HourseMovments
				HourseThinking(ii) = New ThinkingChess(CType(i, Integer), CType(j, Integer), a, Tab, 8, Ord, _
					TB, Cur, 4)
				ii += 1
			End While

			Row = i
			Column = j
			color = a
			Order = Ord

			Current = Cur
		End Sub
		'Cloen a Copy.
		Public Sub Clone(ByRef AA As DrawHourse, ByRef THIS As FormRefrigtz)
			'Create a Construction Ojects and Initiate a Clone Copy.
			AA = New DrawHourse(Me.Row, Me.Column, Me.color, Me.Table, Me.Order, False, _
				Me.Current)
            Dim i As Integer
            i = 0
            While i < AllDraw.HourseMovments
				Try
					AA.HourseThinking(i) = New ThinkingChess()
					Me.HourseThinking(i).Clone(AA.HourseThinking(i), THIS)
				Catch t As Exception
					Log(t)
					AA.HourseThinking(i) = Nothing
				End Try
				i += 1
			End While
		End Sub
		'Draw a Instatnt Hourse on the Table Method.
		Public Sub DrawHourseOnTable(ByRef g As Graphics, CellW As Integer, CellH As Integer)
			Try
				'Gray Order.
				If color = Color.Gray Then
					'Draw an Instatnt Gray Hourse on the Table.
					g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "HG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
				Else
					'Draw an Instatnt Brown Hourse on the Table.
					g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "HB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
				End If
			Catch t As Exception
				Log(t)
			End Try
		End Sub
	End Class
End Namespace