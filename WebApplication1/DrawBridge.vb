Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
Namespace Refrigtz
    Public Class DrawBridge
        'Iniatite Global Variable.
        Public Row As Single, Column As Single
        Public color As Color
        Public BridgeThinking As ThinkingChess() = New ThinkingChess(AllDraw.BridgeMovments) {}
        Public Table As Integer(,) = Nothing
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
        'constructor 2.
        Public Sub New(i As Single, j As Single, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean,
            Cur As Integer)
            ' : base(i, j, a, Table)
            'Initiate Global Variable By Local Parmenter.
            Dim ii As Integer
            Table = Tab
            ii = 0
            While ii < AllDraw.BridgeMovments
                BridgeThinking(ii) = New ThinkingChess(CType(i, Integer), CType(j, Integer), a, Tab, 16, Ord,
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
        Public Sub Clone(ByRef AA As DrawBridge, ByRef THIS As FormRefrigtz)
            'Initiate a Constructed Brideges an Clone a Copy.
            AA = New DrawBridge(Me.Row, Me.Column, Me.color, Me.Table, Me.Order, False,
                Me.Current)
            Dim i As Integer
            i = 0
            While i < AllDraw.BridgeMovments
                Try
                    AA.BridgeThinking(i) = New ThinkingChess()
                    Me.BridgeThinking(i).Clone(AA.BridgeThinking(i), THIS)
                Catch t As Exception
                    Log(t)
                    AA.BridgeThinking(i) = Nothing
                End Try
                i += 1
            End While
        End Sub
        'Draw An Instatnt Brideges Images On the Table Method.
        Public Sub DrawBridgeOnTable(ByRef g As Graphics, CellW As Integer, CellH As Integer)
            Try
                'Gray Color.
                If color = Color.Gray Then
                    'Draw a Gray Bridges Instatnt Image On hte Tabe.
                    g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "BrG.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
                Else
                    'Draw an Instatnt of Brown Bridges On the Table.
                    g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "BrB.png"), New Rectangle(CType((Row * CType(CellW, Single)), Integer), CType((Column * CType(CellH, Single)), Integer), CellW, CellH))
                End If
            Catch t As Exception
                Log(t)
            End Try
        End Sub
    End Class
End Namespace