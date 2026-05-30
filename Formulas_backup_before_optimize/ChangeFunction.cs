namespace Formulas
{
    static class ChangeFunction
    {
        static public AddToTree.Tree ChangeFunctionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = ChangeFunction.ChangeFunctionFxAction(Dummy);
            return Simplifier.SimplifierFx(Dummy, ref UIS);
        }
        static AddToTree.Tree ChangeFunctionFxAction(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return null;
            if ((Dummy.SampleAccess == "^") && (Dummy.LeftSideAccess.SampleAccess.ToLower() == "sin") && (IS.IsNumber(Dummy.RightSideAccess.SampleAccess)))
            {
                AddToTree.Tree Cos = new AddToTree.Tree("Cos", false);
                AddToTree.Tree TOW = new AddToTree.Tree("2", false);
                AddToTree.Tree ONE = new AddToTree.Tree("1", false);

                float NUM = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                if (NUM <= 1)
                    return Dummy;
                NUM = NUM - 2;

                Cos.LeftSideAccess = new AddToTree.Tree(null, false);
                Cos.LeftSideAccess.ThreadAccess = Cos;

                Cos = Cos.LeftSideAccess;


                Cos.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), TOW.CopyNewTree(TOW));
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;
                Cos.SampleAccess = "*";

                Cos = Cos.ThreadAccess;

                Cos.SetLefTandRightCommonlySide(ONE, Cos.CopyNewTree(Cos));
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;
                Cos.SampleAccess = "-";

                Cos.SetLefTandRightCommonlySide(Cos.CopyNewTree(Cos), TOW);
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;
                Cos.SampleAccess = "/";

                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy.ThreadAccess);
                AddToTree.Tree HOLDERDummy = Dummy.CopyNewTree(Dummy.LeftSideAccess);
                AddToTree.Tree NUMDummy = new AddToTree.Tree(null, false);
                if (NUM > 0)
                {
                    Dummy.LeftSideAccess = Cos;
                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;

                    NUMDummy.SampleAccess = NUM.ToString();

                    HOLDERDummy.SetLefTandRightCommonlySide(HOLDERDummy.CopyNewTree(HOLDERDummy), NUMDummy);
                    HOLDERDummy.RightSideAccess.ThreadAccess = HOLDERDummy;
                    HOLDERDummy.LeftSideAccess.ThreadAccess = HOLDERDummy;
                    HOLDERDummy.SampleAccess = "^";

                    Dummy.RightSideAccess = HOLDERDummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "*";

                }
                else
                    Dummy = Cos;
                Dummy.ThreadAccess = HOLDER;


            }
            if ((Dummy.SampleAccess == "^") && (Dummy.LeftSideAccess.SampleAccess.ToLower() == "cos") && (IS.IsNumber(Dummy.RightSideAccess.SampleAccess)))
            {
                AddToTree.Tree Cos = new AddToTree.Tree("Cos", false);
                AddToTree.Tree TOW = new AddToTree.Tree("2", false);
                AddToTree.Tree ONE = new AddToTree.Tree("1", false);

                float NUM = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                if (NUM <= 1)
                    return Dummy;
                NUM = NUM - 2;

                Cos.LeftSideAccess = new AddToTree.Tree(null, false);
                Cos.LeftSideAccess.ThreadAccess = Cos;

                Cos = Cos.LeftSideAccess;


                Cos.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), TOW.CopyNewTree(TOW));
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;
                Cos.SampleAccess = "*";

                Cos = Cos.ThreadAccess;

                Cos.SetLefTandRightCommonlySide(ONE, Cos.CopyNewTree(Cos));
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;
                Cos.SampleAccess = "+";

                Cos.SetLefTandRightCommonlySide(Cos.CopyNewTree(Cos), TOW);
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;
                Cos.SampleAccess = "/";

                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy.ThreadAccess);
                AddToTree.Tree HOLDERDummy = Dummy.CopyNewTree(Dummy.LeftSideAccess);
                AddToTree.Tree NUMDummy = new AddToTree.Tree(null, false);
                if (NUM > 0)
                {
                    Dummy.LeftSideAccess = Cos;
                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;

                    NUMDummy.SampleAccess = NUM.ToString();

                    HOLDERDummy.SetLefTandRightCommonlySide(HOLDERDummy.CopyNewTree(HOLDERDummy), NUMDummy);
                    HOLDERDummy.RightSideAccess.ThreadAccess = HOLDERDummy;
                    HOLDERDummy.LeftSideAccess.ThreadAccess = HOLDERDummy;
                    HOLDERDummy.SampleAccess = "^";

                    Dummy.RightSideAccess = HOLDERDummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "*";

                }
                else
                    Dummy = Cos;
                Dummy.ThreadAccess = HOLDER;
            }
            return Dummy;
        }
    }
}
