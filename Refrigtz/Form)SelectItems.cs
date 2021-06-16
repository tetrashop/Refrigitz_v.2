using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Refrigtz
{
    [Serializable]
    public partial class FormُSelectItems : Form
    {
        public static int Items = -1;
        public FormُSelectItems()
        {
            InitializeComponent();
        }

        private void FormُSelectItems_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Items = 0;
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Items = 1;
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Items = 2;
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Items = 3;
            Close();
        }
    }
}
