//ERRORCORECTION981273 :The Error corrected.refer to page 218.
//=============================================================
//ADDCONDITION18979714 :Refer to page 248.
//=============================================================
using System;

namespace Formulas
{
    static class NumberDivMul
    {
        static public AddToTree.Tree NumberDivMulFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            try
            {
                AddToTree.Tree THREAD = Dummy.CopyNewTree(Dummy.ThreadAccess);
                Dummy.ThreadAccess = null;

                Dummy = NumberDivMul.NumberDivMulFxAction(Dummy, ref UIS);

                while (Dummy.ThreadAccess != null)
                    Dummy = Dummy.ThreadAccess;

                Dummy.ThreadAccess = THREAD;
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
        static AddToTree.Tree NumberDivMulFxAction(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            Dummy.LeftSideAccess = NumberDivMul.NumberDivMulFxAction(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = NumberDivMul.NumberDivMulFxAction(Dummy.RightSideAccess, ref UIS);
            int INCREASE = 2147483647 / 6;
            try
            {
                UIS.SetProgressValue(UIS.progressBar15, 0);

                if (IS.IsMul(Dummy.SampleAccess))
                    if (IS.IsMul(Dummy.RightSideAccess.SampleAccess))
                        if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                            {
                                Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                            }
                UIS.SetProgressValue(UIS.progressBar15, INCREASE + UIS.progressBar15.Value);
                if (IS.IsDiv(Dummy.SampleAccess))
                    if (IS.IsMul(Dummy.LeftSideAccess.SampleAccess))
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                            if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                            {
                                //ERRORCORECTION981273 :The Error corrected.refer to page218.
                                float Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                Num = Num / (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                                Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                Dummy = Dummy.LeftSideAccess;

                            }
                UIS.SetProgressValue(UIS.progressBar15, INCREASE + UIS.progressBar15.Value);
                if (IS.IsMul(Dummy.SampleAccess))
                    if (IS.IsMul(Dummy.RightSideAccess.SampleAccess))
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                            if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                            {

                                //ERRORCORECTION981273 :The Error corrected.refer to page218.
                                if (Dummy.LeftSideAccess.SampleAccess.ToLower() != "c")
                                    if (Dummy.RightSideAccess.SampleAccess.ToLower() != "c")
                                    {
                                        float Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                        Num = Num * (float)System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                                        Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                                    else
                                        Dummy.LeftSideAccess.SampleAccess = "C";


                            }
                UIS.SetProgressValue(UIS.progressBar15, INCREASE + UIS.progressBar15.Value);
                if (IS.IsDiv(Dummy.SampleAccess))
                    if (IS.IsMul(Dummy.LeftSideAccess.SampleAccess))
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                            if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                            {
                                //ERRORCORECTION981273 :The Error corrected.refer to page218.
                                float Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                Num = Num / (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                                Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                Dummy = Dummy.LeftSideAccess;
                            }
                UIS.SetProgressValue(UIS.progressBar15, INCREASE + UIS.progressBar15.Value);
                //ADDCONDITION18979714 :Refer to page 248.
                if (Dummy.SampleAccess == "/")
                    if (Dummy.LeftSideAccess.SampleAccess == "*")
                        if (Dummy.RightSideAccess.SampleAccess == "*")
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                {
                                    if ((Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() != "c") && ((Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() != "c")))
                                    {

                                        float Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                        Num = Num / (float)System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                                        Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();

                                    }
                                    else
                                        Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = "C";
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                }
                        }
                UIS.SetProgressValue(UIS.progressBar15, INCREASE + UIS.progressBar15.Value);
                if (Dummy.SampleAccess == "*")
                    if (Dummy.LeftSideAccess.SampleAccess == "*")
                        if (Dummy.RightSideAccess.SampleAccess == "*")
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                {
                                    if ((Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() != "c") && ((Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() != "c")))
                                    {

                                        float Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                        Num = Num * (float)System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                                        Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();

                                    }
                                    else
                                        Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = "C";
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                }
                        }

            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            UIS.SetProgressValue(UIS.progressBar15, 2147483647);
            return Dummy;

        }
    }
}
