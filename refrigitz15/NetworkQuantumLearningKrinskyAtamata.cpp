#include "stdafx.h"
#include "NetworkQuantumLearningKrinskyAtamata.h"


namespace RefrigtzDLL
{

//std::wstring NetworkQuantumLearningKrinskyAtamata::Root = System::IO::Path::GetDirectoryName(Environment::GetCommandLineArgs()[0]);

	

	NetworkQuantumLearningKrinskyAtamata::NetworkQuantumLearningKrinskyAtamata(int r0, int m0, int k0) : LearningKrinskyAtamata(r0, m0, k0)
	{
		InitializeInstanceFields();
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			Netfi = new LearningKrinskyAtamata*[k0]; for (int g = 0; g < k0; g++)Netfi[g] = new LearningKrinskyAtamata[m0];

			for (int j = 0; j < m0; j++)
			{
				for (int k = 0; k < k0; k++)
				{
					Netfi[j][k] = LearningKrinskyAtamata(r0, m0, k0);
				}
			}

			r = r0;
			m = m0;
			k = k0;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::LearningAlgorithmRegardNet(int Row, int Column)
	{
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			double Hu = 1;

			Netfi[Row][Column].LearningAlgorithmRegard();
			Hu = Netfi[Row][Column].Alpha[State];

			return Hu;
		}
	}

	int NetworkQuantumLearningKrinskyAtamata::IsRewardActionNet(int Row, int Column)
	{
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
//		lock (o)
		{
			if (Netfi[Row][Column].IsReward)
			{
				return 1;
			}
			return -1;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::IsPenaltyActionNet(int Row, int Column)
	{
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
//		lock (o)
		{
			if (Netfi[Row][Column].IsPenalty)
			{
				return 0;
			}
			return -1;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::LearningAlgorithmPenaltyNet(int Row, int Column)
	{
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
//		lock (o)
		{
			double Hu = 1;

				Netfi[Row][Column].LearningAlgorithmPenalty();
				Hu = Netfi[Row][Column].Alpha[State];

			return Hu;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::LearingValue(int Row, int Column)
	{
		////auto o = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
//		lock (o)
		{
			double Hu = 1;

				Hu = Netfi[Row][Column].Alpha[State];

			return Hu;
		}
	}

	void NetworkQuantumLearningKrinskyAtamata::InitializeInstanceFields()
	{
		r = 0;
		m = 0;
		k = 0;
	}
}
