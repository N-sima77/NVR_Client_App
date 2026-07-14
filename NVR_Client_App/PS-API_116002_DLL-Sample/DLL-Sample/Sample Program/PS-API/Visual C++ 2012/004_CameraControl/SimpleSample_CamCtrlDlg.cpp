// SimpleSample_CamCtrlDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_CamCtrl.h"
#include "SimpleSample_CamCtrlDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_CamCtrlDlg::CSimpleSample_CamCtrlDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_CamCtrlDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_CamCtrlDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bLeft);
	DDX_Control(pDX, IDC_BUTTON2, m_bRight);
	DDX_Control(pDX, IDC_BUTTON3, m_bUp);
	DDX_Control(pDX, IDC_BUTTON4, m_bDown);
	DDX_Control(pDX, IDC_BUTTON5, m_bTele);
	DDX_Control(pDX, IDC_BUTTON6, m_bWide);
	DDX_Control(pDX, IDC_BUTTON7, m_bOpen);
	DDX_Control(pDX, IDC_BUTTON8, m_bClose);
	DDX_Control(pDX, IDC_BUTTON9, m_bStop);
	DDX_Control(pDX, IDC_EDIT1, m_ePanTilt);
	DDX_Control(pDX, IDC_EDIT2, m_eZoom);
	DDX_Control(pDX, IDC_EDIT3, m_eIris);
	DDX_Control(pDX, IDC_CHECK1, m_ckCenterMode);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_CamCtrlDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_CamCtrlDlg::PanTilt_Left)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_CamCtrlDlg::PanTilt_Right)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_CamCtrlDlg::PanTilt_Up)
	ON_BN_CLICKED(IDC_BUTTON4, &CSimpleSample_CamCtrlDlg::PanTilt_Down)
	ON_BN_CLICKED(IDC_BUTTON5, &CSimpleSample_CamCtrlDlg::Zoom_Tele)
	ON_BN_CLICKED(IDC_BUTTON6, &CSimpleSample_CamCtrlDlg::Zoom_Wide)
	ON_BN_CLICKED(IDC_BUTTON7, &CSimpleSample_CamCtrlDlg::Iris_Open)
	ON_BN_CLICKED(IDC_BUTTON8, &CSimpleSample_CamCtrlDlg::Iris_Close)
	ON_BN_CLICKED(IDC_BUTTON9, &CSimpleSample_CamCtrlDlg::OnStop)
	ON_WM_LBUTTONDOWN()
	ON_WM_MBUTTONDOWN()
	ON_WM_RBUTTONDOWN()
	ON_WM_LBUTTONUP()
	ON_WM_MBUTTONUP()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_CamCtrlDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_CamCtrlDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_CamCtrlDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	//-----------------------------------------------------
    //Initialize members
	//-----------------------------------------------------		
	PlayStatus = PLAYSTOP;
	m_csLog.Empty();

	//-----------------------------------------------------
    //Initialize the control position
	//-----------------------------------------------------
	this->MoveWindow(0,0,640,730);
	m_bLeft.MoveWindow(10,580,70,50);
	m_bRight.MoveWindow(150,580,70,50);
	m_bUp.MoveWindow(80,530,70,50);
	m_bDown.MoveWindow(80,630,70,50);
	m_bTele.MoveWindow(350,530,70,50);
	m_bWide.MoveWindow(490,530,70,50);
	m_bOpen.MoveWindow(350,630,70,50);
	m_bClose.MoveWindow(490,630,70,50);
	m_bStop.MoveWindow(250,580,70,50);

	m_ePanTilt.MoveWindow(80,600,70,30);
	m_eZoom.MoveWindow(420,550,70,30);
	m_eIris.MoveWindow(420,650,70,30);

	m_ckCenterMode.MoveWindow(10,500,200,20);

	//-----------------------------------------------------
	//Set control label
	//-----------------------------------------------------
	m_bLeft.SetWindowText("Left");
	m_bRight.SetWindowText("Right");
	m_bUp.SetWindowText("Up");
	m_bDown.SetWindowText("Down");
	m_bTele.SetWindowText("Tele");
	m_bWide.SetWindowText("Wide");
	m_bOpen.SetWindowText("Open");
	m_bClose.SetWindowText("Close");
	m_bStop.SetWindowText("Stop");

	m_ePanTilt.SetWindowText("Pan/Tilt");
	m_eZoom.SetWindowText("Zoom");
	m_eIris.SetWindowText("Iris");

	m_ckCenterMode.SetWindowText("Click Centering Mode");

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
	m_psapi->SetIPAddr("192.168.0.10");	//IP address of the device
	m_psapi->SetDeviceType(2);			//Device type:0-3
	m_psapi->SetHttpPort(80);			//Port:0-65535
	m_psapi->SetUserName("admin");		//User name to access the device
	m_psapi->SetPassword("12345");		//Password to access the device
	
    //Set properties for display area
	m_psapi->SetVideoWindow(this->m_hWnd);	//Set the window handle to display
	m_psapi->SetImageWidth(640);			//Image width
	m_psapi->SetImageHeight(480);			//Imgae Height

    //Set properties for image format
	m_psapi->SetStreamFormat(1);			//Image format - JPEG:0,MPEG4:1
	m_psapi->SetJPEGResolution(640);		//JPEG Resolution(It works in case of StreamFormat=0)
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
void CSimpleSample_CamCtrlDlg::OnClose()
{
	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Define variables
		//-----------------------------------------------------
		long	lRet		=	0;
		long	lChannel	=	0;
		long	lpan		=	0;
		long	ltilt		=	0;
		long	lzoom		=	0;
		long	lfocus		=	0;
		long	liris		=	0;	 
		long	lSpeed		=	0;
		long	lStatus		=	0;
		long	lBlocking	=	0;
		long	lCommand	=	0;

		//-----------------------------------------------------
		//Stop to control camera
		//-----------------------------------------------------
		lpan	=	0;
		ltilt	=	0;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Stop):%d",lRet);
		m_dlog.Logging(m_csLog);

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
void CSimpleSample_CamCtrlDlg::OnDestroy()
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
void CSimpleSample_CamCtrlDlg::OnPaint()
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
//* Function Name   : PanTilt_Left
//****************************************************************/
void CSimpleSample_CamCtrlDlg::PanTilt_Left()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	-128;
		ltilt	=	0;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Left):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : PanTilt_Right
//****************************************************************/
void CSimpleSample_CamCtrlDlg::PanTilt_Right()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	128;
		ltilt	=	0;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Rifht):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : PanTilt_Up
//****************************************************************/
void CSimpleSample_CamCtrlDlg::PanTilt_Up()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	-128;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Up):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : PanTilt_Down
//****************************************************************/
void CSimpleSample_CamCtrlDlg::PanTilt_Down()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	128;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Down):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Zoom_Tele
//****************************************************************/
void CSimpleSample_CamCtrlDlg::Zoom_Tele()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	0;
		lzoom	=	1;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Zoom_Tele):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Zoom_Wide
//****************************************************************/
void CSimpleSample_CamCtrlDlg::Zoom_Wide()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	0;
		lzoom	=	-1;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Zoom_Wide):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Iris_Open
//****************************************************************/
void CSimpleSample_CamCtrlDlg::Iris_Open()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	0;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	1;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Iris_Open):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : Iris_Close
//****************************************************************/
void CSimpleSample_CamCtrlDlg::Iris_Close()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	0;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	2;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Iris_Close):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : OnStop
//****************************************************************/
void CSimpleSample_CamCtrlDlg::OnStop()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long	lRet		=	0;
	long	lChannel	=	0;
	long	lpan		=	0;
	long	ltilt		=	0;
	long	lzoom		=	0;
	long	lfocus		=	0;
	long	liris		=	0;	

	if(PlayStatus == PLAYSTART){
		//-----------------------------------------------------
		//Control the camera
		//-----------------------------------------------------
		lChannel = 1;
		lpan	=	0;
		ltilt	=	0;
		lzoom	=	0;
		lfocus	=	0;
		liris	=	0;
		lRet = m_psapi->CameraControl(lChannel,lpan,ltilt,lzoom,lfocus,liris);
		m_csLog.Format("[Function] CameraControl(Stop):%d",lRet);
		m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : MouseDown
//****************************************************************/
void CSimpleSample_CamCtrlDlg::MouseDown(long x, long y)
{
 	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
    long lRet			=	0;
    long lChannel		=	0;
    long lControlSizeX	=	0;
    long lControlSizeY	=	0;

	if (m_ckCenterMode.GetCheck()){
		if(PlayStatus == PLAYSTART){
			//-----------------------------------------------------
			//Camera centering
			//-----------------------------------------------------
			lChannel = 1;
			lControlSizeX = m_psapi->GetImageWidth();
			lControlSizeY = m_psapi->GetImageHeight();
			lRet = m_psapi->CameraCentering(lChannel, x, y, lControlSizeX, lControlSizeY);
			m_csLog.Format("[Function] Click centering:%d (Position X[%d] Y[%d])", lRet, x, y);
			m_dlog.Logging(m_csLog);
		}else{
			m_csLog.Format("[Message] No live.");
			m_dlog.Logging(m_csLog);
		}
	}
}

//****************************************************************
//* Function Name   : MouseUp
//****************************************************************/
void CSimpleSample_CamCtrlDlg::MouseUp(long x, long y)
{
	return;
}

//****************************************************************
//* Function Name   : Receive Mouse down Event
//****************************************************************/
void CSimpleSample_CamCtrlDlg::OnLButtonDown(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseDown(lx, ly);

	CDialog::OnLButtonDown(nFlags, point);
}

void CSimpleSample_CamCtrlDlg::OnMButtonDown(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseDown(lx, ly);

	CDialog::OnMButtonDown(nFlags, point);
}

void CSimpleSample_CamCtrlDlg::OnRButtonDown(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseDown(lx, ly);

	CDialog::OnRButtonDown(nFlags, point);
}

//****************************************************************
//* Function Name   : Receive Mouse up Event
//****************************************************************/
void CSimpleSample_CamCtrlDlg::OnLButtonUp(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseUp(lx, ly);

	CDialog::OnLButtonUp(nFlags, point);
}

void CSimpleSample_CamCtrlDlg::OnMButtonUp(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseUp(lx, ly);

	CDialog::OnMButtonUp(nFlags, point);
}

void CSimpleSample_CamCtrlDlg::OnRButtonUp(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseUp(lx, ly);

	CDialog::OnRButtonUp(nFlags, point);
}
