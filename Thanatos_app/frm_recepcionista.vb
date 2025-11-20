Imports System.Drawing
Imports MaterialSkin
Imports MaterialSkin.Controls
Public Class frm_recepcionista
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

    Private Sub frm_recepcionista_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txt_data1.Text = DateTime.Now.ToString("dd/MM/yyyy")
        If PictureBox5 IsNot Nothing Then
            PictureBox5.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox5.BorderStyle = BorderStyle.None
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

    Private Sub frm_recepcionista_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
        carregar_dados_cremacao(Me.dgv_cremacao)
        carregar_dados_velorio(Me.dgv_velorio)
        carregar_dados_falecido(Me.dgv_falecido)
        carregar_dados_jazigo(Me.dgv_jazigo)
    End Sub

End Class