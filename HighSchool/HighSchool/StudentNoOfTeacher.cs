using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class StudentNoOfTeacher : Form
    {
        public StudentNoOfTeacher()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into StudentNoOfTeacher values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.StudentNoOfTeacher_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from StudentNoOfTeacher where ID ='" + textBox3.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.StudentNoOfTeacher_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentNoOfTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentNoOfTeacherBindingSource.EndEdit();
            this.studentNoOfTeacherTableAdapter.Update(this.hSchoolDataSet.StudentNoOfTeacher);

        }

        private void StudentNoOfTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet.StudentNoOfTeacher' table. You can move, or remove it, as needed.
            this.studentNoOfTeacherTableAdapter.Fill(this.hSchoolDataSet.StudentNoOfTeacher);

        }
    }
}