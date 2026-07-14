// LogDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_InternetModeLive.h"
#include "LogDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

// CLogDlg Dialog

//IMPLEMENT_DYNAMIC(CLogDlg, CDialog)

CLogDlg::CLogDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CLogDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	//{{AFX_DATA_INIT(CLogDlg)
	//}}AFX_DATA_INIT
}

CLogDlg::~CLogDlg()
{
}

void CLogDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CLogDlg, CDialog)
    //{{AFX_MSG_MAP(CLogDlg)
        // NOTE - the ClassWizard will add and remove mapping macros here.
    //}}AFX_MSG_MAP
END_MESSAGE_MAP()

// CLogDlg Message Handler

BOOL CLogDlg::OnInitDialog()
{
	SetInitialControl();

	return TRUE;
}

BOOL CLogDlg::PreTranslateMessage(MSG* pMsg)
{
	if (pMsg->message == WM_KEYDOWN) {
		switch (pMsg->wParam) {
		case VK_ESCAPE:		// Disable the Enter key
		case VK_RETURN:		// Disable the Escape key
			return TRUE;
		}
	}
	else if (pMsg->message == WM_LOGGING) {	// output log
		if (pMsg->wParam != NULL) {
			CString LogMsg;
			LogMsg.Format(_T("%s"), (TCHAR*)pMsg->wParam);
			Logging(LogMsg);
			delete ((TCHAR*)pMsg->wParam);
		}
	}
	return CDialog::PreTranslateMessage(pMsg);
}

long CLogDlg::Logging(CString str)
{
//logging
	CString prebuf;
	CString nexbuf;

	CWnd* pWnd = GetDlgItem(IDC_TXTLOG);
	pWnd->GetWindowText(prebuf);
	if(prebuf.IsEmpty()){
		nexbuf.Format(_T("%s"), str);
	}else{
		nexbuf.Format(_T("%s\r\n%s"), prebuf, str);
	}
	pWnd->SetWindowText(nexbuf);

	return 0;
}

void CLogDlg::SetInitialControl()
{
	WINDOWPLACEMENT wndPos;
	// Form setting
	this->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 680; wndPos.rcNormalPosition.top = 0;
	wndPos.rcNormalPosition.right = (680+320); wndPos.rcNormalPosition.bottom = 500;
	this->SetWindowPlacement(&wndPos);
	// Control setting
	CWnd* pWnd = GetDlgItem(IDC_TXTLOG);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 12; wndPos.rcNormalPosition.top = 24;
	wndPos.rcNormalPosition.right = 300; wndPos.rcNormalPosition.bottom = 466;
	pWnd->SetWindowPlacement(&wndPos);
}