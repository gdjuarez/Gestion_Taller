Public Class ClassMarcaVehiculoT
    'Marca, idModelo
    Private _Marca As String
    Private _idModelo As Integer

    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(ByVal value As String)
            _Marca = value
        End Set
    End Property

    Public Property IdModelo As Integer
        Get
            Return _idModelo
        End Get
        Set(ByVal value As Integer)
            _idModelo = value
        End Set
    End Property
End Class
