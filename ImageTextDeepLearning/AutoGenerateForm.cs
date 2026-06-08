namespace ContourAnalysisDemo
{
    using ContourAnalysisNS;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    public class AutoGenerateForm : Form
    {
        private readonly IContainer components = null;
        private FontDialog fontDialog1;
        private TextBox tbChars;
        private Button btFont;
        private Label label2;
        private Button btGenerate;
        private Label label1;
        private TextBox tbFont;
        private CheckBox cbAntipattern;
        private readonly ImageProcessor processor;
        public AutoGenerateForm(ImageProcessor processo)
        {
            InitializeComponent();
            tbFont.Text = new FontConverter().ConvertToString(tbChars.Font);
            processor = processo;
        }
        private void btFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tbChars.Font = fontDialog1.Font;
                tbFont.Text = new FontConverter().ConvertToString(tbChars.Font);
            }
        }
        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int count = processor.templates.Count;
                TemplateGenerator.GenerateChars(processor, tbChars.Text.ToCharArray(), tbChars.Font);
                if (cbAntipattern.Checked)
                {
                    TemplateGenerator.GenerateAntipatterns(processor);
                }
                MessageBox.Show("Added " + (processor.templates.Count - count) + " templates");
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(components, null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            fontDialog1 = new FontDialog();
            tbChars = new TextBox();
            btFont = new Button();
            label2 = new Label();
            btGenerate = new Button();
            label1 = new Label();
            tbFont = new TextBox();
            cbAntipattern = new CheckBox();
            base.SuspendLayout();
            fontDialog1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            tbChars.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            tbChars.Location = new Point(11, 0x47);
            tbChars.Multiline = true;
            tbChars.Name = "tbChars";
            tbChars.Size = new Size(0x101, 0x51);
            tbChars.TabIndex = 2;
            tbChars.Text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            btFont.Location = new Point(0xdd, 0x17);
            btFont.Name = "btFont";
            btFont.Size = new Size(0x33, 0x17);
            btFont.TabIndex = 3;
            btFont.Text = "Font...";
            btFont.UseVisualStyleBackColor = true;
            btFont.Click += new EventHandler(btFont_Click);
            label2.AutoSize = true;
            label2.Location = new Point(12, 0x37);
            label2.Name = "label2";
            label2.Size = new Size(0x22, 13);
            label2.TabIndex = 4;
            label2.Text = "Chars";
            btGenerate.Location = new Point(0x71, 0xb5);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(0x9b, 0x17);
            btGenerate.TabIndex = 5;
            btGenerate.Text = "Generate templates";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += new EventHandler(btGenerate_Click);
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(0x1c, 13);
            label1.TabIndex = 1;
            label1.Text = "Font";
            tbFont.Location = new Point(11, 0x1a);
            tbFont.Name = "tbFont";
            tbFont.ReadOnly = true;
            tbFont.Size = new Size(0xcc, 20);
            tbFont.TabIndex = 0;
            tbFont.TabStop = false;
            cbAntipattern.AutoSize = true;
            cbAntipattern.Location = new Point(12, 0x9e);
            cbAntipattern.Name = "cbAntipattern";
            cbAntipattern.Size = new Size(0x89, 0x11);
            cbAntipattern.TabIndex = 6;
            cbAntipattern.Text = "Also create antipatterns";
            cbAntipattern.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x11c, 0xd9);
            base.Controls.Add(cbAntipattern);
            base.Controls.Add(btGenerate);
            base.Controls.Add(label2);
            base.Controls.Add(btFont);
            base.Controls.Add(tbChars);
            base.Controls.Add(label1);
            base.Controls.Add(tbFont);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Name = "AutoGenerateForm";
            Text = "Generate Templates";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}
