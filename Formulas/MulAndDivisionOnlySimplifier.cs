namespace Formulas
{
    static class MulAndDivisionOnlySimplifier
    {
        static public AddToTree.Tree MulAndDivisionOnlySimplifierFx(AddToTree.Tree Dummy)
        {
            // if (MulAndDivisionOnlySimplifier.IsCurrentNodeMulOrDivisionOnly(Dummy))
            return MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFxAction(Dummy);
            //else
            //  return Dummy;
        }
        static private bool IsCurrentNodeMulOrDivisionOnly(AddToTree.Tree Dummy)
        {
            bool Is = true;
            /*    if (Dummy == null)
                    return Is;
                if ((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "/"))
                    Is = true;
                else
                    Is = false;
                Is = Is && MulAndDivisionOnlySimplifier.IsCurrentNodeMulOrDivisionOnly(Dummy.LeftSideAccess);
                Is = Is && MulAndDivisionOnlySimplifier.IsCurrentNodeMulOrDivisionOnly(Dummy.RightSideAccess);
                return Is;      
             */
            if ((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "/"))
                Is = true;
            else
                Is = false;
            return Is;
        }

        static private bool MulAndDivisionOnlySimplifierFindDivisionOperandIfIsDelettingFx(AddToTree.Tree Dummy, AddToTree.Tree NodeDeleted)
        {
            bool Is = false;
            if (Dummy == null)
                return Is;
            if (MulAndDivisionOnlySimplifier.IsCurrentNodeMulOrDivisionOnly(Dummy))
                if (!Is)
                    if (Dummy.SampleAccess == "/")
                    {
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, NodeDeleted))
                        {
                            AddToTree.Tree Num = new AddToTree.Tree("1", false);
                            Dummy.RightSideAccess = Num;
                            Dummy.RightSideAccess.LeftSideAccess = Dummy.RightSideAccess;
                            Dummy.RightSideAccess.RightSideAccess = Dummy.RightSideAccess;
                            Is = true;
                        }
                    }
            Is = Is || MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFindDivisionOperandIfIsDelettingFx(Dummy.LeftSideAccess, NodeDeleted);
            Is = Is || MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFindDivisionOperandIfIsDelettingFx(Dummy.RightSideAccess, NodeDeleted);
            return Is;
        }
        static private AddToTree.Tree MulAndDivisionOnlySimplifierFxAction(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFxAction(Dummy.LeftSideAccess);
            MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFxAction(Dummy.RightSideAccess);
            if (Dummy.SampleAccess == "*")
                if (MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFindDivisionOperandIfIsDelettingFx(Dummy.RightSideAccess, Dummy.LeftSideAccess))
                {
                    Dummy.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                    Dummy = Dummy.RightSideAccess;
                }
                else
                if (MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFindDivisionOperandIfIsDelettingFx(Dummy.LeftSideAccess, Dummy.RightSideAccess))
                {
                    Dummy.ThreadAccess = Dummy.LeftSideAccess.ThreadAccess;
                    Dummy = Dummy.LeftSideAccess;
                }
            return Dummy;
        }
    }
}
