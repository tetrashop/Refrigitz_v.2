using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WebJobRefregitz
{
    public partial class FormKindOfGameContinue : Form
    {
        public FormKindOfGameContinue()
        {
            InitializeComponent();
        }

        private void FormKindOfGameContinue_Load(object sender, EventArgs e)
        {
            int iii = 0;
            int t = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            do
            {
                if (DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - t > 1000) break; iii++; if (System.IO.File.Exists(FormRefrigtz.Root + "\\Database\\Games\\CurrentBank" + iii.ToString() + ".accdb")) { comboBoxDatabase.Items.Add("CurrentBank" + iii.ToString() + ".accdb"); }
            } while (true);

        }

        private void radioButtonComputerByComputer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
