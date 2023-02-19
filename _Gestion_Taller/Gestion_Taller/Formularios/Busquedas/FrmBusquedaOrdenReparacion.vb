Public Class FrmBusquedaOrdenReparacion

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miVenta As New ClassVenta
    Dim miCliente As New ClassCliente
    Dim miReparacion As New ClassReparacionT
    Dim AnulaVehiculo As New ClassVehiculoT
    Dim AnulaReparacion As New ClassReparacionT
    Dim miConeccion As New GestionMySQL
    Dim NombreVista As String

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDatagrid()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LlenarDatagrid()
    End Sub

    Private Sub LlenarDatagrid()
        'MsgBox(Global_NombreVista)
        dt = miConeccion.ConsultarTabla(Global_NombreVista)
        DataGridViewOrdenRepa.DataSource = dt
        DataGridViewOrdenRepa.Columns(0).HeaderText = "IdReparacion"
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReparacion.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo(Global_NombreVista, "IdReparacion", TxtReparacion.Text)
        DataGridViewOrdenRepa.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtRazonsocial_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtDominio.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo(Global_NombreVista, "Dominio", TxtDominio.Text)
        DataGridViewOrdenRepa.DataSource = tabla
        miConeccion.Dispose()
    End Sub

    Private Sub TxtApellido_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtCliente.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo(Global_NombreVista, "IdCliente", TxtCliente.Text)
        DataGridViewOrdenRepa.DataSource = tabla
        miConeccion.Dispose()
    End Sub
    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TxtCliente.Clear()
        TxtDominio.Clear()
        TxtReparacion.Clear()
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarSalidaTaller.Click
        If DataGridViewOrdenRepa.RowCount > 0 Then
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(0).Value) Then
                miReparacion.IdReparacion = ""
            Else
                miReparacion.IdReparacion = DataGridViewOrdenRepa.SelectedCells(0).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(1).Value) Then
                miReparacion.Dominio = ""
            Else
                miReparacion.Dominio = DataGridViewOrdenRepa.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(2).Value) Then
                miCliente.IdCliente = ""
            Else
                miCliente.IdCliente = DataGridViewOrdenRepa.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(3).Value) Then
                miCliente.RazonSocial = ""
            Else
                miCliente.RazonSocial = DataGridViewOrdenRepa.SelectedCells(3).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(4).Value) Then
                miCliente.Apellido = ""
            Else
                miCliente.Apellido = DataGridViewOrdenRepa.SelectedCells(4).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(5).Value) Then
                miCliente.Nombre = ""
            Else
                miCliente.Nombre = DataGridViewOrdenRepa.SelectedCells(5).Value
            End If
            '
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmSalidaTaller.TxtDominio.Text = miReparacion.Dominio
            FrmSalidaTaller.LblIdOrdenReparacion.Text = miReparacion.IdReparacion
            FrmSalidaTaller.TxtCliente.Text = miCliente.IdCliente
            FrmSalidaTaller.LblCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnCopiarRetiroVehPagado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarRetiroVehPagado.Click
        If DataGridViewOrdenRepa.RowCount > 0 Then
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(0).Value) Then
                miReparacion.IdReparacion = ""
            Else
                miReparacion.IdReparacion = DataGridViewOrdenRepa.SelectedCells(0).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(1).Value) Then
                miReparacion.Dominio = ""
            Else
                miReparacion.Dominio = DataGridViewOrdenRepa.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(2).Value) Then
                miCliente.IdCliente = ""
            Else
                miCliente.IdCliente = DataGridViewOrdenRepa.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(3).Value) Then
                miCliente.RazonSocial = ""
            Else
                miCliente.RazonSocial = DataGridViewOrdenRepa.SelectedCells(3).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(4).Value) Then
                miCliente.Apellido = ""
            Else
                miCliente.Apellido = DataGridViewOrdenRepa.SelectedCells(4).Value
            End If
            '
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(5).Value) Then
                miCliente.Nombre = ""
            Else
                miCliente.Nombre = DataGridViewOrdenRepa.SelectedCells(5).Value
            End If
            '
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmRetiroVehiculo.TxtDominio.Text = miReparacion.Dominio
            FrmRetiroVehiculo.TxtReparacion.Text = miReparacion.IdReparacion
            FrmRetiroVehiculo.LblIdCliente.Text = miCliente.IdCliente
            FrmRetiroVehiculo.TxtCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnImprimirPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirPresupuesto.Click
        Global_numeroReparacion = 0
        Dim miReparacion As New ClassReparacionT
        If DataGridViewOrdenRepa.RowCount > 0 Then
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(0).Value) Then
                miReparacion.IdReparacion = "0"
            Else
                miReparacion.IdReparacion = DataGridViewOrdenRepa.SelectedCells(0).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Obtengo el idpresupuesto del grid y lo asigno al la 
            'variable global  que se pasa por parametro para impreimir 
            'el PRESUPUESTO
            Global_numeroReparacion = miReparacion.IdReparacion
            FrmOrdenReparacion.MdiParent = MDIMenu
            FrmOrdenReparacion.Show()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
            MsgBox("Seleccione una orden de reparación")
        End If
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Dim AnulaMiGestionMySQL As New GestionMySQL
        Dim AnulaMiGestionMySQL2 As New GestionMySQL
        Dim AnulaMiVehiculo As New ClassVehiculoT
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        AnulaMiVehiculo.Estado = "Fuera de Taller"

        If DataGridViewOrdenRepa.RowCount > 0 Then
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(0).Value) Then
                AnulaReparacion.IdReparacion = "0"
            Else
                AnulaReparacion.IdReparacion = DataGridViewOrdenRepa.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(1).Value) Then
                AnulaMiVehiculo.Dominio = "0"
            Else
                AnulaMiVehiculo.Dominio = DataGridViewOrdenRepa.SelectedCells(1).Value
            End If


            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(10).Value) Then
                AnulaReparacion.Estado = "0"
            Else
                AnulaReparacion.Estado = DataGridViewOrdenRepa.SelectedCells(10).Value
            End If

            MsgBox("Orden de reparación " & AnulaReparacion.IdReparacion & vbNewLine &
                   "Dominio: " & AnulaMiVehiculo.Dominio)
        End If
        If AnulaReparacion.Estado = "INGRESADO" Then

            Dim resultado As DialogResult = MessageBox.Show("Está seguro de ANULAR LA ORDEN DE REPARACÓN Nº: " & AnulaReparacion.IdReparacion & "?", "Atención anulación de ORDEN DE REPARACIÓN ", MessageBoxButtons.YesNo)

            If resultado = Windows.Forms.DialogResult.Yes Then

                Try
                    sql1 = "DELETE FROM reparacion "
                    sql1 += "WHERE IdReparacion = " & AnulaReparacion.IdReparacion
                    'MsgBox(sql1)
                    AnulaMiGestionMySQL.EjecutarSQL(sql1)
                    AnulaMiGestionMySQL.Dispose()
                    'MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Eliminar Datos Reparacion")
                End Try

                '------------------------------------------------------------------
                Try
                    sql2 = "UPDATE vehiculo SET "
                    sql2 += "ESTADO = '" & AnulaMiVehiculo.Estado & "' "
                    sql2 += "WHERE Dominio = '" & AnulaMiVehiculo.Dominio & "'; "
                    'MsgBox(sql2)
                    AnulaMiGestionMySQL2.EjecutarSQL(sql2)
                    AnulaMiGestionMySQL2.Dispose()
                    MsgBox("Registrado", MsgBoxStyle.Information, "Orden de reparacón anulada correctamente")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos Vehiculos")
                End Try
                Me.Close()
            End If
        Else
            MsgBox("Solo se puede anular ordenes de reparacón con estado: INGRESADO")
        End If
        LlenarDatagrid()
    End Sub


    Private Sub BtnEliminarRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarRetiro.Click
        Dim AnulaMiGestionMySQL As New GestionMySQL
        Dim AnulaMiGestionMySQL2 As New GestionMySQL
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        AnulaVehiculo.Estado = "Fuera de Taller"

        If DataGridViewOrdenRepa.RowCount > 0 Then
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(0).Value) Then
                AnulaReparacion.IdReparacion = "0"
            Else
                AnulaReparacion.IdReparacion = DataGridViewOrdenRepa.SelectedCells(0).Value
            End If
            '--
            If IsDBNull(DataGridViewOrdenRepa.SelectedCells(1).Value) Then
                AnulaReparacion.Dominio = "0"
            Else
                AnulaReparacion.Dominio = DataGridViewOrdenRepa.SelectedCells(1).Value
            End If
            '--
            Dim miReparacion As New ClassReparacionT
            Dim miVehiculo As New ClassVehiculoT
            'MsgBox("Cambio estado de vehiculo y dejo el monto de la reparacion en pendiente en cliente")
            'Cambio estado de vehiculo a Reparado
            Dim sql As String = ""

            AnulaReparacion.FechaSalida = "01-01-2000"
            AnulaReparacion.Estado = "REPARADO"

            Try
                Dim miConexion1 As New GestionMySQL
                sql = "UPDATE vehiculo SET "
                sql += "estado = 'En Taller' "
                sql += "WHERE Dominio = '" & AnulaReparacion.Dominio & "'; "
                'MsgBox(sql)
                miConexion1.EjecutarSQL(sql)
                miConexion1.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
            End Try
            '
            Try
                Dim miConexion2 As New GestionMySQL
                sql = "UPDATE reparacion SET "
                sql += "FechaSalida = STR_TO_DATE('" & AnulaReparacion.FechaSalida & "','%d/%m/%Y'), "
                sql += "Estado = '" & AnulaReparacion.Estado & "' "
                sql += "WHERE idReparacion = " & AnulaReparacion.IdReparacion & "; "
                'MsgBox(sql)
                miConexion2.EjecutarSQL(sql)
                miConexion2.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
            End Try
        End If
    End Sub
End Class