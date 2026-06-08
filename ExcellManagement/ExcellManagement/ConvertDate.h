// ConvertDate.h
//================================
#ifndef _CCONVERTDATE_H
#define _CCONVERTDATE_H
#include "stdafx.h"

class CConvertDate:public CObject
{
public :
	CConvertDate();



int OutDateGregorian(int D,int M,int Y,int what);
int OutDateGregorian_k(int D,int M,int Y,int what);
int OutDateLeap(int D,int M,int Y,int what);
int OutDateGerogianAll(int D,int M,int Y,int what);


~CConvertDate();
private:







};
#endif