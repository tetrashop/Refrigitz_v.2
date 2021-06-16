#include "stdafx.h"



namespace RefrigtzDLL
{

	double *HermitInterpolation::SimplifyLxi(double *s, double *x, int p, int j, int i)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (j == p)
			{
				return s;
			}
			if (sizeof(s) / sizeof(s) > 2)
			{
				if (j != i)
				{
					for (int k = p - 1; k >= 0; k--)
					{
						s[k + 1] = s[k];
					}
					s = 0;
					for (int k = 1; k < sizeof(s) / sizeof(s); k++)
					{
						s[k - 1] = s[k - 1] - s[k] * x[j + 1];
					}
				}
			}
			s = SimplifyLxi(s, x, p, j + 1, i);
			return s;
		}
	}

	double *HermitInterpolation::Derivate(double *za, int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double *sz = new double[n - 1];
			for (int i = (n - 1); i > 0; i--)
			{
				sz[i - 1] = za[i] * (i);
			}
			return sz;
		}
	}

	double *HermitInterpolation::PxLxi(double *s, double *x, int n, int i)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double ss = 1;
			for (int j = 0; j < n; j++)
			{
				if (j != i)
				{
					ss = ss * (x[i]-x[j]);
				}
			}
			double *sas = new double[n];
			if (i == 0)
			{
				sas[0] = -1 * x[1];
			}
			else
			{
				sas[0] = -1 * x[0];
			}
			sas[1] = 1;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* aa = SimplifyLxi(sas, x, n.1, 1, i);
			double *aa = SimplifyLxi(sas, x, n-1, 1, i);
			for (int a = 0; a < n; a++)
			{
				aa[a] = aa[a] / ss;
			}
			return aa;
		}
	}

	double *HermitInterpolation::PxUxi(double *x, double *f, int n, int i)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double *uxi=new double[2 * n + n];
			double *result=new double[2 * n + n];
			double *firstpar=new double[2];
			firstpar[0] = 2 * x[i];
			firstpar[1] = -2;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* Lxi = PxLxi(f, x, n, i);
			double *Lxi = PxLxi(f, x, n, i);
			double *Lxi2 = new double[2 * n];
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* lprinlxi = Derivate(Lxi, n);
			double *lprinlxi = Derivate(Lxi, n);

			for (int r = 0; r < n-1; r++)
			{
				uxi[r] = firstpar[0] * lprinlxi[r];
			}
			for (int r = 0; r < n-1; r++)
			{
				uxi[r + 1] = uxi[r + 1] + firstpar[1] * lprinlxi[r];
			}
			uxi = uxi + 1;
			for (int r = 0; r < n; r++)
			{
				for (int w = 0; w < n; w++)
				{
					Lxi2[r + w] = Lxi2[r + w] + Lxi[r] * Lxi[w];
				}
			}
			for (int r = 0; r < n; r++)
			{
				for (int w = 0; w < 2 * n; w++)
				{
					result[r + w] = result[r + w] + uxi[r] * Lxi2[w];
				}
			}

			return result;
		}
	}

	double *HermitInterpolation::PxVxi(double *x, double *f, int n, int i)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double *result=new double[2 * n + n];
			double *vxi=new double[2 * n + n];
			double *firstpar = new double[2];
			vxi[0] = (-1) * x[i];
			vxi[1] = 1;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* Lxi = PxLxi(f, x, n, i);
			double *Lxi = PxLxi(f, x, n, i);
			double *Lxi2=new double[2 * n];
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* lprinlxi = Derivate(Lxi, n);
			double *lprinlxi = Derivate(Lxi, n);

			for (int r = 0; r < n; r++)
			{
				for (int w = 0; w < n; w++)
				{
					Lxi2[r + w] = Lxi2[r + w] + Lxi[r] * Lxi[w];
				}
			}
			for (int r = 0; r < n; r++)
			{
				for (int w = 0; w < 2 * n; w++)
				{
					result[r + w] = result[r + w] + vxi[r] * Lxi2[w];
				}
			}
			return result;
		}
	}

	double *HermitInterpolation::FPerinValue(double *x, double *f, int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double *fperin = new double[n];
			for (int i = 0; i < n / 2; i++)
			{
				for (int J = 0; J < n / 2; J++)
				{
					fperin[i] = fperin[i] + pow(-1, J) * ((1) / (J + 1)) * DetaIorward(x, f, J + 1);
				}
			}
			for (int i = n / 2 + 1; i < n; i++)
			{
				for (int J = n / 2 + 1; J < n; J++)
				{
					fperin[i] = fperin[i] + pow(-1, J-n / 2.1) * ((1) / (J + 1-n / 2.1)) * DeltaiBackward(x, f, J-n / 2);
				}
			}
			return fperin;
		}
	}

	double *HermitInterpolation::PxHermit(double *x, double *f, int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete*' where appropriate:
//ORIGINAL LINE: Double* fperin = FPerinValue(x, f, n);
			double *fperin = FPerinValue(x, f, n);
			double *Result = new double[2 * n + n];
			double *Dummy=new double[2 * n + n];
			double **uxi2 = new double*[2 * n + n]; for (int g = 0; g < n; g++)uxi2[g] = new double[n];
			double **vxi2 = new double*[2 * n + n]; for (int g = 0; g < n; g++)vxi2[g] = new double[n];
			
			for (int i = 0; i < n; i++)
			{
				Dummy = PxUxi(x, f, n, i);
				for (int G = 0; G < 2 * n + n; G++)
				{
					uxi2[i][G] = Dummy[G];
				}
				Dummy = PxVxi(x, f, n, i);
				for (int G = 0; G < 2 * n + n; G++)
				{
					vxi2[i][G] = Dummy[G];
				}


			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < 2 * n + n; j++)
				{
					Result[j] = Result[j] + uxi2[i][j] * f[i] + vxi2[i][j] * fperin[i];
				}
			}
			return Result;
		}
	}

	double HermitInterpolation::DetaIorward(double *x, double *f, int index)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double ad = 0;
			for (int j = 0; j < index; j++)
			{
				ad = ad + pow(-1, j) * Combinition(index, j) * f[index-j];
			}
			return ad;
		}
	}

	double HermitInterpolation::DeltaiBackward(double *x, double *f, int index)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			double ad = 0;
			for (int j = 0; j < index; j++)
			{
				ad = ad + pow(-1, j) * Combinition(index, j) * f[index-j];
			}
			return ad;
		}
	}

	int HermitInterpolation::Factorial(int n)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			if (n == 1 || n == 0)
			{
				return 1;
			}
			return n * Factorial(n-1);
		}
	}

	int HermitInterpolation::Combinition(int nb, int kb)
	{
	//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
	//lock (o)
	{
		if (nb == kb)
		{
			return 1;
		}
		return (Factorial(nb)) / (Factorial(kb) * Factorial(nb-kb));
	}
	}
}
