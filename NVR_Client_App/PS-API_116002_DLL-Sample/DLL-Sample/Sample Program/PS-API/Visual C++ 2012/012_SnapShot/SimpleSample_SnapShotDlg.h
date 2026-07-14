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
class CSimpleSample_SnapShotDlg : public CDialog
{

public:
	CSimpleSample_SnapShotDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SIMPLESAMPLE_SNAPSHOT_DIALOG };

	CButton m_bJpegSnap;
	CButton m_bDZoom1;
	CButton m_bDZoom4;
	CButton m_bDZoomLeft;
	CButton m_bDZoomRight;
	CEdit m_eFileName;

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

	afx_msg void JpegSnapShot();
	afx_msg void DZoom1();
	afx_msg void DZoom4();
	afx_msg void DZoomLeft();
	afx_msg void DZoomRight();

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
