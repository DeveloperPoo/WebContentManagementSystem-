Public Class DeleteEmployee
    Dim al As Integer
    Dim deleteuserRepo As UserRepository = New UserRepository()
    Dim id As Long
    Dim deleteUname As String

    ''' <summary>
    ''' Load Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim level As Integer = Login.loggedInUser.Level
        level = level

        If level = 2 Then
            RB_DE_high.Enabled = False
        ElseIf level = 1 Then
            RB_DE_high.Enabled = False
            RB_DE_medium.Enabled = False
        End If

        GB_DE_PrimaryInformation.Enabled = False
        GB_DE_HumanResources.Enabled = False
        GB_DE_SystemInformation.Enabled = False
        TB_DE_Age.Enabled = False
    End Sub

    ''' <summary>
    ''' Event for search click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TB_DE_Employee.Text.Trim() = "") Then
            MsgBox("Please enter employee number")
            Return
        End If

        id = TB_DE_Employee.Text
        Dim Idresult As User = deleteuserRepo.GetUserByEmployeeNum(id)

        If (Idresult Is Nothing) Then
            MsgBox("Emplyoee Not Found")
            TB_DE_Employee.Enabled = True
        Else

            TB_DE_Employee.Enabled = False
            GB_DE_PrimaryInformation.Enabled = True
            GB_DE_HumanResources.Enabled = True
            GB_DE_SystemInformation.Enabled = True

            TB_DE_FirstName.Text = Idresult.Fname
            TB_DE_LastName.Text = Idresult.Lname
            DTP_DE_DOB.Value = Idresult.Dob
            TB_DE_Age.Text = Today.Year - DTP_DE_DOB.Value.Year
            TB_DE_Address.Text = Idresult.Address
            TB_DE_City.Text = Idresult.City
            TB_DE_Provience.Text = Idresult.Province
            TB_DE_PostalCode.Text = Idresult.PostalCode
            TB_DE_Telephone.Text = Idresult.HomePhone
            TB_DE_cellphone.Text = Idresult.CellPhone
            TB_DE_EmployeeNo.Text = Idresult.EmployeeNumber
            TB_DE_SIN.Text = Idresult.Sin
            TB_DE_Salary.Text = Idresult.HourlyPay
            DTP_DE_dateStarted.Value = Idresult.StartDate
            CB_DE_Schooling.Text = Idresult.Education
            TB_DE_UserName.Text = Idresult.Username
            TB_DE_Password.Text = Idresult.Password

            If Idresult.Level = 3 Then
                RB_DE_high.Checked = True
            ElseIf Idresult.Level = 2 Then
                RB_DE_medium.Checked = True
            ElseIf Idresult.Level = 1 Then
                RB_DE_low.Checked = True
            End If

            BTN_DE_Delete.Enabled = True

        End If
    End Sub

    ''' <summary>
    ''' Event for cancel click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DE_cancel_Click(sender As Object, e As EventArgs) Handles BTN_DE_cancel.Click

        Me.Close()
    End Sub

    ''' <summary>
    ''' Event for delete click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DE_Delete_Click(sender As Object, e As EventArgs) Handles BTN_DE_Delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this employee", "Warning!", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Return
        ElseIf result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            deleteUname = TB_DE_UserName.Text
            Dim Idresult As Long = deleteuserRepo.deleteUser(deleteUname)

            Dim rowAffected As Long = deleteuserRepo.deleteUser(Idresult)

            MsgBox("Employee Deleted Sucessfully")
                Dashboard.Show()
                Me.Close()



        End If

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