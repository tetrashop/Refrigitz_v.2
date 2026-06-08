//LOCATION81726487 :refer to page 265.using System;
//=====================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas
{
    static class LocalSearchMinusPlusNonEqualSimplifier
    {
        static public AddToTree.Tree LocalSearchMinusPlusNonEqualSimplifierFx(AddToTree.Tree Dummy)        
        {
        return LocalSearchMinusPlusNonEqualSimplifier.LocalSearchMinusPlusNonEqualSimplifierActionFx(Dummy);
        }
        static AddToTree.Tree LocalSearchMinusPlusNonEqualSimplifierActionFx(AddToTree.Tree Dummy)        
        {
            if (Dummy == null)
                return Dummy;
            LocalSearchMinusPlusNonEqualSimplifier.LocalSearchMinusPlusNonEqualSimplifierActionFx(Dummy.LeftSideAccess);
            LocalSearchMinusPlusNonEqualSimplifier.LocalSearchMinusPlusNonEqualSimplifierActionFx(Dummy.RightSideAccess);


        }
        static AddToTree.Tree SetMinuseToPlusAndPluseToMinuse(AddToTree.Tree Dummy)
        {
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse)
        {
        }
        static AddToTree.Tree SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(AddToTree.Tree Dummy, AddToTree.Tree ToSimplified, out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse)
        {            
        }
    }
    
}
