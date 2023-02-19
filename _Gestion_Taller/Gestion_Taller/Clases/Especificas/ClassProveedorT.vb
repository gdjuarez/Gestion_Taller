Public Class ClassProveedorT
    'IdProveedor, Nombre, Contacto, Domicilio, Ciudad, Provincia, CodigoPostal, TelFijo, TelCelular, Email, Cuit, Comentario
    Private _IdProveedor As Integer
    Private _Nombre As String
    Private _Contacto As String
    Private _Domicilio As String
    Private _Ciudad As String
    Private _Provincia As String
    Private _CodigoPostal As String
    Private _TelFijo As String
    Private _TelCelular As String
    Private _Email As String
    Private _Cuit As String
    Private _Comentario As String

    Public Property IdProveedor As Integer
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As Integer)
            _IdProveedor = value
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

    Public Property Contacto As String
        Get
            Return _Contacto
        End Get
        Set(ByVal value As String)
            _Contacto = value
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

    Public Property TelFijo As String
        Get
            Return _TelFijo
        End Get
        Set(ByVal value As String)
            _TelFijo = value
        End Set
    End Property

    Public Property TelCelular As String
        Get
            Return _TelCelular
        End Get
        Set(ByVal value As String)
            _TelCelular = value
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

    Public Property Cuit As String
        Get
            Return _Cuit
        End Get
        Set(ByVal value As String)
            _Cuit = value
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
