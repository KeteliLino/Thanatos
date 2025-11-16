Imports MaterialSkin

Public Class frm_login
    Public idFuncionario, nomeFuncionario, idSetor As String
    Private ReadOnly materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

    Public Sub New()
        InitializeComponent()

        ' Registra o form no MaterialSkinManager
        materialSkinManager.AddFormToManage(Me)

        ' Tema: LIGHT ou DARK
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK

        ' Exemplo: usando hex diretamente via ColorTranslator.FromHtml
        materialSkinManager.ColorScheme = New ColorScheme(
            ColorTranslator.FromHtml("#802790"), ' Primary
            ColorTranslator.FromHtml("#802790"), ' Dark Primary
            ColorTranslator.FromHtml("#FFFFFF"), ' Light Primary
            ColorTranslator.FromHtml("#802790"), ' Accent
            TextShade.WHITE)
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        query = $"select * from tb_funcionarios where loginFuncionario= '{txt_login.Text}' and senhaFuncionario ='{txt_senha.Text}'"
        rs = db.Execute(query)
        If rs.EOF = False Then
            idFuncionario = rs.Fields(0).Value.ToString()
            nomeFuncionario = rs.Fields(3).Value.ToString()
            idSetor = rs.Fields(6).Value.ToString()
            frm_home.Show()
            txt_login.Clear()
            txt_senha.Clear()
            Me.Hide()
        Else
            MsgBox("Login ou Senha incorretos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub



    Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
        If chk_visualizar.Checked Then
            ' Mostrar senha
            txt_senha.UseSystemPasswordChar = False
            txt_senha.PasswordChar = ChrW(0)
        Else
            ' Ocultar senha
            txt_senha.UseSystemPasswordChar = True
            txt_senha.PasswordChar = ChrW(9679) ' bolinha preta
        End If
    End Sub

    Private Sub frm_login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If PictureBox1 IsNot Nothing Then
            PictureBox1.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.None
        End If
    End Sub
End Class