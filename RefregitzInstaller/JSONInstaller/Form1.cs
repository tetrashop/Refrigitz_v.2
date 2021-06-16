using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace JSONInstaller
{
    public partial class FormJSONInstaller : Form
    {
        public static class InternalCheck
        {
            static bool is64BitProcess = (IntPtr.Size == 8);
            static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();

            [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool IsWow64Process(
                [In] IntPtr hProcess,
                [Out] out bool wow64Process
            );
            public static bool InternalCheckIsWow64()
            {
                if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                    Environment.OSVersion.Version.Major >= 6)
                {
                    using (Process p = Process.GetCurrentProcess())
                    {
                        bool retVal = false;
                        if (!IsWow64Process(p.Handle, out retVal))
                        {
                            return false;
                        }
                        return retVal;
                    }
                }
                else
                {
                    return false;
                }
            }

        }

        public FormJSONInstaller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!FormJSONInstaller.InternalCheck.InternalCheckIsWow64())
            {
                MessageBox.Show("نصب 32 بیتی");
                ProcessStartInfo start = new ProcessStartInfo();
                int exitCode = 0;

                try
                {
                    exitCode = 0;
                    // Prepare the process to run
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"AccessDatabaseEngineOLEDB12.0Error\\AccessDatabaseEngineOLEDB12.0Error-x86\\AccessDatabaseEngine.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }
                    //MessageBox.Show("پایان نصب اکسس دیتا بیس انجین");
                }
                catch (Exception tt)
                {
                }/*
                try
                {
                    exitCode = 0;
                    // Prepare the process to run
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "Fonts\\BNazanin.ttf";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"C:\\Windows\\System32\\fontview.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }
                    //MessageBox.Show("پایان نصب اکسس دیتا بیس انجین");
                }
                catch (Exception tt)
                {
                }
         */
                try
                {
                    exitCode = 0;

                    // Prepare the process to run
                    start = new ProcessStartInfo();
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "/passive";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"DotNetFX40Client\\dotNetFx40_Client_x86_x64.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }

                }
                catch (Exception t)
                {
                }

                try
                {
                    exitCode = 0;
                    // Prepare the process to run
                    start = new ProcessStartInfo();
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"Setup.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }

                }
                catch (Exception t)
                {
                }
                MessageBox.Show("پایان نصب کل مراحل");
                //     this.Show();
                /*try
                {
                    if (File.Exists("C:\\Windows\\Fonts\\BNazanin.ttf"))
                        File.Delete("C:\\Windows\\Fonts\\BNazanin.ttf");
                    if (File.Exists("C:\\Windows\\Fonts\\BNaznnBd.ttf"))
                        File.Delete("C:\\Windows\\Fonts\\BNaznnBd.ttf");
                    File.Copy("Fonts\\BNazanin.ttf", "C:\\Windows\\Fonts\\BNazanin.ttf");
                    File.Copy("Fonts\\BNaznnBd.ttf", "C:\\Windows\\Fonts\\BNaznnBd.ttf");
                    MessageBox.Show("پایان نصب فونت");
                }
                catch (Exception t)
                {
                    MessageBox.Show("فونت یا نصب شده است یا اشکال در نصب وجود دارد.");
                    MessageBox.Show(t.ToString());
                }*/

            }
            else
            {
                MessageBox.Show("نصب 64 بیتی");
                ProcessStartInfo start = new ProcessStartInfo();
                int exitCode = 0;
                try
                {
                    exitCode = 0;
                    // Prepare the process to run
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "/passive";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"AccessDatabaseEngineOLEDB12.0Error\\AccessDatabaseEngineOLEDB12.0Error-x64\\AccessDatabaseEngine_x64.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }
                }
                catch (Exception ttt)
                {
                    // MessageBox.Show("اشکال در نصب دیتابیس انجین");
                }

                try
                {
                    exitCode = 0;

                    // Prepare the process to run
                    start = new ProcessStartInfo();
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "/passive";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"DotNetFX40Client\\dotNetFx40_Client_x86_x64.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }
                }
                catch (Exception t)
                {
                }



                try
                {
                    exitCode = 0;
                    // Prepare the process to run
                    start = new ProcessStartInfo();
                    //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
                    // Prepare the process to run
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = "";
                    // Enter the executable to run, including the complete path
                    start.FileName = "\"Setup.exe\"";
                    // Do you want to show a console window?
                    start.WindowStyle = ProcessWindowStyle.Normal;
                    start.CreateNoWindow = true;
                    start.UseShellExecute = true;
                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }
                }
                catch (Exception t)
                {
                }


                MessageBox.Show("پایان نصب کل مراحل");
            }
            Application.Exit();

        }


    }
}
