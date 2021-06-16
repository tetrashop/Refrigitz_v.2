//OLDBDLimtColumn Class is derived from CspradSheet Class and CMounth Class and is for 
//Managing Limitation Of Excell Sheet.
//By Ramin Edjlal. Urmia Iran.
#ifndef _OLDBLIMITCOLUMN_H
#define _OLDBLIMITCOLUMN_H
#include "stdafx.h"

class OLDBLimitColumn:CMounth,ExcelManager
{
public:
      OLDBLimitColumn(CString File, CString SheetOrSeparator, bool Backup,BOOL XLSX,INT SheetA);
	  ~OLDBLimitColumn();
	  BOOL Divied_m_aFieldNamesTom_aFiledFirstRowCMounth(CStringArray &m_aFieldNameD,CString Date,CString DVD,CString Path);//Divied First To 255 Filed Second For CMounth class.
	  BOOL CAddFilesInDayForOLDBLimit(CString Day,CString Root,INT DVD,INT Cur); //Add Files in A Mounth Folder to Excell Sheet.
	  BOOL CUpdateFileNumberInFiledRowForOLDBLimt(); //Add Files Number In First Row if number of files in adat is greater than 255. 
	  CStringArray* Getm_aFiledFirstRow(){return m_aFiledFirstRow;}//return m_aFiledFirstRow variable value.
	  INT OLDBLimitRemover(CStringArray &m_aFieldNamesCopied,CString GDateOnExcellFormat,CString hDateOnFileFormat,CString DVD,CString Root,INT CurertDayIfLimit,CMounth *CDVMounth,BOOL Standard,BOOL XLSX);// For Greater than 255;
	  
protected:
	CStringArray m_aFiledFirstRow[MAX_PATH_THIS_PROJECT];//255 Filed Arrays.
	INT m_aFiledFirstRowLen;//Length of m_aFiledFirstRow
	BOOL IsGreter;//Determine if greater than 255 if was true
	INT Sheet;

};
#endif