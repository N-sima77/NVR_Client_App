// SimpleSample_LiveDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_Live.h"
#include "SimpleSample_LiveDlg.h"
#include "resource.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_LiveDlg
//****************************************************************/
CSimpleSample_LiveDlg::CSimpleSample_LiveDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_LiveDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_LiveDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bLiveStart);
	DDX_Control(pDX, IDC_BUTTON2, m_bLiveStop);
	DDX_Control(pDX, IDC_CHECK1, m_ckFitMode);
	//DDX_Control(pDX, IDC_VIDEO_RENDER, m_VideoWnd);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_LiveDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_LiveDlg::LiveStart)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_LiveDlg::LiveStop)
	ON_BN_CLICKED(IDC_CHECK1, &CSimpleSample_LiveDlg::OnBnClickedCheck1)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_LiveDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_LiveDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_LiveDlg::OnInitDialog()
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
	this->MoveWindow(0,0,640,600);
	m_bLiveStart.MoveWindow(10,500,100,50);
	m_bLiveStop.MoveWindow(120,500,100,50);
	m_ckFitMode.MoveWindow(230,500,200,30);

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
    m_psapi->SetIPAddr("192.168.11.114"); //IP address of the device
    m_psapi->SetDeviceType(2);          //Device type:0-3
    m_psapi->SetHttpPort(80);           //Port:0-65535
    m_psapi->SetUserName("admin");      //User name to access the device
    m_psapi->SetPassword("Admin123");      //Password tSo access the device

    //Set properties for display area
    //m_psapi->SetVideoWindow(this->m_hWnd);  //Set the window handle to display
	// Siyah kutuyu doğrudan arayüzdeki ID'sinden (IDC_VIDEO_RENDER) bul
	/*CWnd* pTuval = GetDlgItem(IDC_VIDEO_RENDER);

	// Eğer kutu gerçekten ekrandaysa, motorun hedefini orası yap
	if (pTuval != NULL) {
		m_psapi->SetVideoWindow(pTuval->GetSafeHwnd());
	}
	else{
		// Kutu bulunamazsa program bizi uyaracak
		AfxMessageBox(_T("DİKKAT: IDC_VIDEO_RENDER ID'li kutu arayüzde bulunamadı!"));
	}*/
	m_psapi->SetVideoWindow(this->GetSafeHwnd());
	m_psapi->SetImageWidth(640);            //Image width
    m_psapi->SetImageHeight(480);           //Imgae Height

    //Set properties for image format
    m_psapi->SetStreamFormat(0);        //Image format - JPEG:0,MPEG4:1
    m_psapi->SetJPEGResolution(1920);    //JPEG Resolution(It works in case of StreamFormat=0)
    m_psapi->SetMPEG4Resolution(1080);   //MPEG-4 Resolution(It works in case of StreamFormat=1)
    m_psapi->SetH264Resolution(1920);    //H.264 Resolution(It works in case of StreamFormat=3)
	
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

	if(m_psapi->GetPictureFitMode() == 0){
		//Fit mode (Fixed)
		m_ckFitMode.SetCheck(0);
	}
	else{
		//Fit mode (Fit)
		m_ckFitMode.SetCheck(1);
	}

	return TRUE;  // return TRUE  unless you set the focus to a control
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_LiveDlg::OnClose()
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
void CSimpleSample_LiveDlg::OnDestroy()
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
void CSimpleSample_LiveDlg::OnPaint()
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
void CSimpleSample_LiveDlg::LiveStart()
{
	// 1. GÜVENLİK KALKANI: Zaten açıksa tekrar basılıp çökmesini engelle
	if (PlayStatus == PLAYSTART) {
		return;
	}

	long lRet = 0;
	long lStatus = 0;
	long lBlocking = 0;
	long lNVRChannel = 1;  // NVR'da izlemek istediğiniz kamera (2. Kanal)

	// Video window güncelle
	CWnd* pTuval = GetDlgItem(IDC_VIDEO_RENDER);
	if (pTuval != NULL) {
		m_psapi->SetVideoWindow(pTuval->GetSafeHwnd());
	}

	// NVR'a bağlan
	lRet = m_psapi->Open();
	m_csLog.Format("[Function] Open:%d", lRet);
	m_dlog.Logging(m_csLog);

	if (lRet >= 0) {
		// DOĞRU KULLANIM: 4 Parametre. 
		// İlk parametreye direkt izlemek istediğiniz kanalı (lNVRChannel) verin.
		lRet = m_psapi->PlayLive(lNVRChannel, lStatus, lBlocking, NULL);

		m_csLog.Format("[Function] PlayLive(Start):%d", lRet);
		m_dlog.Logging(m_csLog);

		if (lRet == 0) {
			PlayStatus = PLAYSTART;
		}
		else {
			m_psapi->Close();
			m_csLog.Format("[Function] Close - hata");
			m_dlog.Logging(m_csLog);
		}
	}
}



//****************************************************************
//* Function Name   : LiveStop
//****************************************************************/
void CSimpleSample_LiveDlg::LiveStop()
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
//* Function Name   : SetPictureFitMode
//****************************************************************/
void CSimpleSample_LiveDlg::OnBnClickedCheck1()
{
	if(m_ckFitMode.GetCheck() == 0){
		//Fit mode (Fixed)
		m_psapi->SetPictureFitMode(0);
		m_csLog.Format("[Function] SetPictureFitMode (Fixed)");
		m_dlog.Logging(m_csLog);
	}
	else{
		//Fit mode (Fit)
		m_psapi->SetPictureFitMode(1);
		m_csLog.Format("[Function] SetPictureFitMode (Fit)");
		m_dlog.Logging(m_csLog);
	}
}
