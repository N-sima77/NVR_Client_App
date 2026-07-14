// SimpleSample_InternetModeLive.h : PROJECT_NAME The main header file for the application.
//

#pragma once

#ifndef __AFXWIN_H__
	#error "Please Include the 'stdafx.h' before including this file for PCH."
#endif

#include "resource.h"		// Main simbol


// CSimpleSample_InternetModeLiveApp:
// For the implementation of this class, please refer to the SimpleSample_InternetModeLive.cpp
//

class CSimpleSample_InternetModeLiveApp : public CWinApp
{
public:
	CSimpleSample_InternetModeLiveApp();

// override
	public:
	virtual BOOL InitInstance();

// Implements

	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_InternetModeLiveApp theApp;