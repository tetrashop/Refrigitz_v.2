namespace Formulas
{
    static class RecursiveIntegralAddition
    {
        static public AddToTree.Tree RecursiveIntegralAdditionFx(AddToTree.Tree Node, AddToTree.Tree Dummy, AddToTree.Tree MULTOW, float Queficient, AddToTreeTreeLinkList INTEGRALS, AddToTreeTreeLinkList ANSWER)
        {
            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(MULTOW, Node))
                Dummy = RecursiveIntegralAddition.RecursiveIntegralFxAdditionForLinearEquationOneDegrees(Node, Dummy, Queficient);
            return Dummy;
        }
        static private AddToTree.Tree RecursiveIntegralFxAdditionForLinearEquationOneDegrees(AddToTree.Tree Node, AddToTree.Tree Dummy, float Queficient)
        {
            if (Node == null || Node.LeftSideAccess == null)
                return null;
            if (Queficient != 0)
            {
                AddToTree.Tree NUM = new AddToTree.Tree(Queficient.ToString(), false);
                AddToTree.Tree Copy = new AddToTree.Tree("/", false);

                float NUMCopy = 0;

                if (IS.IsNumber(Node.LeftSideAccess.SampleAccess))
                {

                    if (Node.SampleAccess == "*")
                        NUMCopy = (float)System.Convert.ToDouble(Node.LeftSideAccess.SampleAccess);
                    else
                        NUMCopy = 1;
                    //ERROR198274897234 :The Queficient must subtract to num.refer to page 221.
                    NUMCopy = NUMCopy - Queficient;
                }
                else
                    if (IS.IsNumber(Node.RightSideAccess.SampleAccess))
                {
                    //ERRORCORECTION9827438 :Invalid Number detection.refer to page 223.
                    if (Node.SampleAccess == "*")
                        NUMCopy = (float)System.Convert.ToDouble(Node.RightSideAccess.SampleAccess);
                    else
                        NUMCopy = 1;
                    //ERROR198274897234 :The Queficient must subtract to num.refer to page 221.
                    NUMCopy = NUMCopy - Queficient;
                }
                NUM.SampleAccess = System.Convert.ToString(NUMCopy);
                Copy.SetLefTandRightCommonlySide(Dummy, NUM);
                Copy.LeftSideAccess.ThreadAccess = Copy;
                Copy.RightSideAccess.ThreadAccess = Copy;
                //ERRORCORRECTION872318712 :The Dummy has no ay effect.refer to page 218.
                Dummy = Copy;
            }
            return Dummy;
        }
    }
}
