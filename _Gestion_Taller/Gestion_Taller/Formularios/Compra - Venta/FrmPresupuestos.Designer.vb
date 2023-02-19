<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresupuestos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtidProducto = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNumeroPresu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewIngPedido = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewBarra = New System.Windows.Forms.DataGridView()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtStockminimo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscarCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnIngreso = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnPresupuesto = New System.Windows.Forms.Button()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxValidez = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewIngPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2013, 4, 28, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtprecioUnitario)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TxtImporte)
        Me.Panel2.Controls.Add(Me.Txtcantidad)
        Me.Panel2.Controls.Add(Me.Txtdescripcion)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtidProducto)
        Me.Panel2.Location = New System.Drawing.Point(13, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 58)
        Me.Panel2.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(517, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "P/Unit."
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.Location = New System.Drawing.Point(519, 27)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.Size = New System.Drawing.Size(65, 20)
        Me.txtprecioUnitario.TabIndex = 89
        Me.txtprecioUnitario.Text = "pre"
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(249, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Articulo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(614, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Importe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(29, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Cant."
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(612, 27)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(77, 20)
        Me.TxtImporte.TabIndex = 83
        Me.TxtImporte.Text = "0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcantidad.Location = New System.Drawing.Point(33, 24)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(38, 26)
        Me.Txtcantidad.TabIndex = 2
        Me.Txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(243, 27)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(265, 20)
        Me.Txtdescripcion.TabIndex = 80
        Me.Txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(89, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Cod."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Articulo"
        '
        'TxtidProducto
        '
        Me.TxtidProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtidProducto.Location = New System.Drawing.Point(77, 27)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.ReadOnly = True
        Me.TxtidProducto.Size = New System.Drawing.Size(160, 20)
        Me.TxtidProducto.TabIndex = 74
        Me.TxtidProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblNumeroPresu)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.DataGridViewIngPedido)
        Me.Panel3.Controls.Add(Me.DataGridViewBarra)
        Me.Panel3.Location = New System.Drawing.Point(13, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(726, 379)
        Me.Panel3.TabIndex = 73
        '
        'lblNumeroPresu
        '
        Me.lblNumeroPresu.AutoSize = True
        Me.lblNumeroPresu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPresu.Location = New System.Drawing.Point(529, 11)
        Me.lblNumeroPresu.Name = "lblNumeroPresu"
        Me.lblNumeroPresu.Size = New System.Drawing.Size(25, 16)
        Me.lblNumeroPresu.TabIndex = 79
        Me.lblNumeroPresu.Text = " n°"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Articulos ingresados al Presupuesto n°:"
        '
        'DataGridViewIngPedido
        '
        Me.DataGridViewIngPedido.AllowUserToAddRows = False
        Me.DataGridViewIngPedido.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewIngPedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewIngPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIngPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewIngPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewIngPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIngPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Column2, Me.Column3, Me.Column4, Me.Importe})
        Me.DataGridViewIngPedido.Location = New System.Drawing.Point(5, 34)
        Me.DataGridViewIngPedido.Name = "DataGridViewIngPedido"
        Me.DataGridViewIngPedido.ReadOnly = True
        Me.DataGridViewIngPedido.RowHeadersVisible = False
        Me.DataGridViewIngPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewIngPedido.Size = New System.Drawing.Size(716, 338)
        Me.DataGridViewIngPedido.TabIndex = 77
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "P/Unit."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'DataGridViewBarra
        '
        Me.DataGridViewBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarra.Enabled = False
        Me.DataGridViewBarra.Location = New System.Drawing.Point(65, 152)
        Me.DataGridViewBarra.Name = "DataGridViewBarra"
        Me.DataGridViewBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBarra.Size = New System.Drawing.Size(519, 64)
        Me.DataGridViewBarra.TabIndex = 107
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(572, 562)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(166, 35)
        Me.TxtTotal.TabIndex = 84
        Me.TxtTotal.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(486, 566)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 29)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Total: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(198, 501)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 25)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Precio"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Enabled = False
        Me.TxtPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(168, 535)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.ReadOnly = True
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(125, 31)
        Me.TxtPrecioVenta.TabIndex = 99
        Me.TxtPrecioVenta.Text = "0.00"
        Me.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 432)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Marca"
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulo.Location = New System.Drawing.Point(26, 362)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(60, 16)
        Me.Articulo.TabIndex = 96
        Me.Articulo.Text = "Articulo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(26, 294)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Codigo:"
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Location = New System.Drawing.Point(67, 23)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.ReadOnly = True
        Me.TxtImagen.Size = New System.Drawing.Size(175, 20)
        Me.TxtImagen.TabIndex = 94
        Me.TxtImagen.Visible = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(9, 452)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(283, 31)
        Me.TxtMarca.TabIndex = 93
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Enabled = False
        Me.TxtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(9, 382)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.ReadOnly = True
        Me.TxtArticulo.Size = New System.Drawing.Size(283, 31)
        Me.TxtArticulo.TabIndex = 91
        Me.TxtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdArticulo.Enabled = False
        Me.TxtIdArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdArticulo.Location = New System.Drawing.Point(9, 314)
        Me.TxtIdArticulo.MaxLength = 13
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.ReadOnly = True
        Me.TxtIdArticulo.Size = New System.Drawing.Size(283, 31)
        Me.TxtIdArticulo.TabIndex = 90
        Me.TxtIdArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtStock
        '
        Me.TxtStock.Enabled = False
        Me.TxtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(9, 535)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(52, 31)
        Me.TxtStock.TabIndex = 102
        Me.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 515)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Stock"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtStockminimo)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.TxtImagen)
        Me.Panel4.Controls.Add(Me.TxtPrecioVenta)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.TxtMarca)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.TxtArticulo)
        Me.Panel4.Controls.Add(Me.Articulo)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.TxtIdArticulo)
        Me.Panel4.Controls.Add(Me.TxtStock)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Location = New System.Drawing.Point(747, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 604)
        Me.Panel4.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Stock-Minimo"
        '
        'TxtStockminimo
        '
        Me.TxtStockminimo.Enabled = False
        Me.TxtStockminimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockminimo.Location = New System.Drawing.Point(76, 535)
        Me.TxtStockminimo.Name = "TxtStockminimo"
        Me.TxtStockminimo.ReadOnly = True
        Me.TxtStockminimo.Size = New System.Drawing.Size(86, 31)
        Me.TxtStockminimo.TabIndex = 106
        Me.TxtStockminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(29, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscarCodigoBarra
        '
        Me.TxtBuscarCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCodigoBarra.Location = New System.Drawing.Point(67, 32)
        Me.TxtBuscarCodigoBarra.MaxLength = 13
        Me.TxtBuscarCodigoBarra.Name = "TxtBuscarCodigoBarra"
        Me.TxtBuscarCodigoBarra.Size = New System.Drawing.Size(250, 20)
        Me.TxtBuscarCodigoBarra.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(87, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Agregar articulo"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.Red
        Me.BtnBorrar.Location = New System.Drawing.Point(432, 124)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(288, 40)
        Me.BtnBorrar.TabIndex = 80
        Me.BtnBorrar.Text = "Borrar seleccion del presupuesto"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnIngreso
        '
        Me.BtnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngreso.Location = New System.Drawing.Point(48, 124)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(270, 40)
        Me.BtnIngreso.TabIndex = 3
        Me.BtnIngreso.Text = "Ingresar al presupuesto"
        Me.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnIngreso.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(349, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Fecha"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_cancel_48
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(151, 557)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(137, 50)
        Me.BtnCancelar.TabIndex = 107
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnPresupuesto
        '
        Me.BtnPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPresupuesto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPresupuesto.Image = Global.Gestion_Taller.My.Resources.Resources.BI_save_48
        Me.BtnPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPresupuesto.Location = New System.Drawing.Point(20, 557)
        Me.BtnPresupuesto.Name = "BtnPresupuesto"
        Me.BtnPresupuesto.Size = New System.Drawing.Size(125, 50)
        Me.BtnPresupuesto.TabIndex = 4
        Me.BtnPresupuesto.Text = "Aceptar"
        Me.BtnPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPresupuesto.UseVisualStyleBackColor = True
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackgroundImage = Global.Gestion_Taller.My.Resources.Resources.BI_addCart_48
        Me.BtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnArticulos.Location = New System.Drawing.Point(13, 6)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(48, 48)
        Me.BtnArticulos.TabIndex = 78
        Me.BtnArticulos.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.BackgroundImage = Global.Gestion_Taller.My.Resources.Resources.BI_addP_48
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClientes.Location = New System.Drawing.Point(688, 6)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(48, 48)
        Me.BtnClientes.TabIndex = 109
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(532, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 17)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Agregar cliente"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(432, 32)
        Me.TxtRazonSocial.MaxLength = 13
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(250, 20)
        Me.TxtRazonSocial.TabIndex = 110
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.ForeColor = System.Drawing.Color.Red
        Me.LblIdCliente.Location = New System.Drawing.Point(432, 13)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(60, 13)
        Me.LblIdCliente.TabIndex = 112
        Me.LblIdCliente.Text = "Sin_Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(294, 577)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Válido por"
        '
        'ComboBoxValidez
        '
        Me.ComboBoxValidez.FormattingEnabled = True
        Me.ComboBoxValidez.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "45", "60"})
        Me.ComboBoxValidez.Location = New System.Drawing.Point(352, 574)
        Me.ComboBoxValidez.Name = "ComboBoxValidez"
        Me.ComboBoxValidez.Size = New System.Drawing.Size(37, 21)
        Me.ComboBoxValidez.TabIndex = 114
        Me.ComboBoxValidez.Text = "30"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(395, 578)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "días"
        '
        'FrmPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1064, 613)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxValidez)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblIdCliente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnPresupuesto)
        Me.Controls.Add(Me.TxtBuscarCodigoBarra)
        Me.Controls.Add(Me.BtnArticulos)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnIngreso)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmPresupuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuestos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewIngPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewIngPedido As System.Windows.Forms.DataGridView
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnIngreso As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroPresu As System.Windows.Forms.Label
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Articulo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtImagen As System.Windows.Forms.TextBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtStockminimo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuscarCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewBarra As System.Windows.Forms.DataGridView
    Friend WithEvents BtnPresupuesto As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxValidez As ComboBox
    Friend WithEvents Label12 As Label
End Class
