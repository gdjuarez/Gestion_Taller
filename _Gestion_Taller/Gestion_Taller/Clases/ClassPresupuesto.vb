Public Class ClassPresupuesto

    'Tabla Presupuesto
    Private _IdPresupuesto As Integer
    Private _Fecha As Date
    Private _Total As Decimal
    'Tabla PresupuestoArticulo
    Private _IdPresupuestoArticulos As Integer
    Private _idArticulo As Integer
    Private _Cantidad As Integer
    Private _PrecioUnitario As Decimal
    Private _Importe As Decimal

    Private _IdCliente As String
    Private _vencimiento As Integer

    Public Property IdPresupuesto As Integer
        Get
            Return _IdPresupuesto
        End Get
        Set(value As Integer)
            _IdPresupuesto = value
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

    Public Property IdPresupuestoArticulos As Integer
        Get
            Return _IdPresupuestoArticulos
        End Get
        Set(value As Integer)
            _IdPresupuestoArticulos = value
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

    Public Property Vencimiento As Integer
        Get
            Return _vencimiento
        End Get
        Set(value As Integer)
            _vencimiento = value
        End Set
    End Property
End Class
