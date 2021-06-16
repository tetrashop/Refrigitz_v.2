namespace ShizoImprove
{
    partial class FormShizoImprove
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
            this.buttonSearchAndTree = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBoxWorkingProject = new System.Windows.Forms.TextBox();
            this.buttonImproveCollection = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.progressBarWorking = new System.Windows.Forms.ProgressBar();
            this.buttonSetImprove = new System.Windows.Forms.Button();
            this.buttonImproved = new System.Windows.Forms.Button();
            this.menuStripShizoImprove = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClearCach = new System.Windows.Forms.Button();
            this.buttonActOnFileHistory = new System.Windows.Forms.Button();
            this.checkBoxActOnSuffixes = new System.Windows.Forms.CheckBox();
            this.menuStripShizoImprove.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearchAndTree
            // 
            this.buttonSearchAndTree.Location = new System.Drawing.Point(695, 12);
            this.buttonSearchAndTree.Name = "buttonSearchAndTree";
            this.buttonSearchAndTree.Size = new System.Drawing.Size(93, 23);
            this.buttonSearchAndTree.TabIndex = 0;
            this.buttonSearchAndTree.Text = "SearchAndTree";
            this.buttonSearchAndTree.UseVisualStyleBackColor = true;
            this.buttonSearchAndTree.Click += new System.EventHandler(this.buttonSearchAndTree_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 95);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(657, 304);
            this.treeView1.TabIndex = 1;
            // 
            // textBoxWorkingProject
            // 
            this.textBoxWorkingProject.Location = new System.Drawing.Point(104, 69);
            this.textBoxWorkingProject.Name = "textBoxWorkingProject";
            this.textBoxWorkingProject.Size = new System.Drawing.Size(321, 20);
            this.textBoxWorkingProject.TabIndex = 2;
            this.textBoxWorkingProject.Text = "ExcellManagement";
            // 
            // buttonImproveCollection
            // 
            this.buttonImproveCollection.Location = new System.Drawing.Point(675, 41);
            this.buttonImproveCollection.Name = "buttonImproveCollection";
            this.buttonImproveCollection.Size = new System.Drawing.Size(113, 23);
            this.buttonImproveCollection.TabIndex = 3;
            this.buttonImproveCollection.Text = "ImproveCollection";
            this.buttonImproveCollection.UseVisualStyleBackColor = true;
            this.buttonImproveCollection.Click += new System.EventHandler(this.buttonImproveCollection_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(104, 14);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(565, 20);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.Text = "D:\\";
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(104, 43);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(565, 20);
            this.textBoxOutput.TabIndex = 5;
            this.textBoxOutput.Text = "C:\\ShizoImprove\\";
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // progressBarWorking
            // 
            this.progressBarWorking.Location = new System.Drawing.Point(13, 415);
            this.progressBarWorking.Name = "progressBarWorking";
            this.progressBarWorking.Size = new System.Drawing.Size(656, 23);
            this.progressBarWorking.TabIndex = 6;
            // 
            // buttonSetImprove
            // 
            this.buttonSetImprove.Location = new System.Drawing.Point(675, 70);
            this.buttonSetImprove.Name = "buttonSetImprove";
            this.buttonSetImprove.Size = new System.Drawing.Size(113, 23);
            this.buttonSetImprove.TabIndex = 7;
            this.buttonSetImprove.Text = "SetImprove";
            this.buttonSetImprove.UseVisualStyleBackColor = true;
            this.buttonSetImprove.Click += new System.EventHandler(this.buttonSetImprove_Click);
            // 
            // buttonImproved
            // 
            this.buttonImproved.Enabled = false;
            this.buttonImproved.Location = new System.Drawing.Point(676, 100);
            this.buttonImproved.Name = "buttonImproved";
            this.buttonImproved.Size = new System.Drawing.Size(112, 23);
            this.buttonImproved.TabIndex = 8;
            this.buttonImproved.Text = "Improved";
            this.buttonImproved.UseVisualStyleBackColor = true;
            this.buttonImproved.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStripShizoImprove
            // 
            this.menuStripShizoImprove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStripShizoImprove.Location = new System.Drawing.Point(0, 0);
            this.menuStripShizoImprove.Name = "menuStripShizoImprove";
            this.menuStripShizoImprove.Size = new System.Drawing.Size(800, 24);
            this.menuStripShizoImprove.TabIndex = 9;
            this.menuStripShizoImprove.Text = "menuStripShizoImprove";
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
            // buttonClearCach
            // 
            this.buttonClearCach.Location = new System.Drawing.Point(675, 158);
            this.buttonClearCach.Name = "buttonClearCach";
            this.buttonClearCach.Size = new System.Drawing.Size(112, 23);
            this.buttonClearCach.TabIndex = 10;
            this.buttonClearCach.Text = "ClearCach";
            this.buttonClearCach.UseVisualStyleBackColor = true;
            this.buttonClearCach.Click += new System.EventHandler(this.buttonClearCach_Click);
            // 
            // buttonActOnFileHistory
            // 
            this.buttonActOnFileHistory.Location = new System.Drawing.Point(676, 129);
            this.buttonActOnFileHistory.Name = "buttonActOnFileHistory";
            this.buttonActOnFileHistory.Size = new System.Drawing.Size(111, 23);
            this.buttonActOnFileHistory.TabIndex = 11;
            this.buttonActOnFileHistory.Text = "ActOnFileHistory";
            this.buttonActOnFileHistory.UseVisualStyleBackColor = true;
            this.buttonActOnFileHistory.Click += new System.EventHandler(this.buttonActOnFileHistory_Click);
            // 
            // checkBoxActOnSuffixes
            // 
            this.checkBoxActOnSuffixes.AutoSize = true;
            this.checkBoxActOnSuffixes.Location = new System.Drawing.Point(676, 206);
            this.checkBoxActOnSuffixes.Name = "checkBoxActOnSuffixes";
            this.checkBoxActOnSuffixes.Size = new System.Drawing.Size(97, 17);
            this.checkBoxActOnSuffixes.TabIndex = 12;
            this.checkBoxActOnSuffixes.Text = "Act on Suffixes";
            this.checkBoxActOnSuffixes.UseVisualStyleBackColor = true;
            this.checkBoxActOnSuffixes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormShizoImprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxActOnSuffixes);
            this.Controls.Add(this.buttonActOnFileHistory);
            this.Controls.Add(this.buttonClearCach);
            this.Controls.Add(this.buttonImproved);
            this.Controls.Add(this.buttonSetImprove);
            this.Controls.Add(this.progressBarWorking);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonImproveCollection);
            this.Controls.Add(this.textBoxWorkingProject);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonSearchAndTree);
            this.Controls.Add(this.menuStripShizoImprove);
            this.MainMenuStrip = this.menuStripShizoImprove;
            this.Name = "FormShizoImprove";
            this.Text = "FormShizoImprove";
            this.Load += new System.EventHandler(this.FormShizoImprove_Load);
            this.menuStripShizoImprove.ResumeLayout(false);
            this.menuStripShizoImprove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchAndTree;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxWorkingProject;
        private System.Windows.Forms.Button buttonImproveCollection;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ProgressBar progressBarWorking;
        private System.Windows.Forms.Button buttonSetImprove;
        private System.Windows.Forms.Button buttonImproved;
        private System.Windows.Forms.MenuStrip menuStripShizoImprove;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearCach;
        private System.Windows.Forms.Button buttonActOnFileHistory;
        private System.Windows.Forms.CheckBox checkBoxActOnSuffixes;
    }
}