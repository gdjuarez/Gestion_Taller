<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TSProveedores = New System.Windows.Forms.ToolStrip()
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
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnAgregaProveedor = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTelefonoCelular = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.TSProveedores.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.BackColor = System.Drawing.Color.LightGreen
        Me.TxtIdProveedor.Location = New System.Drawing.Point(639, 65)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(68, 20)
        Me.TxtIdProveedor.TabIndex = 0
        Me.TxtIdProveedor.Text = "000"
        Me.TxtIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.BackColor = System.Drawing.Color.LightGreen
        Me.TxtRazonSocial.Location = New System.Drawing.Point(17, 65)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.ReadOnly = True
        Me.TxtRazonSocial.Size = New System.Drawing.Size(360, 20)
        Me.TxtRazonSocial.TabIndex = 1
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDomicilio.Location = New System.Drawing.Point(17, 105)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.ReadOnly = True
        Me.TxtDomicilio.Size = New System.Drawing.Size(360, 20)
        Me.TxtDomicilio.TabIndex = 2
        '
        'TxtTelefonoFijo
        '
        Me.TxtTelefonoFijo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelefonoFijo.Location = New System.Drawing.Point(17, 145)
        Me.TxtTelefonoFijo.Name = "TxtTelefonoFijo"
        Me.TxtTelefonoFijo.ReadOnly = True
        Me.TxtTelefonoFijo.Size = New System.Drawing.Size(127, 20)
        Me.TxtTelefonoFijo.TabIndex = 3
        '
        'TxtCuit
        '
        Me.TxtCuit.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCuit.Location = New System.Drawing.Point(608, 145)
        Me.TxtCuit.MaxLength = 13
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.ReadOnly = True
        Me.TxtCuit.Size = New System.Drawing.Size(105, 20)
        Me.TxtCuit.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(637, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id_Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Razon social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono fijo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CUIT"
        '
        'TSProveedores
        '
        Me.TSProveedores.BackColor = System.Drawing.Color.Gray
        Me.TSProveedores.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSProveedores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSProveedores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSProveedores.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSProveedores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.ToolStripSeparator5, Me.tsbtnEditar, Me.ToolStripSeparator4, Me.tsbtnEliminar, Me.ToolStripSeparator1, Me.tsbtnGuardar, Me.ToolStripSeparator2, Me.tsbtnCancelar, Me.ToolStripSeparator3, Me.tsbtnBuscar})
        Me.TSProveedores.Location = New System.Drawing.Point(724, 0)
        Me.TSProveedores.Name = "TSProveedores"
        Me.TSProveedores.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSProveedores.Size = New System.Drawing.Size(77, 571)
        Me.TSProveedores.TabIndex = 10
        Me.TSProveedores.Text = "ToolStrip1"
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
        'DGVProveedores
        '
        Me.DGVProveedores.AllowUserToAddRows = False
        Me.DGVProveedores.AllowUserToDeleteRows = False
        Me.DGVProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Location = New System.Drawing.Point(14, 211)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.ReadOnly = True
        Me.DGVProveedores.RowHeadersVisible = False
        Me.DGVProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProveedores.Size = New System.Drawing.Size(699, 296)
        Me.DGVProveedores.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Correo @"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.LightGreen
        Me.TxtEmail.Location = New System.Drawing.Point(313, 145)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(273, 20)
        Me.TxtEmail.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(391, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Ciudad"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCiudad.Location = New System.Drawing.Point(394, 105)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.ReadOnly = True
        Me.TxtCiudad.Size = New System.Drawing.Size(250, 20)
        Me.TxtCiudad.TabIndex = 17
        '
        'BtnCopiar
        '
        Me.BtnCopiar.Location = New System.Drawing.Point(604, 530)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(109, 28)
        Me.BtnCopiar.TabIndex = 19
        Me.BtnCopiar.Text = "Copiar Selección"
        Me.BtnCopiar.UseVisualStyleBackColor = True
        Me.BtnCopiar.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.BtnRefresh.Location = New System.Drawing.Point(550, 520)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.BtnRefresh.TabIndex = 40
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnAgregaProveedor
        '
        Me.BtnAgregaProveedor.Location = New System.Drawing.Point(435, 530)
        Me.BtnAgregaProveedor.Name = "BtnAgregaProveedor"
        Me.BtnAgregaProveedor.Size = New System.Drawing.Size(109, 28)
        Me.BtnAgregaProveedor.TabIndex = 41
        Me.BtnAgregaProveedor.Text = "Agregar Proveedor"
        Me.BtnAgregaProveedor.UseVisualStyleBackColor = True
        Me.BtnAgregaProveedor.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(369, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Altas, bajas y modificación de Proveedores"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Telefono celular"
        '
        'TxtTelefonoCelular
        '
        Me.TxtTelefonoCelular.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelefonoCelular.Location = New System.Drawing.Point(162, 145)
        Me.TxtTelefonoCelular.Name = "TxtTelefonoCelular"
        Me.TxtTelefonoCelular.ReadOnly = True
        Me.TxtTelefonoCelular.Size = New System.Drawing.Size(127, 20)
        Me.TxtTelefonoCelular.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Observaciones"
        '
        'TxtObs
        '
        Me.TxtObs.BackColor = System.Drawing.Color.LightGreen
        Me.TxtObs.Location = New System.Drawing.Point(17, 185)
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.ReadOnly = True
        Me.TxtObs.Size = New System.Drawing.Size(694, 20)
        Me.TxtObs.TabIndex = 45
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(801, 571)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtObs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTelefonoCelular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAgregaProveedor)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.DGVProveedores)
        Me.Controls.Add(Me.TSProveedores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtTelefonoFijo)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.TxtIdProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM-Proveedores"
        Me.TSProveedores.ResumeLayout(False)
        Me.TSProveedores.PerformLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefonoFijo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TSProveedores As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DGVProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents BtnCopiar As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnAgregaProveedor As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTelefonoCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
End Class
