#if !defined(AFX_LOGDLG_H__D3280E27_21D2_473F_A4D7_3042E7275303__INCLUDED_)
#define AFX_LOGDLG_H__D3280E27_21D2_473F_A4D7_3042E7275303__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "resource.h"

/////////////////////////////////////////////////////////////////////////////

#define		WM_LOGGING		(WM_USER + 1)
#define		WM_RCVALARM		(WM_USER + 2)

/////////////////////////////////////////////////////////////////////////////
// CLogDlg Dialog

class CLogDlg : public CDialog
{
// Constructor
public:
    CLogDlg(CWnd* pParent = NULL);   // Default constructor 
    long Logging(CString str);

// Dialog Data
    //{{AFX_DATA(CLogDlg)
	enum { IDD = IDD_LOG };
	CEdit	m_eLog;
	//}}AFX_DATA


// Override
    // ClassWizard generated virtual function overrides.
    //{{AFX_VIRTUAL(CLogDlg)
	protected:
    virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual LRESULT DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam);
	//}}AFX_VIRTUAL

// implementation
protected:

    // Generated message map functions
    //{{AFX_MSG(CLogDlg)
        // ClassWizard will add member functions here
    virtual void OnOK();
    virtual void OnCancel();
    //}}AFX_MSG
    DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
//Microsoft Visual C++ will insert additional declarations immediately before the previous line.


#endif // !defined(AFX_LOGDLG_H__D3280E27_21D2_473F_A4D7_3042E7275303__INCLUDED_)
