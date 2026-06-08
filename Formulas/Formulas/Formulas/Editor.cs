//ERRORCORECTION6456546464:The Length Of Numbers has determined:1394/3/31
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Editors
{
    public partial class Editor : Form
    {
        Graphics g = null;
        Image Map;
        static int X = 10, Y = 10;
        public Editor()
        {
            InitializeComponent();
            this.pictureBoxInOut.Location = new Point(10, 10);
            this.pictureBoxInOut.Size = new System.Drawing.Size(this.Width - 40, this.Height - 40);
            Map = new Bitmap(this.Width - 30, this.Height - 30);
            this.pictureBoxInOut.Image = Map;
            g = Graphics.FromImage(Map);
            pictureBoxInOut.Refresh();
        }
        /*public Graphics GetGraphics()
        {
            return g;
        }
         */
        public Graphics GraphicsAccess
        {
            get { return g; }
            set { g = value; }
        }
        public PictureBox PictureBoxAccess
        {
            get { return pictureBoxInOut; }
            set { pictureBoxInOut = value; }
        }
        private void Editor_Load(object sender, EventArgs e)
        {
        }
        private void DrawIntegralOnForm()
        {
            g.DrawImage(Image.FromFile
              (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

              + "Integral.gif"), new Rectangle(X, Y, 30, 30));
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
            X += 32; ;
        }
        private void DrawLineOnForm()
        {
            g.DrawImage(Image.FromFile
             (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

             + "Line.gif"), new Rectangle(X, Y, 30, 30));
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
            X += 32; ;
        }
        private void DrawTrianglicOnForm()
        {
            g.DrawImage(Image.FromFile
                (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

                + "Trianglic.gif"), new Rectangle(X, Y, 30, 30));

            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        private void DrawCericesOnForm()
        {
            g.DrawImage(Image.FromFile
                (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

                + "Cerices.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        private void DrawRootOnForm()
        {
            g.DrawImage(Image.FromFile
                 (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

                 + "Root.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        private void DrawParantezOnForm()
        {
            g.DrawImage(Image.FromFile
              (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

              + "Parantez.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        private void DrawToUpOnForm()
        {
            g.DrawImage(Image.FromFile
              (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

              + "ToUp.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        private void DrawToDownOnForm()
        {
            g.DrawImage(Image.FromFile
                (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

              + "ToDown.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }

        private void DrawToLeftOnForm()
        {
            g.DrawImage(Image.FromFile
              (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

              + "ToLeft.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        private void DrawToRightOnForm()
        {
            g.DrawImage(Image.FromFile
              (System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\"

              + "ToRight.gif"), new Rectangle(X, Y, 30, 30));
            X += 32;
            if (X > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
        }
        public void FiveBasicOprators(int A)
        {

            if (X + 32 > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
            if (A == 0)
                g.DrawString("+", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(X, Y, 30, 30));
            else
                if (A == 1)
                g.DrawString("-", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(X, Y, 30, 30));
            else
                    if (A == 2)
                g.DrawString("*", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(X, Y, 30, 30));
            else
                        if (A == 3)
                g.DrawString("/", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(X, Y, 30, 30));
            else
                            if (A == 4)
                g.DrawString("^", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(X, Y, 30, 30));
            X += 32;

        }
        public void DrawNumberAndVaribale(String A)
        {
            if (A == null)
                return;
            if (X + 32 * A.Length > this.pictureBoxInOut.Image.Width - 40)
            {
                X = 10;
                Y += 70;
            }
            g.DrawString(A, new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(X, Y, 30 * A.Length, 30));//ERRORCORECTION6456546464:The Length Of Numbers has determined:1394/3/31
            X += 32 * A.Length;

        }
        private void Editor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxInOut_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxInOut_Paint(object sender, PaintEventArgs e)
        {
            this.pictureBoxInOut.Location = new Point(10, 10);
            this.pictureBoxInOut.Size = new System.Drawing.Size(this.Width - 40, this.Height - 40);
            this.pictureBoxInOut.Image = Map;
            pictureBoxInOut.Refresh();

        }
    }
}