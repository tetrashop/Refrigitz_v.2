//ERRORCORECTINO317514 :Simplifier has cuase some errors.refer to page 178.
//=======================================================================
//ERROR01274  :The infinite loop.refer to page 178.
//=======================================================================
//LOCATION137425312 :The need is to find a node at here.refer to page 178.
//=======================================================================
//ERROR3170154302 :the thread of right side is cuased to an infinie loop.refer to page 179.
//=======================================================================
//LOCATION98172498724 :The simplifier of null is here .refer to page 181.
//=======================================================================
//ERRORCAUSE713040  :TransmisionToDeleteingMinusPluse cuase to an invalid result.refer to page 182.
//=======================================================================
//ERROR987348 :The infinit loop.
//ERRORCORECTION918237 :Corection of ERRORCUASE713040.refer to page 182.
//=======================================================================
//ERRORCORECTION812472914 :Correction of error.refer to page 182.
//=======================================================================
//ERROR30704070 :Refer to page 188.
//=======================================================================
//ERROR31705132 :A thread Ocuured.refer to page 190.
//=======================================================================
//LOCATION98724 :Refer to page 190.Testing.
//=======================================================================
//ERROR30174051  :Refer to page 190.
//=======================================================================
//ERROR01715 :Refer to page 203.
//=======================================================================
//ERRORCORECTION31514203 :Refer to p-age 205.
//=======================================================================
//ERRORCORECTION987124 :refe to page 205.
//=======================================================================
//ERROR31517341 :Refer to page 206.
//=======================================================================
//ERROR3456714152 :Simplifier has caused to an error.refer to page 208.
//=======================================================================
//ERROR31704152 :Refer to page 216.
//=======================================================================
//ERRORCORECTION91827489742 :refer to page 220.
//=======================================================================
//ERRORCORECTION198737 :The error corected.refer to page 225.
//=======================================================================
//ERROR3060415732 :refer to page 225.The invalid smplification.
//=======================================================================
//ERROR51324537 :Refer to page 226.
//ERRORCORECTION816872366124 :ERROR75123 CORECTION.refer to page 226.
//=======================================================================
//ERROR3040152572 :Refer to page 238.
//=======================================================================
//ERRORCORECTION892148764 :The Deletion right side corrected.efer to page 238.
//MAYCORECTED2874987 :refre to page 238.
//ERROR1827348971 :Refer to page 238.The null.
//=======================================================================
//ERRORCORECTION8917874724 :When The First node sholud be deleted the invalid structure problem occured.refer to page  242.
//=======================================================================
//LOCATION1341254507 :Refer to page 242.
//=======================================================================
//ERROR317452 :Refer to page 242.
//ERROR31742501 :Refer to page 242.
//=======================================================================
//ERRORCORECTION236487267 :Refer to page 248. 
//=======================================================================
//ERROR3040507030 :Refer to page 254.
//=======================================================================
//LOCATION91823678164 :Refer to page 256.
//=======================================================================
//LOCATION17498723487 :Refer to page 258.
//=======================================================================
//ERRORCORECTION98735 :Refer to page 260.
//=======================================================================
//LOCATION287348728374 :Refer to page 260
//=======================================================================
//LOCATION2873487 :Refer to page 260
//=======================================================================
//LOCATION2873345 :Refer to page 263
//=======================================================================
//LOCATION238733450 :Refer to page 263
//=======================================================================
//LOCATION2388353450 :Refer to page 263
//=======================================================================
//LOCATION2389838450 :Refer to page 263
//=======================================================================
//LOCATION23829338450 :Refer to page 263
//=======================================================================
//LOCATION2248873345 :Refer to page 263
//=======================================================================
//LOCATION23823039283 :Refer to page 263
//=======================================================================
//LOCATION238340839283 :Refer to page 263
//=======================================================================
//LOCATION2875958450 :Refer to page 263
//=======================================================================
//LOCATION238201283 :Refer to page 264
//=======================================================================
//LOCATION23828733 :Refer to page 264.
//=======================================================================
//ERROR317450 :Refer to page 269.The M<ul Reslt is invalid.
//=======================================================================
//ERRORCORECTION918724398728734 :Refer to page 286.
//=======================================================================
//ERRORCORECTINO18263876 :The ERRORCrrected.Refer to page 287.
//=======================================================================
//ERRORCORECTION876246764 :refer to page 292.
//=======================================================================
//ERROCORECTION1982743987 :referr to page 195.
//=======================================================================
//ADDOED217864 :Refer to page 328.
//=======================================================================
//ERROCRECTION9873278634 :The Before Sample Sholud not be minuse.refer to p[age 329.
//=======================================================================
//ADDEDCONDITION28736487687 :refer to page 330.
//=======================================================================
//ERRORCORECTION918724987 : ADDED for page 333 problem.
//=======================================================================
//ADDED19283646 :Refer to page 336.
//=======================================================================
//ERRORCORECTION31754032. refer to page 339.
//=======================================================================
//ERRORCORECTIOn28736487623 :refer to paGE 334
//=======================================================================
//ERRORCORECTION4645645454:The Deleting Unregular Plus Operator From Sin(x)^2 Integral at ERRORCORECTION6654444:1394/4/6
//===============================================            
//ADDEDD66465456654646:The Integral Zero Statement Simplifier added.:1394/4/10.
//===============================================            
//ADDED364565546536465465:The Simplifier of Minus and Plus and Numbers All State Without Paranterized:1394/4/11
//===============================================            
using System;
namespace Formulas
{
    static class Simplifier
    {
        //      static SenderSample Sender = new SenderSample(new Equation());
        static AddToTreeTreeLinkList MULATED = new AddToTreeTreeLinkList();
        static UknownIntegralSolver UIS = new UknownIntegralSolver();
        static public AddToTree.Tree SimplifierFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return null;
            int INCREASE = 2147483647 / 34;

            UIS.SetProgressValue(UIS.progressBar3, 0);

            AddToTree.Tree HOLDER = Dummy.CopyNewTree(Dummy);
            int FIRRST = Integral.NumberOfElements(Dummy);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Simplifier.SetVariablesForFirsTime();

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);


            Dummy = ConvertAllMinuseToPluse.ConvertAllMinuseToPluseFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);


            //Dummy = CTOZero.COnvertCToZeroFx(Dummy);
            //ERROCORECTION1982743987 :referr to page 195.          
            Dummy = MulTowDivision.MulTowDivisionFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);


            //ADDED19283646 :Refer to page 336.            
            Dummy = MulDivisionSorter.MulDivisionSorterFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxMul(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = MulDivisionSorter.MulDivisionSorterFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = NumberDivMul.NumberDivMulFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = LocalSimplifier.LocalSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);


            //ERRORCORECTION31754032. refer to page 339.
            Dummy = CommonFactorSimlification.CommonFactorSimlificationFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.ConstructMinusAndPlusSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            //ADDEDCONDITION28736487687 :refer to page 330.
            Dummy = BesidesAverage.BesidesAverageFx(Dummy, ref UIS);
            //Dummy = MulTowDivision.MulTowDivisionFx(Dummy);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = SimplifierCommonSubFactor.SimplifierCommonSubFactorFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = LocalSimplifier.LocalSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Spliter.SpliterFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.ZeroSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.LeftArrangmentNumberAndX(Dummy);
            //ERRORCAUSE713040  :This cuase to an invalid result.refer to page 182.
            //Dummy = TransmisionToDeleteingMinusPluse.TrasmisionToDeleteingMinusPluseFx(Dummy);
            //ERROR987348 :The infinit loop below.
            //ERROR30704070 :Refer to page 188.
            //ERRORCORECTION3017401517 :The below error of pae 189 corrected.
            //ERROR30174051  :Refer to page 190.
            //ERROR01715 :Refer to page 203.
            //ERROR51324537 :Refer to page 226.
            //ERROR3040507030 :Refer to page 254.
            //ERROR317450 :Refer to page 269.The M<ul Reslt is invalid.

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxMul(Dummy, ref UIS);
            //ERROR31705132 :A thread Ocuured.refer to page 190.            

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
            //ERROR31517341 :Refer to page 206.
            //ERROR31704152 :Refer to page 216.
            //ERROR31704506 :The error occured here.refer to page 217.            

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = MulDivisionSorter.MulDivisionSorterFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = DeletingMultaplification.DeleteingMulFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = NumberDivMul.NumberDivMulFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            //Dummy = MulAndDivisionOnlySimplifier.MulAndDivisionOnlySimplifierFx(Dummy);
            //ERROR3060415732 :refer to page 225.The invalid smplification.

            //ADDOED217864 :Refer to page 328.
            /*
            Dummy = MulTowDivision.MulTowDivisionFx(Dummy);

            Dummy = CommonFactorSimlification.CommonFactorSimlificationFx(Dummy);

            Dummy = SimplifierCommonSubFactor.SimplifierCommonSubFactorFx(Dummy);
             */

            Dummy = LocalSimplifier.LocalSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Spliter.SpliterFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            //ERRORCORECTION918724987 : ADDED for page 333 problem.            
            //ERRORCORECTION4645645454:The Deleting Unregular Plus Operator From Sin(x)^2 Integral at ERRORCORECTION6654444:1394/4/6
            Dummy = AddingSameUnderElements.AddingSameUnderElementsFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);


            Dummy = SimplifierCommonSubFactor.SimplifierCommonSubFactorFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = LocalSimplifier.LocalSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Spliter.SpliterFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            Dummy = Simplifier.ConstructMinusAndPlusSimplifierFx(Dummy, ref UIS);

            UIS.SetProgressValue(UIS.progressBar3, UIS.progressBar3.Value + INCREASE);

            int END = Integral.NumberOfElements(Dummy);

            //UIS.SetProgressValue(UIS.progressBar3 , UIS.progressBar3.Value + INCREASE); 

            if (FIRRST < END)
                return HOLDER;
            else
                return Dummy;
        }
        static private bool SimplifierFxMulRemainedEditableMUL(AddToTree.Tree Current, AddToTree.Tree Dummy)
        {
            AddToTree.Tree NODE = Current;
            while (NODE.ThreadAccess != null)
                NODE = NODE.ThreadAccess;
            return Simplifier.SimplifierFxMulRemainedEditableMULAction(NODE, Dummy);

        }
        static private bool SimplifierFxMulRemainedEditableMULAction(AddToTree.Tree Current, AddToTree.Tree Node)
        {
            bool Is = false;
            if (Current == null)
                return Is;
            if (Current.ThreadAccess != null)
            {
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Current, Node))
                {
                    return Is;
                }
            }
            else
            {
                if (Current.SampleAccess == "*")
                    Is = true;
            }
            Is = Is || SimplifierFxMulRemainedEditableMULAction(Current.LeftSideAccess, Node);
            Is = Is || SimplifierFxMulRemainedEditableMULAction(Current.RightSideAccess, Node);
            return Is;
        }
        static void SetVariablesForFirsTime()
        {
            while (!(MULATED.ISEmpty()))
                MULATED.DELETEFromTreeFirstNode();
            while (DeletingMultaplification.DeletedAccess.CurrentSizeAccess > 0)
                DeletingMultaplification.DeletedAccess.DELETEFromTreeFirstNode();
        }
        static private AddToTree.Tree SimplifierFxMulDisprader(AddToTree.Tree Dummy, ref bool Action, ref bool Again, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;

            //if (Again)
            //  return Dummy;
            Dummy.LeftSideAccess = Simplifier.SimplifierFxMulDisprader(Dummy.LeftSideAccess, ref Action, ref Again, ref UIS);
            try
            {
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {
                    Dummy = Dummy.LeftSideAccess;
                }
                else
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {

                    Dummy = Dummy.RightSideAccess;
                }
            }
            catch (NullReferenceException t)
            {
                ExceptionClass.ExceptionClassMethod(t);
            }
            Dummy.RightSideAccess = Simplifier.SimplifierFxMulDisprader(Dummy.RightSideAccess, ref Action, ref Again, ref UIS);
            /*Dummy.LeftSideAccess = Simplifier.SimplifierFxMulDisprader(Dummy.LeftSideAccess, ref Action);           
            //if (Dummy != null)//ERROR1827348971 :Refer to page 238.The null.
            bool RETURED = false;
            try
            {
                if (Dummy.LeftSideAccess.ThreadAccess == null)
                {
                    Dummy = Dummy.LeftSideAccess;
                    RETURED = true;
                }
                else
                    if (Dummy.RightSideAccess.ThreadAccess == null)
                    {
                        RETURED = true;
                        Dummy = Dummy.RightSideAccess;

                    }
            }
            catch (NullReferenceException t)
            {
            }

            if (RETURED) { RETURED = false; return Dummy; }

            Dummy.RightSideAccess = Simplifier.SimplifierFxMulDisprader(Dummy.RightSideAccess, ref Action);           
             */
            //else
            //return Dummy;
            //if(!Simplifier.SimplifierFxMulRemainedEditableMUL(Dummy,Dummy))
            //return Dummy;
            //ERRORCORECTION8917874724 :When The First node sholud be deleted the invalid structure problem occured.refer to page  242.
            try
            {
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {
                    Dummy = Dummy.LeftSideAccess;
                }
                else
                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess.ThreadAccess, Dummy.ThreadAccess))
                {

                    Dummy = Dummy.RightSideAccess;
                }
            }
            catch (NullReferenceException t)
            {
                ExceptionClass.ExceptionClassMethod(t);
            }
            try
            {
                int INCREASE = 2147483647 / 21;
                bool LTRF = true;
                if ((Dummy.SampleAccess != "*") && (Dummy.SampleAccess != "/"))
                //if ((Dummy.SampleAccess == "*"))
                {
                    if ((Dummy.SampleAccess == "+") || (Dummy.SampleAccess == "-"))
                    {
                        //ERRORCORECTION918237 :Corection of ERRORCUASE713040.refer to page 182.
                        //Simplifier.GetSideOperandOfMul(Dummy, out LTRF);
                        //ERROR3040152572 :Refer to page 238.
                        //ERROR31742501 :Refer to page 242.
                        UIS.SetProgressValue(UIS.progressBar12, 0);
                        AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                        MUL = Simplifier.GetSideOperandOfMul(Dummy, out LTRF);
                        if (MUL != null)
                            if (LTRF)
                            {
                                UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                if (!MULATED.FINDTreeWithOutThreadConsideration(Dummy.LeftSideAccess))
                                {//ERROR317452 :Refer to page 242.
                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);
                                    Dummy.LeftSideAccess = Simplifier.MulDipreder(Dummy.LeftSideAccess, MUL.CopyNewTree(MUL), 0);

                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    MULATED.ADDToTree(Dummy.LeftSideAccess);
                                    Action = true;
                                    Again = true;
                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);
                                }



                                if (!MULATED.FINDTreeWithOutThreadConsideration(Dummy.RightSideAccess))
                                {
                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.RightSideAccess = Simplifier.MulDipreder(MUL.CopyNewTree(MUL), Dummy.RightSideAccess, 0);
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;

                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                    MULATED.ADDToTree(Dummy.RightSideAccess);
                                    Action = true;

                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Again = true;
                                }
                                if (Action)
                                {
                                    while (Dummy.SampleAccess != "*")
                                        Dummy = Dummy.ThreadAccess;
                                    if (Dummy.SampleAccess == "*")//MAYCORECTED2874987 :refre to page 238.
                                    {   //ERRORCORECTION98735 :Refer to page 260.

                                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.LeftSideAccess;
                                    }
                                    Action = false;
                                }
                            }
                            else
                            {
                                UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                //AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                                //MUL = Simplifier.GetSideOperandOfMul(Dummy, out LTRF);
                                if (!MULATED.FINDTreeWithOutThreadConsideration(Dummy.RightSideAccess))
                                {
                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.RightSideAccess = Simplifier.MulDipreder(MUL.CopyNewTree(MUL), Dummy.RightSideAccess, 0);
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;

                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                    MULATED.ADDToTree(Dummy.RightSideAccess);
                                    Action = true;

                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);
                                    Again = true;
                                }

                                UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                if (!(MULATED.FINDTreeWithOutThreadConsideration(Dummy.LeftSideAccess)))
                                {
                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.LeftSideAccess = Simplifier.MulDipreder(Dummy.LeftSideAccess, MUL.CopyNewTree(MUL), 0);
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;


                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    MULATED.ADDToTree(Dummy.LeftSideAccess);
                                    Again = true;

                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                }

                                if (Action)
                                {
                                    while (Dummy.SampleAccess != "*")
                                        Dummy = Dummy.ThreadAccess;
                                    if (Dummy.SampleAccess == "*")//ERRORCORECTION892148764 :The Deletion right side corrected.efer to page 238.
                                    {   //ERRORCORECTION236487267 :Refer to page 248. 
                                        /*Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.RightSideAccess;
                                         */
                                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.RightSideAccess;

                                    }
                                    Action = false;
                                }

                            }

                    }
                    else
                    {
                        UIS.SetProgressValue(UIS.progressBar12, 2147483647 / 2);

                        if ((Dummy.SampleAccess == "*") && (Dummy.SampleAccess != "/"))
                        {
                            if (IS.IsOperator(Dummy.SampleAccess))
                                if (!IS.IsPower(Dummy.SampleAccess))
                                    if (!IS.IsFunction(Dummy.SampleAccess))
                                    {

                                        UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                        //ERRORCORECTION918237 :Corection of ERRORCUASE713040.refer to page 182.
                                        AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                                        MUL = Simplifier.GetSideOperandOfMul(Dummy, out LTRF);
                                        if (MUL != null)
                                            if (LTRF)
                                            {
                                                if (!MULATED.FINDTreeWithOutThreadConsideration(Dummy.LeftSideAccess))
                                                {

                                                    Dummy.LeftSideAccess = Simplifier.MulDipreder(Dummy.LeftSideAccess, MUL.CopyNewTree(MUL), 0);

                                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                                    MULATED.ADDToTree(Dummy.LeftSideAccess);
                                                    Action = true;
                                                    Again = true;

                                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                                }
                                                if (Action)
                                                {
                                                    while (Dummy.SampleAccess != "*")
                                                        Dummy = Dummy.ThreadAccess;
                                                    if (Dummy.SampleAccess == "*")
                                                        Dummy = Dummy.RightSideAccess;
                                                    Action = false;
                                                }
                                            }
                                            else
                                            {
                                                UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                                //AddToTree.Tree MUL = new AddToTree.Tree(null, false);
                                                //MUL = Simplifier.GetSideOperandOfMul(Dummy, out LTRF);
                                                if (!MULATED.FINDTreeWithOutThreadConsideration(Dummy.RightSideAccess))
                                                {


                                                    Dummy.RightSideAccess = Simplifier.MulDipreder(MUL.CopyNewTree(MUL), Dummy.RightSideAccess, 0);

                                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                                    MULATED.ADDToTree(Dummy.RightSideAccess);
                                                    Again = true;
                                                    Action = true;

                                                    UIS.SetProgressValue(UIS.progressBar12, INCREASE + UIS.progressBar12.Value);

                                                }
                                                if (Action)
                                                {
                                                    while (Dummy.SampleAccess != "*")
                                                        Dummy = Dummy.ThreadAccess;
                                                    if (Dummy.SampleAccess == "*")
                                                        Dummy = Dummy.LeftSideAccess;
                                                    Action = false;
                                                }
                                            }

                                    }
                        }
                    }
                }
                if (LTRF)
                {
                    if (Action)
                    {
                        while (Dummy.SampleAccess != "*")
                            Dummy = Dummy.ThreadAccess;
                        if (Dummy.SampleAccess == "*")
                        {
                            if (Dummy.ThreadAccess == null)
                            {
                                Dummy.RightSideAccess.ThreadAccess = null;
                            }
                            Dummy = Dummy.RightSideAccess;
                        }
                        Action = false;
                    }
                }
                else
                {
                    if (Action)
                    {
                        if (Dummy.ThreadAccess != null)
                            while (Dummy.SampleAccess != "*")
                                Dummy = Dummy.ThreadAccess;
                        if (Dummy.SampleAccess == "*")
                        {
                            if (Dummy.ThreadAccess == null)
                                Dummy.LeftSideAccess.ThreadAccess = null;
                            Dummy = Dummy.LeftSideAccess;
                        }
                    }
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }

            UIS.SetProgressValue(UIS.progressBar12, 2147483647);

            return Dummy;
        }


        static AddToTree.Tree MulDipreder(AddToTree.Tree Dummy, AddToTree.Tree DummyDown, int level)
        {

            if (Dummy == null)
                return Dummy;
            //ERROR3170154302 :the thread of right side is cuased to an infinie loop.refer to page 179.
            AddToTree.Tree Holder = new AddToTree.Tree("*", false);
            //Dummy.ThreadAccess = null;
            //DummyDown.ThreadAccess = null;
            Holder.SetLefTandRightCommonlySide(Dummy, DummyDown);
            //Holder.LeftSideAccess.ThreadAccess = Holder;
            //Holder.RightSideAccess.ThreadAccess = Holder;
            //Holder.ThreadAccess = Dummy.ThreadAccess;
            //ERRORCORECTION31514203 :Refer to p-age 205.
            return Holder;
            //Dummy.LeftSideAccess.ThreadAccess = Dummy;
            //Dummy.RightSideAccess.ThreadAccess = Dummy;
            //Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
            //Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;

            /*if(Dummy!=null)
      if (IS.IsOperator(Dummy.SampleAccess)
          || IS.IsFunction(Dummy.SampleAccess)
              || IS.ISindependenceVaribaleOrNumber(Dummy.SampleAccess))
          if (Dummy.LeftSideAccess != null)
          {
              AddToTree.Tree Holder = new AddToTree.Tree("/", false);
              Holder.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, DummyDown);
              Holder.LeftSideAccess.ThreadAccess = Holder;
              Holder.RightSideAccess.ThreadAccess = Holder;
              Dummy.LeftSideAccess = Holder;
              Dummy.LeftSideAccess.ThreadAccess = Dummy;
              Dummy.RightSideAccess.ThreadAccess = Dummy;
              Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              //Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
              //Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
              MULATED.ADDToTree(Holder);
          }
          else
          {
              AddToTree.Tree Holder = new AddToTree.Tree("/", false);
              Holder.SetLefTandRightCommonlySide(Dummy, DummyDown);
              Holder.LeftSideAccess.ThreadAccess = Holder;
              Holder.RightSideAccess.ThreadAccess = Holder;
              Dummy = Holder;
              MULATED.ADDToTree(Holder);
          }
while((Dummy.SampleAccess != "/")&(Dummy!=null))
{
  if (!(IS.IsOperator(Dummy.SampleAccess)
      || IS.IsFunction(Dummy.SampleAccess)
          || IS.ISindependenceVaribaleOrNumber(Dummy.SampleAccess)))
  {
      if (Dummy.LeftSideAccess != null)
          if (IS.IsOperator(Dummy.LeftSideAccess.SampleAccess)
              || IS.IsFunction(Dummy.LeftSideAccess.SampleAccess)
                  || IS.ISindependenceVaribaleOrNumber(Dummy.LeftSideAccess.SampleAccess))
          {
              Dummy.LeftSideAccess = Spliter.DivisionSpliter(Dummy.LeftSideAccess, DummyDown,level++);
              Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              MULATED.ADDToTree(Dummy.LeftSideAccess);
          }
  }
  else
  {
      Dummy.RightSideAccess = Spliter.DivisionSpliter(Dummy.RightSideAccess, DummyDown,level++);
      Dummy.RightSideAccess.ThreadAccess = Dummy;
      Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
      Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
      MULATED.ADDToTree(Dummy.RightSideAccess);
  }
  //ERROR1092874 :The Error is located here .the inproper division detected.refer to page 174.
  if (!MULATED.FINDTreeWithOutThreadConsideration(Dummy.LeftSideAccess))
      Dummy = Dummy.LeftSideAccess;
  else
      break;
}
//Spliter.DivisionSpliter(Dummy.LeftSideAccess, DummyDown);
//Spliter.DivisionSpliter(Dummy.RightSideAccess, DummyDown);                                        
  //if(level==0)
//while (Dummy.ThreadAccess != null)
//{
//  Dummy = Dummy.ThreadAccess;
  //if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, Dummy.ThreadAccess))
  //  Dummy.ThreadAccess = null;
//}                
      */
            //return Dummy;
        }
        //ADDEDD66465456654646:The Integral Zero Statement Simplifier added.:1394/4/10.
        static public AddToTree.Tree ZeroSimplifierFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (!IS.IsZeroNode(Dummy))
                return Dummy;
            int INCREASEZer = Integral.NumberOfElements(Dummy);
            UIS.SetProgressValue(UIS.progressBar17, 0);
            Dummy = Simplifier.ZeroSimplifier(Dummy, ref UIS, 2147483647 / INCREASEZer);
            UIS.SetProgressValue(UIS.progressBar17, 2147483647);

            return Dummy;
        }

        static public AddToTree.Tree ZeroSimplifier(AddToTree.Tree T, ref UknownIntegralSolver UIS, int INCREASE)
        {
            if (T == null)
                return T;
            UIS.SetProgressValue(UIS.progressBar17, UIS.progressBar17.Value + INCREASE);
            if (T.SampleAccess == "*" && IS.IsNumber(T.LeftSideAccess.SampleAccess) && T.LeftSideAccess.SampleAccess == "0")
            {
                T.SetLefTandRightCommonlySide(null, null);
            }
            if (T != null && T.RightSideAccess != null && T.SampleAccess == "*" && IS.IsNumber(T.RightSideAccess.SampleAccess) && T.RightSideAccess.SampleAccess == "0")
            {
                T.SetLefTandRightCommonlySide(null, null);
                T.SampleAccess = null;
            }
            T.LeftSideAccess = ZeroSimplifier(T.LeftSideAccess, ref UIS, INCREASE);
            T.RightSideAccess = ZeroSimplifier(T.RightSideAccess, ref UIS, INCREASE);
            return T;

        }
        //ADDED364565546536465465:The Simplifier of Minus and Plus and Numbers All State Without Paranterized:1394/4/11
        static public AddToTree.Tree ConstructMinusAndPlusSimplifierFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return null;
            int INCREASEZer = Integral.NumberOfElements(Dummy);
            UIS.SetProgressValue(UIS.progressBar18, 0);
            Dummy = Simplifier.ConstructMinusAndPlusAndQuficient(Dummy, ref UIS, 2147483647 / INCREASEZer);
            UIS.SetProgressValue(UIS.progressBar18, 2147483647);

            return Dummy;
        }

        static public AddToTree.Tree SimplifierFxMul(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            //ERRORCORECTION987124 :refe to page 205.
            //Dummy = Simplifier.SimplifierFxSimpler(Dummy);  
            bool ACTION = false;
            bool Again = false;
            if (Simplifier.ISAtLeastOneMulAtNode(Dummy))
            {
                do
                {
                    Again = false;
                    Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
                    Dummy = Simplifier.SimplifierFxMulDisprader(Dummy, ref ACTION, ref Again, ref UIS);
                }
                while (Again);
            }
            return Dummy;
        }
        static int NumberOfElements(AddToTree.Tree Dummy)
        {
            int i = 0;
            if (Dummy == null)
                return 0;
            else
                i = 1;
            i = i + Simplifier.NumberOfElements(Dummy.LeftSideAccess);
            i = i + Simplifier.NumberOfElements(Dummy.RightSideAccess);
            return i;
        }
        static AddToTree.Tree GetSideOperandOfMul(AddToTree.Tree Current, out bool LeftTrueRightFalse)
        {
            //int i = 0;

            AddToTree.Tree Holder = Current;

            Current = Current.ThreadAccess;

            while (Current.SampleAccess != "*")
            {
                if (Current.SampleAccess == "/")
                    goto END;
                if (Current.SampleAccess == "-")
                    goto END;
                if (Current.SampleAccess == "+")
                    goto END;
                if (Current.SampleAccess == "^")
                    goto END;

                Current = Current.ThreadAccess;
            }
            AddToTree.Tree HolderLeft = Current.CopyNewTree(Current.LeftSideAccess);
            HolderLeft.ThreadAccess = null;
            AddToTree.Tree HolderRight = Current.CopyNewTree(Current.RightSideAccess);
            HolderRight.ThreadAccess = null;
            if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Current.RightSideAccess, Holder))
            {
                LeftTrueRightFalse = false;
                return Current.LeftSideAccess;
            }
            else
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Current.LeftSideAccess, Holder))
            {
                LeftTrueRightFalse = true;
                return Current.RightSideAccess;
            }
            /*if (Holder.FINDTreeWithOutThreadConsideration(Holder,HolderRight)!=null)
            {
                LeftTrueRightFalse = false;
                return Current.LeftSideAccess;
            }
            else
                if (Holder.FINDTreeWithOutThreadConsideration(Holder, HolderLeft)!=null)
                {
                    LeftTrueRightFalse = true;
                    return Current.RightSideAccess;
                }
             */
            END:
            LeftTrueRightFalse = false;
            return null;
            /*int LeftLevel = Simplifier.NumberOfElements(Current.LeftSideAccess);
            //while (Current.LeftSideAccess != null)
            //{
              //  Current = Current.LeftSideAccess;
                //LeftLevel++;
            //}
            //Current = Holder;
            //ERROR01274  :The infinite loop.
            //while (Current.SampleAccess != "*")
               // Current = Current.ThreadAccess;
            
            int RightLevel = Simplifier.NumberOfElements(Current.RightSideAccess);
            //while (Current.RightSideAccess != null)
            //{
              //  Current = Current.RightSideAccess;
                //RightLevel++;
           // }
            //LOCATION137425312 :The need is to find a node at here.refer to page 178.
            //while (!EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Holder, Current))
              //  Current = Current.ThreadAccess;
            //while (Current.ThreadAccess != null)
              //  Current = Current.ThreadAccess;
            
            //Current = Holder.FINDTreeWithOutThreadConsideration(Current,Holder);

            //Current = Holder;
            //while (Current.SampleAccess != "*")
              //  Current = Current.ThreadAccess;
            ///if (!EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Current, Holder))
            //{                   
                if (LeftLevel < RightLevel)
                {
                    LeftTrueRightFalse = true;
                    return Current.LeftSideAccess;
                }
                else
                {
                    LeftTrueRightFalse = false;
                    return Current.RightSideAccess;
                }
            //}
            //else
            //{
              //  LeftTrueRightFalse = false;
                //return null;
//            }
            */
        }
        static bool ISAtLeastOneMulAtNode(AddToTree.Tree Node)
        {
            bool Is = false;
            if (Node == null)
                return Is;
            if (Node.SampleAccess == "*")
                Is = true;
            Is = Is || ISAtLeastOneMulAtNode(Node.LeftSideAccess);
            Is = Is || ISAtLeastOneMulAtNode(Node.RightSideAccess);
            return Is;
        }
        static public AddToTree.Tree SimplifierFxSimpler(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            try
            {

                Dummy = MinuseToPluSeconverter.MinuseToPluSeconverterFx(Dummy, ref UIS);

                Dummy = Simplifier.LeftArrangmentNumberAndX(Dummy);

                Dummy = Simplifier.SimplifierFxSimplerActionFx(Dummy, ref UIS);


            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
        static AddToTree.Tree SimplifierFxSimplerActionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {

            if (Dummy == null)
                return Dummy;
            /*if (!RECURSIVE)
            {
                Simplifier.SimplifierFxSimpler(Dummy.LeftSideAccess);
                Simplifier.SimplifierFxSimpler(Dummy.RightSideAccess);
            }*/
            Dummy.LeftSideAccess = Simplifier.SimplifierFxSimplerActionFx(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = Simplifier.SimplifierFxSimplerActionFx(Dummy.RightSideAccess, ref UIS);
            bool RECURSIVE = true;
            int INCREASE = 2147483647 / 6;
            while (RECURSIVE)
            {


                UIS.SetProgressValue(UIS.progressBar4, 0);
                RECURSIVE = false;
                try
                {
                    if (IS.IsOperator(Dummy.SampleAccess))
                    {
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                            {
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                {
                                    //Dummy.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                            }
                            else
                                if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        {
                            ExceptionClass.ExceptionClassMethod(t);
                            // return Dummy;            
                        }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    //LOCATION1341254507 :Refer to page 242.
                    UIS.SetProgressValue(UIS.progressBar4, UIS.progressBar4.Value + INCREASE);
                    if (IS.IsOperator(Dummy.SampleAccess))
                    {
                        try
                        {
                            bool IsNode = false;
                            if (Dummy.ThreadAccess == null)
                                IsNode = true;
                            if (Dummy.LeftSideAccess == null)
                            {
                                RECURSIVE = true;
                                Dummy = Dummy.RightSideAccess;
                                if (IsNode)
                                    Dummy.ThreadAccess = null;
                            }
                            if (Dummy.RightSideAccess == null)
                            {
                                RECURSIVE = true;
                                Dummy = Dummy.LeftSideAccess;
                                if (IsNode)
                                    Dummy.ThreadAccess = null;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }//CORECTIONOFERROR.
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    UIS.SetProgressValue(UIS.progressBar4, UIS.progressBar4.Value + INCREASE);
                    if (Dummy.SampleAccess == "^")
                    {
                        try
                        {
                            if ((IS.IsNumber(Dummy.RightSideAccess.SampleAccess)) && (System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess) == 0))
                            {
                                Dummy = Dummy.LeftSideAccess;
                                RECURSIVE = true;
                            }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "^")
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.LeftSideAccess.RightSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        int Num1 = System.Convert.ToInt32(Dummy.RightSideAccess.SampleAccess);
                                        int Num2 = System.Convert.ToInt32(Dummy.LeftSideAccess.RightSideAccess.SampleAccess);
                                        Num1 = Num1 * Num2;
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.LeftSideAccess;
                                        Dummy.RightSideAccess.SampleAccess = Num1.ToString();

                                    }


                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == "1")
                            {
                                RECURSIVE = true;
                                Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                Dummy = Dummy.LeftSideAccess;
                            }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if ((Dummy.RightSideAccess.SampleAccess == "1") || (Dummy.LeftSideAccess.SampleAccess == "1"))
                            {
                                Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                Dummy = Dummy.LeftSideAccess;
                                RECURSIVE = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                                if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == null)
                                if (Dummy.RightSideAccess.SampleAccess != null)
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }

                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == null)
                                if (Dummy.LeftSideAccess.SampleAccess != null)
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "1";
                                    RECURSIVE = true;
                                }

                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                {
                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                    num = (float)System.Math.Pow(num, (System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess)));
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = num.ToString();
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        /*try{
                                 if (Dummy.RightSideAccess.SampleAccess == "1")
                                 {                            
                                     Dummy = Dummy.LeftSideAccess;
                                     RECURSIVE = true;            
                                 }
                                }
                             catch (NullReferenceException t)
                             { }
                             catch (StackOverflowException t)
                             { }
                      */
                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == null)
                            {
                                RECURSIVE = true;
                                Dummy.SampleAccess = "1";
                                Dummy.LeftSideAccess = null;
                                Dummy.RightSideAccess = null;
                            }
                            else
                                if (Dummy.LeftSideAccess.SampleAccess == null)
                            {
                                if (Dummy.ThreadAccess != null)
                                {
                                    bool ISLeftTrueIsRightFalse = true;
                                    AddToTree.Tree Holder = Dummy.ThreadAccess;

                                    if (Holder.LeftSideAccess == Dummy)
                                        ISLeftTrueIsRightFalse = true;
                                    else
                                        ISLeftTrueIsRightFalse = false;
                                    if (ISLeftTrueIsRightFalse)
                                    {
                                        RECURSIVE = true;
                                        Holder.SetLefTandRightCommonlySide(null, Holder.RightSideAccess);
                                        Holder.SampleAccess = Holder.RightSideAccess.SampleAccess;
                                        Holder.RightSideAccess = null;
                                    }
                                    else
                                    {
                                        RECURSIVE = true;
                                        Holder.SetLefTandRightCommonlySide(Holder.LeftSideAccess, null);
                                        Holder.SampleAccess = Holder.LeftSideAccess.SampleAccess;
                                        Holder.LeftSideAccess = null;
                                    }
                                    Dummy = Holder;
                                }
                                else
                                {
                                    RECURSIVE = true;
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = null;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                    }
                    UIS.SetProgressValue(UIS.progressBar4, UIS.progressBar4.Value + INCREASE);
                    if (Dummy.SampleAccess == "*")
                    {
                        try
                        {
                            if (IS.IsMul(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsMul(Dummy.RightSideAccess.SampleAccess))
                                {
                                    AddToTree.Tree MULCOPY = new AddToTree.Tree("*", false);
                                    AddToTree.Tree MUL = new AddToTree.Tree("*", false);

                                    MUL.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), MULCOPY.CopyNewTree(MULCOPY));
                                    MUL.LeftSideAccess.ThreadAccess = MUL;
                                    MUL.RightSideAccess.ThreadAccess = MUL;

                                    MUL = MUL.RightSideAccess;

                                    MUL.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess), MULCOPY.CopyNewTree(MULCOPY));
                                    MUL.LeftSideAccess.ThreadAccess = MUL;
                                    MUL.RightSideAccess.ThreadAccess = MUL;

                                    MUL = MUL.RightSideAccess;

                                    MUL.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess), Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess));
                                    MUL.LeftSideAccess.ThreadAccess = MUL;
                                    MUL.RightSideAccess.ThreadAccess = MUL;

                                    while (MUL.ThreadAccess != null)
                                        MUL = MUL.ThreadAccess;
                                    MUL.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = MUL;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {   //ERRORCORECTION876246764 :refer to page 292.
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (Dummy.RightSideAccess.SampleAccess == "/")
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                        num = num * (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess));
                                        if (num != 0)
                                            Dummy.LeftSideAccess.SampleAccess = num.ToString();
                                        else
                                            Dummy.LeftSideAccess.SampleAccess = null;
                                        Dummy.SampleAccess = "/";
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                    num = num * (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    //Dummy.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    if (num != 0)
                                        Dummy.SampleAccess = num.ToString();
                                    else
                                        Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                {
                                    Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = Dummy.RightSideAccess;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (Dummy.RightSideAccess.SampleAccess == "*")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.RightSideAccess;
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                                if (Dummy.RightSideAccess.SampleAccess == "*")
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.RightSideAccess;
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (Dummy.RightSideAccess.SampleAccess == "*")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.RightSideAccess;
                                        Dummy.LeftSideAccess.SampleAccess = "C";
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION23829338450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && (Dummy.RightSideAccess.SampleAccess == "*"))
                            {
                                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.LeftSideAccess.SampleAccess));
                                        num = num * (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.LeftSideAccess.SampleAccess));
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        if (num != 0)
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = num.ToString();
                                        else
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = null;
                                        RECURSIVE = true;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                    num = num * (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    if (num != 0)
                                        Dummy.SampleAccess = num.ToString();
                                    else
                                        Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION23829338450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && (Dummy.RightSideAccess.SampleAccess == "*"))
                            {
                                if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION2389838450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && (Dummy.RightSideAccess.SampleAccess == "*"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION2388338450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && (Dummy.RightSideAccess.SampleAccess == "*"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.ISindependenceVaribale(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsPower(Dummy.RightSideAccess.SampleAccess))
                                    if (IS.ISindependenceVaribale(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                        if (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                        {
                                            float NUM = (float)System.Convert.ToDouble(Dummy.RightSideAccess.RightSideAccess.SampleAccess);
                                            NUM++;
                                            //LOCATION1862464237 :
                                            Dummy.RightSideAccess.RightSideAccess.SampleAccess = NUM.ToString();
                                            Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                            Dummy = Dummy.RightSideAccess;

                                            /*Dummy.RightSideAccess.RightSideAccess.SampleAccess = NUM.ToString();
                                            Dummy = Dummy.ThreadAccess;
                                            Dummy.RightSideAccess.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                            Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                            Dummy = Dummy.RightSideAccess;
                                             */
                                            RECURSIVE = true;
                                        }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.ISindependenceVaribale(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsPower(Dummy.LeftSideAccess.SampleAccess))
                                    if (IS.ISindependenceVaribale(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                        if (IS.IsNumber(Dummy.LeftSideAccess.RightSideAccess.SampleAccess))
                                        {
                                            //LOCATION91823678164 :Refer to page 256.
                                            float NUM = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.SampleAccess);
                                            NUM++;
                                            Dummy.LeftSideAccess.RightSideAccess.SampleAccess = NUM.ToString();
                                            Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                            Dummy = Dummy.LeftSideAccess;
                                            RECURSIVE = true;
                                        }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if ((Dummy.LeftSideAccess.SampleAccess.ToLower() == null) || (Dummy.RightSideAccess.SampleAccess.ToLower() == null))
                            {
                                Dummy.LeftSideAccess = null;
                                Dummy.RightSideAccess = null;
                                Dummy.SampleAccess = null;
                                RECURSIVE = true;
                            }
                            else
                                /*if ((Dummy.LeftSideAccess.SampleAccess.ToLower() == "c") && (Dummy.RightSideAccess.SampleAccess.ToLower() == "c"))
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                                else*/
                                if ((IS.IsNumber(Dummy.LeftSideAccess.SampleAccess)) && (Dummy.RightSideAccess.SampleAccess.ToLower() == "c"))
                            {
                                Dummy.LeftSideAccess = null;
                                Dummy.RightSideAccess = null;
                                Dummy.SampleAccess = "C";
                                RECURSIVE = true;
                            }
                            else
                                    if ((IS.IsNumber(Dummy.RightSideAccess.SampleAccess)) && (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c"))
                            {
                                Dummy.LeftSideAccess = null;
                                Dummy.RightSideAccess = null;
                                Dummy.SampleAccess = "C";
                                RECURSIVE = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }


                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == null)
                                if (Dummy.RightSideAccess.SampleAccess != null)
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == null)
                                if (Dummy.LeftSideAccess.SampleAccess != null)
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                {
                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                    num = num * (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = num.ToString();
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (FormatException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "1")
                            {
                                Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                Dummy = Dummy.RightSideAccess;
                                Dummy.RightSideAccess.ThreadAccess = Dummy;
                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                RECURSIVE = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == "1")
                            {
                                Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                Dummy = Dummy.LeftSideAccess;
                                Dummy.RightSideAccess.ThreadAccess = Dummy;
                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                RECURSIVE = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION98172498724 :The simplifier of null is here .refer to page 181.
                            if ((Dummy.LeftSideAccess.SampleAccess == null) || (Dummy.RightSideAccess.SampleAccess == null))
                            {
                                Dummy.LeftSideAccess = null;
                                Dummy.RightSideAccess = null;
                                Dummy.SampleAccess = null;
                                RECURSIVE = true;
                                /*if (Dummy.ThreadAccess != null)
                                {
                                    AddToTree.Tree Holder = Dummy.ThreadAccess;
                                    bool ISLeftTrueIsRightFalse = true;
                                    //if (Holder.LeftSideAccess == Dummy)
                                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Holder.LeftSideAccess,Dummy))
                                        ISLeftTrueIsRightFalse = true;
                                    else
                                        ISLeftTrueIsRightFalse = false;

                                    if (ISLeftTrueIsRightFalse)
                                    {
                                        RECURSIVE = true;
                                        Holder.SetLefTandRightCommonlySide(null, Holder.RightSideAccess);
                                        Holder.SampleAccess = Holder.RightSideAccess.SampleAccess;
                                        Holder.RightSideAccess = null;
                                    }
                                    else
                                    {
                                        RECURSIVE = true;
                                        Holder.SetLefTandRightCommonlySide(Holder.LeftSideAccess, null);
                                        Holder.SampleAccess = Holder.LeftSideAccess.SampleAccess;
                                        Holder.LeftSideAccess = null;
                                    }
                                    Dummy = Holder;
                                }
                                else
                                    Dummy = null;
                                 
                            }
                            else
                            {
                                if (Dummy.LeftSideAccess.SampleAccess == "x")
                                    if (Dummy.RightSideAccess.SampleAccess == "x")
                                    {
                                        RECURSIVE = true;
                                        Dummy.SampleAccess = "^";
                                        AddToTree.Tree NUM = new AddToTree.Tree("2", false);
                                        Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, NUM);
                                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    }

                                 */
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess != null)
                                if (Dummy.RightSideAccess != null)
                                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, Dummy.RightSideAccess))
                                    {//ERRORCORECTION816872366124 :ERROR75123 CORECTION.refer to page 226.
                                        Dummy.RightSideAccess.LeftSideAccess = null;
                                        Dummy.RightSideAccess.RightSideAccess = null;
                                        Dummy.RightSideAccess.SampleAccess = "2";
                                        Dummy.SampleAccess = "^";
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                    }
                    UIS.SetProgressValue(UIS.progressBar4, UIS.progressBar4.Value + INCREASE);
                    if (Dummy.SampleAccess == "+")
                    {
                        try
                        {
                            if (IS.IsPluse(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsPluse(Dummy.RightSideAccess.SampleAccess))
                                {
                                    AddToTree.Tree ADDCOPY = new AddToTree.Tree("+", false);
                                    AddToTree.Tree ADD = new AddToTree.Tree("+", false);

                                    ADD.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), ADDCOPY.CopyNewTree(ADDCOPY));
                                    ADD.LeftSideAccess.ThreadAccess = ADD;
                                    ADD.RightSideAccess.ThreadAccess = ADD;

                                    ADD = ADD.RightSideAccess;

                                    ADD.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess), ADDCOPY.CopyNewTree(ADDCOPY));
                                    ADD.LeftSideAccess.ThreadAccess = ADD;
                                    ADD.RightSideAccess.ThreadAccess = ADD;

                                    ADD = ADD.RightSideAccess;

                                    ADD.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess.LeftSideAccess), Dummy.CopyNewTree(Dummy.RightSideAccess.RightSideAccess));
                                    ADD.LeftSideAccess.ThreadAccess = ADD;
                                    ADD.RightSideAccess.ThreadAccess = ADD;

                                    while (ADD.ThreadAccess != null)
                                        ADD = ADD.ThreadAccess;
                                    ADD.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = ADD;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                    num = num + (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    if (num != 0)
                                        Dummy.SampleAccess = num.ToString();
                                    else
                                        Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION224828832755 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.LeftSideAccess.SampleAccess));
                                        num = num + (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.LeftSideAccess.SampleAccess));
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        if (num != 0)
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = num.ToString();
                                        else
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = null;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {  //ERRORCORECTION918724398728734 :Refer to page 286.
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && (Dummy.RightSideAccess.SampleAccess == "*"))
                            {
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.RightSideAccess))
                                    if ((IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess)) && (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.LeftSideAccess.SampleAccess)))
                                    {
                                        float num = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess));
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.LeftSideAccess;
                                        num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess) + num;
                                        Dummy.LeftSideAccess.SampleAccess = num.ToString();
                                        RECURSIVE = true;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            //LOCATION22482893345 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() != "c")
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION2248873345 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION222295845 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION222295845 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION2875958450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            //LOCATION2873345 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            //LOCATION238733450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION2873487 :Refer to page 260
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                                if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        //LOCATION98724 :Refer to page 190.Testing.
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == null)
                                if (Dummy.RightSideAccess.SampleAccess != null)
                                {
                                    Dummy.RightSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = Dummy.RightSideAccess;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    RECURSIVE = true;

                                    //Dummy.SetLefTandRightCommonlySide(null,null);

                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == null)
                                if (Dummy.LeftSideAccess.SampleAccess != null)
                                {

                                    Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = Dummy.LeftSideAccess;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    RECURSIVE = true;

                                    //Dummy.SetLefTandRightCommonlySide(null,null);                     
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }


                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                {
                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                    num = num + (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = num.ToString();
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess != null)
                                if (Dummy.RightSideAccess != null)
                                {
                                    //if (Dummy.LeftSideAccess.SampleAccess == "x")
                                    //  if (Dummy.RightSideAccess.SampleAccess == "x")
                                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess, Dummy.LeftSideAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.LeftSideAccess.SampleAccess = "2";
                                        Dummy.SampleAccess = "*";
                                    }
                                    if (Dummy.LeftSideAccess.SampleAccess == "*")
                                    {
                                        if (Dummy.RightSideAccess.SampleAccess == "*")
                                        {
                                            if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                                    if (IS.ISindependenceVaribale(Dummy.LeftSideAccess.RightSideAccess.SampleAccess))
                                                        if (IS.ISindependenceVaribale(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                                        {
                                                            RECURSIVE = true;
                                                            Dummy.SampleAccess = "*";
                                                            float num = System.Convert.ToInt16(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                                            num = num + System.Convert.ToInt16(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                                                            AddToTree.Tree NUM = new AddToTree.Tree(num.ToString(), false);
                                                            AddToTree.Tree X = new AddToTree.Tree("x", false);
                                                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                            Dummy.SetLefTandRightCommonlySide(NUM, X);

                                                        }
                                        }
                                        else
                                            if (Dummy.RightSideAccess.SampleAccess == "x")
                                        {
                                            RECURSIVE = true;
                                            Dummy.SampleAccess = "*";

                                            float num = System.Convert.ToInt16(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                            num = num + 1;
                                            AddToTree.Tree NUM = new AddToTree.Tree(num.ToString(), false);
                                            AddToTree.Tree X = new AddToTree.Tree("x", false);
                                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.SetLefTandRightCommonlySide(NUM, X);
                                        }
                                    }
                                    else//ERRORCORECTINO317514 :Simplifier has cuase some errors.refer to page 178.and refer to page 256.
                                        if (Dummy.LeftSideAccess.SampleAccess == "x")
                                        if (Dummy.RightSideAccess.SampleAccess == "*")
                                            if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.LeftSideAccess.SampleAccess))
                                                if (IS.ISindependenceVaribale(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                                {
                                                    RECURSIVE = true;
                                                    Dummy.SampleAccess = "*";
                                                    float num = (float)System.Convert.ToInt16(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                                                    num = num + 1;
                                                    AddToTree.Tree NUM = new AddToTree.Tree(num.ToString(), false);
                                                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                                                    Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                    Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                    Dummy.SetLefTandRightCommonlySide(NUM, X);
                                                }
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                    }
                    UIS.SetProgressValue(UIS.progressBar4, UIS.progressBar4.Value + INCREASE);
                    if (Dummy.SampleAccess == "-")
                    {
                        try
                        {
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                    num = num - (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    if (num != 0)
                                        Dummy.SampleAccess = num.ToString();
                                    else
                                        Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {//ERROCRECTION9873278634 :The Before Sample Sholud not be minuse.
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && (Dummy.RightSideAccess.SampleAccess == "*") && ((Dummy.ThreadAccess == null) || (Dummy.ThreadAccess.SampleAccess != "-")))
                            {
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.RightSideAccess))
                                {
                                    Dummy.SampleAccess = "*";
                                    Dummy.LeftSideAccess.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                    Dummy.LeftSideAccess.SampleAccess = "-";
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    RECURSIVE = true;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            //LOCATION23982333 :Refer to page 264.
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION23828733 :Refer to page 264.
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION238201283 :Refer to page 264.
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.LeftSideAccess.SampleAccess));
                                        num = num - (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.LeftSideAccess.SampleAccess));
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        if (num != 0)
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = num.ToString();
                                        else
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = null;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION23823039283 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.LeftSideAccess.SampleAccess));
                                        num = num - (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.LeftSideAccess.SampleAccess));
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        if (num != 0)
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = num.ToString();
                                        else
                                            Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = null;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                //LOCATION297899283 :Refer to page 263
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION238340839283 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION2388338483 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }


                        try
                        {
                            //LOCATION2388353450 :Refer to page 263
                            if ((Dummy.LeftSideAccess.SampleAccess == "-") && (Dummy.RightSideAccess.SampleAccess == "-"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //LOCATION287348728374 :Refer to page 260
                            if ((Dummy.LeftSideAccess.SampleAccess == "+") && (Dummy.RightSideAccess.SampleAccess == "+"))
                            {
                                if (Dummy.LeftSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    if (Dummy.RightSideAccess.LeftSideAccess.SampleAccess.ToLower() == "c")
                                    {
                                        RECURSIVE = true;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess.ThreadAccess;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    }

                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                                if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == null)
                                if (Dummy.RightSideAccess.SampleAccess != null)
                                {
                                    AddToTree.Tree NUM = new AddToTree.Tree("-1", false);
                                    Dummy = Dummy.RightSideAccess;
                                    Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), NUM);
                                    Dummy.SampleAccess = "*";
                                    RECURSIVE = true;

                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == null)
                                if (Dummy.LeftSideAccess.SampleAccess != null)
                                {
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                    Dummy = Dummy.LeftSideAccess;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    RECURSIVE = true;



                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                {
                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                    num = num - (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess);
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = num.ToString();
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            //ERROR3456714152 :Simplifier has caused to an error.refer to page 208.
                            if (Dummy.LeftSideAccess != null)
                                if (Dummy.RightSideAccess != null)
                                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, Dummy.RightSideAccess))
                                        if ((Dummy.ThreadAccess == null))
                                        {
                                            RECURSIVE = true;
                                            Dummy.LeftSideAccess = null;
                                            Dummy.RightSideAccess = null;
                                            Dummy.SampleAccess = null;
                                        }
                                        else
                                            if (Dummy.ThreadAccess.SampleAccess != "-")
                                        {
                                            RECURSIVE = true;
                                            Dummy.LeftSideAccess = null;
                                            Dummy.RightSideAccess = null;
                                            Dummy.SampleAccess = null;
                                        }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess != null)
                                if (Dummy.RightSideAccess != null)
                                    if (Dummy.LeftSideAccess.SampleAccess == "*")
                                        if (Dummy.RightSideAccess.SampleAccess == "*")
                                        {
                                            if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.RightSideAccess))
                                                if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                                    if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                                    {
                                                        RECURSIVE = true;
                                                        Dummy.SampleAccess = "*";
                                                        float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess);
                                                        num = num - (float)System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess);
                                                        AddToTree.Tree Num = new AddToTree.Tree(null, false);
                                                        if (num != 0)
                                                        {
                                                            Num.SampleAccess = num.ToString();
                                                        }
                                                        else
                                                            Num.SampleAccess = null;
                                                        Dummy.SetLefTandRightCommonlySide(Num, Dummy.RightSideAccess.RightSideAccess);
                                                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                    }
                                        }
                                        else
                                            if (Dummy.RightSideAccess.SampleAccess == "x")
                                        {
                                            if (IS.IsNumber(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                                if (IS.ISindependenceVaribale(Dummy.LeftSideAccess.RightSideAccess.SampleAccess))
                                                {
                                                    RECURSIVE = true;
                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                                    Dummy = Dummy.LeftSideAccess;
                                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                                    num = num - 1;
                                                    if (num == 0)
                                                    {
                                                        Dummy.LeftSideAccess = null;
                                                        Dummy.RightSideAccess = null;
                                                        Dummy.SampleAccess = null;
                                                    }
                                                    else
                                                        Dummy.LeftSideAccess.SampleAccess = num.ToString();
                                                }
                                        }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                    }
                    UIS.SetProgressValue(UIS.progressBar4, UIS.progressBar4.Value + INCREASE);
                    if (Dummy.SampleAccess == "/")
                    {
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "*")
                                if (Dummy.RightSideAccess.SampleAccess == "^")
                                    if (Dummy.LeftSideAccess.RightSideAccess.SampleAccess == "^")
                                        if (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                            if (IS.IsNumber(Dummy.LeftSideAccess.RightSideAccess.RightSideAccess.SampleAccess))
                                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess.LeftSideAccess, Dummy.RightSideAccess.LeftSideAccess))
                                                {
                                                    RECURSIVE = true;
                                                    int num1 = System.Convert.ToInt32(Dummy.RightSideAccess.RightSideAccess.SampleAccess);
                                                    int num2 = System.Convert.ToInt32(Dummy.LeftSideAccess.RightSideAccess.RightSideAccess.SampleAccess);

                                                    if (num1 > num2)
                                                    {
                                                        Dummy.LeftSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.LeftSideAccess.RightSideAccess.SampleAccess = "1";
                                                        num1 = num1 - num2;
                                                        Dummy.RightSideAccess.RightSideAccess.SampleAccess = num1.ToString();
                                                    }
                                                    else
                                                        if (num1 < num2)
                                                    {
                                                        Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.RightSideAccess.SampleAccess = "1";
                                                        num2 = num2 - num1;
                                                        Dummy.LeftSideAccess.RightSideAccess.RightSideAccess.SampleAccess = num2.ToString();

                                                    }
                                                    else
                                                            if (num1 == num2)
                                                    {
                                                        Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.RightSideAccess.SampleAccess = "1";
                                                        Dummy.LeftSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                                        Dummy.LeftSideAccess.RightSideAccess.SampleAccess = "1";
                                                    }

                                                }

                        }
                        catch (NullReferenceException t)
                        {
                            ExceptionClass.ExceptionClassMethod(t);
                        }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "*")
                                if (Dummy.RightSideAccess.SampleAccess == "^")
                                    if (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                        if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.LeftSideAccess))
                                        {
                                            RECURSIVE = true;
                                            Dummy.LeftSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.LeftSideAccess.RightSideAccess.SampleAccess = "1";
                                            int Num = System.Convert.ToInt32(Dummy.RightSideAccess.RightSideAccess.RightSideAccess.SampleAccess);
                                            Num = Num - 1;
                                            Dummy.RightSideAccess.RightSideAccess.SampleAccess = Num.ToString();


                                        }

                        }
                        catch (NullReferenceException t)
                        {
                            ExceptionClass.ExceptionClassMethod(t);
                        }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "*")
                                if (Dummy.LeftSideAccess.RightSideAccess.SampleAccess == "^")
                                    if (IS.IsNumber(Dummy.LeftSideAccess.RightSideAccess.RightSideAccess.SampleAccess))
                                        if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.RightSideAccess, Dummy.LeftSideAccess.RightSideAccess.LeftSideAccess))
                                        {
                                            RECURSIVE = true;
                                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                            Dummy.RightSideAccess.SampleAccess = "1";
                                            double Num = System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.RightSideAccess.SampleAccess);
                                            Num = Num - 1;
                                            Dummy.LeftSideAccess.RightSideAccess.RightSideAccess.SampleAccess = Num.ToString();
                                        }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            //ERRORCORECTIOn28736487623 :refer to paGE 334
                            if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, Dummy.RightSideAccess.LeftSideAccess))
                                if (Dummy.RightSideAccess.SampleAccess == "^")
                                    if (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                    {
                                        Dummy.LeftSideAccess.SampleAccess = "1";
                                        Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.RightSideAccess.RightSideAccess.SampleAccess = System.Convert.ToString(System.Convert.ToInt32(Dummy.RightSideAccess.RightSideAccess.SampleAccess) - 1);
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {//ERRORCORECTINO18263876 :The ERRORCrrected.Refer to page 287.
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.LeftSideAccess.SampleAccess))
                                    if (Dummy.RightSideAccess.SampleAccess == "*")
                                    {
                                        float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                        num = num / (float)(System.Convert.ToDouble(Dummy.RightSideAccess.LeftSideAccess.SampleAccess));
                                        if (num != 0)
                                            Dummy.LeftSideAccess.SampleAccess = num.ToString();
                                        else
                                            Dummy.LeftSideAccess.SampleAccess = null;
                                        Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                        Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                {
                                    float num = (float)(System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess));
                                    num = num / (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    if (num != 0)
                                        Dummy.SampleAccess = num.ToString();
                                    else
                                        Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (DivideByZeroException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsMul(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsMul(Dummy.LeftSideAccess.LeftSideAccess.SampleAccess))
                                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess))
                                    {
                                        Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.RightSideAccess.SampleAccess = "1";
                                        Dummy.LeftSideAccess.LeftSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                        Dummy.LeftSideAccess.LeftSideAccess.RightSideAccess.SampleAccess = "1";
                                        RECURSIVE = true;
                                    }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {

                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && ((Dummy.RightSideAccess.SampleAccess == "*")))
                            {
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.LeftSideAccess, Dummy.RightSideAccess.LeftSideAccess))
                                {
                                    //Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    //Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = "1";
                                    Dummy.LeftSideAccess.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.LeftSideAccess.SampleAccess = "1";

                                    Dummy.LeftSideAccess.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;

                                    RECURSIVE = true;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && ((Dummy.RightSideAccess.SampleAccess == "*")))
                            {
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.LeftSideAccess))
                                {
                                    //Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                    //Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;
                                    Dummy.LeftSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.RightSideAccess.SampleAccess = "1";
                                    Dummy.RightSideAccess.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.LeftSideAccess.SampleAccess = "1";

                                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.RightSideAccess;

                                    RECURSIVE = true;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && ((Dummy.RightSideAccess.SampleAccess == "*")))
                            {
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.LeftSideAccess, Dummy.RightSideAccess.RightSideAccess))
                                {
                                    //Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    //Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                    Dummy.LeftSideAccess.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.LeftSideAccess.SampleAccess = "1";
                                    Dummy.RightSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.RightSideAccess.SampleAccess = "1";

                                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess = Dummy.LeftSideAccess.RightSideAccess;
                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;

                                    RECURSIVE = true;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if ((Dummy.LeftSideAccess.SampleAccess == "*") && ((Dummy.RightSideAccess.SampleAccess == "*")))
                            {
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.RightSideAccess, Dummy.RightSideAccess.RightSideAccess))
                                {
                                    //LOCATION17498723487 :Refer to page 258.
                                    //Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    //Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                    //Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;
                                    Dummy.LeftSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.LeftSideAccess.RightSideAccess.SampleAccess = "1";
                                    Dummy.RightSideAccess.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                                    Dummy.RightSideAccess.RightSideAccess.SampleAccess = "1";

                                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.LeftSideAccess = Dummy.LeftSideAccess.LeftSideAccess;
                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess = Dummy.RightSideAccess.LeftSideAccess;

                                    RECURSIVE = true;
                                }
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }


                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == null)
                                if (Dummy.RightSideAccess.SampleAccess != null)
                                {
                                    Dummy.RightSideAccess = null;
                                    Dummy.LeftSideAccess = null;
                                    Dummy.SampleAccess = null;
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                                if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                                {
                                    RECURSIVE = true;
                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.SampleAccess);
                                    //    if (Dummy.RightSideAccess.SampleAccess.ToLower() != "c")
                                    //  {
                                    num = (float)(num / (float)System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    if (num != 0)
                                        Dummy.SampleAccess = num.ToString();
                                    else
                                        Dummy.SampleAccess = null;
                                    //}
                                    /*else
                                    {
                                        Dummy.SetLefTandRightCommonlySide(null, null);
                                        Dummy.SampleAccess = "C";                              
                                    }
                                     */
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess.ToLower() == "c")
                                if (Dummy.RightSideAccess.SampleAccess.ToLower() == "c")
                                {
                                    Dummy.LeftSideAccess = null;
                                    Dummy.RightSideAccess = null;
                                    Dummy.SampleAccess = "C";
                                    RECURSIVE = true;
                                }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if ((Dummy.LeftSideAccess.SampleAccess == null) && (Dummy.RightSideAccess.SampleAccess != null))
                            {
                                Dummy.LeftSideAccess = null;
                                Dummy.RightSideAccess = null;
                                Dummy.SampleAccess = null;
                                RECURSIVE = true;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess != null)
                                if (Dummy.RightSideAccess != null)
                                    if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, Dummy.RightSideAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.LeftSideAccess = null;
                                        Dummy.RightSideAccess = null;
                                        Dummy.SampleAccess = "1";
                                    }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "^")
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.LeftSideAccess, Dummy.RightSideAccess))
                                    if (IS.IsNumber(Dummy.LeftSideAccess.RightSideAccess.SampleAccess))
                                    {
                                        RECURSIVE = true;
                                        Dummy.SampleAccess = "^";
                                        float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.SampleAccess);
                                        num = num - 1;
                                        AddToTree.Tree NUMnew = new AddToTree.Tree(null, false);
                                        if (num != 0)
                                            NUMnew.SampleAccess = num.ToString();
                                        else
                                            NUMnew.SampleAccess = null;
                                        //Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess.LeftSideAccess, NUM);
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                        Dummy = Dummy.LeftSideAccess;
                                        Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, NUMnew);
                                        //ERRORCORECTION198737 :The error corected.refer to page 225.
                                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    }
                        }
                        catch (NullReferenceException t)
                        {
                            ExceptionClass.ExceptionClassMethod(t);
                        }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.LeftSideAccess.SampleAccess == "^")
                                if (Dummy.RightSideAccess.SampleAccess == "^")
                                    if (IS.IsNumber(Dummy.LeftSideAccess.RightSideAccess.SampleAccess))
                                        if (Dummy.RightSideAccess.RightSideAccess != null)
                                        {
                                            if (IS.IsNumber(Dummy.RightSideAccess.RightSideAccess.SampleAccess))
                                            {
                                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess.LeftSideAccess, Dummy.RightSideAccess.LeftSideAccess))
                                                {
                                                    RECURSIVE = true;
                                                    Dummy.SampleAccess = "^";
                                                    float num = (float)System.Convert.ToDouble(Dummy.LeftSideAccess.RightSideAccess.SampleAccess);
                                                    num = num - (float)System.Convert.ToDouble(Dummy.RightSideAccess.RightSideAccess.SampleAccess);
                                                    AddToTree.Tree NUM = new AddToTree.Tree(null, false);
                                                    if (num != 0)
                                                        NUM.SampleAccess = num.ToString();
                                                    else
                                                        NUM.SampleAccess = null;
                                                    //Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess.LeftSideAccess, NUM);
                                                    //Dummy.LeftSideAccess.ThreadAccess = null;
                                                    //Dummy.RightSideAccess.ThreadAccess = null;                                                                            
                                                    //Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy;
                                                    Dummy = Dummy.LeftSideAccess;
                                                    Dummy.RightSideAccess = NUM;
                                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                                }
                                            }
                                        }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        try
                        {
                            if (Dummy.RightSideAccess.SampleAccess == "1")
                            {
                                RECURSIVE = true;
                                Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                                Dummy = Dummy.LeftSideAccess;
                                Dummy.RightSideAccess.ThreadAccess = Dummy;
                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                            }
                        }
                        catch (NullReferenceException t)
                        { ExceptionClass.ExceptionClassMethod(t); }
                        catch (StackOverflowException t)
                        { ExceptionClass.ExceptionClassMethod(t); }

                    }
                }
                catch (NullReferenceException t)
                {
                    ExceptionClass.ExceptionClassMethod(t);

                    // return Dummy;            
                }
                catch (StackOverflowException t)
                { ExceptionClass.ExceptionClassMethod(t); }
                UIS.SetProgressValue(UIS.progressBar4, 2147483647);
            }
            return Dummy;
        }
        static AddToTree.Tree LeftArrangmentNumberAndX(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.LeftSideAccess != null)
                if (Dummy.RightSideAccess != null)
                    if ((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "+"))
                    {
                        if (IS.ISindependenceVaribaleOrNumber(Dummy.RightSideAccess.SampleAccess))
                            //if (Sender.AutoSenderAccess.IsNumber(Dummy.LeftSideAccess.SampleAccess))
                            Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
                    }

            Simplifier.LeftArrangmentNumberAndX(Dummy.LeftSideAccess);
            Simplifier.LeftArrangmentNumberAndX(Dummy.RightSideAccess);
            return Dummy;
        }
        static public AddToTree.Tree ArrangmentForSpliter(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            try
            {
                if (Dummy.LeftSideAccess != null)
                    if (Dummy.RightSideAccess != null)
                        //ERRORCORECTION812472914 :Correction of error.refer to page 182.
                        if ((Dummy.SampleAccess == "*") || (Dummy.SampleAccess == "+"))
                        {
                            if (IS.IsOperator(Dummy.RightSideAccess.SampleAccess))
                                Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
                            if (Dummy.RightSideAccess.SampleAccess.ToLower() == "C")
                                Dummy.SetLefTandRightCommonlySide(Dummy.RightSideAccess, Dummy.LeftSideAccess);
                        }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            Simplifier.LeftArrangmentNumberAndX(Dummy.LeftSideAccess);
            Simplifier.LeftArrangmentNumberAndX(Dummy.RightSideAccess);
            return Dummy;
        }
        static public AddToTree.Tree ConstructMinusAndPlusAndQuficient(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS, int INCREASE)
        {
            if (Dummy == null)
                return null;
            UIS.SetProgressValue(UIS.progressBar18, UIS.progressBar18.Value + INCREASE);
            if (IS.IsMulAllNode(Dummy.LeftSideAccess) && Dummy.SampleAccess == "-")
            {
                AddToTree.Tree Number = null;

                if (IS.ReterunIfIsNumberNode(Dummy.LeftSideAccess, ref Number))
                {
                    Dummy.SampleAccess = "+";
                    Number.SampleAccess = (System.Convert.ToDouble(Number.SampleAccess) * -1).ToString();
                }
            }
            else
                if (IS.IsMulAllNode(Dummy.RightSideAccess) && Dummy.SampleAccess == "-")
            {
                AddToTree.Tree Number = null;
                if (IS.ReterunIfIsNumberNode(Dummy.RightSideAccess, ref Number))
                {
                    Dummy.SampleAccess = "+";
                    Number.SampleAccess = (System.Convert.ToDouble(Number.SampleAccess) * -1).ToString();
                }
            }
            if (IS.IsPlusOrMulAllNode(Dummy.LeftSideAccess) && Dummy.SampleAccess == "-")
            {
                AddToTree.Tree[] Plus = new AddToTree.Tree[Integral.NumberOfElements(Dummy)];
                int Len = 0;
                if (IS.ReterunIfIsPlusNode(Dummy.LeftSideAccess, ref Plus, ref Len))
                {
                    Dummy.SampleAccess = "+";
                    for (int i = 0; i < Len; i++)
                    {
                        Plus[i].SampleAccess = "-";

                    }
                }
            }
            else
                if (IS.IsPlusOrMulAllNode(Dummy.RightSideAccess) && Dummy.SampleAccess == "-")
            {
                AddToTree.Tree[] Plus = new AddToTree.Tree[Integral.NumberOfElements(Dummy)];
                int Len = 0;
                if (IS.ReterunIfIsPlusNode(Dummy.RightSideAccess, ref Plus, ref Len))
                {
                    for (int i = 0; i < Len; i++)
                    {
                        Plus[i].SampleAccess = "-";

                    }
                }
            }
            Dummy.LeftSideAccess = ConstructMinusAndPlusAndQuficient(Dummy.LeftSideAccess, ref UIS, INCREASE);
            Dummy.RightSideAccess = ConstructMinusAndPlusAndQuficient(Dummy.RightSideAccess, ref UIS, INCREASE);
            return Dummy;
        }
    }
}
