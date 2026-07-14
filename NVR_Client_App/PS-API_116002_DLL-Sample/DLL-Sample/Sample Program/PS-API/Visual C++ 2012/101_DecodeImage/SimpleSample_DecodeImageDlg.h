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
#define DECODEIMAGE		2

#define WM_CB_PROC	(WM_USER + 2)

//--------------------------------------------------------------------
//Dialog
//--------------------------------------------------------------------
class CSimpleSample_DecodeImageDlg : public CDialog
{
public:
	CSimpleSample_DecodeImageDlg(CWnd* pParent = NULL);	// Default constructor

	enum { IDD = IDD_SIMPLESAMPLE_DECODEIMAGE_DIALOG };

	CStatic	m_lblFrameType;
	CStatic	m_lblFrameTime;
	CButton	m_grpImageHeader;
	CStatic	m_lblFileName;
	CStatic	m_lblFolderName;
	CEdit	m_eFrameType;
	CEdit	m_eFrameTime;
	CEdit	m_eFileName;
	CEdit	m_eFolderName;
	CStatic	m_lblView;
	CButton	m_bStop;
	CButton	m_bSaveFile;
	CButton	m_bDecodeImage;
	CString	m_sFolderName;
	CString	m_sFileName;
	CString	m_sFrameTime;
	CString	m_sFrameType;
	CString	m_slblView;

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

	afx_msg void On_SaveFile();
	afx_msg void OnStop();
	afx_msg void OnDecodeImage();

public:
	//-----------------------------------------------------
	// Define functions
	//-----------------------------------------------------
	long	StartLive();
	long	StopLive();

	//-----------------------------------------------------
	// Define variables
	//-----------------------------------------------------
	IPSAPI		*m_psapi;
	CLogDlg		m_dlog;
	CSampleCB	m_pcallback;
	CString		m_csLog;

	long		PlayStatus;

	CString		m_csOutputFileName;
	long		m_lDrawSuffix;
};
