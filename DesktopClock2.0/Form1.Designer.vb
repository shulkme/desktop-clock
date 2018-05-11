<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class desktopclock
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(desktopclock))
        Me.TA_timer = New System.Windows.Forms.Timer(Me.components)
        Me.pb_dot = New System.Windows.Forms.PictureBox()
        Me.pb_min_S = New System.Windows.Forms.PictureBox()
        Me.pb_min_T = New System.Windows.Forms.PictureBox()
        Me.pb_hour_S = New System.Windows.Forms.PictureBox()
        Me.pb_hour_T = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LB_date = New System.Windows.Forms.Label()
        Me.SEC_timer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menu_lock = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_runauto = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_exit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pb_dot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_min_S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_min_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_hour_S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_hour_T, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TA_timer
        '
        Me.TA_timer.Interval = 50
        '
        'pb_dot
        '
        Me.pb_dot.Image = Global.DesktopClock2._0.My.Resources.Resources.ic_dot
        Me.pb_dot.Location = New System.Drawing.Point(235, 10)
        Me.pb_dot.Name = "pb_dot"
        Me.pb_dot.Size = New System.Drawing.Size(34, 130)
        Me.pb_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_dot.TabIndex = 6
        Me.pb_dot.TabStop = False
        '
        'pb_min_S
        '
        Me.pb_min_S.Image = Global.DesktopClock2._0.My.Resources.Resources.ic_num_currency
        Me.pb_min_S.Location = New System.Drawing.Point(395, 10)
        Me.pb_min_S.Name = "pb_min_S"
        Me.pb_min_S.Size = New System.Drawing.Size(100, 1480)
        Me.pb_min_S.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_min_S.TabIndex = 5
        Me.pb_min_S.TabStop = False
        '
        'pb_min_T
        '
        Me.pb_min_T.Image = Global.DesktopClock2._0.My.Resources.Resources.ic_num_currency
        Me.pb_min_T.Location = New System.Drawing.Point(290, 10)
        Me.pb_min_T.Name = "pb_min_T"
        Me.pb_min_T.Size = New System.Drawing.Size(100, 1480)
        Me.pb_min_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_min_T.TabIndex = 4
        Me.pb_min_T.TabStop = False
        '
        'pb_hour_S
        '
        Me.pb_hour_S.Image = Global.DesktopClock2._0.My.Resources.Resources.ic_num_currency
        Me.pb_hour_S.Location = New System.Drawing.Point(115, 10)
        Me.pb_hour_S.Name = "pb_hour_S"
        Me.pb_hour_S.Size = New System.Drawing.Size(100, 1480)
        Me.pb_hour_S.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_hour_S.TabIndex = 3
        Me.pb_hour_S.TabStop = False
        '
        'pb_hour_T
        '
        Me.pb_hour_T.Image = Global.DesktopClock2._0.My.Resources.Resources.ic_hour
        Me.pb_hour_T.Location = New System.Drawing.Point(10, 10)
        Me.pb_hour_T.Margin = New System.Windows.Forms.Padding(0)
        Me.pb_hour_T.Name = "pb_hour_T"
        Me.pb_hour_T.Size = New System.Drawing.Size(100, 430)
        Me.pb_hour_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_hour_T.TabIndex = 0
        Me.pb_hour_T.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LB_date)
        Me.Panel1.Location = New System.Drawing.Point(0, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 122)
        Me.Panel1.TabIndex = 7
        '
        'LB_date
        '
        Me.LB_date.AutoSize = True
        Me.LB_date.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_date.ForeColor = System.Drawing.Color.White
        Me.LB_date.Location = New System.Drawing.Point(223, 13)
        Me.LB_date.Name = "LB_date"
        Me.LB_date.Size = New System.Drawing.Size(0, 28)
        Me.LB_date.TabIndex = 0
        '
        'SEC_timer
        '
        Me.SEC_timer.Enabled = True
        Me.SEC_timer.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.menu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "DesktopClock2.0"
        Me.NotifyIcon1.Visible = True
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_lock, Me.menu_runauto, Me.menu_exit})
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(153, 92)
        '
        'menu_lock
        '
        Me.menu_lock.Name = "menu_lock"
        Me.menu_lock.Size = New System.Drawing.Size(152, 22)
        Me.menu_lock.Text = "取消锁定"
        '
        'menu_runauto
        '
        Me.menu_runauto.Name = "menu_runauto"
        Me.menu_runauto.Size = New System.Drawing.Size(152, 22)
        Me.menu_runauto.Text = "开机自启"
        '
        'menu_exit
        '
        Me.menu_exit.Name = "menu_exit"
        Me.menu_exit.Size = New System.Drawing.Size(152, 22)
        Me.menu_exit.Text = "退出"
        '
        'desktopclock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(504, 201)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pb_dot)
        Me.Controls.Add(Me.pb_min_S)
        Me.Controls.Add(Me.pb_min_T)
        Me.Controls.Add(Me.pb_hour_S)
        Me.Controls.Add(Me.pb_hour_T)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "desktopclock"
        Me.ShowInTaskbar = False
        Me.Text = "DesktopClock"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.pb_dot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_min_S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_min_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_hour_S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_hour_T, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_hour_T As PictureBox
    Friend WithEvents TA_timer As Timer
    Friend WithEvents pb_hour_S As PictureBox
    Friend WithEvents pb_min_T As PictureBox
    Friend WithEvents pb_min_S As PictureBox
    Friend WithEvents pb_dot As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SEC_timer As Timer
    Friend WithEvents LB_date As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents menu As ContextMenuStrip
    Friend WithEvents menu_lock As ToolStripMenuItem
    Friend WithEvents menu_exit As ToolStripMenuItem
    Friend WithEvents menu_runauto As ToolStripMenuItem
End Class
