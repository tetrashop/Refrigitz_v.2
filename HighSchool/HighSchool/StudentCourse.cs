using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class StudentCourse : Form
    {
        public StudentCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into StudentCourse values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.StudentCourse_Load(sender, new EventArgs());
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
            cmd.CommandText = "Delete from StudentCourse where ID ='" + textBox3.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.StudentCourse_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void studentCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentCourseBindingSource.EndEdit();
            this.studentCourseTableAdapter.Update(this.hSchoolDataSet.StudentCourse);

        }

        private void StudentCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet.StudentCourse' table. You can move, or remove it, as needed.
            this.studentCourseTableAdapter.Fill(this.hSchoolDataSet.StudentCourse);

        }
    }
}