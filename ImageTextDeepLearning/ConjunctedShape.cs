using ContourAnalysisDemo;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ImageTextDeepLearning
{
    //Class for create conjuncted shape
    [Serializable]
    internal class ConjunctedShape
    {
        private bool Hollowed = false;
        //initiate global vars
        private readonly int Width = 10, Height = 10;
        private readonly MainForm d = null;
        private readonly int Threashold = 5;
        public Contour<Point> Collection = null;
        public List<Contour<Point>> All = new List<Contour<Point>>();
        public List<Bitmap> AllImage = new List<Bitmap>();
        //Constructor
        public ConjunctedShape(MainForm dd)
        {
            d = dd;
        }
        //Max of list
        private float MaxX(PointF[] Tem)
        {
            float te = 0;
            for (int j = 0; j < Tem.Length; j++)
            {
                if (Tem[j].X > te)
                {
                    te = Tem[j].X;
                }
            }
            return te;
        }
        //Max of list
        private float MaxY(PointF[] Tem)
        {
            float te = 0;
            for (int j = 0; j < Tem.Length; j++)
            {
                if (Tem[j].Y > te)
                {
                    te = Tem[j].Y;
                }
            }
            return te;
        }
        //Min of list
        private float MinX(PointF[] Tem)
        {
            float te = float.MaxValue;
            for (int j = 0; j < Tem.Length; j++)
            {
                if (Tem[j].X < te)
                {
                    te = Tem[j].X;
                }
            }
            return te;
        }
        //Min of list
        private float MinY(PointF[] Tem)
        {
            float te = float.MaxValue;
            for (int j = 0; j < Tem.Length; j++)
            {
                if (Tem[j].Y < te)
                {
                    te = Tem[j].Y;
                }
            }
            return te;
        }
        //max of to object
        private int MaxMax(int maxx, int maxy)
        {
            if (maxx < maxy)
            {
                return maxy;
            }
            return maxx;
        }
        //min of tor object
        private int MinMin(int minx, int miny)
        {
            if (minx < miny)
            {
                return minx;
            }
            return miny;
        }
        //Cropping and fitting image to correcttly map
        private Bitmap cropImage(Bitmap img, Rectangle cropArea)
        {
            int X = cropArea.X;
            int Y = cropArea.Y;
            int XX = cropArea.Width;
            int YY = cropArea.Height;


            Bitmap bmp = new Bitmap(Width, Height);
            using (Graphics gph = Graphics.FromImage(bmp))
            {
                gph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gph.DrawImage(img, new Rectangle(0, 0, Width, Height), new Rectangle(X, Y, XX, YY), GraphicsUnit.Pixel);
                gph.Dispose();
            }
            return bmp;
        }
        //Found of Min of X
        private int ImMinX(Bitmap Im)
        {
            int Mi = -1;
            for (int j = 0; j < Im.Width; j++)
            {
                for (int k = 0; k < Im.Height; k++)
                {


                    if (Equality(Im.GetPixel(j, k), Color.Black))
                    {
                        Mi = j;
                        break;
                    }
                }
                if (Mi > -1)
                {
                    break;
                }
            }
            return Mi;
        }
        //Founf Min of Y
        private int ImMinY(Bitmap Im)
        {
            int Mi = -1;

            for (int k = 0; k < Im.Height; k++)
            {
                for (int j = 0; j < Im.Width; j++)
                {

                    if (Equality(Im.GetPixel(j, k), Color.Black))
                    {
                        Mi = k;
                        break;
                    }
                }
                if (Mi > -1)
                {
                    break;
                }
            }
            return Mi;
        }
        //Found of Max Of Y
        private int ImMaxY(Bitmap Im)
        {
            int Ma = -1;
            for (int k = Im.Height - 1; k >= 0; k--)
            {
                for (int j = 0; j < Im.Width; j++)
                {


                    if (Equality(Im.GetPixel(j, k), Color.Black))
                    {
                        Ma = k;
                        break;
                    }
                }
                if (Ma > -1)
                {
                    break;
                }
            }
            return Ma;
        }
        //Found of Max of X
        private int ImMaxX(Bitmap Im)
        {
            int Ma = -1;

            //{
            for (int j = Im.Width - 1; j >= 0; j--)
            {
                for (int k = 0; k < Im.Height; k++)
                {
                    if ((Equality(Im.GetPixel(j, k), Color.Black)))
                    {
                        Ma = j;
                        break;
                    }
                }
                if (Ma > -1)
                {
                    break;
                }
            }
            return Ma;
        }
        bool Equality(Color a, Color b)
        {
            bool Is = false;
            if (a.G == b.G && a.B == b.B && a.R == b.R)
                Is = true;
            return Is;
        }
        bool[,] GetBolleanFromArgb(Bitmap Temp)
        {
            Color[,] TemI = new Color[Width, Height];
            bool[,] TemB = ZerosB();
            Color black = Color.Black;
            Graphics e = Graphics.FromImage(Temp);
            Color realColor = e.GetNearestColor(black);
            //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
            for (int k = 0; k < Width; k++)
            {
                for (int p = 0; p < Height; p++)
                {
                    object o = new object();
                    lock (o)
                    {
                        TemI[k, p] = Temp.GetPixel(k, p);

                    }
                }

            }
            e.Dispose();
            /*int Max = int.MinValue;
            for (int k = 0; k < Width; k++)
            {
                for (int p = 0; p < Height; p++)
                {
                    object o = new object();
                    lock (o)
                    {
                        if (TemI[k, p] > Max)
                        {
                            Max = TemI[k, p];
                        }
                    }
                }
            }*/
            for (int k = 0; k < Width; k++)
            {
                for (int p = 0; p < Height; p++)
                {
                    object o = new object();
                    lock (o)
                    {
                        if (!Equality(TemI[k, p], black)//(Max / 2)
                                        )
                        {
                            TemB[k, p] = false;
                        }
                        else
                        {
                            TemB[k, p] = true;
                        }
                    }
                }
            }
            return TemB;
        }
        bool[,] ZerosB()
        {
            bool[,] TemB = new bool[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    TemB[i, j] = false;
                }
            }
            return TemB;
        }
        int[,] ZerosI()
        {
            int[,] TemB = new int[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    TemB[i, j] = 0;
                }
            }
            return TemB;
        }
        //Create shape of conjuncted countor poins
        public bool CreateSAhapeFromConjucted(int Wi, int Hei)
        {
            //create shapes at list
            bool Do = ConjunctedShapeCreate(d);
            try
            {
                //when is true
                if (Do)
                {
                    //clear list
                    AllImage.Clear();
                    //for all items
                    for (int i = 0; i < All.Count; i++)
                    {
                        //retrive min and max of tow X and Y
                        //e.FillRectangle(Brushes.White, new Rectangle(0, 0, Mx, Mx));
                        Point[] tec = All[i].ToArray();
                        PointF[] te = new PointF[tec.Length];
                        for (int ii = 0; ii < te.Length; ii++)
                            te[ii] = new PointF(tec[ii].X, tec[ii].Y);
                        float MiX = MinX(te), MiY = MinY(te), MaX = MaxX(te), MaY = MaxY(te);

                        //centeralized
                        float MxM = (MaX - MiX) / 2;
                        float MyM = (MaY - MiY) / 2;
                        float Mx = MxM * 2;
                        float My = MyM * 2;
                        Bitmap Temp = new Bitmap(Width, Height);
                        Graphics e = Graphics.FromImage(Temp);
                        e.FillRectangle(Brushes.White, new Rectangle(0, 0,Width, Height));
                        //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        //initate new root image empty
                        if (!(MaX == MiX || MaY == MiY))
                        {
                            for (int ii = 0; ii < te.Length; ii++)
                            {
                                te[ii] = new PointF(te[ii].X - MiX, te[ii].Y - MiY);
                            }

                            MiX = MinX(te); MiY = MinY(te); MaX = MaxX(te); MaY = MaxY(te);

                            //centeralized
                            MxM = (MaX - MiX) / 2;
                            MyM = (MaY - MiY) / 2;
                            Mx = MxM * 2;
                            My = MyM * 2;
                            for (int ii = 0; ii < te.Length; ii++)
                            {
                                te[ii] = new PointF(((float)((Width) * te[ii].X) / (float)(MaX - MiX)), ((float)((Height) * te[ii].Y) / (float)(MaY - MiY)));
                            }
                            GraphicsPath path = new GraphicsPath();
                            //draw string
                             path.AddLines(te);

                            using (Pen pen = new Pen(Color.Black, 1))
                            {
                                e.DrawPath(pen, path);
                            }

                            e.Dispose();
                            MiX = ImMinX(Temp);
                            MiY = ImMinY(Temp);
                            MaX = ImMaxX(Temp);
                            MaY = ImMaxY(Temp);

                            //centeralized
                            MxM = (MaX - MiX) / 2;
                            MyM = (MaY - MiY) / 2;
                            Mx = MxM * 2;
                            My = MyM * 2;
                            //draw all points
                            if (Mx > My)
                            {
                                Bitmap Te = Temp;

                                //crop to proper space
                                //Te = cropImage(Temp, new Rectangle((int)MiX, (int)MiY, (int)(MaX - MiX), (int)(MaY - MiY)));


                                Do = HollowCountreImageCommmon(ref Te);
                                if (!Do)
                                    MessageBox.Show("fault on hollow!");

                                AllImage.Add(Te);
                            }
                            else
                            {
                                Bitmap Te = Temp;

                                //crop to proper space
                                //Te = cropImage(Temp, new Rectangle((int)MiX, (int)MiY, (int)(MaX - MiX), (int)(MaY - MiY)));

                                Do = HollowCountreImageCommmon(ref Te);
                                if (!Do)
                                    MessageBox.Show("fault on hollow!");


                                // AllImage.Add((Bitmap)Te.Clone());
                                AllImage.Add(Te);
                            }
                        }
                        else
                        {
                            Temp = new Bitmap(Width, Height);
                            e = Graphics.FromImage(Temp);
                            //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            e.FillRectangle(Brushes.White, new Rectangle(0, 0, Width, Height));
                            e.Dispose();
                            AllImage.Add((Bitmap)Temp.Clone());
                        }
                    }
                }
                else
                {
                    //when is not ready return unsuccessfull
                    return false;
                }
            }
            catch (Exception)
            {
                //when existence of exeption return unsuccessfull
                //System.Windows.Forms.MessageBox.Show("Fatual Error!" + t.ToString());
                return false;
            }
            //clear unneed and free memmory
            //All.Clear();
            //Collection.Clear();
            return true;
        }
        //Colorized list of image
        private bool ColorizedCountreImageCommon(List<Bitmap> Im)
        {
            try
            {
                //for all list items
                for (int i = 0; i < Im.Count; i++)
                {
                    //create graphics for current image
                    Graphics e = Graphics.FromImage(Im[i]);
                    //for all image width
                    for (int j = 0; j < Im[i].Width; j++)
                    {
                        //found of tow orthogonal detinated points
                        PointF[] Po = new PointF[2];
                        int nu = 0;
                        for (int k = 0; k < Im[i].Height; k++)
                        {
                            //first
                            if (nu == 0)
                            {
                                if (Im[i].GetPixel(j, k).ToArgb() == Color.Black.ToArgb())
                                {
                                    Po[0] = new PointF(j, k);
                                    nu++;
                                }
                            }
                            else//second
                            if (nu == 1)
                            {
                                if (Im[i].GetPixel(j, k).ToArgb() == Color.Black.ToArgb())
                                {
                                    Po[1] = new PointF(j, k);
                                    nu++;
                                    //draw linnes and free var to coninue
                                    e.DrawLines(Pens.Black, Po);
                                    nu = 0;
                                }
                            }
                        }
                    }
                    //Dispose
                    e.Dispose();
                }

            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
                //return unsuccessfull
                return false;
            }
            //return successfull
            return true;
        }
        //Colorized an image
        private bool ColorizedCountreImageCommmon(ref Bitmap Im)
        {
            try
            {
                //create graphics for current image
                Graphics e = Graphics.FromImage(Im);
                //for all image width
                for (int j = 0; j < Im.Width; j++)
                {
                    //found of tow orthogonal detinated points
                    Point[] Po = new Point[2];
                    int nu = 0;
                    for (int k = 0; k < Im.Height; k++)
                    {
                        //first
                        if (nu == 0)
                        {
                            if (Equality(Im.GetPixel(j, k) , Color.Black))
                            {
                                Po[0] = new Point(j, k);
                                nu++;
                            }
                        }
                        else//second
                        if (nu == 1)
                        {
                            if (Equality(Im.GetPixel(j, k) , Color.Black))
                            {
                                Po[1] = new Point(j, k);
                                nu++;
                                //draw linnes and free var to coninue
                                e.DrawLines(Pens.Black, Po);
                                nu = 0;
                            }
                        }
                    }
                }


            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
                return false;
            }
            return true;
        }
        //making  hollow and emptyy inside.
        private bool HollowCountreImageCommmon(ref Bitmap Im)
        {
            try
            {
                int wi = Im.Width;
                int he = Im.Height;

                List<Task> th = new List<Task>();
                Graphics e = Graphics.FromImage(Im);
                //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
                do
                {
                    Hollowed = false;

                    for (int x = 0; x < wi; x++)
                    {

                        for (int y = 0; y < he; y++)
                        {
                            object o = new object();
                            lock (o)
                            {
                                if (!Equality(Im.GetPixel(x, y), Color.White))
                                {
                                    bool Is = false;
                                    /*var H = Task.Factory.StartNew(() => HollowCountreImageCommmonXY(ref Im, x, y, wi, he, x, y, Ab));
                                    H.Wait();*/
                                    HollowCountreImageCommmonXY(ref Im, x, y, wi, he, x, y, ref Is);
                                }
                            }
                        }
                    }
                } while (Hollowed);
                e.Dispose();

            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
                return false;
            }
            return true;
        }
        //main sub method
        private bool HollowCountreImageCommmonXY(ref Bitmap Im, int x, int y, int wi, int he, int X, int Y, ref bool IsOut)
        {
            try
            {
                bool IsOut1 = false;
                bool IsOut2 = false;
                bool IsOut3 = false;
                bool IsOut4 = false;
                if (!(x >= 0 && y >= 0 && x < wi && y < he))
                {
                    return false;
                }

                bool Is = true;
                object o = new object();
                lock (o)
                {
                    if (!Equality(Im.GetPixel(X, Y), Color.White))
                    {






                        if (x + 1 < wi)
                        {

                            Is = Is && HollowCountreImageCommmonXYRigthX(ref Im, x + 1, y, wi, he, X, Y, ref IsOut1);

                        }




                        if (x - 1 >= 0)
                        {
                            Is = Is && HollowCountreImageCommmonXYLeftX(ref Im, x - 1, y, wi, he, X, Y, ref IsOut2);

                        }


                        if (y + 1 < he)
                        {

                            Is = Is && HollowCountreImageCommmonXYUpY(ref Im, x, y + 1, wi, he, X, Y, ref IsOut3);

                        }


                        if (y - 1 >= 0)
                        {

                            Is = Is && HollowCountreImageCommmonXYDowwnY(ref Im, x, y - 1, wi, he, X, Y, ref IsOut4);

                        }


                        object oo = new object();
                        lock (oo)
                        {
                            if (Is && (!Equality(Im.GetPixel(X, Y), Color.White)))
                            {
                                Im.SetPixel(X, Y, Color.White);
                                Hollowed = true;
                                return false;
                            }
                        }
                    }

                }
                IsOut = IsOut1 || IsOut2 || IsOut3 || IsOut4;
            }
            catch (Exception)
            {
                //MessageBox.Show(t.ToString());
                return false;
            }
            return true;
        }
        //sub method
        private bool HollowCountreImageCommmonXYRigthX(ref Bitmap Im, int x, int y, int wi, int he, int X, int Y, ref bool IsOut)
        {
            bool Is = false;
            try
            {
                if (!(x >= 0 && y >= 0 && x < wi && y < he))
                {
                    return false;
                }

                object o = new object();
                lock (o)
                {
                    if (!Equality(Im.GetPixel(X, Y), Color.White))
                    {
                        if ((x != X || y != Y))
                        {
                            if (!Equality(Im.GetPixel(x, y), Color.White))
                            {
                                Is = true;
                                return true;
                            }

                            if (Is)
                            {
                                return Is;
                            }

                            object ooo = new object();
                            lock (ooo)
                            {
                                if (x + 1 < wi)
                                {

                                    Is = Is || HollowCountreImageCommmonXYRigthX(ref Im, x + 1, y, wi, he, X, Y, ref IsOut);
                                    //Is = Is || HollowCountreImageCommmonXY(ref Im, x + 1, y, wi, he, X, Y, Ab, ref IsOut);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return Is;
        }
        //sub method
        private bool HollowCountreImageCommmonXYLeftX(ref Bitmap Im, int x, int y, int wi, int he, int X, int Y, ref bool IsOut)
        {

            bool Is = false;
            try
            {
                if (!(x >= 0 && y >= 0 && x < wi && y < he))
                {
                    return false;
                }

                object o = new object();
                lock (o)
                {
                    if (!Equality(Im.GetPixel(X, Y), Color.White))
                    {
                        if ((x != X || y != Y))
                        {
                            if (!Equality(Im.GetPixel(x, y), Color.White))
                            {
                                Is = true;
                                return true;
                            }

                            if (Is)
                            {
                                return Is;
                            }

                            object oioo = new object();
                            lock (oioo)
                            {
                                if (x - 1 >= 0)
                                {

                                    Is = Is || HollowCountreImageCommmonXYLeftX(ref Im, x - 1, y, wi, he, X, Y, ref IsOut);
                                    //Is = Is || HollowCountreImageCommmonXY(ref Im, x + 1, y, wi, he, X, Y, Ab, ref IsOut);
                                }
                            }
                        }
                    }
                    object oo = new object();
                    lock (oo)
                    {
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return Is;
        }
        //sub method
        private bool HollowCountreImageCommmonXYUpY(ref Bitmap Im, int x, int y, int wi, int he, int X, int Y, ref bool IsOut)
        {
            bool Is = false;
            try
            {
                if (!(x >= 0 && y >= 0 && x < wi && y < he))
                {
                    return false;
                }

                object o = new object();
                lock (o)
                {
                    if (!Equality(Im.GetPixel(X, Y), Color.White))
                    {
                        if ((x != X || y != Y))
                        {
                            if (!Equality(Im.GetPixel(x, y), Color.White))
                            {
                                Is = true;
                                return true;
                            }

                            if (Is)
                            {
                                return Is;
                            }

                            object pooo = new object();
                            lock (pooo)
                            {
                                if (y + 1 < he)
                                {

                                    Is = Is || HollowCountreImageCommmonXYUpY(ref Im, x, y - 1, wi, he, X, Y, ref IsOut);
                                    //Is = Is || HollowCountreImageCommmonXY(ref Im, x + 1, y, wi, he, X, Y, Ab, ref IsOut);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return Is;
        }
        //sub method
        private bool HollowCountreImageCommmonXYDowwnY(ref Bitmap Im, int x, int y, int wi, int he, int X, int Y, ref bool IsOut)
        {
            bool Is = false;
            try
            {
                if (!(x >= 0 && y >= 0 && x < wi && y < he))
                {
                    return false;
                }

                object o = new object();
                lock (o)
                {
                    if (!Equality(Im.GetPixel(X, Y), Color.White))
                    {
                        if ((x != X || y != Y))
                        {
                            if (!Equality(Im.GetPixel(x, y), Color.White))
                            {
                                Is = true;
                                return true;
                            }

                            if (Is)
                            {
                                return Is;
                            }

                            object pooo = new object();
                            lock (pooo)
                            {
                                if (y + 1 < he)
                                {

                                    Is = Is || HollowCountreImageCommmonXYDowwnY(ref Im, x, y + 1, wi, he, X, Y, ref IsOut);
                                    //Is = Is || HollowCountreImageCommmonXY(ref Im, x + 1, y, wi, he, X, Y, Ab, ref IsOut);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return Is;
        }
        //Create Conjuncted image
        private bool ConjunctedShapeCreate(MainForm d)
        {
            All.Clear();
            //Collection.Clear();
            try
            {
                //get counter points of foreign
                bool flag = true;
                using (List<Contour<Point>>.Enumerator enumerator1 = d.processor.contours.GetEnumerator())
                {
                    //do
                    do
                    {
                        //when is finished break
                        if (!flag)
                        {
                            break;
                        }
                        else
                        {
                            flag = false;
                        }
                        bool flag1 = false, flag2 = false;
                        //while
                        while (true)
                        {
                            //when there is not and is not empty at list
                            
                            //next enumerator
                            flag1 = enumerator1.MoveNext();
                            //when is finished break 
                            if (!flag1)
                            {

                                break;
                            }
                            //current target
                            Contour<Point> current1 = enumerator1.Current;
                            //current points
                            //Point[] PointP1 = current1.ToArray();
                            All.Add(current1);

                            //Collection.Add(current1);
                            flag2 = true;
                        }
                        if (flag2)
                        {
                        }
                        //Collection = new Contour<Point>();
                    } while (true);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
