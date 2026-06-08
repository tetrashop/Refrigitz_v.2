#pragma once

#include "stdafx.h"
/******************************
 * Ramin Edjlal CopyRigth 2015
 * Polynomial Interpolate 
 * Implementation recursivley.
 * Determinant
 * TransPoset
 * Recurve Matrix.
 */

namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] class Interpolate
	class Interpolate
	{
	public:
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: static Double[,] D;
		static double **D;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: static Double* F;
		static double *F;

	public:
		static double *Array(double *ArrayInput, int n);
   public:
	   Interpolate()
	   {
	   
	   }
	   static double *Answer(double *a, int n);
		static double **AMinuseOne(double **A, int n);
		static double Det(double **A, int n);
		static double **AStar(double **A, int n, int ii, int jj);
	};
}
