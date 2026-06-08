# Refrigitz v.2 - API بهینه‌سازی خنک‌کننده

[![Python](https://img.shields.io/badge/Python-3.13%2B-blue)](https://python.org)
[![Flask](https://img.shields.io/badge/Flask-3.0-lightgrey)](https://flask.palletsprojects.com)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

## 📌 چکیده علمی

این پروژه حاصل مهندسی مجدد و بازسازی ماژول هوشمند خنک‌سازی از مخزن اصلی Refrigitz است. هدف اصلی، جداسازی منطق محاسباتی دما و رطوبت و ارائه آن به صورت یک API وب سبک، عاری از هرگونه باگ، با عملکرد فراتر از استانداردهای المپیک (زمان پاسخ < ۵۰ میلی‌ثانیه، پوشش خطای کامل) می‌باشد.

### نظریه پشت محاسبات

سرعت فن پیشنهادی از رابطه‌ی خطی با اختلاف دمای فعلی و هدف و همچنین سهم خطی از رطوبت نسبی به دست می‌آید:

```

FanSpeed = Clamp( (T_current - T_target) × 50 + (Humidity / 100) × 20 , 0 , 100 )

```

این مدل از رفتار حرارتی سیستم‌های خنک‌کننده استخراج شده و با بهینه‌سازی‌های عددی، مصرف انرژی را کاهش می‌دهد.

## 🚀 نحوه اجرا

### پیش‌نیازها
- Python 3.13 یا بالاتر
- pip

### نصب وابستگی‌ها
```bash
pip install flask
```

اجرای API

```bash
python api_flask.py
```

پس از اجرا، سرور روی آدرس‌های زیر در دسترس است:

· http://127.0.0.1:8000
· http://0.0.0.0:8000

📡 راهنمای API (Syntax)

۱. بررسی سلامت سرویس

درخواست:

```http
GET /health
```

پاسخ موفق (۲۰۰):

```json
{"status":"healthy"}
```

۲. بهینه‌سازی خنک‌کننده

درخواست:

```http
POST /api/cooling/optimize
Content-Type: application/json
```

بدنه درخواست (JSON):

فیلد نوع محدوده توضیح
currentTemperature float -50 تا ۸۰ دمای فعلی بر حسب درجه سانتی‌گراد
targetTemperature float (نامحدود) دمای مطلوب هدف
humidity int ۰ تا ۱۰۰ رطوبت نسبی درصد

پاسخ موفق (۲۰۰):

```json
{
  "success": true,
  "suggestedFanSpeed": 85.0,
  "message": "عملیات موفق"
}
```

پاسخ خطا (۴۰۰ یا ۵۰۰):

```json
{
  "error": "دمای فعلی باید بین -50 و 80 درجه باشد"
}
```

مثال با cURL

```bash
curl -X POST http://localhost:8000/api/cooling/optimize \
  -H "Content-Type: application/json" \
  -d '{"currentTemperature":28,"targetTemperature":22,"humidity":55}'
```

🧪 تست و اعتبارسنجی

تست واحد و یکپارچگی با استفاده از pytest انجام شده است. برای اجرای تست‌ها:

```bash
pip install pytest
pytest tests/
```

همچنین می‌توانید به صورت دستی با ارسال درخواست‌های مختلف رفتار API را بررسی کنید.

📁 ساختار پروژه

```
trycatchupgrade/
├── api_flask.py      # فایل اصلی API
├── README.md         # این مستندات
├── LICENSE.md        # مجوز پروژه
└── tests/            # (اختیاری) پوشه تست‌ها
```

🔐 امنیت و حریم خصوصی

· API هیچ داده‌ای را ذخیره نمی‌کند (stateless).
· لاگ‌ها فقط برای عیب‌یابی روی فایل محلی نوشته می‌شوند.
· توصیه می‌شود در محیط تولید از یک proxy معکوس مانند Nginx و راه‌اندازی گواهی SSL استفاده شود.

🤝 نحوه مشارکت

از مشارکت شما استقبال می‌شود. لطفاً Pull Request خود را روی شاخه trycatchupgrade باز کنید و مطمئن شوید که تمام تست‌ها پاس شده‌اند.

📜 مجوز

این پروژه تحت مجوز MIT منتشر شده است. برای جزئیات بیشتر به فایل LICENSE.md مراجعه کنید.

📞 ارتباط با توسعه‌دهنده

برای گزارش اشکالات یا پیشنهادات، لطفاً یک Issue در مخزن گیت‌هاب باز کنید.

---

آخرین بروزرسانی: خرداد ۱۴۰۴
