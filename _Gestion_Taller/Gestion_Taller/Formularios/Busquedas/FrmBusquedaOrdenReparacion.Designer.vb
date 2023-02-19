<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaOrdenReparacion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaOrdenReparacion))
        Me.TxtReparacion = New System.Windows.Forms.TextBox()
        Me.DataGridViewOrdenRepa = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtDominio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.btnCopiarSalidaTaller = New System.Windows.Forms.Button()
        Me.BtnCopiarRetiroVehPagado = New System.Windows.Forms.Button()
        Me.BtnImprimirPresupuesto = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEliminarRetiro = New System.Windows.Forms.Button()
        CType(Me.DataGridViewOrdenRepa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtReparacion
        '
        Me.TxtReparacion.Location = New System.Drawing.Point(289, 61)
        Me.TxtReparacion.Name = "TxtReparacion"
        Me.TxtReparacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtReparacion.TabIndex = 50
        '
        'DataGridViewOrdenRepa
        '
        Me.DataGridViewOrdenRepa.AllowUserToAddRows = False
        Me.DataGridViewOrdenRepa.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewOrdenRepa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewOrdenRepa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewOrdenRepa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewOrdenRepa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrdenRepa.Location = New System.Drawing.Point(10, 93)
        Me.DataGridViewOrdenRepa.Name = "DataGridViewOrdenRepa"
        Me.DataGridViewOrdenRepa.ReadOnly = True
        Me.DataGridViewOrdenRepa.RowHeadersVisible = False
        Me.DataGridViewOrdenRepa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewOrdenRepa.Size = New System.Drawing.Size(946, 373)
        Me.DataGridViewOrdenRepa.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 38)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de Orden de reparación"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(898, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_clear_36
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(12, 53)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(90, 36)
        Me.BtnLimpiar.TabIndex = 53
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtDominio
        '
        Me.TxtDominio.Location = New System.Drawing.Point(446, 61)
        Me.TxtDominio.Name = "TxtDominio"
        Me.TxtDominio.Size = New System.Drawing.Size(100, 20)
        Me.TxtDominio.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "IdReparacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Dominio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(549, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "IdCliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(599, 61)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(200, 20)
        Me.TxtCliente.TabIndex = 57
        '
        'btnCopiarSalidaTaller
        '
        Me.btnCopiarSalidaTaller.Image = CType(resources.GetObject("btnCopiarSalidaTaller.Image"), System.Drawing.Image)
        Me.btnCopiarSalidaTaller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarSalidaTaller.Location = New System.Drawing.Point(803, 53)
        Me.btnCopiarSalidaTaller.Name = "btnCopiarSalidaTaller"
        Me.btnCopiarSalidaTaller.Size = New System.Drawing.Size(89, 36)
        Me.btnCopiarSalidaTaller.TabIndex = 60
        Me.btnCopiarSalidaTaller.Text = "Copiar"
        Me.btnCopiarSalidaTaller.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarSalidaTaller.UseVisualStyleBackColor = True
        Me.btnCopiarSalidaTaller.Visible = False
        '
        'BtnCopiarRetiroVehPagado
        '
        Me.BtnCopiarRetiroVehPagado.Image = CType(resources.GetObject("BtnCopiarRetiroVehPagado.Image"), System.Drawing.Image)
        Me.BtnCopiarRetiroVehPagado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiarRetiroVehPagado.Location = New System.Drawing.Point(803, 53)
        Me.BtnCopiarRetiroVehPagado.Name = "BtnCopiarRetiroVehPagado"
        Me.BtnCopiarRetiroVehPagado.Size = New System.Drawing.Size(89, 36)
        Me.BtnCopiarRetiroVehPagado.TabIndex = 61
        Me.BtnCopiarRetiroVehPagado.Text = "Copiar"
        Me.BtnCopiarRetiroVehPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarRetiroVehPagado.UseVisualStyleBackColor = True
        Me.BtnCopiarRetiroVehPagado.Visible = False
        '
        'BtnImprimirPresupuesto
        '
        Me.BtnImprimirPresupuesto.Image = Global.Gestion_Taller.My.Resources.Resources.BI_print_36
        Me.BtnImprimirPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimirPresupuesto.Location = New System.Drawing.Point(108, 53)
        Me.BtnImprimirPresupuesto.Name = "BtnImprimirPresupuesto"
        Me.BtnImprimirPresupuesto.Size = New System.Drawing.Size(90, 36)
        Me.BtnImprimirPresupuesto.TabIndex = 62
        Me.BtnImprimirPresupuesto.Text = "Imprimir"
        Me.BtnImprimirPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimirPresupuesto.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = Global.Gestion_Taller.My.Resources.Resources.BI_delete_36
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(341, 472)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(283, 46)
        Me.BtnEliminar.TabIndex = 63
        Me.BtnEliminar.Text = "Eliminar Orden Reparacion"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
        '
        'BtnEliminarRetiro
        '
        Me.BtnEliminarRetiro.BackColor = System.Drawing.Color.Red
        Me.BtnEliminarRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarRetiro.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarRetiro.Image = Global.Gestion_Taller.My.Resources.Resources.BI_delete_36
        Me.BtnEliminarRetiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRetiro.Location = New System.Drawing.Point(341, 472)
        Me.BtnEliminarRetiro.Name = "BtnEliminarRetiro"
        Me.BtnEliminarRetiro.Size = New System.Drawing.Size(283, 46)
        Me.BtnEliminarRetiro.TabIndex = 66
        Me.BtnEliminarRetiro.Text = "Eliminar Retiro de vehiculo"
        Me.BtnEliminarRetiro.UseVisualStyleBackColor = False
        Me.BtnEliminarRetiro.Visible = False
        '
        'FrmBusquedaOrdenReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 521)
        Me.Controls.Add(Me.BtnEliminarRetiro)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnImprimirPresupuesto)
        Me.Controls.Add(Me.BtnCopiarRetiroVehPagado)
        Me.Controls.Add(Me.btnCopiarSalidaTaller)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDominio)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtReparacion)
        Me.Controls.Add(Me.DataGridViewOrdenRepa)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaOrdenReparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de orden de reparación"
        CType(Me.DataGridViewOrdenRepa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtReparacion As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewOrdenRepa As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents TxtDominio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents btnCopiarSalidaTaller As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarRetiroVehPagado As System.Windows.Forms.Button
    Friend WithEvents BtnImprimirPresupuesto As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarRetiro As System.Windows.Forms.Button
End Class
