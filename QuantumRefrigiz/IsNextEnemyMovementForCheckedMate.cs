using System;
using System.Collections.Generic;
using System.Drawing;

namespace QuantumRefrigiz
{
    class IsNextEnemyMovementForCheckedMate : AllDraw
    {
        int[,] TableIsNextEnemyMovementForCheckedMate = new int[8, 8];
        public IsNextEnemyMovementForCheckedMate(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, int[,] Tab)
            : base(Order, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    TableIsNextEnemyMovementForCheckedMate[i, j] = Tab[i, j];

        }
        public IsNextEnemyMovementForCheckedMate(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments, AllDraw THi, int[,] Tab)
            : base(Order, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments, THi)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    TableIsNextEnemyMovementForCheckedMate[i, j] = Tab[i, j];
        }
        public bool Is()
        {
            bool IS = false;
            Color a = Color.Gray;
            if (OrderP == -1)
                a = Color.Brown;
            //String A1 = AllDraw.ActionString;
            bool A2 = AllDraw.ActionStringReady;
            bool A3 = AllDraw.AStarGreadyFirstSearch;
            int A4 = AllDraw.AStarGreedyiLevelMax;
            double A5 = AllDraw.AStarGreedytMaxCount;
            bool A6 = AllDraw.Blitz;
            int A7 = AllDraw.CastleMovments;
            int A8 = AllDraw.ConvertedKind;
            bool A9 = AllDraw.ConvertWait;
            int A10 = AllDraw.CurrentHeuristic;
            int A11 = AllDraw.DepthIterative;
            bool A12 = AllDraw.DrawTable;
            bool A13 = AllDraw.DynamicAStarGreedytPrograming;
            int A14 = AllDraw.ElefantMovments;
            bool A15 = AllDraw.EndOfGame;
            bool A16 = AllDraw.FoundATable;
            int A17 = AllDraw.HourseMovments;
            String A18 = AllDraw.ImageRoot;
            String A19 = AllDraw.ImagesSubRoot;
            int A20 = AllDraw.increasedProgress;
            int A21 = AllDraw.KingMovments;
            int A22 = AllDraw.LastColumnQ;
            int A23 = AllDraw.LastRowQ;
            double A24 = AllDraw.Less;
            int A25 = AllDraw.LoopHeuristicIndex;
            int A26 = AllDraw.MaxAStarGreedy;
            //int A27 = AllDraw.MaxAStarGreedyHuristicProgress;
            int A28 = AllDraw.MinisterMovments;
            int A29 = AllDraw.MinThinkingQuantumTreeDepth;
            int A30 = AllDraw.MouseClick;
            int A31 = AllDraw.MovmentsNumber;
            int A32 = AllDraw.NextColumnQ;
            int A33 = AllDraw.NextRowQ;
            bool A34 = AllDraw.NoTableFound;
            int A35 = AllDraw.OrderPlate;
            //String A36 = AllDraw.OutPut;
            bool A37 = AllDraw.Person;
            bool A38 = AllDraw.RedrawTable;
            bool A39 = AllDraw.RegardOccurred;
            String A40 = AllDraw.Root;
            int A41 = AllDraw.SignAttack;
            int A42 = AllDraw.SignDistance;
            int A43 = AllDraw.SignKiller;
            int A44 = AllDraw.SignKingDangour;
            int A45 = AllDraw.SignKingSafe;
            int A46 = AllDraw.SignMovments;
            int A47 = AllDraw.SignObjectDangour;
            int A48 = AllDraw.SignReducedAttacked;
            int A49 = AllDraw.SignSupport;
            bool A50 = AllDraw.SodierConversionOcuured;
            int A51 = AllDraw.SodierMovments;
            bool A52 = AllDraw.StateCP;
            bool A53 = AllDraw.Stockfish;
            List<AllDraw> A54 = new List<AllDraw>();
            for (int i = 0; i < AllDraw.StoreADraw.Count; i++)
                A54.Add(AllDraw.StoreADraw[i]);
            List<int> A55 = new List<int>();
            for (int i = 0; i < AllDraw.StoreADrawAStarGreedy.Count; i++)
                A55.Add(AllDraw.StoreADrawAStarGreedy[i]);
            int A56 = AllDraw.SuppportCountStaticBrown;
            int A57 = AllDraw.SuppportCountStaticGray;
            String A58 = AllDraw.SyntaxToWrite;
            List<int[,]> A59 = new List<int[,]>();
            for (int i = 0; i < AllDraw.TableCurrent.Count; i++)
                A59.Add(AllDraw.TableCurrent[i]);
            List<int[,]> A60 = new List<int[,]>();
            for (int i = 0; i < AllDraw.TableListAction.Count; i++)
                A60.Add(AllDraw.TableListAction[i]);
            int[,] A61 = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A61[i, j] = AllDraw.TableVeryfy[i, j];
            int[,] A62 = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A62[i, j] = AllDraw.TableVeryfyConst[i, j];
            int A63 = AllDraw.TaskBegin;
            int A64 = AllDraw.TaskEnd;
            String A65 = AllDraw.THIScomboBoxMaxLevelText;
            AllDraw A66 = null;
            if (AllDraw.THISDummy != null)
                AllDraw.THISDummy.Clone(A66);
            bool A67 = AllDraw.THISSecradioButtonBrownOrderChecked;
            bool A68 = AllDraw.THISSecradioButtonGrayOrderChecked;
            //bool A69 = AllDraw.UseintTime;
            String B1 = ThinkingQuantumChess.ActionsString;
            int B2 = ThinkingQuantumChess.BeginThread;
            int B3 = ThinkingQuantumChess.EndThread;
            int B4 = ThinkingQuantumChess.FoundFirstMating;
            int B5 = ThinkingQuantumChess.FoundFirstSelfMating;
            bool B6 = ThinkingQuantumChess.KingMaovableBrown;
            bool B7 = ThinkingQuantumChess.KingMaovableGray;
            bool B8 = ThinkingQuantumChess.LearningVarsCheckedMateOccured;
            bool B9 = ThinkingQuantumChess.LearningVarsCheckedMateOccuredOneCheckedMate;
            int B10 = ThinkingQuantumChess.MaxHeuristicx;
            bool B11 = ThinkingQuantumChess.NotSolvedKingDanger;
            int B12 = ThinkingQuantumChess.NumbersOfAllNode;
            //bool B13 = ThinkingQuantumChess.ThinkingRun;





            AllDraw.Blitz = false;

            MaxAStarGreedy = 1;
            int[,] tab = Initiate(0, 0, a, TableIsNextEnemyMovementForCheckedMate, OrderP, false, false, 0, true);
            if (ThinkingQuantumChess.FoundFirstSelfMating > 0)
                IS = true;

            //AllDraw.ActionString = A1; ;
            AllDraw.ActionStringReady = A2;
            AllDraw.AStarGreadyFirstSearch = A3;
            AllDraw.AStarGreedyiLevelMax = A4;
            //AllDraw.AStarGreedytMaxCount = A5;
            AllDraw.Blitz = A6;
            AllDraw.CastleMovments = A7;
            AllDraw.ConvertedKind = A8;
            AllDraw.ConvertWait = A9;
            AllDraw.CurrentHeuristic = A10;
            AllDraw.DepthIterative = A11;
            AllDraw.DrawTable = A12;
            AllDraw.DynamicAStarGreedytPrograming = A13;
            AllDraw.ElefantMovments = A14;
            AllDraw.EndOfGame = A15;
            AllDraw.FoundATable = A16;
            AllDraw.HourseMovments = A17;
            AllDraw.ImageRoot = A18;
            AllDraw.ImagesSubRoot = A19;
            AllDraw.increasedProgress = A20;
            AllDraw.KingMovments = A21;
            AllDraw.LastColumnQ = A22;
            AllDraw.LastRowQ = A23;
            //AllDraw.Less = A24;
            AllDraw.LoopHeuristicIndex = A25;
            AllDraw.MaxAStarGreedy = A26;
            //AllDraw.MaxAStarGreedyHuristicProgress = A27;
            AllDraw.MinisterMovments = A28;
            AllDraw.MinThinkingQuantumTreeDepth = A29;
            AllDraw.MouseClick = A30;
            AllDraw.MovmentsNumber = A31;
            AllDraw.NextColumnQ = A32;
            AllDraw.NextRowQ = A33;
            AllDraw.NoTableFound = A34;
            AllDraw.OrderPlate = A35;
            //AllDraw.OutPut = A36;
            AllDraw.Person = A37;
            AllDraw.RedrawTable = A38;
            AllDraw.RegardOccurred = A39;
            AllDraw.Root = A40;
            //AllDraw.SignAttack = A41;
            //AllDraw.SignDistance =A42;
            AllDraw.SignKiller = A43;
            AllDraw.SignKingDangour = A44;
            AllDraw.SignKingSafe = A45;
            AllDraw.SignMovments = A46;
            AllDraw.SignObjectDangour = A47;
            AllDraw.SignReducedAttacked = A48;
            AllDraw.SignSupport = A49;
            AllDraw.SodierConversionOcuured = A50;
            AllDraw.SodierMovments = A51;
            AllDraw.StateCP = A52;
            AllDraw.Stockfish = A53;
            AllDraw.StoreADraw.Clear();
            for (int i = 0; i < AllDraw.StoreADraw.Count; i++)
                AllDraw.StoreADraw.Add(A54[i]);
            AllDraw.StoreADrawAStarGreedy.Clear();
            for (int i = 0; i < AllDraw.StoreADrawAStarGreedy.Count; i++)
                AllDraw.StoreADrawAStarGreedy.Add(A55[i]);
            AllDraw.SuppportCountStaticBrown = A56;
            AllDraw.SuppportCountStaticGray = A57;
            AllDraw.SyntaxToWrite = A58;
            AllDraw.TableCurrent.Clear();
            for (int i = 0; i < AllDraw.TableCurrent.Count; i++)
                AllDraw.TableCurrent.Add(A59[i]);
            AllDraw.TableListAction.Clear();
            for (int i = 0; i < AllDraw.TableListAction.Count; i++)
                AllDraw.TableListAction.Add(A60[i]);

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    AllDraw.TableVeryfy[i, j] = A61[i, j];

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    AllDraw.TableVeryfyConst[i, j] = A62[i, j];
            AllDraw.TaskBegin = A63;
            AllDraw.TaskEnd = A64;
            AllDraw.THIScomboBoxMaxLevelText = A65;
            if (A66 != null)
                A66.Clone(AllDraw.THISDummy);
            AllDraw.THISSecradioButtonBrownOrderChecked = A67;
            AllDraw.THISSecradioButtonGrayOrderChecked = A68;
            //AllDraw.UseDoubleTime= A69;
            ThinkingQuantumChess.ActionsString = B1;
            ThinkingQuantumChess.BeginThread = B2;
            ThinkingQuantumChess.EndThread = B3;
            ThinkingQuantumChess.FoundFirstMating = B4;
            ThinkingQuantumChess.FoundFirstSelfMating = B5;
            ThinkingQuantumChess.KingMaovableBrown = B6;
            ThinkingQuantumChess.KingMaovableGray = B7;
            ThinkingQuantumChess.LearningVarsCheckedMateOccured = B8;
            ThinkingQuantumChess.LearningVarsCheckedMateOccuredOneCheckedMate = B9;
            ThinkingQuantumChess.MaxHeuristicx = B10;
            ThinkingQuantumChess.NotSolvedKingDanger = B11;
            ThinkingQuantumChess.NumbersOfAllNode = B12;
            //ThinkingQuantumChess.ThinkingRun = B13;
            return IS;
        }
    }
}
