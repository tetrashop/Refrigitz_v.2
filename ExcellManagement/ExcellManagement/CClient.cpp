//CCLient Class containe tow function 
//for Standard and non standard DVDS. 
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"

//Constructor.
CClient::CClient(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA)
{
	Sheet=SheetA;
}

//For Standard DVD.
BOOL CClient::CClientForStandardDVDS(CString File,INT DVD1,INT DVD2,CString Root1,CString Root2,BOOL XLSX)
{
	try{
		//For DVD07 to DVD11.
	  for(int i=DVD1;i<DVD2+1;i++)
	  {
		 //Create DVD Name from DVD number.
		INT DVD=i;
		CString DVDS;
		DVDS.Format(L"%d",DVD);
		if(DVDS.GetLength()== 1)
			DVDS=L"0"+DVDS;
		DVDS=L"DVD"+DVDS;

		//Constructor and pointer.
	    CDVD *CMA=new CDVD(File,Root1+DVDS+L"\\"+Root2,L"Sheet1",TRUE,DVD,Sheet,XLSX);
	
		//Add Files In Every i DVD to excel.
		if(!CMA->CAddFilesInDVD(Root1+DVDS+L"\\"+Root2,DVD,XLSX))
			return FALSE;
		//Free memeory.
		delete CMA;
		//Root1 =L"E:\\Docs\\";
		//Root2 =L"RaminEdjlal\\";
	 }
	}
	  catch(CException&E)
	  {
		  return FALSE;
	  }
  return TRUE;
}
//For Non Standard DVD.
BOOL CClient::CClientForNonStandardDVDS(CString File,INT DVD1,INT DVD2,CString Root1,CString Root2,BOOL XLSX)
{
	try{
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
		
		//Root1 =L"E:\\Docs\\DVD";
		//Root2 =L"RaminEdjlal\\";
	
		//If Number of dates are greater than 1 return FALSE.
		if(CMA->GetCurrentDirectories()->GetCount()>1)
			return FALSE;

		//Update and srore Files and rows of Excel sheets.
		if(!CMA->CUpdateHeaderAndWriteRow(CMA->GetCurrentDirectories()->GetAt(0),Root1+DVDS+L"\\"+Root2,0,i,0,FALSE,XLSX))
			return FALSE;

		//Free memeory.
		delete CMA;
		}
	}catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}
//Deconstructor.
CClient::~CClient()
{


}
