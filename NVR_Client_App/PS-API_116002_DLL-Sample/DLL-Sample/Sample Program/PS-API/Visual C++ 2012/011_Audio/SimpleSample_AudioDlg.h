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
class CSimpleSample_AudioDlg : public CDialog
{
public:
	CSimpleSample_AudioDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SimpleSample_Audio_DIALOG };

	CButton m_bLiveStart;
	CButton m_bLiveStop;
	CButton m_bAudioSendStart;
	CButton m_bAudioSendStop;

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

	afx_msg void LiveStart();
	afx_msg void LiveStop();
	afx_msg void AudioSendStart();
	afx_msg void AudioSendStop();

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
