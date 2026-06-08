namespace ContourAnalysisNS
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;

    [Serializable]
    public class Contour
    {
        private Complex[] array;
        public Rectangle SourceBoundingRect;

        protected Contour()
        {
        }

        public Contour(IList<Point> points) : this(points, 0, points.Count)
        {
        }

        public Contour(int capacity)
        {
            this.array = new Complex[capacity];
        }

        public Contour(IList<Point> points, int startIndex, int count) : this(count)
        {
            int x = points[startIndex].X;
            int y = points[startIndex].Y;
            int num3 = x;
            int num4 = y;
            int num5 = startIndex + count;
            int index = startIndex;
            while (true)
            {
                if (index >= num5)
                {
                    this.SourceBoundingRect = new Rectangle(x, y, (num3 - x) + 1, (num4 - y) + 1);
                    return;
                }
                Point point = points[index];
                Point point2 = (index == (num5 - 1)) ? points[startIndex] : points[index + 1];
                this.array[index] = new Complex((double) (point2.X - point.X), (double) (-point2.Y + point.Y));
                if (point.X > num3)
                {
                    num3 = point.X;
                }
                if (point.X < x)
                {
                    x = point.X;
                }
                if (point.Y > num4)
                {
                    num4 = point.Y;
                }
                if (point.Y < y)
                {
                    y = point.Y;
                }
                index++;
            }
        }

        public unsafe Contour AutoCorrelation(bool normalize)
        {
            int capacity = this.Count / 2;
            Contour contour = new Contour(capacity);
            fixed (Complex* complexRef = ((Complex*) contour.array[0]))
            {
                Complex* complexPtr = complexRef;
                double d = 0.0;
                int shift = 0;
                while (true)
                {
                    bool flag = shift < capacity;
                    if (!flag)
                    {
                        if (normalize)
                        {
                            d = Math.Sqrt(d);
                            complexPtr = complexRef;
                            shift = 0;
                            while (true)
                            {
                                flag = shift < capacity;
                                if (!flag)
                                {
                                    break;
                                }
                                complexPtr[0] = new Complex(complexPtr->a / d, complexPtr->b / d);
                                complexPtr++;
                                shift++;
                            }
                        }
                        complexRef = ref null;
                        return contour;
                    }
                    complexPtr[0] = this.Dot(this, shift);
                    double normaSquare = complexPtr.NormaSquare;
                    if (normaSquare > d)
                    {
                        d = normaSquare;
                    }
                    complexPtr++;
                    shift++;
                }
            }
        }

        public Contour Clone() => 
            new Contour { array = (Complex[]) this.array.Clone() };

        public double DiffR2(Contour c)
        {
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            int index = 0;
            while (true)
            {
                if (index >= this.Count)
                {
                    double num8 = Math.Max(num, num2);
                    return (1.0 - (((num3 / ((double) this.Count)) / num8) / num8));
                }
                double norma = this.array[index].Norma;
                double num6 = c.array[index].Norma;
                if (norma > num)
                {
                    num = norma;
                }
                if (num6 > num2)
                {
                    num2 = num6;
                }
                double num7 = norma - num6;
                num3 += num7 * num7;
                index++;
            }
        }

        public double Distance(Contour c)
        {
            double norma = this.Norma;
            double num2 = c.Norma;
            return (((norma * norma) + (num2 * num2)) - (2.0 * this.Dot(c).a));
        }

        public Complex Dot(Contour c) => 
            this.Dot(c, 0);

        public unsafe Complex Dot(Contour c, int shift)
        {
            int count = this.Count;
            double a = 0.0;
            double b = 0.0;
            fixed (Complex* complexRef3 = ((Complex*) c.array[0]))
            {
                fixed (Complex* complexRef4 = ((Complex*) c.array[c.Count - 1]))
                {
                    Complex* complexPtr = (Complex*) this.array[0];
                    Complex* complexPtr2 = (Complex*) c.array[shift];
                    int num4 = 0;
                    while (true)
                    {
                        if (num4 >= count)
                        {
                            complexRef4 = ref null;
                            complexRef3 = ref null;
                            fixed (Complex* complexRef2 = null)
                            {
                                fixed (Complex* complexRef = null)
                                {
                                    return new Complex(a, b);
                                }
                            }
                        }
                        Complex complex = complexPtr[0];
                        Complex complex2 = complexPtr2[0];
                        a += (complex.a * complex2.a) + (complex.b * complex2.b);
                        b += (complex.b * complex2.a) - (complex.a * complex2.b);
                        complexPtr++;
                        complexPtr2 = (complexPtr2 != complexRef4) ? (complexPtr2 + 1) : complexRef3;
                        num4++;
                    }
                }
            }
        }

        public void Equalization(int newCount)
        {
            if (newCount > this.Count)
            {
                this.EqualizationUp(newCount);
            }
            else
            {
                this.EqualizationDown(newCount);
            }
        }

        private unsafe void EqualizationDown(int newCount)
        {
            Complex complex = this[0];
            Complex[] complexArray = new Complex[newCount];
            int num = 0;
            while (true)
            {
                if (num >= this.Count)
                {
                    this.array = complexArray;
                    return;
                }
                Complex* complexPtr1 = &(complexArray[(num * newCount) / this.Count]);
                complexPtr1[0] += this[num];
                num++;
            }
        }

        private void EqualizationUp(int newCount)
        {
            Complex complex = this[0];
            Complex[] complexArray = new Complex[newCount];
            int index = 0;
            while (true)
            {
                if (index >= newCount)
                {
                    this.array = complexArray;
                    return;
                }
                double num2 = ((1.0 * index) * this.Count) / ((double) newCount);
                int num3 = (int) num2;
                double num4 = num2 - num3;
                complexArray[index] = (num3 != (this.Count - 1)) ? ((this[num3] * (1.0 - num4)) + (this[num3 + 1] * num4)) : this[num3];
                index++;
            }
        }

        public Complex FindMaxNorma()
        {
            double norma = 0.0;
            Complex complex = new Complex();
            foreach (Complex complex2 in this.array)
            {
                if (complex2.Norma > norma)
                {
                    norma = complex2.Norma;
                    complex = complex2;
                }
            }
            return complex;
        }

        public Contour Fourier()
        {
            int count = this.Count;
            Contour contour = new Contour(count);
            int index = 0;
            while (index < count)
            {
                Complex complex = new Complex(0.0, 0.0);
                double num3 = (-6.2831853071795862 * index) / ((double) count);
                int num4 = 0;
                while (true)
                {
                    if (num4 >= count)
                    {
                        contour.array[index] = complex;
                        index++;
                        break;
                    }
                    Complex complex2 = this[num4];
                    complex += complex2.Rotate(num3 * num4);
                    num4++;
                }
            }
            return contour;
        }

        public RectangleF GetBoundsRect()
        {
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            for (int i = 0; i < this.Count; i++)
            {
                Complex complex = this.array[i];
                num5 += complex.a;
                num6 += complex.b;
                if (num5 > num2)
                {
                    num2 = num5;
                }
                if (num5 < num)
                {
                    num = num5;
                }
                if (num6 > num4)
                {
                    num4 = num6;
                }
                if (num6 < num3)
                {
                    num3 = num6;
                }
            }
            return new RectangleF((float) num, (float) num3, (float) (num2 - num), (float) (num4 - num3));
        }

        public Point[] GetPoints(Point startPoint)
        {
            Point[] pointArray = new Point[this.Count + 1];
            PointF tf = (PointF) startPoint;
            pointArray[0] = Point.Round(tf);
            for (int i = 0; i < this.Count; i++)
            {
                tf = tf.Offset((float) this.array[i].a, -((float) this.array[i].b));
                pointArray[i + 1] = Point.Round(tf);
            }
            return pointArray;
        }

        public Contour InterCorrelation(Contour c)
        {
            int count = this.Count;
            Contour contour = new Contour(count);
            for (int i = 0; i < count; i++)
            {
                contour.array[i] = this.Dot(c, i);
            }
            return contour;
        }

        public Contour InterCorrelation(Contour c, int maxShift)
        {
            Contour contour = new Contour(maxShift);
            int index = 0;
            int count = this.Count;
            while (index < (maxShift / 2))
            {
                contour.array[index] = this.Dot(c, index);
                contour.array[(maxShift - index) - 1] = this.Dot(c, (c.Count - index) - 1);
                index++;
            }
            return contour;
        }

        public void Mult(Complex c)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i] = c * this[i];
            }
        }

        public void Normalize()
        {
            double norma = this.FindMaxNorma().Norma;
            if (norma > double.Epsilon)
            {
                this.Scale(1.0 / norma);
            }
        }

        public Complex NormDot(Contour c)
        {
            int count = this.Count;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            int num6 = 0;
            while (true)
            {
                if (num6 >= count)
                {
                    double num7 = 1.0 / Math.Sqrt(num4 * num5);
                    return new Complex(num2 * num7, num3 * num7);
                }
                Complex complex = this[num6];
                Complex complex2 = c[num6];
                num2 += (complex.a * complex2.a) + (complex.b * complex2.b);
                num3 += (complex.b * complex2.a) - (complex.a * complex2.b);
                num4 += complex.NormaSquare;
                num5 += complex2.NormaSquare;
                num6++;
            }
        }

        public void Rotate(double angle)
        {
            double cosAngle = Math.Cos(angle);
            double sinAngle = Math.Sin(angle);
            for (int i = 0; i < this.Count; i++)
            {
                this[i] = this[i].Rotate(cosAngle, sinAngle);
            }
        }

        public void Scale(double scale)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i] = (Complex) (scale * this[i]);
            }
        }

        public int Count =>
            this.array.Length;

        public Complex this[int i]
        {
            get => 
                this.array[i];
            set => 
                (this.array[i] = value);
        }

        public double Norma
        {
            get
            {
                double d = 0.0;
                foreach (Complex complex in this.array)
                {
                    d += complex.NormaSquare;
                }
                return Math.Sqrt(d);
            }
        }
    }
}

