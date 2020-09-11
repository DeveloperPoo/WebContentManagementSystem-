Public Class Login
    Dim userRepository = New UserRepository()
    Public loggedInUser As User

    ''' <summary>
    ''' Login button click - triggers validate form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' Deepanshu
        ValidateForm()
        '' Deepanshu

    End Sub
    '' Deepanshu

    ''' <summary>
    ''' Form validation and submition
    ''' </summary>
    Private Sub ValidateForm()
        If (TB_login_username.Text = "") Then
            MsgBox("Username cannot be empty")
            Return
        End If

        If (TB_login_password.Text = "") Then
            MsgBox("Password cannot be empty")
            Return
        End If

        Dim existingUser = userRepository.GetUserByUsername(TB_login_username.Text)
        If (existingUser Is Nothing) Then
            MsgBox("Invalid Credentials")
            Return
        End If

        If (existingUser.Password = TB_login_password.Text) Then
            Me.loggedInUser = existingUser
            Dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Credentials")
            Return
        End If

    End Sub

    ''' <summary>
    ''' Application close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        End
    End Sub

    ''' <summary>
    ''' Application close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub


    '' Deepanshu
End Class