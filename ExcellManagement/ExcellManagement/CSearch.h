//CSearch Class contain of Class for Search Engine. 
//for Standard and non standard DVDS. 
//By Ramin Edjlal 2013 Urmia Iran.
#ifndef _CSEARCH_H
#define _CSEARCH_H
#include "stdafx.h"
class CSearch:public CSpreadSheet
{
public:
	CSearch(CString File, CString SheetOrSeparator, bool Backup ,INT SheetA,BOOL XLSX);//Constructor
	BOOL CSearchAStringAndSubStringInSpecialSheet(CString SubString,BOOL blSubString,CString SheetOrSeparator,BOOL XLSX);//To Obtain String And Substring In Special Sheet Number. Default is For String.
	BOOL CSearchForSeveralSheet(CString SubString,BOOL blSubString,BOOL XLSX);//For Searching In All Sheet Numbers.
	INT GetMaxRow(){return MAXRow;}
	~CSearch();//Deconstructor
protected:
	INT Sheet;//Sheet Numbers.
    INT *IJ;//An Array for indexing existance of substring.
	CString *Cs;//An Array to contain substring at index location. 
	INT *IJK;//For All Sheet Name contain every Sheet NAme.
	CString *Csk;//For All Substrings;
	CSpreadSheet *CMA;
	INT MAXRow;//Maximum Row.
	
	
};
#endif