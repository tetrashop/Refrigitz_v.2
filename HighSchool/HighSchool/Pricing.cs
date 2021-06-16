using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class Pricing : Form
    {
        public Pricing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Pricing values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Pricing_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from LessonOfTeacher where ID ='" + textBox3.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Pricing_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void pricingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pricingBindingSource.EndEdit();
            this.pricingTableAdapter.Update(this.hSchoolDataSet.Pricing);

        }

        private void Pricing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet.Pricing' table. You can move, or remove it, as needed.
            this.pricingTableAdapter.Fill(this.hSchoolDataSet.Pricing);

        }


    }
}