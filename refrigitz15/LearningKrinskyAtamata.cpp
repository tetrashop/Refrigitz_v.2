#include "stdafx.h"
//#include "QuantumAtamata.h"
#include "LearningKrinskyAtamata.h"


namespace RefrigtzDLL
{

	
	LearningKrinskyAtamata::LearningKrinskyAtamata(int r0, int m0, int k0)
	{
		InitializeInstanceFields();
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			IsReward = bool();
			IsPenalty = bool();
			IsReward = false;
			IsPenalty = false;
			Success = int();
			State = int();
			beta = bool();
			beta = true;
			Reward = double();
			Penalty = double();
			r = int();
			m = int();
			k = int();


			if (r0 >= m0)
			{
				r = r0;
				m = m0;
				k = k0;
				Alpha = new double[r];
				fi = new double[k];
				fi = new double[r];
				for (int i = 0; i < r; i++)
				{
					Alpha[i] = 1.0 / static_cast<double>(r);
				}
				for (int i = 0; i < k; i++)
				{
					fi[i] = 1.0 / static_cast<double>(k);
				}

				//Reward[i] = (double)(new Random()).Next(0, 100000) / 100000.0;
				Reward = 1.0 / static_cast<double>(r);
				//Penalty[i] = (double)(new Random()).Next(0, 100000) / 100000.0;
				Penalty = 1.0 / static_cast<double>(r);
			}
		}
	}
	/*
	void LearningKrinskyAtamata::Clone(QuantumAtamata AA)
	{
		
			AA.r = r;
			AA.m = m;
			AA.k = k;
			AA.Alpha = new double[AA.r];
			for (int i = 0; i < AA.r; i++)
			{
				AA.Alpha[i] = Alpha[i];
			}
			AA.beta = beta;
			AA.Failer = Failer;
			fi = new double[AA.k];
			for (int i = 0; i < AA.k; i++)
			{
				AA.fi[i] = fi[i];
			}
			AA.IsPenalty = IsPenalty;
			AA.IsReward = IsReward;
			AA.Reward = Reward;
			AA.Penalty = Penalty;
			AA.Success = Success;
			AA.Failer = Failer;
			AA.State = State;
		
	}
	*/
	
}
