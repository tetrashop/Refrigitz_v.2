namespace Formulas
{
    partial class TraceKind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceKind));
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(12, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(56, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nodes";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(12, 33);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(96, 17);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Between Node";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // TraceKind
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(124, 51);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(120, 90);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(120, 39);
            Name = "TraceKind";
            Text = "TraceKind";
            Load += new System.EventHandler(TraceKind_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}
