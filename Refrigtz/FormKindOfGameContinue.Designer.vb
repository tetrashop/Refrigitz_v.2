Namespace Refrigtz
	Partial Class FormKindOfGameContinue
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radioButtonGeneticGame = New System.Windows.Forms.RadioButton()
			Me.radioButtonComputerByPerson = New System.Windows.Forms.RadioButton()
			Me.radioButtonComputerByComputer = New System.Windows.Forms.RadioButton()
			Me.comboBoxDataBase = New System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			' 
			' radioButtonGeneticGame
			' 
			Me.radioButtonGeneticGame.AutoSize = True
			Me.radioButtonGeneticGame.Location = New System.Drawing.Point(316, 38)
			Me.radioButtonGeneticGame.Name = "radioButtonGeneticGame"
			Me.radioButtonGeneticGame.Size = New System.Drawing.Size(93, 17)
			Me.radioButtonGeneticGame.TabIndex = 0
			Me.radioButtonGeneticGame.TabStop = True
			Me.radioButtonGeneticGame.Text = "Genetic Game"
			Me.radioButtonGeneticGame.UseVisualStyleBackColor = True
			' 
			' radioButtonComputerByPerson
			' 
			Me.radioButtonComputerByPerson.AutoSize = True
			Me.radioButtonComputerByPerson.Location = New System.Drawing.Point(174, 38)
			Me.radioButtonComputerByPerson.Name = "radioButtonComputerByPerson"
			Me.radioButtonComputerByPerson.Size = New System.Drawing.Size(121, 17)
			Me.radioButtonComputerByPerson.TabIndex = 1
			Me.radioButtonComputerByPerson.TabStop = True
			Me.radioButtonComputerByPerson.Text = "Computer By Person"
			Me.radioButtonComputerByPerson.UseVisualStyleBackColor = True
			' 
			' radioButtonComputerByComputer
			' 
			Me.radioButtonComputerByComputer.AutoSize = True
			Me.radioButtonComputerByComputer.Location = New System.Drawing.Point(33, 38)
			Me.radioButtonComputerByComputer.Name = "radioButtonComputerByComputer"
			Me.radioButtonComputerByComputer.Size = New System.Drawing.Size(133, 17)
			Me.radioButtonComputerByComputer.TabIndex = 2
			Me.radioButtonComputerByComputer.TabStop = True
			Me.radioButtonComputerByComputer.Text = "Computer By Computer"
			Me.radioButtonComputerByComputer.UseVisualStyleBackColor = True
			' 
			' comboBoxDataBase
			' 
			Me.comboBoxDataBase.FormattingEnabled = True
			Me.comboBoxDataBase.Location = New System.Drawing.Point(161, 61)
			Me.comboBoxDataBase.Name = "comboBoxDataBase"
			Me.comboBoxDataBase.Size = New System.Drawing.Size(121, 21)
			Me.comboBoxDataBase.TabIndex = 3
			' 
			' FormKindOfGameContinue
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(436, 94)
			Me.Controls.Add(Me.comboBoxDataBase)
			Me.Controls.Add(Me.radioButtonComputerByComputer)
			Me.Controls.Add(Me.radioButtonComputerByPerson)
			Me.Controls.Add(Me.radioButtonGeneticGame)
			Me.Name = "FormKindOfGameContinue"
			Me.Text = "FormKindOfGameContinue"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormKindOfGameContinue_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Public radioButtonGeneticGame As System.Windows.Forms.RadioButton
		Public radioButtonComputerByPerson As System.Windows.Forms.RadioButton
		Public radioButtonComputerByComputer As System.Windows.Forms.RadioButton
		Public comboBoxDataBase As System.Windows.Forms.ComboBox
	End Class
End Namespace