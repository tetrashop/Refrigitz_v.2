namespace Formulas
{
    static class MulTowDivision
    {
        static public AddToTree.Tree MulTowDivisionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = MulTowDivision.MulTowDivisionCalculator(Dummy, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree MulTowDivisionCalculator(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            //int INCREASE = 2147483647;
            UIS.SetProgressValue(UIS.progressBar6, 0);
            if (IS.IsMul(Dummy.SampleAccess))
            {
                if (IS.IsDiv(Dummy.LeftSideAccess.SampleAccess) && IS.IsDiv(Dummy.RightSideAccess.SampleAccess))
                {
                    AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                    MUL = Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess);
                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess));
                    Dummy.LeftSideAccess.SampleAccess = "*";
                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;

                    Dummy.SampleAccess = "/";

                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(MUL, Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess));
                    Dummy.RightSideAccess.SampleAccess = "*";
                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
                }
                UIS.SetProgressValue(UIS.progressBar6, 2147483647);
                /*                else
                                    if (IS.IsDiv(Dummy.LeftSideAccess.SampleAccess))
                                    {
                                        AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                                        MUL = Dummy.CopyNewTree(Dummy.RightSideAccess);
                                        Dummy.RightSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                        Dummy.RightSideAccess.ThreadAccess = Dummy;

                                        Dummy.SampleAccess = "/";

                                        Dummy.LeftSideAccess.RightSideAccess = MUL;
                                        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                        Dummy.LeftSideAccess.SampleAccess = "*";


                                    }
                                    else
                                        if (IS.IsDiv(Dummy.RightSideAccess.SampleAccess))
                                        {
                                            Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess,Dummy.LeftSideAccess);

                                            AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                                            MUL = Dummy.CopyNewTree(Dummy.RightSideAccess);
                                            Dummy.RightSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                            Dummy.RightSideAccess.ThreadAccess = Dummy;

                                            Dummy.SampleAccess = "/";

                                            Dummy.LeftSideAccess.RightSideAccess = MUL;
                                            Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                            Dummy.LeftSideAccess.SampleAccess = "*";


                                        }
                 */

            }
            MulTowDivision.MulTowDivisionCalculator(Dummy.LeftSideAccess, ref UIS);
            MulTowDivision.MulTowDivisionCalculator(Dummy.RightSideAccess, ref UIS);
            return Dummy;
        }
    }
}
