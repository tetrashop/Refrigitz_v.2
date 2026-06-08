Imports System.IO
Imports System.Threading
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
Namespace Refrigtz
    Class Syncronization
        'Error Handling.
        Shared Sub Log(ex As Exception)
            Try
                Dim stackTrace As String = ex.ToString()
                ' path of file where stack trace will be stored.
                File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
            Catch t As Exception
                Log(t)
            End Try
        End Sub
        '
        Private LastState As Boolean = False
        Public Sub New()
        End Sub
        Public Sub Sync(t As Thread, a As Integer)
            Try
                If a = 1 Then
                    LastState = Mutex(t)
                ElseIf a = 2 Then
                    LastState = [Event](t)
                ElseIf a = 3 Then
                    LastState = Semaphore(t)
                End If
            Catch tt As Exception
                Log(tt)
            End Try
        End Sub
        Function Mutex(t As Thread) As Boolean
            Try

                t.Suspend()
            Catch tt As Exception
                Log(tt)
            End Try
            Return True
        End Function
        Function [Event](t As Thread) As Boolean
            Try

                t.Start()
            Catch tt As Exception
                Log(tt)
            End Try
            Return True
        End Function
        Function Semaphore(t As Thread) As Boolean
            Try

                t.[Resume]()
            Catch tt As Exception
                Log(tt)
            End Try
            Return True
        End Function
    End Class
End Namespace