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
            pictureBoxInOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxInOut)).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxInOut
            // 
            pictureBoxInOut.Location = new System.Drawing.Point(12, 429);
            pictureBoxInOut.Name = "pictureBoxInOut";
            pictureBoxInOut.Size = new System.Drawing.Size(553, 11000);
            pictureBoxInOut.TabIndex = 0;
            pictureBoxInOut.TabStop = false;
            pictureBoxInOut.Click += new System.EventHandler(pictureBoxInOut_Click);
            pictureBoxInOut.Paint += new System.Windows.Forms.PaintEventHandler(pictureBoxInOut_Paint);
            // 
            // Editor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new System.Drawing.Size(600, 10000);
            AutoScrollMinSize = new System.Drawing.Size(600, 10000);
            AutoSize = true;
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(584, 577);
            Controls.Add(pictureBoxInOut);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(600, 10000);
            MinimumSize = new System.Drawing.Size(500, 568);
            Name = "Editor";
            Text = "Editor";
            Load += new System.EventHandler(Editor_Load);
            Paint += new System.Windows.Forms.PaintEventHandler(Editor_Paint);
            ((System.ComponentModel.ISupportInitialize)(pictureBoxInOut)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxInOut;



    }
}
