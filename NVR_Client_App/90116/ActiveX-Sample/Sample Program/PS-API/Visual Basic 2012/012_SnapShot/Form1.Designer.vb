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
        Me.b_DZoom1 = New System.Windows.Forms.Button
        Me.AxipropsapiCtrl1 = New AxIPROPSAPILib.AxipropsapiCtrl
        Me.b_DZoom4 = New System.Windows.Forms.Button
        Me.b_DZoomLeft = New System.Windows.Forms.Button
        Me.b_DZoomRight = New System.Windows.Forms.Button
        Me.bSnapShot = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_DZoom1
        '
        Me.b_DZoom1.Location = New System.Drawing.Point(18, 549)
        Me.b_DZoom1.Name = "b_DZoom1"
        Me.b_DZoom1.Size = New System.Drawing.Size(120, 30)
        Me.b_DZoom1.TabIndex = 2
        Me.b_DZoom1.Text = "Digital Zoom (x1)"
        Me.b_DZoom1.UseVisualStyleBackColor = True
        '
        'AxipropsapiCtrl1
        '
        Me.AxipropsapiCtrl1.Enabled = True
        Me.AxipropsapiCtrl1.Location = New System.Drawing.Point(12, 12)
        Me.AxipropsapiCtrl1.Name = "AxipropsapiCtrl1"
        Me.AxipropsapiCtrl1.OcxState = CType(resources.GetObject("AxipropsapiCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxipropsapiCtrl1.Size = New System.Drawing.Size(640, 480)
        Me.AxipropsapiCtrl1.TabIndex = 13
        '
        'b_DZoom4
        '
        Me.b_DZoom4.Location = New System.Drawing.Point(144, 549)
        Me.b_DZoom4.Name = "b_DZoom4"
        Me.b_DZoom4.Size = New System.Drawing.Size(120, 30)
        Me.b_DZoom4.TabIndex = 15
        Me.b_DZoom4.Text = "Digital Zoom (x4)"
        Me.b_DZoom4.UseVisualStyleBackColor = True
        '
        'b_DZoomLeft
        '
        Me.b_DZoomLeft.Location = New System.Drawing.Point(297, 549)
        Me.b_DZoomLeft.Name = "b_DZoomLeft"
        Me.b_DZoomLeft.Size = New System.Drawing.Size(120, 30)
        Me.b_DZoomLeft.TabIndex = 16
        Me.b_DZoomLeft.Text = "Move to Left"
        Me.b_DZoomLeft.UseVisualStyleBackColor = True
        '
        'b_DZoomRight
        '
        Me.b_DZoomRight.Location = New System.Drawing.Point(423, 549)
        Me.b_DZoomRight.Name = "b_DZoomRight"
        Me.b_DZoomRight.Size = New System.Drawing.Size(120, 30)
        Me.b_DZoomRight.TabIndex = 17
        Me.b_DZoomRight.Text = "Move to Right"
        Me.b_DZoomRight.UseVisualStyleBackColor = True
        '
        'bSnapShot
        '
        Me.bSnapShot.Location = New System.Drawing.Point(423, 504)
        Me.bSnapShot.Name = "bSnapShot"
        Me.bSnapShot.Size = New System.Drawing.Size(120, 30)
        Me.bSnapShot.TabIndex = 18
        Me.bSnapShot.Text = "Jpeg Snap Shot"
        Me.bSnapShot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "fileName"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 510)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 19)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "C:\JpegSnapShot.jpg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 596)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSnapShot)
        Me.Controls.Add(Me.b_DZoomRight)
        Me.Controls.Add(Me.b_DZoomLeft)
        Me.Controls.Add(Me.b_DZoom4)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Controls.Add(Me.b_DZoom1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_SnapShot"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_DZoom1 As System.Windows.Forms.Button
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_DZoom4 As System.Windows.Forms.Button
    Friend WithEvents b_DZoomLeft As System.Windows.Forms.Button
    Friend WithEvents b_DZoomRight As System.Windows.Forms.Button
    Friend WithEvents bSnapShot As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
