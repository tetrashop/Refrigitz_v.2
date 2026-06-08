using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class CountOfPricing : Form
    {
        public CountOfPricing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into CountOfPricing values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.CountOfPricing_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from CountOfPricing where IDOfStudent ='" + textBox3.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.CountOfPricing_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update CountOfPricing Set IDOfStudent=" + textBox1.Text + ",Count=" + textBox2.Text + "where IDOfStudent='" + textBox4.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.CountOfPricing_Load(sender, new EventArgs());
            MessageBox.Show("Update Finsihed.");

        }

        private void countOfPricingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countOfPricingBindingSource.EndEdit();
            this.countOfPricingTableAdapter.Update(this.hSchoolDataSet.CountOfPricing);

        }

        private void CountOfPricing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet.CountOfPricing' table. You can move, or remove it, as needed.
            this.countOfPricingTableAdapter.Fill(this.hSchoolDataSet.CountOfPricing);

        }

    }
}