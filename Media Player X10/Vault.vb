Public Class Vault

    Private Sub Vault_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Black_Theme = True Then
            BackColor = Color.Black

        End If

        If My.Settings.Silver_Theme = True Then
            BackColor = Color.Silver
        End If

        If Not My.Settings.Password_Vault.Count = 0 Then
            Dim ibook As Integer
            Do Until My.Settings.Password_Vault.Count = ibook
                ListBox1.Items.Add(My.Settings.Password_Vault(ibook))
                ibook += 1
            Loop
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Settings.Password_Vault.Remove(ListBox1.Text)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class