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

#define MAX_FILE_PATH	256


//--------------------------------------------------------------------
//Dialog
//--------------------------------------------------------------------
class CSimpleSample_LocalFilePlayDlg : public CDialog
{

public:
	CSimpleSample_LocalFilePlayDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SIMPLESAMPLE_LOCALFILEPLAY_DIALOG };

	CButton m_bPrevFrame;
	CButton m_bRewind;
	CButton m_bReverse;
	CButton m_bPause;
	CButton m_bPlayBack;
	CButton m_bFF;
	CButton m_bNextFrame;
	CButton m_bStop;
	CEdit m_eFileName;

protected:
	virtual void DoDataExchange(CDataExchange* pDX);

protected:
	HICON m_hIcon;
	DECLARE_MESSAGE_MAP()
	afx_msg HCURSOR OnQueryDragIcon();

	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	virtual BOOL OnInitDialog();
	afx_msg void OnClose();
	afx_msg void OnDestroy();
	afx_msg void OnPaint();

	afx_msg void OnPrevFrame();
	afx_msg void OnRewind();
	afx_msg void OnReverse();
	afx_msg void OnPause();
	afx_msg void OnPlayBack();
	afx_msg void OnFF();
	afx_msg void OnNextFrame();
	afx_msg void OnStop();

public:
	//-----------------------------------------------------
	// Define functions
	//-----------------------------------------------------

	//-----------------------------------------------------
	// Define variables
	//-----------------------------------------------------
	IPSAPI*		m_psapi;
	CLogDlg		m_dlog;
	CSampleCB	m_pcallback;
	CString		m_csLog;
	CFont*		m_pFont;

	long		PlayStatus;
};
