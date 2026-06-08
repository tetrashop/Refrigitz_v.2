using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace howto_WPF_3D_triangle_normals
{
    class SemiLines
    {
        public List<List<Line>> lineslistoflines = null;
        public List<Point3D> source = null;
        public SemiLines(List<Point3D> ss)
        {
            source = ss;
            GetListOfLinesList(getlistOfSemilineuniqe(ss));
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
        List<List<Line>> GetListOfLinesList(List<List<Point3D>> s)
        {
            lineslistoflines = new List<List<Line>>();

            for (int i = 0; i < s.Count; i++)
            {
                lineslistoflines.Add(GetQueficentEquation(s[i]));
            }
            return lineslistoflines;
        }
        List<Line> GetQueficentEquation(List<Point3D> s)
        {
            List<Line> linesq = new List<Line>();

            for (int i = 0; i < s.Count - 1; i++)
            {
                linesq.Add(new Line(s[i], s[i + 1]));
            }
            return linesq;
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
                        if (boundry(i, -1, -1))
                            return;
                        ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, j =>
                        {
                            if (boundry(i, j, -1))
                                return;

                            ParallelOptions poi = new ParallelOptions(); poi.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, s.Count, k =>
                            {

                                if (boundry(i, j, k))
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
