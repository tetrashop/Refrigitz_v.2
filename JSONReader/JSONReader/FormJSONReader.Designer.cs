namespace JSONReader
{
    partial class FormJSONReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJSONReader));
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxJSON = new System.Windows.Forms.TextBox();
            this.openFileDialogJSONFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStripJSONReader = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonPersianDate = new System.Windows.Forms.RadioButton();
            this.radioButtonGeorgianDate = new System.Windows.Forms.RadioButton();
            this.menuStripJSONReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.BackgroundImage = global::JSONReader.Properties.Resources.imagesIU2UZCZRCancel;
            this.buttonRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRead.Location = new System.Drawing.Point(547, 373);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImage = global::JSONReader.Properties.Resources.imagesIU2UZCZRRun;
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpen.Location = new System.Drawing.Point(438, 373);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxJSON
            // 
            this.textBoxJSON.Location = new System.Drawing.Point(13, 27);
            this.textBoxJSON.Multiline = true;
            this.textBoxJSON.Name = "textBoxJSON";
            this.textBoxJSON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxJSON.Size = new System.Drawing.Size(869, 340);
            this.textBoxJSON.TabIndex = 2;
            // 
            // openFileDialogJSONFile
            // 
            this.openFileDialogJSONFile.FileName = "openFileDialogJSONFile";
            // 
            // menuStripJSONReader
            // 
            this.menuStripJSONReader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStripJSONReader.Location = new System.Drawing.Point(0, 0);
            this.menuStripJSONReader.Name = "menuStripJSONReader";
            this.menuStripJSONReader.Size = new System.Drawing.Size(894, 24);
            this.menuStripJSONReader.TabIndex = 3;
            this.menuStripJSONReader.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // radioButtonPersianDate
            // 
            this.radioButtonPersianDate.AutoSize = true;
            this.radioButtonPersianDate.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPersianDate.Checked = true;
            this.radioButtonPersianDate.Location = new System.Drawing.Point(237, 373);
            this.radioButtonPersianDate.Name = "radioButtonPersianDate";
            this.radioButtonPersianDate.Size = new System.Drawing.Size(83, 17);
            this.radioButtonPersianDate.TabIndex = 4;
            this.radioButtonPersianDate.TabStop = true;
            this.radioButtonPersianDate.Text = "PersianDate";
            this.radioButtonPersianDate.UseVisualStyleBackColor = false;
            // 
            // radioButtonGeorgianDate
            // 
            this.radioButtonGeorgianDate.AutoSize = true;
            this.radioButtonGeorgianDate.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGeorgianDate.Location = new System.Drawing.Point(237, 396);
            this.radioButtonGeorgianDate.Name = "radioButtonGeorgianDate";
            this.radioButtonGeorgianDate.Size = new System.Drawing.Size(91, 17);
            this.radioButtonGeorgianDate.TabIndex = 5;
            this.radioButtonGeorgianDate.Text = "GeorgianDate";
            this.radioButtonGeorgianDate.UseVisualStyleBackColor = false;
            // 
            // FormJSONReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSONReader.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 417);
            this.Controls.Add(this.radioButtonGeorgianDate);
            this.Controls.Add(this.radioButtonPersianDate);
            this.Controls.Add(this.textBoxJSON);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.menuStripJSONReader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripJSONReader;
            this.Name = "FormJSONReader";
            this.Text = "FormJSONReader";
            this.Load += new System.EventHandler(this.FormJSONReader_Load);
            this.menuStripJSONReader.ResumeLayout(false);
            this.menuStripJSONReader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxJSON;
        private System.Windows.Forms.OpenFileDialog openFileDialogJSONFile;
        private System.Windows.Forms.MenuStrip menuStripJSONReader;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButtonPersianDate;
        private System.Windows.Forms.RadioButton radioButtonGeorgianDate;
    }
}

