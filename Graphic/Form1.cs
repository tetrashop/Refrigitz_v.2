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
        List<string> Stktx = new List<string>();
        public bool Strong = false;
        int count = 1250 * System.Threading.PlatformHelper.ProcessorCount;
        bool go = false;
        bool[,] curvedallpoints = null;
        float[] region = null, r = null, teta = null;
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
        float xs0 = 0, ys0 = 0, xs1 = 0, ys1 = 0, xs2 = 0, ys2 = 0;
        float xb0 = 0, yb0 = 0, xb1 = 0, yb1 = 0, xb2 = 0, yb2 = 0, xb3 = 0, yb3 = 0;
        float xe0 = 0, ye0 = 0, xe1 = 0, ye1 = 0;
        float xr0 = 0, yr0 = 0, xr1 = 0, yr1 = 0;
        float xm = 0, ym = 0, XP = 0, YP = 0;
        int ColorBox = 0;
        float R = 0, P = 0, N = 0, TetaStart = 0, TetaSweep = 0;
        private float xprin, yprin;
        bool[] outcode0 = new bool[4], outcode1 = new bool[4], outcodeOut = new bool[4];
        Shape2D Node = new Shape2D();
        Shape2D Sh = new Shape2D();
        static int ClickMouse = -1;
        bool DrawLine = false;
        bool[] SetValue = new bool[3], SetValueforBezier = new bool[4];
        bool MoveAllow = false, Trans = false;
        static int ArcCount = 0, LineCount = 0, BezierCount = 0, EllipseCount = 0, RectangleCount = 0;

        static void Log(Exception ex) { try { File.AppendAllText("ErrorProgramRun.txt", ex.ToString() + ": On" + DateTime.Now.ToString() + Environment.NewLine); } catch { } }

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
            bool ass = pu ? (stkin < Stk.Count) : (stkin >= 0);
            if (ass)
            {
                Form1 th = Stk[stkin];
                Strong = th.Strong; count = th.count; go = th.go;
                curvedallpoints = th.curvedallpoints; rlen = th.rlen;
                outsidecurved = th.outsidecurved; curvedline = th.curvedline;
                curvedlinelen = th.curvedlinelen; curved = th.curved;
                Reducedinteligent = th.Reducedinteligent; mouseclick = th.mouseclick;
                time = th.time; at = th.at; Colorset = th.Colorset; percent = th.percent;
                elim = th.elim; a = th.a; Kind = th.Kind;
                xp0 = th.xp0; yp0 = th.yp0; xp1 = th.xp1; yp1 = th.yp1;
                xp2 = th.xp2; yp2 = th.yp2; xp3 = th.xp3; yp3 = th.yp3;
                xz0 = th.xz0; yz0 = th.yz0; xz1 = th.xz1; yz1 = th.yz1;
                xz2 = th.xz2; yz2 = th.yz2; xz3 = th.xz3; yz3 = th.yz3;
                xs0 = th.xs0; ys0 = th.ys0; xs1 = th.xs1; ys1 = th.ys1;
                xs2 = th.xs2; ys2 = th.ys2; xb0 = th.xb0; yb0 = th.yb0;
                xb1 = th.xb1; yb1 = th.yb1; xb2 = th.xb2; yb2 = th.yb2;
                xb3 = th.xb3; yb3 = th.yb3; xe0 = th.xe0; ye0 = th.ye0;
                xe1 = th.xe1; ye1 = th.ye1; xr0 = th.xr1; yr0 = th.yr0;
                xr1 = th.xr1; yr1 = th.yr1; xm = th.xm; ym = th.ym;
                XP = th.XP; YP = th.YP; ColorBox = th.ColorBox;
                R = th.R; P = th.P; N = th.N; TetaStart = th.TetaStart;
                TetaSweep = th.TetaSweep; xprin = th.xprin; yprin = th.yprin;
                outcode0 = th.outcode0; outcode1 = th.outcode1; outcodeOut = th.outcodeOut;
                Node = th.Node; Sh = th.Sh; DrawLine = false;
                SetValue = th.SetValue; SetValueforBezier = th.SetValueforBezier;
                MoveAllow = th.MoveAllow; Trans = th.Trans;
                return true;
            }
            return false;
        }

        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_FontChanged(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) { loadToolStripMenuItem.Enabled = false; Strong = true; if (at != null) pictureBox24.Image = at; }
            else { loadToolStripMenuItem.Enabled = true; Strong = false; }
        }

        private void Transmition(object sender, float x, float y, float tx, float ty) { xprin = x + tx; yprin = y + ty; }
        private void Rotation(object sender, float x, float y, float Teta) { double cos = Math.Cos(Teta), sin = Math.Sin(Teta); xprin = (float)(x * cos - y * sin); yprin = (float)(x * sin + y * cos); }
        private void Scaling(object sender, float x, float y, float sx, float sy) { xprin = x * sx; yprin = y * sy; }
        private void MirrorX(object sender, float x, float y) { xprin = x; yprin = -y; }
        private void MirrorY(object sender, float x, float y) { xprin = -x; yprin = y; }
        private void InversionTransmision(object sender, float x, float y, float tx, float ty) { xprin = x - tx; yprin = y - ty; }
        private void InversionRotation(object sender, float x, float y, float Teta) { double cos = Math.Cos(Teta), sin = Math.Sin(Teta); xprin = (float)(x * cos + y * sin); yprin = (float)(-x * sin + y * cos); }
        private void InversionScalling(object sender, float x, float y, float sx, float sy) { xprin = x / sx; yprin = y / sy; }

        private void DrawArc(Graphics g, Pen p, float x0, float y0, float x1, float y1, float x2, float y2)
        {
            R = (float)Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));
            P = (float)Math.Sqrt(Math.Pow(x2 - x0, 2) + Math.Pow(y2 - y0, 2));
            N = (float)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            TetaStart = (float)(180.0 / Math.PI * Math.Atan2(y1 - y0, x1 - x0));
            TetaSweep = (float)(180.0 / Math.PI * Math.Acos((R * R + P * P - N * N) / (2 * R * P)));
            g.DrawArc(p, x0, y0, Math.Abs(x1 - x0), Math.Abs(y1 - y0), TetaStart, TetaSweep);
        }

        private void ArcDraw(object sender, Pen p) { }
        private void LineDraw(object sender, Pen p) { }
        private void LineForBezierDraw(object sender, Pen p) { }
        private void EllipseDraw(object sender) { }
        private void RectangleDraw(object sender) { }
        private void Pen(object sender) { }
        private void MoveAll(object sender) { }
        private void TransOperation(object sender) { }

        private void DrawExistShape(object sender)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(Color.White);
                Shape2D start = Node;
                while (start != null)
                {
                    if (start.Redraw && start.StartPoint2D != null)
                    {
                        Pen p = start.Pc ?? new Pen(Color.Black);
                        switch (start.Shap)
                        {
                            case Shape2D.Shape.Arc:
                                if (start.StartPoint2D.StartPoint2D?.StartPoint2D != null)
                                    DrawArc(g, p, start.StartPoint2D.GetX(), start.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D.GetX(), start.StartPoint2D.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D.StartPoint2D.GetX(), start.StartPoint2D.StartPoint2D.StartPoint2D.GetY());
                                break;
                            case Shape2D.Shape.Line:
                                if (start.StartPoint2D.StartPoint2D != null)
                                    g.DrawLine(p, start.StartPoint2D.GetX(), start.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D.GetX(), start.StartPoint2D.StartPoint2D.GetY());
                                break;
                            case Shape2D.Shape.Bezier:
                                if (start.StartPoint2D.StartPoint2D?.StartPoint2D?.StartPoint2D != null)
                                    g.DrawBezier(p, start.StartPoint2D.GetX(), start.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D.GetX(), start.StartPoint2D.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D.StartPoint2D.GetX(), start.StartPoint2D.StartPoint2D.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetX(), start.StartPoint2D.StartPoint2D.StartPoint2D.StartPoint2D.GetY());
                                break;
                            case Shape2D.Shape.Ellipse:
                                g.DrawEllipse(p, start.StartPoint2D.GetX(), start.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D?.GetX() ?? 0, start.StartPoint2D.StartPoint2D?.GetY() ?? 0);
                                break;
                            case Shape2D.Shape.Rectangle:
                                g.DrawRectangle(p, start.StartPoint2D.GetX(), start.StartPoint2D.GetY(), start.StartPoint2D.StartPoint2D?.GetX() ?? 0, start.StartPoint2D.StartPoint2D?.GetY() ?? 0);
                                break;
                        }
                    }
                    start = start.Start2D;
                }
            }
        }

        private void aRCToolStripMenuItem_Click_1(object sender, EventArgs e) { Kind = 1; ClickMouse = 0; }
        private void aRCToolStripMenuItem_MouseDown(object sender, MouseEventArgs e) { ClickMouse++; }
        private void aRCToolStripMenuItem_MouseMove(object sender, MouseEventArgs e) { }
        private void lToolStripMenuItem_Click(object sender, EventArgs e) { Kind = 2; ClickMouse = 0; }
        private void bezierToolStripMenuItem_Click(object sender, EventArgs e) { Kind = 3; ClickMouse = 0; }
        private void EllipseToolStripMenuItem_Click(object sender, EventArgs e) { Kind = 4; ClickMouse = 0; }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e) { Kind = 5; ClickMouse = 0; }
        private void transmisionToolStripMenuItem_Click(object sender, EventArgs e) { Trans = true; ClickMouse = 0; }
        private void rotateToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void mirroToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void moveToolStripMenuItem_Click(object sender, EventArgs e) { MoveAllow = true; ClickMouse = 0; }
        private void doToolStripMenuItem_Click(object sender, EventArgs e) { openFileDialog1.ShowDialog(); var output = Task.Factory.StartNew(() => { a = new _2dTo3D(openFileDialog1.FileName); }); output.Wait(); pictureBox24.Image = a.ar; pictureBox24.Visible = true; go = true; push(); }
        private void doBy1OfPixelsToolStripMenuItem_Click(object sender, EventArgs e) { openFileDialog1.ShowDialog(); var output = Task.Factory.StartNew(() => { a = new _2dTo3D(openFileDialog1.FileName, 0.5); }); output.Wait(); pictureBox24.Image = a.ar; pictureBox24.Visible = true; go = true; push(); }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e) { pictureBox24.Image = null; go = false; a = null; Strong = false; push(); }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e) { push(); }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) { push(); }
        private void PictureBox1_Click(object sender, EventArgs e) { go = true; elim = true; push(); }
        private void eliminateSetOfColorsToolStripMenuItem_Click(object sender, EventArgs e) { go = true; elim = true; Colorset = true; push(); }
        private void toolStripMenuItem2_Click(object sender, EventArgs e) { push(); }
        private void reducedUntilDesireddToolStripMenuItem_Click(object sender, EventArgs e) { push(); }
        private void doToolStripMenuItem1_Click(object sender, EventArgs e) { push(); }
        private void filtersToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void reduce10ColorsToolStripMenuItem_Click(object sender, EventArgs e) { push(); }
        private void intelligentReducedOff3DModdelToolStripMenuItem_Click(object sender, EventArgs e) { push(); }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void curvedToolStripMenuItem_Click(object sender, EventArgs e) { go = true; curved = true; pictureBox24.Cursor = Cursors.Cross; push(); }
        private void button1_Click(object sender, EventArgs e) { Kind = 1; ClickMouse = 0; }
        private void button2_Click(object sender, EventArgs e) { Kind = 2; ClickMouse = 0; }
        private void button3_Click(object sender, EventArgs e) { Kind = 3; ClickMouse = 0; }
        private void button4_Click(object sender, EventArgs e) { Kind = 4; ClickMouse = 0; }
        private void button5_Click(object sender, EventArgs e) { Kind = 5; ClickMouse = 0; }
        private void button6_Click(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { zoomInToolStripMenuItem_Click(sender, e); }
        private void button8_Click(object sender, EventArgs e) { zoomOutToolStripMenuItem_Click(sender, e); }
        private void button9_Click(object sender, EventArgs e) { MoveAllow = true; ClickMouse = 0; }
        private void button10_Click(object sender, EventArgs e) { Kind = 6; ClickMouse = 0; }
        private void button11_Click(object sender, EventArgs e) { if (stkin < Stk.Count) { PushPop(true); stkin++; UpdateUI(); } }
        private void button12_Click(object sender, EventArgs e) { if (stkin >= 0) { PushPop(false); if (stkin > 0) stkin--; UpdateUI(); } }
        private void PictureBox5_Click(object sender, EventArgs e) { ColorBox = 1; PictureBox23.BackColor = Color.Black; }
        private void PictureBox8_Click(object sender, EventArgs e) { ColorBox = 3; PictureBox23.BackColor = Color.Silver; }
        private void PictureBox9_Click(object sender, EventArgs e) { ColorBox = 0; PictureBox23.BackColor = Color.White; }
        private void PictureBox10_Click(object sender, EventArgs e) { ColorBox = 2; PictureBox23.BackColor = Color.Brown; }
        private void PictureBox11_Click(object sender, EventArgs e) { ColorBox = 4; PictureBox23.BackColor = Color.LightCoral; }
        private void PictureBox12_Click(object sender, EventArgs e) { ColorBox = 5; PictureBox23.BackColor = Color.Red; }
        private void PictureBox13_Click(object sender, EventArgs e) { ColorBox = 6; PictureBox23.BackColor = Color.OrangeRed; }
        private void PictureBox14_Click(object sender, EventArgs e) { ColorBox = 7; PictureBox23.BackColor = Color.Bisque; }
        private void PictureBox15_Click(object sender, EventArgs e) { ColorBox = 14; PictureBox23.BackColor = Color.Pink; }
        private void PictureBox16_Click(object sender, EventArgs e) { ColorBox = 15; PictureBox23.BackColor = Color.LightPink; }
        private void PictureBox17_Click(object sender, EventArgs e) { ColorBox = 9; PictureBox23.BackColor = Color.Yellow; }
        private void PictureBox18_Click(object sender, EventArgs e) { ColorBox = 8; PictureBox23.BackColor = Color.Gold; }
        private void PictureBox19_Click(object sender, EventArgs e) { ColorBox = 12; PictureBox23.BackColor = Color.Blue; }
        private void PictureBox20_Click(object sender, EventArgs e) { ColorBox = 13; PictureBox23.BackColor = Color.Fuchsia; }
        private void PictureBox21_Click(object sender, EventArgs e) { ColorBox = 10; PictureBox23.BackColor = Color.LawnGreen; }
        private void PictureBox22_Click(object sender, EventArgs e) { ColorBox = 11; PictureBox23.BackColor = Color.Aquamarine; }

        private Pen DetermineColor(object sender)
        {
            Color[] cols = { Color.White, Color.Black, Color.Brown, Color.Silver, Color.LightCoral, Color.Red, Color.OrangeRed, Color.Bisque, Color.Gold, Color.Yellow, Color.LawnGreen, Color.Aquamarine, Color.Blue, Color.Fuchsia, Color.Pink, Color.LightPink };
            return new Pen(cols[ColorBox % cols.Length]);
        }

        private Shape2D GetShapeLast(object sender)
        {
            Shape2D last = Node;
            if (last != null) while (last.Start2D != null) last = last.Start2D;
            return last;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            DrawExistShape(sender);
            if (Kind == 1) ArcDraw(sender, DetermineColor(sender));
            if (Kind == 2) LineDraw(sender, DetermineColor(sender));
            if (Kind == 3) LineForBezierDraw(sender, DetermineColor(sender));
            if (Kind == 4) EllipseDraw(sender);
            if (Kind == 5) RectangleDraw(sender);
            if (Kind == 6) Pen(sender);
            if ((ClickMouse == 1 || ClickMouse == 2) && MoveAllow) MoveAll(sender);
            if (Trans) TransOperation(sender);
            DrawExistShape(sender);
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            if (ClickMouse == 0) DrawLine = false;
            if (ClickMouse == 1) DrawLine = true;
            ClickMouse++;
            if (ClickMouse != 1 && Kind == 3) { xp0 = xp1; yp0 = yp1; }
            xprin = PointToClient(Control.MousePosition).X;
            yprin = PointToClient(Control.MousePosition).Y;
            if (!MoveAllow)
            {
                if (Kind != 4 && Kind != 5)
                {
                    if (ClickMouse == 1) { xp0 = xprin; yp0 = yprin; }
                    if (DrawLine) { xp1 = xprin; yp1 = yprin; if (ClickMouse == 2) { DrawLine = false; xs1 = xp1; ys1 = yp1; } }
                }
                else if (ClickMouse == 1) { xp0 = xprin; yp0 = yprin; }
            }
        }

        private void pictureBox24_Click(object sender, MouseEventArgs e) { }
        private void pictureBox24_MouseDoubleClick(object sender, MouseEventArgs e) { }
        private void pictureBox24_MouseMove(object sender, MouseEventArgs e) { }

        private void UpdateUI()
        {
            if (stkin >= 0 && stkin < Stk.Count)
            {
                textBox1.Text = Stktx[stkin];
                checkBox1.Checked = Stkch[stkin];
                label4.Text = Stklb[stkin];
                pictureBox24.Image = StkIm[stkin];
            }
        }

        public class Point2D
        {
            float X, Y;
            public Point2D StartPoint2D;
            public Point2D() { }
            public Point2D(float X0, float Y0) { X = X0; Y = Y0; }
            public float GetX() { return X; } public float GetY() { return Y; }
            public void SetX(float X0) { X = X0; } public void SetY(float Y0) { Y = Y0; }
        }

        public class Shape2D : Point2D
        {
            public enum Shape { Arc, Line, Bezier, Ellipse, Rectangle, Pen, Chord, Pie, None }
            public enum ColorShape { Red, Green, Blue, Black, Yellow }
            public Shape Shap;
            public ColorShape ColorSh;
            public String Name = "";
            public Shape2D Start2D;
            public bool Redraw = false;
            public Pen Pc;
            public Shape2D() { Start2D = null; }
            public Shape2D(int ShapeMode, float X1, float Y1, float X2, float Y2, float X3, float Y3, float X4, float Y4)
            {
                this.Start2D = null;
                if (ShapeMode == 1) { Shap = Shape.Arc; var p1 = new Point2D(X1, Y1); var p2 = new Point2D(X2, Y2); var p3 = new Point2D(X3, Y3); var p4 = new Point2D(X4, Y4); this.StartPoint2D = p1; p1.StartPoint2D = p2; p2.StartPoint2D = p3; p3.StartPoint2D = p4; }
                if (ShapeMode == 2) { Shap = Shape.Line; var p1 = new Point2D(X1, Y1); var p2 = new Point2D(X2, Y2); this.StartPoint2D = p1; p1.StartPoint2D = p2; }
                if (ShapeMode == 3) { Shap = Shape.Bezier; var p1 = new Point2D(X1, Y1); var p2 = new Point2D(X2, Y2); var p3 = new Point2D(X3, Y3); var p4 = new Point2D(X4, Y4); this.StartPoint2D = p1; p1.StartPoint2D = p2; p2.StartPoint2D = p3; p3.StartPoint2D = p4; }
                if (ShapeMode == 4) { Shap = Shape.Ellipse; var p1 = new Point2D(X1, Y1); var p2 = new Point2D(X2, Y2); this.StartPoint2D = p1; p1.StartPoint2D = p2; }
                if (ShapeMode == 5) { Shap = Shape.Rectangle; var p1 = new Point2D(X1, Y1); var p2 = new Point2D(X2, Y2); this.StartPoint2D = p1; p1.StartPoint2D = p2; }
            }
        }
    }
}
