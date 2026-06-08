// API endpoint برای پاکسازی پیشرفته کدهای C#
export default async function handler(req, res) {
  if (req.method !== 'POST') {
    return res.status(405).json({ error: 'Method not allowed. Use POST.' });
  }

  try {
    const { code, steps = ['trycatch', 'commented', 'image', 'whitespace'] } = req.body;
    if (!code || typeof code !== 'string') {
      return res.status(400).json({ error: 'Missing or invalid "code" field.' });
    }

    let cleaned = code;
    const appliedSteps = [];

    // 1. حذف بلاک‌های try-catch خالی
    if (steps.includes('trycatch')) {
      cleaned = removeEmptyTryCatch(cleaned);
      appliedSteps.push('trycatch');
    }

    // 2. حذف خطوط کامنت‌شده که شبیه کد هستند (نه توضیحات معمولی)
    if (steps.includes('commented')) {
      cleaned = removeCommentedOutCode(cleaned);
      appliedSteps.push('commented');
    }

    // 3. تبدیل ارجاعات تصویری به دو کاراکتر (##)
    if (steps.includes('image')) {
      cleaned = convertImageReferences(cleaned);
      appliedSteps.push('image');
    }

    // 4. پاکسازی فضای خالی اضافی (خطوط خالی تکراری، فضای ابتدا/انتها)
    if (steps.includes('whitespace')) {
      cleaned = cleanWhitespace(cleaned);
      appliedSteps.push('whitespace');
    }

    return res.status(200).json({
      success: true,
      originalLength: code.length,
      cleanedLength: cleaned.length,
      cleanedCode: cleaned,
      appliedSteps,
      message: 'Code cleaned successfully.'
    });
  } catch (err) {
    console.error('Error:', err);
    return res.status(500).json({ error: 'Internal server error', details: err.message });
  }
}

// ========== توابع کمکی ==========

function removeEmptyTryCatch(code) {
  // الگو: try { ... } catch (...) { (whitespace|comments)* }
  const pattern = /try\s*\{([^{}]|\{(?:[^{}]|\{[^{}]*\})*\})*?\}\s*catch\s*(?:\([^)]*\))?\s*\{\s*(?:\/\/[^\n]*)?\s*\}/gs;
  let result = code;
  let previous;
  do {
    previous = result;
    result = result.replace(pattern, (match, tryContent) => {
      let inner = tryContent.trim();
      return inner.length === 0 ? '' : inner;
    });
  } while (result !== previous);
  return result;
}

function removeCommentedOutCode(code) {
  // خطوطی که با // شروع می‌شوند (بعد از whitespace) و حاوی کد واقعی هستند.
  // کد واقعی یعنی شامل حداقل یک کاراکتر از مجموعه: ; = { } ( ) [ ] + - * / % ! & | < > , . ? : 
  // و همچنین کلمات کلیدی رایج مانند if, for, while, var, int, string, return, new, etc.
  const lines = code.split(/\r?\n/);
  const filtered = lines.filter(line => {
    const trimmed = line.trim();
    if (!trimmed.startsWith('//')) return true; // خط کامنت نیست

    // بررسی محتوای داخل کامنت
    const content = trimmed.slice(2).trim();
    if (content.length === 0) return false; // کامنت خالی را حذف کن

    // الگوی تشخیص کد (وجود سمبل‌های برنامه‌نویسی یا کلمات کلیدی)
    const codePattern = /[;=(){}\[\]<>+*/%!&|?:,.]|^(if|for|while|var|int|string|bool|double|float|char|byte|long|short|uint|ulong|ushort|decimal|object|dynamic|new|return|throw|break|continue|goto|try|catch|finally|using|namespace|class|struct|interface|enum|delegate|event|public|private|protected|internal|static|readonly|const|virtual|override|abstract|sealed|partial|async|await)\b/;
    if (codePattern.test(content)) {
      return false; // این خط شبیه کد است → حذف شود
    }
    return true; // کامنت معمولی (توضیح) را نگه دار
  });
  return filtered.join('\n');
}

function convertImageReferences(code) {
  // 1. رشته‌های حاوی پسوندهای تصویری: "something.jpg", 'image.png' و ...
  const imageExtPattern = /(["'])([^"']*?\.(jpg|jpeg|png|gif|bmp|ico|svg|webp))\1/gi;
  let result = code.replace(imageExtPattern, '##');

  // 2. نمونه‌سازی از کلاس‌های تصویری (مانند new BitmapImage(), Image.FromFile, etc.)
  const imageClassPattern = /\bnew\s+(BitmapImage|Bitmap|Image|Drawing\.Image|System\.Drawing\.Image|WriteableBitmap)\s*\([^)]*\)/gi;
  result = result.replace(imageClassPattern, '##');

  // 3. متدهای مرتبط با تصویر (LoadImage, GetImage, etc.) - نام تابع شامل Image
  const imageMethodPattern = /\b(?:Load|Get|Save|Read|Write|Create)(?:Image|Picture|Bitmap)\s*\([^)]*\)/gi;
  result = result.replace(imageMethodPattern, '##');

  // 4. ارجاع به آدرس فایل تصویری در کد (بدون کوتیشن)
  const imagePathPattern = /[a-zA-Z0-9_/\\-]+\.(jpg|jpeg|png|gif|bmp)(?=\s|;|\)|,)/gi;
  result = result.replace(imagePathPattern, '##');

  return result;
}

function cleanWhitespace(code) {
  // حذف فضاهای خالی انتهای خطوط
  let result = code.replace(/[ \t]+$/gm, '');
  // تبدیل چندین خط خالی پشت‌سر هم به حداکثر دو خط خالی
  result = result.replace(/\n\s*\n\s*\n/g, '\n\n');
  // حذف خط خالی ابتدای فایل
  result = result.replace(/^\s*\n/, '');
  // حذف خط خالی انتهای فایل
  result = result.replace(/\n\s*$/, '\n');
  return result;
}
