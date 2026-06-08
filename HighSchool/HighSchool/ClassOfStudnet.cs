using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class ClassOfStudnet : Form
    {
        public ClassOfStudnet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into ClassOfStudent values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.ClassOfStudnet_Load(sender, new EventArgs());
            MessageBox.Show("Insert Finsihed.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\HSchool.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from ClassOfStudent where ID ='" + textBox3.Text + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.ClassOfStudnet_Load(sender, new EventArgs());
            MessageBox.Show("Delete Finsihed.");

        }

        private void ClassOfStudnet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSchoolDataSet.ClassOfStudent' table. You can move, or remove it, as needed.
            this.classOfStudentTableAdapter.Fill(this.hSchoolDataSet.ClassOfStudent);

        }

        private void classOfStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classOfStudentBindingSource.EndEdit();
            this.classOfStudentTableAdapter.Update(this.hSchoolDataSet.ClassOfStudent);

        }


    }
}