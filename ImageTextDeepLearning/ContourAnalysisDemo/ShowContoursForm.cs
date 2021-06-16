namespace ContourAnalysisDemo
{
    using ContourAnalysisNS;
    using Emgu.CV;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class ShowContoursForm : Form
    {
        private Templates templates;
        private Templates samples;
        public Template selectedTemplate;
        private Bitmap bmp;
        private IContainer components = null;
        private DataGridView dgvContours;
        private TextBox tbTemplateName;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Column;
        private Label label2;

        public ShowContoursForm(Templates templates, Templates samples, IImage image)
        {
            bool flag = !ReferenceEquals(image, null);
            if (flag)
            {
                this.InitializeComponent();
                this.templates = templates;
                this.samples = samples;
                this.samples = new Templates();
                using (List<Template>.Enumerator enumerator = samples.GetEnumerator())
                {
                    while (true)
                    {
                        flag = enumerator.MoveNext();
                        if (!flag)
                        {
                            break;
                        }
                        Template current = enumerator.Current;
                        this.samples.Add(current);
                    }
                }
                this.dgvContours.RowCount = samples.Count;
                base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                string fileName = Path.GetTempPath() + @"\temp.bmp";
                image.Save(fileName);
                this.bmp = (Bitmap) Image.FromFile(fileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tbTemplateName.Text == "<template name>")
            {
                MessageBox.Show("Enter template name");
            }
            else
            {
                try
                {
                    int rowIndex = this.dgvContours.SelectedCells[0].RowIndex;
                    this.samples[rowIndex].name = this.tbTemplateName.Text;
                    this.templates.Add(this.samples[rowIndex]);
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.Message);
                }
            }
        }

        private void dgvContours_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
            e.Handled = true;
            if (e.RowIndex >= 0)
            {
                Template template = this.samples[e.RowIndex];
                if (e.ColumnIndex == -1)
                {
                    e.Graphics.DrawString(e.RowIndex.ToString(), this.Font, Brushes.Black, (PointF) e.CellBounds.Location);
                }
                else
                {
                    if (e.ColumnIndex == 0)
                    {
                        Rectangle rectangle = new Rectangle(e.CellBounds.X, e.CellBounds.Y, (e.CellBounds.Width - 0x18) / 2, e.CellBounds.Height);
                        rectangle.Inflate(-20, -20);
                        Rectangle sourceBoundingRect = template.contour.SourceBoundingRect;
                        float num3 = Math.Min((float) ((1f * rectangle.Width) / ((float) sourceBoundingRect.Width)), (float) ((1f * rectangle.Height) / ((float) sourceBoundingRect.Height)));
                        e.Graphics.DrawImage(this.bmp, new Rectangle(rectangle.X, rectangle.Y, (int) (sourceBoundingRect.Width * num3), (int) (sourceBoundingRect.Height * num3)), sourceBoundingRect, GraphicsUnit.Pixel);
                    }
                    if (e.ColumnIndex == 0)
                    {
                        template.Draw(e.Graphics, e.CellBounds);
                    }
                }
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
            this.dgvContours = new DataGridView();
            this.Column = new DataGridViewTextBoxColumn();
            this.tbTemplateName = new TextBox();
            this.label1 = new Label();
            this.button1 = new Button();
            this.label2 = new Label();
            ((ISupportInitialize) this.dgvContours).BeginInit();
            base.SuspendLayout();
            this.dgvContours.AllowUserToAddRows = false;
            this.dgvContours.AllowUserToDeleteRows = false;
            this.dgvContours.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvContours.BackgroundColor = SystemColors.Control;
            this.dgvContours.BorderStyle = BorderStyle.None;
            this.dgvContours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.Column };
            this.dgvContours.Columns.AddRange(dataGridViewColumns);
            this.dgvContours.Location = new Point(12, 12);
            this.dgvContours.Name = "dgvContours";
            this.dgvContours.ReadOnly = true;
            this.dgvContours.RowTemplate.Height = 200;
            this.dgvContours.Size = new Size(500, 0x199);
            this.dgvContours.TabIndex = 0;
            this.dgvContours.VirtualMode = true;
            this.dgvContours.CellPainting += new DataGridViewCellPaintingEventHandler(this.dgvContours_CellPainting);
            this.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column.HeaderText = "Contour";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.tbTemplateName.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.tbTemplateName.ForeColor = Color.Gray;
            this.tbTemplateName.Location = new Point(0xcd, 0x1af);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new Size(0x72, 20);
            this.tbTemplateName.TabIndex = 1;
            this.tbTemplateName.Text = "<template name>";
            this.tbTemplateName.Enter += new EventHandler(this.tbTemplateName_Enter);
            this.label1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 0x1b2);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0, 13);
            this.label1.TabIndex = 2;
            this.button1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button1.Location = new Point(0x12, 0x1ad);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0xb5, 0x17);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add selected contour as Template:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label2.ForeColor = Color.Gray;
            this.label2.Location = new Point(0x145, 0x1af);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0xae, 0x1d);
            this.label2.TabIndex = 4;
            this.label2.Text = "enter template name or image file name (*.png, *.jpg)";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x20c, 0x1cb);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.tbTemplateName);
            base.Controls.Add(this.dgvContours);
            base.Name = "ShowContoursForm";
            this.Text = "Create templates";
            ((ISupportInitialize) this.dgvContours).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void tbTemplateName_Enter(object sender, EventArgs e)
        {
            this.tbTemplateName.ForeColor = Color.Black;
            if (this.tbTemplateName.Text == "<template name>")
            {
                this.tbTemplateName.Text = "";
            }
        }
    }
}

