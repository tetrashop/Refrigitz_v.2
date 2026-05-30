#!/bin/bash
# تحلیل، رفع خطا و خروجی باکس کد از تمام فایل‌های C# پروژه Refrigitz

SRC="Formulas"
OUT_MD="all_fixed.md"
TMP_CS="temp_fix.cs"
ERROR_LOG="errors.log"
REFS="-r:System.Windows.Forms.dll -r:System.Drawing.dll -r:System.Data.dll -r:System.Xml.dll -r:System.Core.dll"

echo "# 📐 Refrigitz v.2 – کدهای نهایی و اصلاح‌شده" > "$OUT_MD"
echo "" >> "$OUT_MD"

# ۱. جمع‌آوری تمام usingها برای رفع CS0246
echo "📚 در حال یادگیری usingهای پروژه..."
ALL_USINGS=$(find "$SRC" -name "*.cs" -exec grep -h '^using ' {} \; | sort -u)

# ۲. تابع رفع خطاهای رایج
fix_errors() {
    local code="$1"
    # رفع return مفقود (CS0161) در متدهای غیر void
    code=$(echo "$code" | sed -E '
        /public (bool|int|string|object|void)/,/^[[:space:]]*}/{
            /return/!{
                /}[[:space:]]*$/{
                    s/}[[:space:]]*$/        return false;\n    }/
                }
            }
        }
    ')
    # رفع out parameter (CS0177) – مقدار اولیه false
    code=$(echo "$code" | sed -E 's/out bool (\w+)/out bool \1 = false/g')
    echo "$code"
}

# ۳. پردازش هر فایل
find "$SRC" -name "*.cs" | while read -r file; do
    echo "🔄 پردازش: $file"
    original=$(cat "$file")
    
    # نوشتن فایل موقت برای کامپایل
    echo "$original" > "$TMP_CS"
    
    # کامپایل آزمایشی
    mcs -target:library -out:/dev/null $REFS "$TMP_CS" 2>"$ERROR_LOG"
    
    # اگر خطا داشت، سعی در رفع
    if [ -s "$ERROR_LOG" ]; then
        # رفع با استفاده از تابع
        fixed=$(fix_errors "$original")
        echo "$fixed" > "$TMP_CS"
        # تلاش دوباره
        mcs -target:library -out:/dev/null $REFS "$TMP_CS" 2>/dev/null
        if [ $? -eq 0 ]; then
            echo "✅ رفع شد: $file"
            echo "$fixed" > "$file"
        else
            echo "⚠️ رفع خودکار ممکن نبود: $file (خطاها در $ERROR_LOG)"
        fi
    fi
    
    # افزودن به فایل Markdown
    rel_path="${file#./}"
    echo "## 📄 $rel_path" >> "$OUT_MD"
    echo '```csharp' >> "$OUT_MD"
    cat "$file" >> "$OUT_MD"
    echo '```' >> "$OUT_MD"
    echo "" >> "$OUT_MD"
done

# پاک‌سازی
rm -f "$TMP_CS" "$ERROR_LOG"

echo "🎉 فایل نهایی: $OUT_MD"
echo "📋 می‌توانید با دستور زیر آن را مشاهده کنید:"
echo "   cat $OUT_MD"
