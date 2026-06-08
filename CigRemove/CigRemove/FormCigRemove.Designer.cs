namespace CigRemove
{
    partial class FormCigRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCigRemove));
            this.button1CigIndicator = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChart = new System.Windows.Forms.Button();
            this.dataGridViewCig = new System.Windows.Forms.DataGridView();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSelectiveTime = new System.Windows.Forms.TextBox();
            this.openFileDialogBackup = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogBackup = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCig)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1CigIndicator
            // 
           // this.button1CigIndicator.BackgroundImage = global::CigRemove.Properties.Resources.imagesIU2UZCZRRun;
            this.button1CigIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1CigIndicator.Location = new System.Drawing.Point(13, 23);
            this.button1CigIndicator.Name = "button1CigIndicator";
            this.button1CigIndicator.Size = new System.Drawing.Size(86, 23);
            this.button1CigIndicator.TabIndex = 0;
            this.button1CigIndicator.Text = "CigIndicator";
            this.button1CigIndicator.UseVisualStyleBackColor = true;
            this.button1CigIndicator.Click += new System.EventHandler(this.button1CigIndicator_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(12, 52);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(385, 264);
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // buttonChart
            // 
           // this.buttonChart.BackgroundImage = global::CigRemove.Properties.Resources.imagesIU2UZCZRRun;
            this.buttonChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChart.Location = new System.Drawing.Point(136, 23);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(75, 23);
            this.buttonChart.TabIndex = 2;
            this.buttonChart.Text = "Chart";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // dataGridViewCig
            // 
            this.dataGridViewCig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCig.Location = new System.Drawing.Point(13, 52);
            this.dataGridViewCig.Name = "dataGridViewCig";
            this.dataGridViewCig.Size = new System.Drawing.Size(384, 264);
            this.dataGridViewCig.TabIndex = 3;
            this.dataGridViewCig.Visible = false;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.BackColor = System.Drawing.Color.Transparent;
            this.labelRemaining.Location = new System.Drawing.Point(239, 28);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(0, 13);
            this.labelRemaining.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem.Text = "Tools";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // textBoxSelectiveTime
            // 
            this.textBoxSelectiveTime.Location = new System.Drawing.Point(96, 4);
            this.textBoxSelectiveTime.Name = "textBoxSelectiveTime";
            this.textBoxSelectiveTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectiveTime.TabIndex = 6;
            this.textBoxSelectiveTime.TextChanged += new System.EventHandler(this.textBoxSelectiveTime_TextChanged);
            // 
            // openFileDialogBackup
            // 
            this.openFileDialogBackup.FileName = "openFileDialog1";
            // 
            // FormCigRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           // this.BackgroundImage = global::CigRemove.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 328);
            this.Controls.Add(this.textBoxSelectiveTime);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.dataGridViewCig);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.button1CigIndicator);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCigRemove";
            this.Text = "FormCigRemove";
            this.Load += new System.EventHandler(this.FormCigRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCig)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1CigIndicator;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button buttonChart;
        public System.Windows.Forms.DataGridView dataGridViewCig;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBoxSelectiveTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogBackup;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBackup;
    }
}

