//CDVD Class is Child of OLDBDLimtColumn Class and is for Management of Excel Operatons.
//list of One DVD to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#ifndef _EXCELMANAGER_H
#define _EXCELMANAGER_H
#include "stdafx.h"
class ExcelManager
{
public:
	ExcelManager(BOOL blNeedToCreateSeet,CString csSheetName,CString csFile);
	~ExcelManager();
protected:
	BOOL NeedToCreateSeet; //If TRUE Need To Create SheetName.
	CString SheetName;// SheetName Of File.
	CString File; //Root File nme of excell .
};
#endif