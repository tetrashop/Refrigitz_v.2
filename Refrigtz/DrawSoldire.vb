Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
Namespace Refrigtz
	Public Class DrawSoldier
		Inherits ThingsConverter
        'Iniatate Global Variables.
        Public RowS As Single, ColumnS As Single
        Public color As Color
		Public SoldierThinking As ThinkingChess() = New ThinkingChess(AllDraw.SodierMovments) {}
		Public Table As Integer(,) = Nothing
		Public Order As Integer = 0
		Public Current As Integer = 0
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
			MyBase.New(CType(i, Integer), CType(j, Integer), a, Tab, Ord, TB, _
				Cur)
            Dim ii As Integer
            'Initiate Global Variables.  
            Table = Tab
			ii=0
			While ii < AllDraw.SodierMovments

				SoldierThinking(ii) = New ThinkingChess(CType(i, Integer), CType(j, Integer), a, Tab, 4, Ord, _
					TB, Cur, 16)
				ii += 1
			End While
			RowS = i
			ColumnS = j
			color = a
			Order = Ord
			Current = Cur
		End Sub
		'Clone a Copy Method.
		Public Sub Clone(ByRef AA As DrawSoldier, ByRef THIS As FormRefrigtz)
			'Initiate a Object and Assignemt of a Clone to Construction of a Copy.
			AA = New DrawSoldier(Me.Row, Me.Column, Me.color, Me.Table, Me.Order, False, _
				Me.Current)

            Dim i As Integer
            i = 0
            While i < AllDraw.SodierMovments
				Try
					AA.SoldierThinking(i) = New ThinkingChess()
					Me.SoldierThinking(i).Clone(AA.SoldierThinking(i), THIS)
				Catch t As Exception
					Log(t)
					AA.SoldierThinking(i) = Nothing
				End Try
				i += 1
			End While
		End Sub
		'Drawing Soldiers On the Table Method..
		Public Sub DrawSoldierOnTable(ByRef g As Graphics, CellW As Integer, CellH As Integer)
			'When Conversion Solders Not Occured.
			If Not ConvertOperation(CType(Row, Integer), CType(Column, Integer), color, Table, Order, False, _
				Current) Then

				Try
					'If Order is Gray.
					If color = Color.Gray Then
						'Draw an Instant from File of Gray Soldeirs.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "SG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					Else
						'Draw an Instatnt of Brown Soldier File On the Table.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "SB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					End If
				Catch t As Exception
					Log(t)

				End Try
			'If Minsister Conversion Occured.
			ElseIf ConvertedToMinister Then
				Try
					'Color of Gray.
					If color = Color.Gray Then
						'Draw of Gray Minsister Image File By an Instant.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					Else
						'Draw a Image File on the Table Form n Instatnt One.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					End If
				Catch t As Exception
					Log(t)
				End Try
			ElseIf ConvertedToBridge Then
				'When Bridged Converted.
				Try
					'Color of Gray.
					If color = Color.Gray Then
						'Create on the Inststant of Gray Bridges Images.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "BrG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					Else
						'Creat of an Instant of Brown Image Bridges.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "BrB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					End If
				Catch t As Exception
					Log(t)
				End Try
			ElseIf ConvertedToHourse Then
				'When Hourse Conversion Occured.

				Try
					'Color of Gray.
					If color = Color.Gray Then
						'Draw an Instatnt of Gray Hourse Image File.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "HG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Integer)), Integer), CellW, CellH))
					Else
						'Creat of an Instatnt Hourse Image File.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "HB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					End If
				Catch t As Exception
					Log(t)

				End Try
			ElseIf ConvertedToElefant Then
				'When Elephant Conversion.
				Try
					'Color of Gray.
					If color = Color.Gray Then
						'Draw an Instatnt Image of Gray Elephant.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "EG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
					Else
						'Draw of Instant Image of Brwon Elephant.
						g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "EB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))

					End If
				Catch t As Exception
					Log(t)
				End Try
			End If
		End Sub
	End Class

End Namespace