using System;
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Items = 0;
            Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Items = 1;
            Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Items = 2;
            Close();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Items = 3;
            Close();
        }
    }
}
