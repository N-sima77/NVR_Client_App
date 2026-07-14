
#include "stdafx.h"
#include "SimpleSample_LocalFilePlay.h"
#include "SimpleSample_LocalFilePlayDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CSimpleSample_LocalFilePlayApp

BEGIN_MESSAGE_MAP(CSimpleSample_LocalFilePlayApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()

CSimpleSample_LocalFilePlayApp::CSimpleSample_LocalFilePlayApp()
{
}


CSimpleSample_LocalFilePlayApp theApp;



BOOL CSimpleSample_LocalFilePlayApp::InitInstance()
{

	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);

	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	AfxEnableControlContainer();


	CSimpleSample_LocalFilePlayDlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
	}
	else if (nResponse == IDCANCEL)
	{
	}
	return FALSE;}
