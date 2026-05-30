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
            SuspendLayout();
            // 
            // Sinusad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(184, 81);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(200, 120);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(200, 120);
            Name = "Sinusad";
            Text = "Sinusad";
            Activated += new System.EventHandler(Sinusad_Activated);
            Load += new System.EventHandler(Sinusad_Load);
            Click += new System.EventHandler(Sinusad_Click);
            Paint += new System.Windows.Forms.PaintEventHandler(Sinusad_Paint);
            MouseMove += new System.Windows.Forms.MouseEventHandler(Sinusad_MouseMove);
            ResumeLayout(false);

        }

        #endregion
    }
}