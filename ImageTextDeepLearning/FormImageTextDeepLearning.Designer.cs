namespace ImageTextDeepLearning
{
    partial class FormImageTextDeepLearning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageTextDeepLearning));
            this.textBoxImageTextDeepLearning = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialogImageTextDeepLearning = new System.Windows.Forms.OpenFileDialog();
            this.buttonSplitationConjunction = new System.Windows.Forms.Button();
            this.PictureBoxTest = new System.Windows.Forms.PictureBox();
            this.progressBarCompleted = new System.Windows.Forms.ProgressBar();
            this.buttonTxtDetect = new System.Windows.Forms.Button();
            this.panelImageTextDeepLearning = new System.Windows.Forms.Panel();
            this.PictureBoxImageTextDeepLearning = new System.Windows.Forms.PictureBox();
            this.checkBoxDisablePaintOnAligns = new System.Windows.Forms.CheckBox();
            this.CreateConSha = new System.Windows.Forms.Button();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createConjunctionShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTxtTemplates = new System.Windows.Forms.Button();
            this.checkBoxUndetectiveFont = new System.Windows.Forms.CheckBox();
            this.comboBoxUndetectiveFont = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseCommonEnglish = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddVerb = new System.Windows.Forms.Button();
            this.checkBoxCheckonly = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTest)).BeginInit();
            this.panelImageTextDeepLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImageTextDeepLearning)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxImageTextDeepLearning
            // 
            this.textBoxImageTextDeepLearning.Location = new System.Drawing.Point(564, 7);
            this.textBoxImageTextDeepLearning.Multiline = true;
            this.textBoxImageTextDeepLearning.Name = "textBoxImageTextDeepLearning";
            this.textBoxImageTextDeepLearning.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxImageTextDeepLearning.Size = new System.Drawing.Size(357, 402);
            this.textBoxImageTextDeepLearning.TabIndex = 1;
            this.textBoxImageTextDeepLearning.Text = " رضا پسر خوبی بود. رضا سرد بود. سرد احساس بود. سارا دختر خوبی بود. سارا خوب است. " +
    "سارا با علی دوست است. علی پسر خوبی است. علی خوب است.";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(51, 415);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Visible = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialogImageTextDeepLearning
            // 
            this.openFileDialogImageTextDeepLearning.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImageTextDeepLearning_FileOk);
            // 
            // buttonSplitationConjunction
            // 
            this.buttonSplitationConjunction.Location = new System.Drawing.Point(132, 415);
            this.buttonSplitationConjunction.Name = "buttonSplitationConjunction";
            this.buttonSplitationConjunction.Size = new System.Drawing.Size(75, 23);
            this.buttonSplitationConjunction.TabIndex = 3;
            this.buttonSplitationConjunction.Text = "Splitation";
            this.buttonSplitationConjunction.UseVisualStyleBackColor = true;
            this.buttonSplitationConjunction.Visible = false;
            this.buttonSplitationConjunction.Click += new System.EventHandler(this.buttonSplitationConjunction_Click);
            // 
            // PictureBoxTest
            // 
            this.PictureBoxTest.Location = new System.Drawing.Point(294, 407);
            this.PictureBoxTest.Name = "PictureBoxTest";
            this.PictureBoxTest.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTest.TabIndex = 4;
            this.PictureBoxTest.TabStop = false;
            this.PictureBoxTest.Click += new System.EventHandler(this.PictureBoxTest_Click);
            // 
            // progressBarCompleted
            // 
            this.progressBarCompleted.Location = new System.Drawing.Point(530, 415);
            this.progressBarCompleted.Name = "progressBarCompleted";
            this.progressBarCompleted.Size = new System.Drawing.Size(391, 23);
            this.progressBarCompleted.TabIndex = 5;
            this.progressBarCompleted.VisibleChanged += new System.EventHandler(this.progressBarCompleted_VisibleChanged);
            this.progressBarCompleted.Click += new System.EventHandler(this.progressBarCompleted_Click);
            this.progressBarCompleted.Validating += new System.ComponentModel.CancelEventHandler(this.progressBarCompleted_Validating);
            // 
            // buttonTxtDetect
            // 
            this.buttonTxtDetect.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTxtDetect.Location = new System.Drawing.Point(331, 415);
            this.buttonTxtDetect.Name = "buttonTxtDetect";
            this.buttonTxtDetect.Size = new System.Drawing.Size(75, 23);
            this.buttonTxtDetect.TabIndex = 6;
            this.buttonTxtDetect.Text = "TxtDetect";
            this.buttonTxtDetect.UseVisualStyleBackColor = false;
            this.buttonTxtDetect.Click += new System.EventHandler(this.buttonTxtDetect_Click);
            // 
            // panelImageTextDeepLearning
            // 
            this.panelImageTextDeepLearning.AutoScroll = true;
            this.panelImageTextDeepLearning.Controls.Add(this.PictureBoxImageTextDeepLearning);
            this.panelImageTextDeepLearning.Location = new System.Drawing.Point(24, 27);
            this.panelImageTextDeepLearning.Name = "panelImageTextDeepLearning";
            this.panelImageTextDeepLearning.Size = new System.Drawing.Size(534, 369);
            this.panelImageTextDeepLearning.TabIndex = 7;
            // 
            // PictureBoxImageTextDeepLearning
            // 
            this.PictureBoxImageTextDeepLearning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxImageTextDeepLearning.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxImageTextDeepLearning.Image")));
            this.PictureBoxImageTextDeepLearning.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxImageTextDeepLearning.Name = "PictureBoxImageTextDeepLearning";
            this.PictureBoxImageTextDeepLearning.Size = new System.Drawing.Size(1013, 619);
            this.PictureBoxImageTextDeepLearning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxImageTextDeepLearning.TabIndex = 1;
            this.PictureBoxImageTextDeepLearning.TabStop = false;
            this.PictureBoxImageTextDeepLearning.Click += new System.EventHandler(this.PictureBoxImageTextDeepLearning_Click);
            this.PictureBoxImageTextDeepLearning.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxImageTextDeepLearning_Paint);
            // 
            // checkBoxDisablePaintOnAligns
            // 
            this.checkBoxDisablePaintOnAligns.AutoSize = true;
            this.checkBoxDisablePaintOnAligns.Location = new System.Drawing.Point(356, 392);
            this.checkBoxDisablePaintOnAligns.Name = "checkBoxDisablePaintOnAligns";
            this.checkBoxDisablePaintOnAligns.Size = new System.Drawing.Size(136, 17);
            this.checkBoxDisablePaintOnAligns.TabIndex = 2;
            this.checkBoxDisablePaintOnAligns.Text = "Disable Paint On Aligns";
            this.checkBoxDisablePaintOnAligns.UseVisualStyleBackColor = true;
            this.checkBoxDisablePaintOnAligns.CheckedChanged += new System.EventHandler(this.checkBoxDisablePaintOnAligns_CheckedChanged);
            // 
            // CreateConSha
            // 
            this.CreateConSha.Location = new System.Drawing.Point(213, 415);
            this.CreateConSha.Name = "CreateConSha";
            this.CreateConSha.Size = new System.Drawing.Size(75, 23);
            this.CreateConSha.TabIndex = 8;
            this.CreateConSha.Text = "CreateConSha";
            this.CreateConSha.UseVisualStyleBackColor = true;
            this.CreateConSha.Visible = false;
            this.CreateConSha.Click += new System.EventHandler(this.CreateConSha_Click);
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Location = new System.Drawing.Point(66, 453);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 13);
            this.labelMonitor.TabIndex = 9;
            this.labelMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStripImageTextDeepLearning";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.splitationToolStripMenuItem,
            this.createConjunctionShapesToolStripMenuItem,
            this.txtDetectionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // splitationToolStripMenuItem
            // 
            this.splitationToolStripMenuItem.Name = "splitationToolStripMenuItem";
            this.splitationToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.splitationToolStripMenuItem.Text = "Splitation";
            this.splitationToolStripMenuItem.Click += new System.EventHandler(this.splitationToolStripMenuItem_Click);
            // 
            // createConjunctionShapesToolStripMenuItem
            // 
            this.createConjunctionShapesToolStripMenuItem.Name = "createConjunctionShapesToolStripMenuItem";
            this.createConjunctionShapesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.createConjunctionShapesToolStripMenuItem.Text = "Create Conjunction Shapes";
            this.createConjunctionShapesToolStripMenuItem.Click += new System.EventHandler(this.createConjunctionShapesToolStripMenuItem_Click);
            // 
            // txtDetectionToolStripMenuItem
            // 
            this.txtDetectionToolStripMenuItem.Name = "txtDetectionToolStripMenuItem";
            this.txtDetectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.txtDetectionToolStripMenuItem.Text = "TxtDetection";
            this.txtDetectionToolStripMenuItem.Click += new System.EventHandler(this.txtDetectionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonTxtTemplates
            // 
            this.buttonTxtTemplates.Location = new System.Drawing.Point(420, 415);
            this.buttonTxtTemplates.Name = "buttonTxtTemplates";
            this.buttonTxtTemplates.Size = new System.Drawing.Size(82, 23);
            this.buttonTxtTemplates.TabIndex = 11;
            this.buttonTxtTemplates.Text = "TxtTemplatets";
            this.buttonTxtTemplates.UseVisualStyleBackColor = true;
            this.buttonTxtTemplates.Visible = false;
            this.buttonTxtTemplates.Click += new System.EventHandler(this.buttonTxtTemplates_Click);
            // 
            // checkBoxUndetectiveFont
            // 
            this.checkBoxUndetectiveFont.AutoSize = true;
            this.checkBoxUndetectiveFont.Location = new System.Drawing.Point(21, 20);
            this.checkBoxUndetectiveFont.Name = "checkBoxUndetectiveFont";
            this.checkBoxUndetectiveFont.Size = new System.Drawing.Size(108, 17);
            this.checkBoxUndetectiveFont.TabIndex = 12;
            this.checkBoxUndetectiveFont.Text = "Undetective Font";
            this.checkBoxUndetectiveFont.UseVisualStyleBackColor = true;
            this.checkBoxUndetectiveFont.CheckedChanged += new System.EventHandler(this.checkBoxUndetectiveFont_CheckedChanged);
            // 
            // comboBoxUndetectiveFont
            // 
            this.comboBoxUndetectiveFont.FormattingEnabled = true;
            this.comboBoxUndetectiveFont.Location = new System.Drawing.Point(135, 16);
            this.comboBoxUndetectiveFont.Name = "comboBoxUndetectiveFont";
            this.comboBoxUndetectiveFont.Size = new System.Drawing.Size(287, 21);
            this.comboBoxUndetectiveFont.TabIndex = 13;
            this.comboBoxUndetectiveFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxUndetectiveFont_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUndetectiveFont);
            this.groupBox1.Controls.Add(this.checkBoxUndetectiveFont);
            this.groupBox1.Location = new System.Drawing.Point(51, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 43);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxUseCommonEnglish
            // 
            this.checkBoxUseCommonEnglish.AutoSize = true;
            this.checkBoxUseCommonEnglish.Location = new System.Drawing.Point(509, 459);
            this.checkBoxUseCommonEnglish.Name = "checkBoxUseCommonEnglish";
            this.checkBoxUseCommonEnglish.Size = new System.Drawing.Size(156, 17);
            this.checkBoxUseCommonEnglish.TabIndex = 15;
            this.checkBoxUseCommonEnglish.Text = "Use common English letters";
            this.checkBoxUseCommonEnglish.UseVisualStyleBackColor = true;
            this.checkBoxUseCommonEnglish.CheckedChanged += new System.EventHandler(this.checkBoxUseCommonEnglish_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(671, 459);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "use {a,3, i, }";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Text Mining";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(848, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAddVerb
            // 
            this.buttonAddVerb.Location = new System.Drawing.Point(848, 444);
            this.buttonAddVerb.Name = "buttonAddVerb";
            this.buttonAddVerb.Size = new System.Drawing.Size(66, 23);
            this.buttonAddVerb.TabIndex = 19;
            this.buttonAddVerb.Text = "Add verb";
            this.buttonAddVerb.UseVisualStyleBackColor = true;
            this.buttonAddVerb.Visible = false;
            this.buttonAddVerb.Click += new System.EventHandler(this.buttonAddVerb_Click);
            // 
            // checkBoxCheckonly
            // 
            this.checkBoxCheckonly.AutoSize = true;
            this.checkBoxCheckonly.Location = new System.Drawing.Point(509, 480);
            this.checkBoxCheckonly.Name = "checkBoxCheckonly";
            this.checkBoxCheckonly.Size = new System.Drawing.Size(80, 17);
            this.checkBoxCheckonly.TabIndex = 20;
            this.checkBoxCheckonly.Text = "Only check";
            this.checkBoxCheckonly.UseVisualStyleBackColor = true;
            this.checkBoxCheckonly.Visible = false;
            this.checkBoxCheckonly.CheckedChanged += new System.EventHandler(this.checkBoxCheckonly_CheckedChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(595, 474);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Items.AddRange(new object[] {
            "Sample",
            "Reference"});
            this.comboBoxKind.Location = new System.Drawing.Point(676, 476);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(77, 21);
            this.comboBoxKind.TabIndex = 22;
            this.comboBoxKind.Visible = false;
            this.comboBoxKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxKind_SelectedIndexChanged);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(761, 474);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(73, 21);
            this.comboBoxItem.TabIndex = 23;
            this.comboBoxItem.Visible = false;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // FormImageTextDeepLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 498);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.comboBoxKind);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.checkBoxCheckonly);
            this.Controls.Add(this.buttonAddVerb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxUseCommonEnglish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTxtTemplates);
            this.Controls.Add(this.labelMonitor);
            this.Controls.Add(this.CreateConSha);
            this.Controls.Add(this.checkBoxDisablePaintOnAligns);
            this.Controls.Add(this.panelImageTextDeepLearning);
            this.Controls.Add(this.buttonTxtDetect);
            this.Controls.Add(this.progressBarCompleted);
            this.Controls.Add(this.PictureBoxTest);
            this.Controls.Add(this.buttonSplitationConjunction);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxImageTextDeepLearning);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormImageTextDeepLearning";
            this.Text = "FormImageTextDeepLearning";
            this.Load += new System.EventHandler(this.FormImageTextDeepLearning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTest)).EndInit();
            this.panelImageTextDeepLearning.ResumeLayout(false);
            this.panelImageTextDeepLearning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImageTextDeepLearning)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxImageTextDeepLearning;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogImageTextDeepLearning;
        private System.Windows.Forms.Button buttonSplitationConjunction;
        private System.Windows.Forms.PictureBox PictureBoxTest;
        private System.Windows.Forms.ProgressBar progressBarCompleted;
        private System.Windows.Forms.Button buttonTxtDetect;
        private System.Windows.Forms.Panel panelImageTextDeepLearning;
        private System.Windows.Forms.PictureBox PictureBoxImageTextDeepLearning;
        private System.Windows.Forms.CheckBox checkBoxDisablePaintOnAligns;
        private System.Windows.Forms.Button CreateConSha;
        public System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createConjunctionShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtDetectionToolStripMenuItem;
        private System.Windows.Forms.Button buttonTxtTemplates;
        private System.Windows.Forms.CheckBox checkBoxUndetectiveFont;
        private System.Windows.Forms.ComboBox comboBoxUndetectiveFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUseCommonEnglish;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddVerb;
        private System.Windows.Forms.CheckBox checkBoxCheckonly;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.ComboBox comboBoxItem;
    }
}

