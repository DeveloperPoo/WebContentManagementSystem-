Imports MySql.Data.MySqlClient

Public Class DbManager
    ' Connection String for the database ------ DONT CHANGE
    Private connectionString = "server=localhost;user id=root;password=;database=vbproject;"
    Private _connect As MySqlConnection

    Public Sub New()
        Try
            Me._connect = New MySqlConnection(connectionString)
            Me._connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' Connection Object
    ''' </summary>
    ''' <returns></returns>
    Public Property Connect As MySqlConnection
        Get
            Return _connect
        End Get
        Set(value As MySqlConnection)
            _connect = value
        End Set
    End Property
End Class
