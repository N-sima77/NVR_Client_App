//--------------------------------------------------------------------
// Include headers
//--------------------------------------------------------------------
#pragma once
#include "afxwin.h"

//Include header files of PS-API
#include "psapidef.h"
#include "ipsapi.h"
#include "isearchresult.h"

//Include header files of Sample program
#include "LogDlg.h"
#include "SampleCB.h"


//--------------------------------------------------------------------
//define
//--------------------------------------------------------------------
#define DEF_LOGOUT		0
#define DEF_LOGIN		1

#define DEF_STOP		0
#define DEF_START		1

#define WM_SEARCH_CB	(WM_USER + 2)


//--------------------------------------------------------------------
//Dialog
//--------------------------------------------------------------------
class CSimpleSample_VMDSearchDlg : public CDialog
{

public:
	CSimpleSample_VMDSearchDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SIMPLESAMPLE_VMDSEARCH_DIALOG };

	CListBox m_SearchRet;
	CString m_sYear;
	CString m_sMonth;
	CString m_sDay;
	CString m_sHour;
	CString m_sMin;
	CString m_sSec;
	CString m_eYear;
	CString m_eMonth;
	CString m_eDay;
	CString m_eHour;
	CString m_eMin;
	CString m_eSec;

protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	virtual LRESULT DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam);

protected:
	HICON m_hIcon;
	DECLARE_MESSAGE_MAP()
	afx_msg HCURSOR OnQueryDragIcon();

	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	virtual BOOL OnInitDialog();
	afx_msg void OnClose();
	afx_msg void OnDestroy();
	afx_msg void OnPaint();

	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnMButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnRButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnMButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);

	afx_msg void OnVMDSearch_ASync();
	afx_msg void OnDblclkSearchRet();
	afx_msg void OnSearchCance();

public:
	//-----------------------------------------------------
	// Define functions
	//-----------------------------------------------------
	void Call_PlayStop();
	void ShowResult();
	void ShowResultEx();

	void Call_ClearBox();
	void MouseDown(long x, long y);
	void MouseUp(long x, long y);

	//-----------------------------------------------------
	// Define variables
	//-----------------------------------------------------
	IPSAPI*		m_psapi;
	CLogDlg		m_dlog;
	CSampleCB	m_pcallback;
	CString		m_csLog;

	ISearchResult*		m_SearchResult;
	ISearchResultEx*	m_SearchResultEx;
	long		PlayStatus;

    long gxPosTopLeft;
    long gyPosTopLeft;
    long gxPosBottomRight;
    long gyPosBottomRight;
};
