Public Class QuickSearch
    Dim videoRepo As New VideoRepository()

    ''' <summary>
    ''' Search button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_QS_Search_Click(sender As Object, e As EventArgs) Handles BTN_QS_Search.Click
        Dim searchObject As New Video()
        If (TB_QS_VideoID.Text <> "") Then
            searchObject.VideoId = CLng(TB_QS_VideoID.Text.Trim())
        End If

        searchObject.Title = TB_QS_Title.Text.Trim()

        Dim videoResult As DataTable = videoRepo.AdvanceSearch(searchObject)
        Dim videoList = New VideoList(videoResult)
        videoList.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Cancel button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_QS_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_QS_Cancel.Click

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