Imports System.Windows.Forms
Imports System.Reflection
Imports System.Linq
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System

Namespace Refrigtz
	Partial Class AboutBoxChessRefrigitz
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Me.Text = [String].Format("About {0}", AssemblyTitle)
			Me.labelProductName.Text = AssemblyProduct
			Me.labelVersion.Text = [String].Format("Version {0}", AssemblyVersion)
			Me.labelCopyright.Text = AssemblyCopyright
			Me.labelCompanyName.Text = AssemblyCompany
			Me.textBoxDescription.Text = AssemblyDescription
		End Sub

		#Region "Assembly Attribute Accessors"

		Public ReadOnly Property AssemblyTitle() As String
			Get
				Dim attributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyTitleAttribute), False)
				If attributes.Length > 0 Then
					Dim titleAttribute As AssemblyTitleAttribute = CType(attributes(0), AssemblyTitleAttribute)
					If titleAttribute.Title <> "" Then
						Return titleAttribute.Title
					End If
				End If
				Return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase)
			End Get
		End Property

		Public ReadOnly Property AssemblyVersion() As String
			Get
				Return Assembly.GetExecutingAssembly().GetName().Version.ToString()
			End Get
		End Property

		Public ReadOnly Property AssemblyDescription() As String
			Get
				Dim attributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyDescriptionAttribute), False)
				If attributes.Length = 0 Then
					Return ""
				End If
				Return (CType(attributes(0), AssemblyDescriptionAttribute)).Description
			End Get
		End Property

		Public ReadOnly Property AssemblyProduct() As String
			Get
				Dim attributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyProductAttribute), False)
				If attributes.Length = 0 Then
					Return ""
				End If
				Return (CType(attributes(0), AssemblyProductAttribute)).Product
			End Get
		End Property

		Public ReadOnly Property AssemblyCopyright() As String
			Get
				Dim attributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyCopyrightAttribute), False)
				If attributes.Length = 0 Then
					Return ""
				End If
				Return (CType(attributes(0), AssemblyCopyrightAttribute)).Copyright
			End Get
		End Property

		Public ReadOnly Property AssemblyCompany() As String
			Get
				Dim attributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyCompanyAttribute), False)
				If attributes.Length = 0 Then
					Return ""
				End If
				Return (CType(attributes(0), AssemblyCompanyAttribute)).Company
			End Get
		End Property
		#End Region

		Private Sub labelCopyright_Click(sender As Object, e As EventArgs)

		End Sub
	End Class
End Namespace