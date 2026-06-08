#pragma once
#include "stdafx.h"

#include <string>
#include <vector>
#include "LearningKrinskyAtamata.h"
#include "StringConverterHelper.h"

//Ramin Edjlal.CopyRight 2014.AllRightReserved.
namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class Bit
	class Bit
	{
	public:
		bool *Bits;//2;
	public:
		Bit();
		bool *GetBits();
		void SetZeroZero(); //State 0
		void SetZeroOne(); //State 1
		void SetOneZero(); //State SuperPosition
		void SetOneOne();
		bool IsZeroZero();
		bool IsZeroOne();
		bool IsOneZero();
		bool IsOneOne();
	};
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class QuantumAtamata : LearningKrinskyAtamata
	class QuantumAtamata : public LearningKrinskyAtamata
	{
	public:
		LearningKrinskyAtamata ThreeSet[3];
		std::vector<std::wstring> States;
		std::vector<unsigned char> StateByte;	
		//int r, m, k;	
		Bit *BitState;//[3];
		double *QuatumProbabilities;// [3];

		int NumberActiveAtamata;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public double* FirstProbibility = nullptr;
		double *FirstProbibility;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public double* SecondProbibility = nullptr;
		double *SecondProbibility;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: public double* ThirdProbibility = nullptr;
		double *ThirdProbibility;
		int A1;
		int A2;
		int A3;
		std::wstring AA;
		std::wstring AB;
		std::wstring AC;

		std::wstring CurrentState;
	public:
		QuantumAtamata(int r0, int m0, int k0);
		void CurrenStateInitialize();
		int FirstAtamataState();
		int SecondAtamataState();
		int ThirdAtamataState();
		void InitializeInstanceFields();
	};
}

