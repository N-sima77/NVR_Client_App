// SimpleSample_DecodeImage.h :main header file for the SIMPLESAMPLE_DECODEIMAGE application
//

#if !defined(AFX_SIMPLESAMPLE_DECODEIMAGE_H__8C7097B2_4675_4572_80A2_B6E241D5C773__INCLUDED_)
#define AFX_SIMPLESAMPLE_DECODEIMAGE_H__8C7097B2_4675_4572_80A2_B6E241D5C773__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CSimpleSample_DecodeImageApp:
// See SimpleSample_DecodeImage.cpp for the implementation of this class
//

class CSimpleSample_DecodeImageApp : public CWinApp
{
public:
	CSimpleSample_DecodeImageApp();

// Overrides
    // ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSimpleSample_DecodeImageApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CSimpleSample_DecodeImageApp)
        // NOTE - the ClassWizard will add and remove member functions here.
        //    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SIMPLESAMPLE_DECODEIMAGE_H__8C7097B2_4675_4572_80A2_B6E241D5C773__INCLUDED_)
