#include "stdafx.h"


namespace RefrigtzDLL
{

	std::wstring NetworkQuantumLearningKrinskyAtamata::Root = L""; //System::IO::Path::GetDirectoryName(Environment::GetCommandLineArgs());

	/*void NetworkQuantumLearningKrinskyAtamata::Log(std::exception ex)
	{
		//try
		{
			//autoa = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (a)
			{
				std::wstring stackTrace = ex.what();
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				File::AppendAllText(Root + std::wstring(L"\\ErrorProgramRun.txt"), stackTrace + std::wstring(L": On") + DateTime::Now.ToString()); // path of file where stack trace will be stored.
			}
		}
		//catch(std::exception t)
		{
			
		}
	}
	*/
	NetworkQuantumLearningKrinskyAtamata::NetworkQuantumLearningKrinskyAtamata(int r0, int m0, int k0) : LearningKrinskyAtamata(r0, m0, k0)
	{
		InitializeInstanceFields();
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			Netfi = new LearningKrinskyAtamata*[k0];
			for (int i = 0; i < m0; i++)
				Netfi[i] =new LearningKrinskyAtamata[m0];

			for (int j = 0; j < m0; j++)
			{
				for (int k = 0; k < k0; k++)
				{
					Netfi[j][k] = new LearningKrinskyAtamata(r0, m0, k0);
				}
			}

			r = r0;
			m = m0;
			k = k0;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::LearningAlgorithmRegard(int Row, int Column)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			double Hu = 1;
			//try
			{
				Netfi[Row][Column].LearningAlgorithmRegard();
				Hu = Netfi[Row][Column].alpha[State];
			}
			//catch(std::exception t)
			{
				
			}
			return Hu;
		}
	}

	

	double NetworkQuantumLearningKrinskyAtamata::IsRewardAction(int Row, int Column)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (Netfi[Row][Column].IsReward)
			{
				return 1;
			}
			return -1;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::IsPenaltyAction(int Row, int Column)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (Netfi[Row][Column].IsPenalty)
			{
				return 0;
			}
			return -1;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::LearningAlgorithmPenalty(int Row, int Column)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double Hu = 1;
			//try
			{
				Netfi[Row][Column].LearningAlgorithmPenalty();
				Hu = Netfi[Row][Column].alpha[State];
			}
			//catch(std::exception t)
			{
				
			}
			return Hu;
		}
	}

	double NetworkQuantumLearningKrinskyAtamata::LearingValue(int Row, int Column) 
	{
			double Hu = 1;
			//try
			{
				Hu = Netfi[Row][Column].alpha[State];
			}
			//catch(std::exception t)
			{
				
			}
			return Hu;
		
	}

	void NetworkQuantumLearningKrinskyAtamata::InitializeInstanceFields()
	{
		r = 0;
		m = 0;
		k = 0;
	}
}
