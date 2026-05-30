#!/usr/bin/env python3
import os, sys

INPUT_FILE = "all_code.txt"               # فایل اصلی بزرگ
OUTPUT_DIR = os.path.expanduser("~/storage/shared/Download")  # دانلود در Termux
MAX_SIZE = 400_000                        # 400 کیلوبایت (به بایت)

# اگر پوشه مقصد وجود نداشت، در خانه ایجاد کن
if not os.path.isdir(OUTPUT_DIR):
    OUTPUT_DIR = os.path.expanduser("~/downloads")
    os.makedirs(OUTPUT_DIR, exist_ok=True)

if not os.path.exists(INPUT_FILE):
    print(f"❌ فایل {INPUT_FILE} یافت نشد. ابتدا آن را بسازید.")
    sys.exit(1)

# خواندن تمام خطوط فایل
with open(INPUT_FILE, "r", encoding="utf-8") as f:
    lines = f.readlines()

part_num = 1
current_lines = []
current_size = 0

def write_part(part_lines, num):
    """ذخیره قطعه در پوشه دانلود"""
    name = f"Refrigitz_part_{num}.txt"
    path = os.path.join(OUTPUT_DIR, name)
    with open(path, "w", encoding="utf-8") as pf:
        pf.writelines(part_lines)
    return path, len(part_lines)

for line in lines:
    line_size = len(line.encode("utf-8"))  # اندازه واقعی خط (برای UTF-8)
    
    # اگر این خط شروع یک فایل جدید است
    if line.startswith("// ===== "):
        # اگر با اضافه شدن این فایل جدید حجم از حد مجاز می‌گذرد، قطعه فعلی را ببند
        if current_size + line_size > MAX_SIZE and current_lines:
            path, cnt = write_part(current_lines, part_num)
            print(f"✅ {path} ({cnt} خطوط)")
            part_num += 1
            current_lines = []
            current_size = 0

    current_lines.append(line)
    current_size += line_size

# ذخیره آخرین قطعه
if current_lines:
    path, cnt = write_part(current_lines, part_num)
    print(f"✅ {path} ({cnt} خطوط)")

print(f"\n🎉 تمام! {part_num} قطعه در پوشه دانلود قرار گرفت.")
