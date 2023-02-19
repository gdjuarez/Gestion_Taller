Public Class ClassStock
    'IdArticulo, Stock, StockMin
    Private _IdArticulo As Integer
    Private _Stock As Integer
    Private _StockMin As Integer

    Public Property IdArticulo As Integer
        Get
            Return _IdArticulo
        End Get
        Set(value As Integer)
            _IdArticulo = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property

    Public Property StockMin As Integer
        Get
            Return _StockMin
        End Get
        Set(value As Integer)
            _StockMin = value
        End Set
    End Property
End Class
