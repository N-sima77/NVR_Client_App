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
class CSimpleSample_CamCtrlDlg : public CDialog
{

public:
	CSimpleSample_CamCtrlDlg(CWnd* pParent = NULL);	// Default constructor

	enum { IDD = IDD_SIMPLESAMPLE_CAMCTRL_DIALOG };

	CButton m_bLeft;
	CButton m_bRight;
	CButton m_bUp;
	CButton m_bDown;
	CButton m_bTele;
	CButton m_bWide;
	CButton m_bOpen;
	CButton m_bClose;
	CButton m_bStop;
	CEdit m_ePanTilt;
	CEdit m_eZoom;
	CEdit m_eIris;

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

	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnMButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnRButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnMButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);

	afx_msg void PanTilt_Left();
	afx_msg void PanTilt_Right();
	afx_msg void PanTilt_Up();
	afx_msg void PanTilt_Down();
	afx_msg void Zoom_Tele();
	afx_msg void Zoom_Wide();
	afx_msg void Iris_Open();
	afx_msg void Iris_Close();
	afx_msg void OnStop();

public:
	//-----------------------------------------------------
	// Define functions
	//-----------------------------------------------------
	void MouseDown(long x, long y);
	void MouseUp(long x, long y);

	//-----------------------------------------------------
	// Define variables
	//-----------------------------------------------------
	IPSAPI*		m_psapi;
	CLogDlg		m_dlog;
	CSampleCB	m_pcallback;
	CString		m_csLog;

	long		PlayStatus;
	CButton m_ckCenterMode;
};
