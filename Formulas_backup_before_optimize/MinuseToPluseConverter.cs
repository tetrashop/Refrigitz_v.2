using System;

namespace Formulas
{
    static class MinuseToPluSeconverter
    {
        static public AddToTree.Tree MinuseToPluSeconverterFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            AddToTree.Tree THREAD = Dummy.ThreadAccess;

            Dummy.ThreadAccess = null;

            Dummy = MinuseToPluSeconverter.MinuseToPluSeconverterActionFx(Dummy);

            Dummy.ThreadAccess = THREAD;

            Dummy = NumberDivMul.NumberDivMulFx(Dummy, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree MinuseToPluSeconverterActionFx(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return null;
            try
            {
                if (Dummy.SampleAccess == "-")
                    if (Dummy.ThreadAccess.SampleAccess == "-")
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))
                        {
                            Dummy.ThreadAccess.SampleAccess = "+";
                            AddToTree.Tree CONVERT = new AddToTree.Tree("*", false);
                            AddToTree.Tree Minuse = new AddToTree.Tree("-1", false);
                            CONVERT.SetLefTandRightCommonlySide(Minuse, Dummy.CopyNewTree(Dummy.LeftSideAccess));
                            CONVERT.LeftSideAccess.ThreadAccess = CONVERT;
                            CONVERT.RightSideAccess.ThreadAccess = CONVERT;
                            CONVERT.ThreadAccess = Dummy;
                            Dummy.LeftSideAccess = CONVERT;
                        }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            MinuseToPluSeconverter.MinuseToPluSeconverterActionFx(Dummy.LeftSideAccess);
            MinuseToPluSeconverter.MinuseToPluSeconverterActionFx(Dummy.RightSideAccess);
            return Dummy;
        }
    }
}
