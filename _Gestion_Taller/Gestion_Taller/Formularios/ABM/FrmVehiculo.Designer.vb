<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehiculo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPoliza = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtKilometros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtComentarios = New System.Windows.Forms.TextBox()
        Me.TxtDominio = New System.Windows.Forms.TextBox()
        Me.BtnImagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCilindrada = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTipoMotor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPvtv = New System.Windows.Forms.DateTimePicker()
        Me.CBaseguradora = New System.Windows.Forms.ComboBox()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.CBcombustible = New System.Windows.Forms.ComboBox()
        Me.DGVvehiculos = New System.Windows.Forms.DataGridView()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnAddVehiculoEntradaTaller = New System.Windows.Forms.Button()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.CBModelo = New System.Windows.Forms.ComboBox()
        Me.TSClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVvehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TSClientes.Location = New System.Drawing.Point(617, 0)
        Me.TSClientes.Name = "TSClientes"
        Me.TSClientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSClientes.Size = New System.Drawing.Size(77, 571)
        Me.TSClientes.TabIndex = 13
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(146, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(345, 24)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Altas, bajas y modificación de Vehiculos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Poliza"
        '
        'TxtPoliza
        '
        Me.TxtPoliza.BackColor = System.Drawing.Color.LightGreen
        Me.TxtPoliza.Location = New System.Drawing.Point(25, 172)
        Me.TxtPoliza.Name = "TxtPoliza"
        Me.TxtPoliza.ReadOnly = True
        Me.TxtPoliza.Size = New System.Drawing.Size(135, 20)
        Me.TxtPoliza.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Modelo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Kilometros"
        '
        'TxtKilometros
        '
        Me.TxtKilometros.BackColor = System.Drawing.Color.LightGreen
        Me.TxtKilometros.Location = New System.Drawing.Point(139, 54)
        Me.TxtKilometros.Name = "TxtKilometros"
        Me.TxtKilometros.ReadOnly = True
        Me.TxtKilometros.Size = New System.Drawing.Size(100, 20)
        Me.TxtKilometros.TabIndex = 1
        Me.TxtKilometros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Combustible"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Comentarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Dominio"
        '
        'TxtColor
        '
        Me.TxtColor.BackColor = System.Drawing.Color.LightGreen
        Me.TxtColor.Location = New System.Drawing.Point(248, 54)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.ReadOnly = True
        Me.TxtColor.Size = New System.Drawing.Size(100, 20)
        Me.TxtColor.TabIndex = 2
        Me.TxtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtComentarios
        '
        Me.TxtComentarios.BackColor = System.Drawing.Color.LightGreen
        Me.TxtComentarios.Location = New System.Drawing.Point(25, 211)
        Me.TxtComentarios.Multiline = True
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.ReadOnly = True
        Me.TxtComentarios.Size = New System.Drawing.Size(350, 74)
        Me.TxtComentarios.TabIndex = 11
        '
        'TxtDominio
        '
        Me.TxtDominio.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDominio.Location = New System.Drawing.Point(25, 53)
        Me.TxtDominio.MaxLength = 13
        Me.TxtDominio.Name = "TxtDominio"
        Me.TxtDominio.ReadOnly = True
        Me.TxtDominio.Size = New System.Drawing.Size(69, 20)
        Me.TxtDominio.TabIndex = 0
        '
        'BtnImagen
        '
        Me.BtnImagen.Enabled = False
        Me.BtnImagen.Image = Global.Gestion_Taller.My.Resources.Resources.search_plus
        Me.BtnImagen.Location = New System.Drawing.Point(485, 244)
        Me.BtnImagen.Name = "BtnImagen"
        Me.BtnImagen.Size = New System.Drawing.Size(91, 41)
        Me.BtnImagen.TabIndex = 12
        Me.BtnImagen.Text = "Imagen"
        Me.BtnImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImagen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(390, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Cilindrada"
        '
        'TxtCilindrada
        '
        Me.TxtCilindrada.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCilindrada.Location = New System.Drawing.Point(139, 132)
        Me.TxtCilindrada.Name = "TxtCilindrada"
        Me.TxtCilindrada.ReadOnly = True
        Me.TxtCilindrada.Size = New System.Drawing.Size(100, 20)
        Me.TxtCilindrada.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Tipo motor"
        '
        'TxtTipoMotor
        '
        Me.TxtTipoMotor.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTipoMotor.Location = New System.Drawing.Point(25, 132)
        Me.TxtTipoMotor.Name = "TxtTipoMotor"
        Me.TxtTipoMotor.ReadOnly = True
        Me.TxtTipoMotor.Size = New System.Drawing.Size(100, 20)
        Me.TxtTipoMotor.TabIndex = 6
        Me.TxtTipoMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(166, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Aseguradora"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "V.T.V."
        '
        'DTPvtv
        '
        Me.DTPvtv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPvtv.Location = New System.Drawing.Point(248, 132)
        Me.DTPvtv.Name = "DTPvtv"
        Me.DTPvtv.Size = New System.Drawing.Size(100, 20)
        Me.DTPvtv.TabIndex = 8
        '
        'CBaseguradora
        '
        Me.CBaseguradora.BackColor = System.Drawing.Color.LightGreen
        Me.CBaseguradora.FormattingEnabled = True
        Me.CBaseguradora.Location = New System.Drawing.Point(166, 172)
        Me.CBaseguradora.Name = "CBaseguradora"
        Me.CBaseguradora.Size = New System.Drawing.Size(182, 21)
        Me.CBaseguradora.TabIndex = 10
        '
        'TxtImagen
        '
        Me.TxtImagen.Location = New System.Drawing.Point(418, 205)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(142, 20)
        Me.TxtImagen.TabIndex = 82
        Me.TxtImagen.Visible = False
        '
        'CBcombustible
        '
        Me.CBcombustible.BackColor = System.Drawing.Color.LightGreen
        Me.CBcombustible.FormattingEnabled = True
        Me.CBcombustible.Items.AddRange(New Object() {"Nafta", "Nafta - GNC", "Diesel"})
        Me.CBcombustible.Location = New System.Drawing.Point(248, 92)
        Me.CBcombustible.Name = "CBcombustible"
        Me.CBcombustible.Size = New System.Drawing.Size(100, 21)
        Me.CBcombustible.TabIndex = 5
        '
        'DGVvehiculos
        '
        Me.DGVvehiculos.AllowUserToAddRows = False
        Me.DGVvehiculos.AllowUserToDeleteRows = False
        Me.DGVvehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVvehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVvehiculos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVvehiculos.Location = New System.Drawing.Point(12, 291)
        Me.DGVvehiculos.Name = "DGVvehiculos"
        Me.DGVvehiculos.ReadOnly = True
        Me.DGVvehiculos.RowHeadersVisible = False
        Me.DGVvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVvehiculos.Size = New System.Drawing.Size(589, 219)
        Me.DGVvehiculos.TabIndex = 89
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.BtnRefresh.Location = New System.Drawing.Point(418, 516)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.BtnRefresh.TabIndex = 91
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(479, 526)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(112, 29)
        Me.BtnSeleccionar.TabIndex = 90
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        Me.BtnSeleccionar.Visible = False
        '
        'BtnAddVehiculoEntradaTaller
        '
        Me.BtnAddVehiculoEntradaTaller.Location = New System.Drawing.Point(13, 526)
        Me.BtnAddVehiculoEntradaTaller.Name = "BtnAddVehiculoEntradaTaller"
        Me.BtnAddVehiculoEntradaTaller.Size = New System.Drawing.Size(147, 29)
        Me.BtnAddVehiculoEntradaTaller.TabIndex = 92
        Me.BtnAddVehiculoEntradaTaller.Text = "Agregar entrada taller"
        Me.BtnAddVehiculoEntradaTaller.UseVisualStyleBackColor = True
        Me.BtnAddVehiculoEntradaTaller.Visible = False
        '
        'CBMarca
        '
        Me.CBMarca.BackColor = System.Drawing.Color.LightGreen
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(25, 90)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(100, 21)
        Me.CBMarca.TabIndex = 3
        '
        'CBModelo
        '
        Me.CBModelo.BackColor = System.Drawing.Color.LightGreen
        Me.CBModelo.FormattingEnabled = True
        Me.CBModelo.Location = New System.Drawing.Point(139, 92)
        Me.CBModelo.Name = "CBModelo"
        Me.CBModelo.Size = New System.Drawing.Size(100, 21)
        Me.CBModelo.TabIndex = 4
        '
        'FrmVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 571)
        Me.Controls.Add(Me.CBModelo)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.BtnAddVehiculoEntradaTaller)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.DGVvehiculos)
        Me.Controls.Add(Me.CBcombustible)
        Me.Controls.Add(Me.CBaseguradora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPvtv)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtCilindrada)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTipoMotor)
        Me.Controls.Add(Me.BtnImagen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtPoliza)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtKilometros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtColor)
        Me.Controls.Add(Me.TxtComentarios)
        Me.Controls.Add(Me.TxtDominio)
        Me.Controls.Add(Me.TSClientes)
        Me.Controls.Add(Me.TxtImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVehiculo"
        Me.TSClientes.ResumeLayout(False)
        Me.TSClientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVvehiculos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtKilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtColor As System.Windows.Forms.TextBox
    Friend WithEvents TxtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents TxtDominio As System.Windows.Forms.TextBox
    Friend WithEvents BtnImagen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCilindrada As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTipoMotor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTPvtv As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBaseguradora As System.Windows.Forms.ComboBox
    Friend WithEvents TxtImagen As System.Windows.Forms.TextBox
    Friend WithEvents CBcombustible As System.Windows.Forms.ComboBox
    Friend WithEvents DGVvehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnAddVehiculoEntradaTaller As System.Windows.Forms.Button
    Friend WithEvents CBMarca As System.Windows.Forms.ComboBox
    Friend WithEvents CBModelo As System.Windows.Forms.ComboBox
End Class
