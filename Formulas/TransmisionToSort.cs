//ERROR13107142 :This code cuased to an infinite loop.refer to page 182.
//========================================================================
//ERRORCORECTION9872423784 :The ERRORCUASE713040 Correction.refer to page 182.
//========================================================================
using System;

namespace Formulas
{
    static class TransmisionToDeleteingMinusPluse
    {
        static public AddToTree.Tree TrasmisionToDeleteingMinusPluseFx(AddToTree.Tree Dummy)
        {
            return TransmisionToDeleteingMinusPluse.TrasmisionActionHole(Dummy);
        }
        static private AddToTree.Tree TrasmisionActionHole(AddToTree.Tree Dummy)
        {
            //ERROR13107142 :This code cuased to an infinite loop.refer to page 182.
            if (Dummy == null)
                return Dummy;
            TransmisionToDeleteingMinusPluse.TrasmisionActionHole(Dummy.LeftSideAccess);
            TransmisionToDeleteingMinusPluse.TrasmisionActionHole(Dummy.RightSideAccess);
            try
            {
                bool ABLE = false;
                AddToTree.Tree CurrentObject = Dummy;
                AddToTree.Tree NODE = Dummy;
                AddToTree.Tree FIRST = Dummy;
                while ((IS.IsOperator(FIRST.SampleAccess)) && (FIRST.SampleAccess != "/") && (FIRST.SampleAccess != "^") && (FIRST.ThreadAccess != null))
                    FIRST = FIRST.ThreadAccess;

                int DeepLeft = 0;
                while ((NODE.LeftSideAccess != null) && (IS.IsOperator(NODE.SampleAccess)) && (NODE.SampleAccess != "/") && (NODE.SampleAccess != "^"))
                {
                    NODE = NODE.LeftSideAccess;
                    DeepLeft++;
                }
                //ERRORCORECTION9872423784 :The ERRORCUASE713040 Correction.refer to page 182.
                if (NODE.LeftSideAccess != null)
                    if (NODE.LeftSideAccess.LeftSideAccess != null)
                        ABLE = true;

                if (ABLE)
                    if (DeepLeft > 1)
                    {
                        AddToTree.Tree Last = NODE.CopyNewTree(NODE.ThreadAccess);

                        Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, FIRST);
                        AddToTree.Tree Holder = Dummy.RightSideAccess;
                        Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, Last.LeftSideAccess);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;

                        while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess, Last))
                            Dummy = Dummy.LeftSideAccess;
                        Dummy.LeftSideAccess = Holder;

                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        while ((Dummy.ThreadAccess != null) && (!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, CurrentObject)))
                            Dummy = Dummy.ThreadAccess;
                    }

                ABLE = false;
                NODE = Dummy;
                FIRST = Dummy;

                while ((IS.IsOperator(FIRST.SampleAccess)) && (FIRST.SampleAccess != "^") && (FIRST.SampleAccess != "/") && (FIRST.ThreadAccess != null))
                    FIRST = FIRST.ThreadAccess;

                int DeepRight = 0;
                while ((NODE.RightSideAccess != null) && (IS.IsOperator(NODE.SampleAccess)) && (NODE.SampleAccess != "/") && (NODE.SampleAccess != "^"))
                {
                    NODE = NODE.RightSideAccess;
                    DeepRight++;
                }
                //ERRORCORECTION9872423784 :The ERRORCUASE713040 Correction.refer to page 182.
                if (NODE.RightSideAccess != null)
                    if (NODE.RightSideAccess.RightSideAccess != null)
                        ABLE = false;

                if (ABLE)
                    if (DeepRight > 1)
                    {
                        AddToTree.Tree Last = NODE.CopyNewTree(NODE.ThreadAccess);
                        Dummy = Dummy.FINDTreeWithThreadConsideration(Dummy, FIRST);
                        AddToTree.Tree Holder = Dummy.LeftSideAccess;
                        Dummy.SetLefTandRightCommonlySide(Last.RightSideAccess, Dummy.RightSideAccess);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;

                        while (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.RightSideAccess, Last))
                            Dummy = Dummy.RightSideAccess;
                        Dummy.RightSideAccess = Holder;
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        while ((Dummy.ThreadAccess != null) && (!EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, CurrentObject)))
                            Dummy = Dummy.ThreadAccess;
                    }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
    }
}
