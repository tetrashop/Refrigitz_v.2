#pragma once


// Ok dialog

class Ok : public CDialog
{
	DECLARE_DYNAMIC(Ok)

public:
	Ok(CWnd* pParent = NULL);   // standard constructor
	virtual ~Ok();

// Dialog Data
	enum { IDD = IDD_ABOUT_DIALOG1 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
};
