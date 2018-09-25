Public Class MarketSelectViewModel
    Private marketName As String
    Public Property Name() As String
        Get
            Return marketName
        End Get
        Set(ByVal value As String)
            marketName = value
        End Set
    End Property
    Private marketID As String
    Public Property ID() As String
        Get
            Return marketID
        End Get
        Set(ByVal value As String)
            marketID = value
        End Set
    End Property
End Class
