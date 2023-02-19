<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Me.BtnMail = New System.Windows.Forms.Button()
        Me.BtnWeb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMail
        '
        Me.BtnMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMail.BackgroundImage = Global.Gestion_Taller.My.Resources.Resources.BtnGifSysAboutM
        Me.BtnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMail.Location = New System.Drawing.Point(26, 288)
        Me.BtnMail.Name = "BtnMail"
        Me.BtnMail.Size = New System.Drawing.Size(530, 50)
        Me.BtnMail.TabIndex = 0
        '
        'BtnWeb
        '
        Me.BtnWeb.BackgroundImage = Global.Gestion_Taller.My.Resources.Resources.BtnGifSysAbout
        Me.BtnWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnWeb.Location = New System.Drawing.Point(26, 232)
        Me.BtnWeb.Name = "BtnWeb"
        Me.BtnWeb.Size = New System.Drawing.Size(530, 52)
        Me.BtnWeb.TabIndex = 1
        Me.BtnWeb.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Gestion_Taller.My.Resources.Resources.Gif_Sys_About
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 471)
        Me.Controls.Add(Me.BtnMail)
        Me.Controls.Add(Me.BtnWeb)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnWeb As Button
    Friend WithEvents BtnMail As Button
End Class
