
// CAbout message handlers


// About.cpp : implementation file
//Ramin Edjlal. Urmia Iran.

#include "stdafx.h"
#include "CAbout.h"
#include "afxdialogex.h"


// CAbout dialog

IMPLEMENT_DYNAMIC(CAbout, CDialogEx)

CAbout::CAbout(CWnd* pParent /*=NULL*/)
	: CDialogEx(CAbout::IDD, pParent)
{
#ifndef _WIN32_WCE
	EnableActiveAccessibility();
#endif

	EnableAutomation();

}

CAbout::~CAbout()
{
}

void CAbout::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CDialogEx::OnFinalRelease();
}

void CAbout::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(CAbout, CDialogEx)
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CAbout, CDialogEx)
END_DISPATCH_MAP()

// Note: we add support for IID_IAbout to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .IDL file.

// {7A7CF58E-29F2-4806-AC86-61026FA2D8EF}
static const IID IID_IAbout =
{ 0x7A7CF58E, 0x29F2, 0x4806, { 0xAC, 0x86, 0x61, 0x2, 0x6F, 0xA2, 0xD8, 0xEF } };

BEGIN_INTERFACE_MAP(CAbout, CDialogEx)
	INTERFACE_PART(CAbout, IID_IAbout, Dispatch)
END_INTERFACE_MAP()


// CAbout message handlers
