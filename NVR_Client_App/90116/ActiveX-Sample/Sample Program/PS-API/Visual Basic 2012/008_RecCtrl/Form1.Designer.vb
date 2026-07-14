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
        Me.b_rStart = New System.Windows.Forms.Button
        Me.b_rStop = New System.Windows.Forms.Button
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxipropsapiCtrl1
        '
        Me.AxipropsapiCtrl1.Enabled = True
        Me.AxipropsapiCtrl1.Location = New System.Drawing.Point(12, 48)
        Me.AxipropsapiCtrl1.Name = "AxipropsapiCtrl1"
        Me.AxipropsapiCtrl1.OcxState = CType(resources.GetObject("AxipropsapiCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxipropsapiCtrl1.Size = New System.Drawing.Size(228, 10)
        Me.AxipropsapiCtrl1.TabIndex = 0
        Me.AxipropsapiCtrl1.Visible = False
        '
        'b_rStart
        '
        Me.b_rStart.Location = New System.Drawing.Point(12, 12)
        Me.b_rStart.Name = "b_rStart"
        Me.b_rStart.Size = New System.Drawing.Size(100, 30)
        Me.b_rStart.TabIndex = 1
        Me.b_rStart.Text = "Rec Start"
        Me.b_rStart.UseVisualStyleBackColor = True
        '
        'b_rStop
        '
        Me.b_rStop.Location = New System.Drawing.Point(140, 12)
        Me.b_rStop.Name = "b_rStop"
        Me.b_rStop.Size = New System.Drawing.Size(100, 30)
        Me.b_rStop.TabIndex = 2
        Me.b_rStop.Text = "Rec Stop"
        Me.b_rStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 66)
        Me.Controls.Add(Me.b_rStop)
        Me.Controls.Add(Me.b_rStart)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_Rec"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_rStart As System.Windows.Forms.Button
    Friend WithEvents b_rStop As System.Windows.Forms.Button

End Class
