using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace Run
{
    public class Program
    { //Error Handling.
        static String Root = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText(Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
                }
            }
            catch (Exception t) { Log(t); }
        }

        public static void Main(string[] args)
        {
            String Root = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

            List<Process> a = new List<Process>();
            a.AddRange(Process.GetProcessesByName("Refrigtz"));
            if (a.Count >= 1)
            {

                {
                    for (int i = 0; i < a.Count; i++)
                    {
                        try
                        {

                            a[i].Kill();
                        }
                        catch (Exception t) { Log(t); }

                    }

                }
            }


            String FolderLocation = Root;
            int exitCode = 0;

            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            //TBeep.Start(); MessageBox.Show("running VisualBasicPowerPacks.Control Of the Program While 15 Second id By User.ClickOk and Finished While 20 Second");
            // Prepare the process to run
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = "";
            // Enter the executable to run, including the complete path
            start.FileName = "\"" + FolderLocation + "\\" + "Refrigtz.exe" + "\"";
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
    }
}
