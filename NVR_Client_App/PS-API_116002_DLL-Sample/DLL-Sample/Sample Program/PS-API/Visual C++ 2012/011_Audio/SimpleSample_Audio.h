// SimpleSample_Audio.h : main header file for the SimpleSample_Audio application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CSimpleSample_AudioApp:
// See SimpleSample_Audio.cpp for the implementation of this class
//

class CSimpleSample_AudioApp : public CWinApp
{
public:
	CSimpleSample_AudioApp();

// Overrides
	public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_AudioApp theApp;