Public Class FrmOrdenReparacion

    Private Sub FrmOrdenReparacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'G_TallerDataSetOrdenReparacion.Get_OrdenReparacion' Puede moverla o quitarla según sea necesario.
        Me.Get_OrdenReparacionTableAdapter.Fill(Me.G_TallerDataSetOrdenReparacion.Get_OrdenReparacion, Global_numeroReparacion)
        Me.misdatosTableAdapter.Fill(Me.G_TallerDataSetMisDatos.misdatos)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class