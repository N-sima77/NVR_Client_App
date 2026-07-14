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
        Me.b_gCamPos = New System.Windows.Forms.Button
        Me.b_sCamPos = New System.Windows.Forms.Button
        Me.b_sCamPos2 = New System.Windows.Forms.Button
        Me.b_COP_NOP = New System.Windows.Forms.Button
        Me.b_COP_AT = New System.Windows.Forms.Button
        Me.b_COP_AP = New System.Windows.Forms.Button
        Me.b_COP_AF = New System.Windows.Forms.Button
        Me.b_COP_SP = New System.Windows.Forms.Button
        Me.b_COP_CP = New System.Windows.Forms.Button
        Me.b_COP_DP = New System.Windows.Forms.Button
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
        'b_gCamPos
        '
        Me.b_gCamPos.Location = New System.Drawing.Point(12, 516)
        Me.b_gCamPos.Name = "b_gCamPos"
        Me.b_gCamPos.Size = New System.Drawing.Size(120, 30)
        Me.b_gCamPos.TabIndex = 1
        Me.b_gCamPos.Text = "GetCamPosition"
        Me.b_gCamPos.UseVisualStyleBackColor = True
        '
        'b_sCamPos
        '
        Me.b_sCamPos.Location = New System.Drawing.Point(175, 516)
        Me.b_sCamPos.Name = "b_sCamPos"
        Me.b_sCamPos.Size = New System.Drawing.Size(120, 30)
        Me.b_sCamPos.TabIndex = 2
        Me.b_sCamPos.Text = "SetCamPosition 1"
        Me.b_sCamPos.UseVisualStyleBackColor = True
        '
        'b_sCamPos2
        '
        Me.b_sCamPos2.Location = New System.Drawing.Point(301, 516)
        Me.b_sCamPos2.Name = "b_sCamPos2"
        Me.b_sCamPos2.Size = New System.Drawing.Size(120, 30)
        Me.b_sCamPos2.TabIndex = 3
        Me.b_sCamPos2.Text = "SetCamPosition 2"
        Me.b_sCamPos2.UseVisualStyleBackColor = True
        '
        'b_COP_NOP
        '
        Me.b_COP_NOP.Location = New System.Drawing.Point(12, 562)
        Me.b_COP_NOP.Name = "b_COP_NOP"
        Me.b_COP_NOP.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_NOP.TabIndex = 4
        Me.b_COP_NOP.Text = "NonOperation"
        Me.b_COP_NOP.UseVisualStyleBackColor = True
        '
        'b_COP_AT
        '
        Me.b_COP_AT.Location = New System.Drawing.Point(175, 562)
        Me.b_COP_AT.Name = "b_COP_AT"
        Me.b_COP_AT.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_AT.TabIndex = 5
        Me.b_COP_AT.Text = "AutoTrack"
        Me.b_COP_AT.UseVisualStyleBackColor = True
        '
        'b_COP_AP
        '
        Me.b_COP_AP.Location = New System.Drawing.Point(301, 562)
        Me.b_COP_AP.Name = "b_COP_AP"
        Me.b_COP_AP.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_AP.TabIndex = 6
        Me.b_COP_AP.Text = "AutoPan"
        Me.b_COP_AP.UseVisualStyleBackColor = True
        '
        'b_COP_AF
        '
        Me.b_COP_AF.Location = New System.Drawing.Point(427, 562)
        Me.b_COP_AF.Name = "b_COP_AF"
        Me.b_COP_AF.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_AF.TabIndex = 7
        Me.b_COP_AF.Text = "AutoFocus"
        Me.b_COP_AF.UseVisualStyleBackColor = True
        '
        'b_COP_SP
        '
        Me.b_COP_SP.Location = New System.Drawing.Point(175, 598)
        Me.b_COP_SP.Name = "b_COP_SP"
        Me.b_COP_SP.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_SP.TabIndex = 8
        Me.b_COP_SP.Text = "Set Preset"
        Me.b_COP_SP.UseVisualStyleBackColor = True
        '
        'b_COP_CP
        '
        Me.b_COP_CP.Location = New System.Drawing.Point(301, 598)
        Me.b_COP_CP.Name = "b_COP_CP"
        Me.b_COP_CP.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_CP.TabIndex = 9
        Me.b_COP_CP.Text = "Call Preset"
        Me.b_COP_CP.UseVisualStyleBackColor = True
        '
        'b_COP_DP
        '
        Me.b_COP_DP.Location = New System.Drawing.Point(427, 598)
        Me.b_COP_DP.Name = "b_COP_DP"
        Me.b_COP_DP.Size = New System.Drawing.Size(120, 30)
        Me.b_COP_DP.TabIndex = 10
        Me.b_COP_DP.Text = "Delete Preset"
        Me.b_COP_DP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 646)
        Me.Controls.Add(Me.b_COP_DP)
        Me.Controls.Add(Me.b_COP_CP)
        Me.Controls.Add(Me.b_COP_SP)
        Me.Controls.Add(Me.b_COP_AF)
        Me.Controls.Add(Me.b_COP_AP)
        Me.Controls.Add(Me.b_COP_AT)
        Me.Controls.Add(Me.b_COP_NOP)
        Me.Controls.Add(Me.b_sCamPos2)
        Me.Controls.Add(Me.b_sCamPos)
        Me.Controls.Add(Me.b_gCamPos)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_CamOp"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_gCamPos As System.Windows.Forms.Button
    Friend WithEvents b_sCamPos As System.Windows.Forms.Button
    Friend WithEvents b_sCamPos2 As System.Windows.Forms.Button
    Friend WithEvents b_COP_NOP As System.Windows.Forms.Button
    Friend WithEvents b_COP_AT As System.Windows.Forms.Button
    Friend WithEvents b_COP_AP As System.Windows.Forms.Button
    Friend WithEvents b_COP_AF As System.Windows.Forms.Button
    Friend WithEvents b_COP_SP As System.Windows.Forms.Button
    Friend WithEvents b_COP_CP As System.Windows.Forms.Button
    Friend WithEvents b_COP_DP As System.Windows.Forms.Button

End Class
