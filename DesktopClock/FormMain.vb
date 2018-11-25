Public Class FormMain
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (
                                              ByVal hwnd As IntPtr,
                                              ByVal wMsg As Integer,
                                              ByVal wParam As Integer,
                                              ByVal lParam As Integer) _
                                              As Boolean
    Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Const WM_SYSCOMMAND = &H112
    Const SC_MOVE = &HF010&
    Const HTCAPTION = 2

    Private H As Integer
    Private M As Integer
    Private H_L As Integer
    Private H_R As Integer
    Private M_L As Integer
    Private M_R As Integer

    Private timeMode24 As Boolean  '时间制式
    Private fontFamily As Font  '字体样式
    Private fontColor As Color  '字体颜色
    Private wordSpace As Integer '字体间距
    Private dotSpace As Integer  '点间距
    Private dotTop As Integer   '点上偏移
    Private formBackColor As Color  '窗体背景色
    '查找相近颜色，用于背景透明，目的消除锯齿
    Public Function GetSimilarColor(oColor As Color)
        Dim cR As Integer
        Dim cG As Integer
        Dim cB As Integer
        Dim nColor As Color
        cR = oColor.R
        cG = oColor.G
        cB = oColor.B
        If cR = 255 Then
            cR = cR - 1
        Else
            cR = cR + 1
        End If
        If cG = 255 Then
            cG = cG - 1
        Else
            cG = cG + 1
        End If
        If cB = 255 Then
            cB = cB - 1
        Else
            cB = cB + 1
        End If
        nColor = Color.FromArgb(cR, cG, cB)
        Return nColor
    End Function
    '程序初始化
    Public Function SysInit()
        '获取程序设置
        dotSpace = My.Settings.dotSpace
        dotTop = My.Settings.dotTop
        wordSpace = My.Settings.wordSpace
        fontFamily = My.Settings.fontFamily
        fontColor = My.Settings.fontColor
        timeMode24 = My.Settings.timeMode24
        '设置字体样式
        Label_H_L.Font = fontFamily
        Label_H_R.Font = fontFamily
        Label_M_L.Font = fontFamily
        Label_M_R.Font = fontFamily
        Label_dot.Font = fontFamily
        '设置字体颜色
        Label_H_L.ForeColor = fontColor
        Label_H_R.ForeColor = fontColor
        Label_M_L.ForeColor = fontColor
        Label_M_R.ForeColor = fontColor
        Label_dot.ForeColor = fontColor
        '获取点及字体样式和定位
        Dim dotWodth As Integer = Label_dot.Width
        Dim fontWidth As Integer = Label_H_L.Width
        Dim fontHeight As Integer = Label_H_L.Height
        Dim fontLocationX As Integer = (wordSpace - fontWidth) / 2
        Dim dotLocationX As Integer = (dotSpace - dotWodth) / 2
        '设置点及字体样式和定位
        Panel_H_L.Width = wordSpace
        Panel_H_L.Height = fontHeight
        Panel_H_L.Location = New Point(0, 0)
        Panel_H_R.Width = wordSpace
        Panel_H_R.Height = fontHeight
        Panel_H_R.Location = New Point(wordSpace, 0)
        Panel_M_L.Width = wordSpace
        Panel_M_L.Height = fontHeight
        Panel_M_L.Location = New Point(2 * wordSpace + dotSpace, 0)
        Panel_M_R.Width = wordSpace
        Panel_M_R.Height = fontHeight
        Panel_M_R.Location = New Point(3 * wordSpace + dotSpace, 0)
        Label_H_L.Location = New Point(fontLocationX, 0)
        Label_H_R.Location = New Point(fontLocationX, 0)
        Label_M_L.Location = New Point(fontLocationX, 0)
        Label_M_R.Location = New Point(fontLocationX, 0)
        Label_dot.Location = New Point(2 * wordSpace + dotLocationX, dotTop)
        '设置窗体大小及背景色
        Me.Width = 4 * wordSpace + dotSpace
        Me.Height = fontHeight
        formBackColor = GetSimilarColor(fontColor)
        Me.BackColor = formBackColor
        Me.TransparencyKey = formBackColor
        Return 0
    End Function
    '窗体加载
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Settings.Location) '获取并设置窗体的定位
        SysInit()
    End Sub

    Private Sub Timer_time_Tick(sender As Object, e As EventArgs) Handles Timer_time.Tick
        '获取系统时间并格式化
        M = Format(DateTime.Now, "mm")
        '设置时间制式
        If timeMode24 Then
            H = Format(DateTime.Now, "HH")
        Else
            H = Format(DateTime.Now, "hh")
        End If
        H_L = H \ 10
        H_R = H Mod 10
        M_L = M \ 10
        M_R = M Mod 10
        '小时高位0不显示
        If H_L = 0 Then
            Label_H_L.Text = ""
        Else
            Label_H_L.Text = H_L
        End If
        '显示时间
        Label_H_R.Text = H_R
        Label_M_L.Text = M_L
        Label_M_R.Text = M_R
    End Sub
    '移动窗体
    Private Sub Label_Drop_MouseMove(sender As Object, e As MouseEventArgs) Handles Label_Drop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub
    '菜单项：移动窗体
    Private Sub Menu_move_Click(sender As Object, e As EventArgs) Handles Menu_move.Click
        Label_Drop.Width = Me.Width
        Label_Drop.Height = Me.Height
        Label_Drop.BackColor = Color.FromArgb(255, 255, 50)
        Label_Drop.Location = New Point(0, 0)
        Label_Drop.Visible = True
        Me.Opacity = 0.5
    End Sub
    '菜单项：退出程序
    Private Sub Menu_exit_Click(sender As Object, e As EventArgs) Handles Menu_exit.Click
        End
    End Sub
    '移动窗体块双击退出移动状态，并保存当前位置
    Private Sub Label_Drop_DoubleClick(sender As Object, e As EventArgs) Handles Label_Drop.DoubleClick
        Label_Drop.Visible = False
        Me.Opacity = 1
        My.Settings.Location = New Point(Me.Location)
        My.Settings.Save()
    End Sub
    '菜单项：打开设置
    Private Sub Menu_setting_Click(sender As Object, e As EventArgs) Handles Menu_setting.Click
        FormSetting.Show()
    End Sub
End Class
