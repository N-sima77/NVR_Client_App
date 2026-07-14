<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    
    Private components As System.ComponentModel.IContainer


<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.b_Stop = New System.Windows.Forms.Button
        Me.b_nFrame = New System.Windows.Forms.Button
        Me.b_FF = New System.Windows.Forms.Button
        Me.b_PlayBack = New System.Windows.Forms.Button
        Me.b_Pause = New System.Windows.Forms.Button
        Me.b_Reverse = New System.Windows.Forms.Button
        Me.b_ReWind = New System.Windows.Forms.Button
        Me.b_pFrame = New System.Windows.Forms.Button
        Me.AxipropsapiCtrl1 = New AxIPROPSAPILib.AxipropsapiCtrl
        Me.Label1 = New System.Windows.Forms.Label
        Me.m_eFileName = New System.Windows.Forms.TextBox
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_Stop
        '
        Me.b_Stop.Location = New System.Drawing.Point(226, 534)
        Me.b_Stop.Name = "b_Stop"
        Me.b_Stop.Size = New System.Drawing.Size(100, 30)
        Me.b_Stop.TabIndex = 3
        Me.b_Stop.Text = "[] Stop"
        Me.b_Stop.UseVisualStyleBackColor = True
        '
        'b_nFrame
        '
        Me.b_nFrame.Location = New System.Drawing.Point(438, 570)
        Me.b_nFrame.Name = "b_nFrame"
        Me.b_nFrame.Size = New System.Drawing.Size(100, 30)
        Me.b_nFrame.TabIndex = 2
        Me.b_nFrame.Text = "||> NextFrame"
        Me.b_nFrame.UseVisualStyleBackColor = True
        '
        'b_FF
        '
        Me.b_FF.Location = New System.Drawing.Point(544, 534)
        Me.b_FF.Name = "b_FF"
        Me.b_FF.Size = New System.Drawing.Size(100, 30)
        Me.b_FF.TabIndex = 1
        Me.b_FF.Text = ">> Fast Fwd"
        Me.b_FF.UseVisualStyleBackColor = True
        '
        'b_PlayBack
        '
        Me.b_PlayBack.Location = New System.Drawing.Point(438, 534)
        Me.b_PlayBack.Name = "b_PlayBack"
        Me.b_PlayBack.Size = New System.Drawing.Size(100, 30)
        Me.b_PlayBack.TabIndex = 0
        Me.b_PlayBack.Text = "> Playback"
        Me.b_PlayBack.UseVisualStyleBackColor = True
        '
        'b_Pause
        '
        Me.b_Pause.Location = New System.Drawing.Point(332, 534)
        Me.b_Pause.Name = "b_Pause"
        Me.b_Pause.Size = New System.Drawing.Size(100, 30)
        Me.b_Pause.TabIndex = 20
        Me.b_Pause.Text = "|| Pause"
        Me.b_Pause.UseVisualStyleBackColor = True
        '
        'b_Reverse
        '
        Me.b_Reverse.Location = New System.Drawing.Point(120, 534)
        Me.b_Reverse.Name = "b_Reverse"
        Me.b_Reverse.Size = New System.Drawing.Size(100, 30)
        Me.b_Reverse.TabIndex = 19
        Me.b_Reverse.Text = "< Backward"
        Me.b_Reverse.UseVisualStyleBackColor = True
        '
        'b_ReWind
        '
        Me.b_ReWind.Location = New System.Drawing.Point(14, 534)
        Me.b_ReWind.Name = "b_ReWind"
        Me.b_ReWind.Size = New System.Drawing.Size(100, 30)
        Me.b_ReWind.TabIndex = 18
        Me.b_ReWind.Text = "<< Rewind"
        Me.b_ReWind.UseVisualStyleBackColor = True
        '
        'b_pFrame
        '
        Me.b_pFrame.Location = New System.Drawing.Point(120, 570)
        Me.b_pFrame.Name = "b_pFrame"
        Me.b_pFrame.Size = New System.Drawing.Size(100, 30)
        Me.b_pFrame.TabIndex = 17
        Me.b_pFrame.Text = "<<| PrevFrame"
        Me.b_pFrame.UseVisualStyleBackColor = True
        '
        'AxipropsapiCtrl1
        '
        Me.AxipropsapiCtrl1.Enabled = True
        Me.AxipropsapiCtrl1.Location = New System.Drawing.Point(12, 12)
        Me.AxipropsapiCtrl1.Name = "AxipropsapiCtrl1"
        Me.AxipropsapiCtrl1.OcxState = CType(resources.GetObject("AxipropsapiCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxipropsapiCtrl1.Size = New System.Drawing.Size(640, 480)
        Me.AxipropsapiCtrl1.TabIndex = 25
        Me.AxipropsapiCtrl1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 507)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 12)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Local File Name"
        '
        'm_eFileName
        '
        Me.m_eFileName.Location = New System.Drawing.Point(106, 504)
        Me.m_eFileName.Name = "m_eFileName"
        Me.m_eFileName.Size = New System.Drawing.Size(400, 19)
        Me.m_eFileName.TabIndex = 27
        Me.m_eFileName.Text = "c:\JpegRecordingData.n3r"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 616)
        Me.Controls.Add(Me.m_eFileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Controls.Add(Me.b_Stop)
        Me.Controls.Add(Me.b_nFrame)
        Me.Controls.Add(Me.b_FF)
        Me.Controls.Add(Me.b_PlayBack)
        Me.Controls.Add(Me.b_Pause)
        Me.Controls.Add(Me.b_Reverse)
        Me.Controls.Add(Me.b_ReWind)
        Me.Controls.Add(Me.b_pFrame)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_LocalFilePlay"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_Stop As System.Windows.Forms.Button
    Friend WithEvents b_nFrame As System.Windows.Forms.Button
    Friend WithEvents b_FF As System.Windows.Forms.Button
    Friend WithEvents b_PlayBack As System.Windows.Forms.Button
    Friend WithEvents b_Pause As System.Windows.Forms.Button
    Friend WithEvents b_Reverse As System.Windows.Forms.Button
    Friend WithEvents b_ReWind As System.Windows.Forms.Button
    Friend WithEvents b_pFrame As System.Windows.Forms.Button
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents m_eFileName As System.Windows.Forms.TextBox

End Class
