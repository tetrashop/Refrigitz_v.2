using System;

namespace Formulas
{
    static class DeleteingMinusPluseTree
    {

        static public AddToTree.Tree DeleteingMinusPluseFx(AddToTree.Tree Dummy)
        {
            Dummy = DeleteingMinusPluseTree.ArrangmentToDeleteingMinusPluse(Dummy);
            Dummy = DeleteingMinusPluseTree.RepeatedlyDeletedAction(Dummy);
            while (Dummy.ThreadAccess != null)
                Dummy = Dummy.ThreadAccess;
            return Dummy;
        }
        static AddToTree.Tree ArrangmentToDeleteingMinusPluse(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            DeleteingMinusPluseTree.ArrangmentToDeleteingMinusPluse(Dummy.LeftSideAccess);
            DeleteingMinusPluseTree.ArrangmentToDeleteingMinusPluse(Dummy.RightSideAccess);
            if (Dummy.SampleAccess == "+")
                if (IS.IsMinuseOrPluse(Dummy.LeftSideAccess.SampleAccess))
                    Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
            return Dummy;
        }
        static AddToTree.Tree RepeatedlyDeletedAction(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            DeleteingMinusPluseTree.RepeatedlyDeletedAction(Dummy.LeftSideAccess);
            DeleteingMinusPluseTree.RepeatedlyDeletedAction(Dummy.RightSideAccess);

            AddToTree.Tree Current = Dummy;
            AddToTree.Tree CurrentTow = Dummy.LeftSideAccess;

            if (CurrentTow != null)
                while (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if (CurrentTow != null)
                        while (IS.IsMinuseOrPluse(CurrentTow.SampleAccess))
                        {

                            if (((Dummy.SampleAccess == "+") && (CurrentTow.SampleAccess == "-"))
                            ||
                            ((Dummy.SampleAccess == "-") && (CurrentTow.SampleAccess == "+")))
                            {
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, CurrentTow.RightSideAccess))
                                {
                                    //Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy,Dummy);
                                    String A = Dummy.SampleAccess;
                                    if (Dummy != null)
                                        if (Dummy.ThreadAccess == null)
                                        {
                                            Dummy = Dummy.LeftSideAccess;
                                            Dummy.ThreadAccess = null;

                                        }
                                        else
                                        {
                                            Dummy.ThreadAccess.LeftSideAccess = Dummy.LeftSideAccess;
                                            Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        }
                                    if (A == "+")
                                        while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, CurrentTow.RightSideAccess)) && (Dummy.SampleAccess != "-"))
                                            Dummy = Dummy.LeftSideAccess;

                                    if (A == "-")
                                        while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, CurrentTow.RightSideAccess)) && (Dummy.SampleAccess != "+"))
                                            Dummy = Dummy.LeftSideAccess;
                                    //Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, CurrentTow);

                                    if (Dummy.ThreadAccess == null)
                                    {
                                        Dummy = Dummy.LeftSideAccess;
                                        Dummy.ThreadAccess = null;
                                    }
                                    else
                                    {
                                        Dummy.ThreadAccess.LeftSideAccess = Dummy.LeftSideAccess;
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    }
                                    //if (Dummy.ThreadAccess != null)
                                    //Dummy.ThreadAccess.LeftSideAccess = Dummy.LeftSideAccess;
                                    //Dummy = AddToTree.Tree.DeleteTree(Dummy, CurrentTow);                                
                                    CurrentTow = Dummy.LeftSideAccess;
                                }
                            }
                            CurrentTow = CurrentTow.LeftSideAccess;
                        }
                    Dummy = Dummy.LeftSideAccess;
                    CurrentTow = Dummy.LeftSideAccess;
                }
            //Dummy= Dummy;
            while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Current)) && (Dummy.ThreadAccess != null))
                Dummy = Dummy.ThreadAccess;
            CurrentTow = Dummy.RightSideAccess;

            if (CurrentTow != null)
                while (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if (CurrentTow != null)
                        while (IS.IsMinuseOrPluse(CurrentTow.SampleAccess))
                        {
                            if (((Dummy.SampleAccess == "+") && (CurrentTow.SampleAccess == "-"))
                                ||
                                ((Dummy.SampleAccess == "-") && (CurrentTow.SampleAccess == "+")))
                            {
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, CurrentTow.LeftSideAccess))
                                {

                                    //Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, Dummy);
                                    String A = Dummy.SampleAccess;
                                    if (Dummy.ThreadAccess == null)
                                    {
                                        Dummy = Dummy.RightSideAccess;
                                        Dummy.ThreadAccess = null;
                                    }
                                    else
                                    {
                                        Dummy.ThreadAccess.RightSideAccess = Dummy.RightSideAccess;
                                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    }

                                    if (A == "+")
                                        while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, CurrentTow.LeftSideAccess)) && (Dummy.SampleAccess != "-"))
                                            Dummy = Dummy.RightSideAccess;

                                    if (A == "-")
                                        while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, CurrentTow.RightSideAccess)) && (Dummy.SampleAccess != "+"))
                                            Dummy = Dummy.RightSideAccess;

                                    if (Dummy.ThreadAccess == null)
                                    {
                                        Dummy = Dummy.RightSideAccess;
                                        Dummy.ThreadAccess = null;
                                    }
                                    else
                                    {
                                        Dummy.ThreadAccess.RightSideAccess = Dummy.RightSideAccess;
                                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    }
                                }
                            }
                            CurrentTow = CurrentTow.RightSideAccess;
                        }
                    Dummy = Dummy.RightSideAccess;
                    CurrentTow = Dummy.RightSideAccess;
                }
            return Dummy;
        }

    }
}
