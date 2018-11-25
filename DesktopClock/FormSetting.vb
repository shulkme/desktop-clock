Public Class FormSetting
    Private timeMode24 As Boolean '时间制式
    Private fontFamily As Font '字体样式
    Private fontColor As Color  '字体颜色
    Private wordSpace As Integer '字体间距
    Private dotSpace As Integer '点间距
    Private dotTop As Integer '点上偏移
    Private runAuto As Boolean '开机自启
    '窗体加载
    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '获取程序设置
        dotSpace = My.Settings.dotSpace
        dotTop = My.Settings.dotTop
        wordSpace = My.Settings.wordSpace
        fontFamily = My.Settings.fontFamily
        fontColor = My.Settings.fontColor
        timeMode24 = My.Settings.timeMode24
        runAuto = My.Settings.runAuto
        '初始化时间制式下拉框
        If timeMode24 Then
            ComboBox_timeMode.SelectedItem = "24"
        Else
            ComboBox_timeMode.SelectedItem = "12"
        End If

        TextBox_font.Text = fontFamily.Name & "," & fontFamily.Size '初始化字体样式选择框
        PictureBox_fontColor.BackColor = fontColor '初始化字体颜色选择框
        '初始化点设置框
        NUD_wordSpace.Value = wordSpace
        NUD_dotSpace.Value = dotSpace
        NUD_dopTop.Value = dotTop
        CheckBox_runAuto.Checked = runAuto '初始化开机自启选择框
    End Sub
    '字体样式选择框
    Private Sub TextBox_font_Click(sender As Object, e As EventArgs) Handles TextBox_font.Click
        Dim myFontDialog As FontDialog
        myFontDialog = New FontDialog()
        myFontDialog.Font = My.Settings.fontFamily
        If myFontDialog.ShowDialog() = DialogResult.OK Then
            fontFamily = myFontDialog.Font
        End If
    End Sub
    '字体颜色选择框
    Private Sub PictureBox_fontColor_Click(sender As Object, e As EventArgs) Handles PictureBox_fontColor.Click
        Dim myColorDialog As ColorDialog
        myColorDialog = New ColorDialog()
        myColorDialog.Color = My.Settings.fontColor
        If myColorDialog.ShowDialog() = DialogResult.OK Then
            PictureBox_fontColor.BackColor = myColorDialog.Color
            fontColor = myColorDialog.Color
        End If
    End Sub
    '时间制式下拉框
    Private Sub ComboBox_timeMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_timeMode.SelectedIndexChanged
        If ComboBox_timeMode.SelectedItem = "24" Then
            timeMode24 = True
        Else
            timeMode24 = False
        End If
    End Sub
    '开机自启选择框
    Private Sub CheckBox_runAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_runAuto.CheckedChanged
        runAuto = CheckBox_runAuto.Checked
    End Sub
    '保存设置并应用设置
    Private Sub Btn_apply_Click(sender As Object, e As EventArgs) Handles Btn_apply.Click
        Dim reg As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        '写入注册表
        Try
            If runAuto Then
                reg.SetValue("desktopClock.exe", Application.StartupPath & "\desktopClock.exe")
            Else
                reg.DeleteValue("desktopClock.exe")
            End If
        Catch ex As Exception

        End Try

        '保存设置
        My.Settings.timeMode24 = timeMode24
        My.Settings.fontFamily = fontFamily
        My.Settings.fontColor = fontColor
        My.Settings.wordSpace = wordSpace
        My.Settings.dotSpace = dotSpace
        My.Settings.dotTop = dotTop
        My.Settings.runAuto = runAuto
        My.Settings.Save()
        FormMain.SysInit() '应用设置
    End Sub
    '字体间距调节框
    Private Sub NUD_wordSpace_ValueChanged(sender As Object, e As EventArgs) Handles NUD_wordSpace.ValueChanged
        wordSpace = NUD_wordSpace.Value
    End Sub
    '点间距调节框
    Private Sub NUD_dotSpace_ValueChanged(sender As Object, e As EventArgs) Handles NUD_dotSpace.ValueChanged
        dotSpace = NUD_dotSpace.Value
    End Sub
    '点上偏移调节框
    Private Sub NUD_dopTop_ValueChanged(sender As Object, e As EventArgs) Handles NUD_dopTop.ValueChanged
        dotTop = NUD_dopTop.Value
    End Sub
End Class