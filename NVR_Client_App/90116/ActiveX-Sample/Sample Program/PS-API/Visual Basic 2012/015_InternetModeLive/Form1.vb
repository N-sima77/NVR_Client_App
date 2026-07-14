Public Class Form1
    '****************************************************************
    '* Define
    '****************************************************************
    'ModeStatus 0:Off 1:On
    Enum LiveStatus
        Start = 0
        Live = 1
    End Enum
    Public gStatus As LiveStatus

    '****************************************************************
    '* Function Name        : Load
    '* Overview             : Load PSAPI & Initialize
    '****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Please confirm beforehand that the internet mode of a target device is turned ON.", MsgBoxStyle.Information)

        'Show the log window
        Form2.Location = New Point(Me.Size.Width, 0)
        Form2.Show()

        '----------------------------------------
        'Set properties (ActiveX)
        '----------------------------------------
        Dim Ret As Integer
        With AxiProCtrl
            ' Set visible(VGA)
            .Visible = True
            .Height = 480
            .Width = 640

            'Set properties to connect the device
            .IPAddr = "192.168.0.10"
            .DeviceType = 2
            .HttpPort = 80
            .UserName = "admin"
            .Password = "admin12345"

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

            'Set initial status
            .StreamFormat = 3       'H.264
            gStatus = LiveStatus.Start

            'Connect to device
            Ret = .Open()
            Logging("[Function] Open:" & Ret.ToString())
            If Ret < 0 Then
                'control is disabled.
                b_LiveStart.Enabled = False
                b_LiveEnd.Enabled = False
                b_SetInternetMode.Enabled = False
                TextBox1.Enabled = False
            End If
        End With

        '----------------------------------------
        'Set parameters (TextBox)
        '----------------------------------------
        TextBox1.Text = "1"
    End Sub

    '****************************************************************
    '* Function Name        : FormClosed
    '* Overview             : Destroy main window
    '****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        '----------------------------------------
        'Set properties
        '----------------------------------------
        With AxiProCtrl
            'Close connecntion to the device
            .Close()
            Logging("[Function] Close")

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
        Form2.Close()

    End Sub

    '****************************************************************
    '* Function Name        : SetInternetModeChange
    '* Overview             : InternetMode Change
    ' ****************************************************************
    Private Sub b_SetInternetMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SetInternetMode.Click
        Dim Ret As Integer
        Dim Channel As Integer
        Dim Command As Integer

        If gStatus = LiveStatus.Start Then
            Channel = 1         ' Network Camera
            If Not Integer.TryParse(TextBox1.Text, Command) Then Exit Sub
            If Command <> 0 AndAlso Command <> 1 Then Exit Sub
            Ret = AxiProCtrl.SetInternetModeCam(Channel, Command, AxiProCtrl.StreamFormat, AxiProCtrl.StreamNumber)
            Logging("[Function] SetInternetModeCam(SetMode=" & Command.ToString() & "):" & Ret.ToString())
            AxiProCtrl.InternetMode = Command
            Logging("[Property] InternetMode:" & AxiProCtrl.InternetMode.ToString())
        Else
            Logging("[Message] In the live.")
        End If
    End Sub

    '****************************************************************
    '* Function Name        : StartLive
    '* Overview             : Start live video play
    ' ****************************************************************
    Private Sub b_LiveStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_LiveStart.Click
        Dim Ret As Integer
        Dim Channel As Integer
        Dim Blockmode As Integer

        'Check the play status
        If gStatus = LiveStatus.Start Then
            'Start Live
            Channel = 1         'Network Camera
            Blockmode = 0       'Blocking
            Ret = AxiProCtrl.PlayLive(Channel, Blockmode)
            Logging("[Function] PlayLive(Start):" & Ret.ToString())
            If Ret = 0 Then
                gStatus = LiveStatus.Live
            Else
                AxiProCtrl.Close()
            End If
        Else
            Logging("[Message] In the live.")
        End If

    End Sub

    '****************************************************************
    '* Function Name        : StopLive
    '* Overview             : Stop live video play
    '****************************************************************
    Private Sub b_LiveEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_LiveEnd.Click
        Dim Ret As Integer
        Dim Command As Integer
        Dim Speed As Integer
        Dim Blockmode As Integer

        'Check the play status
        If gStatus = LiveStatus.Live Then
            'Stop Live
            Command = 1         'stop live
            Speed = 1           'step 1
            Blockmode = 0       'blocking
            Ret = AxiProCtrl.PlayControl(Command, Speed, Blockmode)
            Logging("[Function] PlayLive(Stop):" & Ret.ToString())
            'Clear Image
            AxiProCtrl.ClearImage()

            gStatus = LiveStatus.Start
        Else
            Logging("[Message] No live.")
        End If

    End Sub

    '****************************************************************
    '* Function Name        : OnError
    '* Overview             : OnError listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnError(ByVal sender As System.Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnErrorEvent) Handles AxiProCtrl.OnError
        'Output Logs
        Logging("[OnError] errorCode[" & e.errorCode.ToString() & "] description[" & e.description & "]")
    End Sub

    '****************************************************************
    '* Function Name        : OnPlayStatus
    '* Overview             : OnPlayStatus listener event
    '****************************************************************
    Private Sub AxipropsapiCtrl1_OnPlayStatus(ByVal sender As Object, ByVal e As AxIPROPSAPILib._IipropsapiCtrlEvents_OnPlayStatusEvent) Handles AxiProCtrl.OnPlayStatus
        'Output Logs
        Logging("[OnPlayStatus] channel[" & e.channel.ToString() & "] status[" & e.status.ToString() & "]")
    End Sub

    '****************************************************************
    '* Function Name        : Logging
    '* Overview             : Output Logs
    '****************************************************************
    Private Sub Logging(ByVal str As String)
        If Form2.txt_Log.Text <> "" Then
            Form2.txt_Log.Text = Form2.txt_Log.Text & vbCrLf
        End If
        Form2.txt_Log.Text = Form2.txt_Log.Text & str
    End Sub
End Class
