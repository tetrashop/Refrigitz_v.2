namespace Setup
{
    partial class Install
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Install));
            this.buttonInstall = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.checkBoxLanchAndShortcut = new System.Windows.Forms.CheckBox();
            this.labelState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInstall
            // 
            this.buttonInstall.BackgroundImage = global::Setup.Properties.Resources.imagesIU2UZCZR1;
            this.buttonInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstall.Location = new System.Drawing.Point(300, 300);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(90, 30);
            this.buttonInstall.TabIndex = 4;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ErrorImage = null;
            this.pictureBoxLogo.Image = global::Setup.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(430, 114);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // checkBoxLanchAndShortcut
            // 
            this.checkBoxLanchAndShortcut.AutoSize = true;
            this.checkBoxLanchAndShortcut.Checked = true;
            this.checkBoxLanchAndShortcut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLanchAndShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLanchAndShortcut.Location = new System.Drawing.Point(37, 196);
            this.checkBoxLanchAndShortcut.Name = "checkBoxLanchAndShortcut";
            this.checkBoxLanchAndShortcut.Size = new System.Drawing.Size(224, 24);
            this.checkBoxLanchAndShortcut.TabIndex = 5;
            this.checkBoxLanchAndShortcut.Text = "Launch and Create Shorcut";
            this.checkBoxLanchAndShortcut.UseVisualStyleBackColor = true;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(37, 259);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(0, 13);
            this.labelState.TabIndex = 6;
            // 
            // Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Setup.Properties.Resources.images16WPDQQR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 351);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.checkBoxLanchAndShortcut);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Install";
            this.Text = "Install";
            this.Load += new System.EventHandler(this.Install_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.CheckBox checkBoxLanchAndShortcut;
        private System.Windows.Forms.Label labelState;
    }
}