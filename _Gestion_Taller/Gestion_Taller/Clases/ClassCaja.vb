Public Class ClassCaja
    'codCaja, codMovCaja, Fecha, operador
    'idCajaMov, tipoMovimiento, Descripcion, tipoComprobante, serienumero, ingreso, egreso
    Private _codCaja As Integer
    Private _codMovCaja As Integer
    Private _Fecha As Date
    Private _operador As String

    Private _idCajaMov As Integer
    Private _tipoMovimiento As String
    Private _Descripcion As String
    Private _tipoComprobante As String
    Private _serienumero As String
    Private _ingreso As Decimal
    Private _egreso As Decimal
    Private _importe As Decimal

    Public Property CodCaja As Integer
        Get
            Return _codCaja
        End Get
        Set(value As Integer)
            _codCaja = value
        End Set
    End Property

    Public Property CodMovCaja As Integer
        Get
            Return _codMovCaja
        End Get
        Set(value As Integer)
            _codMovCaja = value
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

    Public Property Operador As String
        Get
            Return _operador
        End Get
        Set(value As String)
            _operador = value
        End Set
    End Property

    Public Property IdCajaMov As Integer
        Get
            Return _idCajaMov
        End Get
        Set(value As Integer)
            _idCajaMov = value
        End Set
    End Property

    Public Property TipoMovimiento As String
        Get
            Return _tipoMovimiento
        End Get
        Set(value As String)
            _tipoMovimiento = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property TipoComprobante As String
        Get
            Return _tipoComprobante
        End Get
        Set(value As String)
            _tipoComprobante = value
        End Set
    End Property

    Public Property Serienumero As String
        Get
            Return _serienumero
        End Get
        Set(value As String)
            _serienumero = value
        End Set
    End Property

    Public Property Ingreso As Decimal
        Get
            Return _ingreso
        End Get
        Set(value As Decimal)
            _ingreso = value
        End Set
    End Property

    Public Property Egreso As Decimal
        Get
            Return _egreso
        End Get
        Set(value As Decimal)
            _egreso = value
        End Set
    End Property

    Public Property Importe As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property


End Class
