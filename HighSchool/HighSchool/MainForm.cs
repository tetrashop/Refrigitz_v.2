using System;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course Frm = new Course();
            Frm.ShowDialog();
            StudentCourse Frm1 = new StudentCourse();
            Frm1.textBox1.Text = Frm.textBox2.Text;
            Frm1.Show();
        }
        private void studentCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentCourse Frm = new StudentCourse();
            Frm.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class Frm = new Class();
            Frm.ShowDialog();
            BenchNoClass Frm1 = new BenchNoClass();
            Frm1.textBox1.Text = Frm.textBox2.Text;
            Frm1.ShowDialog();
            ClassOfStudnet Frm2 = new ClassOfStudnet();
            Frm2.textBox1.Text = Frm1.textBox1.Text;
            Frm2.ShowDialog();
        }

        private void benchNoClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BenchNoClass Frm = new BenchNoClass();
            Frm.Show();
        }

        private void classOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassOfStudnet Frm = new ClassOfStudnet();
            Frm.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Studnet Frm = new Studnet();
            Frm.ShowDialog();
            ClassOfStudnet Frm1 = new ClassOfStudnet();
            Frm1.textBox1.Text = Frm.textBox3.Text;
            Frm1.ShowDialog();
            LessonOfStudent Frm2 = new LessonOfStudent();
            Frm2.textBox1.Text = Frm1.textBox1.Text;
            Frm2.ShowDialog();
            RelatedFamilyOfStudent Frm3 = new RelatedFamilyOfStudent();
            Frm3.textBox7.Text = Frm2.textBox1.Text;
            Frm3.ShowDialog();
        }
        private void lessonOfStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonOfStudent Frm = new LessonOfStudent();
            Frm.Show();
        }

        private void relatedFamilyOFstudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatedFamilyOfStudent Frm = new RelatedFamilyOfStudent();
            Frm.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher Frm = new Teacher();
            Frm.ShowDialog();
            Responsibility Frm1 = new Responsibility();
            Frm1.textBox1.Text = Frm.textBox3.Text;
            Frm1.ShowDialog();
            StudentNoOfTeacher Frm2 = new StudentNoOfTeacher();
            Frm2.textBox1.Text = Frm1.textBox1.Text;
            Frm2.ShowDialog();
            LessonOfTeacher Frm3 = new LessonOfTeacher();
            Frm3.textBox1.Text = Frm2.textBox1.Text;
            Frm3 = new LessonOfTeacher();
            RelatedOfTeacher Frm4 = new RelatedOfTeacher();
            Frm4.textBox7.Text = Frm3.textBox1.Text;
            Frm4.ShowDialog();
        }

        private void responsibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Responsibility Frm = new Responsibility();
            Frm.Show();
        }
        private void studentNoOfTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentNoOfTeacher Frm = new StudentNoOfTeacher();
            Frm.Show();
        }

        private void lessonOfTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonOfTeacher Frm = new LessonOfTeacher();
            Frm.Show();
        }

        private void relatedOfTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatedOfTeacher Frm = new RelatedOfTeacher();
            Frm.Show();
        }

        private void relatedOfCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatedOfCourse Frm = new RelatedOfCourse();
            Frm.ShowDialog();
            GradeOfStudyOfRelatedCourse Frm1 = new GradeOfStudyOfRelatedCourse();
            Frm1.textBox1.Text = Frm.textBox3.Text;
            Frm1.ShowDialog();
        }

        private void gradeOfStudyOfRealtedCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeOfStudyOfRelatedCourse Frm = new GradeOfStudyOfRelatedCourse();
            Frm.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book Frm = new Book();
            Frm.Show();
        }

        private void pricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pricing Frm = new Pricing();
            Frm.Show();
            CountOfPricing Frm1 = new CountOfPricing();
            Frm1.textBox1.Text = Frm.textBox2.Text;
            Frm1.ShowDialog();

        }

        private void countOfPricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountOfPricing Frm = new CountOfPricing();
            Frm.Show();
        }
    }
}