/******************************
 * Ramin Edjlal CopyRigth 2015
 * Newotoon Interpolate 
 * Implementation recursivley.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningMachine
{
    class NewotoonInterpolate
    {
        private static Double fx0untinxn(Double[] x, Double[] f, int n, int i, int j)
        {
            if ((i == j - 1) || (i + 1 == j))
                return (f[i] - f[j]) / (x[i] - x[j]);
            Double f1 = fx0untinxn(x, f, n, i, j-1);
            Double f2 = fx0untinxn(x, f, n, i + 1, j);
            return (f1 - f2) / (x[i] - x[j]);
        }

        public static Double[] px(Double[] x, Double[] f, int n)
        {
            /*Double s = f[0];
            for (int i = 1; i < n; i++)
            {
                Double d = 1;
                for (int j = 0; j < i; j++)
                    d = d * (x0 - x[j]);
                d = d * fx0untinxn(x, f, i, 0, i);
                s = s + d;
            }
            return s;
             */
            Double[] s = new Double[n];
             
            s[0] = f[0];

            for (int i = 1; i < n; i++)
            {
                Double d = 1;
                Double[] p = new Double[i + 1];
                p[0] = (-1) * x[0];
                p[1] = 1;
                p = Simplify(p, x, i, 1);
                Double jj = fx0untinxn(x, f, i, 0, i);
                for (int j = 0; j <= i; j++)
                {
                    p[j] = p[j] * jj;
                    s[j] = p[j] + s[j];
                    p[j] = 0;
                }             
            }
            return s;
        }
        static Double[] Simplify(Double[] s, Double[] x, int i, int j)
        {
        if(j==i)
            return s;
        for (int k = i-1; k >= 0; k--)
            s[k + 1] = s[k];
       
         s[0] = 0;

         for (int k = 1; k < s.Length; k++)
             s[k - 1] = s[k - 1] - s[k] * x[j];

       s=Simplify(s, x, i, j + 1);
       return s;       
        
        }
        /*public static bool test(Double[] x, Double[] f, int n,Double x0)
        {

            if (((0.5) * System.Math.Pow(x0, 3) - (7 / 2) * System.Math.Pow(x0, 2) + 9 * x0 - 2) == (px(x, f, n, x0)))
                return true;
            return false;
        }
         */
    }
}