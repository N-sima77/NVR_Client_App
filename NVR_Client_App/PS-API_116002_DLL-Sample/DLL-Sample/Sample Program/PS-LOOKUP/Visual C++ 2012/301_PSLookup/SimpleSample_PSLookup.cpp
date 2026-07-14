// SimpleSample_PSLookup.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "SimpleSample_PSLookup.h"
#include "SimpleSample_PSLookupDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_PSLookupApp

BEGIN_MESSAGE_MAP(CSimpleSample_PSLookupApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()


// CSimpleSample_PSLookupApp construction

CSimpleSample_PSLookupApp::CSimpleSample_PSLookupApp()
{
    // TODO: add construction code here,
    // Place all significant initialization in InitInstance
}


// The one and only CSimpleSample_PSLookupApp object

CSimpleSample_PSLookupApp theApp;


// CSimpleSample_PSLookupApp initialization

BOOL CSimpleSample_PSLookupApp::InitInstance()
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

	CSimpleSample_PSLookupDlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
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
