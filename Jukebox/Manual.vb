Public Class Manual
    ''' <summary>
    ''' User Manual Text
    ''' </summary>
    ''' <param name="sender">User Manual Text</param>
    ''' <param name="e">User Manual Text</param>
    Private Sub Manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtxtManual.Text = "User Manual for Adam's Jukebox" +
            Environment.NewLine + Environment.NewLine +
            "Adam's Jukebox lets you play media files from your computer." +
            Environment.NewLine + Environment.NewLine +
            "Top Menu:" +
            Environment.NewLine +
            "Open - Opens window dialog that allows user to load media files from computer to the Playlist." +
            Environment.NewLine +
            "Manual - Opens User Manual window." +
            Environment.NewLine +
            "Report - Opens Playlist report." +
            Environment.NewLine + Environment.NewLine +
            "Playlist Controls:" +
            Environment.NewLine +
            "Playlist - Click on song selection to play. Playlist will play all songs in the list continuously." +
            Environment.NewLine +
            "Add to Playlist - Opens window dialog that allows user to load media files from computer to the Playlist." +
            Environment.NewLine +
            "Delete from Playlist - Allows user to delete media files from the Playlist." +
            Environment.NewLine +
            "Export Playlist - Allows user to export current Playlist to the Report." +
            Environment.NewLine +
            "Previous - Plays previous media file in the Playlist." +
            Environment.NewLine +
            "Next - Plays next media file in the Playlist." +
            Environment.NewLine + Environment.NewLine +
            "Media Player Controls:" +
            Environment.NewLine +
            "Play - Plays media file in Media Player." +
            Environment.NewLine +
            "Pause - Pauses media file in Media Player." +
            Environment.NewLine +
            "Stop - Stops media file in Media Player." +
            Environment.NewLine +
            "Rewind ( < ) - Fast rewinds media file in Media Player." +
            Environment.NewLine +
            "Fast Forward ( > ) - Fast forward media file in Media Player." +
            Environment.NewLine +
            "Volume - Controls the volume of the Media Player." +
            Environment.NewLine +
            "Track Bar - Controls and displays the duration location of the media currently playing in the Media Player."

        'Formats the title bold
        With Me.rtxtManual
            .Select(0, 30)
            .SelectionFont = New Font(Me.rtxtManual.SelectionFont, FontStyle.Bold)
        End With
    End Sub
End Class