
Imports Microsoft.Reporting.WinForms

Public Class PresupuestoImpresion

    Private Sub PresupuestoImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mipresuTableAdapter.Fill(Me.G_TallerDataSetPresupuesto.mipresu, Val(Global_numeroPresupuesto))
        Me.misdatosTableAdapter.Fill(Me.G_TallerDataSetMisDatos.misdatos)
        Me.ReportPresupuesto.RefreshReport()
    End Sub
End Class