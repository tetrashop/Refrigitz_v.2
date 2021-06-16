using System;

namespace Formulas
{
    static class DeletingMultaplification
    {
        static AddToTreeTreeLinkList DELETED = new AddToTreeTreeLinkList();

        static public AddToTree.Tree DeleteingMulFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            try
            {
                Dummy = DeletingMultaplification.ArrangmentToDeleteingMul(Dummy);
                Dummy = DeletingMultaplification.RepeatedlyDeletedAction(Dummy, ref UIS);
                //Dummy = Simplifier.SimplifierFxSimpler(Dummy);
                while (Dummy.ThreadAccess != null)
                    Dummy = Dummy.ThreadAccess;
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
        static public AddToTreeTreeLinkList DeletedAccess
        {
            get { return DELETED; }
            set { DELETED = value; }

        }
        static AddToTree.Tree ArrangmentToDeleteingMul(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            DeletingMultaplification.ArrangmentToDeleteingMul(Dummy.LeftSideAccess);
            DeletingMultaplification.ArrangmentToDeleteingMul(Dummy.RightSideAccess);
            if (Dummy.SampleAccess == "*")
                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                    Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
            if (Dummy.SampleAccess == "*")
                if (IS.IsMulOrDiv(Dummy.LeftSideAccess.SampleAccess))
                    Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
            return Dummy;
        }
        static AddToTree.Tree RepeatedlyDeletedAction(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            DeletingMultaplification.RepeatedlyDeletedAction(Dummy.LeftSideAccess, ref UIS);
            DeletingMultaplification.RepeatedlyDeletedAction(Dummy.RightSideAccess, ref UIS);
            AddToTree.Tree Current = Dummy;
            AddToTree.Tree CurrentTow = Dummy.LeftSideAccess;
            //int INCREASE = 2147483647 / 9;

            try
            {
                UIS.SetProgressValue(UIS.progressBar14, 0);
                if (CurrentTow != null)
                    if (Dummy != null)
                        while ((IS.IsMul(Dummy.SampleAccess)))
                        {
                            if (!DELETED.FINDTreeWithThreadConsideration(Dummy))
                                if (!EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow, Dummy))
                                    if (CurrentTow != null)
                                        while ((IS.IsMul(CurrentTow.SampleAccess)) && (CurrentTow != null))
                                        {


                                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                                if (IS.IsNumber(CurrentTow.LeftSideAccess.SampleAccess))
                                                {
                                                    ///bool LeftTrueRightFalse = false;
                                                    ///if (EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow.ThreadAccess.LeftSideAccess, CurrentTow))
                                                    ///LeftTrueRightFalse = true;
                                                    ///else
                                                    //if (EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow.ThreadAccess.RightSideAccess, CurrentTow))
                                                    //  LeftTrueRightFalse = false;
                                                    AddToTree.Tree HOLDE = Dummy;
                                                    AddToTree.Tree DummyCurrentTow = Dummy.LeftSideAccess;
                                                    Dummy.SetLefTandRightCommonlySide(CurrentTow.RightSideAccess, Dummy.RightSideAccess);
                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                    while (Dummy.ThreadAccess != null)
                                                        Dummy = Dummy.ThreadAccess;
                                                    Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, CurrentTow);
                                                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, DummyCurrentTow);
                                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                    while (Dummy.ThreadAccess != null)
                                                        Dummy = Dummy.ThreadAccess;
                                                    Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, HOLDE);
                                                    DELETED.ADDToTree(Dummy);
                                                }



                                            if (IS.ISindependenceVaribale(Dummy.LeftSideAccess.SampleAccess))
                                                if (IS.IsNumber(CurrentTow.LeftSideAccess.SampleAccess))
                                                    if ((IS.IsPower(CurrentTow.RightSideAccess.SampleAccess)) || (IS.ISindependenceVaribale(CurrentTow.RightSideAccess.SampleAccess)))
                                                        if ((IS.ISindependenceVaribale(CurrentTow.RightSideAccess.LeftSideAccess.SampleAccess)) || (IS.IsNumber(CurrentTow.RightSideAccess.RightSideAccess.SampleAccess)))
                                                        {
                                                            AddToTree.Tree HOLDE = Dummy;
                                                            AddToTree.Tree DummyCurrentTow = Dummy.LeftSideAccess;
                                                            Dummy.SetLefTandRightCommonlySide(CurrentTow.LeftSideAccess, Dummy.RightSideAccess);
                                                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                            while (Dummy.ThreadAccess != null)
                                                                Dummy = Dummy.ThreadAccess;
                                                            Dummy = CurrentTow;
                                                            Dummy.SetLefTandRightCommonlySide(DummyCurrentTow, Dummy.RightSideAccess);
                                                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                            while (Dummy.ThreadAccess != null)
                                                                Dummy = Dummy.ThreadAccess;
                                                            while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, HOLDE))
                                                                Dummy = Dummy.LeftSideAccess;
                                                            DELETED.ADDToTree(Dummy);
                                                        }

                                            if (IS.ISindependenceVaribale(CurrentTow.RightSideAccess.SampleAccess))
                                                if (IS.IsNumber(CurrentTow.LeftSideAccess.SampleAccess))
                                                    if ((IS.IsPower(Dummy.LeftSideAccess.SampleAccess)) || (IS.ISindependenceVaribale(CurrentTow.RightSideAccess.SampleAccess)))
                                                        if ((IS.ISindependenceVaribale(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) || (IS.IsNumber(CurrentTow.RightSideAccess.RightSideAccess.SampleAccess)))
                                                        {
                                                            AddToTree.Tree HOLDE = Dummy;
                                                            AddToTree.Tree DummyCurrentTow = Dummy.LeftSideAccess;
                                                            Dummy.SetLefTandRightCommonlySide(CurrentTow.LeftSideAccess, Dummy.RightSideAccess);
                                                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                            while (Dummy.ThreadAccess != null)
                                                                Dummy = Dummy.ThreadAccess;
                                                            Dummy = CurrentTow;
                                                            Dummy.SetLefTandRightCommonlySide(DummyCurrentTow, Dummy.RightSideAccess);
                                                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                            while (Dummy.ThreadAccess != null)
                                                                Dummy = Dummy.ThreadAccess;
                                                            while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, HOLDE))
                                                                Dummy = Dummy.LeftSideAccess;
                                                            DELETED.ADDToTree(Dummy);
                                                        }


                                            CurrentTow = CurrentTow.LeftSideAccess;
                                        }
                            if (Dummy.LeftSideAccess == null)
                                break;
                            Dummy = Dummy.LeftSideAccess;
                            CurrentTow = Dummy.LeftSideAccess;
                        }
                //Dummy= Dummy;
                while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Current)) && (Dummy.ThreadAccess != null))
                    Dummy = Dummy.ThreadAccess;
                CurrentTow = Dummy.RightSideAccess;

                UIS.SetProgressValue(UIS.progressBar14, 2147483647 / 2);

                if (CurrentTow != null)
                    while (IS.IsMul(Dummy.SampleAccess))
                    {
                        if (CurrentTow != null)
                            while (IS.IsMul(CurrentTow.SampleAccess) && (CurrentTow != null))
                            {


                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(CurrentTow.LeftSideAccess.SampleAccess))
                                    {
                                        ///bool LeftTrueRightFalse = false;
                                        ///if (EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow.ThreadAccess.LeftSideAccess, CurrentTow))
                                        ///LeftTrueRightFalse = true;
                                        ///else
                                        //if (EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow.ThreadAccess.RightSideAccess, CurrentTow))
                                        //  LeftTrueRightFalse = false;
                                        AddToTree.Tree HOLDE = Dummy;
                                        AddToTree.Tree DummyCurrentTow = Dummy.LeftSideAccess;
                                        Dummy.SetLefTandRightCommonlySide(CurrentTow.RightSideAccess, Dummy.RightSideAccess);
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                        while (Dummy.ThreadAccess != null)
                                            Dummy = Dummy.ThreadAccess;
                                        Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, CurrentTow);
                                        Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, DummyCurrentTow);
                                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                                        while (Dummy.ThreadAccess != null)
                                            Dummy = Dummy.ThreadAccess;
                                        Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, HOLDE);
                                        DELETED.ADDToTree(Dummy);
                                    }


                                if (IS.ISindependenceVaribale(Dummy.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(CurrentTow.LeftSideAccess.SampleAccess))
                                        if ((IS.IsPower(CurrentTow.RightSideAccess.SampleAccess)) || (IS.ISindependenceVaribale(CurrentTow.RightSideAccess.SampleAccess)))
                                            if ((IS.ISindependenceVaribale(CurrentTow.RightSideAccess.LeftSideAccess.SampleAccess)) || (IS.IsNumber(CurrentTow.RightSideAccess.RightSideAccess.SampleAccess)))
                                            {
                                                ///bool LeftTrueRightFalse = false;
                                                ///if (EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow.ThreadAccess.LeftSideAccess, CurrentTow))
                                                ///LeftTrueRightFalse = true;
                                                ///else
                                                //if (EqualToObject.IsEqualWithThreadConsiderationCommonly(CurrentTow.ThreadAccess.RightSideAccess, CurrentTow))
                                                //  LeftTrueRightFalse = false;
                                                AddToTree.Tree HOLDE = Dummy;
                                                AddToTree.Tree DummyCurrentTow = Dummy.LeftSideAccess;
                                                Dummy.SetLefTandRightCommonlySide(CurrentTow.LeftSideAccess, Dummy.RightSideAccess);
                                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                while (Dummy.ThreadAccess != null)
                                                    Dummy = Dummy.ThreadAccess;
                                                //Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, CurrentTow);
                                                Dummy = CurrentTow;
                                                Dummy.SetLefTandRightCommonlySide(DummyCurrentTow, Dummy.RightSideAccess);
                                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                while (Dummy.ThreadAccess != null)
                                                    Dummy = Dummy.ThreadAccess;
                                                //Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, HOLDE);
                                                while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, HOLDE))
                                                    Dummy = Dummy.RightSideAccess;
                                                DELETED.ADDToTree(Dummy);
                                            }


                                if (IS.ISindependenceVaribale(CurrentTow.RightSideAccess.SampleAccess))
                                    if (IS.IsNumber(CurrentTow.LeftSideAccess.SampleAccess))
                                        if ((IS.IsPower(Dummy.LeftSideAccess.SampleAccess)) || (IS.ISindependenceVaribale(CurrentTow.RightSideAccess.SampleAccess)))
                                            if ((IS.ISindependenceVaribale(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) || (IS.IsNumber(CurrentTow.RightSideAccess.RightSideAccess.SampleAccess)))
                                            {
                                                AddToTree.Tree HOLDE = Dummy;
                                                AddToTree.Tree DummyCurrentTow = Dummy.LeftSideAccess;
                                                Dummy.SetLefTandRightCommonlySide(CurrentTow.LeftSideAccess, Dummy.RightSideAccess);
                                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                while (Dummy.ThreadAccess != null)
                                                    Dummy = Dummy.ThreadAccess;
                                                Dummy = CurrentTow;
                                                Dummy.SetLefTandRightCommonlySide(DummyCurrentTow, Dummy.RightSideAccess);
                                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                while (Dummy.ThreadAccess != null)
                                                    Dummy = Dummy.ThreadAccess;
                                                while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, HOLDE))
                                                    Dummy = Dummy.LeftSideAccess;
                                                DELETED.ADDToTree(Dummy);
                                            }


                                CurrentTow = CurrentTow.RightSideAccess;
                            }
                        if (Dummy.RightSideAccess == null)
                            break;
                        Dummy = Dummy.RightSideAccess;
                        CurrentTow = Dummy.RightSideAccess;
                    }
                while ((!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Current)) && (Dummy.ThreadAccess != null))
                    Dummy = Dummy.ThreadAccess;
            }
            catch (NullReferenceException t)
            {
                ExceptionClass.ExceptionClassMethod(t);
            }
            UIS.SetProgressValue(UIS.progressBar14, 2147483647);
            return Dummy;
        }

    }
}
