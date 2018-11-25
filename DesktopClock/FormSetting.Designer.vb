<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_timeMode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUD_wordSpace = New System.Windows.Forms.NumericUpDown()
        Me.NUD_dotSpace = New System.Windows.Forms.NumericUpDown()
        Me.NUD_dopTop = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_font = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_apply = New System.Windows.Forms.Button()
        Me.PictureBox_fontColor = New System.Windows.Forms.PictureBox()
        Me.CheckBox_runAuto = New System.Windows.Forms.CheckBox()
        CType(Me.NUD_wordSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_dotSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_dopTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_fontColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "时间制式："
        '
        'ComboBox_timeMode
        '
        Me.ComboBox_timeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_timeMode.FormattingEnabled = True
        Me.ComboBox_timeMode.Items.AddRange(New Object() {"12", "24"})
        Me.ComboBox_timeMode.Location = New System.Drawing.Point(111, 9)
        Me.ComboBox_timeMode.Name = "ComboBox_timeMode"
        Me.ComboBox_timeMode.Size = New System.Drawing.Size(75, 20)
        Me.ComboBox_timeMode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "字体样式："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "字体间距："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "点间距："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "点上偏移："
        '
        'NUD_wordSpace
        '
        Me.NUD_wordSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUD_wordSpace.Location = New System.Drawing.Point(111, 99)
        Me.NUD_wordSpace.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NUD_wordSpace.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NUD_wordSpace.Name = "NUD_wordSpace"
        Me.NUD_wordSpace.Size = New System.Drawing.Size(75, 21)
        Me.NUD_wordSpace.TabIndex = 7
        Me.NUD_wordSpace.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'NUD_dotSpace
        '
        Me.NUD_dotSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUD_dotSpace.Location = New System.Drawing.Point(111, 129)
        Me.NUD_dotSpace.Name = "NUD_dotSpace"
        Me.NUD_dotSpace.Size = New System.Drawing.Size(75, 21)
        Me.NUD_dotSpace.TabIndex = 7
        '
        'NUD_dopTop
        '
        Me.NUD_dopTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUD_dopTop.Location = New System.Drawing.Point(111, 159)
        Me.NUD_dopTop.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NUD_dopTop.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.NUD_dopTop.Name = "NUD_dopTop"
        Me.NUD_dopTop.Size = New System.Drawing.Size(75, 21)
        Me.NUD_dopTop.TabIndex = 7
        '
        'TextBox_font
        '
        Me.TextBox_font.BackColor = System.Drawing.Color.White
        Me.TextBox_font.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox_font.Location = New System.Drawing.Point(111, 39)
        Me.TextBox_font.Name = "TextBox_font"
        Me.TextBox_font.ReadOnly = True
        Me.TextBox_font.Size = New System.Drawing.Size(75, 21)
        Me.TextBox_font.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "字体颜色："
        '
        'Btn_apply
        '
        Me.Btn_apply.Location = New System.Drawing.Point(116, 197)
        Me.Btn_apply.Name = "Btn_apply"
        Me.Btn_apply.Size = New System.Drawing.Size(70, 27)
        Me.Btn_apply.TabIndex = 11
        Me.Btn_apply.Text = "应用"
        Me.Btn_apply.UseVisualStyleBackColor = True
        '
        'PictureBox_fontColor
        '
        Me.PictureBox_fontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_fontColor.Location = New System.Drawing.Point(111, 69)
        Me.PictureBox_fontColor.Name = "PictureBox_fontColor"
        Me.PictureBox_fontColor.Size = New System.Drawing.Size(75, 21)
        Me.PictureBox_fontColor.TabIndex = 12
        Me.PictureBox_fontColor.TabStop = False
        '
        'CheckBox_runAuto
        '
        Me.CheckBox_runAuto.AutoSize = True
        Me.CheckBox_runAuto.Location = New System.Drawing.Point(12, 203)
        Me.CheckBox_runAuto.Name = "CheckBox_runAuto"
        Me.CheckBox_runAuto.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_runAuto.TabIndex = 13
        Me.CheckBox_runAuto.Text = "开机自启"
        Me.CheckBox_runAuto.UseVisualStyleBackColor = True
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 235)
        Me.Controls.Add(Me.CheckBox_runAuto)
        Me.Controls.Add(Me.PictureBox_fontColor)
        Me.Controls.Add(Me.Btn_apply)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_font)
        Me.Controls.Add(Me.NUD_dopTop)
        Me.Controls.Add(Me.NUD_dotSpace)
        Me.Controls.Add(Me.NUD_wordSpace)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox_timeMode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "首选项"
        CType(Me.NUD_wordSpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_dotSpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_dopTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_fontColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_timeMode As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NUD_wordSpace As NumericUpDown
    Friend WithEvents NUD_dotSpace As NumericUpDown
    Friend WithEvents NUD_dopTop As NumericUpDown
    Friend WithEvents TextBox_font As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_apply As Button
    Friend WithEvents PictureBox_fontColor As PictureBox
    Friend WithEvents CheckBox_runAuto As CheckBox
End Class
