# 🧹 TryCatch Remover API - Professional Code Cleaner for C#

این API یک ابزار قدرتمند برای تمیزکاری خودکار کدهای C# است. قابلیت‌ها:

- **حذف بلاک‌های try-catch خالی** (بدون بدنه یا فقط کامنت)
- **حذف خطوط کامنت‌شده حاوی کد واقعی** (نه توضیحات)
- **تبدیل ارجاعات تصویری به دو کاراکتر `##`** (مسیرها، کلاس‌های Image، متدهای مرتبط)
- **پاکسازی فاصله‌ها و خطوط خالی تکراری**

## 📡 نحوه استفاده

**نقطه پایانی:** `POST /api/clean`

**بدنه (JSON):**
```json
{
  "code": "کد C# شما",
  "steps": ["trycatch", "commented", "image", "whitespace"]  // اختیاری
}
```

پاسخ موفق (200):

```json
{
  "success": true,
  "originalLength": 1234,
  "cleanedLength": 1000,
  "cleanedCode": "...",
  "appliedSteps": ["trycatch", "commented", ...],
  "message": "..."
}
```

🧪 مثال با cURL

```bash
curl -X POST https://your-app.vercel.app/api/clean \
  -H "Content-Type: application/json" \
  -d '{
    "code": "try { int x = 5; } catch { }\n// int y = 10;\nImage.FromFile(\"logo.png\");",
    "steps": ["trycatch", "commented", "image"]
  }'
```

خروجی:

```json
{
  "success": true,
  "cleanedCode": " int x = 5; \n##",
  "appliedSteps": ["trycatch","commented","image"]
}
```

🚀 استقرار روی Vercel

```bash
npm install -g vercel
vercel --prod
```

📜 مجوز

MIT
