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
                AxipropsapiCtrl1.Close()
            End If
        End If

        ' Added Ver5.0.1.0
        TextBox1.Text = "C:\temp\test.bmp"
        TextBox1.AllowDrop = True

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
        If gPlayStatus = 1 Then
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
    '* Function Name        : chk_drawTitle_CheckedChanged      Modefied Ver5.0.1.0
    '* Overview             : Draw Title
    '****************************************************************
    Private Sub chk_drawTitle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_drawTitle.CheckedChanged
        'Define variables
        Dim lRet As Long
        Dim lId As Long
        Dim lCommand As Long
        Dim strText As String
        Dim lxPosition As Long
        Dim lyPosition As Long
        Dim lAlign As Long
        Dim strFont As String
        Dim lFontSize As Long
        Dim lForeColor As Long
        Dim lBorderColor As Long
        Dim lStyle As Long
        Dim Transmittance As Integer

        strText = "PS-API ActiveX"
        lxPosition = 100
        lyPosition = 100
        lAlign = 0
        strFont = "MS UI Gothic"
        lFontSize = 24
        lForeColor = 0
        lBorderColor = 16777215
        lStyle = 2
        Transmittance = &H7F

        If (chk_drawTitle.Checked = True) Then
            'Display Title
            lId = 1
            lCommand = 1
            'Change method(TitleOperation->TitleOperationEx)
            lRet = AxipropsapiCtrl1.TitleOperationEx(lId, lCommand, strText, lxPosition, lyPosition, lAlign, strFont, lFontSize, lForeColor, lBorderColor, lStyle, Transmittance)
            Logging("[Function] TitleOperationEx (ON):" & CStr(lRet))
        Else
            'Not display Title
            lId = 1
            lCommand = 0
            'Change method(TitleOperation->TitleOperationEx)
            lRet = AxipropsapiCtrl1.TitleOperationEx(lId, lCommand, strText, lxPosition, lyPosition, lAlign, strFont, lFontSize, lForeColor, lBorderColor, lStyle, Transmittance)
            Logging("[Function] TitleOperationEx (OFF):" & CStr(lRet))
        End If
    End Sub

    '****************************************************************
    '* Function Name        : chk_drawBox_CheckedChanged        Modefied Ver5.0.1.0
    '* Overview             : Draw Box
    '****************************************************************
    Private Sub chk_drawBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_drawBox.CheckedChanged
        'Define variables
        Dim lRet As Long
        Dim lId As Long
        Dim lCommand As Long
        Dim lColor As Long
        Dim lSize As Long
        Dim lxTopLeft As Long
        Dim lyTopLeft As Long
        Dim lxBottomRight As Long
        Dim lyBottomRight As Long
        Dim Transmittance As Integer

        lColor = 255
        lSize = 3
        lxTopLeft = 200
        lyTopLeft = 200
        lxBottomRight = 300
        lyBottomRight = 300
        Transmittance = &H7F

        If (chk_drawBox.Checked = True) Then
            'Display Box
            lId = 1
            lCommand = 2
            'Change method(BoxOperation->BoxOperationEx)
            lRet = AxipropsapiCtrl1.BoxOperationEx(lId, lCommand, lColor, lSize, lxTopLeft, lyTopLeft, lxBottomRight, lyBottomRight, Transmittance)
            Logging("[Function] BoxOperationEx (ON):" & CStr(lRet))
        Else
            'Not display Box
            lId = 1
            lCommand = 0
            'Change method(BoxOperation->BoxOperationEx)
            lRet = AxipropsapiCtrl1.BoxOperationEx(lId, lCommand, lColor, lSize, lxTopLeft, lyTopLeft, lxBottomRight, lyBottomRight, Transmittance)
            Logging("[Function] BoxOperationEx (OFF):" & CStr(lRet))
        End If
    End Sub

    '****************************************************************
    '* Function Name        : chk_BMPDraw_CheckedChanged        Added Ver5.0.1.0
    '* Overview             : Transparent bitmap image processing
    '****************************************************************
    Private Sub chk_BMPDraw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_BMPDraw.CheckedChanged
        Dim Ret As Integer
        Dim Id As Integer
        Dim Command As Integer
        Dim FileName As String
        Dim XPos As Integer
        Dim YPos As Integer
        Dim MaskColor As Integer
        Dim Transmittance As Integer

        Id = 1                  'ID for management
        XPos = 320              'X position of displayed transparent
        YPos = 240              'Y position of displayed transparent
        If chk_BMPDraw.Checked Then
            'Transparent bitmap
            FileName = TextBox1.Text
            Command = 1             'Bitmap display
            MaskColor = &HFF00FF    'Bitmap's masked color
            Transmittance = &H7F    'Transmittance
            Ret = AxipropsapiCtrl1.BitmapOperationEx(Id, Command, FileName, XPos, YPos, MaskColor, Transmittance)
            Logging("[Function] BitmapOperationEx (ON," & FileName & "):" & Ret.ToString())
        Else
            'Not transparent bitmap
            Command = 0             'Bitmap non display
            MaskColor = &H0         'Bitmap's masked color
            Transmittance = &H7F    'Transmittance
            Ret = AxipropsapiCtrl1.BitmapOperationEx(Id, Command, String.Empty, 0, 0, MaskColor, Transmittance)
            Logging("[Function] BitmapOperationEx (OFF):" & Ret.ToString())
        End If
    End Sub

    '****************************************************************
    '* Function Name        : DragEnter                         Added Ver5.0.1.0
    '* Overview             : Drag the files and only valid
    '****************************************************************
    Private Sub TextBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    '****************************************************************
    '* Function Name        : DragDrop                          Added Ver5.0.1.0
    '* Overview             : Drop a single file to view
    '****************************************************************
    Private Sub TextBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        TextBox1.Text = e.Data.GetData(DataFormats.FileDrop)(0)
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
