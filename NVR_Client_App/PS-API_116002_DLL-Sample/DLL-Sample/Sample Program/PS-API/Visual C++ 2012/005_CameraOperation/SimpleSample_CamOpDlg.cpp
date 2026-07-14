// CSimpleSample_CamOpDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_CamOp.h"
#include "SimpleSample_CamOpDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_CamOpDlg::CSimpleSample_CamOpDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_CamOpDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_CamOpDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bGetCamPos);
	DDX_Control(pDX, IDC_BUTTON2, m_bSetCamPos);
	DDX_Control(pDX, IDC_BUTTON3, m_bSetCamPos2);
	DDX_Control(pDX, IDC_BUTTON4, m_bNoOpe);
	DDX_Control(pDX, IDC_BUTTON5, m_bAutoT);
	DDX_Control(pDX, IDC_BUTTON6, m_bAutoP);
	DDX_Control(pDX, IDC_BUTTON7, m_bAutoF);
	DDX_Control(pDX, IDC_BUTTON8, m_bSetPreset);
	DDX_Control(pDX, IDC_BUTTON9, m_bCallPreset);
	DDX_Control(pDX, IDC_BUTTON10, m_bDeletePreset);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_CamOpDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_CamOpDlg::GetCameraPosition)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_CamOpDlg::SetCameraPosition)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_CamOpDlg::SetCameraPosition2)
	ON_BN_CLICKED(IDC_BUTTON4, &CSimpleSample_CamOpDlg::OnNoOpe)
	ON_BN_CLICKED(IDC_BUTTON5, &CSimpleSample_CamOpDlg::OnAutoT)
	ON_BN_CLICKED(IDC_BUTTON6, &CSimpleSample_CamOpDlg::OnAutoP)
	ON_BN_CLICKED(IDC_BUTTON7, &CSimpleSample_CamOpDlg::OnAutoF)
	ON_BN_CLICKED(IDC_BUTTON8, &CSimpleSample_CamOpDlg::SetPreset)
	ON_BN_CLICKED(IDC_BUTTON9, &CSimpleSample_CamOpDlg::CallPreset)
	ON_BN_CLICKED(IDC_BUTTON10, &CSimpleSample_CamOpDlg::DeletePreset)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_CamOpDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_CamOpDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_CamOpDlg::OnInitDialog()
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
	this->MoveWindow(0,0,640,700);
    m_bGetCamPos.MoveWindow(10,500,120,30);
    m_bSetCamPos.MoveWindow(170,500,120,30);
    m_bSetCamPos2.MoveWindow(300,500,120,30);

	m_bNoOpe.MoveWindow(10,570,120,30);
    m_bAutoT.MoveWindow(170,570,120,30);
    m_bAutoP.MoveWindow(300,570,120,30);
    m_bAutoF.MoveWindow(430,570,120,30);

	m_bSetPreset.MoveWindow(170,620,120,30);
	m_bCallPreset.MoveWindow(300,620,120,30);
	m_bDeletePreset.MoveWindow(430,620,120,30);

 	//-----------------------------------------------------
	//Set control label
	//-----------------------------------------------------
    m_bGetCamPos.SetWindowText("GetCameraPosition");
    m_bSetCamPos.SetWindowText("SetCameraPosition 1");
    m_bSetCamPos2.SetWindowText("SetCameraPosition 2");

	m_bNoOpe.SetWindowText("NonOperation");
    m_bAutoT.SetWindowText("AutoTrack");
    m_bAutoP.SetWindowText("AutoPan");
    m_bAutoF.SetWindowText("AutoFocus");

	m_bSetPreset.SetWindowText("Set Preset");
	m_bCallPreset.SetWindowText("Call Preset");
	m_bDeletePreset.SetWindowText("Delete Preset");

	//-----------------------------------------------------
	//Create log window
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
    m_psapi->SetIPAddr("192.168.0.10"); //IP address of the device
    m_psapi->SetDeviceType(2);           //Device type:0-3
    m_psapi->SetHttpPort(80);            //Port:0-65535
    m_psapi->SetUserName("admin");       //User name to access the device
    m_psapi->SetPassword("12345");       //Password to access the device

    //Set properties for display area
    m_psapi->SetVideoWindow(this->m_hWnd);  //Set the window handle to display
    m_psapi->SetImageWidth(640);            //Image width
    m_psapi->SetImageHeight(480);           //Imgae Height

    //Set properties for image format
    m_psapi->SetStreamFormat(1);        //Image format - JPEG:0,MPEG4:1
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
	m_psapi->SetOpListener((IAppListener*)&m_pcallback);
	m_psapi->SetAlmListener(NULL);

	//Paint background color
	m_psapi->ClearImage();
	m_csLog.Format("[Function] ClearImage");
	m_dlog.Logging(m_csLog);

    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lStatus		=	0;
    long	lChannel	=	0;
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
		//Start Live
		//-----------------------------------------------------
		lChannel	=	1;							//Connect to 1ch
		lBlocking	=	0;							//0:Blocking
		lRet = m_psapi->PlayLive(lChannel,lStatus,lBlocking,NULL);
		m_csLog.Format("[Function] PlayLive(Start):%d",lRet);
		m_dlog.Logging(m_csLog);	

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

	return TRUE;  // return TRUE  unless you set the focus to a control
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_CamOpDlg::OnClose()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long    lRet        =   0;
	long	lSpeed		=	0;
    long    lStatus     =   0;
    long    lBlocking   =   0;
	long	lCommand	=	0;

    if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Stop Live
		//-----------------------------------------------------
		//Setting
		lCommand	=	0;
		lSpeed		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand,lSpeed,lStatus,lBlocking,NULL);
		m_csLog.Format("[Function] PlayLive(Stop):%d",lRet);
		m_dlog.Logging(m_csLog);
		
		//-----------------------------------------------------
		//Disconnect to the device and change the play status
		//-----------------------------------------------------
		m_psapi->Close();
		m_csLog.Format("[Function] Close");
		m_dlog.Logging(m_csLog);

		m_psapi->ClearImage();
		m_csLog.Format("[Function] ClearImage");
		m_dlog.Logging(m_csLog);
	}

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
void CSimpleSample_CamOpDlg::OnDestroy()
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
void CSimpleSample_CamOpDlg::OnPaint()
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
//* Function Name   : GetCameraPosition
//****************************************************************/
void CSimpleSample_CamOpDlg::GetCameraPosition()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lPan		=	0;
	long	lTilt		=	0;
	long	lZoom		=	0;
	long	lFocus		=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //GetCameraPosition
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
		lRet = m_psapi->GetCameraPosition(lChannel,lPan,lTilt,lZoom,lFocus);
	    m_csLog.Format("[Function] GetCameraPosition:%d Pan[%d] Tilt[%d] Zoom[%d] Focus[%d]",lRet,lPan,lTilt,lZoom,lFocus);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : SetCameraPosition
//****************************************************************/
void CSimpleSample_CamOpDlg::SetCameraPosition()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lPan		=	0;
	long	lTilt		=	0;
	long	lZoom		=	0;
	long	lFocus		=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //SetCameraPosition
	    //-----------------------------------------------------
	    lChannel    =   1;                  //1ch
		lPan		=	0;					//0 - 3600 : Pan position
		lTilt		=	0;					//-300 - 900 : Tilt position
		lZoom		=	10;					//10 - 300 : Zoom position
		lFocus		=	14;					//14 - 9999 : Focus position
		lRet = m_psapi->SetCameraPosition(lChannel,lPan,lTilt,lZoom,lFocus);
	    m_csLog.Format("[Function] SetCameraPosition 1:%d",lRet);
	    m_dlog.Logging(m_csLog);	
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : SetCameraPosition2
//****************************************************************/
void CSimpleSample_CamOpDlg::SetCameraPosition2()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lPan		=	0;
	long	lTilt		=	0;
	long	lZoom		=	0;
	long	lFocus		=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //SetCameraPosition
	    //-----------------------------------------------------
	    lChannel    =   1;                  //1ch
		lPan		=	360;				//0 - 3600 : Pan position
		lTilt		=	360;				//-300 - 900 : Tilt position
		lZoom		=	30;					//10 - 300 : Zoom position
		lFocus		=	300;				//14 - 9999 : Focus position
		lRet = m_psapi->SetCameraPosition(lChannel,lPan,lTilt,lZoom,lFocus);
	    m_csLog.Format("[Function] SetCameraPosition 2:%d",lRet);
	    m_dlog.Logging(m_csLog);	
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : OnNoOpe
//****************************************************************/
void CSimpleSample_CamOpDlg::OnNoOpe()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   0;                      //0:No operation
	    ldata       =   0;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (No operation):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : OnAutoT
//****************************************************************/
void CSimpleSample_CamOpDlg::OnAutoT()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   1;                      //0:No operation
	    ldata       =   0;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (AutoTrack):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : OnAutoP
//****************************************************************/
void CSimpleSample_CamOpDlg::OnAutoP()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   2;                      //0:No operation
	    ldata       =   0;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (AutoPan):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : OnAutoF
//****************************************************************/
void CSimpleSample_CamOpDlg::OnAutoF()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   3;                      //0:No operation
	    ldata       =   0;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (AutoFocus):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : SetPreset
//****************************************************************/
void CSimpleSample_CamOpDlg::SetPreset()
{

	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   4;                      //0:No operation
	    ldata       =   1;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (Set Preset):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : CallPreset
//****************************************************************/
void CSimpleSample_CamOpDlg::CallPreset()
{

	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   5;                      //0:No operation
	    ldata       =   1;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (Call Preset):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : DeletePreset
//****************************************************************/
void CSimpleSample_CamOpDlg::DeletePreset()
{

	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
	long	lCommand	=	0;
	long	ldata		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //CameraOperation
	    //-----------------------------------------------------
	    lChannel    =   1;                      //1ch
	    lCommand    =   6;                      //0:No operation
	    ldata       =   1;                      //0 fixation
	    lBlocking	=	0;	//0:Blocking
		lRet = m_psapi->CameraOperation(lChannel,	lCommand,	ldata,	lStatus,	lBlocking,	&m_pcallback);
	    m_csLog.Format("[Function] Camera Operatopm (Delete Preset):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}
