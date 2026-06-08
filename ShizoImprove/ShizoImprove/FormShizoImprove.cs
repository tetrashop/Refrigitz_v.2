/**************************************************************************
 * CopyRight Ramin Edjlal 28 nov 2019 Tetra E-Commerce*********************
 * TetraShop.ir************************************************************
 * ************************************************************************/
using System;
using System.Windows.Forms;

namespace ShizoImprove
{
    public partial class FormShizoImprove : Form
    {
        public String path = "D:\\";//'DVD'\\";
        ShizoImprove t = null;
        ShizoImproveFile tt = null;
        public FormShizoImprove()
        {
            InitializeComponent();
        }

        private void buttonSearchAndTree_Click(object sender, EventArgs e)
        {
            t = new ShizoImprove(path);
        }

        private void FormShizoImprove_Load(object sender, EventArgs e)
        {

        }

        private void buttonImproveCollection_Click(object sender, EventArgs e)
        {
            if (!checkBoxActOnSuffixes.Checked)
            {
                if (ShizoImprove.AllFiles.Count == 0)
                    t = new ShizoImprove(path);
                progressBarWorking.Maximum = ShizoImprove.AllFiles.Count;
                progressBarWorking.Minimum = 0;
                t.FormShizoImprove(textBoxWorkingProject.Text, ref progressBarWorking);

            }
            else
            {
                if (ShizoImproveFile.AllFiles.Count == 0)
                    tt = new ShizoImproveFile(path);
                progressBarWorking.Maximum = ShizoImproveFile.AllFiles.Count;
                progressBarWorking.Minimum = 0;
                tt.FormShizoImprove(textBoxWorkingProject.Text, ref progressBarWorking);

            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            path = textBoxInput.Text;
        }
        //dates created and set parameters
        private void buttonSetImprove_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "C:\\ShizoImprove\\" + textBoxWorkingProject.Text + "\\";
            textBoxOutput.Text = "C:\\ShizoImprove\\Improved\\";
            path = textBoxInput.Text;
            buttonImproved.Enabled = true;
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
        //improved events
        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBoxActOnSuffixes.Checked)
            {
                if (ShizoImprove.AllFiles.Count > 0)
                {

                    progressBarWorking.Maximum = ShizoImprove.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    t.FormImprove(textBoxWorkingProject.Text, ref progressBarWorking);
                }
                else
                {
                    t = new ShizoImprove(path);

                    progressBarWorking.Maximum = ShizoImprove.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    t.FormImprove(textBoxWorkingProject.Text, ref progressBarWorking);
                }
            }
            else
            {
                if (ShizoImproveFile.AllFiles.Count > 0)
                {

                    progressBarWorking.Maximum = ShizoImproveFile.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    tt.FormImprove(textBoxWorkingProject.Text, ref progressBarWorking);
                }
                else
                {
                    tt = new ShizoImproveFile(path);

                    progressBarWorking.Maximum = ShizoImproveFile.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    tt.FormImprove(textBoxWorkingProject.Text, ref progressBarWorking);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBoxShizoImprove()).Show();
        }

        private void buttonClearCach_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "C:\\ShizoImprove\\";
            textBoxOutput.Text = "";
            path = textBoxInput.Text;
            buttonImproved.Enabled = true;



            if (!checkBoxActOnSuffixes.Checked)
            {

                progressBarWorking.Maximum = ShizoImprove.AllFiles.Count;
                progressBarWorking.Minimum = 0;
                t.FormShizoImproveClearCach(textBoxInput.Text, ref progressBarWorking);
            }
            else
            {

                progressBarWorking.Maximum = ShizoImproveFile.AllFiles.Count;
                progressBarWorking.Minimum = 0;
                tt.FormShizoImproveClearCach(textBoxInput.Text, ref progressBarWorking);
            }
        }

        private void buttonActOnFileHistory_Click(object sender, EventArgs e)
        {
            if (!checkBoxActOnSuffixes.Checked)
            {
                if (ShizoImprove.AllFiles.Count > 0)
                {

                    progressBarWorking.Maximum = ShizoImprove.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    t.FormShizoImproveActOnFileHistory(textBoxWorkingProject.Text, ref progressBarWorking);
                }
                else
                {
                    t = new ShizoImprove(path);

                    progressBarWorking.Maximum = ShizoImprove.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    t.FormShizoImproveActOnFileHistory(textBoxWorkingProject.Text, ref progressBarWorking);
                }
            }
            else
            {
                if (ShizoImproveFile.AllFiles.Count > 0)
                {

                    progressBarWorking.Maximum = ShizoImproveFile.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    tt.FormShizoImproveActOnFileHistory(textBoxWorkingProject.Text, ref progressBarWorking);
                }
                else
                {
                    tt = new ShizoImproveFile(path);

                    progressBarWorking.Maximum = ShizoImproveFile.AllFiles.Count;
                    progressBarWorking.Minimum = 0;
                    tt.FormShizoImproveActOnFileHistory(textBoxWorkingProject.Text, ref progressBarWorking);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
