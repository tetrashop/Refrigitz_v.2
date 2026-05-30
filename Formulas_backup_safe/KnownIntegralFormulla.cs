using System;

namespace Formulas
{
    static public class KnownIntegralFormulla
    {
        static public AddToTree.Tree KnownIntegralFormullaFx(AddToTree.Tree Dummy)
        {
            try
            {
                if ((Dummy.LeftSideAccess != null) && (Dummy.RightSideAccess != null) && (IS.IsNumber(Dummy.LeftSideAccess.SampleAccess)) && (Dummy.SampleAccess == "/") && (Dummy.RightSideAccess.SampleAccess == "x"))
                {
                    AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                    Ln.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.RightSideAccess), null);
                    Ln.LeftSideAccess.ThreadAccess = Ln;


                    Ln.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess), Ln.CopyNewTree(Ln));
                    Ln.LeftSideAccess.ThreadAccess = Ln;
                    Ln.RightSideAccess.ThreadAccess = Ln;
                    Ln.SampleAccess = "*";

                    Dummy = Ln;
                }
                else
                    if ((Dummy.LeftSideAccess.SampleAccess.ToLower() == "x") && (Dummy.RightSideAccess == null) && (Dummy.SampleAccess.ToLower() == "ln"))
                {
                    AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                    AddToTree.Tree X = new AddToTree.Tree("X", false);

                    Ln.SetLefTandRightCommonlySide(X.CopyNewTree(X), null);
                    Ln.LeftSideAccess.ThreadAccess = Ln;


                    Ln.SetLefTandRightCommonlySide(X.CopyNewTree(X), Ln.CopyNewTree(Ln));
                    Ln.LeftSideAccess.ThreadAccess = Ln;
                    Ln.RightSideAccess.ThreadAccess = Ln;
                    Ln.SampleAccess = "*";

                    Ln.SetLefTandRightCommonlySide(Ln.CopyNewTree(Ln), X);
                    Ln.LeftSideAccess.ThreadAccess = Ln;
                    Ln.RightSideAccess.ThreadAccess = Ln;
                    Ln.SampleAccess = "-";

                    Dummy = Ln;
                }
                else
                    if (true)
                {
                    Dummy = null;
                }
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); Dummy = null; }
            return Dummy;
        }
    }
}
