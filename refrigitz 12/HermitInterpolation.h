#pragma once

#include "stdafx.h"

namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class HermitInterpolation
	class HermitInterpolation
	{
	public:
		static double *SimplifyLxi(double *s, double *x, int p, int j, int i);
		static double *Derivate(double *za, int n);
		static double *PxLxi(double *s, double *x, int n, int i);
		static double *PxUxi(double *x, double *f, int n, int i);
		static double *PxVxi(double *x, double *f, int n, int i);
		static double *FPerinValue(double *x, double *f, int n);
	public:
		static double *PxHermit(double *x, double *f, int n);
	public:
		HermitInterpolation() 
		{
		}
		static double DetaIorward(double *x, double *f, int index);
		static double DeltaiBackward(double *x, double *f, int index);
		static int Factorial(int n);
			static int Combinition(int nb, int kb);
	};
}
