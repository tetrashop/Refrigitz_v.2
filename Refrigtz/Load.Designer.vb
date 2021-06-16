<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Load
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents ProgressBarLoad As ProgressBar

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProgressBarLoad = New System.Windows.Forms.ProgressBar()

        Me.SuspendLayout()
        '
        'ProgressBar2
        '
        Me.SuspendLayout()
        ' 
        ' progressBar1
        ' 
        Me.ProgressBarLoad.Location = New System.Drawing.Point(1, 3)
        Me.ProgressBarLoad.Name = "progressBar1"
        Me.ProgressBarLoad.Size = New System.Drawing.Size(276, 23)
        Me.ProgressBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBarLoad.TabIndex = 0
        ' 
        ' Load
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(277, 27)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBarLoad)
        Me.MaximizeBox = False
        Me.Name = "Load"
        Me.ShowInTaskbar = False
        Me.Text = "Load"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub

    Private Function progressBar1() As Object
        Throw New NotImplementedException()
    End Function


End Class
