using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace Refrigtz
{
    public partial class FormSelect : Form
    {
        static void Log(Exception ex)
        {
            try
            {
                string stackTrace = ex.ToString();
                File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
            }
            catch (Exception t) { Log(t); }
        }
        //Constructor.
        public FormSelect()
        {
            InitializeComponent();
        }
        //Delegate Of Form Close Visibility.
        delegate void SetCloseVisibleCallback();

        public void SetCloseVisible()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                try
                {

                    SetCloseVisibleCallback d = new SetCloseVisibleCallback(SetCloseVisible);
                    this.Invoke(new Action(() => this.Close()));
                }
                catch (Exception t) { Log(t); }
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (Exception t) { Log(t); }
            }

        }

        private void FormSelect_Load(object sender, EventArgs e)
        {

        }

    }
}
//End Documents.