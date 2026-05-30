using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas
{
    static class CTOZero
    {
        static public AddToTree.Tree COnvertCToZeroFx(AddToTree.Tree Dummy)
        {
            return CTOZero.COnvertCToZeroAction(Dummy);
        }
        static AddToTree.Tree COnvertCToZeroAction(AddToTree.Tree Dummy)
        {
            if (Dummy == null)
                return Dummy;
            try
            {
                if (Dummy.SampleAccess.ToLower() == "c")
                    Dummy.SampleAccess = null;
            }
            catch (NullReferenceException t)
            { }
            CTOZero.COnvertCToZeroAction(Dummy.LeftSideAccess);
            CTOZero.COnvertCToZeroAction(Dummy.RightSideAccess);
            return Dummy;
        }
    }
}
