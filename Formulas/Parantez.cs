using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formulas
{
    public partial class Parantez : Form
    {
        Graphic.Squares Sq = null;
        Graphics g = null;
        static int[] SquredPushed = new int[2];
        int DummyRow = 0, DummyColumn = 0;
        int INTPressded = 0;
        String Contained = null;
        public Parantez()
        {
            InitializeComponent();
        }
        private void Parantez_Load(object sender, EventArgs e)
        {
            this.DrawForm();
            this.DrawParantezOnForm();
        }
        public String GetContained()
        {
            return Contained;
        }
        private void DrawParantezOnForm()
        {
            g.DrawString("(", new Font("Times New Roman", 15), new SolidBrush(Color.Black), 15, 7);
            g.DrawString(")", new Font("Times New Roman", 15), new SolidBrush(Color.Black), 50, 7);
        }
        private void DrawForm()
        {
            int HeightValue = 40;
            int WidthValue = 80;
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Sq = new Graphic.Squares(WidthValue, HeightValue);
            for (int i = 0; i < WidthValue; i = i + 40)
                for (int j = 0; j < HeightValue; j = j + 40)
                {
                    g.DrawRectangle(new Pen(Color.Black, 5), Sq.lwBase[i / 40, j / 40, 0], Sq.lwBase[i / 40, j / 40, 1], 40, 40);
                    g.FillRectangle(new SolidBrush(Color.LightGray), Sq.lwBase[i / 40, j / 40, 0], Sq.lwBase[i / 40, j / 40, 1], 40, 40);
                    g.FillRectangle(new SolidBrush(Color.White), Sq.lwUp[i / 40, j / 40, 0], Sq.lwUp[i / 40, j / 40, 1], 34, 34);
                }
            /*  Integral.BackColor = Color.White;
                Line.BackColor = Color.White;
                Trianglic.BackColor = Color.White;
                Cerices.BackColor = Color.White;
                Root.BackColor = Color.White;
                Parantez.BackColor = Color.White;
                ToUp.BackColor = Color.White;
                ToDown.BackColor = Color.White;
                ToLeft.BackColor = Color.White;
                ToRight.BackColor = Color.White;
             */
        }
        private void Parantez_Paint(object sender, PaintEventArgs e)
        {
            this.DrawForm();
            this.DrawParantezOnForm();
        }
        private void Parantez_MouseMove(object sender, MouseEventArgs e)
        {
            SquredPushed[0] = this.PointToClient(MousePosition).X;
            SquredPushed[1] = this.PointToClient(MousePosition).Y;
            this.PushedRectangle();
        }
        public bool IsOpenedParantez()
        {
            bool Is = false;
            if (INTPressded == 1)
                Is = true;
            return Is;
        }
        public bool IsClosedParantez()
        {
            bool Is = false;
            if (INTPressded == 2)
                Is = true;
            return Is;
        }
        private void PushedRectangle()
        {
            int Row = 0, Column = 0;
            if (Sq != null)
            {
                for (int i = 0; i < Sq.Row; i++)
                {
                    for (int j = 0; j < Sq.Column; j++)
                    {
                        Row = i;
                        Column = j;
                        if (((SquredPushed[0] > Sq.lwBase[Row, Column, 0]) & (SquredPushed[0] < Sq.lwBase[Row, Column, 2])))
                            if (((SquredPushed[1] > Sq.lwBase[Row, Column, 1]) & (SquredPushed[1] < Sq.lwBase[Row, Column, 3])))
                                break;
                    }
                    if (((SquredPushed[0] > Sq.lwBase[Row, Column, 0]) & (SquredPushed[0] < Sq.lwBase[Row, Column, 2])))
                        if (((SquredPushed[1] > Sq.lwBase[Row, Column, 1]) & (SquredPushed[1] < Sq.lwBase[Row, Column, 3])))
                            break;
                }
                if ((Row != DummyRow) || (Column != DummyColumn))
                    if (((SquredPushed[0] > Sq.lwBase[Row, Column, 0]) & (SquredPushed[0] < Sq.lwBase[Row, Column, 2])))
                        if (((SquredPushed[1] > Sq.lwBase[Row, Column, 1]) & (SquredPushed[1] < Sq.lwBase[Row, Column, 3])))
                        {
                            g.DrawRectangle(new Pen(Color.Black, 5), Sq.lwBase[DummyRow, DummyColumn, 0], Sq.lwBase[DummyRow, DummyColumn, 1], 40, 40);
                            g.FillRectangle(new SolidBrush(Color.LightGray), Sq.lwUp[Row, Column, 0], Sq.lwUp[Row, Column, 1], 34, 34);
                            g.FillRectangle(new SolidBrush(Color.White), Sq.lwUp[DummyRow, DummyColumn, 0], Sq.lwUp[DummyRow, DummyColumn, 1], 34, 34);
                            //Open

                            if (Row == 0)
                                if (Column == 0)
                                {
                                    INTPressded = 1;
                                    Contained = "(";
                                }


                            //Close
                            if (Row == 1)
                                if (Column == 0)
                                {
                                    INTPressded = 2;
                                    Contained = ")";
                                }

                            DummyRow = Row;
                            DummyColumn = Column;
                        }
                this.DrawParantezOnForm();
            }
        }
        private void Parantez_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Parantez_Mouseclick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


    }
}