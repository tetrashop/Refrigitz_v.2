//ERRORCORECTION6465464654:The Sigle Statment Recursive Integral Solved:1394/1/31
using System;

namespace Formulas
{
    static class EqualToObject
    {
        static AddToTreeTreeLinkList Answer1 = null;
        static AddToTreeTreeLinkList Answer2 = null;
        static AddToTreeTreeLinkList Answer1Recrve = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList Answer2Recrve = new AddToTreeTreeLinkList();
        static public bool IsEqualWithThreadConsiderationCommonly(AddToTree.Tree T1, AddToTree.Tree T2)
        {
            bool Is = false;
            if ((T1 == null) && (T2 == null))
                return true;
            else
                if (!(((T1 != null) && (T2 != null))))
                return false;
            try
            {
                //if ((T1.SampleAccess == T2.SampleAccess)&&(T1.NodeNumberAccess==T2.NodeNumberAccess))            
                if (T1.SampleAccess == T2.SampleAccess)
                {
                    if ((T1.ThreadAccess == null) && (T2.ThreadAccess == null))
                        Is = true;
                    else
                        if (!(((T1.ThreadAccess != null) && (T2.ThreadAccess != null))))
                        Is = false;
                    else
                            if (T1.ThreadAccess.SampleAccess == T2.ThreadAccess.SampleAccess)
                        Is = true;
                }
                else
                    Is = false;
            }
            catch (NullReferenceException t)
            {
                ExceptionClass.ExceptionClassMethod(t);
            }
            if (!Is)
                return Is;
            Is = Is && EqualToObject.IsEqualWithThreadConsiderationCommonly(T1.LeftSideAccess, T2.LeftSideAccess);
            Is = Is && EqualToObject.IsEqualWithThreadConsiderationCommonly(T1.RightSideAccess, T2.RightSideAccess);

            return Is;
        }
        static public bool IsEqualWithOutThreadConsiderationCommonly(AddToTree.Tree T1, AddToTree.Tree T2)
        {
            bool Is = false;
            if ((T1 == null) && (T2 == null))
                return true;
            else
                if (!(((T1 != null) && (T2 != null))))
                return false;
            try
            {
                //if ((T1.SampleAccess == T2.SampleAccess)&&(T1.NodeNumberAccess==T2.NodeNumberAccess))            
                if (T1.SampleAccess == T2.SampleAccess)
                    Is = true;
                else
                    if (IS.IsNumber(T1.SampleAccess) && IS.IsNumber(T2.SampleAccess) && (System.Math.Abs(System.Convert.ToDouble(T1.SampleAccess) - System.Convert.ToDouble(T2.SampleAccess)) < 0.001))
                    Is = true;
                else
                    Is = false;
            }
            catch (NullReferenceException t)
            {
                ExceptionClass.ExceptionClassMethod(t);
            }
            Is = Is && EqualToObject.IsEqualWithThreadConsiderationCommonly(T1.LeftSideAccess, T2.LeftSideAccess);
            Is = Is && EqualToObject.IsEqualWithThreadConsiderationCommonly(T1.RightSideAccess, T2.RightSideAccess);

            return Is;
        }
        static public bool IsEqualWithOutThreadConsiderationByDivision(AddToTree.Tree T1, AddToTree.Tree T2, ref UknownIntegralSolver UIS)
        {

            bool Is = false;
            AddToTree.Tree Code = new AddToTree.Tree("/", false);
            Code.SetLefTandRightCommonlySide(T1.CopyNewTree(T1), T2.CopyNewTree(T2));
            try
            {
                Code.LeftSideAccess.ThreadAccess = Code;
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            try
            {
                Code.RightSideAccess.ThreadAccess = Code;
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

            Code = Simplifier.SimplifierFx(Code, ref UIS);



            if ((Code.SampleAccess == "1") && (Code.LeftSideAccess == null) && (Code.RightSideAccess == null))
                Is = true;

            return Is;
        }
        static public bool IsEqualWithOutThreadConsiderationByDivision(AddToTree.Tree T1, AddToTree.Tree T2, ref UknownIntegralSolver UIS, ref float Quficient)
        {
            bool Is = false;
            try
            {
                AddToTree.Tree Code = new AddToTree.Tree("/", false);

                T2 = Simplifier.SimplifierFx(T2, ref UIS);
                Answer1 = new AddToTreeTreeLinkList();
                Answer2 = new AddToTreeTreeLinkList();

                Answer1.CreateLinkListFromTree1(T2);
                Answer2.CreateLinkListFromTree1(T1);

                //                Answer1Recrve.CreateLinkListFromTree2(T2);
                //              Answer2Recrve.CreateLinkListFromTree2(UIS.Enterface.SenderAccess.AutoSenderAccess.NodeAccess.CopyNewTree(UIS.Enterface.SenderAccess.AutoSenderAccess.NodeAccess));


                if (Answer2.Node.EqualLinkList(Answer1.Node))//ERRORCORECTION6465464654:The Sigle Statment Recursive Integral Solved:1394/1/31
                {
                    if (IS.IsNumber(T2.LeftSideAccess.SampleAccess) && IS.IsNumber(T1.LeftSideAccess.SampleAccess))
                    {
                        if (Integral.IntegralSignPositive)
                            Quficient = (float)(System.Convert.ToDouble(T1.CopyNewTree(T1).SampleAccess) - Quficient * System.Convert.ToDouble(T2.LeftSideAccess.SampleAccess));
                        else
                            Quficient = (float)(System.Convert.ToDouble(T1.CopyNewTree(T1).SampleAccess) + Quficient * System.Convert.ToDouble(T2.LeftSideAccess.SampleAccess));

                        Is = true;
                    }
                    else
                        if (IS.IsNumber(T2.LeftSideAccess.SampleAccess))
                    {
                        if (Integral.IntegralSignPositive)
                            Quficient = (float)(1.0 - Quficient * System.Convert.ToDouble(T2.LeftSideAccess.SampleAccess));
                        else
                            Quficient = (float)(1.0 + Quficient * System.Convert.ToDouble(T2.LeftSideAccess.SampleAccess));

                        Is = true;
                    }


                }

                if (!Is)
                    if (Answer2.Node.EqualLinkList2(Answer1.Node))//ERRORCORECTION6465464654:The Sigle Statment Recursive Integral Solved:1394/1/31
                    {

                        if (IS.IsNumber(T2.SampleAccess) && IS.IsNumber(T1.LeftSideAccess.SampleAccess))
                        {
                            if (Integral.IntegralSignPositive)
                                Quficient = (float)(System.Convert.ToDouble(T1.CopyNewTree(T1).SampleAccess) - Quficient * System.Convert.ToDouble(T2.SampleAccess));
                            else
                                Quficient = (float)(System.Convert.ToDouble(T1.CopyNewTree(T1).SampleAccess) + Quficient * System.Convert.ToDouble(T2.SampleAccess));

                            Is = true;
                        }
                        else
                            if (!IS.IsNumber(T2.SampleAccess))
                        {
                            if (Integral.IntegralSignPositive)
                                Quficient = (float)(1.0 - Quficient);
                            else
                                Quficient = (float)(1.0 + Quficient);

                            Is = true;
                        }


                    }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Is;
        }
    }
}

