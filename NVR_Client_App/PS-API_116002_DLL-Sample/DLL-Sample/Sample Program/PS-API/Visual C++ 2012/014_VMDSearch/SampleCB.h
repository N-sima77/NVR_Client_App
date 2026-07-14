#if !defined(AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_)
#define AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "psapidef.h"
#include "iapplistener.h"
#include "iappcallback.h"

class CSampleCB  :
	public IAppListener,
	public IAppCallBack
{
public:
	//Constructor/Destructor
	CSampleCB();
	virtual ~CSampleCB();

	HWND GetLogWndHandle();
	void SetLogWndHandle(HWND LogWnd);
	
	HANDLE GetProcHandle();
	void SetProcHandle(HWND hwnd);

	void SendMsg(CString msg);
	void SendParm(long wParam,long lParam);

	//Override -Listener
	void	OnError(		long error,
							LPCSTR description	);
	
	void	OnDevStatus(	long channel,
							long status			);
	
	void	OnRecStatus(	long channel,
							long status			);
	
	void	OnRecordStatus(	long type,
							LPCSTR lpcszTD,
							LPCSTR lpcszNextTD	);
	
	void	OnPlayStatus(	long channel,
							long status			);
	
	void	OnImage(		long type,
							BYTE* pBuffer,
							long size			);
	
	void	OnOpStatus(		long channel,
							long status			);
	
	void	OnAlmStatus(	long channel,
							long lType,
							LPCSTR lpcszTD,
							long status			);

	//Override -CallBack
	void	OnRecCB(		long status		);
	
	void	OnSearchCB();
	
	void	OnSearchExCB();
	
	void	OnPlayStatusCB(	long status		);
	
	void	OnOpStatusCB(	long status		);
	
	void	OnAlmStatusCB(	long status		);
	
	void	OnFtpStatusCB(	long status		);

private:
	HWND	m_hLogWnd;
	HWND	m_hProcWnd;
};

#endif // !defined(AFX_SampleCB_H__48226DA0_CF66_4CCE_BBE3_C6FAB160C3CE__INCLUDED_)
