//LOCATION81726487 :refer to page 265.using System;
//=====================================================
//ERRORCORECTION13175402 :Considerable.refer to page 288.
//=====================================================
//ERRORCORECTION19862348761 :Refer to page 288.
//=====================================================
//ERRORCORECTION9812737 Private state for Page 292.
//=====================================================
//ERRORCORECTION1274 :Refer to page 292.
//=====================================================
using System;

namespace Formulas
{
    static class LocalSearchMulDivionWithNumberMulatedEqualSimplifier
    {
        static public AddToTree.Tree LocalSearchMulDivionWithNumberMulatedEqualSimplifierFx(AddToTree.Tree Dummy, ref bool MULDIVISIONWITHNUMBERMULATED, ref UknownIntegralSolver UIS)
        {
            //Dummy = MulDivioneSorteStructure.MulDivioneSorteStructureFx(Dummy);
            return LocalSearchMulDivionWithNumberMulatedEqualSimplifier.LocalSearchMulDivionWithNumberMulatedEqualSimplifierActionFx(Dummy, ref MULDIVISIONWITHNUMBERMULATED, ref UIS);
        }
        static AddToTree.Tree LocalSearchMulDivionWithNumberMulatedEqualSimplifierActionFx(AddToTree.Tree Dummy, ref bool MULDIVISIONWITHNUMBERMULATED, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            bool SimplifiedTrueOtherWiseFalse = false;
            bool Suitable = false;
            bool MulTrueDivFalse = false;
            bool RETURNED = false;

            float Num = 0;
            try
            {
                if (Dummy.RightSideAccess.SampleAccess == "/")
                {//ERRORCORECTION19862348761 :Refer to page 288.
                    LocalSearchMulDivionWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatDivIsLocatedAtUp(Dummy.LeftSideAccess, Dummy.RightSideAccess, ref Suitable, ref MulTrueDivFalse, ref SimplifiedTrueOtherWiseFalse, ref Num, ref RETURNED);
                    if (SimplifiedTrueOtherWiseFalse)
                    {
                        Dummy = Dummy.RightSideAccess;
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                        {
                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.RightSideAccess.SampleAccess = "1";
                            Num = Num * (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                            if (Num == 0)
                                Dummy.LeftSideAccess.SampleAccess = null;
                            else
                                Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                            MULDIVISIONWITHNUMBERMULATED = true;
                        }
                        /*else
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                            {
                                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.LeftSideAccess.SampleAccess = "1";
                                Num = Num / (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                if (Num == 0)
                                    Dummy.RightSideAccess.SampleAccess = null;
                                else
                                    Dummy.RightSideAccess.SampleAccess = Num.ToString();
                            }
                            else
                            {
                                Dummy.SetLefTandRightCommonlySide(null, null);
                                if (Num == 0)
                                    Dummy.SampleAccess = null;
                                else
                                    Dummy.SampleAccess = Num.ToString();
                            }
                         */
                    }
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

            if (SimplifiedTrueOtherWiseFalse)
            {
                Dummy = Dummy.ThreadAccess;
                AddToTree.Tree HOLDERTHRED = Dummy.ThreadAccess;
                Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
                Dummy.ThreadAccess = HOLDERTHRED;
            }
            SimplifiedTrueOtherWiseFalse = false;
            Suitable = false;
            MulTrueDivFalse = false;
            Num = 0;
            RETURNED = false;
            try
            {
                if (Dummy.LeftSideAccess.SampleAccess == "*")
                {
                    LocalSearchMulDivionWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatDivIsLocatedAtDown(Dummy.RightSideAccess, Dummy.LeftSideAccess, ref Suitable, ref MulTrueDivFalse, ref SimplifiedTrueOtherWiseFalse, ref Num, ref RETURNED);
                    if (SimplifiedTrueOtherWiseFalse)
                    {//ERRORCORECTION1274 :Refer to page 292.
                        Dummy = Dummy.LeftSideAccess;
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                        {
                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.LeftSideAccess.SampleAccess = "1";
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess)) / Num;
                            if (Num == 0)
                                Dummy.RightSideAccess.SampleAccess = null;
                            else
                                Dummy.RightSideAccess.SampleAccess = Num.ToString();
                            MULDIVISIONWITHNUMBERMULATED = true;
                        }
                        else
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                        {
                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.RightSideAccess.SampleAccess = "1";
                            Num = Num * (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                            if (Num == 0)
                                Dummy.LeftSideAccess.SampleAccess = null;
                            else
                                Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                            MULDIVISIONWITHNUMBERMULATED = true;
                        }
                        else
                        {
                            Dummy.SetLefTandRightCommonlySide(null, null);
                            if (Num == 0)
                                Dummy.SampleAccess = null;
                            else
                                Dummy.SampleAccess = Num.ToString();
                            MULDIVISIONWITHNUMBERMULATED = true;
                        }
                    }
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

            if (SimplifiedTrueOtherWiseFalse)
            {
                Dummy = Dummy.ThreadAccess;
                AddToTree.Tree HOLDERTHRED = Dummy.ThreadAccess;
                Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
                Dummy.ThreadAccess = HOLDERTHRED;
            }

            LocalSearchMulDivionWithNumberMulatedEqualSimplifier.LocalSearchMulDivionWithNumberMulatedEqualSimplifierActionFx(Dummy.LeftSideAccess, ref MULDIVISIONWITHNUMBERMULATED, ref UIS);
            LocalSearchMulDivionWithNumberMulatedEqualSimplifier.LocalSearchMulDivionWithNumberMulatedEqualSimplifierActionFx(Dummy.RightSideAccess, ref MULDIVISIONWITHNUMBERMULATED, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatDivIsLocatedAtDown(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool MulTrueDivFalse, ref bool SimplifiedTrueOtherWiseFalse, ref float Num, ref bool RETURNED)
        {
            if (Dummy == null)
                return Dummy;
            if (RETURNED)
                return Dummy;
            try
            {
                if (IS.IsMul(Dummy.SampleAccess)) { }
                else
                    if (IS.IsDiv(Dummy.SampleAccess))
                {
                    if ((EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified.RightSideAccess)) && (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess)))
                    {
                        Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                        try
                        {
                            if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "*") && (Dummy.SampleAccess == "/"))
                            {
                                RETURNED = true;
                                SimplifiedTrueOtherWiseFalse = true;
                                MulTrueDivFalse = false;
                                Dummy.SetLefTandRightCommonlySide(null, null);
                                Dummy.SampleAccess = "1";
                            }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        Suitable = true;
                    }
                    else
                        if ((EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess.LeftSideAccess, ToSimplified.RightSideAccess)) && (IS.IsMul(Dummy.RightSideAccess.SampleAccess) && (Dummy.SampleAccess == "/")))
                    {//ERRORCORECTION9812737 Private state for Page 292.                     
                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "*"))
                            {
                                RETURNED = true;
                                SimplifiedTrueOtherWiseFalse = true;
                                MulTrueDivFalse = false;
                                Dummy.RightSideAccess.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.LeftSideAccess.SampleAccess = "1";
                                Num = 1;
                            }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    else
                    {
                        Suitable = false;
                        return Dummy;
                    }
                }
                else
                {
                    RETURNED = true;
                    return Dummy;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMulDivionWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatDivIsLocatedAtDown(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref MulTrueDivFalse, ref SimplifiedTrueOtherWiseFalse, ref Num, ref RETURNED);
            LocalSearchMulDivionWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatDivIsLocatedAtDown(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref MulTrueDivFalse, ref SimplifiedTrueOtherWiseFalse, ref Num, ref RETURNED);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatDivIsLocatedAtUp(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool MulTrueDivFalse, ref bool SimplifiedTrueOtherWiseFalse, ref float Num, ref bool RETURNED)
        {
            if (Dummy == null)
                return Dummy;
            if (RETURNED)
                return Dummy;
            try
            {
                if (IS.IsMul(Dummy.SampleAccess))
                {
                    //if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified))
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified.RightSideAccess))
                    {
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                        {
                            Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                            try
                            {
                                if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                                {
                                    RETURNED = true;
                                    SimplifiedTrueOtherWiseFalse = true;
                                    MulTrueDivFalse = true;
                                    Dummy.SetLefTandRightCommonlySide(null, null);
                                    Dummy.SampleAccess = "1";
                                    Suitable = true;
                                    return Dummy;
                                }
                            }
                            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        }
                        /*else
                        {  //ERRORCORECTION13175402 :Considerable.
                            RETURNED = true;
                            SimplifiedTrueOtherWiseFalse = true;
                            MulTrueDivFalse = true;
                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.RightSideAccess.SampleAccess = "1";
                            Suitable = true;
                            Num = 1;
                            return Dummy;
                        }
                         */
                    }
                    else
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified.RightSideAccess))
                    {
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                        {
                            Num = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                            try
                            {
                                if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "/") && (Dummy.ThreadAccess.SampleAccess == "*"))
                                {
                                    RETURNED = true;
                                    SimplifiedTrueOtherWiseFalse = true;
                                    MulTrueDivFalse = true;
                                    Dummy.SetLefTandRightCommonlySide(null, null);
                                    Dummy.SampleAccess = "1";
                                    Suitable = true;
                                    return Dummy;
                                }
                            }
                            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        }
                        /*else
                        {//ERRORCORECTION13175402 :Considerable.
                            SimplifiedTrueOtherWiseFalse = true;
                            MulTrueDivFalse = true;
                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.LeftSideAccess.SampleAccess = "1";
                            Suitable = true;
                            Num = 1;
                            return Dummy;
                        }*/

                    }
                }
                else
                {
                    RETURNED = true;
                    return Dummy;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMulDivionWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatDivIsLocatedAtUp(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref MulTrueDivFalse, ref SimplifiedTrueOtherWiseFalse, ref Num, ref RETURNED);
            LocalSearchMulDivionWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatDivIsLocatedAtUp(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref MulTrueDivFalse, ref SimplifiedTrueOtherWiseFalse, ref Num, ref RETURNED);
            return Dummy;
        }
    }

}
