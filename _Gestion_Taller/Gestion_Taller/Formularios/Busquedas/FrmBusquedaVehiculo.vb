Public Class FrmBusquedaVehiculo

    Dim dt As New DataTable
    Dim tabla As New DataTable
    'Dim miCliente As New ClassCliente
    Dim miVehiculo As New ClassVehiculoT
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Private Sub iniciar()
        dt = miGestionMySQL.ConsultarTabla("vehiculo")
        DataGridViewVehiculo.DataSource = dt
        TxtVehiculo.Text = ""
    End Sub

    Private Sub TxtClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVehiculo.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarenTablaEscribo("vehiculo", "dominio", TxtVehiculo.Text)
        DataGridViewVehiculo.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        iniciar()
    End Sub

    Private Sub BtnCopiarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarVehiculo.Click
        If DataGridViewVehiculo.RowCount > 0 Then
            miVehiculo.Dominio = DataGridViewVehiculo.SelectedCells(0).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmEntradaTaller.TxtVehiculo.Text = miVehiculo.Dominio
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddVehiculo.Click
        FrmVehiculo.MdiParent = MDIMenu
        FrmVehiculo.Show()
        FrmVehiculo.BtnAddVehiculoEntradaTaller.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnCopiarEntradaTaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarEntradaTaller.Click
        If DataGridViewVehiculo.RowCount > 0 Then
            miVehiculo.Dominio = DataGridViewVehiculo.SelectedCells(0).Value
            If IsDBNull(DataGridViewVehiculo.SelectedCells(5).Value) Then
                miVehiculo.Kilometros = "0"
            Else
                miVehiculo.Kilometros = DataGridViewVehiculo.SelectedCells(5).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmEntradaTaller.TxtVehiculo.Text = miVehiculo.Dominio
            FrmEntradaTaller.TxtKilometros.Text = miVehiculo.Kilometros
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub
End Class