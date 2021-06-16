Imports System.Windows.Forms
Imports System.Text
Imports System.Linq
Imports System.Drawing
Imports System.Data
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System

Namespace Refrigtz
	Public Partial Class FormKindOfGameContinue
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub FormKindOfGameContinue_Load(sender As Object, e As EventArgs)
			Dim iii As Integer = 0
			Dim t As Integer = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond
			Do
				If DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - t > 1000 Then
					Exit Do
				End If
				iii += 1
				If System.IO.File.Exists("Database\Games\CurrentBank" + iii.ToString() + ".accdb") Then
					comboBoxDataBase.Items.Add("CurrentBank" + iii.ToString() + ".accdb")
				End If
			Loop While True

		End Sub
	End Class

End Namespace