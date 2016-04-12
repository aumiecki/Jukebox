Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer.URL = ListBox1.SelectedItem
        AxWindowsMediaPlayer.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
        AxWindowsMediaPlayer.Ctlcontrols.fastReverse()
    End Sub

    Private Sub btnFastForward_Click(sender As Object, e As EventArgs) Handles btnFastForward.Click
        AxWindowsMediaPlayer.Ctlcontrols.fastForward()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AxWindowsMediaPlayer.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub tbrVolume_Scroll(sender As Object, e As EventArgs) Handles tbrVolume.Scroll
        AxWindowsMediaPlayer.settings.volume = tbrVolume.Value
    End Sub

    Private Sub tsmOpen_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "Select files for this Playlist"
        OpenFileDialog1.Filter = "Wave Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3|MP4 Files (*.mp4)|*.mp4|Video Files(*.wmv)|*.wmv|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For Each song As String In OpenFileDialog1.FileNames
                ListBox1.Items.Add(song)
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "Select files for this Playlist"
        OpenFileDialog1.Filter = "Wave Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3|MP4 Files (*.mp4)|*.mp4|Video Files(*.wmv)|*.wmv|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For Each song As String In OpenFileDialog1.FileNames
                ListBox1.Items.Add(song)
            Next
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer.URL = ListBox1.SelectedItem
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count + 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            AxWindowsMediaPlayer.Ctlcontrols.play()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            AxWindowsMediaPlayer.Ctlcontrols.play()
        End If
    End Sub

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
            ListBox1.SelectedIndex = current
        End Try
    End Sub

    Private Sub tsmUserManual_Click(sender As Object, e As EventArgs) Handles tsmManual.Click
        Manual.Show()
    End Sub
End Class
