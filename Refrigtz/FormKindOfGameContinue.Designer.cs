using System;
namespace Refrigtz
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
            this.RadioButtonGeneticGame = new System.Windows.Forms.RadioButton();
            this.RadioButtonComputerByPerson = new System.Windows.Forms.RadioButton();
            this.RadioButtonComputerByComputer = new System.Windows.Forms.RadioButton();
            this.ComboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.RadioButtonBlitz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RadioButtonGeneticGame
            // 
            this.RadioButtonGeneticGame.AutoSize = true;
            this.RadioButtonGeneticGame.Location = new System.Drawing.Point(278, 38);
            this.RadioButtonGeneticGame.Name = "RadioButtonGeneticGame";
            this.RadioButtonGeneticGame.Size = new System.Drawing.Size(93, 17);
            this.RadioButtonGeneticGame.TabIndex = 0;
            this.RadioButtonGeneticGame.TabStop = true;
            this.RadioButtonGeneticGame.Text = "Genetic Game";
            this.RadioButtonGeneticGame.UseVisualStyleBackColor = true;
            // 
            // RadioButtonComputerByPerson
            // 
            this.RadioButtonComputerByPerson.AutoSize = true;
            this.RadioButtonComputerByPerson.Location = new System.Drawing.Point(151, 38);
            this.RadioButtonComputerByPerson.Name = "RadioButtonComputerByPerson";
            this.RadioButtonComputerByPerson.Size = new System.Drawing.Size(121, 17);
            this.RadioButtonComputerByPerson.TabIndex = 1;
            this.RadioButtonComputerByPerson.TabStop = true;
            this.RadioButtonComputerByPerson.Text = "Computer By Person";
            this.RadioButtonComputerByPerson.UseVisualStyleBackColor = true;
            // 
            // RadioButtonComputerByComputer
            // 
            this.RadioButtonComputerByComputer.AutoSize = true;
            this.RadioButtonComputerByComputer.Location = new System.Drawing.Point(12, 38);
            this.RadioButtonComputerByComputer.Name = "RadioButtonComputerByComputer";
            this.RadioButtonComputerByComputer.Size = new System.Drawing.Size(133, 17);
            this.RadioButtonComputerByComputer.TabIndex = 2;
            this.RadioButtonComputerByComputer.TabStop = true;
            this.RadioButtonComputerByComputer.Text = "Computer By Computer";
            this.RadioButtonComputerByComputer.UseVisualStyleBackColor = true;
            this.RadioButtonComputerByComputer.CheckedChanged += new System.EventHandler(this.RadioButtonComputerByComputer_CheckedChanged);
            // 
            // ComboBoxDatabase
            // 
            this.ComboBoxDatabase.FormattingEnabled = true;
            this.ComboBoxDatabase.Location = new System.Drawing.Point(161, 61);
            this.ComboBoxDatabase.Name = "ComboBoxDatabase";
            this.ComboBoxDatabase.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDatabase.TabIndex = 3;
            this.ComboBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDatabase_SelectedIndexChanged);
            // 
            // RadioButtonBlitz
            // 
            this.RadioButtonBlitz.AutoSize = true;
            this.RadioButtonBlitz.Location = new System.Drawing.Point(378, 38);
            this.RadioButtonBlitz.Name = "RadioButtonBlitz";
            this.RadioButtonBlitz.Size = new System.Drawing.Size(44, 17);
            this.RadioButtonBlitz.TabIndex = 4;
            this.RadioButtonBlitz.TabStop = true;
            this.RadioButtonBlitz.Text = "Blitz";
            this.RadioButtonBlitz.UseVisualStyleBackColor = true;
            // 
            // FormKindOfGameContinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 94);
            this.Controls.Add(this.RadioButtonBlitz);
            this.Controls.Add(this.ComboBoxDatabase);
            this.Controls.Add(this.RadioButtonComputerByComputer);
            this.Controls.Add(this.RadioButtonComputerByPerson);
            this.Controls.Add(this.RadioButtonGeneticGame);
            this.Name = "FormKindOfGameContinue";
            this.Text = "FormKindOfGameContinue";
            this.Load += new System.EventHandler(this.FormKindOfGameContinue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        [field: NonSerialized]
        public System.Windows.Forms.RadioButton RadioButtonGeneticGame;
        [field: NonSerialized]
        public System.Windows.Forms.RadioButton RadioButtonComputerByPerson;
        [field: NonSerialized]
        public System.Windows.Forms.RadioButton RadioButtonComputerByComputer;
        [field: NonSerialized]
        public System.Windows.Forms.ComboBox ComboBoxDatabase;
        [field: NonSerialized]
        public System.Windows.Forms.RadioButton RadioButtonBlitz;
    }
}