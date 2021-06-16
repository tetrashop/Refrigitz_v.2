//Configuration file class 
//Ramin Edjlal.Urmia Iran.

#pragma once


// CConfigurationDialog dialog

class CConfigurationDialog : public CDialogEx
{
	DECLARE_DYNAMIC(CConfigurationDialog)

public:
	CConfigurationDialog(CWnd* pParent = NULL);   // standard constructor
	virtual ~CConfigurationDialog();

	virtual void OnFinalRelease();

// Dialog Data
	enum { IDD = IDD_CONFIGURATIONDIALOG1 };

protected:
	BOOL XLSX;
	BOOL UPDATEDLIST;
	INT RadioCON1;
	INT RadioCON2;
	INT RadioCON3;
	INT RadioCON4;
	INT RadioCON5;
	INT RadioCON6;
	INT RadioCON7;
	INT RadioCON8;
	INT RadioCON9;

	CButton mCON_1;
	CButton mCON_2;
	CButton mCON_3;
	CButton mCON_4;
	CButton mCON_5;
	CButton mCON_6;
	CButton mCON_7;
	CButton mCON_8;
	CButton mCON_9;
	
	CString m_strEditValueIDC_CONEDIT1;
	CString m_strEditValueIDC_CONEDIT2;
	CString m_strEditValueIDC_CONEDIT3;
	CString m_strEditValueIDC_CONEDIT4;
	CString m_strEditValueIDC_CONEDIT5;
	CString m_strEditValueIDC_CONEDIT6;
	CString m_strEditValueIDC_CONEDIT7;
	CString m_strEditValueIDC_CONMFCEDITBROWSE1;
	BOOL CONXLSFiles;//To Xls Files.FALSE XLS and TRUE XLsx
	INT CONIsOrNorOrBoth;//To DVD OR NON DVD OR BOTH Operations .
	INT IsForAllOrIsForOneSheet;//To One Or More Shets.
	BOOL CONExactString;//SubString or Exact String.
	
	CExcellManagementDlg * m_pModeless;
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
public:
	BOOL GETXLSX(){return XLSX;}
	BOOL GetUPDATEDLIST(){return UPDATEDLIST;}
	INT GetIsForAllOrIsForOneSheet(){return IsForAllOrIsForOneSheet;}
	BOOL GetCONExactString(){return CONExactString;}
	CString Getm_strEditValueIDC_CONEDIT1(){return m_strEditValueIDC_CONEDIT1;}
	CString Getm_strEditValueIDC_CONEDIT2(){return m_strEditValueIDC_CONEDIT2;}
	CString Getm_strEditValueIDC_CONEDIT3(){return m_strEditValueIDC_CONEDIT3;}
	CString Getm_strEditValueIDC_CONEDIT4(){return m_strEditValueIDC_CONEDIT4;}
	CString Getm_strEditValueIDC_CONEDIT5(){return m_strEditValueIDC_CONEDIT5;}
	CString Getm_strEditValueIDC_CONEDIT6(){return m_strEditValueIDC_CONEDIT6;} 
	CString Getm_strEditValueIDC_CONEDIT7(){return m_strEditValueIDC_CONEDIT7;}
	CString Getm_strEditValueIDC_CONMFCEDITBROWSE1(){return m_strEditValueIDC_CONMFCEDITBROWSE1;}
	INT  GetCONIsOrNorOrBoth(){return CONIsOrNorOrBoth;}

	INT GetRadioCON1(){return RadioCON1;}
	INT GetRadioCON2(){return RadioCON2;}
	INT GetRadioCON3(){return RadioCON3;} 
	INT GetRadioCON4(){return RadioCON4;}
	INT GetRadioCON5(){return RadioCON5;}
	INT GetRadioCON6(){return RadioCON6;}
	INT GetRadioCON7(){return RadioCON7;}
	INT GetRadioCON8(){return RadioCON8;}
	INT GetRadioCON9(){return RadioCON9;}
	

	afx_msg void OnBnClickedRadio8();
	afx_msg void OnBnClickedRadio9();
	afx_msg void OnBnClickedRadio10();
	afx_msg void OnBnClickedRadio3();
	afx_msg void OnBnClickedRadio6();
	afx_msg void OnBnClickedRadio4();
	afx_msg void OnBnClickedRadio7();
	afx_msg void OnBnClickedRadio1();
	afx_msg void OnBnClickedRadio2();
	afx_msg void OnEnChangeEdit6();
	afx_msg void OnEnChangeEdit8();
	afx_msg void OnEnChangeEdit5();
	afx_msg void OnEnChangeEdit4();
	afx_msg void OnBnClickedConradio1();
	afx_msg void OnBnClickedConradio2();
	afx_msg void OnBnClickedConradio3();
	afx_msg void OnBnClickedConradio4();
	afx_msg void OnBnClickedConradio5();
	afx_msg void OnBnClickedConradio6();
	afx_msg void OnBnClickedConradio7();
	afx_msg void OnBnClickedConradio8();
	afx_msg void OnBnClickedConradio9();
	afx_msg void OnBnClickedOk();
	afx_msg void OnBnClickedCancel();
	afx_msg void OnEnChangeConedit5();
	afx_msg void OnEnChangeConedit6();
	afx_msg void OnEnChangeConedit1();
	afx_msg void OnEnChangeConedit2();
	afx_msg void OnEnChangeConedit3();
	afx_msg void OnEnChangeConedit4();
};
