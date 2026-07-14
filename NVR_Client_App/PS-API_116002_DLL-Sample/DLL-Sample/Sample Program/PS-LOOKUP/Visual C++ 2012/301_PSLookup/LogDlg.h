#pragma once

#include "resource.h"

// CLogDlg Dialog

/////////////////////////////////////////////////////////////////////////////

#define		WM_LOGGING		(WM_USER + 1)
#define		WM_DEVLOOKUP	(WM_USER + 2)

class CLogDlg : public CDialog
{
//	DECLARE_DYNAMIC(CLogDlg)

public:
	CLogDlg(CWnd* pParent = NULL);   // construction
	virtual ~CLogDlg();

// Dialog data
	enum { IDD = IDD_LOG_DIALOG };

	virtual LRESULT DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam);
	long Logging(CString str);

protected:
	HICON m_hIcon;

	virtual BOOL OnInitDialog();
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual BOOL PreTranslateMessage(MSG* pMsg);
	DECLARE_MESSAGE_MAP()

private:
	void SetInitialControl();
};
