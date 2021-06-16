namespace Editors
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.pictureBoxInOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInOut
            // 
            this.pictureBoxInOut.Location = new System.Drawing.Point(12, 429);
            this.pictureBoxInOut.Name = "pictureBoxInOut";
            this.pictureBoxInOut.Size = new System.Drawing.Size(553, 11000);
            this.pictureBoxInOut.TabIndex = 0;
            this.pictureBoxInOut.TabStop = false;
            this.pictureBoxInOut.Click += new System.EventHandler(this.pictureBoxInOut_Click);
            this.pictureBoxInOut.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxInOut_Paint);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(600, 10000);
            this.AutoScrollMinSize = new System.Drawing.Size(600, 10000);
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 577);
            this.Controls.Add(this.pictureBoxInOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 10000);
            this.MinimumSize = new System.Drawing.Size(500, 568);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Editor_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxInOut;



    }
}