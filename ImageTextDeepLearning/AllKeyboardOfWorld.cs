using ContourAnalysisDemo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ImageTextDeepLearning
{
    //To Store All Keyboard literals
    [Serializable]
    internal class AllKeyboardOfWorld
    {
        private bool Hollowed = false;
        public static List<string> fonts = new List<string>();
        public static char[] engsmal = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static char[] engbig = null;
        public static char[] engnum = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ' };

        private readonly char[] te = { 'a', '3', 'i', ' ' };
        public AllKeyboardOfWorld()
        {
            if (fonts.Count == 0)
            {
                fonts.Clear();
                bool Do = ListAllFonts();
                if (!Do)
                {
                    fonts.Clear();
                }
            }
        }
        //Initiate global vars
        private readonly int Width = 10, Height = 10;
        public List<string> KeyboardAllStringsWithfont = new List<string>();
        public List<string> KeyboardAllStrings = new List<string>();
        public List<Bitmap> KeyboardAllImage = new List<Bitmap>();
        public List<bool[,]> KeyboardAllConjunctionMatrix = new List<bool[,]>();
        //Crate all able chars on List indevidully
        public bool CreateString()
        {
            //when not existence
            if (KeyboardAllStrings.Count == 0)
            {
                //clear
                KeyboardAllStrings.Clear();
                try
                {
                    if (!FormImageTextDeepLearning.comeng && FormImageTextDeepLearning.test == false)
                    {   //for all possible
                        for (int i = 0; i < char.MaxValue; i++)
                        {
                            //get type of current
                            Type t = ((char)i).GetType();
                            //when is char and visible and is serializable
                            if (t.Equals(typeof(char)) && t.IsVisible && t.IsSerializable)
                            {
                                //if (((char)i).ToString().Contains("\\u"))
                                
                                //when existemnce of this conditions continue
                                int ch = i;
                                if ((ch >= 0x0020 && ch <= 0xD7FF) ||
                                        (ch >= 0xE000 && ch <= 0xFFFD) ||
                                        ch == 0x0009 ||
                                        ch == 0x000A ||
                                        ch == 0x000D)
                                {
                                    //sdetermine and Store
                                    if (!KeyboardAllStrings.Contains(((char)i).ToString()))
                                    {
                                        KeyboardAllStrings.Add(((char)i).ToString());
                                    }
                                }
                            }
                        }
                    }//speciall
                    else
                    {
                        //when list of english
                        if (FormImageTextDeepLearning.test == false)
                        {

                            for (int i = 0; i < engsmal.Length; i++)
                            {
                                KeyboardAllStrings.Add(Convert.ToString(engsmal[i]));
                            }
                            for (int i = 0; i < engsmal.Length; i++)
                            {
                                KeyboardAllStrings.Add(Convert.ToString(engsmal[i]).ToUpper());
                            }
                            for (int i = 0; i < engnum.Length; i++)
                            {
                                KeyboardAllStrings.Add(Convert.ToString(engnum[i]));
                            }
                        }
                        else//when test
                        {
                            try
                            {
                                if (File.Exists("KeyboardAllStrings.asd"))
                                {
                                    File.Delete("KeyboardAllStrings.asd");
                                }
                            }
                            catch (Exception)
                            {
                            }
                            for (int i = 0; i < te.Length; i++)
                            {
                                KeyboardAllStrings.Add(Convert.ToString(te[i]));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ListAllFonts()
        {
            try
            {
                if (FormImageTextDeepLearning.fontsel == false && FormImageTextDeepLearning.test == false)
                {
                    foreach (FontFamily font in System.Drawing.FontFamily.Families)
                    {
                        fonts.Add(font.Name);
                    }
                }
                else
                {
                    fonts.Add(FormImageTextDeepLearning.selfont.ToString());
                }
            }
            catch (Exception) { return false; }
            return true;
        }
        //Savle all
        private bool SaveAll()
        {
            try
            {
                //when file dos not exist
                if (!File.Exists("KeyboardAllStrings.asd"))
                {
                    
                    //serialized on take root
                    if (KeyboardAllImage.Count > 0)
                    {
                        Refrigtz.TakeRoot t = new Refrigtz.TakeRoot();
                        t.Save(this, "KeyboardAllStrings.asd");
                    }
                }
                else
                {//delete and serilized take root
                    File.Delete("KeyboardAllStrings.asd");
                    if (KeyboardAllImage.Count > 0)
                    {
                        Refrigtz.TakeRoot t = new Refrigtz.TakeRoot();
                        t.Save(this, "KeyboardAllStrings.asd");
                    }
                }
            }
            catch (Exception)
            {
                
            }
            return true;
        }
        //read all
        private bool ReadAll()
        {
            try
            {
                //when existence
                if (File.Exists("KeyboardAllStrings.asd"))
                {
                    //clear
                    KeyboardAllStrings.Clear();
                    KeyboardAllImage.Clear();
                    KeyboardAllConjunctionMatrix.Clear();

                    
                    //serilized
                    Refrigtz.TakeRoot tr = new Refrigtz.TakeRoot();
                    AllKeyboardOfWorld t = tr.Load("KeyboardAllStrings.asd");
                    KeyboardAllConjunctionMatrix = t.KeyboardAllConjunctionMatrix;
                    KeyboardAllConjunctionMatrix = t.KeyboardAllConjunctionMatrix;
                    KeyboardAllImage = t.KeyboardAllImage;
                    KeyboardAllStrings = t.KeyboardAllStrings;
                }
                else//others retiurn unsuccessfull
                {
                    return false;
                }
            }
            catch (Exception)
            {
                //when unsuccessfull return false
                return false;
            }
            //return true
            return true;
        }
        //Cropping and fitting image
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
        private int MinX(Bitmap Im)
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
        private int MinY(Bitmap Im)
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
        private int MaxY(Bitmap Im)
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
        private int MaxX(Bitmap Im)
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
        //Colorized list of image
        private bool ColorizedCountreImageCommon(List<Bitmap> Im)
        {
            try
            {
                //for all list items
                
                ///{
                for (int i = 0; i < Im.Count; i++)
                {
                    //create graphics for current image
                    Graphics e = Graphics.FromImage(Im[i]);
                    //for all image width
                    
                    //{
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
                                if ((Im[i].GetPixel(j, k).ToArgb() == Color.Black.ToArgb()))
                                {
                                    Po[0] = new PointF(j, k);
                                    nu++;
                                }
                            }
                            else//second
                            if (nu == 1)
                            {
                                if ((Im[i].GetPixel(j, k).ToArgb()==Color.Black.ToArgb()))
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
                                if (!Equality(Im.GetPixel(x, y) , Color.White))
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
                    if (!Equality(Im.GetPixel(X,Y) , Color.White))
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
                            if (Is && (!Equality(Im.GetPixel(X,Y) , Color.White)))
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
        GraphicsPath GetStringPath(string s, float dpi, RectangleF rect, Font font, StringFormat format)
        {
            GraphicsPath path = new GraphicsPath();
            // Convert font size into appropriate coordinates
            float emSize = dpi * font.SizeInPoints / 72;
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, rect, format);

            return path;
        }//store all strings list to proper  images themselves list
        public bool ConvertAllStringToImage(MainForm d)
        {
            try
            {
                bool Do = false;
                Do = CreateString();
                //when is not ok
                
                {
                    Do = true;
                }
                //when existence os string list and empty od image list
                if (Do && KeyboardAllImage.Count == 0)
                {
                    //clear
                    KeyboardAllImage.Clear();
                    //for all lists items
                    
                    //{
                    for (int i = 0; i < KeyboardAllStrings.Count; i++)
                    {
                        if (KeyboardAllStrings[i] != " ")
                        {
                            //For all font prototype
                            if (fonts.Count > 0)
                            {
                                //Do literal Database for All fonts
                                
                                //{
                                for (int h = 0; h < fonts.Count; h++)
                                {   //proper empty image coinstruction object
                                    Bitmap Temp = new Bitmap(Width, Height);
                                    //initate new root image empty
                                    //create proper image graphics
                                    Graphics e = Graphics.FromImage(Temp);
                                    //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                    //Draw fill white image
                                    e.FillRectangle(Brushes.White, new Rectangle(0, 0, Width, Height));

                                   using (FontFamily font_family = new FontFamily(Convert.ToString(fonts[0].Substring(fonts[0].IndexOf("=") + 1, fonts[0].IndexOf(",") - (fonts[0].IndexOf("=") + 1)))))
                                    {
                                        using (StringFormat sf = new StringFormat())
                                        {
                                            sf.Alignment = StringAlignment.Center;
                                            sf.LineAlignment = StringAlignment.Center;
                                            float dpi = e.DpiY;
                                            using (GraphicsPath path = GetStringPath(Convert.ToString(KeyboardAllStrings[i]), dpi, new Rectangle(0, 0, Width, Height), new Font(font_family, 12, FontStyle.Bold, GraphicsUnit.Pixel), sf))
                                            {
                                                using (Pen pen = new Pen(Color.Black, 1))
                                                {
                                                    e.DrawPath(pen, path);
                                                }
                                            }
                                        }
                                    }

                                    //retrive min and max of tow X and Y
                                    int MiX = MinX(Temp), MiY = MinY(Temp), MaX = MaxX(Temp), MaY = MaxY(Temp);
                                    int MxM = (MaX - MiX) / 2;
                                    int MyM = (MaY - MiY) / 2;
                                    int Mx = MxM * 2;
                                    int My = MyM * 2;
                                    Bitmap Te = Temp;
                                    e.Dispose();
                                    //crop to proper space



                                    //crop to proper space
                                    //Te = cropImage(Temp, new Rectangle((int)MiX, (int)MiY, (int)(MaX - MiX), (int)(MaY - MiY)));


                                    Do = HollowCountreImageCommmon(ref Te);
                                    if (!Do)
                                        MessageBox.Show("fault on hollow!");
                                    //create proper conjunction matrix
                                    bool[,] Tem = GetBolleanFromArgb(Te);
                                    KeyboardAllImage.Add(Te);
                                    KeyboardAllConjunctionMatrix.Add(Tem);
                                    KeyboardAllStringsWithfont.Add(KeyboardAllStrings[i]);
                                     
                                }
                            }
                            else//When font not installed
                            {
                                //proper empty image coinstruction object
                                Bitmap Temp = new Bitmap(Width, Height);
                                //create proper image graphics
                                Graphics e = Graphics.FromImage(Temp);
                                //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                //Draw fill white image
                                e.FillRectangle(Brushes.White, new Rectangle(0, 0, Width, Height));
                                //draw string
                                //draw string

                                using (FontFamily font_family = new FontFamily(Convert.ToString(fonts[0].Substring(fonts[0].IndexOf("=") + 1, fonts[0].IndexOf(",") - (fonts[0].IndexOf("=") + 1)))))
                                {
                                    using (StringFormat sf = new StringFormat())
                                    {
                                        sf.Alignment = StringAlignment.Center;
                                        sf.LineAlignment = StringAlignment.Center;
                                        float dpi = e.DpiY;
                                        using (GraphicsPath path = GetStringPath(Convert.ToString(KeyboardAllStrings[i]), dpi, new Rectangle(0, 0, Width, Height), new Font(font_family, 12, FontStyle.Bold, GraphicsUnit.Pixel), sf))
                                        {
                                            using (Pen pen = new Pen(Color.Black, 1))
                                            {
                                                e.DrawPath(pen, path);
                                            }
                                        }
                                    }
                                }

                                //retrive min and max of tow X and Y
                                int MiX = MinX(Temp), MiY = MinY(Temp), MaX = MaxX(Temp), MaY = MaxY(Temp);
                                int MxM = (MaX - MiX) / 2;
                                int MyM = (MaY - MiY) / 2;
                                int Mx = MxM * 2;
                                int My = MyM * 2;
                                Bitmap Te = Temp;
                                e.Dispose();


                                //crop to proper space
                                //Te = cropImage(Temp, new Rectangle((int)MiX, (int)MiY, (int)(MaX - MiX), (int)(MaY - MiY)));



                                Do = HollowCountreImageCommmon(ref Te);
                                if (!Do)
                                    MessageBox.Show("fault on hollow!");

                                //create proper conjunction matrix
                                //create proper conjunction matrix
                                bool [,] Tem = GetBolleanFromArgb(Te);
                                KeyboardAllImage.Add(Te);
                                KeyboardAllConjunctionMatrix.Add(Tem);
                                KeyboardAllStringsWithfont.Add(KeyboardAllStrings[i]);
                            }
                        }
                        else
                        {
                            Bitmap Temp = new Bitmap(Width, Height);
                            //initate new root image empty
                            //create proper image graphics
                            Graphics e = Graphics.FromImage(Temp);
                            //Draw fill white image
                            e.FillRectangle(Brushes.White, new Rectangle(0, 0, Width, Height));
                            //e.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            e.Dispose();
                            bool[,] Tem = ZerosB();
                            for (int k = 0; k < Width; k++)
                            {
                                for (int p = 0; p < Height; p++)
                                {
                                    object o = new object();
                                    lock (o)
                                    {
                                        
                                            Tem[k, p] = false;
                                        
                                    }
                                }
                            }
                            KeyboardAllImage.Add(Temp);
                            KeyboardAllConjunctionMatrix.Add(Tem);
                            KeyboardAllStringsWithfont.Add(KeyboardAllStrings[i]);
                       
                        }
                    }
                    
                }
                //else
                
            }
            catch (Exception)
            {
                
                //when existence of exeptio return false
                
                return false;
            }
            //return successfulll
            
            return true;
        }
        //Convert image list to conjunction matrix
        public bool ConvertAllTempageToMatrix(List<Bitmap> TempI)
        {
            try
            {
                //when list is empty
                KeyboardAllConjunctionMatrix.Clear();
                if (KeyboardAllConjunctionMatrix.Count == 0)
                {
                      for (int i = 0; i < TempI.Count; i++)
                    {
                        //matrix boolean object constructor list
                        //create proper conjunction matrix
                        bool[,] Tem = GetBolleanFromArgb(TempI[i]);

                        //add
                        KeyboardAllImage.Add(TempI[i]);
                        KeyboardAllConjunctionMatrix.Add(Tem);
                     }
                }
                else//othewise return successfull
                {
                    return true;
                }
            }
            catch (Exception)
            {
                
                //when is exeption return unsuccessfull
                return false;
            }
            //when save is not valid return successfull
            
            //return successfull
            return true;
        }
    }
}
