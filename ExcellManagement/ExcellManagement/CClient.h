//CCLient Class containe tow function 
//for Standard and non standard DVDS. 
//By Ramin Edjlal. Urmia Iran.
#ifndef _CCLIENT_H
#define _CCLIENT_H
#include "stdafx.h"
class CClient
{
public:
	CClient(CString File,CString Root, CString SheetOrSeparator, bool Backup,INT DVD,INT SheetA);//Constructor
	BOOL CClientForStandardDVDS(CString File,INT DVD1,INT DVD2,CString Root1,CString Root2,BOOL XLSX);//To Add Standard DVDS to excell file.
	BOOL CClientForNonStandardDVDS(CString File,INT DVD1,INT DVD2,CString Root1,CString Root2,BOOL XLSX);//To Add Non Standard DVDS to excell file.
	~CClient();//Deconstructor.
protected:
	INT Sheet;

};
#endif