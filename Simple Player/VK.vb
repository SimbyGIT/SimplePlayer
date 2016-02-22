Imports System.Net
Imports System.Xml
Imports System.IO
Imports System.ComponentModel

Public Class VK
    Public isRemote As Boolean
    Public music(0) As String
    Function method(name As String, param As String) As String
        Dim m_url, ext As String
        If param = "" Then
            m_url = "https://api.vkontakte.ru/method/" _
            & name & ".xml?access_token=" & Equa.token
        Else
            m_url = "https://api.vkontakte.ru/method/" _
            & name & ".xml?" & param _
            & "&access_token=" & Equa.token
        End If
        Dim client As New WebClient()
        Dim data As Stream = client.OpenRead(m_url)
        Dim reader As New StreamReader(data)
        ext = reader.ReadToEnd()
        data.Close()
        reader.Close()
        Return ext
    End Function

  

  

    Private Sub VK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xml As New XmlDocument 'сюда мы будем грузить полученный XML
        Dim node As System.Xml.XmlNode 'сюда мы будем грузить часть общего XML с отдельной песней
        xml.LoadXml(method("audio.get", "")) 'выполняем сам запрос
        Dim i As Integer
        While xml.DocumentElement.HasChildNodes 'пока остаются песни в дереве
            node = xml.DocumentElement.FirstChild 'копируем ветку с одной песней
            ListBox1.Items.Add(node.Item("artist").InnerXml & " | " & node.Item("title").InnerXml) 'добавляем элемент в listbox
            i = i + 1
            ReDim Preserve music(music.Length)
            music(music.Length - 1) = node.Item("url").InnerXml 'добавляем урл в массив
            xml.DocumentElement.RemoveChild(node) 'и удаляем уже ненужную ветку из основного дерева
        End While
        frmMain.АвторизацияToolStripMenuItem.Enabled = False
        frmMain.МоиАудиозаписиToolStripMenuItem.Enabled = True

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

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

                frmMain.AxWindowsMediaPlayer1.URL = music(ListBox1.SelectedIndex + 1)
        frmMain.AxWindowsMediaPlayer1.Ctlcontrols.play()
        isRemote = True

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FindMyString(TextBox1.Text)
    End Sub

    Private Sub VK_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub



End Class