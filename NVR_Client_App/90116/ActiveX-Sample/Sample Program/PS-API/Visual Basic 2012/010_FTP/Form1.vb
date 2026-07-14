Public Class Form1
    '****************************************************************
    '* Define
    '****************************************************************


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
            .Password = "admin123"

            'Set properties for event
            .OnErrorEnable = 1
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

        '----------------------------------------
        'Connect to the device
        '----------------------------------------
        Dim lRet As Long

        lRet = AxipropsapiCtrl1.Open()
        Logging("[Function] Open:" & CStr(lRet))
    End Sub


    '****************************************************************
    '* Function Name        : FormClosed
    '* Overview             : Destroy log window
    '****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        With AxipropsapiCtrl1
            .Close()
        End With

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
            .OnFtpStatusCBEnable = 1
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
    '* Function Name        : Button1_Click
    '* Overview             : Start FtpGet of blocking mode
    '****************************************************************
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Define variables
        Dim lRet As Long
        Dim lchannel As Long
        Dim csStartTD As String
        Dim csEndTD As String
        Dim lData As Long
        Dim lType As Long
        Dim strFile As String
        Dim lBlockmode As Long

        If (AxipropsapiCtrl1.UID > 0) Then
            lchannel = 1

            csStartTD = TextBox1.Text & "/" & TextBox2.Text & "/" & TextBox3.Text & " " & _
                        TextBox4.Text & ":" & TextBox5.Text & ":" & TextBox6.Text

            csEndTD = TextBox7.Text & "/" & TextBox8.Text & "/" & TextBox9.Text & " " & _
                      TextBox10.Text & ":" & TextBox11.Text & ":" & TextBox12.Text

            lData = Me.TextBox13.Text

            lType = 0
            If CheckBox1.Checked = True Then
                lType = lType Or &H1
            End If
            If CheckBox2.Checked = True Then
                lType = lType Or &H2
            End If
            If CheckBox3.Checked = True Then
                lType = lType Or &H4
            End If
            If CheckBox4.Checked = True Then
                lType = lType Or &H8
            End If
            If CheckBox5.Checked = True Then
                lType = lType Or &H10
            End If
            If CheckBox6.Checked = True Then
                lType = lType Or &H20
            End If
            If CheckBox7.Checked = True Then
                lType = lType Or &H40
            End If
            If CheckBox8.Checked = True Then
                lType = lType Or &H80
            End If
            If CheckBox9.Checked = True Then
                lType = lType Or &H100
            End If
            If CheckBox10.Checked = True Then
                lType = lType Or &H200
            End If
            If CheckBox11.Checked = True Then
                lType = lType Or &H400
            End If
            If CheckBox12.Checked = True Then
                lType = lType Or &H800
            End If
            If CheckBox13.Checked = True Then
                lType = lType Or &H1000
            End If
            If CheckBox14.Checked = True Then
                lType = lType Or &H2000
            End If
            If CheckBox15.Checked = True Then
                lType = lType Or &H4000
            End If

            strFile = Me.TextBox14.Text

            lBlockmode = 1
            lRet = AxipropsapiCtrl1.FtpGet(lchannel, csStartTD, csEndTD, lData, lType, strFile, lBlockmode)
            Logging("[Function] FtpGet:" & CStr(lRet) & "(Channel[" & CStr(lchannel) & _
                                                       "] Start[" & csStartTD & _
                                                       "] End[" & csEndTD & _
                                                       "] DataType[ " & CStr(lData) & _
                                                       "] EventType[" & CStr(lType) & _
                                                       "] FileName[" & strFile & _
                                                       "] Mode[" & CStr(lBlockmode) & "])")
        Else
            Logging("[Message] No login.")
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
