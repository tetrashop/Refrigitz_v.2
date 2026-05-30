//ERROR31754015 :Refer to page 338.
//=====================================================
using System;

namespace Formulas
{
    static class ConvertAllMinuseToPluse
    {
        static public AddToTree.Tree ConvertAllMinuseToPluseFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = ConvertAllMinuseToPluse.ConvertAllMinuseToPluseActionFx(Dummy, ref UIS);
            //ERROR31754015 :Refer to page 338.
            Dummy = NumberDivMul.NumberDivMulFx(Dummy, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree ConvertAllMinuseToPluseActionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            int INCREASE = 2147483647 / 3;
            bool SecOND = true;
            try
            {

                UIS.SetProgressValue(UIS.progressBar5, 0);

                if ((Dummy.ThreadAccess.SampleAccess == "-") && (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy)))
                {
                    AddToTree.Tree ONE = new AddToTree.Tree("-1", false);
                    AddToTree.Tree ADD = new AddToTree.Tree("*", false);
                    //Dummy = Dummy.LeftSideAccess;
                    ADD.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess), ONE);
                    ADD.LeftSideAccess.ThreadAccess = ADD;
                    ADD.RightSideAccess.ThreadAccess = ADD;
                    Dummy = Dummy.ThreadAccess;
                    Dummy.SampleAccess = "+";
                    Dummy.LeftSideAccess = ADD;
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    SecOND = false;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            UIS.SetProgressValue(UIS.progressBar5, INCREASE + UIS.progressBar5.Value);

            try
            {
                if ((Dummy.SampleAccess == "-") && (SecOND))
                {
                    AddToTree.Tree ONE = new AddToTree.Tree("-1", false);
                    AddToTree.Tree ADD = new AddToTree.Tree("*", false);
                    ADD.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess), ONE);
                    ADD.LeftSideAccess.ThreadAccess = ADD;
                    ADD.RightSideAccess.ThreadAccess = ADD;
                    Dummy.SampleAccess = "+";
                    Dummy.RightSideAccess = ADD;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            UIS.SetProgressValue(UIS.progressBar5, 2147483647);
            Dummy.LeftSideAccess = ConvertAllMinuseToPluse.ConvertAllMinuseToPluseActionFx(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = ConvertAllMinuseToPluse.ConvertAllMinuseToPluseActionFx(Dummy.RightSideAccess, ref UIS);
            return Dummy;
        }
    }
}
