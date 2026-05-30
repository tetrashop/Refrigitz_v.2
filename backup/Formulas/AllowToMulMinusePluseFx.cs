namespace Formulas
{
    static class AllowToMulMinusePluse
    {
        static public bool AllowToMulMinusePluseFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy.LeftSideAccess = FactorActivation.FactorActivationFx(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = FactorActivation.FactorActivationFx(Dummy.RightSideAccess, ref UIS);
            bool Is = AllowToMulMinusePluse.AllowToMulMinusePluseActionFx(Dummy);
            return Is;
        }
        static bool AllowToMulMinusePluseActionFx(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return true;
            bool Is = true;
            if (Dummy.SampleAccess == "/")
                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    AddToTreeTreeLinkList FACTOR = FindSubFactor.FindSubFactorFx(Dummy.LeftSideAccess, Dummy.RightSideAccess);
                    if (!(FACTOR.ISEmpty()))
                    {
                        AddToTree.Tree FACT = new AddToTree.Tree(null, false);
                        do
                        {
                            FACT = FACTOR.DELETEFromTreeFirstNode();
                            if (IS.IsMinuseOrPluse(FACT.SampleAccess))
                                Is = false;
                        } while (!(FACTOR.ISEmpty()));
                    }
                }
            Is = Is && (AllowToMulMinusePluse.AllowToMulMinusePluseActionFx(Dummy.LeftSideAccess));
            Is = Is && (AllowToMulMinusePluse.AllowToMulMinusePluseActionFx(Dummy.RightSideAccess));
            return Is;
        }
    }
}
