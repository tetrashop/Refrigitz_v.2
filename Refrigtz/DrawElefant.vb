Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
Namespace Refrigtz
    Public Class DrawElefant
        'Initiate Global Variables.
        Public Row As Single, Column As Single
        Public ElefantThinking As ThinkingChess() = New ThinkingChess(AllDraw.ElefantMovments) {}
        Public Table As Integer(,) = Nothing
        Public color As Color
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
        Public Sub New(i As Single, j As Single, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean,
            Cur As Integer)
            'Initiate Global Variables By Local Parameters.
            Table = Tab
            Dim ii As Integer
            ii = 0
            While ii < AllDraw.ElefantMovments
                ElefantThinking(ii) = New ThinkingChess(CType(i, Integer), CType(j, Integer), a, Tab, 16, Ord,
                    TB, Cur, 4)
                ii += 1
            End While

            Row = i
            Column = j
            color = a
            Order = Ord

            Current = Cur
        End Sub
        'Clone a Copy.
        Public Sub Clone(ByRef AA As DrawElefant, ByRef THIS As FormRefrigtz)
            'Initiate a Constructed Object an Clone a Copy.
            AA = New DrawElefant(Me.Row, Me.Column, Me.color, Me.Table, Me.Order, False,
                Me.Current)
            Dim i As Integer
            i = 0
            While i < AllDraw.ElefantMovments
                Try
                    AA.ElefantThinking(i) = New ThinkingChess()
                    Me.ElefantThinking(i).Clone(AA.ElefantThinking(i), THIS)
                Catch t As Exception
                    Log(t)
                    AA.ElefantThinking(i) = Nothing
                End Try
                i += 1
            End While
        End Sub
        'Draw an Instatnt Elephant On the Table.
        Public Sub DrawElefantOnTable(ByRef g As Graphics, CellW As Integer, CellH As Integer)
            Try
                'Gray Color.
                If color = Color.Gray Then
                    'Draw an Instatnt Gray Elephant On the Table.
                    g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "EG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
                Else
                    'Draw an Instatnt Brown Elepehnt On the Table.
                    g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "EB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
                End If
            Catch t As Exception
                Log(t)
            End Try
        End Sub

    End Class
End Namespace