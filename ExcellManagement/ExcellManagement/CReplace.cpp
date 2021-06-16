//Replace class for ExcellManagements.
//Ramin Edjlal.Urmia Iran.

#include "stdafx.h"
CReplace::CReplace(CString File, CString SheetOrSeparator, bool Backup ,INT SheetA,BOOL XLSX):CSearch(File,SheetOrSeparator,Backup,SheetA,XLSX)
{
	//Initiate protected varibales.
	Sheet=SheetA;
	
}
BOOL CReplace::CReplaceInOneSheet(CString SubStringSe,CString SubStringRe,BOOL blSubString,CString SheetOrSeparator,BOOL XLSX)
{	try
	{
	if(!this->CSearchAStringAndSubStringInSpecialSheet(SubStringSe,blSubString,SheetOrSeparator,XLSX))
			return FALSE;
			
	CSpreadSheet *CMAS=new CSpreadSheet(m_sFile,SheetOrSeparator,XLSX,false);

	for(int i=2;i<=MAXRow;i++)
	{
		for(int j=1;j<=255;j++)
		{
			//If Found.
			if(this->IJ[i-1,j-1]==1)
			{
				
			    //Use of One CString to replace new one in old one.
				//If Found and is new one sub set of old one.
				if(this->Cs[i-1,j-1].Find(SubStringSe,0)>=0)
				{
				//Replace new one.
				this->Cs[i-1,j-1].Replace(SubStringSe,SubStringRe);
				if(!CMAS->AddCell(this->Cs[i-1,j-1],j,i))
					return FALSE;

				}
				else
					this->IJ[i-1,j-1]=-1;						
				
				
			}
		}
		}
	delete CMAS;
	}

	catch(CException&e)
	{
	::MessageBox(0,L"Error Replace In One Sheet.",0,0);
	return FALSE;
	}
	return TRUE;
}
BOOL CReplace::CReplaceInAllSheets(CString SubStringSe,CString SubStringRe,BOOL blSubString,BOOL XLSX)
{
	try
	{
    if(!this->CSearchForSeveralSheet(SubStringSe,blSubString,XLSX))
		return FALSE;
	for(int i=1;i<=Sheet;i++)
	{
	CString SheetName;
	SheetName.Format(L"%d",i);
	SheetName=L"Sheet"+SheetName;
	CSpreadSheet *CMAS=new CSpreadSheet(m_sFile,SheetName,XLSX,false);
			 
	for(int j=2;j<=MAXRow;j++)
	{
		for(int k=1;k<=255;k++)
		{	//If Found.
			if(this->IJK[i-1,j-1,k-1]==1)
			{
			 	//Use of One CString to replace new one in old one.
				//If Found and is new one sub set of old one.
				if(this->Cs[i-1,j-1,k-1].Find(SubStringSe,0)>=0)
				{
				
				//Replace new one.
				this->Csk[i-1,j-1,k-1].Replace(SubStringSe,SubStringRe);
				if(!CMAS->AddCell(this->Csk[i-1,j-1,k-1],k,j))
					return FALSE;
				
				}
				else
					this->IJK[i-1,j-1,k-1]=-1;						
			}
		}
	}
	delete CMAS;
	}
}
  catch(CException&e)
	{
	::MessageBox(0,L"Error Replace In All Sheet.",0,0);
	return FALSE;
	}	
return TRUE;
}
CReplace::~CReplace()
{
	try
	{
	if(IJ)
		delete[] IJ;
	if(Cs)
		delete[] Cs;
	if(IJK)
		delete[] IJK;
	if(Csk)
		delete[] Csk;
	}
	catch(CException&e)
	{
		
	}

}