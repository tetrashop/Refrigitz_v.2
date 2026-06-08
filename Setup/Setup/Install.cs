using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace Setup
{
    public partial class Install : Form
    {
        //  Call this function to remove the key from memory after use for security
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        String FolderLocation;
        public Install()
        {
            FolderLocation = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            InitializeComponent();
        }

        private void Install_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Your Windows Will Be Need To Restart.Save Chnges before install.");
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            try
            {
                int exitCode = 0;
                labelState.Text = "running AccessDatabaseEngine.exe.Control Of the Program While 20 Second id By User.";
                // Prepare the process to run
                ProcessStartInfo start = new ProcessStartInfo();
                //MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                // Prepare the process to run
                // Enter in the command line arguments, everything you would enter after the executable name itself
                start.Arguments = "";
                // Enter the executable to run, including the complete path
                start.FileName = "\"" + FolderLocation + "\\" + "AccessDatabaseEngine.exe" + "\"";
                // Do you want to show a console window?
                start.WindowStyle = ProcessWindowStyle.Normal;
                start.CreateNoWindow = true;

                // Run the external process & wait for it to finish
                using (Process proc = Process.Start(start))
                {
                    labelState.Text = "Wait To Exit.";
                    proc.WaitForExit(20000);

                    // Retrieve the app's exit code
                    exitCode = proc.ExitCode;


                }

                //MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                // Prepare the process to run
                start = new ProcessStartInfo();
                // Enter in the command line arguments, everything you would enter after the executable name itself
                start.Arguments = "";
                // Enter the executable to run, including the complete path
                start.FileName = "\"" + FolderLocation + "\\" + "VisualBasicPowerPacksSetup.exe" + "\"";
                // Do you want to show a console window?
                start.WindowStyle = ProcessWindowStyle.Normal;
                start.CreateNoWindow = true;

                // Run the external process & wait for it to finish
                using (Process proc = Process.Start(start))
                {
                    labelState.Text = "Wait To Exit.";
                    proc.WaitForExit(15000);

                    // Retrieve the app's exit code
                    exitCode = proc.ExitCode;


                }

                if (checkBoxLanchAndShortcut.Checked)
                {
                    if (System.IO.File.Exists(FolderLocation + "\\" + "Checksum.btt"))
                        System.IO.File.Delete(FolderLocation + "\\" + "Checksum.btt");
                    labelState.Text = "Creating Shortcut and run Program.";
                    // Prepare the process to run
                    start = new ProcessStartInfo();
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "";
                    // Enter the executable to run, including the complete path
                    start.FileName = @FolderLocation + "\\" + "BodyBuldingTetra.exe";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;

                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        labelState.Text = "Wait To Exit.";
                        proc.WaitForExit(1000);

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;

                    }


                }
                else
                    System.IO.File.WriteAllText(FolderLocation + "\\" + "Checksum.btt", ";laslsjfkl");

                MessageBox.Show("Your Windows Need To Restart.");
                this.Hide();
                System.Diagnostics.Process.Start("ShutDown", "/r");
                
          
            }

            catch (Exception t)
            {
                MessageBox.Show("Your Windows Need To Restart.");
                this.Hide();
                System.Diagnostics.Process.Start("ShutDown", "/r");
              
                
            }
        }
    }
}

