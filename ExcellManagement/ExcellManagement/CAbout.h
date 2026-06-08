//About Text Dialog Class file.
//Ramin Edjlal. Urmia.Iran.

#include "resource.h"
#pragma once


// CAbout dialog

class CAbout : public CDialogEx
{
	DECLARE_DYNAMIC(CAbout)

public:
	CAbout(CWnd* pParent = NULL);   // standard constructor
	virtual ~CAbout();

	virtual void OnFinalRelease();

// Dialog Data
	enum { IDD = IDD_ABOUT_DIALOG1 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};
