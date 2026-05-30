using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas
{
    class LocalSearchMinusPlusNonEqualSimplifier
    {
        public LocalSearchMinusPlusNonEqualSimplifier() { }
        public bool LocalSearchMinusPlusNonEqualSimplifierActionFx(AddToTree.Tree Current)
        {
            return false;
        }
        public bool SetMinuseToPlusAndPluseToMinuse(AddToTree.Tree Current)
        {
            return false;
        }
        public bool SuitableToSimplifierLocalThatToSimplifiedLocatedAtRight(
            AddToTree.Tree Current, AddToTree.Tree Current2,
            out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse)
        {
            Suitable = false;
            MinuseTruePlusFalse = false;
            SimplifiedTrueOtherWiseFalse = false;
            return false;
        }
        public bool SuitableToSimplifierLocalThatToSimplifiedLocatedAtLeft(
            AddToTree.Tree Current, AddToTree.Tree Current2,
            out bool Suitable, out bool MinuseTruePlusFalse, out bool SimplifiedTrueOtherWiseFalse)
        {
            Suitable = false;
            MinuseTruePlusFalse = false;
            SimplifiedTrueOtherWiseFalse = false;
            return false;
        }
    }
}
