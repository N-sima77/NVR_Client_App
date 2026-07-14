// SimpleSample_LiveDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_LiveMulti.h"
#include "SimpleSample_LiveMultiDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_LiveDlg
//****************************************************************/
CSimpleSample_LiveMultiDlg::CSimpleSample_LiveMultiDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_LiveMultiDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_LiveMultiDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, m_bLiveStart);
	DDX_Control(pDX, IDC_BUTTON2, m_bLiveStop);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_LiveMultiDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_LiveMultiDlg::LiveStart)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_LiveMultiDlg::LiveStop)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_LiveMultiDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_LiveMultiDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_LiveMultiDlg::OnInitDialog()
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
	this->MoveWindow(0,0,660,350);
	m_bLiveStart.MoveWindow(10,260,100,50);
	m_bLiveStop.MoveWindow(120,260,100,50);

    CWnd* myPICT1=GetDlgItem(IDC_STATIC1);
    myPICT1->MoveWindow(0,0,320,240);

    CWnd* myPICT2=GetDlgItem(IDC_STATIC2);
    myPICT2->MoveWindow(330,0,320,240);

    m_dlog.Create(IDD_LOG,GetDesktopWindow()); 
    ::SetWindowPos(m_dlog,HWND_TOP,660,0,0,0,SWP_SHOWWINDOW | SWP_NOSIZE);

	m_pcallback.SetLogWndHandle(m_dlog.m_hWnd);		//Set message handle
	m_pcallback.SetProcHandle(this->m_hWnd);		//Set proc handle

    //-----------------------------------------------------
    //Create an instance
    //-----------------------------------------------------	
    m_psapi = NULL;
    m_psapi = GetIPSAPI();
    
    m_psapi2 = NULL;
    m_psapi2 = GetIPSAPI();

    //-----------------------------------------------------
    //Set properties for instance 1
    //-----------------------------------------------------
    //Set properties to connect the device
    m_psapi->SetIPAddr("192.168.0.250"); //IP address of the device
    m_psapi->SetDeviceType(1);          //Device type:0-3
    m_psapi->SetHttpPort(80);           //Port:0-65535
    m_psapi->SetUserName("ADMIN");      //User name to access the device
    m_psapi->SetPassword("12345");      //Password to access the device

    //Set properties for display area
    m_psapi->SetVideoWindow(myPICT1->m_hWnd);  //Set the window handle to display
    m_psapi->SetImageWidth(320);            //Image width
    m_psapi->SetImageHeight(240);           //Imgae Height

    //Set properties for image format
    m_psapi->SetStreamFormat(0);        //Image format - JPEG:0,MPEG4:1
    m_psapi->SetJPEGResolution(640);    //JPEG Resolution(It works in case of StreamFormat=0)
    m_psapi->SetMPEG4Resolution(640);   //MPEG-4 Resolution(It works in case of StreamFormat=1)
	m_psapi->SetH264Resolution(640);    //H.264 Resolution(It works in case of StreamFormat=3)

	//-----------------------------------------------------
	//Set Listener for instance 1
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
	m_csLog.Format("[Function 1] ClearImage");
	m_dlog.Logging(m_csLog);

    //-----------------------------------------------------
    //Set properties for instance 2
    //-----------------------------------------------------
    //Set properties to connect the device
    m_psapi2->SetIPAddr("192.168.0.250"); //IP address of the device
    m_psapi2->SetDeviceType(1);          //Device type:0-3
    m_psapi2->SetHttpPort(80);           //Port:0-65535
    m_psapi2->SetUserName("ADMIN");      //User name to access the device
    m_psapi2->SetPassword("12345");      //Password to access the device

    //Set properties for display area
    m_psapi2->SetVideoWindow(myPICT2->m_hWnd);  //Set the window handle to display
    m_psapi2->SetImageWidth(320);            //Image width
    m_psapi2->SetImageHeight(240);           //Imgae Height

    //Set properties for image format
    m_psapi2->SetStreamFormat(0);        //Image format - JPEG:0,MPEG4:1
    m_psapi2->SetJPEGResolution(640);    //JPEG Resolution(It works in case of StreamFormat=0)
    m_psapi2->SetMPEG4Resolution(640);   //MPEG-4 Resolution(It works in case of StreamFormat=1)
	m_psapi2->SetH264Resolution(640);    //H.264 Resolution(It works in case of StreamFormat=3)

	//-----------------------------------------------------
	//Set Listener for instance 2
	//-----------------------------------------------------
	m_psapi2->SetErrListener((IAppListener*)&m_pcallback);
	m_psapi2->SetDevListener(NULL);
	m_psapi2->SetRecListener(NULL);
	m_psapi2->SetPlayListener((IAppListener*)&m_pcallback);
	m_psapi2->SetImageListener(NULL,1);
	m_psapi2->SetRecordListener(NULL);
	m_psapi2->SetOpListener(NULL);
	m_psapi2->SetAlmListener(NULL);

	//Paint background color
	m_psapi2->ClearImage();
	m_csLog.Format("[Function 2] ClearImage");
	m_dlog.Logging(m_csLog);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_LiveMultiDlg::OnClose()
{
	//-----------------------------------------------------
    //Delete the instance
    //-----------------------------------------------------
    m_psapi->SetVideoWindow(NULL);  //Set the window handle to display
    m_psapi2->SetVideoWindow(NULL);  //Set the window handle to display

	//-----------------------------------------------------
	//Set Listener for instance 1
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
	//Set Listener for instance 2
	//-----------------------------------------------------
 	m_psapi2->SetErrListener(NULL);
	m_psapi2->SetDevListener(NULL);
	m_psapi2->SetRecListener(NULL);
	m_psapi2->SetPlayListener(NULL);
	m_psapi2->SetImageListener(NULL,1);
	m_psapi2->SetRecordListener(NULL);
	m_psapi2->SetOpListener(NULL);
	m_psapi2->SetAlmListener(NULL);

	//-----------------------------------------------------
    //Delete the instance
    //-----------------------------------------------------
    DeleteIPSAPI(m_psapi);
    m_psapi = NULL;
    
    DeleteIPSAPI(m_psapi2);
    m_psapi2 = NULL;
    
 	EndDialog( IDCANCEL );

//	CDialog::OnClose();
}

//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_LiveMultiDlg::OnDestroy()
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
void CSimpleSample_LiveMultiDlg::OnPaint()
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
void CSimpleSample_LiveMultiDlg::LiveStart()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lChannel	=	0;
    long	lChannel2	=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;
    long	lUid		=	-1;

    //-----------------------------------------------------
    //Connect to the device for instance 1
    //-----------------------------------------------------
    lRet = m_psapi->Open();
	m_csLog.Format("[Function 1] Open:%d",lRet);
	m_dlog.Logging(m_csLog);	

	if(lRet > -1){
	    lChannel    =   1;                      //Connect to 1ch
	    lBlocking   =   0;                      //0:Blocking mode
		lRet = m_psapi->PlayLive(lChannel,lStatus,lBlocking,&m_pcallback);
		m_csLog.Format("[Function 1] PlayLive:%d",lRet);
		m_dlog.Logging(m_csLog);

		if(lRet != 0){
			m_psapi->Close();
			m_csLog.Format("[Function 1] Close");
			m_dlog.Logging(m_csLog);
		}else{
		    //-----------------------------------------------------
		    //Connect to the device for instance 2
		    //-----------------------------------------------------
		    lRet = m_psapi2->Connect(m_psapi->GetUID());
			m_csLog.Format("[Function 2] Connect:%d (UID[%d])",lRet, m_psapi->GetUID());
			m_dlog.Logging(m_csLog);
			
			if(lRet > -1){
			    lChannel2   =   2;                      //Connect to 2ch
			    lBlocking   =   0;                      //0:Blocking mode
				lRet = m_psapi2->PlayLive(lChannel2,lStatus,lBlocking,&m_pcallback);
				m_csLog.Format("[Function 2] PlayLive:%d",lRet);
				m_dlog.Logging(m_csLog);

				if(lRet != 0){
					m_psapi2->Disconnect();
					m_csLog.Format("[Function 2] Disconnect");
					m_dlog.Logging(m_csLog);
				}
			}
			PlayStatus = PLAYSTART;
		}
	}
}

//****************************************************************
//* Function Name   : LiveStop
//****************************************************************/
void CSimpleSample_LiveMultiDlg::LiveStop()
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
	    //Set properties
	    //-----------------------------------------------------
		lCommand	=	1;
		lSpeed		=	1;
	    lBlocking	=	0;
		
	    //-----------------------------------------------------
	    //Stop Live
	    //-----------------------------------------------------
		lRet = m_psapi->PlayControl(lCommand,lSpeed,lStatus,lBlocking,&m_pcallback);
	    m_csLog.Format("[Function 1] PlayLive(Stop):%d",lRet);
	    m_dlog.Logging(m_csLog);

		lRet = m_psapi2->PlayControl(lCommand,lSpeed,lStatus,lBlocking,&m_pcallback);
	    m_csLog.Format("[Function 2] PlayLive(Stop):%d",lRet);
	    m_dlog.Logging(m_csLog);

	    //-----------------------------------------------------
	    //Close connection to the device
	    //-----------------------------------------------------
	    m_psapi2->Disconnect();
	    m_csLog.Format("[Function 2] Disconnect");
	    m_dlog.Logging(m_csLog);

	    m_psapi->Close();
	    m_csLog.Format("[Function 1] Close");
	    m_dlog.Logging(m_csLog);

	    m_psapi->ClearImage();
	    m_csLog.Format("[Function 1] ClearImage");
		m_dlog.Logging(m_csLog);
	    m_psapi2->ClearImage();
	    m_csLog.Format("[Function 2] ClearImage");
		m_dlog.Logging(m_csLog);

		//Change status
	    PlayStatus = PLAYSTOP;
	}else{
		m_csLog.Format("[Message] No live.");
		m_dlog.Logging(m_csLog);
    }
}


