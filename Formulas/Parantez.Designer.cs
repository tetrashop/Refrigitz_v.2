namespace Formulas
{
    partial class Parantez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parantez));
            SuspendLayout();
            // 
            // Parantez
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(124, 61);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximumSize = new System.Drawing.Size(80, 100);
            MinimumSize = new System.Drawing.Size(80, 100);
            Name = "Parantez";
            Text = "Parantez";
            Load += new System.EventHandler(Parantez_Load);
            Paint += new System.Windows.Forms.PaintEventHandler(Parantez_Paint);
            MouseClick += new System.Windows.Forms.MouseEventHandler(Parantez_Mouseclick);
            MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(Parantez_MouseDoubleClick);
            MouseMove += new System.Windows.Forms.MouseEventHandler(Parantez_MouseMove);
            ResumeLayout(false);

        }

        #endregion
    }
}