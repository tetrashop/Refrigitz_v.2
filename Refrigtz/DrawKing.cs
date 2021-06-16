using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
namespace RefrigtzDLL
{
    [Serializable]
    public class DrawKing
    {
        //Initiate Global Variables.
        List<int[]> ValuableSelfSupported = new List<int[]>();
      
        public bool MovementsAStarGreedyHuristicFoundT = false;
        public bool IgnoreSelfObjectsT = false;
        public bool UsePenaltyRegardMechnisamT = true;
        public bool BestMovmentsT = false;
        public bool PredictHuristicT = true;
        public bool OnlySelfT = false;
        public bool AStarGreedyHuristicT = false;

        public bool ArrangmentsChanged = false;
        public static double MaxHuristicxK = -20000000000000000;
        public float Row, Column;
        public Color color;
        public int[,] Table = null;
        public ThinkingChess[] KingThinking = new ThinkingChess[AllDraw.KingMovments];
        public int Current = 0;
        public int Order;
        int CurrentAStarGredyMax = -1;

        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText(AllDraw.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
                }
            }
            catch (Exception t) { Log(t); }
        }
        public double ReturnHuristic()
        {
            double a = 0;
            for (int ii = 0; ii < AllDraw.KingMovments; ii++)
                try
                {
                    a += KingThinking[ii].ReturnHuristic(-1, -1, Order);
                }
                catch (Exception t)
                {
                    Log(t);
                }

            return a;
        }
        public bool MaxFound(ref bool MaxNotFound)
        {
            try
            {
                double a = ReturnHuristic();
                if (MaxHuristicxK < a)
                {
                    Object O2 = new Object();
                    lock (O2)
                    {
                        MaxNotFound = false;
                        if (ThinkingChess.MaxHuristicx < MaxHuristicxK)
                            ThinkingChess.MaxHuristicx = a;
                        MaxHuristicxK = a;
                    }
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
        //Constructor 1.
        /*public DrawKing(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
        {
            CurrentAStarGredyMax = CurrentAStarGredy;
            MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
            IgnoreSelfObjectsT = IgnoreSelfObject;
            UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
            BestMovmentsT = BestMovment;
            PredictHuristicT = PredictHurist;
            OnlySelfT = OnlySel;
            AStarGreedyHuristicT = AStarGreedyHuris;
            ArrangmentsChanged = Arrangments;
        }
        */
        //Constructor 2.
        public DrawKing(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, Color a, int[,] Tab, int Ord, bool TB, int Cur//, ref AllDraw. THIS
            )
        {
            
            CurrentAStarGredyMax = CurrentAStarGredy;
            MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
            IgnoreSelfObjectsT = IgnoreSelfObject;
            UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
            BestMovmentsT = BestMovment;
            PredictHuristicT = PredictHurist;
            OnlySelfT = OnlySel;
            AStarGreedyHuristicT = AStarGreedyHuris;
            ArrangmentsChanged = Arrangments;
            //Iniatite Global Variables.
            Table = new int[8, 8];
            for (int ii = 0; ii < 8; ii++)
                for (int jj = 0; jj < 8; jj++)
                    Table[ii, jj] = Tab[ii, jj];
            for (int ii = 0; ii < AllDraw.KingMovments; ii++)
                KingThinking[ii] = new ThinkingChess( CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, (int)i, (int)j, a, Tab, 8, Ord, TB, Cur, 2, 6);

            Row = i;
            Column = j;
            color = a;
            Order = Ord;
            Current = Cur;

        }
        //Clone a Copy.
        public void Clone(ref DrawKing AA//, ref AllDraw. THIS
            )
        {
            int[,] Tab = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Tab[i, j] = this.Table[i, j];
            //Initiate a Construction Object and Clone a Copy.
            AA = new DrawKing( CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, this.Row, this.Column, this.color, this.Table, this.Order, false, this.Current);
            AA.ArrangmentsChanged = ArrangmentsChanged;
            for (int i = 0; i < AllDraw.KingMovments; i++)
            {
                try
                {
                    AA.KingThinking[i] = new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, (int)this.Row, (int)this.Column);
                    this.KingThinking[i].Clone(ref AA.KingThinking[i]);
                }
                catch (Exception t)
                {
                    Log(t);
                    AA.KingThinking[i] = null;
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
        //Draw an Instatnt King on the Table Method.
        public void DrawKingOnTable(ref Graphics g, int CellW, int CellH)
        {

            try
            {
                if (((int)Row >= 0) && ((int)Row < 8) && ((int)Column >= 0) && ((int)Column < 8))
                { //Gray Order.
                    if (color == Color.Gray)
                    {
                        //Draw an Instatnt Gray King Image On the Table.
                        g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "KG.png"), new Rectangle((int)(Row * (float)CellW), (int)(Column * (float)CellH), CellW, CellH));

                    }
                    else
                    {
                        //Draw an Instatnt Brown King Image On the Table.
                        g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "KB.png"), new Rectangle((int)(Row * (float)CellW), (int)(Column * (float)CellH), CellW, CellH));
                    }
                }
            }
            catch (Exception t)
            {
                Log(t);
            }

        }
    }
}
//End of Documentation.