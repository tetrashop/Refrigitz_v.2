namespace Formulas
{
    static class AddingDivisionToThreeDivStructure
    {
        static public AddToTree.Tree AddingDivisionToThreeDivStructureFx(AddToTree.Tree Dummy)
        {
            Dummy = AddingDivisionToThreeDivStructure.AddingDivisionToThreeDivStructureActionFx(Dummy);
            return Dummy;
        }
        static AddToTree.Tree AddingDivisionToThreeDivStructureActionFx(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            if (Dummy.SampleAccess == "/")
            {
                if (Dummy.LeftSideAccess.SampleAccess == "/")
                    if (Dummy.RightSideAccess.SampleAccess != "/")
                    {
                        AddToTree.Tree Div = new AddToTree.Tree("/", false);
                        AddToTree.Tree One = new AddToTree.Tree("1", false);
                        Div.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess), One);
                        Div.LeftSideAccess.ThreadAccess = Div;
                        Div.RightSideAccess.ThreadAccess = Div;
                        Div.ThreadAccess = Dummy;
                        Dummy.RightSideAccess = Div;
                    }
                if (Dummy.LeftSideAccess.SampleAccess != "/")
                    if (Dummy.RightSideAccess.SampleAccess == "/")
                    {
                        AddToTree.Tree Div = new AddToTree.Tree("/", false);
                        AddToTree.Tree One = new AddToTree.Tree("1", false);
                        Div.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess), One);
                        Div.LeftSideAccess.ThreadAccess = Div;
                        Div.RightSideAccess.ThreadAccess = Div;
                        Div.ThreadAccess = Dummy;
                        Dummy.LeftSideAccess = Div;
                    }

            }
            Dummy.LeftSideAccess = AddingDivisionToThreeDivStructure.AddingDivisionToThreeDivStructureActionFx(Dummy.LeftSideAccess);
            Dummy.RightSideAccess = AddingDivisionToThreeDivStructure.AddingDivisionToThreeDivStructureActionFx(Dummy.RightSideAccess);
            return Dummy;
        }
    }
}
