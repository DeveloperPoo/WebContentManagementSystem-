Public Class EditEmployee
    Dim al As Integer
    Dim edituserRepo As UserRepository = New UserRepository()
    Dim id As Long
    Dim status As Integer

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim level As Integer = Login.loggedInUser.Level
        level = level

        If level = 2 Then
            RB_EE_high.Enabled = False
        ElseIf level = 1 Then
            RB_EE_high.Enabled = False
            RB_EE_medium.Enabled = False
        End If

        GB_EE_PrimaryInformation.Enabled = False
        GB_EE_HumanResources.Enabled = False
        GB_EE_SystemInformation.Enabled = False
        TB_EE_Age.Enabled = False
        BTN_EE_Edit.Enabled = False


    End Sub


    ''' <summary>
    ''' Event for search click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_EE_Search.Click
        If (TB_EE_SearchEmp.Text.Trim() = "") Then
            MsgBox("Please enter employee number")
            Return
        End If

        id = TB_EE_SearchEmp.Text.Trim()
        Dim Idresult As User = edituserRepo.GetUserByEmployeeNum(id)

        If (Idresult Is Nothing) Then
            MsgBox("Emplyoee Not Found")
        Else
            GB_EE_PrimaryInformation.Enabled = True
            GB_EE_HumanResources.Enabled = True
            GB_EE_SystemInformation.Enabled = True



            TB_EE_FirstName.Text = Idresult.Fname
            TB_EE_LastName.Text = Idresult.Lname
            DTP_EE_DOB.Value = Idresult.Dob
            TB_EE_Age.Text = Today.Year - DTP_EE_DOB.Value.Year
            TB_EE_Address.Text = Idresult.Address
            TB_EE_City.Text = Idresult.City
            TB_EE_Provience.Text = Idresult.Province
            TB_EE_PostalCode.Text = Idresult.PostalCode
            TB_EE_Telephone.Text = Idresult.HomePhone
            Tb_EE_Cellphone.Text = Idresult.CellPhone
            TB_EE_EmployeeNo.Text = Idresult.EmployeeNumber
            TB_EE_SIN.Text = Idresult.Sin
            TB_EE_Salary.Text = Idresult.HourlyPay
            DTP_EE_dateStarted.Value = Idresult.StartDate
            CB_EE_Schooling.Text = Idresult.Education
            TB_EE_UserName.Text = Idresult.Username
            TB_EE_Password.Text = Idresult.Password

            If Idresult.Level = 3 Then
                RB_EE_high.Checked = True
            ElseIf Idresult.Level = 2 Then
                RB_EE_medium.Checked = True
            ElseIf Idresult.Level = 1 Then
                RB_EE_low.Checked = True
            End If

            If Idresult.Status = 2 Then
                CheckBox1.Checked = True
            End If
            TB_EE_SearchEmp.Enabled = False
            BTN_EE_Edit.Enabled = True

        End If
    End Sub

    ''' <summary>
    ''' Event for submit click - validation and form submition
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EE_Edit_Click_1(sender As Object, e As EventArgs) Handles BTN_EE_Edit.Click
        If RB_EE_low.Checked = True Then
            al = 1
        ElseIf RB_EE_medium.Checked = True Then
            al = 2
        ElseIf RB_EE_high.Checked = True Then
            al = 3
        Else
            MsgBox("Please select a user level")
            Return
        End If

        If CheckBox1.Checked = True Then
            status = 2
        Else
            status = 1
        End If

        If TB_EE_UserName.Text = "" Then
            MsgBox("User name is mandatory")
            Return
        End If

        If TB_EE_Password.Text = "" Then
            MsgBox("Password is mandatory")
            Return
        End If
        Dim sin As String = TB_EE_SIN.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim postalCode As String = TB_EE_PostalCode.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim telephone As String = TB_EE_Telephone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")

        If TB_EE_FirstName.Text = "" Then
            MsgBox("First name Is mandatory")
            Return
            If IsNumeric(TB_EE_FirstName.Text) = True Then
                MsgBox("Numbers are not allowed in first name")
                Return
            End If

        End If
        If TB_EE_LastName.Text = "" Then
            MsgBox("Last name is mandatory")
            Return
            If IsNumeric(TB_EE_LastName.Text) = True Then
                MsgBox("Numbers are not allowed in first name")
                Return
            End If
        End If

        If TB_EE_Address.Text = "" Then
            MsgBox("Address is mandatory")
            Return
        End If

        If TB_EE_City.Text = "" Then
            MsgBox("City is mandatory")
            Return
        End If

        If TB_EE_Provience.Text = "" Then
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

        If TB_EE_Salary.Text = "" Then
            MsgBox("Salary is mandatory")
            Return
        Else
            If (IsNumeric(TB_EE_Salary.Text) <> True) Then
                MsgBox("Invalid Salary")
                'TB_NE_Salary.Text = ""
                Return
            ElseIf CLng(TB_EE_Salary.Text) < 0 Or CLng(TB_EE_Salary.Text) > 999 Then
                MsgBox("Salary should be between 0 and 999")
                Return
            End If

        End If

        If CB_EE_Schooling.Text = "" Then
            MsgBox("Schooling is mandatory")
            Return
        End If


        id = TB_EE_SearchEmp.Text
        Dim Idresult As User = edituserRepo.GetUserByEmployeeNum(id)

        Idresult.Username = TB_EE_UserName.Text
        Idresult.Password = TB_EE_Password.Text
        Idresult.Fname = TB_EE_FirstName.Text
        Idresult.Lname = TB_EE_LastName.Text
        Idresult.Dob = DTP_EE_DOB.Value.ToLongDateString
        Idresult.Address = TB_EE_Address.Text
        Idresult.City = TB_EE_City.Text
        Idresult.Province = TB_EE_Provience.Text
        Idresult.PostalCode = TB_EE_PostalCode.Text
        Idresult.HomePhone = TB_EE_Telephone.Text
        Idresult.CellPhone = Tb_EE_Cellphone.Text
        Idresult.StartDate = DTP_EE_dateStarted.Value.ToLongDateString
        Idresult.Sin = TB_EE_SIN.Text
        Idresult.HourlyPay = TB_EE_Salary.Text
        Idresult.Education = CB_EE_Schooling.Text
        Idresult.Level = al
        Idresult.Status = status

        edituserRepo.EditUser(Idresult)
        MsgBox("Employee Sucessfully Updated")
        Dashboard.Show()
        Me.Close()
        'End If
    End Sub

    ''' <summary>
    ''' event for cancel click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EE_cancel_Click_1(sender As Object, e As EventArgs) Handles BTN_EE_cancel.Click

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

    ''' <summary>
    ''' Value change event for date of birth to calculate age
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DTP_EE_DOB_ValueChanged(sender As Object, e As EventArgs) Handles DTP_EE_DOB.ValueChanged
        TB_EE_Age.Text = Today.Year - DTP_EE_DOB.Value.Year
    End Sub
End Class