Public Class User
    Private _userId As Long
    Private _employeeNumber As String
    Private _username As String
    Private _password As String
    Private _fname As String
    Private _lname As String
    Private _dob As Date
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postalCode As String
    Private _homePhone As String
    Private _cellPhone As String
    Private _startDate As Date
    Private _sin As String
    Private _hourlyPay As Double
    Private _education As String
    Private _level As Integer
    Private _status As Integer

    Public Property UserId As Long
        Get
            Return _userId
        End Get
        Set(value As Long)
            _userId = value
        End Set
    End Property

    Public Property EmployeeNumber As String
        Get
            Return _employeeNumber
        End Get
        Set(value As String)
            _employeeNumber = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Fname As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Public Property Lname As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Public Property Dob As Date
        Get
            Return _dob
        End Get
        Set(value As Date)
            _dob = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property Province As String
        Get
            Return _province
        End Get
        Set(value As String)
            _province = value
        End Set
    End Property

    Public Property PostalCode As String
        Get
            Return _postalCode
        End Get
        Set(value As String)
            _postalCode = value
        End Set
    End Property

    Public Property HomePhone As String
        Get
            Return _homePhone
        End Get
        Set(value As String)
            _homePhone = value
        End Set
    End Property

    Public Property CellPhone As String
        Get
            Return _cellPhone
        End Get
        Set(value As String)
            _cellPhone = value
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property Sin As String
        Get
            Return _sin
        End Get
        Set(value As String)
            _sin = value
        End Set
    End Property

    Public Property HourlyPay As Double
        Get
            Return _hourlyPay
        End Get
        Set(value As Double)
            _hourlyPay = value
        End Set
    End Property

    Public Property Education As String
        Get
            Return _education
        End Get
        Set(value As String)
            _education = value
        End Set
    End Property

    Public Property Level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property
End Class
