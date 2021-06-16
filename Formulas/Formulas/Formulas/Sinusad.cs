using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formulas
{
    public partial class Sinusad : Form
    {
        Graphics g = null;

        Trianglic Tr = null;
        int INTPressde = -1;
        static int[] SquredPushed = new int[2];

        int DummyRow = 0, DummyColumn = 0;
        PictureBox Sin = new PictureBox();
        PictureBox Cos = new PictureBox();
        PictureBox Tan = new PictureBox();
        PictureBox Cot = new PictureBox();
        PictureBox Sec = new PictureBox();
        PictureBox Csc = new PictureBox();
        Equation EqationVariable = null;
        static String Contained = "";
        public Sinusad(ref Sinusad E, ref Equation A)
        {
            InitializeComponent();
            E = this;
            EqationVariable = A;
        }
        private void Sinusad_Load(object sender, EventArgs e)
        {
            this.Location = new Point(EqationVariable.Location.X + EqationVariable.SqAccess.lwBase[2, 0, 0]
            , EqationVariable.Location.Y + EqationVariable.SqAccess.lwBase[2, 0, 1]);
        }
        public int SendINTPresedSinusad()
        {
            return INTPressde;
        }
        private void DrawSinusadArea(int dx, int dy)
        {
            g = this.CreateGraphics();
            Tr = new Trianglic(dx, dy);
            for (int i = 0; i < dx; i = i + 40)
                for (int j = 0; j < dy; j = j + 40)
                {
                    g.DrawRectangle(new Pen(Color.Black, 5), Tr.lwBase[i / 40, j / 40, 0], Tr.lwBase[i / 40, j / 40, 1], 40, 40);
                    g.FillRectangle(new SolidBrush(Color.LightGray), Tr.lwBase[i / 40, j / 40, 0], Tr.lwBase[i / 40, j / 40, 1], 40, 40);
                    g.FillRectangle(new SolidBrush(Color.White), Tr.lwUp[i / 40, j / 40, 0], Tr.lwUp[i / 40, j / 40, 1], 34, 34);
                }
        }

        private void Sinusad_Paint(object sender, PaintEventArgs e)
        {
            this.DrawSinusadArea(this.Width, this.Height);
            this.DrawSinusad();
        }

        private void Sinusad_Activated(object sender, EventArgs e)
        {
            this.Location = new Point(EqationVariable.Location.X + EqationVariable.SqAccess.lwBase[2, 0, 0]
             , EqationVariable.Location.Y + EqationVariable.SqAccess.lwBase[2, 0, 1]);
            this.DrawSinusadArea(this.Width, this.Height);
        }
        private void DrawSinusad()
        {
            g.DrawString("Sin", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 5, 10);
            g.DrawString("Cos", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 45, 10);
            g.DrawString("Tan", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 85, 10);
            g.DrawString("Cot", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 125, 10);
            g.DrawString("Sec", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 5, 45);
            g.DrawString("Csc", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 45, 45);
            g.DrawString("Ln", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 85, 45);
            g.DrawString("Log", new Font("new Times roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), 125, 45);
        }
        private void PushedRectangle()
        {
            int Row = 0, Column = 0;
            if (Tr != null)
            {
                for (int i = 0; i < Tr.Row; i++)
                {
                    for (int j = 0; j < Tr.Column; j++)
                    {
                        Row = i;
                        Column = j;
                        if (((SquredPushed[0] > Tr.lwBase[Row, Column, 0]) & (SquredPushed[0] < Tr.lwBase[Row, Column, 2])))
                            if (((SquredPushed[1] > Tr.lwBase[Row, Column, 1]) & (SquredPushed[1] < Tr.lwBase[Row, Column, 3])))
                                break;
                    }
                    if (((SquredPushed[0] > Tr.lwBase[Row, Column, 0]) & (SquredPushed[0] < Tr.lwBase[Row, Column, 2])))
                        if (((SquredPushed[1] > Tr.lwBase[Row, Column, 1]) & (SquredPushed[1] < Tr.lwBase[Row, Column, 3])))
                            break;
                }
                if ((Row != DummyRow) || (Column != DummyColumn))
                    if (((SquredPushed[0] > Tr.lwBase[Row, Column, 0]) & (SquredPushed[0] < Tr.lwBase[Row, Column, 2])))
                        if (((SquredPushed[1] > Tr.lwBase[Row, Column, 1]) & (SquredPushed[1] < Tr.lwBase[Row, Column, 3])))
                        {
                            g.DrawRectangle(new Pen(Color.Black, 5), Tr.lwBase[DummyRow, DummyColumn, 0], Tr.lwBase[DummyRow, DummyColumn, 1], 40, 40);
                            g.FillRectangle(new SolidBrush(Color.LightGray), Tr.lwUp[Row, Column, 0], Tr.lwUp[Row, Column, 1], 34, 34);
                            g.FillRectangle(new SolidBrush(Color.White), Tr.lwUp[DummyRow, DummyColumn, 0], Tr.lwUp[DummyRow, DummyColumn, 1], 34, 34);
                            //Sin
                            if (DummyRow == 0)
                                if (DummyColumn == 0)
                                    Sin.BackColor = Color.White;

                            if (Row == 0)
                                if (Column == 0)
                                {
                                    INTPressde = 0;
                                    Sin.BackColor = Color.LightGray;
                                }
                            //Cos
                            if (DummyRow == 1)
                                if (DummyColumn == 0)
                                    Cos.BackColor = Color.White;


                            if (Row == 1)
                                if (Column == 0)
                                {
                                    INTPressde = 1;
                                    Cos.BackColor = Color.LightGray;
                                }
                            //Tan
                            if (DummyRow == 2)
                                if (DummyColumn == 0)

                                    Tan.BackColor = Color.White;

                            if (Row == 2)
                                if (Column == 0)
                                {
                                    INTPressde = 2;
                                    Tan.BackColor = Color.LightGray;
                                }
                            //Cot
                            if (DummyRow == 3)
                                if (DummyColumn == 0)
                                    Cot.BackColor = Color.White;

                            if (Row == 3)
                                if (Column == 0)
                                {
                                    Cot.BackColor = Color.LightGray;
                                    INTPressde = 3;
                                }
                            //Sec
                            if (DummyRow == 0)
                                if (DummyColumn == 1)


                                    Sec.BackColor = Color.White;

                            if (Row == 0)
                                if (Column == 1)
                                {
                                    INTPressde = 4;
                                    Sec.BackColor = Color.LightGray;
                                }
                            //Csc
                            if (DummyRow == 1)
                                if (DummyColumn == 1)

                                    Csc.BackColor = Color.White;

                            if (Row == 1)
                                if (Column == 1)
                                {
                                    INTPressde = 5;
                                    Csc.BackColor = Color.LightGray;
                                }
                            //Ln
                            if (DummyRow == 2)
                                if (DummyColumn == 1)

                                    Csc.BackColor = Color.White;

                            if (Row == 2)
                                if (Column == 1)
                                {
                                    INTPressde = 6;
                                    Csc.BackColor = Color.LightGray;
                                }
                            //Log
                            if (DummyRow == 3)
                                if (DummyColumn == 1)

                                    Csc.BackColor = Color.White;

                            if (Row == 3)
                                if (Column == 1)
                                {
                                    INTPressde = 7;
                                    Csc.BackColor = Color.LightGray;
                                }
                            this.DrawSinusad();
                            DummyRow = Row;
                            DummyColumn = Column;
                        }
            }
        }
        private void Sinusad_MouseMove(object sender, MouseEventArgs e)
        {
            SquredPushed[0] = this.PointToClient(MousePosition).X;
            SquredPushed[1] = this.PointToClient(MousePosition).Y;
            this.PushedRectangle();
        }
        private void Sinusad_Click(object sender, EventArgs e)
        {
            Contained = EqationVariable.GetString(INTPressde);
            if (INTPressde != -1)
                this.Hide();
        }
        public String GetContained()
        {
            return Contained;
        }
    }
    class Trianglic
    {
        public int[,,] lwBase = null;
        public int[,,] lwUp = null;
        public int Row = 0;
        public int Column = 0;
        public Trianglic(int destinx, int destiny)
        {
            Row = (destinx) / 40;
            Column = (destiny) / 40;
            lwBase = new int[(destinx) / 40, (destiny) / 40, 4];
            lwUp = new int[(destinx) / 40, (destiny) / 40, 4];
            for (int i = 0; i < destinx; i = i + 40)
                for (int j = 0; j < destiny; j = j + 40)
                {
                    lwBase[i / 40, j / 40, 0] = i;
                    lwBase[i / 40, j / 40, 1] = j;
                    lwBase[i / 40, j / 40, 2] = i + 40;
                    lwBase[i / 40, j / 40, 3] = j + 40;
                    lwUp[i / 40, j / 40, 0] = i + 3;
                    lwUp[i / 40, j / 40, 1] = j + 3;
                    lwUp[i / 40, j / 40, 2] = i + 40 - 3;
                    lwUp[i / 40, j / 40, 3] = j + 40 - 3;
                }

        }
    }
}