
Public Class frmCaja

    Dim dtInicial As New DataTable
    Dim dtCaja As New DataTable
    Public miReparacion As New ClassReparacionT
    Public miVentas As New ClassVenta

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicio()
        flag = "C"
        CalcularSaldo()
    End Sub

    Private Sub Limpiar()
        ' TxtSaldoInicial.Text = "0"
        ComboBoxComprobante.Text = "DOCUMENTO INTERNO"
        TxtDescripcion.Text = ""
        Txtnumero.Text = ""
        TxtImporte.Text = ""
        LblDominio.Text = ""
    End Sub

    Private Sub Inicio()
        Limpiar()
        CalcularSaldoInicial()
        Dim conectar As New GestionMySQL
        dtCaja = conectar.consultarMovimientosCaja(DateTimePickerFecha.Text)
        DataGridViewCaja.DataSource = dtCaja
    End Sub

    Private Sub CalcularSaldoInicial()
        Dim miConexion As New GestionMySQL
        Dim dtSaldoInicial As New DataTable
        Dim saldoIni As String = "0,00"
        dtSaldoInicial = miConexion.ConsultarSaldoInicial(DateTimePickerFecha.Text)
        For Each MiDataRow As DataRow In dtSaldoInicial.Rows
            If IsDBNull(MiDataRow("saldoinicial")) Then
                saldoIni = "0,00"
            Else
                saldoIni = MiDataRow("saldoinicial")
            End If
        Next
        Me.TxtSaldoInicial.Text = saldoIni
    End Sub

    Private Sub CalcularSaldo()
        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Dim miConexion2 As New GestionMySQL
        Dim dtTabla2 As New DataTable
        '-----------------------------suma salida---------------------------
        Dim sql As String
        sql = "SELECT SUM(ImporteSalida) as salida FROM vistacajamovimientos "
        sql += "WHERE Fecha = STR_TO_DATE('" & DateTimePickerFecha.Text & "' ,'%d/%m/%Y') "
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                If IsDBNull(MiDataRow("salida")) Then
                    TxtsumaSalida.Text = "0,00"
                Else
                    TxtsumaSalida.Text = MiDataRow("salida")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
        '-----------------------------suma INGRESOS---------------------------
        Dim sql2 As String
        sql2 = "SELECT SUM(ImporteIngreso) as ingreso FROM vistacajamovimientos "
        sql2 += "WHERE Fecha = STR_TO_DATE('" & DateTimePickerFecha.Text & "' ,'%d/%m/%Y') "
        miConexion2.EjecutarSQL(sql2)
        dtTabla2 = miConexion2.Consulta(sql2)
        Try
            For Each MiDataRow As DataRow In dtTabla2.Rows
                If IsDBNull(MiDataRow("ingreso")) Then
                    TxtsumaIngreso.Text = "0,00"
                Else
                    TxtsumaIngreso.Text = MiDataRow("ingreso")
                End If
            Next

        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion2.Dispose()
        '-----------------------------CALCULA SALDO---------------------------
        Dim saldo As Decimal = 0
        Format(saldo, "##,##0.00")
        Dim ingresos, salidas, saldoinicial As Decimal
        ingresos = CDbl(TxtsumaIngreso.Text)
        salidas = CDbl(TxtsumaSalida.Text)
        saldoinicial = CDbl(TxtSaldoInicial.Text)
        saldo = CDbl((saldoinicial + ingresos) - salidas)
        TxtSaldo.Text = saldo.ToString("0.00")
    End Sub

    Private Sub DateTimePickerFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerFecha.ValueChanged
        Me.Size = New System.Drawing.Size(640, 581)
        Inicio()
        CalcularSaldoInicial()
        CalcularSaldo()
        ' MsgBox("Activar no poder grabar distinta FECHA")
        '------------evita grabar dia anterior O POSTERIOR en caja----OK
        If DateTimePickerFecha.Text <> Date.Today Then
            Panel1.Enabled = False
            ComboBoxComprobante.Enabled = False
            Txtnumero.Enabled = False
            TxtDescripcion.Enabled = False
            TxtImporte.Enabled = False
            BtnRegistrar.Enabled = False
            BtnArqueo.Enabled = False
        Else
            Panel1.Enabled = True
            ComboBoxComprobante.Enabled = True
            Txtnumero.Enabled = True
            TxtDescripcion.Enabled = True
            TxtImporte.Enabled = True
            BtnRegistrar.Enabled = True
            BtnArqueo.Enabled = True
        End If
    End Sub

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        Registrar()
    End Sub

    Private Sub BtnRegistrarRepImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrarRepImp.Click
        Registrar()
        Cambioestado()
        Panel5.Enabled = True
        BtnRegistrar.Visible = True
        TxtImporte.ReadOnly = False
        Inicio()
    End Sub

    Private Sub BtnArqueo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArqueo.Click
        If flag = "C" Then
            FrmArqueo.MdiParent = MDIMenu
            FrmArqueo.Show()
            flag = "A"
        Else
            FrmArqueo.Close()
            flag = "C"
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnINGRESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnINGRESO.Click
        BtnSALIDA.FlatStyle = FlatStyle.Standard
        BtnSALIDA.ForeColor = Color.Gray
        LblIngresoEgreso.ForeColor = Color.Green
        LblIngresoEgreso.Text = "INGRESO"
        BtnINGRESO.ForeColor = Color.Green
        BtnINGRESO.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub BtnSALIDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSALIDA.Click
        BtnINGRESO.FlatStyle = FlatStyle.Standard
        BtnINGRESO.ForeColor = Color.Gray
        LblIngresoEgreso.ForeColor = Color.Red
        LblIngresoEgreso.Text = "SALIDA"
        BtnSALIDA.ForeColor = Color.Red
        BtnSALIDA.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub TxtSaldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaldo.TextChanged
        If TxtSaldo.Text < 0 Then
            TxtSaldo.ForeColor = Color.Red
        Else
            TxtSaldo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImporte.KeyPress
        Dim numero As Decimal
        Dim cadena As String = ""
        Try
            cadena = TxtImporte.Text
            numero = Convert.ToDecimal(e.KeyChar.ToString)
        Catch ex As Exception
            If e.KeyChar <> "," Or e.KeyChar.Equals(vbBack) Then
                e.Handled = True
            Else
                If (cadena.LastIndexOf(",") > 0) Then
                    e.Handled = True
                End If
            End If
        End Try
    End Sub

    Private Sub Cambioestado()
        'MsgBox("Cambio estado de vehiculo y dejo el monto de la reparacion en pendiente en cliente")
        'Cambio estado de vehiculo a Reparado
        Dim sql As String = ""
        Try
            Dim miConexion1 As New GestionMySQL
            sql = "UPDATE reparacion SET "
            sql += "Estado = 'RETIRADO CON PAGO' "
            sql += "WHERE dominio = '" & miReparacion.Dominio & "'; "
            'MsgBox(sql)
            miConexion1.EjecutarSQL(sql)
            miConexion1.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
        End Try
        '
        Try
            Dim miConexion3 As New GestionMySQL
            sql = "UPDATE ventas SET "
            sql += "Pagado = 'SI' "
            sql += "WHERE idVentas = " & miVentas.IdVenta & "; "
            'MsgBox(sql)
            miConexion3.EjecutarSQL(sql)
            miConexion3.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
        End Try
    End Sub

    Private Sub Registrar()
        If TxtImporte.Text = "" Then
            MsgBox("Ingrese el importe  ")
        Else
            Dim meConecto As New GestionMySQL
            Dim meConecto2 As New GestionMySQL
            Dim meConecto3 As New GestionMySQL
            Dim dtTabla As New DataTable
            Dim miCaja As New ClassCaja
            Dim sqlcaja As String = ""
            ' idCajaMov, tipoMovimiento, Descripcion, tipoComprobante, serienumero, Importe
            Dim sql As String = ""
            miCaja.TipoMovimiento = LblIngresoEgreso.Text.Trim
            miCaja.Descripcion = TxtDescripcion.Text.Trim
            miCaja.TipoComprobante = ComboBoxComprobante.Text.Trim
            miCaja.Serienumero = Txtnumero.Text.Trim
            miCaja.Importe = Convert.ToDecimal(TxtImporte.Text)
            ' MsgBox(miCaja.Importe)
            miCaja.Ingreso = 0
            miCaja.Egreso = 0
            If LblIngresoEgreso.Text = "INGRESO" Then
                miCaja.Ingreso = miCaja.Importe
            ElseIf LblIngresoEgreso.Text = "SALIDA" Then
                miCaja.Egreso = miCaja.Importe
            End If
            sql = "INSERT INTO cajamov (tipoMovimiento, Descripcion, tipoComprobante, serienumero, ingreso,egreso)"
            sql += "VALUES ('" & miCaja.TipoMovimiento & "','" & miCaja.Descripcion & "','" & miCaja.TipoComprobante & ""
            sql += "','" & miCaja.Serienumero & "'," & Replace(miCaja.Ingreso, ",", ".") & "," & Replace(miCaja.Egreso, ",", ".") & ")"
            Try
                meConecto.EjecutarSQL(sql)
                MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            meConecto.Dispose()
            '======== Obtengo el ULTIMO CODMOV GRABADO en  tabla cajamov (autoincremental)==================
            Dim sql2 As String
            sql2 = "SELECT MAX(idCajaMov) as ultimoCodmov FROM cajamov; "
            meConecto2.EjecutarSQL(sql2)
            dtTabla = meConecto2.Consulta(sql2)
            Try
                For Each MiDataRow As DataRow In dtTabla.Rows
                    If IsDBNull(MiDataRow("ultimoCodmov")) Then
                        miCaja.CodMovCaja = 0
                    Else
                        miCaja.CodMovCaja = MiDataRow("ultimoCodmov")
                    End If
                Next
                ' MsgBox()
            Catch ex As Exception
                MsgBox("error" + ex.ToString)
            End Try
            meConecto2.Dispose()
            '============================================================================================
            '----------------------- DEBE GRABAR EN LA TABLA CAJA ---------------------------
            'codCaja, codMovCaja, Fecha
            ' miCaja.CodMovCaja =Lblcodmov.Text
            miCaja.Fecha = DateTimePickerFecha.Text.Trim
            miCaja.Operador = usuarioGlobal

            sqlcaja = "INSERT INTO caja (codMovCaja, Fecha,operador)"
            sqlcaja += "VALUES (" & miCaja.CodMovCaja & ", STR_TO_DATE('" & miCaja.Fecha & "','%d/%m/%Y'),'" & miCaja.Operador & "')"
            Try
                meConecto3.EjecutarSQL(sqlcaja)
                ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            meConecto3.Dispose()
            '=========================================
        End If
        Inicio()
        CalcularSaldo()

    End Sub

    Private Sub BtnRepImpagas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepImpagas.Click
        FrmBusquedaVentaSinPago.MdiParent = MDIMenu
        FrmBusquedaVentaSinPago.Show()
    End Sub

End Class