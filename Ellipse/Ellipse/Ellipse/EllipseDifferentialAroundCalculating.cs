using System;


namespace Ellipse
{
    class EllipseDifferentialAroundCalculating
    {
        double around = 0;
        double aroundOiler = 0;
        //double Paround = 0;
        public EllipseDifferentialAroundCalculating(double a, double b, double c)
        {
            //Initiate Ellipse Paramenters.

            double e = (double)System.Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b, 2)) / a;
            double p = 2 * Math.PI * a;

            double dx = 0;

            //double dx =System.(double.MinValue);
            double aa = 30;
            //Found
            for (int i = 1; i < aa; i++)
            {
                dx += ((Math.Pow((LearningMachine.HermitInterpolation.Factorial(2 * i)), 2) / (Math.Pow(Math.Pow(2, i) * (LearningMachine.HermitInterpolation.Factorial(i)), 4))) * (Math.Pow(e, 2 * i) / (2 * i - 1)));
            }
            //Multiply for orthogonality.
            around = p * (1 - dx);
            aroundOiler = Math.PI * (Math.Sqrt(2 * (Math.Pow(a, 2) + Math.Pow(b, 2))));
            /* double h = Math.PI * (Math.Pow(a - b, 2) / Math.Pow(a + b, 2));
             double Pp = Math.PI * (a + b);
             dx = 0;

             for (int i = 1; i < aa; i++)
             {
                 dx += ((Math.Pow(LearningMachine.HermitInterpolation.Factorial(2 * i), 2) / (Math.Pow(Math.Pow(2, i) * LearningMachine.HermitInterpolation.Factorial(i), 4))) * (Math.Pow(e, 2 * i) / (2 * i - 1)));
             }*/
        }
        public EllipseDifferentialAroundCalculating(double a, double b)
        {
            //Initiate Ellipse Paramenters.

            double p = 2 * Math.PI * Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)) / 2);

            around = p;
            aroundOiler = Math.PI * (Math.Sqrt(2 * (Math.Pow(a, 2) + Math.Pow(b, 2))));
            /* double h = Math.PI * (Math.Pow(a - b, 2) / Math.Pow(a + b, 2));
                double Pp = Math.PI * (a + b);
                dx = 0;

                for (int i = 1; i < aa; i++)
                {
                    dx += ((Math.Pow(LearningMachine.HermitInterpolation.Factorial(2 * i), 2) / (Math.Pow(Math.Pow(2, i) * LearningMachine.HermitInterpolation.Factorial(i), 4))) * (Math.Pow(e, 2 * i) / (2 * i - 1)));
                }*/
        }
        public double aroundAccess
        {
            get { return around; }
            set { around = value; }
        }
        public double aroundOilerAccess
        {
            get { return aroundOiler; }
            set { aroundOiler = value; }
        }
    }
}
