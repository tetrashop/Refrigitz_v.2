using System;






















namespace Refrigtz
{
    partial class Load
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);

            }
            catch (Exception t) { Log(t); }
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(1, 3);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(276, 23);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar1.TabIndex = 0;
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(277, 27);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBar1);
            this.MaximizeBox = false;
            this.Name = "Load";
            this.ShowInTaskbar = false;
            this.Text = "Load";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Load_Load);
            this.ResumeLayout(false);

        }

        #endregion
        [field: NonSerialized]
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}