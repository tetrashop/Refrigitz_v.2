//Conjuncting Files is of one of purposes in Creating Markes.
//Ramin Edjla.Urmia Iran.
#include "stdafx.h"
//Constructor
CCreateExcellSheet::CCreateExcellSheet()
{
};
//A Function To Add Require Sheets to Excell File 
int CCreateExcellSheet::CCreateRequireExcellSheet(CString File,int SheetNo)
{
	//Inizialize Local Variables.
	char FileC[MAX_PATH];
	WCHAR SheetNameC [MAX_PATH];
	for(int i=0;i<=File.GetLength();i++)
		FileC[i]=(char)File.GetAt(i);
	int Length=0;
	int Point=0;
	for(int i=File.GetLength();File.GetAt(i)!='\\';i--)
		Length=i;
	for(int i=File.GetLength();File.GetAt(i)!='.';i--)
		Point=i;
	for(int i=Point-2;i>=Length;i--)
	{
		SheetNameC[i-Length]=File.GetAt(i);
	}
	SheetNameC[Point-1-Length]=0;
  CoInitialize(NULL);
  try
  {
	//Activate Sheets.
    Excel::_ApplicationPtr XL;
    HRESULT hr = XL.CreateInstance(L"Excel.Application");

	//XL->Workbooks->Open(FileC);

	//Create Header Sheet Name
    Excel::_WorkbookPtr workbook = XL->Workbooks->Add(Excel::xlWorksheet); 
    Excel::_WorksheetPtr worksheet = XL->ActiveSheet;
    worksheet->Name =L"Sheet" ;
	
	//Add Require Sheet Number to WorkSeet.  
 	for(int i=SheetNo;i>=1;i--)
	{
		char SheetName[8];
		SheetName[0]='S';
		SheetName[1]='h';
		SheetName[2]='e';
		SheetName[3]='e';
		SheetName[4]='t';
		if(i<10)
		{
		SheetName[5]=(char)(i+(int)'0');
		SheetName[6]=0;
		}
		else
		{
		i=i-10;
		SheetName[5]=(char)(1+(int)'0');
		SheetName[6]=(char)(i+(int)'0');
	    SheetName[7]=0;
		i=i+10;
    	}
	    worksheet = XL->Worksheets->Add(); // adding worksheets!!
        worksheet->Name = SheetName;
 	}

	//Save File.
    worksheet->SaveAs(FileC);

	//Close WorkeSheet.
    workbook->Close();

	//Quite From Sheets.
    XL->Quit();
  }
  catch(_com_error &ce)
  {
    
  }

  //CoInizialize.
  CoUninitialize();

 
  return 0;
}

CCreateExcellSheet::~CCreateExcellSheet()
{
}