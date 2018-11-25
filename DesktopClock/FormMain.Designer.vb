<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label_H_L = New System.Windows.Forms.Label()
        Me.Label_M_L = New System.Windows.Forms.Label()
        Me.Label_M_R = New System.Windows.Forms.Label()
        Me.Label_H_R = New System.Windows.Forms.Label()
        Me.Label_dot = New System.Windows.Forms.Label()
        Me.Panel_H_L = New System.Windows.Forms.Panel()
        Me.Panel_H_R = New System.Windows.Forms.Panel()
        Me.Panel_M_L = New System.Windows.Forms.Panel()
        Me.Panel_M_R = New System.Windows.Forms.Panel()
        Me.Timer_time = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Drop = New System.Windows.Forms.Label()
        Me.Notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_move = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_setting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_H_L.SuspendLayout()
        Me.Panel_H_R.SuspendLayout()
        Me.Panel_M_L.SuspendLayout()
        Me.Panel_M_R.SuspendLayout()
        Me.CMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_H_L
        '
        Me.Label_H_L.AllowDrop = True
        Me.Label_H_L.AutoEllipsis = True
        Me.Label_H_L.AutoSize = True
        Me.Label_H_L.BackColor = System.Drawing.Color.Transparent
        Me.Label_H_L.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_H_L.ForeColor = System.Drawing.Color.White
        Me.Label_H_L.Location = New System.Drawing.Point(3, 7)
        Me.Label_H_L.Name = "Label_H_L"
        Me.Label_H_L.Size = New System.Drawing.Size(99, 117)
        Me.Label_H_L.TabIndex = 0
        Me.Label_H_L.Text = "0"
        '
        'Label_M_L
        '
        Me.Label_M_L.AllowDrop = True
        Me.Label_M_L.AutoEllipsis = True
        Me.Label_M_L.AutoSize = True
        Me.Label_M_L.BackColor = System.Drawing.Color.Transparent
        Me.Label_M_L.Font = New System.Drawing.Font("微软雅黑", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_M_L.ForeColor = System.Drawing.Color.White
        Me.Label_M_L.Location = New System.Drawing.Point(29, 23)
        Me.Label_M_L.Name = "Label_M_L"
        Me.Label_M_L.Size = New System.Drawing.Size(108, 124)
        Me.Label_M_L.TabIndex = 0
        Me.Label_M_L.Text = "0"
        '
        'Label_M_R
        '
        Me.Label_M_R.AllowDrop = True
        Me.Label_M_R.AutoEllipsis = True
        Me.Label_M_R.AutoSize = True
        Me.Label_M_R.BackColor = System.Drawing.Color.Transparent
        Me.Label_M_R.Font = New System.Drawing.Font("微软雅黑", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_M_R.ForeColor = System.Drawing.Color.White
        Me.Label_M_R.Location = New System.Drawing.Point(28, 36)
        Me.Label_M_R.Name = "Label_M_R"
        Me.Label_M_R.Size = New System.Drawing.Size(108, 124)
        Me.Label_M_R.TabIndex = 0
        Me.Label_M_R.Text = "0"
        '
        'Label_H_R
        '
        Me.Label_H_R.AllowDrop = True
        Me.Label_H_R.AutoEllipsis = True
        Me.Label_H_R.AutoSize = True
        Me.Label_H_R.BackColor = System.Drawing.Color.Transparent
        Me.Label_H_R.Font = New System.Drawing.Font("微软雅黑", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_H_R.ForeColor = System.Drawing.Color.White
        Me.Label_H_R.Location = New System.Drawing.Point(20, 23)
        Me.Label_H_R.Name = "Label_H_R"
        Me.Label_H_R.Size = New System.Drawing.Size(108, 124)
        Me.Label_H_R.TabIndex = 0
        Me.Label_H_R.Text = "0"
        '
        'Label_dot
        '
        Me.Label_dot.AllowDrop = True
        Me.Label_dot.AutoEllipsis = True
        Me.Label_dot.AutoSize = True
        Me.Label_dot.BackColor = System.Drawing.Color.Transparent
        Me.Label_dot.Font = New System.Drawing.Font("微软雅黑", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_dot.Location = New System.Drawing.Point(290, 25)
        Me.Label_dot.Name = "Label_dot"
        Me.Label_dot.Size = New System.Drawing.Size(75, 124)
        Me.Label_dot.TabIndex = 0
        Me.Label_dot.Text = ":"
        '
        'Panel_H_L
        '
        Me.Panel_H_L.BackColor = System.Drawing.Color.Transparent
        Me.Panel_H_L.Controls.Add(Me.Label_H_L)
        Me.Panel_H_L.Location = New System.Drawing.Point(10, 2)
        Me.Panel_H_L.Name = "Panel_H_L"
        Me.Panel_H_L.Size = New System.Drawing.Size(130, 191)
        Me.Panel_H_L.TabIndex = 2
        '
        'Panel_H_R
        '
        Me.Panel_H_R.BackColor = System.Drawing.Color.Transparent
        Me.Panel_H_R.Controls.Add(Me.Label_H_R)
        Me.Panel_H_R.Location = New System.Drawing.Point(146, 2)
        Me.Panel_H_R.Name = "Panel_H_R"
        Me.Panel_H_R.Size = New System.Drawing.Size(152, 191)
        Me.Panel_H_R.TabIndex = 2
        '
        'Panel_M_L
        '
        Me.Panel_M_L.BackColor = System.Drawing.Color.Transparent
        Me.Panel_M_L.Controls.Add(Me.Label_M_L)
        Me.Panel_M_L.Location = New System.Drawing.Point(371, 2)
        Me.Panel_M_L.Name = "Panel_M_L"
        Me.Panel_M_L.Size = New System.Drawing.Size(152, 191)
        Me.Panel_M_L.TabIndex = 2
        '
        'Panel_M_R
        '
        Me.Panel_M_R.BackColor = System.Drawing.Color.Transparent
        Me.Panel_M_R.Controls.Add(Me.Label_M_R)
        Me.Panel_M_R.Location = New System.Drawing.Point(529, 2)
        Me.Panel_M_R.Name = "Panel_M_R"
        Me.Panel_M_R.Size = New System.Drawing.Size(152, 191)
        Me.Panel_M_R.TabIndex = 2
        '
        'Timer_time
        '
        Me.Timer_time.Enabled = True
        Me.Timer_time.Interval = 1000
        '
        'Label_Drop
        '
        Me.Label_Drop.BackColor = System.Drawing.Color.Coral
        Me.Label_Drop.Location = New System.Drawing.Point(8, 162)
        Me.Label_Drop.Name = "Label_Drop"
        Me.Label_Drop.Size = New System.Drawing.Size(622, 72)
        Me.Label_Drop.TabIndex = 3
        Me.Label_Drop.Visible = False
        '
        'Notify
        '
        Me.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Notify.BalloonTipTitle = "DC"
        Me.Notify.ContextMenuStrip = Me.CMenu
        Me.Notify.Icon = CType(resources.GetObject("Notify.Icon"), System.Drawing.Icon)
        Me.Notify.Text = "DesktopClock"
        Me.Notify.Visible = True
        '
        'CMenu
        '
        Me.CMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_move, Me.Menu_setting, Me.Menu_exit})
        Me.CMenu.Name = "Menu"
        Me.CMenu.Size = New System.Drawing.Size(113, 70)
        '
        'Menu_move
        '
        Me.Menu_move.Name = "Menu_move"
        Me.Menu_move.Size = New System.Drawing.Size(112, 22)
        Me.Menu_move.Text = "移动"
        '
        'Menu_setting
        '
        Me.Menu_setting.Name = "Menu_setting"
        Me.Menu_setting.Size = New System.Drawing.Size(112, 22)
        Me.Menu_setting.Text = "首选项"
        '
        'Menu_exit
        '
        Me.Menu_exit.Name = "Menu_exit"
        Me.Menu_exit.Size = New System.Drawing.Size(112, 22)
        Me.Menu_exit.Text = "退出"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(707, 263)
        Me.Controls.Add(Me.Label_Drop)
        Me.Controls.Add(Me.Panel_M_R)
        Me.Controls.Add(Me.Panel_M_L)
        Me.Controls.Add(Me.Panel_H_L)
        Me.Controls.Add(Me.Panel_H_R)
        Me.Controls.Add(Me.Label_dot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.Panel_H_L.ResumeLayout(False)
        Me.Panel_H_L.PerformLayout()
        Me.Panel_H_R.ResumeLayout(False)
        Me.Panel_H_R.PerformLayout()
        Me.Panel_M_L.ResumeLayout(False)
        Me.Panel_M_L.PerformLayout()
        Me.Panel_M_R.ResumeLayout(False)
        Me.Panel_M_R.PerformLayout()
        Me.CMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_H_L As Label
    Friend WithEvents Label_M_L As Label
    Friend WithEvents Label_M_R As Label
    Friend WithEvents Label_H_R As Label
    Friend WithEvents Label_dot As Label
    Friend WithEvents Panel_H_L As Panel
    Friend WithEvents Panel_H_R As Panel
    Friend WithEvents Panel_M_L As Panel
    Friend WithEvents Panel_M_R As Panel
    Friend WithEvents Timer_time As Timer
    Friend WithEvents Label_Drop As Label
    Friend WithEvents Notify As NotifyIcon
    Friend WithEvents CMenu As ContextMenuStrip
    Friend WithEvents Menu_move As ToolStripMenuItem
    Friend WithEvents Menu_setting As ToolStripMenuItem
    Friend WithEvents Menu_exit As ToolStripMenuItem
End Class
