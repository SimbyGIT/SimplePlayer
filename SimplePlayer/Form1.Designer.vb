<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Play_but = New System.Windows.Forms.PictureBox()
        Me.Stop_but = New System.Windows.Forms.PictureBox()
        Me.Next_but = New System.Windows.Forms.PictureBox()
        Me.Foward_but = New System.Windows.Forms.PictureBox()
        Me.VolumeTrackBar = New System.Windows.Forms.TrackBar()
        Me.PlaylistShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Play_but, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stop_but, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Next_but, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foward_but, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        resources.ApplyResources(Me.Player, "Player")
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'Play_but
        '
        Me.Play_but.Image = Global.SimplePlayer.My.Resources.Resources.player_play__1_
        resources.ApplyResources(Me.Play_but, "Play_but")
        Me.Play_but.Name = "Play_but"
        Me.Play_but.TabStop = False
        '
        'Stop_but
        '
        Me.Stop_but.Image = Global.SimplePlayer.My.Resources.Resources.player_stop
        resources.ApplyResources(Me.Stop_but, "Stop_but")
        Me.Stop_but.Name = "Stop_but"
        Me.Stop_but.TabStop = False
        '
        'Next_but
        '
        Me.Next_but.Image = Global.SimplePlayer.My.Resources.Resources.player_fwd
        resources.ApplyResources(Me.Next_but, "Next_but")
        Me.Next_but.Name = "Next_but"
        Me.Next_but.TabStop = False
        '
        'Foward_but
        '
        Me.Foward_but.Image = Global.SimplePlayer.My.Resources.Resources.player_rew
        resources.ApplyResources(Me.Foward_but, "Foward_but")
        Me.Foward_but.Name = "Foward_but"
        Me.Foward_but.TabStop = False
        '
        'VolumeTrackBar
        '
        Me.VolumeTrackBar.BackColor = System.Drawing.Color.LightCyan
        resources.ApplyResources(Me.VolumeTrackBar, "VolumeTrackBar")
        Me.VolumeTrackBar.Maximum = 100
        Me.VolumeTrackBar.Name = "VolumeTrackBar"
        Me.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.VolumeTrackBar.Value = 50
        '
        'PlaylistShow
        '
        resources.ApplyResources(Me.PlaylistShow, "PlaylistShow")
        Me.PlaylistShow.Name = "PlaylistShow"
        Me.PlaylistShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlaylistShow)
        Me.Controls.Add(Me.VolumeTrackBar)
        Me.Controls.Add(Me.Foward_but)
        Me.Controls.Add(Me.Next_but)
        Me.Controls.Add(Me.Stop_but)
        Me.Controls.Add(Me.Play_but)
        Me.Controls.Add(Me.Player)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Play_but, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stop_but, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Next_but, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foward_but, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Play_but As PictureBox
    Friend WithEvents Stop_but As PictureBox
    Friend WithEvents Next_but As PictureBox
    Friend WithEvents Foward_but As PictureBox
    Friend WithEvents VolumeTrackBar As TrackBar
    Friend WithEvents PlaylistShow As Button
    Friend WithEvents Label1 As Label
End Class
