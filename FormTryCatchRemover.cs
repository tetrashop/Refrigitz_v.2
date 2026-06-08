using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TryCatchRemover
{
    public partial class FormTryCatchRemover : Form
    {
        private CancellationTokenSource _cts;
        private string _rootPath;
        private int _processedCount;
        private int _modifiedCount;
        private int _errorCount;

        public FormTryCatchRemover()
        {
            InitializeComponent();
            this.Text = "Refrigitz TryCatch Remover - Professional Edition";
            this.Icon = null; // بدون آیکون
            this.StartPosition = FormStartPosition.CenterScreen;
            AddTextLogo();
        }

        private void AddTextLogo()
        {
            Label txtLogo = new Label
            {
                Text = "=== Refrigitz TryCatch Remover ===\nBatch clean useless try-catch blocks",
                Font = new System.Drawing.Font("Consolas", 10, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.DarkGreen,
                AutoSize = true,
                Location = new System.Drawing.Point(12, 9),
                Name = "txtLogo"
            };
            this.Controls.Add(txtLogo);
        }

        private void InitializeComponent()
        {
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnSelectPath
            this.btnSelectPath.Location = new System.Drawing.Point(12, 50);
            this.btnSelectPath.Size = new System.Drawing.Size(100, 30);
            this.btnSelectPath.Text = "انتخاب پوشه";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);

            // txtPath
            this.txtPath.Location = new System.Drawing.Point(118, 52);
            this.txtPath.Size = new System.Drawing.Size(400, 23);
            this.txtPath.ReadOnly = true;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(12, 90);
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.Text = "شروع";
            this.btnStart.Enabled = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);

            // btnStop
            this.btnStop.Location = new System.Drawing.Point(118, 90);
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.Text = "توقف";
            this.btnStop.Enabled = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);

            // btnSaveLog
            this.btnSaveLog.Location = new System.Drawing.Point(224, 90);
            this.btnSaveLog.Size = new System.Drawing.Size(100, 30);
            this.btnSaveLog.Text = "ذخیره لاگ";
            this.btnSaveLog.Click += new System.EventHandler(this.BtnSaveLog_Click);

            // rtbLog
            this.rtbLog.Location = new System.Drawing.Point(12, 130);
            this.rtbLog.Size = new System.Drawing.Size(700, 300);
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9);
            this.rtbLog.ReadOnly = true;
            this.rtbLog.WordWrap = false;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 440);
            this.lblStatus.Size = new System.Drawing.Size(0, 15);

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(12, 460);
            this.progressBar.Size = new System.Drawing.Size(700, 20);

            // Form
            this.ClientSize = new System.Drawing.Size(724, 500);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    _rootPath = fbd.SelectedPath;
                    txtPath.Text = _rootPath;
                    btnStart.Enabled = true;
                    AppendLog("مسیر انتخاب شد: " + _rootPath);
                }
            }
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rootPath) || !Directory.Exists(_rootPath))
            {
                MessageBox.Show("لطفاً یک پوشه معتبر انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _cts = new CancellationTokenSource();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnSelectPath.Enabled = false;
            rtbLog.Clear();
            _processedCount = 0;
            _modifiedCount = 0;
            _errorCount = 0;
            AppendLog($"شروع پردازش در {DateTime.Now}");
            AppendLog($"پوشه ریشه: {_rootPath}");

            try
            {
                var files = Directory.GetFiles(_rootPath, "*.cs", SearchOption.AllDirectories);
                progressBar.Maximum = files.Length;
                progressBar.Value = 0;
                AppendLog($"تعداد فایل‌های C# یافت شده: {files.Length}");

                for (int i = 0; i < files.Length; i++)
                {
                    if (_cts.Token.IsCancellationRequested)
                    {
                        AppendLog("عملیات توسط کاربر لغو شد.");
                        break;
                    }

                    await ProcessFileAsync(files[i]);
                    _processedCount++;
                    progressBar.Value = i + 1;
                    lblStatus.Text = $"پردازش: {i + 1} از {files.Length} - تغییر یافته: {_modifiedCount} - خطا: {_errorCount}";
                    Application.DoEvents();
                }

                AppendLog($"پایان پردازش. جمعاً {_processedCount} فایل بررسی شد. {_modifiedCount} فایل تغییر کرد. {_errorCount} خطا.");
            }
            catch (Exception ex)
            {
                AppendLog($"خطای غیرمنتظره: {ex.Message}");
                MessageBox.Show($"خطای سیستمی: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnSelectPath.Enabled = true;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
            AppendLog("درخواست توقف ارسال شد...");
        }

        private async System.Threading.Tasks.Task ProcessFileAsync(string filePath)
        {
            try
            {
                var content = await System.IO.File.ReadAllTextAsync(filePath);
                string newContent = RemoveUselessTryCatchBlocks(content);
                if (newContent != content)
                {
                    // ایجاد پشتیبان
                    string backupPath = filePath + ".bak";
                    await System.IO.File.WriteAllTextAsync(backupPath, content);
                    await System.IO.File.WriteAllTextAsync(filePath, newContent);
                    _modifiedCount++;
                    AppendLog($"تغییر یافت: {Path.GetFileName(filePath)} (پشتیبان: {backupPath})");
                }
            }
            catch (Exception ex)
            {
                _errorCount++;
                AppendLog($"خطا در فایل {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }

        private string RemoveUselessTryCatchBlocks(string code)
        {
            // این regex بلاک‌های try-catch خالی (بدون کد در catch یا با catch خالی) را حذف می‌کند
            // اما بلاک‌های finally را حفظ می‌کند.
            // الگو: try { ... } catch (Exception ex) { }  یا catch { }
            // و همچنین catch با بدنه خالی یا فقط کامنت
            // حذف می‌شود اگر catch خالی باشد و finally نداشته باشد یا finally حفظ شود.
            // برای سادگی، بلاک‌های try-catch که شامل هیچ statement در catch نیستند حذف می‌شوند.
            // پیچیده‌تر نیاز به تحلیل syntax دارد، اما برای اکثر موارد ساده کار می‌کند.

            // حذف try-catch با catch خالی (بدون هیچ statement غیر از whitespace و کامنت)
            var pattern = @"try\s*\{\s*((?:(?!\btry\b).)*?)\s*\}\s*catch\s*(?:\([^)]*\))?\s*\{\s*(?://[^\n]*)?\s*\}";
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);
            string result = regex.Replace(code, m =>
            {
                string tryBody = m.Groups[1].Value.Trim();
                // اگر بدنه try خالی نباشد، آن را نگه می‌داریم ولی catch را حذف می‌کنیم
                // در واقع می‌شود: فقط بدنه try بدون try-catch
                if (!string.IsNullOrEmpty(tryBody))
                    return tryBody;
                else
                    return "";
            });

            // همچنین موارد try-catch با catch که فقط شامل throw; یا return; نیستند? ساده می‌گیریم.
            // برای جلوگیری از اشتباه، فقط بلاک‌های کاملاً خالی را حذف می‌کنیم.
            // باز هم می‌توان بهبود داد.
            return result;
        }

        private void AppendLog(string message)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => AppendLog(message)));
                return;
            }
            rtbLog.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
            rtbLog.ScrollToCaret();
        }

        private void BtnSaveLog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files|*.txt";
                sfd.DefaultExt = "txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, rtbLog.Text);
                    MessageBox.Show("لاگ ذخیره شد.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Declare controls (طراح خودکار انجام می‌دهد، ولی برای رفع خطا اضافه می‌کنیم)
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnSaveLog;
    }
}
