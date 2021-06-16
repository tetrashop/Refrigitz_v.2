//LOCATION81726487 :refer to page 265.using System;
//=====================================================
using System;

namespace Formulas
{
    static class LocalSearchMinusPlusEqualSimplifier
    {
        static public AddToTree.Tree LocalSearchMinusPlusEqualSimplifierFx(AddToTree.Tree Dummy, ref bool MINUSEPLUSEEQUAL, ref UknownIntegralSolver UIS)
        {
            return LocalSearchMinusPlusEqualSimplifier.LocalSearchMinusPlusEqualSimplifierActionFx(Dummy, ref MINUSEPLUSEEQUAL, ref UIS);
        }
        static AddToTree.Tree LocalSearchMinusPlusEqualSimplifierActionFx(AddToTree.Tree Dummy, ref bool MINUSEPLUSEEQUAL, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            bool SimplifiedTrueOtherWiseFalse = false;
            bool Suitable = false;
            bool MinuseTruePluseFalse = false;
            LocalSearchMinusPlusEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy, Dummy.LeftSideAccess, out Suitable, out MinuseTruePluseFalse, out SimplifiedTrueOtherWiseFalse);
            if (SimplifiedTrueOtherWiseFalse)
            {
                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                Dummy.LeftSideAccess.SampleAccess = null;
                MINUSEPLUSEEQUAL = true;
            }
            SimplifiedTrueOtherWiseFalse = false;
            Suitable = false;
            MinuseTruePluseFalse = false;
            LocalSearchMinusPlusEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy, Dummy.RightSideAccess, out Suitable, out MinuseTruePluseFalse, out SimplifiedTrueOtherWiseFalse);
            if (SimplifiedTrueOtherWiseFalse)
            {
                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                Dummy.RightSideAccess.SampleAccess = null;
                MINUSEPLUSEEQUAL = true;
            }
            LocalSearchMinusPlusEqualSimplifier.LocalSearchMinusPlusEqualSimplifierActionFx(Dummy.LeftSideAccess, ref MINUSEPLUSEEQUAL, ref UIS);
            LocalSearchMinusPlusEqualSimplifier.LocalSearchMinusPlusEqualSimplifierActionFx(Dummy.RightSideAccess, ref MINUSEPLUSEEQUAL, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse)
        {
            if (Dummy == null)
            {
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
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified))
                        {
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
                                      if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.ThreadAccess.SampleAccess == "+"))
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
                            }
                            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        }
                        else
                            if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.RightSideAccess) == null)
                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified))
                            {
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

                                }
                                catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                            }
                    Suitable = true;
                }
                else
                {
                    Suitable = false;
                    MinuseTruePlusFalse = false;
                    SimplifiedTrueOtherWiseFalse = false;
                    return Dummy;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse);
            LocalSearchMinusPlusEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.RightSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse)
        {
            if (Dummy == null)
            {
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
                        if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified))
                        {
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
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
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
                                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.RightSideAccess.SampleAccess = null;
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
                                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                Dummy.RightSideAccess.SampleAccess = null;
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
                            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }


                        }
                        else
                            if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.RightSideAccess) == null)
                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified))
                            {
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
                                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.RightSideAccess.SampleAccess = null;
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
                                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                    Dummy.RightSideAccess.SampleAccess = null;
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
                                catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                            }
                }
                else
                {
                    Suitable = false;
                    MinuseTruePlusFalse = false;
                    SimplifiedTrueOtherWiseFalse = false;
                    return Dummy;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMinusPlusEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.LeftSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse);
            LocalSearchMinusPlusEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, ToSimplified, out Suitable, out MinuseTruePlusFalse, out SimplifiedTrueOtherWiseFalse);
            return Dummy;
        }
    }

}
