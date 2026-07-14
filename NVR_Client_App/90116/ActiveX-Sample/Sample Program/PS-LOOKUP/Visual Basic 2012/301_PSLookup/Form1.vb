Public Class Form1
    '****************************************************************
    '* Define
    '****************************************************************
    'SearchStatus 0:Off 1:On
    Enum SearchStatus
        SearchOff = 0
        SearchOn = 1
    End Enum
    Public gStatus As SearchStatus

    '****************************************************************
    '* Function Name        : Load
    '* Overview             : Load PSAPI & Initialize
    '****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Show the log window
        Form2.Location = New Point(Me.Size.Width, 0)
        Form2.Show()

        'Set initial status
        gStatus = SearchStatus.SearchOff

        '----------------------------------------
        'Set properties (ActiveX)
        '----------------------------------------
        With AxpsLookupCtrl
            ' Set non visible
            .Visible = False
            .Height = 10
            .Width = 10

            'Set properties for event
            .OnDevLookupEnable = 0
            Logging("[Property] OnDevLookupEnable:=0")
            .OnErrorEnable = 1
        End With

        '----------------------------------------
        'Set parameters (Other controls)
        '----------------------------------------
        ListBox1.Items.Clear()
        ListBox1.HorizontalScrollbar = True


    End Sub

    '****************************************************************
    '* Function Name        : FormClosed
    '* Overview             : Destroy main window
    '****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        '----------------------------------------
        'Set properties (ActiveX)
        '----------------------------------------
        With AxpsLookupCtrl
            'Set properties for event
            .OnDevLookupEnable = 0
            .OnErrorEnable = 0
        End With
        Form2.Close()
    End Sub

    '****************************************************************
    '* Function Name        : Search_Click
    '* Overview             : Switching the camera searches
    '****************************************************************
    Private Sub b_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Search.Click
        If gStatus = SearchStatus.SearchOff Then
            AxpsLookupCtrl.OnDevLookupEnable = 1
            Logging("[Property] OnDevLookupEnable:=1")
            gStatus = SearchStatus.SearchOn
            b_Search.Text = "&End"
        Else
            AxpsLookupCtrl.OnDevLookupEnable = 0
            Logging("[Property] OnDevLookupEnable:=0")
            gStatus = SearchStatus.SearchOff
            b_Search.Text = "&Start"
        End If
    End Sub

    '****************************************************************
    '* Function Name        : OnDevLookup
    '* Overview             : OnDevLookup listener event
    '****************************************************************
    Private Sub AxpsLookupCtrl_OnDevLookup(ByVal sender As System.Object, ByVal e As AxpslookupLib._IpslookupctrlEvents_OnDevLookupEvent) Handles AxpsLookupCtrl.OnDevLookup
        Dim Logs As String
        'Output Logs
        Logs = "macAddr : " & e.macAddr & vbCrLf & _
                "ipAddr : " & e.ipAddr & vbCrLf & _
                "ipv6Addr : " & e.ipv6Addr & vbCrLf & _
                "portNo : " & e.portNo & vbCrLf & _
                "camName : " & e.camName & vbCrLf & _
                "modelName : " & e.modelName
        Logging("[OnDevLookup] " & Logs)
        Logs = Logs.Replace(vbCrLf, " ")
        ListBox1.Items.Add(Logs)
    End Sub

    '****************************************************************
    '* Function Name        : OnError
    '* Overview             : OnError listener event
    '****************************************************************
    Private Sub AxpsLookupCtrl_OnError(ByVal sender As System.Object, ByVal e As AxpslookupLib._IpslookupctrlEvents_OnErrorEvent) Handles AxpsLookupCtrl.OnError
        'Output Logs
        Logging("[OnError] errorCode[" & e.errorCode.ToString() & "] description[" & e.description & "]")
    End Sub

    '****************************************************************
    '* Function Name        : Logging
    '* Overview             : Output Logs
    '****************************************************************
    Private Sub Logging(ByVal str As String)
        If Form2.txt_Log.Text <> String.Empty Then
            Form2.txt_Log.Text = Form2.txt_Log.Text & vbCrLf
        End If
        Form2.txt_Log.Text = Form2.txt_Log.Text & str
    End Sub

End Class
