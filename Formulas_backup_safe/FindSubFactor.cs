//LOCATION3070405000 :refer to page 300.
//=======================================================
//ERRORCORECTION1287648764 :The condition caused to  Non Requirment Supliments of data.rerefgt oa peg 328.
//=======================================================
//ERRORCORECTION98127489 :refer to page 328.
//=======================================================
//ERRORGESSESSADDED8127466 :refer to page 328.
//=======================================================
//ERRORCORECTION892374978 :Refer to page 330.
//=======================================================
using System;

namespace Formulas
{
    static class FindSubFactor
    {
        static AddToTreeTreeLinkList FACTORLISTEDS = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList COMMONFACTORS = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList NOTEXPECTED = new AddToTreeTreeLinkList();
        static public AddToTreeTreeLinkList FindSubFactorFx(AddToTree.Tree Dummy1, AddToTree.Tree Dummy2)
        {
            while (!(FACTORLISTEDS.ISEmpty()))
                FACTORLISTEDS.DELETEFromTreeFirstNode();
            while (!(COMMONFACTORS.ISEmpty()))
                COMMONFACTORS.DELETEFromTreeFirstNode();
            while (!(NOTEXPECTED.ISEmpty()))
                NOTEXPECTED.DELETEFromTreeFirstNode();
            FindSubFactor.FindSubFactorActionFx(Dummy1, Dummy2);
            return COMMONFACTORS;
        }
        static public AddToTreeTreeLinkList NotExpectedAccess()
        {
            return NOTEXPECTED;
        }
        static public AddToTreeTreeLinkList FACTORLISTEDSAccess()
        {
            return FACTORLISTEDS;
        }
        static void FindSubFactorActionFx(AddToTree.Tree Dummy1, AddToTree.Tree Dummy2)
        {
            FindSubFactor.FindSubFactorCommonAddedToListFx(Dummy1);
            //ERRORCORECTION1287648764 :The condition caused to  Non Requirment Supliments of data.
            //if(Dummy2.SampleAccess == "*")
            FindSubFactor.FindSubFactorCommonFinalizationFx(Dummy2);
        }
        static void FindSubFactorCommonAddedToListFx(AddToTree.Tree Dummy1)
        {
            if (Dummy1 == null)
                return;
            //ERRORGESSESSADDED8127466 :refer to page 328.
            //ERRORCORECTION892374978 :Refer to page 330.
            if ((!(IS.IsMulInNode(Dummy1))) && (FACTORLISTEDS.ISEmpty()))
            {
                if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1)))
                    FACTORLISTEDS.ADDToTree(Dummy1);
            }
            try
            {
                if (Dummy1.SampleAccess == "*")
                {
                    //if ((!(IS.IsNumber(Dummy1.LeftSideAccess.SampleAccess))) && (Dummy1.LeftSideAccess.SampleAccess != "*"))
                    //{
                    //if (!IS.IsMulInNode(Dummy1.LeftSideAccess))
                    if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1.LeftSideAccess)))
                        FACTORLISTEDS.ADDToTree(Dummy1.LeftSideAccess);
                    if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1.LeftSideAccess)))
                        if (Dummy1.LeftSideAccess.SampleAccess == "^")
                            if (IS.IsNumber(Dummy1.LeftSideAccess.RightSideAccess.SampleAccess))
                                //if (!IS.IsMulInNode(Dummy1.LeftSideAccess.LeftSideAccess))
                                if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1.LeftSideAccess.LeftSideAccess)))
                                    FACTORLISTEDS.ADDToTree(Dummy1.LeftSideAccess.LeftSideAccess);
                    //}
                    //if ((!(IS.IsNumber(Dummy1.RightSideAccess.SampleAccess))) && (Dummy1.RightSideAccess.SampleAccess != "*"))
                    //{
                    //if (!IS.IsMulInNode(Dummy1.RightSideAccess))
                    if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1.RightSideAccess)))
                        FACTORLISTEDS.ADDToTree(Dummy1.RightSideAccess);
                    if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1.RightSideAccess)))
                        if (Dummy1.RightSideAccess.SampleAccess == "^")
                            if (IS.IsNumber(Dummy1.RightSideAccess.RightSideAccess.SampleAccess))
                                //if (!IS.IsMulInNode(Dummy1.RightSideAccess.LeftSideAccess))
                                if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy1.RightSideAccess.LeftSideAccess)))
                                    FACTORLISTEDS.ADDToTree(Dummy1.RightSideAccess.LeftSideAccess);
                    //}
                }
                FindSubFactor.FindSubFactorCommonAddedToListFx(Dummy1.LeftSideAccess);
                FindSubFactor.FindSubFactorCommonAddedToListFx(Dummy1.RightSideAccess);
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }

        }
        static void FindSubFactorCommonFinalizationFx(AddToTree.Tree Dummy2)
        {
            if (Dummy2 == null)
                return;
            if ((Dummy2.SampleAccess == "+") || (Dummy2.SampleAccess == "-"))
                if (!(FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2)))
                {
                    NOTEXPECTED.ADDToTree(Dummy2);
                    return;
                }
            try
            {
                //ADDEDCONDTITION9281374 :Refer to page 328.
                //ERRORCORECTION98127489 :refer to page 328.
                //ERRORCORECTION892374978 :Refer to page 330.
                if ((!(IS.IsMulInNode(Dummy2))) && (COMMONFACTORS.ISEmpty()))
                {
                    if ((FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2)) && (!(COMMONFACTORS.FINDTreeWithOutThreadConsideration(Dummy2))))
                    {
                        COMMONFACTORS.ADDToTree(Dummy2);
                        //LOCATION3070405000 :refer to page 300.
                        FACTORLISTEDS.DELETEFromTreeFindedNode(Dummy2);
                        NOTEXPECTED.DELETEFromTreeFindedNode(Dummy2);
                    }
                    else
                        if ((Dummy2.SampleAccess == "^") && (IS.IsNumber(Dummy2.RightSideAccess.RightSideAccess.SampleAccess)) && ((FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2.RightSideAccess.LeftSideAccess))) && (!(COMMONFACTORS.FINDTreeWithOutThreadConsideration(Dummy2.LeftSideAccess))))
                    {
                        COMMONFACTORS.ADDToTree(Dummy2.LeftSideAccess);
                        FACTORLISTEDS.DELETEFromTreeFindedNode(Dummy2.LeftSideAccess);
                        NOTEXPECTED.DELETEFromTreeFindedNode(Dummy2.LeftSideAccess);
                    }
                    else
                        NOTEXPECTED.ADDToTree(Dummy2);
                }
                if (Dummy2.SampleAccess == "*")
                {
                    //if (!IS.IsNumber(Dummy2.LeftSideAccess.SampleAccess))
                    //{                        
                    if ((!(COMMONFACTORS.FINDTreeWithOutThreadConsideration(Dummy2.LeftSideAccess))) && (FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2.LeftSideAccess)))
                    {
                        COMMONFACTORS.ADDToTree(Dummy2.LeftSideAccess);
                        FACTORLISTEDS.DELETEFromTreeFindedNode(Dummy2.LeftSideAccess);
                        NOTEXPECTED.DELETEFromTreeFindedNode(Dummy2.LeftSideAccess);
                    }
                    else
                        if ((Dummy2.LeftSideAccess.SampleAccess == "^") && (IS.IsNumber(Dummy2.LeftSideAccess.RightSideAccess.SampleAccess)) && ((FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2.LeftSideAccess.LeftSideAccess))) && (!(COMMONFACTORS.FINDTreeWithOutThreadConsideration(Dummy2.LeftSideAccess.LeftSideAccess))))
                    {
                        COMMONFACTORS.ADDToTree(Dummy2.LeftSideAccess.LeftSideAccess);
                        FACTORLISTEDS.DELETEFromTreeFindedNode(Dummy2.LeftSideAccess.LeftSideAccess);
                        NOTEXPECTED.DELETEFromTreeFindedNode(Dummy2.LeftSideAccess.LeftSideAccess);
                    }
                    else
                        NOTEXPECTED.ADDToTree(Dummy2.LeftSideAccess);
                    //}
                    //if (!IS.IsNumber(Dummy2.RightSideAccess.SampleAccess))
                    //{
                    if ((FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2.RightSideAccess)) && (!(COMMONFACTORS.FINDTreeWithOutThreadConsideration(Dummy2.RightSideAccess))))
                    {
                        COMMONFACTORS.ADDToTree(Dummy2.RightSideAccess);
                        //LOCATION3070405000 :refer to page 300.
                        FACTORLISTEDS.DELETEFromTreeFindedNode(Dummy2.RightSideAccess);
                        NOTEXPECTED.DELETEFromTreeFindedNode(Dummy2.RightSideAccess);
                    }
                    else
                    if ((Dummy2.RightSideAccess.SampleAccess == "^") && (IS.IsNumber(Dummy2.RightSideAccess.RightSideAccess.SampleAccess)) && ((FACTORLISTEDS.FINDTreeWithOutThreadConsideration(Dummy2.RightSideAccess.LeftSideAccess))) && (!(COMMONFACTORS.FINDTreeWithOutThreadConsideration(Dummy2.RightSideAccess.LeftSideAccess))))
                    {
                        COMMONFACTORS.ADDToTree(Dummy2.RightSideAccess.LeftSideAccess);
                        FACTORLISTEDS.DELETEFromTreeFindedNode(Dummy2.RightSideAccess.LeftSideAccess);
                        NOTEXPECTED.DELETEFromTreeFindedNode(Dummy2.RightSideAccess.LeftSideAccess);
                    }
                    else
                        NOTEXPECTED.ADDToTree(Dummy2.RightSideAccess);
                    //  }
                }
                FindSubFactor.FindSubFactorCommonFinalizationFx(Dummy2.LeftSideAccess);
                FindSubFactor.FindSubFactorCommonFinalizationFx(Dummy2.RightSideAccess);
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
        }
    }
}
