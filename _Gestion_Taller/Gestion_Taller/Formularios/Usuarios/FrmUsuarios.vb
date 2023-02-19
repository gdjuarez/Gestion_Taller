Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmUsuarios

    Dim dtTabla As DataTable
    Private bmodifica As Boolean = False
    Dim User As New ClassUsuario

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim miGestionMySQL As New GestionMySQL
        dtTabla = miGestionMySQL.consultarTabla("usuario")
    End Sub

    Private Sub tsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click


        Dim bGuardar As Boolean = True

        Dim resultado As DialogResult = MessageBox.Show("Está seguro de confirmar?", _
                                                       "Atención", MessageBoxButtons.YesNo)

        If resultado = Windows.Forms.DialogResult.Yes Then

            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                ' bGuardar = False
                MsgBox("Debe ingresar datos")
            Else

                User.Usuario = UsernameTextBox.Text.Trim
                User.Clave = PasswordTextBox.Text.Trim

                Dim miGestionMySQL As New GestionMySQL
                Dim sql As String

                If tsbtnNuevo.Enabled = False Then
                    bmodifica = True
                End If

                If bGuardar Then
                    Try
                        If Not bmodifica Then
                            sql = "INSERT INTO usuario (usuario,clave)"
                            sql += "VALUES('" & User.Usuario & "','" & User.Clave & "');"
                        Else
                            sql = "Update usuario SET "
                            sql += "usuario = '" & User.Usuario & "', "
                            sql += "clave = '" & User.Clave & "' "
                            sql += "WHERE usuario = '" & User.Usuario & "'; "
                        End If

                        miGestionMySQL.EjecutarSQL(sql)
                        miGestionMySQL.Dispose()

                        MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                    Catch ex As Exception

                        MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                    End Try
                End If
                '-----------------------------------------

            End If
            
        Else
            MessageBox.Show("No se registro ", "Atención !!!")
        End If

        Inicio()

    End Sub

    Private Sub tsbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminar.Click

        If UsernameTextBox.Text = "" Then
            MsgBox("Ingrese Usuario")
        End If

        Dim resultado As DialogResult = MessageBox.Show("Está seguro de dar de Baja al Usuario?", _
                                                  "Atención", MessageBoxButtons.YesNo)

        If resultado = Windows.Forms.DialogResult.Yes Then
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String

            Try
                sql = "Delete  FROM usuario Where usuario = '" & UsernameTextBox.Text & "'; "

                miGestionMySQL.EjecutarSQL(sql)
                miGestionMySQL.Dispose()

                MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

            Catch ex As Exception

                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

            End Try
          
        Else
            MessageBox.Show("Acción cancelada ", "Atención !!!")
        End If

        Inicio()


    End Sub

    Private Sub tsbtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNuevo.Click
        tsbtnGuardar.Enabled = True
    End Sub

    Private Sub tsbtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click

        tsbtnEliminar.Enabled = False
        tsbtnNuevo.Enabled = False
        tsbtnCancelar.Enabled = True
        tsbtnGuardar.Enabled = True
    End Sub

    Private Sub Inicio()

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        tsbtnNuevo.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnEliminar.Enabled = True
        tsbtnCancelar.Enabled = True
        tsbtnGuardar.Enabled = False

    End Sub

    Private Sub tsbtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelar.Click
        Inicio()
    End Sub

    Private Sub tsbtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscar.Click
        llenar_listBox()
    End Sub
    Private Sub llenar_listBox()

        'Referenciamos el objeto DataTable
        With ListBox1
            .DataSource = dtTabla
            .DisplayMember = "usuario"
            .ValueMember = "usuario"
        End With
        UsernameTextBox.Text = ""

        ''--------------Refresh listbox usuarios
        Dim miGestionMySQL As New GestionMySQL
        'conectarDB()
        dtTabla = miGestionMySQL.consultarTabla("usuario")
        ''---------------------------------
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        UsernameTextBox.Text = ListBox1.SelectedValue.ToString()
    End Sub
End Class