// SimpleSample_PSLookup.h : PROJECT_NAME アプリケーションのメイン ヘッダー ファイルです。
//

#pragma once

#ifndef __AFXWIN_H__
	#error "PCH に対してこのファイルをインクルードする前に 'stdafx.h' をインクルードしてください"
#endif

#include "resource.h"		// メイン シンボル


// CSimpleSample_PSLookupApp:
// このクラスの実装については、SimpleSample_PSLookup.cpp を参照してください。
//

class CSimpleSample_PSLookupApp : public CWinApp
{
public:
	CSimpleSample_PSLookupApp();

// オーバーライド
	public:
	virtual BOOL InitInstance();

// 実装

	DECLARE_MESSAGE_MAP()
};

extern CSimpleSample_PSLookupApp theApp;