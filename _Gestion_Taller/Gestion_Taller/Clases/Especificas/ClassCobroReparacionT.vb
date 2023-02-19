Public Class ClassCobroReparacionT
    'IdReparacion, Fecha, Total, FechaPago
    Private _IdReparacion As Integer
    Private _Fecha As Date
    Private _Total As Decimal
    Private _FechaPago As Date

    Public Property IdReparacion As Integer
        Get
            Return _IdReparacion
        End Get
        Set(ByVal value As Integer)
            _IdReparacion = value
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

    Public Property FechaPago As Date
        Get
            Return _FechaPago
        End Get
        Set(ByVal value As Date)
            _FechaPago = value
        End Set
    End Property
End Class
