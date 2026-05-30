//LOCATION81726487 :refer to page 265.using System;
//=====================================================
using System;

namespace Formulas
{
    static class LocalSearchMinusPlusWithNumberMulatedEqualSimplifier
    {
        static public AddToTree.Tree LocalSearchMinusPlusWithNumberMulatedEqualSimplifierFx(AddToTree.Tree Dummy, ref bool MINUSEPLUSWITHNUMBERMULATED, ref UknownIntegralSolver UIS)
        {
            Dummy = MinusPluseSorteStructure.MinusPluseSorteStructureFx(Dummy);
            return LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(Dummy, ref MINUSEPLUSWITHNUMBERMULATED);
        }
        static AddToTree.Tree LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(AddToTree.Tree Dummy, ref bool MINUSEPLUSWITHNUMBERMULATED)
        {
            if (Dummy == null)
                return Dummy;
            bool SimplifiedTrueOtherWiseFalse = false;
            bool Suitable = false;
            bool MinuseTruePluseFalse = false;
            float Num = 0;
            try
            {
                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                {
                    LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, Dummy.LeftSideAccess, ref Suitable, ref MinuseTruePluseFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
                    if (SimplifiedTrueOtherWiseFalse)
                    {
                        if ((Dummy.ThreadAccess.ThreadAccess == null) || (Dummy.SampleAccess == "+"))
                        {
                            if (MinuseTruePluseFalse)
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) - Num;
                                Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;
                            }
                            else
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) + Num;
                                Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;
                            }
                        }
                        else
                            if (Dummy.SampleAccess == "-")
                        {
                            if (MinuseTruePluseFalse)
                            {
                                if (MinuseTruePluseFalse)
                                {
                                    Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess) * -1) - Num;
                                    Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                    MINUSEPLUSWITHNUMBERMULATED = true;
                                }
                                else
                                {
                                    Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) + Num;
                                    Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                    MINUSEPLUSWITHNUMBERMULATED = true;
                                }

                                //                                    Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                            }
                            else
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) + Num;
                                Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;
                            }
                        }

                    }
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            SimplifiedTrueOtherWiseFalse = false;
            Suitable = false;
            MinuseTruePluseFalse = false;
            Num = 0;
            try
            {
                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                {
                    LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, Dummy.RightSideAccess, ref Suitable, ref MinuseTruePluseFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
                    if (SimplifiedTrueOtherWiseFalse)
                    {
                        if (Dummy.SampleAccess == "+")
                        {
                            if (MinuseTruePluseFalse)
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess)) - Num;
                                Dummy.RightSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;

                            }
                            else
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess)) + Num;
                                Dummy.RightSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;
                            }
                        }
                        else
                        {
                            if (MinuseTruePluseFalse)
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess) * -1) - Num;
                                Dummy.LeftSideAccess.RightSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;
                            }
                            else
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess) * -1) + Num;
                                Dummy.RightSideAccess.LeftSideAccess.SampleAccess = Num.ToString();
                                MINUSEPLUSWITHNUMBERMULATED = true;
                            }
                        }
                        //Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                        //Dummy.RightSideAccess.SampleAccess = null;
                    }
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(Dummy.LeftSideAccess, ref MINUSEPLUSWITHNUMBERMULATED);
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(Dummy.RightSideAccess, ref MINUSEPLUSWITHNUMBERMULATED);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool MinuseTruePlusFalse, ref bool SimplifiedTrueOtherWiseFalse, ref float Num)
        {
            if (Dummy == null)
                return Dummy;
            try
            {
                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if ((EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified.RightSideAccess)) & (IS.IsNumber(Dummy.RightSideAccess.SampleAccess)))
                    {
                        Num = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                {
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                }
                            }
                            else
                                if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = false;
                                //LOCATION81987526487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                {
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                }
                            }
                            else
                                    if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                //LOCATION81987526487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                {
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                }
                            }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    else
                    if ((EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified.RightSideAccess)) & (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess)))
                    {
                        Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                {
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                }
                            }
                            else
                                if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = false;
                                //LOCATION81987526487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                {
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                }
                            }
                            else
                                    if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                //LOCATION81987526487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                {
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                }
                            }

                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    Suitable = true;
                }
                else
                    return Dummy;
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool MinuseTruePlusFalse, ref bool SimplifiedTrueOtherWiseFalse, ref float Num)
        {
            if (Dummy == null)
                return Dummy;
            AddToTree.Tree HOLDERCATCH = Dummy;
            try
            {
                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if ((EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, ToSimplified.RightSideAccess)) && (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)))
                    {
                        try
                        {
                            Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                            //Dummy = Dummy.LeftSideAccess.RightSideAccess;                               
                            if ((ToSimplified.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.LeftSideAccess.SampleAccess = null;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                /*Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                    {
                                        //        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        //      Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.LeftSideAccess.SampleAccess = null;
                                    }
                                 */
                                Suitable = true;
                                return Dummy;
                            }
                            else
                                if ((ToSimplified.ThreadAccess != null) && (Dummy.SampleAccess == "-"))
                                if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
                                    MinuseTruePlusFalse = true;
                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.SampleAccess = null;
                                    //LOCATION81987526487 :refer to page 265.
                                    /*        AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                            Dummy = Dummy.ThreadAccess;
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                            {
                                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                Dummy.RightSideAccess.SampleAccess = null;
                                            }
                                            else
                                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                                {
                                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                    Dummy.LeftSideAccess.SampleAccess = null;
                                                }
                                     */
                                    Suitable = true;
                                    return Dummy;
                                }
                                else
                                    if ((ToSimplified.ThreadAccess != null) && (Dummy.SampleAccess == "+"))
                                    if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                                    {
                                        SimplifiedTrueOtherWiseFalse = true;
                                        MinuseTruePlusFalse = false;
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.LeftSideAccess.SampleAccess = null;
                                        //LOCATION81987526487 :refer to page 265.
                                        /*AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                        Dummy = Dummy.ThreadAccess;
                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                        {
                                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.RightSideAccess.SampleAccess = null;
                                        }
                                        else
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                            {
                                                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                Dummy.LeftSideAccess.SampleAccess = null;
                                            }
                                         */
                                        Suitable = true;
                                        return Dummy;
                                    }
                                    else
                                        if ((ToSimplified.ThreadAccess != null) && (Dummy.SampleAccess == "-"))
                                        if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "-"))
                                        {
                                            SimplifiedTrueOtherWiseFalse = true;
                                            MinuseTruePlusFalse = true;
                                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.LeftSideAccess.SampleAccess = null;
                                            //LOCATION81987526487 :refer to page 265.
                                            /*        AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                                    Dummy = Dummy.ThreadAccess;
                                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                                    {
                                                        Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.RightSideAccess.SampleAccess = null;
                                                    }
                                                    else
                                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                                        {
                                                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                            Dummy.LeftSideAccess.SampleAccess = null;
                                                        }
                                             */
                                            Suitable = true;
                                            return Dummy;
                                        }
                        }
                        /*if (SimplifiedTrueOtherWiseFalse)
                            Dummy = Dummy.ThreadAccess;
                        else
                            Dummy = Dummy.ThreadAccess.ThreadAccess;
                           }
                         */
                        catch (NullReferenceException t)
                        {
                            Dummy = HOLDERCATCH;
                            ExceptionClass.ExceptionClassMethod(t);
                        }
                    }
                    else
                         if ((EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess.RightSideAccess, ToSimplified.RightSideAccess)) & (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess)))
                    {
                        //Dummy.RightSideAccess.SampleAccess = null;
                        try
                        {

                            Num = (float)System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                            //Dummy = Dummy.RightSideAccess.RightSideAccess;
                            if ((ToSimplified.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = null;
                                //LOCATION81726487 :refer to page 265.
                                /*AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                    {
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.LeftSideAccess.SampleAccess = null;
                                    }
                                 */
                                Suitable = true;
                                return Dummy;
                            }
                            else
                                            if ((((ToSimplified.ThreadAccess != null))) && (ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                //LOCATION81987526487 :refer to page 265.
                                /*        AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                        Dummy = Dummy.ThreadAccess;
                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                        {
                                            Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                            Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                        }
                                        else
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                            {
                                                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                Dummy.LeftSideAccess.SampleAccess = null;
                                            }
                                 */
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = null;
                                Suitable = true;
                                return Dummy;
                            }
                            else
                                                  if ((((ToSimplified.ThreadAccess != null))) && (ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = false;
                                //LOCATION81987526487 :refer to page 265.
                                /*                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                                Dummy = Dummy.ThreadAccess;
                                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                                {
                                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                    Dummy.RightSideAccess.SampleAccess = null;
                                                }
                                                else
                                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                                    {
                                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.LeftSideAccess.SampleAccess = null;
                                                    }
                                 */
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = null;
                                Suitable = true;
                                return Dummy;
                            }
                            else

                                                            if ((((ToSimplified.ThreadAccess != null))) && (ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                MinuseTruePlusFalse = true;
                                //LOCATION81987526487 :refer to page 265.
                                /*AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = null;
                                }
                                else
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                    {
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.LeftSideAccess.SampleAccess = null;
                                    }
                                */
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = null;
                                Suitable = true;
                                return Dummy;
                            }
                            /*if (SimplifiedTrueOtherWiseFalse)
                                Dummy = Dummy.ThreadAccess;
                            else
                                Dummy = Dummy.ThreadAccess.ThreadAccess;
                             */
                        }
                        catch (NullReferenceException t)
                        {
                            ExceptionClass.ExceptionClassMethod(t);
                            Dummy = HOLDERCATCH;
                        }
                    }
                }
                else
                    return Dummy;
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
            return Dummy;
        }
    }
}
