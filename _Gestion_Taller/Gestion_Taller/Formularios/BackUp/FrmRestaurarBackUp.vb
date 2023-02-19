Imports System.IO

Public Class FrmRestaurarBackUp

    Dim dbname As String

    'Change the backup directory here if required.
    Dim bkpath As String = "C:\MYSQLBACKUPS\"

    'Working directory of my sql
    Dim mysqldirectory As String

    Private Sub FrmHacerBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Display Welcome Message in the form's textbox
        TextBox1.Text = "Mensajes:"
        TextBox1.Text += Environment.NewLine
        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
        TextBox1.Text += Environment.NewLine & "Bienvenido!" & Environment.NewLine & "Vamos a restaurar una copia de seguridad de su base de datos..."

    End Sub

    Private Sub BtnRealizaBCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRealizaBCK.Click

        Dim resultado As DialogResult = MessageBox.Show("Se restaurara una copia de su base de datos." & vbNewLine &
                                                        "-----------------------------------" & vbNewLine &
                                                        "CUIDADO, se sobre BORRARA su base actual.", "Atención", MessageBoxButtons.YesNo)

        If resultado = Windows.Forms.DialogResult.Yes Then

            'Define the variables
            Dim dbfullpath As String = ""
            'Nombre base de datos
            dbname = "gestion_taller"

            'MsgBox("Buscar archivo")
            Dim myStream As Stream = Nothing
            Dim openFileDialog1 As New OpenFileDialog With {
                .InitialDirectory = "C:\MYSQLBACKUPS",
                .Filter = "sql files (*.sql)|*.sql",
                .FilterIndex = 2,
                .RestoreDirectory = True
            }

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    myStream = openFileDialog1.OpenFile()
                    If (myStream IsNot Nothing) Then

                        'aca hay que atrapar la direccion y el nombre del archivo para restaurar y grabarloen la variable dbfullpth
                        Dim FileName As String
                        FileName = openFileDialog1.FileName
                        dbfullpath = FileName
                        'MsgBox(FileName)

                    End If
                Catch Ex As Exception
                    MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
                Finally
                    ' Check this again, since we need to make sure we didn't throw an exception on open.
                    If (myStream IsNot Nothing) Then
                        myStream.Close()
                    End If
                End Try
            End If


            'Change the MySQL Working directory here if required. Find the right directory and replace here. 
            'example: it could be mysqldirectory = "C:\Program Files\MySQL\MySQL Server 5.5\bin\"
            mysqldirectory = "C:\Program Files\MySQL\MySQL Server 5.5\bin\"

            'check if the mysqldirectory exists
            Try

                'Start a new process to run Command Prompt
                Dim BackupProcess As New Process

                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.UseShellExecute = False
                BackupProcess.StartInfo.WorkingDirectory = mysqldirectory
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True

                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamreader As StreamReader = BackupProcess.StandardOutput

                TextBox1.Text += Environment.NewLine
                TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                TextBox1.Text += Environment.NewLine & "Intentando restaurar una copia de seguridad guardada en la carpeta """ + bkpath + """."

                Try
                    Dim sentencia As String = ""
                    sentencia = "mysql -hlocalhost -P3307 -uGiFSys -pGiFSys1502  " & dbname & " < """ + dbfullpath + """"

                    'MsgBox(sentencia)

                    BackupStream.WriteLine(sentencia)

                    TextBox1.Text += Environment.NewLine
                    TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                    TextBox1.Text += Environment.NewLine & "Copia de seguridad creada con éxito. Haga clic en 'Ver Back ups' para ver."

                Catch ex As Exception
                    MsgBox("Se produjo un error. MySQL puede no estar instalado o DB no encontrado. Contacte al  Administrador.")

                End Try

                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else

            'MsgBox("Proceso anulado por el usuario")

            End If

    End Sub

    Private Sub BtnVBCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVBCK.Click
        Process.Start("explorer.exe", bkpath)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class