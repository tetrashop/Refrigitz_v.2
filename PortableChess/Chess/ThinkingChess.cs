/**************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
*************TETRASHOP.IR**************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
***************************************
**************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace RefrigtzChessPortable
{
    [Serializable]
    public class ThinkingRefrigtzChessPortable//: IDisposable
    {
        bool ExcangePerformed = false;
        int[] PerformedExchange = null;

        public static string OutP = "";
        List<List<List<int[]>>> MovableAllObjectsList = new List<List<List<int[]>>>();
        public int RemoveOfDisturbIndex = -1;
        int HeuristicDoubleDefenceIndexInOnGameMidle = 0;
        List<List<int[]>> HeuristicDoubleDefenceIndexInOnGame = new List<List<int[]>>();
        int HeuristicReducedAttackedIndexInOnGameMidle = 0;
        List<int> HeuristicReducedAttackedIndexInOnGame = new List<int>();
        static bool GoldenFinished = false;
        public List<List<List<int[]>>> AchmazPure = new List<List<List<int[]>>>();
        int AchmazPureMidle = 0;
        public List<List<List<int[]>>> AchmazReduced = new List<List<List<int[]>>>();
        int AchmazReducedMidle = 0;

        public List<int> WinChiled = new List<int>();
        public List<int> LoseChiled = new List<int>();

        bool IKIsCentralPawnIsOk = false;

        List<int[]> HeuristicAllSupport = new List<int[]>();
        int HeuristicAllSupportMidel = 0;
        List<int[]> HeuristicAllReducedSupport = new List<int[]>();
        int HeuristicAllReducedSupportMidel = 0;
        List<int[]> HeuristicAllAttacked = new List<int[]>();
        int HeuristicAllAttackedMidel = 0;
        List<int[]> HeuristicAllReducedAttacked = new List<int[]>();
        int HeuristicAllReducedAttackedMidel = 0;
        List<int[]> HeuristicAllMove = new List<int[]>();
        int HeuristicAllMoveMidel = 0;
        List<int[]> HeuristicAllReducedMove = new List<int[]>();
        int HeuristicAllReducedMoveMidel = 0;
        public static int NoOfBoardMovedGray = 0;
        public static int NoOfBoardMovedBrown = 0;
        public static int NoOfMovableAllObjectMove = 1;
        public int DifOfNoOfSupporteAndReducedSupportGray = int.MinValue;
        public int DifOfNoOfSupporteAndReducedSupportBrown = int.MinValue;
        public static int ColleralationGray = int.MaxValue;
        public static int ColleralationBrown = int.MaxValue;
        public static int Colleralation = int.MaxValue;
        public static int DeColleralation = int.MaxValue;
        public static int[,] TableInitiation ={
             { -4, -1, 0, 0, 0, 0, 1, 4 },
            { -3, -1, 0, 0, 0, 0, 1, 3 },
            { -2, -1, 0, 0, 0, 0, 1, 2 },
            { -5, -1, 0, 0, 0, 0, 1, 5 },
            { -6, -1, 0, 0, 0, 0, 1, 6 },
            { -2, -1, 0, 0, 0, 0, 1, 2 },
            { -3, -1, 0, 0, 0, 0, 1, 3 },
            { -4, -1, 0, 0, 0, 0, 1, 4 }
            };
        public static int[,] TableInitiationPreventionOfMultipleMove ={
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 }
            };
        int RationalRegard = 10;
        int RationalPenalty = -10;

#pragma warning disable CS0414 // The field 'RationalWin' is assigned but its value is never used
        int RationalWin = 1000;
#pragma warning restore CS0414 // The field 'RationalWin' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'RationalLose' is assigned but its value is never used
        int RationalLose = -1000;
#pragma warning restore CS0414 // The field 'RationalLose' is assigned but its value is never used

        public static bool FullGameAllow = false;
        readonly int iIndex = -1;
        public static bool IsAtLeastOneKillerAtDraw = false;
        public List<bool> KishSelf = new List<bool>();
        public List<bool> KishEnemy = new List<bool>();
        readonly StringBuilder Space = new StringBuilder("&nbsp;");
        //#pragma warning disable CS0414 // The field 'Spaces' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'Spaces' is assigned but its value is never used
        readonly int Spaces = 0;
#pragma warning restore CS0414 // The field 'Spaces' is assigned but its value is never used
        //#pragma warning restore CS0414 // The field 'Spaces' is assigned but its value is never used
        public int HeuristicAttackValueSup = new int();
        public int HeuristicMovementValueSup = new int();
        public int HeuristicSelfSupportedValueSup = new int();
        public int HeuristicReducedMovementValueSup = new int();
        public int HeuristicReducedSupportSup = new int();
        public int HeuristicReducedAttackValueSup = new int();
        public int HeuristicDistributionValueSup = new int();
        public int HeuristicKingSafeSup = new int();
        public int HeuristicFromCenterSup = new int();
        public int HeuristicKingDangourSup = new int();
        public List<bool> IsSup = new List<bool>();
        public List<bool> IsSupHu = new List<bool>();
        readonly StackFrame callStack = new StackFrame(1, true);
        //Initiate Global and Static Variables. 
        public List<bool> IsThereMateOfEnemy = new List<bool>();
        public List<bool> IsThereMateOfSelf = new List<bool>();
        public List<bool> IsThereCheckOfEnemy = new List<bool>();
        public List<bool> IsThereCheckOfSelf = new List<bool>();
        public static NetworkQuantumLearningKrinskyAtamata LearniningTable = new NetworkQuantumLearningKrinskyAtamata(8, 8, 8);
        bool ThinkingAtRun = false;
        public static String ActionsString = "";
        int ThinkingLevel = 0;
        public List<bool[]> LearningVarsObject = new List<bool[]>();
        public static bool LearningVarsCheckedMateOccured;
        public static bool LearningVarsCheckedMateOccuredOneCheckedMate;
        bool IsGardHighPriority = false;
        const int ThresholdBlitz = 10;
        const int ThresholdFullGame = 20000;
        public static int MaxHeuristicx = int.MinValue;
        public bool MovementsAStarGreedyHeuristicFoundT = false;
        public bool IgnoreSelfObjectsT = false;
        public bool UsePenaltyRegardMechnisamT = false;
        public bool BestMovmentsT = false;
        public bool PredictHeuristicT = true;
        public bool OnlySelfT = false;
        public bool AStarGreedyHeuristicT = false;
        bool ArrangmentsChanged = true;
        public int NumberOfPenalties = 0;
        static int NumbersOfCurrentBranchesPenalties = 0;
        public static int NumbersOfAllNode = 0;
        public int SodierMidle = 0;
        public int SodierHigh = 0;
        public int ElefantMidle = 0;
        public int ElefantHigh = 0;
        public int HourseMidle = 0;
        public int HourseHight = 0;
        public int CastleMidle = 0;
        public int CastleHigh = 0;
        public int MinisterMidle = 0;
        public int MinisterHigh = 0;
        public int KingMidle = 0;
        public int KingHigh = 0;
        public static bool KingMaovableGray = false;
        public static bool KingMaovableBrown = false;
        public static int FoundFirstMating;
        public static int FoundFirstSelfMating;
        public int SodierValue = 1 * 3;
        public int ElefantValue = 2 * 16;
        public int HourseValue = 3 * 8;
        public int CastleValue = 5 * 16;
        public int MinisterValue = 8 * 32;
        public int KingValue = 10 * 8;
        public static int BeginThread = 0;
        public static int EndThread = 0;
        bool ExistingOfEnemyHiiting = false;
        int IgnoreObjectDangour = -1;
        public int CheckMateAStarGreedy = 0;
        bool CheckMateOcuured = false;
        int CurrentRow = -1, CurrentColumn = -1;
        public bool IsCheck = false;
        public int Kind = 0;
        public List<int> HitNumber = new List<int>();
        public static bool NotSolvedKingDanger = false;
        public static bool ThinkingRun = false;
        public int ThingsNumber = 0;
        public int CurrentArray = 0;
        public bool ThinkingBegin = false;
        public bool ThinkingFinished = false;
        public int IndexSoldier = 0;
        public int IndexElefant = 0;
        public int IndexHourse = 0;
        public int IndexCastle = 0;
        public int IndexMinister = 0;
        public int IndexKing = 0;
        public int IndexCastling = 0;

        public List<int[]> RowColumnSoldier = null;
        public List<int[]> RowColumnElefant = null;
        public List<int[]> RowColumnHourse = null;
        public List<int[]> RowColumnCastle = null;
        public List<int[]> RowColumnMinister = null;
        public List<int[]> RowColumnKing = null;
        public List<int[]> RowColumnCastling = null;
        public int[,] TableT;
        public List<int> HitNumberSoldier = null;
        public List<int> HitNumberElefant = null;
        public List<int> HitNumberHourse = null;
        public List<int> HitNumberCastle = null;
        public List<int> HitNumberMinister = null;
        public List<int> HitNumberKing = null;
        public List<int> HitNumberCastling = null;
        public int[,] TableConst;
        public List<int[,]> TableListSolder = null;
        public List<int[,]> TableListElefant = null;
        public List<int[,]> TableListHourse = null;
        public List<int[,]> TableListCastle = null;
        public List<int[,]> TableListMinister = null;
        public List<int[,]> TableListKing = null;
        public List<int[,]> TableListCastling = null;

        public List<int[]> HeuristicListSolder = null;
        public List<int[]> HeuristicListElefant = null;
        public List<int[]> HeuristicListHourse = null;
        public List<int[]> HeuristicListCastle = null;
        public List<int[]> HeuristicListMinister = null;
        public List<int[]> HeuristicListKing = null;
        public List<int[]> HeuristicListCastling = null;
        public List<int> KillerAtThinking = null;
        public List<QuantumAtamata> PenaltyRegardListSolder = null;
        public List<QuantumAtamata> PenaltyRegardListElefant = null;
        public List<QuantumAtamata> PenaltyRegardListHourse = null;
        public List<QuantumAtamata> PenaltyRegardListCastle = null;
        public List<QuantumAtamata> PenaltyRegardListMinister = null;
        public List<QuantumAtamata> PenaltyRegardListKing = null;
        public List<QuantumAtamata> PenaltyRegardListCastling = null;

        public int Max;
        public int Row, Column;
        public Color color;
        public int Order;
        //[NonSerialized()]
        public List<AllDraw> AStarGreedy = new List<AllDraw>();
        public List<bool> AStarGreedyMove = new List<bool>();
        readonly int[,] Value = new int[8, 8];
        int CurrentAStarGredyMax = -1;
        List<int[,]> ObjectNumbers = new List<int[,]>();
        ///Log of Errors.
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
        //create a tow dimension list of all object boundry
        void SetObjectNumbersInList(int[,] Tab)
        {
            SetObjectNumbers(Tab);
            int[,] A = new int[2, 6];
            A[0, 0] = SodierMidle;
            A[1, 0] = SodierHigh;

            A[0, 1] = ElefantMidle;
            A[1, 1] = ElefantHigh;

            A[0, 2] = HourseMidle;
            A[1, 2] = HourseHight;

            A[0, 3] = CastleMidle;
            A[1, 3] = CastleHigh;

            A[0, 4] = MinisterMidle;
            A[1, 4] = MinisterHigh;

            A[0, 5] = KingMidle;
            A[1, 5] = KingHigh;
            ObjectNumbers.Add(A);
        }
        //distiguis object boundries 
        public void SetObjectNumbers(int[,] TabS)
        {
            Object a = new Object();
            lock (a)
            {
                SodierMidle = 0;
                SodierHigh = 0;
                ElefantMidle = 0;
                ElefantHigh = 0;
                HourseMidle = 0;
                HourseHight = 0;
                CastleMidle = 0;
                CastleHigh = 0;
                MinisterMidle = 0;
                MinisterHigh = 0;
                KingMidle = 0;
                KingHigh = 0;
                for (int h = 0; h < 8; h++)
                    for (int s = 0; s < 8; s++)
                    {
                        if (TabS[h, s] == 1)
                        {
                            SodierMidle++;
                            SodierHigh++;
                        }
                        else if (TabS[h, s] == 2)
                        {
                            ElefantMidle++;
                            ElefantHigh++;
                        }
                        else if (TabS[h, s] == 3)
                        {
                            HourseMidle++;
                            HourseHight++;
                        }
                        else if (TabS[h, s] == 4)
                        {
                            CastleMidle++;
                            CastleHigh++;
                        }
                        else if (TabS[h, s] == 5)
                        {
                            MinisterMidle++;
                            MinisterHigh++;
                        }
                        else if (TabS[h, s] == 6)
                        {
                            KingMidle++;
                            KingHigh++;
                        }
                        else
                            if (TabS[h, s] == -1)
                        {
                            SodierHigh++;
                        }
                        else if (TabS[h, s] == -2)
                        {
                            ElefantHigh++;
                        }
                        else if (TabS[h, s] == -3)
                        {
                            HourseHight++;
                        }
                        else if (TabS[h, s] == -4)
                        {
                            CastleHigh++;
                        }
                        else if (TabS[h, s] == -5)
                        {
                            MinisterHigh++;
                        }
                        else if (TabS[h, s] == -6)
                        {
                            KingHigh++;
                        }
                    }
            }
        }
        [field: NonSerialized]
        private readonly CancellationTokenSource feedCancellationTokenSource =
            new CancellationTokenSource();
#pragma warning disable CS0169 // The field 'feedTask' is never used
        [field: NonSerialized] private readonly Task feedTask;
#pragma warning restore CS0169 // The field 'feedTask' is never used

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {


            }
        }
        public string AsS(int i, int j, int ii, int jj)
        {
            object o = new object();
            lock (o)
            {
                OutP = Alphabet(i) + Number(j) + Alphabet(ii) + Number(jj);
                return OutP;
            }
        }
        public ThinkingRefrigtzChessPortable() { }
        //Constructor
        public ThinkingRefrigtzChessPortable(int iInde, int KindO, int CurrentAStarGredy, bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j)
        {

            Object O = new Object();
            lock (O)
            {
                //Initiate Variables.
                if (feedCancellationTokenSource == null) feedCancellationTokenSource = new CancellationTokenSource();
                iIndex = iInde;
                CurrentAStarGredyMax = CurrentAStarGredy;
                MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
                IgnoreSelfObjectsT = IgnoreSelfObject;
                UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
                BestMovmentsT = BestMovment;
                PredictHeuristicT = PredictHurist;
                OnlySelfT = OnlySel;
                AStarGreedyHeuristicT = AStarGreedyHuris;
                ArrangmentsChanged = Arrangments;
                Row = i;
                Column = j;
                //Clear Dearty Part.
                if (KindO == 1)
                {
                    TableListSolder = new List<int[,]>();
                    RowColumnSoldier = new List<int[]>();
                    HitNumberSoldier = new List<int>();
                    HeuristicListSolder = new List<int[]>();
                    PenaltyRegardListSolder = new List<QuantumAtamata>();
                }
                else
                    if (KindO == 2)
                {
                    TableListElefant = new List<int[,]>();
                    RowColumnElefant = new List<int[]>();
                    HitNumberElefant = new List<int>();
                    HeuristicListElefant = new List<int[]>();
                    PenaltyRegardListElefant = new List<QuantumAtamata>();
                }
                else
                    if (KindO == 3)
                {
                    TableListHourse = new List<int[,]>();
                    RowColumnHourse = new List<int[]>();
                    HitNumberHourse = new List<int>();
                    HeuristicListHourse = new List<int[]>();
                    PenaltyRegardListHourse = new List<QuantumAtamata>();
                }
                else
                    if (KindO == 4)
                {
                    TableListCastle = new List<int[,]>();
                    RowColumnCastle = new List<int[]>();
                    HitNumberCastle = new List<int>();
                    HeuristicListCastle = new List<int[]>();
                    PenaltyRegardListCastle = new List<QuantumAtamata>();
                }
                else
                    if (KindO == 5)
                {
                    TableListMinister = new List<int[,]>();
                    RowColumnMinister = new List<int[]>();
                    HitNumberMinister = new List<int>();
                    HeuristicListMinister = new List<int[]>();
                    PenaltyRegardListMinister = new List<QuantumAtamata>();
                }
                else if (KindO == 6)
                {
                    TableListKing = new List<int[,]>();
                    RowColumnKing = new List<int[]>();
                    HitNumberKing = new List<int>();
                    HeuristicListKing = new List<int[]>();
                    PenaltyRegardListKing = new List<QuantumAtamata>();
                }
                else if (KindO == 7 || KindO == -7)
                {
                    TableListCastling = new List<int[,]>();
                    RowColumnCastling = new List<int[]>();
                    HitNumberCastling = new List<int>();
                    HeuristicListCastling = new List<int[]>();
                    PenaltyRegardListCastling = new List<QuantumAtamata>();
                }
                KillerAtThinking = new List<int>();
                AStarGreedy = new List<AllDraw>();
                //Network  QuantumAtamata Book Initiate For Every Clone.

            }
        }

        //determine When Arrangment of Table Objects is Validated at Begin.
        bool BeginArragmentsOfOrderFinished(int[,] Table, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                int CH = 0;
                if (ArrangmentsChanged)
                {
                    if (Order == 1)
                    {
                        //Number of Gray Objects at Last Row Bottmm.
                        for (var i = 0; i < 2; i++)
                            for (var j = 6; j < 8; j++)
                                if (Table[i, j] > 0)
                                    CH++;
                    }
                    else
                    {
                        //Number of Brown Objects at Last tow Row Upper.
                        for (var i = 0; i < 8; i++)
                            for (var j = 0; j < 2; j++)
                                if (Table[i, j] < 0)
                                    CH++;
                    }
                }
                else
                {
                    if (Order == -1)
                    {
                        //Number of Brown Objects Table at Last tow row Uppper.
                        for (var i = 0; i < 8; i++)
                            for (var j = 6; j < 2; j++)
                                if (Table[i, j] > 0)
                                    CH++;
                    }
                    else
                    {
                        //Number of Gray Objects Table at Last tow rown below.
                        for (var i = 0; i < 2; i++)
                            for (var j = 0; j < 8; j++)
                                if (Table[i, j] < 0)
                                    CH++;
                    }
                }
                if (CH <= 8)
                    return true;
                return false;
            }
        }
        //Constructor
        public ThinkingRefrigtzChessPortable(int iInde, int KindO, int CurrentAStarGredy, bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int i, int j, Color a, int[,] Tab, int Ma, int Ord, bool ThinkingBeg, int CurA, int ThingN, int Kin)
        {
            Object O = new Object();
            lock (O)
            {
                if (feedCancellationTokenSource == null) feedCancellationTokenSource = new CancellationTokenSource();
                iIndex = iInde;
                CurrentAStarGredyMax = CurrentAStarGredy;
                MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
                IgnoreSelfObjectsT = IgnoreSelfObject;
                UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
                BestMovmentsT = BestMovment;
                PredictHeuristicT = PredictHurist;
                OnlySelfT = OnlySel;
                AStarGreedyHeuristicT = AStarGreedyHuris;
                //Initiate Variables.
                ArrangmentsChanged = Arrangments;
                Kind = Kin;
                SetObjectNumbers(Tab);
                AStarGreedy = new List<AllDraw>();
                ThingsNumber = ThingN;
                CurrentArray = CurA;
                if (KindO == 1)
                {
                    TableListSolder = new List<int[,]>();
                    RowColumnSoldier = new List<int[]>();
                    HitNumberSoldier = new List<int>();
                    HeuristicListSolder = new List<int[]>();
                    PenaltyRegardListSolder = new List<QuantumAtamata>();
                }
                else
                       if (KindO == 2)
                {
                    TableListElefant = new List<int[,]>();
                    RowColumnElefant = new List<int[]>();
                    HitNumberElefant = new List<int>();
                    HeuristicListElefant = new List<int[]>();
                    PenaltyRegardListElefant = new List<QuantumAtamata>();
                }
                else
                       if (KindO == 3)
                {
                    TableListHourse = new List<int[,]>();
                    RowColumnHourse = new List<int[]>();
                    HitNumberHourse = new List<int>();
                    HeuristicListHourse = new List<int[]>();
                    PenaltyRegardListHourse = new List<QuantumAtamata>();
                }
                else
                       if (KindO == 4)
                {
                    TableListCastle = new List<int[,]>();
                    RowColumnCastle = new List<int[]>();
                    HitNumberCastle = new List<int>();
                    HeuristicListCastle = new List<int[]>();
                    PenaltyRegardListCastle = new List<QuantumAtamata>();
                }
                else
                       if (KindO == 5)
                {
                    TableListMinister = new List<int[,]>();
                    RowColumnMinister = new List<int[]>();
                    HitNumberMinister = new List<int>();
                    HeuristicListMinister = new List<int[]>();
                    PenaltyRegardListMinister = new List<QuantumAtamata>();
                }
                else if (KindO == 6)
                {
                    TableListKing = new List<int[,]>();
                    RowColumnKing = new List<int[]>();
                    HitNumberKing = new List<int>();
                    HeuristicListKing = new List<int[]>();
                    PenaltyRegardListKing = new List<QuantumAtamata>();
                }
                else if (KindO == 7 || KindO == -7)
                {
                    TableListCastling = new List<int[,]>();
                    RowColumnCastling = new List<int[]>();
                    HitNumberCastling = new List<int>();
                    HeuristicListCastling = new List<int[]>();
                    PenaltyRegardListCastling = new List<QuantumAtamata>();
                }
                KillerAtThinking = new List<int>();
                AStarGreedy = new List<AllDraw>();

                Row = i;
                Column = j;
                color = a;
                Max = Ma;
                TableT = Tab;
                IndexSoldier = 0;
                IndexElefant = 0;
                IndexHourse = 0;
                IndexCastle = 0;
                IndexMinister = 0;
                IndexKing = 0;
                IndexCastling = 0;
                TableConst = CloneATable(Tab);
                Order = Ord;
                ThinkingBegin = ThinkingBeg;


            }
        }
        //Clone A Table
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
        //Clone A List.  
        int[] CloneAList(int[] Tab, int Count)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate new Objects.
                int[] Table = new int[Count];
                //Asigne to new Objects.
                for (var i = 0; i < Count; i++)
                    Table[i] = Tab[i];
                //Retrun new Object.
                return Table;
            }
        }
        //Clone a copy of an array.
        //Gwt Value of Book Netwrok  Atamtat at Every Need time form parameters index.
        int GetValue(int i, int j)
        {
            Object O = new Object();
            lock (O)
            {
                return Value[i, j];
            }
        }
        ///Clone a Copy.
        public void Clone(ref ThinkingRefrigtzChessPortable AA)
        {
            Object O = new Object();
            lock (O)
            {
                //Assignment Content to New Content Object.
                //Initaite New Object.
                if (AA == null)
                    AA = new ThinkingRefrigtzChessPortable(iIndex, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Row, Column//, Kind
                        );
                AA.ArrangmentsChanged = ArrangmentsChanged;
                //When Depth Object is not NULL.
                if (AStarGreedy.Count != 0)
                {
                    AA.AStarGreedy = new System.Collections.Generic.List<AllDraw>();
                    //For All Depth(s).
                    for (var i = 0; i < AStarGreedy.Count; i++)
                    {
                        //Clone a Copy From Depth Objects.
                        AStarGreedy[i].Clone(AA.AStarGreedy[i]);
                    }
                }
                //For All Moves Indexx Solders List Count.
                for (var j = 0; j < RowColumnSoldier.Count; j++)
                    //Add a Clone To New Solder indexx Object.
                    AA.RowColumnSoldier.Add(CloneAList(RowColumnSoldier[j], 2));
                //For All Castle List Count.
                for (var j = 0; j < RowColumnCastle.Count; j++)
                    //Add a Clone to New Castle index Objects List.
                    AA.RowColumnCastle.Add(CloneAList(RowColumnCastle[j], 2));
                //For All Elephant index List Count.
                for (var j = 0; j < RowColumnElefant.Count; j++)
                    //Add a Clone to New Elephant Object List.
                    AA.RowColumnElefant.Add(CloneAList(RowColumnElefant[j], 2));
                //For All Hourse index List Count.
                for (var j = 0; j < RowColumnHourse.Count; j++)
                    //Add a Clone to New Hourse index List.
                    AA.RowColumnHourse.Add(CloneAList(RowColumnHourse[j], 2));
                //For All King index List Count.
                for (var j = 0; j < RowColumnKing.Count; j++)
                    //Add a Clone To New King Object List.
                    AA.RowColumnKing.Add(CloneAList(RowColumnKing[j], 2));
                //For All Minister index Count.
                for (var j = 0; j < RowColumnMinister.Count; j++)
                    //Add a Clone To Minister New index List.
                    AA.RowColumnMinister.Add(CloneAList(RowColumnMinister[j], 2));
                for (var j = 0; j < RowColumnCastling.Count; j++)
                    //Add a Clone To New King Object List.
                    AA.RowColumnCastling.Add(CloneAList(RowColumnCastling[j], 2));
                //Assgine thread.
                //Create and Initiate new Table Object.
                AA.TableT = new int[8, 8];
                //Create and Initaite New Table Object.
                AA.TableConst = new int[8, 8];
                //if Table is not NULL>
                if (TableT != null)
                    //For All Items in Table Object.
                    for (var i = 0; i < 8; i++)
                        for (var j = 0; j < 8; j++)
                            //Assgine Table items in New Table Object.
                            AA.TableT[i, j] = TableT[i, j];
                //If Table is Not Null.
                if (TableConst != null)
                    //For All Items in Table Object.
                    for (var i = 0; i < 8; i++)
                        for (var j = 0; j < 8; j++)
                            //Assignm Items in New Table Object.
                            AA.TableConst[i, j] = TableConst[i, j];
                //For All Table State Movements in Castles Objects.
                for (var i = 0; i < TableListCastle.Count; i++)
                    //Add aclon of a Table in New Briges Table List.
                    AA.TableListCastle.Add(CloneATable(TableListCastle[i]));
                //For All Table List Movements in  Elephant Objects 
                for (var i = 0; i < TableListElefant.Count; i++)
                    //Add a Clone of Tables in Elephant Mevments Obejcts List To New One.
                    AA.TableListElefant.Add(CloneATable(TableListElefant[i]));
                //For All Hourse Table Movemnts items.
                for (var i = 0; i < TableListHourse.Count; i++)
                    //Add a Clone of Hourse Table Movement in New List.
                    AA.TableListHourse.Add(CloneATable(TableListHourse[i]));
                //For All King Tables Movment Count.
                for (var i = 0; i < TableListKing.Count; i++)
                    //Add a Clone To New King Table List.
                    AA.TableListKing.Add(CloneATable(TableListKing[i]));
                //For All Minister Table Movment Items.
                for (var i = 0; i < TableListMinister.Count; i++)
                    //Add a clone To New Minister Table Movment List.
                    AA.TableListMinister.Add(CloneATable(TableListMinister[i]));
                //For All Solder Table Movment Count.
                for (var i = 0; i < TableListSolder.Count; i++)
                    //Add a Clone of Table item to New Table List Movments.
                    AA.TableListSolder.Add(CloneATable(TableListSolder[i]));
                for (var i = 0; i < TableListCastling.Count; i++)
                    //Add a Clone To New King Table List.
                    AA.TableListCastling.Add(CloneATable(TableListCastling[i]));
                //For All Solder Husrist List Count.
                for (var i = 0; i < HeuristicListSolder.Count; i++)
                    //Ad a Clone of Hueristic Solders To New List.
                    AA.HeuristicListSolder.Add(CloneAList(HeuristicListSolder[i], 4));
                //For All Elephant Heuristic List Count. 
                for (var i = 0; i < HeuristicListElefant.Count; i++)
                    //Add A Clone of Copy to New Elephant Heuristic List.
                    AA.HeuristicListElefant.Add(CloneAList(HeuristicListElefant[i], 4));
                //For All Hours Heuristic Hourse Count.
                for (var i = 0; i < HeuristicListHourse.Count; i++)
                    //Add a Clone of Copy To New Housre Heuristic List.
                    AA.HeuristicListHourse.Add(CloneAList(HeuristicListHourse[i], 4));
                //For All Castles Heuristic List Count.
                for (var i = 0; i < HeuristicListCastle.Count; i++)
                    //Add a Clone of Copy to New Castles Heuristic List.
                    AA.HeuristicListCastle.Add(CloneAList(HeuristicListCastle[i], 4));
                //For All Minister Heuristic List Count.
                for (var i = 0; i < HeuristicListMinister.Count; i++)
                    //Add a Clone of Copy to New Minister List.
                    AA.HeuristicListMinister.Add(CloneAList(HeuristicListMinister[i], 4));
                //For All King Husrict List Items.
                for (var i = 0; i < HeuristicListKing.Count; i++)
                    //Add a Clone of Copy to New King Hursitic List.
                    AA.HeuristicListKing.Add(CloneAList(HeuristicListKing[i], 4));
                for (var i = 0; i < HeuristicListCastling.Count; i++)
                    //Add a Clone of Copy to New King Hursitic List.
                    AA.HeuristicListCastling.Add(CloneAList(HeuristicListCastling[i], 4));
                //Initiate and create Penalty Solder List.
                AA.PenaltyRegardListSolder = new List<QuantumAtamata>();
                //For All Solder Penalty List Count.
                if (Kind == 1)
                {
                    AA.PenaltyRegardListSolder = new List<QuantumAtamata>();
                    for (var i = 0; i < PenaltyRegardListSolder.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        //Add New Object Create to New Penalty Solder List.
                        AA.PenaltyRegardListSolder.Add(PenaltyRegardListSolder[i]);
                    }
                }
                else
                if (Kind == 2)
                {
                    //Initaite and Create Elephant Penalty List Object.
                    AA.PenaltyRegardListElefant = new List<QuantumAtamata>();
                    //For All Elepahtn Penalty List Count.
                    for (var i = 0; i < PenaltyRegardListElefant.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        //Clone a Copy Of Penalty Elephant.
                        AA.PenaltyRegardListElefant.Add(PenaltyRegardListElefant[i]);
                        //Add New Object Create to New Penalty Elephant List.
                    }
                }
                else
            if (Kind == 3)
                {
                    //Initaite and Create Hourse Penalty List Object.
                    AA.PenaltyRegardListHourse = new List<QuantumAtamata>();
                    //For All Solder Hourse List Count.
                    for (var i = 0; i < PenaltyRegardListHourse.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                        //Clone a Copy Of Penalty Hourse.
                        //Add New Object Create to New Penalty Hourse List.
                        AA.PenaltyRegardListHourse.Add(PenaltyRegardListHourse[i]);
                    }
                }
                else
                if (Kind == 4)
                {
                    //Initaite and Create Castles Penalty List Object.
                    AA.PenaltyRegardListCastle = new List<QuantumAtamata>();
                    //For All Solder Castle List Count.
                    for (var i = 0; i < PenaltyRegardListCastle.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        //Clone a Copy Of Penalty Castles.
                        //Add New Object Create to New Penalty Castles List.
                        AA.PenaltyRegardListCastle.Add(PenaltyRegardListCastle[i]);
                    }
                }
                else
                if (Kind == 5)
                {
                    //Initaite and Create Minister Penalty List Object.
                    AA.PenaltyRegardListMinister = new List<QuantumAtamata>();
                    //For All Solder Minster List Count.
                    for (var i = 0; i < PenaltyRegardListMinister.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        //Clone a Copy Of Penalty Minsiter.
                        //Add New Object Create to New Penalty Minsietr List.
                        AA.PenaltyRegardListMinister.Add(PenaltyRegardListMinister[i]);
                    }
                }
                else
                if (Kind == 7 || Kind == -7)
                {
                    //Initaite and Create King Penalty List Object.
                    AA.PenaltyRegardListCastling = new List<QuantumAtamata>();
                    //For All Solder King List Count.
                    for (var i = 0; i < PenaltyRegardListCastling.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        //Clone a Copy Of Penalty King.
                        //Add New Object Create to New Penalty King List.
                        AA.PenaltyRegardListCastling.Add(PenaltyRegardListCastling[i]);
                    }
                }
                else
                if (Kind == 6)
                {
                    //Initaite and Create King Penalty List Object.
                    AA.PenaltyRegardListKing = new List<QuantumAtamata>();
                    //For All Solder King List Count.
                    for (var i = 0; i < PenaltyRegardListKing.Count; i++)
                    {
                        //Initiate a new  QuantumAtamata Object
                        //Clone a Copy Of Penalty King.
                        //Add New Object Create to New Penalty King List.
                        AA.PenaltyRegardListKing.Add(PenaltyRegardListKing[i]);
                    }
                }
                //Iniktiate Same Obejcts to New Same Obejcts.
                AA.AStarGreedy = AStarGreedy;
                AA.CastleValue = CastleValue;
                AA.color = color;
                AA.Column = Column;
                AA.CurrentArray = CurrentArray;
                AA.CurrentColumn = CurrentColumn;
                AA.CurrentRow = CurrentRow;
                AA.ElefantValue = ElefantValue;
                AA.ExistingOfEnemyHiiting = ExistingOfEnemyHiiting;
                AA.HourseValue = HourseValue;
                AA.IgnoreObjectDangour = IgnoreObjectDangour;
                AA.IndexCastle = IndexCastle;
                AA.IndexElefant = IndexElefant;
                AA.IndexHourse = IndexHourse;
                AA.IndexKing = IndexKing;
                AA.IndexCastling = IndexCastling;
                AA.IndexMinister = IndexMinister;
                AA.IndexSoldier = IndexSoldier;
                AA.IsCheck = IsCheck;
                AA.Kind = Kind;
                AA.KingValue = KingValue;
                AA.CheckMateAStarGreedy = CheckMateAStarGreedy;
                AA.CheckMateOcuured = CheckMateOcuured;
                AA.Max = Max;
                AA.MinisterValue = MinisterValue;
                AA.Order = Order;
                AA.Row = Row;
                AA.SodierValue = SodierValue;
                AA.ThingsNumber = ThingsNumber;
                AA.ThinkingBegin = ThinkingBegin;
                AA.ThinkingFinished = ThinkingFinished;
            }
        }
        bool IsDistributedObjectAttackNonDistributedEnemyObject(bool Before, int[,] Table, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if ((Table[RowS, ColS] != TableInitiation[RowS, ColS]) && (Table[RowD, ColD] == TableInitiation[RowD, ColD]))
                    Is = true;
                return Is;
            }
        }
        ///Heuristic of Attacker.
        int HeuristicAttack(bool Before, int[,] Table, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicAttackValue = 0;
                int HA = 0;
                int DumOrder = Order;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                ///When AStarGreedy Heuristic is Not Assigned.
                //When Heuristic is not Greedy.
                if (!AStarGreedyHeuristicT)
                {
                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    if (RowS == RowD && ColS == ColD)
                        return HeuristicAttackValue;
                    int Sign = new int();
                    Order = DummyOrder;
                    ///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
                    ///What is Attack!
                    ///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
                    if (Table[RowD, ColD] > 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = -1;
                        Sign = AllDraw.SignAttack;
                        ChessRules.CurrentOrder = -1;
                        a = Color.Brown;
                    }
                    else if (Table[RowD, ColD] < 0 && DummyOrder == 1 && Table[RowS, ColS] > 0)
                    {
                        Order = 1;
                        Sign = AllDraw.SignAttack;
                        ChessRules.CurrentOrder = -1;
                        a = Color.Gray;
                    }
                    else
                        return HeuristicAttackValue;
                    //For Attack Movments.- GetObjectValueHeuristic
                    Object O1 = new Object();
                    lock (O1)
                    {
                        //if (Before)
                        {
                            bool ab = false;
                            var th = Task.Factory.StartNew(() => ab = IsDistributedObjectAttackNonDistributedEnemyObject(Before, CloneATable(Table), Ord, aa, RowS, ColS, RowD, ColD));
                            th.Wait();
                            th.Dispose();
                            if (ab)
                                HA += RationalPenalty;
                            else
                            {
                                var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                                th1.Wait();
                                th1.Dispose();

                                if (ab)
                                {
                                    HA += RationalRegard;
                                    //When there is supporter of attacked Objects take Heuristic negative else take muliply sign and muliply Heuristic.
                                    int Supported = new int();
                                    int SupportedS = new int();
                                    Supported = 0;
                                    SupportedS = 0;
                                    //For All Enemy Obejcts.                                             
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                    for (int g = 0; g < 8; g++)
                                    {
                                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                        for (int h = 0; h < 8; h++)
                                        {
                                            //Ignore Of Self Objects.
                                            if (Order == 1 && Table[g, h] >= 0)
                                                continue;
                                            if (Order == -1 && Table[g, h] <= 0)
                                                continue;
                                            Color aaa = new Color();
                                            //Assgin Enemy ints.
                                            aaa = Color.Gray;
                                            if (Order * -1 == -1)
                                                aaa = Color.Brown;
                                            else
                                                aaa = Color.Gray;
                                            //When Enemy is Supported.
                                            bool A = new bool();
                                            bool B = new bool();
                                            Object O2 = new Object();
                                            lock (O2)
                                            {
                                                var th2 = Task.Factory.StartNew(() => A = Support(CloneATable(Table), g, h, RowD, ColD, aaa, Order * -1));
                                                th2.Wait();
                                                th2.Dispose();
                                                var th3 = Task.Factory.StartNew(() => B = Support(CloneATable(Table), g, h, RowS, ColS, a, Order));
                                                th3.Wait();
                                                th3.Dispose();
                                            }
                                            //When Enemy is Supported.
                                            if (B)
                                            {
                                                //Assgine variable.
                                                SupportedS++;
                                            }
                                            if (A)
                                            {
                                                //Assgine variable.
                                                Supported++;
                                                continue;
                                            }
                                        }
                                    }

                                    if (SupportedS > 0 && Supported == 0)
                                        HA *= (int)System.Math.Pow(2, SupportedS);
                                    else
                                    if (Supported > 0)
                                        HA *= (int)(-1 * System.Math.Pow(2, Supported));
                                }
                            }
                        }
                    }
                }
                //For All Table Homes find Attack Heuristic.
                else
                {
                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    //Ignore of Current.
                    if (RowS == RowD && ColS == ColD)
                        return HeuristicAttackValue;
                    Order = DummyOrder;
                    int Sign = 1;
                    ///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
                    ///What is Attack!
                    ///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
                    if (Table[RowD, ColD] > 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = -1;
                        Sign = AllDraw.SignAttack;
                        ChessRules.CurrentOrder = -1;
                        a = Color.Brown;
                    }
                    else if (Table[RowD, ColD] < 0 && DummyOrder == 1 && Table[RowS, ColS] > 0)
                    {
                        Order = 1;
                        Sign = AllDraw.SignAttack;
                        ChessRules.CurrentOrder = -1;
                        a = Color.Gray;
                    }
                    else
                        return HeuristicAttackValue;

                    //For Attack Movments.
                    Object O2 = new Object();
                    lock (O2)
                    {
                        //if (Before)
                        {
                            bool ab = false;
                            var th = Task.Factory.StartNew(() => ab = IsDistributedObjectAttackNonDistributedEnemyObject(Before, CloneATable(Table), Ord, aa, RowS, ColS, RowD, ColD));
                            th.Wait();
                            th.Dispose();
                            if (ab)
                                HA += RationalPenalty;
                            var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                            th1.Wait();
                            th1.Dispose();

                            if (ab)
                            {

                                HA += RationalRegard;

                                //When there is supporter of attacked Objects take Heuristic negative else take muliply sign and muliply Heuristic.
                                //For All Enemy Obejcts.                                             
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                int Supported = new int();
                                int SupportedS = new int();
                                Supported = 0;
                                SupportedS = 0;
                                //For All Enemy Obejcts.                                             
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                for (int g = 0; g < 8; g++)
                                {
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                    for (int h = 0; h < 8; h++)
                                    {
                                        //Ignore Of Self Objects.
                                        if (Order == 1 && Table[g, h] >= 0)
                                            continue;
                                        if (Order == -1 && Table[g, h] <= 0)
                                            continue;
                                        Color aaa = new Color();
                                        //Assgin Enemy ints.
                                        aaa = Color.Gray;
                                        if (Order * -1 == -1)
                                            aaa = Color.Brown;
                                        else
                                            aaa = Color.Gray;
                                        //When Enemy is Supported.
                                        bool A = new bool();
                                        bool B = new bool();
                                        Object O12 = new Object();
                                        lock (O12)
                                        {
                                            var th2 = Task.Factory.StartNew(() => A = Support(CloneATable(Table), g, h, RowD, ColD, aaa, Order * -1));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => B = Support(CloneATable(Table), g, h, RowS, ColS, a, Order));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                        //When Enemy is Supported.
                                        if (B)
                                        {
                                            //Assgine variable.
                                            SupportedS++;
                                        }
                                        if (A)
                                        {
                                            //Assgine variable.
                                            Supported++;
                                            continue;
                                        }
                                    }
                                }
                                if (SupportedS > 0 && Supported == 0)
                                    HA *= (int)System.Math.Pow(2, SupportedS);
                                else
                                 if (Supported > 0)
                                    HA *= (int)(-1 * System.Math.Pow(2, Supported));
                            }
                        }
                    }
                }
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                Order = DumOrder;
                //Initiate to Begin Call Orders.
                return 1 * HA;
            }
        }
        bool IsMinisteBreakable(bool Before, int[,] Table, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD)
        {
            bool Is = false;
            const int MinisterGray = 5, MinisterBrown = -5;
            if (Order == -1)
            {
                if (Table[RowD, ColD] == MinisterGray)
                    return true;

            }
            else
            {
                if (Order == 1)
                {
                    if (Table[RowD, ColD] == MinisterBrown)
                        return true;
                }
            }
            return Is;
        }
        bool IsMinistePowerfull(bool Before, int[,] Table, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD)
        {
            bool Is = true;
            const int MinisterGray = 5, MinisterBrown = -5;
            if (Order == 1)
            {
                if (Table[RowS, ColS] == MinisterGray)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table), 31));
                    th.Wait();
                    th.Dispose();
                    if (!ab)
                    {
                        if (ColS < 5)
                            return false;
                    }
                }
            }
            else
            {
                if (Table[RowS, ColS] == MinisterBrown)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table), 31));
                    th.Wait();
                    th.Dispose();
                    if (!ab)
                    {
                        if (ColS > 2)
                            return false;
                    }
                }
            }
            return Is;
        }
        int HeuristicReducsedAttack(bool Before, int[,] Table, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD
                  )
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicReducedAttackValue = 0;
                //Initiate Objects.
                int HA = 0;
                int DumOrder = Order;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                int Sign = 1;
                ///When AStarGreedy Heuristic is Not Assigned.
                bool MinisterOnAttack = false;
                if (!AStarGreedyHeuristicT)
                {
                    //For All Self
                    {
                        {
                            //For Current Object Lcation.
                            Order = new int();
                            Order = DumOrder;
                            Color a = new Color();
                            a = aa;
                            //Ignore Current Unnessery Home.
                            if (RowS == RowD && ColS == ColD)
                                return 0;
                            //Default Is Gray One.
                            Order = DummyOrder;
                            ///When Supporte is true. means [RowD,ColD] Supportes [RowS,ColS].
                            ///What is Supporte!
                            ///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
                            //if (Order == 1 && Table[RowD, ColD] >= 0)
                            //if (Order == -1 && Table[RowD, ColD] <= 0)
                            //if (!Scop(RowD, ColD, RowS, ColS, System.Math.Abs(Table[RowD, ColD])))
                            ///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
                            ///What is Attack!
                            ///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
                            if (Table[RowD, ColD] > 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                            {
                                Order = 1;
                                Sign = 1 * AllDraw.SignAttack;
                                ChessRules.CurrentOrder = 1;
                                a = Color.Gray;
                            }
                            else if (Table[RowD, ColD] < 0 && DummyOrder == 1 && Table[RowS, ColS] > 0)
                            {
                                Order = -1;
                                Sign = 1 * AllDraw.SignAttack;
                                ChessRules.CurrentOrder = -1;
                                a = Color.Brown;
                            }
                            else
                                return HeuristicReducedAttackValue;
                            //For Attack Movments.
                            Object O1 = new Object();
                            lock (O1)
                            {
                                //if (Before)
                                {
                                    bool ab = false;
                                    var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowD, ColD, RowS, ColS, a, Order));
                                    th.Wait();
                                    th.Dispose();
                                    if (ab)
                                    {
                                        MinisterOnAttack = true;
                                        HA += RationalPenalty;
                                        //When there is supporter of attacked Objects take Heuristic negative else take muliply sign and muliply Heuristic.
                                        int Supported = new int();
                                        int SupportedS = new int();
                                        Supported = 0;
                                        SupportedS = 0;
                                        //For All Enemy Obejcts.                                             
                                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                        for (int g = 0; g < 8; g++)
                                        {
                                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                            for (int h = 0; h < 8; h++)
                                            {
                                                //Ignore Of Self Objects.
                                                if (Order == 1 && Table[g, h] >= 0)
                                                    continue;
                                                if (Order == -1 && Table[g, h] <= 0)
                                                    continue;
                                                Color aaa = new Color();
                                                //Assgin Enemy ints.
                                                aaa = Color.Gray;
                                                if (Order * -1 == -1)
                                                    aaa = Color.Brown;
                                                else
                                                    aaa = Color.Gray;
                                                //When Enemy is Supported.
                                                bool A = new bool();
                                                bool B = new bool();
                                                Object O2 = new Object();
                                                lock (O2)
                                                {
                                                    var th2 = Task.Factory.StartNew(() => A = Support(CloneATable(Table), g, h, RowD, ColD, aaa, Order * -1));
                                                    th2.Wait();
                                                    th2.Dispose();
                                                    var th3 = Task.Factory.StartNew(() => B = Support(CloneATable(Table), g, h, RowS, ColS, a, Order));
                                                    th3.Wait();
                                                    th3.Dispose();
                                                }
                                                //When Enemy is Supported.
                                                if (B)
                                                {
                                                    //Assgine variable.
                                                    SupportedS++;
                                                }
                                                if (A)
                                                {
                                                    //Assgine variable.
                                                    Supported++;
                                                    continue;
                                                }
                                            }
                                        }
                                        if (SupportedS > 0 && Supported == 0)
                                            HA *= (int)System.Math.Pow(2, SupportedS);
                                        else
                                              if (Supported > 0)
                                            HA *= (int)(-1 * System.Math.Pow(2, Supported));
                                    }
                                    else
                                    {
                                        if (IsMinisteBreakable(Before, CloneATable(Table), Order, aa, RowS, ColS, RowD, ColD))
                                        {
                                            HA += (3 * RationalPenalty);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //For All Table Homes find Attack Heuristic.
                else
                {

                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    {
                        //Ignore Current Home.
                        //if (Order == 1 && Table[RowD, ColD] >= 0)
                        //if (Order == -1 && Table[RowD, ColD] <= 0)
                        //if (!Scop(RowD, ColD, RowS, ColS, System.Math.Abs(Table[RowD, ColD])))
                        ///When Attack is true. means [RowD,ColD] is in Attacked  [RowS,ColS].
                        ///What is Attack!
                        ///Ans:When [RowD,ColD] is Attacked [RowS,ColS] continue true when enemy is located in [RowD,ColD].
                        if (Table[RowD, ColD] > 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                        {
                            Order = 1;
                            Sign = 1 * AllDraw.SignAttack;
                            ChessRules.CurrentOrder = 1;
                            a = Color.Gray;
                        }
                        else if (Table[RowD, ColD] < 0 && DummyOrder == 1 && Table[RowS, ColS] > 0)
                        {
                            Order = -1;
                            Sign = 1 * AllDraw.SignAttack;
                            ChessRules.CurrentOrder = -1;
                            a = Color.Brown;
                        }
                        else
                            return HeuristicReducedAttackValue;
                        //For Attack Movments.
                        Object O1 = new Object();
                        lock (O1)
                        {
                            //if (Before)
                            {
                                bool ab = false;
                                var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowD, ColD, RowS, ColS, a, Order));
                                th.Wait();
                                th.Dispose();
                                if (ab)
                                {
                                    MinisterOnAttack = true;
                                    HA += RationalPenalty;
                                    //When there is supporter of attacked Objects take Heuristic negative else take muliply sign and muliply Heuristic.
                                    int Supported = new int();
                                    int SupportedS = new int();
                                    Supported = 0;
                                    SupportedS = 0;
                                    //For All Enemy Obejcts.                                             
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                    for (int g = 0; g < 8; g++)
                                    {
                                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                        for (int h = 0; h < 8; h++)
                                        {
                                            //Ignore Of Self Objects.
                                            if (Order == 1 && Table[g, h] >= 0)
                                                continue;
                                            if (Order == -1 && Table[g, h] <= 0)
                                                continue;
                                            Color aaa = new Color();
                                            //Assgin Enemy ints.
                                            aaa = Color.Gray;
                                            if (Order * -1 == -1)
                                                aaa = Color.Brown;
                                            else
                                                aaa = Color.Gray;
                                            //When Enemy is Supported.
                                            bool A = new bool();
                                            bool B = new bool();
                                            Object O2 = new Object();
                                            lock (O2)
                                            {
                                                var th2 = Task.Factory.StartNew(() => A = Support(CloneATable(Table), g, h, RowD, ColD, aaa, Order * -1));
                                                th2.Wait();
                                                th2.Dispose();
                                                var th3 = Task.Factory.StartNew(() => B = Support(CloneATable(Table), g, h, RowS, ColS, a, Order));
                                                th3.Wait();
                                                th3.Dispose();
                                            }
                                            //When Enemy is Supported.
                                            if (B)
                                            {
                                                //Assgine variable.
                                                SupportedS++;
                                            }
                                            if (A)
                                            {
                                                //Assgine variable.
                                                Supported++;
                                                continue;
                                            }
                                        }
                                    }
                                    if (SupportedS > 0 && Supported == 0)
                                        HA *= (int)System.Math.Pow(2, SupportedS);
                                    else
                               if (Supported > 0)
                                        HA *= (int)(-1 * System.Math.Pow(2, Supported));
                                }
                                else
                                {
                                    var th4 = Task.Factory.StartNew(() => ab = IsMinisteBreakable(Before, CloneATable(Table), Order, aa, RowS, ColS, RowD, ColD));
                                    th4.Wait();
                                    th4.Dispose();
                                    if (ab)
                                    {
                                        HA += (3 * RationalPenalty);
                                    }
                                }
                            }
                        }
                    }
                }


                if (!MinisterOnAttack)
                {
                    bool ab = false;
                    var th5 = Task.Factory.StartNew(() => ab = IsMinistePowerfull(Before, CloneATable(Table), Order, aa, RowS, ColS, RowD, ColD));
                    th5.Wait();
                    th5.Dispose();
                    if (ab)
                        HA += RationalRegard;
                }
                else
                {
                    HA += RationalPenalty;
                }
                //Initiate to Begin Call Orders.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                Order = DumOrder;
                //Add Local Heuristic to Global One.
                return HA;
            }
        }
        ///Value of Object method.
        int GetObjectValue(int[,] Tabl, int ii, int jj, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                return System.Math.Abs(Tabl[ii, jj]);
            }
        }
        ///Heuristic of ObjectDanger.
        int HeuristicObjectDangour(int[,] Table, int Order, Color a, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicCheckedMate = 0;
                int HA = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                ///When There is no AStarGreedyHeuristicT
                if (!AStarGreedyHeuristicT)
                {
                    ///For All Object in Current Table.
                    if (RowS == RowD && ColS == ColD)
                        return HeuristicCheckedMate;
                    Order = DummyOrder;
                    int Sign = 1;
                    ///When ObjectDanger is true. means [RowD,ColD] is in ObjectDanger by [RowS,ColS].
                    ///What is ObjectDanger!
                    ///Ans:When [RowS,ColS] is Attacked [RowD,ColD] return true when enemy is located in [RowD,ColD].
                    if (Table[RowD, ColD] > 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = 1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = -1 * AllDraw.SignAttack;
                            ChessRules.CurrentOrder = 1;
                        }
                        a = Color.Gray;
                    }
                    else if (Table[RowD, ColD] < 0 && DummyOrder == 1 && Table[RowS, ColS] > 0)
                    {
                        Order = -1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = -1 * AllDraw.SignAttack;
                            ChessRules.CurrentOrder = -1;
                        }
                        a = Color.Brown;
                    }
                    else
                        return HeuristicCheckedMate;
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = ObjectDanger(CloneATable(Table), RowD, ColD, RowS, ColS, a, Order));

                    th.Wait();
                    th.Dispose();
                    //For ObjectDanger Movments.
                    if (ab)
                    {
                        var th1 = Task.Factory.StartNew(() => HA += Sign * (ObjectValueCalculator(CloneATable(Table), RowD, ColD, RowS, ColS)));
                        th1.Wait();
                        th1.Dispose();
                        //Find Local Sumation of ObjectDanger Heuristic.                               

                    }
                }
                //For All Table Home Find ObjectDanger Heuristic
                else
                {
                    if (RowS == RowD && ColS == ColD)
                        return HeuristicCheckedMate;
                    int Sign = 1;
                    ///When ObjectDanger is true. means [RowD,ColD] is in ObjectDanger by [RowS,ColS].
                    ///What is ObjectDanger!
                    ///Ans:When [RowS,ColS] is Attacked [RowD,ColD] return true when enemy is located in [RowD,ColD].
                    if (Table[RowD, ColD] > 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = 1;
                        Object O2 = new Object();
                        lock (O2)
                        {
                            Sign = -1 * AllDraw.SignAttack;
                            ChessRules.CurrentOrder = 1;
                        }
                        a = Color.Gray;
                    }
                    else if (Table[RowD, ColD] < 0 && DummyOrder == 1 && Table[RowS, ColS] > 0)
                    {
                        Order = -1;
                        Object O3 = new Object();
                        lock (O3)
                        {
                            Sign = -1 * AllDraw.SignAttack;
                            ChessRules.CurrentOrder = -1;
                        }
                        a = Color.Brown;
                    }
                    else
                        return HeuristicCheckedMate;
                    //For ObjectDanger Movments.
                    Object O1 = new Object();
                    lock (O1)
                    {
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = ObjectDanger(CloneATable(Table), RowD, ColD, RowS, ColS, a, Order));
                        th.Wait();
                        th.Dispose();

                        if (ab)
                        {
                            //Find Local Sumation of ObjectDanger Heuristic.                                
                            var th1 = Task.Factory.StartNew(() => HA += Sign * (ObjectValueCalculator(CloneATable(Table), RowD, ColD, RowS, ColS)));
                            th1.Wait();
                            th1.Dispose();
                        }
                    }
                }
                //Initiate Orders to Call Begining.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                //Assignments of Global Heuristic with Local One.
                //return Local Heuristic.
                return HA * 1;
            }
        }
        int HeuristicKiller(int Killed, int[,] Tabl, int RowS, int ColS, int RowD, int ColD, int Ord, Color aa, bool Hit)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Tab = new int[8, 8];
                for (var ik = 0; ik < 8; ik++)
                    for (var jk = 0; jk < 8; jk++)
                        Tab[ik, jk] = Tabl[ik, jk];
                int HeuristicReducedSupport = 0;
                //Defualt is Gray Order.
                int HA = 0;
                int Sign = AllDraw.SignKiller;
                int DummyOrder = Ord;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                //Make live when there is killed.
                if (Killed != 0)
                {
                    Tab[RowD, ColD] = Tab[RowS, ColS];
                    Tab[RowS, ColS] = Killed;
                }

                Order = new int();
                Order = DummyOrder;
                Color a = new Color();
                a = aa;
                Color colorAS = a;
                //Ignore of Self.
                if (Order == 1 && Tab[RowD, ColD] >= 0)
                    return HeuristicReducedSupport;
                if (Order == -1 && Tab[RowD, ColD] <= 0)
                    return HeuristicReducedSupport;
                bool EnemyNotSupported = false;
                a = Color.Gray;
                if (Order == -1)
                    a = Color.Brown;
                //Wehn Curfrent Movemnet is on attack.
                Object O1 = new Object();
                lock (O1)
                {
                    var th = Task.Factory.StartNew(() => EnemyNotSupported = InAttackEnemyThatIsNotSupported(Killed, CloneATable(Tab), Order, aa, RowS, ColS, RowD, ColD));
                    th.Wait();
                    th.Dispose();

                    //When there is Attacks to Current Objects and is killable..
                    bool ab = false;
                    var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), RowD, ColD, RowS, ColS, a, Order));
                    th1.Wait();
                    th1.Dispose();
                    if (ab)
                    {
                        if (EnemyNotSupported)
                        {
                            //Heuristic positive.
                            var th2 = Task.Factory.StartNew(() => HA += AllDraw.SignKiller * (int)((ObjectValueCalculator(CloneATable(Tab), RowS, ColS, RowD, ColD)
                            )));
                            th2.Wait();
                            th2.Dispose();
                        }
                        else
                        {
                            //Heuristic ngative.
                            var th2 = Task.Factory.StartNew(() => HA += AllDraw.SignKiller * (int)((ObjectValueCalculator(CloneATable(Tab), RowS, ColS, RowD, ColD)
                            ) * -1));
                            th2.Wait();
                            th2.Dispose();
                        }
                    }
                    a = colorAS;
                }
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                return 1 * HA;
            }
        }
        //Attacks Of Enemy that is not Supported.QC_OK
        bool InAttackEnemyThatIsNotSupported(int Kilded, int[,] Table, int Order, Color a, int i, int j, int ii, int jj)
        {

            Object O = new Object();
            lock (O)
            {
                //Initiate Global Variables.                
                int Ord = Order;
                bool S = true;
                bool EnemyNotSupported = true;
                if (Kilded != 0)
                {
                    EnemyNotSupported = true;
                    //Enemy
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, RowS =>
                    for (var RowS = 0; RowS < 8; RowS++)
                    {
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ColS =>
                        for (var ColS = 0; ColS < 8; ColS++)
                        {
                            if (!EnemyNotSupported)
                                continue;
                            int Order1 = new int();
                            Order1 = Ord;
                            int[,] Tab = new int[8, 8];
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ik =>
                            for (var ik = 0; ik < 8; ik++)
                            {
                                if (!EnemyNotSupported)
                                    continue;
                                for (var jk = 0; jk < 8; jk++)
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, jk =>
                                {
                                    Object O3 = new Object();
                                    lock (O3)
                                    {
                                        Tab[ik, jk] = Table[ik, jk];
                                    }
                                }
                            }
                            Object O2 = new Object();
                            lock (O2)
                            {
                                Tab[i, j] = Tab[ii, jj];
                                Tab[ii, jj] = Kilded;
                            }
                            //Ignore of Current
                            if (Order1 == 1 && Tab[RowS, ColS] >= 0)
                                continue;
                            else
                                    if (Order1 == -1 && Tab[RowS, ColS] <= 0)
                                continue;
                            a = Color.Gray;
                            if (Order1 * -1 == -1)
                                a = Color.Brown;
                            //When Enemy is Supported.
                            Object O1 = new Object();
                            lock (O1)
                            {
                                bool ab = false;
                                var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowS, ColS, ii, jj, a, Order1 * -1)
                                        && ObjectValueCalculator(CloneATable(Tab), i, j) >= ObjectValueCalculator(CloneATable(Tab), ii, jj));

                                th.Wait();
                                th.Dispose();
                                if (ab)
                                //Wehn [i,j] (Current) is less or equal than [ii,jj] (Enemy) 
                                //EnemyNotSupported method Should continue [valid]
                                //By this situation continue not valid
                                {
                                    EnemyNotSupported = false;
                                    continue;
                                }
                            }
                        }
                        if (!EnemyNotSupported)
                            continue;
                    }
                    if (EnemyNotSupported)
                        S = false;
                }
                //When S is not valid there is one node in [EnemyNotSupported]
                if (!S)
                {
                    Order = Ord;
                    return true;
                }
                Order = Ord;
                return false;
            }
        }
        //When at least one Attacked Self Object return true.
        bool InAttackEnemyThatIsNotSupportedAll(bool EnemyIsValuable, int[,] Table, int Order, Color a, int ij, int ji, int iij, int jji, ref List<int[]> ValuableEnemyNotSupported)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate Global Variables.
                int Ord = Order;
                Object O4 = new Object();
                lock (O4)
                {
                    int[,] Tab = new int[8, 8];
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tab[ik, jk] = Table[ik, jk];
                    bool S = true;
                    bool EnemyNotSupported = true;
                    bool InAttackedNotEnemySupported = false;
                    //For Current
                    for (var i = 0; i < 8; i++)
                    {
                        for (var j = 0; j < 8; j++)
                        {
                            //Ignore of Enemy
                            if (Order == 1 && Tab[i, j] <= 0)
                                continue;
                            else
                                if (Order == -1 && Tab[i, j] >= 0)
                                continue;
                            //For Enemies.
                            for (var ii = 0; ii < 8; ii++)
                            {
                                for (var jj = 0; jj < 8; jj++)
                                {
                                    //Ignore of Curent
                                    if (Order == 1 && Tab[ii, jj] >= 0)
                                        continue;
                                    else
                                        if (Order == -1 && Tab[ii, jj] <= 0)
                                        continue;
                                    Object O1 = new Object();
                                    lock (O1)
                                    {
                                        bool ab = false;
                                        List<int[]> ValuableEnemyNotSupportedA = ValuableEnemyNotSupported;
                                        var th = Task.Factory.StartNew(() => ab = EnemyIsValuable && (!IsObjectValaubleObjectEnemy(ii, jj, Tab[ii, jj], ref ValuableEnemyNotSupportedA)));
                                        th.Wait();
                                        th.Dispose();

                                        ValuableEnemyNotSupported = ValuableEnemyNotSupportedA;

                                        if (ab)
                                            continue;
                                        EnemyNotSupported = true;
                                        InAttackedNotEnemySupported = false;
                                        var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), i, j, ii, jj, a, Order));
                                        th1.Wait();
                                        th1.Dispose();

                                        if (ab)
                                        {
                                            InAttackedNotEnemySupported = true;
                                            //Enemy
                                            for (var RowS = 0; RowS < 8; RowS++)
                                            {
                                                for (var ColS = 0; ColS < 8; ColS++)
                                                {
                                                    //Ignore of Current
                                                    if (Order == 1 && Tab[RowS, ColS] >= 0)
                                                        continue;
                                                    else
                                                        if (Order == -1 && Tab[RowS, ColS] <= 0)
                                                        continue;
                                                    a = Color.Gray;
                                                    if (Order * -1 == -1)
                                                        a = Color.Brown;
                                                    //
                                                    var th2 = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowS, ColS, ii, jj, a, Order * -1));
                                                    th2.Wait();
                                                    th2.Dispose();

                                                    if (ab
                                                        //&& (ObjectValueCalculator(CloneATable(Tab),i,j) >= ObjectValueCalculator(CloneATable(Tab),ii,jj)
                                                        //Wehn [i,j] (Current) is less or equal than [ii,jj] (Enemy) 
                                                        //EnemyNotSupported method Should return [valid]
                                                        //By this situation return not valid
                                                        )
                                                    {
                                                        EnemyNotSupported = false;
                                                    }
                                                }
                                                if (!EnemyNotSupported)
                                                    break;
                                            }
                                        }
                                        if (EnemyNotSupported && InAttackedNotEnemySupported)
                                        {
                                            S = false;
                                            break;
                                        }
                                    }
                                }
                                if (!S)
                                {
                                    break;
                                }
                            }
                            if (!S)
                            {
                                break;
                            }
                        }
                        if (!S)
                        {
                            break;
                        }
                    }
                    //When there is at leat tow enmy of attackment.
                    if (!S)
                    {
                        Order = Ord;
                        return true;
                    }
                    Order = Ord;
                }
                return false;
            }
        }
        //When  there is more than tow self object not supported on atacked by movement return true.
        int IsNotSafeToMoveAenemeyToAttackMoreThanTowObject(int AttackCount, int[,] Table, int Order, int i, int j, int ii, int jj)
        {

            //For All Enemie
            Object O1 = new Object();
            lock (O1)
            {
                //Ignore of Self
                if (Order == 1 && Table[i, j] >= 0)
                {
                    return 0;
                }
                if (Order == -1 && Table[i, j] <= 0)
                {
                    return 0;
                }
                //For All Self and Empty.
                //Ignore of Enemy.
                if (Order == 1 && Table[ii, jj] < 0)
                {
                    return 0;
                }
                if (Order == -1 && Table[ii, jj] > 0)
                {
                    return 0;
                }
                ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[i, j], CloneATable(Table), Order * -1, i, j);
                Color a = Color.Gray;
                if (Order * -1 == -1)
                    a = Color.Brown;
                int[,] Tab = new int[8, 8];
                Object O = new Object();
                lock (O)
                {
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tab[ik, jk] = Table[ik, jk];
                }
                //When there is attack to some self node.
                Object OO = new Object();
                lock (OO)
                {
                    if (A.Rules(i, j, ii, jj, a, Tab[i, j]))
                    {
                        //take move
                        Tab[ii, jj] = Tab[i, j];
                        Tab[i, j] = 0;
                        AttackCount = 0;
                        //For All Self
                        for (var RowS = 0; RowS < 8; RowS++)
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, RowS =>
                        {
                            //if (AttackCount > 1)
                            for (var ColS = 0; ColS < 8; ColS++)
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ColS =>
                            {
                                if (AttackCount > 1)
                                    continue;
                                //Ignore of Enemy.
                                if (Order == 1 && Tab[RowS, ColS] <= 0)
                                    continue;
                                if (Order == -1 && Tab[RowS, ColS] >= 0)
                                    continue;
                                a = Color.Gray;
                                if (Order * -1 == -1)
                                    a = Color.Brown;
                                bool ab = false;
                                var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), ii, jj, RowS, ColS, a, Order * -1));
                                th.Wait();
                                th.Dispose();
                                //when there is attack to some self node.
                                if (ab)
                                {
                                    bool Supporte = false;
                                    //For All Self
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, RowD =>
                                    for (int RowD = 0; RowD < 8; RowD++)
                                    {
                                        if (AttackCount > 1)
                                            continue;
                                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ColD =>
                                        for (int ColD = 0; ColD < 8; ColD++)
                                        {
                                            if (AttackCount > 1)
                                                continue;
                                            //Ignore of Enemy.
                                            if (Order == 1 && Tab[RowD, ColD] <= 0)
                                                continue;
                                            if (Order == -1 && Tab[RowD, ColD] >= 0)
                                                continue;
                                            a = Color.Gray;
                                            if (Order == -1)
                                                a = Color.Brown;
                                            //when there is attack of self node to that enemy node.
                                            var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowD, ColD, RowS, ColS, a, Order) || Attack(CloneATable(Tab), RowD, ColD, ii, jj, a, Order));
                                            th1.Wait();
                                            th1.Dispose();
                                            if (ab)
                                            {
                                                Supporte = true;
                                                continue;
                                            }
                                        }
                                    }
                                    if (!Supporte)
                                        AttackCount++;
                                }
                                else
                                    continue;
                                if (AttackCount > 1)
                                    continue;
                            }
                            if (AttackCount > 1)
                                continue;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                return AttackCount;
            }
        }
        //Supported of Self that is Not Attacks.QC_BAD
        bool InAttackSelfThatNotSupported(int[,] TableS, int Order, Color a, int ij, int ji, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate Variables.
                int[,] Tab = new int[8, 8];
                Object O1 = new Object();
                lock (O1)
                {
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tab[ik, jk] = TableS[ik, jk];
                    int Ord = Order;
                    bool SelfSupported = false;
                    bool InAttackedNotSelfSupported = false;
                    bool IsObjDangerest = false;
                    bool S = true;
                    int i = ii, j = jj;
                    //Ignore of Current
                    //For Enemy.
                    for (var RowS = 0; RowS < 8; RowS++)
                    {
                        for (var ColS = 0; ColS < 8; ColS++)
                        {
                            //Ignore of Current
                            if (Order == 1 && Tab[RowS, ColS] >= 0)
                                continue;
                            else
                            if (Order == -1 && Tab[RowS, ColS] <= 0)
                                continue;
                            //Enemy
                            a = Color.Gray;
                            if (Order * -1 == -1)
                                a = Color.Brown;
                            for (var ik = 0; ik < 8; ik++)
                                for (var jk = 0; jk < 8; jk++)
                                    Tab[ik, jk] = TableS[ik, jk];
                            InAttackedNotSelfSupported = false;
                            SelfSupported = false;
                            Object OO = new Object();
                            lock (OO)
                            {
                                bool ab = false;
                                var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), RowS, ColS, i, j, a, Order * -1));
                                th.Wait();
                                th.Dispose();
                                if (ab)
                                {
                                    InAttackedNotSelfSupported = true;
                                    a = Color.Gray;
                                    if (Order == -1)
                                        a = Color.Brown;
                                    //For Self.
                                    for (int RowD = 0; RowD < 8; RowD++)
                                    {
                                        for (int ColD = 0; ColD < 8; ColD++)
                                        {
                                            //Ignore of Enemies
                                            if (Order == 1 && Tab[RowD, ColD] <= 0)
                                                continue;
                                            else
                                                if (Order == -1 && Tab[RowD, ColD] >= 0)
                                                continue;
                                            a = Color.Gray;
                                            if (Order == -1)
                                                a = Color.Brown;
                                            for (var ik = 0; ik < 8; ik++)
                                                for (var jk = 0; jk < 8; jk++)
                                                    Tab[ik, jk] = TableS[ik, jk];
                                            //When there is support and cuurent is less than enemy.
                                            //method return true when is not supporte and the enemy is less than cuurent in to be hitten.
                                            var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowD, ColD, i, j, a, Order));
                                            th1.Wait();
                                            th1.Dispose();
                                            if (ab)
                                            {
                                                SelfSupported = true;
                                                S = S && true;
                                                break;
                                            }
                                        }
                                        if (SelfSupported)
                                            break;
                                    }
                                    //When a source enemy object attack a destination source object 
                                    //a source object is greater than another source object. Is = -1 Is another object valuable.
                                    //a source object is less than or equal  than another source object.Is = 1 Is not another object valuable.
                                }
                            }
                            if ((!SelfSupported && InAttackedNotSelfSupported) //|| IsObjDangerest
                            )
                            {
                                S = false;
                                break;
                            }
                        }
                        if ((!SelfSupported && InAttackedNotSelfSupported) || IsObjDangerest
                            )
                        {
                            S = false;
                            break;
                        }
                    }
                    if (!SelfSupported
                         && InAttackedNotSelfSupported
                         )
                    {
                        S = false;
                    }
                    if (!SelfSupported && InAttackedNotSelfSupported)
                    {
                        S = false;
                    }

                    Order = Ord;
                    if (S)
                        return false;
                    return true;
                }
            }
        }
        //When there is at least on self object that is not safty.
        bool InAttackSelfThatNotSupportedAll(int[,] TableS, int Order, Color a, int i, int j, int RowS, int ColS, int ikk, int jkk, int iik, int jjk)
        {
            Object O = new Object();
            lock (O)
            {
                bool S = true;
                int Ord = Order;
                List<int[]> ValuableSelfSupported = new List<int[]>();
                bool IsTowValuableObject = false;
                Object O1 = new Object();
                lock (O1)
                {
                    var th = Task.Factory.StartNew(() => IsTowValuableObject = InAttackSelfThatNotSupportedCalculateValuableAll(CloneATable(TableS), Order, color, ikk, jkk, iik, jjk, ref ValuableSelfSupported));
                    th.Wait();
                    th.Dispose();


                    //Initiate Variables.
                    int[,] Tab = new int[8, 8];
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tab[ik, jk] = TableS[ik, jk];
                    bool SelfSupported = false;
                    bool InAttackedNotSelfSupported = false;
                    S = true;
                    Order = Ord;
                    //Ignore of Enemies
                    if (Order == 1 && Tab[i, j] <= 0)
                        return false;
                    else
                        if (Order == -1 && Tab[i, j] >= 0)
                        return false;
                    //when there is another object valuable in List continue.
                    bool ab = false;
                    var th1 = Task.Factory.StartNew(() => ab = IsTowValuableObject && (!IsObjectValaubleObjectSelf(i, j, Tab[i, j], ref ValuableSelfSupported)));
                    th1.Wait();
                    th1.Dispose();
                    if (ab)
                        return false;
                    Order = Ord;
                    //Ignore of Current
                    if (Order == 1 && Tab[RowS, ColS] >= 0)
                        return false;
                    else
                        if (Order == -1 && Tab[RowS, ColS] <= 0)
                        return false;
                    if (i == RowS && j == ColS)
                        return false;
                    //Enemy
                    a = Color.Gray;
                    Order = Ord;
                    if (Order * -1 == -1)
                        a = Color.Brown;
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tab[ik, jk] = TableS[ik, jk];
                    InAttackedNotSelfSupported = false;
                    SelfSupported = false;
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tab[ik, jk] = TableS[ik, jk];
                    Object O2 = new Object();
                    lock (O2)
                    {
                        var th2 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), RowS, ColS, i, j, a, Order * -1));
                        th2.Wait();
                        th2.Dispose();
                        if (ab)
                        {
                            InAttackedNotSelfSupported = true;
                            a = Color.Gray;
                            if (Order == -1)
                                a = Color.Brown;
                            //For Self.
                            for (int RowD = 0; RowD < 8; RowD++)
                            {
                                for (int ColD = 0; ColD < 8; ColD++)
                                {
                                    //Ignore of Enemies
                                    if (Order == 1 && Tab[RowD, ColD] <= 0)
                                        continue;
                                    else
                                        if (Order == -1 && Tab[RowD, ColD] >= 0)
                                        continue;
                                    if (i == RowD && j == ColD)
                                        continue;
                                    a = Color.Gray;
                                    if (Order == -1)
                                        a = Color.Brown;
                                    for (var ik = 0; ik < 8; ik++)
                                        for (var jk = 0; jk < 8; jk++)
                                            Tab[ik, jk] = TableS[ik, jk];
                                    //When there is supporte and cuurent is less than enemy.
                                    //method return true when is not supporte and the enemy is less than cuurent in to be hitten.
                                    var th3 = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowD, ColD, i, j, a, Order) && (ObjectValueCalculator(CloneATable(Tab), i, j) <= ObjectValueCalculator(CloneATable(Tab), RowS, ColS)));
                                    th3.Wait();
                                    th3.Dispose();
                                    if (ab)
                                    {
                                        SelfSupported = true;
                                        S = S && true;
                                        break;
                                    }
                                }
                                //When a source enemy object attack a destination source object 
                                //a source object is greater than another source object. Is = -1 Is another object valuable.
                                //a source object is less than or equal  than another source object.Is = 1 Is not another object valuable.                                    
                                if (SelfSupported)
                                    break;
                            }
                        }
                    }
                    if ((!SelfSupported && InAttackedNotSelfSupported))
                    {
                        S = false;
                    }
                }
                Order = Ord;

                if (S)
                    return false;
                return true;
            }
        }
        //Creation A Complete List of Attacked Self Object(s).
        bool InAttackSelfThatNotSupportedCalculateValuableAll(int[,] TableS, int Order, Color a, int ij, int ji, int ii, int jj, ref List<int[]> ValuableSelfSupported)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate Variables.
                int[,] Tab = new int[8, 8];
                for (var ik = 0; ik < 8; ik++)
                    for (var jk = 0; jk < 8; jk++)
                        Tab[ik, jk] = TableS[ik, jk];
                int Ord = Order;
                bool SelfSupported = false;
                bool InAttackedNotSelfSupported = false;
                bool S = true;
                //For Self
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        S = true;
                        //Ignore of Enemy
                        if (Order == 1 && Tab[i, j] <= 0)
                            continue;
                        else
                            if (Order == -1 && Tab[i, j] >= 0)
                            continue;
                        //For Enemy.
                        for (var RowS = 0; RowS < 8; RowS++)
                        {
                            for (var ColS = 0; ColS < 8; ColS++)
                            {
                                //Ignore of Current
                                if (Order == 1 && Tab[RowS, ColS] >= 0)
                                    continue;
                                else
                                    if (Order == -1 && Tab[RowS, ColS] <= 0)
                                    continue;
                                //Enemy
                                a = Color.Gray;
                                if (Order * -1 == -1)
                                    a = Color.Brown;
                                for (var ik = 0; ik < 8; ik++)
                                    for (var jk = 0; jk < 8; jk++)
                                        Tab[ik, jk] = TableS[ik, jk];
                                InAttackedNotSelfSupported = false;
                                SelfSupported = false;
                                S = true;
                                //Wehn an Object of Enemy Attack Self Object
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    bool ab = false;
                                    var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), RowS, ColS, i, j, a, Order * -1));
                                    th.Wait();
                                    th.Dispose();
                                    if (ab)
                                    {
                                        InAttackedNotSelfSupported = true;
                                        a = Color.Gray;
                                        if (Order == -1)
                                            a = Color.Brown;
                                        //For Self.
                                        for (int RowD = 0; RowD < 8; RowD++)
                                        {
                                            for (int ColD = 0; ColD < 8; ColD++)
                                            {
                                                //Ignore of Enemies
                                                if (Order == 1 && Tab[RowD, ColD] <= 0)
                                                    continue;
                                                else
                                                    if (Order == -1 && Tab[RowD, ColD] >= 0)
                                                    continue;
                                                a = Color.Gray;
                                                if (Order == -1)
                                                    a = Color.Brown;
                                                for (var ik = 0; ik < 8; ik++)
                                                    for (var jk = 0; jk < 8; jk++)
                                                        Tab[ik, jk] = TableS[ik, jk];
                                                //When There is Supporter For Attacked Self Object and Is Greater than Attacking Object.
                                                var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowD, ColD, i, j, a, Order) && (ObjectValueCalculator(CloneATable(Tab), i, j) <= ObjectValueCalculator(CloneATable(Tab), RowS, ColS)));
                                                th1.Wait();
                                                th1.Dispose();
                                                if (ab)
                                                {

                                                    SelfSupported = true;
                                                    S = S && true;
                                                    break;
                                                }
                                            }
                                            if (SelfSupported)
                                                break;
                                        }
                                        //When a source enemy object attack a destination source object 
                                        //a source object is greater than another source object. Is = -1 Is another object valuable.
                                        //a source object is less than or equal  than another source object.Is = 1 Is not another object valuable.                                        
                                    }
                                }
                                //When Attacked Current Object is not supported and there is another object valuable
                                Object O2 = new Object();
                                lock (O2)
                                {
                                    if ((!SelfSupported && InAttackedNotSelfSupported))
                                    {
                                        S = false;
                                        if (!S)
                                        {
                                            int[] Valuable = new int[3];
                                            Valuable[0] = TableS[i, j];
                                            Valuable[1] = i;
                                            Valuable[2] = j;
                                            if (!ExistValuble(Valuable, ref ValuableSelfSupported))
                                                ValuableSelfSupported.Add(Valuable);
                                            S = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Order = Ord;
                //When There is at Last tow SelfNotSupporeted Object.
                if (ValuableSelfSupported.Count > 1)
                    return true;
                return false;
            }
        }
        bool ExistValuble(int[] Table, ref List<int[]> ValuableSelfSupported)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                for (var i = 0; i < ValuableSelfSupported.Count; i++)
                {
                    if (ValuableSelfSupported[i][0] == Table[0] && ValuableSelfSupported[i][1] == Table[1] && ValuableSelfSupported[i][2] == Table[2])
                    {
                        return true;
                    }
                }
                return Is;
            }
        }
        bool MaxObjecvts(List<int> Obj, int Max)
        {
            Object O = new Object();
            lock (O)
            {
                bool MaxO = true;
                if (Obj.Count > 0)
                {
                    if (Max == 0)
                        return !MaxO;
                    if (Max > 0)
                        if (Obj[0] < 0)
                            return !MaxO;
                    if (Max < 0)
                        if (Obj[0] > 0)
                            return !MaxO;
                    for (var i = 0; i < Obj.Count; i++)
                    {
                        if (System.Math.Abs(Obj[i]) > System.Math.Abs(Max))
                        {
                            MaxO = true;
                            return MaxO;
                        }
                        else
                            MaxO = false;
                    }
                }
                return MaxO;
            }
        }
        //When Current Movment Take Supporte.QC_OK
        bool IsCurrentMoveTakeSupporte(int[,] Table, int Order, Color a, int i, int j, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate Variables.
                int[,] Tab = new int[8, 8];
                for (var ik = 0; ik < 8; ik++)
                    for (var jk = 0; jk < 8; jk++)
                        Tab[ik, jk] = Table[ik, jk];
                bool SelfSupported = false;
                int Dum = ChessRules.CurrentOrder;
                for (var RowS = 0; RowS < 8; RowS++)
                {
                    for (var ColS = 0; ColS < 8; ColS++)
                    {
                        //Ignore of Enemy Objects.
                        if (Tab[RowS, ColS] <= 0 && Order == 1)
                            continue;
                        if (Tab[RowS, ColS] >= 0 && Order == -1)
                            continue;
                        a = Color.Gray;
                        if (Order == -1)
                            a = Color.Brown;

                        //When there is Attacks.
                        if (Support(CloneATable(Tab), RowS, ColS, ii, jj, a, Order))
                            SelfSupported = true;
                    }
                }
                return SelfSupported;
            }
        }
        ///Heuristic of King safty.
        int HeuristicKingSafety(int[,] Tab, int Order, Color a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD
          )
        {

            Object ol = new Object();
            lock (ol)
            {
                int HA = 0;
                const int CastleGray = 4, CastleBrown = -4, KingGray = 6, KingBrown = -6;
                if (Order == 1)
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Tab), Order, RowS, ColS);
                    G.FindGrayKing(CloneATable(Tab), ref RowK, ref ColK);
                    if (Kind == 7)
                        HA = RationalRegard;
                    if (Tab[RowK, ColK] == KingGray && Tab[RowK, ColK] == TableInitiation[RowK, ColK] && ChessRules.CastleKingAllowedGray)
                        HA += RationalPenalty;
                    if ((Tab[RowK, ColK] == KingGray) && (Tab[RowK, 7] == CastleGray || Tab[RowK, 0] == CastleGray) && (TableInitiation[RowK, ColK] == 6) && ChessRules.CastleKingAllowedGray)
                    {
                        if (RowS == RowK && ColS == 5)
                            HA += RationalRegard;
                        if (RowS == RowK && ColS == 6)
                            HA += RationalRegard;
                        //if (RowS == RowK - 1 && ColS == 5)
                        ///if (RowS == RowK - 1 && ColS == 6)

                        if (RowS == RowK && ColS == 3)
                            HA += RationalRegard;
                        if (RowS == RowK && ColS == 2)
                            HA += RationalRegard;
                        if (RowS == RowK && ColS == 1)
                            HA += RationalRegard;
                        // if (RowS == RowK - 1 && ColS == 3)
                        //if (RowS == RowK - 1 && ColS == 2)
                        //if (RowS == Row - 1 && ColS == 1)



                    }
                }
                else
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Tab), Order, RowS, ColS);
                    G.FindBrownKing(CloneATable(Tab), ref RowK, ref ColK);
                    if (Kind == -7)
                        HA = RationalRegard;
                    if (Tab[RowK, ColK] == KingBrown && Tab[RowK, ColK] == TableInitiation[RowK, ColK] && ChessRules.CastleKingAllowedBrown)
                        HA += RationalPenalty;
                    if ((Tab[RowK, ColK] == KingBrown) && (Tab[RowK, 7] == CastleBrown || Tab[RowK, 0] == CastleBrown) && (TableInitiation[RowK, ColK] == -6) && ChessRules.CastleKingAllowedBrown)
                    {
                        if (RowS == RowK && ColS == 5)
                            HA += RationalRegard;
                        if (RowS == RowK && ColS == 6)
                            HA += RationalRegard;
                        //if (RowS == RowK + 1 && ColS == 5)
                        // if (RowS == RowK + 1 && ColS == 6)

                        if (RowS == RowK && ColS == 3)
                            HA += RationalRegard;
                        if (RowS == RowK && ColS == 2)
                            HA += RationalRegard;
                        if (RowS == RowK && ColS == 1)
                            HA += RationalRegard;
                        //if (RowS == RowK + 1 && ColS == 3)
                        // if (RowS == RowK + 1 && ColS == 2)
                        //if (RowS == RowK + 1 && ColS == 1)

                    }
                }
                return HA;
            }

        }
        int HeuristicKingPreventionOfCheckedAtBegin(int[,] Tab, int Order, Color a, int CurrentAStarGredy, int RowS, int ColS, int RowD, int ColD
            )
        {
            Object O3 = new Object();
            lock (O3)
            {
                int HA = 0;
                int[,] Tabl = CloneATable(Tab);
                if (Tabl[RowS, ColS] != 0)
                {
                    Tabl[RowD, ColD] = Tabl[RowS, ColS];
                    Tabl[RowS, ColS] = 0;
                    ChessRules A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab[RowD, ColD], CloneATable(Tab), Order, RowD, ColD);
                    var th = Task.Factory.StartNew(() => A.CheckMate(Tabl, Order));
                    th.Wait();
                    th.Dispose();

                    if (!(A.CheckMateGray || A.CheckMateBrown))
                    {
                        if (A.CheckGray || A.CheckBrown)
                        {
                            HA += RationalPenalty;
                        }
                    }
                    if (Order == 1)
                    {
                        if (A.CheckMateGray)
                            HA += RationalPenalty;
                        else
                        if (A.CheckMateBrown)
                            HA += RationalRegard;
                    }
                    else
                    {
                        if (A.CheckMateGray)
                            HA += RationalRegard;
                        else
             if (A.CheckMateBrown)
                            HA += RationalPenalty;
                    }
                }
                else
                {
                    ChessRules A = new ChessRules(CurrentAStarGredy, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab[RowD, ColD], CloneATable(Tab), Order, RowD, ColD);
                    var th = Task.Factory.StartNew(() => A.CheckMate(Tabl, Order));
                    th.Wait();
                    th.Dispose();
                    if (A.CheckGray || A.CheckBrown)
                    {
                        HA += RationalRegard;
                    }
                    if (Order == 1)
                    {
                        if (A.CheckMateGray)
                            HA += RationalPenalty;
                        else
                        if (A.CheckMateBrown)
                            HA += RationalRegard;
                    }
                    else
                    {
                        if (A.CheckMateGray)
                            HA += RationalRegard;
                        else
             if (A.CheckMateBrown)
                            HA += RationalPenalty;
                    }
                }
                return HA;
            }
        }
        int HeuristicSupported(int[,] Tab, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD
           )
        {

            Object O = new Object();
            lock (O)
            {
                int HAS = 0;
                int HAE = 0;
                ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
 {
     var th = Task.Factory.StartNew(() => HAS = HeuristicSelfSupported(CloneATable(Tab), Ord, aa, RowS, ColS, RowD, ColD));
     th.Wait();
     th.Dispose();
 }
 , () =>
 {
     var th = Task.Factory.StartNew(() => HAS = HAE = HeuristicEnemySupported(CloneATable(Tab), Ord, aa, RowS, ColS, RowD, ColD));
     th.Wait();
     th.Dispose();

 });
                return HAS + (HAE);
            }
        }
        ///Identification of Equality
        //Heuristic of Supportation.
        int HeuristicSelfSupported(int[,] Tab, int Ord, Color aa, int RowS, int ColS, int RowD, int ColD
          )
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicSelfSupportedValue = 0;
                //Initiate Local Vrariables.
                int HA = 0;
                int DumOrder = Order;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                //If There is Not AStarGreedy Heuristic Boolean Value.
                if (!AStarGreedyHeuristicT)
                {
                    //For All Self
                    {
                        {
                            //For Current Object Lcation.
                            Order = new int();
                            Order = DumOrder;
                            Color a = new Color();
                            a = aa;
                            //Ignore Current Unnessery Home.
                            if (RowS == RowD && ColS == ColD)
                                return 0;
                            //Default Is Gray One.
                            int Sign = 1;
                            Order = DummyOrder;
                            ///When Supporte is true. means [RowD,ColD] Supportes [RowS,ColS].
                            ///What is Supporte!
                            ///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
                            //if (Order == 1 && Tab[RowD, ColD] <= 0)
                            //if (Order == -1 && Tab[RowD, ColD] >= 0)
                            //if (!Scop(RowS, ColS, RowD, ColD, System.Math.Abs(Tab[RowS, ColS])))
                            if (Tab[RowD, ColD] < 0 && DummyOrder == -1 && Tab[RowS, ColS] <= 0)
                            {
                                Order = -1;
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    Sign = 1 * AllDraw.SignSupport;
                                    ChessRules.CurrentOrder = -1;
                                }
                                a = Color.Brown;
                            }
                            else if (Tab[RowD, ColD] > 0 && DummyOrder == 1 && Tab[RowS, ColS] > 0)
                            {
                                Order = 1;
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    Sign = 1 * AllDraw.SignSupport;
                                    ChessRules.CurrentOrder = 1;
                                }
                                a = Color.Gray;
                            }
                            else
                                return HeuristicSelfSupportedValue;
                            //For Support Movments.
                            bool ab = false;
                            var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowS, ColS, RowD, ColD, a, Order));
                            th.Wait();
                            th.Dispose();
                            if (ab)
                            {
                                //Calculate Local Support Heuristic.
                                HA += RationalRegard;
                                int Supported = new int();
                                int SupportedE = new int();
                                Supported = 0;
                                SupportedE = 0;
                                //For All Self Obejcts.                                             
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                for (int g = 0; g < 8; g++)
                                {
                                    //if (Supported)
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                    for (int h = 0; h < 8; h++)
                                    {
                                        Object O2 = new Object();
                                        lock (O2)
                                        {
                                            //if (Supported)
                                            //Ignore Of Enemy Objects.
                                            if (Order == 1 && Tab[g, h] == 0)
                                                continue;
                                            if (Order == -1 && Tab[g, h] == 0)
                                                continue;
                                            if (!Scop(g, h, RowS, ColS, System.Math.Abs(Tab[g, h])))
                                                continue;
                                            Color aaa = new Color();
                                            //Assgin Enemy ints.
                                            aaa = Color.Gray;
                                            aa = Color.Gray;
                                            if (Order == -1)
                                                aaa = Color.Brown;
                                            else
                                                aaa = Color.Gray;
                                            if (Order * -1 == -1)
                                                aa = Color.Brown;
                                            else
                                                aa = Color.Gray;
                                            //When Enemy is Supported.
                                            bool A = new bool();
                                            bool B = new bool();
                                            var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Tab), g, h, RowS, ColS, aaa, Order));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Tab), g, h, RowS, ColS, aa, Order * -1));
                                            th2.Wait();
                                            th2.Dispose();

                                            //When Enemy is Supported.
                                            if (A)
                                            {
                                                //Assgine variable.
                                                Supported++;

                                            }
                                            if (B)
                                            {
                                                //Assgine variable.
                                                SupportedE++;

                                            }
                                        }
                                    }
                                    // if (Supported)
                                }
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    if (Supported > 0 && SupportedE == 0)
                                        //When is Not Supported multyply 100.
                                        HA *= (int)(System.Math.Pow(2, Supported));
                                    else
                                        if (SupportedE > 0)
                                        //When is Supported Multyply -100.
                                        HA *= (int)(-1 * System.Math.Pow(2, SupportedE));
                                }
                            }
                        }
                    }
                }
                //For All Homes Table.
                else
                {
                    {
                        {
                            {
                                {
                                    Order = new int();
                                    Color a = new Color();
                                    a = aa;
                                    {
                                        //Ignore Current Home.
                                        if (RowS == RowD && ColS == ColD)
                                            return 0;
                                        //Initiate Local Variables.
                                        int Sign = 1;
                                        Order = DummyOrder;
                                        ///When Supporte is true. means [RowD,ColD] is in SelfSupported.by [RowS,ColS].
                                        ///What is Supporte!
                                        ///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
                                        //if (!Scop(RowS, ColS, RowD, ColD, System.Math.Abs(Tab[RowS, ColS])))
                                        if (Tab[RowD, ColD] < 0 && DummyOrder == -1 && Tab[RowS, ColS] <= 0)
                                        {
                                            Order = -1;
                                            Object O2 = new Object();
                                            lock (O2)
                                            {
                                                Sign = 1 * AllDraw.SignSupport;
                                                ChessRules.CurrentOrder = -1;
                                                a = Color.Brown;
                                            }
                                        }
                                        else if (Tab[RowD, ColD] > 0 && DummyOrder == 1 && Tab[RowS, ColS] > 0)
                                        {
                                            Order = 1;
                                            Object O2 = new Object();
                                            lock (O2)
                                            {
                                                Sign = 1 * AllDraw.SignSupport;
                                                ChessRules.CurrentOrder = 1;
                                                a = Color.Gray;
                                            }
                                        }
                                        else
                                            return HeuristicSelfSupportedValue;
                                        //For Support Movments.
                                        bool ab = false;
                                        var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowS, ColS, RowD, ColD, a, Order));
                                        th.Wait();
                                        th.Dispose();
                                        if (ab)
                                        {
                                            //Calculate Local Support Heuristic.
                                            HA += RationalRegard;
                                            int Supported = new int();
                                            int SupportedE = new int();
                                            Supported = 0;
                                            SupportedE = 0;
                                            //For All Self Obejcts.                                             
                                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                            for (int g = 0; g < 8; g++)
                                            {
                                                //if (Supported)
                                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                                for (int h = 0; h < 8; h++)
                                                {
                                                    Object O2 = new Object();
                                                    lock (O2)
                                                    {
                                                        //if (Supported)
                                                        //Ignore Of Enemy Objects.
                                                        if (Order == 1 && Tab[g, h] == 0)
                                                            continue;
                                                        if (Order == -1 && Tab[g, h] == 0)
                                                            continue;
                                                        if (!Scop(g, h, RowS, ColS, System.Math.Abs(Tab[g, h])))
                                                            continue;
                                                        Color aaa = new Color();
                                                        //Assgin Enemy ints.
                                                        aaa = Color.Gray;
                                                        aa = Color.Gray;
                                                        if (Order == -1)
                                                            aaa = Color.Brown;
                                                        else
                                                            aaa = Color.Gray;
                                                        if (Order * -1 == -1)
                                                            aa = Color.Brown;
                                                        else
                                                            aa = Color.Gray;
                                                        //When Enemy is Supported.
                                                        bool A = new bool();
                                                        bool B = new bool();
                                                        var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Tab), g, h, RowS, ColS, aaa, Order));
                                                        th1.Wait();
                                                        th1.Dispose();
                                                        var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Tab), g, h, RowS, ColS, aa, Order * -1));
                                                        th2.Wait();
                                                        th2.Dispose();
                                                        //When Enemy is Supported.
                                                        if (A)
                                                        {
                                                            //Assgine variable.
                                                            Supported++;

                                                        }
                                                        if (B)
                                                        {
                                                            //Assgine variable.
                                                            SupportedE++;

                                                        }
                                                    }
                                                }
                                                // if (Supported)
                                            }
                                            Object O1 = new Object();
                                            lock (O1)
                                            {
                                                if (Supported > 0 && SupportedE == 0)
                                                    //When is Not Supported multyply 100.
                                                    HA *= (int)(System.Math.Pow(2, Supported));
                                                else
                                                  if (SupportedE > 0)
                                                    //When is Supported Multyply -100.
                                                    HA *= (int)(-1 * System.Math.Pow(2, SupportedE));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Reassignments of Global Orders with Local Begining One.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                Order = DumOrder;
                return HA * 1;
            }
        }        ///Identification of Equality
        //Heuristic of Supportation.
        int HeuristicEnemySupported(int[,] Tab, int Ord, Color aa, int RowD, int ColD, int RowS, int ColS
          )
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicSelfSupportedValue = 0;
                //Initiate Local Vrariables.
                int HA = 0;
                int DumOrder = Order;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                //If There is Not AStarGreedy Heuristic Boolean Value.
                if (!AStarGreedyHeuristicT)
                {
                    //For All Self
                    {
                        {
                            //For Current Object Lcation.
                            Order = new int();
                            Order = DumOrder;
                            Color a = new Color();
                            a = aa;
                            //Ignore Current Unnessery Home.
                            if (RowS == RowD && ColS == ColD)
                                return 0;
                            //Default Is Gray One.
                            int Sign = 1;
                            Order = DummyOrder;
                            ///When Supporte is true. means [RowD,ColD] Supportes [RowS,ColS].
                            ///What is Supporte!
                            ///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
                            //if (Order == 1 && Tab[RowD, ColD] <= 0)
                            //if (Order == -1 && Tab[RowD, ColD] >= 0)
                            //if (!Scop(RowS, ColS, RowD, ColD, System.Math.Abs(Tab[RowS, ColS])))
                            if (Tab[RowD, ColD] < 0 && DummyOrder == -1 && Tab[RowS, ColS] <= 0)
                            {
                                Order = -1;
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    Sign = 1 * AllDraw.SignSupport;
                                    ChessRules.CurrentOrder = -1;
                                }
                                a = Color.Brown;
                            }
                            else if (Tab[RowD, ColD] > 0 && DummyOrder == 1 && Tab[RowS, ColS] > 0)
                            {
                                Order = 1;
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    Sign = 1 * AllDraw.SignSupport;
                                    ChessRules.CurrentOrder = 1;
                                }
                                a = Color.Gray;
                            }
                            else
                                return HeuristicSelfSupportedValue;
                            //For Support Movments.
                            bool ab = false;
                            var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowS, ColS, RowD, ColD, a, Order));
                            th.Wait();
                            th.Dispose();
                            if (ab)
                            {

                                //Calculate Local Support Heuristic.
                                HA += RationalPenalty;
                                int Supported = new int();
                                int SupportedE = new int();
                                Supported = 0;
                                SupportedE = 0;
                                //For All Self Obejcts.                                             
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                for (int g = 0; g < 8; g++)
                                {
                                    //if (Supported)
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                    for (int h = 0; h < 8; h++)
                                    {
                                        Object O2 = new Object();
                                        lock (O2)
                                        {
                                            //if (Supported)
                                            //Ignore Of Enemy Objects.
                                            if (Order == 1 && Tab[g, h] == 0)
                                                continue;
                                            if (Order == -1 && Tab[g, h] == 0)
                                                continue;
                                            if (!Scop(g, h, RowS, ColS, System.Math.Abs(Tab[g, h])))
                                                continue;
                                            Color aaa = new Color();
                                            //Assgin Enemy ints.
                                            aaa = Color.Gray;
                                            aa = Color.Gray;
                                            if (Order == -1)
                                                aaa = Color.Brown;
                                            else
                                                aaa = Color.Gray;
                                            if (Order * -1 == -1)
                                                aa = Color.Brown;
                                            else
                                                aa = Color.Gray;
                                            //When Enemy is Supported.
                                            bool A = new bool();
                                            bool B = new bool();
                                            var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Tab), g, h, RowS, ColS, aaa, Order));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Tab), g, h, RowS, ColS, aa, Order * -1));
                                            th2.Wait();
                                            th2.Dispose();
                                            //When Enemy is Supported.
                                            if (A)
                                            {
                                                //Assgine variable.
                                                Supported++;

                                            }
                                            if (B)
                                            {
                                                //Assgine variable.
                                                SupportedE++;

                                            }
                                        }
                                    }
                                    // if (Supported)
                                }
                                Object O1 = new Object();
                                lock (O1)
                                {
                                    if (SupportedE > 0 && Supported == 0)
                                        //When is Not Supported multyply 100.
                                        HA *= (int)System.Math.Pow(2, SupportedE);
                                    else
                                       if (Supported > 0)
                                        //When is Supported Multyply -100.
                                        HA *= (int)(-1 * System.Math.Pow(2, Supported));
                                }
                            }
                        }
                    }
                }
                //For All Homes Table.
                else
                {
                    {
                        {
                            {
                                {
                                    Order = new int();
                                    Color a = new Color();
                                    a = aa;
                                    {
                                        //Ignore Current Home.
                                        if (RowS == RowD && ColS == ColD)
                                            return 0;
                                        //Initiate Local Variables.
                                        int Sign = 1;
                                        Order = DummyOrder;
                                        ///When Supporte is true. means [RowD,ColD] is in SelfSupported.by [RowS,ColS].
                                        ///What is Supporte!
                                        ///Ans:When [RowS,ColS] is Supporte [RowD,ColD] return true when Self is located in [RowD,ColD].
                                        //if (!Scop(RowS, ColS, RowD, ColD, System.Math.Abs(Tab[RowS, ColS])))
                                        if (Tab[RowD, ColD] < 0 && DummyOrder == -1 && Tab[RowS, ColS] <= 0)
                                        {
                                            Order = -1;
                                            Object O2 = new Object();
                                            lock (O2)
                                            {
                                                Sign = 1 * AllDraw.SignSupport;
                                                ChessRules.CurrentOrder = -1;
                                                a = Color.Brown;
                                            }
                                        }
                                        else if (Tab[RowD, ColD] > 0 && DummyOrder == 1 && Tab[RowS, ColS] > 0)
                                        {
                                            Order = 1;
                                            Object O2 = new Object();
                                            lock (O2)
                                            {
                                                Sign = 1 * AllDraw.SignSupport;
                                                ChessRules.CurrentOrder = 1;
                                                a = Color.Gray;
                                            }
                                        }
                                        else
                                            return HeuristicSelfSupportedValue;
                                        //For Support Movments.
                                        bool ab = false;
                                        var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), RowS, ColS, RowD, ColD, a, Order));
                                        th.Wait();
                                        th.Dispose();
                                        if (ab)
                                        {

                                            //Calculate Local Support Heuristic.
                                            HA += RationalPenalty;
                                            int Supported = new int();
                                            int SupportedE = new int();
                                            Supported = 0;
                                            SupportedE = 0;
                                            //For All Self Obejcts.                                             
                                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                                            for (int g = 0; g < 8; g++)
                                            {
                                                //if (Supported)
                                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                                for (int h = 0; h < 8; h++)
                                                {
                                                    Object O2 = new Object();
                                                    lock (O2)
                                                    {
                                                        //if (Supported)
                                                        //Ignore Of Enemy Objects.
                                                        if (Order == 1 && Tab[g, h] == 0)
                                                            continue;
                                                        if (Order == -1 && Tab[g, h] == 0)
                                                            continue;
                                                        if (!Scop(g, h, RowS, ColS, System.Math.Abs(Tab[g, h])))
                                                            continue;
                                                        Color aaa = new Color();
                                                        //Assgin Enemy ints.
                                                        aaa = Color.Gray;
                                                        aa = Color.Gray;
                                                        if (Order == -1)
                                                            aaa = Color.Brown;
                                                        else
                                                            aaa = Color.Gray;
                                                        if (Order * -1 == -1)
                                                            aa = Color.Brown;
                                                        else
                                                            aa = Color.Gray;
                                                        //When Enemy is Supported.
                                                        bool A = new bool();
                                                        bool B = new bool();
                                                        var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Tab), g, h, RowS, ColS, aaa, Order));
                                                        th1.Wait();
                                                        th1.Dispose();
                                                        var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Tab), g, h, RowS, ColS, aa, Order * -1));
                                                        th2.Wait();
                                                        th2.Dispose();
                                                        //When Enemy is Supported.
                                                        if (A)
                                                        {
                                                            //Assgine variable.
                                                            Supported++;

                                                        }
                                                        if (B)
                                                        {
                                                            //Assgine variable.
                                                            SupportedE++;

                                                        }
                                                    }
                                                }
                                                // if (Supported)
                                            }
                                            Object O1 = new Object();
                                            lock (O1)
                                            {
                                                if (SupportedE > 0 && Supported == 0)
                                                    //When is Not Supported multyply 100.
                                                    HA *= (int)System.Math.Pow(2, SupportedE);
                                                else
                                                      if (Supported > 0)
                                                    //When is Supported Multyply -100.
                                                    HA *= (int)(-1 * System.Math.Pow(2, Supported));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Reassignments of Global Orders with Local Begining One.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                Order = DumOrder;
                return HA * 1;
            }
        }        ///Identification of Equality
        public static bool TableEqual(int[,] Tab1, int[,] Tab2)
        {
            Object O = new Object();
            lock (O)
            {
                //For All Home
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        //When there is different values in same location of tow Table return non equality.
                        if (Tab1[i, j] != Tab2[i, j])
                        {
                            return false;
                        }
                    }
                //Else return equlity.
                return true;
            }
        }
        //If tow int Objects is equal.
        public static bool TableEqual(int Tab1, int Tab2)
        {
            Object O = new Object();
            lock (O)
            {
                //When there is different values in same location of tow Table return non equality.
                if (Tab1 != Tab2)
                {
                    return false;
                }
                //Else return equlity.
                return true;
            }
        }
        //Deterimination of Existance of Table in List..
        static public bool ExistTableInList(int[,] Tab, List<int[,]> List, int Index)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate Local Variables.
                bool Exist = false;
                //For All Tables of Table List.
                for (var i = Index; i < List.Count; i++)
                {
                    //Strore Equality Value.
                    bool Eq = TableEqual(Tab, List[i]);
                    //When is Equality is Occurred.
                    if (Eq)
                    {
                        //Store Equality Local Value in a Global static value.
                        AllDraw.LoopHeuristicIndex = i;
                        return Eq;
                    }
                    Exist |= Eq;
                }
                //return Equality Local value of all lists.
                return Exist;
            }
        }
        ///Move Determination.
        public bool Movable(int[,] Tab, int i, int j, int ii, int jj, Color a, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                if (Tab[i, j] == 0)
                    return false;
                if (Order == 1 && Tab[i, j] < 0)
                    return false;
                if (Order == -1 && Tab[i, j] > 0)
                    return false;
                int[,] Table = new int[8, 8];
                for (int p = 0; p < 8; p++)
                    for (int k = 0; k < 8; k++)
                        Table[p, k] = Tab[p, k];
                //Initiate Local Variables.
                int Store = Table[ii, jj];
                ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[i, j], CloneATable(Table), Order, i, j);
                //Menen Parameter is Moveble to Second Parameters Location returm Movable.
                if (Order == 1 && Table[ii, jj] < 0)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = A.Rules(i, j, ii, jj, a, Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        return true;
                    }
                }
                else
                 if (Order == -1 && Table[ii, jj] > 0)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = A.Rules(i, j, ii, jj, a, Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        return true;
                    }
                }
                if (Order == 1 && Table[ii, jj] == 0)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = A.Rules(i, j, ii, jj, a, Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        return true;
                    }
                }
                else
                if (Order == -1 && Table[ii, jj] == 0)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = A.Rules(i, j, ii, jj, a, Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        //
        //When Oredrs of OrderPalte and Calculation Order is not equal return negative one and else return one.
        int SignOrderToPlate(int Order)
        {
            Object O = new Object();
            lock (O)
            {
                int Sign = 1;
                //When Current Order Sign Positive.
                if (Order == AllDraw.OrderPlateDraw)
                    Sign = 1;
                else
                    //When Order is Opposite Sign Negative.
                    if (Order != AllDraw.OrderPlateDraw)
                    Sign = -1;
                return Sign;
            }
        }
        //Remove Penalties of Unnesserily Nodes.
        public bool RemovePenalty(int[,] Tab, int Order, int i, int j)
        {
            Object O = new Object();
            lock (O)
            {
                bool Remove = false;
                //Create Objects.
                ChessRules AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab[i, j], CloneATable(Tab), Order, i, j);
                //When is Check.
                if (AA.Check(CloneATable(Tab), Order))
                {
                    //When there is Current Checked or Objects Danger return false.
                    if (Order == 1 && (AA.CheckGray || AA.CheckGrayObjectDangour))
                    {
                        return Remove;
                    }
                    if (Order == -1 && (AA.CheckBrown || AA.CheckBrownObjectDangour))
                    {
                        return Remove;
                    }
                }

                //For Enemy.
                for (var ii = 0; ii < 8; ii++)
                    for (var jj = 0; jj < 8; jj++)
                    {
                        if (Order == 1 && Tab[ii, jj] >= 0)
                            continue;
                        if (Order == -1 && Tab[ii, jj] <= 0)
                            continue;
                        //Clone a Copy.
                        int[,] Table = new int[8, 8];
                        //Clone a Table.
                        for (var RowS = 0; RowS < 8; RowS++)
                            for (var ColS = 0; ColS < 8; ColS++)
                                Table[RowS, ColS] = Tab[RowS, ColS];
                        ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[ii, jj], CloneATable(Table), Order * -1, ii, jj);
                        Color a = Color.Gray;
                        if (Order * -1 == -1)
                            a = Color.Brown;
                        //When there is movment to current OPbject.
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = A.Rules(ii, jj, i, j, a, Table[ii, jj]));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {
                            //Number of Attacks and take move.
                            int Count = 0;
                            var th1 = Task.Factory.StartNew(() => Count = AttackerCount(CloneATable(Table), Order * -1, a, ii, jj));
                            th1.Wait();
                            th1.Dispose();
                            //When there is Object Danger.
                            //Clone a Copy.
                            for (var RowS = 0; RowS < 8; RowS++)
                                for (var ColS = 0; ColS < 8; ColS++)
                                    Table[RowS, ColS] = Tab[RowS, ColS];
                            //Create new ThinkingRefrigtzChessPortable Rule Object.
                            A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[ii, jj], CloneATable(Table), Order, ii, jj);
                            //Detect int.
                            a = Color.Gray;
                            if (Order == -1)
                                a = Color.Brown;
                            //When Current Movments Attacks Enemy.
                            var th2 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), i, j, ii, jj, a, Order));
                            th2.Wait();
                            th2.Dispose();
                            if (ab)
                            {

                                //For Current Home.
                                for (var RowS = 0; RowS < 8; RowS++)
                                    for (var ColS = 0; ColS < 8; ColS++)
                                    {
                                        //Ignore of Enemy.
                                        if (Order == 1 && Tab[RowS, ColS] <= 0)
                                            continue;
                                        if (Order == -1 && Tab[RowS, ColS] >= 0)
                                            continue;
                                        //Whn Value Of Current is Less That Enemy.
                                        var th3 = Task.Factory.StartNew(() => ab = ObjectValueCalculator(CloneATable(Table), i, j) < ObjectValueCalculator(CloneATable(Table), ii, jj));
                                        th3.Wait();
                                        th3.Dispose();
                                        if (ab)
                                        {
                                            //Take Move.
                                            Table[ii, jj] = Table[i, j];
                                            Table[i, j] = 0;
                                            a = Color.Gray;
                                            if (Order * -1 == -1)
                                                a = Color.Brown;
                                            //When Enemy Attacks Current Moved.
                                            var th4 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowS, ColS, ii, jj, a, Order * -1));
                                            th4.Wait();
                                            th4.Dispose();
                                            if (ab)
                                            {

                                                //For Current Order.
                                                for (int RowD = 0; RowD < 8; RowD++)
                                                    for (int ColD = 0; ColD < 8; ColD++)
                                                    {
                                                        //Ignore of Enemy.
                                                        if (Order == 1 && Tab[RowD, ColD] <= 0)
                                                            continue;
                                                        if (Order == -1 && Tab[RowD, ColD] >= 0)
                                                            continue;
                                                        a = Color.Gray;
                                                        if (Order == -1)
                                                            a = Color.Brown;
                                                        //When Self Supported Current
                                                        var th5 = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), RowD, ColD, i, j, a, Order));
                                                        th5.Wait();
                                                        th5.Dispose();
                                                        if (ab)
                                                        {

                                                            //If V alue of Enemy is Greater Than Current and Value of Enemy is Greater than Supporter.
                                                            var th6 = Task.Factory.StartNew(() => ab = ObjectValueCalculator(CloneATable(Table), RowS, ColS) < ObjectValueCalculator(CloneATable(Table), ii, jj) && ObjectValueCalculator(CloneATable(Table), RowS, ColS) > ObjectValueCalculator(CloneATable(Table), Row, ColS));
                                                            th6.Wait();
                                                            th6.Dispose();
                                                            if (ab)
                                                            {
                                                                Remove = true;
                                                                return Remove;
                                                            }
                                                            else
                                                            {
                                                                return Remove;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            return Remove;
                                                        }
                                                    }
                                            }
                                            else
                                            {
                                                return Remove;
                                            }
                                        }
                                        else
                                        {
                                            return Remove;
                                        }
                                    }
                            }
                        }
                    }
                return Remove;
            }
        }
        //Dangouring of current movment fo current Order.
        bool IsCurrentStateIsDangreousForCurrentOrder(int[,] Tabl, int Order, Color a, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                //Initiate Object.
                ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, 1, CloneATable(Tabl), 1, Row, Column);
                //Gray Order.
                if (Order == 1)
                {
                    //Find location of Gray King.
                    int RowG = -1, ColumnG = -1;
                    A.FindGrayKing(Tabl, ref RowG, ref ColumnG);
                    //When found.
                    if (RowG != -1 && ColumnG != -1)
                    {
                        //For Brown
                        for (var i = 0; i < 8; i++)
                            for (var j = 0; j < 8; j++)
                            {
                                //Ignore of Gray and Empty
                                if (Tabl[i, j] >= 0)
                                    continue;
                                if (i != ii && j != jj)
                                {
                                    //Create new Objects of Table
                                    int[,] TablCon = new int[8, 8];
                                    for (var RowS = 0; RowS < 8; RowS++)
                                        for (var ColS = 0; ColS < 8; ColS++)
                                            TablCon[RowS, ColS] = Tabl[RowS, ColS];
                                    //For Enemy Order.
                                    if (TablCon[i, j] < 0)
                                    {
                                        //For Gray and Empty Objects.
                                        if (TablCon[ii, jj] >= 0)
                                        {
                                            //Setting Enemy Order.
                                            int DummyOrder = Order;
                                            int DummyCurrentOrder = ChessRules.CurrentOrder;
                                            A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TablCon[i, j], TablCon, -1, i, j);
                                            //When Enemy is Attacked Gray Objects.
                                            bool ab = false;
                                            var th = Task.Factory.StartNew(() => ab = A.Rules(i, j, ii, jj, Color.Brown, TablCon[i, j]));
                                            th.Wait();
                                            th.Dispose();
                                            if (ab)
                                            {

                                                //Take Movments.
                                                TablCon[ii, jj] = TablCon[i, j];
                                                TablCon[i, j] = 0;
                                                //Settting Current Order.
                                                ChessRules.CurrentOrder = 1;
                                                //Settting Object.
                                                A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TablCon[ii, jj], TablCon, 1, ii, jj);
                                                //When Occured Check.
                                                var th1 = Task.Factory.StartNew(() => ab = A.Check(TablCon, 1));
                                                th1.Wait();
                                                th1.Dispose();
                                                if (ab)
                                                {

                                                    //When Gray is Check.
                                                    if (A.CheckGray)
                                                    {
                                                        //For Enemy Order Objects.
                                                        for (int RowD = 0; RowD < 8; RowD++)
                                                            for (int ColD = 0; ColD < 8; ColD++)
                                                            {
                                                                //When is not Conflict.
                                                                if (RowD != i && ColD != j && RowD != ii && ColD != jj)
                                                                {
                                                                    //Setting Enemy.
                                                                    ChessRules.CurrentOrder = -1;
                                                                    //When Enemy is Supported 
                                                                    var th2 = Task.Factory.StartNew(() => ab = Support(TablCon, RowD, ColD, i, j, Color.Brown, -1));
                                                                    th2.Wait();
                                                                    th2.Dispose();
                                                                    if (ab)
                                                                    {
                                                                        //restore and return true.
                                                                        Order = DummyOrder;
                                                                        ChessRules.CurrentOrder = DummyCurrentOrder;
                                                                        return true;
                                                                    }
                                                                }
                                                            }
                                                    }
                                                    Order = DummyOrder;
                                                    ChessRules.CurrentOrder = DummyCurrentOrder;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                    }
                }
                //For Brown Order.
                else if (Order == -1)
                {
                    //Found of Brown King.
                    int RowB = -1, ColumnB = -1;
                    A.FindBrownKing(Tabl, ref RowB, ref ColumnB);
                    //When found.
                    if (RowB != -1 && ColumnB != -1)
                    {
                        //For Gray.
                        for (var i = 0; i < 8; i++)
                            for (var j = 0; j < 8; j++)
                            {
                                if (Tabl[i, j] <= 0)
                                    continue;
                                if (i != ii && j != jj)
                                {
                                    //Create new Objects of Table
                                    int[,] TablCon = new int[8, 8];
                                    for (var RowS = 0; RowS < 8; RowS++)
                                        for (var ColS = 0; ColS < 8; ColS++)
                                            TablCon[RowS, ColS] = Tabl[RowS, ColS];
                                    //For Enemy Objects.
                                    if (TablCon[i, j] > 0)
                                    {
                                        //For Self Objects and Empty.
                                        if (TablCon[ii, jj] <= 0)
                                        {
                                            //Store and Enemy Order.
                                            int DummyOrder = Order;
                                            int DummyCurrentOrder = ChessRules.CurrentOrder;
                                            A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TablCon[i, j], TablCon, 1, i, j);
                                            ChessRules.CurrentOrder = 1;
                                            //When Enemy Attacked Self Objects.
                                            bool ab = false;
                                            var th = Task.Factory.StartNew(() => ab = A.Rules(i, j, ii, jj, Color.Gray, TablCon[i, j]));
                                            th.Wait();
                                            th.Dispose();
                                            if (ab)
                                            {
                                                //Take movemnts.
                                                TablCon[ii, jj] = TablCon[i, j];
                                                TablCon[i, j] = 0;
                                                //Setting current Order.
                                                ChessRules.CurrentOrder = -1;
                                                A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TablCon[ii, jj], TablCon, -1, ii, jj);
                                                //When Check Occured.
                                                var th1 = Task.Factory.StartNew(() => ab = A.Check(TablCon, -1));
                                                th1.Wait();
                                                th1.Dispose();
                                                if (ab)
                                                {
                                                    //When Current is Check.
                                                    if (A.CheckBrown)
                                                    {
                                                        //For Enemy Objecvts.
                                                        for (int RowD = 0; RowD < 8; RowD++)
                                                            for (int ColD = 0; ColD < 8; ColD++)
                                                            {
                                                                //Ignore of Conflit.
                                                                if (RowD != i && ColD != j && RowD != ii && ColD != jj)
                                                                {
                                                                    //Setting Enemy Order
                                                                    ChessRules.CurrentOrder = 1;
                                                                    //When Enemy is Supported.
                                                                    var th2 = Task.Factory.StartNew(() => ab = Support(TablCon, RowD, ColD, i, j, Color.Gray, 1));
                                                                    th2.Wait();
                                                                    th2.Dispose();
                                                                    if (ab)
                                                                    {
                                                                        //restore and return true.
                                                                        Order = DummyOrder;
                                                                        ChessRules.CurrentOrder = DummyCurrentOrder;
                                                                        return true;
                                                                    }
                                                                }
                                                            }
                                                    }
                                                    //restore.
                                                    Order = DummyOrder;
                                                    ChessRules.CurrentOrder = DummyCurrentOrder;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                    }
                }
                //return false.
                return false;
            }
        }
        //When Next Movements is Checked.QC_OK.
        int[] IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(int Order, int[,] Tabl, int ik, int jk, int iki, int jki, int OrderPalte, int OrderPalteMulMinuse, int Depth, bool KindCheckedSelf)
        {
            Object O = new Object();
            lock (O)
            {
                int[] Is = new int[4];
                Object O3 = new Object();
                lock (O3)
                {
                    Is[0] = 0;
                    Is[1] = 0;
                    Is[2] = 0;
                    Is[3] = 0;
                    int[,] Tab2 = CloneATable(Tabl);
                    ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab2[ik, jk], Tab2, Order * -1, ik, jk);
                    if (Order * -1 == 1)
                        color = Color.Gray;
                    else
                        color = Color.Brown;
                    //When Enemy Attack Currnet.
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = A.Rules(ik, jk, iki, jki, color, Tab2[ik, jk]));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        Tab2[iki, jki] = Tab2[ik, jk];
                        Tab2[ik, jk] = 0;
                        A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab2[iki, jki], Tab2, Order * -1, iki, jki);
                        //When Current Always is in CheckedMate.
                        var th1 = Task.Factory.StartNew(() => ab = A.CheckMate(Tab2, Order * -1));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {
                            //When Order is Gray.
                            if (OrderPalte == 1)
                            {
                                if (A.CheckMateGray)
                                {
                                    Is[0] = 1;
                                    if (KindCheckedSelf)
                                        Is[1] = Depth;
                                }
                                else
                                {
                                    //if (A.CheckMateBrown)
                                }
                            }
                            //When Order is Brown.
                            else
                               if (OrderPalte == -1)
                            {
                                if (A.CheckMateBrown)
                                {
                                    Is[0] = 1;
                                    Is[1] = Depth;
                                }
                                else
                                {
                                    //if (A.CheckMateGray)
                                }
                            }

                            //When Order * -1 is Gray
                            if (OrderPalteMulMinuse == 1)
                            {
                                if (A.CheckMateGray)
                                {
                                    Is[2] = 1;
                                    Is[3] = Depth;
                                }
                                else
                                {
                                    //if (A.CheckMateBrown)
                                }
                            }
                            //When Order * -1 is Brown
                            else
                               if (OrderPalteMulMinuse == -1)
                            {
                                if (A.CheckMateBrown)
                                {
                                    Is[2] = 1;
                                    Is[3] = Depth;
                                }
                                else
                                {
                                    //if (A.CheckMateGray)
                                }
                            }

                        }
                        if (Order * -1 == 1)
                            color = Color.Gray;
                        else
                            color = Color.Brown;
                        //if (Tab2[iki, jki] == 0)
                        //For Movements.
                        int Ord = Order * -1;
                        int[,] Tab = CloneATable(Tab2);
                        Color a = color;
                        if (Ord == 1)
                            a = Color.Gray;
                        else
                            a = Color.Brown;
                        int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMulMinuse, Depth1 = Depth + 1;
                        bool KindCheckedSelf1 = KindCheckedSelf;
                        Object O1 = new Object();
                        int[] IS = null;
                        lock (O1)
                        {
                            var th2 = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovment(CloneATable(Tab), Ord, a, Depth1, OrderP, OrderM, KindCheckedSelf1));
                            th2.Wait();
                            th2.Dispose();

                        }
                        if (Is[0] == 1) Is[0] = 1;
                        if (IS[2] == 1) Is[2] = 1;
                        Is[1] = Is[1];
                        Is[3] = IS[3];
                    }
                }
                return Is;
            }
        }
        //When Next Movements is Checked.QC_OK.
        bool IsNextMovmentIsCheckOrCheckMateForCurrentMovmentOnCurrentMovemnet(int Order, int[,] Tabl, int ik, int jk, int iki, int jki, int OrderPalte)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                int[,] Tab2 = new int[8, 8];
                for (int ki = 0; ki < 8; ki++)
                    for (int kj = 0; kj < 8; kj++)
                        Tab2[ki, kj] = Tabl[ki, kj];
                ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab2[ik, jk], Tab2, Order - 1, ik, jk);
                //When Enemy Attack Currnet.
                A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Tab2[iki, jki], Tab2, OrderPalte, iki, jki);
                //When Current Always is in CheckedMate.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = A.CheckMate(Tab2, OrderPalte));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    //When for penalty.
                    if (OrderPalte == AllDraw.OrderPlate)
                    {
                        //When Order is Gray.
                        if (OrderPalte == 1)
                        {
                            if (A.CheckMateGray)
                                Is = true;
                            else
                            {
                                if (A.CheckMateBrown)
                                {
                                    return Is;
                                }
                            }
                        }
                        //When Order is Brown.
                        else
                           if (OrderPalte == -1)
                        {
                            if (A.CheckMateBrown)
                                Is = true;
                            else
                            {
                                if (A.CheckMateGray)
                                {
                                    return Is;
                                }
                            }
                        }
                    }
                    //When for regard.
                    else
                    {
                        //When Order * -1 is Gray
                        if (OrderPalte == 1)
                        {
                            if (A.CheckMateGray)
                                Is = true;
                            else
                            {
                                if (A.CheckMateBrown)
                                {
                                    return Is;
                                }
                            }
                        }
                        //When Order * -1 is Brown
                        else
                           if (OrderPalte == -1)
                        {
                            if (A.CheckMateBrown)
                                Is = true;
                            else
                            {
                                if (A.CheckMateGray)
                                {
                                    return Is;
                                }
                            }
                        }
                    }
                }
                return Is;
            }
        }
        int[] IsNextMovmentIsCheckOrCheckMateForCurrentMovment(int[,] Tabl, int Order, Color a, int Depth, int OrderPalte, int OrderPalteMinusPluse, bool KindCheckedSelf)
        {
            Object O = new Object();
            lock (O)
            {
                int[] Is = new int[4];
                Object O3 = new Object();
                lock (O3)
                {
                    Is[0] = 0;
                    Is[1] = 0;
                    Is[2] = 0;
                    Is[3] = 0;
                    int DummyOrder = Order;
                    int DummyCurrentOrder = ChessRules.CurrentOrder;
                    if (Depth >= AllDraw.MaxAStarGreedy)
                    {
                        return Is;
                    }
                    //For All Enemies.
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ik =>
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, jk =>
                        {
                            //Ignore of Current
                            if (Order == 1 && Tabl[ik, jk] >= 0)
                                continue;
                            if (Order == -1 && Tabl[ik, jk] <= 0)
                                continue;
                            switch (System.Math.Abs(Tabl[ik, jk]))
                            {
                                case 1:
                                    //For Current Home
                                    for (var iki = ik - 2; iki < ik + 3; iki++)
                                        for (var jki = jk - 2; jki < jk + 3; jki++)
                                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(ik - 2, ik + 3, iki =>
                                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(jk - 2, jk + 3, jki =>
                                        // init subtotal
                                        {
                                            if (!Scop(ik, jk, iki, jki, 1))
                                                continue;
                                            //Ignore of Enemy
                                            if (Order == 1 && Tabl[iki, jki] < 0)
                                                continue;
                                            if (Order == -1 && Tabl[iki, jki] > 0)
                                                continue;
                                            if (Is[0] == 1)
                                                continue;
                                            int Ord = Order;
                                            int[,] Tab = CloneATable(Tabl);
                                            int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                            bool KindCheckedSelf1 = KindCheckedSelf;
                                            int[] IS = null;
                                            Object O1 = new Object();
                                            lock (O1)
                                            {
                                                var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                                th.Wait();
                                                th.Dispose();
                                                if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                                Is[1] = Is[1]; Is[3] = IS[3];
                                            }
                                        }
                                    break;
                                case 2:

                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, iki =>
                                    for (var iki = 0; iki < 8; iki++)
                                    {
                                        var jki = iki + jk - ik;
                                        if (!Scop(ik, jk, iki, jki, 2))
                                            continue;
                                        //Ignore of Enemy
                                        if (Order == 1 && Tabl[iki, jki] < 0)
                                            continue;
                                        if (Order == -1 && Tabl[iki, jki] > 0)
                                            continue;
                                        if (Is[0] == 1)
                                            continue;
                                        int Ord = Order;
                                        int[,] Tab = CloneATable(Tabl);
                                        int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                        bool KindCheckedSelf1 = KindCheckedSelf;
                                        int[] IS = null;
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                            th.Wait();
                                            th.Dispose();
                                            if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                            Is[1] = Is[1]; Is[3] = IS[3];
                                        }
                                    }
                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, iki =>
                                    for (var iki = 0; iki < 8; iki++)
                                    {
                                        var jki = iki * -1 + jk + ik;
                                        if (!Scop(ik, jk, iki, jki, 2))
                                            continue;
                                        //Ignore of Enemy
                                        if (Order == 1 && Tabl[iki, jki] < 0)
                                            continue;
                                        if (Order == -1 && Tabl[iki, jki] > 0)
                                            continue;
                                        if (Is[0] == 1)
                                            continue;
                                        int Ord = Order;
                                        int[,] Tab = CloneATable(Tabl);
                                        int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                        bool KindCheckedSelf1 = KindCheckedSelf;
                                        int[] IS = null;
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                            th.Wait();
                                            th.Dispose();
                                            if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                            Is[1] = Is[1]; Is[3] = IS[3];
                                        }
                                    }
                                    break;
                                case 3:
                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(ik - 2, ik + 3, iki =>
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(jk - 2, jk + 3, jki =>
                                    for (var iki = ik - 2; iki < ik + 3; iki++)
                                        for (var jki = jk - 2; jki < jk + 3; jki++)
                                        {
                                            if (!Scop(ik, jk, iki, jki, 3))
                                                continue;
                                            //Ignore of Enemy
                                            if (Order == 1 && Tabl[iki, jki] < 0)
                                                continue;
                                            if (Order == -1 && Tabl[iki, jki] > 0)
                                                continue;
                                            int Ord = Order;
                                            int[,] Tab = CloneATable(Tabl);
                                            int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                            bool KindCheckedSelf1 = KindCheckedSelf;
                                            int[] IS = null;
                                            Object O1 = new Object();
                                            lock (O1)
                                            {
                                                var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                                th.Wait();
                                                th.Dispose();

                                                if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                                Is[1] = Is[1]; Is[3] = IS[3];
                                            }
                                        }
                                    break;
                                case 4:
                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, iki =>
                                    for (var iki = 0; iki < 8; iki++)
                                    {
                                        var jki = jk;
                                        if (!Scop(ik, jk, iki, jki, 4))
                                            continue;
                                        //Ignore of Enemy
                                        if (Order == 1 && Tabl[iki, jki] < 0)
                                            continue;
                                        if (Order == -1 && Tabl[iki, jki] > 0)
                                            continue;
                                        if (Is[0] == 1)
                                            continue;
                                        int Ord = Order;
                                        int[,] Tab = CloneATable(Tabl);
                                        int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                        bool KindCheckedSelf1 = KindCheckedSelf;
                                        int[] IS = null;
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                            th.Wait();
                                            th.Dispose();
                                            if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                            Is[1] = Is[1]; Is[3] = IS[3];
                                        }
                                    }
                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, jki =>
                                    for (var jki = 0; jki < 8; jki++)
                                    {
                                        var iki = ik;
                                        if (!Scop(ik, jk, iki, jki, 4))
                                            continue;
                                        //Ignore of Enemy
                                        if (Order == 1 && Tabl[iki, jki] < 0)
                                            continue;
                                        if (Order == -1 && Tabl[iki, jki] > 0)
                                            continue;
                                        if (Is[0] == 1)
                                            continue;
                                        int Ord = Order;
                                        int[,] Tab = CloneATable(Tabl);
                                        int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                        bool KindCheckedSelf1 = KindCheckedSelf;
                                        int[] IS = null;
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                            th.Wait();
                                            th.Dispose();

                                            if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                            Is[1] = Is[1]; Is[3] = IS[3];
                                        }
                                    }
                                    break;
                                case 5:

                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, iki =>
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, jki =>
                                    for (var iki = 0; iki < 8; iki++)
                                        for (var jki = 0; jki < 8; jki++)
                                        {
                                            //Ignore of Enemy
                                            if (Order == 1 && Tabl[iki, jki] < 0)
                                                continue;
                                            if (Order == -1 && Tabl[iki, jki] > 0)
                                                continue;
                                            if (!Scop(ik, jk, iki, jki, 5))
                                                continue;
                                            if (Is[0] == 1)
                                                continue;
                                            int Ord = Order;
                                            int[,] Tab = CloneATable(Tabl);
                                            int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                            bool KindCheckedSelf1 = KindCheckedSelf;
                                            int[] IS = null;
                                            Object O1 = new Object();
                                            lock (O1)
                                            {
                                                var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                                th.Wait();
                                                th.Dispose();

                                                if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                                Is[1] = Is[1]; Is[3] = IS[3];
                                            }
                                        }
                                    break;
                                case 6:
                                    //For Current Home
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(ik - 1, ik + 2, iki =>
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(jk - 1, jk + 2, jki =>
                                    for (var iki = ik - 1; iki < ik + 2; iki++)
                                        for (var jki = jk - 1; jki < jk + 2; jki++)
                                        {
                                            if (!Scop(ik, jk, iki, jki, 6))
                                                continue;
                                            //Ignore of Enemy
                                            if (Order == 1 && Tabl[iki, jki] < 0)
                                                continue;
                                            if (Order == -1 && Tabl[iki, jki] > 0)
                                                continue;
                                            if (Is[0] == 1)
                                                continue;
                                            int Ord = Order;
                                            int[,] Tab = CloneATable(Tabl);
                                            int ik1 = ik, jk1 = jk, iki1 = iki, jki1 = jki, OrderP = OrderPalte, OrderM = OrderPalteMinusPluse, Depth1 = Depth + 1;
                                            bool KindCheckedSelf1 = KindCheckedSelf;
                                            int[] IS = null;
                                            Object O1 = new Object();
                                            lock (O1)
                                            {
                                                var th = Task.Factory.StartNew(() => IS = IsNextMovmentIsCheckOrCheckMateForCurrentMovmentbaseKernel(Ord, CloneATable(Tab), ik1, jk1, iki1, jki1, OrderP, OrderM, Depth1, KindCheckedSelf1));
                                                th.Wait();
                                                th.Dispose();
                                                if (Is[0] == 1) Is[0] = 1; if (IS[2] == 1) Is[2] = 1;
                                                Is[1] = Is[1]; Is[3] = IS[3];
                                            }
                                        }
                                    break;
                            }
                        }
                    Order = DummyOrder;
                    ChessRules.CurrentOrder = DummyCurrentOrder;
                }
                return Is;
            }
        }
        //When Current Movements is in dangrous and is not movable.
        bool IsGardForCurrentMovmentsAndIsNotMovable(int[,] Tab, int Order, Color a, int ii, int jj, int RowS, int ColS)
        {
            Object O = new Object();
            lock (O)
            {
                //Setting false.
                bool Attacked = true;
                int NumberOfCurrentEnemyAttackSuchObject = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                //For Enemy Order.
                Object O1 = new Object();
                lock (O1)
                {
                    //Ignore of Self Objects.
                    if (Order == 1 && Tab[ii, jj] >= 0)
                    {
                        return false;
                    }
                    else
                        if (Order == -1 && Tab[ii, jj] <= 0)
                    {
                        return false;
                    }
                    //Restore
                    Order = DummyOrder;
                    ChessRules.CurrentOrder = DummyCurrentOrder;
                    NumberOfCurrentEnemyAttackSuchObject = 0;
                    //For Self Objects and Empty.
                    //Ignore of Enemy Objects.
                    if (Order == 1 && Tab[RowS, ColS] < 0)
                    {
                        return false;
                    }
                    else
                        if (Order == -1 && Tab[RowS, ColS] > 0)
                    {
                        return false;
                    }         //For Enemy Order.
                    ChessRules.CurrentOrder = Order * -1;
                    //Initiate for not exiting from abnormal loop.
                    Attacked = false;
                    Color aa = Color.Gray;
                    if (Order * -1 == -1)
                        aa = Color.Brown;
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), ii, jj, RowS, ColS, aa, Order * -1) && (ObjectValueCalculator(CloneATable(Tab), ii, jj) < ObjectValueCalculator(CloneATable(Tab), RowS, ColS)));
                    th.Wait();
                    th.Dispose();

                    //When Enemy Attacked Current Movements.
                    if (ab)
                    {
                        NumberOfCurrentEnemyAttackSuchObject++;
                        //Clone a Table.
                        int[,] TabS = new int[8, 8];
                        for (int p = 0; p < 8; p++)
                            for (int m = 0; m < 8; m++)
                                TabS[p, m] = Tab[p, m];
                        TabS[RowS, ColS] = TabS[ii, jj];
                        TabS[ii, jj] = 0;
                        //For Self Objects.
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, RowD =>
                        for (int RowD = 0; RowD < 8; RowD++)
                        {
                            if (!Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
                                continue;
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ColD =>
                            for (int ColD = 0; ColD < 8; ColD++)
                            {
                                if (!Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
                                    if (Order == 1 && Tab[RowD, ColD] <= 0)
                                        continue;
                                    else
                                            if (Order == -1 && Tab[RowD, ColD] >= 0)
                                        continue;
                                //Show the Attacked.
                                Attacked = true;
                                //For Self Objects and Empty.
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, iiiii =>
                                for (int iiiii = 0; iiiii < 8; iiiii++)
                                {
                                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, jjjjj =>
                                    for (int jjjjj = 0; jjjjj < 8; jjjjj++)
                                    {
                                        //Ignore of Enemy Objects.
                                        if (Order == 1 && Tab[iiiii, jjjjj] < 0)
                                            continue;
                                        else
                                               if (Order == -1 && Tab[iiiii, jjjjj] > 0)
                                            continue;
                                        //When Current Objects Movable not need to consideration mor going to next Current object.
                                        Object O2 = new Object();
                                        lock (O2)
                                        {
                                            var th1 = Task.Factory.StartNew(() => ab = (new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TabS[RowD, ColD], TabS, Order, RowD, ColD)).Rules(RowD, ColD, iiiii, jjjjj, a, TabS[RowD, ColD]));
                                            th1.Wait();
                                            th1.Dispose();
                                            if (ab)
                                            {
                                                Attacked = Attacked && false;
                                                continue;
                                            }
                                        }
                                    }
                                    if (!Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
                                        continue;
                                }
                                if (Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
                                    continue;
                            }
                            if (Attacked || NumberOfCurrentEnemyAttackSuchObject > 1)
                                continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                //Restore.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;

                //continue Variable when true show an object is not movable or one enemy object attack more than one current Object.
                return Attacked || NumberOfCurrentEnemyAttackSuchObject > 1;
            }
        }
        ///when current movments gards enemy with higer priority at movment.QC_OK
        bool IsCurrentCanGardHighPriorityEnemy(int Depth, int[,] Table, int Order, Color a, int ij, int ji, int iij, int jji, int OrderPlate)
        {
            Object O = new Object();
            lock (O)
            {
                if (Depth >= CurrentAStarGredyMax)
                {
                    return false;
                }
                Object O4 = new Object();
                lock (O4)
                {
                    Depth++;
                    IsGardHighPriority = false;
                    int[,] Tabl1 = new int[8, 8];
                    for (var ik = 0; ik < 8; ik++)
                        for (var jk = 0; jk < 8; jk++)
                            Tabl1[ik, jk] = Table[ik, jk];
                    //For Current.
                    for (var i = 0; i < 8; i++)
                        for (var j = 0; j < 8; j++)
                        {
                            //Ignore of Enemy.QC_OK.
                            if (Order == 1 && Tabl1[i, j] <= 0)
                                continue;
                            else
                                if (Order == -1 && Tabl1[i, j] >= 0)
                                continue;
                            //For Enemy.
                            for (var ii = 0; ii < 8; ii++)
                                for (var jj = 0; jj < 8; jj++)
                                {
                                    //Ignore of Current.QC_OK.
                                    if (Order == 1 && Tabl1[ii, jj] >= 0)
                                        continue;
                                    else
                                        if (Order == -1 && Tabl1[ii, jj] >= 0)
                                        continue;
                                    for (var ik = 0; ik < 8; ik++)
                                        for (var jk = 0; jk < 8; jk++)
                                            Tabl1[ik, jk] = Table[ik, jk];
                                    //Take Movement.
                                    bool ab = false;
                                    var th = Task.Factory.StartNew(() => ab = Attack(Tabl1, i, j, ii, jj, a, Order * -1));
                                    th.Wait();
                                    th.Dispose();
                                    if (ab)
                                    {

                                        var th1 = Task.Factory.StartNew(() => ab = ObjectValueCalculator(Tabl1, i, j) <= ObjectValueCalculator(Tabl1, ii, jj));
                                        th1.Wait();
                                        th1.Dispose();
                                        if (ab)
                                        {//When Current Movments is

                                            if (Order == OrderPlate)
                                                IsGardHighPriority = true;
                                        }
                                        else
                                        {
                                            Tabl1[ii, jj] = Tabl1[i, j];
                                            Tabl1[i, j] = 0;
                                            if (Order * -1 == 1)
                                                a = Color.Gray;
                                            else
                                                a = Color.Brown;
                                            var th2 = Task.Factory.StartNew(() => IsGardHighPriority = IsGardHighPriority || IsCurrentCanGardHighPriorityEnemy(Depth, CloneATable(Table), Order * -1, a, ii, jj, i, j, OrderPlate));
                                            th2.Wait();
                                            th2.Dispose();
                                        }
                                    }
                                }
                        }
                }

                return IsGardHighPriority;
            }
        }
        bool CurrentIsTowCastleOrMinisterBecomeCheckedMateAtCloseRanAway(int RowK, int ColK, int[,] Table)
        {
            Object O = new Object();
            lock (O)
            {
                if (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table)))
                    return false;
                bool Is = false;
                int IsN = 0;
                if (Table[RowK, ColK] != 0)
                {
                    int Sign = (System.Math.Abs(Table[RowK, ColK]) / Table[RowK, ColK]) * -1;
                    int Obj1 = Sign * 4;
                    int Obj2 = Sign * 5;
                    for (int k = 0; k < 8; k++)
                    {
                        if (RowK == k)
                            continue;
                        if (Table[k, ColK] == Obj1 || Table[k, ColK] == Obj2)
                        {
                            IsN++;
                        }
                        else
                        if (Table[k, ColK] != 0)
                            IsN = 0;
                        for (int p = 0; p < 8; p++)
                        {
                            if (p == ColK)
                                continue;
                            if (Table[k, p] == Obj1 || Table[k, p] == Obj2)
                            {
                                IsN++;
                            }
                            else
                        if (Table[k, p] != 0)
                                IsN = 0;
                        }
                    }

                    if (IsN >= 2)
                        return true;
                    IsN = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        if (ColK == k)
                            continue;
                        if (Table[RowK, k] == Obj1 || Table[RowK, k] == Obj2)
                        {
                            IsN++;
                        }
                        else
                        if (Table[RowK, 0] != 0)
                            IsN = 0;
                        for (int p = 0; p < 8; p++)
                        {
                            if (p == RowK)
                                continue;
                            if (Table[p, k] == Obj1 || Table[p, k] == Obj2)
                            {
                                IsN++;
                            }
                            else
                        if (Table[p, k] != 0)
                                IsN = 0;
                        }
                    }
                    if (IsN >= 2)
                        Is = true;
                }
                return Is;
            }
        }
        bool SameSign(int Obj1, int Obj2)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (Obj1 != 0 && Obj2 != 0)
                {
                    if ((System.Math.Abs(Obj1) / Obj1) == (System.Math.Abs(Obj2) / Obj2))
                        Is = true;
                }
                return Is;
            }
        }
        bool ThereIsOneSideToRanAwayByEnemyKing(int RowK, int ColK, int[,] Table)
        {
            Object O = new Object();
            lock (O)
            {
                if (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table)))
                    return false;
                bool Is = false;
                if ((ColK == 7) && (ColK - 1 >= 0) && (RowK - 1 >= 0) && (RowK + 1 < 8))
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = SameSign(Table[RowK, ColK], Table[RowK - 1, ColK - 1]) && SameSign(Table[RowK, ColK], Table[RowK + 1, ColK - 1]) && SameSign(Table[RowK, ColK], Table[RowK, ColK - 1]));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                        Is = true;
                }
                if ((ColK == 0) && (ColK + 1 < 8) && (RowK - 1 >= 0) && (RowK + 1 < 8))
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = SameSign(Table[RowK, ColK], Table[RowK - 1, ColK + 1]) && SameSign(Table[RowK, ColK], Table[RowK + 1, ColK + 1]) && SameSign(Table[RowK, ColK], Table[RowK, ColK + 1]));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                        Is = true;
                }
                return Is;
            }
        }
        bool CurrentCanBecomeClosedRanAwayByOneCastleOrMinister(int RowK, int ColK, int[,] Table)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThereIsOneSideToRanAwayByEnemyKing(RowK, ColK, CloneATable(Table)));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (k == ColK)
                            continue;
                        for (int p = 0; p < 8; p++)
                        {
                            var th1 = Task.Factory.StartNew(() => ab = SameSign(Table[RowK, ColK], Table[p, k]));
                            th1.Wait();
                            th1.Dispose();
                            if (!ab)
                            {
                                if (Table[p, k] != 0)
                                {
                                    int Obj = System.Math.Abs(Table[p, k]) / Table[p, k];
                                    int Obj1 = Obj * 4;
                                    int Obj2 = Obj * 5;
                                    if (Table[p, k] == Obj1)
                                        return true;
                                    if (Table[p, k] == Obj2)
                                        return true;
                                }
                            }
                        }
                    }
                    for (int k = 0; k < 8; k++)
                    {
                        if (k == RowK)
                            continue;
                        for (int p = 0; p < 8; p++)
                        {
                            var th1 = Task.Factory.StartNew(() => ab = SameSign(Table[RowK, ColK], Table[k, p]));
                            th1.Wait();
                            th1.Dispose();
                            if (!ab)
                            {

                                if (Table[k, p] != 0)
                                {
                                    int Obj = System.Math.Abs(Table[k, p]) / Table[k, p];
                                    int Obj1 = Obj * 4;
                                    int Obj2 = Obj * 5;
                                    if (Table[k, p] == Obj1)
                                        return true;
                                    if (Table[k, p] == Obj2)
                                        return true;
                                }
                            }
                        }
                    }
                }
                return Is;
            }
        }
        bool IsObjectrSelfAttackEnemyKing(int Rowk, int ColK, int[,] Table, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                if (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table)))
                    return false;
                bool Is = false;
                const int MinisteGrayObj = 5, CastleGrayObj = 4, ElepahantGrayObj = 2, PawnGrayObj = 1;
                const int MinisteBrownObj = -5, CastleBrownObj = -4//, ElephantBrownObj = -2
                , PawnBrownObj = -1;
                if (Order == 1)
                {
                    if (ColK == 0)
                    {
                        if (Table[Rowk, ColK + 1] == ElepahantGrayObj)
                        {
                            if (Table[Rowk, ColK + 2] == CastleGrayObj)
                            {
                                if ((Table[Rowk - 1, ColK + 1] == PawnGrayObj) || (Table[Rowk + 1, ColK + 1] == PawnGrayObj))
                                {
                                    Is = true;
                                }
                            }
                            if (Table[Rowk + 1, ColK + 2] == CastleGrayObj)
                            {
                                if ((Table[Rowk - 1, ColK + 1] == MinisteGrayObj) || (Table[Rowk + 1, ColK + 1] == MinisteGrayObj))
                                {
                                    Is = true;
                                }
                            }
                        }
                        if (Table[Rowk, ColK + 1] == PawnGrayObj)
                        {
                            if (Table[Rowk + 1, ColK + 2] == MinisteGrayObj)
                            {
                                if (Table[Rowk - 1, ColK + 2] == PawnGrayObj)
                                    Is = true;
                            }
                            if (Table[Rowk + 1, ColK + 2] == MinisteGrayObj)
                            {
                                if (Table[Rowk - 2, ColK + 2] == PawnGrayObj)
                                    Is = true;
                            }
                        }
                    }
                }
                else
                {
                    if (ColK == 7)
                    {
                        if (Table[Rowk, ColK - 1] == ElepahantGrayObj)
                        {
                            if (Table[Rowk, ColK - 2] == CastleBrownObj)
                            {
                                if ((Table[Rowk - 1, ColK - 1] == PawnBrownObj) || (Table[Rowk + 1, ColK - 1] == PawnBrownObj))
                                {
                                    Is = true;
                                }
                            }
                            if (Table[Rowk - 1, ColK - 2] == CastleBrownObj)
                            {
                                if ((Table[Rowk - 1, ColK - 1] == MinisteBrownObj) || (Table[Rowk + 1, ColK - 1] == MinisteBrownObj))
                                {
                                    Is = true;
                                }
                            }
                        }
                        if (Table[Rowk, ColK - 1] == PawnBrownObj)
                        {
                            if (Table[Rowk - 1, ColK - 2] == MinisteBrownObj)
                            {
                                if (Table[Rowk + 1, ColK - 2] == PawnBrownObj)
                                    Is = true;
                            }
                            if (Table[Rowk - 1, ColK - 2] == MinisteBrownObj)
                            {
                                if (Table[Rowk + 1, ColK - 2] == PawnBrownObj)
                                    Is = true;
                            }
                        }
                    }
                }
                return Is;
            }
        }
        public int SimpleMate_Zero(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                if (Order == 1)
                {
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowD, ColD);
                    int[,] Tab = CloneATable(Table);
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = G.CheckMate(CloneATable(Tab), Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        if (Order == 1 && G.CheckMateBrown)
                            HA += RationalRegard;
                        else
                     if (Order == 1 && G.CheckMateGray)
                            HA += RationalPenalty;
                    }
                }
                else
                {
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    int[,] Tab = CloneATable(Table);
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = G.CheckMate(CloneATable(Tab), Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        if (Order == -1 && G.CheckMateGray)
                            HA += RationalRegard;
                        else
                        if (Order == -1 && G.CheckMateBrown)
                            HA += RationalPenalty;
                    }
                }
                return HA;
            }
        }
        public int SimpleMate_One(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                if (Order == 1)
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    G.FindBrownKing(CloneATable(Table), ref RowK, ref ColK);
                    bool S1 = false;
                    var H1 = Task.Factory.StartNew(() => S1 = CurrentIsTowCastleOrMinisterBecomeCheckedMateAtCloseRanAway(RowK, ColK, CloneATable(Table)));
                    H1.Wait();
                    H1.Dispose();
                    if (S1)
                        HA += RationalRegard;
                    else
                    {
                        bool S2 = false;
                        var H2 = Task.Factory.StartNew(() => S2 = CurrentCanBecomeClosedRanAwayByOneCastleOrMinister(RowK, ColK, CloneATable(Table)));
                        H2.Wait();
                        H2.Dispose();
                        if (S2)
                            HA += RationalRegard;
                        else
                        {
                            bool S3 = false;
                            var H3 = Task.Factory.StartNew(() => S3 = IsObjectrSelfAttackEnemyKing(RowK, ColK, CloneATable(Table), Order));
                            H3.Wait();
                            H3.Dispose();
                            if (S3)
                                HA += RationalRegard;
                        }
                    }
                }
                else
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    G.FindGrayKing(CloneATable(Table), ref RowK, ref ColK);
                    bool S1 = false;
                    var H1 = Task.Factory.StartNew(() => S1 = CurrentIsTowCastleOrMinisterBecomeCheckedMateAtCloseRanAway(RowK, ColK, CloneATable(Table)));
                    H1.Wait();
                    H1.Dispose();
                    if (S1)
                        HA += RationalRegard;
                    else
                    {
                        bool S2 = false;
                        var H2 = Task.Factory.StartNew(() => S2 = CurrentCanBecomeClosedRanAwayByOneCastleOrMinister(RowK, ColK, CloneATable(Table)));
                        H2.Wait();
                        H2.Dispose();
                        if (S2)
                            HA += RationalRegard;
                        else
                        {
                            bool S3 = false;
                            var H3 = Task.Factory.StartNew(() => S2 = IsObjectrSelfAttackEnemyKing(RowK, ColK, CloneATable(Table), Order));
                            H3.Wait();
                            H3.Dispose();
                            if (S3)
                                HA += RationalRegard;
                        }
                    }
                }
                return HA;
            }
        }
        public int SimpleMate_Tow(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                if (Order == 1)
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    G.FindBrownKing(CloneATable(Table), ref RowK, ref ColK);
                    if (EnemyKingCanMateByCloseHome(RowK, ColK, CloneATable(Table), Order))
                        HA += RationalRegard;
                }
                else
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    G.FindGrayKing(CloneATable(Table), ref RowK, ref ColK);
                    if (EnemyKingCanMateByCloseHome(RowK, ColK, CloneATable(Table), Order))
                        HA += RationalRegard;
                }
                return HA;
            }
        }
        public int SimpleMate_Three_And_Four(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                if (Order == 1)
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    G.FindBrownKing(CloneATable(Table), ref RowK, ref ColK);
                    if (EnemyKingHaveAtMostOneEmptyItemInAttack(RowK, ColK, CloneATable(Table), Order))
                        HA += RationalRegard;
                }
                else
                {
                    int RowK = -1, ColK = -1;
                    ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Table), Order, RowS, ColS);
                    G.FindGrayKing(CloneATable(Table), ref RowK, ref ColK);
                    if (EnemyKingHaveAtMostOneEmptyItemInAttack(RowK, ColK, CloneATable(Table), Order))
                        HA += RationalRegard;
                }
                return HA;
            }
        }
        public int EnemyKingHaveAtMostOneEmptyItem(int Rowk, int ColK, int[,] Table, int Order, ref List<int> EmptyR, ref List<int> EmptyC)
        {
            Object O = new Object();
            lock (O)
            {
                int NIs = 0;
                if (Rowk >= 0 && Rowk < 8 && ColK >= 0 && ColK < 8)
                {
                    if ((ColK - 1 >= 0))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk, ColK - 1]))
                        {
                            EmptyR.Add(Rowk);
                            EmptyC.Add(ColK - 1);
                            NIs++;
                        }
                    }
                    if ((ColK + 1 < 8))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk, ColK + 1]))
                        {
                            EmptyR.Add(Rowk);
                            EmptyC.Add(ColK + 1);
                            NIs++;
                        }
                    }
                    if ((Rowk - 1 >= 0))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk - 1, ColK]))
                        {
                            EmptyR.Add(Rowk - 1);
                            EmptyC.Add(ColK);
                            NIs++;
                        }
                    }
                    if ((Rowk + 1 < 8))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk + 1, ColK]))
                        {
                            EmptyR.Add(Rowk + 1);
                            EmptyC.Add(ColK);
                            NIs++;
                        }
                    }
                    if ((ColK - 1 >= 0) && (Rowk - 1 >= 0))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk - 1, ColK - 1]))
                        {
                            EmptyR.Add(Rowk - 1);
                            EmptyC.Add(ColK - 1);
                            NIs++;
                        }
                    }
                    if ((ColK - 1 >= 0) && (Rowk + 1 < 8))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk + 1, ColK - 1]))
                        {
                            EmptyR.Add(Rowk + 1);
                            EmptyC.Add(ColK - 1);
                            NIs++;
                        }
                    }
                    if ((ColK + 1 < 8) && (Rowk + 1 < 8))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk + 1, ColK + 1]))
                        {
                            EmptyR.Add(Rowk + 1);
                            EmptyC.Add(ColK + 1);
                            NIs++;
                        }
                    }
                    if ((ColK + 1 < 8) && (Rowk - 1 >= 0))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk - 1, ColK + 1]))
                        {
                            EmptyR.Add(Rowk - 1);
                            EmptyC.Add(ColK + 1);
                            NIs++;
                        }
                    }
                    if ((ColK + 1 < 8) && (Rowk - 1 >= 0))
                    {
                        if (!SameSign(Table[Rowk, ColK], Table[Rowk - 1, ColK + 1]))
                        {
                            EmptyR.Add(Rowk - 1);
                            EmptyC.Add(ColK + 1);
                            NIs++;
                        }
                    }
                }
                return NIs;
            }
        }
        public bool EnemyKingHaveAtMostOneEmptyItemInAttack(int Rowk, int ColK, int[,] Table, int Order)
        {
            bool ab = false;
            var th = Task.Factory.StartNew(() => ab = IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table)));
            th.Wait();
            th.Dispose();
            if (!ab)
                return false;
            Object O = new Object();
            lock (O)
            {
                //#pragma warning disable CS0219 // The variable 'NIs' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'NIs' is assigned but its value is never used
                int NIs = 0;
#pragma warning restore CS0219 // The variable 'NIs' is assigned but its value is never used
                //#pragma warning restore CS0219 // The variable 'NIs' is assigned but its value is never used
                for (int k = 0; k < 8; k++)
                {
                    for (int p = 0; p < 8; p++)
                    {
                        var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), k, p, Rowk, ColK, color, Order));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {
                            for (int kk = 0; kk < 8; kk++)
                            {
                                for (int pp = 0; pp < 8; pp++)
                                {
                                    for (int kkk = 0; kkk < 8; kkk++)
                                    {
                                        for (int ppp = 0; ppp < 8; ppp++)
                                        {
                                            var th2 = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), kk, pp, kkk, ppp, color, Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            if (ab)
                                            {

                                                int[,] Ta = CloneATable(Table);
                                                Ta[kkk, ppp] = Ta[kk, pp];
                                                Ta[kk, pp] = 0;
                                                ChessRules G = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Order, CloneATable(Ta), Order, kkk, ppp);
                                                var th3 = Task.Factory.StartNew(() => ab = G.CheckMate(CloneATable(Ta), Order));
                                                th3.Wait();
                                                th3.Dispose();
                                                if (ab)
                                                {
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
                return false;
            }
        }
        bool IsNumberOfObjecttIsLessThanThreashold(int[,] Tab, int Threashold = 30)
        {
            Object O = new Object();
            lock (O)
            {
                int ObjN = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Tab[i, j] != 0)
                            ObjN++;
                    }
                }
                if (ObjN <= Threashold)
                    return true;
                return false;
            }
        }
        public bool EnemyKingCanMateByCloseHome(int RowK, int ColK, int[,] Table, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                if (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Table)))
                    return false;
                bool Is = false;
                List<int> EmptyR = new List<int>(), EmptyC = new List<int>();
                int NIs = 0;
                var th = Task.Factory.StartNew(() => NIs = EnemyKingHaveAtMostOneEmptyItem(RowK, ColK, CloneATable(Table), Order, ref EmptyR, ref EmptyC));
                th.Wait();
                th.Dispose();

                //King Have One HomeAtlist movment
                if (NIs <= 2)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        for (int p = 0; p < 8; p++)
                        {
                            if (Order == 1 & Table[k, p] <= 0)
                                continue;
                            if (Order == -1 & Table[k, p] >= 0)
                                continue;
                            int[,] Tab = CloneATable(Table);
                            for (int kk = 0; kk < 8; kk++)
                            {
                                for (int pp = 0; pp < 8; pp++)
                                {
                                    if (Order == 1 & Table[kk, pp] <= 0)
                                        continue;
                                    if (Order == -1 & Table[kk, pp] >= 0)
                                        continue;
                                    //Self Have Support
                                    bool ab = false;
                                    var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Tab), kk, pp, k, p, color, Order));
                                    th1.Wait();
                                    th1.Dispose();
                                    if (ab)
                                    {
                                        for (int kkk = 0; kkk < 8; kkk++)
                                        {
                                            for (int ppp = 0; ppp < 8; ppp++)
                                            {
                                                if (Order == 1 & Table[kkk, ppp] > 0)
                                                    continue;
                                                if (Order == -1 & Table[kkk, ppp] < 0)
                                                    continue;
                                                //Enemy King Attack
                                                var th2 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), k, p, kkk, ppp, color, Order));
                                                th2.Wait();
                                                th2.Dispose();
                                                if (ab)
                                                {
                                                    int[,] Ta = CloneATable(Tab);
                                                    Ta[kkk, ppp] = Ta[k, p];
                                                    Ta[k, p] = 0;
                                                    ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Ta[kkk, ppp], CloneATable(Tab), Order, kkk, ppp);
                                                    if (A.CheckMate(CloneATable(Ta), Order * 1))
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
                return Is;
            }
        }
        bool IsMinisterOrElephantBecomeActive(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            bool Is = false;
            const int ElephantGray = 2, ElephantBrown = -2;
            const int MinisterGray = 2, MinisterBrown = -2;
            if (Order == 1)
            {
                if (Table[7, 2] == ElephantGray)
                {
                    if (ColS == 6 && RowS == 1)
                        Is = true;
                    if (ColS == 6 && RowS == 3)
                        Is = true;
                }
                if (Table[7, 5] == ElephantGray)
                {
                    if (ColS == 6 && RowS == 4)
                        Is = true;
                    if (ColS == 6 && RowS == 6)
                        Is = true;
                }
                if (Table[7, 3] == MinisterGray)
                {
                    if (ColS == 6 && RowS == 2)
                        Is = true;
                    if (ColS == 6 && RowS == 3)
                        Is = true;
                    if (ColS == 6 && RowS == 4)
                        Is = true;
                }
            }
            else
            {
                if (Table[0, 2] == ElephantBrown)
                {
                    if (ColS == 1 && RowS == 1)
                        Is = true;
                    if (ColS == 1 && RowS == 3)
                        Is = true;
                }
                if (Table[0, 5] == ElephantBrown)
                {
                    if (ColS == 1 && RowS == 4)
                        Is = true;
                    if (ColS == 1 && RowS == 6)
                        Is = true;
                }
                if (Table[0, 3] == MinisterBrown)
                {
                    if (ColS == 1 && RowS == 2)
                        Is = true;
                    if (ColS == 1 && RowS == 3)
                        Is = true;
                    if (ColS == 1 && RowS == 4)
                        Is = true;
                }
            }
            return Is;
        }
        bool IsContorlCenter(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            bool Is = false;
            const int ControlF = 3, ControlS = 4;
            if ((RowD == ControlF || RowD == ControlS || ColD == ControlF || ColD == ControlS))
            {
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                th.Wait();
                th.Dispose();
                if (ab)
                    Is = true;
                var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                th1.Wait();
                th1.Dispose();
                if (ab)
                    Is = true;
            }
            return Is;
        }
        ///Heuristic of Check and CheckMate.
        public int HeuristicCheckAndCheckMate(int RowS, int ColS, int RowD, int ColD, int[,] Table, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                var H1 = Task.Factory.StartNew(() => HA += SimpleMate_Zero(RowS, ColS, RowD, ColD, CloneATable(Table), a));
                H1.Wait();
                H1.Dispose();

                if (HA == 0)
                {
                    var H2 = Task.Factory.StartNew(() => HA += SimpleMate_One(RowS, ColS, RowD, ColD, CloneATable(Table), a));
                    H2.Wait();
                    H2.Dispose();
                }
                if (HA == 0)
                {
                    var H3 = Task.Factory.StartNew(() => HA += SimpleMate_Tow(RowS, ColS, RowD, ColD, CloneATable(Table), a));
                    H3.Wait();
                    H3.Dispose();
                }
                if (HA == 0)
                {
                    var H4 = Task.Factory.StartNew(() => HA += SimpleMate_Three_And_Four(RowS, ColS, RowD, ColD, CloneATable(Table), a));
                    H4.Wait();
                    H4.Dispose();
                }
                bool S1 = false;

                var H5 = Task.Factory.StartNew(() => S1 = IsContorlCenter(RowS, ColS, RowD, ColD, CloneATable(Table), a));
                H5.Wait();
                H5.Dispose();
                if (S1)
                {
                    HA += RationalRegard;
                }
                bool S2 = false;

                var H6 = Task.Factory.StartNew(() => S2 = IsMinisterOrElephantBecomeActive(RowS, ColS, RowD, ColD, CloneATable(Table), a));
                H6.Wait();
                H6.Dispose();
                if (S2)
                {
                    HA += RationalRegard;
                }
                return HA;
            }
        }
        //Veryfy and detect Object Value.
        int VeryFye(int[,] Table, int Order, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                int Object = Table[Row, Column];
                //Wehn Solider.
                if (System.Math.Abs(Object) == 1)
                    HA = 1;
                //When Elephant.
                else if (System.Math.Abs(Object) == 2)
                    HA = 2;
                //When Hourse.
                else if (System.Math.Abs(Object) == 3)
                    HA = 3;
                //When Castles.
                else if (System.Math.Abs(Object) == 4)
                    HA = 5;
                //When Minster.
                else if (System.Math.Abs(Object) == 5)
                    HA = 8;
                //When King.
                else if (System.Math.Abs(Object) == 6)
                    HA = 10;
                return HA;
            }
        }
        //QC_OK
        //Numbers of Supporting Current Objects method.
        int SupporterCount(int[,] Table, int Order, Color a, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                if (Order == 1)
                    ChessRules.CurrentOrder = 1;
                else
                    ChessRules.CurrentOrder = -1;
                bool[,] Tab = new bool[8, 8];
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        if (Order == 1 && Table[i, j] <= 0)
                            continue;
                        else
                            if (Order == -1 && Table[i, j] >= 0)
                            continue;
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), i, j, ii, jj, a, Order));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {

                            Count++;
                        }
                    }
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                return Count;
            }
        }
        //Attacks on Enemies.
        int AttackerCount(int[,] Table, int Order, Color a, int i, int j)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                int[,] Tab = new int[8, 8];
                for (int h = 0; h < 8; h++)
                    for (int k = 0; k < 8; k++)
                        Tab[h, k] = Table[h, k];
                //For Slef Objects..
                for (var ii = 0; ii < 8; ii++)
                    for (var jj = 0; jj < 8; jj++)
                    {
                        //Ignore Of Self Objects
                        if (Order == 1 && Tab[ii, jj] >= 0)
                            continue;
                        else
                            if (Order == -1 && Tab[ii, jj] <= 0)
                            continue;
                        //If Current Attacks Enemy.
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Tab), i, j, ii, jj, a, Order));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {
                            Count++;
                        }
                    }
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                return Count;
            }
        }
        //Attackers of Enemies.QC_OK.
        int EnemyAttackerCount(int[,] Table, int Order, Color a, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                if (Order == 1)
                    ChessRules.CurrentOrder = 1;
                else
                    ChessRules.CurrentOrder = -1;
                int[,] Tab = new int[8, 8];
                for (int h = 0; h < 8; h++)
                    for (int k = 0; k < 8; k++)
                        Tab[h, k] = Table[h, k];
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                    {
                        if (Order == 1 && Table[i, j] >= 0)
                            continue;
                        else
                            if (Order == -1 && Table[i, j] <= 0)
                            continue;
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), i, j, ii, jj, a, Order * -1));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {

                            Count++;
                        }
                    }
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                return Count;
            }
        }
        //clear TableInitiationPreventionOfMultipleMoveWhenAll
        void MakeEmptyTableInitiationPreventionOfMultipleMoveWhenAllIsFull()
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (TableInitiationPreventionOfMultipleMove[i, j] == 0)
                            Is = true;
                    }
                }
                if (!Is)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            TableInitiationPreventionOfMultipleMove[i, j] = 0;
                        }
                    }
                }
            }
        }
        //determine when specified ro column of TableInitiationPreventionOfMultipleMoveWhenAll is zero and empty
        bool IsTableRowColIsZero(int Row, int Col)
        {
            Object O = new Object();
            lock (O)
            {
                var th = Task.Factory.StartNew(() => MakeEmptyTableInitiationPreventionOfMultipleMoveWhenAllIsFull());
                th.Wait();
                th.Dispose();

                bool Is = false;
                if (TableInitiationPreventionOfMultipleMove[Row, Col] == 0)
                {
                    return true;
                }
                return Is;
            }
        }
        //when situation of cerntralized location pawn object is ok
        public bool IsCentralPawnIsOk(int[,] Tab, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                int NoOfPawn = 0;
                int NoOfSupport = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Order == 1)
                        {
                            if (Tab[i, j] == 1)
                                NoOfPawn++;
                            if (i - 1 >= 0 && j + 1 < 8)
                            {
                                if (Tab[i - 1, j + 1] == 1)
                                    NoOfSupport++;
                            }
                            if (i - 1 >= 0 && j - 1 >= 0)
                            {
                                if (Tab[i - 1, j - 1] == 1)
                                    NoOfSupport++;
                            }
                        }
                        else
                        {
                            if (Tab[i, j] == -1)
                                NoOfPawn++;
                            if (i + 1 < 8 && j + 1 < 8)
                            {
                                if (Tab[i + 1, j + 1] == -1)
                                    NoOfSupport++;
                            }
                            if (i + 1 < 8 && j - 1 >= 0)
                            {
                                if (Tab[i + 1, j - 1] == -1)
                                    NoOfSupport++;
                            }
                        }
                    }
                }
                if (NoOfSupport >= (NoOfPawn / 2))
                    Is = true;
                return Is;
            }
        }
        //when center is controled by traversal objects.
        public bool CenrtrallnControlByTraversal(int[,] Tab, Color a, int Order, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                Color aa = Color.Gray;
                if (Order * -1 == -1)
                    aa = Color.Brown;
                bool Is = false;
                if (Tab[RowS, ColS] == 1 || Tab[RowS, ColS] == -1)
                    return Is;
                if (Tab[RowS, ColS] != 0)
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = (Tab[3, 4] == 0) && Movable(CloneATable(Tab), RowS, ColS, 3, 4, a, Order));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                        Is = true;
                    var th1 = Task.Factory.StartNew(() => ab = (Tab[4, 3] == 0) && Movable(CloneATable(Tab), RowS, ColS, 4, 3, a, Order));
                    th1.Wait();
                    th1.Dispose();
                    if (ab)
                        Is = true;
                    var th2 = Task.Factory.StartNew(() => ab = (Tab[3, 3] == 0) && Movable(CloneATable(Tab), RowS, ColS, 3, 3, a, Order));
                    th2.Wait();
                    th2.Dispose();
                    if (ab)
                        Is = true;
                    var th3 = Task.Factory.StartNew(() => ab = (Tab[4, 4] == 0) && Movable(CloneATable(Tab), RowS, ColS, 4, 4, a, Order));
                    th3.Wait();
                    th3.Dispose();
                    if (ab)
                        Is = true;
                    if (!Is)
                    {
                        if (Order == 1)
                        {
                            var th4 = Task.Factory.StartNew(() => ab = (Tab[3, 4] < 0) && Attack(CloneATable(Tab), RowS, ColS, 3, 4, aa, Order * -1));
                            th4.Wait();
                            th4.Dispose();
                            if (ab)
                                Is = true;
                            var th5 = Task.Factory.StartNew(() => ab = (Tab[4, 3] < 0) && Attack(CloneATable(Tab), RowS, ColS, 4, 3, aa, Order * -1));
                            th5.Wait();
                            th5.Dispose();
                            if (ab)
                                Is = true;
                            var th6 = Task.Factory.StartNew(() => ab = (Tab[3, 3] < 0) && Attack(CloneATable(Tab), RowS, ColS, 3, 3, aa, Order * -1));
                            th6.Wait();
                            th6.Dispose();
                            if (ab)
                                Is = true;
                            var th7 = Task.Factory.StartNew(() => ab = (Tab[4, 4] < 0) && Attack(CloneATable(Tab), RowS, ColS, 4, 4, aa, Order * -1));
                            th7.Wait();
                            th7.Dispose();
                            if (ab)
                                Is = true;
                            var th8 = Task.Factory.StartNew(() => ab = (Tab[3, 4] > 0) && Support(CloneATable(Tab), RowS, ColS, 3, 4, a, Order));
                            th8.Wait();
                            th8.Dispose();
                            if (ab)
                                Is = true;
                            var th9 = Task.Factory.StartNew(() => ab = (Tab[4, 3] > 0) && Support(CloneATable(Tab), RowS, ColS, 4, 3, a, Order));
                            th9.Wait();
                            th9.Dispose();
                            if (ab)
                                Is = true;
                            var th10 = Task.Factory.StartNew(() => ab = (Tab[3, 3] > 0) && Support(CloneATable(Tab), RowS, ColS, 3, 3, a, Order));
                            th10.Wait();
                            th10.Dispose();
                            if (ab)
                                Is = true;
                            var th11 = Task.Factory.StartNew(() => ab = (Tab[4, 4] > 0) && Support(CloneATable(Tab), RowS, ColS, 4, 4, a, Order));
                            th11.Wait();
                            th11.Dispose();
                            if (ab)
                                Is = true;
                        }
                        else
                        {
                            var th4 = Task.Factory.StartNew(() => ab = (Tab[3, 4] > 0) && Attack(CloneATable(Tab), RowS, ColS, 3, 4, aa, Order * -1));
                            th4.Wait();
                            th4.Dispose();
                            if (ab)
                                Is = true;
                            var th5 = Task.Factory.StartNew(() => ab = (Tab[4, 3] > 0) && Attack(CloneATable(Tab), RowS, ColS, 4, 3, aa, Order * -1));
                            th5.Wait();
                            th5.Dispose();
                            if (ab)
                                Is = true;
                            var th6 = Task.Factory.StartNew(() => ab = (Tab[3, 3] > 0) && Attack(CloneATable(Tab), RowS, ColS, 3, 3, aa, Order * -1));
                            th6.Wait();
                            th6.Dispose();
                            if (ab)
                                Is = true;
                            var th7 = Task.Factory.StartNew(() => ab = (Tab[4, 4] > 0) && Attack(CloneATable(Tab), RowS, ColS, 4, 4, aa, Order * -1));
                            th7.Wait();
                            th7.Dispose();
                            if (ab)
                                Is = true;
                            var th8 = Task.Factory.StartNew(() => ab = (Tab[3, 4] < 0) && Support(CloneATable(Tab), RowS, ColS, 3, 4, a, Order));
                            th8.Wait();
                            th8.Dispose();
                            if (ab)
                                Is = true;
                            var th9 = Task.Factory.StartNew(() => ab = (Tab[4, 3] < 0) && Support(CloneATable(Tab), RowS, ColS, 4, 3, a, Order));
                            th9.Wait();
                            th9.Dispose();
                            if (ab)
                                Is = true;
                            var th10 = Task.Factory.StartNew(() => ab = (Tab[3, 3] < 0) && Support(CloneATable(Tab), RowS, ColS, 3, 3, a, Order));
                            th10.Wait();
                            th10.Dispose();
                            if (ab)
                                Is = true;
                            var th11 = Task.Factory.StartNew(() => ab = (Tab[4, 4] < 0) && Support(CloneATable(Tab), RowS, ColS, 4, 4, a, Order));
                            th11.Wait();
                            th11.Dispose();
                            if (ab)
                                Is = true;
                        }
                        if (!Is)
                        {
                            int[,] Ta = CloneATable(Tab);
                            Ta[RowD, ColD] = Tab[RowS, ColS];
                            Tab[RowS, ColS] = 0;

                            var th12 = Task.Factory.StartNew(() => ab = (Tab[3, 4] == 0) && Movable(CloneATable(Tab), RowD, ColD, 3, 4, a, Order));
                            th12.Wait();
                            th12.Dispose();
                            if (ab)
                                Is = true;
                            var th13 = Task.Factory.StartNew(() => ab = (Tab[4, 3] == 0) && Movable(CloneATable(Tab), RowD, ColD, 4, 3, a, Order));
                            th13.Wait();
                            th13.Dispose();
                            if (ab)
                                Is = true;
                            var th14 = Task.Factory.StartNew(() => ab = (Tab[3, 3] == 0) && Movable(CloneATable(Tab), RowD, ColD, 3, 3, a, Order));
                            th14.Wait();
                            th14.Dispose();
                            if (ab)
                                Is = true;
                            var th15 = Task.Factory.StartNew(() => ab = (Tab[4, 4] == 0) && Movable(CloneATable(Tab), RowD, ColD, 4, 4, a, Order));
                            th15.Wait();
                            th15.Dispose();
                            if (ab)
                                Is = true;
                            if (!Is)
                            {
                                if (Order == 1)
                                {
                                    var th4 = Task.Factory.StartNew(() => ab = (Tab[3, 4] < 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 4, aa, Order * -1));
                                    th4.Wait();
                                    th4.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th5 = Task.Factory.StartNew(() => ab = (Tab[4, 3] < 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 3, aa, Order * -1));
                                    th5.Wait();
                                    th5.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th6 = Task.Factory.StartNew(() => ab = (Tab[3, 3] < 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 3, aa, Order * -1));
                                    th6.Wait();
                                    th6.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th7 = Task.Factory.StartNew(() => ab = (Tab[4, 4] < 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 4, aa, Order * -1));
                                    th7.Wait();
                                    th7.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th8 = Task.Factory.StartNew(() => ab = (Tab[3, 4] > 0) && Support(CloneATable(Tab), RowD, ColD, 3, 4, a, Order));
                                    th8.Wait();
                                    th8.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th9 = Task.Factory.StartNew(() => ab = (Tab[4, 3] > 0) && Support(CloneATable(Tab), RowD, ColD, 4, 3, a, Order));
                                    th9.Wait();
                                    th9.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th10 = Task.Factory.StartNew(() => ab = (Tab[3, 3] > 0) && Support(CloneATable(Tab), RowD, ColD, 3, 3, a, Order));
                                    th10.Wait();
                                    th10.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th11 = Task.Factory.StartNew(() => ab = (Tab[4, 4] > 0) && Support(CloneATable(Tab), RowD, ColD, 4, 4, a, Order));
                                    th11.Wait();
                                    th11.Dispose();
                                    if (ab)
                                        Is = true;
                                }
                                else
                                {
                                    var th4 = Task.Factory.StartNew(() => ab = (Tab[3, 4] > 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 4, aa, Order * -1));
                                    th4.Wait();
                                    th4.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th5 = Task.Factory.StartNew(() => ab = (Tab[4, 3] > 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 3, aa, Order * -1));
                                    th5.Wait();
                                    th5.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th6 = Task.Factory.StartNew(() => ab = (Tab[3, 3] > 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 3, aa, Order * -1));
                                    th6.Wait();
                                    th6.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th7 = Task.Factory.StartNew(() => ab = (Tab[4, 4] > 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 4, aa, Order * -1));
                                    th7.Wait();
                                    th7.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th8 = Task.Factory.StartNew(() => ab = (Tab[3, 4] < 0) && Support(CloneATable(Tab), RowD, ColD, 3, 4, a, Order));
                                    th8.Wait();
                                    th8.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th9 = Task.Factory.StartNew(() => ab = (Tab[4, 3] < 0) && Support(CloneATable(Tab), RowD, ColD, 4, 3, a, Order));
                                    th9.Wait();
                                    th9.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th10 = Task.Factory.StartNew(() => ab = (Tab[3, 3] < 0) && Support(CloneATable(Tab), RowD, ColD, 3, 3, a, Order));
                                    th10.Wait();
                                    th10.Dispose();
                                    if (ab)
                                        Is = true;
                                    var th11 = Task.Factory.StartNew(() => ab = (Tab[4, 4] < 0) && Support(CloneATable(Tab), RowD, ColD, 4, 4, a, Order));
                                    th11.Wait();
                                    th11.Dispose();
                                    if (ab)
                                        Is = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Tab[RowD, ColD] == 1 || Tab[RowD, ColD] == -1)
                            return Is;
                        var th12 = Task.Factory.StartNew(() => ab = (Tab[3, 4] == 0) && Movable(CloneATable(Tab), RowD, ColD, 3, 4, a, Order));
                        th12.Wait();
                        th12.Dispose();
                        if (ab)
                            Is = true;
                        var th13 = Task.Factory.StartNew(() => ab = (Tab[4, 3] == 0) && Movable(CloneATable(Tab), RowD, ColD, 4, 3, a, Order));
                        th13.Wait();
                        th13.Dispose();
                        if (ab)
                            Is = true;
                        var th14 = Task.Factory.StartNew(() => ab = (Tab[3, 3] == 0) && Movable(CloneATable(Tab), RowD, ColD, 3, 3, a, Order));
                        th14.Wait();
                        th14.Dispose();
                        if (ab)
                            Is = true;
                        var th15 = Task.Factory.StartNew(() => ab = (Tab[4, 4] == 0) && Movable(CloneATable(Tab), RowD, ColD, 4, 4, a, Order));
                        th15.Wait();
                        th15.Dispose();
                        if (ab)
                            Is = true;
                        if (!Is)
                        {
                            if (Order == 1)
                            {
                                var th4 = Task.Factory.StartNew(() => ab = (Tab[3, 4] < 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 4, aa, Order * -1));
                                th4.Wait();
                                th4.Dispose();
                                if (ab)
                                    Is = true;
                                var th5 = Task.Factory.StartNew(() => ab = (Tab[4, 3] < 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 3, aa, Order * -1));
                                th5.Wait();
                                th5.Dispose();
                                if (ab)
                                    Is = true;
                                var th6 = Task.Factory.StartNew(() => ab = (Tab[3, 3] < 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 3, aa, Order * -1));
                                th6.Wait();
                                th6.Dispose();
                                if (ab)
                                    Is = true;
                                var th7 = Task.Factory.StartNew(() => ab = (Tab[4, 4] < 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 4, aa, Order * -1));
                                th7.Wait();
                                th7.Dispose();
                                if (ab)
                                    Is = true;
                                var th8 = Task.Factory.StartNew(() => ab = (Tab[3, 4] > 0) && Support(CloneATable(Tab), RowD, ColD, 3, 4, a, Order));
                                th8.Wait();
                                th8.Dispose();
                                if (ab)
                                    Is = true;
                                var th9 = Task.Factory.StartNew(() => ab = (Tab[4, 3] > 0) && Support(CloneATable(Tab), RowD, ColD, 4, 3, a, Order));
                                th9.Wait();
                                th9.Dispose();
                                if (ab)
                                    Is = true;
                                var th10 = Task.Factory.StartNew(() => ab = (Tab[3, 3] > 0) && Support(CloneATable(Tab), RowD, ColD, 3, 3, a, Order));
                                th10.Wait();
                                th10.Dispose();
                                if (ab)
                                    Is = true;
                                var th11 = Task.Factory.StartNew(() => ab = (Tab[4, 4] > 0) && Support(CloneATable(Tab), RowD, ColD, 4, 4, a, Order));
                                th11.Wait();
                                th11.Dispose();
                                if (ab)
                                    Is = true;
                            }
                            else
                            {
                                var th4 = Task.Factory.StartNew(() => ab = (Tab[3, 4] > 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 4, aa, Order * -1));
                                th4.Wait();
                                th4.Dispose();
                                if (ab)
                                    Is = true;
                                var th5 = Task.Factory.StartNew(() => ab = (Tab[4, 3] > 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 3, aa, Order * -1));
                                th5.Wait();
                                th5.Dispose();
                                if (ab)
                                    Is = true;
                                var th6 = Task.Factory.StartNew(() => ab = (Tab[3, 3] > 0) && Attack(CloneATable(Tab), RowD, ColD, 3, 3, aa, Order * -1));
                                th6.Wait();
                                th6.Dispose();
                                if (ab)
                                    Is = true;
                                var th7 = Task.Factory.StartNew(() => ab = (Tab[4, 4] > 0) && Attack(CloneATable(Tab), RowD, ColD, 4, 4, aa, Order * -1));
                                th7.Wait();
                                th7.Dispose();
                                if (ab)
                                    Is = true;
                                var th8 = Task.Factory.StartNew(() => ab = (Tab[3, 4] < 0) && Support(CloneATable(Tab), RowD, ColD, 3, 4, a, Order));
                                th8.Wait();
                                th8.Dispose();
                                if (ab)
                                    Is = true;
                                var th9 = Task.Factory.StartNew(() => ab = (Tab[4, 3] < 0) && Support(CloneATable(Tab), RowD, ColD, 4, 3, a, Order));
                                th9.Wait();
                                th9.Dispose();
                                if (ab)
                                    Is = true;
                                var th10 = Task.Factory.StartNew(() => ab = (Tab[3, 3] < 0) && Support(CloneATable(Tab), RowD, ColD, 3, 3, a, Order));
                                th10.Wait();
                                th10.Dispose();
                                if (ab)
                                    Is = true;
                                var th11 = Task.Factory.StartNew(() => ab = (Tab[4, 4] < 0) && Support(CloneATable(Tab), RowD, ColD, 4, 4, a, Order));
                                th11.Wait();
                                th11.Dispose();
                                if (ab)
                                    Is = true;
                            }
                        }
                    }
                }
                return Is;
            }
        }
        //when tow self castle control tow beside row or column
        bool ExistCastleInDouble(int Order, int[,] Table, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                bool Ex = false;
                int[,] Tab = CloneATable(Table);
                if (Order == 1)
                {
                    if (Tab[RowD, ColD] == 4)
                    {
                        if (ColD == 7)
                        {
                            for (int Row = 0; Row < 8; Row++)
                            {
                                if (Tab[Row, 6] == 4)
                                    Ex = true;
                            }
                        }
                        else
                        if (ColD == 6)
                        {
                            for (int Row = 0; Row < 8; Row++)
                            {
                                if (Tab[Row, 7] == 4)
                                    Ex = true;
                            }
                        }
                    }
                    if (!Ex)
                    {
                        if (Tab[RowS, ColS] == 4 && Tab[RowD, ColD] <= 0)
                        {
                            Tab[RowD, ColD] = Tab[RowS, ColS];
                            Tab[RowS, ColS] = 0;
                            if (Tab[RowD, ColD] == 4)
                            {
                                if (ColD == 7)
                                {
                                    for (int Row = 0; Row < 8; Row++)
                                    {
                                        if (Tab[Row, 6] == 4)
                                            Ex = true;
                                    }
                                }
                                else
                                if (ColD == 6)
                                {
                                    for (int Row = 0; Row < 8; Row++)
                                    {
                                        if (Tab[Row, 7] == 4)
                                            Ex = true;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (Tab[RowD, ColD] == -4)
                    {
                        if (ColD == 0)
                        {
                            for (int Row = 0; Row < 8; Row++)
                            {
                                if (Tab[Row, 1] == -4)
                                    Ex = true;
                            }
                        }
                        else
                        if (ColD == 1)
                        {
                            for (int Row = 0; Row < 8; Row++)
                            {
                                if (Tab[Row, 0] == -4)
                                    Ex = true;
                            }
                        }
                    }
                    if (!Ex)
                    {
                        if (Tab[RowS, ColS] == -4 && Tab[RowD, ColD] <= 0)
                        {
                            Tab[RowD, ColD] = Tab[RowS, ColS];
                            Tab[RowS, ColS] = 0;
                            if (Tab[RowD, ColD] == -4)
                            {
                                if (ColD == 0)
                                {
                                    for (int Row = 0; Row < 8; Row++)
                                    {
                                        if (Tab[Row, 1] == -4)
                                            Ex = true;
                                    }
                                }
                                else
                                if (ColD == 1)
                                {
                                    for (int Row = 0; Row < 8; Row++)
                                    {
                                        if (Tab[Row, 0] == -4)
                                            Ex = true;
                                    }
                                }
                            }
                        }
                    }
                }
                return Ex;
            }
        }
        //Distribution of Objects
        public int HeuristicDistribution(bool Before, int[,] Tab, int Order, Color a, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                int Dis = 0;
                const int ObjectGray = 0, ObjectBrown = 0;
                //opperation decision making  on pawn movment
                bool ab = false;
                var th1 = Task.Factory.StartNew(() => ab = IsTableRowColIsZero(RowS, ColS) && HeuristicAllReducedAttacked.Count == 0);
                th1.Wait();
                th1.Dispose();
                if (ab)
                    Dis = RationalRegard;
                else
                    Dis = RationalPenalty;

                var H1 = Task.Factory.StartNew(() => IKIsCentralPawnIsOk = IsCentralPawnIsOk(CloneATable(Tab), Order));
                H1.Wait();
                H1.Dispose();

                if (IKIsCentralPawnIsOk && HeuristicAllReducedAttacked.Count == 0)
                    Dis += RationalRegard;
                else
                    Dis += RationalPenalty;
                var th2 = Task.Factory.StartNew(() => ab = ExistCastleInDouble(Order, CloneATable(Tab), RowS, ColS, RowD, ColD));
                th2.Wait();
                th2.Dispose();
                if (ab)
                    Dis += RationalRegard;
                if (Order == 1)
                {
                    //castle in col 7 8
                    if (ColD == 6 || ColD == 7)
                    {
                        if (Tab[RowS, ColS] == 4 || Tab[RowD, ColD] == 4)
                            Dis += RationalRegard;
                    }
                    if ((Tab[3, 4] > ObjectGray && Tab[4, 3] > ObjectGray && Tab[3, 3] > ObjectGray && Tab[4, 4] > ObjectGray) || (IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 25)))
                    {
                        var th3 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] == 3) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) > 0));
                        th3.Wait();
                        th3.Dispose();
                        if (ab)
                            Dis += RationalPenalty;
                        else
                        {
                            var th4 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] == 3) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) > 0));
                            th4.Wait();
                            th4.Dispose();
                            if (ab)
                                Dis += RationalPenalty;
                            else

                            {
                                var th5 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] == 3) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) == 0));
                                th5.Wait();
                                th5.Dispose();
                                if (ab)
                                    Dis += RationalRegard;
                                else
                                {
                                    var th6 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] == 3) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) == 0));
                                    th6.Wait();
                                    th6.Dispose();
                                    if (ab)
                                        Dis += RationalRegard;
                                }
                            }
                        }
                    }
                    if (IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 32))
                    {
                        int Cor = 0;
                        var H2 = Task.Factory.StartNew(() => Cor = RefrigtzChessPortable.Colleralation.GetCorrelationScore(TableInitiation, CloneATable(Tab), 8, Order));
                        H2.Wait();
                        H2.Dispose();

                        if (Cor > Colleralation)
                        {
                            Colleralation = Cor;
                            Dis += RationalRegard;
                        }
                        if (Cor < ColleralationGray && Tab[RowS, ColS] > 0 && (Cor >= 0))
                        {
                            ColleralationGray = Cor;
                        }

                    }

                    var th7 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] > 0) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) > 0));
                    th7.Wait();
                    th7.Dispose();
                    if (ab)
                        Dis += RationalPenalty;
                    else
                    {
                        var th8 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] > 0) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) > 0));
                        th8.Wait();
                        th8.Dispose();
                        if (ab)
                            Dis += RationalPenalty;
                        else
                        {
                            var th9 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] > 0) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) == 0));
                            th9.Wait();
                            th9.Dispose();
                            if (ab)
                                Dis += RationalRegard;
                            else
                            {
                                var th10 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] > 0) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) == 0));
                                th10.Wait();
                                th10.Dispose();
                                if (ab)
                                    Dis += RationalRegard;
                            }
                        }
                    }

                    var th11 = Task.Factory.StartNew(() => ab = ((Tab[3, 4] > ObjectGray && Tab[4, 3] > ObjectGray && Tab[3, 3] > ObjectGray && Tab[4, 4] > ObjectGray)) && (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 25)));
                    th11.Wait();
                    th11.Dispose();
                    if (!ab)
                    {
                        var th12 = Task.Factory.StartNew(() => ab = IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 32));
                        th12.Wait();
                        th12.Dispose();
                        if (!ab)
                        {
                            int Cor = 0;
                            var H3 = Task.Factory.StartNew(() => Cor = RefrigtzChessPortable.Colleralation.GetCorrelationScore(TableInitiation, CloneATable(Tab), 8, Order));
                            H3.Wait();
                            H3.Dispose();

                            if (Cor < DeColleralation)
                            {
                                DeColleralation = Cor;
                                Dis += RationalRegard;
                            }
                        }
                    }
                }
                else
                {
                    //castle in col 7 8
                    if (ColD == 1 || ColD == 0)
                    {
                        if (Tab[RowS, ColS] == -4 || Tab[RowD, ColD] == -4)
                            Dis += RationalRegard;
                    }
                    if ((Tab[3, 4] < ObjectBrown && Tab[4, 3] < ObjectBrown && Tab[3, 3] < ObjectBrown && Tab[4, 4] < ObjectBrown) || (IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 25)))
                    {
                        var th13 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] == -3) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) > 0));
                        th13.Wait();
                        th13.Dispose();
                        if (ab)
                            Dis += RationalPenalty;
                        else
                        {
                            var th14 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] == -3) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) > 0));
                            th14.Wait();
                            th14.Dispose();
                            if (ab)
                                Dis += RationalPenalty;
                            else
                            {
                                var th15 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] == -3) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) == 0));
                                th15.Wait();
                                th15.Dispose();
                                if (ab)
                                    Dis += RationalRegard;
                                else
                                {
                                    var th16 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] == -3) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) == 0));
                                    th16.Wait();
                                    th16.Dispose();
                                    if (ab)
                                        Dis += RationalRegard;
                                }
                            }
                        }
                    }
                    var th17 = Task.Factory.StartNew(() => ab = IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 32));
                    th17.Wait();
                    th17.Dispose();
                    if (ab)
                    {
                        int Cor = 0;
                        var H4 = Task.Factory.StartNew(() => Cor = RefrigtzChessPortable.Colleralation.GetCorrelationScore(TableInitiation, CloneATable(Tab), 8, Order));
                        H4.Wait();
                        H4.Dispose();
                        if (Cor > Colleralation)
                        {
                            Colleralation = Cor;
                            Dis += RationalRegard;
                        }
                        if (Cor < ColleralationBrown && Tab[RowS, ColS] < 0 && (Cor >= 0))
                        {
                            ColleralationBrown = Cor;
                        }
                    }
                    var th18 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] < 0) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) > 0));
                    th18.Wait();
                    th18.Dispose();
                    if (ab)
                        Dis += RationalPenalty;
                    else
                    {
                        var th19 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] < 0) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) > 0));
                        th19.Wait();
                        th19.Dispose();
                        if (ab)
                            Dis += RationalPenalty;
                        else
                        {
                            var th20 = Task.Factory.StartNew(() => ab = (Tab[RowS, ColS] < 0) && (NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) == 0));
                            th20.Wait();
                            th20.Dispose();
                            if (ab)
                                Dis += RationalRegard;
                            else
                            {
                                var th21 = Task.Factory.StartNew(() => ab = (Tab[RowD, ColD] < 0) && (NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) == 0));
                                th21.Wait();
                                th21.Dispose();
                                if (ab)
                                    Dis += RationalRegard;
                            }
                        }
                    }
                    if (!((Tab[3, 4] < ObjectBrown && Tab[4, 3] < ObjectBrown && Tab[3, 3] < ObjectBrown && Tab[4, 4] < ObjectBrown)) && (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 25)))
                    {
                        if (!IsNumberOfObjecttIsLessThanThreashold(CloneATable(Tab), 32))
                        {
                            int Cor = 0;
                            var H5 = Task.Factory.StartNew(() => Cor = RefrigtzChessPortable.Colleralation.GetCorrelationScore(TableInitiation, CloneATable(Tab), 8, Order));
                            H5.Wait();
                            H5.Dispose();

                            if (Cor < DeColleralation)
                            {
                                DeColleralation = Cor;
                                Dis += RationalRegard;
                            }
                        }
                    }
                }
                if (CenrtrallnControlByTraversal(CloneATable(Tab), a, Order, RowS, ColS, RowD, ColD))
                    Dis += RationalRegard;
                else
                    Dis += RationalPenalty;

                return Dis;
            }
        }
        //when pawn is doubled or isolated at move before return true and rationalpenalty occured
        bool IsPawnIsolatedOrDoubleBackAwayOrHung(int RowS, int ColS, int RowD, int ColD, int[,] Table, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (Order == 1)
                {
                    if (ColS < 5)
                    {

                        if (!Is)
                        {
                            bool A = true;
                            bool B = true;
                            if (RowD >= 1 && ColD >= 1)
                                A = (Table[RowD - 1, ColD - 1] == 1);
                            if (RowD + 1 < 8 && ColD >= 1)
                                B = (Table[RowD + 1, ColD - 1] == 1);
                            if (!(A || B))
                                Is = true;
                        }
                    }
                }
                else
                {
                    if (ColS > 2)
                    {

                        if (!Is)
                        {
                            bool A = true;
                            bool B = true;
                            if (RowS >= 1 && ColS + 1 < 8)
                                A = (Table[RowS - 1, ColS + 1] == -1);
                            if (RowS + 1 < 8 && ColS + 1 > 8)
                                B = (Table[RowS + 1, ColS + 1] == -1);
                            if (!(A || B))
                                Is = true;
                        }
                    }
                }
                if (!Is)
                {
                    if (Order == 1)
                    {
                        if (ColS + 1 < 8)
                        {
                            if ((Table[RowS, ColS + 1] == 1 && Table[RowS, ColS] == 1))
                                Is = false;
                        }
                        else
                        if (ColS - 1 >= 0)
                        {
                            if ((Table[RowS, ColS - 1] == 1 && Table[RowS, ColS] == 1))
                                Is = false;
                        }
                    }
                    else
                    {
                        if (ColS + 1 < 8)
                        {
                            if ((Table[RowS, ColS + 1] == -1 && Table[RowS, ColS] == -1))
                                Is = false;
                        }
                        else
                      if (ColS - 1 >= 0)
                        {
                            if ((Table[RowS, ColS - 1] == -1 && Table[RowS, ColS] == -1))
                                Is = false;
                        }
                    }
                }
                if (!Is)
                {
                    bool IsSuported = false;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (Order == 1 && Table[i, j] <= 0)
                                continue;
                            if (Order == -1 && Table[i, j] >= 0)
                                continue;
                            if (Math.Abs(Table[RowS, ColS]) == 1 && SameSign(Table[RowS, ColS], Table[i, j]))
                            {
                                bool ab = false;
                                var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), i, j, RowS, ColS, color, Order));
                                th.Wait();
                                th.Dispose();
                                if (ab)
                                {
                                    IsSuported = true;
                                    break;
                                }
                            }
                            else
                            if (Math.Abs(Table[RowD, ColD]) == 1 && SameSign(Table[RowD, ColD], Table[i, j]))
                            {
                                bool ab = false;
                                var th = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), i, j, RowD, ColD, color, Order));
                                th.Wait();
                                th.Dispose();
                                if (ab)
                                {
                                    IsSuported = true;
                                    break;
                                }
                            }
                        }
                        if (IsSuported)
                            break;
                    }
                    Is = (!IsSuported);
                }
                return Is;
            }
        }
        //when pawn move to center by no reducedattack rational regard and heuristic of attacked and "IsPawnIsolatedOrDoubleBackAwayOrHung" rational penalty
        public int HeuristicObjectAtCenterAndPawnAttackTraversalObjectsAndDangourForEnemy(int[,] Table, Color aa, int Ord, int ii, int jj, int i, int j)
        {
            Object O = new Object();
            lock (O)
            {
                int HA = 0;
                Object O1 = new Object();
                lock (O1)
                {
                    if ((i == 3 || i == 4) && (j == 3 || j == 4) && HeuristicAllReducedAttacked.Count == 0)
                    {
                        HA = RationalRegard;
                    }
                    else
                    if ((i == 3 || i == 4) && (j == 3 || j == 4) && HeuristicAllReducedAttacked.Count != 0)
                        HA = RationalPenalty;
                    if (HA == 0)
                    {
                        int[,] Ta = CloneATable(Table);
                        bool Before = false;
                        if (Order == 1)
                        {
                            if (Ta[ii, jj] != 0)
                            {
                                Ta[i, j] = Ta[ii, jj];
                                Ta[ii, jj] = 0;
                                Before = true;
                            }
                            if (Ta[i, j] == 1)
                                HA += HeuristicAttack(Before, CloneATable(Ta), Ord, aa, ii, jj, i, j);
                        }
                        else
                        {
                            if (Ta[ii, jj] != 0)
                            {
                                Ta[i, j] = Ta[ii, jj];
                                Ta[ii, jj] = 0;
                                Before = true;
                            }
                            if (Ta[i, j] == -1)
                                HA += HeuristicAttack(Before, CloneATable(Ta), Ord, aa, ii, jj, i, j);
                        }
                    }
                    if (IsPawnIsolatedOrDoubleBackAwayOrHung(ii, jj, i, j, CloneATable(Table), Order))
                        HA += RationalPenalty;

                }
                return HA;
            }
        }
        //color by order specified
        Color OrderColor(int Ord)
        {
            Object O = new Object();
            lock (O)
            {
                Color a = Color.Gray;
                if (Ord == -1)
                    a = Color.Brown;
                return a;
            }
        }
        //permit mehod suit for heuristicexchange
        bool Permit(int Order, int TabS, int TabD, bool Self = true, bool Move = false)
        {
            Object O = new Object();
            lock (O)
            {
                bool Per = false;
                if (Self)
                {
                    if (Move)
                    {
                        if (Order == 1 && TabS > 0 && TabD == 0)
                            Per = true;
                        if (Order == -1 && TabS < 0 && TabD == 0)
                            Per = true;
                    }
                    else
                    {
                        if (Order == 1 && TabS > 0 && TabD > 0)
                            Per = true;
                        if (Order == -1 && TabS < 0 && TabD < 0)
                            Per = true;
                    }
                }
                else
                {
                    if (Move)
                    {
                        if (Order == 1 && TabS > 0 && TabD <= 0)
                            Per = true;
                        if (Order == -1 && TabS < 0 && TabD >= 0)
                            Per = true;
                    }
                    else
                    {
                        if (Order == 1 && TabS > 0 && TabD < 0)
                            Per = true;
                        if (Order == -1 && TabS < 0 && TabD > 0)
                            Per = true;
                    }
                }
                return Per;
            }
        }
        //specific method for calculation of differential tow object
        int Diff(int Obj1, int Obj2, bool Penalty = true)
        {
            Object O = new Object();
            lock (O)
            {
                int df = Obj1 - Obj2;
                if (Penalty)
                {
                    if (Math.Abs(Obj1) > Math.Abs(Obj2))
                        return 12 - Math.Abs(df) + 1;
                    else
                        return Math.Abs(df) + 1;
                }
                else
                {
                    if (Math.Abs(Obj1) > Math.Abs(Obj2))
                        return Math.Abs(df) + 1;
                    else
                        return 12 - Math.Abs(df) + 1;
                }
            }
        }
        //specific method for calculation of differential tow object second kind
        int DiffSupport(int Obj1, int Obj2)
        {
            Object O = new Object();
            lock (O)
            {
                int df = Obj1 - Obj2;
                return Math.Abs(df) + 1;
            }
        }
        //all heuristics  of attacked and reduced attacked ans supported and reduced attacked
        public int[] HeuristicAll(bool Before, int Killed, int[,] Table, Color aa, int Ord)
        {

            Object O = new Object();
            lock (O)
            {
                int[] HeuristicA = new int[6];
                int[] HeuristicB = new int[6];
                int HA = 0;
                int DumOrder = Order;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                ///When AStarGreedy Heuristic is Not Assigned.
                Object O1 = new Object();
                lock (O1)
                {
                    var output = Task.Factory.StartNew(() =>
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, RowS =>
 {
     ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, ColS =>
     {
         ParallelOptions pooo = new ParallelOptions(); pooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, RowD =>
         {
             ParallelOptions poooo = new ParallelOptions(); poooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, ColD =>
             {
                 if (IsDistributedObjectAttackNonDistributedEnemyObject(Before, CloneATable(Table), Ord, aa, RowS, ColS, RowD, ColD))
                 {
                     HA += RationalPenalty;
                     return;
                 }

                 ParallelOptions pooooo = new ParallelOptions(); pooooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
                 {
                     Object OO = new Object();
                     lock (OO)
                     {
                         if (HeuristicA[0] == 0)
                         {
                             bool ab = false;
                             var th = Task.Factory.StartNew(() => ab = Permit(Order * -1, Table[RowD, ColD], Table[RowS, ColS], false, false));
                             th.Wait();
                             th.Dispose();
                             if (ab)
                             {
                                 var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowD, ColD, RowS, ColS, OrderColor(Ord * -1), Ord * -1));
                                 th1.Wait();
                                 th1.Dispose();
                                 if (ab)
                                 {
                                     if (HeuristicA[0] == 0)
                                         HeuristicA[0] = RationalPenalty;
                                     HeuristicB[0] += RationalPenalty;
                                 }
                             }
                         }
                     }
                 }
                 , () =>
                 {
                     if (HeuristicA[2] == 0)
                     {
                         bool ab = false;
                         var th = Task.Factory.StartNew(() => ab = Permit(Order * -1, Table[RowD, ColD], Table[RowS, ColS], true, false));
                         th.Wait();
                         th.Dispose();
                         if (ab)
                         {
                             var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), RowD, ColD, RowS, ColS, OrderColor(Ord * -1), Ord * -1));
                             th1.Wait();
                             th1.Dispose();
                             if (ab)
                             {
                                 if (HeuristicA[2] == 0)
                                     HeuristicA[2] = RationalPenalty;
                                 HeuristicB[2] += RationalPenalty;
                             }
                         }
                     }
                 }
                 , () =>
                 {
                     if (HeuristicA[1] == 0)
                     {
                         bool ab = false;
                         var th = Task.Factory.StartNew(() => ab = Permit(Order, Table[RowS, ColS], Table[RowD, ColD], false, false));
                         th.Wait();
                         th.Dispose();
                         if (ab)
                         {
                             var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowS, ColS, RowD, ColD, OrderColor(Ord), Ord));
                             th1.Wait();
                             th1.Dispose();
                             if (ab)
                             {
                                 if (HeuristicA[1] == 0)
                                     HeuristicA[1] = RationalRegard;
                                 HeuristicB[1] += RationalRegard;
                             }
                         }
                     }
                 }
                  , () =>
                  {
                      if (HeuristicA[3] == 0)
                      {
                          bool ab = false;
                          var th = Task.Factory.StartNew(() => ab = Permit(Order, Table[RowS, ColS], Table[RowD, ColD], true, false));
                          th.Wait();
                          th.Dispose();
                          if (ab)
                          {
                              var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), RowS, ColS, RowD, ColD, OrderColor(Ord), Ord));
                              th1.Wait();
                              th1.Dispose();
                              if (ab)
                              {
                                  if (HeuristicA[3] == 0)
                                      HeuristicA[3] = RationalRegard;
                                  HeuristicB[3] += RationalRegard;
                              }
                          }
                      }
                  });
             });
         });
     });
 });
                    });

                    output.Wait(); output.Dispose();
                }
                return HeuristicA;

            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInMoveList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllMove.Count; i++)
                    {
                        if (HeuristicAllMove[i][0] == Rows && HeuristicAllMove[i][1] == Cols && HeuristicAllMove[i][2] == Rowd && HeuristicAllMove[i][3] == Cold)
                            Is++;
                    }
                }
                else
                {
                    if (HeuristicAllMoveMidel > 0 && HeuristicAllMoveMidel < HeuristicAllMove.Count)
                    {
                        for (int i = HeuristicAllMoveMidel; i < HeuristicAllMove.Count; i++)
                        {
                            if (HeuristicAllMove[i][0] == Rows && HeuristicAllMove[i][1] == Cols && HeuristicAllMove[i][2] == Rowd && HeuristicAllMove[i][3] == Cold)
                                Is++;
                        }
                    }
                }
                return Is;
            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInReducedMoveList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllReducedMove.Count; i++)
                    {
                        if (HeuristicAllReducedMove[i][2] == Rows && HeuristicAllReducedMove[i][3] == Cols && HeuristicAllReducedMove[i][0] == Rowd && HeuristicAllReducedMove[i][1] == Cold)
                            Is++;
                    }
                }
                else
                {
                    if (HeuristicAllReducedMoveMidel > 0 && HeuristicAllReducedMoveMidel < HeuristicAllReducedMove.Count)
                    {
                        for (int i = HeuristicAllReducedMoveMidel; i < HeuristicAllReducedMove.Count; i++)
                        {
                            if (HeuristicAllReducedMove[i][2] == Rows && HeuristicAllReducedMove[i][3] == Cols && HeuristicAllReducedMove[i][0] == Rowd && HeuristicAllReducedMove[i][1] == Cold)
                                Is++;
                        }
                    }
                }
                return Is;
            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInAttackList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllAttacked.Count; i++)
                    {
                        if (HeuristicAllAttacked[i][0] == Rows && HeuristicAllAttacked[i][1] == Cols && HeuristicAllAttacked[i][2] == Rowd && HeuristicAllAttacked[i][3] == Cold)
                            Is++;
                    }
                }
                else
                {
                    if (HeuristicAllAttackedMidel > 0 && HeuristicAllAttackedMidel < HeuristicAllAttacked.Count)
                    {
                        for (int i = HeuristicAllAttackedMidel; i < HeuristicAllAttacked.Count; i++)
                        {
                            if (HeuristicAllAttacked[i][0] == Rows && HeuristicAllAttacked[i][1] == Cols && HeuristicAllAttacked[i][2] == Rowd && HeuristicAllAttacked[i][3] == Cold)
                                Is++;
                        }
                    }
                }
                return Is;
            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInReducedAttackList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllReducedAttacked.Count; i++)
                    {
                        if (HeuristicAllReducedAttacked[i][2] == Rows && HeuristicAllReducedAttacked[i][3] == Cols && HeuristicAllReducedAttacked[i][0] == Rowd && HeuristicAllReducedAttacked[i][1] == Cold)
                            Is++;
                    }
                }
                else
                {
                    if (HeuristicAllReducedAttackedMidel > 0 && HeuristicAllReducedAttackedMidel < HeuristicAllReducedAttacked.Count)
                    {
                        for (int i = HeuristicAllReducedAttackedMidel; i < HeuristicAllReducedAttacked.Count; i++)
                        {
                            if (HeuristicAllReducedAttacked[i][2] == Rows && HeuristicAllReducedAttacked[i][3] == Cols && HeuristicAllReducedAttacked[i][0] == Rowd && HeuristicAllReducedAttacked[i][1] == Cold)
                                Is++;
                        }
                    }
                }
                return Is;
            }
        }
        List<int[]> ListOfExistInReducedAttackList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                List<int[]> Is = new List<int[]>();
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllReducedAttacked.Count; i++)
                    {
                        if (HeuristicAllReducedAttacked[i][2] == Rows && HeuristicAllReducedAttacked[i][3] == Cols && HeuristicAllReducedAttacked[i][0] == Rowd && HeuristicAllReducedAttacked[i][1] == Cold)
                        {
                            int[] I = new int[5];
                            I[0] = HeuristicAllReducedAttacked[i][0];
                            I[1] = HeuristicAllReducedAttacked[i][1];
                            I[2] = HeuristicAllReducedAttacked[i][2];
                            I[3] = HeuristicAllReducedAttacked[i][3];
                            I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                            Is.Add(I);
                        }
                    }
                }
                else
                {
                    if (HeuristicAllReducedAttackedMidel > 0 && HeuristicAllReducedAttackedMidel < HeuristicAllReducedAttacked.Count)
                    {
                        for (int i = HeuristicAllReducedAttackedMidel; i < HeuristicAllReducedAttacked.Count; i++)
                        {
                            if (HeuristicAllReducedAttacked[i][2] == Rows && HeuristicAllReducedAttacked[i][3] == Cols && HeuristicAllReducedAttacked[i][0] == Rowd && HeuristicAllReducedAttacked[i][1] == Cold)
                            {
                                int[] I = new int[5];
                                I[0] = HeuristicAllReducedAttacked[i][0];
                                I[1] = HeuristicAllReducedAttacked[i][1];
                                I[2] = HeuristicAllReducedAttacked[i][2];
                                I[3] = HeuristicAllReducedAttacked[i][3];
                                I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                                Is.Add(I);
                            }
                        }
                    }
                }
                return Is;
            }
        }
        List<int[]> ListOfExistInReducedSupportList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            List<int[]> Is = new List<int[]>();
            if (Before)
            {
                for (int i = 0; i < HeuristicAllReducedSupport.Count; i++)
                {
                    if (HeuristicAllReducedSupport[i][2] == Rows && HeuristicAllReducedSupport[i][3] == Cols && HeuristicAllReducedSupport[i][0] == Rowd && HeuristicAllReducedSupport[i][1] == Cold)
                    {
                        int[] I = new int[5];
                        I[0] = HeuristicAllReducedSupport[i][0];
                        I[1] = HeuristicAllReducedSupport[i][1];
                        I[2] = HeuristicAllReducedSupport[i][2];
                        I[3] = HeuristicAllReducedSupport[i][3];
                        I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                        Is.Add(I);
                    }
                }
            }
            else
            {
                if (HeuristicAllReducedSupportMidel > 0 && HeuristicAllReducedSupportMidel < HeuristicAllReducedSupport.Count)
                {
                    for (int i = HeuristicAllReducedSupportMidel; i < HeuristicAllReducedSupport.Count; i++)
                    {
                        if (HeuristicAllReducedSupport[i][2] == Rows && HeuristicAllReducedSupport[i][3] == Cols && HeuristicAllReducedSupport[i][0] == Rowd && HeuristicAllReducedSupport[i][1] == Cold)
                        {
                            int[] I = new int[5];
                            I[0] = HeuristicAllReducedSupport[i][0];
                            I[1] = HeuristicAllReducedSupport[i][1];
                            I[2] = HeuristicAllReducedSupport[i][2];
                            I[3] = HeuristicAllReducedSupport[i][3];
                            I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                            Is.Add(I);
                        }
                    }
                }
            }
            return Is;
        }
        List<int[]> ListOfExistInSupportList(bool Before, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                List<int[]> Is = new List<int[]>();
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllSupport.Count; i++)
                    {
                        if (HeuristicAllSupport[i][2] == RowD && HeuristicAllSupport[i][3] == ColD && HeuristicAllSupport[i][0] == RowS && HeuristicAllSupport[i][1] == ColS)
                        {
                            int[] I = new int[5];
                            I[0] = HeuristicAllSupport[i][0];
                            I[1] = HeuristicAllSupport[i][1];
                            I[2] = HeuristicAllSupport[i][2];
                            I[3] = HeuristicAllSupport[i][3];
                            I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                            Is.Add(I);
                        }
                    }
                }
                else
                {
                    if (HeuristicAllSupportMidel > 0 && HeuristicAllSupportMidel < HeuristicAllSupport.Count)
                    {
                        for (int i = HeuristicAllSupportMidel; i < HeuristicAllSupport.Count; i++)
                        {
                            if (HeuristicAllSupport[i][2] == RowD && HeuristicAllSupport[i][3] == ColD && HeuristicAllSupport[i][0] == RowS && HeuristicAllSupport[i][1] == ColS)
                            {
                                int[] I = new int[5];
                                I[0] = HeuristicAllSupport[i][0];
                                I[1] = HeuristicAllSupport[i][1];
                                I[2] = HeuristicAllSupport[i][2];
                                I[3] = HeuristicAllSupport[i][3];
                                I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                                Is.Add(I);
                            }
                        }
                    }
                }
                return Is;
            }
        }
        List<int[]> ListOfExistInAttackList(bool Before, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                List<int[]> Is = new List<int[]>();
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllAttacked.Count; i++)
                    {
                        if (HeuristicAllAttacked[i][2] == RowD && HeuristicAllAttacked[i][3] == ColD && HeuristicAllAttacked[i][0] == RowS && HeuristicAllAttacked[i][1] == ColS)
                        {
                            int[] I = new int[5];
                            I[0] = HeuristicAllAttacked[i][0];
                            I[1] = HeuristicAllAttacked[i][1];
                            I[2] = HeuristicAllAttacked[i][2];
                            I[3] = HeuristicAllAttacked[i][3];
                            I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                            Is.Add(I);
                        }
                    }
                }
                else
                {
                    if (HeuristicAllAttackedMidel > 0 && HeuristicAllAttackedMidel < HeuristicAllAttacked.Count)
                    {
                        for (int i = HeuristicAllAttackedMidel; i < HeuristicAllAttacked.Count; i++)
                        {
                            if (HeuristicAllAttacked[i][2] == RowD && HeuristicAllAttacked[i][3] == ColD && HeuristicAllAttacked[i][0] == RowS && HeuristicAllAttacked[i][1] == ColS)
                            {
                                int[] I = new int[5];
                                I[0] = HeuristicAllAttacked[i][0];
                                I[1] = HeuristicAllAttacked[i][1];
                                I[2] = HeuristicAllAttacked[i][2];
                                I[3] = HeuristicAllAttacked[i][3];
                                I[4] = SignBeforNext(I[0], I[1], I[2], I[3]);
                                Is.Add(I);
                            }
                        }
                    }
                }
                return Is;
            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInSupportList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllSupport.Count; i++)
                    {
                        if (HeuristicAllSupport[i][0] == Rows && HeuristicAllSupport[i][1] == Cols && HeuristicAllSupport[i][2] == Rowd && HeuristicAllSupport[i][3] == Cold)
                            Is++;
                    }
                }
                else
                {
                    if (HeuristicAllSupportMidel > 0 && HeuristicAllSupportMidel < HeuristicAllSupport.Count)
                    {
                        for (int i = HeuristicAllSupportMidel; i < HeuristicAllSupport.Count; i++)
                        {
                            if (HeuristicAllSupport[i][0] == Rows && HeuristicAllSupport[i][1] == Cols && HeuristicAllSupport[i][2] == Rowd && HeuristicAllSupport[i][3] == Cold)
                                Is++;
                        }
                    }
                }
                return Is;
            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInReducedSupportList(bool Before, int Rows, int Cols, int Rowd, int Cold)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                if (Before)
                {
                    for (int i = 0; i < HeuristicAllReducedSupport.Count; i++)
                    {
                        if (HeuristicAllReducedSupport[i][2] == Rows && HeuristicAllReducedSupport[i][3] == Cols && HeuristicAllReducedSupport[i][0] == Rowd && HeuristicAllReducedSupport[i][1] == Cold)
                            Is++;
                    }
                }
                else
                {
                    if (HeuristicAllReducedSupportMidel > 0 && HeuristicAllReducedSupportMidel < HeuristicAllReducedSupport.Count)
                    {
                        for (int i = HeuristicAllReducedSupportMidel; i < HeuristicAllReducedSupport.Count; i++)
                        {
                            if (HeuristicAllReducedSupport[i][2] == Rows && HeuristicAllReducedSupport[i][3] == Cols && HeuristicAllReducedSupport[i][0] == Rowd && HeuristicAllReducedSupport[i][1] == Cold)
                                Is++;
                        }
                    }
                }
                return Is;
            }
        }
        //number of exists of move situation in Heuristic lists 
        int NoOfExistInSupportList(bool Before, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                int Is = 0;
                for (int Rows = 0; Rows < 8; Rows++)
                {
                    for (int Cols = 0; Cols < 8; Cols++)
                    {
                        if (Before)
                        {
                            for (int i = 0; i < HeuristicAllSupport.Count; i++)
                            {
                                if (HeuristicAllSupport[i][0] == Rows && HeuristicAllSupport[i][1] == Cols && HeuristicAllSupport[i][2] == RowD && HeuristicAllSupport[i][3] == ColD)
                                    Is++;
                            }
                        }
                        else
                        {
                            if (HeuristicAllSupportMidel > 0 && HeuristicAllSupportMidel < HeuristicAllSupport.Count)
                            {
                                for (int i = HeuristicAllSupportMidel; i < HeuristicAllSupport.Count; i++)
                                {
                                    if (HeuristicAllSupport[i][0] == Rows && HeuristicAllSupport[i][1] == Cols && HeuristicAllSupport[i][2] == RowD && HeuristicAllSupport[i][3] == ColD)
                                        Is++;
                                }
                            }
                        }
                    }
                }
                return Is;
            }
        }
        //promotion heuristic on pawn
        int HeuristicPromotion(bool Before, int[,] Tab, int Order, int Ros, int Cos, int Rod, int Cod)
        {
            Object O = new Object();
            lock (O)
            {
                int HP = 0;
                if (Order == 1)
                {
                    if (Cod != 0)
                        return HP;
                    if (TableConst[Ros, Cos] == 1 && Tab[Rod, Cod] > 0)
                    {
                        HP = ((RationalRegard) * (NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod)) + ((RationalPenalty) * (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))));
                    }
                }
                else
                {
                    if (Cod != 7)
                        return HP;
                    if (TableConst[Ros, Cos] == -1 && Tab[Rod, Cod] < 0)
                    {
                        HP = ((RationalRegard) * (NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod)) + ((RationalPenalty) * (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))));
                    }
                }
                return HP;
            }
        }
        //heuristic on trying open elephant of self to move
        int HeuristicElephantOpen(bool Before, int[,] Tab, int Order, int Ros, int Cos, int Rod, int Cod)
        {
            Object O = new Object();
            lock (O)
            {
                int HE = 0;
                if (Order == 1)
                {
                    if (TableConst[Ros, Cos] == 2 && Tab[Rod, Cod] <= 0)
                    {
                        HE = ((RationalRegard) * (NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod)) + ((RationalPenalty) * (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))));
                        if (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) == 0)
                            HE *= NoOfExistInMoveList(Before, Ros, Cos, Rod, Cod);
                    }
                }
                else
                {
                    if (TableConst[Ros, Cos] == -2 && Tab[Rod, Cod] >= 0)
                    {
                        HE = ((RationalRegard) * (NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod)) + ((RationalPenalty) * (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))));
                        if (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) == 0)
                            HE *= NoOfExistInMoveList(Before, Ros, Cos, Rod, Cod);
                    }
                }
                return HE;
            }
        }
        //safety of self hourse by value.
        int HeuristicHourseCloseBaseOfWeakHourseIsWhereIsHomeStrong(bool Before, int[,] Tab, int Order, int Ros, int Cos, int Rod, int Cod)
        {
            Object O = new Object();
            lock (O)
            {
                int HH = 0;
                if (Order == 1)
                {
                    if (TableConst[Ros, Cos] == 3 && Tab[Rod, Cod] <= 0)
                    {
                        //Base of weak hourse is where is Home strong.
                        HH = ((RationalRegard) * (NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod)) + ((RationalPenalty) * (128 - NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))));
                        //Hourse close
                        if (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) == 0)
                            HH *= (64 - NoOfExistInMoveList(Before, Ros, Cos, Rod, Cod));
                    }
                }
                else
                {
                    if (TableConst[Ros, Cos] == -3 && Tab[Rod, Cod] >= 0)
                    {
                        //Base of weak hourse is where is Home strong.
                        HH = ((RationalRegard) * (NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod)) + ((RationalPenalty) * (128 - NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))));
                        //Hourse close
                        if (NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) == 0)
                            HH *= (64 - NoOfExistInMoveList(Before, Ros, Cos, Rod, Cod));
                    }
                }
                return HH;
            }
        }
        bool AssignAAndList(int ros, int cos, int rod, int cod, ref List<int[]> T)
        {
            object o = new object();
            lock (o)
            {
                try
                {
                    int[] A = new int[5];
                    A[0] = ros;
                    A[1] = cos;
                    A[2] = rod;
                    A[3] = cod;
                    A[4] = SignBeforNext(ros, cos, rod, cod);
                    T.Add(A);
                }
                catch (Exception g)
                {
                    Log(g);
                    return false;
                }
            }
            return true;
        }
        bool HeuristicExchangHeuristicAllReducedAttacked(int Ord, int RowS, int ColS, int RowD, int ColD, int[,] Table)
        {
            Object OO = new Object();
            lock (OO)
            {
                try
                {

                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Permit(Ord * -1, Table[RowD, ColD], Table[RowS, ColS], false, false));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowD, ColD, RowS, ColS, OrderColor(Ord * -1), Ord * -1));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {
                            Object OOO = new Object();
                            lock (OOO)
                            {
                                AssignAAndList(RowD, ColD, RowS, ColS, ref HeuristicAllReducedAttacked);
                                return true;
                            }
                        }

                    }



                }
                catch (Exception d)
                {
                    return false;
                }
            }
            return false;
        }
        bool HeuristicExchangeHeuristicAllReducedSupport(int Ord, int RowS, int ColS, int RowD, int ColD, int[,] Table)
        {
            Object OO = new Object();
            lock (OO)
            {
                try
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Permit(Ord * -1, Table[RowD, ColD], Table[RowS, ColS], true, false));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), RowD, ColD, RowS, ColS, OrderColor(Ord * -1), Ord * -1));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {

                            Object OOO = new Object();
                            lock (OOO)
                            {
                                AssignAAndList(RowD, ColD, RowS, ColS, ref HeuristicAllReducedSupport);
                                return true;
                            }
                        }
                    }
                }
                catch (Exception d)
                {
                    return false;
                }
            }
            return false;
        }
        bool HeuristicExchangeHeuristicAllReducedMove(int Ord, int RowS, int ColS, int RowD, int ColD, int[,] Table)
        {
            Object OO = new Object();
            lock (OO)
            {
                try
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Permit(Ord * -1, Table[RowD, ColD], Table[RowS, ColS], true, true));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        var th1 = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), RowD, ColD, RowS, ColS, OrderColor(Ord * -1), Ord * -1));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {

                            Object OOO = new Object();
                            lock (OOO)
                            {
                                AssignAAndList(RowD, ColD, RowS, ColS, ref HeuristicAllReducedMove);
                                return true;
                            }
                        }
                    }
                }
                catch (Exception d)
                {
                    return false;
                }
            }
            return false;
        }
        bool HeuristicExchangeHeuristicAllAttacked(int Ord, int RowS, int ColS, int RowD, int ColD, int[,] Table)
        {
            Object OO = new Object();
            lock (OO)
            {
                try
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Permit(Ord, Table[RowS, ColS], Table[RowD, ColD], false, false));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        var th1 = Task.Factory.StartNew(() => ab = Attack(CloneATable(Table), RowS, ColS, RowD, ColD, OrderColor(Ord), Ord));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {
                            Object OOO = new Object();
                            lock (OOO)
                            {
                                AssignAAndList(RowS, ColS, RowD, ColD, ref HeuristicAllAttacked);
                                return true;
                            }
                        }
                    }
                }
                catch (Exception d)
                {
                    return false;
                }
            }
            return false;
        }
        bool HeuristicExchangeHeuristicAllSupport(int Ord, int RowS, int ColS, int RowD, int ColD, int[,] Table)
        {
            Object OO = new Object();
            lock (OO)
            {
                try
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Permit(Ord, Table[RowS, ColS], Table[RowD, ColD], true, false));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(Table), RowS, ColS, RowD, ColD, OrderColor(Ord), Ord));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {
                            Object OOO = new Object();
                            lock (OOO)
                            {
                                AssignAAndList(RowS, ColS, RowD, ColD, ref HeuristicAllSupport);
                                return true;
                            }
                        }

                    }
                }
                catch (Exception d)
                {
                    return false;
                }
            }
            return false;
        }
        bool HeuristicExchangeHeuristicAllMove(int Ord, int RowS, int ColS, int RowD, int ColD, int[,] Table)
        {
            Object OO = new Object();
            lock (OO)
            {
                try
                {
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = Permit(Ord, Table[RowS, ColS], Table[RowD, ColD], true, true));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {

                        var th1 = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), RowS, ColS, RowD, ColD, OrderColor(Ord), Ord));
                        th1.Wait();
                        th1.Dispose();
                        if (ab)
                        {
                            Object OOO = new Object();
                            lock (OOO)
                            {
                                AssignAAndList(RowS, ColS, RowD, ColD, ref HeuristicAllMove);
                                return true;
                            }
                        }

                    }
                }
                catch (Exception d)
                {
                    return false;
                }
            }
            return false;
        }
        //create heuristic and lists of move and reduced move and attack and reduced attack and support and reduced support
        public int[] HeuristicExchange(bool Before, int Killed, int[,] Table, Color aa, int Ord, int Ros, int Cos, int Rod, int Cod)
        {

            Object O = new Object();
            lock (O)
            {
                int[,] RemobeActiveDenfesiveObjectsOfEnemy = new int[8, 8];
                const int ToSupport = 3, ReducedAttacked = 0, ReducedSupport = 2, ReducedMove = 5, ToAttacked = 1, ToMoved = 4;
                int[] Exchange = new int[6];
                int[] ExchangeSeed = new int[3];
                int DumOrd = Ord;
                int DummyOrd = Ord;
                int DummyCurrentOrd = ChessRules.CurrentOrder;


                ///When AStarGreedy Exchange is Not Assigned.
                Object O1 = new Object();
                lock (O1)
                {


                    ParallelOptions poop = new ParallelOptions(); poop.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, RowS =>
                     {
                         ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, ColS =>
                         {
                             ParallelOptions pooo = new ParallelOptions(); pooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, RowD =>
                             {
                                 ParallelOptions poooo = new ParallelOptions(); poooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, 8, ColD =>
                                 {
                                     Object o = new Object();
                                     lock (o)
                                     {
                                         if (Table[RowS, ColS] == 0 && Table[RowD, ColD] == 0)
                                             return;
                                         var output = Task.Factory.StartNew(() =>
                                         {
                                             var H70 = Task.Factory.StartNew(() => ExchangeE(Before, Ord, ref Exchange, ToSupport, ReducedSupport, ReducedAttacked, ToAttacked, ReducedMove, ToMoved, Table, RowS, ColS, RowD, ColD));
                                             H70.Wait();
                                             H70.Dispose();

                                         });
                                         output.Wait(); output.Dispose();
                                     }
                                 });

                             });
                         });
                     });





                }

                //When situation is closed
                var H71 = Task.Factory.StartNew(() => ExchangeA(Ord, ref ExchangeSeed, Exchange, ToSupport, ReducedSupport, ReducedAttacked));
                H71.Wait();
                H71.Dispose();
                //when situation is closed and restriction
                var H72 = Task.Factory.StartNew(() => ExchangeB(Ord, ref ExchangeSeed, Exchange, ToSupport, ReducedSupport, ReducedAttacked, ToAttacked));
                H72.Wait();
                H72.Dispose();
                //Closed space remove
                int A1 = (Exchange[ToAttacked] + Exchange[ToSupport] + Exchange[ToMoved]);
                //penalties
                int A2 = A1 + (Exchange[ReducedAttacked] + Exchange[ReducedSupport] + Exchange[ReducedMove]);
                ExchangeSeed[2] = (int)(((double)RationalPenalty) * ((((double)(A2)) / 64.0)));

                //When victorian of self on enemy to consideration of weaker self traversal object at active enemy strong traversal
                var H73 = Task.Factory.StartNew(() => ExchangeC(Ord, aa, ref ExchangeSeed, Exchange, ToSupport, ReducedSupport, ReducedAttacked, ToAttacked, Table, Ros, Cos, Rod, Cod));
                H73.Wait();
                H73.Dispose();
                //Simplification of mathematic method when we have victories
                double ExchangedOfGameSimplification = (double)(Exchange[ToSupport] - Exchange[ReducedSupport] + Exchange[ToAttacked] - Exchange[ReducedSupport]);
                double MAX = 64.0;
                ExchangeSeed[2] += (int)(((double)(RationalRegard)) * (ExchangedOfGameSimplification / MAX));
                //Remove of most impressive defensive enemy Objects
                var H74 = Task.Factory.StartNew(() => ExchangeD(Before, Ord, MAX, aa, ref ExchangeSeed, Exchange, RemobeActiveDenfesiveObjectsOfEnemy, ToSupport, ReducedSupport, ReducedAttacked, ToAttacked, Table, Ros, Cos, Rod, Cod));
                H74.Wait();
                H74.Dispose();
                //Safty before Attack
                var H7 = Task.Factory.StartNew(() => ExchangeSeed[2] += (RationalPenalty * (NoOfExistInReducedMoveList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInReducedSupportList(Before, Ros, Cos, Rod, Cod))) + (RationalRegard * (NoOfExistInMoveList(Before, Ros, Cos, Rod, Cod) + NoOfExistInAttackList(Before, Ros, Cos, Rod, Cod) + NoOfExistInSupportList(Before, Ros, Cos, Rod, Cod))));
                H7.Wait();
                H7.Dispose();
                Ord = DummyOrd;
                ChessRules.CurrentOrder = DummyCurrentOrd;
                Ord = DumOrd;
                //Initiate to Begin Call Ords.
                return ExchangeSeed;

            }
        }
        void ExchangeA(int Ord, ref int[] ExchangeSeed, int[] Exchange, int ToSupport, int ReducedSupport, int ReducedAttacked)
        {
            Object o = new Object();
            lock (o)
            {
                int A1 = 0;
                var H1 = Task.Factory.StartNew(() => A1 = IsSupportLessThanReducedSupport(Exchange[ToSupport], Exchange[ReducedSupport]));
                H1.Wait();
                H1.Dispose();
                if (A1 > 0)
                    ExchangeSeed[0] = RationalPenalty;
                else
                if (A1 < 0 && Exchange[ReducedSupport] == 0)
                    ExchangeSeed[0] = RationalRegard;
                else//When reinforcment arrangments is Ok
                {
                    if (Ord != AllDraw.OrderPlate)
                    {
                        if (IKIsCentralPawnIsOk && Exchange[ReducedAttacked] == 0)
                        {
                            ExchangeSeed[0] += RationalRegard;
                        }
                        else
                        {
                            if (IKIsCentralPawnIsOk && Exchange[ReducedAttacked] != 0)
                            {
                                ExchangeSeed[0] += RationalPenalty;
                            }
                        }
                    }
                }
            }
        }
        void ExchangeB(int Ord, ref int[] ExchangeSeed, int[] Exchange, int ToSupport, int ReducedSupport, int ReducedAttacked, int ToAttacked)
        {
            Object o = new Object();
            lock (o)
            {
                int A1 = 0;
                var H2 = Task.Factory.StartNew(() => A1 = IsAttackLessThanReducedAttack(Exchange[ToAttacked], Exchange[ReducedAttacked]));
                H2.Wait();
                H2.Dispose();
                if (A1 > 0)
                    ExchangeSeed[1] = RationalPenalty;
                else
                if (A1 < 0 && Exchange[ReducedAttacked] == 0)
                    ExchangeSeed[1] = RationalRegard;
            }
        }
        void ExchangeC(int Ord, Color aa, ref int[] ExchangeSeed, int[] Exchange, int ToSupport, int ReducedSupport, int ReducedAttacked, int ToAttacked, int[,] Table, int Ros, int Cos, int Rod, int Cod)
        {
            Object o = new Object();
            lock (o)
            {
                if (ExchangeSeed[0] + ExchangeSeed[1] + ExchangeSeed[2] >= 0)
                {
                    if (Exchange[ToSupport] - Exchange[ReducedSupport] + Exchange[ToAttacked] - Exchange[ReducedAttacked] > 0)
                    {
                        int HAA6 = 0;
                        Object O11 = new Object();
                        lock (O11)
                        {
                            int i6 = Ros, j6 = Cos, iiii6 = Rod, jjjj6 = Cod;
                            int[,] Table6 = CloneATable(Table);
                            int Ord6 = Ord;
                            Color aa6 = aa;
                            var H3 = Task.Factory.StartNew(() => HAA6 = HeuristicEnemySupported(Table6, Ord6, aa6, i6, j6, iiii6, jjjj6));
                            H3.Wait();
                            H3.Dispose();
                        }
                        if (HAA6 != 0)
                        {
                            if (System.Math.Abs(Table[Rod, Cod]) - System.Math.Abs(Table[Ros, Cos]) >= 2)
                            {
                                ExchangeSeed[0] += RationalRegard;
                            }
                        }
                        else
                        if (HAA6 == 0)
                        {
                            ExchangeSeed[0] += RationalRegard;
                        }
                    }

                }
            }
        }
        void ExchangeD(bool Before, int Ord, double MAX, Color aa, ref int[] ExchangeSeedA, int[] Exchange, int[,] RemobeActiveDenfesiveObjectsOfEnemy, int ToSupport, int ReducedSupport, int ReducedAttacked, int ToAttacked, int[,] Table, int Ros, int Cos, int Rod, int Cod)
        {
            Object o = new Object();
            lock (o)
            {
                int[] ExchangeSeed = ExchangeSeedA;
                double Defen = (double)(RemobeActiveDenfesiveObjectsOfEnemy[Ros, Cos] - RemobeActiveDenfesiveObjectsOfEnemy[Rod, Cod]);
                ExchangeSeed[2] += (int)(((double)(RationalRegard)) * (Defen / MAX) * 4);
                var H4 = Task.Factory.StartNew(() => ExchangeSeed[2] += HeuristicPromotion(Before, CloneATable(Table), Ord, Ros, Cos, Rod, Cod));
                H4.Wait();
                H4.Dispose();
                var H5 = Task.Factory.StartNew(() => ExchangeSeed[2] += HeuristicElephantOpen(Before, CloneATable(Table), Ord, Ros, Cos, Rod, Cod));
                H5.Wait();
                H5.Dispose();
                var H6 = Task.Factory.StartNew(() => ExchangeSeed[2] += HeuristicHourseCloseBaseOfWeakHourseIsWhereIsHomeStrong(Before, CloneATable(Table), Ord, Ros, Cos, Rod, Cod));
                H6.Wait();
                H6.Dispose();
                ExchangeSeedA = ExchangeSeed;

            }
        }
        void ExchangeE(bool Before, int Ord, ref int[] ExchangeA, int ToSupport, int ReducedSupport, int ReducedAttacked, int ToAttacked, int ReducedMove, int ToMoved, int[,] Table, int RowS, int ColS, int RowD, int ColD)
        {
            Object o = new Object();
            lock (o)
            {
                if (!Before || !ExcangePerformed)
                {
                    int[] Exchange = ExchangeA;

                    ParallelOptions pooooo = new ParallelOptions(); pooooo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
                     {

                         Object O11 = new Object();
                         lock (O11)
                         {
                             if (HeuristicExchangHeuristicAllReducedAttacked(Ord, RowS, ColS, RowD, ColD, Table))
                                 Exchange[ReducedAttacked]++;



                         }
                     }
                                             , () =>
                                             {
                                                 Object O11 = new Object();
                                                 lock (O11)
                                                 {



                                                     if (HeuristicExchangeHeuristicAllReducedSupport(Ord, RowS, ColS, RowD, ColD, Table))
                                                         Exchange[ReducedSupport]++;
                                                 }
                                             }
                                           , () =>

                                           {
                                               Object O11 = new Object();
                                               lock (O11)
                                               {

                                                   if (HeuristicExchangeHeuristicAllReducedMove(Ord, RowS, ColS, RowD, ColD, Table))
                                                       Exchange[ReducedMove]++;
                                               }
                                           }
                                                , () =>

                                                {

                                                    Object O11 = new Object();
                                                    lock (O11)
                                                    {
                                                        if (HeuristicExchangeHeuristicAllAttacked(Ord, RowS, ColS, RowD, ColD, Table))
                                                            Exchange[ToAttacked]++;
                                                    }

                                                }
                                                , () =>
                                                {
                                                    Object O11 = new Object();
                                                    lock (O11)
                                                    {

                                                        if (HeuristicExchangeHeuristicAllSupport(Ord, RowS, ColS, RowD, ColD, Table))
                                                            Exchange[ToSupport]++;
                                                    }
                                                }
                                                  , () =>

                                                  {

                                                      Object O11 = new Object();
                                                      lock (O11)
                                                      {

                                                          if (HeuristicExchangeHeuristicAllMove(Ord, RowS, ColS, RowD, ColD, Table))
                                                              Exchange[ToMoved]++;


                                                      }

                                                  });
                    ExchangeA = Exchange;
                    PerformedExchange = ExchangeA;
                    ExcangePerformed = true;
                }
                else
                    ExchangeA = PerformedExchange;

            }
        }
        //when objectS source less than destination
        bool IsObjectSourceLessThanDestination(int RowS, int ColS, int RowD, int ColD, int[,] TabS)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (TabS[RowS, ColS] < TabS[RowD, ColD])
                    Is = true;
                return Is;
            }
        }
        //when support less than reduced support
        int IsSupportLessThanReducedSupport(int Support, int ReducedSupport)
        {
            Object O = new Object();
            lock (O)
            {
                if (Support == 0)
                    return 0;
                if (Support < ReducedSupport)
                    return 1;
                else
                    if (Support > ReducedSupport)
                    return -1;
                return 0;
            }
        }
        //when attack less than reduced attack
        int IsAttackLessThanReducedAttack(int Attack, int ReducedAttack)
        {
            Object O = new Object();
            lock (O)
            {
                if (Attack == 0)
                    return 0;
                if (Attack < ReducedAttack)
                    return 1;
                else
                     if (Attack > ReducedAttack)
                    return -1;
                return 0;
            }
        }
        //when move less than reduced move
        int IsMoveLessThanReducedMove(int Move, int ReducedMove)
        {
            Object O = new Object();
            lock (O)
            {
                if (Move == 0)
                    return 0;
                if (Move < ReducedMove)
                    return 1;
                else
            if (Move > ReducedMove)
                    return -1;
                return 0;
            }
        }
        //Heuristic of Movments.
        public int HeuristicMovment(bool Before, int[,] Table, Color aa, int Ord, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                int HAS = 0;
                int HAE = 0;
                ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
 {
     var th = Task.Factory.StartNew(() => HAS = HeuristicMovmentSelf(Before, CloneATable(Table), aa, Ord, RowS, ColS, RowD, ColD));
     th.Wait();
     th.Dispose();
 }
 , () =>
 {
     var th = Task.Factory.StartNew(() => HAE = HeuristicMovmentEnemy(Before, CloneATable(Table), aa, Ord, RowS, ColS, RowD, ColD));
     th.Wait();
     th.Dispose();

 });
                return HAS + (HAE);
            }
        }
        //Heuristic of self Movments.
        public int HeuristicMovmentSelf(bool Before, int[,] Table, Color aa, int Ord, int RowS, int ColS, int RowD, int ColD)
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicMovementValue = 0;
                //Initiate Local Variable.
                int HA = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                ///When AStarGreedy Heuristic is Not Assigned.
                if (!AStarGreedyHeuristicT)
                {
                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    Order = DummyOrder;
                    int Sign = new int();
                    ///When Moveble is true. means [RowS,ColS] is in Movmebale to [RowD,ColD].
                    ///What is Moveable!
                    ///Ans:When [RowS,ColS] is Movebale to [RowD,ColD] continue true when Empty or Enemy is located in [RowS,ColS].
                    if (Table[RowD, ColD] == 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = -1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = -1;
                        }
                        a = Color.Brown;
                    }
                    else if (Table[RowD, ColD] == 0 && DummyOrder == 1 && Table[RowS, ColS] >= 0)
                    {
                        Order = 1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = 1;
                        }
                        a = Color.Gray;
                    }
                    else
                        return HeuristicMovementValue;
                    //if (Before)
                    {
                        //When is Movable Movement inCurrent.
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {
                            int[,] Tab = new int[8, 8];
                            for (var ik = 0; ik < 8; ik++)
                                for (var jk = 0; jk < 8; jk++)
                                    Tab[ik, jk] = Table[ik, jk];
                            HA += RationalRegard;
                            int Supported = 0;
                            int Attacked = 0;
                            //For All Enemy Obejcts.                                             
                            for (int g = 0; g < 8; g++)
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                            {
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                for (int h = 0; h < 8; h++)
                                {
                                    Object O2 = new Object();
                                    lock (O2)
                                    {
                                        //Ignore Of Self Objects.
                                        if (Order == 1 && Table[g, h] == 0)
                                            continue;
                                        if (Order == -1 && Table[g, h] == 0)
                                            continue;
                                        Color aaa = new Color();
                                        //Assgin Enemy ints.
                                        aaa = Color.Gray;
                                        if (Order * -1 == -1)
                                            aaa = Color.Brown;
                                        else
                                            aaa = Color.Gray;
                                        //When Enemy is Supported.
                                        bool A = new bool();
                                        bool B = new bool();
                                        var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Tab), g, h, RowS, ColS, a, Order));
                                        th1.Wait();
                                        th1.Dispose();



                                        var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Tab), g, h, RowD, ColD, aaa, Order * -1));
                                        th2.Wait();
                                        th2.Dispose();


                                        //When Enemy is Supported.
                                        if (B)
                                        {
                                            //Assgine variable.
                                            Attacked++;
                                        }
                                        if (A)
                                        {
                                            //Assgine variable.
                                            Supported++;
                                            continue;
                                        }
                                    }
                                }
                            }
                            Object O1 = new Object();
                            lock (O1)
                            {
                                if (Supported > 0 && Attacked == 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)System.Math.Pow(2, Supported);
                                else
                                //When is Supported Multyply -100.
                                if (Attacked > 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)(-(1 * System.Math.Pow(2, Attacked)));
                            }
                        }
                    }
                }
                //For All Homes Table.
                else
                {
                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    if (RowD == RowS && ColD == ColS)
                        return HeuristicMovementValue;
                    int Sign = new int();
                    Order = DummyOrder;
                    ///When Moveble is true. means [RowS,ColS] is in Movmebale to [RowD,ColD].
                    ///What is Moveable!
                    ///Ans:When [RowS,ColS] is Movebale to [RowD,ColD] continue true when Empty or Enemy is located in [RowS,ColS].
                    if (Table[RowD, ColD] == 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = -1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = -1;
                            a = Color.Brown;
                        }
                    }
                    else if (Table[RowD, ColD] == 0 && DummyOrder == 1 && Table[RowS, ColS] >= 0)
                    {
                        Order = 1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = 1;
                            a = Color.Gray;
                        }
                    }
                    else
                        return HeuristicMovementValue;
                    //if (Before)
                    {
                        //When is Movable Movement inCurrent.
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {

                            HA += RationalRegard;
                            int Supported = 0;
                            int Attacked = 0;
                            //For All Enemy Obejcts.                                             
                            for (int g = 0; g < 8; g++)
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                            {
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                for (int h = 0; h < 8; h++)
                                {
                                    Object O2 = new Object();
                                    lock (O2)
                                    {
                                        //Ignore Of Self Objects.
                                        if (Order == 1 && Table[g, h] == 0)
                                            continue;
                                        if (Order == -1 && Table[g, h] == 0)
                                            continue;
                                        Color aaa = new Color();
                                        //Assgin Enemy ints.
                                        aaa = Color.Gray;
                                        if (Order * -1 == -1)
                                            aaa = Color.Brown;
                                        else
                                            aaa = Color.Gray;
                                        //When Enemy is Supported.
                                        bool A = new bool();
                                        bool B = new bool();
                                        var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Table), g, h, RowS, ColS, a, Order));
                                        th1.Wait();
                                        th1.Dispose();



                                        var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Table), g, h, RowD, ColD, aaa, Order * -1));
                                        th2.Wait();
                                        th2.Dispose();

                                        //When Enemy is Supported.
                                        if (B)
                                        {
                                            //Assgine variable.
                                            Attacked++;
                                        }
                                        if (A)
                                        {
                                            //Assgine variable.
                                            Supported++;
                                            continue;
                                        }
                                    }
                                }
                            }
                            Object O1 = new Object();
                            lock (O1)
                            {
                                if (Supported > 0 && Attacked == 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)System.Math.Pow(2, Supported);
                                else
                              //When is Supported Multyply -100.
                              if (Attacked > 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)(-(1 * System.Math.Pow(2, Attacked)));
                            }
                        }
                    }
                }
                //Reassignments of Begin Call Global Orders.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                //Store Local Heuristic in Global One.
                return HA * 1;
            }
        }
        //Heuristic of enemy Movments.
        public int HeuristicMovmentEnemy(bool Before, int[,] Table, Color aa, int Ord, int RowD, int ColD, int RowS, int ColS)
        {
            Object O = new Object();
            lock (O)
            {
                int HeuristicMovementValue = 0;
                //Initiate Local Variable.
                int HA = 0;
                int DummyOrder = Order;
                int DummyCurrentOrder = ChessRules.CurrentOrder;
                ///When AStarGreedy Heuristic is Not Assigned.
                if (!AStarGreedyHeuristicT)
                {
                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    Order = DummyOrder;
                    int Sign = new int();
                    ///When Moveble is true. means [RowS,ColS] is in Movmebale to [RowD,ColD].
                    ///What is Moveable!
                    ///Ans:When [RowS,ColS] is Movebale to [RowD,ColD] continue true when Empty or Enemy is located in [RowS,ColS].
                    if (Table[RowD, ColD] == 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = -1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = -1;
                        }
                        a = Color.Brown;
                    }
                    else if (Table[RowD, ColD] == 0 && DummyOrder == 1 && Table[RowS, ColS] >= 0)
                    {
                        Order = 1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = 1;
                        }
                        a = Color.Gray;
                    }
                    else
                        return HeuristicMovementValue;
                    //if (Before)
                    {
                        //When is Movable Movement inCurrent.
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {
                            int[,] Tab = new int[8, 8];
                            for (var ik = 0; ik < 8; ik++)
                                for (var jk = 0; jk < 8; jk++)
                                    Tab[ik, jk] = Table[ik, jk];
                            HA += RationalPenalty;
                            int Supported = 0;
                            int Attacked = 0;
                            //For All Enemy Obejcts.                                             
                            for (int g = 0; g < 8; g++)
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                            {
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                for (int h = 0; h < 8; h++)
                                {
                                    Object O2 = new Object();
                                    lock (O2)
                                    {
                                        //Ignore Of Self Objects.
                                        if (Order == 1 && Table[g, h] == 0)
                                            continue;
                                        if (Order == -1 && Table[g, h] == 0)
                                            continue;
                                        Color aaa = new Color();
                                        //Assgin Enemy ints.
                                        aaa = Color.Gray;
                                        if (Order * -1 == -1)
                                            aaa = Color.Brown;
                                        else
                                            aaa = Color.Gray;
                                        //When Enemy is Supported.
                                        bool A = new bool();
                                        bool B = new bool();
                                        var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Tab), g, h, RowS, ColS, a, Order));
                                        th1.Wait();
                                        th1.Dispose();



                                        var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Tab), g, h, RowD, ColD, aaa, Order * -1));
                                        th2.Wait();
                                        th2.Dispose();
                                        //When Enemy is Supported.
                                        if (B)
                                        {
                                            //Assgine variable.
                                            Attacked++;
                                        }
                                        if (A)
                                        {
                                            //Assgine variable.
                                            Supported++;
                                            continue;
                                        }
                                    }
                                }
                            }
                            Object O1 = new Object();
                            lock (O1)
                            {
                                if (Attacked > 0 && Supported == 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)System.Math.Pow(2, Attacked);
                                else
                                //When is Supported Multyply -100.
                                if (Supported > 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)(-(1 * System.Math.Pow(2, Attacked)));
                            }
                        }
                    }
                }
                //For All Homes Table.
                else
                {
                    Order = new int();
                    Color a = new Color();
                    a = aa;
                    if (RowD == RowS && ColD == ColS)
                        return HeuristicMovementValue;
                    int Sign = new int();
                    Order = DummyOrder;
                    ///When Moveble is true. means [RowS,ColS] is in Movmebale to [RowD,ColD].
                    ///What is Moveable!
                    ///Ans:When [RowS,ColS] is Movebale to [RowD,ColD] continue true when Empty or Enemy is located in [RowS,ColS].
                    if (Table[RowD, ColD] == 0 && DummyOrder == -1 && Table[RowS, ColS] < 0)
                    {
                        Order = -1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = -1;
                            a = Color.Brown;
                        }
                    }
                    else if (Table[RowD, ColD] == 0 && DummyOrder == 1 && Table[RowS, ColS] >= 0)
                    {
                        Order = 1;
                        Object O1 = new Object();
                        lock (O1)
                        {
                            Sign = 1 * AllDraw.SignMovments;
                            ChessRules.CurrentOrder = 1;
                            a = Color.Gray;
                        }
                    }
                    else
                        return HeuristicMovementValue;
                    //if (Before)
                    {
                        //When is Movable Movement inCurrent.
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = Movable(CloneATable(Table), RowS, ColS, RowD, ColD, a, Order));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {
                            HA += RationalPenalty;
                            int Supported = 0;
                            int Attacked = 0;
                            //For All Enemy Obejcts.                                             
                            for (int g = 0; g < 8; g++)
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, g =>
                            {
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, h =>
                                for (int h = 0; h < 8; h++)
                                {
                                    Object O2 = new Object();
                                    lock (O2)
                                    {
                                        //Ignore Of Self Objects.
                                        if (Order == 1 && Table[g, h] == 0)
                                            continue;
                                        if (Order == -1 && Table[g, h] == 0)
                                            continue;
                                        Color aaa = new Color();
                                        //Assgin Enemy ints.
                                        aaa = Color.Gray;
                                        if (Order * -1 == -1)
                                            aaa = Color.Brown;
                                        else
                                            aaa = Color.Gray;
                                        //When Enemy is Supported.
                                        bool A = new bool();
                                        bool B = new bool();
                                        var th1 = Task.Factory.StartNew(() => A = Support(CloneATable(Table), g, h, RowS, ColS, a, Order));
                                        th1.Wait();
                                        th1.Dispose();



                                        var th2 = Task.Factory.StartNew(() => B = Attack(CloneATable(Table), g, h, RowD, ColD, aaa, Order * -1));
                                        th2.Wait();
                                        th2.Dispose();
                                        //When Enemy is Supported.
                                        if (B)
                                        {
                                            //Assgine variable.
                                            Attacked++;
                                        }
                                        if (A)
                                        {
                                            //Assgine variable.
                                            Supported++;
                                            continue;
                                        }
                                    }
                                }
                            }
                            Object O1 = new Object();
                            lock (O1)
                            {
                                if (Attacked > 0 && Supported == 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)System.Math.Pow(2, Attacked);
                                else
                                  //When is Supported Multyply -100.
                                  if (Supported > 0)
                                    //When is Not Supported multyply 100.
                                    HA *= (int)(-(1 * System.Math.Pow(2, Attacked)));
                            }
                        }
                    }
                }
                //Reassignments of Begin Call Global Orders.
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                //Store Local Heuristic in Global One.
                return HA * 1;
            }
        }
        ///Attack Determination.QC_Ok
        public bool Attack(int[,] Tab, int i, int j, int ii, int jj, Color a, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                if (Tab[i, j] == 0)
                    return false;
                if (Tab[ii, jj] == 0)
                    return false;
                if (Tab[i, j] > 0 && Tab[ii, jj] > 0)
                    return false;
                if (Tab[i, j] > 0 && Tab[ii, jj] == 0)
                    return false;
                if (Tab[i, j] < 0 && Tab[ii, jj] < 0)
                    return false;
                if (Tab[i, j] < 0 && Tab[ii, jj] == 0)
                    return false;
                int CCurentOrder = ChessRules.CurrentOrder;
                //Initiate Global static  Variable.
                ChessRules.CurrentOrder = Order;
                int[,] Table = CloneATable(Tab);
                //when there is a Movment from Parameter One to Second Parameter return Attacke..
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = (new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[i, j], CloneATable(Table), Order, i, j)).Rules(i, j, ii, jj, a, Order));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    ChessRules.CurrentOrder = CCurentOrder;
                    return true;
                }
                ChessRules.CurrentOrder = CCurentOrder;
                return false;
            }
        }
        //Object Danger Determination.
        public bool ObjectDanger(int[,] Tab, int i, int j, int ii, int jj, Color a, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                int CCurrentOrder = ChessRules.CurrentOrder;
                //Initiate Local Varibales.
                int[,] Table = new int[8, 8];
                for (var RowS = 0; RowS < 8; RowS++)
                    for (var ColS = 0; ColS < 8; ColS++)
                    {
                        Table[RowS, ColS] = Tab[RowS, ColS];
                    }
                ChessRules.CurrentOrder = Order;
                ///When [i,j] is Attacked [ii,jj] retrun true when enemy is located in [ii,jj].
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = (new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[i, j], CloneATable(Table), Order, i, j)).Rules(i, j, ii, jj, a, Order));
                th.Wait();
                th.Dispose();
                if (ab)
                {

                    //Initiate Local Variables.
                    for (var RowS = 0; RowS < 8; RowS++)
                        for (var ColS = 0; ColS < 8; ColS++)
                        {
                            Table[RowS, ColS] = Tab[RowS, ColS];
                        }
                    //Take Movments.
                    Table[ii, jj] = Table[i, j];
                    Table[i, j] = 0;
                    //Consider Check.
                    ChessRules AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[ii, jj], CloneATable(Table), Order, ii, jj);

                    var th1 = Task.Factory.StartNew(() => ab = AA.ObjectDangourKingMove(Order, CloneATable(Table), false));
                    th1.Wait();
                    th1.Dispose();
                    if (ab)
                    {
                        ChessRules.CurrentOrder = CCurrentOrder;
                        //Return ObjectDanger.
                        if ((AA.CheckGrayObjectDangour) && Order == 1)
                        {
                            return true;
                        }
                        else
                            if ((AA.CheckBrownObjectDangour) && Order == -1)
                        {
                            return true;
                        }
                    }
                    if (AA.CheckMate(CloneATable(Table), Order))
                    {
                        ChessRules.CurrentOrder = CCurrentOrder;
                        //Return ObjectDanger.
                        if ((AA.CheckGray || AA.CheckMateGray) && Order == 1)
                        {
                            return true;
                        }
                        else
                            if ((AA.CheckBrown || AA.CheckMateBrown) && Order == -1)
                        {
                            return true;
                        }
                    }
                }


                ChessRules.CurrentOrder = CCurrentOrder;

                //return Non ObjectDanger.
                return false;
            }
        }
        ///Supportation Determination.QC_OK
        public bool Support(int[,] Tab, int i, int j, int ii, int jj, Color a, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                if (Tab[i, j] == 0)
                    return false;
                //Initiate Local Variables.
                int[,] Table = new int[8, 8];
                for (var RowS = 0; RowS < 8; RowS++)
                    for (var ColS = 0; ColS < 8; ColS++)
                        Table[RowS, ColS] = Tab[RowS, ColS];
                ///When All Tables is Gray.
                if (Order == 1 && Table[i, j] > 0)
                {
                    ///When [i,j] Supporte [ii,jj].
                    bool ab = false;
                    var th = Task.Factory.StartNew(() => ab = (new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[i, j], CloneATable(Table), Order, i, j)).Rules(i, j, ii, jj, a, Table[i, j], false) && SameSign(Table[i, j], Table[ii, jj]));
                    th.Wait();
                    th.Dispose();
                    if (ab)
                    {
                        return true;
                    }
                }
                else
                {
                    if (Order == -1 && Table[i, j] < 0)
                    {  ///When [i,j] Supporte [ii,jj].
                        bool ab = false;
                        var th = Task.Factory.StartNew(() => ab = (new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, Table[i, j], CloneATable(Table), Order, i, j)).Rules(i, j, ii, jj, a, Table[i, j], false) && SameSign(Table[i, j], Table[ii, jj]));
                        th.Wait();
                        th.Dispose();
                        if (ab)
                        {

                            return true;
                        }
                    }
                }
                return false;
            }
        }
        //Return Msx Huiristic of Child Level.
        public bool MaxHeuristic(ref int j, int Kin, ref int Less, int Order)
        {
            Object O = new Object();
            lock (O)
            {


                bool Found = false;
                //When Solders.
                if (Kin == 1)
                {
                    for (var i = 0; i < this.PenaltyRegardListSolder.Count; i++)
                    {
                        if (PenaltyRegardListSolder[i].IsPenaltyAction() != 0)
                        {
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (Less > HeuristicListSolder[i][0] +
                                    HeuristicListSolder[i][1] +
                                    HeuristicListSolder[i][2] +
                                    HeuristicListSolder[i][3] +
                                    HeuristicListSolder[i][4] +
                                    HeuristicListSolder[i][5] +
                                    HeuristicListSolder[i][6] +
                                    HeuristicListSolder[i][7] +
                                    HeuristicListSolder[i][8] +
                                    HeuristicListSolder[i][9])
                                {
                                    Less = HeuristicListSolder[i][0] +
                                HeuristicListSolder[i][1] +
                                HeuristicListSolder[i][2] +
                                HeuristicListSolder[i][3] +
                                HeuristicListSolder[i][4] +
                                HeuristicListSolder[i][5] +
                                HeuristicListSolder[i][6] +
                                HeuristicListSolder[i][7] +
                                    HeuristicListSolder[i][8] +
                                    HeuristicListSolder[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                            else
                            {
                                if (Less < HeuristicListSolder[i][0] +
                             HeuristicListSolder[i][1] +
                             HeuristicListSolder[i][2] +
                             HeuristicListSolder[i][3] +
                             HeuristicListSolder[i][4] +
                             HeuristicListSolder[i][5] +
                             HeuristicListSolder[i][6] +
                             HeuristicListSolder[i][7] +
                             HeuristicListSolder[i][8] +
                             HeuristicListSolder[i][9])
                                {
                                    Less = HeuristicListSolder[i][0] +
                                HeuristicListSolder[i][1] +
                                HeuristicListSolder[i][2] +
                                HeuristicListSolder[i][3] +
                                HeuristicListSolder[i][4] +
                                HeuristicListSolder[i][5] +
                                HeuristicListSolder[i][6] +
                                HeuristicListSolder[i][7] +
                                    HeuristicListSolder[i][8] +
                                    HeuristicListSolder[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                        }
                    }
                }
                else//When Elephant.
                    if (Kin == 2)
                {
                    for (var i = 0; i < this.PenaltyRegardListElefant.Count; i++)
                    {
                        if (PenaltyRegardListElefant[i].IsPenaltyAction() != 0)
                        {
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (Less > HeuristicListElefant[i][0] +
                                    HeuristicListElefant[i][1] +
                                    HeuristicListElefant[i][2] +
                                    HeuristicListElefant[i][3] +
                                    HeuristicListElefant[i][4] +
                                    HeuristicListElefant[i][5] +
                                    HeuristicListElefant[i][6] +
                                    HeuristicListElefant[i][7] +
                                    HeuristicListElefant[i][8] +
                                    HeuristicListElefant[i][9])
                                {
                                    Less = HeuristicListElefant[i][0] +
                                HeuristicListElefant[i][1] +
                                HeuristicListElefant[i][2] +
                                HeuristicListElefant[i][3] +
                                HeuristicListElefant[i][4] +
                                HeuristicListElefant[i][5] +
                                HeuristicListElefant[i][6] +
                                HeuristicListElefant[i][7] +
                                    HeuristicListElefant[i][8] +
                                    HeuristicListElefant[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                            else
                            {
                                if (Less < HeuristicListElefant[i][0] +
                             HeuristicListElefant[i][1] +
                             HeuristicListElefant[i][2] +
                             HeuristicListElefant[i][3] +
                             HeuristicListElefant[i][4] +
                             HeuristicListElefant[i][5] +
                             HeuristicListElefant[i][6] +
                             HeuristicListElefant[i][7] +
                             HeuristicListElefant[i][8] +
                             HeuristicListElefant[i][9])
                                {
                                    Less = HeuristicListElefant[i][0] +
                                HeuristicListElefant[i][1] +
                                HeuristicListElefant[i][2] +
                                HeuristicListElefant[i][3] +
                                HeuristicListElefant[i][4] +
                                HeuristicListElefant[i][5] +
                                HeuristicListElefant[i][6] +
                                HeuristicListElefant[i][7] +
                                    HeuristicListElefant[i][8] +
                                    HeuristicListElefant[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                        }
                    }
                }
                else//When Hourse.
                        if (Kin == 3)
                {
                    for (var i = 0; i < this.PenaltyRegardListHourse.Count; i++)
                    {
                        if (PenaltyRegardListHourse[i].IsPenaltyAction() != 0)
                        {
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (Less > HeuristicListHourse[i][0] +
                                    HeuristicListHourse[i][1] +
                                    HeuristicListHourse[i][2] +
                                    HeuristicListHourse[i][3] +
                                    HeuristicListHourse[i][4] +
                                    HeuristicListHourse[i][5] +
                                    HeuristicListHourse[i][6] +
                                    HeuristicListHourse[i][7] +
                                    HeuristicListHourse[i][8] +
                                    HeuristicListHourse[i][9])
                                {
                                    Less = HeuristicListHourse[i][0] +
                                HeuristicListHourse[i][1] +
                                HeuristicListHourse[i][2] +
                                HeuristicListHourse[i][3] +
                                HeuristicListHourse[i][4] +
                                HeuristicListHourse[i][5] +
                                HeuristicListHourse[i][6] +
                                HeuristicListHourse[i][7] +
                                    HeuristicListHourse[i][8] +
                                    HeuristicListHourse[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                            else
                            {
                                if (Less < HeuristicListHourse[i][0] +
                             HeuristicListHourse[i][1] +
                             HeuristicListHourse[i][2] +
                             HeuristicListHourse[i][3] +
                             HeuristicListHourse[i][4] +
                             HeuristicListHourse[i][5] +
                             HeuristicListHourse[i][6] +
                             HeuristicListHourse[i][7] +
                             HeuristicListHourse[i][8] +
                             HeuristicListHourse[i][9])
                                {
                                    Less = HeuristicListHourse[i][0] +
                                HeuristicListHourse[i][1] +
                                HeuristicListHourse[i][2] +
                                HeuristicListHourse[i][3] +
                                HeuristicListHourse[i][4] +
                                HeuristicListHourse[i][5] +
                                HeuristicListHourse[i][6] +
                                HeuristicListHourse[i][7] +
                                    HeuristicListHourse[i][8] +
                                    HeuristicListHourse[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                        }
                    }
                }
                else//When Castles.
                            if (Kin == 4)
                {
                    for (var i = 0; i < this.PenaltyRegardListCastle.Count; i++)
                    {
                        if (PenaltyRegardListCastle[i].IsPenaltyAction() != 0)
                        {
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (Less > HeuristicListCastle[i][0] +
                                    HeuristicListCastle[i][1] +
                                    HeuristicListCastle[i][2] +
                                    HeuristicListCastle[i][3] +
                                    HeuristicListCastle[i][4] +
                                    HeuristicListCastle[i][5] +
                                    HeuristicListCastle[i][6] +
                                    HeuristicListCastle[i][7] +
                                    HeuristicListCastle[i][8] +
                                    HeuristicListCastle[i][9])
                                {
                                    Less = HeuristicListCastle[i][0] +
                                HeuristicListCastle[i][1] +
                                HeuristicListCastle[i][2] +
                                HeuristicListCastle[i][3] +
                                HeuristicListCastle[i][4] +
                                HeuristicListCastle[i][5] +
                                HeuristicListCastle[i][6] +
                                HeuristicListCastle[i][7] +
                                    HeuristicListCastle[i][8] +
                                    HeuristicListCastle[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                            else
                            {
                                if (Less < HeuristicListCastle[i][0] +
                             HeuristicListCastle[i][1] +
                             HeuristicListCastle[i][2] +
                             HeuristicListCastle[i][3] +
                             HeuristicListCastle[i][4] +
                             HeuristicListCastle[i][5] +
                             HeuristicListCastle[i][6] +
                             HeuristicListCastle[i][7] +
                             HeuristicListCastle[i][8] +
                             HeuristicListCastle[i][9])
                                {
                                    Less = HeuristicListCastle[i][0] +
                                HeuristicListCastle[i][1] +
                                HeuristicListCastle[i][2] +
                                HeuristicListCastle[i][3] +
                                HeuristicListCastle[i][4] +
                                HeuristicListCastle[i][5] +
                                HeuristicListCastle[i][6] +
                                HeuristicListCastle[i][7] +
                                    HeuristicListCastle[i][8] +
                                    HeuristicListCastle[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                        }
                    }
                }
                else//When Minister.
                                if (Kin == 5)
                {
                    for (var i = 0; i < this.PenaltyRegardListMinister.Count; i++)
                    {
                        if (PenaltyRegardListMinister[i].IsPenaltyAction() != 0)
                        {
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (Less > HeuristicListMinister[i][0] +
                                    HeuristicListMinister[i][1] +
                                    HeuristicListMinister[i][2] +
                                    HeuristicListMinister[i][3] +
                                    HeuristicListMinister[i][4] +
                                    HeuristicListMinister[i][5] +
                                    HeuristicListMinister[i][6] +
                                    HeuristicListMinister[i][7] +
                                    HeuristicListMinister[i][8] +
                                    HeuristicListMinister[i][9]
                                    )
                                {
                                    Less = HeuristicListMinister[i][0] +
                                HeuristicListMinister[i][1] +
                                HeuristicListMinister[i][2] +
                                HeuristicListMinister[i][3] +
                                HeuristicListMinister[i][4] +
                                HeuristicListMinister[i][5] +
                                HeuristicListMinister[i][6] +
                                HeuristicListMinister[i][7] +
                                    HeuristicListMinister[i][8] +
                                    HeuristicListMinister[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                            else
                            {
                                if (Less < HeuristicListMinister[i][0] +
                             HeuristicListMinister[i][1] +
                             HeuristicListMinister[i][2] +
                             HeuristicListMinister[i][3] +
                             HeuristicListMinister[i][4] +
                             HeuristicListMinister[i][5] +
                             HeuristicListMinister[i][6] +
                             HeuristicListMinister[i][7] +
                             HeuristicListMinister[i][8] +
                             HeuristicListMinister[i][9]
                             )
                                {
                                    Less = HeuristicListMinister[i][0] +
                                HeuristicListMinister[i][1] +
                                HeuristicListMinister[i][2] +
                                HeuristicListMinister[i][3] +
                                HeuristicListMinister[i][4] +
                                HeuristicListMinister[i][5] +
                                HeuristicListMinister[i][6] +
                                HeuristicListMinister[i][7] +
                                    HeuristicListMinister[i][8] +
                                    HeuristicListMinister[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                        }
                    }
                }
                else//When King.
                                    if (Kin == 6)
                {
                    for (var i = 0; i < this.PenaltyRegardListKing.Count; i++)
                    {
                        if (PenaltyRegardListKing[i].IsPenaltyAction() != 0)
                        {
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (Less > HeuristicListKing[i][0] +
                                    HeuristicListKing[i][1] +
                                    HeuristicListKing[i][2] +
                                    HeuristicListKing[i][3] +
                                    HeuristicListKing[i][4] +
                                    HeuristicListKing[i][5] +
                                    HeuristicListKing[i][6] +
                                    HeuristicListKing[i][7] +
                                    HeuristicListKing[i][8] +
                                    HeuristicListKing[i][9])
                                {
                                    Less = HeuristicListKing[i][0] +
                                HeuristicListKing[i][1] +
                                HeuristicListKing[i][2] +
                                HeuristicListKing[i][3] +
                                HeuristicListKing[i][4] +
                                HeuristicListKing[i][5] +
                                HeuristicListKing[i][6] +
                                HeuristicListKing[i][7] +
                                    HeuristicListKing[i][8] +
                                    HeuristicListKing[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }
                            else
                            {
                                if (Less < HeuristicListKing[i][0] +
                             HeuristicListKing[i][1] +
                             HeuristicListKing[i][2] +
                             HeuristicListKing[i][3] +
                             HeuristicListKing[i][4] +
                             HeuristicListKing[i][5] +
                             HeuristicListKing[i][6] +
                             HeuristicListKing[i][7] +
                             HeuristicListKing[i][8] +
                             HeuristicListKing[i][9])
                                {
                                    Less = HeuristicListKing[i][0] +
                                HeuristicListKing[i][1] +
                                HeuristicListKing[i][2] +
                                HeuristicListKing[i][3] +
                                HeuristicListKing[i][4] +
                                HeuristicListKing[i][5] +
                                HeuristicListKing[i][6] +
                                HeuristicListKing[i][7] +
                                    HeuristicListKing[i][8] +
                                    HeuristicListKing[i][9];
                                    j = i;
                                    Found = true;
                                }
                            }

                        }
                    }
                }
                return Found;
            }
        }
        //Setting Numbers of Objects in Current Table boards.
        //Count of Solders on Table.
        int SolderOnTableCount(ref DrawSoldier[] So, bool Mi, int MaxCount)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0, i = 0;
                //For Alll Solders on int Calculate Solkder Count.
                while (i < MaxCount)
                {
                    //The Index out of range exeption is not fixable.
                    if (So != null) if (So[i] != null)
                        {
                            //When int is Gray or Brown.
                            if (So[i].color == Color.Gray || So[i].color == Color.Brown)
                            {
                                if (Mi)
                                {
                                    if (So[i].color == Color.Gray)
                                        Count++;
                                }
                                else
                                    Count++;
                            }
                            else
                                So[i] = null;
                        }
                    i++;
                };
                return Count;
            }
        }
        //Elepahnt On Table Count.
        int ElefantOnTableCount(ref DrawElefant[] So, bool Mi, int MaxCount)
        {
            Object O = new Object();
            lock (O)
            {

                int Count = 0, i = 0;
                //For All Elephant items in Table.
                while (i < MaxCount)
                {
                    //The Index out of range exeption is not fixable.
                    if (So != null) if (So[i] != null)
                        {
                            //when Elaphant int is Gray or Brown.
                            if (So[i].color == Color.Gray || So[i].color == Color.Brown)
                            {
                                if (Mi)
                                {
                                    if (So[i].color == Color.Gray)
                                        Count++;
                                }
                                else
                                    Count++;
                            }
                            else
                                So[i] = null;
                        }
                    i++;
                };
                return Count;
            }
        }
        //Calculate Hourse on table.
        int HourseOnTableCount(ref DrawHourse[] So, bool Mi, int MaxCount)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0, i = 0;
                while (i < MaxCount)
                {
                    //For All Hourse on Table .
                    //The Index out of range exeption is not fixable.
                    if (So != null) if (So[i] != null)
                        {
                            //When int is Gray or Brown.
                            if (So[i].color == Color.Gray || So[i].color == Color.Brown)
                            {
                                if (Mi)
                                {
                                    if (So[i].color == Color.Gray)
                                        Count++;
                                }
                                else
                                    Count++;
                            }
                            else
                                So[i] = null;
                        }
                    i++;
                };
                return Count;
            }
        }
        //Calculate Castles Count.
        int CastleOnTableCount(ref DrawCastle[] So, bool Mi, int MaxCount)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0, i = 0;
                while (i < MaxCount)
                {
                    //The Index out of range exeption is not fixable.
                    if (So != null) if (So[i] != null)
                        {
                            //When Castles int is Gray or Brown.
                            if (So[i].color == Color.Gray || So[i].color == Color.Brown)
                            {
                                if (Mi)
                                {
                                    if (So[i].color == Color.Gray)
                                        Count++;
                                }
                                else
                                    Count++;
                            }
                            else
                                So[i] = null;
                        }

                    i++;
                };
                return Count;
            }
        }
        //Calculate Minsiter Count.
        int MinisterOnTableCount(ref DrawMinister[] So, bool Mi, int MaxCount)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0, i = 0;
                while (i < MaxCount)
                {
                    //The Index out of range exeption is not fixable.
                    if (So != null) if (So[i] != null)
                        {
                            //When int of items is Gray or Brown.
                            if (So[i].color == Color.Gray || So[i].color == Color.Brown)
                            {
                                if (Mi)
                                {
                                    if (So[i].color == Color.Gray)
                                        Count++;
                                }
                                else
                                    Count++;
                            }
                            else
                                So[i] = null;
                        }
                    i++;
                };
                return Count;
            }
        }
        //Calculate King on Table.
        int KingOnTableCount(ref DrawKing[] So, bool Mi, int MaxCount)
        {
            Object O = new Object();
            lock (O)
            {
                int Count = 0, i = 0;
                while (i < MaxCount)
                {
                    //The Index out of range exeption is not fixable.
                    if (So != null) if (So[i] != null)
                        {
                            //when int is Gray or Brown.
                            if (So[i].color == Color.Gray || So[i].color == Color.Brown)
                            {
                                if (Mi)
                                {
                                    if (So[i].color == Color.Gray)
                                        Count++;
                                }
                                else
                                    Count++;
                            }
                            else
                                So[i] = null;
                        }
                    i++;
                };
                return Count;
            }
        }
        //Return Heuristic.
        public int ReturnHeuristic(int ii, int j, int Order, bool AA, ref int HaveKilled)
        {
            Object O = new Object();
            lock (O)
            {
                AllDraw.OutPut = new System.Text.StringBuilder("");

                //calculation of Heuristic methos and storing value retured.
                int Hur = new int();
                Object O1 = new Object();
                lock (O1)
                {
                    if (!AA)
                    {
                        if (ii >= 0 && UsePenaltyRegardMechnisamT)
                        {
                            int Hav = HaveKilled;
                            var th = Task.Factory.StartNew(() => Hur = (int)((double)ReturnHeuristicCalculartor(0, ii, j, Order, ref Hav) * LearniningTable.LearingValue(Row, Column)));
                            th.Wait();
                            th.Dispose();
                            HaveKilled = Hav;
                        }
                        else
                        {
                            int Hav = HaveKilled;
                            var th = Task.Factory.StartNew(() => Hur = ReturnHeuristicCalculartor(0, ii, j, Order, ref Hav));
                            th.Wait();
                            th.Dispose();
                            HaveKilled = Hav;
                        }
                    }
                    else
                    {
                        int Hav = HaveKilled;
                        var th = Task.Factory.StartNew(() => Hur = ReturnHeuristicCalculartor(0, ii, j, Order, ref Hav) + 1000);
                        th.Wait();
                        th.Dispose();
                        HaveKilled = Hav;

                    }
                    //Optimization depend of numbers of unpealties nodes quefficient.  
                    if (UsePenaltyRegardMechnisamT)
                    {
                        var th = Task.Factory.StartNew(() => Hur = Hur * ((int)(NumbersOfAllNode - NumbersOfCurrentBranchesPenalties) / (int)(NumbersOfAllNode)));
                        th.Wait();
                        th.Dispose();
                        return Hur;
                    }

                    return Hur;
                }
            }
        }
        //statstical html 
        String Alphabet(int RowRealesed)
        {
            Object O = new Object();
            lock (O)
            {
                String A = "";
                if (RowRealesed == 0)
                    A = "a";
                else
                    if (RowRealesed == 1)
                    A = "b";
                else
                        if (RowRealesed == 2)
                    A = "c";
                else
                            if (RowRealesed == 3)
                    A = "d";
                else
                                if (RowRealesed == 4)
                    A = "e";
                else
                                    if (RowRealesed == 5)
                    A = "f";
                else
                                        if (RowRealesed == 6)
                    A = "g";
                else
                                            if (RowRealesed == 7)
                    A = "h";

                return A;
            }
        }
        //statstical html 
        String Number(int ColumnRealeased)
        {
            Object O = new Object();
            lock (O)
            {
                String A = "";
                if (ColumnRealeased == 7)
                    A = "0";
                else
                    if (ColumnRealeased == 6)
                    A = "1";
                else
                        if (ColumnRealeased == 5)
                    A = "2";
                else
                            if (ColumnRealeased == 4)
                    A = "3";
                else
                                if (ColumnRealeased == 3)
                    A = "4";
                else
                                    if (ColumnRealeased == 2)
                    A = "5";
                else
                                        if (ColumnRealeased == 1)
                    A = "6";
                else
                                            if (ColumnRealeased == 0)
                    A = "7";
                return A;
            }
        }
        //Heuristic help to kiling of enemy or gave point witout only lraearning autamata exclusive but act on.
        public int ReturnHeuristicCalculartorKiller(int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            //when killer list satisfied
            if (KillerAtThinking.Count > j)
            {
                //when killer list exist and for victory
                if (KillerAtThinking[j] > 0)
                {
                    IsAtLeastOneKillerAtDraw = true;
                    HaveKilled = iAstarGready;
                }
                else//when kiler is for lose 
                if (KillerAtThinking[j] < 0)
                {
                    IsAtLeastOneKillerAtDraw = true;
                    HaveKilled = (iAstarGready * -1);
                }
            }
            //when there is not served layer
            bool A = !IsSupHuTrue(j); if (A && j >= 0)
            {
                //when there is computations
                for (j = 0; HeuristicListSolder != null && j < HeuristicListSolder.Count; j++)
                {
                    Heuristic += HeuristicListSolder[j][0] +
                        HeuristicListSolder[j][1] +
                        HeuristicListSolder[j][2] +
                        HeuristicListSolder[j][3] +
                        HeuristicListSolder[j][4] +
                        HeuristicListSolder[j][5] +
                        HeuristicListSolder[j][6] +
                    HeuristicListSolder[j][7] +
                    HeuristicListSolder[j][8] +
                    HeuristicListSolder[j][9];
                    Object O1 = new Object();
                    lock (O1)
                    {
                        if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                        {
                            //if (Order == 1)
                            //else
                        }
                    }
                }
                //When Elephant Kind.
                for (j = 0; HeuristicListElefant != null && j < HeuristicListElefant.Count; j++)
                {
                    Heuristic += HeuristicListElefant[j][0] +
                    HeuristicListElefant[j][1] +
                    HeuristicListElefant[j][2] +
                    HeuristicListElefant[j][3] +
                    HeuristicListElefant[j][4] +
                    HeuristicListElefant[j][5] +
                    HeuristicListElefant[j][6] +
                    HeuristicListElefant[j][7] +
                    HeuristicListElefant[j][8] +
                    HeuristicListElefant[j][9];
                    Object O1 = new Object();
                    lock (O1)
                    {
                        if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                        {
                            //if (Order == 1)
                            //else
                        }
                    }

                }
                //when is hourse
                for (j = 0; HeuristicListHourse != null && j < HeuristicListHourse.Count; j++)
                {
                    Heuristic += HeuristicListHourse[j][0] +
                HeuristicListHourse[j][1] +
                HeuristicListHourse[j][2] +
                HeuristicListHourse[j][3] +
                HeuristicListHourse[j][4] +
                HeuristicListHourse[j][5] +
                HeuristicListHourse[j][6] +
                HeuristicListHourse[j][7] +
                HeuristicListHourse[j][8] +
                HeuristicListHourse[j][9];
                    Object O1 = new Object();
                    lock (O1)
                    {
                        if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                        {
                            //if (Order == 1)
                            //else
                        }
                    }

                }
                //when is Castle
                for (j = 0; HeuristicListCastle != null && j < HeuristicListCastle.Count; j++)
                {
                    Heuristic += HeuristicListCastle[j][0] +
            HeuristicListCastle[j][1] +
            HeuristicListCastle[j][2] +
            HeuristicListCastle[j][3] +
            HeuristicListCastle[j][4] +
            HeuristicListCastle[j][5] +
            HeuristicListCastle[j][6] +
            HeuristicListCastle[j][7] +
            HeuristicListCastle[j][8] +
            HeuristicListCastle[j][9];
                    Object O1 = new Object();
                    lock (O1)
                    {
                        if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                        {
                            //if (Order == 1)
                            //else
                        }
                    }
                }
                //when is minister
                for (j = 0; HeuristicListMinister != null && j < HeuristicListMinister.Count; j++)
                {
                    Heuristic += HeuristicListMinister[j][0] +
        HeuristicListMinister[j][1] +
        HeuristicListMinister[j][2] +
        HeuristicListMinister[j][3] +
        HeuristicListMinister[j][4] +
        HeuristicListMinister[j][5] +
        HeuristicListMinister[j][6] +
        HeuristicListMinister[j][7] +
        HeuristicListMinister[j][8] +
        HeuristicListMinister[j][9];
                    Object O1 = new Object();
                    lock (O1)
                    {
                        if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                        {
                            //if (Order == 1)
                            //else
                        }
                    }
                }
                //when is king
                for (j = 0; HeuristicListKing != null && j < HeuristicListKing.Count; j++)
                {
                    {
                        Heuristic += HeuristicListKing[j][0] +
        HeuristicListKing[j][1] +
        HeuristicListKing[j][2] +
        HeuristicListKing[j][3] +
        HeuristicListKing[j][4] +
        HeuristicListKing[j][5] +
        HeuristicListKing[j][6] +
        HeuristicListKing[j][7] +
        HeuristicListKing[j][8] +
        HeuristicListKing[j][9];
                        Object O1 = new Object();
                        lock (O1)
                        {
                            if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                            {
                                //if (Order == 1)
                                //else
                            }
                        }
                    }
                }//when is king
                for (j = 0; HeuristicListCastling != null && j < HeuristicListCastling.Count; j++)
                {
                    {
                        Heuristic += HeuristicListCastling[j][0] +
        HeuristicListCastling[j][1] +
        HeuristicListCastling[j][2] +
        HeuristicListCastling[j][3] +
        HeuristicListCastling[j][4] +
        HeuristicListCastling[j][5] +
        HeuristicListCastling[j][6] +
        HeuristicListCastling[j][7] +
        HeuristicListCastling[j][8] +
        HeuristicListCastling[j][9];
                        Object O1 = new Object();
                        lock (O1)
                        {
                            if (AllDraw.NumberOfLeafComputation == -1 && AllDraw.FirstTraversalTree)
                            {
                                //if (Order == 1)
                                //else
                            }
                        }
                    }
                }
            }
            else
            {
                BOUND = -1;
                return Heuristic;
            }
            return Heuristic;
        }
        //deeper section to deep inside Heuristic calculation 
        public int ReturnHeuristicCalculartorDeeper(int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            //when is deeper
            if (AStarGreedy != null)
            {
                //for all deeper
                for (int k = 0; k < AStarGreedy.Count; k++)
                {
                    //continue when deeper is null
                    if (AStarGreedy[k] == null)
                        continue;
                    Object OOO = new Object();
                    lock (OOO)
                    {
                        //Gray
                        if (Order == -1)
                        {
                            //Repeate for Solder.
                            for (int m = 0; m < AStarGreedy[k].SodierMidle; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperSolider(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                            }
                            //Repeate for Elephant.
                            for (int m = 0; m < AStarGreedy[k].ElefantMidle; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperElephant(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Hourse.
                            for (int m = 0; m < AStarGreedy[k].HourseMidle; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperHourse(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Castles.
                            for (int m = 0; m < AStarGreedy[k].CastleMidle; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperCastle(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Minstre.
                            for (int m = 0; m < AStarGreedy[k].MinisterMidle; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperMinister(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for King.
                            for (int m = 0; m < AStarGreedy[k].KingMidle; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperKing(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            } //Repeate for King.
                            for (int m = 0; m < 1; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperCastling(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                        }
                        else
                        {
                            for (int m = AStarGreedy[k].SodierMidle; m < AStarGreedy[k].SodierHigh; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperSolider(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Elephant.
                            for (int m = AStarGreedy[k].ElefantMidle; m < AStarGreedy[k].ElefantHigh; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperElephant(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Hourse.
                            for (int m = AStarGreedy[k].HourseMidle; m < AStarGreedy[k].HourseHight; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperHourse(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Castles.
                            for (int m = AStarGreedy[k].CastleMidle; m < AStarGreedy[k].CastleHigh; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperCastle(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for Minstre.
                            for (int m = AStarGreedy[k].MinisterMidle; m < AStarGreedy[k].MinisterHigh; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperMinister(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                            //Repeate for King.
                            for (int m = 0; m < 1; m++)
                            {
                                int bo = BOUND;
                                int hav = HaveKilled;
                                var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeperCastling(k, m, iAstarGready, ii, j, Order, ref hav, ref bo));
                                th.Wait();
                                th.Dispose();
                                BOUND = bo;
                                HaveKilled = hav;
                            }
                        }
                    }
                }

            }
            BOUND = 0;
            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperKing(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            if (AStarGreedy[k].KingOnTable == null || AStarGreedy[k].KingOnTable[m] == null || AStarGreedy[k].KingOnTable[m].KingThinking == null || AStarGreedy[k].KingOnTable[m].KingThinking[0] == null || AStarGreedy[k].KingOnTable[m].KingThinking[0].TableListKing == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].KingOnTable[m].KingThinking[0].TableListKing.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].KingOnTable[m].KingThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }
            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperCastling(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            if (AStarGreedy[k].CastlingOnTable == null || AStarGreedy[k].CastlingOnTable[m] == null || AStarGreedy[k].CastlingOnTable[m].CastlingThinking == null || AStarGreedy[k].CastlingOnTable[m].CastlingThinking[0] == null || AStarGreedy[k].CastlingOnTable[m].CastlingThinking[0].TableListCastling == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].CastlingOnTable[m].CastlingThinking[0].TableListCastling.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].CastlingOnTable[m].CastlingThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }
            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperMinister(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            if (AStarGreedy[k].MinisterOnTable == null || AStarGreedy[k].MinisterOnTable[m] == null || AStarGreedy[k].MinisterOnTable[m].MinisterThinking == null || AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0] == null || AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].TableListMinister == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].TableListMinister.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].MinisterOnTable[m].MinisterThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }
            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperCastle(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            if (AStarGreedy[k].CastlesOnTable == null || AStarGreedy[k].CastlesOnTable[m] == null || AStarGreedy[k].CastlesOnTable[m].CastleThinking == null || AStarGreedy[k].CastlesOnTable[m].CastleThinking[0] == null || AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].TableListCastle == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].TableListCastle.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].CastlesOnTable[m].CastleThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }
            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperHourse(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            if (AStarGreedy[k].HoursesOnTable == null || AStarGreedy[k].HoursesOnTable[m] == null || AStarGreedy[k].HoursesOnTable[m].HourseThinking == null || AStarGreedy[k].HoursesOnTable[m].HourseThinking[0] == null || AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].TableListHourse == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].TableListHourse.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].HoursesOnTable[m].HourseThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }
            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperElephant(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;

            if (AStarGreedy[k].ElephantOnTable == null || AStarGreedy[k].ElephantOnTable[m] == null || AStarGreedy[k].ElephantOnTable[m].ElefantThinking == null || AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0] == null || AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].TableListElefant == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].TableListElefant.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].ElephantOnTable[m].ElefantThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }

            return Heuristic;
        }
        //deeper for specific object
        public int ReturnHeuristicCalculartorDeeperSolider(int k, int m, int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;

            if (AStarGreedy[k].SolderesOnTable == null || AStarGreedy[k].SolderesOnTable[m] == null || AStarGreedy[k].SolderesOnTable[m].SoldierThinking == null || AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0] == null || AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].TableListSolder == null)
                return Heuristic;
            for (var jj = 0; jj < AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].TableListSolder.Count; jj++)
            {
                int hav = HaveKilled;
                var th = Task.Factory.StartNew(() => Heuristic += AStarGreedy[k].SolderesOnTable[m].SoldierThinking[0].ReturnHeuristicCalculartor(0, ii, jj, Order * -1, ref hav));
                th.Wait();
                th.Dispose();
                HaveKilled = hav;
            }

            return Heuristic;
        }
        public int ReturnHeuristicCalculartorSurface(int iAstarGready, int ii, int j, int Order, ref int HaveKilled, ref int BOUND)
        {
            int Heuristic = 0;
            bool A = !IsSupHuTrue(j); if (A && j >= 0)
            {
                //When Solder Kind.
                if (System.Math.Abs(Kind) == 1 && HeuristicListSolder.Count > 0)
                {
                    Heuristic += HeuristicListSolder[j][0] +
                        HeuristicListSolder[j][1] +
                        HeuristicListSolder[j][2] +
                        HeuristicListSolder[j][3] +
                        HeuristicListSolder[j][4] +
                        HeuristicListSolder[j][5] +
                        HeuristicListSolder[j][6] +
                        HeuristicListSolder[j][7] +
                        HeuristicListSolder[j][8] +
                        HeuristicListSolder[j][9];
                }
                else
                //When Elephant Kind.
                if (System.Math.Abs(Kind) == 2 && HeuristicListElefant.Count > 0)
                {
                    Heuristic += HeuristicListElefant[j][0] +
                        HeuristicListElefant[j][1] +
                        HeuristicListElefant[j][2] +
                        HeuristicListElefant[j][3] +
                        HeuristicListElefant[j][4] +
                        HeuristicListElefant[j][5] +
                        HeuristicListElefant[j][6] +
                        HeuristicListElefant[j][7] +
                        HeuristicListElefant[j][8] +
                    HeuristicListElefant[j][9];
                }
                else
                //When Hourse Kind.
                if (System.Math.Abs(Kind) == 3 && HeuristicListHourse.Count > 0)
                {
                    Heuristic += HeuristicListHourse[j][0] +
                        HeuristicListHourse[j][1] +
                        HeuristicListHourse[j][2] +
                        HeuristicListHourse[j][3] +
                        HeuristicListHourse[j][4] +
                        HeuristicListHourse[j][5] +
                        HeuristicListHourse[j][6] +
                        HeuristicListHourse[j][7] +
                        HeuristicListHourse[j][8] +
                    HeuristicListHourse[j][9];
                }
                else
                //When Castles Kind.
                if (System.Math.Abs(Kind) == 4 && HeuristicListCastle.Count > 0)
                {
                    Heuristic += HeuristicListCastle[j][0] +
                        HeuristicListCastle[j][1] +
                        HeuristicListCastle[j][2] +
                        HeuristicListCastle[j][3] +
                        HeuristicListCastle[j][4] +
                        HeuristicListCastle[j][5] +
                        HeuristicListCastle[j][6] +
                        HeuristicListCastle[j][7] +
                    HeuristicListCastle[j][8] +
                        HeuristicListCastle[j][9];
                }
                else
                //When Minister Kind.
                if (System.Math.Abs(Kind) == 5 && HeuristicListMinister.Count > 0)
                {
                    Heuristic += HeuristicListMinister[j][0] +
                        HeuristicListMinister[j][1] +
                        HeuristicListMinister[j][2] +
                        HeuristicListMinister[j][3] +
                        HeuristicListMinister[j][4] +
                        HeuristicListMinister[j][5] +
                        HeuristicListMinister[j][6] +
                    HeuristicListMinister[j][7] +
                    HeuristicListMinister[j][8] +
                    HeuristicListMinister[j][9];
                }
                else
                //When King Kind.
                if (System.Math.Abs(Kind) == 6 && HeuristicListKing.Count > 0)
                {
                    Heuristic += HeuristicListKing[j][0] +
                        HeuristicListKing[j][1] +
                        HeuristicListKing[j][2] +
                        HeuristicListKing[j][3] +
                        HeuristicListKing[j][4] +
                        HeuristicListKing[j][5] +
                        HeuristicListKing[j][6] +
                        HeuristicListKing[j][7] +
                        HeuristicListKing[j][8] +
                        HeuristicListKing[j][9];
                }
                else
                //When King Kind.
                if (System.Math.Abs(Kind) == 7 && HeuristicListCastling.Count > 0)
                {
                    Heuristic += HeuristicListCastling[j][0] +
                        HeuristicListCastling[j][1] +
                        HeuristicListCastling[j][2] +
                        HeuristicListCastling[j][3] +
                        HeuristicListCastling[j][4] +
                        HeuristicListCastling[j][5] +
                        HeuristicListCastling[j][6] +
                        HeuristicListCastling[j][7] +
                        HeuristicListCastling[j][8] +
                        HeuristicListCastling[j][9];
                }
            }
            else
            {
                if (Order == AllDraw.OrderPlateDraw)
                {
                    BOUND = -1;
                }
                else
                {
                    BOUND = 1;
                }
            }
            return Heuristic;
        }
        //main insider method for manage Heuristic count
        public int ReturnHeuristicCalculartor(int iAstarGready, int ii, int j, int Order, ref int HaveKilled)
        {
            int BOUND = 0;
            if (iAstarGready > PlatformHelper.ProcessorCount)
                return 0;
            iAstarGready++;
            Object O = new Object();
            lock (O)
            {
                int Heuristic = 0;
                //when deeper there is not or level exceed
                if (AStarGreedy == null && iAstarGready != 0)
                {
                    return 0;
                }
                NumbersOfCurrentBranchesPenalties += NumberOfPenalties;
                int DummyOrder = Order;
                //when there is deeper
                if (ii != -1)
                {
                    //kiiler Heuristic determination//main deeper Heuristic
                    int hav = HaveKilled;
                    int bo = BOUND;
                    var th = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorKiller(iAstarGready, ii, j, Order, ref hav, ref bo));
                    th.Wait();
                    th.Dispose();
                    HaveKilled = hav;
                    bo = BOUND;

                    //main deeper Heuristic
                    hav = HaveKilled;
                    bo = BOUND;
                    var th1 = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorDeeper(iAstarGready, ii, j, Order, ref hav, ref bo));
                    th1.Wait();
                    th1.Dispose();
                    HaveKilled = hav;
                    bo = BOUND;

                }
                else
                {
                    //sufacive Heuristic
                    int hav = HaveKilled;
                    int bo = BOUND;
                    var th1 = Task.Factory.StartNew(() => Heuristic += ReturnHeuristicCalculartorSurface(iAstarGready, ii, j, Order, ref hav, ref bo));
                    th1.Wait();
                    th1.Dispose();
                    HaveKilled = hav;
                    bo = BOUND;

                }
                Order = DummyOrder;
                /*if (BOUND < 0)
                    Heuristic = int.MinValue;
                else
                    if (BOUND > 0)
                    Heuristic = int.MaxValue;*/

                return Heuristic;
            }
        }
        //Returrn of Hurestic Tree.QC_Ok.
        //Scope of Every Objects Movments.
        bool Scop(int i, int j, int ii, int jj, int Kind)
        {
            Object O = new Object();
            lock (O)
            {
                if (i == ii && j == jj)
                    return false;
                //Scope of index out of range.
                if (i < 0)
                {
                    return false;
                }
                if (j < 0)
                {
                    return false;
                }
                if (ii < 0)
                {
                    return false;
                }
                if (jj < 0)
                {
                    return false;
                }
                if (i > 7)
                {
                    return false;
                }
                if (j > 7)
                {
                    return false;
                }
                if (ii > 7)
                {
                    return false;
                }
                if (jj > 7)
                {
                    return false;
                }
                bool Validity = false;
                //Scope on estimation on rule movment.
                if (Kind == 1)//Sodier
                {
                    if (ArrangmentsChanged)
                    {
                        if (Order == 1)
                        {
                            if (j <= jj)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (j >= jj)
                            {
                                return false;
                            }
                        }
                    }
                    else if (!ArrangmentsChanged)
                    {
                        if (Order == -1)
                        {
                            if (j <= jj)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (j >= jj)
                            {
                                return false;
                            }
                        }
                    }
                    if (System.Math.Abs(i - ii) <= 2 && System.Math.Abs(j - jj) <= 2)
                        Validity = true;

                }
                else
                    if (Kind == 2)//Elephant
                {
                    if (System.Math.Abs(i - ii) == System.Math.Abs(j - jj))
                    {
                        Validity = true;
                    }
                }
                else
                        if (Kind == 3)//Hourse
                {
                    if (System.Math.Abs(i - ii) == 1 && System.Math.Abs(j - jj) == 2)
                        Validity = true;
                    if (System.Math.Abs(i - ii) == 2 && System.Math.Abs(j - jj) == 1)
                        Validity = true;
                }
                else
                            if (Kind == 4)//Castle
                {
                    if ((i == ii && j != jj) || (i != ii && j == jj))
                        Validity = true;
                }
                else
                                if (Kind == 5)//Minister
                {
                    if (((i == ii && j != jj) || (i != ii && j == jj)) || System.Math.Abs(i - ii) == System.Math.Abs(j - jj))
                        Validity = true;
                }
                else
              if (Kind == 6)//King
                {
                    if (System.Math.Abs(i - ii) <= 1 && System.Math.Abs(j - jj) <= 1)
                        Validity = true;
                }
                else
              if (Kind == 7 || Kind == -7)//Castling
                {
                    Validity = true;
                }
                if (Kind != 7 && Kind != -7)//Castling
                {
                    if (Order == 1)
                    {
                        if (TableConst[i, j] != Kind)
                            Validity = false;
                    }
                    else
                    {
                        if (TableConst[i, j] != (Kind * -1))
                            Validity = false;
                    }
                }
                return Validity;
            }
        }
        bool Scop(int i, int j, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                if (i == ii && j == jj)
                    return false;
                //Scope of index out of range.
                if (i < 0)
                {
                    return false;
                }
                if (j < 0)
                {
                    return false;
                }
                if (ii < 0)
                {
                    return false;
                }
                if (jj < 0)
                {
                    return false;
                }
                if (i > 7)
                {
                    return false;
                }
                if (j > 7)
                {
                    return false;
                }
                if (ii > 7)
                {
                    return false;
                }
                if (jj > 7)
                {
                    return false;
                }

                return true;
            }
        }
        //Calculate Maximum of Six Max Heuristic of Six Kind Objects.
        int MaxOfSixHeuristic(int[] Less)
        {
            Object O = new Object();
            lock (O)
            {
                int Value = -1;
                int Les = int.MinValue;
                for (var i = 0; i < 6; i++)
                {
                    if (Less[i] > Les)
                    {
                        Les = Less[i];
                        Value = i;
                    }
                }
                return Value;
            }
        }
        //Calculate Minimum of Six Min Heuristic of Six Kind Objects.note the enemy Heuristic are negative.
        int MinOfSixHeuristic(int[] Less)
        {
            Object O = new Object();
            lock (O)
            {
                int Value = -1;
                int Les = int.MaxValue;
                for (var i = 0; i < 6; i++)
                {
                    if (Less[i] < Les)
                    {
                        Les = Less[i];
                        Value = i;
                    }
                }
                return Value;
            }
        }
        void HuMethod(ref int[] Hu, int HeuristicAttackValue, int HeuristicMovementValue, int HeuristicSelfSupportedValue, int HeuristicReducedMovementValue, int HeuristicReducedSupport, int HeuristicReducedAttackValue, int HeuristicDistributionValue, int HeuristicKingSafe, int HeuristicFromCenter, int HeuristicKingDangour, int HeuristicCheckedMate)
        {
            Hu[0] += HeuristicAttackValue;
            Hu[1] += HeuristicMovementValue;
            Hu[2] += HeuristicSelfSupportedValue;
            Hu[3] += HeuristicReducedMovementValue;
            Hu[4] += HeuristicReducedSupport;
            Hu[5] += HeuristicReducedAttackValue;
            Hu[6] += HeuristicDistributionValue;
            Hu[7] += HeuristicKingSafe;
            Hu[8] += HeuristicFromCenter;
            Hu[9] += HeuristicKingDangour + HeuristicCheckedMate;
            return;
        }
        void HuMethodSup(int HeuristicAttackValue, int HeuristicMovementValue, int HeuristicSelfSupportedValue, int HeuristicReducedMovementValue, int HeuristicReducedSupport, int HeuristicReducedAttackValue, int HeuristicDistributionValue, int HeuristicKingSafe, int HeuristicFromCenter, int HeuristicKingDangour, int HeuristicCheckedMate)
        {
            HeuristicAttackValueSup += HeuristicAttackValue;
            HeuristicMovementValueSup += HeuristicMovementValue;
            HeuristicSelfSupportedValueSup += HeuristicSelfSupportedValue;
            HeuristicReducedMovementValueSup += HeuristicReducedMovementValue;
            HeuristicReducedSupportSup += HeuristicReducedSupport;
            HeuristicReducedAttackValueSup += HeuristicReducedAttackValue;
            HeuristicDistributionValueSup += HeuristicDistributionValue;
            HeuristicKingSafeSup += HeuristicKingSafe;
            HeuristicFromCenterSup += HeuristicFromCenter;
            HeuristicKingDangourSup += HeuristicKingDangour + HeuristicCheckedMate;
        }
        void HuMethodSup(ref int[] Hu)
        {
            Hu[0] = HeuristicAttackValueSup;
            Hu[1] = HeuristicMovementValueSup;
            Hu[2] = HeuristicSelfSupportedValueSup;
            Hu[3] = HeuristicReducedMovementValueSup;
            Hu[4] = HeuristicReducedSupportSup;
            Hu[5] = HeuristicReducedAttackValueSup;
            Hu[6] = HeuristicDistributionValueSup;
            Hu[7] = HeuristicKingSafeSup;
            Hu[8] = HeuristicFromCenterSup;
            Hu[9] = HeuristicKingDangourSup;
            return;
        }
        //specific determination for thinking main method
        void KingThinkingRefrigtzChessPortable(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object O = new Object();
            lock (O)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int(); int HeuristicCheckedMate = new int();
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                ///When There is Movments.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThinkingRefrigtzChessPortableRuleThinking(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                    bool Sup = false;
                    var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                    newTask1.Wait(); newTask1.Dispose();

                    if (!Sup)
                    {
                        ///Add Table to List of Private.
                        HitNumberKing.Add(TableS[RowDestination, ColumnDestination]);
                        Object OO = new Object();
                        lock (OO)
                        {
                            ThinkingRun = true;
                        }
                    }
                    ///Predict Heuristic.
                    Object A = new object();
                    lock (A)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                    Object A1 = new object();
                    lock (A1)
                    {
                        if (!Sup) { NumbersOfAllNode++; }
                    }
                    int Killed = 0;
                    newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                    newTask1.Wait(); newTask1.Dispose();



                    // if (!Sup)
                    {
                        Object A3 = new object();
                        lock (A3)
                        {
                            PenaltyVCar = false;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ///Store of Indexes Changes and Table in specific List.
                    newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                    newTask1.Wait(); newTask1.Dispose();
                    ///Wehn Predict of Operation Do operate a Predict of this movments.
                    Object A5 = new object();
                    lock (A5)
                    {
                        //Caused this for Stachostic results.
                        if (!Sup)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    //Calculate Heuristic and Add to List and Cal Syntax.
                    if (!Sup)
                    {
                        String H = "";
                        Object A6 = new object();
                        lock (A6)
                        {
                            AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                            int[] Hu = new int[10];
                            //if (!(IsSup[j]))
                            {
                                //if (IgnoreFromCheckandMateHeuristic)

                                newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                                newTask1.Wait(); newTask1.Dispose();
                                H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                                HeuristicListKing.Add(Hu);
                            }
                        }
                        Object O4 = new Object();
                        lock (O4)
                        {
                            ThinkingLevel++;
                            ThinkingAtRun = false;
                        }
                    }
                    else
                    {
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        int[] Hu = new int[10];
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                        newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        ThinkingAtRun = false;
                    }

                }
                else
                    MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1, -1);
            }
            ThinkingAtRun = false;

        }
        //monitor
        String CheM(int A)
        {
            String AA = "";
            if (A <= -1 && A < 0)
                AA = "+SelfChecked ";
            if (A >= 1 && A > 0)
                AA = "+EnemeyChecked ";
            if (A <= -2 && A < 0)
                AA = "++SelfMate ";
            if (A >= 2 && A > 0)
                AA = "++EnemeyMate ";
            if (A <= -3 && A < 0)
                AA = "++SelfFinished ";
            if (A >= 3 && A > 0)
                AA = "++EnemeyFinsished ";
            return AA;
        }
        //specific determination for thinking main method
        void MinisterThinkingRefrigtzChessPortable(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object O11 = new Object();
            lock (O11)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int(); int HeuristicCheckedMate = new int();
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                ///When There is Movments.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThinkingRefrigtzChessPortableRuleThinking(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                    bool Sup = false;
                    var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                    newTask1.Wait(); newTask1.Dispose();
                    if (!Sup)
                    {
                        ///Add Table to List of Private.
                        HitNumberMinister.Add(TableS[RowDestination, ColumnDestination]);
                        Object OO = new Object();
                        lock (OO)
                        {
                            ThinkingRun = true;
                        }
                    }
                    ///Predict Heuristic.
                    Object A = new object();
                    lock (A)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                    Object A1 = new object();
                    lock (A1)
                    {
                        if (!Sup) { NumbersOfAllNode++; }
                    }
                    int Killed = 0;
                    newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                    newTask1.Wait(); newTask1.Dispose();


                    // if (!Sup)
                    {
                        Object A3 = new object();
                        lock (A3)
                        {
                            PenaltyVCar = false;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ///Store of Indexes Changes and Table in specific List.
                    newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                    newTask1.Wait(); newTask1.Dispose();
                    ///Wehn Predict of Operation Do operate a Predict of this movments.
                    Object A5 = new object();
                    lock (A5)
                    {
                        //Caused this for Stachostic results.
                        if (!Sup)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    //Calculate Heuristic and Add to List and Cal Syntax.
                    if (!Sup)
                    {
                        String H = "";
                        Object A6 = new object();
                        lock (A6)
                        {
                            AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                            int[] Hu = new int[10];
                            //if (!(IsSup[j]))
                            {
                                //if (IgnoreFromCheckandMateHeuristic)

                                newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                                newTask1.Wait(); newTask1.Dispose();
                                H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                                HeuristicListMinister.Add(Hu);
                            }
                        }
                        Object O4 = new Object();
                        lock (O4)
                        {
                            ThinkingLevel++;
                            ThinkingAtRun = false;
                        }
                    }
                    else
                    {
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        int[] Hu = new int[10];
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();

                        newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                        newTask1.Wait(); newTask1.Dispose();
                        ThinkingAtRun = false;
                    }

                }
                else
                    MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1, -1);
            }
            ThinkingAtRun = false;
        }
        //determination for kinmgs for stage of movment befor act
        bool IsPrviousMovemntIsDangrousForCurrent(int[,] TableS, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                bool Dang = false;
                int BREAK = 0;
                Object O1 = new Object();
                lock (O1)
                {
                    //.Current
                    for (var i = 0; i < 8; i++)
                    {
                        for (var j = 0; j < 8; j++)
                        {
                            BREAK = 0;
                            if (Order == 1 && TableS[i, j] <= 0)
                                continue;
                            else
                                if (Order == -1 && TableS[i, j] >= 0)
                                continue;
                            //Enemy
                            for (var ii = 0; ii < 8; ii++)
                            {
                                for (var jj = 0; jj < 8; jj++)
                                {
                                    BREAK = 0;
                                    if (Order == 1 && TableS[ii, jj] >= 0)
                                        continue;
                                    else
                                        if (Order == -1 && TableS[ii, jj] <= 0)
                                        continue;
                                    Color a = Color.Gray;
                                    if (Order * -1 == -1)
                                        a = Color.Brown;
                                    bool ab = false;
                                    var th = Task.Factory.StartNew(() => ab = Attack(CloneATable(TableS), ii, jj, i, j, a, Order * -1));
                                    th.Wait();
                                    th.Dispose();
                                    if (ab)
                                    {
                                        BREAK = 1;
                                        //Current
                                        for (var RowS = 0; RowS < 8; RowS++)
                                        {
                                            for (var ColS = 0; ColS < 8; ColS++)
                                            {
                                                BREAK = 0;
                                                if (Order == 1 && TableS[RowS, ColS] <= 0)
                                                    continue;
                                                else
                                                    if (Order == -1 && TableS[RowS, ColS] >= 0)
                                                    continue;
                                                a = Color.Gray;
                                                if (Order == -1)
                                                    a = Color.Brown;
                                                var th1 = Task.Factory.StartNew(() => ab = Support(CloneATable(TableS), RowS, ColS, i, j, a, Order));
                                                th1.Wait();
                                                th1.Dispose();
                                                if (ab)
                                                {
                                                    BREAK = 2;
                                                    break;
                                                }
                                            }
                                            if (BREAK == 2)
                                                break;
                                        }
                                    }
                                    if (BREAK == 1)
                                        break;
                                }
                                if (BREAK == 1)
                                    break;
                            }
                            if (BREAK == 1)
                                break;
                        }
                        if (BREAK == 1)
                            break;
                    }
                    if (BREAK == 1)
                        Dang = true;
                }
                return Dang;
            }
        }
        //When There is not valuable Object in List Greater than Target Self Object return true.        
        bool IsObjectValaubleObjectSelf(int i, int j, int Object, ref List<int[]> ValuableSelfSupported)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = true;
                for (int k = 0; k < ValuableSelfSupported.Count; k++)
                {
                    if (ValuableSelfSupported[k][0] > 0 && Object > 0)
                    {
                        if (System.Math.Abs(ValuableSelfSupported[k][0]) > System.Math.Abs(Object))
                            Is = false;
                    }
                    else
                       if (ValuableSelfSupported[k][0] < 0 && Object < 0)
                    {
                        if (System.Math.Abs(ValuableSelfSupported[k][0]) > System.Math.Abs(Object))
                            Is = false;
                    }
                    if (Is == false)
                        break;
                }
                return Is;
            }
        }
        //When There is not valuable Object in List Greater than Target enemy Object return true.        
        bool IsObjectValaubleObjectEnemy(int i, int j, int Object, ref List<int[]> ValuableEnemyNotSupported)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = true;
                for (int k = 0; k < ValuableEnemyNotSupported.Count; k++)
                    if (System.Math.Abs(ValuableEnemyNotSupported[k][0]) < System.Math.Abs(Object))
                    {
                        Is = false;
                        break;
                    }
                return Is;
            }
        }
        //a machine learning of learning autamata surface scan
        bool[] SomeLearningVarsCalculator(int[,] TableS, int ik, int jk, int iik, int jjk)
        {
            Object O22 = new Object();
            lock (O22)
            {
                int AttackCount = 0;
                bool[] LearningV = new bool[3];
                Object O = new Object();
                lock (O)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                    for (var i = 0; i < 8; i++)
                    {
                        if ((LearningV[0] || LearningV[1] || LearningV[2]))
                            continue;
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, j =>
                        for (var j = 0; j < 8; j++)
                        {
                            if ((LearningV[0] || LearningV[1] || LearningV[2]))
                                continue;
                            ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, RowS =>
                            for (var RowS = 0; RowS < 8; RowS++)
                            {
                                if ((LearningV[0] || LearningV[1] || LearningV[2]))
                                    continue;
                                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, ColS =>
                                for (var ColS = 0; ColS < 8; ColS++)
                                {
                                    if ((LearningV[0] || LearningV[1] || LearningV[2]))
                                        continue;
                                    //ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.Invoke(() =>
                                    {
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            if (!(LearningV[0] || LearningV[1] || LearningV[2]))
                                                LearningV[0] = LearningV[0] || InAttackSelfThatNotSupportedAll(CloneATable(TableS), Order, color, i, j, RowS, ColS, ik, jk, iik, jjk);
                                        }
                                    }//, () =>
                                    {
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            if ((LearningV[0] || LearningV[1] || LearningV[2]))
                                                continue;
                                            if (AttackCount <= 1 && (!(LearningV[0] || LearningV[1] || LearningV[2])))
                                                AttackCount = AttackCount + IsNotSafeToMoveAenemeyToAttackMoreThanTowObject(AttackCount, CloneATable(TableS), Order, i, j, RowS, ColS//, ii, jj, RowD, ColD
                                                    );
                                            else
                                            if (!(LearningV[0] || LearningV[1] || LearningV[2]))
                                                LearningV[1] = true;
                                        }
                                    }//, () =>
                                    {
                                        Object O1 = new Object();
                                        lock (O1)
                                        {
                                            if (!(LearningV[0] || LearningV[1] || LearningV[2]))
                                                LearningV[2] = LearningV[2] || IsGardForCurrentMovmentsAndIsNotMovable(CloneATable(TableS), Order, color, i, j, RowS, ColS//, ii, jj, RowD, ColD
                                                    );
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return LearningV;
            }
        }
        //learning autamata main section
        bool[] CalculateLearningVars(int Killed, int[,] TableS, int i, int j, int ii, int jj)
        {
            Object O = new Object();
            lock (O)
            {
                bool[] LearningV = new bool[14];
                bool IsCurrentCanGardHighPriorityEne = new bool();
                bool IsNextMovemntIsCheckOrCheckMateForCurrent = new bool();
                bool IsDangerous = new bool();
                bool CanKillerAnUnSupportedEnemy = new bool();
                bool InDangrousUnSupported = new bool();
                bool Support = new bool();
                bool IsNextMovemntIsCheckOrCheckMateForEnemy = new bool();
                bool IsPrviousMovemntIsDangrousForCurr = new bool();
                bool PDo = new bool();
                bool RDo = new bool();
                bool SelfNotSupported = new bool();
                bool EnemyNotSupported = new bool();
                bool IsGardForCurrentMovmentsAndIsNotMova = new bool();
                bool IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = new bool();
                bool P = new bool();
                bool R = new bool();
                bool IsTowValuableObjectEnemy = false;
                List<int[]> ValuableEnemyNotSupported = new List<int[]>();
                List<int[]> ValuableSelfSupported = new List<int[]>();
                //When true must penalty
                Object O11 = new Object();
                lock (O11)
                {
                    var newTask = Task.Factory.StartNew(() => IsPrviousMovemntIsDangrousForCurr = IsPrviousMovemntIsDangrousForCurrent(CloneATable(TableS), Order));
                    newTask.Wait();
                    newTask.Dispose();
                    //when true must penalty
                    if (!IsPrviousMovemntIsDangrousForCurr)
                    {
                        newTask = Task.Factory.StartNew(() => SelfNotSupported = InAttackSelfThatNotSupported(CloneATable(TableS), Order, color, i, j, ii, jj));
                        newTask.Wait();
                        newTask.Dispose();
                    } //when true must regard
                    Support = false;
                    int SelfChackedMateDepth = 0;
                    int EnemyCheckedMateDepth = 0;
                    IsDangerous = false;
                    //For All Current
                    bool[] LearningVars = new bool[3];
                    Task.Run(() => LearningVars = SomeLearningVarsCalculator(CloneATable(TableS), ii, jj, i, j));
                    Object O4 = new Object();
                    lock (O4)
                    {
                        SelfNotSupported = LearningVars[0];
                        IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = LearningVars[1];
                        IsGardForCurrentMovmentsAndIsNotMova = LearningVars[2];
                    }
                    if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!IsDangerous))
                    {
                        int[] Is = new int[4];
                        Is[0] = 0;
                        Is[1] = 0;
                        Is[2] = 0;
                        Is[3] = 0;
                        if (CurrentAStarGredyMax == 0)
                        {
                            int Depth = new int();
                            Depth = 0;
                            int[,] Tab = CloneATable(TableS);
                            int Ord = Order;
                            Color a = color;
                            int Ord1 = AllDraw.OrderPlate;
                            int Ord2 = AllDraw.OrderPlate * -1;
                            //when is true must penalty(Superposition)
                            Task.Run(() => Is = IsNextMovmentIsCheckOrCheckMateForCurrentMovment(CloneATable(Tab), Ord, a, Depth, Ord1, Ord2, true));
                            //A
                        }
                        Object OO1 = new Object();
                        lock (OO1)
                        {
                            if (Is[0] >= 1)
                                IsNextMovemntIsCheckOrCheckMateForCurrent = true;
                            else
                                IsNextMovemntIsCheckOrCheckMateForCurrent = false;
                            if (Is[2] >= 1)
                                IsNextMovemntIsCheckOrCheckMateForEnemy = true;
                            else
                                IsNextMovemntIsCheckOrCheckMateForEnemy = false;
                            SelfChackedMateDepth = Is[1];
                            EnemyCheckedMateDepth = Is[3];
                        }
                    }
                    //Order Depth Consideration Constraint.
                    if (IsNextMovemntIsCheckOrCheckMateForCurrent && IsNextMovemntIsCheckOrCheckMateForEnemy)
                    {
                        Object OO2 = new Object();
                        lock (OO2)
                        {
                            if (SelfChackedMateDepth < EnemyCheckedMateDepth)
                                IsNextMovemntIsCheckOrCheckMateForEnemy = false;
                            else
                            if (SelfChackedMateDepth > EnemyCheckedMateDepth)
                                IsNextMovemntIsCheckOrCheckMateForCurrent = false;
                        }
                    }
                    if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!IsDangerous))
                    {
                        newTask = Task.Factory.StartNew(() => EnemyNotSupported = InAttackEnemyThatIsNotSupportedAll(IsTowValuableObjectEnemy, CloneATable(TableS), Order, color, i, j, ii, jj, ref ValuableEnemyNotSupported));
                        newTask.Wait();
                        newTask.Dispose();
                    }
                    if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!EnemyNotSupported) && (!IsDangerous))
                    {
                        newTask = Task.Factory.StartNew(() => EnemyNotSupported = InAttackEnemyThatIsNotSupported(Killed, CloneATable(TableS), Order, color, i, j, ii, jj));
                        newTask.Wait();
                        newTask.Dispose();
                    }
                    if ((!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!EnemyNotSupported) && (!IsDangerous))
                    {
                        newTask = Task.Factory.StartNew(() => EnemyNotSupported = InAttackEnemyThatIsNotSupportedAll(IsTowValuableObjectEnemy, CloneATable(TableS), Order, color, i, j, ii, jj, ref ValuableEnemyNotSupported));
                        newTask.Wait();
                        newTask.Dispose();
                    }
                    if (CurrentAStarGredyMax == 0 && (!IsNextMovemntIsCheckOrCheckMateForCurrent) && (!SelfNotSupported) && (!IsPrviousMovemntIsDangrousForCurr) && (!IsGardForCurrentMovmentsAndIsNotMova) && (!IsNotSafeToMoveAenemeyToAttackMoreThanTowObj) && (!EnemyNotSupported) && (!IsDangerous))
                    {
                        //when is true must regard.
                        newTask = Task.Factory.StartNew(() => IsCurrentCanGardHighPriorityEne = IsCurrentCanGardHighPriorityEnemy(0, CloneATable(TableS), Order, color, i, j, ii, jj, Order));
                        newTask.Wait();
                        newTask.Dispose();
                    }
                    if (SelfNotSupported || IsNextMovemntIsCheckOrCheckMateForCurrent || IsPrviousMovemntIsDangrousForCurr || IsGardForCurrentMovmentsAndIsNotMova && IsDangerous)
                    {
                        IsCurrentCanGardHighPriorityEne = false;
                        EnemyNotSupported = false;
                        IsNextMovemntIsCheckOrCheckMateForEnemy = false;
                    }
                    Object OO = new Object();
                    lock (OO)
                    {
                        LearningV[0] = IsCurrentCanGardHighPriorityEne;
                        LearningV[1] = IsNextMovemntIsCheckOrCheckMateForCurrent;
                        LearningV[2] = IsDangerous;
                        LearningV[3] = CanKillerAnUnSupportedEnemy;
                        LearningV[4] = InDangrousUnSupported;
                        LearningV[5] = Support;
                        LearningV[6] = IsNextMovemntIsCheckOrCheckMateForEnemy;
                        LearningV[7] = IsPrviousMovemntIsDangrousForCurr;
                        LearningV[8] = PDo;
                        LearningV[9] = RDo;
                        LearningV[10] = SelfNotSupported;
                        LearningV[11] = EnemyNotSupported;
                        LearningV[12] = IsGardForCurrentMovmentsAndIsNotMova;
                        LearningV[13] = IsNotSafeToMoveAenemeyToAttackMoreThanTowObj;
                        //if (IsNextMovemntIsCheckOrCheckMateForCurrent)
                        CanKillerAnUnSupportedEnemy = Support || EnemyNotSupported || IsCurrentCanGardHighPriorityEne || IsNextMovemntIsCheckOrCheckMateForEnemy || IsNextMovemntIsCheckOrCheckMateForCurrent;
                        P = IsNotSafeToMoveAenemeyToAttackMoreThanTowObj || IsGardForCurrentMovmentsAndIsNotMova || IsPrviousMovemntIsDangrousForCurr || SelfNotSupported || IsDangerous || IsCurrentCanGardHighPriorityEne || IsNextMovemntIsCheckOrCheckMateForEnemy || IsNextMovemntIsCheckOrCheckMateForCurrent;
                        R = CanKillerAnUnSupportedEnemy;
                        InDangrousUnSupported = P && (!R);
                        PDo = P & (!R);
                        //B+C
                        RDo = R && (!P);
                    }
                }
                return LearningV;
            }
        }
        void CastlesThinkingRefrigtzChessPortable(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle
        )
        {
            Object O22 = new Object();
            lock (O22)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int(); int HeuristicCheckedMate = new int();
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                ///When There is Movments.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThinkingRefrigtzChessPortableRuleThinking(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination));
                th.Wait();
                th.Dispose();
                if (ab)
                {

                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                    bool Sup = false;
                    var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                    newTask1.Wait(); newTask1.Dispose();

                    if (!Sup)
                    {
                        ///Add Table to List of Private.
                        HitNumberCastle.Add(TableS[RowDestination, ColumnDestination]);
                        Object OO = new Object();
                        lock (OO)
                        {
                            ThinkingRun = true;
                        }
                    }
                    ///Predict Heuristic.
                    Object A = new object();
                    lock (A)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                    Object A1 = new object();
                    lock (A1)
                    {
                        if (!Sup) { NumbersOfAllNode++; }
                    }
                    int Killed = 0;
                    newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                    newTask1.Wait(); newTask1.Dispose();


                    //if (!Sup)
                    {
                        Object A3 = new object();
                        lock (A3)
                        {
                            PenaltyVCar = false;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ///Store of Indexes Changes and Table in specific List.
                    newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                    newTask1.Wait(); newTask1.Dispose();
                    ///Wehn Predict of Operation Do operate a Predict of this movments.
                    Object A5 = new object();
                    lock (A5)
                    {
                        //Caused this for Stachostic results.
                        if (!Sup)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                        }
                    }
                    //Calculate Heuristic and Add to List and Cal Syntax.
                    if (!Sup)
                    {
                        String H = "";
                        Object A6 = new object();
                        lock (A6)
                        {
                            AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                            int[] Hu = new int[10];
                            //if (!(IsSup[j]))
                            {
                                //if (IgnoreFromCheckandMateHeuristic)

                                newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                                newTask1.Wait(); newTask1.Dispose();
                                H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                                HeuristicListCastle.Add(Hu);
                            }
                            Object O4 = new Object();
                            lock (O4)
                            {
                                ThinkingLevel++;
                                ThinkingAtRun = false;
                            }
                        }
                    }
                    else
                    {
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        int[] Hu = new int[10];
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                        newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        ThinkingAtRun = false;
                    }
                }
                else
                    MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1, -1);
            }
            ThinkingAtRun = false;
        }
        //specific determination for thinking main method
        void HourseThinkingRefrigtzChessPortable(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object OO = new Object();
            lock (OO)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int(); int HeuristicCheckedMate = new int();
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                ///When There is Movments.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThinkingRefrigtzChessPortableRuleThinking(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                    bool Sup = false;
                    var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                    newTask1.Wait(); newTask1.Dispose();
                    if (!Sup)
                    {
                        ///Add Table to List of Private.
                        HitNumberHourse.Add(TableS[RowDestination, ColumnDestination]);
                        Object O = new Object();
                        lock (O)
                        {
                            ThinkingRun = true;
                        }
                    }
                    ///Predict Heuristic.
                    Object A = new object();
                    lock (A)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                    Object A1 = new object();
                    lock (A1)
                    {
                        if (!Sup) { NumbersOfAllNode++; }
                    }
                    int Killed = 0;
                    newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                    newTask1.Wait(); newTask1.Dispose();


                    // if (!Sup)
                    {
                        Object A3 = new object();
                        lock (A3)
                        {
                            PenaltyVCar = false;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ///Store of Indexes Changes and Table in specific List.
                    newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                    newTask1.Wait(); newTask1.Dispose();
                    ///Wehn Predict of Operation Do operate a Predict of this movments.
                    Object A5 = new object();
                    lock (A5)
                    {
                        //Caused this for Stachostic results.
                        if (!Sup)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                        }
                    }
                    //Calculate Heuristic and Add to List and Cal Syntax.
                    if (!Sup)
                    {
                        String H = "";
                        Object A6 = new object();
                        lock (A6)
                        {
                            AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                            int[] Hu = new int[10];
                            //if (!(IsSup[j]))
                            {
                                //if (IgnoreFromCheckandMateHeuristic)

                                newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                                newTask1.Wait(); newTask1.Dispose();
                                H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                                HeuristicListHourse.Add(Hu);
                            }
                            Object O4 = new Object();
                            lock (O4)
                            {
                                ThinkingLevel++;
                                ThinkingAtRun = false;
                            }
                        }
                    }
                    else
                    {
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        int[] Hu = new int[10];
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                        newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                        newTask1.Wait(); newTask1.Dispose();
                        ThinkingAtRun = false;
                    }
                }
                else
                    MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1, -1);
            }
            ThinkingAtRun = false;
        }
        //specific determination for thinking main method
        //specific determination for thinking main method
        void ElephantThinkingRefrigtzChessPortable(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object OO = new Object();
            lock (OO)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int(); int HeuristicCheckedMate = new int();
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                ///When There is Movments.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThinkingRefrigtzChessPortableRuleThinking(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                    bool Sup = false;
                    var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                    newTask1.Wait(); newTask1.Dispose();
                    if (!Sup)
                    {
                        ///Add Table to List of Private.
                        HitNumberElefant.Add(TableS[RowDestination, ColumnDestination]);
                        Object O = new Object();
                        lock (O)
                        {
                            ThinkingRun = true;
                        }
                    }
                    ///Predict Heuristic.
                    Object A = new object();
                    lock (A)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                    Object A1 = new object();
                    lock (A1)
                    {
                        if (!Sup) { NumbersOfAllNode++; }
                    }
                    int Killed = 0;
                    newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                    newTask1.Wait(); newTask1.Dispose();


                    //if (!Sup)
                    {
                        Object A3 = new object();
                        lock (A3)
                        {
                            PenaltyVCar = false;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ///Store of Indexes Changes and Table in specific List.
                    newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                    newTask1.Wait(); newTask1.Dispose();
                    ///Wehn Predict of Operation Do operate a Predict of this movments.
                    Object A5 = new object();
                    lock (A5)
                    {
                        //Caused this for Stachostic results.
                        if (!Sup)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    //Calculate Heuristic and Add to List and Cal Syntax.
                    if (!Sup)
                    {
                        String H = "";
                        Object A6 = new object();
                        lock (A6)
                        {
                            AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);


                            int[] Hu = new int[10];
                            //if (!(IsSup[j]))
                            {
                                //if (IgnoreFromCheckandMateHeuristic)

                                newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                                newTask1.Wait(); newTask1.Dispose();
                                H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                                HeuristicListElefant.Add(Hu);
                            }
                            Object O4 = new Object();
                            lock (O4)
                            {
                                ThinkingLevel++;
                                ThinkingAtRun = false;
                            }
                        }
                    }
                    else
                    {
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        int[] Hu = new int[10];
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                        newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        ThinkingAtRun = false;
                    }
                }
                else
                    MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1, -1);
            }
            ThinkingAtRun = false;
        }
        //healthy of lists in learning auatama
        bool EqualitTow(bool PenRegStrore, int kind)
        {
            Object O = new Object();
            lock (O)
            {
                bool Equality = false;
                if (kind == 1 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder.Count == TableListSolder.Count)
                    Equality = true;
                else
                    if (kind == 2 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListElefant.Count == TableListElefant.Count)
                    Equality = true;
                else
                        if (kind == 3 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListHourse.Count == TableListHourse.Count)
                    Equality = true;
                else
                            if (kind == 4 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListCastle.Count == TableListCastle.Count)
                    Equality = true;
                else
                                if (kind == 5 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListMinister.Count == TableListMinister.Count)
                    Equality = true;
                else
                                    if (kind == 6 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListKing.Count == TableListKing.Count)
                    Equality = true;
                else
                                    if ((kind == 7 || kind == -7) && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListCastling.Count == TableListCastling.Count)
                    Equality = true;
                return Equality;
            }
        }
        //healthy of lists in learning auatama
        bool EqualitOne(QuantumAtamata Current, int kind)
        {
            Object O = new Object();
            lock (O)
            {
                bool Equality = false;
                if (kind == 1 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder != null && PenaltyRegardListSolder.Count == TableListSolder.Count)
                    Equality = true;
                else
                    if (kind == 2 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListElefant != null && PenaltyRegardListElefant.Count == TableListElefant.Count)
                    Equality = true;
                else
                        if (kind == 3 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListHourse != null && PenaltyRegardListHourse.Count == TableListHourse.Count)
                    Equality = true;
                else
                if (kind == 4 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListCastle != null && PenaltyRegardListCastle.Count == TableListCastle.Count)
                    Equality = true;
                else
                            if (kind == 5 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListMinister != null && PenaltyRegardListMinister.Count == TableListMinister.Count)
                    Equality = true;
                else
                                     if (kind == 6 && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListKing != null && PenaltyRegardListKing.Count == TableListKing.Count)
                    Equality = true;
                else
                                     if ((kind == 7 || kind == -7) && Current.IsPenaltyAction() != 0 && UsePenaltyRegardMechnisamT && PenaltyRegardListCastling != null && PenaltyRegardListCastling.Count == TableListCastling.Count)
                    Equality = true;
                return Equality;
            }
        }
        //add list 
        void AddAtList(int kind, QuantumAtamata Current)
        {
            Object O = new Object();
            lock (O)
            {
                //Adding Autamata Object to Specified List.
                if (kind == 1)
                    //Soldier
                    PenaltyRegardListSolder.Add(Current);
                else
                if (kind == 2)
                    //Elefant
                    PenaltyRegardListElefant.Add(Current);
                else
                    if (kind == 3)
                    //Hourse
                    PenaltyRegardListHourse.Add(Current);
                else
                        if (kind == 4)
                    //Castles.
                    PenaltyRegardListCastle.Add(Current);
                else
                            if (kind == 5)
                    //Minister.
                    PenaltyRegardListMinister.Add(Current);
                else
                                if (kind == 6)
                    //King.
                    PenaltyRegardListKing.Add(Current);
                else
                                if (kind == 7 || kind == -7)
                    //King.
                    PenaltyRegardListCastling.Add(Current);
            }

        }
        //remove list
        void RemoveAtList(int kind)
        {
            Object O = new Object();
            lock (O)
            {
                //Remove Last Atutamata Object.
                if (kind == 1)
                    //Soldier
                    PenaltyRegardListSolder.RemoveAt(PenaltyRegardListSolder.Count - 1);
                else
                if (kind == 2)
                    //Elefant
                    PenaltyRegardListElefant.RemoveAt(PenaltyRegardListElefant.Count - 1);
                else
                    if (kind == 3)
                    //Hourse
                    PenaltyRegardListHourse.RemoveAt(PenaltyRegardListHourse.Count - 1);
                else
                        if (kind == 4)
                    //Castles
                    PenaltyRegardListCastle.RemoveAt(PenaltyRegardListCastle.Count - 1);
                else
                            if (kind == 5)
                    //Minister
                    PenaltyRegardListMinister.RemoveAt(PenaltyRegardListMinister.Count - 1);
                else
                                if (kind == 6)
                    //King.
                    PenaltyRegardListKing.RemoveAt(PenaltyRegardListKing.Count - 1);
                else
                                if (kind == 7 || kind == -7)
                    //King.
                    PenaltyRegardListCastling.RemoveAt(PenaltyRegardListCastling.Count - 1);
            }
        }
        //learning autamata maib method
        void PenaltyMechanisam(ref bool RETURN, ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, ref int CheckedM, int Killed, bool Before, int kind, int[,] TableS, int ii, int jj, ref QuantumAtamata Current, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int i, int j, bool Castle)
        {
            Object OO = new Object();
            lock (OO)
            {
                RETURN = false;
                Object O3 = new Object();
                ChessRules AA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TableS[ii, jj], CloneATable(TableS), Order, ii, jj);
                Object O = new Object();
                lock (O)
                {
                    if (!UsePenaltyRegardMechnisamT || (GoldenFinished))
                    {
                        RETURN = true;
                        AddAtList(kind, Current);

                    }
                    //Consideration to go to Check.  
                    //if (!UsePenaltyRegardMechnisamT)
                    AA.CheckMate(CloneATable(TableS), Order);
                    {
                        if (AllDraw.OrderPlateDraw == 1 && AA.CheckMateBrown)
                        {
                            Object A = new Object();
                            lock (A)
                            {
                                IsThereMateOfEnemy.Add(true);
                                IsThereCheckOfSelf.Add(false);
                                IsThereCheckOfEnemy.Add(false);
                                IsThereMateOfSelf.Add(false);
                                KishEnemy.Add(true);
                                KishSelf.Add(false);
                                FoundFirstMating++;
                                if (Order == AllDraw.OrderPlateDraw)
                                {
                                    WinChiled.Add(2);
                                    LoseChiled.Add(0);
                                    WinOcuuredatChiled = 2;
                                }
                                if (!(!UsePenaltyRegardMechnisamT || (GoldenFinished)))
                                {
                                    Current.LearningAlgorithmRegard();
                                    RemoveAtList(kind);
                                    AddAtList(kind, Current);
                                }
                                CheckedM = 3;
                                RETURN = true; return;
                            }

                        }
                        if (AllDraw.OrderPlateDraw == -1 && AA.CheckMateGray)
                        {
                            DoEnemySelf = false;
                            Object A = new Object();
                            lock (A)
                            {
                                IsThereMateOfEnemy.Add(true);
                                IsThereCheckOfSelf.Add(false);
                                IsThereCheckOfEnemy.Add(false);
                                IsThereMateOfSelf.Add(false);
                                KishEnemy.Add(true);
                                KishSelf.Add(false);
                                FoundFirstMating++;
                                if (Order == AllDraw.OrderPlateDraw)
                                {
                                    WinChiled.Add(2);
                                    LoseChiled.Add(0);
                                    WinOcuuredatChiled = 2;
                                }
                                if (!(!UsePenaltyRegardMechnisamT || (GoldenFinished)))
                                {
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmRegard();
                                    AddAtList(kind, Current);
                                }
                                CheckedM = 3;
                                RETURN = true; return;
                            }
                        }
                        if (//(AllDraw.OrderPlateDraw == -1 && AA.CheckBrown)|| 
                            (AllDraw.OrderPlateDraw == -1 && AA.CheckMateBrown))
                        {
                            Object A = new Object();
                            lock (A)
                            {
                                IsThereMateOfEnemy.Add(false);
                                IsThereMateOfSelf.Add(true);
                                IsThereCheckOfSelf.Add(false);
                                IsThereCheckOfEnemy.Add(false);
                                KishEnemy.Add(false);
                                KishSelf.Add(true);
                                FoundFirstSelfMating++;
                                if (Order == AllDraw.OrderPlateDraw)
                                {
                                    WinChiled.Add(0);
                                    LoseChiled.Add(-2);
                                    LoseOcuuredatChiled[0] = -2;
                                }
                                if (!(!UsePenaltyRegardMechnisamT || (GoldenFinished)))
                                {
                                    Current.LearningAlgorithmPenalty();
                                    RemoveAtList(kind);
                                    AddAtList(kind, Current);
                                }
                                CheckedM = 3;
                                RETURN = true; return;
                            }

                        }
                        if (//(AllDraw.OrderPlateDraw == 1 && AA.CheckGray) ||
                            (AllDraw.OrderPlateDraw == 1 && AA.CheckMateGray))
                        {
                            DoEnemySelf = false;
                            Object A = new Object();
                            lock (A)
                            {
                                IsThereMateOfEnemy.Add(false);
                                IsThereMateOfSelf.Add(true);
                                IsThereCheckOfSelf.Add(false);
                                IsThereCheckOfEnemy.Add(false);
                                KishEnemy.Add(false);
                                KishSelf.Add(true);
                                FoundFirstSelfMating++;
                                if (Order == AllDraw.OrderPlateDraw)
                                {
                                    WinChiled.Add(0);
                                    LoseChiled.Add(-2);
                                    LoseOcuuredatChiled[0] = -2;
                                }
                                if (!(!UsePenaltyRegardMechnisamT || (GoldenFinished)))
                                {
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                CheckedM = 3;
                                RETURN = true; return;
                            }
                        }
                        /*  if (Order == 1 && AA.CheckMateBrown)
                          {
                              IsThereCheckOfEnemy.Add(true);
                              IsThereMateOfEnemy.Add(false);
                              IsThereMateOfSelf.Add(false);
                              IsThereCheckOfSelf.Add(false);
                              KishEnemy.Add(true);
                              KishSelf.Add(false);
                              DoEnemySelf = false;
                              EnemyCheckMateActionsString = true;
                              CheckedM = -2;
                          }
                          if (Order == -1 && AA.CheckMateGray)
                          {

                              IsThereCheckOfEnemy.Add(true);
                              IsThereMateOfEnemy.Add(false);
                              IsThereMateOfSelf.Add(false);
                              IsThereCheckOfSelf.Add(false);
                              KishEnemy.Add(true);
                              KishSelf.Add(false);
                              DoEnemySelf = false;
                              EnemyCheckMateActionsString = true;
                              CheckedM = -2;
                          }
                          if (Order == 1 && AA.CheckMateGray)
                          {
                              IsThereCheckOfEnemy.Add(false);
                              IsThereMateOfEnemy.Add(false);
                              IsThereMateOfSelf.Add(true);
                              IsThereCheckOfSelf.Add(false);
                              KishEnemy.Add(false);
                              KishSelf.Add(true);
                              EnemyCheckMateActionsString = false;
                              CheckedM = -2;
                          }
                          if (Order == -1 && AA.CheckMateBrown)
                          {
                              IsThereCheckOfEnemy.Add(false);
                              IsThereMateOfEnemy.Add(false);
                              IsThereMateOfSelf.Add(true);
                              IsThereCheckOfSelf.Add(false);
                              KishEnemy.Add(false);
                              KishSelf.Add(true);
                              EnemyCheckMateActionsString = false;
                              CheckedM = -2;
                          }
                        */
                        if (AllDraw.OrderPlateDraw == 1 && AA.CheckGray)
                        {
                            IsThereCheckOfEnemy.Add(false);
                            IsThereMateOfEnemy.Add(false);
                            IsThereMateOfSelf.Add(false);
                            IsThereCheckOfSelf.Add(false);
                            KishSelf.Add(true);
                            KishEnemy.Add(false);

                            Object A = new object();
                            lock (A)
                            {
                                NumberOfPenalties++;
                            }
                            CheckedM = -1;
                        }
                        else
                            if (AllDraw.OrderPlateDraw == -1 && AA.CheckBrown)
                        {
                            IsThereCheckOfEnemy.Add(false);
                            IsThereMateOfEnemy.Add(false);
                            IsThereMateOfSelf.Add(false);
                            IsThereCheckOfSelf.Add(false);
                            KishSelf.Add(true);
                            KishEnemy.Add(false);
                            Object A = new object();
                            lock (A)
                            {
                                NumberOfPenalties++;
                            }
                            CheckedM = -1;
                        }
                        if (AllDraw.OrderPlateDraw == 1 && AA.CheckBrown)
                        {
                            IsThereCheckOfEnemy.Add(false);
                            IsThereMateOfEnemy.Add(false);
                            IsThereMateOfSelf.Add(false);
                            IsThereCheckOfSelf.Add(false);
                            KishEnemy.Add(true);
                            KishSelf.Add(false);
                            Object A = new object();
                            lock (A)
                            {
                                NumberOfPenalties++;
                            }
                            CheckedM = -1;
                        }
                        if (AllDraw.OrderPlateDraw == -1 && AA.CheckGray)
                        {
                            IsThereCheckOfEnemy.Add(false);
                            IsThereMateOfEnemy.Add(false);
                            IsThereMateOfSelf.Add(false);
                            IsThereCheckOfSelf.Add(false);
                            KishEnemy.Add(true);
                            KishSelf.Add(false);
                            Object A = new object();
                            lock (A)
                            {
                                NumberOfPenalties++;
                            }
                            CheckedM = -1;
                        }
                        //if (FoundFirstSelfMating > 0)
                        {
                        }

                    }
                    if (CheckedM != 3)
                    {
                        WinChiled.Add(0);
                        LoseChiled.Add(0);
                    }
                    if (CheckedM != -2 && CheckedM != -1)
                    {
                        IsThereCheckOfEnemy.Add(false);
                        IsThereMateOfEnemy.Add(false);
                        IsThereMateOfSelf.Add(false);
                        IsThereCheckOfSelf.Add(false);
                        KishEnemy.Add(false);
                        KishSelf.Add(false);
                    }
                    if (RETURN)
                        return;
                    if (AllDraw.OrderPlateDraw != Order)
                        return;

                }
                //Initiate Local Variables.
                bool IsCurrentCanGardHighPriorityEne = new bool();
                bool IsNextMovemntIsCheckOrCheckMateForCurrent = new bool();
                bool IsNextMovemntIsCheckOrCheckMateForEnemy = new bool();
                bool IsDangerous = new bool();
                bool CanKillerAnUnSupportedEnemy = new bool();
                bool InDangrousUnSupported = new bool();
                bool Support = new bool();
                bool IsPrviousMovemntIsDangrousForCurr = new bool();
                bool PDo = new bool(), RDo = new bool();
                bool SelfNotSupported = new bool();
                bool EnemyNotSupported = new bool();
                bool IsGardForCurrentMovmentsAndIsNotMova = new bool();
                bool IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = new bool();
                bool[] LearningV = null;
                //Mechanisam of Regrad.  
                Object O1 = new Object();
                lock (O1)
                {
                    if (kind == 1 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListSolder != null && PenaltyRegardListSolder.Count == TableListSolder.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                    else
                     if (kind == 2 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListElefant != null && PenaltyRegardListElefant.Count == TableListElefant.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                    else
                        if (kind == 3 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListHourse != null && PenaltyRegardListHourse.Count == TableListHourse.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                    else
                        if (kind == 4 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListCastle != null && PenaltyRegardListCastle.Count == TableListCastle.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                    else
                            if (kind == 5 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListMinister != null && PenaltyRegardListMinister.Count == TableListMinister.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                    else
                                if (kind == 6 && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListKing != null && PenaltyRegardListKing.Count == TableListKing.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                    else
                                if ((kind == 7 || Kind == -7) && PenRegStrore && UsePenaltyRegardMechnisamT && PenaltyRegardListCastling != null && PenaltyRegardListCastling.Count == TableListCastling.Count)
                    {
                        var newTask2 = Task.Factory.StartNew(() => LearningV = CalculateLearningVars(Killed, CloneATable(TableS), ii, jj, i, j));
                        newTask2.Wait();
                        newTask2.Dispose();
                    }
                }
                Object O2 = new Object();
                lock (O2)
                {
                    IsCurrentCanGardHighPriorityEne = LearningV[0];
                    IsNextMovemntIsCheckOrCheckMateForCurrent = LearningV[1];
                    IsDangerous = LearningV[2];
                    CanKillerAnUnSupportedEnemy = LearningV[3];
                    InDangrousUnSupported = LearningV[4];
                    Support = LearningV[5];
                    IsNextMovemntIsCheckOrCheckMateForEnemy = LearningV[6];
                    IsPrviousMovemntIsDangrousForCurr = LearningV[7];
                    PDo = LearningV[8];
                    RDo = LearningV[9];
                    SelfNotSupported = LearningV[10];
                    EnemyNotSupported = LearningV[11];
                    IsGardForCurrentMovmentsAndIsNotMova = LearningV[12];
                    IsNotSafeToMoveAenemeyToAttackMoreThanTowObj = LearningV[13];
                }
                //Consideration of Itterative Movments to ignore.
                //Operation of Penalty Regard Mechanisam on Check and mate speciffically.
                bool Equality = EqualitOne(Current, kind);
                Object O4 = new Object();
                lock (O4)
                {
                    if (Equality)
                    {
                        ChessRules A = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TableS[ii, jj], CloneATable(TableS), Order, Row, Column);
                        if (A.Check(CloneATable(TableS), Order))
                        {
                            if (Order == 1 && (A.CheckGray))
                            {
                                NumberOfPenalties++;
                                Current.LearningAlgorithmPenalty();
                            }
                            else
                                if (Order == -1 && (A.CheckBrown))
                            {
                                NumberOfPenalties++;
                                Current.LearningAlgorithmPenalty();
                            }
                            AddAtList(kind, Current);
                        }
                        else
                        {
                            if (IsCurrentStateIsDangreousForCurrentOrder(CloneATable(TableS), Order, color, i, j) && DoEnemySelf)
                            {
                                NumberOfPenalties++;
                                Current.LearningAlgorithmPenalty();
                                AddAtList(kind, Current);
                            }
                            else
                                AddAtList(kind, Current);
                        }
                        //When There is Penalty or Regard.To Side can not be equal.
                        if (PDo || RDo)
                        {
                            //Penalty.
                            if (PDo)
                            {
                                Object OO1 = new Object();
                                lock (OO1)
                                {
                                    for (var ik = 0; ik < System.Math.Abs(TableS[i, j]); ik++)
                                        LearniningTable.LearningAlgorithmPenaltyNet(ii, jj);
                                }
                                //When previous Move of Enemy goes to Dangoure Current Object.
                                if (IsPrviousMovemntIsDangrousForCurr && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                //For Not Suppored In Attacked.
                                if (SelfNotSupported && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                //When Current Move Dos,'t Supporte.
                                //For Ocuuring in Enemy CheckMate.
                                if (SelfNotSupported && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (IsGardForCurrentMovmentsAndIsNotMova && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (IsNotSafeToMoveAenemeyToAttackMoreThanTowObj && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (IsDangerous && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }

                                if (EnemyNotSupported && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmRegard();
                                    AddAtList(kind, Current);
                                }

                            }
                            else if (RDo)
                            {
                                Object OOO = new Object();
                                lock (OOO)
                                {
                                    for (var ik = 0; ik < System.Math.Abs(TableS[i, j]); ik++)
                                        LearniningTable.LearningAlgorithmRegardNet(ii, jj);
                                }
                                if (SelfNotSupported && Current.IsPenaltyAction() != 0)
                                {
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (IsGardForCurrentMovmentsAndIsNotMova && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (IsNotSafeToMoveAenemeyToAttackMoreThanTowObj && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (IsDangerous && Current.IsPenaltyAction() != 0)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmPenalty();
                                    AddAtList(kind, Current);
                                }
                                if (EnemyNotSupported && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
                                {
                                    NumberOfPenalties++;
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmRegard();
                                    AddAtList(kind, Current);
                                }

                                if (IsCurrentCanGardHighPriorityEne && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
                                {
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmRegard();
                                    AddAtList(kind, Current);
                                }
                                //For Ocuuring Enemy Garding Objects.
                                if (Support && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
                                {
                                    RemoveAtList(kind);
                                    Current.LearningAlgorithmRegard();
                                    AddAtList(kind, Current);
                                }
                            }

                        }
                        else
                        {
                            //#pragma warning disable CS0219 // The variable 'Added' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'Added' is assigned but its value is never used
                            bool Added = false;
#pragma warning restore CS0219 // The variable 'Added' is assigned but its value is never used
                            //#pragma warning restore CS0219 // The variable 'Added' is assigned but its value is never used
                            Object OO1 = new Object();
                            lock (OO1)
                            {
                                for (var ik = 0; ik < System.Math.Abs(TableS[i, j]); ik++)
                                {
                                    LearniningTable.LearningAlgorithmRegardNet(ii, jj);
                                    LearniningTable.LearningAlgorithmPenaltyNet(ii, jj);
                                }
                            }
                            if (IsNextMovemntIsCheckOrCheckMateForCurrent && Current.IsPenaltyAction() != 0)
                            {
                                NumberOfPenalties++;
                                RemoveAtList(kind);
                                Current.LearningAlgorithmPenalty();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (SelfNotSupported && Current.IsPenaltyAction() != 0)
                            {
                                RemoveAtList(kind);
                                Current.LearningAlgorithmPenalty();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (IsGardForCurrentMovmentsAndIsNotMova && Current.IsPenaltyAction() != 0)
                            {
                                NumberOfPenalties++;
                                RemoveAtList(kind);
                                Current.LearningAlgorithmPenalty();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (IsNotSafeToMoveAenemeyToAttackMoreThanTowObj && Current.IsPenaltyAction() != 0)
                            {
                                NumberOfPenalties++;
                                RemoveAtList(kind);
                                Current.LearningAlgorithmPenalty();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (IsDangerous && Current.IsPenaltyAction() != 0)
                            {
                                NumberOfPenalties++;
                                RemoveAtList(kind);
                                Current.LearningAlgorithmPenalty();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (IsNextMovemntIsCheckOrCheckMateForEnemy && Current.IsPenaltyAction() != 0)
                            {
                                RemoveAtList(kind);
                                Current.LearningAlgorithmRegard();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (IsCurrentCanGardHighPriorityEne && Current.IsPenaltyAction() != 0)
                            {
                                RemoveAtList(kind);
                                Current.LearningAlgorithmRegard();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                            if (EnemyNotSupported && Current.IsPenaltyAction() != 0 && Current.IsRewardAction() != 1)
                            {
                                NumberOfPenalties++;
                                RemoveAtList(kind);
                                Current.LearningAlgorithmRegard();
                                AddAtList(kind, Current);
                                Added = true;
                            }
                        }
                    }
                }
                return;
            }
        }
        void SoldierConversion(ref ThingsConverter t, int RowSource, int ColumnSource, int RowDestination, int ColumnDestination, int[,] TableS)
        {
            Object O = new Object();
            lock (O)
            {
                t.ConvertOperation((int)RowSource, (int)ColumnSource, color, CloneATable(TableS), Order, false, 0);
                int[,] TableCon = new int[8, 8];
                if (t.Convert)
                {
                    TableS[RowSource, ColumnSource] = 0;
                    if (t.ConvertedToMinister)
                        TableS[RowDestination, ColumnDestination] = 5;
                    else if (t.ConvertedToCastle)
                        TableS[RowDestination, ColumnDestination] = 4;
                    else if (t.ConvertedToHourse)
                        TableS[RowDestination, ColumnDestination] = 3;
                    else if (t.ConvertedToElefant)
                        TableS[RowDestination, ColumnDestination] = 2;
                    if (Order == -1)
                        TableS[RowDestination, ColumnDestination] *= -1;

                }
            }
        }
        int KilledBool(int row1, int col1, int row2, int col2, int[,] tab)
        {
            Object O = new Object();
            lock (O)
            {
                if (tab[row1, col1] != 0 && tab[row2, col2] != 0)
                {
                    if (tab[row2, col2] > 0)
                        return 1;
                    if (tab[row2, col2] < 0)
                        return -1;
                }
                return 0;
            }
        }
        //specific determination for thinking main method
        void SupMethod(int[,] TableS, int RowSource, int ColumnSource, int RowDestination, int ColumnDestination, ref bool Sup)
        {
            Object O = new Object();
            lock (O)
            {
                if (TableS[RowDestination, ColumnDestination] > 0 && TableS[RowSource, ColumnSource] > 0)
                {
                    IsSup.Add(true);
                    IsSupHu.Add(true);
                    Sup = true;
                }
                else
                      if (TableS[RowDestination, ColumnDestination] < 0 && TableS[RowSource, ColumnSource] < 0)
                {
                    IsSup.Add(true);
                    IsSupHu.Add(true);
                    Sup = true;
                }
                else
                {
                    IsSup.Add(false);
                    IsSupHu.Add(false);
                    Sup = false;
                }
            }
        }
        void KilledMethod(ref int Killed, bool Sup, int RowSource, int ColumnSource, int RowDestination, int ColumnDestination, ref int[,] TableS, ThingsConverter t = null)
        {
            Object O = new Object();
            lock (O)
            {
                Killed = 0;
                if (!Sup)
                {
                    if (t != null)
                    {
                        if ((!t.Convert))
                        {
                            Object A2 = new object();
                            lock (A2)
                            {
                                MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1);
                                Killed = TableConst[RowDestination, ColumnDestination];
                                TableS[RowDestination, ColumnDestination] = TableS[RowSource, ColumnSource];
                                TableS[RowSource, ColumnSource] = 0;
                            }
                        }
                        else
                        {
                            int con = 1;
                            if (t.ConvertedToMinister)
                                con = 5;
                            else
                            if (t.ConvertedToCastle)
                                con = 4;
                            else
                            if (t.ConvertedToHourse)
                                con = 3;
                            else
                            if (t.ConvertedToElefant)
                                con = 2;

                            MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, con);
                            Killed = TableConst[RowDestination, ColumnDestination];
                            TableS[RowDestination, ColumnDestination] = (Math.Abs(TableS[RowSource, ColumnSource]) / TableS[RowSource, ColumnSource]) * con;
                            TableS[RowSource, ColumnSource] = 0;
                        }
                    }
                    else
                    {
                        Object A2 = new object();
                        lock (A2)
                        {
                            MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1);
                            Killed = TableConst[RowDestination, ColumnDestination];
                            if (!(Kind == 7 || Kind == -7))
                            {
                                TableS[RowDestination, ColumnDestination] = TableS[RowSource, ColumnSource];
                                TableS[RowSource, ColumnSource] = 0;
                            }
                            else
                            {
                                if (RowDestination < RowSource)
                                {
                                    TableS[RowSource - 1, ColumnDestination] = 4;
                                    TableS[RowSource - 2, ColumnDestination] = 6;
                                    TableS[RowSource - 4, ColumnDestination] = 0;
                                    TableS[RowSource, ColumnSource] = 0;

                                }
                                else
                                {
                                    TableS[RowSource + 1, ColumnDestination] = 4;
                                    TableS[RowSource + 2, ColumnDestination] = 6;
                                    TableS[RowSource + 3, ColumnDestination] = 0;
                                    TableS[RowSource, ColumnSource] = 0;

                                }
                            }
                        }
                    }
                }
                KillerAtThinking.Add(KilledBool(RowSource, ColumnSource, RowDestination, ColumnDestination, TableS));
                return;
            }
        }
        void ObjectIndexes(int Kind, bool Sup, int RowDestination, int ColumnDestination, int[,] TableS)
        {
            Object O = new Object();
            lock (O)
            {
                if (!Sup)
                {
                    if (Kind == 1)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnSoldier.Add(AS);

                            TableListSolder.Add(CloneATable(TableS));
                            IndexSoldier++;
                        }
                    }
                    else
                    if (Kind == 2)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnElefant.Add(AS);

                            TableListElefant.Add(CloneATable(TableS));
                            IndexElefant++;
                        }
                    }
                    else
                    if (Kind == 3)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnHourse.Add(AS);

                            TableListHourse.Add(CloneATable(TableS));
                            IndexHourse++;
                        }
                    }
                    else
                    if (Kind == 4)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnCastle.Add(AS);

                            TableListCastle.Add(CloneATable(TableS));
                            IndexCastle++;
                        }
                    }
                    if (Kind == 5)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnMinister.Add(AS);

                            TableListMinister.Add(CloneATable(TableS));
                            IndexMinister++;
                        }
                    }
                    else
                    if (Kind == 6)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnKing.Add(AS);

                            TableListKing.Add(CloneATable(TableS));
                            IndexKing++;
                        }
                    }
                    else
                    if (Kind == 7 || Kind == -7)
                    {
                        Object A4 = new object();
                        lock (A4)
                        {
                            int[] AS = new int[2];
                            AS[0] = RowDestination;
                            AS[1] = ColumnDestination;
                            RowColumnCastling.Add(AS);

                            TableListCastling.Add(CloneATable(TableS));
                            IndexKing++;
                        }
                    }
                }
            }
        }
        void HeuristicInsertion(int Kind, int RowDestination, int ColumnDestination, int[,] TableS, int[] Hu)
        {
            Object A4 = new object();
            lock (A4)
            {
                if (Kind == 1)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnSoldier.Add(AS);

                    TableListSolder.Add(CloneATable(TableS));
                    IndexSoldier++;
                    HeuristicListSolder.Add(Hu);
                    HitNumberSoldier.Add(TableS[RowDestination, ColumnDestination]);
                }
                else
                if (Kind == 2)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnElefant.Add(AS);

                    TableListElefant.Add(CloneATable(TableS));
                    IndexElefant++;
                    HeuristicListElefant.Add(Hu);
                    HitNumberElefant.Add(TableS[RowDestination, ColumnDestination]);
                }
                else
                if (Kind == 3)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnHourse.Add(AS);

                    TableListHourse.Add(CloneATable(TableS));
                    IndexHourse++;
                    HeuristicListHourse.Add(Hu);
                    HitNumberHourse.Add(TableS[RowDestination, ColumnDestination]);
                }
                else
                if (Kind == 4)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnCastle.Add(AS);

                    TableListCastle.Add(CloneATable(TableS));
                    IndexCastle++;
                    HeuristicListCastle.Add(Hu);
                    HitNumberCastle.Add(TableS[RowDestination, ColumnDestination]);
                }
                else
                if (Kind == 5)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnMinister.Add(AS);

                    TableListMinister.Add(CloneATable(TableS));
                    IndexSoldier++;
                    HeuristicListMinister.Add(Hu);
                    HitNumberMinister.Add(TableS[RowDestination, ColumnDestination]);

                }
                else
                if (Kind == 6)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnKing.Add(AS);

                    TableListKing.Add(CloneATable(TableS));
                    IndexKing++;
                    HeuristicListKing.Add(Hu);
                    HitNumberKing.Add(TableS[RowDestination, ColumnDestination]);
                }
                else
                if (Kind == 7 || Kind == -7)
                {
                    int[] AS = new int[2];
                    AS[0] = RowDestination;
                    AS[1] = ColumnDestination;
                    RowColumnCastling.Add(AS);

                    TableListCastling.Add(CloneATable(TableS));
                    IndexCastling++;
                    HeuristicListCastling.Add(Hu);
                    HitNumberCastling.Add(TableS[RowDestination, ColumnDestination]);
                }
            }
        }
        bool ThinkingRefrigtzChessPortableRuleThinking(int[,] TableS, int RowSource, int ColumnSource, int RowDestination, int ColumnDestination)
        {
            Object O = new Object();
            lock (O)
            {
                return (new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TableS[RowSource, ColumnSource], CloneATable(TableS), Order, RowSource, ColumnSource)).Rules(RowSource, ColumnSource, RowDestination, ColumnDestination, color, TableS[RowSource, ColumnSource], false);
            }
        }
        void SolderThinkingRefrigtzChessPortable(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int(); int HeuristicCheckedMate = new int();
                Order = DummyOrder;
                ChessRules.CurrentOrder = DummyCurrentOrder;
                ///When There is Movments.
                bool ab = false;
                var th = Task.Factory.StartNew(() => ab = ThinkingRefrigtzChessPortableRuleThinking(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination));
                th.Wait();
                th.Dispose();
                if (ab)
                {
                    ThingsConverter t = new ThingsConverter(ArrangmentsChanged, RowSource, ColumnSource, color, CloneATable(TableS), Order, false, 0);
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                    bool Sup = false;
                    var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                    newTask1.Wait(); newTask1.Dispose();

                    if (!Sup)
                    {
                        newTask1 = Task.Factory.StartNew(() => SoldierConversion(ref t, RowSource, ColumnSource, RowDestination, ColumnDestination, TableS));
                        newTask1.Wait(); newTask1.Dispose();
                        ///Add Table to List of Private.
                        HitNumberSoldier.Add(TableS[RowDestination, ColumnDestination]);
                        Object O = new Object();
                        lock (O)
                        {
                            ThinkingRun = true;
                        }
                    }
                    ///Predict Heuristic.
                    Object A = new object();
                    lock (A)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                    Object A1 = new object();
                    lock (A1)
                    {
                        if (!Sup) { NumbersOfAllNode++; }
                    }

                    int Killed = 0;
                    newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS, t));
                    newTask1.Wait(); newTask1.Dispose();

                    //if (!Sup)
                    {
                        Object A3 = new object();
                        lock (A3)
                        {
                            PenaltyVCar = false;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ///Store of Indexes Changes and Table in specific List.
                    newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                    newTask1.Wait(); newTask1.Dispose();
                    ///Wehn Predict of Operation Do operate a Predict of this movments.
                    Object A5 = new object();
                    lock (A5)
                    {
                        //Caused this for Stachostic results.
                        if (!Sup)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                        }
                    }
                    //Calculate Heuristic and Add to List and Cal Syntax.
                    if (!Sup)
                    {
                        String H = "";
                        Object A6 = new object();
                        lock (A6)
                        {
                            AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                            int[] Hu = new int[10];
                            //if (!(IsSup[j]))
                            {
                                //if (IgnoreFromCheckandMateHeuristic)

                                newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                                newTask1.Wait(); newTask1.Dispose();
                                H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                                HeuristicListSolder.Add(Hu);
                            }
                        }
                        Object O4 = new Object();
                        lock (O4)
                        {
                            ThinkingLevel++;
                            ThinkingAtRun = false;
                        }
                    }
                    else
                    {
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        int[] Hu = new int[10];
                        newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                        newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                        newTask1.Wait(); newTask1.Dispose();

                        ThinkingAtRun = false;
                    }

                }
                else
                    MovableAllObjectsListMethos(CloneATable(TableS), true, RowSource, ColumnSource, RowDestination, ColumnDestination, 1, -1);
            }
            ThinkingAtRun = false;
        }
        //specific determination for thinking main method
        void CastleThinkingBrown(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int();
                int HeuristicCheckedMate = new int();
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                bool Sup = false;
                var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                newTask1.Wait(); newTask1.Dispose();
                if (!Sup)
                {
                    ///Add Table to List of Private.
                    HitNumberCastling.Add(TableS[RowDestination, ColumnDestination]);
                    Object OO = new Object();
                    lock (OO)
                    {
                        ThinkingRun = true;
                    }
                }
                ///Predict Heuristic.
                Object A = new object();
                lock (A)
                {
                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                    newTask1.Wait(); newTask1.Dispose();
                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                }
                Object A1 = new object();
                lock (A1)
                {
                    if (!Sup) { NumbersOfAllNode++; }
                }
                int Killed = 0;
                newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                newTask1.Wait(); newTask1.Dispose();


                // if (!Sup)
                {
                    Object A3 = new object();
                    lock (A3)
                    {
                        PenaltyVCar = false;
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
                ///Store of Indexes Changes and Table in specific List.
                newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                newTask1.Wait(); newTask1.Dispose();
                ///Wehn Predict of Operation Do operate a Predict of this movments.
                Object A5 = new object();
                lock (A5)
                {
                    //Caused this for Stachostic results.
                    if (!Sup)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
                //Calculate Heuristic and Add to List and Cal Syntax.
                if (!Sup)
                {
                    String H = "";
                    Object A6 = new object();
                    lock (A6)
                    {
                        AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                        int[] Hu = new int[10];
                        //if (!(IsSup[j]))
                        {
                            //if (IgnoreFromCheckandMateHeuristic)

                            newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                            HeuristicListCastling.Add(Hu);
                        }
                    }
                    Object O4 = new Object();
                    lock (O4)
                    {
                        ThinkingLevel++;
                        ThinkingAtRun = false;
                    }
                }
                else
                {
                    newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                    newTask1.Wait(); newTask1.Dispose();
                    int[] Hu = new int[10];
                    newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                    newTask1.Wait(); newTask1.Dispose();

                    String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();

                    newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                    newTask1.Wait(); newTask1.Dispose();
                    ThinkingAtRun = false;
                }

            }
            ThinkingAtRun = false;

        }
        int HeuristicBetterSpace(int[,] TableSS, Color colorS, Color colorE, int OrderS, int OrderE)
        {
            Object OO = new Object();
            lock (OO)
            {
                int HA = 0;
                int SpaceSelf = 0, SpaceEnemy = 0;
                for (int RowS = 0; RowS < 8; RowS++)
                {
                    for (int ColS = 0; ColS < 8; ColS++)
                    {
                        for (int RowD = 0; RowD < 8; RowD++)
                        {
                            for (int ColD = 0; ColD < 8; ColD++)
                            {
                                if ((Order == 1 && TableSS[RowS, ColS] > 0) || (Order == -1 && TableSS[RowS, ColS] < 0))
                                {
                                    if (Attack(CloneATable(TableSS), RowS, ColS, RowD, ColD, colorS, OrderS))
                                        SpaceSelf++;
                                }
                                if ((Order == 1 && TableSS[RowD, ColD] < 0) || (Order == -1 && TableSS[RowD, ColD] > 0))
                                {
                                    if (Attack(CloneATable(TableSS), RowD, ColD, RowS, ColS, colorE, OrderE))
                                        SpaceEnemy++;
                                }
                            }
                        }
                    }
                }
                if (SpaceSelf > SpaceEnemy)
                    HA = RationalRegard;
                else
                    if (SpaceSelf < SpaceEnemy)
                    HA = RationalPenalty;
                return HA;
            }
        }
        bool SubOfHeuristicAllIsPositive(int[] Heuristic)
        {
            bool Is = true;
            if (Heuristic[0] + Heuristic[1] + Heuristic[2] + Heuristic[3] + Heuristic[4] + Heuristic[5] > 0)
                Is = true;
            else
                Is = false;
            return Is;
        }
        public int[] CalculateHeuristicsParallel(bool Before, int Killed, int[,] TableS, int RowS, int ColS, int RowD, int ColD, Color color
    )
        {
            Object OO = new Object();
            lock (OO)
            {
                int[] Heuristic = null;
                int[] Exchange = new int[3];
                int[] HeuristicRemain = new int[6];
                var output = Task.Factory.StartNew(() =>
                {
                    //if (!feedCancellationTokenSource.IsCancellationRequested)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
 {
     Object O = new Object();
     lock (O)
     {
         if (!Scop(RowS, ColS, RowD, ColD, Kind))
             return;
         int[,] TableSS = CloneATable(TableS);
         int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
         var H = Task.Factory.StartNew(() => Heuristic = HeuristicAll(Before, Killed, TableSS, color, Order));
         H.Wait();
         H.Dispose();
     }
 }, () =>
 {
     Object O = new Object();
     lock (O)
     {
         if (!Scop(RowS, ColS, RowD, ColD, Kind))
             return;
         int[,] TableSS = CloneATable(TableS);
         int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
         var H = Task.Factory.StartNew(() => Exchange = HeuristicExchange(Before, Killed, TableSS, color, Order, RowS, ColS, RowD, ColD));
         H.Wait();
         H.Dispose();
     }
 });
                    }
                });

                output.Wait(); output.Dispose();
                var output1 = Task.Factory.StartNew(() =>
                {
                    //if (!feedCancellationTokenSource.IsCancellationRequested)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
 {
     Object O = new Object();
     lock (O)
     {
        //if (SubOfHeuristicAllIsPositive(Heuristic))
        {
             if (!Scop(RowS, ColS, RowD, ColD, Kind))
                 return;
             int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
             int[,] TableSS = CloneATable(TableS);
             var H = Task.Factory.StartNew(() => HeuristicRemain[0] = HeuristicCheckAndCheckMate(RoS, CoS, RoD, CoD, TableSS, color//, ref HeuristicReducedMovementValue
             ));
             H.Wait();
             H.Dispose();
         }
     }
 }, () =>
 {
     Object O = new Object();
     lock (O)
     {
        //if (SubOfHeuristicAllIsPositive(Heuristic))
        {
             if (!Scop(RowS, ColS, RowD, ColD, Kind))
                 return;
             int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
             int[,] TableSS = CloneATable(TableS);
             var H = Task.Factory.StartNew(() => HeuristicRemain[1] = HeuristicDistribution(Before, TableSS, Order, color, RowS, ColS, RowD, ColD//, ref HeuristicDistributionValue
                  ));
             H.Wait();
             H.Dispose();
         }
     }
 }, () =>
 {
     Object O = new Object();
     lock (O)
     {
         if (!Scop(RowS, ColS, RowD, ColD, Kind))
             return;
         int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
         int[,] TableSS = CloneATable(TableS);
         var H = Task.Factory.StartNew(() => HeuristicRemain[2] = HeuristicKingSafety(TableSS, Order, color, CurrentAStarGredyMax, RoS, CoS, RoD, CoD//, ref HeuristicKingSafe
              ));
         H.Wait();
         H.Dispose();
     }
 }, () =>
 {
     Object O = new Object();
     lock (O)
     {
         if (!Scop(RowS, ColS, RowD, ColD, Kind))
             return;
         int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
         int[,] TableSS = CloneATable(TableS);
         var H = Task.Factory.StartNew(() => HeuristicRemain[3] = HeuristicKingPreventionOfCheckedAtBegin(TableSS, Order, color, CurrentAStarGredyMax, RoS, CoS, RoD, CoD//, ref HeuristicKingSafe
         ));
         H.Wait();
         H.Dispose();
     }
 }, () =>
 {
     Object O = new Object();
     lock (O)
     {
        //if (SubOfHeuristicAllIsPositive(Heuristic))
        {
             if (!Scop(RowS, ColS, RowD, ColD, Kind))
                 return;
             int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
             int[,] TableSS = CloneATable(TableS);
             var H = Task.Factory.StartNew(() => HeuristicRemain[4] = HeuristicObjectAtCenterAndPawnAttackTraversalObjectsAndDangourForEnemy(TableSS, color, Order, RoS, CoS, RoD, CoD));
             H.Wait();
             H.Dispose();
         }
     }
 }, () =>
 {
     Object O = new Object();
     lock (O)
     {
        //if (SubOfHeuristicAllIsPositive(Heuristic))
        {
             if (!Scop(RowS, ColS, RowD, ColD, Kind))
                 return;
             int RoS = RowS, CoS = ColS, RoD = RowD, CoD = ColD;
             int[,] TableSS = CloneATable(TableS);
             Color colorE = Color.Gray;
             if (Order == -1)
                 colorE = Color.Gray;
             else
                 colorE = Color.Brown;
             var H = Task.Factory.StartNew(() => HeuristicRemain[5] = HeuristicBetterSpace(TableSS, color, colorE, Order, Order * -1));
             H.Wait();
             H.Dispose();
         }
     }
 });
                    }
                });

                output1.Wait(); output1.Dispose();
                //Central control befor attack
                bool A = (Heuristic[1] > 0);
                bool B = (HeuristicRemain[4] > 0);
                if (A || (!B))
                    Heuristic[1] = 0;
                int[] hu = new int[15];
                for (int i = 0; i < 6; i++)
                    hu[i] = Heuristic[i];
                for (int i = 6; i < 12; i++)
                    hu[i] = HeuristicRemain[i - 6];
                for (int i = 12; i < 15; i++)
                    hu[i] = Exchange[i - 12];
                return hu;
            }
        }
        void SetSupHuTrue()
        {
            Object OO = new Object();
            lock (OO)
            {
                IsSupHu[IsSupHu.Count - 1] = true;
            }
        }
        void ClearSupHuTrue()
        {
            Object OO = new Object();
            lock (OO)
            {
                if (IsSup[IsSup.Count - 1] != true)
                {
                    IsSupHu[IsSupHu.Count - 1] = false;
                    IsSup[IsSup.Count - 1] = false;
                }
            }
        }
        bool DisturbeOnHugeTraversalExchangePrevention(bool Before, int[,] TableS, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                bool Is = false;
                if (!Before)
                {
                    if (HeuristicAllReducedAttackedMidel > 0 && HeuristicAllReducedAttackedMidel < HeuristicAllReducedAttacked.Count)
                    {
                        for (int i = HeuristicAllReducedAttackedMidel; i < HeuristicAllReducedAttacked.Count; i++)
                        {
                            if (Order == 1)
                            {
                                if (((System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]]) > System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]]))
                                //|| (System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]]) > 0 && NoOfExistInSupportList(Before, HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]) == 0)
                                ) && TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]] < 0)
                                {
                                    HeuristicReducedAttackedIndexInOnGame.Add(i);
                                    return true;
                                }
                            }
                            else
                            {
                                if (((System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]]) > System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]]))
                                //|| (System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]]) > 0 && NoOfExistInSupportList(Before, HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]) == 0)
                                ) && TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]] > 0)
                                {
                                    HeuristicReducedAttackedIndexInOnGame.Add(i);
                                    return true;
                                }
                            }
                        }
                    }
                }
                return Is;
            }
        }
        bool DisturbeOnNonSupportedTraversalExchangePrevention(int Killded, bool Before, int[,] TableS, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                bool Is = false;
                if (!Before)
                {
                    if (HeuristicAllReducedAttackedMidel > 0 && HeuristicAllReducedAttackedMidel < HeuristicAllReducedAttacked.Count)
                    {
                        for (int i = HeuristicAllReducedAttackedMidel; i < HeuristicAllReducedAttacked.Count; i++)
                        {
                            if (Order == 1)
                            {
                                List<int[]> Valuable = new List<int[]>();
                                bool DD = InAttackEnemyThatIsNotSupported(Killded, CloneATable(TableS), Order, OrderColor(Order), HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1], HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]);
                                if (DD || (System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]]) > System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]]) && TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]] < 0))
                                {
                                    HeuristicReducedAttackedIndexInOnGame.Add(i);
                                    return true;
                                }
                            }
                            else
                            {
                                List<int[]> Valuable = new List<int[]>();
                                bool DD = InAttackEnemyThatIsNotSupported(Killded, CloneATable(TableS), Order, OrderColor(Order), HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1], HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]);
                                if (DD || (System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][2], HeuristicAllReducedAttacked[i][3]]) > System.Math.Abs(TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]]) && TableS[HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]] > 0))
                                {
                                    HeuristicReducedAttackedIndexInOnGame.Add(i);
                                    return true;
                                }
                            }
                        }
                    }
                }
                return Is;
            }
        }
        //recursive of found achmaz detection to be tow objects at line of source attacked or reduced attack
        int AchmazPuredBefore(bool Before, int[,] Table, int Level = 1)
        {
            Object OO = new Object();
            lock (OO)
            {
                if (!Before)
                    return 0;
                if (Level == 0)
                    return 0;
                int No = 0;
                if (Level == 1)
                {
                    if (Order == 1)
                    {
                        if (AchmazPure.Count > 0)
                        {
                            for (int i = 0; i < AchmazPure[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[0][i][j][0], AchmazPure[0][i][j][1]] > 0 && Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] < 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]]);
                                            Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Killed, CloneATable(Tab), OrderColor(Order), Order, AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3], Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazPuredBefore(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazPure.Count > 0)
                        {
                            for (int i = 0; i < AchmazPure[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[0][i].Count; j++)
                                {
                                    if (AchmazPure[0][i].Count <= 1)
                                        continue;
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[0][i][j][0], AchmazPure[0][i][j][1]] < 0 && Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] > 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]]);
                                            Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Killed, CloneATable(Tab), OrderColor(Order), Order, AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3], Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazPuredBefore(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }

                    }
                }
                else if (Level == 2)
                {
                    if (Order == 1)
                    {
                        if (AchmazPure.Count > 0)
                        {
                            for (int i = 0; i < AchmazPure[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[0][i][j][0], AchmazPure[0][i][j][1]] > 0 && Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] < 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazPure.Count > 0)
                        {
                            for (int i = 0; i < AchmazPure[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[0][i][j][0], AchmazPure[0][i][j][1]] < 0 && Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] > 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                }
                return No;
            }
        }
        //recursive of found achmaz detection to be tow objects at line of source attacked or reduced attack
        int AchmazPuredAfter(bool Before, int[,] Table, int Level = 1)
        {
            Object OO = new Object();
            lock (OO)
            {
                if (Before)
                    return 0;
                if (Level == 0)
                    return 0;
                int No = 0;
                if (Level == 1)
                {
                    if (Order == 1)
                    {
                        if (AchmazPure.Count > 1)
                        {
                            for (int i = 0; i < AchmazPure[1].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[1][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[1][i][j][0], AchmazPure[1][i][j][1]] > 0 && Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]] < 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazPure[1][i][j][0], AchmazPure[1][i][j][1], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]]);
                                            Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Killed, CloneATable(Tab), OrderColor(Order), Order, AchmazPure[1][i][j][0], AchmazPure[1][i][j][1], AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazPure[1][i][j][0], AchmazPure[1][i][j][1], AchmazPure[1][i][j][2], AchmazPure[1][i][j][3], Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazPuredBefore(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazPure.Count > 1)
                        {
                            for (int i = 0; i < AchmazPure[1].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[1][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[1][i][j][0], AchmazPure[1][i][j][1]] > 0 && Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]] < 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazPure[1][i][j][0], AchmazPure[1][i][j][1], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazPure[0][i][j][0], AchmazPure[0][i][j][1], AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]]);
                                            Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Killed, CloneATable(Tab), OrderColor(Order), Order, AchmazPure[1][i][j][0], AchmazPure[1][i][j][1], AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazPure[1][i][j][0], AchmazPure[1][i][j][1], AchmazPure[1][i][j][2], AchmazPure[1][i][j][3], Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazPuredBefore(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }

                    }
                }
                else if (Level == 2)
                {
                    if (Order == 1)
                    {
                        if (AchmazPure.Count > 0)
                        {
                            for (int i = 0; i < AchmazPure[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[1][i][j][0], AchmazPure[1][i][j][1]] > 0 && Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]] < 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazPure.Count > 0)
                        {
                            for (int i = 0; i < AchmazPure[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazPure[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazPure[1][i][j][0], AchmazPure[1][i][j][1]] < 0 && Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]] > 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                }
                return No;
            }
        }
        //recursive of found achmaz detection to be tow objects at line of source attacked or reduced attack
        int AchmazReducedBefore(bool Before, int[,] Table, int Level = 1)
        {
            Object OO = new Object();
            lock (OO)
            {
                if (!Before)
                    return 0;
                if (Level == 0)
                    return 0;
                int No = 0;
                if (Level == 1)
                {
                    if (Order == 1)
                    {
                        if (AchmazReduced.Count > 0)
                        {
                            for (int i = 0; i < AchmazReduced[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]] < 0 && Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] > 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3], AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]]);
                                            Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Math.Abs(Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]]), CloneATable(Tab), OrderColor(Order * -1), Order * -1, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3], Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazReducedBefore(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazReduced.Count > 0)
                        {
                            for (int i = 0; i < AchmazReduced[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]] > 0 && Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] < 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3], AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]]);
                                            Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Math.Abs(Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]]), CloneATable(Tab), OrderColor(Order * -1), Order * -1, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3], Order));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazReducedBefore(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }

                    }
                }
                else if (Level == 2)
                {
                    if (Order == 1)
                    {
                        if (AchmazReduced.Count > 0)
                        {
                            for (int i = 0; i < AchmazReduced[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] < 0 && Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]] > 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazReduced.Count > 0)
                        {
                            for (int i = 0; i < AchmazReduced[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] > 0 && Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]] < 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                }
                return No;
            }
        }
        //recursive of found achmaz detection to be tow objects at line of source attacked or reduced attack
        int AchmazReducedAfter(bool Before, int[,] Table, int Level = 1)
        {
            Object OO = new Object();
            lock (OO)
            {
                if (Before)
                    return 0;
                if (Level == 0)
                    return 0;
                int No = 0;
                if (Level == 1)
                {
                    if (Order == 1)
                    {
                        if (AchmazReduced.Count > 1)
                        {
                            for (int i = 0; i < AchmazReduced[1].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[1][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3]] < 0 && Tab[AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1]] > 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3], AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3]]);
                                            Tab[AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Killed, CloneATable(Tab), OrderColor(Order * -1), Order * -1, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1], AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3], Order * -1));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazReducedAfter(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazReduced.Count > 1)
                        {
                            for (int i = 0; i < AchmazReduced[1].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[1][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3]] > 0 && Tab[AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1]] < 0))
                                    {
                                        ThinkingRefrigtzChessPortable t = new ThinkingRefrigtzChessPortable(0, Kind, CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3], OrderColor(Order), CloneATable(Table), 0, Order, false, 0, 0, Kind);
                                        if (Scop(AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3], AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1]))
                                        {
                                            int Killed = Math.Abs(Tab[AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3]]);
                                            Tab[AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3]] = 0;
                                            var th1 = Task.Factory.StartNew(() => t.HeuristicExchange(Before, Killed, CloneATable(Tab), OrderColor(Order * -1), Order * -1, AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1], AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]));
                                            th1.Wait();
                                            th1.Dispose();
                                            var th2 = Task.Factory.StartNew(() => t.Achmaz(CloneATable(Tab), Before, AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1], AchmazReduced[1][i][j][2], AchmazReduced[1][i][j][3], Order * -1));
                                            th2.Wait();
                                            th2.Dispose();
                                            var th3 = Task.Factory.StartNew(() => No += t.AchmazReducedAfter(Before, CloneATable(Tab), 2));
                                            th3.Wait();
                                            th3.Dispose();
                                        }
                                    }

                                }
                            }
                        }

                    }
                }
                else if (Level == 2)
                {
                    if (Order == 1)
                    {
                        if (AchmazReduced.Count > 0)
                        {
                            for (int i = 0; i < AchmazReduced[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] < 0 && Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]] > 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (AchmazReduced.Count > 0)
                        {
                            for (int i = 0; i < AchmazReduced[0].Count; i++)
                            {
                                for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                                {
                                    int[,] Tab = CloneATable(Table);
                                    if ((Tab[AchmazReduced[0][i][j][2], AchmazReduced[0][i][j][3]] > 0 && Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]] < 0))
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                }
                return No;
            }
        }

        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazReducedElephasnt(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;

                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {
                            if (!Scop(ii, jj, i, j))
                                continue;
                            if (Order == 1 && Tabl[i, j] != -2)
                                continue;
                            if (Order == -1 && Tabl[i, j] != 2)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }
                //===============================


                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazReducedCastle(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OOk = new Object();
            lock (OOk)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;

                Object O1 = new Object();
                lock (O1)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                    for (var i = 0; i < 8; i++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var j = jj;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            if (Order == 1 && Tabl[i, j] != -4)
                                continue;
                            if (Order == -1 && Tabl[i, j] != 4)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }
                //===============================

                Object OO = new Object();
                lock (OO)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var i = ii;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            if (Order == 1 && Tabl[i, j] != -4)
                                continue;
                            if (Order == -1 && Tabl[i, j] != 4)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, i, j, RowS, ColS);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }

                return Existence;
            }

        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazElephasnt(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;
                if (Order == 1 && Tabl[RowS, ColS] != 2)
                    return Existence;
                if (Order == -1 && Tabl[RowS, ColS] != -2)
                    return Existence;
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            if (!Scop(ii, jj, i, j))
                                continue;
                            List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }
                //===============================
                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazCastle(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OOk = new Object();
            lock (OOk)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;
                if (Order == 1 && Tabl[RowS, ColS] != 4)
                    return Existence;
                if (Order == -1 && Tabl[RowS, ColS] != -4)
                    return Existence;
                Object O1 = new Object();
                lock (O1)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                    for (var i = 0; i < 8; i++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var j = jj;

                            if (!Scop(ii, jj, i, j))
                                continue;
                            List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }

                }
                //===============================
                Object OO = new Object();
                lock (OO)
                {

                    for (var j = 0; j < 8; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var i = ii;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }

                }

                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazHourse(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;
                if (Order == 1 && Tabl[RowS, ColS] != 3)
                    return Existence;
                if (Order == -1 && Tabl[RowS, ColS] != -3)
                    return Existence;
                Object O1 = new Object();
                lock (O1)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                    for (var i = RowS - 3; i < RowS + 4; i++)
                    {
                        for (var j = ColS - 3; j < ColS + 4; j++)
                        {
                            Object O = new Object();
                            lock (O)
                            {
                                if (!Scop(ii, jj, i, j))
                                    continue;
                                List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                                if (Exist.Count >= 1)
                                {

                                    Existence.Add(Exist);
                                }

                            }
                        }
                    }
                }


                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazReducedHourse(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;
                Object O1 = new Object();
                lock (O1)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                    for (var i = RowS - 3; i < RowS + 4; i++)
                    {
                        for (var j = ColS - 3; j < ColS + 4; j++)
                        {
                            Object O = new Object();
                            lock (O)
                            {
                                if (!Scop(ii, jj, i, j))
                                    continue;
                                if (Order == 1 && Tabl[i, j] != 3)
                                    continue;
                                if (Order == -1 && Tabl[i, j] != -3)
                                    continue;
                                List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                                if (Exist.Count >= 1)
                                {

                                    Existence.Add(Exist);
                                }

                            }
                        }
                    }
                }
                //===============================


                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazMinister(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;
                if (Order == 1 && Tabl[RowS, ColS] != 5)
                    return Existence;
                if (Order == -1 && Tabl[RowS, ColS] != -5)
                    return Existence;
                Object O1 = new Object();
                lock (O1)
                {
                    for (var i = 0; i < 8; i++)
                    {
                        for (var j = 0; j < 8; j++)
                        {
                            Object O = new Object();
                            lock (O)
                            {

                                if (!Scop(ii, jj, i, j))
                                    continue;
                                List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                                if (Exist.Count >= 1)
                                {

                                    Existence.Add(Exist);
                                }

                            }
                        }
                    }
                }

                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazKing(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OOk = new Object();
            lock (OOk)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;
                if (Order == 1 && Tabl[RowS, ColS] != 6)
                    return Existence;
                if (Order == -1 && Tabl[RowS, ColS] != -6)
                    return Existence;
                Object O1 = new Object();
                lock (O1)
                {
                    for (var i = ii - 1; i < ii + 2; i++)
                    {
                        Object O = new Object();
                        lock (O)
                        {
                            var j = i + ii - jj;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                    //===============================
                    Object OOOo1 = new Object();
                    lock (OOOo1)
                    {


                        for (var i = ii - 1; i < ii + 2; i++)
                        {
                            Object O = new Object();
                            lock (O)
                            {
                                var j = i * -1 + ii - jj;
                                if (!Scop(ii, jj, i, j))
                                    continue;
                                List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                                if (Exist.Count >= 1)
                                {

                                    Existence.Add(Exist);
                                }

                            }
                        }
                    }
                    //=============================================
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>


                    for (var i = ii - 1; i < ii + 2; i++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var j = jj;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }
                //===============================
                Object OO = new Object();
                lock (OO)
                {


                    for (var j = ii - 1; j < ii + 2; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var i = ii;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            List<int[]> Exist = ListOfExistInAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }


                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazReducedKing(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OOk = new Object();
            lock (OOk)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;

                Object O1 = new Object();
                lock (O1)
                {
                    for (var i = ii - 1; i < ii + 2; i++)
                    {
                        Object O = new Object();
                        lock (O)
                        {
                            var j = i + ii - jj;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            if (Order == 1 && Tabl[i, j] != 6)
                                continue;
                            if (Order == -1 && Tabl[i, j] != -6)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                    //===============================
                    Object OOOo1 = new Object();
                    lock (OOOo1)
                    {


                        for (var i = ii - 1; i < ii + 2; i++)
                        {
                            Object O = new Object();
                            lock (O)
                            {
                                var j = i * -1 + ii - jj;
                                if (!Scop(ii, jj, i, j))
                                    continue;
                                if (Order == 1 && Tabl[i, j] != 6)
                                    continue;
                                if (Order == -1 && Tabl[i, j] != -6)
                                    continue;
                                List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                                if (Exist.Count >= 1)
                                {

                                    Existence.Add(Exist);
                                }

                            }
                        }
                    }
                    //=============================================
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>


                    for (var i = ii - 1; i < ii + 2; i++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var j = jj;
                            if (!Scop(ii, jj, i, j))
                                continue;

                            if (Order == 1 && Tabl[i, j] != 6)
                                continue;
                            if (Order == -1 && Tabl[i, j] != -6)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }
                //===============================
                Object OO = new Object();
                lock (OO)
                {


                    for (var j = ii - 1; j < ii + 2; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {

                            var i = ii;
                            if (!Scop(ii, jj, i, j))
                                continue;
                            if (Order == 1 && Tabl[i, j] != 6)
                                continue;
                            if (Order == -1 && Tabl[i, j] != -6)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }


                return Existence;
            }
        }
        //method of list of reduced attack or attack by lists of method found lists by every specified objects on board.
        List<List<int[]>> AchMazReducedMinister(int[,] Tabl, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object OO = new Object();
            lock (OO)
            {
                List<List<int[]>> Existence = new List<List<int[]>>();

                int ii = RowS, jj = ColS;

                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        Object O = new Object();
                        lock (O)
                        {
                            if (!Scop(ii, jj, i, j))
                                continue;
                            if (Order == 1 && Tabl[i, j] != -5)
                                continue;
                            if (Order == -1 && Tabl[i, j] != 5)
                                continue;
                            List<int[]> Exist = ListOfExistInReducedAttackList(Before, RowS, ColS, i, j);
                            if (Exist.Count >= 1)
                            {

                                Existence.Add(Exist);
                            }

                        }
                    }
                }

                return Existence;
            }
        }

        //calculation first level of achmaz by sub metods possible
        void Achmaz(int[,] Table, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object O1 = new Object();
            lock (O1)
            {
                List<List<int[]>> EleRedAchmaz = null, EleAchmaz = null, HourAchmaz = null, HourRedAchmaz = null, CastRedAchmaz = null, CastAchmaz = null, MiniRedAchmaz = null, MiniAchmaz = null, KingRedAchmaz = null, KingAchmaz = null;
                //if (System.Math.Abs(Table[RowS, ColS]) == 2 || System.Math.Abs(Table[RowD, ColD]) == 2)
                {
                    var tth = Task.Factory.StartNew(() =>
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
 {
     var tth1 = Task.Factory.StartNew(() => EleRedAchmaz = AchMazReducedElephasnt(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth1.Wait();
     tth1.Dispose();
 }, () =>
 {
     var tth2 = Task.Factory.StartNew(() => EleAchmaz = AchMazElephasnt(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth2.Wait();
     tth2.Dispose();
 }, () =>
 {
     var tth1 = Task.Factory.StartNew(() => CastRedAchmaz = AchMazReducedCastle(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth1.Wait();
     tth1.Dispose();
 }, () =>
 {
     var tth2 = Task.Factory.StartNew(() => CastAchmaz = AchMazCastle(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth2.Wait();
     tth2.Dispose();
 }, () =>
 {
     var tth1 = Task.Factory.StartNew(() => MiniRedAchmaz = AchMazReducedMinister(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth1.Wait();
     tth1.Dispose();
 }, () =>
 {
     var tth2 = Task.Factory.StartNew(() => MiniAchmaz = AchMazMinister(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth2.Wait();
     tth2.Dispose();
 }, () =>
 {
     var tth1 = Task.Factory.StartNew(() => KingRedAchmaz = AchMazReducedKing(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth1.Wait();
     tth1.Dispose();
 }, () =>
 {
     var tth2 = Task.Factory.StartNew(() => KingAchmaz = AchMazKing(CloneATable(Table), Before, RowS, ColS, RowD, ColD, Order));
     tth2.Wait();
     tth2.Dispose();
 });
                    });
                    tth.Wait();
                    tth.Dispose();
                }
                var ttttth = Task.Factory.StartNew(() =>
                {
                    ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.Invoke(() =>
 {
     var tth1 = Task.Factory.StartNew(() => AchmazPure.Add(CollectionSummation(EleAchmaz, HourAchmaz, CastAchmaz, MiniAchmaz, KingAchmaz)));
     tth1.Wait();
     tth1.Dispose();
 }, () =>
 {
     var tth2 = Task.Factory.StartNew(() => AchmazReduced.Add(CollectionSummation(EleRedAchmaz, HourRedAchmaz, CastRedAchmaz, MiniRedAchmaz, KingRedAchmaz)));
     tth2.Wait();
     tth2.Dispose();
 });
                });
                ttttth.Wait();
                ttttth.Dispose();
            }

        }
        //creation of colldection of achmaz lists depend of region of source objects
        List<List<int[]>> CollectionSortation(List<List<int[]>> A)
        {
            Object O1 = new Object();
            lock (O1)
            {
                List<List<int[]>> Col = new List<List<int[]>>();

                List<int[]> Co = new List<int[]>();
                CollectionSummation(A, -4, ref Co);
                if (Co.Count > 0) Col.Add(Co);
                Co = new List<int[]>();
                CollectionSummation(A, -3, ref Co);
                if (Co.Count > 0) Col.Add(Co);
                Co = new List<int[]>();
                CollectionSummation(A, -2, ref Co);
                if (Co.Count > 0) Col.Add(Co);
                Co = new List<int[]>();
                CollectionSummation(A, -1, ref Co);
                if (Co.Count > 0) Col.Add(Co);
                Co = new List<int[]>();
                CollectionSummation(A, 1, ref Co);
                if (Co.Count > 0) Col.Add(Co);

                Co = new List<int[]>();
                CollectionSummation(A, 2, ref Co);
                if (Co.Count > 0) Col.Add(Co);

                Co = new List<int[]>();
                CollectionSummation(A, 3, ref Co);
                if (Co.Count > 0) Col.Add(Co);

                Co = new List<int[]>();
                CollectionSummation(A, 4, ref Co);
                if (Co.Count > 0) Col.Add(Co);
                return Col;
            }
        }
        //creation of one region of collection of achmaz method
        void CollectionSummation(List<List<int[]>> A, int Sum, ref List<int[]> Co)
        {
            Object O1 = new Object();
            lock (O1)
            {
                if (A == null)
                    return;
                for (int i = 0; i < A.Count; i++)
                {
                    for (int j = 0; j < A[i].Count; j++)
                    {
                        if (A[i][j][4] == Sum && (!Exist(Co, A[i][j])))
                            Co.Add(A[i][j]);
                    }
                }
            }
        }
        //collection of regionns redistributed from achmaz methods
        List<List<int[]>> CollectionSummation(List<List<int[]>> A, List<List<int[]>> B, List<List<int[]>> C, List<List<int[]>> D, List<List<int[]>> E)
        {
            Object O1 = new Object();
            lock (O1)
            {
                List<List<int[]>> Col = new List<List<int[]>>();

                List<int[]> Co1 = new List<int[]>();
                CollectionSummation(A, -4, ref Co1);
                CollectionSummation(B, -4, ref Co1);
                CollectionSummation(C, -4, ref Co1);
                CollectionSummation(D, -4, ref Co1);

                if (Co1.Count > 0) Col.Add(Co1);
                List<int[]> Co2 = new List<int[]>();
                CollectionSummation(A, -3, ref Co2);
                CollectionSummation(B, -3, ref Co2);
                CollectionSummation(C, -3, ref Co2);
                CollectionSummation(D, -3, ref Co2);

                if (Co2.Count > 0) Col.Add(Co2);
                List<int[]> Co3 = new List<int[]>();
                CollectionSummation(A, -2, ref Co3);
                CollectionSummation(B, -2, ref Co3);
                CollectionSummation(C, -2, ref Co3);
                CollectionSummation(D, -2, ref Co3);

                if (Co3.Count > 0) Col.Add(Co3);
                List<int[]> Co4 = new List<int[]>();
                CollectionSummation(A, -1, ref Co4);
                CollectionSummation(B, -1, ref Co4);
                CollectionSummation(C, -1, ref Co4);
                CollectionSummation(D, -1, ref Co4);

                if (Co4.Count > 0) Col.Add(Co4);
                List<int[]> Co5 = new List<int[]>();
                CollectionSummation(A, 1, ref Co5);
                CollectionSummation(B, 1, ref Co5);
                CollectionSummation(C, 1, ref Co5);
                CollectionSummation(D, 1, ref Co5);

                if (Co5.Count > 0) Col.Add(Co5);

                List<int[]> Co6 = new List<int[]>();
                CollectionSummation(A, 2, ref Co6);
                CollectionSummation(B, 2, ref Co6);
                CollectionSummation(C, 2, ref Co6);
                CollectionSummation(D, 2, ref Co6);

                if (Co6.Count > 0) Col.Add(Co6);

                List<int[]> Co7 = new List<int[]>();
                CollectionSummation(A, 3, ref Co7);
                CollectionSummation(B, 3, ref Co7);
                CollectionSummation(C, 3, ref Co7);
                CollectionSummation(D, 3, ref Co7);

                if (Co7.Count > 0) Col.Add(Co7);

                List<int[]> Co8 = new List<int[]>();
                CollectionSummation(A, 4, ref Co8);
                CollectionSummation(B, 4, ref Co8);
                CollectionSummation(C, 4, ref Co8);
                CollectionSummation(D, 4, ref Co8);

                if (Co8.Count > 0) Col.Add(Co8);

                return Col;
            }
        }
        //determine sign of 8th regions
        int SignBeforNext(int Row, int Col, int i, int j)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int Sign = 0;
                if (Row < i && Col > j)
                    Sign = -4;
                if (Row > i && Col > j)
                    Sign = 4;
                if (Row > i && Col < j)
                    Sign = 3;
                if (Row < i && Col > j)
                    Sign = -3;
                if (Row == i && Col < j)
                    Sign = -2;
                if (Row == i && Col > j)
                    Sign = 2;
                if (Row > i && Col == j)
                    Sign = 1;
                if (Row < i && Col == j)
                    Sign = -1;
                return Sign;
            }
        }
        //calculate sum of achmazin pure and reduced and beforand after
        int SumAbsSrcPure(bool Before, int[,] Tab)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int Sum = 0;
                if (AchmazPure.Count == 1)
                {
                    for (int i = 0; i < AchmazPure[0].Count; i++)
                    {
                        for (int j = 0; j < AchmazPure[0][i].Count; j++)
                        {
                            Sum += System.Math.Abs(Tab[AchmazPure[0][i][j][2], AchmazPure[0][i][j][3]]);
                        }
                    }
                }
                return Sum;
            }
        }
        //calculate sum of achmazin pure and reduced and beforand after
        int SumAbsSrcReduced(bool Before, int[,] Tab)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int Sum = 0;
                if (AchmazReduced.Count == 1)
                {
                    for (int i = 0; i < AchmazReduced[0].Count; i++)
                    {
                        for (int j = 0; j < AchmazReduced[0][i].Count; j++)
                        {
                            Sum += System.Math.Abs(Tab[AchmazReduced[0][i][j][0], AchmazReduced[0][i][j][1]]);
                        }
                    }
                }
                return Sum;
            }
        }
        //calculate sum of achmazin pure and reduced and beforand after
        int SumAbsDesPure(bool Before, int[,] Tab)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int Sum = 0;
                if (AchmazPure.Count == 2)
                {
                    for (int i = 0; i < AchmazPure[1].Count; i++)
                    {
                        for (int j = 0; j < AchmazPure[1][i].Count; j++)
                        {
                            Sum += System.Math.Abs(Tab[AchmazPure[1][i][j][2], AchmazPure[1][i][j][3]]);
                        }
                    }

                }

                return Sum;
            }
        }
        //calculate sum of achmazin pure and reduced and beforand after
        int SumAbsDesReduced(bool Before, int[,] Tab)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int Sum = 0;
                if (AchmazReduced.Count == 2)
                {
                    for (int i = 0; i < AchmazReduced[1].Count; i++)
                    {
                        for (int j = 0; j < AchmazReduced[1][i].Count; j++)
                        {
                            Sum += System.Math.Abs(Tab[AchmazReduced[1][i][j][0], AchmazReduced[1][i][j][1]]);
                        }
                    }
                }

                return Sum;
            }
        }
        //heuristic creation of double attacked
        int DoubleAttack(int[,] Table, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int DD = 0;
                List<List<int[]>> DDL = new List<List<int[]>>();
                for (int RowSS = 0; RowSS < 8; RowSS++)
                {
                    for (int ColSS = 0; ColSS < 8; ColSS++)
                    {
                        if (Order == -1 && Table[RowSS, ColSS] >= 0)
                            continue;
                        if (Order == 1 && Table[RowSS, ColSS] <= 0)
                            continue;
                        for (int RowDD = 0; RowDD < 8; RowDD++)
                        {
                            for (int ColDD = 0; ColDD < 8; ColDD++)
                            {
                                List<int[]> DDA = ListOfExistInAttackList(Before, RowSS, ColSS, RowDD, ColDD);
                                if (DDA.Count > 0)
                                    DDL.Add(DDA);
                            }
                        }
                    }
                }
                List<int[]> DDE = new List<int[]>();
                for (int i = 0; i < DDL.Count; i++)
                {
                    for (int j = 0; j < DDL[i].Count; j++)
                    {
                        if (!ExistFull(DDE, DDL[i][j]))
                        {
                            DDE.Add(DDL[i][j]);
                        }
                    }
                }
                if (DDE.Count > 1)
                {
                    for (int RowSS = 0; RowSS < 8; RowSS++)
                    {
                        for (int ColSS = 0; ColSS < 8; ColSS++)
                        {
                            for (int RowDD = 0; RowDD < 8; RowDD++)
                            {
                                for (int ColDD = 0; ColDD < 8; ColDD++)
                                {
                                    for (int i = 0; i < DDE.Count; i++)
                                    {
                                        if (DDE[i][0] == RowSS && DDE[i][1] == ColSS && DDE[i][2] == RowDD && DDE[i][3] == ColDD)
                                            DD++;
                                    }
                                }
                            }
                        }
                    }
                }

                if (DD <= 1)
                    DD = 0;
                DD = (RationalRegard) * (DD);
                return DD;
            }
        }
        //heuristic creation of double defence
        int DoubleDefence(int[,] Table, bool Before, int RowS, int ColS, int RowD, int ColD, int Order)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int DD = 0;
                List<List<int[]>> DDL = new List<List<int[]>>();
                for (int RowSS = 0; RowSS < 8; RowSS++)
                {
                    for (int ColSS = 0; ColSS < 8; ColSS++)
                    {
                        for (int RowDD = 0; RowDD < 8; RowDD++)
                        {
                            for (int ColDD = 0; ColDD < 8; ColDD++)
                            {
                                if (Order == 1 && Table[RowDD, ColDD] >= 0)
                                    continue;
                                if (Order == -1 && Table[RowDD, ColDD] <= 0)
                                    continue;
                                List<int[]> DDA = ListOfExistInReducedAttackList(Before, RowSS, ColSS, RowDD, ColDD);
                                if (DDA.Count > 0)
                                    DDL.Add(DDA);
                            }
                        }
                    }
                }
                List<int[]> DDE = new List<int[]>();
                for (int i = 0; i < DDL.Count; i++)
                {
                    for (int j = 0; j < DDL[i].Count; j++)
                    {
                        if (!ExistFull(DDE, DDL[i][j]))
                        {
                            DDE.Add(DDL[i][j]);
                        }
                    }
                }
                if (DDE.Count > 1)
                {
                    for (int RowDD = 0; RowDD < 8; RowDD++)
                    {
                        for (int ColDD = 0; ColDD < 8; ColDD++)
                        {
                            List<int[]> DDEE = new List<int[]>();
                            for (int RowSS = 0; RowSS < 8; RowSS++)
                            {
                                for (int ColSS = 0; ColSS < 8; ColSS++)
                                {
                                    for (int i = 0; i < DDE.Count; i++)
                                    {
                                        if (DDE[i][0] == RowDD && DDE[i][1] == ColDD && DDE[i][2] == RowSS && DDE[i][3] == ColSS)
                                        {
                                            int[] SS = new int[4];
                                            SS[0] = RowDD;
                                            SS[1] = ColDD;
                                            SS[2] = RowSS;
                                            SS[3] = ColSS;
                                            if (!ExistFull(DDEE, SS))
                                            {
                                                DDEE.Add(SS);
                                                DD++;
                                            }
                                        }
                                    }
                                }
                            }
                            if (DDEE.Count > 1)
                            {
                                if (!ExistFullDoubleList(HeuristicDoubleDefenceIndexInOnGame, DDEE))
                                    HeuristicDoubleDefenceIndexInOnGame.Add(DDEE);
                            }
                        }
                    }
                }
                if (HeuristicDoubleDefenceIndexInOnGame.Count == 0)
                    DD = 0;
                if (DD <= 1)
                    DD = 0;
                DD = (RationalPenalty) * (DD);
                return DD;
            }
        }
        //when after of move
        bool MidleIndex()
        {
            Object OO = new Object();
            lock (OO)
            {
                bool Is = true;
                if (HeuristicAllAttackedMidel != 0)
                    return false;
                if (HeuristicAllMoveMidel != 0)
                    return false;
                if (HeuristicAllReducedAttackedMidel != 0)
                    return false;
                if (HeuristicAllReducedMoveMidel != 0)
                    return false;
                if (HeuristicAllReducedSupportMidel != 0)
                    return false;
                if (HeuristicAllSupportMidel != 0)
                    return false;
                if (HeuristicReducedAttackedIndexInOnGameMidle != 0)
                    return false;
                if (HeuristicDoubleDefenceIndexInOnGameMidle != 0)
                    return false;
                return Is;
            }
        }

        bool IsSupHuTrue()
        {

            Object o = new Object();
            lock (o)
            {
                bool Is = false;

                if (!AllDraw.AllowedSupTrue)
                {
                    Is = IsSupHu[IsSupHu.Count - 1];
                }
                else
                {
                    Is = IsSup[IsSup.Count - 1];

                }
                return Is;
            }
        }
        //heuristic main method
        /********************************************************************************
         complexity of achmaz is O((m^n)*(n^d))*********************************************
         m: avarage state complexity for on state (0<=m<=1026)***************************
         n: avarages every chiles node number of a parent********************************
         d: heighth of tree**************************************************************        
         ********************************************************************************/
        public void CalculateHeuristics(int[] LoseOcuuredatChiled, int WinOcuuredatChiled, bool Before, int Order, int Killed, int[,] TableS, int RowS, int ColS, int RowD, int ColD, Color color
            , ref int HeuristicAttackValue
                , ref int HeuristicMovementValue
                , ref int HeuristicSelfSupportedValue
                , ref int HeuristicReducedMovementValue
               , ref int HeuristicReducedSupport
                , ref int HeuristicReducedAttackValue
                , ref int HeuristicDistributionValue
            , ref int HeuristicKingSafe
            , ref int HeuristicFromCenter
            , ref int HeuristicKingDangour, ref int HeuristicCheckedMate)
        {
            Object OO = new Object();
            lock (OO)
            {
                if (!Scop(RowS, ColS, RowD, ColD, Kind))
                    return;
                int[] Heuristic = new int[6];
                int HCheck = new int();
                int HDistance = new int();
                int HKingSafe = new int();
                int HKingDangour = new int();
                int HFromCenter = 0;
                int HExchangeInnovation = 0;
                int HExchangeSupport = 0;
                if (!Before && MidleIndex())
                {
                    HeuristicAllAttackedMidel = HeuristicAllAttacked.Count;
                    HeuristicAllMoveMidel = HeuristicAllMove.Count;
                    HeuristicAllReducedAttackedMidel = HeuristicAllReducedAttacked.Count;
                    HeuristicAllReducedMoveMidel = HeuristicAllReducedMove.Count;
                    HeuristicAllReducedSupportMidel = HeuristicAllReducedSupport.Count;
                    HeuristicAllSupportMidel = HeuristicAllSupport.Count;
                    HeuristicReducedAttackedIndexInOnGameMidle = HeuristicReducedAttackedIndexInOnGame.Count;
                    HeuristicDoubleDefenceIndexInOnGameMidle = HeuristicDoubleDefenceIndexInOnGame.Count;
                    AchmazPureMidle = AchmazPure.Count;
                    AchmazReducedMidle = AchmazReduced.Count;
                }
                if (Order != AllDraw.OrderPlateDraw)
                    return;
                int[] Hu = null;
                Task H1 = null, H2 = null, H3 = null;
                int HAchmaz = 0;
                int HDoubleAttack = 0, HDoubleDefense = 0;
                int HWin = 0, HLose = 0;
                bool IsS = false;
                var th = Task.Factory.StartNew(() => Hu = CalculateHeuristicsParallel(Before, Killed, CloneATable(TableS), RowS, ColS, RowD, ColD, color));
                th.Wait();
                th.Dispose();

                //if (UsePenaltyRegardMechnisamT)


                Heuristic[0] = Hu[0];
                Heuristic[1] = Hu[1];
                Heuristic[2] = Hu[2];
                Heuristic[3] = Hu[3];
                Heuristic[4] = Hu[4];
                Heuristic[5] = Hu[5];
                HCheck = Hu[6];
                HDistance = Hu[7];
                HKingSafe = Hu[8];
                HKingDangour = Hu[9];
                HFromCenter = Hu[10];
                HExchangeInnovation = Hu[11] + Hu[12] + Hu[13];
                HExchangeSupport = Hu[14];


                Object O1 = new Object();
                lock (O1)
                {
                    if (!IsSupHuTrue())
                    {
                        if (Before)
                        {
                            if (Order == 1)
                            {
                                if ((System.Math.Abs(TableS[RowS, ColS]) > System.Math.Abs(TableS[RowD, ColD])) && TableS[RowD, ColD] > 0 && NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) > 0)
                                {
                                    //if (Before)
                                    SetSupHuTrue();
                                    IsS = true;
                                }
                            }
                            else
                            {
                                if ((System.Math.Abs(TableS[RowS, ColS]) > System.Math.Abs(TableS[RowD, ColD])) && TableS[RowD, ColD] > 0 && NoOfExistInReducedAttackList(Before, RowS, ColS, RowD, ColD) > 0)
                                {
                                    //if (Before)
                                    SetSupHuTrue();
                                    IsS = true;
                                }
                            }
                            if (!GoldenFinished && WinOcuuredatChiled == 0)
                            {  //Disturbe on huge traversal exchange prevention 
                               //Ignore of atack and checkedmate at first until all move
                                bool A = false, B = false, C = false;
                                if (Order == 1)
                                {
                                    A = ColleralationGray < 30;
                                    if (Order == AllDraw.OrderPlateDraw)
                                    {
                                        B = NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) > 0 && (System.Math.Abs(TableS[RowD, ColD]) != 0 && System.Math.Abs(TableS[RowS, ColS]) > 1);
                                        C = HeuristicCheckedMate < 0 && (IsThereMateOfSelf[IsThereMateOfSelf.Count - 1]);
                                    }
                                }
                                else
                                {
                                    A = ColleralationBrown < 30;
                                    if (Order == AllDraw.OrderPlateDraw)
                                    {
                                        B = NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) > 0 && (System.Math.Abs(TableS[RowD, ColD]) != 0 && System.Math.Abs(TableS[RowS, ColS]) > 1);
                                        C = HeuristicCheckedMate < 0 && (IsThereMateOfSelf[IsThereMateOfSelf.Count - 1]);
                                    }
                                }
                                if (A && ((B) || (C)))
                                {
                                    SetSupHuTrue();
                                    IsS = true;
                                }
                                //Every objects one move at game begin
                                int Total = 0;
                                int Is = 0;
                                int NoOfBoardMoved = NoOfObjectNotMovable(CloneATable(TableS), Order, OrderColor(Order), ref Total, ref Is);
                                if (Order == 1)
                                {
                                    if (
                                            //(
                                            (NoOfBoardMoved + Is >= Total) &&
                                            TableInitiationPreventionOfMultipleMove[RowS, ColS] >= NoOfMovableAllObjectMove
                                    //)&& A && TableS[RowS, ColS] < 0 && TableS[RowD, ColD] >= 0
                                    )
                                    {
                                        IsS = true;
                                        SetSupHuTrue();
                                    }
                                }
                                else
                                {
                                    if (
                                            //(
                                            (NoOfBoardMoved + Is >= Total) &&
                                            TableInitiationPreventionOfMultipleMove[RowS, ColS] >= NoOfMovableAllObjectMove
                                    //)&& A && TableS[RowS, ColS] < 0 && TableS[RowD, ColD] >= 0
                                    )
                                    {
                                        IsS = true;
                                        SetSupHuTrue();
                                    }
                                }
                                //Empire more
                                if (A)
                                {
                                    if (ColleralationGray < 16)
                                    {
                                        if (NoOfExistInSupportList(Before, RowS, ColS, RowD, ColD) + NoOfExistInMoveList(Before, RowS, ColS, RowD, ColD) + NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) - NoOfExistInReducedSupportList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedMoveList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) >= DifOfNoOfSupporteAndReducedSupportGray)
                                        {
                                            DifOfNoOfSupporteAndReducedSupportGray = NoOfExistInSupportList(Before, RowS, ColS, RowD, ColD) + NoOfExistInMoveList(Before, RowS, ColS, RowD, ColD) + NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) - NoOfExistInReducedSupportList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedMoveList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS);
                                        }
                                        else
                                        if (DifOfNoOfSupporteAndReducedSupportGray < 0)
                                        {
                                            IsS = true;
                                            SetSupHuTrue();
                                        }
                                    }
                                }
                                //Hourse before elephants
                                if (((RowS == 2 && ColS == 7 && TableInitiation[RowS, ColS] == TableS[2, 7] && TableS[2, 7] == 2) && TableInitiationPreventionOfMultipleMove[2, 7] != 0) || ((RowS == 5 && ColS == 7 && TableInitiation[RowS, ColS] == TableS[5, 7] && TableS[5, 7] == 2) && TableInitiationPreventionOfMultipleMove[5, 7] != 0))
                                {
                                    Color a = Color.Gray;
                                    if (Order == -1)
                                        a = Color.Brown;
                                    if (((TableInitiation[1, 7] == TableS[1, 7] && TableS[1, 7] == 3) && TableInitiationPreventionOfMultipleMove[1, 7] == 0 && ObjectMovable(1, 7, CloneATable(TableS), Order, a)) || ((TableInitiation[6, 7] == TableS[6, 7] && TableS[6, 7] == 3) && TableInitiationPreventionOfMultipleMove[6, 7] == 0 && ObjectMovable(6, 7, CloneATable(TableS), Order, a)))
                                    {
                                        IsS = true;
                                        SetSupHuTrue();
                                    }
                                }
                            }
                            //when thre is most reduced support finding
                            int[] IsNo = MostOfFindMostHeuristicAllReducedSupportInList(Before, RowD, ColD);
                            if (IsNo != null)
                            {
                                if (IsNo[1] < HeuristicAllReducedSupport.Count)
                                {
                                    if (NoOfExistInAttackList(Before, RowS, ColS, HeuristicAllReducedSupport[IsNo[1]][0], HeuristicAllReducedSupport[IsNo[1]][1]) > 0)
                                        ClearSupHuTrue();
                                }
                            }
                            if (HDoubleAttack > 0)
                            {
                                if (!IsSupHuTrue())
                                    WinOcuuredatChiled = 5;
                            }
                        }
                        else
                        {
                            //Disturbe on huge traversal exchange prevention 
                            //if ((System.Math.Abs(TableConst[RowS, ColS]) > System.Math.Abs(Killed)) && Killed != 0 && NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) > 0)
                            if (Order == AllDraw.OrderPlateDraw)
                            {
                                if (DisturbeOnNonSupportedTraversalExchangePrevention(Killed, Before, CloneATable(TableS), Order))
                                {
                                    //if (Before)
                                    SetSupHuTrue();
                                    IsS = true;
                                }
                                if (DisturbeOnHugeTraversalExchangePrevention(Before, CloneATable(TableS), Order))
                                {
                                    //if (Before)
                                    SetSupHuTrue();
                                    IsS = true;
                                }
                                else
                                {
                                    if (TableInitiationPreventionOfMultipleMove[RowS, ColS] == NoOfMovableAllObjectMove && IsSupHuTrue() && IsS)
                                    {
                                        TableInitiationPreventionOfMultipleMove[RowS, ColS] = NoOfMovableAllObjectMove - 1;
                                        IsS = false;
                                    }
                                }
                            }
                            if (!GoldenFinished)
                            {   //Ignore of atack and checkedmate at first until all move
                                bool A = false, B = false, C = false;
                                if (Order == 1)
                                {
                                    A = ColleralationGray < 30;
                                    if (Order == AllDraw.OrderPlateDraw)
                                    {
                                        B = NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) > 0 && (Killed != 0 && Killed < TableS[RowD, ColD]);
                                        C = HeuristicCheckedMate < 0 && (IsThereMateOfSelf[IsThereMateOfSelf.Count - 1]);
                                    }
                                }
                                else
                                {
                                    A = ColleralationBrown < 30;
                                    if (Order == AllDraw.OrderPlateDraw)
                                    {
                                        B = NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) > 0 && (Killed != 0 && Killed < TableS[RowD, ColD]);
                                        C = HeuristicCheckedMate < 0 && (IsThereMateOfSelf[IsThereMateOfSelf.Count - 1]);
                                    }
                                }
                                if (A && ((B) || (C)))
                                {
                                    SetSupHuTrue();
                                    IsS = true;
                                }
                                else
                                {
                                    if (Order == AllDraw.OrderPlateDraw)
                                    {//if (TableInitiationPreventionOfMultipleMove[RowS, ColS] == NoOfMovableAllObjectMove && IsSupHuTrue() && (!IsS))

                                        //Empire more
                                        if (A)
                                        {
                                            if (ColleralationBrown < 16)
                                            {
                                                if (NoOfExistInSupportList(Before, RowS, ColS, RowD, ColD) + NoOfExistInMoveList(Before, RowS, ColS, RowD, ColD) + NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) - NoOfExistInReducedSupportList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedMoveList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS) >= DifOfNoOfSupporteAndReducedSupportBrown)
                                                {
                                                    DifOfNoOfSupporteAndReducedSupportBrown = NoOfExistInSupportList(Before, RowS, ColS, RowD, ColD) + NoOfExistInMoveList(Before, RowS, ColS, RowD, ColD) + NoOfExistInAttackList(Before, RowS, ColS, RowD, ColD) - NoOfExistInReducedSupportList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedMoveList(Before, RowD, ColD, RowS, ColS) - NoOfExistInReducedAttackList(Before, RowD, ColD, RowS, ColS);
                                                }
                                                else
                                                if (DifOfNoOfSupporteAndReducedSupportBrown < 0)
                                                {
                                                    {
                                                        SetSupHuTrue();
                                                        IsS = true;
                                                    }
                                                }
                                            }
                                        }
                                        //Hourse before elephants
                                        if (((RowS == 2 && ColS == 0 && TableInitiation[RowS, ColS] == TableS[RowS, ColS] && TableS[RowS, ColS] == -2) && TableInitiationPreventionOfMultipleMove[2, 0] != 0) || ((RowS == 5 && ColS == 0 && TableInitiation[RowS, ColS] == TableS[RowS, ColS] && TableConst[RowS, ColS] == -2) && TableInitiationPreventionOfMultipleMove[5, 0] != 0))
                                        {
                                            Color a = Color.Gray;
                                            if (Order == -1)
                                                a = Color.Brown;
                                            if (((TableInitiation[1, 0] == TableS[1, 0] && TableS[1, 0] == -3) && TableInitiationPreventionOfMultipleMove[1, 0] == 0 && ObjectMovable(1, 0, CloneATable(TableS), Order, a)) || ((TableInitiation[6, 0] == TableS[6, 0] && TableS[6, 0] == -3) && TableInitiationPreventionOfMultipleMove[6, 0] == 0 && ObjectMovable(6, 0, CloneATable(TableS), Order, a)))
                                            {
                                                SetSupHuTrue();
                                                IsS = true;
                                            }
                                        }
                                        //Every objects one move at game begin
                                        int Total = 0;
                                        int Is = 0;
                                        int NoOfBoardMoved = NoOfObjectNotMovable(CloneATable(TableS), Order, OrderColor(Order), ref Total, ref Is);
                                        if (Order == 1)
                                        {
                                            if (
                                                    //(
                                                    (NoOfBoardMoved + Is >= Total) &&
                                                    TableInitiationPreventionOfMultipleMove[RowS, ColS] >= NoOfMovableAllObjectMove
                                            //)&& A && TableS[RowS, ColS] < 0 && TableS[RowD, ColD] >= 0
                                            )
                                            {
                                                IsS = true;
                                                SetSupHuTrue();
                                            }
                                        }
                                        else
                                        {
                                            if (
                                                    //(
                                                    (NoOfBoardMoved + Is >= Total) &&
                                                    TableInitiationPreventionOfMultipleMove[RowS, ColS] >= NoOfMovableAllObjectMove
                                            //)&& A && TableS[RowS, ColS] < 0 && TableS[RowD, ColD] >= 0
                                            )
                                            {
                                                IsS = true;
                                                SetSupHuTrue();
                                            }
                                        }
                                    }
                                    //when thre is most reduced support finding
                                    int[] IsNo = MostOfFindMostHeuristicAllReducedSupportInList(Before, RowD, ColD);
                                    if (IsNo != null)
                                    {
                                        if (IsNo[1] < HeuristicAllReducedSupport.Count && IsNo[1] >= HeuristicAllReducedSupportMidel)
                                        {
                                            if (NoOfExistInAttackList(Before, RowS, ColS, HeuristicAllReducedSupport[IsNo[1]][0], HeuristicAllReducedSupport[IsNo[1]][1]) > 0)
                                                ClearSupHuTrue();
                                        }
                                    }

                                    if (!IsS)
                                        ClearSupHuTrue();
                                }
                            }
                            if (HDoubleAttack > 0)
                            {
                                if (!IsSupHuTrue())
                                {
                                    WinOcuuredatChiled = 5;
                                }
                                else
                                    WinOcuuredatChiled = 0;
                            }
                        }
                    }
                    if (!IsSupHuTrue() && (Order == AllDraw.OrderPlateDraw))
                    {
                        H1 = Task.Factory.StartNew(() => Achmaz(CloneATable(TableS), Before, RowS, ColS, RowD, ColD, Order));
                        H1.Wait();
                        H1.Dispose();
                        if (Before)
                        {
                            int TotalS = 0;
                            int IsSC = 0;
                            NoOfObjectNotMovable(CloneATable(TableS), Order, OrderColor(Order), ref TotalS, ref IsSC);
                            if ((16 - ColleralationGray) + IsSC >= TotalS)
                                GoldenFinished = true;
                            HAchmaz = (RationalPenalty * (AchmazReducedBefore(Before, CloneATable(TableS)))) + (RationalRegard * (AchmazPuredBefore(Before, CloneATable(TableS))));
                            /* if (HAchmaz > 0)
                             {
                                 //IsSup[IsSup.Count - 1] = false;
                             }
                             else*/
                            if (HAchmaz < 0)
                            {
                                IsSupHu[IsSupHu.Count - 1] = true;
                                //IsSup[IsSup.Count - 1] = true;
                            }
                        }
                        else
                        {
                            int TotalS = 0;
                            int IsSC = 0;
                            NoOfObjectNotMovable(CloneATable(TableS), Order, OrderColor(Order), ref TotalS, ref IsSC);
                            if ((16 - ColleralationBrown) + IsSC >= TotalS)
                                GoldenFinished = true;
                            HAchmaz = (RationalPenalty * (AchmazReducedAfter(Before, CloneATable(TableS)))) + (RationalRegard * (AchmazPuredAfter(Before, CloneATable(TableS))));
                            /* if (HAchmaz > 0)
                              {
                                  //IsSup[IsSup.Count - 1] = false;
                              }
                              else*/
                            if (HAchmaz < 0)
                            {
                                IsSupHu[IsSupHu.Count - 1] = true;
                                //IsSup[IsSup.Count - 1] = true;
                            }
                        }

                    }
                    if (!IsSupHuTrue() && (Order == AllDraw.OrderPlateDraw))
                    {

                        H2 = Task.Factory.StartNew(() => HDoubleAttack = DoubleAttack(CloneATable(TableS), Before, RowS, ColS, RowD, ColD, Order));
                        H3 = Task.Factory.StartNew(() => HDoubleDefense = DoubleDefence(CloneATable(TableS), Before, RowS, ColS, RowD, ColD, Order));
                        H2.Wait();
                        H3.Wait();
                        H2.Dispose();
                        H3.Dispose();
                        if (HDoubleDefense < 0)
                        {
                            SetSupHuTrue();
                            IsS = true;
                        }
                    }
                    if (Before)
                    {
                        HeuristicReducedAttackValue = (Heuristic[0] * SignOrderToPlate(Order));
                        HeuristicAttackValue = (Heuristic[1] * SignOrderToPlate(Order));
                        HeuristicReducedSupport = (Heuristic[2] * SignOrderToPlate(Order));
                        HeuristicSelfSupportedValue = (Heuristic[3] * SignOrderToPlate(Order));
                        HeuristicMovementValue = (Heuristic[4] * SignOrderToPlate(Order));
                        HeuristicReducedMovementValue = ((Heuristic[5] + HExchangeInnovation + HExchangeSupport) * SignOrderToPlate(Order));
                        HeuristicCheckedMate = (((HCheck + HAchmaz + HWin + HLose) * SignOrderToPlate(Order)));
                        HeuristicDistributionValue = ((HDistance + HAchmaz + HDoubleAttack + HDoubleDefense) * SignOrderToPlate(Order));
                        HeuristicKingSafe = (HKingSafe * SignOrderToPlate(Order));
                        HeuristicKingDangour = (HKingDangour * SignOrderToPlate(Order));
                        HeuristicFromCenter = (HFromCenter * SignOrderToPlate(Order));
                    }
                    else
                    {
                        HeuristicReducedAttackValue += (Heuristic[0] * SignOrderToPlate(Order));
                        HeuristicAttackValue += (Heuristic[1] * SignOrderToPlate(Order));
                        HeuristicReducedSupport += (Heuristic[2] * SignOrderToPlate(Order));
                        HeuristicSelfSupportedValue += (Heuristic[3] * SignOrderToPlate(Order));
                        HeuristicMovementValue += (Heuristic[4] * SignOrderToPlate(Order));
                        HeuristicReducedMovementValue += ((Heuristic[5] + HExchangeInnovation + HExchangeSupport) * SignOrderToPlate(Order));
                        HeuristicCheckedMate += (((HCheck) * SignOrderToPlate(Order)));
                        HeuristicDistributionValue += ((HDistance + HAchmaz + HDoubleAttack) * SignOrderToPlate(Order));
                        HeuristicKingSafe += (HKingSafe * SignOrderToPlate(Order));
                        HeuristicKingDangour += (HKingDangour * SignOrderToPlate(Order));
                        HeuristicFromCenter += (HFromCenter * SignOrderToPlate(Order));
                    }
                }
            }
        }

        //find of "FindMostHeuristicAllReducedSupportIsCurrent" in board
        int[] MostOfFindMostHeuristicAllReducedSupportInList(bool Before, int RowS, int ColS)
        {
            Object O = new Object();
            lock (O)
            {
                int[] IsNo = FindMostHeuristicAllReducedSupportIsCurrent(Before, RowS, ColS);

                for (int ii = 0; ii < 8; ii++)
                {
                    for (int jj = 0; jj < 8; jj++)
                    {
                        int[] Is = FindMostHeuristicAllReducedSupportIsCurrent(Before, ii, jj);
                        if (Is[0] > IsNo[0])
                        {
                            return null;
                        }
                    }
                }
                return IsNo;
            }
        }
        //find of most supported objects in enemy
        int[] FindMostHeuristicAllReducedSupportIsCurrent(bool Before, int RowS, int ColS)
        {
            int[] IsNo = new int[2];
            if (!Before)
            {
                if (HeuristicAllReducedSupportMidel > 0 && HeuristicAllReducedSupportMidel < HeuristicAllReducedSupport.Count)
                {
                    for (int i = HeuristicAllReducedSupportMidel; i < HeuristicAllReducedSupport.Count; i++)
                    {
                        if (HeuristicAllReducedSupport[i][2] == RowS && HeuristicAllReducedSupport[i][3] == ColS)
                        {
                            for (int ii = 0; ii < 8; ii++)
                            {
                                for (int jj = 0; jj < 8; jj++)
                                {
                                    int s = IsNo[0];
                                    IsNo[0] += NoOfExistInReducedSupportList(Before, RowS, ColS, ii, jj);
                                    if (s < IsNo[0])
                                    {
                                        IsNo[1] = i;
                                    }
                                    else
                                        IsNo[0] = s;

                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < HeuristicAllReducedSupport.Count; i++)
                {
                    if (HeuristicAllReducedSupport[i][2] == RowS && HeuristicAllReducedSupport[i][3] == ColS)
                    {
                        for (int ii = 0; ii < 8; ii++)
                        {
                            for (int jj = 0; jj < 8; jj++)
                            {
                                int s = IsNo[0];
                                IsNo[0] += NoOfExistInReducedSupportList(Before, RowS, ColS, ii, jj);
                                if (s < IsNo[0])
                                {
                                    IsNo[1] = i;
                                }
                                else
                                    IsNo[0] = s;
                            }
                        }
                    }
                }
            }
            return IsNo;
        }
        //determine if source objects is movable on board
        bool ObjectMovable(int Row, int Col, int[,] Tab, int Order, Color a)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Movable(CloneATable(Tab), Row, Col, i, j, a, Order))
                        {
                            return true;
                        }
                        if (Attack(CloneATable(Tab), Row, Col, i, j, a, Order))
                        {
                            return true;
                        }
                    }
                }
                return Is;
            }
        }
        //when exist "s" in list A
        bool Exist(List<int[]> A, int[] s)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                for (int h = 0; h < A.Count; h++)
                {
                    if (A[h][0] == s[0] && A[h][1] == s[1])
                    {
                        Is = true;
                        break;
                    }
                }
                return Is;
            }
        }
        //when exist complete "s" in list A
        bool ExistFull(List<int[]> A, int[] s)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                for (int h = 0; h < A.Count; h++)
                {
                    if (A[h][0] == s[0] && A[h][1] == s[1] && A[h][2] == s[2] && A[h][3] == s[3])
                    {
                        Is = true;
                        break;
                    }
                }
                return Is;
            }
        }
        //when exist complete "s" list in list A
        bool ExistFullDoubleList(List<List<int[]>> A, List<int[]> s)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                for (int t = 0; t < s.Count; t++)
                {
                    bool IsI = false;
                    for (int h = 0; h < A.Count; h++)
                    {
                        if (ExistFull(A[h], s[t]))
                        {
                            IsI = true;
                        }
                    }
                    Is = IsI || Is;
                }
                return Is;
            }
        }
        //return number of un movable objects on board
        int NoOfObjectNotMovable(int[,] Tab, int Order, Color a, ref int Total, ref int Is)
        {
            Object O = new Object();
            lock (O)
            {
                List<int[]> IsThere = new List<int[]>();
                for (int Row = 0; Row < 8; Row++)
                {
                    for (int Col = 0; Col < 8; Col++)
                    {
                        if (Order == 1 && Tab[Row, Col] > 0)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (Movable(CloneATable(Tab), Row, Col, i, j, a, Order) && ((TableInitiationPreventionOfMultipleMove[Row, Col] == 0 && TableInitiation[Row, Col] == Tab[Row, Col])))
                                    {
                                        int[] ij = new int[2];
                                        ij[0] = Row;
                                        ij[1] = Col;
                                        if (!(Exist(IsThere, ij)))
                                        {
                                            IsThere.Add(ij);
                                            Is++;
                                        }
                                    }

                                }
                            }
                            Total++;
                        }
                        if (Order == -1 && Tab[Row, Col] < 0)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (Movable(CloneATable(Tab), Row, Col, i, j, a, Order) && ((TableInitiationPreventionOfMultipleMove[Row, Col] == 0 && TableInitiation[Row, Col] == Tab[Row, Col])))
                                    {
                                        int[] ij = new int[2];
                                        ij[0] = Row;
                                        ij[1] = Col;
                                        if (!(Exist(IsThere, ij)))
                                        {
                                            IsThere.Add(ij);
                                            Is++;
                                        }
                                    }
                                }
                            }
                            Total++;
                        }
                    }
                }
                Is = Total - Is;
                return Is;
            }
        }
        //specific determination for ThinkingQuantum main method
        void CastleThinkingGray(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int DummyOrder, int DummyCurrentOrder, int[,] TableS, int RowSource, int ColumnSource, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, int RowDestination, int ColumnDestination, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                TableS = CloneATable(TableConst);
                int HeuristicAttackValue = new int();
                int HeuristicMovementValue = new int();
                int HeuristicSelfSupportedValue = new int();
                int HeuristicReducedMovementValue = new int();
                int HeuristicReducedSupport = new int();
                int HeuristicReducedAttackValue = new int();
                int HeuristicDistributionValue = new int();
                int HeuristicKingSafe = new int();
                int HeuristicFromCenter = new int();
                int HeuristicKingDangour = new int();
                int HeuristicCheckedMate = new int();
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                ThinkingAtRun = true; int CheckedM = 0; bool PenaltyVCar = false;
                bool Sup = false;
                var newTask1 = Task.Factory.StartNew(() => SupMethod(CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, ref Sup));
                newTask1.Wait(); newTask1.Dispose();
                if (!Sup)
                {
                    ///Add Table to List of Private.
                    HitNumberCastling.Add(TableS[RowDestination, ColumnDestination]);
                    Object OO = new Object();
                    lock (OO)
                    {
                        ThinkingRun = true;
                    }
                }
                ///Predict Heuristic.
                Object A = new object();
                lock (A)
                {
                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, true, Order, 0, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                    newTask1.Wait(); newTask1.Dispose();
                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                }
                Object A1 = new object();
                lock (A1)
                {
                    if (!Sup) { NumbersOfAllNode++; }
                }
                int Killed = 0;
                newTask1 = Task.Factory.StartNew(() => KilledMethod(ref Killed, Sup, RowSource, ColumnSource, RowDestination, ColumnDestination, ref TableS));
                newTask1.Wait(); newTask1.Dispose();


                // if (!Sup)
                {
                    Object A3 = new object();
                    lock (A3)
                    {
                        PenaltyVCar = false;
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        newTask1 = Task.Factory.StartNew(() => PenaltyMechanisam(ref PenaltyVCar, ref TmpL, ref TmpW, ref CheckedM, Killed, false, Kind, CloneATable(TableS), RowSource, ColumnSource, ref Current, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, RowDestination, ColumnDestination, Castle));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
                ///Store of Indexes Changes and Table in specific List.
                newTask1 = Task.Factory.StartNew(() => ObjectIndexes(Kind, Sup, RowDestination, ColumnDestination, TableS));
                newTask1.Wait(); newTask1.Dispose();
                ///Wehn Predict of Operation Do operate a Predict of this movments.
                Object A5 = new object();
                lock (A5)
                {
                    //Caused this for Stachostic results.
                    if (!Sup)
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled; newTask1 = Task.Factory.StartNew(() => CalculateHeuristics(TmpL, TmpW, false, Order, Killed, CloneATable(TableS), RowSource, ColumnSource, RowDestination, ColumnDestination, color, ref HeuristicAttackValue, ref HeuristicMovementValue, ref HeuristicSelfSupportedValue, ref HeuristicReducedMovementValue, ref HeuristicReducedSupport, ref HeuristicReducedAttackValue, ref HeuristicDistributionValue, ref HeuristicKingSafe, ref HeuristicFromCenter, ref HeuristicKingDangour, ref HeuristicCheckedMate));
                        newTask1.Wait(); newTask1.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
                //Calculate Heuristic and Add to List and Cal Syntax.
                if (!Sup)
                {
                    String H = "";
                    Object A6 = new object();
                    lock (A6)
                    {
                        AsS(RowSource, ColumnSource, RowDestination, ColumnDestination);
                        int[] Hu = new int[10];
                        //if (!(IsSup[j]))
                        {
                            //if (IgnoreFromCheckandMateHeuristic)

                            newTask1 = Task.Factory.StartNew(() => HuMethod(ref Hu, HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                            newTask1.Wait(); newTask1.Dispose();
                            H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();
                            HeuristicListCastling.Add(Hu);
                        }
                    }
                    Object O4 = new Object();
                    lock (O4)
                    {
                        ThinkingLevel++;
                        ThinkingAtRun = false;
                    }
                }
                else
                {
                    newTask1 = Task.Factory.StartNew(() => HuMethodSup(HeuristicAttackValue, HeuristicMovementValue, HeuristicSelfSupportedValue, HeuristicReducedMovementValue, HeuristicReducedSupport, HeuristicReducedAttackValue, HeuristicDistributionValue, HeuristicKingSafe, HeuristicFromCenter, HeuristicKingDangour, HeuristicCheckedMate));
                    newTask1.Wait(); newTask1.Dispose();
                    int[] Hu = new int[10];
                    newTask1 = Task.Factory.StartNew(() => HuMethodSup(ref Hu));
                    newTask1.Wait(); newTask1.Dispose();

                    String H = " HAttack:" + ((Hu[0])).ToString() + " HMove:" + ((Hu[1])).ToString() + " HSelSup:" + ((Hu[2])).ToString() + " HCheckedMateDang:" + ((Hu[3])).ToString() + " HKiller:" + ((Hu[4])).ToString() + " HReduAttack:" + ((Hu[5])).ToString() + " HDisFromCurrentEnemyking:" + ((Hu[6])).ToString() + " HKingSafe:" + ((Hu[7])).ToString() + " HObjFromCeneter:" + ((Hu[8])).ToString() + " HKingDang:" + ((Hu[9])).ToString();

                    newTask1 = Task.Factory.StartNew(() => HeuristicInsertion(Kind, RowDestination, ColumnDestination, CloneATable(TableS), Hu));
                    newTask1.Wait(); newTask1.Dispose();
                    ThinkingAtRun = false;
                }

            }
            ThinkingAtRun = false;
        }
        public void HeuristicPenaltyValuePerform(QuantumAtamata Current, int Order, ref int HeuristicAttackValue, bool AllDrawClass = false)
        {

            Object O1 = new Object();
            lock (O1)
            {
                if (LearningVarsObject.Count == 0 || AllDrawClass)
                {
                    if (Order != AllDraw.OrderPlateDraw)
                    {
                        if (Current.IsPenaltyAction() == 0)
                            HeuristicAttackValue--;
                    }
                    else
                        if (AllDraw.OrderPlateDraw != Order)
                    {
                        if (Current.IsPenaltyAction() == 0)
                            HeuristicAttackValue++;
                    }
                    if (Order != AllDraw.OrderPlateDraw)
                    {
                        if (Current.IsRewardAction() == 1)
                            HeuristicAttackValue++;
                    }
                    else
                        if (AllDraw.OrderPlateDraw != Order)
                    {
                        if (Current.IsRewardAction() == 1)
                            HeuristicAttackValue++;
                    }
                }
                else
                {
                    if ((LearningVarsObject[LearningVarsObject.Count - 1][1] && !LearningVarsObject[LearningVarsObject.Count - 1][4]))
                    {
                        if (Order != AllDraw.OrderPlateDraw)
                        {
                            if (Current.IsPenaltyAction() == 0)
                                HeuristicAttackValue -= 2;
                        }
                        else
                          if (AllDraw.OrderPlateDraw != Order)
                        {
                            if (Current.IsPenaltyAction() == 0)
                                HeuristicAttackValue += 2;
                        }
                        if (Order != AllDraw.OrderPlateDraw)
                        {
                            if (Current.IsRewardAction() == 1)
                                HeuristicAttackValue += 2;
                        }
                        else
                            if (AllDraw.OrderPlateDraw != Order)
                        {
                            if (Current.IsRewardAction() == 1)
                                HeuristicAttackValue -= 2;
                        }
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingSoldierbase(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] TableS = CloneATable(TableConst);
                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                if (Scop(ii, jj, i, j, 1) && System.Math.Abs(TableS[ii, jj]) == 1 && System.Math.Abs(Kind) == 1)
                {
                    Order = ord;
                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                    var newTask = Task.Factory.StartNew(() => SolderThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle));


                    newTask.Wait(); newTask.Dispose();
                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                }
            }
        }
        void ThinkWait()
        {
            Object O = new Object();
            lock (O)
            {
                do { } while (ThinkingAtRun);
            }
        }
        //specific determination for thinking main method
        public void ThinkingSoldier(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(ii - 2, ii + 3, i =>
                for (var i = ii - 2; i < ii + 3; i++)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(jj - 2, jj + 3, j =>
                    for (var j = jj - 2; j < jj + 3; j++)
                    {
                        int[,] TableS = new int[8, 8];
                        Object O = new Object();
                        lock (O)
                        {
                            if (Scop(ii, jj, i, j, 1))
                            {
                                for (var RowS = 0; RowS < 8; RowS++)
                                    for (var ColS = 0; ColS < 8; ColS++)
                                    {
                                        TableS[RowS, ColS] = TableConst[RowS, ColS];
                                    }
                                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                                var newTask = Task.Factory.StartNew(() => ThinkingSoldierbase(ref TmpL, ref TmpW, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                                newTask.Wait(); newTask.Dispose();
                                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                            }
                        }
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingElephantbase(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);

                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {
                    ///Else for Elephant Thinking.
                    if (Scop(ii, jj, i, j, 2) && System.Math.Abs(TableS[ii, jj]) == 2 && System.Math.Abs(Kind) == 2)
                    {
                        Order = ord;
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => ElephantThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingElephant(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O2 = new Object();
            lock (O2)
            {
                Object O1 = new Object();
                lock (O1)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                    for (var i = 0; i < 8; i++)
                    {////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                        for (var j = 0; j < 8; j++)
                        {
                            Object O = new Object();
                            lock (O)
                            {

                                if (Scop(ii, jj, i, j, 2))
                                {
                                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                                    var newTask = Task.Factory.StartNew(() => ThinkingElephantbase(ref TmpL, ref TmpW, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                                    newTask.Wait(); newTask.Dispose();
                                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                                }
                            }
                        }
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseOne(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);

                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {
                    Order = ord;
                    if (Scop(ii, jj, ii + 2, jj + 1, 3))
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 2, jj + 1, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseTwo(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);


                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);

                Order = ord;
                if (Scop(ii, jj, ii - 2, jj - 1, 3))
                {
                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                    var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 2, jj - 1, Castle));


                    newTask.Wait(); newTask.Dispose();
                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseThree(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);

                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {

                    Order = ord;
                    if (Scop(ii, jj, ii + 2, jj - 1, 3))
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 2, jj - 1, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseFour(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);

                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);

                Order = ord;
                if (Scop(ii, jj, ii - 2, jj + 1, 3))
                {
                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                    var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 2, jj + 1, Castle));


                    newTask.Wait(); newTask.Dispose();
                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseFive(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);


                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {
                    Order = ord;
                    if (Scop(ii, jj, ii + 1, jj + 2, 3))
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 1, jj + 2, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseSix(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = CloneATable(TableConst);


                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {
                    Order = ord;
                    if (Scop(ii, jj, ii - 1, jj - 2, 3))
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 1, jj - 2, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseSeven(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] TableS = CloneATable(TableConst);


                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O111 = new Object();
                lock (O111)
                {
                    Order = ord;
                    if (Scop(ii, jj, ii + 1, jj - 2, 3))
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii + 1, jj - 2, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingHourseEight(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O111 = new Object();
            lock (O111)
            {
                int[,] TableS = CloneATable(TableConst);

                ///Initiate a Local Variables.
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {
                    Order = ord;
                    if (Scop(ii, jj, ii - 1, jj + 2, 3))
                    {
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => HourseThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, ii - 1, jj + 2, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    }
                }
            }
        }

        //specific determination for thinking main method
        public void ThinkingHourse(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O = new Object();
            lock (O)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseOne(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O1 = new Object();
            lock (O1)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseTwo(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O2 = new Object();
            lock (O2)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseThree(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O3 = new Object();
            lock (O3)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseFour(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O4 = new Object();
            lock (O4)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseFive(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O5 = new Object();
            lock (O5)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseSix(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O6 = new Object();
            lock (O6)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseSeven(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
            Object O7 = new Object();
            lock (O7)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask = Task.Factory.StartNew(() => ThinkingHourseEight(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                newTask.Wait(); newTask.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

            }
        }
        //specific determination for thinking main method
        public void ThinkingCastleOne(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {

            Object O1 = new Object();
            lock (O1)
            {
                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                for (var i = 0; i < 8; i++)
                {
                    Object O = new Object();
                    lock (O)
                    {

                        var j = jj;
                        ///Initiate a Local Variables.
                        int[,] TableS = CloneATable(TableConst);
                        ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                        QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                        if (Scop(ii, jj, i, j, 4) && System.Math.Abs(TableS[ii, jj]) == 4 && System.Math.Abs(Kind) == 4)
                        {
                            Order = ord;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            var newTask = Task.Factory.StartNew(() => CastlesThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle));


                            newTask.Wait(); newTask.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingCastleTow(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            //==================
            Object O1 = new Object();
            lock (O1)
            {
                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, j =>
                for (var j = 0; j < 8; j++)
                {
                    Object O = new Object();
                    lock (O)
                    {

                        var i = ii;
                        ///Initiate a Local Variables.
                        int[,] TableS = CloneATable(TableConst);
                        ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                        QuantumAtamata Current = new QuantumAtamata(3, 3, 3);

                        if (Scop(ii, jj, i, j, 4) && System.Math.Abs(TableS[ii, jj]) == 4 && System.Math.Abs(Kind) == 4)
                        {
                            Order = ord;
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            var newTask = Task.Factory.StartNew(() => CastlesThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle));
                            newTask.Wait(); newTask.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingCastle(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {

            Object O = new Object();
            lock (O)
            {
                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                var newTask1 = Task.Factory.StartNew(() => ThinkingCastleOne(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));
                newTask1.Wait(); newTask1.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                var newTask2 = Task.Factory.StartNew(() => ThinkingCastleTow(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));
                newTask2.Wait(); newTask2.Dispose();
                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
            }

        }
        //specific determination for thinking main method
        public void ThinkingMinisterbase(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int i, int j, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {

                ///Initiate a Local Variables.
                int[,] TableS = CloneATable(TableConst);
                ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                Object O = new Object();
                lock (O)
                {

                    if (Scop(ii, jj, i, j, 5) && System.Math.Abs(TableS[ii, jj]) == 5 && System.Math.Abs(Kind) == 5)
                    {
                        Order = ord;
                        int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                        var newTask = Task.Factory.StartNew(() => MinisterThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle));


                        newTask.Wait(); newTask.Dispose();
                        LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingMinister(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                int[,] TableS = new int[8, 8];
                ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, i =>
                for (var i = 0; i < 8; i++)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(0, 8, j =>
                    for (var j = 0; j < 8; j++)
                    {
                        TableS = CloneATable(TableConst);
                        Object O = new Object();
                        lock (O)
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            var newTask = Task.Factory.StartNew(() => ThinkingMinisterbase(ref TmpL, ref TmpW, ord, ii, jj, i, j, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                        }
                    }
                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingCastleBrown(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O = new Object();
            lock (O)
            {
                for (var i = ii - 2; i <= ii + 2; i++)
                {


                    ///Initiate a Local Variables.
                    int[,] TableS = CloneATable(TableConst);

                    ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);

                    if (Scop(ii, jj, i, jj, -7) && System.Math.Abs(TableS[ii, jj]) == 6 && System.Math.Abs(Kind) == 7)
                    {///Calculate of Castles of Brown.
                        if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, -7, CloneATable(TableS), Order, ii, jj)).Rules(ii, jj, i, jj, color, -7) && (ChessRules.CastleKingAllowedBrown))
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            var newTask = Task.Factory.StartNew(() => CastleThinkingBrown(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, jj, Castle));


                            newTask.Wait(); newTask.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ThinkingAtRun = false;
                }
            }

        }
        //specific determination for thinking main method
        public void ThinkingCastleGray(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O = new Object();
            lock (O)
            {
                for (var i = ii - 2; i <= ii + 2; i++)
                {

                    ///Initiate a Local Variables.
                    int[,] TableS = CloneATable(TableConst);

                    if (Scop(ii, jj, i, jj, 7) && System.Math.Abs(TableS[ii, jj]) == 6 && System.Math.Abs(Kind) == 7)
                    { ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                        QuantumAtamata Current = new QuantumAtamata(3, 3, 3);

                        if ((new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, 7, CloneATable(TableS), Order, ii, jj)).Rules(ii, jj, i, jj, color, 7) && (ChessRules.CastleKingAllowedGray))
                        {
                            int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                            var newTask = Task.Factory.StartNew(() => CastleThinkingGray(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, jj, Castle));


                            newTask.Wait(); newTask.Dispose();
                            LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                        }
                    }
                    ThinkingAtRun = false;

                }
            }
        }
        //specific determination for thinking main method
        public void ThinkingKing(ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled, int ord, int ii, int jj, int DummyOrder, int DummyCurrentOrder, bool DoEnemySelf, bool PenRegStrore, bool EnemyCheckMateActionsString, bool Castle)
        {
            Object O1 = new Object();
            lock (O1)
            {
                Object O = new Object();
                lock (O)
                {
                    ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(ii - 1, ii + 2, i =>
                    for (var i = ii - 1; i < ii + 2; i++)
                    {
                        ////ParallelOptions po = new ParallelOptions();       po.MaxDegreeOfParallelism =PlatformHelper.ProcessorCount;                    Parallel.For(jj - 1, jj + 2, j =>
                        for (var j = jj - 1; j < jj + 2; j++)
                        {

                            if (i == ii && j == jj)
                                continue;
                            ///Initiate a Local Variables.
                            int[,] TableS = CloneATable(TableConst);
                            ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                            QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                            if (Scop(ii, jj, i, j, 6) && System.Math.Abs(TableS[ii, jj]) == 6 && System.Math.Abs(Kind) == 6)
                            {
                                Order = ord;
                                int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                                var newTask = Task.Factory.StartNew(() => KingThinkingRefrigtzChessPortable(ref TmpL, ref TmpW, DummyOrder, DummyCurrentOrder, CloneATable(TableS), ii, jj, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, i, j, Castle));


                                newTask.Wait(); newTask.Dispose();
                                LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;

                            }
                        }
                    }
                }
            }
        }
        ///Kernel of Thinking
        //specific thinking main method
        void ThinkingWaite()
        {
            Object O = new Object();
            lock (O)
            {
                while (!ThinkingBegin)
                {
                    if (AllDraw.NumberOfLeafComputation != -1)
                        break;
                }
            }
        }
        //operantinal of creation of current deeper node and set string making
        void FullGameThinkingTreeInitialization(AllDraw THIS, int ik, int j, int Order, int kind)
        {
            //soldier
            if (kind == 1)
            {
                //when valid do create of deeper node and string making
                if (TableListSolder.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListSolder[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
            else if (kind == 2)//elephant 
            {
                //when valid do create of deeper node and string making
                if (TableListElefant.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListElefant[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
            else if (kind == 3)//hourse
            {
                //when valid do create of deeper node and string making
                if (TableListHourse.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListHourse[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
            else if (kind == 4)//Castle
            {
                //when valid do create of deeper node and string making
                if (TableListCastle.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListCastle[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
            else if (kind == 5)//minister
            {
                //when valid do create of deeper node and string making
                if (TableListMinister.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListMinister[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
            else if (kind == 6)//king
            {
                //when valid do create of deeper node and string making
                if (TableListKing.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListKing[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
            else if (kind == 7 || kind == -7)//king
            {
                //when valid do create of deeper node and string making
                if (TableListKing.Count > AStarGreedy.Count)
                {
                    if (AStarGreedy.Count == 0)
                        AStarGreedy = new List<AllDraw>();
                    AStarGreedy.Add(new AllDraw(Order * -1, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged));
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Clear();
                    AStarGreedy[AStarGreedy.Count - 1].TableList.Add(CloneATable(TableListCastling[j]));
                    AStarGreedy[AStarGreedy.Count - 1].SetRowColumn(0);
                    AStarGreedy[AStarGreedy.Count - 1].AStarGreedyString = THIS;
                }
            }
        }
        //Deeper than deeper
        void ThinkingFullGame(int iAStarGreedy, AllDraw THIS)
        {
            Object O = new Object();
            lock (O)
            {
                if (AllDraw.Deeperthandeeper)
                {
                    FullGameAllow = true;
                    if (Kind == 1)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListSolder.Count, i =>
 {
     FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
     AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListSolder[i], Order * -1, false, false, 0);
 });
                    }
                    else
                    if (Kind == 2)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListElefant.Count, i =>
 {
     FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
     AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListElefant[i], Order * -1, false, false, 0);
 });
                    }
                    else
                    if (Kind == 3)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListHourse.Count, i =>
 {
     FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
     AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListHourse[i], Order * -1, false, false, 0);
 });
                    }
                    else
                    if (Kind == 4)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListCastle.Count, i =>
 {
     FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
     AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListCastle[i], Order * -1, false, false, 0);
 });
                    }
                    else
                    if (Kind == 5)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListMinister.Count, i =>
 {
     FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
     AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListMinister[i], Order * -1, false, false, 0);
 });
                    }
                    else
                        if (Kind == 6)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListKing.Count, i =>
 {
     FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
     AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListKing[i], Order * -1, false, false, 0);
 });
                    }
                    else
                        if (Kind == 7 || Kind == -7)
                    {
                        ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, TableListCastling.Count, i =>
                         {
                             FullGameThinkingTreeInitialization(THIS, iIndex, i, Order, Kind);
                             AStarGreedy[i].InitiateAStarGreedyt(iAStarGreedy, 0, 0, ColorOpposite(color), TableListCastling[i], Order * -1, false, false, 0);
                         });
                    }
                    FullGameAllow = false;
                }
            }
        }
        Color ColorOpposite(Color a)
        {
            if (a == Color.Gray)
                return Color.Brown;
            return Color.Gray;
        }
        bool MovableAllObjectsListMethos(int RowS, int ColS)
        {
            bool Is = false;
            if (MovableAllObjectsList.Count == 8)
            {
                if (MovableAllObjectsList[RowS].Count == 8)
                {
                    for (int i = 0; i < MovableAllObjectsList[RowS][ColS].Count; i++)
                    {
                        if (MovableAllObjectsList[RowS][ColS][i][5] == 1)
                            Is = true;
                    }
                }
            }
            return Is;
        }
        void MovableAllObjectsListMethos(int[,] TableS, bool Before, int RowS, int ColS, int RowD, int ColD, int con, int movable = 1)
        {
            if (Before)
            {
                if (MovableAllObjectsList.Count == 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        MovableAllObjectsList.Add(new List<List<int[]>>());
                        for (int k = 0; k < 8; k++)
                            MovableAllObjectsList[i].Add(new List<int[]>());
                    }
                }
                int[] B = new int[6];
                B[0] = RowS;
                B[1] = ColS;
                B[2] = RowD;
                B[3] = ColD;
                if (con == 1)
                    B[4] = TableS[RowS, ColS];
                else
                    B[4] = con;
                B[5] = movable;

                for (int i = 0; i < MovableAllObjectsList[RowS][ColS].Count; i++)
                {
                    if (MovableAllObjectsList[RowS][ColS][i][2] == RowS && MovableAllObjectsList[RowS][ColS][i][3] == ColS && MovableAllObjectsList[RowS][ColS][i][4] == TableS[RowS, ColS])
                        MovableAllObjectsList[RowS][ColS].RemoveAt(i);
                }
                MovableAllObjectsList[RowS][ColS].Add(B);

            }
            else
            {
                if (MovableAllObjectsList.Count == 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        MovableAllObjectsList.Add(new List<List<int[]>>());
                        for (int k = 0; k < 8; k++)
                            MovableAllObjectsList[i].Add(new List<int[]>());
                    }
                }
                int[] B = new int[6];
                B[0] = RowS;
                B[1] = ColS;
                B[2] = RowD;
                B[3] = ColD;
                if (con == 1)
                    B[4] = TableS[RowD, ColD];
                else
                    B[4] = con;
                B[5] = movable;

                for (int i = 0; i < MovableAllObjectsList[RowS][ColS].Count; i++)
                {
                    if (MovableAllObjectsList[RowS][ColS][i][2] == RowS && MovableAllObjectsList[RowS][ColS][i][3] == ColS && MovableAllObjectsList[RowS][ColS][i][4] == TableS[RowS, ColS])
                        MovableAllObjectsList[RowS][ColS].RemoveAt(i);
                }
                MovableAllObjectsList[RowD][ColD].Add(B);

            }
        }
        public void Thinking(int iAStarGreedy, AllDraw THIS, ref int[] LoseOcuuredatChiled, ref int WinOcuuredatChiled)
        {
            try
            {
                if (Order != AllDraw.OrderPlateDraw)
                {
                    //Combination of tow elephant s powerfull of tow hourse
                    if (Kind == 2)
                    {
                        RationalPenalty *= 2;
                        RationalRegard *= 2;
                    }
                    if (Kind == 3)
                    {
                        RationalPenalty /= 2;
                        RationalRegard /= 2;
                    }
                }
                else
                {
                    //defensive of tow elephant and primitative of tow hourse
                    if (Kind == 2)
                    {
                        RationalPenalty /= 2;
                        RationalRegard /= 2;
                    }
                    if (Kind == 3)
                    {
                        RationalPenalty *= 2;
                        RationalRegard *= 2;
                    }
                }


                int ord = Order;
                Object O = new Object();
                lock (O)
                {
                    if (CurrentAStarGredyMax > AllDraw.MaxAStarGreedy)
                    {
                        ThinkingBegin = false;
                        ThinkingFinished = true;

                        return;
                    }
                    Thread t = new Thread(new ThreadStart(ThinkingWaite));
                    t.Start();
                    t.Join();

                    NumberOfPenalties = 0;
                    SetObjectNumbers(CloneATable(TableConst));
                    bool PenRegStrore = true;
                    // if (Order == AllDraw.OrderPlateDraw)

                    Object O1 = new Object();
                    lock (O1)
                    {
                        BeginThread++;
                    }
                    {
                        if (//CheckMateOcuured || 
                            FoundFirstSelfMating > AllDraw.MaxAStarGreedy
                            )
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {

                                ThinkingBegin = false;
                                ThinkingFinished = true;
                                EndThread++;
                            }
                            return;
                        }
                        if (//CheckMateOcuured || 
                            FoundFirstMating > AllDraw.MaxAStarGreedy
                            )
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {

                                ThinkingBegin = false;
                                ThinkingFinished = true;
                                EndThread++;
                            }
                            return;
                        }
                    }
                    int DummyOrder = Order;
                    int DummyCurrentOrder = ChessRules.CurrentOrder;
                    //Initiate Locallly Global Variables. 
                    IndexSoldier = 0;
                    IndexElefant = 0;
                    IndexHourse = 0;
                    IndexCastle = 0;
                    IndexMinister = 0;
                    IndexKing = 0;
                    int[,] TableS = new int[8, 8];
                    ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                    ///Most Dot Net FrameWork Hot Path
                    ///Create A Clone of Current Table Constant in ThinkingRefrigtzChessPortable Object Tasble.
                    ///For Stored Location of Objects.
                    var ii = Row;
                    var jj = Column;
                    if (//CheckMateOcuured ||
                    FoundFirstMating > AllDraw.MaxAStarGreedy
                        )
                    {
                        Object O2 = new Object();
                        lock (O2)
                        {

                            ThinkingFinished = true;
                            ThinkingBegin = false;
                            EndThread++;
                        }
                        return;
                    }
                    if (//CheckMateOcuured || 
                    FoundFirstSelfMating > AllDraw.MaxAStarGreedy
                        )
                    {
                        Object O2 = new Object();
                        lock (O2)
                        {

                            ThinkingFinished = true;
                            ThinkingBegin = false;
                            EndThread++;
                        }
                        return;
                    }
                    IgnoreObjectDangour = -1;
                    ///Initiate a Local Variables.
                    TableS = new int[8, 8];
                    ///"Inizialization of This New Class (Current is Dynamic class Object) is MalFunction (Constant Variable Count).
                    QuantumAtamata Current = new QuantumAtamata(3, 3, 3);
                    ///Most Dot Net FrameWork Hot Path
                    ///Create A Clone of Current Table Constant in ThinkingRefrigtzChessPortable Object Tasble.
                    for (var RowS = 0; RowS < 8; RowS++)
                        for (var ColS = 0; ColS < 8; ColS++)
                        {
                            TableS[RowS, ColS] = TableConst[RowS, ColS];
                        }
                    ///Deterimine for Castle King Wrongly Desision.
                    bool Castle = false;
                    bool DoEnemySelf = true;
                    ChessRules AAA = new ChessRules(CurrentAStarGredyMax, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsChanged, TableS[ii, jj], CloneATable(TableS), Order, ii, jj);
                    if (AAA.CheckMate(CloneATable(TableS), Order))
                    {
                        if (AAA.CheckMateGray || AAA.CheckMateBrown)
                        {
                            Object O2 = new Object();
                            lock (O2)
                            {
                                ThinkingFinished = true;
                                CheckMateOcuured = true;
                                if (//(AAA.CheckGray && AllDraw.OrderPlateDraw == 1) || (AAA.CheckBrown && AllDraw.OrderPlateDraw == -1) || 
                                (AAA.CheckMateGray && AllDraw.OrderPlateDraw == 1) || (AAA.CheckMateBrown && AllDraw.OrderPlateDraw == -1))
                                {
                                    FoundFirstSelfMating++;
                                    if (Order == AllDraw.OrderPlateDraw)
                                        LoseOcuuredatChiled[0] = -2;
                                    IsThereMateOfSelf.Add(true);
                                }
                                if ((AAA.CheckMateGray && AllDraw.OrderPlateDraw == -1) || (AAA.CheckMateBrown && AllDraw.OrderPlateDraw == 1))
                                {
                                    if (Order == AllDraw.OrderPlateDraw)
                                        WinOcuuredatChiled = 3;
                                    FoundFirstMating++;
                                    IsThereMateOfEnemy.Add(true);
                                }
                                EndThread++;
                            }
                            return;
                        }
                    }
                    if (Order == -1 && AAA.CheckBrown)
                    {
                        IgnoreObjectDangour = 0;
                        IsCheck = true;
                        DoEnemySelf = false;
                    }
                    if (Order == -1 && AAA.CheckGray)
                    {
                        IgnoreObjectDangour = 0;
                        IsCheck = true;
                        DoEnemySelf = false;
                    }
                    if (Order == -1 && AAA.CheckGray)
                    {
                        IgnoreObjectDangour = 0;
                        IsCheck = true;
                        DoEnemySelf = false;
                    }
                    if (Order == 1 && AAA.CheckBrown)
                    {
                        IgnoreObjectDangour = 0;
                        IsCheck = true;
                        DoEnemySelf = false;
                    }
                    //When Root is CheckMate Benefit of Current Order No Consideration.
                    int CDumnmy = ChessRules.CurrentOrder;
                    bool EnemyCheckMateActionsString = false;
                    DummyOrder = Order;
                    DummyCurrentOrder = Order;
                    ChessRules.CurrentOrder = DummyCurrentOrder;
                    ///Calculate Castles of Gray King.
                    ///
                    int[] TmpL = LoseOcuuredatChiled; int TmpW = WinOcuuredatChiled;
                    switch (Kind)
                    {
                        case 7:

                            var newTask = Task.Factory.StartNew(() => this.ThinkingCastleGray(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        case -7:

                            newTask = Task.Factory.StartNew(() => this.ThinkingCastleBrown(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        case 1:///For Soldier Thinking

                            newTask = Task.Factory.StartNew(() => ThinkingSoldier(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        case 2:///For Elephant Thinking

                            newTask = Task.Factory.StartNew(() => ThinkingElephant(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        case 3:///For Hourse Thinking

                            newTask = Task.Factory.StartNew(() => ThinkingHourse(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        ///Else For Castles Thinking.
                        case 4:///For Castle Thinking
                            newTask = Task.Factory.StartNew(() => ThinkingCastle(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        ///Else for Minister Thinkings.
                        case 5:///For Minister Thinking

                            newTask = Task.Factory.StartNew(() => ThinkingMinister(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                        ///Else For Kings Thinkings.
                        case 6:///For King Thinking
                            newTask = Task.Factory.StartNew(() => ThinkingKing(ref TmpL, ref TmpW, ord, ii, jj, DummyOrder, DummyCurrentOrder, DoEnemySelf, PenRegStrore, EnemyCheckMateActionsString, Castle));


                            newTask.Wait(); newTask.Dispose();
                            break;
                    }
                    LoseOcuuredatChiled[0] += TmpL[0]; WinOcuuredatChiled += TmpW;
                    Object O3 = new Object();
                    lock (O3)
                    {
                        ///Initiate Global Varibales at END.
                        ThinkingBegin = false;
                        ///This Variable Not Work! 
                        ThinkingFinished = true;
                        Order = DummyOrder;
                        ChessRules.CurrentOrder = DummyCurrentOrder;
                        EndThread++;
                    }
                    //
                    ///Return at End.
                }
                ThinkingFullGame(iAStarGreedy, THIS);
                TowDistrurbProperUsePreferNotToClose(ref LoseOcuuredatChiled, TableConst);
                TowDistrurbProperUse(ref LoseOcuuredatChiled);
            }
            catch (Exception t)
            {
                Log(t);
                ThinkingBegin = false;
                ThinkingFinished = true;
                ThinkingAtRun = false;
            }
            return;
        }
        public bool IsTheeAtleastMAteSelf()
        {
            bool Is = false;
            for (int i = 0; i < IsThereMateOfSelf.Count; i++)
                Is = Is || IsThereMateOfSelf[i];
            return Is;

        }
        public void TowDistrurbProperUse(ref int[] LoseOcuuredatChiled)
        {
            Object OI = new Object();
            lock (OI)
            {
                if (!IsTheeAtleastMAteSelf())
                {
                    if (RemoveOfDisturbIndex == -1)
                    {
                        if (IsSupHu.Count > 0)
                        {
                            bool IsSup = true;
                            for (int i = 0; i < IsSupHu.Count; i++)
                            {
                                //if (IsThereMateOfSelf[i])
                                //LoseChiled[i] = -8;
                                IsSup = IsSup && IsSupHu[i];
                            }
                            if (IsSup)
                            {
                                if (HeuristicAllReducedAttackedMidel - 1 == (HeuristicAllReducedAttacked.Count - HeuristicAllReducedAttackedMidel))
                                {
                                    int i = IndexOfMoved();
                                    if (i != -1)
                                    {
                                        RemoveOfDisturbIndex = IndexOfIsSupTRUE(Kind, HeuristicAllReducedAttacked[i][0], HeuristicAllReducedAttacked[i][1]);
                                        if (RemoveOfDisturbIndex != -1)
                                            IsSupHu[RemoveOfDisturbIndex] = false;
                                        else
                                        {
                                            if (Order == AllDraw.OrderPlateDraw)
                                                LoseOcuuredatChiled[0] = -4;
                                        }
                                    }
                                    /* else
                                     {
                                         if (Order == AllDraw.OrderPlateDraw)
                                             LoseOcuuredatChiled[0] = -4;
                                     }*/

                                }
                                /*  else
                                  {
                                      if (Order == AllDraw.OrderPlateDraw)
                                          LoseOcuuredatChiled[0] = -4;
                                  }*/
                            }
                        }

                    }
                }
            }
        }
        public void TowDistrurbProperUsePreferNotToClose(ref int[] LoseOcuuredatChiled, int[,] Tab)
        {
            Object OI = new Object();
            lock (OI)
            {
                if (!IsTheeAtleastMAteSelf())
                {
                    if (RemoveOfDisturbIndex == -1)
                    {
                        if (IsSupHu.Count > 0)
                        {
                            bool IsSup = true;
                            for (int i = 0; i < IsSupHu.Count; i++)
                            {
                                //if (IsThereMateOfSelf[i])
                                //LoseChiled[i] = -8;
                                IsSup = IsSup && IsSupHu[i];
                            }
                            if (IsSup)
                            {
                                if (HeuristicDoubleDefenceIndexInOnGameMidle > (HeuristicDoubleDefenceIndexInOnGame.Count - HeuristicDoubleDefenceIndexInOnGameMidle))
                                {
                                    int[] i = IndexOfMovedDoubleDefence(Tab);
                                    if (i[0] != -1 & i[1] != -1)
                                    {
                                        if (Kind != i[2])
                                            return;
                                        RemoveOfDisturbIndex = IndexOfIsSupTRUE(Math.Abs(TableConst[HeuristicDoubleDefenceIndexInOnGame[i[0]][i[1]][2], HeuristicDoubleDefenceIndexInOnGame[i[0]][i[1]][3]]), HeuristicDoubleDefenceIndexInOnGame[i[0]]);
                                        bool a = MovableAllObjectsListMethos(HeuristicDoubleDefenceIndexInOnGame[i[0]][i[1]][2], HeuristicDoubleDefenceIndexInOnGame[i[0]][i[1]][3]);
                                        if (RemoveOfDisturbIndex != -1 && a)
                                            IsSupHu[RemoveOfDisturbIndex] = false;
                                        else if (!a)
                                        {
                                            if (Order == AllDraw.OrderPlateDraw)
                                            {
                                                LoseOcuuredatChiled[0] = 5;
                                                LoseOcuuredatChiled[1] = HeuristicDoubleDefenceIndexInOnGame[i[0]][i[1]][2];
                                                LoseOcuuredatChiled[2] = HeuristicDoubleDefenceIndexInOnGame[i[0]][i[1]][3];
                                            }
                                        }
                                    }
                                    /*else
                                    {
                                        if (Order == AllDraw.OrderPlateDraw)
                                            LoseOcuuredatChiled[0] = -4;
                                    }
                                    */
                                }
                            }
                        }
                    }
                }
            }
        }
        int IndexOfMoved()
        {
#pragma warning disable CS0219 // The variable 'i' is assigned but its value is never used
            int i = -1;
#pragma warning restore CS0219 // The variable 'i' is assigned but its value is never used
            for (int j = 0; j < HeuristicAllReducedAttackedMidel; j++)
            {
                bool Is = false;
                for (int k = HeuristicAllReducedAttackedMidel; k < HeuristicAllReducedAttacked.Count; k++)
                {
                    if (HeuristicAllReducedAttacked[j][0] == HeuristicAllReducedAttacked[k][0]
                    && HeuristicAllReducedAttacked[j][1] == HeuristicAllReducedAttacked[k][1]
                    && HeuristicAllReducedAttacked[j][2] == HeuristicAllReducedAttacked[k][2]
                    && HeuristicAllReducedAttacked[j][3] == HeuristicAllReducedAttacked[k][3])
                        Is = true;
                }
                if (!Is)
                    return j;
            }
            return -1;
        }
        int[] IndexOfMovedDoubleDefence(int[,] Tab)
        {
            int Object = 0;
            int[] ObjectIndex = { -1, -1, -1 };
            bool Is = false;
            for (int i = 0; i < HeuristicDoubleDefenceIndexInOnGameMidle; i++)
            {
                if (HeuristicDoubleDefenceIndexInOnGame[i].Count == 1)
                    continue;
                for (int j = 0; j < HeuristicDoubleDefenceIndexInOnGame[i].Count; j++)
                {
                    if (System.Math.Abs(Tab[HeuristicDoubleDefenceIndexInOnGame[i][j][2], HeuristicDoubleDefenceIndexInOnGame[i][j][3]]) > ObjectIndex[2])
                    {
                        Is = true;
                        ObjectIndex[0] = i;
                        ObjectIndex[1] = j;
                        ObjectIndex[2] = System.Math.Abs(Tab[HeuristicDoubleDefenceIndexInOnGame[i][j][2], HeuristicDoubleDefenceIndexInOnGame[i][j][3]]);
                    }
                }
            }
            if (HeuristicDoubleDefenceIndexInOnGameMidle > 0 && HeuristicDoubleDefenceIndexInOnGameMidle != HeuristicDoubleDefenceIndexInOnGame.Count)
            {
                Is = false;
                for (int i = HeuristicDoubleDefenceIndexInOnGameMidle; i < HeuristicDoubleDefenceIndexInOnGame.Count; i++)
                {
                    for (int j = 0; j < HeuristicDoubleDefenceIndexInOnGame[i].Count; j++)
                    {
                        if (System.Math.Abs(Tab[HeuristicDoubleDefenceIndexInOnGame[i][j][2], HeuristicDoubleDefenceIndexInOnGame[i][j][3]]) == Object)
                        {
                            Is = true;
                        }
                    }
                }
            }
            else
                Is = false;
            if (Is)
            {
                ObjectIndex[0] = -1;
                ObjectIndex[1] = -1;
            }
            return ObjectIndex;


        }
        int IndexOfIsSupTRUE(int Kind, int RowD, int ColD)
        {
#pragma warning disable CS0219 // The variable 'i' is assigned but its value is never used
            int i = -1;
#pragma warning restore CS0219 // The variable 'i' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'Is' is assigned but its value is never used
            bool Is = false;
#pragma warning restore CS0219 // The variable 'Is' is assigned but its value is never used
            if (Kind == 1)
            {
                for (int j = 0; j < RowColumnSoldier.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnSoldier[j][0], RowColumnSoldier[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            else
            if (Kind == 2)
            {
                for (int j = 0; j < RowColumnElefant.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnElefant[j][0], RowColumnElefant[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            else
            if (Kind == 3)
            {
                for (int j = 0; j < RowColumnHourse.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnHourse[j][0], RowColumnHourse[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            else
            if (Kind == 4)
            {
                for (int j = 0; j < RowColumnCastle.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnCastle[j][0], RowColumnCastle[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            else
            if (Kind == 5)
            {
                for (int j = 0; j < RowColumnMinister.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnMinister[j][0], RowColumnMinister[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            else
            if (Kind == 6)
            {
                for (int j = 0; j < RowColumnKing.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnKing[j][0], RowColumnKing[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            else
            if (Kind == 7 || Kind == -7)
            {
                for (int j = 0; j < RowColumnKing.Count; j++)
                {
                    if (IsSup[j])
                        continue;
                    if (NoOfExistInReducedAttackList(false, RowColumnKing[j][0], RowColumnKing[j][1], RowD, ColD) == 0)
                        return j;
                }
            }
            return -1;
        }
        int IndexOfIsSupTRUE(int Kind, List<int[]> Row)
        {
            int jj = -1;
            bool Is = false;
            if (Kind == 1)
            {
                for (int j = 0; j < RowColumnSoldier.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (IsSup[j])
                            continue;
                        if (NoOfExistInReducedAttackList(false, RowColumnSoldier[j][0], RowColumnSoldier[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;

                    }
                }
            }
            else
            if (Kind == 2)
            {
                for (int j = 0; j < RowColumnElefant.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (IsSup[j])
                            continue;
                        if (NoOfExistInReducedAttackList(false, RowColumnElefant[j][0], RowColumnElefant[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;
                    }
                }
            }
            else
            if (Kind == 3)
            {
                for (int j = 0; j < RowColumnHourse.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (IsSup[j])
                            continue;
                        if (NoOfExistInReducedAttackList(false, RowColumnHourse[j][0], RowColumnHourse[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;
                    }
                }
            }
            else
            if (Kind == 4)
            {
                for (int j = 0; j < RowColumnCastle.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (NoOfExistInReducedAttackList(false, RowColumnCastle[j][0], RowColumnCastle[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;
                    }
                }
            }
            else
            if (Kind == 5)
            {
                for (int j = 0; j < RowColumnMinister.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (IsSup[j])
                            continue;
                        if (NoOfExistInReducedAttackList(false, RowColumnMinister[j][0], RowColumnMinister[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;
                    }
                }
            }
            else
            if (Kind == 6)
            {
                for (int j = 0; j < RowColumnKing.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (IsSup[j])
                            continue;
                        if (NoOfExistInReducedAttackList(false, RowColumnKing[j][0], RowColumnKing[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;
                    }
                }
            }
            else
            if (Kind == 7 || Kind == -7)
            {
                for (int j = 0; j < RowColumnCastling.Count; j++)
                {
                    for (int i = 0; i < Row.Count; i++)
                    {
                        if (IsSup[j])
                            continue;
                        if (NoOfExistInReducedAttackList(false, RowColumnCastling[j][0], RowColumnCastling[j][1], Row[i][0], Row[i][1]) != 0)
                            Is = true;
                        else
                            jj = j;
                    }
                }
            }
            if (!Is)
                return jj;
            return -1;
        }     //objects value main method
              //objects value main method
        int RetrunValValue(int RowS, int ColS, int RowO, int ColO, int[,] Tab, int Sign)
        {
            int O = 0;
            if (RowO == -1 && ColO == -1)
                O = System.Math.Abs(Tab[RowS, ColS]);
            else
                O = System.Math.Abs(Tab[RowS, ColS]) + System.Math.Abs(Tab[RowO, ColO]);
            O *= Sign;
            return O;
        }
        //objects value main method
        int ObjectValueCalculator(int[,] Table//, int Order
            , int RowS, int ColS, int RowO, int ColumnO)
        {
            int Val = 1;
            if (Table[RowS, ColS] / Order > 0)
            {
                if (System.Math.Abs(Table[RowS, ColS]) == 2)
                {
                    Val = Val * 3;
                }
                else
                        if (System.Math.Abs(Table[RowS, ColS]) == 3)
                {
                    Val = Val * 3;
                }
                else
                            if (System.Math.Abs(Table[RowS, ColS]) == 4)
                {
                    Val = Val * 5;
                }
                else
                                if (System.Math.Abs(Table[RowS, ColS]) == 5)
                {
                    Val = Val * 9;
                }
                else
                                if (System.Math.Abs(Table[RowS, ColS]) == 6)
                {
                    Val = Val * 10;
                }
            }
            else
            if (Table[RowO, ColumnO] / Order > 0)
            {
                if (System.Math.Abs(Table[RowO, ColumnO]) == 2)
                {
                    Val = Val * 3;
                }
                else
                   if (System.Math.Abs(Table[RowO, ColumnO]) == 3)
                {
                    Val = Val * 3;
                }
                else
                       if (System.Math.Abs(Table[RowO, ColumnO]) == 4)
                {
                    Val = Val * 5;
                }
                else
                           if (System.Math.Abs(Table[RowO, ColumnO]) == 5)
                {
                    Val = Val * 9;
                }
                else
                           if (System.Math.Abs(Table[RowO, ColumnO]) == 6)
                {
                    Val = Val * 10;
                }
            }
            //}
            //       if (Val < 0)

            return Val;



        }
        //objects value main method
        int ObjectValueCalculator(int[,] Table//, int Order
            , int RowS, int ColS)
        {
            int Val = 1;

            if (System.Math.Abs(Table[RowS, ColS]) == 1)
            {
                Val = 1;
            }
            else
            if (System.Math.Abs(Table[RowS, ColS]) == 2)
            {
                Val = 3;
            }
            else
                        if (System.Math.Abs(Table[RowS, ColS]) == 3)
            {
                Val = 3;
            }
            else
                            if (System.Math.Abs(Table[RowS, ColS]) == 4)
            {
                Val = 5;
            }
            else
                                if (System.Math.Abs(Table[RowS, ColS]) == 5)
            {
                Val = 9;
            }
            else
                                if (System.Math.Abs(Table[RowS, ColS]) == 6)
            {
                Val = 10;
            }
            return Val;
        }
        //objects value main method determination
        bool SignSelfEmpty(int Obj1, int Obj2, int Order, ref int Ord, ref Color A)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (Order == 1)
                {
                    if (Obj1 > 0 && Obj2 == 0)
                    {
                        Is = true;
                        A = Color.Gray;
                        Ord = 1;
                    }
                }
                else
                {
                    if (Obj1 < 0 && Obj2 == 0)
                    {
                        Is = true;
                        A = Color.Brown;
                        Ord = -1;
                    }
                }
                return Is;
            }
        }
        //objects value main method determination
        bool SignEnemyEmpty(int Obj1, int Obj2, int Order, ref int Ord, ref Color A)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (Order == 1)
                {
                    if (Obj1 < 0 && Obj2 == 0)
                    {
                        Is = true;
                        A = Color.Brown;
                        Ord = -1;
                    }
                }
                else
                {
                    if (Obj1 > 0 && Obj2 == 0)
                    {
                        Is = true;
                        A = Color.Gray;
                        Ord = 1;
                    }
                }
                return Is;
            }
        }
        //objects value main method determination
        bool SignNotEqualEnemy(int Obj1, int Obj2, int Order, ref int Ord, ref Color A)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;

                if (Order == 1)
                {
                    if (Obj1 < 0 && Obj2 > 0)
                    {
                        Is = true;
                        A = Color.Brown;
                        Ord = -1;
                    }
                }
                else
                {
                    if (Obj1 > 0 && Obj2 < 0)
                    {
                        Is = true;
                        A = Color.Gray;
                        Ord = 1;
                    }
                }
                return Is;
            }
        }
        //objects value main method determination
        bool SignEqualSelf(int Obj1, int Obj2, int Order, ref int Ord, ref Color A)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;

                if (Order == 1)
                {
                    if (Obj1 > 0 && Obj2 > 0)
                    {
                        Is = true;
                        A = Color.Gray;
                        Ord = 1;
                    }
                }
                else
                {
                    if (Obj1 < 0 && Obj2 < 0)
                    {
                        Is = true;
                        A = Color.Brown;
                        Ord = -1;
                    }
                }
                return Is;
            }
        }
        //objects value main method determination
        bool SignNotEqualSelf(int Obj1, int Obj2, int Order, ref int Ord, ref Color A)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (Order == 1)
                {
                    if (Obj1 > 0 && Obj2 < 0)
                    {
                        Is = true;
                        A = Color.Gray;
                        Ord = 1;
                    }
                }
                else
                {
                    if (Obj1 < 0 && Obj2 > 0)
                    {
                        Is = true;
                        A = Color.Brown;
                        Ord = -1;
                    }
                }
                return Is;
            }
        }
        bool IsSupHuTrue(int j)
        {
            Object O = new Object();
            lock (O)
            {
                bool Is = false;
                if (!AllDraw.AllowedSupTrue)
                {
                    Is = IsSupHu[j];
                }
                else
                {

                    Is = IsSup[j];
                }
                return Is;
            }
        }
    }
}
//End of Documentation.
