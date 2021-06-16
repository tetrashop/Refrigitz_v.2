// CSearchDialog.cpp : implementation file
//Ramin Edjlal. Urmia Iran.


#include "stdafx.h"
#include "CSearchDialog.h"



// CSearchDialog dialog

IMPLEMENT_DYNAMIC(CSearchDialog, CDialogEx)

CSearchDialog::CSearchDialog(CString File, CString SheetOrSeparator, bool Backup ,INT SheetA,CWnd* pParent,BOOL XLSX):CExcellManagementDlg(pParent),CReplace(File,SheetOrSeparator,Backup ,SheetA,XLSX)

{
	m_pModeless=0;
	IsForAllOrIsForOneSheet=0;
	RadioSER1=-1;
	RadioSER2=-1;
	RadioSER3=-1;
	RadioSER4=-1;
#ifndef _WIN32_WCE
	EnableActiveAccessibility();
#endif

	EnableAutomation();

}

CSearchDialog::~CSearchDialog()
{
	if (m_pModeless)
    {
        if (::IsWindow(m_pModeless->GetSafeHwnd()))
            m_pModeless->EndDialog(IDCANCEL);
        delete m_pModeless;
    }
}

void CSearchDialog::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CDialogEx::OnFinalRelease();
}

void CSearchDialog::DoDataExchange(CDataExchange* pDX)
{
	try
	{
	CDialogEx::DoDataExchange(pDX);

	DDX_Text(pDX, IDC_EDIT1, m_strEditValueIDC_EDITSEARCH1);
	DDX_Text(pDX, IDC_EDIT2, m_strEditValueIDC_EDITSEARCH2);
	DDX_Text(pDX, IDC_EDIT3, m_strEditValueIDC_EDITSEARCH3);
	DDX_Text(pDX, IDC_EDIT4, m_strEditValueIDC_EDITSEARCH4);
	DDX_Control(pDX, IDC_MFCVSLISTBOX1, m_VSListBoxIDC_MFCVSLISTBOX1);

	
	DDX_Control(pDX,IDC_RADIO1,mSER_1);
	DDX_Control(pDX,IDC_RADIO2,mSER_2);
	DDX_Control(pDX,IDC_RADIO3,mSER_3);
	DDX_Control(pDX,IDC_RADIO4,mSER_4);
	
	///if((IsDlgButtonChecked(IDC_RADIO1)!=0)||(IsDlgButtonChecked(IDC_RADIO2)!=0))
	{
		DDX_Radio(pDX,IDC_RADIO1,RadioSER1);
		DDX_Radio(pDX,IDC_RADIO2,RadioSER2);
	}

	
	//if((IsDlgButtonChecked(IDC_RADIO3)!=0)||(IsDlgButtonChecked(IDC_RADIO4)!=0))
	{
		DDX_Radio(pDX,IDC_RADIO3,RadioSER3);
		DDX_Radio(pDX,IDC_RADIO4,RadioSER4);	
	}
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Do Data Exchange.",0,0);
	}
}


BEGIN_MESSAGE_MAP(CSearchDialog, CDialogEx)
	ON_BN_CLICKED(IDOK, &CSearchDialog::OnBnClickedOk)
	ON_BN_CLICKED(IDC_BUTTON1, &CSearchDialog::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_RADIO1, &CSearchDialog::OnBnClickedRadio1)
	ON_BN_CLICKED(IDC_RADIO2, &CSearchDialog::OnBnClickedRadio2)
	ON_BN_CLICKED(IDC_RADIO3, &CSearchDialog::OnBnClickedRadio3)
	ON_BN_CLICKED(IDC_RADIO4, &CSearchDialog::OnBnClickedRadio4)
	ON_BN_CLICKED(IDC_BUTTON2, &CSearchDialog::OnBnClickedButton2)
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CSearchDialog, CDialogEx)
END_DISPATCH_MAP()

// Note: we add support for IID_ISearchDialog to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .IDL file.

// {A2280B34-F6E1-496E-81EC-EC7CA1EEC330}
static const IID IID_ISearchDialog =
{ 0xA2280B34, 0xF6E1, 0x496E, { 0x81, 0xEC, 0xEC, 0x7C, 0xA1, 0xEE, 0xC3, 0x30 } };

BEGIN_INTERFACE_MAP(CSearchDialog, CDialogEx)
	INTERFACE_PART(CSearchDialog, IID_ISearchDialog, Dispatch)
END_INTERFACE_MAP()


// CSearchDialog message handlers


void CSearchDialog::OnBnClickedOk()
{
	try
	{
	// TODO: Add your control notification handler code here

	//Constructor and pointer.
	if (!m_pModeless)
        m_pModeless = new CExcellManagementDlg(0);

	//Create windows.
    if (!::IsWindow(m_pModeless->GetSafeHwnd()))
        m_pModeless->Create(IDD_EXCELLMANAGEMENT_DIALOG, this);
	
	
	
	//Show windows.
    m_pModeless->ShowWindow(SW_SHOW);

	//Initiate protected varibles.
	m_pModeless->Setm_strEditValueIDC_EDIT1(L"14");
	m_pModeless->Setm_strEditValueIDC_EDIT5(L"1");
	m_pModeless->Setm_strEditValueIDC_EDIT6(L"6");
	m_pModeless->Setm_strEditValueIDC_EDIT3(L"7");
	m_pModeless->Setm_strEditValueIDC_EDIT4(L"14");
	m_pModeless->Setm_strEditValueIDC_EDIT2(L"E:\\Docs\\");
	m_pModeless->Setm_strEditValueIDC_EDIT7(L"RaminEdjlal\\");	
	m_pModeless->Setm_strEditValueIDC_MFCEDITBROWSE1(L"C:\\Users\\RaminE\\Desktop\\A File For Containing Files In Docs.xlsx");

	//Update variables.
	m_pModeless->UpdateData(FALSE);

	//Hide windows current.
	this->ShowWindow(SW_HIDE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Ok Button.",0,0);
	}
}


void CSearchDialog::OnBnClickedButton1()
{
	// TODO: Add your control notification handler code here
	try{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	
	//If All Sheets.
	if(IsForAllOrIsForOneSheet<0)
	{
		//To find all sheets.

		if(!this->CSearchForSeveralSheet(m_strEditValueIDC_EDITSEARCH1,ExactString,XLSXCON))
		{
			::MessageBox(0,L"Search Not Comleted...",0,0);
			return;
		}
		//For every items found.

		for(int i=0;i<Sheet;i++)
			for(int j=0;j<this->GetMaxRow();j++)
				for(int k=0;k<255;k++)
		{
			//if founds.
			if(this->IJK[i,j,k]==1)
			{
				
				//Initiate local varibales.
			CString SheetName,Row,Column;
			SheetName.Format(L"%d",i+1);
			Row.Format(L"%d",j);
			Column.Format(L"%d",k);
			CString Cont=L"In Sheet("+ SheetName+ L") You have in Row("+Row+L") and Column("+Column+L"): Element \""+ this->Csk[i,j,k]+L"\".\n";

			//Insert items.
			UpdateData(TRUE);						
			int s=m_VSListBoxIDC_MFCVSLISTBOX1.AddItem(Cont,0,-1);
			UpdateData(FALSE);					
			}
		}
	}
	else
		//If One sheets required.
		if(IsForAllOrIsForOneSheet>0)
		{
			if(!this->CSearchAStringAndSubStringInSpecialSheet(m_strEditValueIDC_EDITSEARCH1,ExactString,m_strEditValueIDC_EDITSEARCH4,XLSXCON))
			{
				::MessageBox(0,L"Search Not Comleted...",0,0);
				return;
			}
			//For Sheet.
		  for(int j=0;j<this->GetMaxRow();j++)
				for(int k=0;k<255;k++)
			{
				//If Found.
			if(this->IJ[j,k]==1)
			{
			
				//Initiate local varibales.
			CString Row,Column;
			Row.Format(L"%d",j);
			Column.Format(L"%d",k);
			CString Cont=L"In Sheet"+ m_strEditValueIDC_EDIT4+L"You have in Row("+Row+L") and Column("+Column+L"): Element \""+this->Cs[j,k]+L"\".";

			//Insert items.
			UpdateData(TRUE);
			int s=m_VSListBoxIDC_MFCVSLISTBOX1.AddItem(Cont,0,-1);	
			UpdateData(FALSE);
			
			}
		}

	}
		
	}catch(CException&e)
	{
		::MessageBox(0,L"Search Caused trougth an Exception.Search Not Comleted...",0,0);
		return;
	}
	::MessageBox(0,L"Search Completed...",0,0);
	return;
	
}


void CSearchDialog::OnBnClickedRadio1()
{
	try
	{
	// TODO: Add your control notification handler code here
	IsForAllOrIsForOneSheet=-1;
	GetDlgItem(IDC_EDIT4)->ShowWindow(SW_HIDE);
	UpdateData(TRUE);
	RadioSER1=0;
	RadioSER2=-1;
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error All Sheet Checked. ",0,0);
		return;
	}
	return;
}


void CSearchDialog::OnBnClickedRadio2()
{
	try
	{
	// TODO: Add your control notification handler code here
	IsForAllOrIsForOneSheet=1;
	GetDlgItem(IDC_EDIT4)->ShowWindow(SW_SHOW);
	UpdateData(TRUE);
	RadioSER1=-1;
	RadioSER2=0;	
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error One Sheet Chacked.",0,0);
		return;
	}
	return;
}


void CSearchDialog::OnBnClickedRadio3()
{
	try
	{
	// TODO: Add your control notification handler code here
	ExactString=FALSE;
	UpdateData(TRUE);
	RadioSER3=0;
	RadioSER4=-1;
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Exact String One.",0,0);
		return;
	}
	return;
}


void CSearchDialog::OnBnClickedRadio4()
{
	try
	{
	// TODO: Add your control notification handler code here
	ExactString=TRUE;
	UpdateData(TRUE);
	RadioSER3=-1;
	RadioSER4=0;
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Sub String.",0,0);
		return;
	}
	return;
}


void CSearchDialog::OnBnClickedButton2()
{
	// TODO: Add your control notification handler code here
	try{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	
	//If All Sheets.
	if(IsForAllOrIsForOneSheet<0)
	{
		//To find all sheets.
		if(!this->CReplaceInAllSheets(m_strEditValueIDC_EDITSEARCH2,m_strEditValueIDC_EDITSEARCH3,ExactString,XLSXCON))
		{
			::MessageBox(0,L"Search Not Comleted...",0,0);
			return;
		}
		//For every items found.

		for(int i=0;i<Sheet;i++)
			for(int j=0;j<this->GetMaxRow();j++)
				for(int k=0;k<255;k++)
		{
			//if founds.
			if(this->IJK[i,j,k]==1)
			{
				
				//Initiate local varibales.
			CString SheetName,Row,Column;
			SheetName.Format(L"%d",i+1);
			Row.Format(L"%d",j);
			Column.Format(L"%d",k);
			CString Cont=L"In Sheet("+ SheetName+ L") You Replaced in Row("+Row+L") and Column("+Column+L"): Element \""+ this->Csk[i,j,k]+L"\".\n";

			//Insert items.
			UpdateData(TRUE);						
			int s=m_VSListBoxIDC_MFCVSLISTBOX1.AddItem(Cont,0,-1);
			UpdateData(FALSE);					
			}
		}
	}
	else
		//If One sheets required.
		if(IsForAllOrIsForOneSheet>0)
		{
			if(!this->CReplaceInOneSheet(m_strEditValueIDC_EDITSEARCH2,m_strEditValueIDC_EDITSEARCH3,ExactString,m_strEditValueIDC_EDITSEARCH4,XLSXCON))
			{
				::MessageBox(0,L"Search Not Comleted...",0,0);
				return;
			}
			//For Sheet.
		  for(int j=0;j<this->GetMaxRow();j++)
				for(int k=0;k<255;k++)
			{
				//If Found.
			if(this->IJ[j,k]==1)
			{
			
				//Initiate local varibales.
			CString Row,Column;
			Row.Format(L"%d",j);
			Column.Format(L"%d",k);
			CString Cont=L"In Sheet"+ m_strEditValueIDC_EDIT4+L"You Replaced in Row("+Row+L") and Column("+Column+L"): Element \""+this->Cs[j,k]+L"\".";

			//Insert items.
			UpdateData(TRUE);
			int s=m_VSListBoxIDC_MFCVSLISTBOX1.AddItem(Cont,0,-1);	
			UpdateData(FALSE);
			
			}
		}

	}
		
	}catch(CException&e)
	{
		::MessageBox(0,L"Search Caused trougth an Exception.Search Not Comleted...",0,0);
		return;
	}
	::MessageBox(0,L"Search Completed...",0,0);
	return;
}
