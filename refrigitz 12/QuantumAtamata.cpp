#include "stdafx.h"


namespace RefrigtzDLL
{


	

	LearningKrinskyAtamata::LearningKrinskyAtamata(int r0, int m0, int k0)
	{

		InitializeInstanceFields();


		
		for (int i = 0; i < 3; i++)
		{
			ThreeSet[i] = LearningKrinskyAtamata(r0, m0, k0);
		}
		States.clear();
		r = r0;
		m = m0;
		k = k0;
		FirstProbibility = new double[r];
		SecondProbibility = new double[r];
		ThirdProbibility = new double[r];

	}



	void LearningKrinskyAtamata::CurrenStateInitialize()
	{

		A1 = FirstAtamataState();
		A2 = SecondAtamataState();
		A3 = ThirdAtamataState();
		AA = StringConverterHelper::toString(A1);
		AB = StringConverterHelper::toString(A2);
		AC = StringConverterHelper::toString(A3);
		if (A1 == 0)
		{
			AA = L"|0>,";
		}
		else
		{
			if (A1 == 1)
			{
				AA = L"|1>,";
			}
			else
			{
				if (A1 == 2)
				{
					AA = L"|2>+|3>,";
				}
			}
		}
		if (A2 == 0)
		{
			AB = L"|0>,";
		}
		else
		{
			if (A2 == 1)
			{
				AB = L"|1>,";
			}
			else
			{
				if (A2 == 2)
				{
					AB = L"|2>+|3>,";
				}
			}
		}
		if (A3 == 0)
		{
			AC = L"|0>,";
		}
		else
		{
			if (A3 == 1)
			{
				AC = L"|1>,";
			}
			else
			{
				if (A3 == 2)
				{
					AC = L"|2>+|3>,";
				}
			}
		}
		CurrentState = AA + AB + AC;
		//  CurrentStateByte = System.Convert.ToByte(CurrentState, 2);
		States.push_back(CurrentState);
		//   StateByte.push_back(CurrentStateByte);
		if (A1 == 2)
		{
			if (A2 == 2)
			{
				if (A3 == 2)
				{
					NumberActiveAtamata = 1;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = (ThreeSet[0].alpha[i] + ThreeSet[1].alpha[i] + ThreeSet[2].alpha[i]) / 3.0;
					}
				}
				else
				{
					NumberActiveAtamata = 2;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = (ThreeSet[0].alpha[i] + ThreeSet[1].alpha[i]) / 2.0;
						SecondProbibility[i] = ThreeSet[2].alpha[i];
					}
				}
			}
			else
			{
				if (A3 == 2)
				{

					NumberActiveAtamata = 2;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = (ThreeSet[0].alpha[i] + ThreeSet[2].alpha[i]) / 2.0;
						SecondProbibility[i] = ThreeSet[1].alpha[i];
					}
				}
				else
				{

					NumberActiveAtamata = 3;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = ThreeSet[0].alpha[i];
						SecondProbibility[i] = ThreeSet[1].alpha[i];
						ThirdProbibility[i] = ThreeSet[2].alpha[i];
					}
				}
			}
		}
		else
		{
			if (A2 == 2)
			{
				if (A3 == 2)
				{
					NumberActiveAtamata = 2;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = (ThreeSet[1].alpha[i] + ThreeSet[2].alpha[i]) / 2.0;
						SecondProbibility[i] = ThreeSet[0].alpha[i];
					}
				}
				else
				{
					NumberActiveAtamata = 3;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = ThreeSet[1].alpha[i];
						SecondProbibility[i] = ThreeSet[0].alpha[i];
						ThirdProbibility[i] = ThreeSet[2].alpha[i];
					}
				}
			}
			else
			{
				if (A3 == 2)
				{
					NumberActiveAtamata = 3;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = ThreeSet[2].alpha[i];
						SecondProbibility[i] = ThreeSet[0].alpha[i];
						ThirdProbibility[i] = ThreeSet[1].alpha[i];
					}
				}
				else
				{
					NumberActiveAtamata = 3;
					for (int i = 0; i < r; i++)
					{
						FirstProbibility[i] = ThreeSet[0].alpha[i];
						SecondProbibility[i] = ThreeSet[2].alpha[i];
						ThirdProbibility[i] = ThreeSet[1].alpha[i];
					}
				}
			}
		}

	}



	int LearningKrinskyAtamata::FirstAtamataState()
	{

		if (BitState[0].IsZeroZero())
		{
			//       BitState.SetZeroZero();
			return 0; //0 State
		}
		else
		{
			if (BitState[0].IsZeroOne())
			{
				//          BitState.SetZeroOne();
				return 1; //1 State
			}
		}
		// BitState.SetOneZero();
		return 2; //SuperPosition State

	}

	int LearningKrinskyAtamata::SecondAtamataState()
	{


		if (BitState[1].IsZeroZero())
		{
			//BitState[1].SetZeroZero();
			return 0; //0 State
		}
		else
		{
			if (BitState[1].IsZeroOne())
			{
				//      BitState[1].SetZeroOne();
				return 1; //1 State
			}
		}

		//   BitState[1].SetOneZero();
		return 2; //SuperPosition State

	}

	int LearningKrinskyAtamata::ThirdAtamataState()
	{


		if (BitState[2].IsZeroZero())
		{
			//     BitState[2].SetZeroZero();
			return 0; //0 State
		}
		else
		{
			if (BitState[2].IsZeroOne())
			{
				//        BitState[2].SetZeroOne();
				return 1; //1 State
			}
		}
		// BitState[2].SetOneZero();
		return 2; //SuperPosition State

	}

	void LearningKrinskyAtamata::InitializeInstanceFields()
	{
		States = std::vector<std::wstring>();
		StateByte = std::vector<unsigned char>();
		r = 0;
		m = 0;
		k = 0;
		NumberActiveAtamata = 3;
		FirstProbibility = 0;
		SecondProbibility = 0;
		ThirdProbibility = 0;
		A1 = 0;
		A2 = 0;
		A3 = 0;
		AA = L"";
		AB = L"";
		AC = L"";
		CurrentState = L"";
	}
	LearningKrinskyAtamata::~LearningKrinskyAtamata()
	{
		delete[] FirstProbibility;
		delete[] SecondProbibility;
		delete[] ThirdProbibility;
	}
}


