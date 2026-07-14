
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

	if(m_hLogWnd == NULL) return;

	l_pcStr	= new TCHAR[l_lMsglen+1];
	wsprintf(l_pcStr,_T("%s"), msg);
	::PostMessage(m_hLogWnd, WM_LOGGING, (UINT_PTR)l_pcStr, 0);
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
 * function			: OnPlayStatus
****************************************************************/
void CSampleListener::OnPlayStatus(long channel, long status)
{
	CString	msg;
	msg.Format(_T("[OnPlayStatus] channel[%d] status[%d]"), channel, status);
	SendMsg(msg);
}
