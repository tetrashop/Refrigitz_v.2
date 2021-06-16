namespace ContourAnalysisDemo
{
    using ContourAnalysisNS;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AutoGenerateForm : Form
    {
        private IContainer components = null;
        private FontDialog fontDialog1;
        private TextBox tbChars;
        private Button btFont;
        private Label label2;
        private Button btGenerate;
        private Label label1;
        private TextBox tbFont;
        private CheckBox cbAntipattern;
        private ImageProcessor processor;

        public AutoGenerateForm(ImageProcessor processor)
        {
            this.InitializeComponent();
            this.tbFont.Text = new FontConverter().ConvertToString(this.tbChars.Font);
            this.processor = processor;
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbChars.Font = this.fontDialog1.Font;
                this.tbFont.Text = new FontConverter().ConvertToString(this.tbChars.Font);
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int count = this.processor.templates.Count;
                TemplateGenerator.GenerateChars(this.processor, this.tbChars.Text.ToCharArray(), this.tbChars.Font);
                if (this.cbAntipattern.Checked)
                {
                    TemplateGenerator.GenerateAntipatterns(this.processor);
                }
                MessageBox.Show("Added " + (this.processor.templates.Count - count) + " templates");
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.fontDialog1 = new FontDialog();
            this.tbChars = new TextBox();
            this.btFont = new Button();
            this.label2 = new Label();
            this.btGenerate = new Button();
            this.label1 = new Label();
            this.tbFont = new TextBox();
            this.cbAntipattern = new CheckBox();
            base.SuspendLayout();
            this.fontDialog1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.tbChars.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.tbChars.Location = new Point(11, 0x47);
            this.tbChars.Multiline = true;
            this.tbChars.Name = "tbChars";
            this.tbChars.Size = new Size(0x101, 0x51);
            this.tbChars.TabIndex = 2;
            this.tbChars.Text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.btFont.Location = new Point(0xdd, 0x17);
            this.btFont.Name = "btFont";
            this.btFont.Size = new Size(0x33, 0x17);
            this.btFont.TabIndex = 3;
            this.btFont.Text = "Font...";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new EventHandler(this.btFont_Click);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 0x37);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chars";
            this.btGenerate.Location = new Point(0x71, 0xb5);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new Size(0x9b, 0x17);
            this.btGenerate.TabIndex = 5;
            this.btGenerate.Text = "Generate templates";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new EventHandler(this.btGenerate_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x1c, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            this.tbFont.Location = new Point(11, 0x1a);
            this.tbFont.Name = "tbFont";
            this.tbFont.ReadOnly = true;
            this.tbFont.Size = new Size(0xcc, 20);
            this.tbFont.TabIndex = 0;
            this.tbFont.TabStop = false;
            this.cbAntipattern.AutoSize = true;
            this.cbAntipattern.Location = new Point(12, 0x9e);
            this.cbAntipattern.Name = "cbAntipattern";
            this.cbAntipattern.Size = new Size(0x89, 0x11);
            this.cbAntipattern.TabIndex = 6;
            this.cbAntipattern.Text = "Also create antipatterns";
            this.cbAntipattern.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x11c, 0xd9);
            base.Controls.Add(this.cbAntipattern);
            base.Controls.Add(this.btGenerate);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.btFont);
            base.Controls.Add(this.tbChars);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.tbFont);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Name = "AutoGenerateForm";
            this.Text = "Generate Templates";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

