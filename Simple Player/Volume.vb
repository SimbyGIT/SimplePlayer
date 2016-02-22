Public Class Volume
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        frmMain.AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        Radio_Player_X10.AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        My.Settings.Volume = TrackBar1.Value
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        Label2.Text = TrackBar1.Value.ToString + "%"
    End Sub

    Private Sub Volume_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = My.Settings.Opacity
        TrackBar1.Value = My.Settings.Volume
        frmMain.AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        Radio_Player_X10.AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        frmMain.AxWindowsMediaPlayer1.settings.balance = HScrollBar1.Value
        Radio_Player_X10.AxWindowsMediaPlayer1.settings.balance = HScrollBar1.Value
    End Sub
End Class