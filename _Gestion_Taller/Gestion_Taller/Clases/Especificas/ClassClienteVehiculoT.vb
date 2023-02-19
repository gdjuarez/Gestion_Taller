Public Class ClassClienteVehiculoT
    'IdClienteVehiculo, IdCliente, IdVehiculo
    Private _IdClienteVehiculo As Integer
    Private _IdCliente As Integer
    Private _IdVehiculo As Integer

    Public Property IdClienteVehiculo As Integer
        Get
            Return _IdClienteVehiculo
        End Get
        Set(ByVal value As Integer)
            _IdClienteVehiculo = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property

    Public Property IdVehiculo As Integer
        Get
            Return _IdVehiculo
        End Get
        Set(ByVal value As Integer)
            _IdVehiculo = value
        End Set
    End Property
End Class
