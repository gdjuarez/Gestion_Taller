Public Class FrmDesdeHasta

    Private Sub FrmDesdeHasta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnInfVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfVenta.Click
        BtnInfVenta.Enabled = true
        GlobalDesdeVentas = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaVentas = Convert.ToDateTime(DTPhasta.Text)
        FrmInformeVentas.MdiParent = MDIMenu
        FrmInformeVentas.Show()
        Me.Close()
    End Sub

    Private Sub BtnCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfCaja.Click
        BtnInfCaja.Enabled = False
        GlobalDesdeCaja = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaCaja = Convert.ToDateTime(DTPhasta.Text)
        FrmInformeCaja.MdiParent = MDIMenu
        FrmInformeCaja.Show()
        Me.Close()
    End Sub

End Class