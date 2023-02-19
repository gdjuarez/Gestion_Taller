Public Class ClassUsuarioT
    'Usuario, Clave
    Private _Usuario As String
    Private _Clave As String

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property
End Class
