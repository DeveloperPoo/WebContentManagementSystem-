Public Class NewAdmin

    Dim userRepo As UserRepository = New UserRepository()

    ''' <summary>
    ''' Admin login click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TB_AL_Login_Click(sender As Object, e As EventArgs) Handles TB_AL_Login.Click
        Dim sin As String = TB_AL_Sin.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim postalCode As String = TB_AL_Postalcode.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim telephone As String = TB_AL_Homephone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")

        If TB_AL_Firstname.Text = "" Then
            MsgBox("First name is mandatory")
            Return
        Else
            If IsNumeric(TB_AL_Firstname.Text) = True Then
                MsgBox("Numbers are not allowed in first name")
                Return
            End If
        End If


        If TB_AL_Lastname.Text = "" Then
            MsgBox("Last name is mandatory")
            Return
            If IsNumeric(TB_AL_Lastname.Text) = True Then
                MsgBox("Numbers are not allowed in last name")
                Return
            End If
        End If

        If TB_AL_Address.Text = "" Then
            MsgBox("Address is mandatory")
            Return
        End If

        If TB_AL_City.Text = "" Then
            MsgBox("City is mandatory")
            Return
        End If

        If TB_AL_Province.Text = "" Then
            MsgBox("Province is mandatory")
            Return
        End If

        If postalCode = "" Then
            MsgBox("Postal Code is mandatory")
            Return
        End If

        If telephone = "" Then
            MsgBox("Telephone is mandatory")
            Return
        End If

        If sin = "" Then
            MsgBox("SIN is mandatory")
            Return
        End If

        If TB_AL_Hourlypay.Text = "" Then
            MsgBox("Salary is mandatory")
            Return
        Else
            If (IsNumeric(TB_AL_Hourlypay.Text) <> True) Then
                MsgBox("Invalid Salary")
                'TB_NE_Salary.Text = ""
                Return
            ElseIf CLng(TB_AL_Hourlypay.Text) < 0 Or CLng(TB_AL_Hourlypay.Text) > 999 Then
                MsgBox("Salary should be between 0 and 999")
                Return
            End If
        End If

        If TB_AL_Education.Text = "" Then
            MsgBox("Education is mandatory")
            Return
        End If

        Dim user = New User()
        user.Username = InstallationWizard.TB_uname.Text
        user.Password = InstallationWizard.TB_pswrd.Text
        user.Fname = TB_AL_Firstname.Text
        user.Lname = TB_AL_Firstname.Text
        user.Dob = New Date(1994, 8, 23)
        user.Address = TB_AL_Address.Text
        user.City = TB_AL_City.Text
        user.Province = TB_AL_Province.Text
        user.PostalCode = TB_AL_Postalcode.Text
        user.HomePhone = TB_AL_Homephone.Text
        user.CellPhone = TB_AL_Cellphone.Text
        user.StartDate = New Date(1994, 8, 23)
        user.Sin = TB_AL_Sin.Text
        user.HourlyPay = TB_AL_Hourlypay.Text
        user.Education = TB_AL_Education.Text
        user.Level = 4
        Dim result = userRepo.RegisterUser(user)

        If (result > 0) Then
            MsgBox("Admin Sucessfully added")
            Login.Show()
            Me.Close()
        Else
            MsgBox("Error while creating Admin")
        End If


    End Sub


End Class