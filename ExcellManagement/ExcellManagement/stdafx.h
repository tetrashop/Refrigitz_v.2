
// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently,
// but are changed infrequently

#pragma once

#ifndef _SECURE_ATL
#define _SECURE_ATL 1
#endif

#ifndef VC_EXTRALEAN
#define VC_EXTRALEAN            // Exclude rarely-used stuff from Windows headers
#endif

#include "targetver.h"
#include "resource.h" 



#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // some CString constructors will be explicit

// turns off MFC's hiding of some common and often safely ignored warning messages
#define _AFX_ALL_WARNINGS

#include <afxwin.h>         // MFC core and standard components

#include <afxext.h>         // MFC extensions


#include <afxdisp.h>        // MFC Automation classes



#ifndef _AFX_NO_OLE_SUPPORT
#include <afxdtctl.h>           // MFC support for Internet Explorer 4 Common Controls
#endif
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>             // MFC support for Windows Common Controls
#endif // _AFX_NO_AFXCMN_SUPPORT

#include <afxcontrolbars.h>     // MFC support for ribbons and control bars

#define MAX_PATH_THIS_PROJECT 10000

#include <stdio.h>
#include <stdlib.h>
#include <io.h>
#include <time.h>





#include "ExcelManager.h"

#include "CIllegalCharacterInDataBase.h"
#include "CSpreadSheet.h"

#include "CMounth.h"
#include "ConvertDate.h"

#include "CCreateDates.h"
#include "OLDBLimitColumn.h"
#include  "CDVD.h"
#include "CConjunctSubDirectory.h"
#include  "CDVDNon.h"
#include "CClient.h"

//CGraphicConversation
//using namespace std;
//#include <gl/glut.h>
//#include <windows.h>
//#include <omp.h>
//#include <math.h>
//#include <Wingdi.h>


#include <gdiplus.h>
using namespace Gdiplus;
#pragma comment (lib, "gdiplus.lib")


#include "CGraphicConversation.h"



//CCreateExcellSheet Headers
#import "C:\Program Files\Common Files\microsoft shared\OFFICE14\mso.dll"
#import "C:\Program Files\Common Files\microsoft shared\VBA\VBA6\VBE6EXT.OLB"
#import "C:\Program Files\Microsoft Office\Office14\excel.exe" \
rename("DialogBox","ExcelDialogBox") rename("RGB","ExcelRGB") \
exclude("IFont","IPicture")
#include <stdexcept>
#include <iostream>
#include "CCreateExcellSheet.h"

#include "CSearch.h"
#include "CReplace.h"

#include "ExcellManagementDlg.h"


#include "CSearchDialog.h"




#include "CSheetNumber.h"



#include "CConfigurationDialog.h"


#include "CAbout.h"


#ifdef _UNICODE
#if defined _M_IX86
#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='x86' publicKeyToken='6595b64144ccf1df' language='*'\"")
#elif defined _M_X64
#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='amd64' publicKeyToken='6595b64144ccf1df' language='*'\"")
#else
#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='*' publicKeyToken='6595b64144ccf1df' language='*'\"")
#endif
#endif


