Public Class ProductView
    Private ViewID As String
    Public Property ID() As String
        Get
            Return ViewID
        End Get
        Set(ByVal value As String)
            ViewID = value
        End Set
    End Property
    Private ViewName As String
    Public Property Name() As String
        Get
            Return ViewName
        End Get
        Set(ByVal value As String)
            ViewName = value
        End Set
    End Property
    Private ViewPrice As Decimal
    Public Property Price() As Decimal
        Get
            Return ViewPrice
        End Get
        Set(ByVal value As Decimal)
            ViewPrice = value
        End Set
    End Property
    Private ViewBrand As String
    Public Property Brand() As String
        Get
            Return ViewBrand
        End Get
        Set(ByVal value As String)
            ViewBrand = value
        End Set
    End Property
End Class

