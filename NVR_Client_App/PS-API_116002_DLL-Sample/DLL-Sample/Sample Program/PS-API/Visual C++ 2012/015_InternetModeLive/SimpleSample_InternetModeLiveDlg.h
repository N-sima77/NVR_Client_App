// SimpleSample_InternetModeLiveDlg.h : header file
//

#pragma once

//Include header files of PS-API
#include "psapidef.h"
#include "ipsapi.h"
#include "ipsapifileinfo.h"
#include "ipsapiftpfilelist.h"
#include "ipsapipicture.h"
#include "isearchresult.h"

//Include header files of Sample program
#include "LogDlg.h"
#include "SampleListener.h"

// CSimpleSample_InternetModeLiveDlg dialog
class CSimpleSample_InternetModeLiveDlg : public CDialog
{
// construction
public:
	CSimpleSample_InternetModeLiveDlg(CWnd* pParent = NULL);

// Dialog data
	enum { IDD = IDD_SIMPLESAMPLE_INTERNETMODELIVE_DIALOG };

enum LiveStatus {
        Start = 0,
        Live
};
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implements
protected:
	HICON m_hIcon;

	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual BOOL PreTranslateMessage(MSG* pMsg);
	DECLARE_MESSAGE_MAP()

private:
	void SetInitialControl();

	CLogDlg m_Log;
	CString m_LoggedString;
	CSampleListener m_Listener;
	IPSAPI* m_pPSAPI;
	LiveStatus m_PlayStatus;
public:
	afx_msg void OnBnClickedLivestart();
	afx_msg void OnBnClickedLiveend();
	afx_msg void OnBnClickedInternetmode();
};
