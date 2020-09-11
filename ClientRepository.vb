Imports MySql.Data.MySqlClient

Public Class ClientRepository : Inherits DbManager
    ''' <summary>
    ''' Method to return all undeleted clients 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllClients() As DataTable
        Dim query As String = "SELECT client_id, client_number, fname, lname, email, phone, dob, address, city, province, postal_code, status FROM clients WHERE status = 1 ORDER BY client_id DESC"
        Dim dataset As New DataTable

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
            Return dataset
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return dataset.Tables("clients").Rows
    End Function

    ''' <summary>
    ''' Method to register a client
    ''' </summary>
    ''' <param name="client"></param>
    ''' <returns></returns>
    Public Function RegisterClient(ByVal client As Client) As Long
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "INSERT INTO clients (client_id, client_number, fname, lname, email, phone, dob, address, city, province, postal_code, status)
            VALUES(DEFAULT, @cNum, @fName, @lName, @email, @phone, @dob, @address, @city, @province, @pCode, DEFAULT)"
            Dim newClientNumber = GetNewClientNumber()
            cmd.Parameters.AddWithValue("@cNum", newClientNumber)
            cmd.Parameters.AddWithValue("@fName", client.Fname)
            cmd.Parameters.AddWithValue("@lName", client.Lname)
            cmd.Parameters.AddWithValue("@email", client.Email)
            cmd.Parameters.AddWithValue("@phone", client.Phone)
            cmd.Parameters.AddWithValue("@dob", client.Dob)
            cmd.Parameters.AddWithValue("@address", client.Address)
            cmd.Parameters.AddWithValue("@city", client.City)
            cmd.Parameters.AddWithValue("@province", client.Province)
            cmd.Parameters.AddWithValue("@pCode", client.PostalCode)


            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            If (rowAffected > 0) Then
                MsgBox("Client added with number " & newClientNumber)
            End If
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    ''' <summary>
    ''' Method to edit a client
    ''' </summary>
    ''' <param name="client">Client Object</param>
    ''' <returns></returns>
    Public Function EditClient(ByVal client As Client) As Long
        Dim cmd As New MySqlCommand

        Try
            Dim existingClient As Client = GetClientById(client.ClientId)

            If (existingClient Is Nothing) Then
                MsgBox("Client not found")
                Return 0
            End If

            existingClient = CopyProperties(client, existingClient)


            cmd.Connection = Me.Connect
            cmd.CommandText = "Update clients set fname = @fName, lname = @lName, email = @email, phone = @phone, dob = @dob, address = @address, city = @city, province = @province, postal_code = @pCode
                                   where client_id = @cId"
            cmd.Parameters.AddWithValue("@cId", existingClient.ClientId)
            cmd.Parameters.AddWithValue("@fName", existingClient.Fname)
            cmd.Parameters.AddWithValue("@lName", existingClient.Lname)
            cmd.Parameters.AddWithValue("@email", existingClient.Email)
            cmd.Parameters.AddWithValue("@phone", existingClient.Phone)
            cmd.Parameters.AddWithValue("@dob", existingClient.Dob)
            cmd.Parameters.AddWithValue("@address", existingClient.Address)
            cmd.Parameters.AddWithValue("@city", existingClient.City)
            cmd.Parameters.AddWithValue("@province", existingClient.Province)
            cmd.Parameters.AddWithValue("@pCode", existingClient.PostalCode)

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)

            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function

    ''' <summary>
    ''' Get a client using client number
    ''' </summary>
    ''' <param name="clientNumber"></param>
    ''' <returns></returns>
    Public Function GetClientByClientNumber(ByVal clientNumber As String) As Client
        Dim query As String = "SELECT client_id, client_number, fname, lname, email, phone, dob, address, city, province, postal_code, status FROM clients WHERE status = 1 and client_number = '" & clientNumber & "'"

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "clients")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("clients").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeClientFromDataset(dataset.Tables("clients").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Get a client using client id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function GetClientById(ByVal id As Long) As Client
        Dim query As String = "SELECT client_id, client_number, fname, lname, email, phone, dob, address, city, province, postal_code, status FROM clients WHERE status = 1 and client_id = " & id

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "clients")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("clients").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeClientFromDataset(dataset.Tables("clients").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Make a client object from dataset object
    ''' </summary>
    ''' <param name="dataRow"></param>
    ''' <returns></returns>
    Private Function MakeClientFromDataset(ByVal dataRow As DataRow) As Client
        Dim client = New Client()
        client.ClientId = dataRow(0)
        client.ClientNumber = dataRow(1)

        client.Fname = dataRow(2)
        client.Lname = dataRow(3)
        client.Email = dataRow(4)
        client.Phone = dataRow(5)
        client.Dob = dataRow(6)
        client.Address = dataRow(7)
        client.City = dataRow(8)
        client.Province = dataRow(9)
        client.PostalCode = dataRow(10)
        client.Status = dataRow(11)

        Return client
    End Function

    ''' <summary>
    ''' Fetch new client number from database state
    ''' </summary>
    ''' <returns></returns>
    Private Function GetNewClientNumber() As String

        Dim query As String = "SELECT max(client_number) as max FROM clients"

        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            cmd = New MySqlCommand(query, Me.Connect)
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim maxNum As String = reader.GetString(0)
                If (reader.IsDBNull(0) <> False) Then
                    reader.Close()
                    Return "12345"
                Else
                    reader.Close()
                    Return (CLng(maxNum) + 1).ToString()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Copy Properties from source object to target object
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="target"></param>
    ''' <returns></returns>
    Private Function CopyProperties(ByVal source As Client, ByVal target As Client) As Client
        'target.ClientId = source.ClientId
        'target.ClientNumber = source.ClientNumber
        target.Fname = source.Fname
        target.Lname = source.Lname
        target.Email = source.Email
        target.Phone = source.Phone
        target.Dob = source.Dob
        target.Address = source.Address
        target.City = source.City
        target.Province = source.Province
        target.PostalCode = source.PostalCode
        'target.Status = source.Status

        Return target
    End Function


    ''' <summary>
    ''' Delete a client using client object 
    ''' </summary>
    ''' <param name="clientId">Client ID</param>
    ''' <returns></returns>
    Public Function deleteByClientId(ByVal clientId As Long) As Long

        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "UPDATE clients SET status = 0 WHERE client_id = " & clientId

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affecktked : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Delete a client using Client Number
    ''' </summary>
    ''' <param name="clientNumber">Client Number</param>
    ''' <returns></returns>
    Public Function deleteByClientNumber(ByVal clientNumber As String) As Long

        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "UPDATE clients SET status = 0 WHERE client_number = '" & clientNumber & "'"

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Blind search against client attributes
    ''' </summary>
    ''' <param name="filter"></param>
    ''' <returns></returns>
    Public Function BlindSearch(filter As String) As DataTable
        Dim dataset As New DataTable

        Try

            Dim cmd As New MySqlCommand
            cmd.Connection = Me.Connect
            cmd.CommandText = "SELECT client_id, client_number, fname, lname, email, phone, dob, address, city, province, postal_code, status FROM clients WHERE status = 1
                             AND (client_number LIKE '%" & filter & "%' OR fname LIKE '%" & filter & "%' OR lname LIKE '%" & filter & "%' OR email LIKE '%" & filter & "%' OR phone LIKE '%" & filter & "%' OR dob LIKE '%" & filter & "%' OR address LIKE '%" & filter & "%' OR city LIKE '%" & filter & "%' OR province LIKE '%" & filter & "%' OR postal_code LIKE '%" & filter & "%')  ORDER BY client_id DESC"

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
            Return dataset

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return dataset.Tables("clients").Rows
    End Function

    ''' <summary>
    ''' Get Top clients who rented videos
    ''' </summary>
    ''' <returns></returns>
    Public Function GetTopClients() As ArrayList
        Dim query As String = "SELECT CONCAT(clients.fname, ' ', clients.lname) as client_name, CONCAT(videos.title) as video_title, count(client_fk) as rent_count from rents 
	        inner join clients on clients.client_id = rents.client_fk
	        inner join videos on videos.video_id = rents.video_fk 
			GROUP BY client_fk ORDER by rent_count desc LIMIT 10"
        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "Stats")
            Dim resultList As New ArrayList()
            For i = 0 To dataset.Tables("Stats").Rows.Count - 1 Step 1
                Dim stats As New Stats()
                stats.ClientName = dataset.Tables("Stats").Rows(i)(0)
                stats.VideoTitle = dataset.Tables("Stats").Rows(i)(1)
                stats.RentCount = dataset.Tables("Stats").Rows(i)(2)
                resultList.Add(stats)
            Next
            Return resultList
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function
End Class
