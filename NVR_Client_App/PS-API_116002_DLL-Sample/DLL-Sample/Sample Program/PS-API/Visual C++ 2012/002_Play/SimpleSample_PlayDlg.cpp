
#include "stdafx.h"
#include "SimpleSample_Play.h"
#include "SimpleSample_PlayDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


//****************************************************************
//* Function Name   : CSimpleSample_PlayDlg
//****************************************************************/
CSimpleSample_PlayDlg::CSimpleSample_PlayDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_PlayDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_PlayDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bPrevFrame);
	DDX_Control(pDX, IDC_BUTTON2, m_bRewind);
	DDX_Control(pDX, IDC_BUTTON3, m_bReverse);
	DDX_Control(pDX, IDC_BUTTON4, m_bPause);
	DDX_Control(pDX, IDC_BUTTON5, m_bPlayBack);
	DDX_Control(pDX, IDC_BUTTON6, m_bFF);
	DDX_Control(pDX, IDC_BUTTON7, m_bNextFrame);
	DDX_Control(pDX, IDC_BUTTON8, m_bStop);
	DDX_Control(pDX, IDC_BUTTON9, m_bNextRec);
	DDX_Control(pDX, IDC_BUTTON10, m_bPrevRec);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_PlayDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_PlayDlg::PrevFrame)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_PlayDlg::Rewind)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_PlayDlg::Reverse)
	ON_BN_CLICKED(IDC_BUTTON4, &CSimpleSample_PlayDlg::Pause)
	ON_BN_CLICKED(IDC_BUTTON5, &CSimpleSample_PlayDlg::PlayBack)
	ON_BN_CLICKED(IDC_BUTTON6, &CSimpleSample_PlayDlg::FF)
	ON_BN_CLICKED(IDC_BUTTON7, &CSimpleSample_PlayDlg::NextFrame)
	ON_BN_CLICKED(IDC_BUTTON8, &CSimpleSample_PlayDlg::Stop)
	ON_BN_CLICKED(IDC_BUTTON9, &CSimpleSample_PlayDlg::NextRecord)
	ON_BN_CLICKED(IDC_BUTTON10, &CSimpleSample_PlayDlg::PrevRecord)
	ON_BN_CLICKED(IDC_CHECK, &CSimpleSample_PlayDlg::OnBnClickedCheck)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_PlayDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_PlayDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_PlayDlg::OnInitDialog()
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
    //Initialize the control position		Modefied Ver5.0.1.0
	//-----------------------------------------------------
	this->MoveWindow(0,0,640,620);
	m_bRewind.MoveWindow(5,500,100,30);
	m_bReverse.MoveWindow(110,500,100,30);
	m_bStop.MoveWindow(215,500,100,30);
	m_bPause.MoveWindow(320,500,100,30);
	m_bPlayBack.MoveWindow(425,500,100,30);
	m_bFF.MoveWindow(530,500,100,30);

	m_bPrevRec.MoveWindow(5,530,100,30);
	m_bPrevFrame.MoveWindow(110,530,100,30);
	m_bNextFrame.MoveWindow(425,530,100,30);
	m_bNextRec.MoveWindow(530,530,100,30);

	GetDlgItem(IDC_CHECK)->MoveWindow(5,565,160,16);

	//-----------------------------------------------------
	//Set control label						Modefied Ver5.0.1.0
	//-----------------------------------------------------
	m_bRewind.SetWindowText("<< Rewind");
	m_bReverse.SetWindowText("< Backward");
	m_bStop.SetWindowText("[] Stop");
	m_bPause.SetWindowText("|| Pause");
	m_bPlayBack.SetWindowText("Playback >");
	m_bFF.SetWindowText("Fast Fwd >>");

	m_bPrevRec.SetWindowText("|<< Prev Rec");
	m_bPrevFrame.SetWindowText("<|| Prev Frame");
	m_bNextFrame.SetWindowText("Next Frame ||>");
	m_bNextRec.SetWindowText("Next Rec >>|");

	GetDlgItem(IDC_CHECK)->SetWindowText("Fast and Smooth playback");

	//-----------------------------------------------------
	//Create Log Windwos
	//-----------------------------------------------------
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
	m_psapi->SetIPAddr("192.168.11.114");	//IP address of the device
	m_psapi->SetDeviceType(2);				//Device type:0-3
	m_psapi->SetHttpPort(80);				//Port:0-65535
	m_psapi->SetUserName("admin");			//User name to access the device
	m_psapi->SetPassword("Admin123");			//Password to access the device
		
	//Set properties for display area
	m_psapi->SetVideoWindow(m_hWnd);		//Set the window handle to display
	m_psapi->SetImageWidth(640);			//Image width
	m_psapi->SetImageHeight(480);			//Imgae height

	//Set properties for image format
	m_psapi->SetStreamFormat(0);			//Imgae format - JPEG:0,MPEG4:1
	m_psapi->SetJPEGResolution(640);		//JPEG ResolutionJPEG Resolution(It works in case of StreamFormat=0)
	m_psapi->SetMPEG4Resolution(640);		//MPEG-4 Resolution(It works in case of StreamFormat=1)
   	m_psapi->SetH264Resolution(640);    	//H.264 Resolution(It works in case of StreamFormat=3)

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
void CSimpleSample_PlayDlg::OnClose()
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
void CSimpleSample_PlayDlg::OnDestroy()
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
void CSimpleSample_PlayDlg::OnPaint()
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
//* Function Name   : Stop
//****************************************************************/
void CSimpleSample_PlayDlg::Stop()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	0;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Stop:%d",lRet);
		m_dlog.Logging(m_csLog);
		
		PlayStatus = PLAYSTOP;

		//-----------------------------------------------------
		//Disconnect and change the status
		//-----------------------------------------------------
		m_psapi->Close();
		m_csLog.Format("[Function] Close");
		m_dlog.Logging(m_csLog);

		m_psapi->ClearImage();
		m_csLog.Format("[Function] ClearImage");
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Pause
//****************************************************************/
void CSimpleSample_PlayDlg::Pause()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	3;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("Pause:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : PlayBack
//****************************************************************/
void CSimpleSample_PlayDlg::PlayBack()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;
	long	lchannel	=	0;
	char *	chDate		=	NULL;	

	if(PlayStatus == PLAYSTOP){
		//-----------------------------------------------------
		//Connect to the device
		//-----------------------------------------------------
		lRet = m_psapi->Open();
		m_csLog.Format("[Function] Open:%d",lRet);
		m_dlog.Logging(m_csLog);
		
		if(lRet > -1){
			//Success to connect
			//-----------------------------------------------------
			//Start Live
			//-----------------------------------------------------
			lchannel	=	1;							//Connect to 1ch
			chDate		=	"2010/07/01 00:00:00";
			lStatus		=	0;
			lBlocking	=	0;
			lRet = m_psapi->Play(lchannel, chDate, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
			m_csLog.Format("[Function] Play:%d",lRet);
			m_dlog.Logging(m_csLog);

			//-----------------------------------------------------
			//Change the play status
			//-----------------------------------------------------
			if(lRet == 0){
				//Status:PLAY
				PlayStatus = PLAYSTART;
			}else{
				m_psapi->Close();
				m_csLog.Format("[Function] Close");
				m_dlog.Logging(m_csLog);

				m_psapi->ClearImage();
				m_csLog.Format("[Function] ClearImage");
				m_dlog.Logging(m_csLog);
			}
		}
	}else{
		lCommand	=	4;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Playback:%d",lRet);
		m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name   : Reverse
//****************************************************************/
void CSimpleSample_PlayDlg::Reverse()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	5;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Backward:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : NextFrame
//****************************************************************/
void CSimpleSample_PlayDlg::NextFrame()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	6;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Next Frame:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}                                                                                                      

//****************************************************************
//* Function Name   : PrevFrame
//****************************************************************/
void CSimpleSample_PlayDlg::PrevFrame()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	7;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Previous Frame:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : FF
//****************************************************************/
void CSimpleSample_PlayDlg::FF()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	8;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Fast Forward:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Rewind
//****************************************************************/
void CSimpleSample_PlayDlg::Rewind()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	9;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Rewind:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : NextRecord
//****************************************************************/
void CSimpleSample_PlayDlg::NextRecord()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	10;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Next Record:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : PrevRecord
//****************************************************************/
void CSimpleSample_PlayDlg::PrevRecord()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lStatus		=	0;
	long	lBlocking	=	0;
	long	lCommand	=	0;
	long	lspeed		=	0;

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control playback
		//-----------------------------------------------------
		lCommand	=	11;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand, lspeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Previous Record:%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Chagne FastPlayMode			Added Ver5.0.1.0
//****************************************************************
void CSimpleSample_PlayDlg::OnBnClickedCheck()
{
	long Ret, Mode;

	CButton* pChk = (CButton*)GetDlgItem(IDC_CHECK);
	if (pChk->GetCheck() == BST_CHECKED) {
		Mode = 1;	// high rate mode
		Ret = m_psapi->SetFastPlayMode(Mode);
		m_csLog.Format("[Function] SetFastPlayMode = High Rate Mode:%d", Ret);
		m_dlog.Logging(m_csLog);
	}
	else {
		Mode = 0;	// normal mode
		Ret = m_psapi->SetFastPlayMode(Mode);
		m_csLog.Format("[Function] SetFastPlayMode = Normal Mode:%d", Ret);
		m_dlog.Logging(m_csLog);
	}
}
