﻿
Imports System.IO
Imports AxWMPLib
Imports SkinSoft.VisualStyler
Imports SkinSoft.VisualStyler.Licensing
Imports WMPLib

Public Class frmMain
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 
        Volume.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Try

            Label2.Text = (AxWindowsMediaPlayer1.Ctlcontrols.currentItem.name)

            Label3.Text = (AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString)


            Dim itemno As Integer

            itemno = ListBox1.SelectedIndex

            If Me.AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsStopped Then
                Me.ListBox1.SelectedIndex = itemno + 1
                ListBox3.SelectedIndex = ListBox1.SelectedIndex
                AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem

                Timer1.Start()


            End If


        Catch ex As Exception

            ' program the timer to read if repeat is turned on and then replay 

            If CheckBox1.Checked = True Then
                ListBox1.SelectedIndex = "0"
                ListBox3.SelectedIndex = ListBox1.SelectedIndex
                AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem

            Else
                AxWindowsMediaPlayer1.URL = ""

            End If
        End Try

        Try
            'program the trackbar at the top of the page to read the progress of the media player

            If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPlaying Then
                Me.TrackBar1.Value = Me.AxWindowsMediaPlayer1.Ctlcontrols.currentPosition

            End If

        Catch ex As Exception

            If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsMediaEnded Then
                Me.TrackBar1.Value = 0
                Timer1.Start()

            End If


        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 


        If _
            AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPaused And
            ListBox3.SelectedItem = AxWindowsMediaPlayer1.URL Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()


        Else
            ListBox3.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem
            Timer1.Start()
        End If
    End Sub

    Private Sub ImportASongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportASongToolStripMenuItem.Click _
        
        OpenFileDialog1.Filter =
            "Аудиофайлы(.wav,*.mp3,*.mpeg,*.snd,*.au,*.aif,*.aifc,*.aiff,*.wma)|*.wav;*.mp3;*.mpeg;*.m4a;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma"
        OpenFileDialog1.FileName = ""


        Try

            OpenFileDialog1.Multiselect = True
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then
            Else
                For Each s As String In OpenFileDialog1.SafeFileNames
                    ListBox1.Items.Add(s)
                Next
                For Each s As String In OpenFileDialog1.FileNames

                    ListBox3.Items.Add(s)
                Next
                Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1

            End If


        Catch ex As Exception

        End Try

        If ListBox1.Items.Count <= 1 Then
            Button2.Visible = False
        Else
            Button2.Visible = True


        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll 
        Me.AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar1.Value
    End Sub

    Private Sub AxWindowsMediaPlayer1_Buffering(sender As Object, e As _WMPOCXEvents_BufferingEvent) Handles AxWindowsMediaPlayer1.Buffering _
        
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub AxWindowsMediaPlayer1_NewStream(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.NewStream _
        
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange _
        


        If _
            Me.AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsBuffering Or
            Me.AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPlaying Then
            Me.TrackBar1.Minimum = 0
            Me.TrackBar1.Maximum = Me.AxWindowsMediaPlayer1.currentMedia.duration
            Me.Timer1.Start()
        ElseIf _
            Me.AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsMediaEnded Or
            Me.AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsStopped Then
            Me.TrackBar1.Value = 0
            Me.Timer1.Start()


        End If
        If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPlaying And My.Settings.Notification = True Then
            Try


            Catch ex As Exception

            End Try
        End If

        Try
            If AxWindowsMediaPlayer1.URL = "" Or AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPaused Then

            Else

                Dim song_title As String
                song_title = ListBox1.SelectedItem
                If ListBox4.Items.Contains(song_title) Then

                Else
                    ListBox4.Items.Add(song_title)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 

        AxWindowsMediaPlayer1.URL = ""
        Timer1.Stop()
        TrackBar1.Value = 0
        Label3.Text = "00:00"
        Label2.Text = "----"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 
        If AxWindowsMediaPlayer1.Ctlcontrols.currentPosition <= 3 Then
            Try

                Timer1.Stop()
                AxWindowsMediaPlayer1.URL = ""
                Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
                ListBox3.SelectedIndex = ListBox1.SelectedIndex
                AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem

                If ListBox1.SelectedIndex = - 1 Then
                    Timer1.Stop()
                    AxWindowsMediaPlayer1.URL = ""
                    Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex = 1
                    ListBox3.SelectedIndex = ListBox1.SelectedIndex
                    AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem
                End If


            Catch ex As Exception

                If ListBox1.SelectedIndex = False Then
                    AxWindowsMediaPlayer1.URL = ""
                Else
                End If
            End Try
        Else
            ListBox3.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem
            Timer1.Start()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 
        Try

            Timer1.Stop()
            AxWindowsMediaPlayer1.URL = ""
            Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            ListBox3.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem


        Catch ex As Exception

            If ListBox1.SelectedIndex = False Then
                AxWindowsMediaPlayer1.URL = ""
            Else

                Timer1.Stop()
                AxWindowsMediaPlayer1.URL = ""
                Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex = 1
                ListBox3.SelectedIndex = ListBox1.SelectedIndex
                AxWindowsMediaPlayer1.URL = ListBox3.SelectedItem

            End If
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click 
Me.Close()

    End Sub

    Private Sub frmMain_Leave(sender As Object, e As EventArgs) Handles Me.Leave
    End Sub

    Private Sub FindMyString(ByVal searchString As String)
   If searchString <> String.Empty Then
      Dim index As Integer = listBox1.FindString(searchString)
      If index <> -1 Then
         listBox1.SetSelected(index, True)
      Else
         MessageBox.Show("Нет совпадений")
      End If
   End If
End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = My.Settings.Opacity
        If My.Settings.Skin = True then
            VisualStyler.RestoreApplicationSkin()
            Else 
            VisualStyler.RemoveApplicationSkin()

                End If
        Button2.Visible = False

        Try

            AxWindowsMediaPlayer1.settings.volume = My.Settings.Volume.ToString
            If My.Settings.ShowPlayer = True Then
                AxWindowsMediaPlayer1.Visible = True


            Else

                AxWindowsMediaPlayer1.Visible = False

            End If
        Catch ex As Exception

        End Try


        If My.Settings.Playlist1_Name = "" Then
            Playlist1ToolStripMenuItem.Visible = False
        Else
            If My.Settings.Playlist1_User_Imput_Name = "" Then
                Playlist1ToolStripMenuItem.Text = "Плейлист 1"
            Else
                Playlist1ToolStripMenuItem.Text = My.Settings.Playlist1_User_Imput_Name
            End If
        End If

        If My.Settings.Playlist2_Name = "" Then
            Playlist2ToolStripMenuItem.Visible = False
        Else
            If My.Settings.Playlist2_User_Imput_Name = "" Then
                Playlist2ToolStripMenuItem.Text = "Плейлист 2"
            Else
                Playlist2ToolStripMenuItem.Text = My.Settings.Playlist2_User_Imput_Name
            End If

        End If

        If My.Settings.Playlist3_Name = "" Then
            Playlist3ToolStripMenuItem.Visible = False
        Else
            If My.Settings.Playlist3_User_Imput_Name = "" Then
                Playlist3ToolStripMenuItem.Text = "Плейлист 3"
            Else
                Playlist3ToolStripMenuItem.Text = My.Settings.Playlist3_User_Imput_Name
            End If

        End If

        If My.Settings.Playlist4_Name = "" Then
            Playlist4ToolStripMenuItem.Visible = False
        Else
            If My.Settings.Playlist4_User_Imput_Name = "" Then
                Playlist4ToolStripMenuItem.Text = "Плейлист 4"
            Else
                Playlist4ToolStripMenuItem.Text = My.Settings.Playlist4_User_Imput_Name
            End If

        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick 

        Button5.PerformClick()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click 
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 
        AxWindowsMediaPlayer1.settings.volume = 0
        Volume.TrackBar1.Value = 0
    End Sub


    Private Sub DeleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click _
        
        Timer1.Stop()
        AxWindowsMediaPlayer1.URL = ""
        ListBox1.Items.Clear()
        ListBox3.Items.Clear()
        TrackBar1.Value = 0
        Label3.Text = "00:00"
        Label2.Text = "----"
        If ListBox1.Items.Count <= 1 Then
            Button2.Visible = False

        End If
    End Sub

    Private Sub DeleteSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedItemToolStripMenuItem.Click _
        
        Try
            ListBox3.SelectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox3.Items.Remove(ListBox3.SelectedItem)
            ListBox1.SelectedIndex = "0"

        Catch ex As Exception
            ListBox3.SelectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox3.Items.Remove(ListBox3.SelectedItem)
            ListBox1.SelectedIndex = "-1"
            ListBox3.SelectedIndex = "-1"
        End Try

        AxWindowsMediaPlayer1.URL = ""
        Timer1.Stop()
        TrackBar1.Value = 0
        Label3.Text = "00:00"
        Label2.Text = "----"


        If ListBox1.Items.Count <= 1 Then
            Button2.Visible = False

        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click _
        
        Settings.Show()
    End Sub


    Private Sub RadioPlayerX10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioPlayerX10ToolStripMenuItem.Click _
        
        Radio_Player_X10.Show()
    End Sub

    Private Sub CreateSaveAPlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateSaveAPlaylistToolStripMenuItem.Click _
        
        Try
            Create_or_Save_Playlist.Show()

        Catch ex As Exception


        End Try
    End Sub

    Public Sub NotifyBaloon ()
        
    notifyIcon1.BalloonTipTitle = "Simple Player"
    notifyIcon1.BalloonTipText = "Сейчас играет: " + Label2.Text
    notifyIcon1.Visible = True
    notifyIcon1.ShowBalloonTip(3000)
            
    End Sub

    Private Sub Playlist1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Playlist1ToolStripMenuItem.Click _
        
        Try
            ListBox1.Items.Clear()
            ListBox3.Items.Clear()
            Button3.PerformClick()
            Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist1Contents.txt")
            While (r.Peek() > - 1)
                ListBox3.Items.Add(r.ReadLine)
            End While
            r.Close()

            Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist1SafeFileNames.txt")
            While (a.Peek() > - 1)
                ListBox1.Items.Add(a.ReadLine)
            End While
            a.Close()
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Button2.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Playlist2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Playlist2ToolStripMenuItem.Click _
        
        Try
            ListBox1.Items.Clear()
            ListBox3.Items.Clear()
            Button3.PerformClick()
            Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist2Contents.txt")
            While (r.Peek() > - 1)
                ListBox3.Items.Add(r.ReadLine)
            End While
            r.Close()

            Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist2SafeFileNames.txt")
            While (a.Peek() > - 1)
                ListBox1.Items.Add(a.ReadLine)
            End While
            a.Close()
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Button2.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Playlist3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Playlist3ToolStripMenuItem.Click _
        
        Try
            ListBox1.Items.Clear()
            ListBox3.Items.Clear()
            Button3.PerformClick()
            Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist3Contents.txt")
            While (r.Peek() > - 1)
                ListBox3.Items.Add(r.ReadLine)
            End While
            r.Close()

            Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist3SafeFileNames.txt")
            While (a.Peek() > - 1)
                ListBox1.Items.Add(a.ReadLine)
            End While
            a.Close()
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Button2.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Playlist4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Playlist4ToolStripMenuItem.Click _
        
        Try
            ListBox1.Items.Clear()
            ListBox3.Items.Clear()
            Button3.PerformClick()
            Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist4Contents.txt")
            While (r.Peek() > - 1)
                ListBox3.Items.Add(r.ReadLine)
            End While
            r.Close()

            Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist4SafeFileNames.txt")
            While (a.Peek() > - 1)
                ListBox1.Items.Add(a.ReadLine)
            End While
            a.Close()
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Button2.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AxWindowsMediaPlayer1_MediaError(sender As Object, e As _WMPOCXEvents_MediaErrorEvent) Handles AxWindowsMediaPlayer1.MediaError _
        
        MsgBox(
            "A Error Has Occured. The File In Location " & ListBox3.SelectedItem &
            " . Is Either Corrupt Or Has Moved. If This File Is In A Playlist Please Remove It. Press OK To Remove The Item From Now Playing.")
        ListBox1.SelectedIndex = ListBox3.SelectedIndex
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        ListBox3.Items.Remove(ListBox3.SelectedItem)
        Button3.PerformClick()
    End Sub

    Private Sub PlayerOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerOptionsToolStripMenuItem.Click _
        
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FindMyString(TextBox1.Text)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) 

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If My.Settings.Notify = True then
             NotifyBaloon()
        End If
       
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Equa.Show()

    End Sub
End Class
