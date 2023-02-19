Public Class FrmInformeClientes

    Private Sub FrmInformeClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.clienteTableAdapter.Fill(Me.G_TallerDataSetClientes.cliente)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class