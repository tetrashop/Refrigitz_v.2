namespace Formulas
{
    static class IntegralAnswerAdding
    {
        static AddToTreeTreeLinkList Answer = new AddToTreeTreeLinkList();
        static public void IntegralAnswerAddingFx(AddToTree.Tree Dummy)
        {
            IntegralAnswerAdding.IntegralAnswerAddingActionFx(Dummy);
        }
        static void IntegralAnswerAddingActionFx(AddToTree.Tree Dummy)
        {
            Answer.CreateLinkListFromTree1(Dummy);
        }
        static public AddToTreeTreeLinkList AnswerAccess
        {
            get
            { return Answer; }
            set { Answer = value; }

        }
    }
}
