Public Class Rent

    Private _rentId As Long
    Private _clientId As Long
    Private _videoId As Long
    Private _rentDate As Date

    Public Property RentId As Long
        Get
            Return _rentId
        End Get
        Set(value As Long)
            _rentId = value
        End Set
    End Property

    Public Property ClientId As Long
        Get
            Return _clientId
        End Get
        Set(value As Long)
            _clientId = value
        End Set
    End Property

    Public Property VideoId As Long
        Get
            Return _videoId
        End Get
        Set(value As Long)
            _videoId = value
        End Set
    End Property

    Public Property RentDate As Date
        Get
            Return _rentDate
        End Get
        Set(value As Date)
            _rentDate = value
        End Set
    End Property
End Class
