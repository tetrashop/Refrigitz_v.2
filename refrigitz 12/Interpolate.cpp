#include "stdafx.h"
//#include "Interpolate.h"

namespace RefrigtzDLL
{

	double *Interpolate::Array(double *ArrayInput, int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double *ArrayOutputA=new double[n];
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* ArrayOutput;
			double *ArrayOutput;
			double *Array=new double[n];
			ArrayOutput = Answer(ArrayInput, n);
			for (int i = 0; i < n; i++)
			{
				Array[i] = static_cast<double>(ArrayOutput[i]);
			}
			return Array;
		}
	}

	double *Interpolate::Answer(double *a, int n)
	{
		 //autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		 //lock (o)
		 {
			double *Ans = new double[n];
			 D = new double*[n];
			 for (int i = 0; i < n; i++)
				 D[i] = new double[n];
			 F = new double[n];
			 for (int i = 0; i < n; i++)
			 {
				 D[i][0] = 1;
			 }
			 for (int i = 0; i < n; i++)
			 {
				 for (int j = 1; j < n; j++)
				 {
					 D[i][j] = pow(i, j);
				 }
			 }
			 for (int i = 0; i < n; i++)
			 {
				 F[i] = a[i];
			 }

			 D = AMinuseOne(D, n);

			 for (int i = 0; i < n; i++)
			 {
				 for (int j = 0; j < n; j++)
				 {
					 Ans[i] = Ans[i] + D[i][j] * F[j];
				 }
			 }
			 return Ans;
		 }
	}

	double **Interpolate::AMinuseOne(double **A, int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double **N = new double*[n]; for (int i = 0; i < n; i++)N[i] = new double[n];
			double **Ast = new double*[n - 1]; for (int i = 0; i < n; i++)Ast[i] = new double[n - 1];
			
			for (int ii = 0; ii < n; ii++)
			{
				for (int jj = 0; jj < n; jj++)
				{
					N[ii][jj] = pow(-1, ii + jj) * Det(AStar(A, n, ii, jj), n-1);
				}
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					double AS = N[i][j];
					N[i][j] = N[j][i];
					N[j][i] = AS;
				}
			}
			double SAS = 1 / Det(A, n);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					N[i][j] = SAS * N[i][j];
				}
			}
			return N;
		}
	}

	double Interpolate::Det(double **A, int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (n == 0)
			{
				return 0;
			}
			if (n == 1)
			{
				return A[0][0];
			}
			if (n == 2)
			{
				return A[0][0] * A[1][1].A[0][1] * A[1][0];
			}
			double AA = 0;
			for (int i = 0; i < n; i++)
			{
				AA = AA + A[0][i] * pow(-1, i) * Det(AStar(A, n, 0, i), n - 1);
			}
			return AA;
		}
	}

	double **Interpolate::AStar(double **A, int n, int ii, int jj)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double **Ast = new double*[n - 1]; for (int g = 0; g < n - 1; g++)Ast[g] = new double[n - 1];
			int ni = 0, nj = 0;
			for (int i = 0; i < n; i++)
			{
				nj = 0;
				if ((i == ii))
				{
					i++;
				}
				if (i == n)
				{
					break;
				}
				for (int j = 0; j < n; j++)
				{
					if ((j != jj))
					{
						Ast[ni][nj] = A[i][j];
						nj++;
					}
				}
				ni++;

			}
			return Ast;
		}
	}
}
