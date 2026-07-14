// SimpleSample_CamCtrl.h : main header file for the SIMPLESAMPLE_LIVE application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CSimpleSample_CamCtrlApp:
// See SimpleSample_Live.cpp for the implementation of this class
//

class CSimpleSample_CamCtrlApp : public CWinApp
{
public:
	CSimpleSample_CamCtrlApp();

// Overrides
	public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_CamCtrlApp theApp;