#if !defined(AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_)
#define AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include	"ialarmrcvlistener.h"
#include	"LogDlg.h"

class CSampleListener  : public IAlarmRcvListener
{
public:
	//Constructor/Destructor
	CSampleListener();
	virtual ~CSampleListener();

	HWND GetLogWndHandle();
	void SetLogWndHandle(HWND LogWnd);

	void SendMsg(CString msg);

	HANDLE GetProcHandle();
	void SetProcHandle(HWND hwnd);
	
	//Override -Listener
	void	OnAlarmRcv( const char* timeDate, 
						const char* ipaddr, 
						long channel, 
						long alarmType, 
						const char* messageID, 
						const char* messageText, 
						const char* information );

	void	OnError( long errorCode, 
					 const char* description );
private:
	HWND	m_hLogWnd;
	HWND	m_hProcWnd;


};

#endif // !defined(AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_)
