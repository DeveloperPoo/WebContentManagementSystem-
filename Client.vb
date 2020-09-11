Public Class Client
    Private _clientId As Long
    Private _clientNumber As String
    Private _fname As String
    Private _lname As String
    Private _email As String
    Private _phone As String
    Private _dob As Date
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postalCode As String
    Private _status As Boolean

    Public Property ClientId As Long
        Get
            Return _clientId
        End Get
        Set(value As Long)
            _clientId = value
        End Set
    End Property

    Public Property ClientNumber As String
        Get
            Return _clientNumber
        End Get
        Set(value As String)
            _clientNumber = value
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

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
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

    Public Property Status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
        End Set
    End Property
End Class
