Public Class ClassHerramienta

    'IidHerramientas, Descripcion, Tipo, Cantidad, Imagen
    Private _IdHerramientas As String
    Private _Descripcion As String
    Private _Tipo As String
    Private _Cantidad As Integer
    Private _Imagen As String

    Public Property IdHerramientas As String
        Get
            Return _IdHerramientas
        End Get
        Set(ByVal value As String)
            _IdHerramientas = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(ByVal value As String)
            _Imagen = value
        End Set
    End Property
End Class
