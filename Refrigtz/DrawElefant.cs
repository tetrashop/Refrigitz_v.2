using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
namespace RefrigtzDLL
{
    [Serializable]
    public class DrawElefant
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
        public static double MaxHuristicxE = -20000000000000000;
        public float Row, Column;
        public ThinkingChess[] ElefantThinking = new ThinkingChess[AllDraw.ElefantMovments];
        public int[,] Table = null;
        public Color color;
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
        public bool MaxFound(ref bool MaxNotFound)
        {
            try
            {
                double a = ReturnHuristic();
                if (MaxHuristicxE < a)
                {
                    Object O2 = new Object();
                    lock (O2)
                    {
                        MaxNotFound = false;
                        if (ThinkingChess.MaxHuristicx < MaxHuristicxE)
                            ThinkingChess.MaxHuristicx = a;
                        MaxHuristicxE = a;
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
        public double ReturnHuristic()
        {
            double a = 0;
            for (int ii = 0; ii < AllDraw.ElefantMovments; ii++)
                try
                {
                    a += ElefantThinking[ii].ReturnHuristic(-1, -1, Order);
                }
                catch (Exception t)
                {
                    Log(t);
                }

            return a;
        }

        //Constructor 1.
        /*public DrawElefant(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
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
        }*/
        //Constructor 2.
        public DrawElefant(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, Color a, int[,] Tab, int Ord, bool TB, int Cur//,ref AllDraw. THIS
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
            //Initiate Global Variables By Local Parameters.
            Table = new int[8, 8];
            for (int ii = 0; ii < 8; ii++)
                for (int jj = 0; jj < 8; jj++)
                    Table[ii, jj] = Tab[ii, jj];
            for (int ii = 0; ii < AllDraw.ElefantMovments; ii++)
                ElefantThinking[ii] = new ThinkingChess( CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, (int)i, (int)j, a, Tab, 16, Ord, TB, Cur, 4, 2);

            Row = i;
            Column = j;
            color = a;
            Order = Ord;
            Current = Cur;

        }
        //Clone a Copy.
        public void Clone(ref DrawElefant AA//, ref AllDraw. THIS
            )
        {
            int[,] Tab = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Tab[i, j] = this.Table[i, j];
            //Initiate a Constructed Object an Clone a Copy.
            AA = new DrawElefant( CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, this.Row, this.Column, this.color, this.Table, this.Order, false, this.Current);
            AA.ArrangmentsChanged = ArrangmentsChanged;
            for (int i = 0; i < AllDraw.ElefantMovments; i++)
            {
                try
                {
                    AA.ElefantThinking[i] = new ThinkingChess(CurrentAStarGredyMax, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsChanged, (int)this.Row, (int)this.Column);
                    this.ElefantThinking[i].Clone(ref AA.ElefantThinking[i]);
                }
                catch (Exception t)
                {
                    Log(t);
                    AA.ElefantThinking[i] = null;
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
        //Draw an Instatnt Elephant On the Table.
        public void DrawElefantOnTable(ref Graphics g, int CellW, int CellH)
        {
            try
            {
                //Gray Color.
                if (((int)Row >= 0) && ((int)Row < 8) && ((int)Column >= 0) && ((int)Column < 8))
                {
                    if (color == Color.Gray)
                    {
                        //Draw an Instatnt Gray Elephant On the Table.
                        g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "EG.png"), new Rectangle((int)(Row * (float)CellW), (int)(Column * (float)CellH), CellW, CellH));
                    }
                    else
                    {
                        //Draw an Instatnt Brown Elepehnt On the Table.
                        g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "EB.png"), new Rectangle((int)(Row * (float)CellW), (int)(Column * (float)CellH), CellW, CellH));
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