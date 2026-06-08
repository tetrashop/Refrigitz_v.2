namespace Formulas
{
    static class ReplacementX
    {
        static public AddToTree.Tree ReplacementXFx(AddToTree.Tree Dummy, AddToTree.Tree U, ref UknownIntegralSolver UIS)
        {
            Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
            return ReplacementX.ReplacementXActionFx(Dummy, U);
        }
        static AddToTree.Tree ReplacementXActionFx(AddToTree.Tree Dummy, AddToTree.Tree U)
        {
            if (Dummy == null)
                return Dummy;
            AddToTree.Tree THREAD = Dummy.CopyNewTree(Dummy.ThreadAccess);
            if (Dummy.SampleAccess != null && Dummy.SampleAccess.ToLower() == "x")
            {
                Dummy = U.CopyNewTree(U);
                Dummy.ThreadAccess = THREAD;
                return Dummy;
            }
            Dummy.LeftSideAccess = ReplacementXActionFx(Dummy.LeftSideAccess, U);
            Dummy.RightSideAccess = ReplacementXActionFx(Dummy.RightSideAccess, U);
            return Dummy;
        }
    }
}
