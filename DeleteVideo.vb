Public Class DeleteVideo
    Dim videoRepo As VideoRepository = New VideoRepository()
    Dim videoId As Long

    ''' <summary>
    ''' Load Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_DV_ChooseVideo.Enabled = True
        TB_DV_Title.Enabled = False
        TB_DV_Year.Enabled = False
        TB_DV_Country.Enabled = False
        TB_DV_Language.Enabled = False
        TB_DV_Length.Enabled = False
        TB_DV_Genre.Enabled = False
        TB_DV_Actor.Enabled = False
        TB_DV_Director.Enabled = False
        TB_DV_Resume.Enabled = False
        BTN_DV_Delete.Enabled = False
    End Sub

    ''' <summary>
    ''' Event for search click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DV_Search_Click(sender As Object, e As EventArgs) Handles BTN_DV_Search.Click
        If (TB_DV_ChooseVideo.Text.Trim() = "") Then
            MsgBox("Please enter video number")
            Return
        End If

        videoId = TB_DV_ChooseVideo.Text
        Dim videoResult As Video = videoRepo.GetVideoById(videoId)
        If (videoResult Is Nothing) Then
            MsgBox("Video not found")
        Else
            TB_DV_Title.Text = videoResult.Title
            TB_DV_Year.Text = videoResult.Year
            TB_DV_Country.Text = videoResult.Country
            TB_DV_Language.Text = videoResult.Language
            TB_DV_Length.Text = videoResult.Language
            TB_DV_Genre.Text = videoResult.Genre
            TB_DV_Actor.Text = videoResult.Actors
            TB_DV_Director.Text = videoResult.Director
            TB_DV_Resume.Text = videoResult.Resume
            Try
                PB_EV_Picture.BackgroundImage = Util.GetImageFromUrl(videoResult.Photo)
                PB_EV_Picture.BackgroundImageLayout = ImageLayout.Stretch
                TB_NV_ImgUrl.Text = videoResult.Photo
            Catch ex As Exception
                PB_EV_Picture.BackgroundImage = Nothing
                TB_NV_ImgUrl.Text = ""

            End Try
            BTN_DV_Delete.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Event for delete click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DV_Delete_Click(sender As Object, e As EventArgs) Handles BTN_DV_Delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this video", "Warning!", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Return
        ElseIf result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            Dim videoResult As Video = videoRepo.GetVideoById(videoId)

            videoRepo.deleteByVideoId(videoId)
            MsgBox("Video sucessfully deleted")
            Dashboard.Show()
            Me.Close()


        End If

    End Sub

    ''' <summary>
    ''' event for cancel click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DV_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_DV_Cancel.Click
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