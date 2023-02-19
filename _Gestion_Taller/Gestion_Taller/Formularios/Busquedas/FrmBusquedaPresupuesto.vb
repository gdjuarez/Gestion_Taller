Public Class FrmBusquedaPresupuesto

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miPresupuesto As New ClassPresupuesto
    Dim miCliente As New ClassCliente
    Dim miConeccion As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDatagrid()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LlenarDatagrid()
    End Sub

    Private Sub LlenarDatagrid()
        dt = miConeccion.ConsultarTabla("VistaPresupuestoCliente")
        DataGridViewPresupuestos.DataSource = dt
        DataGridViewPresupuestos.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPresupuestos.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarPresupuesto(TxtPresupuestos.Text)
        DataGridViewPresupuestos.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
        If DataGridViewPresupuestos.RowCount > 0 Then
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(0).Value) Then
                miPresupuesto.IdPresupuesto = ""
            Else
                miPresupuesto.IdPresupuesto = DataGridViewPresupuestos.SelectedCells(0).Value
            End If
            '
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(1).Value) Then
                miPresupuesto.Fecha = ""
            Else
                miPresupuesto.Fecha = DataGridViewPresupuestos.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(2).Value) Then
                miCliente.IdCliente = ""
            Else
                miCliente.IdCliente = DataGridViewPresupuestos.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(3).Value) Then
                miCliente.RazonSocial = ""
            Else
                miCliente.RazonSocial = DataGridViewPresupuestos.SelectedCells(3).Value
            End If
            '
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(4).Value) Then
                miCliente.Nombre = ""
            Else
                miCliente.Nombre = DataGridViewPresupuestos.SelectedCells(4).Value
            End If
            '
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(5).Value) Then
                miCliente.Apellido = ""
            Else
                miCliente.Apellido = DataGridViewPresupuestos.SelectedCells(5).Value
            End If
            '
            'If IsDBNull(DataGridViewPresupuestos.SelectedCells(6).Value) Then
            '    miPresupuesto.Total = "0"
            'Else
            '    miPresupuesto.Total = DataGridViewPresupuestos.SelectedCells(6).Value
            'End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmSalidaTaller.TxtPresupuesto.Text = miPresupuesto.IdPresupuesto
            'FrmSalidaTaller.TxtCliente.Text = miCliente.IdCliente
            'FrmSalidaTaller.LblCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnImprimirPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirPresupuesto.Click
        ' MsgBox("Abrir PresupuestoImpresion y cargar el presupuesto")
        Global_numeroPresupuesto = 0

        If DataGridViewPresupuestos.RowCount > 0 Then
            If IsDBNull(DataGridViewPresupuestos.SelectedCells(0).Value) Then
                miPresupuesto.IdPresupuesto = "0"
            Else
                miPresupuesto.IdPresupuesto = DataGridViewPresupuestos.SelectedCells(0).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Obtengo el idpresupuesto del grid y lo asigno al la 
            'variable global  que se pasa por parametro para impreimir 
            'el PRESUPUESTO
            Global_numeroPresupuesto = miPresupuesto.IdPresupuesto
            PresupuestoImpresion.MdiParent = MDIMenu
            PresupuestoImpresion.Show()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
            MsgBox("Seleccione un Presupuesto")
        End If
        Me.Close()
    End Sub
End Class