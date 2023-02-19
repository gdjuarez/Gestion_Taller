Public Class ClassArticuloT
    'IdArticulo, Descripcion, Marca, PrecioCompra, PrecioVenta, Stock, StockMinimo, Situado, FamiliaArticulo, Foto, Comentario
    Private _IdArticulo As String
    Private _Descripcion As String
    Private _Marca As String
    Private _PrecioCompra As String
    Private _PrecioVenta As String
    Private _Stock As Integer
    Private _StockMinimo As Integer
    Private _Situado As String
    Private _FamiliaArticulo As String
    Private _Foto As String
    Private _Comentario As String

    Public Property IdArticulo As String
        Get
            Return _IdArticulo
        End Get
        Set(ByVal value As String)
            _IdArticulo = value
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

    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(ByVal value As String)
            _Marca = value
        End Set
    End Property

    Public Property PrecioCompra As String
        Get
            Return _PrecioCompra
        End Get
        Set(ByVal value As String)
            _PrecioCompra = value
        End Set
    End Property

    Public Property PrecioVenta As String
        Get
            Return _PrecioVenta
        End Get
        Set(ByVal value As String)
            _PrecioVenta = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(ByVal value As Integer)
            _Stock = value
        End Set
    End Property

    Public Property StockMinimo As Integer
        Get
            Return _StockMinimo
        End Get
        Set(ByVal value As Integer)
            _StockMinimo = value
        End Set
    End Property

    Public Property Situado As String
        Get
            Return _Situado
        End Get
        Set(ByVal value As String)
            _Situado = value
        End Set
    End Property

    Public Property FamiliaArticulo As String
        Get
            Return _FamiliaArticulo
        End Get
        Set(ByVal value As String)
            _FamiliaArticulo = value
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
