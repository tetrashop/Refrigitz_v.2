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
using Chess;
using System;
using System.Diagnostics;
using System.IO;

namespace RefrigtzW
{
    [Serializable]
    public class TakeRoot
    {

        readonly String path3 = @"temp";
        String AllDrawReplacement = "";
        public static int AllDrawKind = 0;
        public static String AllDrawKindString = "";
        public RefrigtzW.AllDraw t = null;

        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText(AllDraw.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString());
                }
            }
            catch (Exception t) { Log(t); }
        }
        void SetAllDrawKindString()
        {
            Object OO = new Object();
            lock (OO)
            {
                if (AllDrawKind == 4)
                    AllDrawKindString = "AllDrawBT.asd";
                else
                if (AllDrawKind == 3)
                    AllDrawKindString = "AllDrawFFST.asd";
                else
                if (AllDrawKind == 2)
                    AllDrawKindString = "AllDrawFTSF.asd";
                else
                if (AllDrawKind == 1)
                    AllDrawKindString = "AllDrawFFSF.asd";

            }
        }
        void SetAllDrawKind(bool UsePenaltyRegardMechnisam, bool AStarGreedyHeuristic)
        {
            Object OO = new Object();
            lock (OO)
            {
                if (UsePenaltyRegardMechnisam && AStarGreedyHeuristic)
                    AllDrawKind = 4;
                else
          if ((!UsePenaltyRegardMechnisam) && AStarGreedyHeuristic)
                    AllDrawKind = 3;
                if (UsePenaltyRegardMechnisam && (!AStarGreedyHeuristic))
                    AllDrawKind = 2;
                if ((!UsePenaltyRegardMechnisam) && (!AStarGreedyHeuristic))
                    AllDrawKind = 1;
            }
        }
        bool DrawManagement(bool FOUND, bool UsePenaltyRegardMechnisam, bool AStarGreedyHeuristic)
        {
            Object OO = new Object();
            lock (OO)
            {
                SetAllDrawKind(UsePenaltyRegardMechnisam, AStarGreedyHeuristic);
                //Set Configuration To True for some unknown reason!.

                SetAllDrawKindString();

                bool Found = false;
                String P = System.Web.HttpRuntime.AppDomainAppPath + path3 + "\\";
                AllDrawReplacement = P + AllDrawKindString;
                Logger y = new Logger(AllDrawReplacement);

                String PP = System.Web.HttpRuntime.AppDomainAppPath;
                AllDrawKindString = PP + AllDrawKindString;
                y = new Logger(AllDrawKindString);

                if (File.Exists(AllDrawReplacement))
                {
                    if (AllDraw.HarasAct)
                        File.Delete(AllDrawReplacement);
                }
                if (File.Exists(AllDrawKindString))
                {
                    if (AllDraw.HarasAct)
                        File.Delete(AllDrawKindString);

                }
                AllDraw.HarasAct = false;
                if (File.Exists(AllDrawKindString))
                {
                    if (File.Exists(AllDrawReplacement))
                    {
                        if (((new System.IO.FileInfo(AllDrawKindString).Length) < (new System.IO.FileInfo(AllDrawReplacement)).Length))
                        {
                            File.Delete(AllDrawKindString);
                            File.Copy(AllDrawReplacement, AllDrawKindString);
                            Found = true;
                        }
                        else if (((new System.IO.FileInfo(AllDrawKindString).Length) > (new System.IO.FileInfo(AllDrawReplacement)).Length))
                        {
                            if (File.Exists(AllDrawReplacement))
                                File.Delete(AllDrawReplacement);
                            File.Copy(AllDrawKindString, AllDrawReplacement);
                            Found = true;
                        }
                    }
                    else
                    {
                        if (!Directory.Exists(Path.GetFullPath(path3)))
                            Directory.CreateDirectory(Path.GetFullPath(path3));
                        File.Copy(AllDrawKindString, AllDrawReplacement);
                        Found = true;
                    }
                    Found = true;
                }
                else if (File.Exists(AllDrawReplacement))
                {
                    File.Copy(AllDrawReplacement, AllDrawKindString);
                    Found = true;
                }
                return Found;
            }
        }
        public bool Load(bool FOUND, bool Quantum, RefrigtzW.FormRefrigtz Curent, ref bool LoadTree, bool MovementsAStarGreedyHeuristicFound, bool IInoreSelfObjects, bool UsePenaltyRegardMechnisam, bool BestMovments, bool PredictHeuristic, bool OnlySelf, bool AStarGreedyHeuristic, bool ArrangmentsChanged)
        {
            Object OO = new Object();
            lock (OO)
            {
                DrawManagement(FOUND, UsePenaltyRegardMechnisam, AStarGreedyHeuristic);
                bool DrawDrawen = false;
                //Load Middle Targets.
                try
                {
                    if (File.Exists(RefrigtzW.FormRefrigtz.AllDrawKindString))
                    {
                        if (RefrigtzW.FormRefrigtz.MovmentsNumber >= 0)
                        {
                            //if (!Quantum)
                            {
                                GalleryStudio.RefregizMemmory tr = new GalleryStudio.RefregizMemmory(MovementsAStarGreedyHeuristicFound, IInoreSelfObjects, UsePenaltyRegardMechnisam, BestMovments, PredictHeuristic, OnlySelf, AStarGreedyHeuristic, ArrangmentsChanged);
                                t = (RefrigtzW.AllDraw)tr.Load(Quantum, RefrigtzW.FormRefrigtz.OrderPlate);
                                if (t != null)
                                {
                                    Curent.Draw = t;
                                    LoadTree = true;
                                    Curent.Draw = Curent.RootFound();
                                    //Curent.Draw.UpdateLoseAndWinDepenOfKind(Curent.Draw.OrderP);

                                    t = Curent.Draw;

                                    DrawDrawen = true;
                                    //System.Windows.Forms.MessageBox.Show("Load Completed.");
                                }
                            }

                        }
                        File.Delete(RefrigtzW.FormRefrigtz.AllDrawKindString);
                    }
                }
                catch (Exception t) { Log(t); }



                return DrawDrawen;
            }
        }  /*    public bool LoadJungle(String path,bool FOUND, bool Quantum, RefrigtzChessPortableForm Curent, ref bool LoadTree, bool MovementsAStarGreedyHeuristicFound, bool IInoreSelfObjects, bool UsePenaltyRegardMechnisam, bool BestMovments, bool PredictHeuristic, bool OnlySelf, bool AStarGreedyHeuristic, bool ArrangmentsChanged)
        {
            Object OO = new Object();
            lock (OO)
            {
                bool DrawDrawen = false;
                //Load Middle Targets.
                try
                {
                    Refrigtz.AllDrawKindString = path;

                    if (File.Exists(RefrigtzChessPortableForm.AllDrawKindString))
                    {
                        if (RefrigtzChessPortableForm.MovmentsNumber >= 0)
                        {
                            //if (!Quantum)
                            {
                                RefregizMemmory tr = new RefregizMemmory(MovementsAStarGreedyHeuristicFound, IInoreSelfObjects, UsePenaltyRegardMechnisam, BestMovments, PredictHeuristic, OnlySelf, AStarGreedyHeuristic, ArrangmentsChanged);
                                t = (AllDraw)tr.LoadJungle(path, Quantum, RefrigtzChessPortableForm.OrderPlate);
                                if (t != null)
                                {
                                    //Curent.Draw = t;

                                    LoadTree = true;
                                    t = Curent.RootFound();

                                    //Curent.Draw.UpdateLoseAndWinDepenOfKind(Curent.Draw.OrderP);


                                    //t = Curent.Draw;
                                    //Curent.SetDrawFounding(ref FOUND, ref THIS, false);
                                    DrawDrawen = true;

                                    System.Windows.Forms.MessageBox.Show("Load Completed.");
                                }
                            }

                        }
                        File.Delete(chess.AllDrawKindString);
                    }
                }
                catch (Exception t) { Log(t); }
                //System.Threading.Thread ttt = new System.Threading.Thread(new System.Threading.ThreadStart(Wait));
                //ttt.Start();
                //ttt.Join();

                return DrawDrawen;
            }
        }

        */
        void Wait()
        {
            Object O = new Object();
            lock (O)
            {
                PerformanceCounter myAppCpu =
                    new PerformanceCounter(
                        "Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, true);



            }
        }
        public bool Save(bool FOUND, bool Quantum, RefrigtzW.FormRefrigtz Curent, ref bool LoadTree, bool MovementsAStarGreedyHeuristicFound, bool IInoreSelfObjects, bool UsePenaltyRegardMechnisam, bool BestMovments, bool PredictHeuristic, bool OnlySelf, bool AStarGreedyHeuristic, bool ArrangmentsChanged)
        {
            Object OO = new Object();
            lock (OO)
            {


                object o = new object();
                lock (o)
                {
                    if (!Quantum)
                    {
                        if (!RefrigtzW.AllDraw.ChangedInTreeOccured)
                            return true;
                    }
                }

                try
                {

                    RefrigtzW.AllDraw Stote = Curent.Draw;
                    if (!File.Exists(AllDrawKindString))
                    {
                        GalleryStudio.RefregizMemmory rt = new GalleryStudio.RefregizMemmory(MovementsAStarGreedyHeuristicFound, IInoreSelfObjects, UsePenaltyRegardMechnisam, BestMovments, PredictHeuristic, OnlySelf, AStarGreedyHeuristic, ArrangmentsChanged
                            );
                        //if (!Quantum)
                        {
                            if (Curent.Draw != null)
                            {
                                Curent.Draw = Curent.RootFound();
                                rt.AllDrawCurrentAccess = Curent.Draw;
                                rt.RewriteAllDraw(RefrigtzW.FormRefrigtz.OrderPlate);
                                RefrigtzW.AllDraw.DrawTable = false;






                            }
                        }

                    }
                    else
                          if (File.Exists(AllDrawKindString))
                    {

                        File.Delete(RefrigtzW.FormRefrigtz.AllDrawKindString);
                        GalleryStudio.RefregizMemmory rt = new GalleryStudio.RefregizMemmory(MovementsAStarGreedyHeuristicFound, IInoreSelfObjects, UsePenaltyRegardMechnisam, BestMovments, PredictHeuristic, OnlySelf, AStarGreedyHeuristic, ArrangmentsChanged
                            );

                        if (Curent.Draw != null)
                        {
                            Curent.Draw = Curent.RootFound();
                            rt.AllDrawCurrentAccess = Curent.Draw;
                            rt.RewriteAllDraw(RefrigtzW.FormRefrigtz.OrderPlate);
                            RefrigtzW.AllDraw.DrawTable = false;






                        }

                    }
                    Curent.Draw = Stote;
                    return true;
#pragma warning disable CS0162 // Unreachable code detected
                    return true;
#pragma warning restore CS0162 // Unreachable code detected
                }
                catch (Exception t)
                {
                    Log(t);
                    return false;
                }
            }
        }
    }
}
