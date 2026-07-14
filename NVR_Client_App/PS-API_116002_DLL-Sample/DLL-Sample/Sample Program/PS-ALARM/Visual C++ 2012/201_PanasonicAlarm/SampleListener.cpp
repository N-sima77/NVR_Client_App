
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
	char*	l_pcStr		=	NULL;
	long	l_lMsglen	=	msg.GetLength();

	if(l_lMsglen	==	0)return;

	if(m_hLogWnd		==	NULL)return;

	l_pcStr	=	new char[l_lMsglen	+	1];
	wsprintf(l_pcStr,"%s",msg);
	::PostMessage(m_hLogWnd	,	(WM_USER + 1)	,	(UINT)l_pcStr	,	0);
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
void CSampleListener::OnError( long errorCode, 
							   const char* description )
{
	CString	msg;
	msg.Format("[Event]OnError errorCode[%d] description[%s]",errorCode,description);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnDeviceStatus
****************************************************************/
void CSampleListener::OnAlarmRcv(const char* timeDate, 
								 const char* ipaddr, 
								 long channel, 
								 long alarmType, 
								 const char* messageID, 
								 const char* messageText, 
								 const char* information )
{
	CString strLogBuf;
	strLogBuf.Format("[OnAlarmRcv]\ntimeDate : %s, \nipaddr : %s, \nchannel : %d, \nalarmType : %d, \nmessageID : %s, \nmessageText : %s", timeDate, ipaddr, channel, alarmType, messageID, messageText);

	// Send message to Log window
	SendMsg(strLogBuf);

	CString strListBuf;
	strListBuf.Format("timeDate [%s]\nipaddr [%s]\nchannel [%d]\nalarmType [%d]\nmessageID [%s]\nmessageText [%s]\ninformation\n----------------\n%s", timeDate, ipaddr, channel, alarmType, messageID, messageText,information);

	char*	l_pcStr		=	NULL;
	long	l_lMsglen	=	strListBuf.GetLength();

	l_pcStr	= new char[l_lMsglen + 1];
	wsprintf(l_pcStr,"%s",strListBuf);

	// Send message to Main window
	::PostMessage(m_hProcWnd, WM_RCVALARM, (UINT)l_pcStr, 0);
}
