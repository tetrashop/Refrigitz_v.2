//Main Dialog File. Implemented by Microsoft and Ramin Edjlal.
//Ramin Edjlal.Urmia Iran.
#include "stdafx.h"
// ExcellManagementDlg.h : header file
//

#pragma once


// CExcellManagementDlg dialog
class CExcellManagementDlg : public CDialogEx
{
// Construction
public:
	CExcellManagementDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CExcellManagementDlg();	// standard constructor

// Dialog Data
	enum { IDD = IDD_EXCELLMANAGEMENT_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	BOOL XLSX;
	INT RadioEXE1;
	INT RadioEXE2;
	INT RadioEXE3;
	CButton m_1;
	CButton m_2;
	CButton m_3;
	INT IsOrNorOrBoth;
	CString m_strEditValueIDC_EDIT1;
	CString m_strEditValueIDC_EDIT2;
	CString m_strEditValueIDC_EDIT3;
	CString m_strEditValueIDC_EDIT4;
	CString m_strEditValueIDC_EDIT5;
	CString m_strEditValueIDC_EDIT6;
	CString m_strEditValueIDC_EDIT7;
	CString m_strEditValueIDC_MFCEDITBROWSE1;
	HICON m_hIcon;
	

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	void Setm_strEditValueIDC_EDIT1(CString a){m_strEditValueIDC_EDIT1=a;}
	void Setm_strEditValueIDC_EDIT2(CString b){m_strEditValueIDC_EDIT2=b;}
	void Setm_strEditValueIDC_EDIT3(CString c){m_strEditValueIDC_EDIT3=c;}
	void Setm_strEditValueIDC_EDIT4(CString d){m_strEditValueIDC_EDIT4=d;}
	void Setm_strEditValueIDC_EDIT5(CString e){m_strEditValueIDC_EDIT5=e;}
	void Setm_strEditValueIDC_EDIT6(CString f){m_strEditValueIDC_EDIT6=f;}
	void Setm_strEditValueIDC_EDIT7(CString g){m_strEditValueIDC_EDIT7=g;}	
	void Setm_strEditValueIDC_MFCEDITBROWSE1(CString h){m_strEditValueIDC_MFCEDITBROWSE1=h;}
	void SetIsOrNorOrBoth(INT a){IsOrNorOrBoth=a;}
	afx_msg void OnEnChangeEdit2();
	afx_msg void OnBnClickedCancel();
	afx_msg void OnBnClickedRadio1();
	afx_msg void OnBnClickedRadio2();
	afx_msg void OnBnClickedRadio4();
	afx_msg void OnEnChangeEdit4();
	afx_msg void OnEnChangeEdit3();
	afx_msg void OnEnChangeEdit5();
	afx_msg void OnEnChangeEdit6();
	afx_msg void OnBnClickedOk();
	afx_msg void OnEnChangeEdit1();
	afx_msg void OnEnChangeEdit7();
	afx_msg void OnEnChangeMfceditbrowse1();
	afx_msg void OnBnClickedButton1();
	
	afx_msg void OnBnClickedButton2();
	
	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton4();
	afx_msg void OnBnClickedRadio3();
};
