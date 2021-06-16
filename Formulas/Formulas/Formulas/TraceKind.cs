using System;
using System.Windows.Forms;

namespace Formulas
{
    public partial class TraceKind : Form
    {
        public TraceKind()
        {
            InitializeComponent();
        }

        private void TraceKind_Load(object sender, EventArgs e)
        {

        }
        public RadioButton RadioButtonOneAcess
        {
            get { return radioButton1; }
            set { radioButton1 = value; }
        }
        public RadioButton RadioButtonTowAcess
        {
            get { return radioButton2; }
            set { radioButton2 = value; }
        }
    }
}