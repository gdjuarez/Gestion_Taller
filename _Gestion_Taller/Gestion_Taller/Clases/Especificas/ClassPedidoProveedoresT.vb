Public Class ClassPedidoProveedoresT
    'IdPP, IdProveedor, Fecha, Total
    Private _IdPPo As Integer
    Private _IdProveedoro As Integer
    Private _Fecha As Date
    Private _Total As Decimal

    Public Property IdPPo As Integer
        Get
            Return _IdPPo
        End Get
        Set(ByVal value As Integer)
            _IdPPo = value
        End Set
    End Property

    Public Property IdProveedoro As Integer
        Get
            Return _IdProveedoro
        End Get
        Set(ByVal value As Integer)
            _IdProveedoro = value
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
End Class
