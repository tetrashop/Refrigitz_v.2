#include "stdafx.h"

namespace RefrigtzDLL
{

	double NewotoonInterpolate::fx0untinxn(double *x, double *f, int n, int i, int j)
	{

		if ((i == j - 1) || (i + 1 == j))
		{
			return (f[i]-f[j]) / (x[i]-x[j]);
		}
		double f1 = fx0untinxn(x, f, n, i, j - 1);
		double f2 = fx0untinxn(x, f, n, i + 1, j);
		return (f1-f2) / (x[i]-x[j]);

	}

	double *NewotoonInterpolate::px(double *x, double *f, int n)
	{

		double *s = new double[n];

		s[0] = f[0];

		for (int i = 1; i < n; i++)
		{
			double *p = new double[i + 1];
			p[0] = (-1) * x[0];
			p[1] = 1;
			p = Simplify(p, x, i, 1);
			double jj = fx0untinxn(x, f, i, 0, i);
			for (int j = 0; j <= i; j++)
			{
				p[j] = p[j] * jj;
				s[j] = p[j] + s[j];
				p[j] = 0;
			}
		}
		return s;

	}

	double *NewotoonInterpolate::Simplify(double *s, double *x, int i, int j)
	{

		if (j == i)
		{
			return s;
		}
		for (int k = i - 1; k >= 0; k--)
		{
			s[k + 1] = s[k];
		}

		s = 0;

		for (int k = 1; k < sizeof(s) / sizeof(s); k++)
		{
			s[k - 1] = s[k - 1] - s[k] * x[j];
		}

		s = Simplify(s, x, i, j + 1);
		return s;
	}

}
