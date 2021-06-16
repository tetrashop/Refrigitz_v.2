Public Class FormSelect


    Public Shared Sub Log(ex As Exception)

        Try

            Dim StackTrace As String = ex.ToString()
            IO.File.AppendAllText("ErrorProgramRun.txt", StackTrace + ": On" + DateTime.Now.ToString())
            ' path Of file where stack trace will be stored.

        Catch t As Exception
            Log(t)
        End Try
    End Sub
    'Constructor.
    'Delegate Of Form Close Visibility.
    Delegate Sub SetCloseVisibleCallback()
    Private Sub SetClose()

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.IsAccessible Then
            Dim d As New SetCloseVisibleCallback(AddressOf SetClose)
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FormSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class