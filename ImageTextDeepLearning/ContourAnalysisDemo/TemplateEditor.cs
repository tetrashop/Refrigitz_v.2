namespace ContourAnalysisDemo
{
    using ContourAnalysisNS;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class TemplateEditor : Form
    {
        private Templates templates;
        private IContainer components = null;
        private DataGridView dgvTemplates;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private CheckBox cbPreferredAngle;
        private Button btDelete;

        public TemplateEditor(Templates templates)
        {
            this.InitializeComponent();
            this.templates = templates;
            templates.Sort((t1, t2) => t1.name.CompareTo(t2.name));
            this.UpdateInterface();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvTemplates.SelectedCells.Count > 0)
            {
                int rowIndex = this.dgvTemplates.SelectedCells[0].RowIndex;
                if ((rowIndex >= 0) && (rowIndex < this.templates.Count))
                {
                    this.templates.RemoveAt(rowIndex);
                    this.UpdateInterface();
                    this.Refresh();
                }
            }
        }

        private void cbPreferredAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dgvTemplates.SelectedCells.Count > 0)
            {
                int rowIndex = this.dgvTemplates.SelectedCells[0].RowIndex;
                if ((rowIndex >= 0) && (rowIndex < this.templates.Count))
                {
                    this.templates[rowIndex].preferredAngleNoMore90 = this.cbPreferredAngle.Checked;
                }
            }
        }

        private void dgvTemplates_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < this.templates.Count))
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = e.RowIndex;
                        break;

                    case 1:
                        e.Value = this.templates[e.RowIndex].name;
                        break;

                    case 2:
                        e.Value = this.templates[e.RowIndex].preferredAngleNoMore90;
                        break;

                    default:
                        break;
                }
            }
        }

        private void dgvTemplates_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.RowIndex < this.templates.Count)) && (e.ColumnIndex == 1))
            {
                this.templates[e.RowIndex].name = e.Value.ToString();
            }
        }

        private void dgvTemplates_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvTemplates.SelectedCells.Count > 0)
            {
                int rowIndex = this.dgvTemplates.SelectedCells[0].RowIndex;
                if ((rowIndex >= 0) && (rowIndex < this.templates.Count))
                {
                    this.Refresh();
                    this.templates[rowIndex].Draw(base.CreateGraphics(), new Rectangle(this.dgvTemplates.Bounds.Right + 10, this.dgvTemplates.Bounds.Top, 300, 200));
                    this.cbPreferredAngle.Checked = this.templates[rowIndex].preferredAngleNoMore90;
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
            this.dgvTemplates = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.label1 = new Label();
            this.cbPreferredAngle = new CheckBox();
            this.btDelete = new Button();
            ((ISupportInitialize) this.dgvTemplates).BeginInit();
            base.SuspendLayout();
            this.dgvTemplates.AllowUserToAddRows = false;
            this.dgvTemplates.AllowUserToDeleteRows = false;
            this.dgvTemplates.AllowUserToResizeRows = false;
            this.dgvTemplates.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvTemplates.BackgroundColor = SystemColors.Control;
            this.dgvTemplates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.Column1, this.Column2 };
            this.dgvTemplates.Columns.AddRange(dataGridViewColumns);
            this.dgvTemplates.Location = new Point(12, 0x17);
            this.dgvTemplates.Name = "dgvTemplates";
            this.dgvTemplates.RowHeadersVisible = false;
            this.dgvTemplates.Size = new Size(260, 0xf5);
            this.dgvTemplates.TabIndex = 0;
            this.dgvTemplates.VirtualMode = true;
            this.dgvTemplates.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dgvTemplates_CellValueNeeded);
            this.dgvTemplates.CellValuePushed += new DataGridViewCellValueEventHandler(this.dgvTemplates_CellValuePushed);
            this.dgvTemplates.SelectionChanged += new EventHandler(this.dgvTemplates_SelectionChanged);
            this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 1f;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Templates";
            this.cbPreferredAngle.AutoSize = true;
            this.cbPreferredAngle.Location = new Point(0x121, 0xfb);
            this.cbPreferredAngle.Name = "cbPreferredAngle";
            this.cbPreferredAngle.Size = new Size(0x9a, 0x11);
            this.cbPreferredAngle.TabIndex = 3;
            this.cbPreferredAngle.Text = "Preferred angle no more 90";
            this.cbPreferredAngle.UseVisualStyleBackColor = true;
            this.cbPreferredAngle.CheckedChanged += new EventHandler(this.cbPreferredAngle_CheckedChanged);
            this.btDelete.Location = new Point(0x1df, 0xf5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new Size(0x63, 0x17);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete template";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new EventHandler(this.btDelete_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(590, 280);
            base.Controls.Add(this.btDelete);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.cbPreferredAngle);
            base.Controls.Add(this.dgvTemplates);
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(0x25e, 0x13e);
            base.Name = "TemplateEditor";
            this.Text = "Template Editor";
            ((ISupportInitialize) this.dgvTemplates).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void UpdateInterface()
        {
            this.dgvTemplates.RowCount = this.templates.Count;
        }
    }
}

