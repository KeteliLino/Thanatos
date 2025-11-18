Imports System.Drawing
Imports System.ComponentModel
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports System.Threading

Public Class frm_administrador
    Dim status, setor As String
    Dim cont As Integer
    Private ReadOnly materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

    Public Sub New()
        InitializeComponent()

        ' Evita executar quando o Visual Studio está no Designer
        If LicenseManager.UsageMode = LicenseUsageMode.Runtime Then
            ' Registra o form no MaterialSkinManager
            materialSkinManager.AddFormToManage(Me)

            ' Tema: LIGHT ou DARK
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK

            ' Color scheme (use HEX convertendo para Color)
            materialSkinManager.ColorScheme = New ColorScheme(
                ColorTranslator.FromHtml("#802790"), ' Primary
                ColorTranslator.FromHtml("#802790"), ' Dark Primary
                ColorTranslator.FromHtml("#FFFFFF"), ' Light Primary
                ColorTranslator.FromHtml("#802790"), ' Accent
                TextShade.WHITE)
            ' wire no construtor ou no Load:

        End If
    End Sub

    Private Sub frm_administrador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_dataCremacao.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txt_dataVelorio.Text = DateTime.Now.ToString("dd/MM/yyyy")
        If PictureBox3 IsNot Nothing Then
            PictureBox3.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.BorderStyle = BorderStyle.None
        End If
    End Sub
    Private Sub Voltar()
        frm_home.Show()
        Me.Hide()
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Voltar()
    End Sub

    Private Sub btn_voltar1_Click(sender As Object, e As EventArgs) Handles btn_voltar1.Click
        Voltar()
    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Voltar()
    End Sub

    Private Sub btn_voltar3_Click(sender As Object, e As EventArgs) Handles btn_voltar3.Click
        Voltar()
    End Sub

    Private Sub btn_voltar4_Click(sender As Object, e As EventArgs) Handles btn_voltar4.Click
        Voltar()
    End Sub

    Private Sub btn_voltar5_Click(sender As Object, e As EventArgs) Handles btn_voltar5.Click
        Voltar()
    End Sub

    Private Sub btn_voltar6_Click(sender As Object, e As EventArgs) Handles btn_voltar6.Click
        Voltar()
    End Sub

    Private Sub btn_incluirFuncionario_Click(sender As Object, e As EventArgs) Handles btn_incluirFuncionario.Click
        Try
            query = $"select * from tb_funcionarios where cpfFuncionario='{txt_cpfFuncionario.Text}'"
            rs = db.Execute(query)
            If rs.EOF = True Then
                query = $"insert into tb_funcionarios (cpfFuncionario,loginFuncionario,senhaFuncionario,nomeFuncionario,cepFuncionario,idStatus,idSetor) values (
                        '{txt_cpfFuncionario.Text}', '{txt_login.Text}', '{txt_senha.Text}','{txt_nomeFuncionario.Text}','{txt_cep.Text}', {status}, {setor});"
                rs = db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")

            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub carregar_dados()
        Try
            query = $"Select tb_funcionarios.cpfFuncionario, tb_funcionarios.loginFuncionario,tb_funcionarios.senhaFuncionario,tb_funcionarios.cepFuncionario, 
                    tb_status.descricaoStatus, tb_setores.descricaoSetor from tb_funcionarios inner join tb_status on tb_funcionarios.idStatus = tb_status.idStatus 
                    inner join tb_setores on tb_funcionarios.idSetor = tb_setores.idSetor"
            rs = db.Execute(query)
            With Me.dgv_funcionarios
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_administrador_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
        carregar_dados()
    End Sub

    Private Sub cmb_setor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_setor.SelectedValueChanged
        If cmb_setor.Text = "Administração" Then
            setor = "1"
        ElseIf cmb_setor.Text = "Financeiro" Then
            setor = "2"
        ElseIf cmb_setor.Text = "Recepção" Then
            setor = "3"
        End If
    End Sub

    Private Sub cmb_status_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_status.SelectedValueChanged
        If cmb_status.Text = "Ativo" Then
            status = "1"
        ElseIf cmb_status.Text = "Inativo" Then
            status = "2"
        End If
    End Sub
End Class