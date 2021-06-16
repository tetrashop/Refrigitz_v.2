namespace ContourAnalysisNS
{
    using System;
    using System.Runtime.InteropServices;

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Complex
    {
        public double a;
        public double b;
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public static Complex FromExp(double r, double angle) => 
            new Complex(r * Math.Cos(angle), r * Math.Sin(angle));

        public double Angle =>
            Math.Atan2(this.b, this.a);
        public override string ToString() => 
            (this.a + "+i" + this.b);

        public double Norma =>
            Math.Sqrt((this.a * this.a) + (this.b * this.b));
        public double NormaSquare =>
            ((this.a * this.a) + (this.b * this.b));
        public static Complex operator +(Complex x1, Complex x2) => 
            new Complex(x1.a + x2.a, x1.b + x2.b);

        public static Complex operator *(double k, Complex x) => 
            new Complex(k * x.a, k * x.b);

        public static Complex operator *(Complex x, double k) => 
            new Complex(k * x.a, k * x.b);

        public static Complex operator *(Complex x1, Complex x2) => 
            new Complex((x1.a * x2.a) - (x1.b * x2.b), (x1.b * x2.a) + (x1.a * x2.b));

        public double CosAngle() => 
            (this.a / Math.Sqrt((this.a * this.a) + (this.b * this.b)));

        public Complex Rotate(double CosAngle, double SinAngle) => 
            new Complex((CosAngle * this.a) - (SinAngle * this.b), (SinAngle * this.a) + (CosAngle * this.b));

        public Complex Rotate(double Angle)
        {
            double num = Math.Cos(Angle);
            double num2 = Math.Sin(Angle);
            return new Complex((num * this.a) - (num2 * this.b), (num2 * this.a) + (num * this.b));
        }
    }
}

