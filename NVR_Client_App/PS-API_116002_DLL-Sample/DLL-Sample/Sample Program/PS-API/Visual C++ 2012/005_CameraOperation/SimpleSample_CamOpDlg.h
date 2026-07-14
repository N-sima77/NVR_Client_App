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
class CSimpleSample_CamOpDlg : public CDialog
{

public:
	CSimpleSample_CamOpDlg(CWnd* pParent = NULL);

	enum { IDD = IDD_SIMPLESAMPLE_CAMOP_DIALOG };

	CButton m_bGetCamPos;
	CButton m_bSetCamPos;
	CButton m_bSetCamPos2;
	CButton m_bNoOpe;
	CButton m_bAutoT;
	CButton m_bAutoP;
	CButton m_bAutoF;
	CButton m_bSetPreset;
	CButton m_bCallPreset;
	CButton m_bDeletePreset;

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

	afx_msg void GetCameraPosition();
	afx_msg void SetCameraPosition();
	afx_msg void SetCameraPosition2();
	afx_msg void OnNoOpe();
	afx_msg void OnAutoT();
	afx_msg void OnAutoP();
	afx_msg void OnAutoF();
	afx_msg void SetPreset();
	afx_msg void CallPreset();
	afx_msg void DeletePreset();

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
