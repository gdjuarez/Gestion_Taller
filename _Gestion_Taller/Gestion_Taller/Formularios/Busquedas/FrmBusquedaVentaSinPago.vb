Public Class FrmBusquedaVentaSinPago

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miVenta As New ClassVenta
    Dim miCliente As New ClassCliente
    Dim miConeccion As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDatagrid()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LlenarDatagrid()
    End Sub

    Private Sub LlenarDatagrid()
        dt = miConeccion.ConsultarTabla("vistaVentasSinpago")
        DataGridViewVentas.DataSource = dt
        DataGridViewVentas.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVentas.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentasSinpago", "codigo", TxtVentas.Text)
        DataGridViewVentas.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtRazonsocial_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtRazonsocial.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentasSinpago", "RazonSocial", TxtRazonsocial.Text)
        DataGridViewVentas.DataSource = tabla
        miConeccion.Dispose()
    End Sub

    Private Sub TxtApellido_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtApellido.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentasSinpago", "Apellido", TxtApellido.Text)
        DataGridViewVentas.DataSource = tabla
        miConeccion.Dispose()
    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Abrir VentaImpresion y cargar la venta")
        Global_numeroVenta = 0
        If DataGridViewVentas.RowCount > 0 Then
            If IsDBNull(DataGridViewVentas.SelectedCells(0).Value) Then
                miVenta.IdVenta = "0"
            Else
                miVenta.IdVenta = DataGridViewVentas.SelectedCells(0).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Obtengo el idVenta del grid y lo asigno al la 
            'variable global  que se pasa por parametro para imprimir 
            'la venta
            Global_numeroVenta = miVenta.IdVenta
            'MsgBox("IMPRIMIR VENTA N°: " & Global_numeroVenta)
            FacturaImpresion.MdiParent = MDIMenu
            FacturaImpresion.Show()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
            MsgBox("Seleccione un Presupuesto")
        End If
        Me.Close()
    End Sub

    Private Sub BtnCopiaCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiaCaja.Click
        Dim codigo, idreparacion As Integer
        Dim total As Decimal
        Dim dominio As String = ""
        If DataGridViewVentas.RowCount > 0 Then
            codigo = DataGridViewVentas.SelectedCells(0).Value
            If IsDBNull(DataGridViewVentas.SelectedCells(1).Value) Then
                idreparacion = "0"
            Else
                idreparacion = DataGridViewVentas.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DataGridViewVentas.SelectedCells(2).Value) Then
                dominio = ""
            Else
                dominio = DataGridViewVentas.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DataGridViewVentas.SelectedCells(8).Value) Then
                total = "0"
            Else
                total = DataGridViewVentas.SelectedCells(8).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            frmCaja.Txtnumero.Text = codigo
            frmCaja.TxtDescripcion.Text = idreparacion
            frmCaja.TxtImporte.Text = total
            frmCaja.LblDominio.Text = dominio
            frmCaja.miReparacion.IdReparacion = idreparacion
            frmCaja.miReparacion.Dominio = dominio
            frmCaja.miVentas.IdVenta = codigo
            frmCaja.miVentas.Importe = total
            frmCaja.BtnRegistrar.Visible = False
            frmCaja.BtnINGRESO.PerformClick()
            frmCaja.Panel5.Enabled = False
            frmCaja.TxtImporte.ReadOnly = True

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub
End Class