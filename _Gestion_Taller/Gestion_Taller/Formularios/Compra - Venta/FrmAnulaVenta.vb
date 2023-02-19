Public Class FrmAnulaVenta

    Dim dtMitabla As New DataTable
    Dim dtMitabla2 As New DataTable
    Dim anularmiVenta As New ClassVenta
    Dim AnulaMiReparacion As New ClassReparacionT

    Private Sub FrmAnulaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtRazonSocial.Text = Global_RazonSocialCliente
        LlenargridVenta()

    End Sub

    Private Sub LlenargridVenta()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla2 = miGestionMySQL.Anular_Venta_Detalle(Global_AnularVenta)
        'con el dt devuelto lleno el datagriedview
        DataGridViewArtVenta.DataSource = dtMitabla2

    End Sub


    Private Sub UpdateStock()
        Dim miVenta As New ClassVenta
        Dim miconexion As New GestionMySQL
        'Dim idVta As Integer

        'con este ciclo recorro el datagridview
        For Each row As DataGridViewRow In DataGridViewArtVenta.Rows
            '------TENGO QUE RESTAR LA CANTIDAD AL STOCK-->  Stock= stock - variable
            'idArticulo, Stock, StockMinimo
            Dim consultaMysql As String = ""
            consultaMysql = "Update stockarticulos SET "
            consultaMysql += "Stock = Stock +'" & row.Cells(0).Value & "' "
            consultaMysql += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "
            Try
                miconexion.EjecutarSQL(consultaMysql)
                'MsgBox(consultaMysql)
                'MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            '-----------------------------------------------------
        Next
        miconexion.Dispose()
        miconexion.Dispose()
        MsgBox("Registro Guardado", MsgBoxStyle.Information)


    End Sub

    Private Sub BtnAnularVenta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAnularReparacion.Click


        Dim resultado As DialogResult = MessageBox.Show("Está seguro de ANULAR LA REPARACION?", "Atención Anulación de Reparación", MessageBoxButtons.YesNo)


        Dim miGestionMySQLClienteVenta As New GestionMySQL
        Dim miGestionMySQLVentaArticulo As New GestionMySQL
        Dim miGestionMySQLVentas As New GestionMySQL
        Dim miGestionMySQLReparacion As New GestionMySQL
        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        Dim sql3 As String = ""

        If resultado = Windows.Forms.DialogResult.Yes Then

            If DataGridViewArtVenta.RowCount > 0 Then
                'actualizamos stock
                UpdateStock()
                anularmiVenta.IdVenta = Global_AnularVenta
                anularmiVenta.Importe = TxtTotal.Text
                AnulaMiReparacion.IdReparacion = lblNumero.Text
                AnulaMiReparacion.FechaReparacion = "01-01-2000"


                Me.DialogResult = Windows.Forms.DialogResult.OK

                MsgBox("ANULAR VENTA N°: " & anularmiVenta.IdVenta & vbNewLine &
                       "Total: $" & anularmiVenta.Importe)

                '---------------------------------------------------------------
                Try
                    sql = "DELETE FROM VentaArticulos "
                    sql += "Where idVenta =" & anularmiVenta.IdVenta

                    miGestionMySQLVentaArticulo.EjecutarSQL(sql)
                    miGestionMySQLVentaArticulo.Dispose()

                    'MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Venta Articulos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error Venta articulo")

                End Try
                '--- ---- ---- ---- --- ---- ---- ---- ---- ---- --- 
                Try
                    sql1 = "DELETE FROM ClienteVenta "
                    sql1 += "Where idVenta =" & anularmiVenta.IdVenta

                    miGestionMySQLClienteVenta.EjecutarSQL(sql1)
                    miGestionMySQLClienteVenta.Dispose()

                    'MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Venta Cliente")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error Cliente Venta")

                End Try

                '--- ---- ---- ---- --- ---- ---- ---- ---- ---- --- 
                Try
                    sql2 = "DELETE FROM Ventas "
                    sql2 += "Where idVentas =" & anularmiVenta.IdVenta

                    miGestionMySQLVentas.EjecutarSQL(sql2)
                    miGestionMySQLVentas.Dispose()

                    'MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Venta")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error Anular venta")

                End Try

                '---------------------------------------------------------------

                Try
                    sql3 = "UPDATE reparacion SET "
                    sql3 += "FechaReparacion = STR_TO_DATE('" & AnulaMiReparacion.FechaReparacion & "','%d/%m/%Y'), "
                    sql3 += "idVenta = 0,  "
                    sql3 += "estado = 'INGRESADO'  "
                    sql3 += "WHERE idReparacion = " & AnulaMiReparacion.IdReparacion & "; "
                    ' MsgBox(sql3)
                    miGestionMySQLReparacion.EjecutarSQL(sql3)
                    miGestionMySQLReparacion.Dispose()
                    MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Reparacion")

                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos Reparacion")
                End Try
                '---------------------------------------------------------------

            Else

                Me.DialogResult = Windows.Forms.DialogResult.Ignore
                MsgBox("Seleccione una Venta para ANULAR")

            End If

            Me.Close()

        End If


    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class