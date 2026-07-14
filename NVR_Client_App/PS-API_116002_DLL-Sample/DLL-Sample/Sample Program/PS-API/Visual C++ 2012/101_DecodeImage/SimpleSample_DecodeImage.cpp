// SimpleSample_DecodeImage.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "SimpleSample_DecodeImage.h"
#include "SimpleSample_DecodeImageDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_DecodeImageApp

BEGIN_MESSAGE_MAP(CSimpleSample_DecodeImageApp, CWinApp)
	//{{AFX_MSG_MAP(CSimpleSample_DecodeImageApp)
        // NOTE - the ClassWizard will add and remove mapping macros here.
        //    DO NOT EDIT what you see in these blocks of generated code!
	//}}AFX_MSG
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_DecodeImageApp construction

CSimpleSample_DecodeImageApp::CSimpleSample_DecodeImageApp()
{
    // TODO: add construction code here,
    // Place all significant initialization in InitInstance
}

/////////////////////////////////////////////////////////////////////////////
// The one and only CSimpleSample_DecodeImageApp object

CSimpleSample_DecodeImageApp theApp;

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_DecodeImageApp initialization

BOOL CSimpleSample_DecodeImageApp::InitInstance()
{
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	AfxEnableControlContainer();

    // Standard initialization
    // If you are not using these features and wish to reduce the size
    //  of your final executable, you should remove from the following
    //  the specific initialization routines you do not need.


	CSimpleSample_DecodeImageDlg dlg;
	m_pMainWnd = &dlg;
	int nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
        // TODO: Place code here to handle when the dialog is
        //  dismissed with OK
	}
	else if (nResponse == IDCANCEL)
	{
        // TODO: Place code here to handle when the dialog is
        //  dismissed with Cancel
	}
	// Since the dialog has been closed, return FALSE so that we exit the
	//  application, rather than start the application's message pump.
	return FALSE;
}
