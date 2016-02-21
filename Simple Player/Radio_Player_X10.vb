
Imports AxWMPLib
Imports WMPLib

Public Class Radio_Player_X10
    Dim station As String

    Private Sub Radio_Player_X10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = My.Settings.Opacity
        AxWindowsMediaPlayer1.settings.volume = My.Settings.Volume
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = "http://wms.absoluteradio.co.uk/absoluteradio.co.uk/vc_lo"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.URL = "http://streaming.radiocloud.co.uk/realradioscotland.m3u"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "http://mediasrv.musicradio.com/CapitalGold"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.URL = "http://media-ice.musicradio.com/HeartEastDevonMP3.m3u"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.URL = "http://mediasrv.musicradio.com/ClassicFM"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.URL = "http://mediasrv.musicradio.com/CapitalRadio"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.URL = "http://www.bbc.co.uk/radio/listen/live/r4.asx"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.URL = "http://www.bbc.co.uk/radio/listen/live/r3.asx"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.URL = "http://www.bbc.co.uk/radio/listen/live/r2.asx"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AxWindowsMediaPlayer1.URL = "http://www.bbc.co.uk/radio/listen/live/r1.asx"

        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer1.URL = "http://www.radiofeeds.co.uk/a648mp3.m3u"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AxWindowsMediaPlayer1.URL = "http://www.radiofeeds.co.uk/a7128mp3.m3u"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AxWindowsMediaPlayer1.URL = "http://wms.absoluteradio.co.uk/absoluteradio.co.uk/a8_lo"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AxWindowsMediaPlayer1.URL = "http://wms.absoluteradio.co.uk/absoluteradio.co.uk/a9_lo"
        TextBox1.Text = "Connecting"
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
    End Sub

    Private Sub AxWindowsMediaPlayer1_MediaError(sender As Object, e As _WMPOCXEvents_MediaErrorEvent) _
        Handles AxWindowsMediaPlayer1.MediaError
        MsgBox(
            "An Error Has Occured While Connecting.Either The Station Is Not Availiable Or It Has Failed To Connect. Please Try Again Later.")
        AxWindowsMediaPlayer1.URL = ""
        TextBox1.Text = "Failed To Connect"
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) _
        Handles AxWindowsMediaPlayer1.PlayStateChange
        If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsBuffering Then
            TextBox1.Text = "Connecting"
        End If

        If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPlaying Then
            TextBox1.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentItem.name

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AxWindowsMediaPlayer1.URL = ""
        TextBox1.Text = "Stopped"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Volume.Show()
    End Sub
End Class


