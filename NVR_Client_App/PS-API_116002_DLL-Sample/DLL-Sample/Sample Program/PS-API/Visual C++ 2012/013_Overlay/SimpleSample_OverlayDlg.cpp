// CSimpleSample_OverlayDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_Overlay.h"
#include "SimpleSample_OverlayDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_OverlayDlg::CSimpleSample_OverlayDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_OverlayDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_OverlayDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_CHECK2, m_ckTitle);
	DDX_Control(pDX, IDC_CHECK3, m_ckBox);
	DDX_Control(pDX, IDC_CHECK4, m_ckBMPDraw);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_OverlayDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_CHECK2, &CSimpleSample_OverlayDlg::OnDrawTitle)
	ON_BN_CLICKED(IDC_CHECK3, &CSimpleSample_OverlayDlg::OnDrawBox)
	ON_BN_CLICKED(IDC_CHECK4, &CSimpleSample_OverlayDlg::OnBMPDraw)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_OverlayDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_OverlayDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_OverlayDlg::OnInitDialog()
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
    //Initialize the control position	Modefied Ver5.0.1.0
    //-----------------------------------------------------
	this->MoveWindow(0,0,640,660);
    m_ckTitle.MoveWindow(10,530,120,20);
    m_ckBox.MoveWindow(10,560,120,20);
	m_ckBMPDraw.MoveWindow(10,590,130,20);
	GetDlgItem(IDC_EDIT)->MoveWindow(160,590,450,20);
	::DragAcceptFiles(GetDlgItem(IDC_EDIT)->m_hWnd, TRUE);

 	//-----------------------------------------------------
	//Set control label					Modefied Ver5.0.1.0
	//-----------------------------------------------------
    m_ckTitle.SetWindowText("Draw Title");
    m_ckBox.SetWindowText("Draw Box");
	m_ckBMPDraw.SetWindowText("Image Tranmission");
	GetDlgItem(IDC_EDIT)->SetWindowText("C:\\temp\\test.bmp");


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
void CSimpleSample_OverlayDlg::OnClose()
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
void CSimpleSample_OverlayDlg::OnDestroy()
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
void CSimpleSample_OverlayDlg::OnPaint()
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
//* Function Name   : DrawTitle						Modefied Ver5.0.1.0
//****************************************************************/
void CSimpleSample_OverlayDlg::OnDrawTitle()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet			=	0;
    long	lId				=	0;
    long	lCommand		=	0;
    char	cText[256];
    long	lxPosition		=	0;
    long	lyPosition		=	0;
    long	lAlign			=	0;
    char	cFont[256];
    long	lFontSize		=	0;
    long	lForeColor		=	0;
    long	lBorderColor	=	0;
    long	lStyle			=	0;
	long	lTransmit		=	0;

	memset(cText, 0, 256);
	wsprintf(cText, "PS-API ActiveX");

	memset(cFont, 0, 256);
    wsprintf(cFont, "MS UI Gothic");

    lxPosition = 100;
    lyPosition = 100;
    lAlign = 0;
    lFontSize = 24;
    lForeColor = 0;
    lBorderColor = 16777215;
    lStyle = 2;
	lTransmit = 0x7F;

	if(m_ckTitle.GetCheck() != 0){
		//-----------------------------------------------------
		//Display Title
		//-----------------------------------------------------
        lId = 1;
        lCommand = 1;
		lRet = m_psapi->TitleOperationEx(lId, lCommand, cText, lxPosition, lyPosition, lAlign, cFont, lFontSize, lForeColor, lBorderColor, lStyle, lTransmit);
        m_csLog.Format("[Function] TitleOperationEx (ON):%d", lRet );
	    m_dlog.Logging(m_csLog);
	}else{
		//-----------------------------------------------------
		//Display Title
		//-----------------------------------------------------
        lId = 1;
        lCommand = 0;
		lRet = m_psapi->TitleOperationEx(lId, lCommand, cText, lxPosition, lyPosition, lAlign, cFont, lFontSize, lForeColor, lBorderColor, lStyle, lTransmit);
        m_csLog.Format("[Function] TitleOperationEx (OFF):%d", lRet );
	    m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name   : DrawBox						Modefied Ver5.0.1.0
//****************************************************************/
void CSimpleSample_OverlayDlg::OnDrawBox()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet			=	0;
    long	lId 			=	0;
    long	lCommand 		=	0;
    long	lColor			=	0;
    long	lSize			=	0;
    long	lxTopLeft		=	0;
    long	lyTopLeft		=	0;
    long	lxBottomRight	=	0;
    long	lyBottomRight	=	0;
	long	lTransmit		=	0;

    lColor = 255;
    lSize = 3;
    lxTopLeft = 200;
    lyTopLeft = 200;
    lxBottomRight = 300;
    lyBottomRight = 300;
	lTransmit = 0x7F;

	if(m_ckBox.GetCheck() != 0){
		//-----------------------------------------------------
		//Display Box
		//-----------------------------------------------------
        lId = 1;
        lCommand = 2;
        lRet = m_psapi->BoxOperationEx(lId, lCommand, lColor, lSize, lxTopLeft, lyTopLeft, lxBottomRight, lyBottomRight, lTransmit);
        m_csLog.Format("[Function] BoxOperationEx (ON):%d", lRet );
	    m_dlog.Logging(m_csLog);
	}else{
		//-----------------------------------------------------
		//Display Box
		//-----------------------------------------------------
        lId = 1;
        lCommand = 0;
        lRet = m_psapi->BoxOperationEx(lId, lCommand, lColor, lSize, lxTopLeft, lyTopLeft, lxBottomRight, lyBottomRight, lTransmit);
        m_csLog.Format("[Function] BoxOperationEx (OFF):%d", lRet );
	    m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name   : Transparent bitmap			Added Ver 5.0.1.0
//****************************************************************
void CSimpleSample_OverlayDlg::OnBMPDraw()
{
    long Ret, Id, Command, XPos, YPos, MaskColor, Transmit;
    CString FileName;

	Id = 1;				// ID for management
	XPos = 320;			// X position of displayed transparent
	YPos = 240;			// Y position of displayed transparent
	if(m_ckBMPDraw.GetCheck() == BST_CHECKED) {
		// Transparent bitmap
		GetDlgItem(IDC_EDIT)->GetWindowText(FileName);
		Command = 1;			// Bitmap display
		MaskColor = 0xFF00FF;	// Bitmap's masked color
		Transmit = 0x7F;		// Transmittance
		Ret = m_psapi->BitmapOperationEx(Id, Command, (LPSTR)(LPCTSTR)FileName, XPos, YPos, MaskColor, Transmit);
        m_csLog.Format("[Function] BitmapOperationEx (ON,%s):%d", FileName, Ret);
	    m_dlog.Logging(m_csLog);
	}
	else {
		// Not transparent bitmap
        Command = 0;            // Bitmap non display
        MaskColor = -1;			// Bitmap's masked color
        Transmit = 0x7F;		// Transmittance
		Ret = m_psapi->BitmapOperationEx(Id, Command, NULL, 0, 0, MaskColor, Transmit);
        m_csLog.Format("[Function] BitmapOperationEx (ON,%s):%d", FileName, Ret);
	    m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name        : PreTranslateMessage		Added Ver 5.0.1.0
//****************************************************************
BOOL CSimpleSample_OverlayDlg::PreTranslateMessage(MSG* pMsg)
{
	if (pMsg->message == WM_DROPFILES) {		// The Drag & Drop support for file
		TCHAR FileName[MAX_PATH+1]; memset(FileName, NULL, sizeof(FileName));
		DragQueryFile((HDROP)pMsg->wParam, 0, FileName, MAX_PATH);
		if (pMsg->hwnd == GetDlgItem(IDC_EDIT)->m_hWnd) {
			GetDlgItem(IDC_EDIT)->SetWindowText(CString(FileName));
		}
		DragFinish((HDROP)pMsg->wParam);
	}
	return CDialog::PreTranslateMessage(pMsg);
}
