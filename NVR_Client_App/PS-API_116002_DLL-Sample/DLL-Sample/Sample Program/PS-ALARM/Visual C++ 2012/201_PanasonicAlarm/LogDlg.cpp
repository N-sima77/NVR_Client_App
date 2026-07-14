// LogDlg.cpp implementation file
//

#include "stdafx.h"
#include "SimpleSample_PanasonicAlarmDlg.h"
#include "LogDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CLogDlg Dialog


CLogDlg::CLogDlg(CWnd* pParent /*=NULL*/)
    : CDialog(CLogDlg::IDD, pParent)
{
    //{{AFX_DATA_INIT(CLogDlg)
	//}}AFX_DATA_INIT
}


void CLogDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialog::DoDataExchange(pDX);
    //{{AFX_DATA_MAP(CLogDlg)
	DDX_Control(pDX, IDC_EDIT1, m_eLog);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CLogDlg, CDialog)
    //{{AFX_MSG_MAP(CLogDlg)
        // NOTE - the ClassWizard will add and remove mapping macros here.
    //}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CLogDlg Message Handler
long CLogDlg::Logging(CString str)
{
	//logging
    CString prebuf;
    CString nexbuf;

    m_eLog.GetWindowText(prebuf);
    nexbuf.Format("%s\r\n%s\n",str,prebuf);
    m_eLog.SetWindowText(nexbuf);

    return 0;
}


LRESULT CLogDlg::DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	//Logging from other thread.
	if(WM_LOGGING	==	message){
		if(wParam == NULL){
			return S_OK;
		}
		if(strlen(((char*)wParam)) == 0){
			return S_OK;
		}

		CString str;
		str.Format("%s",wParam);
		Logging(str);
		delete ((char*)wParam);
	}

	return CDialog::DefWindowProc(message, wParam, lParam);
}

//****************************************************************
//* Overview         : Disable the Return Key
//****************************************************************/
void CLogDlg::OnOK() 
{
    // Disable the Return Key.
    //CDialog::OnOK();
}

void CLogDlg::OnCancel() 
{
    // Disable the Esc Key.
    //CDialog::OnCancel();
}


