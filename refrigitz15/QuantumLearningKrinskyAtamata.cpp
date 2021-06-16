#include "stdafx.h"
#include "QuantumLearningKrinskyAtamata.h"


namespace RefrigtzDLL
{

	QuantumLearningKrinskyAtamata::QuantumLearningKrinskyAtamata(int r0, int m0, int k0, double Alpha00) : QuantumAtamata(r0, m0, k0)
	{
		InitializeInstanceFields();
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			r = int();
			k = int();
			m = int();
			r = r0;
			k = k0;
			m = m0;

			Alpha0 = Alpha0;
			Reward = Alpha0 * (1.0 / (1 + static_cast<double>(BitState[0].Bits[0])) + 1.0 / ((1 + static_cast<double>(BitState[0].Bits[1])) * 2.0) + 1.0 / ((1 + static_cast<double>(BitState[1].Bits[0])) * 4.0) + 1.0 / ((1 + static_cast<double>(BitState[1].Bits[1])) * 8.0) + 1.0 / ((1 + static_cast<double>(BitState[2].Bits[0])) * 16.0) + 1.0 / ((1 + static_cast<double>(BitState[2].Bits[1])) * 32.0));
			Penalty = Alpha0 * (1.0 / (1 + static_cast<double>(!BitState[0].Bits[0])) + 1.0 / ((1 + static_cast<double>(!BitState[0].Bits[1])) * 2.0) + 1.0 / ((1 + static_cast<double>(!BitState[1].Bits[0])) * 4.0) + 1.0 / ((1 + static_cast<double>(!BitState[1].Bits[1])) * 8.0) + 1.0 / ((1 + static_cast<double>(!BitState[2].Bits[0])) * 16.0) + 1.0 / ((1 + static_cast<double>(!BitState[2].Bits[1])) * 32.0));
			int A1 = FirstAtamataState();
			int A2 = SecondAtamataState();
			int A3 = ThirdAtamataState();
			if (A1 == 2)
			{
				Reward += Alpha0 * (1.0 / (1 + static_cast<double>(true)) + 1.0 / (1 + static_cast<double>(true) * 2.0));
			}
			if (A2 == 2)
			{
				Reward += Alpha0 * (1.0 / (1 + static_cast<double>(true)) + 1.0 / (1 + static_cast<double>(true) * 2.0));
			}
			if (A3 == 2)
			{
				Reward += Alpha0 * (1.0 / (1 + static_cast<double>(true)) + 1.0 / (1 + static_cast<double>(true) * 2.0));
			}
			if (A1 == 2)
			{
				Penalty += Alpha0 * (1.0 / (1 + static_cast<double>(false)) + 1.0 / (1 + static_cast<double>(true) * 2.0));
			}
			if (A2 == 2)
			{
				Penalty += Alpha0 * (1.0 / (1 + static_cast<double>(false)) + 1.0 / (1 + static_cast<double>(true) * 2.0));
			}
			if (A3 == 2)
			{
				Penalty += Alpha0 * (1.0 / (1 + static_cast<double>(false)) + 1.0 / (1 + static_cast<double>(true) * 2.0));
			}
		}
	}

	void QuantumLearningKrinskyAtamata::InitializeInstanceFields()
	{
		r = 0;
		k = 0;
		m = 0;
		Alpha = 0;
	}
}
