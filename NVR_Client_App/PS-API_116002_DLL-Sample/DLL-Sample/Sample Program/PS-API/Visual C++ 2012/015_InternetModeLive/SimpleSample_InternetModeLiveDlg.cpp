// SimpleSample_InternetModeLiveDlg.cpp : Implementension file
//

#include "stdafx.h"
#include <locale.h>
#include "SimpleSample_InternetModeLive.h"
#include "SimpleSample_InternetModeLiveDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_InternetModeLiveDlg dialog

CSimpleSample_InternetModeLiveDlg::CSimpleSample_InternetModeLiveDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_InternetModeLiveDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CSimpleSample_InternetModeLiveDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CSimpleSample_InternetModeLiveDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_LIVESTART, &CSimpleSample_InternetModeLiveDlg::OnBnClickedLivestart)
	ON_BN_CLICKED(IDC_LIVEEND, &CSimpleSample_InternetModeLiveDlg::OnBnClickedLiveend)
	ON_BN_CLICKED(IDC_INTERNETMODE, &CSimpleSample_InternetModeLiveDlg::OnBnClickedInternetmode)
END_MESSAGE_MAP()


// CSimpleSample_InternetModeLiveDlg message handler

//****************************************************************
//* Function Name   : OnInitDialog
//* Overview        : Initialization of this dialog
//****************************************************************/
BOOL CSimpleSample_InternetModeLiveDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);
	SetIcon(m_hIcon, FALSE);

	// Initialization of the display of the control
	SetInitialControl();

	// Create/Show Log window
	m_Log.Create(IDD_LOG_DIALOG, GetDesktopWindow());
	m_Log.SetWindowTextW(_T("LOG"));
	m_Log.ShowWindow(SW_SHOW);

	_wsetlocale(LC_ALL, _T(".OCP"));

	m_PlayStatus = Start;

	m_Listener.SetLogWndHandle(m_Log.m_hWnd);		// Set Log window handle
	m_Listener.SetProcHandle(this->m_hWnd);			// Set this window handle

	m_pPSAPI = NULL;
	m_pPSAPI = GetIPSAPI();							// Get PSAPI Interface

	//----------------------------------------
    //Set properties (ActiveX)
    //----------------------------------------
	// Set properties to connect the device
	m_pPSAPI->SetIPAddr((char*)("192.168.0.10"));
	m_pPSAPI->SetDeviceType(2);
	m_pPSAPI->SetHttpPort(80);
	m_pPSAPI->SetUserName((char*)("admin"));
	m_pPSAPI->SetPassword((char*)("admin12345"));
    //Set properties for display area
	m_pPSAPI->SetVideoWindow(GetDlgItem(IDC_AXIPROCTRL)->m_hWnd);
	m_pPSAPI->SetImageWidth(640);
	m_pPSAPI->SetImageHeight(480);
	// Set properties for image format
	m_pPSAPI->SetStreamFormat(3);
	m_pPSAPI->SetJPEGResolution(640);
	m_pPSAPI->SetMPEG4Resolution(640);
	m_pPSAPI->SetH264Resolution(640);
	m_pPSAPI->SetPictureFitMode(0);
	// Set properties for event
	m_pPSAPI->SetErrListener((IAppListener*)&m_Listener);
	m_pPSAPI->SetPlayListener((IAppListener*)&m_Listener);
	m_pPSAPI->SetDevListener(NULL);
	m_pPSAPI->SetImageListener(NULL, 1);
	m_pPSAPI->SetRecListener(NULL);
	m_pPSAPI->SetRecordListener(NULL);
	m_pPSAPI->SetOpListener(NULL);
	m_pPSAPI->SetAlmListener(NULL);

	// Clear Image
	m_pPSAPI->ClearImage();

    //----------------------------------------
    //Set parameters (Others)
    //----------------------------------------
	GetDlgItem(IDC_EDIT)->SetWindowText(_T("1"));

	//----------------------------------------
    //open
    //----------------------------------------
	long Ret = 0;
	Ret = m_pPSAPI->Open();
	m_LoggedString.Format(_T("[Function] open:%d"), Ret);

	return TRUE;
}


void CSimpleSample_InternetModeLiveDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this);

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

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

HCURSOR CSimpleSample_InternetModeLiveDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnClose
//* Overview        : Closed main window
//****************************************************************/
void CSimpleSample_InternetModeLiveDlg::OnClose()
{
	if (m_PlayStatus == Live) {
		OnBnClickedLiveend();
	}
	//----------------------------------------
    //Set properties (ActiveX)
    //----------------------------------------
	// Set the window handle to display
	m_pPSAPI->SetVideoWindow(NULL);
	// Set properties for event
	m_pPSAPI->SetErrListener(NULL);
	m_pPSAPI->SetPlayListener(NULL);
	
	// Release PSAPI instance
	DeleteIPSAPI(m_pPSAPI);
	m_pPSAPI = NULL;

	//-----------------------------------------------------
    //Destroy the log window
    //-----------------------------------------------------
	m_Log.DestroyWindow();

	CDialog::OnClose();
}

//****************************************************************
//* Function Name        : PreTranslateMessage
//* Overview             : Disable the Return/Escape Key
//****************************************************************
BOOL CSimpleSample_InternetModeLiveDlg::PreTranslateMessage(MSG* pMsg)
{
	if (pMsg->message == WM_KEYDOWN) {
		switch (pMsg->wParam) {
		case VK_ESCAPE:		// Disable the Enter key
		case VK_RETURN:		// Disable the Escape key
			return TRUE;
		}
	}
	return CDialog::PreTranslateMessage(pMsg);
}

//****************************************************************
//* Function Name        : OnBnClickedLivestart
//* Overview             : Start live video play
//****************************************************************
void CSimpleSample_InternetModeLiveDlg::OnBnClickedLivestart()
{
	// TODO: Add your control notification handler code here.
	long Ret, Channel, Blockmode, Status = 0;
	
	// Check the play status
	if (m_PlayStatus == Start) {
		// Start Live
		Channel = 1;		// Network camera
		Blockmode = 0;		// Blocking
		Ret = m_pPSAPI->PlayLive(Channel, Status, Blockmode, NULL);
		m_LoggedString.Format(_T("[Function] PlayLive(Start):%d"), Ret);
		m_Log.Logging(m_LoggedString);

		if (Ret == 0) {
			m_PlayStatus = Live;
		}
		else {
			m_pPSAPI->Close();
		}
	}
	else {
		m_Log.Logging(_T("[Message] In the live."));
	}

}

//****************************************************************
//* Function Name        : OnBnClickedLiveend
//* Overview             : Stop live video play
//****************************************************************
void CSimpleSample_InternetModeLiveDlg::OnBnClickedLiveend()
{
	// TODO: Add your control notification handler code here.
	long Ret, Command, Speed, Blockmode, Status = 0;
	
	// Check the play status
	if (m_PlayStatus == Live) {
		// Stop live
		Command = 1;		// Stop live
		Speed = 1;			// Step 1
		Blockmode = 0;		// Blocking
		Ret = m_pPSAPI->PlayControl(Command, Speed, Status, Blockmode, NULL);
		m_LoggedString.Format(_T("[Function] PlayLive(Stop):%d"), Ret);
		m_Log.Logging(m_LoggedString);

		// Close connection to the device
		m_pPSAPI->Close();
		m_Log.Logging(_T("[Function] Close"));

		// Clear Image
		m_pPSAPI->ClearImage();
		m_Log.Logging(_T("[Function] ClearImage"));

		m_PlayStatus = Start;
	}
	else {
		m_Log.Logging(_T("[Message] No live."));
	}
}

//****************************************************************
//* Function Name        : OnBnClickedInternetmode
//* Overview             : InternetMode Change
//****************************************************************
void CSimpleSample_InternetModeLiveDlg::OnBnClickedInternetmode()
{
	// TODO: Add your control notification handler code here.
	long Ret, Channel, Command;
	CString Mode;

	if (m_PlayStatus == Start) {
		Channel = 1;	// Network Camera
		GetDlgItem(IDC_EDIT)->GetWindowText(Mode);
		if (!_stscanf_s(Mode, _T("%d"), &Command)) return;
		if (Command != 0 && Command != 1) return;
		Ret = m_pPSAPI->SetInternetModeCam(Channel, Command, m_pPSAPI->GetStreamFormat(), m_pPSAPI->GetStreamNumber());
		m_LoggedString.Format(_T("[Function] SetInternetModeCam(SetMode=%d):%d"), Command, Ret);
		m_Log.Logging(m_LoggedString);
		m_pPSAPI->SetInternetMode(Command);
		m_LoggedString.Format(_T("[Function] SetInternetMode:%d"), m_pPSAPI->GetInternetMode());
		m_Log.Logging(m_LoggedString);
	}
	else {
		m_Log.Logging(_T("[Message] in the live."));
	}
}

//****************************************************************
//* Function Name   : SetInitialControl
//* Overview        : Initialization of the display of the control
//****************************************************************/
void CSimpleSample_InternetModeLiveDlg::SetInitialControl()
{
	WINDOWPLACEMENT wndPos;
	// Form Settings
	this->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = wndPos.rcNormalPosition.top = 0;
	wndPos.rcNormalPosition.right = 680; wndPos.rcNormalPosition.bottom = 630;
	this->SetWindowPlacement(&wndPos);
	// Control setting
	CWnd* pWnd = GetDlgItem(IDC_AXIPROCTRL);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 12; wndPos.rcNormalPosition.top = 12;
	wndPos.rcNormalPosition.right = 652; wndPos.rcNormalPosition.bottom = 492;
	pWnd->SetWindowPlacement(&wndPos);

	pWnd = GetDlgItem(IDC_LIVESTART);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 12; wndPos.rcNormalPosition.top = 514;
	wndPos.rcNormalPosition.right = 112; wndPos.rcNormalPosition.bottom = 544;
	pWnd->SetWindowPlacement(&wndPos);
	pWnd->SetWindowText(_T("Start &Live"));

	pWnd = GetDlgItem(IDC_LIVEEND);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 118; wndPos.rcNormalPosition.top = 514;
	wndPos.rcNormalPosition.right = 218; wndPos.rcNormalPosition.bottom = 544;
	pWnd->SetWindowPlacement(&wndPos);
	pWnd->SetWindowText(_T("Start &End"));

	pWnd = GetDlgItem(IDC_INTERNETMODE);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 12; wndPos.rcNormalPosition.top = 550;
	wndPos.rcNormalPosition.right = 112; wndPos.rcNormalPosition.bottom = 580;
	pWnd->SetWindowPlacement(&wndPos);
	pWnd->SetWindowText(_T("&Set InternetMode"));
	
	pWnd = GetDlgItem(IDC_EDIT);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 118; wndPos.rcNormalPosition.top = 561;
	wndPos.rcNormalPosition.right = 143; wndPos.rcNormalPosition.bottom = 580;
	pWnd->SetWindowPlacement(&wndPos);
}

