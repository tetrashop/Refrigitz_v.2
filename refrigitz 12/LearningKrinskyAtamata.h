#pragma once
#include "stdafx.h"


/******************************************************************************
 * Ramin Edjlal Copyrights 2015.************************************************
 * Learning AutamatA->**********************************************************
 * The every sum of probability is one.****************************************(*_)
 * four formula .tow for Regard regime and tow for penalty regime.***************(-)
 * Derived Quantum Automata Penalty All Objects of Derived Automat*a***********(-)
 * Malfunction Reward and Penalty Detection**********************************(_*)
 * Penalty Reward Action Failure************************************************(*_)
 * Mistuning of Penalty and Regard Data in IsRegard and IsPenalty Value***x****(+)
 * No Reason For Malfunction of Reward and Penalty Mechanism******************(_)
 * 1395/1/2********************************************************************(*:Sum(3)) (_:Sum(4)) (-:Sum(2)) (All Errors:(7))
 * Penalty Regard Action is Useful For One Time Per AllDraw Object.************
 * No Solution to Overcome to static Behavior Of Quantum Variables Inhererete.*
 ******************************************************************************/



//namespace RefrigtzDLL
//{
	
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class LearningKrinskyAtamata
	class LearningKrinskyAtamata
	{
	public:
		int r;
		int m;
		int k;
	private:
		
	public:
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: public double* alpha;
		double *alpha;
	public:
		bool beta;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: double* fi;
		double *fi;
	public:
		bool IsReward;
		bool IsPenalty;
	public:
		double Reward;
		double Penalty;
		int Success, Failer;
		int State;
		//int State = 1;
	public:
		
		void Initiate();
		
		
		//void Clone(LearningKrinskyAtamata  *AA);

		void FailureState();
		void SuccessState();
		int IsSecondDerivitionIsPositive();
		double LearningAlgorithmRegard();
		 double IsRewardAction();

		double IsPenaltyAction();
		double LearningAlgorithmPenalty();

	public:
		LearningKrinskyAtamata(int r0, int m0, int k0);
		void Clone(LearningKrinskyAtamata * AA);
		void CurrenStateInitialize();
		LearningKrinskyAtamata()
		{
		}
		void InitializeInstanceFields();
	};
//}
