Public Class FrmBusquedaVenta

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miVenta As New ClassVenta
    Dim miCliente As New ClassCliente
    Dim miConeccion As New GestionMySQL
    Dim AnulaMiVenta As New ClassVenta
    Dim AnulaMireparacion As New ClassReparacionT

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDatagrid()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LlenarDatagrid()
    End Sub

    Private Sub LlenarDatagrid()
        dt = miConeccion.ConsultarTabla("vistaVentas")
        DataGridViewVentas.DataSource = dt
        DataGridViewVentas.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVentas.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentas", "codigo", TxtVentas.Text)
        DataGridViewVentas.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtRazonsocial_TextChanged(sender As Object, e As EventArgs) Handles TxtRazonsocial.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentas", "RazonSocial", TxtRazonsocial.Text)
        DataGridViewVentas.DataSource = tabla
        miConeccion.Dispose()
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentas", "Apellido", TxtApellido.Text)
        DataGridViewVentas.DataSource = tabla
        miConeccion.Dispose()
    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
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

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim AnulaMiGestionMySQL As New GestionMySQL
        Dim AnulaMiGestionMySQL2 As New GestionMySQL
        Dim AnulaMiVehiculo As New ClassVehiculoT
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        Dim RS As String = ""
        Dim Ape As String = ""
        Dim Nom As String = ""
        AnulaMiVehiculo.Estado = "Fuera de Taller"

        If DataGridViewVentas.RowCount > 0 Then
            If IsDBNull(DataGridViewVentas.SelectedCells(0).Value) Then
                AnulaMiVenta.IdVenta = "0"
            Else
                AnulaMiVenta.IdVenta = DataGridViewVentas.SelectedCells(0).Value
            End If
            '--
            If IsDBNull(DataGridViewVentas.SelectedCells(1).Value) Then
                AnulaMireparacion.IdReparacion = "0"
            Else
                AnulaMireparacion.IdReparacion = DataGridViewVentas.SelectedCells(1).Value
            End If
            '--
            If IsDBNull(DataGridViewVentas.SelectedCells(3).Value) Then
                RS = "0"
            Else
                RS = DataGridViewVentas.SelectedCells(3).Value
            End If
            '--
            If IsDBNull(DataGridViewVentas.SelectedCells(4).Value) Then
                Ape = "0"
            Else
                Ape = DataGridViewVentas.SelectedCells(4).Value
            End If
            '--
            If IsDBNull(DataGridViewVentas.SelectedCells(5).Value) Then
                Nom = "0"
            Else
                Nom = DataGridViewVentas.SelectedCells(5).Value
            End If

            '--
            If IsDBNull(DataGridViewVentas.SelectedCells(7).Value) Then
                AnulaMiVenta.Total = "0"
            Else
                AnulaMiVenta.Total = DataGridViewVentas.SelectedCells(7).Value
            End If

            '--
            If IsDBNull(DataGridViewVentas.SelectedCells(8).Value) Then
                AnulaMiVenta.Pagado = "0"
            Else
                AnulaMiVenta.Pagado = DataGridViewVentas.SelectedCells(8).Value
            End If

            Global_RazonSocialCliente = "" & RS & " " & Ape & " " & Nom
            Global_AnularVenta = AnulaMiVenta.IdVenta

            MsgBox("Salida de taller " & AnulaMiVenta.IdVenta & vbNewLine &
                   "Reparación: " & AnulaMireparacion.IdReparacion)
        End If
        If AnulaMiVenta.Pagado = "NO" Then
            MsgBox("Aca se anula")

            FrmAnulaVenta.MdiParent = MDIMenu
            FrmAnulaVenta.Show()
            FrmAnulaVenta.lblNumero.Text = AnulaMireparacion.IdReparacion
            FrmAnulaVenta.TxtTotal.Text = AnulaMiVenta.Total

        Else
            MsgBox("Solo se puede anular Salidas de Taller que no han sido abonadas")
        End If

        LlenarDatagrid()

    End Sub
End Class