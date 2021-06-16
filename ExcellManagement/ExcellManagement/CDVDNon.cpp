//CNonDvd Class is derived from CMounth Class and is for Non DVD Algorithm to add 
//list of One Non DVD to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"

//Constructor.
CDVDNon::CDVDNon(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA,BOOL XLSX):CMounth(File,SheetOrSeparator,Backup,XLSX,SheetA),CConjunctSubDirectory(SheetA)
{
	//Inizialize protected variables.
	Sheet=SheetA;
	AllFileInDVD.RemoveAll();
	AllSubDirectories.RemoveAll();	
	FileNo=0;
	Marked=0;
	memset(FileNoN,0,sizeof(INT)*MAX_PATH_THIS_PROJECT);
	memset(MarkedAllSubDirectory,-1,sizeof(INT)*MAX_PATH_THIS_PROJECT);	

}

//Tor find SubDirectoryes Located in a Non Standard DVD.
BOOL CDVDNon::CFindAllSubDirectoiesOfNonDVDS(CString Root)
{
	try
	{
	INT ii=0;
	//Local variables.	
	HANDLE          hFile;                   // Handle to file
    WIN32_FIND_DATA FileInformation;         // File information

   //To convert CString to char array.
   WCHAR path[MAX_PATH_THIS_PROJECT];
   memset(path,0,MAX_PATH_THIS_PROJECT*sizeof(WCHAR));
   for(int i=0;i<Root.GetLength();i++)
	   path[i]=Root.GetString()[i];
   lstrcat(path,L"\\*"); 
   
   //To find first file.
   if(( hFile = ::FindFirstFile((LPCWSTR)path, &FileInformation)) != INVALID_HANDLE_VALUE )
   {
      do
      {
	//To ignore some sub directories.
     if ( !lstrcmp( FileInformation.cFileName, L"."   )) continue;
     if ( !lstrcmp( FileInformation.cFileName, L".."  )) continue;
             
        //Initiate variables and detecting subdirectories of curren day directory recursivley. 
	CString szPath;
	szPath.Format(L"%s",L"\\"+(CString)FileInformation.cFileName);
	  
	//If Is Directory and is not Invalid File.
	if((FileInformation.dwFileAttributes != INVALID_FILE_ATTRIBUTES && 
	(FileInformation.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY))) 
     {
	//Add.
	AllSubDirectories.Add(Root+szPath);

	//Call Recursivley.
	CFindAllSubDirectoiesOfNonDVDS(Root+szPath);
		 
	}
	 else
	 {
  	}	//To find next file.
    }  while ((::FindNextFile(hFile,&FileInformation) == TRUE)&&(hFile != INVALID_HANDLE_VALUE ));
	  ::FindClose(hFile);	
		  
   }
	}catch(CException&e)
	{
		
	   return FALSE;
	   }

   return TRUE;

}

//To Find Files for every all Subdirector.
BOOL CDVDNon::CFindAllFilesForEveryFoundSubDirectory()
{
	try{

	//For Every Subdirectory calll Spesific Function.
	for(int i=0;i<AllSubDirectories.GetCount();i++)
	{
		CString Root=AllSubDirectories.GetAt(i);
		Files=L"";
	    FileNo=0;	
		if(!this->CFindFilesInCurDirectory(Root))
			return FALSE;
		AllFileInDVD.Add(Files);
		FileNoN[i]=FileNo;
	}

	}
	catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}

//Create Files And FileNo in index i.
BOOL CDVDNon::CCreateFilesForEveryIndexI(INT i)
{
	try
	{
		Files=AllFileInDVD.GetAt(i);
		FileNo=FileNoN[i];
	}
	catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}

//Limit function for less than 255 of Non Standrad DVDs.
BOOL CDVDNon::LimitForNonDVDStandard(CString Root,CString Dates,INT DVD,BOOL XLSX)
{
	try{
		//Creates Gerogian dates.
		CCreateDates *MCA=new CCreateDates(GetDays(),GetFiles(),GetAllDays(),Sheet);
	
		//Initiate local variables.
		CString SubRoot=L"*";	        
		CString DVDS;
		DVDS.Format(L"%d",DVD);
		CStringArray m_aFieldNamesCopied;
		m_aFieldNamesCopied.RemoveAll();
        m_aFieldNamesCopied.Copy(m_aFieldNames);
		

		//create constructor and pointer.
		OLDBLimitColumn *oldbLimit= new OLDBLimitColumn(this->m_sFile,L"Sheet1",FALSE,XLSX,Sheet);

		//Remove limit of OLDEB CSpreadsheet class.
		if(oldbLimit->OLDBLimitRemover(m_aFieldNamesCopied,MCA->CCreateExcellFormat(Dates),NULL,DVDS,Root,0,this,FALSE,XLSX)!=-4)
       		return FALSE;

	}
	catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}

//To Update header and write row.
BOOL CDVDNon::CUpdateHeaderAndWriteRow(CString GDayIfStandardISFalse,CString Root,INT Cur,INT DVD,INT iFileIndex,BOOL Standard,BOOL XLSX)
{
	try
	{
		
		//Create Georgian Date.
		CConvertDate *CMC=new CConvertDate();
		int Day=CMC->OutDateGerogianAll(_wtoi(GDayIfStandardISFalse.Mid(6,2)),_wtoi(GDayIfStandardISFalse.Mid(4,2)),_wtoi(GDayIfStandardISFalse.Mid(0,4)),0);
	    int Mounth=CMC->OutDateGerogianAll(_wtoi(GDayIfStandardISFalse.Mid(6,2)),_wtoi(GDayIfStandardISFalse.Mid(4,2)),_wtoi(GDayIfStandardISFalse.Mid(0,4)),1);
	    int Year=CMC->OutDateGerogianAll(_wtoi(GDayIfStandardISFalse.Mid(6,2)),_wtoi(GDayIfStandardISFalse.Mid(4,2)),_wtoi(GDayIfStandardISFalse.Mid(0,4)),2);
	
		

		CString GDay;
		CString GMounth;
		CString GYear;
		GDay.Format(L"%d",Day);
		if(GDay.GetLength()==1)
			GDay=L"0"+GDay;
		GMounth.Format(L"%d",Mounth);
		if(GMounth.GetLength()==1)
			GMounth=L"0"+GMounth;
		GYear.Format(L"%d",Year);
	    GDayIfStandardISFalse.Replace(GDayIfStandardISFalse.Mid(0,8),GYear+GMounth+GDay);
	
		//Inizialize vaiables.
		INT CCurrenRow=0;

		//Obtaine Curent Row than is less than DVD number.
		CString CellValue=L"";
		do
		{
			CCurrenRow++;
			CellValue=L"";
			this->ReadCell(CellValue,2,CCurrenRow);
			if(_wtoi(CellValue)>=DVD)
				break;			
		}while(CellValue!=L"");
		//if(CCurrenRow!=1)
		CCurrenRow--;

		//Creates Gerogian dates.
		CCreateDates *MCA=new CCreateDates(GetDays(),GetFiles(),GetAllDays(),Sheet);

		//To find All SubDirectoryes in Root.
   	   if(!CFindAllSubDirectoiesOfNonDVDS(Root))
			return FALSE;

	   //To find all Files in all Subdirectories.
	   if(!CFindAllFilesForEveryFoundSubDirectory())
	       return FALSE;

	   //Create Marked Array.

	   if(!CCreateMarkedArray(AllSubDirectories,&(MarkedAllSubDirectory[0]),&Marked,&(FileNoN[0])))
			return FALSE;

	   //For Every Marked Number.
	   for(int k=0;k<=Marked;k++)
		{
			//If Exist ignore.
		if(k+CCurrenRow<=m_dTotalRows-1)	continue;

		//Retrive Al SubDirectories Marked With k variable.
		if(!CRetriveMarkedWithE(k,&(MarkedAllSubDirectory[0]),AllSubDirectories,AllSubDirectoryMarkedWithE))
			return FALSE;

		//Inizialize variables.
		Files=L"";
		FileNo=0;

		//Find Minimum SubDirectory Marked with k.
		INT MIN=CFindSmallestSubDirectoryMarkedWithE(AllSubDirectories,&(MarkedAllSubDirectory[0]),k);

		//If Not Found return FALSE.
		if(MIN==-1)
			return FALSE;
		
		//To find Files of Marked SubDirectory with k.
		for(int i=0;i<AllSubDirectoryMarkedWithE.GetCount();i++)
		{
				if(!CFindFilesInCurDirectory(AllSubDirectoryMarkedWithE.GetAt(i)))
					return FALSE;
		}
		
		m_aFieldNames.RemoveAll();
		m_aFieldNames.SetAtGrow(0,L"Date");
		m_aFieldNames.SetAtGrow(1,L"DVD");
		m_aFieldNames.SetAtGrow(2,L"Path");

		//Update Row.
		if(!CUpdateFileNumberInFiledRow())
				return FALSE;
	
		//If Less than 255 do.
		if(FileNo+3<=254)
		{  
		
		
		while(this->m_aFieldNames.GetCount()<Retrivem_dTotalColumns())
		{
			CString No;
			No.Format(L"%d",this->m_aFieldNames.GetCount()-2);
			No=L"File"+No;
			this->m_aFieldNames.Add(No);	
		}

      	//Add files in current subdirectory to add new row.
		if(!this->CAddFilesInCurrentDay(MCA->CCreateExcellFormat(GDayIfStandardISFalse),RemoveChar(AllSubDirectories.GetAt(MIN)),0,DVD,0,FALSE))
		   	 	return FALSE;	

		}
		else
		//If Exist Limit.
	    if(!LimitForNonDVDStandard(RemoveChar(AllSubDirectories.GetAt(MIN)),GDayIfStandardISFalse,DVD,XLSX))
		 	return FALSE;
	
		}
	}
	catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}

//To find specific path in AllSubDirecoty Function.
INT CDVDNon::FindPathInAllSubdirectory(CString path)
{
	try{
		for(int i=0;i<AllSubDirectories.GetCount();i++)
		{
			if(AllSubDirectories.GetAt(i)==path)
				return i;
		}
	}
	catch(CException&e)
	{
		return -1;
	}
	return AllSubDirectories.GetCount();
}

//Deconstructor.
CDVDNon::~CDVDNon()
{
}