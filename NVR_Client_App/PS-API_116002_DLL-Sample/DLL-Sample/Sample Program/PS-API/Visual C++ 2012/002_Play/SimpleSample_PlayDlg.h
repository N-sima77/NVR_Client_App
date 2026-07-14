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
class CSimpleSample_PlayDlg : public CDialog
{
public:
	CSimpleSample_PlayDlg(CWnd* pParent = NULL);

	// Dialog Data
	enum { IDD = IDD_SIMPLESAMPLE_PLAY_DIALOG };

	CButton m_bPrevFrame;
	CButton m_bRewind;
	CButton m_bReverse;
	CButton m_bPause;
	CButton m_bPlayBack;
	CButton m_bFF;
	CButton m_bNextFrame;
	CButton m_bStop;
	CButton m_bNextRec;
	CButton m_bPrevRec;

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

	afx_msg void PrevFrame();
	afx_msg void Rewind();
	afx_msg void Reverse();
	afx_msg void Pause();
	afx_msg void PlayBack();
	afx_msg void FF();
	afx_msg void NextFrame();
	afx_msg void Stop();
	afx_msg void NextRecord();
	afx_msg void PrevRecord();
	afx_msg void OnBnClickedCheck();	// Added Ver5.0.1.0
	
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

	long		PlayStatus;
};
