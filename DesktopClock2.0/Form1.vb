Public Class desktopclock
    Dim hour_T_H = 0
    Dim hour_S_H = 0
    Dim min_T_H = 0
    Dim min_S_H = 0
    Dim hour_T_Differ = 0
    Dim hour_S_Differ = 0
    Dim min_T_Differ = 0
    Dim min_S_Differ = 0
    Dim hour_T_left = 0
    Dim hour_S_left = 0
    Dim min_T_left = 0
    Dim min_S_left = 0
    Dim speed = 15
    Dim sw = Screen.PrimaryScreen.Bounds.Width.ToString  '获取屏幕宽度
    Dim sh = Screen.PrimaryScreen.Bounds.Height.ToString  '获取屏幕高度
    Dim mw = 520
    Dim mh = 240

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hour_T_left = pb_hour_T.Location.X
        hour_S_left = pb_hour_S.Location.X
        min_T_left = pb_min_T.Location.X
        min_S_left = pb_min_S.Location.X
        Me.Location = New Point((sw - mw) / 2, (sh - mh) / 2.2)
        Dim a As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        If a.GetValue("DesktopClock2.0.exe", "null").ToString = "null" Then
            menu.Items.Item("menu_runauto").Text = "开机自启"
        Else
            menu.Items.Item("menu_runauto").Text = "取消自启"
        End If
    End Sub

    Private Sub TA_timer_Tick(sender As Object, e As EventArgs) Handles TA_timer.Tick
        Dim hour_T_top_now = pb_hour_T.Location.Y
        Dim hour_S_top_now = pb_hour_S.Location.Y
        Dim min_T_top_now = pb_min_T.Location.Y
        Dim min_S_top_now = pb_min_S.Location.Y

        If hour_T_top_now <> hour_T_H Then
            If hour_T_Differ > 0 Then
                pb_hour_T.Location = New Point(hour_T_left, hour_T_top_now + speed)
            Else
                pb_hour_T.Location = New Point(hour_T_left, hour_T_top_now - speed)
            End If
        Else
            pb_hour_T.Location = New Point(hour_T_left, hour_T_H)
        End If

        If hour_S_top_now <> hour_S_H Then
            If hour_S_Differ > 0 Then
                pb_hour_S.Location = New Point(hour_S_left, hour_S_top_now + speed)
            Else
                pb_hour_S.Location = New Point(hour_S_left, hour_S_top_now - speed)
            End If
        Else
            pb_hour_S.Location = New Point(hour_S_left, hour_S_H)
        End If


        If min_T_top_now <> min_T_H Then
            If min_T_Differ > 0 Then
                pb_min_T.Location = New Point(min_T_left, min_T_top_now + speed)
            Else
                pb_min_T.Location = New Point(min_T_left, min_T_top_now - speed)
            End If
        Else
            pb_min_T.Location = New Point(min_T_left, min_T_H)
        End If

        If min_S_top_now <> min_S_H Then
            If min_S_Differ > 0 Then
                pb_min_S.Location = New Point(min_S_left, min_S_top_now + speed)
            Else
                pb_min_S.Location = New Point(min_S_left, min_S_top_now - speed)
            End If
        Else
            pb_min_S.Location = New Point(min_S_left, min_S_H)
        End If

    End Sub

    Private Sub SEC_timer_Tick(sender As Object, e As EventArgs) Handles SEC_timer.Tick
        Dim hour_T = Format(DateTime.Now, "HH") \ 10
        Dim hour_S = Format(DateTime.Now, "HH") Mod 10
        Dim min_T = Format(DateTime.Now, "mm") \ 10
        Dim min_S = Format(DateTime.Now, "mm") Mod 10
        hour_T_H = -(150 * hour_T) + 10
        hour_S_H = -(150 * hour_S) + 10
        min_T_H = -(150 * min_T) + 10
        min_S_H = -(150 * min_S) + 10

        Dim hour_T_top = pb_hour_T.Location.Y
        Dim hour_S_top = pb_hour_S.Location.Y
        Dim min_T_top = pb_min_T.Location.Y
        Dim min_S_top = pb_min_S.Location.Y

        hour_T_Differ = hour_T_H - hour_T_top
        hour_S_Differ = hour_S_H - hour_S_top
        min_T_Differ = min_T_H - min_T_top
        min_S_Differ = min_S_H - min_S_top

        If hour_T_Differ <> 0 Or hour_S_Differ <> 0 Or min_T_Differ <> 0 Or min_S_Differ <> 0 Then
            TA_timer.Enabled = True
        Else
            TA_timer.Enabled = False
        End If

        Dim now_date = Format(DateTime.Now, "MM月dd日")
        Dim now_week = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek)
        LB_date.Text = now_date & "  " & now_week
        LB_date.Location = New Point(pb_dot.Location.X + (pb_dot.Width - LB_date.Width) / 2, LB_date.Location.Y)

    End Sub

    Private Sub menu_exit_Click(sender As Object, e As EventArgs) Handles menu_exit.Click
        End
    End Sub

    Private Sub menu_lock_Click(sender As Object, e As EventArgs) Handles menu_lock.Click
        If Me.FormBorderStyle = FormBorderStyle.FixedToolWindow Then
            Me.FormBorderStyle = FormBorderStyle.None
            menu.Items.Item("menu_lock").Text = "取消锁定"
        Else
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
            menu.Items.Item("menu_lock").Text = "锁定"
        End If
    End Sub

    Private Sub menu_runauto_Click(sender As Object, e As EventArgs) Handles menu_runauto.Click
        If menu.Items.Item("menu_runauto").Text = "开机自启" Then
            Dim a As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            a.SetValue("DesktopClock2.0.exe", Application.StartupPath & "\DesktopClock2.0.exe")
            menu.Items.Item("menu_runauto").Text = "取消自启"
        Else
            Dim a As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            a.DeleteValue("DesktopClock2.0.exe")
            menu.Items.Item("menu_runauto").Text = "开机自启"
        End If
    End Sub
End Class
