
#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
    #endif

#include "resource.h"



class CSimpleSample_PlayApp : public CWinApp
{
public:
	CSimpleSample_PlayApp();


	public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_PlayApp theApp;
