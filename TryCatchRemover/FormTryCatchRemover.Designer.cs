namespace TryCatchRemover
{
    partial class FormTryCatchRemover
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnClean;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.txtPath.Location = new System.Drawing.Point(20, 80);
            this.txtPath.Size = new System.Drawing.Size(300, 23);
            this.txtPath.Text = "";

            this.btnClean.Location = new System.Drawing.Point(120, 120);
            this.btnClean.Size = new System.Drawing.Size(100, 30);
            this.btnClean.Text = "حذف try-catch";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);

            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtPath);
            this.Text = "TryCatch Remover - Refrigitz";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
