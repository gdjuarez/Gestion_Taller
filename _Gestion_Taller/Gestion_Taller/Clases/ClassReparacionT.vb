Public Class ClassReparacionT
    'IdReparacion, Dominio, IdCliente, FechaEntrada, DatosAveria, FechaReparacion, FechaSalida, Estado
    Private _IdReparacion As Integer
    Private _Dominio As String
    Private _IdCliente As String
    Private _FechaEntrada As Date
    Private _DatosAveria As String
    Private _FechaReparacion As Date
    Private _FechaSalida As Date
    'grabo estado en vehiculo
    Private _Estado As String

    Public Property IdReparacion As Integer
        Get
            Return _IdReparacion
        End Get
        Set(ByVal value As Integer)
            _IdReparacion = value
        End Set
    End Property

    Public Property Dominio As String
        Get
            Return _Dominio
        End Get
        Set(ByVal value As String)
            _Dominio = value
        End Set
    End Property

    Public Property IdCliente As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property

    Public Property FechaEntrada As Date
        Get
            Return _FechaEntrada
        End Get
        Set(ByVal value As Date)
            _FechaEntrada = value
        End Set
    End Property

    Public Property DatosAveria As String
        Get
            Return _DatosAveria
        End Get
        Set(ByVal value As String)
            _DatosAveria = value
        End Set
    End Property

    Public Property FechaReparacion As Date
        Get
            Return _FechaReparacion
        End Get
        Set(ByVal value As Date)
            _FechaReparacion = value
        End Set
    End Property

    Public Property FechaSalida As Date
        Get
            Return _FechaSalida
        End Get
        Set(ByVal value As Date)
            _FechaSalida = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
End Class
