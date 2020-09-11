Public Class ClientList
    Dim clientRepo As ClientRepository = New ClientRepository()
    Dim formWidth = 1255

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientList = clientRepo.GetAllClients()

        DataGridView1.DataSource = clientList
        InitGrid()
    End Sub

    ''' <summary>
    ''' Datagrid initial setup
    ''' </summary>
    Private Sub InitGrid()
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.Width = Me.Width
        For i = 0 To DataGridView1.ColumnCount - 1 Step 1
            DataGridView1.Columns(i).Width = Me.Width / DataGridView1.ColumnCount
        Next
        DataGridView1.Height = Me.Height - 130
        searchField.Location = New Point(((Me.Width - 455) / 2), 76)
        searchButton.Location = New Point((searchField.Location.X + searchField.Width + 10), 70)
        headLabel.Location = New Point(((Me.Width - 250) / 2), 32)
    End Sub

    ''' <summary>
    ''' CLose event for client list window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeEvent(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    ''' <summary>
    ''' Event for search button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub searchButton_Click_1(sender As Object, e As EventArgs) Handles searchButton.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = clientRepo.BlindSearch(searchField.Text.Trim())
        DataGridView1.Width = Me.Width
        For i = 0 To DataGridView1.ColumnCount - 1 Step 1
            DataGridView1.Columns(i).Width = Me.Width / DataGridView1.ColumnCount
        Next
        DataGridView1.Height = Me.Height - 80
    End Sub

End Class