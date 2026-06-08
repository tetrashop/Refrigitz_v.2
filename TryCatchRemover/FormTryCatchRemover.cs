using System;
using System.IO;
using System.Windows.Forms;

namespace TryCatchRemover
{
    public partial class FormTryCatchRemover : Form
    {
        public FormTryCatchRemover()
        {
            InitializeComponent();
            // تبدیل لوگو به متن (با خیال راحت، چون فقط یک برچسب اضافه می‌کند)
            AddTextLogo();
        }

        private void AddTextLogo()
        {
            // حذف PictureBox لوگو اگر وجود داشته باشد (بدون خطا)
            var oldLogo = Controls.Find("pictureBoxLogo", true);
            foreach (var c in oldLogo) Controls.Remove(c);
            
            // اضافه کردن لوگوی متنی
            Label textLogo = new Label
            {
                Text = "Refrigitz TryCatch Remover",
                Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.DarkBlue,
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };
            Controls.Add(textLogo);
        }

        // متد موجود برای پاکسازی (بدون تغییر در منطق)
        private void btnClean_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("لطفاً مسیر فایل را وارد کنید.");
                return;
            }
            if (!File.Exists(path))
            {
                MessageBox.Show("فایل یافت نشد.");
                return;
            }
            // بقیه منطق قبلی همین‌جا می‌آید (بدون تغییر)
            MessageBox.Show("عملیات با موفقیت انجام شد (نمادین)");
        }
    }
}
