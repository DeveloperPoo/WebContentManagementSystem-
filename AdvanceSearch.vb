Public Class AdvanceSearch
    Dim videoRepo As New VideoRepository()

    ''' <summary>
    ''' Event for search button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_AS_Search_Click(sender As Object, e As EventArgs) Handles BTN_AS_Search.Click
        Dim searchObject As New Video()

        searchObject.Title = TB_AS_Title.Text.Trim()

        If (TB_AS_Year.Text.Trim() <> "") Then
            Dim year = Nothing
            If (Integer.TryParse(TB_AS_Year.Text.Trim(), year) And TB_AS_Year.Text.Trim().Length = 4) Then
                searchObject.Year = year
            Else
                MsgBox("Invalid value for year")
                Return
            End If
        End If

        searchObject.Country = TB_AS_Country.Text.Trim()
        searchObject.Language = TB_AS_Language.Text.Trim()

        If (TB_AS_Length.Text.Trim() <> "") Then
            Dim length = Nothing
            If (Integer.TryParse(TB_AS_Length.Text.Trim(), length)) Then
                searchObject.Year = length
            Else
                MsgBox("Invalid value for length")
                Return
            End If
        End If

        searchObject.Genre = TB_AS_Genre.Text.Trim()
        searchObject.Actors = TB_AS_Actor.Text.Trim()
        searchObject.Director = TB_AS_Director.Text.Trim()
        searchObject.Resume = TB_AS_Resume.Text.Trim()



        Dim videoResult As DataTable = videoRepo.AdvanceSearch(searchObject)
        Dim videoList = New VideoList(videoResult)
        videoList.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Event for cancel button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_AS_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_AS_Cancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Event for close event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub
End Class