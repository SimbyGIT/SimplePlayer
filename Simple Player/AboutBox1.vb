﻿Imports System.IO

Public NotInheritable Class AboutBox1
    Private Sub AboutBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Opacity = My.Settings.Opacity
        ' Установить заголовок формы.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("О программе {0}", ApplicationTitle)
        ' Инициализировать текст, отображаемый в окне "О программе".
        ' TODO: настроить сведения о сборке приложения в области "Приложение" диалогового окна 
        '    свойств проекта (в меню "Проект").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Версия {0}", My.Application.Info.Version.ToString)
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescription.TextChanged
    End Sub

    Private Sub LabelCopyright_Click(sender As Object, e As EventArgs)
    End Sub
End Class
