Public Class CreateNewEmployee
    Dim al As Integer
    Dim userRepo As UserRepository = New UserRepository()

    ''' <summary>
    ''' Event for cancel button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NewEmployee_cancle_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateNewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim level As Integer = Login.loggedInUser.Level
        level = level

        If level = 2 Then
            RB_NE_high.Enabled = False
        ElseIf level = 1 Then
            RB_NE_high.Enabled = False
            RB_NE_medium.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Event on save button click - Validation and submition
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NewEmployee_save_Click_1(sender As Object, e As EventArgs) Handles BTN_NewEmployee_save.Click
        If RB_NE_low.Checked = True Then
            al = 1
        ElseIf RB_NE_medium.Checked = True Then
            al = 2
        ElseIf RB_NE_high.Checked = True Then
            al = 3
        Else
            MsgBox("Please select a user level")
            Return
        End If
        If TB_NE_UserName.Text = "" Then
            MsgBox("User name is mandatory")
            Return
        End If

        If TB_NE_Password.Text = "" Then
            MsgBox("Password is mandatory")
            Return
        End If

        Dim sin As String = TB_NE_SIN.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim postalCode As String = TB_NE_PostalCode.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim telephone As String = TB_NE_Telephone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")

        If TB_NE_FirstName.Text = "" Then
            MsgBox("First name is mandatory")
            Return
        Else
            If IsNumeric(TB_NE_FirstName.Text) = True Then
                MsgBox("Numbers are not allowed in first name")
                Return
            End If
        End If


        If TB_NE_LastName.Text = "" Then
            MsgBox("Last name is mandatory")
            Return
            If IsNumeric(TB_NE_LastName.Text) = True Then
                MsgBox("Numbers are not allowed in last name")
                Return
            End If
        End If

        If TB_NE_Address.Text = "" Then
            MsgBox("Address is mandatory")
            Return
        End If

        If TB_NE_city.Text = "" Then
            MsgBox("City is mandatory")
            Return
        End If

        If TB_NE_Province.Text = "" Then
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

        If TB_NE_Salary.Text = "" Then
            MsgBox("Salary is mandatory")
            Return
        Else
            If (IsNumeric(TB_NE_Salary.Text) <> True) Then
                MsgBox("Invalid Salary")
                'TB_NE_Salary.Text = ""
                Return
            ElseIf CLng(TB_NE_Salary.Text) < 0 Or CLng(TB_NE_Salary.Text) > 999 Then
                MsgBox("Salary should be between 0 and 999")
                Return
            End If
        End If

        If CB_NE_Schooling.Text = "" Then
            MsgBox("Schooling is mandatory")
            Return
        End If

        ' Check if user exists or not
        Dim userCheck As User = userRepo.GetUserByUsername(TB_NE_UserName.Text.Trim())
        If (userCheck Is Nothing) Then
            Dim user = New User()
            user.Username = TB_NE_UserName.Text
            user.Password = TB_NE_Password.Text
            user.Fname = TB_NE_FirstName.Text
            user.Lname = TB_NE_LastName.Text
            user.Dob = DTP_NE_DOB.Value.ToLongDateString
            user.Address = TB_NE_Address.Text
            user.City = TB_NE_city.Text
            user.Province = TB_NE_Province.Text
            user.PostalCode = TB_NE_PostalCode.Text
            user.HomePhone = TB_NE_Telephone.Text
            user.CellPhone = TB_NE_Cellphone.Text
            user.StartDate = DTP_NE_DateStarted.Value.ToLongDateString
            user.Sin = TB_NE_SIN.Text
            user.HourlyPay = TB_NE_Salary.Text
            user.Education = CB_NE_Schooling.Text
            user.Level = al
            Dim rowAffected = userRepo.RegisterUser(user)

            If (rowAffected > 0) Then
                MsgBox("Employee Sucessfully added")
                Dashboard.Show()
                Me.Close()
            Else
                MsgBox("Error while creating new employee")
            End If
        Else
            MsgBox("Username already taken")
        End If
    End Sub

    ''' <summary>
    ''' Event for value change for date field to calculate age
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DTP_NE_DOB_ValueChanged(sender As Object, e As EventArgs) Handles DTP_NE_DOB.ValueChanged
        TB_NE_Age.Text = Today.Year - DTP_NE_DOB.Value.Year
    End Sub

    ''' <summary>
    ''' Canel click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NewEmployee_cancle_Click_1(sender As Object, e As EventArgs) Handles BTN_NewEmployee_cancle.Click

        Me.Close()
    End Sub

    ''' <summary>
    ''' Close Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

 
End Class