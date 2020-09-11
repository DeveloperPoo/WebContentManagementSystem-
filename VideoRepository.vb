Imports MySql.Data.MySqlClient

Public Class VideoRepository : Inherits DbManager

    ''' <summary>
    ''' Get all undeleted videos from database
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllVideos() As DataTable
        Dim query As String = "SELECT video_id, photo, title, year, country, language, length, resume, genre, actors, director, status FROM videos WHERE status < 2 ORDER BY video_id DESC"
        Dim dataset As New DataTable

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return dataset
    End Function

    ''' <summary>
    ''' Add a new video
    ''' </summary>
    ''' <param name="video"></param>
    ''' <returns></returns>
    Public Function AddVideo(ByVal video As Video) As Long
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "INSERT INTO videos (video_id, photo, title, year, country, language, length, resume, genre, actors, director, status)
                                    VALUES(DEFAULT, @photo, @title, @year, @country, @language, @length, @resume, @genre, @actors, @director, DEFAULT)"
            cmd.Parameters.AddWithValue("@photo", video.Photo)
            cmd.Parameters.AddWithValue("@title", video.Title)
            cmd.Parameters.AddWithValue("@year", video.Year)
            cmd.Parameters.AddWithValue("@country", video.Country)
            cmd.Parameters.AddWithValue("@language", video.Language)
            cmd.Parameters.AddWithValue("@length", video.Length)
            cmd.Parameters.AddWithValue("@resume", video.Resume)
            cmd.Parameters.AddWithValue("@genre", video.Genre)
            cmd.Parameters.AddWithValue("@actors", video.Actors)
            cmd.Parameters.AddWithValue("@director", video.Director)


            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            MsgBox("Video successfully added with ID " & GetLastInsertedId())
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    ''' <summary>
    ''' Get last auto generated id from database for video
    ''' </summary>
    ''' <returns></returns>
    Private Function GetLastInsertedId() As Long
        'Select Case LAST_INSERT_ID()
        Dim query As String = "SELECT LAST_INSERT_ID() as last_id"
        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "Stats")
            Return dataset.Tables("Stats").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function

    ''' <summary>
    ''' Edit a video
    ''' </summary>
    ''' <param name="video"></param>
    ''' <returns></returns>
    Public Function EditVideo(ByVal video As Video) As Long
        Dim cmd As New MySqlCommand

        Try
            Dim existingVideo As Video = GetVideoById(video.VideoId)

            If (existingVideo Is Nothing) Then
                MsgBox("Video not found")
                Return 0
            End If

            existingVideo = CopyProperties(video, existingVideo)


            cmd.Connection = Me.Connect
            cmd.CommandText = "Update videos set photo = @photo, title = @title, year = @year, country = @country, language = @language, length = @length, resume = @resume, genre = @genre, actors = @actors, director = @directors
                                   where video_id = @vId"
            cmd.Parameters.AddWithValue("@vId", existingVideo.VideoId)
            cmd.Parameters.AddWithValue("@photo", existingVideo.Photo)
            cmd.Parameters.AddWithValue("@title", existingVideo.Title)
            cmd.Parameters.AddWithValue("@year", existingVideo.Year)
            cmd.Parameters.AddWithValue("@country", existingVideo.Country)
            cmd.Parameters.AddWithValue("@language", existingVideo.Language)
            cmd.Parameters.AddWithValue("@length", existingVideo.Length)
            cmd.Parameters.AddWithValue("@resume", existingVideo.Resume)
            cmd.Parameters.AddWithValue("@genre", existingVideo.Genre)
            cmd.Parameters.AddWithValue("@actors", existingVideo.Actors)
            cmd.Parameters.AddWithValue("@directors", existingVideo.Director)
            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)

            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function


    ''' <summary>
    ''' Get video details using id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function GetVideoById(ByVal id As Long) As Video
        Dim query As String = "SELECT video_id, photo, title, year, country, language, length, resume, genre, actors, director, status FROM videos WHERE status = 1 and video_id = " & id

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "videos")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("videos").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeVideoFromDataset(dataset.Tables("videos").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Get rented video using id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function GetRentedVideoById(ByVal id As Long) As Video
        Dim query As String = "SELECT video_id, photo, title, year, country, language, length, resume, genre, actors, director, status FROM videos WHERE status = 0 and video_id = " & id

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "videos")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("videos").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeVideoFromDataset(dataset.Tables("videos").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Make video object using dataset
    ''' </summary>
    ''' <param name="dataRow"></param>
    ''' <returns></returns>
    Private Function MakeVideoFromDataset(ByVal dataRow As DataRow) As Video
        Dim video = New Video()
        video.VideoId = dataRow(0)
        video.Photo = dataRow(1)

        video.Title = dataRow(2)
        video.Year = dataRow(3)
        video.Country = dataRow(4)
        video.Language = dataRow(5)
        video.Length = dataRow(6)
        video.Resume = dataRow(7)
        video.Genre = dataRow(8)
        video.Actors = dataRow(9)
        video.Director = dataRow(10)
        video.Status = dataRow(11)

        Return video
    End Function

    ''' <summary>
    ''' Copy properties from source to target
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="target"></param>
    ''' <returns></returns>
    Private Function CopyProperties(ByVal source As Video, ByVal target As Video) As Video

        target.VideoId = source.VideoId
        target.Photo = source.Photo

        target.Title = source.Title
        target.Year = source.Year
        target.Country = source.Country
        target.Language = source.Language
        target.Length = source.Length
        target.Resume = source.Resume
        target.Genre = source.Genre
        target.Actors = source.Actors
        target.Director = source.Director
        target.Status = source.Status

        Return target
    End Function

    ''' <summary>
    ''' Rent a video - Will change status to 0
    ''' </summary>
    ''' <param name="videoId"></param>
    ''' <returns></returns>
    Public Function RentVideo(ByVal videoId As Long) As Long

        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "UPDATE videos SET status = 0 WHERE video_id = " & videoId

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Return a video - Will change status to 1
    ''' </summary>
    ''' <param name="videoId"></param>
    ''' <returns></returns>
    Public Function ReturnVideo(ByVal videoId As Long) As Long

        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "UPDATE videos SET status = 1 WHERE video_id = " & videoId

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Delete a video using id
    ''' </summary>
    ''' <param name="videoId"></param>
    ''' <returns></returns>
    Public Function deleteByVideoId(ByVal videoId As Long) As Long

        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "UPDATE videos SET status = 2 WHERE video_id = " & videoId

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Advance search using video fields - LIKE search for strings and exact search for objects
    ''' </summary>
    ''' <param name="video"></param>
    ''' <returns></returns>
    Public Function AdvanceSearch(video As Video) As DataTable
        Dim query As String = "SELECT video_id, photo, title, year, country, language, length, resume, genre, actors, director, status FROM videos WHERE status < 2"
        Dim dataset As New DataTable


        If (video.VideoId <> Nothing) Then
            AppendQuery(query, "video_id", video.VideoId, False)
        End If

        If (video.Title <> "") Then
            AppendQuery(query, "title", video.Title, True)
        End If

        If (video.Year <> Nothing) Then
            AppendQuery(query, "year", video.Year, True)
        End If

        If (video.Country <> "") Then
            AppendQuery(query, "country", video.Country, True)
        End If

        If (video.Language <> "") Then
            AppendQuery(query, "language", video.Language, True)
        End If

        If (video.Length <> Nothing) Then
            AppendQuery(query, "length", video.Length, False)
        End If

        If (video.Resume <> "") Then
            AppendQuery(query, "resume", video.Resume, True)
        End If

        If (video.Genre <> "") Then
            AppendQuery(query, "genre", video.Genre, True)
        End If

        If (video.Actors <> "") Then
            AppendQuery(query, "actors", video.Actors, True)
        End If

        If (video.Director <> "") Then
            AppendQuery(query, "director", video.Director, True)
        End If

        query = query & " ORDER BY video_id DESC"

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return dataset
    End Function

    ''' <summary>
    ''' Aooend query with appropriate column and type of search
    ''' </summary>
    ''' <param name="query"> Existing Query</param>
    ''' <param name="columnName">Column name </param>
    ''' <param name="value">Value to Search</param>
    ''' <param name="likeCheck">Check for like/exact search</param>
    Private Sub AppendQuery(ByRef query As String, columnName As String, value As Object, likeCheck As Boolean)
        If (likeCheck) Then
            query = query & " AND " & columnName & " LIKE '%" & value & "%'"
        Else
            query = query & " AND " & columnName & " = '" & value & "'"
        End If

    End Sub


    ''' <summary>
    ''' Blind search across all video fields
    ''' </summary>
    ''' <param name="filter"></param>
    ''' <returns></returns>
    Public Function BlindSearch(filter As String) As DataTable
        Dim dataset As New DataTable

        Try

            Dim cmd As New MySqlCommand
            cmd.Connection = Me.Connect
            cmd.CommandText = "SELECT video_id, photo, title, year, country, language, length, resume, genre, actors, director, status FROM videos WHERE status < 2
                             AND (photo LIKE '%" & filter & "%' OR title LIKE '%" & filter & "%' OR year LIKE '%" & filter & "%' OR country LIKE '%" & filter & "%' OR language LIKE '%" & filter & "%' OR length LIKE '%" & filter & "%' OR resume LIKE '%" & filter & "%' OR genre LIKE '%" & filter & "%' OR actors LIKE '%" & filter & "%' OR director) ORDER BY video_id DESC"

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
            Return dataset

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return dataset.Tables("clients").Rows
    End Function

    ''' <summary>
    ''' Get top videos from database
    ''' </summary>
    ''' <returns></returns>
    Public Function GetTopVideos() As ArrayList
        Dim query As String = "SELECT CONCAT(clients.fname, ' ', clients.lname) as client_name, CONCAT(videos.title) as video_title, count(video_fk) as rent_count from rents 
	        inner join clients on clients.client_id = rents.client_fk 
	        inner join videos on videos.video_id = rents.video_fk 
			GROUP BY video_fk ORDER by rent_count desc LIMIT 10"
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
