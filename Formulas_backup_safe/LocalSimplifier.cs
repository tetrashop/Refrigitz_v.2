//ERROR30174253 :the result is invalid.refer to page 338.
//==========================================================

namespace Formulas
{
    static class LocalSimplifier
    {
        static public AddToTree.Tree LocalSimplifierFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            Dummy = SuitableStructureForLocalSimplifier.SuitableStructureForLocalSimplifierFx(Dummy, ref UIS);
            bool MINUSEPLUSEEQUAL = false;
            bool MULDIVISIONEQUAL = false;
            bool MINUSEPLUSWITHNUMBERMULATED = false;
            bool MULDIVISIONWITHNUMBERMULATED = false;
            int INCREASE = 2147483647 / 5;
            do
            {
                MINUSEPLUSEEQUAL = false;

                UIS.SetProgressValue(UIS.progressBar10, 0);

                Dummy = LocalSearchMinusPlusEqualSimplifier.LocalSearchMinusPlusEqualSimplifierFx(Dummy, ref MINUSEPLUSEEQUAL, ref UIS);
                //Dummy = LocalSearchMinusPlusEqualSimplifier.LocalSearchMinusPlusEqualSimplifierFx(Dummy);

                UIS.SetProgressValue(UIS.progressBar10, INCREASE + UIS.progressBar10.Value);
                MULDIVISIONEQUAL = false;
                //ERROR30174253 :the result is invalid.refer to page338.
                Dummy = LocalSearchMulDivisionEqualSimplifier.LocalSearchMulDivisionEqualSimplifierFx(Dummy, ref MULDIVISIONEQUAL, ref UIS);

                UIS.SetProgressValue(UIS.progressBar10, INCREASE + UIS.progressBar10.Value);

                MINUSEPLUSWITHNUMBERMULATED = false;
                Dummy = LocalSearchMinusPlusWithNumberMulatedEqualSimplifier.LocalSearchMinusPlusWithNumberMulatedEqualSimplifierFx(Dummy, ref MINUSEPLUSWITHNUMBERMULATED, ref UIS);

                UIS.SetProgressValue(UIS.progressBar10, INCREASE + UIS.progressBar10.Value);
                MULDIVISIONWITHNUMBERMULATED = false;
                //Dummy = LocalSearchMinusPlusEqualSimplifier.LocalSearchMinusPlusEqualSimplifierFx(Dummy);

                //         Dummy = LocalSearchMinusPlusTowNumberSimplifier.LocalSearchMinusPlusTowNumberSimplifierFx(Dummy);

                UIS.SetProgressValue(UIS.progressBar10, INCREASE + UIS.progressBar10.Value);

                Dummy = LocalSearchMulDivionWithNumberMulatedEqualSimplifier.LocalSearchMulDivionWithNumberMulatedEqualSimplifierFx(Dummy, ref MULDIVISIONWITHNUMBERMULATED, ref UIS);

                //          Dummy = Simplifier.SimplifierFxSimpler(Dummy);
                UIS.SetProgressValue(UIS.progressBar10, 2147483647);
            } while (MINUSEPLUSEEQUAL || MULDIVISIONEQUAL || MINUSEPLUSWITHNUMBERMULATED || MULDIVISIONWITHNUMBERMULATED);

            return Dummy;

        }
    }
}
