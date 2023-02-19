Public Class FrmRetiroVehiculo

    Private Sub FrmRetiroVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = Today
    End Sub

    Private Sub BtnBusquedaOrdenReparacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusquedaOrdenReparacion.Click
        'MsgBox("Busco el vehiculo y cargo el dominio en el txt dominio y traigo la reparacion y la pongo en txtReparacion")
        Global_NombreVista = "VistaOrdenReparacionREPARADOS"
        FrmBusquedaOrdenReparacion.MdiParent = MDIMenu
        FrmBusquedaOrdenReparacion.Show()
        FrmBusquedaOrdenReparacion.BtnCopiarRetiroVehPagado.Visible = True
    End Sub

    Private Sub BtnRegistrarSalidaSinPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrarSalidaSinPago.Click

        If TxtCliente.Text = "" Or TxtDominio.Text = "" Then
            MsgBox("Faltan datos para dar salida al vehiculo")
        Else
            Dim miReparacion As New ClassReparacionT
            Dim miVehiculo As New ClassVehiculoT
            'MsgBox("Cambio estado de vehiculo y dejo el monto de la reparacion en pendiente en cliente")
            'Cambio estado de vehiculo a Reparado
            Dim sql As String = ""
            miReparacion.IdReparacion = TxtReparacion.Text
            miReparacion.Dominio = TxtDominio.Text
            miReparacion.FechaSalida = DateTimePicker1.Text
            miReparacion.Estado = "RETIRADO SIN PAGO"
            Try
                Dim miConexion1 As New GestionMySQL
                sql = "UPDATE vehiculo SET "
                sql += "estado = 'Fuera de Taller' "
                sql += "WHERE Dominio = '" & miReparacion.Dominio & "'; "
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
                sql += "FechaSalida = STR_TO_DATE('" & miReparacion.FechaSalida & "','%d/%m/%Y'), "
                sql += "estado = '" & miReparacion.Estado & "'"
                sql += "WHERE idReparacion = " & miReparacion.IdReparacion & "; "
                'MsgBox(sql)
                miConexion2.EjecutarSQL(sql)
                miConexion2.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Global_NombreVista = "VistaOrdenReparacionRETIRADOSsinPAGOS"
        FrmBusquedaOrdenReparacion.MdiParent = MDIMenu
        FrmBusquedaOrdenReparacion.Show()
        FrmBusquedaOrdenReparacion.BtnEliminarRetiro.Visible = True
        Global_Dominio = TxtDominio.Text
    End Sub
End Class