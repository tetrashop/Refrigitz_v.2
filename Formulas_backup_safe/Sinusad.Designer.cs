namespace Formulas
{
    partial class Sinusad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="dispoSing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool dispoSing)
        {
            if (dispoSing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(dispoSing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinusad));
            this.SuspendLayout();
            // 
            // Sinusad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 81);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 120);
            this.Name = "Sinusad";
            this.Text = "Sinusad";
            this.Activated += new System.EventHandler(this.Sinusad_Activated);
            this.Load += new System.EventHandler(this.Sinusad_Load);
            this.Click += new System.EventHandler(this.Sinusad_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Sinusad_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sinusad_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}