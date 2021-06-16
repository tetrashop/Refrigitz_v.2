#include "LearningKrinskyAtamata.h"

//namespace RefrigtzDLL
//{

	void LearningKrinskyAtamata::Initiate()
	{

		IsPenalty = false;
		IsReward = false;

	}

	LearningKrinskyAtamata::LearningKrinskyAtamata(int r0, int m0, int k0)
	{

		InitializeInstanceFields();

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
			alpha = new double[r];
			fi = new double[k];
			fi = new double[r];
			for (int i = 0; i < r; i++)
			{
				alpha[i] = 1.0 / static_cast<double>(r);
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
	
	void LearningKrinskyAtamata::Clone(LearningKrinskyAtamata  AA)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			AA.r = r;
			AA.m = m;
			AA.k = k;
			alpha = new double[AA.r];
			for (int i = 0; i < AA.r; i++)
			{
				AA.alpha[i] = alpha[i];
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
	}
	
	void LearningKrinskyAtamata::FailureState()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			Failer++;
			if (Success < Failer && State < r - 1)
			{
				State++;
			}
			else if (State > 0)
			{
				State--;
			}
		}
	}

	void LearningKrinskyAtamata::SuccessState()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			Success++;
			if (Success > Failer && State < r - 1)
			{
				State++;
			}
			else if (State > 0)
			{
				State--;
			}
		}
	}

	int LearningKrinskyAtamata::IsSecondDerivitionIsPositive()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			for (int i = 0; i < r - 2; i++)
			{
				if (((alpha[i + 2] - 2 * alpha[i + 1] + alpha[i]) / (1.0 / static_cast<double>(r))) < 0)
				{
					return -1;
				}
			}
			return 1;
		}
	}

	double LearningKrinskyAtamata::LearningAlgorithmRegard()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			SuccessState();
			IsReward = true;
			IsPenalty = false;
			alpha[State] += Reward * (1 - alpha[State]);
			for (int i = 0; i < r; i++)
			{
				if (i != State)
				{
					alpha[i] -= Reward * alpha[i];
				}
			}
			beta = false;
			return alpha[State];
		}
	}

	double LearningKrinskyAtamata::IsRewardAction()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (IsReward)
			{
				return 1;
			}
			return -1;
		}
	}

	double LearningKrinskyAtamata::IsPenaltyAction()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (IsPenalty)
			{
				return 0;
			}
			return -1;
		}
	}

	double LearningKrinskyAtamata::LearningAlgorithmPenalty()
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			FailureState();
			IsPenalty = true;
			IsReward = false;
			alpha[State] -= Penalty * alpha[State];
			for (int i = 0; i < r; i++)
			{
				if (i != State)
				{
					alpha[i] -= Penalty * alpha[i];
					alpha[i] += (Penalty / (r - 1));
				}
			}
			beta = true;
			return alpha[State];
		}
	}

	void LearningKrinskyAtamata::InitializeInstanceFields()
	{
		r = 100;
		m = 100;
		k = 100;
		beta = true;
		IsReward = false;
		IsPenalty = false;
		Reward = 0;
		Penalty = 0;
		Success = 0;
		Failer = 0;
		State = 0;
	}
//}
