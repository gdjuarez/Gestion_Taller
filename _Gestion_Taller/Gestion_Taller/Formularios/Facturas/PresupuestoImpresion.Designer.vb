<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoImpresion
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportPresupuesto = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.G_TallerDataSetPresupuesto = New Gestion_Taller.G_TallerDataSetPresupuesto()
        Me.mipresuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mipresuTableAdapter = New Gestion_Taller.G_TallerDataSetPresupuestoTableAdapters.mipresuTableAdapter()
        Me.G_TallerDataSetMisDatos = New Gestion_Taller.G_TallerDataSetMisDatos()
        Me.misdatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.misdatosTableAdapter = New Gestion_Taller.G_TallerDataSetMisDatosTableAdapters.misdatosTableAdapter()
        CType(Me.G_TallerDataSetPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mipresuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_TallerDataSetMisDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportPresupuesto
        '
        Me.ReportPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetpre"
        ReportDataSource1.Value = Me.mipresuBindingSource
        ReportDataSource2.Name = "DataSetMisDatos"
        ReportDataSource2.Value = Me.misdatosBindingSource
        Me.ReportPresupuesto.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportPresupuesto.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportPresupuesto.LocalReport.ReportEmbeddedResource = "Gestion_Taller.ReportPresu.rdlc"
        Me.ReportPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.ReportPresupuesto.Name = "ReportPresupuesto"
        Me.ReportPresupuesto.Size = New System.Drawing.Size(694, 621)
        Me.ReportPresupuesto.TabIndex = 0
        '
        'G_TallerDataSetPresupuesto
        '
        Me.G_TallerDataSetPresupuesto.DataSetName = "G_TallerDataSetPresupuesto"
        Me.G_TallerDataSetPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mipresuBindingSource
        '
        Me.mipresuBindingSource.DataMember = "mipresu"
        Me.mipresuBindingSource.DataSource = Me.G_TallerDataSetPresupuesto
        '
        'mipresuTableAdapter
        '
        Me.mipresuTableAdapter.ClearBeforeFill = True
        '
        'G_TallerDataSetMisDatos
        '
        Me.G_TallerDataSetMisDatos.DataSetName = "G_TallerDataSetMisDatos"
        Me.G_TallerDataSetMisDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'misdatosBindingSource
        '
        Me.misdatosBindingSource.DataMember = "misdatos"
        Me.misdatosBindingSource.DataSource = Me.G_TallerDataSetMisDatos
        '
        'misdatosTableAdapter
        '
        Me.misdatosTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 621)
        Me.Controls.Add(Me.ReportPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PresupuestoImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PresupuestoImpresion"
        CType(Me.G_TallerDataSetPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mipresuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G_TallerDataSetMisDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportPresupuesto As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mipresuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_TallerDataSetPresupuesto As Gestion_Taller.G_TallerDataSetPresupuesto
    Friend WithEvents misdatosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_TallerDataSetMisDatos As Gestion_Taller.G_TallerDataSetMisDatos
    Friend WithEvents mipresuTableAdapter As Gestion_Taller.G_TallerDataSetPresupuestoTableAdapters.mipresuTableAdapter
    Friend WithEvents misdatosTableAdapter As Gestion_Taller.G_TallerDataSetMisDatosTableAdapters.misdatosTableAdapter
End Class
