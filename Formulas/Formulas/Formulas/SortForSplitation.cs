namespace Formulas
{
    static class SortForSplitation
    {
        static public AddToTree.Tree SortForSplitationFx(AddToTree.Tree Dummy)
        {
            if (Dummy.SampleAccess == "/")
                Dummy = SortForSplitation.SortForSplitationActionSenderFx(Dummy.LeftSideAccess, Dummy.RightSideAccess);
            return Dummy;
        }
        static AddToTree.Tree SortForSplitationActionSenderFx(AddToTree.Tree DLeft, AddToTree.Tree DRight)
        {
            return DLeft;
        }
        static AddToTree.Tree SortForSplitationActionReciverFx(AddToTree.Tree Dummy, AddToTree.Tree DummySender)
        {
            return Dummy;
        }
    }

}
