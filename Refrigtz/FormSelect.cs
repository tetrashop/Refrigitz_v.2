using System;
using System.IO;
using System.Windows.Forms;
namespace Refrigtz
{
    [Serializable]
    public partial class FormSelect : Form
    {
        public static int OrderPlateDraw = 1;
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
            Object O = new Object();
            lock (O)
            {         // InvokeRequired required compares the thread ID of the
                      // calling thread to the thread ID of the creating thread.
                      // If these threads are different, it continue;s true.
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
        }
        private void FormSelect_Load(object sender, EventArgs e)
        {
            Object O = new Object();
            lock (O)
            {
                if (File.Exists("_DonotDelete.txt"))
                    RadioButtonBrownOrder.Checked = true;
                else
                    RadioButtonGrayOrder.Checked = true;


            }
        }

        private void RadioButtonBrownOrder_CheckedChanged(object sender, EventArgs e)
        {
            Object O = new Object();
            lock (O)
            {
                OrderPlateDraw = -1;
                if (RadioButtonBrownOrder.Checked)
                {
                    if (!File.Exists("_DonotDelete.txt"))
                        File.Create("_DonotDelete.txt");

                }
            }
        }

        private void RadioButtonGrayOrder_CheckedChanged(object sender, EventArgs e)
        {
            Object O = new Object();
            lock (O)
            {
                if (RadioButtonGrayOrder.Checked)
                {
                    OrderPlateDraw = 1;
                    if (File.Exists("_DonotDelete.txt"))
                        File.Delete("_DonotDelete.txt");
                }
            }
        }
    }
}
//End Documents.