using System;
using System.Windows.Forms;
namespace Refrigtz
{
    [Serializable]
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

                if (DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - t > 1000) break; iii++; if (System.IO.File.Exists(FormRefrigtz.Root + "\\Database\\Games\\CurrentBank" + iii.ToString() + ".accdb")) { ComboBoxDatabase.Items.Add("CurrentBank" + iii.ToString() + ".accdb"); }
            } while (true);

        }

        private void RadioButtonComputerByComputer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
