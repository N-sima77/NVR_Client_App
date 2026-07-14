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
        Me.b_Up = New System.Windows.Forms.Button
        Me.b_Left = New System.Windows.Forms.Button
        Me.b_Right = New System.Windows.Forms.Button
        Me.b_Down = New System.Windows.Forms.Button
        Me.l_PanTilt = New System.Windows.Forms.Label
        Me.l_Zoom = New System.Windows.Forms.Label
        Me.l_Iris = New System.Windows.Forms.Label
        Me.b_Tele = New System.Windows.Forms.Button
        Me.b_Wide = New System.Windows.Forms.Button
        Me.b_Open = New System.Windows.Forms.Button
        Me.b_Close = New System.Windows.Forms.Button
        Me.b_Stop = New System.Windows.Forms.Button
        Me.AxipropsapiCtrl1 = New AxIPROPSAPILib.AxipropsapiCtrl
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_Up
        '
        Me.b_Up.Location = New System.Drawing.Point(90, 538)
        Me.b_Up.Name = "b_Up"
        Me.b_Up.Size = New System.Drawing.Size(80, 40)
        Me.b_Up.TabIndex = 1
        Me.b_Up.Text = "Up"
        Me.b_Up.UseVisualStyleBackColor = True
        '
        'b_Left
        '
        Me.b_Left.Location = New System.Drawing.Point(12, 578)
        Me.b_Left.Name = "b_Left"
        Me.b_Left.Size = New System.Drawing.Size(80, 40)
        Me.b_Left.TabIndex = 2
        Me.b_Left.Text = "Left"
        Me.b_Left.UseVisualStyleBackColor = True
        '
        'b_Right
        '
        Me.b_Right.Location = New System.Drawing.Point(170, 578)
        Me.b_Right.Name = "b_Right"
        Me.b_Right.Size = New System.Drawing.Size(80, 40)
        Me.b_Right.TabIndex = 3
        Me.b_Right.Text = "Right"
        Me.b_Right.UseVisualStyleBackColor = True
        '
        'b_Down
        '
        Me.b_Down.Location = New System.Drawing.Point(90, 618)
        Me.b_Down.Name = "b_Down"
        Me.b_Down.Size = New System.Drawing.Size(80, 40)
        Me.b_Down.TabIndex = 4
        Me.b_Down.Text = "Down"
        Me.b_Down.UseVisualStyleBackColor = True
        '
        'l_PanTilt
        '
        Me.l_PanTilt.AutoSize = True
        Me.l_PanTilt.Location = New System.Drawing.Point(109, 592)
        Me.l_PanTilt.Name = "l_PanTilt"
        Me.l_PanTilt.Size = New System.Drawing.Size(47, 12)
        Me.l_PanTilt.TabIndex = 5
        Me.l_PanTilt.Text = "Pan/Tilt"
        '
        'l_Zoom
        '
        Me.l_Zoom.AutoSize = True
        Me.l_Zoom.Location = New System.Drawing.Point(524, 552)
        Me.l_Zoom.Name = "l_Zoom"
        Me.l_Zoom.Size = New System.Drawing.Size(33, 12)
        Me.l_Zoom.TabIndex = 6
        Me.l_Zoom.Text = "Zoom"
        '
        'l_Iris
        '
        Me.l_Iris.AutoSize = True
        Me.l_Iris.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.l_Iris.Location = New System.Drawing.Point(528, 627)
        Me.l_Iris.Name = "l_Iris"
        Me.l_Iris.Size = New System.Drawing.Size(24, 13)
        Me.l_Iris.TabIndex = 7
        Me.l_Iris.Text = "Iris"
        '
        'b_Tele
        '
        Me.b_Tele.Location = New System.Drawing.Point(438, 538)
        Me.b_Tele.Name = "b_Tele"
        Me.b_Tele.Size = New System.Drawing.Size(80, 40)
        Me.b_Tele.TabIndex = 8
        Me.b_Tele.Text = "Tele"
        Me.b_Tele.UseVisualStyleBackColor = True
        '
        'b_Wide
        '
        Me.b_Wide.Location = New System.Drawing.Point(563, 538)
        Me.b_Wide.Name = "b_Wide"
        Me.b_Wide.Size = New System.Drawing.Size(80, 40)
        Me.b_Wide.TabIndex = 9
        Me.b_Wide.Text = "Wide"
        Me.b_Wide.UseVisualStyleBackColor = True
        '
        'b_Open
        '
        Me.b_Open.Location = New System.Drawing.Point(438, 614)
        Me.b_Open.Name = "b_Open"
        Me.b_Open.Size = New System.Drawing.Size(80, 40)
        Me.b_Open.TabIndex = 10
        Me.b_Open.Text = "Open"
        Me.b_Open.UseVisualStyleBackColor = True
        '
        'b_Close
        '
        Me.b_Close.Location = New System.Drawing.Point(563, 614)
        Me.b_Close.Name = "b_Close"
        Me.b_Close.Size = New System.Drawing.Size(80, 40)
        Me.b_Close.TabIndex = 11
        Me.b_Close.Text = "Close"
        Me.b_Close.UseVisualStyleBackColor = True
        '
        'b_Stop
        '
        Me.b_Stop.Location = New System.Drawing.Point(305, 578)
        Me.b_Stop.Name = "b_Stop"
        Me.b_Stop.Size = New System.Drawing.Size(80, 40)
        Me.b_Stop.TabIndex = 12
        Me.b_Stop.Text = "Stop"
        Me.b_Stop.UseVisualStyleBackColor = True
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(18, 503)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 16)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Click Centering Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 666)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Controls.Add(Me.b_Stop)
        Me.Controls.Add(Me.b_Close)
        Me.Controls.Add(Me.b_Open)
        Me.Controls.Add(Me.b_Wide)
        Me.Controls.Add(Me.b_Tele)
        Me.Controls.Add(Me.l_Iris)
        Me.Controls.Add(Me.l_Zoom)
        Me.Controls.Add(Me.l_PanTilt)
        Me.Controls.Add(Me.b_Down)
        Me.Controls.Add(Me.b_Right)
        Me.Controls.Add(Me.b_Left)
        Me.Controls.Add(Me.b_Up)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_CamCtrl"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_Up As System.Windows.Forms.Button
    Friend WithEvents b_Left As System.Windows.Forms.Button
    Friend WithEvents b_Right As System.Windows.Forms.Button
    Friend WithEvents b_Down As System.Windows.Forms.Button
    Friend WithEvents l_PanTilt As System.Windows.Forms.Label
    Friend WithEvents l_Zoom As System.Windows.Forms.Label
    Friend WithEvents l_Iris As System.Windows.Forms.Label
    Friend WithEvents b_Tele As System.Windows.Forms.Button
    Friend WithEvents b_Wide As System.Windows.Forms.Button
    Friend WithEvents b_Open As System.Windows.Forms.Button
    Friend WithEvents b_Close As System.Windows.Forms.Button
    Friend WithEvents b_Stop As System.Windows.Forms.Button
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
