using System;
namespace Refrigtz
{
    partial class FormSelect
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
            this.RadioButtonGrayOrder = new System.Windows.Forms.RadioButton();
            this.RadioButtonBrownOrder = new System.Windows.Forms.RadioButton();
            this.PictureBoxBrown = new System.Windows.Forms.PictureBox();
            this.PictureBoxGray = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGray)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioButtonGrayOrder
            // 
            this.RadioButtonGrayOrder.AutoSize = true;
            this.RadioButtonGrayOrder.Checked = true;
            this.RadioButtonGrayOrder.Location = new System.Drawing.Point(34, 36);
            this.RadioButtonGrayOrder.Name = "RadioButtonGrayOrder";
            this.RadioButtonGrayOrder.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonGrayOrder.TabIndex = 0;
            this.RadioButtonGrayOrder.TabStop = true;
            this.RadioButtonGrayOrder.UseVisualStyleBackColor = true;
            this.RadioButtonGrayOrder.CheckedChanged += new System.EventHandler(this.RadioButtonGrayOrder_CheckedChanged);
            // 
            // RadioButtonBrownOrder
            // 
            this.RadioButtonBrownOrder.AutoSize = true;
            this.RadioButtonBrownOrder.Location = new System.Drawing.Point(203, 36);
            this.RadioButtonBrownOrder.Name = "RadioButtonBrownOrder";
            this.RadioButtonBrownOrder.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonBrownOrder.TabIndex = 2;
            this.RadioButtonBrownOrder.UseVisualStyleBackColor = true;
            this.RadioButtonBrownOrder.CheckedChanged += new System.EventHandler(this.RadioButtonBrownOrder_CheckedChanged);
            // 
            // PictureBoxBrown
            // 
            this.PictureBoxBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxBrown.Location = new System.Drawing.Point(258, 12);
            this.PictureBoxBrown.Name = "PictureBoxBrown";
            this.PictureBoxBrown.Size = new System.Drawing.Size(78, 75);
            this.PictureBoxBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBrown.TabIndex = 3;
            this.PictureBoxBrown.TabStop = false;
            // 
            // PictureBoxGray
            // 
            this.PictureBoxGray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxGray.Location = new System.Drawing.Point(76, 12);
            this.PictureBoxGray.Name = "PictureBoxGray";
            this.PictureBoxGray.Size = new System.Drawing.Size(77, 74);
            this.PictureBoxGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxGray.TabIndex = 1;
            this.PictureBoxGray.TabStop = false;
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 99);
            this.Controls.Add(this.PictureBoxBrown);
            this.Controls.Add(this.RadioButtonBrownOrder);
            this.Controls.Add(this.PictureBoxGray);
            this.Controls.Add(this.RadioButtonGrayOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelect";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        [field: NonSerialized]
        private System.Windows.Forms.PictureBox PictureBoxGray;
        [field: NonSerialized]
        private System.Windows.Forms.PictureBox PictureBoxBrown;
        [field: NonSerialized]
        public System.Windows.Forms.RadioButton RadioButtonGrayOrder;
        [field: NonSerialized]
        public System.Windows.Forms.RadioButton RadioButtonBrownOrder;
    }
}