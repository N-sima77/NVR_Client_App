// CSimpleSample_SnapShotDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_SnapShot.h"
#include "SimpleSample_SnapShotDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_SnapShotDlg::CSimpleSample_SnapShotDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_SnapShotDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_SnapShotDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bJpegSnap);
	DDX_Control(pDX, IDC_BUTTON2, m_bDZoom1);
	DDX_Control(pDX, IDC_BUTTON3, m_bDZoom4);
	DDX_Control(pDX, IDC_BUTTON4, m_bDZoomLeft);
	DDX_Control(pDX, IDC_BUTTON5, m_bDZoomRight);
	DDX_Control(pDX, IDC_EDIT1, m_eFileName);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_SnapShotDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_SnapShotDlg::JpegSnapShot)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_SnapShotDlg::DZoom1)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_SnapShotDlg::DZoom4)
	ON_BN_CLICKED(IDC_BUTTON4, &CSimpleSample_SnapShotDlg::DZoomLeft)
	ON_BN_CLICKED(IDC_BUTTON5, &CSimpleSample_SnapShotDlg::DZoomRight)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_SnapShotDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_SnapShotDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_SnapShotDlg::OnInitDialog()
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
	this->MoveWindow(0,0,640,620);
    m_bJpegSnap.MoveWindow(470,500,120,30);
    m_bDZoom1.MoveWindow(10,550,120,30);
    m_bDZoom4.MoveWindow(150,550,120,30);
	m_bDZoomLeft.MoveWindow(320,550,120,30);
    m_bDZoomRight.MoveWindow(470,550,120,30);

	CWnd* myPICT=GetDlgItem(IDC_STATIC);
    myPICT->MoveWindow(10,500,100,30);
	m_eFileName.MoveWindow(110,500,300,30);

 	//-----------------------------------------------------
	//Set control label
	//-----------------------------------------------------
    m_bJpegSnap.SetWindowText("Jpeg Snap Shot");
    m_bDZoom1.SetWindowText("Digital Zoom (x1)");
    m_bDZoom4.SetWindowText("Digital Zoom (x4)");
	m_bDZoomLeft.SetWindowText("Move to Left");
    m_bDZoomRight.SetWindowText("Move to Right");

	myPICT->SetWindowText("Save File Name :");
    m_eFileName.SetWindowText("C:\\JpegSnapShot.jpg");

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
    m_cpPicture = GetIPSAPIPicture();

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
void CSimpleSample_SnapShotDlg::OnClose()
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
    DeleteIPSAPIPicture(m_cpPicture);
	m_cpPicture = NULL;

	DeleteIPSAPI(m_psapi);
	m_psapi = NULL;

	EndDialog( IDCANCEL );

//	CDialog::OnClose();
}

//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_SnapShotDlg::OnDestroy()
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
void CSimpleSample_SnapShotDlg::OnPaint()
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
//* Function Name   : JpegSnapShot
//****************************************************************/
void CSimpleSample_SnapShotDlg::JpegSnapShot()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
	char csFileName[256];
	memset(csFileName ,0,256);


	if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //Jpeg SnapShot
	    //-----------------------------------------------------
		lRet = m_psapi->SnapShot(m_cpPicture);
	    m_csLog.Format("[Function] SnapShot:%d",lRet);
	    m_dlog.Logging(m_csLog);

		if ( lRet == 0 ){
			UpdateData(TRUE);
			m_eFileName.GetWindowTextA(csFileName, 256); //FileName(Full path)
			lRet = m_cpPicture->SaveJpegImage(csFileName);
			m_csLog.Format("[Function] SaveJpegImage:%d",lRet);
			m_dlog.Logging(m_csLog);
		}
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : DZoom1
//****************************************************************/
void CSimpleSample_SnapShotDlg::DZoom1()
{
    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //Digital zoom (x1)
	    //-----------------------------------------------------
		m_psapi->SetDigitalZoom(10);
	    m_csLog.Format("[Function] DigitalZoom (x1)");
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : DZoom4
//****************************************************************/
void CSimpleSample_SnapShotDlg::DZoom4()
{
    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //Digital zoom (x4)
	    //-----------------------------------------------------
		m_psapi->SetDigitalZoom(40);
	    m_csLog.Format("[Function] DigitalZoom (x4)");
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : DZoomLeft
//****************************************************************/
void CSimpleSample_SnapShotDlg::DZoomLeft()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lXposition	=	0;
	long	lYposition	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //Digital zoom move to left
	    //-----------------------------------------------------
		lXposition = -320;
		lYposition = 0;
		lRet = m_psapi->DigitalZoomMove(lXposition, lYposition);
	    m_csLog.Format("[Function] DigitalZoomMove(Left):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : DZoomRight
//****************************************************************/
void CSimpleSample_SnapShotDlg::DZoomRight()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lXposition	=	0;
	long	lYposition	=	0;

    if(PlayStatus == PLAYSTART){
	    //-----------------------------------------------------
	    //Digital zoom move to right
	    //-----------------------------------------------------
		lXposition = 320;
		lYposition = 0;
		lRet = m_psapi->DigitalZoomMove(lXposition, lYposition);
	    m_csLog.Format("[Function] DigitalZoomMove(Right):%d",lRet);
	    m_dlog.Logging(m_csLog);
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}
