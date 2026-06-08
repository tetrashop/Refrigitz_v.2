using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace WebJobRefregitz
{
    public partial class FormSelect : Form
    {
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.}
                }
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
            if (File.Exists("_DonotDelete.txt"))
                radioButtonBrownOrder.Checked = true;
            else
                radioButtonGrayOrder.Checked = true;
                
                    
            
        }

        private void radioButtonBrownOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBrownOrder.Checked)
            {
                if (!File.Exists("_DonotDelete.txt"))
                    File.Create("_DonotDelete.txt");

            }
        }

        private void radioButtonGrayOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGrayOrder.Checked)
            {
                if (File.Exists("_DonotDelete.txt"))
                    File.Delete("_DonotDelete.txt");
            }
        }
    }
}
//End Documents.