//CMounth Class is derived from CspradSheet Class and is for Mounth Algorithm to add 
//list of One Mounth to Excel Sheet.
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"
//Constructor.
CMounth::CMounth(INT SheetA):CSpreadSheet(),CIllegalCharacterInDataBase()
{	
	//Initiate protected variables.
	Index=0;
	FileNo=0;
	MaxFileNo=0;
	Days=L"";
	AllDays=L"";
	CurrentDirectories.RemoveAll();
	Sheet=SheetA;
}

//Constructore.
CMounth::CMounth(CString File, CString SheetOrSeparator, bool Backup,BOOL XLSXA,INT SheetA):CSpreadSheet(File, SheetOrSeparator,XLSXA,Backup) 
{
	//Initiate protected variavles.
	Index=0;
	FileNo=0;
	MaxFileNo=0;
	Days=L"";
	AllDays=L"";
	CurrentDirectories.RemoveAll();
	Sheet=SheetA;
}

//Return Days variable for chiled classess.
CString CMounth::GetDays()
{
return Days;
}

//A function for find days in a Mounth in well-defined system.
BOOL CMounth::CFindDays(CString Root)
{
  try
   {
   //Initiate day protected varables and local variables.		
   Days=L""; 
   HANDLE          hFile;                   // Handle to file
   WIN32_FIND_DATA FileInformation;         // File information

  
   //To convert CString Root variable to char array pointer.
  WCHAR path[MAX_PATH_THIS_PROJECT];
   memset(path,0,MAX_PATH_THIS_PROJECT*sizeof(WCHAR));
   for(int i=0;i<Root.GetLength();i++)
	   path[i]=Root.GetString()[i];	
   //A if for find first days.		
   if(( hFile = ::FindFirstFile(path, &FileInformation)) != INVALID_HANDLE_VALUE )
   {
      do
      {	
	//Ignore some directories.
         if ( !lstrcmp( FileInformation.cFileName, L"."   )) continue;
         if ( !lstrcmp( FileInformation.cFileName, L".."  )) continue;
         


         // dirFile.name is the name of the file. Do whatever string comparison 
         // you want here. Something like:
	//Add Days together with separetor variables.
         Days=Days+L"."+(CString)FileInformation.cFileName;

	//To find next day in well-defined system of directories.
       }  while ((::FindNextFile(hFile,&FileInformation) != 0)&&(hFile != INVALID_HANDLE_VALUE ) );

	//Close file find syste,.
      ::FindClose(hFile);	
	
	//Add a point to end of days variables.
	  Days=Days+L".";
		
	//A prereserev state that has to effect.
	  CString Correction=L"";
	  CString Inter=L"";
	 Inter=Days;
	 Days=L"";
	while(Inter.GetLength()>1)
	{
	  
	  Correction=Inter.Mid(1,8);
	  Days=Days+Correction+L".";
	  Inter.Replace(L"."+Correction,L"");
    }
   }
   else
	   return FALSE;
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Find Days in One Month",0,0);
		return FALSE;
	}

   return TRUE;
}

//To find Files in a day.
BOOL CMounth::CFindFiles(CString Root)
{
	try
	{
   //Local variables.	
    HANDLE          hFile;                   // Handle to file
    WIN32_FIND_DATA FileInformation;         // File information
	BOOL A=TRUE;
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
	CString szPath=L"\\"+(CString)FileInformation.cFileName;
	DWORD dwAttrib = GetFileAttributes(Root+szPath);

        if( (dwAttrib != INVALID_FILE_ATTRIBUTES && 
        (dwAttrib & FILE_ATTRIBUTE_DIRECTORY))) 
        {
		 
		 CFindFiles(Root+szPath);
		 }

		 else
		 {
         // dirFile.name is the name of the file. Do whatever string comparison 
         // you want here. Something like:
	//Add Files of found.
         Files=Files+(CString)FileInformation.cFileName+L"\\";
		 FileNo++;
		 }
		
	//To find next file.
      }  while ((::FindNextFile(hFile,&FileInformation) != 0)&&(hFile != INVALID_HANDLE_VALUE ) );
      ::FindClose(hFile);	
	  
   }
   else
	   return FALSE;

   //Remove illegal character.
   Files=RemoveChar(Files);;
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Found Files in One Days.",0,0);
	}
   return TRUE;
}
BOOL CMounth::CFindFilesInCurDirectory(CString Root)
{
	try
	{
	 //Local variables.	
    HANDLE          hFile;                   // Handle to file
    WIN32_FIND_DATA FileInformation;         // File information
	BOOL A=TRUE;
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
	CString szPath=L"\\"+(CString)FileInformation.cFileName;
	DWORD dwAttrib = GetFileAttributes(Root+szPath);

        if( (dwAttrib != INVALID_FILE_ATTRIBUTES && 
        (dwAttrib & FILE_ATTRIBUTE_DIRECTORY))) 
        {
		 
		}
		 else
		 {
         // dirFile.name is the name of the file. Do whatever string comparison 
         // you want here. Something like:
	     //Add Files of found.
         this->Files=Files+(CString)FileInformation.cFileName+L"\\";
		 FileNo++;
		 }
		
	   //To find next file.
      }  while ((::FindNextFile(hFile,&FileInformation) != 0)&&(hFile != INVALID_HANDLE_VALUE ) );
      ::FindClose(hFile);	
	  
   }
   else
	   return FALSE;

   //Remove illegal character.
   Files=RemoveChar(Files);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Found Files in Current Days.",0,0);
		return FALSE;
	}
   return TRUE;
}
BOOL CMounth::CCreateSpecificDayInExcell()
{

	try{
	//Dates Create constructor creating pointer.
	CCreateDates *MCA=new CCreateDates(this->Days,this->Files,this->AllDays,Sheet);
	
	//Create Georgian dates of Days variables.	
	MCA->CCreateGDates();
	
	//Read cell of last row in first coulmn.
	CString CellValue;
	if(!this->ReadCell(CellValue,1,2))
	{
		//Get excell format of current day.
		CellValue=MCA->CCreateExcellFormat(MCA->GetGDays().Mid(0,8));
		
		//Add 1-3 header row cell values.
		this->AddCell(L"Date",1,1);
		this->AddCell(L"Root",2,1);	
		this->AddCell(L"Path",3,1);	
	}
	
	 //Create file format of read cell value.	
	CString FileCellValue=MCA->CCreateFileFormat(CellValue);
	
	//Iniziate index variable.
	int Cur=0;
	
	//Create Georgian dates.
	if(!MCA->CCreateGDates())
		return FALSE;
	
	AllDays=CellValue+'.';
	CString IncDate=FileCellValue;
	
	//Adds non instance days conclusion between days found.	
	while(Cur<MCA->GetGDays().GetLength())
	{
	CString CurDate=MCA->GetGDays().Mid(Cur,8);
	

	while(_wtoi(IncDate)<_wtoi(CurDate))
	{
		IncDate=MCA->AddOneDayToDate(IncDate);
		AllDays+=MCA->CCreateExcellFormat(IncDate)+'.';	
	}

	Cur+=9;	
	}
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Create Specific Day Excel Date.",0,0);
		return FALSE;
	}
	return TRUE;

}

//Add file in current file day folder to a new row of excell file.
INT CMounth::CAddFilesInCurrentDay(CString GDayIfStandardISFalse,CString Root,INT Cur,INT DVD,INT iFileIndex,BOOL Standard)
{
	try
	{
//A local value.
CStringArray csCString;
if(Standard)
{
//CreateDates class constructor pointer.
CCreateDates *CMA=new CCreateDates(this->Days,this->Files,this->AllDays,Sheet);

//Create georgian dates.
if(!CMA->CCreateGDates())
	return 0;
//prepare CStringArray for row writing.
csCString.SetAtGrow(0,CMA->CCreateExcellFormat(CMA->GetGDays().Mid(Cur,8)));
}
else
//prepare CStringArray for row writing.
csCString.SetAtGrow(0,GDayIfStandardISFalse);
CString csDVD;
csDVD.Format(L"%d",DVD);
csCString.SetAtGrow(1,csDVD);
csCString.SetAtGrow(2,Root);
int CrCurBegin=0;

for(int i=0;i<iFileIndex;i++)
		CrCurBegin=this->Files.Find(L"\\",CrCurBegin+1);

int CrCurEnd=0;
INT Column=3;

INT Dummy=this->Files.GetLength();
while(iFileIndex<FileNo)
{
CrCurEnd=this->Files.Find(L"\\",CrCurBegin+1);

csCString.SetAtGrow(Column,this->Files.Mid(CrCurBegin,CrCurEnd-CrCurBegin));

iFileIndex++;
Column++;
CrCurBegin=CrCurEnd+1;

}


//Add new row.
if(!this->AddRow(csCString,0,false))
	return 0;
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Adding Files In Current Day.",0,0);
		return 0;
	}
return FileNo;
}
//To update header with new state file number found.
BOOL CMounth::CUpdateFileNumberInFiledRow()
{
	try{

 	CString I;
	
        //Update header numbers with FileX format.
        while(m_aFieldNames.GetCount()<FileNo+3)
         {
			CString No;
			No.Format(L"%d",m_aFieldNames.GetCount()-2);
			No=L"File"+No;
			m_aFieldNames.Add(No);
			
			
		}
		
	//Update header if less than 255.
        if(m_aFieldNames.GetCount()<=254)
		{
		
		//Prepare and add header.			
		CStringArray Copy_m_aFieldNames;
		Copy_m_aFieldNames.Copy(m_aFieldNames);		
		if(m_aFieldNames.GetCount()>m_dTotalColumns)
	    	if(!this->AddHeaders(Copy_m_aFieldNames,true))
						return FALSE;
		
		}
		 	
	
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Updating Heder File.",0,0);
		return FALSE;
	}
	return TRUE;
}
//Core of adding and preaparing days of mounth and files to new row.
INT CMounth::CAddFilesInMounth(CString Date,CString Root,INT DVD,BOOL Limit,INT CurertDayIfLimit,BOOL XLSXS)
{
	try{
		
		//Iniziate and local variables.
 		BOOL AllIsInExceell=TRUE;
		CString Day;
		CString DVDS;
		CString I;
           CString CellValue;

		
	
		
		//Creates Gerogian dates.
		CCreateDates *MCA=new CCreateDates(this->Days,this->Files,this->AllDays,Sheet);
		
		//Convert DVD of ineger type to CString .
		DVDS.Format(L"%d",DVD);
		if(DVDS.GetLength()==1)
			DVDS=L"0"+DVDS;
		
		//If less than 255 do			
		if(!Limit)
		{
		
		//To find Maximum number of files in a Mounth folder.
		
		//if(!this->CMaxFileNoInMounth(Root))
		//	return -2;
		
		//Create Georgian dates.	  
     		 MCA->CCreateGDates();
	   
	  //Read Last row in fisrst column format.
	  if((!this->ReadCell(CellValue,1,m_dTotalRows))&(CellValue!=L""))		
		return -2;
		
           //A loop for calculating index of current day.
	   while(CurertDayIfLimit<Date.GetLength())
		{
		
		//find current day.				
		Day=Date.Mid(CurertDayIfLimit,8);
		if(Day==L"13920802")
			Day=L"13920802";
		//If there is not day added to preiouce rows do.
		if((_wtoi(MCA->CCreateFileFormat(CellValue))<_wtoi(MCA->GetGDays().Mid(CurertDayIfLimit,8)))||(CellValue==L""))
			{
	
			//Iniziate local variables.
			AllIsInExceell=FALSE;
			FileNo=0;
			Files=L"";
	
			//Find files of current days.
	     	     if(!this->CFindFiles(Root+Days.Mid(CurertDayIfLimit,8)))
					  return -2;
				 //To Split More than Sheets to Sheet Number and more rows.
				 if(FileNo>(Sheet*251))
				     return -1*CurertDayIfLimit;	 
				 //If Not.
				 else
				 {
                //If files number are less than 255.
	    		if(((FileNo-3)<255)&&(FileNo>0))
				{
	
				//If header is upadtaeed.
				if(m_dTotalColumns<FileNo+3)
					{
				if(!this->CUpdateFileNumberInFiledRow())
					{	
					delete MCA;	
					return -2; 	
                  			}
			         }
                          
				//Add files in current day to new row.
				 if(!this->CAddFilesInCurrentDay(Day,Root,CurertDayIfLimit,DVD,0,TRUE))
			       	 {	
                                 delete MCA;	
				return -2;	
				 }
				}
				//If conditions dose not prepared.
			 	else
					//If there is file in day found.
					if(FileNo>0)
					{	
						//Update header.
						if(!this->CUpdateFileNumberInFiledRow())
							{
						delete MCA;	
						return -2; 	
							}
						 return CurertDayIfLimit;
					}
				 }
														
		 }

	//Increase day index in Days file.	
	CurertDayIfLimit+=9;
	}
		
		}
		//If file numbers is greater than 255
		else
		{
			//Create Georgian Days format.
			 MCA->CCreateGDates();

			//Initiate local variables.
			CString SubRoot=L"*";	        
			SetFileNo(0);
			SetFiles(L"");
				 
                        //Find days of Current days folder.
			CFindDays(Root+SubRoot);
			
			//Create Excell format of gerogian days found.
			if(!CCreateSpecificDayInExcell())
				return -2;
            //Update header.		
            if(!CUpdateFileNumberInFiledRow())
				return -2;
	
			//make empty a local variables.
			CStringArray m_aFieldNamesCopied;
			m_aFieldNamesCopied.RemoveAll();
			m_aFieldNamesCopied.Copy(m_aFieldNames);
			m_aFieldNames.RemoveAll();

			//create constructor and pointer.
			OLDBLimitColumn *oldbLimit= new OLDBLimitColumn(this->m_sFile,L"Sheet1",FALSE,XLSXS,Sheet);

			//Remove limit of OLDEB CSpreadsheet class.
 			int RetCode=oldbLimit->OLDBLimitRemover(m_aFieldNamesCopied,MCA->CCreateExcellFormat(MCA->GetGDays().Mid(CurertDayIfLimit,8)),Days.Mid(CurertDayIfLimit,8),DVDS,Root,CurertDayIfLimit,this,TRUE,XLSX);
        		return RetCode;
			
		}
		
		
		if(AllIsInExceell)
			return -5;
		}catch(CException&e)
		{
			::MessageBox(0,L"Error Files Adding In Current Mounth.",0,0);
			return -2;
		}
		
	return -3;
}

//To find maximum number of file in current days.
BOOL CMounth::CMaxFileNoInMounth(CString Root)
{
try{
//Initiate local variable.
int Cur=0;
//until index finished.
while(Cur<Days.GetLength())
{

//Initiate protected variables.
FileNo=0;
Files=L"";

//Find files of every day.
this->CFindFiles(Root+Days.Mid(Cur,8));

//Find Maximum.
if(FileNo>MaxFileNo)
	MaxFileNo=FileNo;
Cur+=9;
}
}
catch(CException&e)
{
	::MessageBox(0,L"Error Maximum File Number Found.L",0,0);
	return FALSE;
}
return TRUE;
}
BOOL CMounth::CFindDirectoriesInCurDirectory(CString Root)
{
	try
	{
 //Local variables.	
    HANDLE          hFile;                   // Handle to file
    WIN32_FIND_DATA FileInformation;         // File information
	BOOL A=TRUE;
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
	CString szPath=L"\\"+(CString)FileInformation.cFileName;
	DWORD dwAttrib = GetFileAttributes(Root+szPath);

        if( (dwAttrib != INVALID_FILE_ATTRIBUTES && 
        (dwAttrib & FILE_ATTRIBUTE_DIRECTORY))) 
        {
			CurrentDirectories.Add(FileInformation.cFileName);
		}
		 else
		 {
    	 }
		
	//To find next file.
      }  while ((::FindNextFile(hFile,&FileInformation) != 0)&&(hFile != INVALID_HANDLE_VALUE ) );
      ::FindClose(hFile);	
	  
   }
   else
	   return FALSE;

   //Remove illegal character.
   Files=RemoveChar(Files);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Found Files in Current Director.",0,0);
		return FALSE;
	}
   return TRUE;
	
}

//Deconstructor
CMounth::~CMounth()
{

}