using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
namespace RefrigtzDLL
{
    [Serializable]
    public class DrawMinister//:DrawKing
    {


        StringBuilder Space = new StringBuilder("&nbsp;");
        //#pragma warning disable CS0414 // The field 'DrawMinister.Spaces' is assigned but its value is never used
        int Spaces = 0;
        //#pragma warning restore CS0414 // The field 'DrawMinister.Spaces' is assigned but its value is never used



        public int WinOcuuredatChiled = 0; public int[] LoseOcuuredatChiled = { 0, 0, 0 };



        //Initiate Global Variable.
        List<int[]> ValuableSelfSupported = new List<int[]>();

        public bool MovementsAStarGreedyHeuristicFoundT = false;
        public bool IgnoreSelfObjectsT = false;
        public bool UsePenaltyRegardMechnisamT = false;
        public bool BestMovmentsT = false;
        public bool PredictHeuristicT = true;
        public bool OnlySelfT = false;
        public bool AStarGreedyHeuristicT = false;

        public bool ArrangmentsChanged = true;
        public static long MaxHeuristicxM = -20000000000000000;
        public float Row, Column;
        public Color color;
        public int[,] Table = null;
        public int Current = 0;
        public int Order;
        public ThinkingChess[] MinisterThinking = new ThinkingChess[AllDraw.MinisterMovments];
        int CurrentAStarGredyMax = -1;
        static void Log(Exception ex)
        {

            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    //Write to File.
                    Helper.WaitOnUsed(AllDraw.Root + "\\ErrorProgramRun.txt"); File.AppendAllText(AllDraw.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString());

                }
            }
            catch (Exception t) { }
        }
        public void Dispose()
        {

            ValuableSelfSupported = null;

        }

        public bool MaxFound(ref bool MaxNotFound)
        {

            int a = ReturnHeuristic();
            if (MaxHeuristicxM < a)
            {
                Object O2 = new Object();
                lock (O2)
                {
                    MaxNotFound = false;
                    if (ThinkingChess.MaxHeuristicx < MaxHeuristicxM)
                        ThinkingChess.MaxHeuristicx = a;
                    MaxHeuristicxM = a;
                }

                return true;
            }

            MaxNotFound = true;

            return false;
        }
        public int ReturnHeuristic()
        {
            int HaveKilled = 0;

            int a = 0;
            for (var ii = 0; ii < AllDraw.MinisterMovments; ii++)

                a += MinisterThinking[ii].ReturnHeuristic(-1, -1, Order, false, ref HaveKilled);

            return a;
        }
        //constructor 1.

        //Constructor 2.
        public DrawMinister(int CurrentAStarGredy, bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, float i, float j, Color a, int[,] Tab, int Ord, bool TB, int Cur//, ref AllDraw. THIS
            )
        {

            object balancelock = new object();
            lock (balancelock)
            {

                CurrentAStarGredyMax = CurrentAStarGredy;
                MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
                IgnoreSelfObjectsT = IgnoreSelfObject;
                UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
                BestMovmentsT = BestMovment;
                PredictHeuristicT = PredictHurist;
                OnlySelfT = OnlySel;
                AStarGreedyHeuristicT = AStarGreedyHuris;
                ArrangmentsChanged = Arrangments;
                //Initiate Global Variables.
                Table = new int[8, 8];
                for (var ii = 0; ii < 8; ii++)
                    for (var jj = 0; jj < 8; jj++)
                        Table[ii, jj] = Tab[ii, jj];
                for (var ii = 0; ii < AllDraw.MinisterMovments; ii++)
                    MinisterThinking[ii] = new ThinkingChess(ii, 5, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, (int)i, (int)j, a, CloneATable(Tab), 32, Ord, TB, Cur, 2, 5);

                Row = i;
                Column = j;
                color = a;
                Current = Cur;
                Order = Ord;
            }

        }
        int[,] CloneATable(int[,] Tab)
        {

            Object O = new Object();
            lock (O)
            {
                //Create and new an Object.
                int[,] Table = new int[8, 8];
                //Assigne Parameter To New Objects.
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tab[i, j];
                //Return New Object.

                return Table;
            }

        }
        bool[,] CloneATable(bool[,] Tab)
        {

            Object O = new Object();
            lock (O)
            {
                //Create and new an Object.
                bool[,] Table = new bool[8, 8];
                //Assigne Parameter To New Objects.
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tab[i, j];
                //Return New Object.

                return Table;
            }

        }
        //Clone a Copy.
        public void Clone(ref DrawMinister AA//, ref AllDraw. THIS
            )
        {

            int[,] Tab = new int[8, 8];
            for (var i = 0; i < 8; i++)
                for (var j = 0; j < 8; j++)
                    Tab[i, j] = this.Table[i, j];
            //Initiate an Object and Clone a Construction Objectve.
            AA = new DrawMinister(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Row, Column, this.color, this.CloneATable(Table), this.Order, false, this.Current);
            AA.ArrangmentsChanged = ArrangmentsChanged;
            for (var i = 0; i < AllDraw.MinisterMovments; i++)
            {

                AA.MinisterThinking[i] = new ThinkingChess(i, 5, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, (int)this.Row, (int)this.Column);
                this.MinisterThinking[i].Clone(ref AA.MinisterThinking[i]);


            }
            AA.Table = new int[8, 8];
            for (var ii = 0; ii < 8; ii++)
                for (var jj = 0; jj < 8; jj++)
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
            object balancelockS = new object();

            lock (balancelockS)
            {
                if (g == null)
                    return;

                try
                {

                    //Gray Color.
                    if (((int)Row >= 0) && ((int)Row < 8) && ((int)Column >= 0) && ((int)Column < 8))
                    {
                        //Gray Order.
                        if (Order == 1)
                        {
                            Object O1 = new Object();
                            lock (O1)
                            {    //Draw an Instant from File of Gray Soldeirs.
                                 //Draw a Gray Instatnt Minister Image on the Table.
                                g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MG.png"), new Rectangle((int)(Row * (float)CellW), (int)(Column * (float)CellH), CellW, CellH));
                            }
                        }
                        else
                        {
                            Object O1 = new Object();
                            lock (O1)
                            {    //Draw an Instant from File of Gray Soldeirs.
                                 //Draw a Brown Instatnt Minister Image on the Table.
                                g.DrawImage(Image.FromFile(AllDraw.ImagesSubRoot + "MB.png"), new Rectangle((int)(Row * CellW), (int)(Column * (float)CellH), CellW, CellH));
                            }
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
}

//End of Documentation.
