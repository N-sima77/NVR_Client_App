// SimpleSample_PanasonicAlarm.cpp
//

#include "stdafx.h"
#include "SimpleSample_PanasonicAlarm.h"
#include "SimpleSample_PanasonicAlarmDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_PanasonicAlarmApp

BEGIN_MESSAGE_MAP(CSimpleSample_PanasonicAlarmApp, CWinApp)
	//{{AFX_MSG_MAP(CSimpleSample_PanasonicAlarmApp)
	//}}AFX_MSG
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_PanasonicAlarmApp

CSimpleSample_PanasonicAlarmApp::CSimpleSample_PanasonicAlarmApp()
{
}

/////////////////////////////////////////////////////////////////////////////
// —Bˆê‚Ì CSimpleSample_PanasonicAlarmApp

CSimpleSample_PanasonicAlarmApp theApp;

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_PanasonicAlarmApp

BOOL CSimpleSample_PanasonicAlarmApp::InitInstance()
{
	AfxEnableControlContainer();

#ifdef _AFXDLL
	//Enable3dControls();
#else
	Enable3dControlsStatic();
#endif

	CSimpleSample_PanasonicAlarmDlg dlg;
	m_pMainWnd = &dlg;
	int nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
	}
	else if (nResponse == IDCANCEL)
	{
	}
	return FALSE;
}
