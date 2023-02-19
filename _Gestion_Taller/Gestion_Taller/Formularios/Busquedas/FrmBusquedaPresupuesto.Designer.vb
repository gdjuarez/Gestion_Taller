<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBusquedaPresupuesto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaPresupuesto))
        Me.TxtPresupuestos = New System.Windows.Forms.TextBox()
        Me.DataGridViewPresupuestos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BtnImprimirPresupuesto = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPresupuestos
        '
        Me.TxtPresupuestos.Location = New System.Drawing.Point(282, 60)
        Me.TxtPresupuestos.Name = "TxtPresupuestos"
        Me.TxtPresupuestos.Size = New System.Drawing.Size(246, 20)
        Me.TxtPresupuestos.TabIndex = 50
        '
        'DataGridViewPresupuestos
        '
        Me.DataGridViewPresupuestos.AllowUserToAddRows = False
        Me.DataGridViewPresupuestos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewPresupuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPresupuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPresupuestos.Location = New System.Drawing.Point(10, 93)
        Me.DataGridViewPresupuestos.Name = "DataGridViewPresupuestos"
        Me.DataGridViewPresupuestos.ReadOnly = True
        Me.DataGridViewPresupuestos.RowHeadersVisible = False
        Me.DataGridViewPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPresupuestos.Size = New System.Drawing.Size(804, 416)
        Me.DataGridViewPresupuestos.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 38)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de Presupuesto"
        '
        'btnCopiar
        '
        Me.btnCopiar.Image = CType(resources.GetObject("btnCopiar.Image"), System.Drawing.Image)
        Me.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiar.Location = New System.Drawing.Point(550, 51)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(89, 36)
        Me.btnCopiar.TabIndex = 52
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiar.UseVisualStyleBackColor = True
        Me.btnCopiar.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(766, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BtnImprimirPresupuesto
        '
        Me.BtnImprimirPresupuesto.Image = Global.Gestion_Taller.My.Resources.Resources.BI_print_36
        Me.BtnImprimirPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimirPresupuesto.Location = New System.Drawing.Point(163, 51)
        Me.BtnImprimirPresupuesto.Name = "BtnImprimirPresupuesto"
        Me.BtnImprimirPresupuesto.Size = New System.Drawing.Size(89, 36)
        Me.BtnImprimirPresupuesto.TabIndex = 53
        Me.BtnImprimirPresupuesto.Text = "Imprimir"
        Me.BtnImprimirPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimirPresupuesto.UseVisualStyleBackColor = True
        '
        'FrmBusquedaPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 521)
        Me.Controls.Add(Me.BtnImprimirPresupuesto)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtPresupuestos)
        Me.Controls.Add(Me.DataGridViewPresupuestos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de presupuesto"
        CType(Me.DataGridViewPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCopiar As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtPresupuestos As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewPresupuestos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnImprimirPresupuesto As System.Windows.Forms.Button
End Class
