Public Class ClassModeloVehiculovbT
    'idVehiculoModelo, Modelo
    Private _idVehiculoModelo As Integer
    Private _Modelo As String

    Public Property IdVehiculoModelo As Integer
        Get
            Return _idVehiculoModelo
        End Get
        Set(ByVal value As Integer)
            _idVehiculoModelo = value
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
End Class
