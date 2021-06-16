using howto_WPF_3D_triangle_normalsuser;
using Point3Dspaceuser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace WindowsApplication1
{

    public partial class Form1 : Form
    {
        
        public static int stkin = 0;
        List<Form1> Stk = new List<Form1>();
        List<Image> StkIm = new List<Image>();
        List<bool> Stkch = new List<bool>();
        List<string> Stklb = new List<string>();
        List<string> Stktx= new List<string>();




        public bool Strong = false;
        int count = 1250 * System.Threading.PlatformHelper.ProcessorCount;
        //int count = 125 * System.Threading.PlatformHelper.ProcessorCount;
        bool go = false;
        bool[,] curvedallpoints = null;

        float[] region = null;
        float[] r = null;
        float[] teta = null;
        int rlen = 0;
        List<Point2D> outsidecurved = new List<Point2D>();
        const int penratio = 400000;
        PointF[] curvedline = new PointF[100000];
        int curvedlinelen = 0;
        bool curved = false;
        public bool Reducedinteligent = false;

        bool mouseclick = false;
        long time = (DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond;

        Image at;
        bool Colorset = false;
        double percent = 0.5;
        bool elim = false;
        public _2dTo3D a = null;
        int Kind = 0;
        float xp0 = 0, yp0 = 0, xp1 = 0, yp1 = 0, xp2 = 0, yp2 = 0, xp3 = 0, yp3 = 0;
        float xz0 = 0, yz0 = 0, xz1 = 0, yz1 = 0, xz2 = 0, yz2 = 0, xz3 = 0, yz3 = 0;
        float xs0 = 0, ys0 = 0, xs1 = 0, ys1 = 0, xs2 = 0, ys2 = 0;// xs3 = 0, ys3 = 0;
        float xb0 = 0, yb0 = 0, xb1 = 0, yb1 = 0, xb2 = 0, yb2 = 0, xb3 = 0, yb3 = 0;
        float xe0 = 0, ye0 = 0, xe1 = 0, ye1 = 0;
        float xr0 = 0, yr0 = 0, xr1 = 0, yr1 = 0;
        float xm = 0, ym = 0;
        float XP = 0, YP = 0;
        int ColorBox = 0;
        float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep = 0;
        private float xprin, yprin;
        bool[] outcode0, outcode1, outcodeOut = new bool[4];
        Shape2D Node = new Shape2D();
        Shape2D Sh = new Shape2D();
        static int ClickMouse = -1;
        bool DrawLine = false;
        bool[] SetValue = new bool[3];
        bool[] SetValueforBezier = new bool[4];
        bool MoveAllow = false;
        bool Trans = false;

        static int ArcCount = 0;
        static int LineCount = 0;
        static int BezierCount = 0;
        static int EllipseCount = 0;
        static int RectangleCount = 0;
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    //Write to File.
                    File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString());
                }
            }

            catch (Exception t) { }

        }
        void push()
        {
            Stk.Add(this);
            StkIm.Add((Image)pictureBox24.Image.Clone());
            Stklb.Add(label4.Text);
            Stktx.Add(textBox1.Text);
            Stkch.Add(checkBox1.Checked);
            stkin = Stk.Count - 1;
       }
        bool PushPop(bool pu)
        {
           bool ass = false;
            if (pu)
                ass = (stkin  < Stk.Count);
            else
                ass = stkin >= 0;

            if (ass )
            {
                Form1 th = Stk[stkin ];
                Strong = th.Strong;

                count = th.count;

                go = th.go;
                curvedallpoints = th.curvedallpoints;

                rlen = th.rlen;
                outsidecurved = th.outsidecurved;
                curvedline = th.curvedline;
                curvedlinelen = th.curvedlinelen;
                curved = th.curved;
                Reducedinteligent = th.Reducedinteligent;

                mouseclick = th.mouseclick;
                time = th.time;

                at = th.at;
                Colorset = th.Colorset;
                percent = th.percent;
                elim = th.elim;
                _2dTo3D a = th.a;
                Kind = th.Kind;
                xp0 = th.xp0; yp0 = th.yp0; xp1 = th.xp1; yp1 = th.yp1; xp2 = th.xp2; yp2 = th.yp2; xp3 = th.xp3; yp3 = th.yp3;
                xz0 = th.xz0; yz0 = th.yz0; xz1 = th.xz1; yz1 = th.yz1; xz2 = th.xz2; yz2 = th.yz2; xz3 = th.xz3; yz3 = th.yz3;
                xs0 = th.xs0; ys0 = th.ys0; xs1 = th.xs1; ys1 = th.ys1; xs2 = th.xs2; ys2 = th.ys2;// xs3 = 0, ys3 = 0;
                xb0 = th.xb0; yb0 = th.yb0; xb1 = th.xb1; yb1 = th.yb1; xb2 = th.xb2; yb2 = th.yb2; xb3 = th.xb3; yb3 = th.yb3;
                xe0 = th.xe0; ye0 = th.ye0; xe1 = th.xe1; ye1 = th.ye1;
                xr0 = th.xr1; yr0 = th.yr0; xr1 = th.xr1; yr1 = th.yr1;
                xm = th.xm; ym = th.ym;
                XP = th.XP; YP = th.YP;
                ColorBox = th.ColorBox;
                R = th.R; P = th.P; N = th.N; TetaStart = th.TetaStart; TetaSweep = th.TetaSweep;
                xprin = th.xprin; yprin = th.yprin;
                outcode0 =th.outcode0; outcode1 = th.outcode1; outcodeOut = th.outcodeOut;
                Node = th.Node;
                Sh = th.Sh;
                DrawLine = false;
                SetValue = th.SetValue;
                SetValueforBezier = th.SetValueforBezier;
                MoveAllow = th.MoveAllow;
                Trans = th.Trans;
                return true;
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Transmition(object sender, float x, float y, float tx, float ty)
        {
            xprin = x + tx;
            yprin = y + ty;
        }
        private void Rotation(object sender, float x, float y, float tx, float Teta)
        {
            xprin = x * (float)(System.Math.Cos(Teta)) - y * (float)(System.Math.Cos(Teta));
            yprin = y * (float)(System.Math.Cos(Teta)) + y * (float)(System.Math.Cos(Teta));
        }
        private void Scaling(object sender, float x, float y, float sx, float sy)
        {
            xprin = x * sx;
            yprin = y * sy;
        }
        private void MirrorX(object sender, float x, float y)
        {
            xprin = x;
            yprin = -1 * y;
        }
        private void MirrorY(object sender, float x, float y)
        {
            xprin = -1 * x;
            yprin = y;
        }
        private void InversionTransmision(object sender, float x, float y, float tx, float ty)
        {
            xprin = x - tx;
            xprin = y - ty;
        }
        private void InversionRotation(object sender, float x, float y, float Teta)
        {
            xprin = x * (float)(System.Math.Cos(Teta)) + y * (float)(System.Math.Cos(Teta));
            yprin = y * (float)(System.Math.Cos(Teta)) - y * (float)(System.Math.Cos(Teta));
        }
        private void InversionScalling(object sender, float x, float y, float sx, float sy)
        {
            xprin = x / sx;
            yprin = y / sy;
        }
        private void CohenSutherlandLineClipAndDraw(object sender, float x0, float y0, float x1, float y1, float xmin, float xmax, float ymin, float ymax, int value)
        {
            //Cohne-sutherland clipping algorithm for line P0=(x0,y0) to p!=(x1,y!)
            //and clip rectangle with diagonal from (xmin,ymin) to (xmax,ymax).
            //bool accept,done;
            float x = 0, y = 0;
            bool done;
            //accept = false;
            done = false;
            CompOutCode(x0, y0, xmin, xmax, ymin, ymax, ref outcode0); CompOutCode(x1, y1, xmin, xmax, ymin, ymax, ref outcode1);
            do
            {
                if (outcode0[0] == false && outcode0[1] == false && outcode0[2] == false && outcode0[3] == false && outcode1[0] == false && outcode1[1] == false && outcode1[2] == false && outcode1[3] == false)
                {
                    //accept = true;
                    done = true;
                }
                if ((outcode0[0] & outcode1[0] == false) && (outcode0[1] & outcode1[1] == false) && (outcode0[2] & outcode1[2] == false) && (outcode0[3] & outcode1[3] == false))
                    done = true;
                else
                {
                    /*Failed both test,so calculate the line segment to clip;
                     from an outside point to an intersection with clip edge.*/
                    if (!(outcode0[0] == false && outcode0[1] == false && outcode0[2] == false && outcode0[3] == false))
                        outcodeOut = outcode0;
                    else
                        outcodeOut = outcode1;
                    /*Now find intersection point;
                     use formulas y=y0+slope*(x-x0),x=x0+(1/slope)*(y-y0).*/
                    if (outcodeOut[3])
                    {//Divide line at top of clip rectangle
                        x = x0 + (x1 - x0) * (ymax - y0) / (y1 - y0);
                        y = ymax;
                    }
                    if (outcodeOut[2])//Divide line at bottom of clip rectangle
                    {
                        x = x0 + (x1 - x0) * (ymin - y0) / (y1 - y0);
                        y = ymax;
                    }
                    else if (outcodeOut[1])//Divide line at right edge of clip rectangle
                    {
                        y = y0 + (y1 - y0) * (xmax - x0) / (x1 - x0);
                        x = xmax;
                    }
                    else if (outcodeOut[0])//Divide line at left edge of clip rectangle
                    {
                        y = y0 + (y1 - y0) * (xmin - x0) / (x1 - x0);
                        x = xmin;
                    }
                    /*Now we move outside point to intersection point to clip,
                    and get ready for next pass*/
                    if (outcodeOut == outcode0)
                    {
                        x0 = x;
                        y0 = y;
                    }
                    else
                    {
                        x1 = x;
                        y1 = y;
                    }
                }
            } while (!done);
            //if accept then Draw line.
        }
        private void CompOutCode(float x, float y, float xmin, float xmax, float ymin, float ymax, ref bool[] code)
        {
            for (int i = 0; i < 4; i++)
                code[i] = false;
            if (y > ymax) code[3] = true;
            else if (y < ymin) code[2] = true;
            if (x > xmax) code[0] = true;
            else if (x < xmin) code[0] = true;
        }
        private void aRCToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 1;
        }
        private void mirroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Click(object sender, EventArgs e)
        {//This method gets MousePoision.
        }

        private void aRCToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {

            //Shape2D Set = new Shape2D();
            if (ClickMouse == 0)
                DrawLine = false;
            if (ClickMouse == 1)
                DrawLine = true;
            ClickMouse++;
            if (ClickMouse != 1)
                if (Kind == 3)
                {
                    xp0 = xp1;
                    yp0 = yp1;
                }
            xprin = this.PointToClient(Control.MousePosition).X;
            yprin = this.PointToClient(Control.MousePosition).Y;
            //The Mouse Click event;
            if (!MoveAllow)
            {
                if ((Kind != 4) & (Kind != 5))
                {
                    if (ClickMouse == 1)
                    {
                        xp0 = xprin;
                        yp0 = yprin;
                    }
                    if (DrawLine)
                    {
                        xp1 = xprin;
                        yp1 = yprin;
                        if (ClickMouse == 2)
                        {
                            DrawLine = false;
                            //The Second Point is Setting
                            xs1 = xp1;
                            ys1 = yp1;
                        }
                    }
                }
                else
                if (ClickMouse == 1)
                {
                    xp0 = xprin;
                    yp0 = yprin;
                }
            }
        }
        private void aRCToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            ClickMouse++;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.DrawExistShape(sender);

            if (Kind == 1)
                this.ArcDraw(sender, this.DetermineColor(sender));
            if (Kind == 2)
                this.LineDraw(sender, this.DetermineColor(sender));
            if (Kind == 3)
                this.LineForBezierDraw(sender, this.DetermineColor(sender));
            if (Kind == 4)
                this.EllipseDraw(sender);
            if (Kind == 5)
                this.RectangleDraw(sender);
            if (Kind == 6)
                this.Pen(sender);
            if ((ClickMouse == 1) || (ClickMouse == 2))
                if (MoveAllow)
                    this.MoveAll(sender);
            if (Trans)
                this.TransOperation(sender);
            this.DrawExistShape(sender);
        }
        private void ArcDraw(object sender, Pen p)
        {
            if (ClickMouse == 1)
                this.LineDraw(sender, this.DetermineColor(sender));
            if (ClickMouse == 2)
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Color.White);
                xp2 = this.PointToClient(Control.MousePosition).X;
                yp2 = this.PointToClient(Control.MousePosition).Y;
                R = (float)System.Math.Sqrt(System.Math.Pow((xp1 - xp0), 2) + System.Math.Pow((yp1 - yp0), 2));
                P = (float)System.Math.Sqrt(System.Math.Pow((xp2 - xp0), 2) + System.Math.Pow((yp2 - yp0), 2));
                N = (float)System.Math.Sqrt(System.Math.Pow((xp1 - xp2), 2) + System.Math.Pow((yp1 - yp2), 2));
                TetaStart = (float)((180 / 3.14) * (System.Math.Atan((yp1 - yp0) / (xp1 - yp0))));
                TetaSweep = (float)((180 / 3.14) * System.Math.Acos(((System.Math.Pow(R, 2)) + (System.Math.Pow(P, 2)) - (System.Math.Pow(N, 2))) / (2 * R * P)));
                g.DrawArc(this.DetermineColor(sender), xp0, yp0, (float)System.Math.Abs(xp1 - xp0), (float)System.Math.Abs(yp1 - yp0), TetaStart, TetaSweep);
            }
            //The thirth point is setting.
            if (ClickMouse == 4)
            {
                xs2 = xp2;
                ys2 = yp2;
                xs1 = xs1 + xp3;
                ys1 = ys1 + yp3;
            }
            if (Kind == 1)
                if (ClickMouse == 3)
                {
                    xp3 = this.PointToClient(Control.MousePosition).X - xp0;
                    yp3 = this.PointToClient(Control.MousePosition).Y - yp0;
                    Graphics g = this.CreateGraphics();
                    g.Clear(Color.White);
                    //g.DrawArc(this.DetermineColor(sender), xp0, yp0, (float)System.Math.Abs(xp1+xp3 - xp0), (float)System.Math.Abs(yp1+yp3 - yp0), TetaStart, TetaSweep);                                 
                    g.DrawArc(this.DetermineColor(sender), xp0, yp0, (float)System.Math.Abs(xp1 + xp3 - xp0), (float)System.Math.Abs(yp1 + yp3 - yp0), TetaStart, TetaSweep);
                }
            if (Kind == 1)
                if (ClickMouse == 4)
                {
                    Shape2D Sh = new Shape2D(1, xs0, ys0, xs1, ys1, xs2, ys2, 0, 0);
                    this.GetShapeLast(sender).Start2D = Sh;
                    Sh.Redraw = true;
                    Sh.Name = "Arc" + System.Convert.ToSingle(ArcCount);
                    ArcCount++;
                    comboBox1.Items.Add(Sh.Name);
                    ClickMouse = 0;
                    Kind = 0;
                    //SetColor
                    Sh.Pc = this.DetermineColor(sender);

                }
            //
        }
        private void LineDraw(object sender, Pen p)
        {
            xp1 = this.PointToClient(Control.MousePosition).X;
            yp1 = this.PointToClient(Control.MousePosition).Y;
            //The First point Setting for redraw
            xs0 = xp0;
            ys0 = yp0;
            Graphics g = this.CreateGraphics();
            if (ClickMouse == 1)
            {
                if (ClickMouse != 2)
                    g.Clear(Color.White);
                g.DrawLine(this.DetermineColor(sender), xp0, yp0, xp1, yp1);
            }
            if (Kind == 2)
                if (ClickMouse == 2)
                {
                    xs1 = xp1;
                    ys1 = yp1;
                    Shape2D Sh = new Shape2D(2, xs0, ys0, xs1, ys1, 0, 0, 0, 0);
                    this.GetShapeLast(sender).Start2D = Sh;
                    Sh.Name = "Line" + System.Convert.ToSingle(LineCount);
                    Sh.Redraw = true;
                    LineCount++;
                    comboBox1.Items.Add(Sh.Name);
                    ClickMouse = 0;
                    Kind = 0;
                    Sh.Pc = this.DetermineColor(sender);
                }
        }
        private void LineForBezierDraw(object sender, Pen p)
        {
            xp1 = this.PointToClient(Control.MousePosition).X;
            yp1 = this.PointToClient(Control.MousePosition).Y;
            Graphics g = this.CreateGraphics();
            if (ClickMouse == 1)
            {
                xb0 = xp0;
                yb0 = yp0;
                g.Clear(Color.White);
                g.DrawLine(this.DetermineColor(sender), xb0, yb0, xp1, yp1);
            }
            else
            if (ClickMouse == 2)
            {
                //            xs1 = xp0;
                //          ys1 = yp0;
                xb1 = xp0;
                yb1 = yp0;
                g.Clear(Color.White);
                xp1 = this.PointToClient(Control.MousePosition).X;
                yp1 = this.PointToClient(Control.MousePosition).Y;
                g.DrawLine(this.DetermineColor(sender), xb0, yb0, xb1, yb1);
                g.DrawLine(this.DetermineColor(sender), xb1, yb1, xp1, yp1);
            }
            else
                if (ClickMouse == 3)
            {
                //xs2 = xp0;
                //ys2 = yp0;
                xb2 = xp0;
                yb2 = yp0;
                g.Clear(Color.White);
                xp1 = this.PointToClient(Control.MousePosition).X;
                yp1 = this.PointToClient(Control.MousePosition).Y;
                g.DrawLine(this.DetermineColor(sender), xb0, yb0, xb1, yb1);
                g.DrawLine(this.DetermineColor(sender), xb1, yb1, xb2, yb2);
                g.DrawLine(this.DetermineColor(sender), xb2, yb2, xp1, yp1);
            }
            else
                   if (ClickMouse == 4)
            {
                //  xs3 = xp0;
                //ys3 = yp0;
                xb3 = xp0;
                yb3 = yp0;
                g.Clear(Color.White);
                xp1 = this.PointToClient(Control.MousePosition).X;
                yp1 = this.PointToClient(Control.MousePosition).Y;
                g.DrawLine(p, xb0, yb0, xb1, yb1);
                g.DrawLine(p, xb1, yb1, xb2, yb2);
                g.DrawLine(p, xb2, yb2, xb3, yb3);
                g.Clear(Color.White);
                g.DrawBezier(this.DetermineColor(sender), xb0, yb0, xb1, yb1, xb2, yb2, xb3, yb3);
            }
            if (Kind == 3)
                if (ClickMouse == 4)
                {
                    Shape2D Sh = new Shape2D(3, xb0, yb0, xb1, yb1, xb2, yb2, xb3, yb3);
                    this.GetShapeLast(sender).Start2D = Sh;
                    Sh.Start2D = null;
                    Sh.Name = "Bezier" + System.Convert.ToSingle(BezierCount);
                    Sh.Redraw = true;
                    BezierCount++;
                    comboBox1.Items.Add(Sh.Name);
                    Kind = 0;
                    ClickMouse = 0;
                    Sh.Pc = this.DetermineColor(sender);
                }

        }
        private void BezierDraw(object sender)
        {
            Graphics g = this.CreateGraphics();
            this.LineForBezierDraw(sender, this.DetermineColor(sender));
            if (ClickMouse == 4)
                g.DrawBezier(this.DetermineColor(sender), xp0, yp0, xp1, yp1, xp2, yp2, xp3, yp3);


        }
        private void EllipseDraw(object sender)
        {
            Graphics g = this.CreateGraphics();
            if (ClickMouse == 1)
            {
                xp1 = this.PointToClient(Control.MousePosition).X - 80;
                yp1 = this.PointToClient(Control.MousePosition).Y - 80;
                g.Clear(Color.White);
                g.DrawEllipse(this.DetermineColor(sender), (int)xp0, (int)yp0, xp1, yp1);
            }
            if (ClickMouse == 2)
            {
                xp0 = this.PointToClient(Control.MousePosition).X - 80;
                yp0 = this.PointToClient(Control.MousePosition).Y - 80;
                g.Clear(Color.White);
                g.DrawEllipse(this.DetermineColor(sender), (int)xp0, (int)yp0, xp1, yp1);
            }
            if (Kind == 4)
                if (ClickMouse == 3)
                {
                    Shape2D Sh = new Shape2D(4, xp0, yp0, xp1, yp1, 0, 0, 0, 0);
                    this.GetShapeLast(sender).Start2D = Sh;
                    Sh.Name = "Ellipse" + System.Convert.ToSingle(EllipseCount);
                    Sh.Redraw = true;
                    EllipseCount++;
                    comboBox1.Items.Add(Sh.Name);
                    Kind = 0;
                    ClickMouse = 0;
                    Sh.Pc = this.DetermineColor(sender);
                }

        }
        private void RectangleDraw(object sender)
        {
            Graphics g = this.CreateGraphics();
            if (ClickMouse == 1)
            {
                xp1 = (this.PointToClient(Control.MousePosition).X) - 50;
                yp1 = (this.PointToClient(Control.MousePosition).Y) - 50;
                g.Clear(Color.White);
                g.DrawRectangle(this.DetermineColor(sender), xp0, yp0, xp1, yp1);
            }
            if (ClickMouse == 2)
            {
                xp0 = (this.PointToClient(Control.MousePosition).X) - 50;
                yp0 = (this.PointToClient(Control.MousePosition).Y) - 50;
                g.Clear(Color.White);
                g.DrawRectangle(this.DetermineColor(sender), xp0, yp0, xp1, yp1);
            }
            if (Kind == 5)
                if (ClickMouse == 3)
                {
                    Shape2D Sh = new Shape2D(5, xp0, yp0, xp1, yp1, 0, 0, 0, 0);
                    this.GetShapeLast(sender).Start2D = Sh;
                    Sh.Name = "Rectangle" + System.Convert.ToSingle(RectangleCount);
                    Sh.Redraw = true;
                    RectangleCount++;
                    comboBox1.Items.Add(Sh.Name);
                    Kind = 0;
                    ClickMouse = 0;
                    Sh.Pc = this.DetermineColor(sender);
                }


        }
        private void Pen(object sender)
        {
            Point2D PoS = new Point2D();
            Graphics g = this.CreateGraphics();
            xprin = this.PointToClient(Control.MousePosition).X;
            yprin = this.PointToClient(Control.MousePosition).Y;
            //System.Drawing.Pen Pn=new Pen(xprin,yprin);
            g.DrawLine(this.DetermineColor(sender), xprin, yprin, (float)(xprin + 0.5), (float)(yprin + 0.5));
            g.DrawLine(this.DetermineColor(sender), xprin, yprin, (float)(xprin + 0.5), (float)(yprin - 0.5));
            g.DrawLine(this.DetermineColor(sender), xprin, yprin, (float)(xprin - 0.5), (float)(yprin + 0.5));
            g.DrawLine(this.DetermineColor(sender), xprin, yprin, (float)(xprin - 0.5), (float)(yprin - 0.5));
            Point2D Po = new Point2D(xprin, yprin);
            PoS = Sh.StartPoint2D;
            if (PoS != null)
                while (PoS.StartPoint2D != null)
                    PoS = PoS.StartPoint2D;
            PoS = Po;
            Po.StartPoint2D = null;
            if (ClickMouse == 2)
            {
                ClickMouse = 0;
                Kind = 0;
            }


        }
        private void DrawPath(object sender, Pen p)
        {
            Graphics g = this.CreateGraphics();

        }
        private void DrawExistShape(object sender)
        {

            Shape2D Start = new Shape2D();
            Start = Node;
            Graphics g = this.CreateGraphics();
            while (Start != null)
            {

                if (Start.Shap == Shape2D.Shape.Arc)
                {
                    //Point2D Dimension = new Point2D();
                    //Dimension = Start.
                    if (Start.Redraw)
                    {
                        if (Start != null)
                        {
                            xz0 = Start.StartPoint2D.GetX();
                            yz0 = Start.StartPoint2D.GetY();
                            xz1 = Start.StartPoint2D.StartPoint2D.GetX();
                            yz1 = Start.StartPoint2D.StartPoint2D.GetY();
                            xz2 = Start.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                            yz2 = Start.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                            float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep;
                            R = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz0), 2) + System.Math.Pow((yz1 - yz0), 2));
                            P = (float)System.Math.Sqrt(System.Math.Pow((xz2 - xz0), 2) + System.Math.Pow((yz2 - yz0), 2));
                            N = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz2), 2) + System.Math.Pow((yz1 - yz2), 2));
                            TetaStart = (float)((180 / 3.14) * (System.Math.Atan((yz1 - yz0) / (xz1 - yz0))));
                            TetaSweep = (float)((180 / 3.14) * System.Math.Acos(((System.Math.Pow(R, 2)) + (System.Math.Pow(P, 2)) - (System.Math.Pow(N, 2))) / (2 * R * P)));
                            g.DrawArc(Start.Pc, xz0, yz0, (float)System.Math.Abs(xz1 - xz0), (float)System.Math.Abs(yz1 - yz0), TetaStart, TetaSweep);
                        }
                    }
                }
                if (Start.Shap == Shape2D.Shape.Line)
                {
                    if (Start.Redraw)
                    {
                        if (Start != null)
                        {
                            xz0 = Start.StartPoint2D.GetX();
                            yz0 = Start.StartPoint2D.GetY();
                            xz1 = Start.StartPoint2D.StartPoint2D.GetX();
                            yz1 = Start.StartPoint2D.StartPoint2D.GetY();
                            g.DrawLine(Start.Pc, xz0, yz0, xz1, yz1);
                        }
                    }
                }
                if (Start.Shap == Shape2D.Shape.Bezier)
                {
                    //Point2D Dimension = new Point2D();
                    //Dimension = Start.
                    if (Start.Redraw)
                    {
                        if (Start != null)
                        {
                            xz0 = Start.StartPoint2D.GetX();
                            yz0 = Start.StartPoint2D.GetY();
                            xz1 = Start.StartPoint2D.StartPoint2D.GetX();
                            yz1 = Start.StartPoint2D.StartPoint2D.GetY();
                            xz2 = Start.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                            yz2 = Start.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                            xz3 = Start.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                            yz3 = Start.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                            g.DrawBezier(Start.Pc, xz0, yz0, xz1, yz1, xz2, yz2, xz3, yz3);
                        }
                    }
                }
                if (Start.Shap == Shape2D.Shape.Ellipse)
                {
                    //Point2D Dimension = new Point2D();
                    //Dimension = Start.
                    if (Start.Redraw)
                    {
                        if (Start != null)
                        {
                            xe0 = Start.StartPoint2D.GetX();
                            ye0 = Start.StartPoint2D.GetY();
                            xe1 = Start.StartPoint2D.StartPoint2D.GetX();
                            ye1 = Start.StartPoint2D.StartPoint2D.GetY();
                            g.DrawEllipse(Start.Pc, (int)xe0, (int)ye0, xe1, ye1);
                        }
                    }
                }
                if (Start.Shap == Shape2D.Shape.Rectangle)
                {
                    //Point2D Dimension = new Point2D();
                    //Dimension = Start.
                    if (Start.Redraw)
                    {
                        if (Start != null)
                        {
                            xr0 = Start.StartPoint2D.GetX();
                            yr0 = Start.StartPoint2D.GetY();
                            xr1 = Start.StartPoint2D.StartPoint2D.GetX();
                            yr1 = Start.StartPoint2D.StartPoint2D.GetY();
                            g.DrawRectangle(Start.Pc, (int)xr0, (int)yr0, xr1, yr1);
                        }
                    }
                }

                Start = Start.Start2D;
            }
        }
        private Shape2D GetShapeLast(object sender)
        {
            Shape2D Last = new Shape2D();
            Last = this.Node;
            if (Last != null)
                while (Last.Start2D != null)
                    Last = Last.Start2D;
            return Last;
        }
        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 1;
        }

        private void doToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            openFileDialog1.ShowDialog();

            var output = Task.Factory.StartNew(() =>
            {
                a = new _2dTo3D(openFileDialog1.FileName);
            });
            output.Wait();

            lock (pictureBox24)
            {
                pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox24.Visible = true;

                pictureBox24.Image = a.ar;
                pictureBox24.Invalidate();
                pictureBox24.Refresh();
                pictureBox24.Update();
                go = true;
            }
            push();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            go = true;
            elim = true;
            push();

        }

        private void pictureBox24_Click(object sender, MouseEventArgs e)
        {
            try
            {
                if (go)
                {
                    if (mouseclick)
                        return;
                    if (Colorset)
                    {
                        if (elim)
                        {
                            mouseclick = true;
                            int x = e.X;
                            int y = e.Y;

                            x = (int)((double)e.X * ((double)(pictureBox24.Image.Width / (double)(pictureBox24.Width))));
                            y = (int)((double)e.Y * ((double)(pictureBox24.Image.Height / (double)(pictureBox24.Height))));
                            List<Color> ss = new List<Color>();
                            for (int r = 0; r < 5; r++)
                            {
                                for (int t = 0; t < Math.PI * 2; t++)
                                {
                                    Color d = (pictureBox24.Image as Bitmap).GetPixel(x + (int)(r * Math.Cos(t)), y + (int)(r * Math.Sin(t)));
                                    if (!ss.Contains(d))
                                        ss.Add(d);
                                }
                            }
                            Graphics g = Graphics.FromImage(pictureBox24.Image);

                            for (int i = 0; i < pictureBox24.Image.Width; i++)
                            {
                                for (int j = 0; j < pictureBox24.Image.Height; j++)
                                {
                                    Color d = (pictureBox24.Image as Bitmap).GetPixel(i, j);

                                    for (int b = 0; b < ss.Count; b++)
                                    {
                                        if (d == ss[b])
                                        {
                                            (pictureBox24.Image as Bitmap).SetPixel(i, j, Color.Black);
                                            g.DrawImage((pictureBox24.Image as Bitmap), 0, 0, pictureBox24.Image.Width, pictureBox24.Image.Height);
                                            g.Save();
                                        }
                                    }

                                }
                            }
                            lock (pictureBox24)
                            {
                                pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox24.Visible = true;
                                pictureBox24.Invalidate();
                                pictureBox24.Refresh();
                                pictureBox24.Update();
                                mouseclick = false;
                                elim = false;
                                Colorset = false;
                            }
                        }
                    }
                    else
                    {
                        if (elim)
                        {
                            int x = e.X;
                            int y = e.Y;

                            x = (int)((double)e.X * ((double)(pictureBox24.Image.Width / (double)(pictureBox24.Width))));
                            y = (int)((double)e.Y * ((double)(pictureBox24.Image.Height / (double)(pictureBox24.Height))));

                            Color s = (pictureBox24.Image as Bitmap).GetPixel(x, y);
                            Graphics g = Graphics.FromImage(pictureBox24.Image);
                            for (int i = 0; i < pictureBox24.Image.Width; i++)
                            {
                                for (int j = 0; j < pictureBox24.Image.Height; j++)
                                {

                                    if ((pictureBox24.Image as Bitmap).GetPixel(i, j) == s)
                                    {
                                        (pictureBox24.Image as Bitmap).SetPixel(i, j, Color.Black);
                                        g.DrawImage((pictureBox24.Image as Bitmap), 0, 0, pictureBox24.Image.Width, pictureBox24.Image.Height);
                                        g.Save();
                                    }


                                }
                            }
                            lock (pictureBox24)
                            {
                                pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox24.Visible = true;
                                pictureBox24.Invalidate();
                                pictureBox24.Refresh();
                                pictureBox24.Update();
                            }
                        }

                    }
                    if (curved)
                    {
                        float x = (float)e.X;
                        float y = (float)e.Y;

                        x = ((float)e.X * (float)((float)(pictureBox24.Image.Width / (float)(pictureBox24.Width))));
                        y = ((float)e.Y * (float)((float)(pictureBox24.Image.Height / (float)(pictureBox24.Height))));
                        curvedline[curvedlinelen] = new PointF(x, y);
                        curvedlinelen++;
                    }
                }
            }
            catch (Exception t) { }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (pictureBox24.Image != null)
                    pictureBox24.Image.Dispose();
                pictureBox24.Visible = false;
                Strong = false;
                count = 1250 * System.Threading.PlatformHelper.ProcessorCount;
                go = false;
                curvedallpoints = null;

                region = null;
                r = null;
                teta = null;
                 rlen = 0;
                outsidecurved = new List<Point2D>();

                curvedline = new PointF[100000];
                curvedlinelen = 0;
                curved = false;
                Reducedinteligent = false;

                mouseclick = false;
                time = (DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond;

                Colorset = false;
                percent = 0.5;
                elim = false;
                a = null;
            }
            catch (Exception t) { Log(t); MessageBox.Show(t.ToString()); }
            push();
        }

        private void doBy1OfPixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();

            var output = Task.Factory.StartNew(() =>
            {
                a = new _2dTo3D(openFileDialog1.FileName, 0.5);
            });
            output.Wait();
            lock (pictureBox24)
            {
                pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox24.Visible = true;
                pictureBox24.Image = a.ar;
                pictureBox24.Invalidate();
                pictureBox24.Refresh();
                pictureBox24.Update();
            }
            push();
        }
        string Get(Image aa)
        {
            lock (a)
            {
                lock (aa)
                {

                    int wid = (aa as Bitmap).Width;
                    int hei = (aa as Bitmap).Height;

                    if (a.x > 0)
                        return "Dimentin; " + wid.ToString() + "X" + hei.ToString() + "; active pixels :" + a.x.ToString();
                    return "Dimentin " + wid.ToString() + "X" + hei.ToString();
                }
            }
        }
        void PointsNumber()
        {
            if (a.x > 20 * System.Threading.PlatformHelper.ProcessorCount)
                textBox1.Text = (20 * System.Threading.PlatformHelper.ProcessorCount).ToString();
            else
                textBox1.Text = a.x.ToString();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1.ShowDialog();

                object o = new object();
                lock (o)
                {
                    Image b = Image.FromFile(openFileDialog1.FileName);
                    var output = Task.Factory.StartNew(() =>
                    {
                        a = new _2dTo3D(b, true);
                    });
                    output.Wait();

                    PointsNumber();

                    lock (pictureBox24)
                    {
                        label4.Text = Get(b);
                        pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox24.Visible = true;
                        pictureBox24.Image = b;
                        pictureBox24.Invalidate();
                        pictureBox24.Refresh();
                        pictureBox24.Update();

                    }
                }
            }
            catch (Exception t) { Log(t); MessageBox.Show(t.ToString()); }
            push();
        }

        private void decreseResulotonCheckersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminateClicingColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void doToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
            try
            {
                Image aa = pictureBox24.Image;
                lock (aa)
                {
                    if (a.x > count)
                    {
                        MessageBox.Show("Reduced image size;Desired Less Than " + count.ToString() + "; Current : " + (a.x).ToString());
                        return;
                    }
                    var output = Task.Factory.StartNew(() =>
                    {
                        if (a == null)
                            a = new _2dTo3D(aa);
                        else
                            a._2dTo3D_reconstructed(aa);
                    });
                    output.Wait();
                }
                label4.Text = Get(aa);

                PointsNumber();
                
                lock (pictureBox24)
                {
                    pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox24.Visible = true;
                    if (pictureBox24.Image != null)
                        pictureBox24.Image.Dispose();
                    pictureBox24.Image = a.ar;
                    pictureBox24.Invalidate();
                    pictureBox24.Refresh();
                    pictureBox24.Update();
                    go = true;
                }
            }
            catch (Exception t) { Log(t); MessageBox.Show(t.ToString()); }
            push();

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            Image aa = pictureBox24.Image;
            lock (aa)
            {
                Graphics g = Graphics.FromImage(aa);



                for (int i = 0; i < aa.Width; i++)
                {
                    for (int j = 0; j < aa.Height; j++)
                    {
                        if (((i + j) % ((int)(1.0 / percent))) == 0)
                        {

                        }
                        else
                        {
                            (aa as Bitmap).SetPixel(i, j, Color.Black);
                            g.DrawImage(aa, 0, 0, aa.Width, aa.Height);
                            g.Save();
                        }
                    }
                }
            }
            percent = percent - 0.1;
            int v = (int)((percent) * 100.0);
            toolStripMenuItem1.Text = "Do by " + v.ToString() + "% of pixels";

            lock (pictureBox24)
            {
                pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox24.Visible = true;
                pictureBox24.Image = aa;
                pictureBox24.Invalidate();
                pictureBox24.Refresh();
                pictureBox24.Update();
                var output = Task.Factory.StartNew(() =>
                    {
                        a = new _2dTo3D(aa, true);
                    });
                    output.Wait();

                PointsNumber();

                label4.Text = Get(aa);
                }
            push();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
            try
            {
                 lock (pictureBox24)
                {
                    pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox24.Visible = true;
                    pictureBox24.Image = (new Bitmap(pictureBox24.Image, new Size((int)((double)(pictureBox24.Image.Width) - ((double)(pictureBox24.Image.Width) * 0.1)), (int)((double)(pictureBox24.Image.Height) - ((double)(pictureBox24.Image.Height) * 0.1)))));
                    pictureBox24.Invalidate();
                    pictureBox24.Refresh();
                    pictureBox24.Update();
                   
                        var output = Task.Factory.StartNew(() =>
                        {
                            a = new _2dTo3D(pictureBox24.Image, true);
                        });
                        output.Wait();

                    PointsNumber();
                    
                    label4.Text = Get(pictureBox24.Image);
                }
            }catch(Exception t) { Log(t); MessageBox.Show(t.ToString()); }
            push();
        }

        private void eliminateSetOfColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            go = true;
            elim = true;
            Colorset = true;
            push();
        }

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            object o = new object();
            lock (o)
            {
                try
                {
                    if (go)
                    {
                        if (a != null)
                        {
                            if (Colorset)
                            {
                                if ((DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond - time <= 1000.0 / 30.0)
                                {
                                    Image a = (Image)pictureBox24.Image.Clone();

                                    lock (a)
                                    {
                                        Graphics g = Graphics.FromImage(a);

                                        int x = e.X;
                                        int y = e.Y;

                                        x = (int)((double)e.X * ((double)(pictureBox24.Image.Width / (double)(pictureBox24.Width))));
                                        y = (int)((double)e.Y * ((double)(pictureBox24.Image.Height / (double)(pictureBox24.Height))));
                                        g.DrawEllipse(new Pen(new SolidBrush(Color.White), (pictureBox24.Image.Width * pictureBox24.Image.Height) / penratio), new Rectangle(x, y, -5, 5));
                                        pictureBox24.Image = a;
                                        g.Dispose();
                                    }
                                }
                                else
                                {
                                    time = (DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond;
                                    pictureBox24.Image = (Image)at.Clone();
                                }
                            }
                            else
                            {
                                if (!curved)
                                {
                                    time = (DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond;

                                    object oo = new object();
                                    lock (at)
                                    {
                                        at = (Image)pictureBox24.Image.Clone();
                                    }
                                }
                            }

                            if (curved)
                            {
                                if ((DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond - time <= 1000.0 / 30.0)
                                {
                                    Image a = (Image)pictureBox24.Image.Clone();

                                    Graphics g = Graphics.FromImage(a);

                                    PointF[] s = new PointF[curvedlinelen];
                                    if (curvedlinelen > 1)
                                    {
                                        for (int i = 0; i < curvedlinelen; i++)
                                            s[i] = curvedline[i];
                                        g.DrawLines(new Pen(new SolidBrush(Color.White), (pictureBox24.Image.Width * pictureBox24.Image.Height) / penratio), s);
                                    }
                                    pictureBox24.Image = a;
                                    g.Dispose();

                                }
                                else
                                {
                                    time = (DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond;

                                    object oo = new object();
                                    lock (at)
                                    {
                                        at = (Image)pictureBox24.Image.Clone();
                                    }
                                }
                            }
                            else
                            {
                                if (!Colorset)
                                {
                                    time = (DateTime.Now.Hour * 24 * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000 + DateTime.Now.Millisecond;

                                    object oo = new object();
                                    lock (at)
                                    {
                                        at = (Image)pictureBox24.Image.Clone();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception t)
                {

                }
            }
        }

        private void reduce10ColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            List<Color> ss = new List<Color>();
            for (int r = 0; r < pictureBox24.Image.Width; r++)
            {
                for (int t = 0; t < pictureBox24.Image.Height; t++)
                {
                    Color d = (pictureBox24.Image as Bitmap).GetPixel(r, t);
                    if (!ss.Contains(d))
                        ss.Add(d);
                }
            }

            Graphics g = Graphics.FromImage(pictureBox24.Image);
            List<Color> ssrep = new List<Color>();
            int gg = (int)((double)ss.Count * 0.1);
            {
                if (ss[gg] != Color.Black)
                {
                    for (int i = 0; i < pictureBox24.Image.Width; i++)
                    {
                        for (int j = 0; j < pictureBox24.Image.Height; j++)
                        {
                            Color d = (pictureBox24.Image as Bitmap).GetPixel(i, j);
                            for (int b = 0; b < gg; b++)
                            {
                                if (d == ss[b] && ss[b] != Color.Black && ss[gg] != Color.Black && d != Color.Black)
                                {
                                    (pictureBox24.Image as Bitmap).SetPixel(i, j, ss[gg]);
                                    g.DrawImage((pictureBox24.Image as Bitmap), 0, 0, pictureBox24.Image.Width, pictureBox24.Image.Height);
                                    g.Save();
                                }
                            }

                        }
                    }
                }
                else
                {
                    if (gg > 0 && (ss.Count > gg + 1))
                    {
                        for (int i = 0; i < pictureBox24.Image.Width; i++)
                        {
                            for (int j = 0; j < pictureBox24.Image.Height; j++)
                            {
                                Color d = (pictureBox24.Image as Bitmap).GetPixel(i, j);
                                for (int b = 0; b < gg + 1; b++)
                                {
                                    if (d == ss[b] && ss[b] != Color.Black && ss[gg + 1] != Color.Black && d != Color.Black)
                                    {
                                        (pictureBox24.Image as Bitmap).SetPixel(i, j, ss[gg + 1]);
                                        g.DrawImage((pictureBox24.Image as Bitmap), 0, 0, pictureBox24.Image.Width, pictureBox24.Image.Height);
                                        g.Save();
                                    }
                                }

                            }
                        }
                    }
                }

                lock (pictureBox24)
                {
                    pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox24.Visible = true;
                    pictureBox24.Invalidate();
                    pictureBox24.Refresh();
                    pictureBox24.Update();
                }
            }
            push();
        }
        void addingpoints(ref List<Point3D> PointsAddp0, ref List<double[]> PointsAddp0Conected, ref List<Point3D> PointsAddp1, ref List<double[]> PointsAddp1Conected)
        {
            for (int i = 0; i < a.cx; i++)
            {
                for (int j = 0; j < a.cyp0; j++)
                {
                    if (a.c[i, j, 0] != 0 || a.c[i, j, 1] != 0 || a.c[i, j, 2] != 0)
                    {
                        Point3D s = new Point3D(i, j, (a.c[i, j, 0] + a.c[i, j, 1] + a.c[i, j, 2]) / 3);
                        PointsAddp0.Add(s);
                        PointsAddp0Conected.Add(a.st[i][j]);
                    }
                }
            }
            for (int i = 0; i < a.cx; i++)
            {
                for (int j = a.cyp0; j < a.cyp1; j++)
                {
                    if (a.c[i, j, 0] != 0 || a.c[i, j, 1] != 0 || a.c[i, j, 2] != 0)
                    {
                        Point3D s = new Point3D(i, j, (a.c[i, j, 0] + a.c[i, j, 1] + a.c[i, j, 2]) / 3);
                        PointsAddp1.Add(s);
                        PointsAddp1Conected.Add(a.st[i][j]);
                    }
                }
            }
        }
        void reducedpoints(ref List<Point3D> PointsAddp0, ref List<Point3D> PointsAddp1)
        {
            for (int i = 0; i < a.cx; i++)
            {
                for (int j = 0; j < a.cyp0; j++)
                {
                    if ((a.c[i, j, 0] + a.c[i, j, 1] + a.c[i, j, 2]) / 3 != 0)
                    {
                        Point3D s = new Point3D(i, j, (a.c[i, j, 0] + a.c[i, j, 1] + a.c[i, j, 2]) / 3);
                        if (!exist(s, PointsAddp0))
                        {
                            a.c[i, j, 0] = 0;
                            a.c[i, j, 1] = 0;
                            a.c[i, j, 2] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < a.cx; i++)
            {
                for (int j = a.cyp0; j < a.cyp1; j++)
                {
                    if ((a.c[i, j, 0] + a.c[i, j, 1] + a.c[i, j, 2]) / 3 != 0)
                    {
                        Point3D s = new Point3D(i, j, (a.c[i, j, 0] + a.c[i, j, 1] + a.c[i, j, 2]) / 3);
                        if (!exist(s, PointsAddp1))
                        {
                            a.c[i, j, 0] = 0;
                            a.c[i, j, 1] = 0;
                            a.c[i, j, 2] = 0;
                        }
                    }
                }
            }
        }
        private void intelligentRedducedOff3DModdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            List<Point3D> PointsAddp0 = new List<Point3D>();
            List<Point3D> PointsAddp1 = new List<Point3D>();
            List<double[]> PointsAddp0Conected = new List<double[]>();
            List<double[]> PointsAddp1Conected = new List<double[]>();
            addingpoints(ref PointsAddp0, ref PointsAddp0Conected, ref PointsAddp1, ref PointsAddp0Conected);
            if (PointsAddp0.Count >= 3 || PointsAddp1.Count >= 3)
            {
                double minrp0 = minraddpoints(PointsAddp0);
                double minrp1 = minraddpoints(PointsAddp1);
                MessageBox.Show("Add capable...p0! " + PointsAddp0.Count.ToString() + " p1! " + PointsAddp1.Count.ToString() + " points. with minrp0 " + minrp0.ToString() + " with minrp1 " + minrp1.ToString());
                if (PointsAddp0.Count > 35 || PointsAddp0.Count > 35)
                {
                    List<Point3D> xxxp0 = new List<Point3D>();

                    List<Point3D> xxxp1 = new List<Point3D>();

                    List<double[]> xxxp0Con = new List<double[]>();

                    List<double[]> xxxp1Con = new List<double[]>();
                    int f = (new Triangle()).reduceCountOfpoints(ref PointsAddp0, ref PointsAddp0Conected, minrp0 * 2, 35.0 / (double)PointsAddp0.Count, ref xxxp0, ref xxxp0Con, System.Convert.ToDouble(textBox1.Text));
                    f = f + (new Triangle()).reduceCountOfpoints(ref PointsAddp1, ref PointsAddp1Conected, minrp1 * 2, 35.0 / (double)PointsAddp1.Count, ref xxxp1, ref xxxp1Con, System.Convert.ToDouble(textBox1.Text));
                    if (xxxp0.Count > 1)
                    {
                        PointsAddp0 = xxxp0;
                        PointsAddp0Conected = xxxp0Con;
                    }
                    if (xxxp1.Count > 1)
                    {
                        PointsAddp1 = xxxp1;
                        PointsAddp1Conected = xxxp1Con;
                    }
                    MessageBox.Show("reduced...p0! " + PointsAddp0.Count.ToString() + " points." + "reduced...p1! " + PointsAddp1.Count.ToString() + " points.");

                    reducedpoints(ref PointsAddp0, ref PointsAddp1);
                    pictureBox24.Image.Dispose();
                    var output = Task.Factory.StartNew(() =>
                    {
                        a.reconstruct2dto3d(f);
                    });
                    output.Wait();
                    lock (pictureBox24)
                    {
                        pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox24.Visible = true;

                        pictureBox24.Image = a.ar;
                        pictureBox24.Invalidate();
                        pictureBox24.Refresh();
                        pictureBox24.Update();
                    }
                }
            }
            push();
        }
        bool exist(Point3D ss, List<Point3D> d)
        {
            if (d.Count == 0)
                return false;
            for (int i = 0; i < d.Count; i++)
            {
                if (ss.X == d[i].X && ss.Y == d[i].Y && ss.Z == d[i].Z)
                    return true;
            }
            return false;
        }

        double minraddpoints(List<Point3D> p0)
        {
            double r = double.MaxValue;
            for (int i = 0; i < p0.Count; i++)
            {
                for (int j = 0; j < p0.Count; j++)
                {

                    double a = Math.Sqrt((p0[i].X - p0[j].X) * (p0[i].X - p0[j].X) + (p0[i].Y - p0[j].Y) * (p0[i].Y - p0[j].Y) + (p0[i].Z - p0[j].Z) * (p0[i].Z - p0[j].Z));

                    if (a < r && a != 0)
                        r = a;
                }
            }
            return r;
        }

        private void curvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            go = true;
            curved = true;
            pictureBox24.Cursor = Cursors.Cross;
            push();
        }
        void isOutsideofCurvedInit()
        {
            curvedallpoints = new bool[pictureBox24.Image.Width, pictureBox24.Image.Height];
            bool[,] curvedapoints = new bool[pictureBox24.Image.Width, pictureBox24.Image.Height];
            PointF[] sd = (PointF[])curvedline.Clone();
            for (int i = 0; i < curvedlinelen - 1; i++)
            {
                float sx = 0, sy = 0, six = 0, siy = 0;

                if ((float)(sd[i].X) > (float)(sd[i + 1].X))
                {
                    sx = (float)(sd[i + 1].X);
                    six = (float)(sd[i].X);
                }
                else
                {
                    six = (float)(sd[i + 1].X);
                    sx = (float)(sd[i].X);
                }
                if ((float)(sd[i].Y) > (float)(sd[i + 1].Y))
                {
                    sy = (float)(sd[i + 1].Y);
                    siy = (float)(sd[i].Y);
                }
                else
                {
                    sy = (float)(sd[i].Y);
                    siy = (float)(sd[i + 1].Y);
                }


                float sdx = sd[i].X, sdix = sd[i + 1].X, sdy = sd[i].Y, sdiy = sd[i + 1].Y;
                for (float k = sx; k < six; k++)
                {
                    float p = (float)((((float)(sdiy - sdy) / (float)(sdix - sdx)) * (float)(k - sdx)) + sdy);
                    int[] nn = new int[2];
                    nn[0] = (int)k;
                    nn[1] = (int)p;

                    if (nn[0] >= 0 && nn[1] >= 0 && nn[0] < pictureBox24.Image.Width && nn[1] < pictureBox24.Image.Height)
                        curvedapoints[nn[0], nn[1]] = true;
                }
            }
            for (int x = 0; x < pictureBox24.Image.Width; x++)
            {
                int ocuuredcount = 0;
                int ocuuredfound = -1;
                int add = 0;
                for (int y = 0; y < pictureBox24.Image.Height; y++)
                {

                    if (curvedapoints[x, y])
                    {
                        if (add == 0)
                        {
                            //the  first time
                            if (ocuuredfound == -1)
                            {
                                ocuuredfound = y;
                                ocuuredcount++;
                                add = 1;
                            }
                            else
                                if (ocuuredfound != y)
                            {
                                ocuuredcount++;
                                ocuuredfound = y;
                            }
                        }
                        else
                        if (add == 3)
                        {
                            ocuuredcount = 0;
                            ocuuredfound = -1;
                            add = 4;

                        }
                    }
                    else
                        if (add == 2)
                    {
                        add = 3;

                    }

                    if (add > 0 && add != 4 && (add == 3 || add == 1 || add == 2))
                    {
                        //add untile second found
                        if (ocuuredcount >= 0)
                        {
                            int[] nn = new int[2];
                            nn[0] = (int)x;
                            nn[1] = (int)y;

                            if (nn[0] < pictureBox24.Image.Width && nn[1] < pictureBox24.Image.Height)
                            {
                                curvedallpoints[nn[0], nn[1]] = true;
                                if (add == 1)
                                    add = 2;
                            }
                        }
                    }
                }
            }
            return;
        }
        int getregion(float x, float y)
        {
            int reg = -1;

            if (x > 0 && y > 0)
                reg = 1;
            if (x < 0 && y > 0)
                reg = 2;
            if (x < 0 && y < 0)
                reg = 3;
            if (x > 0 && y < 0)
                reg = 4;

            if (x > 0 && y == 0)
                reg = 5;
            if (x == 0 && y > 0)
                reg = 6;
            if (x < 0 && y == 0)
                reg = 7;
            if (x == 0 && y < 0)
                reg = 8;
            return reg;
        }

        bool isOutsideofCurved(int x, int y)
        {
            bool Is = true;


            if (curvedallpoints[x, y])
                Is = false;
            return Is;
        }
        bool D(float a, float b)
        {
            if (System.Math.Abs(a - b) <= 3)
                return true;
            return false;
        }
        private void pictureBox24_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (go)
                {
                    if (mouseclick)
                        return;
                    if (curvedlinelen > 0)
                    {
                        curvedline[curvedlinelen] = curvedline[0];
                        /*rlen = 0;
                        r = new float[pictureBox24.Image.Width * pictureBox24.Image.Height];
                        teta = new float[pictureBox24.Image.Width * pictureBox24.Image.Height];
                        region = new float[pictureBox24.Image.Width * pictureBox24.Image.Height];*/
                        isOutsideofCurvedInit();
                        mouseclick = true;
                        Graphics g = Graphics.FromImage(pictureBox24.Image);
                        for (int i = 0; i < pictureBox24.Image.Width; i++)
                        {
                            for (int j = 0; j < pictureBox24.Image.Height; j++)
                            {
                                int x = i;
                                int y = j;

                                //x = (int)((float)x * (float)((float)(pictureBox24.Image.Width / (float)(pictureBox24.Width))));
                                //y = (int)((float)y * (float)((float)(pictureBox24.Image.Height / (float)(pictureBox24.Height))));
                                if (isOutsideofCurved(x, y))
                                {
                                    (pictureBox24.Image as Bitmap).SetPixel(x, y, Color.Black);
                                    g.DrawImage((pictureBox24.Image as Bitmap), 0, 0, pictureBox24.Image.Width, pictureBox24.Image.Height);
                                    g.Save();
                                }
                                else
                                {
                                    g.DrawImage((pictureBox24.Image as Bitmap), 0, 0, pictureBox24.Image.Width, pictureBox24.Image.Height);
                                    g.Save();

                                }
                            }
                        }
                        lock (pictureBox24)
                        {
                            pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox24.Visible = true;

                            pictureBox24.Invalidate();
                            pictureBox24.Refresh();
                            pictureBox24.Update();
                        }

                    }
                    mouseclick = false;
                    curved = false;
                    curvedlinelen = 0;
                    curvedline = new PointF[100000];
                    pictureBox24.Cursor = Cursors.Default;
                }
            }
            catch (Exception t) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                loadToolStripMenuItem.Enabled = false;
                Strong= true;
                if (at != null)
                    pictureBox24.Image = at;
            }
            else
            {
                loadToolStripMenuItem.Enabled = true;
                Strong = false;
            }
        }

        private void reducedUntilDesireddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                do
                {
                    lock (pictureBox24)
                    {
                        pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox24.Visible = true;
                        pictureBox24.Image = (new Bitmap(pictureBox24.Image, new Size((int)((double)(pictureBox24.Image.Width) - ((double)(pictureBox24.Image.Width) * 0.1)), (int)((double)(pictureBox24.Image.Height) - ((double)(pictureBox24.Image.Height) * 0.1)))));
                        pictureBox24.Invalidate();
                        pictureBox24.Refresh();
                        pictureBox24.Update();

                        var output = Task.Factory.StartNew(() =>
                        {
                            a = new _2dTo3D(pictureBox24.Image, true);
                        });
                        output.Wait();

                        PointsNumber();
                        
                        label4.Text = Get(pictureBox24.Image);
                    }
                } while (a.x > count);
            }
            catch (Exception t) { Log(t); MessageBox.Show(t.ToString()); }
            push();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (stkin < Stk.Count)
            {
                if (PushPop(true))
                {
                    if (stkin < Stk.Count - 1)
                        stkin++;
                    textBox1.Text = Stktx[stkin ];
                    checkBox1.Checked = Stkch[stkin ];
                    label4.Text = Stklb[stkin ];

                    pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox24.Visible = true;
                    pictureBox24.Image = StkIm[stkin ];
                    pictureBox24.Invalidate();
                    pictureBox24.Refresh();
                    pictureBox24.Update();
                    button12.Enabled = true;
                }
            }
            else
            {
                button12.Enabled = true;
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (stkin >= 0)
            {
                if (PushPop(false))
                {
                    textBox1.Text = Stktx[stkin ];
                    checkBox1.Checked = Stkch[stkin ];
                    label4.Text = Stklb[stkin ];

                    pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox24.Visible = true;
                    pictureBox24.Image = StkIm[stkin ];
                    pictureBox24.Invalidate();
                    pictureBox24.Refresh();
                    pictureBox24.Update();
                    button11.Enabled = true;
                    if (stkin > 0)
                        stkin--;
                }
            }
            else
            {
                button12.Enabled = false;
                button11.Enabled = true;
            }

        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 2;
        }

        private void bezierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 3;
            for (int i = 0; i < 3; i++)
                this.SetValue[i] = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 3;
            for (int i = 0; i < 3; i++)
                this.SetValue[i] = true;

        }

        private void EllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kind = 4;
            ClickMouse = 0;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kind = 5;
            ClickMouse = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kind = 4;
            ClickMouse = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kind = 5;
            ClickMouse = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtaining Name.
            String Name = "";
            Name = comboBox1.Text.ToString();
            Shape2D Selecte = new Shape2D();
            Selecte = Node;
            //Founding Object
            while (Selecte != null)
            {
                if (Selecte.Name == this.Name)
                    break;
                else
                    Selecte = Selecte.Start2D;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            String Name = "";
            Name = comboBox1.Text.ToString();
            Shape2D Selecte = new Shape2D();
            Selecte = Node;
            //Founding Object
            while (Selecte.Start2D != null)
            {
                if (Selecte.Start2D.Name == Name)
                {
                    Selecte.Start2D = Selecte.Start2D.Start2D;
                }
                else
                    Selecte = Selecte.Start2D;
            }
            comboBox1.Items.Remove(Name);
            comboBox1.Text = "";
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            this.DrawExistShape(sender);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shape2D Zoom = new Shape2D();
            Graphics g = this.CreateGraphics();
            Zoom = Node.Start2D;
            while (Zoom != null)
            {
                g.Clear(Color.White);
                if (Zoom.Shap == Shape2D.Shape.Arc)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(1.1 * (xz1 - xz0) + xz0));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(1.1 * (xz1 - xz0) + yz0));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetX((float)(1.1 * (xz2 - xz0) + yz0));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetY((float)(1.1 * (yz2 - yz0) + xz0));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep;
                    R = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz0), 2) + System.Math.Pow((yz1 - yz0), 2));
                    P = (float)System.Math.Sqrt(System.Math.Pow((xz2 - xz0), 2) + System.Math.Pow((yz2 - yz0), 2));
                    N = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz2), 2) + System.Math.Pow((yz1 - yz2), 2));
                    TetaStart = (float)((180 / 3.14) * (System.Math.Atan((yz1 - yz0) / (xz1 - yz0))));
                    TetaSweep = (float)((180 / 3.14) * System.Math.Acos(((System.Math.Pow(R, 2)) + (System.Math.Pow(P, 2)) - (System.Math.Pow(N, 2))) / (2 * R * P)));
                    g.DrawArc(Zoom.Pc, xz0, yz0, (float)System.Math.Abs(xz1 - xz0), (float)System.Math.Abs(yz1 - yz0), TetaStart, TetaSweep);

                }
                if (Zoom.Shap == Shape2D.Shape.Line)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(1.1 * xz0));
                    Zoom.StartPoint2D.SetY((float)(1.1 * yz0));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(1.1 * xz1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(1.1 * yz1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    g.DrawLine(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                if (Zoom.Shap == Shape2D.Shape.Bezier)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    xz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(1.1 * xz0));
                    Zoom.StartPoint2D.SetY((float)(1.1 * yz0));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(1.1 * xz1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(1.1 * yz1));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetX((float)(1.1 * xz2));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetY((float)(1.1 * yz2));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetX((float)(1.1 * xz3));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetY((float)(1.1 * yz3));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    xz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    g.DrawBezier(Zoom.Pc, xz0, yz0, xz1, yz1, xz2, yz2, xz3, yz3);
                }
                if (Zoom.Shap == Shape2D.Shape.Ellipse)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(1.1 * xz0));
                    Zoom.StartPoint2D.SetY((float)(1.1 * yz0));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(1.1 * xz1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(1.1 * yz1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    g.DrawEllipse(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                if (Zoom.Shap == Shape2D.Shape.Rectangle)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(1.1 * xz0));
                    Zoom.StartPoint2D.SetY((float)(1.1 * yz0));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(1.1 * xz1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(1.1 * yz1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    g.DrawRectangle(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                Zoom = Zoom.Start2D;
            }
            g.Clear(Color.White);
            this.DrawExistShape(sender);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shape2D Zoom = new Shape2D();
            Graphics g = this.CreateGraphics();
            Zoom = Node.Start2D;
            while (Zoom != null)
            {
                g.Clear(Color.White);
                if (Zoom.Shap == Shape2D.Shape.Arc)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();


                    Zoom.StartPoint2D.StartPoint2D.SetX((float)((yz1 - yz0) / 1.1 + xz0));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)((xz1 - xz0) / 1.1 + yz0));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep;
                    R = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz0), 2) + System.Math.Pow((yz1 - yz0), 2));
                    P = (float)System.Math.Sqrt(System.Math.Pow((xz2 - xz0), 2) + System.Math.Pow((yz2 - yz0), 2));
                    N = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz2), 2) + System.Math.Pow((yz1 - yz2), 2));
                    TetaStart = (float)((180 / 3.14) * (System.Math.Atan((yz1 - yz0) / (xz1 - yz0))));
                    TetaSweep = (float)((180 / 3.14) * System.Math.Acos(((System.Math.Pow(R, 2)) + (System.Math.Pow(P, 2)) - (System.Math.Pow(N, 2))) / (2 * R * P)));
                    g.DrawArc(Zoom.Pc, xz0, yz0, (float)System.Math.Abs(xz1 - xz0), (float)System.Math.Abs(yz1 - yz0), TetaStart, TetaSweep);

                }
                if (Zoom.Shap == Shape2D.Shape.Line)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(xz0 / 1.1));
                    Zoom.StartPoint2D.SetY((float)(yz0 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(xz1 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(yz1 / 1.1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    g.DrawLine(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                if (Zoom.Shap == Shape2D.Shape.Bezier)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    xz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(xz0 / 1.1));
                    Zoom.StartPoint2D.SetY((float)(yz0 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(xz1 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(yz1 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetX((float)(xz2 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetY((float)(yz2 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetX((float)(xz3 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetY((float)(yz3 / 1.1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    xz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    g.DrawBezier(Zoom.Pc, xz0, yz0, xz1, yz1, xz2, yz2, xz3, yz3);
                }
                if (Zoom.Shap == Shape2D.Shape.Ellipse)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(xz0 / 1.1));
                    Zoom.StartPoint2D.SetY((float)(yz0 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(xz1 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(yz1 / 1.1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    g.DrawEllipse(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                if (Zoom.Shap == Shape2D.Shape.Rectangle)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX((float)(xz0 / 1.1));
                    Zoom.StartPoint2D.SetY((float)(yz0 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetX((float)(xz1 / 1.1));
                    Zoom.StartPoint2D.StartPoint2D.SetY((float)(yz1 / 1.1));

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    g.DrawRectangle(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                Zoom = Zoom.Start2D;
            }
            g.Clear(Color.White);
            this.DrawExistShape(sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.zoomInToolStripMenuItem_Click(sender, e); ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.zoomOutToolStripMenuItem_Click(sender, e);
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            MoveAllow = true;
        }
        private void MoveAll(object sender)
        {
            Shape2D Zoom = new Shape2D();
            Graphics g = this.CreateGraphics();
            Zoom = Node.Start2D;
            if (ClickMouse == 2)
            {
                MoveAllow = false;
                ClickMouse = 0;
                return;
            }
            while (Zoom != null)
            {
                float Holdx = 0, Holdy = 0;
                Holdx = XP;
                Holdy = YP;
                XP = this.PointToClient(Control.MousePosition).X;
                YP = this.PointToClient(Control.MousePosition).Y;
                if (XP > Holdx)
                    xm = 3;
                if (XP < Holdx)
                    xm = -3;
                if (YP > Holdy)
                    ym = 3;
                if (YP < Holdy)
                    ym = -3;
                g.Clear(Color.White);
                if (Zoom.Shap == Shape2D.Shape.Arc)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();


                    Zoom.StartPoint2D.SetX(xz0 + xm);
                    Zoom.StartPoint2D.SetY(yz0 + ym);
                    Zoom.StartPoint2D.StartPoint2D.SetX(xz1 + xm);
                    Zoom.StartPoint2D.StartPoint2D.SetY(yz1 + ym);
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetX(xz2 + xm);
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetY(yz2 + ym);

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep;
                    R = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz0), 2) + System.Math.Pow((yz1 - yz0), 2));
                    P = (float)System.Math.Sqrt(System.Math.Pow((xz2 - xz0), 2) + System.Math.Pow((yz2 - yz0), 2));
                    N = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz2), 2) + System.Math.Pow((yz1 - yz2), 2));
                    TetaStart = (float)((180 / 3.14) * (System.Math.Atan((yz1 - yz0) / (xz1 - yz0))));
                    TetaSweep = (float)((180 / 3.14) * System.Math.Acos(((System.Math.Pow(R, 2)) + (System.Math.Pow(P, 2)) - (System.Math.Pow(N, 2))) / (2 * R * P)));
                    g.DrawArc(Zoom.Pc, xz0, yz0, (float)System.Math.Abs(xz1 - xz0), (float)System.Math.Abs(yz1 - yz0), TetaStart, TetaSweep);

                }
                if (Zoom.Shap == Shape2D.Shape.Line)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX(xz0 + xm);
                    Zoom.StartPoint2D.SetY(yz0 + ym);
                    Zoom.StartPoint2D.StartPoint2D.SetX(xz1 + xm);
                    Zoom.StartPoint2D.StartPoint2D.SetY(yz1 + ym);

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();

                    g.DrawLine(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                if (Zoom.Shap == Shape2D.Shape.Bezier)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    xz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX(xz0 + xm);
                    Zoom.StartPoint2D.SetY(yz0 + ym);
                    Zoom.StartPoint2D.StartPoint2D.SetX(xz1 + xm);
                    Zoom.StartPoint2D.StartPoint2D.SetY(yz1 + ym);
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetX(xz2 + xm);
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.SetY(yz2 + ym);
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetX(xz3 + xm);
                    Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetY(yz3 + ym);

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    xz1 = Zoom.StartPoint2D.StartPoint2D.GetX();
                    yz1 = Zoom.StartPoint2D.StartPoint2D.GetY();
                    xz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz2 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    xz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                    yz3 = Zoom.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                    g.DrawBezier(Zoom.Pc, xz0, yz0, xz1, yz1, xz2, yz2, xz3, yz3);
                }
                if (Zoom.Shap == Shape2D.Shape.Ellipse)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX(xz0 + xm);
                    Zoom.StartPoint2D.SetY(yz0 + ym);

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    g.DrawEllipse(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                if (Zoom.Shap == Shape2D.Shape.Rectangle)
                {
                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();

                    Zoom.StartPoint2D.SetX(xz0 + xm);
                    Zoom.StartPoint2D.SetY(yz0 + ym);

                    xz0 = Zoom.StartPoint2D.GetX();
                    yz0 = Zoom.StartPoint2D.GetY();
                    g.DrawRectangle(Zoom.Pc, xz0, yz0, xz1, yz1);
                }
                Zoom = Zoom.Start2D;
            }
            g.Clear(Color.White);
            this.DrawExistShape(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MoveAllow = true;
            ClickMouse = 0;
        }
        private void TransOperation(object sender)
        {
            String Name = "";
            Name = comboBox1.Text.ToString();
            Shape2D TransmisionObject = new Shape2D();
            TransmisionObject = Node.Start2D;
            //Founding Object
            if (TransmisionObject == null)
                return;
            while (TransmisionObject != null)
            {
                if (TransmisionObject.Name == Name)
                    break;
                else
                    TransmisionObject = TransmisionObject.Start2D;
            }
            if (TransmisionObject == null)
                return;
            //exit when the object is null
            Graphics g = this.CreateGraphics();

            if (TransmisionObject.Shap == Shape2D.Shape.Arc)
            {
                xz0 = TransmisionObject.StartPoint2D.GetX();
                yz0 = TransmisionObject.StartPoint2D.GetY();
                xz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetX();
                yz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetY();
                xz2 = TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                yz2 = TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                if (ClickMouse == 1)
                {
                    XP = this.PointToClient(Control.MousePosition).X;
                    YP = this.PointToClient(Control.MousePosition).Y;

                    this.Transmition(sender, xz0, yz0, XP - xz0, YP - yz0);
                }

                float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep;
                R = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz0), 2) + System.Math.Pow((yz1 - yz0), 2));
                P = (float)System.Math.Sqrt(System.Math.Pow((xz2 - xz0), 2) + System.Math.Pow((yz2 - yz0), 2));
                N = (float)System.Math.Sqrt(System.Math.Pow((xz1 - xz2), 2) + System.Math.Pow((yz1 - yz2), 2));
                TetaStart = (float)((180 / 3.14) * (System.Math.Atan((yz1 - yz0) / (xz1 - yz0))));
                TetaSweep = (float)((180 / 3.14) * System.Math.Acos(((System.Math.Pow(R, 2)) + (System.Math.Pow(P, 2)) - (System.Math.Pow(N, 2))) / (2 * R * P)));
                g.Clear(Color.White);
                g.DrawArc(TransmisionObject.Pc, xprin, yprin, (float)System.Math.Abs(xz1 - xz0), (float)System.Math.Abs(yz1 - yz0), TetaStart, TetaSweep);

                if (ClickMouse == 2)
                {
                    TransmisionObject.StartPoint2D.SetX(xprin);
                    TransmisionObject.StartPoint2D.SetY(yprin);
                    TransmisionObject.StartPoint2D.StartPoint2D.SetX(xz1 + xprin - xz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.SetY(yz1 + yprin - yz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.SetX(xz2 + xprin - xz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.SetY(yz2 + yprin - yz0);
                    Trans = false;
                }


            }
            if (TransmisionObject.Shap == Shape2D.Shape.Line)
            {
                xz0 = TransmisionObject.StartPoint2D.GetX();
                yz0 = TransmisionObject.StartPoint2D.GetY();
                xz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetX();
                yz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetY();
                if (ClickMouse == 1)
                {
                    XP = this.PointToClient(Control.MousePosition).X;
                    YP = this.PointToClient(Control.MousePosition).Y;

                    this.Transmition(sender, xz0, yz0, XP - xz0, YP - yz0);
                }
                g.Clear(Color.White);
                g.DrawLine(TransmisionObject.Pc, xprin, yprin, xz1 + xprin - xz0, yz1 + yprin - yz0);
                if (ClickMouse == 2)
                {
                    TransmisionObject.StartPoint2D.SetX(xprin);
                    TransmisionObject.StartPoint2D.SetY(yprin);
                    TransmisionObject.StartPoint2D.StartPoint2D.SetX(xz1 + xprin - xz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.SetY(yz1 + yprin - yz0);
                    Trans = false;
                }

            }
            if (TransmisionObject.Shap == Shape2D.Shape.Bezier)
            {
                xz0 = TransmisionObject.StartPoint2D.GetX();
                yz0 = TransmisionObject.StartPoint2D.GetY();
                xz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetX();
                yz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetY();
                xz2 = TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                yz2 = TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                xz3 = TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX();
                yz3 = TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY();
                if (ClickMouse == 1)
                {
                    XP = this.PointToClient(Control.MousePosition).X;
                    YP = this.PointToClient(Control.MousePosition).Y;

                    this.Transmition(sender, xz0, yz0, XP - xz0, YP - yz0);
                }
                g.Clear(Color.White);
                g.DrawBezier(TransmisionObject.Pc, xprin, yprin, xz1 + xprin - xz0, yz1 + yprin - yz0, xz2 + xprin - xz0, yz2 + yprin - yz0, xz3 + xprin - xz0, yz3 + yprin - yz0);
                if (ClickMouse == 2)
                {
                    TransmisionObject.StartPoint2D.SetX(xprin);
                    TransmisionObject.StartPoint2D.SetY(yprin);
                    TransmisionObject.StartPoint2D.StartPoint2D.SetX(xz1 + xprin - xz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.SetY(yz1 + yprin - yz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.SetX(xz2 + xprin - xz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.SetY(yz2 + yprin - yz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetX(xz3 + xprin - xz0);
                    TransmisionObject.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.SetY(yz3 + yprin - yz0);
                    Trans = false;
                }

            }
            if (TransmisionObject.Shap == Shape2D.Shape.Ellipse)
            {
                xz0 = TransmisionObject.StartPoint2D.GetX();
                yz0 = TransmisionObject.StartPoint2D.GetY();
                xz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetX();
                yz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetY();
                if (ClickMouse == 1)
                {
                    XP = this.PointToClient(Control.MousePosition).X;
                    YP = this.PointToClient(Control.MousePosition).Y;

                    this.Transmition(sender, xz0, yz0, XP - xz0, YP - yz0);
                }
                g.Clear(Color.White);
                g.DrawEllipse(TransmisionObject.Pc, xprin, yprin, xz1, yz1);
                if (ClickMouse == 2)
                {
                    TransmisionObject.StartPoint2D.SetX(xprin);
                    TransmisionObject.StartPoint2D.SetY(yprin);
                    Trans = false;
                }
            }
            if (TransmisionObject.Shap == Shape2D.Shape.Rectangle)
            {
                xz0 = TransmisionObject.StartPoint2D.GetX();
                yz0 = TransmisionObject.StartPoint2D.GetY();
                xz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetX();
                yz1 = TransmisionObject.StartPoint2D.StartPoint2D.GetY();
                if (ClickMouse == 1)
                {
                    XP = this.PointToClient(Control.MousePosition).X;
                    YP = this.PointToClient(Control.MousePosition).Y;

                    this.Transmition(sender, xz0, yz0, XP - xz0, YP - yz0);
                }
                g.Clear(Color.White);
                g.DrawRectangle(TransmisionObject.Pc, xprin, yprin, xz1, yz1);
                if (ClickMouse == 2)
                {
                    TransmisionObject.StartPoint2D.SetX(xprin);
                    TransmisionObject.StartPoint2D.SetY(yprin);
                    Trans = false;
                }

            }

        }
        private void transmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trans = true;
            ClickMouse = 0;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            ColorBox = 0;
            this.PictureBox23.BackColor = Color.White;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            ColorBox = 1;
            this.PictureBox23.BackColor = Color.Black;

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            ColorBox = 2;
            this.PictureBox23.BackColor = Color.Brown;
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            ColorBox = 3;
            this.PictureBox23.BackColor = Color.Silver;
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            ColorBox = 4;
            this.PictureBox23.BackColor = Color.LightCoral;
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            ColorBox = 5;
            this.PictureBox23.BackColor = Color.Red;
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            ColorBox = 6;
            this.PictureBox23.BackColor = Color.OrangeRed;
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            ColorBox = 7;
            this.PictureBox23.BackColor = Color.Bisque;
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            ColorBox = 8;
            this.PictureBox23.BackColor = Color.Gold;
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            ColorBox = 9;
            this.PictureBox23.BackColor = Color.Yellow;
        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            ColorBox = 10;
            this.PictureBox23.BackColor = Color.LawnGreen;
        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {
            ColorBox = 11;
            this.PictureBox23.BackColor = Color.Aquamarine;
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            ColorBox = 12;
            this.PictureBox23.BackColor = Color.Blue;
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            ColorBox = 13;
            this.PictureBox23.BackColor = Color.Fuchsia;
        }
        private void PictureBox15_Click(object sender, EventArgs e)
        {
            ColorBox = 14;
            this.PictureBox23.BackColor = Color.Pink;
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            ColorBox = 15;
            this.PictureBox23.BackColor = Color.LightPink;
        }
        private Pen DetermineColor(object sender)
        {
            Pen p = new Pen(Color.White);
            if (ColorBox == 0)
                p.Color = Color.White;
            if (ColorBox == 1)
                p.Color = Color.Black;
            if (ColorBox == 2)
                p.Color = Color.Brown;
            if (ColorBox == 3)
                p.Color = Color.Silver;
            if (ColorBox == 4)
                p.Color = Color.LightCoral;
            if (ColorBox == 5)
                p.Color = Color.Red;
            if (ColorBox == 6)
                p.Color = Color.OrangeRed;
            if (ColorBox == 7)
                p.Color = Color.Bisque;
            if (ColorBox == 8)
                p.Color = Color.Gold;
            if (ColorBox == 9)
                p.Color = Color.Yellow;
            if (ColorBox == 10)
                p.Color = Color.LawnGreen;
            if (ColorBox == 11)
                p.Color = Color.Aquamarine;
            if (ColorBox == 12)
                p.Color = Color.Blue;
            if (ColorBox == 13)
                p.Color = Color.Fuchsia;
            if (ColorBox == 14)
                p.Color = Color.Pink;
            if (ColorBox == 15)
                p.Color = Color.LightPink;
            return p;
        }


        private void Form1_FontChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClickMouse = 0;
            Kind = 6;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



    }
    public class Point2D
    {
        float X, Y;
        public Point2D StartPoint2D;
        public Point2D()
        {
        }
        public Point2D(float X0, float Y0)
        {
            X = X0;
            Y = Y0;
        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public void SetX(float X0)
        {
            X = X0;
        }
        public void SetY(float Y0)
        {
            Y = Y0;
        }
    }
    public class Shape2D : Point2D
    {
        public enum Shape
        {
            Arc,
            Line,
            Bezier,
            Ellipse,
            Rectangle,
            Pen,
            Chord,
            Pie,
            None
        }
        public enum ColorShape
        {
            Red,
            Green,
            Blue,
            Black,
            Yellow
        }
        public Shape Shap;
        public ColorShape ColorSh;
        public String Name = "";
        public Shape2D Start2D;
        public bool Redraw = false;
        public Pen Pc;
        public Shape2D()
        {
            Start2D = null;
        }
        public Shape2D(int ShapeMode, float X1, float Y1, float X2, float Y2, float X3, float Y3, float X4, float Y4)
        {
            this.Start2D = null;
            if (ShapeMode == 1)//Arc
            {
                Shap = Shape.Arc;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                Point2D Po3 = new Point2D(X3, Y3);
                Point2D Po4 = new Point2D(X4, Y4);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = Po3;
                Po3.StartPoint2D = Po4;
                Po4.StartPoint2D = null;
            }
            if (ShapeMode == 2)//Line
            {
                Shap = Shape.Line;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = null;
            }
            if (ShapeMode == 3)//Bezier
            {
                Shap = Shape.Bezier;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                Point2D Po3 = new Point2D(X3, Y3);
                Point2D Po4 = new Point2D(X4, Y4);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = Po3;
                Po3.StartPoint2D = Po4;
                Po4.StartPoint2D = null;
            }
            if (ShapeMode == 4)//Ellipse
            {
                Shap = Shape.Ellipse;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = null;
            }

            if (ShapeMode == 5)//Rectangle
            {
                Shap = Shape.Rectangle;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = null;
            }
            if (ShapeMode == 6)//Chord
            {
                Shap = Shape.Chord;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                Point2D Po3 = new Point2D(X3, Y3);
                Point2D Po4 = new Point2D(X4, Y4);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = Po3;
                Po3.StartPoint2D = Po4;
                Po4.StartPoint2D = null;
            }
            if (ShapeMode == 7)//pie
            {
                Shap = Shape.Pie;
                Point2D Po1 = new Point2D(X1, Y1);
                Point2D Po2 = new Point2D(X2, Y2);
                Point2D Po3 = new Point2D(X3, Y3);
                Point2D Po4 = new Point2D(X4, Y4);
                this.StartPoint2D = Po1;
                Po1.StartPoint2D = Po2;
                Po2.StartPoint2D = Po3;
                Po3.StartPoint2D = Po4;
                Po4.StartPoint2D = null;
            }
        }
    }

}