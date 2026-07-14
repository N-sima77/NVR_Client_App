
#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
    #endif

#include "resource.h"


class CSimpleSample_VMDSearchApp : public CWinApp
{
public:
	CSimpleSample_VMDSearchApp();


	public:
	virtual BOOL InitInstance();



	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_VMDSearchApp theApp;
