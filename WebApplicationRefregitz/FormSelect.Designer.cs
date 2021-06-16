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
            this.radioButtonGrayOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonBrownOrder = new System.Windows.Forms.RadioButton();
            this.pictureBoxBrown = new System.Windows.Forms.PictureBox();
            this.pictureBoxGray = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonGrayOrder
            // 
            this.radioButtonGrayOrder.AutoSize = true;
            this.radioButtonGrayOrder.Checked = true;
            this.radioButtonGrayOrder.Location = new System.Drawing.Point(34, 36);
            this.radioButtonGrayOrder.Name = "radioButtonGrayOrder";
            this.radioButtonGrayOrder.Size = new System.Drawing.Size(14, 13);
            this.radioButtonGrayOrder.TabIndex = 0;
            this.radioButtonGrayOrder.TabStop = true;
            this.radioButtonGrayOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrownOrder
            // 
            this.radioButtonBrownOrder.AutoSize = true;
            this.radioButtonBrownOrder.Location = new System.Drawing.Point(203, 36);
            this.radioButtonBrownOrder.Name = "radioButtonBrownOrder";
            this.radioButtonBrownOrder.Size = new System.Drawing.Size(14, 13);
            this.radioButtonBrownOrder.TabIndex = 2;
            this.radioButtonBrownOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBrown
            // 
            this.pictureBoxBrown.BackgroundImage = global::Refrigtz.Properties.Resources.KB;
            this.pictureBoxBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBrown.Location = new System.Drawing.Point(258, 12);
            this.pictureBoxBrown.Name = "pictureBoxBrown";
            this.pictureBoxBrown.Size = new System.Drawing.Size(78, 75);
            this.pictureBoxBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBrown.TabIndex = 3;
            this.pictureBoxBrown.TabStop = false;
            // 
            // pictureBoxGray
            // 
            this.pictureBoxGray.BackgroundImage = global::Refrigtz.Properties.Resources.KG;
            this.pictureBoxGray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGray.Location = new System.Drawing.Point(76, 12);
            this.pictureBoxGray.Name = "pictureBoxGray";
            this.pictureBoxGray.Size = new System.Drawing.Size(77, 74);
            this.pictureBoxGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGray.TabIndex = 1;
            this.pictureBoxGray.TabStop = false;
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 99);
            this.Controls.Add(this.pictureBoxBrown);
            this.Controls.Add(this.radioButtonBrownOrder);
            this.Controls.Add(this.pictureBoxGray);
            this.Controls.Add(this.radioButtonGrayOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelect";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGray;
        private System.Windows.Forms.PictureBox pictureBoxBrown;
        public System.Windows.Forms.RadioButton radioButtonGrayOrder;
        public System.Windows.Forms.RadioButton radioButtonBrownOrder;
    }
}