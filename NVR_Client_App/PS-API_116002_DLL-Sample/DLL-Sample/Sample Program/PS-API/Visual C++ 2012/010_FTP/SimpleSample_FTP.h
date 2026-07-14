// SimpleSample_Search.h : main header file for the SimpleSample_Search application
//

#if !defined(AFX_SimpleSample_Search_H__47D41A5C_765D_42DA_BD5E_62E7A8C927F2__INCLUDED_)
#define AFX_SimpleSample_Search_H__47D41A5C_765D_42DA_BD5E_62E7A8C927F2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"       // main symbols

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_SearchApp:
// See SimpleSample_Search.cpp for the implementation of this class
//

class CSimpleSample_SearchApp : public CWinApp
{
public:
    CSimpleSample_SearchApp();

// Overrides
    // ClassWizard generated virtual function overrides
    //{{AFX_VIRTUAL(CSimpleSample_SearchApp)
    public:
    virtual BOOL InitInstance();
    //}}AFX_VIRTUAL

// Implementation

    //{{AFX_MSG(CSimpleSample_SearchApp)
        // NOTE - the ClassWizard will add and remove member functions here.
        //    DO NOT EDIT what you see in these blocks of generated code !
    //}}AFX_MSG
    DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SimpleSample_Search_H__47D41A5C_765D_42DA_BD5E_62E7A8C927F2__INCLUDED_)
