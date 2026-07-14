
#pragma once

#include "stdafx.h"

const TCHAR QUOTATIONMARK[] = {0x22, 0x00};
const TCHAR DOUBLEQUOTATIONMARK[] = {0x22, 0x22, 0x00};

#define	CSVERR_NOERROR					(0)				// エラーなし
#define	CSVERR_EDITSTRNONE				(-1)			// 編集する文字列無し
#define	CSVERR_DELIMITERNONE			(-2)			// 検索する区切り文字無し
#define	CSVERR_PARAMFAIL				(-3)			// パラメータが不正
#define	CSVERR_POSNONE					(-4)			// 指定の位置は存在しない
#define CSVERR_COPYERR					(-5)			// 文字列のコピーに失敗

typedef CMap<INT_PTR, INT_PTR, CString, CString&>	CsvStringArray;

// CCSVEdit クラス : 区切り文字で区切られた文字列の編集を行う(プロジェクトの指定によってANSI/Unicodeで動作可能とする)
class CCSVEdit
{
public:
	// コンストラクタ
	CCSVEdit();
	CCSVEdit(CString Ed, CString De = _T(","), bool Qu = true);
	CCSVEdit(LPTSTR Ed, LPCTSTR De = NULL,  bool Qu = true);
	// デストラクタ
	virtual ~CCSVEdit();

	// 編集する文字列を設定する
	INT_PTR SetEditString(CString Ed);
	INT_PTR SetEditString(LPCTSTR Ed);
	// 編集する文字列を取得する
	INT_PTR GetEditString(CString& Ed);
	INT_PTR GetEditString(LPTSTR Ed);
	// 編集する文字列の文字列長を取得する
	INT_PTR GetEditStringLength();
	// 区切り文字を設定する
	INT_PTR SetDelimiter(CString De);
	INT_PTR SetDelimiter(LPCTSTR De);
	// 区切り文字を取得する
	INT_PTR GetDelimiter(CString& De);
	INT_PTR GetDelimiter(LPTSTR De);
	// 区切り文字の文字列長を取得する
	INT_PTR GetDelimiterLength();
	// 記号の有効/無効を設定する
	void SetQuotationMark(const bool Qu) { Quote = Qu; }
	// QuotationMark記号の有効/無効を取得する
	void GetQuotationMark(bool& Qu) { Qu = Quote; }
	// 指定の区切り文字で区切られたデータ数を返す(最低は1)
	INT_PTR GetCSVDataCount();
	// 編集する文字列を区切り文字のみで初期化する
	INT_PTR InitialString(INT_PTR Count);
	// 指定の位置に文字列を挿入する(左から1,2,3と数える)
	INT_PTR SetPosString(CString Val, INT_PTR MarkCount);
	INT_PTR SetPosString(LPCTSTR Val, INT_PTR MarkCount);
	INT_PTR SetPosString(CsvStringArray& Val); 
	// 指定の位置の文字列を取得する(左から1,2,3と数える)
	INT_PTR GetPosString(CString& Val, INT_PTR MarkCount);
	INT_PTR GetPosString(LPTSTR Val, INT_PTR MarkCount);
	INT_PTR GetPosString(CsvStringArray& Val);
	// 指定の位置の文字列長を取得する
	INT_PTR GetPosStringLength(INT_PTR MarkCount);

private:
	// 指定の文字列からQMarkを除去する
	CStringW DelQuoteMark(CString Src);
	// 指定の文字列にQMarkを付与する
	CStringW AddQuoteMark(CString Src);
	// 区切り文字の位置を検索する＆区切り文字の数を検索する
	INT_PTR SearchDelimiterPosition(int& StartPos, INT_PTR SearchCount = 0xFFFF);

	CString EditStr;							// 編集する文字列(空文字可)
	CString Delimiter;							// 編集で使用する区切り文字(空文字不可)
	bool Quote;									// QMarkの使用の有無
};
