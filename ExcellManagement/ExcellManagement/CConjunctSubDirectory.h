//CConjunctDirectory class is a child of CDVDNon class and 
//use of Cojunction of SubDirectories used for NonDVD Standrard 
//to reduce number of rows.
//By Ramin Edjlal. Urmia Iran.
#ifndef _CCONJUNNCTSUBDIRECTORY_H
#define _CCONJUNNCTSUBDIRECTORY_H

#include "stdafx.h"

class CConjunctSubDirectory
{
private:

public:
	CConjunctSubDirectory(INT SheetA);//Constructor.
	INT CFindGreatestSubDirectoryLenghtIfNotMarked(CStringArray &AllSubDirectoryP,INT *MarkedAllSubDirectoryP);//Retrun Greatest Subdirectory lenght. 
	INT SumOfMarked(INT *MarkedAllSubDirectoryP,INT Marked,INT *FileNoNP);//To Find Sum Of AllSubDirectory.	
	BOOL CCreateMarkedArray(CStringArray &AllSubDirectoryP,INT *MarkedAllSubDirectory,INT *MarkedP,INT *FileNoNP);//To Create Marked Arrray.		
	BOOL CRetriveMarkedWithE(INT Marked,INT* MarkedAllSubDirectoryP,CStringArray &AllSubDirectoryP,CStringArray &SubMarkedAllSubStringDirectory);//To retrive All SubString with marked E.
	INT CFindSmallestSubDirectoryMarkedWithE(CStringArray &AllSubDirectoryP,INT *MarkedAllSubDirectoryP,INT MarkedP);//To retrive smallest Subdirectory Marked with E. 
	~CConjunctSubDirectory();//Deconstructor.
	INT GetSheetNeed(){return SheetNeed;}
protected:
	CString LastFindGreatest;//Strore Last Containing Greatest Find UnMarked variable of Subdirectory. 
	INT SheetNeed;
	INT Sheet;
};
#endif