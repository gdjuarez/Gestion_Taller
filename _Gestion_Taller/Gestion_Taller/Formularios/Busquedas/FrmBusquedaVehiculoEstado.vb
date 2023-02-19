Public Class FrmBusquedaVehiculoEstado

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim dtestado As New DataTable
    Dim miVehiculo As New ClassVehiculoT
   
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciar()
        'CBestado.Text = "En Taller"
    End Sub

    Private Sub iniciar()
        dt = miGestionMySQL.ConsultarTabla("vehiculo")
        DataGridViewVehiculoEstado.DataSource = dt
        TxtVehiculo.Clear()
        CBestado.Text = "En Taller"
    End Sub

    Private Sub TxtClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVehiculo.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarenTablaEscribo("vehiculo", "dominio", TxtVehiculo.Text)
        DataGridViewVehiculoEstado.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub CBestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBestado.SelectedIndexChanged
        miVehiculo.Estado = CBestado.Text
        dtestado = miGestionMySQL.VehiculoEstado(miVehiculo.Estado)
        DataGridViewVehiculoEstado.DataSource = dtestado
        TxtVehiculo.Clear()
        CBestado.Text = ""
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        iniciar()
    End Sub
End Class