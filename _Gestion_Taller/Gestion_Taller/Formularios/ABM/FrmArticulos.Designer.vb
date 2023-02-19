<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TSClientes = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnImagem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtStockMinimo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.BrnAgregaArticulo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRubro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSituado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGVArticulos = New System.Windows.Forms.DataGridView()
        Me.TSClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TSClientes
        '
        Me.TSClientes.BackColor = System.Drawing.Color.DimGray
        Me.TSClientes.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSClientes.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.TSClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.ToolStripSeparator5, Me.tsbtnEditar, Me.ToolStripSeparator4, Me.tsbtnEliminar, Me.ToolStripSeparator1, Me.tsbtnGuardar, Me.ToolStripSeparator2, Me.tsbtnCancelar, Me.ToolStripSeparator3, Me.tsbtnBuscar})
        Me.TSClientes.Location = New System.Drawing.Point(1017, 0)
        Me.TSClientes.Name = "TSClientes"
        Me.TSClientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSClientes.Size = New System.Drawing.Size(77, 571)
        Me.TSClientes.TabIndex = 12
        Me.TSClientes.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnNew.Image = Global.Gestion_Taller.My.Resources.Resources.BI_add_72
        Me.tsbtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnNew.Text = "Nuevo"
        Me.tsbtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEditar
        '
        Me.tsbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_edit_72
        Me.tsbtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditar.Name = "tsbtnEditar"
        Me.tsbtnEditar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEditar.Text = "Editar"
        Me.tsbtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEliminar
        '
        Me.tsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEliminar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_delete_72
        Me.tsbtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEliminar.Name = "tsbtnEliminar"
        Me.tsbtnEliminar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEliminar.Text = "Eliminar"
        Me.tsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnGuardar
        '
        Me.tsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnGuardar.Enabled = False
        Me.tsbtnGuardar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_save_72
        Me.tsbtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardar.Name = "tsbtnGuardar"
        Me.tsbtnGuardar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnGuardar.Text = "Guardar"
        Me.tsbtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnCancelar
        '
        Me.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancelar.Enabled = False
        Me.tsbtnCancelar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_cancel_72
        Me.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancelar.Name = "tsbtnCancelar"
        Me.tsbtnCancelar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnCancelar.Text = "Cancelar"
        Me.tsbtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnBuscar
        '
        Me.tsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBuscar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_find_72
        Me.tsbtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBuscar.Name = "tsbtnBuscar"
        Me.tsbtnBuscar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnBuscar.Text = "Buscar"
        Me.tsbtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Precio-Venta"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.BackColor = System.Drawing.Color.LightGreen
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(144, 86)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.ReadOnly = True
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(86, 20)
        Me.TxtPrecioVenta.TabIndex = 32
        Me.TxtPrecioVenta.Text = "0.00"
        Me.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Precio-Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Id_Articulo:"
        '
        'TxtImagen
        '
        Me.TxtImagen.Location = New System.Drawing.Point(836, 162)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(142, 20)
        Me.TxtImagen.TabIndex = 23
        Me.TxtImagen.Visible = False
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.LightGreen
        Me.TxtMarca.Location = New System.Drawing.Point(502, 47)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(300, 20)
        Me.TxtMarca.TabIndex = 22
        '
        'TxtPrecioCompra
        '
        Me.TxtPrecioCompra.BackColor = System.Drawing.Color.LightGreen
        Me.TxtPrecioCompra.Location = New System.Drawing.Point(29, 86)
        Me.TxtPrecioCompra.Name = "TxtPrecioCompra"
        Me.TxtPrecioCompra.ReadOnly = True
        Me.TxtPrecioCompra.Size = New System.Drawing.Size(89, 20)
        Me.TxtPrecioCompra.TabIndex = 21
        Me.TxtPrecioCompra.Text = "0.00"
        Me.TxtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDescripcion.Location = New System.Drawing.Point(140, 47)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(343, 20)
        Me.TxtDescripcion.TabIndex = 20
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtIdArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdArticulo.Location = New System.Drawing.Point(30, 47)
        Me.TxtIdArticulo.MaxLength = 13
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.ReadOnly = True
        Me.TxtIdArticulo.Size = New System.Drawing.Size(88, 20)
        Me.TxtIdArticulo.TabIndex = 19
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.Location = New System.Drawing.Point(611, 160)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(122, 47)
        Me.BtnSeleccionar.TabIndex = 36
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        Me.BtnSeleccionar.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.BtnRefresh.Location = New System.Drawing.Point(739, 158)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.BtnRefresh.TabIndex = 37
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnImagem
        '
        Me.BtnImagem.Image = Global.Gestion_Taller.My.Resources.Resources.search_plus
        Me.BtnImagem.Location = New System.Drawing.Point(710, 112)
        Me.BtnImagem.Name = "BtnImagem"
        Me.BtnImagem.Size = New System.Drawing.Size(91, 41)
        Me.BtnImagem.TabIndex = 35
        Me.BtnImagem.Text = "Imagen"
        Me.BtnImagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImagem.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(813, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Stock minimo"
        '
        'TxtStockMinimo
        '
        Me.TxtStockMinimo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtStockMinimo.Location = New System.Drawing.Point(397, 86)
        Me.TxtStockMinimo.Name = "TxtStockMinimo"
        Me.TxtStockMinimo.ReadOnly = True
        Me.TxtStockMinimo.Size = New System.Drawing.Size(86, 20)
        Me.TxtStockMinimo.TabIndex = 42
        Me.TxtStockMinimo.Text = "0"
        Me.TxtStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Stock"
        '
        'TxtStock
        '
        Me.TxtStock.BackColor = System.Drawing.Color.LightGreen
        Me.TxtStock.Location = New System.Drawing.Point(283, 86)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(89, 20)
        Me.TxtStock.TabIndex = 39
        Me.TxtStock.Text = "0"
        Me.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BrnAgregaArticulo
        '
        Me.BrnAgregaArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrnAgregaArticulo.Location = New System.Drawing.Point(611, 159)
        Me.BrnAgregaArticulo.Name = "BrnAgregaArticulo"
        Me.BrnAgregaArticulo.Size = New System.Drawing.Size(122, 47)
        Me.BrnAgregaArticulo.TabIndex = 44
        Me.BrnAgregaArticulo.Text = "Seleccionar"
        Me.BrnAgregaArticulo.UseVisualStyleBackColor = True
        Me.BrnAgregaArticulo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(502, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Rubro"
        '
        'TxtRubro
        '
        Me.TxtRubro.BackColor = System.Drawing.Color.LightGreen
        Me.TxtRubro.Location = New System.Drawing.Point(502, 86)
        Me.TxtRubro.Name = "TxtRubro"
        Me.TxtRubro.ReadOnly = True
        Me.TxtRubro.Size = New System.Drawing.Size(299, 20)
        Me.TxtRubro.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Situado en.."
        '
        'TxtSituado
        '
        Me.TxtSituado.BackColor = System.Drawing.Color.LightGreen
        Me.TxtSituado.Location = New System.Drawing.Point(29, 126)
        Me.TxtSituado.Name = "TxtSituado"
        Me.TxtSituado.ReadOnly = True
        Me.TxtSituado.Size = New System.Drawing.Size(668, 20)
        Me.TxtSituado.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(301, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(333, 24)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Altas, bajas y modificación de Articulos"
        '
        'DGVArticulos
        '
        Me.DGVArticulos.AllowUserToAddRows = False
        Me.DGVArticulos.AllowUserToDeleteRows = False
        Me.DGVArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArticulos.Location = New System.Drawing.Point(16, 211)
        Me.DGVArticulos.Name = "DGVArticulos"
        Me.DGVArticulos.ReadOnly = True
        Me.DGVArticulos.RowHeadersVisible = False
        Me.DGVArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVArticulos.Size = New System.Drawing.Size(983, 348)
        Me.DGVArticulos.TabIndex = 50
        '
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1094, 571)
        Me.Controls.Add(Me.DGVArticulos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtSituado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtRubro)
        Me.Controls.Add(Me.BrnAgregaArticulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtStockMinimo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.BtnImagem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtPrecioVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtImagen)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.TxtPrecioCompra)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtIdArticulo)
        Me.Controls.Add(Me.TSClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM-Articulos"
        Me.TSClientes.ResumeLayout(False)
        Me.TSClientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtImagen As System.Windows.Forms.TextBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecioCompra As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnImagem As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtStockMinimo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents BrnAgregaArticulo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtRubro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSituado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DGVArticulos As DataGridView
End Class
