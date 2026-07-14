#pragma once
#include "afxwin.h"


#define WM_LOGGING	(WM_USER + 1)

// CLogDlg Dialog

class CLogDlg : public CDialog
{
	DECLARE_DYNAMIC(CLogDlg)

public:
	CLogDlg(CWnd* pParent = NULL);   // Default constructor
	virtual ~CLogDlg();

	long Logging(CString str);

// Dialog Data
	enum { IDD = IDD_LOG };

	CEdit m_eLog;
	virtual LRESULT DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam);

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	DECLARE_MESSAGE_MAP()
};
