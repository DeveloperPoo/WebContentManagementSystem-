Imports MySql.Data.MySqlClient

Public Class UserRepository : Inherits DbManager

    ''' <summary>
    ''' Get All undeleted employees
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllEmployees() As DataTable
        Dim query As String = "SELECT user_id, employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users WHERE status > 0 ORDER BY user_id desc"
        Dim dataset As New DataTable

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
            Return dataset
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    ''' <summary>
    ''' Register a new employee/user
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function RegisterUser(ByVal user As User) As Long
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "INSERT INTO users (user_id, employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status)
                                    VALUES(DEFAULT, @eNum, @uName, @pass, @fName, @lName, @dob, @address, @city, @province, @pCode, @hPhone, @cPhone, @sDate, @sin, @hPay, @education, @level, DEFAULT)"
            Dim newEmployeeNumber = GetNewEmployeeNumber()
            cmd.Parameters.AddWithValue("@eNum", newEmployeeNumber)
            cmd.Parameters.AddWithValue("@uName", user.Username)
            cmd.Parameters.AddWithValue("@pass", user.Password)
            cmd.Parameters.AddWithValue("@fName", user.Fname)
            cmd.Parameters.AddWithValue("@lName", user.Lname)
            cmd.Parameters.AddWithValue("@dob", user.Dob)
            cmd.Parameters.AddWithValue("@address", user.Address)
            cmd.Parameters.AddWithValue("@city", user.City)
            cmd.Parameters.AddWithValue("@province", user.Province)
            cmd.Parameters.AddWithValue("@pCode", user.PostalCode)
            cmd.Parameters.AddWithValue("@hPhone", user.HomePhone)
            cmd.Parameters.AddWithValue("@cPhone", user.CellPhone)
            cmd.Parameters.AddWithValue("@sDate", user.StartDate)
            cmd.Parameters.AddWithValue("@sin", user.Sin)
            cmd.Parameters.AddWithValue("@hPay", user.HourlyPay)
            cmd.Parameters.AddWithValue("@education", user.Education)
            cmd.Parameters.AddWithValue("@level", user.Level)


            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            If (rowAffected > 0) Then
                MsgBox("New employee added with number: " & newEmployeeNumber)
            End If
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    ''' <summary>
    ''' Edit a user/employee
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function EditUser(ByVal user As User) As Long
        Dim cmd As New MySqlCommand

        Try
            Dim existingUser As User = GetUserById(user.UserId)

            If (existingUser Is Nothing) Then
                MsgBox("User not found")
                Return 0
            End If

            existingUser = CopyProperties(user, existingUser)


            cmd.Connection = Me.Connect
            cmd.CommandText = "Update users set username = @UserName,password = @Password ,fname = @fName, lname = @lName, dob = @dob, address = @address, city = @city, province = @province, postal_code = @pCode,
                                    home_phone = @hPhone, cell_phone = @cPhone, start_date = @sDate, sin = @sin, hourly_pay = @hPay, education = @education , level = @level,status = @status,employee_number = @Employee_number
                                        where user_id = @uId"

            cmd.Parameters.AddWithValue("@uId", existingUser.UserId)

            cmd.Parameters.AddWithValue("@UserName", existingUser.Username)
            cmd.Parameters.AddWithValue("@Password", existingUser.Password)
            cmd.Parameters.AddWithValue("@Employee_number", existingUser.EmployeeNumber)
            cmd.Parameters.AddWithValue("@fName", existingUser.Fname)
            cmd.Parameters.AddWithValue("@lName", existingUser.Lname)
            cmd.Parameters.AddWithValue("@dob", existingUser.Dob)
            cmd.Parameters.AddWithValue("@address", existingUser.Address)
            cmd.Parameters.AddWithValue("@city", existingUser.City)
            cmd.Parameters.AddWithValue("@province", existingUser.Province)
            cmd.Parameters.AddWithValue("@pCode", existingUser.PostalCode)
            cmd.Parameters.AddWithValue("@hPhone", existingUser.HomePhone)
            cmd.Parameters.AddWithValue("@cPhone", existingUser.CellPhone)
            cmd.Parameters.AddWithValue("@sDate", existingUser.StartDate)
            cmd.Parameters.AddWithValue("@sin", existingUser.Sin)
            cmd.Parameters.AddWithValue("@hPay", existingUser.HourlyPay)
            cmd.Parameters.AddWithValue("@education", existingUser.Education)
            cmd.Parameters.AddWithValue("@level", existingUser.Level)
            cmd.Parameters.AddWithValue("@status", existingUser.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)

            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function

    ''' <summary>
    ''' Change password for user
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="newPassword"></param>
    ''' <returns></returns>
    Public Function ChangePassword(ByVal username As String, ByVal newPassword As String) As Long
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "Update users set password = @password where username = @username"

            cmd.Parameters.AddWithValue("@password", newPassword)

            cmd.Parameters.AddWithValue("@username", username)


            Dim rowAffected = cmd.ExecuteNonQuery()
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Function

    ''' <summary>
    ''' Get user/employee using username
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    Public Function GetUserByUsername(ByVal username As String) As User
        Dim query As String = "SELECT user_id, employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users WHERE status > 0 and username = '" & username & "'"

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("users").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeUserFromDataset(dataset.Tables("users").Rows(0))
        End If
    End Function


    ''' <summary>
    ''' Get User/Employee using id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function GetUserById(ByVal id As Long) As User
        Dim query As String = "SELECT user_id, employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users WHERE status > 0 and user_id = " & id

        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("users").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeUserFromDataset(dataset.Tables("users").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Make user object from dataset
    ''' </summary>
    ''' <param name="dataRow"></param>
    ''' <returns></returns>
    Private Function MakeUserFromDataset(ByVal dataRow As DataRow) As User
        Dim user = New User()
        user.UserId = dataRow(0)
        user.EmployeeNumber = dataRow(1)
        user.Username = dataRow(2)
        user.Password = dataRow(3)
        user.Fname = dataRow(4)
        user.Lname = dataRow(5)
        user.Dob = dataRow(6)
        user.Address = dataRow(7)
        user.City = dataRow(8)
        user.Province = dataRow(9)
        user.PostalCode = dataRow(10)
        user.HomePhone = dataRow(11)
        user.CellPhone = dataRow(12)
        user.StartDate = dataRow(13)
        user.Sin = dataRow(14)
        user.HourlyPay = dataRow(15)
        user.Education = dataRow(16)
        user.Level = dataRow(17)
        user.Status = dataRow(18)

        Return user
    End Function

    ''' <summary>
    ''' Get new running employee number from database
    ''' </summary>
    ''' <returns></returns>
    Private Function GetNewEmployeeNumber() As String

        Dim query As String = "SELECT max(employee_number) as max FROM users"

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
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            reader.Close()
            Return "12345"
        End Try
    End Function

    ''' <summary>
    ''' Copy properties from source to target
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="target"></param>
    ''' <returns></returns>
    Private Function CopyProperties(ByVal source As User, ByVal target As User) As User

        'target.UserId = source.UserId
        target.EmployeeNumber = source.EmployeeNumber
        target.Username = source.Username
        target.Password = source.Password
        target.Fname = source.Fname
        target.Lname = source.Lname
        target.Dob = source.Dob
        target.Address = source.Address
        target.City = source.City
        target.Province = source.Province
        target.PostalCode = source.PostalCode
        target.HomePhone = source.HomePhone
        target.CellPhone = source.CellPhone
        target.StartDate = source.StartDate
        target.Sin = source.Sin
        target.HourlyPay = source.HourlyPay
        target.Education = source.Education
        target.Level = source.Level
        target.Status = source.Status
        Return target
    End Function

    ''' <summary>
    ''' Delete user using username
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    Public Function deleteUser(ByVal username As String) As Long
        If (username = "admin") Then
            MsgBox("Cannot delete admin")
            Return 0
        End If
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.Connect
            cmd.CommandText = "UPDATE users SET status = 0 WHERE username = '" & username & "'"


            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
            Return rowAffected
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Get user using user/employee number
    ''' </summary>
    ''' <param name="EmpNum"></param>
    ''' <returns></returns>
    Public Function GetUserByEmployeeNum(ByVal EmpNum As Long) As User
        Dim query As String = "SELECT user_id, employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users WHERE status > 0 and employee_number = '" & EmpNum & "'"


        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.Connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        If (dataset.Tables("users").Rows.Count = 0) Then
            Return Nothing
        Else
            Return MakeUserFromDataset(dataset.Tables("users").Rows(0))
        End If
    End Function

    ''' <summary>
    ''' Blind search across various user fields
    ''' </summary>
    ''' <param name="filter"></param>
    ''' <returns></returns>
    Public Function BlindSearch(filter As String) As DataTable
        Dim dataset As New DataTable

        Try

            Dim cmd As New MySqlCommand
            cmd.Connection = Me.Connect
            cmd.CommandText = "SELECT user_id, employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users WHERE status > 0
                             AND (employee_number LIKE '%" & filter & "%' OR username LIKE '%" & filter & "%' OR password LIKE '%" & filter & "%' OR fname LIKE '%" & filter & "%' OR lname LIKE '%" & filter & "%' OR dob LIKE '%" & filter & "%' OR address LIKE '%" & filter & "%' OR city LIKE '%" & filter & "%' OR postal_code LIKE '%" & filter & "%' OR home_phone LIKE '%" & filter & "%' OR cell_phone LIKE '%" & filter & "%' OR start_date LIKE '%" & filter & "%' OR sin LIKE '%" & filter & "%' OR hourly_pay LIKE '%" & filter & "%' OR education) ORDER BY user_id desc"

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset)
            Return dataset

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        'Return dataset.Tables("clients").Rows
    End Function

End Class
