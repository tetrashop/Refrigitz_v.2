namespace ContourAnalysisNS
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    [Serializable]
    public class Template
    {
        public string name;
        public Contour contour;
        public Contour autoCorr;
        public Point startPoint;
        public bool preferredAngleNoMore90 = false;
        public int autoCorrDescriptor1;
        public int autoCorrDescriptor2;
        public int autoCorrDescriptor3;
        public int autoCorrDescriptor4;
        public double contourNorma;
        public double sourceArea;
        [NonSerialized]
        public object tag;
        private static int[] filter1 = new int[] { 1, 1, 1, 1 };
        private static int[] filter2 = new int[] { -1, -1, 1, 1 };
        private static int[] filter3 = new int[] { -1, 1, 1, -1 };
        private static int[] filter4 = new int[] { -1, 1, -1, 1 };

        public Template(Point[] points, double sourceArea, int templateSize)
        {
            this.sourceArea = sourceArea;
            this.startPoint = points[0];
            this.contour = new Contour(points);
            this.contour.Equalization(templateSize);
            this.contourNorma = this.contour.Norma;
            this.autoCorr = this.contour.AutoCorrelation(true);
            this.CalcAutoCorrDescriptions();
        }

        public void CalcAutoCorrDescriptions()
        {
            int count = this.autoCorr.Count;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            for (int i = 0; i < count; i++)
            {
                Complex complex = this.autoCorr[i];
                double norma = complex.Norma;
                int index = (4 * i) / count;
                num2 += filter1[index] * norma;
                num3 += filter2[index] * norma;
                num4 += filter3[index] * norma;
                num5 += filter4[index] * norma;
            }
            this.autoCorrDescriptor1 = (int) ((100.0 * num2) / ((double) count));
            this.autoCorrDescriptor2 = (int) ((100.0 * num3) / ((double) count));
            this.autoCorrDescriptor3 = (int) ((100.0 * num4) / ((double) count));
            this.autoCorrDescriptor4 = (int) ((100.0 * num5) / ((double) count));
        }

        public void Draw(Graphics gr, Rectangle rect)
        {
            int num8;
            int right;
            gr.DrawRectangle(Pens.SteelBlue, rect);
            rect = new Rectangle(rect.Left, rect.Top, rect.Width - 0x18, rect.Height);
            Contour contour = this.contour.Clone();
            Contour contour2 = this.autoCorr.Clone();
            contour2.Normalize();
            Rectangle rectangle = new Rectangle(rect.X, rect.Y, rect.Width / 2, rect.Height);
            rectangle.Inflate(-20, -20);
            Point[] points = contour.GetPoints(this.startPoint);
            Rectangle rectangle2 = Rectangle.Round(contour.GetBoundsRect());
            double width = rectangle2.Width;
            double height = rectangle2.Height;
            float num3 = (float) Math.Min((double) (((double) rectangle.Width) / width), (double) (((double) rectangle.Height) / height));
            int num4 = this.startPoint.X - contour.SourceBoundingRect.Left;
            int num5 = this.startPoint.Y - contour.SourceBoundingRect.Top;
            int num6 = -((int) (rectangle2.Left * num3));
            int num7 = (int) (rectangle2.Bottom * num3);
            for (num8 = 0; num8 < points.Length; num8++)
            {
                points[num8] = new Point((rectangle.Left + num6) + ((int) (((points[num8].X - contour.SourceBoundingRect.Left) - num4) * num3)), (rectangle.Top + num7) + ((int) (((points[num8].Y - contour.SourceBoundingRect.Top) - num5) * num3)));
            }
            gr.DrawPolygon(Pens.Red, points);
            rectangle = new Rectangle((rect.Width / 2) + rect.X, rect.Y, rect.Width / 2, rect.Height);
            rectangle.Inflate(-20, -20);
            List<Point> list = new List<Point>();
            for (num8 = 0; num8 < contour2.Count; num8++)
            {
                right = (rectangle.X + 5) + (num8 * 3);
                Complex complex = contour2[num8 % contour2.Count];
                int num10 = (int) (complex.Norma * rectangle.Height);
                gr.FillRectangle(Brushes.Blue, right, rectangle.Bottom - num10, 3, num10);
                complex = contour2[num8 % contour2.Count];
                list.Add(new Point(right, rectangle.Bottom - ((int) (rectangle.Height * (0.5 + ((complex.Angle / 2.0) / 3.1415926535897931))))));
            }
            try
            {
                gr.DrawLines(Pens.Red, list.ToArray());
            }
            catch (OverflowException)
            {
            }
            Pen pen = new Pen(Color.FromArgb(100, Color.Black));
            for (num8 = 0; num8 <= 10; num8++)
            {
                gr.DrawLine(pen, rectangle.X, rectangle.Bottom - ((num8 * rectangle.Height) / 10), rectangle.X + rectangle.Width, rectangle.Bottom - ((num8 * rectangle.Height) / 10));
            }
            right = rect.Right;
            int num11 = rectangle.Bottom - (rectangle.Height / 2);
            gr.DrawLine(Pens.Gray, right, num11, right + 0x17, num11);
            if ((this.autoCorrDescriptor1 < 0x7fffffff) && (this.autoCorrDescriptor1 > -2147483648))
            {
                gr.FillRectangle(Brushes.Red, right, num11 - ((this.autoCorrDescriptor1 < 0) ? 0 : ((this.autoCorrDescriptor1 * rectangle.Height) / 100)), 5, (Math.Abs(this.autoCorrDescriptor1) * rectangle.Height) / 100);
                gr.FillRectangle(Brushes.Red, right + 6, num11 - ((this.autoCorrDescriptor2 < 0) ? 0 : ((this.autoCorrDescriptor2 * rectangle.Height) / 100)), 5, (Math.Abs(this.autoCorrDescriptor2) * rectangle.Height) / 100);
                gr.FillRectangle(Brushes.Red, right + 12, num11 - ((this.autoCorrDescriptor3 < 0) ? 0 : ((this.autoCorrDescriptor3 * rectangle.Height) / 100)), 5, (Math.Abs(this.autoCorrDescriptor3) * rectangle.Height) / 100);
                gr.FillRectangle(Brushes.Red, right + 0x12, num11 - ((this.autoCorrDescriptor4 < 0) ? 0 : ((this.autoCorrDescriptor4 * rectangle.Height) / 100)), 5, (Math.Abs(this.autoCorrDescriptor4) * rectangle.Height) / 100);
            }
        }
    }
}

