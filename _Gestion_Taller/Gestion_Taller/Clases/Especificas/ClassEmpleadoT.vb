Public Class ClassEmpleadoT

    'IdEmpleado, Apellido, Nombre, Domicilio, Ciudad, Provincia, CodigoPostal, TelFijo, TelCelular, Email, Cargo, Horario, Salario, FechaAlta, FechaVencContrato, Foto, Comentario
    Private _IdEmpleado As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Domicilio As String
    Private _Ciudad As String
    Private _Provincia As String
    Private _CodigoPostal As String
    Private _TelFijo As String
    Private _TelCelular As String
    Private _Email As String
    Private _Cargo As String
    Private _Observaciones As String
    Private _Horario As String
    Private _Salario As String
    Private _FechaAlta As Date
    Private _FechaVencContrato As Date
    Private _Foto As String
    Private _Comentario As String

    Public Property IdEmpleado As String
        Get
            Return _IdEmpleado
        End Get
        Set(ByVal value As String)
            _IdEmpleado = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
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

    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
        End Set
    End Property

    Public Property Horario As String
        Get
            Return _Horario
        End Get
        Set(ByVal value As String)
            _Horario = value
        End Set
    End Property

    Public Property Salario As String
        Get
            Return _Salario
        End Get
        Set(ByVal value As String)
            _Salario = value
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

    Public Property FechaVencContrato As Date
        Get
            Return _FechaVencContrato
        End Get
        Set(ByVal value As Date)
            _FechaVencContrato = value
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

    Public Property Comentario As String
        Get
            Return _Comentario
        End Get
        Set(ByVal value As String)
            _Comentario = value
        End Set
    End Property
End Class
