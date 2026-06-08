//CCreateDates class is a call to inform ConvertDate calss and 
//use of CMounth class variables and derved from these calss.
//By Ramin Edjlal. Urmia Iran.
#ifndef _CCREATEDATES_H
#define _CCREATEDATES_H
#include "stdafx.h"
#include <stdlib.h>
class CCreateDates:public CConvertDate,public CMounth
{
public:
	CCreateDates(CString Days,CString Files,CString AllDays,INT SheetA);
	BOOL CCreateGDates(); //This Function Create A Georgian Date From Hegri Date lis separated wih '.'.
	BOOL CCreateHDates();
	CString AddOneDayToDate(CString Date); //Add one day to day parameter and return it.
	CString DecreaseOneDayFromDate(CString Date); //Decreas One Day From date parameters.
	CString CCreateExcellFormat(CString File); //Create Excell Format Date from standard format.
	CString CCreateFileFormat(CString Excell); //Create Standard Format Date from Excell format.
	CString GetGDays(); //return GDays variable.
	~CCreateDates();
protected:
	CString GDays;//To Store Converted Dates to georigian.
	INT Sheet;
};
#endif