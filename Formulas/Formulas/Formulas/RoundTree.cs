using System;

namespace Formulas
{
    class RoundTree
    {
        public static AddToTree.Tree RoundTreeMethod(AddToTree.Tree Rounding, int Frac)
        {
            if (Rounding == null)
                return null;
            if (IS.IsNumber(Rounding.SampleAccess))
                Rounding.SampleAccess = System.Math.Round(System.Convert.ToDouble(Rounding.SampleAccess), Frac).ToString();
            Rounding.LeftSideAccess = RoundTreeMethod(Rounding.LeftSideAccess, Frac);
            Rounding.RightSideAccess = RoundTreeMethod(Rounding.RightSideAccess, Frac);
            return Rounding;
        }
        public static int MaxFractionalDesimal(AddToTree.Tree T)
        {
            int A = 0;
            if (T == null)
                return A;
            if (IS.IsNumber(T.SampleAccess) && T.SampleAccess.IndexOf(".") != -1)
            {
                String S = T.SampleAccess.Substring(T.SampleAccess.IndexOf("."), T.SampleAccess.Length - T.SampleAccess.IndexOf("."));
                if (A < S.Length)
                    A = S.Length;
            }

            int S1 = MaxFractionalDesimal(T.LeftSideAccess);
            int S2 = MaxFractionalDesimal(T.RightSideAccess);
            if (S1 > A)
                A = S1;
            if (S2 > A)
                A = S2;
            return A;
        }
    }
}
