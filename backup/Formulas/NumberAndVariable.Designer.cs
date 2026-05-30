namespace NumberVar
{
    partial class NumberAndVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberAndVariable));
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(35, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
            // 
            // NumberAndVariable
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(164, 42);
            Controls.Add(textBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(180, 81);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(180, 80);
            Name = "NumberAndVariable";
            Text = "NumberAndVariable";
            Load += new System.EventHandler(NumberAndVariable_Load_1);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}