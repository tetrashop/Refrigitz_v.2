using Point3Dspaceuser;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace howto_WPF_3D_triangle_normalsuser
{
    public static class ImprovmentSort
    {
        public static Point3Dspaceuser.Point3D[] Do(Point3Dspaceuser.Point3D[] a)
        {
            int n = 3;
            Point3Dspaceuser.Point3D[] c = new Point3Dspaceuser.Point3D[n];
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
                d[i] = -1;
            return Sort(a, d, n);

        }
        public static System.Windows.Media.Media3D.Point3D[] Do(System.Windows.Media.Media3D.Point3D[] a)
        {
            int n = 3;
            System.Windows.Media.Media3D.Point3D[] c = new System.Windows.Media.Media3D.Point3D[n];
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
                d[i] = -1;
            return Sort(a, d, n);

        }
        public static double[] Do(double[] a)
        {
            int n = 3;
            Point3D[] c = new Point3D[n];
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
                d[i] = -1;
            return Sort(a, d, n);

        }
        public static float[] Do(float[] a)
        {
            int n = 3;
            float[] c = new float[n];
            float[] d = new float[n];
            for (int i = 0; i < n; i++)
                d[i] = -1;
            return Sort(a, d, n);

        }
        static float[] Sort(float[] a, float[] d, int n)
        {
            float[] c = new float[n];
            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                        continue;
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex] < a[i])
                            Lastindex = i;
                    }
                }
                if ((Lastindex != -1) & (H <= n))
                {
                    d[Lastindex] = Lastindex;
                    c[n - 1 - H] = a[Lastindex];
                    H++;
                }
            }
            return c;
        }
        public static List<float> Do(List<float> a)
        {
            int n = a.Count;
            float[] d = new float[n];
            for (int i = 0; i < n; i++)
                d[i] = -1;
            return Sort(a, d, n);

        }
        static List<float> Sort(List<float> a, float[] d, int n)
        {
            List<float> c = new List<float>();
            for (int i = 0; i < n; i++)
                c.Add(new float());
            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                        continue;
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex] < a[i])
                            Lastindex = i;
                    }
                }
                if ((Lastindex != -1) & (H <= n))
                {
                    d[Lastindex] = Lastindex;
                    c[n - 1 - H] = a[Lastindex];
                    H++;
                }
            }
            return c;
        }
        static System.Windows.Media.Media3D.Point3D[] Sort(System.Windows.Media.Media3D.Point3D[] a, double[] d, int n)
        {
            System.Windows.Media.Media3D.Point3D[] c = new System.Windows.Media.Media3D.Point3D[n];
            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                        continue;
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex].X < a[i].X)
                            Lastindex = i;
                    }
                }
                if ((Lastindex != -1) & (H <= n))
                {
                    d[Lastindex] = Lastindex;
                    c[n - 1 - H] = a[Lastindex];
                    H++;
                }
            }
            return c;
        }
        static Point3Dspaceuser.Point3D[] Sort(Point3Dspaceuser.Point3D[] a, double[] d, int n)
        {
            Point3Dspaceuser.Point3D[] c = new Point3Dspaceuser.Point3D[n];
            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                        continue;
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex].X < a[i].X)
                            Lastindex = i;
                    }
                }
                if ((Lastindex != -1) & (H <= n))
                {
                    d[Lastindex] = Lastindex;
                    c[n - 1 - H] = a[Lastindex];
                    H++;
                }
            }
            return c;
        }
        static double[] Sort(double[] a, double[] d, int n)
        {
            double[] c = new double[n];
            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                        continue;
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex] < a[i])
                            Lastindex = i;
                    }
                }
                if ((Lastindex != -1) & (H <= n))
                {
                    d[Lastindex] = Lastindex;
                    c[n - 1 - H] = a[Lastindex];
                    H++;
                }
            }
            return c;
        }
    }
}