using LearningMachine;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace howto_WPF_3D_triangle_normals
{
    class CurvedSystems
    {
        List<double[]> q = new List<double[]>();
        List<double> qddd = new List<double>();
        List<Point3D> qdddpoints = new List<Point3D>();
        List<List<Point3D>> listofssemipoints = null;

        List<Point3D> source = null;
        List<List<double[]>> qlist = new List<List<double[]>>();
        List<List<double>> qdddlist = new List<List<double>>();
        List<List<Point3D>> qdddpointslist = new List<List<Point3D>>();
        public List<List<double[]>> qsystemlist = new List<List<double[]>>();
        public List<List<Point3D>> qsystemlistaddpoints = new List<List<Point3D>>();
        public CurvedSystems(List<Point3D> ss)
        {
            source = ss;
            listofssemipoints = getlistOfSemilineuniqe(ss);
        }
        public List<List<double[]>> CreateQuficientofCurved()
        {


            for (int i = 0; i < listofssemipoints.Count; i++)
            {

                for (int j = 0; j < listofssemipoints[i].Count; j += 4)
                {
                    if (j < listofssemipoints[i].Count - 3)
                    {
                        double[,] qcurve = new double[3, 3];

                        double[] ddd = new double[3];
                        qcurve[0, 0] = listofssemipoints[i][j].X;
                        qcurve[0, 1] = listofssemipoints[i][j].Y;
                        qcurve[0, 2] = listofssemipoints[i][j].Z;

                        qcurve[1, 0] = listofssemipoints[i][j + 1].X;
                        qcurve[1, 1] = listofssemipoints[i][j + 1].Y;
                        qcurve[1, 2] = listofssemipoints[i][j + 1].Z;

                        qcurve[2, 0] = listofssemipoints[i][j + 2].X;
                        qcurve[2, 1] = listofssemipoints[i][j + 2].Y;
                        qcurve[2, 2] = listofssemipoints[i][j + 2].Z;

                        ddd[0] = listofssemipoints[i][j + 3].X;
                        ddd[1] = listofssemipoints[i][j + 3].Y;
                        ddd[2] = listofssemipoints[i][j + 3].Z;

                        qdddpoints.Add(new Point3D(listofssemipoints[i][j + 3].X, listofssemipoints[i][j + 3].Y, listofssemipoints[i][j + 3].Z));
                        q.Add(Interpolate.Quaficient(qcurve, ddd, 3));
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Not enough regresion data;");
                        //return null; 
                    }
                }
                qdddpointslist.Add(qdddpoints);
                qlist.Add(q);
            }
            for (int j = 0; j < qlist.Count && j < qdddpoints.Count; j++)
            {
                double[] ddd = new double[3];
                for (int i = 0; i < qlist[j].Count && i < qdddpointslist[j].Count; i++)
                {

                    if (q.Count > i && i < qdddpoints.Count)
                    {

                        ddd[0] = qlist[j][i][0] * qdddpointslist[j][i].X;
                        ddd[1] = qlist[j][i][1] * qdddpointslist[j][i].Y;
                        ddd[2] = qlist[j][i][2] * qdddpointslist[j][i].Z;


                        qddd.Add(ddd[0] + ddd[1] + ddd[2]);
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Not enough regresion system data;");
                        //return null;
                    }


                }
                qdddlist.Add(qddd);
            }



            for (int i = 0; i < qlist.Count; i++)
            {
                List<double[]> qq = qlist[i];
                List<double[]> qsystem = new List<double[]>();
                List<Point3D> qsystempoi = new List<Point3D>();


                for (int j = 0; j < qq.Count && j < qdddlist[i].Count; j += 3)
                {
                    if (qq.Count >= j + 4 && qddd.Count >= j + 4)
                    {
                        double[] ddd = new double[3];
                        double[,] qcurve = new double[3, 3];
                        qcurve[0, 0] = qq[j][0];
                        qcurve[0, 1] = qq[j][1];
                        qcurve[0, 2] = qq[j][2];

                        qcurve[1, 0] = qq[j + 1][0];
                        qcurve[1, 1] = qq[j + 1][1];
                        qcurve[1, 2] = qq[j + 1][2];

                        qcurve[2, 0] = qq[j + 2][0];
                        qcurve[2, 1] = qq[j + 2][1];
                        qcurve[2, 2] = qq[j + 2][2];

                        ddd[0] = qdddlist[i][j];
                        ddd[1] = qdddlist[i][j + 1];
                        ddd[2] = qdddlist[i][j + 2];

                        qsystem.Add(Interpolate.Quaficient(qcurve, ddd, 3));
                        qsystempoi.Add(new Point3D(qdddlist[i][j], qdddlist[i][j + 1], qdddlist[i][j + 2]));
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Not enough regresion system data;");
                        //return null;
                    }
                    qsystemlist.Add(qsystem);
                    qsystemlistaddpoints.Add(qsystempoi);
                }


            }
            if (qsystemlist.Count > 0)
                return qsystemlist;

            return null;
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
            if (i != -1 && j != -1)
                if (i == j)
                    return true;
            if (i != -1 && k != -1)
                if (i == k)
                    return true;
            if (k != -1 && j != -1)
                if (j == k)
                    return true;

            return false;
        }
        void getlistOfSemilineuniqeKernel(List<Point3D> s, int i, int j, int k, ref int ii, ref int jj, ref int kk, ref double min, ref bool found, ref Point3D next)
        {
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
        }

        //create list of semi curved; continusly
        List<List<Point3D>> getlistOfSemilineuniqe(List<Point3D> s)
        {
            List<List<Point3D>> ListOfSemiLineUniq = new List<List<Point3D>>();
            bool found = false;
            double min = double.MaxValue;
            Point3D next = new Point3D(-1, -1, -1);
            int semiscount = 0;
            int ii = -1, jj = -1, kk = -1;
            do
            {

                var output = Task.Factory.StartNew(() =>

                {

                    found = false;
                    min = double.MaxValue;
                    if ((next.X == -1 && next.Y == -1 && next.Z == -1))
                    {
                        ii = -1;
                        jj = -1;
                        kk = -1;
                    }
                    for (int i = 0; i < s.Count; i++)
                    {
                        if (!(next.X == -1 && next.Y == -1 && next.Z == -1) && (kk != -1))
                        {
                            i = kk;
                            next = new Point3D(-1, -1, -1);
                        }
                        if (boundry(i, -1, -1))
                            continue; ;
                        for (int j = 0; j < s.Count; j++)
                        {
                            if (boundry(i, j, -1))
                                continue; ;

                            for (int k = 0; k < s.Count; k++)
                            {

                                if (boundry(i, j, k))
                                    continue;
                                bool a = exist(s[i], ListOfSemiLineUniq);
                                bool b = s[i] == next;
                                bool c = exist(next, ListOfSemiLineUniq);
                                bool d = exist(s[j], ListOfSemiLineUniq);
                                bool e = exist(s[k], ListOfSemiLineUniq);
                                if (((!a) || ((b) && (c))) && (!d) && (!e))
                                    getlistOfSemilineuniqeKernel(s, i, j, k, ref ii, ref jj, ref kk, ref min, ref found, ref next);
                            }
                        }
                    }
                });
                output.Wait();
                if (found)
                {
                    bool a = exist(s[ii], ListOfSemiLineUniq);
                    bool b = s[ii] == next;
                    bool c = exist(next, ListOfSemiLineUniq);
                    bool d = exist(s[jj], ListOfSemiLineUniq);
                    bool e = exist(s[kk], ListOfSemiLineUniq);
                    if (((!a) || ((b) && (c))) && (!d) && (!e))
                    {
                        if (ListOfSemiLineUniq.Count == 0)
                            ListOfSemiLineUniq.Add(new List<Point3D>());
                        if ((!a))
                            ListOfSemiLineUniq[semiscount].Add(s[ii]);
                        if ((!d))
                            ListOfSemiLineUniq[semiscount].Add(s[jj]);
                        if ((!e))
                            ListOfSemiLineUniq[semiscount].Add(s[kk]);
                    }
                }
                if (!found)
                {
                    ListOfSemiLineUniq.Add(new List<Point3D>());
                    semiscount++;
                }
                ii = -1;
                jj = -1;
                kk = -1;
            } while (found);
            return ListOfSemiLineUniq;
        }

    }
}
