//This Class Is A Graphical Interface for Drawing Dialog Grpahically for anouncing.
//Edited And Calssify by By Ramin Edjlal
//Urmia Iran.
#ifndef _CGRAPHICCONVERSATION_H
#define  _CGRAPHICCONVERSATION_H
#include "stdafx.h"
class CGraphicConversation:public CClient
{
//	GLubyte ubImage[65536];
	
public:
	CGraphicConversation(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA);//Constructor
	BOOL CCreateDialogWaiting(int x,int y,int width,int height,WCHAR *TEXT);//If Successful Create a Waiting Dialg Box.
	BOOL Blend(
    CString File,   // The image. Must be 32bpp ARGB format
    BYTE alpha );   // Overall opacity (0=transparent, 255=opaque)
	void init();//Iniziate the windows;
	
	~CGraphicConversation();//Deconstructor.
protected:
	INT Sheet;
};
#endif