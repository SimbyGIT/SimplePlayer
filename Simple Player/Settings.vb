Imports SkinSoft.VisualStyler

Public Class Settings
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Edit_Playlists.Show()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Value = My.Settings.Opacity*100
        Me.Opacity = My.Settings.Opacity
        CheckBox2.Checked = My.Settings.Notify
        If My.Settings.Skin = True Then
            CheckBox1.Checked = True 'Проверка на галочку для применения скина
        Else
            CheckBox1.Checked = False
        End If
        TextBox1.Text = My.Settings.dir
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VisualStyler.RemoveApplicationSkin()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VisualStyler.RestoreApplicationSkin()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            My.Settings.Skin = True
        Else
            My.Settings.Skin = False
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        My.Settings.Opacity = HScrollBar1.Value/100
        Opacity = HScrollBar1.Value/100
        frmMain.Opacity = HScrollBar1.Value/100
        Volume.Opacity = HScrollBar1.Value/100
        Radio_Player_X10.Opacity = HScrollBar1.Value/100
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Settings.Notify = True
        Else
            My.Settings.Notify = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FBD1.ShowDialog = DialogResult.OK Then My.Settings.dir = FBD1.SelectedPath
        TextBox1.Text = My.Settings.dir
    End Sub
End Class