<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcaModelo
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
        Me.BtnAgregaMarca = New System.Windows.Forms.Button()
        Me.BtnGrabaMarca = New System.Windows.Forms.Button()
        Me.BtnBorraMarca = New System.Windows.Forms.Button()
        Me.ListBoxMarca = New System.Windows.Forms.ListBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregaModelo = New System.Windows.Forms.Button()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.BtnGrabaModelo = New System.Windows.Forms.Button()
        Me.ListBoxModelo = New System.Windows.Forms.ListBox()
        Me.BtnBorraModelo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAgregaMarca
        '
        Me.BtnAgregaMarca.Image = Global.Gestion_Taller.My.Resources.Resources.BI_add2_36
        Me.BtnAgregaMarca.Location = New System.Drawing.Point(14, 33)
        Me.BtnAgregaMarca.Name = "BtnAgregaMarca"
        Me.BtnAgregaMarca.Size = New System.Drawing.Size(55, 55)
        Me.BtnAgregaMarca.TabIndex = 0
        Me.BtnAgregaMarca.Text = "Agregar"
        Me.BtnAgregaMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregaMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAgregaMarca.UseVisualStyleBackColor = True
        '
        'BtnGrabaMarca
        '
        Me.BtnGrabaMarca.Enabled = False
        Me.BtnGrabaMarca.Image = Global.Gestion_Taller.My.Resources.Resources.BI_disk_36
        Me.BtnGrabaMarca.Location = New System.Drawing.Point(14, 88)
        Me.BtnGrabaMarca.Name = "BtnGrabaMarca"
        Me.BtnGrabaMarca.Size = New System.Drawing.Size(55, 55)
        Me.BtnGrabaMarca.TabIndex = 1
        Me.BtnGrabaMarca.Text = "Grabar"
        Me.BtnGrabaMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabaMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGrabaMarca.UseVisualStyleBackColor = True
        '
        'BtnBorraMarca
        '
        Me.BtnBorraMarca.Image = Global.Gestion_Taller.My.Resources.Resources.BI_delete_36
        Me.BtnBorraMarca.Location = New System.Drawing.Point(14, 143)
        Me.BtnBorraMarca.Name = "BtnBorraMarca"
        Me.BtnBorraMarca.Size = New System.Drawing.Size(55, 55)
        Me.BtnBorraMarca.TabIndex = 2
        Me.BtnBorraMarca.Text = "Borrar"
        Me.BtnBorraMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBorraMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBorraMarca.UseVisualStyleBackColor = True
        '
        'ListBoxMarca
        '
        Me.ListBoxMarca.FormattingEnabled = True
        Me.ListBoxMarca.Location = New System.Drawing.Point(77, 33)
        Me.ListBoxMarca.Name = "ListBoxMarca"
        Me.ListBoxMarca.Size = New System.Drawing.Size(260, 173)
        Me.ListBoxMarca.TabIndex = 3
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.LightGreen
        Me.TxtMarca.Location = New System.Drawing.Point(77, 6)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(260, 20)
        Me.TxtMarca.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnAgregaMarca)
        Me.Panel1.Controls.Add(Me.TxtMarca)
        Me.Panel1.Controls.Add(Me.BtnGrabaMarca)
        Me.Panel1.Controls.Add(Me.ListBoxMarca)
        Me.Panel1.Controls.Add(Me.BtnBorraMarca)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 210)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Marca"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnAgregaModelo)
        Me.Panel2.Controls.Add(Me.TxtModelo)
        Me.Panel2.Controls.Add(Me.BtnGrabaModelo)
        Me.Panel2.Controls.Add(Me.ListBoxModelo)
        Me.Panel2.Controls.Add(Me.BtnBorraModelo)
        Me.Panel2.Location = New System.Drawing.Point(12, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 210)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Modelo"
        '
        'BtnAgregaModelo
        '
        Me.BtnAgregaModelo.Image = Global.Gestion_Taller.My.Resources.Resources.BI_add2_36
        Me.BtnAgregaModelo.Location = New System.Drawing.Point(14, 33)
        Me.BtnAgregaModelo.Name = "BtnAgregaModelo"
        Me.BtnAgregaModelo.Size = New System.Drawing.Size(55, 55)
        Me.BtnAgregaModelo.TabIndex = 0
        Me.BtnAgregaModelo.Text = "Agregar"
        Me.BtnAgregaModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregaModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAgregaModelo.UseVisualStyleBackColor = True
        '
        'TxtModelo
        '
        Me.TxtModelo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtModelo.Location = New System.Drawing.Point(78, 6)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.ReadOnly = True
        Me.TxtModelo.Size = New System.Drawing.Size(258, 20)
        Me.TxtModelo.TabIndex = 4
        '
        'BtnGrabaModelo
        '
        Me.BtnGrabaModelo.Enabled = False
        Me.BtnGrabaModelo.Image = Global.Gestion_Taller.My.Resources.Resources.BI_disk_36
        Me.BtnGrabaModelo.Location = New System.Drawing.Point(14, 88)
        Me.BtnGrabaModelo.Name = "BtnGrabaModelo"
        Me.BtnGrabaModelo.Size = New System.Drawing.Size(55, 55)
        Me.BtnGrabaModelo.TabIndex = 1
        Me.BtnGrabaModelo.Text = "Grabar"
        Me.BtnGrabaModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabaModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGrabaModelo.UseVisualStyleBackColor = True
        '
        'ListBoxModelo
        '
        Me.ListBoxModelo.FormattingEnabled = True
        Me.ListBoxModelo.Location = New System.Drawing.Point(77, 33)
        Me.ListBoxModelo.Name = "ListBoxModelo"
        Me.ListBoxModelo.Size = New System.Drawing.Size(260, 173)
        Me.ListBoxModelo.TabIndex = 3
        '
        'BtnBorraModelo
        '
        Me.BtnBorraModelo.Image = Global.Gestion_Taller.My.Resources.Resources.BI_delete_36
        Me.BtnBorraModelo.Location = New System.Drawing.Point(14, 144)
        Me.BtnBorraModelo.Name = "BtnBorraModelo"
        Me.BtnBorraModelo.Size = New System.Drawing.Size(55, 55)
        Me.BtnBorraModelo.TabIndex = 2
        Me.BtnBorraModelo.Text = "Borrar"
        Me.BtnBorraModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBorraModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBorraModelo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 42)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Altas, bajas y modificación de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Marcas y modelos de vehiculos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 488)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(374, 23)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmMarcaModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 511)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMarcaModelo"
        Me.Text = "ABM Marca & Modelo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregaMarca As System.Windows.Forms.Button
    Friend WithEvents BtnGrabaMarca As System.Windows.Forms.Button
    Friend WithEvents BtnBorraMarca As System.Windows.Forms.Button
    Friend WithEvents ListBoxMarca As System.Windows.Forms.ListBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregaModelo As System.Windows.Forms.Button
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents BtnGrabaModelo As System.Windows.Forms.Button
    Friend WithEvents ListBoxModelo As System.Windows.Forms.ListBox
    Friend WithEvents BtnBorraModelo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
End Class
