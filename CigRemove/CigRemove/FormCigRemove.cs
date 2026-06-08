using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;




namespace CigRemove
{
    public partial class FormCigRemove : Form
    {
        delegate void SetLableValueCalBack(Label JSON, String value);
        private void SetLableValue(Label JSON, String value)
        {
            try
            {
                if (JSON.InvokeRequired)
                {
                    SetLableValueCalBack d = new SetLableValueCalBack(SetLableValue);
                    JSON.Invoke(new Action(() => JSON.Text = value));
                }
                else
                {
                    JSON.Text = value;
                }
            }
            catch (Exception t)
            {
                Log(t);
            }
        }
        delegate void SetprogressBarJSONMaxValueCalBack(ProgressBar JSON, Int32 value);
        private void SetprogressBarJSONMaxValue(ProgressBar JSON, Int32 value)
        {
            try
            {
                if (JSON.InvokeRequired)
                {
                    SetprogressBarJSONMaxValueCalBack d = new SetprogressBarJSONMaxValueCalBack(SetprogressBarJSONMaxValue);
                    JSON.Invoke(new Action(() => JSON.Maximum = value));
                }
                else
                {
                    JSON.Maximum = value;
                }
            }
            catch (Exception t)
            {
                Log(t);
            }
        }
        delegate void SetlableJSONMaxValueCalBack(Label JSON, String value);
        private void SetlableJSONMaxValue(Label JSON, String value)
        {
            try
            {
                if (JSON.InvokeRequired)
                {
                    SetlableJSONMaxValueCalBack d = new SetlableJSONMaxValueCalBack(SetlableJSONMaxValue);
                    JSON.Invoke(new Action(() => JSON.Text = value));
                }
                else
                {
                    JSON.Text = value;
                }
            }
            catch (Exception t)
            {
                Log(t);
            }
        }
        delegate void SetDataGridViewDataSourceCallback(DataGridView dat, object state);

        private void SetDataGridViewDataSource(DataGridView dat, object state)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dat.InvokeRequired)
            {
                SetDataGridViewDataSourceCallback d = new SetDataGridViewDataSourceCallback(SetDataGridViewDataSource);
                dat.Invoke(new Action(() => dat.DataSource = state));
            }
            else
            {
                dat.DataSource = state;
            }
        }

        internal static class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern bool Beep(uint dwFreq, uint dwDuration);
        }
        Graphics g = null;
        List<String> CigRead = null;
        Bitmap Map = null;
        public FormCigRemove()
        {
            InitializeComponent();
            Map = new Bitmap(PictureBox1.Width, PictureBox1.Height);
            g = Graphics.FromImage(Map);
        }
        private void Bump()
        {
            NativeMethods.Beep(300, 210);
        }
        private void button1CigIndicator_Click(object sender, EventArgs e)
        {
            try
            {

                CigReaderDatabase.CigDatabase Cig = new CigReaderDatabase.CigDatabase();
                Cig.CigInsert(DateTime.Now.ToString());
                CigRead = new List<String>();
                Cig.CigRead(ref dataGridViewCig, ref CigRead);
                List<Double> SL = new List<Double>();

                if (CigRead != null)
                {
                    double CigReadL = 0;
                    int CigL = 999999999;
                    int iL = 0;

                    for (int i = 0; i < CigRead.Count - 1; i++)
                    {
                        DateTime S = System.Convert.ToDateTime(CigRead[i]);
                        DateTime A = System.Convert.ToDateTime(CigRead[i + 1]);
                        double SS = S.Hour * 60 * 60 * 1000 + S.Minute * 60 * 1000 + S.Second * 1000 + S.Millisecond;
                        double AA = A.Hour * 60 * 60 * 1000 + A.Minute * 60 * 1000 + A.Second * 1000 + A.Millisecond;
                        String D = S.ToString().Substring(S.ToString().Length - 2, 2);
                        //       if (D == "PM" && S.Hour != 12)
                        //           SS += 12 * 60 * 60 * 1000;
                        String H = A.ToString().Substring(A.ToString().Length - 2, 2);
                        //       if (H == "PM" && A.Hour != 12)
                        //           AA += 12 * 60 * 60 * 1000;
                        if (CigReadL < (AA - SS))
                        {
                            CigReadL = (AA - SS);
                            iL = i;
                        }
                        if (CigL > (AA - SS))
                            CigL = (int)(AA - SS);
                    }
                    if (CigRead != null)
                        for (int i = 0; i < CigRead.Count; i++)
                        {
                            DateTime S = System.Convert.ToDateTime(CigRead[i]);
                            String D = S.ToString().Substring(S.ToString().Length - 2, 2);
                            double SS = S.Hour * 60 * 60 * 1000 + S.Minute * 60 * 1000 + S.Second * 1000 + S.Millisecond;
                            //                if (D == "PM" && S.Hour != 12)
                            //                  SS += 12 * 60 * 60 * 1000;
                            SL.Add(SS);

                        }
                }
                int SA = SL.Count - 1;

                double AD = SL[SA] - SL[SA - 1];
                DateTime ASA = DateTime.Now;
                double ASS = ASA.Hour * 60 * 60 * 1000 + ASA.Minute * 60 * 1000 + ASA.Second * 1000 + ASA.Millisecond;
                String HHY = ASA.ToString().Substring(ASA.ToString().Length - 2, 2);
                //   if (HHY == "PM" && ASA.Hour != 12)
                //       ASS += 12 * 60 * 60 * 1000;
                double AZ = ASS - SL[SA];
                if (File.Exists("Time.tm"))
                    File.Delete("Time.tm");
                File.WriteAllText("Time.tm", (AD - AZ).ToString());

            }

            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            CigReaderDatabase.CigDatabase Cig = new CigReaderDatabase.CigDatabase();
            CigRead = new List<String>();
            Cig.CigRead(ref dataGridViewCig, ref CigRead);
            PictureBox1_Paint(sender, new System.Windows.Forms.PaintEventArgs(g, new System.Drawing.Rectangle(0, 0, this.PictureBox1.Width, PictureBox1.Height)));
        }
        static void Log(Exception ex)
        {
            string stackTrace = ex.ToString();
            File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
        }
        void Draw()
        {
            try
            {

                double CigReadL = 0;
                int CigL = 999999999;
                int iL = 0;
                if (CigRead != null)
                {

                    for (int i = 0; i < CigRead.Count - 1; i++)
                    {
                        DateTime S = System.Convert.ToDateTime(CigRead[i]);
                        DateTime A = System.Convert.ToDateTime(CigRead[i + 1]);
                        double SS = S.Hour * 60 * 60 * 1000 + S.Minute * 60 * 1000 + S.Second * 1000 + S.Millisecond;
                        double AA = A.Hour * 60 * 60 * 1000 + A.Minute * 60 * 1000 + A.Second * 1000 + A.Millisecond;
                        String D = S.ToString().Substring(S.ToString().Length - 2, 2);
                        //  if (D == "PM" && S.Hour != 12)
                        //       SS += 12 * 60 * 60 * 1000;
                        String H = A.ToString().Substring(A.ToString().Length - 2, 2);
                        //     if (H == "PM" && A.Hour != 12)
                        //           AA += 12 * 60 * 60 * 1000;
                        if (CigReadL < (AA - SS))
                        {
                            CigReadL = (AA - SS);
                            iL = i;
                        }
                        if (CigL > (AA - SS))
                            CigL = (int)(AA - SS);
                    }
                    g.DrawLine(new System.Drawing.Pen(new SolidBrush(Color.Black)), new Point(10, this.PictureBox1.Height - 10), new Point(this.PictureBox1.Width - 10, this.PictureBox1.Height - 10));
                    g.DrawLine(new System.Drawing.Pen(new SolidBrush(Color.Black)), new Point(10, this.PictureBox1.Height - 10), new Point(10, 10));
                    List<Double> SL = new List<Double>();
                    if (CigRead != null)
                        for (int i = 0; i < CigRead.Count; i++)
                        {
                            DateTime S = System.Convert.ToDateTime(CigRead[i]);
                            String D = S.ToString().Substring(S.ToString().Length - 2, 2);
                            double SS = S.Hour * 60 * 60 * 1000 + S.Minute * 60 * 1000 + S.Second * 1000 + S.Millisecond;
                            //        if (D == "PM"&& S.Hour != 12)
                            //             SS += 12 * 60 * 60 * 1000;
                            SL.Add(SS);

                        }
                    if (CigRead != null)
                        for (int i = 1; i < SL.Count - 1; i++)
                        {
                            g.DrawLine(new System.Drawing.Pen(new SolidBrush(Color.Red)), new Point((i - 1) * 5 + 10, this.PictureBox1.Height - (int)(((SL[i] - SL[i - 1] - CigL) / CigReadL) * this.PictureBox1.Height) - 10), new Point(i * 5 + 10, this.PictureBox1.Height - (int)(((SL[i + 1] - SL[i] - CigL) / CigReadL) * this.PictureBox1.Height) - 10));
                        }
                    g.DrawString(CigRead[iL].ToString(), new System.Drawing.Font("Times New Roman", 10), new SolidBrush(Color.Green), new Point(this.PictureBox1.Width - 100, this.PictureBox1.Height - 20));
                    g.DrawString("مقدار بیشتر، کاهش مصرف بیشتر نسبت به قبلی ", new System.Drawing.Font("B Nazanin", 14), new SolidBrush(Color.Green), new Point(20, 20));




                    this.PictureBox1.Image = Map;

                    int SA = SL.Count - 1;
                    /*if (SA > 0)
                    {
                        double AD = SL[SA] - SL[SA - 1];
                        DateTime ASA = DateTime.Now;
                        double ASS = ASA.Hour * 60 * 60 * 1000 + ASA.Minute * 60 * 1000 + ASA.Second * 1000 + ASA.Millisecond;
                        String HHY = ASA.ToString().Substring(ASA.ToString().Length - 2, 2);
                //        if (HHY == "PM"&& ASA.Hour != 12)
                //            ASS += 12 * 60 * 60 * 1000;
                        double AZ = ASS - SL[SA];
                        DateTime DS = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(AD - AZ + 60000);
                        SetLableValue(labelRemaining, DS.ToString());
                        if (AD - AZ + 60000 < 0)
                        {
                            labelRemaining.ForeColor = Color.Red;
                            Bump();
                        }
                        else
                            labelRemaining.ForeColor = Color.Black;
                    }
                    else*/
                    {
                        String As = "";
                        As = File.ReadAllText("Time.tm");
                        double AS = System.Convert.ToDouble(As);
                        DateTime ASA = DateTime.Now;
                        double ASS = ASA.Hour * 60 * 60 * 1000 + ASA.Minute * 60 * 1000 + ASA.Second * 1000 + ASA.Millisecond;
                        String HHY = ASA.ToString().Substring(ASA.ToString().Length - 2, 2);
                        //        if (HHY == "PM" && ASA.Hour != 12)
                        //            ASS += 12 * 60 * 60 * 1000;
                        double AZ = ASS - SL[SA];
                        DateTime DS = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(AS - AZ + 60000);
                        SetLableValue(labelRemaining, DS.ToString());
                        if (AS - AZ + 60000 < 0)
                        {
                            labelRemaining.ForeColor = Color.Red;
                            Bump();
                        }
                        else
                            labelRemaining.ForeColor = Color.Black;
                    }
                }


            }
            catch (Exception t)
            {
                Log(t);
                MessageBox.Show(t.ToString());
            }

        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Draw));
            t.Start();
        }

        private void FormCigRemove_Load(object sender, System.EventArgs e)
        {
            try
            {
                CigReaderDatabase.CigDatabase Cig = new CigReaderDatabase.CigDatabase();
                CigRead = new List<String>();
                Cig.CigRead(ref dataGridViewCig, ref CigRead);
                DateTime S = System.Convert.ToDateTime(CigRead[0]);
                DateTime Now = DateTime.Now;
                if (S.Year != Now.Year || S.Month != Now.Month || S.Day != Now.Day)
                {
                    Directory.CreateDirectory(S.Year.ToString() + S.Month.ToString() + S.Day.ToString());
                    File.Copy("CigRemove.accdb", S.Year.ToString() + S.Month.ToString() + S.Day.ToString() + "\\CigRemove.accdb");
                    (new CigReaderDatabase.CigDatabase()).CigDelete();
                }
                CigRead.Clear();
                CigRead = null;
            }
            catch (Exception t)
            {
                Log(t);
            }

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new AboutBoxCigRemove()).ShowDialog();
        }

        private void textBoxSelectiveTime_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists("Time.tm"))
                File.Delete("Time.tm");
            File.WriteAllText("Time.tm", textBoxSelectiveTime.Text);

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogBackup.Filter = "Acccess Datbase|*.accdb";
                openFileDialogBackup.ShowDialog();
                //CigReaderDatabase.CigDatabase Cig = new CigReaderDatabase.CigDatabase();
                // CigRead = new List<String>();
                // Cig.CigRead(ref dataGridViewCig, ref CigRead, openFileDialogBackup.FileName);
                // DateTime S = System.Convert.ToDateTime(CigRead[0]);
                // DateTime Now = DateTime.Now;
                //  if (S.Year != Now.Year || S.Month != Now.Month || S.Day != Now.Day)
                {
                    saveFileDialogBackup.Filter = "Access Database|*.accdb";
                    saveFileDialogBackup.ShowDialog();
                    if (File.Exists(saveFileDialogBackup.FileName))
                        File.Delete(saveFileDialogBackup.FileName);
                    File.Copy(openFileDialogBackup.FileName, saveFileDialogBackup.FileName);
                    //(new CigReaderDatabase.CigDatabase()).CigDelete();
                }
                // CigRead.Clear();
                //  CigRead = null;
            }
            catch (Exception t)
            {
                Log(t);
            }

        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogBackup.Filter = "Acccess Datbase|*.accdb";
                openFileDialogBackup.ShowDialog();
                //   CigReaderDatabase.CigDatabase Cig = new CigReaderDatabase.CigDatabase();
                //    CigRead = new List<String>();
                //    Cig.CigRead(ref dataGridViewCig, ref CigRead,openFileDialogBackup.FileName);
                //    DateTime S = System.Convert.ToDateTime(CigRead[0]);
                //   DateTime Now = DateTime.Now;
                //  if (S.Year != Now.Year || S.Month != Now.Month || S.Day != Now.Day)
                {
                    if (File.Exists("CigRemove.accdb"))
                        File.Delete("CigRemove.accdb");

                    File.Copy(openFileDialogBackup.FileName, "CigRemove.accdb");
                    //(new CigReaderDatabase.CigDatabase()).CigDelete();
                }
                // CigRead.Clear();
                //  CigRead = null;
                MessageBox.Show("موفقیت در انتقال");
            }
            catch (Exception t)
            {
                Log(t);
            }
        }
    }
}
