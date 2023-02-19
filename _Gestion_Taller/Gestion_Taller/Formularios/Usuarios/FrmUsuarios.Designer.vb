<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSRep = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TSRep.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(262, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(259, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Usuarios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSRep
        '
        Me.TSRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TSRep.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSRep.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNuevo, Me.tsbtnEditar, Me.tsbtnEliminar, Me.ToolStripSeparator2, Me.tsbtnGuardar, Me.tsbtnCancelar, Me.ToolStripSeparator3, Me.tsbtnBuscar})
        Me.TSRep.Location = New System.Drawing.Point(0, 0)
        Me.TSRep.Name = "TSRep"
        Me.TSRep.Size = New System.Drawing.Size(403, 39)
        Me.TSRep.Stretch = True
        Me.TSRep.TabIndex = 53
        Me.TSRep.Text = "ToolStrip1"
        '
        'tsbtnNuevo
        '
        Me.tsbtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnNuevo.Image = CType(resources.GetObject("tsbtnNuevo.Image"), System.Drawing.Image)
        Me.tsbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNuevo.Name = "tsbtnNuevo"
        Me.tsbtnNuevo.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnNuevo.Text = "nuevo"
        '
        'tsbtnEditar
        '
        Me.tsbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditar.Image = CType(resources.GetObject("tsbtnEditar.Image"), System.Drawing.Image)
        Me.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditar.Name = "tsbtnEditar"
        Me.tsbtnEditar.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnEditar.Text = "editar"
        '
        'tsbtnEliminar
        '
        Me.tsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEliminar.Image = CType(resources.GetObject("tsbtnEliminar.Image"), System.Drawing.Image)
        Me.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEliminar.Name = "tsbtnEliminar"
        Me.tsbtnEliminar.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnEliminar.Text = "eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbtnGuardar
        '
        Me.tsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnGuardar.Enabled = False
        Me.tsbtnGuardar.Image = CType(resources.GetObject("tsbtnGuardar.Image"), System.Drawing.Image)
        Me.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardar.Name = "tsbtnGuardar"
        Me.tsbtnGuardar.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnGuardar.Text = "guardar"
        '
        'tsbtnCancelar
        '
        Me.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancelar.Enabled = False
        Me.tsbtnCancelar.Image = CType(resources.GetObject("tsbtnCancelar.Image"), System.Drawing.Image)
        Me.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancelar.Name = "tsbtnCancelar"
        Me.tsbtnCancelar.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnCancelar.Text = "cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbtnBuscar
        '
        Me.tsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBuscar.Image = CType(resources.GetObject("tsbtnBuscar.Image"), System.Drawing.Image)
        Me.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBuscar.Name = "tsbtnBuscar"
        Me.tsbtnBuscar.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnBuscar.Text = "buscar usuarios"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(18, 131)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 52
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(18, 74)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 50
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(16, 111)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 51
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(16, 54)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 49
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 211)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TSRep)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Usuarios"
        Me.TSRep.ResumeLayout(False)
        Me.TSRep.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TSRep As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
End Class
