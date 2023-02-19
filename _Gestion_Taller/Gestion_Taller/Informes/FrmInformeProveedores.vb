Public Class FrmInformeProveedores

    Private Sub FrmInformeProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.proveedoresTableAdapter.Fill(Me.G_TallerDataSetProveedores.proveedores)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class