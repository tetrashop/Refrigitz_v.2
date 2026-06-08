//LOCATION81726487 :refer to page 265.using System;
//=====================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas
{
    static class LocalSearchMinusPlusWithNumberMulatedEqualSimplifier
    {
        static public AddToTree.Tree LocalSearchMinusPlusWithNumberMulatedEqualSimplifierFx(AddToTree.Tree Dummy)
        {
            return LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(Dummy);
        }
        static AddToTree.Tree LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            bool SimplifiedTrueOtherWiseFalse = false;
            bool Suitable = false;
            bool MinuseTruePluseFalse = false;
            float Num = 0;
            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
            {
                LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, Dummy.LeftSideAccess, ref Suitable, ref MinuseTruePluseFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
                if (SimplifiedTrueOtherWiseFalse)
                {
             if ((Dummy.ThreadAccess.ThreadAccess == null)||(Dummy.ThreadAccess.SampleAccess == "+"))
                    {
                        if (MinuseTruePluseFalse)
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess)) - Num;
                            Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                        }
                        else
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess)) + Num;
                            Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                        }
                    }
                    else
                        if (Dummy.ThreadAccess.SampleAccess == "-")
                        {
                            if (MinuseTruePluseFalse)
                            {                                                                
                                if (MinuseTruePluseFalse)
                                {
                                    Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess)*-1) - Num;                                    
                                    Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                                }
                                else
                                {
                                    Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess)) + Num;
                                    Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                                }
                    
                                Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                            }
                            else
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess)) + Num;
                                Dummy.LeftSideAccess.SampleAccess = Num.ToString();
                            }
                        }

                }
            }
            SimplifiedTrueOtherWiseFalse = false;
            Suitable = false;
            MinuseTruePluseFalse = false;
            Num = 0;
            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
            {
                LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, Dummy.RightSideAccess, ref Suitable, ref MinuseTruePluseFalse, ref SimplifiedTrueOtherWiseFalse, ref Num);
                if (SimplifiedTrueOtherWiseFalse)
                {
                    if (Dummy.SampleAccess == "+")
                    {
                        if (MinuseTruePluseFalse)
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess)) - Num;
                            Dummy.RightSideAccess.SampleAccess = Num.ToString();

                        }
                        else
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess)) + Num;
                            Dummy.RightSideAccess.SampleAccess = Num.ToString();
                        }
                    }
                    else
                    {
                        if (MinuseTruePluseFalse)
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess)*-1) - Num;
                            Dummy.RightSideAccess.SampleAccess = Num.ToString();

                        }
                        else
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess)*-1) + Num;
                            Dummy.RightSideAccess.SampleAccess = Num.ToString();
                        }
                    }
                    Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                    Dummy.RightSideAccess.SampleAccess = null;
                }
            }
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(Dummy.LeftSideAccess);
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierActionFx(Dummy.RightSideAccess);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool MinuseTruePlusFalse, ref bool SimplifiedTrueOtherWiseFalse,ref float Num)
        {
            if (Dummy == null)            
                return Dummy;            
            try
            {
                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {                    
                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, ToSimplified))
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                        {
                            Num = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);                 
                            try
                            {
                                if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
                                    MinuseTruePlusFalse = true;
                                    //LOCATION81726487 :refer to page 265.
                                    AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                    Dummy = Dummy.ThreadAccess;
                                    if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                    {
                                        Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                        Dummy.RightSideAccess.SampleAccess = null;
                                    }
                                    else
                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                        {
                                            Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                            Dummy.LeftSideAccess.SampleAccess = null;
                                        }
                                }
                                else
                                    if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.ThreadAccess.SampleAccess == "+"))
                                    {
                                        SimplifiedTrueOtherWiseFalse = true;
                                        MinuseTruePlusFalse = false;
                                        //LOCATION81987526487 :refer to page 265.
                                        AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                        Dummy = Dummy.ThreadAccess;
                                        if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                        {
                                            Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                            Dummy.RightSideAccess.SampleAccess = null;
                                        }
                                        else
                                            if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                            {
                                                Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                Dummy.LeftSideAccess.SampleAccess = null;
                                            }
                                    }
                            }
                            catch (NullReferenceException t)
                            { }
                        }
                        else
                               if (EqualToObject.IsEqual(Dummy.RightSideAccess, ToSimplified))
                               if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                               {
                                   Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);                 
                                    try
                                    {
                                        if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                                        {
                                            SimplifiedTrueOtherWiseFalse = true;
                                            MinuseTruePlusFalse = true;
                                            //LOCATION81726487 :refer to page 265.
                                            AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                            Dummy = Dummy.ThreadAccess;
                                            if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                            {
                                                Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                Dummy.RightSideAccess.SampleAccess = null;
                                            }
                                            else
                                                if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                {
                                                    Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                    Dummy.LeftSideAccess.SampleAccess = null;
                                                }
                                        }
                                        else
                                            if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                                            {
                                                SimplifiedTrueOtherWiseFalse = true;
                                                MinuseTruePlusFalse = false;
                                                //LOCATION81987526487 :refer to page 265.
                                                AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                Dummy = Dummy.ThreadAccess;
                                                if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                                {
                                                    Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                    Dummy.RightSideAccess.SampleAccess = null;
                                                }
                                                else
                                                    if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                    {
                                                        Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                        Dummy.LeftSideAccess.SampleAccess = null;
                                                    }
                                            }

                                    }
                                    catch (NullReferenceException t)
                                    { }
                                }
                    Suitable = true;
                }
                else                
                    return Dummy;                
            }
            catch (NullReferenceException t)
            { }
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse,ref Num);
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse,ref Num);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool MinuseTruePlusFalse, ref bool SimplifiedTrueOtherWiseFalse, ref float Num)
        {
            if (Dummy == null)            
                return Dummy;            
            try
            {
             if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
             {
                 
                   if (EqualToObject.IsEqual(Dummy.LeftSideAccess, ToSimplified))
                   if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                       {
                           Num = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);                 
                           try
                            {
                                if ((ToSimplified.ThreadAccess.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
                                    MinuseTruePlusFalse = true;
                                    //LOCATION81726487 :refer to page 265.
                                    AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                    Dummy = Dummy.ThreadAccess;
                                    if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                    {
                                        Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                        Dummy.RightSideAccess.SampleAccess = null;
                                    }
                                    else
                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                        {
                                            //        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                            //      Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                            Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                            Dummy.LeftSideAccess.SampleAccess = null;
                                        }
                                    Suitable = true;
                                    return Dummy;
                                }
                                else
                                    if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.ThreadAccess.SampleAccess == "-"))
                                        if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "+") && (Dummy.ThreadAccess.SampleAccess == "-"))
                                        {
                                            SimplifiedTrueOtherWiseFalse = true;
                                            MinuseTruePlusFalse = true;
                                            //LOCATION81987526487 :refer to page 265.
                                            AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                            Dummy = Dummy.ThreadAccess;
                                            if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                            {
                                                Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                Dummy.RightSideAccess.SampleAccess = null;
                                            }
                                            else
                                                if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                {
                                                    Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                    Dummy.LeftSideAccess.SampleAccess = null;
                                                }
                                            Suitable = true;
                                            return Dummy;
                                        }
                                        else
                                            if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.ThreadAccess.SampleAccess == "+"))
                                                if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "-") && (Dummy.ThreadAccess.SampleAccess == "+"))
                                                {
                                                    SimplifiedTrueOtherWiseFalse = true;
                                                    MinuseTruePlusFalse = false;
                                                    //LOCATION81987526487 :refer to page 265.
                                                    AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                    Dummy = Dummy.ThreadAccess;
                                                    if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                                    {
                                                        Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                        Dummy.RightSideAccess.SampleAccess = null;
                                                    }
                                                    else
                                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                        {
                                                            Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                            Dummy.LeftSideAccess.SampleAccess = null;
                                                        }
                                                    Suitable = true;
                                                    return Dummy;
                                                }
                            }
                            catch (NullReferenceException t)
                            { }


                        }
                        else                  
                        if (EqualToObject.IsEqual(Dummy.RightSideAccess,ToSimplified))
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    Dummy.RightSideAccess.SampleAccess = null;
                                    try
                                    {
                                        Num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                        if ((ToSimplified.ThreadAccess.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                                        {
                                            SimplifiedTrueOtherWiseFalse = true;
                                            MinuseTruePlusFalse = true;
                                            //LOCATION81726487 :refer to page 265.
                                            AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                            Dummy = Dummy.ThreadAccess;
                                            if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                            {
                                                Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                Dummy.RightSideAccess.SampleAccess = null;
                                            }
                                            else
                                                if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                {
                                                    Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                    Dummy.LeftSideAccess.SampleAccess = null;
                                                }
                                            Suitable = true;
                                            return Dummy;
                                        }
                                        else
                                            if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.SampleAccess == "-"))
                                                if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                                                {
                                                    SimplifiedTrueOtherWiseFalse = true;
                                                    MinuseTruePlusFalse = true;
                                                    //LOCATION81987526487 :refer to page 265.
                                                    AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                    Dummy = Dummy.ThreadAccess;
                                                    if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                                    {
                                                        Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                                        Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                                    }
                                                    else
                                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                        {
                                                            Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                            Dummy.LeftSideAccess.SampleAccess = null;
                                                        }
                                                    Suitable = true;
                                                    return Dummy;
                                                }
                                                else
                                                    if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.SampleAccess == "+"))
                                                        if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                                                        {
                                                            SimplifiedTrueOtherWiseFalse = true;
                                                            MinuseTruePlusFalse = false;
                                                            //LOCATION81987526487 :refer to page 265.
                                                            AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                            Dummy = Dummy.ThreadAccess;
                                                            if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                                            {
                                                                Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                                Dummy.RightSideAccess.SampleAccess = null;
                                                            }
                                                            else
                                                                if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                                {
                                                                    Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                                    Dummy.LeftSideAccess.SampleAccess = null;
                                                                }
                                                            Suitable = true;
                                                            return Dummy;
                                                        }

                                    }
                                    catch (NullReferenceException t)
                                    { }
                                }
                }
                else                
                    return Dummy;                
            }
            catch (NullReferenceException t)
            { }
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse,ref Num);
            LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref MinuseTruePlusFalse, ref SimplifiedTrueOtherWiseFalse,ref Num);
            return Dummy;
        }
    }

}
