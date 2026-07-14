
#include "stdafx.h"
#include "SimpleSample_Play.h"
#include "SimpleSample_PlayDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_PlayApp

BEGIN_MESSAGE_MAP(CSimpleSample_PlayApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()


CSimpleSample_PlayApp::CSimpleSample_PlayApp()
{

}

CSimpleSample_PlayApp theApp;


BOOL CSimpleSample_PlayApp::InitInstance()
{

	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);

	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	AfxEnableControlContainer();

	CSimpleSample_PlayDlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
	}
	else if (nResponse == IDCANCEL)
	{
	}
	return FALSE;}
