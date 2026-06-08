//CDVD Class is derived from CMounth Class and is for DVD Algorithm to add 
//list of One DVD to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"
CDVD::CDVD(CString File, CString Root,CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA,BOOL XLSX):CMounth(File,SheetOrSeparator,Backup,XLSX,SheetA)
{       
	//Initiate protected varibles.
	Sheet=SheetA;
	Mounth=L"";
	CString SubRoot=L"*";
	Root=Root+SubRoot;
	//To find Mounth in Root folder of every DVD.
	this->CFindMounthAndStoredAndSorted(DVD,Root,XLSX);
	
}
BOOL CDVD::CFindMounthAndStoredAndSorted(INT DVD,CString Root,BOOL XLSX)
{
    try
    {
    //Initiate Month varivle to empty
    Mounth=L"";
    //This section convert CString data type to char array.
     HANDLE          hFile;                   // Handle to file
    WIN32_FIND_DATA FileInformation;         // File information
    WCHAR path[MAX_PATH_THIS_PROJECT];
    memset(path,0,MAX_PATH_THIS_PROJECT*sizeof(WCHAR));
    for(int i=0;i<Root.GetLength();i++)
	   path[i]=Root.GetString()[i];
    //This line find first file or folder of root directory.    
    if(( hFile = ::FindFirstFile(path, &FileInformation)) != INVALID_HANDLE_VALUE )
    {
      do
      {
	 //These lines ignore from root path of first and second of current directory.
        if ( !lstrcmp( FileInformation.cFileName, L"."   )) continue;
         if ( !lstrcmp( FileInformation.cFileName, L".."  )) continue;
		 
          

	 //To Add found always directory to Mounth with separator character.
         // dirFile.name is the name of the file. Do whatever string comparison 
         // you want here. Something like:
         Mounth=Mounth+L"."+(CString)FileInformation.cFileName;

	//To find next file and continue untle last file found.
      }  while ((::FindNextFile(hFile,&FileInformation) != 0)&&(hFile != INVALID_HANDLE_VALUE ) );

	//Close find file system.
     	 ::FindClose(hFile);	
	//This line add a point to end of Mounth varibale.
	 Mounth=Mounth+L".";
	
	 CString Correction=L"";
	 CString Inter=L"";
	 Inter=Mounth;

	//These line was for sorting desiding and currently has no effect.
	 Mounth=L"";
	while(Inter.GetLength()>1)
	{
	  
	  Correction=Inter.Mid(1,6);
	  Mounth=Mounth+Correction+L".";
	  Inter.Replace(L"."+Correction,L"");
	  
	 }
   }
  	}
	catch(CException&e)
	{
		return FALSE;
	}

   return TRUE;
}
BOOL CDVD::CAddFilesInDVD(CString DVDRoot,INT DVD,BOOL XLSX)
{
	//These lines initiate local variables.
	INT Cur=0;	
	INT RetCode=-1;
	INT RetCodePer=-1;

	//This line constructe CMounth pointer.	
	CMounth *CMA=new CMounth(this->m_sFile,L"Sheet1",TRUE,XLSX,Sheet);

	//A while statement for while Mounth variable travle.
	while(Cur<Mounth.GetLength())
	{

	//To initiate local variable.
	RetCode=-1;
	RetCodePer=-1;
	CString SubRoot=L"*";
	CMA->SetFileNo(0);
	CMA->SetFiles(L"");

	
	//Retrive Current date of Mounth and prepare for use.	
	CString Root=DVDRoot;
	CString Date=Mounth.Mid(Cur,6);
	Root+=Date;
	Root+=L"\\";
	
	//To Find days of current Mounth.	
	CMA->CFindDays(Root+SubRoot);

	//Create Excel format of all days.
	if(!CMA->CCreateSpecificDayInExcell())
		return FALSE;
	//while return code dose not equal to exit code.
  while(RetCode!=-3)
  {
	//If operation begine.
	
	if(RetCode==-1)
	{
     	RetCode=CMA->CAddFilesInMounth(CMA->GetDays(),Root,DVD,FALSE,0,XLSX);

	//when operation compeleted or need to more than 255 column or exit or failer.
	RetCodePer= RetCode;
	}
	else
		//If needs more than 255 column.
		if(RetCode>0)
			   RetCode=CMA->CAddFilesInMounth(CMA->GetDays(),Root,DVD,TRUE,RetCode,XLSX);
			   else
				//This line is when operation is successfully.
				if(RetCode==-5)
					   break;
				else	
				//A prereserev state.			
	        	if(RetCode==-4)
					{
						delete CMA;
						CMA=new CMounth(this->m_sFile,L"Sheet1",FALSE,XLSX,Sheet);
						CMA->SetFileNo(0);
						CMA->SetFiles(L"");
						CMA->CFindDays(Root+SubRoot);
						if(!CMA->CCreateSpecificDayInExcell())
							{
							return FALSE;
							}
					    RetCode=CMA->CAddFilesInMounth(CMA->GetDays(),Root,DVD,FALSE,RetCodePer+9,XLSX);
					}
				else
					//To Split More than Sheets to Sheet Number and more rows.
					if(RetCode==0||RetCode<=-8)
						 {
					    	 //Constructor and pointer.
					    	 CDVDNon *CMAN=new CDVDNon(this->m_sFile,Root,L"Sheet1",FALSE,0,Sheet,XLSX);
							 CMAN->SetFileNo(0);
							 CMAN->SetFiles(L"");
						     CMAN->CFindDays(Root+SubRoot);
						

						     CMAN->CUpdateHeaderAndWriteRow(CMAN->GetDays().Mid(RetCode*-1,8),Root.Mid(0,Root.GetLength()-1)+"\\"+CMAN->GetDays().Mid(RetCode*-1,8),0,DVD,0,FALSE,XLSX);
						     delete CMAN;
							 RetCodePer=RetCode*-1;
							 RetCode=-4;
				 }
			
					//Failer state.
					 if(RetCode==-2)
							{
							//MessageBox(NULL,"Operatiorn Not Completed.",0,0);
							return FALSE;
							}
 			
	}
	//Increased of index variable.
    Cur+=7;
    
	}
	
	return TRUE;
}
//Deconestractor function.
CDVD::~CDVD()
{

}
