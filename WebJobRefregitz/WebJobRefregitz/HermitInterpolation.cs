using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningMachine
{
    class HermitInterpolation
    {
        static Double[] SimplifyLxi(Double[] s, Double[] x, int p, int j,int i)
        {
            if (j == p)
                return s;
            if(s.Length>2)
            if (j != i)
            {
                for (int k = p - 1; k >= 0; k--)
                    s[k + 1] = s[k];
                s[0] = 0;
                for (int k = 1; k < s.Length; k++)
                    s[k - 1] = s[k - 1] - s[k] * x[j + 1];
            }
            s = SimplifyLxi(s, x, p, j + 1, i);
            return s;
        }
        static Double[] Derivate(Double[] za, int n)
        {
            Double[] sz = new Double[n - 1];
            for (int i = (n - 1); i > 0; i--)
                sz[i - 1] = za[i] * (i);
            return sz;
        }
        private static Double[] pxLxi(Double[] s, Double[] x, int n, int i)
        {
            Double ss = 1;
            for (int j = 0; j < n; j++)
                if (j != i)
                    ss = ss * (x[i] - x[j]);
            Double[] sas = new Double[n];
            if(i==0)
                sas[0] = -1 * x[1];
            else
                sas[0] = -1 * x[0];
            sas[1] = 1;
            Double[] aa = SimplifyLxi(sas, x, n-1, 1, i );
            for (int a = 0; a < n; a++)
                aa[a] = aa[a] / ss;
            return aa;        
        }
        static Double[] pxuxi(Double[] x, Double[] f, int n, int i)
        {
            Double[] uxi = new Double[2 * n + n];
            Double[] result = new Double[2 * n + n];
            Double[] firstpar = new Double[2];
            firstpar[0] = 2 * x[i];
            firstpar[1] = -2;
            Double[] Lxi = pxLxi(f, x, n, i);
            Double[] Lxi2 = new Double[2 * n];
            Double[] lprinlxi = Derivate(Lxi, n);

            for (int r = 0; r < n - 1; r++)
                uxi[r] = firstpar[0] * lprinlxi[r];
            for (int r = 0; r < n - 1; r++)
                uxi[r + 1] = uxi[r + 1] + firstpar[1] * lprinlxi[r];
            uxi[0] = uxi[0] + 1;
            for (int r = 0; r < n; r++)
                for (int w = 0; w < n; w++)
                    Lxi2[r + w] = Lxi2[r + w] + Lxi[r] * Lxi[w];
            for (int r = 0; r < n; r++)
                for (int w = 0; w < 2 * n; w++)
                    result[r + w] = result[r + w] + uxi[r] * Lxi2[w];

            return result;

        }
        static Double[] pxvxi(Double[] x, Double[] f, int n, int i)
        {
            Double[] result = new Double[2 * n + n];
            Double[] vxi = new Double[2 * n + n];
            Double[] firstpar = new Double[2];
            vxi[0] = (-1) * x[i];
            vxi[1] = 1;
            Double[] Lxi = pxLxi(f, x, n, i);
            Double[] Lxi2 = new Double[2 * n];
            Double[] lprinlxi = Derivate(Lxi, n);

               for (int r = 0; r < n; r++)
                for (int w = 0; w <  n; w++)
                    Lxi2[r + w] = Lxi2[r + w] + Lxi[r] * Lxi[w];
            for (int r = 0; r <  n; r++)
                for (int w = 0; w <  2*n; w++)
                    result[r + w] = result[r + w] + vxi[r] * Lxi2[w];
            return result;

        }
        static Double[] fperinvalue(Double[] x, Double[] f, int n)
        {
            Double[] fperin = new Double[n];
            for (int i = 0; i < n / 2; i++)
                for (int J = 0; J < n / 2; J++)
                    fperin[i] = fperin[i] + System.Math.Pow(-1, J) * ((1) / (J + 1)) * deltaiForward(x, f, J + 1);
               for (int i = n / 2 + 1; i < n; i++)
                   for (int J = n / 2 + 1; J < n; J++)
                       fperin[i] = fperin[i] + System.Math.Pow(-1, J - n / 2 - 1) * ((1) / (J + 1 - n / 2 - 1)) * deltaibackward(x, f, J - n / 2 );
               return fperin;
        }
        public static Double[] pxHermit(Double[] x, Double[] f, int n)
        {
            Double[] fperin = fperinvalue(x, f, n);
            Double[] Result = new Double[2 * n + n];
              Double[] Dummy = new Double[2 * n + n];
            Double[,] uxi2 = new Double[n, 2*n+n];
            Double[,] vxi2 = new Double[n, 2*n+n];
            for (int i = 0; i < n; i++)
            {
                Dummy = pxuxi(x, f, n, i);
                for (int G = 0; G < 2 * n + n; G++)
                    uxi2[i,G] = Dummy[G];
                Dummy = pxvxi(x, f, n, i);
                for (int G = 0; G < 2 * n + n; G++)
                    vxi2[i,G] = Dummy[G];


            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < 2 * n + n; j++)
                    Result[j] = Result[j] + uxi2[i, j] * f[i] + vxi2[i, j] * fperin[i];
            return Result;
        }
        static Double deltaiForward(Double[] x, Double[] f,int index)
        {
            Double ad = 0;
            for (int j = 0; j <index; j++)
                ad = ad + System.Math.Pow(-1, j) * Combinition(index,j) * f[index  - j];
            return ad;
        }
        static Double deltaibackward(Double[] x, Double[] f,int index)
        {
            Double ad = 0;
            for (int j = 0; j < index; j++)
                ad = ad + System.Math.Pow(-1, j) * Combinition(index,j) * f[index - j];
            return ad;
        }
        static int factorial(int n)
        {
        if(n==1||n==0)
            return 1;
            return n*factorial(n-1);
        
        }
            private static int Combinition(int nb,int kb)
                    {
            if (nb == kb)
                return 1;
            return (factorial(nb))/(factorial(kb)*factorial(nb-kb));        
        }
    }
}
