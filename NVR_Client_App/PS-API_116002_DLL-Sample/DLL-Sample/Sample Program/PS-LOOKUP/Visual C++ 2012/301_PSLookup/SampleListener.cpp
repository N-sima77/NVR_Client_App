
#include "stdafx.h"
#include "SampleListener.h"

CSampleListener::CSampleListener()
{
	m_hLogWnd	=	NULL;
	m_hProcWnd	=	NULL;
}

CSampleListener::~CSampleListener()
{
	m_hLogWnd	=	NULL;
	m_hProcWnd	=	NULL;
}
/****************************************************************
 * function			: LogWndHandle
****************************************************************/
void CSampleListener::SetLogWndHandle(HWND LogWnd)
{
	if(LogWnd == NULL) return;

	m_hLogWnd = LogWnd;
}

HWND CSampleListener::GetLogWndHandle()
{
	return m_hLogWnd;

}
/****************************************************************
 * function			: SendMsg
 ****************************************************************/
void CSampleListener::SendMsg(CString msg)
{
	TCHAR*	l_pcStr		=	NULL;
	long	l_lMsglen	=	msg.GetLength();

	if(l_lMsglen == 0) return;

	if(m_hLogWnd == NULL)return;

	l_pcStr	=	new TCHAR[l_lMsglen	+	1];
	wsprintf(l_pcStr,_T("%s"), msg);
	::PostMessage(m_hLogWnd	, (WM_USER + 1), (UINT_PTR)l_pcStr, 0);
}
/****************************************************************
 * function			: ProcHandle
****************************************************************/
void CSampleListener::SetProcHandle(HWND hwnd)
{
	if(hwnd == NULL) return;

	m_hProcWnd = hwnd;

}
HANDLE CSampleListener::GetProcHandle()
{
	return m_hProcWnd;

}

//----------------------------------------------------------------
//Listener
//----------------------------------------------------------------
/****************************************************************
 * function			: OnError
****************************************************************/
void CSampleListener::OnError(long errorCode, const char* description)
{
	CString	msg;
	msg.Format(_T("[OnError] errorCode[%d] description[%s]"), errorCode, CString(description));
	SendMsg(msg);
}

/****************************************************************
 * function			: OnDevLookup
****************************************************************/
void CSampleListener::OnDevLookup(const char*  macAddr,
					const char*  ipAddr,
					const char*  ipv6Addr,
					long portNo,
					const char*  camName,
					const char*  modelName)
{
	CString Logs, LogBuf;
	Logs.Format(_T("macAddr : %s\r\nipAddr : %s\r\nipv6Addr : %s\r\nportNo : %d\r\ncamName : %s\r\nmodelName : %s"),
						CString(macAddr), CString(ipAddr), CString(ipv6Addr), portNo, CString(camName), CString(modelName));
	LogBuf.Format(_T("[OnDevLookup] %s"), Logs);
	// Send message to Log window
	SendMsg(LogBuf);

	Logs.Replace(_T("\r\n"), _T(" "));

	TCHAR*	l_pcStr		=	NULL;
	long	l_lMsglen	=	Logs.GetLength();

	l_pcStr	= new TCHAR[l_lMsglen + 1];
	wsprintf(l_pcStr, _T("%s"), Logs);

	// Send message to Main window
	::PostMessage(m_hProcWnd, WM_DEVLOOKUP, (UINT_PTR)l_pcStr, 0);
}
