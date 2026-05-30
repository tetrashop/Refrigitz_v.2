//ERRORCORECTION31754051.Refer to page 340.
//====================================================

namespace Formulas
{
    static class SplitationAllowed
    {
        static public AddToTree.Tree SplitationAllowedFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = FactorActivation.FactorActivationFx(Dummy, ref UIS);
            //bool CONTINUE=true;
            //while (CONTINUE)
            //{
            //  CONTINUE = false;
            //  Dummy = SimplifierCommonSubFactor.SimplifierCommonSubFactorCalculatorFx(Dummy, ref CONTINUE, ref UIS);
            //}
            return SplitationAllowed.SplitationAllowedAction(Dummy, ref UIS);
        }
        static AddToTree.Tree SplitationAllowedAction(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.SampleAccess == "/")
                //ERRORCORECTION31754051.Refer to page 340.
                Dummy.LeftSideAccess = SplitationAllowed.SplitationAllowedCalculator(Dummy.LeftSideAccess, Dummy.RightSideAccess, ref UIS);

            Dummy.LeftSideAccess = SplitationAllowed.SplitationAllowedAction(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = SplitationAllowed.SplitationAllowedAction(Dummy.RightSideAccess, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SplitationAllowedCalculator(AddToTree.Tree Dummy, AddToTree.Tree UNDER, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            if ((Dummy.ThreadAccess.SampleAccess == "/") || (Dummy.ThreadAccess.SampleAccess == "*"))
            {
                AddToTreeTreeLinkList ELEMENTS = FactorActivation.GetBigestCommonFactor(UNDER.CopyNewTree(UNDER), ref UIS);

                AddToTree.Tree UNDERDummy = new AddToTree.Tree(null, false);

                while (!(ELEMENTS.ISEmpty()))
                {
                    UNDERDummy = ELEMENTS.DELETEFromTreeFirstNode();
                    if ((Dummy.SampleAccess == "+") && (IS.IsPluSinNode(UNDERDummy)) && (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, UNDERDummy)))
                        Dummy.SplitableAccess = false;
                }
            }
            else
                return Dummy;
            Dummy.LeftSideAccess = SplitationAllowed.SplitationAllowedCalculator(Dummy.LeftSideAccess, UNDER, ref UIS);
            Dummy.RightSideAccess = SplitationAllowed.SplitationAllowedCalculator(Dummy.RightSideAccess, UNDER, ref UIS);
            return Dummy;
        }
    }
}
