#ifndef _CSHEETNUMBER_H
#define _CSHEETNUMBER_H
#include "stdafx.h"
class CSheetNumber
{
public:
	CSheetNumber(INT SheetA);//Constructor.

	INT CCalculateSheetNumber(CString File,CString Root1,CString Root2,INT DVD1,INT DVD2,BOOL XLSXS);//Calculate Sheet Numbers.
	INT GetSheetNeed(){return SheetNeed;}
	~CSheetNumber();//Deconstructor.
protected:
	INT Sheet;
	INT SheetNeed;
};
#endif