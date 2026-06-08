Imports System.Collections
Imports System.IO.Ports
Imports System.Web
Imports System.Resources
Imports System.Media
Imports System.Diagnostics
Imports System.Security.Cryptography
Imports System.Security
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Globalization
Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Imports System.Linq
Imports System.Data
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System
Namespace Run
	Public Class Program
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

		Public Shared Sub Main(args As String())
			Dim a As New List(Of Process)()
			a.AddRange(Process.GetProcessesByName("Refrigtz"))
			If a.Count >= 1 Then

				If True Then
					Dim i As Integer = 0
					While i < a.Count
						Try

							a(i).Kill()
						Catch t As Exception
							Log(t)

						End Try
						i += 1
					End While

				End If
			End If

			System.Threading.Thread.Sleep(3000)
			System.IO.File.AppendAllText("CheckSum.btt", vbLf & vbTab & "Installation Begine On " + DateTime.Now.ToString())
			Dim FolderLocation As [String] = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()(0))
			Dim exitCode As Integer = 0

			' Prepare the process to run
			Dim start As New ProcessStartInfo()
			'TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
			' Prepare the process to run
			' Enter in the command line arguments, everything you would enter after the executable name itself
			start.Arguments = ""
			' Enter the executable to run, including the complete path
			start.FileName = """" + FolderLocation + "\" + "Refrigtz.exe" + """"
			' Do you want to show a console window?
			start.WindowStyle = ProcessWindowStyle.Normal
			start.CreateNoWindow = True
			start.UseShellExecute = True

			' Run the external process & wait for it to finish
			Using proc As Process = Process.Start(start)
				proc.WaitForExit(20000)
				' Retrieve the app's exit code
				exitCode = proc.ExitCode
			End Using
			Try
				File.Delete("Run.txt")
			Catch t As Exception
				Log(t)
			End Try

		End Sub
	End Class
End Namespace