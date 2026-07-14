// SimpleSample_PSLookupDlg.cpp : Implementension file
//

#include "stdafx.h"
#include "SimpleSample_PSLookup.h"
#include "SimpleSample_PSLookupDlg.h"
#include <time.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSimpleSample_PSLookupDlg Dialog

CSimpleSample_PSLookupDlg::CSimpleSample_PSLookupDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSimpleSample_PSLookupDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CSimpleSample_PSLookupDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CSimpleSample_PSLookupDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_DESTROY()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_BUTTON1, &CSimpleSample_PSLookupDlg::OnBnClickedSearch)
END_MESSAGE_MAP()


// CSimpleSample_PSLookupDlg Message handler

//****************************************************************
//* Function Name   : OnInitDialog
//* Overview        : Initialization of this dialog
//****************************************************************/
BOOL CSimpleSample_PSLookupDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	SetIcon(m_hIcon, TRUE);
	SetIcon(m_hIcon, FALSE);
	
	// Initialization of the display of the control
	SetInitialControl();
	
	// Create/Show Log window
	m_Log.Create(IDD_LOG_DIALOG, GetDesktopWindow());
	m_Log.ShowWindow(SW_SHOW);
	
	// Set initial status
	m_Status = SearchOff;
	m_MaxLength = 0;
	m_pLookup = NULL;

	m_Listener.SetLogWndHandle(m_Log.m_hWnd);		// Set Log window handle
	m_Listener.SetProcHandle(this->m_hWnd);			// Set this window handle

	m_pLookup = GetIPSLookup();						// Get PSLookup instance
	//----------------------------------------
    //Set properties (ActiveX)
    //----------------------------------------
	// Initialization event receives
	m_pLookup->SetErrListener(&m_Listener);
	m_pLookup->SetDevLookupListener(NULL);
	m_Log.Logging(_T("[Event] OnDevLookupEnable:=Off"));
 
    //----------------------------------------
    //Set parameters (Other controls)
    //----------------------------------------
    CListBox* pLb = (CListBox*)GetDlgItem(IDC_LIST1);
	pLb->ResetContent();

	return TRUE;  
}

void CSimpleSample_PSLookupDlg::OnPaint()
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

HCURSOR CSimpleSample_PSLookupDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

//****************************************************************
//* Function Name   : OnDestroy
//* Overview        : Destroy all dialogs
//****************************************************************/
void CSimpleSample_PSLookupDlg::OnDestroy() 
{
	DeleteIPSLookup(m_pLookup);						// Release PSLookup instance
	m_pLookup = NULL;

	CDialog::OnDestroy();
    //-----------------------------------------------------
    //Destroy the log window
    //-----------------------------------------------------
	m_Log.DestroyWindow();
}

//****************************************************************
//* Function Name        : OnBnClickedSearch
//* Overview             : Click the button for Search(Start / Stop)
//****************************************************************
void CSimpleSample_PSLookupDlg::OnBnClickedSearch()
{
	// TODO: Add your control notification handler code here.
	CWnd* pWnd = GetDlgItem(IDC_BUTTON1);
	if (m_Status == SearchOff) {
		// Trun on DevLookup event receives
		m_pLookup->SetDevLookupListener(&m_Listener);
		m_Log.Logging(_T("[Event] OnDevLookupEnable:=On"));
		m_Status = SearchOn;
		pWnd->SetWindowText(_T("&End"));
	}
	else {
		// Trun off DevLookup event receives
		m_pLookup->SetDevLookupListener(NULL);
		m_Log.Logging(_T("[Event] OnDevLookupEnable:=Off"));
		m_Status = SearchOff;
		pWnd->SetWindowText(_T("&Start"));
	}
}

//****************************************************************
//* Function Name        : DefWindowProc
//* Overview             : Receives a message from Listener
//****************************************************************
LRESULT CSimpleSample_PSLookupDlg::DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	switch(message)
	{
		case WM_DEVLOOKUP:
			// Add item to ListBox
			CString strTmp;
			strTmp.Format(_T("%s"),(TCHAR*)wParam);
			CListBox* pLb = (CListBox*)GetDlgItem(IDC_LIST1);
			pLb->AddString(strTmp);
			CheckHScroll(strTmp);
			delete	((char*)wParam);
			break;
	}
	
	return CDialog::DefWindowProc(message, wParam, lParam);
}


//****************************************************************
//* Function Name        : PreTranslateMessage
//* Overview             : Disable the Return/Escape Key
//****************************************************************
BOOL CSimpleSample_PSLookupDlg::PreTranslateMessage(MSG* pMsg)
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
//* Function Name   : SetInitialControl
//* Overview        : Initialization of the display of the control
//****************************************************************/
void CSimpleSample_PSLookupDlg::SetInitialControl()
{
	WINDOWPLACEMENT wndPos;
	// Form setting
	this->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = wndPos.rcNormalPosition.top = 0;
	wndPos.rcNormalPosition.right = 560; wndPos.rcNormalPosition.bottom = 400;
	this->SetWindowPlacement(&wndPos);
	// Control setting
	CWnd* pWnd = GetDlgItem(IDC_STATIC);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 12; wndPos.rcNormalPosition.top = 24;
	wndPos.rcNormalPosition.right = 101; wndPos.rcNormalPosition.bottom = 36;
	pWnd->SetWindowPlacement(&wndPos);
	pWnd->SetWindowText(_T("Search Cameras"));

	pWnd = GetDlgItem(IDC_BUTTON1);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 117; wndPos.rcNormalPosition.top = 15;
	wndPos.rcNormalPosition.right = 217; wndPos.rcNormalPosition.bottom = 45;
	pWnd->SetWindowPlacement(&wndPos);
	pWnd->SetWindowText(_T("&Start"));

	pWnd = GetDlgItem(IDC_LIST1);
	pWnd->GetWindowPlacement(&wndPos);
	wndPos.rcNormalPosition.left = 14; wndPos.rcNormalPosition.top = 60;
	wndPos.rcNormalPosition.right = 542; wndPos.rcNormalPosition.bottom = 352;
	pWnd->SetWindowPlacement(&wndPos);
}

//****************************************************************
//* Function Name   : CheckHScroll
//* Overview        : Check the labeling requirements of the horizontal scroll bar
//****************************************************************/
void CSimpleSample_PSLookupDlg::CheckHScroll(CString AddString)
{
	CListBox* pLb = (CListBox*)GetDlgItem(IDC_LIST1);
    CDC* pDC = pLb->GetDC();
    CFont* pFont = pLb->GetFont();
    CFont* pOldFont = pDC->SelectObject(pFont);
	TEXTMETRIC tm;
    pDC->GetTextMetrics(&tm); 

    CSize sz = pDC->GetTextExtent(AddString);
    INT_PTR dx = sz.cx + tm.tmAveCharWidth;
	if (m_MaxLength < dx) m_MaxLength = dx;

	pDC->SelectObject(pOldFont);
	pLb->ReleaseDC(pDC);
	pLb->SetHorizontalExtent((int)m_MaxLength);
}