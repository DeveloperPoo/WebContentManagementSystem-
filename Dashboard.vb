Public Class Dashboard
    Dim clientRepo As New ClientRepository()
    Dim videoRepo As New VideoRepository()
    Dim topClients As ArrayList
    Dim topVideos As ArrayList

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Me.Close()
        Login.Show()
        Login.TB_login_username.Clear()
        Login.TB_login_password.Clear()


    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewToolStripMenuItem.Click
        CreateNewEmployee.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditEmployee.Show()
        Me.Show()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AdminEditToolStripMenuItem_Click(sender As Object, e As EventArgs)
        EditUser.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateNewVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewVideoToolStripMenuItem.Click
        CreateNewVideo.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateNewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewClientToolStripMenuItem.Click
        CreateNewClient.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        EditClient.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteClient.Show()
        Me.Hide()

    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        EditVideo.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        DeleteVideo.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub QuickSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickSearchToolStripMenuItem.Click
        QuickSearch.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AdvanceSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvanceSearchToolStripMenuItem.Click
        AdvanceSearch.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletToolStripMenuItem.Click
        DeleteEmployee.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Menu event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem2.Click
        VideoList.Show()
        Me.Hide()

    End Sub

    ''' <summary>
    ''' Load Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        topClients = clientRepo.GetTopClients()
        topVideos = videoRepo.GetTopVideos()
        lbl_topClientHead.Text = "Top " & topClients.Count & " Clients:-"
        lbl_topVideoHead.Text = "Top " & topClients.Count & " Videos:-"

        lbl_topClients.Text = StatListToStringClients(topClients)
        lbl_topVideos.Text = StatListToStringVideos(topVideos)

        lbl_lastUpdated.Text = "Last Updated On: " & Now.ToLongTimeString
        lbl_lastUpdatedVideo.Text = "Last Updated On: " & Now.ToLongTimeString

        CheckLevel()
    End Sub


    ''' <summary>
    ''' Converting client array list to display string
    ''' </summary>
    ''' <param name="dataList"></param>
    ''' <returns></returns>
    Private Function StatListToStringClients(dataList As ArrayList) As String
        Dim result = ""
        For i = 0 To dataList.Count - 1 Step 1
            result = result & (i + 1) & ". " & dataList(i).ClientName & "(" & dataList(i).RentCount & ")" & vbNewLine & vbNewLine
        Next

        Return result
    End Function

    ''' <summary>
    ''' Converting Videos array list to display string
    ''' </summary>
    ''' <param name="dataList"></param>
    ''' <returns></returns>
    Private Function StatListToStringVideos(dataList As ArrayList) As String
        Dim result = ""
        For i = 0 To dataList.Count - 1 Step 1
            result = result & (i + 1) & ". " & dataList(i).VideoTitle & "(" & dataList(i).RentCount & ")" & vbNewLine & vbNewLine
        Next

        Return result
    End Function

    ''' <summary>
    ''' Menu click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RentVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentVideoToolStripMenuItem.Click
        Me.Hide()
        RentVideo.Show()
    End Sub


    ''' <summary>
    ''' Menu click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReturnVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnVideoToolStripMenuItem.Click
        Me.Hide()
        ReturnVideo.Show()
    End Sub

    ''' <summary>
    ''' Validates and show.hide menu item based on logged in user level
    ''' </summary>
    Private Sub CheckLevel()
        ' For Employee Menu - Only for Admin
        If (Login.loggedInUser.Level = 4) Then
            CreateNewToolStripMenuItem.Visible = True
            EditToolStripMenuItem.Visible = True
            DeletToolStripMenuItem.Visible = True
        Else
            CreateNewToolStripMenuItem.Visible = False
            EditToolStripMenuItem.Visible = False
            DeletToolStripMenuItem.Visible = False
        End If


        ' Client and Video Menu - Managed by levels
        If (Login.loggedInUser.Level > 2) Then
            DeleteToolStripMenuItem.Visible = True
            DeleteToolStripMenuItem1.Visible = True
        End If

        If (Login.loggedInUser.Level > 1) Then
            EditToolStripMenuItem1.Visible = True
            EditToolStripMenuItem2.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Menu click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        EmployeeList.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Menu click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem1.Click
        ClientList.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Close event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'End
    End Sub

    ''' <summary>
    ''' Menu click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub
End Class