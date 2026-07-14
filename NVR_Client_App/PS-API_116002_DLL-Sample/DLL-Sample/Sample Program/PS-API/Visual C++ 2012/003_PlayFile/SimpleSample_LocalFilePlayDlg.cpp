
#include "stdafx.h"
#include "SimpleSample_LocalFilePlay.h"
#include "SimpleSample_LocalFilePlayDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif



//****************************************************************
//* Function Name   : CSimpleSample_LocalFilePlayDlg
//****************************************************************/
CSimpleSample_LocalFilePlayDlg::CSimpleSample_LocalFilePlayDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_LocalFilePlayDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_LocalFilePlayDlg::DoDataExchange(CDataExchange* pDX)
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
	DDX_Control(pDX, IDC_EDIT1, m_eFileName);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_LocalFilePlayDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_LocalFilePlayDlg::OnPrevFrame)
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_LocalFilePlayDlg::OnRewind)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_LocalFilePlayDlg::OnReverse)
	ON_BN_CLICKED(IDC_BUTTON4, &CSimpleSample_LocalFilePlayDlg::OnPause)
	ON_BN_CLICKED(IDC_BUTTON5, &CSimpleSample_LocalFilePlayDlg::OnPlayBack)
	ON_BN_CLICKED(IDC_BUTTON6, &CSimpleSample_LocalFilePlayDlg::OnFF)
	ON_BN_CLICKED(IDC_BUTTON7, &CSimpleSample_LocalFilePlayDlg::OnNextFrame)
	ON_BN_CLICKED(IDC_BUTTON8, &CSimpleSample_LocalFilePlayDlg::OnStop)
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_LocalFilePlayDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_LocalFilePlayDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_LocalFilePlayDlg::OnInitDialog()
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
	this->MoveWindow(0,0,640,640);
	m_bRewind.MoveWindow(5,500,100,30);
	m_bReverse.MoveWindow(110,500,100,30);
	m_bStop.MoveWindow(215,500,100,30);
	m_bPause.MoveWindow(320,500,100,30);
	m_bPlayBack.MoveWindow(425,500,100,30);
	m_bFF.MoveWindow(530,500,100,30);

	m_bPrevFrame.MoveWindow(110,530,100,30);
	m_bNextFrame.MoveWindow(425,530,100,30);

	CWnd* myPICT=GetDlgItem(IDC_STATIC);
    myPICT->MoveWindow(5,570,100,30);
	m_eFileName.MoveWindow(110,570,500,30);

	//-----------------------------------------------------
	//Set control label
	//-----------------------------------------------------
	m_bRewind.SetWindowText("<< Rewind");
	m_bReverse.SetWindowText("< Backward");
	m_bStop.SetWindowText("[] Stop");
	m_bPause.SetWindowText("|| Pause");
	m_bPlayBack.SetWindowText("Playback >");
	m_bFF.SetWindowText("Fast Fwd >>");

	m_bPrevFrame.SetWindowText("<|| PrevFrame");
	m_bNextFrame.SetWindowText("Next Frame ||>");

	myPICT->SetWindowText("Local File Name :");
	m_eFileName.SetWindowText("c:\\JpegRecordingData.n3r");

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
void CSimpleSample_LocalFilePlayDlg::OnClose()
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
void CSimpleSample_LocalFilePlayDlg::OnDestroy()
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
void CSimpleSample_LocalFilePlayDlg::OnPaint()
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
void CSimpleSample_LocalFilePlayDlg::OnStop()
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
		lCommand	=	2;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
		m_csLog.Format("Stop:%d",lRet);
		m_dlog.Logging(m_csLog);

		PlayStatus = PLAYSTOP;

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
void CSimpleSample_LocalFilePlayDlg::OnPause()
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
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Pause:%d",lRet);
		m_dlog.Logging(m_csLog);	
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

//****************************************************************
//* Function Name   : PlayBack
//****************************************************************/
void CSimpleSample_LocalFilePlayDlg::OnPlayBack()
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lStatus		=	0;
    long	lBlocking	=	0;
	char 	chDate[MAX_FILE_PATH];
	long	lCommand	=	0;
	long	lspeed		=	0;

    if(PlayStatus == PLAYSTOP){
		//-----------------------------------------------------
		//Set N3R file password
		//-----------------------------------------------------
		m_psapi->SetFilePassword("");

		//-----------------------------------------------------
		//PlayFile
		//-----------------------------------------------------
	    lBlocking   =   0;
		lStatus		=	0;
		m_eFileName.GetWindowTextA(chDate, MAX_FILE_PATH); //FileName(Full path)
		lRet = m_psapi->PlayFile(chDate,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] PlayFile:%d",lRet);
		m_dlog.Logging(m_csLog);
		
		if(lRet == 0){
			//Status:Play local file
			PlayStatus = PLAYSTART;
		}else{
			m_psapi->ClearImage();
			m_csLog.Format("[Function] ClearImage");
			m_dlog.Logging(m_csLog);
		}
    }else{
		lCommand	=	4;
		lspeed		=	1;
		lStatus		=	0;
		lBlocking	=	0;
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Playback:%d",lRet);
		m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name   : Reverse
//****************************************************************/
void CSimpleSample_LocalFilePlayDlg::OnReverse()
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
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
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
void CSimpleSample_LocalFilePlayDlg::OnNextFrame()
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
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
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
void CSimpleSample_LocalFilePlayDlg::OnPrevFrame()
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
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
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
void CSimpleSample_LocalFilePlayDlg::OnFF()
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
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
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
void CSimpleSample_LocalFilePlayDlg::OnRewind()
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
		lRet = m_psapi->PlayControl(lCommand,	lspeed,	lStatus,	lBlocking,	(IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] Rewind:%d",lRet);
		m_dlog.Logging(m_csLog);	
	}else{
		m_csLog.Format("[Message] No playback.");
		m_dlog.Logging(m_csLog);
    }
}

