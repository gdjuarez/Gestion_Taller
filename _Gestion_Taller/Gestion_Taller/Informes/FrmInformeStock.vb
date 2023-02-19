Public Class FrmInformeStock

    Private Sub FrmInformeStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.vistaarticulosystockyprecioTableAdapter.Fill(Me.G_TallerDataSetStock.vistaarticulosystockyprecio)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class