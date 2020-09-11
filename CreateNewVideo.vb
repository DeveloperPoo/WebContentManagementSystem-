Public Class CreateNewVideo
    Dim videoRepo As VideoRepository = New VideoRepository()
    Dim videoCheck As Boolean = False

    ''' <summary>
    ''' Event for sacve click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NV_Save_Click(sender As Object, e As EventArgs) Handles BTN_NV_Save.Click

        Dim year As String = TB_NV_Year.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("_", "")

        If (TB_NV_Title.Text = "") Then
            MsgBox("Title is mandatory")
            Return
        End If

        If (year = "") Then
            MsgBox("Year is mandatory")
            Return
        End If

        If (TB_NV_Country.Text = "") Then
            MsgBox("Country is mandatory")
            Return
        End If

        If (TB_NV_Language.Text = "") Then
            MsgBox("Language is mandatory")
            Return
        End If

        If (TB_NV_Length.Text = "") Then
            MsgBox("Length is mandatory")
            Return
        End If


        If (TB_NV_Genre.Text = "") Then
            MsgBox("Genre is mandatory")
            Return
        End If

        If (TB_NV_Actor.Text = "") Then
            MsgBox("Actor is mandatory")
            Return
        End If

        If (TB_NV_Director.Text = "") Then
            MsgBox("Director is mandatory")
            Return
        End If

        If (TB_NV_Resume.Text = "") Then
            MsgBox("Resume is mandatory")
            Return
        End If

        Dim video = New Video

        video.Title = TB_NV_Title.Text
        video.Year = TB_NV_Year.Text
        video.Country = TB_NV_Country.Text
        video.Language = TB_NV_Language.Text
        video.Length = TB_NV_Length.Text
        video.Genre = TB_NV_Genre.Text
        video.Actors = TB_NV_Actor.Text
        video.Director = TB_NV_Director.Text
        video.Resume = TB_NV_Resume.Text
        video.Photo = TB_NV_ImgUrl.Text.Trim()

        videoRepo.AddVideo(video)
        MsgBox("Video Sucessfully added")

        Dashboard.Show()
        Me.Close()


    End Sub

    ''' <summary>
    ''' event for cancel button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NV_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_NV_Cancel.Click

        Me.Close()
    End Sub

    ''' <summary>
    ''' Fetch Image MEthod for Image field onblur/onleave
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub fetchImage(sender As Object, e As EventArgs) Handles TB_NV_ImgUrl.Leave
        Try
            PB_NV_Picture.BackgroundImage = Util.GetImageFromUrl(sender.Text)
            PB_NV_Picture.BackgroundImageLayout = ImageLayout.Stretch
            videoCheck = True
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Event for close button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub


End Class