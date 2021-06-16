using System;
using System.Windows.Media.Media3D;

namespace howto_WPF_3D_triangle_normals
{
    class Line
    {
        public double a, b, c, x0, y0, z0;
        public Line(Point3D p0, Point3D p1)
        {
            x0 = p0.X;
            y0 = p0.Y;
            z0 = p0.Z;
            a = (p1.X - p0.X);
            b = (p1.Y - p0.Y);
            c = (p1.Z - p0.Z);
        }
        //constructore for orthogonal line travers from p0 on plate normal0
        public Line(Triangle normal0, Point3D p0)
        {
            x0 = p0.X;
            y0 = p0.Y;
            z0 = p0.Z;
            a = normal0.na;
            b = normal0.nb;
            c = normal0.nc;
        }
        bool existPointOnCurrentLine(Point3D p)
        {
            if (a == 0 || b == 0 || c == 0)
                return false;
            return (((p.X - x0) / a) == (p.Y - y0) / b) && ((p.X - x0) / a) == ((p.Z - z0) / c);
        }
        bool externalMulIsEqual(Triangle t0, Point3D p0)
        {
            Line l1 = new Line(t0, p0);
            double na = (t0.nb * l1.c) - (t0.nc * l1.b);
            double nb = (t0.nc * l1.a) - (t0.na * l1.c);
            double nc = (t0.na * l1.b) - (t0.nb * l1.a);
            return (na == nb) && (na == nc) & (na == 0);

        }
        //tan(pi/2) is ultimate orthogonal and zero is equal 0<landa<pi/2
        bool externalMulIsLessTanLanda(Triangle t0, Point3D p0, double landa)
        {
            Line l1 = new Line(t0, p0);
            double na = (t0.nb * l1.c) - (t0.nc * l1.b);
            double nb = (t0.nc * l1.a) - (t0.na * l1.c);
            double nc = (t0.na * l1.b) - (t0.nb * l1.a);
            return System.Math.Abs(na - nb) < System.Math.Tan(landa) || System.Math.Abs(na - nc) < System.Math.Tan(landa) || System.Math.Abs(nb - nc) < System.Math.Tan(landa);

        }
        public static double getAlpha(Line l0, Line l1)
        {
            return System.Math.Abs(l0.a - l1.a) + System.Math.Abs(l0.b - l1.b) + System.Math.Abs(l0.c - l1.c);
        }
        public double AngleBetweenTowLine(Point3D pl00, Point3D pl01, Point3D pl12, Point3D pl13, ref double an)
        {
            Line l0 = new Line(pl00, pl01);
            Line l1 = new Line(pl12, pl13);
            an = Math.Acos((l0.a * l1.a + l0.b * l1.b + l0.c * l1.c) / ((Math.Sqrt(l0.a * l0.a + l0.b * l0.b + l0.c * l0.c) * Math.Sqrt(l1.a * l1.a + l1.b * l1.b + l1.c * l1.c))));
            return an;
        }
        public static double AngleBetweenTowLineS(Point3D pl00, Point3D pl01, Point3D pl12, Point3D pl13, ref double an)
        {
            Line l0 = new Line(pl00, pl01);
            Line l1 = new Line(pl12, pl13);
            an = Math.Acos((l0.a * l1.a + l0.b * l1.b + l0.c * l1.c) / ((Math.Sqrt(l0.a * l0.a + l0.b * l0.b + l0.c * l0.c) * Math.Sqrt(l1.a * l1.a + l1.b * l1.b + l1.c * l1.c))));
            return an;
        }
        public static double AngleBetweenTowLine(Line l0, Line l1, ref double an)
        {
            an = Math.Acos((l0.a * l1.a + l0.b * l1.b + l0.c * l1.c) / ((Math.Sqrt(l0.a * l0.a + l0.b * l0.b + l0.c * l0.c) * Math.Sqrt(l1.a * l1.a + l1.b * l1.b + l1.c * l1.c))));
            return an;
        }
    }
}
