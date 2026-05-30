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
            this.SuspendLayout();
            // 
            // Parantez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 61);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(80, 100);
            this.MinimumSize = new System.Drawing.Size(80, 100);
            this.Name = "Parantez";
            this.Text = "Parantez";
            this.Load += new System.EventHandler(this.Parantez_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Parantez_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Parantez_Mouseclick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Parantez_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Parantez_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}