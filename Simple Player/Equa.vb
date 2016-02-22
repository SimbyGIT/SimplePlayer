Imports System.ComponentModel
Imports System.Security.Principal
Imports Microsoft.Win32

Public Class Equa
    Public url, token, uid As String

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        url = WebBrowser1.Url.ToString
        If url.Substring(1, 10) = "ttp://link" Then
            token = url.Substring(url.IndexOf("=") + 1, url.IndexOf("&") - url.IndexOf("=") - 1)
            uid = url.Split("=")(3)
            VK.Show()
            Me.Hide()
        End If
    End Sub



    Public Sub SetCurrentEffectPreset(ByVal value As Integer)
        Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim path As String = String.Format("{0}\Software\Microsoft\MediaPlayer\Preferences", identity.User.Value)
        Dim key As RegistryKey = Registry.Users.OpenSubKey(path, True)
        If key Is Nothing Then
            Throw New Exception("Error! Registry not found!")
        End If
        key.SetValue("CurrentEffectPreset", value, RegistryValueKind.DWord)
    End Sub



    Private Sub Equa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://api.vkontakte.ru/oauth/authorize?client_id=5310825&scope=audio&redirect_uri=linkos.esy.es/vk.php&display=popup&response_type=token")
    End Sub

    Private Sub Equa_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
End Class