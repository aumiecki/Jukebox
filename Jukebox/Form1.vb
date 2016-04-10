Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
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
        OpenFileDialog1.ShowDialog()
    End Sub
End Class
