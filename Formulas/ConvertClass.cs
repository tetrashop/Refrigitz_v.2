using System;

namespace Formulas
{
    static class ConvertClass
    {
        public static AddToTree.Tree ConverSetToAddTreeFx(Set Dummy)
        {

            Set Holder = Dummy;
            AddToTree.Tree TreeDummy = null;
            AddToTree.Tree HolderDummy;

            HolderDummy = ConvertClass.ConverSetToAddTreeActionFx(Dummy);

            while (Dummy.ThreadAccess != null)
                Dummy = Dummy.ThreadAccess;

            TreeDummy = ConvertClass.ConverSetToAddTreeActionFx(Dummy);

            TreeDummy = TreeDummy.FINDTreeWithOutThreadConsideration(TreeDummy, HolderDummy);

            return TreeDummy;
        }
        private static AddToTree.Tree ConverSetToAddTreeActionFx(Set Dummy)
        {
            if (Dummy == null)
                return null;
            AddToTree.Tree TreeDummy = new AddToTree.Tree(null, false);
            try
            {
                TreeDummy.SampleAccess = Dummy.StringSampleAccess;
                TreeDummy.LeftSideAccess.ThreadAccess = TreeDummy;
                TreeDummy.RightSideAccess.ThreadAccess = TreeDummy;
            }
            catch (NullReferenceException T) { ExceptionClass.ExceptionClassMethod(T); }
            TreeDummy.SetLefTandRightCommonlySide(ConvertClass.ConverSetToAddTreeActionFx(Dummy.LeftSideAccess), ConvertClass.ConverSetToAddTreeActionFx(Dummy.RightSideAccess));

            return TreeDummy;
        }
    }
}
