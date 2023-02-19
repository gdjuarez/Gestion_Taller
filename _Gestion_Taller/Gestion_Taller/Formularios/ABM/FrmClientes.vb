Public Class frmClientes
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miCliente As New ClassCliente

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenargrid()
        limpiar()
        inicio()
    End Sub
    Private Sub llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.consultarTabla("cliente")
        'con el dt devuelto lleno el datagriedview
        DGVClientes.DataSource = dtMitabla

    End Sub

    Private Sub Inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
        TxtIdCliente.Select()
    End Sub

    Private Sub Limpiar()
        TxtIdCliente.Text = ""
        TxtApellido.Clear()
        TxtNombre.Clear()
        TxtRazonSocial.Clear()
        TxtDomicilio.Clear()
        TxtCiudad.Text = "Mercedes"
        TxtProvincia.Text = "Buenos Aires"
        TxtCodigopostal.Text = "6600"
        TxtTelFijo.Clear()
        TxtTelCelular.Clear()
        TxtCuit.Text = "00-00000000-0"
        TxtEmail.Text = "@"
        TxtObservaciones.Clear()
        InHabilitaTXT()

    End Sub

    Private Sub InhabilitaTXT()
        TxtIdCliente.BackColor = Color.LightGreen
        TxtApellido.BackColor = Color.LightGreen
        TxtNombre.BackColor = Color.LightGreen
        TxtRazonSocial.BackColor = Color.LightGreen
        TxtDomicilio.BackColor = Color.LightGreen
        TxtCiudad.BackColor = Color.LightGreen
        TxtProvincia.BackColor = Color.LightGreen
        TxtCodigopostal.BackColor = Color.LightGreen
        TxtTelFijo.BackColor = Color.LightGreen
        TxtTelCelular.BackColor = Color.LightGreen
        TxtCuit.BackColor = Color.LightGreen
        TxtEmail.BackColor = Color.LightGreen
        TxtObservaciones.BackColor = Color.LightGreen

        TxtIdCliente.ReadOnly = True
        TxtApellido.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtRazonSocial.ReadOnly = True
        TxtDomicilio.ReadOnly = True
        TxtCiudad.ReadOnly = True
        TxtProvincia.ReadOnly = True
        TxtCodigopostal.ReadOnly = True
        TxtTelFijo.ReadOnly = True
        TxtTelCelular.ReadOnly = True
        TxtCuit.ReadOnly = True
        TxtEmail.ReadOnly = True
        TxtObservaciones.ReadOnly = True

    End Sub


    Private Sub HabilitaTXT()
        TxtIdCliente.BackColor = Color.White
        TxtApellido.BackColor = Color.White
        TxtNombre.BackColor = Color.White
        TxtRazonSocial.BackColor = Color.White
        TxtDomicilio.BackColor = Color.White
        TxtCiudad.BackColor = Color.White
        TxtProvincia.BackColor = Color.White
        TxtCodigopostal.BackColor = Color.White
        TxtTelFijo.BackColor = Color.White
        TxtTelCelular.BackColor = Color.White
        TxtCuit.BackColor = Color.White
        TxtEmail.BackColor = Color.White
        TxtObservaciones.BackColor = Color.White

        TxtIdCliente.ReadOnly = False
        TxtApellido.ReadOnly = False
        TxtNombre.ReadOnly = False
        TxtRazonSocial.ReadOnly = False
        TxtDomicilio.ReadOnly = False
        TxtCiudad.ReadOnly = False
        TxtProvincia.ReadOnly = False
        TxtCodigopostal.ReadOnly = False
        TxtTelFijo.ReadOnly = False
        TxtTelCelular.ReadOnly = False
        TxtCuit.ReadOnly = False
        TxtEmail.ReadOnly = False
        TxtObservaciones.ReadOnly = False

    End Sub

    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
        TxtIdCliente.Enabled = True
        tsbtnCancelar.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEditar.Enabled = False
        habilitaTXT()

    End Sub

    Private Sub tsbtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click
        tsbtnNew.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = True
        habilitaTXT()
    End Sub

    'Private Sub tsbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminar.Click

    '    'Dim consultaMysql As String = ""
    '    'Dim codigo As Integer

    '    'codigo = Me.TxtIdCliente.Text

    '    'If TxtIdCliente.Text = "0000" Then
    '    '    MsgBox("Seleccione Cliente para borrar")
    '    'Else
    '    '    Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
    '    '                                            "Atención", MessageBoxButtons.YesNo)
    '    '    If resultado = Windows.Forms.DialogResult.Yes Then
    '    '        conectarDB()
    '    '        comand.CommandType = CommandType.Text
    '    '        comand.Connection = conexion

    '    '        consultaMysql = "DELETE FROM clientes WHERE idcliente =" + codigo.ToString

    '    '        comand.CommandText = consultaMysql

    '    '        Try
    '    '            comand.ExecuteNonQuery()
    '    '            MsgBox("Registro Eliminado", MsgBoxStyle.Information)
    '    '        Catch ex As Exception
    '    '            MsgBox(ex.ToString, MsgBoxStyle.Critical)
    '    '        End Try

    '    '        conexion.Close()
    '    '    End If
    '    'End If

    '    'limpiar()
    '    'llenargrid()
    '    'inicio()

    'End Sub

    Private Sub tsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click

        If TxtApellido.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " del Cliente")
            TxtApellido.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String

            miCliente.IdCliente = Me.TxtIdCliente.Text.Trim
            miCliente.Nombre = Me.TxtNombre.Text.Trim
            miCliente.Apellido = Me.TxtApellido.Text.Trim
            miCliente.RazonSocial = Me.TxtRazonSocial.Text.Trim
            miCliente.Domicilio = Me.TxtDomicilio.Text.Trim
            miCliente.Ciudad = Me.TxtCiudad.Text.Trim
            miCliente.Provincia = Me.TxtProvincia.Text.Trim
            miCliente.CodigoPostal = Me.TxtCodigopostal.Text.Trim
            miCliente.TelFijo = Me.TxtTelFijo.Text.Trim
            miCliente.TelCelular = Me.TxtTelCelular.Text.Trim
            miCliente.Cuil = Me.TxtCuit.Text.Trim
            miCliente.Email = Me.TxtEmail.Text.Trim
            miCliente.Observaciones = Me.TxtObservaciones.Text.Trim

            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then

                Try
                    sql = "INSERT INTO cliente (idCliente,Nombre, Apellido, RazonSocial, Domicilio, Ciudad, "
                    sql += "Provincia, CodigoPostal, TelFijo, TelCelular, Email, Cuil, Observaciones)"
                    sql += "VALUES ('" & miCliente.IdCliente & "','" & miCliente.Nombre & "','" & miCliente.Apellido & "','" & miCliente.RazonSocial & "', "
                    sql += "'" & miCliente.Domicilio & "','" & miCliente.Ciudad & "','" & miCliente.Provincia & "','" & miCliente.CodigoPostal & "', "
                    sql += "'" & miCliente.TelFijo & "','" & miCliente.TelCelular & "','" & miCliente.Email & "',"
                    sql += "'" & miCliente.Cuil & "','" & miCliente.Observaciones & "')"

                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()

                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                End Try
            End If

            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then

                Try
                    sql = "Update cliente SET "
                    sql += "Nombre ='" & miCliente.Nombre & "', "
                    sql += "Apellido ='" & miCliente.Apellido & "', "
                    sql += "RazonSocial = '" & miCliente.RazonSocial & "', "
                    sql += "Domicilio = '" & miCliente.Domicilio & "', "
                    sql += "Ciudad = '" & miCliente.Ciudad & "', "
                    sql += "Provincia = '" & miCliente.Provincia & "', "
                    sql += "CodigoPostal ='" & miCliente.CodigoPostal & "', "
                    sql += "TelFijo ='" & miCliente.TelFijo & "', "
                    sql += "TelCelular ='" & miCliente.TelCelular & "', "
                    sql += "Email ='" & miCliente.Email & "', "
                    sql += "Cuil ='" & miCliente.Cuil & "', "
                    sql += "Observaciones = '" & miCliente.Observaciones & "' "
                    sql += "WHERE idcliente = '" & miCliente.IdCliente & "'; "

                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()

                    MsgBox("Los Datos Actualizados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Actualizar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")

                End Try


            End If
        End If

        limpiar()
        llenargrid()
        inicio()
    End Sub

    Private Sub tsbtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelar.Click
        limpiar()
        inicio()
    End Sub

    Private Sub tsbtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscar.Click
        MsgBox("Para buscar un Cliente escriba el N° DNI o el Apellido en el recuadro", MsgBoxStyle.Information)
        TxtIdCliente.BackColor = Color.White
        TxtIdCliente.ReadOnly = False
        TxtApellido.BackColor = Color.White
        TxtApellido.ReadOnly = False
        TxtIdCliente.Focus()
    End Sub

    Private Sub TxtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtApellido.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("cliente", "Apellido", TxtApellido.Text)
        'con el dt devuelto lleno el datagriedview
        DGVClientes.DataSource = tabla

    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click

        If DGVClientes.RowCount > 0 Then

            miCliente.IdCliente = DGVClientes.SelectedCells(0).Value

            If IsDBNull(DGVClientes.SelectedCells(1).Value) Then
                miCliente.Nombre = ""
            Else
                miCliente.Nombre = DGVClientes.SelectedCells(1).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(2).Value) Then
                miCliente.Apellido = ""
            Else
                miCliente.Apellido = DGVClientes.SelectedCells(2).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(3).Value) Then
                miCliente.RazonSocial = ""
            Else
                miCliente.RazonSocial = DGVClientes.SelectedCells(3).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(4).Value) Then
                miCliente.Domicilio = ""
            Else
                miCliente.Domicilio = DGVClientes.SelectedCells(4).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(5).Value) Then
                miCliente.Ciudad = ""
            Else
                miCliente.Ciudad = DGVClientes.SelectedCells(5).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(6).Value) Then
                miCliente.Provincia = ""
            Else
                miCliente.Provincia = DGVClientes.SelectedCells(6).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(7).Value) Then
                miCliente.CodigoPostal = ""
            Else
                miCliente.CodigoPostal = DGVClientes.SelectedCells(7).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(8).Value) Then
                miCliente.TelFijo = ""
            Else
                miCliente.TelFijo = DGVClientes.SelectedCells(8).Value
            End If
            If IsDBNull(DGVClientes.SelectedCells(9).Value) Then
                miCliente.TelCelular = ""
            Else
                miCliente.TelCelular = DGVClientes.SelectedCells(9).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(10).Value) Then
                miCliente.Email = ""
            Else
                miCliente.Email = DGVClientes.SelectedCells(10).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(11).Value) Then
                miCliente.Cuil = ""
            Else
                miCliente.Cuil = DGVClientes.SelectedCells(11).Value
            End If

            If IsDBNull(DGVClientes.SelectedCells(12).Value) Then
                miCliente.Observaciones = ""
            Else
                miCliente.Observaciones = DGVClientes.SelectedCells(12).Value
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdCliente.Text = miCliente.IdCliente
            Me.TxtNombre.Text = miCliente.Nombre
            Me.TxtApellido.Text = miCliente.Apellido
            Me.TxtRazonSocial.Text = miCliente.RazonSocial
            Me.TxtDomicilio.Text = miCliente.Domicilio
            Me.TxtCiudad.Text = miCliente.Ciudad
            Me.TxtProvincia.Text = miCliente.Provincia
            Me.TxtCodigopostal.Text = miCliente.CodigoPostal
            Me.TxtTelFijo.Text = miCliente.TelFijo
            Me.TxtTelCelular.Text = miCliente.TelCelular
            Me.TxtEmail.Text = miCliente.Email
            Me.TxtCuit.Text = miCliente.Cuil
            Me.TxtObservaciones.Text = miCliente.Observaciones

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub


    Private Sub DGVClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick
        If DGVClientes.RowCount > 0 Then

            miCliente.IdCliente = DGVClientes.SelectedCells(0).Value

            If IsDBNull(DGVClientes.SelectedCells(1).Value) Then
                miCliente.Nombre = ""
            Else
                miCliente.Nombre = DGVClientes.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(2).Value) Then
                miCliente.Apellido = ""
            Else
                miCliente.Apellido = DGVClientes.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(3).Value) Then
                miCliente.RazonSocial = ""
            Else
                miCliente.RazonSocial = DGVClientes.SelectedCells(3).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(4).Value) Then
                miCliente.Domicilio = ""
            Else
                miCliente.Domicilio = DGVClientes.SelectedCells(4).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(5).Value) Then
                miCliente.Ciudad = ""
            Else
                miCliente.Ciudad = DGVClientes.SelectedCells(5).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(6).Value) Then
                miCliente.Provincia = ""
            Else
                miCliente.Provincia = DGVClientes.SelectedCells(6).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(7).Value) Then
                miCliente.CodigoPostal = ""
            Else
                miCliente.CodigoPostal = DGVClientes.SelectedCells(7).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(8).Value) Then
                miCliente.TelFijo = ""
            Else
                miCliente.TelFijo = DGVClientes.SelectedCells(8).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(9).Value) Then
                miCliente.TelCelular = ""
            Else
                miCliente.TelCelular = DGVClientes.SelectedCells(9).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(10).Value) Then
                miCliente.Email = ""
            Else
                miCliente.Email = DGVClientes.SelectedCells(10).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(11).Value) Then
                miCliente.Cuil = ""
            Else
                miCliente.Cuil = DGVClientes.SelectedCells(11).Value
            End If
            '
            If IsDBNull(DGVClientes.SelectedCells(12).Value) Then
                miCliente.Observaciones = ""
            Else
                miCliente.Observaciones = DGVClientes.SelectedCells(12).Value
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdCliente.Text = miCliente.IdCliente
            Me.TxtNombre.Text = miCliente.Nombre
            Me.TxtApellido.Text = miCliente.Apellido
            Me.TxtRazonSocial.Text = miCliente.RazonSocial
            Me.TxtDomicilio.Text = miCliente.Domicilio
            Me.TxtCiudad.Text = miCliente.Ciudad
            Me.TxtProvincia.Text = miCliente.Provincia
            Me.TxtCodigopostal.Text = miCliente.CodigoPostal
            Me.TxtTelFijo.Text = miCliente.TelFijo
            Me.TxtTelCelular.Text = miCliente.TelCelular
            Me.TxtCuit.Text = miCliente.Cuil
            Me.TxtEmail.Text = miCliente.Email
            Me.TxtObservaciones.Text = miCliente.Observaciones

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False


    End Sub


    Private Sub TxtIdCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdCliente.TextChanged
        Dim tabla As New DataTable

        Dim miGestionMysql As New GestionMySQL
        tabla = miGestionMysql.BuscarenTablaEscribo("cliente", "idCliente", TxtIdCliente.Text)
        DGVClientes.DataSource = tabla
        


    End Sub

    Private Sub BtnAddClienteEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddClienteEntrada.Click
        FrmEntradaTaller.LblIdCliente.Text = miCliente.IdCliente
        FrmEntradaTaller.TxtCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
        Me.Close()
    End Sub
End Class