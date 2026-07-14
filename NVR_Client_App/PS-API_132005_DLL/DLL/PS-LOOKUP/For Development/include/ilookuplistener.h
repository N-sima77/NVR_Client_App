#pragma once

/******************************************************************************************
 *  INTERFACE MODULE	PS-LOOKUP APPLICATION LISTENER INTERFACE
 ******************************************************************************************
 *
 *	UNIT:			PS-LOOKUP Application Listener Interface
 *
 *	FILE NAME:		ilookuplistener.h
 *
 *	DESCRIPTION:	PS-LOOKUP Application Listener Interface
 *
 *	INCLUDES:
 */

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
 |  PS API Application Listener Interface Class
 +--------------------------------------------------------------------------------------*/
class ILookupListener
{
public:
	virtual void	OnDevLookup(	const char*  macAddr,
									const char*  ipAddr,
									const char*  ipv6Addr,
									long  portNo,
									const char*  camName,
									const char*  modelName	) = 0;

	virtual void	OnError(	long  errorCode,
								const char*  description	) = 0;
};

