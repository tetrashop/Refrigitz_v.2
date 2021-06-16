using System.Collections.Generic;

namespace Point3Dspaceuser
{
    public class Point3D
    {
        public double X, Y, Z;
        public int i, j, k;
        public Point3D(double x, double y, double z, int ii, int jj, int kk)
        {
            X = x;
            Y = y;
            Z = z;
            i = ii;
            j = jj;
            k = kk;
        }
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D()
        {
        }
        public static bool Exist(List<List<Point3D[]>> lp, Point3D p)
        {
            bool Is = false;
             for (int i = 0; i < lp.Count; i++)
            {
                for (int j = 0; j < lp[i].Count; j++)
                {
                    if (lp[i][j][0].X == p.X && lp[i][j][0].Y == p.Y && lp[i][j][0].Z == p.Z)
                    {
                        Is = true;
                        break;
                    }
                    if (lp[i][j][1].X == p.X && lp[i][j][1].Y == p.Y && lp[i][j][1].Z == p.Z)
                    {
                        Is = true;
                        break;
                    }
                }
            }
            return Is;
        }
    }
}
