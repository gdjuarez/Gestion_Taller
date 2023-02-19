Public Class ClassVehiculoT
    'Dominio, Marca, Modelo, Color, Combustible, Kilometros, TipoMotor, Cilindrada, IdAseguradora, Poliza, FechaAlta, UltimaVisita, Comentario, Foto, Vtv
    Private _Dominio As String
    Private _Marca As String
    Private _Modelo As String
    Private _Color As String
    Private _Combustible As String
    Private _Kilometros As String
    Private _TipoMotor As String
    Private _Cilindrada As String
    Private _IdAseguradora As String
    Private _Poliza As String
    Private _FechaAlta As Date
    Private _UltimaVisita As Date
    Private _Comentario As String
    Private _Foto As String
    Private _Vtv As Date
    Private _Estado As String

    Public Property Dominio As String
        Get
            Return _Dominio
        End Get
        Set(ByVal value As String)
            _Dominio = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(ByVal value As String)
            _Marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(ByVal value As String)
            _Modelo = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(ByVal value As String)
            _Color = value
        End Set
    End Property

    Public Property Combustible As String
        Get
            Return _Combustible
        End Get
        Set(ByVal value As String)
            _Combustible = value
        End Set
    End Property

    Public Property Kilometros As String
        Get
            Return _Kilometros
        End Get
        Set(ByVal value As String)
            _Kilometros = value
        End Set
    End Property

    Public Property TipoMotor As String
        Get
            Return _TipoMotor
        End Get
        Set(ByVal value As String)
            _TipoMotor = value
        End Set
    End Property

    Public Property Cilindrada As String
        Get
            Return _Cilindrada
        End Get
        Set(ByVal value As String)
            _Cilindrada = value
        End Set
    End Property

    Public Property IdAseguradora As String
        Get
            Return _IdAseguradora
        End Get
        Set(ByVal value As String)
            _IdAseguradora = value
        End Set
    End Property

    Public Property Poliza As String
        Get
            Return _Poliza
        End Get
        Set(ByVal value As String)
            _Poliza = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(ByVal value As Date)
            _FechaAlta = value
        End Set
    End Property

    Public Property UltimaVisita As Date
        Get
            Return _UltimaVisita
        End Get
        Set(ByVal value As Date)
            _UltimaVisita = value
        End Set
    End Property

    Public Property Comentario As String
        Get
            Return _Comentario
        End Get
        Set(ByVal value As String)
            _Comentario = value
        End Set
    End Property

    Public Property Foto As String
        Get
            Return _Foto
        End Get
        Set(ByVal value As String)
            _Foto = value
        End Set
    End Property

    Public Property Vtv As Date
        Get
            Return _Vtv
        End Get
        Set(ByVal value As Date)
            _Vtv = value
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
