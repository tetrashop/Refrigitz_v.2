using System;
using System.Windows.Forms;

namespace Setting
{
    public partial class EquationSettingInsertion : Form
    {
        //this variable hold the previous node in order to replace when needed.
        AddToTree.Tree Holder = new AddToTree.Tree(null, false);
        //this Form is due to show setting for insertion equation on tree to be correctly.
        public EquationSettingInsertion()
        {
            InitializeComponent();
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void EquationSettingInsertion_Load(object sender, EventArgs e)
        {

        }
        public bool SetHolder(AddToTree.Tree t)
        {
            Holder = t;
            return true;
        }
        public AddToTree.Tree GetHolder()
        {
            return Holder;
        }
        public bool GropeBox1ReturnIsBegin()
        {
            return Begin1.Checked;
        }
        public bool GropeBox2ReturnIsBegin()
        {
            return Begin2.Checked;
        }
        public bool GropeBox1ReturnISinCurrent()
        {
            return InCurrent1.Checked;
        }
        public bool GropeBox2ReturnISinCurrent()
        {
            return InCurrent2.Checked;
        }
        public bool GropeBox1ReturnIsEnd()
        {
            return End1.Checked;
        }
        public bool GropeBox2ReturnIsEnd()
        {
            return End2.Checked;
        }
        public void ResetSetAllControls()
        {
            Begin1.Checked = false;
            Begin2.Checked = false;
            InCurrent1.Checked = false;
            InCurrent2.Checked = false;
            End1.Checked = false;
            End2.Checked = false;
        }
        public void SetGropBox1(bool Begin, bool Current, bool End)
        {
            Begin1.Checked = Begin;
            InCurrent1.Checked = Current;
            End1.Checked = End;
        }
        public void SetGropBox2(bool Begin, bool Current, bool End)
        {
            Begin2.Checked = Begin;
            InCurrent2.Checked = Current;
            End2.Checked = End;
        }

    }
}