namespace Formulas
{
    static class BesidesAverage
    {
        static public AddToTree.Tree BesidesAverageFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = AddingDivisionToThreeDivStructure.AddingDivisionToThreeDivStructureFx(Dummy);
            return BesidesAverage.BesidesAverageActionFx(Dummy, ref UIS);
        }
        static AddToTree.Tree BesidesAverageActionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            int INCREASE = 2147483647 / 4;
            UIS.SetProgressValue(UIS.progressBar8, 0);
            if (IS.IsDiv(Dummy.SampleAccess))
            {
                if (IS.IsDiv(Dummy.LeftSideAccess.SampleAccess) && IS.IsDiv(Dummy.RightSideAccess.SampleAccess))
                {

                    AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                    MUL = Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess);

                    UIS.SetProgressValue(UIS.progressBar8, INCREASE + UIS.progressBar8.Value);

                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess));
                    Dummy.LeftSideAccess.SampleAccess = "*";
                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;

                    UIS.SetProgressValue(UIS.progressBar8, INCREASE + UIS.progressBar8.Value);

                    Dummy.SampleAccess = "/";

                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess), MUL);
                    Dummy.RightSideAccess.SampleAccess = "*";
                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;

                    UIS.SetProgressValue(UIS.progressBar8, INCREASE + UIS.progressBar8.Value);
                }
                UIS.SetProgressValue(UIS.progressBar8, 2147483647);
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
                                            Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);

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
            Dummy.LeftSideAccess = BesidesAverage.BesidesAverageActionFx(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = BesidesAverage.BesidesAverageActionFx(Dummy.RightSideAccess, ref UIS);
            return Dummy;
        }
    }
}
