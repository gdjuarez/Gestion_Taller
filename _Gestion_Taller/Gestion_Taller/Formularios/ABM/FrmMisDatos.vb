Public Class FrmMisDatos
    Dim MisDatos As New ClassMisDatos()
    Dim dtTable As New DataTable

    Private Sub FrmMisDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()

    End Sub

    Private Sub Inicio()

        LblAlta.Visible = False
        LblEditar.Visible = False

        Dim miGestionMySQL As New GestionMySQL
        Dim dtMitabla As New DataTable

        dtMitabla = miGestionMySQL.consultarTabla("misdatos")

        For Each MiDataRow As DataRow In dtMitabla.Rows

            Me.TxtRazonSocial.Text = MiDataRow("razonsocial")
            Me.TxtDireccion.Text = MiDataRow("direccion")
            Me.TxtCiudad.Text = MiDataRow("ciudad")
            Me.TxtTelefono.Text = MiDataRow("telefono")
            Me.TxtMail.Text = MiDataRow("email")
            Me.TxtCuit.Text = MiDataRow("cuit")

        Next

        If Me.TxtRazonSocial.Text = "" Then
            LblAlta.Visible = True
        Else
            LblEditar.Visible = True
        End If

    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        MisDatos.RazonSocial = Me.TxtRazonSocial.Text.Trim
        MisDatos.Direccion = Me.TxtDireccion.Text.Trim
        MisDatos.Ciudad = Me.TxtCiudad.Text.Trim
        MisDatos.Telefono = Me.TxtTelefono.Text.Trim
        MisDatos.Mail = Me.TxtMail.Text.Trim
        MisDatos.Cuit = Me.TxtCuit.Text.Trim

        Dim miGestionMySQL As New GestionMySQL
        Dim sql As String


        If LblAlta.Visible = True Then
            Try
                sql = "INSERT INTO misdatos (RazonSocial, Direccion, Ciudad, Telefono, Email, Cuit)"
                sql += "VALUES ('" & MisDatos.RazonSocial & "','" & MisDatos.Direccion & "','" & MisDatos.Ciudad & "','" & MisDatos.Telefono & "','" & MisDatos.Mail & "','" & MisDatos.Cuit & "')"

                miGestionMySQL.EjecutarSQL(sql)

                miGestionMySQL.Dispose()

                MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

            Catch ex As Exception

                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

            End Try


        ElseIf LblEditar.Visible = True Then

            Try
                sql = "Update misdatos SET "
                sql += "Direccion ='" & MisDatos.Direccion & "', "
                sql += "Ciudad ='" & MisDatos.Ciudad & "', "
                sql += "Telefono ='" & MisDatos.Telefono & "', "
                sql += "Email ='" & MisDatos.Mail & "', "
                sql += "Cuit ='" & MisDatos.Cuit & "' "
                sql += "WHERE RazonSocial = '" & MisDatos.RazonSocial & "'; "

                miGestionMySQL.EjecutarSQL(sql)

                miGestionMySQL.Dispose()

                MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

            Catch ex As Exception

                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

            End Try
          
        End If
        Me.Close()
    End Sub


End Class