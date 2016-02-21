<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImportDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportASongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Playlist1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Playlist2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Playlist3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Playlist4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateSaveAPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteSelectedItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioPlayerX10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        CType(Me.AxWindowsMediaPlayer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuStrip1.SuspendLayout
        Me.GroupBox5.SuspendLayout
        CType(Me.VisualStyler1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(436, 730)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.MenuStrip1)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(428, 704)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Music Player"
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"),System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(300, 335)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(36, 24)
        Me.Button9.TabIndex = 17
        Me.Button9.UseVisualStyleBackColor = true
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(6, 330)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Repeat Playlist"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"),System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(342, 324)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 35)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = true
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = true
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(446, 174)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"),System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(15, 12)
        Me.AxWindowsMediaPlayer1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(83, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "----"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Now Playing:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Main Controls"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "00:00"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"),System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(92, 70)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 42)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"),System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(178, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 42)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"),System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(264, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 42)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"),System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(350, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 42)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"),System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(5, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = true
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(2, 19)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(428, 45)
        Me.TrackBar1.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportDeleteToolStripMenuItem, Me.PlayerOptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImportDeleteToolStripMenuItem
        '
        Me.ImportDeleteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ImportDeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportASongToolStripMenuItem, Me.ToolStripSeparator9, Me.OpenPlaylistToolStripMenuItem, Me.ToolStripSeparator1, Me.CreateSaveAPlaylistToolStripMenuItem, Me.ToolStripSeparator23, Me.DeleteSelectedItemToolStripMenuItem, Me.DeleteAllToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ImportDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ImportDeleteToolStripMenuItem.Image = CType(resources.GetObject("ImportDeleteToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ImportDeleteToolStripMenuItem.Name = "ImportDeleteToolStripMenuItem"
        Me.ImportDeleteToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.ImportDeleteToolStripMenuItem.Text = "File (Open/Playlists)"
        '
        'ImportASongToolStripMenuItem
        '
        Me.ImportASongToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ImportASongToolStripMenuItem.Image = CType(resources.GetObject("ImportASongToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ImportASongToolStripMenuItem.Name = "ImportASongToolStripMenuItem"
        Me.ImportASongToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ImportASongToolStripMenuItem.Text = "Import Songs"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(178, 6)
        '
        'OpenPlaylistToolStripMenuItem
        '
        Me.OpenPlaylistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Playlist1ToolStripMenuItem, Me.Playlist2ToolStripMenuItem, Me.Playlist3ToolStripMenuItem, Me.Playlist4ToolStripMenuItem})
        Me.OpenPlaylistToolStripMenuItem.Image = CType(resources.GetObject("OpenPlaylistToolStripMenuItem.Image"),System.Drawing.Image)
        Me.OpenPlaylistToolStripMenuItem.Name = "OpenPlaylistToolStripMenuItem"
        Me.OpenPlaylistToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OpenPlaylistToolStripMenuItem.Text = "Open  A Playlist"
        '
        'Playlist1ToolStripMenuItem
        '
        Me.Playlist1ToolStripMenuItem.Image = CType(resources.GetObject("Playlist1ToolStripMenuItem.Image"),System.Drawing.Image)
        Me.Playlist1ToolStripMenuItem.Name = "Playlist1ToolStripMenuItem"
        Me.Playlist1ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.Playlist1ToolStripMenuItem.Text = "Playlist 1"
        '
        'Playlist2ToolStripMenuItem
        '
        Me.Playlist2ToolStripMenuItem.Image = CType(resources.GetObject("Playlist2ToolStripMenuItem.Image"),System.Drawing.Image)
        Me.Playlist2ToolStripMenuItem.Name = "Playlist2ToolStripMenuItem"
        Me.Playlist2ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.Playlist2ToolStripMenuItem.Text = "Playlist 2"
        '
        'Playlist3ToolStripMenuItem
        '
        Me.Playlist3ToolStripMenuItem.Image = CType(resources.GetObject("Playlist3ToolStripMenuItem.Image"),System.Drawing.Image)
        Me.Playlist3ToolStripMenuItem.Name = "Playlist3ToolStripMenuItem"
        Me.Playlist3ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.Playlist3ToolStripMenuItem.Text = "Playlist 3"
        '
        'Playlist4ToolStripMenuItem
        '
        Me.Playlist4ToolStripMenuItem.Image = CType(resources.GetObject("Playlist4ToolStripMenuItem.Image"),System.Drawing.Image)
        Me.Playlist4ToolStripMenuItem.Name = "Playlist4ToolStripMenuItem"
        Me.Playlist4ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.Playlist4ToolStripMenuItem.Text = "Playlist 4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Silver
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'CreateSaveAPlaylistToolStripMenuItem
        '
        Me.CreateSaveAPlaylistToolStripMenuItem.Image = CType(resources.GetObject("CreateSaveAPlaylistToolStripMenuItem.Image"),System.Drawing.Image)
        Me.CreateSaveAPlaylistToolStripMenuItem.Name = "CreateSaveAPlaylistToolStripMenuItem"
        Me.CreateSaveAPlaylistToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CreateSaveAPlaylistToolStripMenuItem.Text = "Create  A Playlist"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(178, 6)
        '
        'DeleteSelectedItemToolStripMenuItem
        '
        Me.DeleteSelectedItemToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteSelectedItemToolStripMenuItem.Image = CType(resources.GetObject("DeleteSelectedItemToolStripMenuItem.Image"),System.Drawing.Image)
        Me.DeleteSelectedItemToolStripMenuItem.Name = "DeleteSelectedItemToolStripMenuItem"
        Me.DeleteSelectedItemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DeleteSelectedItemToolStripMenuItem.Text = "Delete Selected Item"
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteAllToolStripMenuItem.Image = CType(resources.GetObject("DeleteAllToolStripMenuItem.Image"),System.Drawing.Image)
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DeleteAllToolStripMenuItem.Text = "Delete Playlist"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PlayerOptionsToolStripMenuItem
        '
        Me.PlayerOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RadioPlayerX10ToolStripMenuItem})
        Me.PlayerOptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PlayerOptionsToolStripMenuItem.Image = CType(resources.GetObject("PlayerOptionsToolStripMenuItem.Image"),System.Drawing.Image)
        Me.PlayerOptionsToolStripMenuItem.Name = "PlayerOptionsToolStripMenuItem"
        Me.PlayerOptionsToolStripMenuItem.Size = New System.Drawing.Size(160, 20)
        Me.PlayerOptionsToolStripMenuItem.Text = "Extra Options / Features"
        '
        'RadioPlayerX10ToolStripMenuItem
        '
        Me.RadioPlayerX10ToolStripMenuItem.Image = CType(resources.GetObject("RadioPlayerX10ToolStripMenuItem.Image"),System.Drawing.Image)
        Me.RadioPlayerX10ToolStripMenuItem.Name = "RadioPlayerX10ToolStripMenuItem"
        Me.RadioPlayerX10ToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RadioPlayerX10ToolStripMenuItem.Text = "SimpleOnlineRadio"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator17, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator19})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"),System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.HelpToolStripMenuItem.Text = "Settings/About"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(113, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"),System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(113, 6)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Controls.Add(Me.ListBox3)
        Me.GroupBox5.Controls.Add(Me.ListBox4)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(11, 157)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(412, 167)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = false
        Me.GroupBox5.Text = "Recently Played Songs:"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(3, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(406, 145)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = true
        Me.ListBox3.Location = New System.Drawing.Point(154, 28)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 1
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.Color.Black
        Me.ListBox4.ForeColor = System.Drawing.Color.White
        Me.ListBox4.FormattingEnabled = true
        Me.ListBox4.Location = New System.Drawing.Point(32, 31)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(268, 108)
        Me.ListBox4.TabIndex = 0
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"),System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Media Player X10"
        Me.NotifyIcon1.Visible = true
        '
        'VisualStyler1
        '
        Me.VisualStyler1.HookVisualStyles = true
        Me.VisualStyler1.HostForm = Me
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"),SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.ShadowStyle = SkinSoft.VisualStyler.ShadowStyle.Bold
        Me.VisualStyler1.ToolStripStyle = SkinSoft.VisualStyler.ToolStripRenderStyle.OfficeAuto
        Me.VisualStyler1.LoadVisualStyle(Nothing, "OSX (iTunes).vssf")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(444, 424)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(464, 467)
        Me.MinimumSize = New System.Drawing.Size(464, 467)
        Me.Name = "frmMain"
        Me.Text = "Simple Player"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        CType(Me.AxWindowsMediaPlayer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.GroupBox5.ResumeLayout(false)
        CType(Me.VisualStyler1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlayerOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents RadioPlayerX10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ImportDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenPlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Playlist1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Playlist2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Playlist3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Playlist4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImportASongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateSaveAPlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteSelectedItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
End Class
