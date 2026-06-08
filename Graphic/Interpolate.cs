using System;

namespace LearningMachine
{
    public static class Interpolate
    {
        // حل دستگاه معادلات خطی ۳×۳ به روش حذفی گاوس
        public static double[] Quaficient(double[,] a, double[] b, int n)
        {
            double[] x = new double[n];
            double[,] aa = (double[,])a.Clone();
            double[] bb = (double[])b.Clone();

            // تبدیل به ماتریس بالا مثلثی
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    if (aa[k, k] == 0) continue; // pivot صفر (در عمل نباید رخ دهد)
                    double factor = aa[i, k] / aa[k, k];
                    for (int j = k; j < n; j++)
                        aa[i, j] -= factor * aa[k, j];
                    bb[i] -= factor * bb[k];
                }
            }

            // بازگشت به عقب (back substitution)
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                    sum += aa[i, j] * x[j];
                if (aa[i, i] != 0)
                    x[i] = (bb[i] - sum) / aa[i, i];
                else
                    x[i] = 0; // برای پرهیز از تقسیم بر صفر
            }
            return x;
        }
    }
}
