
#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"


class CSimpleSample_OverlayApp : public CWinApp
{
public:
	CSimpleSample_OverlayApp();


	public:
	virtual BOOL InitInstance();



	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_OverlayApp theApp;