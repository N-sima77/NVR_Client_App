<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxiProCtrl = New AxIPROPSAPILib.AxipropsapiCtrl
        Me.b_SetInternetMode = New System.Windows.Forms.Button
        Me.b_LiveStart = New System.Windows.Forms.Button
        Me.b_LiveEnd = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.AxiProCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxiProCtrl
        '
        Me.AxiProCtrl.Enabled = True
        Me.AxiProCtrl.Location = New System.Drawing.Point(12, 12)
        Me.AxiProCtrl.Name = "AxiProCtrl"
        Me.AxiProCtrl.OcxState = CType(resources.GetObject("AxiProCtrl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxiProCtrl.Size = New System.Drawing.Size(640, 480)
        Me.AxiProCtrl.TabIndex = 0
        '
        'b_SetInternetMode
        '
        Me.b_SetInternetMode.Location = New System.Drawing.Point(12, 550)
        Me.b_SetInternetMode.Name = "b_SetInternetMode"
        Me.b_SetInternetMode.Size = New System.Drawing.Size(100, 30)
        Me.b_SetInternetMode.TabIndex = 2
        Me.b_SetInternetMode.Text = "Set Internet&Mode"
        Me.b_SetInternetMode.UseVisualStyleBackColor = True
        '
        'b_LiveStart
        '
        Me.b_LiveStart.Location = New System.Drawing.Point(12, 514)
        Me.b_LiveStart.Name = "b_LiveStart"
        Me.b_LiveStart.Size = New System.Drawing.Size(100, 30)
        Me.b_LiveStart.TabIndex = 3
        Me.b_LiveStart.Text = "Live &Start"
        Me.b_LiveStart.UseVisualStyleBackColor = True
        '
        'b_LiveEnd
        '
        Me.b_LiveEnd.Location = New System.Drawing.Point(118, 514)
        Me.b_LiveEnd.Name = "b_LiveEnd"
        Me.b_LiveEnd.Size = New System.Drawing.Size(100, 30)
        Me.b_LiveEnd.TabIndex = 4
        Me.b_LiveEnd.Text = "Live &End"
        Me.b_LiveEnd.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 561)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(25, 19)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 596)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.b_LiveEnd)
        Me.Controls.Add(Me.b_LiveStart)
        Me.Controls.Add(Me.b_SetInternetMode)
        Me.Controls.Add(Me.AxiProCtrl)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_InternetModeLive"
        CType(Me.AxiProCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxiProCtrl As AxIPROPSAPILib.AxipropsapiCtrl
    Friend WithEvents b_SetInternetMode As System.Windows.Forms.Button
    Friend WithEvents b_LiveStart As System.Windows.Forms.Button
    Friend WithEvents b_LiveEnd As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
