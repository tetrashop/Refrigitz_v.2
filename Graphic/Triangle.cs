using LearningMachine;
using Point3Dspaceuser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace howto_WPF_3D_triangle_normalsuser
{
    public class Triangle
    {
        List<List<Point3D>> AngleCol = null;
        double block = 1;
        double a, b, c, d;
        public double na, nb, nc;

        public Triangle() { }

        public Triangle(Point3D p0, Point3D p1, Point3D p2)
        {
            Point3D dd = getd(p0, p1);
            double[,] aa = new double[3, 3];
            double[] ddd = new double[3];
            aa[0, 0] = p0.X; aa[0, 1] = p0.Y; aa[0, 2] = p0.Z;
            aa[1, 0] = p1.X; aa[1, 1] = p1.Y; aa[1, 2] = p1.Z;
            aa[2, 0] = p2.X; aa[2, 1] = p2.Y; aa[2, 2] = p2.Z;
            ddd[0] = dd.X; ddd[1] = dd.Y; ddd[2] = dd.Z;
            double[] cc = Interpolate.Quaficient(aa, ddd, 3);
            a = cc[0]; b = cc[1]; c = cc[2];
            d = a * p0.X + b * p0.Y + c * p0.Z;
            Line l0 = new Line(p0, p1);
            Line l1 = new Line(p0, p2);
            na = (l0.b * l1.c) - (l0.c * l1.b);
            nb = (l0.c * l1.a) - (l0.a * l1.c);
            nc = (l0.a * l1.b) - (l0.b * l1.a);
        }

        Point3D getd(Point3D p0, Point3D p1)
        {
            Line l0 = new Line(p0, p1);
            return new Point3D(p1.X + l0.a * 2, p1.Y + l0.b * 2, p1.Z + l0.c * 2);
        }

        public bool externalMulIsEqual(Point3D p0, Point3D p1, Point3D p2, Point3D externalp0)
        {
            Triangle t0 = new Triangle(p0, p1, p2);
            Line l1 = new Line(t0, externalp0);
            try
            {
                double valA = t0.na / l1.a;
                double valB = t0.nb / l1.b;
                double valC = t0.nc / l1.c;
                return Math.Abs(valA - valB) < 1e-9 && Math.Abs(valB - valC) < 1e-9;
            }
            catch (DivideByZeroException)
            {
                return (t0.na == l1.a) && (t0.nb == l1.b) && (t0.nc == l1.c);
            }
        }

        public bool externalMulIsEqualiInverse(Point3D p0, Point3D p1, Point3D p2, Point3D externalp0)
        {
            Triangle t0 = new Triangle(p0, p1, p2);
            Line l1 = new Line(t0, externalp0);
            double na2 = ((-1 * t0.nb) * l1.c) - ((-1 * t0.nc) * l1.b);
            double nb2 = ((-1 * t0.nc) * l1.a) - ((-1 * t0.na) * l1.c);
            double nc2 = ((-1 * t0.na) * l1.b) - ((-1 * t0.nb) * l1.a);
            return (na2 == nb2) && (na2 == nc2) && (na2 == 0);
        }

        public int externalMuliszerotow(Point3D p0, Point3D p1, Point3D p2, List<Point3D> externalp0, List<Point3D> dd)
        {
            int count = 0;
            for (int i = 0; i < externalp0.Count; i++)
            {
                if (!exist(p0, dd) || !exist(p1, dd) || !exist(p2, dd))
                {
                    if (!(exist(p0, externalp0[i])) || exist(p1, externalp0[i]) || exist(p2, externalp0[i]))
                    {
                        if (externalMulIsEqual(p0, p1, p2, externalp0[i]))
                            count++;
                    }
                }
            }
            return count;
        }

        public bool distancesaticfied(Point3D p0, Point3D p1, Point3D p2, double d)
        {
            double dist = (Math.Sqrt(Math.Pow(p0.X - p1.X, 2) + Math.Pow(p0.Y - p1.Y, 2) + Math.Pow(p0.Z - p1.Z, 2))
                         + Math.Sqrt(Math.Pow(p0.X - p2.X, 2) + Math.Pow(p0.Y - p2.Y, 2) + Math.Pow(p0.Z - p2.Z, 2))
                         + Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2) + Math.Pow(p1.Z - p2.Z, 2))) / 3;
            return dist <= 2 * d;
        }

        public double AngleBetweenTowLine(Point3D pl00, Point3D pl01, Point3D pl12, Point3D pl13, ref double an)
        {
            Line l0 = new Line(pl00, pl01);
            Line l1 = new Line(pl12, pl13);
            return Line.AngleBetweenTowLine(l0, l1, ref an);
        }

        bool AngleLessThanLanda(Point3D pl00, Point3D pl01, Point3D pl12, Point3D pl13, double landa, ref double an)
        {
            double a = AngleBetweenTowLine(pl00, pl01, pl12, pl13, ref an);
            return a < landa;
        }

        public List<List<Point3D>> GetListOfAngleCollection(List<Point3D> e)
        {
            AngleCol = new List<List<Point3D>>();
            int x = e.Count;
            for (int i = 0; i < x; i++)
            {
                if (exist(e[i], AngleCol)) continue;
                for (int j = 0; j < x; j++)
                {
                    if (exist(e[j], AngleCol)) continue;
                    AngleCol.Add(new List<Point3D> { e[i], e[j] });
                    int index = AngleCol.Count - 1;
                    for (int k = 0; k < x; k++)
                    {
                        if (boundry(i, j, k) || exist(e[k], AngleCol)) continue;
                        for (int p = 0; p < x; p++)
                        {
                            if (boundry(i, j, k, p) || exist(e[p], AngleCol)) continue;
                            double an = 0;
                            if (AngleLessThanLanda(e[i], e[j], e[k], e[p], Math.PI / 90, ref an))
                            {
                                AngleCol[index].Add(e[k]);
                                AngleCol[index].Add(e[p]);
                            }
                        }
                    }
                }
            }
            return AngleCol;
        }

        public int GetPointsCountOfListOfAngleCollection(List<List<Point3D>> a, Point3D p)
        {
            for (int i = 0; i < a.Count; i++)
                if (exist(p, a[i]))
                    return LessDimentionCount(a[i]);
            return 0;
        }

        double MeanX(List<Point3D> x) => x.Average(p => p.X);
        double MeanY(List<Point3D> y) => y.Average(p => p.Y);
        double MeanZ(List<Point3D> z) => z.Average(p => p.Z);

        double DivesionX(List<Point3D> t)
        {
            double mean = MeanX(t);
            return t.Average(p => Math.Abs(p.X - mean));
        }
        double DivesionY(List<Point3D> t)
        {
            double mean = MeanY(t);
            return t.Average(p => Math.Abs(p.Y - mean));
        }
        double DivesionZ(List<Point3D> t)
        {
            double mean = MeanZ(t);
            return t.Average(p => Math.Abs(p.Z - mean));
        }

        int LessDimentionCount(List<Point3D> d)
        {
            double divx = DivesionX(d), divy = DivesionY(d), divz = DivesionZ(d);
            double[] a = new double[] { divx, divy, divz };
            Array.Sort(a);
            Array.Reverse(a);
            double MaxX = d.Max(p => p.X), MinX = d.Min(p => p.X);
            double MaxY = d.Max(p => p.Y), MinY = d.Min(p => p.Y);
            double MaxZ = d.Max(p => p.Z), MinZ = d.Min(p => p.Z);
            if (MaxX - MinX == 0 || MaxY - MinY == 0 || MaxZ - MinZ == 0) return d.Count;
            double lenX = d.Count / (MaxX - MinX);
            double lenY = d.Count / (MaxY - MinY);
            double lenZ = d.Count / (MaxZ - MinZ);
            double MMXY = (MaxX - MinX) * (MaxY - MinY);
            double MMXZ = (MaxX - MinX) * (MaxZ - MinZ);
            double MMZY = (MaxZ - MinZ) * (MaxY - MinY);
            if (a[0] == divx)
                return divy < divz ? (int)((d.Count - MMZY / lenZ) / lenZ) : (int)((d.Count - MMZY / lenY) / lenY);
            else if (a[0] == divy)
                return divx < divz ? (int)((d.Count - MMXZ / lenZ) / lenZ) : (int)((d.Count - MMXZ / lenX) / lenX);
            else
                return divx < divy ? (int)((d.Count - MMXY / lenY) / lenY) : (int)((d.Count - MMXY / lenX) / lenX);
        }

        public int reduceCountOfpoints(ref List<Point3D> sss, ref List<double[]> sCon, double ht, double percent,
            ref List<Point3D> xxx, ref List<double[]> xCon, double bl)
        {
            AngleCol = GetListOfAngleCollection(sss);
            int equal = 0;
            while (sss.Count > bl && equal < 3)
            {
                block++;
                int pcou = sCon.Count;
                var sssCon = sCon;
                var xxxCon = xCon;
                xxx = reductionSetOfPointsToNumberOfSets(sss, ref sssCon, ref xxxCon);
                if (pcou == sssCon.Count) equal++;
                xCon = xxxCon;
                sCon = sssCon;
            }
            return xxx.Count;
        }

        List<Point3D> reductionSetOfPointsToNumberOfSets(List<Point3D> s, ref List<double[]> sCon, ref List<double[]> xCon)
        {
            List<Point3D> sss = new List<Point3D>(s);
            List<double[]> sssCon = new List<double[]>(sCon);
            Point3D p = new Point3D(-1, -1, -1);
            List<Point3D> xxx = new List<Point3D>();
            List<double[]> xxxCon = new List<double[]>();
            List<List<Point3D>> xxxAddedClonies = new List<List<Point3D>> { new List<Point3D>() };
            double minr = minraddpoints(s);
            bool add = false, xxadd = false, done = false;
            double clonieslen = minr;
            int index = 0;
            double blockstor = block;
            do
            {
                add = false;
                minr = minraddpoints(sss);
                for (int i = 0; i < sss.Count; i++)
                {
                    if (!redductionConfiguration(ref sss, minr, ref clonieslen, ref xxadd, ref i, ref xxxAddedClonies))
                        continue;
                    for (int j = 0; j < sss.Count; j++)
                    {
                        if (boundryssscount(i, j, sss.Count)) continue;
                        done = false;
                        Point3D p0 = sss[i], p1 = sss[j];
                        bool a = exist(p0, xxxAddedClonies), b = exist(p1, xxxAddedClonies);
                        if (!(a || b))
                        {
                            int bl1 = GetPointsCountOfListOfAngleCollection(AngleCol, p0);
                            int bl2 = GetPointsCountOfListOfAngleCollection(AngleCol, p1);
                            block = block > Math.Sqrt((bl1 + bl2) / 2) ? Math.Sqrt((bl1 + bl2) / 2) : blockstor;
                            reductionSetOfPointsToNumberOfSetsFull(ref p, p0, p1, a, b, ref add, ref index, ref xxadd,
                                ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
                        }
                        else
                        {
                            int bl1 = GetPointsCountOfListOfAngleCollection(AngleCol, p0);
                            int bl2 = GetPointsCountOfListOfAngleCollection(AngleCol, p1);
                            block = block > Math.Sqrt((bl1 + bl2) / 2) ? Math.Sqrt((bl1 + bl2) / 2) : blockstor;
                            reductionSetOfPointsToNumberOfSetsHulfP(p0, p1, minr, ref p, p0, p1, a, b, ref add, ref index,
                                ref xxadd, ref sss, ref sssCon, ref xxxAddedClonies, ref clonieslen, ref done, ref xxx, ref xxxCon);
                        }
                    }
                }
                xxxAddedClonies.Add(new List<Point3D>());
                xxadd = true;
                index++;
                p = new Point3D(-1, -1, -1);
            } while (sss.Count > 0 && done);
            xCon = xxxCon;
            return xxx;
        }

        void reductionSetOfPointsToNumberOfSetsFull(ref Point3D p, Point3D p0, Point3D p1, bool a, bool b,
            ref bool add, ref int index, ref bool xxadd, ref List<Point3D> sss, ref List<double[]> sssCon,
            ref List<List<Point3D>> xxxAddedClonies, ref double clonieslen, ref bool done,
            ref List<Point3D> xxx, ref List<double[]> xxxCon)
        {
            double count = Math.Sqrt(Math.Pow(p0.X - p1.X, 2) + Math.Pow(p0.Y - p1.Y, 2) + Math.Pow(p0.Z - p1.Z, 2));
            if (count > clonieslen) return;
            if (!xxadd && !a)
            {
                xxadd = true;
                xxx.Add(p0);
                xxxCon.Add(sssCon[sss.IndexOf(p0)]);
            }
            if (sss.Contains(p0))
            {
                add = true;
                if (!a) xxxAddedClonies[index].Add(p0);
                if (!b) xxxAddedClonies[index].Add(p1);
                sss.Remove(p0);
                sssCon.RemoveAt(sss.IndexOf(p0));
            }
            if (sss.Contains(p1))
            {
                sss.Remove(p1);
                sssCon.RemoveAt(sss.IndexOf(p1));
                p = p0;
                done = true;
            }
        }

        void reductionSetOfPointsToNumberOfSetsHulfP(Point3D pp0, Point3D pp1, double minr, ref Point3D p,
            Point3D p0, Point3D p1, bool a, bool b, ref bool add, ref int index, ref bool xxadd,
            ref List<Point3D> sss, ref List<double[]> sssCon, ref List<List<Point3D>> xxxAddedClonies,
            ref double clonieslen, ref bool done, ref List<Point3D> xxx, ref List<double[]> xxxCon)
        {
            if (p0 != p1 && !(a || b) && p.X != -1 && p.Y != -1 && p.Z != -1)
            {
                double count = Math.Sqrt(Math.Pow(p0.X - p1.X, 2) + Math.Pow(p0.Y - p1.Y, 2) + Math.Pow(p0.Z - p1.Z, 2));
                if (count <= clonieslen)
                {
                    if (!a) xxxAddedClonies[index].Add(p0);
                    if (!b) xxxAddedClonies[index].Add(p1);
                    sss.Remove(p0);
                    sssCon.RemoveAt(sss.IndexOf(p0));
                    done = true;
                    p = p1;
                    clonieslen = Math.Max(clonieslen, getclonieslen(sss, p1, minr));
                }
            }
        }

        double getclonieslen(List<Point3D> ss, Point3D d, double minr)
        {
            List<Point3D> s = new List<Point3D>(ss);
            List<Point3D> add = new List<Point3D> { d };
            double m = 1, clonieslen = 0;
            Point3D p0 = d;
            for (int i = 0; i < s.Count; i++)
            {
                if (boundryssscount(i, -1, s.Count)) return double.MaxValue;
                Point3D p1 = s[i];
                if (!add.Contains(p1))
                {
                    double count = Math.Sqrt(Math.Pow(p0.X - p1.X, 2) + Math.Pow(p0.Y - p1.Y, 2) + Math.Pow(p0.Z - p1.Z, 2));
                    if (count > 0 && count <= minr && clonieslen <= m * count)
                    {
                        clonieslen = m * count;
                        s.Remove(p0);
                        p0 = p1;
                        add.Add(p1);
                        m++;
                    }
                }
            }
            return Math.Sqrt(clonieslen);
        }

        bool redductionConfiguration(ref List<Point3D> sss, double minr, ref double clonieslen,
            ref bool xxadd, ref int i, ref List<List<Point3D>> xxxAddedClonies)
        {
            if (sss.Count == 0) return false;
            for (int k = 0; k < sss.Count; k++)
            {
                if (boundryssscount(k, -1, sss.Count)) return false;
                if (!exist(sss[k], xxxAddedClonies))
                {
                    double s = getclonieslen(sss, sss[k], minr);
                    if (s > 0) { clonieslen = s; i = k; xxadd = false; return true; }
                }
            }
            return true;
        }

        double minraddpoints(List<Point3D> p0)
        {
            double r = double.MaxValue;
            for (int i = 0; i < p0.Count; i++)
                for (int j = 0; j < p0.Count; j++)
                {
                    double a = Math.Sqrt(Math.Pow(p0[i].X - p0[j].X, 2) + Math.Pow(p0[i].Y - p0[j].Y, 2) + Math.Pow(p0[i].Z - p0[j].Z, 2));
                    if (a < r && a != 0) r = a;
                }
            return r * block;
        }

        bool exist(Point3D ss, List<List<Point3D>> d) { return d.Any(lst => lst.Any(p => p.X == ss.X && p.Y == ss.Y && p.Z == ss.Z)); }
        bool exist(Point3D ss, List<Point3D> d) { return d.Any(p => p.X == ss.X && p.Y == ss.Y && p.Z == ss.Z); }
        bool exist(Point3D ss, Point3D d) { return ss.X == d.X && ss.Y == d.Y && ss.Z == d.Z; }
        bool boundry(int i, int j, int k) { return i == j || i == k || j == k; }
        bool boundry(int i, int j, int k, int p) { return i == j || i == k || i == p || j == k || j == p || k == p; }
        bool boundryssscount(int i, int j, int ssscount) { return i == j || i >= ssscount || j >= ssscount; }

        public List<List<Point3D>> getlistOfSemilineuniqe(List<Point3D> s)
        {
            List<List<Point3D>> listOfSemiLineUniq = new List<List<Point3D>>();
            bool found = false;
            double min = double.MaxValue;
            Point3D next = null;
            int semiscount = 0, ii = -1, jj = -1, kk = -1;
            do
            {
                found = false;
                min = double.MaxValue;
                ii = -1; jj = -1;
                if (next == null) kk = -1;
                for (int i = 0; i < s.Count; i++)
                {
                    if (next != null) { i = kk; kk = -1; }
                    if (boundry(i, 0, 0)) continue;
                    for (int j = 0; j < s.Count; j++)
                    {
                        if (boundry(i, j, 0)) continue;
                        for (int k = 0; k < s.Count; k++)
                        {
                            if (boundry(i, j, k)) continue;
                            Line l0 = new Line(s[i], s[j]);
                            Line l1 = new Line(s[j], s[k]);
                            double d = Line.getAlpha(l0, l1);
                            if (d < min) { ii = i; jj = j; kk = k; min = d; found = true; next = s[k]; }
                        }
                    }
                }
                if (found && ii >= 0 && jj >= 0 && kk >= 0)
                {
                    if (!exist(s[ii], listOfSemiLineUniq)) listOfSemiLineUniq[semiscount].Add(s[ii]);
                    if (!exist(s[jj], listOfSemiLineUniq)) listOfSemiLineUniq[semiscount].Add(s[jj]);
                    if (!exist(s[kk], listOfSemiLineUniq)) listOfSemiLineUniq[semiscount].Add(s[kk]);
                }
                if (!found)
                {
                    listOfSemiLineUniq.Add(new List<Point3D>());
                    semiscount++;
                }
            } while (found);
            return listOfSemiLineUniq;
        }
    }
}
