Public Class FrmArqueo
    Dim B1000, B500, B200, B100, B50, B20, B10, B5, M2, M1, M50, M25, M10, totalArqueo As Decimal

    Private Sub FrmArqueo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'calcularsaldo(Date.Today)
        'TxtCierre.Text = Global_Saldo
    End Sub

    Private Sub BtnCierreCaja_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCierreCaja.Click

        Dim resultado As DialogResult = MessageBox.Show("En el dia de la fecha " & frmCaja.DateTimePickerFecha.Text & "" & vbNewLine &
                                                        "Se efectuará el CIERRE DE CAJA  " & vbNewLine &
                                                        "Se registrará un: " & TextBoxCierre.Text & "" & vbNewLine &
                                                        "de :$ " & TxtCierre.Text & "" & vbNewLine &
                                                       "Operador: " & usuarioGlobal & "", "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            Dim importe As Decimal
            importe = TxtCierre.Text
            If importe < 0 Then
                importe = importe * -1
            End If
            If TextBoxCierre.Text = "CIERRE EXACTO" Then
                ' MsgBox("grabar cierre exacto")
                'tipoMovimiento(INGRESO), Descripcion(operadorUsuario), tipoComprobante(CIERRE EXACTO), serienumero, Importe(0,00) 
                grabarSobranteFaltante("CIERRE", importe, "CIERRE EXACTO")
            ElseIf TextBoxCierre.Text = "SOBRANTE" Then
                'MsgBox("grabar sobrante")
                'tipoMovimiento(INGRESO), Descripcion(operadorUsuario), tipoComprobante, serienumero, Importe
                grabarSobranteFaltante("INGRESO", importe, "SOBRANTE")
            ElseIf TextBoxCierre.Text = "FALTANTE" Then
                'MsgBox("grabar faltante")
                'tipoMovimiento(SALIDA), Descripcion(operadorUsuario), tipoComprobante, serienumero,( -Importe) ' EN MENOS
                grabarSobranteFaltante("EGRESO", importe, "FALTANTE")
            End If
            'SIEMPRE IMPRIMO
            '-----------------IMPRIMIR HORIZONTAL---------------
            '---------------------------------------------------
            frmCaja.Close()
            Me.Close()
        Else
            MessageBox.Show("Acción cancelada ", "Atención !!!")
        End If
    End Sub

    Private Sub grabarSobranteFaltante(ByVal tipocierre As String, ByVal importe As String, ByVal faltaSobra As String)
        Dim miConexion As New GestionMySQL
        'MsgBox(importe)
        ' GRABO SOBRANTE-FALTANTE-EXACTO DE CAJA  
        If TextBoxCierre.Text = "-" Then
            MsgBox("Falta cerrar caja  ")
        Else
            ' idCajaMov, tipoMovimiento, Descripcion, tipoComprobante, serienumero, Importe
            Dim tipoMovimiento, descripcion, tipoComprobante, serienumero As String
            Dim consultaMysql As String = ""
            Dim importeIngreso As String
            Dim importeEgreso As String
            tipoMovimiento = "CIERRE DE CAJA "
            descripcion = faltaSobra
            tipoComprobante = "CIERRE "
            serienumero = ""
            importeIngreso = "0"
            importeEgreso = "0"
            If faltaSobra = "SOBRANTE" Then
                importeIngreso = importe
            ElseIf faltaSobra = "FALTANTE" Then
                importeEgreso = importe
            End If
            consultaMysql = "INSERT INTO cajamov (tipoMovimiento, Descripcion, tipoComprobante, serienumero, ingreso, egreso)"
            consultaMysql += "VALUES ('" & tipoMovimiento & "','" & descripcion & "','" & tipoComprobante & "','" & serienumero & "'," & Replace(importeIngreso, ",", ".") & "," & Replace(importeEgreso, ",", ".") & ")"
            Try
                miConexion.Consulta(consultaMysql)
                'MsgBox("Registro Guardado, en cajamov", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            miConexion.Dispose()

            '    '======== Obtengo el ULTIMO CODMOV GRABADO en  tabla cajamov (autoincremental)==================
            Dim meConecto2 As New GestionMySQL
            Dim dtTabla As New DataTable
            Dim miCaja As New ClassCaja
            Dim sqlcaja As String = ""

            Dim sql2 As String
            sql2 = "SELECT MAX(idCajaMov) as ultimoCodmov FROM cajamov; "
            meConecto2.EjecutarSQL(sql2)
            dtTabla = meConecto2.Consulta(sql2)
            Try
                For Each MiDataRow As DataRow In dtTabla.Rows
                    If IsDBNull(MiDataRow("ultimoCodmov")) Then
                        miCaja.CodMovCaja = 0
                    Else
                        miCaja.CodMovCaja = MiDataRow("ultimoCodmov")
                    End If
                Next
                ' MsgBox()
            Catch ex As Exception
                MsgBox("error" + ex.ToString)
            End Try
            meConecto2.Dispose()
            frmCaja.Lblcodmov.Text = miCaja.CodMovCaja
            '============================================================================================
            '----------------------- DEBE GRABAR EN LA TABLA CAJA ---------------------------
            'codCaja, codMovCaja, Fecha
            Dim Fecha, operador As String
            Dim codMovCaja As Integer
            Dim consultaMysqlcaja As String = ""
            codMovCaja = frmCaja.Lblcodmov.Text
            Fecha = frmCaja.DateTimePickerFecha.Text.Trim
            operador = usuarioGlobal
            consultaMysqlcaja = "INSERT INTO caja (codMovCaja, Fecha,operador)"
            consultaMysqlcaja += "VALUES (" & codMovCaja & ", STR_TO_DATE('" & Fecha & "','%d/%m/%Y'),'" & operador & "')"
            'MsgBox(consultaMysqlcaja)
            Try
                miConexion.Consulta(consultaMysqlcaja)
                MsgBox("Registro Guardado en caja", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            miConexion.Dispose()
        End If
    End Sub

    '================== A R Q U E O  DE  C A J A ========================================

    Private Sub Txtcant1000_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant1000.TextChanged
        If Txtcant1000.Text = "" Or Txtcant1000.Text = "0" Then
            txtB1000.Text = "0"
            B1000 = 0
        Else
            txtB1000.Text = Txtcant1000.Text * 1000
            B1000 = CDbl(txtB1000.Text)

        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant1000_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant1000.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcant500_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant500.TextChanged
        If Txtcant500.Text = "" Or Txtcant500.Text = "0" Then
            txtB500.Text = "0"
            B500 = 0
        Else
            txtB500.Text = Txtcant500.Text * 500
            B500 = CDbl(txtB500.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant500_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant500.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcant200_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant200.TextChanged
        If Txtcant200.Text = "" Or Txtcant200.Text = "0" Then
            txtB200.Text = "0"
            B200 = 0
        Else
            txtB200.Text = Txtcant200.Text * 200
            B200 = CDbl(txtB200.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant200_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant200.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcant100_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant100.TextChanged

        If Txtcant100.Text = "" Or Txtcant100.Text = "0" Then
            txtB100.Text = "0"
            B100 = 0
        Else
            txtB100.Text = Txtcant100.Text * 100
            B100 = CDbl(txtB100.Text)

        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant100_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant100.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcan50_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant50.TextChanged
        If Txtcant50.Text = "" Or Txtcant50.Text = "0" Then
            TxtB50.Text = "0"
            B50 = 0
        Else
            TxtB50.Text = Txtcant50.Text * 50
            B50 = CDbl(TxtB50.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant50_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant50.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcant20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant20.TextChanged
        If Txtcant20.Text = "" Or Txtcant20.Text = "0" Then
            TxtB20.Text = "0"
            B20 = 0
        Else
            TxtB20.Text = Txtcant20.Text * 20
            B20 = CDbl(TxtB20.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant20_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant20.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcant10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant10.TextChanged
        If Txtcant10.Text = "" Or Txtcant10.Text = "0" Then
            TxtB10.Text = "0"
            B10 = 0
        Else
            TxtB10.Text = Txtcant10.Text * 10
            B10 = CDbl(TxtB10.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant10.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub Txtcant5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcant5.TextChanged
        If Txtcant5.Text = "" Or Txtcant5.Text = "0" Then
            TxtB5.Text = "0"
            B5 = 0
        Else
            TxtB5.Text = Txtcant5.Text * 5
            B5 = CDbl(TxtB5.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub Txtcant5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcant5.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtcantM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtcantM2.TextChanged
        If TxtcantM2.Text = "" Or TxtcantM2.Text = "0" Then
            TxtM2.Text = "0"
            M2 = 0
        Else
            TxtM2.Text = TxtcantM2.Text * 2
            M2 = CDbl(TxtM2.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub TxtcantM2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtcantM2.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtcantM1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtcantM1.TextChanged
        If TxtcantM1.Text = "" Or TxtcantM1.Text = "0" Then
            TxtM1.Text = "0"
            M1 = 0
        Else
            TxtM1.Text = TxtcantM1.Text * 1
            M1 = CDbl(TxtM1.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub TxtcantM1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtcantM1.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtcantM50_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtcantM50.TextChanged
        If TxtcantM50.Text = "" Or TxtcantM50.Text = "0" Then
            TxtM50.Text = "0"
            M50 = 0
        Else
            TxtM50.Text = TxtcantM50.Text * 0.5
            M50 = CDbl(TxtM50.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub TxtcantM50_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtcantM50.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtcantM25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtcantM25.TextChanged
        If TxtcantM25.Text = "" Or TxtcantM25.Text = "0" Then
            TxtM25.Text = "0"
            M25 = 0
        Else
            TxtM25.Text = TxtcantM25.Text * 0.25
            M25 = CDbl(TxtM25.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub TxtcantM25_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtcantM25.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtcantM10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtcantM10.TextChanged
        If TxtcantM10.Text = "" Or TxtcantM10.Text = "0" Then
            TxtM10.Text = "0"
            M10 = 0
        Else
            TxtM10.Text = TxtcantM10.Text * 0.1
            M10 = CDbl(TxtM10.Text)
        End If
        sumarArqueo()
    End Sub

    Private Sub TxtcantM10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtcantM10.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtTotalArqueo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalArqueo.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtCierre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCierre.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub sumarArqueo()
        totalArqueo = (B1000 + B500 + B200 + B100 + B50 + B20 + B10 + B5 + M2 + M1 + M50 + M25 + M10)
        TxtTotalArqueo.Text = totalArqueo.ToString
        calcularCierre()
    End Sub

    Private Sub calcularCierre()
        Dim cierre, saldo As Decimal
        saldo = CDbl(frmCaja.TxtSaldo.Text)

        cierre = (totalArqueo - saldo)
        TxtCierre.Text = cierre.ToString

        If cierre < 0 Then
            TextBoxCierre.ForeColor = Color.Red
            TextBoxCierre.ForeColor = Color.Red
            TextBoxCierre.Text = "FALTANTE"

        ElseIf cierre > 0 Then
            TextBoxCierre.ForeColor = Color.Black
            TextBoxCierre.Text = "SOBRANTE"

        ElseIf cierre = 0 Then
            TextBoxCierre.ForeColor = Color.Green
            TextBoxCierre.Text = "CIERRE EXACTO"
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        flag = "C"
    End Sub

End Class