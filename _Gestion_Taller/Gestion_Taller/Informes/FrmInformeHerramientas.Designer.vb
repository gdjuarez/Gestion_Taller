<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeHerramientas
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.G_tallerDataSetHerramientas = New Gestion_Taller.G_tallerDataSetHerramientas()
        Me.herramientasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.herramientasTableAdapter = New Gestion_Taller.G_tallerDataSetHerramientasTableAdapters.herramientasTableAdapter()
        CType(Me.G_tallerDataSetHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.herramientasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSetHerramintas"
        ReportDataSource3.Value = Me.herramientasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_Taller.ReportHerramientas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(629, 596)
        Me.ReportViewer1.TabIndex = 0
        '
        'G_tallerDataSetHerramientas
        '
        Me.G_tallerDataSetHerramientas.DataSetName = "G_tallerDataSetHerramientas"
        Me.G_tallerDataSetHerramientas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'herramientasBindingSource
        '
        Me.herramientasBindingSource.DataMember = "herramientas"
        Me.herramientasBindingSource.DataSource = Me.G_tallerDataSetHerramientas
        '
        'herramientasTableAdapter
        '
        Me.herramientasTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeHerramientas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 596)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeHerramientas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Herramientas"
        CType(Me.G_tallerDataSetHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.herramientasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents herramientasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_tallerDataSetHerramientas As Gestion_Taller.G_tallerDataSetHerramientas
    Friend WithEvents herramientasTableAdapter As Gestion_Taller.G_tallerDataSetHerramientasTableAdapters.herramientasTableAdapter
End Class
