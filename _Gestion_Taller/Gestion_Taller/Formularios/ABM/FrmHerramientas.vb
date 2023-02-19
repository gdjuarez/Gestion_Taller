Imports System.IO

Public Class FrmHerramientas

    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miArticulo As New ClassHerramienta
    Dim miHerramienta As New ClassHerramienta

    Private Sub FrmHerramientas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Llenargrid()
        Inicio()
        TxtIdHerramienta.Select()
    End Sub

    Private Sub HabilitarTXT()
        TxtIdHerramienta.BackColor = Color.White
        TxtDescripcion.BackColor = Color.White
        TxtCantidad.BackColor = Color.White
        TxtTipo.BackColor = Color.White
        TxtIdHerramienta.ReadOnly = False
        TxtDescripcion.ReadOnly = False
        TxtCantidad.ReadOnly = False
        TxtTipo.ReadOnly = False
    End Sub

    Private Sub InhabilitatTXT()
        TxtIdHerramienta.BackColor = Color.LightGreen
        TxtDescripcion.BackColor = Color.LightGreen
        TxtCantidad.BackColor = Color.LightGreen
        TxtTipo.BackColor = Color.LightGreen
        TxtIdHerramienta.ReadOnly = True
        TxtDescripcion.ReadOnly = True
        TxtCantidad.ReadOnly = True
        TxtTipo.ReadOnly = True
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("herramientas")
        'con el dt devuelto lleno el datagriedview
        DGVHerramientas.DataSource = dtMitabla
    End Sub

    Private Sub Inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
        TxtDescripcion.Select()
    End Sub

    Private Sub Limpiar()
        TxtIdHerramienta.Text = ""
        TxtDescripcion.Clear()
        TxtTipo.Clear()
        TxtImagen.Clear()
        PictureBox1.Image = Nothing
        TxtCantidad.Text = "0"
        InhabilitatTXT()
    End Sub

    Private Sub TsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
        TxtIdHerramienta.Enabled = True
        tsbtnCancelar.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        HabilitarTXT()
    End Sub

    Private Sub TsbtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click
        tsbtnNew.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = True
        HabilitarTXT()
    End Sub

    Private Sub tsbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminar.Click
        Dim miGestionMySQL As New GestionMySQL
        Dim miHerramienta As New ClassHerramienta
        Dim sql As String
        If DGVHerramientas.RowCount > 0 Then
            miHerramienta.IdHerramientas = DGVHerramientas.SelectedCells(0).Value
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.TxtIdHerramienta.Text = miHerramienta.IdHerramientas
        If tsbtnEliminar.Enabled = True Then
            Try
                sql = "DELETE FROM herramientas "
                sql += "WHERE idHerramientas = '" & miHerramienta.IdHerramientas & "'; "
                MsgBox(sql)
                miGestionMySQL.EjecutarSQL(sql)
                miGestionMySQL.Dispose()
                MsgBox("Los Datos borrados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Hrramienta no borrada")
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
        End If
        Limpiar()
        Llenargrid()
        Inicio()
    End Sub

    Private Sub TsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click
        If TxtIdHerramienta.Text = "" Or TxtDescripcion.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " de las herramientas")
            TxtDescripcion.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim miGestionMySQLStock As New GestionMySQL
            Dim sql As String
            miHerramienta.IdHerramientas = Me.TxtIdHerramienta.Text.Trim
            miHerramienta.Descripcion = Me.TxtDescripcion.Text.Trim
            miHerramienta.Tipo = Me.TxtTipo.Text.Trim
            miHerramienta.Cantidad = Me.TxtCantidad.Text.Trim
            miHerramienta.Imagen = Me.TxtImagen.Text
            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then
                Try
                    'IidHerramientas, Descripcion, Tipo, Cantidad, Imagen
                    sql = "INSERT INTO herramientas (idHerramientas, Descripcion, Tipo, Cantidad, Imagen)"
                    sql += "VALUES ('" & miHerramienta.IdHerramientas & "','" & miHerramienta.Descripcion & "','" & miHerramienta.Tipo & "'," & miHerramienta.Cantidad & ",'" & Replace(miHerramienta.Imagen, "\", "\\") & "')"
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception


                    MsgBox("Error: " & vbNewLine & "El codigo ya esta en uso", MsgBoxStyle.Critical, "Insertar Datos")

                    'If ex.Message = "Duplicate entry" Then
                    '    MsgBox("El codigo ya esta en uso")
                    'End If
                End Try
            End If
            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then
                'Actualizen tabla articulos
                Try
                    sql = "Update herramientas SET "
                    sql += "descripcion ='" & miHerramienta.Descripcion & "', "
                    sql += "tipo = '" & miHerramienta.Tipo & "', "
                    sql += "cantidad = " & miHerramienta.Cantidad & ", "
                    sql += "imagen = '" & Replace(miHerramienta.Imagen, "\", "\\") & "'"
                    sql += "WHERE idHerramientas = '" & miHerramienta.IdHerramientas & "'; "
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                End Try
            End If
        End If
        Limpiar()
        Llenargrid()
        Inicio()
    End Sub

    Private Sub TsbtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelar.Click
        Limpiar()
        Inicio()
    End Sub

    Private Sub TsbtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscar.Click
        MsgBox("Para buscar una herramienta escriba la descripcion en el recuadro", MsgBoxStyle.Information)
        TxtIdHerramienta.BackColor = Color.White
        TxtIdHerramienta.ReadOnly = False
        TxtIdHerramienta.Focus()
    End Sub

    Private Sub BtnImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagem.Click
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

    Private Sub TxtIdHerramienta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdHerramienta.TextChanged
        Dim tabla As New DataTable
        Dim miGestionMySQL As New GestionMySQL
        tabla = miGestionMySQL.BuscarenTablaEscribo("Herramientas", "idHerramientas", TxtIdHerramienta.Text)
        DGVHerramientas.DataSource = tabla
        TxtDescripcion.Text = ""
        TxtCantidad.Text = "0"
        TxtTipo.Text = ""
        TxtImagen.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DGVHerramientas.RowCount > 0 Then
            '
            miArticulo.IdHerramientas = DGVHerramientas.SelectedCells(0).Value
            '
            If IsDBNull(DGVHerramientas.SelectedCells(1).Value) Then
                miArticulo.Descripcion = ""
            Else
                miArticulo.Descripcion = DGVHerramientas.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DGVHerramientas.SelectedCells(2).Value) Then
                miArticulo.Tipo = 0
            Else
                miArticulo.Tipo = DGVHerramientas.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DGVHerramientas.SelectedCells(3).Value) Then
                miArticulo.Cantidad = 0
            Else
                miArticulo.Cantidad = CInt(DGVHerramientas.SelectedCells(3).Value)
            End If
            '
            If IsDBNull(DGVHerramientas.SelectedCells(4).Value) Then
                miArticulo.Imagen = ""
            Else
                miArticulo.Imagen = DGVHerramientas.SelectedCells(4).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.TxtIdHerramienta.Text = miArticulo.IdHerramientas
            Me.TxtDescripcion.Text = miArticulo.Descripcion
            Me.TxtTipo.Text = miArticulo.Tipo
            Me.TxtCantidad.Text = miArticulo.Cantidad
            Me.TxtImagen.Text = miArticulo.Imagen
            PictureBox1.ImageLocation = TxtImagen.Text
            'xtImagen.Text = EX.FileName
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False
    End Sub

    Private Sub DGVHerramientas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
              If DGVHerramientas.RowCount > 0 Then

            miArticulo.IdHerramientas = DGVHerramientas.SelectedCells(0).Value
            '
            If IsDBNull(DGVHerramientas.SelectedCells(1).Value) Then
                miArticulo.Descripcion = ""
            Else
                miArticulo.Descripcion = DGVHerramientas.SelectedCells(1).Value
            End If
            '
            If IsDBNull(DGVHerramientas.SelectedCells(2).Value) Then
                miArticulo.Tipo = 0
            Else
                miArticulo.Tipo = DGVHerramientas.SelectedCells(2).Value
            End If
            '
            If IsDBNull(DGVHerramientas.SelectedCells(3).Value) Then
                miArticulo.Cantidad = 0
            Else
                miArticulo.Cantidad = CInt(DGVHerramientas.SelectedCells(3).Value)
            End If
            '
            If IsDBNull(DGVHerramientas.SelectedCells(4).Value) Then
                miArticulo.Imagen = ""
            Else
                miArticulo.Imagen = DGVHerramientas.SelectedCells(4).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.TxtIdHerramienta.Text = miArticulo.IdHerramientas
            Me.TxtDescripcion.Text = miArticulo.Descripcion
            Me.TxtTipo.Text = miArticulo.Tipo
            Me.TxtCantidad.Text = miArticulo.Cantidad
            Me.TxtImagen.Text = miArticulo.Imagen
            PictureBox1.ImageLocation = TxtImagen.Text
            'xtImagen.Text = EX.FileName
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False
    End Sub

    Private Sub BtnImpimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpimir.Click
        FrmInformeHerramientas.MdiParent = MDIMenu
        FrmInformeHerramientas.Show()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Limpiar()
        Llenargrid()
    End Sub

    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged
        If IsNumeric(TxtCantidad.Text) Then
            'Nada
        Else
            MsgBox("DEBE CARGAR SOLO NUMEROS", MsgBoxStyle.Critical)
        End If
    End Sub

End Class