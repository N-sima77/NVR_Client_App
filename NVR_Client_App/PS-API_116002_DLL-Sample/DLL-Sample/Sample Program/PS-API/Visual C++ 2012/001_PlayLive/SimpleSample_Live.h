// SimpleSample_Live.h : main header file for the SIMPLESAMPLE_LIVE application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CSimpleSample_LiveApp:
// See SimpleSample_Live.cpp for the implementation of this class
//

class CSimpleSample_LiveApp : public CWinApp
{
public:
	CSimpleSample_LiveApp();

// Overrides
	public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_LiveApp theApp;