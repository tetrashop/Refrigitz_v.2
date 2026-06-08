//This Class Is A Graphical Interface for Drawing Dialog Grpahically for anouncing.
//By Ramin Edjlal.
//Urmia.Iran.
#include "stdafx.h" 
CGraphicConversation::CGraphicConversation(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA):CClient(File,Root,SheetOrSeparator,Backup,DVD,SheetA)
{
	Sheet=SheetA;
}
void CGraphicConversation::init(void) 
{
   //glClearColor (0.0, 0.0, 0.0, 0.0);
   //glEnable(GL_LIGHTING);
   //glEnable(GL_LIGHT0);
   //glEnable(GL_DEPTH_TEST);
}

// Blend the given bitmap, hBmp, into a layered window.

BOOL CGraphicConversation::Blend(
    CString File,   // The image. Must be 32bpp ARGB format
    BYTE alpha )    // Overall opacity (0=transparent, 255=opaque)
{
	try{
		}
	catch(CException&e)
	{
		return FALSE;
	}
   return TRUE;
}
BOOL CGraphicConversation::CCreateDialogWaiting(int x,int y,int width,int height,WCHAR *TEXT)
{
	try
	{
	}
	catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}
CGraphicConversation::~CGraphicConversation()
{
}