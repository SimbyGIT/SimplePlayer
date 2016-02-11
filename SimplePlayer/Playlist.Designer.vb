<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Playlist
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Playlist_addfolder_but = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Плейлист"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(20, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(357, 290)
        Me.ListBox1.TabIndex = 1
        '
        'AddButton
        '
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.ForeColor = System.Drawing.Color.Blue
        Me.AddButton.Location = New System.Drawing.Point(20, 353)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(102, 23)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Добавить файл"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Playlist_addfolder_but
        '
        Me.Playlist_addfolder_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Playlist_addfolder_but.ForeColor = System.Drawing.Color.Blue
        Me.Playlist_addfolder_but.Location = New System.Drawing.Point(137, 353)
        Me.Playlist_addfolder_but.Name = "Playlist_addfolder_but"
        Me.Playlist_addfolder_but.Size = New System.Drawing.Size(102, 23)
        Me.Playlist_addfolder_but.TabIndex = 3
        Me.Playlist_addfolder_but.Text = "Добавить папку"
        Me.Playlist_addfolder_but.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 388)
        Me.Controls.Add(Me.Playlist_addfolder_but)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.Name = "Playlist"
        Me.Text = "Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents Playlist_addfolder_but As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
