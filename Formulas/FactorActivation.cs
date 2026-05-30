//ERROR932875987 : Refer to page 301 :If The Non Copy of Dummy Passes to method the result of dummy become invalid.
//================================================================================
//ERRORCORECTION981724876 :Refer to page 302.
//================================================================================
//ERRORCORCTION827346 :Refer to page 302.
//================================================================================
//ERROR715540         :Refer to page 302.
//================================================================================
//ERRORCORECTION912847 :refer to page 302.
//================================================================================
//ERROCORECTION172487 ;the non copy strategy cused to invalid result(effection of To be "1").refer to page 302.
//================================================================================
//ERRORCORECTION1284797 :refer to page 302.
//================================================================================
//CAUSEDERROR2983747 :This Section because of Loss Factors not is not become one extra factors.refer to page 334.
//================================================================================
//ERROR293846210394 :The effection of Thread is not act on thread.refer to page 335.
//ERROCORECTION91827831294 :The thread validation is corrected.refer to page 335.
//================================================================================
using System;

namespace Formulas
{
    static class FactorActivation
    {
        static AddToTreeTreeLinkList NotAbledFactors = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList AbledFactors = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList ONLYMULnODE = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList MULATEDELEMENTS = new AddToTreeTreeLinkList();

        static public AddToTree.Tree FactorActivationFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            while (!(NotAbledFactors.ISEmpty()))
                NotAbledFactors.DELETEFromTreeFirstNode();
            while (!(AbledFactors.ISEmpty()))
                AbledFactors.DELETEFromTreeFirstNode();
            while (!(ONLYMULnODE.ISEmpty()))
                ONLYMULnODE.DELETEFromTreeFirstNode();
            while (!(MULATEDELEMENTS.ISEmpty()))
                MULATEDELEMENTS.DELETEFromTreeFirstNode();
            Dummy = FactorActivation.FactorActivationFirstMinuseOrPluseFx(Dummy, ref UIS);

            return Dummy;
        }
        static AddToTree.Tree FactorActivationFirstMinuseOrPluseFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;

            if ((FactorActivation.SuitableForFactorActivation(Dummy.CopyNewTree(Dummy))) && ((Dummy.SampleAccess == "+") || (Dummy.SampleAccess == "-")))
            {
                FactorActivation.FactorActivationOnlyMuLnodesListedFx(Dummy.CopyNewTree(Dummy));
                Dummy = FactorActivation.FactorActivationActionFx(Dummy, ref UIS);
            }
            while (!(NotAbledFactors.ISEmpty()))
                NotAbledFactors.DELETEFromTreeFirstNode();
            while (!(AbledFactors.ISEmpty()))
                AbledFactors.DELETEFromTreeFirstNode();
            while (!(ONLYMULnODE.ISEmpty()))
                ONLYMULnODE.DELETEFromTreeFirstNode();
            while (!(MULATEDELEMENTS.ISEmpty()))
                MULATEDELEMENTS.DELETEFromTreeFirstNode();
            Dummy.LeftSideAccess = FactorActivation.FactorActivationFirstMinuseOrPluseFx(Dummy.LeftSideAccess, ref UIS);
            Dummy.RightSideAccess = FactorActivation.FactorActivationFirstMinuseOrPluseFx(Dummy.RightSideAccess, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree FactorActivationActionFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            //ERROR932875987 : Refer to page 301 :If The Non Copy of Dummy Passes to method the result of dummy become invalid.
            //AddToTree.Tree Factor = FactorActivation.GetBigestCommonFactor(Dummy.CopyNewTree(Dummy));
            AddToTreeTreeLinkList FactorLinkList = FactorActivation.GetBigestCommonFactor(Dummy.CopyNewTree(Dummy), ref UIS);
            bool Action = false;
            bool Mul = false;
            if (!(FactorLinkList.ISEmpty()))
            {
                AddToTree.Tree Factor = new AddToTree.Tree(null, false);
                //ERROR293846210394 :The effection of Thread is not act on thread.
                //AddToTree.Tree Holder = Dummy.CopyNewTree(Dummy.ThreadAccess);
                //ERROCORECTION91827831294 :The thread validation is corrected.refer to page 335.
                AddToTree.Tree Holder = Dummy.ThreadAccess;

                bool LeftTrueRightFalse = false;
                try
                {
                    if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))
                        LeftTrueRightFalse = false;
                    else
                        LeftTrueRightFalse = true;
                }
                catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

                Dummy.ThreadAccess = null;

                while (!(FactorLinkList.ISEmpty()))
                {
                    Factor = FactorLinkList.DELETEFromTreeFirstNode();
                    Dummy = FactorActivation.FactorActivationDivActionFx(Dummy.CopyNewTree(Dummy), Factor, ref Action, ref Mul, FactorLinkList.CopyLinkList());
                }
                while (Dummy.ThreadAccess != null)
                    Dummy = Dummy.ThreadAccess;
                Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);
                try
                {
                    if (!LeftTrueRightFalse)
                        Holder.RightSideAccess = Dummy;
                    else
                        Holder.LeftSideAccess = Dummy;
                }
                catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
                Dummy.ThreadAccess = Holder;
            }
            return Dummy;
        }
        static AddToTree.Tree FactorActivationDivActionFx(AddToTree.Tree Dummy, AddToTree.Tree Factor, ref bool Action, ref bool Mul, AddToTreeTreeLinkList CopyOfFactors)
        {
            if (Dummy == null)
                return Dummy;
            bool Current = false;

            try
            {
                if (Mul && Action && (IS.IsMinusAndPluseFirstNode(Dummy.ThreadAccess) && (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.ThreadAccess.RightSideAccess, Dummy))))
                {
                    Action = false;
                    Mul = false;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            if ((IS.IsMinusAndPluseFirstNode(Dummy)) && (!Mul) && ((Factor != null)))
            {

                AddToTree.Tree Copy = new AddToTree.Tree("*", false);
                Copy.SetLefTandRightCommonlySide(Factor.CopyNewTree(Factor), Dummy.CopyNewTree(Dummy));
                Copy.LeftSideAccess.ThreadAccess = Copy;
                Copy.RightSideAccess.ThreadAccess = Copy;
                Copy.ThreadAccess = Dummy.ThreadAccess;
                Dummy = Copy;
                Mul = true;
                Current = true;
            }
            else//CAUSEDERROR2983747 :This Section because of Loss Factors not is not become one extra factors.            
                Dummy = FactorActivation.ConvertExtraFactorsTooneFx(Dummy, Factor, ref Action, Current);

            if (Current)
            {
                Dummy = Dummy.RightSideAccess;
                //Dummy = Dummy.RightSideAccess;
                Current = false;
            }

            Dummy.LeftSideAccess = FactorActivation.FactorActivationDivActionFx(Dummy.LeftSideAccess, Factor, ref Action, ref Mul, CopyOfFactors);
            Dummy.RightSideAccess = FactorActivation.FactorActivationDivActionFx(Dummy.RightSideAccess, Factor, ref Action, ref Mul, CopyOfFactors);

            return Dummy;
        }
        static AddToTree.Tree ConvertExtraFactorsTooneFx(AddToTree.Tree Dummy, AddToTree.Tree Factors, ref bool Action, bool Current)
        {
            /*AddToTree.Tree HOLDER = Dummy;
            if(IS.IsMinuseOrPluse(Dummy.SampleAccess))
            while (Dummy.SampleAccess != "+")
                Dummy = Dummy.ThreadAccess;
             */
            //while (!(Factors.ISEmpty()))
            Dummy = FactorActivation.ConvertExtraFactorsToone(Dummy, Factors, ref Action, Current);
            //Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy,HOLDER);
            return Dummy;

        }
        static AddToTree.Tree ConvertExtraFactorsToone(AddToTree.Tree Dummy, AddToTree.Tree Factors, ref bool Action, bool Current)
        {
            if (Dummy == null)
                return Dummy;
            if ((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, Factors)) && (!Action) && (!Current))
            {
                Action = true;
                Dummy.SetLefTandRightCommonlySide(null, null);
                Dummy.SampleAccess = "1";
            }
            Dummy.LeftSideAccess = FactorActivation.ConvertExtraFactorsToone(Dummy.LeftSideAccess, Factors, ref Action, Current);
            Dummy.RightSideAccess = FactorActivation.ConvertExtraFactorsToone(Dummy.RightSideAccess, Factors, ref Action, Current);
            return Dummy;
        }
        static void FactorActivationOnlyMuLnodesListedFx(AddToTree.Tree Dummy)
        {
            if (IS.IsNotMinusAndPluseInNode(Dummy))
                if (!(ONLYMULnODE.FINDTreeWithOutThreadConsideration(Dummy)))
                {
                    ONLYMULnODE.ADDToTree(Dummy);
                    return;
                }
            FactorActivation.FactorActivationOnlyMuLnodesListedFx(Dummy.LeftSideAccess);
            FactorActivation.FactorActivationOnlyMuLnodesListedFx(Dummy.RightSideAccess);
            return;
        }
        static public AddToTreeTreeLinkList GetBigestCommonFactor(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            AddToTreeTreeLinkList CommonFactors = new AddToTreeTreeLinkList();
            AddToTreeTreeLinkList Holder = new AddToTreeTreeLinkList();
            //ERRORCORECTION1284797 :refer to page 302.
            Holder = ONLYMULnODE.CopyLinkList();
            AddToTree.Tree Current = new AddToTree.Tree(null, false);
            AddToTreeTreeLinkList MulatedMul = new AddToTreeTreeLinkList();
            AddToTree.Tree Factors = null;
            while (!(Holder.ISEmpty()))
            {
                Current = Holder.DELETEFromTreeFirstNode();
                //ERRORCORCTION827346 :Refer to page 302.
                //ERROR715540         :Refer to page 302.
                MULATEDELEMENTS = FactorActivation.GetMultedElements(Current, ref UIS);

                AddToTreeTreeLinkList DummyConsiderationCopy = new AddToTreeTreeLinkList();
                DummyConsiderationCopy = ONLYMULnODE.CopyLinkList();

                AddToTreeTreeLinkList DummyConsideration = new AddToTreeTreeLinkList();
                DummyConsideration = ONLYMULnODE.CopyLinkList();

                AddToTree.Tree EveryMulatedElementsConsideration = new AddToTree.Tree(null, false);

                while (!(MULATEDELEMENTS.ISEmpty()))
                {
                    DummyConsideration = DummyConsiderationCopy.CopyLinkList();
                    EveryMulatedElementsConsideration = MULATEDELEMENTS.DELETEFromTreeFirstNode();
                    //bool IsFactor = false;
                    float Num = 0;
                    if (EveryMulatedElementsConsideration.SampleAccess != null)
                        if ((IS.IsMinusAndPluseFirstNode(Dummy)) && (IS.ExistElementOnAllMulatedNodes(EveryMulatedElementsConsideration, DummyConsideration, ref UIS)) && (IS.IsNotUpperPowerOfNodeInList(EveryMulatedElementsConsideration, AbledFactors.CopyLinkList(), ref Num)) && (!(AbledFactors.FINDTreeWithOutThreadConsideration(EveryMulatedElementsConsideration))))
                        {
                            Factors = EveryMulatedElementsConsideration;
                            AbledFactors.ADDToTree(Factors);
                        }
                }
            }
            return AbledFactors;
        }
        static public AddToTreeTreeLinkList GetMultedElements(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            AddToTreeTreeLinkList HOLDER = new AddToTreeTreeLinkList();
            try
            {
                if (Dummy.SampleAccess != "*")
                    HOLDER.ADDToTree(Dummy);
                else//ERRORCORECTION912847 :refer to page 302.
                    while (!((Dummy.LeftSideAccess == null) && (Dummy.RightSideAccess == null)))
                    {
                        //ERROCORECTION172487 ;the non copy strategy cused to invalid result(effection of To be "1").refer to page 302.
                        if (Dummy.LeftSideAccess.SampleAccess != "*")
                        //    if (!(HOLDER.FINDTreeWithOutThreadConsideration(Dummy.LeftSideAccess)))
                        {
                            HOLDER.ADDToTree(Dummy.CopyNewTree(Dummy.LeftSideAccess));
                            Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.LeftSideAccess.SampleAccess = "1";
                        }
                        if (Dummy.RightSideAccess.SampleAccess != "*")
                        //  if (!(HOLDER.FINDTreeWithOutThreadConsideration(Dummy.RightSideAccess)))
                        {
                            HOLDER.ADDToTree(Dummy.CopyNewTree(Dummy.RightSideAccess));
                            Dummy.RightSideAccess.SetLefTandRightCommonlySide(null, null);
                            Dummy.RightSideAccess.SampleAccess = "1";
                        }
                        Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

                    }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return HOLDER;
        }
        static bool SuitableForFactorActivation(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (Dummy.SampleAccess == "/")
                Is = true;
            Is = Is || FactorActivation.SuitableForFactorActivation(Dummy.LeftSideAccess);
            Is = Is || FactorActivation.SuitableForFactorActivation(Dummy.RightSideAccess);
            return Is;
        }
    }
}
