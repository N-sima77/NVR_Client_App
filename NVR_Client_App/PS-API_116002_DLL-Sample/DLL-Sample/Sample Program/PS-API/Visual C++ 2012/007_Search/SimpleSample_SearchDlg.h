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

typedef struct SearchType {
	SearchType(){
		EMR_BIT	=	0;
		MAN_BIT	=	0;
		SCH_BIT	=	0;
		TRM_BIT	=	0;
		CMD_BIT	=	0;
		CAM_BIT	=	0;
		SDB_BIT	=	0;
		VLA_BIT	=	0;
		VMD_BIT	=	0;
		CMTN_BIT	=	0;
		CSTY_BIT	=	0;
		CRMV_BIT	=	0;
		CSCD_BIT	=	0;
		CTRM_BIT	=	0;
		CDRT_BIT	=	0;
		PRE_BIT	=	0;
		RSV_BIT	=	0;

	}
	unsigned long EMR_BIT :1;
	unsigned long MAN_BIT :1;
	unsigned long SCH_BIT :1;
	unsigned long TRM_BIT :1;
	unsigned long CMD_BIT :1;
	unsigned long CAM_BIT :1;
	unsigned long SDB_BIT :1;
	unsigned long VLA_BIT :1;
	unsigned long VMD_BIT :1;
	unsigned long CMTN_BIT :1;
	unsigned long CSTY_BIT :1;
	unsigned long CRMV_BIT :1;
	unsigned long CSCD_BIT :1;
	unsigned long CTRM_BIT :1;
	unsigned long CDRT_BIT :1;
	unsigned long PRE_BIT :1;
	unsigned long RSV_BIT :16;
}SEARCHTYPE;


//--------------------------------------------------------------------
//Dialog
//--------------------------------------------------------------------
class CSimpleSample_SearchDlg : public CDialog
{

public:
	CSimpleSample_SearchDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SIMPLESAMPLE_SEARCH_DIALOG };

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
	BOOL m_bType_EMR;
	BOOL m_bType_MAN;
	BOOL m_bType_SCH;
	BOOL m_bType_TRM;
	BOOL m_bType_CMD;
	BOOL m_bType_VMD;
	BOOL m_bType_VMDAlm;
	BOOL m_bType_motion;
	BOOL m_bType_loitering;
	BOOL m_bType_removal;
	BOOL m_bType_screen;
	BOOL m_bType_terminal;
	BOOL m_bType_direction;
	BOOL m_bType_SDB;
	BOOL m_bType_VLA;

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

	afx_msg void OnSearch_Sync();
	afx_msg void OnSearch_ASync();
	afx_msg void OnDblclkSearchRet();
	afx_msg void OnSearchCance();

public:
	//-----------------------------------------------------
	// Define functions
	//-----------------------------------------------------
	void Call_PlayStop();
	void ShowResult();
	void ShowResultEx();

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
};
