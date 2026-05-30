//LOCATION81726487 :refer to page 265.using System;
//=====================================================
using System;

namespace Formulas
{
    static class LocalSearchMinusPlusTowNumberSimplifier
    {
        static public AddToTree.Tree LocalSearchMinusPlusTowNumberSimplifierFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            return LocalSearchMinusPlusTowNumberSimplifier.LocalSearchMinusPlusTowNumberSimplifierActionFx(Dummy, ref UIS);
        }
        static AddToTree.Tree LocalSearchMinusPlusTowNumberSimplifierActionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            bool SimplifiedTrueOtherWiseFalse = false;
            bool Suitable = false;
            bool MinuseTruePluseFalse = false;
            float NUM = 0;
            try
            {
                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                {
                    LocalSearchMinusPlusTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, Dummy.LeftSideAccess, out Suitable, out MinuseTruePluseFalse, out SimplifiedTrueOtherWiseFalse, out NUM);
                    if (SimplifiedTrueOtherWiseFalse)
                    {
                        if (MinuseTruePluseFalse)
                        {
                            float NUMC = (float)System.Convert.ToDouble(Dummy.SampleAccess) - NUM;
                            if (NUMC != 0)
                                Dummy.SampleAccess = System.Convert.ToString(NUMC);
                            else
                                Dummy.SampleAccess = null;

                        }
                        else
                        {
                            float NUMC = (float)System.Convert.ToDouble(Dummy.SampleAccess) + NUM;
                            if (NUMC != 0)
                                Dummy.SampleAccess = System.Convert.ToString(NUMC);
                            else
                                Dummy.SampleAccess = null;
                        }
                    }
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            SimplifiedTrueOtherWiseFalse = false;
            Suitable = false;
            MinuseTruePluseFalse = false;
            try
            {
                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                {
                    LocalSearchMinusPlusTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy, Dummy.RightSideAccess, out Suitable, out MinuseTruePluseFalse, out SimplifiedTrueOtherWiseFalse, out NUM);
                    if (SimplifiedTrueOtherWiseFalse)
                    {
                        if (MinuseTruePluseFalse)
                            Dummy.SampleAccess = System.Convert.ToString(System.Convert.ToDouble(Dummy.SampleAccess) - NUM);
                        else
                            Dummy.SampleAccess = System.Convert.ToString(System.Convert.ToDouble(Dummy.SampleAccess) + NUM);
                    }
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }

            LocalSearchMinusPlusTowNumberSimplifier.LocalSearchMinusPlusTowNumberSimplifierActionFx(Dummy.LeftSideAccess, ref UIS);
            LocalSearchMinusPlusTowNumberSimplifier.LocalSearchMinusPlusTowNumberSimplifierActionFx(Dummy.RightSideAccess, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SetMinuseToPlusAndPluseToMinuse(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.SampleAccess == "-")
                Dummy.SampleAccess = "+";
            else
                if (Dummy.SampleAccess == "+")
                Dummy.SampleAccess = "-";
            return Dummy;
            LocalSearchMinusPlusTowNumberSimplifier.SetMinuseToPlusAndPluseToMinuse(Dummy.LeftSideAccess);
            LocalSearchMinusPlusTowNumberSimplifier.SetMinuseToPlusAndPluseToMinuse(Dummy.RightSideAccess);

        }
        /*static AddToTree.Tree OptimizeMinusePluse(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;            
            if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
            {                
                if (Dummy.SampleAccess == "-")
                {                    
                    try
                    {
                        Dummy.RightSideAccess.LeftSideAccess = LocalSearchMinusPlusTowNumberSimplifier.SetMinuseToPlusAndPluseToMinuse(Dummy.RightSideAccess.LeftSideAccess);
                        Dummy.SampleAccess = "+";
                    }
                    catch(NullReferenceException t){}
                    
                }
            }
            LocalSearchMinusPlusTowNumberSimplifier.OptimizeMinusePluse(Dummy.LeftSideAccess);
            LocalSearchMinusPlusTowNumberSimplifier.OptimizeMinusePluse(Dummy.RightSideAccess);            
            return Dummy;        
        }
        */
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse, out float Num)
        {
            if (Dummy == null)
            {
                Num = 0;
                Suitable = false;
                MinuseTruePlusFalse = false;
                SimplifiedTrueOtherWiseFalse = false;
                return Dummy;
            }
            try
            {
                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.LeftSideAccess) == null)
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
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
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                                    else
                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                    {
                                        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    }
                                }
                                else
                                    if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.ThreadAccess.SampleAccess == "+"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
                                    MinuseTruePlusFalse = false;
                                    //LOCATION81987526487 :refer to page 265.
                                    AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                    Dummy = Dummy.ThreadAccess;
                                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                    {
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                                    else
                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                    {
                                        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    }
                                }
                            }
                            catch (NullReferenceException t)
                            { ExceptionClass.ExceptionClassMethod(t); }
                        }
                        else
                            if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.RightSideAccess) == null)
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
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
                                            Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                            Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                        }
                                        else
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                        {
                                            Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                            Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
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
                                            Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                            Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                        }
                                        else
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                        {
                                            Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                            Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                        }
                                    }

                                }
                                catch (NullReferenceException t)
                                { ExceptionClass.ExceptionClassMethod(t); }
                            }
                    Suitable = true;
                }
                else
                {
                    Num = 0;
                    Suitable = false;
                    MinuseTruePlusFalse = false;
                    SimplifiedTrueOtherWiseFalse = false;
                    return Dummy;
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse, out Num);
            LocalSearchMinusPlusTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.RightSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse, out Num);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse, out float Num)
        {
            if (Dummy == null)
            {
                Num = 0;
                Suitable = false;
                MinuseTruePlusFalse = false;
                SimplifiedTrueOtherWiseFalse = false;
                return Dummy;
            }
            try
            {

                if (IS.IsMinuseOrPluse(Dummy.SampleAccess))
                {
                    if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.LeftSideAccess) == null)
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                            try
                            {
                                if ((ToSimplified.ThreadAccess.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
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
                                        //        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        //      Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                        Dummy.SetLefTandRightCommonlySide(null, null);
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
                                        AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                        Dummy = Dummy.ThreadAccess;
                                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                        {
                                            Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                            Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        }
                                        else
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                        {
                                            Dummy.SetLefTandRightCommonlySide(null, null);
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
                                            AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                            Dummy = Dummy.ThreadAccess;
                                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                            {
                                                Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                                Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                            }
                                            else
                                                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                            {
                                                Dummy.SetLefTandRightCommonlySide(null, null);
                                                Dummy.LeftSideAccess.SampleAccess = null;
                                            }
                                            Suitable = true;
                                            return Dummy;
                                        }
                            }
                            catch (NullReferenceException t)
                            { ExceptionClass.ExceptionClassMethod(t); }
                        }
                        else
                            if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.RightSideAccess) == null)
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                            {
                                Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                Dummy.RightSideAccess.SampleAccess = null;
                                try
                                {
                                    if ((ToSimplified.ThreadAccess.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                                    {
                                        SimplifiedTrueOtherWiseFalse = true;
                                        MinuseTruePlusFalse = true;
                                        //LOCATION81726487 :refer to page 265.
                                        AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
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
                                            AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
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
                                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
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
                                                Suitable = true;
                                                return Dummy;
                                            }

                                }
                                catch (NullReferenceException t)
                                { ExceptionClass.ExceptionClassMethod(t); }
                            }
                }
                else
                {
                    Num = 0;
                    Suitable = false;
                    MinuseTruePlusFalse = false;
                    SimplifiedTrueOtherWiseFalse = false;
                    return Dummy;
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.LeftSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse, out Num);
            LocalSearchMinusPlusTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse, out Num);
            return Dummy;
        }
    }

}
