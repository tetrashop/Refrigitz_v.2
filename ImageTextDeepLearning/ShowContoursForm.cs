namespace ContourAnalysisDemo
{
    //#pragma warning disable CS0246 // The type or namespace name 'ContourAnalysisNS' could not be found (are you missing a using directive or an assembly reference?)
    using ContourAnalysisNS;
    //#pragma warning restore CS0246 // The type or namespace name 'ContourAnalysisNS' could not be found (are you missing a using directive or an assembly reference?)
    //#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    //#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class ShowContoursForm : Form
    {
        //#pragma warning disable CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        private readonly Templates templates;
        //#pragma warning restore CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        //#pragma warning disable CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        private readonly Templates samples;
        //#pragma warning restore CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        //#pragma warning disable CS0246 // The type or namespace name 'Template' could not be found (are you missing a using directive or an assembly reference?)
        public Template selectedTemplate;
        //#pragma warning restore CS0246 // The type or namespace name 'Template' could not be found (are you missing a using directive or an assembly reference?)
        private readonly Bitmap bmp;
        private readonly IContainer components = null;
        private DataGridView dgvContours;
        private TextBox tbTemplateName;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Column;
        private Label label2;

        //#pragma warning disable CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        //#pragma warning disable CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        public ShowContoursForm(Templates templates, Templates samples, Image image)
        //#pragma warning restore CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        //#pragma warning restore CS0246 // The type or namespace name 'Templates' could not be found (are you missing a using directive or an assembly reference?)
        {
            bool flag = !ReferenceEquals(image, null);
            if (flag)
            {
                InitializeComponent();
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
                dgvContours.RowCount = samples.Count;
                base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                string fileName = Path.GetTempPath() + @"\temp.bmp";
                image.Save(fileName);
                bmp = (Bitmap)Image.FromFile(fileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbTemplateName.Text == "<template name>")
            {
                MessageBox.Show("Enter template name");
            }
            else
            {
                try
                {
                    int rowIndex = dgvContours.SelectedCells[0].RowIndex;
                    samples[rowIndex].name = tbTemplateName.Text;
                    templates.Add(samples[rowIndex]);
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
                Template template = samples[e.RowIndex];
                if (e.ColumnIndex == -1)
                {
                    e.Graphics.DrawString(e.RowIndex.ToString(), Font, Brushes.Black, e.CellBounds.Location);
                }
                else
                {
                    if (e.ColumnIndex == 0)
                    {
                        Rectangle rectangle = new Rectangle(e.CellBounds.X, e.CellBounds.Y, (e.CellBounds.Width - 0x18) / 2, e.CellBounds.Height);
                        rectangle.Inflate(-20, -20);
                        Rectangle sourceBoundingRect = template.contour.SourceBoundingRect;
                        float num3 = Math.Min((float)((1f * rectangle.Width) / sourceBoundingRect.Width), (float)((1f * rectangle.Height) / sourceBoundingRect.Height));
                        e.Graphics.DrawImage(bmp, new Rectangle(rectangle.X, rectangle.Y, (int)(sourceBoundingRect.Width * num3), (int)(sourceBoundingRect.Height * num3)), sourceBoundingRect, GraphicsUnit.Pixel);
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
            if (!(!disposing || ReferenceEquals(components, null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvContours = new System.Windows.Forms.DataGridView();
            Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbTemplateName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(dgvContours)).BeginInit();
            SuspendLayout();
            // 
            // dgvContours
            // 
            dgvContours.AllowUserToAddRows = false;
            dgvContours.AllowUserToDeleteRows = false;
            dgvContours.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right);
            dgvContours.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvContours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvContours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Column});
            dgvContours.Location = new System.Drawing.Point(12, 12);
            dgvContours.Name = "dgvContours";
            dgvContours.ReadOnly = true;
            dgvContours.RowTemplate.Height = 200;
            dgvContours.Size = new System.Drawing.Size(500, 409);
            dgvContours.TabIndex = 0;
            dgvContours.VirtualMode = true;
            dgvContours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvContours_CellContentClick);
            dgvContours.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgvContours_CellPainting);
            // 
            // Column
            // 
            Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column.HeaderText = "Contour";
            Column.Name = "Column";
            Column.ReadOnly = true;
            // 
            // tbTemplateName
            // 
            tbTemplateName.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            tbTemplateName.ForeColor = System.Drawing.Color.Gray;
            tbTemplateName.Location = new System.Drawing.Point(205, 431);
            tbTemplateName.Name = "tbTemplateName";
            tbTemplateName.Size = new System.Drawing.Size(114, 20);
            tbTemplateName.TabIndex = 1;
            tbTemplateName.Text = "<template name>";
            tbTemplateName.Enter += new System.EventHandler(tbTemplateName_Enter);
            // 
            // label1
            // 
            label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 434);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 13);
            label1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            button1.Location = new System.Drawing.Point(18, 429);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(181, 23);
            button1.TabIndex = 3;
            button1.Text = "Add selected contour as Template:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // label2
            // 
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(325, 431);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 29);
            label2.TabIndex = 4;
            label2.Text = "enter template name or image file name (*.png, *.jpg)";
            // 
            // ShowContoursForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(524, 459);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tbTemplateName);
            Controls.Add(dgvContours);
            Name = "ShowContoursForm";
            Text = "Create templates";
            Load += new System.EventHandler(ShowContoursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(dgvContours)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void tbTemplateName_Enter(object sender, EventArgs e)
        {
            tbTemplateName.ForeColor = Color.Black;
            if (tbTemplateName.Text == "<template name>")
            {
                tbTemplateName.Text = "";
            }
        }

        private void dgvContours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowContoursForm_Load(object sender, EventArgs e)
        {

        }
    }
}

