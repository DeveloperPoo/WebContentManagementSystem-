Public Class Video
    Private _videoId As Long
    Private _photo As String
    Private _title As String
    Private _year As String
    Private _country As String
    Private _language As String
    Private _length As Integer
    Private _resume As String
    Private _genre As String
    Private _actors As String
    Private _director As String
    Private _status As Integer

    Public Property VideoId As Long
        Get
            Return _videoId
        End Get
        Set(value As Long)
            _videoId = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return _photo
        End Get
        Set(value As String)
            _photo = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Year As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _country
        End Get
        Set(value As String)
            _country = value
        End Set
    End Property

    Public Property Language As String
        Get
            Return _language
        End Get
        Set(value As String)
            _language = value
        End Set
    End Property

    Public Property Length As Integer
        Get
            Return _length
        End Get
        Set(value As Integer)
            _length = value
        End Set
    End Property

    Public Property [Resume] As String
        Get
            Return _resume
        End Get
        Set(value As String)
            _resume = value
        End Set
    End Property

    Public Property Genre As String
        Get
            Return _genre
        End Get
        Set(value As String)
            _genre = value
        End Set
    End Property

    Public Property Actors As String
        Get
            Return _actors
        End Get
        Set(value As String)
            _actors = value
        End Set
    End Property

    Public Property Director As String
        Get
            Return _director
        End Get
        Set(value As String)
            _director = value
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
