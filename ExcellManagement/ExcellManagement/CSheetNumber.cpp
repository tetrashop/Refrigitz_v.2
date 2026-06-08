#include "stdafx.h"
CSheetNumber::CSheetNumber(INT SheetA)
{
	Sheet=SheetA;
	SheetNeed=0;
}

INT CSheetNumber::CCalculateSheetNumber(CString File,CString Root1,CString Root2,INT DVD1,INT DVD2,BOOL XLSX)
{
	INT MAXFileNo=0;
	try
	{
	//For DVD01 to DVD06 do.  
		for(int i=DVD1;i<DVD2+1;i++)
		{
 		 //Create DVD Name from DVD number.
		CString DVDS;		
		DVDS.Format(L"%d",i);
		if(DVDS.GetLength()==1)
			DVDS=L"0"+DVDS;
		DVDS=L"DVD"+DVDS;

		//Constructor and pointer.
		CDVDNon *CMA=new CDVDNon(File,Root1+DVDS+L"\\"+Root2,L"Sheet1",TRUE,i,Sheet,XLSX);

		//To Find and retrive Date of given root.
		if(!CMA->CFindDirectoriesInCurDirectory(Root1+DVDS+L"\\"+Root2))
			return FALSE;
			//To find All SubDirectoryes in Root.
   	   if(!CMA->CFindAllSubDirectoiesOfNonDVDS(Root1+DVDS+L"\\"+Root2))
			return FALSE;

	   //To find all Files in all Subdirectories.
	   if(!CMA->CFindAllFilesForEveryFoundSubDirectory())
	       return FALSE;

	   //Create Marked Array.

	   if(!CMA->CCreateMarkedArray(CMA->GetAllSubDirectories(),CMA->GetMarkedAllSubDirectory(),CMA->GetMarked(),CMA->GetFileNoN()))
	   {
		   SheetNeed=CMA->GetSheetNeed();
	       return FALSE;
	   }

	   //For Every Marked Number.
	   for(int k=0;k<=*(CMA->GetMarked());k++)
		{
		
		//Retrive Al SubDirectories Marked With k variable.
		if(!CMA->CRetriveMarkedWithE(k,CMA->GetMarkedAllSubDirectory(),CMA->GetAllSubDirectories(),CMA->GetAllSubDirectoryMarkedWithE()))
			return FALSE;

		//Inizialize variables.
		CMA->SetFiles(L"");
		CMA->SetFileNo(0);

		//Find Minimum SubDirectory Marked with k.
		INT MIN=CMA->CFindSmallestSubDirectoryMarkedWithE(CMA->GetAllSubDirectories(),CMA->GetMarkedAllSubDirectory(),k);

		//If Not Found return FALSE.
		if(MIN==-1)
			return FALSE;
		
		//To find Files of Marked SubDirectory with k.
		for(int i=0;i<CMA->GetAllSubDirectoryMarkedWithE().GetCount();i++)
		{
				if(!CMA->CFindFilesInCurDirectory(CMA->GetAllSubDirectoryMarkedWithE().GetAt(i)))
					return FALSE;
				
		}
		if(MAXFileNo<CMA->GetFileNo())
			MAXFileNo=CMA->GetFileNo();
				
	   }
	   delete CMA;

		}

	}catch(CException&e)
	{
		::MessageBox(0,L"Error Calculate Sheet Number.",0,0);
		return -1;
	}
	
	return MAXFileNo/254+1;
}
CSheetNumber::~CSheetNumber()
{

}