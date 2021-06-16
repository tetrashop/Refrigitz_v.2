using LearningMachine;
using Point3Dspaceuser;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace howto_WPF_3D_triangle_normalsuser
{


    public class Triangle
    {
        List<List<Point3D>> AngleCol = null;
        double block = 1;
        double a, b, c, d;
        //normal of plate
        public double na, nb, nc;
        public Triangle()
        { }
        public Triangle(Point3D p0, Point3D p1, Point3D p2)
        {
            Point3D dd = getd(p0, p1);
            double[,] aa = new double[3, 3];

            double[] ddd = new double[3];

            aa[0, 0] = p0.X;
            aa[0, 1] = p0.Y;
            aa[0, 2] = p0.Z;

            aa[1, 0] = p1.X;
            aa[1, 1] = p1.Y;
            aa[1, 2] = p1.Z;

            aa[2, 0] = p2.X;
            aa[2, 1] = p2.Y;
            aa[2, 2] = p2.Z;

            ddd[0] = dd.X;
            ddd[1] = dd.Y;
            ddd[2] = dd.Z;

            double[] cc = Interpolate.Quaficient(aa, ddd, 3);

            //plate
            a = cc[0];
            b = cc[1];
            c = cc[2];
            d = a * (p0.X) + b * (p0.Y) + c * (p0.Z);

            //create vectors contain plate
            Line l0 = new Line(p0, p1);
            Line l1 = new Line(p0, p2);
            //normals indices
            na = (l0.b * l1.c) - (l0.c * l1.b);
            nb = (l0.c * l1.a) - (l0.a * l1.c);
            nc = (l0.a * l1.b) - (l0.b * l1.a);
        }
        //point external mul vectors is zero (0 degree)
        bool externalMulIsEqual(Point3D p0, Point3D p1, Point3D p2, Point3D externalp0)
        {
            Triangle t0 = new Triangle(p0, p1, p2);
            Line l1 = new Line(t0, externalp0);
            /*double na = (t0.nb * l1.c) - (t0.nc * l1.b);
            double nb = (t0.nc * l1.a) - (t0.na * l1.c);
            double nc = (t0.na * l1.b) - (t0.nb * l1.a);
            return (na == nb) && (na == nc) & (na == 0);
*/
            try
            {
                return (t0.na / l1.a) == (t0.nb / l1.b) && (t0.nb / l1.b) == (t0.nc / l1.c);
            }
            catch (Exception t)
            {
                return (t0.na == l1.a) && (t0.nb == l1.b) && (t0.nc == l1.c);

            }
        }
        //point external mul vectors is zero (180 degree)
        bool externalMulIsEqualiInverse(Point3D p0, Point3D p1, Point3D p2, Point3D externalp0)
        {
            Triangle t0 = new Triangle(p0, p1, p2);
            Line l1 = new Line(t0, externalp0);
            double na = ((-1 * t0.nb) * l1.c) - ((-1 * t0.nc) * l1.b);
            double nb = ((-1 * t0.nc) * l1.a) - ((-1 * t0.na) * l1.c);
            double nc = ((-1 * t0.na) * l1.b) - ((-1 * t0.nb) * l1.a);
            return (na == nb) && (na == nc) & (na == 0);

        }
        public int GetPointsCountOfListOfAngleCollection(List<List<Point3D>> a, Point3D p)
        {
            int x = a.Count;
            for (int i = 0; i < x; i++)
            {
                if (exist(p, a[i]))
                    return LessDimentionCount(a[i]);
            }
            return 0;
        }
        //creation angle list.
        public List<List<Point3D>> GetListOfAngleCollection(List<Point3D> e)
        {
            List<List<Point3D>> a = new List<List<Point3D>>();
            // List<double> al = new List<double>();
            int x = e.Count;
            int index = -1;

            for (int i = 0; i < x; i++)
            {
                if (exist(e[i], a))
                    continue;
                for (int j = 0; j < x; j++)
                {
                    if (exist(e[j], a))
                        continue;
                    a.Add(new List<Point3D>());
                    index++;

                    a[index].Add(e[i]);
                    a[index].Add(e[j]);
                    for (int k = 0; k < x; k++)
                    {
                        if (exist(e[k], a))
                            continue;
                        for (int p = 0; p < x; p++)
                        {
                            if (boundry(i, j, k, p))
                                continue;
                            if (exist(e[p], a))
                                continue;
                            double an = 0;
                            bool ann = AngleLessThanLanda(e[i], e[j], e[k], e[p], Math.PI / 90, ref an);
                            if (ann)
                            {
                                a[index].Add(e[k]);
                                a[index].Add(e[p]);
                            }

                        }

                    }
                }
            }
            return a;
        }
        bool AngleLessThanLanda(Point3D pl00, Point3D pl01, Point3D pl12, Point3D pl13, double landa, ref double an)

        {
            double a = AngleBetweenTowLine(pl00, pl01, pl12, pl13, ref an);
            if (a < landa)
                return true;
            return false;
        }
        double MeanX(List<Point3D> x)
        {
            double mean = 0;
            for (int i = 0; i < x.Count; i++)
                mean += x[i].X;
            mean /= (double)x.Count;
            return mean;

        }
        double MeanY(List<Point3D> y)
        {
            double mean = 0;
            for (int i = 0; i < y.Count; i++)
                mean += y[i].Y;
            mean /= (double)y.Count;
            return mean;

        }
        double MeanZ(List<Point3D> z)
        {
            double mean = 0;
            for (int i = 0; i < z.Count; i++)
                mean += z[i].Z;
            mean /= (double)z.Count;
            return mean;

        }
        double DivesionX(List<Point3D> t)
        {
            double div = 0;
            double mean = MeanX(t);
            for (int i = 0; i < t.Count; i++)
                div += Math.Abs(t[i].X - mean);
            div /= (double)t.Count;
            return div;
        }
        double DivesionY(List<Point3D> t)
        {
            double div = 0;
            double mean = MeanY(t);
            for (int i = 0; i < t.Count; i++)
                div += Math.Abs(t[i].Y - mean);
            div /= (double)t.Count;
            return div;
        }
        double DivesionZ(List<Point3D> t)
        {
            double div = 0;
            double mean = MeanZ(t);
            for (int i = 0; i < t.Count; i++)
                div += (Math.Abs(t[i].Z - mean));
            div /= (double)t.Count;
            return div;
        }
        int LessDimentionCount(List<Point3D> d)
        {
            int count = 0;
            double divx = DivesionX(d);
            double divy = DivesionY(d);
            double divz = DivesionZ(d);
            double[] a = new double[3];
            a[0] = divx;
            a[1] = divy;
            a[2] = divz;
            a = ImprovmentSort.Do(a);
            double MaxX = maxGetListX(d);
            double MinX = minGetListX(d);

            double MaxY = maxGetListY(d);
            double MinY = minGetListY(d);

            double MaxZ = maxGetListZ(d);
            double MinZ = minGetListZ(d);

            double lenX = ((double)d.Count / (MaxX - MinX));
            double lenY = ((double)d.Count / (MaxY - MinY));
            double lenZ = ((double)d.Count / (MaxZ - MinZ));

            double MMXY = (MaxX - MinX) * (MaxY - MinY);
            double MMXZ = (MaxX - MinX) * (MaxZ - MinZ);
            double MMZY = (MaxZ - MinZ) * (MaxY - MinY);

            if (a[0] == divx)
            {
                if (divy < divz)
                {
                    return (int)(((double)d.Count - (MMZY / lenZ)) / lenZ);
                }
                else
                {
                    return (int)(((double)d.Count - (MMZY / lenY)) / lenY);

                }
            }
            else
                if (a[0] == divy)
            {
                if (divx < divz)
                {
                    return (int)(((double)d.Count - (MMXZ / lenZ)) / lenZ);

                }
                else
                {
                    return (int)(((double)d.Count - (MMXZ / lenX)) / lenX);

                }

            }
            else
                if (a[0] == divz)
            {
                if (divx < divy)
                {
                    return (int)(((double)d.Count - (MMXY / lenY)) / lenY);

                }
                else
                {
                    return (int)(((double)d.Count - (MMXY / lenX)) / lenX);

                }
            }
            return count;

        }
        static double maxGetListX(List<Point3D> d)
        {
            int inex = -1;
            double max = float.MinValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (max < d[i].X)
                {
                    max = d[i].X;
                    inex = i;
                }
            }
            return d[inex].X;
        }
        static double maxGetListY(List<Point3D> d)
        {
            int inex = -1;
            double max = float.MinValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (max < d[i].Y)
                {
                    max = d[i].Y;
                    inex = i;
                }
            }
            return d[inex].Y;
        }
        static double maxGetListZ(List<Point3D> d)
        {
            int inex = -1;
            double max = float.MinValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (max < d[i].Z)
                {
                    max = d[i].Z;
                    inex = i;
                }
            }
            return d[inex].Z;
        }
        static double minGetListX(List<Point3D> d)
        {
            int inex = -1;
            double min = float.MaxValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (min > d[i].X)
                {
                    min = d[i].X;
                    inex = i;
                }
            }
            return d[inex].X;
        }
        static double minGetListY(List<Point3D> d)
        {
            int inex = -1;
            double min = float.MaxValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (min > d[i].X)
                {
                    min = d[i].X;
                    inex = i;
                }
            }
            return d[inex].Y;
        }
        static double minGetListZ(List<Point3D> d)
        {
            int inex = -1;
            double min = float.MaxValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (min > d[i].Z)
                {
                    min = d[i].Z;
                    inex = i;
                }
            }
            return d[inex].Z;
        }

        //0<teta<pi
        double AngleBetweenTowLine(Point3D pl00, Point3D pl01, Point3D pl12, Point3D pl13, ref double an)
        {
            Line l0 = new Line(pl00, pl01);
            Line l1 = new Line(pl12, pl13);
            an = Math.Acos((l0.a * l1.a + l0.b * l1.b + l0.c * l1.c) / ((Math.Sqrt(l0.a * l0.a + l0.b * l0.b + l0.c * l0.c) * Math.Sqrt(l1.a * l1.a + l1.b * l1.b + l1.c * l1.c))));
            return an;
        }
        bool exist(Point3D ss, List<List<Point3D>> d)
        {
            if (d.Count == 0)
                return false;

            for (int i = 0; i < d.Count; i++)
            {
                for (int j = 0; j < d[i].Count; j++)
                {

                    if (ss.X == d[i][j].X && ss.Y == d[i][j].Y && ss.Z == d[i][j].Z)
                        return true;
                }
            }
            return false;
        }
        bool exist(Point3D[] ss, List<Point3D[]> d)
        {
            if (d.Count == 0)
                return false;
            for (int i = 0; i < d.Count; i++)
            {
                if (ss[0].X == d[i][0].X && ss[0].Y == d[i][0].Y && ss[0].Z == d[i][0].Z)
                    return true;
            }
            return false;
        }
        bool exist(Point3D ss, List<Point3D> d)
        {
            if (d.Count == 0)
                return false;
            for (int i = 0; i < d.Count; i++)
            {
                if (ss.X == d[i].X && ss.Y == d[i].Y && ss.Z == d[i].Z)
                    return true;
            }
            return false;
        }
        bool exist(Point3D ss, Point3D d)
        {

            if (ss.X == d.X && ss.Y == d.Y && ss.Z == d.Z)
                return true;
            return false;
        }
        public int externalMuliszerotow(Point3D p0, Point3D p1, Point3D p2, List<Point3D> externalp0, List<Point3D> dd)
        {
            object o = new object();
            lock (o)
            {
                int count = 0;
                for (int i = 0; i < externalp0.Count; i++)
                {
                    if ((!exist(p0, dd)) || (!exist(p1, dd)) || (!exist(p2, dd)))
                    {
                        if (!(exist(p0, externalp0[i])) || exist(p1, externalp0[i]) || exist(p2, externalp0[i]))
                        {
                            if (externalMulIsEqual(p0, p1, p2, externalp0[i]))
                                count++;

                            //if (externalMulIsEqualiInverse(p0, p1, p2, externalp0[i]))
                            //count++;
                        }
                    }
                }
                return count;
            }
        }
        public bool distancesaticfied(Point3D p0, Point3D p1, Point3D p2, double d)
        {
            object o = new object();
            lock (o)
            {
                double count = (Math.Sqrt((p0.X - p1.X) * (p0.X - p1.X) + (p0.Y - p1.Y) * (p0.Y - p1.Y) + (p0.Z - p1.Z) * (p0.Z - p1.Z)) + Math.Sqrt((p0.X - p2.X) * (p0.X - p2.X) + (p0.Y - p2.Y) * (p0.Y - p2.Y) + (p0.Z - p2.Z) * (p0.Z - p2.Z)) + Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) + (p1.Z - p2.Z) * (p1.Z - p2.Z))) / 3;
                if (count <= 2 * d)
                    return true;
                return false;
            }
        }
        Point3D getd(Point3D p0, Point3D p1)
        {
            Line l0 = new Line(p0, p1);
            return new Point3D(p1.X + l0.a * 2, p1.Y + l0.b * 2, p1.Z + l0.c * 2);
        }

        bool boundry(int i, int j, int k, int b, int scount, double countb, double percent)
        {
            if (i == j)
                return true;
            if (i == k)
                return true;
            if (i == b)
                return true;
            if (j == k)
                return true;
            if (j == b)
                return true;
            if (k == b)
                return true;
            if ((double)countb / (double)scount < percent)
                return true;
            if (b >= scount)
                return true;
            if (k >= scount)
                return true;
            if (j >= scount)
                return true;
            if (i >= scount)
                return true;
            return false;
        }
        bool boundryout(int i, int j, int k, int b, int scount, double countb, double percent)
        {
            if ((double)countb / (double)scount <= percent)
                return true;
            if (b >= scount)
                return true;
            if (k >= scount)
                return true;
            if (j >= scount)
                return true;
            if (i >= scount)
                return true;
            return false;
        }
        public bool boundry(int i, int j, int k, int p)
        {
            if (i == j)
                return true;
            if (i == k)
                return true;
            if (i == b)
                return true;
            if (j == k)
                return true;
            if (j == b)
                return true;
            if (k == b)
                return true;

            return false;
        }
        public bool boundry(int i, int j, int k)
        {
            if (i == j)
                return true;
            if (i == k)
                return true;
            if (j == k)
                return true;

            return false;
        }
        public bool boundryssscount(int i, int j, int ssscount)
        {

            if (i == j)
                return true;

            if (i >= ssscount)
                return true;
            if (j >= ssscount)
                return true;
            return false;
        }
        bool distancereduced(Point3D aa, Point3D bb, Point3D cc, ref bool Done, ref List<Point3D> s, double ht, int i, int j, int k)
        {
            bool dos = false;
            double r0 = Math.Sqrt((aa.X - bb.X) * (aa.X - bb.X) + (aa.Y - bb.Y) * (aa.Y - bb.Y) + (aa.Z - bb.Z) * (aa.Z - bb.Z));
            double r1 = Math.Sqrt((aa.X - cc.X) * (aa.X - cc.X) + (aa.Y - cc.Y) * (aa.Y - cc.Y) + (aa.Z - cc.Z) * (aa.Z - cc.Z));

            double r2 = Math.Sqrt((bb.X - cc.X) * (bb.X - cc.X) + (bb.Y - cc.Y) * (bb.Y - cc.Y) + (bb.Z - cc.Z) * (bb.Z - cc.Z));

            if ((r0 < ht * 3) && (r0 > ht))
            {
                s.RemoveAt(i);
                Done = true;
                dos = true;
            }
            else
          if ((r1 < ht * 3) && (r1 > ht))
            {
                s.RemoveAt(j);
                Done = true;
                dos = true;
            }
            else
          if ((r2 < ht * 3) && (r2 > ht))
            {
                s.RemoveAt(k);
                Done = true;
                dos = true;
            }
            return dos;
        }
        void removeitem(Triangle at, ref List<Point3D> s, int i, int b, int j, int k, ref bool Done, double ht)
        {
            double h = System.Math.Abs(at.a * s[b].X + at.b * s[b].Y + at.c * s[b].Z - at.d) / Math.Sqrt(at.a * at.a + at.b * at.b + at.c * at.c);
            if (h < ht && h != 0)
            {
                if (System.Math.Abs(s[b].X - s[i].X) == System.Math.Abs(s[b].X - s[j].X) && System.Math.Abs(s[b].X - s[j].X) == System.Math.Abs(s[b].X - s[k].X))
                {
                    s.RemoveAt(b);
                    Done = true;
                }
                else
                     if (System.Math.Abs(s[b].Y - s[i].Y) == System.Math.Abs(s[b].Y - s[j].Y) && System.Math.Abs(s[b].Y - s[j].Y) == System.Math.Abs(s[b].Y - s[k].Y))
                {
                    s.RemoveAt(b);
                    Done = true;
                }
                else if (System.Math.Abs(s[b].Z - s[i].Z) == System.Math.Abs(s[b].Z - s[j].Z) && System.Math.Abs(s[b].Z - s[j].Z) == System.Math.Abs(s[b].Z - s[k].Z))
                {
                    s.RemoveAt(b);
                    Done = true;
                }

            }

        }

        double minraddpoints(List<Point3D> p0)
        {
            double r = double.MaxValue;
            for (int i = 0; i < p0.Count; i++)
            {
                for (int j = 0; j < p0.Count; j++)
                {

                    double a = Math.Sqrt((p0[i].X - p0[j].X) * (p0[i].X - p0[j].X) + (p0[i].Y - p0[j].Y) * (p0[i].Y - p0[j].Y) + (p0[i].Z - p0[j].Z) * (p0[i].Z - p0[j].Z));

                    if (a < r && a != 0)
                        r = a;
                }
            }
            return r * block;
        }
        double getclonieslen(List<Point3D> ss, Point3D d, double minr)
        {
            Point3D p0 = d;
            List<Point3D> s = ss;
            List<Point3D> add = new List<Point3D>();
            add.Add(p0);
            double m = 1;
            double clonieslen = 0;
            for (int i = 0; i < s.Count; i++)
            {
                if (boundryssscount(i, -1, s.Count))
                    return double.MaxValue;
                getclonieslenInsideFor(i, ref m, ref clonieslen, ref add, ref s, ref p0, minr);
            }
            return Math.Sqrt(clonieslen);
        }
        void getclonieslenInsideFor(int i, ref double m, ref double clonieslen, ref List<Point3D> add, ref List<Point3D> s, ref Point3D p0, double minr)
        {
            object o = new object();
            lock (o)
            {
                Point3D p1 = new Point3D();
                if (i < s.Count)
                    p1 = s[i];
                else
                    return;

                if (!add.Contains(p1))
                {
                    getclonieslenInsideForInsideFirsIf(ref p1, ref m, ref clonieslen, ref add, ref s, ref p0, minr);
                }
            }
        }
        void getclonieslenInsideForInsideFirsIf(ref Point3D p1, ref double m, ref double clonieslen, ref List<Point3D> add, ref List<Point3D> s, ref Point3D p0, double minr)
        {
            object o = new object();
            lock (o)
            {
                double count = Math.Sqrt((p0.X - p1.X) * (p0.X - p1.X) + (p0.Y - p1.Y) * (p0.Y - p1.Y) + (p0.Z - p1.Z) * (p0.Z - p1.Z));
                if (count > 0 && count <= minr)
                {
                    if (clonieslen <= m * count)
                    {
                        getclonieslenInsideForInsideSecondIf(count, ref p1, ref m, ref clonieslen, ref add, ref s, ref p0, minr);
                    }
                }
            }
        }
        void getclonieslenInsideForInsideSecondIf(double count, ref Point3D p1, ref double m, ref double clonieslen, ref List<Point3D> add, ref List<Point3D> s, ref Point3D p0, double minr)
        {
            object o = new object();
            lock (o)
            {
                clonieslen = m * count;
                s.Remove(p0);
                p0 = p1;
                add.Add(p1);
                m++;
            }
        }
        bool redductionConfiguration(ref List<Point3D> sss, double minr, ref double clonieslen, ref bool xxadd, ref int i, ref List<List<Point3D>> xxxAddedClonies)
        {
            if (sss.Count == 0)
                return false;
            for (int k = 0; k < sss.Count; k++)
            {
                if (boundryssscount(k, -1, sss.Count))
                    return false;
                redductionConfigurationInsideFor(k, ref sss, minr, ref clonieslen, ref xxadd, ref i, ref xxxAddedClonies);
            }
            return true;
        }
        bool redductionConfigurationInsideFor(int k, ref List<Point3D> sss, double minr, ref double clonieslen, ref bool xxadd, ref int i, ref List<List<Point3D>> xxxAddedClonies)
        {

            bool a = exist(sss[k], xxxAddedClonies);
            if (!a)
            {
                double s = getclonieslen(sss, sss[k], minr);
                if (s > 0)
                {
                    redductionConfigurationInsideIf(k, s, ref sss, minr, ref clonieslen, ref xxadd, ref i, ref xxxAddedClonies);
                }
            }
            return true;
        }
        bool redductionConfigurationInsideIf(int k, double s, ref List<Point3D> sss, double minr, ref double clonieslen, ref bool xxadd, ref int i, ref List<List<Point3D>> xxxAddedClonies)
        {

            double d = s;
            clonieslen = d;
            i = k;
            xxadd = false;

            return true;
        }
        void reductionSetOfPointsToNumberOfSetsFull(ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)
        {

            double count = Math.Sqrt((p0.X - p1.X) * (p0.X - p1.X) + (p0.Y - p1.Y) * (p0.Y - p1.Y) + (p0.Z - p1.Z) * (p0.Z - p1.Z));
            if (count <= clonieslen)
            {
                if (!xxadd)
                {
                    bool aa = exist(p0, xxx);
                    if (!(aa || a))
                    {
                        reductionSetOfPointsToNumberOfSetsFullP1(ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
                    }
                }
                reductionSetOfPointsToNumberOfSetsFullP2(ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);

                reductionSetOfPointsToNumberOfSetsFullP3(ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
            }

        }
        void reductionSetOfPointsToNumberOfSetsFullP1(ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)
        {


            xxadd = true;
            xxx.Add(p0);
            int ff = sss.IndexOf(p0);
            xxxCon.Add(sssCon[ff]);

        }
        void reductionSetOfPointsToNumberOfSetsFullP2(ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)
        {

            int f = sss.IndexOf(p0);
            if (f < sss.Count && f >= 0)
            {
                add = true;
                if (!(a))
                    xxxAddedClonies[index].Add(p0);
                if (!(b))
                    xxxAddedClonies[index].Add(p1);
                sss.Remove(p0);
                sssCon.RemoveAt(f);
            }

        }

        void reductionSetOfPointsToNumberOfSetsFullP3(ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)
        {



            int f = sss.IndexOf(p1);
            if (f < sss.Count && f >= 0)
            {
                sss.Remove(p1);
                sssCon.RemoveAt(f);

                p = p0;
                done = true;
            }
        }
        void reductionSetOfPointsToNumberOfSetsHulfP(Point3D pp0, Point3D pp1, double minr, ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)

        {
            p0 = p;
            p1 = pp0;
            a = exist(p0, xxxAddedClonies);
            b = exist(p1, xxxAddedClonies);

            reductionSetOfPointsToNumberOfSetsHulfPO(minr, ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);

            p0 = p;
            p1 = pp1;
            a = exist(p0, xxxAddedClonies);
            b = exist(p1, xxxAddedClonies);

            reductionSetOfPointsToNumberOfSetsHulfPT(minr, ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
        }
        void reductionSetOfPointsToNumberOfSetsHulfPO(double minr, ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)

        {
            if (p0 != p1 && (!(a || b)))
            {
                if (p.X != -1 && p.Y != -1 && p.Z != -1)
                {
                    double count = Math.Sqrt((p0.X - p1.X) * (p0.X - p1.X) + (p0.Y - p1.Y) * (p0.Y - p1.Y) + (p0.Z - p1.Z) * (p0.Z - p1.Z));
                    if (count <= clonieslen)
                    {
                        if (!(a))
                        {
                            xxxAddedClonies[index].Add(p0);
                        }
                        if (!(b))
                        {

                            xxxAddedClonies[index].Add(p1);
                        }

                        int ff = sss.IndexOf(p0);
                        sss.Remove(p0);

                        xxxCon.RemoveAt(ff);

                        done = true;
                        p = p1;
                        done = true;
                        double d = getclonieslen(sss, p1, minr);
                        if (d > clonieslen)
                            clonieslen = d;
                    }
                }

            }
        }
        void reductionSetOfPointsToNumberOfSetsHulfPT(double minr, ref Point3D p, Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)

        {
            if (p0 != p1 && (!(a || b)))
            {
                if (p.X != -1 && p.Y != -1 && p.Z != -1)
                {
                    double count = Math.Sqrt((p0.X - p1.X) * (p0.X - p1.X) + (p0.Y - p1.Y) * (p0.Y - p1.Y) + (p0.Z - p1.Z) * (p0.Z - p1.Z));
                    if (count <= clonieslen)
                    {
                        if (!(a))
                        {
                            xxxAddedClonies[index].Add(p0);
                        }
                        if (!(b))
                        {

                            xxxAddedClonies[index].Add(p1);
                        }

                        int f = sss.IndexOf(p1);
                        sss.Remove(p1);

                        xxxCon.RemoveAt(f);


                        p = p0;
                        done = true;
                        double d = getclonieslen(sss, p1, minr);
                        if (d > clonieslen)
                            clonieslen = d;
                    }
                }
            }
        }
        List<Point3D> reductionSetOfPointsToNumberOfSets(List<Point3D> s, ref List<double[]> sCon, ref List<double[]> xCon)
        {
            bool reduced = false;
            List<Point3D> sss = s;
            List<double[]> sssCon = sCon;
            Point3D p = new Point3D(-1, -1, -1);

            List<Point3D> xxx = new List<Point3D>();
            List<double[]> xxxCon = xCon;
            List<List<Point3D>> xxxAddedClonies = new List<List<Point3D>>();
            xxxAddedClonies.Add(new List<Point3D>());
            double minr = minraddpoints(s);
            bool add = false;
            double clonieslen = minr;
            int index = 0;
            bool xxadd = false;
            bool done = false;
            double blockstor = block;
            do
            {
                add = false;
                minr = minraddpoints(sss);
                var output = Task.Factory.StartNew(() =>
                {

                    ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, sss.Count, i =>
                    {

                        if (boundryssscount(i, -1, sss.Count))
                            return;
                        if (!redductionConfiguration(ref sss, minr, ref clonieslen, ref xxadd, ref i, ref xxxAddedClonies))
                            return;


                        ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, sss.Count, j =>
                        {//float[,,] cc = new float[(maxr - minr + 1), (maxteta - minteta + 1), 3];
                            if (boundryssscount(i, j, sss.Count))
                                return;
                            else
                            {
                                done = false;

                                Point3D p0 = sss[i];
                                Point3D p1 = sss[j];


                                Point3D pp0 = sss[i];
                                Point3D pp1 = sss[j];
                                bool a = exist(p0, xxxAddedClonies);
                                bool b = exist(p1, xxxAddedClonies);

                                if ((!(a || b)) //&& (!add)
                                )
                                {
                                    int bl1 = GetPointsCountOfListOfAngleCollection(AngleCol, p0);
                                    int bl2 = GetPointsCountOfListOfAngleCollection(AngleCol, p1);
                                    if (block > Math.Sqrt((bl1 + bl2) / 2))
                                        block = Math.Sqrt((bl1 + bl2) / 2);
                                    else
                                        block = blockstor;

                                    reductionSetOfPointsToNumberOfSetsFull(ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
                                }
                                else
                                {
                                    int bl1 = GetPointsCountOfListOfAngleCollection(AngleCol, pp0);
                                    int bl2 = GetPointsCountOfListOfAngleCollection(AngleCol, pp1);
                                    if (block > Math.Sqrt((bl1 + bl2) / 2))
                                        block = Math.Sqrt((bl1 + bl2) / 2);
                                    else
                                        block = blockstor;
                                    reductionSetOfPointsToNumberOfSetsHulfP(pp0, pp1, minr, ref p, p0, p1, a, b, ref add, ref index, ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
                                }
                            }
                        });
                    });
                });
                output.Wait();
                xxxAddedClonies.Add(new List<Point3D>());
                xxadd = true;
                index++;
                p = new Point3D(-1, -1, -1);
            } while (sss.Count > 0 && done);
            xCon = xxxCon;
            return xxx;
        }
        public int reduceCountOfpoints(ref List<Point3D> sss, ref List<double[]> sCon, double ht, double percent, ref List<Point3D> xxx, ref List<double[]> xCon, double bl)
        {
            AngleCol = GetListOfAngleCollection(sss);
            // List<double> al = new List<double>();

            ///block = bl;
            int pcou = 0;
            int equal = 0;
            while (sss.Count > bl && (equal < 3))
            {
                block++;

                List<double[]> sssCon = sCon;
                List<double[]> xxxCon = xCon;
                pcou = sssCon.Count;
                xxx = reductionSetOfPointsToNumberOfSets(sss, ref sssCon, ref xxxCon);
                if (pcou == sssCon.Count)
                    equal++;
                xCon = xxxCon;
                sCon = sssCon;
            }
            if (xxx.Count >= 1)
                return xxx.Count;

            /*

            double countb = sss.Count;

            List<Point3D[]> d = new List<Point3D[]>();
            bool Done = false;
            List<Point3D> s = sss;
            do
            {
                Done = false;
                var output = Task.Factory.StartNew(() =>
                {

                    ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism =System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, i =>
                    {

                        if (boundryout(i, 0, 0, 0, s.Count, countb, percent))
                            return;
                        ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism =System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, j =>
                        {//float[,,] cc = new float[(maxr - minr + 1), (maxteta - minteta + 1), 3];
                            if (boundryout(i, j, 0, 0, s.Count, countb, percent))
                                return;
                            ParallelOptions ppoio = new ParallelOptions(); ppoioMaxDegreeOfParallelism =System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, k =>
                            {            //external point
                                if (boundryout(i, j, k, 0, s.Count, countb, percent))
                                    return;
                                ParallelOptions ppopio = new ParallelOptions(); ppopioMaxDegreeOfParallelism =System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, b =>
                                {
                                    if (boundry(i, j, k, b, s.Count, countb, percent))
                                        return;
                                    else
                                    if (i < s.Count && j < s.Count && k < s.Count && b < s.Count)
                                    {
                                        Point3D aa = new Point3D(s[i].X, s[i].Y, s[i].Z);
                                        Point3D bb = new Point3D(s[j].X, s[j].Y, s[j].Z);
                                        Point3D cc = new Point3D(s[k].X, s[k].Y, s[k].Z);
                                        if (!distancereduced(aa, bb, cc, ref Done, ref s, ht, i, j, k))
                                        {
                                            Triangle at = new Triangle(aa, bb, cc);

                                            Point3D[] ss = new Point3D[3];
                                            ss[0] = new Point3D(aa.X, aa.Y, aa.Z);
                                            ss[1] = new Point3D(bb.X, bb.Y, bb.Z);
                                            ss[2] = new Point3D(cc.X, cc.Y, cc.Z);
                                            ss = ImprovmentSort.Do(ss);
                                            if (!exist(ss, d))
                                            {
                                                d.Add(ss);

                                                removeitem(at, ref s, i, b, j, k, ref Done, ht);
                                            }
                                        }
                                    }
                                });
                            });
                        });
                    });
                });
                output.Wait();

            } while ((double)s.Count / countb >= percent && (Done));
            sss = s;*/
            return sss.Count;
        }
        //create list of semi curved; continusly

        List<List<Point3D>> getlistOfSemilineuniqe(List<Point3D> s)
        {
            List<List<Point3D>> ListOfSemiLineUniq = new List<List<Point3D>>();
            bool found = false;
            double min = double.MaxValue;
            Point3D next = new Point3D();
            int semiscount = 0;
            int ii = -1, jj = -1, kk = -1;
            do
            {

                var output = Task.Factory.StartNew(() =>

                {

                    found = false;
                    min = double.MaxValue;
                    ii = -1;
                    jj = -1;
                    if (next == null)
                        kk = -1;
                    ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, i =>
                    {
                        if (next != null)
                        {
                            i = kk;
                            kk = -1;
                        }
                        if (boundry(i, 0, 0, 0))
                            return;
                        ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, j =>
                        {
                            if (boundry(i, j, 0, 0))
                                return;

                            ParallelOptions poi = new ParallelOptions(); poi.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, k =>
                            {

                                if (boundry(i, j, k, 0))
                                    return;
                                //external point
                                Line l0 = new Line(s[i], s[j]);
                                Line l1 = new Line(s[j], s[k]);
                                double d = Line.getAlpha(l0, l1);
                                if (d < min)
                                {
                                    ii = i;
                                    jj = j;
                                    kk = k;
                                    min = d;
                                    found = true;
                                    next = s[k];
                                }
                            });
                        });
                    });
                });
                output.Wait();
                if (found)
                {
                    if (((!exist(s[ii], ListOfSemiLineUniq)) || ((s[ii] == next) && (exist(next, ListOfSemiLineUniq)))) && (!exist(s[jj], ListOfSemiLineUniq)) && (!exist(s[kk], ListOfSemiLineUniq)))
                    {
                        if ((!exist(s[ii], ListOfSemiLineUniq)))
                            ListOfSemiLineUniq[semiscount].Add(s[ii]);
                        if ((!exist(s[jj], ListOfSemiLineUniq)))
                            ListOfSemiLineUniq[semiscount].Add(s[jj]);
                        if ((!exist(s[kk], ListOfSemiLineUniq)))
                            ListOfSemiLineUniq[semiscount].Add(s[kk]);
                    }
                }
                if (!found)
                {
                    ListOfSemiLineUniq = new List<List<Point3D>>();
                    semiscount++;
                }
            } while (found);
            return ListOfSemiLineUniq;
        }

    }
}
