Public Class frmProveedores

    Dim dtMiTabla As New DataTable
    Dim miProveedor As New ClassProveedor

    Private Sub proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        inicio()
        llenargrid()
    End Sub

    Private Sub HabilitatTXT()

        TxtIdProveedor.BackColor = Color.White
        TxtRazonSocial.BackColor = Color.White
        TxtDomicilio.BackColor = Color.White
        TxtCiudad.BackColor = Color.White
        TxtTelefonoFijo.BackColor = Color.White
        TxtTelefonoCelular.BackColor = Color.White
        TxtEmail.BackColor = Color.White
        TxtCuit.BackColor = Color.White
        TxtObs.BackColor = Color.White

        TxtIdProveedor.ReadOnly = False
        TxtRazonSocial.ReadOnly = False
        TxtDomicilio.ReadOnly = False
        TxtCiudad.ReadOnly = False
        TxtTelefonoFijo.ReadOnly = False
        TxtTelefonoCelular.ReadOnly = False
        TxtEmail.ReadOnly = False
        TxtCuit.ReadOnly = False
        TxtObs.ReadOnly = False

    End Sub

    Private Sub InhabilitatTXT()
        TxtIdProveedor.BackColor = Color.LightGreen
        TxtRazonSocial.BackColor = Color.LightGreen
        TxtDomicilio.BackColor = Color.LightGreen
        TxtCiudad.BackColor = Color.LightGreen
        TxtTelefonoFijo.BackColor = Color.LightGreen
        TxtTelefonoCelular.BackColor = Color.LightGreen
        TxtEmail.BackColor = Color.LightGreen
        TxtCuit.BackColor = Color.LightGreen
        TxtObs.BackColor = Color.LightGreen

        TxtIdProveedor.ReadOnly = True
        TxtRazonSocial.ReadOnly = True
        TxtDomicilio.ReadOnly = True
        TxtCiudad.ReadOnly = True
        TxtTelefonoFijo.ReadOnly = True
        TxtTelefonoCelular.ReadOnly = True
        TxtEmail.ReadOnly = True
        TxtCuit.ReadOnly = True
        TxtObs.ReadOnly = True

    End Sub


    Private Sub llenargrid()

        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.consultarTabla("proveedores")
        'con el dt devuelto lleno el datagriedview
        DGVProveedores.DataSource = dtMitabla
    End Sub

    Private Sub inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
        TxtRazonSocial.Select()
    End Sub

    Private Sub limpiar()
        TxtIdProveedor.Text = "000"
        TxtRazonSocial.Clear()
        TxtDomicilio.Clear()
        TxtCiudad.Clear()
        TxtTelefonoFijo.Clear()
        TxtTelefonoCelular.Clear()
        TxtCuit.Text = "00-00000000-0"
        TxtEmail.Text = "@"
        TxtObs.Clear()
        InhabilitatTXT()

    End Sub

    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
        TxtIdProveedor.Enabled = False
        tsbtnCancelar.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEditar.Enabled = False
        HabilitatTXT()
    End Sub

    Private Sub tsbtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click
        tsbtnNew.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = True
        HabilitatTXT()
    End Sub

    Private Sub tsbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminar.Click

        'Dim consultaMysql As String = ""
        'Dim codigo As Integer

        'codigo = Me.TxtIdProveedor.Text

        'If TxtIdProveedor.Text = "0000" Then
        '    MsgBox("Seleccione Proveedor para borrar")
        'Else
        '    Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
        '                                           "Atención", MessageBoxButtons.YesNo)
        '    If resultado = Windows.Forms.DialogResult.Yes Then
        '        conectarDB()
        '        comand.CommandType = CommandType.Text
        '        comand.Connection = conexion

        '        consultaMysql = "DELETE FROM proveedores WHERE idProveedor =" + codigo.ToString

        '        comand.CommandText = consultaMysql

        '        Try
        '            comand.ExecuteNonQuery()
        '            MsgBox("Registro Eliminado", MsgBoxStyle.Information)
        '        Catch ex As Exception
        '            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        '        End Try

        '        conexion.Close()
        '    End If
        'End If

        'limpiar()
        'llenargrid()
        'inicio()

    End Sub

    Private Sub tsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click

        If TxtRazonSocial.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " del Proveedor")
            TxtRazonSocial.Select()
        Else

            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String

            miProveedor.IdProveedor = CInt(Me.TxtIdProveedor.Text)
            miProveedor.Nombre = Me.TxtRazonSocial.Text.Trim
            miProveedor.Domicilio = Me.TxtDomicilio.Text.Trim
            miProveedor.Ciudad = Me.TxtCiudad.Text.Trim
            miProveedor.TelFijo = Me.TxtTelefonoFijo.Text.Trim
            miProveedor.TelCelular = Me.TxtTelefonoCelular.Text.Trim
            miProveedor.Cuit = Me.TxtCuit.Text.Trim
            miProveedor.Email = Me.TxtEmail.Text.Trim
            miProveedor.Comentario = Me.TxtObs.Text.Trim


            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then
               
                Try
                    sql = "INSERT INTO Proveedores (RazonSocial,domicilio,localidad,TelFijo,Telcelular,cuit,email,comentarios)"
                    sql += "VALUES ('" & miProveedor.Nombre & "','" & miProveedor.Domicilio & "','" & miProveedor.Ciudad & "','" & miProveedor.TelFijo & "','" & miProveedor.TelCelular & "','" & miProveedor.Cuit & "','" & miProveedor.Email & "','" & miProveedor.Comentario & "')"

                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()

                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                End Try

        End If

            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then

                Try
                    sql = "Update proveedores SET "
                    sql += "RazonSocial ='" & miProveedor.Nombre & "', "
                    sql += "domicilio = '" & miProveedor.Domicilio & "', "
                    sql += "localidad = '" & miProveedor.Ciudad & "', "
                    sql += "telFijo = '" & miProveedor.TelFijo & "', "
                    sql += "telCelular = '" & miProveedor.TelCelular & "', "
                    sql += "cuit = '" & miProveedor.Cuit & "', "
                    sql += "email = '" & miProveedor.Email & "', "
                    sql += "comentarios = '" & miProveedor.Comentario & "' "
                    sql += "WHERE idProveedor = " & miProveedor.IdProveedor & "; "

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

        MsgBox("Para buscar un proveedor escriba la razon social en el recuadro", MsgBoxStyle.Information)
        TxtRazonSocial.BackColor = Color.White
        TxtRazonSocial.ReadOnly = False
        TxtRazonSocial.Focus()

    End Sub

    Private Sub TxtRazonSocial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRazonSocial.TextChanged

        Dim tabla As New DataTable
        Dim miGestionMySQL As New GestionMySQL
        tabla = miGestionMySQL.BuscarenTablaEscribo("proveedores", "RazonSocial", TxtRazonSocial.Text)
        DGVProveedores.DataSource = tabla

    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click

        If DGVProveedores.RowCount > 0 Then

            miProveedor.IdProveedor = DGVProveedores.SelectedCells(0).Value

            If IsDBNull(DGVProveedores.SelectedCells(1).Value) Then
                miProveedor.Nombre = "0"
            Else
                miProveedor.Nombre = DGVProveedores.SelectedCells(1).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(2).Value) Then
                miProveedor.Domicilio = "0"
            Else
                miProveedor.Domicilio = DGVProveedores.SelectedCells(2).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(3).Value) Then
                miProveedor.Ciudad = "0"
            Else
                miProveedor.Ciudad = DGVProveedores.SelectedCells(3).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(4).Value) Then
                miProveedor.TelFijo = "0"
            Else
                miProveedor.TelFijo = DGVProveedores.SelectedCells(4).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(5).Value) Then
                miProveedor.TelCelular = "0"
            Else
                miProveedor.TelCelular = DGVProveedores.SelectedCells(5).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(6).Value) Then
                miProveedor.Cuit = "0"
            Else
                miProveedor.Cuit = DGVProveedores.SelectedCells(6).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(7).Value) Then
                miProveedor.Email = "0"
            Else
                miProveedor.Email = DGVProveedores.SelectedCells(7).Value
            End If
            If IsDBNull(DGVProveedores.SelectedCells(8).Value) Then
                miProveedor.Comentario = "-"
            Else
                miProveedor.Comentario = DGVProveedores.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdProveedor.Text = miProveedor.IdProveedor
            Me.TxtRazonSocial.Text = miProveedor.Nombre
            Me.TxtDomicilio.Text = miProveedor.Domicilio
            Me.TxtCiudad.Text = miProveedor.Ciudad
            Me.TxtTelefonoFijo.Text = miProveedor.TelFijo
            Me.TxtTelefonoCelular.Text = miProveedor.TelCelular
            Me.TxtCuit.Text = miProveedor.Cuit
            Me.TxtEmail.Text = miProveedor.Email
            Me.TxtObs.Text = miProveedor.Comentario

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub


    Private Sub DGVProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProveedores.CellContentClick

        If DGVProveedores.RowCount > 0 Then

            miProveedor.IdProveedor = DGVProveedores.SelectedCells(0).Value

            If IsDBNull(DGVProveedores.SelectedCells(1).Value) Then
                miProveedor.Nombre = ""
            Else
                miProveedor.Nombre = DGVProveedores.SelectedCells(1).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(2).Value) Then
                miProveedor.Domicilio = ""
            Else
                miProveedor.Domicilio = DGVProveedores.SelectedCells(2).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(3).Value) Then
                miProveedor.Ciudad = ""
            Else
                miProveedor.Ciudad = DGVProveedores.SelectedCells(3).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(4).Value) Then
                miProveedor.TelFijo = ""
            Else
                miProveedor.TelFijo = DGVProveedores.SelectedCells(4).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(5).Value) Then
                miProveedor.TelCelular = ""
            Else
                miProveedor.TelCelular = DGVProveedores.SelectedCells(5).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(6).Value) Then
                miProveedor.Cuit = ""
            Else
                miProveedor.Cuit = DGVProveedores.SelectedCells(6).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(7).Value) Then
                miProveedor.Email = ""
            Else
                miProveedor.Email = DGVProveedores.SelectedCells(7).Value
            End If

            If IsDBNull(DGVProveedores.SelectedCells(8).Value) Then
                miProveedor.Comentario = ""
            Else
                miProveedor.Comentario = DGVProveedores.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdProveedor.Text = miProveedor.IdProveedor
            Me.TxtRazonSocial.Text = miProveedor.Nombre
            Me.TxtDomicilio.Text = miProveedor.Domicilio
            Me.TxtCiudad.Text = miProveedor.Ciudad
            Me.TxtTelefonoFijo.Text = miProveedor.TelFijo
            Me.TxtTelefonoCelular.Text = miProveedor.TelCelular
            Me.TxtCuit.Text = miProveedor.Cuit
            Me.TxtEmail.Text = miProveedor.Email
            Me.TxtObs.Text = miProveedor.Comentario

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        limpiar()
        llenargrid()
    End Sub

    Private Sub BtnAgregaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaProveedor.Click

        If DGVProveedores.RowCount > 0 Then

            miProveedor.IdProveedor = DGVProveedores.SelectedCells(0).Value

            If IsDBNull(DGVProveedores.SelectedCells(1).Value) Then
                miProveedor.Nombre = ""
            Else
                miProveedor.Nombre = DGVProveedores.SelectedCells(1).Value
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdProveedor.Text = miProveedor.IdProveedor
            Me.TxtRazonSocial.Text = miProveedor.Nombre
            Me.TxtDomicilio.Text = miProveedor.Domicilio
            Me.TxtCiudad.Text = miProveedor.Ciudad
            Me.TxtTelefonoFijo.Text = miProveedor.TelFijo
            Me.TxtTelefonoCelular.Text = miProveedor.TelCelular
            Me.TxtCuit.Text = miProveedor.Cuit
            Me.TxtEmail.Text = miProveedor.Email
            Me.TxtObs.Text = miProveedor.Comentario
            frmCompras.TxtProveedor.Text = miProveedor.IdProveedor
            frmCompras.TxtRazonSocial.Text = miProveedor.Nombre
            'frmCompras.TxtProveedor.Text = TxtIdProveedor.Text
            'frmCompras.TxtRazonSocial.Text = TxtRazonSocial.Text

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        '-----

       

        Me.Close()
    End Sub

End Class