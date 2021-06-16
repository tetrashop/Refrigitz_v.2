Imports System.IO
Imports System.Windows.Forms
Imports System.Linq
Imports System.Collections.Generic
Imports System
Namespace Refrigtz
    Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Log(ex As Exception)
            Try
                Dim stackTrace As String = ex.ToString()
                ' path of file where stack trace will be stored.
                File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString())
            Catch t As Exception
                Log(t)
            End Try
        End Sub
        'Main Programm.
        Public Shared Sub Main()
            'Intiate  Program Load and Calling.
            Application.EnableVisualStyles()
            Try
                Application.SetCompatibleTextRenderingDefault(False)

                Application.Run(New Load())
            Catch t As Exception
                Log(t)
            End Try

        End Sub
    End Class
End Namespace