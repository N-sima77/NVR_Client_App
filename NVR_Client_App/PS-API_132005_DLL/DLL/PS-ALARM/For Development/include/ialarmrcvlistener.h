/********************************************************************/
/* Filename : ialarmrcvlistener.h                                          */
/*                                                                  */
/* Date : 2008/06/03                                                */
/* Copyright (c) 2008-2009 Panasonic Corporation                    */
/********************************************************************/

#if !defined(AFX_IALARMRCVLISTENER_H__CA039D63_FF09_4D21_91BE_B99E248E1DD7__INCLUDED_)
#define AFX_IALARMRCVLISTENER_H__CA039D63_FF09_4D21_91BE_B99E248E1DD7__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class IAlarmRcvListener  
{
public:
	// Virtual function for OnAlarmRcv
	virtual void	OnAlarmRcv( const char* timeDate, 
								const char* ipaddr, 
								long channel, 
								long alarmType, 
								const char* messageID, 
								const char* messageText, 
								const char* information ) = 0;

	// Virtual function for OnError
	virtual void	OnError( long errorCode, 
							 const char* description ) = 0;
};

#endif // !defined(AFX_IALARMRCVLISTENER_H__CA039D63_FF09_4D21_91BE_B99E248E1DD7__INCLUDED_)
