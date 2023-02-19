Module Module1
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    ' función que retorna el total de una columna 
    Public Function Sumar(ByVal nombreColumna As String, ByVal Dgv As DataGridView) As Double

        Dim total As Decimal = 0
        Dim i As Integer
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i = 0 To Dgv.RowCount - 1
                total = total + CDec(Dgv.Item(nombreColumna.ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function

   
End Module
