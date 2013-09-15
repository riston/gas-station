Public Class Tanker

    Private _cost As Decimal

    Public Property cost() As Decimal
        Get
            cost = _cost
        End Get
        Set(ByVal value As Decimal)
            _cost = value
        End Set
    End Property

End Class
