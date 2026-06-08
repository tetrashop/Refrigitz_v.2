//CDVD Class is Child of OLDBDLimtColumn Class and is for Management of Excel Operatons.
//list of One DVD to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"
//Constructor.
ExcelManager::ExcelManager(BOOL blNeedToCreateSeet,CString csSheetName,CString csFile)
{
	NeedToCreateSeet=blNeedToCreateSeet;
	SheetName=csSheetName;
	File=csFile;
}
//Deconstructor.
ExcelManager::~ExcelManager()
{

}