// SimpleSample_AudioDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_Audio.h"
#include "SimpleSample_AudioDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_AudioDlg
//****************************************************************/
CSimpleSample_AudioDlg::CSimpleSample_AudioDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_AudioDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_AudioDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bLiveStart);
	DDX_Control(pDX, IDC_BUTTON2, m_bLiveStop);
	DDX_Control(pDX, IDC_BUTTON3, m_bAudioSendStart);
	DDX_Control(pDX, IDC_BUTTON4, m_bAudioSendStop);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_AudioDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_AudioDlg::LiveStart)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_AudioDlg::LiveStop)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_AudioDlg::AudioSendStart)
	ON_BN_CLICKED(IDC_BUTTON4, &CSimpleSample_AudioDlg::AudioSendStop)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_AudioDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_AudioDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_AudioDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);
	SetIcon(m_hIcon, FALSE);

	//-----------------------------------------------------
    //Initialize members
	//-----------------------------------------------------		
	PlayStatus = PLAYSTOP;
	m_csLog.Empty();

	//-----------------------------------------------------
    //Initialize the control position
	//-----------------------------------------------------
	AfxMessageBox("Please confirm beforehand that the audio function of a target device is available.", MB_OK|MB_ICONINFORMATION,0);

	this->MoveWindow(0,0,640,600);
	m_bLiveStart.MoveWindow(10,500,100,50);
	m_bLiveStop.MoveWindow(120,500,100,50);
	m_bAudioSendStart.MoveWindow(250,500,150,50);
	m_bAudioSendStop.MoveWindow(410,500,150,50);

	m_dlog.Create(IDD_LOG,GetDesktopWindow()); 
    ::SetWindowPos(m_dlog,HWND_TOP,640,0,0,0,SWP_SHOWWINDOW | SWP_NOSIZE);

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
    m_psapi->SetIPAddr("192.168.0.10"); //IP address of the device
    m_psapi->SetDeviceType(2);          //Device type:0-3
    m_psapi->SetHttpPort(80);           //Port:0-65535
    m_psapi->SetUserName("admin");      //User name to access the device
    m_psapi->SetPassword("12345");      //Password to access the device

    //Set properties for display area
    m_psapi->SetVideoWindow(this->m_hWnd);  //Set the window handle to display
    m_psapi->SetImageWidth(640);            //Image width
    m_psapi->SetImageHeight(480);           //Imgae Height

    //Set properties for image format
    m_psapi->SetStreamFormat(0);        //Image format - JPEG:0,MPEG4:1
    m_psapi->SetJPEGResolution(640);    //JPEG Resolution(It works in case of StreamFormat=0)
    m_psapi->SetMPEG4Resolution(640);   //MPEG-4 Resolution(It works in case of StreamFormat=1)
    m_psapi->SetH264Resolution(640);    //H.264 Resolution(It works in case of StreamFormat=3)

	//-----------------------------------------------------
	//Set Listener
	//-----------------------------------------------------
	m_psapi->SetErrListener((IAppListener*)&m_pcallback);
	m_psapi->SetDevListener(NULL);
	m_psapi->SetRecListener(NULL);
	m_psapi->SetPlayListener((IAppListener*)&m_pcallback);
	m_psapi->SetImageListener(NULL,1);
	m_psapi->SetRecordListener(NULL);
	m_psapi->SetOpListener(NULL);
	m_psapi->SetAlmListener(NULL);

	//Paint background color
	m_psapi->ClearImage();
	m_csLog.Format("[Function] ClearImage");
	m_dlog.Logging(m_csLog);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_AudioDlg::OnClose()
{
	//-----------------------------------------------------
    //Delete the instance
    //-----------------------------------------------------
    m_psapi->SetVideoWindow(NULL);  //Set the window handle to display

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

	DeleteIPSAPI(m_psapi);
    m_psapi = NULL;
    
	EndDialog( IDCANCEL );

//	CDialog::OnClose();
}

//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_AudioDlg::OnDestroy()
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
void CSimpleSample_AudioDlg::OnPaint()
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
//* Function Name   : LiveStart
//****************************************************************/
void CSimpleSample_AudioDlg::LiveStart()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    //-----------------------------------------------------
    //Connect to the device
    //-----------------------------------------------------
    lRet = m_psapi->Open();
	m_csLog.Format("[Function] Open:%d",lRet);
	m_dlog.Logging(m_csLog);	

	
	if(lRet > -1){
		//Success to connect
		//-----------------------------------------------------
		//Audio setting
		//-----------------------------------------------------
		m_psapi->SetAudioRcvEnable(1);
		m_psapi->SetAudioRcvVolume(10);
		m_psapi->SetAudioRcvMute(0);

		//-----------------------------------------------------
		//Start Live
		//-----------------------------------------------------
		lChannel    =   1;                      //Connect to 1ch
		lBlocking   =   0;                      //0:Blocking mode
		lRet = m_psapi->PlayLive(lChannel,lStatus,lBlocking,NULL);
		m_csLog.Format("[Function] PlayLive(Start):%d",lRet);
		m_dlog.Logging(m_csLog);	

		//Change status
		if(lRet == 0){
			//Status:Live
			PlayStatus = PLAYSTART;
		}else{
			//Status:Stop
			m_psapi->Close();
			m_csLog.Format("[Function] Close");
			m_dlog.Logging(m_csLog);	
		}
	}
}

//****************************************************************
//* Function Name   : LiveStop
//****************************************************************/
void CSimpleSample_AudioDlg::LiveStop()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long    lRet        =   0;
	long	lCommand	=	0;
	long	lSpeed		=	0;
    long    lStatus     =   0;
    long    lBlocking   =   0;

	
    if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Stop Live
		//-----------------------------------------------------
		lCommand	=	1;
		lSpeed		=	1;	//If you want to stop play, you set zero.
		lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->PlayControl(lCommand,lSpeed,lStatus,lBlocking,NULL);
		m_csLog.Format("[Function] PlayLive(Stop):%d",lRet);
		m_dlog.Logging(m_csLog);

		//-----------------------------------------------------
		//Close connection to the device
		//-----------------------------------------------------
		m_psapi->Close();
		m_csLog.Format("[Function] Close");
		m_dlog.Logging(m_csLog);

		m_psapi->ClearImage();
		m_csLog.Format("[Function] ClearImage");
		m_dlog.Logging(m_csLog);

		//Change status
		PlayStatus = PLAYSTOP;
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : AudioSendStart
//****************************************************************/
void CSimpleSample_AudioDlg::AudioSendStart()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long    lRet        =   0;
    long    lCommand    =   0;
 
	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Audio setting
		//-----------------------------------------------------
		m_psapi->SetAudioSendVolume(10);
		m_psapi->SetAudioSendMute(0);

		//-----------------------------------------------------
		//Audio transmission start
		//-----------------------------------------------------
		lRet = m_psapi->GetAudioSendStatus();
		if( lRet == 0 ){
			lCommand = 1;
			lRet = m_psapi->AudioSend(lCommand);
			m_csLog.Format("[Function] AudioSend(Start):%d",lRet);
			m_dlog.Logging(m_csLog);	
		}
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name   : AudioSendStop
//****************************************************************/
void CSimpleSample_AudioDlg::AudioSendStop()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long    lRet        =   0;
    long    lCommand    =   0;
 
	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Audio transmission stop
		//-----------------------------------------------------
		lRet = m_psapi->GetAudioSendStatus();
		if( lRet == 1 ){
			lCommand = 0;
			lRet = m_psapi->AudioSend(lCommand);
			m_csLog.Format("[Function] AudioSend(Stop):%d",lRet);
			m_dlog.Logging(m_csLog);	
		}else{
			m_csLog.Format("[Message] No audio transmission.");
			m_dlog.Logging(m_csLog);
		}
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
	}
}
