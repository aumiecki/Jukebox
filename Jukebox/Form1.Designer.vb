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
        Me.GroupBoxLeft = New System.Windows.Forms.GroupBox()
        Me.lblPlaylist = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBoxTop = New System.Windows.Forms.GroupBox()
        Me.AxWindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupBoxBottom = New System.Windows.Forms.GroupBox()
        Me.tbrVolume = New System.Windows.Forms.TrackBar()
        Me.btnFastForward = New System.Windows.Forms.Button()
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TimerPlay = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TrackBarPlay = New System.Windows.Forms.TrackBar()
        Me.GroupBoxLeft.SuspendLayout()
        Me.GroupBoxTop.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBottom.SuspendLayout()
        CType(Me.tbrVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBarPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLeft
        '
        Me.GroupBoxLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLeft.AutoSize = True
        Me.GroupBoxLeft.Controls.Add(Me.lblPlaylist)
        Me.GroupBoxLeft.Controls.Add(Me.ListBox1)
        Me.GroupBoxLeft.Location = New System.Drawing.Point(12, 28)
        Me.GroupBoxLeft.Name = "GroupBoxLeft"
        Me.GroupBoxLeft.Size = New System.Drawing.Size(398, 397)
        Me.GroupBoxLeft.TabIndex = 0
        Me.GroupBoxLeft.TabStop = False
        '
        'lblPlaylist
        '
        Me.lblPlaylist.AutoSize = True
        Me.lblPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylist.Location = New System.Drawing.Point(177, 10)
        Me.lblPlaylist.Name = "lblPlaylist"
        Me.lblPlaylist.Size = New System.Drawing.Size(65, 20)
        Me.lblPlaylist.TabIndex = 3
        Me.lblPlaylist.Text = "Playlist"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(383, 342)
        Me.ListBox1.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(273, 45)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(110, 42)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export Playlist"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(213, 16)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(123, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(66, 16)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(123, 23)
        Me.btnPrev.TabIndex = 4
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(136, 45)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 42)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete from Playlist"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(15, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 42)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add to Playlist"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBoxTop
        '
        Me.GroupBoxTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxTop.Controls.Add(Me.AxWindowsMediaPlayer)
        Me.GroupBoxTop.Location = New System.Drawing.Point(421, 28)
        Me.GroupBoxTop.Name = "GroupBoxTop"
        Me.GroupBoxTop.Size = New System.Drawing.Size(595, 397)
        Me.GroupBoxTop.TabIndex = 1
        Me.GroupBoxTop.TabStop = False
        '
        'AxWindowsMediaPlayer
        '
        Me.AxWindowsMediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer.Enabled = True
        Me.AxWindowsMediaPlayer.Location = New System.Drawing.Point(6, 14)
        Me.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer"
        Me.AxWindowsMediaPlayer.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer.Size = New System.Drawing.Size(583, 377)
        Me.AxWindowsMediaPlayer.TabIndex = 0
        '
        'GroupBoxBottom
        '
        Me.GroupBoxBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxBottom.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBoxBottom.Controls.Add(Me.tbrVolume)
        Me.GroupBoxBottom.Controls.Add(Me.btnFastForward)
        Me.GroupBoxBottom.Controls.Add(Me.btnRewind)
        Me.GroupBoxBottom.Controls.Add(Me.btnStop)
        Me.GroupBoxBottom.Controls.Add(Me.btnPause)
        Me.GroupBoxBottom.Controls.Add(Me.btnPlay)
        Me.GroupBoxBottom.Location = New System.Drawing.Point(421, 470)
        Me.GroupBoxBottom.Name = "GroupBoxBottom"
        Me.GroupBoxBottom.Size = New System.Drawing.Size(595, 61)
        Me.GroupBoxBottom.TabIndex = 3
        Me.GroupBoxBottom.TabStop = False
        '
        'tbrVolume
        '
        Me.tbrVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tbrVolume.Location = New System.Drawing.Point(476, 14)
        Me.tbrVolume.Maximum = 100
        Me.tbrVolume.Name = "tbrVolume"
        Me.tbrVolume.Size = New System.Drawing.Size(113, 45)
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
        Me.btnFastForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastForward.Location = New System.Drawing.Point(385, 14)
        Me.btnFastForward.Name = "btnFastForward"
        Me.btnFastForward.Size = New System.Drawing.Size(85, 34)
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
        Me.btnRewind.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRewind.Location = New System.Drawing.Point(296, 14)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(83, 35)
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
        Me.btnStop.Location = New System.Drawing.Point(206, 14)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(84, 35)
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
        Me.btnPause.Location = New System.Drawing.Point(118, 14)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(82, 35)
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
        Me.btnPlay.Location = New System.Drawing.Point(26, 15)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(86, 35)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOpen, Me.tsmManual})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(127, 25)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "File"
        '
        'tsmOpen
        '
        Me.tsmOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsmOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmOpen.ForeColor = System.Drawing.Color.Black
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.Size = New System.Drawing.Size(53, 21)
        Me.tsmOpen.Text = "Open"
        '
        'tsmManual
        '
        Me.tsmManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsmManual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmManual.ForeColor = System.Drawing.Color.Black
        Me.tsmManual.Name = "tsmManual"
        Me.tsmManual.Size = New System.Drawing.Size(66, 21)
        Me.tsmManual.Text = "Manual"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "MP3 Files (*.mp3)|*.mp3|Wave Files (*.wav)|*.wav|MP4 Files (*.mp4)|*.mp4|Video Fi" &
    "les(*.wmv)|*.wmv"
        Me.OpenFileDialog1.InitialDirectory = "D:\Documents\Source\Repository\Jukebox\Jukebox\WAVfiles"
        Me.OpenFileDialog1.Title = "Choose Media Files"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnPrev)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 431)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'TrackBarPlay
        '
        Me.TrackBarPlay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBarPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TrackBarPlay.Location = New System.Drawing.Point(421, 431)
        Me.TrackBarPlay.Name = "TrackBarPlay"
        Me.TrackBarPlay.Size = New System.Drawing.Size(595, 45)
        Me.TrackBarPlay.TabIndex = 7
        Me.TrackBarPlay.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1054, 546)
        Me.Controls.Add(Me.TrackBarPlay)
        Me.Controls.Add(Me.GroupBoxTop)
        Me.Controls.Add(Me.GroupBoxBottom)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxLeft)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Adam's Jukebox"
        Me.GroupBoxLeft.ResumeLayout(False)
        Me.GroupBoxLeft.PerformLayout()
        Me.GroupBoxTop.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBottom.ResumeLayout(False)
        Me.GroupBoxBottom.PerformLayout()
        CType(Me.tbrVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TrackBarPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxLeft As GroupBox
    Friend WithEvents GroupBoxTop As GroupBox
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
    Friend WithEvents TimerPlay As Timer
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblPlaylist As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents tsmManual As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TrackBarPlay As TrackBar
End Class
