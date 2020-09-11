Public Class ChangePassword
    Dim userRepo As New UserRepository()

    ''' <summary>
    ''' Event for submit click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_CP_Submit_Click(sender As Object, e As EventArgs) Handles BTN_CP_Submit.Click
        If (TB_currentPassword.Text = "" Or TB_newPassword.Text = "" Or tb_conformPassword.Text = "") Then
            MsgBox("Please enter all fields")
            Return
        End If

        If (TB_newPassword.Text <> tb_conformPassword.Text) Then
            MsgBox("New password and confirm password doest not match")
            Return
        End If

        If (Login.loggedInUser.Password <> TB_currentPassword.Text) Then
            MsgBox("Wrong current password")
            Return
        End If

        Dim result As Long = userRepo.ChangePassword(Login.loggedInUser.Username, TB_newPassword.Text)
        If (result > 0) Then
            MsgBox("Password Changed!")
            Login.loggedInUser = userRepo.GetUserByUsername(Login.loggedInUser.Username)
            Me.Close()
            Dashboard.Show()
        Else
            MsgBox("Error while changing password")
            Return
        End If
    End Sub

    ''' <summary>
    ''' Event fires when windows gets closed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

End Class