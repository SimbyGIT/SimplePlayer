Imports System.Security.Principal
Imports Microsoft.Win32

Public Class Equa
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
       
    End Sub
End Class