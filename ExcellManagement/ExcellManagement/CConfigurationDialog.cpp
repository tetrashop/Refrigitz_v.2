// CConfigurationDialog.cpp : implementation file
//Ramin Edjlal.Urmia Iran.

#include "stdafx.h"
#include "CConfigurationDialog.h"
#include "afxdialogex.h"


// CConfigurationDialog dialog

IMPLEMENT_DYNAMIC(CConfigurationDialog, CDialogEx)

CConfigurationDialog::CConfigurationDialog(CWnd* pParent /*=NULL*/)
	: CDialogEx(CConfigurationDialog::IDD, pParent)
{
	XLSX=TRUE;
	m_pModeless=0;
	CONIsOrNorOrBoth=0;
	IsForAllOrIsForOneSheet=0;
	RadioCON1=0;
	RadioCON2=0;
	RadioCON3=0;
	RadioCON4=0;
	UPDATEDLIST=FALSE;
#ifndef _WIN32_WCE
	EnableActiveAccessibility();
#endif

	EnableAutomation();

}

CConfigurationDialog::~CConfigurationDialog()
{
	try
	{
	//Delete Pointer allocating.
	if(m_pModeless)
		delete m_pModeless;
	}catch(CException&e)
	{
		return ; 
	}
	return;
}

void CConfigurationDialog::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CDialogEx::OnFinalRelease();
}

void CConfigurationDialog::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);

	DDX_Text(pDX, IDC_CONEDIT1, m_strEditValueIDC_CONEDIT1);
	DDX_Text(pDX, IDC_CONEDIT2, m_strEditValueIDC_CONEDIT2);
	DDX_Text(pDX, IDC_CONEDIT3, m_strEditValueIDC_CONEDIT3);
	DDX_Text(pDX, IDC_CONEDIT4, m_strEditValueIDC_CONEDIT4);
	DDX_Text(pDX, IDC_CONEDIT5, m_strEditValueIDC_CONEDIT5);
	DDX_Text(pDX, IDC_CONEDIT6, m_strEditValueIDC_CONEDIT6);
	DDX_Text(pDX, IDC_CONEDIT7, m_strEditValueIDC_CONEDIT7);
	DDX_Text(pDX, IDC_CONMFCEDITBROWSE1, m_strEditValueIDC_CONMFCEDITBROWSE1);

	
	DDX_Control(pDX,IDC_CONRADIO1,mCON_1);
	DDX_Control(pDX,IDC_CONRADIO2,mCON_2);
	DDX_Control(pDX,IDC_CONRADIO3,mCON_3);
	DDX_Control(pDX,IDC_CONRADIO4,mCON_4);
	DDX_Control(pDX,IDC_CONRADIO5,mCON_5);
	DDX_Control(pDX,IDC_CONRADIO6,mCON_6);
	DDX_Control(pDX,IDC_CONRADIO7,mCON_7);
	DDX_Control(pDX,IDC_CONRADIO8,mCON_8);
	DDX_Control(pDX,IDC_CONRADIO9,mCON_9);
	
	if((IsDlgButtonChecked(IDC_CONRADIO1)!=0)||(IsDlgButtonChecked(IDC_CONRADIO2)!=0))
	{
		DDX_Radio(pDX,IDC_CONRADIO1,RadioCON1);
		DDX_Radio(pDX,IDC_CONRADIO2,RadioCON2);
	}

	
	if((IsDlgButtonChecked(IDC_CONRADIO3)!=0)||(IsDlgButtonChecked(IDC_CONRADIO4)!=0)||(IsDlgButtonChecked(IDC_CONRADIO5)!=0))
	{
		DDX_Radio(pDX,IDC_CONRADIO3,RadioCON3);
		DDX_Radio(pDX,IDC_CONRADIO4,RadioCON4);	
		DDX_Radio(pDX,IDC_CONRADIO5,RadioCON5);
	
	}
	if((IsDlgButtonChecked(IDC_CONRADIO6)!=0)||(IsDlgButtonChecked(IDC_CONRADIO7)!=0))
	{
		DDX_Radio(pDX,IDC_CONRADIO6,RadioCON6);
		DDX_Radio(pDX,IDC_CONRADIO7,RadioCON7);
	}
	if((IsDlgButtonChecked(IDC_CONRADIO8!=0))||(IsDlgButtonChecked(IDC_CONRADIO9)!=0))
	{
	
		DDX_Radio(pDX,IDC_CONRADIO8,RadioCON8);	
		DDX_Radio(pDX,IDC_CONRADIO9,RadioCON9);
	}
	
}


BEGIN_MESSAGE_MAP(CConfigurationDialog, CDialogEx)
    ON_BN_CLICKED(IDC_CONRADIO1, &CConfigurationDialog::OnBnClickedConradio1)
	ON_BN_CLICKED(IDC_CONRADIO2, &CConfigurationDialog::OnBnClickedConradio2)
	ON_BN_CLICKED(IDC_CONRADIO3, &CConfigurationDialog::OnBnClickedConradio3)
	ON_BN_CLICKED(IDC_CONRADIO4, &CConfigurationDialog::OnBnClickedConradio4)
	ON_BN_CLICKED(IDC_CONRADIO5, &CConfigurationDialog::OnBnClickedConradio5)
	ON_BN_CLICKED(IDC_CONRADIO6, &CConfigurationDialog::OnBnClickedConradio6)
	ON_BN_CLICKED(IDC_CONRADIO7, &CConfigurationDialog::OnBnClickedConradio7)
	ON_BN_CLICKED(IDC_CONRADIO8, &CConfigurationDialog::OnBnClickedConradio8)
	ON_BN_CLICKED(IDC_CONRADIO9, &CConfigurationDialog::OnBnClickedConradio9)
	ON_BN_CLICKED(IDOK, &CConfigurationDialog::OnBnClickedOk)
	ON_BN_CLICKED(IDCANCEL, &CConfigurationDialog::OnBnClickedCancel)
	ON_EN_CHANGE(IDC_CONEDIT5, &CConfigurationDialog::OnEnChangeConedit5)
	ON_EN_CHANGE(IDC_CONEDIT6, &CConfigurationDialog::OnEnChangeConedit6)
	ON_EN_CHANGE(IDC_CONEDIT1, &CConfigurationDialog::OnEnChangeConedit1)
	ON_EN_CHANGE(IDC_CONEDIT2, &CConfigurationDialog::OnEnChangeConedit2)
	ON_EN_CHANGE(IDC_CONEDIT3, &CConfigurationDialog::OnEnChangeConedit3)
	ON_EN_CHANGE(IDC_CONEDIT4, &CConfigurationDialog::OnEnChangeConedit4)
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CConfigurationDialog, CDialogEx)
END_DISPATCH_MAP()

// Note: we add support for IID_IConfigurationDialog to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .IDL file.

// {63A62AF5-5ACC-40BF-9B4C-3697F7B16214}
static const IID IID_IConfigurationDialog =
{ 0x63A62AF5, 0x5ACC, 0x40BF, { 0x9B, 0x4C, 0x36, 0x97, 0xF7, 0xB1, 0x62, 0x14 } };

BEGIN_INTERFACE_MAP(CConfigurationDialog, CDialogEx)
	INTERFACE_PART(CConfigurationDialog, IID_IConfigurationDialog, Dispatch)
END_INTERFACE_MAP()


// CConfigurationDialog message handlers



void CConfigurationDialog::OnBnClickedConradio1()
{
	// TODO: Add your control notification handler code here
	CONXLSFiles=FALSE;
	UpdateData(TRUE);
	XLSX=FALSE;
	RadioCON1=0;
	RadioCON2=-1;
	UpdateData(FALSE);
}


void CConfigurationDialog::OnBnClickedConradio2()
{
	// TODO: Add your control notification handler code here
	CONXLSFiles=TRUE;
	UpdateData(TRUE);
	XLSX=TRUE;
	RadioCON1=-1;
	RadioCON2=0;	
	UpdateData(FALSE);
}


void CConfigurationDialog::OnBnClickedConradio3()
{
	// TODO: Add your control notification handler code here
	CONIsOrNorOrBoth=1;
	UpdateData(TRUE);
	CONIsOrNorOrBoth=1;
	RadioCON3=0;
	RadioCON4=-1;
	RadioCON5=-1;
	UpdateData(FALSE);
	

}


void CConfigurationDialog::OnBnClickedConradio4()
{
	// TODO: Add your control notification handler code here
	CONIsOrNorOrBoth=2;
	UpdateData(TRUE);
	CONIsOrNorOrBoth=2;
	RadioCON3=-1;
	RadioCON4=0;
	RadioCON5=-1;
	UpdateData(FALSE);
	
	
}


void CConfigurationDialog::OnBnClickedConradio5()
{
	// TODO: Add your control notification handler code here
	CONIsOrNorOrBoth=3;
	UpdateData(TRUE);
	CONIsOrNorOrBoth=3;
	RadioCON3=-1;
	RadioCON4=-1;
	RadioCON5=0;
	UpdateData(FALSE);
	
	
}


void CConfigurationDialog::OnBnClickedConradio6()
{
	// TODO: Add your control notification handler code here
	IsForAllOrIsForOneSheet=-1;
	UpdateData(TRUE);
	RadioCON6=0;
	RadioCON7=-1;
	UpdateData(FALSE);
	
}


void CConfigurationDialog::OnBnClickedConradio7()
{
	// TODO: Add your control notification handler code here
	IsForAllOrIsForOneSheet=1;
	UpdateData(TRUE);
	RadioCON6=-1;
	RadioCON7=0;
	UpdateData(FALSE);
}


void CConfigurationDialog::OnBnClickedConradio8()
{
	// TODO: Add your control notification handler code here
	CONExactString=FALSE;
	UpdateData(TRUE);
	RadioCON8=0;
	RadioCON9=-1;
	UpdateData(FALSE);
}


void CConfigurationDialog::OnBnClickedConradio9()
{
	// TODO: Add your control notification handler code here
	CONExactString=TRUE;
	UpdateData(TRUE);
	RadioCON8=-1;
	RadioCON9=0;
	UpdateData(FALSE);
}


void CConfigurationDialog::OnBnClickedOk()
{
	// TODO: Add your control notification handler code here
	UPDATEDLIST=TRUE;
	UpdateData(TRUE);
	//if (!m_pModeless)
    
	m_pModeless = new CExcellManagementDlg(0);

	//Create windows.
    if (!::IsWindow(m_pModeless->GetSafeHwnd()))
        m_pModeless->Create(IDD_EXCELLMANAGEMENT_DIALOG, this);
	
	
	
	//Show windows.
    m_pModeless->ShowWindow(SW_SHOW);

	//Initiate protected varibles.
	/*m_pModeless->Setm_strEditValueIDC_EDIT1(L"14");
	m_pModeless->Setm_strEditValueIDC_EDIT5(L"1");
	m_pModeless->Setm_strEditValueIDC_EDIT6(L"6");
	m_pModeless->Setm_strEditValueIDC_EDIT3(L"7");
	m_pModeless->Setm_strEditValueIDC_EDIT4(L"14");
	m_pModeless->Setm_strEditValueIDC_EDIT2(L"E:\\Docs\\");
	m_pModeless->Setm_strEditValueIDC_EDIT7(L"RaminEdjlal\\");	
	m_pModeless->Setm_strEditValueIDC_MFCEDITBROWSE1(L"C:\\Users\\RaminE\\Desktop\\A File For Containing Files In Docs.xlsx");
	*/
	//Update variables.
	m_pModeless->UpdateData(FALSE);

	//Hide windows current.
	this->ShowWindow(SW_HIDE);
}


void CConfigurationDialog::OnBnClickedCancel()
{
	// TODO: Add your control notification handler code here
	CDialogEx::OnCancel();
}


void CConfigurationDialog::OnEnChangeConedit5()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	
}


void CConfigurationDialog::OnEnChangeConedit6()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	UpdateData(TRUE);
}


void CConfigurationDialog::OnEnChangeConedit1()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	UpdateData(TRUE);
}


void CConfigurationDialog::OnEnChangeConedit2()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	UpdateData(TRUE);
}


void CConfigurationDialog::OnEnChangeConedit3()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	UpdateData(TRUE);
}


void CConfigurationDialog::OnEnChangeConedit4()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	UpdateData(TRUE);
}
