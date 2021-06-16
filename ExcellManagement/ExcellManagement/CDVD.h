//CDVD Class is derived from CMounth Class and is for DVD Algorithm to add 
//list of One DVD to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#ifndef _CDVD_H
#define _CDVD_H
#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <io.h>
#include <time.h>

class CDVD:CMounth
{
private:
	BOOL CFindMounthAndStoredAndSorted(INT DVD,CString Root,BOOL XLSX);//Sore Dates in Well-Defined DVD at Month that defined protected./ 
public:
	CDVD(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA,BOOL XLSX);//Constructore.
	~CDVD();//Deconstructor.
	BOOL CAddFilesInDVD(CString DVDRoot,INT DVD,BOOL XLSX);//To Add Files in DVD to Excel Seet to manage operations.
	
protected:
	CString Mounth;//Month in well-defined DVD.
	INT Sheet;
};
#endif