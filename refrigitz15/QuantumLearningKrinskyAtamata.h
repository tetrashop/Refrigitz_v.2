#pragma once
#include "stdafx.h"
#include "QuantumAtamata.h"


namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class QuantumLearningKrinskyAtamata : QuantumAtamata
	class QuantumLearningKrinskyAtamata : public QuantumAtamata
	{
	/*private:
		int r, k, m;*/
	public:
		double Alpha0;
	public:
		QuantumLearningKrinskyAtamata(int r0, int m0, int k0, double Alpha0);

	private:
		virtual void InitializeInstanceFields();
	};
}
