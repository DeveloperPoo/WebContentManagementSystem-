Public Class Stats
    Private _clientName As String
    Private _videoTitle As String
    Private _rentCount As Long
    Private _lastId As Long

    Public Property ClientName As String
        Get
            Return _clientName
        End Get
        Set(value As String)
            _clientName = value
        End Set
    End Property

    Public Property VideoTitle As String
        Get
            Return _videoTitle
        End Get
        Set(value As String)
            _videoTitle = value
        End Set
    End Property

    Public Property RentCount As Long
        Get
            Return _rentCount
        End Get
        Set(value As Long)
            _rentCount = value
        End Set
    End Property

    Public Property LastId As Long
        Get
            Return _lastId
        End Get
        Set(value As Long)
            _lastId = value
        End Set
    End Property
End Class
