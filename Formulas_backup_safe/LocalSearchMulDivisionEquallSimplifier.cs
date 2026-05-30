//LOCATION81726487 :refer to page 265.using System;
//=====================================================
using System;

namespace Formulas
{
    static class LocalSearchMulDivisionEqualSimplifier
    {
        static public AddToTree.Tree LocalSearchMulDivisionEqualSimplifierFx(AddToTree.Tree Dummy, ref bool MULDIVISIONEQUAL, ref UknownIntegralSolver UIS)
        {
            return LocalSearchMulDivisionEqualSimplifier.LocalSearchMulDivisionEqualSimplifierActionFx(Dummy, ref MULDIVISIONEQUAL, ref UIS);
        }
        static AddToTree.Tree LocalSearchMulDivisionEqualSimplifierActionFx(AddToTree.Tree Dummy, ref bool MULDIVISIONEQUAL, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            bool SimplifiedTrueOtherWiseFalse = false;
            bool Suitable = false;
            bool DivTrueMulFalse = false;
            LocalSearchMulDivisionEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, Dummy.LeftSideAccess, ref Suitable, ref DivTrueMulFalse, ref SimplifiedTrueOtherWiseFalse);
            if (SimplifiedTrueOtherWiseFalse)
            {
                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                Dummy.LeftSideAccess.SampleAccess = "1";
                MULDIVISIONEQUAL = true;
            }
            SimplifiedTrueOtherWiseFalse = false;
            Suitable = false;
            DivTrueMulFalse = false;
            LocalSearchMulDivisionEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, Dummy.RightSideAccess, ref Suitable, ref DivTrueMulFalse, ref SimplifiedTrueOtherWiseFalse);
            if (SimplifiedTrueOtherWiseFalse)
            {
                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                Dummy.RightSideAccess.SampleAccess = "1";
                MULDIVISIONEQUAL = true;
            }
            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
            LocalSearchMulDivisionEqualSimplifier.LocalSearchMulDivisionEqualSimplifierActionFx(Dummy.LeftSideAccess, ref MULDIVISIONEQUAL, ref UIS);
            LocalSearchMulDivisionEqualSimplifier.LocalSearchMulDivisionEqualSimplifierActionFx(Dummy.RightSideAccess, ref MULDIVISIONEQUAL, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool DivTrueMulFalse, ref bool SimplifiedTrueOtherWiseFalse)
        {
            if (Dummy == null)
                return Dummy;
            try
            {
                if (IS.IsMul(Dummy.SampleAccess))
                {
                    //if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.LeftSideAccess) == null)
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified))
                    {
                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                DivTrueMulFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                //Dummy = Dummy.ThreadAccess;
                                /*if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess,HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = "1";
                                }
                                else
                                 */
                                //if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess,HOLDER))
                                //{
                                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.LeftSideAccess.SampleAccess = "1";
                                //}
                            }
                            /*else
                            if ((ToSimplified.ThreadAccess.SampleAccess == "*") && (Dummy.ThreadAccess.SampleAccess == "/"))
                              {
                                  SimplifiedTrueOtherWiseFalse = true;
                                  DivTrueMulFalse = false;
                                  //LOCATION81987526487 :refer to page 265.
                                  AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                  //Dummy = Dummy.ThreadAccess;
                                  if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, HOLDER))
                                  {
                                      Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                      Dummy.RightSideAccess.SampleAccess = "1";
                                  }
                                  else
                                      if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, HOLDER))
                                      {
                                          Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                          Dummy.LeftSideAccess.SampleAccess = null;
                                      }


                              }*/
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    else
                            //if (Dummy.FINDTreeWithThreadConsideration(ToSimplified, Dummy.RightSideAccess) == null)                            
                            if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified))
                    {
                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                DivTrueMulFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = "1";
                                Suitable = true;
                            }

                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    Suitable = true;
                }
                else
                    return Dummy;
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMulDivisionEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref DivTrueMulFalse, ref SimplifiedTrueOtherWiseFalse);
            LocalSearchMulDivisionEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref DivTrueMulFalse, ref SimplifiedTrueOtherWiseFalse);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, ref bool Suitable, ref bool DivTrueMulFalse, ref bool SimplifiedTrueOtherWiseFalse)
        {
            if (Dummy == null)
                return Dummy;
            try
            {

                if (IS.IsMul(Dummy.SampleAccess))
                {
                    //if (Dummy.FINDTreeWithThreadConsideration(ToSimplified,Dummy.RightSideAccess) == null)
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess, ToSimplified))
                    {

                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                DivTrueMulFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = "1";
                                //}
                                Suitable = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    else
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, ToSimplified))
                    {

                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "/") && (Dummy.SampleAccess == "*"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                DivTrueMulFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
                                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.LeftSideAccess.SampleAccess = "1";
                                //}
                                Suitable = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                }
                else
                    return Dummy;
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            LocalSearchMulDivisionEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.LeftSideAccess, ToSimplified, ref Suitable, ref DivTrueMulFalse, ref SimplifiedTrueOtherWiseFalse);
            LocalSearchMulDivisionEqualSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, ToSimplified, ref Suitable, ref DivTrueMulFalse, ref SimplifiedTrueOtherWiseFalse);
            return Dummy;
        }
    }

}

