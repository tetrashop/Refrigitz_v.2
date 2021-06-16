//ERRORCORECTION897123 :The ERROR31704152 corrected.refer to page 216.
//=====================================================
//ERRRORCORECTION1297192 :Replacement mul on non-proper location.reer to page 218.
//ERRORCORECTION918279 :The invalid rghtside assignment.refer to page 218.
//ERRORCORECTION9318279 :The invalid leftside assignment.refer to page 218.
//=====================================================
//ERRORCORECTINO1782647 :On four Section of while added thwe non function condition.refre to page 226.
//ERROR1928749712 :The *** Mraked edited.refer to page 256.
//LOCATION30415071.refer to page 256.
//=====================================================
//ERRORCUASED817263 :Refer to page 244.
//=====================================================
//ERRORCORECTION1982748234 :Refer to page 249.
//=====================================================
//ERRORCORECTION182797  :Refer to page 335.The Invlaid Deletion Nodes.
//=====================================================
//ERROR92834876 :The Division node is located at left side of Mul and in othere is located at right side.refer to page 336.
//=====================================================
//ERRORCORECTION19208734 :The Above Error.(ERROR92834876)refer to page 336.
//=====================================================
//ERROCORECTION198274896 :The Thread become null and the extra mulated nodes dose not removed.refer to page 336.
//=====================================================
using System;

namespace Formulas
{
    static class MulDivisionSorter
    {
        static AddToTreeTreeLinkList MULATED = new AddToTreeTreeLinkList();
        static public AddToTree.Tree MulDivisionSorterFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = MulDivisionSorter.ArrangmentNumberAndX(Dummy);
            bool CONTINUE = false;
            do
            {
                CONTINUE = false;
                Dummy = MulDivisionSorter.MulDivisionSorterFxAction(Dummy, ref UIS, ref CONTINUE);
            } while (CONTINUE);
            return Dummy;
        }
        static AddToTree.Tree ArrangmentNumberAndX(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.LeftSideAccess != null)
                if (Dummy.RightSideAccess != null)
                    if ((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "+"))
                    {
                        if (Dummy.ThreadAccess != null)
                        {
                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.LeftSideAccess, Dummy))
                            {
                                //if (IS.ISindependenceVaribaleOrNumber(Dummy.LeftSideAccess.SampleAccess))
                                //if (!IS.IsOperator(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsDiv(Dummy.RightSideAccess.SampleAccess))
                                    Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
                            }
                            else
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))
                            {
                                //if (IS.ISindependenceVaribaleOrNumber(Dummy.RightSideAccess.SampleAccess))
                                //if(!IS.IsOperator(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsDiv(Dummy.LeftSideAccess.SampleAccess))
                                    Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
                            }
                        }
                        /*
               if (IS.ISindependenceVaribaleOrNumber(Dummy.LeftSideAccess.SampleAccess))
                   Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
                         */
                    }

            MulDivisionSorter.ArrangmentNumberAndX(Dummy.LeftSideAccess);
            MulDivisionSorter.ArrangmentNumberAndX(Dummy.RightSideAccess);
            return Dummy;
        }
        static AddToTree.Tree MulDivisionSorterFxAction(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS, ref bool CONTINUE)
        {
            if (Dummy == null)
                return Dummy;
            AddToTree.Tree Holder = Dummy;
            Dummy.LeftSideAccess = MulDivisionSorter.MulDivisionSorterFxAction(Dummy.LeftSideAccess, ref UIS, ref CONTINUE);
            try
            {
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {
                    Dummy = Dummy.LeftSideAccess;
                }
                else
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {

                    Dummy = Dummy.RightSideAccess;
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            Dummy.RightSideAccess = MulDivisionSorter.MulDivisionSorterFxAction(Dummy.RightSideAccess, ref UIS, ref CONTINUE);
            try
            {
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {
                    Dummy = Dummy.LeftSideAccess;
                }
                else
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {

                    Dummy = Dummy.RightSideAccess;
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            int INCREASE = 2147483647 / 12;
            UIS.SetProgressValue(UIS.progressBar13, 0);

            AddToTree.Tree Current = new AddToTree.Tree(null, false);

            bool BREAK = false;
            UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);
            while ((Dummy != null) && (Dummy.RightSideAccess != null))
            {
                AddToTree.Tree HolderCurrent = Dummy;
                if (MULATED.FINDTreeWithThreadConsideration(Dummy))
                    break;
                if (IS.IsFunction(Dummy.SampleAccess))
                    break;
                Current = Dummy.RightSideAccess;
                if (!IS.IsDiv(Current.SampleAccess))
                    break;
                if (IS.IsOperator(Dummy.SampleAccess) && (!((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "/"))))
                    BREAK = true;

                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                if (!BREAK)
                    while ((Current != null) && (Current.RightSideAccess != null))
                    {
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Current))
                            break;
                        if (IS.IsFunction(Current.SampleAccess))
                            break;
                        //ERRORCORECTION1982748234 :Refer to page 249.
                        if (!((Dummy.SampleAccess == "*") && (Current.SampleAccess == "/")))
                            break;
                        if (MULATED.FINDTreeWithThreadConsideration(Current))
                            break;
                        if (MULATED.FINDTreeWithThreadConsideration(Dummy))
                            break;
                        if (IS.IsOperator(Dummy.SampleAccess) && (!((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "/"))))
                            BREAK = true;//LOCATION98174723742 :Rfer to page 249.                    
                                         //ERROR1892386124 :The Same node of Current and Dummy node.refer to page 238.
                        if (!BREAK)//ERRORCORECTION897123 :The ERROR31704152 corrected.
                            if ((Current.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                            {
                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                                if (Dummy.FINDTreeWithThreadConsideration(Current, Dummy) != null)
                                    break;
                                CONTINUE = true;
                                AddToTree.Tree LOCAL = Dummy;
                                //ERROR1928749712 :The *** Mraked edited.refer to page 256.
                                AddToTree.Tree MUL = new AddToTree.Tree("*", false);
                                MUL.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess), Current.CopyNewTree(Current.LeftSideAccess));

                                MUL.ThreadAccess = null;

                                MUL.LeftSideAccess.ThreadAccess = MUL;
                                MUL.RightSideAccess.ThreadAccess = MUL;

                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                                AddToTree.Tree Contained = Dummy;

                                while (!(EqualToObject.IsEqualWithThreadConsiderationCommonly(Current, Dummy)))
                                    Dummy = Dummy.RightSideAccess;
                                //====

                                //LOCATION30415071.refer to page 256.
                                //ERRORCORECTION9318279 :The invalid leftside assignment.refer to page 218.
                                Dummy = Dummy.ThreadAccess;
                                //ERROR92834876 :The Division node is located at left side of Mul and in othere is located at right side.refer to page 336.
                                /*Dummy.RightSideAccess.LeftSideAccess = MUL;
                                Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                Dummy.RightSideAccess.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess.LeftSideAccess;
                                Dummy.RightSideAccess.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.LeftSideAccess;
                                */
                                //ERRORCORECTION19208734 :The Above Error.(ERROR92834876)refer to page 336.
                                Dummy.RightSideAccess.LeftSideAccess = MUL;
                                Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                Dummy.RightSideAccess.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess.LeftSideAccess;
                                Dummy.RightSideAccess.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.LeftSideAccess;

                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);



                                //while ((Dummy.ThreadAccess != null) && (!(EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy,LOCAL))))
                                //  Dummy = Dummy.ThreadAccess;

                                //LOCATION30415071.refer to page 256.
                                //ERRORCORECTION9318279 :The invalid leftside assignment.refer to page 218.
                                if (Dummy.ThreadAccess != null)
                                {
                                    //Dummy = Dummy.ThreadAccess;
                                    //Dummy.RightSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                    //ERRORCUASED817263 :Refer to page 244.
                                    //Dummy.ThreadAccess = A;
                                    //Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = Dummy.RightSideAccess;
                                }
                                else
                                {
                                    Dummy = Dummy.RightSideAccess;
                                    Dummy.ThreadAccess = null;
                                }
                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                                MULATED.ADDToTree(Dummy);
                                MULATED.ADDToTree(Current);
                                //Holder = Dummy;
                                //        while ((Dummy != null) && (!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy,LOCAL)))
                                //          Dummy = Dummy.RightSideAccess;                                                                         
                                break;
                            }
                        Current = Current.RightSideAccess;
                    }
                if (BREAK)
                    break;
                if (!CONTINUE)
                {
                    if (Dummy.RightSideAccess != null)
                        Dummy = Dummy.RightSideAccess;
                }
                else
                    break;
                //               if (Dummy.RightSideAccess != null)
                //             Current = Dummy.RightSideAccess;


            }

            UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

            //while ((Dummy.ThreadAccess != null) && (!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Holder)))
            //       Dummy = Dummy.ThreadAccess;


            Current = Dummy.LeftSideAccess;

            while ((Dummy != null) && (Dummy.LeftSideAccess != null))
            {
                if (MULATED.FINDTreeWithThreadConsideration(Dummy))
                    break;
                if (IS.IsFunction(Dummy.SampleAccess))
                    break;
                Current = Dummy.LeftSideAccess;
                if (!IS.IsDiv(Current.SampleAccess))
                    break;
                AddToTree.Tree HolderCurrent = Dummy;
                if (IS.IsOperator(Dummy.SampleAccess) && (!((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "/"))))
                    BREAK = true;
                if (!BREAK)
                    while ((Current != null) && (Current.LeftSideAccess != null))
                    {
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Current))
                            break;
                        if (MULATED.FINDTreeWithThreadConsideration(Current))
                            break;
                        //ERRORCORECTINO1782647 :On four Section of while added thwe non function condition.refre to page 226.
                        if (IS.IsFunction(Current.SampleAccess))
                            break;
                        if (MULATED.FINDTreeWithThreadConsideration(Dummy))
                            break;
                        if (IS.IsOperator(Dummy.SampleAccess) && (!((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "/"))))
                            BREAK = true;
                        //ERRORCORECTION1982748234 :Refer to page 249.
                        if (!((Dummy.SampleAccess == "*") && (Current.SampleAccess == "/")))
                            break;//LOCATION98174723741 :Refer to page 249                    
                        if (!BREAK)//ERRORCORECTION897123 :The ERROR31704152 corrected.
                            if ((Current.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                            {
                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                                if (Dummy.FINDTreeWithThreadConsideration(Current, Dummy) != null)
                                    break;
                                CONTINUE = true;
                                AddToTree.Tree LOCAL = Dummy;
                                AddToTree.Tree MUL = new AddToTree.Tree("*", false);
                                MUL.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess), Current.CopyNewTree(Current.LeftSideAccess));

                                MUL.ThreadAccess = null;

                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                                MUL.LeftSideAccess.ThreadAccess = MUL;
                                MUL.RightSideAccess.ThreadAccess = MUL;

                                AddToTree.Tree Contained = Dummy;

                                while (!(EqualToObject.IsEqualWithThreadConsiderationCommonly(Current, Dummy)))
                                    Dummy = Dummy.LeftSideAccess;
                                //ERRRORCORECTION1297192 :Replacement mul on non-proper location.reer to page 218.

                                //Dummy = Dummy.LeftSideAccess;

                                //                        Dummy.LeftSideAccess = MUL;
                                //                      Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                //                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                //                  Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                Dummy = Dummy.ThreadAccess;
                                //ERROR92834876 :The Division node is located at left side of Mul and in othere is located at right side.refer to page 336.
                                /*Dummy.RightSideAccess.LeftSideAccess = MUL;
                                Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                Dummy.RightSideAccess.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess.LeftSideAccess;
                                Dummy.RightSideAccess.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.LeftSideAccess;
                                */
                                //ERRORCORECTION19208734 :The Above Error.(ERROR92834876)refer to page 336.
                                Dummy.LeftSideAccess.LeftSideAccess = MUL;
                                Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                Dummy.LeftSideAccess.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                Dummy.LeftSideAccess.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess.LeftSideAccess;

                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);



                                //while ((Dummy.ThreadAccess != null) && (!(EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy,LOCAL))))
                                //  Dummy = Dummy.ThreadAccess;

                                //LOCATION30415071.refer to page 256.
                                //ERRORCORECTION9318279 :The invalid leftside assignment.refer to page 218.
                                if (Dummy.ThreadAccess != null)
                                {
                                    //Dummy = Dummy.ThreadAccess;
                                    //Dummy.RightSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                    //ERRORCUASED817263 :Refer to page 244.
                                    //Dummy.ThreadAccess = A;
                                    //Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = Dummy.LeftSideAccess;
                                }
                                else
                                {
                                    Dummy = Dummy.LeftSideAccess;
                                    Dummy.ThreadAccess = null;
                                }
                                UIS.SetProgressValue(UIS.progressBar13, INCREASE + UIS.progressBar13.Value);

                                MULATED.ADDToTree(Dummy);
                                MULATED.ADDToTree(Current);
                                //Holder = Dummy;
                                //while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy,Contained))
                                //  Dummy = Dummy.ThreadAccess;                       
                                break;
                            }
                        Current = Current.LeftSideAccess;
                    }
                if (BREAK)
                    break;
                if (!CONTINUE)
                {
                    if (Dummy.LeftSideAccess != null)
                        Dummy = Dummy.LeftSideAccess;
                }
                else
                    break;
                //             
                //if (Dummy.LeftSideAccess != null)
                //  Current = Dummy.LeftSideAccess;
            }
            //while ((Dummy.ThreadAccess != null) && (!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Holder)))
            //  Dummy = Dummy.ThreadAccess;
            //ERROCORECTION198274896 :The Thread become null and the extra mulated nodes dose not removed.refer to page 336.
            try
            {
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {
                    Dummy = Dummy.LeftSideAccess;
                }
                else
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {

                    Dummy = Dummy.RightSideAccess;
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            UIS.SetProgressValue(UIS.progressBar13, 2147483647);
            return Dummy;
        }
    }
}