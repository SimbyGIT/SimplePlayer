Imports System.ComponentModel
Imports System.Net

Public Class Download
    Dim WithEvents wc As New WebClient 'Создаем событие, вызываемое WebClient

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        wc.DownloadFileAsync(New Uri(VK.music(vk.ListBox1.Selectedindex + 1)),
                             My.settings.dir + "\" + vk.ListBox1.SelectedItem + ".mp3")
    End Sub

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) _
        Handles wc.DownloadFileCompleted
        ProgressBar1.Value = 0 'Загрузки завершены
        Label3.Text = "Завершено"
    End Sub

    Private Sub wc_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) _
        Handles wc.DownloadProgressChanged
        Label3.Text = e.ProgressPercentage
        ProgressBar1.Value = sender.ProgressPercentage 'Показываем прогресс скачивания
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VK.isRemote = False Then
            MsgBox("Скачивание возможно только из ВК. Откройте плейлист ВК и выделите песню")
            Me.Close()
        End If

        Label2.Text = vk.ListBox1.SelectedItem
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class