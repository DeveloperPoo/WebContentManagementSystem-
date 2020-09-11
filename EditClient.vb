Public Class EditClient
    Dim clientRepo As ClientRepository = New ClientRepository()
    Dim clientNumber As String

    ''' <summary>
    ''' Load Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_EC_FirstName.Enabled = False
        TB_EC_LastName.Enabled = False
        TB_EC_Email.Enabled = False
        TB_EC_Telephone.Enabled = False
        DTP_EC_DOB.Enabled = False
        TB_EC_Address.Enabled = False
        TB_EC_city.Enabled = False
        TB_EC_Province.Enabled = False
        TB_EC_PostalCode.Enabled = False
        BTN_EC_Edit.Enabled = False
    End Sub
    ''' <summary>
    ''' Event for search click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EC_Search_Click(sender As Object, e As EventArgs) Handles BTN_EC_Search.Click
        If (TB_EC_Client.Text.Trim() = "") Then
            MsgBox("Please enter Client number")
            Return
        End If

        TB_EC_FirstName.Enabled = True
        TB_EC_LastName.Enabled = True
        TB_EC_Email.Enabled = True
        TB_EC_Telephone.Enabled = True
        DTP_EC_DOB.Enabled = True
        TB_EC_Address.Enabled = True
        TB_EC_city.Enabled = True
        TB_EC_Province.Enabled = True
        TB_EC_PostalCode.Enabled = True
        BTN_EC_Edit.Enabled = True

        clientNumber = TB_EC_Client.Text
        Dim clientResult As Client = clientRepo.GetClientByClientNumber(clientNumber)
        If (clientResult Is Nothing) Then
            MsgBox("Client not found")
            TB_EC_Client.Enabled = True

        Else
            TB_EC_Client.Enabled = False
            TB_EC_FirstName.Text = clientResult.Fname
            TB_EC_LastName.Text = clientResult.Lname
            TB_EC_Email.Text = clientResult.Email
            TB_EC_Telephone.Text = clientResult.Phone
            DTP_EC_DOB.Value = clientResult.Dob
            TB_EC_Address.Text = clientResult.Address
            TB_EC_city.Text = clientResult.City
            TB_EC_Province.Text = clientResult.Province
            TB_EC_PostalCode.Text = clientResult.PostalCode
        End If
    End Sub

    ''' <summary>
    ''' Event for edit click - validation and form submition
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EC_Edit_Click(sender As Object, e As EventArgs) Handles BTN_EC_Edit.Click

        Dim clientResult As Client = clientRepo.GetClientByClientNumber(clientNumber)
        Dim postalCode As String = TB_EC_PostalCode.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim telephone As String = TB_EC_Telephone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")


        If (TB_EC_FirstName.Text = "") Then
            MsgBox("First Name is mandatory")
            Return
        Else
            If IsNumeric(TB_EC_FirstName.Text) = True Then
                MsgBox("Numbers are not allowed in first name")
                Return
            End If

        End If

        If (TB_EC_LastName.Text = "") Then
            MsgBox("Last Name is mandatory")
            Return
        Else
            If IsNumeric(TB_EC_FirstName.Text) = True Then
                MsgBox("Numbers are not allowed in last name")
                Return
            End If
        End If

        If (TB_EC_Email.Text = "") Then
            MsgBox("Email is mandatory")
            Return
        Else
            If (Util.ValidateEmail(TB_EC_Email.Text) = False) Then
                MsgBox("Invalid Email")
                Return
            End If
        End If

        If (telephone = "") Then
            MsgBox("Telephone is mandatory")
            Return

        End If

        If (postalCode = "") Then
            MsgBox("Postal Code is mandatory")
            Return
        End If

        If (TB_EC_Province.Text = "") Then
            MsgBox("Province is mandatory")
            Return
        End If

        If (TB_EC_city.Text = "") Then
            MsgBox("City is mandatory")
            Return
        End If

        If (TB_EC_Address.Text = "") Then
            MsgBox("Address is mandatory")
            Return
        End If

        clientResult.Fname = TB_EC_FirstName.Text
        clientResult.Lname = TB_EC_LastName.Text
        clientResult.Email = TB_EC_Email.Text
        clientResult.Phone = TB_EC_Telephone.Text
        clientResult.Dob = DTP_EC_DOB.Value.ToLongDateString
        clientResult.Address = TB_EC_Address.Text
        clientResult.City = TB_EC_city.Text
        clientResult.Province = TB_EC_Province.Text
        clientResult.PostalCode = TB_EC_PostalCode.Text

        clientRepo.EditClient(clientResult)
        MsgBox("Client sucessfully edited")
        Dashboard.Show()
        Me.Close()


    End Sub

    ''' <summary>
    ''' Close event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    ''' <summary>
    ''' Event for cancel click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_EC_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_EC_Cancel.Click
        Me.Close()
    End Sub
End Class