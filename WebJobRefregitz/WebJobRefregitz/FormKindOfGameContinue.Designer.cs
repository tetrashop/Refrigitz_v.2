






















namespace WebJobRefregitz
{
    partial class FormKindOfGameContinue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonGeneticGame = new System.Windows.Forms.RadioButton();
            this.radioButtonComputerByPerson = new System.Windows.Forms.RadioButton();
            this.radioButtonComputerByComputer = new System.Windows.Forms.RadioButton();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.radioButtonBlitz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonGeneticGame
            // 
            this.radioButtonGeneticGame.AutoSize = true;
            this.radioButtonGeneticGame.Location = new System.Drawing.Point(278, 38);
            this.radioButtonGeneticGame.Name = "radioButtonGeneticGame";
            this.radioButtonGeneticGame.Size = new System.Drawing.Size(93, 17);
            this.radioButtonGeneticGame.TabIndex = 0;
            this.radioButtonGeneticGame.TabStop = true;
            this.radioButtonGeneticGame.Text = "Genetic Game";
            this.radioButtonGeneticGame.UseVisualStyleBackColor = true;
            // 
            // radioButtonComputerByPerson
            // 
            this.radioButtonComputerByPerson.AutoSize = true;
            this.radioButtonComputerByPerson.Location = new System.Drawing.Point(151, 38);
            this.radioButtonComputerByPerson.Name = "radioButtonComputerByPerson";
            this.radioButtonComputerByPerson.Size = new System.Drawing.Size(121, 17);
            this.radioButtonComputerByPerson.TabIndex = 1;
            this.radioButtonComputerByPerson.TabStop = true;
            this.radioButtonComputerByPerson.Text = "Computer By Person";
            this.radioButtonComputerByPerson.UseVisualStyleBackColor = true;
            // 
            // radioButtonComputerByComputer
            // 
            this.radioButtonComputerByComputer.AutoSize = true;
            this.radioButtonComputerByComputer.Location = new System.Drawing.Point(12, 38);
            this.radioButtonComputerByComputer.Name = "radioButtonComputerByComputer";
            this.radioButtonComputerByComputer.Size = new System.Drawing.Size(133, 17);
            this.radioButtonComputerByComputer.TabIndex = 2;
            this.radioButtonComputerByComputer.TabStop = true;
            this.radioButtonComputerByComputer.Text = "Computer By Computer";
            this.radioButtonComputerByComputer.UseVisualStyleBackColor = true;
            this.radioButtonComputerByComputer.CheckedChanged += new System.EventHandler(this.radioButtonComputerByComputer_CheckedChanged);
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(161, 61);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDatabase.TabIndex = 3;
            this.comboBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBase_SelectedIndexChanged);
            // 
            // radioButtonBlitz
            // 
            this.radioButtonBlitz.AutoSize = true;
            this.radioButtonBlitz.Location = new System.Drawing.Point(378, 38);
            this.radioButtonBlitz.Name = "radioButtonBlitz";
            this.radioButtonBlitz.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBlitz.TabIndex = 4;
            this.radioButtonBlitz.TabStop = true;
            this.radioButtonBlitz.Text = "Blitz";
            this.radioButtonBlitz.UseVisualStyleBackColor = true;
            // 
            // FormKindOfGameContinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 94);
            this.Controls.Add(this.radioButtonBlitz);
            this.Controls.Add(this.comboBoxDatabase);
            this.Controls.Add(this.radioButtonComputerByComputer);
            this.Controls.Add(this.radioButtonComputerByPerson);
            this.Controls.Add(this.radioButtonGeneticGame);
            this.Name = "FormKindOfGameContinue";
            this.Text = "FormKindOfGameContinue";
            this.Load += new System.EventHandler(this.FormKindOfGameContinue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radioButtonGeneticGame;
        public System.Windows.Forms.RadioButton radioButtonComputerByPerson;
        public System.Windows.Forms.RadioButton radioButtonComputerByComputer;
        public System.Windows.Forms.ComboBox comboBoxDatabase;
        public System.Windows.Forms.RadioButton radioButtonBlitz;
    }
}