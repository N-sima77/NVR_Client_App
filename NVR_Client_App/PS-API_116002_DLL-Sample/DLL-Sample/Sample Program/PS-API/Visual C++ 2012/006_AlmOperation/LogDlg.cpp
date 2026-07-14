// LogDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_Alarm.h"
#include "LogDlg.h"


// CLogDlg Dialog

IMPLEMENT_DYNAMIC(CLogDlg, CDialog)

CLogDlg::CLogDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CLogDlg::IDD, pParent)
{

}

CLogDlg::~CLogDlg()
{
}

void CLogDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT1, m_eLog);
}


BEGIN_MESSAGE_MAP(CLogDlg, CDialog)
END_MESSAGE_MAP()


// CLogDlg Message Handler

long CLogDlg::Logging(CString str)
{
//logging
	CString prebuf;
	CString nexbuf;

	m_eLog.GetWindowText(prebuf);
	if(prebuf == ""){
		nexbuf.Format("%s",str);
	}else{
		nexbuf.Format("%s\r\n%s",prebuf,str);
	}
	m_eLog.SetWindowText(nexbuf);

	return 0;
}


LRESULT CLogDlg::DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	//Logging from other thread.
	if(WM_LOGGING	==	message){
		if(wParam == NULL)return S_OK;
		if(strlen(((char*)wParam)) == 0)return S_OK;
		CString str;
		str.Format("%s",wParam);
		Logging(str);
		delete ((char*)wParam);
	}

	return CDialog::DefWindowProc(message, wParam, lParam);
}
