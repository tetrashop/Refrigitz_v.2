//OLDBDLimtColumn Class is derived from CspradSheet Class and CMounth Class and is for 
//Managing Limitation Of Excell Sheet.
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"
//Constructor.
OLDBLimitColumn::OLDBLimitColumn(CString File, CString SheetOrSeparator, bool Backup,BOOL XLSX,INT SheetA):CMounth(File,SheetOrSeparator,Backup,XLSX,SheetA) ,ExcelManager(FALSE,L"Sheet",File)
{
	Sheet=SheetA;
	for(int i=0;i<MAX_PATH_THIS_PROJECT;i++)
			m_aFiledFirstRow[i].RemoveAll();;//255 Filed Arrays.
	m_aFiledFirstRowLen=0;//Length of m_aFiledFirstRow
	IsGreter=false;
}
//To divied m_aFiledRow CStringArray function to 255 elements.
BOOL OLDBLimitColumn::Divied_m_aFieldNamesTom_aFiledFirstRowCMounth(CStringArray &m_aFieldNameD,CString Date,CString DVD,CString Path)
{
	try
	{
		//if there is less than 255 retrun false;
		if(m_aFieldNameD.GetCount()<255)
			return FALSE;

		//Initiate local variables.
		m_aFiledFirstRowLen=0;
		m_aFiledFirstRowLen++;
		INT m_aFieldNameDLen=0;
		int i=0;
		

		
		//loop for indexing
		while(m_aFieldNameDLen<m_aFieldNameD.GetCount())
		{
		//Set 255 ith elemnts.	
		m_aFiledFirstRow[m_aFiledFirstRowLen-1].Add(m_aFieldNameD.GetAt(m_aFieldNameDLen));	

		//Increament Length.
		m_aFieldNameDLen++;

		i++;

		//if 251 element completed then do.
		if((i-(m_aFiledFirstRowLen-1)*254)>=254)
		{

		//Increament Lenght
    	m_aFiledFirstRowLen++;

		//Set header of 1-3 cell of next sheet.
		m_aFiledFirstRow[m_aFiledFirstRowLen-1].Add(L"Date");	
		m_aFiledFirstRow[m_aFiledFirstRowLen-1].Add(L"DVD");	
		m_aFiledFirstRow[m_aFiledFirstRowLen-1].Add(L"Path");
        i+=3;
		
		}
		}
	}
	catch(CException & e)
	{
		::MessageBox(0,L"Error Divied m_aFieldNames To m_aFiledFirst Row CMounth",0,0);
		return FALSE;
	}
	
	return TRUE;

}

//Limit OLEDB Removr.
INT OLDBLimitColumn::OLDBLimitRemover(CStringArray &m_aFieldNamesCopied,CString GDateOnExcellFormat,CString hDateOnFileFormat,CString DVD,CString Root,INT CurertDayIfLimit,CMounth *CDVMounth,BOOL Standard,BOOL XLSX)
{
		
	try{
     //Initiate local variables.
	INT RectCode=-3;

	//If Not Standard Inizialize protected variables.
	if(!Standard)
		{
		for(int i=0;i<this->m_aFiledFirstRowLen;i++)
		       this->m_aFiledFirstRow[i].RemoveAll();
		this->m_aFiledFirstRowLen=0;
		}

	//Divied m_aFiledNameTo .
    if(!this->Divied_m_aFieldNamesTom_aFiledFirstRowCMounth(m_aFieldNamesCopied,GDateOnExcellFormat,DVD,Root))
			return FALSE;
	if(this->m_aFiledFirstRowLen>Sheet)
		{
			CString SheetA;
			SheetA.Format(L"%d",this->m_aFiledFirstRowLen);					
		    MessageBox(0,L"Error SheetNumber! Increase Sheet Number. Require '"+SheetA+L"', Sheet(s). Operations Will be terminated.",0,0);	//Create m_aFiledN>ames varibale.
			return FALSE;
		}
	
	//for every sheet of there exist. 
	for(int i=0;i<this->m_aFiledFirstRowLen;i++)
	{

	//Iniziate local variables.
	CString SheetId;
	SheetId.Format(L"%d",i+1);
	INT iFileIndex=0;

	//CMounth class constructor pointer.
	CMounth *CMA=new CMounth(this->m_sFile,L"Sheet"+SheetId,FALSE,XLSX,Sheet);

	//If Length of protected variable is less than total column add.
	if(i==this->m_aFiledFirstRowLen-1)
	{
		while(this->m_aFiledFirstRow[i].GetCount()<CMA->Retrivem_dTotalColumns())
		{
			CString No;
			No.Format(L"%d",this->m_aFiledFirstRow[i].GetCount()-2);
			No=L"File"+No;
			this->m_aFiledFirstRow[i].Add(No);	
		}
	}
	if(Standard)
	{
		//Iniziate variables.
		CString SubRoot=L"*";
		CMA->SetFileNo(0);
		CMA->SetFiles(L"");
	
		//Find days of current Mounth.
		CMA->CFindDays(Root+SubRoot);

		//Create Excel format day of excel format.
		if(!CMA->CCreateSpecificDayInExcell())
		{
		//delet object becuse of failer.
		delete CMA;
		return -2;
		}
	}
	else
	{
		CMA->SetFiles(CDVMounth->GetFiles());
		CMA->SetFieldNames(this->m_aFiledFirstRow[i]);
	}
	//CMA->SetFiles(this->Files);

	//Iniziate portected variables.
	CMA->SetFileNo(this->m_aFiledFirstRow[i].GetCount()-3);

	//Update header.
	if(!CMA->CUpdateFileNumberInFiledRow())
	{
		//delete object becuase of failer.
		delete CMA;
		return -2;
	}
	if(Standard)
	{
		//Initiate protected variables.
		CMA->SetFileNo(0);
		CMA->SetFiles(L"");

		//Find files of current day.
	   if(!CMA->CFindFiles(Root+hDateOnFileFormat))
				 return -2;
	}
	//Initiate local variables.
	for(int j=0;j<=i-1;j++)
		iFileIndex+=this->m_aFiledFirstRow[j].GetCount()-3;

	//Iniziate protected variables.
	CMA->SetFileNo(0);
	for(int j=0;j<=i;j++)
		CMA->SetFileNo(CMA->GetFileNo()+this->m_aFiledFirstRow[j].GetCount()-3);
	
	if(Standard)
	{
		//Find files in curcurrent day.
		if(!CMA->CAddFilesInCurrentDay(hDateOnFileFormat,Root,CurertDayIfLimit,_wtoi(DVD),iFileIndex,Standard))
		{
			//delete object.
			delete CMA;
			return -2;
		}
	}
	else
	{
		//Find files in curcurrent day.
		if(!CMA->CAddFilesInCurrentDay(GDateOnExcellFormat,Root,CurertDayIfLimit,_wtoi(DVD),iFileIndex,Standard))
		{
			//delete object.
			delete CMA;
			return -2;
		}

	}
	//delete object.
	delete CMA;
	}
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error OLDB Limit Remover.",0,0);
		return -2;
	}
return -4;
}

//Deconstructor.
OLDBLimitColumn::~OLDBLimitColumn()
{

}
	 