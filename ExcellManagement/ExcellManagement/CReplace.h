//CRepalce Class is derived from CSearch Class and is for Replcaing to Sheet(s). 
//list of One DVD to Excel Sheet.
//By Ramin Edjlal 2013 Urmia Iran.
#ifndef _CREPLACE_H
#define _CREPLACE_H
#include "stdafx.h"
class CReplace:public CSearch
{
public:
	CReplace(CString File, CString SheetOrSeparator, bool Backup ,INT SheetA,BOOL XLSX);//constructor.
	BOOL CReplaceInOneSheet(CString SubStringSe,CString SubStringRe,BOOL blSubString,CString SheetOrSeparator,BOOL XLSX);;//Replace a SubString with New One in specific Sheets.
	BOOL CReplaceInAllSheets(CString SubStringSe,CString SubStringRe,BOOL blSubString,BOOL XLSX);//Replace in All Sheets.
	~CReplace();//DEconsturctor.
protected:
	INT Sheet;
};
#endif