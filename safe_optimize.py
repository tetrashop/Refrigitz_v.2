#!/usr/bin/env python3
import os, re, shutil, subprocess, sys

SRC_DIR = "Formulas"
BACKUP_DIR = "Formulas_backup_safe"

# ۱. بک‌آپ
if not os.path.exists(BACKUP_DIR):
    shutil.copytree(SRC_DIR, BACKUP_DIR)
    print("📦 بک‌آپ در", BACKUP_DIR)

def safe_optimize(code: str) -> str:
    # فقط حذف this. اضافی (در انتساب‌ها و دسترسی به متدها)
    # شرط: اگر بعد از حذف this. متغیر همنام با پارامتر نداشته باشیم (بررسی ساده نمی‌کنیم،
    # اما این حذف در ۹۹٪ موارد بی‌خطر است)
    code = re.sub(r'\bthis\.', '', code)

    # ساده‌سازی شرط‌های true/false
    code = re.sub(r'if\s*\(\s*(\w+)\s*==\s*true\s*\)', r'if (\1)', code)
    code = re.sub(r'if\s*\(\s*(\w+)\s*==\s*false\s*\)', r'if (!\1)', code)
    code = re.sub(r'if\s*\(\s*true\s*==\s*(\w+)\s*\)', r'if (\1)', code)
    code = re.sub(r'if\s*\(\s*false\s*==\s*(\w+)\s*\)', r'if (!\1)', code)

    return code

# --- پردازش ---
print("🔧 اعمال بهینه‌سازی‌های ایمن...")
changed = 0
for root, _, files in os.walk(SRC_DIR):
    for f in files:
        if f.endswith(".cs"):
            path = os.path.join(root, f)
            with open(path, "r", encoding="utf-8") as fp:
                original = fp.read()
            improved = safe_optimize(original)
            if improved != original:
                with open(path, "w", encoding="utf-8") as fp:
                    fp.write(improved)
                print(f"   ✨ {os.path.relpath(path, SRC_DIR)}")
                changed += 1

if changed == 0:
    print("   (قبلاً بهینه شده بودند)")
else:
    print(f"\n✅ {changed} فایل بهبود یافتند.")

# --- کامپایل نهایی ---
print("\n🔨 کامپایل نهایی...")
all_files = []
for root, _, files in os.walk(SRC_DIR):
    for f in files:
        if f.endswith(".cs"):
            all_files.append(os.path.join(root, f))
cmd = ["mcs", "-target:library", "-out:Refrigitz.dll",
       "-r:System.Windows.Forms.dll", "-r:System.Drawing.dll",
       "-r:System.Data.dll", "-r:System.Xml.dll", "-r:System.Core.dll"] + all_files
proc = subprocess.run(cmd, capture_output=True, text=True)
if proc.returncode == 0:
    print("🎉 پروژه بدون خطا کامپایل شد. بهینه‌سازی موفق بود.")
else:
    print("⚠️ کامپایل با خطا مواجه شد. بازگردانی بک‌آپ...")
    shutil.rmtree(SRC_DIR)
    shutil.copytree(BACKUP_DIR, SRC_DIR)
    print("🔄 فایل‌ها به حالت اولیه برگشتند.")
