namespace Formulas
{
    static class IntegralRecursiveMulatFG
    {
        static public bool IntegralRecursiveMulatFGFx(AddToTreeTreeLinkList MulAtFG, AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            AddToTree.Tree HOLDER = MulAtFG.DELETEFromTreeFirstNode();
            if (Dummy != null)
                return EqualToObject.IsEqualWithOutThreadConsiderationByDivision(HOLDER.CopyNewTree(HOLDER), Dummy.CopyNewTree(Dummy), ref UIS);
            return false;
        }
        static public bool IntegralRecursiveMulatFPowerGFx(AddToTree.Tree Integral, AddToTree.Tree Dummy, ref UknownIntegralSolver UIS, ref float Queficient)
        {

            AddToTree.Tree HOLDER = new AddToTree.Tree(null, false);
            bool Istrue = false;
            /*  while(!(MulAtFG.ISEmpty()))
              {
                  HOLDER = MulAtFG.DELETEFromTreeFirstNode();

                  if (HOLDER != null)            
             */
            Istrue = EqualToObject.IsEqualWithOutThreadConsiderationByDivision(Integral, Dummy, ref UIS, ref Queficient);
            /*   else break;
                        */
            if (Istrue)
                return Istrue;

            //}
            return false;
        }
    }
}
