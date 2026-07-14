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
        Me.b_AlmOp = New System.Windows.Forms.Button
        Me.b_TriggerOn = New System.Windows.Forms.Button
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxipropsapiCtrl1
        '
        Me.AxipropsapiCtrl1.Enabled = True
        Me.AxipropsapiCtrl1.Location = New System.Drawing.Point(12, 48)
        Me.AxipropsapiCtrl1.Name = "AxipropsapiCtrl1"
        Me.AxipropsapiCtrl1.OcxState = CType(resources.GetObject("AxipropsapiCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxipropsapiCtrl1.Size = New System.Drawing.Size(227, 10)
        Me.AxipropsapiCtrl1.TabIndex = 0
        Me.AxipropsapiCtrl1.Visible = False
        '
        'b_AlmOp
        '
        Me.b_AlmOp.Location = New System.Drawing.Point(12, 12)
        Me.b_AlmOp.Name = "b_AlmOp"
        Me.b_AlmOp.Size = New System.Drawing.Size(100, 30)
        Me.b_AlmOp.TabIndex = 2
        Me.b_AlmOp.Text = "Alarm Reset"
        Me.b_AlmOp.UseVisualStyleBackColor = True
        '
        'b_TriggerOn
        '
        Me.b_TriggerOn.Location = New System.Drawing.Point(139, 12)
        Me.b_TriggerOn.Name = "b_TriggerOn"
        Me.b_TriggerOn.Size = New System.Drawing.Size(100, 30)
        Me.b_TriggerOn.TabIndex = 3
        Me.b_TriggerOn.Text = "Alarm On"
        Me.b_TriggerOn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 66)
        Me.Controls.Add(Me.b_TriggerOn)
        Me.Controls.Add(Me.b_AlmOp)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_Alarm"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_AlmOp As System.Windows.Forms.Button
    Friend WithEvents b_TriggerOn As System.Windows.Forms.Button

End Class
