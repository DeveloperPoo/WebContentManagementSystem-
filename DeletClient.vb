Public Class DeleteClient
    Dim clientRepo As ClientRepository = New ClientRepository()
    Dim clientNumber As String

    ''' <summary>
    ''' Load Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_DC_FirstName.Enabled = False
        TB_DC_LastName.Enabled = False
        TB_DC_Email.Enabled = False
        TB_DC_Telephone.Enabled = False
        DTP_DC_DOB.Enabled = False
        TB_DC_Address.Enabled = False
        TB_DC_city.Enabled = False
        TB_DC_Province.Enabled = False
        TB_DC_PostalCode.Enabled = False
        BTN_DC_Delete.Enabled = False
    End Sub

    ''' <summary>
    ''' Event for delete click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DC_Delete_Click(sender As Object, e As EventArgs) Handles BTN_DC_Delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this client", "Warning!", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Return
        ElseIf result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            Dim clientResult As Client = clientRepo.GetClientByClientNumber(clientNumber)
            clientRepo.deleteByClientNumber(clientNumber)
            MsgBox("Client sucessfully deleted")

            Dashboard.Show()
            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Event for search click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DC_Search_Click_1(sender As Object, e As EventArgs) Handles BTN_DC_Search.Click
        If (TB_DC_Client.Text.Trim() = "") Then
            MsgBox("Please enter client number")
            Return
        End If

        clientNumber = TB_DC_Client.Text
        Dim clientResult As Client = clientRepo.GetClientByClientNumber(clientNumber)
        If (clientResult Is Nothing) Then
            MsgBox("Client not found")
        Else
            TB_DC_FirstName.Text = clientResult.Fname
            TB_DC_LastName.Text = clientResult.Lname
            TB_DC_Email.Text = clientResult.Email
            TB_DC_Telephone.Text = clientResult.Phone
            DTP_DC_DOB.Value = clientResult.Dob
            TB_DC_Address.Text = clientResult.Address
            TB_DC_city.Text = clientResult.City
            TB_DC_Province.Text = clientResult.Province
            TB_DC_PostalCode.Text = clientResult.PostalCode
            BTN_DC_Delete.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Event for cancel click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTN_DC_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_DC_Cancel.Click

        Me.Close()
    End Sub

    ''' <summary>
    ''' Event for close form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub
End Class