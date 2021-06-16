
//CMounth Class is derived from CspradSheet Class and is for Mounth Algorithm to add 
//list of One Mounth to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#ifndef _CMOUNTH_H
#define _CMOUNTH_H

#include "stdafx.h"

#include <stdio.h>
#include <stdlib.h>
#include <io.h>
#include <time.h>

class CMounth:public CSpreadSheet,public CIllegalCharacterInDataBase
{
public:
	CMounth(INT SheetA);// Open spreadsheet for reading and writing
	CMounth(CString File, CString SheetOrSeparator, bool Backup,BOOL XLSXA,INT SheetA);// Open spreadsheet for reading and writing
	~CMounth();// Perform some cleanup functions
	BOOL CFindDays(CString Root); //Find Days of one Mounth and sort Deasesiding in Days variable.If Successfull return TRUE Otherwise FALSE.
	BOOL CFindFiles(CString Root); //Find Files in Current Day Directory and Store in Files variable.If Successfull return TRUE Otherwise FALSE.
	BOOL CFindFilesInCurDirectory(CString Root); //Find Files in Current  Directory and Store in Files variable.If Successfull return TRUE Otherwise FALSE.
	BOOL CFindDirectoriesInCurDirectory(CString Root); //Find Directoies in Current  Directory and Store in Files variable.If Successfull return TRUE Otherwise FALSE.
	BOOL CCreateSpecificDayInExcell(); //Create Days found in Excell until Current Day.If Successfull return TRUE Otherwise FALSE.
	INT  CAddFilesInCurrentDay(CString GDayIfStandardISFalse,CString Root,INT Cur,INT DVD,INT iFileIndex,BOOL Standard); //Add Files In Current Days.Return Number of Files in FileNo variable if successfulle otherwise zero in FilNo;
	BOOL CUpdateFileNumberInFiledRow(); //Add Files Number In First Row.
	INT CAddFilesInMounth(CString Date,CString Root,INT DVD,BOOL Limit,INT CurertDayIfLimit,BOOL XLSX); //Add Files in A Mounth Folder to Excell Sheet.
	INT  CMaxFileNoInMounth(CString Root);//retrive Max File in Mounth Day Folder.
	VOID SetFileNo(INT m_aFiledFirstRowiLen){FileNo=m_aFiledFirstRowiLen;}//Set FileNo value. 
	VOID SetFiles(CString Fi){Files=Fi;}//Set Files Value.
	INT GetFileNo(){return FileNo;}//Retrun FileNumber.
	CString GetFiles(){return Files;}//Return Files variable value.
	INT Retrivem_dTotalColumns(){return m_dTotalColumns;}//Retrive m_dTotalColumns variable value.
	CString GetAllDays(){return AllDays;}//return AllDays value.
	CString GetDays();//return Days varibale value.
	CStringArray* GetCurrentDirectories(){return &CurrentDirectories;}
protected:
	INT Index; //Current Index of Manupolation.
	CString Days; //Stored Days of one Mounth Deasesiding.
	CString Files; //Stored Files of Current Day Directory. 
	INT FileNo; //File Numbers In Current Day.
	INT MaxFileNo; //Store Maximum File Number in Days .
	CString AllDays; //Store All Days contained Days vriable.
	CStringArray CurrentDirectories;//To Store Directories in CurrentDirectories.
	INT Sheet;
	
};

#endif