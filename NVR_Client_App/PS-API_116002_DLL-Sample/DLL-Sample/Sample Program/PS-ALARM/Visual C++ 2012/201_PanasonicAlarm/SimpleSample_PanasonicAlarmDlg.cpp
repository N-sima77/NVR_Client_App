// SimpleSample_PanasonicAlarmDlg.cpp
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
// CSimpleSample_PanasonicAlarmDlg

CSimpleSample_PanasonicAlarmDlg::CSimpleSample_PanasonicAlarmDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_PanasonicAlarmDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSimpleSample_PanasonicAlarmDlg)
	m_lAlarmPort = 0;
	//}}AFX_DATA_INIT
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CSimpleSample_PanasonicAlarmDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSimpleSample_PanasonicAlarmDlg)
	DDX_Control(pDX, IDC_LIST1, m_RcvAlarmList);
	DDX_Text(pDX, IDC_EDIT1, m_lAlarmPort);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CSimpleSample_PanasonicAlarmDlg, CDialog)
	//{{AFX_MSG_MAP(CSimpleSample_PanasonicAlarmDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, OnStart)
	ON_BN_CLICKED(IDC_BUTTON2, OnStop)
	ON_LBN_SELCHANGE(IDC_LIST1, OnListClick)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_PanasonicAlarmDlg

//****************************************************************
//* Function Name        : OnInitDialog
//* Overview             : Initialize
//****************************************************************
BOOL CSimpleSample_PanasonicAlarmDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);
	SetIcon(m_hIcon, FALSE);
	
    //-----------------------------------------------------
    //Initialize the control position
    //-----------------------------------------------------
    m_dlog.Create(IDD_LOG,GetDesktopWindow()); 
    ::SetWindowPos(m_dlog,HWND_TOP,500,300,0,0,SWP_SHOWWINDOW|SWP_NOSIZE);

    //-----------------------------------------------------
    //Initialize members
    //-----------------------------------------------------		
    m_csLog.Empty();
	m_plistener.SetLogWndHandle(m_dlog.m_hWnd);	//Set message handle
	m_plistener.SetProcHandle(this->m_hWnd);	//Set proc handle
	
	m_psalarm = GetAlarmRcv();

    // Turn on OnError event receiving
	long	lRet;
	lRet = m_psalarm->SetErrListener(&m_plistener);
	
	/* Output Logs */
	m_csLog.Format("SetErrListener(Unregistration) return value : %d ",lRet);
	m_dlog.Logging(m_csLog);	

    // Set receiving port number
	lRet = m_psalarm->SetAlarmRcvPort(1818);
	m_lAlarmPort = m_psalarm->GetAlarmRcvPort();
	SetDlgItemInt( IDC_EDIT1, m_lAlarmPort, TRUE );
	
	/* Output Logs */
	m_csLog.Format("SetAlarmRcvPort(PortNo=%d) return value : %d ",m_lAlarmPort,lRet);
	m_dlog.Logging(m_csLog);	

	return TRUE;
}

void CSimpleSample_PanasonicAlarmDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); 
		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

HCURSOR CSimpleSample_PanasonicAlarmDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

//****************************************************************
//* Function Name        : OnStart
//* Overview             : Start receiving Panasonic Alarm
//****************************************************************
void CSimpleSample_PanasonicAlarmDlg::OnStart() 
{
    // Turn on OnAlarm event receiving
	long	lRet;
	lRet = m_psalarm->SetAlarmRcvListener(&m_plistener);

	/* Output Logs */
	m_csLog.Format("SetAlarmRcvListener(Registration) return value : %d ",lRet);
	m_dlog.Logging(m_csLog);	
}

//****************************************************************
//* Function Name        : OnStop
//* Overview             : Stop receiving Panasonic Alarm
//****************************************************************
void CSimpleSample_PanasonicAlarmDlg::OnStop() 
{
	// Turn off OnAlarm event receiving
	long	lRet;
	lRet = m_psalarm->SetAlarmRcvListener(NULL);

	/* Output Logs */
	m_csLog.Format("SetAlarmRcvListener(Unregistration) return value : %d ",lRet);
	m_dlog.Logging(m_csLog);	
}

//****************************************************************
//* Function Name        : DefWindowProc
//* Overview             : 
//****************************************************************
LRESULT CSimpleSample_PanasonicAlarmDlg::DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	switch(message)
	{
		case WM_RCVALARM:
			// Check list item count
			long  lTotalCount;
			lTotalCount	= m_RcvAlarmList.GetCount();
			if(lTotalCount >= LIST_COUNT_MAX){
				// Delete item from ListBox
				m_RcvAlarmList.DeleteString(0);
			}

			// Add item to ListBox
			CString strTmp;
			strTmp.Format("%s",(char*)wParam);
			long lIndex = m_RcvAlarmList.AddString(strTmp);
			delete	((char*)wParam);
			break;
	}
	
	return CDialog::DefWindowProc(message, wParam, lParam);
}

//****************************************************************
//* Function Name        : OnListClick
//* Overview             : 
//****************************************************************
void CSimpleSample_PanasonicAlarmDlg::OnListClick() 
{
	int  lNowCurIndex;
	lNowCurIndex = m_RcvAlarmList.GetCurSel();
	CString strTmp;
	m_RcvAlarmList.GetText(lNowCurIndex,strTmp);

	//long lRet;
	MessageBox(strTmp,"Panasonic Alarm");
}

