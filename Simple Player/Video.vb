Public Class Video
    Private Sub Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Video_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
       AxWindowsMediaPlayer1.Width = Me.Size.Width
               AxWindowsMediaPlayer1.Height = Me.Size.Height

    End Sub

    Private Sub Video_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
               AxWindowsMediaPlayer1.Width = Me.Size.Width
               AxWindowsMediaPlayer1.Height = Me.Size.Height
    End Sub
End Class