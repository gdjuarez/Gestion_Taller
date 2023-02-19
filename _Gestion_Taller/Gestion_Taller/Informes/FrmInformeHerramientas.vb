Public Class FrmInformeHerramientas

    Private Sub FrmInformeHerramientas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'G_tallerDataSetHerramientas.herramientas' Puede moverla o quitarla según sea necesario.
        Me.herramientasTableAdapter.Fill(Me.G_tallerDataSetHerramientas.herramientas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class