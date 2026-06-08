
#pragma once

#include <afxvslistbox.h>
// CSearchDialog dialog

class CSearchDialog : public CExcellManagementDlg,public CReplace
{
	DECLARE_DYNAMIC(CSearchDialog)

public:
	CSearchDialog(CString File, CString SheetOrSeparator, bool Backup ,INT SheetA,CWnd* pParent,BOOL XLSX);   // standard constructor
	virtual ~CSearchDialog();

	virtual void OnFinalRelease();

// Dialog Data
	enum { IDD = IDD_SEARCHDIALOG1 };

protected:
	CExcellManagementDlg * m_pModeless;
	CString m_strEditValueIDC_EDITSEARCH1;
	CString m_strEditValueIDC_EDITSEARCH2;
	CString m_strEditValueIDC_EDITSEARCH3;
	CString m_strEditValueIDC_EDITSEARCH4;
	CVSListBox m_VSListBoxIDC_MFCVSLISTBOX1;
	INT RadioSER1;
	INT RadioSER2;
	INT RadioSER3;
	INT RadioSER4;
	CButton mSER_1;
	CButton mSER_2;
	CButton mSER_3;
	CButton mSER_4;
	INT IsForAllOrIsForOneSheet;
	BOOL ExactString;
	BOOL XLSXCON;

	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
public:
	void Setm_strEditValueIDC_EDITSEARCH1(CString a){m_strEditValueIDC_EDITSEARCH1=a;}
	void Setm_strEditValueIDC_EDITSEARCH2(CString b){m_strEditValueIDC_EDITSEARCH2=b;}
	void Setm_strEditValueIDC_EDITSEARCH3(CString c){m_strEditValueIDC_EDITSEARCH3=c;}
	void Setm_strEditValueIDC_EDITSEARCH4(CString d){m_strEditValueIDC_EDITSEARCH4=d;}
	void SetIsForAllOrIsForOneSheet(INT a){IsForAllOrIsForOneSheet=a;}
	void SetExactString(BOOL a){ExactString=a;}

	void SetRadio1(INT a){RadioSER1=a;}
	void SetRadio2(INT b){RadioSER2=b;}
	void SetRadio3(INT c){RadioSER3=c;} 
	void SetRadio4(INT d){RadioSER4=d;}
	void SetXLSX(BOOL a){XLSXCON=a;}
	
	
	afx_msg void OnBnClickedOk();
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedRadio1();
	afx_msg void OnBnClickedRadio2();
	
	afx_msg void OnBnClickedRadio3();
	afx_msg void OnBnClickedRadio4();
	afx_msg void OnBnClickedButton2();
};
