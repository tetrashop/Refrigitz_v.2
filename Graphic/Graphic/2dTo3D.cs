/*tetrashop.ir 1399/11/24 iran urmia
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public class _2dTo3D

    {
        byte[,,] geta = null;
        public int width = 0,height = 0;
        public double x = 0;
        int cxC = -1, cyC = -1, czC = -1;
        public List<List<double[]>> st = new List<List<double[]>>();
        public bool _3DReady = false;
        Image a;
        public Image ar;
        //size
        int[] b = new int[3];
        int[,,] t;// zeros(b(1,1),b(1,2),3);
        int[,,] rr;// rr=zeros(b(1,1),b(1,2),3);
        int[,,] f;//     f=zeros(b(1,1),b(1,2),3);
        int[,,] ddr;//     f=zeros(b(1,1),b(1,2),3);
        public float[,,] c;
        public int cx = 0, cyp0 = 0, cyp1 = 0, cz = 3;
        public float[,,] e;
        int fg = 2;
        public int minr = int.MaxValue;
        int minteta = int.MaxValue;
        int minfi = int.MaxValue;
        public int maxr = int.MinValue;
        int maxteta = int.MinValue;
        int maxfi = int.MinValue;
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a as Bitmap)
                {
                    string stackTrace = ex.ToString();
                    //Write to File.
                   File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString());
                }
            }

            catch (Exception t) { }

        }
        double[] cart2sph(float i, float j, float k)
        {
            double[] s = new double[3];
            s[2] = Math.Sqrt(i * i + j * j + k * k);
            if (s[2] == 0.0)
            {
                s[0] = 0.0;
                s[1] = 0.0;
            }
            else
            {
                s[0] = Math.Acos((double)k / s[2]);
                s[1] = Math.Atan2((double)j, (double)i);
            }
            return s;
        }
        bool SetneighboursSt(Image a, double cxr, double cyr, double i, double j, double maxx, double maxy)
        {
            bool aa = false;

            lock (st)
            {
                lock (a as Bitmap)
                {
                    try
                    {
                        if (cxr > 0 && cyr > 0)
                        {
                            if (i >= 0 && j >= 0)
                            {
                                if (i < width && j < height)
                                {
                                    if (cxr < maxx - 1 && cyr < maxy - 1)
                                    {

                                        aa = System.Convert.ToSingle(GetK(a, (int)i, (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 2)) > 0;

                                        if (System.Convert.ToSingle(GetK(a, (int)i, (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 2)) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][0] = cxr;
                                            st[(int)cxr][(int)cyr][1] = cyr;
                                            st[(int)cxr][(int)cyr][2] = (System.Convert.ToSingle(GetK(a, (int)i, (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][3] = cxr - 1;
                                            st[(int)cxr][(int)cyr][4] = cyr;
                                            st[(int)cxr][(int)cyr][5] = (System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)j, 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][6] = cxr + 1;
                                            st[(int)cxr][(int)cyr][7] = cyr;
                                            st[(int)cxr][(int)cyr][8] = (System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)j, 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i), (int)(j - 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j - 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j - 1), 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][9] = cxr;
                                            st[(int)cxr][(int)cyr][10] = (cyr - 1);
                                            st[(int)cxr][(int)cyr][11] = (System.Convert.ToSingle(GetK(a, (int)(i), (int)(j - 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j - 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j - 1), 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j + 1), 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][12] = cxr;
                                            st[(int)cxr][(int)cyr][13] = (cyr + 1);
                                            st[(int)cxr][(int)cyr][14] = (System.Convert.ToSingle(GetK(a, (int)(i), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i), (int)(j + 1), 2))) / 3.0;
                                        }
                                        if (System.Convert.ToSingle(GetK(a, (int)i, (int)(int)j, 0)) + System.Convert.ToSingle(GetK(a, (int)i, (int)(int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)i, (int)(int)j, 2)) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][15] = cxr - 1;
                                            st[(int)cxr][(int)cyr][16] = (cyr - 1);
                                            st[(int)cxr][(int)cyr][17] = (System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j - 1), 0)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 1)) + System.Convert.ToSingle(GetK(a, (int)i, (int)j, 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][18] = cxr - 1;
                                            st[(int)cxr][(int)cyr][19] = (cyr + 1);
                                            st[(int)cxr][(int)cyr][20] = (System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i - 1), (int)(j + 1), 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][21] = cxr + 1;
                                            st[(int)cxr][(int)cyr][22] = (cyr - 1);
                                            st[(int)cxr][(int)cyr][23] = (System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j - 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j - 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j - 1), 2))) / 3.0;
                                        }
                                        if ((System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j + 1), 2))) > 0)
                                        {
                                            st[(int)cxr][(int)cyr][24] = cxr + 1;
                                            st[(int)cxr][(int)cyr][25] = (cyr + 1);
                                            st[(int)cxr][(int)cyr][26] = (System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j + 1), 0)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j + 1), 1)) + System.Convert.ToSingle(GetK(a, (int)(i + 1), (int)(j + 1), 2))) / 3.0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception t) {  Log(t); MessageBox.Show(t.ToString()); }
                    return aa;
                }
            }

        }
        void Threaadcal(int i, int j, int k, int ii, int jj)
        {
            try
            {
                lock (c)
                {
                    if ((float)(System.Convert.ToSingle(GetK(a, i, j, k))) == 0)
                        return;
                    float dr = 0;
                    double[] s = new double[3];
                    //[teta, fi, r] = cart2sph(i, j, 0);
                    s = cart2sph(i, j, 1);
                    t[i, j, k] = (int)Math.Round((double)(s[0] * 180.0 / 3.1415));
                    f[i, j, k] = (int)Math.Round((double)(s[1] * 180.0 / 3.1415));
                    rr[i, j, k] = (int)Math.Round((double)(s[2]));
                    dr = (float)Math.Round(maxr * ((1.0 * ((double)(i + 1))) / (1 + Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)))) * 3.0 * 300.0 / (1.0 + System.Convert.ToSingle(GetK(a, i, j, 0)) + System.Convert.ToSingle(GetK(a, i, j, 1)) + System.Convert.ToSingle(GetK(a, i, j, 2)))); ;
                    ddr[i, j, k] = (int)dr;

                    try
                    {
                        int cxT = (maxr - minr) * ii + (int)dr;
                        int cyT1 = (int)Math.Round((double)((maxteta - minteta) * (double)jj + (double)t[i, j, k] + 2.0));
                        int cyT2 = (int)Math.Round((double)((maxteta - minteta) * (double)jj + (double)t[i, j, k] - 2.0));

                        if (cxT >= 0 && cyT1 >= 0 && cyT2 >= 0 && cxT < cx && cyT1 < cyp1 && cyT2 < cyp1// && (t[i, j, k + 1] + 2 < maxteta - minteta) && (t[i, j, k + 1] - 2 > minteta)
                       )
                        {
                            if ((ii + jj) % 2 == 0)
                            {
                                c[cxT, cyT1, k] = (float)(System.Convert.ToSingle(GetK(a, i, j, k)));
                                //SetneighboursSt(a, cxT, cyT1, cxC, cyC);
                            }
                            else
                            {
                                c[cxT, cyT2, k] = (float)(System.Convert.ToSingle(GetK(a, i, j, k)));
                                //SetneighboursSt(a, cxT, cyT2, cxC, cyC);
                            }
                        }
                    }
                    catch (Exception t)
                    {

                    }
                }
            
            }
            catch (Exception t) {  Log(t); MessageBox.Show(t.ToString()); }
        }
        void ThreaadcalNeighbour(int i, int j, int k, int ii, int jj)
        {
            try
            {
                lock (c)
                {
                    if ((float)(System.Convert.ToSingle(GetK(a, i, j, k))) == 0)
                        return;
                    float dr = 0;
                    double[] s = new double[3];
                    //[teta, fi, r] = cart2sph(i, j, 0);
                    s = cart2sph(i, j, 1);
                    t[i, j, k] = (int)Math.Round((double)(s[0] * 180.0 / 3.1415));
                    f[i, j, k] = (int)Math.Round((double)(s[1] * 180.0 / 3.1415));
                    rr[i, j, k] = (int)Math.Round((double)(s[2]));
                    dr = (float)Math.Round(maxr * ((1.0 * ((double)(i + 1))) / (1 + Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)))) * 3.0 * 300.0 / (1.0 + System.Convert.ToSingle(GetK(a, i, j, 0)) + System.Convert.ToSingle(GetK(a, i, j, 1)) + System.Convert.ToSingle(GetK(a, i, j, 2)))); ;
                    ddr[i, j, k] = (int)dr;
                    
                        try
                        {
                            int cxT = (maxr - minr) * ii + (int)dr;
                            int cyT1 = (int)Math.Round((double)((maxteta - minteta) * (double)jj + (double)t[i, j, k] + 2.0));
                            int cyT2 = (int)Math.Round((double)((maxteta - minteta) * (double)jj + (double)t[i, j, k] - 2.0));
                        if ((maxr - minr) * ii + dr >= 0// && (t[i, j, k + 1] + 2 < maxteta - minteta) && (t[i, j, k + 1] - 2 > minteta)
                        )
                        {
                            if ((ii + jj) % 2 == 0)
                            {
                                SetneighboursSt(a, cxT, cyT1, i, j, cx, cyp0);
                            }
                            else
                            {
                                SetneighboursSt(a, cxT, cyT2, i, j, cx, cyp1);
                            }
                        }
                        }
                        catch (Exception t)
                        {

                        }
                    }
                
            }
            catch (Exception t) {  Log(t); MessageBox.Show(t.ToString()); }
        }
        void Threaadfetch(int i, int j, int k, int ii, int jj)
        {
            lock (e)
            {
                lock (c)
                {
                    try
                    {
                        if ((int)(ii * (maxr - minr) + ddr[i, j, k]) < 0 || (int)(jj * (maxteta - minteta) + t[i, j, k] + 2) < 0)
                            return;
                        if ((int)(ii * (maxr - minr) + ddr[i, j, k]) >= cx || (int)(jj * (maxteta - minteta) + t[i, j, k] + 2) >= cyp1)
                            return;
                        if (c[(int)(ii * (maxr - minr) + ddr[i, j, k]), (int)(jj * (maxteta - minteta) + t[i, j, k] + 2), k] == 0)
                            return;
                        if ((ii + jj) % 2 == 0)
                            e[(int)(ii * b[0] + i), (int)(j), k] = c[(int)(ii * (maxr - minr) + ddr[i, j, k]), (int)(jj * (maxteta - minteta) + t[i, j, k] + 2), k];
                        else
                            e[(int)(ii * b[0] + i), (int)(j), k] = c[(int)(ii * (maxr - minr) + ddr[i, j, k]), (int)(jj * (maxteta - minteta) + t[i, j, k] - 2), k];
                    }
                    catch (Exception t)
                    {
                         Log(t); MessageBox.Show(t.ToString());
                    }
                }
            }
        }
        void Threaaddraw(int i, int j, ref Graphics g, ref Image ar)
        {
            try
            {
                lock (e)
                {
                    lock (ar as Bitmap)
                    {
                        lock (g)
                        {

                            (ar as Bitmap).SetPixel(i, j, Color.FromArgb((int)(e[i, j, 0]), (int)(e[i, j, 1]), (int)(e[i, j, 2])));
                            g.DrawImage(ar, 0, 0, (ar as Bitmap).Width, (ar as Bitmap).Height);
                            g.Save();

                        }
                    }
                }
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        void ContoObject()
        {
            try
            {
                int r = 0;
                int teta = 0;
                int fi = 0;
                cx = (int)((maxr - minr) * fg + (int)maxr + 1);

                cyp0 = (int)Math.Round((double)(maxteta - minteta) + (double)maxteta + 1.0);
                cyp1 = (int)Math.Round((double)(maxteta - minteta) * (double)2 + (double)maxteta + 1.0);
                //cy = (int)Math.Round((double)(maxteta - minteta) * (double)fg + (double)maxteta + 1.0);
                cxC = (int)((maxr - minr) * fg + (int)maxr + 1);
                cyC = (int)Math.Round((double)(maxteta - minteta) * (double)fg + (double)maxteta + 1.0);
                czC = 3;
                for (int i = 0; i < cxC; i++)
                {
                    st.Add(new List<double[]>());
                    for (int j = 0; j < cyC; j++)
                    {
                        st[i].Add(new double[27]);
                    }
                }
                c = new float[cxC, cyC, czC];
                t = new int[b[0], b[1], 3];
                rr = new int[b[0], b[1], 3];
                f = new int[b[0], b[1], 3];
                ddr = new int[b[0], b[1], 3];
                int v = 0;
                int n = 0;
                int q = 0;
                int robeta = 0;

                float rb = (float)0.20;// pixel;
                float Z = (float)0.100;// distance of eye form screen cm;
                float ra = 0;//varabale;
                List<Task> th = new List<Task>();

                var output = Task.Factory.StartNew(() =>
               {

                   ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, fg, delegate (int ii)
                    {

                        ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, fg, delegate (int jj)
                        {
                            //float[,,] cc = new float[(maxr - minr + 1), (maxteta - minteta + 1), 3];
                            ParallelOptions ppoio = new ParallelOptions(); ppoio.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, b[0], delegate (int i)
                        {
                            ParallelOptions pooo = new ParallelOptions(); pooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, b[1], delegate (int j)
                        {
                            lock (geta)
                            {
                                if (geta[i, j, 0] + geta[i, j, 1] + geta[i, j, 2] > 0)
                                    x++;
                            }
                            ParallelOptions poooo = new ParallelOptions(); poooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 2, delegate (int k)
                              {
                                  var output1 = Task.Factory.StartNew(() => Threaadcal(i, j, k, ii, jj));
                                  lock (th) { th.Add(output1); }
                              });


                        });
                        });
                        });
                    });
               });
                //output.Wait();
                th.Add(output);
                Parallel.ForEach(th, item => Task.WaitAll(item));
            }
            catch (Exception t)
            {
                Log(t); MessageBox.Show(t.ToString());
            }
        }
        void ContoObjectNeighbour()
        {
            try
            {
                int r = 0;
                int teta = 0;
                int fi = 0;
                cx = (int)((maxr - minr) * fg + (int)maxr + 1);

                cyp0 = (int)Math.Round((double)(maxteta - minteta) + (double)maxteta + 1.0);
                cyp1 = (int)Math.Round((double)(maxteta - minteta) * (double)2 + (double)maxteta + 1.0);
                //cy = (int)Math.Round((double)(maxteta - minteta) * (double)fg + (double)maxteta + 1.0);
                cxC = (int)((maxr - minr) * fg + (int)maxr + 1);
                cyC = (int)Math.Round((double)(maxteta - minteta) * (double)fg + (double)maxteta + 1.0);
                czC = 3;
                for (int i = 0; i < cxC; i++)
                {
                    st.Add(new List<double[]>());
                    for (int j = 0; j < cyp1; j++)
                    {
                        st[i].Add(new double[27]);
                    }
                }
                c = new float[cxC, cyp1, czC];
                t = new int[b[0], b[1], 3];
                rr = new int[b[0], b[1], 3];
                f = new int[b[0], b[1], 3];
                ddr = new int[b[0], b[1], 3];
                int v = 0;
                int n = 0;
                int q = 0;
                int robeta = 0;

                float rb = (float)0.20;// pixel;
                float Z = (float)0.100;// distance of eye form screen cm;
                float ra = 0;//varabale;
                List<Task> th = new List<Task>();

                var output = Task.Factory.StartNew(() =>
                {

                    ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, fg, delegate (int ii)
                    {

                        ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, fg, delegate (int jj)
                        {
                            //float[,,] cc = new float[(maxr - minr + 1), (maxteta - minteta + 1), 3];
                            ParallelOptions ppoio = new ParallelOptions(); ppoio.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, b[0], delegate (int i)
                                {
                                    ParallelOptions pooo = new ParallelOptions(); pooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, b[1], delegate (int j)
                                    {
                                        lock (geta)
                                        {
                                            if (geta[i, j, 0] + geta[i, j, 1] + geta[i, j, 2] > 0)
                                                x++;
                                        }
                                        ParallelOptions poooo = new ParallelOptions(); poooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 3, delegate (int k)
                                        {
                                            var output1 = Task.Factory.StartNew(() => ThreaadcalNeighbour(i, j, k, ii, jj));
                                            lock (th) { th.Add(output1); }
                                        });


                                    });
                                });
                        });
                    });
                });
                //output.Wait();
                th.Add(output);
                Parallel.ForEach(th, item => Task.WaitAll(item));
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        byte GetK(Image a, int i, int j, int k)
        {
            try
            {
                object o = new object();
                lock (o)
                {
                    lock (geta)
                    {
                        if (i < 0 || j < 0)
                            return 0;
                        if (i >= width || j >= height)
                            return 0;
                        return geta[i, j, k];
                    }
                }
            }
            catch (Exception t)
            {
                Log(t); MessageBox.Show(t.ToString());
            }
            return 0;
        }
        void ConvTo3D()
        {
            try
            {
                int r = 0;
                int teta = 0;
                int fi = 0;
                e = new float[(int)(b[0] * fg), (int)((b[1])), 3];
                List<Task> th = new List<Task>();

                var output = Task.Factory.StartNew(() =>
                {
                    ParallelOptions pop = new ParallelOptions(); pop.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, fg, delegate (int ii)
                     {
                         ParallelOptions popp = new ParallelOptions(); popp.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, fg, delegate (int jj)
                         {
                             ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, b[0], delegate (int i)
                               {
                                   ParallelOptions pon = new ParallelOptions(); pon.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, b[1], delegate (int j)
                                   {
                                       ParallelOptions pob = new ParallelOptions(); pob.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 2, delegate (int k)
                                       {
                                           var output1 = Task.Factory.StartNew(() => Threaadfetch(i, j, k, ii, jj));

                                           lock (th) { th.Add(output1); }
                                       });
                                   });
                               });
                         });
                     });
                });
                // output.Wait();
                th.Add(output);
                Parallel.ForEach(th, item => Task.WaitAll(item));
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }

        }
        void Initiate()
        {
            try
            {
                x = 0;
                minr = int.MaxValue;
                minteta = int.MaxValue;
                minfi = int.MaxValue;
                maxr = int.MinValue;
                maxteta = int.MinValue;
                maxfi = int.MinValue;
                int r = 0;
                int teta = 0;
                int fi = 0;
                b[0] = (a as Bitmap).Width;
                b[1] = (a as Bitmap).Height;
                geta = new byte[b[0], b[1], 3];
                for(int i = 0; i < b[0]; i++)
                {
                    for(int j = 0; j < b[1]; j++)
                    {
                        geta[i, j, 0] = (a as Bitmap).GetPixel(i, j).B;
                        geta[i, j, 1] = (a as Bitmap).GetPixel(i, j).G;
                        geta[i, j, 2] = (a as Bitmap).GetPixel(i, j).R;
                    }
                }
                b[2] = 3;
                t = new int[b[0], b[1], 3];
                rr = new int[b[0], b[1], 3];
                f = new int[b[0], b[1], 3];

                for (int i = 0; i < b[0]; i++)
                {
                    for (int j = 0; j < b[1]; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            double[] s = new double[3];
                            //[teta, fi, r] = cart2sph(i, j, 0);
                            s = cart2sph(i, j, 1);
                            teta = (int)Math.Round(s[0] * 180.0 / 3.1415);
                            fi = (int)Math.Round(s[1] * 180.0 / 3.1415);
                            r = (int)Math.Round(s[2]);
                            if (minr > r)
                                minr = r;

                            if (maxr < r)
                                maxr = r;

                            if (minfi > fi)
                                minfi = fi;

                            if (maxfi < fi)
                                maxfi = fi;

                            if (minteta > teta)
                                minteta = teta;

                            if (maxteta < teta)
                                maxteta = teta;

                        }


                    }
                }
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        void InitiateIntelli()
        {
            try
            {
                minr = int.MaxValue;
                minteta = int.MaxValue;
                minfi = int.MaxValue;
                maxr = int.MinValue;
                maxteta = int.MinValue;
                maxfi = int.MinValue;
                int r = 0;
                int teta = 0;
                int fi = 0;
                t = new int[b[0], b[1], 3];
                rr = new int[b[0], b[1], 3];
                f = new int[b[0], b[1], 3];

                for (int i = 0; i < b[0]; i++)
                {
                    for (int j = 0; j < b[1]; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            double[] s = new double[3];
                            //[teta, fi, r] = cart2sph(i, j, 0);
                            s = cart2sph(i, j, 1);
                            teta = (int)Math.Round(s[0] * 180.0 / 3.1415);
                            fi = (int)Math.Round(s[1] * 180.0 / 3.1415);
                            r = (int)Math.Round(s[2]);
                            if (minr > r)
                                minr = r;

                            if (maxr < r)
                                maxr = r;

                            if (minfi > fi)
                                minfi = fi;

                            if (maxfi < fi)
                                maxfi = fi;

                            if (minteta > teta)
                                minteta = teta;

                            if (maxteta < teta)
                                maxteta = teta;

                        }


                    }
                }
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        float[,,] uitn8(float[,,] p, int ii, int jj, int kk)
        {
            try
            {
                float min = float.MaxValue, max = float.MinValue;
                bool Donemax = false, Donemin = false;
                for (int i = 0; i < ii; i++)
                {
                    for (int j = 0; j < jj; j++)
                    {
                        for (int k = 0; k < kk; k++)
                        {
                            if (p[i, j, k] > max)
                            {
                                Donemax = true;
                                max = p[i, j, k];
                            }
                            if (p[i, j, k] < min)
                            {
                                Donemin = true;
                                min = p[i, j, k];
                            }
                        }
                    }

                }
                float q = min;
                if (q < 0.0 && Donemin)
                {
                    for (int i = 0; i < ii; i++)
                    {
                        for (int j = 0; j < jj; j++)
                        {
                            for (int k = 0; k < kk; k++)
                            {
                                p[i, j, k] -= q;
                            }
                        }

                    }
                }
                min = float.MaxValue; max = float.MinValue;
                Donemax = false; Donemin = false;
                for (int i = 0; i < ii; i++)
                {
                    for (int j = 0; j < jj; j++)
                    {
                        for (int k = 0; k < kk; k++)
                        {
                            if (p[i, j, k] > max)
                            {
                                Donemax = true;
                                max = p[i, j, k];
                            }
                            if (p[i, j, k] < min)
                            {
                                Donemin = true;
                                min = p[i, j, k];
                            }
                        }
                    }

                }
                q = (float)255.0 / (max);
                if (max > 255.0 && Donemax)
                {
                    for (int i = 0; i < ii; i++)
                    {
                        for (int j = 0; j < jj; j++)
                        {
                            for (int k = 0; k < kk; k++)
                            {
                                p[i, j, k] *= q;
                            }
                        }

                    }
                }
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString()); 
            }
            return p;

        }

        public void reconstruct2dto3d(int succeed)
        {
            try
            {
                if (succeed > 0)
                {
                    ConvTo3D();
                    MessageBox.Show("ConvTo3D pass!");
                    ar = new Bitmap((int)(b[0] * fg), (int)((b[1])));
                    MessageBox.Show("Graphic begin!!");
                    Graphics g = Graphics.FromImage(ar as Bitmap);



                    for (int i = 0; i < (ar as Bitmap).Width; i++)
                    {
                        for (int j = 0; j < (ar as Bitmap).Height; j++)
                        {
                            Threaaddraw(i, j, ref g, ref ar);
                        }
                    }
                    _3DReady = true;
                    g.Dispose();
                }
                              MessageBox.Show("Graphic finished!!");

            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }

        //convert 2d image to 3d;
        public _2dTo3D(string ass)
        {
            try
            {
                a = Image.FromFile(ass);
                width = (a as Bitmap).Width;
                height = (a as Bitmap).Height;

                new _2dTo3D(a, true);
                Initiate();
                MessageBox.Show("Initiate pass!");
                ContoObject();
                MessageBox.Show("ContoObject pass!");
                ConvTo3D();
                MessageBox.Show("ConvTo3D pass!");
                e = uitn8(e, (int)(b[0] * fg), (int)((b[1])), 3);
                ar = new Bitmap((int)(b[0] * fg), (int)((b[1])));
                MessageBox.Show("Graphic begin!!");
                Graphics g = Graphics.FromImage(ar as Bitmap);



                for (int i = 0; i < (ar as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (ar as Bitmap).Height; j++)
                    {
                        Threaaddraw(i, j, ref g, ref ar);
                    }
                }
                _3DReady = true;
                g.Dispose();
                    MessageBox.Show("Graphic finished!!");

            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        public _2dTo3D(Image ib, double percent)
        {
            try
            {
                a = ib;
                width = (ib as Bitmap).Width;
                height = (ib as Bitmap).Height;
                Graphics g = Graphics.FromImage(a as Bitmap);


                //new _2dTo3D(a, true);


                for (int i = 0; i < (a as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (a as Bitmap).Height; j++)
                    {
                        if (((i + j) % ((int)(1.0 / percent))) == 0)
                        {
                        }
                        else
                        {
                            (a as Bitmap).SetPixel(i, j, Color.Black);
                            g.DrawImage(a, 0, 0, (a as Bitmap).Width, (a as Bitmap).Height);
                            g.Save();
                        }
                    }
                }
                MessageBox.Show("Simplyified pass!");

                Initiate();
                MessageBox.Show("Initiate pass!");
                ContoObject();
                MessageBox.Show("ContoObject pass!");
                ConvTo3D();
                MessageBox.Show("ConvTo3D pass!");
                e = uitn8(e, (int)(b[0] * fg), (int)((b[1])), 3);
                ar = new Bitmap((int)(b[0] * fg), (int)((b[1])));
                MessageBox.Show("Graphic begin!!");
                g = Graphics.FromImage(ar as Bitmap);



                for (int i = 0; i < (ar as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (ar as Bitmap).Height; j++)
                    {
                        Threaaddraw(i, j, ref g, ref ar);
                    }
                }
                _3DReady = true;
                g.Dispose();
                        MessageBox.Show("Graphic finished!!");

            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        public _2dTo3D(Image ib, bool neighbour)
        {
            try
            {
                object o = new object();
                lock (o)
                {
                    x = 0;
                    a = ib;
                    width = (a as Bitmap).Width;
                    height = (a as Bitmap).Height;
                    Graphics g = Graphics.FromImage(a as Bitmap);
                    Initiate();
                    ContoObjectNeighbour();
                }
            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        public _2dTo3D(Image ib)

        {
            try
            {
                width = (ib as Bitmap).Width;
                height = (ib as Bitmap).Height;
                a = ib;

                //new _2dTo3D(a, true);
                Graphics g = Graphics.FromImage(a as Bitmap);
                Initiate();
                MessageBox.Show("Initiate pass!");
                ContoObject();
                MessageBox.Show("ContoObject pass!");
                ConvTo3D();
                MessageBox.Show("ConvTo3D pass!");
                e = uitn8(e, (int)(b[0] * fg), (int)((b[1])), 3);
                ar = new Bitmap((int)(b[0] * fg), (int)((b[1])));
                MessageBox.Show("Graphic begin!!");
                g = Graphics.FromImage(ar as Bitmap);



                for (int i = 0; i < (ar as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (ar as Bitmap).Height; j++)
                    {
                        Threaaddraw(i, j, ref g, ref ar);
                    }
                }
                _3DReady = true;
                g.Dispose();
                        MessageBox.Show("Graphic finished!!");

            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        public void _2dTo3D_reconstructed(Image ib)

        {
            try
            {
                width = (ib as Bitmap).Width;
                height = (ib as Bitmap).Height;
                a = ib;

                //new _2dTo3D(a, true);

                Graphics g = Graphics.FromImage(a as Bitmap);
                Initiate();
                MessageBox.Show("Initiate pass!");
                ContoObject();
                MessageBox.Show("ContoObject pass!");
                ConvTo3D();
                MessageBox.Show("ConvTo3D pass!");
                e = uitn8(e, (int)(b[0] * fg), (int)((b[1])), 3);
                ar = new Bitmap((int)(b[0] * fg), (int)((b[1])));
                MessageBox.Show("Graphic begin!!");
                g = Graphics.FromImage(ar as Bitmap);



                for (int i = 0; i < (ar as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (ar as Bitmap).Height; j++)
                    {
                        Threaaddraw(i, j, ref g, ref ar);
                    }
                }
                _3DReady = true;
                g.Dispose();
                      MessageBox.Show("Graphic finished!!");

            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
        public _2dTo3D(string ass, double percent)
        {
            try
            {
               a = Image.FromFile(ass);
                width = (a as Bitmap).Width;
                height = (a as Bitmap).Height;
                Graphics g = Graphics.FromImage(a as Bitmap);


                //new _2dTo3D(a, true);


                for (int i = 0; i < (a as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (a as Bitmap).Height; j++)
                    {
                        if (((i + j) % ((int)(1.0 / percent))) == 0)
                        {
                            g.DrawImage(a, 0, 0, (a as Bitmap).Width, (a as Bitmap).Height);
                            g.Save();
                        }
                        else
                        {
                            (a as Bitmap).SetPixel(i, j, Color.Black);
                            g.DrawImage(a, 0, 0, (a as Bitmap).Width, (a as Bitmap).Height);
                            g.Save();
                        }
                    }
                }
                MessageBox.Show("Simplyified pass!");

                Initiate();
                MessageBox.Show("Initiate pass!");
                ContoObject();
                MessageBox.Show("ContoObject pass!");
                ConvTo3D();
                MessageBox.Show("ConvTo3D pass!");
                e = uitn8(e, (int)(b[0] * fg), (int)((b[1])), 3);
                ar = new Bitmap((int)(b[0] * fg), (int)((b[1])));
                MessageBox.Show("Graphic begin!!");
                g = Graphics.FromImage(ar as Bitmap);



                for (int i = 0; i < (ar as Bitmap).Width; i++)
                {
                    for (int j = 0; j < (ar as Bitmap).Height; j++)
                    {
                        Threaaddraw(i, j, ref g, ref ar);
                    }
                }
                _3DReady = true;
                g.Dispose();
                     MessageBox.Show("Graphic finished!!");

            }
            catch (Exception t)
            {
                 Log(t); MessageBox.Show(t.ToString());
            }
        }
    }

}
