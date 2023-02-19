Public Class ClassAseguradoraT
    'idAseguradora, Nombre, Domicilio, Ciudad, Provincia, CodigoPostal, Telefono1, Telefono2, Email, Contacto, Comentario
    Private _idAseguradora As Integer
    Private _Nombre As String
    Private _Domicilio As String
    Private _Ciudad As String
    Private _Provincia As String
    Private _CodigoPostal As String
    Private _Telefono1 As String
    Private _Telefono2 As String
    Private _Email As String
    Private _Contacto As String
    Private _Comentario As String

    Public Property IdAseguradora As String
        Get
            Return _idAseguradora
        End Get
        Set(ByVal value As String)
            _idAseguradora = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(ByVal value As String)
            _Provincia = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(ByVal value As String)
            _CodigoPostal = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return _Telefono1
        End Get
        Set(ByVal value As String)
            _Telefono1 = value
        End Set
    End Property

    Public Property Telefono2 As String
        Get
            Return _Telefono2
        End Get
        Set(ByVal value As String)
            _Telefono2 = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Public Property Contacto As String
        Get
            Return _Contacto
        End Get
        Set(ByVal value As String)
            _Contacto = value
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
End Class
