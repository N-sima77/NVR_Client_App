// CSimpleSample_AlarmDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_Alarm.h"
#include "SimpleSample_AlarmDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_AlarmDlg::CSimpleSample_AlarmDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_AlarmDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_AlarmDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON2, m_bAlarm);
	DDX_Control(pDX, IDC_BUTTON3, m_bArmOn);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_AlarmDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_AlarmDlg::OnAlarmControll)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_AlarmDlg::OnAlarmOn)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_AlarmDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_AlarmDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_AlarmDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);
	SetIcon(m_hIcon, FALSE);

    //-----------------------------------------------------
    //Initialize members
    //-----------------------------------------------------		
    m_csLog.Empty();

    //-----------------------------------------------------
    //Initialize the control position
    //-----------------------------------------------------
    this->MoveWindow(0,0,280,150);
	m_bAlarm.MoveWindow(10,30,120,50);
	m_bArmOn.MoveWindow(140,30,120,50);

	m_bAlarm.SetWindowText("Alarm Reset");
	m_bArmOn.SetWindowText("Alarm On");

	m_dlog.Create(IDD_LOG,GetDesktopWindow()); 
    ::SetWindowPos(m_dlog,HWND_TOP,280,0,0,0,SWP_SHOWWINDOW | SWP_NOSIZE);

	m_pcallback.SetLogWndHandle(m_dlog.m_hWnd);		//Set message handle
	m_pcallback.SetProcHandle(this->m_hWnd);		//Set proc handle

    //-----------------------------------------------------
    //Create an instance
    //-----------------------------------------------------	
    m_psapi = NULL;
    m_psapi = GetIPSAPI();

    //-----------------------------------------------------
    //Set properties
    //-----------------------------------------------------
    //Set properties to connect the device
    m_psapi->SetIPAddr("192.168.0.250"); //IP address of the device
    m_psapi->SetDeviceType(1);          //Device type:0-3
    m_psapi->SetHttpPort(80);           //Port:0-65535
    m_psapi->SetUserName("ADMIN");      //User name to access the device
    m_psapi->SetPassword("12345");      //Password to access the device

     //-----------------------------------------------------
    //Set Listener
    //-----------------------------------------------------
	m_psapi->SetErrListener((IAppListener*)&m_pcallback);
	m_psapi->SetDevListener(NULL);
	m_psapi->SetRecListener(NULL);
	m_psapi->SetPlayListener(NULL);
	m_psapi->SetImageListener(NULL,1);
	m_psapi->SetRecordListener(NULL);
	m_psapi->SetOpListener(NULL);
	m_psapi->SetAlmListener((IAppListener*)&m_pcallback);

    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;

    //-----------------------------------------------------
    //Connect to the device
    //-----------------------------------------------------
	lRet = m_psapi->Open();
	m_csLog.Format("[Function] Open:%d",lRet);
	m_dlog.Logging(m_csLog);	


	return TRUE;  // return TRUE  unless you set the focus to a control
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_AlarmDlg::OnClose()
{
    //-----------------------------------------------------
    //Close connection to the device
    //-----------------------------------------------------
    m_psapi->Close();
    m_csLog.Format("[Function] Close");
    m_dlog.Logging(m_csLog);

	//-----------------------------------------------------
	//Set Listener
	//-----------------------------------------------------
 	m_psapi->SetErrListener(NULL);
	m_psapi->SetDevListener(NULL);
	m_psapi->SetRecListener(NULL);
	m_psapi->SetPlayListener(NULL);
	m_psapi->SetImageListener(NULL,1);
	m_psapi->SetRecordListener(NULL);
	m_psapi->SetOpListener(NULL);
	m_psapi->SetAlmListener(NULL);

    //-----------------------------------------------------
    //Delete the instance
    //-----------------------------------------------------
    DeleteIPSAPI(m_psapi);
    m_psapi = NULL;

	EndDialog( IDCANCEL );

//	CDialog::OnClose();
}

//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_AlarmDlg::OnDestroy()
{
	CDialog::OnDestroy();

    //-----------------------------------------------------
    //Destroy the log window
    //-----------------------------------------------------
    m_dlog.DestroyWindow();

}

//****************************************************************
//* Function Name   : OnPaint
//****************************************************************/
void CSimpleSample_AlarmDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

//****************************************************************
//* Function Name   : OnAlarmControll
//* Overview        : Call AlarmListener.
//* Parameter[in]   : NONE
//* Parameter[out]  : NONE
//* Return Value    : NONE
//* Comments        : 
//****************************************************************/
void CSimpleSample_AlarmDlg::OnAlarmControll()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long    lRet        =   0;
	long	lChannel	=	0;
	long	lCommand	=	0;
	long    lStatus     =   0;
    long    lBlocking   =   0;

	if( m_psapi->GetUID() > -1){
		lChannel	=	1;
		lCommand	=	1;
		lBlocking	=	0;
		lRet	=	m_psapi->AlmOperation(lChannel, lCommand, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] AlarmOperation(Reset):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No login.");
		m_dlog.Logging(m_csLog);
	}
}


void CSimpleSample_AlarmDlg::OnAlarmOn()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long    lRet        =   0;
	long	lChannel	=	0;
	long	lCommand	=	0;
	long    lStatus     =   0;
    long    lBlocking   =   0;

	if( m_psapi->GetUID() > -1){
		lChannel	=	1;
		lCommand	=	2;
		lBlocking	=	0;
		lRet	=	m_psapi->AlmOperation(lChannel, lCommand, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] AlarmOperation(ON):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No login.");
		m_dlog.Logging(m_csLog);
	}
}
