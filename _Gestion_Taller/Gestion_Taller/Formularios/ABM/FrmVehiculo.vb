Public Class FrmVehiculo

    Dim dt As New DataTable
    Dim dtMitabla As New DataTable
    Dim tabla As New DataTable
    'Dim miCliente As New ClassCliente
    Dim miVehiculo As New ClassVehiculoT
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombox("MarcaVehiculo", "Marca", CBMarca)
        llenarCombox("Aseguradora", "Aseguradora", CBaseguradora)
        Limpiar()
        Inicio()
        TxtDominio.Select()
        Llenargrid()
    End Sub

    Private Sub HabilitarTXT()

        TxtDominio.BackColor = Color.White
        TxtKilometros.BackColor = Color.White
        CBMarca.BackColor = Color.White
        CBModelo.BackColor = Color.White
        TxtColor.BackColor = Color.White
        CBcombustible.BackColor = Color.White
        TxtTipoMotor.BackColor = Color.White
        TxtCilindrada.BackColor = Color.White
        TxtPoliza.BackColor = Color.White
        TxtComentarios.BackColor = Color.White
        CBaseguradora.BackColor = Color.White

        TxtDominio.ReadOnly = False
        TxtKilometros.ReadOnly = False
        CBMarca.Enabled = True
        CBModelo.Enabled = True
        TxtColor.ReadOnly = False
        CBcombustible.Enabled = True
        TxtTipoMotor.ReadOnly = False
        TxtCilindrada.ReadOnly = False
        TxtPoliza.ReadOnly = False
        TxtComentarios.ReadOnly = False
        CBaseguradora.Enabled = True
        BtnImagen.Enabled = True
        DTPvtv.Enabled = True
    End Sub

    Private Sub InhabilitatTXT()
       
        TxtDominio.BackColor = Color.LightGreen
        TxtKilometros.BackColor = Color.LightGreen
        CBMarca.BackColor = Color.LightGreen
        CBModelo.BackColor = Color.LightGreen
        TxtColor.BackColor = Color.LightGreen
        CBcombustible.BackColor = Color.LightGreen
        TxtTipoMotor.BackColor = Color.LightGreen
        TxtCilindrada.BackColor = Color.LightGreen
        TxtPoliza.BackColor = Color.LightGreen
        TxtComentarios.BackColor = Color.LightGreen
        CBaseguradora.BackColor = Color.LightGreen

        TxtDominio.ReadOnly = True
        TxtKilometros.ReadOnly = True
        CBMarca.Enabled = False
        CBModelo.Enabled = False
        TxtColor.ReadOnly = True
        CBcombustible.Enabled = False
        TxtTipoMotor.ReadOnly = True
        TxtCilindrada.ReadOnly = True
        TxtPoliza.ReadOnly = True
        TxtComentarios.ReadOnly = True
        BtnImagen.Enabled = False
        CBaseguradora.Enabled = False
        DTPvtv.Enabled = False
    End Sub

    Private Sub Inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
        TxtComentarios.Select()
    End Sub

    Private Sub Limpiar()

        TxtDominio.Clear()
        TxtKilometros.Clear()
        CBMarca.Text = ""
        CBModelo.Text = ""
        TxtColor.Clear()
        CBcombustible.Text = ""
        TxtTipoMotor.Clear()
        TxtCilindrada.Clear()
        TxtPoliza.Clear()
        TxtComentarios.Clear()
        PictureBox1.Image = Nothing
        TxtImagen.clear()
        CBaseguradora.Text = ""
        InhabilitatTXT()
        DTPvtv.Value = Today
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("vistavehiculos")
        'con el dt devuelto lleno el datagriedview
        DGVvehiculos.DataSource = dtMitabla

    End Sub

    Private Sub CBMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMarca.SelectedIndexChanged
        llenarComboxModelo("modeloVehiculo", "Modelo", CBModelo)
    End Sub

    Private Sub tsbtnNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
        TxtDominio.Enabled = True
        tsbtnCancelar.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        HabilitarTXT()
    End Sub

    Private Sub tsbtnEditar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click
        tsbtnNew.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = True
        HabilitarTXT()
    End Sub

    Private Sub tsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click
        If TxtDominio.Text = "" Or CBMarca.Text = "" Or CBModelo.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " del Vehiculo")
            TxtComentarios.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim miGestionMySQLStock As New GestionMySQL
            Dim sql As String

            miVehiculo.Dominio = TxtDominio.Text.Trim
            miVehiculo.Marca = CBMarca.Text.Trim
            miVehiculo.Modelo = CBModelo.Text.Trim
            miVehiculo.Color = TxtColor.Text.Trim
            miVehiculo.Combustible = CBcombustible.Text.Trim
            miVehiculo.Kilometros = TxtKilometros.Text.Trim
            miVehiculo.TipoMotor = TxtTipoMotor.Text.Trim
            miVehiculo.Cilindrada = TxtCilindrada.Text.Trim
            miVehiculo.IdAseguradora = CBaseguradora.Text.Trim
            miVehiculo.Poliza = TxtPoliza.Text.Trim
            miVehiculo.Comentario = TxtComentarios.Text.Trim
            miVehiculo.Foto = TxtImagen.Text.Trim
            miVehiculo.Vtv = DTPvtv.Value
            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then
                Try
                    'Dominio, Marca, Modelo, Color, Combustible, Kilometros, TipoMotor, Cilindrada, IdAseguradora, Poliza, FechaAlta, UltimaVisita, Comentario, Foto, Vtv, Estado
                    sql = "INSERT INTO vehiculo (Dominio, Marca, Modelo, Color, Combustible, "
                    sql += "Kilometros, TipoMotor, Cilindrada, IdAseguradora, Poliza, Comentario, Foto, Vtv)"
                    sql += " VALUES ('" & miVehiculo.Dominio & "','" & miVehiculo.Marca & "','" & miVehiculo.Modelo & "','" & miVehiculo.Color & "','" & miVehiculo.Combustible & "', "
                    sql += "'" & miVehiculo.Kilometros & "','" & miVehiculo.TipoMotor & "','" & miVehiculo.Cilindrada & "','" & miVehiculo.IdAseguradora & "','" & miVehiculo.Poliza & "', "
                    sql += "'" & miVehiculo.Comentario & "','" & miVehiculo.Foto & "', STR_TO_DATE('" & miVehiculo.Vtv & "','%d/%m/%Y'))"
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                End Try
            End If

            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then
                Try
                    'Dominio, Marca, Modelo, Color, Combustible, Kilometros, TipoMotor, Cilindrada, IdAseguradora, Poliza, FechaAlta, UltimaVisita, Comentario, Foto, Vtv, Estado
                    sql = "UPDATE vehiculo set "
                    sql += "Marca = '" & miVehiculo.Marca & "', "
                    sql += "Modelo = '" & miVehiculo.Modelo & "', "
                    sql += "Color = '" & miVehiculo.Color & "', "
                    sql += "Combustible = '" & miVehiculo.Combustible & "', "
                    sql += "Kilometros = '" & miVehiculo.Kilometros & "', "
                    sql += "TipoMotor = '" & miVehiculo.TipoMotor & " ', "
                    sql += "Cilindrada = '" & miVehiculo.Cilindrada & " ', "
                    sql += "IdAseguradora = '" & miVehiculo.IdAseguradora & " ', "
                    sql += "Poliza = '" & miVehiculo.Poliza & " ', "
                    sql += "Comentario = '" & miVehiculo.Comentario & "', "
                    sql += "Foto = '" & miVehiculo.Foto & "', "
                    sql += "Vtv = STR_TO_DATE('" & miVehiculo.Vtv & "','%d/%m/%Y')  "
                    sql += "WHERE Dominio = '" & miVehiculo.Dominio & "'; "
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
                End Try
            End If
        End If
        Limpiar()
        Inicio()
        Llenargrid()
    End Sub

    Private Sub tsbtnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelar.Click
        Limpiar()
        Inicio()
        Llenargrid()

    End Sub

    Private Sub tsbtnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscar.Click
        MsgBox("Para buscar un vehiculo escriba el dominio en el recuadro", MsgBoxStyle.Information)
        TxtDominio.BackColor = Color.White
        TxtDominio.ReadOnly = False
        TxtDominio.Focus()
    End Sub

    Private Sub TxtIdArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If IsNumeric(TxtIdArticulo.Text) Then
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Articulo", "idArticulo", TxtDominio.Text)
        'con el dt devuelto lleno el datagriedview
        'DGVArticulos.DataSource = tabla

        TxtComentarios.Text = ""
        TxtColor.Text = "0,00"
        CBcombustible.Text = ""
        CBMarca.Text = ""
        CBModelo.Text = ""
        TxtImagen.Text = ""
        PictureBox1.Image = Nothing
        'Else
        'MsgBox("Debe ingresar solo NUMEROS")
        'End If

    End Sub

    Private Sub TxtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim tabla As New DataTable
        'conecto
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarArtStockDescripcion(TxtComentarios.Text)
        'con el dt devuelto lleno el datagriedview
        'DGVArticulos.DataSource = tabla

    End Sub

    Private Sub BtnImagem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagen.Click
        'abrir dialogo para seleccionar una image
        Dim EX As New OpenFileDialog With {
            .Title = "BUSCAR IMAGEN"
        }
        'CREAMOS UN FILTRO PRA QUE SOLO SE MUESTRE IMAGENES 
        Dim FILTRAR As String
        FILTRAR = "IMAGENES JPG|*.jpg|"
        FILTRAR += "TODAS LAS IMAGENES|*.png;*.jpg;*.gif;*.b­mp"
        EX.Filter = FILTRAR
        If EX.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = EX.FileName
            TxtImagen.Text = EX.FileName

        End If
    End Sub

    Private Sub BtnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmBusquedaVehiculo.MdiParent = MDIMenu
        FrmBusquedaVehiculo.Show()
        FrmBusquedaVehiculo.BtnCopiarVehiculo.Visible = True
    End Sub

    Private Sub TxtDominio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDominio.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarenTablaEscribo("vehiculo", "dominio", TxtDominio.Text)
        DGVvehiculos.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Limpiar()
        Llenargrid()
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        HabilitarTXT()
        If DGVvehiculos.RowCount > 0 Then

            miVehiculo.Dominio = DGVvehiculos.SelectedCells(0).Value
            '
            If IsDBNull(DGVvehiculos.SelectedCells(1).Value) Then
                miVehiculo.Kilometros = ""
            Else
                miVehiculo.Kilometros = DGVvehiculos.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(2).Value) Then
                miVehiculo.Color = ""
            Else
                miVehiculo.Color = DGVvehiculos.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(3).Value) Then
                miVehiculo.Marca = ""
            Else
                miVehiculo.Marca = DGVvehiculos.SelectedCells(3).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(4).Value) Then
                miVehiculo.Modelo = ""
            Else
                miVehiculo.Modelo = DGVvehiculos.SelectedCells(4).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(5).Value) Then
                miVehiculo.Combustible = ""
            Else
                miVehiculo.Combustible = DGVvehiculos.SelectedCells(5).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(6).Value) Then
                miVehiculo.TipoMotor = ""
            Else
                miVehiculo.TipoMotor = DGVvehiculos.SelectedCells(6).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(7).Value) Then
                miVehiculo.Cilindrada = ""
            Else
                miVehiculo.Cilindrada = DGVvehiculos.SelectedCells(7).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(8).Value) Then
                miVehiculo.Poliza = ""
            Else
                miVehiculo.Poliza = DGVvehiculos.SelectedCells(8).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(9).Value) Then
                miVehiculo.IdAseguradora = ""
            Else
                miVehiculo.IdAseguradora = DGVvehiculos.SelectedCells(9).Value
            End If
            '
            If IsDBNull(DGVvehiculos.SelectedCells(10).Value) Then
                miVehiculo.Comentario = ""
            Else
                miVehiculo.Comentario = DGVvehiculos.SelectedCells(10).Value
            End If
            '
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.TxtDominio.Text = miVehiculo.Dominio
            Me.TxtKilometros.Text = miVehiculo.Kilometros
            Me.TxtColor.Text = miVehiculo.Color
            Me.CBMarca.Text = miVehiculo.Marca
            Me.CBModelo.Text = miVehiculo.Modelo
            Me.CBcombustible.Text = miVehiculo.Combustible
            Me.TxtTipoMotor.Text = miVehiculo.TipoMotor
            Me.TxtCilindrada.Text = miVehiculo.Cilindrada
            Me.TxtPoliza.Text = miVehiculo.Poliza
            Me.CBaseguradora.Text = miVehiculo.IdAseguradora
            Me.TxtComentarios.Text = miVehiculo.Comentario
            PictureBox1.ImageLocation = TxtImagen.Text
            'xtImagen.Text = EX.FileName
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False
    End Sub

    Private Sub BtnAddVehiculoEntradaTaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddVehiculoEntradaTaller.Click
        If DGVvehiculos.RowCount > 0 Then
            miVehiculo.Dominio = DGVvehiculos.SelectedCells(0).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmEntradaTaller.TxtVehiculo.Text = miVehiculo.Dominio
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub llenarCombox(ByVal tabla As String, ByVal display As String, ByVal Combo As ComboBox)
        Dim miConexion As New GestionMySQL
        Dim dt
        dt = miConexion.Consulta("SELECT * FROM " & tabla)
        With Combo
            .DataSource = dt
            .DisplayMember = display
        End With
    End Sub

    Private Sub llenarComboxModelo(ByVal tabla As String, ByVal display As String, ByVal Combo As ComboBox)
        Dim miConexion As New GestionMySQL
        Dim dt
        dt = miConexion.Consulta("SELECT * FROM " & tabla & " where marca = '" & CBMarca.Text.Trim & "'")
        With Combo
            .DataSource = dt
            .DisplayMember = display
        End With
    End Sub
End Class