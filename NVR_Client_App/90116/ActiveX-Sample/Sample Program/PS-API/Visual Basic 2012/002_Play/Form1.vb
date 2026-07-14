Public Class Form1
    '****************************************************************
    '* Define
    '****************************************************************
    'LiveStatus 0:Start 1:Live
    Public gPlayStatus As Long = 0


    '****************************************************************
    '* Function Name        : Load
    '* Overview             : Load PSAPI & Initialize
    '****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            .OnSearchExCBEnable = 0
            .OnPlayStatusCBEnable = 0
            .OnOpStatusCBEnable = 0
            .OnAlmStatusCBEnable = 0
            .OnFtpStatusCBEnable = 0
            ' Added Ver5.0.1.0
            .FastPlayMode = 0   'normal
        End With

        ' Added Ver5.0.1.0
        CheckBox1.Checked = False

    End Sub

    '****************************************************************
    '* Function Name        : FormClosed
    '* Overview             : Destroy log window
    '****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '----------------------------------------
        ' Disconnect
        '----------------------------------------
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Stop
            lCommand = 0
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Stop):" & CStr(lRet))

            If lRet = 0 Then
                'Status:Stop
                gPlayStatus = 0
            End If

            AxipropsapiCtrl1.Close()
            Logging("[Function] Close ")

            AxipropsapiCtrl1.ClearImage()
            Logging("[Function] ClearImage")
        End If

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
    End Sub

    '****************************************************************
    '* Function Name        : ShowResultEx
    '* Overview             : Output list SearchEx/VMDSearchEx result
    ' ****************************************************************
    Private Sub ShowResultEx()
        'Set SearchEx Result to list
    End Sub


    '****************************************************************
    '* Function Name        : b_Stop_Click
    '* Overview             : PlayControl Stop
    '****************************************************************
    Private Sub b_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Stop.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Stop
            lCommand = 0
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Stop):" & CStr(lRet))

            If lRet = 0 Then
                'Status:Stop
                gPlayStatus = 0
            End If

            AxipropsapiCtrl1.Close()
            Logging("[Function] Close ")

            AxipropsapiCtrl1.ClearImage()
            Logging("[Function] ClearImage")
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_Pause_Click
    '* Overview             : PlayControl Pause
    '****************************************************************
    Private Sub b_Pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Pause.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Pause
            lCommand = 3
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Pause):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_PlayBack_Click
    '* Overview             : PlayControl Playback
    '****************************************************************
    Private Sub b_PlayBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PlayBack.Click
        'Define variables
        Dim lRet As Long
        Dim lChannel As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long
        Dim chDate As String

        'Check the play status
        If (gPlayStatus = 0) Then
            'Connect to the device
            lRet = AxipropsapiCtrl1.Open
            Logging("[Function] Open:" & CStr(lRet))

            If lRet > -1 Then
                'Start PlayBack
                lChannel = 1
                chDate = "2010/07/01 00:00:00"
                lBlockmode = 0
                lRet = AxipropsapiCtrl1.Play(lChannel, chDate, lBlockmode)
                Logging("[Function] Play:" & CStr(lRet))

                If lRet = 0 Then
                    'Status:PLAY
                    gPlayStatus = 1
                End If
            End If
        Else
            'Re-Start PlayBack
            lCommand = 4
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Playback):" & CStr(lRet))
        End If

    End Sub

    '****************************************************************
    '* Function Name        : b_Reverse_Click
    '* Overview             : PlayControl backward
    '****************************************************************
    Private Sub b_Reverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Reverse.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Backward
            lCommand = 5
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Backward):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_NextFrame_Click
    '* Overview             : PlayControl Next frame
    '****************************************************************
    Private Sub b_NextFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_NexrFrame.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Next Frame
            lCommand = 6
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Next Frame):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_PrevFrame_Click
    '* Overview             : PlayControl Previous Frame
    '****************************************************************
    Private Sub b_PrevFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PrevFrame.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Previous Frame
            lCommand = 7
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Previous Frame):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_FF_Click
    '* Overview             : PlayControl Fast Forward
    '****************************************************************
    Private Sub b_FF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_FF.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Fast forward
            lCommand = 8
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Fast Forward):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_ReWind_Click
    '* Overview             : PlayControl Rewind
    '****************************************************************
    Private Sub b_ReWind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ReWind.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Rewind
            lCommand = 9
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Rewind):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_NextRec_Click
    '* Overview             : PlayControl Next Record
    '****************************************************************
    Private Sub b_NextRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_NextRec.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Next Record
            lCommand = 10
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Next Record):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_PrevRec_Click
    '* Overview             : PlayControl Previous Record
    '****************************************************************
    Private Sub b_PrevRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PrevRec.Click
        'Define variables
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
            'Previous Record
            lCommand = 11
            lSpeed = 1
            lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
            Logging("[Function] PlayControl(Previous Record):" & CStr(lRet))
        Else
	        Logging("[Message] No playback.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : CheckBox1_CheckedChanged          Added Ver5.0.1.0
    '* Overview             : Set FastPlayMode property
    '****************************************************************
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim Mode As Integer

        If CheckBox1.Checked Then
            Mode = 1       'High rate mode
            AxipropsapiCtrl1.FastPlayMode = Mode
            Logging("[Property] FastPlayMode = High rate mode")
        Else
            Mode = 0        'Normal mode
            AxipropsapiCtrl1.FastPlayMode = Mode
            Logging("[Property] FastPlayMode = Normal mode")
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

End Class
