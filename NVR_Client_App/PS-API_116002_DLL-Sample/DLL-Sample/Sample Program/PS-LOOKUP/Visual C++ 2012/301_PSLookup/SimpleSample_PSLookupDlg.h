// SimpleSample_PSLookupDlg.h : Header file
//

#pragma once

//Include header files of Sample program
#include "LogDlg.h"
#include "pslookup.h"
#include "ilookuplistener.h"
#include "SampleListener.h"

enum SearchStatus {
        SearchOff = 0,
        SearchOn
};

// CSimpleSample_PSLookupDlg Dialog
class CSimpleSample_PSLookupDlg : public CDialog
{
// construction
public:
	CSimpleSample_PSLookupDlg(CWnd* pParent = NULL);

// Dialog data
	enum { IDD = IDD_PSLOOKUP_DIALOG };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	virtual LRESULT DefWindowProc(UINT message, WPARAM wParam, LPARAM lParam);

// Implements
protected:
	HICON m_hIcon;

	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBnClickedSearch();
	afx_msg void OnDestroy();
	virtual BOOL PreTranslateMessage(MSG* pMsg);
	DECLARE_MESSAGE_MAP()
private:
	void SetInitialControl();
	void CheckHScroll(CString AddString);
	CLogDlg m_Log;
	CSampleListener m_Listener;
	IPSLookup* m_pLookup;
	INT_PTR m_MaxLength;
    SearchStatus m_Status;



};
