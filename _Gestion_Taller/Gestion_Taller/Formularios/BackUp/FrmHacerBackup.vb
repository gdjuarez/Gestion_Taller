Imports System.IO

Public Class FrmHacerBackup

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
        TextBox1.Text += Environment.NewLine & "Bienvenido!" & Environment.NewLine & "Vamos a realizar la copia de seguridad de su base de datos..."

        
    End Sub

    Private Sub BtnRealizaBCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRealizaBCK.Click
      
        'Define the variables
        Dim dbfullpath As String = ""
        Dim DbFile As String
        'Nombre base de datos
        dbname = "gestion_taller"

        'Change the MySQL Working directory here if required. Find the right directory and replace here. 
        'example: it could be mysqldirectory = "C:\Program Files\MySQL\MySQL Server 5.5\bin\"
        mysqldirectory = "C:\Program Files\MySQL\MySQL Server 5.5\bin\"

        'check if the mysqldirectory exists
        Try
            If Not Directory.Exists(mysqldirectory) Then
                TextBox1.Text += Environment.NewLine
                TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                TextBox1.Text += Environment.NewLine & "Nos es imposible encontrar el directoro de MySQL en: " & mysqldirectory
                TextBox1.Text += Environment.NewLine & "Nos es imposible seguir."

                'program will auto exit as per the timer specified. No need to include application exit here
            Else
                'If MySQL installation directory is found, continue
                'Change the DB backup file name if required here
                DbFile = "MYSQL_BACKUP-" + dbname & "-" & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
                'MsgBox(DbFile)
                'Append date and time to MySQL backup file
                dbfullpath = bkpath & DbFile

                'Check if C:\MYSQLBACKUPS folder exists. and if not then create
                Try
                    If Not Directory.Exists(bkpath) Then

                        TextBox1.Text += Environment.NewLine
                        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                        TextBox1.Text += Environment.NewLine & "No podemos encontrar la carpeta""" + bkpath + """. Creando la carpeta."

                        Directory.CreateDirectory(bkpath)

                        TextBox1.Text += Environment.NewLine
                        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                        TextBox1.Text += Environment.NewLine & "Carpeta creada. Las copias de seguridad se almacenarán en  """ + bkpath + """ "
                    Else
                        TextBox1.Text += Environment.NewLine
                        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                        TextBox1.Text += Environment.NewLine & " """ + bkpath + """ la carpeta ya existe. Las copias de seguridad se almacenarán en """ + bkpath + """ "

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

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
                TextBox1.Text += Environment.NewLine & "Intentando hacer una copia de seguridad y guardar en la carpeta """ + bkpath + """."

                Try
                    Dim sentencia As String = ""
                    sentencia = "mysqldump --routines -hlocalhost -P3307 -uGiFSys -pGiFSys1502 --databases " & dbname & " > """ + dbfullpath + """"

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

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnVBCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVBCK.Click
        Process.Start("explorer.exe", bkpath)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


End Class
