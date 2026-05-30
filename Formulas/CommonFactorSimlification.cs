//ERRORCORECTION30704050  :Refer to page 302.
//====================================================
//ERROCOCRECTIOn8912739879874 :The thread must be refernces to befor node.
//====================================================

namespace Formulas
{
    static class CommonFactorSimlification
    {
        static public AddToTree.Tree CommonFactorSimlificationFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return null;
            bool CONTINUE = false;
            do
            {
                CONTINUE = false;
                Dummy = CommonFactorSimlification.CommonFactorSimlificationActionFx(Dummy, ref CONTINUE, ref UIS);
                while (Dummy.ThreadAccess != null)
                    Dummy = Dummy.ThreadAccess;
                //Dummy = MulTowDivision.MulTowDivisionFx(Dummy);
                //Dummy = Simplifier.SimplifierFxMul(Dummy);
            } while (CONTINUE);

            return Dummy;
        }
        static AddToTree.Tree CommonFactorSimlificationActionFx(AddToTree.Tree Dummy, ref bool CONTINUE, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            Dummy.LeftSideAccess = CommonFactorSimlification.CommonFactorSimlificationActionFx(Dummy.LeftSideAccess, ref CONTINUE, ref UIS);
            Dummy.RightSideAccess = CommonFactorSimlification.CommonFactorSimlificationActionFx(Dummy.RightSideAccess, ref CONTINUE, ref UIS);
            //Dummy = CommonFactorSimlification.CommonFactorSuitable(Dummy,ref CONTINUE);
            int INCREASE = 2147483647 / 20;
            UIS.SetProgressValue(UIS.progressBar7, 0);
            if (IS.IsMinuseOrPluse(Dummy.CopyNewTree(Dummy).SampleAccess))
            {
                if (IS.IsDiv(Dummy.LeftSideAccess.SampleAccess) && (IS.IsDiv(Dummy.RightSideAccess.SampleAccess)))
                {
                    UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                    AddToTree.Tree COMMONFACTOR = CommonFactor.CommonFactorFx(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.RightSideAccess);
                    AddToTree.Tree COMMONFACTORSIMPLIFICATIONONE = new AddToTree.Tree(null, false);
                    AddToTree.Tree COMMONFACTORSIMPLIFICATIONTOW = new AddToTree.Tree(null, false);
                    AddToTree.Tree COMMONFACTORSIMPLIFICATIONTHREE = new AddToTree.Tree(null, false);
                    AddToTree.Tree COMMONFACTORSIMPLIFICATIONFOUR = new AddToTree.Tree(null, false);
                    AddToTree.Tree COMMONFACTORSIMPLIFICATION = new AddToTree.Tree(null, false);

                    /*COMMONFACTORSIMPLIFICATIONONE.SetLefTandRightCommonlySide(COMMONFACTOR.CopyNewTree(COMMONFACTOR),Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess));
                    COMMONFACTORSIMPLIFICATIONONE.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONONE;
                    COMMONFACTORSIMPLIFICATIONONE.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONONE;
                    COMMONFACTORSIMPLIFICATIONONE.SampleAccess = "/";
                    */
                    COMMONFACTORSIMPLIFICATIONONE = Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess);

                    UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                    COMMONFACTORSIMPLIFICATIONTOW.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATIONONE, Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess));
                    COMMONFACTORSIMPLIFICATIONTOW.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTOW;
                    COMMONFACTORSIMPLIFICATIONTOW.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTOW;
                    COMMONFACTORSIMPLIFICATIONTOW.SampleAccess = "*";

                    /*COMMONFACTORSIMPLIFICATIONTHREE.SetLefTandRightCommonlySide(COMMONFACTOR.CopyNewTree(COMMONFACTOR), Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess));
                    COMMONFACTORSIMPLIFICATIONTHREE.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTHREE;
                    COMMONFACTORSIMPLIFICATIONTHREE.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTHREE;
                    COMMONFACTORSIMPLIFICATIONTHREE.SampleAccess = "/";
                    */
                    //ERRORCORECTION30704050  :Refer to page 302.
                    COMMONFACTORSIMPLIFICATIONTHREE = Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess);

                    UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                    COMMONFACTORSIMPLIFICATIONFOUR.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATIONTHREE, Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess));
                    COMMONFACTORSIMPLIFICATIONFOUR.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONFOUR;
                    COMMONFACTORSIMPLIFICATIONFOUR.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONFOUR;
                    COMMONFACTORSIMPLIFICATIONFOUR.SampleAccess = "*";

                    UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                    COMMONFACTORSIMPLIFICATION.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATIONTOW, COMMONFACTORSIMPLIFICATIONFOUR);
                    COMMONFACTORSIMPLIFICATION.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                    COMMONFACTORSIMPLIFICATION.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                    COMMONFACTORSIMPLIFICATION.SampleAccess = Dummy.SampleAccess;

                    UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                    COMMONFACTORSIMPLIFICATION.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATION.CopyNewTree(COMMONFACTORSIMPLIFICATION), COMMONFACTOR.CopyNewTree(COMMONFACTOR));
                    COMMONFACTORSIMPLIFICATION.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                    COMMONFACTORSIMPLIFICATION.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                    COMMONFACTORSIMPLIFICATION.SampleAccess = "/";

                    UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                    COMMONFACTORSIMPLIFICATION.ThreadAccess = Dummy.ThreadAccess;
                    //ERROCOCRECTIOn8912739879874 :The thread must be refernces to befor node.
                    Dummy = COMMONFACTORSIMPLIFICATION;
                    CONTINUE = true;
                }
                else
                {
                    UIS.SetProgressValue(UIS.progressBar7, 2147483647 / 3);
                    if (IS.IsDiv(Dummy.LeftSideAccess.SampleAccess))
                    {
                        UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                        AddToTree.Tree COMMONFACTORSIMPLIFICATIONONE = new AddToTree.Tree(null, false);
                        AddToTree.Tree COMMONFACTORSIMPLIFICATIONTOW = new AddToTree.Tree(null, false);
                        AddToTree.Tree COMMONFACTORSIMPLIFICATION = new AddToTree.Tree(null, false);

                        COMMONFACTORSIMPLIFICATIONONE.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess), Dummy.CopyNewTree(Dummy.RightSideAccess));
                        COMMONFACTORSIMPLIFICATIONONE.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONONE;
                        COMMONFACTORSIMPLIFICATIONONE.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONONE;
                        COMMONFACTORSIMPLIFICATIONONE.SampleAccess = "*";

                        UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                        COMMONFACTORSIMPLIFICATIONTOW.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), COMMONFACTORSIMPLIFICATIONONE.CopyNewTree(COMMONFACTORSIMPLIFICATIONONE));
                        COMMONFACTORSIMPLIFICATIONTOW.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTOW;
                        COMMONFACTORSIMPLIFICATIONTOW.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTOW;
                        COMMONFACTORSIMPLIFICATIONTOW.SampleAccess = Dummy.SampleAccess;

                        UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                        COMMONFACTORSIMPLIFICATION.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATIONTOW, Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess));
                        COMMONFACTORSIMPLIFICATION.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                        COMMONFACTORSIMPLIFICATION.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                        COMMONFACTORSIMPLIFICATION.SampleAccess = "/";

                        COMMONFACTORSIMPLIFICATION.ThreadAccess = Dummy.ThreadAccess;
                        //ERROCOCRECTIOn8912739879874 :The thread must be refernces to befor node.
                        Dummy = COMMONFACTORSIMPLIFICATION;
                        CONTINUE = true;

                        UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);
                    }
                    else
                    {
                        UIS.SetProgressValue(UIS.progressBar7, (2147483647 / 3) * 2);
                        if (IS.IsDiv(Dummy.RightSideAccess.SampleAccess))
                        {
                            UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                            AddToTree.Tree COMMONFACTORSIMPLIFICATIONONE = new AddToTree.Tree(null, false);
                            AddToTree.Tree COMMONFACTORSIMPLIFICATIONTOW = new AddToTree.Tree(null, false);
                            AddToTree.Tree COMMONFACTORSIMPLIFICATION = new AddToTree.Tree(null, false);

                            UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                            COMMONFACTORSIMPLIFICATIONONE.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess), Dummy.CopyNewTree(Dummy.LeftSideAccess));
                            COMMONFACTORSIMPLIFICATIONONE.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONONE;
                            COMMONFACTORSIMPLIFICATIONONE.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONONE;
                            COMMONFACTORSIMPLIFICATIONONE.SampleAccess = "*";

                            UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                            COMMONFACTORSIMPLIFICATIONTOW.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATIONONE.CopyNewTree(COMMONFACTORSIMPLIFICATIONONE), Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess));
                            COMMONFACTORSIMPLIFICATIONTOW.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTOW;
                            COMMONFACTORSIMPLIFICATIONTOW.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATIONTOW;
                            COMMONFACTORSIMPLIFICATIONTOW.SampleAccess = Dummy.SampleAccess;

                            UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                            COMMONFACTORSIMPLIFICATION.SetLefTandRightCommonlySide(COMMONFACTORSIMPLIFICATIONTOW, Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess));
                            COMMONFACTORSIMPLIFICATION.LeftSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                            COMMONFACTORSIMPLIFICATION.RightSideAccess.ThreadAccess = COMMONFACTORSIMPLIFICATION;
                            COMMONFACTORSIMPLIFICATION.SampleAccess = "/";
                            //ERROCOCRECTIOn8912739879874 :The thread must be refernces to befor node.

                            UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);

                            COMMONFACTORSIMPLIFICATION.ThreadAccess = Dummy.ThreadAccess;

                            Dummy = COMMONFACTORSIMPLIFICATION;
                            CONTINUE = true;

                            UIS.SetProgressValue(UIS.progressBar7, INCREASE + UIS.progressBar7.Value);
                        }
                    }
                }
            }
            UIS.SetProgressValue(UIS.progressBar7, 2147483647);


            return Dummy;
        }
        /*static AddToTree.Tree CommonFactorSuitable(AddToTree.Tree Dummy,ref bool CONTINUE) 
        {
            
        }
         */
    }
}
