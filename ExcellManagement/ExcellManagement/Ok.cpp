// Ok.cpp : implementation file
//

#include "stdafx.h"
#include "Ok.h"
#include "afxdialogex.h"


// Ok dialog

IMPLEMENT_DYNAMIC(Ok, CDialog)

Ok::Ok(CWnd* pParent /*=NULL*/)
	: CDialog(Ok::IDD, pParent)
{

}

Ok::~Ok()
{
}

void Ok::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(Ok, CDialog)
END_MESSAGE_MAP()


// Ok message handlers
