// SimpleSample_PanasonicAlarmDlg.h
//

#if !defined(AFX_SIMPLESAMPLE_PANASONICALARMDLG_H__620426A4_7F8C_4670_B23E_409F52557A77__INCLUDED_)
#define AFX_SIMPLESAMPLE_PANASONICALARMDLG_H__620426A4_7F8C_4670_B23E_409F52557A77__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "resource.h"

#include "psalarmrcv.h"
#include "ialarmrcvlistener.h"

#include "SampleListener.h"
#include "LogDlg.h"

#define		LIST_COUNT_MAX		1000

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_PanasonicAlarmDlg

class CSimpleSample_PanasonicAlarmDlg : public CDialog
{
public:
	CSimpleSample_PanasonicAlarmDlg(CWnd* pParent = NULL);

	//{{AFX_DATA(CSimpleSample_PanasonicAlarmDlg)
	enum { IDD = IDD_PSALARM_DIALOG };
	CListBox	m_RcvAlarmList;
	long	m_lAlarmPort;
	//}}AFX_DATA

	//{{AFX_VIRTUAL(CSimpleSample_PanasonicAlarmDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	virtual LRESULT DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam);
	//}}AFX_VIRTUAL


public:
	//-----------------------------------------------------
	// Define variables
	//-----------------------------------------------------
	IAlarmRcv*			m_psalarm;
	CLogDlg				m_dlog;
	CSampleListener		m_plistener;
	CString				m_csLog;
	
protected:
	HICON m_hIcon;

	// Message map
	//{{AFX_MSG(CSimpleSample_PanasonicAlarmDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnStart();
	afx_msg void OnStop();
	afx_msg void OnListClick();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}

#endif // !defined(AFX_SIMPLESAMPLE_PANASONICALARMDLG_H__620426A4_7F8C_4670_B23E_409F52557A77__INCLUDED_)
