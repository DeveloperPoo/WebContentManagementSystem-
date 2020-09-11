Public Class CreateNewClient
    Dim clientRepo As ClientRepository = New ClientRepository()

    ''' <summary>
    ''' Event on Save button click - Contains validation and submition
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NC_save_Click(sender As Object, e As EventArgs) Handles BTN_NC_save.Click
        Dim postalCode As String = TB_NC_PostalCode.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        Dim telephone As String = TB_NC_telephone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace("_", "")
        If (TB_NC_FirstName.Text = "") Then
            MsgBox("First Name is mandatory")
            Return
        Else
            If IsNumeric(TB_NC_FirstName.Text) = True Then
                MsgBox("Numbers are not allowed in first name")
                Return
            End If
        End If

        If (TB_NC_LastName.Text = "") Then
            MsgBox("Last Name is mandatory")
            Return
        Else
            If IsNumeric(TB_NC_LastName.Text) = True Then
                MsgBox("Numbers are not allowed in last name")
                Return
            End If
        End If

        If (TB_NC_Email.Text = "") Then
            MsgBox("Email is mandatory")
            Return
        Else
            If (Util.ValidateEmail(TB_NC_Email.Text) = False) Then
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

        If (TB_NC_Province.Text = "") Then
            MsgBox("Province is mandatory")
            Return
        End If

        If (TB_NC_city.Text = "") Then
            MsgBox("City is mandatory")
            Return
        End If

        If (TB_NC_Address.Text = "") Then
            MsgBox("Address is mandatory")
            Return
        End If


        Dim client = New Client
        client.Fname = TB_NC_FirstName.Text
        client.Lname = TB_NC_LastName.Text
        client.Email = TB_NC_Email.Text
        client.Phone = TB_NC_telephone.Text
        client.Dob = DTP_NC_DOB.Value.ToLongDateString
        client.Address = TB_NC_Address.Text
        client.City = TB_NC_city.Text
        client.Province = TB_NC_Province.Text
        client.PostalCode = TB_NC_PostalCode.Text
        clientRepo.RegisterClient(client)
        MsgBox("Client Sucessfully added")
        Dashboard.Show()
        Me.Close()

    End Sub


    ''' <summary>
    ''' Event on cancel button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_NC_cancle_Click(sender As Object, e As EventArgs) Handles BTN_NC_cancle.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' CLose Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub
End Class