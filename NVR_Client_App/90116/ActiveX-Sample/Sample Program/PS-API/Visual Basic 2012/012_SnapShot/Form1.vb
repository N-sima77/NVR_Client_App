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
            .IPAddr = "192.168.0.10"
            .DeviceType = 2
            .HttpPort = 80
            .UserName = "admin"
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
            .OnOpStatusEnable = 1
            .OnAlmStatusEnable = 0

            .OnRecStatusCBEnable = 0
            .OnSearchCBEnable = 0
            .OnSearchExCBEnable = 0
            .OnPlayStatusCBEnable = 0
            .OnOpStatusCBEnable = 0
            .OnAlmStatusCBEnable = 0
            .OnFtpStatusCBEnable = 0
        End With

        '----------------------------------------
        'Connect to the device
        '----------------------------------------
        Dim lRet As Long
        Dim lBlockmode As Long
        Dim lChannel As Long

        lRet = AxipropsapiCtrl1.Open
        Logging("[Function] Open:" & CStr(lRet))

        If lRet > -1 Then
	        lChannel = 1
	        lBlockmode = 1
            lRet = AxipropsapiCtrl1.PlayLive(lChannel, lBlockmode)
            Logging("[Function] PlayLive(Start):" & CStr(lRet))

            If lRet = 0 Then
                   gPlayStatus = 1
            Else
            	AxipropsapiCtrl1.Close
            End If
        End If
    End Sub

    '****************************************************************
    '* Function Name        : FormClosed
    '* Overview             : Destroy log window
    '****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '----------------------------------------
        'Disconnect to the device
        '----------------------------------------
        Dim lRet As Long
        Dim lCommand As Long
        Dim lSpeed As Long
        Dim lBlockmode As Long

        'Check the play status
        If (gPlayStatus = 1) Then
	        lCommand = 1
	        lSpeed = 1
	        lBlockmode = 0
            lRet = AxipropsapiCtrl1.PlayControl(lCommand, lSpeed, lBlockmode)
	        Logging("[Function] PlayLive(Stop):" & CStr(lRet))

	        'Close connection to the device
            AxipropsapiCtrl1.Close()
	        Logging("[Function] Close")

	        'ClearImage
            AxipropsapiCtrl1.ClearImage()
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
    '* Function Name        : bSnapShot_Click
    '* Overview             : Save Jpeg image format file
    ' ****************************************************************
    Private Sub bSnapShot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSnapShot.Click
        'Define variables
        Dim lRet As Long
        Dim strFileName As String

        If (gPlayStatus = 1) Then
            strFileName = Me.TextBox1.Text
            lRet = AxipropsapiCtrl1.SaveJpegImage(strFileName)
            Logging("[Function] SaveJpegImage:" & CStr(lRet))
        Else
            Logging("[Message] No live.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_DZoom1_Click
    '* Overview             : Digital zoom (x1)
    ' ****************************************************************
    Private Sub b_DZoom1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DZoom1.Click
        If (gPlayStatus = 1) Then
            'Digital zoom (x1)
            AxipropsapiCtrl1.DigitalZoom = 10
            Logging("[Function] DigitalZoom (x1)")
        Else
            Logging("[Message] No live.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_DZoom4_Click
    '* Overview             : Digital zoom (x4)
    ' ****************************************************************
    Private Sub b_DZoom4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DZoom4.Click
        If (gPlayStatus = 1) Then
            'Digital zoom (x4)
            AxipropsapiCtrl1.DigitalZoom = 40
            Logging("[Function] DigitalZoom (x4)")
        Else
            Logging("[Message] No live.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_DZoomLeft_Click
    '* Overview             : Digital zoom move to left
    ' ****************************************************************
    Private Sub b_DZoomLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DZoomLeft.Click
        'Define variables
        Dim lRet As Long
        Dim lXposition As Long
        Dim lYposition As Long

        If (gPlayStatus = 1) Then
            'Digital zoom move to left
            lXposition = -320
            lYposition = 0
            lRet = AxipropsapiCtrl1.DigitalZoomMove(lXposition, lYposition)
            Logging("[Function] DigitalZoomMove(Left):" & CStr(lRet))
        Else
            Logging("[Message] No live.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : b_DZoomRight_Click
    '* Overview             : Digital zoom move to right
    ' ****************************************************************
    Private Sub b_DZoomRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DZoomRight.Click
        'Define variables
        Dim lRet As Long
        Dim lXposition As Long
        Dim lYposition As Long

        If (gPlayStatus = 1) Then
            'Digital zoom move to right
            lXposition = 320
            lYposition = 0
            lRet = AxipropsapiCtrl1.DigitalZoomMove(lXposition, lYposition)
            Logging("[Function] DigitalZoomMove(Right):" & CStr(lRet))
        Else
            Logging("[Message] No live.")
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
