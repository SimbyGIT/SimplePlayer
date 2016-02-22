Imports System.IO
Imports WMPLib

Public Class Edit_Playlists
    Private Sub FindMyString(searchString As String)
        If searchString <> String.Empty Then
            Dim index As Integer = listBox1.FindString(searchString)
            If index <> - 1 Then
                listBox1.SetSelected(index, True)
            Else
                MessageBox.Show("Нет совпадений")
            End If
        End If
    End Sub

    Private Sub Edit_Playlists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Playlist1_Name = "" Then
            RadioButton1.Visible = False
        Else
            RadioButton1.Visible = True
            If My.Settings.Playlist1_User_Imput_Name = "" Then
                RadioButton1.Text = "Playlist 1"
            Else
                RadioButton1.Text = My.Settings.Playlist1_User_Imput_Name
            End If
        End If

        If My.Settings.Playlist2_Name = "" Then
            RadioButton2.Visible = False
        Else
            RadioButton2.Visible = True
            If My.Settings.Playlist2_User_Imput_Name = "" Then
                RadioButton2.Text = "Playlist 2"
            Else
                RadioButton2.Text = My.Settings.Playlist2_User_Imput_Name
            End If
        End If

        If My.Settings.Playlist3_Name = "" Then
            RadioButton3.Visible = False
        Else
            RadioButton3.Visible = True
            If My.Settings.Playlist3_User_Imput_Name = "" Then
                RadioButton3.Text = "Playlist 3"
            Else
                RadioButton3.Text = My.Settings.Playlist3_User_Imput_Name
            End If

        End If

        If My.Settings.Playlist4_Name = "" Then
            RadioButton4.Visible = False
        Else
            RadioButton4.Visible = True
            If My.Settings.Playlist4_User_Imput_Name = "" Then
                RadioButton4.Text = "Playlist 4"
            Else
                RadioButton4.Text = My.Settings.Playlist4_User_Imput_Name
            End If
        End If

        If _
            My.Settings.Playlist1_Name = "" And My.Settings.Playlist2_Name = "" And My.Settings.Playlist3_Name = "" And
            My.Settings.Playlist4_Name = "" Then
            MsgBox("Нет плейлистов. Создайте плейлист")
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            TextBox1.Text = ""

            Try
                Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist1Contents.txt")
                While (r.Peek() > - 1)
                    ListBox2.Items.Add(r.ReadLine)
                End While
                r.Close()

                Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist1SafeFileNames.txt")
                While (a.Peek() > - 1)
                    ListBox1.Items.Add(a.ReadLine)
                End While
                a.Close()
            Catch ex As Exception
            End Try
            TextBox1.ReadOnly = False
            If My.Settings.Playlist1_User_Imput_Name = "" Then
                TextBox1.Text = "Playlist 1"
            Else
                TextBox1.Text = My.Settings.Playlist1_User_Imput_Name
            End If
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        End If

        If RadioButton2.Checked = True Then
            Try
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist2Contents.txt")
                While (r.Peek() > - 1)
                    ListBox2.Items.Add(r.ReadLine)
                End While
                r.Close()

                Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist2SafeFileNames.txt")
                While (a.Peek() > - 1)
                    ListBox1.Items.Add(a.ReadLine)
                End While
                a.Close()
            Catch ex As Exception
            End Try
            TextBox1.ReadOnly = False
            If My.Settings.Playlist2_User_Imput_Name = "" Then
                TextBox1.Text = "Playlist 2"
            Else
                TextBox1.Text = My.Settings.Playlist2_User_Imput_Name
            End If
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        End If

        If RadioButton3.Checked = True Then
            Try
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist3Contents.txt")
                While (r.Peek() > - 1)
                    ListBox2.Items.Add(r.ReadLine)
                End While
                r.Close()

                Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist3SafeFileNames.txt")
                While (a.Peek() > - 1)
                    ListBox1.Items.Add(a.ReadLine)
                End While
                a.Close()
            Catch ex As Exception
            End Try
            TextBox1.ReadOnly = False
            If My.Settings.Playlist3_User_Imput_Name = "" Then
                TextBox1.Text = "Playlist 3"
            Else
                TextBox1.Text = My.Settings.Playlist3_User_Imput_Name
            End If
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        End If

        If RadioButton4.Checked = True Then
            Try
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                Dim r As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist4Contents.txt")
                While (r.Peek() > - 1)
                    ListBox2.Items.Add(r.ReadLine)
                End While
                r.Close()

                Dim a As New StreamReader("C:\ProgramData\Simple Player\Playlists\Playlist4SafeFileNames.txt")
                While (a.Peek() > - 1)
                    ListBox1.Items.Add(a.ReadLine)
                End While
                a.Close()
            Catch ex As Exception
            End Try
            TextBox1.ReadOnly = False
            If My.Settings.Playlist4_User_Imput_Name = "" Then
                TextBox1.Text = "Playlist 4"
            Else
                TextBox1.Text = My.Settings.Playlist4_User_Imput_Name
            End If
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPaused Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()

        Else
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
        End If
    End Sub

    Private Sub AddSongsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles AddSongsToolStripMenuItem.Click
        OpenFileDialog1.Filter =
            "Аудио Файлы(*.wav,*.mp3,*.mpeg,*.snd,*.au,*.aif,*.aifc,*.aiff,*.wma)|*.wav;*.mp3;*.mpeg;*.m4a;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma"
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

    Private Sub RemoveSelectedSongToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles RemoveSelectedSongToolStripMenuItem.Click
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

    Private Sub RemoveAllSongsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles RemoveAllSongsToolStripMenuItem.Click
        AxWindowsMediaPlayer1.URL = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub PreviewSelectedSongToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.URL = ""
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Save()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.URL = ""
        If RadioButton1.Checked = True Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            TextBox1.ReadOnly = True
            TextBox1.Text = ""
            My.Settings.Playlist1_Name = ""
            RadioButton1.Visible = False
            frmMain.Playlist1ToolStripMenuItem.Visible = False
            My.Settings.Save()
            Try
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist1Contents.txt")
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist1SafeFileNames.txt")
            Catch ex As Exception

            End Try
        End If

        If RadioButton2.Checked = True Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            TextBox1.ReadOnly = True
            TextBox1.Text = ""
            My.Settings.Playlist2_Name = ""
            RadioButton2.Visible = False
            frmMain.Playlist2ToolStripMenuItem.Visible = False
            My.Settings.Save()
            Try
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist2Contents.txt")
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist2SafeFileNames.txt")
            Catch ex As Exception

            End Try
        End If

        If RadioButton3.Checked = True Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            TextBox1.ReadOnly = True
            TextBox1.Text = ""
            My.Settings.Playlist3_Name = ""
            RadioButton3.Visible = False
            frmMain.Playlist3ToolStripMenuItem.Visible = False
            My.Settings.Save()
            Try
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist3Contents.txt")
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist3SafeFileNames.txt")
            Catch ex As Exception

            End Try
        End If

        If RadioButton4.Checked = True Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            TextBox1.ReadOnly = True
            TextBox1.Text = ""
            My.Settings.Playlist4_Name = ""
            RadioButton4.Visible = False
            frmMain.Playlist4ToolStripMenuItem.Visible = False
            My.Settings.Save()

            Try
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist4Contents.txt")
                File.Delete("C:\ProgramData\Simple Player\Playlists\Playlist4SafeFileNames.txt")
            Catch ex As Exception

            End Try

        End If

        If _
            RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And
            RadioButton4.Checked = False Then
            MsgBox(
                "Выберите плейлист прежде чем удалять")

        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Введите имя плейлиста , прежде чем сохранять")
        Else


            If RadioButton1.Checked = True Then
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
            MsgBox("Saved")
            My.Settings.Playlist1_User_Imput_Name = TextBox1.Text
            RadioButton1.Text = My.Settings.Playlist1_User_Imput_Name
            My.Settings.Save()
            frmMain.Playlist1ToolStripMenuItem.Text = My.Settings.Playlist1_User_Imput_Name


            If RadioButton2.Checked = True Then
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

                MsgBox("Saved")
                My.Settings.Playlist2_User_Imput_Name = TextBox1.Text
                RadioButton2.Text = My.Settings.Playlist2_User_Imput_Name
                frmMain.Playlist2ToolStripMenuItem.Text = My.Settings.Playlist2_User_Imput_Name
                My.Settings.Save()

            End If
            If RadioButton3.Checked = True Then
                Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist3Contents.txt")
                Dim i As Integer
                For i = 0 To ListBox2.Items.Count - 1
                    w.WriteLine(ListBox2.Items.Item(i))
                Next
                w.Close()

                Dim a As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist3SafeFileNames.txt")
                Dim b As Integer
                For b = 0 To ListBox1.Items.Count - 1
                    a.WriteLine(ListBox1.Items.Item(b))
                Next
                a.Close()

                MsgBox("Saved")
                My.Settings.Playlist3_User_Imput_Name = TextBox1.Text
                RadioButton3.Text = My.Settings.Playlist3_User_Imput_Name
                frmMain.Playlist3ToolStripMenuItem.Text = My.Settings.Playlist3_User_Imput_Name
                My.Settings.Save()
            End If
            If RadioButton4.Checked = True Then
                Dim w As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist4Contents.txt")
                Dim i As Integer
                For i = 0 To ListBox2.Items.Count - 1
                    w.WriteLine(ListBox2.Items.Item(i))
                Next
                w.Close()

                Dim a As New StreamWriter("C:\ProgramData\Simple Player\Playlists\Playlist4SafeFileNames.txt")
                Dim b As Integer
                For b = 0 To ListBox1.Items.Count - 1
                    a.WriteLine(ListBox1.Items.Item(b))
                Next
                a.Close()

                MsgBox("Сохранено")
                My.Settings.Playlist4_User_Imput_Name = TextBox1.Text
                RadioButton4.Text = My.Settings.Playlist4_User_Imput_Name
                frmMain.Playlist4ToolStripMenuItem.Text = My.Settings.Playlist4_User_Imput_Name
                My.Settings.Save()
            End If
            If _
                RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And
                RadioButton4.Checked = False Then
                MsgBox("Выберите и отредактируйте плейлист, прежде чем сохранять")
            End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Search.Click
        FindMyString(TextBox3.Text)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles MenuStrip1.ItemClicked
    End Sub
End Class