Public Class FrmBackUp

    Private Sub FrmBackUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackUp.Click

        FrmHacerBackup.MdiParent = MDIMenu
        FrmHacerBackup.Show()
        Me.Close()

    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        FrmRestaurarBackUp.MdiParent = MDIMenu
        FrmRestaurarBackUp.Show()
        Me.Close()
      
    End Sub

End Class