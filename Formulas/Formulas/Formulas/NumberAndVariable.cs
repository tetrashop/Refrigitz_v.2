using System;
using System.Windows.Forms;

namespace NumberVar
{
    public partial class NumberAndVariable : Form
    {
        Formulas.Equation EqationVariable = null;
        static String Contained = "";
        public NumberAndVariable(ref NumberAndVariable E, ref Formulas.Equation A)
        {
            InitializeComponent();
            E = this;
            EqationVariable = A;



        }

        private void NumberAndVariable_Load(object sender, EventArgs e)
        {

        }

        private void NumberAndVariable_Load_1(object sender, EventArgs e)
        {

        }
        public String GetContained()
        {
            return Contained;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Contained = textBox1.Text;
        }

    }
}