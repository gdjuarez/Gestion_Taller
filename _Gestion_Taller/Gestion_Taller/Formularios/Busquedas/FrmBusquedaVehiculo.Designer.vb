<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaVehiculo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewVehiculo = New System.Windows.Forms.DataGridView()
        Me.TxtVehiculo = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BtnCopiarVehiculo = New System.Windows.Forms.Button()
        Me.BtnCopiarEntradaTaller = New System.Windows.Forms.Button()
        Me.BtnAddVehiculo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda de Vehiculos"
        '
        'DataGridViewVehiculo
        '
        Me.DataGridViewVehiculo.AllowUserToAddRows = False
        Me.DataGridViewVehiculo.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewVehiculo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculo.Location = New System.Drawing.Point(12, 98)
        Me.DataGridViewVehiculo.Name = "DataGridViewVehiculo"
        Me.DataGridViewVehiculo.ReadOnly = True
        Me.DataGridViewVehiculo.RowHeadersVisible = False
        Me.DataGridViewVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculo.Size = New System.Drawing.Size(950, 421)
        Me.DataGridViewVehiculo.TabIndex = 1
        '
        'TxtVehiculo
        '
        Me.TxtVehiculo.Location = New System.Drawing.Point(305, 65)
        Me.TxtVehiculo.Name = "TxtVehiculo"
        Me.TxtVehiculo.Size = New System.Drawing.Size(313, 20)
        Me.TxtVehiculo.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Taller.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(914, 1)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 39
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BtnCopiarVehiculo
        '
        Me.BtnCopiarVehiculo.Image = CType(resources.GetObject("BtnCopiarVehiculo.Image"), System.Drawing.Image)
        Me.BtnCopiarVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiarVehiculo.Location = New System.Drawing.Point(819, 55)
        Me.BtnCopiarVehiculo.Name = "BtnCopiarVehiculo"
        Me.BtnCopiarVehiculo.Size = New System.Drawing.Size(89, 38)
        Me.BtnCopiarVehiculo.TabIndex = 49
        Me.BtnCopiarVehiculo.Text = "Copiar"
        Me.BtnCopiarVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarVehiculo.UseVisualStyleBackColor = True
        Me.BtnCopiarVehiculo.Visible = False
        '
        'BtnCopiarEntradaTaller
        '
        Me.BtnCopiarEntradaTaller.Image = CType(resources.GetObject("BtnCopiarEntradaTaller.Image"), System.Drawing.Image)
        Me.BtnCopiarEntradaTaller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiarEntradaTaller.Location = New System.Drawing.Point(819, 55)
        Me.BtnCopiarEntradaTaller.Name = "BtnCopiarEntradaTaller"
        Me.BtnCopiarEntradaTaller.Size = New System.Drawing.Size(89, 38)
        Me.BtnCopiarEntradaTaller.TabIndex = 50
        Me.BtnCopiarEntradaTaller.Text = "Copiar"
        Me.BtnCopiarEntradaTaller.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarEntradaTaller.UseVisualStyleBackColor = True
        Me.BtnCopiarEntradaTaller.Visible = False
        '
        'BtnAddVehiculo
        '
        Me.BtnAddVehiculo.Image = Global.Gestion_Taller.My.Resources.Resources.addVehiculo
        Me.BtnAddVehiculo.Location = New System.Drawing.Point(924, 53)
        Me.BtnAddVehiculo.Name = "BtnAddVehiculo"
        Me.BtnAddVehiculo.Size = New System.Drawing.Size(38, 38)
        Me.BtnAddVehiculo.TabIndex = 51
        Me.BtnAddVehiculo.UseVisualStyleBackColor = True
        '
        'FrmBusquedaVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 531)
        Me.Controls.Add(Me.BtnAddVehiculo)
        Me.Controls.Add(Me.BtnCopiarEntradaTaller)
        Me.Controls.Add(Me.BtnCopiarVehiculo)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtVehiculo)
        Me.Controls.Add(Me.DataGridViewVehiculo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Vehiculos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewVehiculo As System.Windows.Forms.DataGridView
    Friend WithEvents TxtVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarVehiculo As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarEntradaTaller As System.Windows.Forms.Button
    Friend WithEvents BtnAddVehiculo As System.Windows.Forms.Button
End Class
