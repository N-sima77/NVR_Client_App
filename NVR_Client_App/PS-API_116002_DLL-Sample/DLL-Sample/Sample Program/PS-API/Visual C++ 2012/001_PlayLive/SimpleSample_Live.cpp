// SimpleSample_Live.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "SimpleSample_Live.h"
#include "SimpleSample_LiveDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_LiveApp

BEGIN_MESSAGE_MAP(CSimpleSample_LiveApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()


// CSimpleSample_LiveApp construction

CSimpleSample_LiveApp::CSimpleSample_LiveApp()
{
    // TODO: add construction code here,
    // Place all significant initialization in InitInstance
}


// The one and only CSimpleSample_LiveApp object

CSimpleSample_LiveApp theApp;


// CSimpleSample_LiveApp initialization

BOOL CSimpleSample_LiveApp::InitInstance()
{
	// 
	// 
	// 
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// 
	// 
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	AfxEnableControlContainer();

    // Standard initialization
    // If you are not using these features and wish to reduce the size
    //  of your final executable, you should remove from the following
    //  the specific initialization routines you do not need.



	CSimpleSample_LiveDlg dlg;
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
