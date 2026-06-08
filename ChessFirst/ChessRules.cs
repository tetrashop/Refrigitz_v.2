
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
namespace ChessFirst
{
    [Serializable]
    public class ChessRules
    {

        StringBuilder Space = new StringBuilder("&nbsp;");


        int Spaces = 0;

        //

        public bool IgnoreSelfObject = false;
        public static int ObjectHittedRow = -1;
        public static bool SelfHomeStatCP = false;
        public static int ObjectHittedColumn = -1;
        //Inititae Global Variables.
        public bool MovementsAStarGreedyHeuristicFoundT = false;
        public bool IgnoreSelfObjectsT = false;
        public bool UsePenaltyRegardMechnisamT = false;
        public bool BestMovmentsT = false;
        public bool PredictHeuristicT = true;
        public bool OnlySelfT = false;
        public bool AStarGreedyHeuristicT = false;
        static int NumbersofKingMovesToPatGray = 0;
        static int NumbersofKingMovesToPatBrown = 0;
        public static bool PatCheckedInKingRule = false;
        public static bool CastleKingAllowedGray = true;
        public static bool CastleKingAllowedBrown = true;
        public static bool KingAttacker = false;
        public static bool SmallKingCastleBrown = false;
        public static bool KingCastleBrown = false;
        public static bool SmallKingCastleGray = false;
        public static bool KingCastleGray = false;
        public static bool BigKingCastleBrown = false;
        public static bool BigKingCastleGray = false;
        public static bool CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporter = false;
        public static int CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber = 0;
        public static bool CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
        public bool CheckGrayObjectDangour = false;
        public bool CheckBrownObjectDangour = false;
        public static bool CheckGrayObjectDangourFirstTimesOcured = false;
        public static bool CheckBrownObjectDangourFirstTimesOcured = false;
        public static bool CastleActGray = false;
        public static bool CastleActBrown = false;
        public static int CurrentOrder = 1;
        public bool PatkGray = false;
        public bool PatBrown = false;
        public bool CheckGray = false;
        public bool CheckBrown = false;
        public bool CheckMateGray = false;
        public bool CheckMateBrown = false;
        public static bool CheckGrayRemovable = true;
        public static bool CheckBrownRemovable = true;
        public static int CheckGrayRemovableValueRowi = 0;
        public static int CheckGrayRemovableValueColumni = 0;
        public static int CheckGrayRemovableValueRowii = 0;
        public static int CheckGrayRemovableValueColumnjj = 0;
        public static int CheckBrownRemovableValueRowi = 0;
        public static int CheckBrownRemovableValueColumnj = 0;
        public static int CheckBrownRemovableValueRowii = 0;
        public static int CheckBrownRemovableValueColumnjj = 0;
        int Kind;
        int KindNA;
        int Row, Column;
        int[,] TableS = new int[8, 8];
        int Order = 0;
        //public bool ExistInDestinationEnemy = false;
        bool ArrangmentsBoard = false;
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
#pragma warning disable CS0168 // The variable 't' is declared but never used
            catch (Exception t) { }
#pragma warning restore CS0168 // The variable 't' is declared but never used
        }
        public ChessRules(int CurrentAStarGredy, bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int oRDER)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            CurrentAStarGredyMax = CurrentAStarGredy;
            MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
            IgnoreSelfObjectsT = IgnoreSelfObject;
            UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
            BestMovmentsT = BestMovment;
            PredictHeuristicT = PredictHurist;
            OnlySelfT = OnlySel;
            AStarGreedyHeuristicT = AStarGreedyHuris;
            Order = oRDER;
            ArrangmentsBoard = ArrangmentsChanged;
            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ChessRules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
        }
        public ChessRules(int CurrentAStarGredy, int oRDER, bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            CurrentAStarGredyMax = CurrentAStarGredy;
            Order = oRDER;
            MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
            IgnoreSelfObjectsT = IgnoreSelfObject;
            UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
            BestMovmentsT = BestMovment;
            PredictHeuristicT = PredictHurist;
            OnlySelfT = OnlySel;
            AStarGreedyHeuristicT = AStarGreedyHuris;
            ArrangmentsBoard = ArrangmentsChanged;
            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ChessRules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
        }
        //Constructor 
        public ChessRules(int CurrentAStarGredy, bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int Ki, int[,] A, int Ord, int i, int j)
        {
            Object O = new Object();
            lock (O)
            { //long Time = TimeElapced.TimeNow();Spaces++;

                CurrentAStarGredyMax = CurrentAStarGredy;
                MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
                IgnoreSelfObjectsT = IgnoreSelfObject;
                UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
                BestMovmentsT = BestMovment;
                PredictHeuristicT = PredictHurist;
                OnlySelfT = OnlySel;
                AStarGreedyHeuristicT = AStarGreedyHuris;
                ArrangmentsBoard = ArrangmentsChanged;
                Row = i;
                Column = j;

                //Initiate Global Variables By Local Parameters.
                KindNA = Ki;
                Kind = System.Math.Abs(Ki);
                TableS = CloneATable(A);

                Order = Ord;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ChessRules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
            }
        }
        //Initiate of Rules of ChessFirst Refregitz.
        public bool Rules(int RowFirst, //The First Click Row
            int ColumnFirst, //The First Click Column.
            int RowSecond, //The Destination Click Row
            int ColumnSecond, //The Destination Click Column
            Color color,//int.  
            int Ki//Current Kind.
            , bool SelfHomeStatCP = true
            )
        {
            Object O = new Object();
            lock (O)
            {
                if (RowFirst == RowSecond && ColumnFirst == ColumnSecond)
                    return false;
                int[,] Table = CloneATable(TableS);

                if (RowFirst == RowSecond && ColumnFirst == ColumnSecond)
                    return false;
                if (Order == 1 && Table[RowFirst, ColumnFirst] < 0)
                    return false;
                if (Order == -1 && Table[RowFirst, ColumnFirst] > 0)
                    return false;

                if (Order == 1 && Table[RowFirst, ColumnFirst] == 0)
                    return false;
                if (Order == -1 && Table[RowFirst, ColumnFirst] == 0)
                    return false;
                //long Time = TimeElapced.TimeNow();Spaces++;


                if (Table[RowFirst, ColumnFirst] > 0 && Table[RowSecond, ColumnSecond] > 0)
                {
                    if (!SelfHomeStatCP)
                        IgnoreSelfObject = true;
                    else
                        IgnoreSelfObject = false;
                }
                else
                    IgnoreSelfObject = false;

                if (Table[RowFirst, ColumnFirst] < 0 && Table[RowSecond, ColumnSecond] < 0)
                {
                    if (!SelfHomeStatCP)
                        IgnoreSelfObject = true;
                    else
                        IgnoreSelfObject = false;
                }
                else
                    IgnoreSelfObject = false;

                //Initaite Global Varibales.
                Object O1 = new Object();
                lock (O1)
                {
                    CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporter = false;
                    CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber = 0;
                }
                //When Order is Non Detectable Continue Traversal Back.
                //if (Order != CurrentOrder)
                //  return false;
                //Found Location of Tow Gray and Brown Kings. 
                int RowB = 0, ColumnB = 0;
                int RowG = 0, ColumnG = 0;
                FindBrownKing(CloneATable(TableS), ref RowB, ref ColumnB);
                FindGrayKing(CloneATable(TableS), ref RowG, ref ColumnG);

                //Gray Order.
                if ((Order == 1))
                {
                    if (Table[RowFirst, ColumnFirst] == 6)
                    {
                        if (System.Math.Abs(RowB - RowSecond) <= 1 && System.Math.Abs(ColumnB - ColumnSecond) <= 1)
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return false;
                        }
                    }
                    //Illegal King Foundation.
                    if (System.Math.Abs(RowB - RowG) <= 1 && System.Math.Abs(ColumnB - ColumnG) <= 1)
                    {
                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return false;
                    }
                }//Brown Order.
                else
                {
                    if (Table[RowFirst, ColumnFirst] == -6)
                    {
                        if (System.Math.Abs(RowG - RowSecond) <= 1 && System.Math.Abs(ColumnG - ColumnSecond) <= 1)
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return false;
                        }
                    }
                    //Ilegal Kings Foundation.
                    if (System.Math.Abs(RowB - RowG) <= 1 && System.Math.Abs(ColumnB - ColumnG) <= 1)
                    {
                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return false;
                    }
                }
                //Determination of Enemy in the Destionation Home.
                bool ExistInDestinationEnemy = new bool();
                if (((Table[RowFirst, ColumnFirst] > 0) && (Table[RowSecond, ColumnSecond] < 0) && (Order == 1)))
                {
                    ExistInDestinationEnemy = true;
                }
                else
                    if (((Table[RowFirst, ColumnFirst] < 0) && (Table[RowSecond, ColumnSecond] > 0) && (Order == -1)))
                {
                    ExistInDestinationEnemy = true;
                }

                //If There is A Source of Soldier.
                if (System.Math.Abs(Kind) == 1)
                {
                    if (!(ArrangmentsBoard))
                    {
                        //Solders of Gray at Begining.
                        if (ColumnFirst == 1 && (Order == 1))
                        {

                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                        }
                        else//Solder of Brown At Begining.
                            if (ColumnFirst == 6 && (Order == -1))
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                        }
                        else//Another Solder Movments.
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                        }
                    }
                    else
                    {
                        //Solders of Gray at Begining.
                        if (ColumnFirst == 6 && (Order == 1))
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                        }
                        else//Solder of Brown At Begining.
                            if (ColumnFirst == 1 && (Order == -1))
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                        }
                        else//Another Solder Movments.
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                        }
                    }
                }
                else//For another Kind of Objects.
                {
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
                }
            }
        }
        //Castle King Movment Consideration.
        public bool CastleKing(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, int Ki)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                if ((ArrangmentsBoard))
                {             //Gray Order.
                    if (Order == 1)
                    {
                        //When Gray Castles Not Act.
                        if (ChessFirst.ChessRules.CastleKingAllowedGray)
                        {
                            //If Column is At First Location.
                            if (ColumnFirst == 7 && ColumnSecond == 7)
                            {
                                //When Kings Moves for Small Kings Castles Movments.
                                if (RowFirst == RowSecond - 2 && ((RowSecond - 2) >= 0))
                                {
                                    //Consideration of Castles King of Gray King.

                                    if (((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && ((RowSecond - 2) >= 0) && Table[RowSecond - 2, ColumnSecond] == 6 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond + 1, ColumnSecond] == 4)
                                    {
                                        Object OO = new Object();
                                        lock (OO)
                                        {
                                            CastleActGray = true;
                                            SmallKingCastleGray = true;
                                        }
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        return true;
                                    }

                                }

                                else//For Greates Castles King Movments.
                                    if (RowFirst == RowSecond + 2 && ((RowSecond + 2) < 8))
                                {
                                    //Consideration of Castles King M<ovments.

                                    if (((RowSecond + 2) < 8) && ((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && ((RowSecond - 2) >= 0) && Table[RowSecond + 2, ColumnSecond] == 6 && Table[RowSecond + 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond - 2, ColumnSecond] == 4)
                                    {
                                        Object OO = new Object();
                                        lock (OO)
                                        {
                                            CastleActGray = true;
                                            BigKingCastleGray = true;
                                        }
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        return true;
                                    }


                                }
                            }
                        }
                    }
                    else//Order of Brown.
                    {
                        //When Brown Castles King Not Occured.
                        if (ChessFirst.ChessRules.CastleKingAllowedBrown)
                        {
                            //Column Situation.
                            if (ColumnFirst == 0 && ColumnSecond == 0)
                            {
                                //Small Brown King Castles Consideration.
                                if (RowFirst == RowSecond - 2 && ((RowSecond - 2) < 8))
                                {


                                    if (((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && Table[RowSecond - 2, ColumnSecond] == -6 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond + 1, ColumnSecond] == -4)
                                    {
                                        //CastleActBrown = true;
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            CastleActBrown = true;
                                            SmallKingCastleBrown = true;
                                        }
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        return true;
                                    }


                                }
                                else
                                    if (RowFirst == RowSecond + 2 && ((RowSecond + 2) < 8))
                                //Brown Kings.Big King Castles Consideration.
                                {

                                    if (((RowSecond + 2) < 8) && ((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && ((RowSecond - 2) >= 0) && Table[RowSecond + 2, ColumnSecond] == -6 && Table[RowSecond + 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond - 2, ColumnSecond] == -4)
                                    {
                                        //CastleActBrown = true;
                                        Object OO = new Object();
                                        lock (OO)
                                        {
                                            CastleActBrown = true;
                                            BigKingCastleBrown = true;
                                        }
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        return true;
                                    }

                                }
                            }
                        }
                    }
                }
                else
                {
                    //Gray Order.
                    if (Order == 1)
                    {
                        //When Gray Castles Not Act.
                        if (ChessFirst.ChessRules.CastleKingAllowedGray)
                        {
                            //If Column is At First Location.
                            if (ColumnFirst == 0 && ColumnSecond == 0)
                            {
                                //When Kings Moves for Small Kings Castles Movments.
                                if (RowFirst == RowSecond - 2 && ((RowSecond - 2) >= 0))
                                {
                                    //Consideration of Castles King of Gray King.


                                    if (((RowSecond - 2) >= 0) && ((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && Table[RowSecond - 2, ColumnSecond] == 6 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond + 1, ColumnSecond] == 4)
                                    {
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        CastleActGray = true;
                                        SmallKingCastleGray = true;
                                        return true;
                                    }

                                }

                                else//For Greates Castles King Movments.
                                    if (RowFirst == RowSecond + 2 && ((RowSecond + 2) < 8))
                                {
                                    //Consideration of Castles King M<ovments.

                                    if (((RowSecond + 2) < 8) && ((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && ((RowSecond - 2) >= 0) && Table[RowSecond + 2, ColumnSecond] == 6 && Table[RowSecond + 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond - 2, ColumnSecond] == 4)
                                    {
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        CastleActGray = true;
                                        BigKingCastleGray = true;
                                        return true;
                                    }


                                }
                            }
                        }
                    }
                    else//Order of Brown.
                    {
                        //When Brown Castles King Not Occured.
                        if (ChessFirst.ChessRules.CastleKingAllowedBrown)
                        {
                            //Column Situation.
                            if (ColumnFirst == 7 && ColumnSecond == 7)
                            {
                                //Small Brown King Castles Consideration.
                                if (RowFirst == RowSecond - 2 && ((RowSecond - 2) > 0))
                                {


                                    if (((RowSecond - 2) >= 0) && ((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && Table[RowSecond - 2, ColumnSecond] == -6 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond + 1, ColumnSecond] == -4)
                                    {
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        CastleActBrown = true;
                                        SmallKingCastleBrown = true;
                                        return true;
                                    }


                                }
                                else
                                    if (RowFirst == RowSecond + 2 && ((RowSecond + 2) < 8))
                                //Brown Kings.Big King Castles Consideration.
                                {

                                    if (((RowSecond + 2) < 8) && ((RowSecond - 1) >= 0) && ((RowSecond + 1) < 8) && ((RowSecond - 2) >= 0) && Table[RowSecond + 2, ColumnSecond] == -6 && Table[RowSecond + 1, ColumnSecond] == 0 && Table[RowSecond, ColumnSecond] == 0 && Table[RowSecond - 1, ColumnSecond] == 0 && Table[RowSecond - 2, ColumnSecond] == -4)
                                    {
                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                        CastleActBrown = true;
                                        BigKingCastleBrown = true;
                                        return true;
                                    }

                                }
                            }
                        }
                    }
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return false;
            }
        }
        //Simulation and Consdtruction of Check.
        public bool CheckConstructor(Color color, int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, int Ki, int Order)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                 //Initiate a Local Variable.
                 //Clone A Copy of Table.
                int[,] tab = CloneATable(TableS);


                //Act a Move.
                tab[RowSecond, ColumnSecond] = tab[RowFirst, ColumnFirst];
                tab[RowFirst, ColumnFirst] = 0;
                //If There is Check State.
                if (Check(tab, Order))
                {
                    //When int of Order is Gray Check return Check State.
                    if (Order == 1)
                        if (CheckGray)
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckConstructor:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return true;
                        }
                    //When int is Brown State  there is Check State return Check State.
                    if (Order == -1)
                        if (CheckBrown)
                        {
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckConstructor:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return true;
                        }
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckConstructor:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Return Non Check State.
                return false;
            }
        }
        //Method of Self Home int Objects Consideration.
        private bool ExistSelfHome(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, int Ki)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                //Initiate of Local Variable.
                bool NotExistInDestinationSelfHome = false;
                //When There is Not Source and Destination is the Same Home Location. 
                if (RowFirst != RowSecond || ColumnFirst != ColumnSecond)
                {
                    //If the Same Gray int Return Self Home. 
                    if (Table[RowSecond, ColumnSecond] > 0 && Table[RowFirst, ColumnFirst] > 0)
                        NotExistInDestinationSelfHome = true;
                    else//If The Same int Brown Return Self Home.
                        if (Table[RowSecond, ColumnSecond] < 0 && Table[RowFirst, ColumnFirst] < 0)
                        NotExistInDestinationSelfHome = true;
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ExistSelfHome:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return NotExistInDestinationSelfHome;
            }
        }

        //Object Danger Consideration
        public bool ObjectDangourKingMove(int Order, int[,] Table, bool DoIgnore)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;
                int[,] Tab = new int[8, 8];
                //Clone a Copy
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Tab[i, j] = Table[i, j];
                //Initiate Variables.
                CheckGray = false;
                CheckBrown = false;
                CheckGrayObjectDangour = false;
                CheckBrownObjectDangour = false;
                int RowG = 0, ColumnG = 0;
                int RowB = 0, ColumnB = 0;
                //Object O = new Object();
                ////lock (O)
                ///{
                /// if (DoIgnore)
                ///ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = true;
                // }
                //Check identification.
                //Check(CloneATable(Tab), Order);
                bool CheckGrayDummy = CheckGray;
                bool CheckBrownDummy = CheckBrown;
                //If There is Check on Tow Side.

                int CDummy = ChessFirst.ChessRules.CurrentOrder;
                int COrder = Order;
                if (Order == 1)
                {
                    //Location of King Gary
                    if (FindGrayKing(CloneATable(Tab), ref RowG, ref ColumnG))
                    {
                        //For Enemy Brown.
                        for (var ii = 0; ii < 8; ii++)
                        {
                            for (var jj = 0; jj < 8; jj++)
                            {

                                //Ignore Gray.
                                if (Tab[ii, jj] >= 0)
                                    continue;
                                //For Current Gray and Empty.
                                for (var iii = 0; iii < 8; iii++)
                                {
                                    for (var jjj = 0; jjj < 8; jjj++)
                                    {
                                        for (var i = 0; i < 8; i++)
                                            for (var j = 0; j < 8; j++)
                                                Tab[i, j] = Table[i, j];
                                        //Ignore Brown.
                                        if (Tab[iii, jjj] < 0)
                                            continue;
                                        ChessFirst.ThinkingChessFirst AA = new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, ii, jj);
                                        //When There is Attacked to Gray from Brown.
                                        if (AA.Attack(CloneATable(Tab), ii, jj, iii, jjj, Color.Brown, Order * -1))
                                        {
                                            //Move.
                                            int a = Tab[iii, jjj];
                                            Tab[iii, jjj] = Tab[ii, jj];
                                            Tab[ii, jj] = 0;
                                            int[,] Tabl = new int[8, 8];
                                            for (int h = 0; h < 8; h++)
                                                for (int g = 0; g < 8; g++)
                                                    Tabl[h, g] = Tab[h, g];
                                            ChessFirst.ChessRules AAA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tabl[iii, jjj], CloneATable(Tabl), Order, iii, jjj);
                                            //When there is checked or checkmate.
                                            if (AAA.CheckMate(Tabl, Order))
                                            {
                                                //if (AAA.CheckMateGray)
                                                if (AAA.CheckMateGray)
                                                {
                                                    CheckGrayObjectDangour = true;
                                                    break;
                                                }
                                            }
                                            //CheckGrayObjectDangour = true;
                                        }
                                        if (CheckGrayObjectDangour)
                                            break;

                                    }
                                    if (CheckGrayObjectDangour)
                                        break;
                                }
                                if (CheckGrayObjectDangour)
                                    break;

                            }
                            if (CheckGrayObjectDangour)
                                break;

                        }
                    }
                }
                else
                {
                    //Location of King Brown
                    if (FindBrownKing(CloneATable(Tab), ref RowB, ref ColumnB))
                    {

                        //For Gray Enemy.
                        for (var ii = 0; ii < 8; ii++)
                        {
                            for (var jj = 0; jj < 8; jj++)
                            {
                                //Ignore Brown
                                if (Tab[ii, jj] <= 0)
                                    continue;
                                //For Current Brown.
                                for (var iii = 0; iii < 8; iii++)
                                {
                                    for (var jjj = 0; jjj < 8; jjj++)
                                    {
                                        for (var i = 0; i < 8; i++)
                                            for (var j = 0; j < 8; j++)
                                                Tab[i, j] = Table[i, j];
                                        //Ignore Gray.
                                        if (Tab[iii, jjj] > 0)
                                            continue;

                                        ChessFirst.ThinkingChessFirst AA = new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, ii, jj);
                                        //When There is Attack to Brown.
                                        if (AA.Attack(CloneATable(Tab), ii, jj, iii, jjj, Color.Gray, Order * -1))
                                        {
                                            //Move
                                            int a = Tab[iii, jjj];
                                            Tab[iii, jjj] = Tab[ii, jj];
                                            Tab[ii, jj] = 0;
                                            int[,] Tabl = new int[8, 8];
                                            for (int h = 0; h < 8; h++)
                                                for (int g = 0; g < 8; g++)
                                                    Tabl[h, g] = Tab[h, g];
                                            ChessFirst.ChessRules AAA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tabl[iii, jjj], CloneATable(Tabl), Order, iii, jjj);
                                            //When There is Check or Checkedmate
                                            if (AAA.CheckMate(Tabl, Order))
                                            {
                                                //if (AAA.CheckMateBrown)
                                                if (AAA.CheckMateBrown)
                                                {
                                                    CheckBrownObjectDangour = true;
                                                    break;
                                                }

                                            }

                                            //CheckBrownObjectDangour = true;

                                        }
                                        if (CheckBrownObjectDangour)
                                            break;
                                    }
                                    if (CheckBrownObjectDangour)
                                        break;
                                }
                                if (CheckBrownObjectDangour)
                                    break;

                            }
                            if (CheckBrownObjectDangour)
                                break;

                        }
                    }
                }
                //Iniaiate Global Variables.
                //Object O1 = new Object();
                //lock (O1)
                //{
                //ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
                //}
                //If There is Brown ObjectDanger Or Gray ObjectDanger.
                if (CheckBrownObjectDangour || CheckGrayObjectDangour)
                {
                    //Iniaate Global Check Variable By Local Variables.
                    ChessFirst.ChessRules.CurrentOrder = CDummy;
                    Order = COrder;
                    CheckGray = CheckGrayDummy;
                    CheckBrown = CheckBrownDummy;
                    //Achamz is Validity.
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return true;
                }
                ChessFirst.ChessRules.CurrentOrder = CDummy;
                Order = COrder;

                //Iniatiate Of Global Varibales By Local Variables.
                CheckGray = CheckGrayDummy;
                CheckBrown = CheckBrownDummy;
                //Return Not Validiy.
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return false;
            }
        }
        public bool ObjectDangourKingMove(int Order, int[,] Table)
        {
            Object O = new Object();
            lock (O)
            {   //long Time = TimeElapced.TimeNow();Spaces++;
                int[,] Tab = new int[8, 8];
                //Clone a Copy
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Tab[i, j] = Table[i, j];
                //Initiate Variables.
                CheckGray = false;
                CheckBrown = false;
                CheckGrayObjectDangour = false;
                CheckBrownObjectDangour = false;
                int RowG = 0, ColumnG = 0;
                int RowB = 0, ColumnB = 0;
                //Object O = new Object();
                ////lock (O)
                ///{
                /// if (DoIgnore)
                ///ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = true;
                // }
                //Check identification.
                //Check(CloneATable(Tab), Order);
                bool CheckGrayDummy = CheckGray;
                bool CheckBrownDummy = CheckBrown;
                //If There is Check on Tow Side.

                int CDummy = ChessFirst.ChessRules.CurrentOrder;
                int COrder = Order;
                if (Order == 1)
                {
                    //Location of King Gary
                    if (FindGrayKing(CloneATable(Tab), ref RowG, ref ColumnG))
                    {
                        //For Enemy Brown.
                        for (var ii = 0; ii < 8; ii++)
                        {
                            for (var jj = 0; jj < 8; jj++)
                            {

                                //Ignore Gray.
                                if (Tab[ii, jj] >= 0)
                                    continue;
                                //For Current Gray and Empty.
                                for (var iii = 0; iii < 8; iii++)
                                {
                                    for (var jjj = 0; jjj < 8; jjj++)
                                    {
                                        for (var i = 0; i < 8; i++)
                                            for (var j = 0; j < 8; j++)
                                                Tab[i, j] = Table[i, j];
                                        //Ignore Brown.
                                        if (Tab[iii, jjj] < 0)
                                            continue;
                                        ChessFirst.ThinkingChessFirst AA = new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, ii, jj);
                                        //When There is Attacked to Gray from Brown.
                                        if (AA.Attack(CloneATable(Tab), ii, jj, iii, jjj, Color.Brown, Order * -1))
                                        {
                                            //Move.
                                            int a = Tab[iii, jjj];
                                            Tab[iii, jjj] = Tab[ii, jj];
                                            Tab[ii, jj] = 0;
                                            int[,] Tabl = new int[8, 8];
                                            for (int h = 0; h < 8; h++)
                                                for (int g = 0; g < 8; g++)
                                                    Tabl[h, g] = Tab[h, g];
                                            ChessFirst.ChessRules AAA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tabl[iii, jjj], CloneATable(Tabl), Order, iii, jjj);
                                            //When there is checked or checkmate.
                                            if (AAA.Check(Tabl, Order))
                                            {
                                                //if (AAA.CheckMateGray)
                                                if (AAA.CheckGray)
                                                {
                                                    CheckGrayObjectDangour = true;
                                                    break;
                                                }
                                            }
                                            //CheckGrayObjectDangour = true;
                                        }
                                        if (CheckGrayObjectDangour)
                                            break;

                                    }
                                    if (CheckGrayObjectDangour)
                                        break;
                                }
                                if (CheckGrayObjectDangour)
                                    break;

                            }
                            if (CheckGrayObjectDangour)
                                break;

                        }
                    }
                }
                else
                {
                    //Location of King Brown
                    if (FindBrownKing(CloneATable(Tab), ref RowB, ref ColumnB))
                    {

                        //For Gray Enemy.
                        for (var ii = 0; ii < 8; ii++)
                        {
                            for (var jj = 0; jj < 8; jj++)
                            {
                                //Ignore Brown
                                if (Tab[ii, jj] <= 0)
                                    continue;
                                //For Current Brown.
                                for (var iii = 0; iii < 8; iii++)
                                {
                                    for (var jjj = 0; jjj < 8; jjj++)
                                    {
                                        for (var i = 0; i < 8; i++)
                                            for (var j = 0; j < 8; j++)
                                                Tab[i, j] = Table[i, j];
                                        //Ignore Gray.
                                        if (Tab[iii, jjj] > 0)
                                            continue;

                                        ChessFirst.ThinkingChessFirst AA = new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, ii, jj);
                                        //When There is Attack to Brown.
                                        if (AA.Attack(CloneATable(Tab), ii, jj, iii, jjj, Color.Gray, Order * -1))
                                        {
                                            //Move
                                            int a = Tab[iii, jjj];
                                            Tab[iii, jjj] = Tab[ii, jj];
                                            Tab[ii, jj] = 0;
                                            int[,] Tabl = new int[8, 8];
                                            for (int h = 0; h < 8; h++)
                                                for (int g = 0; g < 8; g++)
                                                    Tabl[h, g] = Tab[h, g];
                                            ChessFirst.ChessRules AAA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tabl[iii, jjj], CloneATable(Tabl), Order, iii, jjj);
                                            //When There is Check or Checkedmate
                                            if (AAA.Check(Tabl, Order))
                                            {
                                                //if (AAA.CheckMateBrown)
                                                if (AAA.CheckBrown)
                                                {
                                                    CheckBrownObjectDangour = true;
                                                    break;
                                                }

                                            }

                                            //CheckBrownObjectDangour = true;

                                        }
                                        if (CheckBrownObjectDangour)
                                            break;
                                    }
                                    if (CheckBrownObjectDangour)
                                        break;
                                }
                                if (CheckBrownObjectDangour)
                                    break;

                            }
                            if (CheckBrownObjectDangour)
                                break;

                        }
                    }
                }
                //Iniaiate Global Variables.
                //Object O1 = new Object();
                //lock (O1)
                //{
                //ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
                //}
                //If There is Brown ObjectDanger Or Gray ObjectDanger.
                if (CheckBrownObjectDangour || CheckGrayObjectDangour)
                {
                    //Iniaate Global Check Variable By Local Variables.
                    ChessFirst.ChessRules.CurrentOrder = CDummy;
                    Order = COrder;
                    CheckGray = CheckGrayDummy;
                    CheckBrown = CheckBrownDummy;
                    //Achamz is Validity.
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return true;
                }
                ChessFirst.ChessRules.CurrentOrder = CDummy;
                Order = COrder;

                //Iniatiate Of Global Varibales By Local Variables.
                CheckGray = CheckGrayDummy;
                CheckBrown = CheckBrownDummy;
                //Return Not Validiy.
                return false;
            }
        }
        bool AchmazCheckByMoveByRule(int[,] Tabl, int RowF, int ColumnF, int RowS, int ColumnS, int Order)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                bool Achmaz = false;
                int[,] Table = new int[8, 8];
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tabl[i, j];
                Table[RowS, ColumnS] = Table[RowF, ColumnF];
                Table[RowF, ColumnF] = 0;
                if (Check(CloneATable(Table), Order))
                {
                    if (Order == 1 && CheckGray)
                        Achmaz = true;
                    if (Order == -1 && CheckBrown)
                        Achmaz = true;

                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("AchmazCheckByMoveByRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Achmaz;
            }
        }
        public bool ObjectDangourKingMove(int Order, int[,] Table, bool DoIgnore, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            { //long Time = TimeElapced.TimeNow();Spaces++;
                int[,] Tab = new int[8, 8];
                //Clone a Copy
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Tab[i, j] = Table[i, j];
                //Initiate Variables.
                CheckGray = false;
                CheckBrown = false;
                CheckGrayObjectDangour = false;
                CheckBrownObjectDangour = false;
                Object OO = new Object();
                lock (OO)
                {
                    if (DoIgnore)
                        ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = true;
                }

                //Check identification.
                Check(CloneATable(Tab), Order);
                bool CheckGrayDummy = CheckGray;
                bool CheckBrownDummy = CheckBrown;
                //If There is Check on Tow Side.
                if (CheckBrown || CheckGray)
                {
                    //Check meand achmaz.
                    if (CheckBrown)
                        CheckBrownObjectDangour = true;
                    if (CheckGray)
                        CheckGrayObjectDangour = true;
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return true;

                }
                int CDummy = ChessFirst.ChessRules.CurrentOrder;
                int COrder = Order;

                //Location of King Gary

                {
                    //Iniatite Global Varibales.
                    ChessFirst.ChessRules.CurrentOrder = -1;
                    Order = -1;
                    //For Enemies.
                    for (var i = 0; i < 8; i++)
                    {
                        for (var j = 0; j < 8; j++)
                        {
                            //Ignore of current.
                            if (Order == 1 && Tab[i, i] >= 0)
                                continue;
                            if (Order == -1 && Tab[i, i] <= 0)
                                continue;
                            //For All Current
                            for (var iii = 0; iii < 8; iii++)
                            {
                                for (var jjj = 0; jjj < 8; jjj++)
                                {
                                    //Ignore of enemies.
                                    if (Order == 1 && Tab[iii, jjj] <= 0)
                                        continue;
                                    if (Order == -1 && Tab[iii, jjj] >= 0)
                                        continue;


                                    //Clone a Copy
                                    for (var ik = 0; ik < 8; ik++)
                                        for (var jk = 0; jk < 8; jk++)
                                            Tab[ik, jk] = Table[ik, jk];
                                    ChessFirst.ChessRules A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tab[i, j], CloneATable(Tab), Order * -1, i, j);
                                    Color a = Color.Gray;
                                    if (Order * -1 == -1)
                                        a = Color.Brown;
                                    //When Enemies can gard King
                                    if (A.Rules(i, j, iii, jjj, a, Tab[i, j]))
                                    {
                                        Tab[iii, jjj] = Tab[i, j];
                                        Tab[i, j] = 0;
                                        if (A.CheckMate(CloneATable(Tab), Order))
                                        {
                                            if (Order == 1 && A.CheckMateGray)
                                            {
                                                //For Current.
                                                for (var iiii = 0; iiii < 8; iiii++)
                                                {
                                                    for (var jjjj = 0; jjjj < 8; jjjj++)
                                                    {
                                                        //Ignore of enemies.
                                                        if (Order == 1 && Tab[iiii, jjjj] <= 0)
                                                            continue;
                                                        if (Order == -1 && Tab[iiii, jjjj] >= 0)
                                                            continue;
                                                        //For Enemies and Emety.
                                                        for (int iiiii = 0; iiiii < 8; iiiii++)
                                                        {
                                                            for (int jjjjj = 0; jjjjj < 8; jjjjj++)
                                                            {
                                                                //Ignore of Current.
                                                                if (Order == 1 && Tab[iiiii, jjjjj] > 0)
                                                                    continue;
                                                                if (Order == -1 && Tab[iiiii, jjjjj] < 0)
                                                                    continue;
                                                                for (var ik = 0; ik < 8; ik++)
                                                                    for (var jk = 0; jk < 8; jk++)
                                                                        Tab[ik, jk] = Table[ik, jk];
                                                                Tab[iii, jjj] = Tab[i, j];
                                                                Tab[i, j] = 0;

                                                                A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tab[iiii, jjjj], CloneATable(Tab), Order, iiii, jjjj);
                                                                if (A.Rules(iiii, jjjj, iiiii, jjjjj, a, Tab[i, j]))
                                                                {
                                                                    Tab[iiiii, jjjjj] = Tab[iiii, jjjj];
                                                                    Tab[iiii, jjjj] = 0;
                                                                    if (A.CheckMate(CloneATable(Tab), Order))
                                                                    {
                                                                        CheckBrown = A.CheckBrown;
                                                                        CheckGray = A.CheckGray;
                                                                        CheckMateGray = A.CheckMateGray;
                                                                        CheckMateBrown = A.CheckMateBrown;
                                                                        CheckGrayObjectDangour = A.CheckGrayObjectDangour;
                                                                        CheckBrownObjectDangour = A.CheckBrownObjectDangour;
                                                                        ChessFirst.ChessRules.CurrentOrder = CDummy;
                                                                        Order = COrder;
                                                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                                                        return true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                            }
                                            else
                                                if (Order == -1 && A.CheckMateBrown)
                                            {

                                                //For Current.
                                                for (var iiii = 0; iiii < 8; iiii++)
                                                {
                                                    for (var jjjj = 0; jjjj < 8; jjjj++)
                                                    {
                                                        //Ignore of enemies.
                                                        if (Order == 1 && Tab[iiii, jjjj] <= 0)
                                                            continue;
                                                        if (Order == -1 && Tab[iiii, jjjj] >= 0)
                                                            continue;
                                                        //For Enemies and Emety.
                                                        for (int iiiii = 0; iiiii < 8; iiiii++)
                                                        {
                                                            for (int jjjjj = 0; jjjjj < 8; jjjjj++)
                                                            {
                                                                //Ignore of Current.
                                                                if (Order == 1 && Tab[iiiii, jjjjj] > 0)
                                                                    continue;
                                                                if (Order == -1 && Tab[iiiii, jjjjj] < 0)
                                                                    continue;
                                                                for (var ik = 0; ik < 8; ik++)
                                                                    for (var jk = 0; jk < 8; jk++)
                                                                        Tab[ik, jk] = Table[ik, jk];
                                                                Tab[iii, jjj] = Tab[i, j];
                                                                Tab[i, j] = 0;

                                                                A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Tab[iiii, jjjj], CloneATable(Tab), Order, iiii, jjjj);
                                                                if (A.Rules(iiii, jjjj, iiiii, jjjjj, a, Tab[i, j]))
                                                                {
                                                                    Tab[iiiii, jjjjj] = Tab[iiii, jjjj];
                                                                    Tab[iiii, jjjj] = 0;
                                                                    if (A.CheckMate(CloneATable(Tab), Order))
                                                                    {
                                                                        CheckBrown = A.CheckBrown;
                                                                        CheckGray = A.CheckGray;
                                                                        CheckMateGray = A.CheckMateGray;
                                                                        CheckMateBrown = A.CheckMateBrown;
                                                                        CheckGrayObjectDangour = A.CheckGrayObjectDangour;
                                                                        CheckBrownObjectDangour = A.CheckBrownObjectDangour;
                                                                        ChessFirst.ChessRules.CurrentOrder = CDummy;
                                                                        Order = COrder;
                                                                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                                                        return true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }


                                        }

                                    }

                                }
                            }
                        }
                    }

                }

                ChessFirst.ChessRules.CurrentOrder = CDummy;
                Order = COrder;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ObjectDangourKingMove:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Iniatiate Of Global Varibales By Local Variables.
                //Return Not Validiy.
                return false;
            }
        }
        //Gray King Founder.
        public bool FindGrayKing(int[,] Table, ref int Row, ref int Column)
        {
            Object O = new Object();
            lock (O)
            {   //long Time = TimeElapced.TimeNow();Spaces++;
                //For All Home Table.
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        //If Current is Gray Home 
                        if (Table[i, j] == 6)
                        {
                            //Initiate Refreable Parameters.
                            Row = i;
                            Column = j;
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindGrayKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            return true;
                        }
                    }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindGrayKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Not Found.
                return false;
            }
        }
        //Alpahber Object Consideration.
        static String ThingsAlphabet(int i)
        {
            Object O = new Object();
            lock (O)
            { //long Time = TimeElapced.TimeNow();
              //Initiate a Local Varibale. 
                String A = "";
                //Determinbe Gray Or Brown Movment.
                if (i < 0)
                    A = "Brown:";
                if (i > 0)
                    A = "Gray:";
                //Determine Object Alhpabet. 
                if (System.Math.Abs(i) == 1)
                    A += "(S)";
                if (System.Math.Abs(i) == 2)
                    A += "(E)";
                if (System.Math.Abs(i) == 3)
                    A += "(H)";
                if (System.Math.Abs(i) == 4)
                    A += "(B)";
                if (System.Math.Abs(i) == 5)
                    A += "(M)";
                if (System.Math.Abs(i) == 6)
                    A += "(K)";
                //Retrun Alphabet.
                ////AllDraw.OutPut.Append("\r\nThingsAlphabet:" + (TimeElapced.TimeNow() - Time).ToString());
                return A;

            }
        }
        //Row Alphabet Consideration.
        static String RowAlphabet(int i)
        {
            Object O = new Object();
            lock (O)
            {        //long Time = TimeElapced.TimeNow();
                     //Initiate Local Variable.
                String A = "";
                //Row Alphabet Consideration.
                if (i == 0)
                    A = "a";
                if (i == 1)
                    A = "b";
                if (i == 2)
                    A = "c";
                if (i == 3)
                    A = "d";
                if (i == 4)
                    A = "e";
                if (i == 5)
                    A = "f";
                if (i == 6)
                    A = "g";
                if (i == 7)
                    A = "h";
                //Return Row Alphabet.
                ////AllDraw.OutPut.Append("\r\nRowAlphabet:" + (TimeElapced.TimeNow() - Time).ToString());
                return A;

            }
        }
        //Create Syntax of Movments.
        public String CreateStatistic(bool Arrange, int[,] Tab, int Movments, int SourceThings, int Column, int Row, bool Hit, int HitThings, bool CastleKing, bool SodierConvert//, ref AllDraw. THIS

            )
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            Object OOO = new Object();
            lock (OOO)
            {
                ArrangmentsBoard = Arrange;

                bool ms = false;
                int bn = Movments;
                if (((bn) % 2) == 1)
                    ms = true;
                //Movments String Number Creation in String.
                bn = ((int)(bn / 2)) + 1;
                String SN = "";
                String S = "";
                if (ms)
                    SN = bn.ToString() + ".";


                //Consider CheckMate Condition of Table.
                ChessFirst.ChessRules A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, Arrange, 1, CloneATable(Tab), 1, Row, Column);
                ChessFirst.ChessRules AA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, Arrange, 1, CloneATable(Tab), 1, Row, Column);
                ChessFirst.ChessRules AAA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, Arrange, 1, CloneATable(Tab), 1, Row, Column);
                A.CheckMate(CloneATable(Tab), Order);
                AA.ObjectDangourKingMove(Order, CloneATable(Tab), false);
                Color a = Color.Gray;
                if (Order == -1)
                    a = Color.Brown;
                AAA.Pat(CloneATable(Tab), Order, a);
                if (A.CheckGray)
                {
                    Object O2 = new Object();
                    lock (O2)
                    {
                        ChessFirst.ChessRules.CastleKingAllowedGray = false;
                        ChessFirst.ChessRules.CastleActGray = true;
                        ChessFirst.ThinkingChessFirst.KingMaovableGray = true;
                    }
                }
                else if (A.CheckBrown)
                {
                    Object O2 = new Object();
                    lock (O2)
                    {
                        ChessFirst.ChessRules.CastleActBrown = true;
                        ChessFirst.ChessRules.CastleKingAllowedBrown = false;
                        ChessFirst.ThinkingChessFirst.KingMaovableBrown = true;
                    }
                }
                bool Castles = false;
                if (Order == 1)
                    if (ChessFirst.ChessRules.SmallKingCastleGray || ChessFirst.ChessRules.BigKingCastleGray)
                        Castles = true;
                if (Order == -1)
                    if (ChessFirst.ChessRules.SmallKingCastleBrown || ChessFirst.ChessRules.BigKingCastleBrown)
                        Castles = true;
                //When Solder Converted or Castles King Acts.
                if (SodierConvert || (CastleKing && Castles))
                {
                    //When Castles Acts.
                    if (CastleKing)
                    {
                        //Castles Brown King.
                        if (ChessFirst.ChessRules.SmallKingCastleGray)
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                ChessFirst.ThinkingChessFirst.KingMaovableGray = true;
                                S += "Gray-BK-S";
                                Object O = new Object();
                                lock (O)
                                {
                                    if (!AllDraw.Stockfish)
                                    {
                                        ChessFirst.ChessRules.SmallKingCastleGray = false;
                                        ChessFirst.ChessRules.CastleKingAllowedGray = false;
                                    }
                                }
                            }
                        }
                        else
                            if (ChessFirst.ChessRules.BigKingCastleGray)
                        //Castles Brown King.                    
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                S += "Gray-BK-B";
                                ChessFirst.ThinkingChessFirst.KingMaovableGray = true;
                                Object O = new Object();
                                lock (O)
                                {
                                    if (!AllDraw.Stockfish)
                                    {
                                        ChessFirst.ChessRules.BigKingCastleGray = false;
                                        ChessFirst.ChessRules.CastleKingAllowedGray = false;
                                    }
                                }
                            }
                        }
                        else
                                if (ChessFirst.ChessRules.SmallKingCastleBrown)
                        //Castles Brown King.                    
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                S += "Brown-BK-S";
                                ChessFirst.ThinkingChessFirst.KingMaovableBrown = true;
                                Object O = new Object();
                                lock (O)
                                {
                                    if (!AllDraw.Stockfish)
                                    {
                                        ChessFirst.ChessRules.SmallKingCastleBrown = false;
                                        ChessFirst.ChessRules.CastleKingAllowedBrown = false;
                                    }
                                }
                            }
                        }
                        else
                                    if (ChessFirst.ChessRules.BigKingCastleBrown)
                        //Castles Brown King.                    
                        {

                            Object O2 = new Object();
                            lock (O2)
                            {
                                S += "Brown-BK-B";
                                ChessFirst.ThinkingChessFirst.KingMaovableBrown = true;
                                Object O = new Object();
                                lock (O)
                                {
                                    if (!AllDraw.Stockfish)
                                    {
                                        ChessFirst.ChessRules.BigKingCastleBrown = false;
                                        ChessFirst.ChessRules.CastleKingAllowedBrown = false;
                                    }
                                }
                            }
                        }
                        //Castles Brown King.                    

                        //Great Castles Gray King.

                    }
                    //Soldier Converted.
                    if (SodierConvert)
                    {
                        //Object Kind String Addition.
                        S += ThingsAlphabet(SourceThings);
                        //If Hit Acts.
                        if (Hit)
                        {
                            Object O = new Object();
                            lock (O)
                            {
                                ObjectHittedRow = Row;
                                ObjectHittedColumn = Column;
                            }
                            //THIS.SetObjectInPictureBox(Row, Column);

                            S += "x";
                        }
                        S += Column.ToString();
                        //CheckMate of Gray Or Brown
                        if (AAA.PatkGray || AAA.PatBrown)
                        {
                            S += "-O-";
                        }
                        else
                            if (A.CheckMateGray || A.CheckMateBrown)
                        {
                            S += "++";
                        }
                        //Check Of Gray Or Brown.
                        else if (A.CheckBrown || A.CheckGray)
                        {

                            S += "+";
                            if (A.CheckBrown && Order == -1)
                            {
                                Object O2 = new Object();
                                lock (O2)
                                {
                                    ChessFirst.ThinkingChessFirst.KingMaovableBrown = true;
                                    ChessFirst.ChessRules.BigKingCastleBrown = false;
                                    ChessFirst.ChessRules.CastleKingAllowedBrown = false;
                                }
                            }
                            if (A.CheckGray && Order == 1)
                            {
                                Object O2 = new Object();
                                lock (O2)
                                {
                                    ChessFirst.ThinkingChessFirst.KingMaovableGray = true;
                                    ChessFirst.ChessRules.BigKingCastleGray = false;
                                    ChessFirst.ChessRules.CastleKingAllowedGray = false;
                                }
                            }
                        }
                        else if (AA.CheckGrayObjectDangour || AA.CheckBrownObjectDangour)
                        {

                            if (AA.CheckGrayObjectDangour && Order == -1)
                            {
                                Object O2 = new Object();
                                lock (O2)
                                {
                                    ChessFirst.ThinkingChessFirst.KingMaovableBrown = true;

                                }
                            }
                            if (AA.CheckBrownObjectDangour && Order == 1)
                            {
                                Object O2 = new Object();
                                lock (O2)
                                {
                                    ChessFirst.ThinkingChessFirst.KingMaovableGray = true;

                                }
                            }
                        }

                    }
                }
                else//Brown Order.
                {
                    //Object of Kind.
                    S += ThingsAlphabet(SourceThings);
                    //Hit Consideration.
                    if (Hit)
                    {
                        Object O = new Object();
                        lock (O)
                        {
                            ObjectHittedRow = Row;
                            ObjectHittedColumn = Column;
                        }
                        //THIS.SetObjectInPictureBox(Row, Column);
                        S += "x";
                    }
                    //Row Column Consideration.
                    S += RowAlphabet(Row);
                    S += Column.ToString();
                    //CheckMate Consideration.
                    if (AAA.PatkGray || AAA.PatBrown)
                    {
                        S += "-O-";
                    }
                    else

                        if (A.CheckMateGray || A.CheckMateBrown)
                    {
                        S += "++";
                    }
                    //Gray Consideration.
                    else if (A.CheckBrown || A.CheckGray)
                    {
                        S += "+";
                        if (A.CheckBrown && Order == -1)
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                ChessFirst.ChessRules.BigKingCastleBrown = false;
                                ChessFirst.ChessRules.CastleKingAllowedBrown = false;
                                ChessFirst.ThinkingChessFirst.KingMaovableGray = true;

                            }
                        }
                        if (A.CheckGray && Order == 1)
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                ChessFirst.ChessRules.BigKingCastleGray = false;
                                ChessFirst.ChessRules.CastleKingAllowedGray = false;
                                ChessFirst.ThinkingChessFirst.KingMaovableGray = true;

                            }
                        }
                    }
                    else if (AA.CheckGrayObjectDangour || AA.CheckBrownObjectDangour)
                    {

                        if (AA.CheckGrayObjectDangour && Order == -1)
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                ChessFirst.ThinkingChessFirst.KingMaovableBrown = true;

                            }
                        }
                        if (AA.CheckBrownObjectDangour && Order == 1)
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                ChessFirst.ThinkingChessFirst.KingMaovableGray = true;

                            }
                        }
                    }


                }
                //Separate.
                if (AllDraw.Less != int.MinValue)
                    S += " With Heuristic (" + AllDraw.Less.ToString() + ")--";
                else
                    S += " --";
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CreateStatistic:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Return String Sysntax.
                return SN + S;
            }
        }
        //Consideration of Existing Table in List.
        bool ArrayInList(List<int[]> List, int[] A)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                 //Initiate Local Variables.
                bool Is = false;
                //For each Items of a Tow Part List.
                for (var i = 0; i < List.Count; i++)
                {
                    //If Listis Equal Setting of Local Variable Equality.
                    if (A[0] == List[i][0] && A[1] == List[i][1])
                        Is = true;
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ArrayInList:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Retrun Condition.
                return Is;
            }
        }
        //Find a Specific Objects.
        public bool FindAThing(int[,] Table, ref int Row, ref int Column, int Thing, bool BeMovable, List<int[]> List)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;
                  //For All Items In Table Home.
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        //Initiate Local Variables.
                        int[] AA = new int[2];
                        AA[0] = i;
                        AA[1] = j;
                        //If Table Home is Eqaul Tow Things Object.
                        if (Table[i, j] == Thing)
                        {
                            //If Set A Global Variable Low Logical.
                            if (!BeMovable)
                            {
                                //If Array Exist In List Continue Traversal Back.
                                if (ArrayInList(List, AA))
                                    continue;
                                //Iniatiate Local Varibales.
                                Row = i;
                                Column = j;
                                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindAThing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                //Found State.
                                return true;
                            }
                            else//else of Condition.
                            {
                                //Iniatiate Local Variables.
                                Color A = Color.Gray;
                                if (Order == -1)
                                    A = Color.Brown;
                                //For All Second Home.
                                for (var ii = 0; ii < 8; ii++)
                                    for (var jj = 0; jj < 8; jj++)
                                    {
                                        //If First Home is Movable to Second Home.
                                        if ((new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, i, j)).Movable(CloneATable(Table), i, j, ii, jj, A, Order))
                                        {
                                            //If Array Exist in Home.
                                            if (ArrayInList(List, AA))
                                                continue;
                                            //Initaite Local Variables.
                                            Row = i;
                                            Column = j;
                                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindAThing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                            //Found of State
                                            return true;
                                        }

                                    }
                            }

                        }
                    }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindAThing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Not Found State.
                return false;
            }
        }
        //Brown King Found  Consideration.
        public bool FindBrownKing(int[,] Table, ref int Row, ref int Column)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                 //For All Home Table.
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        //If Current Home is Brown King.
                        if (Table[i, j] == -6)
                        {
                            //Initiate Refrencable Parameter.
                            Row = i;
                            Column = j;
                            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindBrownKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                            //Found of Brown King.
                            return true;
                        }
                    }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("FindBrownKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Not Found.
                return false;
            }
        }
        //A Constraint Check Removed Unused Method.
        public bool CheckRemovableByAttack(int[,] Table, int Order)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;
                  //Initiate Local Variables.
                int[,] Tabl = new int[8, 8];
                //Clone a Copy.
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Tabl[i, j] = Table[i, j];
                //Initiate Global Variables.
                Object OO = new Object();
                lock (OO)
                {
                    CheckGrayRemovable = true;

                    CheckBrownRemovable = true;
                }

                Check(Tabl, Order);
                //if (Order == -1)
                {
                    //For All Home Tables in Fourth Second Traversal.
                    for (var i = 0; i < 8; i++)
                        for (var j = 0; j < 8; j++)
                            for (var ii = 0; ii < 8; ii++)
                                for (var jj = 0; jj < 8; jj++)
                                {
                                    //If Tow How is the Same Continue Traversal Back.
                                    if (i == ii && j == jj)
                                        continue;
                                    //If is Brown Order.
                                    if (Table[i, j] < 0)
                                    {
                                        //If Is Gray Order.
                                        if (Table[ii, jj] > 0)
                                        {
                                            //Initiate Local Variables.
                                            int[,] Tab = new int[8, 8];
                                            //Clone  a Copy.
                                            for (var iii = 0; iii < 8; iii++)
                                                for (var jjj = 0; jjj < 8; jjj++)
                                                {
                                                    Tab[iii, jjj] = Table[iii, jjj];
                                                }
                                            //If Is Movable.
                                            if ((new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, i, j)).Movable(CloneATable(Tab), i, j, ii, jj, Color.Brown, -1))
                                            {
                                                //Clone a Copy.
                                                for (var iii = 0; iii < 8; iii++)
                                                    for (var jjj = 0; jjj < 8; jjj++)
                                                    {
                                                        Tab[iii, jjj] = Table[iii, jjj];
                                                    }
                                                //If Brown Check.
                                                if (CheckBrown)
                                                {
                                                    //Initiate Local Variables.
                                                    Tab[ii, jj] = Tab[i, j];
                                                    Tab[i, j] = 0;
                                                    //If There is Not Check.
                                                    if (!Check(CloneATable(Tab), Order))
                                                    {
                                                        //If Is Not Brown Check.
                                                        if (!CheckBrown)
                                                        {
                                                            //Initiate and Move.
                                                            Tab[i, j] = Table[ii, jj];
                                                            Tab[ii, jj] = 0;
                                                            Object O1 = new Object();
                                                            lock (O1)
                                                            {
                                                                CheckBrownRemovableValueRowi = i;
                                                                CheckGrayRemovableValueColumni = j;
                                                                CheckGrayRemovableValueRowii = ii;
                                                                CheckGrayRemovableValueColumnjj = jj;
                                                                CheckGrayRemovable = true;
                                                            }
                                                        }
                                                    }
                                                    //Move Back.
                                                    Tab[i, j] = Table[ii, jj];
                                                    Tab[ii, jj] = 0;
                                                }


                                            }
                                        }
                                    }
                                }
                }
                {
                    //For All Second Traversal Homes.
                    for (var i = 0; i < 8; i++)
                        for (var j = 0; j < 8; j++)
                            for (var ii = 0; ii < 8; ii++)
                                for (var jj = 0; jj < 8; jj++)
                                {
                                    //if The Tow Traversal are the ame Continue Traversal Back.
                                    if (i == ii && j == jj)
                                        continue;
                                    //If the Gray.
                                    if (Table[i, j] > 0)
                                    {
                                        //If the Brown.
                                        if (Table[ii, jj] < 0)
                                        {
                                            //Inaitate Local Variables.
                                            int[,] Tab = new int[8, 8];
                                            //Clone a Copy.
                                            for (var iii = 0; iii < 8; iii++)
                                                for (var jjj = 0; jjj < 8; jjj++)
                                                {
                                                    Tab[iii, jjj] = Table[iii, jjj];
                                                }
                                            //Moveable Movemnts in the Tow Traversal Kind.
                                            if ((new ChessFirst.ThinkingChessFirst(-1, 0, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, i, j)).Movable(CloneATable(Tab), i, j, ii, jj, Color.Gray, 1))
                                            {
                                                for (var iii = 0; iii < 8; iii++)
                                                    for (var jjj = 0; jjj < 8; jjj++)
                                                    {
                                                        Tab[iii, jjj] = Table[iii, jjj];
                                                    }
                                                //If the Gray Check.
                                                if (CheckGray)
                                                {
                                                    //Move 
                                                    Tab[ii, jj] = Tab[i, j];
                                                    Tab[i, j] = 0;
                                                    //If ther is Not Check.
                                                    if (!Check(CloneATable(Tab), Order))
                                                    {
                                                        //If there is Not Gray Check.
                                                        if (!CheckGray)
                                                        {
                                                            //Move and Initaite Local and Global Variables.
                                                            Tab[i, j] = Table[ii, jj];
                                                            Tab[ii, jj] = 0;
                                                            Object O1 = new Object();
                                                            lock (O1)
                                                            {
                                                                CheckBrownRemovableValueRowi = i;
                                                                CheckBrownRemovableValueColumnj = j;
                                                                CheckBrownRemovableValueRowii = ii;
                                                                CheckBrownRemovableValueColumnjj = jj;
                                                                CheckBrownRemovable = true;
                                                            }

                                                        }
                                                    }
                                                    //Move Back.
                                                    Tab[i, j] = Table[ii, jj];
                                                    Tab[ii, jj] = 0;
                                                }


                                            }
                                        }
                                    }
                                }
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckRemovableByAttack:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //If Check Remoavbe Brown Or Gray Return Removable.
                if (CheckBrownRemovable || CheckGrayRemovable)
                    return true;
                //Return Not Removable.
                return false;
            }
        }
        bool[,] VeryFye(int[,] Table, int Order, Color a, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {   //long Time = TimeElapced.TimeNow();Spaces++;
                int Cdummy = ChessFirst.ChessRules.CurrentOrder;
                if (Order == 1)
                    ChessFirst.ChessRules.CurrentOrder = 1;
                else
                    ChessFirst.ChessRules.CurrentOrder = -1;
                bool[,] Tab = new bool[8, 8];
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        if (i == ii && j == jj)
                            continue;


                        if ((new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[ii, jj], CloneATable(Table), Order, ii, jj)).Rules(ii, jj, i, j, a, Table[ii, jj]))
                        {
                            Tab[i, j] = true;
                        }
                        if ((new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[ii, jj], CloneATable(Table), Order, ii, jj)).Rules(ii, jj, i, j, a, Table[ii, jj]))
                        {
                            Tab[i, j] = true;
                        }
                    }
                ChessFirst.ChessRules.CurrentOrder = Cdummy;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("VeryFye:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Tab;
            }
        }
        public bool OnlyKingMovable(int[,] Tab, bool[,] TabB, int Order)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        if (TabB[i, j])
                        {
                            if (Order == 1)
                            {
                                if (Tab[i, j] != 6)
                                {
                                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("OnlyKingMovable:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                    return false;
                                }
                            }
                            else
                                if (Tab[i, j] != -6)
                            {
                                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("OnlyKingMovable:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                                return false;
                            }
                        }

                    }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("OnlyKingMovable:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return true;

            }
        }
        int[,] CloneATable(int[,] Tab)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
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
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CloneATable:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Table;
            }

        }
        bool[,] CloneATable(bool[,] Tab)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
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
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CloneATable:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Table;
            }

        }

        public bool Pat(int[,] Tab, int Order, Color a)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;
                int[,] Table = new int[8, 8];
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tab[i, j];
                bool Pat = false;
                Object OO = new Object();
                lock (OO)
                {
                    PatCheckedInKingRule = true;
                }
                if (!Check(CloneATable(Table), Order))
                {
                    bool[,] TableS = new bool[8, 8];
                    //  if (Order == -1)

                    for (var ii = 0; ii < 8; ii++)
                        for (var jj = 0; jj < 8; jj++)
                        {
                            if (Table[ii, jj] > 0)
                            {
                                bool[,] TableSS = VeryFye(CloneATable(Table), 1, Color.Gray, ii, jj);

                                for (var iii = 0; iii < 8; iii++)
                                    for (var jjj = 0; jjj < 8; jjj++)
                                    {
                                        TableS[iii, jjj] |= TableSS[iii, jjj];
                                    }
                            }
                        }
                    if (OnlyKingMovable(CloneATable(Table), CloneATable(TableS), 1))
                    {
                        NumbersofKingMovesToPatGray++;
                    }
                    Pat = false;
                    for (var ii = 0; ii < 8; ii++)
                        for (var jj = 0; jj < 8; jj++)
                        {
                            Pat |= TableS[ii, jj];
                        }
                    Pat = !Pat;
                    if (Pat || NumbersofKingMovesToPatGray > 16)
                    {
                        Object On = new Object();
                        lock (On)
                        {
                            AllDraw.EndOfGame = true;
                            PatkGray = true;
                        }
                    }
                    TableS = new bool[8, 8];

                    for (var ii = 0; ii < 8; ii++)
                        for (var jj = 0; jj < 8; jj++)
                        {
                            if (Table[ii, jj] < 0)
                            {
                                bool[,] TableSS = VeryFye(CloneATable(Table), -1, Color.Brown, ii, jj);
                                for (var iii = 0; iii < 8; iii++)
                                    for (var jjj = 0; jjj < 8; jjj++)
                                    {
                                        TableS[iii, jjj] |= TableSS[iii, jjj];
                                    }
                            }
                        }
                    if (OnlyKingMovable(CloneATable(Table), CloneATable(TableS), -1))
                    {
                        NumbersofKingMovesToPatBrown++;
                    }
                    Pat = false;
                    for (var ii = 0; ii < 8; ii++)
                        for (var jj = 0; jj < 8; jj++)
                        {
                            Pat |= TableS[ii, jj];
                        }
                    Pat = !Pat;
                    if (Pat || NumbersofKingMovesToPatBrown >= 16)
                    {
                        Object On = new Object();
                        lock (On)
                        {
                            AllDraw.EndOfGame = true;
                            PatBrown = true;
                        }
                    }
                    if (PatkGray || PatBrown)
                        Pat = true;
                }
                else
                {
                    if (CheckGray)
                        NumbersofKingMovesToPatGray = 0;
                    else
                        if (CheckBrown)
                        NumbersofKingMovesToPatBrown = 0;

                }
                Object O1 = new Object();
                lock (O1)
                {
                    PatCheckedInKingRule = false;
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Pat:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Pat;
            }
        }
        void CheckKing(int[,] Table, int Order, int RowK, int ColumnK)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                int[,] Tab = new int[8, 8];
                //Clone a Copy.
                for (var ii = 0; ii < 8; ii++)
                    for (var jj = 0; jj < 8; jj++)
                        Tab[ii, jj] = Table[ii, jj];
                int Ord = Order;
                Color aa = Color.Gray;
                if (Ord == -1)
                    aa = Color.Brown;
                bool BREAK = false;
                //For All Home Table.
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        //If The Current Home is the Gray King Continue Traversal Back.
                        if (i == RowK && j == ColumnK)
                            continue;
                        if (Ord == 1 & Tab[i, j] <= 0)
                            continue;
                        if (Ord == -1 & Tab[i, j] >= 0)
                            continue;
                        //Initiate Global Variables.
                        int Dummt = ChessFirst.ChessRules.CurrentOrder;
                        ChessFirst.ChessRules.CurrentOrder = -1;
                        //Clone a Copy.
                        for (var ii = 0; ii < 8; ii++)
                            for (var jj = 0; jj < 8; jj++)
                                Tab[ii, jj] = Table[ii, jj];

                        Color a = Color.Gray;
                        if (Ord == -1)
                            a = Color.Brown;
                        ChessFirst.ChessRules A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[i, j], CloneATable(Table), Ord, i, j);
                        if (Ord == 1)
                        {
                            //Menen Parameter is Moveble to Second Parameters Location returm Movable.
                            if (A.Rules(i, j, RowK, ColumnK, aa, Ord))
                            {
                                BREAK = true;
                                //Initiate Local Is Check Variables.
                                CheckBrown = true;
                                break;
                            }
                        }
                        else
                        {   //Menen Parameter is Moveble to Second Parameters Location returm Movable.
                            if (A.Rules(i, j, RowK, ColumnK, aa, Ord))
                            {
                                BREAK = true;
                                CheckGray = true;
                                break;
                            }
                        }

                        //Initiate Global Variables.
                        ChessFirst.ChessRules.CurrentOrder = Dummt;


                    }
                    if (BREAK)
                        break;
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
            }
        }
        //Check Consideration Method.
        public bool Check(int[,] Table, int Ord)
        {
            Object O = new Object();
            lock (O)
            {  //long Time = TimeElapced.TimeNow();Spaces++;
               //A player is not required to move their king out of check and the game concludes when there is a 100 % probability that one of the kings has been taken. As a result there is no checkmate.
                if (DrawKing.KingGrayNotCheckedByQuantumMove && Ord == 1)
                    return false;
                else
                if (DrawKing.KingBrownNotCheckedByQuantumMove && Ord == -1)
                    return false;
                int DummyOrder = Ord;
                //Initiate Local and Global Briables.
                bool Store = ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing;
                Object OO = new Object();
                lock (OO)
                {
                    ChessFirst.ChessRules.CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKing = false;
                }
                CheckGray = false;
                CheckBrown = false;
                //Initiate Local Variables.
                int RowG = 0, ColumnG = 0;
                int RowB = 0, ColumnB = 0;
                //if (Ord == 1)

                //Foud of Gray King.
                if (FindGrayKing(CloneATable(Table), ref RowG, ref ColumnG))
                    CheckKing(CloneATable(Table), -1, RowG, ColumnG);

                //Found of Brown King.
                if (FindBrownKing(CloneATable(Table), ref RowB, ref ColumnB))
                    CheckKing(CloneATable(Table), 1, RowB, ColumnB);

                Ord = DummyOrder;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Check:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //If Gray Check Or brwon Check return Check..
                if (CheckBrown || CheckGray)
                    return true;
                //Return Non Check.
                return false;
            }
        }
        void CheckMateKing(int[,] Tab, int Ord, bool CheckGrayDummy, bool CheckBrownDummy, int RowK, int ColumnK, ref bool ActMove, bool Checked)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                int DummyOrder = Order;
                //For All Home Table.
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        if (Ord == 1 && Tab[i, j] > 0)
                            continue;
                        if (Ord == -1 && Tab[i, j] < 0)
                            continue;

                        //Clone a Copy.
                        CheckGray = CheckGrayDummy;
                        CheckBrown = CheckBrownDummy;
                        //If There is Gray Check.
                        if (Checked)
                        {
                            //Initiate Global Variables.
                            ChessFirst.ChessRules.CurrentOrder = 1;
                            //Ig Gray King is Movable to First Home Table.
                            Color a = Color.Gray;
                            if (Ord == -1)
                                a = Color.Brown;
                            ChessFirst.ChessRules A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[RowK, ColumnK], CloneATable(Table), Ord, RowK, ColumnK);
                            Order = DummyOrder;
                            ///Table[ii, jj] = 0;
                            //Menen Parameter is Moveble to Second Parameters Location returm Movable.
                            for (int k = 0; k < 8; k++)
                                for (int p = 0; p < 8; p++)
                                    Table[k, p] = Tab[k, p];
                            if (A.Rules(RowK, ColumnK, i, j, a, Ord))
                            {
                                Order = DummyOrder;
                                //Initaite Loval and Move.
                                //ActMove = false;
                                int Store = Table[i, j];
                                //For Another Methods
                                Table[i, j] = Table[RowK, ColumnK];
                                Table[RowK, ColumnK] = 0;
                                //If Is Check.
                                if (A.Check(CloneATable(Table), Ord))
                                {
                                    //Move Back.
                                    //If Gray Check.
                                    if (Ord == 1)
                                    {
                                        if (A.CheckGray)
                                        {
                                            //Move Mack.
                                            ActMove = true;
                                            continue;
                                        }
                                        else//If There is Not Gray Check.
                                        {
                                            //Move Back.
                                            ActMove = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (A.CheckBrown)
                                        {
                                            //Move Mack.
                                            ActMove = true;
                                            continue;
                                        }
                                        else//If There is Not Gray Check.
                                        {
                                            //Move Back.
                                            ActMove = false;
                                            break;
                                        }
                                    }

                                }
                                else
                                {
                                    //Comon Move Back.
                                    ActMove = false;
                                    break;
                                }

                            }
                        }

                    }
                    //If One of The Not Movable.
                    if (!ActMove)
                        break;
                }
                Order = DummyOrder;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckMateKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
            }
        }
        void CheckMateNotKing(int[,] Tab, int Ord, bool CheckGrayDummy, bool CheckBrownDummy, ref bool ActMove)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                int DummyOrder = Ord;
                //For All Home Table.
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        if (Ord == 1 && Tab[i, j] <= 0)
                            continue;
                        if (Ord == -1 && Tab[i, j] >= 0)
                            continue;
                        //Initiate Global varibales. 
                        CheckGray = CheckGrayDummy;
                        CheckBrown = CheckBrownDummy;
                        //Clone a Copy.
                        CheckGray = CheckGrayDummy;
                        CheckBrown = CheckBrownDummy;
                        //If There is Gray Check.
                        //Initiate Local Varibale.
                        ActMove = true;
                        //For All Second Home Table.
                        for (var ii = 0; ii < 8; ii++)
                        {

                            for (var jj = 0; jj < 8; jj++)
                            {
                                if (Ord == 1 && Tab[ii, jj] > 0)
                                    continue;
                                if (Ord == -1 && Tab[ii, jj] < 0)
                                    continue;
                                //Clone a Copy.

                                Table = CloneATable(Tab);

                                Color a = Color.Gray;
                                if (Ord == -1)
                                    a = Color.Brown;
                                ChessFirst.ChessRules A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[i, j], CloneATable(Table), Ord, i, j);
                                ///Table[ii, jj] = 0;
                                //Menen Parameter is Moveble to Second Parameters Location returm Movable.
                                if (A.Rules(i, j, ii, jj, a, Ord))
                                {
                                    Order = DummyOrder;
                                    //Initiate Local Varibales and Move.
                                    //ActMove = false;
                                    //For Another Methods
                                    int Store = Table[i, j];
                                    Table[ii, jj] = Table[i, j];
                                    Table[i, j] = 0;
                                    //If Check.
                                    A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[ii, jj], CloneATable(Table), Ord, ii, jj);
                                    if (A.Check(CloneATable(Table), Ord))
                                    {
                                        Order = DummyOrder;
                                        //Move Back.
                                        Table[i, j] = Table[ii, jj];
                                        Table[ii, jj] = Store;
                                        //If Gray Check.
                                        if (Ord == 1)
                                        {
                                            if (A.CheckGray)
                                            {
                                                //Initiate and Move Back.
                                                ActMove = true;
                                                Table[i, j] = Table[ii, jj];
                                                Table[ii, jj] = Store;
                                                continue;
                                            }
                                            //If There is Not Gray Check.
                                            else
                                            {
                                                //Initiate Varaible and Move Back.
                                                ActMove = false;
                                                Table[i, j] = Table[ii, jj];
                                                Table[ii, jj] = Store;
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            if (A.CheckBrown)
                                            {
                                                //Initiate and Move Back.
                                                ActMove = true;
                                                Table[i, j] = Table[ii, jj];
                                                Table[ii, jj] = Store;
                                                continue;
                                            }
                                            //If There is Not Gray Check.
                                            else
                                            {
                                                //Initiate Varaible and Move Back.
                                                ActMove = false;
                                                Table[i, j] = Table[ii, jj];
                                                Table[ii, jj] = Store;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //Move Back and Initiate.
                                        Table[i, j] = Table[ii, jj];
                                        Table[ii, jj] = Store;
                                        ActMove = false;
                                        break;
                                    }
                                }
                            }
                            //If Not Movable Break.
                            if (!ActMove)
                                break;
                        }

                        if (!ActMove)
                            break;
                    }
                    //If Not Movable Break.
                    if (!ActMove)
                        break;
                }
                Order = DummyOrder;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckMateNotKing:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
            }
        }
        //CheckMate Consideration.QC-OK
        public bool CheckMate(int[,] Tab, int Ord)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;

                //Initiate Local and Global  Varibales.
                int[,] Table = new int[8, 8];

                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tab[i, j];

                CheckGray = false;
                CheckBrown = false;
                CheckMateBrown = false;
                CheckMateGray = false;
                bool ActMoveG = true;
                bool ActMoveGF = true;
                bool ActMoveB = true;
                bool ActMoveBF = true;
                int RowG = 0, ColumnG = 0;
                int RowB = 0, ColumnB = 0;
                int DumnyOrder = Ord;
                //Check Consideration.
                Check(CloneATable(Table), Ord);
                //Initiate Local Varibales.
                bool CheckGrayDummy = CheckGray;
                bool CheckBrownDummy = CheckBrown;

                ActMoveG = true;
                ActMoveGF = true;

                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tab[i, j];
                ChessFirst.ChessRules A = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[RowG, ColumnG], CloneATable(Table), Ord, RowG, ColumnG);

                //Found of Gray King.
                if (FindGrayKing(CloneATable(Table), ref RowG, ref ColumnG))
                    A.CheckMateKing(CloneATable(Table), 1, CheckGrayDummy, CheckBrownDummy, RowG, ColumnG, ref ActMoveG, CheckGray);

                Table = CloneATable(Tab);


                //Found of Gray King.
                if (FindGrayKing(CloneATable(Table), ref RowG, ref ColumnG))
                    A.CheckMateNotKing(CloneATable(Table), 1, CheckGrayDummy, CheckBrownDummy, ref ActMoveGF);

                //Intiate Global Variables.
                CheckGray = CheckGrayDummy;
                CheckBrown = CheckBrownDummy;

                //Condition of CheckMate Gray King.
                if (CheckGray && (ActMoveG && ActMoveGF))
                    CheckMateGray = true;


                ActMoveB = true;
                ActMoveBF = true;

                ChessFirst.ChessRules AA = new ChessFirst.ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsBoard, Table[RowB, ColumnB], CloneATable(Table), Ord, RowB, ColumnB);

                Table = CloneATable(Tab);


                //Found of Brown King.
                if (FindBrownKing(CloneATable(Table), ref RowB, ref ColumnB))
                    AA.CheckMateKing(CloneATable(Table), -1, CheckGrayDummy, CheckBrownDummy, RowB, ColumnB, ref ActMoveB, CheckBrown);
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Table[i, j] = Tab[i, j];
                //Found of Brown King.
                if (FindBrownKing(CloneATable(Table), ref RowB, ref ColumnB))
                    AA.CheckMateNotKing(CloneATable(Table), -1, CheckGrayDummy, CheckBrownDummy, ref ActMoveBF);


                //Initiate Global Varibales.
                CheckGray = CheckGrayDummy;
                CheckBrown = CheckBrownDummy;
                //Condition of Brown CheckMate.
                if (CheckBrown && (ActMoveB && ActMoveBF))
                    CheckMateBrown = true;

                //Initiate Global Variables.
                Ord = DumnyOrder;
                //If Brown CheckMate and Gray.
                if (CheckMateGray || CheckMateBrown)
                {
                    //Initiate Global Variable and Return CheckMate.
                    CheckGray = CheckGrayDummy;
                    CheckBrown = CheckBrownDummy;
                    Object On = new Object();
                    lock (On)
                    {
                        AllDraw.EndOfGame = true;
                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckMate:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return true;
                    }
                }
                //Initiate Global Variables.
                CheckGray = CheckGrayDummy;
                CheckBrown = CheckBrownDummy;
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheckMate:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Return Not CheckMate.
                return false;
            }
        }
        //Internal Rule of ChessFirst Method.
        private bool Rule(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy, int Ki, bool SelfHomeStatCP)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;
                  //When is Not Castles King State.
                if (Kind != 7)
                {
                    //Determination of Enemy Existing.
                    if (ExistSelfHome(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, Ki) && SelfHomeStatCP)
                    {
                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return false;
                    }
                }
                //Determination of King Enemy at Destination Home.

                //If Source and The Destination are The Same.
                if (RowFirst == RowSecond && ColumnFirst == ColumnSecond)
                {
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return false;
                }
                //Initiate Global Variable.
                Object OO = new Object();
                lock (OO)
                {
                    KingAttacker = false;
                }
                //Rule of Soldeir.
                switch (Kind)
                {
                    //Rule of Soldeir.
                    case 1:
                        if (System.Math.Abs(TableS[RowFirst, ColumnFirst]) != Kind)
                            return false;
                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return SoldierRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);


                    case 4://Rule of Castles.
                        if (System.Math.Abs(TableS[RowFirst, ColumnFirst]) != Kind)
                            return false;


                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return CastleRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);


                    case 3://Rule of Hourses.
                        if (System.Math.Abs(TableS[RowFirst, ColumnFirst]) != Kind)
                            return false;
                        return HourseRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);

                    case 2://Rule of Elephant.

                        if (System.Math.Abs(TableS[RowFirst, ColumnFirst]) != Kind)
                            return false;

                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return ElefantRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);
                    case 5://Rule of Ministers.
                        if (System.Math.Abs(TableS[RowFirst, ColumnFirst]) != Kind)
                            return false;

                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return MinisterRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);

                    case 6://Rule of Kings.
                        if (System.Math.Abs(TableS[RowFirst, ColumnFirst]) != Kind)
                            return false;
                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return KingRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki);
                    case 7://Rule of Castles King.

                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return CastleKing(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, Ki);
                    case -7://Rule of Castles King.

                        ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Rule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                        return CastleKing(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, Ki);
                    default:
                        return false;
                }

            }
        }
        //King Rule Method.
        public bool KingRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy, int Ki)
        {
            Object O = new Object();
            lock (O)
            {     //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                //When Miniaster Rule is Valid.
                if (MinisterRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki) && (System.Math.Abs(RowFirst - RowSecond) <= 1) && (System.Math.Abs(ColumnFirst - ColumnSecond) <= 1))
                {
                    //Initiate Local Variable.

                    Move = true;
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("KingRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Move;
            }
        }
        //Rules of Minister Method.
        public bool MinisterRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy, int Ki)
        {
            Object O = new Object();
            lock (O)
            {    //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                //When is Castles Rule.
                if (CastleRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki))
                    //Return Validity.,
                    Move = true;
                else
                    //When is Elephant Rule.
                    if (ElefantRules(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy, Ki))
                    //Return Validity.,
                    Move = true;
                //Return Not Valididty.
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("MinisterRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Move;
            }

        }
        //Castles Rule Method.
        public bool CastleRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy, int Ki)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                bool Act = false;
                //If Variation is Only in Row.
                if (System.Math.Abs(ColumnFirst - ColumnSecond) == 0 && System.Math.Abs(RowFirst - RowSecond) != 0)
                {
                    //Initiate Local Variables.
                    int RowU = RowSecond, RowD = RowFirst;
                    int ColD = ColumnFirst, ColU = ColumnSecond;
                    int Rowf = 1, Colf = 1;
                    if (RowU < RowD)
                        Rowf = -1;
                    if (ColU < ColD)
                        Colf = -1;
                    int incf = 0, incR = 0;
                    if (Rowf < 0)
                        incf = -1;
                    if (Colf < 0)
                        incR = -1;
                    int F = 0, G = 0;
                    int A = 0, B = 0;
                    if (incf < 0)
                    {
                        F = RowU;
                        G = RowD;
                    }
                    else
                    {
                        F = RowD;
                        G = RowU;

                    }
                    if (incR < 0)
                    {
                        A = ColU;
                        B = ColD;
                    }
                    else
                    {
                        A = ColD;
                        B = ColU;

                    }
                    {
                        //For Variation of Row Home.
                        for (var i = F; i <= G; i++)
                        {
                            if (IgnoreSelfObject && i == RowSecond)
                                continue;
                            //When is Not Current Source Home.
                            if (i != RowFirst)
                            {
                                //When There is Self Home at Home of Gray Return Not Validity.
                                if (Table[i, ColumnFirst] > 0 && Table[RowFirst, ColumnFirst] > 0)
                                {
                                    Move = false;
                                    Act = true;
                                }
                                //When There is Self Home of Brown Objects Return Not Validity.
                                if (Table[i, ColumnFirst] < 0 && Table[RowFirst, ColumnFirst] < 0)
                                {
                                    Act = true;
                                    Move = false;
                                }

                                //If Situation is Occured.
                                if (i != RowSecond)
                                {
                                    //When There is Slef Home at Root Return Not Valididty.
                                    if ((Table[i, ColumnFirst] < 0 || Table[i, ColumnFirst] > 0) && Table[RowFirst, ColumnFirst] > 0)
                                    {
                                        Act = true;
                                        Move = false;
                                    }
                                    //When There is Slef Home at Root Return Not Valididty.
                                    if ((Table[i, ColumnFirst] > 0 || Table[i, ColumnFirst] < 0) && Table[RowFirst, ColumnFirst] < 0)
                                    {
                                        Act = true;
                                        Move = false;
                                    }
                                }
                            }

                        }
                    }
                    if (!Act)
                        Move = true;

                }
                //When There is Only Column Variation Home Changes.
                if (System.Math.Abs(ColumnFirst - ColumnSecond) != 0 && System.Math.Abs(RowFirst - RowSecond) == 0)
                {
                    //Initiate Local Variables.
                    int RowU = RowSecond, RowD = RowFirst;
                    int ColD = ColumnFirst, ColU = ColumnSecond;
                    int Rowf = 1, Colf = 1;
                    if (RowU < RowD)
                        Rowf = -1;
                    if (ColU < ColD)
                        Colf = -1;
                    int incf = 0, incR = 0;
                    if (Rowf < 0)
                        incf = -1;
                    if (Colf < 0)
                        incR = -1;
                    int F = 0, G = 0;
                    int A = 0, B = 0;
                    if (incf < 0)
                    {
                        F = RowU;
                        G = RowD;
                    }
                    else
                    {
                        F = RowD;
                        G = RowU;

                    }
                    if (incR < 0)
                    {
                        A = ColU;
                        B = ColD;
                    }
                    else
                    {
                        A = ColD;
                        B = ColU;

                    }

                    //For All Column Home Variation.
                    for (var j = A; j <= B; j++)
                    {
                        if (IgnoreSelfObject && j == ColumnSecond)
                            continue;
                        //When The Source is Not The Current.
                        if (j != ColumnFirst)
                        {
                            //For All Self Home at Root Return Not Validity
                            if (Table[RowFirst, j] > 0 && Table[RowFirst, ColumnFirst] > 0)
                            {
                                Act = true;
                                Move = false;
                            }
                            //For All Self Home at Root Return Not Validity.                       
                            if (Table[RowFirst, j] < 0 && Table[RowFirst, ColumnFirst] < 0)
                            {
                                Act = true;
                                Move = false;
                            }
                            //Condition Determination.
                            if (j != ColumnSecond)
                            {
                                //Existing of Self Home At Root Cuased to Not validity.
                                if ((Table[RowFirst, j] < 0 || Table[RowFirst, j] > 0) && Table[RowFirst, ColumnFirst] > 0)
                                {
                                    Act = true;
                                    Move = false;
                                }
                                //Existing of Self Home At Root Cuased to Not validity.
                                if ((Table[RowFirst, j] > 0 || Table[RowFirst, j] < 0) && Table[RowFirst, ColumnFirst] < 0)
                                {
                                    Act = true;
                                    Move = false;
                                }
                            }
                        }


                    }
                    //Return Validity.
                    if (!Act)
                        Move = true;
                }

                //Return Not Validity.

                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CastleRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Return not Vailidity.
                return Move;

            }
        }
        //Elephant Rule Method.
        public bool ElefantRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy, int Ki)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                bool Act = false;
                //Orthogonal Movments of One Abs Derivation.
                if (System.Math.Abs(ColumnFirst - ColumnSecond) == System.Math.Abs(RowFirst - RowSecond))
                {
                    //Initaiet Of Local Variables.
                    int RowU = RowSecond, RowD = RowFirst;
                    int ColD = ColumnFirst, ColU = ColumnSecond;
                    int Rowf = 1, Colf = 1;
                    if (RowU < RowD)
                        Rowf = -1;
                    if (ColU < ColD)
                        Colf = -1;
                    int incf = 0, incR = 0;
                    if (Rowf < 0)
                        incf = -1;
                    if (Colf < 0)
                        incR = -1;
                    int F = 0, G = 0;
                    int A = 0, B = 0;
                    if (incf < 0)
                    {
                        F = RowU;
                        G = RowD;
                    }
                    else
                    {
                        F = RowD;
                        G = RowU;

                    }
                    if (incR < 0)
                    {
                        A = ColU;
                        B = ColD;
                    }
                    else
                    {
                        A = ColD;
                        B = ColU;

                    }
                    //For All Root Source to Destination.
                    for (var i = F; i <= G; i++)
                        for (var j = A; j <= B; j++)
                        {
                            if (IgnoreSelfObject && i == RowSecond && j == ColumnSecond)
                                continue;

                            //If Abs Derivation is Not One Continue. 
                            if (System.Math.Abs(i - RowFirst) != System.Math.Abs(j - ColumnFirst))
                                continue;
                            //If the Current is Not Source Home.
                            if (i != RowFirst && j != ColumnFirst)
                            {
                                {
                                    //If the Root Contains Self Home Return Not Validity.
                                    if (Table[i, j] > 0 && Table[RowFirst, ColumnFirst] > 0)
                                    {
                                        Act = true;
                                        Move = false;
                                    }
                                    //If The Root Contains Self Home Return Not vALIDITY. 
                                    if (Table[i, j] < 0 && Table[RowFirst, ColumnFirst] < 0)
                                    {
                                        Act = true;
                                        Move = false;
                                    }
                                    //When the Current is Not The Source Home.
                                    if (i != RowSecond && j != ColumnSecond)
                                    {
                                        //When the Self ObjectExisting at the Root .
                                        if ((Table[i, j] > 0 || Table[i, j] < 0) && Table[RowFirst, ColumnFirst] > 0)
                                        {
                                            Act = true;
                                            Move = false;
                                        }
                                        //When the Self ObjectExisting at the Root .
                                        if ((Table[i, j] < 0 || Table[i, j] > 0) && Table[RowFirst, ColumnFirst] < 0)
                                        {
                                            Act = true;
                                            Move = false;
                                        }
                                    }
                                }
                            }

                        }
                    //Return Validity.
                    if (!Act)
                        Move = true;
                }

                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ElephantRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //Return Not Validity.
                return Move;
            }
        }
        //Hource Rule Method.
        public bool HourseRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy)
        {
            Object O = new Object();
            lock (O)
            {   //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                //When L Movament is Occured. 
                if (System.Math.Abs(ColumnFirst - ColumnSecond) == 2 && System.Math.Abs(RowFirst - RowSecond) == 1)
                {
                    //Retrun Validity.
                    Move = true;
                }
                //When Second L Movments Occured.
                if (System.Math.Abs(ColumnFirst - ColumnSecond) == 1 && System.Math.Abs(RowFirst - RowSecond) == 2)
                {
                    //Return Validity.
                    Move = true;
                }
                //Return Not Validity.

                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("HourseRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Move;
            }
        }
        public bool SoldierRulesaArrangmentsBoardOne(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                //When int is Gray.
                if (Order == 1)
                {
                    //If Not Forward Return Not Validity.
                    if (ColumnFirst < ColumnSecond)
                        Move = false;
                }
                else//int of Brown.
                    if (Order == -1)
                {
                    //If Not Back Wrad Return Not Vlaidity.
                    if (ColumnFirst > ColumnSecond)
                        Move = false;
                }
                //When Soldier Not Moved in Original Location do
                if (NotMoved)
                {
                    if (Order == -1 && Table[RowFirst, ColumnFirst] < 0)
                    {
                        //Depend on First Move do For Land Of Islam


                        if ((ColumnFirst + 2 < 8) && (ColumnFirst + 1 < 8) &&
                            (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 2) && (Table[RowSecond, ColumnSecond - 1] == 0)
                            )
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else
                            if ((ColumnFirst + 1 < 8) &&
                                (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Brown Soldier Rulments.
                                if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
                        {
                            if ((RowSecond - 1 < 8) &&
                                (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }

                        }

                    }
                    else//Gray int.
                        if (Order == 1 && Table[RowFirst, ColumnFirst] > 0)
                    {
                        //Depend Of First Move do For Positivism

                        if ((ColumnSecond + 2 < 8) && (ColumnSecond + 1 < 8) &&
                            (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 2) && (Table[RowSecond, ColumnSecond + 1] == 0)
                            )
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else
                            if ((ColumnSecond + 1 < 8) &&
                                (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Condition Enemy Movments.
                                if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
                        {
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                            if ((RowSecond - 1 >= 0) &&
                                    (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                        }

                    }
                }
                else//If Soldeior Moved Previously.
                {
                    //For Brown int.
                    if (Order == -1 && Table[RowFirst, ColumnFirst] < 0)
                    {
                        //Depend on Second Move do For Land Of Islam

                        if ((ColumnFirst + 1 < 8) &&
                                (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Brown Soldier Rulments.                            
                            if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
                        {
                            if ((RowSecond - 1 < 8) &&
                                (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }

                        }

                    }
                    else//Gray int.
                        if (Order == 1 && Table[RowFirst, ColumnFirst] > 0)
                    {
                        //Depend Of Second Move do For Positivism Land

                        if ((ColumnSecond + 1 < 8) &&
                                 (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Condition Enemy Movments.
                            if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
                        {
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                            if ((RowSecond - 1 >= 0) &&
                                    (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                        }

                    }
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("SoldierRule:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Move;
            }
        }
        public bool SoldierRulesaArrangmentsBoardZero(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy)
        {

            Object O = new Object();
            lock (O)
            {
                int[,] Table = CloneATable(TableS);

                //long Time = TimeElapced.TimeNow();Spaces++;
                bool Move = false;
                //When int is Gray.
                if (Order == 1)
                {
                    //If Not Forward Return Not Validity.
                    if (ColumnFirst > ColumnSecond)
                        Move = false;
                }
                else//int of Brown.
                    if (Order == -1)
                {
                    //If Not Back Wrad Return Not Vlaidity.
                    if (ColumnFirst < ColumnSecond)
                        Move = false;
                }
                //When Soldier Not Moved in Original Location do
                if (NotMoved)
                {
                    if (Order == 1 && Table[RowFirst, ColumnFirst] > 0)
                    {
                        //Depend on First Move do For Land Of Islam


                        if ((ColumnFirst + 2 < 8) && (ColumnFirst + 1 < 8) &&
                            (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 2) && (Table[RowSecond, ColumnSecond - 1] == 0)
                            )
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else
                            if ((ColumnFirst + 1 < 8) &&
                                (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Gray Soldier Rulments.
                                if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
                        {
                            if ((RowSecond - 1 < 8) &&
                                (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }

                        }

                    }
                    else//Brown int.
                        if (Order == -1 && Table[RowFirst, ColumnFirst] < 0)
                    {
                        //Depend Of First Move do For Positivism

                        if ((ColumnSecond + 2 < 8) && (ColumnSecond + 1 < 8) &&
                            (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 2) && (Table[RowSecond, ColumnSecond + 1] == 0)
                            )
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else
                            if ((ColumnSecond + 1 < 8) &&
                                (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Condition Enemy Movments.
                                if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
                        {
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                            if ((RowSecond - 1 >= 0) &&
                                    (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                        }

                    }
                }
                else//If Soldeior Moved Previously.
                {
                    //For Gray int.
                    if (Order == 1 && Table[RowFirst, ColumnFirst] > 0)
                    {
                        //Depend on Second Move do For Land Of Islam

                        if ((ColumnFirst + 1 < 8) &&
                                (RowFirst == RowSecond) && (ColumnSecond == ColumnFirst + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Gray Soldier Rulments.                            
                            if ((ColumnFirst + 1 < 8) && ColumnSecond == ColumnFirst + 1)
                        {
                            if ((RowSecond - 1 < 8) &&
                                (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                            {
                                Move = true;
                            }

                        }

                    }
                    else//Brown int.
                        if (Order == -1 && Table[RowFirst, ColumnFirst] < 0)
                    {
                        //Depend Of Second Move do For Positivism Land

                        if ((ColumnSecond + 1 < 8) &&
                                 (RowFirst == RowSecond) && (ColumnFirst == ColumnSecond + 1) && (Table[RowSecond, ColumnSecond] == 0))
                        {
                            //When Destination is The Empty Return Validity Else Return Not Validity.
                            if (Table[RowSecond, ColumnSecond] == 0)
                                Move = true;
                            else
                                Move = false;
                        }
                        else//Hit Condition Enemy Movments.
                            if ((ColumnSecond + 1 < 8) && ColumnFirst == ColumnSecond + 1)
                        {
                            if ((RowSecond + 1 < 8) &&
                                (RowFirst == RowSecond + 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                            if ((RowSecond - 1 >= 0) &&
                                    (RowFirst == RowSecond - 1) && (ExistInDestinationEnemy || IgnoreSelfObject))
                                //Return Validity.
                                Move = true;
                        }

                    }
                }
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("SoldierRulesaArrangmentsBoardZero:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return Move;
            }

        }
        //Solder Rule Method.
        public bool SoldierRules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, bool NotMoved, Color color, bool ExistInDestinationEnemy)
        {
            Object O = new Object();
            lock (O)
            {
                //long Time = TimeElapced.TimeNow();Spaces++;

                if (!(ArrangmentsBoard))
                {
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("SoldierRules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return SoldierRulesaArrangmentsBoardZero(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);
                }
                else
                {
                    ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("SoldierRules:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                    return SoldierRulesaArrangmentsBoardOne(RowFirst, ColumnFirst, RowSecond, ColumnSecond, NotMoved, color, ExistInDestinationEnemy);
                }

                ///Return Not Validity.
            }
        }
    }
}

//End of Documentation.