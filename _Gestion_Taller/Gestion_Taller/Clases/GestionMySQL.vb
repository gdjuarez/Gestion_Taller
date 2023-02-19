Imports MySql.Data.MySqlClient

Public Class GestionMySQL
    Private miConexion As New MySqlConnection
    Private miComando As New MySqlCommand

    Public Sub New()
        Try
            miConexion.ConnectionString = ("Server=localhost;Port=3307;Database=gestion_taller;User=GiFSys;Password=GiFSys1502;")
            miConexion.Open()
            miComando.Connection = miConexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub EjecutarSQL(ByVal SentenciaSQL As String)
        miComando.CommandText = SentenciaSQL
        miComando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()
    End Sub

    Public Function ConsultarTabla(ByVal tabla As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " + tabla
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarenTablaEscribo(ByVal tabla As String, ByVal columna As String, ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " & tabla & " WHERE " & columna & " LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarArtStockDescripcion(ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT v.idArticulo, v.Descripcion, v.PrecioCompra, v.PrecioVenta, v.Marca, "
        strMysql += "v.Imagen,v.Rubro, s.Stock, s.StockMinimo,v.situado "
        strMysql += "From articulo v inner join stockarticulos s on v.idArticulo = s.idArticulo Where Descripcion  LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarPresupuesto(ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT p.idPresupuesto, p.Fecha, c.RazonSocial, c.Nombre, c.Apellido, p.Total "
        strMysql += "FROM comercio.presupuestos p left join clientepresupuesto cp "
        strMysql += "on p.idpresupuesto = cp.idpresupuesto left join cliente c "
        strMysql += "on c.idcliente = cp.idcliente Where p.idPresupuesto LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarArtStockID(ByVal idArticulo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT v.idArticulo, v.Descripcion, v.PrecioCompra, v.PrecioVenta, v.Marca, "
        strMysql += "v.Imagen,v.Rubro, s.Stock, s.StockMinimo,v.situado "
        strMysql += "FROM articulo v inner join stockarticulos s on v.idArticulo = s.idArticulo Where v.idArticulo ='" & idArticulo & "'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function Consulta(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = sql
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function Agrego_Presupuesto(ByVal numero As String) As DataTable
        Dim miDt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT  cantidad, idArticulo as Codigo,Descripcion as Detalle,Preciounitario,Importe FROM  vistapresupuesto "
        strMysql += "WHERE idPresupuesto = " & numero
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(miDt)
        miConexion.Close()
        Return miDt
    End Function

    ''------Dataset para reporte presupuesto---
    'Public Function Presupuesto(ByVal numero As String) As DataSet
    '    Dim miDataSet As New DataSet
    '    Dim strMysql As String
    '    strMysql = "SELECT * FROM  vistapresupuesto "
    '    strMysql += "WHERE idPresupuesto = " & numero
    '    'MsgBox(strMysql)
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
    '    adaptador.Fill(miDataSet)
    '    miConexion.Close()
    '    Return miDataSet
    'End Function

    '----------get_Factura para ANULAR la venta  DETALLE----------------------------
    Public Function Anular_Venta_Detalle(ByVal numeroVenta As Integer) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = ""
        strMysql += "SELECT va.Cantidad,va.idArticulo as codigo ,a.Descripcion as Detalle,  va.PrecioUnitario, va.Importe "
        strMysql += "FROM ventas v "
        strMysql += "inner join ventaarticulos va on va.idventa= v.idventas "
        strMysql += "inner join Articulo a on a.idArticulo=va.idArticulo "
        strMysql += "where idVenta = " & numeroVenta

        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    '---------------------------------------------------------------------------




    '------------------CAJA------------------------

    Public Function consultarMovimientosCaja(ByVal FECHA As Date) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM vistacajamovimientos WHERE Fecha =  STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y') "
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarSaldoInicial(ByVal FECHA As Date) As DataTable
        'CREADO JUNIO-2018
        Dim dt As New DataTable
        ' Dim strMysql As String = "SELECT * FROM vistacajamovimientos WHERE Fecha =  STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y') "
        Dim sql As String = ""
        sql = "SELECT sum(ingreso)- sum(egreso) as saldoinicial "
        sql += "FROM cajamov cm "
        sql += "inner join caja c on c.codMovCaja = cm.idCajaMov "
        sql += "where c.fecha < STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y');"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(sql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function VehiculoEstado(ByVal estado As String) As DataTable
        Dim dt As New DataTable
        Dim sql As String
        sql = "SELECT v.Dominio, v.Kilometros, v.Color, v.Marca, v.Modelo, v.Combustible, v.TipoMotor, v.Cilindrada, v.Poliza, "
        sql += "A.Aseguradora, v.Comentario, v.Estado, v.Foto, v.Vtv "
        sql += "FROM gestion_taller.vehiculo v "
        sql += "left join aseguradora a on a.Aseguradora = v.idaseguradora "
        sql += " where(v.estado = '" & estado & "')"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(sql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function


End Class
