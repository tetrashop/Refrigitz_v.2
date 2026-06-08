//This Class Use form Microsoft or another  Corporation(s) Codes to Manage Creating Excell Sheet
//Edited And Calssify by By Ramin Edjlal
//Urmia Iran.
#ifndef _CCREATEEXCELLSHEET_H
#define  _CCREATEEXCELLSHEET_H
#include "stdafx.h"


class CCreateExcellSheet
{
public:
	CCreateExcellSheet();//Constructor
	int CCreateRequireExcellSheet(CString File,int SheetNo);//To Add Requir Sheets to Excel File.
	~CCreateExcellSheet();//Deconstructor.
};
#endif