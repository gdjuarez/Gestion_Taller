Public Class FrmPresupuestos
    Dim tabla As New DataTable
    Dim miArticulo As New ClassArticulo

    Private Sub FrmPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
        obtengonumeropresupuesto()
        TxtBuscarCodigoBarra.Focus()
        lblNumeroPresu.Text = Global_numeroPresupuesto + 1
    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        FrmBusquedaArticulo.MdiParent = MDIMenu
        FrmBusquedaArticulo.Show()
        FrmBusquedaArticulo.btnCopiarPresupuesto.Visible = True
    End Sub

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        FrmBusquedaCliente.MdiParent = MDIMenu
        FrmBusquedaCliente.Show()
        FrmBusquedaCliente.btnCopiarPresupuesto.Visible = True
    End Sub

    Private Sub BtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngreso.Click
        'Dim cantidad As Integer
        'Int32.TryParse(plista7, cantidad)
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
                Dim index As Integer = DataGridViewIngPedido.Rows.Add()
                ' Referenciamos la nueva fila
                Dim currentRow As DataGridViewRow = DataGridViewIngPedido.Rows(index)
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
                TxtTotal.Text = Sumar("Importe", DataGridViewIngPedido).ToString("0.00")
            Else
                MsgBox("Ingrese CANTIDAD y ARTICULO")
            End If
        End If
    End Sub

    Private Sub obtengonumeropresupuesto()
        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Global_numeroPresupuesto = 0
        '======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
        Dim sql As String
        sql = "SELECT MAX(idPresupuesto) as ultimoIdP FROM presupuestos;"
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                Dim ultimoIdP As String = ""

                If IsDBNull(MiDataRow("ultimoIdP")) Then
                    Global_numeroPresupuesto = 0
                Else
                    Global_numeroPresupuesto = MiDataRow("ultimoIdP")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
    End Sub

    Private Sub Txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcantidad.TextChanged
        If IsNumeric(Txtcantidad.Text) Then
            If txtprecioUnitario.Text >= 0 Then
                TxtImporte.Text = (txtprecioUnitario.Text * Txtcantidad.Text).ToString("0.00")
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
        rowToDelete = DataGridViewIngPedido.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If (rowToDelete > -1) Then
            DataGridViewIngPedido.Rows.RemoveAt(rowToDelete)
        End If
        'sumo nuevamente la columna importe porque saque un item
        TxtTotal.Text = Sumar("Importe", DataGridViewIngPedido).ToString("0.00")
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
            tabla = consulta.buscarArtStockID(TxtBuscarCodigoBarra.Text)
            DataGridViewBarra.DataSource = tabla
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
                'calcularimporte()
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
            MsgBox("Ingrese CODIGO DE BARRAS")
        End If
        Txtcantidad.Text = 1
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
            TxtImporte.Text = (txtprecioUnitario.Text * Txtcantidad.Text).ToString("0.00")
        End If
    End Sub

    Private Sub BtnPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPresupuesto.Click
        If LblIdCliente.Text <> "IdCliente" Then
            GraboPresupuesto()
            'MsgBox("Se creara presupuesto N°:" & Global_numeroPresupuesto & vbNewLine & "para el cliente " & TxtRazonSocial.Text)
        Else
            Dim respuesta As DialogResult = MessageBox.Show("Esta realizando un prespuesto sin CLIENTE. Quere continuar?",
                                                   "Atención", MessageBoxButtons.YesNo)
            If respuesta = Windows.Forms.DialogResult.Yes Then
                GraboPresupuesto()
            Else
                'Decide seguir sin cliente en el presupuesto
            End If
        End If
        Me.Close()
    End Sub

    Private Sub GraboPresupuesto()
        Dim miConexionEncabezado As New GestionMySQL
        Dim miConexionDetalle As New GestionMySQL
        Dim miPresupuesto As New ClassPresupuesto
        ' -----------------------------------------------------------------------------------------
        'Formato para la fecha 
        'para grabar
        'INSERT INTO mytabla (fecha) VALUES STR_TO_DATE(fecha, '%d/%m/%y')
        'para leer
        'SELECT id, DATE_FORMAT(fecha, '%d/%m/%y') AS fecha FROM mytabla;
        '-----------------------------------------------------------------------------------------
        If DataGridViewIngPedido.RowCount = 0 Then
            MsgBox("Faltan datos " & vbNewLine & " para completar el presupuesto")
            Txtcantidad.Select()
            Exit Sub
        Else
            Dim sql As String = ""
            'ventaImporte = totalPedido
            miPresupuesto.Fecha = DateTimePicker1.Value
            miPresupuesto.Total = Me.TxtTotal.Text.Trim
            If BtnPresupuesto.Enabled = True Then
                Try
                    sql = "INSERT INTO presupuestos (fecha, total)"
                    sql += "VALUES ( STR_TO_DATE('" & miPresupuesto.Fecha & "' ,'%d/%m/%Y') ," & Replace(miPresupuesto.Total, ",", ".") & ")"
                    miConexionEncabezado.EjecutarSQL(sql)
                    miConexionEncabezado.Dispose()

                    ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
            End If
        End If
        'MsgBox("busco el ultimo idPresupuesto")
        ''======== Obtengo el ULTIMO idpresupuesto tabla ventas(autoincremental)====================
        obtengonumeropresupuesto()
        'grabo cliente presupuesto con vencimiento
        Grabo_clientePresupesto()

        '============================================================================================
        'HAY QUE RECORRER EL DATAGRIED E IR GRABANDO EN LA
        'TABLA presupuestoarticulos
        'Tomar el idPresupuesto del lblNumeroPedido.text
        '( idPresupuesto, idArticulo, Cantidad, PrecioUnitario, Importe )
        ''------------------------------------------------------------------------------------
        If DataGridViewIngPedido.RowCount = 0 Then
            MsgBox("Ingrese los datos " & vbNewLine & " del presupueto")
            Txtcantidad.Select()
        Else
            Dim idPresu As Integer
            Dim sqlDetall As String = ""
            idPresu = Global_numeroPresupuesto
            If BtnPresupuesto.Enabled = True Then
                'con este ciclo recorro el datagridview
                For Each row As DataGridViewRow In DataGridViewIngPedido.Rows
                    sqlDetall = "INSERT INTO presupuestoarticulos (idPresupuesto,idArticulo,Cantidad,PrecioUnitario,Importe)"
                    sqlDetall += "VALUES (" & idPresu & ",'" & row.Cells(1).Value & "'," & row.Cells(0).Value & "," & Replace(row.Cells(3).Value, ",", ".") & "," & Replace(row.Cells(4).Value, ",", ".") & ")"
                    Try
                        miConexionDetalle.EjecutarSQL(sqlDetall)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try
                Next
                miConexionDetalle.Dispose()
                Dim fecha As String = DateTimePicker1.Text.Trim
            End If
        End If
        Me.Close()
        'IMPRIME TICKET ????
        Dim resultado As DialogResult = MessageBox.Show("Desea imprimir presupuesto?",
                                                        "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            PresupuestoImpresion.MdiParent = MDIMenu
            PresupuestoImpresion.Show()
        End If
    End Sub

    Private Sub Grabo_clientePresupesto()
        Dim encabezado As New GestionMySQL
        Dim clientepresu As New ClassPresupuesto
        Dim sql2 As String
        clientepresu.IdCliente = LblIdCliente.Text
        clientepresu.Vencimiento = ComboBoxValidez.Text
        clientepresu.IdPresupuesto = Global_numeroPresupuesto
        Try
            sql2 = "INSERT INTO clientepresupuesto (IdPresupuesto, idCliente, Vencimiento)"
            sql2 += "VALUES (" & clientepresu.IdPresupuesto & ",'" & clientepresu.IdCliente & "','" & clientepresu.Vencimiento & "')"
            encabezado.EjecutarSQL(sql2)
            encabezado.Dispose()
            ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
        Catch ex As Exception
            ' MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtprecioUnitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecioUnitario.TextChanged
        If Txtcantidad.Text = "" Or txtprecioUnitario.Text = "" Then
            TxtImporte.Text = "0"
        Else
            TxtImporte.Text = (txtprecioUnitario.Text * Txtcantidad.Text).ToString("0.00")
        End If
    End Sub



    Private Sub LblIdCliente_TextChanged(sender As Object, e As EventArgs) Handles LblIdCliente.TextChanged
        If LblIdCliente.Text <> "Sin_Cliente" Then
            LblIdCliente.ForeColor = Color.Black
        Else
            LblIdCliente.ForeColor = Color.Red
        End If
    End Sub
End Class