Public Class LoginFormUsuarios

    Dim dtTabla As New DataTable

    Private Sub LoginFormUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim miGestionMySQL As New GestionMySQL
        dtTabla = miGestionMySQL.consultarTabla("usuario")

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        For Each MiDataRow As DataRow In dtTabla.Rows
            Dim usuario, clave As String

            usuario = MiDataRow("usuario")
            clave = MiDataRow("clave")

            If UsernameTextBox.Text = "Admin" And UsernameTextBox.Text = usuario And PasswordTextBox.Text = clave Then

                'MsgBox("Administrador: correcto", 64, "Identificando...")

                frmUsuarios.MdiParent = MDIMenu
                frmUsuarios.Show()

                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                Me.Hide()
                Exit Sub   'salgo del ciclo y del metodo (medio chanchito XD)

            End If

        Next

        MsgBox("Administrador: Incorrecto", 16, "Acceso denegado...")
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
