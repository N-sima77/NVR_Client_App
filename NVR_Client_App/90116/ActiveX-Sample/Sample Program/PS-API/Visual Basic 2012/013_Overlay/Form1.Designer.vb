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
        Me.chk_drawTitle = New System.Windows.Forms.CheckBox
        Me.chk_drawBox = New System.Windows.Forms.CheckBox
        Me.chk_BMPDraw = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
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
        '
        'chk_drawTitle
        '
        Me.chk_drawTitle.AutoSize = True
        Me.chk_drawTitle.Location = New System.Drawing.Point(46, 535)
        Me.chk_drawTitle.Name = "chk_drawTitle"
        Me.chk_drawTitle.Size = New System.Drawing.Size(77, 16)
        Me.chk_drawTitle.TabIndex = 2
        Me.chk_drawTitle.Text = "Draw Title"
        Me.chk_drawTitle.UseVisualStyleBackColor = True
        '
        'chk_drawBox
        '
        Me.chk_drawBox.AutoSize = True
        Me.chk_drawBox.Location = New System.Drawing.Point(46, 557)
        Me.chk_drawBox.Name = "chk_drawBox"
        Me.chk_drawBox.Size = New System.Drawing.Size(74, 16)
        Me.chk_drawBox.TabIndex = 3
        Me.chk_drawBox.Text = "Draw Box"
        Me.chk_drawBox.UseVisualStyleBackColor = True
        '
        'chk_BMPDraw
        '
        Me.chk_BMPDraw.AutoSize = True
        Me.chk_BMPDraw.Location = New System.Drawing.Point(46, 579)
        Me.chk_BMPDraw.Name = "chk_BMPDraw"
        Me.chk_BMPDraw.Size = New System.Drawing.Size(126, 16)
        Me.chk_BMPDraw.TabIndex = 4
        Me.chk_BMPDraw.Text = "Image Transmission"
        Me.chk_BMPDraw.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 577)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(452, 19)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 606)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chk_BMPDraw)
        Me.Controls.Add(Me.chk_drawBox)
        Me.Controls.Add(Me.chk_drawTitle)
        Me.Controls.Add(Me.AxipropsapiCtrl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_Overlay"
        CType(Me.AxipropsapiCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxipropsapiCtrl1 As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents chk_drawTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chk_drawBox As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BMPDraw As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
