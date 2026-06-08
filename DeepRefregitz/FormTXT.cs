using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace DeepRefregitz
{
    [Serializable]
    public partial class FormTXT : Form
    {
        public FormTXT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTXT_Load(object sender, EventArgs e)
        {
            textBoxTXT.Text = "";
            if (FormRefrigtz.ErrorTrueMonitorFalse)
            {
                // textBoxTXT.Text = File.ReadAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt");
            }
            else
            {
                textBoxTXT.Text = File.ReadAllText(FormRefrigtz.Root + "\\Database\\Monitor.html");
            }
        }
    }
}
