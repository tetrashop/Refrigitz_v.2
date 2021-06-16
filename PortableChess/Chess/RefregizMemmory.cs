/**************************************************************************************************************
 * Ramin Edjlal Copyright 1397/04/20 **************************************************************************
 * 1397/04/26:Problem in Seirlization Recurisvely of linked list for refrigitz.********************************
 * ************************************************************************************************************
 */
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace RefrigtzChessPortable
{

    [Serializable]

    public class RefregizMemmory //:AllDraw
    {
        public static int AllDrawKind = 0;//0,1,2,3,4,5,6
        public static String AllDrawKindString = "";

        public int iii = 0, jjj = 0;
        public bool MovementsAStarGreedyHeuristicFoundT = false;
        public bool IgnoreSelfObjectsT = false;
        public bool UsePenaltyRegardMechnisamT = false;
        public bool BestMovmentsT = false;
        public bool PredictHeuristicT = true;
        public bool OnlySelfT = false;
        public bool AStarGreedyHeuristicT = false;
        public bool ArrangmentsT = false;
        string SAllDraw = "";
        public int Kind = 0;
        //static RefregizMemmory Node;
        public AllDraw Current = null;
        //bool NewListOfNextBegins = true;



        void SetAllDrawKindString()
        {
            Object O = new Object();
            lock (O)
            {
                if (AllDrawKind == 4)
                    AllDrawKindString = "S_AllDrawBT.asd";
                else
                if (AllDrawKind == 3)
                    AllDrawKindString = "S_AllDrawFFST.asd";
                else
                if (AllDrawKind == 2)
                    AllDrawKindString = "S_AllDrawFTSF.asd";
                else
                if (AllDrawKind == 1)
                    AllDrawKindString = "S_AllDrawFFSF.asd";

            }
        }
        public RefregizMemmory(bool MovementsAStarGreedyHeuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments//) : base(MovementsAStarGreedyHeuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments
            )
        {
            if (UsePenaltyRegardMechnisa && AStarGreedyHuris)
                AllDrawKind = 4;
            else
                                           if ((!UsePenaltyRegardMechnisa) && AStarGreedyHuris)
                AllDrawKind = 3;
            if (UsePenaltyRegardMechnisa && (!AStarGreedyHuris))
                AllDrawKind = 2;
            if ((!UsePenaltyRegardMechnisa) && (!AStarGreedyHuris))
                AllDrawKind = 1;
            //Set Configuration To True for some unknown reason!.
            //UpdateConfigurationTableVal = true;                             
            SetAllDrawKindString();
            SAllDraw = AllDrawKindString;


            Object o = new Object();
            lock (o)
            {
                MovementsAStarGreedyHeuristicFoundT = MovementsAStarGreedyHeuristicTFou;
                IgnoreSelfObjectsT = IgnoreSelfObject;
                BestMovmentsT = BestMovment;
                PredictHeuristicT = PredictHurist;
                OnlySelfT = OnlySel;
                ArrangmentsT = Arrangments;
            }

        }
        public AllDraw Load(bool Quantum, int Order)
        {
            Object o = new Object();
            lock (o)
            {
                if (File.Exists(SAllDraw))
                {
                    FileInfo A = new FileInfo(SAllDraw);
                    if (A.Length == 0)
                        return null;

                    AllDraw tt = new AllDraw(Order, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsT);
                    FileStream DummyFileStream = new FileStream(SAllDraw, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                    BinaryFormatter Formatters = new BinaryFormatter();
                    DummyFileStream.Seek(0, SeekOrigin.Begin);

                    Console.WriteLine("Loading...");
                    AllDraw.indexStep = (int)Formatters.Deserialize(DummyFileStream);
                    tt = (AllDraw)Formatters.Deserialize(DummyFileStream);
                    if (tt == null)
                        return tt;
                    tt = (AllDraw)tt.LoaderEC(Quantum, Order, DummyFileStream, Formatters);

                    DummyFileStream.Flush();
                    DummyFileStream.Close();

                    return tt;
                }

                return null;

                //return Node.al;
            }
        }
        public AllDraw LoadJungle(string pathj, bool Quantum, int Order)
        {
            Object o = new Object();
            lock (o)
            {
                SAllDraw = pathj;
                if (File.Exists(SAllDraw))
                {
                    FileInfo A = new FileInfo(SAllDraw);
                    if (A.Length == 0)
                        return null;

                    AllDraw tt = new AllDraw(Order, MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsT);
                    FileStream DummyFileStream = new FileStream(SAllDraw, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                    BinaryFormatter Formatters = new BinaryFormatter();
                    DummyFileStream.Seek(0, SeekOrigin.Begin);

                    Console.WriteLine("Loading...");
                    AllDraw.indexStep = (int)Formatters.Deserialize(DummyFileStream);
                    tt = (AllDraw)Formatters.Deserialize(DummyFileStream);
                    if (tt == null)
                        return tt;
                    tt = (AllDraw)tt.LoaderEC(Quantum, Order, DummyFileStream, Formatters);

                    DummyFileStream.Flush();
                    DummyFileStream.Close();

                    return tt;
                }

                return null;

                //return Node.al;
            }
        }
        public void RewriteAllDraw(int Order)
        {
            Object oo = new Object();
            lock (oo)
            {

                //Current = new AllDraw(MovementsAStarGreedyHeuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHeuristicT, OnlySelfT, AStarGreedyHeuristicT, ArrangmentsT);
                FileStream DummyFileStream = null;



                //RefregizMemmory t = p;

                FileInfo DummyFileInfo = new FileInfo(SAllDraw);
                //DummyFileInfo.Delete();
                DummyFileStream = new FileStream(SAllDraw, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);

                Formatters.Serialize(DummyFileStream, AllDraw.indexStep);
                Formatters.Serialize(DummyFileStream, Current);
                Current.RewriteAllDrawRec(Formatters, DummyFileStream, Order);


                DummyFileStream.Flush(); DummyFileStream.Close();

            }
        }

        public AllDraw AllDrawCurrentAccess
        {
            get
            { return Current; }
            set
            { Current = value; }
        }

    }
}
