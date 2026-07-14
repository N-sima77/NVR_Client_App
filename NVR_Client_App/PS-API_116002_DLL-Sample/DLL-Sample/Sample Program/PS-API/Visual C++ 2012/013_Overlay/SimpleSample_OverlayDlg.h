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
#define PLAYSTART		1
#define PLAYSTOP		0


//--------------------------------------------------------------------
//Dialog
//--------------------------------------------------------------------
class CSimpleSample_OverlayDlg : public CDialog
{

public:
	CSimpleSample_OverlayDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SIMPLESAMPLE_OVERLAY_DIALOG };

	CButton m_ckTitle;
	CButton m_ckBox;
	CButton m_ckBMPDraw;	// Added Ver5.0.1.0

protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support

protected:
	HICON m_hIcon;
	DECLARE_MESSAGE_MAP()
	afx_msg HCURSOR OnQueryDragIcon();

	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	virtual BOOL OnInitDialog();
	afx_msg void OnClose();
	afx_msg void OnDestroy();
	afx_msg void OnPaint();
	virtual BOOL PreTranslateMessage(MSG* pMsg);	// Added Ver5.0.1.0

	afx_msg void OnDrawTitle();
	afx_msg void OnDrawBox();
	afx_msg void OnBMPDraw();	// Added Ver5.0.1.0

public:
	//-----------------------------------------------------
	// Define functions
	//-----------------------------------------------------

	//-----------------------------------------------------
	// Define variables
	//-----------------------------------------------------
	IPSAPI*		m_psapi;
	IPSAPIPicture*	m_cpPicture;
	CLogDlg		m_dlog;
	CSampleCB	m_pcallback;
	CString		m_csLog;

	long		PlayStatus;
};
