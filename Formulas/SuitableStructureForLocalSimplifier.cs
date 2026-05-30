//CORECTION1982798724 :Refer to page 289.
//================================================
//ERRORCORECTION31704050 :Refer to page 290.
//================================================
//ADD7317 :refer to page 291.
//================================================
using System;

namespace Formulas
{
    static class SuitableStructureForLocalSimplifier
    {
        static public AddToTree.Tree SuitableStructureForLocalSimplifierFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

            return SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierFxAction(Dummy, ref UIS);
        }
        static public AddToTree.Tree SuitableStructureForLocalSimplifierConverstionOfDivToMul(AddToTree.Tree Dummy, ref bool CONVERSION, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            if (CONVERSION)
                return Dummy;
            bool CUREENTCONVERSION = false;
            AddToTree.Tree HOLDER = Dummy;
            AddToTree.Tree HOLDERTOMUL = new AddToTree.Tree(null, false);
            bool FIND = false;
            try
            {
                if (Dummy.SampleAccess == "/")
                {
                    while (IS.IsMulOrDiv(Dummy.SampleAccess))
                    {//ERRORCORECTION31704050 :Refer to page 290.
                        if (Dummy.ThreadAccess != null)
                        {
                            Dummy = Dummy.ThreadAccess;
                            FIND = true;
                            /*bool LEFTTRUERIGHTFALSE = false;
                            if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, Dummy))
                                LEFTTRUERIGHTFALSE = true;
                            else
                                LEFTTRUERIGHTFALSE = false;
                             */
                            bool BREAK = false;
                            if (Dummy.SampleAccess == "/")
                            {
                                HOLDERTOMUL = Dummy.CopyNewTree(Dummy.RightSideAccess);
                                Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                Dummy.RightSideAccess.SampleAccess = "1";
                                Dummy.SampleAccess = "*";
                                do
                                {

                                    Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, HOLDER);
                                    AddToTree.Tree NEW = new AddToTree.Tree("*", false);
                                    NEW.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess), HOLDERTOMUL);
                                    NEW.LeftSideAccess.ThreadAccess = NEW;
                                    NEW.RightSideAccess.ThreadAccess = NEW;
                                    Dummy.RightSideAccess = NEW;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    System.Media.SystemSounds.Beep.Play();
                                    BREAK = true;
                                    CUREENTCONVERSION = true;
                                    //break;
                                } while (!BREAK);
                            }
                            /*else
                            {
                               if (LEFTTRUERIGHTFALSE)
                                    Dummy = Dummy.LeftSideAccess;
                                else
                                    Dummy = Dummy.RightSideAccess;
                                
                            }
                             */
                            if (BREAK)
                                break;
                        }
                        else
                        {
                            Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, HOLDER);
                            FIND = false;
                            break;
                        }
                    }
                }
                //ADD7317 :refer to page 291.
                if (CUREENTCONVERSION)
                {
                    AddToTree.Tree THREAD = Dummy.ThreadAccess;
                    Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
                    Dummy.ThreadAccess = THREAD;
                }
                else
                    if (FIND)
                {
                    Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, HOLDER);
                    FIND = false;
                }


                SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierConverstionOfDivToMul(Dummy.LeftSideAccess, ref CONVERSION, ref UIS);
                SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierConverstionOfDivToMul(Dummy.RightSideAccess, ref CONVERSION, ref UIS);
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            catch (StackOverflowException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
        static AddToTree.Tree SuitableStructureForLocalSimplifierFxAction(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierFxNumberSorter(Dummy);
            //CORECTION1982798724 :Refer to page 289.
            bool CONVERSION = false;
            Dummy = SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierConverstionOfDivToMul(Dummy, ref CONVERSION, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree SuitableStructureForLocalSimplifierFxNumberSorter(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.SampleAccess == "*")
                if (!IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                    if (Dummy.RightSideAccess.SampleAccess == "*")
                        if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                        {
                            AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy.LeftSideAccess);
                            Dummy.LeftSideAccess = Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess);
                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                            Dummy = Dummy.RightSideAccess;
                            Dummy.LeftSideAccess = HOLDER;
                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                            Dummy = Dummy.ThreadAccess;
                        }
            if (Dummy.SampleAccess == "*")
                if (!IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                    if (Dummy.RightSideAccess.SampleAccess == "*")
                        if (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                        {
                            AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy.LeftSideAccess);
                            Dummy.LeftSideAccess = Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess);
                            Dummy.LeftSideAccess.ThreadAccess = Dummy;
                            Dummy = Dummy.RightSideAccess;
                            Dummy.RightSideAccess = HOLDER;
                            Dummy.RightSideAccess.ThreadAccess = Dummy;
                            Dummy = Dummy.ThreadAccess;
                        }
            Dummy.LeftSideAccess = SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierFxNumberSorter(Dummy.LeftSideAccess);
            Dummy.RightSideAccess = SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierFxNumberSorter(Dummy.RightSideAccess);
            return Dummy;
        }
    }
}
