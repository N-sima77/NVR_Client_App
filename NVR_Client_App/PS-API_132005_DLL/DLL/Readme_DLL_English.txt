#######################################################################
How to use PS-API DLL
                                               (c) i-PRO Co., Ltd. 2025
#######################################################################

< INDEX >
1. NOTE
2. VERSION INFORMATION
3. (unnecessary) ActiveX control install 
4. CHANGE HISTORY
5. ACKNOWLEDGMENTS


-----------------------------------------------------------------------
1. NOTE

  When you use the following development tool with C++ Class library,
  please choose "DLL".

  - Microsoft Visual C++ 2005
  - Microsoft Visual C++ 2012

  Please refer to each Interface specifications document for details.


2. VERSION INFORMATION

  Package Name : PS-API DLL
  SDK Version  : V13.20.05

  File Name    : PS-API_132005_DLL.zip

  +========================================================================+
  | // IMPORTANT //                                                        |
  |  * To use this SDK package,                                            |
  |    please install the runtime component of Visual C++ library.         |
  |                                                                        |
  |  * If the different version PS-API has been already installed,         |
  |    please uninstall it, then install the new one.                      |
  +========================================================================+


                        File Name                        File Version
  ---------------------+--------------------------------+------------------
  [PS-API]
  Document              PS-API Interface Specifications 
                               for DLL Japanese.pdf         13.20 R01
                        PS-API Interface Specifications 
                               for DLL English.pdf          13.20 R01

  Binary                ipropsapi.dll                       13.10.4.0
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
                               for DLL Japanese.pdf         1.2 R09
                        PS-ALARM Interface Specifications 
                               for DLL English.pdf          1.2 R09

  Binary                psalarmrcv.dll                      1.0.11.0

  [PS-LOOKUP]
  Document              PS-LOOKUP Interface Specifications 
                               for DLL Japanese.pdf         1.0 R18
                        PS-LOOKUP Interface Specifications 
                               for DLL English.pdf          1.0 R18

  Binary                pslookup.dll                        1.0.7.0

  * It is no problem to use the file that includes the old company name.


3. For version (v12.80.03) or later, 
   installation of ActiveX control is no longer required.


4. CHANGE HISTORY
  2025.07.31 ---------------------------------------------------------------
  SDK Version  : V13.20.05
  Changed File : The following files are updated.

                 - ipropsapidevice.dll
                        (File Version : 13.10.3.0 -> 13.20.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 13.10.5.0 -> 13.20.2.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 13.10.1.0 -> 13.20.2.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
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
                 - Added white LED-related settings 
		   to the Command parameter of the CameraOperation method.

  2023.12.20 ---------------------------------------------------------------
  SDK Version  : V13.10.06
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 13.00.3.0 -> 13.10.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 13.00.5.0 -> 13.10.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 13.00.3.0 -> 13.10.5.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.90.2.0 -> 13.10.1.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
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
                 - Added a function to get the UID used when sending recorder CGI directly from the app.
                     (* However, the UID etc. set in the argument of Connect() 
                        should be the UID get with the GetUID property.)
                     ---Added property---
                      GetUIDEx

                 - Added function check the certificate of the connecting device during HTTPS communication.
                     ---Added property---                
                      SetCertificateVerifyEnable
                      GetCertificateVerifyEnable

  2023.03.10 ---------------------------------------------------------------
  SDK Version  : V13.00.08
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 12.90.1.0 -> 13.00.3.0 )
                 - ipropsapidevice.dll
                        (File Version : 12.90.3.0 -> 13.00.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.90.6.0 -> 13.00.3.0 )
                 - ipropsapissl.dll
                        (File Version : 12.00.2.0 -> 13.00.2.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---S series---
                     WV-S65302-Z2, WV-S65302-Z2-1
                     WV-S65501-Z1, WV-S65301-Z1, WV-S65301-Z1-1, WV-S61501-Z1, WV-S61301-Z1
                     WV-S65300-ZY, WV-S61300-ZY

                     ---X series---
                     WV-X86530-Z2, WV-X86530-Z2-1
                     WV-X86531-Z2, WV-X86531-Z2-1 

  2022.12.09 ---------------------------------------------------------------
  SDK Version  : V12.90.07
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---NU series---
                     WJ-NU101, WJ-NU201, WJ-NU300, WJ-NU301

  2022.09.30 ---------------------------------------------------------------
  SDK Version  : V12.80.03
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                        ---B series---
                        WV-B51300-F3, WV-B51300-F3W
                        WV-B54300-F3, WV-B54300-F3W

                 [PS-API]
                 - Enabled to output video and audio without installing ActiveX controls.
                 - Add Microsoft Windows Server 2022 Standard(Desktop Experience) to supported 
                 - Delete Microsoft Windows 8 Pro to supported OS.

                 [PS-ALARM]
                 - Add Microsoft Windows Server 2022 Standard(Desktop Experience) to supported 
                 - Delete Microsoft Windows 8 Pro to supported OS.

                 [PS-LOOKUP]
                 - Add Microsoft Windows Server 2022 Standard(Desktop Experience) to supported 
                 - Delete Microsoft Windows 8 Pro to supported OS.

  2022.06.30 ---------------------------------------------------------------
  SDK Version  : V12.70.02
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 12.50.1.0 -> 12.70.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.40.3.0 -> 12.60.3.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
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
  SDK Version  : V12.50.01
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 12.30.1.0 -> 12.50.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.30.1.0 -> 12.40.3.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.30.1.0 -> 12.40.3.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---S series---
                     WV-S8574L, WV-S8574LUX, WV-S8564L, WV-S8544L, WV-S8544LUX, WV-S8544
                     WV-S8573L, WV-S8573LUX, WV-S8563L, WV-S8543L, WV-S8543LUX, WV-S8543
                     WV-S15500-V3LN, WV-S15700-V2LN
		             WV-S22500-V3L, WV-S22700-V2L
 		             WV-S25500-V3LN, WV-S25700-V2LN
 
                 [PS-API]
                 - Add Microsoft Windows 11 Pro to supported OS.
                 - Add Microsoft Windows Server 2019 Standard(Desktop Experience) to supported OS.
  2022.01.31 ---------------------------------------------------------------
  SDK Version  : V12.30.01
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 12.00.4.0 -> 12.20.2.0 )
                 - ipropsapidevice.dll
                        (File Version : 12.10.1.0 -> 12.30.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.10.1.0 -> 12.30.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.10.1.0 -> 12.30.1.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---S series---
                     WV-S4156, WV-S4156J
                     WV-S4556L, WV-S4556LJ, WV-S4556LM
                     WV-S4176, WV-S4176J
                     WV-S4576L, WV-S4576LJ, WV-S4576LM
                     WV-S7130UX
                     WV-S7130WUX
 
                 [PS-API]
                 - Fixed the displayed video lag of SD backup playback recorded on the recorder.

  2021.08.31 ---------------------------------------------------------------
  SDK Version  : V12.10.01
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 12.00.4.0 -> 12.10.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 12.00.7.0 -> 12.10.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 12.00.4.0 -> 12.10.1.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---S series---
                     WV-S1536LT, WV-S1536L, WV-S1516L,  WV-S1516LD,
                     WV-S1515L,  WV-S1136,  WV-S1135V,  WV-S1116D,
                     WV-S1116,   WV-S1115V, WV-S2536LT, WV-S2536L,
                     WV-S2236L,  WV-S2136L, WV-S2136,   WV-S2135,
                     WV-S2116LD, WV-S2116L, WV-S2115
 
                 [PS-API]
                 - Fixed NW disconnect detection of NX series.

  2021.05.31 ---------------------------------------------------------------
  SDK Version  : V12.00.08
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---X series---
                     WV-X8571N
                     WV-X4172, WV-X4173, WV-X4573L
                     ---S series---
                     WV-S8531N
                     WV-S4151, WV-S4551L

                 [PS-API]
                 - Added function to support n3 and MP4 file download(HTTP/HTTPS) 
                   of NX Series.
                     ---Added Method---
                      HttpDownload
                 - Added the function to stop event recording of specified channel 
                   to the AlmOperation method.
                 - New resolution added for U series cameras.(2688 * 1520)

  2020.09.07 ---------------------------------------------------------------
  SDK Version  : V11.80.03
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File VerFion : 11.41.1.0 -> 11.80.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 11.60.2.0 -> 11.80.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.60.1.0 -> 11.80.3.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.40.1.0 -> 11.80.1.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---X series---
                     WV-X1571L, WV-X2571L, WV-X2271L
                     WV-X1551L, WV-X2551L, WV-X2251L
                     WV-X1534L, WV-X2533L, WV-X2232L
                     ---S series---
                     WV-S1572L, WV-S2572L, WV-S2272L
                     WV-S1552L, WV-S2552L, WV-S2252L

                 [PS-API]
                 - Addressed the issue that an error may occur 
                   when starting audio transmission while audio reception.
                 - Addressed the issue when may not be unmute.
                 - Partially changed the information acquisition method from NWDR.

  2020.05.29 ---------------------------------------------------------------
  SDK Version  : V11.60.02
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File VerFion : 11.20.1.0 -> 11.41.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 11.40.1.0 -> 11.60.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.40.1.0 -> 11.60.1.0 )
                 - ipropsapissl.dll
                        (File Version :     -     -> 10.50.1.0 )
                 - psalarmrcv.dll
                        (File Version : 1.0.10.0 -> 1.0.11.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
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
                 - Update the values of method/property related to 
                   additional model.
                 - Add HTTPS communication function.
                     ---Added property---
                      SetSecureCommunicationMode
                      GetSecureCommunicationMode
                 - Add function to correct the transmission interval of 
                   decoded pictures.
                     ---Added property---
                      SetTransIntervalMode
                      GetetTransIntervalMode
                      SetDecBufferNum
                      GetDecBufferNum
                 - Fix the issue that the program crushes by received timming of MP4data 
                   when execute HttpMP4Download Method.
                 - Add Microsoft Windows Server 2016 Standard(Desktop Experience) to supported OS.

                 [PS-ALARM]
                 - Changed the maximum value of argument messageText 
                   of OnAlarmRcv.(255 -> 520)
                 - Add Microsoft Windows Server 2016 Standard(Desktop Experience) to supported OS.

                 [PS-LOOKUP]
                 - Add Microsoft Windows Server 2016 Standard(Desktop Experience) to supported OS.

  2019.06.26 ---------------------------------------------------------------
  SDK Version  : V11.40.01
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 11.30.1.0 -> 11.40.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.30.1.0 -> 11.40.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.30.1.0 -> 11.40.1.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---S series---
                     WV-S1570L, S2570L, S2270L,
                     WV-S6532LN
                     ---X series---
                     WV-X6533LN

                 [PS-API]
                 - Update the values of method/property related to 
                   additional model.
                 - Fix the isuue that some live stop 
                   when starting live in multiple processes continuously.
                 - Add the Microsoft Visual C++ 2012 
                   to application development environment.

                 [PS-ALARM][PS-LOOKUP]
                 - Add the Microsoft Visual C++ 2012 
                   to application development environment.

  2019.03.28 ---------------------------------------------------------------
  SDK Version  : V11.30.01
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---NX series---
                     WJ-NX100
                     ---S series---
                     WV-S3130J, S3131L, S3110J, S3111L,
                     WV-S3530J, S3531L, S3510J, S3511L, S3532LM, S3512LM

                 [PS-API][PS-ALARM]
                 - Update the values of method/property related to 
                   additional model.

  2018.06.29 ---------------------------------------------------------------
  SDK Version  : V11.10.05
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 11.00.2.0 -> 11.10.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 11.00.8.0 -> 11.10.4.0 )
                 - ipropsapiftp.dll
                        (File Version : 10.30.1.0 -> 10.50.1.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 11.00.5.0 -> 11.10.3.0 )
                 - psalarmrcv.dll
                        (File Version : 1.0.9.0  @ -> 1.0.10.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---S series---
                     WV-S2550L, S1550L, S2250L
                     WV-S8530N
                     ---X series---
                     WV-X8570L

                 [PS-API][PS-ALARM]
                 - Update the values of method/property related to 
                   additional model.

  2018.03.23 ---------------------------------------------------------------
  SDK Version  : V11.00.08
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 10.30.4.0 -> 11.00.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 10.30.3.0 -> 11.00.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 10.30.14.0 -> 11.00.8.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 10.30.10.0 -> 11.00.5.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---X series---
                     WV-X4571L, X4171, X4170

                 [PS-API]
                 - Support 360 degree network camera (WV-X4571L, X4171, X4170).
                   Update the values of method/property.
                 - Support AAC audio format with PlayFile method.
                 - Changed the minimum value of argument focus of 
                   SetCameraPosition method / GetCameraPosition method.

  2017.12.12 ---------------------------------------------------------------
  SDK Version  : V10.30.15
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---NX series---
                     WJ-NX300
                     ---S series---
                     WV-S6131, S6111, S6530, S6130, S6110
                     WV-S4150, S4550
                 
                 [PS-API]
                 - Support MP4 file download(HTTP) of NX Series.
                     ---Added Method---
                      HttpMP4Download
                      GetMP4DownloadStatus
                      GetMP4DownloadTransRate
                     ---Added Listener---
                      OnMP4DownloadStatus
                      SetMP4DownloadListener
                 - Change the setting of substream receive of NX Series.
                     ---Added Property---
                      SetNXStreamNumber / GetNXStreamNumber
                 - Support HDD Standby Control of NX Series.
                 - Support AAC audio format with PlayLive method and 
                   Play method.
                     ---Added Property---
                      SetRcvAudioDec / GetRcvAudioDec

                    *In case of using multiple instances, 
                     please do not use AAC Format.

                 - Change company name some of file properties.

  2017.06.19 ---------------------------------------------------------------
  SDK Version  : V10.10.04
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 10.00.7.0 -> 10.10.3.0 )
                 - ipropsapivideo.dll
                        (File Version : 10.00.20.0 -> 10.10.2.0 )
                 - ipropsapiftp.dll
                        (File Version : 10.00.5.0 -> 10.10.2.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 10.00.18.0 -> 10.10.1.0 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                     ---NX series---
                     WJ-NX200
                     ---X series---
                     WV-X6531N, X6531NJ(Japan Only), X6531NH(China only)
                     WV-X6511N, X6511NJ(Japan Only)
                 
                 [Supported OS]
                 - Delete Microsoft Windows XP Professional SP3 /
                   Microsoft Windows Vista Business SP2 from supported OS.
                 
                 [PS-API]
                 - Change company name of file properties.
                 - Support WJ-NX200 series.
                 - Support X series cameras.

  2017.02.21 ---------------------------------------------------------------
  SDK Version  : V10.00.24
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
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
                 - Support H.265 format.
                 - Update the System Requirement.
                 - Support WJ-NX series Network Disk Recorder.
                 - Support Aero PTZ camera.
                 - Support S series cameras.
                 - The following Method are added.
                     ---Method---
                     CameraWiperControl

  2016.11.02 ---------------------------------------------------------------
  SDK Version  : V9.60.13
  Changed File : The following files are updated.
                 - ipropsapivideo.dll
                        (File Version : 9.50.14.0 -> 9.60.14.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.50.8.0 -> 9.60.10.0 )
		 - psalarmrcv.dll 
                        (File Version : 1.0.8.0 -> 1.0.9.0 )

  Description  : [PS-API]
                 - Fix the issue that might take time to stop live.

  2016.6.30 ---------------------------------------------------------------
  SDK Version  : V9.50.12
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 9.30.2.0 -> 9.50.1.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.30.10.0 -> 9.50.14.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.30.8.0 -> 9.50.8.0 )

  Description  : [PS-API]
                 - Fix the issue that the program crushes 
                   when calling CamSnapShot twice.

  2016.4.17 ---------------------------------------------------------------
  SDK Version  : V9.40.02
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 9.30.7.0 -> 9.40.2.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.30.9.0 -> 9.30.10.0 )

  Description  : [PS-API]
                 - Add the following new models to supported products.
                     ---1 series---
                     WV-SFV130, WV-SFV110, WV-SFN130, WV-SFN110

  2016.2.1 ----------------------------------------------------------------
  SDK Version  : V9.30.13
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 9.20.4.0 -> 9.30.2.0 )
                 - ipropsapidevice.dll
                        (File Version : 9.0.5.0 -> 9.30.7.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.20.13.0 -> 9.30.9.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.20.1.0 -> 9.30.8.0 )

  Description  : [PS-API][PS-ALARM][PS-LOOKUP]
                 - Add Microsoft Windows Server 2012 Standard /
                   Microsoft Windows Server 2012 R2 Standard to supported OS.
                 - Delete Microsoft Windows Server 2003 Standard /
                   Microsoft Windows Server 2003 Enterprise from supported OS.

  2015.12.7 ----------------------------------------------------------------
  SDK Version  : V9.20.13
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 9.0.2.0 -> 9.20.4.0 )
                 - ipropsapivideo.dll
                        (File Version : 9.0.8.0 -> 9.20.13.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 9.0.6.0 -> 9.20.1.0 )

  Description  : [PS-API]
                 - Add the following new models to supported products.
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
                 - Add Microsoft Windows 10 Pro to supported OS.
                 - Add the restrictions when using Smart Coding function of network camera.
                 - Add the cropping functions.
                     ---Method---
                     SetCroppingRect, GetCroppingRect
                     SetCroppingDrawRect, GetCroppingDrawRect
                     SetCroppingDrawEnable, GetCroppingDrawEnable
                     SetCroppingMarker, GetCroppingMarker
                     ---Property---
                     CroppingEnabled

  2015.07.27 ----------------------------------------------------------------
  SDK Version  : V9.00.11
  Changed File : The following files are updated.
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

  Description  : [PS-API]
                 - Update recommended system environment information.
                 - Add the following new models to supported products.
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
  SDK Version  : V8.10.18
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 8.10.4.0 -> 8.10.5.0 )
                 - ipropsapivideo.dll
                        (File Version : 8.10.12.0 -> 8.10.15.0 )

  Description  : [PS-API]
                 - Enhanced security.

  2015.02.06 ----------------------------------------------------------------
  SDK Version  : V8.10.14
  Changed File : The following files are updated.
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

  Description  : [PS-API]
                 - Add the following new models to supported products.
                   WJ-NV250
                   WV-SFV481, WV-SFN480
                   WV-SPN531, WV-SPN311, WV-SPN310
                   WV-SPW631LT, WV-SPW631L, WV-SPW611L, WV-SPW611
                   BB-ST165A, BB-ST162A, BB-SW175A, BB-SW172A, BB-SW174WA, BB-SW384A
                 
                 [PS-API]
                 - Support 360 degree network camera (WV-SFV481, WV-SFN480).
                   Update the values of method/property.

  2014.08.25 ----------------------------------------------------------------
  SDK Version  : V7.50.12
  Changed File : The following files are updated.
                 - ipropsapivideo.dll
                        (File Version : 7.50.11.0 -> 7.50.13.0 )
                 - ipropsapidsfilters.ax
                        (File Version : 7.50.6.0 -> 7.50.8.0 )

  Description  : [PS-API]
                 - Fix the issue that PlayFile method doesn't work the N3R video
                   which is recorded with 360 degree network camera (WV-SF438, WV-SF448E, WV-SW458)
                   and firmware version 1.55 or later.

  2014.07.25 ----------------------------------------------------------------
  SDK Version  : V7.50.10
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                   WJ-NV300
                   WV-SFV311, WV-SFV310
                   WV-SFR311, WV-SFR310
                   WV-SFN311, WV-SFN310
                 
                 [PS-API]
                 - Support NV300 series.
                 - Support new 3 series cameras.

  2014.06.04 ----------------------------------------------------------------
  SDK Version  : V7.40.10
  Changed File : The following files are updated.
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

  Description  : [Supported Products]
                 - Add the following new models to supported products.
                   WV-SFV631L/WV-SFN631L/WV-SFR631L
                   WV-SFV611L/WV-SFN611L/WV-SFR611L
                   WV-SW115
                 
                 [Supported OS]
                 - Add Windows 8.1 Pro to supported OS.
                   (Modern UI Mode is not supported.)
                 
                 [PS-API]
                 - Update the System Requirement.
                 - Support H.264 (1)(2)(3)(4) for WV-SFV631L series 
                   and WV-SFV611L series.
                 - Update the description of 360 degree network camera.
                 - Add the following property.
                     DecResolutionMode

  2013.07.21 ----------------------------------------------------------------
  SDK Version  : V7.20.05
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                        (File Version : 7.10.5.0 -> 7.20.5.0 )
                 - PS-API Interface Specifications
                        (File Version : 7.1 R01 -> 7.2 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.1 R02 -> 1.1 R03 )
                 - PS-LOOKUP Interface Specifications
                        (File Version : 1.0 R04 -> 1.0 R05 )

  Description  : [Supported Products]
                 - Add the following new models to supported products.
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
  SDK Version  : V7.10.13
  Changed File : The following files are updated.
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

  Description  : [Supported OS]
                 - Add Windows 8 Pro to supported OS.
                   (Modern UI Mode is not supported.)

                 [PS-API]
                 - The following Method are added.
                     SetCameraImageCap

  2012.12.25 ----------------------------------------------------------------
  SDK Version  : V7.00.15
  Changed File : The following files are updated.
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

  Description  : [Supported Product]
                 - Add SF438 series and SW458 series to supported devices.
                   (360-degree network camera suppport.)

                 [PS-API]
                 - The following Method are added.
                     CamSnapShot

                 - The following Method are deleted.
                     SetIntelligentView
                     GetIntelligentView
                     SetIntelligentViewColor
                     GetIntelligentViewColor
                     SetIntelligentViewSize
                     GetIntelligentViewSize
                     SetIntelligentViewTrackTime
                     GetIntelligentViewTrackTime

  2012.7.11 ----------------------------------------------------------------
  SDK Version  : V6.00.17
  Changed File : The following files are updated.
                 - ipropsapivideo.dll
                        (File Version : 6.0.15.0 -> 6.0.17.0 )
                 - PS-API Interface Specifications
                        (File Version : 6.0 R01 -> 6.0 R02 )

  Description  : [Supported Product]
                 - Add SF539 series and SF549 series to supported devices.
                 
                 [PS-API]
                 - Addressed the following issue:
                   > When the displayed video size is changed between after 
                     starting Live/Playback and before displaying the video,
                     the displayed video image size may not be correct. 

  2012.5.15 ----------------------------------------------------------------
  SDK Version  : V6.00.15
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 5.0.6.0 -> 6.0.4.0 )
                 - ipropsapidevice.dll
                        (File Version : 5.0.11.0 -> 6.0.9.0 )
                 - ipropsapivideo.dll
                        (File Version : -> 5.0.16.0 -> 6.0.15.0 )
                 - ipropsapidsfilters.ax            
                        (File Version : -> 5.0.14.0 -> 6.0.10.0 )

  Description  : [PS-API]
                 - StreamID support
                     Acquire the StreamID information from recorder.
                     Set the switch StreamID mode.
                     Live/Playback with StreamID.
                     (For ND400, NV200, HD616/716)
                 - Login result status
                     Can acquire the login result status.
                 - Maximum / In use UID
                     Acquire the UID information from recorder. 
                     (For ND400, NV200, HD616/716)
                 - Change User Management Mode
                     Can change the user management mode between First-Come-First-Serve 
                     and Last-Come-First-Serve.
                     (For ND400, NV200, HD616/716)
                 - Get statistics data from NV200(NVF20).
                     (For NV200)

                 - The following Method are added.
                     GetSIDInfo
                     GetUIDInfo
                     GetLoginStatus
                     GetStatisticsData
                     SetUIDPriority

                 - The following Property are added.
                     SetSIDMode / GetSIDMod

  2012.2.29 ----------------------------------------------------------------
  SDK Version  : V6.00.02 (Beta-version release)
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 5.0.6.0 -> 6.0.1.0 )
                 - ipropsapidevice.dll
                        (File Version : 5.0.11.0 -> 6.0.3.0 )
                 - ipropsapivideo.dll
                        (File Version : -> 5.0.16.0 -> 6.0.3.0 )
                 - ipropsapidsfilters.ax            
                        (File Version : -> 5.0.14.0 -> 6.0.2.0 )

  Description  : [PS-API]
                 - StreamID support
                     Acquire the StreamID information from recorder.
                     Set the switch StreamID mode.
                     Live/Playback with StreamID.
                     (For ND400, NV200, HD616/716)
                 - Login result status
                     Can acquire the login result status.
                 - Maximum / In use UID
                     Acquire the UID information from recorder. 
                     (For ND400, NV200, HD616/716)
                 - Change User Management Mode
                     Can change the user management mode between First-Come-First-Serve 
                     and Last-Come-First-Serve.
                     (For ND400, NV200, HD616/716)

                 - The following Method are added.
                     GetSIDInfo
                     GetUIDInfo
                     GetLoginStatus

                 - The following Property are added.
                     SetSIDMode / GetSIDMod

  2012.1.12 ----------------------------------------------------------------
  SDK Version  : V5.00.16
  Changed File : The following files are updated.
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

                 The following files are added.
                 - pslookup.dll

                 The following files are deleted.
                 - stdadapter.ax

  Description  : [Supported Product]
                 - Add SF135 series, SW155 series and SW396 series to supported devices.

                 [PS-API]
                 - Add Microsoft Windows Server 2008 R2 SP1 to System Environment.
                 - Added digital sign to dll/ax files.

                 - Smooth Playback(Fast Forward/Rewind)
                   Support the new setting to switch between normal playback mode 
                   and smooth playback mode. (ND400, NV200, HD616/716)
                 - Camera setting data acquisition from a recorder
                   Can acquire the camera setting data registered in a recorder from the recorder.
                 - Bitmap overlay
                   Can overlay a specified bitmap image on a video. 
                 - IPv6 support
                   Support IPv6 protocol. (except PS-ALARM)
                 - Fixed RTP port setting
                   Can fix a specific port for receiving MPEG-4/H.264 stream.

                 - The following Method are added.
                     SetCameraTime
                     TitleOperationEx
                     BoxOperationEx
                     BitmapOperationEx

                 - The following Property are added.
                     SetRtpPortMode / GetRtpPortMode
                     SetRtpPortRange / GetRtpPortRange
                     SetFastPlayMode / GetFastPlayMode

                 [PS-ALARM]
                 - Add Microsoft Windows Server 2008 R2 SP1 to System Environment.
                 - Added digital sign to dll file.

                 [PS-LOOKUP]
                 - First release
                 - Added digital sign to dll file.

  2011.11.25 ----------------------------------------------------------------
  SDK Version  : V4.10.20
  Changed File : The following files are updated.
                 - ipropsapivideo.dll
                        (File Version : 4.10.19.0 -> 4.10.20.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 4.10.13.0 -> 4.10.14.0)

  Description  : [PS-API]
                 - Addressed the following issue:
                   In case of PlayFile, when jump to blank image time frame by using 
                   PlayControlByTime, the blank image skip doesn't work well.

  2011.08.31 ----------------------------------------------------------------
  SDK Version  : V4.10.19
  Changed File : The following files are updated.
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

                 The following files are added.
                 - qnuladapter.ax
                 - libwrtsp.dll
                 - RTSPlib.dll

  Description  : [PS-API]
                 - Add Windows 7 Professional PS1 and Microsoft Windows Server 2003
                   to System Environment.
                 - Add SW355 series, SC384 series, SW395 and SF340 series to supported devices.
                 - Support Internet Mode (over HTTP) of NW cameras and Encoder.
                 - The following Property are added.
                     SetInternetMode / GetInternetMode
                 - Added digital sign to dll/ax files.

                 [PS-ALARM]
                 - Add Windows 7 Professional PS1 and Microsoft Windows Server 2003
                   to System Environment.
                 - Add SW355 series, SC384 series, SW395 and SF340 series to supported devices.
                 - Added digital sign to dll/ax files.

  2011.04.25 ----------------------------------------------------------------
  SDK Version  : V4.00.29
  Changed File : The following files are updated.
                 - ipropsapidevice.dll   
                        (File Version : 4.0.7.0 -> 4.0.8.0)

  Description  : [PS-API]
                 - Addressed the following issue:
                    Correct the model name definition of WJ-NV200.
                    > GetDevTimeZone() returns incorrect timezone for WJ-NV200
                      if the timezone setting of WJ-NV200 is from GMT-4:30 to GMT+13:00.
                    > PS-API GetDevStatus() always return 0 with the WJ-NV200

  2011.02.08 ----------------------------------------------------------------
  SDK Version  : V4.00.28
  Changed File : The following files are updated.
                 - ipropsapi.dll
                        (File Version : 4.0.6.0 -> 4.0.8.0)
                 - ipropsapivideo.dll
                        (File Version : 4.0.19.0 -> 4.0.26.0)
                 - ipropsapidsfilters.ax            
                        (File Version : 4.0.13.0 -> 4.0.14.0)

  Description  : [PS-API]
                 - Addressed the following issue:
                     Thread leak occurs by network playback with changing StreamFormat.

  2010.12.17 ----------------------------------------------------------------
  SDK Version  : V4.00.21
  Changed File : The following files are updated.
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

  Description  : [PS-API]
                 - Add NV200 series, SP102/SP105/SC385 series to supported devices.
                 - Support 16:9 aspect ratio.
                 - Added Preset sequence / Patrol / Auto sort functions 
                   to CameraOperation method.
                 - Addressed the following issue:
                     Memory leak occur by network playback with audio reception.
                 - The following Method are added.
                     GetPicturePosition
                 - The following Property are added.
                     SetPictureFitMode / GetPictureFitMode
                     SetFilePassword / GetFilePassword

                 [PS-ALARM]
                 - Add NV200 series, SP102/SP105/SC385 series to supported devices.

  2010.10.15 ----------------------------------------------------------------
  SDK Version  : V3.00.47
  Changed File : The following files are updated.
                 - ipropsapivideo.dll
                        (File Version : 3.0.35.0 -> 3.0.38.0 )

  Description  : [PS-API]
                 - Addressed the following issue:
                   - When multiple instances call PlayLive/Play method
                     with the non-blocking mode, network error occurs.
                   - When one instance call Play method using SetMultiScreenChannel
                     after changing redorders, the playback isn't started.

  2010.09.09 ----------------------------------------------------------------
  SDK Version  : V3.00.43
  Changed File : Readme file is updated.

  Description  : [PS-API]
                 - Added "IMPORTANT" section.
                   Binaries and documents are not updated.

  2010.08.23 ----------------------------------------------------------------
  SDK Version  : V3.00.42
  Changed File : The following files are updated.
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
                 - PS-API Interface Specifications
                        (File Version : 3.0 R01 -> 3.0 R02 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R04 -> 1.0 R05 )

  Description  : [PS-API]
                 - The following Method are added.
                     MultiSyncPause
                     MultiSyncTime
                 - DST mode arguments are added to the following interfaces.
                     PlayControlByTime
                     OnRecordStatus
                 - Added the procedure of the VC++ 2005 runtime installation.

  2010.06.23 ----------------------------------------------------------------
  SDK Version  : V3.00.19
  Changed File : The following files are updated.
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
                 - PS-API Interface Specifications
                        (File Version : 2.0 R03 -> 3.0 R01 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R03 -> 1.0 R04 )

                 The following files are added.
                 - ipropsapishmlogger.dll           
                 - stdadapter.ax                    

                 The following files are deleted.
                 - HdrDecoderPS.ax                  
                 - ReceiverPS.ax                    

  Description  : [PS-API]
                 - Added the image recognition functions.
                 - Added the digital zoom frunctions and the overlay functions.
                 - Added the snap shot functions.
                 - Added the audio reception and transmission functions.
                 - Added the functions to control Auto Back Focus and Super Dynamic 
                   of a network camera.
                 - Added the functions to control AUX of a network camera.
                 - The following Method are added.
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
                     SnapShot
                     AudioSend
                     GetAudioSendStatus
                     CameraCentering
                     CameraAuxControl
                     GetCameraAuxStatus
                     SetRecordListener
                 - The following Property are added.
                     SetSearchMultiChMask / GetSearchMultiChMask
                     SetSkipRecordGap / GetSkipRecordGap
                     SetMultiScreenChannel / GetMultiScreenChannel
                     SetDigitalZoom / GetDigitalZoom
                     SetDigitalZoomMode / GetDigitalZoomMode
                     SetAudioRcvEnable / GetAudioRcvEnable
                     SetAudioRcvVolume / GetAudioRcvVolume
                     SetAudioRcvMute / GetAudioRcvMute
                     SetAudioSendVolume / GetAudioSendVolume
                     SetAudioSendMute / GetAudioSendMute
                 - The following Event is added.
                     OnRecordStatus

                 [PS-ALARM]
                 - None

  2010.03.15 ----------------------------------------------------------------
  SDK Version  : V2.00.43
  Changed File : The following files are updated.
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
                 - psalarmrcv.dll                   
                        (File Version : 1.0.7.0 -> 1.0.8.0)
                 - PS-API Interface Specifications
                        (File Version : 2.0 R02 -> 2.0 R03 )
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 R02 -> 1.0 R03 )

  Description  : [PS-API]
                 - Addressed the following issues:
                   - When the application call functions in the following 
                     procedure, "library error" occurs.
                     [rewind play - pause play - rewind play]
                   - PlayControl(Stop Live : command=1) method does not return
                     a value, after Network Error occurs during playing live.
                   - Open() method returns error, if the authentication setting 
                     of HD300 is enabled.
                   - PS-API notifies of the SDK error, if blocking operation 
                     is called rapidly after non-blocking operation was called.
                   - While the callback of another non-blocking operation 
                     is running, if the non-blockin method is called, 
                     it does not work.
                 - Change company name of file properties.

                 [PS-ALARM]
                 - Change company name of file properties.

  2009.12.24 ----------------------------------------------------------------
  SDK Version  : V2.00.38
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
                 - PS-API Interface Specifications for DLL English.pdf
                        (File Version : 2.0 R02(Dec.1,2009) -> 2.0 R02(Dec.24,2009) )

  Description  : [PS-API]
                 - Change the following point.
                   - When using PlayLive method with the following condition,
                     PS-API returns error.
                     (1) Image capture mode is set to "1.3 mega pixel" on NW camera,
                         and JPEGResolution is set to "2048" on PS-API.
                     (2) Image capture mode is set to "3 mega pixel" on NW camera,
                         and JPEGResolution is set to "320" on PS-API.

                 - Addressed the following issue:
                   - When multiple instances receive JPEG video stream of NW camera
                     with PlayLive method, "Network error" occurs.
                   - When using RecCtrl method method from 
                     the application using C# environment, access violation occurs.
                   - Fix the issue that the last search result item cannot be gotten
                     when total count of search result is "(16 * N) + 1".

                 - Correct the spelling in PS-API Interface Specifications 
                   for DLL English.

  2009.12.01 ----------------------------------------------------------------
  SDK Version  : V2.00.34
  
  Changed File : The following files are updated.
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
                 - PS-ALARM Interface Specifications
                        (File Version : 1.0 -> 1.0 R02)
                 - psalarmrcv.dll
                        (File Version : 1.0.6.0 -> 1.0.7.0)

                 The following files are added.
                 - ipropsapiftp.dll
                 - rphlib.dll
                 - ipropsapidsfilters.ax
                 - ReceiverPS.ax

                 The following files are deleted.
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

  Description  : [PS-API]
                   - Add HD600/700 series, NP502/NW502S series and HD309A to 
                     supported devices.
                   - Support H.264 format.
                   - Add FTP download functions.
                   - Support compressed video image for NetworkDiskRecorder.
                     (OnImage/DecodeImage)
                   - Add stream format auto-detect function for NetworkDiskRecorder.
                   - Add multicast address and port auto-detect function.
                   - Add function to start play by the latest record.
                   - The following functions are added.
                       SearchEx
                       GetDevTimeZone
                       FtpGet
                       FtpCancel
                       FtpServerClose
                       GetFtpStatus
                       GetFtpTransRate
                       GetFtpTransByte
                       SetH264Port / GetH264Port
                       SetH264Resolution / GetH264Resolution
                       SetMultiAutoConf / GetMulticastAutoConf
                       SetStreamNumber / GetStreamNumber
                       SetTransFrameRate / GetTransFrameRate
                       SetFtpPort / GetFtpPort
                       SetFtpTransMode / GetFtpTransMode
                   - The following Callback are added.
                       OnSearchExCB
                       OnFtpStatusCB
                   - The following Class is added.
                       ISearchResultEx
                     
                 [PS-ALARM]
                   - Correct the file property of psalarmrcv.dll.

  2009.10.30 ----------------------------------------------------------------
  SDK Version  : V1.20.29
  
  Changed File : The following files are updated.
                 - PS-API Interface Specifications
                     (File Version : 1.2 R02 -> 1.2 R03)
                 
  Description  : - Addressed the following issue:
                   - Add the description of Pan/Tilt direction depending 
                     on camera setting condition.
                   - Add the description of HttpTimeout.

  2009.10.07 ----------------------------------------------------------------
  SDK Version  : V1.20.28
  
  Changed File : The following files are updated.
                 - ipropsapidevice.dll
                     (File Version : 1.20.11.0 -> 1.20.12.0)
                 - ipropsapivideo.dll
                     (File Version : 1.20.11.0 -> 1.20.12.0)
                 
  Description  : - Addressed the following issue:
                   - Error occurs while calling SetCameraPosition() 
                     countinuously.
                   - Hung-up while calling DeleteIPSAPI().

  2009.09.30 ----------------------------------------------------------------
  SDK Version  : V1.20.27
  
  Changed File : The following files are added.
                 - ipropsapidevice.dll
                 
  Description  : - Addressed the following issue:
                   - About Focus control of CameraControl(),
                     Focus doesn't stop moving though specifying Focus=0.

  2009.07.31 ----------------------------------------------------------------
  SDK Version  : V1.20.25
  
  Changed File : The following files are added.
                 - RawDataReceiver.ax
                 
  Description  : - Add the following functions.
                   - Get compressed video image.(PS-API)
                   - Add Search condition.(PS-API)
                   - Receive Panasonic Alarm.(PS-ALARM)

  2009.06.28 ----------------------------------------------------------------
  SDK Version  : V1.01.02
  
  Changed File : The following files are updated.
                 - ipropsapivideo.dll
                     (File Version : 1.0.2.0 -> 1.0.4.0)
                 - HdrDecoderPS.ax
                     (File Version : 1.1.0.0 -> 1.1.1.0)
                 
  Description  : - Addressed the following issue:
                   Memory leak occur by repeating FF & REW (HD300).
                   
                 - Addressed the following issue:
                   When the current time of PC/Recorder is daylight saving time (DST)
                   and the  that was recorded in DST term is specified,
                   the video image is played back with a time lag of one hour.
                   
  2009.03.13 ----------------------------------------------------------------
  SDK Version  : V1.01.00
  
  Changed File : The following files are updated.
                 - PS-API Interface Specifications for DLL English.pdf
                     (File Version : 1.0 -> 1.1)
                 - PS-API Interface Specifications for ActiveX English.pdf
                     (File Version : 1.0 -> 1.1)
                 - ipropsapivideo.dll
                     (File Version : 1.0.1.0 -> 1.0.2.0)
                 
  Description  : - When either MPEG-4 decoder for Camera or MPEG-4 decoder 
                   for Recorder is installed in your environment, 
                   MPEG-4 LIVE and PLAY work.

  2009.02.17 ----------------------------------------------------------------
  SDK Version  : V1.00.05
  
  Changed File : -
  
  Description  : First release


5. ACKNOWLEDGMENTS
  - Panasonic thanks the following for reporting the vulnerability:

    Ariele Caltabiano (kimiya) working with HP's Zero Day Initiative. (ZDI-CAN-2752, ZDI-CAN-2753)

  - Panasonic thanks the following for reporting the vulnerability:

	kernelsmith working with HP's Zero Day Initiative. (ZDI-CAN-2940)

