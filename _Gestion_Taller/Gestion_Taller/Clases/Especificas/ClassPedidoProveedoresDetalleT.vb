Public Class ClassPedidoProveedoresDetalleT
    'IdPPDetalle, idArticulo, Cantidad, PrecioUnitario, Importe, IdPP
    Private _IdPPDetalle As Integer
    Private _idArticulo As String
    Private _Cantidad As Integer
    Private _PrecioUnitario As Decimal
    Private _Importe As Decimal
    Private _IdPP As Integer

    Public Property IdPPDetalle As Integer
        Get
            Return _IdPPDetalle
        End Get
        Set(ByVal value As Integer)
            _IdPPDetalle = value
        End Set
    End Property

    Public Property IdArticulo As String
        Get
            Return _idArticulo
        End Get
        Set(ByVal value As String)
            _idArticulo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Decimal)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property Importe As Decimal
        Get
            Return _Importe
        End Get
        Set(ByVal value As Decimal)
            _Importe = value
        End Set
    End Property

    Public Property IdPP As Integer
        Get
            Return _IdPP
        End Get
        Set(ByVal value As Integer)
            _IdPP = value
        End Set
    End Property
End Class
