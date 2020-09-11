Imports MySql.Data.MySqlClient

Public Class RentRepository : Inherits DbManager

    ''' <summary>
    ''' Get All rents 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllRentals() As DataRowCollection
        Dim query As String = "SELECT rent_id, client_fk, video_fk, rent_date FROM rents"
        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "rents")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return dataset.Tables("rents").Rows
    End Function


    ''' <summary>
    ''' Method to rent a video
    ''' </summary>
    ''' <param name="rent"></param>
    ''' <returns></returns>
    Public Function RentVideo(ByVal rent As Rent) As Long
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "INSERT INTO rents (rent_id, client_fk, video_fk, rent_date)
                                    VALUES(DEFAULT, @cId, @vId, DEFAULT)"
            cmd.Parameters.AddWithValue("@cId", rent.ClientId)
            cmd.Parameters.AddWithValue("@vId", rent.VideoId)
            'cmd.Parameters.AddWithValue("@rDate", rent.RentDate)

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    ''' <summary>
    ''' Edit any rent record
    ''' </summary>
    ''' <param name="rent"></param>
    ''' <returns></returns>
    Public Function EditRent(ByVal rent As Rent) As Long
        Dim cmd As New MySqlCommand

        Try
            Dim existingRent As Rent = GetRentsByRentId(rent.RentId)

            If (existingRent Is Nothing) Then
                MsgBox("Rental not found")
                Return 0
            End If

            existingRent = CopyProperties(rent, existingRent)


            cmd.Connection = Me.Connect
            cmd.CommandText = "Update rents set client_fk = @cId, video_fk = @vId, rent_date = @rDate
                                   where rent_id = @rId"
            cmd.Parameters.AddWithValue("@rId", existingRent.RentId)
            cmd.Parameters.AddWithValue("@cId", existingRent.ClientId)
            cmd.Parameters.AddWithValue("@vId", existingRent.VideoId)
            cmd.Parameters.AddWithValue("@rDate", existingRent.RentDate)


            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)

            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function

    ''' <summary>
    ''' Get Rental details using client id
    ''' </summary>
    ''' <param name="clientId"></param>
    ''' <returns></returns>
    Public Function GetRentsByClientId(ByVal clientId As Long) As ArrayList
        Dim query As String = "SELECT rent_id, client_fk, video_fk, rent_date FROM rents WHERE client_fk = " & clientId

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "rents")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("rents").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeRentsFromDataset(dataset.Tables("rents").Rows)
        End If
    End Function


    ''' <summary>
    ''' Get Rental details using video id
    ''' </summary>
    ''' <param name="videoId"></param>
    ''' <returns></returns>
    Public Function GetRentsByVideoId(ByVal videoId As Long) As ArrayList
        Dim query As String = "SELECT rent_id, client_fk, video_fk, rent_date FROM rents WHERE video_fk = " & videoId

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "rents")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("rents").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeRentsFromDataset(dataset.Tables("rents").Rows)
        End If
    End Function

    ''' <summary>
    ''' Get Latest rental details for a video
    ''' </summary>
    ''' <param name="videoId"></param>
    ''' <returns></returns>
    Public Function GetLatestRentsByVideoId(ByVal videoId As Long) As Rent
        Dim query As String = "SELECT rent_id, client_fk, video_fk, rent_date FROM rents WHERE video_fk = " & videoId & " order by rent_date desc LIMIT 1"

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "rents")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("rents").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeRentFromDataset(dataset.Tables("rents").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Get Rental details using rent id
    ''' </summary>
    ''' <param name="rentId"></param>
    ''' <returns></returns>
    Public Function GetRentsByRentId(ByVal rentId As Long) As Rent
        Dim query As String = "SELECT rent_id, client_fk, video_fk, rent_date FROM rents WHERE rent_id = " & rentId

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "rents")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("rents").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeRentsFromDataset(dataset.Tables("rents").Rows)(0)
        End If
    End Function

    ''' <summary>
    ''' Make rents arraylist object from dataset
    ''' </summary>
    ''' <param name="dataRowCollection"></param>
    ''' <returns></returns>
    Private Function MakeRentsFromDataset(ByVal dataRowCollection As DataRowCollection) As ArrayList
        Dim rentList = New ArrayList()

        For i = 0 To dataRowCollection.Count - 1 Step 1
            Dim rent = New Rent()
            rent.RentId = dataRowCollection(i)(0)
            rent.ClientId = dataRowCollection(i)(1)
            rent.VideoId = dataRowCollection(i)(2)
            rent.RentDate = dataRowCollection(i)(3)
            rentList.Add(rent)
        Next


        Return rentList
    End Function

    ''' <summary>
    ''' Make rent object from dataset
    ''' </summary>
    ''' <param name="dataRow"></param>
    ''' <returns></returns>
    Private Function MakeRentFromDataset(ByVal dataRow As DataRow) As Rent
        Dim rent = New Rent()
        rent.RentId = dataRow(0)
        rent.ClientId = dataRow(1)
        rent.VideoId = dataRow(2)
        rent.RentDate = dataRow(3)

        Return rent
    End Function

    ''' <summary>
    ''' Copy Rental details from source to target
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="target"></param>
    ''' <returns></returns>
    Private Function CopyProperties(ByVal source As Rent, ByVal target As Rent) As Rent

        target.RentId = source.RentId
        target.ClientId = source.ClientId
        target.VideoId = source.VideoId

        Return target
    End Function

    ''' <summary>
    ''' Delete Rental recors using rent id
    ''' </summary>
    ''' <param name="rentId"></param>
    ''' <returns></returns>
    Private Function deleteByRentId(ByVal rentId As Long) As Long

        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "Delete from rents where rent_id = " & rentId

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function


End Class
