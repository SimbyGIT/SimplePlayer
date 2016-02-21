Imports Simple_Player.My
Imports SkinSoft.VisualStyler
Imports SkinSoft.VisualStyler.Licensing

Public Class Settings
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Edit_Playlists.Show()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Value = 100

        If My.Settings.Skin = True Then
            CheckBox1.Checked =True 'Проверка на галочку для применения скина
            Else 
             CheckBox1.Checked =False
        End If
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
        My.Settings.Opacity = HScrollBar1.Value
        Opacity = HScrollBar1.Value
    End Sub
End Class