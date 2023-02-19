Public Class ClassDetalleReparacionT
    'idDetalleReparacion, idReparacion, IdArticulo, Cantidad, PrecioUnitario, Importe
    Private _idDetalleReparacion As Integer
    Private _idReparacion As Integer
    Private _IdArticulo As String
    Private _Cantidad As Integer
    Private _PrecioUnitario As Decimal
    Private _Importe As Decimal

    Public Property IdDetalleReparacion As Integer
        Get
            Return _idDetalleReparacion
        End Get
        Set(ByVal value As Integer)
            _idDetalleReparacion = value
        End Set
    End Property

    Public Property IdReparacion As Integer
        Get
            Return _idReparacion
        End Get
        Set(ByVal value As Integer)
            _idReparacion = value
        End Set
    End Property

    Public Property IdArticulo As String
        Get
            Return _IdArticulo
        End Get
        Set(ByVal value As String)
            _IdArticulo = value
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
End Class
