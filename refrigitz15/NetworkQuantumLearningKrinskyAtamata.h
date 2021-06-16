#pragma once
#include "stdafx.h"
#include "LearningKrinskyAtamata.h"
#include <string>
#include <stdexcept>

/*CopyRight Ramin Edjlal***************************2018*************************
 The Magic Table Game Satte Learing Quantum Atamata.****************************
 *******************************************************************************
 */ 

namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class NetworkQuantumLearningKrinskyAtamata : LearningKrinskyAtamata
	class NetworkQuantumLearningKrinskyAtamata : public LearningKrinskyAtamata
	{
	public:
		static std::wstring Root;
	private:
		static void Log(std::exception &ex);

		//int r, m, k;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: LearningKrinskyAtamata[,] Netfi;
		LearningKrinskyAtamata **Netfi;


	public:
		NetworkQuantumLearningKrinskyAtamata(int r0, int m0, int k0);
		virtual double LearningAlgorithmRegardNet(int Row, int Column);
		virtual int IsRewardActionNet(int Row, int Column);

		virtual double IsPenaltyActionNet(int Row, int Column);
		virtual double LearningAlgorithmPenaltyNet(int Row, int Column);
		virtual double LearingValue(int Row, int Column);

	private:
		virtual void InitializeInstanceFields();
	};
}

