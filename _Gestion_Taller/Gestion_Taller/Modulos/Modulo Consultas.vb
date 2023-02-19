Module Modulo_Consultas

    'Public comando As New MySql.Data.MySqlClient.MySqlCommand
    'Public consultaMysql As String = ""

   
    'Public Function buscoFecha(ByVal tabla As String, ByVal fecha As Date) As DataTable
    '    'utilizado para las entregas 
    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT * FROM " & tabla & " WHERE Fecha =  STR_TO_DATE('" & fecha & "' ,'%d/%m/%Y')"
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)
    '    'MsgBox(strMysql)
    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function


    '--- PROBANDO DATOS DEL TICKET CON PARAMETO IDVENTA -------------
    'Public Function getTicketCabecera(ByVal nVenta As Integer) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT v.idVentas, v.Fecha, v.Total, va.idVentaArticulo, va.idArticulo, va.Cantidad, va.PrecioUnitario, va.Importe FROM comercio.ventas v inner join comercio.ventaarticulos va on va.idventa= v.idventas where idVenta=" & nVenta
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function
    ''--------------------------------------------------------------
    'Public Function getTicketDetalle(ByVal nVenta As Integer) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT va.idArticulo, va.Cantidad, va.PrecioUnitario, va.Importe FROM comercio.ventas v inner join comercio.ventaarticulos va on va.idventa= v.idventas where idVenta=" & nVenta
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function
    ''--------------------------------------------------------------
    'Public Function buscoApellidoNombre(ByVal tabla As String, ByVal id As Integer) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT Apellido, Nombre FROM " & tabla & " WHERE idPersonal = " & id
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function contarRegistros(ByVal tabla As String) As DataTable
    '    'Consulta para contar la cantidad de registros de una tabla
    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT COUNT(*) as Registros FROM " + tabla
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function consultallenarComboBox(ByVal columna As String, ByVal tabla As String) As DataTable

    '    'CONSULTA A UNA COLUMNA DE UNA TABLA para luego llenar un Combobox
    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT " & columna & " FROM " & tabla & ""
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

   

    'Public Function buscarArtStockID(ByVal idArticulo As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT v.idArticulo, v.Descripcion, v.PrecioCompra, v.PrecioVenta, v.Marca, v.Imagen, s.Stock, s.StockMinimo FROM articulo v inner join stockarticulos s on v.idArticulo = s.idArticulo Where v.idArticulo ='" & idArticulo & "'"

    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function
    '----------------------------------------C A J A ---------------------------------

    'Public Function consultarsaldoInicial(ByVal FECHA As Date) As DataTable

    '    '-------------------CAJA----SALDO INICIAL
    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT saldoinicial FROM caja WHERE  Fecha =  STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y') "
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function


    'Public Function consultarCierres(ByVal MES As String, ByVal ANNO As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT * FROM vistacierredecaja WHERE  month(Fecha) = " & MES & " and year(fecha) = " & ANNO & ""
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function
    ''-----------------INFORMES DE CAJA MENSUAL --------------------------------------------
    'Public Function informeCaja(ByVal MES As String, ByVal ANNO As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = ""

    '    strMysql = "SELECT COUNT(DESCRIPCION) AS CANTIDAD,tipoMovimiento,TIPOCOMPROBANTE,DESCRIPCION,SUM(IMPORTE) AS IMPORTE"
    '    strMysql += " FROM cajamov M inner join caja C ON C.CODCAJA = M.IDCAJAMOV "
    '    strMysql += " WHERE  month(Fecha) = " & MES & " and year(fecha) = " & ANNO & " GROUP BY DESCRIPCION"

    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)
    '    ' MsgBox(strMysql)
    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function informeCajaMensualCodCajadelSaldoInicial(ByVal MES As String, ByVal ANNO As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = ""
    '    '--------------------------------Obtengo el codigo de caja del primer SaldoInicial grabado en ese MES
    '    strMysql = "SELECT min(codcaja) as Codcaja FROM caja"
    '    strMysql += " WHERE month(Fecha) =" & MES & " and year(fecha) = " & ANNO & ""

    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)
    '    ' MsgBox(strMysql)
    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function informeCajaMensualSaldoinicial(ByVal codCaja As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = ""

    '    strMysql = "SELECT saldoinicial  FROM caja"
    '    strMysql += " WHERE codcaja=" & codCaja

    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)
    '    ' MsgBox(strMysql)
    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function informeCajaMensualIngresos(ByVal MES As String, ByVal ANNO As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = ""


    '    strMysql = "SELECT sum(importe) as Ingresos FROM vistacajamovimientos"
    '    strMysql += " WHERE TIPOMOVIMIENTO= 'INGRESO' and month(Fecha) =" & MES & " and year(fecha) = " & ANNO & ""

    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)
    '    ' MsgBox(strMysql)
    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function informeCajaMensualSalidas(ByVal MES As String, ByVal ANNO As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = ""

    '    strMysql = "SELECT sum(importe) as Salidas FROM vistacajamovimientos"
    '    strMysql += " WHERE TIPOMOVIMIENTO= 'SALIDA' and month(Fecha) =" & MES & " and year(fecha) = " & ANNO & ""

    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)
    '    'MsgBox(strMysql)
    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function
    ''---------------------------------------------------------------
    ''REPORTES


    'Public Function listarClientes() As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT Apellido, Nombre, NombreFantasia, Domicilio, Telefono, TelefonoLaboral, Localidad, Rubro, Ranking FROM cliente"
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

    'Public Function listarClientesyLocalidad(ByVal localidad As String) As DataTable

    '    Dim dt As New DataTable
    '    Dim strMysql As String = "SELECT Apellido, Nombre, NombreFantasia, Domicilio, Telefono, "
    '    strMysql += "TelefonoLaboral, Localidad, Rubro, Ranking FROM cliente "
    '    strMysql += "where localidad ='" & localidad & "'"

    '    'MsgBox(strMysql)
    '    Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, conexion)

    '    adaptador.Fill(dt)
    '    conexion.Close()

    '    Return dt

    'End Function

End Module
