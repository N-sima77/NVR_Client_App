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
        Me.AxpsLookupCtrl = New AxpslookupLib.Axpslookupctrl
        Me.Label1 = New System.Windows.Forms.Label
        Me.b_Search = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        CType(Me.AxpsLookupCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxpsLookupCtrl
        '
        Me.AxpsLookupCtrl.Enabled = True
        Me.AxpsLookupCtrl.Location = New System.Drawing.Point(434, 12)
        Me.AxpsLookupCtrl.Name = "AxpsLookupCtrl"
        Me.AxpsLookupCtrl.OcxState = CType(resources.GetObject("AxpsLookupCtrl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxpsLookupCtrl.Size = New System.Drawing.Size(10, 10)
        Me.AxpsLookupCtrl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Cameras"
        '
        'b_Search
        '
        Me.b_Search.Location = New System.Drawing.Point(117, 15)
        Me.b_Search.Name = "b_Search"
        Me.b_Search.Size = New System.Drawing.Size(100, 30)
        Me.b_Search.TabIndex = 2
        Me.b_Search.Text = "&Start"
        Me.b_Search.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(14, 60)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(528, 292)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 366)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.b_Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxpsLookupCtrl)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SimpleSample_PSLookup"
        CType(Me.AxpsLookupCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxpsLookupCtrl As AxpslookupLib.Axpslookupctrl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_Search As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
