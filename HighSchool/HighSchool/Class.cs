using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Class values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Class_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Class where ID ='" + textBox4.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Class_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Class set Name=" + textBox1.Text + ",ID=" + textBox2.Text + ",Color=" + textBox3.Text + "where ID='" + textBox4.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Class_Load(sender, new EventArgs());
            MessageBox.Show("Updare Finsihed.");
        }

        private void classBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classBindingSource.EndEdit();
            this.classTableAdapter.Update(this.hSchoolDataSet1.Class);

        }

        private void Class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet1.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.hSchoolDataSet1.Class);

        }



    }
}