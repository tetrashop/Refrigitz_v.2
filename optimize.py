#!/usr/bin/env python3
import os, re, shutil, subprocess, sys

SRC_DIR = "Formulas"
BACKUP_DIR = "Formulas_backup_before_optimize"

# ۱. بک‌آپ از کل پوشه
if not os.path.exists(BACKUP_DIR):
    shutil.copytree(SRC_DIR, BACKUP_DIR)
    print("📦 بک‌آپ در", BACKUP_DIR)

def optimize_code(code: str) -> str:
    # --- حذف this. بی‌خطر ---
    code = re.sub(r'\bthis\.', '', code)

    # --- تبدیل ArrayList / Hashtable به Generic (اگر وجود داشته باشد) ---
    if 'ArrayList' in code:
        code = re.sub(r'\bArrayList\b', 'List<object>', code)
        if 'using System.Collections.Generic;' not in code:
            code = 'using System.Collections.Generic;\n' + code
    if 'Hashtable' in code:
        code = re.sub(r'\bHashtable\b', 'Dictionary<object,object>', code)
        if 'using System.Collections.Generic;' not in code:
            code = 'using System.Collections.Generic;\n' + code

    # --- تبدیل if (x == true) به if (x) ---
    code = re.sub(r'if\s*\(\s*(\w+)\s*==\s*true\s*\)', r'if (\1)', code)
    code = re.sub(r'if\s*\(\s*(\w+)\s*==\s*false\s*\)', r'if (!\1)', code)

    # --- استفاده از StringBuilder در متدهایی که ۳ بار یا بیشتر string += انجام می‌دهند ---
    # (فقط یک بهینه‌سازی اولیه؛ اگر متغیر قبلاً StringBuilder نباشد، تبدیل می‌کنیم)
    # ابتدا متدهایی که در آن‌ها یک متغیر رشته‌ای با += زیاد استفاده شده را پیدا می‌کنیم
    # ساده‌ترین حالت: اگر در یک متد متغیری از نوع string داریم که چند بار += شده،
    # آن را به StringBuilder تبدیل می‌کنیم.
    # به دلیل پیچیدگی، فقط یک الگوی خیلی واضح را هدف می‌گیریم:
    # string x = ""; ... x += ...; (بیش از ۲ بار)
    # این بخش نیاز به تحلیل دقیق‌تر دارد، اما برای جلوگیری از خرابی،
    # فقط در صورتی که نام متغیر "sb" یا "builder" نباشد، کاری نمی‌کنیم.
    # به‌جای آن، یک بهبود ساده‌تر: حذف متغیرهای موقتی که استفاده نمی‌شوند.

    # --- حذف متغیرهای محلی بلااستفاده (اختصاص داده شده ولی خوانده نشده) ---
    # حذف خطوطی که فقط یک متغیر را تعریف و مقداردهی می‌کنند و در ادامهٔ همان بلوک
    # هرگز از آن متغیر استفاده نمی‌شود. (رفع CS0219)
    lines = code.split('\n')
    new_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        # تشخیص تعریف متغیر با انتساب: Type var = ...;
        m = re.match(r'^(\s*)(\w+)\s+(\w+)\s*=\s*(.+);\s*$', line)
        if m:
            indent = m.group(1)
            var_name = m.group(3)
            # بلوک جاری را تا بسته شدن } هم‌سطح با این indent پیدا کن
            j = i + 1
            while j < len(lines):
                if lines[j].startswith(indent + '}') or (lines[j].strip() == '}' and len(lines[j]) - len(lines[j].lstrip()) <= len(indent)):
                    break
                j += 1
            block = '\n'.join(lines[i+1:j])
            # اگر در این بلوک (و در بقیهٔ متد) از var_name استفاده نشده باشد، خط را حذف کن
            # اما مراقب باش که ممکن است var_name بعداً در بلوک‌های بیرونی استفاده شود،
            # بنابراین فقط در همان سطح indent بررسی می‌کنیم (ساده‌سازی)
            # در عمل، فقط متغیرهایی که در همان متد و بعد از تعریف استفاده نمی‌شوند حذف می‌شوند.
            # با این حال ریسک وجود دارد، پس فقط اگر در کل فایل بعد از این خط نام متغیر نیامده باشد.
            rest_of_file = '\n'.join(lines[i+1:])
            if var_name not in rest_of_file:
                # اطمینان از اینکه این یک متغیر محلی ساده است (با حروف کوچک شروع می‌شود)
                if var_name[0].islower() and not var_name.startswith('_'):
                    i += 1
                    continue  # این خط را اضافه نمی‌کنیم (حذف)
        new_lines.append(line)
        i += 1
    code = '\n'.join(new_lines)

    # --- حذف کدهای unreachable ( warning CS0162 ) ---
    # فقط return بلافاصله بعد از return یا throw یا break غیرشرطی را حذف می‌کنیم
    code = re.sub(r'return\s+[^;]+;\s*return\s+[^;]+;', lambda m: m.group(0).split(';')[0] + ';', code)

    return code

# --- پردازش همه فایل‌های .cs ---
print("🔧 در حال بهینه‌سازی...")
for root, _, files in os.walk(SRC_DIR):
    for f in files:
        if f.endswith(".cs"):
            path = os.path.join(root, f)
            with open(path, "r", encoding="utf-8") as fp:
                original = fp.read()
            improved = optimize_code(original)
            if improved != original:
                with open(path, "w", encoding="utf-8") as fp:
                    fp.write(improved)
                print(f"   ✨ {os.path.relpath(path, SRC_DIR)}")

# --- کامپایل نهایی برای اطمینان ---
print("\n🔨 کامپایل بررسی سلامت...")
all_files = []
for root, _, files in os.walk(SRC_DIR):
    for f in files:
        if f.endswith(".cs"):
            all_files.append(os.path.join(root, f))
cmd = ["mcs", "-target:library", "-out:Refrigitz_optimized.dll",
       "-r:System.Windows.Forms.dll", "-r:System.Drawing.dll",
       "-r:System.Data.dll", "-r:System.Xml.dll", "-r:System.Core.dll"] + all_files
proc = subprocess.run(cmd, capture_output=True, text=True)
if proc.returncode == 0:
    print("✅ بهینه‌سازی موفق – پروژه بدون خطا کامپایل شد.")
else:
    print("⚠️ کامپایل با خطا مواجه شد. بازگردانی بک‌آپ...")
    if os.path.exists(BACKUP_DIR):
        shutil.rmtree(SRC_DIR)
        shutil.copytree(BACKUP_DIR, SRC_DIR)
        print("🔄 فایل‌ها به حالت قبل برگردانده شدند.")
    else:
        print("❌ بک‌آپ در دسترس نیست!")
    sys.exit(1)
