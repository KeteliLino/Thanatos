Module banco_dados
    Public query As String
    Public db As ADODB.Connection 'Variavel do banco
    Public rs As ADODB.Recordset 'Variavel das tabelas

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=bd_thanatos;UID=root;PWD=usbw;port=6060;option3;")
            MsgBox("ConexÃ£o Ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
