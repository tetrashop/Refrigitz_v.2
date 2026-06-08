






















namespace WebJobRefregitz
{
    partial class FormTXT
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
            this.textBoxTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTXT
            // 
            this.textBoxTXT.Location = new System.Drawing.Point(13, 13);
            this.textBoxTXT.Multiline = true;
            this.textBoxTXT.Name = "textBoxTXT";
            this.textBoxTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTXT.Size = new System.Drawing.Size(1307, 563);
            this.textBoxTXT.TabIndex = 0;
            this.textBoxTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 588);
            this.Controls.Add(this.textBoxTXT);
            this.Name = "FormTXT";
            this.Text = "FormTXT";
            this.Load += new System.EventHandler(this.FormTXT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTXT;
    }
}