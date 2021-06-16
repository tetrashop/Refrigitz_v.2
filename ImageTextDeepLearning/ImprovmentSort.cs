using ContourAnalysisNS;
using Point3Dspaceuser;
using System.Collections.Generic;
namespace ImageTextDeepLearning
{
    public static class ImprovmentSort
    {
        public static Point3D[] Do(Point3D[] a)
        {
            int n = 3;
            Point3D[] c = new Point3D[n];
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = -1;
            }

            return Sort(a, d, n);
        }
        public static double[] Do(double[] a)
        {
            int n = 3;
            Point3D[] c = new Point3D[n];
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = -1;
            }

            return Sort(a, d, n);
        }
        public static float[] Do(float[] a)
        {
            int n = 3;
            float[] c = new float[n];
            float[] d = new float[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = -1;
            }

            return Sort(a, d, n);
        }

        private static float[] Sort(float[] a, float[] d, int n)
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
                    {
                        continue;
                    }
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex] < a[i])
                        {
                            Lastindex = i;
                        }
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
            {
                d[i] = -1;
            }

            return Sort(a, d, n);
        }

        private static List<float> Sort(List<float> a, float[] d, int n)
        {
            List<float> c = new List<float>();
            for (int i = 0; i < n; i++)
            {
                c.Add(new float());
            }

            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                    {
                        continue;
                    }
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex] < a[i])
                        {
                            Lastindex = i;
                        }
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
        public static List<SameRikhEquvalent> Do(List<SameRikhEquvalent> a,ref List<bool[,]> GreaterThanOneCuurvvedMatrix)
        {
            int n = a.Count;
            float[] d = new float[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = -1;
            }

            return Sort(a, d, n,ref GreaterThanOneCuurvvedMatrix);
        }

        private static List<SameRikhEquvalent> Sort(List<SameRikhEquvalent> a, float[] d, int n, ref List<bool[,]> GreaterThanOneCuurvvedMatrix)
        {
            List<SameRikhEquvalent> c = new List<SameRikhEquvalent>();
            List<bool[,]> cGreaterThanOneCuurvvedMatrix = new List<bool[,]>();
            for (int i = 0; i < a.Count; i++)
            {
                cGreaterThanOneCuurvvedMatrix.Add(new bool[a[i].N, a[i].M]);
            }

            for (int i = 0; i < n; i++)
            {
                c.Add(a[i]);
            }

            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                    {
                        continue;
                    }
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex].Angle < a[i].Angle)
                        {
                            Lastindex = i;
                        }
                    }
                }
                if ((Lastindex != -1) & (H <= n))
                {
                    d[Lastindex] = Lastindex;
                    c[n - 1 - H] = a[Lastindex];
                    cGreaterThanOneCuurvvedMatrix[n - 1 - H] = GreaterThanOneCuurvvedMatrix[Lastindex];
                    H++;
                }
            }
            GreaterThanOneCuurvvedMatrix = cGreaterThanOneCuurvvedMatrix;
            return c;
        }

        private static Point3D[] Sort(Point3D[] a, double[] d, int n)
        {
            Point3D[] c = new Point3D[n];
            int H = 0;
            while (H < n)
            {
                int Lastindex = -1;
                bool FirstIndex = false;
                for (int i = 0; i < n; i++)
                {
                    if ((i == d[i]))
                    {
                        continue;
                    }
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex].X < a[i].X)
                        {
                            Lastindex = i;
                        }
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

        private static double[] Sort(double[] a, double[] d, int n)
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
                    {
                        continue;
                    }
                    else
                    {
                        if (!FirstIndex)
                        {
                            Lastindex = i;
                            FirstIndex = true;
                        }
                        if (a[Lastindex] < a[i])
                        {
                            Lastindex = i;
                        }
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
