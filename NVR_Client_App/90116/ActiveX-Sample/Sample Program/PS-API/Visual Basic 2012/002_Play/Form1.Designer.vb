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
        Me.AxipropsapiCtrl1 = New AxIPROPSAPILib.AxipropsapiCtrl
        Me.b_Stop = New System.Windows.Forms.Button
        Me.b_NexrFrame = New System.Windows.Forms.Button
        Me.b_FF = New System.Windows.Forms.Button
        Me.b_PlayBack = New System.Windows.Forms.Button
        Me.b_Pause = New System.Windows.Forms.Button
        Me.b_Reverse = New System.Windows.Forms.Button
        Me.b_ReWind = New System.Windows.Forms.Button
        Me.b_PrevFrame = New System.Windows.Forms.Button
        Me.b_NextRec = New System.Windows.Forms.Button
        Me.b_PrevRec = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxipropsapiCtrl1
        '
        Me.AxipropsapiCtrl1.Enabled = True
        Me.AxipropsapiCtrl1.Location = New System.Drawing.Point(12, 12)
        Me.AxipropsapiCtrl1.Name = "AxipropsapiCtrl1"
        Me.AxipropsapiCtrl1.OcxState = CType(resources.GetObject("AxipropsapiCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxipropsapiCtrl1.Size = New System.Drawing.Size(640, 480)
        Me.AxipropsapiCtrl1.TabIndex = 0
        Me.AxipropsapiCtrl1.TabStop = False
        '
        'b_Stop
        '
        Me.b_Stop.Location = New System.Drawing.Point(224, 513)
        Me.b_Stop.Name = "b_Stop"
        Me.b_Stop.Size = New System.Drawing.Size(100, 30)
        Me.b_Stop.TabIndex = 3
        Me.b_Stop.Text = "[] Stop"
        Me.b_Stop.UseVisualStyleBackColor = True
        '
        'b_NexrFrame
        '
        Me.b_NexrFrame.Location = New System.Drawing.Point(436, 549)
        Me.b_NexrFrame.Name = "b_NexrFrame"
        Me.b_NexrFrame.Size = New System.Drawing.Size(100, 30)
        Me.b_NexrFrame.TabIndex = 9
        Me.b_NexrFrame.Text = "||> NextFrame"
        Me.b_NexrFrame.UseVisualStyleBackColor = True
        '
        'b_FF
        '
        Me.b_FF.Location = New System.Drawing.Point(542, 513)
        Me.b_FF.Name = "b_FF"
        Me.b_FF.Size = New System.Drawing.Size(100, 30)
        Me.b_FF.TabIndex = 6
        Me.b_FF.Text = ">> Fast Fwd"
        Me.b_FF.UseVisualStyleBackColor = True
        '
        'b_PlayBack
        '
        Me.b_PlayBack.Location = New System.Drawing.Point(436, 513)
        Me.b_PlayBack.Name = "b_PlayBack"
        Me.b_PlayBack.Size = New System.Drawing.Size(100, 30)
        Me.b_PlayBack.TabIndex = 5
        Me.b_PlayBack.Text = "> Playback"
        Me.b_PlayBack.UseVisualStyleBackColor = True
        '
        'b_Pause
        '
        Me.b_Pause.Location = New System.Drawing.Point(330, 513)
        Me.b_Pause.Name = "b_Pause"
        Me.b_Pause.Size = New System.Drawing.Size(100, 30)
        Me.b_Pause.TabIndex = 4
        Me.b_Pause.Text = "|| Pause"
        Me.b_Pause.UseVisualStyleBackColor = True
        '
        'b_Reverse
        '
        Me.b_Reverse.Location = New System.Drawing.Point(118, 513)
        Me.b_Reverse.Name = "b_Reverse"
        Me.b_Reverse.Size = New System.Drawing.Size(100, 30)
        Me.b_Reverse.TabIndex = 2
        Me.b_Reverse.Text = "< Backward"
        Me.b_Reverse.UseVisualStyleBackColor = True
        '
        'b_ReWind
        '
        Me.b_ReWind.Location = New System.Drawing.Point(12, 513)
        Me.b_ReWind.Name = "b_ReWind"
        Me.b_ReWind.Size = New System.Drawing.Size(100, 30)
        Me.b_ReWind.TabIndex = 1
        Me.b_ReWind.Text = "<< Rewind"
        Me.b_ReWind.UseVisualStyleBackColor = True
        '
        'b_PrevFrame
        '
        Me.b_PrevFrame.Location = New System.Drawing.Point(118, 549)
        Me.b_PrevFrame.Name = "b_PrevFrame"
        Me.b_PrevFrame.Size = New System.Drawing.Size(100, 30)
        Me.b_PrevFrame.TabIndex = 8
        Me.b_PrevFrame.Text = "<|| PrevFrame"
        Me.b_PrevFrame.UseVisualStyleBackColor = True
        '
        'b_NextRec
        '
        Me.b_NextRec.Location = New System.Drawing.Point(542, 549)
        Me.b_NextRec.Name = "b_NextRec"
        Me.b_NextRec.Size = New System.Drawing.Size(100, 30)
        Me.b_NextRec.TabIndex = 10
        Me.b_NextRec.Text = ">>| NextRecord"
        Me.b_NextRec.UseVisualStyleBackColor = True
        '
        'b_PrevRec
        '
        Me.b_PrevRec.Location = New System.Drawing.Point(12, 549)
        Me.b_PrevRec.Name = "b_PrevRec"
        Me.b_PrevRec.Size = New System.Drawing.Size(100, 30)
        Me.b_PrevRec.TabIndex = 7
        Me.b_PrevRec.Text = "|<< PrevRecord"
        Me.b_PrevRec.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 588)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 16)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Fast and smooth playback"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 616)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.b_PrevRec)
        Me.Controls.Add(Me.b_NextRec)
        Me.Controls.Add(Me.b_Stop)
        Me.Controls.Add(Me.b_NexrFrame)
        Me.Controls.Add(Me.b_FF)
        Me.Controls.Add(Me.b_PlayBack)
        Me.Controls.Add(Me.b_Pause)
        Me.Controls.Add(Me.b_Reverse)
        Me.Controls.Add(Me.b_ReWind)
        Me.Controls.Add(Me.b_PrevFrame)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_Play"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_Stop As System.Windows.Forms.Button
    Friend WithEvents b_NexrFrame As System.Windows.Forms.Button
    Friend WithEvents b_FF As System.Windows.Forms.Button
    Friend WithEvents b_PlayBack As System.Windows.Forms.Button
    Friend WithEvents b_Pause As System.Windows.Forms.Button
    Friend WithEvents b_Reverse As System.Windows.Forms.Button
    Friend WithEvents b_ReWind As System.Windows.Forms.Button
    Friend WithEvents b_PrevFrame As System.Windows.Forms.Button
    Friend WithEvents b_NextRec As System.Windows.Forms.Button
    Friend WithEvents b_PrevRec As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
