<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenReparacion
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.G_TallerDataSetOrdenReparacion = New Gestion_Taller.G_TallerDataSetOrdenReparacion()
        Me.Get_OrdenReparacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_OrdenReparacionTableAdapter = New Gestion_Taller.G_TallerDataSetOrdenReparacionTableAdapters.Get_OrdenReparacionTableAdapter()
        Me.G_TallerDataSetMisDatos = New Gestion_Taller.G_TallerDataSetMisDatos()
        Me.misdatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.misdatosTableAdapter = New Gestion_Taller.G_TallerDataSetMisDatosTableAdapters.misdatosTableAdapter()
        CType(Me.G_TallerDataSetOrdenReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_OrdenReparacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_TallerDataSetMisDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetOrdenReparacion"
        ReportDataSource1.Value = Me.Get_OrdenReparacionBindingSource
        ReportDataSource2.Name = "DataSetMisDatos"
        ReportDataSource2.Value = Me.misdatosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_Taller.ReportOrdenReparacion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(694, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'G_TallerDataSetOrdenReparacion
        '
        Me.G_TallerDataSetOrdenReparacion.DataSetName = "G_TallerDataSetOrdenReparacion"
        Me.G_TallerDataSetOrdenReparacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Get_OrdenReparacionBindingSource
        '
        Me.Get_OrdenReparacionBindingSource.DataMember = "Get_OrdenReparacion"
        Me.Get_OrdenReparacionBindingSource.DataSource = Me.G_TallerDataSetOrdenReparacion
        '
        'Get_OrdenReparacionTableAdapter
        '
        Me.Get_OrdenReparacionTableAdapter.ClearBeforeFill = True
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
        'FrmOrdenReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrdenReparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de reparación"
        CType(Me.G_TallerDataSetOrdenReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_OrdenReparacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G_TallerDataSetMisDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Get_OrdenReparacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_TallerDataSetOrdenReparacion As Gestion_Taller.G_TallerDataSetOrdenReparacion
    Friend WithEvents misdatosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_TallerDataSetMisDatos As Gestion_Taller.G_TallerDataSetMisDatos
    Friend WithEvents Get_OrdenReparacionTableAdapter As Gestion_Taller.G_TallerDataSetOrdenReparacionTableAdapters.Get_OrdenReparacionTableAdapter
    Friend WithEvents misdatosTableAdapter As Gestion_Taller.G_TallerDataSetMisDatosTableAdapters.misdatosTableAdapter
End Class
