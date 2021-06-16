//LOCATION98124 : Refer to page 279.
//========================================================

namespace Formulas
{
    static class MinusPluseSorteStructure
    {
        static public AddToTree.Tree MinusPluseSorteStructureFx(AddToTree.Tree Dummy)
        {
            bool Sorted = true;
            return MinusPluseSorteStructure.MinusPluseSorteStructureActionFx(Dummy, ref Sorted);
        }
        static AddToTree.Tree MinusPluseSorteStructureActionFx(AddToTree.Tree Dummy, ref bool Sorted)
        {
            if (Dummy == null)
                return Dummy;
            if (!Sorted)
                return Dummy;
            else
            {
                //if (Dummy.ThreadAccess == null)//LOCATION98124 : Refer to page 279.
                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if (IS.IsMinuseOrPluse(Dummy.LeftSideAccess.SampleAccess))
                    {
                        AddToTree.Tree Holder = Dummy.CopyNewTree(Dummy.LeftSideAccess);
                        AddToTree.Tree Holder2 = Dummy.CopyNewTree(Dummy);
                        Dummy = Dummy.LeftSideAccess;
                        Dummy.RightSideAccess = Holder2;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy = Dummy.RightSideAccess;
                        Dummy.LeftSideAccess = Holder.RightSideAccess;
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy = Dummy.ThreadAccess;
                        Dummy.ThreadAccess = Holder.ThreadAccess;
                    }
                }
                else
                {
                    Sorted = false;
                    return Dummy;
                }

            }
            Dummy.LeftSideAccess = MinusPluseSorteStructure.MinusPluseSorteStructureActionFx(Dummy.LeftSideAccess, ref Sorted);
            Dummy.RightSideAccess = MinusPluseSorteStructure.MinusPluseSorteStructureActionFx(Dummy.RightSideAccess, ref Sorted);
            return Dummy;
        }
    }
}
