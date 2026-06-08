<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelect
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
    Friend WithEvents pictureBoxGray As PictureBox
    Friend WithEvents pictureBoxBrown As PictureBox
    Friend WithEvents radioButtonGrayOrder As RadioButton
    Friend WithEvents radioButtonBrownOrder As RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radioButtonGrayOrder = New System.Windows.Forms.RadioButton()
        Me.radioButtonBrownOrder = New System.Windows.Forms.RadioButton()
        Me.pictureBoxBrown = New System.Windows.Forms.PictureBox()
        Me.pictureBoxGray = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        ' 
        ' radioButtonGrayOrder
        ' 
        Me.radioButtonGrayOrder.AutoSize = True
        Me.radioButtonGrayOrder.Location = New System.Drawing.Point(34, 36)
        Me.radioButtonGrayOrder.Name = "radioButtonGrayOrder"
        Me.radioButtonGrayOrder.Size = New System.Drawing.Size(14, 13)
        Me.radioButtonGrayOrder.TabIndex = 0
        Me.radioButtonGrayOrder.TabStop = True
        Me.radioButtonGrayOrder.UseVisualStyleBackColor = True
        ' 
        ' radioButtonBrownOrder
        ' 
        Me.radioButtonBrownOrder.AutoSize = True
        Me.radioButtonBrownOrder.Location = New System.Drawing.Point(203, 36)
        Me.radioButtonBrownOrder.Name = "radioButtonBrownOrder"
        Me.radioButtonBrownOrder.Size = New System.Drawing.Size(14, 13)
        Me.radioButtonBrownOrder.TabIndex = 2
        Me.radioButtonBrownOrder.TabStop = True
        Me.radioButtonBrownOrder.UseVisualStyleBackColor = True
        ' 
        ' pictureBoxBrown
        ' 
        Me.pictureBoxBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBoxBrown.Location = New System.Drawing.Point(258, 12)
        Me.pictureBoxBrown.Name = "pictureBoxBrown"
        Me.pictureBoxBrown.Size = New System.Drawing.Size(78, 75)
        Me.pictureBoxBrown.TabIndex = 3
        Me.pictureBoxBrown.TabStop = False
        ' 
        ' pictureBoxGray
        ' 
        Me.pictureBoxGray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBoxGray.Location = New System.Drawing.Point(76, 12)
        Me.pictureBoxGray.Name = "pictureBoxGray"
        Me.pictureBoxGray.Size = New System.Drawing.Size(77, 74)
        Me.pictureBoxGray.TabIndex = 1
        Me.pictureBoxGray.TabStop = False
        ' 
        ' FormSelect
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 99)
        Me.Controls.Add(Me.pictureBoxBrown)
        Me.Controls.Add(Me.radioButtonBrownOrder)
        Me.Controls.Add(Me.pictureBoxGray)
        Me.Controls.Add(Me.radioButtonGrayOrder)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSelect"
        Me.Text = "Select"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


End Class
