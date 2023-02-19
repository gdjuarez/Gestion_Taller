<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.TxtClientes = New System.Windows.Forms.TextBox()
        Me.btnCopiarPresupuesto = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCopiarVentas = New System.Windows.Forms.Button()
        Me.BtnCopiarEntradaTaller = New System.Windows.Forms.Button()
        Me.BtnAltaCliente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda de Clientes"
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.AllowUserToAddRows = False
        Me.DataGridViewClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(5, 99)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.ReadOnly = True
        Me.DataGridViewClientes.RowHeadersVisible = False
        Me.DataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewClientes.Size = New System.Drawing.Size(804, 363)
        Me.DataGridViewClientes.TabIndex = 1
        '
        'TxtClientes
        '
        Me.TxtClientes.Location = New System.Drawing.Point(279, 64)
        Me.TxtClientes.Name = "TxtClientes"
        Me.TxtClientes.Size = New System.Drawing.Size(211, 20)
        Me.TxtClientes.TabIndex = 1
        '
        'btnCopiarPresupuesto
        '
        Me.btnCopiarPresupuesto.Image = CType(resources.GetObject("btnCopiarPresupuesto.Image"), System.Drawing.Image)
        Me.btnCopiarPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarPresupuesto.Location = New System.Drawing.Point(506, 55)
        Me.btnCopiarPresupuesto.Name = "btnCopiarPresupuesto"
        Me.btnCopiarPresupuesto.Size = New System.Drawing.Size(89, 38)
        Me.btnCopiarPresupuesto.TabIndex = 47
        Me.btnCopiarPresupuesto.Text = "Copiar"
        Me.btnCopiarPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarPresupuesto.UseVisualStyleBackColor = True
        Me.btnCopiarPresupuesto.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(763, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 46)
        Me.btnRefresh.TabIndex = 39
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCopiarVentas
        '
        Me.btnCopiarVentas.Image = CType(resources.GetObject("btnCopiarVentas.Image"), System.Drawing.Image)
        Me.btnCopiarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarVentas.Location = New System.Drawing.Point(174, 55)
        Me.btnCopiarVentas.Name = "btnCopiarVentas"
        Me.btnCopiarVentas.Size = New System.Drawing.Size(89, 38)
        Me.btnCopiarVentas.TabIndex = 48
        Me.btnCopiarVentas.Text = "Copiar"
        Me.btnCopiarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarVentas.UseVisualStyleBackColor = True
        Me.btnCopiarVentas.Visible = False
        '
        'BtnCopiarEntradaTaller
        '
        Me.BtnCopiarEntradaTaller.Image = CType(resources.GetObject("BtnCopiarEntradaTaller.Image"), System.Drawing.Image)
        Me.BtnCopiarEntradaTaller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiarEntradaTaller.Location = New System.Drawing.Point(601, 55)
        Me.BtnCopiarEntradaTaller.Name = "BtnCopiarEntradaTaller"
        Me.BtnCopiarEntradaTaller.Size = New System.Drawing.Size(89, 38)
        Me.BtnCopiarEntradaTaller.TabIndex = 49
        Me.BtnCopiarEntradaTaller.Text = "Copiar"
        Me.BtnCopiarEntradaTaller.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarEntradaTaller.UseVisualStyleBackColor = True
        Me.BtnCopiarEntradaTaller.Visible = False
        '
        'BtnAltaCliente
        '
        Me.BtnAltaCliente.Image = Global.Gestion_Taller.My.Resources.Resources.BI_adduser_36
        Me.BtnAltaCliente.Location = New System.Drawing.Point(763, 51)
        Me.BtnAltaCliente.Name = "BtnAltaCliente"
        Me.BtnAltaCliente.Size = New System.Drawing.Size(46, 46)
        Me.BtnAltaCliente.TabIndex = 50
        Me.BtnAltaCliente.UseVisualStyleBackColor = True
        '
        'FrmBusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 471)
        Me.Controls.Add(Me.BtnAltaCliente)
        Me.Controls.Add(Me.BtnCopiarEntradaTaller)
        Me.Controls.Add(Me.btnCopiarVentas)
        Me.Controls.Add(Me.btnCopiarPresupuesto)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtClientes)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewClientes As System.Windows.Forms.DataGridView
    Friend WithEvents TxtClientes As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCopiarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents btnCopiarVentas As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarEntradaTaller As System.Windows.Forms.Button
    Friend WithEvents BtnAltaCliente As System.Windows.Forms.Button
End Class
