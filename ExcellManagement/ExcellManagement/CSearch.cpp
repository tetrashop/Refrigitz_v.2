//Search File class implementation.
//Ramin Edjlal.Urmia.Iran.

#include "stdafx.h"
CSearch::CSearch(CString File, CString SheetOrSeparator, bool Backup ,INT SheetA,BOOL XLSX):CSpreadSheet(File,SheetOrSeparator,XLSX,Backup)
{
	Sheet=SheetA;
	MAXRow=0;
}
BOOL CSearch::CSearchAStringAndSubStringInSpecialSheet(CString SubString,BOOL blSubString,CString SheetOrSeparator,BOOL XLSX)
{
	try
	{
		//Constructor and pointer.
		CMA=new CSpreadSheet(m_sFile,SheetOrSeparator,XLSX,false);

		//Initiate protected variables.
 		IJ=new INT[CMA->GetTotalRows(),CMA->GetTotalColumns()];
		Cs=new CString[CMA->GetTotalRows(),CMA->GetTotalColumns()];

		//Find Maximum Rows.
		if(MAXRow<CMA->GetTotalRows()-1)
			MAXRow=CMA->GetTotalRows()-1;

		//Initiate protected variables.
		for(int i=0;i<CMA->GetTotalRows();i++)
			for(int j=0;j<CMA->GetTotalColumns();j++)
			{
				IJ[i,j]=-1;
				Cs[i,j]=L"";
			}

			//Read Cells and find items.
		for(int i=2;i<=CMA->GetTotalRows();i++)
			for(int j=1;j<=CMA->GetTotalColumns();j++)
			{
				CString CellValue;
				CMA->ReadCell(CellValue,j,i);

				//If Exact items produced.
				if((!blSubString)&&(CellValue==SubString))
				{
					IJ[i-1,j-1]=1;
					Cs[i-1,j-1]= CellValue;
				}
				else
					//If ubstring found.
					if(blSubString&&(CellValue.Find(SubString,0)>0||SubString.Find(CellValue,0)>0))
					{
					  IJ[i-1,j-1]=1;
					  Cs[i-1,j-1]= CellValue;			
					}
			}

		
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Search A String and Sub String In Specific Sheet.",0,0);
		return FALSE;
	}
	return TRUE;
}
BOOL CSearch::CSearchForSeveralSheet(CString SubString,BOOL blSubString,BOOL XLSX)
{
	try
	{
		//Initiate protected varibales.
		IJK=new INT[Sheet,65000,255];
		Csk=new CString[Sheet,65000,255];
		
		for(int i=0;i<Sheet;i++)
		for(int w=0;w<65000;w++)
			for(int j=0;j<255;j++)
			{
				IJK[i,w,j]=-1;
				Csk[i,w,j]=L"";
		
			}

			//For Every Sheets.
		for(int i=1;i<=Sheet;i++)
		{
			CString SheetName;
			SheetName=L"Sheet";
			CString INTEGER;
			INTEGER.Format(L"%d",i);
			SheetName+=INTEGER;
			
			//Find for Every Sheets.
			if(!this->CSearchAStringAndSubStringInSpecialSheet(SubString,blSubString,SheetName,XLSX))
				return FALSE;
		
			//Statment for all Sheets.
			for(int w=0;w<MAXRow;w++)
			for(int j=0;j<CMA->GetTotalColumns();j++)
			{
				IJK[i-1,w,j]=IJ[w,j];
				Csk[i-1,w,j]=Cs[w,j];
			}
			
			//Delete protected variables.
			delete[] IJ;
			delete[] Cs;
			delete CMA;
		}
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Search for Several Sheet.",0,0);
		return FALSE;
	}
	return TRUE;
}
CSearch::~CSearch()
{
   try{
	   //Decunstructor.
	   delete[] IJK;
       delete[] Csk;
	   }
	   catch(CException&e)
	   {

	   }
}