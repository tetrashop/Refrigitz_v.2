Imports System.Collections.Generic

Public Class Stack
    Public i As List(Of Integer) = New List(Of Integer)
    Public ii As List(Of Integer) = New List(Of Integer)
    Public iii As List(Of Integer) = New List(Of Integer)
    Public j As List(Of Integer) = New List(Of Integer)
    Public jj As List(Of Integer) = New List(Of Integer)
    Public jjj As List(Of Integer) = New List(Of Integer)
    Public Sub Push_i(st As Integer)
        i.Add(st)
    End Sub
    Public Function Pop_i() As Integer
        Dim A As Integer = i(i.Count - 1)
        i.RemoveAt(i.Count - 1)
        Return A
    End Function
    Public Sub Push_ii(st As Integer)
        ii.Add(st)
    End Sub
    Public Function Pop_ii() As Integer
        Dim A As Integer = ii(ii.Count - 1)
        ii.RemoveAt(ii.Count - 1)
        Return A
    End Function
    Public Sub Push_iii(st As Integer)
        iii.Add(st)
    End Sub
    Public Function Pop_iii() As Integer
        Dim A As Integer = iii(iii.Count - 1)
        iii.RemoveAt(iii.Count - 1)
        Return A
    End Function
    Public Sub Push_j(st As Integer)
        j.Add(st)
    End Sub
    Public Function Pop_j() As Integer
        Dim A As Integer = j(j.Count - 1)
        j.RemoveAt(j.Count - 1)
        Return A
    End Function
    Public Sub Push_jj(st As Integer)
        jj.Add(st)
    End Sub
    Public Function Pop_jj() As Integer
        Dim A As Integer = jj(jj.Count - 1)
        jj.RemoveAt(jj.Count - 1)
        Return A
    End Function
    Public Sub Push_jjj(st As Integer)
        jjj.Add(st)
    End Sub
    Public Function Pop_jjj() As Integer
        Dim A As Integer = jjj(jjj.Count - 1)
        jjj.RemoveAt(jjj.Count - 1)
        Return A
    End Function
End Class
