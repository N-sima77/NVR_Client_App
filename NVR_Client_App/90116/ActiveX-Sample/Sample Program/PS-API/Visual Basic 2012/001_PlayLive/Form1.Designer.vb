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
        Me.b_LiveStart = New System.Windows.Forms.Button
        Me.b_liveStop = New System.Windows.Forms.Button
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
        'b_LiveStart
        '
        Me.b_LiveStart.Location = New System.Drawing.Point(12, 513)
        Me.b_LiveStart.Name = "b_LiveStart"
        Me.b_LiveStart.Size = New System.Drawing.Size(100, 30)
        Me.b_LiveStart.TabIndex = 0
        Me.b_LiveStart.Text = "LiveStart"
        Me.b_LiveStart.UseVisualStyleBackColor = True
        '
        'b_liveStop
        '
        Me.b_liveStop.Location = New System.Drawing.Point(132, 513)
        Me.b_liveStop.Name = "b_liveStop"
        Me.b_liveStop.Size = New System.Drawing.Size(100, 30)
        Me.b_liveStop.TabIndex = 1
        Me.b_liveStop.Text = "LiveStop"
        Me.b_liveStop.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(254, 521)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 16)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Fit mode ( [ ] Fixed,  [V] Fit )"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 566)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.b_liveStop)
        Me.Controls.Add(Me.b_LiveStart)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_Live"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_LiveStart As System.Windows.Forms.Button
    Friend WithEvents b_liveStop As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
