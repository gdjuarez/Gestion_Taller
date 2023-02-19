

Public Class ClassVenta

    'Tabla Venta
    Private _IdVenta As Integer
    Private _Fecha As Date
    Private _Total As Decimal
    'Tabla VentaArticulo
    Private _IdVentaArticulos As Integer
    Private _idArticulo As Integer
    Private _Cantidad As Integer
    Private _PrecioUnitario As Decimal
    Private _Importe As Decimal

    Private _IdCliente As String

    Private _Pagado As String

    Public Property IdVenta As Integer
        Get
            Return _IdVenta
        End Get
        Set(value As Integer)
            _IdVenta = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property

    Public Property IdVentaArticulos As Integer
        Get
            Return _IdVentaArticulos
        End Get
        Set(value As Integer)
            _IdVentaArticulos = value
        End Set
    End Property

    Public Property IdArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Decimal)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property Importe As Decimal
        Get
            Return _Importe
        End Get
        Set(value As Decimal)
            _Importe = value
        End Set
    End Property

    Public Property IdCliente As String
        Get
            Return _IdCliente
        End Get
        Set(value As String)
            _IdCliente = value
        End Set
    End Property

    Public Property Pagado As String
        Get
            Return _Pagado
        End Get
        Set(ByVal value As String)
            _Pagado = value
        End Set
    End Property
End Class
