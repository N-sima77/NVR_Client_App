
#include "stdafx.h"
#include "SampleCB.h"

CSampleCB::CSampleCB()
{
	m_hLogWnd	=	NULL;
	m_hProcWnd	=	NULL;
	m_lSaveSuffix = 0;
}

CSampleCB::~CSampleCB()
{
	m_hLogWnd	=	NULL;
	m_hProcWnd	=	NULL;
}
/****************************************************************
 * function			: LogWndHandle
****************************************************************/
void CSampleCB::SetLogWndHandle(HWND LogWnd)
{
	if(LogWnd == NULL) return;

	m_hLogWnd = LogWnd;
}

HWND CSampleCB::GetLogWndHandle()
{
	return m_hLogWnd;

}

/****************************************************************
 * function			: ProcHandle
****************************************************************/
void CSampleCB::SetProcHandle(HWND hwnd)
{
	if(hwnd == NULL) return;

	m_hProcWnd = hwnd;

}

HANDLE CSampleCB::GetProcHandle()
{
	return m_hProcWnd;

}

/****************************************************************
 * function			: SendMsg
 ****************************************************************/
void CSampleCB::SendMsg(CString msg)
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
 * function			: SendParm
****************************************************************/
void CSampleCB::SendParm(long wParam, long lParam)
{
	if(m_hProcWnd	==	NULL)return;

	::PostMessage(m_hProcWnd,	(WM_USER + 2),	wParam,	lParam);
}

/****************************************************************
 * function			: SetFolderName
****************************************************************/
void CSampleCB::SetFolderName(CString folderName)
{
	if(m_pcFolderName != NULL)
	{
		m_pcFolderName = NULL;
	}
	m_pcFolderName = new char[folderName.GetLength() + 1];
	strcpy_s(m_pcFolderName, folderName.GetLength() + 1,folderName);

	CreateDirectory(m_pcFolderName, NULL);
}

/****************************************************************
 * function			: SetFileName
****************************************************************/
void CSampleCB::SetFileName(CString fileName)
{
	if(m_pcFileName != NULL)
	{
		m_pcFileName = NULL;
	}
	m_pcFileName = new char[fileName.GetLength() + 1];
	strcpy_s(m_pcFileName, fileName.GetLength() + 1, fileName);

}

/****************************************************************
 * function			: ClearNumber
****************************************************************/
void CSampleCB::ClearNumber()
{
	m_lSaveSuffix = 0;
}

//----------------------------------------------------------------
//Listener
//----------------------------------------------------------------
/****************************************************************
 * function			: OnError
****************************************************************/
void CSampleCB::OnError(long error, LPCSTR description)
{
	CString	msg;
	msg.Format("[OnError] error[%d] description[%s]",error, description);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnDevStatus
****************************************************************/
void CSampleCB::OnDevStatus(long channel, long status)
{
	CString	msg;
	msg.Format("[OnDevStatus] channel[%d] status[%d]",channel, status);
	SendMsg(msg);

}

/****************************************************************
 * function			: OnRecStatus
****************************************************************/
void CSampleCB::OnRecStatus(long channel, long status)
{
	CString	msg;
	msg.Format("[OnRecStatus] channel[%d] status[%d]",channel, status);
	SendMsg(msg);

}

/****************************************************************
 * function			: OnRecordStatus
****************************************************************/
void CSampleCB::OnRecordStatus(long  type,
							   LPCSTR  lpcszTD, 
							   LPCSTR lpcszNextTD)
{
	CString	msg;
	msg.Format("[OnRecordStatus] type[%d] lpcszTD[%s] lpcszTD[%s]", type, lpcszTD, lpcszNextTD);
	SendMsg(msg);

}

/****************************************************************
 * function			: OnPlayStatus
****************************************************************/
void CSampleCB::OnPlayStatus(long channel, long status)
{
	CString	msg;
	msg.Format("[OnPlayStatus] channel[%d] status[%d]",channel, status);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnImage
****************************************************************/
void CSampleCB::OnImage(long type, BYTE* pBuffer, long size)
{
	CString	msg;

	char FileName[256];
	HANDLE hImageFile;
	DWORD dwWriteSize;

	long lMaxFile = 100;

	if(m_lSaveSuffix == 0)
	{
		msg.Format("[OnImage] Type[%d] Size[%d byte] Start", type, size);
		SendMsg(msg);
	}
	else if(m_lSaveSuffix == lMaxFile)
	{
		msg.Format("[OnImage] Type[%d] Size[%d byte] * %d", type,size, m_lSaveSuffix);
		SendMsg(msg);
		m_lSaveSuffix++;
	}

	if(m_lSaveSuffix < lMaxFile){
		memset(FileName, 0, 256);

		wsprintf(FileName, "%s\\%s.%03d", m_pcFolderName, m_pcFileName, m_lSaveSuffix);

		//Write to a file
		hImageFile = CreateFile(FileName, GENERIC_WRITE, FILE_SHARE_READ, NULL, CREATE_ALWAYS,
									FILE_ATTRIBUTE_NORMAL, NULL);
		if(hImageFile == INVALID_HANDLE_VALUE) return;
		WriteFile(hImageFile, pBuffer, size, &dwWriteSize, NULL);
		m_lSaveSuffix++;
		
		CloseHandle(hImageFile);
		hImageFile = INVALID_HANDLE_VALUE;

	}
}

/****************************************************************
 * function			: OnOpStatus
****************************************************************/
void CSampleCB::OnOpStatus(long channel, long status)
{
	CString	msg;
	msg.Format("[OnOpStatus] channel[%d] status[%d]",channel, status);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnAlarmStatus
****************************************************************/
void CSampleCB::OnAlmStatus(long  channel,
							long  type, 
							LPCSTR lpcszTD, 
							long  status)
{
	CString	msg;
	msg.Format("[OnAlmStatus] channel[%d] type[%d] lpcszTD[%s] status[%d]", channel, type, lpcszTD, status);
	SendMsg(msg);
}


//----------------------------------------------------------------
//CallBack
//----------------------------------------------------------------
/****************************************************************
 * function			: OnRecCB
****************************************************************/
void CSampleCB::OnRecCB(long status)
{
	CString	msg;
	msg.Format("[OnRecCB] status[%d])",status);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnSearchCB
****************************************************************/
void CSampleCB::OnSearchCB( )
{
	//Logging
	CString	msg;
	msg.Format("[OnSearchCB] Show Search result.");
	SendMsg(msg);

	//Proc
	SendParm(0,0);
}

/****************************************************************
 * function			: OnSearchExCB
****************************************************************/
void CSampleCB::OnSearchExCB( )
{
	//Logging
	CString	msg;
	msg.Format("[OnSearchExCB] Show Search result.");
	SendMsg(msg);

	//Proc
	SendParm(1,0);
}

/****************************************************************
 * function			: OnPlayStatusCB
****************************************************************/
//PlayCallBack
void CSampleCB::OnPlayStatusCB(long status)
{
	CString	msg;
	msg.Format("[OnPlayStatusCB] status[%d])",status);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnOPStatusCB
****************************************************************/
void CSampleCB::OnOpStatusCB(long status)
{
	CString	msg;
	msg.Format("[OnOpStatusCB] status[%d])",status);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnAlarmStatusCB
****************************************************************/
void CSampleCB::OnAlmStatusCB(long  status)
{
	CString	msg;
	msg.Format("[OnAlmStatusCB] status[%d])",status);
	SendMsg(msg);
}

/****************************************************************
 * function			: OnFtpStatusCB
****************************************************************/
void CSampleCB::OnFtpStatusCB(long status)
{
	CString	msg;
	msg.Format("[OnFtpStatusCB] status[%d])",status);
	SendMsg(msg);
}




