Public Class RentVideo
    Dim videoResult As Video
    Dim clientResult As Client

    Dim RentRepo As RentRepository = New RentRepository()
    Dim clientRepo As ClientRepository = New ClientRepository()
    Dim videoRepo As VideoRepository = New VideoRepository()
    Dim clientNumber As String
    Dim videoId As Long
    Dim rentId As Long
    Dim clientCheck As Boolean = False
    Dim videoCheck As Boolean = False

    ''' <summary>
    ''' Click Search button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RV_B_ClientSearch_Click(sender As Object, e As EventArgs) Handles RV_B_ClientSearch.Click

        clientNumber = RV_TB_ClientNum.Text
        clientResult = clientRepo.GetClientByClientNumber(clientNumber)

        If (clientResult Is Nothing) Then
            MsgBox("Client not found")
        Else
            RV_TB_ClientName.Text = clientResult.Fname
            RV_TB_Clientphone.Text = clientResult.Phone
            RV_TB_ClientAddress.Text = clientResult.Address
            'RV_TB_ClientNum.Enabled = False
            clientCheck = True
            If (videoCheck And clientCheck) Then
                RV_B_Rent.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Video search button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RV_B_VideoSearch_Click(sender As Object, e As EventArgs) Handles RV_B_VideoSearch.Click

        videoId = RV_TB_VideoId.Text
        videoResult = videoRepo.GetVideoById(videoId)

        If (videoResult Is Nothing) Then
            MsgBox("Video not found")
        Else
            RV_TB_VideoTitle.Text = videoResult.Title
            RV_TB_VideoLang.Text = videoResult.Language
            RV_TB_VideoDirector.Text = videoResult.Director
            RV_TB_VideoResume.Text = videoResult.Resume
            PictureBox1.BackgroundImage = Util.GetImageFromUrl(videoResult.Photo)
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            'RV_TB_VideoId.Enabled = False
            videoCheck = True
            If (videoCheck And clientCheck) Then
                RV_B_Rent.Enabled = True
            End If
        End If

    End Sub

    ''' <summary>
    ''' Rent button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RV_B_Rent_Click(sender As Object, e As EventArgs) Handles RV_B_Rent.Click

        Dim rent = New Rent()
        rent.ClientId = clientResult.ClientId
        rent.VideoId = videoResult.VideoId
        RentRepo.RentVideo(rent)
        videoRepo.RentVideo(videoId)

        MsgBox("Video Rented")
        Dashboard.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Cancel button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RV_B_Cancel_Click(sender As Object, e As EventArgs) Handles RV_B_Cancel.Click

        Me.Close()
    End Sub

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RentVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RV_TB_ClientName.Enabled = False
        RV_TB_Clientphone.Enabled = False
        RV_TB_ClientAddress.Enabled = False
        RV_TB_VideoTitle.Enabled = False
        RV_TB_VideoLang.Enabled = False
        RV_TB_VideoDirector.Enabled = False
        RV_TB_VideoResume.Enabled = False
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