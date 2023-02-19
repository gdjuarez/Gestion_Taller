Public Class FrmNavegador

    Private Sub FrmNavegador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim afip As String = "https://auth.afip.gob.ar/contribuyente_/login.xhtml"
        WebBrowser1.Navigate(afip)
    End Sub
End Class