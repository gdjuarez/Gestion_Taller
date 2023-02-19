Public Class FrmSalidaTaller

    Dim dttabla As New DataTable
    Dim miArticulo As New ClassArticulo
    Dim miVenta As New ClassVenta
    Dim micaja As New ClassCaja
    Dim miReparacion As New ClassReparacionT
    Dim miVehiculo As New ClassVehiculoT

    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
        'ObtengoNumeroVenta()
        TxtBuscarCodigoBarra.Focus()
        'lblNumeroPedido.Text = Global_numeroVenta + 1
    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        FrmBusquedaArticulo.MdiParent = MDIMenu
        FrmBusquedaArticulo.Show()
        FrmBusquedaArticulo.btnCopiarVenta.Visible = True
    End Sub

    Private Sub BtnPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPresupuesto.Click
        FrmBusquedaPresupuesto.MdiParent = MDIMenu
        FrmBusquedaPresupuesto.Show()
        FrmBusquedaPresupuesto.btnCopiar.Visible = True
        BtnIngreso.Enabled = False
        BtnBorrar.Enabled = False
    End Sub

    Private Sub BtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngreso.Click
        If Txtcantidad.Text = "" Or TxtidProducto.Text = "" Or TxtImporte.Text = 0 Then
            MsgBox("INGRESE CANTIDAD Y ARTICULO")
        Else
            If Convert.ToInt32(Txtcantidad.Text) > Convert.ToInt32(TxtStock.Text) Then
                MsgBox("No existe la cantidad solicitada :Pedir Articulo" & vbNewLine &
                       "Stock Minimo = " & TxtStockminimo.Text & vbNewLine &
                       "Stock Actual = " & TxtStock.Text & vbNewLine &
                       "Cantidad Solicitada = " & Txtcantidad.Text)
            ElseIf TxtImporte.Text > 0 Then
                ' lleno el datagridview en el mismo orden que tengan las columnas
                Dim values() As Object = {Txtcantidad.Text, TxtidProducto.Text, Txtdescripcion.Text, txtprecioUnitario.Text, TxtImporte.Text}
                ' Añadimos una nueva fila al control DataGridView
                Dim index As Integer = DataGridViewSalidaTaller.Rows.Add()
                ' Referenciamos la nueva fila
                Dim currentRow As DataGridViewRow = DataGridViewSalidaTaller.Rows(index)
                ' Añadimos los valores a las celdas de la fila
                currentRow.SetValues(values)
                'limpio los textbox
                Txtcantidad.Text = 0
                TxtidProducto.Text = ""
                Txtdescripcion.Text = ""
                txtprecioUnitario.Text = 0
                TxtImporte.Text = 0
                TxtBuscarCodigoBarra.Text = 0
                'Uso funcion sumar para sumar la columna Importe
                TxtTotal.Text = Sumar("Importe", DataGridViewSalidaTaller).ToString("0.00")
            Else
                MsgBox("Ingrese CANTIDAD y ARTICULO")
            End If
        End If
    End Sub

    Public Sub IngresoVentaCaja(ByVal venta As String, ByVal importe As Decimal, ByVal fecha As String)
        Dim miconexion1 As New GestionMySQL
        Dim miVentaCaja As New ClassCaja
        Dim consultaMysql As String = ""
        miVentaCaja.TipoMovimiento = "INGRESO"
        miVentaCaja.Descripcion = "VENTA"
        miVentaCaja.TipoComprobante = "No valido como factura"
        miVentaCaja.Serienumero = venta
        miVentaCaja.Egreso = 0
        miVentaCaja.Ingreso = importe
        'MsgBox("importe Ingreso" & ": " & importeIngreso & ": " & "importe egreso" & ": " & importeEgreso)
        consultaMysql = "INSERT INTO cajamov (tipoMovimiento, Descripcion, tipoComprobante, serienumero, ingreso,egreso)"
        consultaMysql += "VALUES ('" & miVentaCaja.TipoMovimiento & "','" & miVentaCaja.Descripcion & "','" & miVentaCaja.TipoComprobante & "','" & miVentaCaja.Serienumero & "'," & Replace(miVentaCaja.Ingreso, ",", ".") & "," & Replace(miVentaCaja.Egreso, ",", ".") & ")"
        Try
            miconexion1.EjecutarSQL(consultaMysql)
            'MsgBox(consultaMysql)
            'MsgBox("Registro Guardado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        miconexion1.Dispose()
        '======== Obtengo el ULTIMO CODMOV GRABADO en  tabla cajamov (autoincremental)==================
        Dim miconexion2 As New GestionMySQL
        Dim sql As String = ""
        Sql = "SELECT MAX(idCajaMov) as ultimoCodmov FROM cajamov;"
        miconexion2.EjecutarSQL(sql)
        dttabla = miconexion2.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dttabla.Rows
                If IsDBNull(MiDataRow("ultimoCodmov")) Then
                    micaja.CodMovCaja = 0
                Else
                    micaja.CodMovCaja = MiDataRow("ultimoCodmov")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miconexion2.Dispose()
        '============================================================================================
        '----------------------- DEBE GRABAR EN LA TABLA CAJA ---------------------------
        Dim miconexion3 As New GestionMySQL
        Dim consultaMysqlcaja As String = ""
        micaja.Fecha = DateTimePicker1.Value
        consultaMysqlcaja = "INSERT INTO caja (codMovCaja, Fecha,operador)"
        consultaMysqlcaja += "VALUES (" & micaja.CodMovCaja & ", STR_TO_DATE('" & micaja.Fecha & "','%d/%m/%Y'),'" & usuarioGlobal & "')"
        Try
            miconexion3.EjecutarSQL(consultaMysqlcaja)
            ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        miconexion3.Dispose()
    End Sub

    Private Sub Grabo_clienteVenta()
        Dim encabezado As New GestionMySQL
        Dim clienteventa As New ClassVenta
        Dim sql As String
        clienteventa.IdCliente = TxtCliente.Text
        clienteventa.IdVenta = Global_numeroVenta
        Try
            sql = "INSERT INTO clienteventa (idVenta, idCliente)"
            sql += "VALUES (" & clienteventa.IdVenta & ",'" & clienteventa.IdCliente & "')"
            encabezado.EjecutarSQL(sql)
            encabezado.Dispose()
            'MsgBox("Registro Guardado clienteventa", MsgBoxStyle.Information)
        Catch ex As Exception
            ' MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ObtengoNumeroVenta()
        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Global_numeroVenta = 0
        '======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
        Dim sql As String
        sql = "SELECT MAX(idVentas) as ultimoIdv FROM Ventas;"
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                Dim ultimoIdP As String = ""
                Global_numeroVenta = MiDataRow("ultimoIdV")
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
    End Sub

    Private Sub Txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcantidad.TextChanged
        If IsNumeric(Txtcantidad.Text) Then
            If txtprecioUnitario.Text >= 0 Then
                TxtImporte.Text = CDec(txtprecioUnitario.Text * Txtcantidad.Text).ToString("0.00")
            Else
                MsgBox("Ingrese Articulo")
                Txtcantidad.Text = "0"
            End If
        Else
            MsgBox("Ingrese números")
        End If
    End Sub

    Private Sub TxtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImporte.TextChanged
        If IsNumeric(TxtImporte.Text) Then
            'nada XD
        Else
            MsgBox("Importe no válido")
        End If
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim rowToDelete As Integer
        rowToDelete = DataGridViewSalidaTaller.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If (rowToDelete > -1) Then
            DataGridViewSalidaTaller.Rows.RemoveAt(rowToDelete)
        End If
        'sumo nuevamente la columna importe porque saque un item
        TxtTotal.Text = Sumar("Importe", DataGridViewSalidaTaller)
    End Sub

    Private Sub TxtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStock.TextChanged
        'Dim cantidad As Integer
        'Int32.TryParse(plista7, cantidad)
        'If TxtStock.Text = "" Then
        'Else
        '    If TxtStock.Text < cantidad Then
        '        MsgBox("Pedir Articulo" & vbNewLine &
        '               "Stock Minimo = " & plista7 & vbNewLine &
        '               "Stock Actual = " & plista6)
        '    End If
        'End If
    End Sub

    Private Sub TxtBuscarCodigoBarra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarCodigoBarra.TextChanged
        ayudaLTC()
        If TxtBuscarCodigoBarra.Text <> "" Then
            'conecto
            Dim consulta As New GestionMySQL
            'uso funcion para buscar en tabla , columna y campo que return un Datatable 
            dttabla = consulta.BuscarArtStockID(TxtBuscarCodigoBarra.Text)
            DataGridViewBarra.DataSource = dttabla
            '----------------------------------------------------------------------------
            If DataGridViewBarra.RowCount > 1 Then
                If IsDBNull(DataGridViewBarra.SelectedCells(0).Value) Then
                    miArticulo.IdArticulo = "1"
                Else
                    miArticulo.IdArticulo = DataGridViewBarra.SelectedCells(0).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(1).Value) Then
                    miArticulo.Descripcion = ""
                Else
                    miArticulo.Descripcion = DataGridViewBarra.SelectedCells(1).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(3).Value) Then
                    miArticulo.PrecioVenta = "0"
                Else
                    miArticulo.PrecioVenta = DataGridViewBarra.SelectedCells(3).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(4).Value) Then
                    miArticulo.Marca = ""
                Else
                    miArticulo.Marca = DataGridViewBarra.SelectedCells(4).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(5).Value) Then
                    miArticulo.Foto = ""
                Else
                    miArticulo.Foto = DataGridViewBarra.SelectedCells(5).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(6).Value) Then
                    miArticulo.Rubro = ""
                Else
                    miArticulo.Rubro = DataGridViewBarra.SelectedCells(6).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(7).Value) Then
                    miArticulo.Stock = ""
                Else
                    miArticulo.Stock = DataGridViewBarra.SelectedCells(7).Value
                End If
                '
                If IsDBNull(DataGridViewBarra.SelectedCells(8).Value) Then
                    miArticulo.StockMinimo = "0"
                Else
                    miArticulo.StockMinimo = DataGridViewBarra.SelectedCells(8).Value
                End If
                calcularimporte()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.TxtidProducto.Text = miArticulo.IdArticulo
                Me.Txtdescripcion.Text = miArticulo.Descripcion
                Me.txtprecioUnitario.Text = miArticulo.PrecioVenta
                Me.TxtIdArticulo.Text = miArticulo.IdArticulo
                Me.TxtArticulo.Text = miArticulo.Descripcion
                Me.TxtPrecioVenta.Text = miArticulo.PrecioVenta
                Me.TxtMarca.Text = miArticulo.Marca
                Me.TxtImagen.Text = miArticulo.Foto
                Me.TxtStock.Text = miArticulo.Stock
                Me.TxtStockminimo.Text = miArticulo.StockMinimo
                Me.PictureBox1.ImageLocation = Me.TxtImagen.Text
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Ignore
            End If
        Else
            MsgBox("Ingrese CODIGO")
        End If
        Txtcantidad.Text = 1
        TxtImporte.Text = (Txtcantidad.Text * txtprecioUnitario.Text)
    End Sub

    Private Sub ayudaLTC()
        'vacio a cada cambio de letra el textbox
        Me.TxtidProducto.Text = ""
        Me.Txtdescripcion.Text = ""
        Me.txtprecioUnitario.Text = 0
        Me.TxtIdArticulo.Text = ""
        Me.TxtArticulo.Text = ""
        Me.TxtPrecioVenta.Text = ""
        Me.TxtMarca.Text = ""
        Me.TxtImagen.Text = ""
        Me.TxtStock.Text = ""
        Me.TxtStockminimo.Text = ""
        Me.PictureBox1.Image = Nothing
        calcularimporte()
    End Sub

    Private Sub calcularimporte()
        If Txtcantidad.Text = "" Or txtprecioUnitario.Text = "" Then
            TxtImporte.Text = "0"
        Else
            TxtImporte.Text = (Txtcantidad.Text * txtprecioUnitario.Text).ToString("0.00")
        End If
    End Sub

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click

        If LblIdOrdenReparacion.Text <> "Nº Ord Repa" Then
            '-----------------------------------------------------------------------------------------
            If DataGridViewSalidaTaller.RowCount = 0 Then
                MsgBox("Faltan datos " & vbNewLine & " para completar la operación")
                Txtcantidad.Select()
                Exit Sub
            Else
                Dim miconexion1 As New GestionMySQL
                Dim consultaMysql1 As String = ""
                miVenta.Fecha = DateTimePicker1.Value
                miVenta.Total = Me.TxtTotal.Text.Trim
                'ventaImporte = totalPedido

                If BtnVenta.Enabled = True Then
                    consultaMysql1 = "INSERT INTO ventas (fecha,total,Pagado)"
                    consultaMysql1 += "VALUES ( STR_TO_DATE('" & miVenta.Fecha & "' ,'%d/%m/%Y') ," & Replace(miVenta.Total, ",", ".") & ", 'NO')"
                    Try
                        miconexion1.EjecutarSQL(consultaMysql1)
                        'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try
                    miconexion1.Dispose()
                End If
            End If
            'MsgBox("busco el ultimo idPedido")
            ''======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
            ObtengoNumeroVenta()

            Grabo_clienteVenta()

            '============================================================================================
            'HAY QUE RECORRER EL DATAGRIED E IR GRABANDO EN LA
            'TABLA ventaarticulos
            'Tomar el idventas del lblNumeroPedido.text
            '( idVenta, idArticulo, Cantidad, PrecioUnitario, Importe )
            ''------------------------------------------------------------------------------------
            If DataGridViewSalidaTaller.RowCount = 0 Then
                MsgBox("Ingrese los datos " & vbNewLine & " de la venta")
                Txtcantidad.Select()
            Else
                Dim miconexion2 As New GestionMySQL
                Dim miconexion3 As New GestionMySQL
                'Dim idVta As Integer
                Dim consultaMysql2 As String = ""
                miVenta.IdVenta = Global_numeroVenta
                'ventaNumero = Global_numeroVenta
                If BtnVenta.Enabled = True Then
                    'con este ciclo recorro el datagridview
                    For Each row As DataGridViewRow In DataGridViewSalidaTaller.Rows
                        consultaMysql2 = "INSERT INTO ventaarticulos (idVenta,idArticulo,Cantidad,PrecioUnitario,Importe)"
                        consultaMysql2 += "VALUES (" & miVenta.IdVenta & ",'" & row.Cells(1).Value & "'," & row.Cells(0).Value & "," & Replace(row.Cells(3).Value, ",", ".") & "," & Replace(row.Cells(4).Value, ",", ".") & ")"
                        Try
                            miconexion2.EjecutarSQL(consultaMysql2)
                            'MsgBox(consultaMysql)
                            'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox(ex.ToString, MsgBoxStyle.Critical)
                        End Try
                        '--------------------------------------------------
                        '------TENGO QUE RESTAR LA CANTIDAD AL STOCK-->  Stock= stock - variable
                        'idArticulo, Stock, StockMinimo
                        Dim consultaMysql3 As String = ""
                        consultaMysql3 = "Update stockarticulos SET "
                        consultaMysql3 += "Stock = Stock -'" & row.Cells(0).Value & "' "
                        consultaMysql3 += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "
                        Try
                            miconexion3.EjecutarSQL(consultaMysql3)
                            'MsgBox(consultaMysql)
                            'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox(ex.ToString, MsgBoxStyle.Critical)
                        End Try
                        '-----------------------------------------------------
                    Next
                    miconexion2.Dispose()
                    miconexion3.Dispose()
                    MsgBox("Registro Guardado", MsgBoxStyle.Information)
                    'IngresoVentaCaja(miVenta.IdVenta, miVenta.Total, miVenta.Fecha)
                End If
            End If
            'Cambio estado de vehiculo a Reparado
            Dim sql As String = ""
            Dim miConexion4 As New GestionMySQL
            miReparacion.Dominio = TxtDominio.Text
            miReparacion.FechaReparacion = DateTimePicker1.Text
            miReparacion.IdReparacion = LblIdOrdenReparacion.Text
            miReparacion.Estado = "REPARADO"

            Try
                Dim miConexion5 As New GestionMySQL
                sql = "UPDATE reparacion SET "
                sql += "FechaReparacion = STR_TO_DATE('" & miReparacion.FechaReparacion & "','%d/%m/%Y'), "
                sql += "idVenta =  " & Global_numeroVenta & ",  "
                sql += "estado = '" & miReparacion.Estado & "'  "
                sql += "WHERE idReparacion = " & miReparacion.IdReparacion & "; "
                'MsgBox(sql)
                miConexion5.EjecutarSQL(sql)
                miConexion5.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
            End Try
            Me.Close()
        Else
            MsgBox("Para procesar la salida de taller es necesario cargar una " & vbNewLine & "ORDEN DE REPARACION", MsgBoxStyle.Critical, "Gestion TALLER GiF Sys®")
        End If

    End Sub

    Private Sub BtnBusquedaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusquedaCliente.Click
        Global_NombreVista = "VistaOrdenReparacionINGRESADOS"
        FrmBusquedaOrdenReparacion.MdiParent = MDIMenu
        FrmBusquedaOrdenReparacion.Show()
        FrmBusquedaOrdenReparacion.btnCopiarSalidaTaller.Visible = True
        Me.BtnPresupuesto.Enabled = True
    End Sub

    Private Sub TxtPresupuesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPresupuesto.TextChanged
        Dim miConexion As New GestionMySQL
        Dim dt As New DataTable
        dt = miConexion.Agrego_Presupuesto(TxtPresupuesto.Text)
        DataGridViewSalidaTaller.DataSource = dt
        TxtTotal.Text = Sumar("Importe", DataGridViewSalidaTaller).ToString("0.00")
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.TxtImporte.Text = 0
        Me.TxtidProducto.Text = ""
        Me.Txtdescripcion.Text = ""
        Me.txtprecioUnitario.Text = 0
        Me.TxtIdArticulo.Text = ""
        Me.TxtArticulo.Text = ""
        Me.TxtPrecioVenta.Text = ""
        Me.TxtMarca.Text = ""
        Me.TxtImagen.Text = ""
        Me.TxtStock.Text = ""
        Me.TxtStockminimo.Text = ""
        Me.PictureBox1.Image = Nothing
        Me.DataGridViewSalidaTaller.DataSource = Nothing
        Me.LblIdOrdenReparacion.Text = ""
        Me.TxtCliente.Clear()
        Me.TxtTotal.Clear()
        Me.TxtPresupuesto.Text = 0
    End Sub

    Private Sub LblIdCliente_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LblIdOrdenReparacion.TextChanged
        If LblIdOrdenReparacion.Text <> "Sin_Cliente" Then
            LblIdOrdenReparacion.ForeColor = Color.Black
        Else
            LblIdOrdenReparacion.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BtnAnulaSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnulaSalida.Click
        FrmBusquedaVenta.MdiParent = MDIMenu
        FrmBusquedaVenta.Show()
        FrmBusquedaVenta.BtnEliminar.Visible = True
        Me.Close()

    End Sub
End Class