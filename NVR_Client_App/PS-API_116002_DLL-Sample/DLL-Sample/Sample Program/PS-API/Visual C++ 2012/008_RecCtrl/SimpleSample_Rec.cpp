
#include "stdafx.h"
#include "SimpleSample_Rec.h"
#include "SimpleSample_RecDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_RecApp

BEGIN_MESSAGE_MAP(CSimpleSample_RecApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()



CSimpleSample_RecApp::CSimpleSample_RecApp()
{
}


CSimpleSample_RecApp theApp;


BOOL CSimpleSample_RecApp::InitInstance()
{

	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);

	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	AfxEnableControlContainer();


	CSimpleSample_RecDlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
	}
	else if (nResponse == IDCANCEL)
	{
	}
	return FALSE;
}
