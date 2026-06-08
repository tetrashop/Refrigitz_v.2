using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace CigReaderDatabase
{
    class CigDatabase
    {
        OleDbConnection bookConnJs;
        OleDbCommand oleDbCmdJs = new OleDbCommand();
        List<String> Words = new List<String>();
        String connParamJs = "";

        OleDbConnection bookConnWo;
        OleDbCommand oleDbCmdWo = new OleDbCommand();
        String connParamWo = "";

        public CigDatabase()
        {
            connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "CigRemove.accdb;Persist Security Info=true;Jet OLEDB:Database Password='HGBVBGF(HGDSACBNB!'";
            connParamJs = connParamJs.Replace("\\", "/");

        }
        delegate void SetprogressBarJSONValueCalBack(ProgressBar JSON, Int32 value);
        private void SetprogressBarJSONValue(ProgressBar JSON, Int32 value)
        {
            try
            {
                if (JSON.InvokeRequired)
                {
                    SetprogressBarJSONValueCalBack d = new SetprogressBarJSONValueCalBack(SetprogressBarJSONValue);
                    JSON.Invoke(new Action(() => JSON.Value = value));
                }
                else
                {
                    JSON.Value = value;
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
        static void Log(Exception ex)
        {
            string stackTrace = ex.ToString();
            File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
        }

        public bool CigRead(ref DataGridView dataGridViewCig, ref List<String> CigRead)
        {
            bool OK = false;
            try
            {

                connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "CigRemove.accdb;Persist Security Info=true;Jet OLEDB:Database Password='HGBVBGF(HGDSACBNB!'";
                connParamJs = connParamJs.Replace("\\", "/");
                OleDbConnection conObj = new OleDbConnection(connParamJs);
                conObj.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                OleDbDataAdapter da = new OleDbDataAdapter();
                String AAA = "";

                AAA = "select * from CigTable";

                da = new OleDbDataAdapter(AAA, conObj);
                da.Fill(dt);
                dataGridViewCig.DataSource = dt.DefaultView;
                dataGridViewCig.Refresh();
                for (int i = 0; i < dataGridViewCig.RowCount; i++)
                {
                    CigRead.Add(dataGridViewCig.Rows[i].Cells["CigDateS"].Value.ToString());
                }
                conObj.Close();
                conObj.Dispose();
                da.Dispose();
                OK = true;
            }
            catch (Exception t)
            {
                Log(t);
            }
            return OK;

        }
        public bool CigRead(ref DataGridView dataGridViewCig, ref List<String> CigRead, String fileName)
        {
            bool OK = false;
            try
            {

                connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Persist Security Info=true;Jet OLEDB:Database Password='HGBVBGF(HGDSACBNB!'";
                connParamJs = connParamJs.Replace("\\", "/");
                OleDbConnection conObj = new OleDbConnection(connParamJs);
                conObj.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                OleDbDataAdapter da = new OleDbDataAdapter();
                String AAA = "";

                AAA = "select * from CigTable";

                da = new OleDbDataAdapter(AAA, conObj);
                da.Fill(dt);
                dataGridViewCig.DataSource = dt.DefaultView;
                dataGridViewCig.Refresh();
                for (int i = 0; i < dataGridViewCig.RowCount; i++)
                {
                    CigRead.Add(dataGridViewCig.Rows[i].Cells["CigDateS"].Value.ToString());
                }
                conObj.Close();
                conObj.Dispose();
                da.Dispose();
                OK = true;
            }
            catch (Exception t)
            {
                Log(t);
            }
            return OK;

        }

        private bool ShowWordFreuency(ref DataGridView dataGridViewJSON)
        {
            bool OK = false;
            try
            {
                connParamWo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "WordsJSONFreuency.accdb;Persist Security Info=true;Jet OLEDB:Database Password='ddfg!asdsax*Ghklk('";
                connParamWo = connParamWo.Replace("\\", "/");
                OleDbConnection conObj = new OleDbConnection(connParamWo);
                conObj.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                OleDbDataAdapter da = new OleDbDataAdapter();
                String AAA = "";

                AAA = "select * from JSONWord";

                da = new OleDbDataAdapter(AAA, conObj);
                da.Fill(dt);
                this.SetDataGridViewDataSource(dataGridViewJSON, dt.DefaultView);
                conObj.Close();
                conObj.Dispose();
                da.Dispose();
                OK = true;
            }
            catch (Exception t)
            {
            }
            return OK;

        }
        private bool JSONCreateWord(ref ProgressBar progressBarJSON, ref Label lableJSON)
        {

            bool OK = false;
            try
            {
                connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "JSON.accdb;Persist Security Info=true;Jet OLEDB:Database Password='a*dasdf^ddfghjhf)'";
                connParamJs = connParamJs.Replace("\\", "/");
                bookConnJs = new OleDbConnection(connParamJs);
                bookConnJs.Open();
                oleDbCmdJs.Connection = bookConnJs;
                oleDbCmdJs.CommandText = "Select * From JSONContent";
                int temp = 0;
                OleDbDataReader Ree = oleDbCmdJs.ExecuteReader();

                int Len = 0, MaxLen = 0;
                while (Ree.Read())
                    MaxLen++;

                bookConnJs.Close();
                bookConnJs.Dispose();
                oleDbCmdJs.Dispose();
                oleDbCmdJs = new OleDbCommand();
                connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "JSON.accdb;Persist Security Info=true;Jet OLEDB:Database Password='a*dasdf^ddfghjhf)'";
                connParamJs = connParamJs.Replace("\\", "/");
                bookConnJs = new OleDbConnection(connParamJs);
                bookConnJs.Open();
                oleDbCmdJs.Connection = bookConnJs;
                oleDbCmdJs.CommandText = "Select * From JSONContent";
                Ree = oleDbCmdJs.ExecuteReader();

                SetprogressBarJSONMaxValue(progressBarJSON, MaxLen);
                double T1 = 0, T2 = 0, T = 0;
                while (Ree.Read())
                {
                    T1 = DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000 + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
                    Len++;
                    SetprogressBarJSONValue(progressBarJSON, Len);
                    Words.Clear();
                    String Dummy = Ree["QueryTextS"].ToString();
                    Dummy = Dummy.Replace("'", "");
                    int G = 0;
                    while (G <= Dummy.Length && Dummy.IndexOf(" ") != -1)
                    {
                        String Word = Dummy.Substring(0, Dummy.IndexOf(" "));
                        G += (Word.Length + 1);
                        Dummy = Dummy.Remove(0, Dummy.IndexOf(" ") + 1);

                        Words.Add(Word);
                    }
                    if (Dummy.IndexOf(" ") == -1)
                        Words.Add(Dummy);
                    for (int j = 0; j < Words.Count; j++)
                    {
                        connParamWo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "WordsJSONFreuency.accdb;Persist Security Info=true;Jet OLEDB:Database Password='ddfg!asdsax*Ghklk('";
                        connParamWo = connParamWo.Replace("\\", "/");
                        bookConnWo = new OleDbConnection(connParamWo);
                        bookConnWo.Open();
                        oleDbCmdWo.Connection = bookConnWo;
                        oleDbCmdWo.CommandText = "Select * From JSONWord Where WordS='" + Words[j] + "'";
                        temp = 0;
                        OleDbDataReader Re = oleDbCmdWo.ExecuteReader();
                        if (Re.Read())
                        {
                            connParamWo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "WordsJSONFreuency.accdb;Persist Security Info=true;Jet OLEDB:Database Password='ddfg!asdsax*Ghklk('";
                            oleDbCmdWo.Dispose();
                            oleDbCmdWo = new OleDbCommand();
                            oleDbCmdWo.CommandText = "UPDATE JSONWord SET Words=@Words, FrequencyS=@FrequencyS Where ID=" + Re["ID"].ToString();
                            oleDbCmdWo.Parameters.AddWithValue("@Words", Words[j]);
                            oleDbCmdWo.Parameters.AddWithValue("@FrequencyS", System.Convert.ToInt32(Re["FrequencyS"]) + 1);

                            bookConnWo = new OleDbConnection(connParamWo);
                            bookConnWo.Open();
                            oleDbCmdWo.Connection = bookConnWo;

                            temp = oleDbCmdWo.ExecuteNonQuery();
                            if (temp <= 0)
                                MessageBox.Show("خطای ورود رکورد.");
                            oleDbCmdWo.Dispose();
                            bookConnWo.Close();
                            bookConnWo.Dispose();
                            OK = true;
                        }
                        else
                        {
                            oleDbCmdWo = new OleDbCommand();
                            connParamWo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "WordsJSONFreuency.accdb;Persist Security Info=true;Jet OLEDB:Database Password='ddfg!asdsax*Ghklk('";
                            bookConnWo = new OleDbConnection(connParamWo);
                            bookConnWo.Open();
                            oleDbCmdWo.Connection = bookConnWo;
                            oleDbCmdWo.CommandText = "insert into JSONWord(WordS,FrequencyS)  values (@WordS,@FrequencyS)";
                            oleDbCmdWo.Parameters.AddWithValue("@WordS", Words[j]);
                            oleDbCmdWo.Parameters.AddWithValue("@FrequencyS", 1);
                            temp = oleDbCmdWo.ExecuteNonQuery();
                            if (temp <= 0)
                                MessageBox.Show("خطای ورود رکورد.");
                            oleDbCmdWo.Dispose();
                            bookConnWo.Close();
                            bookConnWo.Dispose();

                        }
                    }
                    T2 = DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000 + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
                    if (T1 != 0 && T2 != 0)
                    {
                        String Dum = "";
                        Dum += "About ";
                        T = ((T * (Len - 1)) + (T2 - T1)) / Len;
                        DateTime Time = new DateTime();
                        Time = Time.AddMilliseconds(T * MaxLen - Len * T);
                        bool and = false;
                        if (Time.Hour != 0)
                        {
                            Dum += Time.Hour.ToString();
                            Dum += " Hour ";
                            and = true;
                        }

                        if (Time.Minute != 0)
                        {
                            if (and)
                                Dum += " and ";
                            Dum += Time.Minute.ToString();
                            Dum += " Minute ";
                            and = true;
                        }
                        if (Time.Second != 0)
                        {
                            if (and)
                                Dum += " and ";
                            Dum += Time.Second.ToString();
                            if (and)
                                Dum += " Second ";

                        }
                        Dum += " Remining";
                        SetlableJSONMaxValue(lableJSON, Dum);
                    }

                }
                SetlableJSONMaxValue(lableJSON, "Finished.");
                bookConnJs.Close();
                bookConnJs.Dispose();
                oleDbCmdJs.Dispose();

            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
            }
            return OK;
        }

        public bool CigInsert(String CigDateS)
        {
            bool OK = false;
            try
            {
                connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "CigRemove.accdb;Persist Security Info=true;Jet OLEDB:Database Password='HGBVBGF(HGDSACBNB!'";
                connParamJs = connParamJs.Replace("\\", "/");
                bookConnJs = new OleDbConnection(connParamJs);
                bookConnJs.Open();
                oleDbCmdJs.Connection = bookConnJs;
                oleDbCmdJs.CommandText = "insert into CigTable(CigDateS)  values (@CigDateS)";
                oleDbCmdJs.Parameters.AddWithValue("@CigDateS", System.Convert.ToDateTime(CigDateS));
                int temp = 0;
                temp = oleDbCmdJs.ExecuteNonQuery();
                if (temp <= 0)
                    MessageBox.Show("خطای ورود رکورد.");
                else
                    MessageBox.Show("موفقیت در ورود اطلاعات.");
                oleDbCmdJs.Dispose();
                bookConnJs.Close();
                bookConnJs.Dispose();
                OK = true;
            }
            catch (Exception t)
            {
                Log(t);
                MessageBox.Show(t.ToString());
            }


            return OK;
        }
        public bool CigDelete()
        {
            bool OK = false;
            try
            {
                connParamJs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\" + "CigRemove.accdb;Persist Security Info=true;Jet OLEDB:Database Password='HGBVBGF(HGDSACBNB!'";
                connParamJs = connParamJs.Replace("\\", "/");
                bookConnJs = new OleDbConnection(connParamJs);
                bookConnJs.Open();
                oleDbCmdJs.Connection = bookConnJs;
                oleDbCmdJs.CommandText = "Delete * From CigTable";
                int temp = 0;
                temp = oleDbCmdJs.ExecuteNonQuery();
                if (temp <= 0)
                    MessageBox.Show("خطای حذف.");
                else
                    MessageBox.Show("موفقیت حذف.");
                oleDbCmdJs.Dispose();
                bookConnJs.Close();
                bookConnJs.Dispose();
                OK = true;
            }
            catch (Exception t)
            {
                Log(t);
                MessageBox.Show(t.ToString());
            }


            return OK;
        }

    }
}
