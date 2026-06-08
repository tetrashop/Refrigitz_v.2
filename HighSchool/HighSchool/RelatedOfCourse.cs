using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class RelatedOfCourse : Form
    {
        public RelatedOfCourse()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into RealatedOfCourse values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.RelatedOfCourse_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from RealatedOfCourse where IDCard ='" + textBox6.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.RelatedOfCourse_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }


        private void realatedOfCourseBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void realatedOfCourseBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.realatedOfCourseBindingSource1.EndEdit();
            this.realatedOfCourseTableAdapter.Update(this.hSchoolDataSet1.RealatedOfCourse);

        }

        private void RelatedOfCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet1.RealatedOfCourse' table. You can move, or remove it, as needed.
            this.realatedOfCourseTableAdapter.Fill(this.hSchoolDataSet1.RealatedOfCourse);

        }
    }
}