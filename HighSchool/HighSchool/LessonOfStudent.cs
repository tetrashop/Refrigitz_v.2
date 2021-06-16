using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class LessonOfStudent : Form
    {
        public LessonOfStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into LessonOfStudent values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.LessonOfStudent_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from LessonOfStudent where ID ='" + textBox6.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.LessonOfStudent_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void lessonOfStudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lessonOfStudentBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void lessonOfStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lessonOfStudentBindingSource.EndEdit();
            this.lessonOfStudentTableAdapter.Update(this.hSchoolDataSet.LessonOfStudent);

        }

        private void LessonOfStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet.LessonOfStudent' table. You can move, or remove it, as needed.
            this.lessonOfStudentTableAdapter.Fill(this.hSchoolDataSet.LessonOfStudent);

        }
    }
}