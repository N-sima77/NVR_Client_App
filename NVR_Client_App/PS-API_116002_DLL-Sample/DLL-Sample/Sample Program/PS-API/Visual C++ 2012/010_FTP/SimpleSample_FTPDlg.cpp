// SimpleSample_FTPDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_FTP.h"
#include "SimpleSample_FTPDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_FTPDlg::CSimpleSample_FTPDlg(CWnd* pParent /*=NULL*/)
    : CDialog(CSimpleSample_FTPDlg::IDD, pParent)
{
    //{{AFX_DATA_INIT(CSimpleSample_FTPDlg)
	m_sYear = _T("2010");
	m_sMonth = _T("07");
	m_sDay = _T("01");
	m_sHour = _T("09");
	m_sMin = _T("59");
	m_sSec = _T("00");
	m_eYear = _T("2010");
	m_eMonth = _T("07");
	m_eDay = _T("01");
	m_eHour = _T("10");
	m_eMin = _T("01");
	m_eSec = _T("00");
	m_bType_EMR = FALSE;
	m_bType_MAN = FALSE;
	m_bType_SCH = FALSE;
	m_bType_TRM = FALSE;
	m_bType_CMD = FALSE;
	m_bType_VMD = FALSE;
	m_bType_SDB = FALSE;
	m_bType_VLA = FALSE;
	m_bType_VMDAlm = FALSE;
	m_bType_motion = FALSE;
	m_bType_loitering = FALSE;
	m_bType_removal = FALSE;
	m_bType_screen = FALSE;
	m_bType_terminal = FALSE;
	m_bType_direction = FALSE;
	m_fName = _T("C:\\DownloadData");
	m_DataType = 0;
	//}}AFX_DATA_INIT
    // Note that LoadIcon does not require a subsequent DestroyIcon in Win32
    m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_FTPDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialog::DoDataExchange(pDX);
    //{{AFX_DATA_MAP(CSimpleSample_FTPDlg)
	DDX_Text(pDX, IDC_EDIT2, m_sYear);
	DDX_Text(pDX, IDC_EDIT3, m_sMonth);
	DDX_Text(pDX, IDC_EDIT4, m_sDay);
	DDX_Text(pDX, IDC_EDIT5, m_sHour);
	DDX_Text(pDX, IDC_EDIT6, m_sMin);
	DDX_Text(pDX, IDC_EDIT7, m_sSec);
	DDX_Text(pDX, IDC_EDIT8, m_eYear);
	DDX_Text(pDX, IDC_EDIT9, m_eMonth);
	DDX_Text(pDX, IDC_EDIT10, m_eDay);
	DDX_Text(pDX, IDC_EDIT11, m_eHour);
	DDX_Text(pDX, IDC_EDIT12, m_eMin);
	DDX_Text(pDX, IDC_EDIT13, m_eSec);
	DDX_Check(pDX, IDC_CHECK2, m_bType_EMR);
	DDX_Check(pDX, IDC_CHECK3, m_bType_MAN);
	DDX_Check(pDX, IDC_CHECK4, m_bType_SCH);
	DDX_Check(pDX, IDC_CHECK5, m_bType_TRM);
	DDX_Check(pDX, IDC_CHECK6, m_bType_CMD);
	DDX_Check(pDX, IDC_CHECK7, m_bType_VMD);
	DDX_Check(pDX, IDC_CHECK1, m_bType_SDB);
	DDX_Check(pDX, IDC_CHECK8, m_bType_VLA);
	DDX_Check(pDX, IDC_CHECK9, m_bType_VMDAlm);
	DDX_Check(pDX, IDC_CHECK10, m_bType_motion);
	DDX_Check(pDX, IDC_CHECK11, m_bType_loitering);
	DDX_Check(pDX, IDC_CHECK12, m_bType_removal);
	DDX_Check(pDX, IDC_CHECK13, m_bType_screen);
	DDX_Check(pDX, IDC_CHECK14, m_bType_terminal);
	DDX_Check(pDX, IDC_CHECK15, m_bType_direction);
	DDX_Text(pDX, IDC_EDIT16, m_fName);
	DDX_Text(pDX, IDC_EDIT15, m_DataType);
	//}}AFX_DATA_MAP
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_FTPDlg, CDialog)
    //{{AFX_MSG_MAP(CSimpleSample_FTPDlg)
    ON_WM_PAINT()
    ON_WM_CREATE()
    ON_WM_DESTROY()
    ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BUTTON1, OnFtpDownload)
    ON_WM_SYSCOMMAND()
    ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_FTPDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_FTPDlg::OnCreate(LPCREATESTRUCT lpCreateStruct) 
{
    if (CDialog::OnCreate(lpCreateStruct) == -1)
        return -1;

    return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_FTPDlg::OnInitDialog()
{
    CDialog::OnInitDialog();

    SetIcon(m_hIcon, TRUE);         // Set big icon
    SetIcon(m_hIcon, FALSE);        // Set small icon

    //-----------------------------------------------------
    //Initialize members
    //-----------------------------------------------------		
    m_csLog.Empty();

    //-----------------------------------------------------
    //Initialize the control position
    //-----------------------------------------------------
    this->MoveWindow(0,0,480,500);
    m_dlog.Create(IDD_LOG,GetDesktopWindow()); 
    ::SetWindowPos(m_dlog,HWND_TOP,480,0,0,0,SWP_SHOWWINDOW | SWP_NOSIZE);

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
	m_psapi->SetPassword("admin123");      //Password to access the device

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
	m_psapi->SetAlmListener(NULL);

    return TRUE;  // return TRUE  unless you set the focus to a control
}


//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_FTPDlg::OnClose() 
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

	//CDialog::OnClose();
}
//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_FTPDlg::OnDestroy() 
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
void CSimpleSample_FTPDlg::OnPaint() 
{
    CDialog::OnPaint();
}

//****************************************************************
//* Function Name   : OnFtpDownload
//****************************************************************/
void CSimpleSample_FTPDlg::OnFtpDownload() 
{

	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
	long lRet		=	0;
	long lChannel	=	0;
	char csStartTD[256];
	char csEndTD[256];
	long lData		=	0;
	long lType		=	0;
	char csFileName[256];
	long lStatus	=	0;
	long lBlockMode	=	0;
	FTPTYPE stType;

	memset(csStartTD,0,256);
	memset(csEndTD ,0,256);
	memset(csFileName ,0,256);
	
	if(m_psapi->GetUID() == -1){
		//Connect to the device
		lRet = m_psapi->Open();
		m_csLog.Format("[Function] Open:",lRet);
		m_dlog.Logging(m_csLog);
	}

	//-----------------------------------------------------
	//FTP
	//-----------------------------------------------------
	if(m_psapi->GetUID() > -1){
		UpdateData(TRUE);
		lChannel = 1;
		
		wsprintf(csStartTD,"%s/%s/%s %s:%s:%s\0", m_sYear, m_sMonth, m_sDay, m_sHour, m_sMin, m_sSec);	//StartTime
		wsprintf(csEndTD,"%s/%s/%s %s:%s:%s\0", m_eYear, m_eMonth, m_eDay, m_eHour, m_eMin, m_eSec);	//EndTime

		lData = m_DataType;

		if(	m_bType_EMR)stType.EMR_BIT = 1;
		if(	m_bType_MAN)stType.MAN_BIT = 1;
		if(	m_bType_SCH)stType.SCH_BIT = 1;
		if(	m_bType_TRM)stType.TRM_BIT = 1;
		if(	m_bType_CMD)stType.CMD_BIT = 1;
		if(	m_bType_VMD)stType.CAM_BIT = 1;
		if( m_bType_SDB)stType.SDB_BIT = 1;
		if( m_bType_VLA)stType.VLA_BIT = 1;
		if( m_bType_VMDAlm)stType.VMD_BIT = 1;
		if( m_bType_motion)stType.CMTN_BIT = 1;
		if( m_bType_loitering)stType.CSTY_BIT = 1;
		if( m_bType_removal)stType.CRMV_BIT = 1;
		if( m_bType_screen)stType.CSCD_BIT = 1;
		if( m_bType_terminal)stType.CTRM_BIT = 1;
		if( m_bType_direction)stType.CDRT_BIT = 1;
		lType = *(long*)&stType;

		wsprintf(csFileName,"%s",m_fName);

		lBlockMode	=	1;

		lRet = m_psapi->FtpGet(lChannel,csStartTD,csEndTD,lData,lType,csFileName,lStatus,lBlockMode,&m_pcallback);
		m_csLog.Format("FtpGet:%d (Channel[%d] Start[%s] End[%s] DataType[%d] EventType[%d] FileaName[%s] Mode[%d])",lRet,lChannel,csStartTD,csEndTD,lData,lType,csFileName,lBlockMode);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No login.");
		m_dlog.Logging(m_csLog);
	}
}

