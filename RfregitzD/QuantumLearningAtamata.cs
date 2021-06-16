using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningMachine
{

    public class QuantumLearningKrinskyAtamata : QuantumAtamata
    {
        int r = 0, k = 0, m = 0;
        double Alpha = 0;
        public QuantumLearningKrinskyAtamata(int r0, int m0, int k0,double Alpha0)
            : base(r0, m0, k0)
        {
            r = r0;
            k = k0;
            m = m0;
            
            Alpha = Alpha0;
            Reward = Alpha * (1.0 / (1 + System.Convert.ToDouble(BitState[0].Bits[0])) + 1.0 / ((1 + System.Convert.ToDouble(BitState[0].Bits[1])) *2.0) + 1.0 / ((1 + System.Convert.ToDouble(BitState[1].Bits[0])) *4.0) + 1.0 / ((1 + System.Convert.ToDouble(BitState[1].Bits[1])) *8.0) + 1.0 / ((1 + System.Convert.ToDouble(BitState[2].Bits[0])) * 16.0) + 1.0 / ((1 + System.Convert.ToDouble(BitState[2].Bits[1])) * 32.0));
            Penalty = Alpha * (1.0 / (1 + System.Convert.ToDouble(!BitState[0].Bits[0])) + 1.0 / ((1 + System.Convert.ToDouble(!BitState[0].Bits[1])) *2.0) + 1.0 / ((1 + System.Convert.ToDouble(!BitState[1].Bits[0])) *4.0) + 1.0 / ((1 + System.Convert.ToDouble(!BitState[1].Bits[1])) *8.0) + 1.0 / ((1 + System.Convert.ToDouble(!BitState[2].Bits[0])) * 16.0) + 1.0 / ((1 + System.Convert.ToDouble(!BitState[2].Bits[1])) * 32.0));
            int A1 = FirstAtamataState();
            int A2 = SecondAtamataState();
            int A3 = ThirdAtamataState();
            if (A1 == 2)
            {
                Reward += Alpha * (1.0 / (1 + System.Convert.ToDouble(true)) + 1.0 / (1 + System.Convert.ToDouble(true) *2.0));
            }
            if (A2 == 2)
            {
                Reward += Alpha * (1.0 / (1 + System.Convert.ToDouble(true)) + 1.0 / (1 + System.Convert.ToDouble(true) *2.0));
            }
            if (A3 == 2)
            {
                Reward += Alpha * (1.0 / (1 + System.Convert.ToDouble(true)) + 1.0 / (1 + System.Convert.ToDouble(true) *2.0));
            }
            if (A1 == 2)
            {
                Penalty += Alpha * (1.0 / (1 + System.Convert.ToDouble(false)) + 1.0 / (1 + System.Convert.ToDouble(true) *2.0));
            }
            if (A2 == 2)
            {
                Penalty += Alpha * (1.0 / (1 + System.Convert.ToDouble(false)) + 1.0 / (1 + System.Convert.ToDouble(true) *2.0));
            }
            if (A3 == 2)
            {
                Penalty += Alpha * (1.0 / (1 + System.Convert.ToDouble(false)) + 1.0 / (1 + System.Convert.ToDouble(true) *2.0));
            }
        }
    }
}
