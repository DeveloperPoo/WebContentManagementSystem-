Public Class InstallationWizard
    Dim userRepo As UserRepository = New UserRepository()

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InstallationWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (userRepo.GetUserByUsername("admin") Is Nothing) Then
            'MsgBox("Admin not there. Stay on Installation Wizard")
            'Me.Hide()
            PNL_Loginadmin.Hide()

        Else

            'MsgBox("Admin is there. Stay on Installation Wizard")
            Me.Hide()
            PNL_admin_login.Hide()
            PNL_Loginadmin.Show()

        End If
    End Sub

    ''' <summary>
    ''' Login button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub login_admin_Click(sender As Object, e As EventArgs) Handles login_admin.Click
        Me.Hide()
        Login.Show()
    End Sub


    ''' <summary>
    ''' Submit button event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_AL_Submit_Click(sender As Object, e As EventArgs) Handles BTN_AL_Submit.Click

        If TB_pswrd.Text = "" Or TB_cpswrd.Text = "" Then
            MsgBox("Null Values are not allowed")
        ElseIf TB_pswrd.Text.Length < 8 Or TB_cpswrd.Text.Length < 8 Then
            MsgBox("Password should be more than 7 character")
        ElseIf TB_pswrd.Text <> TB_cpswrd.Text Then
            MsgBox("Password does not match ")
        Else
            Me.Hide()
            NewAdmin.Show()

        End If
    End Sub


    ''' <summary>
    ''' Inital data for admin registration
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PNL_admin_login_Paint(sender As Object, e As PaintEventArgs) Handles PNL_admin_login.Paint

        TB_uname.Text = "admin"
        TB_uname.Enabled = False
    End Sub
End Class