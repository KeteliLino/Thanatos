Imports MaterialSkin

Public Class frm_login
    Public idFuncionario, nomeFuncionario As String
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
        ' editando picture box
        If PictureBox1 IsNot Nothing Then
            PictureBox1.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        'query = $"select * from tb_funcionarios where login= '{txt_login.Text}' and senha ='{txt_senha.Text}'"
        'rs = db.Execute(query)
        'If rs.EOF = False Then
        'idFuncionario = rs.Fields(0).Value.ToString()
        'nomeFuncionario = rs.Fields(4).Value.ToString()

        '   frm_menu.Show()
        '   Me.Hide()
        'Else
        '   MsgBox("Login ou Senha incorretos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End If
        If txt_login.Text = "a" And txt_senha.Text = "a" Then
            frm_home.Show()
            Me.Hide()
        Else
            MsgBox("Login ou Senha incorretos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If


    End Sub
End Class