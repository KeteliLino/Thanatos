Module Module1
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection 'Variavel do banco
    Public rs As New ADODB.Recordset  'Variavel das tabelas
    Public cont As Integer

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=cad_clientes;UID=root;PWD=usbw;port=3307;option3;")
            MsgBox("Conexão Ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module

