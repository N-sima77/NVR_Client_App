Public Class Form1
    '****************************************************************
    '* Define
    '****************************************************************
    'LiveStatus 0:Start 1:Live
    Public gPlayStatus As Long = 0
    Public gxPosTopLeft As Long = 0
    Public gyPosTopLeft As Long = 0
    Public gxPosBottomRight As Long = 0
    Public gyPosBottomRight As Long = 0


    '****************************************************************
    '* Function Name        : Load
    '* Overview             : Load PSAPI & Initialize
    '****************************************************************
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Show the log window
        With Form2
            .Show()
        End With

        '----------------------------------------
        'Set properties
        '----------------------------------------
        With AxipropsapiCtrl1
            'Set properties to connect the device
            .IPAddr = "192.168.0.250"
            .DeviceType = 1
            .HttpPort = 80
            .UserName = "ADMIN"
            .Password = "12345"

            'Set properties for image format
            .StreamFormat = 0
            .JPEGResolution = 640
            .MPEG4Resolution = 640
            .H264Resolution = 640

            'Set properties for event
            .OnErrorEnable = 1
            .OnDevStatusEnable = 0
            .OnRecStatusEnable = 0
            .OnPlayStatusEnable = 1
            .OnImageRefreshEnable = 0
            .OnRecordStatusEnable = 0
            .OnOpStatusEnable = 0
            .OnAlmStatusEnable = 0

            .OnRecStatusCBEnable = 0
            .OnSearchCBEnable = 0
            .OnSearchExCBEnable = 1
            .OnPlayStatusCBEnable = 0
            .OnOpStatusCBEnable = 0
            .OnAlmStatusCBEnable = 0
            .OnFtpStatusCBEnable = 0
        End With

        '----------------------------------------
        'Connect to the device
        '----------------------------------------
        Dim lRet As Long

        AxipropsapiCtrl1.MouseUpEnable = 1
        AxipropsapiCtrl1.MouseDownEnable = 1

        lRet = AxipropsapiCtrl1.Open()
        Logging("[Function] Open:" & CStr(lRet))
    End Sub

    '****************************************************************
    '* Function Name        : FormClosed
    '* Overview             : Destroy log window
    '****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '----------------------------------------
        'Disconnect to the device
        '----------------------------------------
        Call_PlayStop()

        AxipropsapiCtrl1.Close()
        Logging("[Function] Close")

        '----------------------------------------
        'Set properties
        '----------------------------------------
        With AxipropsapiCtrl1
            'Set properties for event
            .OnErrorEnable = 0
            .OnDevStatusEnable = 0
            .OnRecStatusEnable = 0
            .OnPlayStatusEnable = 0
            .OnImageRefreshEnable = 0
            .OnRecordStatusEnable = 0
            .OnOpStatusEnable = 0
            .OnAlmStatusEnable = 0

            .OnRecStatusCBEnable = 0
            .OnSearchCBEnable = 0
            .OnSearchExCBEnable = 0
            .OnPlayStatusCBEnable = 0
            .OnOpStatusCBEnable = 0
            .OnAlmStatusCBEnable = 0
            .OnFtpStatusCBEnable = 0
        End With

        With Form2
            .Close()
        End With
    End Sub

    '****************************************************************
    '* Function Name        : Logging
    '* Overview             : Output Logs
    '****************************************************************
    Private Sub Logging(ByVal str As String)
        With Form2
            If .txt_Log.Text <> "" Then
                .txt_Log.Text = .txt_Log.Text & vbCrLf
            End If
            .txt_Log.Text = .txt_Log.Text & str
        End With
    End Sub

    '****************************************************************
    '* Function Name        : ShowResult
    '* Overview             : Output list Search result
    ' ****************************************************************
    Private Sub ShowResult()
        'Set Search Result to list
        'Define variables
        Dim i As Long
        Dim strnm As Integer
        Dim Endbuf As Integer
        Dim strbuf As String

        'List initialize
        Me.ListBox1.Items.Clear()

        strbuf = AxipropsapiCtrl1.SearchResult

        Endbuf = 1
        i = 0

        Do
            strnm = InStr(1, strbuf, vbCrLf)
            If (strnm = 0) Then
                strnm = InStr(1, strbuf, vbLf)
                If (strnm = 0) Then
                    Exit Do
                Else
                    Me.ListBox1.Items.Add(Strings.Left(strbuf, strnm))
                    strbuf = Strings.Right(strbuf, Len(strbuf) - strnm)
                    Me.ListBox1.SetSelected(Me.ListBox1.Items.Count - 1, True)
                End If
            Else
                Me.ListBox1.Items.Add(Strings.Left(strbuf, strnm - 1))
                strbuf = Strings.Right(strbuf, Len(strbuf) - strnm - 1)
                Me.ListBox1.SetSelected(Me.ListBox1.Items.Count - 1, True)
            End If
        Loop

    End Sub

    '****************************************************************
    '* Function Name        : ShowResultEx
    '* Overview             : Output list SearchEx/VMDSearchEx result
    ' ****************************************************************
    Private Sub ShowResultEx()
        'Set SearchEx Result to list
        'Define variables
        Dim i As Long
        Dim strnm As Integer
        Dim Endbuf As Integer
        Dim strbuf As String

        'List initialize
        Me.ListBox1.Items.Clear()

        strbuf = AxipropsapiCtrl1.SearchResultEx

        Endbuf = 1
        i = 0

        Do
            strnm = InStr(1, strbuf, vbCrLf)
            If (strnm = 0) Then
                strnm = InStr(1, strbuf, vbLf)
                If (strnm = 0) Then
                    Exit Do
                Else
                    Me.ListBox1.Items.Add(Strings.Left(strbuf, strnm))
                    strbuf = Strings.Right(strbuf, Len(strbuf) - strnm)
                    Me.ListBox1.SetSelected(Me.ListBox1.Items.Count - 1, True)
                End If
            Else
                Me.ListBox1.Items.Add(Strings.Left(strbuf, strnm - 1))
                strbuf = Strings.Right(strbuf, Len(strbuf) - strnm - 1)
                Me.ListBox1.SetSelected(Me.ListBox1.Items.Count - 1, True)
            End If
        Loop

    End Sub


    '****************************************************************
    '* Function Name        : Call_PlayStop
    '* Overview             : 
    '****************************************************************
    Private Sub Call_PlayStop()
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Stop Live
        If (gPlayStatus = 1) Then
            lCommand = 0
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] Play(Stop):" & CStr(lRet))

            AxipropsapiCtrl1.ClearImage()
            Logging("[Function] ClearImage")

            'Status:Stop
            gPlayStatus = 0
        End If
    End Sub

    '****************************************************************
    '* Function Name        : Call_ClearBox
    '* Overview             : 
    '****************************************************************
    Private Sub Call_ClearBox()
        'Define variables
        Dim lRet As Long
        Dim lId As Long
        Dim lCommand As Long
        Dim lColor As Long
        Dim lSize As Long

        'Draw Box
        lId = 1
        lCommand = 0
        lColor = 16777215
        lSize = 3
        lRet = AxipropsapiCtrl1.BoxOperation(lId, lCommand, lColor, lSize, 0, 0, 1, 1)

        gxPosTopLeft = 0
        gyPosTopLeft = 0
        gxPosBottomRight = 0
        gyPosBottomRight = 0
    End Sub

    '****************************************************************
    '* Function Name        : Search_Sync_Click
    '* Overview             : Start SearchEx of blocking mode
    '****************************************************************
    Private Sub bVMDSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bVMDSearch.Click
        'Define variables
        Dim lRet As Long
        Dim lchannel As Long
        Dim csStartTD As String
        Dim csEndTD As String
        Dim lmask As Long
        Dim laSensitivity As Long
        Dim laxTopLeft As Long
        Dim layTopLeft As Long
        Dim laxBottomRight As Long
        Dim layBottomRight As Long
        Dim lbSensitivity As Long
        Dim lbxTopLeft As Long
        Dim lbyTopLeft As Long
        Dim lbxBottomRight As Long
        Dim lbyBottomRight As Long
        Dim lcSensitivity As Long
        Dim lcxTopLeft As Long
        Dim lcyTopLeft As Long
        Dim lcxBottomRight As Long
        Dim lcyBottomRight As Long
        Dim ldSensitivity As Long
        Dim ldxTopLeft As Long
        Dim ldyTopLeft As Long
        Dim ldxBottomRight As Long
        Dim ldyBottomRight As Long
        Dim limageWidth As Long
        Dim limageHeight As Long
        Dim lBlockmode As Long

        Call_PlayStop()

        'Set properties
        lchannel = 1

        csStartTD = TextBox1.Text & "/" & TextBox2.Text & "/" & TextBox3.Text & " " & _
                    TextBox4.Text & ":" & TextBox5.Text & ":" & TextBox6.Text

        csEndTD = TextBox7.Text & "/" & TextBox8.Text & "/" & TextBox9.Text & " " & _
                  TextBox10.Text & ":" & TextBox11.Text & ":" & TextBox12.Text

        lmask = 1
        laSensitivity = 1
        laxTopLeft = gxPosTopLeft
        layTopLeft = gyPosTopLeft
        laxBottomRight = gxPosBottomRight
        layBottomRight = gyPosBottomRight
        lbSensitivity = 0
        lbxTopLeft = 0
        lbyTopLeft = 0
        lbxBottomRight = 0
        lbyBottomRight = 0
        lcSensitivity = 0
        lcxTopLeft = 0
        lcyTopLeft = 0
        lcxBottomRight = 0
        lcyBottomRight = 0
        ldSensitivity = 0
        ldxTopLeft = 0
        ldyTopLeft = 0
        ldxBottomRight = 0
        ldyBottomRight = 0
        limageWidth = 320
        limageHeight = 240
        lBlockmode = 1

        'VmdSearchEx
        lRet = AxipropsapiCtrl1.VmdSearchEx(lchannel, csStartTD, csEndTD, lmask, _
                                            laSensitivity, laxTopLeft, layTopLeft, laxBottomRight, layBottomRight, _
                                            lbSensitivity, lbxTopLeft, lbyTopLeft, lbxBottomRight, lbyBottomRight, _
                                            lcSensitivity, lcxTopLeft, lcyTopLeft, lcxBottomRight, lcyBottomRight, _
                                            ldSensitivity, ldxTopLeft, ldyTopLeft, ldxBottomRight, ldyBottomRight, _
                                            limageWidth, limageHeight, lBlockmode)
        Logging("[Function] VmdSearchEx:" & CStr(lRet) & "(Channel[" & CStr(lchannel) & _
                                                        "] Start[" & csStartTD & _
                                                        "] End[" & csEndTD & _
                                                        "] Mode[" & CStr(lBlockmode) & "])")
    End Sub

    '****************************************************************
    '* Function Name        : Button3_Click
    '* Overview             : play for SearchEx result
    ' ****************************************************************
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Define variables
        Dim lRet As Long

        'Search Cancel
        lRet = AxipropsapiCtrl1.SearchCancel()
        Logging("[Function] SearchCancel:" & CStr(lRet))
    End Sub

    '****************************************************************
    '* Function Name        : List1_DblClick
    '* Overview             : play for SearchEx result
    ' ****************************************************************
    Private Sub List1_DblClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        'Define variables
        Dim lPos As String
        Dim TIMEDATA As String
        Dim CHBUF As String

        Call_PlayStop()
        Call_ClearBox()

        If Me.ListBox1.Text() <> "" Then
            'Get listbox data
            lPos = InStr(Me.ListBox1.Text(), ",")
            If (lPos = 0) Then Exit Sub
            If (lPos = 1) Then Exit Sub

            'ch
            CHBUF = Strings.Left(Me.ListBox1.Text(), lPos - 1)

            'startTD, EndTD
            TIMEDATA = Mid(Me.ListBox1.Text(), 4)
            TIMEDATA = Strings.Left(TIMEDATA, 19)

            Dim lRet As Long
            lRet = AxipropsapiCtrl1.Play(CLng(CHBUF), TIMEDATA, 0)
            Logging("[Function] Play:" & CStr(lRet))

            If (lRet = 0) Then
                'Status:Play
                gPlayStatus = 1
            End If
        Else
            Logging("[Message] There is no result record.")
        End If
    End Sub


    '****************************************************************
    '* Function Name        : OnError
    '* Overview             : OnError listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnError(ByVal sender As System.Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent) Handles AxipropsapiCtrl1.OnError
        'Output Logs
        Logging("[OnError] errorCode[" & CStr(e.errorCode) & "] description[" & e.description & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnDevStatus
    '* Overview             : OnDevStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnDevStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnDevStatusEvent) Handles AxipropsapiCtrl1.OnDevStatus
        'Output Logs
        Logging("[OnDevStatus] channel[" & CStr(e.channel) & "] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnRecStatus
    '* Overview             : OnRecStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnRecStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusEvent) Handles AxipropsapiCtrl1.OnRecStatus
        'Output Logs
        Logging("[OnRecStatus] channel[" & CStr(e.channel) & "] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnPlayStatus
    '* Overview             : OnPlayStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnPlayStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent) Handles AxipropsapiCtrl1.OnPlayStatus
        'Output Logs
        Logging("[OnPlayStatus] channel[" & CStr(e.channel) & "] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnRecordStatus
    '* Overview             : OnRecordStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnRecordStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecordStatusEvent) Handles AxipropsapiCtrl1.OnRecordStatus
        'Output Logs
        Logging("[OnRecordStatus] type[" & CStr(e.recType) & "] timeDate[" & e.timeDate & "] nextRecTime[" & e.nextRecTime & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnImageRefresh
    '* Overview             : OnImageRefresh listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnImageRefresh(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxipropsapiCtrl1.OnImageRefresh
        'Output Logs
        Logging("[OnImageRefresh] No argument.")
    End Sub

    '****************************************************************
    '* Function Name        : OnOpStatus
    '* Overview             : OnOpStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnOpStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusEvent) Handles AxipropsapiCtrl1.OnOpStatus
        'Output Logs
        Logging("[OnOpStatus] channel[" & CStr(e.channel) & "] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnAlmStatus
    '* Overview             : OnAlmStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnAlmStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusEvent) Handles AxipropsapiCtrl1.OnAlmStatus
        'Output Logs
        Logging("[OnAlmStatus] channel[" & CStr(e.channel) & "] type[" & CStr(e.alarmtype) & "] timeDate[" & e.timeDate & "] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnRecStatusCB
    '* Overview             : OnRecStatusCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnRecStatusCB(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnRecStatusCBEvent) Handles AxipropsapiCtrl1.OnRecStatusCB
        'Output Logs
        Logging("[OnRecStatusCB] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnSearchCB
    '* Overview             : OnSearchCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnSearchCB(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxipropsapiCtrl1.OnSearchCB
        'Output Logs
        Logging("[OnSearchCB] Show Search result.")
        ShowResult()
    End Sub

    '****************************************************************
    '* Function Name        : OnSearchExCB
    '* Overview             : OnSearchExCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnSearchExCB(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxipropsapiCtrl1.OnSearchExCB
        'Output Logs
        Logging("[OnSearchExCB] Show Search result.")
        ShowResultEx()
    End Sub

    '****************************************************************
    '* Function Name        : OnPlayStatusCB
    '* Overview             : OnPlayStatusCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnPlayStatusCB(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusCBEvent) Handles AxipropsapiCtrl1.OnPlayStatusCB
        'Output Logs
        Logging("[OnPlayStatusCB] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnOpStatusCB
    '* Overview             : OnOpStatusCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnOpStatusCB(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnOpStatusCBEvent) Handles AxipropsapiCtrl1.OnOpStatusCB
        'Output Logs
        Logging("[OnOpStatusCB] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnAlmStatusCB
    '* Overview             : OnAlmStatusCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnAlmStatusCB(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnAlmStatusCBEvent) Handles AxipropsapiCtrl1.OnAlmStatusCB
        'Output Logs
        Logging("[OnAlmStatusCB] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnFtpStatusCB
    '* Overview             : OnFtpStatusCB callback event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnFtpStatusCB(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnFtpStatusCBEvent) Handles AxipropsapiCtrl1.OnFtpStatusCB
        'Output Logs
        Logging("[OnFtpStatusCB] status[" & CStr(e.status) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : MouseDown
    '* Overview             : MouseDown event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_MouseDownEvent(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_MouseDownEvent) Handles AxipropsapiCtrl1.MouseDownEvent
        gxPosTopLeft = e.x
        gyPosTopLeft = e.y
        Logging("[MouseDown] Position [X:" & CStr(e.x) & " Y:" & CStr(e.y) & "]")
    End Sub

    '****************************************************************
    '* Function Name        : MouseUp
    '* Overview             : MouseUp event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_MouseUpEvent(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_MouseUpEvent) Handles AxipropsapiCtrl1.MouseUpEvent
        'Define variables
        Dim lRet As Long
        Dim lxTmpTL As Long
        Dim lyTmpTL As Long
        Dim lxTmpBR As Long
        Dim lyTmpBR As Long
        Dim lId As Long
        Dim lCommand As Long
        Dim lColor As Long
        Dim lSize As Long

        gxPosBottomRight = e.x
        gyPosBottomRight = e.y
        Logging("[MouseUp] Position [X:" & CStr(e.x) & " Y:" & CStr(e.y) & "]")

        If (gxPosTopLeft > gxPosBottomRight) Then
            lxTmpTL = gxPosBottomRight
            lxTmpBR = gxPosTopLeft
        Else
            lxTmpTL = gxPosTopLeft
            lxTmpBR = gxPosBottomRight
        End If

        If (gyPosTopLeft > gyPosBottomRight) Then
            lyTmpTL = gyPosBottomRight
            lyTmpBR = gyPosTopLeft
        Else
            lyTmpTL = gyPosTopLeft
            lyTmpBR = gyPosBottomRight
        End If

        'Draw Box
        lId = 1
        lCommand = 1
        lColor = 16777215
        lSize = 3
        lRet = AxipropsapiCtrl1.BoxOperation(lId, lCommand, lColor, lSize, lxTmpTL, lyTmpTL, lxTmpBR, lyTmpBR)

        gxPosTopLeft = lxTmpTL
        gyPosTopLeft = lyTmpTL
        gxPosBottomRight = lxTmpBR
        gyPosBottomRight = lyTmpBR
    End Sub
End Class
