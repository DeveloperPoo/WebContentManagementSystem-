Imports System.IO
Imports System.Net

Public Class ReturnVideo
    Dim videoRepo As New VideoRepository()
    Dim rentRepo As New RentRepository()
    Dim clientRepo As New ClientRepository()
    Dim videoNumber As Long

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReturnVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dashboard.Show()
    End Sub

    ''' <summary>
    ''' Search button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RV_B_VideoSearch_Click(sender As Object, e As EventArgs) Handles RV_B_VideoSearch.Click
        Dim videoId = Nothing
        If (Long.TryParse(ReV_TB_VideoId.Text.Trim(), videoId)) Then
            Dim video As Video = videoRepo.GetRentedVideoById(videoId)
            Dim rent As Rent = rentRepo.GetLatestRentsByVideoId(videoId)
            If (video Is Nothing Or rent Is Nothing) Then
                MsgBox("Video not found")
                Return
            Else
                Dim client = clientRepo.GetClientById(rent.ClientId)
                If (client Is Nothing) Then
                    MsgBox("Client details not found against rented video")
                    Return
                End If
                ReV_TB_ClientName.Text = client.Fname & " " & client.Lname
                ReV_TB_ClientNum.Text = client.ClientNumber
                ReV_TB_RentDate.Text = rent.RentDate.ToLongDateString
                ReV_B_Return.Enabled = True
                ReV_TB_VideoId.Enabled = False
                videoNumber = video.VideoId


                PictureBox1.BackgroundImage = Util.GetImageFromUrl(video.Photo)
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch


            End If
        Else
            MsgBox("Invalid value for Video ID")
            Return
        End If
    End Sub

    ''' <summary>
    ''' Return button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReV_B_Return_Click(sender As Object, e As EventArgs) Handles ReV_B_Return.Click
        videoRepo.ReturnVideo(videoNumber)
        MsgBox("Video Returned!")
        Me.Close()
        Dashboard.Show()
    End Sub

    ''' <summary>
    ''' Cancel button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReV_B_Cancel_Click(sender As Object, e As EventArgs) Handles ReV_B_Cancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Form close event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub
End Class