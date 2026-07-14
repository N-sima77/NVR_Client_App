
#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"


class CSimpleSample_CamOpApp : public CWinApp
{
public:
	CSimpleSample_CamOpApp();


	public:
	virtual BOOL InitInstance();



	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_CamOpApp theApp;