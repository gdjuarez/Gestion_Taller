Public Class ClassMisDatos

    Private _RazonSocial As String
    Private _Direccion As String
    Private _Ciudad As String
    Private _Telefono As String
    Private _Mail As String
    Private _Cuit As String

    Public Property RazonSocial As String
        Get
            Return _RazonSocial
        End Get
        Set(value As String)
            _RazonSocial = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return _Mail
        End Get
        Set(value As String)
            _Mail = value
        End Set
    End Property

    Public Property Cuit As String
        Get
            Return _Cuit
        End Get
        Set(value As String)
            _Cuit = value
        End Set
    End Property

End Class
