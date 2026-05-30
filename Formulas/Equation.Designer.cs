namespace Formulas
{
    partial class Equation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equation));
            SuspendLayout();
            // 
            // Equation
            // 
            ClientSize = new System.Drawing.Size(384, 81);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Equation";
            Load += new System.EventHandler(Form1_Load);
            Click += new System.EventHandler(Form1_Click);
            Paint += new System.Windows.Forms.PaintEventHandler(Form1_Paint);
            MouseClick += new System.Windows.Forms.MouseEventHandler(Equation_MouseMove);
            MouseMove += new System.Windows.Forms.MouseEventHandler(Equation_MouseMove);
            Resize += new System.EventHandler(Equation_Resize);
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timer1;

    }
}

