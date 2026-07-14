
#include "stdafx.h"
#include "SimpleSample_LiveMulti.h"
#include "SimpleSample_LiveMultiDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_LiveMultiApp

BEGIN_MESSAGE_MAP(CSimpleSample_LiveMultiApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()



CSimpleSample_LiveMultiApp::CSimpleSample_LiveMultiApp()
{
}


CSimpleSample_LiveMultiApp theApp;


BOOL CSimpleSample_LiveMultiApp::InitInstance()
{

	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);

	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	AfxEnableControlContainer();


	CSimpleSample_LiveMultiDlg dlg;
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
