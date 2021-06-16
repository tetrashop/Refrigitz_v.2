using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas
{
    static class LocalSearchMulDivisionMulatedTowNumberSimplifier
    {
        static public AddToTree.Tree LocalSearchMulDivisionPowerTowNumberSimplifierFx(AddToTree.Tree Dummy)        
        {
            return LocalSearchMulDivisionMulatedTowNumberSimplifier.LocalSearchMulDivisionPowerTowNumberSimplifierActionFx(Dummy);
        }
        static AddToTree.Tree LocalSearchMulDivisionPowerTowNumberSimplifierActionFx(AddToTree.Tree Dummy)        
        {
               if(Dummy==null)
                  return Dummy;
               bool SimplifiedTrueOtherWiseFalse = false;
               bool Suitable = false;
               bool ISC = false;
               float NUM = 0;
               try
               {
                   if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                   {
                       LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy, Dummy.LeftSideAccess, out Suitable, out SimplifiedTrueOtherWiseFalse, out NUM,out ISC);
                       if (SimplifiedTrueOtherWiseFalse && (!ISC))
                       {
                           
                           float NUMC = (float)System.Convert.ToDouble(Dummy.SampleAccess) * NUM;
                           if (NUMC != 0)
                               Dummy.LeftSideAccess.SampleAccess = System.Convert.ToString(NUMC);
                           else
                               Dummy.LeftSideAccess.SampleAccess = null;
                       }
                       else
                           if (ISC)
                               Dummy.LeftSideAccess.SampleAccess = "C";
                   }
                   else
                       if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                       {
                           LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy, Dummy.LeftSideAccess, out Suitable, out SimplifiedTrueOtherWiseFalse, out NUM, out ISC);
                           if (SimplifiedTrueOtherWiseFalse)
                               Dummy.LeftSideAccess.SampleAccess = "C";
                       }
               }
               catch (NullReferenceException t)
               { }            
               SimplifiedTrueOtherWiseFalse = false;
               Suitable = false;
               ISC = false;
               try
               {
                   if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                   {
                       LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy, Dummy.RightSideAccess, out Suitable, out SimplifiedTrueOtherWiseFalse, out NUM,out ISC);
                       if (SimplifiedTrueOtherWiseFalse&&(!ISC))
                       {
                           float NUMC = (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess) * NUM;
                           if (NUMC != 0)
                               Dummy.RightSideAccess.SampleAccess = System.Convert.ToString(NUMC);
                           else
                               Dummy.RightSideAccess.SampleAccess = null;
                       }
                       else
                       if (ISC)
                       Dummy.RightSideAccess.SampleAccess = "C";
                   }
                   else
                       if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                       {
                           LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy, Dummy.LeftSideAccess, out Suitable, out SimplifiedTrueOtherWiseFalse, out NUM, out ISC);
                           if (SimplifiedTrueOtherWiseFalse)
                               Dummy.RightSideAccess.SampleAccess = "C";
                       }              
               }
               catch (NullReferenceException t)
               { }            
               LocalSearchMulDivisionMulatedTowNumberSimplifier.LocalSearchMulDivisionPowerTowNumberSimplifierActionFx(Dummy.LeftSideAccess);
               LocalSearchMulDivisionMulatedTowNumberSimplifier.LocalSearchMulDivisionPowerTowNumberSimplifierActionFx(Dummy.RightSideAccess);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool SimplifiedTrueOtherWiseFalse, out float Num,out bool  ISC)
        {
            if (Dummy == null)
            {
                Num = 0;
                Suitable = false;
                SimplifiedTrueOtherWiseFalse = false;
                ISC = false;
                return Dummy;
            }
            try
            {
                if (IS.IsMul(Dummy.SampleAccess))
                {
                    if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                    {
                        Dummy.LeftSideAccess.SampleAccess = "1";
                        SimplifiedTrueOtherWiseFalse = true;
                        Suitable = true;
                        ISC = true;
                        Num = 0;
                        return Dummy;
                    }
                    else
                        if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                        {
                            Dummy.RightSideAccess.SampleAccess = "1";
                            SimplifiedTrueOtherWiseFalse = true;
                            Suitable = true;
                            ISC = true;
                            Num = 0;
                            return Dummy;
                        }
                    else
                    if (Dummy.FindTree(ToSimplified, Dummy.LeftSideAccess) == null)
                    if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                    {
                        Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                        try
                        {
                            if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                }
                                else
                                    if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                    {
                                        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    }
                            }
                              else                              
                                  if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.ThreadAccess.SampleAccess == "+"))
                                            {
                                                SimplifiedTrueOtherWiseFalse = true;
                                                //LOCATION81987526487 :refer to page 265.
                                                AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                Dummy = Dummy.ThreadAccess;
                                                if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                                {
                                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                                }
                                                else
                                                    if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                    {
                                                        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                                        Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                                    }
                                            }
                        }
                        catch (NullReferenceException t)
                        { }
                    }
                    else
                        if (Dummy.FindTree(ToSimplified, Dummy.RightSideAccess) == null)
                        if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                            try
                            {
                                if ((ToSimplified.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
                                    //LOCATION81726487 :refer to page 265.
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
                                            Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                            Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                        }
                                }
                                else
                                if ((ToSimplified.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
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
                                                            Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                                            Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                                        }
                                                }

                            }
                            catch (NullReferenceException t)
                            { }
                        }
                    Suitable = true;
                }
                else
                {
                    Num = 0;
                    Suitable = false;
                    SimplifiedTrueOtherWiseFalse = false;
                    ISC = false;
                    return Dummy;
                }
            }
            catch (NullReferenceException t)
            { }
            LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.LeftSideAccess, ToSimplified, out Suitable, out SimplifiedTrueOtherWiseFalse, out Num,out ISC);
            LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(Dummy.RightSideAccess, ToSimplified, out Suitable, out SimplifiedTrueOtherWiseFalse, out Num,out ISC);
            return Dummy;
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool SimplifiedTrueOtherWiseFalse, out float Num,out bool ISC)
        {
            if (Dummy == null)
            {
                Num = 0;
                Suitable = false;
                SimplifiedTrueOtherWiseFalse = false;
                ISC = false;
                return Dummy;
            }            
            try
            {
                
                if (IS.IsMul(Dummy.SampleAccess))
                {
                    if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                    {
                        Dummy.LeftSideAccess.SampleAccess = "1";
                        SimplifiedTrueOtherWiseFalse = true;
                        Suitable = true;
                        ISC = true;
                        Num = 0;
                        return Dummy;
                    }
                    else
                    if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                    {
                    Dummy.RightSideAccess.SampleAccess = "1";
                    SimplifiedTrueOtherWiseFalse = true;
                    Suitable = true;
                    ISC = true;
                    Num = 0;
                    return Dummy;
                    }
                    else
                    if (Dummy.FindTree(ToSimplified, Dummy.LeftSideAccess) == null)
                    if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))                    
                    {
                        Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                        try
                        {
                            if ((ToSimplified.ThreadAccess.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                            {
                                SimplifiedTrueOtherWiseFalse = true;
                                //LOCATION81726487 :refer to page 265.
                                AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                Dummy = Dummy.ThreadAccess;
                                if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                {
                                    Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                    Dummy.RightSideAccess.SampleAccess = "1";
                                }
                                else
                                    if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                    {
                                //        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                  //      Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                        Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                        Dummy.RightSideAccess.SampleAccess = "1";
                                    }
                                Suitable = true;
                                ISC = false;
                                return Dummy;
                            }
                            else
                                if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.ThreadAccess.SampleAccess == "-"))
                                    if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "+") && (Dummy.ThreadAccess.SampleAccess == "-"))
                                    {
                                        SimplifiedTrueOtherWiseFalse = true;
                                        //LOCATION81987526487 :refer to page 265.
                                        AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                        Dummy = Dummy.ThreadAccess;
                                        if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                        {
                                            Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                            Dummy.RightSideAccess.SampleAccess = "1";
                                        }
                                        else
                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                           {
                                               Dummy.SetLeftAndRightSide(null, null);
                                               Dummy.LeftSideAccess.SampleAccess = "1";
                                           }
                                       Suitable = true;
                                       ISC = false;
                                       return Dummy;
                                    }
                                    else
                                        if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.ThreadAccess.SampleAccess == "+"))
                                            if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "-") && (Dummy.ThreadAccess.SampleAccess == "+"))
                                            {
                                                SimplifiedTrueOtherWiseFalse = true;
                                                //LOCATION81987526487 :refer to page 265.
                                                AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                Dummy = Dummy.ThreadAccess;
                                                if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                                {
                                                    Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                    Dummy.RightSideAccess.SampleAccess = "1";
                                                }
                                                else
                                                if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                    {
                                                        Dummy.SetLeftAndRightSide(null, null);
                                                        Dummy.LeftSideAccess.SampleAccess = "1";
                                                    }
                                                Suitable = true;
                                                ISC = false;
                                                return Dummy;
                                            }
                        }
                        catch (NullReferenceException t)
                        { }                     
                        
                    }
                    else
                        if (Dummy.FindTree(ToSimplified, Dummy.RightSideAccess) == null)
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                        {
                            Num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                            Dummy.RightSideAccess.SampleAccess = "1";                            
                            try
                            {                                
                             if ((ToSimplified.ThreadAccess.ThreadAccess == null) && (Dummy.SampleAccess == "-"))
                                {
                                    SimplifiedTrueOtherWiseFalse = true;
                                    //LOCATION81726487 :refer to page 265.
                                    AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                    Dummy = Dummy.ThreadAccess;
                                    if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                    {
                                        Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                        Dummy.RightSideAccess.SampleAccess = "1";
                                    }
                                    else
                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                        {
                                            Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                            Dummy.LeftSideAccess.SampleAccess = "1";
                                        }
                                    Suitable = true;
                                    ISC = false;
                                    return Dummy;
                                }
                                else
                                    if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.SampleAccess == "-"))
                                        if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "+") && (Dummy.SampleAccess == "-"))
                                        {
                                            SimplifiedTrueOtherWiseFalse = true;
                                            //LOCATION81987526487 :refer to page 265.
                                            AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                            Dummy = Dummy.ThreadAccess;
                                            if (EqualToObject.IsEqual(Dummy.RightSideAccess, HOLDER))
                                            {
                                                Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                Dummy.RightSideAccess.SampleAccess = "1";
                                            }
                                            else
                                                if (EqualToObject.IsEqual(Dummy.LeftSideAccess,HOLDER))
                                                {
                                                    Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                    Dummy.LeftSideAccess.SampleAccess = "1";
                                                }
                                            Suitable = true;
                                            ISC = false;
                                            return Dummy;
                                        }
                                        else
                                        if ((ToSimplified.ThreadAccess.ThreadAccess != null) && (Dummy.SampleAccess == "+"))
                                           if ((ToSimplified.ThreadAccess.ThreadAccess.SampleAccess == "-") && (Dummy.SampleAccess == "+"))
                                                   {
                                                    SimplifiedTrueOtherWiseFalse = true;
                                                    //LOCATION81987526487 :refer to page 265.
                                                    AddToTree.Tree HOLDER = Dummy.CopyTree(Dummy);
                                                    Dummy = Dummy.ThreadAccess;
                                                    if (EqualToObject.IsEqual(Dummy.RightSideAccess,HOLDER))
                                                    {
                                                        Dummy.RightSideAccess.SetLeftAndRightSide(null, null);
                                                        Dummy.RightSideAccess.SampleAccess = "1";
                                                    }
                                                    else
                                                        if (EqualToObject.IsEqual(Dummy.LeftSideAccess, HOLDER))
                                                        {
                                                            Dummy.LeftSideAccess.SetLeftAndRightSide(null, null);
                                                            Dummy.LeftSideAccess.SampleAccess = "1";
                                                        }
                                                    Suitable = true;
                                                    ISC = false;
                                                    return Dummy;
                                                }

                            }
                            catch (NullReferenceException t)
                            { }                                 
                        }                    
                }
                else
                {
                    Num = 0;
                    Suitable = false;
                    SimplifiedTrueOtherWiseFalse = false;
                    ISC = false;
                    return Dummy;
                }
            }
            catch (NullReferenceException t)
            { }
            LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.LeftSideAccess, ToSimplified, out Suitable, out SimplifiedTrueOtherWiseFalse, out Num,out ISC);
            LocalSearchMulDivisionMulatedTowNumberSimplifier.SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(Dummy.RightSideAccess, ToSimplified, out Suitable, out SimplifiedTrueOtherWiseFalse, out Num,out ISC);
            return Dummy;
        }
     }
}
