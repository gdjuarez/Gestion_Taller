Public Class FrmEntradaTaller

    Private Sub BtnAgregarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarVehiculo.Click
        FrmBusquedaVehiculo.MdiParent = MDIMenu
        FrmBusquedaVehiculo.Show()
        FrmBusquedaVehiculo.BtnCopiarEntradaTaller.Visible = True
    End Sub

    Private Sub BtnAgregarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarCliente.Click
        FrmBusquedaCliente.MdiParent = MDIMenu
        FrmBusquedaCliente.Show()
        FrmBusquedaCliente.BtnCopiarEntradaTaller.Visible = True
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        If TxtCliente.Text = "" Or TxtVehiculo.Text = "" Or TxtDiagnostico.Text = "" Or TxtKilometros.Text = "" Then
            MsgBox("Es necesario que tenga todos los datos cargados")
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim miConexion As New GestionMySQL
            Dim miReparacion As New ClassReparacionT
            Dim miVehiculo As New ClassVehiculoT
            Dim sql As String = ""
            miReparacion.Dominio = TxtVehiculo.Text
            miReparacion.IdCliente = LblIdCliente.Text
            miReparacion.FechaEntrada = DTPEntradaTaller.Text
            miReparacion.DatosAveria = TxtDiagnostico.Text
            miVehiculo.Kilometros = TxtKilometros.Text
            miReparacion.Estado = "INGRESADO"
            miVehiculo.Estado = "En Taller"
            'IdReparacion, Dominio, IdCliente, FechaEntrada, DatosAveria, FechaReparacion, FechaSalida,// (en tabla vehiculo) Estado
            Try
                sql = "INSERT INTO reparacion ( Dominio, IdCliente, FechaEntrada, DatosAveria, estado) "
                sql += "VALUES ('" & miReparacion.Dominio & "','" & miReparacion.IdCliente & "',STR_TO_DATE('" & miReparacion.FechaEntrada & "','%d/%m/%Y'),'" & miReparacion.DatosAveria & "','" & miReparacion.Estado & "')"
                'MsgBox(sql)
                miGestionMySQL.EjecutarSQL(sql)
                miGestionMySQL.Dispose()
                'MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
            sql = ""
            '------------------------------------------------------------------
            Try
                sql = "UPDATE vehiculo SET "
                sql += "kilometros = '" & miVehiculo.Kilometros & "', "
                sql += "ESTADO = '" & miVehiculo.Estado & "' "
                sql += "WHERE Dominio = '" & miReparacion.Dominio & "'; "
                'MsgBox(sql)
                miConexion.EjecutarSQL(sql)
                miConexion.Dispose()
                MsgBox("Registrado", MsgBoxStyle.Information, "Insertar Datos")
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
            End Try
            'Envio a imprimir orden de reparacion
            obtengoNumeroReparacion()
            'MsgBox(Global_numeroReparacion)
            FrmOrdenReparacion.MdiParent = MDIMenu
            FrmOrdenReparacion.Show()
            Me.Close()
        End If
    End Sub

    Private Sub obtengoNumeroReparacion()
        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Global_numeroReparacion = 0
        '======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
        Dim sql As String
        sql = "SELECT MAX(idReparacion) as ultimoIdP FROM reparacion;"
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                Dim ultimoIdP As String = ""

                If IsDBNull(MiDataRow("ultimoIdP")) Then
                    Global_numeroReparacion = 0
                Else
                    Global_numeroReparacion = MiDataRow("ultimoIdP")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
    End Sub

    Private Sub TxtVehiculo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVehiculo.TextChanged
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        Dim dtmitabla As New DataTable
        dtmitabla = miGestionMySQL.BuscarenTablaEscribo("Vehiculo", "Dominio", TxtVehiculo.Text)
        Dim estado As String = ""
        For Each MiDataRow As DataRow In dtmitabla.Rows
            If IsDBNull(MiDataRow("estado")) Then
                estado = "Fuera de Taller"
            Else
                estado = MiDataRow("estado")
            End If
            'MsgBox(estado)
        Next
        If estado = "En Taller" Then
            MsgBox("EL DOMINIO ingresado pertenece a un Vehiculo en taller", 16, "Acceso denegado...")
        Else
            BtnAceptar.Enabled = True
            MsgBox("Actualizar kilometraje de vehiculo")
        End If
    End Sub

    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Global_NombreVista = "VistaOrdenReparacion"
        FrmBusquedaOrdenReparacion.MdiParent = MDIMenu
        FrmBusquedaOrdenReparacion.Show()
        FrmBusquedaOrdenReparacion.BtnEliminar.Visible = True
        Me.Close()
    End Sub
End Class