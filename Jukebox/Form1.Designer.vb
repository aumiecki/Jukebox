<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTop = New System.Windows.Forms.GroupBox()
        Me.AxWindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupBoxRight = New System.Windows.Forms.GroupBox()
        Me.GroupBoxBottom = New System.Windows.Forms.GroupBox()
        Me.tbrVolume = New System.Windows.Forms.TrackBar()
        Me.btnFastForward = New System.Windows.Forms.Button()
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxTop.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBottom.SuspendLayout()
        CType(Me.tbrVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Location = New System.Drawing.Point(38, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 466)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBoxTop
        '
        Me.GroupBoxTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxTop.Controls.Add(Me.AxWindowsMediaPlayer)
        Me.GroupBoxTop.Location = New System.Drawing.Point(255, 48)
        Me.GroupBoxTop.Name = "GroupBoxTop"
        Me.GroupBoxTop.Size = New System.Drawing.Size(543, 342)
        Me.GroupBoxTop.TabIndex = 1
        Me.GroupBoxTop.TabStop = False
        '
        'AxWindowsMediaPlayer
        '
        Me.AxWindowsMediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer.Enabled = True
        Me.AxWindowsMediaPlayer.Location = New System.Drawing.Point(6, 10)
        Me.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer"
        Me.AxWindowsMediaPlayer.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer.Size = New System.Drawing.Size(531, 326)
        Me.AxWindowsMediaPlayer.TabIndex = 0
        '
        'GroupBoxRight
        '
        Me.GroupBoxRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRight.Location = New System.Drawing.Point(816, 48)
        Me.GroupBoxRight.Name = "GroupBoxRight"
        Me.GroupBoxRight.Size = New System.Drawing.Size(200, 342)
        Me.GroupBoxRight.TabIndex = 2
        Me.GroupBoxRight.TabStop = False
        '
        'GroupBoxBottom
        '
        Me.GroupBoxBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxBottom.Controls.Add(Me.tbrVolume)
        Me.GroupBoxBottom.Controls.Add(Me.btnFastForward)
        Me.GroupBoxBottom.Controls.Add(Me.btnRewind)
        Me.GroupBoxBottom.Controls.Add(Me.btnStop)
        Me.GroupBoxBottom.Controls.Add(Me.btnPause)
        Me.GroupBoxBottom.Controls.Add(Me.btnPlay)
        Me.GroupBoxBottom.Location = New System.Drawing.Point(255, 397)
        Me.GroupBoxBottom.Name = "GroupBoxBottom"
        Me.GroupBoxBottom.Size = New System.Drawing.Size(761, 117)
        Me.GroupBoxBottom.TabIndex = 3
        Me.GroupBoxBottom.TabStop = False
        '
        'tbrVolume
        '
        Me.tbrVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tbrVolume.Location = New System.Drawing.Point(561, 36)
        Me.tbrVolume.Maximum = 100
        Me.tbrVolume.Name = "tbrVolume"
        Me.tbrVolume.Size = New System.Drawing.Size(183, 45)
        Me.tbrVolume.TabIndex = 5
        Me.tbrVolume.TickFrequency = 10
        Me.tbrVolume.Value = 50
        '
        'btnFastForward
        '
        Me.btnFastForward.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFastForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnFastForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFastForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFastForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastForward.Location = New System.Drawing.Point(452, 35)
        Me.btnFastForward.Name = "btnFastForward"
        Me.btnFastForward.Size = New System.Drawing.Size(103, 46)
        Me.btnFastForward.TabIndex = 4
        Me.btnFastForward.Text = ">"
        Me.btnFastForward.UseVisualStyleBackColor = True
        '
        'btnRewind
        '
        Me.btnRewind.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRewind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnRewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRewind.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRewind.Location = New System.Drawing.Point(343, 35)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(103, 46)
        Me.btnRewind.TabIndex = 3
        Me.btnRewind.Text = "<"
        Me.btnRewind.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(234, 35)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(103, 46)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(125, 35)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(103, 46)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(16, 35)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(103, 46)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOpen})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(61, 25)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "File"
        '
        'tsmOpen
        '
        Me.tsmOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmOpen.ForeColor = System.Drawing.Color.White
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.Size = New System.Drawing.Size(53, 21)
        Me.tsmOpen.Text = "Open"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "MP3 Files (*.mp3)|*.mp3|Wave Files (*.wav)|*.wav|MP4 Files (*.mp4)|*.mp4|Video Fi" &
    "les(*.wmv)|*..wmv"
        Me.OpenFileDialog1.InitialDirectory = "D:\Music"
        Me.OpenFileDialog1.Title = "Choose Media Files"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Jukebox.My.Resources.Resources.Jukebox_Backgroud_Image1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1054, 546)
        Me.Controls.Add(Me.GroupBoxBottom)
        Me.Controls.Add(Me.GroupBoxRight)
        Me.Controls.Add(Me.GroupBoxTop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Adam's Jukebox"
        Me.GroupBoxTop.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBottom.ResumeLayout(False)
        Me.GroupBoxBottom.PerformLayout()
        CType(Me.tbrVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBoxTop As GroupBox
    Friend WithEvents GroupBoxRight As GroupBox
    Friend WithEvents GroupBoxBottom As GroupBox
    Friend WithEvents AxWindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmOpen As ToolStripMenuItem
    Friend WithEvents btnFastForward As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnRewind As Button
    Friend WithEvents tbrVolume As TrackBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
End Class
