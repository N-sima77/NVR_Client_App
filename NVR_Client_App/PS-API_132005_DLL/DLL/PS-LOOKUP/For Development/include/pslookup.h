#pragma once

#ifdef LOOKUP_EXPORTS
#define LOOKUP_API __declspec(dllexport)
#else
#define LOOKUP_API __declspec(dllimport)
#endif

/******************************************************************************************
 *  INTERFACE MODULE	PS-LOOKUP DLL
 ******************************************************************************************
 *
 *	UNIT:			PS-LOOKUP DLL Interface
 *
 *	FILE NAME:		pslookup.h
 *
 *	DESCRIPTION:	PS-LOOKUP DLL Interface
 *
 *	INCLUDES:
 */

					#include "ilookuplistener.h"

/*
 *	NAMESPACE:
 */

/*
 *	NOTES:
 *
 *  REV HIST:
 * 
 *	Name		Date		Reason
 *	---------------------------------------------------------------------------------------
 *  PSN         05/16/11    Created
 *
 ******************************************************************************************
 *  COPYRIGHT:		Panasonic System Networks Co., Ltd. 2011
 *****************************************************************************************/

/*----------------------------------------------------------------------------------------
 |  PS API Interface Class
 +--------------------------------------------------------------------------------------*/
class LOOKUP_API IPSLookup {

public:
	IPSLookup(void){};
	virtual ~IPSLookup(){};

	virtual long	SetDevLookupListener ( ILookupListener*  pReceiver ) = 0;
		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0           : success                                */
		/* minus value : error code                             */
		/*------------------------------------------------------*/

	virtual long	SetErrListener ( ILookupListener*  pReceiver ) = 0;
		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0           : success                                */
		/* minus value : error code                             */
		/*------------------------------------------------------*/
	virtual long	SetDestSubnet( long id, long masksize, char *ipaddress ) = 0;

		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0           : success                                */
		/* minus value : error code                             */
		/*------------------------------------------------------*/
	virtual long	GetDestSubnet( long id, long &masksize, char *ipaddress, long ipaddress_size ) = 0;
		/*------------------------------------------------------*/
		/* Return value                                         */
		/* 0           : success                                */
		/* minus value : error code                             */
		/*------------------------------------------------------*/


};

/*------------------------------------------------------------------*/
/* Function to handle IPSLookup                                     */
/*------------------------------------------------------------------*/
LOOKUP_API IPSLookup* GetIPSLookup();
LOOKUP_API void DeleteIPSLookup( IPSLookup* );

