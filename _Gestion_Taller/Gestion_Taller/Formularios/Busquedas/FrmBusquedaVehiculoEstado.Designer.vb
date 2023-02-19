<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaVehiculoEstado
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.DataGridViewVehiculoEstado = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.CBestado = New System.Windows.Forms.ComboBox()
        Me.TxtVehiculo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewVehiculoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(12, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 42)
        Me.Panel1.TabIndex = 0
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(216, 3)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(465, 31)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Busqueda de Vehiculos por estado"
        '
        'DataGridViewVehiculoEstado
        '
        Me.DataGridViewVehiculoEstado.AllowUserToAddRows = False
        Me.DataGridViewVehiculoEstado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewVehiculoEstado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVehiculoEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVehiculoEstado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVehiculoEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculoEstado.Location = New System.Drawing.Point(12, 99)
        Me.DataGridViewVehiculoEstado.Name = "DataGridViewVehiculoEstado"
        Me.DataGridViewVehiculoEstado.ReadOnly = True
        Me.DataGridViewVehiculoEstado.RowHeadersVisible = False
        Me.DataGridViewVehiculoEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculoEstado.Size = New System.Drawing.Size(950, 420)
        Me.DataGridViewVehiculoEstado.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(914, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 39
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'CBestado
        '
        Me.CBestado.FormattingEnabled = True
        Me.CBestado.Items.AddRange(New Object() {"En Taller", "Fuera de Taller"})
        Me.CBestado.Location = New System.Drawing.Point(787, 64)
        Me.CBestado.Name = "CBestado"
        Me.CBestado.Size = New System.Drawing.Size(121, 21)
        Me.CBestado.TabIndex = 50
        Me.CBestado.Text = "En Taller"
        '
        'TxtVehiculo
        '
        Me.TxtVehiculo.Location = New System.Drawing.Point(365, 64)
        Me.TxtVehiculo.Name = "TxtVehiculo"
        Me.TxtVehiculo.Size = New System.Drawing.Size(244, 20)
        Me.TxtVehiculo.TabIndex = 1
        '
        'FrmBusquedaVehiculoEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 531)
        Me.Controls.Add(Me.CBestado)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtVehiculo)
        Me.Controls.Add(Me.DataGridViewVehiculoEstado)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaVehiculoEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Vehiculos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewVehiculoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents DataGridViewVehiculoEstado As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents CBestado As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVehiculo As System.Windows.Forms.TextBox
End Class
