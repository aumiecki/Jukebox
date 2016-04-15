Public Class Form1

    ''' <summary>
    ''' Play Button
    ''' </summary>
    ''' <param name="sender">Play Button</param>
    ''' <param name="e">Play Button</param>
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer.URL = ListBox1.SelectedItem
        AxWindowsMediaPlayer.Ctlcontrols.play()
    End Sub

    ''' <summary>
    ''' Pause Button
    ''' </summary>
    ''' <param name="sender">Pause Button</param>
    ''' <param name="e">Pause Button</param>
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer.Ctlcontrols.pause()
    End Sub

    ''' <summary>
    ''' Stop Button
    ''' </summary>
    ''' <param name="sender">Stop Button</param>
    ''' <param name="e">Stop Button</param>
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        TimerPlay.Stop()
        TrackBarPlay.Value = "0"
        AxWindowsMediaPlayer.Ctlcontrols.stop()
    End Sub

    ''' <summary>
    ''' Rewind Button
    ''' </summary>
    ''' <param name="sender">Rewind Button</param>
    ''' <param name="e">Rewind Button</param>
    Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
        AxWindowsMediaPlayer.Ctlcontrols.fastReverse()
    End Sub

    ''' <summary>
    ''' Fast Forward Button
    ''' </summary>
    ''' <param name="sender">Fast Forward Button</param>
    ''' <param name="e">Fast Forward Button</param>
    Private Sub btnFastForward_Click(sender As Object, e As EventArgs) Handles btnFastForward.Click
        AxWindowsMediaPlayer.Ctlcontrols.fastForward()
    End Sub

    ''' <summary>
    ''' Open dialog to select files from computer
    ''' </summary>
    ''' <param name="sender">Open dialog to select files from computer</param>
    ''' <param name="e">Open dialog to select files from computer</param>
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'AxWindowsMediaPlayer.URL = OpenFileDialog1.FileName
    End Sub

    ''' <summary>
    ''' Volume Track Bar
    ''' </summary>
    ''' <param name="sender">Volume Track Bar</param>
    ''' <param name="e">Volume Track Bar</param>
    Private Sub tbrVolume_Scroll(sender As Object, e As EventArgs) Handles tbrVolume.Scroll
        AxWindowsMediaPlayer.settings.volume = tbrVolume.Value
    End Sub

    ''' <summary>
    ''' Open Tool Strip Menu button to open the window dialog and load selected files in to Playlist
    ''' </summary>
    ''' <param name="sender">Open Tool Strip Menu button</param>
    ''' <param name="e">Open Tool Strip Menu button</param>
    Private Sub tsmOpen_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "Select files for this Playlist"
        OpenFileDialog1.Filter = "Wave Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3|MP4 Files (*.mp4)|*.mp4|Video Files(*.wmv)|*.wmv|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For Each song As String In OpenFileDialog1.FileNames
                ListBox1.Items.Add(song)
            Next
        End If
        Timer1.Start()
    End Sub

    ''' <summary>
    ''' Add to Playlist button to open the window dialog and load selected files in to Playlist
    ''' </summary>
    ''' <param name="sender">Add to Playlist button</param>
    ''' <param name="e">Add to Playlist button</param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "Select files for this Playlist"
        OpenFileDialog1.Filter = "Wave Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3|MP4 Files (*.mp4)|*.mp4|Video Files(*.wmv)|*.wmv|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For Each song As String In OpenFileDialog1.FileNames
                ListBox1.Items.Add(song)
            Next
        End If
        Timer1.Start()
    End Sub

    ''' <summary>
    ''' Delete from Playlist button
    ''' </summary>
    ''' <param name="sender"Delete from Playlist button></param>
    ''' <param name="e">Delete from Playlist button</param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox1.SelectedIndex = "0"
            ListBox1.ClearSelected()
        Catch ex As Exception
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox1.SelectedIndex = "-1"
            ListBox1.ClearSelected()
        End Try
    End Sub

    ''' <summary>
    ''' Playlist Indext Changer
    ''' </summary>
    ''' <param name="sender">Playlist Indext Changer</param>
    ''' <param name="e">Playlist Indext Changer</param>
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TimerPlay.Start()
        AxWindowsMediaPlayer.URL = ListBox1.SelectedItem
        Timer1.Start()
    End Sub

    ''' <summary>
    ''' Previous Song Button
    ''' </summary>
    ''' <param name="sender">Previous Song Button</param>
    ''' <param name="e">Previous Song Button</param>
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count + 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            AxWindowsMediaPlayer.Ctlcontrols.play()
        End If
    End Sub

    ''' <summary>
    ''' Next Song Button
    ''' </summary>
    ''' <param name="sender">Next Song Button</param>
    ''' <param name="e">Next Song Button</param>
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            AxWindowsMediaPlayer.Ctlcontrols.play()
        End If
    End Sub

    ''' <summary>
    ''' Export Playlist to a text file
    ''' </summary>
    ''' <param name="sender">Export Playlist to a text file</param>
    ''' <param name="e">Export Playlist to a text file</param>
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim count As Integer = -1
        Dim writer As New IO.StreamWriter(Application.StartupPath & "\playlist.txt")
        Dim current As Integer = ListBox1.SelectedIndex
        Try
            Do Until count = ListBox1.Items.Count
                ListBox1.SelectedIndex = count + 1
                writer.WriteLine(ListBox1.SelectedItem)
                count = count + 1
            Loop
        Catch ex As Exception
            writer.Close()
            ListBox1.ClearSelected()
        End Try
    End Sub

    ''' <summary>
    ''' Display User Manual Window
    ''' </summary>
    ''' <param name="sender">Display User Manual Window</param>
    ''' <param name="e">Display User Manual Window</param>
    Private Sub tsmUserManual_Click(sender As Object, e As EventArgs) Handles tsmManual.Click
        Manual.Show()
    End Sub

    ''' <summary>
    ''' Track Bar for Media Player
    ''' </summary>
    ''' <param name="sender">Track Bar for Media Player</param>
    ''' <param name="e">Track Bar for Media Player</param>
    Private Sub TrackBarPlay_Scroll(sender As Object, e As EventArgs) Handles TrackBarPlay.Scroll
        AxWindowsMediaPlayer.Ctlcontrols.currentPosition = TrackBarPlay.Value
    End Sub

    ''' <summary>
    ''' Track Bar for Media Player - Mouse Down
    ''' </summary>
    ''' <param name="sender">Track Bar for Media Player - Mouse Down</param>
    ''' <param name="e">Track Bar for Media Player - Mouse Down</param>
    Private Sub TrackBarPlay_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBarPlay.MouseDown
        AxWindowsMediaPlayer.Ctlcontrols.currentPosition = TrackBarPlay.Value
    End Sub

    ''' <summary>
    ''' Timer for the Track Bar
    ''' </summary>
    ''' <param name="sender">Timer for the Track Bar</param>
    ''' <param name="e">Timer for the Track Bar</param>
    Private Sub TimerPlay_Tick(sender As Object, e As EventArgs) Handles TimerPlay.Tick
        TrackBarPlay.Maximum = AxWindowsMediaPlayer.currentMedia.duration
        TrackBarPlay.Value = AxWindowsMediaPlayer.Ctlcontrols.currentPosition
    End Sub

    ''' <summary>
    ''' Timer for the Playlist
    ''' </summary>
    ''' <param name="sender">Timer for the Playlist</param>
    ''' <param name="e">Timer for the Playlist</param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim itemNo As Integer

            itemNo = ListBox1.SelectedIndex

            If Me.AxWindowsMediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
                Me.ListBox1.SelectedIndex = itemNo + 1
                AxWindowsMediaPlayer.URL = ListBox1.SelectedItem
                Timer1.Start()
            Else
                Timer1.Start()
            End If
        Catch ex As Exception
            Timer1.Stop()
        End Try
    End Sub

    ''' <summary>
    ''' Display Report Window
    ''' </summary>
    ''' <param name="sender">Display Report Window</param>
    ''' <param name="e">Display Report Window</param>
    Private Sub tsmReport_Click(sender As Object, e As EventArgs) Handles tsmReport.Click
        Report.txtReport.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\playlist.txt")
        Report.Show()
    End Sub
End Class
