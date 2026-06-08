namespace ContourAnalysisNS
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Runtime.CompilerServices;

    public static class PointHelper
    {
        public static int Area(this Rectangle rect) => 
            (rect.Width * rect.Height);

        public static Point Center(this Rectangle rect) => 
            new Point(rect.X + (rect.Width / 2), rect.Y + (rect.Height / 2));

        public static int Distance(this Point point, Point p) => 
            (Math.Abs((int) (point.X - p.X)) + Math.Abs((int) (point.Y - p.Y)));

        public static void NormalizePoints(Point[] points, Rectangle rectangle)
        {
            if ((rectangle.Height != 0) && (rectangle.Width != 0))
            {
                Matrix matrix = new Matrix();
                matrix.Translate((float) rectangle.Center().X, (float) rectangle.Center().Y);
                if (rectangle.Width > rectangle.Height)
                {
                    matrix.Scale(1f, (1f * rectangle.Width) / ((float) rectangle.Height));
                }
                else
                {
                    matrix.Scale((1f * rectangle.Height) / ((float) rectangle.Width), 1f);
                }
                matrix.Translate((float) -rectangle.Center().X, (float) -rectangle.Center().Y);
                matrix.TransformPoints(points);
            }
        }

        public static void NormalizePoints2(Point[] points, Rectangle rectangle, Rectangle needRectangle)
        {
            if ((rectangle.Height != 0) && (rectangle.Width != 0))
            {
                float num = (1f * needRectangle.Width) / ((float) rectangle.Width);
                float num2 = (1f * needRectangle.Height) / ((float) rectangle.Height);
                float scaleX = Math.Min(num, num2);
                Matrix matrix = new Matrix();
                matrix.Scale(scaleX, scaleX);
                matrix.Translate((((float) needRectangle.X) / scaleX) - rectangle.X, (((float) needRectangle.Y) / scaleX) - rectangle.Y);
                matrix.TransformPoints(points);
            }
        }

        public static PointF Offset(this PointF p, float dx, float dy) => 
            new PointF(p.X + dx, p.Y + dy);
    }
}

