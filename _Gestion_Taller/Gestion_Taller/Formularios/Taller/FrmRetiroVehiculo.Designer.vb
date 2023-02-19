<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetiroVehiculo
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
        Me.TxtDominio = New System.Windows.Forms.TextBox()
        Me.BtnBusquedaOrdenReparacion = New System.Windows.Forms.Button()
        Me.BtnRegistrarSalidaSinPago = New System.Windows.Forms.Button()
        Me.TxtReparacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDominio
        '
        Me.TxtDominio.Location = New System.Drawing.Point(93, 24)
        Me.TxtDominio.Name = "TxtDominio"
        Me.TxtDominio.Size = New System.Drawing.Size(76, 20)
        Me.TxtDominio.TabIndex = 0
        Me.TxtDominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnBusquedaOrdenReparacion
        '
        Me.BtnBusquedaOrdenReparacion.Location = New System.Drawing.Point(12, 22)
        Me.BtnBusquedaOrdenReparacion.Name = "BtnBusquedaOrdenReparacion"
        Me.BtnBusquedaOrdenReparacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnBusquedaOrdenReparacion.TabIndex = 1
        Me.BtnBusquedaOrdenReparacion.Text = "Busqueda de vehiculo"
        Me.BtnBusquedaOrdenReparacion.UseVisualStyleBackColor = True
        '
        'BtnRegistrarSalidaSinPago
        '
        Me.BtnRegistrarSalidaSinPago.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnRegistrarSalidaSinPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarSalidaSinPago.Location = New System.Drawing.Point(203, 94)
        Me.BtnRegistrarSalidaSinPago.Name = "BtnRegistrarSalidaSinPago"
        Me.BtnRegistrarSalidaSinPago.Size = New System.Drawing.Size(200, 50)
        Me.BtnRegistrarSalidaSinPago.TabIndex = 3
        Me.BtnRegistrarSalidaSinPago.Text = "Registrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "salida"
        Me.BtnRegistrarSalidaSinPago.UseVisualStyleBackColor = False
        '
        'TxtReparacion
        '
        Me.TxtReparacion.Location = New System.Drawing.Point(175, 24)
        Me.TxtReparacion.Name = "TxtReparacion"
        Me.TxtReparacion.Size = New System.Drawing.Size(77, 20)
        Me.TxtReparacion.TabIndex = 5
        Me.TxtReparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dominio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº reparación"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(93, 51)
        Me.TxtCliente.MaxLength = 13
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(261, 20)
        Me.TxtCliente.TabIndex = 118
        Me.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.Location = New System.Drawing.Point(26, 54)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(48, 13)
        Me.LblIdCliente.TabIndex = 119
        Me.LblIdCliente.Text = "IdCliente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.BtnBusquedaOrdenReparacion)
        Me.Panel1.Controls.Add(Me.LblIdCliente)
        Me.Panel1.Controls.Add(Me.TxtDominio)
        Me.Panel1.Controls.Add(Me.TxtCliente)
        Me.Panel1.Controls.Add(Me.TxtReparacion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(32, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 81)
        Me.Panel1.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(258, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 120
        '
        'BtnAnular
        '
        Me.BtnAnular.BackColor = System.Drawing.Color.Red
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Location = New System.Drawing.Point(32, 94)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(100, 50)
        Me.BtnAnular.TabIndex = 121
        Me.BtnAnular.Text = "Anular " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "salida"
        Me.BtnAnular.UseVisualStyleBackColor = False
        '
        'FrmRetiroVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 151)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRegistrarSalidaSinPago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRetiroVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro de vehiculo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtDominio As System.Windows.Forms.TextBox
    Friend WithEvents BtnBusquedaOrdenReparacion As System.Windows.Forms.Button
    Friend WithEvents BtnRegistrarSalidaSinPago As System.Windows.Forms.Button
    Friend WithEvents TxtReparacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
End Class
