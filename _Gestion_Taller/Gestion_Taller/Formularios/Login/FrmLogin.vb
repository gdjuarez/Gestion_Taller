Public Class FrmLogin
    Dim dtTabla As New DataTable

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim miGestionMySQL As New GestionMySQL
        dtTabla = miGestionMySQL.consultarTabla("usuario")
        UsernameTextBox.Focus()
    End Sub
   

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        For Each MiDataRow As DataRow In dtTabla.Rows
            Dim usuario, clave As String

            usuario = MiDataRow("usuario")
            clave = MiDataRow("clave")

            ' MsgBox(usuario & " " & clave)

            If UsernameTextBox.Text = usuario And PasswordTextBox.Text = clave Then

                usuarioGlobal = usuario

                ' MsgBox("Usuario y contraseña: correcta", 64, "Identificando...")
                MDIMenu.Show()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                Me.Hide()

                Exit Sub   'salgo del ciclo y del metodo XD
            End If

        Next
        MsgBox("Usuario y contraseña: Incorrecto", 16, "Acceso denegado...")

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

   
End Class
