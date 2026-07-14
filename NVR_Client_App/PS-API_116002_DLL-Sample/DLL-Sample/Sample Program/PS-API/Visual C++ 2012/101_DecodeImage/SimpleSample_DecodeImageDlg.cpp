// SimpleSample_DecodeImageDlg.cpp : インプリメンテーション ファイル
//

#include "stdafx.h"
#include "SimpleSample_DecodeImage.h"
#include "SimpleSample_DecodeImageDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif


//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_DecodeImageDlg::CSimpleSample_DecodeImageDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_DecodeImageDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSimpleSample_DecodeImageDlg)
	m_sFolderName = _T("");
	m_sFileName = _T("");
	m_sFrameTime = _T("");
	m_sFrameType = _T("");
	m_slblView = _T("");
	//}}AFX_DATA_INIT
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_DecodeImageDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSimpleSample_DecodeImageDlg)
	DDX_Control(pDX, IDC_lblFrameType, m_lblFrameType);
	DDX_Control(pDX, IDC_lblFrameTime, m_lblFrameTime);
	DDX_Control(pDX, IDC_grpImageHeader, m_grpImageHeader);
	DDX_Control(pDX, IDC_lblFileName, m_lblFileName);
	DDX_Control(pDX, IDC_lblFolderName, m_lblFolderName);
	DDX_Control(pDX, IDC_FrameType, m_eFrameType);
	DDX_Control(pDX, IDC_FrameTime, m_eFrameTime);
	DDX_Control(pDX, IDC_FileName, m_eFileName);
	DDX_Control(pDX, IDC_FolderName, m_eFolderName);
	DDX_Control(pDX, IDC_lblView, m_lblView);
	DDX_Control(pDX, IDC_Stop, m_bStop);
	DDX_Control(pDX, IDC_SaveFile, m_bSaveFile);
	DDX_Control(pDX, IDC_DecodeImage, m_bDecodeImage);
	DDX_Text(pDX, IDC_FolderName, m_sFolderName);
	DDX_Text(pDX, IDC_FileName, m_sFileName);
	DDX_Text(pDX, IDC_FrameTime, m_sFrameTime);
	DDX_Text(pDX, IDC_FrameType, m_sFrameType);
	DDX_Text(pDX, IDC_lblView, m_slblView);
	//}}AFX_DATA_MAP
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_DecodeImageDlg, CDialog)
	//{{AFX_MSG_MAP(CSimpleSample_DecodeImageDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_SaveFile, On_SaveFile)
	ON_BN_CLICKED(IDC_Stop, OnStop)
	ON_BN_CLICKED(IDC_DecodeImage, OnDecodeImage)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
HCURSOR CSimpleSample_DecodeImageDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_DecodeImageDlg::OnCreate(LPCREATESTRUCT lpCreateStruct) 
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;
	
	//Create an instance
	m_psapi = NULL;
	m_psapi = GetIPSAPI();
	
	return 0;
}


//****************************************************************
//* Function Name   : OnInitDialog
//****************************************************************/
BOOL CSimpleSample_DecodeImageDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
    //-----------------------------------------------------
    //Initialize members
    //-----------------------------------------------------		
    PlayStatus = PLAYSTOP;
    m_csLog.Empty();

	m_slblView = "";								//Display current status
	m_sFolderName = "C:\\DecodeImage";				//Directory path to save files
	m_csOutputFileName = "CompressedVideoImage";	//Save file name
	m_lDrawSuffix = 0;								//File count

    //-----------------------------------------------------
    //Initialize the control position
    //-----------------------------------------------------
	this->MoveWindow(0,0,800,595);
	m_bSaveFile.MoveWindow(655,30,120,50);
	m_bStop.MoveWindow(655,100,120,50);
	m_lblFolderName.MoveWindow(25,495,40,14);
	m_eFolderName.MoveWindow(70,490,395,21);
	m_lblFileName.MoveWindow(485,495,40,14);
	m_eFileName.MoveWindow(520,490,135,21);
	m_grpImageHeader.MoveWindow(15,518,650,40);
	m_lblFrameTime.MoveWindow(25,535,70,14);
	m_eFrameTime.MoveWindow(100,531,270,21);
	m_lblFrameType.MoveWindow(447,535,70,14);
	m_eFrameType.MoveWindow(520,531,135,21);

	m_bDecodeImage.MoveWindow(680,485,100,60);
	m_lblView.MoveWindow(650,460,200,20);

	m_bSaveFile.SetWindowText("Save Compressed\nVideo Image");

	//-----------------------------------------------------
	//Create log window
	//-----------------------------------------------------
	m_dlog.Create(IDD_LOG,GetDesktopWindow());
    ::SetWindowPos(m_dlog,HWND_TOP,800,0,0,0,SWP_SHOWWINDOW | SWP_NOSIZE);

	m_pcallback.SetLogWndHandle(m_dlog.m_hWnd);		//Set messgae handle to the listener class
	m_pcallback.SetProcHandle(this->m_hWnd);		//Set proc handle to the listener class

	UpdateData(false);

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
	m_psapi->SetImageWidth(640);			//Image Width
	m_psapi->SetImageHeight(480);			//Image Height

	//Set properties for image format
	m_psapi->SetStreamFormat(0);				//Image format - JPEG:0, MPEG-4:1, H.264:3
	m_psapi->SetJPEGResolution(640);			//JPEG Resolution(It works in case of StreamFormat = 0);
	m_psapi->SetMPEG4Resolution(640);			//MPEG-4 Resolution(It works in case of StreamFormat = 1);
	m_psapi->SetH264Resolution(640);    		//H.264 Resolution(It works in case of StreamFormat=3)

	//-----------------------------------------------------
    //Set Listener
    //-----------------------------------------------------
	long	lDataType	=	0;
	lDataType	=	2;					//1:Bitmap	2:Raw data

	m_psapi->SetErrListener((IAppListener*)&m_pcallback);
	m_psapi->SetDevListener(NULL);
	m_psapi->SetRecListener(NULL);
	m_psapi->SetPlayListener((IAppListener*)&m_pcallback);
	m_psapi->SetImageListener((IAppListener*)&m_pcallback, lDataType);
	m_psapi->SetRecordListener(NULL);
	m_psapi->SetOpListener(NULL);
	m_psapi->SetAlmListener(NULL);

	//Paint background color
	m_psapi->ClearImage();
	m_csLog.Format("[Function] ClearImage");
	m_dlog.Logging(m_csLog);

	return TRUE;  // TODO: Add extra initialization here
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_DecodeImageDlg::OnClose() 
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
    
	CDialog::OnClose();
}

//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_DecodeImageDlg::OnDestroy() 
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
void CSimpleSample_DecodeImageDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this);

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

//****************************************************************
//* Function Name   : On_SaveFile
//****************************************************************/
void CSimpleSample_DecodeImageDlg::On_SaveFile() 
{
	UpdateData(true);
	m_pcallback.SetFolderName(m_sFolderName);
	m_pcallback.SetFileName(m_csOutputFileName);
	StartLive();	
}

//****************************************************************
//* Function Name   : OnStop
//****************************************************************/
void CSimpleSample_DecodeImageDlg::OnStop() 
{
	StopLive();
	m_pcallback.ClearNumber();
}


//****************************************************************
//* Function Name   : StartLive
//****************************************************************/
long CSimpleSample_DecodeImageDlg::StartLive()
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
	return 0;
}

//****************************************************************
//* Function Name   : StopLive
//****************************************************************/
long CSimpleSample_DecodeImageDlg::StopLive()
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
	return 0;
}

//****************************************************************
//* Function Name   : OnDecodeImage
//****************************************************************/
void CSimpleSample_DecodeImageDlg::OnDecodeImage() 
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
	unsigned char* pcFile;
	char* pcFolderName;
	char FileName[256];
	DWORD wFileSize;
	DWORD wReadSize;
	HANDLE hImageFile;

    //-----------------------------------------------------
	//Set properties for display area
    //-----------------------------------------------------
	m_psapi->SetVideoWindow(this->m_hWnd);		//Set the window handle to display
	m_psapi->SetStreamFormat(0);				//Image format - JPEG:0, MPEG-4:1, H.264:3

    if(PlayStatus == PLAYSTART)
	{
		m_csLog.Format("[Message] Live already started.");
		m_dlog.Logging(m_csLog);
		return ;
	}

    //-----------------------------------------------------
	//Read Compressed video image from a file
    //-----------------------------------------------------
	pcFolderName = new char[m_sFolderName.GetLength() + 1];
	strcpy_s(pcFolderName, m_sFolderName.GetLength() + 1, m_sFolderName);
	wsprintf(FileName, "%s\\%s.%03d", pcFolderName, m_csOutputFileName, m_lDrawSuffix);
	delete [] pcFolderName;
	
	hImageFile = CreateFile(FileName, GENERIC_READ, FILE_SHARE_READ, NULL, 
								OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL);

	if(hImageFile == INVALID_HANDLE_VALUE)
	{
		m_lDrawSuffix = 0;
		return;
	}
	wFileSize = GetFileSize(hImageFile, NULL);
	pcFile = new unsigned char[wFileSize];
	ReadFile(hImageFile, pcFile, wFileSize, &wReadSize, NULL);
	m_sFileName.Format("%s.%03d", m_csOutputFileName, m_lDrawSuffix);
	UpdateData(false);
	m_lDrawSuffix++;

	//Check size
	if( wReadSize == ntohl(*(long *)&pcFile[0])){
		
		m_slblView = "DecodeImage";
		UpdateData(false);

		//Analyze header
		long lFilePointer;

		long	lHeaderSize;
		short	sID;
		short	sLength;
		long	lClock;
		char	cTimeZoneDirection;
		char	cTimeZoneHour;
		char	cTimeZoneMinute;
		char	cSummerTime;
		short	sFrameTime;
		short	sCompression;
		short	sFrameType;
		short	sImageWidth;
		short	sImageHeight;

		//Initialize
		lFilePointer = 0;
		lHeaderSize = 0;
		sID = 0;
		sLength = 0;
		lClock	= 0;
		cTimeZoneDirection	= 0;
		cTimeZoneHour	= 0;
		cTimeZoneMinute	= 0;
		cSummerTime	= 0;
		sFrameTime	= 0;
		sCompression	= 0;
		sFrameType	= 0;
		sImageWidth	= 0;
		sImageHeight	= 0;
		SYSTEMTIME st;

		lFilePointer += 4;

		//Get header size
		lHeaderSize = ntohl(*(long *)&pcFile[lFilePointer]);
		lFilePointer +=4;

		//Analize Information Unit
		while(1)
		{
			//Get ID
			sID = ntohs(*(short *)&pcFile[lFilePointer]);
			lFilePointer += 2;

			//Get Length
			sLength = ntohs(*(short *)&pcFile[lFilePointer]);
			lFilePointer += 2;

			if(sID == 0x0011)
			{

				//Get Clock
				lClock = ntohl(*(long *)&pcFile[lFilePointer]);
				//Get TimeZoneDirection
				cTimeZoneDirection = pcFile[lFilePointer + 4];
				//Get TimeZoneHour
				cTimeZoneHour = pcFile[lFilePointer + 5];
				//Get TimeZoneMinute
				cTimeZoneMinute = pcFile[lFilePointer + 6];
				//Get SummerTime
				cSummerTime = pcFile[lFilePointer + 7];

				//Move lFilePointer
				lFilePointer += sLength - 4;

			}
			else if(sID == 0x0012)
			{
				//Get FrameTime
				sFrameTime = ntohs(*(short *)&pcFile[lFilePointer]);
				lFilePointer += sLength - 4;
			}
			else if(sID == 0x1001)
			{
				//Get Compression
				sCompression = ntohs(*(short *)&pcFile[lFilePointer]);
				lFilePointer += sLength - 4;
			}
			else if(sID == 0x1002)
			{
				//Get FrameType
				sFrameType = ntohs(*(short *)&pcFile[lFilePointer]);
				lFilePointer += sLength - 4;
			}
			else if(sID == 0x1003)
			{
				//Get ImageWidth
				sImageWidth = ntohs(*(short *)&pcFile[lFilePointer]);
				//Get Imageheight
				sImageHeight = ntohs(*(short *)&pcFile[lFilePointer + 2]);

				lFilePointer += sLength - 4;
			}

			if(lFilePointer > lHeaderSize)
			{

				//time_t -> SYSTEMTIME
				FILETIME ft;
				LONGLONG ll;

				ll = Int32x32To64((LONG)lClock, 10000000) + 116444736000000000;
				ft.dwLowDateTime = (DWORD)ll;
				ft.dwHighDateTime = (DWORD)(ll >> 32);
				FileTimeToSystemTime(&ft, &st);

				st.wMilliseconds = sFrameTime*10;

				//Display header informations

				char cDispTimeZone[3] = "-+";
				m_sFrameTime.Format("%04d/%02d/%02d %02d:%02d:%02d:%03d %c%02d:%02d",
										st.wYear, st.wMonth, st.wDay, 
										st.wHour, st.wMinute, st.wSecond, st.wMilliseconds,
										cDispTimeZone[cTimeZoneDirection], cTimeZoneHour, cTimeZoneMinute
										);
				if(cSummerTime == 1)
				{
					m_sFrameTime = m_sFrameTime + " DST";
				}

				if(sFrameType == 0)
				{
					m_sFrameType = "JPEG";
				}
				else if(sFrameType == 1)
				{
					m_sFrameType = "MPEG-4 I-Frame";
				}
				else if(sFrameType == 2)
				{
					m_sFrameType = "MPEG-4 P-Frame";
				}

				UpdateData(false);

				//Draw a Compressed video image
				m_psapi->DecodeImage(pcFile, wFileSize);	
				break;
			}
		}
	}

	delete[] pcFile;
	CloseHandle(hImageFile);
	hImageFile = INVALID_HANDLE_VALUE;
}
