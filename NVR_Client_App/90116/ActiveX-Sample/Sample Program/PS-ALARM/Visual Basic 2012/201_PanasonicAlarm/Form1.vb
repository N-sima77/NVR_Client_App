Public Class Form1

    '****************************************************************
    '* Function Name        : Load
    '* Overview             : Create log window
    '****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Form2
            .StartPosition = FormStartPosition.Manual
            .Left = 600
            .Top = 400
            .Show()
        End With

        With Me
            'Change visible property of control to FALSE
            .Axpsalarmrcvctrl1.Visible = False

            .Left = 50
            .Top = 50

            'Turn on OnError event receiving
            .Axpsalarmrcvctrl1.OnErrorEnable = 1

            'Set receiving port number
            .Axpsalarmrcvctrl1.AlarmRcvPort = 1818    'Editable value
            Logging("AlarmRcvPort : " & CStr(Me.Axpsalarmrcvctrl1.AlarmRcvPort))

            'Display port number
            .TextBox1.Text = .Axpsalarmrcvctrl1.AlarmRcvPort
        End With
    End Sub

    '****************************************************************
    '* Function Name        : Logging
    '* Overview             : Logging
    '****************************************************************
    Private Sub Logging(ByVal str As String)
        Form2.txt_Log.Text = str & vbCrLf & Form2.txt_Log.Text
    End Sub

    '****************************************************************
    '* Function Name        : Command1_Click
    '* Overview             : Start receiving Panasonic Alarm
    '****************************************************************
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Turn on OnAlarm event receiving
        Me.Axpsalarmrcvctrl1.OnAlarmRcvEnable = 1

        Logging("onAlarmRcvEnable : 1 (On)")
    End Sub

    '****************************************************************
    '* Function Name        : Command2_Click
    '* Overview             : Stop receiving Panasonic Alarm
    '****************************************************************
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Turn off OnAlarm event receiving
        Me.Axpsalarmrcvctrl1.OnAlarmRcvEnable = 0

        Logging("onAlarmRcvEnable : 0 (Off)")
    End Sub

    '****************************************************************
    '* Function Name        : OnError
    '* Overview             : OnError
    '****************************************************************
    Public Sub Axpsalarmrcvctrl1_OnError(ByVal sender As Object, ByVal e As AxPSALARMRCVLib._IpsalarmrcvctrlEvents_OnErrorEvent) Handles Axpsalarmrcvctrl1.OnError
        'Output Error log
        Logging("[OnError]  errorcode:" & CStr(e.errorCode) & "   errorMsg:" & e.description)
    End Sub

    '****************************************************************
    '* Function Name        : OnAlarmRcv
    '* Overview             : OnAlarmRcv
    '****************************************************************

    Public Sub Axpsalarmrcvctrl1_OnAlarmRcv_1(ByVal sender As System.Object, ByVal e As AxPSALARMRCVLib._IpsalarmrcvctrlEvents_OnAlarmRcvEvent) Handles Axpsalarmrcvctrl1.OnAlarmRcv
        Dim strLog As String
        strLog = "[OnAlarmRcv]timeDate : " & CStr(e.timeDate) & vbCrLf _
                    & "ipaddr : " & CStr(e.ipaddr) & vbCrLf _
                    & "channel : " & CStr(e.channel) & vbCrLf _
                    & "alarmType : " & CStr(e.alarmType) & vbCrLf _
                    & "messageID : " & CStr(e.messageID) & vbCrLf _
                    & "messageText : " & CStr(e.messageText) & vbCrLf


        Logging(strLog)

        Dim strAlarm As String
        strAlarm = "timeDate[" & CStr(e.timeDate) & "]  " & vbCrLf _
                    & "ipaddr[" & CStr(e.ipaddr) & "]  " & vbCrLf _
                    & "channel[" & CStr(e.channel) & "]  " & vbCrLf _
                    & "alarmType[" & CStr(e.alarmType) & "]  " & vbCrLf _
                    & "messageID[" & CStr(e.messageID) & "]  " & vbCrLf _
                    & "messageText[" & CStr(e.messageText) & "]  " & vbCrLf _
                    & "information" & vbCrLf _
                    & "----------------" & vbCrLf _
                    & CStr(e.information) & vbCrLf

        If Me.ListBox1.Items.Count >= 1000 Then
            Me.ListBox1.Items.RemoveAt(0)
        End If

        'Add received Panasonic Alarm to list
        Me.ListBox1.Items.Add(strAlarm)
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        MsgBox(Me.ListBox1.Items.Item(Me.ListBox1.SelectedIndex()))
    End Sub

End Class
