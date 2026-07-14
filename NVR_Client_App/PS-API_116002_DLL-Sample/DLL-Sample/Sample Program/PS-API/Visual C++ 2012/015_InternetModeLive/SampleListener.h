#if !defined(AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_)
#define AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include 	"psapidef.h"
#include 	"iapplistener.h"
#include 	"iappcallback.h"
#include	"LogDlg.h"

class CSampleListener  : 	public IAppListener,
							public IAppCallBack

{
public:
	//Constructor/Destructor
	CSampleListener();
	virtual ~CSampleListener();

	HWND GetLogWndHandle();
	void SetLogWndHandle(HWND LogWnd);

	HANDLE GetProcHandle();
	void SetProcHandle(HWND hwnd);

	void SendMsg(CString msg);
	
	//Override -Listener 11events and 7callbacks for PS-API
	void OnError(long  errorCode, const char* description);
	//void OnDevStatus(long channel, long status);
	//void OnRecStatus(long channel, long status);
	void OnPlayStatus(long channel, long status);
	//void OnRecordStatus(long recType, char* timeDate, long isDst, char* nextrecTime, long isDstNext);
	//void OnImage(long type, unsigned char* pBuffer, long size);
	//void OnOpStatus(long channel, long status);
	//void OnAlmStatus(long channel, long type, char* timeDate, long status);
	//void OnSaveFile(long status, char* filename);
	//void OnConvertFile(long fileNo, long progress);
	//void OnAudio(long type, unsigned char* pBuffer, long size);
	//
	//void OnRecCB(long status);
	//void OnSearchCB();
	//void OnSearchExCB();
	//void OnPlayStatusCB(long status);
	//void OnOpStatusCB(long status);
	//void OnAlmStatusCB(long status);
	//void OnFtpStatusCB(long status);
	
private:
	HWND	m_hLogWnd;
	HWND	m_hProcWnd;


};

#endif // !defined(AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_)
