Imports System.IO
Imports WMPLib

Public Class Create_or_Save_Playlist
    Private Sub Create_or_Save_Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Playlist1_Name = "" Then
            TextBox1.Text = "Playlist 1"
        Else

            If My.Settings.Playlist2_Name = "" Then
                TextBox1.Text = "Playlist 2"
            Else

                If My.Settings.Playlist3_Name = "" Then
                    TextBox1.Text = "Playlist 3"
                Else

                    If My.Settings.Playlist4_Name = "" Then
                        TextBox1.Text = "Playlist 4"


                    Else
                        MsgBox(
                            "All Playlist Spots Have Been Filled Please Delete Some By Visiting The Playlist Options Under The Settings.")
                        Me.Close()


                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter A Playlist Name Before Saving")
        Else


            If My.Settings.Playlist1_Name = "" Then
                If Directory.Exists("C:\ProgramData\Simple Player\Playlists") Then
                    Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist1Contents.txt")
                    Dim i As Integer
                    For i = 0 To ListBox2.Items.Count - 1
                        w.WriteLine(ListBox2.Items.Item(i))
                    Next
                    w.Close()

                    Dim a As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist1SafeFileNames.txt")
                    Dim b As Integer
                    For b = 0 To ListBox1.Items.Count - 1
                        a.WriteLine(ListBox1.Items.Item(b))
                    Next
                    a.Close()

                Else
                    Directory.CreateDirectory("C:\ProgramData\Simple Player\Playlists")
                    Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist1Contents.txt")
                    Dim i As Integer
                    For i = 0 To ListBox2.Items.Count - 1
                        w.WriteLine(ListBox2.Items.Item(i))
                    Next
                    w.Close()
                    Dim a As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist1SafeFileNames.txt")
                    Dim b As Integer
                    For b = 0 To ListBox1.Items.Count - 1
                        a.WriteLine(ListBox1.Items.Item(b))
                    Next
                    a.Close()
                End If
                MsgBox("Playlist 1 Created Successfully")
                My.Settings.Playlist1_Name = "Playlist1"
                My.Settings.Playlist1_User_Imput_Name = TextBox1.Text
                frmMain.Playlist1ToolStripMenuItem.Visible = True
                frmMain.Playlist1ToolStripMenuItem.Text = My.Settings.Playlist1_User_Imput_Name
                My.Settings.Save()
                Me.Close()


            Else
                If My.Settings.Playlist2_Name = "" Then
                    If Directory.Exists("C:\ProgramData\Simple Player\Playlists") Then
                        Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist2Contents.txt")
                        Dim i As Integer
                        For i = 0 To ListBox2.Items.Count - 1
                            w.WriteLine(ListBox2.Items.Item(i))
                        Next
                        w.Close()

                        Dim a As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist2SafeFileNames.txt")
                        Dim b As Integer
                        For b = 0 To ListBox1.Items.Count - 1
                            a.WriteLine(ListBox1.Items.Item(b))
                        Next
                        a.Close()
                    Else
                        Directory.CreateDirectory("C:\ProgramData\Simple Player\Playlists")
                        Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist2Contents.txt")
                        Dim i As Integer
                        For i = 0 To ListBox2.Items.Count - 1
                            w.WriteLine(ListBox2.Items.Item(i))
                        Next
                        w.Close()
                        Dim a As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist2SafeFileNames.txt")
                        Dim b As Integer
                        For b = 0 To ListBox1.Items.Count - 1
                            a.WriteLine(ListBox1.Items.Item(b))
                        Next
                        a.Close()
                    End If
                    MsgBox("Playlist 2 Created Successfully")
                    My.Settings.Playlist2_Name = "Playlist2"
                    My.Settings.Playlist2_User_Imput_Name = TextBox1.Text
                    frmMain.Playlist2ToolStripMenuItem.Visible = True
                    frmMain.Playlist2ToolStripMenuItem.Text = My.Settings.Playlist2_User_Imput_Name
                    My.Settings.Save()
                    Me.Close()


                Else
                    If My.Settings.Playlist3_Name = "" Then
                        If Directory.Exists("C:\ProgramData\Simple Player\Playlists") Then
                            Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist3Contents.txt")
                            Dim i As Integer
                            For i = 0 To ListBox2.Items.Count - 1
                                w.WriteLine(ListBox2.Items.Item(i))
                            Next
                            w.Close()
                            Dim _
                                a As _
                                    New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist3SafeFileNames.txt")
                            Dim b As Integer
                            For b = 0 To ListBox1.Items.Count - 1
                                a.WriteLine(ListBox1.Items.Item(b))
                            Next
                            a.Close()
                        Else
                            Directory.CreateDirectory("C:\ProgramData\Simple Player\Playlists")
                            Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist3Contents.txt")
                            Dim i As Integer
                            For i = 0 To ListBox2.Items.Count - 1
                                w.WriteLine(ListBox2.Items.Item(i))
                            Next
                            w.Close()
                            Dim _
                                a As _
                                    New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist3SafeFileNames.txt")
                            Dim b As Integer
                            For b = 0 To ListBox1.Items.Count - 1
                                a.WriteLine(ListBox1.Items.Item(b))
                            Next
                            a.Close()
                        End If
                        MsgBox("Playlist 3 Created Successfully")
                        My.Settings.Playlist3_Name = "Playlist3"
                        My.Settings.Playlist3_User_Imput_Name = TextBox1.Text
                        frmMain.Playlist3ToolStripMenuItem.Visible = True
                        frmMain.Playlist3ToolStripMenuItem.Text = My.Settings.Playlist3_User_Imput_Name
                        My.Settings.Save()
                        Me.Close()


                    Else

                        If My.Settings.Playlist4_Name = "" Then
                            If Directory.Exists("C:\ProgramData\Simple Player\Playlists") Then
                                Dim _
                                    w As _
                                        New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist4Contents.txt")
                                Dim i As Integer
                                For i = 0 To ListBox2.Items.Count - 1
                                    w.WriteLine(ListBox2.Items.Item(i))
                                Next
                                w.Close()

                                Dim _
                                    a As _
                                        New StreamWriter(
                                            "C:\ProgramData\Simple Player\Playlists\Playlist4SafeFileNames.txt")
                                Dim b As Integer
                                For b = 0 To ListBox1.Items.Count - 1
                                    a.WriteLine(ListBox1.Items.Item(b))
                                Next
                                a.Close()
                            Else
                                Directory.CreateDirectory("C:\ProgramData\Simple Player\Playlists")
                                Dim _
                                    w As _
                                        New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist4Contents.txt")
                                Dim i As Integer
                                For i = 0 To ListBox2.Items.Count - 1
                                    w.WriteLine(ListBox2.Items.Item(i))
                                Next
                                w.Close()
                                Dim _
                                    a As _
                                        New StreamWriter(
                                            "C:\ProgramData\Simple Player\Playlists\Playlist4SafeFileNames.txt")
                                Dim b As Integer
                                For b = 0 To ListBox1.Items.Count - 1
                                    a.WriteLine(ListBox1.Items.Item(b))
                                Next
                                a.Close()
                            End If
                            MsgBox("Playlist 4 Created Successfully")
                            My.Settings.Playlist4_Name = "Playlist4"
                            My.Settings.Playlist4_User_Imput_Name = TextBox1.Text
                            frmMain.Playlist4ToolStripMenuItem.Visible = True
                            frmMain.Playlist4ToolStripMenuItem.Text = My.Settings.Playlist4_User_Imput_Name
                            My.Settings.Save()
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OpenFileDialog1.Filter =
            "Audio Files(*.wav,*.mp3,*.mpeg,*.snd,*.au,*.aif,*.aifc,*.aiff,*.wma)|*.wav;*.mp3;*.mpeg;*.m4a;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma"
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

                    ListBox2.Items.Add(s)
                Next
                Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If frmMain.ListBox1.Items.Count = 0 Then
            MsgBox("Please Add Songs To The Music Player Playlist Before Importing Songs To This Playlist")
        Else

            For Each s As String In frmMain.ListBox1.Items
                ListBox1.Items.Add(s)
            Next
            For Each s As String In frmMain.ListBox3.Items
                ListBox2.Items.Add(s)
            Next
        End If
    End Sub

    Private Sub AddMusicPlayerPlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles AddMusicPlayerPlaylistToolStripMenuItem.Click
        If frmMain.ListBox1.Items.Count = 0 Then
            MsgBox("Please Add Songs To The Music Player Playlist Before Importing Songs To This Playlist")
        Else

            For Each s As String In frmMain.ListBox1.Items
                ListBox1.Items.Add(s)
            Next
            For Each s As String In frmMain.ListBox3.Items
                ListBox2.Items.Add(s)
            Next
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub DeleteSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles DeleteSelectedItemToolStripMenuItem.Click
        AxWindowsMediaPlayer1.URL = ""
        Try
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox1.SelectedIndex = "0"

        Catch ex As Exception
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox1.SelectedIndex = "-1"
            ListBox2.SelectedIndex = "-1"
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.URL = ""
        Try
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox1.SelectedIndex = "0"

        Catch ex As Exception
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox1.SelectedIndex = "-1"
            ListBox2.SelectedIndex = "-1"
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.URL = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub EmptyPlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles EmptyPlaylistToolStripMenuItem.Click
        AxWindowsMediaPlayer1.URL = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPaused Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()

        Else
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
        End If
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.URL = ""
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Try


            AxWindowsMediaPlayer1.URL = ""
            Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem


        Catch ex As Exception

            If ListBox1.SelectedIndex = False Then
                AxWindowsMediaPlayer1.URL = ""
            Else


                AxWindowsMediaPlayer1.URL = ""
                Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex = 1
                ListBox2.SelectedIndex = ListBox1.SelectedIndex
                AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem

            End If
        End Try
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles PreviousToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.Ctlcontrols.currentPosition <= 3 Then
            Try


                AxWindowsMediaPlayer1.URL = ""
                Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
                ListBox2.SelectedIndex = ListBox1.SelectedIndex
                AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem

                If ListBox1.SelectedIndex = - 1 Then

                    AxWindowsMediaPlayer1.URL = ""
                    Me.ListBox1.SelectedIndex = ListBox1.SelectedIndex = 1
                    ListBox2.SelectedIndex = ListBox1.SelectedIndex
                    AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
                End If


            Catch ex As Exception

                If ListBox1.SelectedIndex = False Then
                    AxWindowsMediaPlayer1.URL = ""
                Else
                End If
            End Try
        Else
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub ImportSongsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ImportSongsToolStripMenuItem.Click
        OpenFileDialog1.Filter =
            "Audio Files(*.wav,*.mp3,*.mpeg,*.snd,*.au,*.aif,*.aifc,*.aiff,*.wma)|*.wav;*.mp3;*.mpeg;*.m4a;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma"
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

                    ListBox2.Items.Add(s)
                Next
                Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddSongsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles AddSongsToolStripMenuItem.Click
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles MenuStrip1.ItemClicked
    End Sub
End Class