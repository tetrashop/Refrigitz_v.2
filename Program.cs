using System;
using System.IO;
using System.Windows.Forms;

namespace TryCatchRemover
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => LogAndShowError(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => LogAndShowError(e.ExceptionObject as Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTryCatchRemover());
        }

        private static void LogAndShowError(Exception ex)
        {
            string logPath = Path.Combine(Application.StartupPath, "TryCatchRemover_Error.log");
            File.AppendAllText(logPath, $"{DateTime.Now}: {ex?.ToString()}{Environment.NewLine}");
            MessageBox.Show($"خطای غیرمنتظره: {ex?.Message}\nلاگ در {logPath} ذخیره شد.", "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
