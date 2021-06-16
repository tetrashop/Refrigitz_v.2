using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
namespace RefrigtzW
{
    public class DrawMinister//:DrawKing
    {
        //Initiate Global Variable.
        public bool MovementsAStarGreedyHuristicFoundT = false;
        public bool IgnoreSelfObjectsT = false;
        public bool UsePenaltyRegardMechnisamT = true;
        public bool BestMovmentsT = false;
        public bool PredictHuristicT = true;
        public bool OnlySelfT = false;
        public bool AStarGreedyHuristicT = false;

        public bool ArrangmentsChanged = false;
        public static double MaxHuristicxM = -20000000000000000;
        public float Row, Column;
        public Color color;
        public int[,] Table = null;
        public int Current = 0;
        public int Order;
        public ThinkingChess[] MinisterThinking = new ThinkingChess[AllDraw.MinisterMovments];
        static void Log(Exception ex)
        {
            try
            {
                string stackTrace = ex.ToString();
                File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
            }
            catch (Exception t) { Log(t); }
        }
        public bool MaxFound(ref bool MaxNotFound)
        {
            try
            {
                double a = ReturnHuristic();
                if (MaxHuristicxM < a)
                {
                    MaxNotFound = false;
                    if (ThinkingChess.MaxHuristicx < MaxHuristicxM)
                        ThinkingChess.MaxHuristicx = a;
                    MaxHuristicxM = a;
                    return true;
                }
            }
            catch (Exception t)
            {
                Log(t);

            }
            MaxNotFound = true;
            return false;
        }
        public double ReturnHuristic()
        {
            double a = 0;
            for (int ii = 0; ii < AllDraw.MinisterMovments; ii++)
                try
                {
                    a += MinisterThinking[ii].ReturnHuristic(-1, -1, Order);
                }
                catch (Exception t)
                {
                    Log(t);
                }
            return a;
        }
        //constructor 1.
        public DrawMinister(bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
        {
            MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
            IgnoreSelfObjectsT = IgnoreSelfObject;
            UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
            BestMovmentsT = BestMovment;
            PredictHuristicT = PredictHurist;
            OnlySelfT = OnlySel;
            AStarGreedyHuristicT = AStarGreedyHuris;
            ArrangmentsChanged = Arrangments;
        }
        //Constructor 2.
        public DrawMinister(bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, Color a, int[,] Tab, int Ord, bool TB, int Cur//, ref FormRefrigtz THIS
            )
        {
            MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
            IgnoreSelfObjectsT = IgnoreSelfObject;
            UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
            BestMovmentsT = BestMovment;
            PredictHuristicT = PredictHurist;
            OnlySelfT = OnlySel;
            AStarGreedyHuristicT = AStarGreedyHuris;
            ArrangmentsChanged = Arrangments;
            //Initiate Global Variables.
            Table = new int[8, 8];
            for (int ii = 0; ii < 8; ii++)
                for (int jj = 0; jj < 8; jj++)
                    Table[ii, jj] = Tab[ii, jj];
            for (int ii = 0; ii < AllDraw.MinisterMovments; ii++)
                MinisterThinking[ii] = new ThinkingChess(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, (int)i, (int)j, a, Tab, 32, Ord, TB, Cur, 2, 5);

            Row = i;
            Column = j;
            color = a;
            Current = Cur;
            Order = Ord;

        }
        //Clone a Copy.
        public void Clone(ref DrawMinister AA//, ref FormRefrigtz THIS
            )
        {
            int[,] Tab = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Tab[i, j] = this.Table[i, j];
            //Initiate an Object and Clone a Construction Objectve.
            AA = new DrawMinister(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, Row, Column, this.color, this.Table, this.Order, false, this.Current);
            AA.ArrangmentsChanged = ArrangmentsChanged;
            for (int i = 0; i < AllDraw.MinisterMovments; i++)
            {
                try
                {
                    AA.MinisterThinking[i] = new ThinkingChess(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, (int)this.Row, (int)this.Column);
                    this.MinisterThinking[i].Clone(ref AA.MinisterThinking[i]);
                }
                catch (Exception t)
                {
                    Log(t);
                    AA.MinisterThinking[i] = null;
                }

            }
            AA.Table = new int[8, 8];
            for (int ii = 0; ii < 8; ii++)
                for (int jj = 0; jj < 8; jj++)
                    AA.Table[ii, jj] = Tab[ii, jj];
            AA.Row = Row;
            AA.Column = Column;
            AA.Order = Order;
            AA.Current = Current;
            AA.color = color;

        }
        //Draw an Mnister on the Table.
        public void DrawMinisterOnTable(ref Graphics g, int CellW, int CellH)
        {
            try
            {
                //Gray Order.
                if (color == Color.Gray)
                {
                    //Draw a Gray Instatnt Minister Image on the Table.
                    g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MG.png"), new Rectangle((int)(Row * (float)CellW), (int)(Column * (float)CellH), CellW, CellH));
                }
                else
                {
                    //Draw a Brown Instatnt Minister Image on the Table.
                    g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MB.png"), new Rectangle((int)(Row * CellW), (int)(Column * (float)CellH), CellW, CellH));
                }

            }
            catch (Exception t) { Log(t); }
        }
    }
}
//End of Documentation.