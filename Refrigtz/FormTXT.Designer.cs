using System;
namespace Refrigtz
{
    partial class FormTXT
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxTXT = new System.Windows.Forms.TextBox();
            this.treeViewRefregitzDraw = new System.Windows.Forms.TreeView();
            this.contextMenuStripRefrigitzTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkertreeView = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStripRefrigitzTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxTXT
            // 
            this.TextBoxTXT.Location = new System.Drawing.Point(13, 13);
            this.TextBoxTXT.Multiline = true;
            this.TextBoxTXT.Name = "TextBoxTXT";
            this.TextBoxTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxTXT.Size = new System.Drawing.Size(1307, 529);
            this.TextBoxTXT.TabIndex = 0;
            this.TextBoxTXT.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // treeViewRefregitzDraw
            // 
            this.treeViewRefregitzDraw.Location = new System.Drawing.Point(12, 13);
            this.treeViewRefregitzDraw.Name = "treeViewRefregitzDraw";
            this.treeViewRefregitzDraw.Size = new System.Drawing.Size(1308, 529);
            this.treeViewRefregitzDraw.TabIndex = 85;
            this.treeViewRefregitzDraw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRefregitzDraw_AfterSelect);
            this.treeViewRefregitzDraw.BindingContextChanged += new System.EventHandler(this.treeViewRefregitzDraw_BindingContextChanged);
            this.treeViewRefregitzDraw.ContextMenuStripChanged += new System.EventHandler(this.treeViewRefregitzDraw_ContextMenuStripChanged);
            this.treeViewRefregitzDraw.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.treeViewRefregitzDraw_ControlAdded);
            // 
            // contextMenuStripRefrigitzTree
            // 
            this.contextMenuStripRefrigitzTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTreeToolStripMenuItem});
            this.contextMenuStripRefrigitzTree.Name = "contextMenuStripRefrigitzTree";
            this.contextMenuStripRefrigitzTree.Size = new System.Drawing.Size(125, 26);
            // 
            // showTreeToolStripMenuItem
            // 
            this.showTreeToolStripMenuItem.Name = "showTreeToolStripMenuItem";
            this.showTreeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.showTreeToolStripMenuItem.Text = "ShowTree";
            // 
            // backgroundWorkertreeView
            // 
            this.backgroundWorkertreeView.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkertreeView_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(26, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "LoseOcuuredatChiled[0] < 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(262, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Draw.IsCurrentDraw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(370, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "IsThereMateOfSelf[j]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(480, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "IsThereMateOfEnemy[j]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(605, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "KishEnemy[j]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(679, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "KishSelf[j]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(738, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "HaveKilled > 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(820, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "HaveKilled < 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(171, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "LoseChiled[j] < 0";
            // 
            // FormTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 588);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewRefregitzDraw);
            this.Controls.Add(this.TextBoxTXT);
            this.Name = "FormTXT";
            this.Text = "FormTXT";
            this.Load += new System.EventHandler(this.FormTXT_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormTXT_MouseClick);
            this.contextMenuStripRefrigitzTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        [field: NonSerialized]
        private System.Windows.Forms.TextBox TextBoxTXT;
        private System.Windows.Forms.TreeView treeViewRefregitzDraw;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRefrigitzTree;
        private System.Windows.Forms.ToolStripMenuItem showTreeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkertreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}