<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Playlists
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Playlists))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddSongsRemoveSongsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSongsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveSelectedSongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveAllSongsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Search = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        CType(Me.AxWindowsMediaPlayer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RadioButton1
        '
        resources.ApplyResources(Me.RadioButton1, "RadioButton1")
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = false
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'ListBox2
        '
        resources.ApplyResources(Me.ListBox2, "ListBox2")
        Me.ListBox2.ForeColor = System.Drawing.Color.Black
        Me.ListBox2.FormattingEnabled = true
        Me.ListBox2.Name = "ListBox2"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'RadioButton4
        '
        resources.ApplyResources(Me.RadioButton4, "RadioButton4")
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.TabStop = true
        Me.RadioButton4.UseVisualStyleBackColor = true
        '
        'RadioButton3
        '
        resources.ApplyResources(Me.RadioButton3, "RadioButton3")
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabStop = true
        Me.RadioButton3.UseVisualStyleBackColor = true
        '
        'RadioButton2
        '
        resources.ApplyResources(Me.RadioButton2, "RadioButton2")
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabStop = true
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Multiline = true
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.MenuStrip1)
        Me.TabPage1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.TabPage1.Name = "TabPage1"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = true
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = true
        '
        'ListBox1
        '
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Name = "ListBox1"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSongsRemoveSongsToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'AddSongsRemoveSongsToolStripMenuItem
        '
        resources.ApplyResources(Me.AddSongsRemoveSongsToolStripMenuItem, "AddSongsRemoveSongsToolStripMenuItem")
        Me.AddSongsRemoveSongsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSongsToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveSelectedSongToolStripMenuItem, Me.ToolStripSeparator2, Me.RemoveAllSongsToolStripMenuItem})
        Me.AddSongsRemoveSongsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AddSongsRemoveSongsToolStripMenuItem.Name = "AddSongsRemoveSongsToolStripMenuItem"
        '
        'AddSongsToolStripMenuItem
        '
        resources.ApplyResources(Me.AddSongsToolStripMenuItem, "AddSongsToolStripMenuItem")
        Me.AddSongsToolStripMenuItem.Name = "AddSongsToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'RemoveSelectedSongToolStripMenuItem
        '
        resources.ApplyResources(Me.RemoveSelectedSongToolStripMenuItem, "RemoveSelectedSongToolStripMenuItem")
        Me.RemoveSelectedSongToolStripMenuItem.Name = "RemoveSelectedSongToolStripMenuItem"
        '
        'ToolStripSeparator2
        '
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'RemoveAllSongsToolStripMenuItem
        '
        resources.ApplyResources(Me.RemoveAllSongsToolStripMenuItem, "RemoveAllSongsToolStripMenuItem")
        Me.RemoveAllSongsToolStripMenuItem.Name = "RemoveAllSongsToolStripMenuItem"
        '
        'OptionsToolStripMenuItem
        '
        resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.ToolStripSeparator3, Me.PreviousToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        '
        'PlayToolStripMenuItem
        '
        resources.ApplyResources(Me.PlayToolStripMenuItem, "PlayToolStripMenuItem")
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        '
        'PauseToolStripMenuItem
        '
        resources.ApplyResources(Me.PauseToolStripMenuItem, "PauseToolStripMenuItem")
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        '
        'StopToolStripMenuItem
        '
        resources.ApplyResources(Me.StopToolStripMenuItem, "StopToolStripMenuItem")
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        '
        'ToolStripSeparator3
        '
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        '
        'PreviousToolStripMenuItem
        '
        resources.ApplyResources(Me.PreviousToolStripMenuItem, "PreviousToolStripMenuItem")
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        '
        'NextToolStripMenuItem
        '
        resources.ApplyResources(Me.NextToolStripMenuItem, "NextToolStripMenuItem")
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        '
        'AxWindowsMediaPlayer1
        '
        resources.ApplyResources(Me.AxWindowsMediaPlayer1, "AxWindowsMediaPlayer1")
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"),System.Windows.Forms.AxHost.State)
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'Search
        '
        resources.ApplyResources(Me.Search, "Search")
        Me.Search.Name = "Search"
        Me.Search.UseVisualStyleBackColor = true
        '
        'TextBox3
        '
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        '
        'Edit_Playlists
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "Edit_Playlists"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.AxWindowsMediaPlayer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddSongsRemoveSongsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSongsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveSelectedSongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveAllSongsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Search As Button
    Friend WithEvents TextBox3 As TextBox
End Class
