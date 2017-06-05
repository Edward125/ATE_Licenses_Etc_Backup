<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.combLine = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnEtc = New System.Windows.Forms.Button()
        Me.btnLIC = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'combLine
        '
        Me.combLine.FormattingEnabled = True
        Me.combLine.Items.AddRange(New Object() {"AS2-A", "AS2-B", "AS3-A", "AS3-B", "AS4-A", "AS4-B", "AS5-A", "AS5-B", "AS6-A", "AS6-B", "AS7-A", "AS7-B", "AS8-A", "AS8-B"})
        Me.combLine.Location = New System.Drawing.Point(6, 23)
        Me.combLine.Name = "combLine"
        Me.combLine.Size = New System.Drawing.Size(92, 25)
        Me.combLine.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConfig)
        Me.GroupBox1.Controls.Add(Me.btnEtc)
        Me.GroupBox1.Controls.Add(Me.btnLIC)
        Me.GroupBox1.Controls.Add(Me.combLine)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(474, 17)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(162, 34)
        Me.btnConfig.TabIndex = 5
        Me.btnConfig.Text = "Config"
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnEtc
        '
        Me.btnEtc.Location = New System.Drawing.Point(298, 17)
        Me.btnEtc.Name = "btnEtc"
        Me.btnEtc.Size = New System.Drawing.Size(157, 34)
        Me.btnEtc.TabIndex = 4
        Me.btnEtc.Text = "ETC"
        Me.btnEtc.UseVisualStyleBackColor = True
        '
        'btnLIC
        '
        Me.btnLIC.Location = New System.Drawing.Point(113, 17)
        Me.btnLIC.Name = "btnLIC"
        Me.btnLIC.Size = New System.Drawing.Size(169, 34)
        Me.btnLIC.TabIndex = 3
        Me.btnLIC.Text = "LIC"
        Me.btnLIC.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 89)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "ATE_Licenses_Etc_Backup 1.0(Edward Song)"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents combLine As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents btnEtc As System.Windows.Forms.Button
    Friend WithEvents btnLIC As System.Windows.Forms.Button

End Class
