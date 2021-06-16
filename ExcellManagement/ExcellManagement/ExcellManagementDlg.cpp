//Dialog Class.
//Edited By Ramin Edjlal. Urmia. Iran.
// ExcellManagementDlg.cpp : implementation file
//Ramin Edjlal.Urmia Iran.

#include "stdafx.h"
#include "ExcellManagement.h"
#include "ExcellManagementDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CExcellManagementDlg dialog


CSearchDialog * m_pModeless;
CConfigurationDialog * m_pModelessCon;

CExcellManagementDlg::CExcellManagementDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CExcellManagementDlg::IDD, pParent)
{
	try
	{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	IsOrNorOrBoth=0;
	XLSX=TRUE;
	RadioEXE1=-1;
	RadioEXE2=-1;
	RadioEXE3=-1;
	//m_pModeless=0;
	if(m_pModelessCon)
		{
			if(m_pModelessCon->GetUPDATEDLIST())
			{
				m_strEditValueIDC_EDIT1=L"14";
				m_strEditValueIDC_EDIT3=m_pModelessCon->Getm_strEditValueIDC_CONEDIT1();
				m_strEditValueIDC_EDIT4=m_pModelessCon->Getm_strEditValueIDC_CONEDIT2();
				m_strEditValueIDC_EDIT5=m_pModelessCon->Getm_strEditValueIDC_CONEDIT3();
				m_strEditValueIDC_EDIT6=m_pModelessCon->Getm_strEditValueIDC_CONEDIT4();
				m_strEditValueIDC_EDIT2=m_pModelessCon->Getm_strEditValueIDC_CONEDIT6();
				m_strEditValueIDC_EDIT7=m_pModelessCon->Getm_strEditValueIDC_CONEDIT7();
				m_strEditValueIDC_MFCEDITBROWSE1=m_pModelessCon->Getm_strEditValueIDC_CONMFCEDITBROWSE1();
				RadioEXE1=m_pModelessCon->GetRadioCON3();
				RadioEXE2=m_pModelessCon->GetRadioCON4();
				RadioEXE3=m_pModelessCon->GetRadioCON5();
				XLSX=m_pModelessCon->GETXLSX();
				IsOrNorOrBoth=m_pModelessCon->GetCONIsOrNorOrBoth();
				

		}
	}
	else
	{
	m_strEditValueIDC_EDIT1=L"14";
	m_strEditValueIDC_EDIT5=L"1";
	m_strEditValueIDC_EDIT6=L"6";
	m_strEditValueIDC_EDIT3=L"7";
	m_strEditValueIDC_EDIT4=L"14";
	m_strEditValueIDC_EDIT2=L"E:\\Docs\\";
	m_strEditValueIDC_EDIT7=L"RaminEdjlal\\";	
	m_strEditValueIDC_MFCEDITBROWSE1=L"C:\\Users\\RaminE\\Desktop\\A File For Containing Files In Docs.xlsx";
	RadioEXE1=-1;
	RadioEXE2=-1;
	RadioEXE3=-1;
	}
	
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Excell Mangemaent Dialog Constructor.",0,0);
	}
	return;

	
}
CExcellManagementDlg::~CExcellManagementDlg()
{
	try
	{
	if (m_pModeless)
    {
        if (::IsWindow(m_pModeless->GetSafeHwnd()))
            m_pModeless->EndDialog(IDCANCEL);
        delete m_pModeless;
    }
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error CxexellManagement Constructor.",0,0);
	}
	
}
void CExcellManagementDlg::DoDataExchange(CDataExchange* pDX)
{
	try
	{
	CDialogEx::DoDataExchange(pDX);
	
	DDX_Text(pDX, IDC_EDIT1, m_strEditValueIDC_EDIT1);
	DDX_Text(pDX, IDC_EDIT2, m_strEditValueIDC_EDIT2);
	DDX_Text(pDX, IDC_EDIT3, m_strEditValueIDC_EDIT3);
	DDX_Text(pDX, IDC_EDIT4, m_strEditValueIDC_EDIT4);
	DDX_Text(pDX, IDC_EDIT5, m_strEditValueIDC_EDIT5);
	DDX_Text(pDX, IDC_EDIT6, m_strEditValueIDC_EDIT6);
	DDX_Text(pDX, IDC_EDIT7, m_strEditValueIDC_EDIT7);
	DDX_Text(pDX, IDC_MFCEDITBROWSE1, m_strEditValueIDC_MFCEDITBROWSE1);
	
	DDX_Control(pDX,IDC_RADIO1,m_1);
	DDX_Control(pDX,IDC_RADIO2,m_2);
	DDX_Control(pDX,IDC_RADIO3,m_3);
	
	//if((IsDlgButtonChecked(IDC_RADIO1)!=0)||(IsDlgButtonChecked(IDC_RADIO2)!=0)||(IsDlgButtonChecked(IDC_RADIO3)!=0))
	{
		DDX_Radio(pDX,IDC_RADIO1,RadioEXE1);
	
		DDX_Radio(pDX,IDC_RADIO2,RadioEXE2);
	
		DDX_Radio(pDX,IDC_RADIO3,RadioEXE3);
	}
	
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Do Exchange in Excell Mangement Dialog.",0,0);
	}

}

BEGIN_MESSAGE_MAP(CExcellManagementDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_EN_CHANGE(IDC_EDIT2, &CExcellManagementDlg::OnEnChangeEdit2)
	ON_BN_CLICKED(IDCANCEL, &CExcellManagementDlg::OnBnClickedCancel)
	ON_BN_CLICKED(IDC_RADIO1, &CExcellManagementDlg::OnBnClickedRadio1)
	ON_BN_CLICKED(IDC_RADIO2, &CExcellManagementDlg::OnBnClickedRadio2)
	ON_BN_CLICKED(IDC_RADIO4, &CExcellManagementDlg::OnBnClickedRadio4)
	ON_EN_CHANGE(IDC_EDIT4, &CExcellManagementDlg::OnEnChangeEdit4)
	ON_EN_CHANGE(IDC_EDIT3, &CExcellManagementDlg::OnEnChangeEdit3)
	ON_EN_CHANGE(IDC_EDIT5, &CExcellManagementDlg::OnEnChangeEdit5)
	ON_EN_CHANGE(IDC_EDIT6, &CExcellManagementDlg::OnEnChangeEdit6)

	ON_BN_CLICKED(IDOK, &CExcellManagementDlg::OnBnClickedOk)
	ON_EN_CHANGE(IDC_EDIT1, &CExcellManagementDlg::OnEnChangeEdit1)
	ON_EN_CHANGE(IDC_EDIT7, &CExcellManagementDlg::OnEnChangeEdit7)
	ON_EN_CHANGE(IDC_MFCEDITBROWSE1, &CExcellManagementDlg::OnEnChangeMfceditbrowse1)
	ON_BN_CLICKED(IDC_BUTTON1, &CExcellManagementDlg::OnBnClickedButton1)
	
	ON_BN_CLICKED(IDC_BUTTON2, &CExcellManagementDlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CExcellManagementDlg::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CExcellManagementDlg::OnBnClickedButton4)
	ON_BN_CLICKED(IDC_RADIO3, &CExcellManagementDlg::OnBnClickedRadio3)
END_MESSAGE_MAP()


// CExcellManagementDlg message handlers

BOOL CExcellManagementDlg::OnInitDialog()
{
	try
	{
	CDialogEx::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here
	}
	catch(CException&e)
	{
		::MessageBox(0,L"On Init Dialog.",0,0);
	}
	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CExcellManagementDlg::OnPaint()
{
	try
	{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
	}
	catch(CException&e)
	{
		::MessageBox(0,L"On Init Paint.",0,0);
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CExcellManagementDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CExcellManagementDlg::OnEnChangeEdit2()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnBnClickedCancel()
{
	try
	{
	// TODO: Add your control notification handler code here
	CDialogEx::OnCancel();
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Exit Program.",0,0);
	}
}


void CExcellManagementDlg::OnBnClickedRadio1()
{
	try
	{
	// TODO: Add your control notification handler code here
	GetDlgItem(IDC_EDIT5)->ShowWindow(SW_HIDE);
	GetDlgItem(IDC_EDIT6)->ShowWindow(SW_HIDE);
	GetDlgItem(IDC_EDIT3)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT4)->ShowWindow(SW_SHOW);
	IsOrNorOrBoth=1;
	RadioEXE1=0;
	RadioEXE2=-1;
	RadioEXE3=-1;
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error DVD(s) are Standard Checked.",0,0);
	}
}


void CExcellManagementDlg::OnBnClickedRadio2()
{
	try
	{
	// TODO: Add your control notification handler code here
	GetDlgItem(IDC_EDIT5)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT6)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT3)->ShowWindow(SW_HIDE);
	GetDlgItem(IDC_EDIT4)->ShowWindow(SW_HIDE);
	IsOrNorOrBoth=2;
	RadioEXE1=-1;
	RadioEXE2=0;
	RadioEXE3=-1;
	
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error DVD(s) are Non Standard Checked.",0,0);
	}
}


void CExcellManagementDlg::OnBnClickedRadio4()
{
	// TODO: Add your control notification handler code here
	GetDlgItem(IDC_EDIT5)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT6)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT3)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT4)->ShowWindow(SW_SHOW);
	IsOrNorOrBoth=3;
}


void CExcellManagementDlg::OnEnChangeEdit4()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnEnChangeEdit3()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnEnChangeEdit5()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnEnChangeEdit6()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnBnClickedOk()
{
	// TODO: Add your control notification handler code here
	CDialogEx::OnOK();
	
	UpdateData(TRUE); // Get value from control to variable
      // m_strEditValue now contains the value entered in the edit control

	//Determine About Kind of File.
	if(m_strEditValueIDC_MFCEDITBROWSE1.Right(4)==L".xls")
		XLSX=FALSE;
	else
		XLSX=TRUE;
	//Load Sheets numbers.
	INT Sheet=_wtoi(m_strEditValueIDC_EDIT1);
	::MessageBox(0,L"Note For SheetNumber.If You Don't Enter Sheet Number Correctly And It Needs More Than Sheet You Should Do Operation From Beginning With New Non Created Excell File.",0,0);
    CCreateExcellSheet *CCreateSheet=new CCreateExcellSheet();
    CCreateSheet->CCreateRequireExcellSheet(m_strEditValueIDC_MFCEDITBROWSE1,Sheet);
	delete CCreateSheet;

	//Initiate local varibales.
    CString DVDS1;
	CString DVDS2;

	
	//If Non Standard clicked or both.
	if(IsOrNorOrBoth!=0)
	{
	try{
	if(IsOrNorOrBoth==2||IsOrNorOrBoth==3)
	{
	DVDS1.Format(L"%d",_wtoi(m_strEditValueIDC_EDIT5));
	if(DVDS1.GetLength()== 1)
		DVDS1=L"0"+DVDS1;
	DVDS1=L"DVD"+DVDS1;
	
	DVDS2.Format(L"%d",_wtoi(m_strEditValueIDC_EDIT6));
	if(DVDS2.GetLength()== 1)
		DVDS2=L"0"+DVDS2;
	DVDS2=L"DVD"+DVDS2;

	//Constructor and pointer.
	  CClient *CMA=new CClient(m_strEditValueIDC_MFCEDITBROWSE1,m_strEditValueIDC_EDIT2+DVDS1+L"\\"+m_strEditValueIDC_EDIT7,L"Sheet1",TRUE,1,Sheet);
	
      //For Non DVD standard. 
	  if(!CMA->CClientForNonStandardDVDS(m_strEditValueIDC_MFCEDITBROWSE1,_wtoi(m_strEditValueIDC_EDIT5),_wtoi(m_strEditValueIDC_EDIT6),m_strEditValueIDC_EDIT2,m_strEditValueIDC_EDIT7,XLSX))
		{
			delete CMA;
			MessageBox(L"Operatiorn Not Completed.",0,0);
			return;
		}
	  
	  delete CMA;
		

	  MessageBox(L"Operatiorn For Non DVD Standard Finally Completed.",0,0);
		}


	//If Standard or both.
      if(IsOrNorOrBoth==1||IsOrNorOrBoth==3)
		{

	DVDS1.Format(L"%d",_wtoi(m_strEditValueIDC_EDIT3));
	if(DVDS1.GetLength()== 1)
		DVDS1=L"0"+DVDS1;
	DVDS1=L"DVD"+DVDS1;
	
	DVDS2.Format(L"%d",_wtoi(m_strEditValueIDC_EDIT4));
	if(DVDS2.GetLength()== 1)
		DVDS2=L"0"+DVDS2;
	DVDS2=L"DVD"+DVDS2;
		//Constructor and pointer.
    	CClient * CMA=new CClient(m_strEditValueIDC_MFCEDITBROWSE1,m_strEditValueIDC_EDIT2+DVDS2+L"\\"+m_strEditValueIDC_EDIT7,L"Sheet1",TRUE,8,Sheet);
	
		//For DVD Standard.
        if(!CMA->CClientForStandardDVDS(m_strEditValueIDC_MFCEDITBROWSE1,_wtoi(m_strEditValueIDC_EDIT3),_wtoi(m_strEditValueIDC_EDIT4),m_strEditValueIDC_EDIT2,m_strEditValueIDC_EDIT7,XLSX))
     	{
	    	delete CMA;
	       	MessageBox(L"Operatiorn Not Completed.",0,0);
	    	return;
	    }
	  
	    delete CMA;
		MessageBox(L"Operatiorn For DVD Standard Finally Completed.",0,0);
	}
 }
  catch(CException&E)
  {
	  return;
	  MessageBox(L"Operatiorn Not Completed.",0,0);
  }
  
}
   //Pausing System.
   system("pause");
   return;
}


void CExcellManagementDlg::OnEnChangeEdit1()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnEnChangeEdit7()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnEnChangeMfceditbrowse1()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CExcellManagementDlg::OnBnClickedButton1()
{
	try
	{
	// TODO: Add your control notification handler code here
	CAbout dlg;
	dlg.DoModal();
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error About Openning.",0,0);
	}
}




void CExcellManagementDlg::OnBnClickedButton2()
{
	// TODO: Add your control notification handler code here
	try
	{
		//Message and Initiate local variables.
	::MessageBox(0,L"This is Limitation Proceess . Do Until Successful Proccess.",0,0);
	 CString DVDS1;
	 CString DVDS2;

	DVDS1.Format(L"%d",_wtoi(m_strEditValueIDC_EDIT5));
	if(DVDS1.GetLength()== 1)
		DVDS1=L"0"+DVDS1;
	DVDS1=L"DVD"+DVDS1;
	
	DVDS2.Format(L"%d",_wtoi(m_strEditValueIDC_EDIT3));
	if(DVDS2.GetLength()== 1)
		DVDS2=L"0"+DVDS2;
	DVDS2=L"DVD"+DVDS2;
	//Constructor.
	CSheetNumber *CMA=new CSheetNumber(_wtoi(m_strEditValueIDC_EDIT1));

	//Update data.
	UpdateData(TRUE);

	//Calculate Sheet Numbers.
	INT Sheet=CMA->CCalculateSheetNumber(m_strEditValueIDC_MFCEDITBROWSE1,m_strEditValueIDC_EDIT2,m_strEditValueIDC_EDIT7,_wtoi(m_strEditValueIDC_EDIT5),_wtoi(m_strEditValueIDC_EDIT6),XLSX);

	//If Sheets Not enougth we sholud do again.
	if(Sheet==0)
	{
		m_strEditValueIDC_EDIT1.Format(L"%d",CMA->GetSheetNeed());
		UpdateData(FALSE);
		delete CMA;
		::MessageBox(0,L"Do Again..",0,0);
		return;
	}
	delete CMA;

	//If Successfule.
	m_strEditValueIDC_EDIT1.Format(L"%d",Sheet);
	UpdateData(FALSE);
	}
	catch(CException&E)
	{
		//Try Exception.
		::MessageBox(0,L"Do Again..",0,0);
		return;
	}
	//Message for Successful.
	::MessageBox(0,L"Operation Completed.",0,0);
	return;

}


void CExcellManagementDlg::OnBnClickedButton3()
{
	try
	{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	if(m_strEditValueIDC_MFCEDITBROWSE1.Right(4)==L".xls")
		XLSX=FALSE;
	else
		XLSX=TRUE;
	
	if (!m_pModeless)
        m_pModeless = new CSearchDialog(m_strEditValueIDC_MFCEDITBROWSE1,L"Sheet1",TRUE,_wtoi(m_strEditValueIDC_EDIT1),0,XLSX);

    if (!::IsWindow(m_pModeless->GetSafeHwnd()))
		m_pModeless->Create(IDD_SEARCHDIALOG1, this);
	
	m_pModeless->ShowWindow(SW_SHOW);
	m_pModeless->SetRadio1(m_pModelessCon->GetRadioCON6());
	m_pModeless->SetRadio2(m_pModelessCon->GetRadioCON7());
	m_pModeless->SetRadio3(m_pModelessCon->GetRadioCON8());
	m_pModeless->SetRadio4(m_pModelessCon->GetRadioCON9());
	m_pModeless->SetIsForAllOrIsForOneSheet(m_pModelessCon->GetIsForAllOrIsForOneSheet());
	m_pModeless->SetExactString(m_pModelessCon->GetCONExactString());
	m_pModeless->SetXLSX(m_pModelessCon->GETXLSX());
	m_pModeless->Setm_strEditValueIDC_EDITSEARCH4(m_pModelessCon->Getm_strEditValueIDC_CONEDIT5());




	m_pModeless->UpdateData(FALSE);

	this->ShowWindow(SW_HIDE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Search.",0,0);
	}
}


void CExcellManagementDlg::OnBnClickedButton4()
{
	try
	{
	// TODO: Add your control notification handler code here
	

	if (!m_pModelessCon)
			m_pModelessCon = new CConfigurationDialog(0);

    if (!::IsWindow(m_pModelessCon->GetSafeHwnd()))
		m_pModelessCon->Create(IDD_CONFIGURATIONDIALOG1, this);
	
	m_pModelessCon->ShowWindow(SW_SHOW);


	this->ShowWindow(SW_HIDE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Configuration.",0,0);
	}
}


void CExcellManagementDlg::OnBnClickedRadio3()
{
	try
	{
	// TODO: Add your control notification handler code here
	GetDlgItem(IDC_EDIT5)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT6)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT3)->ShowWindow(SW_SHOW);
	GetDlgItem(IDC_EDIT4)->ShowWindow(SW_SHOW);
	IsOrNorOrBoth=3;
	RadioEXE1=-1;
	RadioEXE2=-1;
	RadioEXE3=0;
	UpdateData(FALSE);
	}
	catch(CException&e)
	{
		::MessageBox(0,L"Error Both above Checked.",0,0);
	}
	
	
	
}
