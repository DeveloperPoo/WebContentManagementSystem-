Public Class EditVideo
    Dim videoRepo As VideoRepository = New VideoRepository()
    Dim videoId As Long
    Dim videoCheck As Boolean = False

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TB_EV_Title.Enabled = False
        TB_EV_Year.Enabled = False
        TB_EV_Country.Enabled = False
        TB_EV_Language.Enabled = False
        TB_EV_Length.Enabled = False
        TB_EV_Genre.Enabled = False
        TB_EV_Actor.Enabled = False
        TB_EV_Director.Enabled = False
        TB_EV_Resume.Enabled = False
        BTN_EV_Edit.Enabled = False
    End Sub

    ''' <summary>
    ''' Event for seach click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EV_search_Click(sender As Object, e As EventArgs) Handles BTN_EV_search.Click
        If (TB_EV_ChooseVideo.Text.Trim() = "") Then
            MsgBox("Please enter video number")
            Return
        End If
        TB_EV_Title.Enabled = True
        TB_EV_Year.Enabled = True
        TB_EV_Country.Enabled = True
        TB_EV_Language.Enabled = True
        TB_EV_Length.Enabled = True
        TB_EV_Genre.Enabled = True
        TB_EV_Actor.Enabled = True
        TB_EV_Director.Enabled = True
        TB_EV_Resume.Enabled = True
        BTN_EV_Edit.Enabled = True

        videoId = TB_EV_ChooseVideo.Text
        Dim videoResult As Video = videoRepo.GetVideoById(videoId)
        If (videoResult Is Nothing) Then
            MsgBox("Video not found")
            TB_EV_ChooseVideo.Enabled = True

            TB_EV_Title.Enabled = False
            TB_EV_Year.Enabled = False
            TB_EV_Country.Enabled = False
            TB_EV_Language.Enabled = False
            TB_EV_Length.Enabled = False
            TB_EV_Genre.Enabled = False
            TB_EV_Actor.Enabled = False
            TB_EV_Director.Enabled = False
            TB_EV_Resume.Enabled = False

        Else
            TB_EV_ChooseVideo.Enabled = False
            TB_EV_Title.Text = videoResult.Title
            TB_EV_Year.Text = videoResult.Year
            TB_EV_Country.Text = videoResult.Country
            TB_EV_Language.Text = videoResult.Language
            TB_EV_Length.Text = videoResult.Length
            TB_EV_Genre.Text = videoResult.Genre
            TB_EV_Actor.Text = videoResult.Actors
            TB_EV_Director.Text = videoResult.Director
            TB_EV_Resume.Text = videoResult.Resume
            Try
                PB_EV_Picture.BackgroundImage = Util.GetImageFromUrl(videoResult.Photo)
                PB_EV_Picture.BackgroundImageLayout = ImageLayout.Stretch
                TB_NV_ImgUrl.Text = videoResult.Photo
                videoCheck = True
            Catch ex As Exception
                PB_EV_Picture.BackgroundImage = Nothing
                TB_NV_ImgUrl.Text = ""

            End Try

        End If
    End Sub

    ''' <summary>
    ''' event for edit click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EV_Edit_Click(sender As Object, e As EventArgs) Handles BTN_EV_Edit.Click
        Dim videoResult As Video = videoRepo.GetVideoById(videoId)
        Dim year As String = TB_EV_Year.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("_", "")

        If (TB_EV_Title.Text = "") Then
            MsgBox("Title is mandatory")
            Return
        End If

        If (year = "") Then
            MsgBox("Year is mandatory")
            Return
        End If

        If (TB_EV_Country.Text = "") Then
            MsgBox("Country is mandatory")
            Return
        End If

        If (TB_EV_Language.Text = "") Then
            MsgBox("Language is mandatory")
            Return
        End If

        If (TB_EV_Length.Text = "") Then
            MsgBox("Length is mandatory")
            Return
        End If


        If (TB_EV_Genre.Text = "") Then
            MsgBox("Genre is mandatory")
            Return
        End If

        If (TB_EV_Actor.Text = "") Then
            MsgBox("Actor is mandatory")
            Return
        End If

        If (TB_EV_Director.Text = "") Then
            MsgBox("Director is mandatory")
            Return
        End If

        If (TB_EV_Resume.Text = "") Then
            MsgBox("Resume is mandatory")
            Return
        End If

        videoResult.Title = TB_EV_Title.Text
        videoResult.Year = TB_EV_Year.Text
        videoResult.Country = TB_EV_Country.Text
        videoResult.Language = TB_EV_Language.Text
        videoResult.Length = TB_EV_Length.Text
        videoResult.Genre = TB_EV_Genre.Text
        videoResult.Actors = TB_EV_Actor.Text
        videoResult.Director = TB_EV_Director.Text
        videoResult.Resume = TB_EV_Resume.Text

        videoRepo.EditVideo(videoResult)
        MsgBox("Video sucessfully edited")

        Dashboard.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Event for cancel click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EV_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_EV_Cancel.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Fetch Image on URL change event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub fetchImage(sender As Object, e As EventArgs) Handles TB_NV_ImgUrl.Leave
        Try
            PB_EV_Picture.BackgroundImage = Util.GetImageFromUrl(sender.Text)
            PB_EV_Picture.BackgroundImageLayout = ImageLayout.Stretch
            videoCheck = True
        Catch ex As Exception

        End Try
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