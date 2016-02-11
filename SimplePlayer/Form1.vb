Public Class Main
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Play_but_Click(sender As Object, e As EventArgs) Handles Play_but.Click
        Player.Ctlcontrols.play()

    End Sub

    Private Sub Stop_but_Click(sender As Object, e As EventArgs) Handles Stop_but.Click
        Player.Ctlcontrols.stop()

    End Sub

    Private Sub Next_but_Click(sender As Object, e As EventArgs) Handles Next_but.Click
        Player.Ctlcontrols.fastForward()

    End Sub

    Private Sub Foward_but_Click(sender As Object, e As EventArgs) Handles Foward_but.Click
        Player.Ctlcontrols.fastReverse()

    End Sub

    Private Sub PlaylistShow_Click(sender As Object, e As EventArgs) Handles PlaylistShow.Click
        Playlist.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub VolumeTrackBar_Scroll(sender As Object, e As EventArgs) Handles VolumeTrackBar.Scroll
        Player.settings.volume = VolumeTrackBar.Value

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player.settings.volume = VolumeTrackBar.Value
    End Sub
End Class
