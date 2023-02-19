<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtTelFijo = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCodigopostal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTelCelular = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.BtnAddClienteEntrada = New System.Windows.Forms.Button()
        Me.TSClientes.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TSClientes
        '
        Me.TSClientes.BackColor = System.Drawing.Color.Gray
        Me.TSClientes.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.ToolStripSeparator5, Me.tsbtnEditar, Me.ToolStripSeparator4, Me.tsbtnEliminar, Me.ToolStripSeparator1, Me.tsbtnGuardar, Me.ToolStripSeparator2, Me.tsbtnCancelar, Me.ToolStripSeparator3, Me.tsbtnBuscar})
        Me.TSClientes.Location = New System.Drawing.Point(842, 0)
        Me.TSClientes.Name = "TSClientes"
        Me.TSClientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSClientes.Size = New System.Drawing.Size(77, 571)
        Me.TSClientes.TabIndex = 11
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
        Me.Label7.Location = New System.Drawing.Point(276, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Ciudad"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCiudad.Location = New System.Drawing.Point(279, 98)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.ReadOnly = True
        Me.TxtCiudad.Size = New System.Drawing.Size(217, 20)
        Me.TxtCiudad.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Correo @"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.LightGreen
        Me.TxtEmail.Location = New System.Drawing.Point(330, 141)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(250, 20)
        Me.TxtEmail.TabIndex = 10
        '
        'DGVClientes
        '
        Me.DGVClientes.AllowUserToAddRows = False
        Me.DGVClientes.AllowUserToDeleteRows = False
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(12, 215)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.ReadOnly = True
        Me.DGVClientes.RowHeadersVisible = False
        Me.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClientes.Size = New System.Drawing.Size(819, 299)
        Me.DGVClientes.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(592, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "CUIT /CUIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Telefono Fijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "DNI/Cuit"
        '
        'TxtCuit
        '
        Me.TxtCuit.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCuit.Location = New System.Drawing.Point(595, 141)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.ReadOnly = True
        Me.TxtCuit.Size = New System.Drawing.Size(236, 20)
        Me.TxtCuit.TabIndex = 11
        '
        'TxtTelFijo
        '
        Me.TxtTelFijo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelFijo.Location = New System.Drawing.Point(13, 141)
        Me.TxtTelFijo.Name = "TxtTelFijo"
        Me.TxtTelFijo.ReadOnly = True
        Me.TxtTelFijo.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelFijo.TabIndex = 8
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDomicilio.Location = New System.Drawing.Point(13, 98)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.ReadOnly = True
        Me.TxtDomicilio.Size = New System.Drawing.Size(250, 20)
        Me.TxtDomicilio.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombre.Location = New System.Drawing.Point(293, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(273, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.BackColor = System.Drawing.Color.LightGreen
        Me.TxtIdCliente.Location = New System.Drawing.Point(71, 9)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(146, 20)
        Me.TxtIdCliente.TabIndex = 0
        Me.TxtIdCliente.Text = "0000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Apellido "
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.LightGreen
        Me.TxtApellido.Location = New System.Drawing.Point(14, 59)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.ReadOnly = True
        Me.TxtApellido.Size = New System.Drawing.Size(264, 20)
        Me.TxtApellido.TabIndex = 1
        '
        'BtnCopiar
        '
        Me.BtnCopiar.Location = New System.Drawing.Point(697, 520)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(125, 35)
        Me.BtnCopiar.TabIndex = 10
        Me.BtnCopiar.Text = "Copiar Selección"
        Me.BtnCopiar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(328, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Altas, bajas y modificación de Clientes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(578, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Razon Social"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.BackColor = System.Drawing.Color.LightGreen
        Me.TxtRazonSocial.Location = New System.Drawing.Point(581, 59)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.ReadOnly = True
        Me.TxtRazonSocial.Size = New System.Drawing.Size(250, 20)
        Me.TxtRazonSocial.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(741, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "CodigoPostal"
        '
        'TxtCodigopostal
        '
        Me.TxtCodigopostal.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCodigopostal.Location = New System.Drawing.Point(741, 98)
        Me.TxtCodigopostal.Name = "TxtCodigopostal"
        Me.TxtCodigopostal.ReadOnly = True
        Me.TxtCodigopostal.Size = New System.Drawing.Size(90, 20)
        Me.TxtCodigopostal.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(184, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Telefono Celular"
        '
        'TxtTelCelular
        '
        Me.TxtTelCelular.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelCelular.Location = New System.Drawing.Point(176, 141)
        Me.TxtTelCelular.Name = "TxtTelCelular"
        Me.TxtTelCelular.ReadOnly = True
        Me.TxtTelCelular.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelCelular.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(511, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Provincia"
        '
        'TxtProvincia
        '
        Me.TxtProvincia.BackColor = System.Drawing.Color.LightGreen
        Me.TxtProvincia.Location = New System.Drawing.Point(514, 98)
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.ReadOnly = True
        Me.TxtProvincia.Size = New System.Drawing.Size(217, 20)
        Me.TxtProvincia.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BackColor = System.Drawing.Color.LightGreen
        Me.TxtObservaciones.Location = New System.Drawing.Point(13, 185)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ReadOnly = True
        Me.TxtObservaciones.Size = New System.Drawing.Size(818, 20)
        Me.TxtObservaciones.TabIndex = 12
        '
        'BtnAddClienteEntrada
        '
        Me.BtnAddClienteEntrada.Location = New System.Drawing.Point(566, 520)
        Me.BtnAddClienteEntrada.Name = "BtnAddClienteEntrada"
        Me.BtnAddClienteEntrada.Size = New System.Drawing.Size(125, 35)
        Me.BtnAddClienteEntrada.TabIndex = 54
        Me.BtnAddClienteEntrada.Text = "Copiar Selección"
        Me.BtnAddClienteEntrada.UseVisualStyleBackColor = True
        Me.BtnAddClienteEntrada.Visible = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(919, 571)
        Me.Controls.Add(Me.BtnAddClienteEntrada)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtProvincia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTelCelular)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtCodigopostal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.DGVClientes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtTelFijo)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdCliente)
        Me.Controls.Add(Me.TSClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM-Clientes"
        Me.TSClientes.ResumeLayout(False)
        Me.TSClientes.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents DGVClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents BtnCopiar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigopostal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTelCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddClienteEntrada As System.Windows.Forms.Button
End Class
