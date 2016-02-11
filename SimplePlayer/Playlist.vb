Public Class Playlist

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Playlist_add_but_Click_1(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim open_music_file As New OpenFileDialog()
        open_music_file.InitialDirectory = "c:\"
        open_music_file.Filter = "MP3 (*.mp3)|*.mp3|Все файлы (*.*)|*.*"
        open_music_file.RestoreDirectory = True
        If open_music_file.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ListBox1.Items.Add(open_music_file.FileName)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Main.Player.URL = ListBox1.SelectedItem
    End Sub
End Class