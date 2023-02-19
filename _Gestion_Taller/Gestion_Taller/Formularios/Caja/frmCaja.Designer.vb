<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSALIDA = New System.Windows.Forms.Button()
        Me.BtnINGRESO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblDETALLE = New System.Windows.Forms.Label()
        Me.LblIngresoEgreso = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxComprobante = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnArqueo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DataGridViewCaja = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtnumero = New System.Windows.Forms.TextBox()
        Me.Lblcodmov = New System.Windows.Forms.Label()
        Me.TxtsumaIngreso = New System.Windows.Forms.TextBox()
        Me.TxtsumaSalida = New System.Windows.Forms.TextBox()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnRepImpagas = New System.Windows.Forms.Button()
        Me.LblDominio = New System.Windows.Forms.Label()
        Me.BtnRegistrarRepImp = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(43, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FECHA:"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(112, 5)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePickerFecha.TabIndex = 1
        '
        'TxtSaldoInicial
        '
        Me.TxtSaldoInicial.Location = New System.Drawing.Point(438, 5)
        Me.TxtSaldoInicial.Name = "TxtSaldoInicial"
        Me.TxtSaldoInicial.ReadOnly = True
        Me.TxtSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoInicial.TabIndex = 3
        Me.TxtSaldoInicial.Text = "0"
        Me.TxtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSALIDA)
        Me.Panel1.Controls.Add(Me.BtnINGRESO)
        Me.Panel1.Location = New System.Drawing.Point(14, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 88)
        Me.Panel1.TabIndex = 8
        '
        'BtnSALIDA
        '
        Me.BtnSALIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSALIDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSALIDA.Location = New System.Drawing.Point(38, 48)
        Me.BtnSALIDA.Name = "BtnSALIDA"
        Me.BtnSALIDA.Size = New System.Drawing.Size(133, 37)
        Me.BtnSALIDA.TabIndex = 1
        Me.BtnSALIDA.Text = "SALIDA"
        Me.BtnSALIDA.UseVisualStyleBackColor = True
        '
        'BtnINGRESO
        '
        Me.BtnINGRESO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnINGRESO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnINGRESO.Location = New System.Drawing.Point(38, 4)
        Me.BtnINGRESO.Name = "BtnINGRESO"
        Me.BtnINGRESO.Size = New System.Drawing.Size(133, 38)
        Me.BtnINGRESO.TabIndex = 0
        Me.BtnINGRESO.Text = "INGRESO"
        Me.BtnINGRESO.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(311, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SALDO INICIAL: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(28, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TIPO DE OPERACION: "
        '
        'LblDETALLE
        '
        Me.LblDETALLE.AutoSize = True
        Me.LblDETALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDETALLE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDETALLE.Location = New System.Drawing.Point(252, 12)
        Me.LblDETALLE.Name = "LblDETALLE"
        Me.LblDETALLE.Size = New System.Drawing.Size(239, 16)
        Me.LblDETALLE.TabIndex = 12
        Me.LblDETALLE.Text = "DETALLE DE LA OPERACION DE"
        '
        'LblIngresoEgreso
        '
        Me.LblIngresoEgreso.AutoSize = True
        Me.LblIngresoEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresoEgreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblIngresoEgreso.Location = New System.Drawing.Point(492, 12)
        Me.LblIngresoEgreso.Name = "LblIngresoEgreso"
        Me.LblIngresoEgreso.Size = New System.Drawing.Size(80, 16)
        Me.LblIngresoEgreso.TabIndex = 13
        Me.LblIngresoEgreso.Text = "INGRESO "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(270, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "COMPROBANTE: "
        '
        'ComboBoxComprobante
        '
        Me.ComboBoxComprobante.FormattingEnabled = True
        Me.ComboBoxComprobante.Items.AddRange(New Object() {"DOCUMENTO INTERNO", "FACTURA", "RECIBO", "SIN COMPROBANTE", "TICKET"})
        Me.ComboBoxComprobante.Location = New System.Drawing.Point(404, 38)
        Me.ComboBoxComprobante.Name = "ComboBoxComprobante"
        Me.ComboBoxComprobante.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxComprobante.TabIndex = 18
        Me.ComboBoxComprobante.Text = "DOCUMENTO INTERNO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(35, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = " IMPORTE  A CARGAR:"
        '
        'TxtImporte
        '
        Me.TxtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporte.ForeColor = System.Drawing.Color.Blue
        Me.TxtImporte.Location = New System.Drawing.Point(213, 7)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(150, 31)
        Me.TxtImporte.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(271, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "DESCRIPCION: "
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(12, 494)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(118, 31)
        Me.BtnRegistrar.TabIndex = 23
        Me.BtnRegistrar.Text = "REGISTRAR"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnArqueo
        '
        Me.BtnArqueo.Location = New System.Drawing.Point(157, 494)
        Me.BtnArqueo.Name = "BtnArqueo"
        Me.BtnArqueo.Size = New System.Drawing.Size(104, 31)
        Me.BtnArqueo.TabIndex = 24
        Me.BtnArqueo.Text = "ARQUEO"
        Me.BtnArqueo.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.ForeColor = System.Drawing.Color.Red
        Me.BtnSalir.Location = New System.Drawing.Point(281, 494)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 31)
        Me.BtnSalir.TabIndex = 25
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DataGridViewCaja
        '
        Me.DataGridViewCaja.AllowUserToAddRows = False
        Me.DataGridViewCaja.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewCaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewCaja.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCaja.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCaja.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewCaja.Location = New System.Drawing.Point(12, 244)
        Me.DataGridViewCaja.MultiSelect = False
        Me.DataGridViewCaja.Name = "DataGridViewCaja"
        Me.DataGridViewCaja.ReadOnly = True
        Me.DataGridViewCaja.RowHeadersVisible = False
        Me.DataGridViewCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCaja.Size = New System.Drawing.Size(621, 217)
        Me.DataGridViewCaja.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(270, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "SERIE-NUMERO:"
        '
        'Txtnumero
        '
        Me.Txtnumero.Location = New System.Drawing.Point(404, 66)
        Me.Txtnumero.Name = "Txtnumero"
        Me.Txtnumero.Size = New System.Drawing.Size(118, 20)
        Me.Txtnumero.TabIndex = 17
        '
        'Lblcodmov
        '
        Me.Lblcodmov.AutoSize = True
        Me.Lblcodmov.Location = New System.Drawing.Point(526, 200)
        Me.Lblcodmov.Name = "Lblcodmov"
        Me.Lblcodmov.Size = New System.Drawing.Size(59, 13)
        Me.Lblcodmov.TabIndex = 28
        Me.Lblcodmov.Text = "Lblcodmov"
        '
        'TxtsumaIngreso
        '
        Me.TxtsumaIngreso.Location = New System.Drawing.Point(529, 468)
        Me.TxtsumaIngreso.Name = "TxtsumaIngreso"
        Me.TxtsumaIngreso.ReadOnly = True
        Me.TxtsumaIngreso.Size = New System.Drawing.Size(93, 20)
        Me.TxtsumaIngreso.TabIndex = 29
        Me.TxtsumaIngreso.Text = "0,00"
        '
        'TxtsumaSalida
        '
        Me.TxtsumaSalida.Location = New System.Drawing.Point(529, 493)
        Me.TxtsumaSalida.Name = "TxtsumaSalida"
        Me.TxtsumaSalida.ReadOnly = True
        Me.TxtsumaSalida.Size = New System.Drawing.Size(93, 20)
        Me.TxtsumaSalida.TabIndex = 30
        Me.TxtsumaSalida.Text = "0,00"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(530, 518)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.ReadOnly = True
        Me.TxtSaldo.Size = New System.Drawing.Size(92, 22)
        Me.TxtSaldo.TabIndex = 31
        Me.TxtSaldo.Text = "0,00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(431, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "INGRESOS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(446, 497)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "SALIDAS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(458, 522)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "SALDO"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtSaldoInicial)
        Me.Panel2.Controls.Add(Me.DateTimePickerFecha)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 33)
        Me.Panel2.TabIndex = 193
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.TxtDescripcion)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.LblDETALLE)
        Me.Panel5.Controls.Add(Me.LblIngresoEgreso)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Txtnumero)
        Me.Panel5.Controls.Add(Me.ComboBoxComprobante)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(12, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(621, 128)
        Me.Panel5.TabIndex = 196
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(399, 97)
        Me.TxtDescripcion.MaxLength = 119
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(212, 20)
        Me.TxtDescripcion.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.BtnRepImpagas)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.TxtImporte)
        Me.Panel6.Controls.Add(Me.LblDominio)
        Me.Panel6.Location = New System.Drawing.Point(12, 182)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(621, 50)
        Me.Panel6.TabIndex = 197
        '
        'BtnRepImpagas
        '
        Me.BtnRepImpagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepImpagas.ForeColor = System.Drawing.Color.Red
        Me.BtnRepImpagas.Location = New System.Drawing.Point(411, 4)
        Me.BtnRepImpagas.Name = "BtnRepImpagas"
        Me.BtnRepImpagas.Size = New System.Drawing.Size(191, 36)
        Me.BtnRepImpagas.TabIndex = 198
        Me.BtnRepImpagas.Text = "Reparaciones impagas"
        Me.BtnRepImpagas.UseVisualStyleBackColor = True
        '
        'LblDominio
        '
        Me.LblDominio.AutoSize = True
        Me.LblDominio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDominio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDominio.Location = New System.Drawing.Point(428, 9)
        Me.LblDominio.Name = "LblDominio"
        Me.LblDominio.Size = New System.Drawing.Size(20, 16)
        Me.LblDominio.TabIndex = 199
        Me.LblDominio.Text = " 0"
        '
        'BtnRegistrarRepImp
        '
        Me.BtnRegistrarRepImp.Location = New System.Drawing.Point(12, 494)
        Me.BtnRegistrarRepImp.Name = "BtnRegistrarRepImp"
        Me.BtnRegistrarRepImp.Size = New System.Drawing.Size(118, 31)
        Me.BtnRegistrarRepImp.TabIndex = 198
        Me.BtnRegistrarRepImp.Text = "REGISTRAR"
        Me.BtnRegistrarRepImp.UseVisualStyleBackColor = True
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 571)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.TxtsumaSalida)
        Me.Controls.Add(Me.TxtsumaIngreso)
        Me.Controls.Add(Me.DataGridViewCaja)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnArqueo)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Lblcodmov)
        Me.Controls.Add(Me.BtnRegistrarRepImp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 5)
        Me.MaximizeBox = False
        Me.Name = "frmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Control de caja"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    Friend WithEvents BtnSALIDA As System.Windows.Forms.Button
    Friend WithEvents BtnINGRESO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblDETALLE As System.Windows.Forms.Label
    Friend WithEvents LblIngresoEgreso As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxComprobante As System.Windows.Forms.ComboBox

    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnRegistrar As System.Windows.Forms.Button
    Friend WithEvents BtnArqueo As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DataGridViewCaja As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Lblcodmov As System.Windows.Forms.Label
    Friend WithEvents TxtsumaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents TxtsumaSalida As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label


    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents BtnRepImpagas As System.Windows.Forms.Button
    Friend WithEvents BtnRegistrarRepImp As System.Windows.Forms.Button
    Friend WithEvents LblDominio As System.Windows.Forms.Label

End Class
