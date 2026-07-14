// SimpleSample_VMDSearch.cpp : implementation file
//

#include "stdafx.h"
#include "SimpleSample_VMDSearch.h"
#include "SimpleSample_VMDSearchDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//****************************************************************
//* Function Name   : CSimpleSample_CamCtrlDlg
//****************************************************************/
CSimpleSample_VMDSearchDlg::CSimpleSample_VMDSearchDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_VMDSearchDlg::IDD, pParent)
	, m_sYear(_T("2010"))
	, m_sMonth(_T("07"))
	, m_sDay(_T("01"))
	, m_sHour(_T("00"))
	, m_sMin(_T("00"))
	, m_sSec(_T("00"))
	, m_eYear(_T("2010"))
	, m_eMonth(_T("07"))
	, m_eDay(_T("01"))
	, m_eHour(_T("23"))
	, m_eMin(_T("59"))
	, m_eSec(_T("59"))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//****************************************************************
//* Function Name   : DoDataExchange
//****************************************************************/
void CSimpleSample_VMDSearchDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_LIST1, m_SearchRet);
	DDX_Text(pDX, IDC_EDIT2, m_sYear);
	DDX_Text(pDX, IDC_EDIT3, m_sMonth);
	DDX_Text(pDX, IDC_EDIT5, m_sDay);
	DDX_Text(pDX, IDC_EDIT6, m_sHour);
	DDX_Text(pDX, IDC_EDIT7, m_sMin);
	DDX_Text(pDX, IDC_EDIT8, m_sSec);
	DDX_Text(pDX, IDC_EDIT4, m_eYear);
	DDX_Text(pDX, IDC_EDIT9, m_eMonth);
	DDX_Text(pDX, IDC_EDIT10, m_eDay);
	DDX_Text(pDX, IDC_EDIT11, m_eHour);
	DDX_Text(pDX, IDC_EDIT12, m_eMin);
	DDX_Text(pDX, IDC_EDIT13, m_eSec);
}

//****************************************************************
//* Function Name   : BEGIN_MESSAGE_MAP
//****************************************************************/
BEGIN_MESSAGE_MAP(CSimpleSample_VMDSearchDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_CLOSE()
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BUTTON2, &CSimpleSample_VMDSearchDlg::OnVMDSearch_ASync)
	ON_BN_CLICKED(IDC_BUTTON3, &CSimpleSample_VMDSearchDlg::OnSearchCance)
	ON_LBN_DBLCLK(IDC_LIST1, &CSimpleSample_VMDSearchDlg::OnDblclkSearchRet)
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
HCURSOR CSimpleSample_VMDSearchDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnCreate
//****************************************************************/
int CSimpleSample_VMDSearchDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialog::OnCreate(lpCreateStruct) == -1)
		return -1;

	return 0;
}

//****************************************************************
//* Function Name   : OnQueryDragIcon
//****************************************************************/
BOOL CSimpleSample_VMDSearchDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);
	SetIcon(m_hIcon, FALSE);

    //-----------------------------------------------------
    //Initialize members
    //-----------------------------------------------------		
	PlayStatus	=	DEF_STOP;
    m_csLog.Empty();

    //-----------------------------------------------------
    //Initialize the control position
    //-----------------------------------------------------
    this->MoveWindow(0,0,800,555);
    m_dlog.Create(IDD_LOG,GetDesktopWindow()); 
    ::SetWindowPos(m_dlog,HWND_TOP,800,0,0,0,SWP_SHOWWINDOW | SWP_NOSIZE);

	m_pcallback.SetLogWndHandle(m_dlog.m_hWnd);//Set message handle
	m_pcallback.SetProcHandle(this->m_hWnd);//Set proc handle

    //-----------------------------------------------------
    //Create an instance
    //-----------------------------------------------------	
    m_psapi = NULL;
    m_psapi = GetIPSAPI();
	m_SearchResult = NULL;
	m_SearchResult = GetISearchResult();
	m_SearchResultEx = NULL;
	m_SearchResultEx = GetISearchResultEx();

	//-----------------------------------------------------
	//Set properties
	//-----------------------------------------------------
	//Set properties to connect the device
    m_psapi->SetIPAddr("192.168.0.250"); //IP address of the device
    m_psapi->SetDeviceType(1);          //Device type:0-3
    m_psapi->SetHttpPort(80);           //Port:0-65535
    m_psapi->SetUserName("ADMIN");      //User name to access the device
    m_psapi->SetPassword("12345");      //Password to access the device

	//Set properties for display area
    m_psapi->SetVideoWindow(this->m_hWnd);  //Set the window handle to display
    m_psapi->SetImageWidth(320);            //Image width
    m_psapi->SetImageHeight(240);           //Imgae Height

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

    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;

    //-----------------------------------------------------
    //Connect to the device
    //-----------------------------------------------------
	lRet = m_psapi->Open();
	m_csLog.Format("[Function] Open:%d",lRet);
	m_dlog.Logging(m_csLog);	

	return TRUE;  // return TRUE  unless you set the focus to a control
}

//****************************************************************
//* Function Name   : OnClose
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnClose()
{
	//-----------------------------------------------------
    //Close connection to the device
    //-----------------------------------------------------
	Call_PlayStop();

    //-----------------------------------------------------
    //Delete the instance
    //-----------------------------------------------------
    DeleteISearchResult(m_SearchResult);
    m_SearchResult = NULL;
    DeleteISearchResultEx(m_SearchResultEx);
    m_SearchResultEx = NULL;
    DeleteIPSAPI(m_psapi);
    m_psapi = NULL;

	EndDialog( IDCANCEL );

//	CDialog::OnClose();
}

//****************************************************************
//* Function Name   : OnDestroy
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnDestroy()
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
void CSimpleSample_VMDSearchDlg::OnPaint()
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
//* Function Name   : ShowResult
//****************************************************************/
void CSimpleSample_VMDSearchDlg::ShowResult()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long lRet = 0;
	long lCount = 0;
	CString csRet;
	SSEARCHRSLT_INFO stInfo;
	csRet.Empty();

	//-----------------------------------------------------
	//get list count
	//-----------------------------------------------------
	lRet = m_SearchResult->GetListCount( lCount ); 
	if((lCount < 0) || (lRet != 0)){
		m_csLog.Format("[Message] SearchEx result error");
		m_dlog.Logging(m_csLog);
		return;
	}else if((lCount == 0) && (lRet == 0)){
		m_csLog.Format("[Message] SearchEx result count is 0");
		m_dlog.Logging(m_csLog);
		return;
	}
	
	//-----------------------------------------------------
	//get search result
	//-----------------------------------------------------
	for(int i=0; i < lCount; i++){
		lRet = m_SearchResult->GetAndDelete(&stInfo);
		
		//output format [No, ch, startTD, EndTd, Kind, Audio ]
		csRet.Format("%d, %d, %s, %s, %s, %d",
						(i+1),
						stInfo.m_lChannel,
						stInfo.m_cStartTD,
						stInfo.m_cEndTD,
						stInfo.m_cRecKind,
						stInfo.m_lAudio);
		
		//output listbox
		m_SearchRet.InsertString(-1,csRet);
	}
}

//****************************************************************
//* Function Name   : ShowResultEx
//****************************************************************/
void CSimpleSample_VMDSearchDlg::ShowResultEx()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long lRet = 0;
	long lCount = 0;
	CString csRet;
	SSEARCHRSLT_INFO_EX stInfo;
	csRet.Empty();

	//-----------------------------------------------------
	//get list count
	//-----------------------------------------------------
	lRet = m_SearchResultEx->GetListCount( lCount ); 
	if((lCount < 0) || (lRet != 0)){
		m_csLog.Format("[Message] SearchEx result error");
		m_dlog.Logging(m_csLog);
		return;
	}else if((lCount == 0) && (lRet == 0)){
		m_csLog.Format("[Message] SearchEx result count is 0");
		m_dlog.Logging(m_csLog);
		return;
	}

	//-----------------------------------------------------
	//get search result
	//-----------------------------------------------------
	for(int i=0; i < lCount; i++){
		lRet = m_SearchResultEx->GetAndDelete(&stInfo);
		
		//output format [No, ch, startTD, EndTd, Kind, Audio, Time zone, Time mode ]
		csRet.Format("%d, %d, %s, %s, %s, %d, %d, %d",
						(i+1),
						stInfo.m_lChannel,
						stInfo.m_cStartTD,
						stInfo.m_cEndTD,
						stInfo.m_cRecKind,
						stInfo.m_lAudio,
						stInfo.m_lTimeZone,
						stInfo.m_lTimeMode);
		
		//output listbox
		m_SearchRet.InsertString(-1,csRet);
	}
}

//****************************************************************
//* Function Name   : Call_PlayStop
//****************************************************************/
void CSimpleSample_VMDSearchDlg::Call_PlayStop()
{
	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
	long lRet		=	0;
	long lCommand	=	0;
	long lSpeed		=	0;
	long lBlocking	=	0;
	long lStatus	=	0;

	if(PlayStatus	==	DEF_START){
		//-----------------------------------------------------
		//Stop Play
		//-----------------------------------------------------
		lCommand = 0;
		lSpeed = 1;
		lStatus = 0;
		lBlocking = 0;
		lRet = m_psapi->PlayControl(lCommand, lSpeed, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
		m_csLog.Format("[Function] PlayControl(Stop):%d",lRet);
		m_dlog.Logging(m_csLog);

		PlayStatus = DEF_STOP;

		m_psapi->ClearImage();
		m_csLog.Format("[Function] ClearImage");
		m_dlog.Logging(m_csLog);
	}
}

//****************************************************************
//* Function Name   : OnVMDSearch_ASync
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnVMDSearch_ASync()
{
	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
	long lRet			=	0;
	long lChannel		=	0;
	char csStartTD[256];
	char csEndTD[256];
	long lmask			=	0;
	long laSensitivity	=	0;
	long laxTopLeft		=	0;
	long layTopLeft		=	0;
	long laxBottomRight	=	0;
	long layBottomRight	=	0;
	long lbSensitivity 	=	0;
	long lbxTopLeft		=	0;
	long lbyTopLeft 	=	0;
	long lbxBottomRight	=	0;
	long lbyBottomRight =	0;
	long lcSensitivity	=	0;
	long lcxTopLeft		=	0;
	long lcyTopLeft		=	0;
	long lcxBottomRight	=	0;
	long lcyBottomRight	=	0;
	long ldSensitivity 	=	0;
	long ldxTopLeft 	=	0;
	long ldyTopLeft 	=	0;
	long ldxBottomRight =	0;
	long ldyBottomRight =	0;
	long limageWidth 	=	0;
	long limageHeight 	=	0;
	long lBlockMode		=	0;

	memset(csStartTD,0,256);
	memset(csEndTD	,0,256);

	Call_PlayStop();

	//-----------------------------------------------------
	//SearchEx
	//-----------------------------------------------------
	UpdateData(TRUE);

	lChannel = 1;
	wsprintf(csStartTD,"%s/%s/%s %s:%s:%s\0", m_sYear, m_sMonth, m_sDay, m_sHour, m_sMin, m_sSec );	//StartTime
	wsprintf(csEndTD,"%s/%s/%s %s:%s:%s\0", m_eYear, m_eMonth, m_eDay, m_eHour, m_eMin, m_eSec );	//EndTime

    lmask = 1;
    laSensitivity = 1;
    laxTopLeft = gxPosTopLeft;
    layTopLeft = gyPosTopLeft;
    laxBottomRight = gxPosBottomRight;
    layBottomRight = gyPosBottomRight;
    lbSensitivity = 0;
    lbxTopLeft = 0;
    lbyTopLeft = 0;
    lbxBottomRight = 0;
    lbyBottomRight = 0;
    lcSensitivity = 0;
    lcxTopLeft = 0;
    lcyTopLeft = 0;
    lcxBottomRight = 0;
    lcyBottomRight = 0;
    ldSensitivity = 0;
    ldxTopLeft = 0;
    ldyTopLeft = 0;
    ldxBottomRight = 0;
    ldyBottomRight = 0;
    limageWidth = m_psapi->GetImageWidth();
    limageHeight = m_psapi->GetImageHeight();
	lBlockMode	=	1;

	lRet = m_psapi->VMDSearchEx(lChannel, csStartTD, csEndTD, lmask,
                                laSensitivity, laxTopLeft, layTopLeft, laxBottomRight, layBottomRight,
                                lbSensitivity, lbxTopLeft, lbyTopLeft, lbxBottomRight, lbyBottomRight,
                                lcSensitivity, lcxTopLeft, lcyTopLeft, lcxBottomRight, lcyBottomRight,
                                ldSensitivity, ldxTopLeft, ldyTopLeft, ldxBottomRight, ldyBottomRight,
                                limageWidth, limageHeight, m_SearchResultEx, lBlockMode, &m_pcallback);
	m_csLog.Format("[Function] VMDSearchEx:%d (Channel[%d] Start[%s] End[%s] Mode[%d])",lRet,lChannel,csStartTD,csEndTD,lBlockMode);
	m_dlog.Logging(m_csLog);	
}

//****************************************************************
//* Function Name   : OnSearchCancel
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnSearchCance()
{
	//-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
	long lRet		=	0;

	//-----------------------------------------------------
	//SearchCancel
	//-----------------------------------------------------
	lRet = m_psapi->SearchCancel();
	m_csLog.Format("[Function] SearchCancel:%d",lRet);
	m_dlog.Logging(m_csLog);
}

//****************************************************************
//* Function Name   : OnDblclkSearchRet
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnDblclkSearchRet()
{
	//-----------------------------------------------------
	//Define variables
	//-----------------------------------------------------
	long lRet		=	0;
	long lchannel	=	0;
	long lStatus	=	0;
	long Startbuf	=	0;
	long Nextbuf	=	0;
	long Endbuf		=	0;
	long lBlocking	=	0;
	long lsel		=	0;
	char *	chDate	=	NULL;
	CString	csListbuf;
	CString csChannel;
	CString csTimeDT;
	csListbuf.Empty();
	csChannel.Empty();
	csTimeDT.Empty();

	//-----------------------------------------------------
	//Stop Play
	//-----------------------------------------------------
	Call_PlayStop();
	Call_ClearBox();

	//-----------------------------------------------------
	//check parameter
	//-----------------------------------------------------
	lsel = m_SearchRet.GetCurSel();
	if(m_SearchRet.GetTextLen(lsel) == 0){
		return;
	}
	
	//-----------------------------------------------------
	//Get listbox data
	//-----------------------------------------------------
	m_SearchRet.GetText(lsel,csListbuf);

	//-----------------------------------------------------
	//Start Play
	//-----------------------------------------------------
	//Search [, ], get ch & timedate
	Startbuf = csListbuf.Find(", ",0);
	Nextbuf = csListbuf.Find(", ",Startbuf+2);
	Endbuf = csListbuf.Find(", ",Nextbuf+2);

	lchannel = atol( csListbuf.Mid(Startbuf+2,Nextbuf-Startbuf+2) );

	csTimeDT = csListbuf.Mid(Startbuf+5,Endbuf-(Nextbuf+2));
	chDate = new char[Endbuf-(Nextbuf+2)+1];
	memset(chDate, 0, Endbuf-(Nextbuf+2)+1);
	memcpy(chDate, csTimeDT, Endbuf-(Nextbuf+2));

	lBlocking	=	0;
	lRet = m_psapi->Play(lchannel, chDate, lStatus, lBlocking, (IAppCallBack*)&m_pcallback);
	m_csLog.Format("[Function] Play:%d",lRet);
	m_dlog.Logging(m_csLog);

	if( lRet == 0 ){
		PlayStatus	=	DEF_START;
	}

	delete chDate;
}

//****************************************************************
//* Function Name   : DefWindowProc
//****************************************************************/
LRESULT CSimpleSample_VMDSearchDlg::DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	if(message	==	WM_SEARCH_CB){
		if(wParam == 0){
			ShowResult();
		}else{
			ShowResultEx();		}
	}
	return CDialog::DefWindowProc(message, wParam, lParam);
}

//****************************************************************
//* Function Name   : Call_ClearBox
//****************************************************************/
void CSimpleSample_VMDSearchDlg::Call_ClearBox()
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

	//-----------------------------------------------------
	//Display Box
	//-----------------------------------------------------
    lId = 1;
    lCommand = 1;
    lColor = 16777215;
    lSize = 3;
    lRet = m_psapi->BoxOperation(lId, lCommand, lColor, lSize, 0, 0, 1, 1);

    gxPosTopLeft = 0;
    gyPosTopLeft = 0;
    gxPosBottomRight = 0;
    gyPosBottomRight = 0;
}

//****************************************************************
//* Function Name   : MouseDown
//****************************************************************/
void CSimpleSample_VMDSearchDlg::MouseDown(long x, long y)
{
    gxPosTopLeft = x;
    gyPosTopLeft = y;
	m_csLog.Format("[MouseDown] Position X[%d] Y[%d]",x, y);
	m_dlog.Logging(m_csLog);
}

//****************************************************************
//* Function Name   : MouseUp
//****************************************************************/
void CSimpleSample_VMDSearchDlg::MouseUp(long x, long y)
{
    //-----------------------------------------------------
    //Define variables
    //-----------------------------------------------------
    long	lRet		=	0;
    long	lxTmpTL		=	0;
    long	lyTmpTL		=	0;
    long	lxTmpBR		=	0;
    long	lyTmpBR		=	0;
    long	lId 		=	0;
    long	lCommand 	=	0;
    long	lColor		=	0;
    long	lSize		=	0;

    gxPosBottomRight = x;
    gyPosBottomRight = y;
	m_csLog.Format("[MouseUp] Position X[%d] Y[%d]",x, y);
	m_dlog.Logging(m_csLog);

	if(gxPosTopLeft > gxPosBottomRight){
        lxTmpTL = gxPosBottomRight;
        lxTmpBR = gxPosTopLeft;
	}else{
        lxTmpTL = gxPosTopLeft;
        lxTmpBR = gxPosBottomRight;
	}

	if(gyPosTopLeft > gyPosBottomRight){
        lyTmpTL = gyPosBottomRight;
        lyTmpBR = gyPosTopLeft;
	}else{
        lyTmpTL = gyPosTopLeft;
        lyTmpBR = gyPosBottomRight;
	}

	//-----------------------------------------------------
	//Display Box
	//-----------------------------------------------------
    lId = 1;
    lCommand = 1;
    lColor = 16777215;
    lSize = 3;
    lRet = m_psapi->BoxOperation(lId, lCommand, lColor, lSize, lxTmpTL, lyTmpTL, lxTmpBR, lyTmpBR);

    gxPosTopLeft = lxTmpTL;
    gyPosTopLeft = lyTmpTL;
    gxPosBottomRight = lxTmpBR;
    gyPosBottomRight = lyTmpBR;
}

//****************************************************************
//* Function Name   : Receive Mouse down Event
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnLButtonDown(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseDown(lx, ly);

	CDialog::OnLButtonDown(nFlags, point);
}

void CSimpleSample_VMDSearchDlg::OnMButtonDown(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseDown(lx, ly);

	CDialog::OnMButtonDown(nFlags, point);
}

void CSimpleSample_VMDSearchDlg::OnRButtonDown(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseDown(lx, ly);

	CDialog::OnRButtonDown(nFlags, point);
}

//****************************************************************
//* Function Name   : Receive Mouse up Event
//****************************************************************/
void CSimpleSample_VMDSearchDlg::OnLButtonUp(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseUp(lx, ly);

	CDialog::OnLButtonUp(nFlags, point);
}

void CSimpleSample_VMDSearchDlg::OnMButtonUp(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseUp(lx, ly);

	CDialog::OnMButtonUp(nFlags, point);
}

void CSimpleSample_VMDSearchDlg::OnRButtonUp(UINT nFlags, CPoint point)
{
	long lx = point.x;
	long ly = point.y;
	MouseUp(lx, ly);

	CDialog::OnRButtonUp(nFlags, point);
}
