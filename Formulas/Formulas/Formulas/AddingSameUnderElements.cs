//===============================================
//ERRORCORECTION6654444:The Deleting Unregular Plus Operator From Sin(x)^2 Integral:1394/4/6
//===============================================
using System;

namespace Formulas
{
    static class AddingSameUnderElements
    {
        static public AddToTree.Tree AddingSameUnderElementsFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            bool CllingRightTrueLeftFalse = false;
            return AddingSameUnderElements.AddingSameUnderElementsSenderActionFx(Dummy, Dummy, ref CllingRightTrueLeftFalse, ref UIS);
        }
        static AddToTree.Tree AddingSameUnderElementsSenderActionFx(AddToTree.Tree Node, AddToTree.Tree Dummy, ref bool CllingRightTrueLeftFalse, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            try
            {
                if ((IS.IsPluSinNode(Dummy)))
                {
                    CllingRightTrueLeftFalse = false;
                    Dummy.LeftSideAccess = AddingSameUnderElements.AddingSameUnderElementsSenderActionFx(Node, Dummy.LeftSideAccess, ref CllingRightTrueLeftFalse, ref UIS);
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                        Dummy = Dummy.LeftSideAccess;

                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            try
            {
                if ((IS.IsPluSinNode(Dummy)))
                {
                    CllingRightTrueLeftFalse = true;
                    Dummy.RightSideAccess = AddingSameUnderElements.AddingSameUnderElementsSenderActionFx(Node, Dummy.RightSideAccess, ref CllingRightTrueLeftFalse, ref UIS);
                    //ERRORCORECTION6654444:The Deleting Unregular Plus Operator From Sin(x)^2 Integral:1394/4/6
                    if (Dummy.RightSideAccess.ThreadAccess != null && EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess.ThreadAccess, Dummy.ThreadAccess))
                        Dummy = Dummy.RightSideAccess;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            if (Dummy.ThreadAccess != null)
                if (!(((IS.IsMinuseOrPluse(Dummy.ThreadAccess.SampleAccess)))))
                    return Dummy;

            try
            {
                if ((Dummy.ThreadAccess == null) || (Dummy.ThreadAccess.SampleAccess == "+"))
                    if (Dummy.SampleAccess == "/")
                    {
                        /*            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))
                                        Dummy.ThreadAccess.LeftSideAccess = AddingSameUnderElements.AddingSameUnderElementsActionReciverFx(Node, Dummy.ThreadAccess.LeftSideAccess, Dummy,ref CllingRightTrueLeftFalse);
                                    else
                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.LeftSideAccess, Dummy))
                                            Dummy.ThreadAccess.RightSideAccess = AddingSameUnderElements.AddingSameUnderElementsActionReciverFx(Node, Dummy.ThreadAccess.RightSideAccess, Dummy,ref CllingRightTrueLeftFalse);
                         */
                        Dummy.ThreadAccess = AddingSameUnderElements.AddingSameUnderElementsActionReciverFx(Node, Dummy.ThreadAccess, Dummy, ref CllingRightTrueLeftFalse, ref UIS);

                    }

            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
        static AddToTree.Tree OptimizeNode(AddToTree.Tree Dummy)
        {
            while (Dummy.ThreadAccess != null)
                Dummy = Dummy.ThreadAccess;
            return Dummy.CopyReferenclyTree(Dummy);
        }
        static AddToTree.Tree AddingSameUnderElementsActionReciverFx(AddToTree.Tree Node, AddToTree.Tree Dummy, AddToTree.Tree DummySender, ref bool CllingRightTrueLeftFalse, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            try
            {
                if ((IS.IsPluSinNode(Dummy)))
                {
                    CllingRightTrueLeftFalse = false;
                    Dummy.LeftSideAccess = AddingSameUnderElements.AddingSameUnderElementsActionReciverFx(Node, Dummy.LeftSideAccess, DummySender, ref CllingRightTrueLeftFalse, ref UIS);
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            try
            {
                if ((IS.IsPluSinNode(Dummy)))
                {
                    CllingRightTrueLeftFalse = true;
                    Dummy.RightSideAccess = AddingSameUnderElements.AddingSameUnderElementsActionReciverFx(Node, Dummy.RightSideAccess, DummySender, ref CllingRightTrueLeftFalse, ref UIS);
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

            bool CurrentSimplification = false;
            AddToTree.Tree Befor = Dummy.CopyNewTree(Dummy);
            int INCREASE = 2147483647 / 3;
            try
            {
                UIS.SetProgressValue(UIS.progressBar16, 0);

                if (((Dummy.ThreadAccess == null) || (Dummy.ThreadAccess.SampleAccess == "+")) && (((Dummy.SampleAccess == "/"))) && ((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess, DummySender.RightSideAccess))) && ((!(EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, DummySender)))))
                {


                    AddToTree.Tree ADD = new AddToTree.Tree("+", false);
                    AddToTree.Tree Div = new AddToTree.Tree("/", false);
                    ADD.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess), DummySender.CopyNewTree(DummySender.LeftSideAccess));
                    ADD.LeftSideAccess.ThreadAccess = ADD;
                    ADD.RightSideAccess.ThreadAccess = ADD;
                    Div.SetLefTandRightCommonlySide(ADD, Dummy.CopyNewTree(Dummy.RightSideAccess));
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))
                    {
                        Dummy = Dummy.ThreadAccess;
                        Div.ThreadAccess = Dummy;
                        Dummy.RightSideAccess = Div;

                    }
                    else
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.LeftSideAccess, Dummy))
                    {
                        Dummy = Dummy.ThreadAccess;
                        Div.ThreadAccess = Dummy;
                        Dummy.LeftSideAccess = Div;

                    }
                    //AddToTree.Tree HOLDER = Dummy.CopyReferenclyTree(Dummy);
                    AddToTree.Tree HOLDER = Dummy.CopyReferenclyTree(Dummy);

                    UIS.SetProgressValue(UIS.progressBar16, INCREASE + UIS.progressBar16.Value);

                    Node = Dummy.CopyReferenclyTree(Dummy);
                    while (Node.ThreadAccess != null)
                        Node = Node.ThreadAccess;

                    Dummy = Dummy.FINDTreeWithOutThreadConsideration(Node, DummySender);

                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))
                    {
                        Dummy = Dummy.ThreadAccess;
                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                        Dummy = Dummy.LeftSideAccess;
                    }
                    else
                        if (Dummy.ThreadAccess.LeftSideAccess != null && EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.LeftSideAccess, Dummy))
                    {
                        Dummy = Dummy.ThreadAccess;
                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                        Dummy = Dummy.RightSideAccess;
                    }
                    //Node = AddingSameUnderElements.OptimizeNode(Dummy);

                    UIS.SetProgressValue(UIS.progressBar16, INCREASE + UIS.progressBar16.Value);

                    Node = Dummy.CopyReferenclyTree(Dummy);
                    while (Node.ThreadAccess != null)
                        Node = Node.ThreadAccess;

                    if (!(EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Node)))
                        Dummy = Dummy.FINDTreeWithOutThreadConsideration(HOLDER, Node);

                    CurrentSimplification = true;

                }
                else
                {
                    UIS.SetProgressValue(UIS.progressBar16, 2147483647);
                    //if(!CurrentSimplification)
                    //  Dummy = Dummy.FINDTreeWithThreadConsideration(Befor,Dummy);
                    return Dummy;
                }
                if (CurrentSimplification)
                {
                    Dummy = SimplifierCommonSubFactor.SimplifierCommonSubFactorFx(Dummy, ref UIS);
                    Dummy = LocalSimplifier.LocalSimplifierFx(Dummy, ref UIS);

                }
                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Befor))
                {
                    UIS.SetProgressValue(UIS.progressBar16, 2147483647);
                    return Dummy;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            UIS.SetProgressValue(UIS.progressBar16, 2147483647);
            return Dummy;
        }
    }
}
