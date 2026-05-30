//ERRORCORECTION2189743 :the Second condition of above is added.
//======================================================================
//ERROCRECTIOn98217487 :the Last condition (Dummy.ThreadAccess.SampleAccess) is Div.
//======================================================================
using System;

namespace Formulas
{
    static class SimplifierCommonSubFactor
    {
        static public AddToTree.Tree SimplifierCommonSubFactorFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = Spliter.SpliterFx(Dummy, ref UIS);
            bool CONTINUE = false;
            //do
            //{
            //  CONTINUE = false;
            Dummy = NumberDivMul.NumberDivMulFx(Dummy, ref UIS);

            Dummy = SimplifierCommonSubFactor.SimplifierCommonSubFactorCalculatorFx(Dummy, ref CONTINUE, ref UIS);
            //} while (CONTINUE);
            return Dummy;
        }
        static public AddToTree.Tree SimplifierCommonSubFactorCalculatorFx(AddToTree.Tree Dummy, ref bool CONTINUE, ref UknownIntegralSolver UIS)
        {
            if ((Dummy == null) || (!(IS.IsDivInNode(Dummy))))
                return Dummy;
            //ERRORCORECTION2189743 :the Second condition of above is added.
            int INCREASE = 2147483647 / 9;
            UIS.SetProgressValue(UIS.progressBar9, 0);
            if (Dummy.SampleAccess == "/")
            {
                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);
                Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);
                Dummy.LeftSideAccess = FactorActivation.FactorActivationFx(Dummy.LeftSideAccess, ref UIS);

                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);

                Dummy.RightSideAccess = FactorActivation.FactorActivationFx(Dummy.RightSideAccess, ref UIS);

                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);
                /* try
                 {
                      Dummy.LeftSideAccess.ThreadAccess = Dummy;
                     Dummy.RightSideAccess.ThreadAccess = Dummy;
                 }
                 catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }                
      */
                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);

                Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);

                Dummy = NumberDivMul.NumberDivMulFx(Dummy, ref UIS);

                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);
                AddToTreeTreeLinkList COMMONFACTOR = FindSubFactor.FindSubFactorFx(Dummy.LeftSideAccess, Dummy.RightSideAccess);
                bool ENDLEFT = false;
                bool ENDRIGHT = false;
                AddToTree.Tree COMMONSUBFACORT = new AddToTree.Tree(null, false);

                UIS.SetProgressValue(UIS.progressBar9, INCREASE + UIS.progressBar9.Value);

                while (!((COMMONFACTOR.ISEmpty())) && ((ENDLEFT && ENDRIGHT)))
                {
                    CONTINUE = true;
                    COMMONSUBFACORT = COMMONFACTOR.DELETEFromTreeFirstNode();
                    if (!ENDLEFT)
                        Dummy.LeftSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorActionLeftSideFx(Dummy.LeftSideAccess, COMMONSUBFACORT, ref ENDLEFT, FindSubFactor.FACTORLISTEDSAccess());
                    if (!ENDRIGHT)
                        Dummy.RightSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorActionRightSideFx(Dummy.RightSideAccess, COMMONSUBFACORT, ref ENDRIGHT, FindSubFactor.NotExpectedAccess());

                    Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
                }

                UIS.SetProgressValue(UIS.progressBar9, 2147483647);

                if (!((IS.IsDivInNode(Dummy.LeftSideAccess)) || (IS.IsDivInNode(Dummy.RightSideAccess))))
                    return Dummy;

            }
            if (Dummy.LeftSideAccess != null)
                Dummy.LeftSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorCalculatorFx(Dummy.LeftSideAccess, ref CONTINUE, ref UIS);

            if (Dummy.RightSideAccess != null)
                Dummy.RightSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorCalculatorFx(Dummy.RightSideAccess, ref CONTINUE, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SimplifierCommonSubFactorActionLeftSideFx(AddToTree.Tree Dummy, AddToTree.Tree COMMONSUBFACTOR, ref bool END, AddToTreeTreeLinkList NOTFACTOR)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.SampleAccess != "*")
                if (NOTFACTOR.FINDTreeWithOutThreadConsideration(Dummy))
                    return Dummy;
            if (END)
                return Dummy;
            if ((Dummy.ThreadAccess.SampleAccess == "*") && (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, COMMONSUBFACTOR)))
            {
                Dummy.SetLefTandRightCommonlySide(null, null);
                Dummy.SampleAccess = "1";
                END = true;
            }
            else
             if ((Dummy.ThreadAccess.SampleAccess == "^") && (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.ThreadAccess.LeftSideAccess, COMMONSUBFACTOR)) && (IS.IsNumber(Dummy.ThreadAccess.RightSideAccess.SampleAccess)))
            {
                float NUM = (float)System.Convert.ToDouble(Dummy.ThreadAccess.RightSideAccess.SampleAccess);
                NUM = NUM - 1;
                if (NUM > 0)
                    Dummy.ThreadAccess.RightSideAccess.SampleAccess = NUM.ToString();
                else
                {
                    Dummy.SetLefTandRightCommonlySide(null, null);
                    Dummy.SampleAccess = "1";
                }
                END = true;
            }

            Dummy.LeftSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorActionLeftSideFx(Dummy.LeftSideAccess, COMMONSUBFACTOR, ref END, NOTFACTOR);
            Dummy.RightSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorActionLeftSideFx(Dummy.RightSideAccess, COMMONSUBFACTOR, ref END, NOTFACTOR);
            return Dummy;
        }
        static AddToTree.Tree SimplifierCommonSubFactorActionRightSideFx(AddToTree.Tree Dummy, AddToTree.Tree COMMONSUBFACTOR, ref bool END, AddToTreeTreeLinkList NOTFACTOR)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.SampleAccess != "*")
                if (NOTFACTOR.FINDTreeWithOutThreadConsideration(Dummy))
                    return Dummy;
            if (END)
                return Dummy;
            try
            {   //ERROCRECTIOn98217487 :the Last condition (Dummy.ThreadAccess.SampleAccess) is Div.
                if ((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, COMMONSUBFACTOR) && (Dummy.ThreadAccess.SampleAccess == "*") || (Dummy.ThreadAccess.SampleAccess == "/")))
                {
                    Dummy.SetLefTandRightCommonlySide(null, null);
                    Dummy.SampleAccess = "1";
                    END = true;
                }
                else
                    if ((Dummy.ThreadAccess.SampleAccess == "^") && (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, COMMONSUBFACTOR)) && (IS.IsNumber(Dummy.ThreadAccess.RightSideAccess.SampleAccess)))
                {
                    float NUM = (float)System.Convert.ToDouble(Dummy.ThreadAccess.RightSideAccess.SampleAccess);
                    NUM = NUM - 1;
                    if (NUM > 0)
                        Dummy.ThreadAccess.RightSideAccess.SampleAccess = NUM.ToString();
                    else
                    {
                        Dummy.SetLefTandRightCommonlySide(null, null);
                        Dummy.SampleAccess = "1";
                    }
                    END = true;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            Dummy.LeftSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorActionRightSideFx(Dummy.LeftSideAccess, COMMONSUBFACTOR, ref END, NOTFACTOR);
            Dummy.RightSideAccess = SimplifierCommonSubFactor.SimplifierCommonSubFactorActionRightSideFx(Dummy.RightSideAccess, COMMONSUBFACTOR, ref END, NOTFACTOR);
            return Dummy;
        }
    }
}
