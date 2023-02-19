Public Class FrmMarcaModelo
    Dim miConexion As New GestionMySQL
    Dim DtMarca As New DataTable
    Dim DtModelo As New DataTable

    Private Sub FrmMarcaModelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarListaMarca("marcaVehiculo", "Marca")
    End Sub

    Private Sub llenarListaMarca(ByVal tabla As String, ByVal display As String)
        DtMarca = miConexion.ConsultarTabla("marcaVehiculo")
        With ListBoxMarca
            .DataSource = DtMarca
            .DisplayMember = display
        End With
    End Sub

    Private Sub llenarListaModelo(ByVal tabla As String, ByVal display As String, ByVal marca As String)
        Dim sql As String
        sql = "SELECT m.modelo FROM " & tabla & " m where m.Marca = '" & Marca & "';"
        DtModelo = miConexion.Consulta(sql)
        With ListBoxModelo
            .DataSource = DtModelo
            .DisplayMember = display
        End With
    End Sub

    Private Sub inicio()
        TxtMarca.ReadOnly = True
        TxtMarca.BackColor = Color.LightGreen
        TxtMarca.Clear()
        TxtModelo.ReadOnly = True
        TxtModelo.BackColor = Color.LightGreen
        TxtModelo.Clear()
        BtnGrabaMarca.Enabled = False
        BtnGrabaModelo.Enabled = False
    End Sub

    Private Sub BtnAgregaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaMarca.Click
        TxtMarca.Clear()
        TxtMarca.ReadOnly = False
        TxtMarca.BackColor = Color.White
        BtnGrabaMarca.Enabled = True

    End Sub

    Private Sub BtnAgregaModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaModelo.Click
        TxtModelo.Clear()
        If TxtMarca.Text = "" Then
            MsgBox("Debe tener selecionada una marca")
        Else
            TxtModelo.ReadOnly = False
            TxtModelo.BackColor = Color.White
        End If
        BtnGrabaModelo.Enabled = True
    End Sub

    Private Sub ListBoxMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxMarca.SelectedIndexChanged
        Dim Marca As String
        Marca = ListBoxMarca.Text
        TxtMarca.Text = Marca
        llenarListaModelo("modeloVehiculo", "Modelo", Marca)
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnGrabaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabaMarca.Click
        Dim miConexion As New GestionMySQL
        Dim marca As String = TxtMarca.Text
        Dim sql As String
        Try
            sql = "INSERT INTO marcaVehiculo (Marca)"
            sql += "VALUES ('" & marca & "')"
            miConexion.EjecutarSQL(sql)
            miConexion.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try

        Marca = ListBoxMarca.Text
        TxtMarca.Text = Marca
        llenarListaModelo("modeloVehiculo", "Modelo", Marca)
        inicio()
    End Sub

    Private Sub BtnGrabaModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabaModelo.Click
        Dim miConexion As New GestionMySQL
        Dim marca As String = TxtMarca.Text
        Dim modelo As String = TxtModelo.Text

        Dim sql As String
        Try
            sql = "INSERT INTO ModeloVehiculo (Modelo, Marca)"
            sql += "VALUES ('" & modelo & "','" & marca & "')"
            miConexion.EjecutarSQL(sql)
            miConexion.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
        llenarListaMarca("marcaVehiculo", "Marca")
        inicio()
    End Sub


    Private Sub BtnBorraModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorraModelo.Click
        Dim miConexion As New GestionMySQL

        Dim marca As String = TxtMarca.Text
        Dim modelo As String = TxtModelo.Text

        If TxtModelo.Text = "" Then
            MsgBox("Seleccione modelo para borrar")
        Else
            Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
                                                    "Atención", MessageBoxButtons.YesNo)
            If resultado = Windows.Forms.DialogResult.Yes Then
                Try
                    miConexion.Consulta("DELETE FROM modeloVehiculo WHERE modelo = '" & modelo & "';")

                    MsgBox("Registro Eliminado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try

                miConexion.Dispose()
            End If
        End If
        llenarListaModelo("modeloVehiculo", "Modelo", Marca)
        inicio()
    End Sub

    Private Sub ListBoxModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxModelo.SelectedIndexChanged
        Dim Modelo As String
        Modelo = ListBoxModelo.Text
        TxtModelo.Text = Modelo
    End Sub
End Class