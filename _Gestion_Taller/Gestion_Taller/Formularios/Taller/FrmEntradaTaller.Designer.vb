<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradaTaller
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
        Me.BtnAgregarVehiculo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtVehiculo = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregarCliente = New System.Windows.Forms.Button()
        Me.DTPEntradaTaller = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblOrdedenRepa = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.TxtKilometros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAgregarVehiculo
        '
        Me.BtnAgregarVehiculo.Image = Global.Gestion_Taller.My.Resources.Resources.BI_find_b2_36
        Me.BtnAgregarVehiculo.Location = New System.Drawing.Point(112, 100)
        Me.BtnAgregarVehiculo.Name = "BtnAgregarVehiculo"
        Me.BtnAgregarVehiculo.Size = New System.Drawing.Size(36, 36)
        Me.BtnAgregarVehiculo.TabIndex = 0
        Me.BtnAgregarVehiculo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Vehiculo"
        '
        'TxtVehiculo
        '
        Me.TxtVehiculo.Location = New System.Drawing.Point(154, 115)
        Me.TxtVehiculo.Name = "TxtVehiculo"
        Me.TxtVehiculo.Size = New System.Drawing.Size(100, 20)
        Me.TxtVehiculo.TabIndex = 2
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(140, 70)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(201, 20)
        Me.TxtCliente.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar Cliente"
        '
        'BtnAgregarCliente
        '
        Me.BtnAgregarCliente.Image = Global.Gestion_Taller.My.Resources.Resources.BI_findUser_36
        Me.BtnAgregarCliente.Location = New System.Drawing.Point(98, 55)
        Me.BtnAgregarCliente.Name = "BtnAgregarCliente"
        Me.BtnAgregarCliente.Size = New System.Drawing.Size(36, 36)
        Me.BtnAgregarCliente.TabIndex = 3
        Me.BtnAgregarCliente.UseVisualStyleBackColor = True
        '
        'DTPEntradaTaller
        '
        Me.DTPEntradaTaller.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEntradaTaller.Location = New System.Drawing.Point(347, 69)
        Me.DTPEntradaTaller.Name = "DTPEntradaTaller"
        Me.DTPEntradaTaller.Size = New System.Drawing.Size(100, 20)
        Me.DTPEntradaTaller.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seleccionar fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Entrada de taller"
        '
        'TxtDiagnostico
        '
        Me.TxtDiagnostico.Location = New System.Drawing.Point(24, 160)
        Me.TxtDiagnostico.Multiline = True
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.Size = New System.Drawing.Size(497, 176)
        Me.TxtDiagnostico.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Diagnostico"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(446, 340)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 27)
        Me.BtnAceptar.TabIndex = 11
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(24, 340)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblOrdedenRepa
        '
        Me.LblOrdedenRepa.AutoSize = True
        Me.LblOrdedenRepa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrdedenRepa.Location = New System.Drawing.Point(362, 29)
        Me.LblOrdedenRepa.Name = "LblOrdedenRepa"
        Me.LblOrdedenRepa.Size = New System.Drawing.Size(45, 25)
        Me.LblOrdedenRepa.TabIndex = 13
        Me.LblOrdedenRepa.Text = "000"
        Me.LblOrdedenRepa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(137, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Orden de reparación Nº "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.Location = New System.Drawing.Point(221, 54)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(0, 13)
        Me.LblIdCliente.TabIndex = 15
        '
        'TxtKilometros
        '
        Me.TxtKilometros.Location = New System.Drawing.Point(292, 115)
        Me.TxtKilometros.Name = "TxtKilometros"
        Me.TxtKilometros.Size = New System.Drawing.Size(100, 20)
        Me.TxtKilometros.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "kilometros"
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(171, 342)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(202, 23)
        Me.BtnAnular.TabIndex = 18
        Me.BtnAnular.Text = "Anular Orden Reparacion"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'FrmEntradaTaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 371)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.TxtKilometros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblIdCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblOrdedenRepa)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDiagnostico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTPEntradaTaller)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAgregarCliente)
        Me.Controls.Add(Me.TxtVehiculo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAgregarVehiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEntradaTaller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada Taller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregarVehiculo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents DTPEntradaTaller As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents LblOrdedenRepa As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents TxtKilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
End Class
