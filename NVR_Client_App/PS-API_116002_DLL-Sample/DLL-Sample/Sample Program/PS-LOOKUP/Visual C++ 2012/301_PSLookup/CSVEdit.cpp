
#include "stdafx.h"
#include "CSVEdit.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

/// <summary>
/// コンストラクタ-1/オブジェクトの作成を行う
/// </summary>
CCSVEdit::CCSVEdit()
{
	EditStr.Empty();
	Delimiter = _T(",");
	Quote = true;
}
/// <summary>
/// コンストラクタ-2/オブジェクトの作成を行う
/// </summary>
/// <param name="Ed">(I) CSV編集を行う文字列</param>
/// <param name="De">(I) 区切り文字列:Default ","</param>
/// <param name="Qu">(I) QuotationMarkの使用の有無:Default true</param>
CCSVEdit::CCSVEdit(CString Ed, CString De, bool Qu)
{
	SetEditString(Ed);
	if (SetDelimiter(De) != CSVERR_NOERROR) {
		SetDelimiter(_T(","));
	}
	Quote = Qu;
}
/// <summary>
/// コンストラクタ-3/オブジェクトの作成を行う(登録エラーの場合デフォルト値で設定)
/// </summary>
/// <param name="Ed">(I) CSV編集を行う文字列バッファ:Default ""</param>
/// <param name="De">(I) 区切り文字列バッファ:Default ","</param>
/// <param name="Qu">(I) QuotationMarkの使用の有無:Default true</param>
CCSVEdit::CCSVEdit(LPTSTR Ed, LPCTSTR De, bool Qu)
{
	if (SetEditString(Ed) != CSVERR_NOERROR) {
		SetEditString(_T(""));
	}
	if (SetDelimiter(De) != CSVERR_NOERROR) {
		SetDelimiter(_T(","));
	}
	Quote = Qu;
}

/// <summary>
/// デストラクタ/オブジェクトの破棄を行う
/// </summary>
CCSVEdit::~CCSVEdit()
{
	EditStr.Empty();
	Delimiter.Empty();
}

/// <summary>
/// SetEditString-1/編集する文字列を設定する
/// </summary>
/// <param name="Ed">(I) CSV編集を行う文字列</param>
/// <returns>[INT_PTR] 0:データ設定成功 -3:引数指定エラー</returns>
INT_PTR CCSVEdit::SetEditString(CString Ed)
{
	EditStr = Ed;
	EditStr.FreeExtra();
	return CSVERR_NOERROR;
}
/// <summary>
/// SetEditString-2/編集する文字列を設定する
/// </summary>
/// <param name="Ed">(I) CSV編集を行う文字列バッファ</param>
/// <returns>[INT_PTR] 0:データ設定成功 -3:引数指定エラー</returns>
INT_PTR CCSVEdit::SetEditString(LPCTSTR Ed)
{
	if (Ed == NULL) return CSVERR_PARAMFAIL;	// 引数指定エラー
	return SetEditString(CString(Ed));
}

/// <summary>
/// GetEditString-1/編集する文字列を取得する
/// </summary>
/// <param name="Ed">(O) CSV編集を行う文字列</param>
/// <returns>[INT_PTR] 0:データ取得成功 -3:引数指定エラー</returns>
INT_PTR CCSVEdit::GetEditString(CString& Ed)
{
	Ed = EditStr;
	return CSVERR_NOERROR;
}
/// <summary>
/// GetEditString-2/編集する文字列を取得する
/// </summary>
/// <param name="Ed">(O) CSV編集を行う文字列のバッファ</param>
/// <returns>[INT_PTR] 0:データ取得成功 -3:引数指定エラー -5:データ取得失敗</returns>
INT_PTR CCSVEdit::GetEditString(LPTSTR Ed)
{	
	if (Ed == NULL) return CSVERR_PARAMFAIL;	// 引数指定エラー
	errno_t err = _tcsncpy_s(Ed, EditStr.GetLength(), static_cast<LPCTSTR>(EditStr), _TRUNCATE);
	if (err == CSVERR_NOERROR) return CSVERR_NOERROR;
	else					   return CSVERR_COPYERR;
}

/// <summary>
/// GetEditStringLength/編集する文字列の文字列長を取得する
/// </summary>
/// <returns>[INT_PTR] 編集する文字列の文字列長</returns>
INT_PTR CCSVEdit::GetEditStringLength()
{
	return EditStr.GetLength();
}

/// <summary>
/// SetDelimiter-1/区切り文字を設定する
/// </summary>
/// <param name="De">(I) 設定する区切り文字列</param>
/// <returns>[INT_PTR] 0:データ設定成功 -3:引数指定エラー</returns>
INT_PTR CCSVEdit::SetDelimiter(CString De)
{
	if (De.GetLength() <= 0) return CSVERR_PARAMFAIL;
	Delimiter = De;
	return CSVERR_NOERROR;
}
/// <summary>
/// SetDelimiter-2/区切り文字を設定する
/// </summary>
/// <param name="De">(I) 区切り文字列のバッファ</param>
/// <returns>[INT_PTR] 0:データ設定成功 -3:引数指定エラー</returns>
INT_PTR CCSVEdit::SetDelimiter(LPCTSTR De)
{
	if (De == NULL) return CSVERR_PARAMFAIL;
	return SetDelimiter(CString(De));
}

/// <summary>
/// GetDelimiter-1/区切り文字を取得する
/// </summary>
/// <param name="Ed">(O) 取得した区切り文字列</param>
/// <returns>[INT_PTR] 0:データ取得成功 -5:データ取得失敗</returns>
INT_PTR CCSVEdit::GetDelimiter(CString& De)
{
	De = Delimiter;
	return CSVERR_NOERROR;
}
/// <summary>
/// GetDelimiter-2/区切り文字を取得する
/// </summary>
/// <param name="Ed">(O) 取得した区切り文字列のバッファ</param>
/// <returns>[INT_PTR] 0:データ取得成功 -3:引数指定エラー -5:データ取得失敗</returns>
INT_PTR CCSVEdit::GetDelimiter(LPTSTR De)
{
	if (De == NULL) return CSVERR_PARAMFAIL;
	errno_t err = _tcsncpy_s(De, Delimiter.GetLength(), static_cast<LPCTSTR>(Delimiter), _TRUNCATE);
	if (err == CSVERR_NOERROR) return CSVERR_NOERROR;
	else					   return CSVERR_COPYERR;
}

/// <summary>
/// GetEditStringLength/区切り文字の文字列長を取得する
/// </summary>
/// <returns>[INT_PTR] 区切り文字の文字列長</returns>
INT_PTR CCSVEdit::GetDelimiterLength()
{
	return Delimiter.GetLength();
}

/// <summary>
/// GetCSVDataCount()/区切り文字で区切られている文字列データの数を返す(区切り文字なしの場合を１とする)
/// </summary>
/// <returns>[INT_PTR] (>0):区切り文字で区切られている文字列の数 -1:操作対象文字列無し</returns>
INT_PTR CCSVEdit::GetCSVDataCount()
{
	if (EditStr.IsEmpty()) return CSVERR_EDITSTRNONE;	// 操作対象文字列無し
	if (Delimiter.IsEmpty()) return 1;					// 区切り文字無し->文字列の数は１とする
	int Start = 0;
	INT_PTR Count = SearchDelimiterPosition(Start);	// 区切り文字を可能な限り検索
	return (Count+1);		// Countは区切り文字の数のため(+1)して返す
}

/// <summary>
/// InitialString/編集対象文字列を区切り文字で初期化する
/// </summary>
/// <param name="Count">(I) 作成する区切り文字で区切られたCSVData数</param>
/// <returns>[INT_PTR] 0:処理正常 -2:区切り文字無し -3:引数指定エラー</returns>
INT_PTR CCSVEdit::InitialString(INT_PTR Count)
{
	if (Delimiter.IsEmpty()) return CSVERR_DELIMITERNONE;	// 区切り文字無し
	if (Count < 0) return CSVERR_PARAMFAIL;
	EditStr.Empty();
	for (INT_PTR i=0; i<(Count-1); i++) {
		EditStr+=Delimiter;	// 指定個数分区切り文字を設定
	}
	return CSVERR_NOERROR;
}

/// <summary>
/// SetPosString-1/CSV編集データの指定の位置に文字列を設定する
/// </summary>
/// <param name="Val">(I) 格納する文字列</param>
/// <param name="MarkCount">(I) 格納するデータの位置(左端から1,2,3...とする)</param>
/// <returns>[INT_PTR] 0:処理正常 -3:引数指定エラー -4:指定位置なし</returns>
INT_PTR CCSVEdit::SetPosString(CString Val, INT_PTR MarkCount)
{
	if (MarkCount <= 0) return CSVERR_PARAMFAIL;		// 引数指定エラー
	if (Quote) Val = AddQuoteMark(Val);				// QMarkを付与する
	CString Temp = EditStr, LeftVal, RightVal;
	int Start = 0, End = 0;
	LeftVal.Empty(); RightVal.Empty();
	SearchDelimiterPosition(Start, MarkCount);		// 指定位置の開始位置を検索
	if (Start < 0) return CSVERR_POSNONE;				// 指定位置無し
	LeftVal = Temp.Left(Start);
	End = Start;
	SearchDelimiterPosition(End, 2);				// 指定の位置の次の開始位置を検索
	if (End > 0) {
		End-=Delimiter.GetLength();
		RightVal = Temp.Mid(End);
	}
	Temp.Format(_T("%s%s%s"), LeftVal, Val, RightVal);	// 文字列の再構成
	EditStr = Temp;
	return CSVERR_NOERROR;
}
/// <summary>
/// SetPosString-2/CSV編集データの指定の位置に文字列を設定する
/// </summary>
/// <param name="Val">(I) 格納する文字列バッファ</param>
/// <param name="MarkCount">(I) 格納するデータの位置(左端から1,2,3...とする)</param>
/// <returns>[INT_PTR] 0:処理正常 -3:引数指定エラー -4:指定位置なし</returns>
INT_PTR CCSVEdit::SetPosString(LPCTSTR Val, INT_PTR MarkCount)
{
	if (Val == NULL) return CSVERR_PARAMFAIL;	// 引数指定エラー
	return SetPosString(CString(Val), MarkCount);
}

/// <summary>
/// SetPosString-3/CSV編集データに文字列を各々設定する
/// </summary>
/// <param name="Val">(I) 格納する文字列の配列(0からデータを設定していること)</param>
/// <returns>[INT_PTR] 0:処理正常 -3:引数指定エラー -4:指定位置なし</returns>
INT_PTR CCSVEdit::SetPosString(CsvStringArray& Val)
{
	INT_PTR Ret;
	for (INT_PTR i=0; i<Val.GetCount(); i++) {
		CStringW DivStr;
		if (!Val.Lookup(i, DivStr)) DivStr.Empty();
		Ret = SetPosString(DivStr, i+1);
		if (Ret < 0) return Ret;
	}
	return CSVERR_NOERROR;
}

/// <summary>
/// GetPosString-1/CSV編集データの指定の位置の文字列を取得する
/// </summary>
/// <param name="Val">(O) 取得する文字列</param>
/// <param name="MarkCount">(I) 取得するするデータの位置(左端から1,2,3...とする)</param>
/// <returns>[INT_PTR] 0:処理正常 -3:引数指定エラー -4:指定位置なし</returns>
INT_PTR CCSVEdit::GetPosString(CString& Val, INT_PTR MarkCount)
{
	if (MarkCount <= 0) return CSVERR_PARAMFAIL;		// 引数指定エラー
	CString Temp = EditStr;
	int Start = 0, End = 0;
	Val.Empty();
	SearchDelimiterPosition(Start, MarkCount);		// 指定の位置の開始位置を検索
	if (Start < 0) return CSVERR_POSNONE;				// 指定位置無し
	End = Start;
	SearchDelimiterPosition(End, 2);				// 指定の位置の次の開始位置を検索
	if (End > 0) End-=Delimiter.GetLength();
	// 抽出文字列の取得
	if (Start < End)	   Val = Temp.Mid(Start, (End-Start));
	else if (Start == End) Val.Empty();
	else				   Val = Temp.Mid(Start);
	if (Quote) Val = DelQuoteMark(Val);				// QMarkを消去する
	return CSVERR_NOERROR;
}
/// <summary>
/// GetPosString-2/CSV編集データの指定の位置の文字列を取得する
/// </summary>
/// <param name="Val">(O) 取得する文字列のバッファ</param>
/// <param name="MarkCount">(I) 取得するデータの位置(左端から1,2,3...とする)</param>
/// <returns>[INT_PTR] 0:処理正常 -3:引数指定エラー -4:指定位置なし -5:データ取得失敗</returns>
INT_PTR CCSVEdit::GetPosString(LPTSTR Val, INT_PTR MarkCount)
{
	if (Val == NULL) return CSVERR_PARAMFAIL;
	CString WVal;
	INT_PTR Ret = GetPosString(WVal, MarkCount);
	if (Ret != CSVERR_NOERROR) return Ret;
	errno_t err = wcsncpy_s(Val, WVal.GetLength(), static_cast<LPCWSTR>(WVal), _TRUNCATE);
	if (err == CSVERR_NOERROR) return CSVERR_NOERROR;
	else					   return CSVERR_COPYERR;
}
/// <summary>
/// GetPosString-3/CSV編集データを区切り文字で分割して取得する
/// </summary>
/// <param name="Val">(O) 取得する文字列の配列(0からデータを取得していく)</param>
/// <returns>[INT_PTR] 0:処理正常 -3:引数指定エラー -4:指定位置なし -5:データ取得失敗</returns>
INT_PTR CCSVEdit::GetPosString(CsvStringArray& Val)
{
	Val.RemoveAll();
	CString DivStr;
	INT_PTR Ret;
	for (INT_PTR i=0; i<GetCSVDataCount(); i++) {
		Ret = GetPosString(DivStr, i+1);
		if (Ret != CSVERR_NOERROR) return Ret;
		Val.SetAt(i, DivStr);
	}
	return CSVERR_NOERROR;
}

/// <summary>
/// GetPosStringLength/CSV編集データの指定の位置の文字列長を取得する
/// </summary>
/// <param name="MarkCount">(I) 取得するデータの位置(左端から1,2,3...とする)</param>
/// <returns>[INT_PTR] 区切り文字の文字列長</returns>
INT_PTR CCSVEdit::GetPosStringLength(INT_PTR MarkCount)
{
	CString Val;
	INT_PTR Ret;
	Ret = GetPosString(Val, MarkCount);
	if (Ret != CSVERR_NOERROR) return 0;
	return Val.GetLength();
}

/// <summary>
/// DelQuoteMark/CSV編集データからQuotationMarkを削除する
/// </summary>
/// <param name="Src">(I) 削除対象の文字列</param>
/// <returns>[CString] 削除後の文字列</returns>
CString CCSVEdit::DelQuoteMark(CString Src)
{
	CString Ret;
	int Left = 0, Right = Src.GetLength();
	if (Src.Left(1).Compare(QUOTATIONMARK) == 0) Left++;
	if (Src.Right(1).Compare(QUOTATIONMARK) == 0) Right--;
	Ret = Src.Mid(Left, Right-Left);						// 両端のQMarkを削除
	Ret.Replace(DOUBLEQUOTATIONMARK, QUOTATIONMARK);		// 文中のQMarkをシングル表記に変更
	return Ret;
}

/// <summary>
/// AddQuoteMark/CSV編集データにQuotationMarkを追加する
/// </summary>
/// <param name="Src">(I) 追加対象の文字列</param>
/// <returns>[CString] 追加後の文字列</returns>
CString CCSVEdit::AddQuoteMark(CString Src)
{
	CString Ret = Src;
	int Left = 0, Right = Src.GetLength();
	if (Ret.Find(QUOTATIONMARK) >= 0 || Ret.Find(Delimiter) >= 0) {	// QMark or 区切り文字あり？
		if (Src.Left(1).Compare(QUOTATIONMARK) == 0) Left++;
		if (Src.Right(1).Compare(QUOTATIONMARK) == 0) Right--;
		Ret = Src.Mid(Left, Right-Left);							// 両端のQMarkを一旦削除
		Ret.Replace(QUOTATIONMARK, DOUBLEQUOTATIONMARK);			// 文中のQMarkをダブル表記に変更
		Ret = CStringW(QUOTATIONMARK)+Ret+CStringW(QUOTATIONMARK);	// 両端のQMarkを設定
	}
	return Ret;
}

/// <summary>
/// SearchDelimiterPosition/区切り文字の位置を検索する＆区切り文字の数を検索する
/// </summary>
/// <param name="StartPos">(I/O) 検索を開始する文字の位置&区切り文字で区切られた文字列の先頭位置</param>
/// <param name="SearchCount">(I) 最大検索する区切り文字の数(左から1,2,3,...とする 相対数を指定)</param>
/// <returns>[INT_PTR] 検索した区切り文字の数</returns>
INT_PTR CCSVEdit::SearchDelimiterPosition(int& StartPos, INT_PTR SearchCount)
{
	bool Flag = false;
	INT_PTR Count = 0, TargetCount = SearchCount-1;
	int Pos = StartPos, Start = StartPos;
	while (1) {
		if (Count >= TargetCount) break;	// 指定回数まで区切り文字検索完了
		// ダブルクォーテーションでくくられている？
		if (Quote && EditStr.Mid(Start, 1).CompareNoCase(QUOTATIONMARK) == 0) Flag = true;
		Pos = EditStr.Find(Delimiter, Start);	// 次の区切り文字の検索
		if (Pos < 0) break;						// 区切り文字無し
		// ダブルクォーテーションでくくられている？
		if (Quote && Flag && EditStr.Mid(Pos-1, 1).CompareNoCase(QUOTATIONMARK) == 0) Flag = false;
		Start = Pos+Delimiter.GetLength();		// 次の検索開始位置の設定
		if (!Flag) Count++;
	}
	if (Flag || Pos < 0) StartPos = -1;		// 終端まで検索 or QMark異常(終端検索扱い)
	else				 StartPos = Start;	// 開始位置の確保
	return Count;
}
