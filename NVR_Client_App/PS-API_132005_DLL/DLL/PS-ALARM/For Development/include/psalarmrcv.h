/********************************************************************/
/* Filename : psalarmrcv.h                                          */
/*                                                                  */
/* Date : 2008/06/03                                                */
/* Copyright (c) 2008-2009 Panasonic Corporation                    */
/********************************************************************/
#include	"ialarmrcvlistener.h"

/*------------------------------------------------------------------*/
/* Define                                                           */
/*------------------------------------------------------------------*/
#ifdef PSALARMRCV_EXPORTS
#define PSALARMRCV_API __declspec(dllexport)
#else
#define PSALARMRCV_API __declspec(dllimport)
#endif


/*------------------------------------------------------------------*/
/* IAlarmRcv Class                                                    */
/*------------------------------------------------------------------*/
class PSALARMRCV_API IAlarmRcv {
public:

	IAlarmRcv(void);

	virtual	long	SetAlarmRcvPort( long port ) = 0;
		/*------------------------------------------------------*/
		/* 0-65535 : Port number                                */
		/*------------------------------------------------------*/

	virtual long	GetAlarmRcvPort() = 0;
		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0-65535     : Port numbe                             */
		/* minus value : error code                             */
		/*------------------------------------------------------*/

	virtual	long	SetAlarmRcvListener( IAlarmRcvListener* pReceiver ) = 0;
		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0           : success                                */
		/* minus value : error code                             */
		/*------------------------------------------------------*/

	virtual long	SetErrListener( IAlarmRcvListener* pReceiver ) = 0;
		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0           : success                                */
		/* minus value : error code                             */
		/*------------------------------------------------------*/

};


/*------------------------------------------------------------------*/
/* Extern Function to handle IAlarmRcv                              */
/*------------------------------------------------------------------*/
PSALARMRCV_API IAlarmRcv* GetAlarmRcv(void);
PSALARMRCV_API void DeleteAlarmRcv(IAlarmRcv* ialarmrcv);

