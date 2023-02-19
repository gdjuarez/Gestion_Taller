<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesdeHasta
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
        Me.DTPdesde = New System.Windows.Forms.DateTimePicker()
        Me.DTPhasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnInfVenta = New System.Windows.Forms.Button()
        Me.BtnInfCaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DTPdesde
        '
        Me.DTPdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdesde.Location = New System.Drawing.Point(119, 49)
        Me.DTPdesde.Name = "DTPdesde"
        Me.DTPdesde.Size = New System.Drawing.Size(101, 20)
        Me.DTPdesde.TabIndex = 0
        '
        'DTPhasta
        '
        Me.DTPhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPhasta.Location = New System.Drawing.Point(119, 91)
        Me.DTPhasta.Name = "DTPhasta"
        Me.DTPhasta.Size = New System.Drawing.Size(101, 20)
        Me.DTPhasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Elija las fechas"
        '
        'BtnInfVenta
        '
        Me.BtnInfVenta.Location = New System.Drawing.Point(67, 126)
        Me.BtnInfVenta.Name = "BtnInfVenta"
        Me.BtnInfVenta.Size = New System.Drawing.Size(153, 23)
        Me.BtnInfVenta.TabIndex = 5
        Me.BtnInfVenta.Text = "Seleccionar"
        Me.BtnInfVenta.UseVisualStyleBackColor = True
        Me.BtnInfVenta.Visible = False
        '
        'BtnInfCaja
        '
        Me.BtnInfCaja.Location = New System.Drawing.Point(67, 126)
        Me.BtnInfCaja.Name = "BtnInfCaja"
        Me.BtnInfCaja.Size = New System.Drawing.Size(153, 23)
        Me.BtnInfCaja.TabIndex = 10
        Me.BtnInfCaja.Text = "Seleccionar"
        Me.BtnInfCaja.UseVisualStyleBackColor = True
        Me.BtnInfCaja.Visible = False
        '
        'FrmDesdeHasta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.BtnInfCaja)
        Me.Controls.Add(Me.BtnInfVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPhasta)
        Me.Controls.Add(Me.DTPdesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDesdeHasta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desde Hasta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTPdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPhasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnInfVenta As System.Windows.Forms.Button
    Friend WithEvents BtnInfCaja As System.Windows.Forms.Button
End Class
