#######################################################################
PS-API OCXについて  (* V13.10から名称をOCXに変更)
                                               (c) i-PRO Co., Ltd. 2025
#######################################################################

< INDEX >
1. SDKの説明
2. バージョン情報
3. (不要) ActiveXコントロールのインストール
4. 変更履歴
5. 謝辞


-----------------------------------------------------------------------
1. SDKの説明

  以下の開発環境でOCXを用いたアプリケーションを開発する場合は、
  "OCX"を使用してください。

  - Microsoft Visual Basic 2005
  - Microsoft Visual C# 2005
  - Microsoft Visual Basic 2012
  - Microsoft Visual C# 2012
  - HTML (JScript)

  詳細については、各インターフェース仕様書を参照してください。


2. バージョン情報

  パッケージ名 : PS-API OCX
  SDKバージョン: V13.20.05

  ファイル名   : PS-API_132005_OCX.zip

  +========================================================================+
  | // 重要 //                                                             |
  |  * 本SDKパッケージを使用するには、                                     |
  |    同梱のVisual C++ ランタイムライブラリをインストールしてください。   |
  |　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　|
  |  * すでに別のバージョンのPS-APIがインストールされている場合は、        |
  |    アンインストールした後、インストールを行ってください。              |
  +========================================================================+

                        ファイル名                       ファイルバージョン
  ---------------------+--------------------------------+------------------
  [PS-API]
  Document              PS-API Interface Specifications 
                        for OCX Japanese.pdf                13.20 R01
                        PS-API Interface Specifications 
                        for OCX English.pdf                 13.20 R01

  Binary                ipropsapi.ocx                       13.10.2.0
                        ipropsapi.dll                       13.10.4.0
                        ipropsapidevice.dll                 13.20.5.0
                        ipropsapivideo.dll                  13.20.2.0
                        ipropsapissl.dll                    13.00.2.0
                        ipropsapiftp.dll                    12.90.1.0
                        ipropsapishmlogger.dll              1.0.3.0

  DirectShowFilters     declib.dll                          1.0.0.0
                        rphlib.dll                          1.1.1.0
                        ipropsapidsfilters.ax               13.20.2.0
                        qnuladapter.ax                      8.50.1.0
                        libwrtsp.dll                        11.90.2.0
                        RTSPlib.dll                         11.90.2.0
                        ipropsapih264dec.ax                 1.0.0.0
                        ipropsapih265dec.ax                 1.0.0.0
                        AACDecodeFilterAS.ax                1.0.7.0
                        MPEG4VideoDecoder2AS.ax             1.1.1.0
                        pg726dec.ax                         1.0.1.3
                        pg726enc.ax                         1.1.1.4
                        IPPCustomDll.dll                    1.0.2.0
                        mc_dec_hevc.dll                     8.2.0.70

  VC++ 2005 Runtime     vcredist_x86.exe                    2.0.50727.5672
  VC++ 2012 Runtime     vcredist_x86.exe                    11.0.61030.0

  [PS-ALARM]
  Document              PS-ALARM Interface Specifications 
                               for OCX Japanese.pdf         1.2 R09
                        PS-ALARM Interface Specifications 
                               for OCX English.pdf          1.2 R09

  Binary                psalarmrcv.ocx                      1.0.9.0
                        psalarmrcv.dll                      1.0.11.0

  [PS-LOOKUP]
  Document              PS-LOOKUP Interface Specifications 
                               for OCX Japanese.pdf         1.0 R19
                        PS-LOOKUP Interface Specifications 
                               for OCX English.pdf          1.0 R19

  Binary                pslookup.ocx                        1.0.4.0
                        pslookup.dll                        1.0.7.0

  * 旧社名が記載されている場合がありますが、問題なくお使いいただけます。


3. バージョン（v12.80.03）以降について、ActiveXコントロールのインストールは
　 不要になります。


4. 変更履歴
  2025.07.31 ---------------------------------------------------------------
  SDKバージョン: V13.20.05
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 13.10.3.0 -> 13.20.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 13.10.5.0 -> 13.20.2.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 13.10.1.0 -> 13.20.2.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NX series---
                     WJ-NX210

                     ---X series---
                     WV-X67701-Z3L3, WV-X67701-Z3L3V
		     WV-X67700-Z3-3, WV-X67700-Z3-3V, WV-X67700-Z3L3, WV-X67700-Z3L3V
		     WV-X67711-Z3L3, WV-X67711-Z3L3V
		     WV-X67710-Z3-1, WV-X67710-Z3-1V, WV-X67710-Z3-3, WV-X67710-Z3-3V,
		     WV-X67710-Z3L1, WV-X67710-Z3L1V, WV-X67710-Z3L3, WV-X67710-Z3L3V
		     WV-X67301-Z4L3, WV-X67301-Z4L3V
		     WV-X67300-Z4-3, WV-X67300-Z4-3V, WV-X67300-Z4L3, WV-X67300-Z4L3V
		     WV-X67311-Z4L3, WV-X67311-Z4L3V
		     WV-X67310-Z4-1, WV-X67310-Z4-1V, WV-X67310-Z4-3, WV-X67310-Z4-3V,
		     WV-X67310-Z4L1, WV-X67310-Z4L1V, WV-X67310-Z4L3, WV-X67310-Z4L3V

                 [PS-API]
                 - CameraOperationメソッドのCommand引数に白色LED関連の設定を追加しました。

  2023.12.20 ---------------------------------------------------------------
  SDKバージョン: V13.10.06
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 12.90.1.0 -> 13.10.2.0 )
                 - ipropsapi.dll
                        (File Version : 13.00.3.0 -> 13.10.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 13.00.5.0 -> 13.10.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 13.00.3.0 -> 13.10.5.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.90.2.0 -> 13.10.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NX series---
                     WJ-NX310, WJ-NX410, WJ-NX510

                     ---S series---
                     WV-S85702-F3L, WV-S85702-F3L1, WV-S85402-V2L,  WV-S85402-V2L1
                     WV-S35302-F2L, WV-S35302-F2L1, WV-S35302-F2LG, WV-S32302-F2L, WV-S32302-F2L1, WV-S32302-F2LG
                     WV-S66700-Z3,  WV-S66700-Z3L,  WV-S66600-Z3,   WV-S66600-Z3L
                     WV-S66300-Z4,  WV-S66300-Z4L
                     WV-S66300-Z3,  WV-S66300-Z3L

                     ---X series---
                     WV-X35302-F2L
                     WV-X66700-Z3S, WV-X66700-Z3LS, WV-X66600-Z3S, WV-X66600-Z3LS
                     WV-X66300-Z4S, WV-X66300-Z4LS
                     WV-X66300-Z3S, WV-X66300-Z3LS

                     ---U series---
                     WV-U85402-V2L, WV-U85402-V2L1
                     WV-U21300-V2L, WV-U11300-V2

                 [PS-API]
                 - アプリからレコーダCGIを直接送信する際に利用するUIDを取得する機能を追加
　　　　　　　　　　　（※但し、Connect()の引数に設定するUID等は、既存UIDプロパティで取得したUIDを使用すること）
                     ---追加プロパティ---
                      UIDEx

                 - HTTPS通信時、カメラのサーバー証明書の妥当性をチェックする機能を追加
                      ---追加プロパティ---                
                      CertificateVerifyEnable

                 [備考]
                 - 名称をActiveXからOCXに変更しました。
　　　　　　　　　　(※ 名称変更によるアプリへの影響はありません）

  2023.03.10 ---------------------------------------------------------------
  SDKバージョン: V13.00.08
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 12.90.1.0 -> 13.00.3.0 )
                 - ipropsapidevice.dll
                        (File Version : 12.90.3.0 -> 13.00.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.90.6.0 -> 13.00.3.0 )
                 - ipropsapissl.dll
                        (File Version : 12.00.2.0 -> 13.00.2.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---S series---
                     WV-S65302-Z2, WV-S65302-Z2-1
                     WV-S65501-Z1, WV-S65301-Z1, WV-S65301-Z1-1, WV-S61501-Z1, WV-S61301-Z1
                     WV-S65300-ZY, WV-S61300-ZY

                     ---X series---
                     WV-X86530-Z2, WV-X86530-Z2-1
                     WV-X86531-Z2, WV-X86531-Z2-1                         

  2022.12.09 ---------------------------------------------------------------
  SDKバージョン: V12.90.07
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 12.80.1.0 -> 12.90.1.0 )
                 - ipropsapi.dll
                        (File Version : 12.80.1.0 -> 12.90.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 12.80.1.0 -> 12.90.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.80.3.0 -> 12.90.6.0 )
                 - ipropsapiftp.dll
                        (File Version : 12.00.2.0 -> 12.90.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.40.3.0 -> 12.90.2.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NU series---
                     WJ-NU101, WJ-NU201, WJ-NU300, WJ-NU301

  2022.09.30 ---------------------------------------------------------------
  SDKバージョン: V12.80.03
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 12.20.2.0 -> 12.80.1.0 )
                 - ipropsapi.dll
                        (File Version : 12.20.2.0 -> 12.80.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 12.70.2.0 -> 12.80.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.60.3.0 -> 12.80.3.0 )
                 - ipropsapih264dec.ax
                        (File Version :     -     -> 1.0.0.0   )
                 - ipropsapih265dec.ax
                        (File Version :     -     -> 1.0.0.0   )
                 - AACDecodeFilterAS.ax
                        (File Version :     -     -> 1.0.7.0   )
                 - MPEG4VideoDecoder2AS.ax
                        (File Version :     -     -> 1.1.1.0   )
                 - pg726dec.ax
                        (File Version :     -     -> 1.0.1.3   )
                 - pg726enc.ax
                        (File Version :     -     -> 1.1.1.4   ) 
                 - IPPCustomDll.dll
                        (File Version :     -     -> 1.0.2.0   ) 
                 - mc_dec_hevc.dll
                        (File Version :     -     -> 8.2.0.70  ) 

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                        ---B series---
                        WV-B51300-F3, WV-B51300-F3W
                        WV-B54300-F3, WV-B54300-F3W

                 [PS-API]
                 - ActiveXコントロールのインストール無しで、映像/音声の出力を可能としました。
                 - ハードウェア環境のOSにWindows Server 2022 Standard(Desktop Experience)を
                   追加しました。
                 - ハードウェア環境のOSにMicrosoft Windows 8 Proを削除しました。

                 [PS-ALARM]
                 - ハードウェア環境のOSにWindows Server 2022 Standard(Desktop Experience)を
                   追加しました。
                 - ハードウェア環境のOSにMicrosoft Windows 8 Proを削除しました。

                 [PS-LOOKUP]
                 - ハードウェア環境のOSにWindows Server 2022 Standard(Desktop Experience)を
                   追加しました。
                 - ハードウェア環境のOSにMicrosoft Windows 8 Proを削除しました。

  2022.06.30 ---------------------------------------------------------------
  SDKバージョン: V12.70.02
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 12.50.1.0 -> 12.70.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.40.3.0 -> 12.60.3.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
			---S series---
			WV-S15500-V3L, WV-S15500-V3LN1, WV-S15500-V3LK,
			WV-S15600-V2L, WV-S15600-V2LN,
			WV-S15700-V2L, WV-S15700-V2LK,
			WV-S22500-V3LG, WV-S22500-V3L1,
			WV-S22600-V2L, WV-S22600-V2LG,
			WV-S22700-V2LG, WV-S22700-V2L1,
			WV-S25500-V3L, WV-S25500-V3LG, WV-S25500-V3LN1,
			WV-S25600-V2L, WV-S25600-V2LN, WV-S25600-V2LG,
			WV-S25700-V2L, WV-S25700-V2LG, WV-S25700-V2LN1,
			WV-S15500-F3L,
			WV-S15500-F6L,
			WV-S22500-F3L,
			WV-S22500-F6L,
			WV-S25500-F3L,
			WV-S25500-F6L
			-----
			WV-S65340-Z4K, WV-S65340-Z4N,
			WV-S65340-Z2K, WV-S65340-Z2N,
			WV-S61302-Z4, 
			WV-S61301-Z2
			-----
			WV-S71300-F3
			-----
			WV-S1536LNS		
	
			---B series---
			WV-B65302-Z2,
			WV-B65301-Z1,
			WV-B65300-ZY,
			WV-B61301-Z2,
			WV-B61301-Z1,
			WV-B61300-ZY,
			-----
			WV-B71300-F3,
			WV-B71300-F3-1,
			WV-B71300-F3W,
			WV-B71300-F3W1

			---U series---
			WV-U65302-Z2, WV-U65302-Z2G
			WV-U65301-Z1, WV-U65301-Z1G
			WV-U65300-ZY, WV-U65300-ZYG
			WV-U61301-Z2,
			WV-U61301-Z1,
			WV-U61300-ZY, WV-U61300-ZYG

  2022.04.01 ---------------------------------------------------------------
  SDKバージョン: V12.50.01
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 12.30.1.0 -> 12.50.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.30.1.0 -> 12.40.3.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.30.1.0 -> 12.40.3.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---S series---
                     WV-S8574L, WV-S8574LUX, WV-S8564L, WV-S8544L, WV-S8544LUX, WV-S8544
                     WV-S8573L, WV-S8573LUX, WV-S8563L, WV-S8543L, WV-S8543LUX, WV-S8543
                     WV-S15500-V3LN, WV-S15700-V2LN
		             WV-S22500-V3L, WV-S22700-V2L
 		             WV-S25500-V3LN, WV-S25700-V2LN
                 [PS-API]
                 - ハードウェア環境のOSにMicrosoft Windows 11 Proを追加しました。
                 - ハードウェア環境のOSにWindows Server 2019 Standard(Desktop Experience)を
                   追加しました。

  2022.01.31 ---------------------------------------------------------------
  SDKバージョン: V12.30.01
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 12.00.4.0 -> 12.20.2.0 )
                 - ipropsapi.dll
                        (File Version : 12.00.4.0 -> 12.20.2.0 )
                 - ipropsapidevice.dll
                        (File Version : 12.10.1.0 -> 12.30.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.10.1.0 -> 12.30.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.10.1.0 -> 12.30.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---S series---
                     WV-S4156, WV-S4156J
                     WV-S4556L, WV-S4556LJ, WV-S4556LM
                     WV-S4176, WV-S4176J
                     WV-S4576L, WV-S4576LJ, WV-S4576LM
                     WV-S7130UX
                     WV-S7130WUX
 
                 [PS-API]
                 - レコーダに記録されているSDバックアップ再生時の映像カクツキを
　　　　　　　　　 修正しました。

  2021.08.31 ---------------------------------------------------------------
  SDKバージョン: V12.10.01
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 12.00.4.0 -> 12.10.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.00.7.0 -> 12.10.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.00.4.0 -> 12.10.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---S series---
                     WV-S1536LT, WV-S1536L, WV-S1516L,  WV-S1516LD,
                     WV-S1515L,  WV-S1136,  WV-S1135V,  WV-S1116D,
                     WV-S1116,   WV-S1115V, WV-S2536LT, WV-S2536L,
                     WV-S2236L,  WV-S2136L, WV-S2136,   WV-S2135,
                     WV-S2116LD, WV-S2116L, WV-S2115
 
                 [PS-API]
                 - NXレコーダとのNW断検出の処理を修正しました。

  2021.05.31 ---------------------------------------------------------------
  SDKバージョン: V12.00.08
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File VerFion : 11.41.1.0 -> 12.00.4.0 )
                 - ipropsapi.dll
                        (File VerFion : 11.80.1.0 -> 12.00.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 11.80.2.0 -> 12.00.4.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.80.3.0 -> 12.00.7.0 )
                 - ipropsapissl.dll
                        (File Version : 10.50.1.0 -> 12.00.2.0 )
                 - ipropsapiftp.dll
                        (File Version : 11.30.1.0 -> 12.00.2.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.80.1.0 -> 12.00.4.0 )
                 - libwrtsp.dll
                        (File Version : 1.0.7.0   -> 11.90.2.0 )
                 - RTSPlib.dll
                        (File Version : 1.0.1.0   -> 11.90.2.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---X series---
                     WV-X8571N
                     WV-X4172, WV-X4173, WV-X4573L
                     ---S series---
                     WV-S8531N
                     WV-S4151, WV-S4551L
 
                 [PS-API]
                 - NXレコーダのHTTP/HTTPSダウンロード機能を追加しました
                   (ダウンロード対象ファイル：n3、MP4)
                     ---追加メソッド---
                      HttpDownload
                 - AlarmOperationメソッドに、指定chでのイベント録画停止機能を追加しました
                 - Uシリーズカメラの新解像度に対応しました(2688×1520)

  2020.09.07 ---------------------------------------------------------------
  SDKバージョン: V11.80.03
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File VerFion : 11.41.1.0 -> 11.80.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 11.60.2.0 -> 11.80.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.60.1.0 -> 11.80.3.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.40.1.0 -> 11.80.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---X series---
                     WV-X1571L, WV-X2571L, WV-X2271L
                     WV-X1551L, WV-X2551L, WV-X2251L
                     WV-X1534L, WV-X2533L, WV-X2232L
                     ---S series---
                     WV-S1572L, WV-S2572L, WV-S2272L
                     WV-S1552L, WV-S2552L, WV-S2252L
 
                 [PS-API]
                 - 受話中に、送話開始するとエラーになる場合がある問題の修正
                 - 受話ミュートの解除できない場合がある問題の修正
                 - NWDRからの情報取得方式について一部変更。

  2020.05.29 ---------------------------------------------------------------
  SDKバージョン: V11.60.02
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 11.20.1.0 -> 11.41.1.0 )
                 - ipropsapi.dll
                        (File VerFion : 11.20.1.0 -> 11.41.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 11.40.1.0 -> 11.60.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.40.1.0 -> 11.60.1.0 )
                 - ipropsapissl.dll
                        (File Version :     -     -> 10.50.1.0 )
                 - psalarmrcv.ocx
                        (File Version : 1.0.8.0 -> 1.0.9.0 )
                 - psalarmrcv.dll
                        (File Version : 1.0.10.0 -> 1.0.11.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---U series---
                     WV-U1142, U1134J, U1132, U1114J,
                     WV-U2142L, U2134J, U2132L, U2114J,
                     WV-U1542L, U1532L
                     WV-U2542L, U2532L
                     WV-U1133J, U1130, U1113J
                     WV-U2140L, U2130L
                     WV-U1533J,
                     WV-U2540L, U2530L

                 [PS-API]
                 - サポート製品に関連した、メソッド・プロパティの設定値を
                   更新しました。
                 - HTTPS機能を追加しました。
                     ---追加プロパティ---
                      SecureCommunicationMode
                 - 映像のカクツキを抑制する機能を追加しました。
                     ---追加プロパティ---
                      TransIntervalMode
                      DecBufferNum
                 - HttpMP4Downloadの実行時、MP4データの受信タイミングにより
                   クラッシュする問題の修正
                 - ハードウェア環境のOSにWindows Server 2016 Standard(Desktop Experience)を
                   追加しました。

                 [PS-ALARM]
                 - OnAlarmRcvの引数"messageText"の最大値を変更しました。（255-> 520）
                 - ハードウェア環境のOSにWindows Server 2016 Standard(Desktop Experience)を
                   追加しました。

                 [PS-LOOKUP]
                 - ハードウェア環境のOSにWindows Server 2016 Standard(Desktop Experience)を
                   追加しました。

  2019.06.26 ---------------------------------------------------------------
  SDKバージョン: V11.40.01
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 11.30.1.0 -> 11.40.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.30.1.0 -> 11.40.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.30.1.0 -> 11.40.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---S series---
                     WV-S1570L, S2570L, S2270L,
                     WV-S6532LN
                     ---X series---
                     WV-X6533LN

                 [PS-API]
　　　　　　　　 - サポート製品に関連した、メソッド・プロパティの設定値を
　　　　　　　　　 更新しました。
　　　　　　　　 - 連続して複数プロセスでライブを開始すると、一部ライブが
                   停止するという問題を修正しました。
　　　　　　　　 - アプリケーションの開発環境に、Microsoft Visual Basic 2012、
　　　　　　　　　 Microsoft Visual C# 2012を追加しました。

　　　　　　　　 [PS-ALARM][PS-LOOKUP]
　　　　　　　　 - アプリケーションの開発環境に、Microsoft Visual Basic 2012、
　　　　　　　　　 Microsoft Visual C# 2012を追加しました。

  2019.03.28 ---------------------------------------------------------------
  SDKバージョン: V11.30.01
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 11.00.1.0 -> 11.20.1.0 )
                 - ipropsapi.dll
                        (File Version : 11.00.1.0 -> 11.20.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 11.10.2.0 -> 11.30.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.10.4.0 -> 11.30.1.0 )
                 - ipropsapiftp.dll
                        (File Version : 10.50.1.0 -> 11.30.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.10.3.0 -> 11.30.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NX series---
                     WJ-NX100
                     ---S series---
                     WV-S3130J, S3131L, S3110J, S3111L,
                     WV-S3530J, S3531L, S3510J, S3511L, S3532LM, S3512LM

                 [PS-API][PS-ALARM]
　　　　　　　　 - サポート製品に関連した、メソッド・プロパティの設定値を
　　　　　　　　　 更新しました。

  2018.06.29 ---------------------------------------------------------------
  SDKバージョン: V11.10.05
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 11.00.2.0 -> 11.10.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.00.8.0 -> 11.10.4.0 )
                 - ipropsapiftp.dll
                        (File Version : 10.30.1.0 -> 10.50.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.00.5.0 -> 11.10.3.0 )
                 - psalarmrcv.dll
                        (File Version : 1.0.9.0 　 -> 1.0.10.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---S series---
                     WV-S2550L, S1550L, S2250L
                     WV-S8530N
                     ---X series---
                     WV-X8570L

                 [PS-API][PS-ALARM]
　　　　　　　　 - WV-S2550L, S1550L, S2250L, S8530N, X8570Lに関連した、
                   メソッド・プロパティの設定値を更新しました。

  2018.03.23 ---------------------------------------------------------------
  SDKバージョン: V11.00.08
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 10.30.1.0 -> 11.00.1.0 )
                 - ipropsapi.dll
                        (File Version : 10.30.4.0 -> 11.00.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 10.30.3.0 -> 11.00.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 10.30.14.0 -> 11.00.8.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 10.30.10.0 -> 11.00.5.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---X series---
                     WV-X4571L, X4171, X4170

                 [PS-API]
　　　　　　　　 - WV-X4571L, X4171, X4170に関連した、
                   メソッド・プロパティの設定値を更新しました。
　　　　　　　　 - ファイル再生時の音声(AAC)出力に対応しました。
                 - SetCameraPositionの引数focus/CameraPosFocusプロパティの
　　　　　　　　　 最小値を変更しました。

  2017.12.12 ---------------------------------------------------------------
  SDKバージョン: V10.30.15
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 10.00.2.0 -> 10.30.1.0 )
                 - ipropsapi.dll
                        (File Version : 10.00.3.0 -> 10.30.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 10.10.3.0 -> 10.30.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 10.10.2.0 -> 10.30.14.0 )
                 - ipropsapiftp.dll
                        (File Version : 10.10.2.0 -> 10.30.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 10.10.1.0 -> 10.30.10.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NX series---
                     WJ-NX300
                     ---S series---
                     WV-S6131, S6111, S6530, S6130, S6110
                     WV-S4150, S4550
                 
                 [PS-API]
                 - NXシリーズのMP4ファイルダウンロード(HTTP)に対応しました。
                     ---追加メソッド---
　　　　　　　　　　  HttpMP4Download
                      GetMP4DownloadStatus
                      GetMP4DownloadTransRate
                     ---追加プロパティ---
                      OnMP4DownloadStatusEnable
                     ---追加イベント---
                      OnMP4DownloadStatus
　　　　　　　　 - NXシリーズのサブストリーム受信の設定方法を変更しました。
                     ---追加プロパティ---
                      NXStreamNumber
　　　　　　　　 - NXシリーズのHDDスタンバイ制御に対応しました。
　　　　　　　　 - ライブ、ネットワーク再生時の音声(AAC)出力に対応しました。
                     ---追加プロパティ---
                      RcvAudioDec

　　　　　　　　　　* 複数インスタンスで多画面表示を行う際に、音声のAAC は
                      使用しないで下さい。

                 - 一部のファイルプロパティの社名を変更しました。

  2017.06.19 ---------------------------------------------------------------
  SDKバージョン: V10.10.04
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 10.00.7.0 -> 10.10.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 10.00.20.0 -> 10.10.2.0 )
                 - ipropsapiftp.dll
                        (File Version : 10.00.5.0 -> 10.10.2.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 10.00.18.0 -> 10.10.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NX series---
                     WJ-NX200
                     ---X series---
                     WV-X6531N, X6531NJ(Japan Only), X6531NH(China only)
                     WV-X6511N, X6511NJ(Japan Only)
                 
                 [サポートするOS]
                 - ハードウェア環境のOSからMicrosoft Windows XP Professional SP3 /
                   Microsoft Windows Vista Business SP2を削除しました。
                 
                 [PS-API]
                 - ファイルプロパティの社名を変更しました。
                 - WJ-NX200に対応しました。
                 - Xシリーズカメラに対応しました。

  2017.02.21 ---------------------------------------------------------------
  SDKバージョン: V10.00.24
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 9.50.3.0 -> 10.00.02.0 )
                 - ipropsapi.dll
                        (File Version : 9.50.01.0 -> 10.00.03.0 )
                 - ipropsapidevice.dll
                        (File Version : 9.40.02.0 -> 10.00.07.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.60.14.0 -> 10.00.20.0 )
                 - ipropsapiftp.dll
                        (File Version : 8.50.3.0 -> 10.00.05.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.60.10.0 -> 10.00.18.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                     ---NX series---
                     WJ-NX400
                     ---Aero PTZ---
                     WV-SUD638
                     ---S series---
                     WV-S2531LN , WV-S2511LN
                     WV-S2131L, WV-S2131, WV-S2130, WV-S2111L, WV-S2110
                     WV-S1531LN, WV-S1511LN
                     WV-S2231L, WV-S2211L, 
                     WV-S1132, WV-S1131, WV-S1112, WV-S1111
                     ---S series: China only---
                     WV-S2532LH, WV-S2512LH
                     WV-S2132LH, WV-S2132H, WV-S2130H, WV-S2112LH, WV-S2112H, WV-S2110H
                     WV-S1432LH, WV-S1412LH
                     WV-S1132H, WV-S1112H
                 
                 [PS-API]
                 - H.265に対応しました。
                 - 推奨環境情報を更新しました。
                 - WJ-NXシリーズNWDRに対応しました。
                 - Aero PTZカメラに対応しました。
                 - Sシリーズカメラに対応しました。
                 - カメラワイパー制御機能に対応しました。
                     ---メソッド---
                     CameraWiperControl

  2016.11.02 ---------------------------------------------------------------
  SDKバージョン: V9.60.13
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 9.50.2.0 -> 9.50.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.50.14.0 -> 9.60.14.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.50.8.0 -> 9.60.10.0 )
		 - psalarmrcv.dll 
                        (File Version : 1.0.8.0 -> 1.0.9.0 )

  変更内容     : [PS-API]
                 - ライブ停止に時間がかかるケースがある問題を修正

  2016.6.30 ---------------------------------------------------------------
  SDKバージョン: V9.50.12
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 9.40.1.0 -> 9.50.2.0 )
                 - ipropsapi.dll
                        (File Version : 9.30.2.0 -> 9.50.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.30.10.0 -> 9.50.14.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.30.8.0 -> 9.50.8.0 )

  変更内容     : [PS-API]
                 - CamSnapShotを２回実行した場合、クラッシュする問題の修正

  2016.4.17 ---------------------------------------------------------------
  SDKバージョン: V9.40.02
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 9.30.1.0 -> 9.40.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 9.30.7.0 -> 9.40.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.30.9.0 -> 9.30.10.0 )

  変更内容     : [PS-API]
                 - サポートする製品に以下のモデルを追加しました。
                     ---1 series---
                     WV-SFV130, WV-SFV110, WV-SFN130, WV-SFN110

  2016.2.1 ----------------------------------------------------------------
  SDKバージョン: V9.30.13
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 9.20.3.0 -> 9.30.1.0 )
                 - ipropsapi.dll
                        (File Version : 9.20.4.0 -> 9.30.2.0 )
                 - ipropsapidevice.dll
                        (File Version : 9.0.5.0 -> 9.30.7.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.20.13.0 -> 9.30.9.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.20.1.0 -> 9.30.8.0 )

  変更内容     : [PS-API][PS-ALARM][PS-LOOKUP]
                 - ハードウェア環境のOSにMicrosoft Windows Server 2012 Standard /
                   Microsoft Windows Server 2012 R2 Standardを追加しました。
                 - ハードウェア環境のOSからMicrosoft Windows Server 2003 Standard /
                   Microsoft Windows Server 2003 Enterpriseを削除しました。
                 　
  2015.12.7 ----------------------------------------------------------------
  SDKバージョン: V9.20.13
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 9.0.2.0 -> 9.20.3.0 )
                 - ipropsapi.dll
                        (File Version : 9.0.2.0 -> 9.20.4.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.0.8.0 -> 9.20.13.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.0.6.0 -> 9.20.1.0 )

  変更内容     : [PS-API]
                 - サポートする製品に以下のモデルを追加しました。
                     ---5 series---
                     WV-SPW531AL, WV-SPN531A, WV-SPW532L(Europe Only)
                     ---3 series---
                     WV-SPW311LA, WV-SPN311A, WV-SPW312L(Europe Only)
                     WV-SPN310A, WV-SPN310AJ(Japan Only)
                     WV-SFV311A, WV-SFV310A
                     WV-SFR311A, WV-SFR310A
                     WV-SFN311A, WV-SFN310A, WV-SFN310AJ(Japan Only)
                     ---1 series---
                     WV-SP105A(Japan Only)
                     ---BB series---
                     BB-SC384B, BB-SC382
                 - ハードウェア環境のOSにMicrosoft Windows 10 Proを追加しました。
                 - スマートコーディング使用時の制約事項を追記しました。
                 - クロッピング表示機能を追加しました。
                     ---メソッド---
                     SetCroppingRect, GetCroppingRect
                     SetCroppingDrawRect, GetCroppingDrawRect
                     SetCroppingDrawEnable, GetCroppingDrawEnable
                     SetCroppingMarker, GetCroppingMarker
                     ---プロパティ---
                     CroppingEnabled
                     CropRectLtX, CropRectLtY, CropRectRbX, CropRectRbY
                     CropDrawRectLtX, CropDrawRectLtY, CropDrawRectRbX, CropDrawRectRbY, CropDrawMode
                     CropMarkerMode, CropMarkerLtX, CropMarkerLtY, CropMarkerRbX, CropMarkerRbY
                     CropMarkerLSize, CropMarkerLColor, CropMarkerESize, CropMarkerEColor

  2015.07.27 ----------------------------------------------------------------
  SDKバージョン: V9.00.11
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 8.10.2.0 -> 9.0.2.0 )
                 - ipropsapi.dll
                        (File Version : 8.10.5.0 -> 9.0.2.0 )
                 - ipropsapidevice.dll
                        (File Version : 8.10.6.0 -> 9.0.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 8.10.15.0 -> 9.0.8.0 )
                 - ipropsapiftp.dll
                        (File Version : 7.50.1.0 -> 8.50.3.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 8.10.7.0 -> 9.0.6.0 )
                 - qnuladapter.ax
                        (File Version : 8.10.1.0 -> 8.50.1.0 )
                 - libwrtsp.dll
                        (File Version : 1.0.5.3 -> 1.0.7.0 )
                 - RTSPlib.dll
                        (File Version : 1.0.0.5 -> 1.0.1.0 )

  変更内容     : [PS-API]
                 - 推奨動作環境をアップデートしました。
                 - サポートする製品に以下のモデルを追加しました。
                   ---2 series : China only---
                   WV-SFV533LH, WV-SFV313LH
                   WV-SFN533LH, WV-SFN533H, WV-SFN532H, WV-SFN313LH, WV-SFN313H
                   WV-SPN533LH, WV-SPN533H, WV-SPN313LH, WV-SPN313H
                   WV-SPW533LH, WV-SPW313LH
                   ---5 series---
                   WV-SFV531, WV-SFN531, WV-SFR531
                   ---BB series---
                   BB-SW374, BB-SC364
                   ---PTZ---
                   WV-SW397, WV-SW397A, WV-SC387
                   ---4K---
                   WV-SFV781L, WV-SPV781L

  2015.06.09 ----------------------------------------------------------------
  SDKバージョン: V8.10.18
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 8.10.4.0 -> 8.10.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 8.10.12.0 -> 8.10.15.0 )

  変更内容     : [PS-API]
                 - セキュリティ強化を実施。

  2015.02.06 ----------------------------------------------------------------
  SDKバージョン: V8.10.14
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 7.50.1.0 -> 8.10.2.0 )
                 - ipropsapi.dll
                        (File Version : 7.50.1.0 -> 8.10.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 7.50.3.0 -> 8.10.6.0 )
                 - ipropsapivideo.dll
                        (File Version : 7.50.13.0 -> 8.10.12.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 7.50.8.0 -> 8.10.7.0 )
                 - qnuladapter.ax
                        (File Version : 7.40.1.0 -> 8.10.1.0 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                   WJ-NV250
                   WV-SFV481, WV-SFN480
                   WV-SPN531, WV-SPN311, WV-SPN310
                   WV-SPW631LT, WV-SPW631L, WV-SPW611L, WV-SPW611
                   BB-ST165A, BB-ST162A, BB-SW175A, BB-SW172A, BB-SW174WA, BB-SW384A
                 
                 [PS-API]
                 - WV-SFV481, WV-SFN480に対応しました。
                   メソッド・プロパティの設定値を更新しました。

  2014.08.25 ----------------------------------------------------------------
  SDKバージョン: V7.50.12
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapivideo.dll
                        (File Version : 7.50.11.0 -> 7.50.13.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 7.50.6.0 -> 7.50.8.0 )

  変更内容     : [PS-API]
                 - 全方位カメラ(WV-SF438, WV-SF448E, WV-SW458)のファームウェア
                   バージョンV1.55以降を使用して録画されたN3Rファイルの再生が
                   出来ない不具合を修正。

  2014.07.25 ----------------------------------------------------------------
  SDKバージョン: V7.50.10
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 7.30.1.0 -> 7.50.1.0 )
                 - ipropsapi.dll
                        (File Version : 7.30.1.0 -> 7.50.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 7.40.3.0 -> 7.50.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 7.40.9.0 -> 7.50.11.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 7.40.2.0 -> 7.50.6.0 )
                 - ipropsapiftp.dll
                        (File Version : 4.0.3.0 -> 7.50.1.0 )

                 - PS-API Interface Specifications
                        (File Version : 7.4 R01 -> 7.5 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.1 R04 -> 1.1 R05 )
                 - PS-LOOKUP Interface Specifications
                        (File Version : 1.0 R06 -> 1.0 R07 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                   WJ-NV300
                   WV-SFV311, WV-SFV310
                   WV-SFR311, WV-SFR310
                   WV-SFN311, WV-SFN310
                 
                 [PS-API]
                 - WJ-NV300シリーズに対応しました。
                 - 3シリーズカメラに対応しました。

  2014.06.04 ----------------------------------------------------------------
  SDKバージョン: V7.40.10
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 7.10.1.0 -> 7.30.1.0 )
                 - ipropsapi.dll
                        (File Version : 7.10.2.0 -> 7.30.1.0)
                 - ipropsapidevice.dll
                        (File Version : 7.20.5.0 -> 7.40.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 7.10.14.0 -> 7.40.9.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 7.10.8.0 -> 7.40.2.0 )
                 - qnuladapter.ax
                        (File Version : 4.10.2.0 -> 7.40.1.0 )

                 - PS-API Interface Specifications
                        (File Version : 7.2 R01 -> 7.4 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.1 R03 -> 1.1 R04 )
                 - PS-LOOKUP Interface Specifications
                        (File Version : 1.0 R05 -> 1.0 R06 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                   WV-SFV631L/WV-SFN631L/WV-SFR631L
                   WV-SFV611L/WV-SFN611L/WV-SFR611L
                   WV-SW115
                 
                 [サポートするOS]
                 - サポートするOSにWindows 8.1 Proを追加しました。
                   (Modern UIモードは非対応。)
                 
                 [PS-API]
                 - 推奨環境情報を更新しました。
                 - WV-SFV631LシリーズおよびWV-SFV611Lシリーズの
                   H.264(1)～(4)の配信に対応しました。
                 - 全方位カメラに関する記載を更新しました。
                 - 以下のプロパティを追加しました。
                     DecResolutionMode

  2013.07.21 ----------------------------------------------------------------
  SDKバージョン: V7.20.05
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 7.10.5.0 -> 7.20.5.0 )
                 - PS-API Interface Specifications
                        (File Version : 7.1 R01 -> 7.2 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.1 R02 -> 1.1 R03 )
                 - PS-LOOKUP Interface Specifications
                        (File Version : 1.0 R04 -> 1.0 R05 )

  変更内容     : [サポートする製品]
                 - サポートする製品に以下のモデルを追加しました。
                   WV-SF448E
                   WV-SW598 / WV-SW598J
                   WV-SW158
                   WV-SF138
                   WV-ST162 / BB-ST162
                   WV-ST165 / BB-ST165
                   WV-SW175 / BB-SW175
                   WV-SW174W / BB-SW174W
                   WV-SW172 / BB-SW172
                   WV-SP307
                   WV-SF337
                   WJ-GXE100 / DG-GXE100

  2013.06.28 ----------------------------------------------------------------
  SDKバージョン: V7.10.13
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 7.0.2.0 -> 7.10.1.0 )
                 - ipropsapi.dll
                        (File Version : 7.0.6.0 -> 7.10.2.0 )
                 - ipropsapidevice.dll
                        (File Version : 7.0.5.0 -> 7.10.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 7.0.15.0 -> 7.10.14.0 )
                 - ipropsapiftp.dll
                        (File Version : 3.0.9.0 -> 4.0.3.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 7.0.8.0 -> 7.10.8.0 )
                 - libwrtsp.dll
                        (File Version : 1.0.5.1 -> 1.0.5.3 )
                 - PS-API Interface Specifications
                        (File Version : 7.0 R01 -> 7.1 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.1 R01 -> 1.1 R02 )
                 - PS-LOOKUP Interface Specifications
                        (File Version : 1.0 R03 -> 1.0 R04 )

  変更内容     : [サポートするOS]
                 - サポートするOSにWindows 8 Proを追加しました。
                   (Modern UIモードは非対応。)

                 [PS-API]
                 - 以下のメソッドを追加しました。
                     SetCameraImageCap

  2012.12.25 ----------------------------------------------------------------
  SDKバージョン: V7.00.15
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 6.0.1.0 -> 7.0.2.0 )
                 - ipropsapi.dll
                        (File Version : 6.0.4.0 -> 7.0.6.0 )
                 - ipropsapidevice.dll
                        (File Version : 6.0.9.0 -> 7.0.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 6.0.17.0 -> 7.0.15.0 )
                 - ipropsapiftp.dll
                        (File Version : 3.0.8.0 -> 3.0.9.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 6.0.10.0 -> 7.0.8.0 )
                 - PS-API Interface Specifications
                        (File Version : 6.0 R02 -> 7.0 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R08 -> 1.1 R01 )
                 - PS-LOOKUP Interface Specifications
                        (File Version : 1.0 R02 -> 1.0 R03 )

  変更内容     : [サポートする製品]
                 - サポートする製品にSF438シリーズ、SW458シリーズを追加しました。
                   (全方位ネットワークカメラ対応)

                 [PS-API]
                 - 以下のメソッドを追加しました。
                     CamSnapShot

                 - 以下のメソッドを削除しました。
                     SetIntelligentView
                     GetIntelligentView
                     SetIntelligentViewColor
                     GetIntelligentViewColor
                     SetIntelligentViewSize
                     GetIntelligentViewSize
                     SetIntelligentViewTrackTime
                     GetIntelligentViewTrackTime

  2012.7.11 ----------------------------------------------------------------
  SDKバージョン: V6.00.17
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapivideo.dll
                        (File Version : 6.0.15.0 -> 6.0.17.0 )
                 - PS-API Interface Specifications
                        (File Version : 6.0 R01 -> 6.0 R02 )

  変更内容     : [サポートする製品]
                 - サポートする製品にSF539シリーズ、SF549シリーズを追加しました。

                 [PS-API]
                 - 以下の不具合に対応しました。
                   > ライブ・再生を行ってから、映像が表示される前に
                     描画サイズを変更した場合に、表示が正しく行われない場合がある

  2012.5.15 ----------------------------------------------------------------
  SDKバージョン: V6.00.15
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 5.0.3.0 -> 6.0.1.0 )
                 - ipropsapi.dll
                        (File Version : 5.0.6.0 -> 6.0.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 5.0.11.0 -> 6.0.9.0 )
                 - ipropsapivideo.dll
                        (File Version : 5.0.16.0 -> 6.0.15.0 )
                 - ipropsapidsfilters.ax            
                        (File Version : 5.0.14.0 -> 6.0.10.0 )

  変更内容     : [PS-API]
                 - StreamID対応
                     StreamID情報をレコーダから取得する。
                     StreamIDモードで動作するか否かを設定する。
                     StreamIDモードでライブおよびネットワーク再生を行う。
                     (対象機器 : ND400, NV200, HD616/716)
                 - ログイン結果状態取得
                     ログイン結果(成功または不成功理由)を取得する。
                 - UID最大数/使用数取得
                     UID情報をレコーダから取得する。
                     (対象機器 : ND400, NV200, HD616/716)
                 - UID先優先/後優先設定
                     レコーダのUID先優先/後優先設定を行う。
                     (対象機器 : ND400, NV200, HD616/716)
                 - NV200(NVF20)統計データ取得機能
                     (対象機器 : NV200)

                 - 以下のメソッドを追加しました。
                     GetSIDInfo
                     GetUIDInfo
                     GetLoginStatus
                     GetStatisticsData
                     SetUIDPriority
                     
                 - 以下のプロパティを追加しました。
                     SIDMode
                     SIDInfoMode
                     SIDInfoMax
                     SIDInfoUse
                     UIDInfoMax
                     UIDInfoUse

  2012.2.29 ----------------------------------------------------------------
  SDKバージョン: V6.00.02 (Beta-version release)
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 5.0.3.0 -> 6.0.1.0 )
                 - ipropsapi.dll
                        (File Version : 5.0.6.0 -> 6.0.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 5.0.11.0 -> 6.0.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 5.0.16.0 -> 6.0.3.0 )
                 - ipropsapidsfilters.ax            
                        (File Version : 5.0.14.0 -> 6.0.2.0 )

  変更内容     : [PS-API]
                 - StreamID対応
                     StreamID情報をレコーダから取得する。
                     StreamIDモードで動作するか否かを設定する。
                     StreamIDモードでライブおよびネットワーク再生を行う。
                     (対象機器 : ND400, NV200, HD616/716)
                 - ログイン結果状態取得
                     ログイン結果(成功または不成功理由)を取得する。
                 - UID最大数/使用数取得
                     UID情報をレコーダから取得する。
                     (対象機器 : ND400, NV200, HD616/716)
                 - UID先優先/後優先設定
                     レコーダのUID先優先/後優先設定を行う。
                     (対象機器 : ND400, NV200, HD616/716)

                 - 以下のメソッドを追加しました。
                     GetSIDInfo
                     GetUIDInfo
                     GetLoginStatus
                     
                 - 以下のプロパティを追加しました。
                     SIDMode
                     SIDInfoMode
                     SIDInfoMax
                     SIDInfoUse
                     UIDInfoMax
                     UIDInfoUse

  2012.1.12 ----------------------------------------------------------------
  SDKバージョン: V5.00.16
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 4.10.2.0 -> 5.0.3.0)
                 - ipropsapi.dll
                        (File Version : 4.10.6.0 -> 5.0.6.0)
                 - ipropsapidevice.dll
                        (File Version : 4.10.4.0 -> 5.0.11.0)
                 - ipropsapivideo.dll
                        (File Version : 4.10.20.0 -> 5.0.16.0)
                 - ipropsapiftp.dll
                        (File Version : 1.0.20.0 -> 3.0.8.0)
                 - ipropsapishmlogger.dll
                        (File Version : 1.0.1.0 -> 1.0.3.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 4.10.14.0 -> 5.0.14.0)
                 - PS-API Interface Specifications
                        (File Version : 4.1 R01 -> 5.0 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R07 -> 1.0 R08 )

                 以下のファイルが追加されました。
                 - pslookup.ocx
                 - pslookup.dll

                 以下のファイルが削除されました。
                 - stdadapter.ax

  変更内容     : [サポートする製品]
                 - サポートする製品にSF135シリーズ、SW155シリーズ、SW396シリーズを追加しました。

                 [PS-API]
                 - ハードウェア環境のOSにMicrosoft Windows Server 2008 R2 SP1を追加しました。
                 - dll/ocx/ax ファイルにデジタル署名を付与しました。

                 - スムーズ再生
                   ND400, NV200, HD600/700の高速再生および逆高速再生のスムーズ再生モードに
                   対応しました。
                 - レコーダからのカメラ設定情報取得
                   レコーダに登録されたカメラ設定情報をレコーダから取得機能を追加しました。
                 - ビットマップオーバーレイ
                   映像表示に指定したビットマップをオーバーレイする機能を追加しました。
                 - IPv6対応
                   IPv6プロトコルに対応しました。(PS-ALARMは対応していません。)
                 - RTPポート固定モード
                   MPEG-4/H.264ストリームの受信ポートを指定したポートに固定する機能を追加しました。

                 - 以下のメソッドを追加しました。
                     SetCameraTime
                     TitleOperationEx
                     BoxOperationEx
                     BitmapOperationEx
                     
                 - 以下のプロパティを追加しました。
                     RtpPortMode
                     RtpPortRange
                     FastPlayMode

                 [PS-ALARM]
                 - ハードウェア環境のOSにMicrosoft Windows Server 2008 R2 SP1を追加しました。
                 - dll/ocx ファイルにデジタル署名を付与しました。

                 [PS-LOOKUP]
                 -  初版リリース
                 - dll/ocx ファイルにデジタル署名を付与しました。

  2011.11.25 ----------------------------------------------------------------
  SDKバージョン: V4.10.20
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapivideo.dll
                        (File Version : 4.10.19.0 -> 4.10.20.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 4.10.13.0 -> 4.10.14.0)

  変更内容     : [PS-API]
                 - ファイル再生において、一時停止中に録画データのない時間帯に
                   PlayControlByTimeでジャンプすると、黒画スキップが行われない
                   不具合を修正しました。

  2011.08.31 ----------------------------------------------------------------
  SDKバージョン: V4.10.19
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 4.0.6.0 -> 4.10.2.0)
                 - ipropsapi.dll
                        (File Version : 4.0.8.0 -> 4.10.6.0)
                 - ipropsapidevice.dll
                        (File Version : 4.0.8.0 -> 4.10.4.0)
                 - ipropsapivideo.dll
                        (File Version : 4.0.26.0 -> 4.10.19.0)
                 - ipropsapiftp.dll
                        (File Version : 1.0.19.0 -> 1.0.20.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 4.0.14.0 -> 4.10.13.0)
                 - PS-API Interface Specifications
                        (File Version : 4.0 R01 -> 4.1 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R06 -> 1.0 R07 )
                 - vcredist_x86.exe
                        (File Version : 6.0.2900.2180 -> 2.0.50727.5672 )

                 以下のファイルが追加されました。
                 - qnuladapter.ax
                 - libwrtsp.dll
                 - RTSPlib.dll

  変更内容     : [PS-API]
                 - ハードウェア環境のOSにWindows 7 Professional SP1、
                   Microsoft Windows Server 2003を追加しました。
                 - サポートする製品にSW355シリーズ、SC384シリーズ、SW395シリーズ、
                   SF340シリーズを追加しました。
                 - カメラおよびエンコーダのインターネットモード(over HTTP)に対応しました。
                 - 以下のプロパティを追加しました。
                     InternetMode
                 - dll/ocx/ax ファイルにデジタル署名を付与しました。

                 [PS-ALARM]
                 - ハードウェア環境のOSにWindows 7 Professional SP1、
                   Microsoft Windows Server 2003を追加しました。
                 - サポートする製品にSW355シリーズ、SC384シリーズ、SW395シリーズ、
                   SF340シリーズを追加しました。
                 - dll/ocx/ax ファイルにデジタル署名を付与しました。

  2011.04.25 ----------------------------------------------------------------
  SDKバージョン: V4.00.29
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll   
                        (File Version : 4.0.7.0 -> 4.0.8.0)

  変更内容     : [PS-API]
                 - WJ-NV200のモデル名定義の誤りを修正しました。
                   > WJ-NV200のタイムゾーンがGMT-4:30からGMT+13:00の範囲に設定されている場合
                     GetDevTimeZone()で得られるタイムゾーン情報が不正となります。
                   > WJ-NV200に対し、GetDevStatus()を実行しても常に0が返ります。

  2011.02.08 ----------------------------------------------------------------
  SDKバージョン: V4.00.28
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 4.0.6.0 -> 4.0.8.0)
                 - ipropsapivideo.dll
                        (File Version : 4.0.19.0 -> 4.0.26.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 4.0.13.0 -> 4.0.14.0)

  変更内容     : [PS-API]
                 - StreamFormatの変更を伴うネットワーク再生において、
                   スレッドリークする問題を修正しました。

 2010.12.17 ----------------------------------------------------------------
  SDKバージョン: V4.00.21
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx
                        (File Version : 3.0.11.0 -> 4.0.6.0)
                 - ipropsapi.dll
                        (File Version : 3.0.9.1 -> 4.0.6.0)
                 - ipropsapidevice.dll
                        (File Version : 3.0.11.0 -> 4.0.7.0)
                 - ipropsapivideo.dll
                        (File Version : 3.0.38.0 -> 4.0.19.0)
                 - ipropsapiftp.dll
                        (File Version : 1.0.18.0 -> 1.0.19.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 3.0.28.0 -> 4.0.13.0)
                 - PS-API Interface Specifications
                        (File Version : 3.0 R01 -> 4.0 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R05 -> 1.0 R06 )

  変更内容     : [PS-API]
                 - サポートする製品にNV200 シリーズ、SP102/SP105/SC385 シリーズを
                   追加しました。
                 - 16:9画面表示に対応しました。
                 - CameraOperationメソッドに、プリセットシーケンス/パトロール/
                   オートソート機能を追加しました。
                 - 音声受話有りのネットワーク再生において、メモリリークする問題を
                   修正しました。
                 - 以下のメソッドを追加しました。
                     GetPicturePosition
                 - 以下のプロパティを追加しました。
                     PicturePosTopX
                     PicturePosTopY
                     PicturePosBottomX
                     PicturePosBottomY
                     PictureFitMode
                     FilePassword

                 [PS-ALARM]
                 - サポートする製品にNV200 シリーズ、SP102/SP105/SC385 シリーズを
                   追加しました。

  2010.10.15 ----------------------------------------------------------------
  SDKバージョン: V3.00.47
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.ocx 
                        (File Version : 3.0.8.0 -> 3.0.11.0 )
                 - ipropsapivideo.dll
                        (File Version : 3.0.35.0 -> 3.0.38.0 )

  変更内容     : [PS-API]
                 - 複数インスタンスでPlayLive/Playメソッドを非同期で
                   実行した場合に、ネットワークエラーが発生する不具合を
                   修正しました。
                 - TitleOperationメソッドでアクセスバイオレーションが
                   発生する不具合を修正しました。
                 - 複数のレコーダーを切り替えてネットワーク再生を行う場合、
                   SetMultiScreenChannelを使用すると映像が表示されない不具合を
                   修正しました。

  2010.09.09 ----------------------------------------------------------------
  SDKバージョン: V3.00.43
  変更ファイル : Readmeファイルが更新されました。

  変更内容     : [PS-API]
                 - "重要"を記載しました。
                   バイナリファイルやドキュメントに変更はありません。

  2010.08.23 ----------------------------------------------------------------
  SDKバージョン: V3.00.42
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 3.0.2.1 -> 3.0.9.1 )
                 - ipropsapidevice.dll
                        (File Version : 3.0.8.1 -> 3.0.11.0 )
                 - ipropsapivideo.dll
                        (File Version : 3.0.13.0 -> 3.0.35.0 )
                 - ipropsapiftp.dll
                        (File Version : 1.0.16.0 -> 1.0.18.0 )
                 - ipropsapishmlogger.dll
                        (File Version : 1.0.0.3 -> 1.0.1.0 )
                 - ipropsapidsfilters.ax            
                        (File Version : 3.0.11.0 -> 3.0.28.0 )
                 - stdadapter.ax            
                        (File Version : 3.0.6.0 -> 3.0.7.0 )
                 - ipropsapi.ocx
                        (File Version : 3.0.5.0 -> 3.0.8.0 )
                 - PS-API Interface Specifications
                        (File Version : 3.0 R01 -> 3.0 R02 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R04 -> 1.0 R05 )

  変更内容     : [PS-API]
                 - 以下のメソッドを追加しました。
                     MultiSyncPause
                     MultiSyncTime
                 - 以下のインタフェースにDSTモード引数を追加しました。
                     PlayControlByTime
                     OnRecordStatus
                 - VC++ 2005 ランタイムのインストール手順を追加しました。

  2010.06.23 ----------------------------------------------------------------
  SDKバージョン: V3.00.19
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 2.0.14.0 -> 3.0.2.1)
                 - ipropsapidevice.dll
                        (File Version : 2.0.25.0 -> 3.0.8.1)
                 - ipropsapivideo.dll
                        (File Version : 2.0.32.0 -> 3.0.13.0)
                 - ipropsapiftp.dll
                        (File Version : 1.0.15.0 -> 1.0.16.0)
                 - rphlib.dll                       
                        (File Version : 1.0.2.0 -> 1.1.1.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 2.0.21.0 -> 3.0.11.0)
                 - ipropsapi.ocx
                        (File Version : 2.0.16.0 -> 3.0.5.0)
                 - PS-API Interface Specifications
                        (File Version : 2.0 R03 -> 3.0 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R03 -> 1.0 R04 )

                 以下のファイルが追加されました。
                 - ipropsapishmlogger.dll           
                 - stdadapter.ax                    

                 以下のファイルが削除されました。
                 - HdrDecoderPS.ax                  
                 - ReceiverPS.ax                    

  変更内容     : [PS-API]
                 - 画像認識機能を追加しました。
                 - デジタルズーム機能、オーバーレイ機能を追加しました。
                 - スナップショット機能を追加しました。
                 - 音声受信機能、音声送信機能を追加しました。
                 - ネットワークカメラのオートバックフォーカスおよびスーパーダイナミックを
                   制御する機能を追加しました。
                 - ネットワークカメラのAUXを制御する機能を追加しました。
                 - 以下のメソッドを追加しました。
                     ClearWaitingFunc
                     GetWaitingFuncCount
                     GetDeviceLog
                     GetDevCurrentInfo
                     GetInfoString
                     VmdSearchEx
                     SearchCancel
                     PlayControlByTime
                     GetImageResolution
                     DigitalZoomMove
                     GetDigitalZoomPosition
                     SetInteligentView 
                     GetInteligentView 
                     SetInteligentViewColor
                     GetInteligentViewColor 
                     SetInteligentViewSize 
                     GetInteligentViewSize 
                     SetInteligentViewTrackTime
                     GetInteligentViewTrackTime
                     TitleOperation
                     GetTitle
                     BoxOperation
                     SaveJpegImage
                     GetJpegImage
                     SaveBitmapImage
                     GetBitmapImage
                     AudioSend
                     GetAudioSendStatus
                     CameraCentering
                     CameraAuxControl
                     GetCameraAuxStatus
                 - 以下のプロパティを追加しました。
                     SearchMultiChMask
                     SkipRecordGap
                     MultiScreenChannel
                     DigitalZoom
                     DigitalZoomMode
                     DigitalZoomPositionX
                     DigitalZoomPositionY
                     ImageResolutionHeight
                     ImageResolutionWidth
                     AudioRcvEnable
                     AudioRcvVolume
                     AudioRcvMute
                     AudioSendVolume
                     AudioSendMute
                     OnRecordStatusEnable
                 - 以下のイベントを追加しました。
                     OnRecordStatus

                 [PS-ALARM]
                 - ファイルプロパティの社名を変更しました。

  2010.03.15 ----------------------------------------------------------------
  SDKバージョン: V2.00.43
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 2.0.12.0 -> 2.0.14.0)
                 - ipropsapidevice.dll
                        (File Version : 2.0.24.0 -> 2.0.25.0)
                 - ipropsapivideo.dll
                        (File Version : 2.0.26.0 -> 2.0.32.0)
                 - ipropsapiftp.dll
                        (File Version : 1.0.13.0 -> 1.0.15.0)
                 - rphlib.dll                       
                        (File Version : 1.0.1.0 -> 1.0.2.0)
                 - HdrDecoderPS.ax                  
                        (File Version : 1.1.5.0 -> 1.1.6.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 2.0.18.0 -> 2.0.21.0)
                 - ReceiverPS.ax                    
                        (File Version : 2.0.18.0 -> 2.0.21.0)
                 - ipropsapi.ocx
                        (File Version : 2.0.14.0 -> 2.0.16.0)
                 - psalarmrcv.dll                   
                        (File Version : 1.0.7.0 -> 1.0.8.0)
                 - psalarmrcv.ocx                   
                        (File Version : 1.0.7.0 -> 1.0.8.0)
                 - PS-API Interface Specifications
                        (File Version : 2.0 R02 -> 2.0 R03 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R02 -> 1.0 R03 )

  変更内容     : [PS-API]
                 - 以下の不具合を修正しました。
                   - アプリケーションから以下の順番でメソッドを呼び出した
                     場合に、library errorが発生する。
                     [Rewind - Pause - Rewind]
                   - Live受信中にネットワーク異常が発生した後、PlayControl
                     (ライブ停止 : command=1)の応答が返らなくなるケースがある。
                   - HD300シリーズのユーザ認証有りの場合に、Openがエラーとなる。
                   - 非同期でメソッド呼出を実行した直後に、同期でメソッド呼出を
                     実行するとSDKエラーが発生し、操作不能になる場合がある。
                   - 非同期呼び出しのコールバック処理中に、非同期でメソッドの
                     呼び出しを行うと、実行されない場合がある。
                 - ファイルプロパティの社名を変更しました。

                 [PS-ALARM]
                 - ファイルプロパティの社名を変更しました。

  2009.12.24 ----------------------------------------------------------------
  SDKバージョン: V2.00.38
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapi.dll
                        (File Version : 2.0.11.0 -> 2.0.12.0)
                 - ipropsapidevice.dll
                        (File Version : 2.0.23.0 -> 2.0.24.0)
                 - ipropsapivideo.dll
                        (File Version : 2.0.23.0 -> 2.0.26.0)
                 - ipropsapidsfilters.ax
                        (File Version : 2.0.17.0 -> 2.0.18.0)
                 - ReceiverPS.ax
                        (File Version : 2.0.17.0 -> 2.0.18.0)
                 - ipropsapi.ocx
                        (File Version : 2.0.13.0 -> 2.0.14.0)
                 - PS-API Interface Specifications for ActiveX English.pdf
                        (File Version : 2.0 R02(Dec.1,2009) -> 2.0 R02(Dec.24,2009) )

  変更内容     : [PS-API]
                 - 以下の点を改善しました。
                   - 以下の条件でPlayLiveを行った場合、エラーを返すように変更しました。
                     (1) カメラに設定された撮像モードが「1.3Mピクセル」で、
                         PS-APIに設定されたJPEGResolutionが「2048」の場合。
                     (2) カメラに設定された撮像モードが「3Mピクセル」で、
                         PS-APIに設定されたJPEGResolutionが「320」の場合。

                 - 以下の不具合を修正しました。
                   - 複数インスタンスでカメラのJPEGライブを受信している場合に、
                     ネットワークエラーが発生する不具合を修正しました。
                   - C#で作成したアプリケーションからGetDevTimeZoneメソッド
                     またはRecCtrlメソッドを使用した場合に、異常終了することがある
                     不具合を修正しました。
                   - Search、SearchExで検索結果が(16の倍数+1)件の場合に
                     最後の1件が取得できない不具合の修正。

                 - PS-API Interface Specifications for ActiveX Englishの誤記を修正。

  2009.12.01 ----------------------------------------------------------------
  SDKバージョン: V2.00.34
  
  変更ファイル : 以下のファイルが更新されました。
                 - PS-API Interface Specifications
                        (File Version : 1.2 R03 -> 2.0 R02)
                 - ipropsapi.dll
                        (File Version : 1.20.6.0 -> 2.0.11.0)
                 - ipropsapidevice.dll
                        (File Version : 1.20.12.0 -> 2.0.23.0)
                 - ipropsapivideo.dll
                        (File Version : 1.20.12.0 -> 2.0.23.0)
                 - HdrDecoderPS.ax
                        (File Version : 1.1.1.0 -> 1.1.5.0)
                 - ipropsapi.ocx
                        (File Version : 1.20.5.0 -> 2.0.13.0)
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 -> 1.0 R02)
                 - psalarmrcv.dll
                        (File Version : 1.0.6.0 -> 1.0.7.0)
                 - psalarmrcv.ocx
                        (File Version : 1.0.6.0 -> 1.0.7.0)

                 以下のファイルが追加されました。
                 - ipropsapiftp.dll
                 - rphlib.dll
                 - ipropsapidsfilters.ax
                 - ReceiverPS.ax

                 以下のファイルが削除されました。
                 - H3rFileReaderPS.ax
                 - HdrHttpReceiverPS.ax
                 - JpegDecoderPSND.ax
                 - JpegHttpReceiverPSCAM.ax
                 - JpegHttpReceiverPSND.ax
                 - JpegN3rFileReaderPS.ax
                 - Mp4RtpRphPS.ax
                 - Mpeg4HttpReceiverPSND.ax
                 - Mpeg4N3rFileReaderPS.ax
                 - PlaybackPS.ax
                 - RawDataReceiver.ax
                 - RTPReceiverPSCAM.ax
                 - RTPReceiverPSND.ax
              
  変更内容     : [PS-API]
                 - サポートする製品にHD600/700 シリーズ、NP502/NW502S シリーズ、
                   HD309Aを追加しました。
                 - H.264に対応しました。
                 - FTPダウンロード機能を追加しました。
                 - NetworkDiskRecorderの自動フォーマット切替機能を追加しました。
                 - マルチキャスト設定の自動取得機能を追加しました。
                 - 最新レコード再生機能を追加しました。
                 - サポートする開発環境にVisual C#を追加しました。
                 - 以下のメソッドを追加しました。
                     SearchEx
                     GetDevTimeZone
                     FtpGet
                     FtpCancel
                     FtpServerClose
                     GetFtpStatus
                     GetFtpTransRate
                     GetFtpTransByte
                 - 以下のプロパティを追加しました。
                     SearchResultEx
                     H264Port
                     H264Resolution
                     MulticastAutoConf
                     StreamNumber
                     TransFrameRate
                     FtpPort
                     FtpTransMode
                     OnSearchExCBEnable
                     OnFtpStatusCBEnable
                 - 以下のイベントを追加しました。
                     OnSearchExCB
                     OnFtpStatusCB
                 - 高負荷な環境条件で長時間継続稼動した場合、
                   メモリが枯渇してしまう不具合を修正しました。

                 [PS-ALARM]
                 - psalarmrcv.dllのファイルプロパティを修正しました。
                 - サポートする開発環境にVisual C#を追加しました。

  2009.10.30 ----------------------------------------------------------------
  SDKバージョン: V1.20.29
  
  変更ファイル : 以下のファイルが更新されました。
                 - PS-API Interface Specifications
                        (File Version : 1.2 R02 -> 1.2 R03)
              
  変更内容     : - カメラ設置条件によるPan/Tilt方向を明記
                 - HttpTimeoutに関する注意事項を追記

  2009.10.07 ----------------------------------------------------------------
  SDKバージョン: V1.20.28
  
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapidevice.dll
                        (File Version : 1.20.11.0 -> 1.20.12.0)
                 - ipropsapivideo.dll
                        (File Version : 1.20.11.0 -> 1.20.12.0)
              
  変更内容     : - SetCameraPositionを連続で実行するとエラーが発生する
                   不具合を修正。

  2009.09.30 ----------------------------------------------------------------
  SDKバージョン: V1.20.27
  
  変更ファイル : 以下のファイルが追加されました。
                 - ipropsapidevice.dll
                 
  変更内容     : - CameraControlのFocus制御において、Focus=0を指定しても
                   Focus移動が停止しない問題を修正。

  2009.07.31 ----------------------------------------------------------------
  SDKバージョン: V1.20.25
  
  変更ファイル : 以下のファイルが追加されました。
                 - RawDataReceiver.ax
                 
  変更内容     : - 検索条件を追加しました。(PS-API)
                 - 独自アラーム受信機能を追加しました。(PS-ALARM)

  2009.06.28 ----------------------------------------------------------------
  SDKバージョン: V1.01.02
  
  変更ファイル : 以下のファイルが更新されました。
                 - ipropsapivideo.dll
                     (File Version : 1.0.2.0 -> 1.0.4.0)
                 - HdrDecoderPS.ax
                     (File Version : 1.1.0.0 -> 1.1.1.0)
                 
  変更内容     : - HD300の録画再生において、FFとREWを繰り返すと
                   メモリリークする問題を修正。

                 - PC/レコーダーの現在時刻が夏時間中であり、
                   かつ夏時間に録画されたレコードを再生した場合に、
                   再生される映像が１時間ずれた時刻の映像となる問題を修正。

  2009.03.13 ----------------------------------------------------------------
  SDKバージョン: V1.01.00
  
  変更ファイル : 以下のファイルが更新されました。
                 - PS-API Interface Specifications for DLL Japanese.pdf
                     (File Version : 1.0 -> 1.1)
                 - PS-API Interface Specifications for ActiveX Japanese.pdf
                     (File Version : 1.0 -> 1.1)
                 - ipropsapivideo.dll
                     (File Version : 1.0.1.0 -> 1.0.2.0)
                 
  変更内容     : - カメラ用MPEG-4デコーダーもしくはレコーダー用MPEG-4デコーダーの
                   どちらをインストールしてもMPEG-4のライブ/再生ができるように
                   なりました。

  2009.02.17 ----------------------------------------------------------------
  SDKバージョン: V1.00.05
  
  変更ファイル : -
  
  変更内容     : 初版リリース


5. 謝辞
  - Panasonic thanks the following for reporting the vulnerability:

    Ariele Caltabiano (kimiya) working with HP's Zero Day Initiative. (ZDI-CAN-2752, ZDI-CAN-2753)

  - Panasonic thanks the following for reporting the vulnerability:

	kernelsmith working with HP's Zero Day Initiative. (ZDI-CAN-2940)


