Public Class FrmAbout

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnWeb_Click(sender As Object, e As EventArgs) Handles BtnWeb.Click
        Process.Start("www.gifsys.ml")
    End Sub

    Private Sub BtnMail_Click(sender As Object, e As EventArgs) Handles BtnMail.Click
        Try
            Dim Para As String = "mailto:infogifsys@gmail.com"
            System.Diagnostics.Process.Start(Para)
        Catch ex As Exception
            'Label1.Text = ex.Message
        End Try

    End Sub
End Class