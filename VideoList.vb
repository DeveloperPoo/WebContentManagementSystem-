Public Class VideoList
    Dim _mode As Integer = 0
    Dim videoRepo As VideoRepository = New VideoRepository()
    Dim formWidth = 1255
    Dim videoList As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Custom constructor to intialize datagrid with data
    ''' </summary>
    ''' <param name="list"></param>
    Public Sub New(ByVal list As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        videoList = list
    End Sub

    ''' <summary>
    ''' Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VideoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (videoList Is Nothing) Then
            videoList = videoRepo.GetAllVideos()
        End If

        DataGridView1.DataSource = videoList
        InitGrid()
    End Sub

    ''' <summary>
    ''' Initialize video datagrid 
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
    ''' Form close event
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
        DataGridView1.DataSource = videoRepo.BlindSearch(searchField.Text.Trim())
        DataGridView1.Width = Me.Width
        For i = 0 To DataGridView1.ColumnCount - 1 Step 1
            DataGridView1.Columns(i).Width = Me.Width / DataGridView1.ColumnCount
        Next
        DataGridView1.Height = Me.Height - 80
    End Sub
End Class