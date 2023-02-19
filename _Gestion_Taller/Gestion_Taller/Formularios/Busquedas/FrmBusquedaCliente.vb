Public Class FrmBusquedaCliente

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miCliente As New ClassCliente
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Private Sub iniciar()
        dt = miGestionMySQL.ConsultarTabla("cliente")
        DataGridViewClientes.DataSource = dt
        TxtClientes.Text = ""
    End Sub

    Private Sub TxtClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClientes.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Cliente", "RazonSocial", TxtClientes.Text)
        DataGridViewClientes.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        iniciar()
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPresupuesto.Click
        If DataGridViewClientes.RowCount > 0 Then
            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmPresupuestos.LblIdCliente.Text = miCliente.IdCliente
            FrmPresupuestos.TxtRazonSocial.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub btnCopiarVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarVentas.Click
        If DataGridViewClientes.RowCount > 0 Then
            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmSalidaTaller.LblIdOrdenReparacion.Text = miCliente.IdCliente
            FrmSalidaTaller.TxtCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnCopiarEntradaTaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarEntradaTaller.Click
        If DataGridViewClientes.RowCount > 0 Then
            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmEntradaTaller.LblIdCliente.Text = miCliente.IdCliente
            FrmEntradaTaller.TxtCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAltaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAltaCliente.Click
        frmClientes.MdiParent = MDIMenu
        frmClientes.Show()
        frmClientes.BtnAddClienteEntrada.Visible = True
        Me.Close()
    End Sub

End Class