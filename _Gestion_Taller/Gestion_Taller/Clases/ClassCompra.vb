Public Class ClassCompra

    'idCompras, idProveedor, Fecha, Total
    Private _IdCompras As Integer
    Private _idProveedor As Integer
    Private _Fecha As Date
    Private _Total As Decimal
    'idcompra_articulo, idArticulo, Cantidad, PrecioUnitario, Importe, idCompra
    Private _idcompra_articulo As Integer
    Private _idArticulo As Integer
    Private _Cantidad As Integer
    Private _PrecioUnitario As Decimal
    Private _Importe As Decimal


    Public Property IdCompras As Integer
        Get
            Return _IdCompras
        End Get
        Set(ByVal value As Integer)
            _IdCompras = value
        End Set
    End Property

    Public Property idProveedor As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total = value
        End Set
    End Property

    Public Property idcompra_articulo As Integer
        Get
            Return _idcompra_articulo
        End Get
        Set(ByVal value As Integer)
            _idcompra_articulo = value
        End Set
    End Property

    Public Property IdArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(ByVal value As Integer)
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

   
End Class
