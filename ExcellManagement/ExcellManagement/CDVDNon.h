//CNonDvd Class is derived from CMounth Class and is for Non DVD Algorithm to add 
//list of One Non DVD to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#ifndef _CDVDNON_H
#define _CDVDNON_H
#include "stdafx.h"
class CDVDNon:public CMounth,public CConjunctSubDirectory
{

	
public:
	CDVDNon(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA,BOOL XLSX);//Constructor
	
	BOOL CFindAllSubDirectoiesOfNonDVDS(CString Root);//Find every i subdirectories files.
	BOOL CCreateFilesForEveryIndexI(INT i);//To retrive files for every index i.
	BOOL LimitForNonDVDStandard(CString Root,CString Date,INT DVD,BOOL XLSX);//To Operate as Non DVD Standard.
	INT FindPathInAllSubdirectory(CString path);//reterun index of path in Allsubdirectory protected variables. 
	BOOL CFindAllFilesForEveryFoundSubDirectory();//To find evey files in subdirectory.
	CStringArray& GetAllFileInDVD(){return AllFileInDVD;}
	CStringArray& GetAllSubDirectories(){return AllSubDirectories;}
	CStringArray& GetAllSubDirectoryMarkedWithE(){return AllSubDirectoryMarkedWithE;}
	INT*GetFileNoN(){return &FileNoN[0];}
	INT *GetMarkedAllSubDirectory(){return &MarkedAllSubDirectory[0];}
	INT*GetMarked(){return &Marked;}
	BOOL CUpdateHeaderAndWriteRow(CString GDayIfStandardISFalse,CString Root,INT Cur,INT DVD,INT iFileIndex,BOOL Standard,BOOL XLSX);//To Update header and write row.
	~CDVDNon();//Deconstructor
protected:
	CStringArray AllFileInDVD;//Store All Files In Non Standard DVD.
	CStringArray AllSubDirectories;//Store All Subdirectory In Non Standard DVD.
	CStringArray AllSubDirectoryMarkedWithE;//All SubDirectory that Marked with specific variable E.
	INT FileNoN[MAX_PATH_THIS_PROJECT];//Store Number of Files in Linear Mapped with AllSubDirectories.
	INT MarkedAllSubDirectory[MAX_PATH_THIS_PROJECT];//Store Marked Number to conjunct Subdirectories.
	INT Marked;//Maximum Marked value sored in MarkedAllSubDirectory.
	INT Sheet;
};
#endif