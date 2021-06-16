namespace ContourAnalysisDemo
{
    using ContourAnalysisNS;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class TemplateEditor : Form
    {
        private readonly Templates templates;
        private readonly IContainer components = null;
        private DataGridView dgvTemplates;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private CheckBox cbPreferredAngle;
        private Button btDelete;

        public TemplateEditor(Templates templates)
        {
            InitializeComponent();
            this.templates = templates;
            templates.Sort((t1, t2) => t1.name.CompareTo(t2.name));
            UpdateInterface();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvTemplates.SelectedCells.Count > 0)
            {
                int rowIndex = dgvTemplates.SelectedCells[0].RowIndex;
                if ((rowIndex >= 0) && (rowIndex < templates.Count))
                {
                    templates.RemoveAt(rowIndex);
                    UpdateInterface();
                    Refresh();
                }
            }
        }

        private void cbPreferredAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvTemplates.SelectedCells.Count > 0)
            {
                int rowIndex = dgvTemplates.SelectedCells[0].RowIndex;
                if ((rowIndex >= 0) && (rowIndex < templates.Count))
                {
                    templates[rowIndex].preferredAngleNoMore90 = cbPreferredAngle.Checked;
                }
            }
        }

        private void dgvTemplates_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < templates.Count))
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = e.RowIndex;
                        break;

                    case 1:
                        e.Value = templates[e.RowIndex].name;
                        break;

                    case 2:
                        e.Value = templates[e.RowIndex].preferredAngleNoMore90;
                        break;

                    default:
                        break;
                }
            }
        }

        private void dgvTemplates_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.RowIndex < templates.Count)) && (e.ColumnIndex == 1))
            {
                templates[e.RowIndex].name = e.Value.ToString();
            }
        }

        private void dgvTemplates_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTemplates.SelectedCells.Count > 0)
            {
                int rowIndex = dgvTemplates.SelectedCells[0].RowIndex;
                if ((rowIndex >= 0) && (rowIndex < templates.Count))
                {
                    Refresh();
                    templates[rowIndex].Draw(base.CreateGraphics(), new Rectangle(dgvTemplates.Bounds.Right + 10, dgvTemplates.Bounds.Top, 300, 200));
                    cbPreferredAngle.Checked = templates[rowIndex].preferredAngleNoMore90;
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
            dgvTemplates = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cbPreferredAngle = new CheckBox();
            btDelete = new Button();
            ((ISupportInitialize)dgvTemplates).BeginInit();
            base.SuspendLayout();
            dgvTemplates.AllowUserToAddRows = false;
            dgvTemplates.AllowUserToDeleteRows = false;
            dgvTemplates.AllowUserToResizeRows = false;
            dgvTemplates.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            dgvTemplates.BackgroundColor = SystemColors.Control;
            dgvTemplates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { Column1, Column2 };
            dgvTemplates.Columns.AddRange(dataGridViewColumns);
            dgvTemplates.Location = new Point(12, 0x17);
            dgvTemplates.Name = "dgvTemplates";
            dgvTemplates.RowHeadersVisible = false;
            dgvTemplates.Size = new Size(260, 0xf5);
            dgvTemplates.TabIndex = 0;
            dgvTemplates.VirtualMode = true;
            dgvTemplates.CellValueNeeded += new DataGridViewCellValueEventHandler(dgvTemplates_CellValueNeeded);
            dgvTemplates.CellValuePushed += new DataGridViewCellValueEventHandler(dgvTemplates_CellValuePushed);
            dgvTemplates.SelectionChanged += new EventHandler(dgvTemplates_SelectionChanged);
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 1f;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 40;
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(0x38, 13);
            label1.TabIndex = 1;
            label1.Text = "Templates";
            cbPreferredAngle.AutoSize = true;
            cbPreferredAngle.Location = new Point(0x121, 0xfb);
            cbPreferredAngle.Name = "cbPreferredAngle";
            cbPreferredAngle.Size = new Size(0x9a, 0x11);
            cbPreferredAngle.TabIndex = 3;
            cbPreferredAngle.Text = "Preferred angle no more 90";
            cbPreferredAngle.UseVisualStyleBackColor = true;
            cbPreferredAngle.CheckedChanged += new EventHandler(cbPreferredAngle_CheckedChanged);
            btDelete.Location = new Point(0x1df, 0xf5);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(0x63, 0x17);
            btDelete.TabIndex = 4;
            btDelete.Text = "Delete template";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += new EventHandler(btDelete_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(590, 280);
            base.Controls.Add(btDelete);
            base.Controls.Add(label1);
            base.Controls.Add(cbPreferredAngle);
            base.Controls.Add(dgvTemplates);
            DoubleBuffered = true;
            MinimumSize = new Size(0x25e, 0x13e);
            base.Name = "TemplateEditor";
            Text = "Template Editor";
            ((ISupportInitialize)dgvTemplates).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void UpdateInterface()
        {
            dgvTemplates.RowCount = templates.Count;
        }
    }
}

