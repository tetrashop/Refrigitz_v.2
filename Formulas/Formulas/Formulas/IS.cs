using System;

namespace Formulas
{
    static class IS
    {
        static public bool IsMulInNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (Dummy.SampleAccess == "*")
                Is = true;
            Is = Is || IS.IsMulInNode(Dummy.LeftSideAccess);
            Is = Is || IS.IsMulInNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool ReterunIfIsNumberNode(AddToTree.Tree Dummy, ref AddToTree.Tree Number)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (IS.IsNumber(Dummy.SampleAccess))
            {
                Is = true;
                Number = Dummy;
            }
            Is = Is || ReterunIfIsNumberNode(Dummy.LeftSideAccess, ref Number);
            Is = Is || ReterunIfIsNumberNode(Dummy.RightSideAccess, ref Number);
            return Is;
        }
        static public bool ReterunIfIsPlusNode(AddToTree.Tree Dummy, ref AddToTree.Tree[] Plus, ref int Len)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (IS.IsPluse(Dummy.SampleAccess))
            {
                Is = true;
                Plus[Len] = Dummy;
                Len++;
            }
            Is = Is || ReterunIfIsPlusNode(Dummy.LeftSideAccess, ref Plus, ref Len);
            Is = Is || ReterunIfIsPlusNode(Dummy.RightSideAccess, ref Plus, ref Len);
            return Is;
        }
        static public bool IsMulAllNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return true;
            bool Is = true;
            if (((Dummy.SampleAccess != "*") && (Dummy.SampleAccess != "^")) && (IS.IsOperator(Dummy.SampleAccess)))
                Is = false;
            Is = Is && IS.IsMulAllNode(Dummy.LeftSideAccess);
            Is = Is && IS.IsMulAllNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool IsPlusOrMulAllNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return true;
            bool Is = true;
            if (((Dummy.SampleAccess != "+") && (Dummy.SampleAccess != "^") || (Dummy.SampleAccess != "*")) && IS.IsOperator(Dummy.SampleAccess))
                Is = false;
            Is = Is && IS.IsPlusOrMulAllNode(Dummy.LeftSideAccess);
            Is = Is && IS.IsPlusOrMulAllNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool IsZeroNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (Dummy.SampleAccess == "0")
                Is = true;
            Is = Is || IS.IsZeroNode(Dummy.LeftSideAccess);
            Is = Is || IS.IsZeroNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool IsPluSinNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (Dummy.SampleAccess == "+")
                Is = true;
            Is = Is || IS.IsPluSinNode(Dummy.LeftSideAccess);
            Is = Is || IS.IsPluSinNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool IsNotUpperPowerOfNodeInList(AddToTree.Tree Dummy, AddToTreeTreeLinkList AbaledFactors, ref float PowerExsistNumber)
        {
            bool Is = false;
            AddToTree.Tree AbaledNode = new AddToTree.Tree(null, false);
            bool OPERATION = false;
            while (!(AbaledFactors.ISEmpty()))
            {
                AbaledNode = AbaledFactors.DELETEFromTreeFirstNode();
                if (AbaledNode.SampleAccess == "^")
                    if (Dummy.SampleAccess == "^")
                        if (IS.IsNumber(Dummy.RightSideAccess.SampleAccess))
                            if (IS.IsNumber(AbaledNode.RightSideAccess.SampleAccess))
                                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy.LeftSideAccess, AbaledNode.LeftSideAccess))
                                {
                                    float NumDummy = (float)(System.Convert.ToDouble(Dummy.RightSideAccess.SampleAccess));
                                    float NumAbaled = (float)(System.Convert.ToDouble(AbaledNode.RightSideAccess.SampleAccess));
                                    if (NumAbaled < NumDummy)
                                        Is = true;
                                    PowerExsistNumber = NumAbaled;
                                    OPERATION = true;
                                    break;
                                }
            }
            if (AbaledFactors.ISEmpty() || (!OPERATION))
                Is = true;
            return Is;

        }
        static public bool ExistElementOnAllMulatedNodes(AddToTree.Tree Dummy, AddToTreeTreeLinkList Consideration, ref UknownIntegralSolver UIS)
        {
            bool Is = true;
            AddToTreeTreeLinkList MULATEDELEMENTS = new AddToTreeTreeLinkList();
            while (!(Consideration.ISEmpty()))
            {
                MULATEDELEMENTS = FactorActivation.GetMultedElements(Consideration.DELETEFromTreeFirstNode(), ref UIS);
                Is = Is && (IS.ExistElementOnAllMulatedNodesAction(Dummy, MULATEDELEMENTS));
            }
            return Is;
        }
        static bool ExistElementOnAllMulatedNodesAction(AddToTree.Tree Dummy, AddToTreeTreeLinkList MULATEDELEMENTS)
        {
            bool Is = false;
            AddToTree.Tree MuLnode = new AddToTree.Tree(null, false);
            while (!(MULATEDELEMENTS.ISEmpty()))
            {
                MuLnode = MULATEDELEMENTS.DELETEFromTreeFirstNode();
                if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Dummy, MuLnode))
                {
                    Is = true;
                    break;
                }
            }
            return Is;
        }
        static public bool IsNotMinusAndPluseInNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return true;
            bool Is = true;
            if (Dummy.SampleAccess == "+")
                Is = false;
            if (Dummy.SampleAccess == "-")
                Is = false;
            //ERRORCORECTIO289374 :Refer to page 302
            Is = Is && IS.IsNotMinusAndPluseInNode(Dummy.LeftSideAccess);
            Is = Is && IS.IsNotMinusAndPluseInNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool IsDivInNode(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return false;
            bool Is = false;
            if (Dummy.SampleAccess == "/")
                Is = true;
            //ERRORCORECTIO289374 :Refer to page 302
            Is = Is || IS.IsDivInNode(Dummy.LeftSideAccess);
            Is = Is || IS.IsDivInNode(Dummy.RightSideAccess);
            return Is;
        }
        static public bool IsMinusAndPluseFirstNode(AddToTree.Tree Dummy)
        {
            bool Is = false;
            if (Dummy.SampleAccess == "+")
                Is = true;
            if (Dummy.SampleAccess == "-")
                Is = true;
            //ERRORCORECTIO289374 :Refer to page 302
            return Is;
        }
        static public bool IsMinuseOrPluse(String Sample)
        {
            bool IsMinuseOrPluse = false;
            if (Sample != null)
            {
                if (Sample.ToString() == "+")
                    IsMinuseOrPluse = true;
                else
                    if (Sample.ToString() == "-")
                    IsMinuseOrPluse = true;
            }
            return IsMinuseOrPluse;
        }
        static public bool IsPluse(String Sample)
        {
            bool IsPluse = false;
            if (Sample != null)
                if (Sample.ToString() == "+")
                    IsPluse = true;
            return IsPluse;
        }
        static public bool IsMulOrDiv(String Sample)
        {
            bool IsMulOrDiv = false;
            if (Sample != null)
            {
                if (Sample.ToString() == "*")
                    IsMulOrDiv = true;
                else
                    if (Sample.ToString() == "/")
                    IsMulOrDiv = true;
            }
            return IsMulOrDiv;
        }
        static public bool IsDiv(String Sample)
        {
            bool IsDiv = false;
            if (Sample != null)
                if (Sample.ToString() == "/")
                    IsDiv = true;
            return IsDiv;
        }
        static public bool IsMul(String Sample)
        {
            bool IsMul = false;
            if (Sample != null)
                if (Sample.ToString() == "*")
                    IsMul = true;

            return IsMul;
        }
        static public bool IsOperator(String Sample)
        {
            bool IsOperator = false;
            try
            {
                if (Sample != null)
                {
                    if (Sample.ToString() == "+")
                        IsOperator = true;
                    else
                        if (Sample.ToString() == "-")
                        IsOperator = true;
                    else
                            if (Sample.ToString() == "*")
                        IsOperator = true;
                    else
                                if (Sample.ToString() == "/")
                        IsOperator = true;
                    else
                                    if (Sample.ToString().ToLower() == "pow")
                        IsOperator = true;
                    else
                                        if (Sample.ToString().ToLower() == "^")
                        IsOperator = true;
                }
            }
            catch (StackOverflowException t)
            { ExceptionClass.ExceptionClassMethod(t); }

            return IsOperator;
        }
        static public bool ISindependenceVaribaleOrNumber(String Sample)
        {
            bool ISindePendenceVariableOrNumber = false;
            if (Sample != null)
            {
                if (IS.ISindependenceVaribale(Sample))
                    ISindePendenceVariableOrNumber = true;
                if (IS.IsNumber(Sample))
                    ISindePendenceVariableOrNumber = true;
            }
            return ISindePendenceVariableOrNumber;
        }
        static public bool IsFunction(String Sample)
        {
            bool IsFunction = false;
            if (Sample != null)
            {
                if (Sample.ToString().ToLower() == "sin")
                    IsFunction = true;
                else
                    if (Sample.ToString().ToLower() == "cos")
                    IsFunction = true;
                else
                        if (Sample.ToString().ToLower() == "tan")
                    IsFunction = true;
                else
                            if (Sample.ToString().ToLower() == "cot")
                    IsFunction = true;
                else
                                if (Sample.ToString().ToLower() == "sec")
                    IsFunction = true;
                else
                                    if (Sample.ToString().ToLower() == "csc")
                    IsFunction = true;
                else
                                        if (Sample.ToString().ToLower() == "log")
                    IsFunction = true;
                else
                                            if (Sample.ToString().ToLower() == "ln")
                    IsFunction = true;
                if (Sample.ToString().ToLower() == "root")
                    IsFunction = true;
            }
            return IsFunction;
        }
        static public bool IsNumber(String Sample)
        {
            bool IsNumber = false;
            if (Sample != null)
            {
                //ERRORCORECTION89764567 :The condition of being parantez added
                if ((!IS.IsFunction(Sample)) && (!IS.IsOperator(Sample)) && (!IS.ISindependenceVaribale(Sample)) && (!IS.IsParantez(Sample)) && (!IS.IsEqualWithThreadConsiderationCommonlySample(Sample)) && (Sample.ToLower() != "c"))
                    IsNumber = true;
            }
            return IsNumber;
        }
        static public bool IsNumberNegative(String Sample)
        {
            bool NumberNegative = false;
            if (Sample != null)
            {
                //ERRORCORECTION89764567 :The condition of being parantez added
                if ((!IS.IsFunction(Sample)) && (!IS.IsOperator(Sample)) && (!IS.ISindependenceVaribale(Sample)) && (!IS.IsParantez(Sample)) && (!IS.IsEqualWithThreadConsiderationCommonlySample(Sample)) && (Sample.ToLower() != "c"))
                    NumberNegative = true;
                if (NumberNegative && System.Convert.ToDouble(Sample) < 0)
                    NumberNegative = true;
                else if (NumberNegative && System.Convert.ToDouble(Sample) >= 0)
                    NumberNegative = false;
            }
            return NumberNegative;
        }
        static public bool IsParantez(String Sample)
        {
            //ERRORCORECTION896709487 : it is like a number ERROR73425362.The problem solved.
            bool IsPrantez = false;
            if (Sample != null)
                if ((Sample.ToString() == "()") || (Sample.ToString() == "(") || (Sample.ToString() == ")"))
                    IsPrantez = true;
            return IsPrantez;
        }
        static public bool IsPower(String Sample)
        {
            bool Is = false;
            if (Sample == "^")
                Is = true;
            return Is;
        }

        static private bool IsEqualWithThreadConsiderationCommonlySample(String Sample)
        {
            bool Is = false;
            if (Sample == "=")
                Is = true;
            else
                Is = false;
            return Is;

        }
        static public bool ISindependenceVaribale(String Sample)
        {
            bool ISindePendenceVariable = false;
            if (Sample != null)
            {
                if (Sample.ToString().ToLower() == "x")
                    ISindePendenceVariable = true;
                else
                    ISindePendenceVariable = false;
            }
            return ISindePendenceVariable;
        }


    }
}
